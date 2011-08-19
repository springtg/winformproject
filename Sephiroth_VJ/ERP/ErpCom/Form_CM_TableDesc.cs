using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
//using C1.C1PrintDocument;

namespace ERP.ErpCom
{
	public class Form_CM_TableDesc : COM.APSWinForm.Form_Top
	{
		private System.ComponentModel.IContainer components = null;

		public Form_CM_TableDesc()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_CM_TableDesc));
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.pnl_SearchSplitRight = new System.Windows.Forms.Panel();
			this.pnl_SearchRightImage = new System.Windows.Forms.Panel();
			this.lbl_MakeClass = new System.Windows.Forms.Label();
			this.txt_Desc = new System.Windows.Forms.TextBox();
			this.txt_Table = new System.Windows.Forms.TextBox();
			this.lbl_Desc = new System.Windows.Forms.Label();
			this.lbl_Table = new System.Windows.Forms.Label();
			this.picb_RMR = new System.Windows.Forms.PictureBox();
			this.picb_RTR = new System.Windows.Forms.PictureBox();
			this.picb_RTM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.picb_RMM = new System.Windows.Forms.PictureBox();
			this.picb_RBR = new System.Windows.Forms.PictureBox();
			this.picb_RBM = new System.Windows.Forms.PictureBox();
			this.picb_RBL = new System.Windows.Forms.PictureBox();
			this.picb_RML = new System.Windows.Forms.PictureBox();
			this.splitter_Body = new System.Windows.Forms.Splitter();
			this.pnl_BodyLeft = new System.Windows.Forms.Panel();
			this.pnl_SearchSplitLeft = new System.Windows.Forms.Panel();
			this.pnl_SearchLeftImage = new System.Windows.Forms.Panel();
			this.txt_TablePre = new System.Windows.Forms.TextBox();
			this.lbl_WorkPre = new System.Windows.Forms.Label();
			this.cmb_TableType = new C1.Win.C1List.C1Combo();
			this.lbl_TableType = new System.Windows.Forms.Label();
			this.picb_LBM = new System.Windows.Forms.PictureBox();
			this.picb_LMR = new System.Windows.Forms.PictureBox();
			this.picb_LTR = new System.Windows.Forms.PictureBox();
			this.picb_LTM = new System.Windows.Forms.PictureBox();
			this.picb_LMM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_LML = new System.Windows.Forms.PictureBox();
			this.picb_LBL = new System.Windows.Forms.PictureBox();
			this.picb_LBR = new System.Windows.Forms.PictureBox();
			this.fgrid_Main = new COM.FSP();
			this.fgrid_Sub = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Body.SuspendLayout();
			this.pnl_SearchSplitRight.SuspendLayout();
			this.pnl_SearchRightImage.SuspendLayout();
			this.pnl_BodyLeft.SuspendLayout();
			this.pnl_SearchSplitLeft.SuspendLayout();
			this.pnl_SearchLeftImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_TableType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Sub)).BeginInit();
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Sub);
			this.pnl_Body.Controls.Add(this.pnl_SearchSplitRight);
			this.pnl_Body.Controls.Add(this.splitter_Body);
			this.pnl_Body.Controls.Add(this.pnl_BodyLeft);
			this.pnl_Body.DockPadding.All = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 64);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 582);
			this.pnl_Body.TabIndex = 32;
			// 
			// pnl_SearchSplitRight
			// 
			this.pnl_SearchSplitRight.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchSplitRight.Controls.Add(this.pnl_SearchRightImage);
			this.pnl_SearchSplitRight.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_SearchSplitRight.DockPadding.Bottom = 8;
			this.pnl_SearchSplitRight.Location = new System.Drawing.Point(355, 8);
			this.pnl_SearchSplitRight.Name = "pnl_SearchSplitRight";
			this.pnl_SearchSplitRight.Size = new System.Drawing.Size(653, 96);
			this.pnl_SearchSplitRight.TabIndex = 24;
			// 
			// pnl_SearchRightImage
			// 
			this.pnl_SearchRightImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchRightImage.Controls.Add(this.lbl_MakeClass);
			this.pnl_SearchRightImage.Controls.Add(this.txt_Desc);
			this.pnl_SearchRightImage.Controls.Add(this.picb_RMR);
			this.pnl_SearchRightImage.Controls.Add(this.txt_Table);
			this.pnl_SearchRightImage.Controls.Add(this.lbl_Desc);
			this.pnl_SearchRightImage.Controls.Add(this.lbl_Table);
			this.pnl_SearchRightImage.Controls.Add(this.picb_RTR);
			this.pnl_SearchRightImage.Controls.Add(this.picb_RTM);
			this.pnl_SearchRightImage.Controls.Add(this.lbl_SubTitle2);
			this.pnl_SearchRightImage.Controls.Add(this.picb_RMM);
			this.pnl_SearchRightImage.Controls.Add(this.picb_RBR);
			this.pnl_SearchRightImage.Controls.Add(this.picb_RBM);
			this.pnl_SearchRightImage.Controls.Add(this.picb_RBL);
			this.pnl_SearchRightImage.Controls.Add(this.picb_RML);
			this.pnl_SearchRightImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchRightImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchRightImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchRightImage.Name = "pnl_SearchRightImage";
			this.pnl_SearchRightImage.Size = new System.Drawing.Size(653, 88);
			this.pnl_SearchRightImage.TabIndex = 20;
			// 
			// lbl_MakeClass
			// 
			this.lbl_MakeClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_MakeClass.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_MakeClass.ImageIndex = 0;
			this.lbl_MakeClass.ImageList = this.img_Button;
			this.lbl_MakeClass.Location = new System.Drawing.Point(560, 34);
			this.lbl_MakeClass.Name = "lbl_MakeClass";
			this.lbl_MakeClass.Size = new System.Drawing.Size(80, 23);
			this.lbl_MakeClass.TabIndex = 100;
			this.lbl_MakeClass.Text = "Create";
			this.lbl_MakeClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_MakeClass.Click += new System.EventHandler(this.lbl_MakeClass_Click);
			this.lbl_MakeClass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MakeClass_MouseUp);
			this.lbl_MakeClass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MakeClass_MouseDown);
			// 
			// txt_Desc
			// 
			this.txt_Desc.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Desc.Enabled = false;
			this.txt_Desc.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Desc.Location = new System.Drawing.Point(111, 58);
			this.txt_Desc.MaxLength = 60;
			this.txt_Desc.Name = "txt_Desc";
			this.txt_Desc.ReadOnly = true;
			this.txt_Desc.Size = new System.Drawing.Size(529, 21);
			this.txt_Desc.TabIndex = 98;
			this.txt_Desc.Text = "";
			// 
			// txt_Table
			// 
			this.txt_Table.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Table.Enabled = false;
			this.txt_Table.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Table.Location = new System.Drawing.Point(111, 36);
			this.txt_Table.MaxLength = 60;
			this.txt_Table.Name = "txt_Table";
			this.txt_Table.ReadOnly = true;
			this.txt_Table.Size = new System.Drawing.Size(210, 21);
			this.txt_Table.TabIndex = 97;
			this.txt_Table.Text = "";
			// 
			// lbl_Desc
			// 
			this.lbl_Desc.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Desc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Desc.ImageIndex = 0;
			this.lbl_Desc.ImageList = this.img_Label;
			this.lbl_Desc.Location = new System.Drawing.Point(10, 58);
			this.lbl_Desc.Name = "lbl_Desc";
			this.lbl_Desc.Size = new System.Drawing.Size(100, 21);
			this.lbl_Desc.TabIndex = 94;
			this.lbl_Desc.Text = "테이블 설명";
			this.lbl_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Table
			// 
			this.lbl_Table.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Table.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Table.ImageIndex = 0;
			this.lbl_Table.ImageList = this.img_Label;
			this.lbl_Table.Location = new System.Drawing.Point(10, 36);
			this.lbl_Table.Name = "lbl_Table";
			this.lbl_Table.Size = new System.Drawing.Size(100, 21);
			this.lbl_Table.TabIndex = 93;
			this.lbl_Table.Text = "테이블";
			this.lbl_Table.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_RMR
			// 
			this.picb_RMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_RMR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_RMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_RMR.Image")));
			this.picb_RMR.Location = new System.Drawing.Point(552, 24);
			this.picb_RMR.Name = "picb_RMR";
			this.picb_RMR.Size = new System.Drawing.Size(104, 56);
			this.picb_RMR.TabIndex = 26;
			this.picb_RMR.TabStop = false;
			// 
			// picb_RTR
			// 
			this.picb_RTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_RTR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_RTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_RTR.Image")));
			this.picb_RTR.Location = new System.Drawing.Point(637, 0);
			this.picb_RTR.Name = "picb_RTR";
			this.picb_RTR.Size = new System.Drawing.Size(16, 32);
			this.picb_RTR.TabIndex = 21;
			this.picb_RTR.TabStop = false;
			// 
			// picb_RTM
			// 
			this.picb_RTM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_RTM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_RTM.Image = ((System.Drawing.Image)(resources.GetObject("picb_RTM.Image")));
			this.picb_RTM.Location = new System.Drawing.Point(224, 0);
			this.picb_RTM.Name = "picb_RTM";
			this.picb_RTM.Size = new System.Drawing.Size(423, 39);
			this.picb_RTM.TabIndex = 0;
			this.picb_RTM.TabStop = false;
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
			this.lbl_SubTitle2.Text = "      Column List of Table";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_RMM
			// 
			this.picb_RMM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_RMM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_RMM.Image = ((System.Drawing.Image)(resources.GetObject("picb_RMM.Image")));
			this.picb_RMM.Location = new System.Drawing.Point(160, 24);
			this.picb_RMM.Name = "picb_RMM";
			this.picb_RMM.Size = new System.Drawing.Size(485, 48);
			this.picb_RMM.TabIndex = 27;
			this.picb_RMM.TabStop = false;
			// 
			// picb_RBR
			// 
			this.picb_RBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_RBR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_RBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_RBR.Image")));
			this.picb_RBR.Location = new System.Drawing.Point(637, 73);
			this.picb_RBR.Name = "picb_RBR";
			this.picb_RBR.Size = new System.Drawing.Size(16, 16);
			this.picb_RBR.TabIndex = 23;
			this.picb_RBR.TabStop = false;
			// 
			// picb_RBM
			// 
			this.picb_RBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_RBM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_RBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_RBM.Image")));
			this.picb_RBM.Location = new System.Drawing.Point(144, 72);
			this.picb_RBM.Name = "picb_RBM";
			this.picb_RBM.Size = new System.Drawing.Size(493, 18);
			this.picb_RBM.TabIndex = 24;
			this.picb_RBM.TabStop = false;
			// 
			// picb_RBL
			// 
			this.picb_RBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_RBL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_RBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_RBL.Image")));
			this.picb_RBL.Location = new System.Drawing.Point(0, 73);
			this.picb_RBL.Name = "picb_RBL";
			this.picb_RBL.Size = new System.Drawing.Size(168, 20);
			this.picb_RBL.TabIndex = 22;
			this.picb_RBL.TabStop = false;
			// 
			// picb_RML
			// 
			this.picb_RML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_RML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_RML.Image = ((System.Drawing.Image)(resources.GetObject("picb_RML.Image")));
			this.picb_RML.Location = new System.Drawing.Point(0, 24);
			this.picb_RML.Name = "picb_RML";
			this.picb_RML.Size = new System.Drawing.Size(168, 56);
			this.picb_RML.TabIndex = 25;
			this.picb_RML.TabStop = false;
			// 
			// splitter_Body
			// 
			this.splitter_Body.Location = new System.Drawing.Point(352, 8);
			this.splitter_Body.Name = "splitter_Body";
			this.splitter_Body.Size = new System.Drawing.Size(3, 566);
			this.splitter_Body.TabIndex = 22;
			this.splitter_Body.TabStop = false;
			// 
			// pnl_BodyLeft
			// 
			this.pnl_BodyLeft.Controls.Add(this.fgrid_Main);
			this.pnl_BodyLeft.Controls.Add(this.pnl_SearchSplitLeft);
			this.pnl_BodyLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnl_BodyLeft.DockPadding.Right = 5;
			this.pnl_BodyLeft.Location = new System.Drawing.Point(8, 8);
			this.pnl_BodyLeft.Name = "pnl_BodyLeft";
			this.pnl_BodyLeft.Size = new System.Drawing.Size(344, 566);
			this.pnl_BodyLeft.TabIndex = 21;
			// 
			// pnl_SearchSplitLeft
			// 
			this.pnl_SearchSplitLeft.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchSplitLeft.Controls.Add(this.pnl_SearchLeftImage);
			this.pnl_SearchSplitLeft.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_SearchSplitLeft.DockPadding.Bottom = 8;
			this.pnl_SearchSplitLeft.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchSplitLeft.Name = "pnl_SearchSplitLeft";
			this.pnl_SearchSplitLeft.Size = new System.Drawing.Size(339, 96);
			this.pnl_SearchSplitLeft.TabIndex = 20;
			// 
			// pnl_SearchLeftImage
			// 
			this.pnl_SearchLeftImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchLeftImage.Controls.Add(this.cmb_TableType);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_TableType);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_TablePre);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_WorkPre);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMM);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LML);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBL);
			this.pnl_SearchLeftImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchLeftImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchLeftImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchLeftImage.Name = "pnl_SearchLeftImage";
			this.pnl_SearchLeftImage.Size = new System.Drawing.Size(339, 88);
			this.pnl_SearchLeftImage.TabIndex = 19;
			// 
			// txt_TablePre
			// 
			this.txt_TablePre.BackColor = System.Drawing.SystemColors.Window;
			this.txt_TablePre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_TablePre.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_TablePre.Location = new System.Drawing.Point(111, 58);
			this.txt_TablePre.MaxLength = 60;
			this.txt_TablePre.Name = "txt_TablePre";
			this.txt_TablePre.Size = new System.Drawing.Size(210, 21);
			this.txt_TablePre.TabIndex = 101;
			this.txt_TablePre.Text = "SP";
			// 
			// lbl_WorkPre
			// 
			this.lbl_WorkPre.ImageIndex = 0;
			this.lbl_WorkPre.ImageList = this.img_Label;
			this.lbl_WorkPre.Location = new System.Drawing.Point(10, 58);
			this.lbl_WorkPre.Name = "lbl_WorkPre";
			this.lbl_WorkPre.Size = new System.Drawing.Size(100, 21);
			this.lbl_WorkPre.TabIndex = 47;
			this.lbl_WorkPre.Text = "테이블 Prefix";
			this.lbl_WorkPre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_TableType
			// 
			this.cmb_TableType.AddItemCols = 0;
			this.cmb_TableType.AddItemSeparator = ';';
			this.cmb_TableType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_TableType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_TableType.Caption = "";
			this.cmb_TableType.CaptionHeight = 17;
			this.cmb_TableType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_TableType.ColumnCaptionHeight = 18;
			this.cmb_TableType.ColumnFooterHeight = 18;
			this.cmb_TableType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_TableType.ContentHeight = 17;
			this.cmb_TableType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_TableType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_TableType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_TableType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_TableType.EditorHeight = 17;
			this.cmb_TableType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_TableType.GapHeight = 2;
			this.cmb_TableType.ItemHeight = 15;
			this.cmb_TableType.Location = new System.Drawing.Point(111, 36);
			this.cmb_TableType.MatchEntryTimeout = ((long)(2000));
			this.cmb_TableType.MaxDropDownItems = ((short)(5));
			this.cmb_TableType.MaxLength = 32767;
			this.cmb_TableType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_TableType.Name = "cmb_TableType";
			this.cmb_TableType.PartialRightColumn = false;
			this.cmb_TableType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_TableType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_TableType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_TableType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_TableType.Size = new System.Drawing.Size(210, 21);
			this.cmb_TableType.TabIndex = 46;
			this.cmb_TableType.TextChanged += new System.EventHandler(this.cmb_TableType_TextChanged);
			// 
			// lbl_TableType
			// 
			this.lbl_TableType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_TableType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_TableType.ImageIndex = 0;
			this.lbl_TableType.ImageList = this.img_Label;
			this.lbl_TableType.Location = new System.Drawing.Point(10, 36);
			this.lbl_TableType.Name = "lbl_TableType";
			this.lbl_TableType.Size = new System.Drawing.Size(100, 21);
			this.lbl_TableType.TabIndex = 45;
			this.lbl_TableType.Text = "테이블 유형";
			this.lbl_TableType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_LBM
			// 
			this.picb_LBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBM.Image")));
			this.picb_LBM.Location = new System.Drawing.Point(131, 70);
			this.picb_LBM.Name = "picb_LBM";
			this.picb_LBM.Size = new System.Drawing.Size(192, 18);
			this.picb_LBM.TabIndex = 28;
			this.picb_LBM.TabStop = false;
			// 
			// picb_LMR
			// 
			this.picb_LMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LMR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMR.Image")));
			this.picb_LMR.Location = new System.Drawing.Point(324, 24);
			this.picb_LMR.Name = "picb_LMR";
			this.picb_LMR.Size = new System.Drawing.Size(15, 48);
			this.picb_LMR.TabIndex = 26;
			this.picb_LMR.TabStop = false;
			// 
			// picb_LTR
			// 
			this.picb_LTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LTR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTR.Image")));
			this.picb_LTR.Location = new System.Drawing.Point(323, 0);
			this.picb_LTR.Name = "picb_LTR";
			this.picb_LTR.Size = new System.Drawing.Size(16, 32);
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
			this.picb_LTM.Size = new System.Drawing.Size(139, 32);
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
			this.picb_LMM.Size = new System.Drawing.Size(171, 48);
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
			this.lbl_SubTitle1.Text = "      Table List";
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
			this.picb_LML.Size = new System.Drawing.Size(168, 48);
			this.picb_LML.TabIndex = 25;
			this.picb_LML.TabStop = false;
			// 
			// picb_LBL
			// 
			this.picb_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_LBL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBL.Image")));
			this.picb_LBL.Location = new System.Drawing.Point(0, 68);
			this.picb_LBL.Name = "picb_LBL";
			this.picb_LBL.Size = new System.Drawing.Size(168, 20);
			this.picb_LBL.TabIndex = 22;
			this.picb_LBL.TabStop = false;
			// 
			// picb_LBR
			// 
			this.picb_LBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBR.Image")));
			this.picb_LBR.Location = new System.Drawing.Point(323, 72);
			this.picb_LBR.Name = "picb_LBR";
			this.picb_LBR.Size = new System.Drawing.Size(16, 16);
			this.picb_LBR.TabIndex = 29;
			this.picb_LBR.TabStop = false;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(0, 96);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
			this.fgrid_Main.Size = new System.Drawing.Size(339, 470);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:White;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 103;
			this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
			this.fgrid_Main.TextChanged += new System.EventHandler(this.fgrid_Main_Click);
			// 
			// fgrid_Sub
			// 
			this.fgrid_Sub.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Sub.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Sub.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Sub.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Sub.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Sub.Location = new System.Drawing.Point(355, 104);
			this.fgrid_Sub.Name = "fgrid_Sub";
			this.fgrid_Sub.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Sub.Size = new System.Drawing.Size(653, 470);
			this.fgrid_Sub.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:White;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Sub.TabIndex = 29;
			// 
			// Form_CM_TableDesc
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Name = "Form_CM_TableDesc";
			this.Text = "Description of Table";
			this.Load += new System.EventHandler(this.Form_PS_TableDesc_Load);
			this.TextChanged += new System.EventHandler(this.Form_PS_TableDesc_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			this.pnl_SearchSplitRight.ResumeLayout(false);
			this.pnl_SearchRightImage.ResumeLayout(false);
			this.pnl_BodyLeft.ResumeLayout(false);
			this.pnl_SearchSplitLeft.ResumeLayout(false);
			this.pnl_SearchLeftImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_TableType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Sub)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		
		#region 속성 정의



		public System.Windows.Forms.Panel pnl_Body;
		public System.Windows.Forms.Panel pnl_SearchSplitRight;
		public System.Windows.Forms.Panel pnl_SearchRightImage;
		private System.Windows.Forms.TextBox txt_Desc;
		private System.Windows.Forms.TextBox txt_Table;
		private System.Windows.Forms.Label lbl_Desc;
		private System.Windows.Forms.Label lbl_Table;
		private System.Windows.Forms.Label lbl_MakeClass;
		public System.Windows.Forms.PictureBox picb_RMR;
		public System.Windows.Forms.PictureBox picb_RTR;
		public System.Windows.Forms.PictureBox picb_RTM;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.PictureBox picb_RMM;
		public System.Windows.Forms.PictureBox picb_RBR;
		public System.Windows.Forms.PictureBox picb_RBM;
		public System.Windows.Forms.PictureBox picb_RBL;
		public System.Windows.Forms.PictureBox picb_RML;
		private System.Windows.Forms.Splitter splitter_Body;
		public System.Windows.Forms.Panel pnl_BodyLeft;
		public System.Windows.Forms.Panel pnl_SearchSplitLeft;
		public System.Windows.Forms.Panel pnl_SearchLeftImage;
		private System.Windows.Forms.TextBox txt_TablePre;
		private System.Windows.Forms.Label lbl_WorkPre;
		private C1.Win.C1List.C1Combo cmb_TableType;
		private System.Windows.Forms.Label lbl_TableType;
		public System.Windows.Forms.PictureBox picb_LBM;
		public System.Windows.Forms.PictureBox picb_LMR;
		public System.Windows.Forms.PictureBox picb_LTR;
		public System.Windows.Forms.PictureBox picb_LTM;
		public System.Windows.Forms.PictureBox picb_LMM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_LML;
		public System.Windows.Forms.PictureBox picb_LBL;  
		public System.Windows.Forms.PictureBox picb_LBR;
		public COM.FSP fgrid_Main;
		public COM.FSP fgrid_Sub;


		#endregion


		#region 변수 정의

		private System.Collections.Hashtable _Imgmap = new Hashtable();
		private int _Rowfixed;
		

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion


		#region 멤버 메서드


		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{

			// Title 값 지정
			this.Text = "Description of Table";
			this.lbl_MainTitle.Text = "Description of Table";
			ClassLib.ComFunction.SetLangDic(this);


			#region 버튼 권한

			try
			{
                //COM.OraDB btn_control = new COM.OraDB();
                //DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
                //tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
                //tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
                //tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
                //btn_control = null;
			}
			catch
			{
			}

			#endregion


			DataTable dtcmb_list;
			
			

			// 그리드 설정
			fgrid_Main.Set_Grid_Comm( "TABLE_DESC", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  

			_Rowfixed = fgrid_Main.Rows.Fixed;

			// 그리드 상에서 Insert, Delete, Update 이미지로 표시해주기 위한 작업
			fgrid_Main.Set_Action_Image(img_Action); 

			// 그리드 설정
			this.fgrid_Sub.Set_Grid_Comm( "TABLE_COLUMN_DESC", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);  

			//_Rowfixed = fgrid_Main.Rows.Fixed;

			// 그리드 상에서 Insert, Delete, Update 이미지로 표시해주기 위한 작업
			this.fgrid_Sub.Set_Action_Image( img_Action); 



			// 프로그램 리스트 항목 SELECT
			dtcmb_list = Select_PgList();

			// 프로그램 리스트 추가
			COM.ComCtl.Set_ComboList(dtcmb_list, cmb_TableType, 0, 0);
			cmb_TableType.Splits[0].DisplayColumns[0].Visible= false;
			cmb_TableType.SelectedValue = "TABLE";
 

		}


		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 

			} 

			arg_fgrid.AutoSizeCols();
		}




		#endregion 

		private void Form_PS_TableDesc_Load(object sender, System.EventArgs e)
		{
			Init_Form();  
		
		}


		#region 이벤트 처리

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			dt_ret = Select_Data_List();
			Display_Grid(dt_ret, this.fgrid_Main);
		}

		private void cmb_TableType_TextChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			dt_ret = Select_Data_List();
			Display_Grid(dt_ret, this.fgrid_Main);
		}

		private void fgrid_Main_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			this.txt_Table.Text = this.fgrid_Main[this.fgrid_Main.Row,1].ToString();
			this.txt_Desc.Text = this.fgrid_Main[this.fgrid_Main.Row,3].ToString();
			
			dt_ret = Select_SubData_List();
			Display_Grid(dt_ret, this.fgrid_Sub);
		}

		private void lbl_MakeClass_Click(object sender, System.EventArgs e)
		{
			Pop_TableClass frm_pop = new Pop_TableClass();

			COM.ComVar.Parameter_PopUp = new string[2];
			COM.ComVar.Parameter_PopUp[0] = this.txt_Table.Text ;
			COM.ComVar.Parameter_PopUp[1] = this.txt_Desc.Text;
			frm_pop.ShowDialog();

		}


		private void lbl_MakeClass_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			lbl_MakeClass.ImageIndex = 1;
		}

		private void lbl_MakeClass_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			lbl_MakeClass.ImageIndex = 0;
		}

		
		//		private void btn_Print_Click(object sender, System.EventArgs e)
		//		{
		//			// create C1PrintDocument
		//			C1PrintDocument doc = new C1PrintDocument();
		//			doc.PageSettings.Landscape = true;
		//			doc.StartDoc();
		//
		//			// add some text (tables, etc)
		//			
		//			doc.RenderBlockText("<< Sephiroth 테이블 설명 >>");
		//			doc.RenderBlockText(" ");
		//			doc.RenderBlockText(" 테이블명 : " + txt_Table.Text );
		//			doc.RenderBlockText(" 테이블 설명 : " + txt_Desc.Text );
		//			doc.RenderBlockText(" ");
		//
		//
		//			// add the flex to the document
		//			doc.RenderBlockC1Printable(fgrid_Sub) ; //, doc.BodyAreaSize.Width); // << render grid
		//			doc.RenderBlockText(" ");
		//
		//		
		//			// document is ready
		//			doc.EndDoc();
		//
		//			// show print document
		//			using (FlexAPS.C1PrintPreviewForm dlg = new C1PrintPreviewForm())
		//			{
		//				dlg.Text = "Table Description";
		//				dlg.Document = doc;
		//				dlg.ShowDialog();
		//			}
		//		}

		#endregion

		#region DB Connect

		/// <summary>
		/// Select_PgId : 프로그램 아이디, 순번 리스트 조회
		/// </summary>
		/// <returns></returns>
		private DataTable Select_PgList()
		{
			  
			DataSet ds_ret;
			string process_name = "PKG_SCM_TABLE.SELECT_TABLE_TYPE_LIST";

			MyOraDB.ReDim_Parameter(1); 

			MyOraDB.Process_Name = process_name; 
			MyOraDB.Parameter_Name[0] = "OUT_CURSOR"; 
			MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor; 
			MyOraDB.Parameter_Values[0] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ; 

			return ds_ret.Tables[process_name]; 


		}
 

		/// <summary>
		/// Select_Data_List : 조회부에 맞는 데이터 그리드에 표시
		/// </summary>
		private DataTable Select_Data_List()
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SCM_TABLE.SELECT_TABLE_DESC_LIST";

			MyOraDB.ReDim_Parameter(3); 

			MyOraDB.Process_Name = process_name; 

			MyOraDB.Parameter_Name[0] = "ARG_TABLE_TYPE"; 
			MyOraDB.Parameter_Name[1] = "ARG_TABLE_NAME";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

			MyOraDB.Parameter_Values[0] = cmb_TableType.Columns[0].Text; 
			MyOraDB.Parameter_Values[1] = this.txt_TablePre.Text; 
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ; 

			return ds_ret.Tables[process_name]; 


		}


		/// <summary>
		/// Select_SubData_List : 테이블에 대한 세부 칼럼 list
		/// </summary>
		private DataTable Select_SubData_List()
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SCM_TABLE.SELECT_TABLE_COLUMN";

			MyOraDB.ReDim_Parameter(2); 

			MyOraDB.Process_Name = process_name; 

			MyOraDB.Parameter_Name[0] = "ARG_TABLE_NAME"; 
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

			MyOraDB.Parameter_Values[0] = this.fgrid_Main[this.fgrid_Main.Row,1].ToString();
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ; 

			return ds_ret.Tables[process_name]; 


		}

 
 

		#endregion

	



	}
}

