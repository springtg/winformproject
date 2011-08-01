using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexAPS.ProdSheet
{
	public class Form_PD_WorkSheet_Release : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리


		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_Tail;
		private System.Windows.Forms.Panel pnl_Head;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Button btn_Release;
		private System.Windows.Forms.Label btn_PCard;
		private System.Windows.Forms.TextBox txt_MaxAsyDate;
		private System.Windows.Forms.Label lbl_ReleaseDay;
		public System.Windows.Forms.DateTimePicker dpick_ConfirmYMD;
		private System.Windows.Forms.Label lbl_NOS1;
		private System.Windows.Forms.Label lbl_NOS;
		private System.Windows.Forms.Label lbl_Stit22;
		private System.Windows.Forms.Label lbl_Stit11;
		private System.Windows.Forms.Label lbl_Stit2;
		private System.Windows.Forms.Label lbl_Stit1;
		private System.Windows.Forms.Label btn_WorkArea;
		private System.Windows.Forms.Label btn_Cancel;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		private C1.Win.C1Command.C1OutPage obarpg_Release;
		private C1.Win.C1Command.C1OutPage obarpg_ReleaseDef;
		private COM.FSP fgrid_Release;
		private COM.FSP fgrid_ReleaseDef;
		private System.Windows.Forms.Label lbl_ConfirmYMD;
		private System.Windows.Forms.TextBox txt_StatusDay;
		private System.Windows.Forms.TextBox txt_NextWorkDay;
		private System.Windows.Forms.TextBox txt_Status;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private C1.Win.C1Command.C1OutBar obar_Main;
		private System.Windows.Forms.ImageList img_SmallLabel;
  
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자


		public Form_PD_WorkSheet_Release()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PD_WorkSheet_Release));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_Tail = new System.Windows.Forms.Panel();
			this.obar_Main = new C1.Win.C1Command.C1OutBar();
			this.obarpg_Release = new C1.Win.C1Command.C1OutPage();
			this.fgrid_Release = new COM.FSP();
			this.obarpg_ReleaseDef = new C1.Win.C1Command.C1OutPage();
			this.fgrid_ReleaseDef = new COM.FSP();
			this.pnl_Head = new System.Windows.Forms.Panel();
			this.pnl_BT = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.btn_Release = new System.Windows.Forms.Button();
			this.btn_PCard = new System.Windows.Forms.Label();
			this.txt_MaxAsyDate = new System.Windows.Forms.TextBox();
			this.lbl_ReleaseDay = new System.Windows.Forms.Label();
			this.dpick_ConfirmYMD = new System.Windows.Forms.DateTimePicker();
			this.lbl_ConfirmYMD = new System.Windows.Forms.Label();
			this.lbl_NOS1 = new System.Windows.Forms.Label();
			this.lbl_NOS = new System.Windows.Forms.Label();
			this.lbl_Stit22 = new System.Windows.Forms.Label();
			this.lbl_Stit11 = new System.Windows.Forms.Label();
			this.lbl_Stit2 = new System.Windows.Forms.Label();
			this.lbl_Stit1 = new System.Windows.Forms.Label();
			this.btn_WorkArea = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.txt_StatusDay = new System.Windows.Forms.TextBox();
			this.txt_NextWorkDay = new System.Windows.Forms.TextBox();
			this.txt_Status = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_Tail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
			this.obar_Main.SuspendLayout();
			this.obarpg_Release.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Release)).BeginInit();
			this.obarpg_ReleaseDef.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ReleaseDef)).BeginInit();
			this.pnl_Head.SuspendLayout();
			this.pnl_BT.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.SystemColors.Window;
			this.c1Sizer1.Controls.Add(this.pnl_Tail);
			this.c1Sizer1.Controls.Add(this.pnl_Head);
			this.c1Sizer1.GridDefinition = "12.1527777777778:False:True;85.7638888888889:False:False;\t99.2125984251968:False:" +
				"False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 31;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_Tail
			// 
			this.pnl_Tail.Controls.Add(this.obar_Main);
			this.pnl_Tail.Location = new System.Drawing.Point(4, 78);
			this.pnl_Tail.Name = "pnl_Tail";
			this.pnl_Tail.Size = new System.Drawing.Size(1008, 494);
			this.pnl_Tail.TabIndex = 1;
			// 
			// obar_Main
			// 
			this.obar_Main.Controls.Add(this.obarpg_Release);
			this.obar_Main.Controls.Add(this.obarpg_ReleaseDef);
			this.obar_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.obar_Main.Location = new System.Drawing.Point(0, 0);
			this.obar_Main.Name = "obar_Main";
			this.obar_Main.Pages.Add(this.obarpg_Release);
			this.obar_Main.Pages.Add(this.obarpg_ReleaseDef);
			this.obar_Main.SelectedIndex = 1;
			this.obar_Main.Size = new System.Drawing.Size(1008, 494);
			this.obar_Main.Text = "c1OutBar1";
			// 
			// obarpg_Release
			// 
			this.obarpg_Release.Controls.Add(this.fgrid_Release);
			this.obarpg_Release.Location = new System.Drawing.Point(0, 0);
			this.obarpg_Release.Name = "obarpg_Release";
			this.obarpg_Release.Size = new System.Drawing.Size(0, 0);
			this.obarpg_Release.TabIndex = 0;
			this.obarpg_Release.Text = "Dail WorkSheet Release";
			// 
			// fgrid_Release
			// 
			this.fgrid_Release.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Release.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Release.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Release.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Release.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Release.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_Release.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Release.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Release.Name = "fgrid_Release";
			this.fgrid_Release.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Release.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Release.TabIndex = 44;
			this.fgrid_Release.Click += new System.EventHandler(this.fgrid_Release_Click);
			this.fgrid_Release.DoubleClick += new System.EventHandler(this.fgrid_Release_DoubleClick);
			// 
			// obarpg_ReleaseDef
			// 
			this.obarpg_ReleaseDef.Controls.Add(this.fgrid_ReleaseDef);
			this.obarpg_ReleaseDef.Location = new System.Drawing.Point(0, 40);
			this.obarpg_ReleaseDef.Name = "obarpg_ReleaseDef";
			this.obarpg_ReleaseDef.Size = new System.Drawing.Size(1008, 434);
			this.obarpg_ReleaseDef.TabIndex = 1;
			this.obarpg_ReleaseDef.Text = "Dail WorkSheet Release (Defect)";
			// 
			// fgrid_ReleaseDef
			// 
			this.fgrid_ReleaseDef.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_ReleaseDef.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_ReleaseDef.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_ReleaseDef.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_ReleaseDef.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_ReleaseDef.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_ReleaseDef.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_ReleaseDef.Location = new System.Drawing.Point(0, 0);
			this.fgrid_ReleaseDef.Name = "fgrid_ReleaseDef";
			this.fgrid_ReleaseDef.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_ReleaseDef.Size = new System.Drawing.Size(1008, 434);
			this.fgrid_ReleaseDef.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_ReleaseDef.TabIndex = 44;
			this.fgrid_ReleaseDef.Click += new System.EventHandler(this.fgrid_ReleaseDef_Click);
			// 
			// pnl_Head
			// 
			this.pnl_Head.Controls.Add(this.pnl_BT);
			this.pnl_Head.Location = new System.Drawing.Point(4, 4);
			this.pnl_Head.Name = "pnl_Head";
			this.pnl_Head.Size = new System.Drawing.Size(1008, 70);
			this.pnl_Head.TabIndex = 0;
			// 
			// pnl_BT
			// 
			this.pnl_BT.BackColor = System.Drawing.Color.Transparent;
			this.pnl_BT.Controls.Add(this.pnl_SearchImage);
			this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BT.DockPadding.Bottom = 5;
			this.pnl_BT.Location = new System.Drawing.Point(0, 0);
			this.pnl_BT.Name = "pnl_BT";
			this.pnl_BT.Size = new System.Drawing.Size(1008, 72);
			this.pnl_BT.TabIndex = 46;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.btn_Release);
			this.pnl_SearchImage.Controls.Add(this.btn_PCard);
			this.pnl_SearchImage.Controls.Add(this.txt_MaxAsyDate);
			this.pnl_SearchImage.Controls.Add(this.lbl_ReleaseDay);
			this.pnl_SearchImage.Controls.Add(this.dpick_ConfirmYMD);
			this.pnl_SearchImage.Controls.Add(this.lbl_ConfirmYMD);
			this.pnl_SearchImage.Controls.Add(this.lbl_NOS1);
			this.pnl_SearchImage.Controls.Add(this.lbl_NOS);
			this.pnl_SearchImage.Controls.Add(this.lbl_Stit22);
			this.pnl_SearchImage.Controls.Add(this.lbl_Stit11);
			this.pnl_SearchImage.Controls.Add(this.lbl_Stit2);
			this.pnl_SearchImage.Controls.Add(this.lbl_Stit1);
			this.pnl_SearchImage.Controls.Add(this.btn_WorkArea);
			this.pnl_SearchImage.Controls.Add(this.btn_Cancel);
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.pictureBox1);
			this.pnl_SearchImage.Controls.Add(this.pictureBox2);
			this.pnl_SearchImage.Controls.Add(this.pictureBox3);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1008, 67);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// btn_Release
			// 
			this.btn_Release.Location = new System.Drawing.Point(392, 35);
			this.btn_Release.Name = "btn_Release";
			this.btn_Release.Size = new System.Drawing.Size(80, 23);
			this.btn_Release.TabIndex = 296;
			this.btn_Release.Text = "Release";
			this.btn_Release.Click += new System.EventHandler(this.btn_Release_Click);
			// 
			// btn_PCard
			// 
			this.btn_PCard.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_PCard.ImageIndex = 0;
			this.btn_PCard.ImageList = this.img_Button;
			this.btn_PCard.Location = new System.Drawing.Point(473, 35);
			this.btn_PCard.Name = "btn_PCard";
			this.btn_PCard.Size = new System.Drawing.Size(80, 23);
			this.btn_PCard.TabIndex = 295;
			this.btn_PCard.Text = "Pass Card";
			this.btn_PCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_PCard.Click += new System.EventHandler(this.btn_PCard_Click);
			this.btn_PCard.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_PCard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_PCard.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_PCard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// txt_MaxAsyDate
			// 
			this.txt_MaxAsyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_MaxAsyDate.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_MaxAsyDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_MaxAsyDate.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_MaxAsyDate.Location = new System.Drawing.Point(808, 36);
			this.txt_MaxAsyDate.MaxLength = 60;
			this.txt_MaxAsyDate.Name = "txt_MaxAsyDate";
			this.txt_MaxAsyDate.ReadOnly = true;
			this.txt_MaxAsyDate.TabIndex = 284;
			this.txt_MaxAsyDate.Text = "";
			// 
			// lbl_ReleaseDay
			// 
			this.lbl_ReleaseDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_ReleaseDay.ImageIndex = 0;
			this.lbl_ReleaseDay.ImageList = this.img_Label;
			this.lbl_ReleaseDay.Location = new System.Drawing.Point(707, 36);
			this.lbl_ReleaseDay.Name = "lbl_ReleaseDay";
			this.lbl_ReleaseDay.Size = new System.Drawing.Size(100, 21);
			this.lbl_ReleaseDay.TabIndex = 282;
			this.lbl_ReleaseDay.Text = "Max Asy. Date";
			this.lbl_ReleaseDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_ConfirmYMD
			// 
			this.dpick_ConfirmYMD.CustomFormat = "yyyyMMdd";
			this.dpick_ConfirmYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_ConfirmYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ConfirmYMD.Location = new System.Drawing.Point(277, 36);
			this.dpick_ConfirmYMD.Name = "dpick_ConfirmYMD";
			this.dpick_ConfirmYMD.Size = new System.Drawing.Size(102, 22);
			this.dpick_ConfirmYMD.TabIndex = 294;
			this.dpick_ConfirmYMD.CloseUp += new System.EventHandler(this.dpick_ConfirmYMD_CloseUp);
			// 
			// lbl_ConfirmYMD
			// 
			this.lbl_ConfirmYMD.ImageIndex = 0;
			this.lbl_ConfirmYMD.ImageList = this.img_Label;
			this.lbl_ConfirmYMD.Location = new System.Drawing.Point(176, 36);
			this.lbl_ConfirmYMD.Name = "lbl_ConfirmYMD";
			this.lbl_ConfirmYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_ConfirmYMD.TabIndex = 34;
			this.lbl_ConfirmYMD.Text = "Confirm Day";
			this.lbl_ConfirmYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_NOS1
			// 
			this.lbl_NOS1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_NOS1.ImageIndex = 0;
			this.lbl_NOS1.ImageList = this.img_SmallLabel;
			this.lbl_NOS1.Location = new System.Drawing.Point(874, 0);
			this.lbl_NOS1.Name = "lbl_NOS1";
			this.lbl_NOS1.Size = new System.Drawing.Size(50, 21);
			this.lbl_NOS1.TabIndex = 290;
			this.lbl_NOS1.Text = "NOS";
			this.lbl_NOS1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_NOS
			// 
			this.lbl_NOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_NOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_NOS.Location = new System.Drawing.Point(925, 0);
			this.lbl_NOS.Name = "lbl_NOS";
			this.lbl_NOS.Size = new System.Drawing.Size(74, 21);
			this.lbl_NOS.TabIndex = 293;
			this.lbl_NOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_Stit22
			// 
			this.lbl_Stit22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Stit22.ImageIndex = 0;
			this.lbl_Stit22.ImageList = this.img_SmallLabel;
			this.lbl_Stit22.Location = new System.Drawing.Point(747, 0);
			this.lbl_Stit22.Name = "lbl_Stit22";
			this.lbl_Stit22.Size = new System.Drawing.Size(50, 21);
			this.lbl_Stit22.TabIndex = 288;
			this.lbl_Stit22.Text = "Stit 2";
			this.lbl_Stit22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Stit11
			// 
			this.lbl_Stit11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Stit11.ImageIndex = 0;
			this.lbl_Stit11.ImageList = this.img_SmallLabel;
			this.lbl_Stit11.Location = new System.Drawing.Point(620, 0);
			this.lbl_Stit11.Name = "lbl_Stit11";
			this.lbl_Stit11.Size = new System.Drawing.Size(50, 21);
			this.lbl_Stit11.TabIndex = 286;
			this.lbl_Stit11.Text = "Stit 1";
			this.lbl_Stit11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Stit2
			// 
			this.lbl_Stit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Stit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_Stit2.Location = new System.Drawing.Point(798, 0);
			this.lbl_Stit2.Name = "lbl_Stit2";
			this.lbl_Stit2.Size = new System.Drawing.Size(75, 21);
			this.lbl_Stit2.TabIndex = 292;
			this.lbl_Stit2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_Stit1
			// 
			this.lbl_Stit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Stit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_Stit1.Location = new System.Drawing.Point(671, 0);
			this.lbl_Stit1.Name = "lbl_Stit1";
			this.lbl_Stit1.Size = new System.Drawing.Size(75, 21);
			this.lbl_Stit1.TabIndex = 291;
			this.lbl_Stit1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_WorkArea
			// 
			this.btn_WorkArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_WorkArea.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_WorkArea.ImageIndex = 0;
			this.btn_WorkArea.ImageList = this.img_Button;
			this.btn_WorkArea.Location = new System.Drawing.Point(920, 35);
			this.btn_WorkArea.Name = "btn_WorkArea";
			this.btn_WorkArea.Size = new System.Drawing.Size(80, 23);
			this.btn_WorkArea.TabIndex = 284;
			this.btn_WorkArea.Text = "Work Area";
			this.btn_WorkArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_WorkArea.Click += new System.EventHandler(this.btn_WorkArea_Click);
			this.btn_WorkArea.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_WorkArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_WorkArea.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_WorkArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(554, 35);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(80, 23);
			this.btn_Cancel.TabIndex = 281;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory.Caption = "";
			this.cmb_Factory.CaptionHeight = 17;
			this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory.ColumnCaptionHeight = 18;
			this.cmb_Factory.ColumnFooterHeight = 18;
			this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(61, 36);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(100, 21);
			this.cmb_Factory.TabIndex = 33;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_SmallLabel;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(50, 21);
			this.lbl_Factory.TabIndex = 32;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(993, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 27);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(992, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(784, 32);
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
			this.lbl_SubTitle1.Text = "      Daily WorkSheet";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(992, 51);
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
			this.picb_BM.Size = new System.Drawing.Size(848, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 47);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(168, 20);
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 24);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(168, 25);
			this.pictureBox2.TabIndex = 25;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(160, 24);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(840, 25);
			this.pictureBox3.TabIndex = 27;
			this.pictureBox3.TabStop = false;
			// 
			// txt_StatusDay
			// 
			this.txt_StatusDay.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StatusDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StatusDay.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StatusDay.Location = new System.Drawing.Point(408, 32);
			this.txt_StatusDay.MaxLength = 60;
			this.txt_StatusDay.Name = "txt_StatusDay";
			this.txt_StatusDay.ReadOnly = true;
			this.txt_StatusDay.Size = new System.Drawing.Size(75, 21);
			this.txt_StatusDay.TabIndex = 284;
			this.txt_StatusDay.Text = "";
			this.txt_StatusDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_StatusDay.Visible = false;
			// 
			// txt_NextWorkDay
			// 
			this.txt_NextWorkDay.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_NextWorkDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_NextWorkDay.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_NextWorkDay.Location = new System.Drawing.Point(536, 32);
			this.txt_NextWorkDay.MaxLength = 60;
			this.txt_NextWorkDay.Name = "txt_NextWorkDay";
			this.txt_NextWorkDay.ReadOnly = true;
			this.txt_NextWorkDay.TabIndex = 286;
			this.txt_NextWorkDay.Text = "";
			this.txt_NextWorkDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_NextWorkDay.Visible = false;
			// 
			// txt_Status
			// 
			this.txt_Status.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Status.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Status.Location = new System.Drawing.Point(480, 32);
			this.txt_Status.MaxLength = 60;
			this.txt_Status.Name = "txt_Status";
			this.txt_Status.ReadOnly = true;
			this.txt_Status.Size = new System.Drawing.Size(56, 21);
			this.txt_Status.TabIndex = 285;
			this.txt_Status.Text = "";
			this.txt_Status.Visible = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(360, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 287;
			this.label1.Text = "StatusDay";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Visible = false;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(464, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 288;
			this.label2.Text = "Status";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Visible = false;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(568, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 289;
			this.label3.Text = "NextWorkDay";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Visible = false;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form_PD_WorkSheet_Release
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_StatusDay);
			this.Controls.Add(this.txt_NextWorkDay);
			this.Controls.Add(this.txt_Status);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_PD_WorkSheet_Release";
			this.Text = "Release Daily Production Order Sheet";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.txt_Status, 0);
			this.Controls.SetChildIndex(this.txt_NextWorkDay, 0);
			this.Controls.SetChildIndex(this.txt_StatusDay, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_Tail.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
			this.obar_Main.ResumeLayout(false);
			this.obarpg_Release.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Release)).EndInit();
			this.obarpg_ReleaseDef.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ReleaseDef)).EndInit();
			this.pnl_Head.ResumeLayout(false);
			this.pnl_BT.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 
 
		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction();
 
		//작업지시 나간 상태 표시 (planstatus = 'D'인 경우)
		private string _Release_Div = "R";

		//최근 작업지시 일자, 최근 작업지시 상태, 다음 내릴 작업지시 일자
		private string _MaxReleasedDate;
		private string _MaxReleasedStatus;
		private string _NextReleasedDate;


		//오늘 날짜
		private string _TodayDate;

		//작업지시, 패스카드 구분 Flag
		private bool _ReleaseYN = false;
		private bool _PCardYN = false;



		//선택되어졌던 젠더 행
		private int _BeforeGenRow = -1;
		private int _BeforeGenRow1 = -1; 


        //// thread process wait. form
        //private FlexAPS.ProdBase.Pop_ProcessWait _PopForm;


		// thread return value
		private bool _Thread_Run_Flag = false;



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
				this.Text = "Release Daily Production Order Sheet";
				lbl_MainTitle.Text = "Release Daily Production Order Sheet"; 
  


				fgrid_Release.Set_Grid("SPD_RELEASE_BSC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_Release.Set_Action_Image(img_Action);
				fgrid_Release.AllowSorting = AllowSortingEnum.None;
				fgrid_Release.AllowEditing = false;
				fgrid_Release.ExtendLastCol = false;
				fgrid_Release.Font = new Font("Verdana", 7); 
				fgrid_Release.AllowSorting = AllowSortingEnum.None;
				fgrid_Release.AllowDragging = AllowDraggingEnum.None;
  
				fgrid_ReleaseDef.Set_Grid("SPD_RELEASE_DEF_BSC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_ReleaseDef.AllowSorting = AllowSortingEnum.None;
				fgrid_ReleaseDef.AllowEditing = false;
				fgrid_ReleaseDef.ExtendLastCol = false;
				fgrid_ReleaseDef.Font = new Font("Verdana", 7); 
				fgrid_ReleaseDef.AllowSorting = AllowSortingEnum.None;
				fgrid_ReleaseDef.AllowDragging = AllowDraggingEnum.None;


				
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
  
			tbtn_New.Enabled = false;
			tbtn_Save.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false; 
			tbtn_Color.Enabled = false;   

			dpick_ConfirmYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;

			btn_PCard.Enabled = false; 

			if(ClassLib.ComVar.This_Admin_YN == "N") 
			{
				btn_Cancel.Visible = false;
			}



			obar_Main.SelectedPage = obarpg_Release;

			//today
			_TodayDate = System.DateTime.Now.ToString("yyyyMMdd");


			// Factory Combobox Add Items
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
			dt_ret.Dispose();
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;  


		} 
		
 



		#endregion
		  
		#region 조회
 
		

		/// <summary>
		/// Display_Data : 사이즈 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Data(DataTable arg_dt, COM.FSP arg_fgrid)
		{  

			string before_item = "", now_item = "";
			int gen_row = 0;  
			string sel_gen = "";
			int min_size_col = arg_fgrid.Cols.Count + 1;
			int size_qty = 0, sum_size_qty = 0;


			
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;

			if(arg_dt.Rows.Count == 0) return; 


			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{ 
 

				if(arg_fgrid.Equals(fgrid_Release) )
				{

					now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxLINE_CD - 1].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxLOT - 1].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxREQ_NO - 1].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxDESC1 - 1].ToString(); // day_seq
					

				}
				else if(arg_fgrid.Equals(fgrid_ReleaseDef) )
				{

					now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxLINE_CD - 1].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxLOT - 1].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxREQ_NO - 1].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxDESC1 - 1].ToString() // jit_req_type
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxDESC5 - 1].ToString() // cmp_cd
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxDESC6 - 1].ToString() // str_op_cd
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxDESC7 - 1].ToString(); // end_op_cd


				}


				if(before_item != now_item)
				{ 
					arg_fgrid.Rows.Add();   



					arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = "";

					for(int a = (int)ClassLib.TBSPD_RELEASE_BSC.IxFACTORY; a < (int)ClassLib.TBSPD_RELEASE_BSC.IxCS_SIZE_START; a++)
					{ 
						arg_fgrid[arg_fgrid.Rows.Count - 1, a] = arg_dt.Rows[i].ItemArray[a - 1].ToString();
					}

					
					//작지전, 후 색깔 표시 위해 세팅
					if(arg_fgrid.Equals(fgrid_Release) )
					{ 
						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxDESC3 - 1].ToString() == "D") // PLAN_STATUS
						{
							arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = _Release_Div;
						}
						else
						{
							arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = "";
						}
					}
						

					//gen
					for(int j = 1; j <= arg_fgrid.Rows.Fixed; j++)
					{
						if(arg_fgrid[j, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + arg_fgrid[gen_row, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN].ToString();

							break;
						} 
					}

					before_item = now_item;
  
					sum_size_qty = 0;


				}

				//사이즈별 수량 표시
				for(int j = (int)ClassLib.TBSPD_RELEASE_BSC.IxCS_SIZE_START; j < arg_fgrid.Cols.Count; j++)
				{
					if(arg_fgrid[gen_row, j].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxCS_SIZE - 1].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						size_qty = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_RELEASE_BSC.IxSIZE_QTY - 1].ToString()); 
						arg_fgrid[arg_fgrid.Rows.Count - 1, j] = (size_qty.ToString() == "0") ? "" : size_qty.ToString();

						sum_size_qty += size_qty; 
						
						break;   
					} 
				}


				arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPD_RELEASE_BSC.IxTOT_QTY] = sum_size_qty.ToString();



			} // end for i

//			//--------------------------------------------------------------
//			//LOT에 대한 젠더만 표시
//			string[] token = sel_gen.Split('/');
//
//			for(int i = 2; i < arg_fgrid.Rows.Fixed; i++) 
//				arg_fgrid.Rows[i].Visible = false;   
//
//			for(int i = 2; i < arg_fgrid.Rows.Fixed; i++) 
//			{
//				for(int j = 0; j < token.Length; j++)
//				{
//					if(arg_fgrid[i, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN].ToString() == token[j])
//					{
//						arg_fgrid.Rows[i].Visible = true; 
//						break;
//					} 
//				} // end for j 
//			} // end for i



			//--------------------------------------------------------------
			//Merge 속성
			arg_fgrid.AllowMerging = AllowMergingEnum.Free; 
			for(int i = (int)ClassLib.TBSPD_RELEASE_BSC.IxCS_SIZE_START; i < arg_fgrid.Cols.Count; i++)
			{
				arg_fgrid.Cols[i].AllowMerging = false;  
			}

			//--------------------------------------------------------------
			//SubTotals  
			arg_fgrid.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
			arg_fgrid.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black; 
			arg_fgrid.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
			arg_fgrid.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;

			arg_fgrid.Subtotal(AggregateEnum.Sum, 0, -1, (int)ClassLib.TBSPD_RELEASE_BSC.IxTOT_QTY, "Sum is {0}");  

			for (int i = (int)ClassLib.TBSPD_RELEASE_BSC.IxCS_SIZE_START; i < arg_fgrid.Cols.Count; i++)
			{
				arg_fgrid.Subtotal(AggregateEnum.Sum, 0, -1, i, "Sum is {0}");  
			}

 


			// 정상작업지시 일 경우, LOT 별 수량 표시
			if(arg_fgrid.Equals(fgrid_Release) )
			{
				arg_fgrid.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPD_RELEASE_BSC.IxLOT, (int)ClassLib.TBSPD_RELEASE_BSC.IxTOT_QTY, "Sum is {0}");  

				for (int i = (int)ClassLib.TBSPD_RELEASE_BSC.IxCS_SIZE_START; i < arg_fgrid.Cols.Count; i++)
				{
					arg_fgrid.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPD_RELEASE_BSC.IxLOT, i, "Sum is {0}");  
				}
			} // end if(arg_fgrid.Equals(fgrid_Release) )
		 

//
//			// 정상작업지시 일 경우, Line 별 수량 표시
//			if(arg_fgrid.Equals(fgrid_Release) )
//			{
//				arg_fgrid.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPD_RELEASE_BSC.IxLINE_CD, (int)ClassLib.TBSPD_RELEASE_BSC.IxTOT_QTY, "Sum is {0}");  
//
//				for (int i = (int)ClassLib.TBSPD_RELEASE_BSC.IxCS_SIZE_START; i < arg_fgrid.Cols.Count; i++)
//				{
//					arg_fgrid.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPD_RELEASE_BSC.IxLINE_CD, i, "Sum is {0}");  
//				}
//			} // end if(arg_fgrid.Equals(fgrid_Release) )


 


			//기타 속성 
			arg_fgrid.LeftCol = min_size_col;
			arg_fgrid.Cols.Frozen = (int)ClassLib.TBSPD_RELEASE_BSC.IxCS_SIZE_START; 
			 

		} 
 
 
		/// <summary>
		/// Set_Button_Status : release, cancel button status setting
		/// </summary>
		private void Set_Button_Status()
		{
			try
			{ 

				//작업지시일때만 작지 버튼 활성화
				if(dpick_ConfirmYMD.Value.ToString("yyyyMMdd") == MyComFunction.ConvertDate2DbType(_NextReleasedDate) )  
				{ 
 
					//작업지시 상태 "O(K)" 이면 패스카드 버튼 활성화
					if(txt_Status.Text.Substring(0, 1) == "O")
					{
						btn_Release.Enabled = false;
						btn_Release.BackColor = ClassLib.ComVar.ClrReleaseNone;  
						btn_PCard.Enabled = true;
						
						if(ClassLib.ComVar.This_Admin_YN == "Y")
						{
							btn_Cancel.Visible = true;
						}
						else
						{
							btn_Cancel.Visible = false;
						}

						_ReleaseYN = true;
						_PCardYN = false; 
					}
					else
					{
						btn_Release.Enabled = true;
						Set_Finish_Check(); 
						btn_PCard.Enabled = false;
						btn_Cancel.Visible = false; 
						_ReleaseYN = false; 
						_PCardYN = true;
					}

				}
				else
				{ 
					btn_Release.Enabled = false;
					btn_Release.BackColor = ClassLib.ComVar.ClrReleaseNone;
					btn_PCard.Enabled = false;
					btn_Cancel.Visible = false; 
					_ReleaseYN = true;
					_PCardYN = true; 

				}
  



				//--------------------------------------------------------
				// 2006_01_09 수정
				// VJ : Passcard 버튼 작업 처리 안함
				// QD : 버튼 처리 함
				if(cmb_Factory.SelectedValue.ToString() == "VJ" || cmb_Factory.SelectedValue.ToString() == "JJ")
				{
					btn_PCard.Visible = false;
					btn_Cancel.Location = new Point(btn_PCard.Location.X, btn_PCard.Location.Y);
				}

				//--------------------------------------------------------





				//바로 전날 작업지시일때만 취소 버튼 보여주기
				if(ClassLib.ComVar.This_Admin_YN == "Y")
				{
					if(dpick_ConfirmYMD.Value.ToString("yyyyMMdd") == MyComFunction.ConvertDate2DbType(_MaxReleasedDate) )
					{
						if(txt_Status.Text.Substring(0, 1) == "O")
						{
							btn_Cancel.Visible = false; 
						}
						else
						{
							btn_Cancel.Visible = true;
						}
					}
					else
					{
						btn_Cancel.Visible = false; 
					} 
				}



			}
			catch
			{
			}
		}



		/// <summary>
		/// Set_Finish_Check : finish 상태 체크
		/// </summary>
		private void Set_Finish_Check()
		{
			try
			{ 
  
				int find_ts_row = fgrid_Release.FindRow("N", fgrid_Release.Rows.Fixed, (int)ClassLib.TBSPD_RELEASE_BSC.IxTS_FINISH_YN, false, true, false);
				
				//all finish
				if(find_ts_row == -1)
				{	
					btn_Release.BackColor = ClassLib.ComVar.ClrReleaseAll_Y;
					return;
				}

				find_ts_row = fgrid_Release.FindRow("Y", fgrid_Release.Rows.Fixed, (int)ClassLib.TBSPD_RELEASE_BSC.IxTS_FINISH_YN, false, true, false);

				//all no finish
				if(find_ts_row == -1)
				{	
					btn_Release.BackColor = ClassLib.ComVar.ClrReleaseAll_N;
					return;
				}

				// finish + no finish
				//btn_Release.BackColor = ClassLib.ComVar.ClrReleaseMix_YN; 
				btn_Release.BackColor = ClassLib.ComVar.ClrReleaseAll_N;
			
			}
			catch
			{
			}
		}




		#endregion

		#region 툴바 이벤트 메서드

 
		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{

			if(cmb_Factory.SelectedIndex == -1) return;   
			
			string factory = cmb_Factory.SelectedValue.ToString();

			//-----------------------------------------------------------------------------------------------
			//next work day 추출 
			//-----------------------------------------------------------------------------------------------
			txt_StatusDay.Text = "";
			txt_Status.Text = "";
			txt_NextWorkDay.Text = "";
			txt_MaxAsyDate.Text = ""; 


			DataTable dt_ret = Select_NEXTWORKDAY(factory);
			txt_StatusDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
			txt_Status.Text = dt_ret.Rows[0].ItemArray[1].ToString();
			txt_NextWorkDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString());  

			_MaxReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
			_MaxReleasedStatus = dt_ret.Rows[0].ItemArray[1].ToString();
			_NextReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString()); 
			
			//dpick_ConfirmYMD.Text = _NextReleasedDate;
			//-----------------------------------------------------------------------------------------------


			//-----------------------------------------------------------------------------------------------
			//release, cancel button status setting
			//-----------------------------------------------------------------------------------------------
			Set_Button_Status();
			//-----------------------------------------------------------------------------------------------


			string confirm_ymd = dpick_ConfirmYMD.Value.ToString("yyyyMMdd");
			//-----------------------------------------------------------------------------------------------
			//Max Asy. Date 추출
			//-----------------------------------------------------------------------------------------------
			txt_MaxAsyDate.Text = "";
			dt_ret = Select_OPSIZE_MAX_ASY_DATE(factory, confirm_ymd);
			txt_MaxAsyDate.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString()); 
			//-----------------------------------------------------------------------------------------------


			//-----------------------------------------------------------------------------------------------
			//Search stit1, stit2, nos qty.
			//-----------------------------------------------------------------------------------------------
			lbl_Stit1.Text = "";
			lbl_Stit2.Text = "";
			lbl_NOS.Text = "";
				
			//SPD_LOT_DAILY_OPSIZE  -> stit1, stit2, nos qty.
			dt_ret = Select_OPSIZE_AREA_QTY(factory, confirm_ymd);
			//column 0: div, 1: mat_area, 2: size_qty
			//row 0: stit1, 1: stit2, 2: NOS  



			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{

				if(dt_ret.Rows[i].ItemArray[0].ToString() == "1") // main
				{

					if(dt_ret.Rows[i].ItemArray[1].ToString() == "000")
					{
						lbl_Stit1.Text = dt_ret.Rows[i].ItemArray[2].ToString();
					}
					else if(dt_ret.Rows[i].ItemArray[1].ToString() == "400")
					{
						lbl_Stit2.Text = dt_ret.Rows[i].ItemArray[2].ToString();
					}

				}
				else
				{
					lbl_NOS.Text = dt_ret.Rows[i].ItemArray[2].ToString();
				}


			} // end for i



//			if(dt_ret.Rows.Count == 1)
//			{
//				lbl_Stit1.Text = dt_ret.Rows[0].ItemArray[2].ToString();
//				lbl_Stit2.Text = "0";
//				lbl_NOS.Text = "0";
//			}
//			else if(dt_ret.Rows.Count == 2)
//			{
//				lbl_Stit1.Text = dt_ret.Rows[0].ItemArray[2].ToString();
//				lbl_Stit2.Text = "0";
//				lbl_NOS.Text = dt_ret.Rows[1].ItemArray[2].ToString();  
//			}
//			else if(dt_ret.Rows.Count == 3)
//			{
//				lbl_Stit1.Text = dt_ret.Rows[0].ItemArray[2].ToString();
//				lbl_Stit2.Text = dt_ret.Rows[1].ItemArray[2].ToString();
//				lbl_NOS.Text = dt_ret.Rows[2].ItemArray[2].ToString(); 
//
//			}
			//-----------------------------------------------------------------------------------------------


			//-----------------------------------------------------------------------------------------------
			// 데이터 조회
			//-----------------------------------------------------------------------------------------------
			DataSet ds_ret = Select_SPD_DAILY_WORKSHEET(factory, confirm_ymd);

			DataTable dt_ret_release = ds_ret.Tables[0];
			Display_Data(dt_ret_release, fgrid_Release);
			Set_Finish_Check();

			DataTable dt_ret_release_def = ds_ret.Tables[1];
			Display_Data(dt_ret_release_def, fgrid_ReleaseDef);
			//-----------------------------------------------------------------------------------------------



		}

 
	
		/// <summary>
		/// Event_Tbtn_Print : 
		/// </summary>
		private void Event_Tbtn_Print()
		{


			this.Cursor = Cursors.WaitCursor;

			string title = "";
			string para  = "";

 

			if(fgrid_Release.Rows.Count < fgrid_Release.Rows.Fixed) return;

 
			string filename = Application.StartupPath + @"\Report\Production\" + this.Name + ".txt";
			string sDir = ClassLib.ComFunction.Set_RD_Directory(this.Name); 

			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;



			if(obar_Main.SelectedPage.Name == "obarpg_Release")
			{

				fgrid_Release.ClipSeparators = "@ ";
				fgrid_Release.SaveGrid( filename, FileFormatEnum.TextCustom);



				title = "DailySheet Release";

				sDir = ClassLib.ComFunction.Set_RD_Directory("Form_PD_WorkSheet_Release"); 




//				para = "/rfn [" + Application.StartupPath + @"\" + this.Name + ".txt] /rv V_STIT1[" + lbl_Stit1.Text + "]V_STIT2[" + lbl_Stit2.Text + "]V_NOS1[" + lbl_NOS.Text + "] V_DATE[" 
//					+ txt_StatusDay.Text + "] V_STATUS[" + txt_Status.Text + "] V_REDATE[" + dpick_ConfirmYMD.Text +"]";
//				
//				COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report(title, this.Name +".mrd", para);

				para = "/rfn [" + filename + "] /rv V_STIT1[" + lbl_Stit1.Text + "]V_STIT2[" + lbl_Stit2.Text + "]V_NOS1[" + lbl_NOS.Text + "] V_DATE[" 
					+ txt_StatusDay.Text + "] V_STATUS[" + txt_Status.Text + "] V_REDATE[" + dpick_ConfirmYMD.Text +"]";
				
				COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report(title, sDir, para);


				report.ShowDialog();

				
			}
			else
			{
				fgrid_ReleaseDef.ClipSeparators = "@ "; 
				fgrid_ReleaseDef.SaveGrid( filename, FileFormatEnum.TextCustom);



				title = "DailySheet Defective";

				sDir = ClassLib.ComFunction.Set_RD_Directory("Form_PD_WorkSheet_Defective"); 

				

//				para = "/rfn [" + Application.StartupPath + @"\" + this.Name + ".txt] /rv V_DATE[" + txt_StatusDay.Text 
//					+ "] V_STATUS[" + txt_Status.Text + "] V_REDATE[" + dpick_ConfirmYMD.Text +"]"; 
//				COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report(title , "Form_PD_WorkSheet_Defective.mrd", para);

				
				para = "/rfn [" + filename + "] /rv V_DATE[" + txt_StatusDay.Text 
					+ "] V_STATUS[" + txt_Status.Text + "] V_REDATE[" + dpick_ConfirmYMD.Text +"]"; 

				
				COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report(title, sDir, para);


				report.ShowDialog();
			}
			
			

			this.Cursor = Cursors.Default;



		}



		#endregion

		#region 그리드 이벤트 메서드
 

		#endregion

		#region 버튼 및 기타 이벤트 메서드
 

		/// <summary>
		/// Event_SelectedValueChanged_cmb_Factory : 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_Factory()
		{
 
			if(cmb_Factory.SelectedIndex == -1) return;   
			 
			string factory = cmb_Factory.SelectedValue.ToString();

			//-----------------------------------------------------------------------------------------------
			// 사이즈 헤더 할당
			//-----------------------------------------------------------------------------------------------
			// 정상 작업지시
			fgrid_Release.Rows.Count = 2;  
			ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_Release, 
														factory, 
														"", 
														fgrid_Release.Rows.Fixed,
														(int)ClassLib.TBSPD_RELEASE_BSC.IxGEN,
														(int)ClassLib.TBSPD_RELEASE_BSC.IxCS_SIZE_START);



			// 불량 작업지시
			fgrid_ReleaseDef.Rows.Count = 2;  
			ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_ReleaseDef, 
														factory, 
														"", 
														fgrid_ReleaseDef.Rows.Fixed,
														(int)ClassLib.TBSPD_RELEASE_BSC.IxGEN,
														(int)ClassLib.TBSPD_RELEASE_BSC.IxCS_SIZE_START);
			//-----------------------------------------------------------------------------------------------
 

			#region move event_tbtn_search()


//			//-----------------------------------------------------------------------------------------------
//			//next work day 추출 
//			//-----------------------------------------------------------------------------------------------
//			txt_StatusDay.Text = "";
//			txt_Status.Text = "";
//			txt_NextWorkDay.Text = "";
//			txt_MaxAsyDate.Text = ""; 
//
//
//			DataTable dt_ret = Select_NEXTWORKDAY(factory);
//			txt_StatusDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
//			txt_Status.Text = dt_ret.Rows[0].ItemArray[1].ToString();
//			txt_NextWorkDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString());  
//
//			_MaxReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
//			_MaxReleasedStatus = dt_ret.Rows[0].ItemArray[1].ToString();
//			_NextReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString()); 
//			
//			dpick_ConfirmYMD.Text = _NextReleasedDate;
//			//-----------------------------------------------------------------------------------------------
//
//
//			//-----------------------------------------------------------------------------------------------
//			//release, cancel button status setting
//			//-----------------------------------------------------------------------------------------------
//			Set_Button_Status();
//			//-----------------------------------------------------------------------------------------------
//
//
//			string confirm_ymd = dpick_ConfirmYMD.Value.ToString("yyyyMMdd");
//			//-----------------------------------------------------------------------------------------------
//			//Max Asy. Date 추출
//			//-----------------------------------------------------------------------------------------------
//			txt_MaxAsyDate.Text = "";
//			dt_ret = Select_OPSIZE_MAX_ASY_DATE(factory, confirm_ymd);
//			txt_MaxAsyDate.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString()); 
//			//-----------------------------------------------------------------------------------------------
//
//
//			//-----------------------------------------------------------------------------------------------
//			//Search stit1, stit2, nos qty.
//			//-----------------------------------------------------------------------------------------------
//			lbl_Stit1.Text = "";
//			lbl_Stit2.Text = "";
//			lbl_NOS.Text = "";
//				
//			//SPD_LOT_DAILY_OPSIZE  -> stit1, stit2, nos qty.
//			dt_ret = Select_OPSIZE_AREA_QTY(factory, confirm_ymd);
//			//column 0: div, 1: mat_area, 2: size_qty
//			//row 0: stit1, 1: stit2, 2: NOS  
//
//			if(dt_ret.Rows.Count == 1)
//			{
//				lbl_Stit1.Text = dt_ret.Rows[0].ItemArray[2].ToString();
//				lbl_Stit2.Text = "0";
//				lbl_NOS.Text = "0";
//			}
//			else if(dt_ret.Rows.Count == 2)
//			{
//				lbl_Stit1.Text = dt_ret.Rows[0].ItemArray[2].ToString();
//				lbl_Stit2.Text = "0";
//				lbl_NOS.Text = dt_ret.Rows[1].ItemArray[2].ToString();  
//			}
//			else if(dt_ret.Rows.Count == 3)
//			{
//				lbl_Stit1.Text = dt_ret.Rows[0].ItemArray[2].ToString();
//				lbl_Stit2.Text = dt_ret.Rows[1].ItemArray[2].ToString();
//				lbl_NOS.Text = dt_ret.Rows[2].ItemArray[2].ToString(); 
//
//			}
//			//-----------------------------------------------------------------------------------------------

			#endregion

 
			//-----------------------------------------------------------------------------------------------
			//next work day 추출 
			//-----------------------------------------------------------------------------------------------
			txt_StatusDay.Text = "";
			txt_Status.Text = "";
			txt_NextWorkDay.Text = "";
			txt_MaxAsyDate.Text = ""; 


			DataTable dt_ret = Select_NEXTWORKDAY(factory);
			txt_StatusDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
			txt_Status.Text = dt_ret.Rows[0].ItemArray[1].ToString();
			txt_NextWorkDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString());  

			_MaxReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
			_MaxReleasedStatus = dt_ret.Rows[0].ItemArray[1].ToString();
			_NextReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString()); 

			dpick_ConfirmYMD.Text = _NextReleasedDate;
			//-----------------------------------------------------------------------------------------------

			


			//-----------------------------------------------------------------------------------------------
			// 데이터 조회
			//-----------------------------------------------------------------------------------------------
			Event_Tbtn_Search();
 
			


		}
 
 

		/// <summary>
		/// Event_CloseUp_dpick_ConfirmYMD : 
		/// </summary>
		private void Event_CloseUp_dpick_ConfirmYMD()
		{

			txt_MaxAsyDate.Text = "";
			lbl_Stit1.Text = "";
			lbl_Stit2.Text = "";
			lbl_NOS.Text = "";

			fgrid_Release.Rows.Count = fgrid_Release.Rows.Fixed;
 
			if(Convert.ToInt32(dpick_ConfirmYMD.Value.ToString("yyyyMMdd") ) > Convert.ToInt32(MyComFunction.ConvertDate2DbType(_NextReleasedDate)) )  // Convert.ToInt32(_TodayDate))
			{
				ClassLib.ComFunction.User_Message("Not Confirm", "Change Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				btn_Release.Enabled = false;
				btn_Release.BackColor = ClassLib.ComVar.ClrReleaseNone;
				btn_PCard.Enabled = false;
				btn_Cancel.Visible = false;
				_ReleaseYN = false;
				_PCardYN = false;
				
				return;
			}

				
				
			Event_Tbtn_Search();

 
		} 



		/// <summary>
		/// Event_Click_btn_Release : 
		/// </summary>
		private void Event_Click_btn_Release()
		{

			
			if(cmb_Factory.SelectedIndex == -1) return;  
				 


			// all finish check
			if(btn_Release.BackColor.Equals(ClassLib.ComVar.ClrReleaseAll_Y))
			{

				DialogResult message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this);
				if(message_result == DialogResult.No) return;  
					
				this.Cursor = Cursors.WaitCursor; 
 

                //System.Threading.Thread thread_run = new System.Threading.Thread(new System.Threading.ThreadStart(Event_Click_btn_Release_Run));
                //thread_run.Start();

                //_PopForm = new FlexAPS.ProdBase.Pop_ProcessWait();
                //_PopForm.Processing();
                //_PopForm.Start(); 


                //// thread 종료 후 재 조회
                //thread_run.Abort(); 

                //if(_Thread_Run_Flag)
                //{
                //    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this); 
                //    Event_Tbtn_Search();
                //}
                //else
                //{
                //    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this); 
                //}


                Event_Click_btn_Release_Run();


                if (_Thread_Run_Flag)
                {
                    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
                    Event_Tbtn_Search();
                }
                else
                {
                    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
                }
				



			}
			else
			{
				 
				string factory = cmb_Factory.SelectedValue.ToString();
				string confirm_ymd = dpick_ConfirmYMD.Value.ToString("yyyyMMdd");

				Pop_ReleaseNoFinish pop_form = new Pop_ReleaseNoFinish(factory, confirm_ymd);  
				pop_form.ShowDialog();

			}



		}



		/// <summary>
		/// Event_Click_btn_Release_Run: thread 내부 실행 메서드
		/// </summary>
		private void Event_Click_btn_Release_Run()
		{


			try
			{

				DataTable dt_ret; 
				string error_count = "";
 
				string proc_name = "";
				string today = System.DateTime.Now.ToString("yyyyMMdd");
				string factory = cmb_Factory.SelectedValue.ToString();
				string confirm_ymd = "";


				confirm_ymd = dpick_ConfirmYMD.Value.ToString("yyyyMMdd");



				DataTable dt_check = null;


				//------------------------------------------------------------------
				// 2009-09-07 추가
				// 작업지시 사전 점검
				// 패스카드 작업 완료 사항 점검 (VJ : Passcard 버튼 작업 처리 안함)
				//------------------------------------------------------------------
				if(factory == "VJ" || factory == "JJ")
				{

					dt_check = CHECK_BEFORE_RELEASED_PASSCARD(factory, confirm_ymd);


					if(dt_check != null && dt_check.Rows.Count > 0 && dt_check.Rows[0].ItemArray[0].ToString().Trim() != "Y")
					{
						string message = @"Is progressing 'Passcard' creation." + "\r\n\r\n" + "You must communicate to 'IT'."; 
						ClassLib.ComFunction.User_Message(message, "Event_Click_btn_Release_Run", MessageBoxButtons.OK, MessageBoxIcon.Error);

						return;
					}



				}

				//------------------------------------------------------------------
				// 작업지시 사전 점검
				// spo_lot_daily, spd_lot_daily_opsize 수량 전체 점검
				//------------------------------------------------------------------
				dt_check = CHECK_BEFORE_RELEASED_ALL_QTY(factory, confirm_ymd);


				if(dt_check != null && dt_check.Rows.Count > 0)
				{
					string line_cd = dt_check.Rows[0].ItemArray[0].ToString();
					string line_name =dt_check.Rows[0].ItemArray[1].ToString();
					string lot = dt_check.Rows[0].ItemArray[2].ToString();
					
					string message = "Check leadtime." + "\r\n\r\n" + "Line : " + line_name + " (" + line_cd + ")" + "\r\n" + "LOT : " + lot; 
					ClassLib.ComFunction.User_Message(message, "Event_Click_btn_Release_Run", MessageBoxButtons.OK, MessageBoxIcon.Error);

					return;
				}


				//------------------------------------------------------------------
				// 작업지시 사전 점검
				// area (작업장) 설정이 miniline 별로 정확하게 할당되었는지 점검
				//------------------------------------------------------------------
				dt_check = CHECK_BEFORE_RELEASED_MINILINE_AREA(factory, confirm_ymd);


				if(dt_check != null && dt_check.Rows.Count > 0)
				{
					string line_cd = dt_check.Rows[0].ItemArray[0].ToString();
					string line_name =dt_check.Rows[0].ItemArray[1].ToString();
					string lot = dt_check.Rows[0].ItemArray[2].ToString();
					
					string message = "Check Miniline work area." + "\r\n\r\n" + "Line : " + line_name + " (" + line_cd + ")" + "\r\n" + "LOT : " + lot; 
					ClassLib.ComFunction.User_Message(message, "Event_Click_btn_Release_Run", MessageBoxButtons.OK, MessageBoxIcon.Error);

					return;
				}



				//------------------------------------------------------------------
				// 작업지시
				//------------------------------------------------------------------  
				Run_SP_SPD_Assign_Daily_WorkSheet(factory, confirm_ymd);  

				//------------------------------------------------------------------
				// 작업지시 내린 후 에러창 표시
				 
				proc_name = "PKG_SPD_CHECK_BSC.CHECK_LOT_INFO_NULL";
				error_count = Check_Error(factory, proc_name);

				// 0번째 오류 났으므로 첫번째 오류 체크 불필요
				if(Convert.ToInt32(error_count) > 0)
				{
					
					this.Cursor = Cursors.Default; 

					//proc_name = "PKG_SPD_CHECK_BSC.CHECK_LOT_INFO_NULL";
					COM.Com_Form.Form_Proc_Error check_error = new COM.Com_Form.Form_Proc_Error(true, today, proc_name, ClassLib.ComVar.CxErrorCheck_Error);
					check_error.ShowDialog();
					_ReleaseYN = false;

					_Thread_Run_Flag = false;
					return;
				}
					// 첫번째 오류 체크 : 작지 내리기전에 정합성 체크후 오류가 있으면 (v_err_ct>0 이면) 오류창 발생,  작지 conform실패
				else if(Convert.ToInt32(error_count) == 0)
				{
					error_count = "";  
					//error_count = Check_Error("1");

					proc_name = "PKG_SPD_CHECK_BSC.CHECK_DAILY_LOT_SIZE";
					error_count = Check_Error(factory, proc_name);

					// 첫번째 오류 났으므로 두번째 오류 체크 불필요
					if(Convert.ToInt32(error_count) > 0)
					{
					
						this.Cursor = Cursors.Default; 

						//proc_name = "PKG_SPD_CHECK_BSC.CHECK_DAILY_LOT_SIZE";
						COM.Com_Form.Form_Proc_Error check_error = new COM.Com_Form.Form_Proc_Error(true, today, proc_name, ClassLib.ComVar.CxErrorCheck_Error);
						check_error.ShowDialog();
						_ReleaseYN = false;

						_Thread_Run_Flag = false;
						return;
					} 
						// 두번째 오류 체크 필요
					else if(Convert.ToInt32(error_count) == 0)
					{
						error_count = "";  
						//error_count = Check_Error("2");

						proc_name = "PKG_SPD_CHECK_BSC.CHECK_AFTER_WORKSHEET";
						error_count = Check_Error(factory, proc_name);

						//오류 발생
						if(Convert.ToInt32(error_count) > 0)
						{
							
							this.Cursor = Cursors.Default; 

							//proc_name = "PKG_SPD_CHECK_BSC.CHECK_AFTER_WORKSHEET";
							COM.Com_Form.Form_Proc_Error check_error = new COM.Com_Form.Form_Proc_Error(true, today, proc_name, ClassLib.ComVar.CxErrorCheck_Error);
							check_error.ShowDialog();
							_ReleaseYN = false;

							_Thread_Run_Flag = false;
							return;
						}
							//작업지시 정상 발부
						else if(Convert.ToInt32(error_count) == 0)
						{ 
							
						 	 
							//next work day 추출
							dt_ret = Select_NEXTWORKDAY(factory);
							txt_StatusDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
							txt_Status.Text = dt_ret.Rows[0].ItemArray[1].ToString();
							txt_NextWorkDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString()); 

							_MaxReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
							_MaxReleasedStatus = dt_ret.Rows[0].ItemArray[1].ToString();
							_NextReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString());  


							dpick_ConfirmYMD.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString()); 

							//
							//						//-----------------------------------------------------------------------------------------------
							//						// 데이터 조회
							//						//-----------------------------------------------------------------------------------------------
							//						confirm_ymd = dpick_ConfirmYMD.Value.ToString("yyyyMMdd");
							//						DataSet ds_ret = Select_SPD_DAILY_WORKSHEET(factory, confirm_ymd);
							//
							//						DataTable dt_ret_release = ds_ret.Tables[0];
							//						Display_Data(dt_ret_release, fgrid_Release);
							//						Set_Finish_Check();
							//
							//						DataTable dt_ret_release_def = ds_ret.Tables[1];
							//						Display_Data(dt_ret_release_def, fgrid_ReleaseDef);
							//						//-----------------------------------------------------------------------------------------------



							
							//release, cancel button status setting
							btn_Release.Enabled = false; 

							btn_PCard.ImageIndex = 1;
							Event_Click_btn_PCard();

							_ReleaseYN = true;

							_Thread_Run_Flag = true;

						} // end //작업지시 정상 발부
					} // end // 두번째 오류 체크 필요
				} // end // 첫번째 오류 체크

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Release", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
			finally 
			{ 
				//_PopForm.Close(); 
				this.Cursor = Cursors.Default;   
			} 




		}



		/// <summary>
		/// Event_Click_btn_PCard : 
		/// </summary>
		private void Event_Click_btn_PCard()
		{

			DataTable dt_ret;
			string error_count = "";
 
			if(cmb_Factory.SelectedIndex == -1) return; 

 
			//--------------------------------------------------------
			// 2006_01_09 수정
			// VJ : Passcard 버튼 작업 처리 안함
			// QD : 버튼 처리 함
			if(cmb_Factory.SelectedValue.ToString() == "VJ" || cmb_Factory.SelectedValue.ToString() == "JJ") 
			{
				_Thread_Run_Flag = true;
				return; 
			}

			//--------------------------------------------------------


			
			this.Cursor = Cursors.WaitCursor;  

			string factory = cmb_Factory.SelectedValue.ToString();
			string confirm_ymd = dpick_ConfirmYMD.Value.ToString("yyyyMMdd");



			error_count = Run_SP_SPD_PCARD_TOT_RUN(factory, confirm_ymd);


			if(Convert.ToInt32(error_count) == 0)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this); 
				this.Cursor = Cursors.Default;  

				btn_PCard.ImageIndex = 0;
				btn_PCard.Enabled = false;


//				//next work day 추출
//				dt_ret = Select_NEXTWORKDAY(factory);
//				txt_StatusDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
//				txt_Status.Text = dt_ret.Rows[0].ItemArray[1].ToString();
//				txt_NextWorkDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString()); 
//
//				_MaxReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
//				_MaxReleasedStatus = dt_ret.Rows[0].ItemArray[1].ToString();
//				_NextReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString()); 
//
//
//				dpick_ConfirmYMD.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString()); 
//
//
//				//-----------------------------------------------------------------------------------------------
//				// 데이터 조회
//				//-----------------------------------------------------------------------------------------------
//				confirm_ymd = dpick_ConfirmYMD.Value.ToString("yyyyMMdd"); 
//				DataSet ds_ret = Select_SPD_DAILY_WORKSHEET(factory, confirm_ymd);
//
//				DataTable dt_ret_release = ds_ret.Tables[0];
//				Display_Data(dt_ret_release, fgrid_Release);
//				Set_Finish_Check();
//
//				DataTable dt_ret_release_def = ds_ret.Tables[1];
//				Display_Data(dt_ret_release_def, fgrid_ReleaseDef);
//				//-----------------------------------------------------------------------------------------------
 

				_PCardYN = true;
				_Thread_Run_Flag = true;
 

				
			}
				// 에러 발생 경우
			else
			{
				// 에러창 표시
					
				confirm_ymd = dpick_ConfirmYMD.Value.ToString("yyyyMMdd");

				Pop_ReleasePCard_Error pop_form = new Pop_ReleasePCard_Error(confirm_ymd);  
				pop_form.ShowDialog();

				btn_PCard.ImageIndex = 0;
				_PCardYN = false;

				_Thread_Run_Flag = false;
				return;

			}

			


		}



		/// <summary>
		/// Event_Click_btn_Cancel : 
		/// </summary>
		private void Event_Click_btn_Cancel()
		{
 
 
			if(cmb_Factory.SelectedIndex == -1 || txt_StatusDay.Text == "") return;

			string factory = cmb_Factory.SelectedValue.ToString();
			string status_day = MyComFunction.ConvertDate2DbType(txt_StatusDay.Text);
			string status = txt_Status.Text;


			Pop_ReleaseCancel pop_form = new Pop_ReleaseCancel(factory, status_day, status); 
			COM.ComVar.Parameter_PopUp = new string[] {};
			pop_form.ShowDialog();


			if(! pop_form._Close_Save) return;


            //System.Threading.Thread thread_run = new System.Threading.Thread(new System.Threading.ThreadStart(Event_Click_btn_Cancel_Run));
            //thread_run.Start();

            //_PopForm = new FlexAPS.ProdBase.Pop_ProcessWait();
            //_PopForm.Processing();
            //_PopForm.Start(); 
 

            //// thread 종료 후 재 조회
            //thread_run.Abort(); 

            //if(_Thread_Run_Flag)
            //{
            //    Event_Tbtn_Search();
            //}


            Event_Click_btn_Cancel_Run();

            Event_Tbtn_Search();



		}



		/// <summary>
		/// Event_Click_btn_Cancel_Run : thread 내부 실행 메서드
		/// </summary>
		private void Event_Click_btn_Cancel_Run()
		{


			try
			{

 
				string factory = cmb_Factory.SelectedValue.ToString();
				string status_day = MyComFunction.ConvertDate2DbType(txt_StatusDay.Text); 



				// 작업지시 취소
				bool save_flag = FlexAPS.ProdSheet.Pop_ReleaseCancel.Run_SP_SPD_Cancel_Daily_WorkSheet(factory, status_day); 

				if(!save_flag) 
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this); 

					_Thread_Run_Flag = false; 
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this); 

					_Thread_Run_Flag = true;
				}


				//next work day 추출
				DataTable dt_ret = Select_NEXTWORKDAY(factory);
				txt_StatusDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
				txt_Status.Text = dt_ret.Rows[0].ItemArray[1].ToString();
				txt_NextWorkDay.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString()); 

				_MaxReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString());
				_MaxReleasedStatus = dt_ret.Rows[0].ItemArray[1].ToString();
				_NextReleasedDate = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[2].ToString()); 
 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
			finally 
			{ 
				//_PopForm.Close(); 
				this.Cursor = Cursors.Default;   
			} 


		}





		/// <summary>
		/// Event_Click_btn_WorkArea : 
		/// </summary>
		private void Event_Click_btn_WorkArea()
		{

			if(cmb_Factory.SelectedIndex == -1) return;


			DataTable dt_ret;
 
			string division = "";
			string factory = cmb_Factory.SelectedValue.ToString();
			string confirm_ymd = dpick_ConfirmYMD.Value.ToString("yyyyMMdd");
			string next_work_ymd = MyComFunction.ConvertDate2DbType(txt_NextWorkDay.Text);


			if(obar_Main.SelectedPage.Name.Equals("obarpg_Release") )
			{
				division = "1";
			}
			else if(obar_Main.SelectedPage.Name.Equals("obarpg_ReleaseDef") )
			{
				division = "2";
			}

			 

			
			Form_PD_LOTDaily_Out pop_form = new Form_PD_LOTDaily_Out(division, factory, confirm_ymd, next_work_ymd); 
			pop_form.WindowState = System.Windows.Forms.FormWindowState.Normal; 
			pop_form.ShowDialog(); 



			lbl_Stit1.Text = "";
			lbl_Stit2.Text = "";
			lbl_NOS.Text = "";
				
			//SPD_LOT_DAILY_OPSIZE  -> stit1, stit2, nos qty.
			dt_ret = Select_OPSIZE_AREA_QTY(factory, confirm_ymd);
			//column 0: div, 1: mat_area, 2: size_qty
			//row 0: stit1, 1: stit2, 2: NOS  

			if(dt_ret.Rows.Count == 1)
			{
				lbl_Stit1.Text = dt_ret.Rows[0].ItemArray[2].ToString();
				lbl_Stit2.Text = "0";
				lbl_NOS.Text = "0";
			}
			else if(dt_ret.Rows.Count == 2)
			{
				lbl_Stit1.Text = dt_ret.Rows[0].ItemArray[2].ToString();
				lbl_Stit2.Text = "0";
				lbl_NOS.Text = dt_ret.Rows[1].ItemArray[2].ToString();  
			}
			else if(dt_ret.Rows.Count == 3)
			{
				lbl_Stit1.Text = dt_ret.Rows[0].ItemArray[2].ToString();
				lbl_Stit2.Text = dt_ret.Rows[1].ItemArray[2].ToString();
				lbl_NOS.Text = dt_ret.Rows[2].ItemArray[2].ToString(); 

			}

			 


		}



		#endregion

		#region 컨텍스트 메뉴 이벤트 메서드
 
 

		#endregion
 

		#endregion   
		
		#region 이벤트 처리

		#region 툴바 이벤트
 

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

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				Event_Tbtn_Print(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		#endregion

		#region 그리드 이벤트

 
		private void fgrid_Release_Click(object sender, System.EventArgs e)
		{
			 

			try
			{

				if(fgrid_Release.Rows.Count <= fgrid_Release.Rows.Fixed) return; 
			
			
	
				int findrow = 0;  
				int sel_row = fgrid_Release.Selection.r1; 
			

				if(fgrid_Release[sel_row, (int)ClassLib.TBSPD_RELEASE_BSC.IxLOT] == null) return;


				//------------------------------------------------
				//선택한 젠더행 색깔 표시
				string sel_gen = fgrid_Release[sel_row, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN].ToString();

				findrow = fgrid_Release.FindRow(sel_gen, 2, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN, false, true, false);

				if(findrow == -1) return;

				fgrid_Release.GetCellRange(findrow, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN, findrow, fgrid_Release.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow; 
				fgrid_Release.GetCellRange(findrow, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN, findrow, fgrid_Release.Cols.Count - 1).StyleNew.ForeColor = Color.Black;

				if(_BeforeGenRow != -1 && _BeforeGenRow != findrow) 
					fgrid_Release.GetCellRange(_BeforeGenRow, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN, _BeforeGenRow, fgrid_Release.Cols.Count - 1).StyleNew.Clear(); 

				_BeforeGenRow = findrow; 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Release_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		private void fgrid_ReleaseDef_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				if(fgrid_ReleaseDef.Rows.Count <= fgrid_ReleaseDef.Rows.Fixed) return; 


				int findrow = 0; 
				int sel_row = fgrid_ReleaseDef.Selection.r1; 

				if(fgrid_ReleaseDef[sel_row, (int)ClassLib.TBSPD_RELEASE_BSC.IxLOT] == null) return;
			
				//------------------------------------------------
				//선택한 젠더행 색깔 표시
				string sel_gen = fgrid_ReleaseDef[sel_row, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN].ToString();

				findrow = fgrid_ReleaseDef.FindRow(sel_gen, 2, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN, false, true, false);

				if(findrow == -1) return;

				fgrid_ReleaseDef.GetCellRange(findrow, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN, findrow, fgrid_ReleaseDef.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow; 
				fgrid_ReleaseDef.GetCellRange(findrow, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN, findrow, fgrid_ReleaseDef.Cols.Count - 1).StyleNew.ForeColor = Color.Black;

				if(_BeforeGenRow1 != -1 && _BeforeGenRow1 != findrow) 
					fgrid_ReleaseDef.GetCellRange(_BeforeGenRow1, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN, _BeforeGenRow1, fgrid_ReleaseDef.Cols.Count - 1).StyleNew.Clear(); 

				_BeforeGenRow1 = findrow; 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_ReleaseDef_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		 
		}

		private void fgrid_Release_DoubleClick(object sender, System.EventArgs e)
		{
			
			try
			{
				
				this.Cursor = Cursors.WaitCursor;


				if(fgrid_Release.Rows.Count <= fgrid_Release.Rows.Fixed) return;
				if(cmb_Factory.SelectedIndex == -1) return;

				if(fgrid_Release[fgrid_Release.Selection.r1, (int)ClassLib.TBSPD_RELEASE_BSC.IxLOT] == null) return;


				string factory = cmb_Factory.SelectedValue.ToString();
				
				string line_cd = fgrid_Release[fgrid_Release.Selection.r1, (int)ClassLib.TBSPD_RELEASE_BSC.IxLINE_NAME].ToString()
					+ " (" + fgrid_Release[fgrid_Release.Selection.r1, (int)ClassLib.TBSPD_RELEASE_BSC.IxLINE_CD].ToString() + ")"; 

				string model_name = fgrid_Release[fgrid_Release.Selection.r1, (int)ClassLib.TBSPD_RELEASE_BSC.IxMODEL_NAME].ToString();
				string style_cd = fgrid_Release[fgrid_Release.Selection.r1, (int)ClassLib.TBSPD_RELEASE_BSC.IxSTYLE_CD].ToString();
				string gen = fgrid_Release[fgrid_Release.Selection.r1, (int)ClassLib.TBSPD_RELEASE_BSC.IxGEN].ToString();
				string obs_id = fgrid_Release[fgrid_Release.Selection.r1, (int)ClassLib.TBSPD_RELEASE_BSC.IxOBS_ID].ToString();
				string obs_type = fgrid_Release[fgrid_Release.Selection.r1, (int)ClassLib.TBSPD_RELEASE_BSC.IxOBS_TYPE].ToString();
				string lot = fgrid_Release[fgrid_Release.Selection.r1, (int)ClassLib.TBSPD_RELEASE_BSC.IxLOT].ToString();
				string req_no = fgrid_Release[fgrid_Release.Selection.r1, (int)ClassLib.TBSPD_RELEASE_BSC.IxREQ_NO].ToString();
				string plan_ymd = fgrid_Release[fgrid_Release.Selection.r1, (int)ClassLib.TBSPD_RELEASE_BSC.IxDESC2].ToString();  // plan_ymd
																																  

				Pop_ReleaseSize pop_form = new Pop_ReleaseSize(factory, line_cd, model_name, style_cd, gen, obs_id, obs_type, lot, req_no, plan_ymd);   
				pop_form.WindowState = System.Windows.Forms.FormWindowState.Normal; 
				pop_form.ShowDialog(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Release_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
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

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_SelectedValueChanged_cmb_Factory();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_Factory", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		} 

		private void dpick_ConfirmYMD_CloseUp(object sender, System.EventArgs e)
		{
			try
			{
				Event_CloseUp_dpick_ConfirmYMD();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_CloseUp_dpick_ConfirmYMD", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		}  

		private void btn_Release_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_btn_Release();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Release", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  


		}

		private void btn_PCard_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_btn_PCard();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_PCard", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_btn_Cancel();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}

		private void btn_WorkArea_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_btn_WorkArea();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_WorkArea", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}


		#endregion  

		#region 컨텍스트 메뉴 이벤트

  

		#endregion


		#endregion
		 
		#region 디비 연결


		#region 조회

		/// <summary>
		/// Select_NEXTWORKDAY : SPD_WORKSHEET 에서 NEXT WORK DAY 추출
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <returns></returns> 
		private DataTable Select_NEXTWORKDAY(string arg_factory)
		{
			
			try
			{
				 
				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.SELECT_NEXTWORKDAY";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = "";

				MyOraDB.Add_Select_Parameter(true); 
				DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				return null; 
			}
		}

 

		/// <summary>
		/// Select_OPSIZE_MAX_ASY_DATE : SPD_LOT_DAILY_OPSIZE  -> Max Asy. Date 추출 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_dir_req_ymd"></param>
		/// <returns></returns>
		private DataTable Select_OPSIZE_MAX_ASY_DATE(string arg_factory, string arg_dir_req_ymd)
		{
			DataSet ds_ret; 

			try
			{
				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.SELECT_MAX_ASY_DATE_OPSIZE";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DIR_REQ_YMD";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_dir_req_ymd;
				MyOraDB.Parameter_Values[2] = "";

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				return null; 
			}
		}


		/// <summary>
		/// Select_OPSIZE_AREA_QTY : SPD_LOT_DAILY_OPSIZE  -> stit1, stit2, nos qty.
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_dir_req_ymd"></param>
		/// <returns></returns>
		private DataTable Select_OPSIZE_AREA_QTY(string arg_factory, string arg_dir_req_ymd)
		{
			DataSet ds_ret; 

			try
			{
				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.SELECT_AREA_QTY_OPSIZE";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DIR_REQ_YMD";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_dir_req_ymd;
				MyOraDB.Parameter_Values[2] = "";

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				return null; 
			}
		}
		 

		 

		/// <summary>
		/// Select_SPD_DAILY_WORKSHEET : 작업지시 데이터 조회
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_dir_req_ymd"></param>
		/// <returns></returns>
		private DataSet Select_SPD_DAILY_WORKSHEET(string arg_factory, string arg_dir_req_ymd)
		{
			
			try
			{
				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.SELECT_SPD_DAILY_WORKSHEET";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DIR_REQ_YMD";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_dir_req_ymd;
				MyOraDB.Parameter_Values[2] = "";

				MyOraDB.Add_Select_Parameter(true);  



				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.SELECT_SPD_DAILY_WORKSHEET_DEF";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DIR_REQ_YMD";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_dir_req_ymd;
				MyOraDB.Parameter_Values[2] = "";

				MyOraDB.Add_Select_Parameter(false);  


				DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;  
				return ds_ret;

			}
			catch
			{
				return null; 
			}
		}



		#endregion      

		#region 저장
 


		/// <summary>
		/// CHECK_BEFORE_RELEASED_PASSCARD : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_confirm_ymd"></param>
		/// <returns></returns>
		private DataTable CHECK_BEFORE_RELEASED_PASSCARD(string arg_factory, string arg_confirm_ymd) 
		{

			try
			{
				
				COM.OraDB LMyOraDB = new COM.OraDB();
				DataSet ds_ret; 


				LMyOraDB.ReDim_Parameter(3); 

				LMyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.CHECK_BEFORE_RELEASED_PASSCARD";

				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				LMyOraDB.Parameter_Name[1] = "ARG_DIR_REQ_YMD";
				LMyOraDB.Parameter_Name[2] = "OUT_CURSOR";  

				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			
				LMyOraDB.Parameter_Values[0] = arg_factory; 
				LMyOraDB.Parameter_Values[1] = arg_confirm_ymd;  
				LMyOraDB.Parameter_Values[2] = "";

				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[LMyOraDB.Process_Name]; 
			}
			catch
			{
				return null; 
			}


		}



		/// <summary>
		/// CHECK_BEFORE_RELEASED_ALL_QTY : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_confirm_ymd"></param>
		/// <returns></returns>
		private DataTable CHECK_BEFORE_RELEASED_ALL_QTY(string arg_factory, string arg_confirm_ymd) 
		{

			try
			{
				
				COM.OraDB LMyOraDB = new COM.OraDB();
				DataSet ds_ret; 


				LMyOraDB.ReDim_Parameter(3); 

				LMyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.CHECK_BEFORE_RELEASED_ALL_QTY";

				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				LMyOraDB.Parameter_Name[1] = "ARG_DIR_REQ_YMD";
				LMyOraDB.Parameter_Name[2] = "OUT_CURSOR";  

				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			
				LMyOraDB.Parameter_Values[0] = arg_factory; 
				LMyOraDB.Parameter_Values[1] = arg_confirm_ymd;  
				LMyOraDB.Parameter_Values[2] = "";

				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[LMyOraDB.Process_Name]; 
			}
			catch
			{
				return null; 
			}


		}


		/// <summary>
		/// CHECK_BEFORE_RELEASED_MINILINE_AREA : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_confirm_ymd"></param>
		/// <returns></returns>
		private DataTable CHECK_BEFORE_RELEASED_MINILINE_AREA(string arg_factory, string arg_confirm_ymd) 
		{

			try
			{
				
				COM.OraDB LMyOraDB = new COM.OraDB();
				DataSet ds_ret; 


				LMyOraDB.ReDim_Parameter(3); 

				LMyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.CHECK_BEFORE_RELEASED_AREA";

				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				LMyOraDB.Parameter_Name[1] = "ARG_DIR_REQ_YMD";
				LMyOraDB.Parameter_Name[2] = "OUT_CURSOR";  

				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			
				LMyOraDB.Parameter_Values[0] = arg_factory; 
				LMyOraDB.Parameter_Values[1] = arg_confirm_ymd;  
				LMyOraDB.Parameter_Values[2] = "";

				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[LMyOraDB.Process_Name]; 
			}
			catch
			{
				return null; 
			}


		}



		/// <summary>
		/// Run_SP_SPD_Assign_Daily_WorkSheet : 작지 일자 기준으로 작업지시(공정라인별,세부라인 시긴대별) 발부 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_confirm_ymd"></param>
		/// <returns></returns>
		private bool Run_SP_SPD_Assign_Daily_WorkSheet(string arg_factory, string arg_confirm_ymd) 
		{  
			DataSet ds_ret;

			try
			{
				MyOraDB.ReDim_Parameter(3);  

				MyOraDB.Process_Name = "SP_SPD_Assign_Daily_WorkSheet";  
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_DIR_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";  
  
				for (int i = 0; i < 3; i++) MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_confirm_ymd; 
				MyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User; 

				MyOraDB.Add_Run_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Run_Procedure();	 
			 
				if(ds_ret == null)  
					return false; 
				else
					return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Run_SP_SPD_Assign_Daily_WorkSheet",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			} 
		}



		/// <summary>
		/// Run_SP_SPD_PCARD_TOT_RUN : 작업지시 완료 후 패스카드 실행
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_confirm_ymd"></param>
		/// <returns></returns>
		private string Run_SP_SPD_PCARD_TOT_RUN(string arg_factory, string arg_confirm_ymd) 
		{  
			DataSet ds_ret; 
			
			try
			{
				MyOraDB.ReDim_Parameter(4);  

				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.RUN_SP_SPD_PCARD_TOT_RUN";  
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_REQ_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_confirm_ymd;  
				MyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;  
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(true);  
				ds_ret = MyOraDB.Exe_Select_Procedure();	 
			 
				if(ds_ret == null) return null ; 
				return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString();

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Run_SP_SPD_PCARD_TOT_RUN",MessageBoxButtons.OK,MessageBoxIcon.Error) ; 
				return null;
			} 
		}



		/// <summary>
		/// Check_Error : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_procname"></param>
		/// <returns></returns>
		public static string Check_Error(string arg_factory, string arg_procname)
		{

			try
			{
				
				COM.OraDB LMyOraDB = new COM.OraDB();
				DataSet ds_ret; 


				LMyOraDB.ReDim_Parameter(4); 

				LMyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.CHECK_ERROR_COUNT";

				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				LMyOraDB.Parameter_Name[1] = "ARG_PROC_NAME"; 
				LMyOraDB.Parameter_Name[2] = "ARG_UPD_USER";
				LMyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			
				LMyOraDB.Parameter_Values[0] = arg_factory; 
				LMyOraDB.Parameter_Values[1] = arg_procname; 
				LMyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;  
				LMyOraDB.Parameter_Values[3] = "";

				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[LMyOraDB.Process_Name].Rows[0].ItemArray[0].ToString(); 
			}
			catch
			{
				return null; 
			}
		 
		}




		#endregion  
 

		#endregion



 

	}
}

