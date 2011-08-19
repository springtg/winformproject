using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

namespace FlexPurchase.Quality
{
	public class Pop_QC_Result_List : COM.PCHWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_DeSelectAll;
		private System.Windows.Forms.ContextMenu cmenu_Barcode;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.DateTimePicker dpick_labYmd;
		private System.Windows.Forms.Label lbl_labYmd;
		private C1.Win.C1List.C1Combo cmb_mcsNo;
		private C1.Win.C1List.C1Combo cmb_labCompCd;
		private System.Windows.Forms.Label lbl_labCompCd;
		private System.Windows.Forms.Label lbl_mcsNo;
		private System.Windows.Forms.TextBox txt_mcsNo;
		private System.Windows.Forms.Label lbl_con;
		private System.Windows.Forms.Label lbl_remark;
		private System.Windows.Forms.TextBox txt_remark;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.TextBox txt_labNo;
		private C1.Win.C1List.C1Combo cmb_result;
		private System.Windows.Forms.TextBox txt_reqNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_labSeq;
		private System.Windows.Forms.Label lbl_reqNo;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.TextBox txt_reqSeq;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();

		//메인창으로 리턴될 데이터 테이블
		public DataTable _DT;  
		private bool _vConfirmYn	= false; 
		private bool _isAccessible  = true;
		private bool _isInitSet		= false;

		private string _vLabNo  = ""; 
		private string _vLabSeq = "";

		private int _lxLabNoCol			= (int)ClassLib.TBSQL_LAB_TEST.IxLAB_NO;
		private int _lxLabSeqCol		= (int)ClassLib.TBSQL_LAB_TEST.IxLAB_SEQ;
		private int _lxMcsNoCol			= (int)ClassLib.TBSQL_LAB_TEST.IxMCS_NO;
		private int _lxLabCompCdCol		= (int)ClassLib.TBSQL_LAB_TEST.IxLAB_COMP_CD;
		private int _lxResultCol		= (int)ClassLib.TBSQL_LAB_TEST.IxRESULT;
		private int _lxRemarksCol		= (int)ClassLib.TBSQL_LAB_TEST.IxREMARKS;
		private int _lxStatusCol		= (int)ClassLib.TBSQL_LAB_TEST.IxSTATUS;
//		private int _lxFactoryCol		= (int)ClassLib.TBSQL_LAB_TEST.IxFACTORY;
//		private int _lxLabYmdCol		= (int)ClassLib.TBSQL_LAB_TEST.IxLAB_YMD;
//		private int _lxTestCdCol		= (int)ClassLib.TBSQL_LAB_TEST.IxTEST_CD;
//		private int _lxTestNameCol		= (int)ClassLib.TBSQL_LAB_TEST.IxTEST_NAME;
//		private int _lxUnitCol			= (int)ClassLib.TBSQL_LAB_TEST.IxUNIT;
//		private int _lxResultValueCol	= (int)ClassLib.TBSQL_LAB_TEST.IxRESULT_VALUE;
//		private int _lxResultSaltCol	= (int)ClassLib.TBSQL_LAB_TEST.IxRESULT_SALT;
//		private int _lxResultWaterCol	= (int)ClassLib.TBSQL_LAB_TEST.IxRESULT_WATER;
//		private int _lxSpecMinCol		= (int)ClassLib.TBSQL_LAB_TEST.IxSEPC_MIN;
//		private int _lxSpecMaxCol		= (int)ClassLib.TBSQL_LAB_TEST.IxSPEC_MAX;
//		private int _lxMethodCol		= (int)ClassLib.TBSQL_LAB_TEST.IxMETHOD;
//		private int _lxReqNoCol			= (int)ClassLib.TBSQL_LAB_TEST.IxREQ_NO;
//		private int _lxReqSeqCol		= (int)ClassLib.TBSQL_LAB_TEST.IxREQ_SEQ;
//		private int _lxUpdUserCol		= (int)ClassLib.TBSQL_LAB_TEST.IxUPD_USER;
//		private int _lxUpdYmdCol		= (int)ClassLib.TBSQL_LAB_TEST.IxUPD_YMD;

		#endregion
		
		#region 생성자 / 소멸자
		public Pop_QC_Result_List()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_QC_Result_List));
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style49 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style50 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style51 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style52 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style53 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style54 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style55 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style56 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.lbl_con = new System.Windows.Forms.Label();
            this.lbl_remark = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_reqSeq = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.lbl_reqNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_reqNo = new System.Windows.Forms.TextBox();
            this.txt_labSeq = new System.Windows.Forms.TextBox();
            this.txt_labNo = new System.Windows.Forms.TextBox();
            this.lbl_labCompCd = new System.Windows.Forms.Label();
            this.lbl_mcsNo = new System.Windows.Forms.Label();
            this.txt_mcsNo = new System.Windows.Forms.TextBox();
            this.dpick_labYmd = new System.Windows.Forms.DateTimePicker();
            this.lbl_labYmd = new System.Windows.Forms.Label();
            this.fgrid_main = new COM.FSP();
            this.cmb_result = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.cmb_mcsNo = new C1.Win.C1List.C1Combo();
            this.cmb_labCompCd = new C1.Win.C1List.C1Combo();
            this.cmenu_Barcode = new System.Windows.Forms.ContextMenu();
            this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
            this.menuitem_DeSelectAll = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_mcsNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_labCompCd)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(609, 4);
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
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(832, 23);
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // tbtn_Conform
            // 
            this.tbtn_Conform.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.GridDefinition = "98.4:False:False;\t98.989898989899:False:False;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(792, 500);
            this.c1Sizer1.TabIndex = 25;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Controls.Add(this.lbl_con);
            this.pnl_menu.Controls.Add(this.lbl_remark);
            this.pnl_menu.Controls.Add(this.txt_remark);
            this.pnl_menu.Location = new System.Drawing.Point(12, 443);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(872, 53);
            this.pnl_menu.TabIndex = 174;
            // 
            // lbl_con
            // 
            this.lbl_con.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_con.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_con.ImageIndex = 0;
            this.lbl_con.ImageList = this.img_Label;
            this.lbl_con.Location = new System.Drawing.Point(8, 6);
            this.lbl_con.Name = "lbl_con";
            this.lbl_con.Size = new System.Drawing.Size(100, 21);
            this.lbl_con.TabIndex = 556;
            this.lbl_con.Text = "Condemnation";
            this.lbl_con.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_remark
            // 
            this.lbl_remark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_remark.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remark.ImageIndex = 0;
            this.lbl_remark.ImageList = this.img_Label;
            this.lbl_remark.Location = new System.Drawing.Point(8, 28);
            this.lbl_remark.Name = "lbl_remark";
            this.lbl_remark.Size = new System.Drawing.Size(100, 21);
            this.lbl_remark.TabIndex = 555;
            this.lbl_remark.Text = "Remark";
            this.lbl_remark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_remark
            // 
            this.txt_remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remark.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_remark.Location = new System.Drawing.Point(112, 28);
            this.txt_remark.MaxLength = 200;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(648, 21);
            this.txt_remark.TabIndex = 554;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_factory);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 84);
            this.panel1.TabIndex = 169;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 13);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 180;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_reqSeq);
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.lbl_reqNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_reqNo);
            this.groupBox1.Controls.Add(this.txt_labSeq);
            this.groupBox1.Controls.Add(this.txt_labNo);
            this.groupBox1.Controls.Add(this.lbl_labCompCd);
            this.groupBox1.Controls.Add(this.lbl_mcsNo);
            this.groupBox1.Controls.Add(this.txt_mcsNo);
            this.groupBox1.Controls.Add(this.dpick_labYmd);
            this.groupBox1.Controls.Add(this.lbl_labYmd);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 83);
            this.groupBox1.TabIndex = 381;
            this.groupBox1.TabStop = false;
            // 
            // txt_reqSeq
            // 
            this.txt_reqSeq.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_reqSeq.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_reqSeq.Location = new System.Drawing.Point(648, 8);
            this.txt_reqSeq.Name = "txt_reqSeq";
            this.txt_reqSeq.Size = new System.Drawing.Size(40, 21);
            this.txt_reqSeq.TabIndex = 566;
            this.txt_reqSeq.Visible = false;
            // 
            // txt_status
            // 
            this.txt_status.Enabled = false;
            this.txt_status.Location = new System.Drawing.Point(592, 57);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(168, 21);
            this.txt_status.TabIndex = 565;
            // 
            // lbl_reqNo
            // 
            this.lbl_reqNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqNo.ImageIndex = 1;
            this.lbl_reqNo.ImageList = this.img_Label;
            this.lbl_reqNo.Location = new System.Drawing.Point(296, 57);
            this.lbl_reqNo.Name = "lbl_reqNo";
            this.lbl_reqNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqNo.TabIndex = 564;
            this.lbl_reqNo.Text = "Request No";
            this.lbl_reqNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 1;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 563;
            this.label1.Text = "LAB No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_reqNo
            // 
            this.txt_reqNo.Enabled = false;
            this.txt_reqNo.Location = new System.Drawing.Point(400, 57);
            this.txt_reqNo.Name = "txt_reqNo";
            this.txt_reqNo.Size = new System.Drawing.Size(192, 21);
            this.txt_reqNo.TabIndex = 562;
            // 
            // txt_labSeq
            // 
            this.txt_labSeq.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_labSeq.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_labSeq.Location = new System.Drawing.Point(608, 8);
            this.txt_labSeq.Name = "txt_labSeq";
            this.txt_labSeq.Size = new System.Drawing.Size(40, 21);
            this.txt_labSeq.TabIndex = 561;
            this.txt_labSeq.Visible = false;
            // 
            // txt_labNo
            // 
            this.txt_labNo.Enabled = false;
            this.txt_labNo.Location = new System.Drawing.Point(112, 57);
            this.txt_labNo.Name = "txt_labNo";
            this.txt_labNo.Size = new System.Drawing.Size(168, 21);
            this.txt_labNo.TabIndex = 560;
            // 
            // lbl_labCompCd
            // 
            this.lbl_labCompCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_labCompCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_labCompCd.ImageIndex = 1;
            this.lbl_labCompCd.ImageList = this.img_Label;
            this.lbl_labCompCd.Location = new System.Drawing.Point(296, 13);
            this.lbl_labCompCd.Name = "lbl_labCompCd";
            this.lbl_labCompCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_labCompCd.TabIndex = 557;
            this.lbl_labCompCd.Text = "Component";
            this.lbl_labCompCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mcsNo
            // 
            this.lbl_mcsNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_mcsNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mcsNo.ImageIndex = 1;
            this.lbl_mcsNo.ImageList = this.img_Label;
            this.lbl_mcsNo.Location = new System.Drawing.Point(296, 35);
            this.lbl_mcsNo.Name = "lbl_mcsNo";
            this.lbl_mcsNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_mcsNo.TabIndex = 556;
            this.lbl_mcsNo.Text = "MCS No";
            this.lbl_mcsNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_mcsNo
            // 
            this.txt_mcsNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mcsNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_mcsNo.Location = new System.Drawing.Point(400, 35);
            this.txt_mcsNo.MaxLength = 10;
            this.txt_mcsNo.Name = "txt_mcsNo";
            this.txt_mcsNo.Size = new System.Drawing.Size(88, 21);
            this.txt_mcsNo.TabIndex = 555;
            this.txt_mcsNo.TextChanged += new System.EventHandler(this.txt_mcsNo_TextChanged);
            this.txt_mcsNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mcsNo_KeyPress);
            // 
            // dpick_labYmd
            // 
            this.dpick_labYmd.CustomFormat = "";
            this.dpick_labYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_labYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_labYmd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_labYmd.Location = new System.Drawing.Point(112, 35);
            this.dpick_labYmd.Name = "dpick_labYmd";
            this.dpick_labYmd.Size = new System.Drawing.Size(168, 21);
            this.dpick_labYmd.TabIndex = 383;
            // 
            // lbl_labYmd
            // 
            this.lbl_labYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_labYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_labYmd.ImageIndex = 1;
            this.lbl_labYmd.ImageList = this.img_Label;
            this.lbl_labYmd.Location = new System.Drawing.Point(8, 35);
            this.lbl_labYmd.Name = "lbl_labYmd";
            this.lbl_labYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_labYmd.TabIndex = 382;
            this.lbl_labYmd.Text = "LAB Date";
            this.lbl_labYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(12, 92);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(768, 347);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 175;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // cmb_result
            // 
            this.cmb_result.AddItemCols = 0;
            this.cmb_result.AddItemSeparator = ';';
            this.cmb_result.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_result.Caption = "";
            this.cmb_result.CaptionHeight = 17;
            this.cmb_result.CaptionStyle = style33;
            this.cmb_result.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_result.ColumnCaptionHeight = 18;
            this.cmb_result.ColumnFooterHeight = 18;
            this.cmb_result.ContentHeight = 16;
            this.cmb_result.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_result.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_result.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_result.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_result.EditorHeight = 16;
            this.cmb_result.EvenRowStyle = style34;
            this.cmb_result.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_result.FooterStyle = style35;
            this.cmb_result.GapHeight = 2;
            this.cmb_result.HeadingStyle = style36;
            this.cmb_result.HighLightRowStyle = style37;
            this.cmb_result.ItemHeight = 15;
            this.cmb_result.Location = new System.Drawing.Point(112, 6);
            this.cmb_result.MatchEntryTimeout = ((long)(2000));
            this.cmb_result.MaxDropDownItems = ((short)(5));
            this.cmb_result.MaxLength = 32767;
            this.cmb_result.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_result.Name = "cmb_result";
            this.cmb_result.OddRowStyle = style38;
            this.cmb_result.PartialRightColumn = false;
            this.cmb_result.PropBag = resources.GetString("cmb_result.PropBag");
            this.cmb_result.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_result.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_result.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_result.SelectedStyle = style39;
            this.cmb_result.Size = new System.Drawing.Size(192, 22);
            this.cmb_result.Style = style40;
            this.cmb_result.TabIndex = 557;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style41;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ContentHeight = 16;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 16;
            this.cmb_factory.EvenRowStyle = style42;
            this.cmb_factory.FooterStyle = style43;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style44;
            this.cmb_factory.HighLightRowStyle = style45;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(0, 0);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style46;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style47;
            this.cmb_factory.Size = new System.Drawing.Size(121, 22);
            this.cmb_factory.Style = style48;
            this.cmb_factory.TabIndex = 0;
            // 
            // cmb_mcsNo
            // 
            this.cmb_mcsNo.AddItemCols = 0;
            this.cmb_mcsNo.AddItemSeparator = ';';
            this.cmb_mcsNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_mcsNo.Caption = "";
            this.cmb_mcsNo.CaptionHeight = 17;
            this.cmb_mcsNo.CaptionStyle = style49;
            this.cmb_mcsNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_mcsNo.ColumnCaptionHeight = 18;
            this.cmb_mcsNo.ColumnFooterHeight = 18;
            this.cmb_mcsNo.ContentHeight = 16;
            this.cmb_mcsNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_mcsNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_mcsNo.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_mcsNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_mcsNo.EditorHeight = 16;
            this.cmb_mcsNo.EvenRowStyle = style50;
            this.cmb_mcsNo.FooterStyle = style51;
            this.cmb_mcsNo.GapHeight = 2;
            this.cmb_mcsNo.HeadingStyle = style52;
            this.cmb_mcsNo.HighLightRowStyle = style53;
            this.cmb_mcsNo.ItemHeight = 15;
            this.cmb_mcsNo.Location = new System.Drawing.Point(0, 0);
            this.cmb_mcsNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_mcsNo.MaxDropDownItems = ((short)(5));
            this.cmb_mcsNo.MaxLength = 32767;
            this.cmb_mcsNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_mcsNo.Name = "cmb_mcsNo";
            this.cmb_mcsNo.OddRowStyle = style54;
            this.cmb_mcsNo.PartialRightColumn = false;
            this.cmb_mcsNo.PropBag = resources.GetString("cmb_mcsNo.PropBag");
            this.cmb_mcsNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_mcsNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_mcsNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_mcsNo.SelectedStyle = style55;
            this.cmb_mcsNo.Size = new System.Drawing.Size(121, 22);
            this.cmb_mcsNo.Style = style56;
            this.cmb_mcsNo.TabIndex = 0;
            // 
            // cmb_labCompCd
            // 
            this.cmb_labCompCd.AddItemCols = 0;
            this.cmb_labCompCd.AddItemSeparator = ';';
            this.cmb_labCompCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_labCompCd.Caption = "";
            this.cmb_labCompCd.CaptionHeight = 17;
            this.cmb_labCompCd.CaptionStyle = style57;
            this.cmb_labCompCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_labCompCd.ColumnCaptionHeight = 18;
            this.cmb_labCompCd.ColumnFooterHeight = 18;
            this.cmb_labCompCd.ContentHeight = 16;
            this.cmb_labCompCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_labCompCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_labCompCd.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_labCompCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_labCompCd.EditorHeight = 16;
            this.cmb_labCompCd.EvenRowStyle = style58;
            this.cmb_labCompCd.FooterStyle = style59;
            this.cmb_labCompCd.GapHeight = 2;
            this.cmb_labCompCd.HeadingStyle = style60;
            this.cmb_labCompCd.HighLightRowStyle = style61;
            this.cmb_labCompCd.ItemHeight = 15;
            this.cmb_labCompCd.Location = new System.Drawing.Point(0, 0);
            this.cmb_labCompCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_labCompCd.MaxDropDownItems = ((short)(5));
            this.cmb_labCompCd.MaxLength = 32767;
            this.cmb_labCompCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_labCompCd.Name = "cmb_labCompCd";
            this.cmb_labCompCd.OddRowStyle = style62;
            this.cmb_labCompCd.PartialRightColumn = false;
            this.cmb_labCompCd.PropBag = resources.GetString("cmb_labCompCd.PropBag");
            this.cmb_labCompCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_labCompCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_labCompCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_labCompCd.SelectedStyle = style63;
            this.cmb_labCompCd.Size = new System.Drawing.Size(121, 22);
            this.cmb_labCompCd.Style = style64;
            this.cmb_labCompCd.TabIndex = 0;
            // 
            // menuitem_SelectAll
            // 
            this.menuitem_SelectAll.Index = -1;
            this.menuitem_SelectAll.Text = "";
            // 
            // menuitem_DeSelectAll
            // 
            this.menuitem_DeSelectAll.Index = -1;
            this.menuitem_DeSelectAll.Text = "";
            // 
            // Pop_QC_Result_List
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 558);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_QC_Result_List";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_QC_Result_List_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_mcsNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_labCompCd)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void Grid_AfterEditProcess()
		{
			fgrid_main.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		private void Pop_QC_Result_List_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				COM.ComVar.Parameter_PopUp		= new string[3];

				COM.ComVar.Parameter_PopUp[0]	= fgrid_main[fgrid_main.Rows.Fixed, _lxLabNoCol].ToString();
				COM.ComVar.Parameter_PopUp[1]	= fgrid_main[fgrid_main.Rows.Fixed, _lxLabSeqCol].ToString();
				COM.ComVar.Parameter_PopUp[2]	= txt_status.Text.Substring(0,1);

				string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp != null && vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{ 
			this.Tbtn_SearchProcess(false);
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
				this.Tbtn_SaveProcess(true);
		}						

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_DeleteProcess();
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(_vConfirmYn) 
				this.Tbtn_ConfirmCancelProcess();
			else
				this.Tbtn_ConfirmProcess();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess(); 
		}

		private void txt_mcsNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
			{
				txt_mcsNo.Text	= txt_mcsNo.Text.ToString().ToUpper();
				this.Txt_McsNoTextChangedProcess();
				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
			}
		}

		private void txt_mcsNo_TextChanged(object sender, System.EventArgs e)
		{
			if(_isInitSet)
			{
				txt_mcsNo.Text	= txt_mcsNo.Text.ToString().ToUpper();
				this.Txt_McsNoTextChangedProcess();
			}
		}

		private void Txt_McsNoTextChangedProcess()
		{
			try
			{
				_isAccessible = false;
				DataTable vDt = new DataTable();
				vDt = ClassLib.ComFunction.SELECT_SBC_MCS_LIST(COM.ComVar.This_Factory, txt_mcsNo.Text.ToString().Trim());
				COM.ComCtl.Set_ComboList(vDt, cmb_mcsNo, 0, 1, true, 88, 256);

				if (vDt.Rows.Count > 0 && vDt.Rows.Count < 2)
					cmb_mcsNo.SelectedIndex = 1; 
				else if (vDt == null || vDt.Rows.Count <= 0) 
					cmb_mcsNo.SelectedIndex = 0; 

				vDt.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				_isAccessible = true;
			}
		}

		private void cmb_mcsNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_McsNoSelectedValueChangedProcess();
		}

		private void Cmb_McsNoSelectedValueChangedProcess()
		{
			try
			{
				if (_isAccessible)
				{
					txt_mcsNo.Text				= cmb_mcsNo.SelectedValue.ToString();
					cmb_mcsNo.SelectedValue		= txt_mcsNo.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#region 입력이동

		#endregion

		#region 버튼효과

		#endregion

		#region 롤오버 이미지 처리

		#endregion

		#endregion

		#region 공통 메서드

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
            //			ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Inspection Request List";
            this.Text = "Inspection Request";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			fgrid_main.Set_Grid("SQL_LAB_TEST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			//			cmb_factory.SelectedIndex = 0;
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
	
			// LAB Component Cd set    cmb_labCompCd
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SQC01");
			COM.ComCtl.Set_ComboList(vDt, cmb_labCompCd, 1, 2, true, 56,0);
			vDt.Dispose();
			cmb_labCompCd.SelectedIndex = -1;

			// condemnation set    cmb_result
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SQC03");
			COM.ComCtl.Set_ComboList(vDt, cmb_result, 1, 2, true, 56,0);
			vDt.Dispose();
			cmb_result.SelectedIndex = -1;

			if (COM.ComVar.Parameter_PopUp != null)
			{
				if (COM.ComVar.Parameter_PopUp[0].ToString() == " ")
					cmb_factory.SelectedIndex	= 0; 
				else
					cmb_factory.SelectedValue = COM.ComVar.Parameter_PopUp[0].ToString();	
				txt_labNo.Text				= COM.ComVar.Parameter_PopUp[1].ToString(); 
				txt_labSeq.Text				= COM.ComVar.Parameter_PopUp[2].ToString(); 
				txt_reqNo.Text				= COM.ComVar.Parameter_PopUp[3].ToString(); 
				txt_reqSeq.Text				= COM.ComVar.Parameter_PopUp[4].ToString(); 

				COM.ComVar.Parameter_PopUp	= null; 

				this.Tbtn_SearchProcess(true); 
			}

			// Disabled tbutton
			tbtn_Create.Enabled		= false;
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();

				this.txt_mcsNo.Text					= "";
				this.txt_remark.Text				= "";
				this.txt_labNo.Text					= ""; 
				this.txt_labSeq.Text				= "";
				this.txt_reqNo.Text					= "";
				this.cmb_mcsNo.SelectedIndex		= -1;
				this.cmb_result.SelectedIndex	= -1; 
				this.cmb_labCompCd.SelectedIndex	= -1; 

				tbtn_Save.Enabled		= true;
				tbtn_Delete.Enabled		= true;
				tbtn_Conform.Enabled	= false;
				fgrid_main.AllowEditing	= true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}


		private void Tbtn_SearchProcess(bool arg_bool)
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory, cmb_labCompCd, cmb_mcsNo}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if ((arg_bool) || FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					this.Cursor = Cursors.WaitCursor;

					string vFactory		= COM.ComFunction.Empty_Combo(cmb_factory, "");
					string vLabNo		= COM.ComFunction.Empty_TextBox(txt_labNo, "");  
					string vLabSeq		= COM.ComFunction.Empty_TextBox(txt_labSeq, "");  
					string vMcsNo		= COM.ComFunction.Empty_Combo(cmb_mcsNo, ""); 
					string vLabCompCd	= COM.ComFunction.Empty_Combo(cmb_labCompCd, ""); 

					this.tbtn_Conform.Enabled	= false; 
					dpick_labYmd.Enabled		= true; 
					txt_mcsNo.Enabled			= true;	
					cmb_mcsNo.Enabled			= true;
					cmb_labCompCd.Enabled		= true; 
					cmb_result.Enabled			= true;
					txt_remark.Enabled			= true; 
					_vLabNo			= ""; 
					_vLabSeq		= ""; 

					if (!arg_bool || (vLabNo != "" && vLabNo != null))
					{
						DataTable vTemp = SELECT_SQL_LAB_TEST_RESULT(vFactory, vLabNo, vLabSeq, vMcsNo, vLabCompCd);
					
						if (vTemp.Rows.Count > 0)
						{
							ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_main, vTemp);

							if (fgrid_main[fgrid_main.Rows.Fixed, _lxLabNoCol] != null && fgrid_main[fgrid_main.Rows.Fixed, _lxLabNoCol].ToString() != "")
							{
								txt_labNo.Text	= fgrid_main[fgrid_main.Rows.Fixed, _lxLabNoCol].ToString(); 
								txt_labSeq.Text	= fgrid_main[fgrid_main.Rows.Fixed, _lxLabSeqCol].ToString(); 
								_vLabNo			= txt_labNo.Text.Trim(); 
								_vLabSeq		= txt_labSeq.Text.Trim(); 
								
								txt_status.Text = fgrid_main[fgrid_main.Rows.Fixed, _lxStatusCol].ToString();
								if (txt_status.Text.Trim() == "Commit")
								{
									_vConfirmYn				= true;
									tbtn_Save.Enabled		= false;
									tbtn_Delete.Enabled		= false;
									tbtn_Conform.Enabled	= true;
									fgrid_main.AllowEditing	= false;
									cmb_result.Enabled		= false;
									txt_remark.Enabled		= false; 
								}
								else
								{
									_vConfirmYn	= false;
									tbtn_Save.Enabled		= true;
									tbtn_Delete.Enabled		= true;
									tbtn_Conform.Enabled	= true;
									fgrid_main.AllowEditing	= true;
									cmb_result.Enabled		= true;
									txt_remark.Enabled		= true; 
								}

								_isInitSet		= true; 
								txt_mcsNo.Text				= fgrid_main[fgrid_main.Rows.Fixed, _lxMcsNoCol].ToString(); 
								_isInitSet		= false; 

								cmb_mcsNo.SelectedValue		= txt_mcsNo.Text.Trim(); 
								cmb_labCompCd.SelectedValue	= fgrid_main[fgrid_main.Rows.Fixed, _lxLabCompCdCol].ToString(); 
								cmb_result.SelectedValue	= fgrid_main[fgrid_main.Rows.Fixed, _lxResultCol].ToString(); 
								txt_remark.Text				= fgrid_main[fgrid_main.Rows.Fixed, _lxRemarksCol].ToString(); 

								dpick_labYmd.Enabled	= false; 						
								txt_mcsNo.Enabled		= false;	
								cmb_mcsNo.Enabled		= false;
								cmb_labCompCd.Enabled	= false; 

								this.tbtn_Conform.Enabled	= true; 
							}
							else
							{
								_vConfirmYn		= false;

								for (int  i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
								{
									fgrid_main[i, 0]	= ClassLib.ComVar.Insert; 
								}
							}

							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
						}
						else
						{
							fgrid_main.ClearAll();
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
						}		
					}
					else
					{
						fgrid_main.ClearAll();
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
					}		
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_SaveProcess(bool arg_bool)
		{
			try
			{ 
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory, cmb_labCompCd, cmb_mcsNo};
				System.Windows.Forms.TextBox[] txt_array = {txt_reqNo}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					DialogResult result = new DialogResult(); 

					if (arg_bool) 
					{	
						result = ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					}
					if ((!arg_bool) || result.ToString() == "Yes")
					{						
						fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1); 

						string vLabNo	= this.txt_labNo.Text.Trim(); 
						int	   vLabSeq	= 0; 
						if(txt_labSeq.Text != "")
							vLabSeq	= int.Parse(this.txt_labSeq.Text.Trim());

						if (vLabNo == "")
						{
							// LabNo Select 
							string vFactory		= COM.ComFunction.Empty_Combo(cmb_factory, "AL") == " " ? "AL" : COM.ComFunction.Empty_Combo(cmb_factory, "AL");
							string vDocDivision = ClassLib.ComVar.QC_TEST;
							string vDocType		= "00";
							string vDate		= System.DateTime.Today.ToString().Substring(0,10).Replace("-","");
							string vUser		= COM.ComVar.This_User;
						 
							DataTable vDt = ClassLib.ComFunction.SELECT_DOCUMENT_NO(vFactory, vDocDivision, vDocType, vDate, vUser);

							vLabNo  = vDt.Rows[0].ItemArray[0].ToString().Trim();
							vLabSeq	= int.Parse(vLabNo.Substring(12,4));
						}

						// HEAD 저장
						if (!SAVE_SQL_LAB_TEST_HEAD("", vLabNo, vLabSeq.ToString()))
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}

						if ( vLabNo != null && vLabNo != "" ) 
						{
							for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
							{
								fgrid_main[i, _lxLabNoCol]			= vLabNo;
								fgrid_main[i, _lxLabSeqCol]			= vLabSeq;
							}
						}
						 
						if (!MyOraDB.Save_FlexGird_Ready("PKG_SQL_LAB_TEST_TAIL.SAVE_SQL_LAB_TEST_TAIL", fgrid_main, false))
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}

						// 저장 완료
						if (MyOraDB.Exe_Modify_Procedure_all())
						{
							txt_labNo.Text	=  vLabNo; 
							txt_labSeq.Text	=  vLabSeq.ToString();
							txt_status.Text	= "Save";

							_vConfirmYn		= false;
							_vLabNo			=  vLabNo; 
							_vLabSeq		=  vLabSeq.ToString(); 
							tbtn_Conform.Enabled	= true;

							Tbtn_AfterSaveProcess();
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
						}
						else
							return;
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

		private void Tbtn_ConfirmProcess()
		{
			try
			{ 
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory, cmb_labCompCd, cmb_mcsNo, cmb_result}; 
				System.Windows.Forms.TextBox[] txt_array = {txt_labNo, txt_reqNo}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
					{
						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= 0 ; vRow--)
						{
							if (fgrid_main[vRow, 0] != null && fgrid_main[vRow, 0].ToString() != "")
							{
								Tbtn_SaveProcess(false); 
							}
						}		

						// HEAD 저장
						if (!SAVE_SQL_LAB_TEST_HEAD("C", _vLabNo, _vLabSeq))
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}
						// 저장 완료
						MyOraDB.Exe_Modify_Procedure();
					
						txt_status.Text			= "Commit";
						_vConfirmYn				= true;
						tbtn_Save.Enabled		= false;
						tbtn_Delete.Enabled		= false;
						tbtn_Conform.Enabled	= true;
						fgrid_main.AllowEditing	= false;

						cmb_result.Enabled		= false;
						txt_remark.Enabled		= false; 
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

		private void Tbtn_ConfirmCancelProcess()
		{
			try
			{ 
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory, cmb_labCompCd, cmb_mcsNo, cmb_result}; 
				System.Windows.Forms.TextBox[] txt_array = {txt_labNo, txt_reqNo}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you Cancel to Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
					{
						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= 0 ; vRow--)
						{
							if (fgrid_main[vRow, 0] != null && fgrid_main[vRow, 0].ToString() != "")
							{
								Tbtn_SaveProcess(false); 
							}
						}		

						// HEAD 저장
						if (!SAVE_SQL_LAB_TEST_HEAD("", _vLabNo, _vLabSeq))
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}

						// 저장 완료
						MyOraDB.Exe_Modify_Procedure();
													
						txt_status.Text			= "Save";
						_vConfirmYn				= false;
						tbtn_Save.Enabled		= true;
						tbtn_Delete.Enabled		= true;
						tbtn_Conform.Enabled	= true;
						fgrid_main.AllowEditing	= true;

						cmb_result.Enabled		= true;
						txt_remark.Enabled		= true; 
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

		private void Tbtn_DeleteProcess()
		{
			try
			{ 
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
				System.Windows.Forms.TextBox[] txt_array = {txt_labNo, txt_reqNo}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
					{
						// HEAD 저장
						if (!SAVE_SQL_LAB_TEST_HEAD("D", _vLabNo, _vLabSeq))
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}
						// 저장 완료
						MyOraDB.Exe_Modify_Procedure();
						this.Tbtn_NewProcess(); 
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

		private void Tbtn_AfterSaveProcess()
		{
			try
			{				
				if (cmb_factory.SelectedIndex > -1)
				{
					for(int i = fgrid_main.Rows.Count - 1; i >= fgrid_main.Rows.Fixed; i--)
					{
						if(fgrid_main[i,0] == null || fgrid_main[i, 0].ToString() == "") continue; 
							

						if( fgrid_main[i, 0].ToString() == "D" )
						{ 
							fgrid_main.Rows.Remove(i);
						}
						else
						{
							fgrid_main[i, 0] = "";
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}		

		private void Tbtn_PrintProcess()
		{
			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory, cmb_labCompCd, cmb_mcsNo}; 
			System.Windows.Forms.TextBox[] txt_array = {txt_labNo, txt_reqNo}; 

			if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
			{
				string sDir		= "";
				string sPara	= "";

				string vLabNo	= txt_labNo.Text; 
				
				if (vLabNo != null && vLabNo != "")
				{
					sDir   = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_QC_LAB_Test");
					sPara  = " /rp ";
					sPara += "['" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"'] ";
					sPara += "['" + vLabNo +		"'] ";
				}
				else
					return;

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

				MyReport.Text = "Lab Test sheet";
				MyReport.Show();			
			}
		}
			
		#endregion

		#region DB Connect
		/// <summary>
		/// PKG_SBO_OUT_TAIL : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBO_OUT_TAIL : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SQL_LAB_TEST_RESULT(string arg_factory, string arg_labNo,  string arg_labSeq, 
												    string arg_mcsNo,   string arg_labCompCd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SQL_LAB_TEST_TAIL.SELECT_SQL_LAB_TEST_RESULT";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LAB_NO";
			MyOraDB.Parameter_Name[2] = "ARG_LAB_SEQ";
			MyOraDB.Parameter_Name[3] = "ARG_MCS_NO";
			MyOraDB.Parameter_Name[4] = "ARG_LAB_COMP_CD";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_labNo;
			MyOraDB.Parameter_Values[2] = arg_labSeq;
			MyOraDB.Parameter_Values[3] = arg_mcsNo;
			MyOraDB.Parameter_Values[4] = arg_labCompCd;
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// SAVE_SQL_LAB_TEST_HEAD : 헤더 정보 저장
		/// </summary>
		public bool SAVE_SQL_LAB_TEST_HEAD(string arg_div, string arg_labNo, string arg_labSeq)
		{
			try
			{
				MyOraDB.ReDim_Parameter(13);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SQL_LAB_TEST_HEAD.SAVE_SQL_LAB_TEST_HEAD";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2]  = "ARG_LAB_NO";
				MyOraDB.Parameter_Name[3]  = "ARG_LAB_SEQ";
				MyOraDB.Parameter_Name[4]  = "ARG_LAB_COMP_CD";
				MyOraDB.Parameter_Name[5]  = "ARG_MCS_NO";
				MyOraDB.Parameter_Name[6]  = "ARG_LAB_YMD";
				MyOraDB.Parameter_Name[7]  = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[8]  = "ARG_REQ_SEQ";
				MyOraDB.Parameter_Name[9]  = "ARG_RESULT";
				MyOraDB.Parameter_Name[10] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[11] = "ARG_STATUS";
				MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;

				//04.DATA 정의
				if (arg_div == "D")
				{
					MyOraDB.Parameter_Values[0]  = "D";
					MyOraDB.Parameter_Values[11] = "S";
				}
				else if (arg_div == "C")
				{
					MyOraDB.Parameter_Values[0]  = "U";
					MyOraDB.Parameter_Values[11] = "C";
				}
				else
				{
					MyOraDB.Parameter_Values[0]  = txt_labNo.Text.Trim() == "" ? "I" : "U";
					MyOraDB.Parameter_Values[11] = "S";
				}

				MyOraDB.Parameter_Values[1]  = COM.ComFunction.Empty_Combo(cmb_factory, "ALL") == " " ? "ALL" : COM.ComFunction.Empty_Combo(cmb_factory, "ALL");
				MyOraDB.Parameter_Values[2]  = arg_labNo;
				MyOraDB.Parameter_Values[3]  = arg_labSeq;
				MyOraDB.Parameter_Values[4]  = COM.ComFunction.Empty_Combo(cmb_labCompCd, "");
				MyOraDB.Parameter_Values[5]  = COM.ComFunction.Empty_Combo(cmb_mcsNo, "");
				MyOraDB.Parameter_Values[6]  = dpick_labYmd.Text.Replace("-", "");
				MyOraDB.Parameter_Values[7]  = COM.ComFunction.Empty_TextBox(txt_reqNo, "");
				MyOraDB.Parameter_Values[8]  = COM.ComFunction.Empty_TextBox(txt_reqSeq, "");
				MyOraDB.Parameter_Values[9]  = COM.ComFunction.Empty_Combo(cmb_result, "");
				MyOraDB.Parameter_Values[10] = COM.ComFunction.Empty_TextBox(txt_remark, "");
				MyOraDB.Parameter_Values[12] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "SAVE_SBP_REQUEST_HEAD", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}

		#endregion

	}
}

