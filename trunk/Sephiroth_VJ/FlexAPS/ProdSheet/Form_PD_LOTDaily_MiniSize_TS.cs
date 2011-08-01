using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexAPS.ProdSheet
{
	public class Form_PD_LOTDaily_MiniSize_TS : COM.APSWinForm.Form_Top
	{
		
		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.ContextMenu cmenu_Grid;
		private System.Windows.Forms.MenuItem menuItem_Clear;
		private System.Windows.Forms.MenuItem menuItem_AddRow;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_Tail;
		public System.Windows.Forms.Panel pnl_TailSearch;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.TextBox txt_DaySeq;
		private System.Windows.Forms.Label lbl_DaySeq;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_Level4;
		private System.Windows.Forms.RadioButton rad_Level3;
		private System.Windows.Forms.RadioButton rad_Level2;
		private System.Windows.Forms.RadioButton rad_Level1;
		private System.Windows.Forms.Label lbl_LOT;
		private System.Windows.Forms.TextBox txt_LOT;
		private System.Windows.Forms.TextBox txt_Model;
		private System.Windows.Forms.TextBox txt_LineName;
		private System.Windows.Forms.Label lbl_LineCd1;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_Model;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Panel pnl_Head;
		public System.Windows.Forms.Panel pnl_HeadSearch;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private C1.Win.C1List.C1Combo cmb_LineCd;
		private System.Windows.Forms.Label lbl_LineCd;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.DateTimePicker dpick_ToYMD;
		private System.Windows.Forms.TextBox txt_Font;
		private System.Windows.Forms.Label lbl_Font;
		public System.Windows.Forms.DateTimePicker dpick_FromYMD;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.RadioButton rad_Level5;
		private System.Windows.Forms.Label btn_Check;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Finish;
		public COM.FSP fgrid_MiniSizeTS;
		private System.Windows.Forms.Label btn_AssignTS;
		private COM.FSP fgrid_MiniSize;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자


		public Form_PD_LOTDaily_MiniSize_TS()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PD_LOTDaily_MiniSize_TS));
			this.cmenu_Grid = new System.Windows.Forms.ContextMenu();
			this.menuItem_Clear = new System.Windows.Forms.MenuItem();
			this.menuItem_AddRow = new System.Windows.Forms.MenuItem();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_Tail = new System.Windows.Forms.Panel();
			this.fgrid_MiniSizeTS = new COM.FSP();
			this.pnl_TailSearch = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_DaySeq = new System.Windows.Forms.TextBox();
			this.lbl_DaySeq = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rad_Level5 = new System.Windows.Forms.RadioButton();
			this.rad_Level4 = new System.Windows.Forms.RadioButton();
			this.rad_Level3 = new System.Windows.Forms.RadioButton();
			this.rad_Level2 = new System.Windows.Forms.RadioButton();
			this.rad_Level1 = new System.Windows.Forms.RadioButton();
			this.lbl_LOT = new System.Windows.Forms.Label();
			this.txt_LOT = new System.Windows.Forms.TextBox();
			this.txt_Model = new System.Windows.Forms.TextBox();
			this.txt_LineName = new System.Windows.Forms.TextBox();
			this.lbl_LineCd1 = new System.Windows.Forms.Label();
			this.txt_Gen = new System.Windows.Forms.TextBox();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_Model = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.pnl_Head = new System.Windows.Forms.Panel();
			this.fgrid_MiniSize = new COM.FSP();
			this.pnl_HeadSearch = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_AssignTS = new System.Windows.Forms.Label();
			this.btn_Check = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.btn_Finish = new System.Windows.Forms.Label();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.cmb_LineCd = new C1.Win.C1List.C1Combo();
			this.lbl_LineCd = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
			this.txt_Font = new System.Windows.Forms.TextBox();
			this.lbl_Font = new System.Windows.Forms.Label();
			this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_Tail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MiniSizeTS)).BeginInit();
			this.pnl_TailSearch.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.pnl_Head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MiniSize)).BeginInit();
			this.pnl_HeadSearch.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// cmenu_Grid
			// 
			this.cmenu_Grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem_Clear,
																					   this.menuItem_AddRow});
			// 
			// menuItem_Clear
			// 
			this.menuItem_Clear.Index = 0;
			this.menuItem_Clear.Text = "Clear";
			this.menuItem_Clear.Click += new System.EventHandler(this.menuItem_Clear_Click);
			// 
			// menuItem_AddRow
			// 
			this.menuItem_AddRow.Index = 1;
			this.menuItem_AddRow.Text = "Add Hourly Sequence";
			this.menuItem_AddRow.Click += new System.EventHandler(this.menuItem_AddRow_Click);
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.SystemColors.Window;
			this.c1Sizer1.Controls.Add(this.pnl_Tail);
			this.c1Sizer1.Controls.Add(this.pnl_Head);
			this.c1Sizer1.GridDefinition = "35.4166666666667:True:False;62.5:False:False;\t99.2125984251968:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 30;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_Tail
			// 
			this.pnl_Tail.Controls.Add(this.fgrid_MiniSizeTS);
			this.pnl_Tail.Controls.Add(this.pnl_TailSearch);
			this.pnl_Tail.Location = new System.Drawing.Point(4, 212);
			this.pnl_Tail.Name = "pnl_Tail";
			this.pnl_Tail.Size = new System.Drawing.Size(1008, 360);
			this.pnl_Tail.TabIndex = 1;
			// 
			// fgrid_MiniSizeTS
			// 
			this.fgrid_MiniSizeTS.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_MiniSizeTS.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_MiniSizeTS.ContextMenu = this.cmenu_Grid;
			this.fgrid_MiniSizeTS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_MiniSizeTS.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_MiniSizeTS.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveDown;
			this.fgrid_MiniSizeTS.Location = new System.Drawing.Point(0, 43);
			this.fgrid_MiniSizeTS.Name = "fgrid_MiniSizeTS";
			this.fgrid_MiniSizeTS.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_MiniSizeTS.Size = new System.Drawing.Size(1008, 317);
			this.fgrid_MiniSizeTS.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_MiniSizeTS.TabIndex = 44;
			this.fgrid_MiniSizeTS.Click += new System.EventHandler(this.fgrid_MiniSizeTS_Click);
			this.fgrid_MiniSizeTS.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MiniSizeTS_BeforeEdit);
			this.fgrid_MiniSizeTS.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.fgrid_MiniSizeTS_OwnerDrawCell);
			this.fgrid_MiniSizeTS.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MiniSizeTS_AfterEdit);
			// 
			// pnl_TailSearch
			// 
			this.pnl_TailSearch.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_TailSearch.Controls.Add(this.pnl_SearchImage);
			this.pnl_TailSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_TailSearch.DockPadding.Bottom = 5;
			this.pnl_TailSearch.Location = new System.Drawing.Point(0, 0);
			this.pnl_TailSearch.Name = "pnl_TailSearch";
			this.pnl_TailSearch.Size = new System.Drawing.Size(1008, 43);
			this.pnl_TailSearch.TabIndex = 36;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_DaySeq);
			this.pnl_SearchImage.Controls.Add(this.lbl_DaySeq);
			this.pnl_SearchImage.Controls.Add(this.groupBox1);
			this.pnl_SearchImage.Controls.Add(this.lbl_LOT);
			this.pnl_SearchImage.Controls.Add(this.txt_LOT);
			this.pnl_SearchImage.Controls.Add(this.txt_Model);
			this.pnl_SearchImage.Controls.Add(this.txt_LineName);
			this.pnl_SearchImage.Controls.Add(this.lbl_LineCd1);
			this.pnl_SearchImage.Controls.Add(this.txt_Gen);
			this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_Model);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle2);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1008, 38);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// txt_DaySeq
			// 
			this.txt_DaySeq.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_DaySeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_DaySeq.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_DaySeq.Location = new System.Drawing.Point(625, 10);
			this.txt_DaySeq.MaxLength = 60;
			this.txt_DaySeq.Name = "txt_DaySeq";
			this.txt_DaySeq.ReadOnly = true;
			this.txt_DaySeq.Size = new System.Drawing.Size(20, 21);
			this.txt_DaySeq.TabIndex = 199;
			this.txt_DaySeq.Text = "";
			// 
			// lbl_DaySeq
			// 
			this.lbl_DaySeq.ImageIndex = 0;
			this.lbl_DaySeq.ImageList = this.img_SmallLabel;
			this.lbl_DaySeq.Location = new System.Drawing.Point(578, 10);
			this.lbl_DaySeq.Name = "lbl_DaySeq";
			this.lbl_DaySeq.Size = new System.Drawing.Size(46, 21);
			this.lbl_DaySeq.TabIndex = 198;
			this.lbl_DaySeq.Text = "Day";
			this.lbl_DaySeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rad_Level5);
			this.groupBox1.Controls.Add(this.rad_Level4);
			this.groupBox1.Controls.Add(this.rad_Level3);
			this.groupBox1.Controls.Add(this.rad_Level2);
			this.groupBox1.Controls.Add(this.rad_Level1);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8F);
			this.groupBox1.Location = new System.Drawing.Point(682, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(318, 32);
			this.groupBox1.TabIndex = 45;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "View Option";
			// 
			// rad_Level5
			// 
			this.rad_Level5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Level5.Location = new System.Drawing.Point(231, 14);
			this.rad_Level5.Name = "rad_Level5";
			this.rad_Level5.Size = new System.Drawing.Size(81, 16);
			this.rad_Level5.TabIndex = 4;
			this.rad_Level5.Tag = "4";
			this.rad_Level5.Text = "Time Priod";
			this.rad_Level5.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_Level4
			// 
			this.rad_Level4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Level4.Location = new System.Drawing.Point(165, 14);
			this.rad_Level4.Name = "rad_Level4";
			this.rad_Level4.Size = new System.Drawing.Size(66, 16);
			this.rad_Level4.TabIndex = 3;
			this.rad_Level4.Tag = "3";
			this.rad_Level4.Text = "MiniLine";
			this.rad_Level4.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_Level3
			// 
			this.rad_Level3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Level3.Location = new System.Drawing.Point(121, 14);
			this.rad_Level3.Name = "rad_Level3";
			this.rad_Level3.Size = new System.Drawing.Size(44, 16);
			this.rad_Level3.TabIndex = 2;
			this.rad_Level3.Tag = "2";
			this.rad_Level3.Text = "Day";
			this.rad_Level3.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_Level2
			// 
			this.rad_Level2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Level2.Location = new System.Drawing.Point(53, 14);
			this.rad_Level2.Name = "rad_Level2";
			this.rad_Level2.Size = new System.Drawing.Size(68, 16);
			this.rad_Level2.TabIndex = 1;
			this.rad_Level2.Tag = "1";
			this.rad_Level2.Text = "Request";
			this.rad_Level2.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_Level1
			// 
			this.rad_Level1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Level1.Location = new System.Drawing.Point(8, 14);
			this.rad_Level1.Name = "rad_Level1";
			this.rad_Level1.Size = new System.Drawing.Size(45, 16);
			this.rad_Level1.TabIndex = 0;
			this.rad_Level1.Tag = "0";
			this.rad_Level1.Text = "LOT";
			this.rad_Level1.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// lbl_LOT
			// 
			this.lbl_LOT.ImageIndex = 0;
			this.lbl_LOT.ImageList = this.img_SmallLabel;
			this.lbl_LOT.Location = new System.Drawing.Point(432, 10);
			this.lbl_LOT.Name = "lbl_LOT";
			this.lbl_LOT.Size = new System.Drawing.Size(50, 21);
			this.lbl_LOT.TabIndex = 111;
			this.lbl_LOT.Text = "LOT";
			this.lbl_LOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LOT
			// 
			this.txt_LOT.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOT.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LOT.Location = new System.Drawing.Point(483, 10);
			this.txt_LOT.MaxLength = 60;
			this.txt_LOT.Name = "txt_LOT";
			this.txt_LOT.ReadOnly = true;
			this.txt_LOT.Size = new System.Drawing.Size(85, 21);
			this.txt_LOT.TabIndex = 112;
			this.txt_LOT.Text = "";
			// 
			// txt_Model
			// 
			this.txt_Model.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Model.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Model.Location = new System.Drawing.Point(203, 10);
			this.txt_Model.MaxLength = 60;
			this.txt_Model.Name = "txt_Model";
			this.txt_Model.ReadOnly = true;
			this.txt_Model.TabIndex = 125;
			this.txt_Model.Text = "";
			// 
			// txt_LineName
			// 
			this.txt_LineName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineName.Location = new System.Drawing.Point(61, 10);
			this.txt_LineName.MaxLength = 60;
			this.txt_LineName.Name = "txt_LineName";
			this.txt_LineName.ReadOnly = true;
			this.txt_LineName.Size = new System.Drawing.Size(80, 21);
			this.txt_LineName.TabIndex = 118;
			this.txt_LineName.Text = "";
			// 
			// lbl_LineCd1
			// 
			this.lbl_LineCd1.ImageIndex = 0;
			this.lbl_LineCd1.ImageList = this.img_SmallLabel;
			this.lbl_LineCd1.Location = new System.Drawing.Point(10, 10);
			this.lbl_LineCd1.Name = "lbl_LineCd1";
			this.lbl_LineCd1.Size = new System.Drawing.Size(50, 21);
			this.lbl_LineCd1.TabIndex = 117;
			this.lbl_LineCd1.Text = "Line";
			this.lbl_LineCd1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Gen
			// 
			this.txt_Gen.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Gen.Location = new System.Drawing.Point(385, 10);
			this.txt_Gen.MaxLength = 60;
			this.txt_Gen.Name = "txt_Gen";
			this.txt_Gen.ReadOnly = true;
			this.txt_Gen.Size = new System.Drawing.Size(36, 21);
			this.txt_Gen.TabIndex = 109;
			this.txt_Gen.Text = "";
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(304, 10);
			this.txt_StyleCd.MaxLength = 60;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.ReadOnly = true;
			this.txt_StyleCd.Size = new System.Drawing.Size(80, 21);
			this.txt_StyleCd.TabIndex = 108;
			this.txt_StyleCd.Text = "";
			// 
			// lbl_Model
			// 
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_SmallLabel;
			this.lbl_Model.Location = new System.Drawing.Point(152, 10);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(50, 21);
			this.lbl_Model.TabIndex = 107;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(991, 8);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(17, 22);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(992, -5);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(16, 13);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(16, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(992, 32);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, -2);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(16, 8);
			this.lbl_SubTitle2.TabIndex = 28;
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(992, 23);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 22);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(848, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 23);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 0);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 30);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
			this.picb_MM.Location = new System.Drawing.Point(160, 24);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.Size = new System.Drawing.Size(840, 0);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// pnl_Head
			// 
			this.pnl_Head.Controls.Add(this.fgrid_MiniSize);
			this.pnl_Head.Controls.Add(this.pnl_HeadSearch);
			this.pnl_Head.Location = new System.Drawing.Point(4, 4);
			this.pnl_Head.Name = "pnl_Head";
			this.pnl_Head.Size = new System.Drawing.Size(1008, 204);
			this.pnl_Head.TabIndex = 0;
			// 
			// fgrid_MiniSize
			// 
			this.fgrid_MiniSize.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_MiniSize.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_MiniSize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_MiniSize.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_MiniSize.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_MiniSize.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_MiniSize.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_MiniSize.Location = new System.Drawing.Point(0, 65);
			this.fgrid_MiniSize.Name = "fgrid_MiniSize";
			this.fgrid_MiniSize.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_MiniSize.Size = new System.Drawing.Size(1008, 139);
			this.fgrid_MiniSize.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_MiniSize.TabIndex = 43;
			this.fgrid_MiniSize.Click += new System.EventHandler(this.fgrid_MiniSize_Click);
			// 
			// pnl_HeadSearch
			// 
			this.pnl_HeadSearch.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_HeadSearch.Controls.Add(this.panel1);
			this.pnl_HeadSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_HeadSearch.DockPadding.Bottom = 3;
			this.pnl_HeadSearch.Location = new System.Drawing.Point(0, 0);
			this.pnl_HeadSearch.Name = "pnl_HeadSearch";
			this.pnl_HeadSearch.Size = new System.Drawing.Size(1008, 65);
			this.pnl_HeadSearch.TabIndex = 42;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.btn_AssignTS);
			this.panel1.Controls.Add(this.btn_Check);
			this.panel1.Controls.Add(this.btn_Cancel);
			this.panel1.Controls.Add(this.btn_Finish);
			this.panel1.Controls.Add(this.lbl_PlanYMD);
			this.panel1.Controls.Add(this.cmb_LineCd);
			this.panel1.Controls.Add(this.lbl_LineCd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dpick_ToYMD);
			this.panel1.Controls.Add(this.txt_Font);
			this.panel1.Controls.Add(this.lbl_Font);
			this.panel1.Controls.Add(this.dpick_FromYMD);
			this.panel1.Controls.Add(this.cmb_Factory);
			this.panel1.Controls.Add(this.lbl_Factory);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.lbl_SubTitle1);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.pictureBox7);
			this.panel1.Controls.Add(this.pictureBox8);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1008, 62);
			this.panel1.TabIndex = 18;
			// 
			// btn_AssignTS
			// 
			this.btn_AssignTS.ImageIndex = 0;
			this.btn_AssignTS.ImageList = this.img_Button;
			this.btn_AssignTS.Location = new System.Drawing.Point(552, 33);
			this.btn_AssignTS.Name = "btn_AssignTS";
			this.btn_AssignTS.Size = new System.Drawing.Size(80, 23);
			this.btn_AssignTS.TabIndex = 205;
			this.btn_AssignTS.Text = "Assign TS";
			this.btn_AssignTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_AssignTS.Click += new System.EventHandler(this.btn_AssignTS_Click);
			this.btn_AssignTS.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_AssignTS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_AssignTS.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_AssignTS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Check
			// 
			this.btn_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Check.ImageIndex = 0;
			this.btn_Check.ImageList = this.img_Button;
			this.btn_Check.Location = new System.Drawing.Point(662, 33);
			this.btn_Check.Name = "btn_Check";
			this.btn_Check.Size = new System.Drawing.Size(80, 23);
			this.btn_Check.TabIndex = 204;
			this.btn_Check.Text = "Check TS";
			this.btn_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
			this.btn_Check.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Check.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Check.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Check.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(824, 33);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(80, 23);
			this.btn_Cancel.TabIndex = 203;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Finish
			// 
			this.btn_Finish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Finish.ImageIndex = 0;
			this.btn_Finish.ImageList = this.img_Button;
			this.btn_Finish.Location = new System.Drawing.Point(743, 33);
			this.btn_Finish.Name = "btn_Finish";
			this.btn_Finish.Size = new System.Drawing.Size(80, 23);
			this.btn_Finish.TabIndex = 202;
			this.btn_Finish.Text = "Finish";
			this.btn_Finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
			this.btn_Finish.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Finish.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Finish.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Finish.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.ImageIndex = 0;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(176, 34);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 35;
			this.lbl_PlanYMD.Text = "Assy. Date";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_LineCd
			// 
			this.cmb_LineCd.AddItemCols = 0;
			this.cmb_LineCd.AddItemSeparator = ';';
			this.cmb_LineCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LineCd.Caption = "";
			this.cmb_LineCd.CaptionHeight = 17;
			this.cmb_LineCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LineCd.ColumnCaptionHeight = 18;
			this.cmb_LineCd.ColumnFooterHeight = 18;
			this.cmb_LineCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LineCd.ContentHeight = 17;
			this.cmb_LineCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LineCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LineCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LineCd.EditorHeight = 17;
			this.cmb_LineCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineCd.GapHeight = 2;
			this.cmb_LineCd.ItemHeight = 15;
			this.cmb_LineCd.Location = new System.Drawing.Point(441, 34);
			this.cmb_LineCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_LineCd.MaxDropDownItems = ((short)(5));
			this.cmb_LineCd.MaxLength = 32767;
			this.cmb_LineCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LineCd.Name = "cmb_LineCd";
			this.cmb_LineCd.PartialRightColumn = false;
			this.cmb_LineCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_LineCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LineCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.Size = new System.Drawing.Size(100, 21);
			this.cmb_LineCd.TabIndex = 73;
			this.cmb_LineCd.SelectedValueChanged += new System.EventHandler(this.cmb_LineCd_SelectedValueChanged);
			// 
			// lbl_LineCd
			// 
			this.lbl_LineCd.ImageIndex = 0;
			this.lbl_LineCd.ImageList = this.img_SmallLabel;
			this.lbl_LineCd.Location = new System.Drawing.Point(390, 34);
			this.lbl_LineCd.Name = "lbl_LineCd";
			this.lbl_LineCd.Size = new System.Drawing.Size(50, 21);
			this.lbl_LineCd.TabIndex = 72;
			this.lbl_LineCd.Text = "Line";
			this.lbl_LineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(280, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 21);
			this.label1.TabIndex = 193;
			this.label1.Text = "~";
			this.label1.Visible = false;
			// 
			// dpick_ToYMD
			// 
			this.dpick_ToYMD.CustomFormat = "yyyyMMdd";
			this.dpick_ToYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ToYMD.Location = new System.Drawing.Point(296, 8);
			this.dpick_ToYMD.Name = "dpick_ToYMD";
			this.dpick_ToYMD.Size = new System.Drawing.Size(100, 22);
			this.dpick_ToYMD.TabIndex = 195;
			this.dpick_ToYMD.Visible = false;
			this.dpick_ToYMD.CloseUp += new System.EventHandler(this.dpick_CloseUp);
			this.dpick_ToYMD.ValueChanged += new System.EventHandler(this.dpick_ValueChanged);
			// 
			// txt_Font
			// 
			this.txt_Font.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_Font.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Font.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Font.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Font.Location = new System.Drawing.Point(963, 34);
			this.txt_Font.MaxLength = 60;
			this.txt_Font.Name = "txt_Font";
			this.txt_Font.Size = new System.Drawing.Size(35, 21);
			this.txt_Font.TabIndex = 196;
			this.txt_Font.Text = "";
			this.txt_Font.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Font_KeyPress);
			this.txt_Font.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Font_KeyUp);
			// 
			// lbl_Font
			// 
			this.lbl_Font.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Font.ImageIndex = 0;
			this.lbl_Font.ImageList = this.img_SmallLabel;
			this.lbl_Font.Location = new System.Drawing.Point(912, 34);
			this.lbl_Font.Name = "lbl_Font";
			this.lbl_Font.Size = new System.Drawing.Size(50, 21);
			this.lbl_Font.TabIndex = 195;
			this.lbl_Font.Text = "Font";
			this.lbl_Font.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_FromYMD
			// 
			this.dpick_FromYMD.CustomFormat = "yyyyMMdd";
			this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_FromYMD.Location = new System.Drawing.Point(277, 34);
			this.dpick_FromYMD.Name = "dpick_FromYMD";
			this.dpick_FromYMD.Size = new System.Drawing.Size(100, 22);
			this.dpick_FromYMD.TabIndex = 194;
			this.dpick_FromYMD.CloseUp += new System.EventHandler(this.dpick_CloseUp);
			this.dpick_FromYMD.ValueChanged += new System.EventHandler(this.dpick_ValueChanged);
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
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(61, 34);
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(100, 21);
			this.cmb_Factory.TabIndex = 33;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_SmallLabel;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 34);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(50, 21);
			this.lbl_Factory.TabIndex = 32;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(993, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(15, 22);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(992, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(224, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(784, 32);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      LOT Information";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(992, 46);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 16);
			this.pictureBox4.TabIndex = 23;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(144, 44);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(848, 18);
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 42);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(168, 20);
			this.pictureBox6.TabIndex = 22;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(168, 22);
			this.pictureBox7.TabIndex = 25;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(160, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(840, 22);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// Form_PD_LOTDaily_MiniSize_TS
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_PD_LOTDaily_MiniSize_TS";
			this.Text = "Time Sequence";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PD_LOTDaily_MiniSize_TS_Closing);
			this.Load += new System.EventHandler(this.Form_PD_LOTDaily_MiniSize_TS_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_Tail.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MiniSizeTS)).EndInit();
			this.pnl_TailSearch.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.pnl_Head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MiniSize)).EndInit();
			this.pnl_HeadSearch.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion  
		
		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction();
 

		
		//MPS 폼에서 파라미터로 넘어오는 값 
		private string _Factory, _PlanYMD, _Line;


		//선택되어졌던 젠더 행
		private int _BeforeGenRow = -1;

		//수정하기 전 수량
		private string _BeforeQty;


		//표시 레벨 정보
		private int _Level_LOT = 0;
		private int _Level_Req = 1;
		private int _Level_Day = 2;
		private int _Level_MLine = 3;
		private int _Level_InputPrio = 4; 

		
		//Balance 맞지 않는 수량 카운트 : 저장 시 정합성 체크 여부로 참조
		private int _Count_UnBalance_Qty = 0;

//
//		// border info
//		private SolidBrush  _bdrBrush;
//		private int         _bdrOutside;
//		private int         _bdrInside;
 
 



		//input_prio 별 최대 사이즈 수량
		private int _MaxHourlyQty = 168;    // 12 * 14 (최대 cs_size_seq) = 168



        //// thread process wait. form
        //private FlexAPS.ProdBase.Pop_ProcessWait _PopForm;


		// thread return value
		private bool _Thread_Run_Flag = false;



		#endregion 

		#region 멤버 메서드


		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			
			try
			{ 
 

				//Title
				this.Text = "Assign Time Sequence";
				lbl_MainTitle.Text = "Assign Time Sequence"; 
  


				fgrid_MiniSize.Set_Grid("SPO_LOT_DAILY_MINI_H", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_MiniSize.ExtendLastCol = false;
				fgrid_MiniSize.AllowEditing = false;
				fgrid_MiniSize.AllowSorting = AllowSortingEnum.None;
				fgrid_MiniSize.AllowDragging = AllowDraggingEnum.None;
				fgrid_MiniSize.Font = new Font("Verdana", 7);
				fgrid_MiniSize.Styles.Alternate.BackColor = Color.White; 
 

				fgrid_MiniSizeTS.Set_Grid("SPD_LOT_DAILY_MINI_TS_SIZE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_MiniSizeTS.Set_Action_Image(img_Action);
				fgrid_MiniSizeTS.Mark_Grid_Menu();
				fgrid_MiniSizeTS.ExtendLastCol = false;
				fgrid_MiniSizeTS.AllowSorting = AllowSortingEnum.None;
				fgrid_MiniSizeTS.AllowDragging = AllowDraggingEnum.None;
				fgrid_MiniSizeTS.Font = new Font("Verdana", 7);
				fgrid_MiniSizeTS.Styles.Alternate.BackColor = Color.White; 
 


				//Set Combo List
				Init_Control(); 

 

   
				if(ClassLib.ComVar.FormClick_Flag == true)
				{ 
					_Factory = ClassLib.ComVar.Parameter_PopUp[0];
					_PlanYMD = ClassLib.ComVar.Parameter_PopUp[1];
					_Line = ClassLib.ComVar.Parameter_PopUp[2];

					if(ClassLib.ComVar.This_FormDate == "") 
					{
						ClassLib.ComVar.This_FormDate = _PlanYMD;
					}

					dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(_PlanYMD); 
					dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(_PlanYMD);  

					cmb_Factory.SelectedValue = _Factory;

				}
				else
				{ 
					cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

					if(ClassLib.ComVar.This_FormDate != "")
					{
						dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(ClassLib.ComVar.This_FormDate);
						dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(ClassLib.ComVar.This_FormDate);
					}
					else
					{
						dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(System.DateTime.Now.ToString("yyyyMMdd") );
						dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(System.DateTime.Now.ToString("yyyyMMdd") );
					} 


				}
				 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

  
		}


		
		/// <summary>
		/// Init_Control : 
		/// </summary>
		private void Init_Control()
		{
  

			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false;


			 
			dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_ToYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			txt_Font.Text = ClassLib.ComVar.StdFontSize;


			rad_Level5.Checked = true;


			DataTable dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);  
 
			 


		} 
		
 



		#endregion
		  
		#region 조회


		
		/// <summary>
		/// Display_LOT_DAILY_MINI_SIZE : 
		/// </summary>
		private void Display_LOT_DAILY_MINI_SIZE()
		{


			string before_item = "", now_item = ""; 
			int gen_row = 0;   
			string sel_gen = "";
			int min_size_col = fgrid_MiniSize.Cols.Count + 1;   //default : col max value
			int size_qty = 0, sum_size_qty = 0;


			

			string factory = cmb_Factory.SelectedValue.ToString();
			//			string fromymd = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
			//			string toymd = MyComFunction.ConvertDate2DbType(dpick_ToYMD.Text);
			string fromymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
			string toymd = dpick_ToYMD.Value.ToString("yyyyMMdd");
			string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_LineCd, " ");
			string lot = " ";

			DataTable dt_ret = Select_SPO_LOT_MINI_SIZE_DAY(factory, fromymd, toymd, line_cd, lot);
 
			fgrid_MiniSize.Rows.Count = fgrid_MiniSize.Rows.Fixed;
			fgrid_MiniSizeTS.Rows.Count = fgrid_MiniSizeTS.Rows.Fixed; 

			txt_LineName.Text = ""; 
			txt_Model.Text = ""; 
			txt_StyleCd.Text = ""; 
			txt_Gen.Text = ""; 
			txt_LOT.Text = ""; 
			txt_DaySeq.Text = ""; 


			if(dt_ret.Rows.Count == 0) 
			{
				btn_Finish.Enabled = false;
				//btn_Cancel.Enabled = false;
				return; 
			}


  
			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
      	 
				now_item = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxREQ_NO - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxMLINE_CD - 1].ToString();
 
				if(before_item != now_item)
				{
  
					fgrid_MiniSize.Rows.Add();
								
					//default data setting
					for(int j = 1; j <= (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN; j++)
					{
						fgrid_MiniSize[fgrid_MiniSize.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j - 1].ToString();
					}
 					 
					//gen
					for(int j = 1; j <= fgrid_MiniSize.Rows.Fixed; j++)
					{
						if(fgrid_MiniSize[j, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_MiniSize[gen_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN].ToString();

							break;
						} 
					}


					before_item = now_item; 

					sum_size_qty = 0;
					

				}
 

				//--------------------------------------------------------------

				for(int j = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxCS_SIZE_START; j < fgrid_MiniSize.Cols.Count; j++)
				{
					if(fgrid_MiniSize[gen_row, j].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxCS_SIZE - 1].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						size_qty = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxSIZE_QTY - 1].ToString()); 
						fgrid_MiniSize[fgrid_MiniSize.Rows.Count - 1, j] = (size_qty.ToString() == "0") ? "" : size_qty.ToString();

						sum_size_qty += size_qty;
						

						break; 
					} 
				}
  


				fgrid_MiniSize[fgrid_MiniSize.Rows.Count - 1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxTOT_QTY] = sum_size_qty.ToString();

 	 



			} // end for 



			//--------------------------------------------------------------
			//LOT에 대한 젠더만 표시
			string[] token = sel_gen.Split('/');

			for(int i = 1; i < fgrid_MiniSize.Rows.Fixed; i++) 
				fgrid_MiniSize.Rows[i].Visible = false;   

			for(int i = 1; i < fgrid_MiniSize.Rows.Fixed; i++) 
			{
				for(int j = 0; j < token.Length; j++)
				{
					if(fgrid_MiniSize[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN].ToString() == token[j])
					{
						fgrid_MiniSize.Rows[i].Visible = true; 
						break;
					} 
				} // end for j 
			} // end for i
  

			//--------------------------------------------------------------
			//Merge 속성 
			fgrid_MiniSize.AllowMerging = AllowMergingEnum.Free; 
			for(int i = fgrid_MiniSize.Rows.Fixed; i < fgrid_MiniSize.Rows.Count; i++) fgrid_MiniSize.Rows[i].AllowMerging = false;  
			fgrid_MiniSize.Cols[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxMODEL_NAME].AllowMerging = true;
			fgrid_MiniSize.Cols[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxSTYLE_CD].AllowMerging = true;


			//--------------------------------------------------------------
			// subtotal 
			fgrid_MiniSize.Subtotal(AggregateEnum.Clear);
			fgrid_MiniSize.SubtotalPosition = SubtotalPositionEnum.BelowData;  
			//			fgrid_MiniSize.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
			//			fgrid_MiniSize.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;   
			fgrid_MiniSize.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
			fgrid_MiniSize.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;   
			fgrid_MiniSize.Styles[CellStyleEnum.Subtotal2].BackColor = ClassLib.ComVar.ClrSubTotal2;
			fgrid_MiniSize.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Black;   


//			fgrid_MiniSize.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxREQ_NO, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxTOT_QTY, "");
//
//			for(int i = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxCS_SIZE_START; i < fgrid_MiniSize.Cols.Count; i++)
//			{
//				fgrid_MiniSize.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxREQ_NO, i, "");
//			}


			fgrid_MiniSize.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxTOT_QTY, "");

			for(int i = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxCS_SIZE_START; i < fgrid_MiniSize.Cols.Count; i++)
			{
				fgrid_MiniSize.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT, i, "");
			}


			 


			//--------------------------------------------------------------
			// finish 전부 된 경우는 btn_finish 비활성화 처리
			int findrow = 0;
			findrow = fgrid_MiniSize.FindRow("N", fgrid_MiniSize.Rows.Fixed, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxTS_FINISH_YN, false, true, false);
				
			//all ts_finish_yn = 'Y'
			if(findrow == -1)
			{
				btn_Finish.Enabled = false;
				//btn_Cancel.Enabled = true;
			}
			else
			{
				btn_Finish.Enabled = true;
				//btn_Cancel.Enabled = false;
			}
			//--------------------------------------------------------------



			//--------------------------------------------------------------
			//기타 속성 
			fgrid_MiniSize.Cols.Frozen = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxCS_SIZE_START;
			fgrid_MiniSize.LeftCol = min_size_col; 




		}



		/// <summary>
		/// Display_LOT_DAILY_MINI_TS_SIZE : 
		/// </summary>
		/// <param name="arg_selrow"></param>
		private void Display_LOT_DAILY_MINI_TS_SIZE(int arg_selrow)
		{

			if(fgrid_MiniSize.Rows.Count <= fgrid_MiniSize.Rows.Fixed) return;


			//------------------------------------------------
			//선택한 젠더행 색깔 표시
			string sel_gen = fgrid_MiniSize[arg_selrow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN].ToString();

			int findrow = fgrid_MiniSize.FindRow(sel_gen, 1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN, false, true, false);

			if(findrow == -1) return;

			fgrid_MiniSize.GetCellRange(findrow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN, findrow, fgrid_MiniSize.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow; 
			fgrid_MiniSize.GetCellRange(findrow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN, findrow, fgrid_MiniSize.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
 
			if(_BeforeGenRow != -1 && _BeforeGenRow != findrow) 
				fgrid_MiniSize.GetCellRange(_BeforeGenRow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN, _BeforeGenRow, fgrid_MiniSize.Cols.Count - 1).StyleNew.Clear(); 

			_BeforeGenRow = findrow;

			//------------------------------------------------
			//선택 데이터 정보 표시
			txt_LineName.Text = fgrid_MiniSize[arg_selrow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLINE_NAME].ToString(); 
			txt_Model.Text = fgrid_MiniSize[arg_selrow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxMODEL_NAME].ToString();
			txt_StyleCd.Text = fgrid_MiniSize[arg_selrow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxSTYLE_CD].ToString();
			txt_Gen.Text = fgrid_MiniSize[arg_selrow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN].ToString();  
			txt_LOT.Text = fgrid_MiniSize[arg_selrow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT].ToString(); 
			txt_DaySeq.Text = fgrid_MiniSize[arg_selrow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxDAY_SEQ].ToString();


			// 사이즈 헤더 할당 
			fgrid_MiniSizeTS.Rows.Fixed = 2;
			ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_MiniSizeTS, 
														cmb_Factory.SelectedValue.ToString(), 
														txt_Gen.Text.Trim(), 
														fgrid_MiniSizeTS.Rows.Fixed,
														(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxGEN,
														(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxCS_SIZE_START);




			// 가장 긴 사이즈 문대만큼 x 표시 : report 용이
			Set_DefaultSize_Head_Add();

			Display_LOT_DAILY_MINI_TS_SIZE(); 
			Display_Qty_Balance();


		}



		/// <summary>
		/// Set_DefaultSize_Head_Add : 가장 긴 사이즈 문대만큼 x 표시 : report 용이
		/// </summary>
		private void Set_DefaultSize_Head_Add()
		{

			int max_gen_count = fgrid_MiniSize.Cols.Count - (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxCS_SIZE_START;
			int now_gen_count = fgrid_MiniSizeTS.Cols.Count - ( (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxCS_SIZE_START); 
			
			if(now_gen_count >= max_gen_count) return;
			
			int before_gen_cont = fgrid_MiniSizeTS.Cols.Count;
			int add_gen_cont = max_gen_count - now_gen_count;

			fgrid_MiniSizeTS.Cols.Count = fgrid_MiniSizeTS.Cols.Count + add_gen_cont;



			for(int i = before_gen_cont; i < fgrid_MiniSizeTS.Cols.Count; i++)
			{
				fgrid_MiniSizeTS.Cols[i].Width = 45;  
				fgrid_MiniSizeTS.Cols[i].AllowSorting = false; 
				
				 
				if(fgrid_MiniSizeTS[2, i] == null) fgrid_MiniSizeTS[2, i] = "x"; 
				 

			} // end for i



		}




		/// <summary>
		/// Display_LOT_DAILY_MINI_TS_SIZE : 
		/// </summary>
		private void Display_LOT_DAILY_MINI_TS_SIZE()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;

				string before_item = "", now_item = ""; 
				int level = 0;
				int min_size_col = fgrid_MiniSizeTS.Cols.Count + 1;   //default : col max value
				int size_qty = 0, sum_size_qty = 0;
				int insert_row = 0;


				string factory = cmb_Factory.SelectedValue.ToString(); 
				string[] token = txt_LOT.Text.Split('-');
				string lot_no = token[0];
				string lot_seq = token[1];
				string op_cd = ClassLib.ComVar.StdOpCd; // UPS
				string day_seq = txt_DaySeq.Text.Trim();

				DataTable dt_ret = Select_SPD_LOT_DAILY_MINI_TS_SIZE(factory, lot_no, lot_seq, op_cd, day_seq);
  

				fgrid_MiniSizeTS.Rows.Count = fgrid_MiniSizeTS.Rows.Fixed;

				if(dt_ret.Rows.Count == 0)
				{
//					btn_Finish.Enabled = false;
//					btn_Cancel.Enabled = false;
					return; 
				}
			

			

				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{

					now_item = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxLOT_NO].ToString()
						+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxLOT_SEQ].ToString()
						+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxREQ_NO].ToString()
						+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxDAY_SEQ].ToString()
						+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxMLINE_CD].ToString()
						+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxINPUT_PRIO].ToString();


					if(before_item != now_item)
					{
				 
						level = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_LEVEL].ToString() );  
						fgrid_MiniSizeTS.Rows.InsertNode(fgrid_MiniSizeTS.Rows.Count, level);

						insert_row = fgrid_MiniSizeTS.Rows.Count - 1;

						for(int j = 0; j <= (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY; j++)
						{
							fgrid_MiniSizeTS[insert_row, j + 1] = dt_ret.Rows[i].ItemArray[j].ToString(); 
						} // end for j
	

 
					
						if(level == _Level_LOT)
						{
							fgrid_MiniSizeTS.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
							fgrid_MiniSizeTS.Rows[insert_row].AllowEditing = false;
 
						}
						else if(level == _Level_Req)
						{
							fgrid_MiniSizeTS.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
							fgrid_MiniSizeTS.Rows[insert_row].AllowEditing = false; 

						}
						else if(level == _Level_Day)
						{

						
						
							fgrid_MiniSizeTS.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd; 
							fgrid_MiniSizeTS.Rows[insert_row].AllowEditing = false;



							// finish_yn, plan_status color
							if(fgrid_MiniSizeTS[insert_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
							{
								fgrid_MiniSizeTS.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrFinishY;
								//fgrid_MiniSizeTS.Rows[insert_row + 1].StyleNew.BackColor = ClassLib.ComVar.ClrFinishY; 
							} 


							if(fgrid_MiniSizeTS[insert_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
							{
								fgrid_MiniSizeTS.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrRelease;
								//fgrid_MiniSizeTS.Rows[insert_row + 1].StyleNew.BackColor = ClassLib.ComVar.ClrRelease; 
							} 

 


						}
						else if(level == _Level_MLine)
						{

						
							//fgrid_MiniSizeTS.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd; 
							fgrid_MiniSizeTS.Rows[insert_row].AllowEditing = false;


						 
							// req_no/ day_seq/ mline 별 balance row
							fgrid_MiniSizeTS.Rows.InsertNode(insert_row + 1, _Level_InputPrio); 
							//fgrid_MiniSizeTS.Rows[insert_row + 1].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
							fgrid_MiniSizeTS.Rows[insert_row + 1].StyleNew.Font = new Font("Verdana", 7, FontStyle.Bold);
						
							fgrid_MiniSizeTS[insert_row + 1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_DESC1 + 1] = "Balance";
						
							fgrid_MiniSizeTS[insert_row + 1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1] 
								= fgrid_MiniSizeTS[insert_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1];

							fgrid_MiniSizeTS.Rows[insert_row + 1].AllowEditing = false;



							// finish_yn, plan_status color
							if(fgrid_MiniSizeTS[insert_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
							{
								fgrid_MiniSizeTS.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrFinishY;
								//fgrid_MiniSizeTS.Rows[insert_row + 1].StyleNew.BackColor = ClassLib.ComVar.ClrFinishY; 
							} 


							if(fgrid_MiniSizeTS[insert_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
							{
								fgrid_MiniSizeTS.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrRelease;
								//fgrid_MiniSizeTS.Rows[insert_row + 1].StyleNew.BackColor = ClassLib.ComVar.ClrRelease; 
							} 


						


						}
						else if(level == _Level_InputPrio)
						{

						
							// finish_yn, plan_status color
							if(fgrid_MiniSizeTS[insert_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
							{
								fgrid_MiniSizeTS.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrReadOnly;
								fgrid_MiniSizeTS.Rows[insert_row].AllowEditing = false;
							}


							if(fgrid_MiniSizeTS[insert_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
							{
								fgrid_MiniSizeTS.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrReadOnly;
								fgrid_MiniSizeTS.Rows[insert_row].AllowEditing = false;
							} 


						} // end if level




					
						before_item = now_item;

						sum_size_qty = 0;


					} // end if



					//-------------------------------------------------------------- 
					for(int j = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxCS_SIZE_START; j < fgrid_MiniSizeTS.Cols.Count; j++)
					{
						if(fgrid_MiniSizeTS[2, j].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxCS_SIZE].ToString())
						{
							min_size_col = (min_size_col > j) ? j : min_size_col;

							if(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSIZE_QTY] == null 
								|| dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSIZE_QTY].ToString().Trim().Equals("") )
							{
								continue;
							} 

							size_qty = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSIZE_QTY].ToString() );

							sum_size_qty += size_qty;

							fgrid_MiniSizeTS[insert_row, j] = (size_qty.ToString() == "0") ? "" : size_qty.ToString();

						
						 

							break; 
						} 
					}


					if(level == _Level_InputPrio)
					{
						fgrid_MiniSizeTS[insert_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1] = (sum_size_qty.ToString() == "0") ? "" : sum_size_qty.ToString();  

						//					// save list
						//					fgrid_MiniSizeTS[insert_row, 0] = "Y";

					}

					//--------------------------------------------------------------




				} // end for i 
			
 

				fgrid_MiniSizeTS.Cols.Frozen = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxCS_SIZE_START;
				fgrid_MiniSizeTS.Tree.Column = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_DESC1 + 1;
			
				rad_Level5.Checked = true;
				fgrid_MiniSizeTS.Tree.Show(_Level_Day); 


			

				#region


				//---------------------------------------------------------------------------------------------------
				// 현재 일자 하위 보여주기
				//---------------------------------------------------------------------------------------------------
//				int now_level = 0;
//				string now_planymd = "";
// 
//				for(int i = fgrid_MiniSizeTS.Rows.Fixed; i < fgrid_MiniSizeTS.Rows.Count; i++)
//				{
//				
//					if(fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_LEVEL + 1] == null) continue;
//				
//					now_level = Convert.ToInt32(fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_LEVEL + 1].ToString() );
//					if(now_level != _Level_Day) continue;
//
//				
//				
//					if(fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1] == null) continue;
//				
//					now_planymd = fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1].ToString(); 
//					if(now_planymd != dpick_FromYMD.Value.ToString("yyyyMMdd") ) continue;
// 
//
//
//					Row r = fgrid_MiniSizeTS.Rows[i];
//					if(!r.IsNode) return;
//					r.Node.Collapsed = !r.Node.Collapsed; 
//
//
//
//
//					//				// create border style
//					//				
//					//				_bdrBrush = new SolidBrush(Color.YellowGreen);
//					//				_bdrOutside = 3;
//					//				_bdrInside = 0;
//					//
//					//				// enable ownerdraw
//					//				fgrid_MiniSizeTS.DrawMode = DrawModeEnum.OwnerDraw; 
//					//				
//					//
//					//
//					//				for(int a = r.Node.Row.Index; a <= r.Node.GetNode(NodeTypeEnum.LastChild).Row.Index; a++)
//					//				{
//					//					//CellStyle s = fgrid_MiniSizeTS.Styles.Add("Border");
//					//
//					//					for(int b = 0; b < fgrid_MiniSizeTS.Cols.Count; b++)
//					//					{
//					//						CellStyle s = fgrid_MiniSizeTS.Styles.Add("Border"); // , fgrid_MiniSizeTS.GetCellRange(a, b).Style 
//					//						CellRange rg = fgrid_MiniSizeTS.GetCellRange(a, b);
//					//						rg.Style = fgrid_MiniSizeTS.Styles["Border"];  
//					//					}
//					//
//					//				}
//					//
//					//				// repaint control to show changes
//					//				fgrid_MiniSizeTS.Invalidate();
//
// 
//
//					for(int a = r.Node.Row.Index; a <= r.Node.GetNode(NodeTypeEnum.LastChild).GetNode(NodeTypeEnum.LastChild).Row.Index; a++)
//					{
//					 
//						for(int b = 1; b < fgrid_MiniSizeTS.Cols.Count; b++)
//						{ 
//							CellRange rg = fgrid_MiniSizeTS.GetCellRange(a, b);
//							rg.StyleNew.BackColor = ClassLib.ComVar.GridAlternate_Color;
//
//
//							// set color : finish, released 
//							if(fgrid_MiniSizeTS[r.Node.Row.Index, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
//							{
//								rg.StyleNew.BackColor = ClassLib.ComVar.ClrFinishY; 
//							} 
//
//
//							if(fgrid_MiniSizeTS[r.Node.Row.Index, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
//							{
//								rg.StyleNew.BackColor = ClassLib.ComVar.ClrRelease; 
//							} 
//
//
//
// 
//						} // end for b
// 
//
//
//
//
//
//
//						// delete 후 insert 이므로, 현재 일자에 대한 데이터들을 저장대상으로 기본 설정 
//						if(fgrid_MiniSizeTS[a, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_LEVEL + 1] == null) continue;
//
//						if(fgrid_MiniSizeTS.Rows[a].Node.Level == _Level_InputPrio)
//						{
//							fgrid_MiniSizeTS[a, 0] = "Y";
//
//
//							// 총 수량이 0 인 데이터는 저장처리 하지 않기 위함
//							if(fgrid_MiniSizeTS[a, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1] == null
//								|| fgrid_MiniSizeTS[a, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1].ToString().Trim().Equals("") 
//								|| Convert.ToInt32(fgrid_MiniSizeTS[a, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1].ToString() ) == 0)
//							{
//								fgrid_MiniSizeTS[a, 0] = "";
//							}
//
//						}
//
//						
//
//					} // end for a
//
//
//
//
//				}
//				//---------------------------------------------------------------------------------------------------
 

				#endregion


				//---------------------------------------------------------------------------------------------------
				// 현재 일자 하위 보여주기
				//---------------------------------------------------------------------------------------------------
				Display_Now_PlanDay();



				fgrid_MiniSizeTS.LeftCol = min_size_col;


			}
			catch 
			{
				 
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		} 


		private void Display_Now_PlanDay()
		{


			//---------------------------------------------------------------------------------------------------
			// 현재 일자 하위 보여주기
			//---------------------------------------------------------------------------------------------------
			int now_level = 0;
			string now_planymd = "";
 
			for(int i = fgrid_MiniSizeTS.Rows.Fixed; i < fgrid_MiniSizeTS.Rows.Count; i++)
			{
				
				if(fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_LEVEL + 1] == null) continue;
				
				now_level = Convert.ToInt32(fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_LEVEL + 1].ToString() );
				if(now_level != _Level_Day) continue;

				
				
				if(fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1] == null) continue;
				
				now_planymd = fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1].ToString(); 
				if(now_planymd != dpick_FromYMD.Value.ToString("yyyyMMdd") ) continue;
 


				Row r = fgrid_MiniSizeTS.Rows[i];
				if(!r.IsNode) return;
				r.Node.Collapsed = !r.Node.Collapsed; 




				//				// create border style
				//				
				//				_bdrBrush = new SolidBrush(Color.YellowGreen);
				//				_bdrOutside = 3;
				//				_bdrInside = 0;
				//
				//				// enable ownerdraw
				//				fgrid_MiniSizeTS.DrawMode = DrawModeEnum.OwnerDraw; 
				//				
				//
				//
				//				for(int a = r.Node.Row.Index; a <= r.Node.GetNode(NodeTypeEnum.LastChild).Row.Index; a++)
				//				{
				//					//CellStyle s = fgrid_MiniSizeTS.Styles.Add("Border");
				//
				//					for(int b = 0; b < fgrid_MiniSizeTS.Cols.Count; b++)
				//					{
				//						CellStyle s = fgrid_MiniSizeTS.Styles.Add("Border"); // , fgrid_MiniSizeTS.GetCellRange(a, b).Style 
				//						CellRange rg = fgrid_MiniSizeTS.GetCellRange(a, b);
				//						rg.Style = fgrid_MiniSizeTS.Styles["Border"];  
				//					}
				//
				//				}
				//
				//				// repaint control to show changes
				//				fgrid_MiniSizeTS.Invalidate();

 

				for(int a = r.Node.Row.Index; a <= r.Node.GetNode(NodeTypeEnum.LastChild).GetNode(NodeTypeEnum.LastChild).Row.Index; a++)
				{
					 
					for(int b = 1; b < fgrid_MiniSizeTS.Cols.Count; b++)
					{ 
						CellRange rg = fgrid_MiniSizeTS.GetCellRange(a, b);
						rg.StyleNew.BackColor = ClassLib.ComVar.GridAlternate_Color;


						// set color : finish, released 
						if(fgrid_MiniSizeTS[r.Node.Row.Index, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
						{
							rg.StyleNew.BackColor = ClassLib.ComVar.ClrFinishY; 
						} 


						if(fgrid_MiniSizeTS[r.Node.Row.Index, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
						{
							rg.StyleNew.BackColor = ClassLib.ComVar.ClrRelease; 
						} 



 
					} // end for b
 






					// delete 후 insert 이므로, 현재 일자에 대한 데이터들을 저장대상으로 기본 설정 
					if(fgrid_MiniSizeTS[a, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_LEVEL + 1] == null) continue;

					if(fgrid_MiniSizeTS.Rows[a].Node.Level == _Level_InputPrio)
					{
						fgrid_MiniSizeTS[a, 0] = "Y";


						// 총 수량이 0 인 데이터는 저장처리 하지 않기 위함
						if(fgrid_MiniSizeTS[a, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1] == null
							|| fgrid_MiniSizeTS[a, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1].ToString().Trim().Equals("") 
							|| Convert.ToInt32(fgrid_MiniSizeTS[a, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1].ToString() ) == 0)
						{
							fgrid_MiniSizeTS[a, 0] = "";
						}

					}

						

				} // end for a




			}
			//---------------------------------------------------------------------------------------------------



		}

		

		/// <summary>
		/// Display_Qty_Balance : 
		/// </summary>
		private void Display_Qty_Balance()
		{

			C1.Win.C1FlexGrid.Node node;
			int start_row = 0;
			int end_row = 0;

			int sum_balance = 0;
			int sum_qty = 0;


			_Count_UnBalance_Qty = 0;

			// 컬럼 balance
			for(int i = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxCS_SIZE_START; i < fgrid_MiniSizeTS.Cols.Count; i++)
			{
 

				for(int j = fgrid_MiniSizeTS.Rows.Fixed; j < fgrid_MiniSizeTS.Rows.Count; j++)
				{
				
					node = fgrid_MiniSizeTS.Rows[j].Node;

					if(node.Level != _Level_MLine) continue;


					start_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
					 
					for(int a = start_row + 1; a <= end_row; a++)
					{
						if(fgrid_MiniSizeTS[a, i] == null || fgrid_MiniSizeTS[a, i].ToString().Trim().Equals("") ) continue;

						sum_balance += Convert.ToInt32( fgrid_MiniSizeTS[a, i].ToString() );
					}

					sum_qty = Convert.ToInt32( (fgrid_MiniSizeTS[j, i] == null || fgrid_MiniSizeTS[j, i].ToString().Trim() == "") ? "0" :  fgrid_MiniSizeTS[j, i].ToString() );
 
					fgrid_MiniSizeTS[start_row, i] = Convert.ToSingle(sum_qty - sum_balance); 


					// balance 불일치 표시
					if(fgrid_MiniSizeTS[start_row, i] == null || fgrid_MiniSizeTS[start_row, i].ToString().Trim().Equals("") )
					{
						fgrid_MiniSizeTS[start_row, i] = "0";
					}

					if(fgrid_MiniSizeTS[start_row - 1, i] == null || fgrid_MiniSizeTS[start_row - 1, i].ToString().Trim().Equals("") )
					{
						fgrid_MiniSizeTS[start_row - 1, i] = "0";
					}


					

					//if(Convert.ToInt32(fgrid_MiniSizeTS[start_row, i].ToString() ) != Convert.ToInt32(fgrid_MiniSizeTS[start_row - 1, i].ToString() ) )
					if(Convert.ToInt32(fgrid_MiniSizeTS[start_row, i].ToString() ) != 0)
					{


						CellRange cr = fgrid_MiniSizeTS.GetCellRange(start_row, i);  
						cr.StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;


 
						//						CellStyle s = fgrid_MiniSizeTS.Styles.Add("Warning"); // , fgrid_MiniSizeTS.GetCellRange(start_row, i).Style 
						//						s.ForeColor = ClassLib.ComVar.ClrWarning;
						//						s.Font = new Font("Verdana", 7, FontStyle.Bold);
						//
						//						CellRange cr = fgrid_MiniSizeTS.GetCellRange(start_row, i); 
						//						cr.Style = fgrid_MiniSizeTS.Styles["Warning"];  
						 
						
						//---------------------------------------------------------
						// 현재 입력 대상 일자에서만 balance 안맞는 수량 체크
						//---------------------------------------------------------
						
						//_Count_UnBalance_Qty++;



						if(fgrid_MiniSizeTS[start_row - 1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1] != null)
						{
							string plan_ymd = fgrid_MiniSizeTS[start_row - 1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1].ToString();

							if(plan_ymd == dpick_FromYMD.Value.ToString("yyyyMMdd"))
							{
								_Count_UnBalance_Qty++;
							}

						}
						//---------------------------------------------------------



					}
					else
					{
						
						CellRange cr = fgrid_MiniSizeTS.GetCellRange(start_row, i);  
						cr.StyleNew.ForeColor = Color.Black;


						//						CellStyle s = fgrid_MiniSizeTS.Styles.Add("Normal"); //, fgrid_MiniSizeTS.GetCellRange(start_row, i).Style 
						//						s.ForeColor = Color.Black;
						//						s.Font = new Font("Verdana", 7);
						//
						//						CellRange cr = fgrid_MiniSizeTS.GetCellRange(start_row, i); 
						//						cr.Style = fgrid_MiniSizeTS.Styles["Normal"];  


					}


					// balance 초기화
					sum_balance = 0;
					sum_qty = 0;

				
				} // end for j



			} // end for i



			// 행 balance  
			for(int i = fgrid_MiniSizeTS.Rows.Fixed; i < fgrid_MiniSizeTS.Rows.Count; i++)
			{
				
 
				node = fgrid_MiniSizeTS.Rows[i].Node;

				if(node.Level != _Level_InputPrio) continue;

				for(int j = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxCS_SIZE_START; j < fgrid_MiniSizeTS.Cols.Count; j++)
				{

					if(fgrid_MiniSizeTS[i, j] == null || fgrid_MiniSizeTS[i, j].ToString().Trim().Equals("") ) continue;

					sum_balance += Convert.ToInt32( fgrid_MiniSizeTS[i, j].ToString() );

				} // end for j


				fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1] = sum_balance.ToString();


				// balance 불일치 표시
				if(fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1] == null 
					|| fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1].ToString().Trim().Equals("") )
				{
					fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1] = "0";
				}

				if(fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1] == null 
					|| fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1].ToString().Trim().Equals("") )
				{
					fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1] = "0";
				}


				if(Convert.ToInt32(fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1].ToString() ) 
					!= Convert.ToInt32(fgrid_MiniSizeTS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1].ToString() ) )
				{

					
					CellRange cr = fgrid_MiniSizeTS.GetCellRange(i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1); 
					cr.StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;  


					//					CellStyle s = fgrid_MiniSizeTS.Styles.Add("Warning"); //, fgrid_MiniSizeTS.GetCellRange(i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1).Style 
					//					s.ForeColor = ClassLib.ComVar.ClrWarning;
					//					s.Font = new Font("Verdana", 7, FontStyle.Bold);
					//
					//					CellRange cr = fgrid_MiniSizeTS.GetCellRange(i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1); 
					//					cr.Style = fgrid_MiniSizeTS.Styles["Warning"];  


				}
				else
				{


					CellRange cr = fgrid_MiniSizeTS.GetCellRange(i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1); 
					cr.StyleNew.ForeColor = Color.Black;


 
					//					CellStyle s = fgrid_MiniSizeTS.Styles.Add("Normal"); // , fgrid_MiniSizeTS.GetCellRange(i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1).Style 
					//					s.ForeColor = Color.Black;
					//					s.Font = new Font("Verdana", 7);
					//
					//					CellRange cr = fgrid_MiniSizeTS.GetCellRange(i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1); 
					//					cr.Style = fgrid_MiniSizeTS.Styles["Normal"];  


				}



				// balance 초기화
				sum_balance = 0;
				sum_qty = 0;

				

				
			} // end for i



		}




		#endregion

		#region 툴바 이벤트 메서드


		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{
		
			txt_LineName.Text = "";
			txt_LOT.Text = ""; 
			txt_Model.Text = "";
			txt_StyleCd.Text = "";
			txt_Gen.Text = "";  
			txt_DaySeq.Text = "";
			fgrid_MiniSizeTS.Rows.Count = fgrid_MiniSizeTS.Rows.Fixed;

		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{
 
			Display_LOT_DAILY_MINI_SIZE(); 
			Display_LOT_DAILY_MINI_TS_SIZE(fgrid_MiniSize.Rows.Fixed);  

		}


		/// <summary>
		/// Event_Tbtn_Save : 
		/// </summary>
		private void Event_Tbtn_Save()
		{
 
			//행 수정 상태 해제
			fgrid_MiniSizeTS.Select(fgrid_MiniSizeTS.Selection.r1, 0, fgrid_MiniSizeTS.Selection.r1, fgrid_MiniSizeTS.Cols.Count-1, false);
 
		
			// 수정, 조회때마다 Balance 계산하여 정합성 맞지 않는 카운터 관리하므로 수량 정합성 체크 생략
			if(_Count_UnBalance_Qty != 0)
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
				ClassLib.ComFunction.User_Message("Exist quantity unbalance size.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}



			bool save_flag = Update_SPD_LOT_DAILY_MINI_TS_SIZE();

			if(! save_flag) 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this); 

				Display_LOT_DAILY_MINI_TS_SIZE(); 
				Display_Qty_Balance();

			}
				
			 


		}



		/// <summary>
		/// Event_Tbtn_Print : 
		/// </summary>
		private void Event_Tbtn_Print()
		{
 
			this.Cursor = Cursors.WaitCursor;

			

 

			if(fgrid_MiniSizeTS.Rows.Count < fgrid_MiniSizeTS.Rows.Fixed) return;

 
			string filename = Application.StartupPath + @"\Report\Production\" + this.Name + ".txt";
			string sDir = ClassLib.ComFunction.Set_RD_Directory(this.Name); 

			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null; 
			 

			fgrid_MiniSizeTS.ClipSeparators = "@ ";
			fgrid_MiniSizeTS.SaveGrid( filename, FileFormatEnum.TextCustom);
 
			string title = "Size to Time Sequence.";

			string para = "/rfn [" + filename + "] /rv V_LINE[" + txt_LineName.Text + "]V_MODEL[" + txt_Model.Text + "]V_STYLE[" + txt_StyleCd.Text + "] V_GENDER[" 
				+ txt_Gen.Text + "] V_LOT[" + txt_LOT.Text + "] V_ASYDATE[" + dpick_FromYMD.Value.ToString("yyyy-MM-dd") + " (" + txt_DaySeq.Text +")]";
			
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report(title, sDir, para);


			report.ShowDialog(); 
		

		    this.Cursor = Cursors.Default;
			 


		}


		#endregion

		#region 그리드 이벤트 메서드


		
		private void Event_Click_fgrid_MiniSize()
		{

			if(fgrid_MiniSize.Rows.Count <= fgrid_MiniSize.Rows.Fixed) 
			{
				fgrid_MiniSizeTS.Rows.Count = fgrid_MiniSizeTS.Rows.Fixed;
				return;
			}

			
			//subtotal row
			if(fgrid_MiniSize[fgrid_MiniSize.Selection.r1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT] == null) 
			{
				fgrid_MiniSizeTS.Rows.Count = fgrid_MiniSizeTS.Rows.Fixed;
				return;
			}
 
			Display_LOT_DAILY_MINI_TS_SIZE(fgrid_MiniSize.Selection.r1); 

		}



		private void Event_Click_fgrid_MiniSizeTS()
		{
 

		}
		

		/// <summary>
		/// Event_AfterEdit_fgrid_MiniSizeTS : 
		/// </summary>
		/// <param name="e"></param>
		private void Event_AfterEdit_fgrid_MiniSizeTS(C1.Win.C1FlexGrid.RowColEventArgs e)
		{


			bool digit_flag = false;


			// input prio 추가 후 수정된 데이터 desc1 에 반영
			if(e.Col == (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxINPUT_PRIO + 1)
			{

				digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_MiniSizeTS[e.Row, e.Col].ToString());

				if(digit_flag == false) 
				{
					fgrid_MiniSizeTS[e.Row, e.Col] = Convert.ToString(Convert.ToInt32(fgrid_MiniSizeTS[e.Row - 1, e.Col].ToString() ) + 1 ); 
				}


				fgrid_MiniSizeTS[e.Row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_DESC1 + 1] = fgrid_MiniSizeTS[e.Row, e.Col].ToString();



			}
			else if(e.Col >= (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxCS_SIZE_START + 1)
			{
			
				digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_MiniSizeTS[e.Row, e.Col].ToString());

				if(digit_flag == false) 
				{
					fgrid_MiniSizeTS[e.Row, e.Col] = _BeforeQty;
					return;
				}
			 

				//168 족 넘으면 에러 처리
				if(! fgrid_MiniSizeTS[e.Row, e.Col].ToString().Trim().Equals("") 
					&& Convert.ToInt32(fgrid_MiniSizeTS[e.Row, e.Col].ToString() ) > _MaxHourlyQty)
				{
				
					fgrid_MiniSizeTS[e.Row, e.Col] = "";
					//fgrid_MiniSizeTS.GetCellRange(e.Row, e.Col).StyleNew.BackColor = ClassLib.ComVar.ClrWarning_Back;
				
					string message = "Over Quantity. : " + _MaxHourlyQty.ToString(); // + "\n\r\n\r" + "Add New Hourly";
					ClassLib.ComFunction.User_Message(message, "Input Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return; 
				}



				Display_Qty_Balance();

				fgrid_MiniSizeTS[e.Row, 0] = "Y";

			}


		}


		#region Border 표시


//		private void Event_OwnerDrawCell_fgrid_MiniSizeTS(C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
//		{
//
//			// we only want cells with style set to "Border" 
//			CellStyle s = fgrid_MiniSizeTS.GetCellStyle(e.Row, e.Col);
//			if (s == null || s.Name != "Border")
//				return;
//
//			// draw cell content as usual
//			e.DrawCell();
//
//			// get custom border widths for this cell
//			// (depends on neighbor cells)
//			Rectangle rc;
//			Graphics g = e.Graphics;
//			Margins m = GetBorderMargins(e.Row, e.Col);
//
//			// draw custom borders
//			if (m.Top > 0)
//			{
//				rc = e.Bounds;
//				rc.Height = m.Top;
//				g.FillRectangle(_bdrBrush, rc);
//			}
//			if (m.Left > 0)
//			{
//				rc = e.Bounds;
//				rc.Width = m.Left;
//				g.FillRectangle(_bdrBrush, rc);
//			}
//			if (m.Bottom > 0)
//			{
//				rc = e.Bounds;
//				rc.Y = rc.Bottom - m.Bottom;
//				rc.Height = m.Bottom;
//				g.FillRectangle(_bdrBrush, rc);
//			}
//			if (m.Right > 0)
//			{
//				rc = e.Bounds;
//				rc.X = rc.Right - m.Right;
//				rc.Width = m.Right;
//				g.FillRectangle(_bdrBrush, rc);
//			}
// 
//
//		}
//
//
//		// calculate border widths taking neighbor cells into account
//		Margins _m = new Margins(0,0,0,0);
//		private Margins GetBorderMargins(int row, int col)
//		{
//			// initialize return value
//			_m.Left = _m.Right = _m.Top = _m.Bottom = 0;
//
//			// check whether this cell has a border
//			CellRange rg = fgrid_MiniSizeTS.GetCellRange(row, col);
//			if (rg.Style == null || rg.Style.Name != "Border")
//				return _m;
//
//			// check whether this cell is at the top of the range
//			_m.Top = _bdrOutside;
//			if (row > fgrid_MiniSizeTS.Rows.Fixed)
//			{
//				rg.r1 = rg.r2 = row-1;
//				if (rg.Style != null && rg.Style.Name == "Border")
//					_m.Top = 0;
//				rg.r1 = rg.r2 = row;
//			}
//
//			// check whether this cell is at the left of the range
//			_m.Left = _bdrOutside;
//			if (col > fgrid_MiniSizeTS.Cols.Fixed)
//			{
//				rg.c1 = rg.c2 = col-1;
//				if (rg.Style != null && rg.Style.Name == "Border")
//					_m.Left = 0;
//				rg.c1 = rg.c2 = col;
//			}
//
//			// check whether this cell is at the bottom of the range
//			_m.Bottom = _bdrOutside;
//			if (row < fgrid_MiniSizeTS.Rows.Count-1)
//			{
//				rg.r1 = rg.r2 = row+1;
//				if (rg.Style != null && rg.Style.Name == "Border")
//					_m.Bottom = _bdrInside;
//				rg.r1 = rg.r2 = row;
//			}
//
//			// check whether this cell is at the right of the range
//			_m.Right = _bdrOutside;
//			if (col < fgrid_MiniSizeTS.Cols.Count-1)
//			{
//				rg.c1 = rg.c2 = col+1;
//				if (rg.Style != null && rg.Style.Name == "Border")
//					_m.Right = _bdrInside;
//				rg.c1 = rg.c2 = col;
//			}
//
//			// done
//			return _m;
//		}



		#endregion



		#endregion

		#region 버튼 및 기타 이벤트 메서드


		/// <summary>
		/// Event_Click_btn_AssignTS : 
		/// </summary>
		private void Event_Click_btn_AssignTS()
		{

			if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1) return; 
			if(fgrid_MiniSize.Rows.Count <= fgrid_MiniSize.Rows.Fixed) return;
			
			if(fgrid_MiniSize[fgrid_MiniSize.Selection.r1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT] == null
				|| fgrid_MiniSize[fgrid_MiniSize.Selection.r1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT].ToString().Equals("") ) return;

			if(fgrid_MiniSize[fgrid_MiniSize.Selection.r1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxTS_FINISH_YN].ToString().Trim() == "Y") return;



			DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this); 
			if(result == DialogResult.No) return;



			string factory = cmb_Factory.SelectedValue.ToString();
			string[] token = fgrid_MiniSize[fgrid_MiniSize.Selection.r1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT].ToString().Split('-');
			string lot_no = token[0];
			string lot_seq = token[1];
			string day_seq = fgrid_MiniSize[fgrid_MiniSize.Selection.r1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxDAY_SEQ].ToString();
			string op_cd = ClassLib.ComVar.StdOpCd; 
			string max_hourly_qty = "30";


			bool run_flag = Reset_SPD_LOT_DAILY_MINI_SIZE_TS(factory, lot_no, lot_seq, day_seq, op_cd, max_hourly_qty);

			if(! run_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);

				// refresh
				Display_LOT_DAILY_MINI_TS_SIZE(fgrid_MiniSize.Selection.r1);
				
			}




		}


		/// <summary>
		/// Event_Click_btn_Check : 
		/// </summary>
		private void Event_Click_btn_Check()
		{

			if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1) return;


			string factory = cmb_Factory.SelectedValue.ToString();
			string line_cd = cmb_LineCd.SelectedValue.ToString();
			string from_date = dpick_FromYMD.Value.ToString("yyyyMMdd");
			string op_cd = ClassLib.ComVar.StdOpCd;


			Form_PD_MiniSize_TS_Check pop_form = new Form_PD_MiniSize_TS_Check(factory, line_cd, from_date, op_cd);  
			pop_form.ShowDialog();


		}


		/// <summary>
		/// Event_Click_btn_Finish : 
		/// </summary>
		private void Event_Click_btn_Finish()
		{

			//해당 제조일자의 LOT이 모두 TS가 할당되어 있는지 체크
			bool all_input_flag = Check_Finish_LOT_Count();

			if(! all_input_flag)
			{
				return;
			}
			else
			{


				//spo_lot_daily_size 와 사이즈 수량 일치 체크 -> spo_lot_daily_mini_size, spd_lot_daily_mini_size_ts
				bool finish_flag = Check_Finish_Qty();

				if(! finish_flag)
				{
					//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsNotHaveData, this); 
					return;
				}
				else
				{

                    //System.Threading.Thread thread_run = new System.Threading.Thread(new System.Threading.ThreadStart(Event_Click_btn_Finish_Run));
                    //thread_run.Start();

                    //_PopForm = new FlexAPS.ProdBase.Pop_ProcessWait();
                    //_PopForm.Processing();
                    //_PopForm.Start(); 
 

                    //// thread 종료 후 재 조회
                    //thread_run.Abort(); 

                    Event_Click_btn_Finish_Run();


					if(_Thread_Run_Flag)
					{
				
						Display_LOT_DAILY_MINI_SIZE();
						Display_LOT_DAILY_MINI_TS_SIZE(fgrid_MiniSize.Selection.r1);

					}



					if(ClassLib.ComVar.FormDailyTS != null) ClassLib.ComVar.FormDailyTS.Close();
					if(ClassLib.ComVar.FormDailyMini != null) ClassLib.ComVar.FormDailyMini.Close();
					if(ClassLib.ComVar.FormDailySize != null) ClassLib.ComVar.FormDailySize.Close();

				

				} // if(! finish_flag)

			} // end if(! all_input_flag)


		} 



		/// <summary>
		/// Event_Click_btn_Finish_Run : thread 내부 실행 메서드
		/// </summary>
		private void Event_Click_btn_Finish_Run()
		{

			try
			{

				string factory = cmb_Factory.SelectedValue.ToString();
				string plan_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
				string line_cd = cmb_LineCd.SelectedValue.ToString();
				string finishyn = "Y";

				bool save_flag = Save_Finish(factory, plan_ymd, line_cd, finishyn);
				
				if(! save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					btn_Finish.Enabled = true; 
				
					_Thread_Run_Flag = false;
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this); 
					btn_Finish.Enabled = false; 

					_Thread_Run_Flag = true; 

				}
 
				


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Finish", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
			finally 
			{ 
				//_PopForm.Close(); 
				this.Cursor = Cursors.Default;   
			} 


		}


		/// <summary>
		/// Event_Click_btn_Cancel : 
		/// </summary>
		private void Event_Click_btn_Cancel()
		{

			string before_lot = "", now_lot = "";
			string[] token = null;
			string factory = "", lotno = "", lotseq = "", dayseq = ""; 
			
			  
			for(int i = fgrid_MiniSize.Rows.Fixed; i < fgrid_MiniSize.Rows.Count; i++)
			{
				if(fgrid_MiniSize[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT] == null) continue;

				now_lot = fgrid_MiniSize[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT].ToString();

				if(before_lot != now_lot)
				{
					factory = cmb_Factory.SelectedValue.ToString();
					token = fgrid_MiniSize[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT].ToString().Split('-');
					lotno = token[0];
					lotseq = token[1];
					dayseq = fgrid_MiniSize[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxDAY_SEQ].ToString();  
					
					bool save_flag = Select_Check_Cancel(factory, lotno, lotseq, dayseq);
		
					if(! save_flag)
					{  
						ClassLib.ComFunction.User_Message("Already Released", "Finish Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

					before_lot = now_lot;
				}

			}


			DialogResult message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this);
			if(message_result == DialogResult.No) return; 


            //System.Threading.Thread thread_run = new System.Threading.Thread(new System.Threading.ThreadStart(Event_Click_btn_Cancel_Run));
            //thread_run.Start();

            //_PopForm = new FlexAPS.ProdBase.Pop_ProcessWait();
            //_PopForm.Processing();
            //_PopForm.Start(); 
 

            //// thread 종료 후 재 조회
            //thread_run.Abort(); 

            Event_Click_btn_Cancel_Run();


			if(_Thread_Run_Flag)
			{
				
				Display_LOT_DAILY_MINI_SIZE();
				Display_LOT_DAILY_MINI_TS_SIZE(fgrid_MiniSize.Selection.r1);

			}
 		


			if(ClassLib.ComVar.FormDailyTS != null) ClassLib.ComVar.FormDailyTS.Close();
			if(ClassLib.ComVar.FormDailyMini != null) ClassLib.ComVar.FormDailyMini.Close();
			if(ClassLib.ComVar.FormDailySize != null) ClassLib.ComVar.FormDailySize.Close();

			


		}


		/// <summary>
		/// Event_Click_btn_Cancel_Run : thread 내부 실행 메서드
		/// </summary>
		private void Event_Click_btn_Cancel_Run()
		{

			try
			{

				string factory = cmb_Factory.SelectedValue.ToString();
				string plan_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
				string line_cd = cmb_LineCd.SelectedValue.ToString();
				string finishyn = "N";


				bool save_flag = Save_Finish(factory, plan_ymd, line_cd, finishyn);
			
				if(! save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					
					_Thread_Run_Flag = false;

				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
					btn_Finish.Enabled = true;
					
					_Thread_Run_Flag = true;

				} 
 
				


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
			finally 
			{ 
				//_PopForm.Close(); 
				this.Cursor = Cursors.Default;   
			} 


		}



		
		#region Finish, Finish Cancel


		/// <summary>
		/// Check_Finish_Qty : spo_lot_daily_size 와 사이즈 수량 일치 체크 -> spo_lot_daily_mini_size, spd_lot_daily_mini_size_ts
		/// </summary>
		/// <returns></returns>
		private bool Check_Finish_Qty()
		{
			

			try
			{

				string before_lot = "", now_lot = "";
				string[] token = null;
				string factory = "", lotno = "", lotseq = "", dayseq = "";
				string stylecd = "", item = "";
				int count = 0;
				bool check_flag = false;


				for(int i = fgrid_MiniSize.Rows.Fixed; i < fgrid_MiniSize.Rows.Count; i++)
				{
					if(fgrid_MiniSize[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT] == null) continue;

					now_lot = fgrid_MiniSize[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT].ToString();

					if(before_lot != now_lot)
					{
						factory = cmb_Factory.SelectedValue.ToString();
						token = fgrid_MiniSize[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxLOT].ToString().Split('-');
						lotno = token[0];
						lotseq = token[1];
						dayseq = fgrid_MiniSize[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxDAY_SEQ].ToString();
						stylecd = fgrid_MiniSize[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxSTYLE_CD].ToString();

						check_flag = Select_Check_Finish_Qty(factory, lotno, lotseq, dayseq);
			
						if(! check_flag)
						{
							//item = stylecd + " (" + dayseq + ")"; 	
							
							item = "Style : " + stylecd + "\r\n";
							item += "LOT : " + now_lot; 

							string message = "Mismatch Data." + "\r\n\r\n" + item;

							ClassLib.ComFunction.User_Message(message, "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
							count++;
							break;
						}

						before_lot = now_lot;
					}
				}

				if(count > 0)
					return false;
				else
					return true;

			}
			catch
			{
				return false;
			}
		}



		/// <summary>
		/// Check_Finish_LOT_Count : 
		/// </summary>
		/// <returns></returns>
		private bool Check_Finish_LOT_Count()
		{

			try
			{
 
				string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
				string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_LineCd, " ");
				
				string line_name = "";
				
				if(cmb_LineCd.SelectedIndex == -1)
				{
					line_name = "";
				}
				else
				{
					line_name = cmb_LineCd.Columns[1].Text;
				}

				string plan_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
 
				bool check_flag = Select_Check_Finish_LOT_Count(factory, line_cd, plan_ymd);
			
				if(! check_flag)
				{
					 
					string message = "Do not input all data in line : " + line_name + " (" + line_cd + ")" + ",  Asy. date : " + dpick_FromYMD.Value.ToString("yyyy-MM-dd");

					ClassLib.ComFunction.User_Message(message, "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);  
					return false;
				}
				else
				{
					return true;
				}

			}
			catch
			{
				return false;
			}


		}




		#endregion


		#endregion

		#region 컨텍스트 메뉴 이벤트 메서드


		/// <summary>
		/// Event_Click_menuItem_Clear : 
		/// </summary>
		private void Event_Click_menuItem_Clear()
		{
 
			
			int[] sel_row = fgrid_MiniSizeTS.Selections;

			for(int i = 0; i < sel_row.Length; i++)
			{
				
				//finisn_yn = 'Y' 이면 제외
				if(fgrid_MiniSizeTS[sel_row[i], (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTS_FINISH_YN + 1] == null) continue;
				if(fgrid_MiniSizeTS[sel_row[i], (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() != "N") continue;


				if(fgrid_MiniSizeTS.Rows[sel_row[i]].Node.Level != _Level_InputPrio) continue;


				for(int j = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxCS_SIZE_START; j < fgrid_MiniSizeTS.Cols.Count; j++)
				{
					fgrid_MiniSizeTS[sel_row[i], j] = ""; 

				} // end for j

				fgrid_MiniSizeTS[sel_row[i], 0] = "Y"; 

			} // end for i



			Display_Qty_Balance();


		}



		/// <summary>
		/// Event_Click_menuItem_AddRow : 
		/// </summary>
		private void Event_Click_menuItem_AddRow()
		{


			int sel_row = fgrid_MiniSizeTS.Selection.r1;

			if(fgrid_MiniSizeTS[sel_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_LEVEL + 1] == null) return;

 
			// finish_yn = 'N' 일때 가능
			if(fgrid_MiniSizeTS[sel_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTS_FINISH_YN + 1] != null
				&& fgrid_MiniSizeTS[sel_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTS_FINISH_YN + 1].ToString().Trim() == "Y") 
			{
				ClassLib.ComFunction.User_Message("Already finished or released.", "Add Hourly", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}



			// 현재 일자만 저장대상이 되므로 가능  
			if(fgrid_MiniSizeTS[sel_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1] == null) return;
				

			string now_planymd = fgrid_MiniSizeTS[sel_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1].ToString(); 
			if(now_planymd != dpick_FromYMD.Value.ToString("yyyyMMdd") ) 
			{
				ClassLib.ComFunction.User_Message("Only add hourly on day.", "Add Hourly", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}


			// 미니라인 선택에서 가능
			if(fgrid_MiniSizeTS.Rows[sel_row].Node.Level != _Level_MLine) 
			{
				ClassLib.ComFunction.User_Message("Select miniline.", "Add Hourly", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}


			  


			int last_child_row = fgrid_MiniSizeTS.Rows[sel_row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;
			int next_hourly = Convert.ToInt32(fgrid_MiniSizeTS[last_child_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxINPUT_PRIO + 1].ToString()) + 1;

			fgrid_MiniSizeTS.Rows.InsertNode(last_child_row + 1, _Level_InputPrio);

			fgrid_MiniSizeTS[last_child_row + 1, 0] = "";

			
			for(int i = 0; i <= (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxGEN + 1; i++)
			{
				if(i == (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTREE_DESC1 + 1) 
				{
					fgrid_MiniSizeTS[last_child_row + 1, i] = next_hourly.ToString();  
				}
				else if(i == (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxINPUT_PRIO + 1) 
				{
					fgrid_MiniSizeTS[last_child_row + 1, i] = next_hourly.ToString();  
				}
				else if(i == (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxTOT_QTY + 1
					|| i == (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxSUM_QTY + 1) 
				{
					fgrid_MiniSizeTS[last_child_row + 1, i] = ""; 
				}
				else
				{
					fgrid_MiniSizeTS[last_child_row + 1, i] = fgrid_MiniSizeTS[last_child_row, i];
				} 
 
			} // end for i



			fgrid_MiniSizeTS.Rows[last_child_row + 1].StyleNew.BackColor = ClassLib.ComVar.GridAlternate_Color;




		}

 

		#endregion
 

		#endregion   
		
		#region 이벤트 처리

		#region 툴바 이벤트


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				Event_Tbtn_New();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Search(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Save(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		} 

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Print(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}

		
		 




		#endregion

		#region 그리드 이벤트


		private void fgrid_MiniSize_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_fgrid_MiniSize(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_fgrid_MiniSize", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		}

		private void fgrid_MiniSizeTS_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_fgrid_MiniSizeTS(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_fgrid_MiniSizeTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		}
		 


		private void fgrid_MiniSizeTS_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				if(fgrid_MiniSizeTS[e.Row, e.Col] == null)  fgrid_MiniSizeTS[e.Row, e.Col] = ""; 
				_BeforeQty = (fgrid_MiniSizeTS[e.Row, e.Col].ToString() == "") ? "0": fgrid_MiniSizeTS[e.Row, e.Col].ToString();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_MiniSize_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}

		private void fgrid_MiniSizeTS_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				Event_AfterEdit_fgrid_MiniSizeTS(e);
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_AfterEdit_fgrid_MiniSizeTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}

		private void fgrid_MiniSizeTS_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
		{
		
			try
			{
//				Event_OwnerDrawCell_fgrid_MiniSizeTS(e);
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_OwnerDrawCell_fgrid_MiniSizeTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}


		 
 


		#endregion

		#region 버튼 및 기타 이벤트


		#region 버튼 이미지 이벤트

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



		private void Form_PD_LOTDaily_MiniSize_TS_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
 


		private void Form_PD_LOTDaily_MiniSize_TS_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ClassLib.ComVar.FormDailyTS= null;
		}
 


		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				if(cmb_Factory.SelectedIndex == -1) return;


				// 초기화
				fgrid_MiniSize.Rows.Count = 2; 
				fgrid_MiniSizeTS.Rows.Count = fgrid_MiniSizeTS.Rows.Fixed; 

				txt_LineName.Text = ""; 
				txt_Model.Text = ""; 
				txt_StyleCd.Text = ""; 
				txt_Gen.Text = ""; 
				txt_LOT.Text = ""; 
				txt_DaySeq.Text = "";  


				// 라인 정보 할당 
				string factory = cmb_Factory.SelectedValue.ToString();
				DataTable dt_ret = FlexAPS.ProdBase.Form_PB_Line.Select_SPB_LINE_ROLE(factory);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineCd, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
				dt_ret.Dispose();


				// 사이즈 헤더 할당
				ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_MiniSize, 
															factory, 
															"", 
															fgrid_MiniSize.Rows.Fixed,
															(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxGEN,
															(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC.IxCS_SIZE_START);

				


				if(ClassLib.ComVar.FormClick_Flag)  
				{
					cmb_LineCd.SelectedValue = _Line; 
				}
				else 
				{
					cmb_LineCd.SelectedIndex = 0;  
				}





			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		

		private void dpick_ValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				DateTimePicker src = sender as DateTimePicker;

				src.CustomFormat = ClassLib.ComVar.This_SetedDateType;
  
				if(src.Equals(dpick_FromYMD))
				{
					dpick_ToYMD.Text = dpick_FromYMD.Text;  
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		
		private void dpick_CloseUp(object sender, System.EventArgs e)
		{
			try
			{

				DateTimePicker src = sender as DateTimePicker; 
  
				fgrid_MiniSize.Rows.Count = fgrid_MiniSize.Rows.Fixed;
				fgrid_MiniSizeTS.Rows.Count = fgrid_MiniSizeTS.Rows.Fixed;


//				if(src.Equals(dpick_ToYMD))
//				{

					if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1) return; 

					Display_LOT_DAILY_MINI_SIZE(); 
					Display_LOT_DAILY_MINI_TS_SIZE(fgrid_MiniSize.Rows.Fixed); 
//				}
 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_FromYMD_CloseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		} 


		private void cmb_LineCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{

				if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1) return; 

				Display_LOT_DAILY_MINI_SIZE(); 
				Display_LOT_DAILY_MINI_TS_SIZE(fgrid_MiniSize.Rows.Fixed);   

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_LineCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void txt_Font_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
		
			try
			{
				//13 : enter
				if(e.KeyChar == (char)13) 
				{
					ClassLib.ComFunction.Set_Grid_Font_Size(fgrid_MiniSize, Convert.ToSingle(txt_Font.Text));
					ClassLib.ComFunction.Set_Grid_Font_Size(fgrid_MiniSizeTS, Convert.ToSingle(txt_Font.Text));
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Font_KeyPress", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void txt_Font_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			try
			{
				ClassLib.ComFunction.Set_NumberTextBox(txt_Font, 3);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Font_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
			
			try
			{
				
				RadioButton src = sender as RadioButton; 
				fgrid_MiniSizeTS.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) );

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void btn_AssignTS_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_btn_AssignTS(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_AssignTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}
		

		private void btn_Check_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_btn_Check(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void btn_Finish_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Click_btn_Finish();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Finish", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default; 
			}
		
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Click_btn_Cancel();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default; 
			}
		
		}
 


		#endregion

		#region 컨텍스트 메뉴 이벤트


		private void menuItem_Clear_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_menuItem_Clear(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_Clear", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void menuItem_AddRow_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_menuItem_AddRow(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_AddRow", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		 

		#endregion


		#endregion
		 
		#region 디비 연결


		#region 조회

		 
		/// <summary>
		/// Select_SPO_LOT_SIZE_DAY : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_fromymd"></param>
		/// <param name="arg_toymd"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_lot"></param>
		/// <returns></returns>
		private DataTable Select_SPO_LOT_MINI_SIZE_DAY(string arg_factory, string arg_fromymd, string arg_toymd, string arg_line_cd, string arg_lot)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPO_LOT_MINI_SIZE_DAY";

				MyOraDB.ReDim_Parameter(6); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_FROMYMD";
				MyOraDB.Parameter_Name[2] = "ARG_TOYMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[4] = "ARG_LOT";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_fromymd;  
				MyOraDB.Parameter_Values[2] = arg_toymd; 
				MyOraDB.Parameter_Values[3] = arg_line_cd; 
				MyOraDB.Parameter_Values[4] = arg_lot;
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
				
			}
			catch
			{
				return null;
			}

		}




		/// <summary>
		/// Select_SPD_LOT_DAILY_MINI_TS_SIZE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		/// <param name="arg_opcd"></param>
		/// <param name="arg_dayseq"></param>
		/// <returns></returns>
		private DataTable Select_SPD_LOT_DAILY_MINI_TS_SIZE(string arg_factory, string arg_lotno, string arg_lotseq, string arg_opcd, string arg_dayseq)
		{

			try
			{

				DataSet ds_ret;
				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPD_DAILY_MINI_TS_SIZE";

				MyOraDB.ReDim_Parameter(6); 
 
				//01.PROCEDURE명
				MyOraDB.Process_Name = process_name;
 
				//02.ARGURMENT명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_OP_CD";
				MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";
 
				//03.DATA TYPE
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			 
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = arg_factory;  
				MyOraDB.Parameter_Values[1] = arg_lotno;
				MyOraDB.Parameter_Values[2] = arg_lotseq; 
				MyOraDB.Parameter_Values[3] = arg_opcd; 
				MyOraDB.Parameter_Values[4] = arg_dayseq; 
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 

			}
			catch
			{
				return null;
			}

		}



 

		#endregion    

		#region Finish, Finish Cancel



		/// <summary>
		/// Select_Check_Finish_LOT_Count : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_plan_ymd"></param>
		/// <returns></returns>
		private bool Select_Check_Finish_LOT_Count(string arg_factory, string arg_line_cd, string arg_plan_ymd)
		{

			DataSet ds_ret; 

			try
			{
				string process_name = "PKG_SPD_DAILY_BSC.CHECK_FINISH_LOT_COUNT";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_PLAN_YMD"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_line_cd; 
				MyOraDB.Parameter_Values[2] = arg_plan_ymd;  
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true);  
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return false; 

				//수량 모두 일치
				if(ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString() == "0") 
				{
					return true; 
				}
				else 
				{
					return false;  
				}
				 
			}
			catch
			{
				return false;
			} 


		}


		/// <summary>
		/// Select_Check_Finish_Qty : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		/// <param name="arg_dayseq"></param>
		/// <returns></returns>
		private bool Select_Check_Finish_Qty(string arg_factory, string arg_lotno, string arg_lotseq, string arg_dayseq)
		{
			DataSet ds_ret; 

			try
			{
				string process_name = "PKG_SPD_DAILY_BSC.CHECK_FINISH_QTY";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_DAY_SEQ"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lotno;
				MyOraDB.Parameter_Values[2] = arg_lotseq;
				MyOraDB.Parameter_Values[3] = arg_dayseq;  
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true);  
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return false; 

				//수량 모두 일치
				if(ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString() == "0") 
				{
					return true; 
				}
				else 
				{
					return false;  
				}
				 
			}
			catch
			{
				return false;
			} 
		}



		

		/// <summary>
		/// Save_Finish : Finish 실행
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_plan_ymd"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_finishyn"></param>
		/// <returns></returns>
		private bool Save_Finish(string arg_factory, string arg_plan_ymd, string arg_line_cd, string arg_finishyn)
		{ 

			try
			{ 
					
				int col_ct = 5;   
  
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.UPDATE_FINISH";
  

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_PLAN_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_TS_FINISH_YN";
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER"; 

				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  
				}
 
  
				MyOraDB.Parameter_Values[0] = arg_factory;  
				MyOraDB.Parameter_Values[1] = arg_plan_ymd; 
				MyOraDB.Parameter_Values[2] = arg_line_cd;
				MyOraDB.Parameter_Values[3] = arg_finishyn; 
				MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;


				MyOraDB.Add_Modify_Parameter(true);
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true; 
				}

			}
			catch
			{ 
				return false;
			}


		}
		 



		/// <summary>
		/// Select_Check_Cancel : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		/// <param name="arg_dayseq"></param>
		/// <returns></returns>
		private bool Select_Check_Cancel(string arg_factory, string arg_lotno, string arg_lotseq, string arg_dayseq)
		{
			DataSet ds_ret; 

			try
			{
				string process_name = "PKG_SPD_DAILY_BSC.CHECK_FINISH_CANCEL";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_DAY_SEQ"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lotno;
				MyOraDB.Parameter_Values[2] = arg_lotseq;
				MyOraDB.Parameter_Values[3] = arg_dayseq;  
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true);  
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return false; 

				//cancel ok - plan_status == "L"
				if(ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString() == "L") 
					return true; 
				else 
					return false;  
				 
			}
			catch
			{
				return false;
			} 
		}



		#endregion

		#region 저장


		/// <summary>
		/// Update_SPD_LOT_DAILY_MINI_TS_SIZE : 
		/// </summary>
		/// <returns></returns>
		public bool Update_SPD_LOT_DAILY_MINI_TS_SIZE()
		{

			try
			{ 

				
				int col_ct = 14;  						 
				int row, col;
				


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.UPDATE_SPD_DAILY_MINI_TS_SIZE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_REQ_NO"; 
				MyOraDB.Parameter_Name[6] = "ARG_OP_CD";
				MyOraDB.Parameter_Name[7] = "ARG_MLINE_CD";
				MyOraDB.Parameter_Name[8] = "ARG_INPUT_PRIO";
				MyOraDB.Parameter_Name[9] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[10] = "ARG_INPUT_QTY"; 
				MyOraDB.Parameter_Name[11] = "ARG_PLAN_YMD";
				MyOraDB.Parameter_Name[12] = "ARG_LINE_CD"; 
				MyOraDB.Parameter_Name[13] = "ARG_UPD_USER"; 

 


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 



				string factory = cmb_Factory.SelectedValue.ToString();
				string[] token = txt_LOT.Text.Split('-');
				string lot_no = token[0];
				string lot_seq = token[1]; 
				string op_cd = ClassLib.ComVar.StdOpCd;
				string plan_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
				string line_cd = cmb_LineCd.SelectedValue.ToString();
				
				C1.Win.C1FlexGrid.Node node;
				string now_planymd = ""; 
				string day_seq = "";
				string req_no = "";
				string mline_cd = ""; 
				string input_prio = "";
  


				int start_row = 0;
				int end_row = 0; 



				for(row = fgrid_MiniSizeTS.Rows.Fixed; row <= fgrid_MiniSizeTS.Rows.Count - 1; row++)
				{

					node = fgrid_MiniSizeTS.Rows[row].Node;

					if(node.Level != _Level_Day) continue;


					// 현재 일자 check
					if(fgrid_MiniSizeTS[row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1] == null) continue;
				
					now_planymd = fgrid_MiniSizeTS[row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1].ToString(); 
					if(now_planymd != plan_ymd ) continue;




					start_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					end_row = node.GetNode(NodeTypeEnum.LastChild).GetNode(NodeTypeEnum.LastChild).Row.Index; // req 별, miniline별 이므로 child의 child 계산
					 



					day_seq = fgrid_MiniSizeTS[start_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxDAY_SEQ + 1].ToString();
					req_no = fgrid_MiniSizeTS[start_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxREQ_NO + 1].ToString();

 

					vList.Add("D"); 
					vList.Add(factory); 
					vList.Add(lot_no); 
					vList.Add(lot_seq);  
					vList.Add(day_seq);
					vList.Add(req_no); 
					vList.Add(op_cd); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add("");  
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(ClassLib.ComVar.This_User); 


					for(int a = start_row + 1; a <= end_row; a++)
					{
						
						
						if(fgrid_MiniSizeTS[a, 0] == null || fgrid_MiniSizeTS[a, 0].ToString() != "Y") continue; 
 
						
						mline_cd = fgrid_MiniSizeTS[a, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxMLINE_CD + 1].ToString(); 
						input_prio = fgrid_MiniSizeTS[a, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxINPUT_PRIO + 1].ToString(); 

						for(col = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxCS_SIZE_START; col < fgrid_MiniSizeTS.Cols.Count; col++)
						{  
							if(fgrid_MiniSizeTS[a, col] == null || fgrid_MiniSizeTS[a, col].ToString() == "" || fgrid_MiniSizeTS[a, col].ToString() == "0") continue;
						 

							vList.Add("I"); 
							vList.Add(factory); 
							vList.Add(lot_no); 
							vList.Add(lot_seq);  
							vList.Add(day_seq); 
							vList.Add(req_no);
							vList.Add(op_cd); 
							vList.Add(mline_cd); 
							vList.Add(input_prio); 
							vList.Add(fgrid_MiniSizeTS[2, col].ToString() );  //cs_size
							vList.Add(fgrid_MiniSizeTS[a, col].ToString() );  //input_qty 
							vList.Add(plan_ymd); 
							vList.Add(line_cd); 
							vList.Add(ClassLib.ComVar.This_User);  


						} // end for col 


					} // end for a
 
					 
//					// passcard 
// 
//					vList.Add("P"); 
//					vList.Add(factory); 
//					vList.Add(lot_no); 
//					vList.Add(lot_seq);  
//					vList.Add(day_seq);
//					vList.Add(req_no); 
//					vList.Add(op_cd); 
//					vList.Add(""); 
//					vList.Add("");  
//					vList.Add(""); 
//					vList.Add(plan_ymd); 
//					vList.Add(line_cd); 
//					vList.Add(ClassLib.ComVar.This_User);  



				} // end for row

 


				for(row = fgrid_MiniSizeTS.Rows.Fixed; row <= fgrid_MiniSizeTS.Rows.Count - 1; row++)
				{

					node = fgrid_MiniSizeTS.Rows[row].Node;

					if(node.Level != _Level_Day) continue;


					// 현재 일자 check
					if(fgrid_MiniSizeTS[row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1] == null) continue;
				
					now_planymd = fgrid_MiniSizeTS[row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxFINISH_DATE + 1].ToString(); 
					if(now_planymd != plan_ymd ) continue;




					start_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					end_row = node.GetNode(NodeTypeEnum.LastChild).GetNode(NodeTypeEnum.LastChild).Row.Index; // req 별, miniline별 이므로 child의 child 계산
					 



					day_seq = fgrid_MiniSizeTS[start_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxDAY_SEQ + 1].ToString();
					req_no = fgrid_MiniSizeTS[start_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC.IxREQ_NO + 1].ToString();

 

					vList.Add("P"); 
					vList.Add(factory); 
					vList.Add(lot_no); 
					vList.Add(lot_seq);  
					vList.Add(day_seq);
					vList.Add(req_no); 
					vList.Add(op_cd); 
					vList.Add(" "); 
					vList.Add(" "); 
					vList.Add(" ");  
					vList.Add(" "); 
					vList.Add(" "); 
					vList.Add(" "); 
					vList.Add(ClassLib.ComVar.This_User); 

  

				} // end for row




  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행

				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}

			}
			catch(Exception ex)
			{ 
				MessageBox.Show(ex.ToString() );
				return false;
			} 
 


		}



		#endregion  

		#region 자동전개


		/// <summary>
		/// Reset_SPD_LOT_DAILY_MINI_SIZE_TS : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param> 
		/// <param name="arg_day_seq"></param>
		/// <param name="arg_op_cd"></param> 
		/// <param name="arg_max_hourly_qty"></param>
		/// <returns></returns>
		private bool Reset_SPD_LOT_DAILY_MINI_SIZE_TS(string arg_factory, 
			string arg_lot_no, 
			string arg_lot_seq,  
			string arg_day_seq, 
			string arg_op_cd,  
			string arg_max_hourly_qty)
		{
			
			try
			{

				DataSet ds_ret; 
				int col_ct = 7;

				MyOraDB.ReDim_Parameter(col_ct);  
 
				MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.RESET_SPD_MINI_SIZE_TS"; 
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";  
				MyOraDB.Parameter_Name[3] = "ARG_DAY_SEQ";  
				MyOraDB.Parameter_Name[4] = "ARG_OP_CD";    
				MyOraDB.Parameter_Name[5] = "ARG_MAX_HOURLY_QTY";  
				MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";  
  
				for (int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}	 
				
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lot_no;
				MyOraDB.Parameter_Values[2] = arg_lot_seq;  
				MyOraDB.Parameter_Values[3] = arg_day_seq; 
				MyOraDB.Parameter_Values[4] = arg_op_cd;  
				MyOraDB.Parameter_Values[5] = arg_max_hourly_qty; 
				MyOraDB.Parameter_Values[6] = ClassLib.ComVar.This_User; 
  

				MyOraDB.Add_Modify_Parameter(true);  
				ds_ret = MyOraDB.Exe_Modify_Procedure();		
			 
				if(ds_ret == null)  
					return false; 
				else
					return true;

			}
			catch
			{
				return false;
			}

		}



		#endregion

		#endregion

		
 


	}
}

