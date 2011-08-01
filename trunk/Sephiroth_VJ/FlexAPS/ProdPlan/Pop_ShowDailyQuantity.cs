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
	public class Pop_ShowDailyQuantity : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_T;
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
		private System.Windows.Forms.Label lbl_LOT;
		private System.Windows.Forms.TextBox txt_LOT;
		private System.Windows.Forms.TextBox txt_ObsType;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.TextBox txt_Model;
		private System.Windows.Forms.Label lbl_Model;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.TextBox txt_LineName;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.Label lbl_ObsType;
		private System.Windows.Forms.Label lbl_Line;
		private System.Windows.Forms.TextBox txt_DPO;
		private System.Windows.Forms.Label lbl_DPO;
		private COM.FSP fgrid_Main;
		private System.Windows.Forms.CheckBox chk_CheckTopMost;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자


		public Pop_ShowDailyQuantity()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


		private string _Factory = "";
		private string _LineName = "";
		private string _ModelName = "";
		private string _StyleCd = "";
		private string _Gen = "";
		private string _OBSId;
		private string _OBSType; 
		private string _LOT = "";
		private string _LOTNo = "";
		private string _LOTSeq = ""; 

		 

		public Pop_ShowDailyQuantity(string arg_factory, 
			string arg_line_name,
			string arg_model_name, 
			string arg_style_cd,
			string arg_gen, 
			string arg_obs_id, 
			string arg_obs_type,  
			string arg_lot_no,
			string arg_lot_seq)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Factory = arg_factory;
			_LineName = arg_line_name;
			_ModelName = arg_model_name;
			_StyleCd = arg_style_cd; 
			_Gen = arg_gen;
			_OBSId = arg_obs_id;
			_OBSType = arg_obs_type; 
			_LOT = arg_lot_no + "-" + arg_lot_seq;
			_LOTNo = arg_lot_no;
			_LOTSeq = arg_lot_seq;
 

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_ShowDailyQuantity));
			this.pnl_T = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.chk_CheckTopMost = new System.Windows.Forms.CheckBox();
			this.txt_DPO = new System.Windows.Forms.TextBox();
			this.lbl_DPO = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.lbl_ObsType = new System.Windows.Forms.Label();
			this.lbl_LOT = new System.Windows.Forms.Label();
			this.txt_LOT = new System.Windows.Forms.TextBox();
			this.txt_ObsType = new System.Windows.Forms.TextBox();
			this.txt_Gen = new System.Windows.Forms.TextBox();
			this.txt_Model = new System.Windows.Forms.TextBox();
			this.lbl_Model = new System.Windows.Forms.Label();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.txt_LineName = new System.Windows.Forms.TextBox();
			this.lbl_Line = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.fgrid_Main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_T.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
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
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 287);
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// pnl_T
			// 
			this.pnl_T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_T.BackColor = System.Drawing.Color.Transparent;
			this.pnl_T.Controls.Add(this.pnl_SearchImage);
			this.pnl_T.DockPadding.Bottom = 5;
			this.pnl_T.DockPadding.Left = 8;
			this.pnl_T.DockPadding.Right = 8;
			this.pnl_T.Location = new System.Drawing.Point(0, 64);
			this.pnl_T.Name = "pnl_T";
			this.pnl_T.Size = new System.Drawing.Size(1016, 64);
			this.pnl_T.TabIndex = 48;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.chk_CheckTopMost);
			this.pnl_SearchImage.Controls.Add(this.txt_DPO);
			this.pnl_SearchImage.Controls.Add(this.lbl_DPO);
			this.pnl_SearchImage.Controls.Add(this.lbl_ObsType);
			this.pnl_SearchImage.Controls.Add(this.lbl_LOT);
			this.pnl_SearchImage.Controls.Add(this.txt_LOT);
			this.pnl_SearchImage.Controls.Add(this.txt_ObsType);
			this.pnl_SearchImage.Controls.Add(this.txt_Gen);
			this.pnl_SearchImage.Controls.Add(this.txt_Model);
			this.pnl_SearchImage.Controls.Add(this.lbl_Model);
			this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.txt_LineName);
			this.pnl_SearchImage.Controls.Add(this.lbl_Line);
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
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 59);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// chk_CheckTopMost
			// 
			this.chk_CheckTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chk_CheckTopMost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_CheckTopMost.Location = new System.Drawing.Point(912, 32);
			this.chk_CheckTopMost.Name = "chk_CheckTopMost";
			this.chk_CheckTopMost.Size = new System.Drawing.Size(80, 21);
			this.chk_CheckTopMost.TabIndex = 198;
			this.chk_CheckTopMost.Text = "TOP Most";
			this.chk_CheckTopMost.CheckedChanged += new System.EventHandler(this.chk_CheckTopMost_CheckedChanged);
			// 
			// txt_DPO
			// 
			this.txt_DPO.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_DPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_DPO.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_DPO.Location = new System.Drawing.Point(508, 32);
			this.txt_DPO.MaxLength = 60;
			this.txt_DPO.Name = "txt_DPO";
			this.txt_DPO.ReadOnly = true;
			this.txt_DPO.Size = new System.Drawing.Size(55, 21);
			this.txt_DPO.TabIndex = 159;
			this.txt_DPO.Text = "";
			// 
			// lbl_DPO
			// 
			this.lbl_DPO.ImageIndex = 0;
			this.lbl_DPO.ImageList = this.img_SmallLabel;
			this.lbl_DPO.Location = new System.Drawing.Point(457, 32);
			this.lbl_DPO.Name = "lbl_DPO";
			this.lbl_DPO.Size = new System.Drawing.Size(50, 21);
			this.lbl_DPO.TabIndex = 158;
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
			// lbl_ObsType
			// 
			this.lbl_ObsType.ImageIndex = 0;
			this.lbl_ObsType.ImageList = this.img_SmallLabel;
			this.lbl_ObsType.Location = new System.Drawing.Point(576, 32);
			this.lbl_ObsType.Name = "lbl_ObsType";
			this.lbl_ObsType.Size = new System.Drawing.Size(50, 21);
			this.lbl_ObsType.TabIndex = 154;
			this.lbl_ObsType.Text = "Type";
			this.lbl_ObsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_LOT
			// 
			this.lbl_LOT.ImageIndex = 0;
			this.lbl_LOT.ImageList = this.img_SmallLabel;
			this.lbl_LOT.Location = new System.Drawing.Point(669, 32);
			this.lbl_LOT.Name = "lbl_LOT";
			this.lbl_LOT.Size = new System.Drawing.Size(50, 21);
			this.lbl_LOT.TabIndex = 145;
			this.lbl_LOT.Text = "LOT";
			this.lbl_LOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LOT
			// 
			this.txt_LOT.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOT.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LOT.Location = new System.Drawing.Point(720, 32);
			this.txt_LOT.MaxLength = 60;
			this.txt_LOT.Name = "txt_LOT";
			this.txt_LOT.ReadOnly = true;
			this.txt_LOT.Size = new System.Drawing.Size(90, 21);
			this.txt_LOT.TabIndex = 146;
			this.txt_LOT.Text = "";
			// 
			// txt_ObsType
			// 
			this.txt_ObsType.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ObsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ObsType.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ObsType.Location = new System.Drawing.Point(627, 32);
			this.txt_ObsType.MaxLength = 60;
			this.txt_ObsType.Name = "txt_ObsType";
			this.txt_ObsType.ReadOnly = true;
			this.txt_ObsType.Size = new System.Drawing.Size(30, 21);
			this.txt_ObsType.TabIndex = 155;
			this.txt_ObsType.Text = "";
			// 
			// txt_Gen
			// 
			this.txt_Gen.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Gen.Location = new System.Drawing.Point(414, 32);
			this.txt_Gen.MaxLength = 60;
			this.txt_Gen.Name = "txt_Gen";
			this.txt_Gen.ReadOnly = true;
			this.txt_Gen.Size = new System.Drawing.Size(30, 21);
			this.txt_Gen.TabIndex = 153;
			this.txt_Gen.Text = "";
			// 
			// txt_Model
			// 
			this.txt_Model.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Model.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Model.Location = new System.Drawing.Point(221, 32);
			this.txt_Model.MaxLength = 60;
			this.txt_Model.Name = "txt_Model";
			this.txt_Model.ReadOnly = true;
			this.txt_Model.Size = new System.Drawing.Size(111, 21);
			this.txt_Model.TabIndex = 152;
			this.txt_Model.Text = "";
			// 
			// lbl_Model
			// 
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_SmallLabel;
			this.lbl_Model.Location = new System.Drawing.Point(170, 32);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(50, 21);
			this.lbl_Model.TabIndex = 151;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(333, 32);
			this.txt_StyleCd.MaxLength = 60;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.ReadOnly = true;
			this.txt_StyleCd.Size = new System.Drawing.Size(80, 21);
			this.txt_StyleCd.TabIndex = 150;
			this.txt_StyleCd.Text = "";
			// 
			// txt_LineName
			// 
			this.txt_LineName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineName.Location = new System.Drawing.Point(67, 32);
			this.txt_LineName.MaxLength = 60;
			this.txt_LineName.Name = "txt_LineName";
			this.txt_LineName.ReadOnly = true;
			this.txt_LineName.Size = new System.Drawing.Size(90, 21);
			this.txt_LineName.TabIndex = 147;
			this.txt_LineName.Text = "";
			// 
			// lbl_Line
			// 
			this.lbl_Line.ImageIndex = 0;
			this.lbl_Line.ImageList = this.img_SmallLabel;
			this.lbl_Line.Location = new System.Drawing.Point(16, 32);
			this.lbl_Line.Name = "lbl_Line";
			this.lbl_Line.Size = new System.Drawing.Size(50, 21);
			this.lbl_Line.TabIndex = 144;
			this.lbl_Line.Text = "Line";
			this.lbl_Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(985, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 19);
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
			this.lbl_SubTitle1.Text = "      Selected Information";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(984, 43);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 41);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 39);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 25);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
			this.picb_MM.Location = new System.Drawing.Point(160, 24);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.Size = new System.Drawing.Size(832, 25);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(7, 128);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.Size = new System.Drawing.Size(1000, 156);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 49;
			// 
			// Pop_ShowDailyQuantity
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 309);
			this.Controls.Add(this.fgrid_Main);
			this.Controls.Add(this.pnl_T);
			this.Name = "Pop_ShowDailyQuantity";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Assign Size to LOT (Daily)";
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_T, 0);
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_T.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의
  

		//표시 레벨 정보
		private int _Level_LOT = 0; 
		private int _Level_Day = 1;



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
				this.Text = "Assign Size to LOT (Daily)";
				lbl_MainTitle.Text = "Assign Size to LOT (Daily)"; 


				fgrid_Main.Set_Grid("SPO_LOT_DAILY_SIZE_DAILY", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
				fgrid_Main.AllowSorting = AllowSortingEnum.None;
				fgrid_Main.AllowEditing = false;
				fgrid_Main.ExtendLastCol = false; 
				fgrid_Main.Font = new Font("Verdana", 7);


				Init_Control();


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


			c1ToolBar1.Visible = false;
 


			// 사이즈 헤더 할당 
			fgrid_Main.Rows.Fixed = 2;
			ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_Main, 
														_Factory, 
														_Gen, 
														fgrid_Main.Rows.Fixed,
														(int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxGEN,
														(int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxCS_SIZE_START);




			
			// 데이터 조회
			txt_LineName.Text = _LineName;
			txt_Model.Text = _ModelName;
			txt_StyleCd.Text = _StyleCd;
			txt_Gen.Text = _Gen;
			txt_DPO.Text = _OBSId;
			txt_ObsType.Text = _OBSType;
			txt_LOT.Text = _LOT;


			
			Display_LOT_DAILY_SIZE(); 



		}


		#endregion
		  
		#region 조회


		/// <summary>
		/// Display_LOT_DAILY_SIZE : 
		/// </summary>
		private void Display_LOT_DAILY_SIZE()
		{
			  
		 
			string before_item = "", now_item = ""; 
			int level = 0;
			int min_size_col = fgrid_Main.Cols.Count + 1;   //default : col max value
			int size_qty = 0;
			int insert_row = 0;


			string factory = _Factory; 
			string lot_no = _LOTNo;
			string lot_seq = _LOTSeq;

			DataTable dt_ret = Select_SPO_LOT_DAILY_SIZE_DAILY(factory, lot_no, lot_seq);
  

			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

			if(dt_ret.Rows.Count == 0) return; 


			

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{

				now_item = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxLOT_NO].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxLOT_SEQ].ToString() 
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxDAY_SEQ].ToString();


				if(before_item != now_item)
				{
				 
					level = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxTREE_LEVEL].ToString() );  
					//fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, level);
					fgrid_Main.Rows.Add();

					insert_row = fgrid_Main.Rows.Count - 1;

					for(int j = 0; j <= (int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxTOT_QTY; j++)
					{
						fgrid_Main[insert_row, j + 1] = dt_ret.Rows[i].ItemArray[j].ToString(); 
					} // end for j
	

 
					
					if(level == _Level_LOT)
					{
						fgrid_Main.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						fgrid_Main.Rows[insert_row].AllowEditing = false;
 
					} 
					else if(level == _Level_Day)
					{

						// finish_yn, plan_status color
						if(fgrid_Main[insert_row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxTS_FINISH_YN + 1].ToString() == "Y")
						{
							fgrid_Main.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrFinishY;
							fgrid_Main.Rows[insert_row].AllowEditing = false;
						}


						if(fgrid_Main[insert_row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxPLAN_STATUS + 1].ToString() == "D")
						{
							fgrid_Main.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrRelease;
							fgrid_Main.Rows[insert_row].AllowEditing = false;
						} 

					} // end if level




					
					before_item = now_item;


				} // end if



				//-------------------------------------------------------------- 
				for(int j = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxCS_SIZE_START; j < fgrid_Main.Cols.Count; j++)
				{
					if(fgrid_Main[2, j].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxCS_SIZE].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						size_qty = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxSIZE_QTY].ToString() );
						
						fgrid_Main[insert_row, j] = (size_qty.ToString() == "0") ? "" : size_qty.ToString();
						 

						break; 
					} 
				}
				//--------------------------------------------------------------




			} // end for i




			//--------------------------------------------------------------
			//SubTotals   
			fgrid_Main.SubtotalPosition = SubtotalPositionEnum.BelowData;
			fgrid_Main.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
			fgrid_Main.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;  

			fgrid_Main.Subtotal(AggregateEnum.Sum, 0, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxPLAN_STATUS + 1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxTOT_QTY + 1, "Sum is {0}");  

			for (int i = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxCS_SIZE_START; i < fgrid_Main.Cols.Count; i++)
			{
				fgrid_Main.Subtotal(AggregateEnum.Sum, 0, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxPLAN_STATUS + 1, i, "Sum is {0}");  
			}
			//--------------------------------------------------------------

			

//			fgrid_Main.Cols.Frozen = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxCS_SIZE_START;
//			fgrid_Main.Tree.Column = (int)ClassLib.TBSPO_LOT_DAILY_SIZE_DAILY_BSC.IxDESC1 + 1;
//			 
//			fgrid_Main.Tree.Show(_Level_Day);  



			fgrid_Main.LeftCol = min_size_col;


 

		}



		#endregion

		#region 툴바 이벤트 메서드
 

		#endregion

		#region 그리드 이벤트 메서드
 
		#endregion

		#region 버튼 및 기타 이벤트 메서드


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

		private void chk_CheckTopMost_CheckedChanged(object sender, System.EventArgs e)
		{
		
			if(chk_CheckTopMost.Checked)
			{
				this.TopMost = true;
			}
			else
			{
				this.TopMost = false;
			}

		}

		  
   
		#endregion

		#region 컨텍스트 메뉴 이벤트 메서드

 

		#endregion
 

		#endregion   
		
		#region 이벤트 처리

		#region 툴바 이벤트


		#endregion 

		#region 그리드 이벤트
  

		#endregion

		#region 버튼 및 기타 이벤트

		 
		#endregion

		#region 컨텍스트 메뉴 이벤트

  

		#endregion


		#endregion
		 
		#region 디비 연결
 
 
		private DataTable Select_SPO_LOT_DAILY_SIZE_DAILY(string arg_factory, string arg_lotno, string arg_lotseq)
		{

			try
			{

				COM.OraDB myOraDB = new COM.OraDB();

				DataSet ds_ret;
				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPO_LOT_DAILY_SIZE_DAY";

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





	}
}

