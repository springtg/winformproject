using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
//using Lassalle.Flow;

namespace FlexMold.Master
{
	public class Form_PB_Model : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리 

		private C1.Win.C1Command.C1OutBar obar_Main;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1OutPage obarpg_ModelMold;
		public System.Windows.Forms.PictureBox pictureBox24;  
		private C1.Win.C1List.C1Combo c1Combo1; 
		public System.Windows.Forms.PictureBox pictureBox58;
		public System.Windows.Forms.PictureBox pictureBox59;
		public System.Windows.Forms.PictureBox pictureBox60; 
		public System.Windows.Forms.PictureBox pictureBox61;
		public System.Windows.Forms.PictureBox pictureBox62;
		public System.Windows.Forms.PictureBox pictureBox63;
		public System.Windows.Forms.PictureBox pictureBox64;
		public System.Windows.Forms.PictureBox pictureBox65; 
		public System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		public System.Windows.Forms.PictureBox pictureBox50;
		public System.Windows.Forms.PictureBox pictureBox51;
		public System.Windows.Forms.PictureBox pictureBox52;
		public System.Windows.Forms.Label label14;
		public System.Windows.Forms.PictureBox pictureBox53;
		public System.Windows.Forms.PictureBox pictureBox54;
		public System.Windows.Forms.PictureBox pictureBox55;
		public System.Windows.Forms.PictureBox pictureBox56;
		public System.Windows.Forms.PictureBox pictureBox57;
		private System.Windows.Forms.Panel pnl_MM;
		private System.Windows.Forms.Panel pnl_MMTR;
		private System.Windows.Forms.Splitter splitter4;
		public COM.FSP fgrid_ModelOpCd;
		public COM.FSP fgrid_Mold;
		private System.Windows.Forms.Panel panel8;
		public System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.TextBox txt_TypeName;
		private System.Windows.Forms.TextBox txt_MoldPart;
		private System.Windows.Forms.Label lbl_MoldPart;
		public System.Windows.Forms.PictureBox pictureBox42;
		public System.Windows.Forms.PictureBox pictureBox43;
		public System.Windows.Forms.PictureBox pictureBox44;
		public System.Windows.Forms.PictureBox pictureBox45;
		public System.Windows.Forms.PictureBox pictureBox46;
		public System.Windows.Forms.PictureBox pictureBox47;
		public System.Windows.Forms.PictureBox pictureBox48;
		public System.Windows.Forms.Label lbl_SubTitle8;
		public System.Windows.Forms.PictureBox pictureBox49;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Panel pnl_Body;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.Panel pnl_MMBodyLeftTopImage;
		private C1.Win.C1List.C1Combo cmb_MMMold;
		private System.Windows.Forms.Label lbl_MMMold;
		private C1.Win.C1List.C1Combo cmb_MMGen;
		private System.Windows.Forms.Label lbl_MMGen;
		private C1.Win.C1List.C1Combo cmb_MMModel;
		private System.Windows.Forms.Label lbl_MMModel;
		private C1.Win.C1List.C1Combo cmb_MMFactory;
		public System.Windows.Forms.PictureBox pictureBox34;
		private System.Windows.Forms.Label lbl_MMFactory;
		public System.Windows.Forms.PictureBox pictureBox38;
		public System.Windows.Forms.PictureBox pictureBox39;
		public System.Windows.Forms.Label lbl_SubTitle7;
		public System.Windows.Forms.PictureBox pictureBox35;
		public System.Windows.Forms.PictureBox pictureBox41;
		private System.Windows.Forms.Panel pnl_MMBodyLeftTop;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.TextBox txt_Model; 
		private System.ComponentModel.IContainer components = null;

		public Form_PB_Model()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Model));
			this.obar_Main = new C1.Win.C1Command.C1OutBar();
			this.obarpg_ModelMold = new C1.Win.C1Command.C1OutPage();
			this.pnl_MM = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.fgrid_ModelOpCd = new COM.FSP();
			this.pnl_MMBodyLeftTop = new System.Windows.Forms.Panel();
			this.pnl_MMBodyLeftTopImage = new System.Windows.Forms.Panel();
			this.txt_Model = new System.Windows.Forms.TextBox();
			this.cmb_MMMold = new C1.Win.C1List.C1Combo();
			this.lbl_MMMold = new System.Windows.Forms.Label();
			this.cmb_MMGen = new C1.Win.C1List.C1Combo();
			this.lbl_MMGen = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.cmb_MMModel = new C1.Win.C1List.C1Combo();
			this.lbl_MMModel = new System.Windows.Forms.Label();
			this.cmb_MMFactory = new C1.Win.C1List.C1Combo();
			this.pictureBox34 = new System.Windows.Forms.PictureBox();
			this.lbl_MMFactory = new System.Windows.Forms.Label();
			this.pictureBox38 = new System.Windows.Forms.PictureBox();
			this.pictureBox39 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle7 = new System.Windows.Forms.Label();
			this.pictureBox35 = new System.Windows.Forms.PictureBox();
			this.pictureBox41 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.splitter4 = new System.Windows.Forms.Splitter();
			this.pnl_MMTR = new System.Windows.Forms.Panel();
			this.fgrid_Mold = new COM.FSP();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txt_TypeName = new System.Windows.Forms.TextBox();
			this.txt_MoldPart = new System.Windows.Forms.TextBox();
			this.lbl_MoldPart = new System.Windows.Forms.Label();
			this.pictureBox42 = new System.Windows.Forms.PictureBox();
			this.pictureBox43 = new System.Windows.Forms.PictureBox();
			this.pictureBox44 = new System.Windows.Forms.PictureBox();
			this.pictureBox45 = new System.Windows.Forms.PictureBox();
			this.pictureBox46 = new System.Windows.Forms.PictureBox();
			this.pictureBox47 = new System.Windows.Forms.PictureBox();
			this.pictureBox48 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle8 = new System.Windows.Forms.Label();
			this.pictureBox49 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.c1Combo1 = new C1.Win.C1List.C1Combo();
			this.pictureBox58 = new System.Windows.Forms.PictureBox();
			this.pictureBox59 = new System.Windows.Forms.PictureBox();
			this.pictureBox60 = new System.Windows.Forms.PictureBox();
			this.pictureBox61 = new System.Windows.Forms.PictureBox();
			this.pictureBox62 = new System.Windows.Forms.PictureBox();
			this.pictureBox63 = new System.Windows.Forms.PictureBox();
			this.pictureBox64 = new System.Windows.Forms.PictureBox();
			this.pictureBox65 = new System.Windows.Forms.PictureBox();
			this.panel10 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.pictureBox50 = new System.Windows.Forms.PictureBox();
			this.pictureBox51 = new System.Windows.Forms.PictureBox();
			this.pictureBox52 = new System.Windows.Forms.PictureBox();
			this.label14 = new System.Windows.Forms.Label();
			this.pictureBox53 = new System.Windows.Forms.PictureBox();
			this.pictureBox54 = new System.Windows.Forms.PictureBox();
			this.pictureBox55 = new System.Windows.Forms.PictureBox();
			this.pictureBox56 = new System.Windows.Forms.PictureBox();
			this.pictureBox57 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
			this.obar_Main.SuspendLayout();
			this.obarpg_ModelMold.SuspendLayout();
			this.pnl_MM.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ModelOpCd)).BeginInit();
			this.pnl_MMBodyLeftTop.SuspendLayout();
			this.pnl_MMBodyLeftTopImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MMMold)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MMGen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MMModel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MMFactory)).BeginInit();
			this.pnl_MMTR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).BeginInit();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
			this.panel10.SuspendLayout();
			this.pnl_Body.SuspendLayout();
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
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
			// 
			// tbtn_Insert
			// 
			this.tbtn_Insert.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Insert_Click);
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
			// obar_Main
			// 
			this.obar_Main.BackColor = System.Drawing.SystemColors.Window;
			this.obar_Main.Controls.Add(this.obarpg_ModelMold);
			this.obar_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.obar_Main.Location = new System.Drawing.Point(8, 0);
			this.obar_Main.Name = "obar_Main";
			this.obar_Main.Pages.Add(this.obarpg_ModelMold);
			this.obar_Main.Size = new System.Drawing.Size(1000, 584);
			this.obar_Main.Text = "c1OutBar1";
			this.obar_Main.SelectedPageChanged += new System.EventHandler(this.obar_Main_SelectedPageChanged);
			// 
			// obarpg_ModelMold
			// 
			this.obarpg_ModelMold.Controls.Add(this.pnl_MM);
			this.obarpg_ModelMold.Location = new System.Drawing.Point(0, 20);
			this.obarpg_ModelMold.Name = "obarpg_ModelMold";
			this.obarpg_ModelMold.Size = new System.Drawing.Size(1000, 544);
			this.obarpg_ModelMold.TabIndex = 1;
			this.obarpg_ModelMold.Text = "Model Mold Information";
			// 
			// pnl_MM
			// 
			this.pnl_MM.Controls.Add(this.pictureBox4);
			this.pnl_MM.Controls.Add(this.pictureBox6);
			this.pnl_MM.Controls.Add(this.fgrid_ModelOpCd);
			this.pnl_MM.Controls.Add(this.pnl_MMBodyLeftTop);
			this.pnl_MM.Controls.Add(this.splitter4);
			this.pnl_MM.Controls.Add(this.pnl_MMTR);
			this.pnl_MM.DockPadding.All = 8;
			this.pnl_MM.Location = new System.Drawing.Point(0, 0);
			this.pnl_MM.Name = "pnl_MM";
			this.pnl_MM.Size = new System.Drawing.Size(1000, 544);
			this.pnl_MM.TabIndex = 38;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(8, 16);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(8, 64);
			this.pictureBox4.TabIndex = 118;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(-24, 88);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(20, 40);
			this.pictureBox6.TabIndex = 117;
			this.pictureBox6.TabStop = false;
			// 
			// fgrid_ModelOpCd
			// 
			this.fgrid_ModelOpCd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fgrid_ModelOpCd.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_ModelOpCd.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_ModelOpCd.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_ModelOpCd.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_ModelOpCd.Location = new System.Drawing.Point(8, 104);
			this.fgrid_ModelOpCd.Name = "fgrid_ModelOpCd";
			this.fgrid_ModelOpCd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_ModelOpCd.Size = new System.Drawing.Size(624, 432);
			this.fgrid_ModelOpCd.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_ModelOpCd.TabIndex = 48;
			this.fgrid_ModelOpCd.Click += new System.EventHandler(this.fgrid_ModelOpCd_Click);
			this.fgrid_ModelOpCd.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_ModelOpCd_BeforeEdit);
			this.fgrid_ModelOpCd.DoubleClick += new System.EventHandler(this.fgrid_ModelOpCd_DoubleClick);
			this.fgrid_ModelOpCd.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_ModelOpCd_AfterEdit);
			// 
			// pnl_MMBodyLeftTop
			// 
			this.pnl_MMBodyLeftTop.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_MMBodyLeftTop.Controls.Add(this.pnl_MMBodyLeftTopImage);
			this.pnl_MMBodyLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_MMBodyLeftTop.DockPadding.Bottom = 5;
			this.pnl_MMBodyLeftTop.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_MMBodyLeftTop.Location = new System.Drawing.Point(8, 8);
			this.pnl_MMBodyLeftTop.Name = "pnl_MMBodyLeftTop";
			this.pnl_MMBodyLeftTop.Size = new System.Drawing.Size(625, 96);
			this.pnl_MMBodyLeftTop.TabIndex = 5;
			// 
			// pnl_MMBodyLeftTopImage
			// 
			this.pnl_MMBodyLeftTopImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.txt_Model);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.cmb_MMMold);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.lbl_MMMold);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.cmb_MMGen);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.lbl_MMGen);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.cmb_MMModel);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.lbl_MMModel);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.cmb_MMFactory);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox34);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.lbl_MMFactory);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox38);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox39);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.lbl_SubTitle7);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox35);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox41);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox2);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox1);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox3);
			this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox9);
			this.pnl_MMBodyLeftTopImage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_MMBodyLeftTopImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_MMBodyLeftTopImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_MMBodyLeftTopImage.Name = "pnl_MMBodyLeftTopImage";
			this.pnl_MMBodyLeftTopImage.Size = new System.Drawing.Size(625, 152);
			this.pnl_MMBodyLeftTopImage.TabIndex = 21;
			// 
			// txt_Model
			// 
			this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Model.Location = new System.Drawing.Point(61, 64);
			this.txt_Model.Name = "txt_Model";
			this.txt_Model.Size = new System.Drawing.Size(163, 22);
			this.txt_Model.TabIndex = 121;
			this.txt_Model.Text = "";
			this.txt_Model.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Model_KeyDown);
			// 
			// cmb_MMMold
			// 
			this.cmb_MMMold.AddItemCols = 0;
			this.cmb_MMMold.AddItemSeparator = ';';
			this.cmb_MMMold.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_MMMold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_MMMold.Caption = "";
			this.cmb_MMMold.CaptionHeight = 17;
			this.cmb_MMMold.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_MMMold.ColumnCaptionHeight = 18;
			this.cmb_MMMold.ColumnFooterHeight = 18;
			this.cmb_MMMold.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_MMMold.ContentHeight = 17;
			this.cmb_MMMold.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_MMMold.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_MMMold.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MMMold.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_MMMold.EditorHeight = 17;
			this.cmb_MMMold.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MMMold.GapHeight = 2;
			this.cmb_MMMold.ItemHeight = 15;
			this.cmb_MMMold.Location = new System.Drawing.Point(448, 0);
			this.cmb_MMMold.MatchEntryTimeout = ((long)(2000));
			this.cmb_MMMold.MaxDropDownItems = ((short)(5));
			this.cmb_MMMold.MaxLength = 32767;
			this.cmb_MMMold.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_MMMold.Name = "cmb_MMMold";
			this.cmb_MMMold.PartialRightColumn = false;
			this.cmb_MMMold.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_MMMold.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_MMMold.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_MMMold.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_MMMold.Size = new System.Drawing.Size(150, 21);
			this.cmb_MMMold.TabIndex = 32;
			this.cmb_MMMold.Visible = false;
			this.cmb_MMMold.SelectedValueChanged += new System.EventHandler(this.cmb_MMMold_SelectedValueChanged);
			// 
			// lbl_MMMold
			// 
			this.lbl_MMMold.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_MMMold.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MMMold.ImageIndex = 0;
			this.lbl_MMMold.ImageList = this.img_Label;
			this.lbl_MMMold.Location = new System.Drawing.Point(352, 0);
			this.lbl_MMMold.Name = "lbl_MMMold";
			this.lbl_MMMold.Size = new System.Drawing.Size(100, 21);
			this.lbl_MMMold.TabIndex = 31;
			this.lbl_MMMold.Text = "몰드 공정 여부";
			this.lbl_MMMold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_MMMold.Visible = false;
			// 
			// cmb_MMGen
			// 
			this.cmb_MMGen.AddItemCols = 0;
			this.cmb_MMGen.AddItemSeparator = ';';
			this.cmb_MMGen.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_MMGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_MMGen.Caption = "";
			this.cmb_MMGen.CaptionHeight = 17;
			this.cmb_MMGen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_MMGen.ColumnCaptionHeight = 18;
			this.cmb_MMGen.ColumnFooterHeight = 18;
			this.cmb_MMGen.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_MMGen.ContentHeight = 17;
			this.cmb_MMGen.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_MMGen.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_MMGen.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MMGen.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_MMGen.EditorHeight = 17;
			this.cmb_MMGen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MMGen.GapHeight = 2;
			this.cmb_MMGen.ItemHeight = 15;
			this.cmb_MMGen.Location = new System.Drawing.Point(533, 64);
			this.cmb_MMGen.MatchEntryTimeout = ((long)(2000));
			this.cmb_MMGen.MaxDropDownItems = ((short)(5));
			this.cmb_MMGen.MaxLength = 32767;
			this.cmb_MMGen.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_MMGen.Name = "cmb_MMGen";
			this.cmb_MMGen.PartialRightColumn = false;
			this.cmb_MMGen.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_MMGen.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_MMGen.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_MMGen.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_MMGen.Size = new System.Drawing.Size(80, 21);
			this.cmb_MMGen.TabIndex = 32;
			this.cmb_MMGen.SelectedValueChanged += new System.EventHandler(this.cmb_MMGen_SelectedValueChanged);
			// 
			// lbl_MMGen
			// 
			this.lbl_MMGen.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_MMGen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MMGen.ImageIndex = 0;
			this.lbl_MMGen.ImageList = this.img_SmallLabel;
			this.lbl_MMGen.Location = new System.Drawing.Point(480, 64);
			this.lbl_MMGen.Name = "lbl_MMGen";
			this.lbl_MMGen.Size = new System.Drawing.Size(50, 21);
			this.lbl_MMGen.TabIndex = 31;
			this.lbl_MMGen.Text = "Gender";
			this.lbl_MMGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// cmb_MMModel
			// 
			this.cmb_MMModel.AddItemCols = 0;
			this.cmb_MMModel.AddItemSeparator = ';';
			this.cmb_MMModel.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_MMModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_MMModel.Caption = "";
			this.cmb_MMModel.CaptionHeight = 17;
			this.cmb_MMModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_MMModel.ColumnCaptionHeight = 18;
			this.cmb_MMModel.ColumnFooterHeight = 18;
			this.cmb_MMModel.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_MMModel.ContentHeight = 17;
			this.cmb_MMModel.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_MMModel.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_MMModel.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MMModel.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_MMModel.EditorHeight = 17;
			this.cmb_MMModel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MMModel.GapHeight = 2;
			this.cmb_MMModel.ItemHeight = 15;
			this.cmb_MMModel.Location = new System.Drawing.Point(227, 65);
			this.cmb_MMModel.MatchEntryTimeout = ((long)(2000));
			this.cmb_MMModel.MaxDropDownItems = ((short)(5));
			this.cmb_MMModel.MaxLength = 32767;
			this.cmb_MMModel.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_MMModel.Name = "cmb_MMModel";
			this.cmb_MMModel.PartialRightColumn = false;
			this.cmb_MMModel.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_MMModel.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_MMModel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_MMModel.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_MMModel.Size = new System.Drawing.Size(245, 21);
			this.cmb_MMModel.TabIndex = 30;
			this.cmb_MMModel.SelectedValueChanged += new System.EventHandler(this.cmb_MMModel_SelectedValueChanged);
			// 
			// lbl_MMModel
			// 
			this.lbl_MMModel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_MMModel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MMModel.ImageIndex = 0;
			this.lbl_MMModel.ImageList = this.img_SmallLabel;
			this.lbl_MMModel.Location = new System.Drawing.Point(11, 64);
			this.lbl_MMModel.Name = "lbl_MMModel";
			this.lbl_MMModel.Size = new System.Drawing.Size(50, 21);
			this.lbl_MMModel.TabIndex = 29;
			this.lbl_MMModel.Text = "Model";
			this.lbl_MMModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_MMFactory
			// 
			this.cmb_MMFactory.AddItemCols = 0;
			this.cmb_MMFactory.AddItemSeparator = ';';
			this.cmb_MMFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_MMFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_MMFactory.Caption = "";
			this.cmb_MMFactory.CaptionHeight = 17;
			this.cmb_MMFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_MMFactory.ColumnCaptionHeight = 18;
			this.cmb_MMFactory.ColumnFooterHeight = 18;
			this.cmb_MMFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_MMFactory.ContentHeight = 17;
			this.cmb_MMFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_MMFactory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_MMFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MMFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_MMFactory.EditorHeight = 17;
			this.cmb_MMFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MMFactory.GapHeight = 2;
			this.cmb_MMFactory.ItemHeight = 15;
			this.cmb_MMFactory.Location = new System.Drawing.Point(61, 36);
			this.cmb_MMFactory.MatchEntryTimeout = ((long)(2000));
			this.cmb_MMFactory.MaxDropDownItems = ((short)(5));
			this.cmb_MMFactory.MaxLength = 32767;
			this.cmb_MMFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_MMFactory.Name = "cmb_MMFactory";
			this.cmb_MMFactory.PartialRightColumn = false;
			this.cmb_MMFactory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_MMFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_MMFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_MMFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_MMFactory.Size = new System.Drawing.Size(163, 21);
			this.cmb_MMFactory.TabIndex = 33;
			this.cmb_MMFactory.SelectedValueChanged += new System.EventHandler(this.cmb_MMFactory_SelectedValueChanged);
			// 
			// pictureBox34
			// 
			this.pictureBox34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox34.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
			this.pictureBox34.Location = new System.Drawing.Point(608, 254);
			this.pictureBox34.Name = "pictureBox34";
			this.pictureBox34.Size = new System.Drawing.Size(17, 16);
			this.pictureBox34.TabIndex = 23;
			this.pictureBox34.TabStop = false;
			// 
			// lbl_MMFactory
			// 
			this.lbl_MMFactory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_MMFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MMFactory.ImageIndex = 0;
			this.lbl_MMFactory.ImageList = this.img_SmallLabel;
			this.lbl_MMFactory.Location = new System.Drawing.Point(10, 36);
			this.lbl_MMFactory.Name = "lbl_MMFactory";
			this.lbl_MMFactory.Size = new System.Drawing.Size(50, 21);
			this.lbl_MMFactory.TabIndex = 13;
			this.lbl_MMFactory.Text = "Factory";
			this.lbl_MMFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox38
			// 
			this.pictureBox38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox38.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
			this.pictureBox38.Location = new System.Drawing.Point(608, 0);
			this.pictureBox38.Name = "pictureBox38";
			this.pictureBox38.Size = new System.Drawing.Size(21, 32);
			this.pictureBox38.TabIndex = 21;
			this.pictureBox38.TabStop = false;
			// 
			// pictureBox39
			// 
			this.pictureBox39.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox39.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
			this.pictureBox39.Location = new System.Drawing.Point(224, 0);
			this.pictureBox39.Name = "pictureBox39";
			this.pictureBox39.Size = new System.Drawing.Size(625, 32);
			this.pictureBox39.TabIndex = 0;
			this.pictureBox39.TabStop = false;
			// 
			// lbl_SubTitle7
			// 
			this.lbl_SubTitle7.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle7.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle7.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle7.Image")));
			this.lbl_SubTitle7.Location = new System.Drawing.Point(0, -1);
			this.lbl_SubTitle7.Name = "lbl_SubTitle7";
			this.lbl_SubTitle7.Size = new System.Drawing.Size(231, 32);
			this.lbl_SubTitle7.TabIndex = 20;
			this.lbl_SubTitle7.Text = "      Model/ OpCd Info.";
			this.lbl_SubTitle7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox35
			// 
			this.pictureBox35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox35.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
			this.pictureBox35.Location = new System.Drawing.Point(0, 250);
			this.pictureBox35.Name = "pictureBox35";
			this.pictureBox35.Size = new System.Drawing.Size(240, 88);
			this.pictureBox35.TabIndex = 22;
			this.pictureBox35.TabStop = false;
			// 
			// pictureBox41
			// 
			this.pictureBox41.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox41.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox41.Image")));
			this.pictureBox41.Location = new System.Drawing.Point(0, 152);
			this.pictureBox41.Name = "pictureBox41";
			this.pictureBox41.Size = new System.Drawing.Size(288, 120);
			this.pictureBox41.TabIndex = 25;
			this.pictureBox41.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 73);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(168, 27);
			this.pictureBox2.TabIndex = 34;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(168, 75);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(440, 24);
			this.pictureBox1.TabIndex = 34;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(607, 77);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(25, 16);
			this.pictureBox3.TabIndex = 118;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(608, 32);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(32, 56);
			this.pictureBox9.TabIndex = 120;
			this.pictureBox9.TabStop = false;
			// 
			// splitter4
			// 
			this.splitter4.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter4.Location = new System.Drawing.Point(633, 8);
			this.splitter4.Name = "splitter4";
			this.splitter4.Size = new System.Drawing.Size(8, 528);
			this.splitter4.TabIndex = 4;
			this.splitter4.TabStop = false;
			// 
			// pnl_MMTR
			// 
			this.pnl_MMTR.Controls.Add(this.fgrid_Mold);
			this.pnl_MMTR.Controls.Add(this.panel8);
			this.pnl_MMTR.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnl_MMTR.DockPadding.Left = 5;
			this.pnl_MMTR.Location = new System.Drawing.Point(641, 8);
			this.pnl_MMTR.Name = "pnl_MMTR";
			this.pnl_MMTR.Size = new System.Drawing.Size(351, 528);
			this.pnl_MMTR.TabIndex = 3;
			// 
			// fgrid_Mold
			// 
			this.fgrid_Mold.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fgrid_Mold.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromCursor;
			this.fgrid_Mold.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Mold.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Mold.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Mold.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Mold.Location = new System.Drawing.Point(5, 96);
			this.fgrid_Mold.Name = "fgrid_Mold";
			this.fgrid_Mold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Mold.Size = new System.Drawing.Size(346, 432);
			this.fgrid_Mold.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Mold.TabIndex = 49;
			this.fgrid_Mold.DoubleClick += new System.EventHandler(this.fgrid_Mold_DoubleClick);
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.SystemColors.Window;
			this.panel8.Controls.Add(this.panel9);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.DockPadding.Bottom = 5;
			this.panel8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel8.Location = new System.Drawing.Point(5, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(346, 96);
			this.panel8.TabIndex = 6;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.SystemColors.Window;
			this.panel9.Controls.Add(this.txt_TypeName);
			this.panel9.Controls.Add(this.txt_MoldPart);
			this.panel9.Controls.Add(this.lbl_MoldPart);
			this.panel9.Controls.Add(this.pictureBox42);
			this.panel9.Controls.Add(this.pictureBox43);
			this.panel9.Controls.Add(this.pictureBox44);
			this.panel9.Controls.Add(this.pictureBox45);
			this.panel9.Controls.Add(this.pictureBox46);
			this.panel9.Controls.Add(this.pictureBox47);
			this.panel9.Controls.Add(this.pictureBox48);
			this.panel9.Controls.Add(this.lbl_SubTitle8);
			this.panel9.Controls.Add(this.pictureBox49);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(346, 91);
			this.panel9.TabIndex = 21;
			// 
			// txt_TypeName
			// 
			this.txt_TypeName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_TypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_TypeName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_TypeName.Location = new System.Drawing.Point(161, 36);
			this.txt_TypeName.MaxLength = 60;
			this.txt_TypeName.Name = "txt_TypeName";
			this.txt_TypeName.ReadOnly = true;
			this.txt_TypeName.Size = new System.Drawing.Size(150, 21);
			this.txt_TypeName.TabIndex = 113;
			this.txt_TypeName.Text = "";
			// 
			// txt_MoldPart
			// 
			this.txt_MoldPart.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_MoldPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_MoldPart.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_MoldPart.Location = new System.Drawing.Point(111, 36);
			this.txt_MoldPart.MaxLength = 60;
			this.txt_MoldPart.Name = "txt_MoldPart";
			this.txt_MoldPart.ReadOnly = true;
			this.txt_MoldPart.Size = new System.Drawing.Size(49, 21);
			this.txt_MoldPart.TabIndex = 112;
			this.txt_MoldPart.Text = "";
			// 
			// lbl_MoldPart
			// 
			this.lbl_MoldPart.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_MoldPart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MoldPart.ImageIndex = 0;
			this.lbl_MoldPart.ImageList = this.img_Label;
			this.lbl_MoldPart.Location = new System.Drawing.Point(10, 36);
			this.lbl_MoldPart.Name = "lbl_MoldPart";
			this.lbl_MoldPart.Size = new System.Drawing.Size(100, 21);
			this.lbl_MoldPart.TabIndex = 13;
			this.lbl_MoldPart.Text = "Mold";
			this.lbl_MoldPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox42
			// 
			this.pictureBox42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox42.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox42.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox42.Image")));
			this.pictureBox42.Location = new System.Drawing.Point(329, 75);
			this.pictureBox42.Name = "pictureBox42";
			this.pictureBox42.Size = new System.Drawing.Size(21, 16);
			this.pictureBox42.TabIndex = 23;
			this.pictureBox42.TabStop = false;
			// 
			// pictureBox43
			// 
			this.pictureBox43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox43.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox43.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox43.Image")));
			this.pictureBox43.Location = new System.Drawing.Point(0, 71);
			this.pictureBox43.Name = "pictureBox43";
			this.pictureBox43.Size = new System.Drawing.Size(168, 20);
			this.pictureBox43.TabIndex = 22;
			this.pictureBox43.TabStop = false;
			// 
			// pictureBox44
			// 
			this.pictureBox44.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox44.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox44.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox44.Image")));
			this.pictureBox44.Location = new System.Drawing.Point(330, 24);
			this.pictureBox44.Name = "pictureBox44";
			this.pictureBox44.Size = new System.Drawing.Size(20, 91);
			this.pictureBox44.TabIndex = 26;
			this.pictureBox44.TabStop = false;
			// 
			// pictureBox45
			// 
			this.pictureBox45.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox45.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox45.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox45.Image")));
			this.pictureBox45.Location = new System.Drawing.Point(131, 73);
			this.pictureBox45.Name = "pictureBox45";
			this.pictureBox45.Size = new System.Drawing.Size(346, 18);
			this.pictureBox45.TabIndex = 28;
			this.pictureBox45.TabStop = false;
			// 
			// pictureBox46
			// 
			this.pictureBox46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox46.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox46.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox46.Image")));
			this.pictureBox46.Location = new System.Drawing.Point(329, 0);
			this.pictureBox46.Name = "pictureBox46";
			this.pictureBox46.Size = new System.Drawing.Size(21, 32);
			this.pictureBox46.TabIndex = 21;
			this.pictureBox46.TabStop = false;
			// 
			// pictureBox47
			// 
			this.pictureBox47.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox47.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox47.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox47.Image")));
			this.pictureBox47.Location = new System.Drawing.Point(224, 0);
			this.pictureBox47.Name = "pictureBox47";
			this.pictureBox47.Size = new System.Drawing.Size(346, 32);
			this.pictureBox47.TabIndex = 0;
			this.pictureBox47.TabStop = false;
			// 
			// pictureBox48
			// 
			this.pictureBox48.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox48.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox48.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox48.Image")));
			this.pictureBox48.Location = new System.Drawing.Point(160, 24);
			this.pictureBox48.Name = "pictureBox48";
			this.pictureBox48.Size = new System.Drawing.Size(346, 91);
			this.pictureBox48.TabIndex = 27;
			this.pictureBox48.TabStop = false;
			// 
			// lbl_SubTitle8
			// 
			this.lbl_SubTitle8.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle8.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle8.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle8.Image")));
			this.lbl_SubTitle8.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle8.Name = "lbl_SubTitle8";
			this.lbl_SubTitle8.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle8.TabIndex = 20;
			this.lbl_SubTitle8.Text = "      Mold Info.";
			this.lbl_SubTitle8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox49
			// 
			this.pictureBox49.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox49.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox49.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox49.Image")));
			this.pictureBox49.Location = new System.Drawing.Point(0, 24);
			this.pictureBox49.Name = "pictureBox49";
			this.pictureBox49.Size = new System.Drawing.Size(168, 91);
			this.pictureBox49.TabIndex = 25;
			this.pictureBox49.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(0, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.TabIndex = 0;
			this.pictureBox5.TabStop = false;
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pictureBox24
			// 
			this.pictureBox24.Location = new System.Drawing.Point(0, 0);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.TabIndex = 0;
			this.pictureBox24.TabStop = false;
			// 
			// c1Combo1
			// 
			this.c1Combo1.AddItemCols = 0;
			this.c1Combo1.AddItemSeparator = ';';
			this.c1Combo1.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1Combo1.Caption = "";
			this.c1Combo1.CaptionHeight = 17;
			this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo1.ColumnCaptionHeight = 18;
			this.c1Combo1.ColumnFooterHeight = 18;
			this.c1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.c1Combo1.ContentHeight = 17;
			this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo1.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo1.EditorHeight = 17;
			this.c1Combo1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo1.GapHeight = 2;
			this.c1Combo1.ItemHeight = 15;
			this.c1Combo1.Location = new System.Drawing.Point(111, 36);
			this.c1Combo1.MatchEntryTimeout = ((long)(2000));
			this.c1Combo1.MaxDropDownItems = ((short)(5));
			this.c1Combo1.MaxLength = 32767;
			this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo1.Name = "c1Combo1";
			this.c1Combo1.PartialRightColumn = false;
			this.c1Combo1.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.c1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo1.Size = new System.Drawing.Size(210, 21);
			this.c1Combo1.TabIndex = 36;
			// 
			// pictureBox58
			// 
			this.pictureBox58.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox58.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox58.Image")));
			this.pictureBox58.Location = new System.Drawing.Point(334, 24);
			this.pictureBox58.Name = "pictureBox58";
			this.pictureBox58.Size = new System.Drawing.Size(15, 155);
			this.pictureBox58.TabIndex = 26;
			this.pictureBox58.TabStop = false;
			// 
			// pictureBox59
			// 
			this.pictureBox59.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox59.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox59.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox59.Image")));
			this.pictureBox59.Location = new System.Drawing.Point(333, 0);
			this.pictureBox59.Name = "pictureBox59";
			this.pictureBox59.Size = new System.Drawing.Size(16, 32);
			this.pictureBox59.TabIndex = 21;
			this.pictureBox59.TabStop = false;
			// 
			// pictureBox60
			// 
			this.pictureBox60.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox60.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox60.Image")));
			this.pictureBox60.Location = new System.Drawing.Point(216, 0);
			this.pictureBox60.Name = "pictureBox60";
			this.pictureBox60.Size = new System.Drawing.Size(351, 40);
			this.pictureBox60.TabIndex = 0;
			this.pictureBox60.TabStop = false;
			// 
			// pictureBox61
			// 
			this.pictureBox61.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox61.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox61.Image")));
			this.pictureBox61.Location = new System.Drawing.Point(160, 24);
			this.pictureBox61.Name = "pictureBox61";
			this.pictureBox61.Size = new System.Drawing.Size(349, 155);
			this.pictureBox61.TabIndex = 27;
			this.pictureBox61.TabStop = false;
			// 
			// pictureBox62
			// 
			this.pictureBox62.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox62.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox62.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox62.Image")));
			this.pictureBox62.Location = new System.Drawing.Point(333, 179);
			this.pictureBox62.Name = "pictureBox62";
			this.pictureBox62.Size = new System.Drawing.Size(16, 16);
			this.pictureBox62.TabIndex = 23;
			this.pictureBox62.TabStop = false;
			// 
			// pictureBox63
			// 
			this.pictureBox63.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox63.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox63.Image")));
			this.pictureBox63.Location = new System.Drawing.Point(144, 177);
			this.pictureBox63.Name = "pictureBox63";
			this.pictureBox63.Size = new System.Drawing.Size(349, 18);
			this.pictureBox63.TabIndex = 24;
			this.pictureBox63.TabStop = false;
			// 
			// pictureBox64
			// 
			this.pictureBox64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox64.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox64.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox64.Image")));
			this.pictureBox64.Location = new System.Drawing.Point(0, 175);
			this.pictureBox64.Name = "pictureBox64";
			this.pictureBox64.Size = new System.Drawing.Size(168, 20);
			this.pictureBox64.TabIndex = 22;
			this.pictureBox64.TabStop = false;
			// 
			// pictureBox65
			// 
			this.pictureBox65.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox65.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox65.Image")));
			this.pictureBox65.Location = new System.Drawing.Point(0, 24);
			this.pictureBox65.Name = "pictureBox65";
			this.pictureBox65.Size = new System.Drawing.Size(168, 155);
			this.pictureBox65.TabIndex = 25;
			this.pictureBox65.TabStop = false;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.SystemColors.Window;
			this.panel10.Controls.Add(this.textBox1);
			this.panel10.Controls.Add(this.textBox2);
			this.panel10.Controls.Add(this.textBox3);
			this.panel10.Controls.Add(this.textBox4);
			this.panel10.Controls.Add(this.label7);
			this.panel10.Controls.Add(this.textBox5);
			this.panel10.Controls.Add(this.label8);
			this.panel10.Controls.Add(this.label9);
			this.panel10.Controls.Add(this.label10);
			this.panel10.Controls.Add(this.textBox6);
			this.panel10.Controls.Add(this.textBox7);
			this.panel10.Controls.Add(this.textBox8);
			this.panel10.Controls.Add(this.textBox9);
			this.panel10.Controls.Add(this.textBox10);
			this.panel10.Controls.Add(this.label11);
			this.panel10.Controls.Add(this.label12);
			this.panel10.Controls.Add(this.label13);
			this.panel10.Controls.Add(this.pictureBox50);
			this.panel10.Controls.Add(this.pictureBox51);
			this.panel10.Controls.Add(this.pictureBox52);
			this.panel10.Controls.Add(this.label14);
			this.panel10.Controls.Add(this.pictureBox53);
			this.panel10.Controls.Add(this.pictureBox54);
			this.panel10.Controls.Add(this.pictureBox55);
			this.panel10.Controls.Add(this.pictureBox56);
			this.panel10.Controls.Add(this.pictureBox57);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel10.Location = new System.Drawing.Point(0, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(349, 175);
			this.panel10.TabIndex = 20;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Window;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.textBox1.Location = new System.Drawing.Point(177, 102);
			this.textBox1.MaxLength = 60;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(153, 21);
			this.textBox1.TabIndex = 108;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.textBox2.Location = new System.Drawing.Point(177, 80);
			this.textBox2.MaxLength = 60;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(153, 21);
			this.textBox2.TabIndex = 107;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.textBox3.Location = new System.Drawing.Point(111, 80);
			this.textBox3.MaxLength = 60;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(65, 21);
			this.textBox3.TabIndex = 106;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.Window;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.textBox4.Location = new System.Drawing.Point(111, 124);
			this.textBox4.MaxLength = 60;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(219, 21);
			this.textBox4.TabIndex = 105;
			this.textBox4.Text = "";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ImageIndex = 0;
			this.label7.ImageList = this.img_Label;
			this.label7.Location = new System.Drawing.Point(10, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 21);
			this.label7.TabIndex = 104;
			this.label7.Text = "표시순번";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.SystemColors.Window;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.textBox5.Location = new System.Drawing.Point(111, 102);
			this.textBox5.MaxLength = 60;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(65, 21);
			this.textBox5.TabIndex = 103;
			this.textBox5.Text = "";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ImageIndex = 0;
			this.label8.ImageList = this.img_Label;
			this.label8.Location = new System.Drawing.Point(10, 102);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 21);
			this.label8.TabIndex = 102;
			this.label8.Text = "몰드코드";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.ImageIndex = 0;
			this.label9.ImageList = this.img_MiniButton;
			this.label9.Location = new System.Drawing.Point(331, 146);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(21, 21);
			this.label9.TabIndex = 101;
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.ImageIndex = 0;
			this.label10.ImageList = this.img_Label;
			this.label10.Location = new System.Drawing.Point(10, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 21);
			this.label10.TabIndex = 99;
			this.label10.Text = "몰드유형";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.textBox6.Location = new System.Drawing.Point(177, 58);
			this.textBox6.MaxLength = 60;
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(153, 21);
			this.textBox6.TabIndex = 98;
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.textBox7.Location = new System.Drawing.Point(111, 58);
			this.textBox7.MaxLength = 60;
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(65, 21);
			this.textBox7.TabIndex = 97;
			this.textBox7.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.textBox8.Location = new System.Drawing.Point(177, 36);
			this.textBox8.MaxLength = 60;
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(153, 21);
			this.textBox8.TabIndex = 96;
			this.textBox8.Text = "";
			// 
			// textBox9
			// 
			this.textBox9.BackColor = System.Drawing.SystemColors.Window;
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.textBox9.Location = new System.Drawing.Point(111, 146);
			this.textBox9.MaxLength = 60;
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(210, 21);
			this.textBox9.TabIndex = 94;
			this.textBox9.Text = "";
			// 
			// textBox10
			// 
			this.textBox10.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.textBox10.Location = new System.Drawing.Point(111, 36);
			this.textBox10.MaxLength = 60;
			this.textBox10.Name = "textBox10";
			this.textBox10.ReadOnly = true;
			this.textBox10.Size = new System.Drawing.Size(65, 21);
			this.textBox10.TabIndex = 93;
			this.textBox10.Text = "";
			// 
			// label11
			// 
			this.label11.ImageIndex = 0;
			this.label11.ImageList = this.img_Label;
			this.label11.Location = new System.Drawing.Point(10, 146);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 21);
			this.label11.TabIndex = 41;
			this.label11.Text = "비고";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.ImageIndex = 0;
			this.label12.ImageList = this.img_Label;
			this.label12.Location = new System.Drawing.Point(10, 58);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 21);
			this.label12.TabIndex = 39;
			this.label12.Text = "반제품목";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.ImageIndex = 0;
			this.label13.ImageList = this.img_Label;
			this.label13.Location = new System.Drawing.Point(10, 36);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 21);
			this.label13.TabIndex = 38;
			this.label13.Text = "모델";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox50
			// 
			this.pictureBox50.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox50.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox50.Image")));
			this.pictureBox50.Location = new System.Drawing.Point(334, 24);
			this.pictureBox50.Name = "pictureBox50";
			this.pictureBox50.Size = new System.Drawing.Size(15, 135);
			this.pictureBox50.TabIndex = 26;
			this.pictureBox50.TabStop = false;
			// 
			// pictureBox51
			// 
			this.pictureBox51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox51.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox51.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox51.Image")));
			this.pictureBox51.Location = new System.Drawing.Point(333, 0);
			this.pictureBox51.Name = "pictureBox51";
			this.pictureBox51.Size = new System.Drawing.Size(16, 32);
			this.pictureBox51.TabIndex = 21;
			this.pictureBox51.TabStop = false;
			// 
			// pictureBox52
			// 
			this.pictureBox52.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox52.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox52.Image")));
			this.pictureBox52.Location = new System.Drawing.Point(216, 0);
			this.pictureBox52.Name = "pictureBox52";
			this.pictureBox52.Size = new System.Drawing.Size(351, 40);
			this.pictureBox52.TabIndex = 0;
			this.pictureBox52.TabStop = false;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.SystemColors.Window;
			this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.label14.ForeColor = System.Drawing.Color.Navy;
			this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
			this.label14.Location = new System.Drawing.Point(0, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(231, 30);
			this.label14.TabIndex = 20;
			this.label14.Text = "      Display Select Info.";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox53
			// 
			this.pictureBox53.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox53.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox53.Image")));
			this.pictureBox53.Location = new System.Drawing.Point(160, 24);
			this.pictureBox53.Name = "pictureBox53";
			this.pictureBox53.Size = new System.Drawing.Size(349, 135);
			this.pictureBox53.TabIndex = 27;
			this.pictureBox53.TabStop = false;
			// 
			// pictureBox54
			// 
			this.pictureBox54.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox54.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox54.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox54.Image")));
			this.pictureBox54.Location = new System.Drawing.Point(333, 159);
			this.pictureBox54.Name = "pictureBox54";
			this.pictureBox54.Size = new System.Drawing.Size(16, 16);
			this.pictureBox54.TabIndex = 23;
			this.pictureBox54.TabStop = false;
			// 
			// pictureBox55
			// 
			this.pictureBox55.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox55.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox55.Image")));
			this.pictureBox55.Location = new System.Drawing.Point(144, 157);
			this.pictureBox55.Name = "pictureBox55";
			this.pictureBox55.Size = new System.Drawing.Size(349, 18);
			this.pictureBox55.TabIndex = 24;
			this.pictureBox55.TabStop = false;
			// 
			// pictureBox56
			// 
			this.pictureBox56.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox56.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox56.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox56.Image")));
			this.pictureBox56.Location = new System.Drawing.Point(0, 155);
			this.pictureBox56.Name = "pictureBox56";
			this.pictureBox56.Size = new System.Drawing.Size(168, 20);
			this.pictureBox56.TabIndex = 22;
			this.pictureBox56.TabStop = false;
			// 
			// pictureBox57
			// 
			this.pictureBox57.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox57.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox57.Image")));
			this.pictureBox57.Location = new System.Drawing.Point(0, 24);
			this.pictureBox57.Name = "pictureBox57";
			this.pictureBox57.Size = new System.Drawing.Size(168, 135);
			this.pictureBox57.TabIndex = 25;
			this.pictureBox57.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.obar_Main);
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 56);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 584);
			this.pnl_Body.TabIndex = 29;
			// 
			// Form_PB_Model
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Name = "Form_PB_Model";
			this.Text = "Model Information";
			this.Load += new System.EventHandler(this.Form_PB_Model_Load);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
			this.obar_Main.ResumeLayout(false);
			this.obarpg_ModelMold.ResumeLayout(false);
			this.pnl_MM.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ModelOpCd)).EndInit();
			this.pnl_MMBodyLeftTop.ResumeLayout(false);
			this.pnl_MMBodyLeftTopImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_MMMold)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MMGen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MMModel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MMFactory)).EndInit();
			this.pnl_MMTR.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).EndInit();
			this.panel8.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
			this.panel10.ResumeLayout(false);
			this.pnl_Body.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

	 
		#region 변수 정의
    

		private COM.OraDB MyOraDB = new COM.OraDB();

		private DataTable HeadDT = new DataTable("HeadTitle");

		//노드 수 -> 공정에 링크 그릴때 필요
		private int _Node_Count = 0; 
		//새로 그려지는 공정 노드 수
		private int _Op_Count = 0;
		
		private int _Rowfixed; 

		#endregion  

		#region 멤버 메서드 
  

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			DataTable dt_ret;
			DataRow datarow;


			//Title
			this.Text = "Model Information";
			this.lbl_MainTitle.Text = "Model Information"; 


			ClassLib.ComFunction.SetLangDic(this);

			#region 버튼 권한

//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//			}
//			catch
//			{
//			}

			#endregion


//			cmb_MFactory.Enabled = false; 
//			cmb_MLMFactory.Enabled = false; 
//			cmb_MLLFactory.Enabled = false;
//			cmb_MLFactory.Enabled = false;
//			cmb_MMFactory.Enabled = false;
// 
  
 

			// 모델정보 
////			fgrid_MModelDetail.Set_Grid("SPB_MODEL_CODE", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);  
////			fgrid_MModelDetail.Set_Action_Image(img_Action);
//// 	 
////			ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
//// 
////			fgrid_BOM.Set_Grid("STANDARD_BOM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
////			fgrid_BOM.ExtendLastCol = true;
////			fgrid_BOM.Tree.Column = 1;  
////			_Rowfixed = fgrid_BOM.Rows.Fixed;
////
////			//숨겨진 그리드 세팅 
////			fgrid_BomNode.Set_Grid("NODE_BOM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
////			fgrid_BomLink.Set_Grid("LINK_BOM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
////			fgrid_NodeRout.Set_Grid("NODE_ROUT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
////			fgrid_LinkRout.Set_Grid("LINK_ROUT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
////
//// 
////			// 모델 라인 정보 
////			fgrid_MLModel.Set_Grid("SPB_MODEL_CODE", "3", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
////			fgrid_MLLine.Set_Grid("SPB_LINE_CODE", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  
////			fgrid_ModelLine.Set_Grid("SPB_MODEL_LINE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);  
////			fgrid_ModelLine.Set_Action_Image(img_Action); 
////
//// 
			// 모델 몰드 정보 
			fgrid_ModelOpCd.Set_Grid("SPB_MODEL_OPCD", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			fgrid_ModelOpCd.Set_Action_Image(img_Action);
			fgrid_Mold.Set_Grid("SPB_DT_MOLD", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 


			//-------------------------------------------------------
			//첫번째 행 헤더 정보 저장 (실제 디비 필드명)
  
			for(int i = 0; i < fgrid_ModelOpCd.Cols.Count; i++)
			{
				HeadDT.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			} 

			datarow = HeadDT.NewRow();
				 
			for(int i = 1; i < fgrid_ModelOpCd.Cols.Count; i++)
			{ 
				datarow[i] = "ARG_" + fgrid_ModelOpCd[0, i].ToString(); 

				//첫번째 행에 두번째 행 정보 저장 (그리드 타이틀)
				fgrid_ModelOpCd[0, i] = fgrid_ModelOpCd[1, i].ToString();
			} 
			 
			HeadDT.Rows.Add(datarow);

			fgrid_ModelOpCd.Rows[0].Visible = true;
			fgrid_ModelOpCd.Rows[1].Visible = false;

			//------------------------------------------------------- 
			dt_ret = ClassLib.ComFunction.Select_Factory_List(); 
////			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
////			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLMFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
////			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLLFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
////			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MMFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
//// 
////			cmb_MFactory.SelectedValue = ClassLib.ComVar.This_Factory;   
////			cmb_MFactory.SelectedValue = ClassLib.ComVar.This_Factory; 
////			cmb_MLMFactory.SelectedValue = ClassLib.ComVar.This_Factory;  
			cmb_MMFactory.SelectedValue = ClassLib.ComVar.This_Factory;  
////
////
////			 
////			// 모델 연도 세팅
////			dt_ret = Select_Model_Year(); 
////			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MDYear, 0, 0, true, COM.ComVar.ComboList_Visible.Code); 
////			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLMYear, 0, 0, false, COM.ComVar.ComboList_Visible.Code); 
//// 

			// Yes/No 세팅
			dt_ret = MyOraDB.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxYesNo); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MMMold, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
			cmb_MMMold.SelectedValue = "Y";


			if(COM.ComVar.Model_ModelCd != "")
				obar_Main.SelectedPage = obarpg_ModelMold;  
////			else
////				obar_Main.SelectedPage = obarpg_Model; 


			 

		}

 


		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			if(arg_dt == null) return;

			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;  
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = "";
			} 

			arg_fgrid.AutoSizeCols();
		}
 

		#endregion 

		#region 이벤트 처리  
		

		#region 공통 이벤트 

		private void obar_Main_SelectedPageChanged(object sender, System.EventArgs e)
		{
 
			switch(obar_Main.SelectedPage.Name)
			{
				 
				case "obarpg_Model": 

					tbtn_Append.Enabled = false;
					tbtn_Insert.Enabled = false;
 						  
					break;

				case "obarpg_ModelLine": 
					 
					tbtn_Append.Enabled = false;
					tbtn_Insert.Enabled = false;
 							  
					break;

				case "obarpg_ModelMold":
 
					tbtn_Append.Enabled = false;
					tbtn_Insert.Enabled = false;
					 
					break;


			}
		}


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
////				case "obarpg_Model": 
////					//cmb_MFactory.SelectedIndex = -1;
////					//cmb_MDYear.SelectedIndex = -1; 
////
////					txt_MDModel.Text = "";
////					fgrid_MModelDetail.Rows.Count = fgrid_MModelDetail.Rows.Fixed;
////
////					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
////
////					break;
////
////				case "obarpg_ModelLine": 
////					 
////					//cmb_MLMFactory.SelectedIndex = -1;
////					//cmb_MLMYear.SelectedIndex = -1;
////					//cmb_MLLFactory.SelectedIndex = -1;
////					//cmb_MLFactory.SelectedIndex = -1;
////					//cmb_MLModel.SelectedIndex = -1; 
////
////					//fgrid_MLModel.Rows.Count = fgrid_MLModel.Rows.Fixed;
////					//fgrid_MLLine.Rows.Count = fgrid_MLLine.Rows.Fixed;
////					fgrid_ModelLine.Rows.Count = fgrid_ModelLine.Rows.Fixed;
////
////					txt_MLModelCd.Text = "";
////					txt_MLModelName.Text = "";
////					txt_MLLineCd.Text = "";
////					txt_MLLineName.Text = ""; 
////					txt_MLLineSeq.Text = ""; 
////					txt_MLAloRate.Text = "";
////					txt_MLRemarks.Text = "";
////
////					break;
					
				case "obarpg_ModelMold": 
				 
					//cmb_MMFactory.SelectedIndex = -1;
					//cmb_MMModel.SelectedIndex = -1;
					//cmb_MMMold.SelectedIndex = -1;

					fgrid_ModelOpCd.Rows.Count = fgrid_ModelOpCd.Rows.Fixed;
					fgrid_Mold.Rows.Count = fgrid_Mold.Rows.Fixed;

					txt_MoldPart.Text = "";
					txt_TypeName.Text = "";



					break;


			}
 
		}



		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			switch(obar_Main.SelectedPage.Name)
			{
////				case "obarpg_Model": 
////
////					if(cmb_MFactory.SelectedIndex == -1 || cmb_MDYear.SelectedIndex == -1) return;
////					  
////					dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
////						ClassLib.ComFunction.Empty_Combo(cmb_MDYear, " "));
////					Display_Grid(dt_ret, fgrid_MModelDetail);
////
////					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
////
////					break;
//// 
////
////				case "obarpg_ModelLine":  
////
////					if(cmb_MLFactory.SelectedIndex == -1 && cmb_MLModel.SelectedIndex == -1) return;
////					 
////					dt_ret = Select_Model_Line();
////					Display_Grid(dt_ret, fgrid_ModelLine);
////
////					txt_MLModelCd.Text = "";
////					txt_MLModelName.Text = "";
////					txt_MLLineCd.Text = "";
////					txt_MLLineName.Text = ""; 
////					txt_MLLineSeq.Text = ""; 
////					txt_MLAloRate.Text = "";
////					txt_MLRemarks.Text = ""; 
////
////					break;
				
				case "obarpg_ModelMold": 
					
					if(cmb_MMFactory.SelectedIndex == -1 || cmb_MMModel.SelectedIndex == -1 || cmb_MMGen.SelectedIndex == -1) return;
 
					dt_ret = Select_ModelOpCd_List();  
					Display_TreeGrid(dt_ret, fgrid_ModelOpCd);
					break;
			}
		}



		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			switch(obar_Main.SelectedPage.Name)
			{
////				case "obarpg_Model": 
////					//행 수정 상태 해제
////					fgrid_MModelDetail.Select(fgrid_MModelDetail.Selection.r1, 0, fgrid_MModelDetail.Selection.r1, fgrid_MModelDetail.Cols.Count-1, false);
////  
//////					for(int i = fgrid_MModelDetail.Rows.Fixed; i < fgrid_MModelDetail.Rows.Count; i++)
//////					{
//////						if(fgrid_MModelDetail[i, (int)ClassLib.TBSPB_MODEL.IxBOM_CD] == null || fgrid_MModelDetail[i, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString() == "") 
//////						{
//////							ClassLib.ComFunction.Data_Message("BOM Code", ClassLib.ComVar.MgsDoNotSave, this);
//////							return;
//////						}
//////					}
////
//////					MyOraDB.Save_FlexGird("PKG_SPB_MODEL_BSC.SAVE_SPB_MODEL", fgrid_MModelDetail);
//////
//////					dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
//////						ClassLib.ComFunction.Empty_Combo(cmb_MDYear, " "));
//////					Display_Grid(dt_ret, fgrid_MModelDetail);
////
////
////					string message_text = "Do you want to apply on MPS LOT ?";
////					DialogResult message = ClassLib.ComFunction.User_Message(message_text, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
////
////					bool save_flag = false;
////
////
////
////
////
////
////					if(message == DialogResult.Yes)
////					{
////						save_flag = Save_SPB_MODEL_WITH_MPS_LOT();  
////					}
////					else
////					{
////						save_flag = MyOraDB.Save_FlexGird("PKG_SPB_MODEL_BSC.SAVE_SPB_MODEL", fgrid_MModelDetail);
////					}
////
////
////					
////
////
////
////					string factory = ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " ");
////					string style_cd  = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ");
////
////					if(save_flag)
////					{
////						dt_ret = Select_Model_List_Style(factory, style_cd);
////						Display_Grid(dt_ret, fgrid_MModelDetail);
////
////						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
////					}
////					else
////					{
////						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
////					}
////
////
////					break;
////
////				case "obarpg_ModelLine":  
////					//행 수정 상태 해제
////					fgrid_ModelLine.Select(fgrid_ModelLine.Selection.r1, 0, fgrid_ModelLine.Selection.r1, fgrid_ModelLine.Cols.Count-1, false);
////					  
////					MyOraDB.Save_FlexGird("PKG_SPB_MODEL_BSC.SAVE_MODEL_LINE", fgrid_ModelLine); 
////
////					dt_ret = Select_Model_Line();
////					Display_Grid(dt_ret, fgrid_ModelLine);
////					
////					//					txt_MLModelCd.Text = "";
////					//					txt_MLModelName.Text = "";
////					//					txt_MLLineCd.Text = "";
////					//					txt_MLLineName.Text = ""; 
////					//					txt_MLLineSeq.Text = ""; 
////					//					txt_MLAloRate.Text = "";
////					//					txt_MLRemarks.Text = "";
////
////					break;
					
				case "obarpg_ModelMold": 
					
					int sel_row = fgrid_ModelOpCd.Selection.r1;
					//
					//					//행 수정 상태 해제
					fgrid_ModelOpCd.Select(fgrid_ModelOpCd.Selection.r1, 0, fgrid_ModelOpCd.Selection.r1, fgrid_ModelOpCd.Cols.Count-1, false);
					// 
					//					Save_ModelOpMold();
					//
					//					tbtn_Search_Click(null, null);
					//
					//					fgrid_ModelOpCd.TopRow = sel_row;
					// 
					//					x 




					//Delete_Model_Opmold();

					for(int i=2; i<fgrid_ModelOpCd.Rows.Count; i++)
					{
						if(fgrid_ModelOpCd[i, 0].ToString().Trim() != "")
						{
							string[] arraylist = new string[12];

							arraylist[0] = fgrid_ModelOpCd[i, 0].ToString();
							arraylist[1] = fgrid_ModelOpCd[i, 16].ToString();
							arraylist[2] = fgrid_ModelOpCd[i, 9].ToString();
							arraylist[3] = fgrid_ModelOpCd[i, 17].ToString();
							arraylist[4] = fgrid_ModelOpCd[i, 10].ToString();
							arraylist[5] = fgrid_ModelOpCd[i, 11].ToString();
							arraylist[6] = fgrid_ModelOpCd[i, 6].ToString();
							arraylist[7] = fgrid_ModelOpCd[i, 12].ToString();
							arraylist[8] = fgrid_ModelOpCd[i, 13].ToString();
							arraylist[9] = fgrid_ModelOpCd[i, 14].ToString();
							arraylist[10]= fgrid_ModelOpCd[i, 15].ToString();
							arraylist[11]= ClassLib.ComVar.This_User;
							
							Delete_Model_Opmold(arraylist);
							Save_Model_Opmold(arraylist);
						}

						
					}


					//Save_ModelOpMold();

					tbtn_Search_Click(null, null);

					fgrid_ModelOpCd.TopRow = sel_row;

					break;


			} 
		}



		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
////				case "obarpg_Model": 
////								  
////					break;
////
				case "obarpg_ModelMold": 
					 
					break;

////
////				case "obarpg_ModelLine":  
////
////					break;
			}
		}



		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
////				case "obarpg_Model": 
////								  
////					break;

				case "obarpg_ModelMold": 
					 
					break;


////				case "obarpg_ModelLine":  
////
////					break;
			}
		}



		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
////				case "obarpg_Model": 
////					fgrid_MModelDetail.Delete_Row(); 			  
////					break;
////
////				
////				case "obarpg_ModelLine":  
////					fgrid_ModelLine.Delete_Row(); 
////					break;

				case "obarpg_ModelMold":
					fgrid_ModelOpCd.Delete_Row();
					break;


			}
		}


		#endregion

		#region 모델정보
 
		
		private void cmb_MFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
////			if(cmb_MFactory.SelectedIndex == -1) return;
////			 
////
////
////			// 공장별 BOM code list
////			Set_BOM_Code(); 


			//cmb_MDYear.SelectedIndex = 0;   
		}

 

////		private void cmb_MDYear_SelectedValueChanged(object sender, System.EventArgs e)
////		{
////			DataTable dt_ret;
////
////			if(cmb_MFactory.SelectedIndex == -1) return;     // || cmb_MDYear.SelectedIndex == -1
////
////			for(int i = fgrid_MModelDetail.Rows.Fixed; i < fgrid_MModelDetail.Rows.Count; i++)
////			{
////				if(fgrid_MModelDetail[i, 0].ToString() == "I" || fgrid_MModelDetail[i, 0].ToString() == "U") 
////				{
////					//MessageBox.Show("저장되지 않은 데이터가 있습니다");
////					return;
////				}
////			}
////			 
////			dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
////				ClassLib.ComFunction.Empty_Combo(cmb_MDYear, " "));
////			Display_Grid(dt_ret, fgrid_MModelDetail);
////			 
////		}


 
 
////		private void fgrid_MModelDetail_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
////		{
////			if ((fgrid_MModelDetail.Rows.Fixed > 0) && (fgrid_MModelDetail.Row >= fgrid_MModelDetail.Rows.Fixed))
////			{
////				if(fgrid_MModelDetail.Cols[fgrid_MModelDetail.Col].DataType != typeof(string))
////				{
////					fgrid_MModelDetail.Buffer_CellData = "";
////				}
////				else
////				{
////					fgrid_MModelDetail.Buffer_CellData = (fgrid_MModelDetail[fgrid_MModelDetail.Row, fgrid_MModelDetail.Col] == null) ? "" : fgrid_MModelDetail[fgrid_MModelDetail.Row, fgrid_MModelDetail.Col].ToString();
////				}
////
//// 
////
////			} // end if rows.fixed
////
////		}

		 
	 


////		private void fgrid_MModelDetail_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
////		{
////			fgrid_MModelDetail[e.Row, e.Col] = (fgrid_MModelDetail[e.Row, e.Col].ToString() == "") ? fgrid_MModelDetail.Buffer_CellData : fgrid_MModelDetail[e.Row, e.Col].ToString();
////			fgrid_MModelDetail.Update_Row();  
////			fgrid_MModelDetail.AutoSizeCols();
////		}


////		private void txt_MDModel_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
////		{
////			DataTable dt_ret;
////
////			try
////			{
////				//13 : enter
////				if(e.KeyChar == (char)13) 
////				{
////					txt_MDModel.Text = txt_MDModel.Text.ToUpper();
////
////					if(cmb_MFactory.SelectedIndex == -1 || cmb_MDYear.SelectedIndex == -1) return;
////					  
////					dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
////						ClassLib.ComFunction.Empty_Combo(cmb_MDYear, " "));
////					Display_Grid(dt_ret, fgrid_MModelDetail);
////
////					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
////
////				}
////			}
////			catch
////			{
////			}
////		}
////
////		
////
////
////		
////		private void txt_StyleCd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
////		{
////			DataTable dt_ret;
////
////			try
////			{
////				//13 : enter
////				if(e.KeyChar == (char)13) 
////				{
////					 
////					if(cmb_MFactory.SelectedIndex == -1) return;
////					  
////					dt_ret = Select_Model_List_Style(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
////						                             ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "") );
////					
////					Display_Grid(dt_ret, fgrid_MModelDetail);
////
////					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
////
////				}
////			}
////			catch
////			{
////			}
////		}



		#endregion

		#region 모델 라인 정보
 
////		private void cmb_MLMFactory_SelectedValueChanged(object sender, System.EventArgs e)
////		{
////			cmb_MLLFactory.SelectedIndex = cmb_MLMFactory.SelectedIndex;
////			cmb_MLFactory.SelectedIndex = cmb_MLMFactory.SelectedIndex;
////		}
////
////
////		private void cmb_MLMYear_SelectedValueChanged(object sender, System.EventArgs e)
////		{ 
////			DataTable dt_ret;
////
////			if(cmb_MLMFactory.SelectedIndex == -1 || cmb_MLMYear.SelectedIndex == -1) return;
////			  
////			dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MLMFactory, " "),
////				ClassLib.ComFunction.Empty_Combo(cmb_MLMYear, " "));
////			Display_Grid(dt_ret, fgrid_MLModel);
////
////		}
////
////		
////
////		private void cmb_MLLFactory_SelectedValueChanged(object sender, System.EventArgs e)
////		{
////			DataTable dt_ret;
////
////			cmb_MLMFactory.SelectedIndex = cmb_MLLFactory.SelectedIndex;
////			cmb_MLFactory.SelectedIndex = cmb_MLLFactory.SelectedIndex;
////
////			if(cmb_MLLFactory.SelectedIndex == -1) return; 
////
////			dt_ret = Select_Line_List();
////			Display_Grid(dt_ret, fgrid_MLLine);
////
////
////		}
////
////
////		private void cmb_MLFactory_SelectedValueChanged(object sender, System.EventArgs e)
////		{
////			DataTable dt_ret;
////
////			cmb_MLMFactory.SelectedIndex = cmb_MLFactory.SelectedIndex;
////			cmb_MLLFactory.SelectedIndex = cmb_MLFactory.SelectedIndex;
////
////			if(cmb_MLFactory.SelectedIndex == -1) return;
////			 
////			dt_ret = Select_Model_CmbList(cmb_MLFactory.SelectedValue.ToString());
////
////			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLModel, 0, 1, false);
////			 
////		}
////		
////		 
////		private void cmb_MLModel_SelectedValueChanged(object sender, System.EventArgs e)
////		{
////			DataTable dt_ret;
////
////			if(cmb_MLFactory.SelectedIndex == -1 || cmb_MLModel.SelectedIndex == -1) return;
////			 
////			dt_ret = Select_Model_Line();
////			Display_Grid(dt_ret, fgrid_ModelLine);
////			  
////		}

		 

////		private void fgrid_MLModel_Click(object sender, System.EventArgs e)
////		{
////			if(fgrid_MLModel.Rows.Count <= fgrid_MLLine.Rows.Fixed) return;
////
////			txt_MLModelCd.Text = "";
////			txt_MLModelName.Text = "";
////
////			txt_MLModelCd.Text = fgrid_MLModel[fgrid_MLModel.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxMODEL_CD].ToString();
////			txt_MLModelName.Text = fgrid_MLModel[fgrid_MLModel.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxMODEL_NAME].ToString();
////
////			//if(cmb_MLModel.SelectedIndex != -1) return;
////
////			for(int i = fgrid_ModelLine.Rows.Fixed; i < fgrid_ModelLine.Rows.Count; i++)
////			{
////				if(fgrid_ModelLine[i, 0].ToString() == "I" || fgrid_ModelLine[i, 0].ToString() == "U") 
////				{
////					//MessageBox.Show("저장되지 않은 데이터가 있습니다");
////					return;
////				}
////			}
////
////			 
////			cmb_MLModel.SelectedValue = txt_MLModelCd.Text;
////			 
////
////		}
////
////  
////		
////		private void fgrid_MLLine_Click(object sender, System.EventArgs e)
////		{
////			if(fgrid_MLLine.Rows.Count <= fgrid_MLLine.Rows.Fixed) return;
////
////			txt_MLLineCd.Text = "";
////			txt_MLLineName.Text = "";
////
////			txt_MLLineCd.Text = fgrid_MLLine[fgrid_MLLine.Selection.r1, (int)ClassLib.TBSPB_LINE.IxLINE_CD].ToString();
////			txt_MLLineName.Text = fgrid_MLLine[fgrid_MLLine.Selection.r1, (int)ClassLib.TBSPB_LINE.IxLINE_NAME].ToString();
//// 
////		}
//// 

////		private void btn_AppendRow_Click(object sender, System.EventArgs e)
////		{
////			int i;
////
////			if(cmb_MLFactory.SelectedIndex == -1 || cmb_MLModel.SelectedIndex == -1) return;
////
////					
////			//			if(txt_MLModelCd.Text != cmb_MLModel.SelectedValue.ToString())
////			//			{
////			//				MessageBox.Show("모델코드 불일치");
////			//				return;
////			//			}
////			
////			//			if(Convert.ToInt32(fgrid_MLModel[fgrid_MLModel.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxLINE_QTY].ToString())
////			//				== fgrid_ModelLine.Rows.Count - fgrid_ModelLine.Rows.Fixed)
////			//			{
////			//				MessageBox.Show("할당 가능 제조라인수 초과"); 
////			//
////			//				txt_MLModelCd.Text = "";
////			//				txt_MLModelName.Text = "";
////			//				txt_MLLineCd.Text = "";
////			//				txt_MLLineName.Text = ""; 
////			//				txt_MLLineSeq.Text = ""; 
////			//				txt_MLAloRate.Text = "";
////			//				txt_MLRemarks.Text = "";
////			//
////			//				return;
////			//			}
////			
////			if(txt_MLLineSeq.Text == "")
////			{
////				ClassLib.ComFunction.Data_Message("Line Priority", ClassLib.ComVar.MgsWrongInput, this);
////				return;
////			}
////
////
////			for(i = fgrid_MLLine.Rows.Fixed; i < fgrid_ModelLine.Rows.Count; i++)
////			{
//// 
////				if(txt_MLLineSeq.Text == fgrid_ModelLine[i, (int)ClassLib.TBSPB_MODEL_LINE.IxLINE_SEQ].ToString())
////				{
////					MessageBox.Show("Duplicate Line Priority");
////					txt_MLLineSeq.Text = "";
////					return;
////				}
////			}
////
////			fgrid_ModelLine.Add_Row(fgrid_ModelLine.Rows.Count - 1);
////			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxFACTORY] = cmb_MLFactory.SelectedValue.ToString();
////			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxMODEL_CD] = txt_MLModelCd.Text;
////			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxLINE_SEQ] = txt_MLLineSeq.Text;
////			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxLINE_CD] = txt_MLLineCd.Text;
////			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxALO_RATE] = (txt_MLAloRate.Text == "") ? "" : txt_MLAloRate.Text;
////			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxREMARKS] = txt_MLRemarks.Text;
////			 
////
////		}
////
////
////		private void btn_AppendRow_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
////		{
////			btn_AppendRow.ImageIndex = 1; 
////		}
////
////		private void btn_AppendRow_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
////		{
////			btn_AppendRow.ImageIndex = 0; 
////		}
////
////
////		private void fgrid_ModelLine_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
////		{
////			if ((fgrid_ModelLine.Rows.Fixed > 0) && (fgrid_ModelLine.Row >= fgrid_ModelLine.Rows.Fixed))
////			{
////				if(fgrid_ModelLine.Cols[fgrid_ModelLine.Col].DataType == typeof(bool))
////				{
////					fgrid_ModelLine.Buffer_CellData = "";
////				}
////				else
////				{
////					fgrid_ModelLine.Buffer_CellData = (fgrid_ModelLine[fgrid_ModelLine.Row, fgrid_ModelLine.Col] == null) ? "" : fgrid_ModelLine[fgrid_ModelLine.Row, fgrid_ModelLine.Col].ToString();
////				}
////			}
////		}
////
////
////		private void fgrid_ModelLine_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
////		{
////			fgrid_ModelLine.Update_Row(); 
////		}



		#endregion

		#region 모델 몰드 정보
			
			
		private void cmb_MMFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;
//// 
			if(cmb_MMFactory.SelectedIndex == -1) return;
 
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_MMFactory.SelectedValue.ToString(), ClassLib.ComVar.CxGen);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MMGen, 1, 2, false, COM.ComVar.ComboList_Visible.Code);  
////
			dt_ret = Select_Model_CmbList(cmb_MMFactory.SelectedValue.ToString()); 
			dt_ret = Select_Model_ExistBOM_CmbList();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MMModel, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
////
			if(COM.ComVar.Model_ModelCd.Trim().Length > 0 && COM.ComVar.Model_ModelCd.Trim().Length > 0)
				cmb_MMModel.SelectedValue = COM.ComVar.Model_ModelCd;
			else
				cmb_MMModel.SelectedValue = 0; 
////
////
////			
		}
			
			
		private void cmb_MMModel_SelectedValueChanged(object sender, System.EventArgs e)
		{ 
			DataTable dt_ret;

			try
			{
				if(cmb_MMFactory.SelectedIndex == -1 || cmb_MMModel.SelectedIndex == -1 || cmb_MMGen.SelectedIndex == -1) return;
 
				dt_ret = Select_ModelOpCd_List();  
				Display_TreeGrid(dt_ret, fgrid_ModelOpCd);
			}
			catch
			{
			}

		}


		
		private void cmb_MMMold_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
			//			if(cmb_MMFactory.SelectedIndex == -1 || cmb_MMModel.SelectedIndex == -1 || cmb_MMGen.SelectedIndex == -1) return;
			// 
			//			dt_ret = Select_ModelOpCd_List();  
			//			Display_TreeGrid(dt_ret, fgrid_ModelOpCd);

		}

		
		private void cmb_MMGen_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_MMFactory.SelectedIndex == -1 || cmb_MMModel.SelectedIndex == -1 || cmb_MMGen.SelectedIndex == -1) return;
 
				dt_ret = Select_ModelOpCd_List();  
				Display_TreeGrid(dt_ret, fgrid_ModelOpCd);
			}
			catch
			{
			}
		}


 

		/// <summary>
		/// Display_TreeGrid : 트리 형태로 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_TreeGrid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			
			CellRange cellrg;

			int level = (int)ClassLib.TBSPB_MODEL_OPCD.IxLEVEL;

			int grid_cd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxCODE;
			int grid_name = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxNAME;
			int grid_bomcd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxBOM_CD;
			int grid_bomname = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxBOM_NAME;
			int grid_moldyn = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_YN;
			int grid_moldtype = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_TYPE;
			int grid_typename = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxTYPE_NAME;
			int grid_level = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxLEVEL;
			int grid_modelcd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMODEL_CD;
			int grid_cmpcd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxCMP_CD;
			int grid_opcd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxOP_CD;
			int grid_moldcd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CD;
			int grid_moldord = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_ORD;
			int grid_moldcycle = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CYCLE;
			int grid_remarks = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxREMARKS;
			int grid_factory = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxFACTORY;
			int grid_gen = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxGEN;
			
			 
			arg_fgrid.Tree.Column = grid_cd;
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;
			arg_fgrid.Cols.Count = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMaxCt + 1;

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.Rows.InsertNode(i + arg_fgrid.Rows.Fixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[level].ToString()) - 1);

				arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = "";

				switch(arg_dt.Rows[i].ItemArray[level].ToString())
				{
					case "1":    //model
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMODEL_CD].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_name] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMODEL_NAME].ToString();
						break;

					case "2":   //cmp
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxCMP_CD].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_name] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxCMP_NAME].ToString();
						break;

					case "3":    //op
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxOP_CD].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_name] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxOP_NAME].ToString();
						break;

					case "4":    //mold type
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_TYPE].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_name] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxTYPE_NAME].ToString();
						break;
				}

				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_bomcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxBOM_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_bomname] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxBOM_NAME].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldyn] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_YN].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldtype] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_TYPE].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_typename] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxTYPE_NAME].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_level] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxLEVEL].ToString();
 
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_modelcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMODEL_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cmpcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxCMP_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxOP_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldord] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_ORD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldcycle] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_CYCLE].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_remarks] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxREMARKS].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_factory] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxFACTORY].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_gen] = cmb_MMGen.SelectedValue.ToString();
  

				if (arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldyn].ToString() == "Y")
				{
					 
					cellrg = arg_fgrid.GetCellRange(i + arg_fgrid.Rows.Fixed, grid_cd, i + arg_fgrid.Rows.Fixed, grid_name);
					cellrg.StyleNew.ForeColor = ClassLib.ComVar.ClrImportant;

					if(arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldcd].ToString() == "")
					{

						cellrg = arg_fgrid.GetCellRange(i + arg_fgrid.Rows.Fixed, grid_moldtype, i + arg_fgrid.Rows.Fixed, grid_typename);
						cellrg.StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
					}

				}

				


				arg_fgrid.AutoSizeCols(); 
				arg_fgrid.Tree.Style = TreeStyleFlags.Complete;
 


			} 
 

		}


		private void fgrid_ModelOpCd_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_ModelOpCd.Rows.Fixed > 0) && (fgrid_ModelOpCd.Row >= fgrid_ModelOpCd.Rows.Fixed))
			{
				if(fgrid_ModelOpCd.Cols[fgrid_ModelOpCd.Col].DataType == typeof(bool))
				{
					fgrid_ModelOpCd.Buffer_CellData = "";
				}
				else
				{
					fgrid_ModelOpCd.Buffer_CellData = (fgrid_ModelOpCd[fgrid_ModelOpCd.Row, fgrid_ModelOpCd.Col] == null) ? "" : fgrid_ModelOpCd[fgrid_ModelOpCd.Row, fgrid_ModelOpCd.Col].ToString();
				}
			}
		}



		private void fgrid_ModelOpCd_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			bool digit_flag;

			if (e.Col != (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_ORD 
				&& e.Col != (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CYCLE)  
			{
				fgrid_ModelOpCd.Update_Row(); 
			}
			else
			{
				digit_flag = COM.ComFunction.Check_Digit(fgrid_ModelOpCd[e.Row, e.Col].ToString());

				if(digit_flag == false) return; 

				fgrid_ModelOpCd.Update_Row();

			
			}

			

		}


		
		private void fgrid_ModelOpCd_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;
			if(fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_TYPE].ToString() == "")
				fgrid_ModelOpCd.Rows[fgrid_ModelOpCd.Selection.r1].AllowEditing = false;
			else
				fgrid_ModelOpCd.Rows[fgrid_ModelOpCd.Selection.r1].AllowEditing = true;

			//MessageBox.Show(fgrid_ModelOpCd[fgrid_ModelOpCd.RowSel,1].ToString());
			//txt_MoldPart.Text = fgrid_ModelOpCd[fgrid_ModelOpCd.RowSel, 1].ToString();
			//txt_TypeName.Text = fgrid_ModelOpCd[fgrid_ModelOpCd.RowSel, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxTYPE_NAME].ToString();
					
			//dt_ret = Select_MoldType_List();
			//Display_Grid(dt_ret, fgrid_Mold);
		}

 
	


		private void fgrid_ModelOpCd_DoubleClick(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				int sel_row = fgrid_ModelOpCd.Selection.r1;

			
				if(fgrid_ModelOpCd[sel_row, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_YN].ToString() == "Y"
					&& fgrid_ModelOpCd[sel_row, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_TYPE].ToString() != "")
				{
					//txt_MoldPart.Text = fgrid_ModelOpCd[sel_row, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_TYPE].ToString();
					//MessageBox.Show(fgrid_ModelOpCd[fgrid_ModelOpCd.RowSel,1].ToString());
					txt_MoldPart.Text = fgrid_ModelOpCd[fgrid_ModelOpCd.RowSel, 10].ToString();
					txt_TypeName.Text = fgrid_ModelOpCd[sel_row, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxTYPE_NAME].ToString();
//					
					dt_ret = Select_MoldType_List();
					Display_Grid(dt_ret, fgrid_Mold);

				}
				else
				{
					txt_MoldPart.Text = "";
					txt_TypeName.Text = "";

					fgrid_Mold.Rows.Count = fgrid_Mold.Rows.Fixed;

				}
		 

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"fgrid_ModelOpCd_Click",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

	

	 

		private void fgrid_Mold_DoubleClick(object sender, System.EventArgs e)
		{

			try
			{
//				if(fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_TYPE].ToString() 
//					!= txt_MoldPart.Text)
//				{
//					MessageBox.Show("Discordance Mold Type");
//					return;
//				}

				//신규
				if(fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CD].ToString() == "")
				{
					fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, 0] = "I";
				}
				else
				{
					if(fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, 0].ToString() != "I")
						fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, 0] = "U";
				}


				fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CD] = 
					fgrid_Mold[fgrid_Mold.Selection.r1, (int)ClassLib.TBDT_TOOL.IxTOOL_CD].ToString();
		 
				fgrid_ModelOpCd.LeftCol = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CD;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"fgrid_Mold_Click",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}


		}




		#endregion
		 

		#endregion 
	 
		#region DB Connect


		/// <summary>
		/// Select_Model_Year : 모델에 대한 연도 리스트 찾기
		/// </summary>
		private DataTable Select_Model_Year()
		{
 
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(1); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_YEAR";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}

 
		/// <summary>
		/// Select_Model_List : 모델 리스트 가져오기
		/// </summary>
		private DataTable Select_Model_List(string arg_factory, string arg_year)
		{

			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_LIST";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_YEAR";
			MyOraDB.Parameter_Name[2] = "ARG_MODEL_NAME";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_year, " ");

////			switch(obar_Main.SelectedPage.Name)
////			{ 
////				case "obarpg_Model":  
////					MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_MDModel, " ");
////					break;
////
////				case "obarpg_ModelLine": 
////					MyOraDB.Parameter_Values[2] = " ";
////					break; 
////			} 

			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 

		}





		/// <summary>
		/// Select_Model_List_Style : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <returns></returns>
		private DataTable Select_Model_List_Style(string arg_factory, string arg_stylecd)
		{

			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_LIST_STYLE";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stylecd;  
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 

		}




		/// <summary>
		/// Select_Model_Line : 모델 라인 리스트 가져오기
		/// </summary>
////		private DataTable Select_Model_Line()
////		{
////			 
////			DataSet ds_ret; 
//// 
////			MyOraDB.ReDim_Parameter(3); 
////
////			//01.PROCEDURE명
////			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_LINE";
//// 
////			//02.ARGURMENT명
////			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
////			MyOraDB.Parameter_Name[1] = "ARG_MODEL_CD";
////			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
////
////			//03.DATA TYPE
////			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
////			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
////			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
////			 
////			//04.DATA 정의  
////			MyOraDB.Parameter_Values[0] = cmb_MLFactory.SelectedValue.ToString();
////			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_MLModel, " ");
////			MyOraDB.Parameter_Values[2] = "";
////
////			MyOraDB.Add_Select_Parameter(true);
//// 
////			ds_ret = MyOraDB.Exe_Select_Procedure();
////
////			if(ds_ret == null) return null ;
////			
////			return ds_ret.Tables[MyOraDB.Process_Name]; 
////
////		}
////


		/// <summary>
		/// Select_Line_List : 라인 리스트 가져오기
		/// </summary>
////		private DataTable Select_Line_List()
////		{
////			 
////			DataSet ds_ret; 
//// 
////			MyOraDB.ReDim_Parameter(2); 
////
////			//01.PROCEDURE명
////			MyOraDB.Process_Name = "PKG_SPB_LINE.SELECT_LINE_LIST";
//// 
////			//02.ARGURMENT명
////			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
////			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
////
////			//03.DATA TYPE
////			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
////			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
////			 
////			//04.DATA 정의  
////			MyOraDB.Parameter_Values[0] = cmb_MLLFactory.SelectedValue.ToString(); ;
////			MyOraDB.Parameter_Values[1] = "";
////
////			MyOraDB.Add_Select_Parameter(true);
//// 
////			ds_ret = MyOraDB.Exe_Select_Procedure();
////
////			if(ds_ret == null) return null ;
////			
////			return ds_ret.Tables[MyOraDB.Process_Name];  
////
////		}
////
////		/// <summary>
////		/// Select_Model_ExistBOM_CmbList : BOm 코드 있는 모델  콤보 리스트 찾기 
////		/// </summary>
////		/// <param name="arg_factory"></param>
////		/// <param name="arg_cmb">적용시킬 콤보박스</param>
		public DataTable Select_Model_ExistBOM_CmbList()
		{ 
			 
			DataSet ds_ret; 
 
			try
			{
				MyOraDB.ReDim_Parameter(2); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_SPB_MODEL_EXISTBOM";
 
				//02.ARGURMENT명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				//03.DATA TYPE
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = cmb_MMFactory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = "";

				MyOraDB.Add_Select_Parameter(true);
 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ;
			
				return ds_ret.Tables[MyOraDB.Process_Name];  
			}
			catch
			{
				return null;
			}
		}
////
////

		/// <summary>
		/// Select_Model_CmbList : 모델  콤보 리스트 찾기, 리스트 추가
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_cmb">적용시킬 콤보박스</param>
		public DataTable Select_Model_CmbList(string arg_factory)
		{ 
			 
			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_CMBLIST";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name];  

		}


		
		/// <summary>
		/// Save_ModelOpMold : 모델 공정 몰드 저장
		/// </summary>
		private bool Save_ModelOpMold()
		{
			int arg_ct = 0;
			int save_ct =0 ;							// 저장 행 수
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 
	
			try
			{
				ClassLib.Arr_TBSPB_MODEL_OPMOLD  arr_opmold= new ClassLib.Arr_TBSPB_MODEL_OPMOLD();
			
				arg_ct = arr_opmold.lx.GetLength(0) + 2;

				MyOraDB.ReDim_Parameter(arg_ct); 
		
				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SAVE_SPB_MODEL_OPMOLD";

			
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";

				for (int i = 0 ; i < arr_opmold.lx.GetLength(0); i ++)
				{	
					MyOraDB.Parameter_Name[i + 1] = HeadDT.Rows[0].ItemArray[arr_opmold.lx[i]].ToString(); 
				}
				MyOraDB.Parameter_Name[arg_ct - 1] = "ARG_UPD_USER"; 
		
				//03.DATA TYPE
				for (int i = 0 ; i < arg_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			
		
					
				//04.DATA 정의
				 
				// 저장 행 수 구하기
				for(int i = fgrid_ModelOpCd.Rows.Fixed ; i < fgrid_ModelOpCd.Rows.Count; i++)
				{
					if(fgrid_ModelOpCd[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[arg_ct * save_ct ]; 
			         
				for (int i  = fgrid_ModelOpCd.Rows.Fixed; i < fgrid_ModelOpCd.Rows.Count; i++)
				{
					if(fgrid_ModelOpCd[i, 0].ToString() != "")
					{ 

						MyOraDB.Parameter_Values[para_ct] = fgrid_ModelOpCd[i, 0].ToString(); 
						para_ct ++;

						for(int j = 0; j < arr_opmold.lx.GetLength(0); j++)
						{
							MyOraDB.Parameter_Values[para_ct] = (fgrid_ModelOpCd[i, arr_opmold.lx[j]] == null) ? "" : fgrid_ModelOpCd[i, arr_opmold.lx[j]].ToString();
							para_ct ++;
						} // end for j 
						MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User;
						para_ct ++;
					} // end if
	 
				} // end for i

				//05.Package연결
				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
					
				return true;



			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_ModelOpMold",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}


		}



		/// <summary>
		/// Select_ModelOpCd_List : 모델 -> 반제 -> 공정  -> 몰드 리스트 추출
		/// </summary>
		/// <returns></returns>
		private DataTable Select_ModelOpCd_List()
		{
			DataSet ds_ret; 
 
			try
			{
				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_OPCD_LIST";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[2] = "ARG_GEN";
				MyOraDB.Parameter_Name[3] = "ARG_MOLD_YN";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

				//03.DATA TYPE
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = cmb_MMFactory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_MMModel.SelectedValue.ToString();     //ClassLib.ComFunction.Empty_Combo(cmb_MMModel, " ");
				MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(cmb_MMGen, " ");
				MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_MMMold, " ");
				MyOraDB.Parameter_Values[4] = "";

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[MyOraDB.Process_Name];  
			}
			catch
			{
				return null;
			}
		}


	 
		/// <summary>
		/// Select_MoldType_List : 몰드 유형에 따른 몰드 리스트 
		/// </summary>
		/// <returns></returns> 
		private DataTable Select_MoldType_List()
		{

			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MOLD_LIST";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "ARG_PART_CD"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_MMFactory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_TextBox(txt_MoldPart, " ");
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name];  
		}



		private void Delete_Model_Opmold(string[] arg_arraylist)
		{
			
			MyOraDB.ReDim_Parameter(7); 

			//01.PROCEDURE명
			MyOraDB.Process_Name =  "PKG_SDT_MOLD_WH.DELETE_SPB_MOLD_OPMODEL";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "ARG_MODEL_CD"; 
			MyOraDB.Parameter_Name[2] = "ARG_GEN"; 
			MyOraDB.Parameter_Name[3] = "ARG_CMP_CD"; 
			MyOraDB.Parameter_Name[4] = "ARG_OP_CD"; 
			MyOraDB.Parameter_Name[5] = "ARG_MOLD_TYPE";
			MyOraDB.Parameter_Name[6] = "ARG_MOLD_CD";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;

			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_MMFactory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_MMModel.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = cmb_MMGen.SelectedValue.ToString();
			MyOraDB.Parameter_Values[3] = arg_arraylist[4];
			MyOraDB.Parameter_Values[4] = arg_arraylist[5];
			MyOraDB.Parameter_Values[5] = arg_arraylist[6];
			MyOraDB.Parameter_Values[6] = arg_arraylist[7];

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();	
		}


		private void Save_Model_Opmold(string[] arg_arraylist)
		{
			MyOraDB.ReDim_Parameter(arg_arraylist.Length); 

			//01.PROCEDURE명
			MyOraDB.Process_Name =  "PKG_SPB_MODEL_BSC.SAVE_SPB_MODEL_OPMOLD";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[2] = "ARG_MODEL_CD"; 
			MyOraDB.Parameter_Name[3] = "ARG_GEN"; 
			MyOraDB.Parameter_Name[4] = "ARG_CMP_CD";
			MyOraDB.Parameter_Name[5] = "ARG_OP_CD";
			MyOraDB.Parameter_Name[6] = "ARG_MOLD_TYPE"; 
			MyOraDB.Parameter_Name[7] = "ARG_MOLD_CD"; 
			MyOraDB.Parameter_Name[8] = "ARG_MOLD_ORD"; 
			MyOraDB.Parameter_Name[9] = "ARG_MOLD_CYCLE"; 
			MyOraDB.Parameter_Name[10] = "ARG_REMARKS";
			MyOraDB.Parameter_Name[11] = "ARG_UPD_USER";

			//03.DATA TYPE
			for(int i=0; i<arg_arraylist.Length; i++)
			{
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
			}
						 
			//04.DATA 정의  
			for(int i=0; i<arg_arraylist.Length; i++)
			{
				MyOraDB.Parameter_Values[i] = arg_arraylist[i];
			}
			
			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();	
		}




		#endregion


		private void Form_PB_Model_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

	 

		#region BOM 표시


		
		private void fgrid_MModelDetail_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
//			if(e.Button != MouseButtons.Left) return;
//
//		    Set_BOM_Code();
		}



////		private void fgrid_MModelDetail_Click(object sender, System.EventArgs e)
////		{
////			try
////			{
////				//txt_MDModel.Text = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxMODEL_NAME].ToString();
////				Display_BOM();
////			}
////			catch
////			{
////			}
////		}

		 
		private void fgrid_MModelDetail_ComboCloseUp(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			//			try
			//			{
			//				Display_BOM();
			//			}
			//			catch
			//			{
			//			}
		}


		#region 모델 BOM Routing 표시


		/// <summary>
		/// Set_BOM_Code : 
		/// </summary>
////		private void Set_BOM_Code()
////		{
////
////			try
////			{
////
////				
////				//if(fgrid_MModelDetail.Rows.Count == fgrid_MModelDetail.Rows.Fixed) return;
//// 
////
////				if(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, "").Equals("") ) return;
////
////
////				string factory = ClassLib.ComFunction.Empty_Combo(cmb_MFactory, ""); 
////
////				DataTable dt_ret = null;
////				string cmb_list = "";
////
////
////				dt_ret = Select_SPB_BOM_CD(factory); 
////
////				for(int i = 0; i < dt_ret.Rows.Count; i++) 
////				{
////					cmb_list += "|" + dt_ret.Rows[i].ItemArray[0].ToString(); 
////				}
////
////				fgrid_MModelDetail.Cols[(int)ClassLib.TBSPB_MODEL.IxBOM_CD].ComboList = cmb_list; 
////				
//// 
////				dt_ret.Dispose(); 
////
////			}
////			catch(Exception ex)
////			{
////				ClassLib.ComFunction.User_Message(ex.Message, "Set_BOM_Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
////			} 
////
////
////		}
////
////
////
////		private DataTable Select_SPB_BOM_CD(string arg_factory)
////		{
////
////			DataSet ds_ret; 
//// 
////			MyOraDB.ReDim_Parameter(2); 
////
////			//01.PROCEDURE명
////			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_SPB_BOM_CD";
//// 
////			//02.ARGURMENT명
////			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
////			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
////
////			//03.DATA TYPE
////			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
////			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
////			 
////			//04.DATA 정의  
////			MyOraDB.Parameter_Values[0] = arg_factory; 
////			MyOraDB.Parameter_Values[1] = "";
////
////			MyOraDB.Add_Select_Parameter(true); 
////			ds_ret = MyOraDB.Exe_Select_Procedure();
////
////			if(ds_ret == null) return null; 
////			return ds_ret.Tables[MyOraDB.Process_Name]; 
////
////
////		}
////
////
////
////
////		public void Display_BOM()
////		{
////			try
////			{ 
////				DataTable dt_ret; 
////				Lassalle.Flow.Node node;
////
////
////				_Rowfixed = fgrid_BomNode.Rows.Fixed;
////
////				ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
////			
////				dt_ret = Select_StdBom_List(); 
////   
////				if(dt_ret.Rows.Count > 0)
////				{
////					Set_Tree(dt_ret);   
////					Select_StdBom_Node_List();
////					Select_StdBom_Link_List();
////
////					for(int i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
////					{
////						foreach(Item item in addflow_BOM.Items)
////						{
////							if(item is Lassalle.Flow.Node)
////							{
////								node = (Lassalle.Flow.Node)item; 
////
////								if(fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString() == node.Tag.ToString())
////								{
////									Select_StdRout_Node(node.Tag.ToString(), node); 
////									break;
////								}
////							} 
////						}//end foreach 
////					
////						Select_StdRout_Link(fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString()); 
////					
////
////					}
//// 
////				}
////				else
////				{
////					fgrid_BOM.Tree.Column = 1; 
////					fgrid_BOM.Rows.Count = _Rowfixed; 
////				}
////
////			}
////			catch
////			{
////			}
////		}
////
////
////		/// <summary>
////		/// Set_Tree : 그리드에 트리 형태로 데이터 구현
////		/// </summary>
////		/// <param name="arg_dt">트리로 적용될 데이터테이블</param>
////		private void Set_Tree(DataTable arg_dt)
////		{
////			try
////			{
////				fgrid_BOM.Tree.Column = 1; 
////				fgrid_BOM.Rows.Count = _Rowfixed;
////  
////				for(int i = 0; i < arg_dt.Rows.Count; i++)
////				{
////					fgrid_BOM.Rows.InsertNode(i + _Rowfixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_BOM.IxCMP_LEVEL - 1].ToString()) - 1);
////
////					fgrid_BOM[i + _Rowfixed, 0] = "";
////
////					for(int j = 1; j < fgrid_BOM.Cols.Count; j++)
////					{
////						fgrid_BOM[i + _Rowfixed, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
////					}
////
////					fgrid_BOM.AutoSizeCols();
//// 
////				}
////	   
////
////				fgrid_BOM.Tree.Style = TreeStyleFlags.Complete;
////			}
////			catch
////			{
////			}
////			 
////		}
//// 
////
////		/// <summary>
////		/// Select_StdBom_Node_List : Standard BOM Node 리스트 찾기  
////		/// </summary>
////		private void Select_StdBom_Node_List()
////		{
////			DataSet ds_ret; 
////			DataTable dt_ret;
////			Lassalle.Flow.Node node;
////
////			try
////			{ 
////				string process_name = "PKG_SPB_BOM.SELECT_STDBOM_NODELIST";
////
////				MyOraDB.ReDim_Parameter(3); 
//// 
////				MyOraDB.Process_Name = process_name;
////  
////				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
////				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
////				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
//// 
////				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
////				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
////				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
////			  
////				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString(); 
////				MyOraDB.Parameter_Values[1] = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString();  
////				MyOraDB.Parameter_Values[2] = ""; 
////
////				MyOraDB.Add_Select_Parameter(true); 
////				ds_ret = MyOraDB.Exe_Select_Procedure();
//// 
////				if(ds_ret == null) return; 
////				dt_ret = ds_ret.Tables[process_name];
////
////
////				//-------------------------------------------------------------------------------- 
////				fgrid_BomNode.Rows.Count = _Rowfixed; 
////				fgrid_BomNode.Cols.Count = dt_ret.Columns.Count + 1; 
////				_Node_Count = dt_ret.Rows.Count;
////
//// 
////				// Set List
////				for(int i = 0; i < dt_ret.Rows.Count; i++)
////				{
////					fgrid_BomNode.AddItem(dt_ret.Rows[i].ItemArray, fgrid_BomNode.Rows.Count, 1); 
////				} 
////
////
////			 
////				for(int i = _Rowfixed; i < fgrid_BomNode.Rows.Count; i++)
////				{ 
////					node = new Lassalle.Flow.Node();
////
////					node = addflow_BOM.Nodes.Add(Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxLEFT].ToString()), 
////						Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTOP].ToString()), 
////						Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxWIDTH].ToString()), 
////						Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxHEIGHT].ToString()), "");
////
////					//node.Text =  fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTEXT].ToString();
////					node.Text =  fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTAG].ToString();
////
////					node.Tooltip = node.Text;
////					node.Tag = fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTAG].ToString();  
////				
////					ClassLib.ComFunction.Set_NodeProp(fgrid_BomNode, node, i); 
////
////					//node.DrawColor = Color.LightGray;
////					//node.TextColor = Color.Gray;
////					node.Alignment = Alignment.CenterTOP; 
////  
////				} //end for 
////				//--------------------------------------------------------------------------------
//// 
////			}
////			catch
////			{  
////			}  
//// 
////		}
////
////
////
////		/// <summary>
////		/// Select_StdBom_Link_List : Standard BOM Link 리스트 찾기 
////		/// </summary>
////		private void Select_StdBom_Link_List()
////		{
////
////			DataSet ds_ret; 
////			DataTable dt_ret;
////			Lassalle.Flow.Link link; 
////			int org_index, dst_index;
////
////			try
////			{ 
////				string process_name = "PKG_SPB_BOM.SELECT_STDBOM_LINKLIST";
////
////				MyOraDB.ReDim_Parameter(3); 
//// 
////				MyOraDB.Process_Name = process_name;
////  
////				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
////				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
////				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
//// 
////				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
////				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
////				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
////			  
////				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString(); 
////				MyOraDB.Parameter_Values[1] = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString(); 
////				MyOraDB.Parameter_Values[2] = ""; 
////
////				MyOraDB.Add_Select_Parameter(true); 
////				ds_ret = MyOraDB.Exe_Select_Procedure();
//// 
////				if(ds_ret == null) return; 
////				dt_ret = ds_ret.Tables[process_name];
////
////
////				//-------------------------------------------------------------------------------- 
////				fgrid_BomLink.Rows.Count = _Rowfixed; 
////				//			fgrid_BomLink.Cols.Count = dt_ret.Columns.Count + 1; 
//// 
////				// Set List
////				for(int i = 0; i < dt_ret.Rows.Count; i++)
////				{
////					fgrid_BomLink.AddItem(dt_ret.Rows[i].ItemArray, fgrid_BomLink.Rows.Count, 1); 
////				} 
////
////
////				////////////////////////////////////////////////////////////////
////				for(int i = _Rowfixed; i < fgrid_BomLink.Rows.Count; i++)
////				{ 
////					link = new Lassalle.Flow.Link(); 
////	  
////					org_index = ClassLib.ComFunction.Get_Index(fgrid_BomNode, fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxORG_NODE].ToString(), (int)ClassLib.TBSPB_NODE_BOM.IxNODE_CD, _Rowfixed);
////					dst_index = ClassLib.ComFunction.Get_Index(fgrid_BomNode, fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxDST_NODE].ToString(), (int)ClassLib.TBSPB_NODE_BOM.IxNODE_CD, _Rowfixed);
////
////					link = addflow_BOM.Nodes[org_index].OutLinks.Add(addflow_BOM.Nodes[dst_index]);
////				
////					link.Tag = fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxTAG].ToString();  
////
////					ClassLib.ComFunction.Set_LinkProp(fgrid_BomLink, link, i);
////
////					//link.DrawColor =  Color.LightGray;
////
//// 
////				} // end for
////
////				//			_Link_Index = max_index + 1;
////				//--------------------------------------------------------------------------------
//// 
////			}
////			catch
////			{  
////			}   
//// 
////		}
////  
////
////		/// <summary>
////		/// Select_StdBom_List : 표준 BOM 리스트 찾기
////		/// </summary>
////		private DataTable Select_StdBom_List()
////		{ 
////			DataSet ds_ret; 
////
////			try
////			{ 
////				string process_name = "PKG_SPB_BOM.SELECT_STDBOM_ROUT";
////
////				MyOraDB.ReDim_Parameter(4); 
//// 
////				MyOraDB.Process_Name = process_name;
////  
////				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
////				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD";
////				MyOraDB.Parameter_Name[2] = "ARG_ROUT";  //"ARG_ROUT_TYPE"; 
////				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
//// 
////				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
////				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
////				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
////				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
////			  
////				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString();
////				MyOraDB.Parameter_Values[1] = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString(); 
////				MyOraDB.Parameter_Values[2] = ClassLib.ComVar.Rout_Type;
////				MyOraDB.Parameter_Values[3] = "";  
////
////				MyOraDB.Add_Select_Parameter(true); 
////				ds_ret = MyOraDB.Exe_Select_Procedure();
////
////				if(ds_ret == null) return null; 
////				return ds_ret.Tables[process_name]; 
////
////			}
////			catch
////			{ 
////				return null; 
////			}  
////
////		} 
////
////
////		/// <summary>
////		///  Select_StdRout_Node : Standard Routing Node 리스트 찾기  
////		/// </summary>
////		private void  Select_StdRout_Node(string arg_cmpcd, Lassalle.Flow.Node arg_node)
////		{
////			DataSet ds_ret; 
////			DataTable dt_ret;
////			Lassalle.Flow.Node node;
////			int location_x = 0, location_y = 0;
////			int pre_level, my_level;  
////			 
////
////			try
////			{ 
////				string process_name = "PKG_SPB_ROUT.SELECT_BOMROUT_NODE";
////
////				MyOraDB.ReDim_Parameter(5); 
//// 
////				MyOraDB.Process_Name = process_name;
////  
////				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
////				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
////				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";  
////				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE"; 
////				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
//// 
////				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
////				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
////				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
////				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
////				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
////			  
////				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString(); 
////				MyOraDB.Parameter_Values[1] = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString(); 
////				MyOraDB.Parameter_Values[2] = arg_cmpcd; 
////				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.Rout_Type; 
////				MyOraDB.Parameter_Values[4] = ""; 
////
////				MyOraDB.Add_Select_Parameter(true); 
////				ds_ret = MyOraDB.Exe_Select_Procedure();
//// 
////				if(ds_ret == null) return; 
////				dt_ret = ds_ret.Tables[process_name];
////
////
////				//-------------------------------------------------------------------------------- 
////				fgrid_NodeRout.Rows.Count = _Rowfixed;  
//// 
////				// Set List
////				for(int i = 0; i < dt_ret.Rows.Count; i++)
////				{
////					fgrid_NodeRout.AddItem(dt_ret.Rows[i].ItemArray, fgrid_NodeRout.Rows.Count, 1);
////				}  
////
////				///////////////////////////////////////////////////////////
////			
////				location_x = (int)(arg_node.Location.X + 5);
////				location_y = (int)(arg_node.Location.Y + 10); 
////				
////				for(int i = _Rowfixed; i < fgrid_NodeRout.Rows.Count; i++)
////				{ 
////					node = new Lassalle.Flow.Node();
////
////					node = addflow_BOM.Nodes.Add(Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxLEFT].ToString()), 
////						Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTOP].ToString()), 
////						Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxWIDTH].ToString()), 
////						Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxHEIGHT].ToString()), "");
////				
////					node.Text =  fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTEXT].ToString(); 
////					node.Tooltip = node.Text;
////
////					//tag = pcardyn (1) + routseq (3) + tag
////					//node.Tag = fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTAG].ToString();  
////					//node.Tag = arg_node.Tag;
////
////					node.Tag = fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTAG].ToString() 
////						+ fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString() 
////						+ arg_cmpcd;
////
////					if(node.Tag.ToString().Substring(0, 1) == "Y") node.Text = "*" + node.Text; 
//// 
////				
////					if(_Op_Count != 0)
////					{
////				 
////						//					pre_level = Convert.ToInt32(fgrid_NodeRout[i - 1, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 1));
////						//					my_level = Convert.ToInt32(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 1));
////
////
////						pre_level = Convert.ToInt32(fgrid_NodeRout[i - 1, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 2));
////						my_level = Convert.ToInt32(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 2));
//// 
////						if(pre_level == my_level)    //같은 레벨이 뒤따라 올때 X 좌표값 증가해서 옆에 표시
////						{
////							location_x = location_x + (int)node.Size.Width + 5;
////						}
////						else                         //다른 레벨이 뒤따라 올때 Y 좌표값 증가해서 아래에 표시
////						{
////							location_y = location_y + (int)node.Size.Height + 30; 
////						}
//// 
////
////					}
////
////					node.Location = new Point(location_x, location_y); 
////
////					ClassLib.ComFunction.Set_NodeProp(fgrid_NodeRout, node, i); 
////
////					//				arg_node.Hidden = true;
////
////					_Op_Count++;
////  
////				} //end for  
////				//--------------------------------------------------------------------------------
//// 
////			}
////			catch 
////			{ 
////			}
//// 
////		}
////
////
////
////		/// <summary>
////		/// Select_StdRout_Link : Standard Routing  Link 리스트 찾기 
////		/// </summary>
////		private void Select_StdRout_Link(string arg_cmpcd)
////		{
////			DataSet ds_ret; 
////			DataTable dt_ret;
////			Lassalle.Flow.Link link; 
////			int org_index, dst_index; 
////
////			try
////			{ 
////				string process_name =  "PKG_SPB_ROUT.SELECT_BOMROUT_LINK";
////
////				MyOraDB.ReDim_Parameter(5); 
//// 
////				MyOraDB.Process_Name = process_name;
////  
////				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
////				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
////				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";  
////				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE"; 
////				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
//// 
////				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
////				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
////				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
////				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
////				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 
////
////				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString(); 
////				MyOraDB.Parameter_Values[1] = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString(); 
////				MyOraDB.Parameter_Values[2] = arg_cmpcd; 
////				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.Rout_Type;  
////				MyOraDB.Parameter_Values[4] = "";  
////
////				MyOraDB.Add_Select_Parameter(true); 
////				ds_ret = MyOraDB.Exe_Select_Procedure();
//// 
////				if(ds_ret == null) return; 
////				dt_ret = ds_ret.Tables[process_name];
////
////
////				//-------------------------------------------------------------------------------- 
////				fgrid_LinkRout.Rows.Count = _Rowfixed;  
//// 
////				// Set List
////				for(int i = 0; i < dt_ret.Rows.Count; i++)
////				{
////					fgrid_LinkRout.AddItem(dt_ret.Rows[i].ItemArray, fgrid_LinkRout.Rows.Count, 1); 
////				} 
////
////
////				////////////////////////////////////////////////////////////////
////				for(int i = _Rowfixed; i < fgrid_LinkRout.Rows.Count; i++)
////				{ 
////					link = new Lassalle.Flow.Link(); 
////	  
////					org_index = ClassLib.ComFunction.Get_Index(fgrid_NodeRout, fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxORG_NODE].ToString(), (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD, _Rowfixed) + _Node_Count;
////					dst_index = ClassLib.ComFunction.Get_Index(fgrid_NodeRout, fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxDST_NODE].ToString(), (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD, _Rowfixed) + _Node_Count;
////				
////					link = addflow_BOM.Nodes[org_index].OutLinks.Add(addflow_BOM.Nodes[dst_index]);
////				
////					link.Tag = fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxTAG].ToString(); 
//// 
////					ClassLib.ComFunction.Set_LinkProp(fgrid_LinkRout, link, i);
////
////
////					//				if(max_index <= Convert.ToInt32(link.Tag))  max_index = Convert.ToInt32(link.Tag); 
////				
////				
////				} // end for
////
////				//			_Link_Index = max_index + 1;
////
////			 
////				_Node_Count = _Node_Count + _Op_Count;
////				_Op_Count = 0;
////			
////				//--------------------------------------------------------------------------------
//// 
////			}
////			catch
////			{  
////			}    
////		  
////
////
////		}


		#endregion  
 


		#endregion 
	
		#region model tran
		
	
		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				Label src = sender as Label;
				src.ImageIndex = 1;
			}
			catch
			{
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				Label src = sender as Label;
				src.ImageIndex = 0;
			}
			catch
			{
			}
		}

		private void txt_Model_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Enter)
				{
					//SELECT_MOLD_SIZE_NEW_LIST();
					DataTable dt_ret = Select_Model_List();
					ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MMModel, 0, 1, false, false);
				}
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private DataTable Select_Model_List()
		{			
			//DataSet DS_Ret;
			MyOraDB.ReDim_Parameter(2);

			string Proc_Name = "pkg_sbc_model.select_sdc_mstyle_list2";
			
			MyOraDB.Process_Name = Proc_Name;

			MyOraDB.Parameter_Name[0] = "ARG_STYLE_NAME";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = txt_Model.Text.Trim().ToUpper();//  "VJ";
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];

		}

		
////		private void btn_TranModel_Click(object sender, System.EventArgs e)
////		{
////			DataTable dt_ret;
////			bool save_flag = false;
////
////			try
////			{
////				dt_ret = Save_ModelTran();
////				
////				if(dt_ret == null) return;
////
////				save_flag = Save_StyleTran(); 
////
////				if(!save_flag)
////				{
////					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
////					return;
////				}
////				else
////				{
////					// 신규 모델 info
////					int dt_row = dt_ret.Rows.Count;
////
////					if(dt_row > 0)
////					{
////						string message = "";
////
////						int model_name = 1;
////
////						for(int i=0; i<dt_row; i++)
////						{
////							message += dt_ret.Rows[i].ItemArray[model_name].ToString() + "\r\n";
////						}
////
////
////						ClassLib.ComFunction comfunc = new FlexAPS.ClassLib.ComFunction();
////						comfunc.AutoWorkMessage(this.Name, "E001", message);
////					}
////
////					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
////				
////					//refresh
////					dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
////						ClassLib.ComFunction.Empty_Combo(cmb_MDYear, " "));
////					Display_Grid(dt_ret, fgrid_MModelDetail);
////
////					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
////
//// 				}
////
////			}
////			catch
////			{
////			}
////		}
////		
////
////		/// <summary>
////		/// Save_ModelTran : 신규 모델 자동 저장 -> 신규 모델 리스트 리턴
////		/// </summary>
////		/// <returns></returns>
////		private DataTable Save_ModelTran()
////		{
////			DataSet ds_ret;
////
////			try
////			{
////				MyOraDB.ReDim_Parameter(3); 
////  
////				string process_name = "PKG_SPB_MODEL_BSC.TRANS_MODEL";
////				MyOraDB.Process_Name = process_name;
////  
////				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
////				MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";  
////				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
//// 
////				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
////				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
////				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
////			  
////				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString();  
////				MyOraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;
////				MyOraDB.Parameter_Values[2] = ""; 
////
////				MyOraDB.Add_Select_Parameter(true); 
////				ds_ret = MyOraDB.Exe_Select_Procedure();
////
////				if(ds_ret == null) return null ; 
////				return ds_ret.Tables[process_name];
////			}
////			catch
////			{
////				return null;
////			}
////		}
////
////		/// <summary>
////		/// Save_StyleTran : 신규 스타일 자동 저장
////		/// </summary>
////		/// <returns></returns>
////		private bool Save_StyleTran()
////		{
////			try
////			{
////				MyOraDB.ReDim_Parameter(2);
////				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.TRANS_STYLE";
////
////				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
////				MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";
////
////				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
////				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
////			
////				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString();  
////				MyOraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;  
////
////				MyOraDB.Add_Modify_Parameter(true);	 
////				MyOraDB.Exe_Modify_Procedure();	 
////				return true;
////			}
////			catch
////			{
////				return false;
////			}
////		}
////
////
////
////
////		/// <summary>
////		/// Save_SPB_MODEL_WITH_MPS_LOT : 
////		/// </summary>
////		/// <returns></returns>
////		private bool Save_SPB_MODEL_WITH_MPS_LOT()
////		{
////
////			try
////			{ 
////
////
////				this.Cursor = Cursors.WaitCursor;
//// 
////				//---------------------------------------------------------------------------
////				//1. spb_model
////				//--------------------------------------------------------------------------- 
////				int col_ct = 10;  						 
////				int row = 0;
////				
////
////
////				MyOraDB.ReDim_Parameter(col_ct);
////				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SAVE_SPB_MODEL";
////
////				// 파라미터 이름 설정
////				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
////				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
////				MyOraDB.Parameter_Name[2] = "ARG_MODEL_CD"; 
////				MyOraDB.Parameter_Name[3] = "ARG_MODEL_NAME";
////				MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
////				MyOraDB.Parameter_Name[5] = "ARG_BOM_CD";
////				MyOraDB.Parameter_Name[6] = "ARG_LINE_QTY"; 
////				MyOraDB.Parameter_Name[7] = "ARG_REMARKS";
////				MyOraDB.Parameter_Name[8] = "ARG_BOM_CD_OLD"; 
////				MyOraDB.Parameter_Name[9] = "ARG_UPD_USER";  
//// 
////
////				// 파라미터의 데이터 Type
////				for(int i = 0; i < col_ct ; i++)
////				{
////					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
////				} 
////				 
////
////				// 파라미터 값에 저장할 배열
////				ArrayList vList = new ArrayList();  
////
////
////				for(row = fgrid_MModelDetail.Rows.Fixed; row < fgrid_MModelDetail.Rows.Count; row++)
////				{
////
////					if(fgrid_MModelDetail[row, 0] == null || fgrid_MModelDetail[row, 0].ToString().Trim().Equals("") ) continue;
////
////    
////					vList.Add(fgrid_MModelDetail[row, 0].ToString());
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxFACTORY].ToString());
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxMODEL_CD].ToString()); 
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxMODEL_NAME].ToString()); 
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxCATEGORY].ToString()); 
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString()); 
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxLINE_QTY].ToString()); 
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxREMARKS].ToString()); 
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxBOM_CD_OLD].ToString()); 
////					vList.Add(ClassLib.ComVar.This_User); 
////
////
////				} // end for row
////
////
////				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 
////
////				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
////
////
////
////
////
////				//---------------------------------------------------------------------------
////				//1. Model BOM 이 수정되었을 경우, MPS 의 LOT 에도 BOM 변경 사항 반영
////				//--------------------------------------------------------------------------- 
////				col_ct = 5;  	
//// 
////
////				MyOraDB.ReDim_Parameter(col_ct);
////				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.CHANGE_MODEL_BOM_IN_MPS_LOT";
////
////				// 파라미터 이름 설정
////				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
////				MyOraDB.Parameter_Name[1] = "ARG_MODEL_CD";
////				MyOraDB.Parameter_Name[2] = "ARG_BOM_CD_OLD"; 
////				MyOraDB.Parameter_Name[3] = "ARG_BOM_CD_NEW";
////				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER"; 
//// 
////
////				// 파라미터의 데이터 Type
////				for(int i = 0; i < col_ct ; i++)
////				{
////					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
////				} 
////				 
////
////				vList.Clear();
////				// 파라미터 값에 저장할 배열
////				vList = new ArrayList();  
////
////
////				for(row = fgrid_MModelDetail.Rows.Fixed; row < fgrid_MModelDetail.Rows.Count; row++)
////				{
////
////					if(fgrid_MModelDetail[row, 0] == null || fgrid_MModelDetail[row, 0].ToString().Trim().Equals("") ) continue;
////
////     
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxFACTORY].ToString());
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxMODEL_CD].ToString());  
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxBOM_CD_OLD].ToString()); 
////					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString());   
////					vList.Add(ClassLib.ComVar.This_User); 
////
////
////				} // end for row
////
////
////				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 
////
////				MyOraDB.Add_Modify_Parameter(false);		// 파라미터 데이터를 DataSet에 추가 
////
////
////
////
////
////
////				// db 반영
////				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
////
////				if(ds_ret == null)
////				{
////					return false;
////				}
////				else
////				{
////					return true;
////				}
////
////			}
////			catch
////			{  
////				return false;
////			} 
////			finally
////			{
////				this.Cursor = Cursors.Default;
////			}
////
////
////		}




		#endregion






	}
}

