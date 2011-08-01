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
	public class Form_PO_OrderRecv : COM.APSWinForm.Form_Top
	{
		
		#region 컨트롤 정의 및 리소스 정리

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.ContextMenu cmenu_AddLoss;
		private System.Windows.Forms.MenuItem menuItem_AddLoss;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_Style;
		private C1.Win.C1List.C1Combo cmb_EObsType;
		private System.Windows.Forms.Label lbl_EObsType;
		private System.Windows.Forms.Label btn_OrderRecv;
		private C1.Win.C1List.C1Combo cmb_EDate;
		private System.Windows.Forms.Label lbl_EDate;
		private C1.Win.C1List.C1Combo cmb_EFactory;
		private System.Windows.Forms.Label lbl_EFactory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_NonStyleData;
		private System.Windows.Forms.Label lbl_NonModelData;
		private System.Windows.Forms.Panel pnl_BL;
		public System.Windows.Forms.Panel pnl_Sales;
		private System.Windows.Forms.CheckBox chk_AllSelect;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_SubTitle2;
		private System.Windows.Forms.Panel pnl_BR;
		public System.Windows.Forms.Panel pnl_Plan;
		private System.Windows.Forms.CheckBox chk_AllDelete;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.Label lbl_SubTitle3;
		private COM.FSP fgrid_EOrder;
		private COM.FSP fgrid_POrder;
		private System.Windows.Forms.ImageList img_LongButton;


		#endregion

		#region 생성자, 소멸자


		public Form_PO_OrderRecv()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_OrderRecv));
			this.cmenu_AddLoss = new System.Windows.Forms.ContextMenu();
			this.menuItem_AddLoss = new System.Windows.Forms.MenuItem();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_BR = new System.Windows.Forms.Panel();
			this.fgrid_POrder = new COM.FSP();
			this.pnl_Plan = new System.Windows.Forms.Panel();
			this.chk_AllDelete = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle3 = new System.Windows.Forms.Label();
			this.pnl_BL = new System.Windows.Forms.Panel();
			this.fgrid_EOrder = new COM.FSP();
			this.pnl_Sales = new System.Windows.Forms.Panel();
			this.chk_AllSelect = new System.Windows.Forms.CheckBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.pnl_BT = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_NonStyleData = new System.Windows.Forms.Label();
			this.lbl_NonModelData = new System.Windows.Forms.Label();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.cmb_EObsType = new C1.Win.C1List.C1Combo();
			this.lbl_EObsType = new System.Windows.Forms.Label();
			this.btn_OrderRecv = new System.Windows.Forms.Label();
			this.cmb_EDate = new C1.Win.C1List.C1Combo();
			this.lbl_EDate = new System.Windows.Forms.Label();
			this.cmb_EFactory = new C1.Win.C1List.C1Combo();
			this.lbl_EFactory = new System.Windows.Forms.Label();
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
			this.pnl_BR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_POrder)).BeginInit();
			this.pnl_Plan.SuspendLayout();
			this.pnl_BL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EOrder)).BeginInit();
			this.pnl_Sales.SuspendLayout();
			this.pnl_BT.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_EObsType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_EDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_EFactory)).BeginInit();
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
			// cmenu_AddLoss
			// 
			this.cmenu_AddLoss.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.menuItem_AddLoss});
			// 
			// menuItem_AddLoss
			// 
			this.menuItem_AddLoss.Index = 0;
			this.menuItem_AddLoss.Text = "Add Loss Qty.";
			this.menuItem_AddLoss.Click += new System.EventHandler(this.menuItem_AddLoss_Click);
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
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
			this.c1Sizer1.Controls.Add(this.pnl_BR);
			this.c1Sizer1.Controls.Add(this.pnl_BL);
			this.c1Sizer1.Controls.Add(this.pnl_BT);
			this.c1Sizer1.GridDefinition = "11.1111111111111:False:True;86.1111111111111:False:False;0:False:False;\t0:False:F" +
				"alse;48.9173228346457:True:False;49.1141732283465:False:False;0:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_BR
			// 
			this.pnl_BR.Controls.Add(this.fgrid_POrder);
			this.pnl_BR.Controls.Add(this.pnl_Plan);
			this.pnl_BR.DockPadding.Left = 5;
			this.pnl_BR.Location = new System.Drawing.Point(509, 72);
			this.pnl_BR.Name = "pnl_BR";
			this.pnl_BR.Size = new System.Drawing.Size(499, 496);
			this.pnl_BR.TabIndex = 38;
			// 
			// fgrid_POrder
			// 
			this.fgrid_POrder.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_POrder.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_POrder.ContextMenu = this.cmenu_AddLoss;
			this.fgrid_POrder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_POrder.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_POrder.Location = new System.Drawing.Point(5, 32);
			this.fgrid_POrder.Name = "fgrid_POrder";
			this.fgrid_POrder.Size = new System.Drawing.Size(494, 464);
			this.fgrid_POrder.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_POrder.TabIndex = 71;
			// 
			// pnl_Plan
			// 
			this.pnl_Plan.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Plan.Controls.Add(this.chk_AllDelete);
			this.pnl_Plan.Controls.Add(this.pictureBox1);
			this.pnl_Plan.Controls.Add(this.pictureBox4);
			this.pnl_Plan.Controls.Add(this.lbl_SubTitle3);
			this.pnl_Plan.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Plan.DockPadding.Bottom = 5;
			this.pnl_Plan.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_Plan.Location = new System.Drawing.Point(5, 0);
			this.pnl_Plan.Name = "pnl_Plan";
			this.pnl_Plan.Size = new System.Drawing.Size(494, 32);
			this.pnl_Plan.TabIndex = 70;
			// 
			// chk_AllDelete
			// 
			this.chk_AllDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_AllDelete.Location = new System.Drawing.Point(224, 5);
			this.chk_AllDelete.Name = "chk_AllDelete";
			this.chk_AllDelete.Size = new System.Drawing.Size(104, 15);
			this.chk_AllDelete.TabIndex = 30;
			this.chk_AllDelete.Text = "Delete All";
			this.chk_AllDelete.CheckedChanged += new System.EventHandler(this.chk_AllDelete_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(478, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 32);
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(224, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(270, 32);
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// lbl_SubTitle3
			// 
			this.lbl_SubTitle3.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle3.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle3.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle3.Image")));
			this.lbl_SubTitle3.Location = new System.Drawing.Point(0, -1);
			this.lbl_SubTitle3.Name = "lbl_SubTitle3";
			this.lbl_SubTitle3.Size = new System.Drawing.Size(231, 32);
			this.lbl_SubTitle3.TabIndex = 28;
			this.lbl_SubTitle3.Text = "      Receive to Plan";
			this.lbl_SubTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_BL
			// 
			this.pnl_BL.Controls.Add(this.fgrid_EOrder);
			this.pnl_BL.Controls.Add(this.pnl_Sales);
			this.pnl_BL.Location = new System.Drawing.Point(8, 72);
			this.pnl_BL.Name = "pnl_BL";
			this.pnl_BL.Size = new System.Drawing.Size(497, 496);
			this.pnl_BL.TabIndex = 36;
			// 
			// fgrid_EOrder
			// 
			this.fgrid_EOrder.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_EOrder.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_EOrder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_EOrder.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_EOrder.Location = new System.Drawing.Point(0, 32);
			this.fgrid_EOrder.Name = "fgrid_EOrder";
			this.fgrid_EOrder.Size = new System.Drawing.Size(497, 464);
			this.fgrid_EOrder.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_EOrder.TabIndex = 71;
			// 
			// pnl_Sales
			// 
			this.pnl_Sales.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Sales.Controls.Add(this.chk_AllSelect);
			this.pnl_Sales.Controls.Add(this.pictureBox2);
			this.pnl_Sales.Controls.Add(this.pictureBox3);
			this.pnl_Sales.Controls.Add(this.lbl_SubTitle2);
			this.pnl_Sales.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Sales.DockPadding.Bottom = 5;
			this.pnl_Sales.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_Sales.Location = new System.Drawing.Point(0, 0);
			this.pnl_Sales.Name = "pnl_Sales";
			this.pnl_Sales.Size = new System.Drawing.Size(497, 32);
			this.pnl_Sales.TabIndex = 70;
			// 
			// chk_AllSelect
			// 
			this.chk_AllSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_AllSelect.Location = new System.Drawing.Point(224, 5);
			this.chk_AllSelect.Name = "chk_AllSelect";
			this.chk_AllSelect.Size = new System.Drawing.Size(104, 15);
			this.chk_AllSelect.TabIndex = 29;
			this.chk_AllSelect.Text = "Select All";
			this.chk_AllSelect.CheckedChanged += new System.EventHandler(this.chk_AllSelect_CheckedChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(481, 0);
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
			this.pictureBox3.Size = new System.Drawing.Size(273, 32);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, -1);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 32);
			this.lbl_SubTitle2.TabIndex = 28;
			this.lbl_SubTitle2.Text = "      Request from Sales";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_BT
			// 
			this.pnl_BT.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_BT.Controls.Add(this.pnl_SearchImage);
			this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BT.DockPadding.Bottom = 2;
			this.pnl_BT.DockPadding.Left = 8;
			this.pnl_BT.DockPadding.Right = 8;
			this.pnl_BT.Location = new System.Drawing.Point(0, 0);
			this.pnl_BT.Name = "pnl_BT";
			this.pnl_BT.Size = new System.Drawing.Size(1016, 64);
			this.pnl_BT.TabIndex = 35;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.groupBox1);
			this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_Style);
			this.pnl_SearchImage.Controls.Add(this.cmb_EObsType);
			this.pnl_SearchImage.Controls.Add(this.lbl_EObsType);
			this.pnl_SearchImage.Controls.Add(this.btn_OrderRecv);
			this.pnl_SearchImage.Controls.Add(this.cmb_EDate);
			this.pnl_SearchImage.Controls.Add(this.lbl_EDate);
			this.pnl_SearchImage.Controls.Add(this.cmb_EFactory);
			this.pnl_SearchImage.Controls.Add(this.lbl_EFactory);
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
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 62);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox1.Controls.Add(this.lbl_NonStyleData);
			this.groupBox1.Controls.Add(this.lbl_NonModelData);
			this.groupBox1.Location = new System.Drawing.Point(724, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 30);
			this.groupBox1.TabIndex = 203;
			this.groupBox1.TabStop = false;
			// 
			// lbl_NonStyleData
			// 
			this.lbl_NonStyleData.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(251)), ((System.Byte)(248)), ((System.Byte)(185)));
			this.lbl_NonStyleData.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_NonStyleData.Location = new System.Drawing.Point(136, 10);
			this.lbl_NonStyleData.Name = "lbl_NonStyleData";
			this.lbl_NonStyleData.Size = new System.Drawing.Size(132, 16);
			this.lbl_NonStyleData.TabIndex = 41;
			this.lbl_NonStyleData.Text = "Style Data Not Found";
			this.lbl_NonStyleData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_NonModelData
			// 
			this.lbl_NonModelData.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(217)), ((System.Byte)(250)), ((System.Byte)(216)));
			this.lbl_NonModelData.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_NonModelData.Location = new System.Drawing.Point(4, 10);
			this.lbl_NonModelData.Name = "lbl_NonModelData";
			this.lbl_NonModelData.Size = new System.Drawing.Size(132, 16);
			this.lbl_NonModelData.TabIndex = 40;
			this.lbl_NonModelData.Text = "Model Data Not Found";
			this.lbl_NonModelData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(587, 36);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.TabIndex = 202;
			this.txt_StyleCd.Text = "";
			this.txt_StyleCd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StyleCd_KeyPress);
			// 
			// lbl_Style
			// 
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_SmallLabel;
			this.lbl_Style.Location = new System.Drawing.Point(536, 36);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(50, 21);
			this.lbl_Style.TabIndex = 201;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_EObsType
			// 
			this.cmb_EObsType.AddItemCols = 0;
			this.cmb_EObsType.AddItemSeparator = ';';
			this.cmb_EObsType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_EObsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_EObsType.Caption = "";
			this.cmb_EObsType.CaptionHeight = 17;
			this.cmb_EObsType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_EObsType.ColumnCaptionHeight = 18;
			this.cmb_EObsType.ColumnFooterHeight = 18;
			this.cmb_EObsType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_EObsType.ContentHeight = 17;
			this.cmb_EObsType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_EObsType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_EObsType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_EObsType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_EObsType.EditorHeight = 17;
			this.cmb_EObsType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_EObsType.GapHeight = 2;
			this.cmb_EObsType.ItemHeight = 15;
			this.cmb_EObsType.Location = new System.Drawing.Point(429, 36);
			this.cmb_EObsType.MatchEntryTimeout = ((long)(2000));
			this.cmb_EObsType.MaxDropDownItems = ((short)(5));
			this.cmb_EObsType.MaxLength = 32767;
			this.cmb_EObsType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_EObsType.Name = "cmb_EObsType";
			this.cmb_EObsType.PartialRightColumn = false;
			this.cmb_EObsType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_EObsType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_EObsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_EObsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_EObsType.Size = new System.Drawing.Size(100, 21);
			this.cmb_EObsType.TabIndex = 39;
			this.cmb_EObsType.SelectedValueChanged += new System.EventHandler(this.cmb_EObsType_SelectedValueChanged);
			// 
			// lbl_EObsType
			// 
			this.lbl_EObsType.ImageIndex = 0;
			this.lbl_EObsType.ImageList = this.img_Label;
			this.lbl_EObsType.Location = new System.Drawing.Point(328, 36);
			this.lbl_EObsType.Name = "lbl_EObsType";
			this.lbl_EObsType.Size = new System.Drawing.Size(100, 21);
			this.lbl_EObsType.TabIndex = 38;
			this.lbl_EObsType.Text = "Order Type";
			this.lbl_EObsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_OrderRecv
			// 
			this.btn_OrderRecv.ImageIndex = 2;
			this.btn_OrderRecv.ImageList = this.img_MiniButton;
			this.btn_OrderRecv.Location = new System.Drawing.Point(696, 36);
			this.btn_OrderRecv.Name = "btn_OrderRecv";
			this.btn_OrderRecv.Size = new System.Drawing.Size(21, 21);
			this.btn_OrderRecv.TabIndex = 0;
			this.btn_OrderRecv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_OrderRecv.Click += new System.EventHandler(this.btn_OrderRecv_Click);
			this.btn_OrderRecv.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_OrderRecv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_OrderRecv.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_OrderRecv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// cmb_EDate
			// 
			this.cmb_EDate.AddItemCols = 0;
			this.cmb_EDate.AddItemSeparator = ';';
			this.cmb_EDate.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_EDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_EDate.Caption = "";
			this.cmb_EDate.CaptionHeight = 17;
			this.cmb_EDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_EDate.ColumnCaptionHeight = 18;
			this.cmb_EDate.ColumnFooterHeight = 18;
			this.cmb_EDate.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_EDate.ContentHeight = 17;
			this.cmb_EDate.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_EDate.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_EDate.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_EDate.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_EDate.EditorHeight = 17;
			this.cmb_EDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_EDate.GapHeight = 2;
			this.cmb_EDate.ItemHeight = 15;
			this.cmb_EDate.Location = new System.Drawing.Point(219, 36);
			this.cmb_EDate.MatchEntryTimeout = ((long)(2000));
			this.cmb_EDate.MaxDropDownItems = ((short)(5));
			this.cmb_EDate.MaxLength = 32767;
			this.cmb_EDate.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_EDate.Name = "cmb_EDate";
			this.cmb_EDate.PartialRightColumn = false;
			this.cmb_EDate.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_EDate.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_EDate.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_EDate.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_EDate.Size = new System.Drawing.Size(100, 21);
			this.cmb_EDate.TabIndex = 36;
			this.cmb_EDate.SelectedValueChanged += new System.EventHandler(this.cmb_EDate_SelectedValueChanged);
			// 
			// lbl_EDate
			// 
			this.lbl_EDate.ImageIndex = 0;
			this.lbl_EDate.ImageList = this.img_SmallLabel;
			this.lbl_EDate.Location = new System.Drawing.Point(168, 36);
			this.lbl_EDate.Name = "lbl_EDate";
			this.lbl_EDate.Size = new System.Drawing.Size(50, 21);
			this.lbl_EDate.TabIndex = 35;
			this.lbl_EDate.Text = "DPO";
			this.lbl_EDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_EFactory
			// 
			this.cmb_EFactory.AddItemCols = 0;
			this.cmb_EFactory.AddItemSeparator = ';';
			this.cmb_EFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_EFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_EFactory.Caption = "";
			this.cmb_EFactory.CaptionHeight = 17;
			this.cmb_EFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_EFactory.ColumnCaptionHeight = 18;
			this.cmb_EFactory.ColumnFooterHeight = 18;
			this.cmb_EFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_EFactory.ContentHeight = 17;
			this.cmb_EFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_EFactory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_EFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_EFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_EFactory.EditorHeight = 17;
			this.cmb_EFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_EFactory.GapHeight = 2;
			this.cmb_EFactory.ItemHeight = 15;
			this.cmb_EFactory.Location = new System.Drawing.Point(60, 36);
			this.cmb_EFactory.MatchEntryTimeout = ((long)(2000));
			this.cmb_EFactory.MaxDropDownItems = ((short)(5));
			this.cmb_EFactory.MaxLength = 32767;
			this.cmb_EFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_EFactory.Name = "cmb_EFactory";
			this.cmb_EFactory.PartialRightColumn = false;
			this.cmb_EFactory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_EFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_EFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_EFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_EFactory.Size = new System.Drawing.Size(100, 21);
			this.cmb_EFactory.TabIndex = 33;
			this.cmb_EFactory.SelectedValueChanged += new System.EventHandler(this.cmb_EFactory_SelectedValueChanged);
			// 
			// lbl_EFactory
			// 
			this.lbl_EFactory.ImageIndex = 0;
			this.lbl_EFactory.ImageList = this.img_SmallLabel;
			this.lbl_EFactory.Location = new System.Drawing.Point(9, 36);
			this.lbl_EFactory.Name = "lbl_EFactory";
			this.lbl_EFactory.Size = new System.Drawing.Size(50, 21);
			this.lbl_EFactory.TabIndex = 32;
			this.lbl_EFactory.Text = "Factory";
			this.lbl_EFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(985, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 22);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(984, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(776, 32);
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
			this.lbl_SubTitle1.Text = "      Sales / Plan";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(984, 46);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 44);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(840, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 42);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 22);
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
			this.picb_MM.Size = new System.Drawing.Size(832, 22);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// Form_PO_OrderRecv
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_PO_OrderRecv";
			this.Text = "Order Checking List (Sales/Plan)";
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_BR.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_POrder)).EndInit();
			this.pnl_Plan.ResumeLayout(false);
			this.pnl_BL.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EOrder)).EndInit();
			this.pnl_Sales.ResumeLayout(false);
			this.pnl_BT.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_EObsType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_EDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_EFactory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 
		 
		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();  


		// 체크된 행을 한꺼번에 옮기기 위해서 데이터 테이블 생성
		private DataTable _MoveDataTable = new DataTable();


		// 이미 오더 접수된 행에 대해서는 처리 안하기 위해서
		private string _YetCheck_Div = "x";
 

		// 스타일, 모델 정보 없는 카운트
		private int _StyleNoCount = 0;
		private int _ModelNoCount = 0; 


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
				this.Text = "Order Request & Receive (Sales/Plan)";
				this.lbl_MainTitle.Text = "Order Request & Receive (Sales/Plan)"; 
 

				fgrid_EOrder.Set_Grid("SPO_RECV_BSC", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false); 
				fgrid_EOrder.Set_Action_Image(img_Action);
				fgrid_EOrder.Styles.Alternate.BackColor = Color.White;
				fgrid_EOrder.Font = new Font("Verdana", 7);

				fgrid_POrder.Set_Grid("SPO_RECV_BSC", "2", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false); 
				fgrid_POrder.Set_Action_Image(img_Action);  
				fgrid_POrder.Styles.Alternate.BackColor = Color.White;
				fgrid_POrder.Font = new Font("Verdana", 7);


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
			tbtn_Color.Enabled = false;
			tbtn_Print.Enabled = false; 
 
			 
			//------------------------------------------------------------------------------------------- 
			_MoveDataTable.Columns.Add(new DataColumn("DIVISION", Type.GetType("System.String")));
			_MoveDataTable.Columns.Add(new DataColumn("DEL_YN", Type.GetType("System.String")));

			for(int i = (int)ClassLib.TBSPO_RECV_BSC.IxFACTORY; i <= (int)ClassLib.TBSPO_RECV_BSC.IxLOT_LOSS_REMAINQTY; i++)
			{
				_MoveDataTable.Columns.Add(new DataColumn(fgrid_POrder[0, i].ToString(), Type.GetType("System.String")));
			}
			//-------------------------------------------------------------------------------------------  
			



			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_EFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);   
			cmb_EFactory.SelectedValue = ClassLib.ComVar.This_Factory;


		}




		
		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			 
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{ 
				if(arg_fgrid.Equals(fgrid_EOrder))
				{
						
					//arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;

					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = "";
			

					//OA 발생 req_no 표시
					if(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSEM_REQ_BSC.IxOA_NU].ToString() != "__________"
						&& arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSEM_REQ_BSC.IxPLAN_OAAPP_DIV].ToString() == "R")
					{
						arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
						arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrOA;
					}

					//이미 계획에 반영된 데이터인 경우
					if(Convert.ToBoolean(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSEM_REQ_BSC.IxCHECK_FLAG]) )
					{
						arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = _YetCheck_Div;
						arg_fgrid.Rows[fgrid_EOrder.Rows.Count - 1].AllowEditing = false; 

						//OA 발생 req_no 표시된것은 Row 색 바꾸지 않음
						if(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSEM_REQ_BSC.IxOA_NU].ToString() != "__________"
							&& arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSEM_REQ_BSC.IxPLAN_OAAPP_DIV].ToString() == "R") continue;

						//arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrLightSel;

					}   
				}


				if(arg_fgrid.Equals(fgrid_POrder))
				{
						
					//arg_fgrid.Cols.Count = arg_dt.Columns.Count;

					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = "";
			

					//LOT으로 구성되지 않은 REQ_NO에 대해서만 삭제 가능 (오더 접수 취소 가능) 
					//lot 구성된 req 표시
					if(Convert.ToBoolean(fgrid_POrder[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPO_RECV_BSC.IxLOT_DIV].ToString()))
					{
						arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 0).StyleNew.BackColor = ClassLib.ComVar.ClrDisableHead;
					}

					//OA 발생 req_no 표시
					if(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPO_RECV_BSC.IxOA_NU].ToString() != "__________"
						&& arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPO_RECV_BSC.IxPLAN_OAAPP_DIV].ToString() == "R")
					{
						arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
						arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrOA;
					} 

 					

					//order 수량 != sum(사이즈별 order 수량) : 경고표시
					if(Convert.ToInt32(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPO_RECV_BSC.IxTOT_QTY].ToString())
						!= Convert.ToInt32(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPO_RECV_BSC.IxTOT_SUM_QTY].ToString()) )
					{
						arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
					}
					

				}

			} // end for i


			///////////////////////////////////////////////////
			//속성정의
			///////////////////////////////////////////////////
				
			arg_fgrid.AllowMerging = AllowMergingEnum.Free;
			for(int i = 0; i < arg_fgrid.Cols.Count; i++) arg_fgrid.Cols[i].AllowMerging = false;
			arg_fgrid.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
			arg_fgrid.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
			arg_fgrid.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
			arg_fgrid.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;
			arg_fgrid.Styles[CellStyleEnum.Subtotal2].BackColor = ClassLib.ComVar.ClrSubTotal2;
			arg_fgrid.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Black;
			arg_fgrid.Styles[CellStyleEnum.Subtotal3].BackColor = ClassLib.ComVar.ClrSubTotal3;
			arg_fgrid.Styles[CellStyleEnum.Subtotal3].ForeColor = Color.Black;


			if(arg_fgrid.Equals(fgrid_EOrder))
			{
					
				arg_fgrid.Cols[(int)ClassLib.TBSEM_REQ_BSC.IxMODEL_NAME].AllowMerging = true;
				arg_fgrid.Cols[(int)ClassLib.TBSEM_REQ_BSC.IxSTYLE_CD].AllowMerging = true;

				arg_fgrid.Tree.Column = (int)ClassLib.TBSEM_REQ_BSC.IxMODEL_NAME;
				arg_fgrid.Subtotal(AggregateEnum.Clear); 
				arg_fgrid.SubtotalPosition = SubtotalPositionEnum.AboveData; 
				
				arg_fgrid.Subtotal(AggregateEnum.Sum, 3, (int)ClassLib.TBSEM_REQ_BSC.IxSTYLE_CD, (int)ClassLib.TBSEM_REQ_BSC.IxTOT_QTY, " {0}");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSEM_REQ_BSC.IxMODEL_NAME, (int)ClassLib.TBSEM_REQ_BSC.IxTOT_QTY, " {0}");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSEM_REQ_BSC.IxCHECK_FLAG, (int)ClassLib.TBSEM_REQ_BSC.IxTOT_QTY, "");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 0, -1, (int)ClassLib.TBSEM_REQ_BSC.IxTOT_QTY, "Total");

				arg_fgrid.AutoSizeCols((int)ClassLib.TBSEM_REQ_BSC.IxMODEL_NAME + 1, arg_fgrid.Cols.Count - 1, 0);
			

			}
			else if(arg_fgrid.Equals(fgrid_POrder))
			{
				arg_fgrid.Cols[(int)ClassLib.TBSPO_RECV_BSC.IxMODEL_NAME].AllowMerging = true;
				arg_fgrid.Cols[(int)ClassLib.TBSPO_RECV_BSC.IxSTYLE_CD].AllowMerging = true;

				arg_fgrid.Tree.Column = (int)ClassLib.TBSPO_RECV_BSC.IxMODEL_NAME;
				arg_fgrid.Subtotal(AggregateEnum.Clear); 
				arg_fgrid.SubtotalPosition = SubtotalPositionEnum.AboveData; 

				arg_fgrid.Subtotal(AggregateEnum.Sum, 3, (int)ClassLib.TBSPO_RECV_BSC.IxSTYLE_CD, (int)ClassLib.TBSPO_RECV_BSC.IxTOT_QTY, "{0}");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSPO_RECV_BSC.IxMODEL_NAME, (int)ClassLib.TBSPO_RECV_BSC.IxTOT_QTY, "{0}"); 
				arg_fgrid.Subtotal(AggregateEnum.Sum, 0, -1, (int)ClassLib.TBSPO_RECV_BSC.IxTOT_QTY, "Total");
				
				
				arg_fgrid.AutoSizeCols((int)ClassLib.TBSPO_RECV_BSC.IxMODEL_NAME + 1, arg_fgrid.Cols.Count - 1, 0);

			}
 
 
		}






		#endregion

		#region 툴바 이벤트 메서드
		

		private void Event_Tbtn_New()
		{

			chk_AllSelect.Checked = false;
			chk_AllDelete.Checked = false;
			fgrid_EOrder.Rows.Count = fgrid_EOrder.Rows.Fixed;
			fgrid_POrder.Rows.Count = fgrid_POrder.Rows.Fixed;

		}

		private void Event_Tbtn_Search()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;

				if (cmb_EFactory.SelectedIndex == -1 || cmb_EDate.SelectedIndex == -1) return;
 


				chk_AllSelect.Checked = false;
				chk_AllDelete.Checked = false;
				fgrid_EOrder.Rows.Count = fgrid_EOrder.Rows.Fixed;
				fgrid_POrder.Rows.Count = fgrid_POrder.Rows.Fixed;


				string factory = cmb_EFactory.SelectedValue.ToString();
				string obs_id = cmb_EDate.SelectedValue.ToString();
				string obs_type = ClassLib.ComFunction.Empty_Combo(cmb_EObsType, " ");
				string style_cd = txt_StyleCd.Text.Replace("-", "");

//				DataTable dt_ret = Select_SEM_REQ(factory, obs_id, obs_type, style_cd);
//				Display_Grid(dt_ret, fgrid_EOrder); 
// 
//				dt_ret = Select_SPO_RECV(factory, obs_id, obs_type, style_cd);
//				Display_Grid(dt_ret, fgrid_POrder);  

				DataSet ds_ret = Select_SEM_REQ_SPO_RECV(factory, obs_id, obs_type, style_cd);
				Display_Grid(ds_ret.Tables[0], fgrid_EOrder); 
				Display_Grid(ds_ret.Tables[1], fgrid_POrder); 


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
 
		private void Event_Tbtn_Save()
		{
 
			bool save_flag = false;  
 
			  
			//모델, 스타일 기본 정보 개발 테이블에서 자동으로 생산 테이블로 저장
			this.Cursor = Cursors.WaitCursor;
			Save_Auto_ModelStyle();  
			this.Cursor = Cursors.Default; 
			
			
			//스타일, 모델정보 등록 여부 체크
			this.Cursor = Cursors.WaitCursor;
			save_flag = Check_Style_ExistYN();
			this.Cursor = Cursors.Default; 

			if(!save_flag) 
			{ 
//				if(_StyleNoCount > 0)
//				{
//					ProdBase.Form_PB_Style pop_form = new ProdBase.Form_PB_Style();
//					pop_form.WindowState = FormWindowState.Normal;
//					pop_form.Show();
//				}

				if(_ModelNoCount > 0)
				{
					ProdBase.Form_PB_Model pop_form = new ProdBase.Form_PB_Model();
					pop_form.WindowState = FormWindowState.Normal;
					pop_form.Show();
				}

				
				return;
			} 

			this.Cursor = Cursors.WaitCursor;
			
			if(! Save_SPO_RECV() )
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				this.Cursor = Cursors.Default; 
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
				this.Cursor = Cursors.Default; 

				Event_Tbtn_Search();

				chk_AllSelect.Checked = false;
				chk_AllDelete.Checked = false;

			}

			

			


		} 

		#region 저장

		/// <summary>
		/// Save_Auto_ModelStyle : 
		/// </summary>
		/// <returns></returns>
		private bool Save_Auto_ModelStyle()
		{ 
			
			try 
			{ 
				
				string factory = cmb_EFactory.SelectedValue.ToString();


				DataTable dt_ret = Save_ModelTran(factory);
				
				Save_StyleTran(factory); 


				int dt_row = dt_ret.Rows.Count;

				if(dt_row > 0)
				{
					string message = "";

					int model_name = 1;

					for(int i=0; i<dt_row; i++)
					{
						message += dt_ret.Rows[i].ItemArray[model_name].ToString() + "\r\n";
					}


					ClassLib.ComFunction comfunc = new FlexAPS.ClassLib.ComFunction();
					comfunc.AutoWorkMessage(this.Name, "E001", message);
				}

				return true;

			}
			catch
			{
				return false;
			}

		}



		/// <summary>
		/// Check_Style_ExistYN : REQ_NO에 대한 스타일 코드가 기본 스타일 정보(spb_style, spb_model)에 등록되어 있는지 여부 체크
		/// </summary>
		/// <returns></returns>
		private bool Check_Style_ExistYN()
		{
			
			try
			{ 
				string factory = cmb_EFactory.SelectedValue.ToString();
				string style_cd = "";
				string exist = "";

				int count = 0;

				int findrow = fgrid_POrder.FindRow("I", fgrid_POrder.Rows.Fixed, 0, false, true, false);

				// 새로 insert 하는 행이 없을때
				if(findrow == -1) return true;

				for(int i = findrow; i < fgrid_POrder.Rows.Count; i++)
				{
					style_cd = fgrid_POrder[i, (int)ClassLib.TBSPO_RECV_BSC.IxSTYLE_CD].ToString();
					exist = Select_Style_ExistYN(factory, style_cd);
 
					
					//스타일 코드 등록 안되어 있는 경우
					switch(exist.Substring(0, 1))   // 스타일에서 없는지, 모델에서 없는지 체크
					{
						case "S":
							// 스타일 코드에 정보 있을 경우 
							//if(exist.Substring(1, 1) == "Y") return true; 
							break;

						case "M":
							//스타일 코드에 정보 없을 경우

							// 1. 스타일코드에만 없을 경우
							if(exist.Substring(1, 1) == "Y") 
							{
								fgrid_POrder.Rows[i].StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow; 
								_StyleNoCount++;
							}
								// 2. 모델코드부터 없을 경우
							else 
							{
								fgrid_POrder.Rows[i].StyleNew.BackColor = ClassLib.ComVar.ClrSel_Green; 
								_ModelNoCount++;
							}

							count++;

							break;

					}
				} // end for i


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


		private void Event_Tbtn_Delete()
		{

			string req_no = "";

			int sel_r1 = fgrid_POrder.Selection.r1;
			int sel_r2 = fgrid_POrder.Selection.r2; 
			int start_row = 0, end_row = 0;

			int findrow = -1;

			start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
			end_row = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

			for(int i = end_row; i >= start_row; i--)
			{
				if(fgrid_POrder[i, 0] == null) continue;


				//OA 발생 req_no 표시
				if(fgrid_POrder[i, (int)ClassLib.TBSPO_RECV_BSC.IxOA_NU].ToString() != "__________"
					&& fgrid_POrder[i, (int)ClassLib.TBSPO_RECV_BSC.IxOA_FLAG].ToString() != "_")
				{
					continue;
				} 




				if(fgrid_POrder[i, 0].ToString() == "I")
				{
					req_no = fgrid_POrder[i, (int)ClassLib.TBSPO_RECV_BSC.IxREQ_NO].ToString();
					fgrid_POrder.Rows.Remove(i); 

					//오더 접수 취소되었으므로 체크박스 에디트 가능상태로 전환
					findrow = fgrid_EOrder.FindRow(req_no, fgrid_EOrder.Rows.Fixed, (int)ClassLib.TBSEM_REQ_BSC.IxREQ_NO, false, true, false);
					fgrid_EOrder[findrow, 0] = "";
					fgrid_EOrder[findrow, (int)ClassLib.TBSEM_REQ_BSC.IxCHECK_FLAG] = "FALSE";
					
				}
				else
				{
					//if(fgrid_POrder[i, 0].ToString() == "N") continue;

					//lot으로 생성된 req는 삭제 불가능
					if(Convert.ToBoolean(fgrid_POrder[i, (int)ClassLib.TBSPO_RECV_BSC.IxLOT_DIV].ToString())) continue;

					fgrid_POrder[i, 0] = "D";
				}

			}  
 

		}


		#endregion

		#region 그리드 이벤트 메서드
 

		#endregion

		#region 버튼 및 기타 이벤트
 

		/// <summary>
		/// Make_MoveDataTable : 체크된 오더에 대해서 데이터테이블로 구성
		/// </summary>
		private void Make_MoveDataTable()
		{
			DataRow newrow; 
 
			//이미 오더 접수된 req_no에 대해서는 데이터테이블을 만들지 않음 

			//int findrow = fgrid_EOrder.FindRow("TRUE", fgrid_EOrder.Rows.Fixed, (int)ClassLib.TBSEM_REQ_BSC.IxCHECK_FLAG, false, true, false);
			//if(findrow == -1) return;

			for(int i = fgrid_EOrder.Rows.Fixed; i < fgrid_EOrder.Rows.Count; i++)
			{
				if(fgrid_EOrder[i, 0] == null) continue;
				if(fgrid_EOrder[i, 0].ToString() == _YetCheck_Div) continue;
				if(!(Convert.ToBoolean(fgrid_EOrder[i, (int)ClassLib.TBSEM_REQ_BSC.IxCHECK_FLAG].ToString()))) continue;

				newrow = _MoveDataTable.NewRow();

				newrow[0] = "I";
				newrow[1] = "N";  // del_yn
			
				for(int j = (int)ClassLib.TBSEM_REQ_BSC.IxFACTORY; j <= (int)ClassLib.TBSEM_REQ_BSC.IxPLAN_OAAPP_YMD; j++)
				{
					newrow[j - (int)ClassLib.TBSEM_REQ_BSC.IxFACTORY + 2] = fgrid_EOrder[i, j].ToString();
				}
							
				newrow[(int)ClassLib.TBSPO_RECV_BSC.IxLOT_DIV] = "FALSE";
				
				newrow[(int)ClassLib.TBSPO_RECV_BSC.IxLOT_REMAINQTY] = 
					(fgrid_EOrder[i, (int)ClassLib.TBSEM_REQ_BSC.IxTOT_QTY] == null) ? "" : fgrid_EOrder[i, (int)ClassLib.TBSEM_REQ_BSC.IxTOT_QTY].ToString(); 
				
				newrow[(int)ClassLib.TBSPO_RECV_BSC.IxLOT_LOSS_REMAINQTY] = 
					(fgrid_EOrder[i, (int)ClassLib.TBSEM_REQ_BSC.IxTOT_SUM_LOSS_QTY] == null) ? "" : fgrid_EOrder[i, (int)ClassLib.TBSEM_REQ_BSC.IxTOT_SUM_LOSS_QTY].ToString();
				 


				_MoveDataTable.Rows.Add(newrow);

				fgrid_EOrder[i, 0] = _YetCheck_Div;
			}

			 
		}



		#endregion

		#region 컨텍스트 메뉴 이벤트
 


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


		
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Tbtn_Delete();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		#endregion

		#region 그리드 이벤트



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

		
		
		private void cmb_EFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 

				if (cmb_EFactory.SelectedIndex == -1) return;

				fgrid_EOrder.Rows.Count = fgrid_EOrder.Rows.Fixed;
				fgrid_POrder.Rows.Count = fgrid_POrder.Rows.Fixed;

			
				DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_EFactory.SelectedValue.ToString(), ClassLib.ComVar.CxOBS_Type);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_EObsType, 1, 2, true, COM.ComVar.ComboList_Visible.Code);  
				
				if(cmb_EObsType.ListCount != 0) 
				{
					cmb_EObsType.SelectedIndex = 0;  
				}
		

				dt_ret = ClassLib.ComFunction.Select_DPO(cmb_EFactory.SelectedValue.ToString(), "E"); 
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_EDate, 0, 0, false, COM.ComVar.ComboList_Visible.Code);  

				if(cmb_EDate.ListCount != 0) 
				{
					cmb_EDate.SelectedIndex = 0;
				}


				dt_ret.Dispose();



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_EFactory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		private void cmb_EDate_SelectedValueChanged(object sender, System.EventArgs e)
		{
		

			try
			{ 
 
				fgrid_EOrder.Rows.Count = fgrid_EOrder.Rows.Fixed;
				fgrid_POrder.Rows.Count = fgrid_POrder.Rows.Fixed;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_EDate_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		private void cmb_EObsType_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 
 
				fgrid_EOrder.Rows.Count = fgrid_EOrder.Rows.Fixed;
				fgrid_POrder.Rows.Count = fgrid_POrder.Rows.Fixed;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_EObsType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		private void txt_StyleCd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
		
			try
			{ 
 
				//13 : enter
				if(e.KeyChar != (char)13) return; 
				
				if (cmb_EFactory.SelectedIndex == -1 || cmb_EDate.SelectedIndex == -1) return;

				Event_Tbtn_Search(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyPress", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		} 

		private void chk_AllSelect_CheckedChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 
 
				for(int i = fgrid_EOrder.Rows.Fixed; i < fgrid_EOrder.Rows.Count; i++)
				{
					if(fgrid_EOrder[i, 0] == null) continue;
					if(fgrid_EOrder[i, 0].ToString() == _YetCheck_Div) continue;
					//if(!(Convert.ToBoolean(fgrid_EOrder[i, (int)ClassLib.TBSEM_REQ_BSC.IxCHECK_FLAG].ToString()))) continue;

					if(chk_AllSelect.Checked)
					{
						fgrid_EOrder[i, (int)ClassLib.TBSEM_REQ_BSC.IxCHECK_FLAG] = "TRUE";
					}
					else
					{
						fgrid_EOrder[i, (int)ClassLib.TBSEM_REQ_BSC.IxCHECK_FLAG] = "FALSE";
					}

				} 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "chk_AllSelect_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void chk_AllDelete_CheckedChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 
 

				string req_no = "";  
				int findrow = -1;


				if(chk_AllDelete.Checked)
				{
					

					for(int i = fgrid_POrder.Rows.Count - 1; i >= fgrid_POrder.Rows.Fixed; i--)
					{
						if(fgrid_POrder[i, 0] == null) continue;


						//OA 발생 req_no 표시
						if(fgrid_POrder[i, (int)ClassLib.TBSPO_RECV_BSC.IxOA_NU].ToString() != "__________"
							&& fgrid_POrder[i, (int)ClassLib.TBSPO_RECV_BSC.IxOA_FLAG].ToString() != "_")
						{
							continue;
						} 

						if(fgrid_POrder[i, 0].ToString() == "I")
						{
							req_no = fgrid_POrder[i, (int)ClassLib.TBSPO_RECV_BSC.IxREQ_NO].ToString();
							fgrid_POrder.Rows.Remove(i); 

							//오더 접수 취소되었으므로 체크박스 에디트 가능상태로 전환
							findrow = fgrid_EOrder.FindRow(req_no, fgrid_EOrder.Rows.Fixed, (int)ClassLib.TBSEM_REQ_BSC.IxREQ_NO, false, true, false);
							fgrid_EOrder[findrow, 0] = "";
							fgrid_EOrder[findrow, (int)ClassLib.TBSEM_REQ_BSC.IxCHECK_FLAG] = "FALSE";
					
						}
						else
						{
							//if(fgrid_POrder[i, 0].ToString() == "N") continue;

							//lot으로 생성된 req는 삭제 불가능
							if(Convert.ToBoolean(fgrid_POrder[i, (int)ClassLib.TBSPO_RECV_BSC.IxLOT_DIV].ToString())) continue;

							fgrid_POrder[i, 0] = "D";
						}

					}  

				} // if(chk_AllSelect.Checked)
				else
				{
					for(int i = fgrid_POrder.Rows.Fixed; i < fgrid_POrder.Rows.Count; i++)
					{
						if(fgrid_POrder[i, 0] == null) continue; 

						if(fgrid_POrder[i, 0].ToString() == "D") fgrid_POrder[i, 0] = "";
					}

				} 



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "chk_AllDelete_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		#region 컬럼 자동 소트 클래스

		/// <summary>
		/// MyComparer
		/// compares two grid rows using all columns
		/// </summary>
		public class MyComparer : IComparer
		{
			C1FlexGrid _flex;
			public MyComparer(C1FlexGrid flex)
			{
				_flex = flex;
			}
			int IComparer.Compare(object x, object y)
			{
				// get row indices
				int r1 = ((Row)x).Index;
				int r2 = ((Row)y).Index;

				// scan all columns looking for differences
				for (int c = 0; c < _flex.Cols.Count; c++)
				{
					// get display values
					string s1 = _flex.GetDataDisplay(r1, c);
					string s2 = _flex.GetDataDisplay(r2, c);

					// compare, done when a difference is found
					int cmp = string.Compare(s1, s2);
					if (cmp != 0) return cmp;
				}

				// all values are the same, use row indices
				// to keep sort stable
				return r1 - r2;
			}
		}


		#endregion 


		private void btn_OrderRecv_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				if(fgrid_EOrder.Rows.Count <= fgrid_EOrder.Rows.Fixed) return;  
 

				//fgrid_EOrder.Sort(new MyComparer(fgrid_EOrder)); 

				//체크된 오더에 대해서 데이터테이블로 구성
				Make_MoveDataTable(); 

				if(_MoveDataTable.Rows.Count == 0) return; 

				for(int i = 0; i < _MoveDataTable.Rows.Count; i++)
				{   
					fgrid_POrder.AddItem(_MoveDataTable.Rows[i].ItemArray, fgrid_POrder.Rows.Count, 0);
				
				} // end for i

				_MoveDataTable.Clear();
 
				fgrid_POrder.TopRow = fgrid_POrder.Rows.Count;
				fgrid_POrder.AutoSizeCols((int)ClassLib.TBSPO_RECV_BSC.IxMODEL_NAME + 1, fgrid_POrder.Cols.Count - 1, 0);
 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_OrderRecv_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		#endregion  
		
		#region 컨텍스트 메뉴 이벤트


		private void menuItem_AddLoss_Click(object sender, System.EventArgs e)
		{
		
			try
			{
			
				ProdOrder.Form_PO_OrderRecv_Loss pop_form = new ProdOrder.Form_PO_OrderRecv_Loss();

				ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_EFactory.SelectedValue.ToString(),
																   fgrid_POrder[fgrid_POrder.Selection.r1, (int)ClassLib.TBSPO_RECV_BSC.IxREQ_NO].ToString()};

				pop_form.ShowDialog();



				string factory = cmb_EFactory.SelectedValue.ToString();
				string obs_id = cmb_EDate.SelectedValue.ToString();
				string obs_type = ClassLib.ComFunction.Empty_Combo(cmb_EObsType, " ");
				string style_cd = txt_StyleCd.Text.Replace("-", ""); 

//				DataTable dt_ret = Select_SPO_RECV(factory, obs_id, obs_type, style_cd);
//				Display_Grid(dt_ret, fgrid_POrder); 

				DataSet ds_ret = Select_SEM_REQ_SPO_RECV(factory, obs_id, obs_type, style_cd); 
				Display_Grid(ds_ret.Tables[1], fgrid_POrder); 




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_AddLoss_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}


		#endregion


		#endregion 

		#region 디비 연결



		#region 조회


		/// <summary>
		/// Select_SEM_REQ : 수출 생산 의뢰 마스터 리스트 찾기 (SEM_REQ)
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_obs_id"></param>
		/// <param name="arg_obs_type"></param>
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		private DataTable Select_SEM_REQ(string arg_factory, string arg_obs_id, string arg_obs_type, string arg_style_cd)
		{ 
			
			try
			{ 

				DataSet ds_ret;
				string process_name = "PKG_SPO_ORDER_BSC.SELECT_SEM_REQ";


				MyOraDB.ReDim_Parameter(5); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";  
				MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE"; 
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_obs_id;
				MyOraDB.Parameter_Values[2] = arg_obs_type; 
				MyOraDB.Parameter_Values[3] = arg_style_cd;  
				MyOraDB.Parameter_Values[4] = ""; 

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
		/// Select_SPO_RECV : 생산 계획 오더 접수 리스트 찾기 (SPO_RECV)
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_obs_id"></param>
		/// <param name="arg_obs_type"></param>
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		private DataTable Select_SPO_RECV(string arg_factory, string arg_obs_id, string arg_obs_type, string arg_style_cd)
		{ 
		
			try
			{ 

				DataSet ds_ret;
				string process_name = "PKG_SPO_ORDER_BSC.SELECT_SPO_RECV";


				MyOraDB.ReDim_Parameter(5); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";  
				MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE"; 
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_obs_id;
				MyOraDB.Parameter_Values[2] = arg_obs_type; 
				MyOraDB.Parameter_Values[3] = arg_style_cd;  
				MyOraDB.Parameter_Values[4] = ""; 

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
		/// Select_SEM_REQ_SPO_RECV : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_obs_id"></param>
		/// <param name="arg_obs_type"></param>
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		private DataSet Select_SEM_REQ_SPO_RECV(string arg_factory, string arg_obs_id, string arg_obs_type, string arg_style_cd)
		{ 
			
			try
			{ 

				DataSet ds_ret;
				string process_name = "PKG_SPO_ORDER_BSC.SELECT_SEM_REQ";


				MyOraDB.ReDim_Parameter(5); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";  
				MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE"; 
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_obs_id;
				MyOraDB.Parameter_Values[2] = arg_obs_type; 
				MyOraDB.Parameter_Values[3] = arg_style_cd;  
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
 



				process_name = "PKG_SPO_ORDER_BSC.SELECT_SPO_RECV";


				MyOraDB.ReDim_Parameter(5); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";  
				MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE"; 
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_obs_id;
				MyOraDB.Parameter_Values[2] = arg_obs_type; 
				MyOraDB.Parameter_Values[3] = arg_style_cd;  
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(false); 


				ds_ret = MyOraDB.Exe_Select_Procedure();
				if(ds_ret == null) return null ; 
				return ds_ret; 

			}
			catch
			{
				return null;
			} 
		}


		#endregion

		#region 저장


		/// <summary>
		/// Save_ModelTran : 신규 모델 자동 저장 -> 신규 모델 리스트 리턴
		/// </summary>
		/// <returns></returns>
		private DataTable Save_ModelTran(string arg_factory)
		{
			DataSet ds_ret;

			try
			{
				MyOraDB.ReDim_Parameter(3); 
  
				string process_name = "PKG_SPO_ORDER_BSC.TRANS_MODEL";
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";  
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory;  
				MyOraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;
				MyOraDB.Parameter_Values[2] = ""; 

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
		/// Save_StyleTran : 신규 스타일 자동 저장
		/// </summary>
		/// <returns></returns>
		private bool Save_StyleTran(string arg_factory)
		{
			try
			{
				MyOraDB.ReDim_Parameter(2);
				MyOraDB.Process_Name = "PKG_SPO_ORDER_BSC.TRANS_STYLE";

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
			
				MyOraDB.Parameter_Values[0] = arg_factory;  
				MyOraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;  

				MyOraDB.Add_Modify_Parameter(true);	 
				MyOraDB.Exe_Modify_Procedure();	 
				return true;
			}
			catch
			{
				return false;
			}
		}


		/// <summary>
		/// Select_Style_ExistYN : DB에서 스타일 코드 등록 여부값 추출
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <returns></returns>
		private string Select_Style_ExistYN(string arg_factory, string arg_stylecd)
		{
		
			try
			{ 
				
				DataSet ds_ret;
				string process_name = "PKG_SPO_ORDER_BSC.SELECT_STYLE_EXISTYN";

				MyOraDB.ReDim_Parameter(3); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";  
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_stylecd;  
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ;
			
				return ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString(); 
			}
			catch
			{
				return null;
			}
		}



		/// <summary>
		/// SPO_RECV : 
		/// </summary>
		private bool Save_SPO_RECV()
		{
			
			try
			{
				//int col_ct = fgrid_POrder.Cols.Count;	    // 칼럼의 수
				
				int col_ct = fgrid_POrder.Cols.Count - 5;

				int row_fixed = fgrid_POrder.Rows.Fixed;						// 그리드 고정행 값
				int count = 0, save_ct =0 ;											// 저장 행 수
 
				int para_ct =0;												// 파라미터 값의 저장 배열의 수
				int row,col;


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPO_ORDER_BSC.SAVE_SPO_RECV";

				// 파라미터 이름 설정 
				MyOraDB.Parameter_Name[count] = "ARG_DIVISION"; 
				count++;
				for(int i = 1; i < fgrid_POrder.Cols.Count; i++)
				{ 
					if(i == (int)ClassLib.TBSPO_RECV_BSC.IxOGAC) continue; 
					if(i == (int)ClassLib.TBSPO_RECV_BSC.IxMODEL_NAME) continue; 
					if(i == (int)ClassLib.TBSPO_RECV_BSC.IxTOT_SUM_QTY) continue;
					if(i == (int)ClassLib.TBSPO_RECV_BSC.IxSUM_QTY) continue;
					if(i == (int)ClassLib.TBSPO_RECV_BSC.IxUPD_YMD) continue;

					MyOraDB.Parameter_Name[count] = "ARG_" + fgrid_POrder[0, i].ToString(); 
					count++;
				} 
 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 	 
	
				}
	
				// 저장 행 수 구하기
				for(int i = row_fixed ; i < fgrid_POrder.Rows.Count; i++)
				{
					if(fgrid_POrder[i, 0] != null && fgrid_POrder[i, 0].ToString() != "") 
					{
						save_ct += 1; 
					}

				}
			
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct];


				// 각 행의 변경값 Setting
				for(row = row_fixed; row < fgrid_POrder.Rows.Count ; row++)
				{
					if(fgrid_POrder[row, 0] != null && fgrid_POrder[row, 0].ToString() != "")
					{  
						for(col = 0; col < fgrid_POrder.Cols.Count; col++)	// 각 열의 값 Setting
						{
							 
							if(col == (int)ClassLib.TBSPO_RECV_BSC.IxOGAC) continue; 
							if(col == (int)ClassLib.TBSPO_RECV_BSC.IxMODEL_NAME) continue;  
							if(col == (int)ClassLib.TBSPO_RECV_BSC.IxTOT_SUM_QTY) continue;
							if(col == (int)ClassLib.TBSPO_RECV_BSC.IxSUM_QTY) continue;
							if(col == (int)ClassLib.TBSPO_RECV_BSC.IxUPD_YMD) continue;

							// 데이터값 설정 
							if(fgrid_POrder.Cols[col].Style.DataType != null
								&& fgrid_POrder.Cols[col].DataType.Equals(typeof(bool)) )
							{
								fgrid_POrder[row, col] = (fgrid_POrder[row, col] == null) ? "False" : fgrid_POrder[row, col].ToString();
								MyOraDB.Parameter_Values[para_ct] = (fgrid_POrder[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							} 
							else
							{ 
								if(col == (int)ClassLib.TBSPO_RECV_BSC.IxUPD_USER) 
									MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User; 
								else 
									MyOraDB.Parameter_Values[para_ct] = (fgrid_POrder[row, col] == null) ? "" : fgrid_POrder[row,col].ToString();
								 
								para_ct ++;

							} // end if( 데이터값 설정 )	
		
						} // end for col 
					} // end if
				} // end for row

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
				MessageBox.Show( ex.Message,"Save_SPO_RECV",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}





		#endregion
 


		#endregion
 



	}
}

