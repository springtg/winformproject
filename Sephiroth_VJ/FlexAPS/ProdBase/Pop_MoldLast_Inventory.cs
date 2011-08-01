using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdBase
{
	public class Pop_MoldLast_Inventory : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.ImageList img_SmallLabel;
		private COM.FSP fgrid_LastInv;
		public System.Windows.Forms.Panel pnl_LSearchSplitLeft;
		public System.Windows.Forms.Panel pnl_SearchLeftImage;
		private System.Windows.Forms.Label lbl_Total;
		private System.Windows.Forms.TextBox txt_ModelName;
		private System.Windows.Forms.TextBox txt_ModelCd;
		private System.Windows.Forms.TextBox txt_LineCd;
		private System.Windows.Forms.TextBox txt_Gender;
		private System.Windows.Forms.TextBox txt_LastName;
		private System.Windows.Forms.TextBox txt_LastCd;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label lbl_Model;
		private System.Windows.Forms.Label lbl_Line;
		private System.Windows.Forms.Label lbl_Last;
		public System.Windows.Forms.PictureBox picb_LMR;
		public System.Windows.Forms.PictureBox picb_LBR;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_LBM;
		public System.Windows.Forms.PictureBox picb_LTR;
		public System.Windows.Forms.PictureBox picb_LTM;
		public System.Windows.Forms.PictureBox picb_LMM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_LML;
		public System.Windows.Forms.PictureBox picb_LBL;
		private System.Windows.Forms.TextBox txt_TotalQty;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자

		public Pop_MoldLast_Inventory()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		//string[] pop_parameter = new string[] { factory, last_cd, last_name, gender, line_cd, line_name, model_cd, model_name };


		string _Factory;
		string _LastCd;
		string _LastName;
		string _Gender;
		string _LineCd;
		string _LineName;
		string _ModelCd;
		string _ModelName;

		public Pop_MoldLast_Inventory(string[] arg_pop_parameter)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Factory   = arg_pop_parameter[0];
			_LastCd    = arg_pop_parameter[1];
			_LastName  = arg_pop_parameter[2];
			_Gender    = arg_pop_parameter[3];
			_LineCd    = arg_pop_parameter[4];
			_LineName  = arg_pop_parameter[5];
			_ModelCd   = arg_pop_parameter[6];
			_ModelName = arg_pop_parameter[7];

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_MoldLast_Inventory));
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.fgrid_LastInv = new COM.FSP();
			this.pnl_LSearchSplitLeft = new System.Windows.Forms.Panel();
			this.pnl_SearchLeftImage = new System.Windows.Forms.Panel();
			this.txt_TotalQty = new System.Windows.Forms.TextBox();
			this.lbl_Total = new System.Windows.Forms.Label();
			this.txt_ModelName = new System.Windows.Forms.TextBox();
			this.txt_ModelCd = new System.Windows.Forms.TextBox();
			this.txt_LineCd = new System.Windows.Forms.TextBox();
			this.txt_Gender = new System.Windows.Forms.TextBox();
			this.txt_LastName = new System.Windows.Forms.TextBox();
			this.txt_LastCd = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.lbl_Model = new System.Windows.Forms.Label();
			this.lbl_Line = new System.Windows.Forms.Label();
			this.lbl_Last = new System.Windows.Forms.Label();
			this.picb_LMR = new System.Windows.Forms.PictureBox();
			this.picb_LBR = new System.Windows.Forms.PictureBox();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.picb_LBM = new System.Windows.Forms.PictureBox();
			this.picb_LTR = new System.Windows.Forms.PictureBox();
			this.picb_LTM = new System.Windows.Forms.PictureBox();
			this.picb_LMM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_LML = new System.Windows.Forms.PictureBox();
			this.picb_LBL = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LastInv)).BeginInit();
			this.pnl_LSearchSplitLeft.SuspendLayout();
			this.pnl_SearchLeftImage.SuspendLayout();
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
			this.stbar.Location = new System.Drawing.Point(0, 217);
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// fgrid_LastInv
			// 
			this.fgrid_LastInv.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_LastInv.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_LastInv.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_LastInv.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_LastInv.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_LastInv.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_LastInv.Location = new System.Drawing.Point(5, 136);
			this.fgrid_LastInv.Name = "fgrid_LastInv";
			this.fgrid_LastInv.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_LastInv.Size = new System.Drawing.Size(1007, 80);
			this.fgrid_LastInv.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_LastInv.TabIndex = 48;
			this.fgrid_LastInv.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_LastInv_BeforeEdit);
			this.fgrid_LastInv.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_LastInv_AfterEdit);
			// 
			// pnl_LSearchSplitLeft
			// 
			this.pnl_LSearchSplitLeft.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_LSearchSplitLeft.Controls.Add(this.pnl_SearchLeftImage);
			this.pnl_LSearchSplitLeft.DockPadding.All = 5;
			this.pnl_LSearchSplitLeft.Location = new System.Drawing.Point(0, 64);
			this.pnl_LSearchSplitLeft.Name = "pnl_LSearchSplitLeft";
			this.pnl_LSearchSplitLeft.Size = new System.Drawing.Size(1016, 72);
			this.pnl_LSearchSplitLeft.TabIndex = 49;
			// 
			// pnl_SearchLeftImage
			// 
			this.pnl_SearchLeftImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchLeftImage.Controls.Add(this.txt_TotalQty);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Total);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_ModelName);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_ModelCd);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_LineCd);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_Gender);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_LastName);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_LastCd);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_Factory);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Model);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Line);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Last);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBR);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMM);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LML);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBL);
			this.pnl_SearchLeftImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchLeftImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchLeftImage.Location = new System.Drawing.Point(5, 5);
			this.pnl_SearchLeftImage.Name = "pnl_SearchLeftImage";
			this.pnl_SearchLeftImage.Size = new System.Drawing.Size(1006, 62);
			this.pnl_SearchLeftImage.TabIndex = 19;
			// 
			// txt_TotalQty
			// 
			this.txt_TotalQty.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_TotalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_TotalQty.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_TotalQty.Location = new System.Drawing.Point(899, 36);
			this.txt_TotalQty.MaxLength = 10;
			this.txt_TotalQty.Name = "txt_TotalQty";
			this.txt_TotalQty.ReadOnly = true;
			this.txt_TotalQty.Size = new System.Drawing.Size(56, 21);
			this.txt_TotalQty.TabIndex = 221;
			this.txt_TotalQty.Text = "";
			// 
			// lbl_Total
			// 
			this.lbl_Total.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Total.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Total.ImageIndex = 0;
			this.lbl_Total.ImageList = this.img_Label;
			this.lbl_Total.Location = new System.Drawing.Point(798, 36);
			this.lbl_Total.Name = "lbl_Total";
			this.lbl_Total.Size = new System.Drawing.Size(100, 21);
			this.lbl_Total.TabIndex = 220;
			this.lbl_Total.Text = "Inventory Qty.";
			this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_ModelName
			// 
			this.txt_ModelName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ModelName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ModelName.Location = new System.Drawing.Point(658, 36);
			this.txt_ModelName.MaxLength = 10;
			this.txt_ModelName.Name = "txt_ModelName";
			this.txt_ModelName.ReadOnly = true;
			this.txt_ModelName.Size = new System.Drawing.Size(128, 21);
			this.txt_ModelName.TabIndex = 219;
			this.txt_ModelName.Text = "";
			// 
			// txt_ModelCd
			// 
			this.txt_ModelCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ModelCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ModelCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ModelCd.Location = new System.Drawing.Point(601, 36);
			this.txt_ModelCd.MaxLength = 10;
			this.txt_ModelCd.Name = "txt_ModelCd";
			this.txt_ModelCd.ReadOnly = true;
			this.txt_ModelCd.Size = new System.Drawing.Size(56, 21);
			this.txt_ModelCd.TabIndex = 218;
			this.txt_ModelCd.Text = "";
			// 
			// txt_LineCd
			// 
			this.txt_LineCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineCd.Location = new System.Drawing.Point(483, 36);
			this.txt_LineCd.MaxLength = 10;
			this.txt_LineCd.Name = "txt_LineCd";
			this.txt_LineCd.ReadOnly = true;
			this.txt_LineCd.Size = new System.Drawing.Size(56, 21);
			this.txt_LineCd.TabIndex = 216;
			this.txt_LineCd.Text = "";
			// 
			// txt_Gender
			// 
			this.txt_Gender.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gender.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Gender.Location = new System.Drawing.Point(365, 36);
			this.txt_Gender.MaxLength = 10;
			this.txt_Gender.Name = "txt_Gender";
			this.txt_Gender.ReadOnly = true;
			this.txt_Gender.Size = new System.Drawing.Size(56, 21);
			this.txt_Gender.TabIndex = 215;
			this.txt_Gender.Text = "";
			// 
			// txt_LastName
			// 
			this.txt_LastName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LastName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LastName.Location = new System.Drawing.Point(236, 36);
			this.txt_LastName.MaxLength = 10;
			this.txt_LastName.Name = "txt_LastName";
			this.txt_LastName.ReadOnly = true;
			this.txt_LastName.Size = new System.Drawing.Size(128, 21);
			this.txt_LastName.TabIndex = 214;
			this.txt_LastName.Text = "";
			// 
			// txt_LastCd
			// 
			this.txt_LastCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LastCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LastCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LastCd.Location = new System.Drawing.Point(179, 36);
			this.txt_LastCd.MaxLength = 10;
			this.txt_LastCd.Name = "txt_LastCd";
			this.txt_LastCd.ReadOnly = true;
			this.txt_LastCd.Size = new System.Drawing.Size(56, 21);
			this.txt_LastCd.TabIndex = 213;
			this.txt_LastCd.Text = "";
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Factory.Location = new System.Drawing.Point(61, 36);
			this.txt_Factory.MaxLength = 10;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.ReadOnly = true;
			this.txt_Factory.Size = new System.Drawing.Size(56, 21);
			this.txt_Factory.TabIndex = 212;
			this.txt_Factory.Text = "";
			// 
			// lbl_Model
			// 
			this.lbl_Model.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Model.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_SmallLabel;
			this.lbl_Model.Location = new System.Drawing.Point(552, 36);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(48, 21);
			this.lbl_Model.TabIndex = 32;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Line
			// 
			this.lbl_Line.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Line.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Line.ImageIndex = 0;
			this.lbl_Line.ImageList = this.img_SmallLabel;
			this.lbl_Line.Location = new System.Drawing.Point(432, 36);
			this.lbl_Line.Name = "lbl_Line";
			this.lbl_Line.Size = new System.Drawing.Size(50, 21);
			this.lbl_Line.TabIndex = 31;
			this.lbl_Line.Text = "Line";
			this.lbl_Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Last
			// 
			this.lbl_Last.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Last.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Last.ImageIndex = 0;
			this.lbl_Last.ImageList = this.img_SmallLabel;
			this.lbl_Last.Location = new System.Drawing.Point(128, 36);
			this.lbl_Last.Name = "lbl_Last";
			this.lbl_Last.Size = new System.Drawing.Size(50, 21);
			this.lbl_Last.TabIndex = 30;
			this.lbl_Last.Text = "Last";
			this.lbl_Last.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_LMR
			// 
			this.picb_LMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LMR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMR.Image")));
			this.picb_LMR.Location = new System.Drawing.Point(991, 24);
			this.picb_LMR.Name = "picb_LMR";
			this.picb_LMR.Size = new System.Drawing.Size(23, 22);
			this.picb_LMR.TabIndex = 26;
			this.picb_LMR.TabStop = false;
			// 
			// picb_LBR
			// 
			this.picb_LBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBR.Image")));
			this.picb_LBR.Location = new System.Drawing.Point(990, 46);
			this.picb_LBR.Name = "picb_LBR";
			this.picb_LBR.Size = new System.Drawing.Size(24, 16);
			this.picb_LBR.TabIndex = 23;
			this.picb_LBR.TabStop = false;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_SmallLabel;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(50, 21);
			this.lbl_Factory.TabIndex = 13;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_LBM
			// 
			this.picb_LBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBM.Image")));
			this.picb_LBM.Location = new System.Drawing.Point(131, 44);
			this.picb_LBM.Name = "picb_LBM";
			this.picb_LBM.Size = new System.Drawing.Size(1006, 18);
			this.picb_LBM.TabIndex = 28;
			this.picb_LBM.TabStop = false;
			// 
			// picb_LTR
			// 
			this.picb_LTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LTR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTR.Image")));
			this.picb_LTR.Location = new System.Drawing.Point(990, 0);
			this.picb_LTR.Name = "picb_LTR";
			this.picb_LTR.Size = new System.Drawing.Size(24, 32);
			this.picb_LTR.TabIndex = 21;
			this.picb_LTR.TabStop = false;
			// 
			// picb_LTM
			// 
			this.picb_LTM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LTM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LTM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTM.Image")));
			this.picb_LTM.Location = new System.Drawing.Point(224, 0);
			this.picb_LTM.Name = "picb_LTM";
			this.picb_LTM.Size = new System.Drawing.Size(1006, 32);
			this.picb_LTM.TabIndex = 0;
			this.picb_LTM.TabStop = false;
			// 
			// picb_LMM
			// 
			this.picb_LMM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LMM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LMM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMM.Image")));
			this.picb_LMM.Location = new System.Drawing.Point(160, 24);
			this.picb_LMM.Name = "picb_LMM";
			this.picb_LMM.Size = new System.Drawing.Size(1006, 22);
			this.picb_LMM.TabIndex = 27;
			this.picb_LMM.TabStop = false;
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
			this.lbl_SubTitle1.TabIndex = 20;
			this.lbl_SubTitle1.Text = "      Last Information";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_LML
			// 
			this.picb_LML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_LML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LML.Image = ((System.Drawing.Image)(resources.GetObject("picb_LML.Image")));
			this.picb_LML.Location = new System.Drawing.Point(0, 24);
			this.picb_LML.Name = "picb_LML";
			this.picb_LML.Size = new System.Drawing.Size(168, 22);
			this.picb_LML.TabIndex = 25;
			this.picb_LML.TabStop = false;
			// 
			// picb_LBL
			// 
			this.picb_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_LBL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBL.Image")));
			this.picb_LBL.Location = new System.Drawing.Point(0, 42);
			this.picb_LBL.Name = "picb_LBL";
			this.picb_LBL.Size = new System.Drawing.Size(168, 20);
			this.picb_LBL.TabIndex = 22;
			this.picb_LBL.TabStop = false;
			// 
			// Pop_MoldLast_Inventory
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 239);
			this.Controls.Add(this.pnl_LSearchSplitLeft);
			this.Controls.Add(this.fgrid_LastInv);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Pop_MoldLast_Inventory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Controls.SetChildIndex(this.fgrid_LastInv, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_LSearchSplitLeft, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LastInv)).EndInit();
			this.pnl_LSearchSplitLeft.ResumeLayout(false);
			this.pnl_SearchLeftImage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의


		private COM.OraDB MyOraDB = new COM.OraDB(); 

		
		//수정하기 전 수량
		private string _BeforeQty;



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
				this.Text = "Last Inventory";
				this.lbl_MainTitle.Text = "Last Inventory"; 
  
				
				fgrid_LastInv.Set_Grid("SPB_MOLD_LAST_INV", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
				fgrid_LastInv.Set_Action_Image(img_Action); 
				//fgrid_LastInv.Font = new Font("Verdana", 7);
 

				//Set Combo List
				Init_Control(); 
				 

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


			txt_Factory.Text = _Factory;
			txt_LastCd.Text = _LastCd;
			txt_LastName.Text = _LastName;
			txt_Gender.Text = _Gender;
			txt_LineCd.Text = _LineCd;
			txt_ModelCd.Text = _ModelCd;
			txt_ModelName.Text = _ModelName;
			


			// 사이즈 헤더 할당 
			fgrid_LastInv.Rows.Fixed = 2;
			ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_LastInv, 
														_Factory, 
														_Gender, 
														fgrid_LastInv.Rows.Fixed,
														(int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxGEN,
														(int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxCS_SIZE_START);


		} 
		
 


		#endregion 

		#region 조회


	 

		#endregion 

		#region 툴바 이벤트 메서드


		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{

			 


		} 


		private void Event_Tbtn_Search()
		{

			string last_seq = "00";
			DataTable dt_ret = Select_SPB_MOLD_LAST_INV(_Factory, _LastCd, _LineCd, _ModelCd, last_seq);

			//if(dt_ret.Rows.Count == 0) return;
 

			Display_Qty(dt_ret, fgrid_LastInv);


		}


		/// <summary>
		/// Display_Qty : 
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Qty(DataTable arg_dt, COM.FSP arg_fgrid)
		{

			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;


			// 1. inv_qty row
			// 2. cycle_hourly row
			arg_fgrid.Rows.Add();
			arg_fgrid.Rows.Add();

			// header
			arg_fgrid[arg_fgrid.Rows.Count - 2, (int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxDESCRIPTION] = "Quantity";
			arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxDESCRIPTION] = "Cycle (Hourly)";

			
			
			if(arg_dt.Rows.Count == 0) return;


			for(int i = (int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxFACTORY; i <= (int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxTOT_QTY; i++)
			{
				if(i == (int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxDESCRIPTION) continue;

				arg_fgrid[arg_fgrid.Rows.Count - 2, i] = arg_dt.Rows[0].ItemArray[i - 1].ToString();
				arg_fgrid[arg_fgrid.Rows.Count - 1, i] = arg_dt.Rows[0].ItemArray[i - 1].ToString();

			} // end for i

			// tail
			int min_size_col = arg_fgrid.Cols.Count + 1;
			int inv_qty = 0;
			int sum_inv_qty = 0;
			int cycle_hourly = 0;

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				for(int j = (int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxCS_SIZE_START; j < arg_fgrid.Cols.Count; j++)
				{
					if(arg_fgrid[2, j].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxTBCS_SIZE].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						inv_qty = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxTBINV_QTY].ToString() );
						cycle_hourly = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxTBCYCLE_HOURLY].ToString() );

						arg_fgrid[arg_fgrid.Rows.Count - 2, j] = (inv_qty.ToString() == "0") ? "" : inv_qty.ToString();

						// inventory qty 있는 경우에 Cycle 표시 (Default : 1)
						if(! arg_fgrid[arg_fgrid.Rows.Count - 2, j].ToString().Trim().Equals("") )
						{
							arg_fgrid[arg_fgrid.Rows.Count - 1, j] = (cycle_hourly.ToString() == "0") ? "" : cycle_hourly.ToString();
						}
						 

						sum_inv_qty += inv_qty;

						break; 
					} 
				} // end for j

			} // end for i


			arg_fgrid[arg_fgrid.Rows.Count - 2, (int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxTOT_QTY] = sum_inv_qty.ToString();
			txt_TotalQty.Text = sum_inv_qty.ToString();


			arg_fgrid.LeftCol = min_size_col;




		}




		private void Event_Tbtn_Save()
		{

			bool save_flag = Save_SPB_MOLD_LAST_INV();

			if(! save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave);
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave); 

				Event_Tbtn_Search();
			}

			 

		}


		private void Event_Tbtn_Delete()
		{

			 

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
				Event_Tbtn_Search(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				Event_Tbtn_Save(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		 
		private void fgrid_LastInv_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(fgrid_LastInv[e.Row, e.Col] == null)  fgrid_LastInv[e.Row, e.Col] = ""; 
			_BeforeQty = (fgrid_LastInv[e.Row, e.Col].ToString() == "") ? "0": fgrid_LastInv[e.Row, e.Col].ToString();
		}

		private void fgrid_LastInv_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			bool digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_LastInv[e.Row, e.Col].ToString());

			if(digit_flag == false) 
			{
				fgrid_LastInv[e.Row, e.Col] = _BeforeQty;
				return;
			}

			
			// cycle_hourly default : 1
			if(e.Row == fgrid_LastInv.Rows.Count - 2)
			{
				fgrid_LastInv[fgrid_LastInv.Rows.Count - 1, e.Col] = "1";
			}
			 

			Display_Qty_Balance(); 
		
		}

		/// <summary>
		/// Display_Qty_Balance : total 재계산
		/// </summary>
		private void Display_Qty_Balance()
		{
			
			int sum_inv_qty = 0;

			for(int i = (int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxCS_SIZE_START; i < fgrid_LastInv.Cols.Count; i++)
			{
				if(fgrid_LastInv[fgrid_LastInv.Rows.Count - 2, i] == null
					|| fgrid_LastInv[fgrid_LastInv.Rows.Count - 2, i].ToString().Trim() == "") continue;

				sum_inv_qty += Convert.ToInt32( fgrid_LastInv[fgrid_LastInv.Rows.Count - 2, i].ToString() );

			} // end for i

			fgrid_LastInv[fgrid_LastInv.Rows.Count - 2, (int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxTOT_QTY] = sum_inv_qty.ToString();
			//txt_TotalQty.Text = sum_inv_qty.ToString();
				
				
		}


		#endregion

		#region 버튼 및 기타 이벤트

  

		#endregion  

		#region 컨텍스트 메뉴 이벤트


		 

		#endregion 

		#endregion 

		#region 디비 연결

 
		#region 조회

		 
		/// <summary>
		/// Select_SPB_MOLD_LAST_INV : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_last_cd"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_model_cd"></param>
		/// <param name="arg_last_seq"></param>
		/// <returns></returns>
		private DataTable Select_SPB_MOLD_LAST_INV(string arg_factory, string arg_last_cd, string arg_line_cd, string arg_model_cd, string arg_last_seq)
		{

			try
			{

				DataSet ds_ret;

				string process_name = "PKG_SPB_MOLD_LAST_BSC.SELECT_SPB_MOLD_LAST_INV";

				MyOraDB.ReDim_Parameter(6); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_LAST_CD";  
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_MODEL_CD";  
				MyOraDB.Parameter_Name[4] = "ARG_LAST_SEQ";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory;  
				MyOraDB.Parameter_Values[1] = arg_last_cd; 
				MyOraDB.Parameter_Values[2] = arg_line_cd; 
				MyOraDB.Parameter_Values[3] = arg_model_cd; 
				MyOraDB.Parameter_Values[4] = arg_last_seq; 
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

		#endregion 
		
		#region 저장
 
 

		/// <summary>
		/// Save_SPB_MOLD_LAST_INV : 
		/// </summary>
		/// <returns></returns>
		private bool Save_SPB_MOLD_LAST_INV()
		{

			try
			{ 

				
				int col_ct = 13;  


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_MOLD_LAST_BSC.SAVE_SPB_MOLD_LAST_INV";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_LAST_CD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[4] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[5] = "ARG_LAST_SEQ";
				MyOraDB.Parameter_Name[6] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[7] = "ARG_STATUS";
				MyOraDB.Parameter_Name[8] = "ARG_DEPT_CD";
				MyOraDB.Parameter_Name[9] = "ARG_DEPT_NAME";
				MyOraDB.Parameter_Name[10] = "ARG_INV_QTY";
				MyOraDB.Parameter_Name[11] = "ARG_CYCLE_HOURLY";
				MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";  


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList();  
 

				vList.Add("D"); 
				vList.Add(_Factory); 
				vList.Add(_LastCd); 
				vList.Add(_LineCd);  
				vList.Add(_ModelCd);
				vList.Add("00");
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(ClassLib.ComVar.This_User); 


				for(int col = (int)ClassLib.TBSPB_MOLD_LAST_INVENTORY.IxCS_SIZE_START; col < fgrid_LastInv.Cols.Count; col++)
				{  
					if(fgrid_LastInv[fgrid_LastInv.Rows.Count - 2, col] == null 
						|| fgrid_LastInv[fgrid_LastInv.Rows.Count - 2, col].ToString() == "") continue;
					
					vList.Add("I"); 
					vList.Add(_Factory); 
					vList.Add(_LastCd); 
					vList.Add(_LineCd);  
					vList.Add(_ModelCd);
					vList.Add("00");
					vList.Add(fgrid_LastInv[2, col].ToString() );  //cs_size
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(fgrid_LastInv[fgrid_LastInv.Rows.Count - 2, col].ToString() );  //inv_qty
					vList.Add(fgrid_LastInv[fgrid_LastInv.Rows.Count - 1, col].ToString() );  //cycle_hourly
					vList.Add(ClassLib.ComVar.This_User);  
  

				} // end for col  

  
  
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

