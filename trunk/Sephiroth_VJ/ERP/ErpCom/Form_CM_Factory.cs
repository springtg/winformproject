using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;


namespace ERP.ErpCom
{
	public class Form_CM_Factory : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리 

		public System.Windows.Forms.Panel pnl_Right;
		public System.Windows.Forms.Panel pnl_BottomImage;
		public System.Windows.Forms.PictureBox picb_DTR;
		public System.Windows.Forms.PictureBox picb_DTM;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.PictureBox picb_DMR;
		public System.Windows.Forms.PictureBox picb_DMM;
		public System.Windows.Forms.PictureBox picb_DBR;
		public System.Windows.Forms.PictureBox picb_DBM;
		public System.Windows.Forms.PictureBox picb_DBL;
		public System.Windows.Forms.PictureBox picb_DML;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.TextBox txt_CalType;
		private System.Windows.Forms.TextBox txt_Remarks;
		private System.Windows.Forms.TextBox txt_Code;
		private System.Windows.Forms.TextBox txt_Address;
		private System.Windows.Forms.Label lbl_FCalType;
		private System.Windows.Forms.Label lbl_FAddress;
		private System.Windows.Forms.Label lbl_FName;
		private System.Windows.Forms.Label lbl_FCode;
		private System.Windows.Forms.Label lbl_FRemraks;
		private System.Windows.Forms.Panel pnl_Left;
		public COM.FSP fgrid_Factory;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.CheckBox chk_UseYN;
		private System.Windows.Forms.Label lbl_UseYN;
		private System.ComponentModel.IContainer components = null;

		public Form_CM_Factory()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_CM_Factory));
			this.pnl_Right = new System.Windows.Forms.Panel();
			this.pnl_BottomImage = new System.Windows.Forms.Panel();
			this.picb_DTR = new System.Windows.Forms.PictureBox();
			this.picb_DMR = new System.Windows.Forms.PictureBox();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.txt_CalType = new System.Windows.Forms.TextBox();
			this.txt_Remarks = new System.Windows.Forms.TextBox();
			this.txt_Code = new System.Windows.Forms.TextBox();
			this.txt_Address = new System.Windows.Forms.TextBox();
			this.lbl_FCalType = new System.Windows.Forms.Label();
			this.lbl_FAddress = new System.Windows.Forms.Label();
			this.lbl_FName = new System.Windows.Forms.Label();
			this.lbl_FCode = new System.Windows.Forms.Label();
			this.lbl_FRemraks = new System.Windows.Forms.Label();
			this.picb_DTM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.picb_DMM = new System.Windows.Forms.PictureBox();
			this.picb_DBR = new System.Windows.Forms.PictureBox();
			this.picb_DBM = new System.Windows.Forms.PictureBox();
			this.picb_DBL = new System.Windows.Forms.PictureBox();
			this.picb_DML = new System.Windows.Forms.PictureBox();
			this.pnl_Left = new System.Windows.Forms.Panel();
			this.fgrid_Factory = new COM.FSP();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.chk_UseYN = new System.Windows.Forms.CheckBox();
			this.lbl_UseYN = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Right.SuspendLayout();
			this.pnl_BottomImage.SuspendLayout();
			this.pnl_Left.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
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
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
			// 
			// tbtn_Insert
			// 
			this.tbtn_Insert.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Insert_Click);
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					 this.statusBarPanel1});
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// pnl_Right
			// 
			this.pnl_Right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Right.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Right.Controls.Add(this.pnl_BottomImage);
			this.pnl_Right.DockPadding.All = 8;
			this.pnl_Right.Location = new System.Drawing.Point(664, 64);
			this.pnl_Right.Name = "pnl_Right";
			this.pnl_Right.Size = new System.Drawing.Size(352, 582);
			this.pnl_Right.TabIndex = 35;
			// 
			// pnl_BottomImage
			// 
			this.pnl_BottomImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_BottomImage.Controls.Add(this.chk_UseYN);
			this.pnl_BottomImage.Controls.Add(this.lbl_UseYN);
			this.pnl_BottomImage.Controls.Add(this.picb_DTR);
			this.pnl_BottomImage.Controls.Add(this.picb_DMR);
			this.pnl_BottomImage.Controls.Add(this.txt_Name);
			this.pnl_BottomImage.Controls.Add(this.txt_CalType);
			this.pnl_BottomImage.Controls.Add(this.txt_Remarks);
			this.pnl_BottomImage.Controls.Add(this.txt_Code);
			this.pnl_BottomImage.Controls.Add(this.txt_Address);
			this.pnl_BottomImage.Controls.Add(this.lbl_FCalType);
			this.pnl_BottomImage.Controls.Add(this.lbl_FAddress);
			this.pnl_BottomImage.Controls.Add(this.lbl_FName);
			this.pnl_BottomImage.Controls.Add(this.lbl_FCode);
			this.pnl_BottomImage.Controls.Add(this.lbl_FRemraks);
			this.pnl_BottomImage.Controls.Add(this.picb_DTM);
			this.pnl_BottomImage.Controls.Add(this.lbl_SubTitle2);
			this.pnl_BottomImage.Controls.Add(this.picb_DMM);
			this.pnl_BottomImage.Controls.Add(this.picb_DBR);
			this.pnl_BottomImage.Controls.Add(this.picb_DBM);
			this.pnl_BottomImage.Controls.Add(this.picb_DBL);
			this.pnl_BottomImage.Controls.Add(this.picb_DML);
			this.pnl_BottomImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_BottomImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_BottomImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_BottomImage.Name = "pnl_BottomImage";
			this.pnl_BottomImage.Size = new System.Drawing.Size(336, 566);
			this.pnl_BottomImage.TabIndex = 0;
			// 
			// picb_DTR
			// 
			this.picb_DTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DTR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DTR.Image")));
			this.picb_DTR.Location = new System.Drawing.Point(320, 0);
			this.picb_DTR.Name = "picb_DTR";
			this.picb_DTR.Size = new System.Drawing.Size(16, 24);
			this.picb_DTR.TabIndex = 21;
			this.picb_DTR.TabStop = false;
			// 
			// picb_DMR
			// 
			this.picb_DMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DMR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DMR.Image")));
			this.picb_DMR.Location = new System.Drawing.Point(321, 24);
			this.picb_DMR.Name = "picb_DMR";
			this.picb_DMR.Size = new System.Drawing.Size(15, 528);
			this.picb_DMR.TabIndex = 26;
			this.picb_DMR.TabStop = false;
			// 
			// txt_Name
			// 
			this.txt_Name.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Name.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Name.Location = new System.Drawing.Point(111, 58);
			this.txt_Name.MaxLength = 60;
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.ReadOnly = true;
			this.txt_Name.Size = new System.Drawing.Size(210, 21);
			this.txt_Name.TabIndex = 100;
			this.txt_Name.Text = "";
			// 
			// txt_CalType
			// 
			this.txt_CalType.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_CalType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_CalType.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_CalType.Location = new System.Drawing.Point(111, 102);
			this.txt_CalType.MaxLength = 100;
			this.txt_CalType.Name = "txt_CalType";
			this.txt_CalType.ReadOnly = true;
			this.txt_CalType.Size = new System.Drawing.Size(210, 21);
			this.txt_CalType.TabIndex = 99;
			this.txt_CalType.Text = "";
			// 
			// txt_Remarks
			// 
			this.txt_Remarks.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Remarks.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Remarks.Location = new System.Drawing.Point(111, 146);
			this.txt_Remarks.MaxLength = 20;
			this.txt_Remarks.Name = "txt_Remarks";
			this.txt_Remarks.ReadOnly = true;
			this.txt_Remarks.Size = new System.Drawing.Size(210, 21);
			this.txt_Remarks.TabIndex = 98;
			this.txt_Remarks.Text = "";
			// 
			// txt_Code
			// 
			this.txt_Code.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Code.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Code.Location = new System.Drawing.Point(111, 36);
			this.txt_Code.MaxLength = 60;
			this.txt_Code.Name = "txt_Code";
			this.txt_Code.ReadOnly = true;
			this.txt_Code.Size = new System.Drawing.Size(210, 21);
			this.txt_Code.TabIndex = 102;
			this.txt_Code.Text = "";
			// 
			// txt_Address
			// 
			this.txt_Address.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Address.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Address.Location = new System.Drawing.Point(111, 80);
			this.txt_Address.MaxLength = 60;
			this.txt_Address.Name = "txt_Address";
			this.txt_Address.ReadOnly = true;
			this.txt_Address.Size = new System.Drawing.Size(210, 21);
			this.txt_Address.TabIndex = 101;
			this.txt_Address.Text = "";
			// 
			// lbl_FCalType
			// 
			this.lbl_FCalType.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_FCalType.ImageIndex = 0;
			this.lbl_FCalType.ImageList = this.img_Label;
			this.lbl_FCalType.Location = new System.Drawing.Point(10, 102);
			this.lbl_FCalType.Name = "lbl_FCalType";
			this.lbl_FCalType.Size = new System.Drawing.Size(100, 21);
			this.lbl_FCalType.TabIndex = 97;
			this.lbl_FCalType.Text = "카렌더 타입";
			this.lbl_FCalType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_FAddress
			// 
			this.lbl_FAddress.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_FAddress.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_FAddress.ImageIndex = 0;
			this.lbl_FAddress.ImageList = this.img_Label;
			this.lbl_FAddress.Location = new System.Drawing.Point(10, 80);
			this.lbl_FAddress.Name = "lbl_FAddress";
			this.lbl_FAddress.Size = new System.Drawing.Size(100, 21);
			this.lbl_FAddress.TabIndex = 95;
			this.lbl_FAddress.Text = "주소지";
			this.lbl_FAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_FName
			// 
			this.lbl_FName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_FName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_FName.ImageIndex = 0;
			this.lbl_FName.ImageList = this.img_Label;
			this.lbl_FName.Location = new System.Drawing.Point(10, 58);
			this.lbl_FName.Name = "lbl_FName";
			this.lbl_FName.Size = new System.Drawing.Size(100, 21);
			this.lbl_FName.TabIndex = 94;
			this.lbl_FName.Text = "공장명";
			this.lbl_FName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_FCode
			// 
			this.lbl_FCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_FCode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_FCode.ImageIndex = 0;
			this.lbl_FCode.ImageList = this.img_Label;
			this.lbl_FCode.Location = new System.Drawing.Point(10, 36);
			this.lbl_FCode.Name = "lbl_FCode";
			this.lbl_FCode.Size = new System.Drawing.Size(100, 21);
			this.lbl_FCode.TabIndex = 93;
			this.lbl_FCode.Text = "공장 코드";
			this.lbl_FCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_FRemraks
			// 
			this.lbl_FRemraks.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_FRemraks.ImageIndex = 0;
			this.lbl_FRemraks.ImageList = this.img_Label;
			this.lbl_FRemraks.Location = new System.Drawing.Point(10, 146);
			this.lbl_FRemraks.Name = "lbl_FRemraks";
			this.lbl_FRemraks.Size = new System.Drawing.Size(100, 21);
			this.lbl_FRemraks.TabIndex = 96;
			this.lbl_FRemraks.Text = "비고";
			this.lbl_FRemraks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_DTM
			// 
			this.picb_DTM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DTM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DTM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DTM.Image")));
			this.picb_DTM.Location = new System.Drawing.Point(224, 0);
			this.picb_DTM.Name = "picb_DTM";
			this.picb_DTM.Size = new System.Drawing.Size(106, 39);
			this.picb_DTM.TabIndex = 0;
			this.picb_DTM.TabStop = false;
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
			this.lbl_SubTitle2.TabIndex = 28;
			this.lbl_SubTitle2.Text = "      Display Factory Info.";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_DMM
			// 
			this.picb_DMM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DMM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DMM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DMM.Image")));
			this.picb_DMM.Location = new System.Drawing.Point(160, 24);
			this.picb_DMM.Name = "picb_DMM";
			this.picb_DMM.Size = new System.Drawing.Size(168, 526);
			this.picb_DMM.TabIndex = 27;
			this.picb_DMM.TabStop = false;
			// 
			// picb_DBR
			// 
			this.picb_DBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DBR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBR.Image")));
			this.picb_DBR.Location = new System.Drawing.Point(320, 550);
			this.picb_DBR.Name = "picb_DBR";
			this.picb_DBR.Size = new System.Drawing.Size(16, 16);
			this.picb_DBR.TabIndex = 23;
			this.picb_DBR.TabStop = false;
			// 
			// picb_DBM
			// 
			this.picb_DBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DBM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBM.Image")));
			this.picb_DBM.Location = new System.Drawing.Point(144, 548);
			this.picb_DBM.Name = "picb_DBM";
			this.picb_DBM.Size = new System.Drawing.Size(176, 18);
			this.picb_DBM.TabIndex = 24;
			this.picb_DBM.TabStop = false;
			// 
			// picb_DBL
			// 
			this.picb_DBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_DBL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBL.Image")));
			this.picb_DBL.Location = new System.Drawing.Point(0, 546);
			this.picb_DBL.Name = "picb_DBL";
			this.picb_DBL.Size = new System.Drawing.Size(168, 20);
			this.picb_DBL.TabIndex = 22;
			this.picb_DBL.TabStop = false;
			// 
			// picb_DML
			// 
			this.picb_DML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_DML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DML.Image = ((System.Drawing.Image)(resources.GetObject("picb_DML.Image")));
			this.picb_DML.Location = new System.Drawing.Point(0, 24);
			this.picb_DML.Name = "picb_DML";
			this.picb_DML.Size = new System.Drawing.Size(168, 526);
			this.picb_DML.TabIndex = 25;
			this.picb_DML.TabStop = false;
			// 
			// pnl_Left
			// 
			this.pnl_Left.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Left.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Left.Controls.Add(this.fgrid_Factory);
			this.pnl_Left.DockPadding.Bottom = 8;
			this.pnl_Left.DockPadding.Left = 8;
			this.pnl_Left.DockPadding.Top = 8;
			this.pnl_Left.Location = new System.Drawing.Point(0, 64);
			this.pnl_Left.Name = "pnl_Left";
			this.pnl_Left.Size = new System.Drawing.Size(664, 582);
			this.pnl_Left.TabIndex = 36;
			// 
			// fgrid_Factory
			// 
			this.fgrid_Factory.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Factory.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Factory.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Factory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Factory.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Factory.Location = new System.Drawing.Point(8, 8);
			this.fgrid_Factory.Name = "fgrid_Factory";
			this.fgrid_Factory.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Factory.Size = new System.Drawing.Size(656, 566);
			this.fgrid_Factory.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Factory.TabIndex = 26;
			this.fgrid_Factory.Click += new System.EventHandler(this.fgrid_Factory_Click);
			this.fgrid_Factory.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Factory_BeforeEdit);
			this.fgrid_Factory.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Factory_AfterEdit);
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.Text = "statusBarPanel1";
			// 
			// chk_UseYN
			// 
			this.chk_UseYN.Enabled = false;
			this.chk_UseYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_UseYN.Location = new System.Drawing.Point(111, 124);
			this.chk_UseYN.Name = "chk_UseYN";
			this.chk_UseYN.Size = new System.Drawing.Size(16, 21);
			this.chk_UseYN.TabIndex = 143;
			// 
			// lbl_UseYN
			// 
			this.lbl_UseYN.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_UseYN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_UseYN.ImageIndex = 0;
			this.lbl_UseYN.ImageList = this.img_Label;
			this.lbl_UseYN.Location = new System.Drawing.Point(10, 124);
			this.lbl_UseYN.Name = "lbl_UseYN";
			this.lbl_UseYN.Size = new System.Drawing.Size(100, 21);
			this.lbl_UseYN.TabIndex = 142;
			this.lbl_UseYN.Text = "사용 여부";
			this.lbl_UseYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form_CM_Factory
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Left);
			this.Controls.Add(this.pnl_Right);
			this.Name = "Form_CM_Factory";
			this.Text = "Factory Information";
			this.Load += new System.EventHandler(this.Form_CM_Factory_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Right, 0);
			this.Controls.SetChildIndex(this.pnl_Left, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Right.ResumeLayout(false);
			this.pnl_BottomImage.ResumeLayout(false);
			this.pnl_Left.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 
 

		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion 

		#region 멤버 메서드


		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			//Title
			this.Text = "Factory Information";
			lbl_MainTitle.Text = "Factory Information";
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



			DataTable dt_ret;

			
 

			// 그리드 설정
			//fgrid_Factory.Set_Grid_Comm("FACTORY_CODE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_Factory.Set_Grid("FACTORY_CODE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_Factory.Set_Action_Image(img_Action); 


			dt_ret = Select_SCM_FACTORY();
			Display_Grid(dt_ret, fgrid_Factory);
		}
 



		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
		 	arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;  
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;
  
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = ""; 
			} 

			arg_fgrid.AutoSizeCols();
		}



		#endregion 

		#region 이벤트 처리


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			fgrid_Factory.Rows.Count = fgrid_Factory.Rows.Fixed;
			txt_Code.Text = "";
			txt_Name.Text = "";
			txt_Address.Text = "";
			txt_CalType.Text = "";
			txt_Remarks.Text = "";
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				DataTable dt_ret;

				dt_ret = Select_SCM_FACTORY();
				Display_Grid(dt_ret, fgrid_Factory);
			}
			catch
			{
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			try
			{
				//행 수정 상태 해제
				fgrid_Factory.Select(fgrid_Factory.Selection.r1, 0, fgrid_Factory.Selection.r1, fgrid_Factory.Cols.Count-1, false);
  
				MyOraDB.Save_FlexGird("PKG_SCM_FACTORY.SAVE_FACTORY_LIST", fgrid_Factory);
 
				dt_ret = Select_SCM_FACTORY();
				Display_Grid(dt_ret, fgrid_Factory);
			}
			catch
			{
			}


		}

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Factory.Add_Row(fgrid_Factory.Rows.Count - 1); 
		}

		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Factory.Add_Row(fgrid_Factory.Selection.r1); 
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Factory.Delete_Row();
		}

		

		private void fgrid_Factory_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_Factory.Rows.Fixed > 0) && (fgrid_Factory.Row >= fgrid_Factory.Rows.Fixed))
			{
				fgrid_Factory.Buffer_CellData = (fgrid_Factory[fgrid_Factory.Row, fgrid_Factory.Col] == null) ? "" : fgrid_Factory[fgrid_Factory.Row, fgrid_Factory.Col].ToString();
			}
		}


		private void fgrid_Factory_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Factory.Update_Row();
			fgrid_Factory.AutoSizeCols();
		}


		private void fgrid_Factory_Click(object sender, System.EventArgs e)
		{
			try
			{
				int sel_row = fgrid_Factory.Selection.r1;

				if(sel_row >= fgrid_Factory.Rows.Fixed)
				{
					txt_Code.Text = fgrid_Factory[sel_row, (int)ClassLib.TBSCM_FACTORY.IxFACTORY].ToString();
					txt_Name.Text = fgrid_Factory[sel_row, (int)ClassLib.TBSCM_FACTORY.IxFACTORY_NAME].ToString();
					txt_Address.Text = fgrid_Factory[sel_row, (int)ClassLib.TBSCM_FACTORY.IxADDRESS].ToString();
					txt_CalType.Text = fgrid_Factory[sel_row, (int)ClassLib.TBSCM_FACTORY.IxCAL_TYPE].ToString();
					chk_UseYN.Checked = Convert.ToBoolean(fgrid_Factory[sel_row, (int)ClassLib.TBSCM_FACTORY.IxUSE_YN].ToString() );
					txt_Remarks.Text = fgrid_Factory[sel_row, (int)ClassLib.TBSCM_FACTORY.IxREMARKS].ToString();
				}
			}
			catch
			{
			}
		}



		#endregion


		#region DB Connect

		/// <summary>
		/// Select_SPB_FACTORY : Factory 조회
		/// </summary>
		/// <returns></returns>
		public static DataTable Select_SCM_FACTORY()
		{
 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(1); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SCM_FACTORY.SELECT_SCM_FACTORY";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}
		
		#endregion

		 
		private void Form_CM_Factory_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

	 
		



	}
}

