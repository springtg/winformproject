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

namespace FlexAPS.ProdPlan
{
	public class Form_PO_LOTDailyMini : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.ContextMenu cmenu_Grid;
		private System.Windows.Forms.MenuItem menuItem_Clear;
		private System.Windows.Forms.MenuItem menuItem3;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_Tail;
		public System.Windows.Forms.Panel pnl_TailSearch;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.GroupBox groupBox1;
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
		private COM.FSP fgrid_LOT;
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
		private System.Windows.Forms.TextBox txt_DaySeq;
		private System.Windows.Forms.Label lbl_DaySeq;
		private System.Windows.Forms.RadioButton rad_Level4;
		private System.Windows.Forms.Label btn_AssignTS;
		public COM.FSP fgrid_MiniSize;
		private System.Windows.Forms.CheckBox chk_CheckCapa;
		private System.Windows.Forms.MenuItem menuItem_SelMLine;

		#endregion

		#region 생성자, 소멸자

		public Form_PO_LOTDailyMini()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_LOTDailyMini));
			this.cmenu_Grid = new System.Windows.Forms.ContextMenu();
			this.menuItem_Clear = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem_SelMLine = new System.Windows.Forms.MenuItem();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_Tail = new System.Windows.Forms.Panel();
			this.fgrid_MiniSize = new COM.FSP();
			this.pnl_TailSearch = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.btn_AssignTS = new System.Windows.Forms.Label();
			this.txt_DaySeq = new System.Windows.Forms.TextBox();
			this.lbl_DaySeq = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			this.fgrid_LOT = new COM.FSP();
			this.pnl_HeadSearch = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
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
			this.chk_CheckCapa = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_Tail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MiniSize)).BeginInit();
			this.pnl_TailSearch.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.pnl_Head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LOT)).BeginInit();
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
																					   this.menuItem3,
																					   this.menuItem_SelMLine});
			// 
			// menuItem_Clear
			// 
			this.menuItem_Clear.Index = 0;
			this.menuItem_Clear.Text = "Clear";
			this.menuItem_Clear.Click += new System.EventHandler(this.menuItem_Clear_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "-";
			// 
			// menuItem_SelMLine
			// 
			this.menuItem_SelMLine.Index = 2;
			this.menuItem_SelMLine.Text = "Select MiniLine";
			this.menuItem_SelMLine.Click += new System.EventHandler(this.menuItem_SelMLine_Click);
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
			this.c1Sizer1.TabIndex = 29;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_Tail
			// 
			this.pnl_Tail.Controls.Add(this.fgrid_MiniSize);
			this.pnl_Tail.Controls.Add(this.pnl_TailSearch);
			this.pnl_Tail.Location = new System.Drawing.Point(4, 212);
			this.pnl_Tail.Name = "pnl_Tail";
			this.pnl_Tail.Size = new System.Drawing.Size(1008, 360);
			this.pnl_Tail.TabIndex = 1;
			// 
			// fgrid_MiniSize
			// 
			this.fgrid_MiniSize.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_MiniSize.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_MiniSize.ContextMenu = this.cmenu_Grid;
			this.fgrid_MiniSize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_MiniSize.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_MiniSize.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_MiniSize.Location = new System.Drawing.Point(0, 43);
			this.fgrid_MiniSize.Name = "fgrid_MiniSize";
			this.fgrid_MiniSize.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_MiniSize.Size = new System.Drawing.Size(1008, 317);
			this.fgrid_MiniSize.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_MiniSize.TabIndex = 44;
			this.fgrid_MiniSize.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MiniSize_BeforeEdit);
			this.fgrid_MiniSize.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.fgrid_MiniSize_OwnerDrawCell);
			this.fgrid_MiniSize.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MiniSize_AfterEdit);
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
			this.pnl_SearchImage.Controls.Add(this.btn_AssignTS);
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
			// btn_AssignTS
			// 
			this.btn_AssignTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AssignTS.ImageIndex = 0;
			this.btn_AssignTS.ImageList = this.img_Button;
			this.btn_AssignTS.Location = new System.Drawing.Point(920, 8);
			this.btn_AssignTS.Name = "btn_AssignTS";
			this.btn_AssignTS.Size = new System.Drawing.Size(80, 23);
			this.btn_AssignTS.TabIndex = 200;
			this.btn_AssignTS.Text = "Assign TS";
			this.btn_AssignTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_AssignTS.Click += new System.EventHandler(this.btn_AssignTS_Click);
			this.btn_AssignTS.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_AssignTS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_AssignTS.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_AssignTS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
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
			this.groupBox1.Controls.Add(this.rad_Level4);
			this.groupBox1.Controls.Add(this.rad_Level3);
			this.groupBox1.Controls.Add(this.rad_Level2);
			this.groupBox1.Controls.Add(this.rad_Level1);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8F);
			this.groupBox1.Location = new System.Drawing.Point(682, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(233, 32);
			this.groupBox1.TabIndex = 45;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "View Option";
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
			this.pnl_Head.Controls.Add(this.fgrid_LOT);
			this.pnl_Head.Controls.Add(this.pnl_HeadSearch);
			this.pnl_Head.Location = new System.Drawing.Point(4, 4);
			this.pnl_Head.Name = "pnl_Head";
			this.pnl_Head.Size = new System.Drawing.Size(1008, 204);
			this.pnl_Head.TabIndex = 0;
			// 
			// fgrid_LOT
			// 
			this.fgrid_LOT.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_LOT.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_LOT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_LOT.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_LOT.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_LOT.Location = new System.Drawing.Point(0, 65);
			this.fgrid_LOT.Name = "fgrid_LOT";
			this.fgrid_LOT.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_LOT.Size = new System.Drawing.Size(1008, 139);
			this.fgrid_LOT.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_LOT.TabIndex = 43;
			this.fgrid_LOT.Click += new System.EventHandler(this.fgrid_LOT_Click);
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
			this.panel1.Controls.Add(this.chk_CheckCapa);
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
			// chk_CheckCapa
			// 
			this.chk_CheckCapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chk_CheckCapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_CheckCapa.Location = new System.Drawing.Point(680, 34);
			this.chk_CheckCapa.Name = "chk_CheckCapa";
			this.chk_CheckCapa.Size = new System.Drawing.Size(232, 21);
			this.chk_CheckCapa.TabIndex = 197;
			this.chk_CheckCapa.Text = "Check miniline standard capacity";
			// 
			// Form_PO_LOTDailyMini
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_PO_LOTDailyMini";
			this.Text = "Assign to MiniLine";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PO_LOTDailyMini_Closing);
			this.Load += new System.EventHandler(this.Form_PO_LOTDailyMini_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_Tail.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MiniSize)).EndInit();
			this.pnl_TailSearch.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.pnl_Head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LOT)).EndInit();
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
		private string _Factory = "";
		private string _PlanYMD = "";
		private string _Line;


		//선택되어졌던 젠더 행
		private int _BeforeGenRow = -1;

		//수정하기 전 수량
		private string _BeforeQty;


		//표시 레벨 정보
		private int _Level_LOT = 0;
		private int _Level_Req = 1;
		private int _Level_Day = 2;
		private int _Level_MLine = 3; 



		
		//Balance 맞지 않는 수량 카운트 : 저장 시 정합성 체크 여부로 참조
		private int _Count_UnBalance_Qty = 0;





		

//		// border info
//		private SolidBrush  _bdrBrush;
//		private int         _bdrOutside;
//		private int         _bdrInside;







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
				this.Text = "Assign to MiniLine";
				lbl_MainTitle.Text = "Assign to MiniLine";
    


				fgrid_LOT.Set_Grid("SPO_LOT_DAILY_MINI_H", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_LOT.AllowMerging = AllowMergingEnum.Free; 
				for(int i = 1; i < fgrid_LOT.Cols.Count; i++) fgrid_LOT.Cols[i].AllowMerging = false; 
				fgrid_LOT.ExtendLastCol = false; 
				fgrid_LOT.Font = new Font("Verdana", 7);
				fgrid_LOT.Styles.Alternate.BackColor = Color.White;
				fgrid_LOT.AllowSorting = AllowSortingEnum.None;
				fgrid_LOT.AllowDragging = AllowDraggingEnum.None;


				fgrid_MiniSize.Set_Grid("SPO_LOT_DAILY_MINI_SIZE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_MiniSize.Set_Action_Image(img_Action); 
				fgrid_MiniSize.ExtendLastCol = false; 
				fgrid_MiniSize.Font = new Font("Verdana", 7);
				fgrid_MiniSize.Styles.Alternate.BackColor = Color.White;
				fgrid_MiniSize.AllowSorting = AllowSortingEnum.None;
				fgrid_MiniSize.AllowDragging = AllowDraggingEnum.None;


				

				//Set Combo List
				Init_Control(); 



				if(ClassLib.ComVar.FormClick_Flag == true)
				{ 
					_Factory = ClassLib.ComVar.Parameter_PopUp[0];
					_PlanYMD = ClassLib.ComVar.Parameter_PopUp[1];
					_Line = ClassLib.ComVar.Parameter_PopUp[2];

					if(ClassLib.ComVar.This_FormDate == "") 
					{
						ClassLib.ComVar.This_FormDate = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
						ClassLib.ComVar.This_ToDate = MyComFunction.ConvertDate2DbType(dpick_ToYMD.Text);
					}

				 
					dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(_PlanYMD); 
					dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(_PlanYMD);  
				 
					cmb_Factory.SelectedValue = _Factory;

				}
				else
				{ 
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

				
					cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory; 

				} // end if


				 


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


			rad_Level4.Checked = true; 
			chk_CheckCapa.Checked = true;


			DataTable dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);  
 
			




		} 
		
 


		#endregion 

		#region 조회

 

		/// <summary>
		/// Display_LOT_DAILY_SIZE : 
		/// </summary>
		private void Display_LOT_DAILY_SIZE()
		{


			string before_item = "", now_item = ""; 
			int gen_row = 0;   
			string sel_gen = "";
			int min_size_col = fgrid_LOT.Cols.Count + 1;   //default : col max value
			int size_qty = 0, sum_size_qty = 0;


			

			string factory = cmb_Factory.SelectedValue.ToString();
//			string fromymd = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
//			string toymd = MyComFunction.ConvertDate2DbType(dpick_ToYMD.Text);
			string fromymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
			string toymd = dpick_ToYMD.Value.ToString("yyyyMMdd");
			string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_LineCd, " ");
			string lot = " ";

			DataTable dt_ret = Select_SPO_LOT_SIZE_DAY(factory, fromymd, toymd, line_cd, lot);
 
			fgrid_LOT.Rows.Count = fgrid_LOT.Rows.Fixed;
			fgrid_MiniSize.Rows.Count = fgrid_MiniSize.Rows.Fixed; 

			txt_LineName.Text = ""; 
			txt_Model.Text = ""; 
			txt_StyleCd.Text = ""; 
			txt_Gen.Text = ""; 
			txt_LOT.Text = ""; 
			txt_DaySeq.Text = ""; 


			if(dt_ret.Rows.Count == 0) return;


  
			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
      	 
				now_item = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxLOT - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxREQ_NO - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxOBS_NU - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxOBS_SEQ_NU - 1].ToString();
 
				if(before_item != now_item)
				{
  
					fgrid_LOT.Rows.Add();
								
					//default data setting
					for(int j = 1; j <= (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN; j++)
					{
						fgrid_LOT[fgrid_LOT.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j - 1].ToString();
					}
 					 
					//gen
					for(int j = 1; j <= fgrid_LOT.Rows.Fixed; j++)
					{
						if(fgrid_LOT[j, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_LOT[gen_row, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN].ToString();

							break;
						} 
					}


					before_item = now_item; 

					sum_size_qty = 0;
					

				}
 

				//--------------------------------------------------------------

				for(int j = (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxCS_SIZE_START; j < fgrid_LOT.Cols.Count; j++)
				{
					if(fgrid_LOT[gen_row, j].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxCS_SIZE - 1].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						size_qty = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxSIZE_QTY - 1].ToString()); 
						fgrid_LOT[fgrid_LOT.Rows.Count - 1, j] = (size_qty.ToString() == "0") ? "" : size_qty.ToString();

						sum_size_qty += size_qty;
						

						break; 
					} 
				}
  


				fgrid_LOT[fgrid_LOT.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxTOT_QTY] = sum_size_qty.ToString();

//				// 수량 합계 0 인 request 숨김
//				if(Convert.ToInt32(fgrid_LOT[fgrid_LOT.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxTOT_QTY].ToString()) == 0)
//				{
//					fgrid_LOT.Rows[fgrid_LOT.Rows.Count - 1].Visible = false;
//				}

				
				
					 



			} // end for 



			//--------------------------------------------------------------
			//LOT에 대한 젠더만 표시
			string[] token = sel_gen.Split('/');

			for(int i = 1; i < fgrid_LOT.Rows.Fixed; i++) 
				fgrid_LOT.Rows[i].Visible = false;   

			for(int i = 1; i < fgrid_LOT.Rows.Fixed; i++) 
			{
				for(int j = 0; j < token.Length; j++)
				{
					if(fgrid_LOT[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN].ToString() == token[j])
					{
						fgrid_LOT.Rows[i].Visible = true; 
						break;
					} 
				} // end for j 
			} // end for i
  

			//--------------------------------------------------------------
			//Merge 속성 
			fgrid_LOT.AllowMerging = AllowMergingEnum.Free; 
			for(int i = fgrid_LOT.Rows.Fixed; i < fgrid_LOT.Rows.Count; i++) fgrid_LOT.Rows[i].AllowMerging = false;  
			fgrid_LOT.Cols[(int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxMODEL_NAME].AllowMerging = true;
			fgrid_LOT.Cols[(int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxSTYLE_CD].AllowMerging = true;


			//--------------------------------------------------------------
			// subtotal 
			fgrid_LOT.Subtotal(AggregateEnum.Clear);
			fgrid_LOT.SubtotalPosition = SubtotalPositionEnum.BelowData;  
//			fgrid_LOT.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
//			fgrid_LOT.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;   
			fgrid_LOT.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
			fgrid_LOT.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;   

			fgrid_LOT.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxLOT, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxTOT_QTY, "");

			for(int i = (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxCS_SIZE_START; i < fgrid_LOT.Cols.Count; i++)
			{
				fgrid_LOT.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxLOT, i, "");
			}



			//--------------------------------------------------------------
			//기타 속성 
			fgrid_LOT.Cols.Frozen = (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxCS_SIZE_START;
			fgrid_LOT.LeftCol = min_size_col; 




		}

		

		/// <summary>
		/// Display_LOT_DAILY_MINI_SIZE : 
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_LOT_DAILY_MINI_SIZE(int arg_selrow)
		{

			if(fgrid_LOT.Rows.Count <= fgrid_LOT.Rows.Fixed) return;


			//------------------------------------------------
			//선택한 젠더행 색깔 표시
			string sel_gen = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN].ToString();

			int findrow = fgrid_LOT.FindRow(sel_gen, 1, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN, false, true, false);

			if(findrow == -1) return;

			fgrid_LOT.GetCellRange(findrow, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN, findrow, fgrid_LOT.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow; 
			fgrid_LOT.GetCellRange(findrow, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN, findrow, fgrid_LOT.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
 
			if(_BeforeGenRow != -1 && _BeforeGenRow != findrow) 
				fgrid_LOT.GetCellRange(_BeforeGenRow, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN, _BeforeGenRow, fgrid_LOT.Cols.Count - 1).StyleNew.Clear(); 

			_BeforeGenRow = findrow;

			//------------------------------------------------
			//선택 데이터 정보 표시
			txt_LineName.Text = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxLINE_NAME].ToString(); 
			txt_Model.Text = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxMODEL_NAME].ToString();
			txt_StyleCd.Text = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxSTYLE_CD].ToString();
			txt_Gen.Text = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN].ToString();  
			txt_LOT.Text = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxLOT].ToString(); 
			txt_DaySeq.Text = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxDAY_SEQ].ToString();


			// 사이즈 헤더 할당 
			fgrid_MiniSize.Rows.Fixed = 2;
			ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_MiniSize, 
														cmb_Factory.SelectedValue.ToString(), 
														txt_Gen.Text.Trim(), 
														fgrid_MiniSize.Rows.Fixed,
														(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxGEN,
														(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxCS_SIZE_START);




			Display_LOT_DAILY_MINI_SIZE(); 
			Display_Qty_Balance();


		}


		/// <summary>
		/// Display_LOT_DAILY_MINI_SIZE : 
		/// </summary>
		private void Display_LOT_DAILY_MINI_SIZE()
		{

			string before_item = "", now_item = ""; 
			int level = 0;
			int min_size_col = fgrid_MiniSize.Cols.Count + 1;   //default : col max value
			int sum_size_qty = 0;
			int insert_row = 0;


			string factory = cmb_Factory.SelectedValue.ToString(); 
			string[] token = txt_LOT.Text.Split('-');
			string lot_no = token[0];
			string lot_seq = token[1];
			string op_cd = ClassLib.ComVar.StdOpCd; // UPS
			string day_seq = txt_DaySeq.Text.Trim();

			DataTable dt_ret = Select_SPO_LOT_DAILY_MINI_SIZE(factory, lot_no, lot_seq, op_cd, day_seq);
  

			fgrid_MiniSize.Rows.Count = fgrid_MiniSize.Rows.Fixed;

			if(dt_ret.Rows.Count == 0) return;  
			

			

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{

				now_item = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxLOT_NO].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxLOT_SEQ].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxREQ_NO].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxDAY_SEQ].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxMLINE_CD].ToString();


				if(before_item != now_item)
				{
				 
					level = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTREE_LEVEL].ToString() );  
					fgrid_MiniSize.Rows.InsertNode(fgrid_MiniSize.Rows.Count, level);

					insert_row = fgrid_MiniSize.Rows.Count - 1;

					for(int j = 0; j <= (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY; j++)
					{
						fgrid_MiniSize[insert_row, j + 1] = dt_ret.Rows[i].ItemArray[j].ToString(); 
					} // end for j
	

 
					
					if(level == _Level_LOT)
					{
						fgrid_MiniSize.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						fgrid_MiniSize.Rows[insert_row].AllowEditing = false;
 
					}
					else if(level == _Level_Req)
					{
						fgrid_MiniSize.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
						fgrid_MiniSize.Rows[insert_row].AllowEditing = false; 

					}
					else if(level == _Level_Day)
					{

						
						
						fgrid_MiniSize.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd; 
						fgrid_MiniSize.Rows[insert_row].AllowEditing = false;


						// req_no/ day_seq 별 balance row
						fgrid_MiniSize.Rows.InsertNode(insert_row + 1, _Level_MLine); 
						fgrid_MiniSize.Rows[insert_row + 1].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
						fgrid_MiniSize.Rows[insert_row + 1].StyleNew.Font = new Font("Verdana", 7, FontStyle.Bold);
						
						fgrid_MiniSize[insert_row + 1, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTREE_DESC1 + 1] = "Balance";
						
						fgrid_MiniSize[insert_row + 1, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTOT_QTY + 1] 
							= fgrid_MiniSize[insert_row, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTOT_QTY + 1];

						fgrid_MiniSize.Rows[insert_row + 1].AllowEditing = false;




						// finish_yn, plan_status color
						if(fgrid_MiniSize[insert_row, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
						{
							fgrid_MiniSize.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrFinishY;
							//fgrid_MiniSize.Rows[insert_row + 1].StyleNew.BackColor = ClassLib.ComVar.ClrFinishY; 
						} 


						if(fgrid_MiniSize[insert_row, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
						{
							fgrid_MiniSize.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrRelease;
							//fgrid_MiniSize.Rows[insert_row + 1].StyleNew.BackColor = ClassLib.ComVar.ClrRelease; 
						} 

 


					}
					else if(level == _Level_MLine)
					{

						
						// finish_yn, plan_status color
						if(fgrid_MiniSize[insert_row, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
						{
							fgrid_MiniSize.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrReadOnly;
							fgrid_MiniSize.Rows[insert_row].AllowEditing = false;
						}


						if(fgrid_MiniSize[insert_row, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
						{
							fgrid_MiniSize.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrReadOnly;
							fgrid_MiniSize.Rows[insert_row].AllowEditing = false;
						} 



						// display capa column color
						CellRange rg = fgrid_MiniSize.GetCellRange(insert_row, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxMLINE_STD_CAPA + 1);
						rg.StyleNew.ForeColor = ClassLib.ComVar.ClrImportant;
						rg.StyleNew.Font = new Font("Verdana", 7, FontStyle.Bold);

  


					} // end if level




					
					before_item = now_item;


				} // end if



				//-------------------------------------------------------------- 
				for(int j = (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxCS_SIZE_START; j < fgrid_MiniSize.Cols.Count; j++)
				{
					if(fgrid_MiniSize[2, j].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxCS_SIZE].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						if(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSIZE_QTY] == null 
							|| dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSIZE_QTY].ToString().Trim().Equals("") )
						{
							continue;
						} 

						sum_size_qty = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSIZE_QTY].ToString() );

						fgrid_MiniSize[insert_row, j] = (sum_size_qty.ToString() == "0") ? "" : sum_size_qty.ToString();
						 

						break; 
					} 
				}
				//--------------------------------------------------------------




			} // end for i 
			
 

			fgrid_MiniSize.Cols.Frozen = (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxCS_SIZE_START;
			fgrid_MiniSize.Tree.Column = (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTREE_DESC1 + 1;
			
			rad_Level4.Checked = true;
			fgrid_MiniSize.Tree.Show(_Level_Day); 


			
			
			#region



//			//---------------------------------------------------------------------------------------------------
//			// 현재 일자 하위 보여주기
//			//---------------------------------------------------------------------------------------------------
//			int now_level = 0;
//			string now_planymd = "";
// 
//			for(int i = fgrid_MiniSize.Rows.Fixed; i < fgrid_MiniSize.Rows.Count; i++)
//			{
//				
//				if(fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTREE_LEVEL + 1] == null) continue;
//				
//				now_level = Convert.ToInt32(fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTREE_LEVEL + 1].ToString() );
//				if(now_level != _Level_Day) continue;
//
//				
//				
//				if(fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxFINISH_DATE + 1] == null) continue;
//				
//				now_planymd = fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxFINISH_DATE + 1].ToString(); 
//				if(now_planymd != dpick_FromYMD.Value.ToString("yyyyMMdd") ) continue;
// 
//
//
//				Row r = fgrid_MiniSize.Rows[i];
//				if(!r.IsNode) return;
//				r.Node.Collapsed = !r.Node.Collapsed; 
//
//
//
//
////				// create border style
////				
////				_bdrBrush = new SolidBrush(Color.YellowGreen);
////				_bdrOutside = 3;
////				_bdrInside = 0;
////
////				// enable ownerdraw
////				fgrid_MiniSize.DrawMode = DrawModeEnum.OwnerDraw; 
////				
////
////
////				for(int a = r.Node.Row.Index; a <= r.Node.GetNode(NodeTypeEnum.LastChild).Row.Index; a++)
////				{
////					//CellStyle s = fgrid_MiniSize.Styles.Add("Border");
////
////					for(int b = 0; b < fgrid_MiniSize.Cols.Count; b++)
////					{
////						CellStyle s = fgrid_MiniSize.Styles.Add("Border"); // , fgrid_MiniSize.GetCellRange(a, b).Style 
////						CellRange rg = fgrid_MiniSize.GetCellRange(a, b);
////						rg.Style = fgrid_MiniSize.Styles["Border"];  
////					}
////
////				}
////
////				// repaint control to show changes
////				fgrid_MiniSize.Invalidate();
//
// 
//
//				for(int a = r.Node.Row.Index; a <= r.Node.GetNode(NodeTypeEnum.LastChild).Row.Index; a++)
//				{
// 
//					 
//					for(int b = 1; b < fgrid_MiniSize.Cols.Count; b++)
//					{ 
//						CellRange rg = fgrid_MiniSize.GetCellRange(a, b);
//						rg.StyleNew.BackColor = ClassLib.ComVar.GridAlternate_Color;
//
//
//						// set color : finish, released
//						if(fgrid_MiniSize[r.Node.Row.Index, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
//						{
//							rg.StyleNew.BackColor = ClassLib.ComVar.ClrFinishY; 
//						} 
//
//
//						if(fgrid_MiniSize[r.Node.Row.Index, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
//						{
//							rg.StyleNew.BackColor = ClassLib.ComVar.ClrRelease; 
//						} 
//
//
//					}  // end for b 
//
//
//				} // end for a
//
//
//
//
//			}
//			//---------------------------------------------------------------------------------------------------
 


			#endregion  



			//---------------------------------------------------------------------------------------------------
			// 현재 일자 하위 보여주기
			//---------------------------------------------------------------------------------------------------
			Display_Now_PlanDay();




			fgrid_MiniSize.LeftCol = min_size_col;



		} 

 
		
		/// <summary>
		/// Display_Now_PlanDay : 현재 일자 하위 보여주기
		/// </summary>
		private void Display_Now_PlanDay()
		{


			//---------------------------------------------------------------------------------------------------
			// 현재 일자 하위 보여주기
			//---------------------------------------------------------------------------------------------------
			int now_level = 0;
			string now_planymd = "";
	
			for(int i = fgrid_MiniSize.Rows.Fixed; i < fgrid_MiniSize.Rows.Count; i++)
			{
				
				if(fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTREE_LEVEL + 1] == null) continue;
				
				now_level = Convert.ToInt32(fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTREE_LEVEL + 1].ToString() );
				if(now_level != _Level_Day) continue;

				
				
				if(fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxFINISH_DATE + 1] == null) continue;
				
				now_planymd = fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxFINISH_DATE + 1].ToString(); 
				if(now_planymd != dpick_FromYMD.Value.ToString("yyyyMMdd") ) continue;
	


				Row r = fgrid_MiniSize.Rows[i];
				if(!r.IsNode) return;
				r.Node.Collapsed = !r.Node.Collapsed; 




//				// create border style
//				
//				_bdrBrush = new SolidBrush(Color.YellowGreen);
//				_bdrOutside = 3;
//				_bdrInside = 0;
//
//				// enable ownerdraw
//				fgrid_MiniSize.DrawMode = DrawModeEnum.OwnerDraw; 
//				
//
//
//				for(int a = r.Node.Row.Index; a <= r.Node.GetNode(NodeTypeEnum.LastChild).Row.Index; a++)
//				{
//					//CellStyle s = fgrid_MiniSize.Styles.Add("Border");
//
//					for(int b = 0; b < fgrid_MiniSize.Cols.Count; b++)
//					{
//						CellStyle s = fgrid_MiniSize.Styles.Add("Border"); // , fgrid_MiniSize.GetCellRange(a, b).Style 
//						CellRange rg = fgrid_MiniSize.GetCellRange(a, b);
//						rg.Style = fgrid_MiniSize.Styles["Border"];  
//					}
//
//				}
//
//				// repaint control to show changes
//				fgrid_MiniSize.Invalidate();

	

				for(int a = r.Node.Row.Index; a <= r.Node.GetNode(NodeTypeEnum.LastChild).Row.Index; a++)
				{
	
						
					for(int b = 1; b < fgrid_MiniSize.Cols.Count; b++)
					{ 
						CellRange rg = fgrid_MiniSize.GetCellRange(a, b);
						rg.StyleNew.BackColor = ClassLib.ComVar.GridAlternate_Color;


						// set color : finish, released
						if(fgrid_MiniSize[r.Node.Row.Index, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
						{
							rg.StyleNew.BackColor = ClassLib.ComVar.ClrFinishY; 
						} 


						if(fgrid_MiniSize[r.Node.Row.Index, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
						{
							rg.StyleNew.BackColor = ClassLib.ComVar.ClrRelease; 
						} 


					}  // end for b 


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
			for(int i = (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxCS_SIZE_START; i < fgrid_MiniSize.Cols.Count; i++)
			{
 

				for(int j = fgrid_MiniSize.Rows.Fixed; j < fgrid_MiniSize.Rows.Count; j++)
				{
				
					node = fgrid_MiniSize.Rows[j].Node;

					if(node.Level != _Level_Day) continue;


					start_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
					 
					for(int a = start_row + 1; a <= end_row; a++)
					{
						if(fgrid_MiniSize[a, i] == null || fgrid_MiniSize[a, i].ToString().Trim().Equals("") ) continue;

						sum_balance += Convert.ToInt32( fgrid_MiniSize[a, i].ToString() );
					}

					sum_qty = Convert.ToInt32( (fgrid_MiniSize[j, i] == null || fgrid_MiniSize[j, i].ToString().Trim() == "") ? "0" :  fgrid_MiniSize[j, i].ToString() );


					fgrid_MiniSize[start_row, i] = Convert.ToSingle(sum_qty - sum_balance); 


					// balance 불일치 표시
					if(fgrid_MiniSize[start_row, i] == null || fgrid_MiniSize[start_row, i].ToString().Trim().Equals("") )
					{
						fgrid_MiniSize[start_row, i] = "0";
					}

					if(fgrid_MiniSize[start_row - 1, i] == null || fgrid_MiniSize[start_row - 1, i].ToString().Trim().Equals("") )
					{
						fgrid_MiniSize[start_row - 1, i] = "0";
					}


					//if(Convert.ToInt32(fgrid_MiniSize[start_row, i].ToString() ) != Convert.ToInt32(fgrid_MiniSize[start_row - 1, i].ToString() ) )
					if(Convert.ToInt32(fgrid_MiniSize[start_row, i].ToString() ) != 0)
					{


						CellRange cr = fgrid_MiniSize.GetCellRange(start_row, i);  
						cr.StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;


 
//						CellStyle s = fgrid_MiniSize.Styles.Add("Warning"); // , fgrid_MiniSize.GetCellRange(start_row, i).Style 
//						s.ForeColor = ClassLib.ComVar.ClrWarning;
//						s.Font = new Font("Verdana", 7, FontStyle.Bold);
//
//						CellRange cr = fgrid_MiniSize.GetCellRange(start_row, i); 
//						cr.Style = fgrid_MiniSize.Styles["Warning"];  
						 
						
						//---------------------------------------------------------
						// 현재 입력 대상 일자에서만 balance 안맞는 수량 체크
						//---------------------------------------------------------
						
						//_Count_UnBalance_Qty++;



						if(fgrid_MiniSize[start_row - 1, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxFINISH_DATE + 1] != null)
						{
							string plan_ymd = fgrid_MiniSize[start_row - 1, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxFINISH_DATE + 1].ToString();

							if(plan_ymd == dpick_FromYMD.Value.ToString("yyyyMMdd"))
							{
								_Count_UnBalance_Qty++;
							}

						}
						//---------------------------------------------------------



					}
					else
					{
						
						CellRange cr = fgrid_MiniSize.GetCellRange(start_row, i);  
						cr.StyleNew.ForeColor = Color.Black;


//						CellStyle s = fgrid_MiniSize.Styles.Add("Normal"); //, fgrid_MiniSize.GetCellRange(start_row, i).Style 
//						s.ForeColor = Color.Black;
//						s.Font = new Font("Verdana", 7);
//
//						CellRange cr = fgrid_MiniSize.GetCellRange(start_row, i); 
//						cr.Style = fgrid_MiniSize.Styles["Normal"];  


					}


					// balance 초기화
					sum_balance = 0;
					sum_qty = 0;

				
				} // end for j



			} // end for i



			// 행 balance  
			for(int i = fgrid_MiniSize.Rows.Fixed; i < fgrid_MiniSize.Rows.Count; i++)
			{
				
 
				node = fgrid_MiniSize.Rows[i].Node;

				if(node.Level != _Level_MLine) continue;

				for(int j = (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxCS_SIZE_START; j < fgrid_MiniSize.Cols.Count; j++)
				{

					if(fgrid_MiniSize[i, j] == null || fgrid_MiniSize[i, j].ToString().Trim().Equals("") ) continue;

					sum_balance += Convert.ToInt32( fgrid_MiniSize[i, j].ToString() );

				} // end for j


				fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1] = sum_balance.ToString();


				// balance 불일치 표시
				if(fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1] == null 
					|| fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1].ToString().Trim().Equals("") )
				{
					fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1] = "0";
				}

				if(fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTOT_QTY + 1] == null 
					|| fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTOT_QTY + 1].ToString().Trim().Equals("") )
				{
					fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTOT_QTY + 1] = "0";
				}


				if(Convert.ToInt32(fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1].ToString() ) 
					!= Convert.ToInt32(fgrid_MiniSize[i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTOT_QTY + 1].ToString() ) )
				{

					
					CellRange cr = fgrid_MiniSize.GetCellRange(i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1); 
					cr.StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;  


//					CellStyle s = fgrid_MiniSize.Styles.Add("Warning"); //, fgrid_MiniSize.GetCellRange(i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1).Style 
//					s.ForeColor = ClassLib.ComVar.ClrWarning;
//					s.Font = new Font("Verdana", 7, FontStyle.Bold);
//
//					CellRange cr = fgrid_MiniSize.GetCellRange(i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1); 
//					cr.Style = fgrid_MiniSize.Styles["Warning"];  


				}
				else
				{


					CellRange cr = fgrid_MiniSize.GetCellRange(i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1); 
					cr.StyleNew.ForeColor = Color.Black;


 
//					CellStyle s = fgrid_MiniSize.Styles.Add("Normal"); // , fgrid_MiniSize.GetCellRange(i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1).Style 
//					s.ForeColor = Color.Black;
//					s.Font = new Font("Verdana", 7);
//
//					CellRange cr = fgrid_MiniSize.GetCellRange(i, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1); 
//					cr.Style = fgrid_MiniSize.Styles["Normal"];  


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
			fgrid_MiniSize.Rows.Count = fgrid_MiniSize.Rows.Fixed;

		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{
 
			Display_LOT_DAILY_SIZE(); 
			Display_LOT_DAILY_MINI_SIZE(fgrid_LOT.Rows.Fixed);  

		}


		/// <summary>
		/// Event_Tbtn_Save : 
		/// </summary>
		private void Event_Tbtn_Save()
		{
 
			//행 수정 상태 해제
			fgrid_MiniSize.Select(fgrid_MiniSize.Selection.r1, 0, fgrid_MiniSize.Selection.r1, fgrid_MiniSize.Cols.Count-1, false);
 
		
			// 수정, 조회때마다 Balance 계산하여 정합성 맞지 않는 카운터 관리하므로 수량 정합성 체크 생략
			if(_Count_UnBalance_Qty != 0)
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
				ClassLib.ComFunction.User_Message("Exist quantity unbalance size.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}



			bool save_flag = Update_SPO_LOT_DAILY_MINI_SIZE();

			if(! save_flag) 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this); 

				Display_LOT_DAILY_MINI_SIZE(); 
				Display_Qty_Balance();

			}
				
			 


		}



		#endregion

		#region 그리드 이벤트 메서드


		/// <summary>
		/// Event_Click_fgrid_LOT : 
		/// </summary>
		private void Event_Click_fgrid_LOT()
		{

			if(fgrid_LOT.Rows.Count <= fgrid_LOT.Rows.Fixed) 
			{
				fgrid_MiniSize.Rows.Count = fgrid_MiniSize.Rows.Fixed;
				return;
			}

			
			//subtotal row
			if(fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxLOT] == null) 
			{
				fgrid_MiniSize.Rows.Count = fgrid_MiniSize.Rows.Fixed;
				return;
			}
 
			Display_LOT_DAILY_MINI_SIZE(fgrid_LOT.Selection.r1); 

		}



		/// <summary>
		/// Event_AfterEdit_fgrid_MiniSize : 
		/// </summary>
		/// <param name="e"></param>
		private void Event_AfterEdit_fgrid_MiniSize(C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			bool digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_MiniSize[e.Row, e.Col].ToString());

			if(digit_flag == false) 
			{
				fgrid_MiniSize[e.Row, e.Col] = _BeforeQty;
				return;
			}
			 

			Display_Qty_Balance();

			fgrid_MiniSize[e.Row, 0] = "Y";


			// check miniline capa -> only warning
			if(chk_CheckCapa.Checked)
			{
			
				int mline_std_capa = Convert.ToInt32(fgrid_MiniSize[e.Row, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxMLINE_STD_CAPA + 1].ToString() );
				int mline_now_qty = Convert.ToInt32(fgrid_MiniSize[e.Row, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxSUM_QTY + 1].ToString() );

				if(mline_std_capa < mline_now_qty)
				{
					ClassLib.ComFunction.User_Message("Now miniline summary quantity more than miniline standard capacity.", "Modify Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				}

			}





		}


		#region Border 표시


//		private void Event_OwnerDrawCell_fgrid_MiniSize(C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
//		{
//
//			// we only want cells with style set to "Border" 
//			CellStyle s = fgrid_MiniSize.GetCellStyle(e.Row, e.Col);
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
//			CellRange rg = fgrid_MiniSize.GetCellRange(row, col);
//			if (rg.Style == null || rg.Style.Name != "Border")
//				return _m;
//
//			// check whether this cell is at the top of the range
//			_m.Top = _bdrOutside;
//			if (row > fgrid_MiniSize.Rows.Fixed)
//			{
//				rg.r1 = rg.r2 = row-1;
//				if (rg.Style != null && rg.Style.Name == "Border")
//					_m.Top = 0;
//				rg.r1 = rg.r2 = row;
//			}
//
//			// check whether this cell is at the left of the range
//			_m.Left = _bdrOutside;
//			if (col > fgrid_MiniSize.Cols.Fixed)
//			{
//				rg.c1 = rg.c2 = col-1;
//				if (rg.Style != null && rg.Style.Name == "Border")
//					_m.Left = 0;
//				rg.c1 = rg.c2 = col;
//			}
//
//			// check whether this cell is at the bottom of the range
//			_m.Bottom = _bdrOutside;
//			if (row < fgrid_MiniSize.Rows.Count-1)
//			{
//				rg.r1 = rg.r2 = row+1;
//				if (rg.Style != null && rg.Style.Name == "Border")
//					_m.Bottom = _bdrInside;
//				rg.r1 = rg.r2 = row;
//			}
//
//			// check whether this cell is at the right of the range
//			_m.Right = _bdrOutside;
//			if (col < fgrid_MiniSize.Cols.Count-1)
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
 

		#endregion
 
		#region 컨텍스트 메뉴 이벤트 메서드


		/// <summary>
		/// Event_Click_menuItem_Clear : 
		/// </summary>
		private void Event_Click_menuItem_Clear()
		{
 
			
			int[] sel_row = fgrid_MiniSize.Selections;

			for(int i = 0; i < sel_row.Length; i++)
			{
				
				//finisn_yn = 'Y' 이면 제외
				if(fgrid_MiniSize[sel_row[i], (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTS_FINISH_YN + 1] == null) continue;
				if(fgrid_MiniSize[sel_row[i], (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() != "N") continue;


				if(fgrid_MiniSize.Rows[sel_row[i]].Node.Level != _Level_MLine) continue;


				for(int j = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxCS_SIZE_START; j < fgrid_MiniSize.Cols.Count; j++)
				{
					fgrid_MiniSize[sel_row[i], j] = ""; 

				} // end for j

				fgrid_MiniSize[sel_row[i], 0] = "Y"; 

			} // end for i



			Display_Qty_Balance();


		}



		/// <summary>
		/// Event_Click_menuItem_SelMLine : 
		/// </summary>
		private void Event_Click_menuItem_SelMLine()
		{
   


			
			bool save_flag = Check_Before_Reset_Mline();

			if(!save_flag)
			{
				DialogResult message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				
				// save 먼저 처리 후 미니라인 재설정
				if(message_result == DialogResult.Yes)
				{
					Event_Tbtn_Save();
				}
			}
			
	 
			string factory = cmb_Factory.SelectedValue.ToString();
			string opcd = ClassLib.ComVar.StdOpCd;
			string linecd = cmb_LineCd.SelectedValue.ToString();  
			
		
			// 메인라인 일때만 미니라인 재설정 가능함
            // (001 ~ 006, 031 ~ 036)
			//if(Convert.ToInt32(linecd) > 6) return;

			if( (Convert.ToInt32(linecd) <= 1 && Convert.ToInt32(linecd) >= 6)
				|| (Convert.ToInt32(linecd) <= 31 && Convert.ToInt32(linecd) >= 36) ) return;




			ClassLib.ComVar.Parameter_PopUp = new string[] {factory, opcd, linecd};

			ProdPlan.Pop_SelMLine pop_form = new ProdPlan.Pop_SelMLine();  
			pop_form.ShowDialog(); 

			// 미니라인코드 일별 리스트 표시 
			Display_LOT_DAILY_MINI_SIZE(); 
			Display_Qty_Balance();



		}




		/// <summary>
		/// Check_Before_Reset_Mline : 
		/// </summary>
		/// <returns></returns>
		private bool Check_Before_Reset_Mline()
		{
		
			try
			{

				int count = 0;


				for(int i = fgrid_MiniSize.Rows.Fixed; i < fgrid_MiniSize.Rows.Count; i++)
				{
					if(fgrid_MiniSize[i, 0] == null) continue;
					if(fgrid_MiniSize[i, 0].ToString() == "Y") count++;
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

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}
		 


		#endregion

		#region 그리드 이벤트
		

		private void fgrid_LOT_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_fgrid_LOT(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_fgrid_LOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		}

		private void fgrid_MiniSize_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				if(fgrid_MiniSize[e.Row, e.Col] == null)  fgrid_MiniSize[e.Row, e.Col] = ""; 
				_BeforeQty = (fgrid_MiniSize[e.Row, e.Col].ToString() == "") ? "0": fgrid_MiniSize[e.Row, e.Col].ToString();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_MiniSize_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		}

		private void fgrid_MiniSize_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				Event_AfterEdit_fgrid_MiniSize(e);
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_AfterEdit_fgrid_MiniSize", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  


		} 
 	
		private void fgrid_MiniSize_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
		{

			try
			{
//				Event_OwnerDrawCell_fgrid_MiniSize(e);
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_OwnerDrawCell_fgrid_MiniSize", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

 
		private void Form_PO_LOTDailyMini_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		
		private void Form_PO_LOTDailyMini_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ClassLib.ComVar.FormDailyMini= null;
		}



		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				if(cmb_Factory.SelectedIndex == -1) return;


				// 초기화
				fgrid_LOT.Rows.Count = 2; 
				fgrid_MiniSize.Rows.Count = fgrid_MiniSize.Rows.Fixed; 

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
				ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_LOT, 
															factory, 
															"", 
															fgrid_LOT.Rows.Fixed,
															(int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxGEN,
															(int)ClassLib.TBSPO_LOT_DAILY_MINI_HEAD_BSC.IxCS_SIZE_START);

				


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
  
				fgrid_LOT.Rows.Count = fgrid_LOT.Rows.Fixed;
				fgrid_MiniSize.Rows.Count = fgrid_MiniSize.Rows.Fixed;


//				if(src.Equals(dpick_ToYMD))
//				{

					if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1) return;

					Display_LOT_DAILY_SIZE(); 
					Display_LOT_DAILY_MINI_SIZE(fgrid_LOT.Rows.Fixed); 
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

				Display_LOT_DAILY_SIZE(); 
				Display_LOT_DAILY_MINI_SIZE(fgrid_LOT.Rows.Fixed); 

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
					ClassLib.ComFunction.Set_Grid_Font_Size(fgrid_LOT, Convert.ToSingle(txt_Font.Text));
					ClassLib.ComFunction.Set_Grid_Font_Size(fgrid_MiniSize, Convert.ToSingle(txt_Font.Text));
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
				fgrid_MiniSize.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) ); 

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
				
				string factory = cmb_Factory.SelectedValue.ToString();
				//string planymd = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
				string planymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
				string linecd = cmb_LineCd.SelectedValue.ToString();  

				ClassLib.ComVar.Parameter_PopUp = new string[] {factory, planymd, linecd};
 
				if(ClassLib.ComVar.FormDailyTS == null)
				{
					ClassLib.ComVar.FormDailyTS = new ProdSheet.Form_PD_LOTDaily_MiniSize_TS(); 
					ClassLib.ComVar.FormClick_Flag = true;
					ClassLib.ComVar.FormDailyTS.ShowDialog();
				}
				else
				{
					ClassLib.ComVar.FormDailyTS.Select();
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_AssignTS_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void menuItem_SelMLine_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_menuItem_SelMLine(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_SelMLine", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		private DataTable Select_SPO_LOT_SIZE_DAY(string arg_factory, string arg_fromymd, string arg_toymd, string arg_line_cd, string arg_lot)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPO_LOT_SIZE_DAY";

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
		/// Select_SPO_LOT_DAILY_MINI_SIZE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		/// <param name="arg_opcd">standard opcd : UPS</param>
		/// <param name="arg_dayseq"></param>
		/// <returns></returns>
		private DataTable Select_SPO_LOT_DAILY_MINI_SIZE(string arg_factory, string arg_lotno, string arg_lotseq, string arg_opcd, string arg_dayseq)
		{

			try
			{

				DataSet ds_ret;
				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPO_LOT_DAILY_MINI_SIZE";

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

		#region 컨텍스트 메뉴


		 
		 

		#endregion

		#region 저장


		/// <summary>
		/// Update_SPO_LOT_DAILY_MINI_SIZE : 
		/// </summary> 
		/// <returns></returns>
		public bool Update_SPO_LOT_DAILY_MINI_SIZE()
		{

			try
			{ 

				
				int col_ct = 14;  						 
				int row = 0, col = 0;
				


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.UPDATE_SPO_LOT_DAILY_MINI_SIZE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_REQ_NO"; 
				MyOraDB.Parameter_Name[6] = "ARG_OP_CD";
				MyOraDB.Parameter_Name[7] = "ARG_MLINE_CD"; 
				MyOraDB.Parameter_Name[8] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[9] = "ARG_SIZE_QTY";
				MyOraDB.Parameter_Name[10] = "ARG_LOSS_QTY"; 
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
  


				int start_row = 0;
				int end_row = 0; 



				for(row = fgrid_MiniSize.Rows.Fixed; row <= fgrid_MiniSize.Rows.Count - 1; row++)
				{

					node = fgrid_MiniSize.Rows[row].Node;

					if(node.Level != _Level_Day) continue;


					// 현재 일자 check
					if(fgrid_MiniSize[row, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxFINISH_DATE + 1] == null) continue;
				
					now_planymd = fgrid_MiniSize[row, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxFINISH_DATE + 1].ToString(); 
					if(now_planymd != plan_ymd ) continue;




					start_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
					 

					int save_exist_count = 0;

					for(int a = start_row + 1; a <= end_row; a++)
					{
						if(fgrid_MiniSize[a, 0] == null || fgrid_MiniSize[a, 0].ToString() != "Y") continue; 

						save_exist_count++;
					}

					if(save_exist_count == 0) continue;






					day_seq = fgrid_MiniSize[start_row + 1, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxDAY_SEQ + 1].ToString();
					req_no = fgrid_MiniSize[start_row + 1, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxREQ_NO + 1].ToString();



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
						
						
						if(fgrid_MiniSize[a, 0] == null || fgrid_MiniSize[a, 0].ToString() != "Y") continue; 
 
						
						mline_cd = fgrid_MiniSize[a, (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxMLINE_CD + 1].ToString(); 
  

						for(col = (int)ClassLib.TBSPO_LOT_DAILY_MINI_SIZE_BSC.IxCS_SIZE_START; col < fgrid_MiniSize.Cols.Count; col++)
						{  
							if(fgrid_MiniSize[a, col] == null || fgrid_MiniSize[a, col].ToString() == "" || fgrid_MiniSize[a, col].ToString() == "0") continue;
						 

							vList.Add("I"); 
							vList.Add(factory); 
							vList.Add(lot_no); 
							vList.Add(lot_seq);  
							vList.Add(day_seq); 
							vList.Add(req_no);
							vList.Add(op_cd); 
							vList.Add(mline_cd); 
							vList.Add(fgrid_MiniSize[2, col].ToString() );  //cs_size
							vList.Add(fgrid_MiniSize[a, col].ToString() );  //size_qty
							vList.Add("0");  //loss_qty
							vList.Add(plan_ymd); 
							vList.Add(line_cd); 
							vList.Add(ClassLib.ComVar.This_User); 
   

						} // end for col 


					} // end for a
 
					 
					vList.Add("H"); 
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
					vList.Add(plan_ymd); 
					vList.Add(line_cd); 
					vList.Add(ClassLib.ComVar.This_User); 




				} // end for i
  
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

		

		#endregion




	}
}


