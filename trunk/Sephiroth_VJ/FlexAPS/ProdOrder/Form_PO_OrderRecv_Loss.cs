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
	public class Form_PO_OrderRecv_Loss : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Size;
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
		private System.Windows.Forms.TextBox txt_ReqNo;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.TextBox txt_Model;
		private System.Windows.Forms.TextBox txt_Dest;
		private System.Windows.Forms.TextBox txt_DPO;
		private System.Windows.Forms.TextBox txt_OGAC;
		private System.Windows.Forms.TextBox txt_RGAC;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_Model;
		private System.Windows.Forms.Label lbl_Dest;
		private System.Windows.Forms.Label lbl_DPO;
		private System.Windows.Forms.Label lbl_ReqNo;
		private System.Windows.Forms.Label lbl_Gac;
		private System.Windows.Forms.TextBox txt_ObsType;
		private System.ComponentModel.IContainer components = null;

		public Form_PO_OrderRecv_Loss()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_OrderRecv_Loss));
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Size = new COM.FSP();
			this.pnl_Top = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_ObsType = new System.Windows.Forms.TextBox();
			this.txt_Gen = new System.Windows.Forms.TextBox();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.txt_Model = new System.Windows.Forms.TextBox();
			this.txt_Dest = new System.Windows.Forms.TextBox();
			this.txt_DPO = new System.Windows.Forms.TextBox();
			this.txt_OGAC = new System.Windows.Forms.TextBox();
			this.txt_RGAC = new System.Windows.Forms.TextBox();
			this.txt_ReqNo = new System.Windows.Forms.TextBox();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.lbl_Model = new System.Windows.Forms.Label();
			this.lbl_Dest = new System.Windows.Forms.Label();
			this.lbl_DPO = new System.Windows.Forms.Label();
			this.lbl_ReqNo = new System.Windows.Forms.Label();
			this.lbl_Gac = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Size)).BeginInit();
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
			this.stbar.Location = new System.Drawing.Point(0, 270);
			this.stbar.Name = "stbar";
			this.stbar.Size = new System.Drawing.Size(1016, 24);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Text = "Add Loss Quantity";
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
			this.pnl_Body.Size = new System.Drawing.Size(1016, 131);
			this.pnl_Body.TabIndex = 37;
			// 
			// fgrid_Size
			// 
			this.fgrid_Size.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Size.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Size.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Size.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Size.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Size.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Size.Name = "fgrid_Size";
			this.fgrid_Size.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Size.Size = new System.Drawing.Size(1000, 123);
			this.fgrid_Size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:White;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Size.TabIndex = 47;
			this.fgrid_Size.Click += new System.EventHandler(this.fgrid_Size_Click);
			this.fgrid_Size.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Size_AfterEdit);
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
			this.pnl_SearchImage.Controls.Add(this.txt_ObsType);
			this.pnl_SearchImage.Controls.Add(this.txt_Gen);
			this.pnl_SearchImage.Controls.Add(this.txt_Style);
			this.pnl_SearchImage.Controls.Add(this.txt_Model);
			this.pnl_SearchImage.Controls.Add(this.txt_Dest);
			this.pnl_SearchImage.Controls.Add(this.txt_DPO);
			this.pnl_SearchImage.Controls.Add(this.txt_OGAC);
			this.pnl_SearchImage.Controls.Add(this.txt_RGAC);
			this.pnl_SearchImage.Controls.Add(this.txt_ReqNo);
			this.pnl_SearchImage.Controls.Add(this.lbl_Style);
			this.pnl_SearchImage.Controls.Add(this.lbl_Model);
			this.pnl_SearchImage.Controls.Add(this.lbl_Dest);
			this.pnl_SearchImage.Controls.Add(this.lbl_DPO);
			this.pnl_SearchImage.Controls.Add(this.lbl_ReqNo);
			this.pnl_SearchImage.Controls.Add(this.lbl_Gac);
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
			this.txt_ObsType.Location = new System.Drawing.Point(497, 36);
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
			this.txt_Gen.Location = new System.Drawing.Point(929, 36);
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
			this.txt_Style.Location = new System.Drawing.Point(852, 36);
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
			this.txt_Model.Location = new System.Drawing.Point(700, 36);
			this.txt_Model.MaxLength = 60;
			this.txt_Model.Name = "txt_Model";
			this.txt_Model.ReadOnly = true;
			this.txt_Model.TabIndex = 112;
			this.txt_Model.Text = "";
			// 
			// txt_Dest
			// 
			this.txt_Dest.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Dest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dest.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Dest.Location = new System.Drawing.Point(588, 36);
			this.txt_Dest.MaxLength = 60;
			this.txt_Dest.Name = "txt_Dest";
			this.txt_Dest.ReadOnly = true;
			this.txt_Dest.Size = new System.Drawing.Size(60, 21);
			this.txt_Dest.TabIndex = 111;
			this.txt_Dest.Text = "";
			// 
			// txt_DPO
			// 
			this.txt_DPO.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_DPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_DPO.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_DPO.Location = new System.Drawing.Point(436, 36);
			this.txt_DPO.MaxLength = 60;
			this.txt_DPO.Name = "txt_DPO";
			this.txt_DPO.ReadOnly = true;
			this.txt_DPO.Size = new System.Drawing.Size(60, 21);
			this.txt_DPO.TabIndex = 110;
			this.txt_DPO.Text = "";
			// 
			// txt_OGAC
			// 
			this.txt_OGAC.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OGAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OGAC.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OGAC.Location = new System.Drawing.Point(324, 36);
			this.txt_OGAC.MaxLength = 60;
			this.txt_OGAC.Name = "txt_OGAC";
			this.txt_OGAC.ReadOnly = true;
			this.txt_OGAC.Size = new System.Drawing.Size(60, 21);
			this.txt_OGAC.TabIndex = 106;
			this.txt_OGAC.Text = "";
			// 
			// txt_RGAC
			// 
			this.txt_RGAC.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_RGAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_RGAC.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_RGAC.Location = new System.Drawing.Point(263, 36);
			this.txt_RGAC.MaxLength = 60;
			this.txt_RGAC.Name = "txt_RGAC";
			this.txt_RGAC.ReadOnly = true;
			this.txt_RGAC.Size = new System.Drawing.Size(60, 21);
			this.txt_RGAC.TabIndex = 104;
			this.txt_RGAC.Text = "";
			// 
			// txt_ReqNo
			// 
			this.txt_ReqNo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ReqNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ReqNo.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ReqNo.Location = new System.Drawing.Point(61, 36);
			this.txt_ReqNo.MaxLength = 60;
			this.txt_ReqNo.Name = "txt_ReqNo";
			this.txt_ReqNo.ReadOnly = true;
			this.txt_ReqNo.TabIndex = 102;
			this.txt_ReqNo.Text = "";
			// 
			// lbl_Style
			// 
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_SmallLabel;
			this.lbl_Style.Location = new System.Drawing.Point(801, 36);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(50, 21);
			this.lbl_Style.TabIndex = 109;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_Model
			// 
			this.lbl_Model.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_SmallLabel;
			this.lbl_Model.Location = new System.Drawing.Point(649, 36);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(50, 21);
			this.lbl_Model.TabIndex = 108;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Dest
			// 
			this.lbl_Dest.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Dest.ImageIndex = 0;
			this.lbl_Dest.ImageList = this.img_SmallLabel;
			this.lbl_Dest.Location = new System.Drawing.Point(537, 36);
			this.lbl_Dest.Name = "lbl_Dest";
			this.lbl_Dest.Size = new System.Drawing.Size(50, 21);
			this.lbl_Dest.TabIndex = 107;
			this.lbl_Dest.Text = "Dest.";
			this.lbl_Dest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_DPO
			// 
			this.lbl_DPO.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_DPO.ImageIndex = 0;
			this.lbl_DPO.ImageList = this.img_SmallLabel;
			this.lbl_DPO.Location = new System.Drawing.Point(385, 36);
			this.lbl_DPO.Name = "lbl_DPO";
			this.lbl_DPO.Size = new System.Drawing.Size(50, 21);
			this.lbl_DPO.TabIndex = 106;
			this.lbl_DPO.Text = "DPO";
			this.lbl_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_ReqNo
			// 
			this.lbl_ReqNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ReqNo.ImageIndex = 0;
			this.lbl_ReqNo.ImageList = this.img_SmallLabel;
			this.lbl_ReqNo.Location = new System.Drawing.Point(10, 36);
			this.lbl_ReqNo.Name = "lbl_ReqNo";
			this.lbl_ReqNo.Size = new System.Drawing.Size(50, 21);
			this.lbl_ReqNo.TabIndex = 105;
			this.lbl_ReqNo.Text = "Req.No";
			this.lbl_ReqNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Gac
			// 
			this.lbl_Gac.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Gac.ImageIndex = 0;
			this.lbl_Gac.ImageList = this.img_Label;
			this.lbl_Gac.Location = new System.Drawing.Point(162, 36);
			this.lbl_Gac.Name = "lbl_Gac";
			this.lbl_Gac.Size = new System.Drawing.Size(100, 21);
			this.lbl_Gac.TabIndex = 34;
			this.lbl_Gac.Text = "RGAC/ OGAC";
			this.lbl_Gac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.lbl_SubTitle1.Text = "      Request";
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
			// Form_PO_OrderRecv_Loss
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 294);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Top);
			this.Name = "Form_PO_OrderRecv_Loss";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Loss Quantity";
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Load += new System.EventHandler(this.Form_PO_OrderRecv_Loss_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Top, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Size)).EndInit();
			this.pnl_Top.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
 

		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();

		private int _Rowfixed;
		private string _OrderColFlag = "v";
		private string _Factory, _ReqNo;

		#endregion 

		#region 멤버 메서드


		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			DataSet ds_ret;
			DataTable dt_recv, dt_size; 

			// Title 
			this.Text = "Add Loss Quantity";
			this.lbl_MainTitle.Text = "Add Loss Quantity";

			ClassLib.ComFunction.SetLangDic(this); 

			#region 버튼 권한

//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//			}
//			catch
//			{
//			}

			#endregion

 
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_Print.Enabled = false; 

			fgrid_Size.Set_Grid("SPO_RECV_LOSS", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, true); 
			_Rowfixed = fgrid_Size.Rows.Fixed;
			fgrid_Size.Set_Action_Image(img_Action);
			fgrid_Size.AllowSorting = AllowSortingEnum.None;

			_Factory = ClassLib.ComVar.Parameter_PopUp[0];
			_ReqNo = ClassLib.ComVar.Parameter_PopUp[1];

			ds_ret = Select_Data();
			dt_recv = ds_ret.Tables["PKG_SPO_ORDER_BSC.SELECT_SPO_RECV_REQNO_INFO"];
			Display_Data(dt_recv);
			dt_size = ds_ret.Tables["PKG_SPO_ORDER_BSC.SELECT_SEM_REQ_SIZE"];
			Set_SizeHead();
			Display_SizeData(dt_size); 

		}


		/// <summary>
		/// Display_Data : info 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Data(DataTable arg_dt)
		{
			try
			{
				txt_ReqNo.Text = _ReqNo;
				txt_RGAC.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_RECV_LOSS.IxTBRGAC].ToString();
				txt_OGAC.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_RECV_LOSS.IxTBOGAC].ToString();
				txt_DPO.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_RECV_LOSS.IxTBOBS_ID].ToString();
				txt_ObsType.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_RECV_LOSS.IxTBOBS_TYPE].ToString();
				txt_Dest.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_RECV_LOSS.IxTBDEST].ToString();
				txt_Model.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_RECV_LOSS.IxTBMODEL_NAME].ToString();
				txt_Style.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_RECV_LOSS.IxTBSTYLE_CD].ToString();
				txt_Gen.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_RECV_LOSS.IxTBGEN].ToString();

			}
			catch
			{
			}

		}

		/// <summary>
		/// Set_SizeHead : 
		/// </summary>
		private void Set_SizeHead()
		{
			DataTable dt_ret;

			try
			{
				dt_ret = Select_Gen_Size(txt_Gen.Text);

				fgrid_Size.Rows.Count = fgrid_Size.Rows.Fixed;
				fgrid_Size.Cols.Count = dt_ret.Rows.Count + (int)ClassLib.TBSPO_RECV_LOSS.IxCS_SIZE_START; 

				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_Size[1, (int)ClassLib.TBSPO_RECV_LOSS.IxCS_SIZE_START + i] = dt_ret.Rows[i].ItemArray[0];
					fgrid_Size.Cols[(int)ClassLib.TBSPO_RECV_LOSS.IxCS_SIZE_START + i].Width = 45;
					fgrid_Size.Cols[(int)ClassLib.TBSPO_RECV_LOSS.IxCS_SIZE_START + i].StyleNew.Clear();
				
				}
 
				fgrid_Size.Rows[1].TextAlign = TextAlignEnum.CenterCenter;
			}
			catch
			{
			}
  
		}
 
		/// <summary>
		/// Display_SizeData : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_SizeData(DataTable arg_dt)
		{
			int leftcol = fgrid_Size.Cols.Count - 1;

			try
			{
				fgrid_Size.Rows.Count = _Rowfixed;

				fgrid_Size.Rows.Add();
				fgrid_Size.Rows.Add();

				fgrid_Size[fgrid_Size.Rows.Count - 2, (int)ClassLib.TBSPO_RECV_LOSS.IxDESC] = "Order";
				fgrid_Size[fgrid_Size.Rows.Count - 1, (int)ClassLib.TBSPO_RECV_LOSS.IxDESC] = "Loss";

				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					for(int j = (int)ClassLib.TBSPO_RECV_LOSS.IxCS_SIZE_START; j < fgrid_Size.Cols.Count; j++)
					{
						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_RECV_LOSS.IxTBCS_SIZE].ToString() == fgrid_Size[1, j].ToString())
						{
							fgrid_Size[0, j] = _OrderColFlag; 
							fgrid_Size[fgrid_Size.Rows.Count - 2, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_RECV_LOSS.IxTBORD_QTY].ToString();
							fgrid_Size[fgrid_Size.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_RECV_LOSS.IxTBLOSS_QTY].ToString();

							leftcol = (leftcol > j) ? j : leftcol;
						}
					} // end for j
				} // end for i

				//summary
				Set_SubTotals();
 
				fgrid_Size.Cols.Frozen = (int)ClassLib.TBSPO_RECV_LOSS.IxCS_SIZE_START;
				fgrid_Size.LeftCol = leftcol - 1;  
				
			}
			catch
			{
			}
		}

		/// <summary>
		/// Set_SubTotals : 
		/// </summary>
		private void Set_SubTotals()
		{
			try
			{
				int sum = 0; 
  
				for(int i = fgrid_Size.Rows.Fixed; i < fgrid_Size.Rows.Count; i++)
				{ 
					for(int j = (int)ClassLib.TBSPO_RECV_LOSS.IxCS_SIZE_START; j < fgrid_Size.Cols.Count - 1; j++)
					{
						if(fgrid_Size[i, j] == null) continue;

						sum += Convert.ToInt32((fgrid_Size[i, j].ToString() == "") ? "0" : fgrid_Size[i, j].ToString()); 
					}

					fgrid_Size[i, (int)ClassLib.TBSPO_RECV_LOSS.IxSUM] = sum.ToString();  
					sum = 0;
 			 
				} // end for i
			}
			catch
			{
			}
		}

		#endregion 

		#region 이벤트 처리

		private void fgrid_Size_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				int selrow = fgrid_Size.Selection.r1;
				int selcol = fgrid_Size.Selection.c1;

				if(selrow == fgrid_Size.Rows.Count - 1 
					&& fgrid_Size[0, selcol] != null && fgrid_Size[0, selcol].ToString() == _OrderColFlag)
					fgrid_Size.Cols[selcol].AllowEditing = true;
				else
					fgrid_Size.Cols[selcol].AllowEditing = false;
			}
			catch
			{
			}
		}

		private void fgrid_Size_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			bool digit_flag;

			try
			{
				digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_Size[e.Row, e.Col].ToString());

				if(digit_flag == false) 
				{
					fgrid_Size[e.Row, e.Col] = "";
					return;
				} 
				Set_SubTotals();
			}
			catch
			{
			}
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				txt_ReqNo.Text = "";
				txt_RGAC.Text = "";
				txt_OGAC.Text = "";
				txt_DPO.Text = "";
				txt_ObsType.Text = "";
				txt_Dest.Text = "";
				txt_Model.Text = "";
				txt_Style.Text = "";
				txt_Gen.Text = "";

				fgrid_Size.Rows.Count = _Rowfixed;

			}
			catch
			{
			}
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataSet ds_ret;
			DataTable dt_recv, dt_size;

			try
			{
				ds_ret = Select_Data();
				dt_recv = ds_ret.Tables["PKG_SPO_ORDER_BSC.SELECT_SPO_RECV_REQNO_INFO"];
				Display_Data(dt_recv);
				dt_size = ds_ret.Tables["PKG_SPO_ORDER_BSC.SELECT_SEM_REQ_SIZE"];
				//Set_SizeHead();
				Display_SizeData(dt_size); 

			}
			catch
			{
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataSet ds_ret;
			DataTable dt_size;

			bool save_flag = false;

			try
			{
				save_flag = UPDATE_SEM_REQ_SIZE_LOSS();
				if(!save_flag) return;

				ds_ret = Select_Data(); 
				dt_size = ds_ret.Tables["PKG_SPO_ORDER_BSC.SELECT_SEM_REQ_SIZE"]; 
				Display_SizeData(dt_size); 

			}
			catch
			{
			}
		}


		#endregion
 
		#region DB Connect
 
		/// <summary>
		/// Select_Data : 
		/// </summary>
		/// <returns></returns>
		private DataSet Select_Data()
		{
			DataSet ds_ret; 

			try
			{ 
				// REQ_NO에 대한 대표 데이터 추출 - SPO_RECV
				MyOraDB.ReDim_Parameter(3); 
				MyOraDB.Process_Name = "PKG_SPO_ORDER_BSC.SELECT_SPO_RECV_REQNO_INFO";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";  
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory; 
				MyOraDB.Parameter_Values[1] = _ReqNo;  
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true);
 
				// REQ_NO에 대한 사이즈 데이터 추출
				MyOraDB.ReDim_Parameter(3); 
				MyOraDB.Process_Name = "PKG_SPO_ORDER_BSC.SELECT_SEM_REQ_SIZE";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";  
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory; 
				MyOraDB.Parameter_Values[1] = _ReqNo;  
				MyOraDB.Parameter_Values[2] = ""; 

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
		/// Select_Gen_Size : 젠더에 따른 사이즈 문대 리스트
		/// </summary>
		/// <param name="arg_gen"></param>
		/// <returns></returns>
		private DataTable Select_Gen_Size(string arg_gen)
		{ 
			DataSet ds_ret;

			try
			{
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

				if(ds_ret == null) return null ;
			
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null ;
			} 
		}

		/// <summary>
		/// UPDATE_SEM_REQ_SIZE_LOSS : 
		/// </summary>
		/// <returns></returns>
		private bool UPDATE_SEM_REQ_SIZE_LOSS()
		{
			int col_ct = 6; 
			int save_ct = 0;                      
			int para_ct =0;	 

			try
			{ 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPO_ORDER_BSC.UPDATE_SEM_REQ_SIZE_LOSS";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[3] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[4] = "ARG_LOSS_QTY";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER"; 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				} 
				 
				// 저장 행 수 구하기  
				for(int col = (int)ClassLib.TBSPO_LOT_DAILY_SIZE.IxCS_SIZE_START; col < fgrid_Size.Cols.Count - 1; col++)
				{ 
					if(fgrid_Size[0, col] == null || fgrid_Size[0, col].ToString() != _OrderColFlag) continue;
					save_ct += 1;
				} 

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[(col_ct * save_ct) + col_ct]; 

				for(int col = (int)ClassLib.TBSPO_LOT_DAILY_SIZE.IxCS_SIZE_START; col < fgrid_Size.Cols.Count - 1; col++)
				{  
					if(fgrid_Size[0, col] == null || fgrid_Size[0, col].ToString() != _OrderColFlag) continue;
					
					fgrid_Size[fgrid_Size.Rows.Count - 1, col] = (fgrid_Size[fgrid_Size.Rows.Count - 1, col] == null) ? "0" : fgrid_Size[fgrid_Size.Rows.Count - 1, col].ToString();

					//sem_req_size에 loss_qty 저장
					MyOraDB.Parameter_Values[para_ct] = "D";
					MyOraDB.Parameter_Values[para_ct + 1] = _Factory;
					MyOraDB.Parameter_Values[para_ct + 2] = _ReqNo; 
					MyOraDB.Parameter_Values[para_ct + 3] = fgrid_Size[1, col].ToString(); 
					MyOraDB.Parameter_Values[para_ct + 4] = fgrid_Size[fgrid_Size.Rows.Count - 1, col].ToString();  
					MyOraDB.Parameter_Values[para_ct + 5] = ClassLib.ComVar.This_User; 

					para_ct += col_ct;

				} // end for col   
 
				//spo_recv에 tot_loss_qty 저장
				MyOraDB.Parameter_Values[para_ct] = "H";
				MyOraDB.Parameter_Values[para_ct + 1] = _Factory;
				MyOraDB.Parameter_Values[para_ct + 2] = _ReqNo; 
				MyOraDB.Parameter_Values[para_ct + 3] = ""; 
				MyOraDB.Parameter_Values[para_ct + 4] = "";  
				MyOraDB.Parameter_Values[para_ct + 5] = ClassLib.ComVar.This_User; 


				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"UPDATE_SEM_REQ_SIZE_LOSS",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}


		}


		#endregion


		private void Form_PO_OrderRecv_Loss_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		

 

	}
}

