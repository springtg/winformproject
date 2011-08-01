using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdPlan
{
	public class Pop_LOTDaily_Modify : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.DateTimePicker dpick_ToYMD;
		public System.Windows.Forms.DateTimePicker dpick_FromYMD;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_PlanYMD;
		public System.Windows.Forms.Panel pnl_Display;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Panel pnl_Body;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.Label btn_Commit;
		public System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Refresh;
		private System.Windows.Forms.ContextMenu cmenu_Copy;
		private System.Windows.Forms.MenuItem menuItem_Copy;
		private System.Windows.Forms.MenuItem menuItem_Paste;
		private System.Windows.Forms.MenuItem menuItem_Delete;
		private System.Windows.Forms.Label lbl_Qty;
		private System.Windows.Forms.TextBox txt_OrderQty;
		private System.Windows.Forms.TextBox txt_LossQty;
		private System.Windows.Forms.TextBox txt_SumQty;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Label lbl_Balance;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.TextBox txt_Balance;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자

		public Pop_LOTDaily_Modify()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		private FlexAPS.ProdPlan.Form_PO_LOTDaily _Parent_Form = null;

		public Pop_LOTDaily_Modify(FlexAPS.ProdPlan.Form_PO_LOTDaily arg_parent)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Parent_Form = arg_parent;

		}




		private string _Factory;
		private string _LOT;
		private string _OrderQty;
		private string _LossQty;

		public Pop_LOTDaily_Modify(string arg_factory, string arg_lot, string arg_orderqty, string arg_lossqty)
		{

			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();


			_Factory = arg_factory;
			_LOT = arg_lot;
			_OrderQty = arg_orderqty;
			_LossQty = arg_lossqty;

//			Init_Form();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_LOTDaily_Modify));
			this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
			this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.pnl_Display = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_SumQty = new System.Windows.Forms.TextBox();
			this.txt_LossQty = new System.Windows.Forms.TextBox();
			this.txt_OrderQty = new System.Windows.Forms.TextBox();
			this.lbl_Qty = new System.Windows.Forms.Label();
			this.btn_Refresh = new System.Windows.Forms.Label();
			this.btn_Commit = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.cmenu_Copy = new System.Windows.Forms.ContextMenu();
			this.menuItem_Copy = new System.Windows.Forms.MenuItem();
			this.menuItem_Paste = new System.Windows.Forms.MenuItem();
			this.menuItem_Delete = new System.Windows.Forms.MenuItem();
			this.lbl_Balance = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.txt_Balance = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Display.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
			this.img_Button.ImageSize = new System.Drawing.Size(60, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Location = new System.Drawing.Point(676, 3);
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 136);
			this.stbar.Name = "stbar";
			this.stbar.Size = new System.Drawing.Size(1002, 0);
			this.stbar.Visible = false;
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Text = "MPS - Modify Size Quantity";
			// 
			// dpick_ToYMD
			// 
			this.dpick_ToYMD.CustomFormat = "yyyyMMdd";
			this.dpick_ToYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ToYMD.Location = new System.Drawing.Point(226, 9);
			this.dpick_ToYMD.Name = "dpick_ToYMD";
			this.dpick_ToYMD.Size = new System.Drawing.Size(100, 22);
			this.dpick_ToYMD.TabIndex = 192;
			this.dpick_ToYMD.ValueChanged += new System.EventHandler(this.dpick_ToYMD_ValueChanged);
			// 
			// dpick_FromYMD
			// 
			this.dpick_FromYMD.CustomFormat = "yyyyMMdd";
			this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_FromYMD.Location = new System.Drawing.Point(111, 9);
			this.dpick_FromYMD.Name = "dpick_FromYMD";
			this.dpick_FromYMD.Size = new System.Drawing.Size(100, 22);
			this.dpick_FromYMD.TabIndex = 191;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(211, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 16);
			this.label1.TabIndex = 73;
			this.label1.Text = "~";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.ImageIndex = 0;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(10, 8);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 72;
			this.lbl_PlanYMD.Text = "Assy. Date";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_Display
			// 
			this.pnl_Display.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Display.Controls.Add(this.pnl_SearchImage);
			this.pnl_Display.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Display.DockPadding.Bottom = 5;
			this.pnl_Display.DockPadding.Left = 8;
			this.pnl_Display.DockPadding.Right = 8;
			this.pnl_Display.DockPadding.Top = 5;
			this.pnl_Display.Location = new System.Drawing.Point(0, 0);
			this.pnl_Display.Name = "pnl_Display";
			this.pnl_Display.Size = new System.Drawing.Size(1002, 43);
			this.pnl_Display.TabIndex = 193;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_Balance);
			this.pnl_SearchImage.Controls.Add(this.lbl_Balance);
			this.pnl_SearchImage.Controls.Add(this.txt_SumQty);
			this.pnl_SearchImage.Controls.Add(this.txt_LossQty);
			this.pnl_SearchImage.Controls.Add(this.txt_OrderQty);
			this.pnl_SearchImage.Controls.Add(this.lbl_Qty);
			this.pnl_SearchImage.Controls.Add(this.btn_Refresh);
			this.pnl_SearchImage.Controls.Add(this.btn_Commit);
			this.pnl_SearchImage.Controls.Add(this.btn_Cancel);
			this.pnl_SearchImage.Controls.Add(this.dpick_FromYMD);
			this.pnl_SearchImage.Controls.Add(this.label1);
			this.pnl_SearchImage.Controls.Add(this.dpick_ToYMD);
			this.pnl_SearchImage.Controls.Add(this.lbl_PlanYMD);
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
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 5);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(986, 33);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// txt_SumQty
			// 
			this.txt_SumQty.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_SumQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SumQty.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_SumQty.Location = new System.Drawing.Point(568, 8);
			this.txt_SumQty.MaxLength = 60;
			this.txt_SumQty.Name = "txt_SumQty";
			this.txt_SumQty.ReadOnly = true;
			this.txt_SumQty.Size = new System.Drawing.Size(55, 21);
			this.txt_SumQty.TabIndex = 288;
			this.txt_SumQty.Text = "";
			this.txt_SumQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txt_LossQty
			// 
			this.txt_LossQty.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LossQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LossQty.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LossQty.Location = new System.Drawing.Point(512, 8);
			this.txt_LossQty.MaxLength = 60;
			this.txt_LossQty.Name = "txt_LossQty";
			this.txt_LossQty.ReadOnly = true;
			this.txt_LossQty.Size = new System.Drawing.Size(55, 21);
			this.txt_LossQty.TabIndex = 287;
			this.txt_LossQty.Text = "";
			this.txt_LossQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txt_OrderQty
			// 
			this.txt_OrderQty.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OrderQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OrderQty.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OrderQty.Location = new System.Drawing.Point(456, 8);
			this.txt_OrderQty.MaxLength = 60;
			this.txt_OrderQty.Name = "txt_OrderQty";
			this.txt_OrderQty.ReadOnly = true;
			this.txt_OrderQty.Size = new System.Drawing.Size(55, 21);
			this.txt_OrderQty.TabIndex = 286;
			this.txt_OrderQty.Text = "";
			this.txt_OrderQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl_Qty
			// 
			this.lbl_Qty.ImageIndex = 0;
			this.lbl_Qty.ImageList = this.img_Label;
			this.lbl_Qty.Location = new System.Drawing.Point(336, 8);
			this.lbl_Qty.Name = "lbl_Qty";
			this.lbl_Qty.Size = new System.Drawing.Size(120, 21);
			this.lbl_Qty.TabIndex = 285;
			this.lbl_Qty.Text = "Order/ Loss/ Sum.";
			this.lbl_Qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Refresh.ImageIndex = 0;
			this.btn_Refresh.ImageList = this.img_Button;
			this.btn_Refresh.Location = new System.Drawing.Point(792, 6);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(60, 23);
			this.btn_Refresh.TabIndex = 284;
			this.btn_Refresh.Text = "Refresh";
			this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			this.btn_Refresh.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Refresh.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Commit
			// 
			this.btn_Commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Commit.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Commit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Commit.ImageIndex = 0;
			this.btn_Commit.ImageList = this.img_Button;
			this.btn_Commit.Location = new System.Drawing.Point(853, 6);
			this.btn_Commit.Name = "btn_Commit";
			this.btn_Commit.Size = new System.Drawing.Size(60, 23);
			this.btn_Commit.TabIndex = 283;
			this.btn_Commit.Text = "Apply";
			this.btn_Commit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
			this.btn_Commit.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Commit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Commit.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Commit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(914, 6);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(60, 23);
			this.btn_Cancel.TabIndex = 282;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(969, 8);
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
			this.picb_TR.Location = new System.Drawing.Point(970, -5);
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
			this.picb_TM.Size = new System.Drawing.Size(970, 32);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, -2);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(16, 8);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(970, 18);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 17);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(826, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 18);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 25);
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
			this.picb_MM.Size = new System.Drawing.Size(818, 0);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Bottom = 8;
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 43);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1002, 93);
			this.pnl_Body.TabIndex = 194;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.ContextMenu = this.cmenu_Copy;
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Column;
			this.fgrid_Main.Size = new System.Drawing.Size(986, 85);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:White;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 48;
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			// 
			// cmenu_Copy
			// 
			this.cmenu_Copy.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem_Copy,
																					   this.menuItem_Paste,
																					   this.menuItem_Delete});
			// 
			// menuItem_Copy
			// 
			this.menuItem_Copy.Index = 0;
			this.menuItem_Copy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.menuItem_Copy.ShowShortcut = false;
			this.menuItem_Copy.Text = "Copy";
			this.menuItem_Copy.Click += new System.EventHandler(this.menuItem_Copy_Click);
			// 
			// menuItem_Paste
			// 
			this.menuItem_Paste.Index = 1;
			this.menuItem_Paste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.menuItem_Paste.ShowShortcut = false;
			this.menuItem_Paste.Text = "Paste";
			this.menuItem_Paste.Click += new System.EventHandler(this.menuItem_Paste_Click);
			// 
			// menuItem_Delete
			// 
			this.menuItem_Delete.Index = 2;
			this.menuItem_Delete.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.menuItem_Delete.ShowShortcut = false;
			this.menuItem_Delete.Text = "Delete";
			this.menuItem_Delete.Click += new System.EventHandler(this.menuItem_Delete_Click);
			// 
			// lbl_Balance
			// 
			this.lbl_Balance.ImageIndex = 0;
			this.lbl_Balance.ImageList = this.img_SmallLabel;
			this.lbl_Balance.Location = new System.Drawing.Point(632, 8);
			this.lbl_Balance.Name = "lbl_Balance";
			this.lbl_Balance.Size = new System.Drawing.Size(53, 21);
			this.lbl_Balance.TabIndex = 289;
			this.lbl_Balance.Text = "Balance";
			this.lbl_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txt_Balance
			// 
			this.txt_Balance.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Balance.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Balance.Location = new System.Drawing.Point(685, 8);
			this.txt_Balance.MaxLength = 60;
			this.txt_Balance.Name = "txt_Balance";
			this.txt_Balance.ReadOnly = true;
			this.txt_Balance.Size = new System.Drawing.Size(55, 21);
			this.txt_Balance.TabIndex = 290;
			this.txt_Balance.Text = "";
			this.txt_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Pop_LOTDaily_Modify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1002, 136);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Display);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Pop_LOTDaily_Modify";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MPS - Modify Size Quantity";
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Load += new System.EventHandler(this.Pop_LOTDaily_Modify_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_Display, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Display.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 

		private string _LOTNo, _LOTSeq; 

		private int _TBDate_Row, _YMDRow, _DaySeqRow, _SizeRow; 
		private int _StatusRow, _FinishRow, _SaveFlagRow;
		private int _HoliYN_Row;

		private string _YMDDesc = "Date";
		private string _DaySeqDesc = "Day Seq.";
		private string _SizeDesc = "Size Qty."; 

		// 현재 LOT에 할당되어져 있는 MaxPlanYMD, dayseq
		private string _MaxPlanYMD; 
		private int _MaxDaySeq;

		// 다음 추가될 계획일자
		private string _NextPlanYMD;

		// copy한 데이터 저장 배열
		private string[] _CopyList;

		public bool _Save_Flag = false;



		//----------------------------------------------
		// 선적 구간 표시
		//---------------------------------------------- 
		public string _ShipDateF_20;  // 선적중
		public string _ShipDateT_20;
		public string _ShipDateF_30;  // 선적준비중
		public string _ShipDateT_30;
		public string _ShipDateF_40;  // 다음 선적 진행중
		public string _ShipDateT_40; 
		public string _ShipDateF_50; 

		public Color _ClrShipDate_20;
		public Color _ClrShipDate_30;
		public Color _ClrShipDate_40;   
		//----------------------------------------------



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
				this.Text = "MPS - Modify Size Quantity";
				lbl_MainTitle.Text = "MPS - Modify Size Quantity";
	   
				ClassLib.ComFunction.SetLangDic(this); 
				

				fgrid_Main.Set_Grid("SPO_LOT_DAILY_MODIFY", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_Main.Set_Action_Image(img_Action);
				fgrid_Main.Font = new Font("Verdana", 7);
				fgrid_Main.ExtendLastCol = false;
				fgrid_Main.AllowSorting = AllowSortingEnum.None;
				fgrid_Main.AllowDragging = AllowDraggingEnum.None;
				fgrid_Main.SelectionMode = SelectionModeEnum.CellRange; 


				fgrid_Main.Rows[1].Visible = false;
				fgrid_Main.Cols[0].Visible = false;
				fgrid_Main.Cols.Fixed = 2;

				
				
				Init_Control();



				// 계획일자 세팅, 사이즈 수량 표시 작업
				Display_Default_HeadDate();
				Display_Data();
  



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}



		private void Init_Control()
		{

			tbtn_New.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false;  
			tbtn_Print.Enabled = false; 

			dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_ToYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_FromYMD.Enabled = false;
 
 
			string[] token = _LOT.Split('-'); 
			_LOTNo = token[0];
			_LOTSeq = token[1]; 

			txt_OrderQty.Text = _OrderQty;
			txt_LossQty.Text = _LossQty;

		}



		#endregion

		#region 조회


		/// <summary>
		/// Display_Default_HeadDate : 
		/// </summary>
		private void Display_Default_HeadDate()
		{
			
			 
			DataTable dt_ret = Select_LOT_DAILY_YMD_BOUND(_Factory, _LOTNo, _LOTSeq);

			string min_planymd = dt_ret.Rows[0].ItemArray[0].ToString();
			string max_planymd = dt_ret.Rows[0].ItemArray[1].ToString(); 
			_MaxPlanYMD = max_planymd;

			// 검색조건 날짜 세팅
			dpick_FromYMD.Value = Convert.ToDateTime(MyComFunction.ConvertDate2Type(min_planymd));
  
			string to_date = Convert.ToDateTime(MyComFunction.ConvertDate2Type(max_planymd)).AddDays(10).ToString("yyyyMMdd");
			dpick_ToYMD.Value = Convert.ToDateTime(MyComFunction.ConvertDate2Type(to_date));
 

			// Description, 날짜 세팅 
			_HoliYN_Row = fgrid_Main.Rows.Fixed - 2;
			_TBDate_Row = fgrid_Main.Rows.Fixed - 1;
			_YMDRow = fgrid_Main.Rows.Fixed;
			_DaySeqRow = fgrid_Main.Rows.Fixed + 1; 
			_SizeRow = fgrid_Main.Rows.Fixed + 2; 
			_StatusRow = fgrid_Main.Rows.Fixed + 3; 
			_FinishRow = fgrid_Main.Rows.Fixed + 4;
			_SaveFlagRow = fgrid_Main.Rows.Fixed + 5; 
				
			fgrid_Main.Rows.Count = _SaveFlagRow + 1;
			fgrid_Main.Cols.Count = fgrid_Main.Cols.Fixed;
			fgrid_Main.Rows.Fixed = _SizeRow;
			fgrid_Main.Rows[_StatusRow].Visible = false;
			fgrid_Main.Rows[_FinishRow].Visible = false; 
			fgrid_Main.Rows[_SaveFlagRow].Visible = false;
			
			fgrid_Main[_DaySeqRow, fgrid_Main.Cols.Fixed - 1] = _DaySeqDesc;
			fgrid_Main[_YMDRow, fgrid_Main.Cols.Fixed - 1] = _YMDDesc;
			fgrid_Main[_SizeRow, fgrid_Main.Cols.Fixed - 1] = _SizeDesc;

			fgrid_Main.AutoSizeCol(fgrid_Main.Cols.Fixed - 1);


			 
		}


		/// <summary>
		/// Display_Data : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Data()
		{ 


			string factory = _Factory;
			string from_plan_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
			string to_plan_ymd = dpick_ToYMD.Value.ToString("yyyyMMdd");
			string lot_no = _LOTNo;
			string lot_seq = _LOTSeq;



			DataSet ds_ret = Select_LOT_DAILY_DATA(factory, from_plan_ymd, to_plan_ymd, lot_no, lot_seq); 
			DataTable ymd_dt = ds_ret.Tables[0];
			DataTable size_dt = ds_ret.Tables[1]; 

			Display_YMD(ymd_dt);
			Display_Size(size_dt);


			// poweruser 권한이면 작업 가능 처리
			if(ClassLib.ComVar.This_PowerUser_YN != "Y")
			{ 
				Check_Shipping_Area(); 
			} 
 
		}



		#region Display_Data 관련


		/// <summary>
		/// Check_Shipping_Area : 
		/// </summary>
		private void Check_Shipping_Area()
		{


			// LOT 이 모두 SHIPPING 40 이전에 배치되면 처리 가능. 



			string date = "";

			int free_count = 0;
			int shipping_count = 0;
			int col_ship_date_f_50 = -1;

			for(int i = fgrid_Main.Cols.Count - 1; i >= fgrid_Main.Cols.Fixed; i--)
			{

				if(fgrid_Main[_TBDate_Row, i] == null || fgrid_Main[_TBDate_Row, i].ToString() == "") continue;

				date = fgrid_Main[_TBDate_Row, i].ToString();

				if(Convert.ToInt32(date) == Convert.ToInt32(_ShipDateF_50) )
				{
					col_ship_date_f_50 = i;
				} 

				if(fgrid_Main[_SizeRow, i] == null || fgrid_Main[_SizeRow, i].ToString() == "" || fgrid_Main[_SizeRow, i].ToString() == "0") continue;
 
				if(Convert.ToInt32(date) > Convert.ToInt32(_ShipDateF_50) )
				{
					//if(fgrid_Main[_SizeRow, i] == null || fgrid_Main[_SizeRow, i].ToString() == "" || fgrid_Main[_SizeRow, i].ToString() == "0") continue;

					free_count++; 

				}   
				else
				{
					shipping_count++; 
				}


			}


			col_ship_date_f_50 = (col_ship_date_f_50 == -1) ? fgrid_Main.Cols.Count - 1 : col_ship_date_f_50;


			if(free_count == 0 || shipping_count == 0)
			{
				for(int i = fgrid_Main.Cols.Fixed + 1; i <= col_ship_date_f_50; i++)
				{
					fgrid_Main.Cols[i].AllowEditing = true;
				}

			}
			else
			{
				for(int i = fgrid_Main.Cols.Fixed; i <= col_ship_date_f_50; i++)
				{
					fgrid_Main.Cols[i].AllowEditing = false;
				}
			}


		}
 

		/// <summary>
		/// Display_YMD : 날짜 세팅
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_YMD(DataTable arg_dt)
		{

			fgrid_Main.Cols.Count = fgrid_Main.Cols.Fixed + arg_dt.Rows.Count;

			if(arg_dt.Rows.Count == 0) return;


			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_Main.Cols[i + fgrid_Main.Cols.Fixed].Width = 50;
				fgrid_Main.Cols[i + fgrid_Main.Cols.Fixed].TextAlign = TextAlignEnum.RightCenter;

 				//실제 날짜 표시
				fgrid_Main[_TBDate_Row, i + fgrid_Main.Cols.Fixed] 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString();
 					
				fgrid_Main[_YMDRow, i + fgrid_Main.Cols.Fixed] 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString().Substring(4, 2)
					+ ClassLib.ComVar.This_SetedDateSign
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString().Substring(6, 2);
    

				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHHOLI_YN].ToString() == "N")
				{
					//fgrid_Main[_DaySeqRow, i + fgrid_Main.Cols.Fixed] = dayseq.ToString();
					//dayseq++;
					
					fgrid_Main[_HoliYN_Row, i + fgrid_Main.Cols.Fixed] = "N";

				}
				else
				{
					//휴일 색깔 처리 
					fgrid_Main.Cols[i + fgrid_Main.Cols.Fixed].StyleNew.BackColor = ClassLib.ComVar.ClrDisableHead;
					fgrid_Main.Cols[i + fgrid_Main.Cols.Fixed].AllowEditing = false;

					fgrid_Main[_HoliYN_Row, i + fgrid_Main.Cols.Fixed] = "Y";
				} 

				//------------------------------------------------------------------------------------------------------ 
				string date = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString();


				if(! _ShipDateF_20.Trim().Equals("") && ! _ShipDateF_30.Trim().Equals("")
					&& Convert.ToInt32(date) >= Convert.ToInt32(_ShipDateF_20)
					&& Convert.ToInt32(date) < Convert.ToInt32(_ShipDateF_30) )
				{
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.BackColor = _ClrShipDate_20;
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.ForeColor = ClassLib.ComVar.Clr_Text_Blue; 

				} 

				if(! _ShipDateF_30.Trim().Equals("") && ! _ShipDateF_40.Trim().Equals("")
					&& Convert.ToInt32(date) >= Convert.ToInt32(_ShipDateF_30)
					&& Convert.ToInt32(date) < Convert.ToInt32(_ShipDateF_40) )
				{
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.BackColor = _ClrShipDate_30;
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.ForeColor = ClassLib.ComVar.Clr_Text_Blue; 

				} 

				if(! _ShipDateF_40.Trim().Equals("") && ! _ShipDateF_50.Trim().Equals("")
					&& Convert.ToInt32(date) >= Convert.ToInt32(_ShipDateF_40)
					&& Convert.ToInt32(date) < Convert.ToInt32(_ShipDateF_50) )
				{
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.BackColor = _ClrShipDate_40;
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.ForeColor = ClassLib.ComVar.Clr_Text_Blue; 

				} 

				//------------------------------------------------------------------------------------------------------ 


			}

			string todate = MyComFunction.ConvertDate2Type(arg_dt.Rows[arg_dt.Rows.Count - 1].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString());
			DateTime todate1 = Convert.ToDateTime(todate).AddDays(1);
			_NextPlanYMD = todate1.ToString("yyyyMMdd"); 

			 
		}


		/// <summary>
		/// Display_YMD_Add : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_YMD_Add(DataTable arg_dt)
		{
			 
			 
			if(arg_dt.Rows.Count == 0) return; 
			

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_Main.Cols.Add();
				fgrid_Main.Cols[fgrid_Main.Cols.Count - 1].Width = 50;
				fgrid_Main.Cols[fgrid_Main.Cols.Count - 1].TextAlign = TextAlignEnum.RightCenter;

				//실제 날짜 표시
				fgrid_Main[_TBDate_Row, fgrid_Main.Cols.Count - 1] 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString();
 					
				fgrid_Main[_YMDRow, fgrid_Main.Cols.Count - 1] 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString().Substring(4, 2)
					+ ClassLib.ComVar.This_SetedDateSign
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString().Substring(6, 2);
    

				//max_dayseq++;

				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHHOLI_YN].ToString() == "N")
				{
					//fgrid_Main[_DaySeqRow, fgrid_Main.Cols.Count - 1] = max_dayseq.ToString(); 
				}
				else
				{
					//휴일 색깔 처리 
					fgrid_Main.Cols[fgrid_Main.Cols.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrDisableHead;
					fgrid_Main.Cols[fgrid_Main.Cols.Count - 1].AllowEditing = false;
				} 

				//------------------------------------------------------------------------------------------------------ 
				string date = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString();


				if(! _ShipDateF_20.Trim().Equals("") && ! _ShipDateT_20.Trim().Equals("")
					&& Convert.ToInt32(date) >= Convert.ToInt32(_ShipDateF_20)
					&& Convert.ToInt32(date) <= Convert.ToInt32(_ShipDateT_20) )
				{
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.BackColor = _ClrShipDate_20;
				} 

				if(! _ShipDateF_30.Trim().Equals("") && ! _ShipDateT_30.Trim().Equals("")
					&& Convert.ToInt32(date) >= Convert.ToInt32(_ShipDateF_30)
					&& Convert.ToInt32(date) <= Convert.ToInt32(_ShipDateT_30) )
				{
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.BackColor = _ClrShipDate_30;
				} 

				if(! _ShipDateF_40.Trim().Equals("") && ! _ShipDateT_40.Trim().Equals("")
					&& Convert.ToInt32(date) >= Convert.ToInt32(_ShipDateF_40)
					&& Convert.ToInt32(date) <= Convert.ToInt32(_ShipDateT_40) )
				{
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.BackColor = _ClrShipDate_40;
				} 

				//------------------------------------------------------------------------------------------------------ 
					


			}

			string todate = MyComFunction.ConvertDate2Type(arg_dt.Rows[arg_dt.Rows.Count - 1].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString());
			DateTime todate1 = Convert.ToDateTime(todate).AddDays(1);
			_NextPlanYMD = todate1.ToString("yyyyMMdd");

			 
		}


		/// <summary>
		/// Display_Size : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Size(DataTable arg_dt)
		{
			 
			if(arg_dt.Rows.Count == 0) return;

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				for(int j = fgrid_Main.Cols.Fixed; j < fgrid_Main.Cols.Count; j++)
				{
					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDPLAN_YMD].ToString()
						== fgrid_Main[_TBDate_Row, j].ToString())
					{
						fgrid_Main[_DaySeqRow, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDDAY_SEQ].ToString();
						fgrid_Main[_SizeRow, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDSIZE_QTY].ToString();

						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDPLAN_STATUS].ToString() == "D")
						{
							fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, j, fgrid_Main.Rows.Count - 1, j).StyleNew.BackColor = ClassLib.ComVar.ClrRelease;
							fgrid_Main.Cols[j].AllowEditing = false; 
						}
						else
						{
							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDTS_FINISH_YN].ToString() == "Y")
							{
								fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, j, fgrid_Main.Rows.Count - 1, j).StyleNew.BackColor = ClassLib.ComVar.ClrFinishY;
								fgrid_Main.Cols[j].AllowEditing = false; 
							}
						}

						

						fgrid_Main[_StatusRow, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDPLAN_STATUS].ToString();
						fgrid_Main[_FinishRow, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDTS_FINISH_YN].ToString();


						break;
					}
				} // end for j
			} // end for i

			_MaxDaySeq = Convert.ToInt32(arg_dt.Rows[arg_dt.Rows.Count - 1].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDDAY_SEQ].ToString() );

			//사이즈 총합 계산
			Set_SumQty();

			
		}

		
 


		#endregion 

		#endregion 

		#region 그리드 이벤트 관련


		private void Event_AfterEdit_fgrid_Main(C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			bool digit_flag = COM.ComFunction.Check_Digit(fgrid_Main[e.Row, e.Col].ToString());

			if(! digit_flag) 
			{
				fgrid_Main[e.Row, e.Col] = ""; 
			}
			

			//수량 체크
			bool check_sum = Set_SumQty(); 

			//수정됨을 표시
			Set_SaveFlag(e.Col);

		}


		#region 수량 변경 관련

 
		/// <summary>
		/// Set_SumQty : 
		/// </summary>
		private bool Set_SumQty()
		{
			
			try
			{

				int sum = 0;


				for(int i = fgrid_Main.Cols.Fixed; i < fgrid_Main.Cols.Count; i++)
				{
					fgrid_Main[_SizeRow, i] = (fgrid_Main[_SizeRow, i] == null) ? "" : fgrid_Main[_SizeRow, i].ToString();

					if(fgrid_Main[_SizeRow, i].ToString() == "") continue;

					sum += Convert.ToInt32(fgrid_Main[_SizeRow, i].ToString() );
				}

				txt_SumQty.Text = sum.ToString();

				
				int orderqty = Convert.ToInt32(txt_OrderQty.Text);
				int lossqty = Convert.ToInt32(txt_LossQty.Text);
				int sumqty = Convert.ToInt32(txt_SumQty.Text);


				txt_Balance.Text = Convert.ToString( (orderqty + lossqty) - sumqty);


				if( (orderqty + lossqty) != sumqty)
				{
					txt_SumQty.ForeColor = ClassLib.ComVar.ClrWarning;
					txt_SumQty.Font = new Font(txt_SumQty.Font.FontFamily, txt_SumQty.Font.Size, FontStyle.Bold);
					//MessageBox.Show("Order Qty. Not Equal");
					return false;
				}
				else
				{
					txt_SumQty.ForeColor = Color.Black;
					txt_SumQty.Font = new Font(txt_SumQty.Font.FontFamily, txt_SumQty.Font.Size, FontStyle.Regular);
					return true;
				}


			}
			catch
			{
				return false;
			}
		}



		/// <summary>
		/// Set_SaveFlag : 
		/// </summary>
		/// <param name="arg_selcol"></param>
		private void Set_SaveFlag(int arg_selcol)
		{  
			 	

			fgrid_Main[_DaySeqRow, arg_selcol] = (fgrid_Main[_DaySeqRow, arg_selcol] == null) ? "" : fgrid_Main[_DaySeqRow, arg_selcol].ToString();
			fgrid_Main[_SizeRow, arg_selcol] = (fgrid_Main[_SizeRow, arg_selcol] == null) ? "" : fgrid_Main[_SizeRow, arg_selcol].ToString();
			
			//insert : dayseq 데이터 없고, 사이즈 수량 데이터 있을 경우
			if(fgrid_Main[_DaySeqRow, arg_selcol].ToString() == "")
			{
				if(fgrid_Main[_SizeRow, arg_selcol].ToString() == "0" || fgrid_Main[_SizeRow, arg_selcol].ToString() == "")
				{
					fgrid_Main[_SaveFlagRow, arg_selcol] = ""; 
				}
				else
				{
					fgrid_Main[_SaveFlagRow, arg_selcol] = "I"; 
				}
			}
				//update : dayseq 데이터 있는 상태에서, 수량 데이터 있을 경우 (수량변경)
				//delete : dayseq 데이터 있는 상태에서, 수량 데이터 없을 경우 (수량삭제)
			else
			{
				if(fgrid_Main[_SizeRow, arg_selcol].ToString() == "0" || fgrid_Main[_SizeRow, arg_selcol].ToString() == "")
				{
					fgrid_Main[_SaveFlagRow, arg_selcol] = "D";
				}
				else
				{
					fgrid_Main[_SaveFlagRow, arg_selcol] = "U";
				}
			}

			 
		}


		#endregion



		#endregion

		#region 버튼 및 기타 이벤트


		/// <summary>
		/// Event_Click_Refresh : 
		/// </summary>
		private void Event_Click_Refresh()
		{

//			//dayseq, size row clear
//			for(int i = fgrid_Main.Cols.Fixed; i < fgrid_Main.Cols.Count; i++)
//			{
//				fgrid_Main[_DaySeqRow, i] = "";
//				fgrid_Main[_SizeRow, i] = "";
//			}
//
//			DataSet ds_ret = Select_LOT_DAILY_DATA();   
//			Display_Size(ds_ret.Tables[0]); 


			// 계획일자 세팅, 사이즈 수량 표시 작업
			Display_Data();


		}

		/// <summary>
		/// Event_Click_Commit : 
		/// </summary>
		private void Event_Click_Commit()
		{

			//행 수정 상태 해제
			fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count-1, false);
 


			//수량 체크
			bool save_flag = Set_SumQty();
			if(!save_flag)
			{
				ClassLib.ComFunction.User_Message("Order Qty. Not Equal", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			//수정된 일자 데이터 표시 플래그 설정
			Set_Save_DaySeq(); 

			//수정될 데이터 저장 테이블 구성
			save_flag = Make_Save_DaySeq(); 


			if(!save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return;
			}
			else
			{ 
				// dayseq 갱신 
				save_flag = Make_RUN_RESET_DAYSEQ(_LOTNo + "-" + _LOTSeq, false);  
					
				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				else
				{  
					// leadtime 재전개
					save_flag = Make_RUN_LOT_MOVE_ADAPT_LEADTIME(false, _LOTNo, _LOTSeq);  
						
					if(!save_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
					else
					{  	
						//spo_lot 정보 수정 테이블 구성 - plan_strymd, plan_endymd, tot_day_seq 등 수정
						save_flag = Make_RUN_LOT_DIVIDE_UPDATE_LOT(false, _LOTNo + "-" + _LOTSeq, "-1");
 
						if(!save_flag)
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}
						else
						{   
							DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();
 
							if(ds_ret == null)
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
								return;
							}
							else
							{
						
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
								
								//save flag clear
								for(int i = fgrid_Main.Cols.Fixed; i < fgrid_Main.Cols.Count; i++) fgrid_Main[_SaveFlagRow, i] = "";
								//btn_Refresh_Click(null, null); 
								_Save_Flag = true;
								this.Close();
							}
 
						}  //spo_lot 정보 수정 테이블 구성 

					} // leadtime 재전개
				} // dayseq 갱신 
			}	//수정될 데이터 저장 테이블 구성  



		}


		#region 저장 관련
 

		/// <summary>
		/// Set_Save_DaySeq : 수정된 일자 데이터 표시 플래그 설정
		/// </summary>
		private void Set_Save_DaySeq()
		{
			
			for(int i = fgrid_Main.Cols.Fixed; i < fgrid_Main.Cols.Count; i++)
			{
				fgrid_Main[_StatusRow, i] = (fgrid_Main[_StatusRow, i] == null) ? "" : fgrid_Main[_StatusRow, i].ToString();
				if(fgrid_Main[_StatusRow, i].ToString() == "D") continue;

				fgrid_Main[_FinishRow, i] = (fgrid_Main[_FinishRow, i] == null) ? "" : fgrid_Main[_FinishRow, i].ToString();
				if(fgrid_Main[_FinishRow, i].ToString() == "Y") continue;

				fgrid_Main[_DaySeqRow, i] = (fgrid_Main[_DaySeqRow, i] == null) ? "" : fgrid_Main[_DaySeqRow, i].ToString();
				fgrid_Main[_SaveFlagRow, i] = (fgrid_Main[_SaveFlagRow, i] == null) ? "" : fgrid_Main[_SaveFlagRow, i].ToString();

				if(fgrid_Main[_SaveFlagRow, i].ToString() != "I") continue;

				_MaxDaySeq++;
				fgrid_Main[_DaySeqRow, i] = _MaxDaySeq.ToString();


			}

			 
		}
		
		#endregion


		/// <summary>
		/// Event_Click_Cancel : 
		/// </summary>
		private void Event_Click_Cancel()
		{

			if(!_Save_Flag) 
			{
				_Save_Flag = false;
			}

			this.Close();

		}




		private void Event_ValueChanged_dpick_ToYMD()
		{

			
			if(Convert.ToInt32(dpick_ToYMD.Value.ToString("yyyyMMdd")) < Convert.ToInt32(_MaxPlanYMD)) return;


			if(Convert.ToInt32(dpick_ToYMD.Value.ToString("yyyyMMdd")) < Convert.ToInt32(_NextPlanYMD))
			{
				for(int i = fgrid_Main.Cols.Fixed; i < fgrid_Main.Cols.Count; i++)
				{
					if(fgrid_Main[_TBDate_Row, i].ToString() == dpick_ToYMD.Value.ToString("yyyyMMdd") )
					{
						_NextPlanYMD = fgrid_Main[_TBDate_Row, i + 1].ToString();
						fgrid_Main.Cols.Count = i + 1;
							
						break;
					}
				}
			}
			else
			{

				string factory = _Factory;
				string from_plan_ymd = _NextPlanYMD;
				string to_plan_ymd = dpick_ToYMD.Value.ToString("yyyyMMdd");
				string lot_no = _LOTNo;
				string lot_seq = _LOTSeq;


				DataSet ds_ret = Select_LOT_DAILY_DATA(factory, from_plan_ymd, to_plan_ymd, lot_no, lot_seq);  
				Display_YMD_Add(ds_ret.Tables[0]); 
			}


		}




		#endregion

		#region 컨텍스트 메뉴 이벤트 (Copy/ Paste/ Delete)


		
		private void Event_Click_menuItem_Copy()
		{

			int c1 = fgrid_Main.Selection.c1;
			int c2 = fgrid_Main.Selection.c2;
			int start_col = 0, end_col = 0;

			 
			start_col = (c1 < c2) ? c1 : c2;
			end_col = (c1 > c2) ? c1 : c2;

			_CopyList = new string[end_col - start_col + 1];

			for(int i = start_col; i <= end_col; i++)
			{
				fgrid_Main[_SizeRow, i] = (fgrid_Main[_SizeRow, i] == null) ? "" : fgrid_Main[_SizeRow, i].ToString();

				_CopyList[i - start_col] = fgrid_Main[_SizeRow, i].ToString();
			}

			 


		}

		private void Event_Click_menuItem_Paste()
		{

			int sel_col = fgrid_Main.Selection.c1;

			 
//			for(int i = 0; i < _CopyList.Length; i++)
//			{
//				fgrid_Main[_SizeRow, i + sel_col] = _CopyList[i]; 
//				Set_SaveFlag(i + sel_col);
//
//				if(i + sel_col == fgrid_Main.Cols.Count - 1) break;
//
//			}


			// 휴일은 제외해서 적용
			int display_col = sel_col;
			int copy_list_count = 0;
	

			while(true)
			{

				if(fgrid_Main[_HoliYN_Row, display_col] == null || fgrid_Main[_HoliYN_Row, display_col].ToString() == "N")
				{
					fgrid_Main[_SizeRow, display_col] = _CopyList[copy_list_count];
					Set_SaveFlag(display_col);

					copy_list_count++;
					display_col++;
				}
				else
				{
					display_col++;
				}

				if(display_col == fgrid_Main.Cols.Count) break;
				if(copy_list_count == _CopyList.Length) break;

			} // end while


			//수량 체크
			Set_SumQty(); 

			 

		}

		private void Event_Click_menuItem_Delete()
		{

			int c1 = fgrid_Main.Selection.c1;
			int c2 = fgrid_Main.Selection.c2;
			int start_col = 0, end_col = 0;
 

			start_col = (c1 < c2) ? c1 : c2;
			end_col = (c1 > c2) ? c1 : c2;

			for(int i = start_col; i <= end_col; i++)
			{
				fgrid_Main[_StatusRow, i] = (fgrid_Main[_StatusRow, i] == null) ? "" : fgrid_Main[_StatusRow, i].ToString();
				if(fgrid_Main[_StatusRow, i].ToString() == "D") continue;

				fgrid_Main[_FinishRow, i] = (fgrid_Main[_FinishRow, i] == null) ? "" : fgrid_Main[_FinishRow, i].ToString();
				if(fgrid_Main[_FinishRow, i].ToString() == "Y") continue;


				fgrid_Main[_SizeRow, i] = ""; 

				fgrid_Main[_DaySeqRow, i] = (fgrid_Main[_DaySeqRow, i] == null) ? "" : fgrid_Main[_DaySeqRow, i].ToString();
				
				if(fgrid_Main[_DaySeqRow, i].ToString() == "")
				{
					fgrid_Main[_SaveFlagRow, i] = "";
				}
				else
				{
					fgrid_Main[_SaveFlagRow, i] = "D";
				}
			} // end for i

			//수량 체크
			Set_SumQty(); 

		}



		#endregion 

		#endregion

		#region 이벤트 처리

		#region 그리드 이벤트


		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			
			try
			{
				Event_AfterEdit_fgrid_Main(e);	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_AfterEdit_fgrid_Main", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		
		
		
		private void Pop_LOTDaily_Modify_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		 


		private void btn_Refresh_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_Refresh();	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_Refresh", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		
		private void btn_Commit_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_Commit();	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_Commit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_Cancel();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			
		}


		private void dpick_ToYMD_ValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_ValueChanged_dpick_ToYMD();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_ValueChanged_dpick_ToYMD", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		#endregion  

		#region 컨텍스트 메뉴 이벤트 (Copy/ Paste/ Delete)
 
		private void menuItem_Copy_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_menuItem_Copy();	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_Copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void menuItem_Paste_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_menuItem_Paste();	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void menuItem_Delete_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_menuItem_Delete();	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuItem_Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		#endregion 


		#endregion
 
		#region 디비 연결
 

		/// <summary>
		/// Select_LOT_DAILY_YMD_BOUND : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		private DataTable Select_LOT_DAILY_YMD_BOUND(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{  
			DataSet ds_ret;

			try
			{  
				string process_name = "PKG_SPO_MPS_BSC.SELECT_LOT_DAILY_YMD_BOUND";

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

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}
		}


		
		
		/// <summary>
		/// Select_LOT_DAILY_DATA : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_from_plan_ymd"></param>
		/// <param name="arg_to_plan_ymd"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		private DataSet Select_LOT_DAILY_DATA(string arg_factory, string arg_from_plan_ymd, string arg_to_plan_ymd, string arg_lot_no, string arg_lot_seq)
		{  
			
			try
			{ 
				DataSet ds_ret;


				// ymd 추출
				string process_name = "PKG_SPO_MPS_BSC.SELECT_LOT_DAILY_YMD";

				MyOraDB.ReDim_Parameter(4);  
				MyOraDB.Process_Name = process_name;
	 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_FROM_PLAN_YMD";  
				MyOraDB.Parameter_Name[2] = "ARG_TO_PLAN_YMD";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
					
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_from_plan_ymd;
				MyOraDB.Parameter_Values[2] = arg_to_plan_ymd;
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true);  


				


				// data 추출
				process_name = "PKG_SPO_MPS_BSC.SELECT_LOT_DAILY_SIZEQTY";

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

 


		#region 저장 관련

		/// <summary>
		/// Make_Save_DaySeq : 
		/// </summary>
		/// <returns></returns>
		private bool Make_Save_DaySeq()
		{ 
			
			try
			{ 
				int col_ct = 8; 
				int save_ct = 0;                      
				int para_ct =0;	 


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPO_MPS_BSC.SAVE_LOT_DAILY_MODIFY";
 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_PLAN_YMD";
				MyOraDB.Parameter_Name[6] = "ARG_SIZE_QTY";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER"; 
 
				for(int i = 0; i < col_ct ; i++) 
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  
				} 
				  
				for(int i = fgrid_Main.Cols.Fixed; i < fgrid_Main.Cols.Count; i++)
				{
					if(fgrid_Main[_SaveFlagRow, i] == null) continue;
					if(fgrid_Main[_SaveFlagRow, i].ToString() == "") continue;  
					save_ct++;
				}  

				MyOraDB.Parameter_Values  = new string[col_ct * save_ct]; 
 
				//-------------------------------------------------  
				for(int i = fgrid_Main.Cols.Fixed; i < fgrid_Main.Cols.Count; i++)
				{
					if(fgrid_Main[_SaveFlagRow, i] == null) continue;
					if(fgrid_Main[_SaveFlagRow, i].ToString() == "") continue;  
					 
					MyOraDB.Parameter_Values[para_ct] = fgrid_Main[_SaveFlagRow, i].ToString();  
					MyOraDB.Parameter_Values[para_ct + 1] = _Factory; 
					MyOraDB.Parameter_Values[para_ct + 2] = _LOTNo; 
					MyOraDB.Parameter_Values[para_ct + 3] = _LOTSeq;  
					MyOraDB.Parameter_Values[para_ct + 4] = fgrid_Main[_DaySeqRow, i].ToString();  
					MyOraDB.Parameter_Values[para_ct + 5] = fgrid_Main[_TBDate_Row, i].ToString();   
					MyOraDB.Parameter_Values[para_ct + 6] = fgrid_Main[_SizeRow, i].ToString();
					MyOraDB.Parameter_Values[para_ct + 7] = ClassLib.ComVar.This_User; 

					para_ct += col_ct;
					 
				} // end for  
 
				MyOraDB.Add_Modify_Parameter(true); 		 
				
				return true;

			}
			catch
			{ 
				return false;
			}

		}



		/// <summary>
		/// Make_RUN_RESET_DAYSEQ : 작업지시 이후부터의 dayseq 재계산
		/// </summary> 
		/// <param name="arg_lot"></param>
		/// <param name="arg_para_clear"></param>
		private bool Make_RUN_RESET_DAYSEQ(string arg_lot, bool arg_para_clear)
		{
  
			try
			{
				int col_ct = 4; 
 
				MyOraDB.ReDim_Parameter(col_ct); 
 
				MyOraDB.Process_Name = "PKG_SPO_MPS_BSC.RUN_RESET_DAYSEQ";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";  
 
				for (int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			
 
				MyOraDB.Parameter_Values[0] = _Factory;
				string[] token = arg_lot.Split('-');
				MyOraDB.Parameter_Values[1] = token[0];
				MyOraDB.Parameter_Values[2] = token[1]; 
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User; 
 
				MyOraDB.Add_Modify_Parameter(arg_para_clear);
				return true;

			}
			catch
			{ 
				return false;
			}

		}


		/// <summary>
		/// Make_RUN_LOT_MOVE_ADAPT_LEADTIME : LOT  이동에 따른 리드타임 재전개  
		/// </summary> 
		/// <param name="arg_lot"></param>
		/// <param name="arg_para_clear"></param>
		public bool Make_RUN_LOT_MOVE_ADAPT_LEADTIME(bool arg_para_clear, string arg_lotno, string arg_lot_seq)
		{
  
			try
			{
				int col_ct = 4; 
				int lotseq_count = 0;
				int para_ct = 0;

 
				MyOraDB.ReDim_Parameter(col_ct); 
 
				MyOraDB.Process_Name = "PKG_SPO_MPS_BSC.RUN_LOT_MOVE_ADAPT_LEADTIME";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";  
 
				for (int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			


				string[] token = arg_lot_seq.Split('/');
				lotseq_count = token.Length;

				MyOraDB.Parameter_Values  = new string[col_ct * lotseq_count];  

				for(int i = 0; i < lotseq_count; i++)
				{
					MyOraDB.Parameter_Values[para_ct] = _Factory; 
					MyOraDB.Parameter_Values[para_ct + 1] = arg_lotno;
					MyOraDB.Parameter_Values[para_ct + 2] = token[i]; 
					MyOraDB.Parameter_Values[para_ct + 3] = ClassLib.ComVar.This_User; 

					para_ct += col_ct;
				}

				MyOraDB.Add_Modify_Parameter(arg_para_clear);  
				return true;

			}
			catch
			{ 
				return false;
			}

		}



		/// <summary>
		/// Make_Update_SPO_LOT :  
		/// </summary>  
		/// <param name="arg_lot"></param>
		/// <param name="arg_planst"></param>
		public bool Make_RUN_LOT_DIVIDE_UPDATE_LOT(bool arg_para_clear, string arg_lot, string arg_planst)
		{
			int col_ct = 5; 

			string[] token = null;
			string lot_no = "", lot_seq = "";
 
			try
			{
				MyOraDB.ReDim_Parameter(col_ct); 
 
				MyOraDB.Process_Name = "PKG_SPO_MPS_BSC.RUN_LOT_DIVIDE_UPDATE_LOT";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_PLAN_STATUS"; 
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER"; 
		     
				for (int i = 0; i <= col_ct - 1; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			
 
				MyOraDB.Parameter_Values  = new string[col_ct]; 
				token = arg_lot.Split('-');

				lot_no = token[0];
				lot_seq = token[1]; 
			
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = lot_no; 
				MyOraDB.Parameter_Values[2] = lot_seq;
				MyOraDB.Parameter_Values[3] = arg_planst;
				MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;  
			
				MyOraDB.Add_Modify_Parameter(arg_para_clear);  
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

