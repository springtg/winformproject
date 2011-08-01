using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient; 

namespace FlexAPS.ProdBase
{

	
	public class Pop_CreateMiniLine : COM.APSWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.ImageList img_MiniButton;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.TextBox txt_MLineQty;
		private System.Windows.Forms.Label btn_Search;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txt_OpName;
		private System.Windows.Forms.TextBox txt_OpCd;
		private System.Windows.Forms.TextBox txt_LineName;
		private System.Windows.Forms.TextBox txt_LineCd;
		private System.Windows.Forms.TextBox txt_FactoryName;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label lb_MLineQty;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_OpCd;
		private System.Windows.Forms.Label lbl_LineCd;
		public COM.FSP fgrid_MLine;
		private System.ComponentModel.IContainer components = null;

		public Pop_CreateMiniLine()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_CreateMiniLine));
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.fgrid_MLine = new COM.FSP();
			this.btn_Save = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.lb_MLineQty = new System.Windows.Forms.Label();
			this.txt_OpName = new System.Windows.Forms.TextBox();
			this.txt_OpCd = new System.Windows.Forms.TextBox();
			this.lbl_OpCd = new System.Windows.Forms.Label();
			this.txt_LineName = new System.Windows.Forms.TextBox();
			this.txt_LineCd = new System.Windows.Forms.TextBox();
			this.lbl_LineCd = new System.Windows.Forms.Label();
			this.txt_FactoryName = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.txt_MLineQty = new System.Windows.Forms.TextBox();
			this.btn_Search = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MLine)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(616, 432);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 66;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// fgrid_MLine
			// 
			this.fgrid_MLine.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_MLine.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_MLine.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_MLine.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_MLine.Location = new System.Drawing.Point(8, 141);
			this.fgrid_MLine.Name = "fgrid_MLine";
			this.fgrid_MLine.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_MLine.Size = new System.Drawing.Size(680, 285);
			this.fgrid_MLine.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_MLine.TabIndex = 64;
			// 
			// btn_Save
			// 
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.ImageIndex = 0;
			this.btn_Save.ImageList = this.img_Button;
			this.btn_Save.Location = new System.Drawing.Point(545, 432);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(70, 23);
			this.btn_Save.TabIndex = 63;
			this.btn_Save.Text = "Apply";
			this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pnl_Search
			// 
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.Bottom = 8;
			this.pnl_Search.Font = new System.Drawing.Font("굴림", 9F);
			this.pnl_Search.Location = new System.Drawing.Point(8, 46);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(679, 95);
			this.pnl_Search.TabIndex = 208;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.lb_MLineQty);
			this.pnl_SearchImage.Controls.Add(this.txt_OpName);
			this.pnl_SearchImage.Controls.Add(this.txt_OpCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_OpCd);
			this.pnl_SearchImage.Controls.Add(this.txt_LineName);
			this.pnl_SearchImage.Controls.Add(this.txt_LineCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_LineCd);
			this.pnl_SearchImage.Controls.Add(this.txt_FactoryName);
			this.pnl_SearchImage.Controls.Add(this.txt_Factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchImage.Controls.Add(this.txt_MLineQty);
			this.pnl_SearchImage.Controls.Add(this.btn_Search);
			this.pnl_SearchImage.Controls.Add(this.pictureBox1);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.Font = new System.Drawing.Font("굴림", 9F);
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(679, 87);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// lb_MLineQty
			// 
			this.lb_MLineQty.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_MLineQty.ImageIndex = 0;
			this.lb_MLineQty.ImageList = this.img_Label;
			this.lb_MLineQty.Location = new System.Drawing.Point(336, 58);
			this.lb_MLineQty.Name = "lb_MLineQty";
			this.lb_MLineQty.Size = new System.Drawing.Size(100, 21);
			this.lb_MLineQty.TabIndex = 212;
			this.lb_MLineQty.Text = "MiniLine Qty.";
			this.lb_MLineQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OpName
			// 
			this.txt_OpName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OpName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OpName.Location = new System.Drawing.Point(181, 58);
			this.txt_OpName.MaxLength = 60;
			this.txt_OpName.Name = "txt_OpName";
			this.txt_OpName.ReadOnly = true;
			this.txt_OpName.Size = new System.Drawing.Size(140, 21);
			this.txt_OpName.TabIndex = 218;
			this.txt_OpName.Text = "";
			// 
			// txt_OpCd
			// 
			this.txt_OpCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OpCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OpCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OpCd.Location = new System.Drawing.Point(111, 58);
			this.txt_OpCd.MaxLength = 60;
			this.txt_OpCd.Name = "txt_OpCd";
			this.txt_OpCd.ReadOnly = true;
			this.txt_OpCd.Size = new System.Drawing.Size(69, 21);
			this.txt_OpCd.TabIndex = 217;
			this.txt_OpCd.Text = "";
			// 
			// lbl_OpCd
			// 
			this.lbl_OpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_OpCd.ImageIndex = 0;
			this.lbl_OpCd.ImageList = this.img_Label;
			this.lbl_OpCd.Location = new System.Drawing.Point(10, 58);
			this.lbl_OpCd.Name = "lbl_OpCd";
			this.lbl_OpCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_OpCd.TabIndex = 210;
			this.lbl_OpCd.Text = "Proc.";
			this.lbl_OpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LineName
			// 
			this.txt_LineName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineName.Location = new System.Drawing.Point(507, 36);
			this.txt_LineName.MaxLength = 60;
			this.txt_LineName.Name = "txt_LineName";
			this.txt_LineName.ReadOnly = true;
			this.txt_LineName.Size = new System.Drawing.Size(140, 21);
			this.txt_LineName.TabIndex = 216;
			this.txt_LineName.Text = "";
			// 
			// txt_LineCd
			// 
			this.txt_LineCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineCd.Location = new System.Drawing.Point(437, 36);
			this.txt_LineCd.MaxLength = 60;
			this.txt_LineCd.Name = "txt_LineCd";
			this.txt_LineCd.ReadOnly = true;
			this.txt_LineCd.Size = new System.Drawing.Size(69, 21);
			this.txt_LineCd.TabIndex = 215;
			this.txt_LineCd.Text = "";
			// 
			// lbl_LineCd
			// 
			this.lbl_LineCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LineCd.ImageIndex = 0;
			this.lbl_LineCd.ImageList = this.img_Label;
			this.lbl_LineCd.Location = new System.Drawing.Point(336, 36);
			this.lbl_LineCd.Name = "lbl_LineCd";
			this.lbl_LineCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_LineCd.TabIndex = 209;
			this.lbl_LineCd.Text = "Line";
			this.lbl_LineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_FactoryName
			// 
			this.txt_FactoryName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_FactoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_FactoryName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_FactoryName.Location = new System.Drawing.Point(181, 36);
			this.txt_FactoryName.MaxLength = 60;
			this.txt_FactoryName.Name = "txt_FactoryName";
			this.txt_FactoryName.ReadOnly = true;
			this.txt_FactoryName.Size = new System.Drawing.Size(140, 21);
			this.txt_FactoryName.TabIndex = 214;
			this.txt_FactoryName.Text = "";
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Factory.Location = new System.Drawing.Point(111, 36);
			this.txt_Factory.MaxLength = 60;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.ReadOnly = true;
			this.txt_Factory.Size = new System.Drawing.Size(69, 21);
			this.txt_Factory.TabIndex = 213;
			this.txt_Factory.Text = "";
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 211;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_MLineQty
			// 
			this.txt_MLineQty.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_MLineQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_MLineQty.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_MLineQty.Location = new System.Drawing.Point(437, 58);
			this.txt_MLineQty.MaxLength = 60;
			this.txt_MLineQty.Name = "txt_MLineQty";
			this.txt_MLineQty.ReadOnly = true;
			this.txt_MLineQty.Size = new System.Drawing.Size(210, 21);
			this.txt_MLineQty.TabIndex = 207;
			this.txt_MLineQty.Text = "";
			// 
			// btn_Search
			// 
			this.btn_Search.BackColor = System.Drawing.SystemColors.Control;
			this.btn_Search.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_MiniButton;
			this.btn_Search.Location = new System.Drawing.Point(648, 58);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(21, 21);
			this.btn_Search.TabIndex = 205;
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(152, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(512, 40);
			this.pictureBox1.TabIndex = 208;
			this.pictureBox1.TabStop = false;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(662, 27);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(24, 47);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(663, 0);
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
			this.picb_TM.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(455, 32);
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
			this.lbl_SubTitle1.Text = "      MiniLine Information";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(663, 72);
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
			this.picb_BM.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(144, 71);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(519, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 72);
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
			this.picb_ML.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 54);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.Location = new System.Drawing.Point(0, 0);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.TabIndex = 0;
			this.picb_MM.TabStop = false;
			// 
			// Pop_CreateMiniLine
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.fgrid_MLine);
			this.Controls.Add(this.pnl_Search);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Name = "Pop_CreateMiniLine";
			this.Text = "Select MiniLine";
			this.Load += new System.EventHandler(this.Pop_CreateMiniLine_Load);
			this.Controls.SetChildIndex(this.btn_Save, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.fgrid_MLine, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MLine)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

  
		#region 변수 정의 

 
		private COM.OraDB MyOraDB = new COM.OraDB();

		//미리 선택되어진 미니라인
		private string _SelMLineCd;


		// 체크된 행을 한꺼번에 옮기기 위해서 데이터 테이블 생성
		public DataTable _DTSelMLine = new DataTable(); 

		//폼 닫힐때 일어난 이벤트 (save : true, cancel : false)
		public bool _CloseSave;
 

		#endregion 

		#region 멤버 메서드


		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			DataTable dt_ret;

			int findrow = 0;
 
			//Title
			this.Text = "Select MiniLine";
			this.lbl_MainTitle.Text = "Select MiniLine";
 
			ClassLib.ComFunction.SetLangDic(this);



			txt_Factory.Text = ClassLib.ComVar.Parameter_PopUp[0];  
			txt_FactoryName.Text = ClassLib.ComVar.Parameter_PopUp[1];
			txt_LineCd.Text = ClassLib.ComVar.Parameter_PopUp[2];
			txt_LineName.Text = ClassLib.ComVar.Parameter_PopUp[3];
			txt_OpCd.Text = ClassLib.ComVar.Parameter_PopUp[4];
			txt_OpName.Text = ClassLib.ComVar.Parameter_PopUp[5];
			txt_MLineQty.Text = ClassLib.ComVar.Parameter_PopUp[6];
			_SelMLineCd = ClassLib.ComVar.Parameter_PopUp[7];
 

 			fgrid_MLine.Set_Grid("SPB_OPCD_LINE", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			
			//-------------------------------------------------------------------------------------------  
			for(int i = (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxCHECK_FLAG; i <= (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxREMARKS; i++)
				_DTSelMLine.Columns.Add(new DataColumn(fgrid_MLine[0, i].ToString(), Type.GetType("System.String")));
			//-------------------------------------------------------------------------------------------  
			 

			dt_ret = Select_SPB_OPCD_LINE();
			Display_Grid(dt_ret, fgrid_MLine);

			//------------------------------------------------------------------------------------------
			string[] token = _SelMLineCd.Split('/'); 

			for(int i = 0; i < token.Length - 1; i++)
			{ 
				findrow = fgrid_MLine.FindRow(token[i], fgrid_MLine.Rows.Fixed, (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxOP_LINE, false, true, false);
				if(findrow == -1) continue;
				fgrid_MLine[findrow, (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxCHECK_FLAG] = "TRUE";
				fgrid_MLine[findrow, (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxSEL_YN] = "Y";
 
			}

			
			
		}


		/// <summary>
		/// Close_Form : Form Close 시 작업
		/// </summary>
		private void Close_Form()
		{
			this.Close();
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


		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;  
			src.ImageIndex = 1;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;  
			src.ImageIndex = 0;
		}
 



		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			dt_ret = Select_SPB_OPCD_LINE();
			Display_Grid(dt_ret, fgrid_MLine);
		}



		private void btn_Save_Click(object sender, System.EventArgs e)
		{
 
			DataRow newrow;
 
			for(int i = fgrid_MLine.Rows.Fixed; i < fgrid_MLine.Rows.Count; i++)
			{
//				//이미 선택되어진것 제외
//				if(fgrid_MLine[i, (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxSEL_YN].ToString() == "Y") continue;
//
//				if(!Convert.ToBoolean(fgrid_MLine[i, (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxCHECK_FLAG].ToString())) continue;
//				
//				newrow = _DTSelMLine.NewRow();
//
//
//				for(int j = (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxCHECK_FLAG; j <= (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxREMARKS; j++)
//					newrow[j - (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxCHECK_FLAG] = fgrid_MLine[i, j].ToString();
//
//				
//				_DTSelMLine.Rows.Add(newrow); 

 
				newrow = _DTSelMLine.NewRow();

				switch(fgrid_MLine[i, (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxSEL_YN].ToString())
				{
					case "Y":

						// 선택취소 -> Delete
						if(!Convert.ToBoolean(fgrid_MLine[i, (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxCHECK_FLAG].ToString()))
							newrow[0] = "D";
						else
							newrow[0] = "U";

						break;

					case "N":

						if(Convert.ToBoolean(fgrid_MLine[i, (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxCHECK_FLAG].ToString()))
							newrow[0] = "I";
						 
						break;
				}



				if(Convert.ToString(newrow[0]) == "" || newrow[0] == null) continue;

				for(int j = (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxCHECK_FLAG + 1; j <= (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxREMARKS; j++)
					newrow[j - (int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxCHECK_FLAG] = fgrid_MLine[i, j].ToString();

				
				_DTSelMLine.Rows.Add(newrow); 



			} // end for i


			_CloseSave = true;
			Close_Form();

 
		}



		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_CloseSave = false;
			Close_Form();
		}




		#endregion 

		#region DB Connect
 

		/// <summary>
		/// Select_SPB_OPCD_LINE : 공정의 미니라인 리스트
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_OPCD_LINE()
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SPB_LINE.SELECT_SPB_OPCD_LINE";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OP_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = txt_Factory.Text;
			MyOraDB.Parameter_Values[1] = txt_OpCd.Text;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 


		}



		#endregion



		
		private void Pop_CreateMiniLine_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		

	


	}
 
}

