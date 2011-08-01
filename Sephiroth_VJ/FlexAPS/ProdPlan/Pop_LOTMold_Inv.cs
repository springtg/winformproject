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
	public class Pop_LOTMold_Inv : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Panel pnl_Body;
		public System.Windows.Forms.Panel pnl_Top;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.Label lbl_LOT;
		private System.Windows.Forms.TextBox txt_LOT;
		private System.Windows.Forms.TextBox txt_Model;
		private System.Windows.Forms.TextBox txt_LineName;
		private System.Windows.Forms.Label lbl_LineCd1;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_Model;
		public COM.FSP fgrid_Main;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자


		public Pop_LOTMold_Inv()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		private string _Factory;
		private string _LineCd;
		private string _LineName;
		private string _Model;
		private string _StyleCd;
		private string _Gen;
		private string _LOT;

		public Pop_LOTMold_Inv(string arg_factory, 
			string arg_line_cd, 
			string arg_line_name, 
			string arg_model, 
			string arg_style_cd, 
			string arg_gen, 
			string arg_lot)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Factory = arg_factory;
			_LineCd = arg_line_cd;
			_LineName = arg_line_name;
			_Model = arg_model;
			_StyleCd = arg_style_cd;
			_Gen = arg_gen;
			_LOT = arg_lot;


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_LOTMold_Inv));
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.pnl_Top = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.lbl_LOT = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
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
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.pnl_Top.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
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
			this.stbar.Location = new System.Drawing.Point(0, 449);
			this.stbar.Name = "stbar";
			this.stbar.Size = new System.Drawing.Size(1016, 24);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Text = "Hourly production capacity (Last)";
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
			this.pnl_Body.Location = new System.Drawing.Point(0, 137);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 310);
			this.pnl_Body.TabIndex = 37;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(1000, 302);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 45;
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
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
			this.pnl_Top.TabIndex = 36;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
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
			// lbl_LOT
			// 
			this.lbl_LOT.ImageIndex = 0;
			this.lbl_LOT.ImageList = this.img_SmallLabel;
			this.lbl_LOT.Location = new System.Drawing.Point(438, 36);
			this.lbl_LOT.Name = "lbl_LOT";
			this.lbl_LOT.Size = new System.Drawing.Size(50, 21);
			this.lbl_LOT.TabIndex = 129;
			this.lbl_LOT.Text = "LOT";
			this.lbl_LOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txt_LOT
			// 
			this.txt_LOT.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOT.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LOT.Location = new System.Drawing.Point(489, 36);
			this.txt_LOT.MaxLength = 60;
			this.txt_LOT.Name = "txt_LOT";
			this.txt_LOT.ReadOnly = true;
			this.txt_LOT.Size = new System.Drawing.Size(85, 21);
			this.txt_LOT.TabIndex = 130;
			this.txt_LOT.Text = "";
			// 
			// txt_Model
			// 
			this.txt_Model.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Model.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Model.Location = new System.Drawing.Point(206, 36);
			this.txt_Model.MaxLength = 60;
			this.txt_Model.Name = "txt_Model";
			this.txt_Model.ReadOnly = true;
			this.txt_Model.TabIndex = 133;
			this.txt_Model.Text = "";
			// 
			// txt_LineName
			// 
			this.txt_LineName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineName.Location = new System.Drawing.Point(61, 36);
			this.txt_LineName.MaxLength = 60;
			this.txt_LineName.Name = "txt_LineName";
			this.txt_LineName.ReadOnly = true;
			this.txt_LineName.Size = new System.Drawing.Size(80, 21);
			this.txt_LineName.TabIndex = 132;
			this.txt_LineName.Text = "";
			// 
			// lbl_LineCd1
			// 
			this.lbl_LineCd1.ImageIndex = 0;
			this.lbl_LineCd1.ImageList = this.img_SmallLabel;
			this.lbl_LineCd1.Location = new System.Drawing.Point(10, 36);
			this.lbl_LineCd1.Name = "lbl_LineCd1";
			this.lbl_LineCd1.Size = new System.Drawing.Size(50, 21);
			this.lbl_LineCd1.TabIndex = 131;
			this.lbl_LineCd1.Text = "Line";
			this.lbl_LineCd1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Gen
			// 
			this.txt_Gen.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Gen.Location = new System.Drawing.Point(388, 36);
			this.txt_Gen.MaxLength = 60;
			this.txt_Gen.Name = "txt_Gen";
			this.txt_Gen.ReadOnly = true;
			this.txt_Gen.Size = new System.Drawing.Size(36, 21);
			this.txt_Gen.TabIndex = 128;
			this.txt_Gen.Text = "";
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(307, 36);
			this.txt_StyleCd.MaxLength = 60;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.ReadOnly = true;
			this.txt_StyleCd.Size = new System.Drawing.Size(80, 21);
			this.txt_StyleCd.TabIndex = 127;
			this.txt_StyleCd.Text = "";
			// 
			// lbl_Model
			// 
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_SmallLabel;
			this.lbl_Model.Location = new System.Drawing.Point(155, 36);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(50, 21);
			this.lbl_Model.TabIndex = 126;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.lbl_SubTitle1.Text = "      LOT Information";
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
			// Pop_LOTMold_Inv
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 473);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Top);
			this.Name = "Pop_LOTMold_Inv";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hourly production capacity (Last)";
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Load += new System.EventHandler(this.Pop_LOTMold_Inv_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Top, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.pnl_Top.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
 
		#region 변수 정의


		private COM.OraDB MyOraDB = new COM.OraDB();
		 

		// level
		private string _LevelDaySize = "1";
		private string _LevelLastInv = "2";
		private string _LevelLastCT = "3";
		private string _LevelLastCapa = "4";




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
				this.Text = "Hourly production capacity (Last)";
				this.lbl_MainTitle.Text = "Hourly production capacity (Last)"; 

				 
				
				fgrid_Main.Set_Grid("SPO_LOT_LAST_INVENTORY", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_Main.Font = new Font("Verdana", 7);
				fgrid_Main.AllowSorting = AllowSortingEnum.None;
				fgrid_Main.AllowDragging = AllowDraggingEnum.None;
				fgrid_Main.Styles.Alternate.BackColor = Color.White;  
			

				 
 
				Init_Control(); 
 

				// search
				Event_Tbtn_Search();
 

				 

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
			tbtn_Print.Enabled = false;


			txt_LineName.Text = _LineName;
			txt_Model.Text = _Model;
			txt_StyleCd.Text = _StyleCd;
			txt_Gen.Text = _Gen;
			txt_LOT.Text = _LOT; 


			// 사이즈 헤더 할당 
			ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_Main, 
														_Factory, 
														_Gen, 
														fgrid_Main.Rows.Fixed,
														(int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxGEN,
														(int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxCS_SIZE_START);

  

		} 
		
 


		#endregion 

		#region 조회
 
 
		/// <summary>
		/// Display_Data : 
		/// </summary>
		private void Display_Data()
		{

			string before_item = "", now_item = ""; 
			int gen_row = 0; 
			string sel_gen = "";
			int min_size_col = fgrid_Main.Cols.Count + 1;   //default : col max value
			int sum_size_qty = 0;



			string factory = _Factory;
			string[] token = _LOT.Split('-');
			string lot_no = token[0];
			string lot_seq = token[1];

			DataTable dt_ret = Select_SPO_LOT_LAST_INVENTORY(factory, lot_no, lot_seq);

			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 
  


			if(dt_ret.Rows.Count == 0) return;


  
			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
      	 
				now_item = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxLOT_NO - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxLOT_SEQ - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxDAY_SEQ - 1].ToString();
 
				if(before_item != now_item)
				{
  
					fgrid_Main.Rows.Add();
								
					//default data setting
					for(int j = 1; j <= (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxGEN; j++)
					{
						fgrid_Main[fgrid_Main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j - 1].ToString();
					}
 					 
					fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxGEN] = _Gen;


					// day size row 아닌것
					if(fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxDESC_LEVEL].ToString() != _LevelDaySize)
					{
						fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxDAY_SEQ] = "";
						fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxTOT_QTY] = "";
					}

					// last inv, cycle 만 수정 가능
					if(fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxDESC_LEVEL].ToString() == _LevelDaySize
						|| fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxDESC_LEVEL].ToString() == _LevelLastCapa)
					{
						fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;  
					}



					 
					//gen
					for(int j = 1; j <= fgrid_Main.Rows.Fixed; j++)
					{
						if(fgrid_Main[j, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxGEN].ToString() == _Gen)
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_Main[gen_row, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxGEN].ToString();

							break;
						} 
					}


					before_item = now_item; 
					 

				}
 

				//--------------------------------------------------------------

				for(int j = (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxCS_SIZE_START; j < fgrid_Main.Cols.Count; j++)
				{
					if(fgrid_Main[gen_row, j].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxCS_SIZE - 1].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						sum_size_qty = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxSIZE_QTY - 1].ToString());
						
						fgrid_Main[fgrid_Main.Rows.Count - 1, j] = (sum_size_qty.ToString() == "0") ? "" : sum_size_qty.ToString();
						

						break; 
					} 
				}
  


			} // end for 


			//--------------------------------------------------------------
			//LOT에 대한 젠더만 표시
			string[] token1 = sel_gen.Split('/');

			for(int i = 1; i < fgrid_Main.Rows.Fixed; i++) 
				fgrid_Main.Rows[i].Visible = false;   

			for(int i = 1; i < fgrid_Main.Rows.Fixed; i++) 
			{
				for(int j = 0; j < token1.Length; j++)
				{
					if(fgrid_Main[i, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxGEN].ToString() == token1[j])
					{
						fgrid_Main.Rows[i].Visible = true; 
						break;
					} 
				} // end for j 
			} // end for i 


			//--------------------------------------------------------------
			//Merge 속성 
			fgrid_Main.AllowMerging = AllowMergingEnum.Free; 
			for(int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++) fgrid_Main.Rows[i].AllowMerging = false;  
			fgrid_Main.Cols[(int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxDESC1].AllowMerging = true; 


			//기타 속성 
			fgrid_Main.Cols.Frozen = (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxCS_SIZE_START;
			fgrid_Main.LeftCol = min_size_col; 



			Display_Last_Capa();


		}



		/// <summary>
		/// Display_Last_Capa : 
		/// </summary>
		private void Display_Last_Capa()
		{

			int findrow = fgrid_Main.FindRow(_LevelLastInv, fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxDESC_LEVEL, false, true, false);

			if(findrow == -1) return;

			int row_last_inv = findrow;
			int row_last_ct = findrow + 1;
			int row_last_capa = findrow + 2;

			int last_inv = 0;
			int last_ct = 0;
			string last_capa = "";

			int sum_last_inv = 0;
			int sum_last_capa = 0;

			for(int i = (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxCS_SIZE_START; i < fgrid_Main.Cols.Count; i++)
			{

				last_inv = (fgrid_Main[row_last_inv, i] == null || fgrid_Main[row_last_inv, i].ToString().Trim().Equals("") ) ? 0 : Convert.ToInt32(fgrid_Main[row_last_inv, i].ToString() );
				last_ct = (fgrid_Main[row_last_ct, i] == null || fgrid_Main[row_last_ct, i].ToString().Trim().Equals("") ) ? 0 : Convert.ToInt32(fgrid_Main[row_last_ct, i].ToString() );

				last_capa = ( (last_inv * last_ct) == 0) ? "" : Convert.ToString(last_inv * last_ct); 

				fgrid_Main[row_last_capa, i] = last_capa;


				sum_last_inv += last_inv;
				sum_last_capa += Convert.ToInt32( (last_capa == "") ? "0" : last_capa ); 

				
			}



			fgrid_Main[row_last_inv, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxTOT_QTY] = sum_last_inv.ToString();
			fgrid_Main[row_last_capa, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxTOT_QTY] = sum_last_capa.ToString();

			


		}





		#endregion 

		#region 툴바 이벤트 메서드


		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{
		
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 

		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{

			Display_Data();
			 
		}

 

		/// <summary>
		/// Event_Tbtn_Save : 
		/// </summary>
		private void Event_Tbtn_Save()
		{
  

			bool save_flag = Save_SPO_LOT_LAST_INVENTORY();

			if(! save_flag)
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


		#endregion

		#region 그리드 이벤트 메서드
 


		#endregion

		#region 버튼 및 기타 이벤트 메서드
 

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



		#endregion

		#region 그리드 이벤트
		 

 

		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			
			try
			{
				Display_Last_Capa();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


		private void Pop_LOTMold_Inv_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
 
 

		#endregion 

		#region 컨텍스트 메뉴 이벤트
 


		#endregion 

		#endregion 

		#region 디비 연결


		#region 조회

		
		/// <summary>
		/// Select_SPO_LOT_LAST_INVENTORY : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		private DataTable Select_SPO_LOT_LAST_INVENTORY(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPO_LOT_LAST_BSC.SELECT_SPO_LOT_LAST_INVENTORY";

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
		/// Save_SPO_LOT_LAST_INVENTORY : 
		/// </summary>
		/// <returns></returns>
		private bool Save_SPO_LOT_LAST_INVENTORY()
		{

			try
			{ 

				
				int col_ct = 12;  


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPO_LOT_LAST_BSC.SAVE_SPO_LOT_LAST_INVENTORY";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[4] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[6] = "ARG_GEN";
				MyOraDB.Parameter_Name[7] = "ARG_INV_QTY";
				MyOraDB.Parameter_Name[8] = "ARG_CYCLE_HOURLY";
				MyOraDB.Parameter_Name[9] = "ARG_HOURLY_LAST_CAPA";
				MyOraDB.Parameter_Name[10] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[11] = "ARG_UPD_USER"; 


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 



				string factory = _Factory;
				string[] token = _LOT.Split('-');
				string lot_no = token[0];
				string lot_seq = token[1]; 
				string line_cd = _LineCd;
				string style_cd = _StyleCd.Replace("-", "");
				string gen = _Gen; 
   
				int findrow = fgrid_Main.FindRow(_LevelLastInv, fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxDESC_LEVEL, false, true, false);

				if(findrow == -1) return false;

				int row_last_inv = findrow;
				int row_last_ct = findrow + 1;
				int row_last_capa = findrow + 2;

				string last_inv = "";
				string last_ct = "";
				string last_capa = "";
 

				for(int i = (int)ClassLib.TBSPO_LOT_LAST_INVENTORY.IxCS_SIZE_START; i < fgrid_Main.Cols.Count; i++)
				{

					last_inv = (fgrid_Main[row_last_inv, i] == null || fgrid_Main[row_last_inv, i].ToString().Trim().Equals("") ) ? "0" : fgrid_Main[row_last_inv, i].ToString();
					last_ct = (fgrid_Main[row_last_ct, i] == null || fgrid_Main[row_last_ct, i].ToString().Trim().Equals("") ) ? "0" : fgrid_Main[row_last_ct, i].ToString();
					last_capa = (fgrid_Main[row_last_capa, i] == null || fgrid_Main[row_last_capa, i].ToString().Trim().Equals("") ) ? "0" : fgrid_Main[row_last_capa, i].ToString();

					vList.Add(factory); 
					vList.Add(lot_no); 
					vList.Add(lot_seq);  
					vList.Add(fgrid_Main[2, i].ToString() );  //cs_size
					vList.Add(line_cd);  
					vList.Add(style_cd);  
					vList.Add(gen);  
					vList.Add(last_inv);  //inv_qty
					vList.Add(last_ct);   //cycle_hourly
					vList.Add(last_capa);   //hourly last capa
					vList.Add("");  // remarks
					vList.Add(ClassLib.ComVar.This_User); 
				
				}
   
  
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

