using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexAPS.ProdPlan
{
	public class Form_PO_LOTDailySize : COM.APSWinForm.Form_Top
	{

		
		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.ContextMenu cmenu_Grid;
		private System.Windows.Forms.MenuItem menuItem_AssignSize;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem_DisplayMold;
		private System.Windows.Forms.MenuItem menuItem_AssignSizeAll;
		private System.Windows.Forms.MenuItem menuItem_Clear;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.MenuItem menuItem_StyleMold;
		private System.Windows.Forms.MenuItem menuItem_DailySave;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_Head;
		public System.Windows.Forms.Panel pnl_HeadSearch;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.DateTimePicker dpick_ToYMD;
		private System.Windows.Forms.TextBox txt_Font;
		private System.Windows.Forms.Label lbl_Font;
		public System.Windows.Forms.DateTimePicker dpick_FromYMD;
		private C1.Win.C1List.C1Combo cmb_LineCd;
		private System.Windows.Forms.Label lbl_LineCd;
		private System.Windows.Forms.Label lbl_PlanYMD;
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
		private COM.FSP fgrid_LOT;
		private System.Windows.Forms.Panel pnl_Tail;
		public System.Windows.Forms.Panel pnl_TailSearch;
		public System.Windows.Forms.Panel pnl_SearchImage;
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
		public COM.FSP fgrid_Size;
		private System.Windows.Forms.Label btn_SetMLine;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_Level1;
		private System.Windows.Forms.RadioButton rad_Level2;
		private System.Windows.Forms.RadioButton rad_Level3;
		private System.Windows.Forms.Label btn_SetReqPriority;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem_HideOneDay;
		private System.Windows.Forms.MenuItem menuItem_ShowAllDays;
		private System.Windows.Forms.Label btn_ShowDailyQty;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자


		public Form_PO_LOTDailySize()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_LOTDailySize));
			this.cmenu_Grid = new System.Windows.Forms.ContextMenu();
			this.menuItem_AssignSize = new System.Windows.Forms.MenuItem();
			this.menuItem_AssignSizeAll = new System.Windows.Forms.MenuItem();
			this.menuItem_Clear = new System.Windows.Forms.MenuItem();
			this.menuItem_DailySave = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem_DisplayMold = new System.Windows.Forms.MenuItem();
			this.menuItem_StyleMold = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem_ShowAllDays = new System.Windows.Forms.MenuItem();
			this.menuItem_HideOneDay = new System.Windows.Forms.MenuItem();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_Tail = new System.Windows.Forms.Panel();
			this.fgrid_Size = new COM.FSP();
			this.pnl_TailSearch = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rad_Level3 = new System.Windows.Forms.RadioButton();
			this.rad_Level2 = new System.Windows.Forms.RadioButton();
			this.rad_Level1 = new System.Windows.Forms.RadioButton();
			this.btn_SetMLine = new System.Windows.Forms.Label();
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
			this.btn_SetReqPriority = new System.Windows.Forms.Label();
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
			this.btn_ShowDailyQty = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_Tail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Size)).BeginInit();
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
																					   this.menuItem_AssignSize,
																					   this.menuItem_AssignSizeAll,
																					   this.menuItem_Clear,
																					   this.menuItem_DailySave,
																					   this.menuItem2,
																					   this.menuItem_DisplayMold,
																					   this.menuItem_StyleMold,
																					   this.menuItem1,
																					   this.menuItem_ShowAllDays,
																					   this.menuItem_HideOneDay});
			// 
			// menuItem_AssignSize
			// 
			this.menuItem_AssignSize.Index = 0;
			this.menuItem_AssignSize.Text = "Assign Size";
			this.menuItem_AssignSize.Visible = false;
			this.menuItem_AssignSize.Click += new System.EventHandler(this.menuItem_AssignSize_Click);
			// 
			// menuItem_AssignSizeAll
			// 
			this.menuItem_AssignSizeAll.Index = 1;
			this.menuItem_AssignSizeAll.Text = "Assign Size (All)";
			this.menuItem_AssignSizeAll.Click += new System.EventHandler(this.menuItem_AssignSizeAll_Click);
			// 
			// menuItem_Clear
			// 
			this.menuItem_Clear.Index = 2;
			this.menuItem_Clear.Text = "Clear";
			this.menuItem_Clear.Click += new System.EventHandler(this.menuItem_Clear_Click);
			// 
			// menuItem_DailySave
			// 
			this.menuItem_DailySave.Index = 3;
			this.menuItem_DailySave.Text = "Daily Save";
			this.menuItem_DailySave.Click += new System.EventHandler(this.menuItem_DailySave_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 4;
			this.menuItem2.Text = "-";
			this.menuItem2.Visible = false;
			// 
			// menuItem_DisplayMold
			// 
			this.menuItem_DisplayMold.Index = 5;
			this.menuItem_DisplayMold.Text = "Display Mold Capa.";
			this.menuItem_DisplayMold.Visible = false;
			this.menuItem_DisplayMold.Click += new System.EventHandler(this.menuItem_DisplayMold_Click);
			// 
			// menuItem_StyleMold
			// 
			this.menuItem_StyleMold.Index = 6;
			this.menuItem_StyleMold.Text = "View Style Mold Capa.";
			this.menuItem_StyleMold.Visible = false;
			this.menuItem_StyleMold.Click += new System.EventHandler(this.menuItem_StyleMold_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 7;
			this.menuItem1.Text = "-";
			// 
			// menuItem_ShowAllDays
			// 
			this.menuItem_ShowAllDays.Index = 8;
			this.menuItem_ShowAllDays.Text = "Show All Days";
			this.menuItem_ShowAllDays.Click += new System.EventHandler(this.menuItem_ShowAllDays_Click);
			// 
			// menuItem_HideOneDay
			// 
			this.menuItem_HideOneDay.Index = 9;
			this.menuItem_HideOneDay.Text = "Hide One Day";
			this.menuItem_HideOneDay.Click += new System.EventHandler(this.menuItem_HideOneDay_Click);
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
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
			this.c1Sizer1.GridDefinition = "35.5902777777778:True:False;62.3263888888889:False:False;\t99.2125984251968:False:" +
				"False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_Tail
			// 
			this.pnl_Tail.Controls.Add(this.fgrid_Size);
			this.pnl_Tail.Controls.Add(this.pnl_TailSearch);
			this.pnl_Tail.Location = new System.Drawing.Point(4, 213);
			this.pnl_Tail.Name = "pnl_Tail";
			this.pnl_Tail.Size = new System.Drawing.Size(1008, 359);
			this.pnl_Tail.TabIndex = 1;
			// 
			// fgrid_Size
			// 
			this.fgrid_Size.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Size.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Size.ContextMenu = this.cmenu_Grid;
			this.fgrid_Size.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Size.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Size.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Size.Location = new System.Drawing.Point(0, 43);
			this.fgrid_Size.Name = "fgrid_Size";
			this.fgrid_Size.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Size.Size = new System.Drawing.Size(1008, 316);
			this.fgrid_Size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Size.TabIndex = 44;
			this.fgrid_Size.Click += new System.EventHandler(this.fgrid_Size_Click);
			this.fgrid_Size.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Size_BeforeEdit);
			this.fgrid_Size.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Size_AfterEdit);
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
			this.pnl_SearchImage.Controls.Add(this.groupBox1);
			this.pnl_SearchImage.Controls.Add(this.btn_SetMLine);
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
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rad_Level3);
			this.groupBox1.Controls.Add(this.rad_Level2);
			this.groupBox1.Controls.Add(this.rad_Level1);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8F);
			this.groupBox1.Location = new System.Drawing.Point(727, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(170, 32);
			this.groupBox1.TabIndex = 45;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "View Option";
			// 
			// rad_Level3
			// 
			this.rad_Level3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Level3.Location = new System.Drawing.Point(124, 14);
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
			this.rad_Level2.Location = new System.Drawing.Point(56, 14);
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
			this.rad_Level1.Size = new System.Drawing.Size(48, 16);
			this.rad_Level1.TabIndex = 0;
			this.rad_Level1.Tag = "0";
			this.rad_Level1.Text = "LOT";
			this.rad_Level1.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// btn_SetMLine
			// 
			this.btn_SetMLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SetMLine.ImageIndex = 0;
			this.btn_SetMLine.ImageList = this.img_LongButton;
			this.btn_SetMLine.Location = new System.Drawing.Point(901, 8);
			this.btn_SetMLine.Name = "btn_SetMLine";
			this.btn_SetMLine.TabIndex = 197;
			this.btn_SetMLine.Text = "Assign MiniLine";
			this.btn_SetMLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_SetMLine.Click += new System.EventHandler(this.btn_SetMLine_Click);
			this.btn_SetMLine.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_SetMLine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_SetMLine.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_SetMLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
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
			this.pnl_Head.Size = new System.Drawing.Size(1008, 205);
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
			this.fgrid_LOT.Size = new System.Drawing.Size(1008, 140);
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
			this.panel1.Controls.Add(this.btn_ShowDailyQty);
			this.panel1.Controls.Add(this.btn_SetReqPriority);
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
			// btn_SetReqPriority
			// 
			this.btn_SetReqPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SetReqPriority.ImageIndex = 0;
			this.btn_SetReqPriority.ImageList = this.img_LongButton;
			this.btn_SetReqPriority.Location = new System.Drawing.Point(792, 33);
			this.btn_SetReqPriority.Name = "btn_SetReqPriority";
			this.btn_SetReqPriority.Size = new System.Drawing.Size(115, 23);
			this.btn_SetReqPriority.TabIndex = 198;
			this.btn_SetReqPriority.Text = "Set Dest. Priority";
			this.btn_SetReqPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_SetReqPriority.Click += new System.EventHandler(this.btn_SetReqPriority_Click);
			this.btn_SetReqPriority.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_SetReqPriority.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_SetReqPriority.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_SetReqPriority.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
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
			this.cmb_LineCd.Location = new System.Drawing.Point(442, 34);
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
			this.lbl_LineCd.Location = new System.Drawing.Point(391, 34);
			this.lbl_LineCd.Name = "lbl_LineCd";
			this.lbl_LineCd.Size = new System.Drawing.Size(50, 21);
			this.lbl_LineCd.TabIndex = 72;
			this.lbl_LineCd.Text = "Line";
			this.lbl_LineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(272, 8);
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
			this.dpick_ToYMD.Location = new System.Drawing.Point(288, 8);
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
			this.txt_Font.BackColor = System.Drawing.Color.White;
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
			// btn_ShowDailyQty
			// 
			this.btn_ShowDailyQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ShowDailyQty.ImageIndex = 0;
			this.btn_ShowDailyQty.ImageList = this.img_LongButton;
			this.btn_ShowDailyQty.Location = new System.Drawing.Point(693, 33);
			this.btn_ShowDailyQty.Name = "btn_ShowDailyQty";
			this.btn_ShowDailyQty.Size = new System.Drawing.Size(105, 23);
			this.btn_ShowDailyQty.TabIndex = 199;
			this.btn_ShowDailyQty.Text = "Show Daily Qty.";
			this.btn_ShowDailyQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_ShowDailyQty.Click += new System.EventHandler(this.btn_ShowDailyQty_Click);
			this.btn_ShowDailyQty.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_ShowDailyQty.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_ShowDailyQty.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_ShowDailyQty.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Form_PO_LOTDailySize
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_PO_LOTDailySize";
			this.Text = "Assign Size to LOT";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PO_LOTDailySize_Closing);
			this.Load += new System.EventHandler(this.Form_PO_LOTDailySize_Load);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_Tail.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Size)).EndInit();
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
   
 
		//mps 상에서 바로 사이즈 수정하고자 할때 구분자
		public bool _DirectlyMPS = false;		
		private string _LOT; 
		 


		//선택되어졌던 젠더 행
		private int _BeforeGenRow = -1;

		//수정하기 전 수량
		private string _BeforeQty;


		//표시 레벨 정보
		private int _Level_LOT = 0;
		private int _Level_Req = 1;
		private int _Level_Day = 2;





//		//몰드 정보 visible 여부
//		private bool _View_Mold = false;


		//Balance 맞지 않는 수량 카운트 : 저장 시 정합성 체크 여부로 참조
		private int _Count_UnBalance_Qty = 0;


		//grid original row height
		private int _GridRow_Height = 0;



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
 			
				// Title 
				this.Text = "Assign Size to LOT";
				this.lbl_MainTitle.Text = "Assign Size to LOT"; 

				ClassLib.ComFunction.SetLangDic(this);
 

				
				fgrid_LOT.Set_Grid("SPO_LOT_DAILY_SIZE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
				//fgrid_LOT.Set_Action_Image(img_Action);
				fgrid_LOT.Font = new Font("Verdana", 7);
				fgrid_LOT.AllowSorting = AllowSortingEnum.None;
				fgrid_LOT.AllowDragging = AllowDraggingEnum.None;
				fgrid_LOT.Styles.Alternate.BackColor = Color.White; 
			

				fgrid_Size.Set_Grid("SPO_LOT_DAILY_SIZE", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_Size.Set_Action_Image(img_Action);  
				fgrid_Size.Mark_Grid_Menu();
				fgrid_Size.Font = new Font("Verdana", 7);
				fgrid_Size.ExtendLastCol = false; 
				fgrid_Size.AllowSorting = AllowSortingEnum.None;
				fgrid_Size.AllowDragging = AllowDraggingEnum.None;
				fgrid_Size.Styles.Alternate.BackColor = Color.White; 
				//fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTOT_QTY + 1].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
				fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTOT_QTY + 1].StyleNew.Font = new Font("Verdana", 7, FontStyle.Bold);
				//fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxSUM_QTY + 1].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
				fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxSUM_QTY + 1].StyleNew.Font = new Font("Verdana", 7, FontStyle.Bold); 





				//Set Combo List
				Init_Control(); 
 


				if(_DirectlyMPS)
				{
					cmb_Factory.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0];
					dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(Convert.ToDateTime(ClassLib.ComVar.Parameter_PopUp[1]).ToString("yyyyMMdd")); 
					dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(Convert.ToDateTime(ClassLib.ComVar.Parameter_PopUp[1]).ToString("yyyyMMdd")); 	
					cmb_LineCd.SelectedValue = ClassLib.ComVar.Parameter_PopUp[2];
					_LOT = ClassLib.ComVar.Parameter_PopUp[3];

					if(ClassLib.ComVar.This_FormDate == "") 
					{
						ClassLib.ComVar.This_FormDate = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
						ClassLib.ComVar.This_ToDate = MyComFunction.ConvertDate2DbType(dpick_ToYMD.Text);
					}

					Display_LOT_SIZE(); 
					Display_Size(fgrid_LOT.Rows.Fixed); 

				}
				else
				{
					cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
 
					if(ClassLib.ComVar.This_FormDate == "")
					{
						dpick_FromYMD.Text = ClassLib.ComVar.This_FormDate; 
						dpick_ToYMD.Text = ClassLib.ComVar.This_ToDate; 	
					}
				} 





				 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


			 
		}



		/// <summary>
		/// 
		/// </summary>
		private void Init_Control()
		{

			  
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false; 


			dpick_FromYMD.CustomFormat = " "; 
			dpick_ToYMD.CustomFormat = " ";  
			txt_Font.Text = ClassLib.ComVar.StdFontSize;


			rad_Level3.Checked = true;


			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
  


		} 
		
 


		#endregion 

		#region 조회


		private void Display_LOT_SIZE()
		{
			 
			string before_item = "", now_item = ""; 
			int gen_row = 0;   
			string sel_gen = "";
			int min_size_col = fgrid_LOT.Cols.Count + 1;   //default : col max value
			int sum_size_qty = 0; //lot_qty + loss_qty


			

			string factory = cmb_Factory.SelectedValue.ToString();
			string fromymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
			string toymd = dpick_ToYMD.Value.ToString("yyyyMMdd");
			string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_LineCd, " ");
			string lot = " "; //ClassLib.ComFunction.Empty_String(_LOT, " "); 

			DataTable dt_ret = Select_SPO_LOT_SIZE(factory, fromymd, toymd, line_cd, lot);
 
			fgrid_LOT.Rows.Count = fgrid_LOT.Rows.Fixed;
			fgrid_Size.Rows.Count = fgrid_Size.Rows.Fixed;
 
			txt_LineName.Text = ""; 
			txt_Model.Text = ""; 
			txt_StyleCd.Text = ""; 
			txt_Gen.Text = ""; 
			txt_LOT.Text = ""; 


			if(dt_ret.Rows.Count == 0) return;


  
			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
      	 
				now_item = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxLOT - 1].ToString();
 
				if(before_item != now_item)
				{
  
					fgrid_LOT.Rows.Add();
								
					//default data setting
					for(int j = 1; j <= (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN; j++)
					{
						fgrid_LOT[fgrid_LOT.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j - 1].ToString();
					}
 					 
					//gen
					for(int j = 1; j <= fgrid_LOT.Rows.Fixed; j++)
					{
						if(fgrid_LOT[j, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_LOT[gen_row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN].ToString();

							break;
						} 
					}


					before_item = now_item; 
					 

				}
 

				//--------------------------------------------------------------

				for(int j = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxCS_SIZE_START; j < fgrid_LOT.Cols.Count; j++)
				{
					if(fgrid_LOT[gen_row, j].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxCS_SIZE - 1].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						sum_size_qty = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxSIZE_QTY - 1].ToString()) 
							+ Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxLOSS_QTY - 1].ToString());
						
						fgrid_LOT[fgrid_LOT.Rows.Count - 1, j] = (sum_size_qty.ToString() == "0") ? "" : sum_size_qty.ToString();
						

						break; 
					} 
				}
  


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
					if(fgrid_LOT[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN].ToString() == token[j])
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
			fgrid_LOT.Cols[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxMODEL_NAME].AllowMerging = true;
			fgrid_LOT.Cols[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxSTYLE_CD].AllowMerging = true;


			//기타 속성 
			fgrid_LOT.Cols.Frozen = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxCS_SIZE_START;
			fgrid_LOT.LeftCol = min_size_col;
			fgrid_Size.Rows.Count = fgrid_Size.Rows.Fixed; 
			 
		}



		/// <summary>
		/// Display_Size : 
		/// </summary>
		/// <param name="arg_selrow"></param>
		private void Display_Size(int arg_selrow)
		{
			  
			if(fgrid_LOT.Rows.Count <= fgrid_LOT.Rows.Fixed) return;


			//------------------------------------------------
			//선택한 젠더행 색깔 표시
			string sel_gen = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN].ToString();

			int findrow = fgrid_LOT.FindRow(sel_gen, 1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN, false, true, false);

			if(findrow == -1) return;

			fgrid_LOT.GetCellRange(findrow, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN, findrow, fgrid_LOT.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow; 
			fgrid_LOT.GetCellRange(findrow, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN, findrow, fgrid_LOT.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
 
			if(_BeforeGenRow != -1 && _BeforeGenRow != findrow) 
				fgrid_LOT.GetCellRange(_BeforeGenRow, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN, _BeforeGenRow, fgrid_LOT.Cols.Count - 1).StyleNew.Clear(); 

			_BeforeGenRow = findrow;

			//------------------------------------------------
			//선택 데이터 정보 표시
			txt_LineName.Text = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxLINE_NAME].ToString(); 
			txt_Model.Text = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxMODEL_NAME].ToString();
			txt_StyleCd.Text = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxSTYLE_CD].ToString();
			txt_Gen.Text = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN].ToString();  
			txt_LOT.Text = fgrid_LOT[arg_selrow, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxLOT].ToString(); 


			// 사이즈 헤더 할당 
			fgrid_Size.Rows.Fixed = 2;
			ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_Size, 
														cmb_Factory.SelectedValue.ToString(), 
														txt_Gen.Text.Trim(), 
														fgrid_Size.Rows.Fixed,
														(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxGEN,
														(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxCS_SIZE_START);




			// 가장 긴 사이즈 문대만큼 x 표시 : report 용이
			Set_DefaultSize_Head_Add();


			Display_LOT_DAILY_SIZE(); 
			Display_Qty_Balance();
			
		}


		/// <summary>
		/// Set_DefaultSize_Head_Add : 가장 긴 사이즈 문대만큼 x 표시 : report 용이
		/// </summary>
		private void Set_DefaultSize_Head_Add()
		{

			int max_gen_count = fgrid_LOT.Cols.Count - (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxCS_SIZE_START;
			int now_gen_count = fgrid_Size.Cols.Count - ( (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxCS_SIZE_START); 
			
			if(now_gen_count >= max_gen_count) return;
			
			int before_gen_cont = fgrid_Size.Cols.Count;
			int add_gen_cont = max_gen_count - now_gen_count;

			fgrid_Size.Cols.Count = fgrid_Size.Cols.Count + add_gen_cont;



			for(int i = before_gen_cont; i < fgrid_Size.Cols.Count; i++)
			{
				fgrid_Size.Cols[i].Width = 45;  
				fgrid_Size.Cols[i].AllowSorting = false; 
				
				 
				if(fgrid_Size[2, i] == null) fgrid_Size[2, i] = "x"; 
				 

			} // end for i



		}


		
		/// <summary>
		/// Display_LOT_DAILY_SIZE : 
		/// </summary>
		private void Display_LOT_DAILY_SIZE()
		{
			  
		 
			string before_item = "", now_item = ""; 
			int level = 0;
			int min_size_col = fgrid_Size.Cols.Count + 1;   //default : col max value
			int sum_size_qty = 0;
			int insert_row = 0;


			string factory = cmb_Factory.SelectedValue.ToString(); 
			string[] token = txt_LOT.Text.Split('-');
			string lot_no = token[0];
			string lot_seq = token[1];

			DataTable dt_ret = Select_SPO_LOT_DAILY_SIZE(factory, lot_no, lot_seq);
  

			fgrid_Size.Rows.Count = fgrid_Size.Rows.Fixed;

			if(dt_ret.Rows.Count == 0) return; 


			

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{

				now_item = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxLOT_NO].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxLOT_SEQ].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxREQ_NO].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxOBS_NU].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxOBS_SEQ_NU].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxDAY_SEQ].ToString();


				if(before_item != now_item)
				{
				 
					level = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTREE_LEVEL].ToString() );  
					fgrid_Size.Rows.InsertNode(fgrid_Size.Rows.Count, level);

					insert_row = fgrid_Size.Rows.Count - 1;

					for(int j = 0; j <= (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxSUM_QTY; j++)
					{
						fgrid_Size[insert_row, j + 1] = dt_ret.Rows[i].ItemArray[j].ToString(); 
					} // end for j
	

 
					
					if(level == _Level_LOT)
					{
						fgrid_Size.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						fgrid_Size.Rows[insert_row].AllowEditing = false;
 
					}
					else if(level == _Level_Req)
					{
						fgrid_Size.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
						
						// req_no 별 balance row
						fgrid_Size.Rows.InsertNode(insert_row + 1, _Level_Day); 
						fgrid_Size.Rows[insert_row + 1].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
						fgrid_Size.Rows[insert_row + 1].StyleNew.Font = new Font("Verdana", 7, FontStyle.Bold);
						
						fgrid_Size[insert_row + 1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTREE_DESC1 + 1] = "Balance";
						
						fgrid_Size[insert_row + 1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTOT_QTY + 1] 
							= fgrid_Size[insert_row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTOT_QTY + 1];

						fgrid_Size.Rows[insert_row].AllowEditing = false;
						fgrid_Size.Rows[insert_row + 1].AllowEditing = false;


					}
					else if(level == _Level_Day)
					{

						// finish_yn, plan_status color
						if(fgrid_Size[insert_row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
						{
							fgrid_Size.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrFinishY;
							fgrid_Size.Rows[insert_row].AllowEditing = false;
						}


						if(fgrid_Size[insert_row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
						{
							fgrid_Size.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrRelease;
							fgrid_Size.Rows[insert_row].AllowEditing = false;
						} 

					} // end if level




					
					before_item = now_item;


				} // end if



				//-------------------------------------------------------------- 
				for(int j = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxCS_SIZE_START; j < fgrid_Size.Cols.Count; j++)
				{
					if(fgrid_Size[2, j].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxCS_SIZE].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						sum_size_qty = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxSIZE_QTY].ToString() );
						
						fgrid_Size[insert_row, j] = (sum_size_qty.ToString() == "0") ? "" : sum_size_qty.ToString();
						 

						break; 
					} 
				}
				//--------------------------------------------------------------




			} // end for i



			

			fgrid_Size.Cols.Frozen = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxCS_SIZE_START;
			fgrid_Size.Tree.Column = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTREE_DESC1 + 1;
			
			rad_Level3.Checked = true;
			fgrid_Size.Tree.Show(_Level_Day); 



			#region


//			//---------------------------------------------------------------------------------------------------
//			// 현재 일자 하위 보여주기
//			//---------------------------------------------------------------------------------------------------
//			int now_level = 0;
//			string now_planymd = "";
// 
//			for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
//			{
//				
//				if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTREE_LEVEL + 1] == null) continue;
//				
//				now_level = Convert.ToInt32(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTREE_LEVEL + 1].ToString() );
//				if(now_level != _Level_Day) continue;
//
//				
//				
//				if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxFINISH_DATE + 1] == null) continue;
//				
//				now_planymd = fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxFINISH_DATE + 1].ToString(); 
//				if(now_planymd != dpick_FromYMD.Value.ToString("yyyyMMdd") ) continue;
// 
//
//
//				Row r = fgrid_Size.Rows[i];
//				if(!r.IsNode) return;
//				r.Node.Collapsed = !r.Node.Collapsed; 
//
//
//
//				for(int b = 1; b < fgrid_Size.Cols.Count; b++)
//				{ 
//					CellRange rg = fgrid_Size.GetCellRange(r.Node.Row.Index, b);
//					rg.StyleNew.BackColor = ClassLib.ComVar.GridAlternate_Color; 
//
//
//					// set color : finish, released
//					if(fgrid_Size[r.Node.Row.Index, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
//					{
//						rg.StyleNew.BackColor = ClassLib.ComVar.ClrFinishY; 
//					} 
//
//
//					if(fgrid_Size[r.Node.Row.Index, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
//					{
//						rg.StyleNew.BackColor = ClassLib.ComVar.ClrRelease; 
//					} 
//
//
//
//				}  // end for b  
//
//
//			}


			#endregion


			//---------------------------------------------------------------------------------------------------
			// 현재 일자 하위 보여주기
			//---------------------------------------------------------------------------------------------------
			Display_Now_PlanDay();



			fgrid_Size.LeftCol = min_size_col;


 

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
 
			for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
			{
				
				if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTREE_LEVEL + 1] == null) continue;
				
				now_level = Convert.ToInt32(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTREE_LEVEL + 1].ToString() );
				if(now_level != _Level_Day) continue;

				
				
				if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxFINISH_DATE + 1] == null) continue;
				
				now_planymd = fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxFINISH_DATE + 1].ToString(); 
				if(now_planymd != dpick_FromYMD.Value.ToString("yyyyMMdd") ) continue;
 


				Row r = fgrid_Size.Rows[i];
				if(!r.IsNode) return;
				r.Node.Collapsed = !r.Node.Collapsed; 



				for(int b = 1; b < fgrid_Size.Cols.Count; b++)
				{ 
					CellRange rg = fgrid_Size.GetCellRange(r.Node.Row.Index, b);
					rg.StyleNew.BackColor = ClassLib.ComVar.GridAlternate_Color; 


					// set color : finish, released
					if(fgrid_Size[r.Node.Row.Index, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
					{
						rg.StyleNew.BackColor = ClassLib.ComVar.ClrFinishY; 
					} 


					if(fgrid_Size[r.Node.Row.Index, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxPLAN_STATUS + 1].ToString() == "D")
					{
						rg.StyleNew.BackColor = ClassLib.ComVar.ClrRelease; 
					} 



				}  // end for b  


			}



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
			for(int i = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxCS_SIZE_START; i < fgrid_Size.Cols.Count; i++)
			{
 

				for(int j = fgrid_Size.Rows.Fixed; j < fgrid_Size.Rows.Count; j++)
				{
				
					node = fgrid_Size.Rows[j].Node;

					if(node.Level != _Level_Req) continue;


					start_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
					 
					for(int a = start_row + 1; a <= end_row; a++)
					{
						if(fgrid_Size[a, i] == null || fgrid_Size[a, i].ToString().Trim().Equals("") ) continue;

						sum_balance += Convert.ToInt32( fgrid_Size[a, i].ToString() );
					}

					sum_qty = Convert.ToInt32( (fgrid_Size[j, i] == null || fgrid_Size[j, i].ToString().Trim() == "") ? "0" :  fgrid_Size[j, i].ToString() );


					fgrid_Size[start_row, i] = Convert.ToSingle(sum_qty - sum_balance);


					// balance 불일치 표시
					if(fgrid_Size[start_row, i] == null || fgrid_Size[start_row, i].ToString().Trim().Equals("") )
					{
						fgrid_Size[start_row, i] = "0";
					}

					if(fgrid_Size[start_row - 1, i] == null || fgrid_Size[start_row - 1, i].ToString().Trim().Equals("") )
					{
						fgrid_Size[start_row - 1, i] = "0";
					}


					//if(Convert.ToInt32(fgrid_Size[start_row, i].ToString() ) != Convert.ToInt32(fgrid_Size[start_row - 1, i].ToString() ) )
					if(Convert.ToInt32(fgrid_Size[start_row, i].ToString() ) != 0)
					{

						CellRange cr = fgrid_Size.GetCellRange(start_row, i); 
						cr.StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
						//cr.StyleNew.Font = new Font("Verdana", 7, FontStyle.Bold);

						_Count_UnBalance_Qty++;

					}
					else
					{
						CellRange cr = fgrid_Size.GetCellRange(start_row, i);  
						cr.StyleNew.ForeColor = Color.Black;
					}


					// balance 초기화
					sum_balance = 0;
					sum_qty = 0;

				
				} // end for j



			} // end for i



			// 행 balance  
			for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
			{
				
 
				node = fgrid_Size.Rows[i].Node;

				if(node.Level != _Level_Day) continue;

				for(int j = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxCS_SIZE_START; j < fgrid_Size.Cols.Count; j++)
				{

					if(fgrid_Size[i, j] == null || fgrid_Size[i, j].ToString().Trim().Equals("") ) continue;

					sum_balance += Convert.ToInt32( fgrid_Size[i, j].ToString() );

				} // end for j


				fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxSUM_QTY + 1] = sum_balance.ToString();


				// balance 불일치 표시
				if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxSUM_QTY + 1] == null || fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxSUM_QTY + 1].ToString().Trim().Equals("") )
				{
					fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxSUM_QTY + 1] = "0";
				}

				if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTOT_QTY + 1] == null || fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTOT_QTY + 1].ToString().Trim().Equals("") )
				{
					fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTOT_QTY + 1] = "0";
				}


				if(Convert.ToInt32(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxSUM_QTY + 1].ToString() ) 
					!= Convert.ToInt32(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTOT_QTY + 1].ToString() ) )
				{

					CellRange cr = fgrid_Size.GetCellRange(i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxSUM_QTY + 1); 
					cr.StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 
					//cr.StyleNew.Font = new Font("Verdana", 7, FontStyle.Bold);

				}
				else
				{
					CellRange cr = fgrid_Size.GetCellRange(i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxSUM_QTY + 1); 
					cr.StyleNew.ForeColor = Color.Black;
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
			fgrid_Size.Rows.Count = fgrid_Size.Rows.Fixed;

		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{
 
			Display_LOT_SIZE(); 
			Display_Size(fgrid_LOT.Rows.Fixed);

		}


		/// <summary>
		/// Event_Tbtn_Save : 
		/// </summary>
		private void Event_Tbtn_Save(bool arg_all_flag)
		{
 
			//행 수정 상태 해제
			fgrid_Size.Select(fgrid_Size.Selection.r1, 0, fgrid_Size.Selection.r1, fgrid_Size.Cols.Count-1, false);
 
		
			// 수정, 조회때마다 Balance 계산하여 정합성 맞지 않는 카운터 관리하므로 수량 정합성 체크 생략
			if(_Count_UnBalance_Qty != 0)
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
				ClassLib.ComFunction.User_Message("Exist quantity unbalance size.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}



			//bool save_flag = Update_SPO_LOT_DAILY_SIZE(arg_all_flag);
		
			bool save_flag = Update_SPO_LOT_DAILY_SIZE_All();

			if(! save_flag) 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this); 

				Display_LOT_DAILY_SIZE();  
				Display_Qty_Balance();
			}
				
			 


		}



		/// <summary>
		/// Event_Tbtn_Print : 
		/// </summary>
		private void Event_Tbtn_Print()
		{
 
			this.Cursor = Cursors.WaitCursor;

			

 

			if(fgrid_Size.Rows.Count < fgrid_Size.Rows.Fixed) return;

 
			string filename = Application.StartupPath + @"\Report\Production\" + this.Name + ".txt";
			string sDir = ClassLib.ComFunction.Set_RD_Directory(this.Name); 

			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null; 
			 

			fgrid_Size.ClipSeparators = "@ ";
			fgrid_Size.SaveGrid( filename, FileFormatEnum.TextCustom);
 
			string title = "Size to Time Sequence.";

			string para = "/rfn [" + filename + "] /rv V_LINE[" + txt_LineName.Text + "]V_MODEL[" + txt_Model.Text + "]V_STYLE[" + txt_StyleCd.Text + "] V_GENDER[" 
				+ txt_Gen.Text + "] V_LOT[" + txt_LOT.Text + "]";
			
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report(title, sDir, para);


			report.ShowDialog(); 
		

			this.Cursor = Cursors.Default;
			 


		}


		#endregion

		#region 그리드 이벤트 메서드


		/// <summary>
		/// Event_Click_fgrid_LOT : 
		/// </summary>
		private void Event_Click_fgrid_LOT()
		{

			if(fgrid_LOT.Rows.Count <= fgrid_LOT.Rows.Fixed) return;
				 
			Display_Size(fgrid_LOT.Selection.r1); 

		}


		/// <summary>
		/// Event_AfterEdit_fgrid_Size : 
		/// </summary>
		/// <param name="e"></param>
		private void Event_AfterEdit_fgrid_Size(C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			bool digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_Size[e.Row, e.Col].ToString());

			if(digit_flag == false) 
			{
				fgrid_Size[e.Row, e.Col] = _BeforeQty;
				return;
			}
			 

			Display_Qty_Balance();

			fgrid_Size[e.Row, 0] = "Y";


		}


		/// <summary>
		/// Event_Clickt_fgrid_Size : 
		/// </summary>
		/// <param name="e"></param>
		private void Event_Click_fgrid_Size()
		{

//			if(fgrid_Size.Rows[fgrid_Size.Selection.r1].Node.Level != _Level_Day) return;
//
//			string day_seq = fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxDAY_SEQ + 1].ToString();
//			string now_day_seq = "";
//
//			for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
//			{
//
//				if(fgrid_Size.Rows[i].Node.Level != _Level_Day) continue;
//
//				if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxDAY_SEQ + 1] == null
//					|| fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxDAY_SEQ + 1].ToString().Trim().Equals("") ) continue;
//
//				now_day_seq = fgrid_Size[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxDAY_SEQ + 1].ToString();
//
//				if(day_seq == now_day_seq)
//				{
//					fgrid_Size.Rows[i].StyleNew.BackColor = ClassLib.ComVar.GridHigh_Color;
//					fgrid_Size.Rows[i].StyleNew.ForeColor = ClassLib.ComVar.GridHighFore_Color;
//				}
//				else
//				{
//					fgrid_Size.Rows[i].StyleNew.BackColor = Color.Empty;
//					fgrid_Size.Rows[i].StyleNew.ForeColor = Color.Black;
//				}
//
//				
//
//
//			} // end for i

		}




		#endregion

		#region 버튼 및 기타 이벤트 메서드
 


		/// <summary>
		/// Event_Click_btn_SetReqPriority : 
		/// </summary>
		private void Event_Click_btn_SetReqPriority()
		{

			if(fgrid_LOT.Rows.Count <= fgrid_LOT.Rows.Fixed) return;


			string factory = cmb_Factory.SelectedValue.ToString();

			if(fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxLOT] == null) return;


			string[] lot = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxLOT].ToString().Split('-');
			string lot_no = lot[0];
			string lot_seq = lot[1];


			FlexAPS.ProdPlan.Pop_SetReqPriority pop_form = new FlexAPS.ProdPlan.Pop_SetReqPriority(factory, lot_no, lot_seq);
			pop_form.ShowDialog();

			if(! pop_form._CloseSave) return;


			// 재조회
			Display_LOT_DAILY_SIZE(); 
			Display_Qty_Balance();




		}



		/// <summary>
		/// Event_Click_btn_ShowDailyQty : 
		/// </summary>
		private void Event_Click_btn_ShowDailyQty()
		{

			if(fgrid_LOT.Rows.Count <= fgrid_LOT.Rows.Fixed) return;


			
			if(fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxLOT] == null) return;

			string factory = cmb_Factory.SelectedValue.ToString();
			string line_name = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxLINE_NAME].ToString();  
			string model_name = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxMODEL_NAME].ToString();  
			string style_cd = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxSTYLE_CD].ToString();  
			string gen = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN].ToString();  
			string obs_id =  fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxOBS_ID].ToString();
			string obs_type =  fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxOBS_TYPE].ToString();

			string[] lot = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxLOT].ToString().Split('-');
			string lot_no = lot[0];
			string lot_seq = lot[1]; 
			

			FlexAPS.ProdPlan.Pop_ShowDailyQuantity pop_form = new FlexAPS.ProdPlan.Pop_ShowDailyQuantity(factory, line_name, model_name, style_cd, gen, obs_id, obs_type, lot_no, lot_seq);
			pop_form.Show();
 


		}




		#endregion
 
		#region 컨텍스트 메뉴 이벤트


		/// <summary>
		/// Event_Click_menuItem_AssignSize : 배치된 사이즈 일자 제외하고 나머지 일자에 대해서 daily size 재전개
		/// </summary>
		private void Event_Click_menuItem_AssignSize(bool arg_all_flag)
		{

			 
			if(! _DirectlyMPS)
			{
				if(txt_LOT.Text == "")  return; 
			}

			
				
			this.Cursor = Cursors.WaitCursor;


 
			string factory = cmb_Factory.SelectedValue.ToString();
			string[] token = txt_LOT.Text.Trim().Split('-');
			string lot_no = token[0];
			string lot_seq = token[1];

			bool run_flag = Reset_SPO_LOT_DAILY_SIZE(arg_all_flag, factory, lot_no, lot_seq);



			this.Cursor = Cursors.Default;


			string proc_name = "sp_spo_assign_daily_size";
			string error_count = FlexAPS.ProdSheet.Form_PD_WorkSheet_Release.Check_Error(factory, proc_name);
			string today = System.DateTime.Now.ToString("yyyyMMdd");



			// 첫번째 오류 났으므로 두번째 오류 체크 불필요
			if(Convert.ToInt32(error_count) > 0)
			{ 
 
				COM.Com_Form.Form_Proc_Error check_error = new COM.Com_Form.Form_Proc_Error(true, today, proc_name, ClassLib.ComVar.CxErrorCheck_Error);
				check_error.ShowDialog();  
				return;
			}
			else
			{

				if(! run_flag) 
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					return; 
				}


				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);

				Display_LOT_DAILY_SIZE();
				Display_Qty_Balance();


			}

			
			


		}


 
		/// <summary>
		/// Event_Click_menuItem_Clear : 
		/// </summary>
		private void Event_Click_menuItem_Clear()
		{
 
			
			int[] sel_row = fgrid_Size.Selections;

			for(int i = 0; i < sel_row.Length; i++)
			{
				
				//finisn_yn = 'Y' 이면 제외
				if(fgrid_Size[sel_row[i], (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTS_FINISH_YN + 1] == null) continue;
				if(fgrid_Size[sel_row[i], (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTS_FINISH_YN + 1].ToString() != "N") continue;

				if(fgrid_Size.Rows[sel_row[i]].Node.Level != _Level_Day) continue;

				for(int j = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxCS_SIZE_START; j < fgrid_Size.Cols.Count; j++)
				{
					fgrid_Size[sel_row[i], j] = ""; 

				} // end for j

				fgrid_Size[sel_row[i], 0] = "Y"; 

			} // end for i



			Display_Qty_Balance();


		}


 

		private void Event_Click_menuItem_DisplayMold()
		{

//			if(_View_Mold)
//				_View_Mold = false;
//			else
//				_View_Mold = true;
//
//
//
//			if(_View_Mold)
//			{
//				for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
//				{
//					if(fgrid_Size[i, 0] == null || fgrid_Size[i, 0].ToString() != _ShortRowFlag) continue;
//					fgrid_Size.Rows[i].Visible = true; 
//				}
//			}
//			else
//			{
//				for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
//				{
//					if(fgrid_Size[i, 0] == null || fgrid_Size[i, 0].ToString() != _ShortRowFlag) continue;
//					fgrid_Size.Rows[i].Visible = false; 
//				}
//			}


		}


		private void Event_Click_menuItem_StyleMold()
		{

			if(fgrid_Size.Rows[fgrid_Size.Selection.r1].Node.Level != _Level_Day) return;

			//balance row
			if(fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxLOT_NO] == null
				|| fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxLOT_NO].ToString().Trim().Equals("") ) return;


			string factory = cmb_Factory.SelectedValue.ToString();
			string planymd = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text); 
			string dayseq = fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxDAY_SEQ + 1].ToString(); 
			string stylecd = txt_StyleCd.Text;
			string[] token = txt_LOT.Text.Split('-');
			string lotno = token[0];
			string lotseq = token[1]; 

			Form_PB_StyleMold pop_form = new Form_PB_StyleMold(factory, planymd, stylecd, lotno, lotseq, dayseq);
			pop_form.Show();


		}



		/// <summary>
		/// Event_Click_menuItem_ShowAllDay : 모든 일자 보여주기
		/// </summary>
		private void Event_Click_menuItem_ShowAllDays()
		{
			
			for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
			{
				fgrid_Size.Rows[i].Height = _GridRow_Height;
			} // end for i

		}



		/// <summary>
		/// Event_Click_menuItem_HideOneDay : 특정 일자 숨기기
		/// </summary>
		private void Event_Click_menuItem_HideOneDay()
		{
 


			int[] sel_row = fgrid_Size.Selections;

			for(int i = 0; i < sel_row.Length; i++)
			{
				 
				if(fgrid_Size.Rows[sel_row[i]].Node.Level != _Level_Day) continue;

				// balance row 제외
				if(fgrid_Size[sel_row[i], (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxLOT_NO] == null
					|| fgrid_Size[sel_row[i], (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxLOT_NO].ToString().Equals("") ) continue;
 
				_GridRow_Height = fgrid_Size.Rows[sel_row[i]].Height;

				fgrid_Size.Rows[sel_row[i]].Height = 0;

			} // end for i




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

				Event_Tbtn_Save(true); 
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

		private void fgrid_Size_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				if(fgrid_Size[e.Row, e.Col] == null)  fgrid_Size[e.Row, e.Col] = ""; 
				_BeforeQty = (fgrid_Size[e.Row, e.Col].ToString() == "") ? "0": fgrid_Size[e.Row, e.Col].ToString();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Size_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		}

		private void fgrid_Size_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			
			try
			{
				Event_AfterEdit_fgrid_Size(e);
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_AfterEdit_fgrid_Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		}


		private void fgrid_Size_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_fgrid_Size();
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_fgrid_Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


		private void Form_PO_LOTDailySize_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_PO_LOTDailySize_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ClassLib.ComVar.FormDailySize = null;
		}




		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				if(cmb_Factory.SelectedIndex == -1) return;

				// 초기화
				fgrid_LOT.Rows.Count = 2; 
				fgrid_Size.Rows.Count = fgrid_Size.Rows.Fixed;
 
				txt_LineName.Text = ""; 
				txt_Model.Text = ""; 
				txt_StyleCd.Text = ""; 
				txt_Gen.Text = ""; 
				txt_LOT.Text = ""; 


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
															(int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxGEN,
															(int)ClassLib.TBSPO_LOT_DAILY_SIZE_HEAD.IxCS_SIZE_START);



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}  

		private void cmb_LineCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1) return;

				Display_LOT_SIZE(); 
				Display_Size(fgrid_LOT.Rows.Fixed); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_LineCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
  
//				if(src.Equals(dpick_ToYMD))
//				{
					
					if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1) return;

					Display_LOT_SIZE(); 
					Display_Size(fgrid_LOT.Rows.Fixed); 
//				}
 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_FromYMD_CloseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					ClassLib.ComFunction.Set_Grid_Font_Size(fgrid_Size, Convert.ToSingle(txt_Font.Text));
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
				fgrid_Size.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) );

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void btn_SetMLine_Click(object sender, System.EventArgs e)
		{
			
			try
			{
				
				string factory = cmb_Factory.SelectedValue.ToString();
				string planymd = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
				string linecd = cmb_LineCd.SelectedValue.ToString(); 

				ClassLib.ComVar.Parameter_PopUp = new string[] {factory, planymd, linecd};
				ClassLib.ComVar.FormDailyMini = new Form_PO_LOTDailyMini(); 
				ClassLib.ComVar.FormClick_Flag = true;
				ClassLib.ComVar.FormDailyMini.ShowDialog();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_SetMLine_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}


		private void btn_SetReqPriority_Click(object sender, System.EventArgs e)
		{
		

			try
			{
				
				Event_Click_btn_SetReqPriority();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_SetReqPriority", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}


		private void btn_ShowDailyQty_Click(object sender, System.EventArgs e)
		{
		

			try
			{
				
				Event_Click_btn_ShowDailyQty();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_ShowDailyQty", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

	 



		#endregion 

		#region 컨텍스트 메뉴 이벤트


		
		private void menuItem_AssignSize_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_menuItem_AssignSize(false); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_AssignSize", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void menuItem_AssignSizeAll_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_menuItem_AssignSize(true);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_AssignSizeAll", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

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

		private void menuItem_DailySave_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Save(false); 	
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_DailySave", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
 

		}

		private void menuItem_DisplayMold_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_menuItem_DisplayMold(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_DisplayMold", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		} 

		private void menuItem_StyleMold_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_menuItem_StyleMold();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_StyleMold", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
 
		private void menuItem_ShowAllDays_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_menuItem_ShowAllDays();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_ShowAllDays", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void menuItem_HideOneDay_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_menuItem_HideOneDay();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_HideOneDay", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}





		#endregion 

		#endregion 

		#region 디비 연결


		#region 조회

		
		/// <summary>
		/// Select_SPO_LOT_SIZE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_fromymd"></param>
		/// <param name="arg_toymd"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_lot"></param>
		/// <returns></returns>
		private DataTable Select_SPO_LOT_SIZE(string arg_factory, string arg_fromymd, string arg_toymd, string arg_line_cd, string arg_lot)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPO_LOT_SIZE";

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
		/// Select_SPO_LOT_DAILY_SIZE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		/// <returns></returns>
		public static DataTable Select_SPO_LOT_DAILY_SIZE(string arg_factory, string arg_lotno, string arg_lotseq)
		{

			try
			{

				COM.OraDB myOraDB = new COM.OraDB();

				DataSet ds_ret;
				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPO_LOT_DAILY_SIZE";

				myOraDB.ReDim_Parameter(4); 
 
				//01.PROCEDURE명
				myOraDB.Process_Name = process_name;
 
				//02.ARGURMENT명
				myOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				myOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				myOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				myOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				//03.DATA TYPE
				myOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				myOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				myOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				myOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				//04.DATA 정의  
				myOraDB.Parameter_Values[0] = arg_factory;  
				myOraDB.Parameter_Values[1] = arg_lotno;
				myOraDB.Parameter_Values[2] = arg_lotseq; 
				myOraDB.Parameter_Values[3] = ""; 

				myOraDB.Add_Select_Parameter(true); 
				ds_ret = myOraDB.Exe_Select_Procedure();

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


		/// <summary>
		/// Reset_SPO_LOT_DAILY_SIZE :
		/// </summary>
		/// <param name="arg_all_flag"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		private bool Reset_SPO_LOT_DAILY_SIZE(bool arg_all_flag, string arg_factory, string arg_lot_no, string arg_lot_seq)
		{
			
			try
			{

				DataSet ds_ret; 
				int col_ct = 4;

				MyOraDB.ReDim_Parameter(col_ct);  

				//SP_SPO_Assign_Daily_Size(ARG_FACTORY, ARG_LOT_NO, ARG_LOT_SEQ, ARG_UPD_USER);

				if(arg_all_flag)  // daily size 재전개 - 모두 삭제하고 다시 재전개
				{
					MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.RESET_SPO_LOT_DAILY_SIZE_ALL";  
				}
				else // daily size 재전개 - 배치된 사이즈 일자 제외하고 나머지 일자에 대해서 daily size 재전개
				{
					MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.RESET_SPO_LOT_DAILY_SIZE"; 
				}
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";  
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";  
  
				for (int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}	 
				
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lot_no;
				MyOraDB.Parameter_Values[2] = arg_lot_seq; 
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User; 
  

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

		#region 저장


		/// <summary>
		/// Update_SPO_LOT_DAILY_SIZE : 
		/// </summary>
		/// <param name="arg_all_flag"></param>
		/// <returns></returns>
		public bool Update_SPO_LOT_DAILY_SIZE(bool arg_all_flag)
		{

			try
			{ 

				
				int col_ct = 10;  						 
				int row, col;
				string lot_no = "";
				string lot_seq = "";
				string day_seq = "";
				string req_no = "";
 



				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.UPDATE_SPO_LOT_DAILY_SIZE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[6] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[7] = "ARG_SIZE_QTY";
				MyOraDB.Parameter_Name[8] = "ARG_LOSS_QTY"; 
				MyOraDB.Parameter_Name[9] = "ARG_UPD_USER"; 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 



				string factory = cmb_Factory.SelectedValue.ToString();
				string[] token = txt_LOT.Text.Split('-');
				lot_no = token[0];
				lot_seq = token[1];



				int start_row = 0;
				int end_row = 0;

				if(arg_all_flag)
				{
					start_row = fgrid_Size.Rows.Fixed;
					end_row = fgrid_Size.Rows.Count - 1;
				}
				else
				{
					start_row = fgrid_Size.Selection.r1;
					end_row = fgrid_Size.Selection.r1;
				}


				for(row = start_row; row <= end_row; row++)
				{

					if(fgrid_Size[row, 0] == null || fgrid_Size[row, 0].ToString() != "Y") continue; 
 
					day_seq = fgrid_Size[row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxDAY_SEQ + 1].ToString();
					req_no = fgrid_Size[row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxREQ_NO + 1].ToString();
					

					vList.Add("D"); 
					vList.Add(factory); 
					vList.Add(lot_no); 
					vList.Add(lot_seq);  
					vList.Add(day_seq);
					vList.Add(req_no);
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(ClassLib.ComVar.This_User); 
  

					for(col = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxCS_SIZE_START; col < fgrid_Size.Cols.Count; col++)
					{  
						if(fgrid_Size[row, col] == null || fgrid_Size[row, col].ToString() == "") continue;
						
						vList.Add("I"); 
						vList.Add(factory); 
						vList.Add(lot_no); 
						vList.Add(lot_seq);  
						vList.Add(day_seq); 
						vList.Add(req_no);
						vList.Add(fgrid_Size[2, col].ToString() );  //cs_size
						vList.Add(fgrid_Size[row, col].ToString() );  //size_qty
						vList.Add("0");  //loss_qty
						vList.Add(ClassLib.ComVar.This_User); 
  

					} // end for col 


					vList.Add("U"); 
					vList.Add(factory); 
					vList.Add(lot_no); 
					vList.Add(lot_seq);  
					vList.Add(day_seq);
					vList.Add(req_no);
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(ClassLib.ComVar.This_User); 

 
					 


				} // end for i
  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				return true;

			}
			catch(Exception ex)
			{ 
				MessageBox.Show(ex.ToString() );
				return false;
			} 

		}





		/// <summary>
		/// Update_SPO_LOT_DAILY_SIZE : 
		/// </summary>
		/// <param name="arg_all_flag"></param>
		/// <returns></returns>
		public bool Update_SPO_LOT_DAILY_SIZE_All()
		{

			try
			{ 

				
				int col_ct = 10;  						 
				int row, col;
				string lot_no = "";
				string lot_seq = "";
				string day_seq = "";
				string req_no = "";
 



				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.UPDATE_SPO_LOT_DAILY_SIZE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[6] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[7] = "ARG_SIZE_QTY";
				MyOraDB.Parameter_Name[8] = "ARG_LOSS_QTY"; 
				MyOraDB.Parameter_Name[9] = "ARG_UPD_USER"; 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 



				string factory = cmb_Factory.SelectedValue.ToString();
				string[] token = txt_LOT.Text.Split('-');
				lot_no = token[0];
				lot_seq = token[1];



				int start_row = 0;
				int end_row = 0;

				
				start_row = fgrid_Size.Rows.Fixed;
				end_row = fgrid_Size.Rows.Count - 1;
				


				for(row = start_row; row <= end_row; row++)
				{

					if(fgrid_Size[row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTS_FINISH_YN] == null
						|| fgrid_Size[row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxTS_FINISH_YN].ToString().Trim() == "Y") continue;



					day_seq = fgrid_Size[row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxDAY_SEQ + 1].ToString();

					if(Convert.ToInt32(day_seq) < 0) continue;



					req_no = fgrid_Size[row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxREQ_NO + 1].ToString();
					

					vList.Add("D"); 
					vList.Add(factory); 
					vList.Add(lot_no); 
					vList.Add(lot_seq);  
					vList.Add(day_seq);
					vList.Add(req_no);
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(ClassLib.ComVar.This_User); 
  

					for(col = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_BSC.IxCS_SIZE_START; col < fgrid_Size.Cols.Count; col++)
					{  
						if(fgrid_Size[row, col] == null || fgrid_Size[row, col].ToString() == "") continue;
						
						vList.Add("I"); 
						vList.Add(factory); 
						vList.Add(lot_no); 
						vList.Add(lot_seq);  
						vList.Add(day_seq); 
						vList.Add(req_no);
						vList.Add(fgrid_Size[2, col].ToString() );  //cs_size
						vList.Add(fgrid_Size[row, col].ToString() );  //size_qty
						vList.Add("0");  //loss_qty
						vList.Add(ClassLib.ComVar.This_User); 
  

					} // end for col 


					vList.Add("U"); 
					vList.Add(factory); 
					vList.Add(lot_no); 
					vList.Add(lot_seq);  
					vList.Add(day_seq);
					vList.Add("");
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(ClassLib.ComVar.This_User); 

 
					 


				} // end for i
  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				return true;

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

