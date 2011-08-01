using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdOrder
{
	public class Form_PO_Lot : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_Left;
		public System.Windows.Forms.Panel pnl_RightTop;
		private System.Windows.Forms.Panel pnl_RightBottom;
		public System.Windows.Forms.Panel pnl_LeftSearch;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_FromDate;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_StyleCd;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_ToDate;
		private System.Windows.Forms.Label lbl_Date;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private COM.FSP fgrid_Order;
		private System.Windows.Forms.Panel pnl_RightBody;
		private System.Windows.Forms.Label btn_Change;
		private System.Windows.Forms.Label btn_CreateVLot;
		private System.Windows.Forms.Label btn_Step3;
		public System.Windows.Forms.Panel pnl_RightSearch;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btn_Step2;
		private System.Windows.Forms.Label lbl_LotCount;
		private System.Windows.Forms.TextBox txt_LotCount;
		public System.Windows.Forms.PictureBox pictureBox57;
		public System.Windows.Forms.PictureBox pictureBox58;
		public System.Windows.Forms.PictureBox pictureBox59;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.PictureBox pictureBox60;
		public System.Windows.Forms.PictureBox pictureBox61;
		public System.Windows.Forms.PictureBox pictureBox62;
		public System.Windows.Forms.PictureBox pictureBox63;
		public System.Windows.Forms.PictureBox pictureBox64;
		private COM.FSP fgrid_Lot;
		private COM.FSP fgrid_Recv_Lot;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.ContextMenu cmenu_Order;
		private System.Windows.Forms.MenuItem menuItem_Relation;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem_OA;
		private System.Windows.Forms.ContextMenu cmenu_DLotDayily;
		private System.Windows.Forms.MenuItem menuItem_DLotDayily;
		private System.Windows.Forms.MenuItem menuItem_ChangeLot;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuitem_LOTSize;
		private System.Windows.Forms.MenuItem menuItem_Relation1;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.RadioButton rad_OneOne;
		private System.Windows.Forms.RadioButton rad_Transfer;
		private System.Windows.Forms.RadioButton rad_Partition;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자

		public Form_PO_Lot()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_Lot));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_RightBottom = new System.Windows.Forms.Panel();
			this.pnl_RightBody = new System.Windows.Forms.Panel();
			this.fgrid_Lot = new COM.FSP();
			this.cmenu_DLotDayily = new System.Windows.Forms.ContextMenu();
			this.menuItem_DLotDayily = new System.Windows.Forms.MenuItem();
			this.menuItem_ChangeLot = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuitem_LOTSize = new System.Windows.Forms.MenuItem();
			this.menuItem_Relation1 = new System.Windows.Forms.MenuItem();
			this.btn_Change = new System.Windows.Forms.Label();
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.btn_CreateVLot = new System.Windows.Forms.Label();
			this.btn_Step3 = new System.Windows.Forms.Label();
			this.pnl_RightTop = new System.Windows.Forms.Panel();
			this.fgrid_Recv_Lot = new COM.FSP();
			this.pnl_RightSearch = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rad_OneOne = new System.Windows.Forms.RadioButton();
			this.rad_Transfer = new System.Windows.Forms.RadioButton();
			this.rad_Partition = new System.Windows.Forms.RadioButton();
			this.btn_Step2 = new System.Windows.Forms.Label();
			this.lbl_LotCount = new System.Windows.Forms.Label();
			this.txt_LotCount = new System.Windows.Forms.TextBox();
			this.pictureBox57 = new System.Windows.Forms.PictureBox();
			this.pictureBox58 = new System.Windows.Forms.PictureBox();
			this.pictureBox59 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.pictureBox60 = new System.Windows.Forms.PictureBox();
			this.pictureBox61 = new System.Windows.Forms.PictureBox();
			this.pictureBox62 = new System.Windows.Forms.PictureBox();
			this.pictureBox63 = new System.Windows.Forms.PictureBox();
			this.pictureBox64 = new System.Windows.Forms.PictureBox();
			this.pnl_Left = new System.Windows.Forms.Panel();
			this.fgrid_Order = new COM.FSP();
			this.cmenu_Order = new System.Windows.Forms.ContextMenu();
			this.menuItem_Relation = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem_OA = new System.Windows.Forms.MenuItem();
			this.pnl_LeftSearch = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.cmb_FromDate = new C1.Win.C1List.C1Combo();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_StyleCd = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_ToDate = new C1.Win.C1List.C1Combo();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_RightBottom.SuspendLayout();
			this.pnl_RightBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Lot)).BeginInit();
			this.pnl_RightTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Recv_Lot)).BeginInit();
			this.pnl_RightSearch.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnl_Left.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Order)).BeginInit();
			this.pnl_LeftSearch.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_FromDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ToDate)).BeginInit();
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
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.SystemColors.Window;
			this.c1Sizer1.Controls.Add(this.pnl_RightBottom);
			this.c1Sizer1.Controls.Add(this.pnl_RightTop);
			this.c1Sizer1.Controls.Add(this.pnl_Left);
			this.c1Sizer1.GridDefinition = "39.4097222222222:True:True;58.5069444444444:False:False;\t49.4094488188976:True:Fa" +
				"lse;49.4094488188976:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_RightBottom
			// 
			this.pnl_RightBottom.Controls.Add(this.pnl_RightBody);
			this.pnl_RightBottom.Location = new System.Drawing.Point(510, 235);
			this.pnl_RightBottom.Name = "pnl_RightBottom";
			this.pnl_RightBottom.Size = new System.Drawing.Size(502, 337);
			this.pnl_RightBottom.TabIndex = 2;
			// 
			// pnl_RightBody
			// 
			this.pnl_RightBody.Controls.Add(this.fgrid_Lot);
			this.pnl_RightBody.Controls.Add(this.btn_Change);
			this.pnl_RightBody.Controls.Add(this.btn_Cancel);
			this.pnl_RightBody.Controls.Add(this.btn_CreateVLot);
			this.pnl_RightBody.Controls.Add(this.btn_Step3);
			this.pnl_RightBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_RightBody.Location = new System.Drawing.Point(0, 0);
			this.pnl_RightBody.Name = "pnl_RightBody";
			this.pnl_RightBody.Size = new System.Drawing.Size(502, 337);
			this.pnl_RightBody.TabIndex = 51;
			// 
			// fgrid_Lot
			// 
			this.fgrid_Lot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Lot.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Lot.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Lot.ContextMenu = this.cmenu_DLotDayily;
			this.fgrid_Lot.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Lot.Location = new System.Drawing.Point(0, 25);
			this.fgrid_Lot.Name = "fgrid_Lot";
			this.fgrid_Lot.Size = new System.Drawing.Size(504, 313);
			this.fgrid_Lot.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Lot.TabIndex = 125;
			this.fgrid_Lot.EnterCell += new System.EventHandler(this.fgrid_Lot_EnterCell);
			this.fgrid_Lot.Click += new System.EventHandler(this.fgrid_Lot_Click);
			this.fgrid_Lot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_Lot_MouseDown);
			this.fgrid_Lot.DoubleClick += new System.EventHandler(this.fgrid_Lot_DoubleClick);
			this.fgrid_Lot.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Lot_AfterEdit);
			// 
			// cmenu_DLotDayily
			// 
			this.cmenu_DLotDayily.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							 this.menuItem_DLotDayily,
																							 this.menuItem_ChangeLot,
																							 this.menuItem2,
																							 this.menuitem_LOTSize,
																							 this.menuItem_Relation1});
			// 
			// menuItem_DLotDayily
			// 
			this.menuItem_DLotDayily.Index = 0;
			this.menuItem_DLotDayily.Text = "Direct Assign to MPS";
			this.menuItem_DLotDayily.Click += new System.EventHandler(this.menuItem_DLotDayily_Click);
			// 
			// menuItem_ChangeLot
			// 
			this.menuItem_ChangeLot.Index = 1;
			this.menuItem_ChangeLot.Text = "Change LOT";
			this.menuItem_ChangeLot.Click += new System.EventHandler(this.menuItem_ChangeLot_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 2;
			this.menuItem2.Text = "-";
			// 
			// menuitem_LOTSize
			// 
			this.menuitem_LOTSize.Index = 3;
			this.menuitem_LOTSize.Text = "Display LOT Size";
			this.menuitem_LOTSize.Click += new System.EventHandler(this.menuitem_LOTSize_Click);
			// 
			// menuItem_Relation1
			// 
			this.menuItem_Relation1.Index = 4;
			this.menuItem_Relation1.Text = "Display Relation";
			this.menuItem_Relation1.Click += new System.EventHandler(this.menuItem_Relation1_Click);
			// 
			// btn_Change
			// 
			this.btn_Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Change.ImageIndex = 0;
			this.btn_Change.ImageList = this.img_LongButton;
			this.btn_Change.Location = new System.Drawing.Point(293, 0);
			this.btn_Change.Name = "btn_Change";
			this.btn_Change.TabIndex = 124;
			this.btn_Change.Text = "V.LOT→R.LOT";
			this.btn_Change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
			this.btn_Change.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Change.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Change.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Change.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_LongButton;
			this.btn_Cancel.Location = new System.Drawing.Point(192, 0);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.TabIndex = 123;
			this.btn_Cancel.Text = "Cancel LOT";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_CreateVLot
			// 
			this.btn_CreateVLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_CreateVLot.ImageIndex = 0;
			this.btn_CreateVLot.ImageList = this.img_LongButton;
			this.btn_CreateVLot.Location = new System.Drawing.Point(394, 0);
			this.btn_CreateVLot.Name = "btn_CreateVLot";
			this.btn_CreateVLot.TabIndex = 122;
			this.btn_CreateVLot.Text = "Create V.LOT";
			this.btn_CreateVLot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_CreateVLot.Click += new System.EventHandler(this.btn_CreateVLot_Click);
			this.btn_CreateVLot.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_CreateVLot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_CreateVLot.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_CreateVLot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Step3
			// 
			this.btn_Step3.ImageIndex = 0;
			this.btn_Step3.ImageList = this.img_LongButton;
			this.btn_Step3.Location = new System.Drawing.Point(2, 0);
			this.btn_Step3.Name = "btn_Step3";
			this.btn_Step3.Size = new System.Drawing.Size(112, 23);
			this.btn_Step3.TabIndex = 118;
			this.btn_Step3.Text = "Create R.LOT";
			this.btn_Step3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Step3.Click += new System.EventHandler(this.btn_Step3_Click);
			this.btn_Step3.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Step3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Step3.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Step3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// pnl_RightTop
			// 
			this.pnl_RightTop.Controls.Add(this.fgrid_Recv_Lot);
			this.pnl_RightTop.Controls.Add(this.pnl_RightSearch);
			this.pnl_RightTop.Location = new System.Drawing.Point(510, 4);
			this.pnl_RightTop.Name = "pnl_RightTop";
			this.pnl_RightTop.Size = new System.Drawing.Size(502, 227);
			this.pnl_RightTop.TabIndex = 1;
			// 
			// fgrid_Recv_Lot
			// 
			this.fgrid_Recv_Lot.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Recv_Lot.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Recv_Lot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Recv_Lot.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Recv_Lot.Location = new System.Drawing.Point(0, 112);
			this.fgrid_Recv_Lot.Name = "fgrid_Recv_Lot";
			this.fgrid_Recv_Lot.Size = new System.Drawing.Size(502, 115);
			this.fgrid_Recv_Lot.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Recv_Lot.TabIndex = 49;
			this.fgrid_Recv_Lot.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Recv_Lot_BeforeEdit);
			this.fgrid_Recv_Lot.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Recv_Lot_AfterEdit);
			// 
			// pnl_RightSearch
			// 
			this.pnl_RightSearch.Controls.Add(this.panel1);
			this.pnl_RightSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_RightSearch.DockPadding.Bottom = 5;
			this.pnl_RightSearch.Location = new System.Drawing.Point(0, 0);
			this.pnl_RightSearch.Name = "pnl_RightSearch";
			this.pnl_RightSearch.Size = new System.Drawing.Size(502, 112);
			this.pnl_RightSearch.TabIndex = 48;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.rad_OneOne);
			this.panel1.Controls.Add(this.rad_Transfer);
			this.panel1.Controls.Add(this.rad_Partition);
			this.panel1.Controls.Add(this.btn_Step2);
			this.panel1.Controls.Add(this.lbl_LotCount);
			this.panel1.Controls.Add(this.txt_LotCount);
			this.panel1.Controls.Add(this.pictureBox57);
			this.panel1.Controls.Add(this.pictureBox58);
			this.panel1.Controls.Add(this.pictureBox59);
			this.panel1.Controls.Add(this.lbl_SubTitle2);
			this.panel1.Controls.Add(this.pictureBox60);
			this.panel1.Controls.Add(this.pictureBox61);
			this.panel1.Controls.Add(this.pictureBox62);
			this.panel1.Controls.Add(this.pictureBox63);
			this.panel1.Controls.Add(this.pictureBox64);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(502, 107);
			this.panel1.TabIndex = 20;
			// 
			// rad_OneOne
			// 
			this.rad_OneOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_OneOne.Location = new System.Drawing.Point(9, 32);
			this.rad_OneOne.Name = "rad_OneOne";
			this.rad_OneOne.Size = new System.Drawing.Size(150, 21);
			this.rad_OneOne.TabIndex = 29;
			this.rad_OneOne.Text = "Order (1) : LOT (1)";
			this.rad_OneOne.CheckedChanged += new System.EventHandler(this.rad_OneOne_CheckedChanged);
			// 
			// rad_Transfer
			// 
			this.rad_Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Transfer.Location = new System.Drawing.Point(9, 53);
			this.rad_Transfer.Name = "rad_Transfer";
			this.rad_Transfer.Size = new System.Drawing.Size(150, 21);
			this.rad_Transfer.TabIndex = 30;
			this.rad_Transfer.Text = "Order (N) : LOT (1)";
			// 
			// rad_Partition
			// 
			this.rad_Partition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Partition.Location = new System.Drawing.Point(184, 80);
			this.rad_Partition.Name = "rad_Partition";
			this.rad_Partition.Size = new System.Drawing.Size(150, 21);
			this.rad_Partition.TabIndex = 31;
			this.rad_Partition.Text = "Order (1) : LOT (N)";
			this.rad_Partition.Visible = false;
			this.rad_Partition.CheckedChanged += new System.EventHandler(this.rad_Partition_CheckedChanged);
			// 
			// btn_Step2
			// 
			this.btn_Step2.ImageIndex = 0;
			this.btn_Step2.ImageList = this.img_LongButton;
			this.btn_Step2.Location = new System.Drawing.Point(2, 78);
			this.btn_Step2.Name = "btn_Step2";
			this.btn_Step2.Size = new System.Drawing.Size(112, 23);
			this.btn_Step2.TabIndex = 117;
			this.btn_Step2.Text = "Collecting Order";
			this.btn_Step2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Step2.Click += new System.EventHandler(this.btn_Step2_Click);
			this.btn_Step2.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Step2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Step2.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Step2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// lbl_LotCount
			// 
			this.lbl_LotCount.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_LotCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LotCount.ImageIndex = 0;
			this.lbl_LotCount.ImageList = this.img_Label;
			this.lbl_LotCount.Location = new System.Drawing.Point(336, 80);
			this.lbl_LotCount.Name = "lbl_LotCount";
			this.lbl_LotCount.Size = new System.Drawing.Size(100, 21);
			this.lbl_LotCount.TabIndex = 116;
			this.lbl_LotCount.Text = "Divide Qty.";
			this.lbl_LotCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_LotCount.Visible = false;
			// 
			// txt_LotCount
			// 
			this.txt_LotCount.BackColor = System.Drawing.Color.White;
			this.txt_LotCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LotCount.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LotCount.Location = new System.Drawing.Point(437, 80);
			this.txt_LotCount.MaxLength = 20;
			this.txt_LotCount.Name = "txt_LotCount";
			this.txt_LotCount.Size = new System.Drawing.Size(56, 21);
			this.txt_LotCount.TabIndex = 115;
			this.txt_LotCount.Text = "";
			this.txt_LotCount.Visible = false;
			this.txt_LotCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_LotCount_KeyUp);
			// 
			// pictureBox57
			// 
			this.pictureBox57.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox57.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox57.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox57.Image")));
			this.pictureBox57.Location = new System.Drawing.Point(487, 24);
			this.pictureBox57.Name = "pictureBox57";
			this.pictureBox57.Size = new System.Drawing.Size(15, 67);
			this.pictureBox57.TabIndex = 26;
			this.pictureBox57.TabStop = false;
			// 
			// pictureBox58
			// 
			this.pictureBox58.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox58.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox58.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox58.Image")));
			this.pictureBox58.Location = new System.Drawing.Point(486, 0);
			this.pictureBox58.Name = "pictureBox58";
			this.pictureBox58.Size = new System.Drawing.Size(16, 32);
			this.pictureBox58.TabIndex = 21;
			this.pictureBox58.TabStop = false;
			// 
			// pictureBox59
			// 
			this.pictureBox59.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox59.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox59.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox59.Image")));
			this.pictureBox59.Location = new System.Drawing.Point(216, 0);
			this.pictureBox59.Name = "pictureBox59";
			this.pictureBox59.Size = new System.Drawing.Size(504, 40);
			this.pictureBox59.TabIndex = 0;
			this.pictureBox59.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle2.TabIndex = 20;
			this.lbl_SubTitle2.Text = "      Create Option";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox60
			// 
			this.pictureBox60.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox60.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox60.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox60.Image")));
			this.pictureBox60.Location = new System.Drawing.Point(160, 24);
			this.pictureBox60.Name = "pictureBox60";
			this.pictureBox60.Size = new System.Drawing.Size(502, 67);
			this.pictureBox60.TabIndex = 27;
			this.pictureBox60.TabStop = false;
			// 
			// pictureBox61
			// 
			this.pictureBox61.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox61.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox61.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox61.Image")));
			this.pictureBox61.Location = new System.Drawing.Point(486, 91);
			this.pictureBox61.Name = "pictureBox61";
			this.pictureBox61.Size = new System.Drawing.Size(16, 16);
			this.pictureBox61.TabIndex = 23;
			this.pictureBox61.TabStop = false;
			// 
			// pictureBox62
			// 
			this.pictureBox62.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox62.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox62.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox62.Image")));
			this.pictureBox62.Location = new System.Drawing.Point(144, 89);
			this.pictureBox62.Name = "pictureBox62";
			this.pictureBox62.Size = new System.Drawing.Size(502, 18);
			this.pictureBox62.TabIndex = 24;
			this.pictureBox62.TabStop = false;
			// 
			// pictureBox63
			// 
			this.pictureBox63.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox63.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox63.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox63.Image")));
			this.pictureBox63.Location = new System.Drawing.Point(0, 87);
			this.pictureBox63.Name = "pictureBox63";
			this.pictureBox63.Size = new System.Drawing.Size(168, 20);
			this.pictureBox63.TabIndex = 22;
			this.pictureBox63.TabStop = false;
			// 
			// pictureBox64
			// 
			this.pictureBox64.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox64.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox64.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox64.Image")));
			this.pictureBox64.Location = new System.Drawing.Point(0, 24);
			this.pictureBox64.Name = "pictureBox64";
			this.pictureBox64.Size = new System.Drawing.Size(168, 67);
			this.pictureBox64.TabIndex = 25;
			this.pictureBox64.TabStop = false;
			// 
			// pnl_Left
			// 
			this.pnl_Left.Controls.Add(this.fgrid_Order);
			this.pnl_Left.Controls.Add(this.pnl_LeftSearch);
			this.pnl_Left.Location = new System.Drawing.Point(4, 4);
			this.pnl_Left.Name = "pnl_Left";
			this.pnl_Left.Size = new System.Drawing.Size(502, 568);
			this.pnl_Left.TabIndex = 0;
			// 
			// fgrid_Order
			// 
			this.fgrid_Order.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Order.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Order.ContextMenu = this.cmenu_Order;
			this.fgrid_Order.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Order.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Order.Location = new System.Drawing.Point(0, 112);
			this.fgrid_Order.Name = "fgrid_Order";
			this.fgrid_Order.Size = new System.Drawing.Size(502, 456);
			this.fgrid_Order.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Order.TabIndex = 42;
			this.fgrid_Order.DoubleClick += new System.EventHandler(this.fgrid_Order_DoubleClick);
			this.fgrid_Order.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Order_AfterEdit);
			// 
			// cmenu_Order
			// 
			this.cmenu_Order.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuItem_Relation,
																						this.menuItem1,
																						this.menuItem_OA});
			// 
			// menuItem_Relation
			// 
			this.menuItem_Relation.Index = 0;
			this.menuItem_Relation.Text = "Display Relation";
			this.menuItem_Relation.Click += new System.EventHandler(this.menuItem_Relation_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Text = "-";
			this.menuItem1.Visible = false;
			// 
			// menuItem_OA
			// 
			this.menuItem_OA.Index = 2;
			this.menuItem_OA.Text = "Order Adjust";
			this.menuItem_OA.Visible = false;
			this.menuItem_OA.Click += new System.EventHandler(this.menuItem_OA_Click);
			// 
			// pnl_LeftSearch
			// 
			this.pnl_LeftSearch.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_LeftSearch.Controls.Add(this.pnl_SearchImage);
			this.pnl_LeftSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_LeftSearch.DockPadding.Bottom = 5;
			this.pnl_LeftSearch.Location = new System.Drawing.Point(0, 0);
			this.pnl_LeftSearch.Name = "pnl_LeftSearch";
			this.pnl_LeftSearch.Size = new System.Drawing.Size(502, 112);
			this.pnl_LeftSearch.TabIndex = 41;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.cmb_FromDate);
			this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.label1);
			this.pnl_SearchImage.Controls.Add(this.cmb_ToDate);
			this.pnl_SearchImage.Controls.Add(this.lbl_Date);
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(502, 107);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// cmb_FromDate
			// 
			this.cmb_FromDate.AddItemCols = 0;
			this.cmb_FromDate.AddItemSeparator = ';';
			this.cmb_FromDate.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_FromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_FromDate.Caption = "";
			this.cmb_FromDate.CaptionHeight = 17;
			this.cmb_FromDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_FromDate.ColumnCaptionHeight = 18;
			this.cmb_FromDate.ColumnFooterHeight = 18;
			this.cmb_FromDate.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_FromDate.ContentHeight = 17;
			this.cmb_FromDate.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_FromDate.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_FromDate.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_FromDate.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_FromDate.EditorHeight = 17;
			this.cmb_FromDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_FromDate.GapHeight = 2;
			this.cmb_FromDate.ItemHeight = 15;
			this.cmb_FromDate.Location = new System.Drawing.Point(111, 58);
			this.cmb_FromDate.MatchEntryTimeout = ((long)(2000));
			this.cmb_FromDate.MaxDropDownItems = ((short)(5));
			this.cmb_FromDate.MaxLength = 32767;
			this.cmb_FromDate.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_FromDate.Name = "cmb_FromDate";
			this.cmb_FromDate.PartialRightColumn = false;
			this.cmb_FromDate.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_FromDate.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_FromDate.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_FromDate.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_FromDate.Size = new System.Drawing.Size(97, 21);
			this.cmb_FromDate.TabIndex = 36;
			this.cmb_FromDate.SelectedValueChanged += new System.EventHandler(this.cmb_FromDate_SelectedValueChanged);
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.White;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(111, 80);
			this.txt_StyleCd.MaxLength = 20;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(210, 21);
			this.txt_StyleCd.TabIndex = 116;
			this.txt_StyleCd.Text = "";
			this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
			// 
			// lbl_StyleCd
			// 
			this.lbl_StyleCd.ImageIndex = 0;
			this.lbl_StyleCd.ImageList = this.img_Label;
			this.lbl_StyleCd.Location = new System.Drawing.Point(10, 80);
			this.lbl_StyleCd.Name = "lbl_StyleCd";
			this.lbl_StyleCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_StyleCd.TabIndex = 45;
			this.lbl_StyleCd.Text = "Style";
			this.lbl_StyleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(208, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 21);
			this.label1.TabIndex = 44;
			this.label1.Text = "~";
			// 
			// cmb_ToDate
			// 
			this.cmb_ToDate.AddItemCols = 0;
			this.cmb_ToDate.AddItemSeparator = ';';
			this.cmb_ToDate.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_ToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_ToDate.Caption = "";
			this.cmb_ToDate.CaptionHeight = 17;
			this.cmb_ToDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_ToDate.ColumnCaptionHeight = 18;
			this.cmb_ToDate.ColumnFooterHeight = 18;
			this.cmb_ToDate.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_ToDate.ContentHeight = 17;
			this.cmb_ToDate.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_ToDate.EditorBackColor = System.Drawing.Color.White;
			this.cmb_ToDate.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ToDate.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_ToDate.EditorHeight = 17;
			this.cmb_ToDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ToDate.GapHeight = 2;
			this.cmb_ToDate.ItemHeight = 15;
			this.cmb_ToDate.Location = new System.Drawing.Point(224, 58);
			this.cmb_ToDate.MatchEntryTimeout = ((long)(2000));
			this.cmb_ToDate.MaxDropDownItems = ((short)(5));
			this.cmb_ToDate.MaxLength = 32767;
			this.cmb_ToDate.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_ToDate.Name = "cmb_ToDate";
			this.cmb_ToDate.PartialRightColumn = false;
			this.cmb_ToDate.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_ToDate.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_ToDate.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_ToDate.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_ToDate.Size = new System.Drawing.Size(97, 21);
			this.cmb_ToDate.TabIndex = 43;
			this.cmb_ToDate.SelectedValueChanged += new System.EventHandler(this.cmb_ToDate_SelectedValueChanged);
			// 
			// lbl_Date
			// 
			this.lbl_Date.ImageIndex = 0;
			this.lbl_Date.ImageList = this.img_Label;
			this.lbl_Date.Location = new System.Drawing.Point(10, 58);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(100, 21);
			this.lbl_Date.TabIndex = 35;
			this.lbl_Date.Text = "DPO";
			this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Location = new System.Drawing.Point(111, 36);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_Factory.TabIndex = 33;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 32;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(487, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 67);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(486, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(16, 32);
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
			this.picb_TM.Size = new System.Drawing.Size(278, 32);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
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
			this.lbl_SubTitle1.Text = "      Received Order";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(486, 91);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 89);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(342, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 87);
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
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 67);
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
			this.picb_MM.Size = new System.Drawing.Size(334, 67);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// Form_PO_Lot
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_PO_Lot";
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_RightBottom.ResumeLayout(false);
			this.pnl_RightBody.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Lot)).EndInit();
			this.pnl_RightTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Recv_Lot)).EndInit();
			this.pnl_RightSearch.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.pnl_Left.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Order)).EndInit();
			this.pnl_LeftSearch.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_FromDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ToDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
 
		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 

		//lot qty 변경 후 remain qty에 반영하기 위해서 변경 전 값 기억
		private string _BeforeLotQty;

		//size 입력하기 위해서 데이터테이블 구성해서 저장 대상 넘김
		private DataTable _SizeDT = new DataTable("SizeSaveData");


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
				this.Text = "Create LOT";
				this.lbl_MainTitle.Text = "Create LOT"; 

				//ClassLib.ComFunction.SetLangDic(this);
 


				fgrid_Order.Set_Grid("SPO_RECV", "4", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false); 
				fgrid_Order.Styles.Alternate.BackColor = Color.White; 
				fgrid_Order.Font = new Font("Verdana", 7);

				fgrid_Recv_Lot.Set_Grid("SPO_RECV_LOT", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, true); 
				fgrid_Recv_Lot.Font = new Font("Verdana", 7);

				fgrid_Lot.Set_Grid("SPO_LOT", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, true); 
				fgrid_Lot.Set_Action_Image(img_Action);  
				fgrid_Lot.Font = new Font("Verdana", 7);



				Init_Control(); 

				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
 
		}


		private void Init_Control()
		{

			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_Print.Enabled = false; 
 
			//-----------------------------------------------------------------
			//size 입력하기 위해서 데이터테이블 구성해서 저장 대상 넘김
			for(int i = (int)ClassLib.TBSPO_RECV_LOT.IxFACTORY; i <= (int)ClassLib.TBSPO_RECV_LOT.IxLOT_LOSS_QTY; i++) 
				_SizeDT.Columns.Add(new DataColumn(i.ToString(), typeof(string))); 
			//-----------------------------------------------------------------



			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			dt_ret.Dispose();
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;   
			
			
			rad_OneOne.Checked = true; 


		}


		#endregion

		#region 툴바 이벤트 메서드
		

		private void Event_Tbtn_New()
		{
			//cmb_Factory.SelectedIndex = -1;
			//cmb_FromDate.SelectedIndex = -1;
			//cmb_ToDate.SelectedIndex = -1; 
			txt_StyleCd.Text = "";

			fgrid_Order.Rows.Count = fgrid_Order.Rows.Fixed; 

			fgrid_Recv_Lot.Select(fgrid_Recv_Lot.Selection.r1, 0, fgrid_Recv_Lot.Selection.r1, fgrid_Recv_Lot.Selection.c1, false);
			fgrid_Recv_Lot.Rows.Count = fgrid_Recv_Lot.Rows.Fixed; 

			fgrid_Lot.Select(fgrid_Lot.Selection.r1, 0, fgrid_Lot.Selection.r1, fgrid_Lot.Selection.c1, false);
			fgrid_Lot.Rows.Count = fgrid_Lot.Rows.Fixed;

			rad_OneOne.Checked = false; 
		}

		private void Event_Tbtn_Search()
		{


			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_FromDate};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

			if(! essential_check) return;

			string factory = cmb_Factory.SelectedValue.ToString();
			string dpo_from = cmb_FromDate.SelectedValue.ToString();
			string dpo_to = ClassLib.ComFunction.Empty_Combo(cmb_ToDate, cmb_FromDate.SelectedValue.ToString() );
			string style_cd = ClassLib.ComFunction.Empty_String(txt_StyleCd.Text.Replace("-", ""), " ");

			
			DataSet ds_ret = Select_SPO_RECV_AND_LOT(factory, dpo_from, dpo_to, style_cd);
			DataTable dt_recv = ds_ret.Tables[0];
			DataTable dt_lot = ds_ret.Tables[1];

			fgrid_Order.Display_Grid(dt_recv, false);
			Display_Grid_Property_Order();

			fgrid_Lot.Display_Grid(dt_lot, true);
			Display_Grid_Property_LOT();

			fgrid_Recv_Lot.Rows.Count = fgrid_Recv_Lot.Rows.Fixed;

		}


		/// <summary>
		/// Display_Grid_Property_Order : 
		/// </summary>
		private void Display_Grid_Property_Order()
		{


			for(int i = fgrid_Order.Rows.Fixed; i < fgrid_Order.Rows.Count; i++)
			{

				//				if(Convert.ToBoolean(fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_DIV]) )
				//				{

				//lot_remainqty <= 0 이면 수정불가
				if(Convert.ToInt32(fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY].ToString()) <= 0
					&& Convert.ToInt32(fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_LOSS_REMAINQTY].ToString()) <= 0 )
				{
					fgrid_Order.Rows[i].StyleNew.BackColor = ClassLib.ComVar.ClrDarkSel;
					fgrid_Order.Rows[i].AllowEditing = false;

					//minus  수량 경고 표시
					if(Convert.ToInt32(fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY].ToString()) < 0
						&& Convert.ToInt32(fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_LOSS_REMAINQTY].ToString()) < 0 )
					{
						fgrid_Order.Rows[i].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
					}
				}
				else
				{
					fgrid_Order.Rows[i].StyleNew.BackColor = ClassLib.ComVar.ClrLightSel;
					fgrid_Order.Rows[i].AllowEditing = true;
				}

				//				} // end if(lot_div check == true)

 

				//OA 상태 표시 -> OA Number 있고
				if(fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxOA_NU].ToString() != "__________")
				{
					// PLAN_OAAPP_DIV = "R"인 경우
					if(fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxPLAN_OAAPP_DIV].ToString() == "R")
					{
						fgrid_Order.Rows[i].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;  
						fgrid_Order.Rows[i].StyleNew.BackColor = ClassLib.ComVar.ClrOA; 
					}

				}


			} // end for i


			// merge
			fgrid_Order.AllowMerging = AllowMergingEnum.Free;
			for(int i = 0; i < fgrid_Order.Cols.Count; i++) fgrid_Order.Cols[i].AllowMerging = false;
			fgrid_Order.Cols[(int)ClassLib.TBSPO_RECV_CHECK.IxMODEL_NAME].AllowMerging = true;
			fgrid_Order.Cols[(int)ClassLib.TBSPO_RECV_CHECK.IxSTYLE_CD].AllowMerging = true;

			// subtotal
			fgrid_Order.Tree.Column = (int)ClassLib.TBSPO_RECV_CHECK.IxMODEL_NAME;
			fgrid_Order.Subtotal(AggregateEnum.Clear);  
			fgrid_Order.SubtotalPosition = SubtotalPositionEnum.AboveData;  
			fgrid_Order.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
			fgrid_Order.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black; 
			fgrid_Order.Styles[CellStyleEnum.Subtotal2].BackColor = ClassLib.ComVar.ClrSubTotal2;
			fgrid_Order.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Black;
 
			fgrid_Order.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSPO_RECV_CHECK.IxSTYLE_CD, (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_QTY, " {0}"); 
			fgrid_Order.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPO_RECV_CHECK.IxMODEL_NAME, (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_QTY, "{0}");
			fgrid_Order.Subtotal(AggregateEnum.Sum, 0, -1, (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_QTY, "Total"); 


			fgrid_Order.AutoSizeCols((int)ClassLib.TBSPO_RECV_CHECK.IxMODEL_NAME + 1, fgrid_Order.Cols.Count - 1, 1);


		}


		/// <summary>
		/// 
		/// </summary>
		private void Display_Grid_Property_LOT()
		{

			for(int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
			{

				//OA 상태 표시 -> PLAN_OAAPP_DIV = "R"인 경우
				if(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxPLAN_OAAPP_DIV].ToString() == "R")
				{
					fgrid_Lot.Rows[i].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;  
					fgrid_Lot.Rows[i].StyleNew.BackColor = ClassLib.ComVar.ClrOA; 
				}


				//가상 LOT 표시
				if(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxREAL_LOTYN].ToString() == "N")
				{ 
					fgrid_Lot.Rows[i].StyleNew.BackColor = ClassLib.ComVar.ClrVirtualLOT;
				}

				//BOM 코드 세팅 여부 표시
				if(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxBOM_CD].ToString() == "__________")
				{
					fgrid_Lot.GetCellRange(i, (int)ClassLib.TBSPO_LOT.IxBOM_CD).StyleNew.BackColor = ClassLib.ComVar.ClrWarning_Back;
				}

				
			}


			//edit 가능한 컬럼 표시
			fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxPO_NO].StyleNew.BackColor = Color.White;
			fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxBOM_CD].StyleNew.BackColor = Color.White;
			fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxROUT_TYPE].StyleNew.BackColor = Color.White;
			fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxLEADTIME_CD].StyleNew.BackColor = Color.White;
			fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxREMARKS].StyleNew.BackColor = Color.White;


			fgrid_Lot.AutoSizeCols();


		}



		private void Event_Tbtn_Save()
		{


			bool save_flag = false;
			bool equal_flag = true, error_flag = true;
			DataSet return_flag = null;
			
			int selrow = fgrid_Lot.Selection.r1; 


			fgrid_Lot.Select(selrow, 0, selrow, fgrid_Lot.Cols.Count - 1, false); 

			if(!Save_Check()) return;
			 
			if(rad_OneOne.Checked)
			{
				save_flag = Save_SPO_LOT_SIZE(); 

				if(!save_flag) 
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
					return;
				}
				else
				{
					save_flag = Save_Recv_Lot(false); 

					if(!save_flag) 
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
						return;
					}
					else
					{
						return_flag = MyOraDB.Exe_Modify_Procedure();

						if(return_flag == null)
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
							return;
						}
						else
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);	
							Event_Tbtn_Search();
						}
					}
				}

			} // end if(rad_OneOne.Checked)
			else if(rad_Transfer.Checked)
			{
				for(int i = fgrid_Recv_Lot.Rows.Fixed; i < fgrid_Recv_Lot.Rows.Count; i++)
				{
 
					if(Convert.ToBoolean(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG]) == false) continue;

					if(Convert.ToInt32(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxTOT_QTY].ToString()) 
						!= Convert.ToInt32(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_QTY].ToString()))
					{
						equal_flag = false;
					}
						

				} // end for i


				//사이즈 수량 일괄 처리
				if(equal_flag == true)
				{
					save_flag = Save_SPO_LOT_SIZE(); 

					if(!save_flag) 
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
						return;
					}
					else
					{
						save_flag = Save_Recv_Lot(false); 

						if(!save_flag) 
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);	 
							return;
						}
						else
						{
							return_flag = MyOraDB.Exe_Modify_Procedure();

							if(return_flag == null)
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
								return;
							}
							else
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
								Event_Tbtn_Search();
							}
						}
					}

				} // end if(equal_flag == true)
					//사이즈 입력 후 처리
				else
				{
					error_flag = Check_Lot_Size();

					if(error_flag)
					{ 
						//다시 사이즈 창 띄워서 수정하도록
						Show_LotSize();
					}
					else
					{
						save_flag = Save_Recv_Lot(true); 
						if(!save_flag) 
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
							return;
						}
						else
						{
							return_flag = MyOraDB.Exe_Modify_Procedure();

							if(return_flag == null)
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);	 
								return;
							}
							else
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);	
								Event_Tbtn_Search(); 
							}
						} // end if(!save_flag) 
					} // end if(error_flag)


				}


			}
			else if(rad_Partition.Checked)
			{
				error_flag = Check_Lot_Size();

				if(error_flag)
				{
					this.Cursor = Cursors.Default;
					//다시 사이즈 창 띄워서 수정하도록
					Show_LotSize();
				}
				else
				{
					save_flag = Save_Recv_Lot(true); 
					if(!save_flag) 
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
						return;
					}
					else
					{
						return_flag = MyOraDB.Exe_Modify_Procedure();

						if(return_flag == null)
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); 
							return;
						}
						else
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);	
							Event_Tbtn_Search();
						}
					} // end if(!save_flag) 
				} // end if(error_flag)
 
			} 
			
			fgrid_Lot.TopRow = selrow;



		}


		#region 저장

		/// <summary>
		/// Show_LotSize : 다시 사이즈 창 띄워서 수정하도록
		/// </summary>
		private void Show_LotSize()
		{ 
			//----------------------------------------------------
			//LOT 사이즈 입력
			//---------------------------------------------------- 
			for(int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
			{
				if(fgrid_Lot[i, 0].ToString() != "I") continue;
				if(! fgrid_Lot.Rows[i].Style.ForeColor.Equals(Color.Red)) continue;

				Update_LotSize(i);
 
			} // end for i
  
		} 

		

		/// <summary>
		/// Update_LotSize
		/// </summary>
		private void Update_LotSize(int arg_row)
		{
 
			Form_PO_Lot_Size pop_form = new Form_PO_Lot_Size();  
			DataTable dt_ret = Select_Lot_ReqNo(fgrid_Lot[arg_row, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString(), fgrid_Lot[arg_row, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString());
			pop_form._InsertFlag = false;
			pop_form._SizeDT = dt_ret; 
			pop_form.ShowDialog();  

			Event_Tbtn_Search();
			fgrid_Lot.TopRow = arg_row;

			_SizeDT.Rows.Clear();
			dt_ret.Dispose();
			

		}


		/// <summary>
		/// Select_Lot_ReqNo : 
		/// </summary>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		/// <returns></returns>
		private DataTable Select_Lot_ReqNo(string arg_lotno, string arg_lotseq)
		{

			DataSet ds_ret;
			string process_name = "PKG_SPO_LOT_BSC.SELECT_LOT_REQNO";

			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
			MyOraDB.Parameter_Values[1] = arg_lotno; 
			MyOraDB.Parameter_Values[2] = arg_lotseq;   
			MyOraDB.Parameter_Values[3] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
		
			return ds_ret.Tables[process_name]; 


		}


		/// <summary>
		/// Save_Check : 저장하기 전 필수항목 check
		/// </summary>
		/// <returns></returns>
		private bool Save_Check()
		{
			int count = 0;

			for(int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
			{
				//if(fgrid_Lot[i, 0].ToString() != "I" && fgrid_Lot[i, 0].ToString() != "U") continue;

				if(fgrid_Lot[i, 0] == null || fgrid_Lot[i, 0].ToString() == "") continue;

				//bom_cd
				if(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxBOM_CD].ToString().Trim() == "")
				{
					fgrid_Lot.GetCellRange(i, (int)ClassLib.TBSPO_LOT.IxBOM_CD).StyleNew.BackColor = ClassLib.ComVar.ClrWarning_Back;
					count++;
				}

//				//PO_NO
//				if(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxPO_NO].ToString().Trim() == "")
//				{
//					fgrid_Lot.GetCellRange(i, (int)ClassLib.TBSPO_LOT.IxPO_NO).StyleNew.BackColor = ClassLib.ComVar.ClrWarning_Back;
//					count++;
//				}

			} // end for i

			if(count > 0)
				return false;
			else
				return true;

		}


		/// <summary>
		/// Save_SPO_LOT_SIZE : 
		/// </summary>
		private bool Save_SPO_LOT_SIZE()
		{

			int col_ct = 6;
			int row_fixed = fgrid_Lot.Rows.Fixed;		// 그리드 고정행 값 

			int save_ct = 0;                            // 저장 행 수
			int para_ct =0;								// 파라미터 값의 저장 배열의 수

			string req_no = "";

			try
			{
 

				//---------------------------------------------------------------------------
 
				MyOraDB.ReDim_Parameter(3);
				MyOraDB.Process_Name = "PKG_SPO_LOT_BSC.DELETE_SPO_LOT_SIZE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				 

				// 파라미터의 데이터 Type
				for(int i = 0; i < 3 ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	 
	
				 
				// 저장 행 수 구하기
				for(int row = row_fixed; row < fgrid_Lot.Rows.Count; row++)
				{
					if(fgrid_Lot[row, 0].ToString() == "" || fgrid_Lot[row, 0].ToString() == "D") continue;

					save_ct += 1;
					 
				}

			
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[3 * save_ct];

 
				for(int row = row_fixed; row < fgrid_Lot.Rows.Count; row++)
				{
					if(fgrid_Lot[row, 0].ToString() == "" || fgrid_Lot[row, 0].ToString() == "D") continue;

					 

					MyOraDB.Parameter_Values[para_ct] = cmb_Factory.SelectedValue.ToString(); 
					MyOraDB.Parameter_Values[para_ct + 1] = fgrid_Lot[row, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString(); 
					MyOraDB.Parameter_Values[para_ct + 2] = fgrid_Lot[row, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString(); 
					 
					para_ct += 3; 

				} // end for row
 


				MyOraDB.Add_Modify_Parameter(true); 

				save_ct = 0;                           
				para_ct =0;	

 


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPO_LOT_BSC.SAVE_AUTO_SPO_LOT_SIZE";

				// 파라미터 이름 설정 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_REQ_NO"; 
				MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";
				  

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				 
				// 저장 행 수 구하기
				for(int row = row_fixed; row < fgrid_Lot.Rows.Count; row++)
				{
					if(fgrid_Lot[row, 0].ToString() == "" || fgrid_Lot[row, 0].ToString() == "D") continue;

					save_ct += 1;
					 
				}

			
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct];

 
				for(int row = row_fixed; row < fgrid_Lot.Rows.Count; row++)
				{
					if(fgrid_Lot[row, 0].ToString() == "" || fgrid_Lot[row, 0].ToString() == "D") continue;

					for(int i = fgrid_Recv_Lot.Rows.Fixed; i < fgrid_Recv_Lot.Rows.Count; i++)
					{

						if(Convert.ToBoolean(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG].ToString()) == false) continue;

						
						if(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_NO].ToString() == fgrid_Lot[row, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString()
							&& fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_SEQ].ToString() == fgrid_Lot[row, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString())
						{
							req_no += fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxREQ_NO].ToString() + "/";
						}

					} // end for i

					MyOraDB.Parameter_Values[para_ct] = fgrid_Lot[row, 0].ToString();
					MyOraDB.Parameter_Values[para_ct + 1] = cmb_Factory.SelectedValue.ToString(); 
					MyOraDB.Parameter_Values[para_ct + 2] = req_no;     // req_no.Substring(0, req_no.Length - 1); 
					MyOraDB.Parameter_Values[para_ct + 3] = fgrid_Lot[row, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString(); 
					MyOraDB.Parameter_Values[para_ct + 4] = fgrid_Lot[row, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString();  
					MyOraDB.Parameter_Values[para_ct + 5] = ClassLib.ComVar.This_User; 
					
					para_ct += col_ct;
					req_no = "";

				} // end for row

 

				MyOraDB.Add_Modify_Parameter(false);		// 파라미터 데이터를 DataSet에 추가  
				 
				
				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_SPO_LOT_SIZE", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}


		}


		/// <summary>
		/// Save_Recv_Lot : spb_lot, spb_recv_lot 리스트 저장
		/// </summary>
		private bool Save_Recv_Lot(bool arg_clearflag)
		{ 
		 				 
			try
			{


				int col_ct = 17;  
				int save_ct = 0;                            // 저장 행 수
				int para_ct =0;	
				int col_count = 0;


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPO_LOT_BSC.SAVE_SPORECV_SPOLOT";


				MyOraDB.Parameter_Name[col_count] = "ARG_DIVISION";
				col_count++;
 
				for(int i = (int)ClassLib.TBSPO_RECV_LOT.IxFACTORY; i <= (int)ClassLib.TBSPO_RECV_LOT.IxUPD_USER; i++)
				{ 
					if(i == (int)ClassLib.TBSPO_RECV_LOT.IxTOT_LOSS_QTY) continue;
					if(i == (int)ClassLib.TBSPO_RECV_LOT.IxLOT_LOSS_QTY) continue; 

					MyOraDB.Parameter_Name[col_count] = "ARG_" + fgrid_Recv_Lot[0, i].ToString();
					col_count++;
				}
 
				MyOraDB.Parameter_Name[col_count] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[col_count + 1] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[col_count + 2] = "ARG_LEADTIME_CD"; 


				for(int i = 0; i < col_ct; i++) MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ;  
 
				for(int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
				{
					if(fgrid_Lot[i, 0].ToString() != "")
					{
						if(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString() == ""
							|| fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString() == "") continue;

						save_ct += 1;
					}
				
				} 
 


				MyOraDB.Parameter_Values = new string[col_ct * (save_ct + fgrid_Recv_Lot.Rows.Count - fgrid_Recv_Lot.Rows.Fixed) + 1]; 
 

				for(int i = fgrid_Recv_Lot.Rows.Fixed; i < fgrid_Recv_Lot.Rows.Count; i++)
				{
					if(Convert.ToBoolean(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG].ToString()) == false) continue;

					MyOraDB.Parameter_Values[para_ct] = "R"; 
					para_ct++;

					for(int j = (int)ClassLib.TBSPO_RECV_LOT.IxFACTORY; j <= (int)ClassLib.TBSPO_RECV_LOT.IxREMARKS; j++)
					{ 
						if(j == (int)ClassLib.TBSPO_RECV_LOT.IxTOT_LOSS_QTY) continue;
						if(j == (int)ClassLib.TBSPO_RECV_LOT.IxLOT_LOSS_QTY) continue; 
 
						MyOraDB.Parameter_Values[para_ct] = (fgrid_Recv_Lot[i, j] == null) ? "" : fgrid_Recv_Lot[i, j].ToString();
						para_ct++; 
					} 
					MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User; 
					MyOraDB.Parameter_Values[para_ct + 1] = "";   //BOM_CD
					MyOraDB.Parameter_Values[para_ct + 2] = "";		//ROUT_TYPE
					MyOraDB.Parameter_Values[para_ct + 3] = "";   //LEADTIME_CD

					para_ct += 4; 
				}


				for(int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
				{
					if(fgrid_Lot[i, 0].ToString() != "")
					{ 
 
						if(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString() == ""
							|| fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString() == "") continue;


						MyOraDB.Parameter_Values[para_ct]  = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, 0].ToString(), " ");
						MyOraDB.Parameter_Values[para_ct + 1]  = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxFACTORY].ToString(), " ");
						MyOraDB.Parameter_Values[para_ct + 2]  = "";   // req_no
						MyOraDB.Parameter_Values[para_ct + 3]  = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString(), " "); 
						MyOraDB.Parameter_Values[para_ct + 4]  = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString(), " ");
						MyOraDB.Parameter_Values[para_ct + 5]  = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxOBS_ID].ToString(), " ");
						MyOraDB.Parameter_Values[para_ct + 6]  = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxOBS_TYPE].ToString(), " ");
						MyOraDB.Parameter_Values[para_ct + 7]  = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxPO_NO].ToString(), " "); 
						MyOraDB.Parameter_Values[para_ct + 8]  = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxSTYLE_CD].ToString(), " "); 
						MyOraDB.Parameter_Values[para_ct + 9] = "";   // tot_qty
						MyOraDB.Parameter_Values[para_ct + 10] = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_QTY].ToString(), " ");
						MyOraDB.Parameter_Values[para_ct + 11] = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxREAL_LOTYN].ToString(), " ");
						MyOraDB.Parameter_Values[para_ct + 12] = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxREMARKS].ToString(), " ");
						MyOraDB.Parameter_Values[para_ct + 13] = ClassLib.ComVar.This_User;
					
						string[] token = fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxBOM_CD].ToString().Split(' '); 
						MyOraDB.Parameter_Values[para_ct + 14] = token[0]; 
						MyOraDB.Parameter_Values[para_ct + 15] = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxROUT_TYPE].ToString(), " ");
						MyOraDB.Parameter_Values[para_ct + 16] = ClassLib.ComFunction.Empty_String(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLEADTIME_CD].ToString(), " ");

						para_ct += col_ct; 
					}
				 
				}

   
				MyOraDB.Add_Modify_Parameter(arg_clearflag);
				return true;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_SPO_LOT_SIZE", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
 

 
		}



		/// <summary>
		/// Check_Lot_Size : 
		/// </summary>
		/// <returns></returns>
		private bool Check_Lot_Size()
		{
			DataTable dt_ret;
			bool error_flag = false;

			for(int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
			{
				if(fgrid_Lot[i, 0].ToString() != "I") continue;

				//디비에 연결해서 수량 체크
				dt_ret = Check_SizeExist(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxFACTORY].ToString(),
					fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString(),
					fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString(),
					fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_QTY].ToString());

				if(dt_ret.Rows[0].ItemArray[0].ToString() == "N")
				{ 
					if(!error_flag) error_flag = true;

					fgrid_Lot.Rows[i].StyleNew.ForeColor = Color.Red; 
					 
				}
				else
				{
					fgrid_Lot.Rows[i].StyleNew.ForeColor = Color.Blue; 
				}



			} // end for i


			if(error_flag)
				return true;
			else
				return false;




		}


		/// <summary>
		/// Check_SizeExist : 디비에 연결해서 수량 체크
		/// </summary>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		/// <param name="arg_lotqty"></param>
		private DataTable Check_SizeExist(string arg_factory, string arg_lotno, string arg_lotseq, string arg_lotqty)
		{

			DataSet ds_ret;
			string process_name = "PKG_SPO_LOT_BSC.CHECK_LOTSIZE_EXIST";

			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[3] = "ARG_LOT_QTY";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory; 
			MyOraDB.Parameter_Values[1] = arg_lotno; 
			MyOraDB.Parameter_Values[2] = arg_lotseq; 
			MyOraDB.Parameter_Values[3] = arg_lotqty;  
			MyOraDB.Parameter_Values[4] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[process_name]; 

		}



		#endregion



		#endregion

		#region 그리드 이벤트 메서드

		
		/// <summary>
		/// Event_AfterEdit_FgridOrder : 
		/// </summary>
		/// <param name="e"></param>
		private void Event_AfterEdit_FgridOrder(C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			
			// bom code 체크
			if(e.Col != (int)ClassLib.TBSPO_RECV_CHECK.IxCHECK_FLAG) return;

			if(! Convert.ToBoolean(fgrid_Order[e.Row, e.Col].ToString() ) ) return;

			string bom_cd = fgrid_Order[e.Row, (int)ClassLib.TBSPO_RECV_CHECK.IxBOM_CD].ToString().Trim();

			// bom code 없을 경우
			if(bom_cd.Replace("_", "").Equals("") )
			{
				ClassLib.ComFunction.User_Message("Not assign bom code", "Create LOT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				fgrid_Order[e.Row, e.Col] = "False";
				return;
			}

		}
 
		/// <summary>
		/// Event_AfterEdit_FgridRecvLot : 
		/// </summary>
		/// <param name="e"></param>
		private void Event_AfterEdit_FgridRecvLot(C1.Win.C1FlexGrid.RowColEventArgs e)
		{

//			string after_qty = fgrid_Recv_Lot[e.Row, e.Col].ToString();  
//			
//			bool digit_flag;
//
//			int total_qty;
//			int modify_qty = 0;
//			int new_remain_qty = 0;
//			
//			int order_rowno = _Rowfixed;
// 
//			int order_totqty = (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_QTY;
//			int order_remainqty = (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY;  
//
// 
//			//---------------------------------------------------------------
//
//			if(e.Col != (int)ClassLib.TBSPO_RECV_LOT.IxLOT_QTY) return;
//			 
//			//if(_BeforeLotQty == after_qty) return; 
//
//			digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_Recv_Lot[e.Row, e.Col].ToString());
//
//			if(digit_flag == false) return;
//
//
//			//---------------------------------------------------------------
//
//			//수정되어야 할 fgrid_Order row no 계산 
//			order_rowno = Convert.ToInt32(fgrid_Recv_Lot[e.Row, (int)ClassLib.TBSPO_RECV_LOT.IxROW_NO].ToString());
//
//			//수정된 후의 값과 수정 전의 값 차이 계산
//			modify_qty = Convert.ToInt32(_BeforeLotQty) - Convert.ToInt32(after_qty); 
//
//			//계산된 차이 수량 + 기존 fgrid_Order의 남은 수량 
//			new_remain_qty = modify_qty + Convert.ToInt32(fgrid_Order[order_rowno, order_remainqty].ToString()); 
//
//			//fgrid_Order 에 반영
//			fgrid_Order[order_rowno, order_remainqty] = Convert.ToString(new_remain_qty);  
//
//			//---------------------------------------------------------------
//
//			total_qty = Convert.ToInt32(fgrid_Order[order_rowno, order_totqty].ToString()); 
//
// 
//			Update_LotQty(order_rowno, e.Row, 
//				total_qty,   Convert.ToInt32(after_qty), 
//				Convert.ToInt32(fgrid_Order[order_rowno, order_remainqty].ToString()), Convert.ToInt32(_BeforeLotQty));
// 



		}


		/// <summary>
		/// Update_LotQty : 
		/// </summary>
		/// <param name="arg_orderrow">수정할 fgrid_Order Row No</param>
		/// <param name="arg_recvrow">수정할 fgrid_Recv_Lot Row No</param>
		/// <param name="arg_totalqty">총 오더 수량</param>
		/// <param name="arg_afterqty">변경된 lot 수량</param>
		/// <param name="arg_beforeqty">변경되기 전 fgrid_Order의 Lot_RemainQty</param>
		/// <param name="arg_beforelot">변경되기 전 fgrid_Recv_Lot의 LotQty</param>
		private void Update_LotQty(int arg_orderrow, int arg_recvrow, int arg_totalqty, int arg_afterqty, int arg_beforeqty, int arg_beforelot)
		{

			if(arg_afterqty == 0)                  
			{
				// lot 번호가 이미 있으면 삭제 후 다시 lot 생성 가능 메시지 출력
				 
				// fgrid_Recv_Lot
				// 1. lot_checked = n
				// 2. lot_yn = n
				// 3. 배경색 : empty
				// 4. 글자색 : orange
				// * 삭제

				// fgrid_Order
				// 1. order_Checked = n
				// 2. lot_div = n
				// 3. 배경색 : empty
				// 4. 수정 가능 상태로

				
				//				 Delete_Recv_Lot();

				DialogResult message_result;

				//message_result = MessageBox.Show("LOT 생성을 취소하시겠습니까?", "", MessageBoxButtons.YesNo);
				message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this);
				
				if(message_result == DialogResult.No) 
				{
					fgrid_Recv_Lot[arg_recvrow, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_QTY] = arg_beforelot; 
					fgrid_Order[arg_orderrow, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY] = Convert.ToInt32(arg_beforeqty - arg_beforelot);

					if(fgrid_Order[arg_orderrow, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY].ToString() == fgrid_Order[arg_orderrow, (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_QTY].ToString())
					{
						fgrid_Order.GetCellRange(arg_orderrow, 1, arg_orderrow, fgrid_Order.Cols.Count - 1).StyleNew.BackColor = Color.Empty;
					}
					else if(fgrid_Order[arg_orderrow, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY].ToString() == "0")
					{
						fgrid_Order.GetCellRange(arg_orderrow, 1, arg_orderrow, fgrid_Order.Cols.Count - 1).StyleNew.BackColor = Color.LightSteelBlue;	
					}
					else
					{
						fgrid_Order.GetCellRange(arg_orderrow, 1, arg_orderrow, fgrid_Order.Cols.Count - 1).StyleNew.BackColor = Color.Lavender;
					}


					return;
				}
				 

				

			}// end if(arg_afterqty == 0)
			else if(arg_afterqty == arg_totalqty) 
			{
				// fgrid_Recv_Lot
				// 1. lot_checked = y
				// 2. lot_yn = y
				// 3. 배경색 : blue
				
				// fgrid_Order
				// 1. order_Checked = y
				// 2. order_div = y
				// 3. 배경색 : blue
				// 4. 수정 불가 상태로

		
				//				if(Convert.ToBoolean(fgrid_Recv_Lot[arg_recvrow, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG]) == false)
				//				{
				//					fgrid_Recv_Lot[arg_recvrow, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_YN] = "N";
				//				}
				//				else
				//				{
				//					fgrid_Recv_Lot[arg_recvrow, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_YN] = "Y";
				//				}
 
				fgrid_Recv_Lot[arg_recvrow, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG] = "TRUE"; 
				fgrid_Recv_Lot.GetCellRange(arg_recvrow, 1, arg_recvrow, fgrid_Recv_Lot.Cols.Count - 1).StyleNew.BackColor = Color.LightSteelBlue;

				fgrid_Order[arg_orderrow, (int)ClassLib.TBSPO_RECV_CHECK.IxCHECK_FLAG] = "TRUE";
				fgrid_Order[arg_orderrow, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_DIV] = "TRUE";
				fgrid_Order.GetCellRange(arg_orderrow, 1, arg_orderrow, fgrid_Order.Cols.Count - 1).StyleNew.BackColor = Color.LightSteelBlue;
				fgrid_Order.Rows[arg_orderrow].AllowEditing = false; 
				 


			}
			else if(arg_afterqty < arg_totalqty)
			{
				// fgrid_Recv_Lot
				// 1. lot_checked = y
				// 2. lot_yn = y
				// 3. 배경색 : lavendar

				// fgrid_Order
				// 1. order_checked = n
				// 2. order_div = y
				// 3. 배경색 : lavendar
				// 4. 수정 가능 상태로


				fgrid_Recv_Lot[arg_recvrow, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG] = "TRUE";
				//				fgrid_Recv_Lot[arg_recvrow, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_YN] = "Y";
				fgrid_Recv_Lot.GetCellRange(arg_recvrow, 1, arg_recvrow, fgrid_Recv_Lot.Cols.Count - 1).StyleNew.BackColor = Color.Lavender;

				fgrid_Order[arg_orderrow, (int)ClassLib.TBSPO_RECV_CHECK.IxCHECK_FLAG] = "FALSE";
				fgrid_Order[arg_orderrow, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_DIV] = "TRUE";
				fgrid_Order.GetCellRange(arg_orderrow, 1, arg_orderrow, fgrid_Order.Cols.Count - 1).StyleNew.BackColor = Color.Lavender;
				fgrid_Order.Rows[arg_orderrow].AllowEditing = true; 
				 


			} 
 
			//----------------------------------------------------------------------
			//바뀐 Lot 수량을 fgrid_Lot에 반영
			
			for(int i = 0; i < fgrid_Lot.Rows.Count; i++)
			{
				if(fgrid_Recv_Lot[arg_recvrow, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_NO].ToString() == fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString()
					&& fgrid_Recv_Lot[arg_recvrow, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_SEQ].ToString() == fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString())
				{ 
					
					//					if(fgrid_Lot[i, 0].ToString() != "I") fgrid_Lot.Update_Row(i);
 
					fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_QTY] = fgrid_Recv_Lot[arg_recvrow, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_QTY].ToString();

					if(fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_QTY].ToString() == "0") Delete_Recv_Lot(i);
  
					return;
				}
			}



		}



		/// <summary>
		/// Event_Beforedit_FgridRecvLot : 
		/// </summary>
		/// <param name="e"></param>
		/// <returns></returns>
		private void Event_Beforedit_FgridRecvLot(C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			
			bool digit_flag;

			if(e.Col != (int)ClassLib.TBSPO_RECV_LOT.IxLOT_QTY) return;

			digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_Recv_Lot[e.Row, e.Col].ToString());

			if(digit_flag == false) 
			{
				fgrid_Recv_Lot[e.Row, e.Col] = 0;
				return;
			}

			_BeforeLotQty = (fgrid_Recv_Lot[e.Row, e.Col].ToString() == "") ? "0": fgrid_Recv_Lot[e.Row, e.Col].ToString();

		}


		/// <summary>
		/// Event_AfterEdit_FgridLot : 
		/// </summary>
		/// <param name="e"></param>
		private void Event_AfterEdit_FgridLot(C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			//LOT 수량 수정할 경우 
			fgrid_Lot.Update_Row();
			fgrid_Lot.AutoSizeCols(); 


		}


		/// <summary>
		/// Event_Click_FgridLot : 
		/// </summary>
		private void Event_Click_FgridLot()
		{
  
//		
//			if(fgrid_Lot.Rows.Count <= fgrid_Lot.Rows.Fixed) return;
//
//			int sel_row = fgrid_Lot.Selection.r1; 
//			string factory = fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxFACTORY].ToString();
//			string line_cd = fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxLINE_CD].ToString();
//			string bom_cd = fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxBOM_CD].ToString();
//
//			DataTable dt_ret = null;
//			string cmb_list = "";
//
//
//			//ROUT_TYPE 콤보 리스트 세팅
//			if(bom_cd == "")
//			{
//				fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxROUT_TYPE].ComboList = "";
//			}
//			else
//			{
//				dt_ret = Select_SPB_BOM_ROUT_TYPE(factory, bom_cd); 
//
//				for(int i = 0; i < dt_ret.Rows.Count; i++) 
//				{
//					cmb_list += "|" + dt_ret.Rows[i].ItemArray[0].ToString(); 
//				}
//
//				fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxROUT_TYPE].ComboList = cmb_list;
//
//			}
//
//
//			dt_ret = null;
//			cmb_list = "";
//
//			//LEADTIME_CD 콤보 리스트 세팅
//			if(line_cd == "") 
//			{
//				fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxLEADTIME_CD].ComboList = "";
//			}
//			else
//			{
//				dt_ret = Select_SPB_LINEOP_LEADTIME_CD(factory, line_cd);
//
//				for(int i = 0; i < dt_ret.Rows.Count; i++) 
//				{
//					cmb_list += "|" + dt_ret.Rows[i].ItemArray[0].ToString(); 
//				}
//
//				fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxLEADTIME_CD].ComboList = cmb_list;
//			}
//
//
//			
//			dt_ret.Dispose();


		}

 

		/// <summary>
		/// Event_EnterCell_FgridLot : 
		/// </summary>
		private void Event_EnterCell_FgridLot()
		{

//			string po_no = "", style_cd = "", obs_type = "";
//			bool check_sc = false;
//
//			if(fgrid_Lot.Selection.c1 != (int)ClassLib.TBSPO_LOT.IxPO_NO) return; 
//
//			_BeforePO = (fgrid_Lot[fgrid_Lot.Selection.r1, fgrid_Lot.Selection.c1] == null) 
//				? "": fgrid_Lot[fgrid_Lot.Selection.r1, fgrid_Lot.Selection.c1].ToString(); 
//
// 
//
//			//sales contract 작성 여부 체크
//			//작성된 경우 : Y, 작성안된 경우 : N
//			//Y 일때 po변경 불가능하도록 처리
//
//			//신규 등록상태는 대상에서 제외
//			if(fgrid_Lot[fgrid_Lot.Selection.r1, 0] != null && fgrid_Lot[fgrid_Lot.Selection.r1, 0].ToString() == "I") return;
//
//			po_no = fgrid_Lot[fgrid_Lot.Selection.r1, fgrid_Lot.Selection.c1].ToString();
//			style_cd = fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxSTYLE_CD].ToString();
//			obs_type = fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxOBS_TYPE].ToString(); 
//
//			check_sc = Check_SC_STATE(po_no, style_cd, obs_type);
//
//			if(check_sc) 
//			{
//				fgrid_Lot[fgrid_Lot.Selection.r1, fgrid_Lot.Selection.c1] = _BeforePO;
//				fgrid_Lot.Cols[fgrid_Lot.Selection.c1].AllowEditing = false;
//				ClassLib.ComFunction.User_Message("Already sales contract");
//			}
//			else
//			{
//				fgrid_Lot.Cols[fgrid_Lot.Selection.c1].AllowEditing = true;
//			}
 
		}



		/// <summary>
		/// Event_MouseDown_FgridLot
		/// </summary>
		private void Event_MouseDown_FgridLot(System.Windows.Forms.MouseEventArgs e)
		{

			if(fgrid_Lot.Rows.Count == fgrid_Lot.Rows.Fixed) return;

			if(e.Button == MouseButtons.Left)
			{

				
				if(fgrid_Lot.Rows.Count <= fgrid_Lot.Rows.Fixed) return;

				int sel_row = fgrid_Lot.Selection.r1; 

				if(fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxFACTORY] == null 
					|| fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxLINE_CD] == null || fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxLINE_CD].ToString().Equals("")
					|| fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxBOM_CD] == null || fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxBOM_CD].ToString().Equals("") ) return;


				string factory = fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxFACTORY].ToString();
				string line_cd = fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxLINE_CD].ToString();
				string bom_cd = fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxBOM_CD].ToString();

				DataTable dt_ret = null;
				string cmb_list = "";


				//ROUT_TYPE 콤보 리스트 세팅
				if(bom_cd == "")
				{
					fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxROUT_TYPE].ComboList = "";
				}
				else
				{
					dt_ret = Select_SPB_BOM_ROUT_TYPE(factory, bom_cd); 

					for(int i = 0; i < dt_ret.Rows.Count; i++) 
					{
						cmb_list += "|" + dt_ret.Rows[i].ItemArray[0].ToString(); 
					}

					fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxROUT_TYPE].ComboList = cmb_list;

				}


				dt_ret = null;
				cmb_list = "";

				//LEADTIME_CD 콤보 리스트 세팅
				if(line_cd == "") 
				{
					fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxLEADTIME_CD].ComboList = "";
				}
				else
				{
					dt_ret = Select_SPB_LINEOP_LEADTIME_CD(factory, line_cd);

					for(int i = 0; i < dt_ret.Rows.Count; i++) 
					{
						cmb_list += "|" + dt_ret.Rows[i].ItemArray[0].ToString(); 
					}

					fgrid_Lot.Cols[(int)ClassLib.TBSPO_LOT.IxLEADTIME_CD].ComboList = cmb_list;
				}


			
				dt_ret.Dispose();



			}
			else if(e.Button == MouseButtons.Right)
			{


				switch (fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString().Substring(0, 2))
				{
					case "VL":
						menuItem_ChangeLot.Text = "Change Virtual LOT into Real LOT";
						break;

						//				case "LT":
						//					menuItem_ChangeLot.Text = "Change Real LOT into Virtual LOT";
						//					break;

					default:
						menuItem_ChangeLot.Visible = false;
						break;

				} // end switch

			}



		}


		#endregion

		#region 버튼 및 기타 이벤트


		/// <summary>
		/// Event_Click_BtnStep2 : 
		/// </summary>
		private void Event_Click_BtnStep2()
		{

			
			if(rad_OneOne.Checked)
			{
				Make_OneOne_Lot();
			}
 

			if(rad_Transfer.Checked)
			{
				Make_OneMany_Lot();
			}


			if(rad_Partition.Checked)
			{

				ClassLib.ComFunction.Set_NumberTextBox(txt_LotCount, 3);

				for(int i = 0; i <= Convert.ToInt32(txt_LotCount.Text) - 1; i++)
				{
					Make_OneMany_Lot();
				}
			}

		}


		#region Set, Get LOT No

		/// <summary>
		/// Set_LotNo : 다음 LOT 번호 찾기
		/// </summary>
		/// <returns></returns>
		private string Set_LotNo()
		{
			string lotno_code = "";
			int lotno_seq = 0;
			string lotno = "";

			//			if(fgrid_Lot.Rows.Count == _Rowfixed)
			//			{
			//				lotno = Get_LotNo(); 
			//				lotno_seq = Convert.ToInt32(lotno.Substring(6));
			//			}
			//			else
			//			{
			// 				if(fgrid_Lot[fgrid_Lot.Rows.Count - 1, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString().Substring(0, 2) != "LT")
			//				{
			//					lotno = Get_LotNo(); 
			//					lotno_seq = Convert.ToInt32(lotno.Substring(6));
			//				} 
			//				else
			//				{
			//					lotno = fgrid_Lot[fgrid_Lot.Rows.Count - 1, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString();
			//					lotno_seq = Convert.ToInt32(lotno.Substring(6)) + 1;
			//				}
			//
			//
			//			}


			int findrow = fgrid_Lot.FindRow("I", fgrid_Lot.Rows.Fixed, 0, false, true, false);

			if(findrow == -1)
			{
				lotno = Get_LotNo(); 
				lotno_seq = Convert.ToInt32(lotno.Substring(6));

				lotno_code = lotno.Substring(0, 6);  
				lotno = lotno_code + string.Format("{0:000}", lotno_seq);
			}
			else
			{
				lotno = fgrid_Lot[fgrid_Lot.Rows.Count - 1, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString();
				lotno_seq = Convert.ToInt32(lotno.Substring(6)) + 1;
			}


			return lotno;
			 
		}


		/// <summary>
		/// Set_LotNo : 다음 LOT 번호 찾기
		/// </summary>
		/// <returns></returns>
		private string Set_LotNo(string arg_reqno_date)
		{
			string lotno_code = "";
			int lotno_seq = 0;
			string lotno = "";

			//			if(fgrid_Lot.Rows.Count == _Rowfixed)
			//			{
			//				lotno = Get_LotNo(arg_reqno_date); 
			//				lotno_seq = Convert.ToInt32(lotno.Substring(6));
			//			}
			//			else
			//			{
			//				if(fgrid_Lot[fgrid_Lot.Rows.Count - 1, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString().Substring(0, 2) != "LT")
			//				{
			//					lotno = Get_LotNo(arg_reqno_date); 
			//					lotno_seq = Convert.ToInt32(lotno.Substring(6));
			//				} 
			//				else
			//				{
			//					lotno = fgrid_Lot[fgrid_Lot.Rows.Count - 1, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString();
			//					lotno_seq = Convert.ToInt32(lotno.Substring(6)) + 1;
			//				}
			//
			//
			//			}



			int findrow = fgrid_Lot.FindRow("I", fgrid_Lot.Rows.Fixed, 0, false, true, false);

			if(findrow == -1)
			{
				
				lotno = Get_LotNo(arg_reqno_date); 
				lotno_seq = Convert.ToInt32(lotno.Substring(6));
  
				lotno_code = lotno.Substring(0, 6);  
				lotno = lotno_code + string.Format("{0:000}", lotno_seq);
			}
			else
			{
				lotno = fgrid_Lot[fgrid_Lot.Rows.Count - 1, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString();
				lotno_seq = Convert.ToInt32(lotno.Substring(6)) + 1;

				lotno_code = lotno.Substring(0, 6);  
				lotno = lotno_code + string.Format("{0:000}", lotno_seq);
			} 

			return lotno;
			 
		}


		/// <summary>
		/// Get_Max_LotNo : 디비에서 next lot no 가져오기
		/// </summary>
		/// <returns></returns>
		private string Get_LotNo(string arg_reqno_date)
		{  
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPO_LOT_BSC.GET_NEXT_LOTNO";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_REQNO_DATE"; 
				MyOraDB.Parameter_Name[2] = "ARG_PREFIX"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = arg_reqno_date; 
				MyOraDB.Parameter_Values[2] = "LT"; 
				MyOraDB.Parameter_Values[3] = "";   

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString(); ; 
			}
			catch
			{
				return null;
			}

			
		}



		/// <summary>
		/// Get_Max_LotNo : 디비에서 next lot no 가져오기
		/// </summary>
		/// <returns></returns>
		private string Get_LotNo()
		{  

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPO_LOT_BSC.GET_NEXT_LOTNO";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_REQNO_DATE"; 
				MyOraDB.Parameter_Name[2] = "ARG_PREFIX"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
 
				if(cmb_ToDate.SelectedIndex == -1) 
				{
					MyOraDB.Parameter_Values[1] = cmb_FromDate.SelectedValue.ToString().Substring(0, 2) + cmb_FromDate.SelectedValue.ToString().Substring(3, 2);
				}
				else
				{
					MyOraDB.Parameter_Values[1]= cmb_ToDate.SelectedValue.ToString().Substring(0, 2) + cmb_ToDate.SelectedValue.ToString().Substring(3, 2);
				} 
			 
				MyOraDB.Parameter_Values[2] = "LT"; 
				MyOraDB.Parameter_Values[3] = "";   

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString(); ; 
			}
			catch
			{
				return null;
			}



		}


		#endregion

		#region btn_step2 (collecting order)
	

		/// <summary>
		/// Make_OneOne_Lot : 
		/// </summary>
		private void Make_OneOne_Lot()
		{
			string lotno = "", reqno = ""; 
			string[] new_data;  

			// req_no 미리 선택한경우 제외
			int findrow = -1;

			for(int i = fgrid_Order.Rows.Fixed; i < fgrid_Order.Rows.Count; i++)
			{
				if(Convert.ToBoolean(fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxCHECK_FLAG]) == true 
					&& (fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY].ToString() != "0"))
				{
 
					reqno = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxREQ_NO].ToString();

					findrow = fgrid_Recv_Lot.FindRow(reqno, fgrid_Recv_Lot.Rows.Fixed, (int)ClassLib.TBSPO_RECV_LOT.IxREQ_NO, false, true, false);

					// req_no 미리 선택한경우 제외
					if(findrow != -1) continue;

					//lot 번호 가져오기
					lotno = Set_LotNo(reqno.Substring(2, 4));

					//----------------------------------------------------
					//fgrid_lot 에 데이터 추가
					new_data = new string[fgrid_Lot.Cols.Count + 1]; 
						
					new_data[0] = "I";
					new_data[(int)ClassLib.TBSPO_LOT.IxROW_NO] = i.ToString(); 
					new_data[(int)ClassLib.TBSPO_LOT.IxFACTORY] = cmb_Factory.SelectedValue.ToString(); 
					new_data[(int)ClassLib.TBSPO_LOT.IxLOT_NO] = lotno;
					new_data[(int)ClassLib.TBSPO_LOT.IxLOT_SEQ] = "00";
					new_data[(int)ClassLib.TBSPO_LOT.IxOBS_ID] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxOBS_ID].ToString();
					new_data[(int)ClassLib.TBSPO_LOT.IxOBS_TYPE] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxOBS_TYPE].ToString();
					new_data[(int)ClassLib.TBSPO_LOT.IxPO_NO] = ""; //fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxOGAC].ToString();
					new_data[(int)ClassLib.TBSPO_LOT.IxSTYLE_CD] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxSTYLE_CD].ToString();
					new_data[(int)ClassLib.TBSPO_LOT.IxBOM_CD] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxBOM_CD].ToString();
					new_data[(int)ClassLib.TBSPO_LOT.IxLEADTIME_CD] = ClassLib.ComVar.LeadTimeCode;
					new_data[(int)ClassLib.TBSPO_LOT.IxROUT_TYPE] = ClassLib.ComVar.Rout_Type;
					new_data[(int)ClassLib.TBSPO_LOT.IxLOT_QTY] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY].ToString();
					new_data[(int)ClassLib.TBSPO_LOT.IxLOSS_QTY] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_LOSS_REMAINQTY].ToString();
					new_data[(int)ClassLib.TBSPO_LOT.IxREAL_LOTYN] = "Y";
					new_data[(int)ClassLib.TBSPO_LOT.IxPLAN_OAAPP_DIV] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxPLAN_OAAPP_DIV].ToString();

					if(fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxOBS_TYPE].ToString() == "CP")
					{
						new_data[(int)ClassLib.TBSPO_LOT.IxREMARKS] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxDEST].ToString();
					}
					else
					{
						new_data[(int)ClassLib.TBSPO_LOT.IxREMARKS] = ""; 
					}
		
		
					fgrid_Lot.AddItem(new_data, fgrid_Lot.Rows.Count, 0); 
					fgrid_Lot.AutoSizeCols();
					fgrid_Lot.TopRow = fgrid_Lot.Rows.Count - 1;

					//----------------------------------------------------
					//fgrid_recv_lot 에 데이터 추가, lot 반영됨을 표시

					new_data = new string[fgrid_Recv_Lot.Cols.Count + 1]; 
						
					new_data[0] = "";
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG] = "TRUE";
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxROW_NO] = i.ToString(); 
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_YN] = "Y"; 
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxFACTORY] = cmb_Factory.SelectedValue.ToString(); 
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxREQ_NO] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxREQ_NO].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_NO] = lotno;
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_SEQ] = "00";
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxOBS_ID] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxOBS_ID].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxOBS_TYPE] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxOBS_TYPE].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxPO_NO] = ""; //fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxOGAC].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxSTYLE_CD] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxSTYLE_CD].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxTOT_QTY] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_QTY].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_QTY] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxTOT_LOSS_QTY] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_LOSS_QTY].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_LOSS_QTY] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_LOSS_REMAINQTY].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxREMARKS] = "";  
		
					fgrid_Recv_Lot.AddItem(new_data, fgrid_Recv_Lot.Rows.Count, 0); 
					fgrid_Recv_Lot.GetCellRange(fgrid_Recv_Lot.Rows.Count - 1, 1, fgrid_Recv_Lot.Rows.Count - 1, fgrid_Recv_Lot.Cols.Count - 1).StyleNew.BackColor = Color.LightSteelBlue;
					fgrid_Recv_Lot.AutoSizeCols();

					//----------------------------------------------------
					//fgrid_Order 에 상태 반영

					fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxCHECK_FLAG] = "TRUE";
					fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_DIV] = "TRUE"; 
					fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY] = "0";
					fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_LOSS_REMAINQTY] = "0";
					fgrid_Order.Rows[i].AllowEditing = false;
					fgrid_Order.GetCellRange(i, 1, i, fgrid_Order.Cols.Count - 1).StyleNew.BackColor = Color.LightSteelBlue;




		 			 
				} // end if

			} // end for(i, fgrid_Order)

		}

	 

		/// <summary>
		/// Make_OneMany_Lot : 
		/// </summary>
		private void Make_OneMany_Lot()
		{  

			string[] new_data;  


			for(int i = fgrid_Order.Rows.Fixed; i < fgrid_Order.Rows.Count; i++)
			{
				if(Convert.ToBoolean(fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxCHECK_FLAG]) == true 
					&& (fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY].ToString() != "0"))
				{
   
					//----------------------------------------------------
					//fgrid_recv_lot 에 데이터 추가 

					//					reqno = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxREQ_NO].ToString();
					//					findrow = fgrid_Recv_Lot.FindRow(reqno, fgrid_Recv_Lot.Rows.Fixed, (int)ClassLib.TBSPO_RECV_LOT.IxREQ_NO, false, true, false);

					//					// req_no 미리 선택한경우 제외
					//					if(findrow != -1) continue;


					new_data = new string[fgrid_Recv_Lot.Cols.Count + 1]; 
						
					new_data[0] = "";

					if(rad_Partition.Checked == true)
					{
						new_data[(int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG] = "FALSE";
					}
					else
					{
						new_data[(int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG] = "TRUE";
					}

					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxROW_NO] = i.ToString(); 
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_YN] = "N"; 
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxFACTORY] = cmb_Factory.SelectedValue.ToString(); 
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxREQ_NO] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxREQ_NO].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_NO] = "";
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_SEQ] = "";
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxOBS_ID] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxOBS_ID].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxOBS_TYPE] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxOBS_TYPE].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxPO_NO] = ""; //fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxOGAC].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxSTYLE_CD] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxSTYLE_CD].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxTOT_QTY] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_QTY].ToString();
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxTOT_LOSS_QTY] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_LOSS_QTY].ToString();

					if(rad_Partition.Checked == true)
					{
						new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_QTY] = "0"; 
						new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_LOSS_QTY] = "0";
					}
					else
					{
						new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_QTY] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_QTY].ToString();
						new_data[(int)ClassLib.TBSPO_RECV_LOT.IxLOT_LOSS_QTY] = fgrid_Order[i, (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_LOSS_QTY].ToString();

					} 
					 
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxREAL_LOTYN] = "Y";  
					new_data[(int)ClassLib.TBSPO_RECV_LOT.IxREMARKS] = "";  
		
					fgrid_Recv_Lot.AddItem(new_data, fgrid_Recv_Lot.Rows.Count, 0); 
					fgrid_Recv_Lot.AutoSizeCols();
 
					fgrid_Recv_Lot.GetCellRange(fgrid_Recv_Lot.Rows.Count - 1, (int)ClassLib.TBSPO_RECV_LOT.IxTOT_QTY,
						fgrid_Recv_Lot.Rows.Count - 1, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_LOSS_QTY).StyleNew.ForeColor = Color.Orange;

 
		 			 
				} // end if

			} // end for(i, fgrid_Order)

		}
 
		/// <summary>
		/// Make_Mearge_Lot : 
		/// </summary> 
		private void Make_Mearge_Lot()
		{
       
			//lot 생성할 수 있는 키 조건 : style_cd, obs_id 
			string standard_key = "";
			string current_key = "";

			int first_check_row = 0;
			//int lot_row = 0;

			//lot 생성 조건에 만족하면서
			//req_no가 같으면 lot_no는 그대로, lot_seq 증가
			//req_no가 다르면 lot_no 생성, lot_seq = "00"
			string standard_reqno = "";
			string current_reqno = "";
			bool reqno_equal = false;


			//병합 후 적용될 lot 수량 
			int lotqty = 0, lotlossqty = 0;

			//LOT_NO, LOT_SEQ
			string min_reqno_date ="9999";
			string lotno = ""; 
			string lotseq = "00"; 

			//fgrid_Lot에 추가될 데이터 값
			string[] new_data; 
			int findrow = 0;
			string style_cd = "";


			 
			//-------------------------------------------------------------------
			//키 조건 체크, lot 수량 합계 계산

			for(int i = fgrid_Recv_Lot.Rows.Fixed; i < fgrid_Recv_Lot.Rows.Count; i++)
			{
					
				if(Convert.ToBoolean(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG]) == false
					|| fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_YN].ToString() == "Y") continue;

				min_reqno_date = (Convert.ToInt32(min_reqno_date) > Convert.ToInt32(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxREQ_NO].ToString().Substring(2, 4)))
					? fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxREQ_NO].ToString().Substring(2, 4) : min_reqno_date;

				if(first_check_row == 0 || standard_key == "")
				{
					first_check_row = i;
					standard_key = fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxSTYLE_CD].ToString() 
						+ fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxOBS_ID].ToString(); 

					standard_reqno = fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxREQ_NO].ToString();

				}

				if(i != first_check_row)
				{
					current_key = fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxSTYLE_CD].ToString() 
						+ fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxOBS_ID].ToString(); 

					current_reqno = fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxREQ_NO].ToString();

				}


				if(current_key != "" && standard_key != current_key) 
				{
					ClassLib.ComFunction.User_Message("Not equal style code or obs type", "Merge LOT", MessageBoxButtons.OK, MessageBoxIcon.Information);
					standard_key = "";
					current_key = "";
					standard_reqno = "";
					current_reqno = ""; 

					return;
				}
				else
				{
					lotqty += Convert.ToInt32(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_QTY].ToString());	 
					lotlossqty += Convert.ToInt32(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_LOSS_QTY].ToString());	 

					if(standard_reqno == current_reqno) 
					{
						reqno_equal = true;
					}
					else
					{
						reqno_equal = false;
					}
					

				}

			} // end for(i, fgrid_Recv_Lot)


			standard_key = "";
			current_key = "";   
			standard_reqno = "";
			current_reqno = "";

			//----------------------------------------------------
			//fgrid_lot 에 데이터 추가

		
			//lot 번호 가져오기 
			lotno = Set_LotNo(min_reqno_date); 
			lotseq = "00"; 
			
			//----------------------------------------------------
			//lot 반영됨을 표시 
				
			if (reqno_equal == true)
			{ 
				for(int i = fgrid_Recv_Lot.Rows.Fixed; i < fgrid_Recv_Lot.Rows.Count; i++)
				{
					if(Convert.ToBoolean(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG]) == false
						|| fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_YN].ToString() == "Y") continue;

					lotseq = Convert.ToString(Convert.ToInt32(lotseq) + 1).PadLeft(2, '0');

					fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_YN] = "Y"; 
					fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_NO] = lotno;
					fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_SEQ] = lotseq;
				}
			}
			else
			{

				new_data = new string[fgrid_Lot.Cols.Count + 1];  

				lotseq = "00"; 
				style_cd = fgrid_Recv_Lot[first_check_row, (int)ClassLib.TBSPO_RECV_LOT.IxSTYLE_CD].ToString();
				findrow = fgrid_Order.FindRow(style_cd, fgrid_Order.Rows.Fixed, (int)ClassLib.TBSPO_RECV_CHECK.IxSTYLE_CD, false, true, false);
				
				if(findrow == -1) return;

				new_data[0] = "I";
				new_data[(int)ClassLib.TBSPO_LOT.IxROW_NO] = "";  //fgrid_Recv_Lot[first_check_row, (int)ClassLib.TBSPO_RECV_LOT.IxROW_NO].ToString(); 
				new_data[(int)ClassLib.TBSPO_LOT.IxFACTORY] = cmb_Factory.SelectedValue.ToString(); 
				new_data[(int)ClassLib.TBSPO_LOT.IxLOT_NO] = lotno;
				new_data[(int)ClassLib.TBSPO_LOT.IxLOT_SEQ] = lotseq;
				new_data[(int)ClassLib.TBSPO_LOT.IxOBS_ID] = fgrid_Order[findrow, (int)ClassLib.TBSPO_RECV_CHECK.IxOBS_ID].ToString();
				new_data[(int)ClassLib.TBSPO_LOT.IxOBS_TYPE] = fgrid_Recv_Lot[first_check_row, (int)ClassLib.TBSPO_RECV_LOT.IxOBS_TYPE].ToString();
				new_data[(int)ClassLib.TBSPO_LOT.IxPO_NO] = ""; //fgrid_Order[findrow, (int)ClassLib.TBSPO_RECV_CHECK.IxOGAC].ToString();
				new_data[(int)ClassLib.TBSPO_LOT.IxSTYLE_CD] = fgrid_Recv_Lot[first_check_row, (int)ClassLib.TBSPO_RECV_LOT.IxSTYLE_CD].ToString();
				new_data[(int)ClassLib.TBSPO_LOT.IxBOM_CD] = fgrid_Order[findrow, (int)ClassLib.TBSPO_RECV_CHECK.IxBOM_CD].ToString();
				new_data[(int)ClassLib.TBSPO_LOT.IxLEADTIME_CD] = ClassLib.ComVar.LeadTimeCode;
				new_data[(int)ClassLib.TBSPO_LOT.IxROUT_TYPE] = ClassLib.ComVar.Rout_Type;
				new_data[(int)ClassLib.TBSPO_LOT.IxLOT_QTY] = lotqty.ToString();
				new_data[(int)ClassLib.TBSPO_LOT.IxLOSS_QTY] = lotlossqty.ToString();
				new_data[(int)ClassLib.TBSPO_LOT.IxREAL_LOTYN] = fgrid_Recv_Lot[first_check_row, (int)ClassLib.TBSPO_RECV_LOT.IxREAL_LOTYN].ToString();
				new_data[(int)ClassLib.TBSPO_LOT.IxPLAN_OAAPP_DIV] = fgrid_Order[findrow, (int)ClassLib.TBSPO_RECV_CHECK.IxPLAN_OAAPP_DIV].ToString();
				
				if(fgrid_Order[findrow, (int)ClassLib.TBSPO_RECV_CHECK.IxOBS_TYPE].ToString() == "CP")
				{
					new_data[(int)ClassLib.TBSPO_LOT.IxREMARKS] = fgrid_Order[findrow, (int)ClassLib.TBSPO_RECV_CHECK.IxDEST].ToString();
				}
				else
				{
					new_data[(int)ClassLib.TBSPO_LOT.IxREMARKS] = ""; 
				}
	

				fgrid_Lot.AddItem(new_data, fgrid_Lot.Rows.Count, 0); 
				fgrid_Lot.AutoSizeCols();

				for(int i = fgrid_Recv_Lot.Rows.Fixed; i < fgrid_Recv_Lot.Rows.Count; i++)
				{
					if(Convert.ToBoolean(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG]) == false
						|| fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_YN].ToString() == "Y") continue;


					fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_YN] = "Y"; 
					fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_NO] = lotno;
					fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_SEQ] = lotseq;
				}

				
			} 

			fgrid_Recv_Lot.AutoSizeCols(); 

			

		}  



		#endregion

		private void Event_Click_BtnStep3()
		{

			//lot 생성할 수 있는 키 조건 : style_cd, obs_type
			string standard_key = "";
			string current_key = "";

			int first_check_row = 0; 

			//lot 생성 조건에 만족하면서
			//req_no가 같으면 lot_no는 그대로, lot_seq 증가
			//req_no가 다르면 lot_no 생성, lot_seq = "00"
			string standard_reqno = "";
			string current_reqno = ""; 


			bool equal_flag = true;


			//수정상태 해제
			fgrid_Recv_Lot.Select(fgrid_Recv_Lot.Selection.r1, 0, fgrid_Recv_Lot.Selection.r1, fgrid_Recv_Lot.Cols.Count - 1, false);
 

			if(rad_OneOne.Checked)
			{
				Make_Mearge_Lot();	 
			}

		

			if(rad_Transfer.Checked  || rad_Partition.Checked)
			{

				#region 오류처리

				//-------------------------------------------------------------------
				//키 조건 체크, lot 수량 합계 계산

				for(int i = fgrid_Recv_Lot.Rows.Fixed; i < fgrid_Recv_Lot.Rows.Count; i++)
				{
					if(Convert.ToBoolean(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG]) == false
						|| fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_YN].ToString() == "Y") continue;

					if(first_check_row == 0 || standard_key == "")
					{
						first_check_row = i;
						standard_key = fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxSTYLE_CD].ToString();
						//+ fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxOBS_TYPE].ToString();

						standard_reqno = fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxREQ_NO].ToString();

					}

					if(i != first_check_row)
					{
						current_key = fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxSTYLE_CD].ToString();
						//+ fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxOBS_TYPE].ToString();

						current_reqno = fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxREQ_NO].ToString();

					}


					if(current_key != "" && standard_key != current_key) 
					{
						MessageBox.Show("Not equal style code or obs type");
						standard_key = "";
						current_key = "";
						standard_reqno = "";
						current_reqno = ""; 

						return;
					}
					

				} // end for(i, fgrid_Recv_Lot)




				for(int i = fgrid_Recv_Lot.Rows.Fixed; i < fgrid_Recv_Lot.Rows.Count; i++)
				{
					if(Convert.ToBoolean(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG].ToString()) == true
						&& fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_QTY].ToString() == "0") 
					{
						//MessageBox.Show("LOT 수량 입력");
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsNotHaveData, this);
						return;
					}
				}


				#endregion

			
				Make_Mearge_Lot();


				////////////////////////////////////////////////////////////////////////////

				if(rad_Transfer.Checked)
				{
					for(int i = fgrid_Recv_Lot.Rows.Fixed; i < fgrid_Recv_Lot.Rows.Count; i++)
					{

						if(Convert.ToBoolean(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG]) == false) continue;

						if(Convert.ToInt32(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxTOT_QTY].ToString()) 
							!= Convert.ToInt32(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_QTY].ToString()))
						{
							equal_flag = false;
						}
					

					} // end for i

					if(equal_flag == true)
					{
						//MessageBox.Show("사이즈 합계 처리");
						equal_flag = true;
						fgrid_Lot.TopRow = fgrid_Lot.Rows.Count - 1;
						return; 
					}

				} // end if(rad_Transfer.Checked)


				////////////////////////////////////////////////////////////////////////////
				Set_LotSize();  


			} // end if(rad_Transfer.Checked == true || rad_Partition.Checked == true)

  


		}



		#region btn_step3 (create real lot)



		/// <summary>
		/// Set_LotSize : 
		/// </summary>
		private void Set_LotSize()
		{
			DataRow datarow;
 
			//----------------------------------------------------
			//LOT 사이즈 입력
			//----------------------------------------------------

			Form_PO_Lot_Size pop_form = new Form_PO_Lot_Size(); 
 

			for(int i = fgrid_Recv_Lot.Rows.Fixed; i < fgrid_Recv_Lot.Rows.Count; i++)
			{ 
				if(Convert.ToBoolean(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxCHECK_FLAG]) == false) continue;


				//----------------------------------------------------------
				datarow = _SizeDT.NewRow(); 

				for(int j = (int)ClassLib.TBSPO_RECV_LOT.IxFACTORY; j <= (int)ClassLib.TBSPO_RECV_LOT.IxLOT_LOSS_QTY; j++)
				{
					datarow[j - (int)ClassLib.TBSPO_RECV_LOT.IxFACTORY] = fgrid_Recv_Lot[i, j].ToString(); 
				} 

				_SizeDT.Rows.Add(datarow);

				//----------------------------------------------------------
				pop_form._InsertFlag = true;
				pop_form._SizeDT = _SizeDT;  


			} // end for

			pop_form.ShowDialog(); 

			_SizeDT.Rows.Clear();

			Event_Tbtn_Search();
			

		}



		#endregion


		private void Event_Click_BtnCancel()
		{
 
			DialogResult message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this);

			if(message_result == DialogResult.No) return;  

			Delete_Recv_Lot(fgrid_Lot.Selection.r1);

		}

		#region LOT Cancel

		/// <summary>
		/// Delete_Recv_Lot : 
		/// </summary>
		/// <param name="arg_row"></param>
		private void Delete_Recv_Lot(int arg_row)
		{
			 
			int order_check = (int)ClassLib.TBSPO_RECV_CHECK.IxCHECK_FLAG; 
			int order_totqty = (int)ClassLib.TBSPO_RECV_CHECK.IxTOT_QTY;
			int order_lotdiv = (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_DIV;
			int order_remainqty = (int)ClassLib.TBSPO_RECV_CHECK.IxLOT_REMAINQTY;

			int order_row = 0;
			int remainqty = 0, modifyqty = 0; 
		
			if (fgrid_Lot[arg_row, 0].ToString() == "I")
			{
 
				for(int i = fgrid_Recv_Lot.Rows.Count - 1; i >= fgrid_Recv_Lot.Rows.Fixed; i--)
				{
					if(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_NO].ToString() == fgrid_Lot[arg_row, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString()
						&& fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxLOT_SEQ].ToString() == fgrid_Lot[arg_row, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString())
					{
						//LOT 생성 취소되었으므로 체크박스 에디트 가능상태로 전환 
   
						order_row = Convert.ToInt32(fgrid_Recv_Lot[i, (int)ClassLib.TBSPO_RECV_LOT.IxROW_NO].ToString());
						remainqty = Convert.ToInt32(fgrid_Order[order_row, order_remainqty].ToString());
						modifyqty = Convert.ToInt32(fgrid_Lot[arg_row, (int)ClassLib.TBSPO_LOT.IxLOT_QTY].ToString());

						fgrid_Order[order_row, order_check] = "FALSE";
						fgrid_Order[order_row, order_remainqty] = Convert.ToString(remainqty + modifyqty);
						fgrid_Order.Rows[order_row].AllowEditing = true;

						if((remainqty + modifyqty) == Convert.ToInt32(fgrid_Order[order_row, order_totqty].ToString()))
						{
							fgrid_Order[order_row, order_lotdiv] = "FALSE";
							fgrid_Order.GetCellRange(order_row, 1, order_row, fgrid_Order.Cols.Count - 1).StyleNew.BackColor = Color.Empty;
						}
						else
						{
							fgrid_Order[order_row, order_lotdiv] = "TRUE";
							fgrid_Order.GetCellRange(order_row, 1, order_row, fgrid_Order.Cols.Count - 1).StyleNew.BackColor = Color.Lavender;
						}

				 

						fgrid_Recv_Lot.Rows.Remove(i); 
					} 
				}
 
 			
				fgrid_Lot.Rows.Remove(arg_row);


 
			}
			else
			{
				/*
				//plan_status = 'P' or 'L' 인것만 삭제 가능
				if(fgrid_Lot[arg_row, (int)ClassLib.TBSPO_LOT.IxPLAN_STATUS].ToString() == "P"
					|| fgrid_Lot[arg_row, (int)ClassLib.TBSPO_LOT.IxPLAN_STATUS].ToString() == "L"
					|| fgrid_Lot[arg_row, (int)ClassLib.TBSPO_LOT.IxPLAN_STATUS].ToString() == "")
				{
					fgrid_Lot.Delete_Row(); 
				}
				else
				{
					//MessageBox.Show("삭제 불가능");
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					return;
				}
				*/


				// 삭제 할 때 Shipping Area 작성 여부 체크
				Delete_Check_Shipping_Area();


			}


		}


		/// <summary>
		/// Delete_Check_Shipping_Area : 
		/// </summary>
		private void Delete_Check_Shipping_Area()
		{
			bool check_sc = false;
			string real_yn = ""; 
			string factory = "", lot_no = "", lot_seq = "";

			//string lot = "";
			string message = "";

			int sel_r1 = fgrid_Lot.Selection.r1;
			int sel_r2 = fgrid_Lot.Selection.r2; 

			int start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
			int end_row = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

			for(int i = start_row; i <= end_row; i++)
			{
				real_yn = fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxREAL_LOTYN].ToString(); 
				
				// rpm 시뮬레이션용 LOT 은 바로 삭제
				if(real_yn == "N")
				{
					fgrid_Lot.Delete_Row();
				}
					// rpm 시뮬레이션용이 아닌 경우는 S/C 작성여부 체크해서 삭제 여부 반영
				else
				{ 
					 
					factory = fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxFACTORY].ToString();
					lot_no = fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString();
					lot_seq = fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString(); 

					 
					check_sc = Check_Shipping_Area(factory, lot_no, lot_seq);

					if(check_sc) 
					{  
						 
						message = "Shipping area. Can't cancel LOT." + "\r\n\r\n" + "LOT : " + lot_no + "-" + lot_seq;

						ClassLib.ComFunction.User_Message(message, "LOT Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					
						for(int j = i; j <= end_row; j++)
						{
							if(fgrid_Lot[j, 0] == null) continue;

							if(fgrid_Lot[j, 0].ToString() == "D") fgrid_Lot[j, 0] = ""; 
						} 

						fgrid_Lot.TopRow = i;
						fgrid_Lot.Select(i, 0, i, fgrid_Lot.Cols.Count - 1, false);

						return;

					} 
					else
					{
						fgrid_Lot.Delete_Row();
					}  // end if(shipping area check)


					//fgrid_Lot.Delete_Row();


				} // end if(real_yn == "N")


			} // end for i 

		}



		/// <summary>
		/// Check_Shipping_Area : 
		/// </summary>
		/// <returns></returns>
		public static bool Check_Shipping_Area(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{

            
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			string return_val = "";

			string process_name = "PKG_SPO_LOT_BSC.CHECK_SHIPPING_AREA";

			MyOraDB.ReDim_Parameter(4); 
	 
			MyOraDB.Process_Name = process_name;
	 
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
	  
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
				
			MyOraDB.Parameter_Values[0] = arg_factory; 
			MyOraDB.Parameter_Values[1] = arg_lot_no; 
			MyOraDB.Parameter_Values[2] = arg_lot_seq;   
			MyOraDB.Parameter_Values[3] = "";  

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return false; 
			return_val = ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString(); 

			if(return_val == "Y")
				return true;
			else
				return false;

				
		}


		#endregion


		private void Event_Click_BtnChange()
		{

			// 선택된 LOT 리스트

			//-------------------------------------------------------------------------------------------
			DataTable dtChangeLOT = new DataTable(); 
			dtChangeLOT.Columns.Add(new DataColumn("FACTORY", Type.GetType("System.String"))); 
			dtChangeLOT.Columns.Add(new DataColumn("CHECK_FLAG", Type.GetType("System.String"))); 
			dtChangeLOT.Columns.Add(new DataColumn("LOT", Type.GetType("System.String"))); 
			dtChangeLOT.Columns.Add(new DataColumn("STATUS", Type.GetType("System.String"))); 
			//------------------------------------------------------------------------------------------- 
			 
			DataRow newrow; 

			for(int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
			{
				// 선택된 행만 데이터 테이블로 구성
				if(!fgrid_Lot.Rows[i].Selected
					|| fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxREAL_LOTYN].ToString() != "N") continue;
					
				newrow = dtChangeLOT.NewRow();

				newrow[0] = cmb_Factory.SelectedValue.ToString();
				newrow[1] = "TRUE";
				newrow[2] = fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString()
					+ "-" + fgrid_Lot[i, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString();
				newrow[3] = "Ready";

				dtChangeLOT.Rows.Add(newrow); 
			}
 
		
			Pop_ChangeVtoRLot pop_form = new Pop_ChangeVtoRLot();   
			pop_form._DtLOT = dtChangeLOT;
			pop_form.ShowDialog();

			dtChangeLOT.Rows.Clear(); 
			Event_Tbtn_Search();


		}


		private void Event_Click_BtnCreateVLot()
		{
			
			if(cmb_Factory.SelectedIndex == -1) return;

			bool run_flag = Set_SP_SPO_Create_VLot();

			if(!run_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
			}
			else
			{
				Event_Tbtn_Search();
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
			}

		}

		#region 가상 LOT 일괄 생성

		/// <summary>
		/// Set_SP_SPO_Create_VLot : 가상 LOT 일괄 생성
		/// </summary>
		private bool Set_SP_SPO_Create_VLot()
		{

			try
			{

				DataSet ds_ret;
				string year = "", month = "";

				MyOraDB.ReDim_Parameter(5); 
  
				MyOraDB.Process_Name = "SP_SPO_Create_VLot2";    
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_REQNO_DATE";
				MyOraDB.Parameter_Name[2] = "ARG_PREFIX";    
				MyOraDB.Parameter_Name[3] = "ARG_DELETE"; 
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";  
 
				for (int i = 0; i <= 4; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			
 	  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();

				year = System.DateTime.Now.Year.ToString().Substring(2, 2);
				month = System.DateTime.Now.Month.ToString().PadLeft(2, '0');

				MyOraDB.Parameter_Values[1] = year + month;
				MyOraDB.Parameter_Values[2] = "VL"; 
				MyOraDB.Parameter_Values[3] = "N"; 
				MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;  


				MyOraDB.Add_Run_Parameter(true);  
				ds_ret = MyOraDB.Exe_Run_Procedure(); 

				if(ds_ret == null) return false;
				return true;

			}
			catch
			{
				return false;
			}

		}

		#endregion



		#endregion

		#region 컨텍스트 메뉴 이벤트


		/// <summary>
		/// Event_Click_MItem_DLotDaily : 
		/// </summary>
		private void Event_Click_MItem_DLotDaily()
		{

			int sel_row = fgrid_Lot.Selection.r1;
			 
			Pop_SetDirectLotDayily pop_form = new Pop_SetDirectLotDayily();

			if(sel_row < fgrid_Lot.Rows.Fixed) return;

			if(fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxBOM_CD].ToString().Replace("_", "") == "") 
			{
				ClassLib.ComFunction.User_Message("Not yet assign BOM", "Direct Assign to MPS", MessageBoxButtons.OK, MessageBoxIcon.Error); 
				return;
			}

			if(fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxPLAN_STATUS].ToString() == "L") 
			{
				ClassLib.ComFunction.User_Message("Already assign line", "Direct Assign to MPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			 
			//{factory, factory_name, lot_no, lot_seq, po_no}

			COM.ComVar.Parameter_PopUp = new string[] {fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxFACTORY].ToString(), 
														  cmb_Factory.Columns[1].Text,
														  fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString(),
														  fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString(),
														  fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxPO_NO].ToString(),
														  ((int)ClassLib.ComVar.FormLoadDIV_LOT.FromLOT).ToString()};

			pop_form.ShowDialog();

			//if (pop_form._CloseSave) fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxPLAN_STATUS] = "L";

			
			Event_Tbtn_Search();
			fgrid_Lot.TopRow = sel_row;


		}


		private void Event_Click_MItem_ChangeLot()
		{

			int sel_row = fgrid_Lot.Selection.r1;
			bool run_flag = false;

			switch (fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString().Substring(0, 2))
			{
				case "VL":
					Set_SP_SPO_Change_RVLot("R");
					break;

//				case "LT":
//					Set_SP_SPO_Change_RVLot("V");
//					break;

			} // end switch


			if(!run_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
			}
			else
			{
				Event_Tbtn_Search();
				fgrid_Lot.TopRow = sel_row;

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
			}
 

		}

		#region Change LOT


		/// <summary>
		/// Set_SP_SPO_Change_RVLot : 가상 LOT를 실제 LOT으로 바꾸는 작업
		/// </summary>
		private bool Set_SP_SPO_Change_RVLot(string arg_tolot_div)
		{

			try
			{

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(4); 
 
				//01.PROCEDURE명
				MyOraDB.Process_Name = "SP_SPO_Change_RVLot";    
 
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_VLOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_TOLOT_DIV"; 
				MyOraDB.Parameter_Name[3] = "ARG_USER";  
								
				//03.DATA TYPE
				for (int i = 0; i <= 3; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			

			
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString();
				MyOraDB.Parameter_Values[2] = arg_tolot_div; 
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;  


				MyOraDB.Add_Run_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Run_Procedure();		 
 
				if(ds_ret == null) return false;
				
				return true;

			}
			catch
			{
				return false;
			}

		}


		#endregion


		private void Event_Click_MItem_LOTSize()
		{

			ProdPlan.Form_PO_LOTAddLoss pop_form = new ProdPlan.Form_PO_LOTAddLoss();   
			ClassLib.ComVar.Parameter_PopUp = new string[] {fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxFACTORY].ToString(), 
															   fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString(),
															   fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString(),
															   fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxOBS_ID].ToString(),
															   fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxSTYLE_CD].ToString()};
			pop_form.ShowDialog();  
			Event_Tbtn_Search();

		}



		private void Event_Click_MItem_Relation1()
		{
  
			if(fgrid_Lot.Rows.Count <= fgrid_Lot.Rows.Fixed) return;

			if(fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxLOT_NO] == null
				|| fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ] == null)
			{
				fgrid_Recv_Lot.Rows.Count = fgrid_Recv_Lot.Rows.Fixed;
				return;
			}


			string lot_no = fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxLOT_NO].ToString();
			string lot_seq = fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSPO_LOT.IxLOT_SEQ].ToString();
			DataTable dt_ret = Select_SPO_RECV_DISPLAY("2", lot_no + "-" + lot_seq);
			
			fgrid_Recv_Lot.Rows.Count = fgrid_Recv_Lot.Rows.Fixed;  
			//fgrid_Recv_Lot.Cols.Count = arg_dt.Columns.Count + 1;

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				fgrid_Recv_Lot.AddItem(dt_ret.Rows[i].ItemArray, fgrid_Recv_Lot.Rows.Count, 1);
				fgrid_Recv_Lot[fgrid_Recv_Lot.Rows.Count - 1, 0] = "";
			}
			fgrid_Recv_Lot.AutoSizeCols();

			//Display_Relation();
			 
			dt_ret.Dispose();

		}

		private void Event_Click_MItem_Relation()
		{

			if(fgrid_Order.Rows.Count <= fgrid_Order.Rows.Fixed) return;

			if(fgrid_Order[fgrid_Order.Selection.r1, (int)ClassLib.TBSPO_RECV_CHECK.IxREQ_NO] == null)
			{
				fgrid_Recv_Lot.Rows.Count = fgrid_Recv_Lot.Rows.Fixed;
				return;
			}


			string req_no = fgrid_Order[fgrid_Order.Selection.r1, (int)ClassLib.TBSPO_RECV_CHECK.IxREQ_NO].ToString();
			DataTable dt_ret = Select_SPO_RECV_DISPLAY("1", req_no);
				
			fgrid_Recv_Lot.Rows.Count = fgrid_Recv_Lot.Rows.Fixed;  
			//fgrid_Recv_Lot.Cols.Count = arg_dt.Columns.Count + 1;
 
			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				fgrid_Recv_Lot.AddItem(dt_ret.Rows[i].ItemArray, fgrid_Recv_Lot.Rows.Count, 1);
				fgrid_Recv_Lot[fgrid_Recv_Lot.Rows.Count - 1, 0] = "";
			}
			fgrid_Recv_Lot.AutoSizeCols();

			//Display_Relation();

			dt_ret.Dispose();

		}




		#region Relation 표시

		/// <summary>
		/// Select_SPO_RECV_DISPLAY : LOT : REQ_NO 관계 추출
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_value"></param>
		/// <returns></returns>
		private DataTable Select_SPO_RECV_DISPLAY(string arg_division, string arg_value)
		{
			
			try
			{
				DataSet ds_ret;


				string process_name = "PKG_SPO_LOT_BSC.SELECT_SPO_RECV_DISPLAY";

				MyOraDB.ReDim_Parameter(4); 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[2] = "ARG_VALUE"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = arg_division; 
				MyOraDB.Parameter_Values[2] = arg_value;   
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}

		}

		#endregion


		private void Event_Click_MItem_OA()
		{

			int sel_row = fgrid_Order.Selection.r1; 

			if(sel_row < fgrid_Order.Rows.Fixed) return; 
			if(fgrid_Order[sel_row, (int)ClassLib.TBSPO_RECV_CHECK.IxPLAN_OAAPP_DIV].ToString() == "__________"
				|| fgrid_Order[sel_row, (int)ClassLib.TBSPO_RECV_CHECK.IxPLAN_OAAPP_DIV].ToString() == "") return;  //!= "R") return;

			//				Form_PO_Lot_Adjust pop_form = new Z_Form_PO_Lot_Adjust(); 
			//				
			//				//{factory, from_date, to_date, req_no}
			//
			//				from_date = fgrid_Order[sel_row, (int)ClassLib.TBSPO_RECV_CHECK.IxREQ_NO].ToString().Substring(2, 4);
			//				to_date = from_date;
			//
			//				COM.ComVar.Parameter_PopUp = new string[] {cmb_Factory.SelectedValue.ToString(), 
			//															  from_date, 
			//															  to_date,
			//															  fgrid_Order[sel_row, (int)ClassLib.TBSPO_RECV_CHECK.IxREQ_NO].ToString()};
			//				pop_form._FormLoadDiv = ClassLib.ComVar.FormLoadDIV_OA.FromLOT;
			//				pop_form.ShowDialog();


			Event_Tbtn_Search();

			//if (pop_form._CloseSave) fgrid_Lot[sel_row, (int)ClassLib.TBSPO_LOT.IxPLAN_STATUS] = "L";



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


		#endregion

		#region 그리드 이벤트

		private void fgrid_Order_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				Event_AfterEdit_FgridOrder(e); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_AfterEdit_FgridOrder", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		} 

		private void fgrid_Order_DoubleClick(object sender, System.EventArgs e)
		{
			try
			{ 
				 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Order_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void fgrid_Recv_Lot_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				Event_AfterEdit_FgridRecvLot(e); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_AfterEdit_FgridRecvLot", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void fgrid_Recv_Lot_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				Event_Beforedit_FgridRecvLot(e); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Beforedit_FgridRecvLot", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void fgrid_Lot_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{ 
				Event_AfterEdit_FgridLot(e); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_AfterEdit_FgridLot", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void fgrid_Lot_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Event_Click_FgridLot();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_FgridLot", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void fgrid_Lot_DoubleClick(object sender, System.EventArgs e)
		{
			try
			{  
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Lot_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void fgrid_Lot_EnterCell(object sender, System.EventArgs e)
		{
			try
			{ 
				Event_EnterCell_FgridLot();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_EnterCell_FgridLot", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void fgrid_Lot_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{ 
				Event_MouseDown_FgridLot(e);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_MouseDown_FgridLot", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
  
				if (cmb_Factory.SelectedIndex == -1) return;

				fgrid_Order.Rows.Count = fgrid_Order.Rows.Fixed;
				fgrid_Recv_Lot.Rows.Count = fgrid_Recv_Lot.Rows.Fixed;
				fgrid_Lot.Rows.Count = fgrid_Lot.Rows.Fixed;

				DataTable dt_ret = ClassLib.ComFunction.Select_DPO(cmb_Factory.SelectedValue.ToString(), "P");  
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_FromDate, 0, 0, false, COM.ComVar.ComboList_Visible.Code); 
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ToDate, 0, 0, false, COM.ComVar.ComboList_Visible.Code);  
				dt_ret.Dispose();

				if(cmb_FromDate.ListCount != 0) cmb_FromDate.SelectedIndex = 0;



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void cmb_FromDate_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 

				fgrid_Order.Rows.Count = fgrid_Order.Rows.Fixed;
				fgrid_Recv_Lot.Rows.Count = fgrid_Recv_Lot.Rows.Fixed;
				fgrid_Lot.Rows.Count = fgrid_Lot.Rows.Fixed;
 
				if(cmb_FromDate.SelectedIndex == -1) return;
				cmb_ToDate.SelectedValue = cmb_FromDate.SelectedValue.ToString(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_FromDate_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void cmb_ToDate_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
			 
				fgrid_Order.Rows.Count = fgrid_Order.Rows.Fixed;
				fgrid_Recv_Lot.Rows.Count = fgrid_Recv_Lot.Rows.Fixed;
				fgrid_Lot.Rows.Count = fgrid_Lot.Rows.Fixed; 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_ToDate_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			try
			{ 

				if(e.KeyCode != Keys.Enter) return;

				Event_Tbtn_Search();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void rad_OneOne_CheckedChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 
 
//				rad_Partition.Checked = false;
//				rad_Transfer.Checked = false;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_OneOne_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 
		 

		private void rad_Partition_CheckedChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 
 
//				if (rad_Partition.Checked)
//				{
//					lbl_LotCount.Visible = true;
//					txt_LotCount.Visible = true;
//					txt_LotCount.Text = "";
//				}
//				else
//				{
//					lbl_LotCount.Visible = false;
//					txt_LotCount.Visible = false;
//				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_Partition_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 
 
		private void btn_Step2_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_Click_BtnStep2();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_BtnStep2", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}  

		private void btn_Step3_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_Click_BtnStep3(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_BtnStep3", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_Click_BtnCancel();	
            }
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_BtnCancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btn_Change_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_Click_BtnChange();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_BtnChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btn_CreateVLot_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_Click_BtnCreateVLot();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_BtnCreateVLot", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		} 
		
		private void txt_LotCount_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
		
			try
			{ 

				if(e.KeyCode != Keys.Enter) return;

				Event_Click_BtnStep2();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_LotCount_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		#endregion   
		
		#region 컨텍스트 메뉴 이벤트

		private void menuItem_DLotDayily_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_MItem_DLotDaily();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_MItem_DLotDaily", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuItem_ChangeLot_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_MItem_ChangeLot();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_MItem_ChangeLot", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuitem_LOTSize_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_MItem_LOTSize();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_MItem_LOTSize", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		
		private void menuItem_Relation1_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_MItem_Relation1();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_MItem_Relation1", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 
		

		private void menuItem_Relation_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_MItem_Relation();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_MItem_Relation", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		

		private void menuItem_OA_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_MItem_OA();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_MItem_OA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		#endregion


		#endregion 

		#region 디비 연결


		/// <summary>
		/// Select_SPO_RECV_AND_LOT : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_dpo_from"></param>
		/// <param name="arg_dpo_to"></param>
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		private DataSet Select_SPO_RECV_AND_LOT(string arg_factory, string arg_dpo_from, string arg_dpo_to, string arg_style_cd)
		{

			try
			{
				 
				DataSet ds_ret;

				string process_name = "PKG_SPO_LOT_BSC.SELECT_SPO_RECV";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE"; 
				MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";  

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_dpo_from;
				MyOraDB.Parameter_Values[2] = arg_dpo_to;
				MyOraDB.Parameter_Values[3] = arg_style_cd;
				MyOraDB.Parameter_Values[4] = "";   

				MyOraDB.Add_Select_Parameter(true); 




				process_name = "PKG_SPO_LOT_BSC.SELECT_SPO_LOT";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE"; 
				MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";  

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_dpo_from;
				MyOraDB.Parameter_Values[2] = arg_dpo_to;
				MyOraDB.Parameter_Values[3] = arg_style_cd;
				MyOraDB.Parameter_Values[4] = "";      

				MyOraDB.Add_Select_Parameter(false); 

				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret; 

			}
			catch
			{ 
				return null;
			}

		}


		/// <summary>
		/// Select_SPB_BOM_ROUT_TYPE : 선택된 LOT에 대한 BOM코드에 할당된 ROUT_TYPE 리스트
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_bomcd"></param>
		/// <returns></returns>
		public static DataTable Select_SPB_BOM_ROUT_TYPE(string arg_factory, string arg_bomcd)
		{
			
			try
			{

				COM.OraDB myOraDB = new COM.OraDB();

				DataSet ds_ret;


				string process_name = "PKG_SPO_LOT_BSC.SELECT_SPB_BOM_ROUT_TYPE";

				myOraDB.ReDim_Parameter(3); 
 
				myOraDB.Process_Name = process_name;
 
				myOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				myOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				myOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				myOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				myOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				myOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
				myOraDB.Parameter_Values[0] = arg_factory; 
				myOraDB.Parameter_Values[1] = arg_bomcd; 
				myOraDB.Parameter_Values[2] = "";   

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



		/// <summary>
		/// Select_SPB_LINEOP_LEADTIME_CD : 배치된 라인의 리드타임 코드 리스트 추출
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_linecd"></param>
		/// <returns></returns>
		public static DataTable Select_SPB_LINEOP_LEADTIME_CD(string arg_factory, string arg_linecd)
		{
			try
			{

				COM.OraDB myOraDB = new COM.OraDB();

				DataSet ds_ret;

			
				string process_name = "PKG_SPO_LOT_BSC.SELECT_SPB_LINEOP_LEADTIME_CD";

				myOraDB.ReDim_Parameter(3); 
 
				myOraDB.Process_Name = process_name;
 
				myOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				myOraDB.Parameter_Name[1] = "ARG_LINE_CD"; 
				myOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				myOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				myOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				myOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
				myOraDB.Parameter_Values[0] = arg_factory; 
				myOraDB.Parameter_Values[1] = arg_linecd; 
				myOraDB.Parameter_Values[2] = "";   

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

		

		
	}
}

