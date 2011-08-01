using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using Microsoft.VisualC; 
using System.Data;
using System.Data.OracleClient;
using NETRONIC.XGantt;


namespace FlexAPS.ProdPlan
{
	public class Form_PO_LOTDaily : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.Panel pnl_Body;
		public C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1Command.C1ContextMenu cmenu_diagram;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private C1.Win.C1Command.C1ContextMenu cmenu_table;
		private C1.Win.C1Command.C1CommandLink c1CommandLink17;
		private C1.Win.C1Command.C1Command menuitem_LOTInfo;
		private C1.Win.C1Command.C1CommandLink c1CommandLink10;
		private C1.Win.C1Command.C1CommandMenu menuitem_MoveLine;
		private C1.Win.C1Command.C1Command menuitem_AllMove;
		private C1.Win.C1Command.C1CommandLink c1CommandLink19;
		private C1.Win.C1Command.C1CommandLink c1CommandLink20;
		private C1.Win.C1Command.C1Command menuitem_DisplaySize;
		private C1.Win.C1Command.C1CommandLink c1CommandLink21;
		private C1.Win.C1Command.C1Command menuitem_ChangeLOT;
		private C1.Win.C1Command.C1Command menuitem_ReqNo;
		private C1.Win.C1Command.C1CommandLink c1CommandLink9;
		private C1.Win.C1Command.C1Command menuitem_DLOT;
		private C1.Win.C1Command.C1CommandLink c1CommandLink11;
		private C1.Win.C1Command.C1Command menuitem_MLOT;
		private C1.Win.C1Command.C1CommandLink c1CommandLink12;
		private C1.Win.C1Command.C1Command menuitem_CancelLOT;
		public System.Windows.Forms.DateTimePicker dpick_FromYMD;
		public System.Windows.Forms.DateTimePicker dpick_ToYMD;
		private C1.Win.C1List.C1Combo cmb_OBSType;
		private System.Windows.Forms.Label lbl_OBSType;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_RTS;
		private System.Windows.Forms.Label lbl_NoSize;
		private System.Windows.Forms.Label lbl_DirLOT;
		private System.Windows.Forms.Label lbl_VirtualLOT;
		private System.Windows.Forms.Label lbl_RealLOT;
		private NETRONIC.XGantt.VcGantt vcGantt;
		private C1.Win.C1Command.C1CommandLink c1CommandLink13;
		private C1.Win.C1Command.C1Command menuitem_MiniLine;
		private C1.Win.C1Command.C1CommandLink c1CommandLink14;
		private C1.Win.C1Command.C1Command menuitem_TS;
		private C1.Win.C1Command.C1CommandLink c1CommandLink15;
		private C1.Win.C1Command.C1Command c1Command1;
		private System.Windows.Forms.Label btn_AssignSize;
		private C1.Win.C1Command.C1CommandLink c1CommandLink16;
		private C1.Win.C1Command.C1Command menuitem_DisplayDaySize;
		private C1.Win.C1Command.C1CommandLink c1CommandLink22;
		private C1.Win.C1Command.C1Command c1Command2;
		private C1.Win.C1Command.C1CommandLink c1CommandLink23;
		private C1.Win.C1Command.C1Command menuitem_LOTSize;
		private C1.Win.C1Command.C1CommandLink c1CommandLink24;
		private C1.Win.C1Command.C1Command menuitem_MoveLOT;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_Line;
		private C1.Win.C1List.C1Combo cmb_LineTo;
		private C1.Win.C1List.C1Combo cmb_LineFrom;
		private System.Windows.Forms.CheckBox chk_OnlyVLot;
		private C1.Win.C1Command.C1CommandLink c1CommandLink25;
		private C1.Win.C1Command.C1Command c1Command3;
		private C1.Win.C1Command.C1CommandLink c1CommandLink26;
		private C1.Win.C1Command.C1Command menuitem_LOTForecast;
		private C1.Win.C1Command.C1CommandLink c1CommandLink18;
		private C1.Win.C1Command.C1Command menuitem_LastInv;
		private C1.Win.C1Command.C1CommandLink c1CommandLink27;
		private C1.Win.C1Command.C1Command menuitem_DelayProduction;
		private C1.Win.C1Command.C1CommandLink c1CommandLink28;
		private C1.Win.C1Command.C1Command c1Command4;
		private C1.Win.C1Command.C1CommandLink c1CommandLink29;
		private C1.Win.C1Command.C1Command menuitem_OAClosing;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자

		public Form_PO_LOTDaily()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PO_LOTDaily));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.btn_AssignSize = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_RTS = new System.Windows.Forms.Label();
            this.lbl_NoSize = new System.Windows.Forms.Label();
            this.lbl_DirLOT = new System.Windows.Forms.Label();
            this.lbl_VirtualLOT = new System.Windows.Forms.Label();
            this.lbl_RealLOT = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.chk_OnlyVLot = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_LineTo = new C1.Win.C1List.C1Combo();
            this.cmb_LineFrom = new C1.Win.C1List.C1Combo();
            this.lbl_Line = new System.Windows.Forms.Label();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.cmb_OBSType = new C1.Win.C1List.C1Combo();
            this.lbl_OBSType = new System.Windows.Forms.Label();
            this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
            this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PlanYMD = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
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
            this.vcGantt = new NETRONIC.XGantt.VcGantt();
            this.cmenu_diagram = new C1.Win.C1Command.C1ContextMenu();
            this.c1CommandLink24 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_MoveLOT = new C1.Win.C1Command.C1Command();
            this.c1CommandLink9 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_DLOT = new C1.Win.C1Command.C1Command();
            this.c1CommandLink11 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_MLOT = new C1.Win.C1Command.C1Command();
            this.c1CommandLink22 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command2 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink16 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_DisplayDaySize = new C1.Win.C1Command.C1Command();
            this.c1CommandLink28 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command4 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink29 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_OAClosing = new C1.Win.C1Command.C1Command();
            this.cmenu_table = new C1.Win.C1Command.C1ContextMenu();
            this.c1CommandLink17 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_LOTInfo = new C1.Win.C1Command.C1Command();
            this.c1CommandLink10 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_MoveLine = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink19 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_ReqNo = new C1.Win.C1Command.C1Command();
            this.c1CommandLink21 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_ChangeLOT = new C1.Win.C1Command.C1Command();
            this.c1CommandLink12 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_CancelLOT = new C1.Win.C1Command.C1Command();
            this.c1CommandLink23 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_LOTSize = new C1.Win.C1Command.C1Command();
            this.c1CommandLink27 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_DelayProduction = new C1.Win.C1Command.C1Command();
            this.c1CommandLink15 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command1 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink18 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_LastInv = new C1.Win.C1Command.C1Command();
            this.c1CommandLink20 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_DisplaySize = new C1.Win.C1Command.C1Command();
            this.c1CommandLink13 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_MiniLine = new C1.Win.C1Command.C1Command();
            this.c1CommandLink14 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_TS = new C1.Win.C1Command.C1Command();
            this.c1CommandLink25 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command3 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink26 = new C1.Win.C1Command.C1CommandLink();
            this.menuitem_LOTForecast = new C1.Win.C1Command.C1Command();
            this.menuitem_AllMove = new C1.Win.C1Command.C1Command();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LineTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LineFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            this.pnl_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Menu
            // 
            this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
            this.img_Menu.Images.SetKeyName(0, "");
            this.img_Menu.Images.SetKeyName(1, "");
            this.img_Menu.Images.SetKeyName(2, "");
            this.img_Menu.Images.SetKeyName(3, "");
            this.img_Menu.Images.SetKeyName(4, "");
            this.img_Menu.Images.SetKeyName(5, "");
            this.img_Menu.Images.SetKeyName(6, "");
            this.img_Menu.Images.SetKeyName(7, "");
            this.img_Menu.Images.SetKeyName(8, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink8,
            this.c1CommandLink7});
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.tbtn_New);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Search);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Save);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Append);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Insert);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Delete);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Create);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Color);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Print);
            this.c1CommandHolder1.Commands.Add(this.cmenu_diagram);
            this.c1CommandHolder1.Commands.Add(this.menuitem_MoveLOT);
            this.c1CommandHolder1.Commands.Add(this.menuitem_DLOT);
            this.c1CommandHolder1.Commands.Add(this.menuitem_MLOT);
            this.c1CommandHolder1.Commands.Add(this.c1Command2);
            this.c1CommandHolder1.Commands.Add(this.menuitem_DisplayDaySize);
            this.c1CommandHolder1.Commands.Add(this.cmenu_table);
            this.c1CommandHolder1.Commands.Add(this.menuitem_LOTInfo);
            this.c1CommandHolder1.Commands.Add(this.menuitem_MoveLine);
            this.c1CommandHolder1.Commands.Add(this.menuitem_AllMove);
            this.c1CommandHolder1.Commands.Add(this.menuitem_ReqNo);
            this.c1CommandHolder1.Commands.Add(this.menuitem_ChangeLOT);
            this.c1CommandHolder1.Commands.Add(this.menuitem_CancelLOT);
            this.c1CommandHolder1.Commands.Add(this.menuitem_LOTSize);
            this.c1CommandHolder1.Commands.Add(this.c1Command1);
            this.c1CommandHolder1.Commands.Add(this.menuitem_DisplaySize);
            this.c1CommandHolder1.Commands.Add(this.menuitem_MiniLine);
            this.c1CommandHolder1.Commands.Add(this.menuitem_TS);
            this.c1CommandHolder1.Commands.Add(this.c1Command3);
            this.c1CommandHolder1.Commands.Add(this.menuitem_LOTForecast);
            this.c1CommandHolder1.Commands.Add(this.menuitem_LastInv);
            this.c1CommandHolder1.Commands.Add(this.menuitem_DelayProduction);
            this.c1CommandHolder1.Commands.Add(this.c1Command4);
            this.c1CommandHolder1.Commands.Add(this.menuitem_OAClosing);
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
            // 
            // pnl_Search
            // 
            this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.btn_AssignSize);
            this.pnl_Search.Controls.Add(this.groupBox1);
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Location = new System.Drawing.Point(0, 64);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(1016, 100);
            this.pnl_Search.TabIndex = 35;
            // 
            // btn_AssignSize
            // 
            this.btn_AssignSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AssignSize.ImageIndex = 0;
            this.btn_AssignSize.ImageList = this.img_Button;
            this.btn_AssignSize.Location = new System.Drawing.Point(529, 2);
            this.btn_AssignSize.Name = "btn_AssignSize";
            this.btn_AssignSize.Size = new System.Drawing.Size(80, 23);
            this.btn_AssignSize.TabIndex = 198;
            this.btn_AssignSize.Text = "Deploy Size";
            this.btn_AssignSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AssignSize.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_AssignSize.Click += new System.EventHandler(this.btn_AssignSize_Click);
            this.btn_AssignSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_AssignSize.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_AssignSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbl_RTS);
            this.groupBox1.Controls.Add(this.lbl_NoSize);
            this.groupBox1.Controls.Add(this.lbl_DirLOT);
            this.groupBox1.Controls.Add(this.lbl_VirtualLOT);
            this.groupBox1.Controls.Add(this.lbl_RealLOT);
            this.groupBox1.Location = new System.Drawing.Point(616, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 32);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // lbl_RTS
            // 
            this.lbl_RTS.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_RTS.Image = ((System.Drawing.Image)(resources.GetObject("lbl_RTS.Image")));
            this.lbl_RTS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_RTS.Location = new System.Drawing.Point(308, 11);
            this.lbl_RTS.Name = "lbl_RTS";
            this.lbl_RTS.Size = new System.Drawing.Size(75, 15);
            this.lbl_RTS.TabIndex = 77;
            this.lbl_RTS.Text = "   RGAC";
            this.lbl_RTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NoSize
            // 
            this.lbl_NoSize.BackColor = System.Drawing.Color.White;
            this.lbl_NoSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_NoSize.Location = new System.Drawing.Point(233, 11);
            this.lbl_NoSize.Name = "lbl_NoSize";
            this.lbl_NoSize.Size = new System.Drawing.Size(75, 15);
            this.lbl_NoSize.TabIndex = 76;
            this.lbl_NoSize.Text = "No Size";
            this.lbl_NoSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DirLOT
            // 
            this.lbl_DirLOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.lbl_DirLOT.Location = new System.Drawing.Point(8, 11);
            this.lbl_DirLOT.Name = "lbl_DirLOT";
            this.lbl_DirLOT.Size = new System.Drawing.Size(75, 15);
            this.lbl_DirLOT.TabIndex = 75;
            this.lbl_DirLOT.Text = "Released";
            this.lbl_DirLOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_VirtualLOT
            // 
            this.lbl_VirtualLOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(166)))));
            this.lbl_VirtualLOT.Location = new System.Drawing.Point(83, 11);
            this.lbl_VirtualLOT.Name = "lbl_VirtualLOT";
            this.lbl_VirtualLOT.Size = new System.Drawing.Size(75, 15);
            this.lbl_VirtualLOT.TabIndex = 74;
            this.lbl_VirtualLOT.Text = "Finished";
            this.lbl_VirtualLOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RealLOT
            // 
            this.lbl_RealLOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lbl_RealLOT.Location = new System.Drawing.Point(158, 11);
            this.lbl_RealLOT.Name = "lbl_RealLOT";
            this.lbl_RealLOT.Size = new System.Drawing.Size(75, 15);
            this.lbl_RealLOT.TabIndex = 73;
            this.lbl_RealLOT.Text = "Planning";
            this.lbl_RealLOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.chk_OnlyVLot);
            this.pnl_SearchImage.Controls.Add(this.label3);
            this.pnl_SearchImage.Controls.Add(this.cmb_LineTo);
            this.pnl_SearchImage.Controls.Add(this.cmb_LineFrom);
            this.pnl_SearchImage.Controls.Add(this.lbl_Line);
            this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
            this.pnl_SearchImage.Controls.Add(this.lbl_Style);
            this.pnl_SearchImage.Controls.Add(this.cmb_OBSType);
            this.pnl_SearchImage.Controls.Add(this.lbl_OBSType);
            this.pnl_SearchImage.Controls.Add(this.dpick_ToYMD);
            this.pnl_SearchImage.Controls.Add(this.dpick_FromYMD);
            this.pnl_SearchImage.Controls.Add(this.label1);
            this.pnl_SearchImage.Controls.Add(this.lbl_PlanYMD);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
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
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 84);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // chk_OnlyVLot
            // 
            this.chk_OnlyVLot.Location = new System.Drawing.Point(552, 63);
            this.chk_OnlyVLot.Name = "chk_OnlyVLot";
            this.chk_OnlyVLot.Size = new System.Drawing.Size(176, 16);
            this.chk_OnlyVLot.TabIndex = 205;
            this.chk_OnlyVLot.Text = "Display Virtual LOT Only";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(425, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 204;
            this.label3.Text = "~";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_LineTo
            // 
            this.cmb_LineTo.AddItemSeparator = ';';
            this.cmb_LineTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LineTo.Caption = "";
            this.cmb_LineTo.CaptionHeight = 17;
            this.cmb_LineTo.CaptionStyle = style1;
            this.cmb_LineTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LineTo.ColumnCaptionHeight = 18;
            this.cmb_LineTo.ColumnFooterHeight = 18;
            this.cmb_LineTo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LineTo.ContentHeight = 17;
            this.cmb_LineTo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LineTo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LineTo.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LineTo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LineTo.EditorHeight = 17;
            this.cmb_LineTo.EvenRowStyle = style2;
            this.cmb_LineTo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LineTo.FooterStyle = style3;
            this.cmb_LineTo.HeadingStyle = style4;
            this.cmb_LineTo.HighLightRowStyle = style5;
            this.cmb_LineTo.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_LineTo.Images"))));
            this.cmb_LineTo.ItemHeight = 15;
            this.cmb_LineTo.Location = new System.Drawing.Point(440, 58);
            this.cmb_LineTo.MatchEntryTimeout = ((long)(2000));
            this.cmb_LineTo.MaxDropDownItems = ((short)(5));
            this.cmb_LineTo.MaxLength = 32767;
            this.cmb_LineTo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LineTo.Name = "cmb_LineTo";
            this.cmb_LineTo.OddRowStyle = style6;
            this.cmb_LineTo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LineTo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LineTo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LineTo.SelectedStyle = style7;
            this.cmb_LineTo.Size = new System.Drawing.Size(100, 21);
            this.cmb_LineTo.Style = style8;
            this.cmb_LineTo.TabIndex = 203;
            this.cmb_LineTo.PropBag = resources.GetString("cmb_LineTo.PropBag");
            // 
            // cmb_LineFrom
            // 
            this.cmb_LineFrom.AddItemSeparator = ';';
            this.cmb_LineFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LineFrom.Caption = "";
            this.cmb_LineFrom.CaptionHeight = 17;
            this.cmb_LineFrom.CaptionStyle = style9;
            this.cmb_LineFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LineFrom.ColumnCaptionHeight = 18;
            this.cmb_LineFrom.ColumnFooterHeight = 18;
            this.cmb_LineFrom.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LineFrom.ContentHeight = 17;
            this.cmb_LineFrom.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LineFrom.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LineFrom.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LineFrom.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LineFrom.EditorHeight = 17;
            this.cmb_LineFrom.EvenRowStyle = style10;
            this.cmb_LineFrom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LineFrom.FooterStyle = style11;
            this.cmb_LineFrom.HeadingStyle = style12;
            this.cmb_LineFrom.HighLightRowStyle = style13;
            this.cmb_LineFrom.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_LineFrom.Images"))));
            this.cmb_LineFrom.ItemHeight = 15;
            this.cmb_LineFrom.Location = new System.Drawing.Point(325, 58);
            this.cmb_LineFrom.MatchEntryTimeout = ((long)(2000));
            this.cmb_LineFrom.MaxDropDownItems = ((short)(5));
            this.cmb_LineFrom.MaxLength = 32767;
            this.cmb_LineFrom.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LineFrom.Name = "cmb_LineFrom";
            this.cmb_LineFrom.OddRowStyle = style14;
            this.cmb_LineFrom.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LineFrom.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LineFrom.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LineFrom.SelectedStyle = style15;
            this.cmb_LineFrom.Size = new System.Drawing.Size(100, 21);
            this.cmb_LineFrom.Style = style16;
            this.cmb_LineFrom.TabIndex = 202;
            this.cmb_LineFrom.PropBag = resources.GetString("cmb_LineFrom.PropBag");
            // 
            // lbl_Line
            // 
            this.lbl_Line.ImageIndex = 0;
            this.lbl_Line.ImageList = this.img_Label;
            this.lbl_Line.Location = new System.Drawing.Point(224, 58);
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(100, 21);
            this.lbl_Line.TabIndex = 201;
            this.lbl_Line.Text = "Line";
            this.lbl_Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_StyleCd.Location = new System.Drawing.Point(653, 36);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(100, 21);
            this.txt_StyleCd.TabIndex = 200;
            // 
            // lbl_Style
            // 
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(552, 36);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 199;
            this.lbl_Style.Text = "Style";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_OBSType
            // 
            this.cmb_OBSType.AddItemSeparator = ';';
            this.cmb_OBSType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OBSType.Caption = "";
            this.cmb_OBSType.CaptionHeight = 17;
            this.cmb_OBSType.CaptionStyle = style17;
            this.cmb_OBSType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OBSType.ColumnCaptionHeight = 18;
            this.cmb_OBSType.ColumnFooterHeight = 18;
            this.cmb_OBSType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OBSType.ContentHeight = 17;
            this.cmb_OBSType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OBSType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OBSType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OBSType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OBSType.EditorHeight = 17;
            this.cmb_OBSType.EvenRowStyle = style18;
            this.cmb_OBSType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OBSType.FooterStyle = style19;
            this.cmb_OBSType.HeadingStyle = style20;
            this.cmb_OBSType.HighLightRowStyle = style21;
            this.cmb_OBSType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OBSType.Images"))));
            this.cmb_OBSType.ItemHeight = 15;
            this.cmb_OBSType.Location = new System.Drawing.Point(111, 58);
            this.cmb_OBSType.MatchEntryTimeout = ((long)(2000));
            this.cmb_OBSType.MaxDropDownItems = ((short)(5));
            this.cmb_OBSType.MaxLength = 32767;
            this.cmb_OBSType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OBSType.Name = "cmb_OBSType";
            this.cmb_OBSType.OddRowStyle = style22;
            this.cmb_OBSType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OBSType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OBSType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OBSType.SelectedStyle = style23;
            this.cmb_OBSType.Size = new System.Drawing.Size(100, 21);
            this.cmb_OBSType.Style = style24;
            this.cmb_OBSType.TabIndex = 196;
            this.cmb_OBSType.SelectedValueChanged += new System.EventHandler(this.cmb_OBSType_SelectedValueChanged);
            this.cmb_OBSType.PropBag = resources.GetString("cmb_OBSType.PropBag");
            // 
            // lbl_OBSType
            // 
            this.lbl_OBSType.ImageIndex = 0;
            this.lbl_OBSType.ImageList = this.img_Label;
            this.lbl_OBSType.Location = new System.Drawing.Point(10, 58);
            this.lbl_OBSType.Name = "lbl_OBSType";
            this.lbl_OBSType.Size = new System.Drawing.Size(100, 21);
            this.lbl_OBSType.TabIndex = 195;
            this.lbl_OBSType.Text = "Order Type";
            this.lbl_OBSType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_ToYMD
            // 
            this.dpick_ToYMD.CustomFormat = "yyyyMMdd";
            this.dpick_ToYMD.Font = new System.Drawing.Font("Verdana", 9F);
            this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ToYMD.Location = new System.Drawing.Point(440, 36);
            this.dpick_ToYMD.Name = "dpick_ToYMD";
            this.dpick_ToYMD.Size = new System.Drawing.Size(102, 22);
            this.dpick_ToYMD.TabIndex = 192;
            this.dpick_ToYMD.ValueChanged += new System.EventHandler(this.dpick_ValueChanged);
            // 
            // dpick_FromYMD
            // 
            this.dpick_FromYMD.CustomFormat = "yyyyMMdd";
            this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 9F);
            this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_FromYMD.Location = new System.Drawing.Point(325, 36);
            this.dpick_FromYMD.Name = "dpick_FromYMD";
            this.dpick_FromYMD.Size = new System.Drawing.Size(102, 22);
            this.dpick_FromYMD.TabIndex = 191;
            this.dpick_FromYMD.ValueChanged += new System.EventHandler(this.dpick_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(425, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PlanYMD
            // 
            this.lbl_PlanYMD.ImageIndex = 1;
            this.lbl_PlanYMD.ImageList = this.img_Label;
            this.lbl_PlanYMD.Location = new System.Drawing.Point(224, 36);
            this.lbl_PlanYMD.Name = "lbl_PlanYMD";
            this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
            this.lbl_PlanYMD.TabIndex = 72;
            this.lbl_PlanYMD.Text = "Assy. Date";
            this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style25;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style26;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style27;
            this.cmb_Factory.HeadingStyle = style28;
            this.cmb_Factory.HighLightRowStyle = style29;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(111, 36);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style30;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style31;
            this.cmb_Factory.Size = new System.Drawing.Size(100, 21);
            this.cmb_Factory.Style = style32;
            this.cmb_Factory.TabIndex = 34;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.ImageIndex = 1;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
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
            this.picb_MR.Location = new System.Drawing.Point(983, 24);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(17, 44);
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
            this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.picb_BR.Location = new System.Drawing.Point(984, 69);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 68);
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
            this.picb_BL.Location = new System.Drawing.Point(0, 69);
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
            this.picb_ML.Size = new System.Drawing.Size(168, 47);
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
            this.picb_MM.Size = new System.Drawing.Size(832, 44);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Body.Controls.Add(this.vcGantt);
            this.pnl_Body.Location = new System.Drawing.Point(0, 160);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pnl_Body.Size = new System.Drawing.Size(1016, 480);
            this.pnl_Body.TabIndex = 36;
            // 
            // vcGantt
            // 
            this.vcGantt.BackColor = System.Drawing.SystemColors.Window;
            this.vcGantt.ConfigurationStorage = ((NETRONIC.XGantt.VcConfigurationStorage)(resources.GetObject("vcGantt.ConfigurationStorage")));
            this.vcGantt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vcGantt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcGantt.Location = new System.Drawing.Point(8, 0);
            this.vcGantt.Name = "vcGantt";
            this.vcGantt.Size = new System.Drawing.Size(1000, 480);
            this.vcGantt.TabIndex = 1;
            this.vcGantt.Text = "vcGantt1";
            this.vcGantt.VcGroupLeftDoubleClicking += new NETRONIC.XGantt.VcGantt.VcGroupLeftDoubleClickingEventHandler(this.vcGantt_VcGroupLeftDoubleClicking);
            this.vcGantt.VcNodeRightClicking += new NETRONIC.XGantt.VcGantt.VcNodeRightClickingEventHandler(this.vcGantt_VcNodeRightClicking);
            this.vcGantt.VcGroupLeftClicking += new NETRONIC.XGantt.VcGantt.VcGroupLeftClickingEventHandler(this.vcGantt_VcGroupLeftClicking);
            this.vcGantt.VcNodeCreating += new NETRONIC.XGantt.VcGantt.VcNodeCreatingEventHandler(this.vcGantt_VcNodeCreating);
            this.vcGantt.VcNodeModifying += new NETRONIC.XGantt.VcGantt.VcNodeModifyingEventHandler(this.vcGantt_VcNodeModifying);
            this.vcGantt.VcGroupRightClicking += new NETRONIC.XGantt.VcGantt.VcGroupRightClickingEventHandler(this.vcGantt_VcGroupRightClicking);
            this.vcGantt.VcToolTipTextSupplying += new NETRONIC.XGantt.VcGantt.VcToolTipTextSupplyingEventHandler(this.vcGantt_VcToolTipTextSupplying);
            this.vcGantt.VcNodeLeftDoubleClicking += new NETRONIC.XGantt.VcGantt.VcNodeLeftDoubleClickingEventHandler(this.vcGantt_VcNodeLeftDoubleClicking);
            this.vcGantt.VcNodeDeleting += new NETRONIC.XGantt.VcGantt.VcNodeDeletingEventHandler(this.vcGantt_VcNodeDeleting);
            this.vcGantt.Click += new System.EventHandler(this.vcGantt_Click);
            // 
            // cmenu_diagram
            // 
            this.cmenu_diagram.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink24,
            this.c1CommandLink9,
            this.c1CommandLink11,
            this.c1CommandLink22,
            this.c1CommandLink16,
            this.c1CommandLink28,
            this.c1CommandLink29});
            this.cmenu_diagram.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(129)));
            this.cmenu_diagram.Name = "cmenu_diagram";
            // 
            // c1CommandLink24
            // 
            this.c1CommandLink24.Command = this.menuitem_MoveLOT;
            // 
            // menuitem_MoveLOT
            // 
            this.menuitem_MoveLOT.Name = "menuitem_MoveLOT";
            this.menuitem_MoveLOT.Text = "Move";
            this.menuitem_MoveLOT.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_MoveLOT_Click);
            // 
            // c1CommandLink9
            // 
            this.c1CommandLink9.Command = this.menuitem_DLOT;
            // 
            // menuitem_DLOT
            // 
            this.menuitem_DLOT.Name = "menuitem_DLOT";
            this.menuitem_DLOT.Text = "Divide";
            this.menuitem_DLOT.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_DLOT_Click);
            // 
            // c1CommandLink11
            // 
            this.c1CommandLink11.Command = this.menuitem_MLOT;
            // 
            // menuitem_MLOT
            // 
            this.menuitem_MLOT.Name = "menuitem_MLOT";
            this.menuitem_MLOT.Text = "Merge";
            this.menuitem_MLOT.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_MLOT_Click);
            // 
            // c1CommandLink22
            // 
            this.c1CommandLink22.Command = this.c1Command2;
            // 
            // c1Command2
            // 
            this.c1Command2.Name = "c1Command2";
            this.c1Command2.Text = "-";
            // 
            // c1CommandLink16
            // 
            this.c1CommandLink16.Command = this.menuitem_DisplayDaySize;
            // 
            // menuitem_DisplayDaySize
            // 
            this.menuitem_DisplayDaySize.Name = "menuitem_DisplayDaySize";
            this.menuitem_DisplayDaySize.Text = "Assign Size to LOT";
            this.menuitem_DisplayDaySize.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_DisplayDaySize_Click);
            // 
            // c1CommandLink28
            // 
            this.c1CommandLink28.Command = this.c1Command4;
            // 
            // c1Command4
            // 
            this.c1Command4.Name = "c1Command4";
            this.c1Command4.Text = "-";
            // 
            // c1CommandLink29
            // 
            this.c1CommandLink29.Command = this.menuitem_OAClosing;
            // 
            // menuitem_OAClosing
            // 
            this.menuitem_OAClosing.Icon = ((System.Drawing.Icon)(resources.GetObject("menuitem_OAClosing.Icon")));
            this.menuitem_OAClosing.Name = "menuitem_OAClosing";
            this.menuitem_OAClosing.Text = "OA Closing";
            this.menuitem_OAClosing.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_OAClosing_Click);
            // 
            // cmenu_table
            // 
            this.cmenu_table.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink17,
            this.c1CommandLink10,
            this.c1CommandLink21,
            this.c1CommandLink12,
            this.c1CommandLink23,
            this.c1CommandLink27,
            this.c1CommandLink15,
            this.c1CommandLink18,
            this.c1CommandLink20,
            this.c1CommandLink13,
            this.c1CommandLink14,
            this.c1CommandLink25,
            this.c1CommandLink26});
            this.cmenu_table.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(129)));
            this.cmenu_table.Name = "cmenu_table";
            // 
            // c1CommandLink17
            // 
            this.c1CommandLink17.Command = this.menuitem_LOTInfo;
            // 
            // menuitem_LOTInfo
            // 
            this.menuitem_LOTInfo.Name = "menuitem_LOTInfo";
            this.menuitem_LOTInfo.Text = "LOT Information";
            this.menuitem_LOTInfo.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_LOTInfo_Click);
            // 
            // c1CommandLink10
            // 
            this.c1CommandLink10.Command = this.menuitem_MoveLine;
            // 
            // menuitem_MoveLine
            // 
            this.menuitem_MoveLine.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink19});
            this.menuitem_MoveLine.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(129)));
            this.menuitem_MoveLine.Name = "menuitem_MoveLine";
            this.menuitem_MoveLine.Text = "Move into Another Line";
            this.menuitem_MoveLine.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_MoveLine_Click);
            // 
            // c1CommandLink19
            // 
            this.c1CommandLink19.Command = this.menuitem_ReqNo;
            // 
            // menuitem_ReqNo
            // 
            this.menuitem_ReqNo.Name = "menuitem_ReqNo";
            this.menuitem_ReqNo.Text = "Request NO";
            this.menuitem_ReqNo.Visible = false;
            // 
            // c1CommandLink21
            // 
            this.c1CommandLink21.Command = this.menuitem_ChangeLOT;
            // 
            // menuitem_ChangeLOT
            // 
            this.menuitem_ChangeLOT.Name = "menuitem_ChangeLOT";
            this.menuitem_ChangeLOT.Text = "Change LOT";
            this.menuitem_ChangeLOT.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_ChangeLOT_Click);
            // 
            // c1CommandLink12
            // 
            this.c1CommandLink12.Command = this.menuitem_CancelLOT;
            // 
            // menuitem_CancelLOT
            // 
            this.menuitem_CancelLOT.Name = "menuitem_CancelLOT";
            this.menuitem_CancelLOT.Text = "Cancel Assigned LOT";
            this.menuitem_CancelLOT.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_CancelLOT_Click);
            // 
            // c1CommandLink23
            // 
            this.c1CommandLink23.Command = this.menuitem_LOTSize;
            // 
            // menuitem_LOTSize
            // 
            this.menuitem_LOTSize.Name = "menuitem_LOTSize";
            this.menuitem_LOTSize.Text = "LOT Size/ Add Loss";
            this.menuitem_LOTSize.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_LOTSize_Click);
            // 
            // c1CommandLink27
            // 
            this.c1CommandLink27.Command = this.menuitem_DelayProduction;
            // 
            // menuitem_DelayProduction
            // 
            this.menuitem_DelayProduction.Name = "menuitem_DelayProduction";
            this.menuitem_DelayProduction.Text = "Delay Production";
            this.menuitem_DelayProduction.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_DelayProduction_Click);
            // 
            // c1CommandLink15
            // 
            this.c1CommandLink15.Command = this.c1Command1;
            // 
            // c1Command1
            // 
            this.c1Command1.Name = "c1Command1";
            this.c1Command1.Text = "-";
            // 
            // c1CommandLink18
            // 
            this.c1CommandLink18.Command = this.menuitem_LastInv;
            // 
            // menuitem_LastInv
            // 
            this.menuitem_LastInv.Name = "menuitem_LastInv";
            this.menuitem_LastInv.Text = "Assign Last Inventory Quantity";
            this.menuitem_LastInv.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_LastInv_Click);
            // 
            // c1CommandLink20
            // 
            this.c1CommandLink20.Command = this.menuitem_DisplaySize;
            // 
            // menuitem_DisplaySize
            // 
            this.menuitem_DisplaySize.Name = "menuitem_DisplaySize";
            this.menuitem_DisplaySize.Text = "Assign Size to LOT";
            this.menuitem_DisplaySize.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_DisplaySize_Click);
            // 
            // c1CommandLink13
            // 
            this.c1CommandLink13.Command = this.menuitem_MiniLine;
            // 
            // menuitem_MiniLine
            // 
            this.menuitem_MiniLine.Name = "menuitem_MiniLine";
            this.menuitem_MiniLine.Text = "Assign to MiniLine";
            this.menuitem_MiniLine.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_MiniLine_Click);
            // 
            // c1CommandLink14
            // 
            this.c1CommandLink14.Command = this.menuitem_TS;
            // 
            // menuitem_TS
            // 
            this.menuitem_TS.Name = "menuitem_TS";
            this.menuitem_TS.Text = "Assign Time Sequence";
            this.menuitem_TS.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_TS_Click);
            // 
            // c1CommandLink25
            // 
            this.c1CommandLink25.Command = this.c1Command3;
            // 
            // c1Command3
            // 
            this.c1Command3.Name = "c1Command3";
            this.c1Command3.Text = "-";
            // 
            // c1CommandLink26
            // 
            this.c1CommandLink26.Command = this.menuitem_LOTForecast;
            // 
            // menuitem_LOTForecast
            // 
            this.menuitem_LOTForecast.Name = "menuitem_LOTForecast";
            this.menuitem_LOTForecast.Text = "LOT Forecast Size";
            this.menuitem_LOTForecast.Click += new C1.Win.C1Command.ClickEventHandler(this.menuitem_LOTForecast_Click);
            // 
            // menuitem_AllMove
            // 
            this.menuitem_AllMove.Name = "menuitem_AllMove";
            // 
            // Form_PO_LOTDaily
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Search);
            this.Name = "Form_PO_LOTDaily";
            this.Text = "MPS (Master Plan Schedule)";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LineTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LineFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion  

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 

		//rts_ymd가 없는 경우 최대 날짜로 설정
		private string _NullDate = "99981231";

		private DataTable _DT_Query;




		//----------------------------------------------
		// 선적 구간 표시
		//---------------------------------------------- 
		public string _ShipDateF_20 = "";  // 선적중
		public string _ShipDateT_20 = "";
		public string _ShipDateF_30 = "";  // 선적준비중
		public string _ShipDateT_30 = "";
		public string _ShipDateF_40 = "";  // 다음 선적 진행중
		public string _ShipDateT_40 = "";
		public string _ShipDateF_50 = "";  // Free 구간
		public string _ShipDateT_50 = "";

		public Color _ClrShipDate_20;
		public Color _ClrShipDate_30;
		public Color _ClrShipDate_40;  

		public string _WarningDateF = "";
		public string _WarningDateT = "";
		//----------------------------------------------



		//----------------------------------------------
		// vcGantt 관련 변수
		//---------------------------------------------- 
		//ContextMenu 선택시 클릭한 노드, 그룹
		private VcNode _SelNode; 
		private string _SelLine;

		//ContextMenu 선택시 클릭한 그룹
		private NETRONIC.XGantt.VcGroup _SelGroup; 
 
		//----------------------------------------------



        //// thread process wait. form
        //private FlexAPS.ProdBase.Pop_ProcessWait _PopForm;
 

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
				this.Text = "MPS (Master Plan Schedule)";
				lbl_MainTitle.Text = "MPS (Master Plan Schedule)"; 
			
				//ClassLib.ComFunction.SetLangDic(this);
 

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

			tbtn_Save.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false;  



			Set_QueryTable();
			Set_vcGantt();


			dpick_FromYMD.CustomFormat = " "; 
			dpick_ToYMD.CustomFormat = " "; 

            

			



			// Factory Combobox Add Items 
			DataTable dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;    


		}

 
		private void Set_QueryTable()
		{

			_DT_Query = new DataTable("Query List"); 
   	
			// LOT_NO - LOT_SEQ - DAY_SEQ
			_DT_Query.Columns.Add(new DataColumn("ID", Type.GetType("System.String")));

			// query문 (insert, update, delete)
			_DT_Query.Columns.Add(new DataColumn("Query", Type.GetType("System.String")));

			// save 조건 만족하는 쿼리문 표시 (Y/N)
			_DT_Query.Columns.Add(new DataColumn("CheckDiv", Type.GetType("System.String")));    
  
		}


		/// <summary>
		/// Set_vcGantt : 간트차트 세팅
		/// </summary>
		private void Set_vcGantt()
		{

			//Set file path for the bitmaps
//			string exeName = Environment.GetCommandLineArgs()[0];
//			string exeDir = System.IO.Path.GetDirectoryName(exeName);
//			vcGantt.FilePath = System.IO.Path.GetDirectoryName(exeDir)+ @"\PlanImage\"; 
			
			
			//--------------------------------------------------------------
			//체크박스 구현 
			// 1. 속성창-> object -> tables -> tableformat 중 적용하고자 하는 format 선택
			// 2. 선택한 format 수정화면 -> 체크박스 넣을 필드 선택 -> 타입을 Graphics로 선택
			// 3. Graphics file Name 입력 칸에서 Configure Mapping화면 선택
			// 4. 적용시킬 데이터 필드, Map을 선택
			// 5. Map은 Graphics File Map으로 등록
			//-------------------------------------------------------------- 

 


		} 



		#endregion

		#region VcGantt 관련 : 날짜형, 문자형 변환, 마지막 일자 구하기, 초기화

		/// <summary>
		/// normDat : 날짜형을 vcGantt chart형 날짜 포맷 스트링으로
		/// </summary>
		/// <param name="arg_dateValue"></param>
		/// <returns></returns>
		private string normDat(DateTime arg_dateValue)
		{
			string dateValue;

			dateValue = arg_dateValue.ToString("dd.MM.yy");

			return dateValue;
		}


		/// <summary>
		/// Convert_ToDate : 스트링을 날짜형으로 
		/// </summary>
		/// <param name="arg_dateString"></param>
		/// <returns></returns>
		private static DateTime Convert_ToDate(string arg_dateString)
		{
			 string date_string;

			date_string = arg_dateString.Substring(0, 4) + "-";
			date_string = date_string + arg_dateString.Substring(4, 2) + "-";
			date_string = date_string + arg_dateString.Substring(6, 2);
		
			return Convert.ToDateTime(date_string);
			 
 
		}


		/// <summary>
		/// SetNodeEndDate :  calculate end date for all nodes  
		/// </summary>
		/// <param name="node"></param>
		private void SetNodeEndDate(VcNode node)
		{
			 
			// Avoid empty duration or negative duration
			if ((string) node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDURATION) == "" || 
				Convert.ToInt32(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDURATION)) < 0)
				node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDURATION,"0");
         
			// Start Date empty then end date should also be empty 
			if (node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString() == "31.12.1899 00:00:00")
				node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_E,""); 
			else
			{
				// Precondition in property page nodes
				// "assign calendar to nodes" must be true 
				VcCalendar tmpCal = vcGantt.CalendarCollection.Active;   
           
				DateTime tmpDate = tmpCal.AddDuration((DateTime)node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S),
					Convert.ToInt32(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDURATION)));
				node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_E, tmpDate);
            
				 
				node.Update();
			}  
			 

		}


		/// <summary>
		/// Clear_vcGantt : 간트차트 초기화
		/// </summary>
		private void Clear_vcGantt()
		{
			

			try
			{

				this.Cursor = Cursors.WaitCursor;

				if(vcGantt == null) return;

				if(vcGantt.NodeCollection.Count == 0) return;

				vcGantt.SuspendUpdate(true);

				foreach(VcGroup group in vcGantt.GroupCollection)
				{
					VcGroupCollection subGroupCltn = group.SubGroups;

					foreach(VcGroup subgroup in subGroupCltn)
					{
						VcNodeCollection nodeCltn = subgroup.NodeCollection;

						foreach(VcNode node in nodeCltn) node.Delete();

						subgroup.Delete();
					} 

					group.Delete();
				}

				vcGantt.SuspendUpdate(false);


				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Clear_vcGantt", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}



		#endregion
 
		#region 툴바 이벤트 메서드
		

		private void Event_Tbtn_New()
		{
			//간트차트 초기화
			Clear_vcGantt(); 
		}


		private void Event_Tbtn_Search()
		{
 

			#region


				try
				{
					
					

					//this.Cursor = Cursors.WaitCursor;
	 

	
					if(cmb_Factory.SelectedIndex == -1) return; 
	
					
					//--------------------------------------------------------------
					// 1. 간트차트 초기화
					//-------------------------------------------------------------- 
					Clear_vcGantt();   
					//--------------------------------------------------------------  
	
					//--------------------------------------------------------------
					// 2. shipping area, MPS 표시하기 위한 Dataset
					//--------------------------------------------------------------  
					DataSet ds_ret = Select_SPO_LOT_DAILY();  
					//--------------------------------------------------------------  
	
					//--------------------------------------------------------------
					// 3. shipping area 표시하기 위한 변수 할당
					//--------------------------------------------------------------  
					DataTable dt_warning = ds_ret.Tables[2]; 
	
	//				_ShipDateF_20 = dt_warning.Rows[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
	//				_ShipDateT_20 = dt_warning.Rows[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();
	//				_ClrShipDate_20 = Color.FromArgb( Convert.ToInt32(dt_warning.Rows[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxBACK_COLOR].ToString() ) );
	//
	//				_ShipDateF_30 = dt_warning.Rows[1].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
	//				_ShipDateT_30 = dt_warning.Rows[1].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();
	//				_ClrShipDate_30 = Color.FromArgb( Convert.ToInt32(dt_warning.Rows[1].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxBACK_COLOR].ToString() ) );
	//
	//				_ShipDateF_40 = dt_warning.Rows[2].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
	//				_ShipDateT_40 = dt_warning.Rows[2].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();
	//				_ClrShipDate_40 = Color.FromArgb( Convert.ToInt32(dt_warning.Rows[2].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxBACK_COLOR].ToString() ) );
	//
	//				_ShipDateF_50 = dt_warning.Rows[3].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
	//				_ShipDateT_50 = dt_warning.Rows[3].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();  
	

	
					string where = "AREA_CD = " + @"'20'";
					DataRow[] findrow = dt_warning.Select(where);
					if(findrow.Length != 0)
					{
						_ShipDateF_20 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
						_ShipDateT_20 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();
						_ClrShipDate_20 = Color.FromArgb( Convert.ToInt32(findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxBACK_COLOR].ToString() ) );
					}
					findrow = null;
	
					where = "AREA_CD = " + @"'30'";
					findrow = dt_warning.Select(where);
					if(findrow.Length != 0)
					{
						_ShipDateF_30 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
						_ShipDateT_30 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();
						_ClrShipDate_30 = Color.FromArgb( Convert.ToInt32(findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxBACK_COLOR].ToString() ) );
					}
					findrow = null;
	
					where = "AREA_CD = " + @"'40'";
					findrow = dt_warning.Select(where);
					if(findrow.Length != 0)
					{
						_ShipDateF_40 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
						_ShipDateT_40 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();
						_ClrShipDate_40 = Color.FromArgb( Convert.ToInt32(findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxBACK_COLOR].ToString() ) );
					}
					findrow = null;
	
					where = "AREA_CD = " + @"'50'";
					findrow = dt_warning.Select(where);
					if(findrow.Length != 0)
					{
						_ShipDateF_50 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
						_ShipDateT_50 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();
					}
					findrow = null;
	
	
					_WarningDateF = _ShipDateF_30;
					_WarningDateT = _ShipDateF_50;
					//-------------------------------------------------------------- 
	

					//this.Cursor = Cursors.Default;



					//--------------------------------------------------------------
					// 4. MPS 표시
					//--------------------------------------------------------------
					DataTable dt_ret1 = ds_ret.Tables[0]; 
					Display_vcGantt_Head(dt_ret1);  
	
					DataTable dt_ret2 = ds_ret.Tables[1];  
					Display_vcGantt_Detail(dt_ret2);   
					//-------------------------------------------------------------- 
	
					//--------------------------------------------------------------
					// 5. shipping area 표시
					//--------------------------------------------------------------
					VcDateLine shipping_date_f_30 = vcGantt.DateLineCollection.DateLineByName("ShippingDateF_30");
					shipping_date_f_30.Date = Convert.ToDateTime(Convert_ToDate(_ShipDateF_30).ToString("yy.MM.dd"));
					shipping_date_f_30.LineColor = Color.Blue;  //_ClrShipDate_20;  // blue
					shipping_date_f_30.LineThickness = 100;
					shipping_date_f_30.Visible = true;
	
					VcDateLine shipping_date_f_40 = vcGantt.DateLineCollection.DateLineByName("ShippingDateF_40");
					shipping_date_f_40.Date = Convert.ToDateTime(Convert_ToDate(_ShipDateF_40).ToString("yy.MM.dd"));
					shipping_date_f_40.LineColor = Color.Yellow; //_ClrShipDate_30;  // yellow
					shipping_date_f_40.LineThickness = 100;
					shipping_date_f_40.Visible = true;
	
	
					VcDateLine shipping_date_f_50 = vcGantt.DateLineCollection.DateLineByName("ShippingDateF_50");
					shipping_date_f_50.Date = Convert.ToDateTime(Convert_ToDate(_ShipDateF_50).ToString("yy.MM.dd"));
					shipping_date_f_50.LineColor = Color.Green; //_ClrShipDate_40;  // green
					shipping_date_f_50.LineThickness = 100;
					shipping_date_f_50.Visible = true;
					//--------------------------------------------------------------
	
					//-----------------------------------------------------------------------------------------------
					// 6. VJ 일 경우 shipping green 구간부터 향후 10주 표시
					//-----------------------------------------------------------------------------------------------
					if(cmb_Factory.SelectedIndex != -1 && cmb_Factory.SelectedValue.ToString() == "VJ" && cmb_Factory.SelectedValue.ToString() == "JJ")
					{

						DateTime date_warning_start = Convert_ToDate(_ShipDateF_50);

						//Define non work interval for shaded area
						//VcCalendar calendar = vcGantt.CalendarCollection.CalendarByName("BaseCalendar");
						VcCalendar calendar = vcGantt.CalendarCollection.CalendarByName("HolidayCalendar");
						calendar.AddNonWorkInterval(date_warning_start, date_warning_start.AddDays(70));

					}
					//-----------------------------------------------------------------------------------------------







				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				//this.Cursor = Cursors.Default;
			}

			#endregion


//			if(cmb_Factory.SelectedIndex == -1) return; 
//
//
//
//
//			System.Threading.Thread thread_run = new System.Threading.Thread(new System.Threading.ThreadStart(Event_Tbtn_Search_Run));
//			thread_run.Start();
//
//			_PopForm = new FlexAPS.ProdBase.Pop_ProcessWait();
//			_PopForm.Processing();
//			_PopForm.Start(); 
//
//
//			// thread 종료 후 재 조회
//			thread_run.Abort(); 

				   


		}  





		#region vcGantt 표시 관련


		

		/// <summary>
		/// Event_Tbtn_Search_Run : 
		/// </summary>
		private void Event_Tbtn_Search_Run()
		{


			try
			{


				//--------------------------------------------------------------
				// 1. 간트차트 초기화
				//-------------------------------------------------------------- 
				Clear_vcGantt();   
				//--------------------------------------------------------------  

				//--------------------------------------------------------------
				// 2. shipping area, MPS 표시하기 위한 Dataset
				//--------------------------------------------------------------  
				DataSet ds_ret = Select_SPO_LOT_DAILY();  
				//--------------------------------------------------------------  

				//--------------------------------------------------------------
				// 3. shipping area 표시하기 위한 변수 할당
				//--------------------------------------------------------------  
				DataTable dt_warning = ds_ret.Tables[2]; 
 
				string where = "AREA_CD = " + @"'20'";
				DataRow[] findrow = dt_warning.Select(where);
				if(findrow.Length != 0)
				{
					_ShipDateF_20 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
					_ShipDateT_20 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();
					_ClrShipDate_20 = Color.FromArgb( Convert.ToInt32(findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxBACK_COLOR].ToString() ) );
				}
				findrow = null;

				where = "AREA_CD = " + @"'30'";
				findrow = dt_warning.Select(where);
				if(findrow.Length != 0)
				{
					_ShipDateF_30 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
					_ShipDateT_30 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();
					_ClrShipDate_30 = Color.FromArgb( Convert.ToInt32(findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxBACK_COLOR].ToString() ) );
				}
				findrow = null;

				where = "AREA_CD = " + @"'40'";
				findrow = dt_warning.Select(where);
				if(findrow.Length != 0)
				{
					_ShipDateF_40 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
					_ShipDateT_40 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();
					_ClrShipDate_40 = Color.FromArgb( Convert.ToInt32(findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxBACK_COLOR].ToString() ) );
				}
				findrow = null;

				where = "AREA_CD = " + @"'50'";
				findrow = dt_warning.Select(where);
				if(findrow.Length != 0)
				{
					_ShipDateF_50 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_F].ToString();
					_ShipDateT_50 = findrow[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS.IxPLAN_DATE_T].ToString();
				}
				findrow = null;


				_WarningDateF = _ShipDateF_30;
				_WarningDateT = _ShipDateF_50;
				//-------------------------------------------------------------- 

				//--------------------------------------------------------------
				// 4. MPS 표시
				//--------------------------------------------------------------
				DataTable dt_ret1 = ds_ret.Tables[0]; 
				Display_vcGantt_Head(dt_ret1);  

				DataTable dt_ret2 = ds_ret.Tables[1];  
				Display_vcGantt_Detail(dt_ret2);   
				//-------------------------------------------------------------- 

				//--------------------------------------------------------------
				// 5. shipping area 표시
				//--------------------------------------------------------------
				VcDateLine shipping_date_f_30 = vcGantt.DateLineCollection.DateLineByName("ShippingDateF_30");
				shipping_date_f_30.Date = Convert.ToDateTime(Convert_ToDate(_ShipDateF_30).ToString("yy.MM.dd"));
				shipping_date_f_30.LineColor = Color.Blue;  //_ClrShipDate_20;  // blue
				shipping_date_f_30.LineThickness = 100;
				shipping_date_f_30.Visible = true;

				VcDateLine shipping_date_f_40 = vcGantt.DateLineCollection.DateLineByName("ShippingDateF_40");
				shipping_date_f_40.Date = Convert.ToDateTime(Convert_ToDate(_ShipDateF_40).ToString("yy.MM.dd"));
				shipping_date_f_40.LineColor = Color.Yellow; //_ClrShipDate_30;  // yellow
				shipping_date_f_40.LineThickness = 100;
				shipping_date_f_40.Visible = true;


				VcDateLine shipping_date_f_50 = vcGantt.DateLineCollection.DateLineByName("ShippingDateF_50");
				shipping_date_f_50.Date = Convert.ToDateTime(Convert_ToDate(_ShipDateF_50).ToString("yy.MM.dd"));
				shipping_date_f_50.LineColor = Color.Green; //_ClrShipDate_40;  // green
				shipping_date_f_50.LineThickness = 100;
				shipping_date_f_50.Visible = true;
				//--------------------------------------------------------------

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
			finally 
			{ 
				//_PopForm.Close(); 
				this.Cursor = Cursors.Default;   
			} 


		}




		/// <summary>
		/// Display_vcGantt : 간트차트로 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_vcGantt_Head(DataTable arg_dt)
		{ 
			

			if(arg_dt.Rows.Count == 0) return;  


			
			this.Cursor = Cursors.WaitCursor;



			string linecd, linename, lot, modelname, stylecd, gen;
			string obsid, obstype, view_rgac, ogac, lotqty, lossqty, sumqty;
			string pono, totdayseq, lotplanyn, dayseq;
			string dailysizeqty, dailyplanstatus, dailysizeyn, flag, reallotyn, id, finishyn;
			string linemanager; 
			DateTime rgac, planymd;   



			vcGantt.SuspendUpdate(true); 



			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{ 
				linecd = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxLINE_CD].ToString();
				linename = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxLINE_NAME].ToString(); 
				lot = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxLOT].ToString();
				modelname = "";  
				stylecd = ""; 
				gen = "";  
				obsid = "";  
				obstype = "";  
					
				ogac = ""; 
				lotqty = ""; 
				lossqty = "";  
				sumqty = "";  
				pono = "";  
				totdayseq = "";
				lotplanyn = ""; 
				dayseq = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxDAY_SEQ].ToString(); 
				

				//total row
				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY.IxLOT].ToString() == "_") 
				{
					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxPLAN_YMD].ToString().Substring(0, 1) != "_")
					{
						planymd = Convert_ToDate(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxPLAN_YMD].ToString());
					}
					else
					{
						planymd = Convert_ToDate(_NullDate); 
					}

					
					rgac = Convert_ToDate(_NullDate);
					view_rgac = ""; 


				}
				else
				{
					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxPLAN_YMD].ToString().Substring(0, 1) != "_")
					{
						planymd = Convert_ToDate(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxPLAN_YMD].ToString());
						rgac = Convert_ToDate(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxPLAN_YMD].ToString());
						view_rgac = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxPLAN_YMD].ToString().Substring(4, 2)
							+ ClassLib.ComVar.This_SetedDateSign + arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxPLAN_YMD].ToString().Substring(6, 2);
					}
					else
					{
						planymd = Convert_ToDate(_NullDate); 
						rgac = Convert_ToDate(_NullDate);
						view_rgac = "";
					}
				}

				
				dailysizeqty = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxDAILY_SIZEQTY].ToString();
				dailyplanstatus = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxDAILY_PLANSTATUS].ToString();
				dailysizeyn = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxDAILY_SIZEYN].ToString();
				linemanager = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxLINE_MANAGER].ToString();


				flag = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxFLAG].ToString(); 
				
				string planymd_s = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxPLAN_YMD].ToString();

				
				
				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY.IxLOT].ToString() != "_")  //total row
				{
					if(planymd_s.Substring(0, 1) != "_")
					{ 
						
						if(Convert.ToInt32(planymd_s) >= Convert.ToInt32(_WarningDateF) 
							&& Convert.ToInt32(planymd_s) < Convert.ToInt32(_WarningDateT) )
						{
							flag = "W";
						} 
							
					}
				} // end (! total row)

				//------------------------------------------------------------------------------------------------------




				
				reallotyn = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxREAL_LOTYN].ToString();
				id = lot + "-" + dayseq; 
				finishyn = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_HEAD.IxDAILY_FNISH_YN].ToString();

				vcGantt.InsertNodeRecord(id             + ";" + linecd			 + ";" + linename                    + ";" 
										+ lot           + ";" + modelname		 + ";" + stylecd                     + ";" 
										+ gen           + ";" + obsid			 + ";" + obstype                     + ";" 
										+ normDat(rgac) + ";" + view_rgac		 + ";" + ogac                        + ";" 
										+ lotqty        + ";" + lossqty			 + ";" + sumqty                      + ";" 
										+ pono          + ";" + totdayseq        + ";" + lotplanyn                   + ";" 
										+ dayseq		+ ";" + normDat(planymd) + ";" + normDat(planymd.AddDays(1)) + ";" 
										+ "1"		    + ";" + dailysizeqty     + ";" + dailyplanstatus			 + ";"
										+ dailysizeyn   + ";" + flag	         + ";" + reallotyn                   + ";"
										+ "Y"			+ ";" + finishyn		 + ";" + linemanager                 + ";" );					
 		

			}    //end for

			
			vcGantt.TimeScaleStart = Convert_ToDate(MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text));
			vcGantt.TimeScaleEnd = Convert_ToDate(MyComFunction.ConvertDate2DbType(dpick_ToYMD.Text));


//			string plan_status = "";
//			string today_plan_ymd = "";


			foreach(VcNode node in vcGantt.NodeCollection) 
			{

				node.MoveMode = VcNodeMoveMode.vcNodeMoveModeX; 


//				if(today_plan_ymd.Trim().Equals(""))
//				{
//					plan_status = node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_PLANSTATUS).ToString();
//
//					if(plan_status.Trim().Equals("L"))
//					{
//						today_plan_ymd = Convert.ToDateTime(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S)).Year.ToString()
//										+ Convert.ToDateTime(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S)).Month.ToString().PadLeft(2, '0')
//										+ Convert.ToDateTime(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S)).Day.ToString().PadLeft(2, '0');
//
//						
//
//					} // end if(plan_status.Trim().Equals("L"))
//
//				} // end if(plan_ymd.Trim().Equals(""))


			}


			
			vcGantt.SuspendUpdate(false);

			vcGantt.EndLoading();
			
			

//			//-----------------------------------------------------------------------------------------------
//            // VJ 일 경우 현 작업지시 생산 일자부터 6주~10주 표시
//			//-----------------------------------------------------------------------------------------------
//			if(cmb_Factory.SelectedIndex != -1 && cmb_Factory.SelectedValue.ToString() == "VJ" && cmb_Factory.SelectedValue.ToString() == "JJ")
//			{
//
//				DateTime date_warning_start = Convert_ToDate(today_plan_ymd);
//
//				//Define non work interval for shaded area
//				//VcCalendar calendar = vcGantt.CalendarCollection.CalendarByName("BaseCalendar");
//				VcCalendar calendar = vcGantt.CalendarCollection.CalendarByName("HolidayCalendar");
//				calendar.AddNonWorkInterval(date_warning_start.AddDays(36), date_warning_start.AddDays(64)); // 6주~10주
//
//			}
//			//-----------------------------------------------------------------------------------------------





			
			this.Cursor = Cursors.Default;



		}   




		/// <summary>
		/// Display_vcGantt : 간트차트로 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_vcGantt_Detail(DataTable arg_dt)
		{ 
			 
			if(arg_dt.Rows.Count == 0) return;  


			
			this.Cursor = Cursors.WaitCursor;



			string modelname, stylecd, gen;
			string obsid, obstype, view_rgac, ogac, view_ogac, lotqty, lossqty, sumqty;
			string pono, lotplanyn, msryn; 
			DateTime rgac;  



			vcGantt.SuspendUpdate(true); 

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{ 
				
				modelname = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxMODEL_NAME].ToString(); 
				stylecd = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxSTYLE_CD].ToString();
				gen = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxGEN].ToString();
				obsid = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxOBS_ID].ToString();
				obstype = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxOBS_TYPE].ToString();
				
				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxRGAC].ToString().Substring(0, 1) != "_")
				{
					rgac = Convert_ToDate(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxRGAC].ToString());
					view_rgac = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxRGAC].ToString().Substring(4, 2)
						+ ClassLib.ComVar.This_SetedDateSign + arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxRGAC].ToString().Substring(6, 2);
				}
				else
				{
					rgac = Convert_ToDate(_NullDate);
					view_rgac = "";
				}


				ogac = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxOGAC].ToString(); 

				if(ogac.Length == 8)
				{
					view_ogac = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxOGAC].ToString().Substring(4, 2)
						+ ClassLib.ComVar.This_SetedDateSign + arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxOGAC].ToString().Substring(6, 2);
				}
				else
				{
					view_ogac = "";
				}

				 

				lotqty = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxLOT_QTY].ToString();
				lossqty = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxLOSS_QTY].ToString();
				sumqty = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxSUM_QTY].ToString();
				pono = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxPO_NO].ToString();
				lotplanyn = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxLOT_PLANYN].ToString();
				msryn = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_DETAIL.IxMSR_YN].ToString();
					


				foreach(VcGroup group in vcGantt.GroupCollection)
				{
					VcGroupCollection subGroupCltn = group.SubGroups;

					foreach(VcGroup subgroup in subGroupCltn)
					{ 
						if(subgroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString()
							== arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY.IxLOT].ToString())
						{
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxMODEL_NAME, modelname);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxSTYLE_CD, stylecd);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxGEN, gen);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxOBS_ID, obsid);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxOBS_TYPE, obstype);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxVIEW_RGAC, view_rgac);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxOGAC, ogac);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT_QTY, lotqty);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOSS_QTY, lossqty);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxSUM_QTY, sumqty);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPO_NO, pono); 
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT_PLANYN, lotplanyn);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxMSR_YN, msryn);
							subgroup.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxVIEW_OGAC, view_ogac);

							foreach(VcNode node in subgroup.NodeCollection)
							{
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxMODEL_NAME, modelname);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxSTYLE_CD, stylecd);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxGEN, gen);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxOBS_ID, obsid);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxOBS_TYPE, obstype);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxVIEW_RGAC, view_rgac);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxOGAC, ogac);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT_QTY, lotqty);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOSS_QTY, lossqty);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxSUM_QTY, sumqty);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPO_NO, pono); 
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT_PLANYN, lotplanyn);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxMSR_YN, msryn);
								node.set_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxVIEW_OGAC, view_ogac);
							}

							break;

						} // end if 

					} // end foreach(VcGroup subgroup in subGroupCltn) 
				} // end foreach(VcGroup group in vcGantt.GroupCollection) 

			}    //end for

			vcGantt.SuspendUpdate(false);
			 
		

			
			this.Cursor = Cursors.Default;


		}   



		

		/// <summary>
		/// Refresh_vcGantt : 수정된 라인에 대해서만 Clear후 Search
		/// </summary>
		/// <param name="arg_line">수정된 라인 정보</param>
		private void Refresh_vcGantt(string arg_line)
		{

			#region

			 
			this.Cursor = Cursors.WaitCursor;
			

			//---------------------------------------------------------
			// Clear
			//---------------------------------------------------------
			vcGantt.SuspendUpdate(true); 
			
			string[] token = arg_line.Split('/'); 


			for(int i = 0; i < token.Length; i++)
			{
				foreach(VcGroup group in vcGantt.GroupCollection)
				{ 
					if(group.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString() == token[i])
					{
						VcGroupCollection subGroupCltn = group.SubGroups;

						foreach(VcGroup subgroup in subGroupCltn)
						{
							VcNodeCollection nodeCltn = subgroup.NodeCollection;

							foreach(VcNode node in nodeCltn) node.Delete();

							subgroup.Delete();
						} 

						group.Delete();
					}
				
				} 
			} //end for i



			//---------------------------------------------------------
			// Search
			//---------------------------------------------------------
			for(int i = 0; i < token.Length; i++)
			{   
	
				DataSet ds_ret = Select_SPO_LOT_DAILY_LINE(token[i]); 

				DataTable dt_ret1 = ds_ret.Tables[0]; 
				Display_vcGantt_Head(dt_ret1);  

				DataTable dt_ret2 = ds_ret.Tables[1];  
				Display_vcGantt_Detail(dt_ret2);   

			}



			vcGantt.SuspendUpdate(false);



			this.Cursor = Cursors.Default;
			
			#endregion

 
//			_SelLine = arg_line;
//
//			System.Threading.Thread thread_run = new System.Threading.Thread(new System.Threading.ThreadStart(Refresh_vcGantt_Run));
//			thread_run.Start();
//
//			_PopForm = new FlexAPS.ProdBase.Pop_ProcessWait();
//			_PopForm.Processing();
//			_PopForm.Start(); 
//
//
//			// thread 종료 후 재 조회
//			thread_run.Abort();  



		}


		/// <summary>
		/// Refresh_vcGantt_Run : 
		/// </summary>
		private void Refresh_vcGantt_Run()
		{


			try
			{

				this.Cursor = Cursors.WaitCursor;
			

				//---------------------------------------------------------
				// Clear
				//---------------------------------------------------------
				vcGantt.SuspendUpdate(true); 
			
				string[] token = _SelLine.Split('/'); 


				for(int i = 0; i < token.Length; i++)
				{
					foreach(VcGroup group in vcGantt.GroupCollection)
					{ 
						if(group.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString() == token[i])
						{
							VcGroupCollection subGroupCltn = group.SubGroups;

							foreach(VcGroup subgroup in subGroupCltn)
							{
								VcNodeCollection nodeCltn = subgroup.NodeCollection;

								foreach(VcNode node in nodeCltn) node.Delete();

								subgroup.Delete();
							} 

							group.Delete();
						}
				
					} 
				} //end for i



				//---------------------------------------------------------
				// Search
				//---------------------------------------------------------
				for(int i = 0; i < token.Length; i++)
				{   
	
					DataSet ds_ret = Select_SPO_LOT_DAILY_LINE(token[i]); 

					DataTable dt_ret1 = ds_ret.Tables[0]; 
					Display_vcGantt_Head(dt_ret1);  

					DataTable dt_ret2 = ds_ret.Tables[1];  
					Display_vcGantt_Detail(dt_ret2);   

				}



				vcGantt.SuspendUpdate(false);
 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Refresh_vcGantt_Run", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
			finally 
			{ 
				//_PopForm.Close(); 
				this.Cursor = Cursors.Default;   
			} 

		}




		#endregion

		private void Event_Tbtn_Print()
		{ 

			VcPrinter v_printer =  vcGantt.Printer; 

			v_printer.PrintDate = true;
			v_printer.PageNumbers = true;
			v_printer.PageNumberMode = VcPageNumberMode.vcPageNOfM;  
			v_printer.FitToPage = false;
			v_printer.ZoomFactor = 100;
			v_printer.PageFrame = true; 
			v_printer.PageDescription = true;
			v_printer.PageDescriptionString = "        Plan Day : " + MyComFunction.ConvertDate2Type(dpick_FromYMD.Text)
				+ " ~ " + MyComFunction.ConvertDate2Type(dpick_ToYMD.Text) + "        "; 

			vcGantt.ShowPrintPreviewDialog();

		}
 
		

		#endregion 

		#region 그리드 이벤트 메서드


		private void Event_vcGantt_VcGroupLeftClicking(NETRONIC.XGantt.VcGroupClickingEventArgs e)
		{
			 
			string planymd = e.Group.NodeCollection.FirstNode().get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString();

			foreach(VcNode node in e.Group.NodeCollection)
			{
				//rts_ymd node 
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() == "0")
				{
					continue;
				}


				//released node
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_PLANSTATUS).ToString() == "D") 
				{
					planymd = node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString(); 
					planymd = Convert.ToDateTime(planymd).AddDays(1).ToString();
					continue;
				}
				
				if( Convert.ToDateTime(planymd).CompareTo(Convert.ToDateTime(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString() ) ) <= 0  ) continue;

				planymd = node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString();

				//break;

			}

			vcGantt.ScrollToDate(Convert.ToDateTime(planymd), VcHorizontalAlignment.vcLeftAligned, 1);

		}
 

		private void Event_vcGantt_VcGroupLeftDoubleClicking(string arg_factory, string arg_lot, string arg_line)
		{
 
			ProdPlan.Pop_SetLOTInformation pop_form = new ProdPlan.Pop_SetLOTInformation(arg_factory, arg_lot); 
			pop_form.ShowDialog();
  

			// 저장 된 후면 라인 reflesh 처리
			if(pop_form._CloseSave)
			{ 
				Refresh_vcGantt(arg_line);
			}


		} 
		
		
		private void Event_vcGantt_VcGroupRightClicking(NETRONIC.XGantt.VcGroupClickingEventArgs e)
		{

			e.ReturnStatus = VcReturnStatus.vcRetStatNoPopup;
  
			//---------------------------------------------------------------------
			int dir_count = 0;
			
			foreach(VcNode node in e.Group.NodeCollection)
			{
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() == "0") continue;
				
				// 작업지시 하루라도 나갔으면 실행할 수 없음
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_PLANSTATUS).ToString() == "D") 
				{
					dir_count++;
					break;
				}

//				//finish 된 것은 실행할 수 없음
//				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_FNISH_YN).ToString() != "N")
//				{
//					dir_count++;
//					break;
//				} 


			}

			if(dir_count > 0)
			{
				menuitem_CancelLOT.Visible = false; 
			}
			else
			{
				menuitem_CancelLOT.Visible = true; 
			}
			//---------------------------------------------------------------------



			//---------------------------------------------------------------------
			string real_lotyn = e.Group.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxREAL_LOTYN).ToString();
				 
			if(real_lotyn == "Y")
			{
				menuitem_ChangeLOT.Visible = false; 
			}
			else
			{
				menuitem_ChangeLOT.Visible = true;
				menuitem_ChangeLOT.Text = "Change Virtual LOT into Real LOT";
			}
			//---------------------------------------------------------------------



			



			cmenu_table.ShowContextMenu(vcGantt, new Point(e.X, e.Y));

			_SelGroup = e.Group; 


		}
  
		
		private void Event_vcGantt_VcNodeRightClicking(NETRONIC.XGantt.VcNodeClickingEventArgs e)
		{

			e.ReturnStatus = VcReturnStatus.vcRetStatNoPopup;  


			//---------------------------------------------------------------------
			// poweruser 권한이 아니면 oa closing 불가능 처리
			if(ClassLib.ComVar.This_PowerUser_YN == "Y")
			{
				//menuitem_OAClosing.Visible = true; 
				menuitem_OAClosing.Enabled = true; 
			}
			else
			{
				//menuitem_OAClosing.Visible = false; 
				menuitem_OAClosing.Enabled = false; 
			}
			//---------------------------------------------------------------------




			cmenu_diagram.ShowContextMenu(vcGantt, new Point(e.X, e.Y)); 
	
			_SelNode = e.Node;

		}


		private void Event_vcGantt_VcNodeLeftDoubleClicking(NETRONIC.XGantt.VcNodeClickingEventArgs e)
		{

			e.ReturnStatus = VcReturnStatus.vcRetStatFalse;


			//{factory, lot, order qty, loss qty} 
			string factory = cmb_Factory.SelectedValue.ToString();
			string lot = e.Node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString();
			string orderqty = e.Node.SuperGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT_QTY).ToString();
			string lossqty = e.Node.SuperGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOSS_QTY).ToString(); 
					   

			ProdPlan.Pop_LOTDaily_Modify pop_form = new ProdPlan.Pop_LOTDaily_Modify(factory, lot, orderqty, lossqty); 

			pop_form._ShipDateF_20 = _ShipDateF_20;
			pop_form._ShipDateT_20 = _ShipDateT_20;
			pop_form._ShipDateF_30 = _ShipDateF_30;
			pop_form._ShipDateT_30 = _ShipDateT_30;
			pop_form._ShipDateF_40 = _ShipDateF_40;
			pop_form._ShipDateT_40 = _ShipDateT_40;
			pop_form._ShipDateF_50 = _ShipDateF_50;

			pop_form._ClrShipDate_20 = _ClrShipDate_20;
			pop_form._ClrShipDate_30 = _ClrShipDate_30;
			pop_form._ClrShipDate_40 = _ClrShipDate_40;

			pop_form.ShowDialog();  
 
			if(pop_form._Save_Flag)
			{
				string line = e.Node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString();
				Refresh_vcGantt(line);
			}


		}
  

		private void Event_vcGantt_VcToolTipTextSupplying(NETRONIC.XGantt.VcToolTipTextSupplyingEventArgs e)
		{

			
			if (e.HitObjectType == VcObjectType.vcObjTypeNodeInDiagram)
			{ 
				VcNode node = (VcNode)e.HitObject;

				//day_seq == 0 이면 임의적으로 RTS_YMD 나타내는 것임
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() == "0")
				{
					string[] token = node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxRGAC).ToString().Split(' ');
					e.Text = "RGAC : " + token[0];
				}
				else
				{
					e.Text = "Day : " + node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ)
						+ "\r\n" + "Qty. : " + node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_SIZEQTY);
				} 
			}

		}



		#endregion

		#region 버튼 및 기타 이벤트 메서드


		private void Event_SelectedValueChanged_CmbFactory()
		{

			if(cmb_Factory.SelectedIndex == -1) return; 
			

			DataTable dt_ret;
			string year = "", frommonth = "", fromday = "", fromymd = "";
			string toyear = "", tomonth = "", today = "", toymd = "";
 
			//간트차트 초기화
			Clear_vcGantt();
 
			//일자 초기화
			year = System.DateTime.Now.Year.ToString(); 
			frommonth = System.DateTime.Now.Month.ToString().PadLeft(2, '0');
			fromday = "01";	
			fromymd = year + frommonth + fromday; 
			toyear = System.DateTime.Now.AddMonths(2).Year.ToString();
			tomonth = System.DateTime.Now.AddMonths(2).Month.ToString().PadLeft(2, '0');
			today = System.DateTime.DaysInMonth(Convert.ToInt32(toyear), Convert.ToInt32(tomonth)).ToString().PadLeft(2, '0');
			toymd = toyear + tomonth + today;  
			 

			dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(fromymd);
			dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(toymd); 
			


			if(ClassLib.ComVar.This_FormDate == "") 
			{
				ClassLib.ComVar.This_FormDate = fromymd;
				ClassLib.ComVar.This_ToDate = toymd;
			} 

			//obs type 리스트 할당  
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxOBS_Type);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OBSType, 1, 2, true, COM.ComVar.ComboList_Visible.Code);  
			cmb_OBSType.SelectedIndex = 0; 

			//line 리스트 할당
			dt_ret = ProdBase.Form_PB_Line.Select_SPB_LINE(cmb_Factory.SelectedValue.ToString() ); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineFrom, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineTo, 1, 2, true, COM.ComVar.ComboList_Visible.Name);

			dt_ret.Dispose();

		}




		#endregion

		#region 컨텍스트 메뉴 이벤트 메서드


		#region 테이블 영역

		
		/// <summary>
		/// Event_Click_menuitem_LOTInfo : 
		/// </summary>
		private void Event_Click_menuitem_LOTInfo()
		{
			
			string factory = cmb_Factory.SelectedValue.ToString();
			string lot = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString();  
			string line = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString();

			Event_vcGantt_VcGroupLeftDoubleClicking(factory, lot, line); 

		}


		/// <summary>
		/// Event_Click_menuitem_MoveLine : 
		/// </summary>
		private void Event_Click_menuitem_MoveLine()
		{

			string[] token = null;
			string factory = "", lot_no = "", lot_seq = "";
			string planymd = "", line_cd = "";
			int dir_dayseq_count = 0;
			bool run_flag = false;

			VcGroup preGroup = _SelGroup;   
			
			/////////////////////////////////////////////////////////////////////////////////////////////
			//작지 나간, finish 된 일자가 하루라도 있다면 한꺼번에 이동 불가
			//LOT 분할작업 실행
			/////////////////////////////////////////////////////////////////////////////////////////////
			foreach(VcNode node in _SelGroup.NodeCollection)
			{
				//rts_ymd node 제외
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() == "0") continue;
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_PLANSTATUS).ToString() != "L") dir_dayseq_count++; 
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_FNISH_YN).ToString() != "N") dir_dayseq_count++;  
			}

			if(dir_dayseq_count > 0) 
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
				string message = "Already Released or Already Finished" + "\r\n" + "Can't move line.";
				ClassLib.ComFunction.User_Message(message, "Move Line", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			
			/////////////////////////////////////////////////////////////////////////////////////////////
			//모두 작업지시 상태가 아니라면 라인 이동 가능
			//라인 업데이트 작업만 실행, 계획일자등은 MPS 화면상에서 다시 수정하도록 처리
			/////////////////////////////////////////////////////////////////////////////////////////////
			token = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString().Split('-');
			lot_no = token[0];
			lot_seq = token[1];
 

			foreach(VcNode node in _SelGroup.NodeCollection)
			{
				//rts_ymd node 제외
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() == "0") continue;
				
				planymd = Convert.ToDateTime(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S)).Year
					+ Convert.ToDateTime(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S)).Month.ToString().PadLeft(2, '0')
					+ Convert.ToDateTime(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S)).Day.ToString().PadLeft(2, '0');

				break;
				
			}
			
			//{factory, factory_name, lot_no, lot_seq, po_no, loadform_div}
			ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_Factory.SelectedValue.ToString(), cmb_Factory.Columns[1].Text,
																lot_no,
																lot_seq,
																planymd,
																((int)ClassLib.ComVar.FormLoadDIV_LOT.FromMPS).ToString()};

			ProdOrder.Pop_SetDirectLotDayily pop_form = new ProdOrder.Pop_SetDirectLotDayily(); 
			pop_form.dpick_PlanYMD.Enabled = false;
			pop_form.ShowDialog();  
			if(!pop_form._CloseSave) return; 

			//{line_cd, plan_start_ymd}
			line_cd = ClassLib.ComVar.Parameter_PopUp[0];

			//LINE_CD만 UPDATE
			factory = cmb_Factory.SelectedValue.ToString();

			run_flag = RUN_LOT_ALL_DAYSEQ_MOVE(factory, lot_no, lot_seq, line_cd); 
			
			if(!run_flag) 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
				return; 
			}
			
			Refresh_vcGantt(preGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString()
				+ "/" + line_cd);
 
			 

		}



		/// <summary>
		/// Event_Click_menuitem_ChangeLOT : 
		/// </summary>
		private void Event_Click_menuitem_ChangeLOT()
		{
 
			string lot = "", lot_no = "", lot_seq = "";
			bool save_flag = false; 
 
			DialogResult message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this);
			if(message_result == DialogResult.No) return; 

			lot = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString();  
			string[] token = lot.Split('-');
			lot_no = token[0];
			lot_seq = token[1];
 

			string real_yn = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxREAL_LOTYN).ToString();

			if(real_yn == "N")
			{
				save_flag = Update_ChangeLOT(cmb_Factory.SelectedValue.ToString(), lot_no, lot_seq);
			} 
 
			if(!save_flag)
			{
				//정상실행 안됨
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this); 
				Refresh_vcGantt(_SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString());

			}



		}


		/// <summary>
		/// Event_Click_menuitem_CancelLOT : 
		/// </summary>
		private void Event_Click_menuitem_CancelLOT()
		{
 
			string planst = "";
			string finish_yn = "";


			string factory = cmb_Factory.SelectedValue.ToString();
			string[] token = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString().Split('-');
			string lot_no = token[0];
			string lot_seq = token[1];




			// 작업지시 여부
			planst = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT_PLANYN).ToString();

			if(planst == "Y")
			{
				ClassLib.ComFunction.Data_Message("Already Released", ClassLib.ComVar.MgsDoNotRun, this);
				return;
			}


			// finish 여부
			finish_yn = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_FNISH_YN).ToString();

			if(finish_yn == "Y")
			{
				ClassLib.ComFunction.Data_Message("Already Finished",ClassLib.ComVar.MgsDoNotRun, this);
				return;
			}


			// shipping area check
			//shipping 되고 있는 구간인 40 이전 구간에 대해서는 경고 표시
			//LOT이 shipping 40 이전 구간에 하루라도 걸려 있으면 경고 표시
			foreach(VcNode day_node in _SelGroup.NodeCollection)
			{
					
				if(day_node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() == "0") continue;

				if(Convert.ToDateTime(day_node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S) ) < Convert.ToDateTime(Convert_ToDate(_ShipDateF_50).ToString("yy.MM.dd") ) )
				{ 
					ClassLib.ComFunction.User_Message("Shipping area. Can't cancel LOT.", "LOT Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return; 
				} 
							
					
			} 



			// shipping 구간에 걸려 있었지만 임의로 일자 딜레이 후 삭제하려는 경우 발생
			// sbm_shipping_shecdule 에 한번이라도 만들어져 있으면 삭제 못하도록 한번 더 경고 표시
			bool ss_already_create_flag = FlexAPS.ProdOrder.Form_PO_Lot.Check_Shipping_Area(factory, lot_no, lot_seq);

			if (ss_already_create_flag)
			{

				ClassLib.ComFunction.User_Message("Already create shipping schedule. Can't cancel LOT.", "LOT Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;

			}



			DialogResult message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this);
			if(message_result == DialogResult.No) return; 

			
			bool save_flag = Cancel_Assigned_LOT(factory, lot_no, lot_seq);

			if(! save_flag)
			{
				//정상실행 안됨
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this); 
				Refresh_vcGantt(_SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString());

			}

				

		}
 


		/// <summary>
		/// Event_Click_menuitem_LOTSize : 
		/// </summary>
		/// <param name="arg_forecast_flag">forecast 일때, 생성자 파라미터 : true</param>
		private void Event_Click_menuitem_LOTSize(bool arg_forecast_flag)
		{

			Form_PO_LOTAddLoss pop_form = null;

			// forecast 일때, 생성자 파라미터 : true
			if(arg_forecast_flag)
			{
				pop_form = new Form_PO_LOTAddLoss(true);  
			}
			else
			{
				pop_form = new Form_PO_LOTAddLoss();  
			}

			
			string obsid = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxOBS_ID).ToString();
			string stylecd = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxSTYLE_CD).ToString(); 
			string[] token = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString().Split('-'); 

			ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_Factory.SelectedValue.ToString(), token[0], token[1], obsid, stylecd};
			pop_form.ShowDialog(); 
  
			
			if(! arg_forecast_flag)
			{
				Refresh_vcGantt(_SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString());
			} 
			 


		}




		/// <summary>
		/// Event_Click_menuitem_DelayProduction : 
		/// </summary>
		private void Event_Click_menuitem_DelayProduction()
		{

			this.Cursor = Cursors.WaitCursor;


			
			string factory = cmb_Factory.SelectedValue.ToString();
			string linecd = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString();
			string line_name = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_NAME).ToString();
			string model_name = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxMODEL_NAME).ToString();
			string stylecd = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxSTYLE_CD).ToString();
			string gen = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxGEN).ToString();
			string lot = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString(); 

			FlexAPS.ProdPlan.Pop_LOTDaily_DelayProduction pop_form = new FlexAPS.ProdPlan.Pop_LOTDaily_DelayProduction(factory, linecd, line_name, model_name, stylecd, gen, lot);

			pop_form._ShipDateF_20 = _ShipDateF_20;
			pop_form._ShipDateT_20 = _ShipDateT_20;
			pop_form._ShipDateF_30 = _ShipDateF_30;
			pop_form._ShipDateT_30 = _ShipDateT_30;
			pop_form._ShipDateF_40 = _ShipDateF_40;
			pop_form._ShipDateT_40 = _ShipDateT_40;
			pop_form._ShipDateF_50 = _ShipDateF_50;

			pop_form._ClrShipDate_20 = _ClrShipDate_20;
			pop_form._ClrShipDate_30 = _ClrShipDate_30;
			pop_form._ClrShipDate_40 = _ClrShipDate_40;

			pop_form.ShowDialog();
			if(!pop_form._Save_Flag) return;

			Refresh_vcGantt(_SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString());


			this.Cursor = Cursors.Default;


		}

 

		/// <summary>
		/// Event_Click_menuitem_LastInv : 
		/// </summary>
		private void Event_Click_menuitem_LastInv()
		{
			

			this.Cursor = Cursors.WaitCursor;


			
			string factory = cmb_Factory.SelectedValue.ToString();
			string linecd = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString();
			string line_name = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_NAME).ToString();
			string model_name = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxMODEL_NAME).ToString();
			string stylecd = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxSTYLE_CD).ToString();
			string gen = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxGEN).ToString();
			string lot = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString(); 

			FlexAPS.ProdPlan.Pop_LOTMold_Inv pop_form = new FlexAPS.ProdPlan.Pop_LOTMold_Inv(factory, linecd, line_name, model_name, stylecd, gen, lot);
			pop_form.ShowDialog();



			this.Cursor = Cursors.Default;


		}


		/// <summary>
		/// Event_Click_menuitem_DisplaySize : 
		/// </summary>
		private void Event_Click_menuitem_DisplaySize()
		{

			string planymd = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString();

			foreach(VcNode node in _SelGroup.NodeCollection)
			{
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() == "0") continue;
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_PLANSTATUS).ToString() != "L") continue;

				planymd = node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString();
				break;
			}

			string linecd = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString();
			string lot = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString(); 

			ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_Factory.SelectedValue.ToString(), planymd, linecd, lot};
 
					 
			if(ClassLib.ComVar.FormDailySize == null)
			{
				ClassLib.ComVar.FormDailySize = new Form_PO_LOTDailySize(); 
				ClassLib.ComVar.FormDailySize._DirectlyMPS = true; 
				ClassLib.ComVar.FormDailySize.ShowDialog();
				Refresh_vcGantt(linecd);
			}
			else
			{
				ClassLib.ComVar.FormDailySize.Select();
			}


		}


		/// <summary>
		/// Event_Click_menuitem_MiniLine : 
		/// </summary>
		private void Event_Click_menuitem_MiniLine()
		{

			string planymd = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString();

			foreach(VcNode node in _SelGroup.NodeCollection)
			{
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() == "0") continue;
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_PLANSTATUS).ToString() != "L") continue;

				planymd = node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString();
				break;
			}

			string linecd = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString();

			planymd = Convert.ToString(Convert.ToDateTime(planymd).ToString("yyyyMMdd"));

			ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_Factory.SelectedValue.ToString(), planymd, linecd};

			Form_PO_LOTDailyMini pop_form = new Form_PO_LOTDailyMini();
			ClassLib.ComVar.FormClick_Flag = true;
			pop_form.Show(); 


		}


		/// <summary>
		/// Event_Click_menuitem_TS : 
		/// </summary>
		private void Event_Click_menuitem_TS()
		{

			string planymd = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString();

			foreach(VcNode node in _SelGroup.NodeCollection)
			{
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() == "0") continue;
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_PLANSTATUS).ToString() != "L") continue;

				planymd = node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString();
				break;
			}

			string linecd = _SelGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString();

			planymd = Convert.ToString(Convert.ToDateTime(planymd).ToString("yyyyMMdd"));

			ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_Factory.SelectedValue.ToString(), planymd, linecd};

			ProdSheet.Form_PD_LOTDaily_MiniSize_TS pop_form = new ProdSheet.Form_PD_LOTDaily_MiniSize_TS();
			ClassLib.ComVar.FormClick_Flag = true;
			pop_form.Show(); 


		}




		#endregion

		#region 다이어그램 영역


		private void Event_Click_menuitem_MoveLOT()
		{

			string[] token = null;
			string lot_no = "", lot_seq = "";
			string planymd = "", line_cd = "", day_seq = ""; 
			string lot_all_before_40_flag = "Y";

			 
			/////////////////////////////////////////////////////////////////////////////////////////////
			//작지 나간 일자 이동 불가 
			if(_SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_PLANSTATUS).ToString() != "L") 
			{
				ClassLib.ComFunction.Data_Message("Already Released",ClassLib.ComVar.MgsDoNotRun, this);
				return;
			}

			//finish 된 것은 실행할 수 없음
			if(_SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_FNISH_YN).ToString() != "N")
			{
				ClassLib.ComFunction.Data_Message("Already Finished",ClassLib.ComVar.MgsDoNotRun, this);
				return;
			} 
			///////////////////////////////////////////////////////////////////////////////////////////// 

 
 
			token = _SelNode.SuperGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString().Split('-');
			lot_no = token[0];
			lot_seq = token[1];

			planymd = Convert.ToDateTime(_SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S)).Year
				+ Convert.ToDateTime(_SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S)).Month.ToString().PadLeft(2, '0')
				+ Convert.ToDateTime(_SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S)).Day.ToString().PadLeft(2, '0');
			 
			line_cd = _SelNode.SuperGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString();
			day_seq = _SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString(); 

 

			// 하루라도 SHIPPING 40 이후에 있을 경우
			foreach(VcNode day_node in _SelNode.SuperGroup.NodeCollection)
			{
				if(Convert.ToInt32(day_node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() ) != 0)
				{

					if(Convert.ToDateTime(day_node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S) ) >= Convert.ToDateTime(Convert_ToDate(_ShipDateF_50).ToString("yy.MM.dd") ) )
					{ 
						lot_all_before_40_flag = "N";
					} 
								
				}
							 
			} // end foreach

 

			//{factory, factory_name, lot_no, lot_seq, po_no, loadform_div, line_cd}
			COM.ComVar.Parameter_PopUp = new string[] {cmb_Factory.SelectedValue.ToString(), 
														  cmb_Factory.Columns[1].Text,
														  lot_no,
														  lot_seq,
														  planymd,
														  ((int)ClassLib.ComVar.FormLoadDIV_LOT.FromMPSMove).ToString(), 
														  line_cd,
														  day_seq,
														  _ShipDateF_50,
														  lot_all_before_40_flag};

			ProdOrder.Pop_SetDirectLotDayily pop_form = new ProdOrder.Pop_SetDirectLotDayily(); 
			pop_form.cmb_LineCd.Enabled = false;
			pop_form.ShowDialog();  
			if(!pop_form._CloseSave) return;
  
			Refresh_vcGantt(line_cd);
  

		}



		

		/// <summary>
		/// Event_Click_menuitem_Divide_Merge_LOT : 
		/// </summary>
		/// <param name="arg_division"></param>
		private void Event_Click_menuitem_Divide_Merge_LOT(ClassLib.ComVar.MPS_LOT_Action arg_division)
		{
  

			bool password_check = false;

			 
			foreach (VcNode node in vcGantt.NodeCollection) 
			{
				if(node.Marked == false) continue;
					
				//rts_ymd 노드 제외
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() == "0") continue;
				
				//작업지시 나간 dayseq 포함되어 있으면 실행할 수 없음
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_PLANSTATUS).ToString() != "L")
				{
					ClassLib.ComFunction.Data_Message("Already Released", ClassLib.ComVar.MgsDoNotRun, this);
					return;
				}

				//finish 된 것은 실행할 수 없음
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_FNISH_YN).ToString() != "N")
				{
					ClassLib.ComFunction.Data_Message("Already Finished",ClassLib.ComVar.MgsDoNotRun, this);
					return;
				}


				//shipping 되고 있는 구간인 40 이전 구간에 대해서는 경고 표시
				if(Convert.ToDateTime(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S) ) < Convert.ToDateTime(Convert_ToDate(_ShipDateF_50).ToString("yy.MM.dd") ) )
				{
					 
					// poweruser 권한이면, 비밀번호 인증 후. 작업 가능 처리
					if(ClassLib.ComVar.This_PowerUser_YN == "Y")
					{

						Pop_Password pop_password = new Pop_Password();
						pop_password.ShowDialog();

						// 비밀번호 인증 캔슬이거나, 비밀번호 인증 실패일 경우 처리 불가능
						if(! pop_password._Apply_Flag) return;
						if(! pop_password._Password_OK_Flag) return;

						password_check = true;


					}
					else
					{
						ClassLib.ComFunction.User_Message("Shipping area. Can't divide LOT.", "LOT Divide", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}


				} 

				//LOT이 shipping 40 이전 구간에 하루라도 걸려 있으면 경고 표시
				if(Convert.ToDateTime(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S) ) >=  Convert.ToDateTime(Convert_ToDate(_ShipDateF_30).ToString("yy.MM.dd") ) 
					&& Convert.ToInt32(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() ) > 1)
				{

					foreach(VcNode day_node in node.SuperGroup.NodeCollection)
					{
						if(Convert.ToInt32(day_node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString() ) == 1)
						{

							if(Convert.ToDateTime(day_node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S) ) < Convert.ToDateTime(Convert_ToDate(_ShipDateF_50).ToString("yy.MM.dd") ) )
							{
								 

								// poweruser 권한이면, 비밀번호 인증 후. 작업 가능 처리
								if(ClassLib.ComVar.This_PowerUser_YN == "Y")
								{

									if(! password_check)
									{
										Pop_Password pop_password = new Pop_Password();
										pop_password.ShowDialog();

										// 비밀번호 인증 캔슬이거나, 비밀번호 인증 실패일 경우 처리 불가능
										if(! pop_password._Apply_Flag) return;
										if(! pop_password._Password_OK_Flag) return;
									}



								}
								else
								{
									ClassLib.ComFunction.User_Message("Shipping area. Can't divide LOT.", "LOT Divide", MessageBoxButtons.OK, MessageBoxIcon.Information);
									return;
								}


							} 
							
						}
							
					} // end foreach

				}
				//사이즈 전개 안된 dayseq 포함되어 있으면 실행할 수 없음
				if(node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAILY_SIZEYN).ToString() == "N")
				{
					ClassLib.ComFunction.Data_Message("Not Yet Assign Size", ClassLib.ComVar.MgsDoNotRun, this);
					return;
				}

			}

 




			string factory = cmb_Factory.SelectedValue.ToString();
			string obs_id = _SelNode.SuperGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxOBS_ID).ToString();
			string obs_type = _SelNode.SuperGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxOBS_TYPE).ToString();
			string model = _SelNode.SuperGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxMODEL_NAME).ToString();
			string style = _SelNode.SuperGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxSTYLE_CD).ToString(); 
			string gender = _SelNode.SuperGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxGEN).ToString(); 
			
			string[] token = _SelNode.SuperGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString().Split('-');
			string lot_no = token[0];
			string lot_seq = token[1];

			string line_cd = _SelNode.SuperGroup.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString(); 
			 
 
			string[] pop_parameter = new string[] {factory, obs_id, obs_type, model, style, gender, lot_no, lot_seq, line_cd};


			Pop_LOTDivide_Merge pop_form = new Pop_LOTDivide_Merge(arg_division, pop_parameter);
			pop_form.ShowDialog();


			if(! pop_form._CloseSave) return; 

			Refresh_vcGantt(line_cd + "/" + pop_form._LineCdNew);

		}




		/// <summary>
		/// Event_Click_menuitem_DisplayDaySize : 
		/// </summary>
		private void Event_Click_menuitem_DisplayDaySize()
		{

			if(cmb_Factory.SelectedIndex == -1) return;

			string factory = cmb_Factory.SelectedValue.ToString();
			string planymd = _SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxPLAN_YMD_S).ToString();
			string linecd = _SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString();
			string lot = _SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString();  

			ClassLib.ComVar.Parameter_PopUp = new string[] {factory, planymd, linecd, lot};
  
			ClassLib.ComVar.FormDailySize = new Form_PO_LOTDailySize(); 
			ClassLib.ComVar.FormDailySize._DirectlyMPS = true; 
			ClassLib.ComVar.FormDailySize.ShowDialog();

			Refresh_vcGantt(linecd); 


		}



		/// <summary>
		/// Event_Click_menuitem_OAClosing : 
		/// </summary>
		private void Event_Click_menuitem_OAClosing()
       {


			string factory = cmb_Factory.SelectedValue.ToString();
			string linecd = _SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString();
			string lot = _SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString();  
			string[] token = lot.Split('-');
			string lot_no = token[0];
			string lot_seq = token[1];
			string day_seq = _SelNode.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString();



			bool last_day_seq = false;

			// 마지막 일자만 가능하도록 처리
			foreach(VcNode day_node in _SelNode.SuperGroup.NodeCollection)
			{

				string now_day_seq = day_node.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxDAY_SEQ).ToString();

				if(Convert.ToInt32(now_day_seq) > Convert.ToInt32(day_seq) )
				{
					last_day_seq = false;
					break;
				}
				else
				{
					last_day_seq = true;
				}
							
			} // end foreach


			if(! last_day_seq)
			{
				ClassLib.ComFunction.User_Message("You must selecte last day sequence.", "OA Clsoing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}




			bool password_check = false;

			// poweruser 권한이면, 비밀번호 인증 후. 작업 가능 처리
			if(ClassLib.ComVar.This_PowerUser_YN != "Y") return;
			

			if(! password_check)
			{

				Pop_Password pop_password = new Pop_Password();
				pop_password.ShowDialog();

				// 비밀번호 인증 캔슬이거나, 비밀번호 인증 실패일 경우 처리 불가능
				if(! pop_password._Apply_Flag) return;
				if(! pop_password._Password_OK_Flag) return;

			}



			// 비밀번호 인증 통과 후 프로시저 실행하여 바로 작업
			DialogResult message_result = ClassLib.ComFunction.Data_Message("OA Clsoing", ClassLib.ComVar.MgsChooseRun, this);

			if(message_result == DialogResult.No) return;



			


			bool run_flag = RUN_SPO_LOT_OA_CLOSING(factory, lot_no, lot_seq, day_seq);


			if(run_flag)
			{
				ClassLib.ComFunction.Data_Message("OA Clsoing", ClassLib.ComVar.MgsEndRun, this);
				Refresh_vcGantt(linecd); 
			}
			else
			{
				ClassLib.ComFunction.Data_Message("OA Clsoing", ClassLib.ComVar.MgsDoNotRun, this);
				return;
			}

			





		}




		#endregion


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
				//this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Search(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				//this.Cursor = Cursors.Default;
			}

		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Print();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}



		#endregion

		#region 그리드 이벤트
 

		private void vcGantt_VcGroupLeftClicking(object sender, NETRONIC.XGantt.VcGroupClickingEventArgs e)
		{
			try
			{
				Event_vcGantt_VcGroupLeftClicking(e);	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_vcGantt_VcGroupLeftClicking", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		
		}

		private void vcGantt_VcGroupLeftDoubleClicking(object sender, NETRONIC.XGantt.VcGroupClickingEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string factory = cmb_Factory.SelectedValue.ToString();
				string lot = e.Group.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLOT).ToString(); 
				string line = e.Group.get_DataField((int)ClassLib.TBSPO_LOT_DAILY_vcGANTT.IxLINE_CD).ToString();

				Event_vcGantt_VcGroupLeftDoubleClicking(factory, lot, line);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "vcGantt_VcGroupLeftDoubleClicking", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void vcGantt_VcGroupRightClicking(object sender, NETRONIC.XGantt.VcGroupClickingEventArgs e)
		{
			try
			{
				 Event_vcGantt_VcGroupRightClicking(e);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_vcGantt_VcGroupRightClicking", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void vcGantt_VcNodeCreating(object sender, NETRONIC.XGantt.VcNodeCreatingEventArgs e)
		{
			try
			{
				 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "vcGantt_VcNodeCreating", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void vcGantt_VcNodeDeleting(object sender, NETRONIC.XGantt.VcNodeDeletingEventArgs e)
		{
			try
			{
				 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "vcGantt_VcNodeDeleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		} 

		private void vcGantt_VcNodeModifying(object sender, NETRONIC.XGantt.VcNodeModifyingEventArgs e)
		{
			try
			{
				 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "vcGantt_VcNodeModifying", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void vcGantt_VcNodeLeftDoubleClicking(object sender, NETRONIC.XGantt.VcNodeClickingEventArgs e)
		{
			try
			{
				Event_vcGantt_VcNodeLeftDoubleClicking(e); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_vcGantt_VcNodeLeftDoubleClicking", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		} 

		private void vcGantt_VcNodeRightClicking(object sender, NETRONIC.XGantt.VcNodeClickingEventArgs e)
		{ 
			try
			{
				Event_vcGantt_VcNodeRightClicking(e);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_vcGantt_VcNodeRightClicking", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}
 
		private void vcGantt_VcToolTipTextSupplying(object sender, NETRONIC.XGantt.VcToolTipTextSupplyingEventArgs e)
		{

			try
			{
				Event_vcGantt_VcToolTipTextSupplying(e);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_vcGantt_VcToolTipTextSupplying", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				Event_SelectedValueChanged_CmbFactory();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_CmbFactory", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}  


		private void cmb_OBSType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
			try
			{
				
				if(cmb_Factory.SelectedIndex == -1 || cmb_OBSType.SelectedIndex == -1) return;

				this.Cursor = Cursors.WaitCursor; 
				//간트차트 초기화
				Clear_vcGantt();   
				this.Cursor = Cursors.Default;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_OBSType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		
		private void dpick_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{ 
				
				DateTimePicker src = sender as DateTimePicker; 
				src.CustomFormat = ClassLib.ComVar.This_SetedDateType;
 

				if(src.CustomFormat == " " || src.Value.ToString().Trim() == "") return;

				if(src.Name == "dpick_FromYMD")
				{
					//vcGantt.TimeScaleStart = Convert.ToDateTime(Convert_ToDate(MyComFunction.ConvertDate2DbType(dpick_FromYMD.Value.ToString() )).ToString("yy.MM.dd"));
					vcGantt.TimeScaleStart = Convert.ToDateTime(Convert_ToDate( dpick_FromYMD.Value.ToString("yyyyMMdd") ).ToString("yy.MM.dd"));
				}
				else if(src.Name == "dpick_ToYMD")
				{
					//vcGantt.TimeScaleEnd = Convert.ToDateTime(Convert_ToDate(MyComFunction.ConvertDate2DbType(dpick_ToYMD.Value.ToString() )).ToString("yy.MM.dd")); 
					vcGantt.TimeScaleEnd = Convert.ToDateTime(Convert_ToDate( dpick_ToYMD.Value.ToString("yyyyMMdd") ).ToString("yy.MM.dd")); 
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		


		private void btn_AssignSize_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				
				if(cmb_Factory.SelectedIndex == -1) return;

				string factory = cmb_Factory.SelectedValue.ToString();
				string from_plan_ymd =  dpick_FromYMD.Text;
				string to_plan_ymd = dpick_ToYMD.Text;

				ProdPlan.Pop_MPSDeploySize pop_form = new ProdPlan.Pop_MPSDeploySize(factory, from_plan_ymd, to_plan_ymd);  
				pop_form.Show(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_OBSType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		#endregion

		#region 컨텍스트 메뉴 이벤트
		

		#region 테이블 영역

		private void menuitem_LOTInfo_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Click_menuitem_LOTInfo();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_LOTInfo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		} 
 
		private void menuitem_MoveLine_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Event_Click_menuitem_MoveLine();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_MoveLine", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void menuitem_ChangeLOT_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Event_Click_menuitem_ChangeLOT();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_ChangeLOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void menuitem_CancelLOT_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				this.Cursor = Cursors.WaitCursor;
 
				Event_Click_menuitem_CancelLOT();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_CancelLOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void menuitem_LOTSize_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Click_menuitem_LOTSize(false);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_LOTSize", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 
		

		
		private void menuitem_DelayProduction_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				Event_Click_menuitem_DelayProduction();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_DelayProduction", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		
		private void menuitem_LastInv_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Click_menuitem_LastInv();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_LastInv", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuitem_DisplaySize_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Click_menuitem_DisplaySize();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_DisplaySize", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		private void menuitem_MiniLine_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Click_menuitem_MiniLine();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_MiniLine", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuitem_TS_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Click_menuitem_TS();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_TS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuitem_LOTForecast_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
			
				Event_Click_menuitem_LOTSize(true);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_LOTForecast_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		
		#endregion  
		
		#region 다이어그램 영역

		private void menuitem_MoveLOT_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{  
				Event_Click_menuitem_MoveLOT(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_MoveLOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}  

		private void menuitem_DLOT_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{   
				Event_Click_menuitem_Divide_Merge_LOT(ClassLib.ComVar.MPS_LOT_Action.Divide); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_Divide_Merge_LOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void menuitem_MLOT_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Click_menuitem_Divide_Merge_LOT(ClassLib.ComVar.MPS_LOT_Action.Merge); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void menuitem_DisplayDaySize_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Click_menuitem_DisplayDaySize();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_DisplayDaySize", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void menuitem_OAClosing_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Click_menuitem_OAClosing();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_menuitem_OAClosing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		


		#endregion

		#endregion
 

		#endregion

		#region 디비 연결
   

		#region 조회


		/// <summary>
		/// Select_SPO_LOT_DAYILY : SPO_LOT_DAYILY 리스트
		/// </summary>
		private DataSet Select_SPO_LOT_DAILY()
		{
			
			try
			{ 

				
				DataSet ds_ret;


				//--------------------------------------------------------
				// head
				//--------------------------------------------------------
				string process_name = "PKG_SPO_MPS_BSC.SELECT_LOT_DAILY_HEAD";

				MyOraDB.ReDim_Parameter(11); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROMYMD";
				MyOraDB.Parameter_Name[2] = "ARG_TOYMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[4] = "ARG_LINE_CD_FROM";
				MyOraDB.Parameter_Name[5] = "ARG_LINE_CD_TO";
				MyOraDB.Parameter_Name[6] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[7] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[8] = "ARG_DISPLAY_VLOT_ONLY";
				MyOraDB.Parameter_Name[9] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[10] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;
			   
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
				MyOraDB.Parameter_Values[2] = MyComFunction.ConvertDate2DbType(dpick_ToYMD.Text); 
				MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_String(ClassLib.ComVar.This_Line, " ");

				if(cmb_LineFrom.SelectedIndex == -1 || cmb_LineFrom.SelectedValue.ToString().Trim() == "")
				{
					MyOraDB.Parameter_Values[4] = "-1";
				}
				else
				{
					MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_LineFrom, "-1");
				}

				if(cmb_LineTo.SelectedIndex == -1 || cmb_LineTo.SelectedValue.ToString().Trim() == "")
				{
					MyOraDB.Parameter_Values[5] = "-1";
				}
				else
				{
					MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(cmb_LineTo, "-1");
				}
 
				MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_Combo(cmb_OBSType, " "); 
				MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " "); 
				MyOraDB.Parameter_Values[8] = (chk_OnlyVLot.Checked) ? "N" : " ";
				MyOraDB.Parameter_Values[9] = ClassLib.ComVar.This_User;
				MyOraDB.Parameter_Values[10] = "";

				MyOraDB.Add_Select_Parameter(true);
				//-------------------------------------------------------- 

				//--------------------------------------------------------
				// detail
				//--------------------------------------------------------
				process_name = "PKG_SPO_MPS_BSC.SELECT_LOT_DAILY_DETAIL";

				MyOraDB.ReDim_Parameter(11); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROMYMD";
				MyOraDB.Parameter_Name[2] = "ARG_TOYMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[4] = "ARG_LINE_CD_FROM";
				MyOraDB.Parameter_Name[5] = "ARG_LINE_CD_TO";
				MyOraDB.Parameter_Name[6] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[7] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[8] = "ARG_DISPLAY_VLOT_ONLY";
				MyOraDB.Parameter_Name[9] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[10] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;
			   
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
				MyOraDB.Parameter_Values[2] = MyComFunction.ConvertDate2DbType(dpick_ToYMD.Text); 
				MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_String(ClassLib.ComVar.This_Line, " ");

				if(cmb_LineFrom.SelectedIndex == -1 || cmb_LineFrom.SelectedValue.ToString().Trim() == "")
				{
					MyOraDB.Parameter_Values[4] = "-1";
				}
				else
				{
					MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_LineFrom, "-1");
				}

				if(cmb_LineTo.SelectedIndex == -1 || cmb_LineTo.SelectedValue.ToString().Trim() == "")
				{
					MyOraDB.Parameter_Values[5] = "-1";
				}
				else
				{
					MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(cmb_LineTo, "-1");
				}
 
				MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_Combo(cmb_OBSType, " "); 
				MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " "); 
				MyOraDB.Parameter_Values[8] = (chk_OnlyVLot.Checked) ? "N" : " ";
				MyOraDB.Parameter_Values[9] = ClassLib.ComVar.This_User;
				MyOraDB.Parameter_Values[10] = "";

				MyOraDB.Add_Select_Parameter(false); 
				//-------------------------------------------------------- 


				//--------------------------------------------------------
				// shipping area
				//--------------------------------------------------------
				process_name = "PKG_SPO_MPS_BSC.SELECT_SBM_SHIPPING_MASTER";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			   
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(false); 
				//-------------------------------------------------------- 


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
		/// Select_SPO_LOT_DAILY_LINE :  
		/// </summary>
		private DataSet Select_SPO_LOT_DAILY_LINE(string arg_linecd)
		{
			DataSet ds_ret;

			try
			{ 
				string process_name = "PKG_SPO_MPS_BSC.SELECT_LOT_DAILY_LINE_HEAD";

				MyOraDB.ReDim_Parameter(9); 
 
				MyOraDB.Process_Name = process_name;  

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROMYMD";
				MyOraDB.Parameter_Name[2] = "ARG_TOYMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_CD"; 
				MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[6] = "ARG_DISPLAY_VLOT_ONLY";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[8] = "OUT_CURSOR"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;
			   
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
				MyOraDB.Parameter_Values[2] = MyComFunction.ConvertDate2DbType(dpick_ToYMD.Text); 
				MyOraDB.Parameter_Values[3] = arg_linecd; 
				MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_OBSType, " "); 
				MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " "); 
				MyOraDB.Parameter_Values[6] = (chk_OnlyVLot.Checked) ? "N" : " ";
				MyOraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;
				MyOraDB.Parameter_Values[8] = ""; 



				MyOraDB.Add_Select_Parameter(true); 


				process_name = "PKG_SPO_MPS_BSC.SELECT_LOT_DAILY_LINE_DETAIL";

				MyOraDB.ReDim_Parameter(9); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROMYMD";
				MyOraDB.Parameter_Name[2] = "ARG_TOYMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_CD"; 
				MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[6] = "ARG_DISPLAY_VLOT_ONLY";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[8] = "OUT_CURSOR"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;
			   
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
				MyOraDB.Parameter_Values[2] = MyComFunction.ConvertDate2DbType(dpick_ToYMD.Text); 
				MyOraDB.Parameter_Values[3] = arg_linecd; 
				MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_OBSType, " "); 
				MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " "); 
				MyOraDB.Parameter_Values[6] = (chk_OnlyVLot.Checked) ? "N" : " ";
				MyOraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;
				MyOraDB.Parameter_Values[8] = ""; 


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



		#endregion

		#region Line Move (All)

		/// <summary>
		/// RUN_LOT_ALL_DAYSEQ_MOVE : LOT 전체 라인 이동에 따른 SPO 관련 테이블 UPDATE
		/// </summary>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		/// <param name="arg_linecd"></param>
		private bool RUN_LOT_ALL_DAYSEQ_MOVE(string arg_factory, string arg_lotno, string arg_lotseq, string arg_linecd)
		{

			try
			{
				
				int col_ct = 5;

				MyOraDB.ReDim_Parameter(col_ct); 
 
				MyOraDB.Process_Name = "PKG_SPO_MPS_BSC.RUN_LOT_ALL_DAYSEQ_MOVE";
   
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO"; 
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_LINE_CD";  
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";
		    
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_lotno;
				MyOraDB.Parameter_Values[2] = arg_lotseq; 
				MyOraDB.Parameter_Values[3] = arg_linecd; 
				MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User; 
			
				MyOraDB.Add_Modify_Parameter(true);  
				MyOraDB.Exe_Modify_Procedure();
				return true;

			}
			catch
			{
				return false;
			}
		}


		#endregion

		#region Change LOT (가상 LOT -> 실제 LOT)


		/// <summary>
		/// Update_ChangeLOT : 가상 LOT를 실제 LOT으로 바꾸는 작업 - RealYN = 'Y'로
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		public bool Update_ChangeLOT(string arg_factory, string arg_lotno, string arg_lotseq)
		{
			
			try
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(4); 
 
				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SPO_MPS_BSC.UPDATE_CHANGE_LOT";    
 
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";  
								
				//03.DATA TYPE
				for (int i = 0; i <= 3; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			

			
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_lotno;
				MyOraDB.Parameter_Values[2] = arg_lotseq; 
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;  

				MyOraDB.Add_Modify_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Modify_Procedure(); 
			 
				if(ds_ret == null) 
					return false;
				else
					return true;
			}
			catch
			{
				return false;
			}

		}


		#endregion 

		#region Cancel LOT (라인 할당 취소)


		/// <summary>
		/// Cancel_Assigned_LOT : LOT 라인 할당 취소
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		private bool Cancel_Assigned_LOT(string arg_factory, string arg_lotno, string arg_lotseq)
		{
			DataSet ds_ret;

			try
			{
				MyOraDB.ReDim_Parameter(4); 
 
				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SPO_MPS_BSC.CANCEL_ASSIGNED_LOT";    
 
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";  
								
				//03.DATA TYPE
				for (int i = 0; i <= 3; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			

			
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_lotno;
				MyOraDB.Parameter_Values[2] = arg_lotseq; 
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;  

				MyOraDB.Add_Modify_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Modify_Procedure();		 
 
				if(ds_ret == null) 
					return false; 
				else
					return true;
			}
			catch
			{
				return false; 
			}

		}


		#endregion 

		#region LOT OA Clsoing


		/// <summary>
		/// RUN_SPO_LOT_OA_CLOSING : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <param name="arg_day_seq"></param>
		/// <returns></returns>
		private bool RUN_SPO_LOT_OA_CLOSING(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_day_seq)
		{

			DataSet ds_ret;

			try
			{
				MyOraDB.ReDim_Parameter(5); 
 
				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SPO_LOT_OA_BSC.RUN_SPO_LOT_OA_CLOSING";    
 
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_DAY_SEQ"; 
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";  
								
				//03.DATA TYPE
				for (int i = 0; i < 5; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			

			
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_lot_no;
				MyOraDB.Parameter_Values[2] = arg_lot_seq; 
				MyOraDB.Parameter_Values[3] = arg_day_seq; 
				MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;  

				MyOraDB.Add_Modify_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Modify_Procedure();		 
 
				if(ds_ret == null) 
					return false; 
				else
					return true;
			}
			catch
			{
				return false; 
			}



		}


		#endregion

		private void vcGantt_Click(object sender, System.EventArgs e)
		{
		
		}


		#endregion 
  
		
 
 

	 
	}
}

