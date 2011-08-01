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
	public class Pop_SetLOTInformation : COM.APSWinForm.Pop_Large
	{
		
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Label btn_Cancel;
		public System.Windows.Forms.Label btn_Commit; 
		private System.Windows.Forms.Panel pnl_Info;
		public System.Windows.Forms.Panel pnl_SearchLeftImage;
		public System.Windows.Forms.PictureBox picb_LBR;
		public System.Windows.Forms.PictureBox picb_LBL;
		public System.Windows.Forms.PictureBox picb_LMR;
		public System.Windows.Forms.PictureBox picb_LTR;
		public System.Windows.Forms.PictureBox picb_LTM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_LBM;
		public System.Windows.Forms.PictureBox picb_LMM;
		public System.Windows.Forms.PictureBox picb_LML;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txt_LossQty;
		private System.Windows.Forms.TextBox txt_TotalQty;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.TextBox txt_ObsType;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbl_Line;
		private System.Windows.Forms.Label lbl_DaySeq;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private System.Windows.Forms.Label lbl_StatusYMD;
		private System.Windows.Forms.Label lbl_LOTSt;
		private System.Windows.Forms.Label lbl_Qty;
		private System.Windows.Forms.Label lbl_Model;
		private System.Windows.Forms.Label lbl_BOM;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_LOT;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_OA;
		private System.Windows.Forms.Label lbl_LOTDiv;
		private System.Windows.Forms.Label lbl_Hold;
		private System.Windows.Forms.TextBox txt_Model;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.TextBox txt_LOT;
		private C1.Win.C1List.C1Combo cmb_LOTDiv;
		private C1.Win.C1List.C1Combo cmb_OA;
		private C1.Win.C1List.C1Combo cmb_LOTSt;
		private System.Windows.Forms.TextBox txt_LOTStYMD;
		private System.Windows.Forms.TextBox txt_LineCd;
		private System.Windows.Forms.TextBox txt_PlanStrYMD;
		private System.Windows.Forms.TextBox txt_PlanEndYMD;
		private System.Windows.Forms.TextBox txt_TotDaySeq;
		private System.Windows.Forms.CheckBox chk_HoldYN;
		private System.Windows.Forms.Label btn_BOM;
		private System.Windows.Forms.Label lbl_RTS;
		private System.Windows.Forms.TextBox txt_RtsYMD;
		private C1.Win.C1Command.C1OutBar obar_main;
		private C1.Win.C1Command.C1OutPage obarpg_LeadTime;
		public COM.FSP fgrid_OpLT;
		private System.Windows.Forms.Label lbl_ApplyYMD;
		private System.Windows.Forms.Label lbl_LTCd;
		private System.Windows.Forms.TextBox txt_ApplyYMD;
		private C1.Win.C1List.C1Combo cmb_BOM;
		private C1.Win.C1List.C1Combo cmb_LTCd;
		private C1.Win.C1List.C1Combo cmb_RoutType;
		private System.Windows.Forms.Label lbl_RoutType;
		private System.Windows.Forms.Label btn_Model;
		public System.Windows.Forms.Label btn_LOTApply;
		private System.Windows.Forms.Label btn_Refresh;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label btn_AdaptLT;
		private System.Windows.Forms.Label btn_OpLT;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label lbl_DPO;
		private System.Windows.Forms.TextBox txt_ObsID;
		private System.Windows.Forms.Label lbl_OGAC;
		public COM.FSP fgrid_ReqNo;
		public System.Windows.Forms.DateTimePicker dpick_OGAC;
		private C1.Win.C1Command.C1OutPage obarpg_Req;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자


		public Pop_SetLOTInformation()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


		private string _Factory;
		private string _LOT;

		public Pop_SetLOTInformation(string arg_factory, string arg_lot)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Factory = arg_factory;
			_LOT = arg_lot;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SetLOTInformation));
			this.btn_Commit = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.pnl_Info = new System.Windows.Forms.Panel();
			this.pnl_SearchLeftImage = new System.Windows.Forms.Panel();
			this.dpick_OGAC = new System.Windows.Forms.DateTimePicker();
			this.chk_HoldYN = new System.Windows.Forms.CheckBox();
			this.lbl_Hold = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_PlanEndYMD = new System.Windows.Forms.TextBox();
			this.txt_PlanStrYMD = new System.Windows.Forms.TextBox();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.txt_TotDaySeq = new System.Windows.Forms.TextBox();
			this.lbl_DaySeq = new System.Windows.Forms.Label();
			this.cmb_OA = new C1.Win.C1List.C1Combo();
			this.lbl_OA = new System.Windows.Forms.Label();
			this.btn_OpLT = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.lbl_ApplyYMD = new System.Windows.Forms.Label();
			this.txt_ApplyYMD = new System.Windows.Forms.TextBox();
			this.lbl_BOM = new System.Windows.Forms.Label();
			this.cmb_RoutType = new C1.Win.C1List.C1Combo();
			this.lbl_RoutType = new System.Windows.Forms.Label();
			this.lbl_LTCd = new System.Windows.Forms.Label();
			this.cmb_LTCd = new C1.Win.C1List.C1Combo();
			this.cmb_BOM = new C1.Win.C1List.C1Combo();
			this.cmb_LOTDiv = new C1.Win.C1List.C1Combo();
			this.lbl_LOTDiv = new System.Windows.Forms.Label();
			this.lbl_Line = new System.Windows.Forms.Label();
			this.txt_LineCd = new System.Windows.Forms.TextBox();
			this.cmb_LOTSt = new C1.Win.C1List.C1Combo();
			this.txt_LOTStYMD = new System.Windows.Forms.TextBox();
			this.txt_Model = new System.Windows.Forms.TextBox();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.txt_ObsType = new System.Windows.Forms.TextBox();
			this.txt_ObsID = new System.Windows.Forms.TextBox();
			this.txt_RtsYMD = new System.Windows.Forms.TextBox();
			this.txt_Gen = new System.Windows.Forms.TextBox();
			this.lbl_StatusYMD = new System.Windows.Forms.Label();
			this.lbl_LOTSt = new System.Windows.Forms.Label();
			this.lbl_Model = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.lbl_DPO = new System.Windows.Forms.Label();
			this.lbl_RTS = new System.Windows.Forms.Label();
			this.lbl_OGAC = new System.Windows.Forms.Label();
			this.lbl_LOT = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.txt_LossQty = new System.Windows.Forms.TextBox();
			this.txt_TotalQty = new System.Windows.Forms.TextBox();
			this.txt_LOT = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.lbl_Qty = new System.Windows.Forms.Label();
			this.btn_LOTApply = new System.Windows.Forms.Label();
			this.btn_Model = new System.Windows.Forms.Label();
			this.btn_AdaptLT = new System.Windows.Forms.Label();
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_BOM = new System.Windows.Forms.Label();
			this.picb_LBR = new System.Windows.Forms.PictureBox();
			this.picb_LBL = new System.Windows.Forms.PictureBox();
			this.picb_LMR = new System.Windows.Forms.PictureBox();
			this.picb_LTR = new System.Windows.Forms.PictureBox();
			this.picb_LTM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_LBM = new System.Windows.Forms.PictureBox();
			this.picb_LMM = new System.Windows.Forms.PictureBox();
			this.picb_LML = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.obar_main = new C1.Win.C1Command.C1OutBar();
			this.obarpg_LeadTime = new C1.Win.C1Command.C1OutPage();
			this.fgrid_OpLT = new COM.FSP();
			this.obarpg_Req = new C1.Win.C1Command.C1OutPage();
			this.fgrid_ReqNo = new COM.FSP();
			this.btn_Refresh = new System.Windows.Forms.Label();
			this.pnl_Info.SuspendLayout();
			this.pnl_SearchLeftImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_RoutType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LTCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_BOM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LOTDiv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LOTSt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.obar_main)).BeginInit();
			this.obar_main.SuspendLayout();
			this.obarpg_LeadTime.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_OpLT)).BeginInit();
			this.obarpg_Req.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ReqNo)).BeginInit();
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
			// btn_Commit
			// 
			this.btn_Commit.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Commit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Commit.ImageIndex = 0;
			this.btn_Commit.ImageList = this.img_Button;
			this.btn_Commit.Location = new System.Drawing.Point(8, 664);
			this.btn_Commit.Name = "btn_Commit";
			this.btn_Commit.Size = new System.Drawing.Size(70, 23);
			this.btn_Commit.TabIndex = 202;
			this.btn_Commit.Text = "Apply";
			this.btn_Commit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Commit.Visible = false;
			this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
			this.btn_Commit.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Commit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Commit.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Commit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(616, 660);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// pnl_Info
			// 
			this.pnl_Info.BackColor = System.Drawing.Color.Transparent;
			this.pnl_Info.Controls.Add(this.pnl_SearchLeftImage);
			this.pnl_Info.DockPadding.Bottom = 5;
			this.pnl_Info.Location = new System.Drawing.Point(6, 46);
			this.pnl_Info.Name = "pnl_Info";
			this.pnl_Info.Size = new System.Drawing.Size(680, 230);
			this.pnl_Info.TabIndex = 225;
			// 
			// pnl_SearchLeftImage
			// 
			this.pnl_SearchLeftImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchLeftImage.Controls.Add(this.dpick_OGAC);
			this.pnl_SearchLeftImage.Controls.Add(this.chk_HoldYN);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Hold);
			this.pnl_SearchLeftImage.Controls.Add(this.label9);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_PlanEndYMD);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_PlanStrYMD);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_PlanYMD);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_TotDaySeq);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_DaySeq);
			this.pnl_SearchLeftImage.Controls.Add(this.cmb_OA);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_OA);
			this.pnl_SearchLeftImage.Controls.Add(this.btn_OpLT);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_ApplyYMD);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_ApplyYMD);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_BOM);
			this.pnl_SearchLeftImage.Controls.Add(this.cmb_RoutType);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_RoutType);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_LTCd);
			this.pnl_SearchLeftImage.Controls.Add(this.cmb_LTCd);
			this.pnl_SearchLeftImage.Controls.Add(this.cmb_BOM);
			this.pnl_SearchLeftImage.Controls.Add(this.cmb_LOTDiv);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_LOTDiv);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Line);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_LineCd);
			this.pnl_SearchLeftImage.Controls.Add(this.cmb_LOTSt);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_LOTStYMD);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_Model);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_ObsType);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_ObsID);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_RtsYMD);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_Gen);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_StatusYMD);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_LOTSt);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Model);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Style);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_DPO);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_RTS);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_OGAC);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_LOT);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_LossQty);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_TotalQty);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_LOT);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_Factory);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Qty);
			this.pnl_SearchLeftImage.Controls.Add(this.btn_LOTApply);
			this.pnl_SearchLeftImage.Controls.Add(this.btn_Model);
			this.pnl_SearchLeftImage.Controls.Add(this.btn_AdaptLT);
			this.pnl_SearchLeftImage.Controls.Add(this.btn_BOM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBL);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTM);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LML);
			this.pnl_SearchLeftImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchLeftImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchLeftImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchLeftImage.Name = "pnl_SearchLeftImage";
			this.pnl_SearchLeftImage.Size = new System.Drawing.Size(680, 225);
			this.pnl_SearchLeftImage.TabIndex = 19;
			// 
			// dpick_OGAC
			// 
			this.dpick_OGAC.CustomFormat = "yyyyMMdd";
			this.dpick_OGAC.Enabled = false;
			this.dpick_OGAC.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_OGAC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_OGAC.Location = new System.Drawing.Point(333, 58);
			this.dpick_OGAC.Name = "dpick_OGAC";
			this.dpick_OGAC.Size = new System.Drawing.Size(119, 21);
			this.dpick_OGAC.TabIndex = 284;
			this.dpick_OGAC.ValueChanged += new System.EventHandler(this.dpick_OGAC_ValueChanged);
			// 
			// chk_HoldYN
			// 
			this.chk_HoldYN.BackColor = System.Drawing.Color.Transparent;
			this.chk_HoldYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_HoldYN.Location = new System.Drawing.Point(557, 146);
			this.chk_HoldYN.Name = "chk_HoldYN";
			this.chk_HoldYN.Size = new System.Drawing.Size(16, 21);
			this.chk_HoldYN.TabIndex = 264;
			// 
			// lbl_Hold
			// 
			this.lbl_Hold.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Hold.ImageIndex = 0;
			this.lbl_Hold.ImageList = this.img_Label;
			this.lbl_Hold.Location = new System.Drawing.Point(456, 146);
			this.lbl_Hold.Name = "lbl_Hold";
			this.lbl_Hold.Size = new System.Drawing.Size(100, 21);
			this.lbl_Hold.TabIndex = 263;
			this.lbl_Hold.Text = "Hold";
			this.lbl_Hold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(433, 168);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(16, 21);
			this.label9.TabIndex = 227;
			this.label9.Text = "~";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_PlanEndYMD
			// 
			this.txt_PlanEndYMD.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_PlanEndYMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_PlanEndYMD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_PlanEndYMD.Location = new System.Drawing.Point(456, 168);
			this.txt_PlanEndYMD.MaxLength = 60;
			this.txt_PlanEndYMD.Name = "txt_PlanEndYMD";
			this.txt_PlanEndYMD.ReadOnly = true;
			this.txt_PlanEndYMD.TabIndex = 261;
			this.txt_PlanEndYMD.Text = "";
			// 
			// txt_PlanStrYMD
			// 
			this.txt_PlanStrYMD.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_PlanStrYMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_PlanStrYMD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_PlanStrYMD.Location = new System.Drawing.Point(333, 168);
			this.txt_PlanStrYMD.MaxLength = 60;
			this.txt_PlanStrYMD.Name = "txt_PlanStrYMD";
			this.txt_PlanStrYMD.ReadOnly = true;
			this.txt_PlanStrYMD.Size = new System.Drawing.Size(95, 21);
			this.txt_PlanStrYMD.TabIndex = 260;
			this.txt_PlanStrYMD.Text = "";
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_PlanYMD.ImageIndex = 0;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(232, 168);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 237;
			this.lbl_PlanYMD.Text = "Scheduled Day";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_TotDaySeq
			// 
			this.txt_TotDaySeq.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_TotDaySeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_TotDaySeq.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_TotDaySeq.Location = new System.Drawing.Point(111, 168);
			this.txt_TotDaySeq.MaxLength = 60;
			this.txt_TotDaySeq.Name = "txt_TotDaySeq";
			this.txt_TotDaySeq.ReadOnly = true;
			this.txt_TotDaySeq.Size = new System.Drawing.Size(117, 21);
			this.txt_TotDaySeq.TabIndex = 262;
			this.txt_TotDaySeq.Text = "";
			// 
			// lbl_DaySeq
			// 
			this.lbl_DaySeq.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_DaySeq.ImageIndex = 0;
			this.lbl_DaySeq.ImageList = this.img_Label;
			this.lbl_DaySeq.Location = new System.Drawing.Point(10, 168);
			this.lbl_DaySeq.Name = "lbl_DaySeq";
			this.lbl_DaySeq.Size = new System.Drawing.Size(100, 21);
			this.lbl_DaySeq.TabIndex = 236;
			this.lbl_DaySeq.Text = "Total Day";
			this.lbl_DaySeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_OA
			// 
			this.cmb_OA.AddItemCols = 0;
			this.cmb_OA.AddItemSeparator = ';';
			this.cmb_OA.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OA.Caption = "";
			this.cmb_OA.CaptionHeight = 17;
			this.cmb_OA.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OA.ColumnCaptionHeight = 18;
			this.cmb_OA.ColumnFooterHeight = 18;
			this.cmb_OA.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OA.ContentHeight = 16;
			this.cmb_OA.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OA.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OA.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OA.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OA.EditorHeight = 16;
			this.cmb_OA.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OA.GapHeight = 2;
			this.cmb_OA.ItemHeight = 15;
			this.cmb_OA.Location = new System.Drawing.Point(557, 58);
			this.cmb_OA.MatchEntryTimeout = ((long)(2000));
			this.cmb_OA.MaxDropDownItems = ((short)(5));
			this.cmb_OA.MaxLength = 32767;
			this.cmb_OA.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OA.Name = "cmb_OA";
			this.cmb_OA.PartialRightColumn = false;
			this.cmb_OA.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor" +
				":Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style" +
				"8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_OA.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OA.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OA.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OA.Size = new System.Drawing.Size(117, 20);
			this.cmb_OA.TabIndex = 256;
			// 
			// lbl_OA
			// 
			this.lbl_OA.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_OA.ImageIndex = 0;
			this.lbl_OA.ImageList = this.img_Label;
			this.lbl_OA.Location = new System.Drawing.Point(456, 58);
			this.lbl_OA.Name = "lbl_OA";
			this.lbl_OA.Size = new System.Drawing.Size(100, 21);
			this.lbl_OA.TabIndex = 235;
			this.lbl_OA.Text = "OA";
			this.lbl_OA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_OpLT
			// 
			this.btn_OpLT.ImageIndex = 0;
			this.btn_OpLT.ImageList = this.img_MiniButton;
			this.btn_OpLT.Location = new System.Drawing.Point(429, 146);
			this.btn_OpLT.Name = "btn_OpLT";
			this.btn_OpLT.Size = new System.Drawing.Size(21, 21);
			this.btn_OpLT.TabIndex = 282;
			this.btn_OpLT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_OpLT.Click += new System.EventHandler(this.btn_OpLT_Click);
			this.btn_OpLT.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_OpLT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_OpLT.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_OpLT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_ApplyYMD
			// 
			this.lbl_ApplyYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_ApplyYMD.ImageIndex = 0;
			this.lbl_ApplyYMD.ImageList = this.img_Label;
			this.lbl_ApplyYMD.Location = new System.Drawing.Point(232, 146);
			this.lbl_ApplyYMD.Name = "lbl_ApplyYMD";
			this.lbl_ApplyYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_ApplyYMD.TabIndex = 270;
			this.lbl_ApplyYMD.Text = "LT Apply Day";
			this.lbl_ApplyYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_ApplyYMD
			// 
			this.txt_ApplyYMD.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ApplyYMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ApplyYMD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ApplyYMD.Location = new System.Drawing.Point(333, 146);
			this.txt_ApplyYMD.MaxLength = 60;
			this.txt_ApplyYMD.Name = "txt_ApplyYMD";
			this.txt_ApplyYMD.ReadOnly = true;
			this.txt_ApplyYMD.Size = new System.Drawing.Size(95, 21);
			this.txt_ApplyYMD.TabIndex = 272;
			this.txt_ApplyYMD.Text = "";
			// 
			// lbl_BOM
			// 
			this.lbl_BOM.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_BOM.ImageIndex = 0;
			this.lbl_BOM.ImageList = this.img_Label;
			this.lbl_BOM.Location = new System.Drawing.Point(232, 80);
			this.lbl_BOM.Name = "lbl_BOM";
			this.lbl_BOM.Size = new System.Drawing.Size(100, 21);
			this.lbl_BOM.TabIndex = 225;
			this.lbl_BOM.Text = "BOM";
			this.lbl_BOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_RoutType
			// 
			this.cmb_RoutType.AddItemCols = 0;
			this.cmb_RoutType.AddItemSeparator = ';';
			this.cmb_RoutType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_RoutType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_RoutType.Caption = "";
			this.cmb_RoutType.CaptionHeight = 17;
			this.cmb_RoutType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_RoutType.ColumnCaptionHeight = 18;
			this.cmb_RoutType.ColumnFooterHeight = 18;
			this.cmb_RoutType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_RoutType.ContentHeight = 16;
			this.cmb_RoutType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_RoutType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_RoutType.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_RoutType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_RoutType.EditorHeight = 16;
			this.cmb_RoutType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_RoutType.GapHeight = 2;
			this.cmb_RoutType.ItemHeight = 15;
			this.cmb_RoutType.Location = new System.Drawing.Point(333, 102);
			this.cmb_RoutType.MatchEntryTimeout = ((long)(2000));
			this.cmb_RoutType.MaxDropDownItems = ((short)(5));
			this.cmb_RoutType.MaxLength = 32767;
			this.cmb_RoutType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_RoutType.Name = "cmb_RoutType";
			this.cmb_RoutType.PartialRightColumn = false;
			this.cmb_RoutType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor" +
				":Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style" +
				"8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_RoutType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_RoutType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_RoutType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_RoutType.Size = new System.Drawing.Size(117, 20);
			this.cmb_RoutType.TabIndex = 276;
			// 
			// lbl_RoutType
			// 
			this.lbl_RoutType.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_RoutType.ImageIndex = 0;
			this.lbl_RoutType.ImageList = this.img_Label;
			this.lbl_RoutType.Location = new System.Drawing.Point(232, 102);
			this.lbl_RoutType.Name = "lbl_RoutType";
			this.lbl_RoutType.Size = new System.Drawing.Size(100, 21);
			this.lbl_RoutType.TabIndex = 275;
			this.lbl_RoutType.Text = "Routing Type";
			this.lbl_RoutType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_LTCd
			// 
			this.lbl_LTCd.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_LTCd.ImageIndex = 0;
			this.lbl_LTCd.ImageList = this.img_Label;
			this.lbl_LTCd.Location = new System.Drawing.Point(232, 124);
			this.lbl_LTCd.Name = "lbl_LTCd";
			this.lbl_LTCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_LTCd.TabIndex = 269;
			this.lbl_LTCd.Text = "LeadTime Cd";
			this.lbl_LTCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_LTCd
			// 
			this.cmb_LTCd.AddItemCols = 0;
			this.cmb_LTCd.AddItemSeparator = ';';
			this.cmb_LTCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LTCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LTCd.Caption = "";
			this.cmb_LTCd.CaptionHeight = 17;
			this.cmb_LTCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LTCd.ColumnCaptionHeight = 18;
			this.cmb_LTCd.ColumnFooterHeight = 18;
			this.cmb_LTCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LTCd.ContentHeight = 16;
			this.cmb_LTCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LTCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LTCd.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LTCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LTCd.EditorHeight = 16;
			this.cmb_LTCd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LTCd.GapHeight = 2;
			this.cmb_LTCd.ItemHeight = 15;
			this.cmb_LTCd.Location = new System.Drawing.Point(333, 124);
			this.cmb_LTCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_LTCd.MaxDropDownItems = ((short)(5));
			this.cmb_LTCd.MaxLength = 32767;
			this.cmb_LTCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LTCd.Name = "cmb_LTCd";
			this.cmb_LTCd.PartialRightColumn = false;
			this.cmb_LTCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap" +
				":True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor" +
				":Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_LTCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LTCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LTCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LTCd.Size = new System.Drawing.Size(117, 20);
			this.cmb_LTCd.TabIndex = 274;
			// 
			// cmb_BOM
			// 
			this.cmb_BOM.AddItemCols = 0;
			this.cmb_BOM.AddItemSeparator = ';';
			this.cmb_BOM.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_BOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_BOM.Caption = "";
			this.cmb_BOM.CaptionHeight = 17;
			this.cmb_BOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_BOM.ColumnCaptionHeight = 18;
			this.cmb_BOM.ColumnFooterHeight = 18;
			this.cmb_BOM.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_BOM.ContentHeight = 16;
			this.cmb_BOM.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_BOM.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_BOM.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_BOM.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_BOM.EditorHeight = 16;
			this.cmb_BOM.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_BOM.GapHeight = 2;
			this.cmb_BOM.ItemHeight = 15;
			this.cmb_BOM.Location = new System.Drawing.Point(333, 80);
			this.cmb_BOM.MatchEntryTimeout = ((long)(2000));
			this.cmb_BOM.MaxDropDownItems = ((short)(5));
			this.cmb_BOM.MaxLength = 32767;
			this.cmb_BOM.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_BOM.Name = "cmb_BOM";
			this.cmb_BOM.PartialRightColumn = false;
			this.cmb_BOM.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap" +
				":True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor" +
				":Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_BOM.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_BOM.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_BOM.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_BOM.Size = new System.Drawing.Size(117, 20);
			this.cmb_BOM.TabIndex = 273;
			this.cmb_BOM.SelectedValueChanged += new System.EventHandler(this.cmb_BOM_SelectedValueChanged);
			// 
			// cmb_LOTDiv
			// 
			this.cmb_LOTDiv.AddItemCols = 0;
			this.cmb_LOTDiv.AddItemSeparator = ';';
			this.cmb_LOTDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LOTDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LOTDiv.Caption = "";
			this.cmb_LOTDiv.CaptionHeight = 17;
			this.cmb_LOTDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LOTDiv.ColumnCaptionHeight = 18;
			this.cmb_LOTDiv.ColumnFooterHeight = 18;
			this.cmb_LOTDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LOTDiv.ContentHeight = 16;
			this.cmb_LOTDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LOTDiv.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LOTDiv.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LOTDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LOTDiv.EditorHeight = 16;
			this.cmb_LOTDiv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LOTDiv.GapHeight = 2;
			this.cmb_LOTDiv.ItemHeight = 15;
			this.cmb_LOTDiv.Location = new System.Drawing.Point(557, 80);
			this.cmb_LOTDiv.MatchEntryTimeout = ((long)(2000));
			this.cmb_LOTDiv.MaxDropDownItems = ((short)(5));
			this.cmb_LOTDiv.MaxLength = 32767;
			this.cmb_LOTDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LOTDiv.Name = "cmb_LOTDiv";
			this.cmb_LOTDiv.PartialRightColumn = false;
			this.cmb_LOTDiv.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap" +
				":True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor" +
				":Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_LOTDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LOTDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LOTDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LOTDiv.Size = new System.Drawing.Size(117, 20);
			this.cmb_LOTDiv.TabIndex = 255;
			// 
			// lbl_LOTDiv
			// 
			this.lbl_LOTDiv.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_LOTDiv.ImageIndex = 0;
			this.lbl_LOTDiv.ImageList = this.img_Label;
			this.lbl_LOTDiv.Location = new System.Drawing.Point(456, 80);
			this.lbl_LOTDiv.Name = "lbl_LOTDiv";
			this.lbl_LOTDiv.Size = new System.Drawing.Size(100, 21);
			this.lbl_LOTDiv.TabIndex = 232;
			this.lbl_LOTDiv.Text = "LOT Division";
			this.lbl_LOTDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Line
			// 
			this.lbl_Line.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Line.ImageIndex = 0;
			this.lbl_Line.ImageList = this.img_Label;
			this.lbl_Line.Location = new System.Drawing.Point(456, 36);
			this.lbl_Line.Name = "lbl_Line";
			this.lbl_Line.Size = new System.Drawing.Size(100, 21);
			this.lbl_Line.TabIndex = 238;
			this.lbl_Line.Text = "Line";
			this.lbl_Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LineCd
			// 
			this.txt_LineCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineCd.Location = new System.Drawing.Point(557, 36);
			this.txt_LineCd.MaxLength = 60;
			this.txt_LineCd.Name = "txt_LineCd";
			this.txt_LineCd.ReadOnly = true;
			this.txt_LineCd.Size = new System.Drawing.Size(117, 21);
			this.txt_LineCd.TabIndex = 259;
			this.txt_LineCd.Text = "";
			// 
			// cmb_LOTSt
			// 
			this.cmb_LOTSt.AddItemCols = 0;
			this.cmb_LOTSt.AddItemSeparator = ';';
			this.cmb_LOTSt.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LOTSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LOTSt.Caption = "";
			this.cmb_LOTSt.CaptionHeight = 17;
			this.cmb_LOTSt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LOTSt.ColumnCaptionHeight = 18;
			this.cmb_LOTSt.ColumnFooterHeight = 18;
			this.cmb_LOTSt.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LOTSt.ContentHeight = 16;
			this.cmb_LOTSt.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LOTSt.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LOTSt.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LOTSt.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LOTSt.EditorHeight = 16;
			this.cmb_LOTSt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LOTSt.GapHeight = 2;
			this.cmb_LOTSt.ItemHeight = 15;
			this.cmb_LOTSt.Location = new System.Drawing.Point(557, 102);
			this.cmb_LOTSt.MatchEntryTimeout = ((long)(2000));
			this.cmb_LOTSt.MaxDropDownItems = ((short)(5));
			this.cmb_LOTSt.MaxLength = 32767;
			this.cmb_LOTSt.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LOTSt.Name = "cmb_LOTSt";
			this.cmb_LOTSt.PartialRightColumn = false;
			this.cmb_LOTSt.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor" +
				":Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style" +
				"8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_LOTSt.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LOTSt.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LOTSt.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LOTSt.Size = new System.Drawing.Size(117, 20);
			this.cmb_LOTSt.TabIndex = 257;
			// 
			// txt_LOTStYMD
			// 
			this.txt_LOTStYMD.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LOTStYMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOTStYMD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LOTStYMD.Location = new System.Drawing.Point(557, 124);
			this.txt_LOTStYMD.MaxLength = 60;
			this.txt_LOTStYMD.Name = "txt_LOTStYMD";
			this.txt_LOTStYMD.ReadOnly = true;
			this.txt_LOTStYMD.Size = new System.Drawing.Size(117, 21);
			this.txt_LOTStYMD.TabIndex = 258;
			this.txt_LOTStYMD.Text = "";
			// 
			// txt_Model
			// 
			this.txt_Model.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Model.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Model.Location = new System.Drawing.Point(111, 124);
			this.txt_Model.MaxLength = 60;
			this.txt_Model.Name = "txt_Model";
			this.txt_Model.ReadOnly = true;
			this.txt_Model.Size = new System.Drawing.Size(117, 21);
			this.txt_Model.TabIndex = 251;
			this.txt_Model.Text = "";
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(111, 146);
			this.txt_StyleCd.MaxLength = 60;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.ReadOnly = true;
			this.txt_StyleCd.Size = new System.Drawing.Size(80, 21);
			this.txt_StyleCd.TabIndex = 247;
			this.txt_StyleCd.Text = "";
			// 
			// txt_ObsType
			// 
			this.txt_ObsType.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ObsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ObsType.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ObsType.Location = new System.Drawing.Point(192, 102);
			this.txt_ObsType.MaxLength = 60;
			this.txt_ObsType.Name = "txt_ObsType";
			this.txt_ObsType.ReadOnly = true;
			this.txt_ObsType.Size = new System.Drawing.Size(36, 21);
			this.txt_ObsType.TabIndex = 246;
			this.txt_ObsType.Text = "";
			// 
			// txt_ObsID
			// 
			this.txt_ObsID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ObsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ObsID.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ObsID.Location = new System.Drawing.Point(111, 102);
			this.txt_ObsID.MaxLength = 60;
			this.txt_ObsID.Name = "txt_ObsID";
			this.txt_ObsID.ReadOnly = true;
			this.txt_ObsID.Size = new System.Drawing.Size(80, 21);
			this.txt_ObsID.TabIndex = 254;
			this.txt_ObsID.Text = "";
			// 
			// txt_RtsYMD
			// 
			this.txt_RtsYMD.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_RtsYMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_RtsYMD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_RtsYMD.Location = new System.Drawing.Point(333, 36);
			this.txt_RtsYMD.MaxLength = 60;
			this.txt_RtsYMD.Name = "txt_RtsYMD";
			this.txt_RtsYMD.ReadOnly = true;
			this.txt_RtsYMD.Size = new System.Drawing.Size(117, 21);
			this.txt_RtsYMD.TabIndex = 268;
			this.txt_RtsYMD.Text = "";
			// 
			// txt_Gen
			// 
			this.txt_Gen.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Gen.Location = new System.Drawing.Point(192, 146);
			this.txt_Gen.MaxLength = 60;
			this.txt_Gen.Name = "txt_Gen";
			this.txt_Gen.ReadOnly = true;
			this.txt_Gen.Size = new System.Drawing.Size(36, 21);
			this.txt_Gen.TabIndex = 248;
			this.txt_Gen.Text = "";
			// 
			// lbl_StatusYMD
			// 
			this.lbl_StatusYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_StatusYMD.ImageIndex = 0;
			this.lbl_StatusYMD.ImageList = this.img_Label;
			this.lbl_StatusYMD.Location = new System.Drawing.Point(456, 124);
			this.lbl_StatusYMD.Name = "lbl_StatusYMD";
			this.lbl_StatusYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_StatusYMD.TabIndex = 241;
			this.lbl_StatusYMD.Text = "Status Day";
			this.lbl_StatusYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_LOTSt
			// 
			this.lbl_LOTSt.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_LOTSt.ImageIndex = 0;
			this.lbl_LOTSt.ImageList = this.img_Label;
			this.lbl_LOTSt.Location = new System.Drawing.Point(456, 102);
			this.lbl_LOTSt.Name = "lbl_LOTSt";
			this.lbl_LOTSt.Size = new System.Drawing.Size(100, 21);
			this.lbl_LOTSt.TabIndex = 240;
			this.lbl_LOTSt.Text = "LOT Status";
			this.lbl_LOTSt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Model
			// 
			this.lbl_Model.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_Label;
			this.lbl_Model.Location = new System.Drawing.Point(10, 124);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(100, 21);
			this.lbl_Model.TabIndex = 233;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(10, 146);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 224;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_DPO
			// 
			this.lbl_DPO.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_DPO.ImageIndex = 0;
			this.lbl_DPO.ImageList = this.img_Label;
			this.lbl_DPO.Location = new System.Drawing.Point(10, 102);
			this.lbl_DPO.Name = "lbl_DPO";
			this.lbl_DPO.Size = new System.Drawing.Size(100, 21);
			this.lbl_DPO.TabIndex = 229;
			this.lbl_DPO.Text = "DPO / Type";
			this.lbl_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_RTS
			// 
			this.lbl_RTS.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_RTS.ImageIndex = 0;
			this.lbl_RTS.ImageList = this.img_Label;
			this.lbl_RTS.Location = new System.Drawing.Point(232, 36);
			this.lbl_RTS.Name = "lbl_RTS";
			this.lbl_RTS.Size = new System.Drawing.Size(100, 21);
			this.lbl_RTS.TabIndex = 267;
			this.lbl_RTS.Text = "RGAC";
			this.lbl_RTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OGAC
			// 
			this.lbl_OGAC.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_OGAC.ImageIndex = 0;
			this.lbl_OGAC.ImageList = this.img_Label;
			this.lbl_OGAC.Location = new System.Drawing.Point(232, 58);
			this.lbl_OGAC.Name = "lbl_OGAC";
			this.lbl_OGAC.Size = new System.Drawing.Size(100, 21);
			this.lbl_OGAC.TabIndex = 283;
			this.lbl_OGAC.Text = "OGAC";
			this.lbl_OGAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_LOT
			// 
			this.lbl_LOT.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_LOT.ImageIndex = 0;
			this.lbl_LOT.ImageList = this.img_Label;
			this.lbl_LOT.Location = new System.Drawing.Point(10, 58);
			this.lbl_LOT.Name = "lbl_LOT";
			this.lbl_LOT.Size = new System.Drawing.Size(100, 21);
			this.lbl_LOT.TabIndex = 228;
			this.lbl_LOT.Text = "LOT";
			this.lbl_LOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 226;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LossQty
			// 
			this.txt_LossQty.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LossQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LossQty.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LossQty.Location = new System.Drawing.Point(172, 80);
			this.txt_LossQty.MaxLength = 60;
			this.txt_LossQty.Name = "txt_LossQty";
			this.txt_LossQty.ReadOnly = true;
			this.txt_LossQty.Size = new System.Drawing.Size(56, 21);
			this.txt_LossQty.TabIndex = 250;
			this.txt_LossQty.Text = "";
			// 
			// txt_TotalQty
			// 
			this.txt_TotalQty.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_TotalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_TotalQty.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_TotalQty.Location = new System.Drawing.Point(111, 80);
			this.txt_TotalQty.MaxLength = 60;
			this.txt_TotalQty.Name = "txt_TotalQty";
			this.txt_TotalQty.ReadOnly = true;
			this.txt_TotalQty.Size = new System.Drawing.Size(60, 21);
			this.txt_TotalQty.TabIndex = 249;
			this.txt_TotalQty.Text = "";
			// 
			// txt_LOT
			// 
			this.txt_LOT.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOT.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LOT.Location = new System.Drawing.Point(111, 58);
			this.txt_LOT.MaxLength = 60;
			this.txt_LOT.Name = "txt_LOT";
			this.txt_LOT.ReadOnly = true;
			this.txt_LOT.Size = new System.Drawing.Size(117, 21);
			this.txt_LOT.TabIndex = 253;
			this.txt_LOT.Text = "";
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
			this.txt_Factory.Size = new System.Drawing.Size(117, 21);
			this.txt_Factory.TabIndex = 252;
			this.txt_Factory.Text = "";
			// 
			// lbl_Qty
			// 
			this.lbl_Qty.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Qty.ImageIndex = 0;
			this.lbl_Qty.ImageList = this.img_Label;
			this.lbl_Qty.Location = new System.Drawing.Point(10, 80);
			this.lbl_Qty.Name = "lbl_Qty";
			this.lbl_Qty.Size = new System.Drawing.Size(100, 21);
			this.lbl_Qty.TabIndex = 227;
			this.lbl_Qty.Text = "Total/Loss Qty.";
			this.lbl_Qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_LOTApply
			// 
			this.btn_LOTApply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_LOTApply.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_LOTApply.ImageIndex = 0;
			this.btn_LOTApply.ImageList = this.img_Button;
			this.btn_LOTApply.Location = new System.Drawing.Point(604, 196);
			this.btn_LOTApply.Name = "btn_LOTApply";
			this.btn_LOTApply.Size = new System.Drawing.Size(70, 23);
			this.btn_LOTApply.TabIndex = 281;
			this.btn_LOTApply.Text = "Apply";
			this.btn_LOTApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_LOTApply.Click += new System.EventHandler(this.btn_LOTApply_Click);
			this.btn_LOTApply.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_LOTApply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_LOTApply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_LOTApply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Model
			// 
			this.btn_Model.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Model.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Model.ImageIndex = 0;
			this.btn_Model.ImageList = this.img_Button;
			this.btn_Model.Location = new System.Drawing.Point(10, 196);
			this.btn_Model.Name = "btn_Model";
			this.btn_Model.Size = new System.Drawing.Size(70, 23);
			this.btn_Model.TabIndex = 277;
			this.btn_Model.Text = "Model";
			this.btn_Model.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Model.Click += new System.EventHandler(this.btn_Model_Click);
			this.btn_Model.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Model.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Model.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Model.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_AdaptLT
			// 
			this.btn_AdaptLT.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_AdaptLT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_AdaptLT.ImageIndex = 0;
			this.btn_AdaptLT.ImageList = this.img_LongButton;
			this.btn_AdaptLT.Location = new System.Drawing.Point(152, 196);
			this.btn_AdaptLT.Name = "btn_AdaptLT";
			this.btn_AdaptLT.TabIndex = 266;
			this.btn_AdaptLT.Text = "Apply LOT L/T";
			this.btn_AdaptLT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_AdaptLT.Click += new System.EventHandler(this.btn_AdaptLT_Click);
			this.btn_AdaptLT.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_AdaptLT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_AdaptLT.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_AdaptLT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_BOM
			// 
			this.btn_BOM.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_BOM.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_BOM.ImageIndex = 0;
			this.btn_BOM.ImageList = this.img_Button;
			this.btn_BOM.Location = new System.Drawing.Point(81, 196);
			this.btn_BOM.Name = "btn_BOM";
			this.btn_BOM.Size = new System.Drawing.Size(70, 23);
			this.btn_BOM.TabIndex = 265;
			this.btn_BOM.Text = "BOM";
			this.btn_BOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_BOM.Click += new System.EventHandler(this.btn_BOM_Click);
			this.btn_BOM.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_BOM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_BOM.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_BOM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// picb_LBR
			// 
			this.picb_LBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBR.Image")));
			this.picb_LBR.Location = new System.Drawing.Point(664, 209);
			this.picb_LBR.Name = "picb_LBR";
			this.picb_LBR.Size = new System.Drawing.Size(16, 16);
			this.picb_LBR.TabIndex = 23;
			this.picb_LBR.TabStop = false;
			// 
			// picb_LBL
			// 
			this.picb_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_LBL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBL.Image")));
			this.picb_LBL.Location = new System.Drawing.Point(0, 205);
			this.picb_LBL.Name = "picb_LBL";
			this.picb_LBL.Size = new System.Drawing.Size(168, 20);
			this.picb_LBL.TabIndex = 22;
			this.picb_LBL.TabStop = false;
			// 
			// picb_LMR
			// 
			this.picb_LMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LMR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMR.Image")));
			this.picb_LMR.Location = new System.Drawing.Point(665, 24);
			this.picb_LMR.Name = "picb_LMR";
			this.picb_LMR.Size = new System.Drawing.Size(15, 225);
			this.picb_LMR.TabIndex = 26;
			this.picb_LMR.TabStop = false;
			// 
			// picb_LTR
			// 
			this.picb_LTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LTR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTR.Image")));
			this.picb_LTR.Location = new System.Drawing.Point(664, 0);
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
			this.picb_LTM.Size = new System.Drawing.Size(480, 32);
			this.picb_LTM.TabIndex = 0;
			this.picb_LTM.TabStop = false;
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
			this.lbl_SubTitle1.Text = "       Seleted LOT Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_LBM
			// 
			this.picb_LBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBM.Image")));
			this.picb_LBM.Location = new System.Drawing.Point(131, 207);
			this.picb_LBM.Name = "picb_LBM";
			this.picb_LBM.Size = new System.Drawing.Size(533, 18);
			this.picb_LBM.TabIndex = 28;
			this.picb_LBM.TabStop = false;
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
			this.picb_LMM.Size = new System.Drawing.Size(512, 225);
			this.picb_LMM.TabIndex = 27;
			this.picb_LMM.TabStop = false;
			// 
			// picb_LML
			// 
			this.picb_LML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_LML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LML.Image = ((System.Drawing.Image)(resources.GetObject("picb_LML.Image")));
			this.picb_LML.Location = new System.Drawing.Point(0, 24);
			this.picb_LML.Name = "picb_LML";
			this.picb_LML.Size = new System.Drawing.Size(168, 225);
			this.picb_LML.TabIndex = 25;
			this.picb_LML.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// obar_main
			// 
			this.obar_main.BackColor = System.Drawing.SystemColors.Window;
			this.obar_main.Controls.Add(this.obarpg_LeadTime);
			this.obar_main.Controls.Add(this.obarpg_Req);
			this.obar_main.Location = new System.Drawing.Point(8, 277);
			this.obar_main.Name = "obar_main";
			this.obar_main.Pages.Add(this.obarpg_LeadTime);
			this.obar_main.Pages.Add(this.obarpg_Req);
			this.obar_main.Size = new System.Drawing.Size(680, 375);
			this.obar_main.SelectedPageChanged += new System.EventHandler(this.obar_main_SelectedPageChanged);
			// 
			// obarpg_LeadTime
			// 
			this.obarpg_LeadTime.Controls.Add(this.fgrid_OpLT);
			this.obarpg_LeadTime.Location = new System.Drawing.Point(0, 20);
			this.obarpg_LeadTime.Name = "obarpg_LeadTime";
			this.obarpg_LeadTime.Size = new System.Drawing.Size(680, 335);
			this.obarpg_LeadTime.TabIndex = 1;
			this.obarpg_LeadTime.Text = "Display Operation Code LeadTime";
			// 
			// fgrid_OpLT
			// 
			this.fgrid_OpLT.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_OpLT.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_OpLT.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_OpLT.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_OpLT.Location = new System.Drawing.Point(8, 8);
			this.fgrid_OpLT.Name = "fgrid_OpLT";
			this.fgrid_OpLT.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_OpLT.Size = new System.Drawing.Size(664, 320);
			this.fgrid_OpLT.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_OpLT.TabIndex = 242;
			// 
			// obarpg_Req
			// 
			this.obarpg_Req.Controls.Add(this.fgrid_ReqNo);
			this.obarpg_Req.Location = new System.Drawing.Point(0, 0);
			this.obarpg_Req.Name = "obarpg_Req";
			this.obarpg_Req.Size = new System.Drawing.Size(0, 0);
			this.obarpg_Req.TabIndex = 2;
			this.obarpg_Req.Text = "Request List";
			// 
			// fgrid_ReqNo
			// 
			this.fgrid_ReqNo.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_ReqNo.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_ReqNo.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_ReqNo.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_ReqNo.Location = new System.Drawing.Point(8, 8);
			this.fgrid_ReqNo.Name = "fgrid_ReqNo";
			this.fgrid_ReqNo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_ReqNo.Size = new System.Drawing.Size(664, 300);
			this.fgrid_ReqNo.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_ReqNo.TabIndex = 242;
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Refresh.ImageIndex = 0;
			this.btn_Refresh.ImageList = this.img_Button;
			this.btn_Refresh.Location = new System.Drawing.Point(545, 660);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(70, 23);
			this.btn_Refresh.TabIndex = 281;
			this.btn_Refresh.Text = "Refresh";
			this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			this.btn_Refresh.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Refresh.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Pop_SetLOTInformation
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(694, 688);
			this.Controls.Add(this.obar_main);
			this.Controls.Add(this.pnl_Info);
			this.Controls.Add(this.btn_Commit);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Refresh);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Pop_SetLOTInformation";
			this.Text = "LOT Information";
			this.Controls.SetChildIndex(this.btn_Refresh, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Commit, 0);
			this.Controls.SetChildIndex(this.pnl_Info, 0);
			this.Controls.SetChildIndex(this.obar_main, 0);
			this.pnl_Info.ResumeLayout(false);
			this.pnl_SearchLeftImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_RoutType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LTCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_BOM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LOTDiv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LOTSt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.obar_main)).EndInit();
			this.obar_main.ResumeLayout(false);
			this.obarpg_LeadTime.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_OpLT)).EndInit();
			this.obarpg_Req.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ReqNo)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction();
 
		public bool _CloseSave = false;  
		private string _LotNo, _LotSeq;

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
				this.Text = "LOT Information";
				lbl_MainTitle.Text = "LOT Information";
  
				ClassLib.ComFunction.SetLangDic(this); 


		
				//op cd leadtime grid head setting
				fgrid_OpLT.Set_Grid("SPD_LOT_DAILY_OP_LT", "1", 2, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false);
				fgrid_OpLT.ExtendLastCol = false;
				fgrid_OpLT.AllowEditing = false;
				fgrid_OpLT.Styles.Alternate.BackColor = Color.Empty; 
				fgrid_OpLT.Font = new Font("Verdana", 7);
			
	
  
				//grid setting
				fgrid_ReqNo.Set_Grid("SPO_LOT_DAILY", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, true);
				fgrid_ReqNo.ExtendLastCol = false; 
 

				//Set Combo List
				Init_Control(); 
 

				this.Cursor = Cursors.WaitCursor;

				//LOT Detail 데이터 표시
				Display_LOT_Information(_Factory, _LotNo, _LotSeq); 

				//LOT에 대한 공정 리드타임 전개 표시
				Display_OP_LEADTIME();

				 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}


			 
		}



		/// <summary>
		/// 
		/// </summary>
		private void Init_Control()
		{

			  
			cmb_LOTSt.Enabled = false;
			cmb_OA.Enabled = false;
			cmb_LOTDiv.Enabled = false;


			string[] token = _LOT.Split('-');
			_LotNo = token[0]; 
			_LotSeq = token[1]; 


			
			DataTable dt_ret;
 
			//공통코드 cmb list
			dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxLOTPlanSt);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LOTSt, 1, 2, false, COM.ComVar.ComboList_Visible.Name);  

			dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxLOTOaAppDiv);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OA, 1, 2, false, COM.ComVar.ComboList_Visible.Name);

			dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxLOTDiv);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LOTDiv, 1, 2, false, COM.ComVar.ComboList_Visible.Name);  
 

			//cmb_BOM 
			dt_ret = ProdBase.Form_PB_BOM.Select_SPB_BOM_CD(_Factory);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_BOM, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code);


			
			dpick_OGAC.CustomFormat = " "; 
			obar_main.SelectedPage = obarpg_LeadTime;
 
 
		} 
		


		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		private void Display_LOT_Information(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{
 
			//------------------------
			//display lot detail info
			//------------------------
			DataSet ds_ret = Select_SPO_LOT_INFO(arg_factory, arg_lot_no, arg_lot_seq);
				
			DataTable lot_dt = ds_ret.Tables[0];
			DataTable reqno_dt = ds_ret.Tables[1]; 
  

			txt_Factory.Text = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxFACTORY].ToString();
			txt_LOT.Text = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxLOT].ToString();
			txt_ObsID.Text = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxOBS_ID].ToString();
			txt_ObsType.Text = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxOBS_TYPE].ToString(); 
			
			if(! lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxPO_NO].ToString().Trim().Replace("_", "").Equals("") )
			{
				dpick_OGAC.Text = MyComFunction.ConvertDate2Type(lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxPO_NO].ToString()); 
			}

			txt_Model.Text = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxMODEL_CD].ToString();
			txt_StyleCd.Text = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxSTYLE_CD].ToString();
			txt_Gen.Text = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxGEN].ToString();
			cmb_BOM.SelectedValue = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxBOM_CD].ToString();
			txt_TotalQty.Text = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxLOT_QTY].ToString();
			txt_LossQty.Text = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxTOT_LOSS_QTY].ToString();
	
			cmb_LOTDiv.SelectedValue = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxREAL_LOTYN].ToString();
			chk_HoldYN.Checked = Convert.ToBoolean(lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxHOLD_YN].ToString());
			cmb_OA.SelectedValue = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxPLAN_OAAPP_DIV].ToString();
			txt_LineCd.Text = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxLINE_CD].ToString();
			txt_RtsYMD.Text = MyComFunction.ConvertDate2Type(lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxRTS_YMD].ToString());
			txt_TotDaySeq.Text = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxTOT_DAY_SEQ].ToString();
			txt_PlanStrYMD.Text = MyComFunction.ConvertDate2Type(lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxPLN_STRYMD].ToString());
			txt_PlanEndYMD.Text = MyComFunction.ConvertDate2Type(lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxPLN_ENDYMD].ToString());
			cmb_LOTSt.SelectedValue = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxPLN_STATUS].ToString();
			txt_LOTStYMD.Text = MyComFunction.ConvertDate2Type(lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxPLN_STATUSYMD].ToString());

			//------------------------
			//combo list setting
			//------------------------  
			//cmb_LTCd
			string line_cd = txt_LineCd.Text;
			DataTable dt_ret = ProdOrder.Form_PO_Lot.Select_SPB_LINEOP_LEADTIME_CD(_Factory, line_cd);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LTCd, 0, 0, false, COM.ComVar.ComboList_Visible.Name);  
			cmb_LTCd.SelectedValue = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxLEADTIME_CD].ToString();
			dt_ret.Dispose();

			txt_ApplyYMD.Text = MyComFunction.ConvertDate2Type(lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxAPPLY_YMD].ToString());
			cmb_RoutType.SelectedValue = lot_dt.Rows[0].ItemArray[(int)ClassLib.TBSPO_LOT_DETAIL_MPS.IxROUT_TYPE].ToString();
 

			//------------------------
			//display req_no list
			//------------------------
			fgrid_ReqNo.Rows.Count = fgrid_ReqNo.Rows.Fixed;

			for(int i = 0; i < reqno_dt.Rows.Count; i++)
			{
				fgrid_ReqNo.AddItem(reqno_dt.Rows[i].ItemArray, fgrid_ReqNo.Rows.Count, 1);
				fgrid_ReqNo[i + fgrid_ReqNo.Rows.Fixed, 0] = ""; 
			}
				

			// subtotal 
			fgrid_ReqNo.Subtotal(AggregateEnum.Clear);
			fgrid_ReqNo.SubtotalPosition = SubtotalPositionEnum.BelowData;  
			fgrid_ReqNo.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
			fgrid_ReqNo.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;   
			fgrid_ReqNo.Subtotal(AggregateEnum.Sum, 0, -1, (int)ClassLib.TBSPO_LOT_DETAIL_MPS_ACTION.IxTOT_QTY, "Total");

			fgrid_ReqNo.AutoSizeCols();


		}


		
		/// <summary>
		/// Display_OP_LEADTIME : 
		/// </summary>
		private void Display_OP_LEADTIME()
		{

			string bom_cd = ClassLib.ComFunction.Empty_Combo(cmb_BOM, " ");
			string rout_type = ClassLib.ComFunction.Empty_Combo(cmb_RoutType, " ");

			DataSet ds_ret = Select_SPD_LOT_DAILY_OPLT(_Factory, _LotNo, _LotSeq, bom_cd, rout_type);
			DataTable dt_lt_h = ds_ret.Tables[0];
			DataTable dt_lt_d = ds_ret.Tables[1];
			DataTable dt_ymd = ds_ret.Tables[2];

			//1.공정 날짜 세팅
			Display_OP_LEADTIME_Set_OpYMD(dt_ymd);

			//2. 데이터 표시
			Display_OP_LEADTIME_Set_OpCd(dt_lt_h, fgrid_OpLT);
			Display_OP_LEADTIME_Set_LT(dt_lt_d, fgrid_OpLT); 


		}

		#region Display_OP_LEADTIME 관련


		/// <summary>
		/// Display_OP_LEADTIME_Set_OpYMD : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_OP_LEADTIME_Set_OpYMD(DataTable arg_dt)
		{

			fgrid_OpLT.Cols.Count = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxYMD_START + arg_dt.Rows.Count;

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_OpLT.Cols[i + (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxYMD_START].Width = 62;
				fgrid_OpLT.Cols[i + (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxYMD_START].TextAlign = TextAlignEnum.CenterCenter;

				//요일명 표시
				fgrid_OpLT[1, i + (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxYMD_START] 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBYMD_WEEKDAY].ToString();

				//실제 날짜 표시
				fgrid_OpLT[0, i + (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxYMD_START] 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBYMD_THEDAY].ToString();

				//날짜 표시 형태로 날짜 표시
				fgrid_OpLT[2, i + (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxYMD_START] 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBYMD_THEDAY].ToString().Substring(4, 2) 
					+ ClassLib.ComVar.This_SetedDateSign
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBYMD_THEDAY].ToString().Substring(6, 2);

				//휴일 색깔 처리
				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBYMD_HOLI_YN].ToString() == "N") continue;
				fgrid_OpLT.Cols[i + (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxYMD_START].StyleNew.BackColor = ClassLib.ComVar.ClrDisableHead;
				fgrid_OpLT.Cols[i + (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxYMD_START].Width = 40;

			}

		}



		/// <summary>
		/// Display_OP_LEADTIME_Set_OpCd : 
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_grid"></param>
		private void Display_OP_LEADTIME_Set_OpCd(DataTable arg_dt, COM.FSP arg_fgrid)
		{

			int level = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBCMP_LEVEL; 
			int grid_cmpcd = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxCMP_CD; 
			int grid_opcd = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxOP_CD;
			int grid_routseq = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxROUT_SEQ;
			int grid_opcolor = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxOP_COLOR;
			int grid_cmplevel = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxCMP_LEVEL; 
			 
			 
			arg_fgrid.Tree.Column = grid_opcd;
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
					
				if(arg_dt.Rows[i].ItemArray[level].ToString() == "") continue;

				arg_fgrid.Rows.InsertNode(i + arg_fgrid.Rows.Fixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[level].ToString()) - 1);

				arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cmpcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBCMP_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_routseq] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBROUT_SEQ].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opcolor] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_COLOR].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cmplevel] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBCMP_LEVEL].ToString(); 

				
				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_COLOR].ToString() == "") continue;

                if (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_COLOR] == null
                    || arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_COLOR].ToString().Trim().Equals(""))
                {
                }
                else
                {
                    arg_fgrid.GetCellRange(i + arg_fgrid.Rows.Fixed, grid_opcd).StyleNew.BackColor
                        = Color.FromArgb(Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_COLOR].ToString()));
                }


			} // end for i  
				
			
			//arg_fgrid.Cols[grid_cmpcd].AllowMerging = true;
			arg_fgrid.Tree.Style = TreeStyleFlags.Complete;  
			arg_fgrid.AutoSizeCol(grid_cmpcd);

			 
		}


		/// <summary>
		/// Display_OP_LEADTIME_Set_LT : 
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_grid"></param>
		private void Display_OP_LEADTIME_Set_LT(DataTable arg_dt, COM.FSP arg_fgrid)
		{

			string find_item = "", now_item = "", equal_item = "";
			int set_row = -1;
 
			int grid_cmpcd = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxCMP_CD; 
			int grid_opcd = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxOP_CD;
			int grid_routseq = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxROUT_SEQ;
			int grid_opcolor = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxOP_COLOR;
			int grid_cmplevel = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxCMP_LEVEL;  
 

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				set_row = -1; 

				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_STR_YMD].ToString() == "_") continue;
				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_END_YMD].ToString() == "_") continue;

				find_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBCMP_CD].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_CD].ToString(); 


				for(int j = arg_fgrid.Rows.Fixed; j < arg_fgrid.Rows.Count; j++)
				{
					now_item  = arg_fgrid[j, (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxCMP_CD].ToString()
						+ arg_fgrid[j, (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxOP_CD].ToString(); 

					
					if(find_item == now_item)
					{
						for(int a = j + 1; a < arg_fgrid.Rows.Count; a++)
						{
							equal_item = arg_fgrid[a, (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxCMP_CD].ToString()
								+ arg_fgrid[a, (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxOP_CD].ToString();

							if(now_item != equal_item) 
							{
								set_row = a - 1;
								break;
							}
						} // end for a
						//
						set_row = (set_row == -1) ? set_row = arg_fgrid.Rows.Count - 1 : set_row;
						break;

					} // end if   
				}// end for j

				if(set_row == -1) continue;

				for(int k = (int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxYMD_START; k < arg_fgrid.Cols.Count; k++)
				{
					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_STR_YMD].ToString() == arg_fgrid[0, k].ToString())
					{
						//insert opcd row
						arg_fgrid[set_row, k] = (arg_fgrid[set_row, k] == null) ? "" : arg_fgrid[set_row, k].ToString();

						if(arg_fgrid[set_row, k].ToString() != "")
						{
							set_row++;

							arg_fgrid.Rows.InsertNode(set_row, Convert.ToInt32(arg_fgrid[set_row - 1, grid_cmplevel].ToString()) - 1);

							arg_fgrid[set_row, 0] = ""; 
							arg_fgrid[set_row, grid_cmpcd] = arg_fgrid[set_row - 1, grid_cmpcd];
							arg_fgrid[set_row, grid_opcd] = arg_fgrid[set_row - 1, grid_opcd];
							arg_fgrid[set_row, grid_routseq] = arg_fgrid[set_row - 1, grid_routseq];
							arg_fgrid[set_row, grid_opcolor] = arg_fgrid[set_row - 1, grid_opcolor];
							arg_fgrid[set_row, grid_cmplevel] = arg_fgrid[set_row - 1, grid_cmplevel];
			

							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_COLOR].ToString() != "")
							{
								arg_fgrid.GetCellRange(set_row, grid_opcd).StyleNew.BackColor 
									= Color.FromArgb(Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_COLOR].ToString()) ); 
							}

						}


						int duration = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_END_YMD].ToString()) 
							- Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBOP_STR_YMD].ToString());
						int end_col = k + duration;

						
						arg_fgrid.GetCellRange(set_row, k, set_row, end_col).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow;

						for(int a = k; a <= end_col; a++)
						{
							arg_fgrid[set_row, a] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBSUM_SIZE].ToString() 
								+ " (" + arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBDAY_SEQ].ToString() + ")" ;


							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_OP_LEADTIME.IxTBPLAN_STATUS].ToString() == "D")
							{
								arg_fgrid.GetCellRange(set_row, a).StyleNew.BackColor = ClassLib.ComVar.ClrWarning_Back;
								arg_fgrid.GetCellRange(set_row, a).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;  
							} 

						}

						break;
					}
				} // end for k 

			} // end for i

			
			 
		}



		#endregion 


		#endregion 

		#region 툴바 이벤트 메서드

		#endregion

		#region 그리드 이벤트 메서드

		#endregion

		#region 버튼 및 기타 이벤트 메서드


		/// <summary>
		/// Event_Click_AdaptLT : 
		/// </summary>
		private void Event_Click_AdaptLT()
		{
			
			if(cmb_LTCd.SelectedIndex == -1) 
			{
				ClassLib.ComFunction.Data_Message("Lead Time Code", ClassLib.ComVar.MgsWrongInput, this);
				return;
			}

			string factory = _Factory;
			string lot = txt_LOT.Text;
			string style_cd = txt_StyleCd.Text;
			string line_cd = txt_LineCd.Text;
			string leadtime_cd = ClassLib.ComFunction.Empty_Combo(cmb_LTCd, " ");
			string apply_ymd = txt_ApplyYMD.Text.Replace(ClassLib.ComVar.This_SetedDateSign, ""); 
			 
			Pop_AdaptLeadTime pop_form = new Pop_AdaptLeadTime(factory, lot, style_cd, line_cd, leadtime_cd, apply_ymd);
			pop_form.ShowDialog(); 
  

			//LOT Detail 데이터 표시
			Display_LOT_Information(_Factory, _LotNo, _LotSeq);
				
			//LOT에 대한 공정 리드타임 전개 표시
			Display_OP_LEADTIME();

		}



		/// <summary>
		/// Event_Click_LOTApply : 
		/// </summary>
		private void Event_Click_LOTApply()
		{
			

			// poweruser 권한이면, 비밀번호 인증 후. 작업 가능 처리
			if(ClassLib.ComVar.This_PowerUser_YN == "Y")
			{

				Pop_Password pop_password = new Pop_Password();
				pop_password.ShowDialog();

				// 비밀번호 인증 캔슬이거나, 비밀번호 인증 실패일 경우 처리 불가능
				if(! pop_password._Apply_Flag) return;
				if(! pop_password._Password_OK_Flag) return; 

			}
			else
			{
				ClassLib.ComFunction.User_Message("Can't change LOT Information.", "LOT Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}



			// 사전 체크
			// 1. bom_cd,  2. rout_type,   3. leadtime_cd null
			if(cmb_BOM.SelectedIndex == -1) 
			{
				ClassLib.ComFunction.Data_Message("BOM Code", ClassLib.ComVar.MgsNotHaveData, this);
				cmb_BOM.Focus();
				return;
			}

			if(cmb_RoutType.SelectedIndex == -1) 
			{
				ClassLib.ComFunction.Data_Message("BOM Routing Type", ClassLib.ComVar.MgsNotHaveData, this);
				cmb_RoutType.Focus();
				return;
			}

			if(cmb_LTCd.SelectedIndex == -1) 
			{
				ClassLib.ComFunction.Data_Message("Leadtime Code", ClassLib.ComVar.MgsNotHaveData, this);
				cmb_LTCd.Focus();
				return;
			}



			// LOT 정보 수정
			bool save_flag = Update_SPO_LOT();

			if(!save_flag)
			{
				_CloseSave = false;
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave);
				return;
			}
			else
			{
				_CloseSave = true;
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave);

				
				
				//LOT Detail 데이터 표시
				Display_LOT_Information(_Factory, _LotNo, _LotSeq); 

				//LOT에 대한 공정 리드타임 전개 표시
				Display_OP_LEADTIME();


			}

		}


		/// <summary>
		/// Event_Click_Commit : Reqno 별 LOT Divide 실행
		/// </summary>
		private void Event_Click_Commit()
		{

			//_CloseSave = true

		}


		#endregion
 

		#endregion 

		#region 이벤트 처리


		#region 툴바 이벤트

		#endregion

		#region 그리드 이벤트

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


		private void dpick_OGAC_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{  
				dpick_OGAC.CustomFormat = ClassLib.ComVar.This_SetedDateType;  
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_OGAC_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void cmb_BOM_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 

				this.Cursor = Cursors.WaitCursor;

				if(cmb_BOM.SelectedIndex == -1) return;

				//cmb_RoutType
				string bom_cd = cmb_BOM.SelectedValue.ToString();

				DataTable dt_ret = ProdOrder.Form_PO_Lot.Select_SPB_BOM_ROUT_TYPE(_Factory, bom_cd);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_RoutType, 0, 0, false, COM.ComVar.ComboList_Visible.Code); 
				
				if(cmb_RoutType.ListCount > 0)
				{
					cmb_RoutType.SelectedIndex = 0;
				}



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_BOM_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}


		private void obar_main_SelectedPageChanged(object sender, System.EventArgs e)
		{
			
			try
			{ 
//				if(obar_main.SelectedPage.Name.ToString() == "obarpg_LeadTime")
//				{
//					btn_Commit.Enabled = false;
//				}
//				else if(obar_main.SelectedPage.Name.ToString() == "obarpg_Req")
//				{
//					 btn_Commit.Enabled = true;
//				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_BOM_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}



		private void btn_OpLT_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				 
				this.Cursor = Cursors.WaitCursor;

				string apply_ymd = txt_ApplyYMD.Text.Replace(ClassLib.ComVar.This_SetedDateSign, "");
				string factory = _Factory;
				string line_cd = txt_LineCd.Text;
				string leadtime_cd = ClassLib.ComFunction.Empty_Combo(cmb_LTCd, " ");
				
				ClassLib.ComVar.Parameter_PopUp = new string[] { apply_ymd, factory, line_cd, leadtime_cd };

				FlexAPS.ProdBase.Pop_DisplayOpLeadTime pop_form = new FlexAPS.ProdBase.Pop_DisplayOpLeadTime();
				pop_form.Show();

				 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_OpLT_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		private void btn_Model_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				
				this.Cursor = Cursors.WaitCursor;

				ProdBase.Form_PB_Model pop_form = new ProdBase.Form_PB_Model();
				pop_form.WindowState = FormWindowState.Normal;
				pop_form.Show();

				pop_form.cmb_MFactory.SelectedValue = _Factory;
				pop_form.cmb_MDYear.SelectedValue = txt_Model.Text.Substring(0, 2); 
				int findrow = pop_form.fgrid_MModelDetail.FindRow(txt_Model.Text, pop_form.fgrid_MModelDetail.Rows.Fixed, (int)ClassLib.TBSPB_MODEL.IxMODEL_CD, false, true, false);
				if(findrow != -1)
				{
					pop_form.txt_MDModel.Text = pop_form.fgrid_MModelDetail[findrow, (int)(int)ClassLib.TBSPB_MODEL.IxMODEL_NAME].ToString();
					pop_form.fgrid_MModelDetail.Select(findrow, 0, findrow, pop_form.fgrid_MModelDetail.Cols.Count - 1, true);
					pop_form.Display_BOM();
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Model_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void btn_BOM_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				
				this.Cursor = Cursors.WaitCursor;

				ProdBase.Form_PB_BOMRout pop_form = new ProdBase.Form_PB_BOMRout(); 
   
				ClassLib.ComVar.MenuClick_Flag = true; 

				//pop_form.ShowDialog();

				pop_form.WindowState = System.Windows.Forms.FormWindowState.Normal;
				pop_form.Show();
				pop_form.Set_Factory(_Factory);
				pop_form.Set_BomCd(cmb_BOM.SelectedValue.ToString());
				pop_form.Set_RoutType(cmb_RoutType.SelectedValue.ToString());
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_BOM_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void btn_AdaptLT_Click(object sender, System.EventArgs e)
		{
			try
			{   
				this.Cursor = Cursors.WaitCursor;

				Event_Click_AdaptLT(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_AdaptLT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 

		private void btn_LOTApply_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Event_Click_LOTApply();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_LOTApply", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void btn_Refresh_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				
				this.Cursor = Cursors.WaitCursor;

				//LOT Detail 데이터 표시
				Display_LOT_Information(_Factory, _LotNo, _LotSeq); 

				//LOT에 대한 공정 리드타임 전개 표시
				Display_OP_LEADTIME();
	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Refresh_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void btn_Commit_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Event_Click_Commit();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_Commit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				
				if(!_CloseSave) 
				{
					_CloseSave = false;
				}

				this.Close();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}


		#endregion

		


		#endregion  
 
		#region 디비 연결
  

		/// <summary>
		/// Select_SPO_LOT_INFO : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		public static DataSet Select_SPO_LOT_INFO(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{
			
			try
			{ 

				COM.OraDB myOraDB = new COM.OraDB();

				DataSet ds_ret;  

				string process_name = "PKG_SPO_MPS_BSC.SELECT_SPO_LOT_DETAIL";

				myOraDB.ReDim_Parameter(4); 
 
				myOraDB.Process_Name = process_name; 

				myOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				myOraDB.Parameter_Name[1] = "ARG_LOT_NO"; 
				myOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				myOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				myOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				myOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				myOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				myOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				myOraDB.Parameter_Values[0] = arg_factory; 
				myOraDB.Parameter_Values[1] = arg_lot_no; 
				myOraDB.Parameter_Values[2] = arg_lot_seq;  
				myOraDB.Parameter_Values[3] = ""; 

				myOraDB.Add_Select_Parameter(true); 




				process_name = "PKG_SPO_MPS_BSC.SELECT_SPO_RECV_LOT";

				myOraDB.ReDim_Parameter(4); 
 
				myOraDB.Process_Name = process_name; 

				myOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				myOraDB.Parameter_Name[1] = "ARG_LOT_NO"; 
				myOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				myOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				myOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				myOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				myOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				myOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				myOraDB.Parameter_Values[0] = arg_factory; 
				myOraDB.Parameter_Values[1] = arg_lot_no; 
				myOraDB.Parameter_Values[2] = arg_lot_seq;  
				myOraDB.Parameter_Values[3] = ""; 

				myOraDB.Add_Select_Parameter(false); 

				ds_ret = myOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret;  
			}
			catch
			{
				return null;
			}

		} 
		 


		/// <summary>
		/// Select_SPD_LOT_DAILY_OPLT : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <param name="arg_bom_cd"></param>
		/// <param name="arg_rout_type"></param>
		/// <returns></returns>
		private DataSet Select_SPD_LOT_DAILY_OPLT(string arg_factory, 
			string arg_lot_no,
			string arg_lot_seq,
			string arg_bom_cd, 
			string arg_rout_type)
		{
			DataSet ds_ret;  

			try
			{ 
				string process_name = "PKG_SPO_MPS_BSC.SELECT_SPD_LOT_DAILY_OP_LT_H";

//				MyOraDB.ReDim_Parameter(4); 
// 
//				MyOraDB.Process_Name = process_name; 
//
//				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
//				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
//				MyOraDB.Parameter_Name[2] = "ARG_ROUT_TYPE"; 
//				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
// 
//				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
//				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
//				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
//				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
//			 
//				MyOraDB.Parameter_Values[0] = arg_factory; 
//				MyOraDB.Parameter_Values[1] = arg_bom_cd;
//				MyOraDB.Parameter_Values[2] = arg_rout_type;
//				MyOraDB.Parameter_Values[3] = ""; 
//
//				MyOraDB.Add_Select_Parameter(true);  



				MyOraDB.ReDim_Parameter(6); 
 
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_bom_cd;
				MyOraDB.Parameter_Values[2] = arg_rout_type;
				MyOraDB.Parameter_Values[3] = arg_lot_no; 
				MyOraDB.Parameter_Values[4] = arg_lot_seq; 
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true);





				process_name = "PKG_SPO_MPS_BSC.SELECT_SPD_LOT_DAILY_OP_LT_D";

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

				MyOraDB.Add_Select_Parameter(false); 



				process_name = "PKG_SPO_MPS_BSC.SELECT_SPD_LOT_DAILY_OPLT_YMD";

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

				MyOraDB.Add_Select_Parameter(false); 

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
		/// Update_SPO_LOT : LOT 정보 수정(OGAC(PO_NO), BOM 코드, ROUT_TYPE 코드, LEADTIME 코드)
		/// </summary> 
		private bool Update_SPO_LOT()
		{   
			try
			{
				int col_ct = 17;

				MyOraDB.ReDim_Parameter(col_ct);  
				MyOraDB.Process_Name = "PKG_SPO_LOT_BSC.SAVE_SPORECV_SPOLOT";
  
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[2] = "ARG_REQ_NO"; 
				MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[6] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[7] = "ARG_PO_NO";
				MyOraDB.Parameter_Name[8] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[9] = "ARG_TOT_QTY";
				MyOraDB.Parameter_Name[10] = "ARG_LOT_QTY"; 
				MyOraDB.Parameter_Name[11] = "ARG_REAL_LOTYN";
				MyOraDB.Parameter_Name[12] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[13] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[14] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[15] = "ARG_ROUT_TYPE";
				MyOraDB.Parameter_Name[16] = "ARG_LEADTIME_CD";
  
				for(int i = 0; i < col_ct; i++)
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
  
				MyOraDB.Parameter_Values[0]  = "U"; 
				MyOraDB.Parameter_Values[1]  = _Factory; 
				MyOraDB.Parameter_Values[2]  = ""; 
				MyOraDB.Parameter_Values[3]  = _LotNo; 
				MyOraDB.Parameter_Values[4]  = _LotSeq; 
				MyOraDB.Parameter_Values[5]  = ""; 
				MyOraDB.Parameter_Values[6]  = ""; 
				MyOraDB.Parameter_Values[7]  = dpick_OGAC.Value.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[8]  = ""; 
				MyOraDB.Parameter_Values[9]  = "";  
				MyOraDB.Parameter_Values[10] = "";  
				MyOraDB.Parameter_Values[11] = ""; 
				MyOraDB.Parameter_Values[12] = "";  
				MyOraDB.Parameter_Values[13] = ClassLib.ComVar.This_User; 
				MyOraDB.Parameter_Values[14] = ClassLib.ComFunction.Empty_Combo(cmb_BOM, " ");
				MyOraDB.Parameter_Values[15] = ClassLib.ComFunction.Empty_Combo(cmb_RoutType, " ");
				MyOraDB.Parameter_Values[16] = ClassLib.ComFunction.Empty_Combo(cmb_LTCd, " ");

				MyOraDB.Add_Modify_Parameter(true);
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
			catch
			{ 
				return false;
			}
		}




		#endregion

		

 

 
	}
}

