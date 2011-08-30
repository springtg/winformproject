using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;
using Lassalle.Flow; 






namespace FlexOrder.ExpOA
{
	public class Form_OA_Create : COM.OrderWinForm.Form_Top
	{

		#region 컨트롤 및 리소스 정의


		private System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.Panel pnl_OA_Info;
		private System.Windows.Forms.Panel panel7;
		private C1.Win.C1List.C1Combo cmb_OBS_Type;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.Label lbl_OBS_ID;
		private C1.Win.C1List.C1Combo cmb_OBS_ID;
		private System.Windows.Forms.Label lbl_St;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox25;
		private System.Windows.Forms.PictureBox pictureBox26;
		private System.Windows.Forms.PictureBox pictureBox27;
		private System.Windows.Forms.PictureBox pictureBox28;
		private System.Windows.Forms.PictureBox pictureBox29;
		private System.Windows.Forms.PictureBox pictureBox30;
		private System.Windows.Forms.PictureBox pictureBox31;
		private System.Windows.Forms.PictureBox pictureBox32;
		private System.Windows.Forms.Label lbl_OA_Nu;
		private C1.Win.C1List.C1Combo cmb_OA_Nu;
		private C1.Win.C1List.C1Combo cmb_Style_Cd;
		public System.Windows.Forms.Panel pnl_Left;
		private System.Windows.Forms.Label lbl_OA_Title;
		private System.Windows.Forms.Panel pnl_Order;
		private System.Windows.Forms.Panel panel6;
		public COM.FSP fgrid_Order;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Label lbl_Order_Title;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.TextBox txt_Style_Cd;
		private System.Windows.Forms.Splitter splitter1;
		public System.Windows.Forms.Panel pnl_Right;
		private System.Windows.Forms.Panel pnl_OA_Detail;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_OA_Detail;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Panel pnl_Balance;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		public COM.FSP fgrid_Balance;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.Label lbl_Balance_Title;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.PictureBox pictureBox23;
		private System.Windows.Forms.PictureBox pictureBox24;
		private System.Windows.Forms.Panel pnl_AddFlow;
		private System.Windows.Forms.ContextMenu ctm_Order;
		private System.Windows.Forms.MenuItem mnt_Delete;
		private System.Windows.Forms.MenuItem mnt_Insert;
		private System.Windows.Forms.MenuItem mnt_Cancel;
		private Lassalle.Flow.AddFlow AddFlow;
		private System.Windows.Forms.ContextMenu cmt_AddFlow;
		private System.Windows.Forms.MenuItem mnt_ClearAll;
		private System.Windows.Forms.MenuItem mnt_Cancel_All;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private C1.Win.C1List.C1Combo cmb_FirstClass;
		private C1.Win.C1List.C1Combo cmb_SecondClass;
		private System.Windows.Forms.TextBox txt_Purchase_No;
		private C1.Win.C1List.C1Combo cmb_Season_Code;
		private System.Windows.Forms.TextBox txt_Our_Reference;
		private System.Windows.Forms.TextBox txt_Order_Reason;
		private System.Windows.Forms.TextBox txt_Purchase_Group;
		private System.Windows.Forms.TextBox txt_Qual_Iseq;
		private System.Windows.Forms.TextBox txt_Your_Reference;
		private System.Windows.Forms.DateTimePicker dtp_Adjust_Date;
		private System.Windows.Forms.DateTimePicker dtp_Apply_Date;
		private C1.Win.C1List.C1Combo cmb_Season_Year;
		private System.Windows.Forms.TextBox txt_Remarks;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Confirm;
		private System.Windows.Forms.ImageList img_Button2;
		private System.Windows.Forms.Label btn_OBS_ID;
		private System.Windows.Forms.MenuItem mnt_Bar;
		private System.ComponentModel.IContainer components = null;

		public Form_OA_Create()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_OA_Create));
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.pnl_Right = new System.Windows.Forms.Panel();
			this.pnl_OA_Detail = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.dtp_Apply_Date = new System.Windows.Forms.DateTimePicker();
			this.dtp_Adjust_Date = new System.Windows.Forms.DateTimePicker();
			this.txt_Your_Reference = new System.Windows.Forms.TextBox();
			this.txt_Remarks = new System.Windows.Forms.TextBox();
			this.txt_Qual_Iseq = new System.Windows.Forms.TextBox();
			this.txt_Purchase_Group = new System.Windows.Forms.TextBox();
			this.cmb_FirstClass = new C1.Win.C1List.C1Combo();
			this.txt_Order_Reason = new System.Windows.Forms.TextBox();
			this.txt_Our_Reference = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cmb_Season_Code = new C1.Win.C1List.C1Combo();
			this.txt_Purchase_No = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmb_Season_Year = new C1.Win.C1List.C1Combo();
			this.label2 = new System.Windows.Forms.Label();
			this.cmb_SecondClass = new C1.Win.C1List.C1Combo();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_OA_Detail = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pnl_Balance = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.fgrid_Balance = new COM.FSP();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.lbl_Balance_Title = new System.Windows.Forms.Label();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.pnl_AddFlow = new System.Windows.Forms.Panel();
			this.AddFlow = new Lassalle.Flow.AddFlow();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pnl_Left = new System.Windows.Forms.Panel();
			this.pnl_Order = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.fgrid_Order = new COM.FSP();
			this.ctm_Order = new System.Windows.Forms.ContextMenu();
			this.mnt_Delete = new System.Windows.Forms.MenuItem();
			this.mnt_Insert = new System.Windows.Forms.MenuItem();
			this.mnt_Bar = new System.Windows.Forms.MenuItem();
			this.mnt_Cancel = new System.Windows.Forms.MenuItem();
			this.mnt_Cancel_All = new System.Windows.Forms.MenuItem();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.lbl_Order_Title = new System.Windows.Forms.Label();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pnl_OA_Info = new System.Windows.Forms.Panel();
			this.cmb_OA_Nu = new C1.Win.C1List.C1Combo();
			this.panel7 = new System.Windows.Forms.Panel();
			this.btn_OBS_ID = new System.Windows.Forms.Label();
			this.img_Button2 = new System.Windows.Forms.ImageList(this.components);
			this.txt_Style_Cd = new System.Windows.Forms.TextBox();
			this.cmb_Style_Cd = new C1.Win.C1List.C1Combo();
			this.lbl_OA_Nu = new System.Windows.Forms.Label();
			this.cmb_OBS_Type = new C1.Win.C1List.C1Combo();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.lbl_OBS_ID = new System.Windows.Forms.Label();
			this.cmb_OBS_ID = new C1.Win.C1List.C1Combo();
			this.lbl_St = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox25 = new System.Windows.Forms.PictureBox();
			this.pictureBox26 = new System.Windows.Forms.PictureBox();
			this.lbl_OA_Title = new System.Windows.Forms.Label();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.pictureBox28 = new System.Windows.Forms.PictureBox();
			this.pictureBox29 = new System.Windows.Forms.PictureBox();
			this.pictureBox30 = new System.Windows.Forms.PictureBox();
			this.pictureBox31 = new System.Windows.Forms.PictureBox();
			this.pictureBox32 = new System.Windows.Forms.PictureBox();
			this.cmt_AddFlow = new System.Windows.Forms.ContextMenu();
			this.mnt_ClearAll = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Body.SuspendLayout();
			this.pnl_Right.SuspendLayout();
			this.pnl_OA_Detail.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_FirstClass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_Code)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_Year)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_SecondClass)).BeginInit();
			this.pnl_Balance.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Balance)).BeginInit();
			this.pnl_AddFlow.SuspendLayout();
			this.pnl_Left.SuspendLayout();
			this.pnl_Order.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Order)).BeginInit();
			this.pnl_OA_Info.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OA_Nu)).BeginInit();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style_Cd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).BeginInit();
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
			this.pnl_Body.Controls.Add(this.pnl_Right);
			this.pnl_Body.Controls.Add(this.splitter1);
			this.pnl_Body.Controls.Add(this.pnl_Left);
			this.pnl_Body.Location = new System.Drawing.Point(0, 48);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 592);
			this.pnl_Body.TabIndex = 54;
			// 
			// pnl_Right
			// 
			this.pnl_Right.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Right.Controls.Add(this.pnl_OA_Detail);
			this.pnl_Right.Controls.Add(this.pnl_Balance);
			this.pnl_Right.Controls.Add(this.pnl_AddFlow);
			this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Right.Location = new System.Drawing.Point(355, 0);
			this.pnl_Right.Name = "pnl_Right";
			this.pnl_Right.Size = new System.Drawing.Size(661, 592);
			this.pnl_Right.TabIndex = 56;
			// 
			// pnl_OA_Detail
			// 
			this.pnl_OA_Detail.Controls.Add(this.panel2);
			this.pnl_OA_Detail.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_OA_Detail.Location = new System.Drawing.Point(0, 0);
			this.pnl_OA_Detail.Name = "pnl_OA_Detail";
			this.pnl_OA_Detail.Size = new System.Drawing.Size(661, 160);
			this.pnl_OA_Detail.TabIndex = 131;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.DockPadding.Right = 4;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(661, 152);
			this.panel2.TabIndex = 129;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.RosyBrown;
			this.panel3.Controls.Add(this.btn_Cancel);
			this.panel3.Controls.Add(this.btn_Confirm);
			this.panel3.Controls.Add(this.dtp_Apply_Date);
			this.panel3.Controls.Add(this.dtp_Adjust_Date);
			this.panel3.Controls.Add(this.txt_Your_Reference);
			this.panel3.Controls.Add(this.txt_Remarks);
			this.panel3.Controls.Add(this.txt_Qual_Iseq);
			this.panel3.Controls.Add(this.txt_Purchase_Group);
			this.panel3.Controls.Add(this.cmb_FirstClass);
			this.panel3.Controls.Add(this.txt_Order_Reason);
			this.panel3.Controls.Add(this.txt_Our_Reference);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.cmb_Season_Code);
			this.panel3.Controls.Add(this.txt_Purchase_No);
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.label14);
			this.panel3.Controls.Add(this.label15);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.cmb_Season_Year);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.cmb_SecondClass);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Controls.Add(this.pictureBox2);
			this.panel3.Controls.Add(this.lbl_OA_Detail);
			this.panel3.Controls.Add(this.pictureBox3);
			this.panel3.Controls.Add(this.pictureBox4);
			this.panel3.Controls.Add(this.pictureBox5);
			this.panel3.Controls.Add(this.pictureBox6);
			this.panel3.Controls.Add(this.pictureBox7);
			this.panel3.Controls.Add(this.pictureBox8);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(657, 152);
			this.panel3.TabIndex = 1;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
			this.btn_Cancel.Location = new System.Drawing.Point(551, 120);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(100, 23);
			this.btn_Cancel.TabIndex = 227;
			this.btn_Cancel.Text = "*Cancel";
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Confirm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Confirm.ForeColor = System.Drawing.Color.Black;
			this.btn_Confirm.Location = new System.Drawing.Point(448, 120);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(100, 23);
			this.btn_Confirm.TabIndex = 226;
			this.btn_Confirm.Text = "*Confirm";
			this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
			// 
			// dtp_Apply_Date
			// 
			this.dtp_Apply_Date.CustomFormat = "yyyy-MM-dd";
			this.dtp_Apply_Date.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.dtp_Apply_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Apply_Date.Location = new System.Drawing.Point(108, 55);
			this.dtp_Apply_Date.Name = "dtp_Apply_Date";
			this.dtp_Apply_Date.Size = new System.Drawing.Size(105, 20);
			this.dtp_Apply_Date.TabIndex = 225;
			// 
			// dtp_Adjust_Date
			// 
			this.dtp_Adjust_Date.CustomFormat = "yyyy-MM-dd";
			this.dtp_Adjust_Date.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.dtp_Adjust_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Adjust_Date.Location = new System.Drawing.Point(547, 34);
			this.dtp_Adjust_Date.Name = "dtp_Adjust_Date";
			this.dtp_Adjust_Date.Size = new System.Drawing.Size(105, 20);
			this.dtp_Adjust_Date.TabIndex = 224;
			// 
			// txt_Your_Reference
			// 
			this.txt_Your_Reference.BackColor = System.Drawing.Color.White;
			this.txt_Your_Reference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Your_Reference.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Your_Reference.Location = new System.Drawing.Point(331, 77);
			this.txt_Your_Reference.MaxLength = 100;
			this.txt_Your_Reference.Name = "txt_Your_Reference";
			this.txt_Your_Reference.Size = new System.Drawing.Size(104, 19);
			this.txt_Your_Reference.TabIndex = 215;
			this.txt_Your_Reference.Text = "";
			// 
			// txt_Remarks
			// 
			this.txt_Remarks.BackColor = System.Drawing.Color.White;
			this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Remarks.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Remarks.Location = new System.Drawing.Point(109, 121);
			this.txt_Remarks.MaxLength = 100;
			this.txt_Remarks.Name = "txt_Remarks";
			this.txt_Remarks.Size = new System.Drawing.Size(325, 19);
			this.txt_Remarks.TabIndex = 214;
			this.txt_Remarks.Text = "";
			// 
			// txt_Qual_Iseq
			// 
			this.txt_Qual_Iseq.BackColor = System.Drawing.Color.White;
			this.txt_Qual_Iseq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Qual_Iseq.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Qual_Iseq.Location = new System.Drawing.Point(109, 99);
			this.txt_Qual_Iseq.MaxLength = 100;
			this.txt_Qual_Iseq.Name = "txt_Qual_Iseq";
			this.txt_Qual_Iseq.Size = new System.Drawing.Size(104, 19);
			this.txt_Qual_Iseq.TabIndex = 212;
			this.txt_Qual_Iseq.Text = "";
			// 
			// txt_Purchase_Group
			// 
			this.txt_Purchase_Group.BackColor = System.Drawing.Color.White;
			this.txt_Purchase_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Purchase_Group.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Purchase_Group.Location = new System.Drawing.Point(109, 77);
			this.txt_Purchase_Group.MaxLength = 100;
			this.txt_Purchase_Group.Name = "txt_Purchase_Group";
			this.txt_Purchase_Group.Size = new System.Drawing.Size(104, 19);
			this.txt_Purchase_Group.TabIndex = 211;
			this.txt_Purchase_Group.Text = "";
			// 
			// cmb_FirstClass
			// 
			this.cmb_FirstClass.AddItemCols = 0;
			this.cmb_FirstClass.AddItemSeparator = ';';
			this.cmb_FirstClass.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_FirstClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_FirstClass.Caption = "";
			this.cmb_FirstClass.CaptionHeight = 17;
			this.cmb_FirstClass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_FirstClass.ColumnCaptionHeight = 18;
			this.cmb_FirstClass.ColumnFooterHeight = 18;
			this.cmb_FirstClass.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_FirstClass.ContentHeight = 15;
			this.cmb_FirstClass.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_FirstClass.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_FirstClass.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_FirstClass.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_FirstClass.EditorHeight = 15;
			this.cmb_FirstClass.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_FirstClass.GapHeight = 2;
			this.cmb_FirstClass.ItemHeight = 15;
			this.cmb_FirstClass.Location = new System.Drawing.Point(108, 34);
			this.cmb_FirstClass.MatchEntryTimeout = ((long)(2000));
			this.cmb_FirstClass.MaxDropDownItems = ((short)(5));
			this.cmb_FirstClass.MaxLength = 32767;
			this.cmb_FirstClass.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_FirstClass.Name = "cmb_FirstClass";
			this.cmb_FirstClass.PartialRightColumn = false;
			this.cmb_FirstClass.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_FirstClass.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_FirstClass.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_FirstClass.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_FirstClass.Size = new System.Drawing.Size(104, 19);
			this.cmb_FirstClass.TabIndex = 120;
			// 
			// txt_Order_Reason
			// 
			this.txt_Order_Reason.BackColor = System.Drawing.Color.White;
			this.txt_Order_Reason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Order_Reason.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Order_Reason.Location = new System.Drawing.Point(547, 77);
			this.txt_Order_Reason.MaxLength = 100;
			this.txt_Order_Reason.Name = "txt_Order_Reason";
			this.txt_Order_Reason.Size = new System.Drawing.Size(104, 19);
			this.txt_Order_Reason.TabIndex = 210;
			this.txt_Order_Reason.Text = "";
			// 
			// txt_Our_Reference
			// 
			this.txt_Our_Reference.BackColor = System.Drawing.Color.White;
			this.txt_Our_Reference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Our_Reference.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Our_Reference.Location = new System.Drawing.Point(547, 55);
			this.txt_Our_Reference.MaxLength = 100;
			this.txt_Our_Reference.Name = "txt_Our_Reference";
			this.txt_Our_Reference.Size = new System.Drawing.Size(104, 19);
			this.txt_Our_Reference.TabIndex = 209;
			this.txt_Our_Reference.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label11.Font = new System.Drawing.Font("Verdana", 8F);
			this.label11.ImageIndex = 1;
			this.label11.ImageList = this.img_Label;
			this.label11.Location = new System.Drawing.Point(7, 120);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 21);
			this.label11.TabIndex = 132;
			this.label11.Text = "Remarks";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label8.Font = new System.Drawing.Font("Verdana", 8F);
			this.label8.ImageIndex = 1;
			this.label8.ImageList = this.img_Label;
			this.label8.Location = new System.Drawing.Point(7, 98);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 21);
			this.label8.TabIndex = 129;
			this.label8.Text = "Qual Iseq";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Season_Code
			// 
			this.cmb_Season_Code.AddItemCols = 0;
			this.cmb_Season_Code.AddItemSeparator = ';';
			this.cmb_Season_Code.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Season_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Season_Code.Caption = "";
			this.cmb_Season_Code.CaptionHeight = 17;
			this.cmb_Season_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Season_Code.ColumnCaptionHeight = 18;
			this.cmb_Season_Code.ColumnFooterHeight = 18;
			this.cmb_Season_Code.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Season_Code.ContentHeight = 15;
			this.cmb_Season_Code.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Season_Code.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Season_Code.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Season_Code.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Season_Code.EditorHeight = 15;
			this.cmb_Season_Code.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Season_Code.GapHeight = 2;
			this.cmb_Season_Code.ItemHeight = 15;
			this.cmb_Season_Code.Location = new System.Drawing.Point(331, 99);
			this.cmb_Season_Code.MatchEntryTimeout = ((long)(2000));
			this.cmb_Season_Code.MaxDropDownItems = ((short)(5));
			this.cmb_Season_Code.MaxLength = 32767;
			this.cmb_Season_Code.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Season_Code.Name = "cmb_Season_Code";
			this.cmb_Season_Code.PartialRightColumn = false;
			this.cmb_Season_Code.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Season_Code.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Season_Code.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Season_Code.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Season_Code.Size = new System.Drawing.Size(104, 19);
			this.cmb_Season_Code.TabIndex = 208;
			// 
			// txt_Purchase_No
			// 
			this.txt_Purchase_No.BackColor = System.Drawing.Color.White;
			this.txt_Purchase_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Purchase_No.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Purchase_No.Location = new System.Drawing.Point(331, 55);
			this.txt_Purchase_No.MaxLength = 100;
			this.txt_Purchase_No.Name = "txt_Purchase_No";
			this.txt_Purchase_No.Size = new System.Drawing.Size(104, 19);
			this.txt_Purchase_No.TabIndex = 207;
			this.txt_Purchase_No.Text = "";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label13.Font = new System.Drawing.Font("Verdana", 8F);
			this.label13.ImageIndex = 1;
			this.label13.ImageList = this.img_Label;
			this.label13.Location = new System.Drawing.Point(446, 76);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 21);
			this.label13.TabIndex = 135;
			this.label13.Text = "Order Reason";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label14.Font = new System.Drawing.Font("Verdana", 8F);
			this.label14.ImageIndex = 1;
			this.label14.ImageList = this.img_Label;
			this.label14.Location = new System.Drawing.Point(446, 98);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 21);
			this.label14.TabIndex = 134;
			this.label14.Text = "Season Year";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label15.Font = new System.Drawing.Font("Verdana", 8F);
			this.label15.ImageIndex = 1;
			this.label15.ImageList = this.img_Label;
			this.label15.Location = new System.Drawing.Point(446, 54);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 21);
			this.label15.TabIndex = 133;
			this.label15.Text = "Our Reference";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 1;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(446, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 123;
			this.label3.Text = "Adjust Date";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Season_Year
			// 
			this.cmb_Season_Year.AddItemCols = 0;
			this.cmb_Season_Year.AddItemSeparator = ';';
			this.cmb_Season_Year.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Season_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Season_Year.Caption = "";
			this.cmb_Season_Year.CaptionHeight = 17;
			this.cmb_Season_Year.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Season_Year.ColumnCaptionHeight = 18;
			this.cmb_Season_Year.ColumnFooterHeight = 18;
			this.cmb_Season_Year.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Season_Year.ContentHeight = 15;
			this.cmb_Season_Year.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Season_Year.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Season_Year.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Season_Year.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Season_Year.EditorHeight = 15;
			this.cmb_Season_Year.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Season_Year.GapHeight = 2;
			this.cmb_Season_Year.ItemHeight = 15;
			this.cmb_Season_Year.Location = new System.Drawing.Point(547, 99);
			this.cmb_Season_Year.MatchEntryTimeout = ((long)(2000));
			this.cmb_Season_Year.MaxDropDownItems = ((short)(5));
			this.cmb_Season_Year.MaxLength = 32767;
			this.cmb_Season_Year.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Season_Year.Name = "cmb_Season_Year";
			this.cmb_Season_Year.PartialRightColumn = false;
			this.cmb_Season_Year.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Season_Year.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Season_Year.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Season_Year.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Season_Year.Size = new System.Drawing.Size(104, 19);
			this.cmb_Season_Year.TabIndex = 124;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Verdana", 8F);
			this.label2.ImageIndex = 1;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(230, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 121;
			this.label2.Text = "Second Class";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_SecondClass
			// 
			this.cmb_SecondClass.AddItemCols = 0;
			this.cmb_SecondClass.AddItemSeparator = ';';
			this.cmb_SecondClass.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_SecondClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_SecondClass.Caption = "";
			this.cmb_SecondClass.CaptionHeight = 17;
			this.cmb_SecondClass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_SecondClass.ColumnCaptionHeight = 18;
			this.cmb_SecondClass.ColumnFooterHeight = 18;
			this.cmb_SecondClass.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_SecondClass.ContentHeight = 15;
			this.cmb_SecondClass.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_SecondClass.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_SecondClass.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_SecondClass.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_SecondClass.EditorHeight = 15;
			this.cmb_SecondClass.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_SecondClass.GapHeight = 2;
			this.cmb_SecondClass.ItemHeight = 15;
			this.cmb_SecondClass.Location = new System.Drawing.Point(331, 34);
			this.cmb_SecondClass.MatchEntryTimeout = ((long)(2000));
			this.cmb_SecondClass.MaxDropDownItems = ((short)(5));
			this.cmb_SecondClass.MaxLength = 32767;
			this.cmb_SecondClass.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_SecondClass.Name = "cmb_SecondClass";
			this.cmb_SecondClass.PartialRightColumn = false;
			this.cmb_SecondClass.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_SecondClass.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_SecondClass.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_SecondClass.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_SecondClass.Size = new System.Drawing.Size(104, 19);
			this.cmb_SecondClass.TabIndex = 122;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label10.Font = new System.Drawing.Font("Verdana", 8F);
			this.label10.ImageIndex = 1;
			this.label10.ImageList = this.img_Label;
			this.label10.Location = new System.Drawing.Point(7, 54);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 21);
			this.label10.TabIndex = 131;
			this.label10.Text = "Apply Date";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("Verdana", 8F);
			this.label9.ImageIndex = 1;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(7, 76);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 130;
			this.label9.Text = "Purchase Group";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 1;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(7, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 119;
			this.label1.Text = "First Class";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label6.Font = new System.Drawing.Font("Verdana", 8F);
			this.label6.ImageIndex = 1;
			this.label6.ImageList = this.img_Label;
			this.label6.Location = new System.Drawing.Point(230, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 127;
			this.label6.Text = "Your Reference";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("Verdana", 8F);
			this.label5.ImageIndex = 1;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(230, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 126;
			this.label5.Text = "Season Code";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Verdana", 8F);
			this.label4.ImageIndex = 1;
			this.label4.ImageList = this.img_Label;
			this.label4.Location = new System.Drawing.Point(230, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 125;
			this.label4.Text = "Purchase No";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(168, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(473, 32);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(635, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(22, 32);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// lbl_OA_Detail
			// 
			this.lbl_OA_Detail.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_OA_Detail.Image = ((System.Drawing.Image)(resources.GetObject("lbl_OA_Detail.Image")));
			this.lbl_OA_Detail.Location = new System.Drawing.Point(0, 0);
			this.lbl_OA_Detail.Name = "lbl_OA_Detail";
			this.lbl_OA_Detail.Size = new System.Drawing.Size(172, 32);
			this.lbl_OA_Detail.TabIndex = 0;
			this.lbl_OA_Detail.Text = "      Adjust Detail";
			this.lbl_OA_Detail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(638, 32);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(19, 106);
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 24);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(32, 117);
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.Blue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(567, 138);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(90, 14);
			this.pictureBox5.TabIndex = 8;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.Color.Blue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(72, 138);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(569, 14);
			this.pictureBox6.TabIndex = 9;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.Color.Blue;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 138);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(80, 14);
			this.pictureBox7.TabIndex = 6;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Navy;
			this.pictureBox8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(32, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(609, 120);
			this.pictureBox8.TabIndex = 4;
			this.pictureBox8.TabStop = false;
			// 
			// pnl_Balance
			// 
			this.pnl_Balance.Controls.Add(this.panel1);
			this.pnl_Balance.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnl_Balance.Location = new System.Drawing.Point(0, 400);
			this.pnl_Balance.Name = "pnl_Balance";
			this.pnl_Balance.Size = new System.Drawing.Size(661, 192);
			this.pnl_Balance.TabIndex = 130;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.DockPadding.All = 4;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(661, 192);
			this.panel1.TabIndex = 129;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.RosyBrown;
			this.panel5.Controls.Add(this.fgrid_Balance);
			this.panel5.Controls.Add(this.pictureBox17);
			this.panel5.Controls.Add(this.pictureBox18);
			this.panel5.Controls.Add(this.lbl_Balance_Title);
			this.panel5.Controls.Add(this.pictureBox19);
			this.panel5.Controls.Add(this.pictureBox20);
			this.panel5.Controls.Add(this.pictureBox21);
			this.panel5.Controls.Add(this.pictureBox22);
			this.panel5.Controls.Add(this.pictureBox23);
			this.panel5.Controls.Add(this.pictureBox24);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(4, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(653, 188);
			this.panel5.TabIndex = 1;
			// 
			// fgrid_Balance
			// 
			this.fgrid_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Balance.AutoResize = false;
			this.fgrid_Balance.BackColor = System.Drawing.Color.White;
			this.fgrid_Balance.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Balance.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Balance.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Balance.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Balance.Location = new System.Drawing.Point(0, 28);
			this.fgrid_Balance.Name = "fgrid_Balance";
			this.fgrid_Balance.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Balance.Size = new System.Drawing.Size(653, 160);
			this.fgrid_Balance.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Balance.TabIndex = 40;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox17.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(168, -1);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(469, 32);
			this.pictureBox17.TabIndex = 2;
			this.pictureBox17.TabStop = false;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox18.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(631, 0);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(22, 32);
			this.pictureBox18.TabIndex = 1;
			this.pictureBox18.TabStop = false;
			// 
			// lbl_Balance_Title
			// 
			this.lbl_Balance_Title.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_Balance_Title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Balance_Title.Image")));
			this.lbl_Balance_Title.Location = new System.Drawing.Point(0, 0);
			this.lbl_Balance_Title.Name = "lbl_Balance_Title";
			this.lbl_Balance_Title.Size = new System.Drawing.Size(172, 32);
			this.lbl_Balance_Title.TabIndex = 0;
			this.lbl_Balance_Title.Text = "      Adjust Balance";
			this.lbl_Balance_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox19.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(634, 32);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(19, 142);
			this.pictureBox19.TabIndex = 5;
			this.pictureBox19.TabStop = false;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox20.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(0, 24);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(32, 153);
			this.pictureBox20.TabIndex = 3;
			this.pictureBox20.TabStop = false;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox21.BackColor = System.Drawing.Color.Blue;
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(563, 174);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(90, 14);
			this.pictureBox21.TabIndex = 8;
			this.pictureBox21.TabStop = false;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox22.BackColor = System.Drawing.Color.Blue;
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(72, 174);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(565, 14);
			this.pictureBox22.TabIndex = 9;
			this.pictureBox22.TabStop = false;
			// 
			// pictureBox23
			// 
			this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox23.BackColor = System.Drawing.Color.Blue;
			this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
			this.pictureBox23.Location = new System.Drawing.Point(0, 174);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(80, 14);
			this.pictureBox23.TabIndex = 6;
			this.pictureBox23.TabStop = false;
			// 
			// pictureBox24
			// 
			this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox24.BackColor = System.Drawing.Color.Navy;
			this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
			this.pictureBox24.Location = new System.Drawing.Point(32, 24);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.Size = new System.Drawing.Size(605, 156);
			this.pictureBox24.TabIndex = 4;
			this.pictureBox24.TabStop = false;
			// 
			// pnl_AddFlow
			// 
			this.pnl_AddFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_AddFlow.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.pnl_AddFlow.Controls.Add(this.AddFlow);
			this.pnl_AddFlow.Location = new System.Drawing.Point(-4, 160);
			this.pnl_AddFlow.Name = "pnl_AddFlow";
			this.pnl_AddFlow.Size = new System.Drawing.Size(669, 240);
			this.pnl_AddFlow.TabIndex = 129;
			// 
			// AddFlow
			// 
			this.AddFlow.BackColor = System.Drawing.SystemColors.Window;
			this.AddFlow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AddFlow.Location = new System.Drawing.Point(0, 0);
			this.AddFlow.Name = "AddFlow";
			this.AddFlow.Size = new System.Drawing.Size(669, 240);
			this.AddFlow.TabIndex = 0;
			this.AddFlow.DoubleClick += new System.EventHandler(this.AddFlow_DoubleClick);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(352, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 592);
			this.splitter1.TabIndex = 54;
			this.splitter1.TabStop = false;
			// 
			// pnl_Left
			// 
			this.pnl_Left.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Left.Controls.Add(this.pnl_Order);
			this.pnl_Left.Controls.Add(this.pnl_OA_Info);
			this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnl_Left.DockPadding.Right = 8;
			this.pnl_Left.Location = new System.Drawing.Point(0, 0);
			this.pnl_Left.Name = "pnl_Left";
			this.pnl_Left.Size = new System.Drawing.Size(352, 592);
			this.pnl_Left.TabIndex = 53;
			// 
			// pnl_Order
			// 
			this.pnl_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Order.Controls.Add(this.panel6);
			this.pnl_Order.DockPadding.All = 4;
			this.pnl_Order.Location = new System.Drawing.Point(0, 152);
			this.pnl_Order.Name = "pnl_Order";
			this.pnl_Order.Size = new System.Drawing.Size(344, 440);
			this.pnl_Order.TabIndex = 129;
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.BackColor = System.Drawing.Color.RosyBrown;
			this.panel6.Controls.Add(this.fgrid_Order);
			this.panel6.Controls.Add(this.pictureBox9);
			this.panel6.Controls.Add(this.pictureBox10);
			this.panel6.Controls.Add(this.lbl_Order_Title);
			this.panel6.Controls.Add(this.pictureBox11);
			this.panel6.Controls.Add(this.pictureBox12);
			this.panel6.Controls.Add(this.pictureBox13);
			this.panel6.Controls.Add(this.pictureBox14);
			this.panel6.Controls.Add(this.pictureBox15);
			this.panel6.Controls.Add(this.pictureBox16);
			this.panel6.Location = new System.Drawing.Point(4, 4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(340, 432);
			this.panel6.TabIndex = 2;
			// 
			// fgrid_Order
			// 
			this.fgrid_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Order.AutoResize = false;
			this.fgrid_Order.BackColor = System.Drawing.Color.White;
			this.fgrid_Order.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Order.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Order.ContextMenu = this.ctm_Order;
			this.fgrid_Order.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Order.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Order.Location = new System.Drawing.Point(0, 26);
			this.fgrid_Order.Name = "fgrid_Order";
			this.fgrid_Order.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Order.Size = new System.Drawing.Size(334, 398);
			this.fgrid_Order.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Order.TabIndex = 39;
			this.fgrid_Order.DoubleClick += new System.EventHandler(this.fgrid_Order_DoubleClick);
			// 
			// ctm_Order
			// 
			this.ctm_Order.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnt_Delete,
																					  this.mnt_Insert,
																					  this.mnt_Bar,
																					  this.mnt_Cancel,
																					  this.mnt_Cancel_All});
			// 
			// mnt_Delete
			// 
			this.mnt_Delete.Index = 0;
			this.mnt_Delete.Text = "Delete";
			this.mnt_Delete.Click += new System.EventHandler(this.mnt_Delete_Click);
			// 
			// mnt_Insert
			// 
			this.mnt_Insert.Index = 1;
			this.mnt_Insert.Text = "Insert";
			this.mnt_Insert.Click += new System.EventHandler(this.mnt_Insert_Click);
			// 
			// mnt_Bar
			// 
			this.mnt_Bar.Index = 2;
			this.mnt_Bar.Text = "-";
			// 
			// mnt_Cancel
			// 
			this.mnt_Cancel.Index = 3;
			this.mnt_Cancel.Text = "Cancel";
			// 
			// mnt_Cancel_All
			// 
			this.mnt_Cancel_All.Index = 4;
			this.mnt_Cancel_All.Text = "Cancel All";
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(168, -1);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(156, 32);
			this.pictureBox9.TabIndex = 2;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(318, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(21, 32);
			this.pictureBox10.TabIndex = 1;
			this.pictureBox10.TabStop = false;
			// 
			// lbl_Order_Title
			// 
			this.lbl_Order_Title.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_Order_Title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Order_Title.Image")));
			this.lbl_Order_Title.Location = new System.Drawing.Point(0, 0);
			this.lbl_Order_Title.Name = "lbl_Order_Title";
			this.lbl_Order_Title.Size = new System.Drawing.Size(172, 32);
			this.lbl_Order_Title.TabIndex = 0;
			this.lbl_Order_Title.Text = "       Order Info.";
			this.lbl_Order_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(321, 32);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(19, 386);
			this.pictureBox11.TabIndex = 5;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox12.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(0, 24);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(32, 397);
			this.pictureBox12.TabIndex = 3;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox13.BackColor = System.Drawing.Color.Blue;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(250, 418);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(90, 14);
			this.pictureBox13.TabIndex = 8;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox14.BackColor = System.Drawing.Color.Blue;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(72, 418);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(252, 14);
			this.pictureBox14.TabIndex = 9;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox15.BackColor = System.Drawing.Color.Blue;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(0, 418);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(80, 14);
			this.pictureBox15.TabIndex = 6;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox16.BackColor = System.Drawing.Color.Navy;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(32, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(292, 400);
			this.pictureBox16.TabIndex = 4;
			this.pictureBox16.TabStop = false;
			// 
			// pnl_OA_Info
			// 
			this.pnl_OA_Info.Controls.Add(this.cmb_OA_Nu);
			this.pnl_OA_Info.Controls.Add(this.panel7);
			this.pnl_OA_Info.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_OA_Info.DockPadding.Right = 4;
			this.pnl_OA_Info.Location = new System.Drawing.Point(0, 0);
			this.pnl_OA_Info.Name = "pnl_OA_Info";
			this.pnl_OA_Info.Size = new System.Drawing.Size(344, 152);
			this.pnl_OA_Info.TabIndex = 128;
			// 
			// cmb_OA_Nu
			// 
			this.cmb_OA_Nu.AddItemCols = 0;
			this.cmb_OA_Nu.AddItemSeparator = ';';
			this.cmb_OA_Nu.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OA_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OA_Nu.Caption = "";
			this.cmb_OA_Nu.CaptionHeight = 17;
			this.cmb_OA_Nu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OA_Nu.ColumnCaptionHeight = 18;
			this.cmb_OA_Nu.ColumnFooterHeight = 18;
			this.cmb_OA_Nu.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OA_Nu.ContentHeight = 15;
			this.cmb_OA_Nu.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OA_Nu.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OA_Nu.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OA_Nu.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OA_Nu.EditorHeight = 15;
			this.cmb_OA_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OA_Nu.GapHeight = 2;
			this.cmb_OA_Nu.ItemHeight = 15;
			this.cmb_OA_Nu.Location = new System.Drawing.Point(110, 119);
			this.cmb_OA_Nu.MatchEntryTimeout = ((long)(2000));
			this.cmb_OA_Nu.MaxDropDownItems = ((short)(5));
			this.cmb_OA_Nu.MaxLength = 32767;
			this.cmb_OA_Nu.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OA_Nu.Name = "cmb_OA_Nu";
			this.cmb_OA_Nu.PartialRightColumn = false;
			this.cmb_OA_Nu.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OA_Nu.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OA_Nu.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OA_Nu.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OA_Nu.Size = new System.Drawing.Size(210, 19);
			this.cmb_OA_Nu.TabIndex = 203;
			this.cmb_OA_Nu.TextChanged += new System.EventHandler(this.cmb_OA_Nu_TextChanged);
			this.cmb_OA_Nu.SelectedValueChanged += new System.EventHandler(this.cmb_OA_Nu_SelectedValueChanged);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.RosyBrown;
			this.panel7.Controls.Add(this.btn_OBS_ID);
			this.panel7.Controls.Add(this.txt_Style_Cd);
			this.panel7.Controls.Add(this.cmb_Style_Cd);
			this.panel7.Controls.Add(this.lbl_OA_Nu);
			this.panel7.Controls.Add(this.cmb_OBS_Type);
			this.panel7.Controls.Add(this.lbl_OBS_Type);
			this.panel7.Controls.Add(this.lbl_OBS_ID);
			this.panel7.Controls.Add(this.cmb_OBS_ID);
			this.panel7.Controls.Add(this.lbl_St);
			this.panel7.Controls.Add(this.lbl_Factory);
			this.panel7.Controls.Add(this.cmb_Factory);
			this.panel7.Controls.Add(this.pictureBox25);
			this.panel7.Controls.Add(this.pictureBox26);
			this.panel7.Controls.Add(this.lbl_OA_Title);
			this.panel7.Controls.Add(this.pictureBox27);
			this.panel7.Controls.Add(this.pictureBox28);
			this.panel7.Controls.Add(this.pictureBox29);
			this.panel7.Controls.Add(this.pictureBox30);
			this.panel7.Controls.Add(this.pictureBox31);
			this.panel7.Controls.Add(this.pictureBox32);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(340, 152);
			this.panel7.TabIndex = 1;
			// 
			// btn_OBS_ID
			// 
			this.btn_OBS_ID.ImageIndex = 0;
			this.btn_OBS_ID.ImageList = this.img_Button2;
			this.btn_OBS_ID.Location = new System.Drawing.Point(299, 76);
			this.btn_OBS_ID.Name = "btn_OBS_ID";
			this.btn_OBS_ID.Size = new System.Drawing.Size(21, 20);
			this.btn_OBS_ID.TabIndex = 207;
			this.btn_OBS_ID.Click += new System.EventHandler(this.btn_OBS_ID_Click);
			// 
			// img_Button2
			// 
			this.img_Button2.ImageSize = new System.Drawing.Size(21, 21);
			this.img_Button2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button2.ImageStream")));
			this.img_Button2.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txt_Style_Cd
			// 
			this.txt_Style_Cd.BackColor = System.Drawing.Color.White;
			this.txt_Style_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_Cd.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Style_Cd.Location = new System.Drawing.Point(110, 98);
			this.txt_Style_Cd.MaxLength = 100;
			this.txt_Style_Cd.Name = "txt_Style_Cd";
			this.txt_Style_Cd.Size = new System.Drawing.Size(104, 19);
			this.txt_Style_Cd.TabIndex = 206;
			this.txt_Style_Cd.Text = "";
			this.txt_Style_Cd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Style_Cd_KeyPress);
			// 
			// cmb_Style_Cd
			// 
			this.cmb_Style_Cd.AddItemCols = 0;
			this.cmb_Style_Cd.AddItemSeparator = ';';
			this.cmb_Style_Cd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Style_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Style_Cd.Caption = "";
			this.cmb_Style_Cd.CaptionHeight = 17;
			this.cmb_Style_Cd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Style_Cd.ColumnCaptionHeight = 18;
			this.cmb_Style_Cd.ColumnFooterHeight = 18;
			this.cmb_Style_Cd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Style_Cd.ContentHeight = 15;
			this.cmb_Style_Cd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Style_Cd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Style_Cd.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Style_Cd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Style_Cd.EditorHeight = 15;
			this.cmb_Style_Cd.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Style_Cd.GapHeight = 2;
			this.cmb_Style_Cd.ItemHeight = 15;
			this.cmb_Style_Cd.Location = new System.Drawing.Point(216, 98);
			this.cmb_Style_Cd.MatchEntryTimeout = ((long)(2000));
			this.cmb_Style_Cd.MaxDropDownItems = ((short)(5));
			this.cmb_Style_Cd.MaxLength = 32767;
			this.cmb_Style_Cd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Style_Cd.Name = "cmb_Style_Cd";
			this.cmb_Style_Cd.PartialRightColumn = false;
			this.cmb_Style_Cd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Style_Cd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Style_Cd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Style_Cd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Style_Cd.Size = new System.Drawing.Size(105, 19);
			this.cmb_Style_Cd.TabIndex = 205;
			this.cmb_Style_Cd.SelectedValueChanged += new System.EventHandler(this.cmb_Style_Cd_SelectedValueChanged);
			// 
			// lbl_OA_Nu
			// 
			this.lbl_OA_Nu.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OA_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OA_Nu.ImageIndex = 1;
			this.lbl_OA_Nu.ImageList = this.img_Label;
			this.lbl_OA_Nu.Location = new System.Drawing.Point(8, 119);
			this.lbl_OA_Nu.Name = "lbl_OA_Nu";
			this.lbl_OA_Nu.Size = new System.Drawing.Size(100, 21);
			this.lbl_OA_Nu.TabIndex = 202;
			this.lbl_OA_Nu.Text = "OA Nu";
			this.lbl_OA_Nu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_OBS_Type
			// 
			this.cmb_OBS_Type.AddItemCols = 0;
			this.cmb_OBS_Type.AddItemSeparator = ';';
			this.cmb_OBS_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_Type.Caption = "";
			this.cmb_OBS_Type.CaptionHeight = 17;
			this.cmb_OBS_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_Type.ColumnCaptionHeight = 18;
			this.cmb_OBS_Type.ColumnFooterHeight = 18;
			this.cmb_OBS_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_Type.ContentHeight = 15;
			this.cmb_OBS_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_Type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_Type.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_Type.EditorHeight = 15;
			this.cmb_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.GapHeight = 2;
			this.cmb_OBS_Type.ItemHeight = 15;
			this.cmb_OBS_Type.Location = new System.Drawing.Point(110, 56);
			this.cmb_OBS_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_Type.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_Type.MaxLength = 32767;
			this.cmb_OBS_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_Type.Name = "cmb_OBS_Type";
			this.cmb_OBS_Type.PartialRightColumn = false;
			this.cmb_OBS_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_Type.TabIndex = 204;
			this.cmb_OBS_Type.TextChanged += new System.EventHandler(this.cmb_OBS_Type_TextChanged);
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 1;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(8, 54);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Type.TabIndex = 203;
			this.lbl_OBS_Type.Text = "OBS Type";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OBS_ID
			// 
			this.lbl_OBS_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_ID.ImageIndex = 1;
			this.lbl_OBS_ID.ImageList = this.img_Label;
			this.lbl_OBS_ID.Location = new System.Drawing.Point(8, 76);
			this.lbl_OBS_ID.Name = "lbl_OBS_ID";
			this.lbl_OBS_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_ID.TabIndex = 201;
			this.lbl_OBS_ID.Text = "OBS ID";
			this.lbl_OBS_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_OBS_ID
			// 
			this.cmb_OBS_ID.AddItemCols = 0;
			this.cmb_OBS_ID.AddItemSeparator = ';';
			this.cmb_OBS_ID.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID.Caption = "";
			this.cmb_OBS_ID.CaptionHeight = 17;
			this.cmb_OBS_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID.ColumnFooterHeight = 18;
			this.cmb_OBS_ID.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID.ContentHeight = 15;
			this.cmb_OBS_ID.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_ID.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID.EditorHeight = 15;
			this.cmb_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID.GapHeight = 2;
			this.cmb_OBS_ID.ItemHeight = 15;
			this.cmb_OBS_ID.Location = new System.Drawing.Point(110, 77);
			this.cmb_OBS_ID.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID.MaxLength = 32767;
			this.cmb_OBS_ID.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID.Name = "cmb_OBS_ID";
			this.cmb_OBS_ID.PartialRightColumn = false;
			this.cmb_OBS_ID.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_ID.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.Size = new System.Drawing.Size(188, 19);
			this.cmb_OBS_ID.TabIndex = 202;
			this.cmb_OBS_ID.TextChanged += new System.EventHandler(this.cmb_OBS_ID_TextChanged);
			// 
			// lbl_St
			// 
			this.lbl_St.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_St.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_St.ImageIndex = 1;
			this.lbl_St.ImageList = this.img_Label;
			this.lbl_St.Location = new System.Drawing.Point(8, 97);
			this.lbl_St.Name = "lbl_St";
			this.lbl_St.Size = new System.Drawing.Size(100, 21);
			this.lbl_St.TabIndex = 200;
			this.lbl_St.Text = "Style Cd";
			this.lbl_St.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 32);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 115;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.ContentHeight = 15;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 15;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(110, 34);
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
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 118;
			// 
			// pictureBox25
			// 
			this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox25.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox25.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
			this.pictureBox25.Location = new System.Drawing.Point(168, -1);
			this.pictureBox25.Name = "pictureBox25";
			this.pictureBox25.Size = new System.Drawing.Size(156, 32);
			this.pictureBox25.TabIndex = 2;
			this.pictureBox25.TabStop = false;
			// 
			// pictureBox26
			// 
			this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox26.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
			this.pictureBox26.Location = new System.Drawing.Point(318, 0);
			this.pictureBox26.Name = "pictureBox26";
			this.pictureBox26.Size = new System.Drawing.Size(22, 32);
			this.pictureBox26.TabIndex = 1;
			this.pictureBox26.TabStop = false;
			// 
			// lbl_OA_Title
			// 
			this.lbl_OA_Title.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_OA_Title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_OA_Title.Image")));
			this.lbl_OA_Title.Location = new System.Drawing.Point(0, 0);
			this.lbl_OA_Title.Name = "lbl_OA_Title";
			this.lbl_OA_Title.Size = new System.Drawing.Size(172, 32);
			this.lbl_OA_Title.TabIndex = 0;
			this.lbl_OA_Title.Text = "      Adjust Info.";
			this.lbl_OA_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox27
			// 
			this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox27.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
			this.pictureBox27.Location = new System.Drawing.Point(321, 32);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(19, 106);
			this.pictureBox27.TabIndex = 5;
			this.pictureBox27.TabStop = false;
			// 
			// pictureBox28
			// 
			this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox28.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
			this.pictureBox28.Location = new System.Drawing.Point(0, 24);
			this.pictureBox28.Name = "pictureBox28";
			this.pictureBox28.Size = new System.Drawing.Size(32, 117);
			this.pictureBox28.TabIndex = 3;
			this.pictureBox28.TabStop = false;
			// 
			// pictureBox29
			// 
			this.pictureBox29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox29.BackColor = System.Drawing.Color.Blue;
			this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
			this.pictureBox29.Location = new System.Drawing.Point(250, 138);
			this.pictureBox29.Name = "pictureBox29";
			this.pictureBox29.Size = new System.Drawing.Size(90, 14);
			this.pictureBox29.TabIndex = 8;
			this.pictureBox29.TabStop = false;
			// 
			// pictureBox30
			// 
			this.pictureBox30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox30.BackColor = System.Drawing.Color.Blue;
			this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
			this.pictureBox30.Location = new System.Drawing.Point(72, 138);
			this.pictureBox30.Name = "pictureBox30";
			this.pictureBox30.Size = new System.Drawing.Size(252, 14);
			this.pictureBox30.TabIndex = 9;
			this.pictureBox30.TabStop = false;
			// 
			// pictureBox31
			// 
			this.pictureBox31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox31.BackColor = System.Drawing.Color.Blue;
			this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
			this.pictureBox31.Location = new System.Drawing.Point(0, 138);
			this.pictureBox31.Name = "pictureBox31";
			this.pictureBox31.Size = new System.Drawing.Size(80, 14);
			this.pictureBox31.TabIndex = 6;
			this.pictureBox31.TabStop = false;
			// 
			// pictureBox32
			// 
			this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox32.BackColor = System.Drawing.Color.Navy;
			this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
			this.pictureBox32.Location = new System.Drawing.Point(32, 24);
			this.pictureBox32.Name = "pictureBox32";
			this.pictureBox32.Size = new System.Drawing.Size(292, 120);
			this.pictureBox32.TabIndex = 4;
			this.pictureBox32.TabStop = false;
			// 
			// cmt_AddFlow
			// 
			this.cmt_AddFlow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.mnt_ClearAll});
			// 
			// mnt_ClearAll
			// 
			this.mnt_ClearAll.Index = 0;
			this.mnt_ClearAll.Text = "Clear All";
			this.mnt_ClearAll.Click += new System.EventHandler(this.mnt_ClearAll_Click);
			// 
			// Form_OA_Create
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Name = "Form_OA_Create";
			this.Load += new System.EventHandler(this.Form_OA_Create_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			this.pnl_Right.ResumeLayout(false);
			this.pnl_OA_Detail.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_FirstClass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_Code)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_Year)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_SecondClass)).EndInit();
			this.pnl_Balance.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Balance)).EndInit();
			this.pnl_AddFlow.ResumeLayout(false);
			this.pnl_Left.ResumeLayout(false);
			this.pnl_Order.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Order)).EndInit();
			this.pnl_OA_Info.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OA_Nu)).EndInit();
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style_Cd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자변수 정의

		private int  _NodeTop_D =10, _NodeTop_I =10 , _BaseLeft_I  =300, _BaseLeft_D = 10, _BaseWidth=50 ,_BaseHeight =10 ,_BaseTop  =10;
		
		private string _DeleteDesc = "Delete", _InsertDesc = "Insert",   _DeleteSeq="1",_InsertSeq ="2", _Head ="H", _Tail ="T" , _job_division ="",
			           _OANumber="", _OAConfirm ="", _StyleChange ="S", _OANumberChange ="O", _Context ="C",_Delete ="D", _Insert="I",
			           _Style ="";

		private ClassLib.OraDB  MyOraDB = new ClassLib.OraDB();

		private  DataTable _dt_flag = new DataTable("SaveTable");
		string _NewMaxOARelFlag  = "0";
		

		private ClassLib.OraDB  MyClassLib = new ClassLib.OraDB();
		private COM.ComFunction MyComFunction    = new COM.ComFunction();



		#endregion 

		#region 공통메쏘드

		
		private void Init_Form()
		{


			//Setting  Title
			this.Text = "Order Adjust";
			this.lbl_MainTitle.Text = "Order Adjust";
			ClassLib.ComFunction.SetLangDic(this);

			#region 버튼 권한
//
//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//
//				//Button 활성화
//				tbtn_Save.Enabled = true;     tbtn_Append.Enabled = true;   
//				tbtn_Delete.Enabled = true;   tbtn_Insert.Enabled = true; 
//
//			}
//			catch
//			{
//			}

			#endregion

			#region 그리드 
			
			DataTable dt_list;

			//Setting Grid(TBSEM_OBS_OA_CREATE01)
			fgrid_Order.Set_Grid( "SEM_OBS_OA_CREATE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			fgrid_Order.Set_Action_Image(img_Action); 
			fgrid_Order.Font = new Font("Verdana",8);


			//Setting Grid(TBSEM_OBS_OA_CREATE02)
			fgrid_Balance.Set_Grid( "SEM_OBS_OA_CREATE", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			fgrid_Balance.Font = new Font("Verdana",8);



			#endregion

			#region Adjust Info
			//Setting Factory Combo
			
			//Test용
			//ClassLib.ComVar.This_Factory ="VJ";
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);			
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory ;
			

			//Setting OBS Type			
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString() , ClassLib.ComVar.CxOBS_Type);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type, 1, 2, true);  			
			cmb_OBS_Type.SelectedIndex = 1;
			//cmb_OBS_Type.Enabled  = false;




//			//Setting OBS ID
//			cmb_OBS_ID.ClearItems();
//			if (cmb_OBS_Type.SelectedIndex != 1)
//			{
//				ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type.SelectedValue.ToString(), cmb_OBS_ID);  
//			}

			#endregion 

			#region Adjust Detail

			//Setting obs div		
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),"SEM05");
			ClassLib.ComCtl.Set_ComboList_AddItem(dt_list, cmb_FirstClass, 1, 2, false,70,150);
			cmb_FirstClass.SelectedValue = "01";


			//Setting SecondClass
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),"SEM06");
			ClassLib.ComCtl.Set_ComboList_AddItem (dt_list, cmb_SecondClass , 1, 2, false,70,150);
			cmb_SecondClass.SelectedIndex = 1;
            
			//Setting Season
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),"SEM15");
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Season_Code , 1, 2);
			cmb_Season_Code.SelectedValue = "SP";

			//Date
			dtp_Adjust_Date.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			string now  = System.DateTime.Now.ToString("yyyyMMdd");
			dtp_Adjust_Date.Text = MyComFunction.ConvertDate2Type(now);

			dtp_Apply_Date.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			now  = System.DateTime.Now.ToString("yyyyMMdd");
			dtp_Apply_Date.Text = MyComFunction.ConvertDate2Type(now);


			ClassLib.ComFunction.Set_Year(cmb_Season_Year);


			#endregion 

			AddFlow.AutoScroll   = true;
			AddFlow.Enabled      = false;


			btn_Confirm.Enabled  = true;
			btn_Confirm.ForeColor =  System.Drawing.Color.Red;
			btn_Cancel.Enabled   = true;
			btn_Cancel.ForeColor = System.Drawing.Color.Red;

			mnt_Bar.Visible         = false;
			mnt_Cancel.Visible      = false;
			mnt_Cancel_All.Visible  = false;

			this.Cursor = Cursors.Default;

		}


		private bool Check_OA_Apply()
		{

			try
			{
 
				DataTable dt_list;

				dt_list  = Select_OA_Check();

				if (dt_list.Rows[0].ItemArray[0].ToString() == ClassLib.ComVar.ConsReal_Y)
					return true;
				else
					return false;

			}
			catch
			{
				return false;

			}

		}


		

		private bool Check_Save()
		{


			#region  01. 조회시 필수조건을 체크한다. 

			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_Factory ,cmb_FirstClass, cmb_OBS_ID, cmb_OBS_Type, cmb_Season_Code, cmb_Season_Year , cmb_SecondClass , cmb_Style_Cd }; 
			System.Windows.Forms.TextBox[] txt_array = {txt_Order_Reason,txt_Our_Reference ,txt_Purchase_Group ,txt_Purchase_No ,txt_Qual_Iseq }; 


			if ( !(FlexOrder.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array)) ) 
			{
				ClassLib.ComFunction.User_Message("Essentiality_check", "tbtn_Save_Click()", MessageBoxButtons.OK , MessageBoxIcon.Error );
				return false;

			}
			#endregion 		

			#region  02. "D에는 무조건 I가 하나라도 있어야 함...

			int vDelete  = 0, vInsert =0;
			for( int i = fgrid_Order.Rows.Fixed ; i   <  fgrid_Order.Rows.Count ; i++)
			{

				if  (fgrid_Order[i,0] == null) continue;

				if (fgrid_Order[i,0].ToString()== ClassLib.ComVar.ConsJob_D) vDelete ++;
				if (fgrid_Order[i,0].ToString() == ClassLib.ComVar.ConsJob_I) vInsert ++;

			}


	
			if (vDelete==0 ) 
			{
				
				ClassLib.ComFunction.User_Message("There is not flag -D", "tbtn_Save_Click()", MessageBoxButtons.OK , MessageBoxIcon.Error );
				
				return false;

			}


			if (vDelete > vInsert )
			{
				
				ClassLib.ComFunction.User_Message("[Wrong flag set] " + "\r\n" + 
					"Correct Balance Set : Flag-D <= Flag-I" + "\r\n" +
					"Wrong Balacne Set   : Flag-D > Flag-I", "tbtn_Save_Click()", MessageBoxButtons.OK , MessageBoxIcon.Error );
				
				return false;

			}

				

			#endregion 

			#region 3.OBS/ CS OBS에따른 검증

			
			string  vAdjustOption  = cmb_FirstClass.SelectedValue.ToString();

			switch(vAdjustOption)
			{
				case  "01"  :
				{
					for (int i =fgrid_Balance.Rows.Fixed ;  i< fgrid_Balance.Rows.Count  ;i++)
					{
						if ((fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG] ==null)  ||
							(fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG].ToString() =="" ) ) continue;
                        
						if (fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOBS_NU].ToString().Substring(0,1) != "C")
						{
							ClassLib.ComFunction.User_Message("[Wrong job flag] " + "\r\n" + 
								"01.Nike Order & Chanshin Order is wrong " , "tbtn_Save_Click()", MessageBoxButtons.OK , MessageBoxIcon.Error );
				
							return false;


						}
					}

					break;
				}
               

				case  "02"  :
				{
					for (int i =fgrid_Balance.Rows.Fixed ;  i< fgrid_Balance.Rows.Count  ;i++)
					{
						if ((fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG] ==null)  ||
							(fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG].ToString() =="" ) ) continue;
                        
						if ((fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG].ToString() == _DeleteDesc) && 
							(fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOBS_NU].ToString().Substring(0,1) != "C"))
						{
							ClassLib.ComFunction.User_Message("[Wrong job flag] " + "\r\n" + 
								"Please check : Nike Order & Chanshin Order" , "tbtn_Save_Click()", MessageBoxButtons.OK , MessageBoxIcon.Error );
				
							return false;


						}



						if ((fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG].ToString() == _InsertDesc) && 
							(fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOBS_NU].ToString().Substring(0,1) == "C"))
						{
							ClassLib.ComFunction.User_Message("[Wrong job flag] " + "\r\n" + 
								"Please check : Nike Order & Chanshin Order" , "tbtn_Save_Click()", MessageBoxButtons.OK , MessageBoxIcon.Error );
				
							return false;


						}

							


						
					}
					break;

				}

				case  "03"  :
				{
					for (int i =fgrid_Balance.Rows.Fixed ;  i< fgrid_Balance.Rows.Count  ;i++)
					{
						if ((fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG] ==null)  ||
							(fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG].ToString() =="" ) ) continue;
                        
						if (fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOBS_NU].ToString().Substring(0,1) == "C")
						{
							ClassLib.ComFunction.User_Message("[Wrong job flag] " + "\r\n" + 
								"Please check : Nike Order & Chanshin Order" , "tbtn_Save_Click()", MessageBoxButtons.OK , MessageBoxIcon.Error );
				
							return false;


						}
							


						
					}
					break;

				}
			}
			#endregion 









			return true;

			
		}



	



		private bool Check_Cancel()
		{

			try
			{

				
				_Style= cmb_Style_Cd.SelectedValue.ToString();
			
				if ((cmb_OA_Nu.SelectedValue != null) || (cmb_OA_Nu.SelectedValue.ToString().Length>=10))
					_OANumber = cmb_OA_Nu.SelectedValue.ToString();
				else
					return false;



 
				DataTable dt_list;

				dt_list  = Select_Cancel_Check();

				if (dt_list.Rows[0].ItemArray[0].ToString() == ClassLib.ComVar.ConsReal_Y)
					return true;
				else
					return false;

			}
			catch
			{
				return false;

			}

		}



		private bool Check_Order_Receive()
		{

			try
			{
 
				DataTable dt_list;

				dt_list  = Select_Receive_Check();

				if (dt_list.Rows[0].ItemArray[0].ToString() == ClassLib.ComVar.ConsReal_Y)
					return true;
				else
					return false;

			}
			catch
			{
				return false;

			}

		}

		

		//다음 Node의 Top위치를 잡아온다.
		private  void  Set_Node_Top(string arg_type , int arg_row)
		{

			_NodeTop_D  = _BaseTop ;
			_NodeTop_I  = _BaseTop ;


			for (int i  =AddFlow.Nodes.Count-1 ;  i>  -1   ; i--)
			{

				switch (arg_type)
				{
					case "D":
						if (AddFlow.Nodes[i].Text != _DeleteDesc) continue;
						_NodeTop_D = (_NodeTop_D <= Convert.ToInt16 (AddFlow.Nodes[i].Rect.Top )) ?  Convert.ToInt16(AddFlow.Nodes[i].Rect.Top+_BaseHeight*3 + 15): _NodeTop_D;
						break;

					case "I":
						if (AddFlow.Nodes[i].Text != _InsertDesc) continue;
						_NodeTop_I = (_NodeTop_I <= Convert.ToInt16(AddFlow.Nodes[i].Rect.Top) ) ? Convert.ToInt16(AddFlow.Nodes[i].Rect.Top+_BaseHeight*3 + 15): _NodeTop_I;
						break;

					case "C":
					{
						if (AddFlow.Nodes[i].Tag.ToString()  == fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxOBS_NU].ToString()  + 
							fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxOBS_SEQ_NU].ToString()  + 
							fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxCHG_NU].ToString()  )
						{
							
							fgrid_Order.GetCellRange(arg_row, 0, arg_row,fgrid_Order.Cols.Count -1).StyleNew.ForeColor  =ClassLib.ComVar.ClrBlack;
							fgrid_Order[fgrid_Order.Selection.r1,0] = "";

							AddFlow.Nodes[i].Remove();
						}
						fgrid_Order[arg_row,0]="";
						continue;
					}

						

				}

			}


		}


		private void 	Set_Clear(string arg_flag)
		{

			_NewMaxOARelFlag  = "0";

			if (arg_flag  == _StyleChange)
			{

				cmb_Style_Cd.SelectedIndex  = 0;
				cmb_OA_Nu.ClearItems();

				fgrid_Balance.Rows.Count = fgrid_Balance.Rows.Fixed;
				fgrid_Order.Rows.Count   = fgrid_Order.Rows.Fixed;
				AddFlow.Items.Clear();

				//cmb_OA_Nu.ClearItems();

				Set_Enable(ClassLib.ComVar.ConsCFM_P);


			}

			if (arg_flag  == _OANumberChange)
			{

				fgrid_Balance.Rows.Count = fgrid_Balance.Rows.Fixed;
				AddFlow.Items.Clear();

				
				if (cmb_OA_Nu.Columns[1].Text.Substring(0,1)== ClassLib.ComVar.ConsCFM_C)
					Set_Enable(ClassLib.ComVar.ConsCFM_C);
				else if (cmb_OA_Nu.Columns[1].Text.Substring(0,1)== ClassLib.ComVar.ConsCFM_R)
					Set_Enable(ClassLib.ComVar.ConsCFM_R);
				else
					Set_Enable(ClassLib.ComVar.ConsCFM_P);


				for (int i =0 ; i < fgrid_Order.Rows.Count; i++)
				{
					
					fgrid_Order.GetCellRange(i, 0, i,fgrid_Order.Cols.Count -1).StyleNew.ForeColor  = Color.Black;
					fgrid_Order[i,0] ="";


				}


	

			}
				


			cmb_FirstClass.SelectedIndex = 1;
			cmb_Season_Code.SelectedIndex  =1;			
			cmb_Season_Year.SelectedIndex =1;
			cmb_SecondClass.SelectedIndex  =1;
			txt_Order_Reason.Clear();
			txt_Our_Reference.Clear();
			txt_Purchase_Group.Clear();
			txt_Purchase_No.Clear();
			txt_Qual_Iseq.Clear();
			txt_Remarks.Clear();
			txt_Style_Cd.Clear();
			txt_Your_Reference.Clear();
			



		}


		private void Set_Enable(string   arg_flag)
		{

			try
			{

				if (arg_flag == ClassLib.ComVar.ConsCFM_C)
				{

				
					cmb_FirstClass.Enabled  = false;
					cmb_Season_Code.Enabled  = false;	
					cmb_Season_Year.Enabled  = false;
					cmb_SecondClass.Enabled  = false;
	
					txt_Order_Reason.Enabled  = false;
					txt_Our_Reference.Enabled  = false;
					txt_Purchase_Group.Enabled  = false;
					txt_Purchase_No.Enabled  = false;
					txt_Qual_Iseq.Enabled  = false;
					txt_Remarks.Enabled  = false;
					//txt_Style_Cd.Enabled  = false;
					txt_Your_Reference.Enabled  = false;



					btn_Confirm.Enabled = false;
					btn_Confirm.ForeColor = System.Drawing.Color.Black;
					btn_Cancel.Enabled   = true;
					btn_Cancel.ForeColor = System.Drawing.Color.Red;

					tbtn_Save.Enabled  = false;
					tbtn_Delete.Enabled  = false;


				}
				else if (arg_flag == ClassLib.ComVar.ConsCFM_R)
				{


					cmb_FirstClass.Enabled  = true;
					cmb_Season_Code.Enabled  = true;	
					cmb_Season_Year.Enabled  = true;
					cmb_SecondClass.Enabled  = true;
	
					txt_Order_Reason.Enabled  = true;
					txt_Our_Reference.Enabled  = true;
					txt_Purchase_Group.Enabled  = true;
					txt_Purchase_No.Enabled  = true;
					txt_Qual_Iseq.Enabled  = true;
					txt_Remarks.Enabled  = true;
					//txt_Style_Cd.Enabled  = true;
					txt_Your_Reference.Enabled  = true;


					btn_Confirm.Enabled  = true;
					btn_Confirm.ForeColor = System.Drawing.Color.Red;
					btn_Cancel.Enabled   = false;
					btn_Cancel.ForeColor =System.Drawing.Color.Black;


					tbtn_Save.Enabled  = true;
					tbtn_Delete.Enabled  = true;




				}
				else
				{

					cmb_FirstClass.Enabled  = true;
					cmb_Season_Code.Enabled  = true;	
					cmb_Season_Year.Enabled  = true;
					cmb_SecondClass.Enabled  = true;
	
					txt_Order_Reason.Enabled  = true;
					txt_Our_Reference.Enabled  = true;
					txt_Purchase_Group.Enabled  = true;
					txt_Purchase_No.Enabled  = true;
					txt_Qual_Iseq.Enabled  = true;
					txt_Remarks.Enabled  = true;
					//txt_Style_Cd.Enabled  = true;
					txt_Your_Reference.Enabled  = true;



					btn_Confirm.Enabled  = true;
					btn_Confirm.ForeColor =  System.Drawing.Color.Red;
					btn_Cancel.Enabled   = true;
					btn_Cancel.ForeColor = System.Drawing.Color.Red;

					tbtn_Save.Enabled  = true;
					tbtn_Delete.Enabled  = true;



				}
				

//
//				if (cmb_OA_Nu.SelectedValue.ToString().Length != 10)
//				{
//					btn_Confirm.Enabled  = true;
//					btn_Confirm.ForeColor =  System.Drawing.Color.Red;
//					btn_Cancel.Enabled   = true;
//					btn_Cancel.ForeColor = System.Drawing.Color.Red;
//
//				}
			}
			catch(Exception ex)
			{

				ClassLib.ComFunction.User_Message(ex.ToString(), "Set_Enable", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

		}


		private void Set_OA_List(string arg_factory, string oa_nu)
		{

			DataTable   dt_list;

			dt_list  = Select_Obs_List();
			fgrid_Order.Display_Grid(dt_list, true); 


			dt_list = Select_OA(cmb_Factory.SelectedValue.ToString(), oa_nu );
			Display_OA(dt_list);

			dt_list = Select_OA_Relation(cmb_Factory.SelectedValue.ToString(), oa_nu );
			Display_OA_Relation(dt_list);

			dt_list = Select_Add_Node(cmb_Factory.SelectedValue.ToString(),  oa_nu);
			Drow_Order_Flag_Search(dt_list);





		}

	
		private void  Drow_Order_Flag(int arg_left, int arg_top, int arg_width, int arg_height, int arg_row, string arg_job)
		{
			
                      
			

				string vJobDesc  = (arg_job =="D")? _DeleteDesc :_InsertDesc;
				Lassalle.Flow.Node NodeTitle      = new Lassalle.Flow.Node(arg_left,  arg_top, arg_width *3,  arg_height,vJobDesc);
				Lassalle.Flow.Node NodeObsNu      = new Lassalle.Flow.Node(arg_left,  arg_top+arg_height*1, arg_width, arg_height, fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxOBS_NU].ToString());
				Lassalle.Flow.Node NodeObsSeqNu   = new Lassalle.Flow.Node(arg_left+arg_width*1, arg_top+arg_height*1,arg_width, arg_height, fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxOBS_SEQ_NU].ToString());
				Lassalle.Flow.Node NodeChgNu      = new Lassalle.Flow.Node(arg_left+arg_width*2, arg_top+arg_height*1, arg_width, arg_height, fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxCHG_NU].ToString());
				Lassalle.Flow.Node NodeOgacDate   = new Lassalle.Flow.Node(arg_left, arg_top+arg_height*2, arg_width, arg_height, fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxOGAC_YMD ].ToString());
				Lassalle.Flow.Node NodeRgacDate   = new Lassalle.Flow.Node(arg_left+arg_width*1, arg_top+arg_height*2, arg_width, arg_height, fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxRTS_YMD].ToString());
				Lassalle.Flow.Node NodeTotalQty   = new Lassalle.Flow.Node(arg_left+arg_width*2,  arg_top+arg_height*2, arg_width, arg_height, fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxTOT_QTY].ToString());
				string vNodeTag =  fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxOBS_NU].ToString()  + 
					fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxOBS_SEQ_NU].ToString() +
					fgrid_Order[arg_row,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxCHG_NU].ToString();
            

			
				Set_Node_Property(NodeTitle,arg_job,vNodeTag);
				Set_Node_Property(NodeObsNu,arg_job,vNodeTag);Set_Node_Property(NodeObsSeqNu,arg_job,vNodeTag);Set_Node_Property(NodeChgNu,arg_job,vNodeTag);
				Set_Node_Property(NodeOgacDate,arg_job,vNodeTag);Set_Node_Property(NodeRgacDate,arg_job,vNodeTag);Set_Node_Property(NodeTotalQty,arg_job,vNodeTag);

			
				AddFlow.Nodes.Add(NodeTitle); 
				AddFlow.Nodes.Add(NodeObsNu); AddFlow.Nodes.Add(NodeObsSeqNu); AddFlow.Nodes.Add(NodeChgNu); 
				AddFlow.Nodes.Add(NodeOgacDate); AddFlow.Nodes.Add(NodeRgacDate); AddFlow.Nodes.Add(NodeTotalQty); 


			
			
				Drow_Order_Link();

				Set_Balance_By_Size();  //AddFlow에서 Delete와 Insert부분만 끄집어내고, balance sheet에 올린후, oa_rel_flag + oa_flag의 임미의 칼럼으로 sort한후,subtotal만들기

			



		}

		
		private void  Drow_Order_Flag_Search(DataTable arg_list)
		{
			 

                      
			for (int i= 0; i< arg_list.Rows.Count  ;i++)
			{
				//string vJobDesc  = (arg_job =="D")? _DeleteDesc :_InsertDesc;
				//Lassalle.Flow.Node Node     = new Lassalle.Flow.Node(arg_left,  arg_top, arg_width *3,  arg_height,vJobDesc);

				int vWidth   = 0;
				if ((arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxTEXT -1].ToString() == _DeleteDesc) ||
					(arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxTEXT -1].ToString() == _InsertDesc) ) 
					vWidth= Convert.ToUInt16(arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxNODE_WIDTH-1])*3;
				else
	                vWidth = Convert.ToUInt16(arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxNODE_WIDTH-1]);      


				

				Lassalle.Flow.Node Node    = new Lassalle.Flow.Node(Convert.ToUInt16(arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxNODE_LEFT-1]),
																	Convert.ToUInt16(arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxNODE_TOP-1]),
																	vWidth,
																	Convert.ToUInt16(arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxNODE_HEIGHT-1]),
																	arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxTEXT -1].ToString());



					
		
				Set_Node_Property(Node,
					              arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.lxOA_FLAG-1].ToString(),
					              arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxTAG -1].ToString());
			
				AddFlow.Nodes.Add(Node); 


				Node.Tooltip  = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxTOOLTIP -1].ToString();
				//Node.Index    = Convert.ToInt16(arg_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxOA_NODE_SEQ -1]);
				


			}


			DataTable dt_list;
			dt_list = Select_Add_Link(cmb_Factory.SelectedValue.ToString(),  cmb_OA_Nu.SelectedValue.ToString());
			Drow_Order_Link_Search();


		}


		private void Set_Balance_By_Size()
		{
			DataTable  dt_list;

			fgrid_Balance.Rows.Count   = fgrid_Balance.Rows.Fixed;

			//Size qty Setting 
			for (int i  =0 ; i<AddFlow.Nodes.Count    ;i++)
			{
				if ((AddFlow.Nodes[i].Text   != _DeleteDesc) && (AddFlow.Nodes[i].Text   != _InsertDesc )) continue;
			    

			    dt_list = Select_Obs_Size(cmb_Factory.SelectedValue.ToString(),
					                      AddFlow.Nodes[i].Tag.ToString().Substring(0,10),
										  AddFlow.Nodes[i].Tag.ToString().Substring(10,10),	
										  AddFlow.Nodes[i].Tag.ToString().Substring(20,5));
	
				Display_Balance(AddFlow.Nodes[i].Text ,AddFlow.Nodes[i].Tooltip, AddFlow.Nodes[i].Text,dt_list  );

			}



			fgrid_Balance.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending,7);
			Set_Balance_Total();



		}


		private  void Set_Balance_Total()
		{   
			#region  관계별 
			int iOARelFlag		=  (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_REL_FLAG;

			CellStyle cStyle1 = fgrid_Balance.Styles[CellStyleEnum.Subtotal1];
			cStyle1.Font = new Font(fgrid_Balance.Font , FontStyle.Regular );


			fgrid_Balance.SubtotalPosition = SubtotalPositionEnum.AboveData;
			fgrid_Balance.Tree.Column = iOARelFlag;			
			for (int c = (int)ClassLib.TBSEM_OBS_OA_CREATE02.IxCS_SIZE ; c <fgrid_Balance.Cols.Count; c++)
			{                      
				fgrid_Balance.Subtotal(AggregateEnum.Sum, iOARelFlag, iOARelFlag, c, "+/- ");
				fgrid_Balance.Styles[CellStyleEnum.Subtotal1].BackColor  =  ClassLib.ComVar.ClrTransparent;
				fgrid_Balance.Styles[CellStyleEnum.Subtotal1].ForeColor  =  ClassLib.ComVar.Clr_Text_Blue;
				fgrid_Balance.Styles[CellStyleEnum.Subtotal1].Font       = cStyle1.Font;			
			}
			#endregion 

			#region 전체
			CellStyle cStyle0 = fgrid_Balance.Styles[CellStyleEnum.Subtotal0];
			cStyle0.Font = new Font(fgrid_Balance.Font , FontStyle.Regular );

			fgrid_Balance.SubtotalPosition = SubtotalPositionEnum.AboveData;
			fgrid_Balance.Tree.Column = iOARelFlag;
			for (int c = (int)ClassLib.TBSEM_OBS_OA_CREATE02.IxCS_SIZE ; c <fgrid_Balance.Cols.Count; c++)
			{
				fgrid_Balance.Subtotal(AggregateEnum.Sum, 0, 0,c,"**");
				fgrid_Balance.Styles[CellStyleEnum.Subtotal0].BackColor  = ClassLib.ComVar.ClrTransparent ;
				fgrid_Balance.Styles[CellStyleEnum.Subtotal0].ForeColor  = ClassLib.ComVar.Clr_Text_Red;
				fgrid_Balance.Styles[CellStyleEnum.Subtotal0].Font       = cStyle0.Font;
			}

			#endregion 

		}


		private void Display_OA(DataTable arg_list)
		{
			
			cmb_FirstClass.SelectedValue  = arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.lxOA_OBS_DIV-1].ToString();
			cmb_SecondClass.SelectedValue = arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.lxOA_DIV-1].ToString();
			dtp_Adjust_Date.Text		  = ClassLib.ComFunction.Convert_ToDate(arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.IxOA_YMD -1].ToString()).ToString();
			dtp_Apply_Date.Text			  = ClassLib.ComFunction.Convert_ToDate(arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.IxCHG_YMD-1].ToString()).ToString();
			txt_Purchase_No.Text		  = arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.lxPUR_NO -1].ToString();
			txt_Our_Reference.Text		  = arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.lxOUR_REF_NO-1].ToString();
			txt_Purchase_Group.Text		  = arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.lxPUR_GRP -1].ToString();
			txt_Your_Reference.Text	      = arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.lxYOUR_REF -1].ToString();
			txt_Order_Reason.Text		  = arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.lxORDER_RSN -1].ToString();
			txt_Qual_Iseq.Text			  = arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.lxQUAL_ISEQ -1].ToString();
			cmb_Season_Code.SelectedValue = arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.lxSEASON_CD -1].ToString();
			cmb_Season_Year.Text		  = arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.IxSEASON_YEAR-1].ToString();
			txt_Remarks.Text			  = arg_list.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA_INFORMATION.lxREMARKS -1].ToString();


		}

		
		private void Display_OA_Relation(DataTable arg_list)
		{
		

			//Size 별 수량 Setting
			int iOA_REL_FLAG = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_REL_FLAG;
			//int iFACTORY     = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxFACTORY;
			int iOBS_NU      = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOBS_NU;
			int iOBS_SEQ_NU  = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOBS_SEQ_NU;
			int iCHG_NU      = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxCHG_NU;
			int iOA_FLAG      = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG;
			int iCOL_SORT     = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxCOL_SORT; 
			int iCS_SIZE     = (int)ClassLib.TBSEM_OBS_OA_CREATE02.IxCS_SIZE;
			int iQTY         = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxORDER_QTY;

			//merge
			fgrid_Balance.AllowMerging = AllowMergingEnum.Free;
			for (int j=(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxFACTORY ; j<=(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxCHG_NU;j++)
				fgrid_Balance.Cols[j].AllowMerging = true;

			fgrid_Balance.Cols[(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG ].AllowMerging = false;
			fgrid_Balance.Cols[(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_REL_FLAG].AllowMerging = false;

			//Size Setting
			for(int i=0; i<arg_list.Rows.Count; i++)
			{
				string sOBS_NU     = arg_list.Rows[i].ItemArray[iOBS_NU-1].ToString();
				string sOBS_SEQ_NU = arg_list.Rows[i].ItemArray[iOBS_SEQ_NU-1].ToString();
				string sCHG_NU     = arg_list.Rows[i].ItemArray[iCHG_NU-1].ToString();					
				string sSIZE       = arg_list.Rows[i].ItemArray[iCS_SIZE-1].ToString();
				string sQTY        = arg_list.Rows[i].ItemArray[iQTY-1].ToString();

				if (( fgrid_Balance.Rows.Count == fgrid_Balance.Rows.Fixed ) ||
					( sOBS_NU     != fgrid_Balance[fgrid_Balance.Rows.Count-1, iOBS_NU].ToString()     ) || 
					( sOBS_SEQ_NU != fgrid_Balance[fgrid_Balance.Rows.Count-1, iOBS_SEQ_NU].ToString() ) || 
					( sCHG_NU     != fgrid_Balance[fgrid_Balance.Rows.Count-1, iCHG_NU].ToString()     )  )
				{

//					string vOAFlag  =  (arg_oa_flag== _DeleteDesc )? _DeleteSeq:_InsertSeq;
//					string vOARelFlag  =  (arg_oa_rel_flag==null )? "0":arg_oa_rel_flag;
					fgrid_Balance.AddItem(arg_list.Rows[i].ItemArray, fgrid_Balance.Rows.Count, 1);


					fgrid_Balance[fgrid_Balance.Rows.Count-1,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG] =arg_list.Rows[i].ItemArray[iOA_FLAG-1 ].ToString();
					fgrid_Balance[fgrid_Balance.Rows.Count-1,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_REL_FLAG] =arg_list.Rows[i].ItemArray[iOA_REL_FLAG-1].ToString();
					fgrid_Balance[fgrid_Balance.Rows.Count-1,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxCOL_SORT] = arg_list.Rows[i].ItemArray[iCOL_SORT-1].ToString();
						

					fgrid_Balance[fgrid_Balance.Rows.Count-1, iCS_SIZE] = " ";
					fgrid_Balance[fgrid_Balance.Rows.Count-1, iQTY ] = " ";
					fgrid_Balance[fgrid_Balance.Rows.Count-1,0 ] = " ";

											
				}

				for(int j=(int)ClassLib.TBSEM_OBS_OA_CREATE02.IxCS_SIZE  ; j<fgrid_Balance.Cols.Count; j++)
				{
					if (fgrid_Balance[1, j].ToString() == sSIZE)
					{
						if (arg_list.Rows[i].ItemArray[iOA_FLAG ].ToString()!= _DeleteDesc )
							fgrid_Balance[fgrid_Balance.Rows.Count-1, j] = sQTY;
						else
							fgrid_Balance[fgrid_Balance.Rows.Count-1, j] = "-" + sQTY;

						fgrid_Balance.LeftCol = Convert.ToInt16(fgrid_Balance.Cols.Count/2);
						break;
					}
				}
				

				
				

			} 
			
			fgrid_Balance.Cols[0].Width = 0;
			
			fgrid_Balance.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending,7);
			Set_Balance_Total();

			

		}


		private void Display_Balance(string arg_obs_key , string arg_oa_rel_flag, string arg_oa_flag, DataTable arg_list)
		{
				
	
 		

			//Size 별 수량 Setting
			int iOBS_NU     = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOBS_NU;
			int iOBS_SEQ_NU = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOBS_SEQ_NU;
			int iCHG_NU     = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxCHG_NU;
			int iCS_SIZE    = (int)ClassLib.TBSEM_OBS_OA_CREATE02.IxCS_SIZE;
			int iQTY        = (int)ClassLib.TBSEM_OBS_OA_CREATE02.lxORDER_QTY;

			//merge
			fgrid_Balance.AllowMerging = AllowMergingEnum.Free;
			for (int j=(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxFACTORY ; j<=(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxCHG_NU;j++)
				fgrid_Balance.Cols[j].AllowMerging = true;

			fgrid_Balance.Cols[(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG ].AllowMerging = false;
			fgrid_Balance.Cols[(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_REL_FLAG].AllowMerging = false;

			//Size Setting
			for(int i=0; i<arg_list.Rows.Count; i++)
			{
				string sOBS_NU     = arg_list.Rows[i].ItemArray[iOBS_NU-1].ToString();
				string sOBS_SEQ_NU = arg_list.Rows[i].ItemArray[iOBS_SEQ_NU-1].ToString();
				string sCHG_NU     = arg_list.Rows[i].ItemArray[iCHG_NU-1].ToString();					
				string sSIZE       = arg_list.Rows[i].ItemArray[iCS_SIZE-1].ToString();
				string sQTY        = arg_list.Rows[i].ItemArray[iQTY-1].ToString();

				if (( fgrid_Balance.Rows.Count == fgrid_Balance.Rows.Fixed ) ||
					( sOBS_NU     != fgrid_Balance[fgrid_Balance.Rows.Count-1, iOBS_NU].ToString()     ) || 
					( sOBS_SEQ_NU != fgrid_Balance[fgrid_Balance.Rows.Count-1, iOBS_SEQ_NU].ToString() ) || 
					( sCHG_NU     != fgrid_Balance[fgrid_Balance.Rows.Count-1, iCHG_NU].ToString()     )  )
				{

					string vOAFlag  =  (arg_oa_flag== _DeleteDesc )? _DeleteSeq:_InsertSeq;
					string vOARelFlag  =  (arg_oa_rel_flag==null )? "0":arg_oa_rel_flag;
					fgrid_Balance.AddItem(arg_list.Rows[i].ItemArray, fgrid_Balance.Rows.Count, 1);


					fgrid_Balance[fgrid_Balance.Rows.Count-1,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG] = arg_oa_flag;
					fgrid_Balance[fgrid_Balance.Rows.Count-1,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_REL_FLAG] = vOARelFlag;
					fgrid_Balance[fgrid_Balance.Rows.Count-1,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxCOL_SORT] = 
                                vOARelFlag.PadLeft(3,'0')+vOAFlag.PadLeft(3,'0');

					fgrid_Balance[fgrid_Balance.Rows.Count-1, iCS_SIZE] = " ";
					fgrid_Balance[fgrid_Balance.Rows.Count-1, iQTY ] = " ";
					fgrid_Balance[fgrid_Balance.Rows.Count-1,0 ] = " ";

											
				}

				for(int j=(int)ClassLib.TBSEM_OBS_OA_CREATE02.IxCS_SIZE  ; j<fgrid_Balance.Cols.Count; j++)
				{
					if (fgrid_Balance[1, j].ToString() == sSIZE)
					{
						if (arg_oa_flag!= _DeleteDesc )
							fgrid_Balance[fgrid_Balance.Rows.Count-1, j] = sQTY;
						else
							fgrid_Balance[fgrid_Balance.Rows.Count-1, j] = "-" + sQTY;

						fgrid_Balance.LeftCol = Convert.ToInt16(fgrid_Balance.Cols.Count/2);
						break;
					}
				}
				

				
				

			} 
			
			fgrid_Balance.Cols[0].Width = 0;

			

			
			
			


		}


		private void Drow_Order_Link_Search()
		{

            int vLinkStart = 0,vLinkEnd = 0;

			DataTable dt_list;
			dt_list  = Select_Add_Link(cmb_Factory.SelectedValue.ToString(), cmb_OA_Nu.SelectedValue.ToString());

			//AddFlow의  Line그리기
			for (int i =0 ; i<dt_list.Rows.Count  ; i++)
			{
				for (int j=0 ; j<AddFlow.Items.Count   ;j++)
				{
					
					if (( AddFlow.Items[j].Text   == _DeleteDesc )  &&
						(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxTOOLTIP -1].ToString()  == AddFlow.Items[j].Tooltip.ToString()))
					{
						vLinkStart  = j;
						break;

					}
				}


				for (int j=0 ; j<AddFlow.Items.Count   ;j++)
				{
					if (( AddFlow.Items[j].Text  == _InsertDesc  )  &&
						(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxTOOLTIP -1].ToString()  == AddFlow.Items[j].Tooltip.ToString()))
					{
						vLinkEnd  = j;
						break;

					}
				}
                        																																							   
				Link link1 = AddFlow.CreateLink(AddFlow.Nodes[vLinkStart], AddFlow.Nodes[vLinkEnd]); 
					                            
				link1.Text =  dt_list.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_OA_CREATE03.IxTOOLTIP -1].ToString();

				

			}


		}


		private void Drow_Order_Link()
		{


			int  vLinkStart = -1, vLinkEnd= -1;
			string vNewMaxOARelFlag = "0";
			//string   vNewMaxOARelFlag = "0";  
 


			//MaxFlag구하기 
			for(int i = 0 ;  i< AddFlow.Nodes.Count -1  ; i++)			
			{

				if (((AddFlow.Nodes[i].Text == _DeleteDesc) || (AddFlow.Nodes[i].Text == _InsertDesc )) && ( (AddFlow.Nodes[i].Tooltip   == null) ||(AddFlow.Nodes[i].Tooltip   == "")))
				{
					_NewMaxOARelFlag =  (Convert.ToUInt16(_NewMaxOARelFlag) < Convert.ToUInt16(AddFlow.Nodes[i].Tooltip)) ? AddFlow.Nodes[i].Tooltip:_NewMaxOARelFlag;
					vNewMaxOARelFlag = Convert.ToString(Select_OA_Rel_Flag(_NewMaxOARelFlag));								

				}


			}


			
			//AddFlow의  "Delete Flag"의 좌표잡기
			for(int i = 0 ;  i< AddFlow.Nodes.Count -1  ; i++)			
			{

				if ((AddFlow.Nodes[i].Text == _DeleteDesc) &&( (AddFlow.Nodes[i].Tooltip   == null) ||(AddFlow.Nodes[i].Tooltip   == "") ) ) 
				{
					vLinkStart = i;										
					break;
				}

				continue;

			}


			//AddFlow의  "Insert Flag"의 좌표잡기
			for(int i= 0 ;  i< AddFlow.Nodes.Count -1  ; i++)			
			{

				if ((AddFlow.Nodes[i].Text == _InsertDesc) &&( (AddFlow.Nodes[i].Tooltip   == null) ||(AddFlow.Nodes[i].Tooltip   == "") ) ) 
				{
					vLinkEnd = i;
					break;
				}

				continue;

			}


			//AddFlow의  Line그리기 
			if (vLinkStart ==vLinkEnd)  return; 
			if ((vLinkStart != -1) &&  (vLinkEnd != -1 ) )
			{
				_NewMaxOARelFlag  = vNewMaxOARelFlag; 

				Link link1 = AddFlow.CreateLink(AddFlow.Nodes[vLinkStart], AddFlow.Nodes[vLinkEnd]); 
				AddFlow.Nodes[vLinkStart].Tooltip =_NewMaxOARelFlag;
				AddFlow.Nodes[vLinkEnd].Tooltip =_NewMaxOARelFlag;
			
				link1.Text =_NewMaxOARelFlag;

				Set_Link_Property(link1);

			}
			

		}


		private void  Set_Node_Property( Lassalle.Flow.Node  arg_node, string  arg_type , string arg_node_tag )
		{

			switch(arg_type)
			{
				case "I":     //Title 
					arg_node.Alignment = Alignment.CenterMIDDLE;
					arg_node.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
					arg_node.DrawColor = Color.Black;
					arg_node.DrawWidth = 1;
					arg_node.FillColor = Color.White; 
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/7/False/False/False/False"); 
					arg_node.Gradient = true; 
					arg_node.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
					arg_node.GradientColor = Color.FromArgb(128, 255, 128); 
					arg_node.Shape.Style = ShapeStyle.Rectangle; 
					arg_node.TextColor = Color.Black; 
					arg_node.Tag = arg_node_tag;					
					break;

				case "D":  //Detail
					arg_node.Alignment = Alignment.CenterMIDDLE;
					arg_node.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
					arg_node.DrawColor = Color.Black;
					arg_node.DrawWidth = 1;
					arg_node.FillColor = Color.White; 
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/7/False/False/False/False"); 
					arg_node.Gradient = true; 
					arg_node.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
					arg_node.GradientColor = Color.FromArgb(255, 120, 0); 
					arg_node.Shape.Style = ShapeStyle.Rectangle; 
					arg_node.TextColor = Color.Black; 
					arg_node.Tag = arg_node_tag;
					break;
		       
			}



		}


		private void Set_Link_Property(Lassalle.Flow.Link  arg_link)
		{


			arg_link.Font = ClassLib.ComFunction.ToFont("Verdana/7/False/False/False/False");
			arg_link.Line.Style  =LineStyle.Polyline;
			arg_link.ArrowDst.Angle  = ArrowAngle.deg15;
			arg_link.ArrowDst.Size   = ArrowSize.Small;
			arg_link.TextColor       = Color.Black;
			arg_link.DrawColor       = Color.Black;
			arg_link.Line.Style = LineStyle.HVH;
			arg_link.BackMode = BackMode.Opaque;
			



		}


		private void Set_Obs_List()
		{

			try
			{
				this.Cursor = Cursors.WaitCursor;
				DataTable dt_list;

				dt_list  = Select_Obs_List();

				fgrid_Order.Display_Grid(dt_list, true); 

				//Display Balanc의 Flag용
				_dt_flag.Rows.Clear();		_dt_flag.Columns.Clear();
				int vCol =6;
				for (int i = 0 ; i < vCol  ;i++)
					_dt_flag.Columns.Add(new DataColumn(i.ToString(), typeof(string)));

				this.Cursor = Cursors.Default;

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_Obs_List()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 

			}


		}


		#endregion 

		#region  Data 컨넥트
		
		
		private DataTable Make_OA_Nu()
		{
			string vJobPackage;
 
			DataSet ret; 

			MyOraDB.ReDim_Parameter(2); 
            
			vJobPackage  = "PKG_SEM_OA_CREATE.MAKE_SEM_OA_NU";
			MyOraDB.Process_Name =vJobPackage;
			
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR"; 
				
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
	
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = "";
				
			MyOraDB.Add_Select_Parameter(true); 
			ret = MyOraDB.Exe_Select_Procedure();
			
			//setting grid
			if(ret == null) 
			{
				ClassLib.ComFunction.User_Message("Order Adjust Number Creation Error","Make_OA_Nu()",MessageBoxButtons.OK  ,MessageBoxIcon.Error);
				return null;
			}
			else
			{
				return ret.Tables[vJobPackage];
			}
			
		}


		
		private bool Delete_Sem_OA(string arg_factory, string arg_oanu)
		{

			try
			{
		   


				int vCnt = 5;
				MyOraDB.ReDim_Parameter(vCnt);
				MyOraDB.Process_Name = "PKG_SEM_OA_CREATE.DELETE_SEM_OBS_OA"; 
				
				//Parameter Name
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";	      
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";  		 
				MyOraDB.Parameter_Name[2] = "ARG_OA_NU";        
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";  		 
				MyOraDB.Parameter_Name[4] = "ARG_UPD_YMD"; 

				//Parameter Type
				for (int i =0 ; i< vCnt; i++)
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 


				//Parameter Value			
				MyOraDB.Parameter_Values[0] = _job_division;
				MyOraDB.Parameter_Values[1] = arg_factory;
				MyOraDB.Parameter_Values[2] = arg_oanu;
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;
				MyOraDB.Parameter_Values[4] =  System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  

				
				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();

				return true;




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "Delete_Sem_OA()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;

			}


		}




		
		private bool Save_OA_List()
		{
			try
			{
						
				int     vOASeqNu =0;
			

		
				if (_job_division == ClassLib.ComVar.ConsJob_I) 
				{
					DataTable dt_list;
					dt_list = Make_OA_Nu();
					_OANumber = Convert.ToString(dt_list.Rows[0].ItemArray[0]);
				}

				int vParm = 30;
				MyOraDB.ReDim_Parameter(vParm); 

				//Package Name
				MyOraDB.Process_Name= "PKG_SEM_OA_CREATE.SAVE_SEM_OBS_OA";

				#region Name
				int vCntName =0;
				MyOraDB.Parameter_Name[vCntName++] = "ARG_JOB_FLAG"; 	               
				MyOraDB.Parameter_Name[vCntName++] = "ARG_DIVISION"; 	               
				MyOraDB.Parameter_Name[vCntName++] = "ARG_FACTORY";  	               
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OA_NU";                    
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OA_DIV";        //SECONC CLASS               
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OA_YMD";                   
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OA_CFM"; 	                 
				MyOraDB.Parameter_Name[vCntName++] = "ARG_CHG_YMD";    	             
				MyOraDB.Parameter_Name[vCntName++] = "ARG_PUR_NO";                   
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OUR_REF_NO";               
				MyOraDB.Parameter_Name[vCntName++] = "ARG_PUR_GRP";                  
				MyOraDB.Parameter_Name[vCntName++] = "ARG_YOUR_REF";                 
				MyOraDB.Parameter_Name[vCntName++] = "ARG_ORDER_RSN";                
				MyOraDB.Parameter_Name[vCntName++] = "ARG_QUAL_ISEQ"; 	             
				MyOraDB.Parameter_Name[vCntName++] = "ARG_SEASON_CD";                
				MyOraDB.Parameter_Name[vCntName++] = "ARG_SEASON_YEAR";              
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OA_SEQ_NU";     //           
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OA_POSITION";              
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OBS_DIV";                  
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OA_OBS_DIV";         //FRISRT CLASS      
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OBS_ID"; 	                 
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OBS_TYPE";                 
				MyOraDB.Parameter_Name[vCntName++] = "ARG_STYLE_CD";                 
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OBS_NU";                   
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OBS_SEQ_NU";               
				MyOraDB.Parameter_Name[vCntName++] = "ARG_CHG_NU"; 	                 
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OA_FLAG";                  
				MyOraDB.Parameter_Name[vCntName++] = "ARG_OA_REL_FLAG";              
				MyOraDB.Parameter_Name[vCntName++] = "ARG_REMARKS";                  
				MyOraDB.Parameter_Name[vCntName++] = "ARG_UPD_USER"; 		     

				#endregion  

				//Parameter Type
				for (int i =0 ; i< vParm; i++)
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 



				int vCount  =0;
				int vStartRow =0;
				for (int i =fgrid_Balance.Rows.Fixed  ;  i< fgrid_Balance.Rows.Count ; i++)	
				{
					if ((fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxFACTORY] != null)  &&
						(fgrid_Balance[i,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxFACTORY].ToString() == cmb_Factory.SelectedValue.ToString()))
					{
						vCount  = vCount  +1;
						vStartRow = (vStartRow ==0) ?  i: vStartRow;  
					}
				}
					
	           
				MyOraDB.Parameter_Values =  new  string[vCount * vParm] ;
					//MyOraDB.Parameter_Values  = new string[col_ct * (save_ct)];


				#region Value
				int vCntValues  = 0; 
				for(int j =  vStartRow  ; j< fgrid_Balance.Rows.Count  ; j++)
				{

					
					if ((fgrid_Balance[j,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxFACTORY] != null)  &&
						(fgrid_Balance[j,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxFACTORY].ToString() == cmb_Factory.SelectedValue.ToString()))
						vOASeqNu++;
					else
						continue;



					MyOraDB.Parameter_Values[vCntValues++]  = (j ==  vStartRow) ?_Head:_Tail;
					MyOraDB.Parameter_Values[vCntValues++]  = _job_division;	 
					MyOraDB.Parameter_Values[vCntValues++]  = cmb_Factory.SelectedValue.ToString();	
					MyOraDB.Parameter_Values[vCntValues++]  = _OANumber;                     
					MyOraDB.Parameter_Values[vCntValues++]  = cmb_FirstClass.SelectedValue.ToString(); 
					MyOraDB.Parameter_Values[vCntValues++]  = dtp_Adjust_Date.Text.Replace("-","") ;		
					MyOraDB.Parameter_Values[vCntValues++]  = ClassLib.ComFunction.Empty_String(_OAConfirm,ClassLib.ComVar.ConsOBS_R);; 							  
					MyOraDB.Parameter_Values[vCntValues++]  = dtp_Apply_Date.Text.Replace("-","");		
					MyOraDB.Parameter_Values[vCntValues++]  = ClassLib.ComFunction.Empty_TextBox(txt_Purchase_No," ") ;
					MyOraDB.Parameter_Values[vCntValues++]  = ClassLib.ComFunction.Empty_TextBox(txt_Our_Reference," ") ;     
					MyOraDB.Parameter_Values[vCntValues++]  = ClassLib.ComFunction.Empty_TextBox(txt_Purchase_Group, " ");
					MyOraDB.Parameter_Values[vCntValues++] =  ClassLib.ComFunction.Empty_TextBox(txt_Your_Reference," ") ;
					MyOraDB.Parameter_Values[vCntValues++] =  ClassLib.ComFunction.Empty_TextBox(txt_Order_Reason," ");    
					MyOraDB.Parameter_Values[vCntValues++] =  ClassLib.ComFunction.Empty_TextBox(txt_Qual_Iseq," ") ;       
					MyOraDB.Parameter_Values[vCntValues++] =  cmb_Season_Code.SelectedValue.ToString();      
					MyOraDB.Parameter_Values[vCntValues++] =  cmb_Season_Year.Text;
					MyOraDB.Parameter_Values[vCntValues++] =  vOASeqNu.ToString().PadLeft(5,'0');
					MyOraDB.Parameter_Values[vCntValues++] =  fgrid_Balance[j,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG].ToString().Substring(0,1);
					MyOraDB.Parameter_Values[vCntValues++] =  " ";                            //"ARG_OBS_DIV";  
					MyOraDB.Parameter_Values[vCntValues++] =  cmb_SecondClass.SelectedValue.ToString();
					MyOraDB.Parameter_Values[vCntValues++] =  cmb_OBS_ID.Text;  
					MyOraDB.Parameter_Values[vCntValues++] =  cmb_OBS_Type.SelectedValue.ToString();       
					MyOraDB.Parameter_Values[vCntValues++] =  cmb_Style_Cd.SelectedValue.ToString();  
					MyOraDB.Parameter_Values[vCntValues++] =  fgrid_Balance[j,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOBS_NU].ToString(); 
					MyOraDB.Parameter_Values[vCntValues++] =  fgrid_Balance[j,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOBS_SEQ_NU].ToString();
					MyOraDB.Parameter_Values[vCntValues++]  = fgrid_Balance[j,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxCHG_NU].ToString(); 	   
					MyOraDB.Parameter_Values[vCntValues++]  = fgrid_Balance[j,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_FLAG].ToString().Substring(0,1); 
					MyOraDB.Parameter_Values[vCntValues++]  = fgrid_Balance[j,(int)ClassLib.TBSEM_OBS_OA_CREATE02.lxOA_REL_FLAG].ToString();
					MyOraDB.Parameter_Values[vCntValues++]  = ClassLib.ComFunction.Empty_TextBox(txt_Remarks," "); ; 
					MyOraDB.Parameter_Values[vCntValues++]  = ClassLib.ComVar.This_User;	     

				}
				#endregion


				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();



				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "Save_OA_List()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;

			}

		}


		


		private bool Save_OA_AddNode()
		{

			try
			{
		   

				Lassalle.Flow.Node node;


				int vParm = 21, vSaveCount = 0,vName=0 ;
				MyOraDB.ReDim_Parameter(vParm);
				MyOraDB.Process_Name = "PKG_SEM_OA_CREATE.SAVE_SEM_OBS_OA_NODE"; 
				
				
				MyOraDB.Parameter_Name[vName++] = "ARG_DIVISION";	      
				MyOraDB.Parameter_Name[vName++] = "ARG_FACTORY";  		 
				MyOraDB.Parameter_Name[vName++] = "ARG_OA_NU";        
				MyOraDB.Parameter_Name[vName++] = "ARG_OA_NODE";    
				MyOraDB.Parameter_Name[vName++] = "ARG_OA_NODE_SEQ";
				MyOraDB.Parameter_Name[vName++] = "ARG_OA_FLAG";
				MyOraDB.Parameter_Name[vName++] = "ARG_OA_LINK_SEQ";
				MyOraDB.Parameter_Name[vName++] = "ARG_ORG_NODE";     
				MyOraDB.Parameter_Name[vName++] = "ARG_DST_NODE";     
				MyOraDB.Parameter_Name[vName++] = "ARG_ARROW_DST";    
				MyOraDB.Parameter_Name[vName++] = "ARG_ARROW_MID";    
				MyOraDB.Parameter_Name[vName++] = "ARG_ARROW_ORG";    
				MyOraDB.Parameter_Name[vName++] = "ARG_NODE_TOP";     
				MyOraDB.Parameter_Name[vName++] = "ARG_NODE_LEFT";    
				MyOraDB.Parameter_Name[vName++] = "ARG_NODE_WIDTH";   
				MyOraDB.Parameter_Name[vName++] = "ARG_NODE_HEIGHT";  
				MyOraDB.Parameter_Name[vName++] = "ARG_TAG"; 		     
				MyOraDB.Parameter_Name[vName++] = "ARG_TEXT";         
				MyOraDB.Parameter_Name[vName++] = "ARG_TOOLTIP"; 	 	 
				MyOraDB.Parameter_Name[vName++] = "ARG_UPD_USER";     
				MyOraDB.Parameter_Name[vName++] = "ARG_UPD_YMD";   
 

			
				//Parameter Type
				for (int iType =0 ; iType< vParm; iType++)
					MyOraDB.Parameter_Type[iType] = (int)OracleType.VarChar; 


			
				//Parameter Value	
				foreach(Item item in AddFlow.Items)
				{
					if(item is Lassalle.Flow.Node) vSaveCount++; 
				}

				MyOraDB.Parameter_Values  = new string[vParm *( vSaveCount)];

				int vValue = 0;
				foreach(Item item in AddFlow.Items)
				{
					if(item is Lassalle.Flow.Node)
					{
						node = (Lassalle.Flow.Node)item;

						int index = node.Index;
						//					RectangleF rc = node.Rect; 

						
						MyOraDB.Parameter_Values[vValue++] = _job_division;
						MyOraDB.Parameter_Values[vValue++] = cmb_Factory.SelectedValue.ToString();  
						MyOraDB.Parameter_Values[vValue++] = ClassLib.ComFunction.Empty_String(_OANumber," ");
						MyOraDB.Parameter_Values[vValue++] = node.Tag.ToString();
						MyOraDB.Parameter_Values[vValue++] = node.Index.ToString();
						MyOraDB.Parameter_Values[vValue++] = (AddFlow.Nodes[index].GradientColor != Color.FromArgb(128, 255, 128))? _Delete:_Insert;
						MyOraDB.Parameter_Values[vValue++] = " "; //ARG_OA_LINK_SEQ
						MyOraDB.Parameter_Values[vValue++] = " "; //ARG_ORG_NODE
						MyOraDB.Parameter_Values[vValue++] = " "; //ARG_DST_NODE
						MyOraDB.Parameter_Values[vValue++] = " "; //"ARG_ARROW_DST
						MyOraDB.Parameter_Values[vValue++] = " ";//ARG_ARROW_MID
						MyOraDB.Parameter_Values[vValue++] = " ";//ARG_ARROW_ORG
						MyOraDB.Parameter_Values[vValue++] = AddFlow.Nodes[index].Location.Y.ToString();  //TOP
						MyOraDB.Parameter_Values[vValue++] = AddFlow.Nodes[index].Location.X.ToString();  //LEFT
						MyOraDB.Parameter_Values[vValue++] = _BaseWidth.ToString();                       //WIDTH
						MyOraDB.Parameter_Values[vValue++] = _BaseHeight.ToString();                      //Height
						MyOraDB.Parameter_Values[vValue++] = AddFlow.Nodes[index].Tag.ToString();
						MyOraDB.Parameter_Values[vValue++] = AddFlow.Nodes[index].Text;
						MyOraDB.Parameter_Values[vValue++] = (AddFlow.Nodes[index].Tooltip == null)? " ": (ClassLib.ComFunction.Empty_String(AddFlow.Nodes[index].Tooltip," "));
						MyOraDB.Parameter_Values[vValue++] = ClassLib.ComVar.This_User;
						MyOraDB.Parameter_Values[vValue++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  
			
					} 


				}//end foreach 
						


				
				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();

				return true;




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "Save_OA_AddFlow()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;

			}


		}



		private bool Save_OA_AddLink()
		{

			try
			{
		   

				Lassalle.Flow.Link link;

				int vParm = 13, vSaveCount = 0,vName=0 ;
				MyOraDB.ReDim_Parameter(vParm);
				MyOraDB.Process_Name = "PKG_SEM_OA_CREATE.SAVE_SEM_OBS_OA_LINK"; 
				
				
				MyOraDB.Parameter_Name[vName++] = "ARG_DIVISION";	      
				MyOraDB.Parameter_Name[vName++] = "ARG_FACTORY";  		 
				MyOraDB.Parameter_Name[vName++] = "ARG_OA_NU";        
				MyOraDB.Parameter_Name[vName++] = "ARG_OA_NODE";    
				MyOraDB.Parameter_Name[vName++] = "ARG_OA_NODE_SEQ";
				MyOraDB.Parameter_Name[vName++] = "ARG_OA_LINK_SEQ";
				MyOraDB.Parameter_Name[vName++] = "ARG_ORG_NODE";     
				MyOraDB.Parameter_Name[vName++] = "ARG_DST_NODE";     
				MyOraDB.Parameter_Name[vName++] = "ARG_ARROW_DST";    
				MyOraDB.Parameter_Name[vName++] = "ARG_ARROW_MID";    
				MyOraDB.Parameter_Name[vName++] = "ARG_ARROW_ORG";     	 	 
				MyOraDB.Parameter_Name[vName++] = "ARG_UPD_USER";     
				MyOraDB.Parameter_Name[vName++] = "ARG_UPD_YMD";   
 


			
				//Parameter Type
				for (int iType =0 ; iType< vParm; iType++)
					MyOraDB.Parameter_Type[iType] = (int)OracleType.VarChar; 




			
				//Parameter Value	
				foreach(Item item in AddFlow.Items)
				{
					if(item is Lassalle.Flow.Link) vSaveCount++; 
				}



				MyOraDB.Parameter_Values  = new string[vParm * vSaveCount];

				int vValue = 0;
				foreach(Item item in AddFlow.Items)
				{
					if(item is Lassalle.Flow.Link)
					{
					    link = (Lassalle.Flow.Link)item;

						string index = link.Text;
					

						MyOraDB.Parameter_Values[vValue++] = _job_division;
						MyOraDB.Parameter_Values[vValue++] = cmb_Factory.SelectedValue.ToString();  
						MyOraDB.Parameter_Values[vValue++] = ClassLib.ComFunction.Empty_String(_OANumber," ");  //ARG_OA_NU
						MyOraDB.Parameter_Values[vValue++] = " ";                                               //ARG_OA_NODE
						MyOraDB.Parameter_Values[vValue++] = " ";                                               //ARG_OA_NODE_SEQ 
						MyOraDB.Parameter_Values[vValue++] = link.Text;                                         //ARG_OA_LINK_SEQ 
						MyOraDB.Parameter_Values[vValue++] = link.Org.Index.ToString();                         //ARG_ORG_NODE
						MyOraDB.Parameter_Values[vValue++] = link.Dst.Index.ToString();                         //ARG_DST_NODE
						MyOraDB.Parameter_Values[vValue++] = " "; //"ARG_ARROW_DST
						MyOraDB.Parameter_Values[vValue++] = " "; //ARG_ARROW_MID
						MyOraDB.Parameter_Values[vValue++] = " "; //ARG_ARROW_ORG
						MyOraDB.Parameter_Values[vValue++] = ClassLib.ComVar.This_User;
						MyOraDB.Parameter_Values[vValue++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  
			
					} 


				}//end foreach 
						


				
				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();

				return true;




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "Save_OA_AddFlow()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;

			}


		}



		private DataTable  Select_Obs_Size(string arg_factory, string arg_obs_nu, string arg_obs_seq_nu, string obs_chg_nu)
		{
			DataSet ds_ret;


			string process_name = "PKG_SEM_OA_CREATE.SELECT_SEM_OBS_SIZE_LIST";


			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[3]  = "ARG_CHG_NU";
			MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = arg_factory;
			MyOraDB.Parameter_Values[1]  = arg_obs_nu;
			MyOraDB.Parameter_Values[2]  = arg_obs_seq_nu;
			MyOraDB.Parameter_Values[3]  = obs_chg_nu;
			MyOraDB.Parameter_Values[4]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}


		private DataTable  Select_Add_Node(string arg_factory, string arg_oa_nu)
		{
			DataSet ds_ret;


			string process_name = "PKG_SEM_OA_CREATE.SELECT_SEM_OBS_OA_NODE";


			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OA_NU";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = arg_factory;
			MyOraDB.Parameter_Values[1]  = arg_oa_nu;
			MyOraDB.Parameter_Values[2]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}
		


		
		private DataTable  Select_Add_Link(string arg_factory, string arg_oa_nu)
		{
			DataSet ds_ret;


			string process_name = "PKG_SEM_OA_CREATE.SELECT_SEM_OBS_OA_LINK";


			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OA_NU";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = arg_factory;
			MyOraDB.Parameter_Values[1]  = arg_oa_nu;
			MyOraDB.Parameter_Values[2]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}


		private DataTable  Select_OA(string arg_factory, string arg_oa_nu)
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CREATE.SELECT_SEM_OBS_OA_LIST";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OA_NU";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = arg_factory;
			MyOraDB.Parameter_Values[1]  = arg_oa_nu;
			MyOraDB.Parameter_Values[2]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}




		private DataTable  Select_OA_Relation(string arg_factory, string arg_oa_nu)
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CREATE.SELECT_SEM_OBS_OA_REL_LIST";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OA_NU";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = arg_factory;
			MyOraDB.Parameter_Values[1]  = arg_oa_nu;
			MyOraDB.Parameter_Values[2]  = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

			
		}




		private DataTable  Select_Obs_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CREATE.SELECT_SEM_OBS_LIST";

			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = cmb_OBS_ID.Text.ToString();
			MyOraDB.Parameter_Values[2]  = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[3]  = ClassLib.ComFunction.Empty_Combo(cmb_Style_Cd ," ");
			MyOraDB.Parameter_Values[4]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}


		private string  Select_OA_Rel_Flag(string arg_oa_rel_flag)
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CREATE.SELECT_OA_REL_FLAG";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OR_REL_FLAG";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = (arg_oa_rel_flag == "")? "0": arg_oa_rel_flag;
			MyOraDB.Parameter_Values[2]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString(); 

	}


	


		private DataTable  Select_Receive_Check()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CREATE.CHECK_SEM_RECEIVE";

			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";


			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = cmb_OBS_ID.Text;
			MyOraDB.Parameter_Values[2]  = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[3]  = cmb_Style_Cd.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]  = "";
		
			MyOraDB.Add_Select_Parameter(true);

			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
		
			return ds_ret.Tables[process_name]; 

		}


		private DataTable  Select_OA_Check()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CREATE.CHECK_SEM_OA_APPLY";

			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";


			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = cmb_OBS_ID.Text;
			MyOraDB.Parameter_Values[2]  = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[3]  = cmb_Style_Cd.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}



		private DataTable  Select_Cancel_Check()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CREATE.CHECK_SEM_OA_CANCEL";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OA_NU";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";


			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = _OANumber;	
			MyOraDB.Parameter_Values[2]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		

		#endregion 

		#region 이벤트처리



		private void cmb_OBS_Type_TextChanged(object sender, System.EventArgs e)
		{

			cmb_OBS_ID.ClearItems();
			txt_Style_Cd.Clear();

			if (cmb_OBS_Type.SelectedIndex  == 0) return;

			ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type.SelectedValue.ToString(), cmb_OBS_ID);  

		}



		
		private void cmb_OBS_ID_TextChanged(object sender, System.EventArgs e)
		{
		
			
			try
			{

				if (cmb_OBS_ID.SelectedIndex  == 0) return;

				cmb_Style_Cd.ClearItems();
				txt_Style_Cd.Clear();
				DataTable dt_list ;

				//TEST(cmb_style_cd의 개체를 완전히 dispose시키고 다시한번해보기)
				dt_list = MyOraDB.Select_OBS_Style(cmb_Factory.SelectedValue.ToString(),cmb_OBS_ID.Text , cmb_OBS_Type.SelectedValue.ToString()," " );

				if ((dt_list  == null) || (dt_list.Rows.Count  == 0))   return;
				COM.ComCtl.Set_ComboList(dt_list, cmb_Style_Cd , 0, 1, true,70,150);
				//ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Style_Cd , 0, 1, false)
				//ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Style_Cd, 0, 1,  true);		
				//ClassLib.ComCtl.Set_ComboList_AddItem(dt_list, cmb_Style_Cd, 0, 1, true, 70,150);	
				
				//cmb_Style_Cd.Splits[0].DisplayColumns["Code"].Width = 70;
				//cmb_Style_Cd.Splits[0].DisplayColumns["Name"].Width = 150-25;//스크롤 방지

				//if (cmb_Style_Cd = 
				//cmb_Style_Cd.SelectedIndex = -1;
				
				


			}
			catch(Exception ex)
			{

				ClassLib.ComFunction.User_Message(ex.ToString(),"cmb_OBS_ID_TextChanged()",MessageBoxButtons.OK , MessageBoxIcon.Error);

			}


		}


	

		private void txt_Style_Cd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			try
			{
				if(e.KeyChar == (char)13)
				{
								
				
					cmb_Style_Cd.ClearItems();
					DataTable dt_list ;

					dt_list = MyOraDB.Select_OBS_Style(cmb_Factory.SelectedValue.ToString(),cmb_OBS_ID.Text , cmb_OBS_Type.SelectedValue.ToString(),txt_Style_Cd.Text );

					if ((dt_list == null) || (dt_list.Rows.Count   == 0 )) return;

					//ClassLib.ComCtl.Set_ComboList_AddItem(dt_list,cmb_Style_Cd ,0,1);				
					ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Style_Cd, 0, 1, true, 70,150);
					cmb_Style_Cd.SelectedIndex = -1;

				}
			}
			catch
			{
 
					
			}
	
		}

		private void cmb_Style_Cd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
			try
			{
				this.Cursor = Cursors.WaitCursor;

				

				//cmb_OA_Nu = null;
				fgrid_Balance.Rows.Count  = fgrid_Balance.Rows.Fixed;
				fgrid_Order.Rows.Count  = fgrid_Order.Rows.Fixed;
				txt_Style_Cd.Clear();
				AddFlow.Items.Clear();
			
			

				DataTable dt_list ;
				if (cmb_Style_Cd.SelectedIndex <=0) return;
				txt_Style_Cd.Text  = cmb_Style_Cd.SelectedValue.ToString();

		
				Set_Obs_List();
			

				//Size run Setting 
				MyOraDB.Select_Gen_Pst(cmb_Style_Cd.SelectedValue.ToString());
				fgrid_Balance.Rows.Count   = fgrid_Balance.Rows.Fixed;
				dt_list =MyClassLib.Select_Gen_Size(cmb_Factory.SelectedValue.ToString(),ClassLib.ComVar.DivGen, ClassLib.ComVar.DivPst);
				ClassLib.ComFunction.Set_SizeHeadToGrid(fgrid_Balance.Rows.Fixed-1,fgrid_Balance.Cols.Count,dt_list,fgrid_Balance );

				_Style   = cmb_Style_Cd.SelectedValue.ToString();
				txt_Style_Cd.Text  =_Style;


			   
			
				cmb_OA_Nu.DataSource = null;
				dt_list = MyOraDB.Select_Create_OA_Nu(cmb_Factory.SelectedValue.ToString(), cmb_OBS_ID.Text ,cmb_OBS_Type.SelectedValue.ToString(),
					cmb_Style_Cd.SelectedValue.ToString());		
					
				if ((dt_list  == null) || (dt_list.Rows.Count  == 0))   return;				
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OA_Nu , 0, 1, true,70,150);		
				
			

				this.Cursor = Cursors.Default;

			}
			catch(Exception ex)
			{
			    btn_Confirm.Enabled = true;
				btn_Cancel.ForeColor = System.Drawing.Color.Black;
				btn_Cancel.Enabled   = true;
				btn_Cancel.ForeColor = System.Drawing.Color.Black;
				this.Cursor = Cursors.Default;
				//ClassLib.ComFunction.User_Message(ex.ToString(), "cmb_Style_Cd_SelectedValueChanged()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				ClassLib.ComFunction.Status_Bar_Message( ex.ToString() + "cmb_Style_Cd_SelectedValueChanged()" ,this);
						
			}	
			finally
			{
				this.Cursor = Cursors.Default;

			}
		}


	
		private void cmb_OA_Nu_TextChanged(object sender, System.EventArgs e)
		{
//
//			try
//			{
//				Set_Clear(_OANumberChange);
//
//				if ((cmb_OA_Nu.SelectedValue.ToString()  == null) || (cmb_OA_Nu.SelectedValue.ToString() == "")) 
//				{
//					_OANumber = "";
//					return;
//				}
//
//
//			
//				
//
//				Set_OA_List(cmb_Factory.SelectedValue.ToString(), cmb_OA_Nu.SelectedValue.ToString());
//
//				if (cmb_OA_Nu.Columns[1].Text.Substring(0,1) ==ClassLib.ComVar.ConsCFM_C)
//					Set_Enable(ClassLib.ComVar.ConsCFM_C);
//				else if  (cmb_OA_Nu.Columns[1].Text.Substring(0,1) ==ClassLib.ComVar.ConsCFM_R)
//					Set_Enable(ClassLib.ComVar.ConsCFM_R);
//				else
//					Set_Enable(ClassLib.ComVar.ConsCFM_P);
//					
//                
//			   
//
//
//				_OANumber   = cmb_OA_Nu.SelectedValue.ToString();
//				
//			}
//			catch//(Exception ex)
//			{
//				this.Cursor = Cursors.Default;
//				//ClassLib.ComFunction.User_Message(ex.ToString(), "cmb_OA_Nu_TextChanged()", MessageBoxButtons.OK, MessageBoxIcon.Error);
//								
//			}	
//			finally
//			{
//
//				this.Cursor = Cursors.Default;
//			}
		

		}


		private void AddFlow_DoubleClick(object sender, System.EventArgs e)
		{
			for (int i = 0 ; i< AddFlow.Nodes.Count ; i++)
			{
		
				if (AddFlow.Nodes[i].Selected == true)
				{

	
					Set_Pop_Order_Size(AddFlow.Nodes[i].Tag.ToString().Substring(0,10),
						AddFlow.Nodes[i].Tag.ToString().Substring(10,10),
						AddFlow.Nodes[i].Tag.ToString().Substring(20,5));
				
				}
			}


		}


		private void fgrid_Order_DoubleClick(object sender, System.EventArgs e)
		{
			Set_Pop_Order_Size(	fgrid_Order[fgrid_Order.Selection.r1,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxOBS_NU].ToString(),
				fgrid_Order[fgrid_Order.Selection.r1,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxOBS_SEQ_NU].ToString(),
				fgrid_Order[fgrid_Order.Selection.r1,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxCHG_NU].ToString());

		
		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			
			try
			{   
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_Factory ,cmb_FirstClass, cmb_OBS_ID, cmb_OBS_Type, cmb_Season_Code, cmb_Season_Year , cmb_SecondClass , cmb_Style_Cd }; 
				System.Windows.Forms.TextBox[] txt_array = {txt_Order_Reason,txt_Our_Reference ,txt_Purchase_Group ,txt_Purchase_No ,txt_Qual_Iseq }; 


				

				if (Check_Save()  != true) return;
			

				_job_division = ClassLib.ComVar.ConsJob_I ;
				if (Save_OA_List() != true) 
				{	
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndOK , this);
					return;
				}

				if (Save_OA_AddNode() != true) //
				{	
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndOK , this);
					return;
				}


				if (Save_OA_AddLink() != true) //
				{	
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndOK , this);
					return;
				}



//			
//				if (_OANumber !="")
//					cmb_OA_Nu.SelectedValue   = _OANumber;
//



				Set_Pop_OA_Confirm();


				this.Cursor = Cursors.Default;

			}
			catch(Exception ex)
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.User_Message(ex.ToString(), "tbtn_Save_Click()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}	
			finally
			{

				this.Cursor = Cursors.Default;
			}
		
		}


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			cmb_Style_Cd_SelectedValueChanged(null,null);
		}

	
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{
				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this);
				if(DialogResult.Yes != dr) return;


				this.Cursor = Cursors.WaitCursor;
				_job_division = ClassLib.ComVar.ConsJob_D ;

				if(cmb_OA_Nu.Columns[1].Text.Substring(0,1) == ClassLib.ComVar.ConsCFM_C  )
				{
					ClassLib.ComFunction.User_Message("This order adjust is confirmed ..", "tbtn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);

					return;
				}

				Delete_Sem_OA(cmb_Factory.SelectedValue.ToString(), cmb_OA_Nu.SelectedValue.ToString());
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndDelete , this);
				

				cmb_OA_Nu.SelectedIndex  = -1;
				cmb_Style_Cd_SelectedValueChanged(null,null);


			}
			catch(Exception ex)
			{

				MessageBox.Show(ex.ToString(),  "tbtn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			Set_Clear(_StyleChange);
			cmb_OA_Nu.SelectedValue ="";
			//Set_Clear(_OANumberChange);


		}




		private void btn_Confirm_Click(object sender, System.EventArgs e)
		{


			if ((cmb_OA_Nu.SelectedValue == null) || (cmb_OA_Nu.SelectedValue.ToString().Length<10))
			{
				ClassLib.ComFunction.User_Message("Please ..Check adjust  number!!",   "btn_Confirm_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}


			Set_Pop_OA_Confirm();
	

		}


		private void btn_OBS_ID_Click(object sender, System.EventArgs e)
		{
			try
			{

				if (cmb_OBS_ID.SelectedIndex  == 0) return;

				cmb_Style_Cd.ClearItems();
				txt_Style_Cd.Clear();
				DataTable dt_list ;

				//TEST(cmb_style_cd의 개체를 완전히 dispose시키고 다시한번해보기)
				dt_list = MyOraDB.Select_OBS_Style(cmb_Factory.SelectedValue.ToString(),cmb_OBS_ID.Text , cmb_OBS_Type.SelectedValue.ToString()," " );

				if ((dt_list  == null) || (dt_list.Rows.Count  == 0))   {cmb_Style_Cd.DataSource = null; return;}
				COM.ComCtl.Set_ComboList(dt_list, cmb_Style_Cd , 0, 1, true,70,150);
				//ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Style_Cd , 0, 1, false)
				//ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Style_Cd, 0, 1,  true);		
				//ClassLib.ComCtl.Set_ComboList_AddItem(dt_list, cmb_Style_Cd, 0, 1, true, 70,150);	
				
				//cmb_Style_Cd.Splits[0].DisplayColumns["Code"].Width = 70;
				//cmb_Style_Cd.Splits[0].DisplayColumns["Name"].Width = 150-25;//스크롤 방지

				//if (cmb_Style_Cd = 
				//cmb_Style_Cd.SelectedIndex = -1;
				
				


			}
			catch(Exception ex)
			{

				ClassLib.ComFunction.User_Message(ex.ToString(),"btn_OBS_ID_Click()",MessageBoxButtons.OK , MessageBoxIcon.Error);

			}
		}


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{

			if  (Check_Cancel() != true)
			{
		
				ClassLib.ComFunction.User_Message ("[Impossible ]"  +"\r\n"+  
                                                   "Case 1.There is aready applied in plan" +"\r\n"+   
												   "Case 2.There is unconfirmed adjust" +"\r\n"+   
												   "Case 3.Higher adjust no is existed" +"\r\n"+  
												   "Case 4.Select adjust number", "btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;

			}
			
			Set_Pop_OA_Cancel();


		}




		private void cmb_OA_Nu_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
			try
			{
				Set_Clear(_OANumberChange);

				if ((cmb_OA_Nu.SelectedValue.ToString()  == null) || (cmb_OA_Nu.SelectedValue.ToString() == "")) 
				{
					_OANumber = "";
					return;
				}


			
				

				Set_OA_List(cmb_Factory.SelectedValue.ToString(), cmb_OA_Nu.SelectedValue.ToString());

				if (cmb_OA_Nu.Columns[1].Text.Substring(0,1) ==ClassLib.ComVar.ConsCFM_C)
					Set_Enable(ClassLib.ComVar.ConsCFM_C);
				else if  (cmb_OA_Nu.Columns[1].Text.Substring(0,1) ==ClassLib.ComVar.ConsCFM_R)
					Set_Enable(ClassLib.ComVar.ConsCFM_R);
				else
					Set_Enable(ClassLib.ComVar.ConsCFM_P);
					
                
			   


				_OANumber   = cmb_OA_Nu.SelectedValue.ToString();
				
			}
			catch//(Exception ex)
			{
				this.Cursor = Cursors.Default;
				//ClassLib.ComFunction.User_Message(ex.ToString(), "cmb_OA_Nu_TextChanged()", MessageBoxButtons.OK, MessageBoxIcon.Error);
								
			}	
			finally
			{

				this.Cursor = Cursors.Default;
			}
		}

	


		#endregion 

		#region 콘텍스트 및 팝업메뉴
		
		
		private void mnt_ClearAll_Click(object sender, System.EventArgs e)
		{
			AddFlow.Nodes.Clear();
			
		}


		private void mnt_Delete_Click(object sender, System.EventArgs e)
		{
			try
			{



				this.Cursor = Cursors.WaitCursor ;

				#region 작업전 검증 사항

				
				if (Check_OA_Apply() == false)  
				{
					ClassLib.ComFunction.User_Message("Order Adjust is not applied at this style","mnt_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
					return;


				}



				if (Check_Order_Receive() == false)  
				{
					ClassLib.ComFunction.User_Message("Order Receive is not applied at this style","mnt_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
					return;


				}


				
               //Request가 안된것은 .D플래그 불가
				if ((fgrid_Order[fgrid_Order.Selection.r1,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxREQ_YN].ToString() == ClassLib.ComVar.ConsReal_N))
				{
					ClassLib.ComFunction.User_Message("[Wrong job flag] " + "\r\n" + 
						"01.Unrequested order is not made by flag -D" , "mnt_Delete_Click()", MessageBoxButtons.OK , MessageBoxIcon.Error );
			
					return ;
				}





				if ((fgrid_Order[fgrid_Order.Selection.r1,0].ToString() == "D") || (fgrid_Order[fgrid_Order.Selection.r1,0].ToString() == "I") ||
					 (fgrid_Order[fgrid_Order.Selection.r1,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxOA_NU_BEF].ToString() != "__________"))
				{

					ClassLib.ComFunction.User_Message("Duplication Selection","mnt_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
					return;
				}



				if (Convert.ToInt32(fgrid_Order[fgrid_Order.Selection.r1, (int)ClassLib.TBSEM_OBS_OA_CREATE01.lxTOT_QTY].ToString()) == 0 ) 
				{

					ClassLib.ComFunction.User_Message("Zero Quantity is impossible to set here", "mnt_Insert_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}





				#endregion 


				fgrid_Order.GetCellRange(fgrid_Order.Selection.r1, 0, fgrid_Order.Selection.r1,fgrid_Order.Cols.Count -1).StyleNew.ForeColor  =ClassLib.ComVar.Clr_Text_Red;
				fgrid_Order[fgrid_Order.Selection.r1,0] = "D";


				
				Set_Node_Top("D",fgrid_Order.Selection.r1 );
				Drow_Order_Flag(_BaseLeft_D,_NodeTop_D ,_BaseWidth ,_BaseHeight ,fgrid_Order.Selection.r1,"D" );
				
				
				//Set_Balacne(); 
				//addflow 링크 먼져 건다.  Link가 연결된것끼리 oa_rel_flag를 강제로 동일하게 소문자 a, b, c, d, e, f의 순으로 세팅하고 
				//그리고 링크가 변경될때 마다 balance설정하기
				//1.AddFlow를 읽는다.
				//  Balance Sheet에 그려준다.
				//3.이것은 addflow의 link 혹은 node가 변경될때 마다 다시 그려준다....즉 하나의 모둘로 구성할것... 
				//3.fgrid_balance에서는 가상의 oa_flag + oa_rel_flag 를 기준으로 subtotal할수 있게 처리한다.




			
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "mnt_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 

			}

		}


		private void mnt_Insert_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				this.Cursor = Cursors.WaitCursor ;

				#region 작업전 검증 사항

				if (Check_OA_Apply() == false)  
				{
					ClassLib.ComFunction.User_Message("Order Adjust is not applied at this style","mnt_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
					return;


				}


				if (Check_Order_Receive() == false)  
				{
					ClassLib.ComFunction.User_Message("Order Receive is not applied at this style","mnt_Insert_Click", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
					return;


				}

				
				if ((fgrid_Order[fgrid_Order.Selection.r1,0].ToString() == "D") || (fgrid_Order[fgrid_Order.Selection.r1,0].ToString() == "I") ||
					 (fgrid_Order[fgrid_Order.Selection.r1,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxOA_NU_AFT].ToString() != "__________"))
				{

					ClassLib.ComFunction.User_Message("Duplication Selection","mnt_Insert_Click", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
					return;
				}

				if (fgrid_Order[fgrid_Order.Selection.r1,(int)ClassLib.TBSEM_OBS_OA_CREATE01.lxREQ_YN].ToString() == ClassLib.ComVar.ConsReal_Y)
				{

					ClassLib.ComFunction.User_Message("This order  was requested..","mnt_Insert_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}


//				if (Convert.ToInt32(fgrid_Order[fgrid_Order.Selection.r1, (int)ClassLib.TBSEM_OBS_OA_CREATE01.lxTOT_QTY].ToString()) == 0 ) 
//				{
//
//					ClassLib.ComFunction.User_Message("Zero Quantity is impossible to set here", "mnt_Insert_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
//					return;
//				}
//


				#endregion 




				fgrid_Order.GetCellRange(fgrid_Order.Selection.r1, 0, fgrid_Order.Selection.r1,fgrid_Order.Cols.Count -1).StyleNew.ForeColor  =ClassLib.ComVar.Clr_Text_SeaBlue;
				fgrid_Order[fgrid_Order.Selection.r1,0] = "I";


				Set_Node_Top("I", fgrid_Order.Selection.r1 );
				Drow_Order_Flag(_BaseLeft_I,_NodeTop_I ,_BaseWidth ,_BaseHeight ,fgrid_Order.Selection.r1,"I" );

			

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "mnt_Insert_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 

			}




		}


//		private void mnt_Cancel_Click(object sender, System.EventArgs e)
//		{
//
//			try
//			{
//				this.Cursor = Cursors.WaitCursor ;
//
//
//				Set_Node_Top("C", fgrid_Order.Selection.r1 );
//				Drow_Order_Flag(_BaseLeft_I,_NodeTop_I ,_BaseWidth ,_BaseHeight ,fgrid_Order.Selection.r1,"C");
//
//			}
//			catch (Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "mnt_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			}
//			finally
//			{
//				this.Cursor = Cursors.Default; 
//
//			}
//
//			
//
//
//		}
//
//
//		private void mnt_Cancel_All_Click(object sender, System.EventArgs e)
//		{
//			
//			try
//			{
//				this.Cursor = Cursors.WaitCursor ;
//
//				for(int i =fgrid_Balance.Rows.Fixed ;  i < fgrid_Balance.Rows.Count   ;i++)
//				{
//
//					Set_Node_Top("C",i);
//				}
//
//
//				AddFlow.Items.Clear();
//				fgrid_Balance.Rows.Count  = fgrid_Balance.Rows.Fixed;
//
//			}
//			catch (Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "mnt_Cancel_All_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			}
//			finally
//			{
//				this.Cursor = Cursors.Default; 
//
//			}
//
//		
//		}


		private void  Set_Pop_Order_Size(string arg_obs_nu, string arg_obs_seq_nu, string chg_nu)
		{
			FlexOrder.ExpOA.Pop_OA_Order_Size  pop_form = new ExpOA.Pop_OA_Order_Size();

			COM.ComVar.Parameter_PopUp = new string[] 
			{
				cmb_Factory.SelectedValue.ToString(),
				cmb_OBS_Type.SelectedValue.ToString(),
				cmb_OBS_ID.Text,				
				cmb_Style_Cd.SelectedValue.ToString(),
				arg_obs_nu,
				arg_obs_seq_nu,
				chg_nu,
			
			};
					
			pop_form.ShowDialog();


		}



		
		private void  Set_Pop_OA_Confirm()
		{
			try
			{

				this.Cursor = Cursors.WaitCursor;			

				FlexOrder.ExpOA.Form_OA_Create_Confirm  pop_form = new ExpOA.Form_OA_Create_Confirm();
				COM.ComVar.Parameter_PopUp = new string[] 
				{
					cmb_Factory.SelectedValue.ToString(),
					cmb_OBS_ID.Text,
					cmb_OBS_Type.SelectedValue.ToString(),
					cmb_Style_Cd.SelectedValue.ToString(),
					ClassLib.ComVar.ConsCFM_R,
					_OANumber
				};
				 
				pop_form.ShowDialog();

				
				#region OA정보 다시 설정
				cmb_OA_Nu.ClearItems();

				DataTable  dt_list;
				dt_list = MyOraDB.Select_Create_OA_Nu(cmb_Factory.SelectedValue.ToString(), cmb_OBS_ID.Text ,cmb_OBS_Type.SelectedValue.ToString(),
					cmb_Style_Cd.SelectedValue.ToString());		
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OA_Nu , 0, 1, true,70,150);		
				cmb_OA_Nu.SelectedValue  = _OANumber;


				//Set_Clear(_OANumberChange);

				#endregion 


				this.Cursor = Cursors.Default;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "Set_Pop_OA_Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			finally
			{

			}


		}

		private void  Set_Pop_OA_Cancel()
		{
			this.Cursor = Cursors.WaitCursor;


			FlexOrder.ExpOA.Form_OA_Create_Cancel  pop_form = new ExpOA.Form_OA_Create_Cancel();
			COM.ComVar.Parameter_PopUp = new string[] 
			{
				cmb_Factory.SelectedValue.ToString(),
				cmb_OBS_ID.Text,
				cmb_OBS_Type.SelectedValue.ToString(),
				cmb_Style_Cd.SelectedValue.ToString(),
				ClassLib.ComVar.ConsCFM_C,
				_OANumber
			};
			 
			pop_form.ShowDialog();



			#region OA정보 다시 설정

			cmb_OA_Nu.ClearItems();

			DataTable  dt_list;
			dt_list = MyOraDB.Select_Create_OA_Nu(cmb_Factory.SelectedValue.ToString(), cmb_OBS_ID.Text ,cmb_OBS_Type.SelectedValue.ToString(),
				cmb_Style_Cd.SelectedValue.ToString());		
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OA_Nu , 0, 1, true,70,150);		
			cmb_OA_Nu.SelectedValue  ="";

			#endregion 

			
		
            //OBS 정보 다시 설정..//
			dt_list  = Select_Obs_List();
			fgrid_Order.Display_Grid(dt_list, true); 


			this.Cursor = Cursors.Default;

		}



		#endregion 

		private void Form_OA_Create_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}


	}
}

