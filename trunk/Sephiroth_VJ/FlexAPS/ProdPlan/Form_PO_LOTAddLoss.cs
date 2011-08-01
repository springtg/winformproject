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
	public class Form_PO_LOTAddLoss : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리 

		public System.Windows.Forms.Panel pnl_Top;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.TextBox txt_ObsType;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.TextBox txt_Model;
		private System.Windows.Forms.TextBox txt_DPO;
		private System.Windows.Forms.Label lbl_Model;
		private System.Windows.Forms.Label lbl_DPO;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.TextBox txt_PoNo;
		private System.Windows.Forms.Label lbl_PoNo;
		private System.Windows.Forms.TextBox txt_LOT;
		private System.Windows.Forms.Label lbl_LOT;
		private System.Windows.Forms.Panel pnl_BT;
		public COM.FSP fgrid_Req;
		private System.Windows.Forms.Splitter splitter1;
		public COM.FSP fgrid_Size;
		private System.ComponentModel.IContainer components = null;


		private bool _ForecastDivision = false;

		public Form_PO_LOTAddLoss()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}




		public Form_PO_LOTAddLoss(bool arg_forecast_division)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_ForecastDivision = arg_forecast_division;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_LOTAddLoss));
			this.pnl_Top = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.lbl_PoNo = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.txt_PoNo = new System.Windows.Forms.TextBox();
			this.txt_LOT = new System.Windows.Forms.TextBox();
			this.lbl_LOT = new System.Windows.Forms.Label();
			this.txt_ObsType = new System.Windows.Forms.TextBox();
			this.txt_Gen = new System.Windows.Forms.TextBox();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.txt_Model = new System.Windows.Forms.TextBox();
			this.txt_DPO = new System.Windows.Forms.TextBox();
			this.lbl_Model = new System.Windows.Forms.Label();
			this.lbl_DPO = new System.Windows.Forms.Label();
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
			this.fgrid_Size = new COM.FSP();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pnl_BT = new System.Windows.Forms.Panel();
			this.fgrid_Req = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Top.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Size)).BeginInit();
			this.pnl_BT.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Req)).BeginInit();
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
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Insert
			// 
			this.tbtn_Insert.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Insert_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Text = "LOT Size / Add Loss Quantity";
			// 
			// pnl_Top
			// 
			this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Top.Controls.Add(this.pnl_SearchImage);
			this.pnl_Top.DockPadding.Bottom = 8;
			this.pnl_Top.DockPadding.Left = 8;
			this.pnl_Top.DockPadding.Right = 8;
			this.pnl_Top.Location = new System.Drawing.Point(0, 64);
			this.pnl_Top.Name = "pnl_Top";
			this.pnl_Top.Size = new System.Drawing.Size(1016, 73);
			this.pnl_Top.TabIndex = 37;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.lbl_PoNo);
			this.pnl_SearchImage.Controls.Add(this.txt_PoNo);
			this.pnl_SearchImage.Controls.Add(this.txt_LOT);
			this.pnl_SearchImage.Controls.Add(this.lbl_LOT);
			this.pnl_SearchImage.Controls.Add(this.txt_ObsType);
			this.pnl_SearchImage.Controls.Add(this.txt_Gen);
			this.pnl_SearchImage.Controls.Add(this.txt_Style);
			this.pnl_SearchImage.Controls.Add(this.txt_Model);
			this.pnl_SearchImage.Controls.Add(this.txt_DPO);
			this.pnl_SearchImage.Controls.Add(this.lbl_Model);
			this.pnl_SearchImage.Controls.Add(this.lbl_DPO);
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
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 65);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// lbl_PoNo
			// 
			this.lbl_PoNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_PoNo.ImageIndex = 0;
			this.lbl_PoNo.ImageList = this.img_SmallLabel;
			this.lbl_PoNo.Location = new System.Drawing.Point(696, 32);
			this.lbl_PoNo.Name = "lbl_PoNo";
			this.lbl_PoNo.Size = new System.Drawing.Size(50, 21);
			this.lbl_PoNo.TabIndex = 107;
			this.lbl_PoNo.Text = "PO";
			this.lbl_PoNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_PoNo.Visible = false;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txt_PoNo
			// 
			this.txt_PoNo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_PoNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_PoNo.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_PoNo.Location = new System.Drawing.Point(752, 32);
			this.txt_PoNo.MaxLength = 60;
			this.txt_PoNo.Name = "txt_PoNo";
			this.txt_PoNo.ReadOnly = true;
			this.txt_PoNo.Size = new System.Drawing.Size(76, 21);
			this.txt_PoNo.TabIndex = 116;
			this.txt_PoNo.Text = "";
			this.txt_PoNo.Visible = false;
			// 
			// txt_LOT
			// 
			this.txt_LOT.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOT.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LOT.Location = new System.Drawing.Point(880, 32);
			this.txt_LOT.MaxLength = 60;
			this.txt_LOT.Name = "txt_LOT";
			this.txt_LOT.ReadOnly = true;
			this.txt_LOT.TabIndex = 118;
			this.txt_LOT.Text = "";
			this.txt_LOT.Visible = false;
			// 
			// lbl_LOT
			// 
			this.lbl_LOT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LOT.ImageIndex = 0;
			this.lbl_LOT.ImageList = this.img_SmallLabel;
			this.lbl_LOT.Location = new System.Drawing.Point(832, 32);
			this.lbl_LOT.Name = "lbl_LOT";
			this.lbl_LOT.Size = new System.Drawing.Size(50, 21);
			this.lbl_LOT.TabIndex = 117;
			this.lbl_LOT.Text = "LOT";
			this.lbl_LOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_LOT.Visible = false;
			// 
			// txt_ObsType
			// 
			this.txt_ObsType.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ObsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ObsType.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ObsType.Location = new System.Drawing.Point(408, 36);
			this.txt_ObsType.MaxLength = 60;
			this.txt_ObsType.Name = "txt_ObsType";
			this.txt_ObsType.ReadOnly = true;
			this.txt_ObsType.Size = new System.Drawing.Size(39, 21);
			this.txt_ObsType.TabIndex = 115;
			this.txt_ObsType.Text = "";
			// 
			// txt_Gen
			// 
			this.txt_Gen.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Gen.Location = new System.Drawing.Point(239, 36);
			this.txt_Gen.MaxLength = 60;
			this.txt_Gen.Name = "txt_Gen";
			this.txt_Gen.ReadOnly = true;
			this.txt_Gen.Size = new System.Drawing.Size(39, 21);
			this.txt_Gen.TabIndex = 114;
			this.txt_Gen.Text = "";
			// 
			// txt_Style
			// 
			this.txt_Style.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Style.Location = new System.Drawing.Point(162, 36);
			this.txt_Style.MaxLength = 60;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.ReadOnly = true;
			this.txt_Style.Size = new System.Drawing.Size(76, 21);
			this.txt_Style.TabIndex = 113;
			this.txt_Style.Text = "";
			// 
			// txt_Model
			// 
			this.txt_Model.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Model.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Model.Location = new System.Drawing.Point(61, 36);
			this.txt_Model.MaxLength = 60;
			this.txt_Model.Name = "txt_Model";
			this.txt_Model.ReadOnly = true;
			this.txt_Model.TabIndex = 112;
			this.txt_Model.Text = "";
			// 
			// txt_DPO
			// 
			this.txt_DPO.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_DPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_DPO.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_DPO.Location = new System.Drawing.Point(347, 36);
			this.txt_DPO.MaxLength = 60;
			this.txt_DPO.Name = "txt_DPO";
			this.txt_DPO.ReadOnly = true;
			this.txt_DPO.Size = new System.Drawing.Size(60, 21);
			this.txt_DPO.TabIndex = 110;
			this.txt_DPO.Text = "";
			// 
			// lbl_Model
			// 
			this.lbl_Model.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_SmallLabel;
			this.lbl_Model.Location = new System.Drawing.Point(10, 36);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(50, 21);
			this.lbl_Model.TabIndex = 108;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_DPO
			// 
			this.lbl_DPO.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_DPO.ImageIndex = 0;
			this.lbl_DPO.ImageList = this.img_SmallLabel;
			this.lbl_DPO.Location = new System.Drawing.Point(296, 36);
			this.lbl_DPO.Name = "lbl_DPO";
			this.lbl_DPO.Size = new System.Drawing.Size(50, 21);
			this.lbl_DPO.TabIndex = 106;
			this.lbl_DPO.Text = "DPO";
			this.lbl_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(983, 27);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(24, 25);
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
			this.picb_TM.Size = new System.Drawing.Size(1000, 32);
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
			this.lbl_SubTitle1.Text = "      Select Information";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(984, 50);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 49);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(1000, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 50);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 32);
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
			this.picb_MM.Size = new System.Drawing.Size(1000, 25);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Size);
			this.pnl_Body.Controls.Add(this.splitter1);
			this.pnl_Body.Controls.Add(this.pnl_BT);
			this.pnl_Body.DockPadding.Bottom = 8;
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 137);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 503);
			this.pnl_Body.TabIndex = 38;
			// 
			// fgrid_Size
			// 
			this.fgrid_Size.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Size.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Size.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Size.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Size.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Size.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Size.Location = new System.Drawing.Point(8, 267);
			this.fgrid_Size.Name = "fgrid_Size";
			this.fgrid_Size.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Size.Size = new System.Drawing.Size(1000, 228);
			this.fgrid_Size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:White;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Focus{BackColor:Highlight;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Size.TabIndex = 45;
			this.fgrid_Size.Click += new System.EventHandler(this.fgrid_Size_Click);
			this.fgrid_Size.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Size_AfterEdit);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(8, 264);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(1000, 3);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// pnl_BT
			// 
			this.pnl_BT.Controls.Add(this.fgrid_Req);
			this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BT.DockPadding.Bottom = 5;
			this.pnl_BT.Location = new System.Drawing.Point(8, 0);
			this.pnl_BT.Name = "pnl_BT";
			this.pnl_BT.Size = new System.Drawing.Size(1000, 264);
			this.pnl_BT.TabIndex = 0;
			// 
			// fgrid_Req
			// 
			this.fgrid_Req.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Req.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Req.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Req.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Req.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Req.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Req.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Req.Name = "fgrid_Req";
			this.fgrid_Req.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Req.Size = new System.Drawing.Size(1000, 259);
			this.fgrid_Req.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:White;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Focus{BackColor:Highlight;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Req.TabIndex = 44;
			this.fgrid_Req.Click += new System.EventHandler(this.fgrid_Req_Click);
			// 
			// Form_PO_LOTAddLoss
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Top);
			this.Name = "Form_PO_LOTAddLoss";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOT Size / Add Loss Quantity";
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Load += new System.EventHandler(this.Form_PO_LOTAddLoss_Load);
			this.Activated += new System.EventHandler(this.Form_PO_LOTAddLoss_Activated);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Top, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Top.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Size)).EndInit();
			this.pnl_BT.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Req)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();  
   
		private string _Factory, _LotNo, _LotSeq, _ObsID, _StyleCd; 

		private string _SizeRowFlag = "S";
		private string _LossRowFlag = "L"; 



		#endregion  

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			
			try
			{

				ClassLib.ComFunction.SetLangDic(this);

				//Title
				string title = "";

				if(_ForecastDivision)
				{
					title = "LOT Forecast Size";
				}
				else
				{
					title = "LOT Size / Add Loss Quantity";
				}

				this.Text = title;
				lbl_MainTitle.Text = title;
  

				fgrid_Req.Set_Grid("SPO_LOT_SIZE_LOSS", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false);
				fgrid_Req.Set_Action_Image(img_Action);
				fgrid_Req.ExtendLastCol = false;
				fgrid_Req.Font = new Font("Verdana", 7);
				fgrid_Req.AllowEditing = false;


				fgrid_Size.Set_Grid("SPO_LOT_SIZE", "2", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false);
				fgrid_Size.Set_Action_Image(img_Action);
				fgrid_Size.ExtendLastCol = false;
				fgrid_Size.Font = new Font("Verdana", 7);
    
			
				Init_Control();  
 

			
				DataSet ds_ret = Select_LOTInfo_ReqQty();
				DataTable lotinfo_dt = ds_ret.Tables[0];
				DataTable req_dt = ds_ret.Tables[1];

				Display_LOTInfo(lotinfo_dt);
				Set_SIZE_HEAD(fgrid_Req, txt_Gen.Text, (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxCS_SIZE_START);
				Set_SIZE_HEAD(fgrid_Size, txt_Gen.Text, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxCS_SIZE_START);

				Set_DisplayGrid_Req(req_dt); 

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
			//tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_Print.Enabled = false;

			_Factory = ClassLib.ComVar.Parameter_PopUp[0];  
			_LotNo = ClassLib.ComVar.Parameter_PopUp[1];  
			_LotSeq = ClassLib.ComVar.Parameter_PopUp[2];  
			_ObsID = ClassLib.ComVar.Parameter_PopUp[3];  
			_StyleCd = ClassLib.ComVar.Parameter_PopUp[4];

		}



		/// <summary>
		/// Display_LOTInfo : 
		/// </summary>
		private void Display_LOTInfo(DataTable arg_dt)
		{
		  
			txt_Model.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxLI_MODEL_NAME].ToString();
			txt_Style.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxLI_STYLE_CD].ToString();
			txt_Gen.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxLI_GEN].ToString();
			txt_PoNo.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxLI_PO_NO].ToString();
			txt_DPO.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxLI_OBS_ID].ToString();
			txt_ObsType.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxLI_OBS_TYPE].ToString();
			txt_LOT.Text = _LotNo + "-" + _LotSeq;

			 
		}

 


		/// <summary>
		/// 
		/// </summary>
		private void Set_DisplayGrid_Req(DataTable arg_dt)
		{
			string before_item = "", now_item = ""; 
            int min_size_col = fgrid_Req.Cols.Count + 1; 
			int sum_size_row = 0, sum_loss_row = 0;

			try
			{ 
				fgrid_Req.Rows.Count = fgrid_Req.Rows.Fixed;

				if(arg_dt.Rows.Count == 0) return; 
  
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{ 
					now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTBREQ_NO].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTBOBS_NU].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTBOBS_SEQ_NU].ToString(); 
					  
					if(before_item != now_item)
					{  
						fgrid_Req.Rows.Add(); 
						fgrid_Req.Rows.Add();
						 
						fgrid_Req[fgrid_Req.Rows.Count - 2, 0] = _SizeRowFlag;
						fgrid_Req[fgrid_Req.Rows.Count - 1, 0] = _LossRowFlag; 
 
//						fgrid_Req[fgrid_Req.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxREQ_NO] 
//							= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTBREQ_NO].ToString(); 
// 
//						fgrid_Req[fgrid_Req.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxREQ_NO] 
//							= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTBREQ_NO].ToString();  


						for(int a = (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxREQ_NO; a <= (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxOGAC; a++)
						{
							fgrid_Req[fgrid_Req.Rows.Count - 2, a] = arg_dt.Rows[i].ItemArray[a - 2].ToString(); 
							fgrid_Req[fgrid_Req.Rows.Count - 1, a] = arg_dt.Rows[i].ItemArray[a - 2].ToString(); 
						}



						fgrid_Req.Rows[fgrid_Req.Rows.Count - 2].AllowEditing = false;
						fgrid_Req.Rows[fgrid_Req.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrLightSel;

						before_item = now_item;  
						

					}

					//사이즈별 수량 표시
					for(int j = (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxCS_SIZE_START; j < fgrid_Req.Cols.Count; j++)
					{
						if(fgrid_Req[1, j].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTBCS_SIZE].ToString())
						{
							//if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTBSIZE_QTY].ToString() == "0") continue;

							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTBSIZE_QTY].ToString() == "0"
								&& arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTBLOSS_QTY].ToString() == "0") continue;


							min_size_col = (min_size_col > j) ? j : min_size_col; 

							fgrid_Req[fgrid_Req.Rows.Count - 2, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTBSIZE_QTY].ToString();
							fgrid_Req[fgrid_Req.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTBLOSS_QTY].ToString();
					

							break;  
						} 
					}  
 
				} // end for i
 
				//--------------------------------------------------------------
				//기타 속성
				// 1. Merge
				fgrid_Req.AllowMerging = AllowMergingEnum.Free;
 
				fgrid_Req.Cols[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTOT_QTY].AllowMerging = false;
				fgrid_Req.Cols[(int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxSUM_QTY].AllowMerging = false;

				for(int i = (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxCS_SIZE_START; i < fgrid_Req.Cols.Count; i++)
					fgrid_Req.Cols[i].AllowMerging = false;
    

				//2. SubTotals
				//2-1. row별
				for(int i = fgrid_Req.Rows.Fixed; i < fgrid_Req.Rows.Count; i += 2)
				{
					for(int j = (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxCS_SIZE_START; j < fgrid_Req.Cols.Count; j++)
					{
						if(fgrid_Req[i, j] != null && fgrid_Req[i, j].ToString() != "")
						{
							sum_size_row += Convert.ToInt32(fgrid_Req[i, j].ToString() );
						}

						if(fgrid_Req[i + 1, j] != null && fgrid_Req[i + 1, j].ToString() != "")
						{
							sum_loss_row += Convert.ToInt32(fgrid_Req[i + 1, j].ToString() );
						} 
					}

					fgrid_Req[i, (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTOT_QTY] = sum_size_row.ToString();
					fgrid_Req[i, (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxSUM_QTY] = sum_size_row.ToString();
					fgrid_Req[i + 1, (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTOT_QTY] = sum_loss_row.ToString();
					fgrid_Req[i + 1, (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxSUM_QTY] = sum_loss_row.ToString();

					sum_size_row = 0;
					sum_loss_row = 0;
				}

				

				//2-2. col별 
				fgrid_Req.Subtotal(AggregateEnum.Clear); 
				fgrid_Req.SubtotalPosition = SubtotalPositionEnum.AboveData;

				fgrid_Req.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
				fgrid_Req.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;  

				for (int i = (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxTOT_QTY; i < fgrid_Req.Cols.Count; i++) 
					fgrid_Req.Subtotal(AggregateEnum.Sum, 0, -1, i, "Total");
  
				 
				
				fgrid_Req.LeftCol = min_size_col;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_DisplayGrid_Req", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

 
		/// <summary>
		/// 
		/// </summary>
		private void Set_DisplayGrid_LOT(DataTable arg_dt)
		{
			string before_item = "", now_item = ""; 
			int min_size_col = fgrid_Size.Cols.Count + 1; 
			int sum_size_row = 0, sum_loss_row = 0;

			try
			{ 
				fgrid_Size.Rows.Count = fgrid_Size.Rows.Fixed;

				if(arg_dt.Rows.Count == 0) return; 
  
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{ 
					now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBLOT].ToString()
						       + arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBREQ_NO].ToString()
							   + arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBOBS_NU].ToString()
							   + arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBOBS_SEQ_NU].ToString(); 
					  
					if(before_item != now_item)
					{  
						fgrid_Size.Rows.Add(); 
						fgrid_Size.Rows.Add();
						 
						fgrid_Size[fgrid_Size.Rows.Count - 2, 0] = _SizeRowFlag;
						fgrid_Size[fgrid_Size.Rows.Count - 1, 0] = _LossRowFlag; 

//						fgrid_Size[fgrid_Size.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxOGAC] 
//							= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBOGAC].ToString(); 
//
//						fgrid_Size[fgrid_Size.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxLOT] 
//							= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBLOT].ToString(); 
// 
////						fgrid_Size[fgrid_Size.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxREQ_NO] 
////							= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBREQ_NO].ToString(); 
// 
// 
//
//						fgrid_Size[fgrid_Size.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxOGAC] 
//							= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBOGAC].ToString(); 
//
//						fgrid_Size[fgrid_Size.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxLOT] 
//							= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBLOT].ToString(); 
// 
//						fgrid_Size[fgrid_Size.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxREQ_NO] 
//							= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBREQ_NO].ToString(); 


						for(int a = (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxLOT; a <= (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxOGAC; a++)
						{
							fgrid_Size[fgrid_Size.Rows.Count - 2, a] = arg_dt.Rows[i].ItemArray[a - 2].ToString(); 
							fgrid_Size[fgrid_Size.Rows.Count - 1, a] = arg_dt.Rows[i].ItemArray[a - 2].ToString(); 
						}


						fgrid_Size.Rows[fgrid_Size.Rows.Count - 2].AllowEditing = false;
						fgrid_Size.Rows[fgrid_Size.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrLightSel;

						before_item = now_item;  
						

					}

					//사이즈별 수량 표시
					for(int j = (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxCS_SIZE_START; j < fgrid_Size.Cols.Count; j++)
					{
						if(fgrid_Size[1, j].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBCS_SIZE].ToString())
						{
							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBSIZE_QTY].ToString() == "0"
								&& arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBLOSS_QTY].ToString() == "0") continue;

							min_size_col = (min_size_col > j) ? j : min_size_col; 

							fgrid_Size[fgrid_Size.Rows.Count - 2, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBSIZE_QTY].ToString();
							fgrid_Size[fgrid_Size.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTBLOSS_QTY].ToString();
					

							break;  
						} 
					}  
 
				} // end for i
 
				//--------------------------------------------------------------
				//기타 속성
				// 1. Merge
				fgrid_Size.AllowMerging = AllowMergingEnum.Free;
 
				fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxREQ_NO].AllowMerging = false;
				fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTOT_QTY].AllowMerging = false;
				fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxSUM_QTY].AllowMerging = false;

				for(int i = (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxCS_SIZE_START; i < fgrid_Size.Cols.Count; i++)
					fgrid_Size.Cols[i].AllowMerging = false;
    

				//2. SubTotals
				//2-1. row별
				for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i += 2)
				{
					for(int j = (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxCS_SIZE_START; j < fgrid_Size.Cols.Count; j++)
					{
						if(fgrid_Size[i, j] != null && fgrid_Size[i, j].ToString() != "")
						{
							sum_size_row += Convert.ToInt32(fgrid_Size[i, j].ToString() );
						}

						if(fgrid_Size[i + 1, j] != null && fgrid_Size[i + 1, j].ToString() != "")
						{
							sum_loss_row += Convert.ToInt32(fgrid_Size[i + 1, j].ToString() );
						} 
					}

					fgrid_Size[i, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTOT_QTY] = sum_size_row.ToString();
					fgrid_Size[i, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxSUM_QTY] = sum_size_row.ToString();
					fgrid_Size[i + 1, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTOT_QTY] = sum_loss_row.ToString();
					fgrid_Size[i + 1, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxSUM_QTY] = sum_loss_row.ToString();

					sum_size_row = 0;
					sum_loss_row = 0;
				}

				

				//2-2. col별 
				fgrid_Size.Subtotal(AggregateEnum.Clear); 
				fgrid_Size.SubtotalPosition = SubtotalPositionEnum.AboveData;

				fgrid_Size.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
				fgrid_Size.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;  

				for (int i = (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxTOT_QTY; i < fgrid_Size.Cols.Count; i++) 
					fgrid_Size.Subtotal(AggregateEnum.Sum, 0, -1, i, "Total");
  
				 
				
				fgrid_Size.LeftCol = min_size_col;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_DisplayGrid_LOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		/// <summary>
		/// Set_SIZE_HEAD : 
		/// </summary>
		/// <param name="arg_fgrid"></param>
		/// <param name="arg_gen"></param>
		/// <param name="arg_size_start"></param>
		private void Set_SIZE_HEAD(COM.FSP arg_fgrid, string arg_gen, int arg_size_start)
		{
			DataTable dt_ret;

			try
			{
				dt_ret = Select_Gen_Size(arg_gen);

				arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;
				arg_fgrid.Cols.Count = dt_ret.Rows.Count + arg_size_start;
    
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					arg_fgrid[1, arg_size_start + i] = dt_ret.Rows[i].ItemArray[0].ToString();
					arg_fgrid.Cols[arg_size_start + i].Width = 45;
					arg_fgrid.Cols[arg_size_start + i].StyleNew.Clear(); 
				}
 
				arg_fgrid.Rows[0].TextAlign = TextAlignEnum.RightCenter; 
				arg_fgrid.Cols.Frozen = arg_size_start; 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_SIZE_HEAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}
 



		#endregion  

		#region 이벤트 처리

		private void fgrid_Size_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			bool digit_flag;

			try
			{
				if(e.Col != (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxREQ_NO)
				{
					digit_flag = COM.ComFunction.Check_Digit(fgrid_Size[e.Row, e.Col].ToString());

					if(digit_flag == false) 
					{
						fgrid_Size[e.Row, e.Col] = "0";
						return;
					} 
				}


				fgrid_Size[e.Row, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxSAVE_FLAG] = "Y";

				//Set SubTotal
				int sumrow = 0;

				for(int i = (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxCS_SIZE_START; i < fgrid_Size.Cols.Count; i++)
				{
					if(fgrid_Size[e.Row, i] == null || fgrid_Size[e.Row, i].ToString() == "") continue;
					sumrow += Convert.ToInt32(fgrid_Size[e.Row, i].ToString());
				}

				fgrid_Size[e.Row, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxSUM_QTY] = sumrow.ToString();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Size_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
				
		}



		private void fgrid_Req_Click(object sender, System.EventArgs e)
		{
			 
			try
			{
				if(fgrid_Req[fgrid_Req.Selection.r1, (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxREQ_NO] == null) return;

				DataTable dt_ret = Select_LOT_SIZE_LOSS(fgrid_Req[fgrid_Req.Selection.r1, (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxREQ_NO].ToString() );
				Set_DisplayGrid_LOT(dt_ret);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Req_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void fgrid_Size_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;
			string cmb_list = "";
			string lotno = "", lotseq = "";

			try
			{
				if(fgrid_Size.Rows.Count <= fgrid_Size.Rows.Fixed) return;

				if(fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxLOT] == null) return;

				string[] token = fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxLOT].ToString().Split('-');
				lotno = token[0];
				lotseq = token[1];
 
				if(lotno == "")
				{
					fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxREQ_NO].ComboList = "";
				}
				else
				{
					dt_ret = Select_SPO_RECV_LOT(lotno, lotseq);

					for(int i = 0; i < dt_ret.Rows.Count; i++) cmb_list += "|" + dt_ret.Rows[i].ItemArray[0].ToString(); 
					fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxREQ_NO].ComboList = cmb_list;
				} 
				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Size_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				fgrid_Size.Add_Row(fgrid_Size.Selection.r1);  
 
				fgrid_Size[fgrid_Size.Selection.r1, 0] = _LossRowFlag;
				fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxSAVE_FLAG] = "Y";
				fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxLOT] 
					= fgrid_Size[fgrid_Size.Selection.r1 - 1, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxLOT].ToString();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Insert_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataSet ds_ret;
			DataTable dt_ret;

			try
			{
				ds_ret = Select_LOTInfo_ReqQty(); 
				dt_ret = ds_ret.Tables[1];
 
				Set_DisplayGrid_Req(dt_ret); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		#region 저장 관련

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			bool save_flag = false; 

			try
			{
				this.Cursor = Cursors.WaitCursor;

				int sel_row = fgrid_Req.Selection.r1;



				save_flag = Save_SPO_LOT_SIZE_LOSS();

				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					this.Cursor = Cursors.Default;
					return;
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this); 


					//----------------------------------------------------------------------------------------------------------------------
					// 재조회
					//----------------------------------------------------------------------------------------------------------------------
					DataSet ds_ret = Select_LOTInfo_ReqQty();
					DataTable lotinfo_dt = ds_ret.Tables[0];
					DataTable req_dt = ds_ret.Tables[1];

					Display_LOTInfo(lotinfo_dt);
					Set_SIZE_HEAD(fgrid_Req, txt_Gen.Text, (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxCS_SIZE_START);
					Set_SIZE_HEAD(fgrid_Size, txt_Gen.Text, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxCS_SIZE_START);

					Set_DisplayGrid_Req(req_dt);


					DataTable dt_ret = Select_LOT_SIZE_LOSS(fgrid_Req[sel_row, (int)ClassLib.TBSPO_LOT_ADDLOSS_H.IxREQ_NO].ToString() );
					Set_DisplayGrid_LOT(dt_ret);
					//----------------------------------------------------------------------------------------------------------------------


				   
					this.Cursor = Cursors.Default;
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		


		/// <summary>
		/// Save_SPO_LOT_SIZE_LOSS : 
		/// </summary>
		/// <returns></returns>
		private bool Save_SPO_LOT_SIZE_LOSS()
		{
			bool save_flag = false;

			try
			{
				save_flag = Make_SPO_LOT_SIZE_LOSS();

				if(!save_flag)  
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
		/// Make_SPO_LOT_SIZE_LOSS : 
		/// </summary>
		private bool Make_SPO_LOT_SIZE_LOSS()
		{
			int col_ct = 8;  
			int save_ct = 0, save_row_ct = 0;                      
			int para_ct =0;	 
			string lotno = "", lotseq = "";

			try
			{ 
				MyOraDB.ReDim_Parameter(col_ct);


				string process_name = "";

				if(_ForecastDivision)
				{
					process_name = "PKG_SPO_LOT_LOSS_BSC.UPDATE_SPO_LOT_SIZE_FORECAST";
				}
				else
				{
					process_name = "PKG_SPO_LOT_LOSS_BSC.UPDATE_SPO_LOT_SIZE_LOSS";
				}


				MyOraDB.Process_Name = process_name;

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[4] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[5] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[6] = "ARG_LOSS_QTY";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER"; 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 
				// 저장 행 수 구하기 
				for(int row = fgrid_Size.Rows.Fixed; row < fgrid_Size.Rows.Count; row++)
				{
					if(fgrid_Size[row, 0] == null) continue; 
					if(fgrid_Size[row, 0].ToString() != _LossRowFlag) continue;
					if(fgrid_Size[row, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxSAVE_FLAG] == null 
						|| fgrid_Size[row, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxSAVE_FLAG].ToString() != "Y") continue;

					save_row_ct += 1;

					for(int col = (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxCS_SIZE_START; col < fgrid_Size.Cols.Count; col++)
					{ 
						if(fgrid_Size[row, col] == null || fgrid_Size[row, col].ToString() == "") continue;
						save_ct += 1;
					}
				} 

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[(col_ct * save_ct) + (col_ct * save_row_ct)]; 
 
				for(int row = fgrid_Size.Rows.Fixed; row < fgrid_Size.Rows.Count; row++)
				{
					if(fgrid_Size[row, 0] == null) continue; 
					if(fgrid_Size[row, 0].ToString() != _LossRowFlag) continue; 
					if(fgrid_Size[row, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxSAVE_FLAG] == null 
						|| fgrid_Size[row, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxSAVE_FLAG].ToString() != "Y") continue;
  
					
					string[] token = fgrid_Size[row, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxLOT].ToString().Split('-'); 
					lotno = token[0];
					lotseq = token[1];

					for(int col = (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxCS_SIZE_START; col < fgrid_Size.Cols.Count; col++)
					{  
						if(fgrid_Size[row, col] == null || fgrid_Size[row, col].ToString() == "") continue;
						
						 
						//SPO_LOT_SIZE 에 loss_qty 저장
						MyOraDB.Parameter_Values[para_ct] = "D";
						MyOraDB.Parameter_Values[para_ct + 1] = _Factory; 
						MyOraDB.Parameter_Values[para_ct + 2] = lotno;
						MyOraDB.Parameter_Values[para_ct + 3] = lotseq; 
						MyOraDB.Parameter_Values[para_ct + 4] = fgrid_Size[row, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxREQ_NO].ToString(); 
						MyOraDB.Parameter_Values[para_ct + 5] = fgrid_Size[1, col].ToString(); 
						MyOraDB.Parameter_Values[para_ct + 6] = fgrid_Size[row, col].ToString();  
						MyOraDB.Parameter_Values[para_ct + 7] = ClassLib.ComVar.This_User; 

						para_ct += col_ct; 

					} // end for col 
 

					//spo_lot에 loss_qty, spo_recv에 tot_loss_qty 저장
					MyOraDB.Parameter_Values[para_ct] = "H";
					MyOraDB.Parameter_Values[para_ct + 1] = _Factory;
					MyOraDB.Parameter_Values[para_ct + 2] = lotno;
					MyOraDB.Parameter_Values[para_ct + 3] = lotseq; 
					MyOraDB.Parameter_Values[para_ct + 4] = fgrid_Size[row, (int)ClassLib.TBSPO_LOT_ADDLOSS_D.IxREQ_NO].ToString(); 
					MyOraDB.Parameter_Values[para_ct + 5] = ""; 
					MyOraDB.Parameter_Values[para_ct + 6] = "";  
					MyOraDB.Parameter_Values[para_ct + 7] = ClassLib.ComVar.This_User; 
 
					para_ct += col_ct; 

				} // end for i
 
				MyOraDB.Add_Modify_Parameter(true);		 
				MyOraDB.Exe_Modify_Procedure();
				
				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Make_SPO_LOT_SIZE_LOSS", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
 


		#endregion



		#endregion 

		#region DB Connect


		/// <summary>
		/// Select_Gen_Size : 젠더에 따른 사이즈 문대 리스트
		/// </summary>
		/// <param name="arg_gen"></param>
		/// <returns></returns>
		private DataTable Select_Gen_Size(string arg_gen)
		{
			 
			try
			{

				DataSet ds_ret;
				string process_name = "PKG_SPO_ORDER_BSC.SELECT_GEN_SIZE";

				MyOraDB.ReDim_Parameter(3); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = process_name;
 
				//02.ARGURMENT명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_GEN";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				//03.DATA TYPE
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = _Factory; 
				MyOraDB.Parameter_Values[1] = arg_gen;
				MyOraDB.Parameter_Values[2] = ""; 

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
		/// Select_LOTInfo_ReqQty :  
		/// </summary>
		private DataSet Select_LOTInfo_ReqQty()
		{
			DataSet ds_ret;

			try
			{
			 
				string process_name = "PKG_SPO_LOT_LOSS_BSC.SELECT_LOT_INFO";

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
			   
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = _LotNo;
				MyOraDB.Parameter_Values[2] = _LotSeq;  
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true); 


				process_name = "PKG_SPO_LOT_LOSS_BSC.SELECT_LOT_REQNO_SIZE";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			   
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = _ObsID;
				MyOraDB.Parameter_Values[2] = _StyleCd;  
				MyOraDB.Parameter_Values[3] = ""; 

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



		/// <summary>
		/// Select_LOT_SIZE_LOSS :  
		/// </summary>
		private DataTable Select_LOT_SIZE_LOSS(string arg_reqno)
		{
			DataSet ds_ret;

			try
			{
			 
				string process_name = "";

				if(_ForecastDivision)
				{
					process_name = "PKG_SPO_LOT_LOSS_BSC.SELECT_LOT_SIZE_FORECAST";
				}
				else
				{
					process_name = "PKG_SPO_LOT_LOSS_BSC.SELECT_LOT_SIZE_LOSS";
				}

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_REQ_NO"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			   
				MyOraDB.Parameter_Values[0] = _Factory; 
				MyOraDB.Parameter_Values[1] = arg_reqno; 
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
		/// Select_SPO_RECV_LOT :  
		/// </summary>
		private DataTable Select_SPO_RECV_LOT(string arg_lotno, string arg_lotseq)
		{
			DataSet ds_ret;

			try
			{
			 
				string process_name = "PKG_SPO_LOT_LOSS_BSC.SELECT_SPO_RECV_LOT";

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
			   
				MyOraDB.Parameter_Values[0] = _Factory; 
				MyOraDB.Parameter_Values[1] = arg_lotno; 
				MyOraDB.Parameter_Values[2] = arg_lotseq; 
				MyOraDB.Parameter_Values[3] = ""; 

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


		private void Form_PO_LOTAddLoss_Activated(object sender, System.EventArgs e)
		{
			txt_Model.Focus();
		}

		private void Form_PO_LOTAddLoss_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
 

 

		
	}
}

