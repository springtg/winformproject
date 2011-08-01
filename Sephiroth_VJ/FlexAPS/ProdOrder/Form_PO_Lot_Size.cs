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
	public class Form_PO_Lot_Size : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리 

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
		private System.Windows.Forms.Label lbl_StyleCd;
		private System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Size;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.TextBox txt_LotNoSeq;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.Label lbl_Model;
		private System.Windows.Forms.TextBox txt_ObsType;
		private System.Windows.Forms.TextBox txt_ObsID;
		private System.Windows.Forms.Label lbl_DPO;

		
		private System.ComponentModel.IContainer components = null;

		public Form_PO_Lot_Size()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_Lot_Size));
			this.pnl_Top = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_ObsType = new System.Windows.Forms.TextBox();
			this.txt_ObsID = new System.Windows.Forms.TextBox();
			this.lbl_DPO = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.txt_Gen = new System.Windows.Forms.TextBox();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_StyleCd = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.txt_LotNoSeq = new System.Windows.Forms.TextBox();
			this.lbl_Model = new System.Windows.Forms.Label();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Size = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Top.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Size)).BeginInit();
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
			this.stbar.Location = new System.Drawing.Point(0, 431);
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
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
			this.pnl_Top.TabIndex = 34;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_ObsType);
			this.pnl_SearchImage.Controls.Add(this.txt_ObsID);
			this.pnl_SearchImage.Controls.Add(this.lbl_DPO);
			this.pnl_SearchImage.Controls.Add(this.txt_Gen);
			this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_StyleCd);
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
			// txt_ObsType
			// 
			this.txt_ObsType.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ObsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ObsType.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ObsType.Location = new System.Drawing.Point(313, 36);
			this.txt_ObsType.MaxLength = 60;
			this.txt_ObsType.Name = "txt_ObsType";
			this.txt_ObsType.ReadOnly = true;
			this.txt_ObsType.Size = new System.Drawing.Size(49, 21);
			this.txt_ObsType.TabIndex = 107;
			this.txt_ObsType.Text = "";
			// 
			// txt_ObsID
			// 
			this.txt_ObsID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ObsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ObsID.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ObsID.Location = new System.Drawing.Point(263, 36);
			this.txt_ObsID.MaxLength = 60;
			this.txt_ObsID.Name = "txt_ObsID";
			this.txt_ObsID.ReadOnly = true;
			this.txt_ObsID.Size = new System.Drawing.Size(49, 21);
			this.txt_ObsID.TabIndex = 106;
			this.txt_ObsID.Text = "";
			// 
			// lbl_DPO
			// 
			this.lbl_DPO.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_DPO.ImageIndex = 0;
			this.lbl_DPO.ImageList = this.img_SmallLabel;
			this.lbl_DPO.Location = new System.Drawing.Point(212, 36);
			this.lbl_DPO.Name = "lbl_DPO";
			this.lbl_DPO.Size = new System.Drawing.Size(50, 21);
			this.lbl_DPO.TabIndex = 105;
			this.lbl_DPO.Text = "DPO";
			this.lbl_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txt_Gen
			// 
			this.txt_Gen.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Gen.Location = new System.Drawing.Point(162, 36);
			this.txt_Gen.MaxLength = 60;
			this.txt_Gen.Name = "txt_Gen";
			this.txt_Gen.ReadOnly = true;
			this.txt_Gen.Size = new System.Drawing.Size(49, 21);
			this.txt_Gen.TabIndex = 104;
			this.txt_Gen.Text = "";
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(61, 36);
			this.txt_StyleCd.MaxLength = 60;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.ReadOnly = true;
			this.txt_StyleCd.TabIndex = 102;
			this.txt_StyleCd.Text = "";
			// 
			// lbl_StyleCd
			// 
			this.lbl_StyleCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_StyleCd.ImageIndex = 0;
			this.lbl_StyleCd.ImageList = this.img_SmallLabel;
			this.lbl_StyleCd.Location = new System.Drawing.Point(10, 36);
			this.lbl_StyleCd.Name = "lbl_StyleCd";
			this.lbl_StyleCd.Size = new System.Drawing.Size(50, 21);
			this.lbl_StyleCd.TabIndex = 34;
			this.lbl_StyleCd.Text = "Style";
			this.lbl_StyleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// txt_LotNoSeq
			// 
			this.txt_LotNoSeq.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LotNoSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LotNoSeq.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LotNoSeq.Location = new System.Drawing.Point(848, 56);
			this.txt_LotNoSeq.MaxLength = 60;
			this.txt_LotNoSeq.Name = "txt_LotNoSeq";
			this.txt_LotNoSeq.ReadOnly = true;
			this.txt_LotNoSeq.Size = new System.Drawing.Size(150, 21);
			this.txt_LotNoSeq.TabIndex = 106;
			this.txt_LotNoSeq.Text = "";
			this.txt_LotNoSeq.Visible = false;
			// 
			// lbl_Model
			// 
			this.lbl_Model.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_SmallLabel;
			this.lbl_Model.Location = new System.Drawing.Point(800, 56);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(50, 21);
			this.lbl_Model.TabIndex = 105;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_Model.Visible = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Size);
			this.pnl_Body.DockPadding.Bottom = 8;
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 137);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 293);
			this.pnl_Body.TabIndex = 35;
			// 
			// fgrid_Size
			// 
			this.fgrid_Size.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Size.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Size.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Size.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Size.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Size.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Size.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Size.Name = "fgrid_Size";
			this.fgrid_Size.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Size.Size = new System.Drawing.Size(1000, 285);
			this.fgrid_Size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:White;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Size.TabIndex = 47;
			this.fgrid_Size.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Size_AfterEdit);
			// 
			// Form_PO_Lot_Size
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 453);
			this.Controls.Add(this.lbl_Model);
			this.Controls.Add(this.txt_LotNoSeq);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Top);
			this.Name = "Form_PO_Lot_Size";
			this.Text = "Create LOT Size";
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Load += new System.EventHandler(this.Form_PO_Lot_Size_Load);
			this.Activated += new System.EventHandler(this.Form_PO_Lot_Size_Activated);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Top, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.txt_LotNoSeq, 0);
			this.Controls.SetChildIndex(this.lbl_Model, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Top.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Size)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		public DataTable _SizeDT = new DataTable();
		public bool _InsertFlag;

		private string _Factory, _StyleCd, _ObsID, _ObsType, _Gen;

		private string _OrdSizeFlag = "OS";
		private string _OrdLossFlag = "OL"; 
		private string _SizeRowFlag = "S";
		private string _LossRowFlag = "L"; 
		private string _SizeColFlag = "x";

		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{  

			try
			{
		 	
				//Title
				this.Text = "LOT Size / Add Loss Quantity";
				lbl_MainTitle.Text = "LOT Size / Add Loss Quantity"; 
			 
				ClassLib.ComFunction.SetLangDic(this); 
			

				fgrid_Size.Set_Grid("SPO_LOT_SIZE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_Size.Set_Action_Image(img_Action);
				fgrid_Size.Font = new Font("Verdana", 7); 


				Init_Control(); 


				//사이즈 데이터 표시
				Set_SizeData();

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


			CellStyle cellst = fgrid_Size.Styles.Add("REQ"); 
			cellst.BackColor = ClassLib.ComVar.ClrSel_Green;

			 
			_Factory = _SizeDT.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTFACTORY].ToString();
			_StyleCd = _SizeDT.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTSTYLE_CD].ToString();
			_ObsID = _SizeDT.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTOBS_ID].ToString();
			_ObsType = _SizeDT.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTOBS_TYPE].ToString();


			//사이즈 헤더 세팅  
			Set_Default_SizeHead();

			fgrid_Size.AllowSorting = AllowSortingEnum.None;
			fgrid_Size.AllowDragging = AllowDraggingEnum.None;


			txt_StyleCd.Text = _StyleCd;
			txt_ObsID.Text = _ObsID;
			txt_ObsType.Text = _ObsType;
			txt_Gen.Text = _Gen;


		}



		/// <summary>
		/// Set_Default_SizeHead : 사이즈 헤더 세팅
		/// </summary>
		private void Set_Default_SizeHead()
		{
			 
			DataTable dt_ret = Select_SEM_SIZE();
			if(dt_ret.Rows.Count == 0) return;
			_Gen = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_CSSIZE.IxGEN].ToString(); 
			
			fgrid_Size.Rows.Count = fgrid_Size.Rows.Fixed;
			fgrid_Size.Cols.Count = dt_ret.Rows.Count + (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxCS_SIZE_START;


			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				fgrid_Size[1, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxCS_SIZE_START + i] = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_CSSIZE.IxCS_SIZE];
				fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxCS_SIZE_START + i].Width = 45;
				fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxCS_SIZE_START + i].StyleNew.Clear();
			}

			fgrid_Size.Rows[1].TextAlign = TextAlignEnum.CenterCenter;
 
		}


		/// <summary>
		/// Set_SizeData : 사이즈 데이터 추출 
		/// </summary>
		private void Set_SizeData()
		{
			DataTable dt_ret;

			string before_req = "", now_req = "";
			string lotno = "", lotseq = "", before_lot = "", now_lot = "";
			int req_display_count = 0;

			try
			{ 
				fgrid_Size.Rows.Count = fgrid_Size.Rows.Fixed;


				for(int i = 0; i < _SizeDT.Rows.Count; i++)
				{ 
					now_req = _SizeDT.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTREQ_NO].ToString();

					if(before_req != now_req)
					{
						for(int j = 0; j < _SizeDT.Rows.Count; j++)
						{
							lotno = _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTLOT_NO].ToString();
							lotseq = _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTLOT_SEQ].ToString();
							now_lot = lotno + lotseq;

							if(before_lot != now_lot)
							{ 
								if(req_display_count != 0)
								{
									if(_InsertFlag) continue;
								}
								 
								dt_ret = Select_SPO_LOT_SIZE(lotno, lotseq, now_req);
								Disaply_SizeData(dt_ret);
								req_display_count++;
								

								before_lot = now_lot;
							} // end if(before_lot != now_lot)

						} // end for j

						before_req = now_req;
						before_lot = "";

					} // end if(before_req != now_req) 

				} // end for i

				int findrow = 0;

				for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
				{
					for(int j = 0; j < _SizeDT.Rows.Count; j++)
					{  
						now_lot = _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTLOT_NO].ToString()
							    + "-" + _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTLOT_SEQ].ToString();  
						findrow = fgrid_Size.FindRow(now_lot, fgrid_Size.Rows.Fixed, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT, false, true, false);
						
						//lot이 없다면 추가
						if(findrow == -1)
						{
							fgrid_Size.Rows.Add();
							fgrid_Size.Rows.Add(); 
								
							fgrid_Size[fgrid_Size.Rows.Count - 2, 0] = _SizeRowFlag; 
							fgrid_Size[fgrid_Size.Rows.Count - 1, 0] = _LossRowFlag;

							fgrid_Size.Rows[fgrid_Size.Rows.Count - 1].Visible = false;
  
							for(int a = 0; a <= 1; a++)
							{
								fgrid_Size[fgrid_Size.Rows.Count - 2 + a, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxREQ_NO] 
									= _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTREQ_NO].ToString(); 

								fgrid_Size[fgrid_Size.Rows.Count - 2 + a, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT]
									= _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTLOT_NO].ToString()
									+ "-" + _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTLOT_SEQ].ToString();

								fgrid_Size[fgrid_Size.Rows.Count - 2 + a, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxMODEL_NAME] = ""; 

								fgrid_Size[fgrid_Size.Rows.Count - 2 + a, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxSTYLE_CD] 
									= _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTSTYLE_CD].ToString(); 

								fgrid_Size[fgrid_Size.Rows.Count - 2 + a, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxOBS_ID] 
									= _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTOBS_ID].ToString(); 

								fgrid_Size[fgrid_Size.Rows.Count - 2 + a, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxOBS_TYPE] 
									= _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTOBS_TYPE].ToString(); 

								fgrid_Size[fgrid_Size.Rows.Count - 2 + a, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxPO_NO] = ""; 
 
							}
							
							fgrid_Size[fgrid_Size.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxTOT_QTY]
								= _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTLOT_QTY].ToString();
							fgrid_Size[fgrid_Size.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxSUM_QTY] = "0"; 

							fgrid_Size[fgrid_Size.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxTOT_QTY]
								= _SizeDT.Rows[j].ItemArray[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxDTLOT_LOSS_QTY].ToString();
							fgrid_Size[fgrid_Size.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxSUM_QTY] = "0"; 


						}
						else
						{
							continue;
						}
					}// end for j
				}// end for i

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_SizeData", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
		 
 

		/// <summary>
		/// Disaply_SizeData : 사이즈 데이터 그리드에 표시 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Disaply_SizeData(DataTable arg_dt)
		{ 
			string before_item = "", now_item = "";  
			int min_size_col = fgrid_Size.Cols.Count + 1;  
            string div = ""; 
			int sum_qty = 0, sum_loss = 0;
 
			try
			{ 
				if(arg_dt.Rows.Count == 0) return; 
				
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					
					now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSEM_REQ_SIZE.IxDIV].ToString() 
						     + arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSEM_REQ_SIZE.IxREQ_NO].ToString()
						     + arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSEM_REQ_SIZE.IxLOT].ToString();
 
					div = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSEM_REQ_SIZE.IxDIV].ToString();

					if(before_item != now_item)
					{ 
						sum_qty = 0;
						sum_loss = 0;

						fgrid_Size.Rows.Add();
						fgrid_Size.Rows.Add(); 
								
						if(div == "1")
						{ 
							fgrid_Size[fgrid_Size.Rows.Count - 2, 0] = _OrdSizeFlag; 
							fgrid_Size[fgrid_Size.Rows.Count - 1, 0] = _OrdLossFlag; 
						}
						else
						{
							fgrid_Size[fgrid_Size.Rows.Count - 2, 0] = _SizeRowFlag; 
							fgrid_Size[fgrid_Size.Rows.Count - 1, 0] = _LossRowFlag; 
						}
						
						//default data setting
						for(int j = 1; j <= (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxOBS_TYPE; j++)
						{ 
							fgrid_Size[fgrid_Size.Rows.Count - 2, j] = arg_dt.Rows[i].ItemArray[j].ToString(); 
							fgrid_Size[fgrid_Size.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
						}  
						
						if(div == "1")
						{
							fgrid_Size.Rows[fgrid_Size.Rows.Count - 2].Style = fgrid_Size.Styles["REQ"];
							fgrid_Size.Rows[fgrid_Size.Rows.Count - 1].Style = fgrid_Size.Styles["REQ"]; 
							fgrid_Size.Rows[fgrid_Size.Rows.Count - 2].AllowEditing = false;
							fgrid_Size.Rows[fgrid_Size.Rows.Count - 1].AllowEditing = false;
						}


						fgrid_Size.Rows[fgrid_Size.Rows.Count - 1].Visible = false;

						before_item = now_item;  
					}
 

					//--------------------------------------------------------------

					for(int j = (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxCS_SIZE_START; j < fgrid_Size.Cols.Count; j++)
					{
						if(fgrid_Size[1, j].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSEM_REQ_SIZE.IxCS_SIZE].ToString())
						{
							min_size_col = (min_size_col > j) ? j : min_size_col;
 
							fgrid_Size[fgrid_Size.Rows.Count - 2, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSEM_REQ_SIZE.IxORD_QTY].ToString(); 
							fgrid_Size[fgrid_Size.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSEM_REQ_SIZE.IxLOSS_QTY].ToString();

							if(fgrid_Size[fgrid_Size.Rows.Count - 2, j] != null) 
								sum_qty += Convert.ToInt32(fgrid_Size[fgrid_Size.Rows.Count - 2, j].ToString()); 
							 
							if(fgrid_Size[fgrid_Size.Rows.Count - 1, j] != null) 
								sum_loss += Convert.ToInt32(fgrid_Size[fgrid_Size.Rows.Count - 1, j].ToString()); 
							 
							if(div == "1") fgrid_Size[0, j] = _SizeColFlag; 

							break; 
						} 
					}  

					fgrid_Size[fgrid_Size.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxTOT_QTY] = Convert.ToString(sum_qty);
					fgrid_Size[fgrid_Size.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxSUM_QTY] = Convert.ToString(sum_qty);
					fgrid_Size[fgrid_Size.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxTOT_QTY] = Convert.ToString(sum_loss);
					fgrid_Size[fgrid_Size.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxSUM_QTY] = Convert.ToString(sum_loss);
 

//					if(div == "1")
//					{ 
//						fgrid_Size.Rows.Add();
//						fgrid_Size.Rows.Add(); 
//					}
 

				} // end for  
 

				//--------------------------------------------------------------
				//Merge 속성 
				fgrid_Size.AllowMerging = AllowMergingEnum.Free; 
				for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++) fgrid_Size.Rows[i].AllowMerging = false;  
 				fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxTOT_QTY].AllowMerging = false;
 				fgrid_Size.Cols[(int)ClassLib.TBSPO_LOT_SIZE_GRID.IxSUM_QTY].AllowMerging = false; 
 
				fgrid_Size.Cols.Frozen = (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxCS_SIZE_START;
				fgrid_Size.LeftCol = min_size_col; 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Disaply_SizeData", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}




		#endregion 
	
		#region 이벤트 처리

		 
		private void fgrid_Size_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			bool digit_flag;
//			bool check_flag = false;

			try
			{

				digit_flag = COM.ComFunction.Check_Digit(fgrid_Size[e.Row, e.Col].ToString());

				if(digit_flag == false) 
				{
					fgrid_Size[e.Row, e.Col] = "0";
					return;
				} 

				//Set SubTotal
				int sumrow = 0;

				for(int i = (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxCS_SIZE_START; i < fgrid_Size.Cols.Count; i++)
				{
					if(fgrid_Size[e.Row, i] == null || fgrid_Size[e.Row, i].ToString() == "") continue;
					sumrow += Convert.ToInt32(fgrid_Size[e.Row, i].ToString());
				}

				fgrid_Size[e.Row, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxSUM_QTY] = sumrow.ToString();
 


//				//po 중복 체크
//				if(e.Col == (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxPO_NO)
//				{
//
//					string stylecd = fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxSTYLE_CD].ToString();
//					string obstype = fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxOBS_TYPE].ToString();
//					string pono = fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxPO_NO].ToString();
//
//					Z_Form_PO_Lot lot_form = new Z_Form_PO_Lot();
//					check_flag = lot_form.Check_PO_DUPLICATE(_Factory, stylecd, obstype, pono);
//
//					if(!check_flag)
//					{
//						MessageBox.Show("Duplicate PO No");
//						fgrid_Size[fgrid_Size.Selection.r1, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxPO_NO] = "";
//						return;
//					} 
//				} // end if(e.Col == (int)ClassLib.TBSPO_LOT.IxPO_NO)
		
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Size_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 



		}
 
 

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				txt_StyleCd.Text = _StyleCd;
				txt_ObsID.Text = _ObsID;
				txt_ObsType.Text = _ObsType;
				txt_Gen.Text = _Gen;


				//사이즈 데이터 표시
				Set_SizeData();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			bool save_flag = false;

			try
			{

				this.Cursor = Cursors.WaitCursor;


				//				save_flag = Check_PO_NO();
				//
				//				if(!save_flag)
				//				{
				//					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsWrongInput + " : PO No", this);
				//					return;
				//				}
				//				else
				//				{

				save_flag = Check_Size_Balance();

				if(!save_flag)
				{
					ClassLib.ComFunction.User_Message("You need match size balance", "Check Size Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				else
				{


					save_flag = Save_Size();

					if(!save_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
					else
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this); 
					}


				}
				//				}

				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
  
		}


//		/// <summary>
//		/// 
//		/// </summary>
//		/// <returns></returns>
//		private bool Check_PO_NO()
//		{
//			string before_lot = "", now_lot = "";
//			int count = 0;
//
//			try
//			{
//				for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
//				{
//					if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT] == null
//						|| fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT].ToString() == "") continue;
//
//					now_lot = fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT].ToString();
//
//					if(before_lot != now_lot) 
//					{
//						if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxPO_NO] == null
//							|| fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxPO_NO].ToString() == "")
//						{
//							fgrid_Size.GetCellRange(i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxPO_NO).StyleNew.BackColor = ClassLib.ComVar.ClrWarning_Back;
//							count++;
//						}
//
//						before_lot = now_lot;
//					}
//
//				} // end for i
//
//				if(count > 0)
//					return false;
//				else
//					return true;
//			}
//			catch
//			{
//				return false;
//			}
//		}


		public bool Check_Size_Balance()
		{

			try
			{

				CellRange cr;

				for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
				{
					if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT] == null
						|| fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT].ToString() == "") continue;

					if(Convert.ToInt32(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxTOT_QTY].ToString() )
						!= Convert.ToInt32(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxSUM_QTY].ToString() ) )
					{

						cr = fgrid_Size.GetCellRange(i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxTOT_QTY, i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxSUM_QTY);
						cr.StyleNew.BackColor = ClassLib.ComVar.ClrWarning_Back;

						return false;
					}
					else
					{
						cr = fgrid_Size.GetCellRange(i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxTOT_QTY, i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxSUM_QTY);
						cr.StyleNew.BackColor = Color.Empty;
					}

				}


				return true;


			}
			catch
			{
				return false;
			}
		}



		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private bool Save_Size()
		{
			bool flag = false;

			try
			{
				flag = Save_SPO_LOT_SIZE();
				if(!flag) 
				{ 
					return false;
				}
				else
				{
					flag = Save_SPO_LOT();
					if(!flag) 
					{ 
						return false;
					}
					else
					{ 
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
				}
				

			}
			catch
			{ 
				return false;
			}
		}


		#endregion 

		#region DB Connect
  
		/// <summary>
		/// Select_SEM_SIZE : 스타일의 gender에 해당되는 사이즈 문대 리스트
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SEM_SIZE()
		{  
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPO_LOT_BSC.SELECT_SEM_SIZE";

				MyOraDB.ReDim_Parameter(3); 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory; 
				MyOraDB.Parameter_Values[1] = _StyleCd; 
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
		/// Select_SPO_LOT_SIZE : 
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPO_LOT_SIZE(string arg_lotno, string arg_lotseq, string arg_reqno)
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPO_LOT_BSC.SELECT_SPO_LOT_SIZE";
 
				MyOraDB.ReDim_Parameter(5); 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory; 
				MyOraDB.Parameter_Values[1] = arg_lotno; 
				MyOraDB.Parameter_Values[2] = arg_lotseq; 
				MyOraDB.Parameter_Values[3] = arg_reqno; 
				MyOraDB.Parameter_Values[4] = ""; 

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
		/// Save_SPO_LOT_SIZE : lot 사이즈 저장
		/// </summary>
		/// <returns></returns>
		public bool Save_SPO_LOT_SIZE()
		{ 
			int col_ct = 9; 
			int save_ct = 0, save_row_ct = 0;                      
			int para_ct =0;							 
			int row, col;
			string lot_no = "", lot_seq = "", req_no = "";
  

			try
			{ 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPO_LOT_BSC.SAVE_SPO_LOT_SIZE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[4] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[5] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[6] = "ARG_SIZE_QTY";
				MyOraDB.Parameter_Name[7] = "ARG_LOSS_QTY"; 
				MyOraDB.Parameter_Name[8] = "ARG_UPD_USER"; 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 
				// 저장 행 수 구하기 
				for(row = fgrid_Size.Rows.Fixed; row < fgrid_Size.Rows.Count; row++)
				{
					if(fgrid_Size[row, 0] == null) continue; 
					if(fgrid_Size[row, 0].ToString() != _SizeRowFlag) continue; 

					save_row_ct += 1;

					for(col = (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxCS_SIZE_START; col < fgrid_Size.Cols.Count; col++)
					{ 
						if(fgrid_Size[row, col] == null || fgrid_Size[row, col].ToString() == "") continue;
						save_ct += 1;
					}
				} 

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[(col_ct * save_ct) + (col_ct * (save_row_ct * 2))]; 
 
				for(row = fgrid_Size.Rows.Fixed; row < fgrid_Size.Rows.Count; row++)
				{
					if(fgrid_Size[row, 0] == null) continue; 
					if(fgrid_Size[row, 0].ToString() != _SizeRowFlag) continue;  

					string[] token = fgrid_Size[row, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT].ToString().Split('-');
					lot_no = token[0];
					lot_seq = token[1];
					req_no = fgrid_Size[row, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxREQ_NO].ToString();

					MyOraDB.Parameter_Values[para_ct] = "D";
					MyOraDB.Parameter_Values[para_ct + 1] = _Factory;
					MyOraDB.Parameter_Values[para_ct + 2] = lot_no; 
					MyOraDB.Parameter_Values[para_ct + 3] = lot_seq;  
					MyOraDB.Parameter_Values[para_ct + 4] = req_no;
					MyOraDB.Parameter_Values[para_ct + 5] = ""; 
					MyOraDB.Parameter_Values[para_ct + 6] = ""; 
					MyOraDB.Parameter_Values[para_ct + 7] = ""; 
					MyOraDB.Parameter_Values[para_ct + 8] = ClassLib.ComVar.This_User; 
 
					para_ct += col_ct;

					for(col = (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxCS_SIZE_START; col < fgrid_Size.Cols.Count; col++)
					{  
						if(fgrid_Size[row, col] == null || fgrid_Size[row, col].ToString() == "") continue;
						
						MyOraDB.Parameter_Values[para_ct] = "I";
						MyOraDB.Parameter_Values[para_ct + 1] = _Factory; 
						MyOraDB.Parameter_Values[para_ct + 2] = lot_no; 
						MyOraDB.Parameter_Values[para_ct + 3] = lot_seq;  
						MyOraDB.Parameter_Values[para_ct + 4] = req_no;
						MyOraDB.Parameter_Values[para_ct + 5] = fgrid_Size[1, col].ToString();  //cs_size
						MyOraDB.Parameter_Values[para_ct + 6] = fgrid_Size[row, col].ToString();  //size_qty
						MyOraDB.Parameter_Values[para_ct + 7] = (fgrid_Size[row + 1, col] == null || fgrid_Size[row + 1, col].ToString() == "")
							? "0" : fgrid_Size[row + 1, col].ToString();  //loss_qty
						MyOraDB.Parameter_Values[para_ct + 8] = ClassLib.ComVar.This_User; 
 
						para_ct += col_ct;

					} // end for col  

					MyOraDB.Parameter_Values[para_ct] = "L";
					MyOraDB.Parameter_Values[para_ct + 1] = _Factory;
					MyOraDB.Parameter_Values[para_ct + 2] = lot_no; 
					MyOraDB.Parameter_Values[para_ct + 3] = lot_seq;  
					MyOraDB.Parameter_Values[para_ct + 4] = "";
					MyOraDB.Parameter_Values[para_ct + 5] = ""; 
					MyOraDB.Parameter_Values[para_ct + 6] = ""; 
					MyOraDB.Parameter_Values[para_ct + 7] = ""; 
					MyOraDB.Parameter_Values[para_ct + 8] = ClassLib.ComVar.This_User; 
 
					para_ct += col_ct;


				} // end for i
 
				MyOraDB.Add_Modify_Parameter(true);	 
				
				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_SPO_LOT_SIZE", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}


		/// <summary>
		/// Save_SPO_LOT : 
		/// </summary>
		/// <returns></returns>
		public bool Save_SPO_LOT()
		{  

			int col_ct = 8;  
			int save_ct = 0;                      
			int para_ct = 0;
			string before_lot = "", now_lot = "";
			string[] token = null;
			string lotno = "", lotseq = "";


			try
			{ 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPO_LOT_BSC.SAVE_SPO_LOT_SIZE_LOT";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_REQ_NO"; 
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO"; 
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[4] = "ARG_PO_NO"; 
				MyOraDB.Parameter_Name[5] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[6] = "ARG_LEADTIME_CD"; 
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER"; 
 
				for(int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
				
			

				for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
				{
					if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT] == null
						|| fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT].ToString() == "") continue;

					now_lot = fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT].ToString();

					if(before_lot != now_lot) 
					{
						save_ct++;  
						before_lot = now_lot;
					}

				}


				before_lot = "";
				now_lot = "";

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct ]; 

				for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
				{
					if(fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT] == null
						|| fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT].ToString() == "") continue;

					now_lot = fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT].ToString();

					if(before_lot != now_lot)
					{
						token = fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxLOT].ToString().Split('-');
						lotno = token[0];
						lotseq = token[1]; 
			
						MyOraDB.Parameter_Values[para_ct] = _Factory; 
						MyOraDB.Parameter_Values[para_ct + 1] = fgrid_Size[fgrid_Size.Rows.Fixed, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxREQ_NO].ToString();
						MyOraDB.Parameter_Values[para_ct + 2] = lotno; 
						MyOraDB.Parameter_Values[para_ct + 3] = lotseq;
						MyOraDB.Parameter_Values[para_ct + 4] = fgrid_Size[i, (int)ClassLib.TBSPO_LOT_SIZE_GRID.IxPO_NO].ToString(); 
						MyOraDB.Parameter_Values[para_ct + 5] = ClassLib.ComVar.Rout_Type;
						MyOraDB.Parameter_Values[para_ct + 6] = ClassLib.ComVar.LeadTimeCode;
						MyOraDB.Parameter_Values[para_ct + 7] = ClassLib.ComVar.This_User; 

                        para_ct += col_ct;
						before_lot = now_lot;
					}

				} 
 
 
				MyOraDB.Add_Modify_Parameter(false);		 
				
				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_SPO_LOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}



		}



		#endregion


		private void Form_PO_Lot_Size_Activated(object sender, System.EventArgs e)
		{
			txt_StyleCd.Focus(); 
		}


		private void Form_PO_Lot_Size_Load(object sender, System.EventArgs e)
		{
			Init_Form();  
		}

		 


 
	}
}

