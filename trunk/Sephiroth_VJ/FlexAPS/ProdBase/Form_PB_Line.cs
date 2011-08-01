using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 

namespace FlexAPS.ProdBase
{
	public class Form_PB_Line : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리 

		private C1.Win.C1Command.C1OutBar obar_Main;
		private C1.Win.C1Command.C1OutPage obarpg_Line;
		private System.Windows.Forms.Panel pnl_LBody;
		public System.Windows.Forms.Panel pnl_LSearchSplitLeft;
		public System.Windows.Forms.Panel pnl_SearchLeftImage;
		public System.Windows.Forms.PictureBox picb_LMR;
		public System.Windows.Forms.PictureBox picb_LBR;
		private C1.Win.C1List.C1Combo cmb_LFactory;
		private System.Windows.Forms.Label lbl_SLFactory;
		public System.Windows.Forms.PictureBox picb_LBM;
		public System.Windows.Forms.PictureBox picb_LTR;
		public System.Windows.Forms.PictureBox picb_LTM;
		public System.Windows.Forms.PictureBox picb_LMM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_LML;
		public System.Windows.Forms.PictureBox picb_LBL;
		private System.Windows.Forms.Panel pnl_LBodyRight;
		public System.Windows.Forms.Panel pnl_DisplayImage;
		private System.Windows.Forms.TextBox txt_LRemarks;
		private System.Windows.Forms.TextBox txt_LProcUnit;
		private System.Windows.Forms.TextBox txt_LMinCapa;
		private System.Windows.Forms.TextBox txt_LStdCapa;
		private System.Windows.Forms.Label lbl_LRemarks;
		private System.Windows.Forms.Label lbl_LProcUnit;
		private System.Windows.Forms.Label lbl_LMinCapa;
		private System.Windows.Forms.Label lbl_LStdCapa;
		private System.Windows.Forms.TextBox txt_LName;
		private System.Windows.Forms.TextBox txt_LCode;
		private System.Windows.Forms.Label lbl_LCharge;
		private System.Windows.Forms.Label lbl_LName;
		private System.Windows.Forms.Label lbl_LCode;
		private System.Windows.Forms.Label lbl_LMaxCapa;
		private System.Windows.Forms.TextBox txt_LMaxCapa;
		private System.Windows.Forms.TextBox txt_LCharge;
		public System.Windows.Forms.PictureBox picb_DBM;
		public System.Windows.Forms.PictureBox picb_DMM;
		public System.Windows.Forms.PictureBox picb_DBR;
		public System.Windows.Forms.PictureBox picb_DMR;
		public System.Windows.Forms.PictureBox picb_DTR;
		public System.Windows.Forms.PictureBox picb_DTM;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.PictureBox picb_DBL;
		public System.Windows.Forms.PictureBox picb_DML;
		public COM.FSP fgrid_Line;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Panel pnl_MLB;
		public System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Panel pnl_MLBT;
		public COM.FSP fgrid_MiniLine;
		public System.Windows.Forms.Label lbl_SubTitle5;
		private C1.Win.C1List.C1Combo cmb_MLOpCd;
		private C1.Win.C1List.C1Combo cmb_MLLineCd;
		private System.Windows.Forms.Label lbl_MLLine;
		private System.Windows.Forms.Label lbl_MLOpCd;
		private C1.Win.C1List.C1Combo cmb_MLFactory;
		private System.Windows.Forms.Label lbl_MLFactory;
		private System.Windows.Forms.Label lbl_LLineType;
		private System.Windows.Forms.CheckBox chk_LViewYN;
		private System.Windows.Forms.TextBox txt_LLineType;
		private System.Windows.Forms.Label lbl_LViewYN;
		private C1.Win.C1Command.C1OutPage obarpg_LineOpMini;
		private System.Windows.Forms.MenuItem menuItem_CreateLine;
		private System.Windows.Forms.ContextMenu cmenu_createline;
		private System.Windows.Forms.MenuItem menuItem_Group;
		private C1.Win.C1Command.C1OutPage obarpg_LineOpLeadTime;
		private System.Windows.Forms.Panel pnl_LLB;
		public COM.FSP fgrid_LineOpLT;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Panel panel4;
		private C1.Win.C1List.C1Combo cmb_LLLineCd;
		private System.Windows.Forms.Label lbl_LLLine;
		public System.Windows.Forms.PictureBox pictureBox17;
		private C1.Win.C1List.C1Combo cmb_LLFactory;
		private System.Windows.Forms.Label lbl_LLFactory;
		public System.Windows.Forms.PictureBox pictureBox18;
		public System.Windows.Forms.PictureBox pictureBox19;
		public System.Windows.Forms.PictureBox pictureBox20;
		public System.Windows.Forms.PictureBox pictureBox21;
		public System.Windows.Forms.PictureBox pictureBox22;
		public System.Windows.Forms.PictureBox pictureBox23;
		public System.Windows.Forms.Label lbl_SubTitle6;
		public System.Windows.Forms.PictureBox pictureBox24;
		private System.Windows.Forms.Label btn_Copy;
		private System.Windows.Forms.Label btn_ApplyCopy;
		private System.Windows.Forms.Label btn_DisplayOp;
		private C1.Win.C1List.C1Combo cmb_LTCd;
		private System.Windows.Forms.Label lbl_LTCd;
		private C1.Win.C1List.C1Combo cmb_ApplyYMD;
		private System.Windows.Forms.Label lbl_ApplyYMD;
		private System.Windows.Forms.Label btn_CreateLTCd;
		private System.Windows.Forms.Label btn_CreateApplyYMD;
		private System.Windows.Forms.CheckBox chk_DefaultYN;
		private System.Windows.Forms.Label lbl_DefaultYN;
		private C1.Win.C1List.C1Combo cmb_ApplyYMDCopy;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label lbl_CreateLineGroup;
		private System.Windows.Forms.Label btn_CreateLineGroup;
		private System.Windows.Forms.Label lbl_LRoutType;
		private System.Windows.Forms.TextBox txt_LRoutType;
		private System.Windows.Forms.Label btn_ApplyCopyLine;
		private C1.Win.C1List.C1Combo cmb_LLLineCd1;
		private System.Windows.Forms.Label btn_LineCopy;
		private System.Windows.Forms.Panel panel2;
		private System.ComponentModel.IContainer components = null;

		public Form_PB_Line()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PB_Line));
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
            C1.Win.C1List.Style style65 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style66 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style67 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style68 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style69 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style70 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style71 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style72 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style73 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style74 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style75 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style76 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style77 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style78 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style79 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style80 = new C1.Win.C1List.Style();
            this.obar_Main = new C1.Win.C1Command.C1OutBar();
            this.obarpg_Line = new C1.Win.C1Command.C1OutPage();
            this.pnl_LBody = new System.Windows.Forms.Panel();
            this.fgrid_Line = new COM.FSP();
            this.pnl_LSearchSplitLeft = new System.Windows.Forms.Panel();
            this.pnl_SearchLeftImage = new System.Windows.Forms.Panel();
            this.btn_CreateLineGroup = new System.Windows.Forms.Label();
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.lbl_CreateLineGroup = new System.Windows.Forms.Label();
            this.picb_LMR = new System.Windows.Forms.PictureBox();
            this.picb_LBR = new System.Windows.Forms.PictureBox();
            this.cmb_LFactory = new C1.Win.C1List.C1Combo();
            this.lbl_SLFactory = new System.Windows.Forms.Label();
            this.picb_LBM = new System.Windows.Forms.PictureBox();
            this.picb_LTR = new System.Windows.Forms.PictureBox();
            this.picb_LTM = new System.Windows.Forms.PictureBox();
            this.picb_LMM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_LML = new System.Windows.Forms.PictureBox();
            this.picb_LBL = new System.Windows.Forms.PictureBox();
            this.pnl_LBodyRight = new System.Windows.Forms.Panel();
            this.pnl_DisplayImage = new System.Windows.Forms.Panel();
            this.lbl_LRoutType = new System.Windows.Forms.Label();
            this.txt_LRoutType = new System.Windows.Forms.TextBox();
            this.lbl_LLineType = new System.Windows.Forms.Label();
            this.chk_LViewYN = new System.Windows.Forms.CheckBox();
            this.txt_LLineType = new System.Windows.Forms.TextBox();
            this.lbl_LViewYN = new System.Windows.Forms.Label();
            this.picb_DBM = new System.Windows.Forms.PictureBox();
            this.txt_LRemarks = new System.Windows.Forms.TextBox();
            this.txt_LProcUnit = new System.Windows.Forms.TextBox();
            this.txt_LMinCapa = new System.Windows.Forms.TextBox();
            this.txt_LStdCapa = new System.Windows.Forms.TextBox();
            this.lbl_LRemarks = new System.Windows.Forms.Label();
            this.lbl_LProcUnit = new System.Windows.Forms.Label();
            this.lbl_LMinCapa = new System.Windows.Forms.Label();
            this.lbl_LStdCapa = new System.Windows.Forms.Label();
            this.txt_LName = new System.Windows.Forms.TextBox();
            this.txt_LCode = new System.Windows.Forms.TextBox();
            this.lbl_LCharge = new System.Windows.Forms.Label();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.lbl_LCode = new System.Windows.Forms.Label();
            this.lbl_LMaxCapa = new System.Windows.Forms.Label();
            this.txt_LMaxCapa = new System.Windows.Forms.TextBox();
            this.txt_LCharge = new System.Windows.Forms.TextBox();
            this.picb_DMM = new System.Windows.Forms.PictureBox();
            this.picb_DBR = new System.Windows.Forms.PictureBox();
            this.picb_DMR = new System.Windows.Forms.PictureBox();
            this.picb_DTR = new System.Windows.Forms.PictureBox();
            this.picb_DTM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle2 = new System.Windows.Forms.Label();
            this.picb_DBL = new System.Windows.Forms.PictureBox();
            this.picb_DML = new System.Windows.Forms.PictureBox();
            this.obarpg_LineOpLeadTime = new C1.Win.C1Command.C1OutPage();
            this.pnl_LLB = new System.Windows.Forms.Panel();
            this.fgrid_LineOpLT = new COM.FSP();
            this.cmenu_createline = new System.Windows.Forms.ContextMenu();
            this.menuItem_CreateLine = new System.Windows.Forms.MenuItem();
            this.menuItem_Group = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_ApplyCopyLine = new System.Windows.Forms.Label();
            this.cmb_LLLineCd1 = new C1.Win.C1List.C1Combo();
            this.btn_LineCopy = new System.Windows.Forms.Label();
            this.chk_DefaultYN = new System.Windows.Forms.CheckBox();
            this.lbl_DefaultYN = new System.Windows.Forms.Label();
            this.btn_CreateApplyYMD = new System.Windows.Forms.Label();
            this.btn_CreateLTCd = new System.Windows.Forms.Label();
            this.cmb_ApplyYMD = new C1.Win.C1List.C1Combo();
            this.lbl_ApplyYMD = new System.Windows.Forms.Label();
            this.cmb_LTCd = new C1.Win.C1List.C1Combo();
            this.lbl_LTCd = new System.Windows.Forms.Label();
            this.btn_DisplayOp = new System.Windows.Forms.Label();
            this.btn_ApplyCopy = new System.Windows.Forms.Label();
            this.cmb_ApplyYMDCopy = new C1.Win.C1List.C1Combo();
            this.btn_Copy = new System.Windows.Forms.Label();
            this.cmb_LLLineCd = new C1.Win.C1List.C1Combo();
            this.lbl_LLLine = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.cmb_LLFactory = new C1.Win.C1List.C1Combo();
            this.lbl_LLFactory = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle6 = new System.Windows.Forms.Label();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.obarpg_LineOpMini = new C1.Win.C1Command.C1OutPage();
            this.pnl_MLB = new System.Windows.Forms.Panel();
            this.fgrid_MiniLine = new COM.FSP();
            this.pnl_MLBT = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle5 = new System.Windows.Forms.Label();
            this.cmb_MLOpCd = new C1.Win.C1List.C1Combo();
            this.cmb_MLLineCd = new C1.Win.C1List.C1Combo();
            this.lbl_MLLine = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lbl_MLOpCd = new System.Windows.Forms.Label();
            this.cmb_MLFactory = new C1.Win.C1List.C1Combo();
            this.lbl_MLFactory = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
            this.obar_Main.SuspendLayout();
            this.obarpg_Line.SuspendLayout();
            this.pnl_LBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Line)).BeginInit();
            this.pnl_LSearchSplitLeft.SuspendLayout();
            this.pnl_SearchLeftImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBL)).BeginInit();
            this.pnl_LBodyRight.SuspendLayout();
            this.pnl_DisplayImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DML)).BeginInit();
            this.obarpg_LineOpLeadTime.SuspendLayout();
            this.pnl_LLB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_LineOpLT)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LLLineCd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ApplyYMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LTCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ApplyYMDCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LLLineCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LLFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            this.obarpg_LineOpMini.SuspendLayout();
            this.pnl_MLB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MiniLine)).BeginInit();
            this.pnl_MLBT.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLOpCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLLineCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // tbtn_Color
            // 
            this.tbtn_Color.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Color_Click);
            // 
            // obar_Main
            // 
            this.obar_Main.Animate = false;
            this.obar_Main.BackColor = System.Drawing.SystemColors.Window;
            this.obar_Main.Controls.Add(this.obarpg_Line);
            this.obar_Main.Controls.Add(this.obarpg_LineOpLeadTime);
            this.obar_Main.Controls.Add(this.obarpg_LineOpMini);
            this.obar_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obar_Main.Location = new System.Drawing.Point(8, 0);
            this.obar_Main.Name = "obar_Main";
            this.obar_Main.SelectedIndex = 0;
            this.obar_Main.Size = new System.Drawing.Size(998, 576);
            this.obar_Main.SelectedPageChanged += new System.EventHandler(this.obar_Main_SelectedPageChanged);
            // 
            // obarpg_Line
            // 
            this.obarpg_Line.Controls.Add(this.pnl_LBody);
            this.obarpg_Line.Name = "obarpg_Line";
            this.obarpg_Line.Size = new System.Drawing.Size(998, 516);
            this.obarpg_Line.Text = "VSM Line";
            // 
            // pnl_LBody
            // 
            this.pnl_LBody.Controls.Add(this.fgrid_Line);
            this.pnl_LBody.Controls.Add(this.pnl_LSearchSplitLeft);
            this.pnl_LBody.Controls.Add(this.pnl_LBodyRight);
            this.pnl_LBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_LBody.Location = new System.Drawing.Point(0, 0);
            this.pnl_LBody.Name = "pnl_LBody";
            this.pnl_LBody.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_LBody.Size = new System.Drawing.Size(998, 516);
            this.pnl_LBody.TabIndex = 27;
            // 
            // fgrid_Line
            // 
            this.fgrid_Line.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Line.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Line.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Line.Location = new System.Drawing.Point(8, 81);
            this.fgrid_Line.Name = "fgrid_Line";
            this.fgrid_Line.Rows.DefaultSize = 19;
            this.fgrid_Line.Size = new System.Drawing.Size(583, 427);
            this.fgrid_Line.StyleInfo = resources.GetString("fgrid_Line.StyleInfo");
            this.fgrid_Line.TabIndex = 33;
            this.fgrid_Line.Click += new System.EventHandler(this.fgrid_Line_Click);
            this.fgrid_Line.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Line_AfterEdit);
            // 
            // pnl_LSearchSplitLeft
            // 
            this.pnl_LSearchSplitLeft.Controls.Add(this.pnl_SearchLeftImage);
            this.pnl_LSearchSplitLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_LSearchSplitLeft.Location = new System.Drawing.Point(8, 8);
            this.pnl_LSearchSplitLeft.Name = "pnl_LSearchSplitLeft";
            this.pnl_LSearchSplitLeft.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_LSearchSplitLeft.Size = new System.Drawing.Size(583, 73);
            this.pnl_LSearchSplitLeft.TabIndex = 26;
            // 
            // pnl_SearchLeftImage
            // 
            this.pnl_SearchLeftImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchLeftImage.Controls.Add(this.btn_CreateLineGroup);
            this.pnl_SearchLeftImage.Controls.Add(this.lbl_CreateLineGroup);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LMR);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LBR);
            this.pnl_SearchLeftImage.Controls.Add(this.cmb_LFactory);
            this.pnl_SearchLeftImage.Controls.Add(this.lbl_SLFactory);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LBM);
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
            this.pnl_SearchLeftImage.Size = new System.Drawing.Size(583, 65);
            this.pnl_SearchLeftImage.TabIndex = 19;
            // 
            // btn_CreateLineGroup
            // 
            this.btn_CreateLineGroup.ImageIndex = 4;
            this.btn_CreateLineGroup.ImageList = this.img_MiniButton;
            this.btn_CreateLineGroup.Location = new System.Drawing.Point(393, 36);
            this.btn_CreateLineGroup.Name = "btn_CreateLineGroup";
            this.btn_CreateLineGroup.Size = new System.Drawing.Size(21, 21);
            this.btn_CreateLineGroup.TabIndex = 102;
            this.btn_CreateLineGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CreateLineGroup.Click += new System.EventHandler(this.btn_CreateLineGroup_Click);
            this.btn_CreateLineGroup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_CreateLineGroup_MouseDown);
            this.btn_CreateLineGroup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CreateLineGroup_MouseUp);
            // 
            // img_MiniButton
            // 
            this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
            this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_MiniButton.Images.SetKeyName(0, "");
            this.img_MiniButton.Images.SetKeyName(1, "");
            this.img_MiniButton.Images.SetKeyName(2, "");
            this.img_MiniButton.Images.SetKeyName(3, "");
            this.img_MiniButton.Images.SetKeyName(4, "");
            this.img_MiniButton.Images.SetKeyName(5, "");
            // 
            // lbl_CreateLineGroup
            // 
            this.lbl_CreateLineGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_CreateLineGroup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateLineGroup.ImageIndex = 0;
            this.lbl_CreateLineGroup.ImageList = this.img_Label;
            this.lbl_CreateLineGroup.Location = new System.Drawing.Point(292, 36);
            this.lbl_CreateLineGroup.Name = "lbl_CreateLineGroup";
            this.lbl_CreateLineGroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_CreateLineGroup.TabIndex = 29;
            this.lbl_CreateLineGroup.Text = "Line Group";
            this.lbl_CreateLineGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_LMR
            // 
            this.picb_LMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_LMR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMR.Image")));
            this.picb_LMR.Location = new System.Drawing.Point(568, 24);
            this.picb_LMR.Name = "picb_LMR";
            this.picb_LMR.Size = new System.Drawing.Size(23, 25);
            this.picb_LMR.TabIndex = 26;
            this.picb_LMR.TabStop = false;
            // 
            // picb_LBR
            // 
            this.picb_LBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_LBR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBR.Image")));
            this.picb_LBR.Location = new System.Drawing.Point(567, 49);
            this.picb_LBR.Name = "picb_LBR";
            this.picb_LBR.Size = new System.Drawing.Size(24, 16);
            this.picb_LBR.TabIndex = 23;
            this.picb_LBR.TabStop = false;
            // 
            // cmb_LFactory
            // 
            this.cmb_LFactory.AddItemSeparator = ';';
            this.cmb_LFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LFactory.Caption = "";
            this.cmb_LFactory.CaptionHeight = 17;
            this.cmb_LFactory.CaptionStyle = style1;
            this.cmb_LFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LFactory.ColumnCaptionHeight = 18;
            this.cmb_LFactory.ColumnFooterHeight = 18;
            this.cmb_LFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LFactory.ContentHeight = 17;
            this.cmb_LFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LFactory.EditorHeight = 17;
            this.cmb_LFactory.EvenRowStyle = style2;
            this.cmb_LFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LFactory.FooterStyle = style3;
            this.cmb_LFactory.HeadingStyle = style4;
            this.cmb_LFactory.HighLightRowStyle = style5;
            this.cmb_LFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_LFactory.Images"))));
            this.cmb_LFactory.ItemHeight = 15;
            this.cmb_LFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_LFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_LFactory.MaxDropDownItems = ((short)(5));
            this.cmb_LFactory.MaxLength = 32767;
            this.cmb_LFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LFactory.Name = "cmb_LFactory";
            this.cmb_LFactory.OddRowStyle = style6;
            this.cmb_LFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LFactory.SelectedStyle = style7;
            this.cmb_LFactory.Size = new System.Drawing.Size(180, 21);
            this.cmb_LFactory.Style = style8;
            this.cmb_LFactory.TabIndex = 14;
            this.cmb_LFactory.SelectedValueChanged += new System.EventHandler(this.cmb_LFactory_SelectedValueChanged);
            this.cmb_LFactory.PropBag = resources.GetString("cmb_LFactory.PropBag");
            // 
            // lbl_SLFactory
            // 
            this.lbl_SLFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SLFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SLFactory.ImageIndex = 0;
            this.lbl_SLFactory.ImageList = this.img_Label;
            this.lbl_SLFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_SLFactory.Name = "lbl_SLFactory";
            this.lbl_SLFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_SLFactory.TabIndex = 13;
            this.lbl_SLFactory.Text = "Factory";
            this.lbl_SLFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_LBM
            // 
            this.picb_LBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_LBM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBM.Image")));
            this.picb_LBM.Location = new System.Drawing.Point(131, 47);
            this.picb_LBM.Name = "picb_LBM";
            this.picb_LBM.Size = new System.Drawing.Size(583, 18);
            this.picb_LBM.TabIndex = 28;
            this.picb_LBM.TabStop = false;
            // 
            // picb_LTR
            // 
            this.picb_LTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_LTR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTR.Image")));
            this.picb_LTR.Location = new System.Drawing.Point(567, 0);
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
            this.picb_LTM.Size = new System.Drawing.Size(583, 32);
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
            this.picb_LMM.Size = new System.Drawing.Size(583, 25);
            this.picb_LMM.TabIndex = 27;
            this.picb_LMM.TabStop = false;
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
            this.lbl_SubTitle1.TabIndex = 20;
            this.lbl_SubTitle1.Text = "      Line Head Info.";
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
            this.picb_LML.Size = new System.Drawing.Size(168, 25);
            this.picb_LML.TabIndex = 25;
            this.picb_LML.TabStop = false;
            // 
            // picb_LBL
            // 
            this.picb_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_LBL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBL.Image")));
            this.picb_LBL.Location = new System.Drawing.Point(0, 45);
            this.picb_LBL.Name = "picb_LBL";
            this.picb_LBL.Size = new System.Drawing.Size(168, 20);
            this.picb_LBL.TabIndex = 22;
            this.picb_LBL.TabStop = false;
            // 
            // pnl_LBodyRight
            // 
            this.pnl_LBodyRight.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_LBodyRight.Controls.Add(this.pnl_DisplayImage);
            this.pnl_LBodyRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_LBodyRight.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_LBodyRight.Location = new System.Drawing.Point(591, 8);
            this.pnl_LBodyRight.Name = "pnl_LBodyRight";
            this.pnl_LBodyRight.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnl_LBodyRight.Size = new System.Drawing.Size(399, 500);
            this.pnl_LBodyRight.TabIndex = 24;
            // 
            // pnl_DisplayImage
            // 
            this.pnl_DisplayImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_DisplayImage.Controls.Add(this.lbl_LRoutType);
            this.pnl_DisplayImage.Controls.Add(this.txt_LRoutType);
            this.pnl_DisplayImage.Controls.Add(this.lbl_LLineType);
            this.pnl_DisplayImage.Controls.Add(this.chk_LViewYN);
            this.pnl_DisplayImage.Controls.Add(this.txt_LLineType);
            this.pnl_DisplayImage.Controls.Add(this.lbl_LViewYN);
            this.pnl_DisplayImage.Controls.Add(this.picb_DBM);
            this.pnl_DisplayImage.Controls.Add(this.txt_LRemarks);
            this.pnl_DisplayImage.Controls.Add(this.txt_LProcUnit);
            this.pnl_DisplayImage.Controls.Add(this.txt_LMinCapa);
            this.pnl_DisplayImage.Controls.Add(this.txt_LStdCapa);
            this.pnl_DisplayImage.Controls.Add(this.lbl_LRemarks);
            this.pnl_DisplayImage.Controls.Add(this.lbl_LProcUnit);
            this.pnl_DisplayImage.Controls.Add(this.lbl_LMinCapa);
            this.pnl_DisplayImage.Controls.Add(this.lbl_LStdCapa);
            this.pnl_DisplayImage.Controls.Add(this.txt_LName);
            this.pnl_DisplayImage.Controls.Add(this.txt_LCode);
            this.pnl_DisplayImage.Controls.Add(this.lbl_LCharge);
            this.pnl_DisplayImage.Controls.Add(this.lbl_LName);
            this.pnl_DisplayImage.Controls.Add(this.lbl_LCode);
            this.pnl_DisplayImage.Controls.Add(this.lbl_LMaxCapa);
            this.pnl_DisplayImage.Controls.Add(this.txt_LMaxCapa);
            this.pnl_DisplayImage.Controls.Add(this.txt_LCharge);
            this.pnl_DisplayImage.Controls.Add(this.picb_DMM);
            this.pnl_DisplayImage.Controls.Add(this.picb_DBR);
            this.pnl_DisplayImage.Controls.Add(this.picb_DMR);
            this.pnl_DisplayImage.Controls.Add(this.picb_DTR);
            this.pnl_DisplayImage.Controls.Add(this.picb_DTM);
            this.pnl_DisplayImage.Controls.Add(this.lbl_SubTitle2);
            this.pnl_DisplayImage.Controls.Add(this.picb_DBL);
            this.pnl_DisplayImage.Controls.Add(this.picb_DML);
            this.pnl_DisplayImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_DisplayImage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_DisplayImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_DisplayImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_DisplayImage.Name = "pnl_DisplayImage";
            this.pnl_DisplayImage.Size = new System.Drawing.Size(391, 500);
            this.pnl_DisplayImage.TabIndex = 24;
            // 
            // lbl_LRoutType
            // 
            this.lbl_LRoutType.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_LRoutType.ImageIndex = 0;
            this.lbl_LRoutType.ImageList = this.img_Label;
            this.lbl_LRoutType.Location = new System.Drawing.Point(10, 168);
            this.lbl_LRoutType.Name = "lbl_LRoutType";
            this.lbl_LRoutType.Size = new System.Drawing.Size(100, 21);
            this.lbl_LRoutType.TabIndex = 146;
            this.lbl_LRoutType.Text = "Routing Type";
            this.lbl_LRoutType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_LRoutType
            // 
            this.txt_LRoutType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LRoutType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LRoutType.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_LRoutType.Location = new System.Drawing.Point(111, 168);
            this.txt_LRoutType.MaxLength = 100;
            this.txt_LRoutType.Name = "txt_LRoutType";
            this.txt_LRoutType.ReadOnly = true;
            this.txt_LRoutType.Size = new System.Drawing.Size(210, 21);
            this.txt_LRoutType.TabIndex = 147;
            // 
            // lbl_LLineType
            // 
            this.lbl_LLineType.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_LLineType.ImageIndex = 0;
            this.lbl_LLineType.ImageList = this.img_Label;
            this.lbl_LLineType.Location = new System.Drawing.Point(10, 146);
            this.lbl_LLineType.Name = "lbl_LLineType";
            this.lbl_LLineType.Size = new System.Drawing.Size(100, 21);
            this.lbl_LLineType.TabIndex = 143;
            this.lbl_LLineType.Text = "Line Group";
            this.lbl_LLineType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_LViewYN
            // 
            this.chk_LViewYN.Enabled = false;
            this.chk_LViewYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_LViewYN.Location = new System.Drawing.Point(111, 338);
            this.chk_LViewYN.Name = "chk_LViewYN";
            this.chk_LViewYN.Size = new System.Drawing.Size(16, 21);
            this.chk_LViewYN.TabIndex = 145;
            this.chk_LViewYN.Visible = false;
            // 
            // txt_LLineType
            // 
            this.txt_LLineType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LLineType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LLineType.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_LLineType.Location = new System.Drawing.Point(111, 146);
            this.txt_LLineType.MaxLength = 100;
            this.txt_LLineType.Name = "txt_LLineType";
            this.txt_LLineType.ReadOnly = true;
            this.txt_LLineType.Size = new System.Drawing.Size(210, 21);
            this.txt_LLineType.TabIndex = 144;
            // 
            // lbl_LViewYN
            // 
            this.lbl_LViewYN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_LViewYN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LViewYN.ImageIndex = 0;
            this.lbl_LViewYN.ImageList = this.img_Label;
            this.lbl_LViewYN.Location = new System.Drawing.Point(10, 338);
            this.lbl_LViewYN.Name = "lbl_LViewYN";
            this.lbl_LViewYN.Size = new System.Drawing.Size(100, 21);
            this.lbl_LViewYN.TabIndex = 142;
            this.lbl_LViewYN.Text = "MiniLine View";
            this.lbl_LViewYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_LViewYN.Visible = false;
            // 
            // picb_DBM
            // 
            this.picb_DBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_DBM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_DBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBM.Image")));
            this.picb_DBM.Location = new System.Drawing.Point(144, 481);
            this.picb_DBM.Name = "picb_DBM";
            this.picb_DBM.Size = new System.Drawing.Size(239, 27);
            this.picb_DBM.TabIndex = 24;
            this.picb_DBM.TabStop = false;
            // 
            // txt_LRemarks
            // 
            this.txt_LRemarks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LRemarks.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_LRemarks.Location = new System.Drawing.Point(111, 190);
            this.txt_LRemarks.MaxLength = 100;
            this.txt_LRemarks.Name = "txt_LRemarks";
            this.txt_LRemarks.ReadOnly = true;
            this.txt_LRemarks.Size = new System.Drawing.Size(210, 21);
            this.txt_LRemarks.TabIndex = 100;
            // 
            // txt_LProcUnit
            // 
            this.txt_LProcUnit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LProcUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LProcUnit.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_LProcUnit.Location = new System.Drawing.Point(111, 317);
            this.txt_LProcUnit.MaxLength = 100;
            this.txt_LProcUnit.Name = "txt_LProcUnit";
            this.txt_LProcUnit.ReadOnly = true;
            this.txt_LProcUnit.Size = new System.Drawing.Size(210, 21);
            this.txt_LProcUnit.TabIndex = 99;
            this.txt_LProcUnit.Visible = false;
            // 
            // txt_LMinCapa
            // 
            this.txt_LMinCapa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LMinCapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LMinCapa.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_LMinCapa.Location = new System.Drawing.Point(111, 124);
            this.txt_LMinCapa.MaxLength = 100;
            this.txt_LMinCapa.Name = "txt_LMinCapa";
            this.txt_LMinCapa.ReadOnly = true;
            this.txt_LMinCapa.Size = new System.Drawing.Size(210, 21);
            this.txt_LMinCapa.TabIndex = 98;
            // 
            // txt_LStdCapa
            // 
            this.txt_LStdCapa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LStdCapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LStdCapa.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_LStdCapa.Location = new System.Drawing.Point(111, 102);
            this.txt_LStdCapa.MaxLength = 100;
            this.txt_LStdCapa.Name = "txt_LStdCapa";
            this.txt_LStdCapa.ReadOnly = true;
            this.txt_LStdCapa.Size = new System.Drawing.Size(210, 21);
            this.txt_LStdCapa.TabIndex = 97;
            // 
            // lbl_LRemarks
            // 
            this.lbl_LRemarks.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_LRemarks.ImageIndex = 0;
            this.lbl_LRemarks.ImageList = this.img_Label;
            this.lbl_LRemarks.Location = new System.Drawing.Point(10, 190);
            this.lbl_LRemarks.Name = "lbl_LRemarks";
            this.lbl_LRemarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_LRemarks.TabIndex = 96;
            this.lbl_LRemarks.Text = "Remarks";
            this.lbl_LRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_LProcUnit
            // 
            this.lbl_LProcUnit.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_LProcUnit.ImageIndex = 0;
            this.lbl_LProcUnit.ImageList = this.img_Label;
            this.lbl_LProcUnit.Location = new System.Drawing.Point(10, 317);
            this.lbl_LProcUnit.Name = "lbl_LProcUnit";
            this.lbl_LProcUnit.Size = new System.Drawing.Size(100, 21);
            this.lbl_LProcUnit.TabIndex = 95;
            this.lbl_LProcUnit.Text = "Prod. Unit";
            this.lbl_LProcUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_LProcUnit.Visible = false;
            // 
            // lbl_LMinCapa
            // 
            this.lbl_LMinCapa.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_LMinCapa.ImageIndex = 0;
            this.lbl_LMinCapa.ImageList = this.img_Label;
            this.lbl_LMinCapa.Location = new System.Drawing.Point(10, 124);
            this.lbl_LMinCapa.Name = "lbl_LMinCapa";
            this.lbl_LMinCapa.Size = new System.Drawing.Size(100, 21);
            this.lbl_LMinCapa.TabIndex = 94;
            this.lbl_LMinCapa.Text = "Min Capa.";
            this.lbl_LMinCapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_LStdCapa
            // 
            this.lbl_LStdCapa.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_LStdCapa.ImageIndex = 0;
            this.lbl_LStdCapa.ImageList = this.img_Label;
            this.lbl_LStdCapa.Location = new System.Drawing.Point(10, 102);
            this.lbl_LStdCapa.Name = "lbl_LStdCapa";
            this.lbl_LStdCapa.Size = new System.Drawing.Size(100, 21);
            this.lbl_LStdCapa.TabIndex = 93;
            this.lbl_LStdCapa.Text = "Std Capa.";
            this.lbl_LStdCapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_LName
            // 
            this.txt_LName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_LName.Location = new System.Drawing.Point(111, 58);
            this.txt_LName.MaxLength = 60;
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.ReadOnly = true;
            this.txt_LName.Size = new System.Drawing.Size(210, 21);
            this.txt_LName.TabIndex = 90;
            // 
            // txt_LCode
            // 
            this.txt_LCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LCode.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_LCode.Location = new System.Drawing.Point(111, 36);
            this.txt_LCode.MaxLength = 60;
            this.txt_LCode.Name = "txt_LCode";
            this.txt_LCode.ReadOnly = true;
            this.txt_LCode.Size = new System.Drawing.Size(210, 21);
            this.txt_LCode.TabIndex = 86;
            // 
            // lbl_LCharge
            // 
            this.lbl_LCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_LCharge.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LCharge.ImageIndex = 0;
            this.lbl_LCharge.ImageList = this.img_Label;
            this.lbl_LCharge.Location = new System.Drawing.Point(10, 296);
            this.lbl_LCharge.Name = "lbl_LCharge";
            this.lbl_LCharge.Size = new System.Drawing.Size(100, 21);
            this.lbl_LCharge.TabIndex = 17;
            this.lbl_LCharge.Text = "Line Charge";
            this.lbl_LCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_LCharge.Visible = false;
            // 
            // lbl_LName
            // 
            this.lbl_LName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_LName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LName.ImageIndex = 0;
            this.lbl_LName.ImageList = this.img_Label;
            this.lbl_LName.Location = new System.Drawing.Point(10, 58);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(100, 21);
            this.lbl_LName.TabIndex = 15;
            this.lbl_LName.Text = "Line Name";
            this.lbl_LName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_LCode
            // 
            this.lbl_LCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_LCode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LCode.ImageIndex = 0;
            this.lbl_LCode.ImageList = this.img_Label;
            this.lbl_LCode.Location = new System.Drawing.Point(10, 36);
            this.lbl_LCode.Name = "lbl_LCode";
            this.lbl_LCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_LCode.TabIndex = 14;
            this.lbl_LCode.Text = "Line Code";
            this.lbl_LCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_LMaxCapa
            // 
            this.lbl_LMaxCapa.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_LMaxCapa.ImageIndex = 0;
            this.lbl_LMaxCapa.ImageList = this.img_Label;
            this.lbl_LMaxCapa.Location = new System.Drawing.Point(10, 80);
            this.lbl_LMaxCapa.Name = "lbl_LMaxCapa";
            this.lbl_LMaxCapa.Size = new System.Drawing.Size(100, 21);
            this.lbl_LMaxCapa.TabIndex = 78;
            this.lbl_LMaxCapa.Text = "Max Capa.";
            this.lbl_LMaxCapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_LMaxCapa
            // 
            this.txt_LMaxCapa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LMaxCapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LMaxCapa.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_LMaxCapa.Location = new System.Drawing.Point(111, 80);
            this.txt_LMaxCapa.MaxLength = 100;
            this.txt_LMaxCapa.Name = "txt_LMaxCapa";
            this.txt_LMaxCapa.ReadOnly = true;
            this.txt_LMaxCapa.Size = new System.Drawing.Size(210, 21);
            this.txt_LMaxCapa.TabIndex = 92;
            // 
            // txt_LCharge
            // 
            this.txt_LCharge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LCharge.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_LCharge.Location = new System.Drawing.Point(111, 296);
            this.txt_LCharge.MaxLength = 60;
            this.txt_LCharge.Name = "txt_LCharge";
            this.txt_LCharge.ReadOnly = true;
            this.txt_LCharge.Size = new System.Drawing.Size(210, 21);
            this.txt_LCharge.TabIndex = 91;
            this.txt_LCharge.Visible = false;
            // 
            // picb_DMM
            // 
            this.picb_DMM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_DMM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_DMM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DMM.Image")));
            this.picb_DMM.Location = new System.Drawing.Point(152, 32);
            this.picb_DMM.Name = "picb_DMM";
            this.picb_DMM.Size = new System.Drawing.Size(231, 500);
            this.picb_DMM.TabIndex = 27;
            this.picb_DMM.TabStop = false;
            // 
            // picb_DBR
            // 
            this.picb_DBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_DBR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_DBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBR.Image")));
            this.picb_DBR.Location = new System.Drawing.Point(375, 483);
            this.picb_DBR.Name = "picb_DBR";
            this.picb_DBR.Size = new System.Drawing.Size(16, 25);
            this.picb_DBR.TabIndex = 23;
            this.picb_DBR.TabStop = false;
            // 
            // picb_DMR
            // 
            this.picb_DMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_DMR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_DMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DMR.Image")));
            this.picb_DMR.Location = new System.Drawing.Point(376, 25);
            this.picb_DMR.Name = "picb_DMR";
            this.picb_DMR.Size = new System.Drawing.Size(15, 500);
            this.picb_DMR.TabIndex = 26;
            this.picb_DMR.TabStop = false;
            // 
            // picb_DTR
            // 
            this.picb_DTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_DTR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_DTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DTR.Image")));
            this.picb_DTR.Location = new System.Drawing.Point(375, 0);
            this.picb_DTR.Name = "picb_DTR";
            this.picb_DTR.Size = new System.Drawing.Size(16, 32);
            this.picb_DTR.TabIndex = 21;
            this.picb_DTR.TabStop = false;
            // 
            // picb_DTM
            // 
            this.picb_DTM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_DTM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_DTM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DTM.Image")));
            this.picb_DTM.Location = new System.Drawing.Point(224, 0);
            this.picb_DTM.Name = "picb_DTM";
            this.picb_DTM.Size = new System.Drawing.Size(161, 39);
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
            this.lbl_SubTitle2.Text = "      Display Line Head Info.";
            this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_DBL
            // 
            this.picb_DBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_DBL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_DBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBL.Image")));
            this.picb_DBL.Location = new System.Drawing.Point(0, 479);
            this.picb_DBL.Name = "picb_DBL";
            this.picb_DBL.Size = new System.Drawing.Size(168, 29);
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
            this.picb_DML.Size = new System.Drawing.Size(168, 500);
            this.picb_DML.TabIndex = 25;
            this.picb_DML.TabStop = false;
            // 
            // obarpg_LineOpLeadTime
            // 
            this.obarpg_LineOpLeadTime.Controls.Add(this.pnl_LLB);
            this.obarpg_LineOpLeadTime.Name = "obarpg_LineOpLeadTime";
            this.obarpg_LineOpLeadTime.Size = new System.Drawing.Size(998, 516);
            this.obarpg_LineOpLeadTime.Text = "VSM Line OP LeadTime";
            // 
            // pnl_LLB
            // 
            this.pnl_LLB.Controls.Add(this.fgrid_LineOpLT);
            this.pnl_LLB.Controls.Add(this.panel1);
            this.pnl_LLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_LLB.Location = new System.Drawing.Point(0, 0);
            this.pnl_LLB.Name = "pnl_LLB";
            this.pnl_LLB.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_LLB.Size = new System.Drawing.Size(998, 516);
            this.pnl_LLB.TabIndex = 0;
            // 
            // fgrid_LineOpLT
            // 
            this.fgrid_LineOpLT.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_LineOpLT.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_LineOpLT.ContextMenu = this.cmenu_createline;
            this.fgrid_LineOpLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_LineOpLT.Location = new System.Drawing.Point(8, 98);
            this.fgrid_LineOpLT.Name = "fgrid_LineOpLT";
            this.fgrid_LineOpLT.Rows.DefaultSize = 19;
            this.fgrid_LineOpLT.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_LineOpLT.Size = new System.Drawing.Size(982, 410);
            this.fgrid_LineOpLT.StyleInfo = resources.GetString("fgrid_LineOpLT.StyleInfo");
            this.fgrid_LineOpLT.TabIndex = 53;
            this.fgrid_LineOpLT.Click += new System.EventHandler(this.fgrid_LineOpLT_Click);
            this.fgrid_LineOpLT.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_LineOpLT_AfterEdit);
            this.fgrid_LineOpLT.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_LineOpLT_BeforeEdit);
            // 
            // cmenu_createline
            // 
            this.cmenu_createline.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_CreateLine,
            this.menuItem_Group});
            // 
            // menuItem_CreateLine
            // 
            this.menuItem_CreateLine.Index = 0;
            this.menuItem_CreateLine.Text = "Create MiniLine";
            this.menuItem_CreateLine.Click += new System.EventHandler(this.menuItem_CreateLine_Click);
            // 
            // menuItem_Group
            // 
            this.menuItem_Group.Index = 1;
            this.menuItem_Group.Text = "Grouping";
            this.menuItem_Group.Click += new System.EventHandler(this.menuItem_Group_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel1.Size = new System.Drawing.Size(982, 90);
            this.panel1.TabIndex = 52;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.btn_ApplyCopyLine);
            this.panel4.Controls.Add(this.cmb_LLLineCd1);
            this.panel4.Controls.Add(this.btn_LineCopy);
            this.panel4.Controls.Add(this.chk_DefaultYN);
            this.panel4.Controls.Add(this.lbl_DefaultYN);
            this.panel4.Controls.Add(this.btn_CreateApplyYMD);
            this.panel4.Controls.Add(this.btn_CreateLTCd);
            this.panel4.Controls.Add(this.cmb_ApplyYMD);
            this.panel4.Controls.Add(this.lbl_ApplyYMD);
            this.panel4.Controls.Add(this.cmb_LTCd);
            this.panel4.Controls.Add(this.lbl_LTCd);
            this.panel4.Controls.Add(this.btn_DisplayOp);
            this.panel4.Controls.Add(this.btn_ApplyCopy);
            this.panel4.Controls.Add(this.cmb_ApplyYMDCopy);
            this.panel4.Controls.Add(this.btn_Copy);
            this.panel4.Controls.Add(this.cmb_LLLineCd);
            this.panel4.Controls.Add(this.lbl_LLLine);
            this.panel4.Controls.Add(this.pictureBox17);
            this.panel4.Controls.Add(this.cmb_LLFactory);
            this.panel4.Controls.Add(this.lbl_LLFactory);
            this.panel4.Controls.Add(this.pictureBox18);
            this.panel4.Controls.Add(this.pictureBox19);
            this.panel4.Controls.Add(this.pictureBox20);
            this.panel4.Controls.Add(this.pictureBox21);
            this.panel4.Controls.Add(this.pictureBox22);
            this.panel4.Controls.Add(this.pictureBox23);
            this.panel4.Controls.Add(this.lbl_SubTitle6);
            this.panel4.Controls.Add(this.pictureBox24);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 85);
            this.panel4.TabIndex = 20;
            // 
            // btn_ApplyCopyLine
            // 
            this.btn_ApplyCopyLine.ImageIndex = 0;
            this.btn_ApplyCopyLine.ImageList = this.img_MiniButton;
            this.btn_ApplyCopyLine.Location = new System.Drawing.Point(752, 35);
            this.btn_ApplyCopyLine.Name = "btn_ApplyCopyLine";
            this.btn_ApplyCopyLine.Size = new System.Drawing.Size(21, 21);
            this.btn_ApplyCopyLine.TabIndex = 211;
            this.btn_ApplyCopyLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ApplyCopyLine.Click += new System.EventHandler(this.btn_ApplyCopyLine_Click);
            this.btn_ApplyCopyLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_ApplyCopyLine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // cmb_LLLineCd1
            // 
            this.cmb_LLLineCd1.AddItemSeparator = ';';
            this.cmb_LLLineCd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LLLineCd1.Caption = "";
            this.cmb_LLLineCd1.CaptionHeight = 17;
            this.cmb_LLLineCd1.CaptionStyle = style9;
            this.cmb_LLLineCd1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LLLineCd1.ColumnCaptionHeight = 18;
            this.cmb_LLLineCd1.ColumnFooterHeight = 18;
            this.cmb_LLLineCd1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LLLineCd1.ContentHeight = 17;
            this.cmb_LLLineCd1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LLLineCd1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LLLineCd1.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LLLineCd1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LLLineCd1.EditorHeight = 17;
            this.cmb_LLLineCd1.EvenRowStyle = style10;
            this.cmb_LLLineCd1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LLLineCd1.FooterStyle = style11;
            this.cmb_LLLineCd1.HeadingStyle = style12;
            this.cmb_LLLineCd1.HighLightRowStyle = style13;
            this.cmb_LLLineCd1.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_LLLineCd1.Images"))));
            this.cmb_LLLineCd1.ItemHeight = 15;
            this.cmb_LLLineCd1.Location = new System.Drawing.Point(611, 35);
            this.cmb_LLLineCd1.MatchEntryTimeout = ((long)(2000));
            this.cmb_LLLineCd1.MaxDropDownItems = ((short)(5));
            this.cmb_LLLineCd1.MaxLength = 32767;
            this.cmb_LLLineCd1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LLLineCd1.Name = "cmb_LLLineCd1";
            this.cmb_LLLineCd1.OddRowStyle = style14;
            this.cmb_LLLineCd1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LLLineCd1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LLLineCd1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LLLineCd1.SelectedStyle = style15;
            this.cmb_LLLineCd1.Size = new System.Drawing.Size(140, 21);
            this.cmb_LLLineCd1.Style = style16;
            this.cmb_LLLineCd1.TabIndex = 210;
            this.cmb_LLLineCd1.PropBag = resources.GetString("cmb_LLLineCd1.PropBag");
            // 
            // btn_LineCopy
            // 
            this.btn_LineCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_LineCopy.ImageIndex = 0;
            this.btn_LineCopy.ImageList = this.img_Button;
            this.btn_LineCopy.Location = new System.Drawing.Point(530, 34);
            this.btn_LineCopy.Name = "btn_LineCopy";
            this.btn_LineCopy.Size = new System.Drawing.Size(80, 23);
            this.btn_LineCopy.TabIndex = 209;
            this.btn_LineCopy.Text = "Copy";
            this.btn_LineCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_LineCopy.Click += new System.EventHandler(this.btn_LineCopy_Click);
            this.btn_LineCopy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_LineCopy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // chk_DefaultYN
            // 
            this.chk_DefaultYN.BackColor = System.Drawing.Color.Transparent;
            this.chk_DefaultYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_DefaultYN.Location = new System.Drawing.Point(389, 58);
            this.chk_DefaultYN.Name = "chk_DefaultYN";
            this.chk_DefaultYN.Size = new System.Drawing.Size(16, 21);
            this.chk_DefaultYN.TabIndex = 208;
            this.chk_DefaultYN.UseVisualStyleBackColor = false;
            // 
            // lbl_DefaultYN
            // 
            this.lbl_DefaultYN.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_DefaultYN.ImageIndex = 0;
            this.lbl_DefaultYN.ImageList = this.img_Label;
            this.lbl_DefaultYN.Location = new System.Drawing.Point(288, 58);
            this.lbl_DefaultYN.Name = "lbl_DefaultYN";
            this.lbl_DefaultYN.Size = new System.Drawing.Size(100, 21);
            this.lbl_DefaultYN.TabIndex = 207;
            this.lbl_DefaultYN.Text = "Standard L/T";
            this.lbl_DefaultYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_CreateApplyYMD
            // 
            this.btn_CreateApplyYMD.ImageIndex = 2;
            this.btn_CreateApplyYMD.ImageList = this.img_MiniButton;
            this.btn_CreateApplyYMD.Location = new System.Drawing.Point(671, 58);
            this.btn_CreateApplyYMD.Name = "btn_CreateApplyYMD";
            this.btn_CreateApplyYMD.Size = new System.Drawing.Size(21, 21);
            this.btn_CreateApplyYMD.TabIndex = 109;
            this.btn_CreateApplyYMD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CreateApplyYMD.Click += new System.EventHandler(this.btn_CreateApplyYMD_Click);
            this.btn_CreateApplyYMD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_CreateApplyYMD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_CreateLTCd
            // 
            this.btn_CreateLTCd.ImageIndex = 2;
            this.btn_CreateLTCd.ImageList = this.img_MiniButton;
            this.btn_CreateLTCd.Location = new System.Drawing.Point(252, 58);
            this.btn_CreateLTCd.Name = "btn_CreateLTCd";
            this.btn_CreateLTCd.Size = new System.Drawing.Size(21, 21);
            this.btn_CreateLTCd.TabIndex = 108;
            this.btn_CreateLTCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CreateLTCd.Click += new System.EventHandler(this.btn_CreateLTCd_Click);
            this.btn_CreateLTCd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_CreateLTCd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // cmb_ApplyYMD
            // 
            this.cmb_ApplyYMD.AddItemSeparator = ';';
            this.cmb_ApplyYMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ApplyYMD.Caption = "";
            this.cmb_ApplyYMD.CaptionHeight = 17;
            this.cmb_ApplyYMD.CaptionStyle = style17;
            this.cmb_ApplyYMD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ApplyYMD.ColumnCaptionHeight = 18;
            this.cmb_ApplyYMD.ColumnFooterHeight = 18;
            this.cmb_ApplyYMD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ApplyYMD.ContentHeight = 17;
            this.cmb_ApplyYMD.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ApplyYMD.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ApplyYMD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ApplyYMD.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ApplyYMD.EditorHeight = 17;
            this.cmb_ApplyYMD.EvenRowStyle = style18;
            this.cmb_ApplyYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ApplyYMD.FooterStyle = style19;
            this.cmb_ApplyYMD.HeadingStyle = style20;
            this.cmb_ApplyYMD.HighLightRowStyle = style21;
            this.cmb_ApplyYMD.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_ApplyYMD.Images"))));
            this.cmb_ApplyYMD.ItemHeight = 15;
            this.cmb_ApplyYMD.Location = new System.Drawing.Point(530, 58);
            this.cmb_ApplyYMD.MatchEntryTimeout = ((long)(2000));
            this.cmb_ApplyYMD.MaxDropDownItems = ((short)(5));
            this.cmb_ApplyYMD.MaxLength = 32767;
            this.cmb_ApplyYMD.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ApplyYMD.Name = "cmb_ApplyYMD";
            this.cmb_ApplyYMD.OddRowStyle = style22;
            this.cmb_ApplyYMD.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ApplyYMD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ApplyYMD.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ApplyYMD.SelectedStyle = style23;
            this.cmb_ApplyYMD.Size = new System.Drawing.Size(140, 21);
            this.cmb_ApplyYMD.Style = style24;
            this.cmb_ApplyYMD.TabIndex = 107;
            this.cmb_ApplyYMD.SelectedValueChanged += new System.EventHandler(this.cmb_ApplyYMD_SelectedValueChanged);
            this.cmb_ApplyYMD.PropBag = resources.GetString("cmb_ApplyYMD.PropBag");
            // 
            // lbl_ApplyYMD
            // 
            this.lbl_ApplyYMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ApplyYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApplyYMD.ImageIndex = 0;
            this.lbl_ApplyYMD.ImageList = this.img_Label;
            this.lbl_ApplyYMD.Location = new System.Drawing.Point(429, 58);
            this.lbl_ApplyYMD.Name = "lbl_ApplyYMD";
            this.lbl_ApplyYMD.Size = new System.Drawing.Size(100, 21);
            this.lbl_ApplyYMD.TabIndex = 106;
            this.lbl_ApplyYMD.Text = "Apply Date";
            this.lbl_ApplyYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_LTCd
            // 
            this.cmb_LTCd.AddItemSeparator = ';';
            this.cmb_LTCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LTCd.Caption = "";
            this.cmb_LTCd.CaptionHeight = 17;
            this.cmb_LTCd.CaptionStyle = style25;
            this.cmb_LTCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LTCd.ColumnCaptionHeight = 18;
            this.cmb_LTCd.ColumnFooterHeight = 18;
            this.cmb_LTCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LTCd.ContentHeight = 17;
            this.cmb_LTCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LTCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LTCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LTCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LTCd.EditorHeight = 17;
            this.cmb_LTCd.EvenRowStyle = style26;
            this.cmb_LTCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LTCd.FooterStyle = style27;
            this.cmb_LTCd.HeadingStyle = style28;
            this.cmb_LTCd.HighLightRowStyle = style29;
            this.cmb_LTCd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_LTCd.Images"))));
            this.cmb_LTCd.ItemHeight = 15;
            this.cmb_LTCd.Location = new System.Drawing.Point(111, 58);
            this.cmb_LTCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_LTCd.MaxDropDownItems = ((short)(5));
            this.cmb_LTCd.MaxLength = 32767;
            this.cmb_LTCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LTCd.Name = "cmb_LTCd";
            this.cmb_LTCd.OddRowStyle = style30;
            this.cmb_LTCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LTCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LTCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LTCd.SelectedStyle = style31;
            this.cmb_LTCd.Size = new System.Drawing.Size(140, 21);
            this.cmb_LTCd.Style = style32;
            this.cmb_LTCd.TabIndex = 105;
            this.cmb_LTCd.SelectedValueChanged += new System.EventHandler(this.cmb_LTCd_SelectedValueChanged);
            this.cmb_LTCd.PropBag = resources.GetString("cmb_LTCd.PropBag");
            // 
            // lbl_LTCd
            // 
            this.lbl_LTCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_LTCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LTCd.ImageIndex = 0;
            this.lbl_LTCd.ImageList = this.img_Label;
            this.lbl_LTCd.Location = new System.Drawing.Point(10, 58);
            this.lbl_LTCd.Name = "lbl_LTCd";
            this.lbl_LTCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_LTCd.TabIndex = 104;
            this.lbl_LTCd.Text = "L/T Code";
            this.lbl_LTCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_DisplayOp
            // 
            this.btn_DisplayOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DisplayOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_DisplayOp.ImageIndex = 0;
            this.btn_DisplayOp.ImageList = this.img_Button;
            this.btn_DisplayOp.Location = new System.Drawing.Point(888, 32);
            this.btn_DisplayOp.Name = "btn_DisplayOp";
            this.btn_DisplayOp.Size = new System.Drawing.Size(80, 23);
            this.btn_DisplayOp.TabIndex = 103;
            this.btn_DisplayOp.Text = "Display L.T.";
            this.btn_DisplayOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DisplayOp.Click += new System.EventHandler(this.btn_DisplayOp_Click);
            this.btn_DisplayOp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_DisplayOp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_ApplyCopy
            // 
            this.btn_ApplyCopy.ImageIndex = 0;
            this.btn_ApplyCopy.ImageList = this.img_MiniButton;
            this.btn_ApplyCopy.Location = new System.Drawing.Point(926, 58);
            this.btn_ApplyCopy.Name = "btn_ApplyCopy";
            this.btn_ApplyCopy.Size = new System.Drawing.Size(21, 21);
            this.btn_ApplyCopy.TabIndex = 102;
            this.btn_ApplyCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ApplyCopy.Click += new System.EventHandler(this.btn_ApplyCopy_Click);
            this.btn_ApplyCopy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_ApplyCopy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // cmb_ApplyYMDCopy
            // 
            this.cmb_ApplyYMDCopy.AddItemSeparator = ';';
            this.cmb_ApplyYMDCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ApplyYMDCopy.Caption = "";
            this.cmb_ApplyYMDCopy.CaptionHeight = 17;
            this.cmb_ApplyYMDCopy.CaptionStyle = style33;
            this.cmb_ApplyYMDCopy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ApplyYMDCopy.ColumnCaptionHeight = 18;
            this.cmb_ApplyYMDCopy.ColumnFooterHeight = 18;
            this.cmb_ApplyYMDCopy.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ApplyYMDCopy.ContentHeight = 17;
            this.cmb_ApplyYMDCopy.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ApplyYMDCopy.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ApplyYMDCopy.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ApplyYMDCopy.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ApplyYMDCopy.EditorHeight = 17;
            this.cmb_ApplyYMDCopy.EvenRowStyle = style34;
            this.cmb_ApplyYMDCopy.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ApplyYMDCopy.FooterStyle = style35;
            this.cmb_ApplyYMDCopy.HeadingStyle = style36;
            this.cmb_ApplyYMDCopy.HighLightRowStyle = style37;
            this.cmb_ApplyYMDCopy.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_ApplyYMDCopy.Images"))));
            this.cmb_ApplyYMDCopy.ItemHeight = 15;
            this.cmb_ApplyYMDCopy.Location = new System.Drawing.Point(785, 58);
            this.cmb_ApplyYMDCopy.MatchEntryTimeout = ((long)(2000));
            this.cmb_ApplyYMDCopy.MaxDropDownItems = ((short)(5));
            this.cmb_ApplyYMDCopy.MaxLength = 32767;
            this.cmb_ApplyYMDCopy.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ApplyYMDCopy.Name = "cmb_ApplyYMDCopy";
            this.cmb_ApplyYMDCopy.OddRowStyle = style38;
            this.cmb_ApplyYMDCopy.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ApplyYMDCopy.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ApplyYMDCopy.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ApplyYMDCopy.SelectedStyle = style39;
            this.cmb_ApplyYMDCopy.Size = new System.Drawing.Size(140, 21);
            this.cmb_ApplyYMDCopy.Style = style40;
            this.cmb_ApplyYMDCopy.TabIndex = 68;
            this.cmb_ApplyYMDCopy.PropBag = resources.GetString("cmb_ApplyYMDCopy.PropBag");
            // 
            // btn_Copy
            // 
            this.btn_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Copy.ImageIndex = 0;
            this.btn_Copy.ImageList = this.img_Button;
            this.btn_Copy.Location = new System.Drawing.Point(704, 57);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(80, 23);
            this.btn_Copy.TabIndex = 66;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            this.btn_Copy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Copy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // cmb_LLLineCd
            // 
            this.cmb_LLLineCd.AddItemSeparator = ';';
            this.cmb_LLLineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LLLineCd.Caption = "";
            this.cmb_LLLineCd.CaptionHeight = 17;
            this.cmb_LLLineCd.CaptionStyle = style41;
            this.cmb_LLLineCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LLLineCd.ColumnCaptionHeight = 18;
            this.cmb_LLLineCd.ColumnFooterHeight = 18;
            this.cmb_LLLineCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LLLineCd.ContentHeight = 17;
            this.cmb_LLLineCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LLLineCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LLLineCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LLLineCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LLLineCd.EditorHeight = 17;
            this.cmb_LLLineCd.EvenRowStyle = style42;
            this.cmb_LLLineCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LLLineCd.FooterStyle = style43;
            this.cmb_LLLineCd.HeadingStyle = style44;
            this.cmb_LLLineCd.HighLightRowStyle = style45;
            this.cmb_LLLineCd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_LLLineCd.Images"))));
            this.cmb_LLLineCd.ItemHeight = 15;
            this.cmb_LLLineCd.Location = new System.Drawing.Point(389, 36);
            this.cmb_LLLineCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_LLLineCd.MaxDropDownItems = ((short)(5));
            this.cmb_LLLineCd.MaxLength = 32767;
            this.cmb_LLLineCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LLLineCd.Name = "cmb_LLLineCd";
            this.cmb_LLLineCd.OddRowStyle = style46;
            this.cmb_LLLineCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LLLineCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LLLineCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LLLineCd.SelectedStyle = style47;
            this.cmb_LLLineCd.Size = new System.Drawing.Size(140, 21);
            this.cmb_LLLineCd.Style = style48;
            this.cmb_LLLineCd.TabIndex = 32;
            this.cmb_LLLineCd.SelectedValueChanged += new System.EventHandler(this.cmb_LLLineCd_SelectedValueChanged);
            this.cmb_LLLineCd.PropBag = resources.GetString("cmb_LLLineCd.PropBag");
            // 
            // lbl_LLLine
            // 
            this.lbl_LLLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_LLLine.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LLLine.ImageIndex = 0;
            this.lbl_LLLine.ImageList = this.img_Label;
            this.lbl_LLLine.Location = new System.Drawing.Point(288, 36);
            this.lbl_LLLine.Name = "lbl_LLLine";
            this.lbl_LLLine.Size = new System.Drawing.Size(100, 21);
            this.lbl_LLLine.TabIndex = 31;
            this.lbl_LLLine.Text = "Line";
            this.lbl_LLLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(965, 70);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(17, 16);
            this.pictureBox17.TabIndex = 23;
            this.pictureBox17.TabStop = false;
            // 
            // cmb_LLFactory
            // 
            this.cmb_LLFactory.AddItemSeparator = ';';
            this.cmb_LLFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LLFactory.Caption = "";
            this.cmb_LLFactory.CaptionHeight = 17;
            this.cmb_LLFactory.CaptionStyle = style49;
            this.cmb_LLFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LLFactory.ColumnCaptionHeight = 18;
            this.cmb_LLFactory.ColumnFooterHeight = 18;
            this.cmb_LLFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LLFactory.ContentHeight = 17;
            this.cmb_LLFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LLFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LLFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LLFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LLFactory.EditorHeight = 17;
            this.cmb_LLFactory.EvenRowStyle = style50;
            this.cmb_LLFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LLFactory.FooterStyle = style51;
            this.cmb_LLFactory.HeadingStyle = style52;
            this.cmb_LLFactory.HighLightRowStyle = style53;
            this.cmb_LLFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_LLFactory.Images"))));
            this.cmb_LLFactory.ItemHeight = 15;
            this.cmb_LLFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_LLFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_LLFactory.MaxDropDownItems = ((short)(5));
            this.cmb_LLFactory.MaxLength = 32767;
            this.cmb_LLFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LLFactory.Name = "cmb_LLFactory";
            this.cmb_LLFactory.OddRowStyle = style54;
            this.cmb_LLFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LLFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LLFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LLFactory.SelectedStyle = style55;
            this.cmb_LLFactory.Size = new System.Drawing.Size(140, 21);
            this.cmb_LLFactory.Style = style56;
            this.cmb_LLFactory.TabIndex = 14;
            this.cmb_LLFactory.SelectedValueChanged += new System.EventHandler(this.cmb_LLFactory_SelectedValueChanged);
            this.cmb_LLFactory.PropBag = resources.GetString("cmb_LLFactory.PropBag");
            // 
            // lbl_LLFactory
            // 
            this.lbl_LLFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_LLFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LLFactory.ImageIndex = 0;
            this.lbl_LLFactory.ImageList = this.img_Label;
            this.lbl_LLFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_LLFactory.Name = "lbl_LLFactory";
            this.lbl_LLFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_LLFactory.TabIndex = 13;
            this.lbl_LLFactory.Text = "Factory";
            this.lbl_LLFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(0, 70);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(168, 20);
            this.pictureBox18.TabIndex = 22;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(964, 24);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(18, 77);
            this.pictureBox19.TabIndex = 26;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox20.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(131, 69);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(982, 18);
            this.pictureBox20.TabIndex = 28;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(965, 0);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(21, 32);
            this.pictureBox21.TabIndex = 21;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox22.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(224, 0);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(982, 32);
            this.pictureBox22.TabIndex = 0;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox23.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(160, 24);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(982, 85);
            this.pictureBox23.TabIndex = 27;
            this.pictureBox23.TabStop = false;
            // 
            // lbl_SubTitle6
            // 
            this.lbl_SubTitle6.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle6.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle6.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle6.Image")));
            this.lbl_SubTitle6.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle6.Name = "lbl_SubTitle6";
            this.lbl_SubTitle6.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle6.TabIndex = 20;
            this.lbl_SubTitle6.Text = "      Line OpCd Information";
            this.lbl_SubTitle6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox24.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(0, 24);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(168, 85);
            this.pictureBox24.TabIndex = 25;
            this.pictureBox24.TabStop = false;
            // 
            // obarpg_LineOpMini
            // 
            this.obarpg_LineOpMini.Controls.Add(this.pnl_MLB);
            this.obarpg_LineOpMini.Name = "obarpg_LineOpMini";
            this.obarpg_LineOpMini.PageVisible = false;
            this.obarpg_LineOpMini.Size = new System.Drawing.Size(998, 496);
            this.obarpg_LineOpMini.Text = "Assign MiniLine to Operation";
            // 
            // pnl_MLB
            // 
            this.pnl_MLB.Controls.Add(this.fgrid_MiniLine);
            this.pnl_MLB.Controls.Add(this.pnl_MLBT);
            this.pnl_MLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MLB.Location = new System.Drawing.Point(0, 0);
            this.pnl_MLB.Name = "pnl_MLB";
            this.pnl_MLB.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_MLB.Size = new System.Drawing.Size(998, 496);
            this.pnl_MLB.TabIndex = 0;
            // 
            // fgrid_MiniLine
            // 
            this.fgrid_MiniLine.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_MiniLine.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_MiniLine.ContextMenu = this.cmenu_createline;
            this.fgrid_MiniLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_MiniLine.Location = new System.Drawing.Point(8, 81);
            this.fgrid_MiniLine.Name = "fgrid_MiniLine";
            this.fgrid_MiniLine.Rows.DefaultSize = 19;
            this.fgrid_MiniLine.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_MiniLine.Size = new System.Drawing.Size(982, 407);
            this.fgrid_MiniLine.StyleInfo = resources.GetString("fgrid_MiniLine.StyleInfo");
            this.fgrid_MiniLine.TabIndex = 50;
            this.fgrid_MiniLine.Click += new System.EventHandler(this.fgrid_MiniLine_Click);
            this.fgrid_MiniLine.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MiniLine_AfterEdit);
            this.fgrid_MiniLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_MiniLine_MouseDown);
            // 
            // pnl_MLBT
            // 
            this.pnl_MLBT.Controls.Add(this.panel3);
            this.pnl_MLBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MLBT.Location = new System.Drawing.Point(8, 8);
            this.pnl_MLBT.Name = "pnl_MLBT";
            this.pnl_MLBT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_MLBT.Size = new System.Drawing.Size(982, 73);
            this.pnl_MLBT.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.pictureBox11);
            this.panel3.Controls.Add(this.pictureBox13);
            this.panel3.Controls.Add(this.pictureBox14);
            this.panel3.Controls.Add(this.lbl_SubTitle5);
            this.panel3.Controls.Add(this.cmb_MLOpCd);
            this.panel3.Controls.Add(this.cmb_MLLineCd);
            this.panel3.Controls.Add(this.lbl_MLLine);
            this.panel3.Controls.Add(this.pictureBox9);
            this.panel3.Controls.Add(this.lbl_MLOpCd);
            this.panel3.Controls.Add(this.cmb_MLFactory);
            this.panel3.Controls.Add(this.lbl_MLFactory);
            this.panel3.Controls.Add(this.pictureBox10);
            this.panel3.Controls.Add(this.pictureBox12);
            this.panel3.Controls.Add(this.pictureBox15);
            this.panel3.Controls.Add(this.pictureBox16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 65);
            this.panel3.TabIndex = 20;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(964, 24);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(18, 32);
            this.pictureBox11.TabIndex = 26;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(965, 0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(21, 32);
            this.pictureBox13.TabIndex = 21;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(224, 0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(982, 32);
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;
            // 
            // lbl_SubTitle5
            // 
            this.lbl_SubTitle5.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle5.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle5.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle5.Image")));
            this.lbl_SubTitle5.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle5.Name = "lbl_SubTitle5";
            this.lbl_SubTitle5.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle5.TabIndex = 20;
            this.lbl_SubTitle5.Text = "      OP MiniLine";
            this.lbl_SubTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_MLOpCd
            // 
            this.cmb_MLOpCd.AddItemSeparator = ';';
            this.cmb_MLOpCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MLOpCd.Caption = "";
            this.cmb_MLOpCd.CaptionHeight = 17;
            this.cmb_MLOpCd.CaptionStyle = style57;
            this.cmb_MLOpCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MLOpCd.ColumnCaptionHeight = 18;
            this.cmb_MLOpCd.ColumnFooterHeight = 18;
            this.cmb_MLOpCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MLOpCd.ContentHeight = 17;
            this.cmb_MLOpCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MLOpCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MLOpCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLOpCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MLOpCd.EditorHeight = 17;
            this.cmb_MLOpCd.EvenRowStyle = style58;
            this.cmb_MLOpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLOpCd.FooterStyle = style59;
            this.cmb_MLOpCd.HeadingStyle = style60;
            this.cmb_MLOpCd.HighLightRowStyle = style61;
            this.cmb_MLOpCd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MLOpCd.Images"))));
            this.cmb_MLOpCd.ItemHeight = 15;
            this.cmb_MLOpCd.Location = new System.Drawing.Point(675, 36);
            this.cmb_MLOpCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_MLOpCd.MaxDropDownItems = ((short)(5));
            this.cmb_MLOpCd.MaxLength = 32767;
            this.cmb_MLOpCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MLOpCd.Name = "cmb_MLOpCd";
            this.cmb_MLOpCd.OddRowStyle = style62;
            this.cmb_MLOpCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MLOpCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MLOpCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MLOpCd.SelectedStyle = style63;
            this.cmb_MLOpCd.Size = new System.Drawing.Size(180, 21);
            this.cmb_MLOpCd.Style = style64;
            this.cmb_MLOpCd.TabIndex = 30;
            this.cmb_MLOpCd.SelectedValueChanged += new System.EventHandler(this.cmb_MLOpCd_SelectedValueChanged);
            this.cmb_MLOpCd.PropBag = resources.GetString("cmb_MLOpCd.PropBag");
            // 
            // cmb_MLLineCd
            // 
            this.cmb_MLLineCd.AddItemSeparator = ';';
            this.cmb_MLLineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MLLineCd.Caption = "";
            this.cmb_MLLineCd.CaptionHeight = 17;
            this.cmb_MLLineCd.CaptionStyle = style65;
            this.cmb_MLLineCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MLLineCd.ColumnCaptionHeight = 18;
            this.cmb_MLLineCd.ColumnFooterHeight = 18;
            this.cmb_MLLineCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MLLineCd.ContentHeight = 17;
            this.cmb_MLLineCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MLLineCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MLLineCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLLineCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MLLineCd.EditorHeight = 17;
            this.cmb_MLLineCd.EvenRowStyle = style66;
            this.cmb_MLLineCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLLineCd.FooterStyle = style67;
            this.cmb_MLLineCd.HeadingStyle = style68;
            this.cmb_MLLineCd.HighLightRowStyle = style69;
            this.cmb_MLLineCd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MLLineCd.Images"))));
            this.cmb_MLLineCd.ItemHeight = 15;
            this.cmb_MLLineCd.Location = new System.Drawing.Point(393, 36);
            this.cmb_MLLineCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_MLLineCd.MaxDropDownItems = ((short)(5));
            this.cmb_MLLineCd.MaxLength = 32767;
            this.cmb_MLLineCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MLLineCd.Name = "cmb_MLLineCd";
            this.cmb_MLLineCd.OddRowStyle = style70;
            this.cmb_MLLineCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MLLineCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MLLineCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MLLineCd.SelectedStyle = style71;
            this.cmb_MLLineCd.Size = new System.Drawing.Size(180, 21);
            this.cmb_MLLineCd.Style = style72;
            this.cmb_MLLineCd.TabIndex = 32;
            this.cmb_MLLineCd.SelectedValueChanged += new System.EventHandler(this.cmb_MLLineCd_SelectedValueChanged);
            this.cmb_MLLineCd.PropBag = resources.GetString("cmb_MLLineCd.PropBag");
            // 
            // lbl_MLLine
            // 
            this.lbl_MLLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MLLine.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MLLine.ImageIndex = 0;
            this.lbl_MLLine.ImageList = this.img_Label;
            this.lbl_MLLine.Location = new System.Drawing.Point(292, 36);
            this.lbl_MLLine.Name = "lbl_MLLine";
            this.lbl_MLLine.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLLine.TabIndex = 31;
            this.lbl_MLLine.Text = "Line";
            this.lbl_MLLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(965, 50);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(17, 16);
            this.pictureBox9.TabIndex = 23;
            this.pictureBox9.TabStop = false;
            // 
            // lbl_MLOpCd
            // 
            this.lbl_MLOpCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MLOpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MLOpCd.ImageIndex = 0;
            this.lbl_MLOpCd.ImageList = this.img_Label;
            this.lbl_MLOpCd.Location = new System.Drawing.Point(574, 36);
            this.lbl_MLOpCd.Name = "lbl_MLOpCd";
            this.lbl_MLOpCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLOpCd.TabIndex = 29;
            this.lbl_MLOpCd.Text = "Proc.";
            this.lbl_MLOpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_MLFactory
            // 
            this.cmb_MLFactory.AddItemSeparator = ';';
            this.cmb_MLFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MLFactory.Caption = "";
            this.cmb_MLFactory.CaptionHeight = 17;
            this.cmb_MLFactory.CaptionStyle = style73;
            this.cmb_MLFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MLFactory.ColumnCaptionHeight = 18;
            this.cmb_MLFactory.ColumnFooterHeight = 18;
            this.cmb_MLFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MLFactory.ContentHeight = 17;
            this.cmb_MLFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MLFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MLFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MLFactory.EditorHeight = 17;
            this.cmb_MLFactory.EvenRowStyle = style74;
            this.cmb_MLFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLFactory.FooterStyle = style75;
            this.cmb_MLFactory.HeadingStyle = style76;
            this.cmb_MLFactory.HighLightRowStyle = style77;
            this.cmb_MLFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MLFactory.Images"))));
            this.cmb_MLFactory.ItemHeight = 15;
            this.cmb_MLFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_MLFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_MLFactory.MaxDropDownItems = ((short)(5));
            this.cmb_MLFactory.MaxLength = 32767;
            this.cmb_MLFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MLFactory.Name = "cmb_MLFactory";
            this.cmb_MLFactory.OddRowStyle = style78;
            this.cmb_MLFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MLFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MLFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MLFactory.SelectedStyle = style79;
            this.cmb_MLFactory.Size = new System.Drawing.Size(180, 21);
            this.cmb_MLFactory.Style = style80;
            this.cmb_MLFactory.TabIndex = 14;
            this.cmb_MLFactory.SelectedValueChanged += new System.EventHandler(this.cmb_MLFactory_SelectedValueChanged);
            this.cmb_MLFactory.PropBag = resources.GetString("cmb_MLFactory.PropBag");
            // 
            // lbl_MLFactory
            // 
            this.lbl_MLFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MLFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MLFactory.ImageIndex = 1;
            this.lbl_MLFactory.ImageList = this.img_Label;
            this.lbl_MLFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_MLFactory.Name = "lbl_MLFactory";
            this.lbl_MLFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLFactory.TabIndex = 13;
            this.lbl_MLFactory.Text = "Factory";
            this.lbl_MLFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 50);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(168, 20);
            this.pictureBox10.TabIndex = 22;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(131, 49);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(982, 18);
            this.pictureBox12.TabIndex = 28;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(160, 24);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(982, 65);
            this.pictureBox15.TabIndex = 27;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(0, 24);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(168, 65);
            this.pictureBox16.TabIndex = 25;
            this.pictureBox16.TabStop = false;
            // 
            // img_LongButton
            // 
            this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
            this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongButton.Images.SetKeyName(0, "");
            this.img_LongButton.Images.SetKeyName(1, "");
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.obar_Main);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel2.Size = new System.Drawing.Size(1014, 576);
            this.panel2.TabIndex = 29;
            // 
            // Form_PB_Line
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.panel2);
            this.Name = "Form_PB_Line";
            this.Text = "VSM Line";
            this.Load += new System.EventHandler(this.Form_PB_Line_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
            this.obar_Main.ResumeLayout(false);
            this.obarpg_Line.ResumeLayout(false);
            this.pnl_LBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Line)).EndInit();
            this.pnl_LSearchSplitLeft.ResumeLayout(false);
            this.pnl_SearchLeftImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBL)).EndInit();
            this.pnl_LBodyRight.ResumeLayout(false);
            this.pnl_DisplayImage.ResumeLayout(false);
            this.pnl_DisplayImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_DML)).EndInit();
            this.obarpg_LineOpLeadTime.ResumeLayout(false);
            this.pnl_LLB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_LineOpLT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LLLineCd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ApplyYMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LTCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ApplyYMDCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LLLineCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LLFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            this.obarpg_LineOpMini.ResumeLayout(false);
            this.pnl_MLB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MiniLine)).EndInit();
            this.pnl_MLBT.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLOpCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLLineCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion


		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();

		private DataTable MiniHeadDT = new DataTable("MiniHeadTitle");
		private DataTable RSCHeadDT = new DataTable("RSCHeadTitle");
 
		#endregion

		#region 멤버 메서드

  
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			DataTable dt_ret;
			DataRow datarow;
			CellStyle cellst;

			//Title
			this.Text = "VSM Line Information";
			this.lbl_MainTitle.Text = "VSM Line Information"; 

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


//			cmb_LFactory.Enabled = false;
//			cmb_MLFactory.Enabled = false;
//			cmb_LLFactory.Enabled = false;


			fgrid_Line.Set_Grid("LINE_CODE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			fgrid_Line.Set_Action_Image(img_Action);
 

			//대표 라인에 해당되는 세부라인 정의
			//SPB_LINEOP_MIN
			cmb_MLOpCd.Enabled = false;

			fgrid_MiniLine.Set_Grid("SPB_LINEOP_MINI", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_MiniLine.Set_Action_Image(img_Action); 

			cellst = fgrid_MiniLine.Styles.Add("MASK");
			cellst.DataType = typeof(string);		 
			cellst.EditMask = "00D00H00M"; 

			fgrid_MiniLine.Cols[(int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxWORK_TIME].Style = fgrid_MiniLine.Styles["MASK"];

			//-------------------------------------------------------
			//첫번째 행 헤더 정보 저장 (실제 디비 필드명)
  
			for(int i = 0; i < fgrid_MiniLine.Cols.Count; i++)
			{
				MiniHeadDT.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			} 

			datarow = MiniHeadDT.NewRow();
				 
			for(int i = 1; i < fgrid_MiniLine.Cols.Count; i++)
			{ 
				datarow[i] = "ARG_" + fgrid_MiniLine[0, i].ToString(); 

				//첫번째 행에 두번째 행 정보 저장 (그리드 타이틀)
				fgrid_MiniLine[0, i] = fgrid_MiniLine[1, i].ToString();
			} 
			 
			MiniHeadDT.Rows.Add(datarow);

			fgrid_MiniLine.Rows[0].Visible = true;
			fgrid_MiniLine.Rows[1].Visible = false;

			//-------------------------------------------------------



			//공정 라인 리드타임 정의
			//SPB_LINEOP_LEADTIME  
			fgrid_LineOpLT.Set_Grid("SPB_LINEOP_LEADTIME", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_LineOpLT.Set_Action_Image(img_Action); 
 
//			cellst = fgrid_LineOpLT.Styles.Add("MASK_D");
//			cellst.DataType = typeof(string);		 
//			cellst.EditMask = "00D"; 
//
//			cellst = fgrid_LineOpLT.Styles.Add("MASK_H");
//			cellst.DataType = typeof(string);		 
//			cellst.EditMask = "00D00H"; 


			fgrid_LineOpLT.Styles.Add("MASK_D").DataType = typeof(string);
			fgrid_LineOpLT.Styles.Add("MASK_D").EditMask = "00D"; 

			fgrid_LineOpLT.Styles.Add("MASK_H").DataType = typeof(string);
			fgrid_LineOpLT.Styles.Add("MASK_H").EditMask = "00D00H"; 





			btn_Copy.Enabled = false; 
			cmb_ApplyYMDCopy.Visible = false;
			btn_ApplyCopy.Visible = false; 

			btn_LineCopy.Enabled = false; 
			cmb_LLLineCd1.Visible = false;
			btn_ApplyCopyLine.Visible = false; 
  
			//Factory
			dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);  
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LLFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);  

			cmb_LFactory.SelectedValue = ClassLib.ComVar.This_Factory;  
			cmb_MLFactory.SelectedValue = ClassLib.ComVar.This_Factory;  
			cmb_LLFactory.SelectedValue = ClassLib.ComVar.This_Factory; 

			obar_Main.SelectedPage = obarpg_Line;

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
 
			try
			{
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{

					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 

					if(arg_fgrid.Equals(fgrid_Line))
					{ 
						//라인 그룹별 색깔 표시 
						if(arg_fgrid[i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINE.IxLINE_COLOR].ToString() != "")
							arg_fgrid.GetCellRange(i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINE.IxLINE_CD, 
								i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINE.IxLINE_NAME).StyleNew.BackColor 
								= Color.FromArgb(Convert.ToInt32(arg_fgrid[i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINE.IxLINE_COLOR].ToString()) );

						
					}

					if(arg_fgrid.Equals(fgrid_LineOpLT))
					{

						//데이터 없으면 글자색 빨간색으로 표시
						if(arg_fgrid[i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxEXIST_YN].ToString() == "N")
						{
							arg_fgrid.Rows[i +  arg_fgrid.Rows.Fixed].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;

							arg_fgrid[i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLINE_CD] = cmb_LLLineCd.SelectedValue.ToString();
							arg_fgrid[i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEADTIME_CD] = cmb_LTCd.SelectedValue.ToString();
							arg_fgrid[i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxAPPLY_YMD] = cmb_ApplyYMD.SelectedValue.ToString();
							arg_fgrid[i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEADTIME_DESC] = cmb_LTCd.Columns[1].Text;
							arg_fgrid[i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxDEFAULT_YN] = chk_DefaultYN.Checked.ToString();


						}

						//공정에 공정색깔 표시
						if(arg_fgrid[i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOP_COLOR].ToString() != "")
							arg_fgrid.GetCellRange(i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOP_CD).StyleNew.BackColor 
								= Color.FromArgb(Convert.ToInt32(arg_fgrid[i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOP_COLOR].ToString()) );


						//otu 에 따라서 포맷 변경
						switch (arg_fgrid[i +  arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOTU].ToString() )
						{
							case "D":
								for(int a = (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME; a <= (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME; a++)
								{
									arg_fgrid.Cols[a].Style = fgrid_LineOpLT.Styles["MASK_D"]; 
								}
									
								break;

							case "H":
								for(int a = (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME; a <= (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME; a++)
								{
									arg_fgrid.Cols[a].Style = fgrid_LineOpLT.Styles["MASK_H"];
								}
									
								break;

							default:
								for(int a = (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME; a <= (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME; a++)
								{
									arg_fgrid.Cols[a].StyleNew.Format = "";
								}
								break;

						} // end switch


					}


				} 


				arg_fgrid.AutoSizeCols();
			}
			catch
			{
			}
 
		}



		
		/// <summary>
		/// Display_TreeGrid_Mini :세부라인 트리 형태로 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_TreeGrid_Mini(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			 
			CellRange cellrg; 
			
			int level = (int)ClassLib.TBSPB_LINEOP_MINI.IxLEVEL;

			int grid_cd = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxCODE;
			int grid_name = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxNAME;
			int grid_linecd = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLINE_CD;
			int grid_linemame = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLINE_NAME;
			int grid_opcd = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_CD;
			int grid_opname = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_NAME;
			int grid_opline = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_LINE;
			int grid_oplinename = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_LINE_NAME; 
			int grid_level = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL;
			int grid_factory = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxFACTORY; 
			int grid_groupid = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxGROUP_ID;
			int grid_reallinecd = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxREAL_LINE_CD;
			int grid_areacd = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxAREA_CD;
			int grid_outyn = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOUT_YN;
			int grid_maxcapa = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMAX_CAPA;
			int grid_stdcapa = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxSTD_CAPA;
			int grid_mincapa = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMIN_CAPA;
			int grid_procunit = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxPROC_UNIT;
			int grid_worktime = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxWORK_TIME;
			int grid_remarks = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxREMARKS;
			int grid_existyn = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxEXIST_YN;
			int grid_mlineqty = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMLINE_QTY;
  
			try
			{
				arg_fgrid.Tree.Column = grid_cd;
				arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;
				arg_fgrid.Cols.Count = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMaxCt + 1;

				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.Rows.InsertNode(i + arg_fgrid.Rows.Fixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[level].ToString()) - 1);

					arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = "";

					switch(arg_dt.Rows[i].ItemArray[level].ToString())
					{
						case "1":
							arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxLINE_CD].ToString();
							arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_name] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxLINE_NAME].ToString();
							break;

						case "2":    //op
							arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxOP_CD].ToString();
							arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_name] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxOP_NAME].ToString();

							arg_fgrid.Rows[i + arg_fgrid.Rows.Fixed].StyleNew.BackColor = ClassLib.ComVar.ClrLightSel;
							break;

						case "3":   //opline
							arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxOP_LINE].ToString();
							arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_name] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxOP_LINE_NAME].ToString();
						 
							cellrg = arg_fgrid.GetCellRange(i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxCODE, i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxNAME);

							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxEXIST_YN].ToString() != "")
							{
								if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxEXIST_YN].ToString() == "N")
									cellrg.StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
								else
									cellrg.StyleNew.ForeColor = ClassLib.ComVar.ClrImportant;
							}
						
						 
							break;


					}

					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_linecd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxLINE_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_linemame] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxLINE_NAME].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxOP_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opname] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxOP_NAME].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opline] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxOP_LINE].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_oplinename] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxOP_LINE_NAME].ToString();
				
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_level] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxLEVEL].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_factory] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxFACTORY].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_groupid] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxGROUP_ID].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_reallinecd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxREAL_LINE_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_areacd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxAREA_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_outyn] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxOUT_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_maxcapa] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxMAX_CAPA].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_stdcapa] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxSTD_CAPA].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_mincapa] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxMIN_CAPA].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_procunit] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxPROC_UNIT].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_worktime] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxWORK_TIME].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_remarks] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxREMARKS].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_existyn] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxEXIST_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_mlineqty] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LINEOP_MINI.IxMLINE_QTY].ToString();
   
					arg_fgrid.AutoSizeCols(); 
					arg_fgrid.Tree.Style = TreeStyleFlags.Complete;
 
				} // end for i
			} 
			catch
			{
			}
 

		}
		

 
		/// <summary>
		/// Check_LineOp_Mini_Capa : 미니라인 총 capa = 공정 capa 일치여부 체크
		/// </summary>
		/// <returns></returns>
		private bool Check_LineOp_Mini_Capa()
		{

			int start_row = 0;
			int opcd_row = 0, opcd_level = 0, mline_qty = 0;
			int opcd_mincapa = 0, opcd_stdcapa = 0, opcd_maxcapa = 0;
			string mincapa = "", stdcapa = "", maxcapa = "";
			int sum_mincapa = 0, sum_stdcapa = 0, sum_maxcapa = 0;

			bool return_value = false;
			bool continue_flag = true;

			try
			{
			
				start_row = fgrid_MiniLine.Rows.Fixed;

				while(true)
				{
					if(!continue_flag) break;
 
					//공정 capa 
					for(int i = start_row; i < fgrid_MiniLine.Rows.Count; i++)
					{
						if(fgrid_MiniLine[i, 0].ToString() == "") continue;

						//opcd_row = i - 1;

						for(int j = i - 1; j >= fgrid_MiniLine.Rows.Fixed; j--)
						{
							if( Convert.ToInt32(fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL].ToString())
								> Convert.ToInt32(fgrid_MiniLine[j, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL].ToString()) )
							{
								opcd_row = j;
								break;
							}
						}

						opcd_level = Convert.ToInt32(fgrid_MiniLine[opcd_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL].ToString());
						mline_qty = Convert.ToInt32(fgrid_MiniLine[opcd_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMLINE_QTY].ToString());

						//모두 delete 될 상태면 체크 필요 없음  
						if(mline_qty == 0) continue_flag = false;

						opcd_mincapa = Convert.ToInt32(fgrid_MiniLine[opcd_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMIN_CAPA].ToString());
						opcd_stdcapa = Convert.ToInt32(fgrid_MiniLine[opcd_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxSTD_CAPA].ToString());
						opcd_maxcapa = Convert.ToInt32(fgrid_MiniLine[opcd_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMAX_CAPA].ToString());

						break;

					} // end for i = start_row


					if(!continue_flag)
					{
						return_value = true;
						break;
					}
 


					//미니라인 총 capa
					for(int i = opcd_row + 1; i < fgrid_MiniLine.Rows.Count; i++)
					{
						if(Convert.ToInt32(fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL].ToString()) <= opcd_level) 
						{
							start_row = i;
							break;
						}

						if(fgrid_MiniLine[i, 0].ToString() == "D") continue;
				
						mincapa = (fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMIN_CAPA].ToString() == "") ? "0" : fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMIN_CAPA].ToString();
						stdcapa = (fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxSTD_CAPA].ToString() == "") ? "0" : fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxSTD_CAPA].ToString();
						maxcapa = (fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMAX_CAPA].ToString() == "") ? "0" : fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMAX_CAPA].ToString();

						sum_mincapa += Convert.ToInt32(mincapa);
						sum_stdcapa += Convert.ToInt32(stdcapa);
						sum_maxcapa += Convert.ToInt32(maxcapa);


					} // end for i = opcd_row + 1


					if(opcd_mincapa != sum_mincapa || opcd_stdcapa != sum_stdcapa || opcd_maxcapa != sum_maxcapa)
					{
						fgrid_MiniLine.GetCellRange(opcd_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMAX_CAPA, 
							start_row - 1, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMIN_CAPA).StyleNew.BackColor = ClassLib.ComVar.ClrLightSel;

						return_value = false;
					}
					else
					{
						return_value = true;
					}


 
					//종료 조건
					for(int i = start_row + 1; i < fgrid_MiniLine.Rows.Count; i++)
					{
						if(fgrid_MiniLine[i, 0].ToString() != "")
							continue_flag = true;
						else
							continue_flag = false;
					}



				} // end while(true)



				return return_value;

			}
			catch
			{
				return false;
			}
 

		}
 


		#endregion

		#region 이벤트 처리


		#region 공통 이벤트

		
		private void obar_Main_SelectedPageChanged(object sender, System.EventArgs e)
		{
 
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Line":

					tbtn_Append.Enabled = true;
					tbtn_Insert.Enabled = true;
 		  
					break;

				default:

					tbtn_Append.Enabled = false;
					tbtn_Insert.Enabled = false;
 
					break;  
			}

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			if(src.Equals(btn_CreateLTCd) || src.Equals(btn_CreateApplyYMD))
				src.ImageIndex = 3;
			else
				src.ImageIndex = 1;

		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			
			if(src.Equals(btn_CreateLTCd) || src.Equals(btn_CreateApplyYMD))
				src.ImageIndex = 2;
			else
				src.ImageIndex = 0;
		}

 
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Line":
					//cmb_LFactory.SelectedIndex = -1;
					fgrid_Line.Rows.Count = fgrid_Line.Rows.Fixed;

					txt_LCode.Text = "";
					txt_LName.Text = "";
					txt_LCharge.Text = "";
					txt_LMaxCapa.Text = "";
					txt_LStdCapa.Text = "";
					txt_LMinCapa.Text = "";
					txt_LProcUnit.Text = "";
					txt_LLineType.Text = "";
					txt_LRoutType.Text = "";
					chk_LViewYN.Checked = false;
					txt_LRemarks.Text = "";

					break;
 
				case "obarpg_LineOpMini": 
					
					//cmb_MLFactory.SelectedIndex = -1;
					//cmb_MLLineCd.SelectedIndex = -1;
					//cmb_MLOpCd.SelectedIndex = -1;

					fgrid_MiniLine.Rows.Count = fgrid_MiniLine.Rows.Fixed;


					break;

				case "obarpg_LineOpLeadTime": 

					//cmb_LLFactory.SelectedIndex = -1;

					cmb_LLLineCd.SelectedIndex = -1; 
					cmb_LTCd.SelectedIndex = -1;
					cmb_ApplyYMD.SelectedIndex = -1;

					fgrid_LineOpLT.Rows.Count = fgrid_LineOpLT.Rows.Fixed;

					btn_Copy.Enabled = false; 
					btn_Copy.Text = "Copy";
					cmb_ApplyYMDCopy.Visible = false;
					cmb_ApplyYMDCopy.SelectedIndex = -1;
					btn_ApplyCopy.Visible = false; 

					btn_LineCopy.Enabled = false; 
					btn_LineCopy.Text = "Copy";
					cmb_LLLineCd1.Visible = false;
					cmb_LLLineCd1.SelectedIndex = -1;
					btn_ApplyCopyLine.Visible = false; 


					break; 
			}
		}



		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			try
			{
				switch(obar_Main.SelectedPage.Name)
				{
					case "obarpg_Line":
						if(cmb_LFactory.SelectedIndex == -1) return;
					 
						dt_ret = Select_SPB_LINE(cmb_LFactory.SelectedValue.ToString()); 
						Display_Grid(dt_ret, fgrid_Line); 
 
						break;
 
					case "obarpg_LineOpMini":
					 
						if(cmb_MLFactory.SelectedIndex == -1) return;

						this.Cursor = Cursors.WaitCursor;

						dt_ret = Select_SPB_LINEOP_MINI();
						Display_TreeGrid_Mini(dt_ret, fgrid_MiniLine); 
 
						this.Cursor = Cursors.Default;

						break;

					case "obarpg_LineOpLeadTime":

						if(cmb_LLFactory.SelectedIndex == -1 || cmb_LLLineCd.SelectedIndex == -1 
							|| cmb_LTCd.SelectedIndex == -1 || cmb_ApplyYMD.SelectedIndex == -1 ) return;
 
						btn_Copy.Enabled = false; 
						btn_Copy.Text = "Copy";
						cmb_ApplyYMDCopy.Visible = false;
						cmb_ApplyYMDCopy.SelectedIndex = -1;
						btn_ApplyCopy.Visible = false; 

						btn_LineCopy.Enabled = false; 
						btn_LineCopy.Text = "Copy";
						cmb_LLLineCd1.Visible = false;
						cmb_LLLineCd1.SelectedIndex = -1;
						btn_ApplyCopyLine.Visible = false; 

						dt_ret = Select_SPB_LINEOP_LEADTIME();
						Display_Grid(dt_ret, fgrid_LineOpLT);  
 
						break; 

				}
			}
			catch
			{
			}
		}



		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;
			bool save_rtn;
			int sel_row;

			try
			{
				switch(obar_Main.SelectedPage.Name)
				{
					case "obarpg_Line":
 
						if(cmb_LFactory.SelectedIndex != -1)
						{
							//행 수정 상태 해제
							fgrid_Line.Select(fgrid_Line.Selection.r1, 0, fgrid_Line.Selection.r1, fgrid_Line.Cols.Count-1, false);
 
							MyOraDB.Save_FlexGird("PKG_SPB_LINE.SAVE_SPB_LINE", fgrid_Line); 

							dt_ret = Select_SPB_LINE(cmb_LFactory.SelectedValue.ToString()); 
							Display_Grid(dt_ret, fgrid_Line); 
						}
 
						break; 

					case "obarpg_LineOpMini": 
					  
						sel_row = fgrid_MiniLine.Selection.r1;

						//행 수정 상태 해제
						fgrid_MiniLine.Select(fgrid_MiniLine.Selection.r1, 0, fgrid_MiniLine.Selection.r1, fgrid_MiniLine.Cols.Count-1, false);
  
						this.Cursor = Cursors.WaitCursor;

						save_rtn = Save_SPB_LINEOP_MINI();

						if(save_rtn)
						{
							dt_ret = Select_SPB_LINEOP_MINI();
							Display_TreeGrid_Mini(dt_ret, fgrid_MiniLine);
							fgrid_MiniLine.TopRow = sel_row;
						}

						this.Cursor = Cursors.Default; 

						break;

					case "obarpg_LineOpLeadTime":

						//행 수정 상태 해제
						fgrid_LineOpLT.Select(fgrid_LineOpLT.Selection.r1, 0, fgrid_LineOpLT.Selection.r1, fgrid_LineOpLT.Cols.Count-1, false); 
				
						// 00D00H00M 형식으로 맞추기
						Set_TimeFormat(); 

						Save_SPB_LINEOP_LEADTIME();
						dt_ret = Select_SPB_LINEOP_LEADTIME();  
						Display_Grid(dt_ret, fgrid_LineOpLT); 

						break;
 
				}
			}
			catch
			{
			}
		}


		/// <summary>
		/// Set_TimeFormat : 00D00H00M 형식으로 맞추기
		/// </summary>
		private void Set_TimeFormat()
		{
			try
			{
				for(int i = fgrid_LineOpLT.Rows.Fixed; i < fgrid_LineOpLT.Rows.Count; i++)
				{
					if(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOTU].ToString() == "") continue;
 
					switch(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOTU].ToString() )
					{
						case "D":
 
							if(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME] == null
								|| fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME].ToString() == "" )
							{
								 fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME] = "00D";
							}

							if(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSETUP_TIME] == null
								|| fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSETUP_TIME].ToString() == "" )
							{
								fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSETUP_TIME] = "00D";
							}

							if(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxPROCESS_TIME] == null
								|| fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxPROCESS_TIME].ToString() == "" )
							{
								fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxPROCESS_TIME] = "00D";
							}

							if(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxWAITTING_TIME] == null
								|| fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxWAITTING_TIME].ToString() == "" )
							{
								fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxWAITTING_TIME] = "00D";
							}

							if(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME] == null
								|| fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME].ToString() == "" )
							{
								fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME] = "00D";
							}


							fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME_SV]
								= fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME].ToString() + "00H00M";

							fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSETUP_TIME_SV]
								= fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSETUP_TIME].ToString() + "00H00M";

							fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxPROCESS_TIME_SV]
								= fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxPROCESS_TIME].ToString() + "00H00M";

							fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxWAITTING_TIME_SV]
								= fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxWAITTING_TIME].ToString() + "00H00M";

							fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME_SV]
								= fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME].ToString() + "00H00M";

							break;

						case "H":

							if(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME] == null
								|| fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME].ToString() == "" )
							{
								fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME] = "00D00H";
							}

							
							if(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSETUP_TIME] == null
								|| fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSETUP_TIME].ToString() == "" )
							{
								fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSETUP_TIME] = "00D00H";
							}

							if(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxPROCESS_TIME] == null
								|| fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxPROCESS_TIME].ToString() == "" )
							{
								fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxPROCESS_TIME] = "00D00H";
							}

							if(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxWAITTING_TIME] == null
								|| fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxWAITTING_TIME].ToString() == "" )
							{
								fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxWAITTING_TIME] = "00D00H";
							}

							if(fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME] == null
								|| fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME].ToString() == "" )
							{
								fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME_SV] = "00D00H";
							}


							fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME_SV]
								= fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME].ToString() + "00M";

							fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSETUP_TIME_SV]
								= fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSETUP_TIME].ToString() + "00M";

							fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxPROCESS_TIME_SV]
								= fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxPROCESS_TIME].ToString() + "00M";

							fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxWAITTING_TIME_SV]
								= fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxWAITTING_TIME].ToString() + "00M";

							fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME_SV]
								= fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME].ToString() + "00M";

							break; 
					}
				} // end for

			}
			catch
			{
			}
		}




		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				switch(obar_Main.SelectedPage.Name)
				{
					case "obarpg_Line":
						fgrid_Line.Add_Row(fgrid_Line.Rows.Count - 1); 
						fgrid_Line[fgrid_Line.Rows.Count - 1, (int)ClassLib.TBSPB_LINE.IxFACTORY] = cmb_LFactory.SelectedValue.ToString();
						break; 
				}
			}
			catch
			{
			}

		}
  

		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				switch(obar_Main.SelectedPage.Name)
				{
					case "obarpg_Line":
						fgrid_Line.Add_Row(fgrid_Line.Selection.r1); 
						fgrid_Line[fgrid_Line.Selection.r1, (int)ClassLib.TBSPB_LINE.IxFACTORY] = cmb_LFactory.SelectedValue.ToString(); 
						break;
 
				}
			}
			catch
			{
			}
		}



		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			int start_row, end_row; 

			try
			{
				switch(obar_Main.SelectedPage.Name)
				{
					case "obarpg_Line":
						fgrid_Line.Delete_Row(); 
						break;
 
					case "obarpg_LineOpMini": 

							switch(Convert.ToInt32(fgrid_MiniLine[fgrid_MiniLine.Selection.r1, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL].ToString()))
							{
								case 2:    //공정의 미니라인 모두 삭제

									int mline_qty = 0;  

									mline_qty = Convert.ToInt32(fgrid_MiniLine[fgrid_MiniLine.Selection.r1, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMLINE_QTY].ToString());

									start_row = fgrid_MiniLine.Selection.r1 + 1;
									end_row = start_row + mline_qty - 1; 

									for(int i = end_row; i >= start_row;  i--) 
									{
										if(fgrid_MiniLine[i, 0].ToString() == "I") 
											fgrid_MiniLine.Rows.Remove(i); 
										else
											fgrid_MiniLine[i, 0] = "D"; 
									}

									fgrid_MiniLine[fgrid_MiniLine.Selection.r1, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMLINE_QTY] = "0";


									break;

								case 3:    //미니라인만 삭제
				 
									int sel_r1 = fgrid_MiniLine.Selection.r1;
									int sel_r2 = fgrid_MiniLine.Selection.r2; 
									int delete_count = 0;
									int old_mline_qty = 0;

									start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
									end_row = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

									for(int i = end_row; i >= start_row;  i--) 
									{
										if(fgrid_MiniLine[i, 0].ToString() == "I") 
											fgrid_MiniLine.Rows.Remove(i); 
										else
											fgrid_MiniLine[i, 0] = "D";

									} 
										
									for(int i = start_row - 1; i >= fgrid_MiniLine.Rows.Fixed; i--)
									{
										if( Convert.ToInt32(fgrid_MiniLine[start_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL].ToString())
											> Convert.ToInt32(fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL].ToString()) )
										{
											delete_count = end_row - start_row + 1;
											old_mline_qty = Convert.ToInt32(fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMLINE_QTY].ToString());

											fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMLINE_QTY] = Convert.ToString(old_mline_qty - delete_count);

											break; 
										} 
									} 
			 
									break;

							} // end switch

							 
						break;

					case "obarpg_LineOpLeadTime":

						fgrid_LineOpLT.Delete_Row(); 

						break; 
			
				} // end switch

  
 
			}
			catch
			{
			}

		}


		
		private void tbtn_Color_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Line":

					Set_Color();
 		  
					break; 
			}
		}


		/// <summary>
		/// Set_Color : 라인 그룹별 색깔 지정
		/// </summary>
		private void Set_Color()
		{
			ColorDialog clrdig = new ColorDialog(); 

			int r1 = fgrid_Line.Selection.r1;
			int r2 = fgrid_Line.Selection.r2;  

			int from_row = (r1 < r2) ? r1 : r2;
			int to_row = (r1 < r2) ? r2 : r1;

			if(clrdig.ShowDialog() == DialogResult.OK)
			{
				for(int i = from_row; i <= to_row; i++)
				{
					fgrid_Line[i, (int)ClassLib.TBSPB_LINE.IxLINE_COLOR] = clrdig.Color.ToArgb().ToString(); 
					if(fgrid_Line[i, 0].ToString() == "") fgrid_Line[i, 0] = "U"; 
					fgrid_Line.GetCellRange(i, (int)ClassLib.TBSPB_LINE.IxLINE_CD, i, (int)ClassLib.TBSPB_LINE.IxLINE_NAME).StyleNew.BackColor = clrdig.Color;
				} //end for
			} // end if 

		}
		

		#endregion
 
 

		#region 라인 정보

		private void cmb_LFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_LFactory.SelectedIndex == -1) return;
			 
				dt_ret = Select_SPB_LINE(cmb_LFactory.SelectedValue.ToString()); 
				Display_Grid(dt_ret, fgrid_Line); 
			}
			catch
			{
			}
			 
		}


		private void fgrid_Line_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Line.Update_Row(fgrid_Line.Selection.r1);	
		}


		private void fgrid_Line_Click(object sender, System.EventArgs e)
		{
			int sel_row = fgrid_Line.Selection.r1;

			try
			{
				if(sel_row >= fgrid_Line.Rows.Fixed)
				{
					txt_LCode.Text = fgrid_Line[sel_row, (int)ClassLib.TBSPB_LINE.IxLINE_CD].ToString();
					txt_LName.Text = fgrid_Line[sel_row, (int)ClassLib.TBSPB_LINE.IxLINE_NAME].ToString();
					txt_LCharge.Text = fgrid_Line[sel_row, (int)ClassLib.TBSPB_LINE.IxLINE_MANAGER].ToString();
					txt_LMaxCapa.Text = fgrid_Line[sel_row, (int)ClassLib.TBSPB_LINE.IxMAX_CAPA].ToString(); 
					txt_LStdCapa.Text = fgrid_Line[sel_row, (int)ClassLib.TBSPB_LINE.IxSTD_CAPA].ToString();
					txt_LMinCapa.Text = fgrid_Line[sel_row, (int)ClassLib.TBSPB_LINE.IxMIN_CAPA].ToString();
					txt_LProcUnit.Text = fgrid_Line[sel_row, (int)ClassLib.TBSPB_LINE.IxPROD_UNIT].ToString();
					txt_LLineType.Text = fgrid_Line[sel_row, (int)ClassLib.TBSPB_LINE.IxLINE_GROUP].ToString();
					txt_LRoutType.Text = fgrid_Line[sel_row, (int)ClassLib.TBSPB_LINE.IxROUT_TYPE].ToString();
					chk_LViewYN.Checked = Convert.ToBoolean(fgrid_Line[sel_row, (int)ClassLib.TBSPB_LINE.IxMLINE_YN].ToString());
					txt_LRemarks.Text = fgrid_Line[sel_row, (int)ClassLib.TBSPB_LINE.IxREMARKS].ToString();
				}
			}
			catch
			{
				return;
			}


		}

 
		private void btn_CreateLineGroup_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_CreateLineGroup.ImageIndex = 5;
		}

		private void btn_CreateLineGroup_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_CreateLineGroup.ImageIndex = 4;
		}

		private void btn_CreateLineGroup_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_LFactory.SelectedIndex == -1) return;

				COM.APSWinForm.Form_CM_CodeAdd pop_form = new COM.APSWinForm.Form_CM_CodeAdd();
				ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_LFactory.SelectedValue.ToString(), ClassLib.ComVar.CxLineType, ""};
				pop_form.ShowDialog(); 

				fgrid_Line.Set_Grid("LINE_CODE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
				dt_ret = Select_SPB_LINE(cmb_LFactory.SelectedValue.ToString()); 
				Display_Grid(dt_ret, fgrid_Line); 
   
			}
			catch
			{
			}
		}

		#endregion 
	 
		#region 공정라인에 대한 세부라인 정의

		private void cmb_MLFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_MLFactory.SelectedIndex == -1) return;

				dt_ret = Select_SPB_LINE(cmb_MLFactory.SelectedValue.ToString());
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLLineCd, 1, 2, true, COM.ComVar.ComboList_Visible.Name);

				//cmb_MLLineCd.SelectedIndex = 0;

				dt_ret = Select_SPB_OPCD_CMB(cmb_MLFactory.SelectedValue.ToString());
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLOpCd, 0, 1, true);
				cmb_MLOpCd.SelectedValue = ClassLib.ComVar.StdOpCd;

			}
			catch
			{
			}

		}

		private void cmb_MLLineCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
//			DataTable dt_ret;
//
//			try
//			{
//				if(cmb_MLFactory.SelectedIndex == -1 || cmb_MLLineCd.SelectedIndex == -1) return;
//
//				dt_ret = Select_LINEOP_LIST_CMB(cmb_MLFactory.SelectedValue.ToString(), cmb_MLLineCd.SelectedValue.ToString());
//				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLOpCd, 0, 1, true);
//
//				cmb_MLOpCd.SelectedIndex = 0;
//			}
//			catch
//			{
//			}

		}


		private void cmb_MLOpCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_MLFactory.SelectedIndex == -1 || cmb_MLLineCd.SelectedIndex == -1 || cmb_MLOpCd.SelectedIndex == -1) return;

				this.Cursor = Cursors.WaitCursor;

				dt_ret = Select_SPB_LINEOP_MINI();
				Display_TreeGrid_Mini(dt_ret, fgrid_MiniLine); 
 
				this.Cursor = Cursors.Default;
			}
			catch
			{
			}

		}

		private void fgrid_MiniLine_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_MiniLine.Update_Row(fgrid_MiniLine.Selection.r1);	
			fgrid_MiniLine[fgrid_MiniLine.Selection.r1, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_LINE_NAME] = fgrid_MiniLine[fgrid_MiniLine.Selection.r1, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxNAME].ToString();

			fgrid_MiniLine.AutoSizeCols();
		}


		private void fgrid_MiniLine_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(fgrid_MiniLine[fgrid_MiniLine.Selection.r1, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL].ToString() != "3")
					fgrid_MiniLine.Rows[fgrid_MiniLine.Selection.r1].AllowEditing = false;
				else
				{
					fgrid_MiniLine.Rows[fgrid_MiniLine.Selection.r1].AllowEditing = true;

					if(Convert.ToBoolean(fgrid_MiniLine[fgrid_MiniLine.Selection.r1, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOUT_YN].ToString()) )
						fgrid_MiniLine.Cols[(int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxGROUP_ID].AllowEditing = false;
					else
						fgrid_MiniLine.Cols[(int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxGROUP_ID].AllowEditing = true;
				}
			}
			catch
			{
			}
		}

	

		private void fgrid_MiniLine_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{

			try
			{
				if(e.Button != MouseButtons.Right) return;
			 

				switch(fgrid_MiniLine[fgrid_MiniLine.Selection.r1, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL].ToString())
				{
					case "2":

						fgrid_MiniLine.ContextMenu = cmenu_createline;
						menuItem_CreateLine.Visible = true;
						menuItem_Group.Visible = false;

						break;

//					case "3":
//
//						fgrid_MiniLine.ContextMenu = cmenu_createline;
//						menuItem_CreateLine.Visible = false;
//						menuItem_Group.Visible = true;
//
//						break;

					default:

						fgrid_MiniLine.ContextMenu = null;

						break;
				}
			}
			catch
			{
			}
	
		}

		 
		private void menuItem_CreateLine_Click(object sender, System.EventArgs e)
		{
			try
			{
 
				int sel_row = fgrid_MiniLine.Selection.r1; 
				int new_row = 0, new_count = 0, del_row = 0; 
				string del_mlinecd = "";

				int ix_level = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL;
				int ix_mlinecd = (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_LINE;
				string mline_cd = "";


				//선택된 미니라인 팝업창에 표시해주기 위함
				for(int i = sel_row + 1; i < fgrid_MiniLine.Rows.Count; i++)
				{
					if( Convert.ToInt32(fgrid_MiniLine[sel_row, ix_level].ToString()) < Convert.ToInt32(fgrid_MiniLine[i, ix_level].ToString()) )
						mline_cd += fgrid_MiniLine[i, ix_mlinecd].ToString() +  "/";
					else
						break;
				}

				//			//마지막 구분자 없애기
				// 			if(mline_cd != "") mline_cd = mline_cd.Substring(0, mline_cd.Length - 1);

				//{factory, factory_name, line_cd, line_name, op_cd, op_name, mline_qty, mline_cd}

				ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_MLFactory.SelectedValue.ToString(), cmb_MLFactory.Columns[1].Text, 
																   fgrid_MiniLine[sel_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLINE_CD].ToString(),
																   fgrid_MiniLine[sel_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLINE_NAME].ToString(),
																   fgrid_MiniLine[sel_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_CD].ToString(),
																   fgrid_MiniLine[sel_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_NAME].ToString(),
																   fgrid_MiniLine[sel_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxMLINE_QTY].ToString(),
																   mline_cd };
 

				Pop_CreateMiniLine pop_form = new Pop_CreateMiniLine();
				pop_form.ShowDialog();

				if (!pop_form._CloseSave) return; 
 			 
 
				new_count = 0;

				for(int i = 0; i < pop_form._DTSelMLine.Rows.Count; i++)
				{

					switch(pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxCHECK_FLAG - 1].ToString().Trim())
					{
						case "I": 

							new_row = sel_row + 1 + new_count; 

							fgrid_MiniLine.Rows.InsertNode(new_row, Convert.ToInt32(fgrid_MiniLine[sel_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL].ToString()));

							fgrid_MiniLine[new_row, 0] = pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxCHECK_FLAG - 1].ToString();

							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxCODE] 
								= pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxOP_LINE - 1].ToString();

							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxNAME] 
								= pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxOP_LINE_NAME - 1].ToString();

				
							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLINE_CD] = fgrid_MiniLine[sel_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLINE_CD].ToString();
							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_CD] = fgrid_MiniLine[sel_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_CD].ToString();
							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_NAME] = fgrid_MiniLine[sel_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_NAME].ToString();
							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_LINE] = fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxCODE].ToString();
							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_LINE_NAME] = fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxNAME].ToString();
 

							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLEVEL] = "3";
							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxFACTORY] = cmb_MLFactory.SelectedValue.ToString();


							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxAREA_CD] 
								= pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxAREA_CD - 1].ToString();

							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOUT_YN]
								= pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxOUT_YN - 1].ToString();

							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxSTD_CAPA] 
								= pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxSTD_CAPA - 1].ToString();

							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxPROC_UNIT] 
								= pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxPROD_UNIT - 1].ToString();

							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxWORK_TIME] 
								= pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxPROD_TIME - 1].ToString();

							fgrid_MiniLine[new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxREMARKS] 
								= pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxREMARKS - 1].ToString();
				
							fgrid_MiniLine.Rows[new_row].AllowEditing = true;
							fgrid_MiniLine.GetCellRange(new_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxCODE).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;


							new_count++;

							break;

						case "D":

							del_mlinecd = pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxOP_LINE - 1].ToString();
							del_row = fgrid_MiniLine.FindRow(del_mlinecd, fgrid_MiniLine.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_LINE, false, true, false);

							fgrid_MiniLine.Delete_Row(del_row);

							break;

							//					case "U":
							//
							//						del_mlinecd = pop_form._DTSelMLine.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_POPUP.IxOP_LINE - 1].ToString();
							//						del_row = fgrid_MiniLine.FindRow(del_mlinecd, fgrid_MiniLine.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_LINE, false, true, false);
							//
							//						fgrid_MiniLine.Update_Row(del_row);
							//
							//						break;
 
					}


				
				} // end for i

				fgrid_MiniLine.AutoSizeCols();
				fgrid_MiniLine.TopRow = sel_row;
			}
			catch
			{	
			}
		}


		private void menuItem_Group_Click(object sender, System.EventArgs e)
		{

			DataTable dt_ret;
			int sel_row = fgrid_MiniLine.Selection.r1;
			string mline_cd = "";
			int findrow = 0;
			string groupid = "";

			try
			{
				for(int i = fgrid_MiniLine.Rows.Fixed; i < fgrid_MiniLine.Rows.Count; i++)
				{
					if(!fgrid_MiniLine.Rows[i].Selected) continue; 

					//외주 공정 처리 미니라인은 그룹핑 적용하지 않음
					if(Convert.ToBoolean(fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOUT_YN].ToString()) ) continue;

					mline_cd += fgrid_MiniLine[i, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_LINE].ToString() + "/";
				}

				//{factory, factory_name, line_cd, line_name, mline_cd}

				ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_MLFactory.SelectedValue.ToString(), cmb_MLFactory.Columns[1].Text, 
																   fgrid_MiniLine[sel_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLINE_CD].ToString(),
																   fgrid_MiniLine[sel_row, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxLINE_NAME].ToString(),
																   mline_cd };
 


				Pop_CreateMiniLineGroup pop_form = new Pop_CreateMiniLineGroup();
				pop_form.ShowDialog();

				if (!pop_form._CloseSave) return; 

				groupid = ClassLib.ComVar.Parameter_PopUp[0]; 

				string[] token = mline_cd.Split('/');

				for(int i = 0; i < token.Length; i++)
				{
					if(token[i] == "") break;

					findrow = fgrid_MiniLine.FindRow(token[i], fgrid_MiniLine.Rows.Fixed, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxOP_LINE, false, true, false);
				
					fgrid_MiniLine.Update_Row(findrow);
					fgrid_MiniLine[findrow, (int)ClassLib.TBSPB_LINEOP_MINI_GRID.IxGROUP_ID] = groupid;
				}


				//바로 저장
				Save_SPB_LINEOP_MINI();

				dt_ret = Select_SPB_LINEOP_MINI();
				Display_TreeGrid_Mini(dt_ret, fgrid_MiniLine);
				fgrid_MiniLine.TopRow = fgrid_MiniLine.Selection.r1;
			}
			catch
			{
			}
			
		}

		 

		#endregion 
 
		#region 라인공정에 대한 리드타임 정의 



		private void cmb_LLFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{ 
				if(cmb_LLFactory.SelectedIndex == -1) return; 
				
				fgrid_LineOpLT.Rows.Count = fgrid_LineOpLT.Rows.Fixed;  
				cmb_LLLineCd.SelectedIndex = -1;
				cmb_LTCd.SelectedIndex = -1;
				cmb_ApplyYMD.SelectedIndex = -1; 
				chk_DefaultYN.Checked = false;

				dt_ret = Select_SPB_LINE(cmb_LLFactory.SelectedValue.ToString()); 
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LLLineCd, 1, 2, false, COM.ComVar.ComboList_Visible.Name);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LLLineCd1, 1, 2, false, COM.ComVar.ComboList_Visible.Name);
			}
			catch
			{
			}
 
		}


		private void cmb_LLLineCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_LLFactory.SelectedIndex == -1 || cmb_LLLineCd.SelectedIndex == -1) return;

				btn_LineCopy.Enabled = true;

				fgrid_LineOpLT.Rows.Count = fgrid_LineOpLT.Rows.Fixed; 
				cmb_LTCd.SelectedIndex = -1;
				cmb_ApplyYMD.SelectedIndex = -1;
				cmb_LTCd.ClearItems();
				cmb_ApplyYMD.ClearItems();
				chk_DefaultYN.Checked = false;

				dt_ret = Select_LeadTimeCd_CMB();
 
				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_LTCd, 0, 1, 2);
				cmb_LTCd.Splits[0].DisplayColumns[1].Visible = false;
				cmb_LTCd.Splits[0].DisplayColumns[2].Visible = false;
				cmb_LTCd.DisplayMember = "CODE";
 
			}
			catch
			{
			}

		}


		private void cmb_LTCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_LLFactory.SelectedIndex == -1 || cmb_LLLineCd.SelectedIndex == -1 || cmb_LTCd.SelectedIndex == -1) return;

				fgrid_LineOpLT.Rows.Count = fgrid_LineOpLT.Rows.Fixed; 
				cmb_ApplyYMD.SelectedIndex = -1; 
				cmb_ApplyYMD.ClearItems();
				chk_DefaultYN.Checked = Convert.ToBoolean(cmb_LTCd.Columns[2].Text);

				dt_ret = Select_ApplyYMD_CMB();
 
				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_ApplyYMD, 0, 0);
				cmb_ApplyYMD.Splits[0].DisplayColumns[1].Visible = false; 
				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_ApplyYMDCopy, 0, 0);
				cmb_ApplyYMDCopy.Splits[0].DisplayColumns[1].Visible = false; 

				

				//dt_ret = Select_SPB_LINEOP_LEADTIME();
				//Display_Grid(dt_ret, fgrid_LineOpLT); 
 
				//btn_Copy.Enabled = true;
			}
			catch
			{
			}
		}


		private void cmb_ApplyYMD_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_LLFactory.SelectedIndex == -1 || cmb_LLLineCd.SelectedIndex == -1 
					|| cmb_LTCd.SelectedIndex == -1 || cmb_ApplyYMD.SelectedIndex == -1) return;
  
				fgrid_LineOpLT.Rows.Count = fgrid_LineOpLT.Rows.Fixed; 

				dt_ret = Select_SPB_LINEOP_LEADTIME();
				Display_Grid(dt_ret, fgrid_LineOpLT); 
 
				btn_Copy.Enabled = true;
			}
			catch
			{
			}
		}

		 
		private void fgrid_LineOpLT_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{ 
				// 선택 cmp 에 따르는 공정 리스트 그리드 콤보로 처리

				string cmp_cd = fgrid_LineOpLT[fgrid_LineOpLT.Selection.r1, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSTD_CMP].ToString();

				if(cmp_cd == "")
				{
					fgrid_LineOpLT.Cols[(int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSTD_OPCD].ComboList = "";
				}
				else
				{
					dt_ret = Select_SPB_CMP_OPCD_CMB(cmb_LLFactory.SelectedValue.ToString(), cmp_cd);

					string cmb_list = "";

					for(int i = 0; i < dt_ret.Rows.Count; i++) cmb_list += "|" + dt_ret.Rows[i].ItemArray[0].ToString(); 
					fgrid_LineOpLT.Cols[(int)ClassLib.TBSPB_LINEOP_LEADTIME.IxSTD_OPCD].ComboList = cmb_list;
				}

 
			}
			catch
			{
			}
		}

		private void fgrid_LineOpLT_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_LineOpLT.Rows.Fixed > 0) && (fgrid_LineOpLT.Row >= fgrid_LineOpLT.Rows.Fixed))
			{
				if(fgrid_LineOpLT.Cols[fgrid_LineOpLT.Col].DataType == typeof(bool))
				{
					fgrid_LineOpLT.Buffer_CellData = "";
				}
				else
				{
					fgrid_LineOpLT.Buffer_CellData = (fgrid_LineOpLT[fgrid_LineOpLT.Row, fgrid_LineOpLT.Col] == null) ? "" : fgrid_LineOpLT[fgrid_LineOpLT.Row, fgrid_LineOpLT.Col].ToString();
				}
			}
		}

		
		private void fgrid_LineOpLT_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{ 
			try
			{
				switch(e.Col)
				{ 
					case (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOTU:  

						//전체 컬럼 모두 적용 
						for(int i = fgrid_LineOpLT.Rows.Fixed; i < fgrid_LineOpLT.Rows.Count; i++)
						{
							fgrid_LineOpLT[i, e.Col] = fgrid_LineOpLT[e.Row, e.Col].ToString();

							if(fgrid_LineOpLT[i, 0].ToString() == "" 
								&& fgrid_LineOpLT.Buffer_CellData != fgrid_LineOpLT[e.Row, e.Col].ToString()
								&& fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxEXIST_YN].ToString() != "N") 
							{
								fgrid_LineOpLT[i, 0] = "U";
							}

						}

						//otu 에 따라서 컬럼 포맷 변경
						if(fgrid_LineOpLT[e.Row, e.Col] != null && fgrid_LineOpLT[e.Row, e.Col].ToString() != "") 
						{
							switch (fgrid_LineOpLT[e.Row, e.Col].ToString() )
							{
								case "D":
									for(int i = (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME; i <= (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME; i++)
									{
										fgrid_LineOpLT.Cols[i].Style = fgrid_LineOpLT.Styles["MASK_D"]; 

										// 원래 otu = 'H'였을 경우 시간 데이터 삭제 처리
										if(fgrid_LineOpLT.Buffer_CellData == "H")
										{ 
											for(int a = fgrid_LineOpLT.Rows.Fixed; a < fgrid_LineOpLT.Rows.Count; a++)
												fgrid_LineOpLT[a, i] = fgrid_LineOpLT[a, i].ToString().Substring(0, 3);
										}

									}
									
									break;

								case "H":
									for(int i = (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxLEAD_TIME; i <= (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME; i++)
									{
										fgrid_LineOpLT.Cols[i].Style = fgrid_LineOpLT.Styles["MASK_H"];

										// 원래 otu = 'D'였을 경우 확장될 시간 데이터 기본값 세팅
										if(fgrid_LineOpLT.Buffer_CellData == "D")
										{
											for(int a = fgrid_LineOpLT.Rows.Fixed; a < fgrid_LineOpLT.Rows.Count; a++)
											{ 
												if(fgrid_LineOpLT[a, i].ToString().Trim().Length != 3) continue; 
												fgrid_LineOpLT[a, i] = fgrid_LineOpLT[a, i].ToString() + "00H";
											}
										} // end if

									}
									
									break;
							}
						}

						break;


					case (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxH_DAY:  
 
						bool digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_LineOpLT[e.Row, e.Col].ToString() );

						if(digit_flag == false) 
						{
							fgrid_LineOpLT[e.Row, e.Col] = "";
							break;
						}
						 

						//전체 컬럼 모두 적용
						for(int i = fgrid_LineOpLT.Rows.Fixed; i < fgrid_LineOpLT.Rows.Count; i++)
						{
							fgrid_LineOpLT[i, e.Col] = fgrid_LineOpLT[e.Row, e.Col].ToString(); 
							
							if(fgrid_LineOpLT[i, 0].ToString() == "" 
								&& fgrid_LineOpLT.Buffer_CellData != fgrid_LineOpLT[e.Row, e.Col].ToString()
								&& fgrid_LineOpLT[i, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxEXIST_YN].ToString() != "N") 
							{
								fgrid_LineOpLT[i, 0] = "U";
							}
						}

						break; 
				}
  


				if( fgrid_LineOpLT.Buffer_CellData != fgrid_LineOpLT[e.Row, e.Col].ToString())
				{
					if(fgrid_LineOpLT[e.Row, (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxEXIST_YN].ToString() == "N")
						fgrid_LineOpLT[e.Row, 0] = "I";
					else
						fgrid_LineOpLT[e.Row, 0] = "U"; 
				}

				


				fgrid_LineOpLT.AutoSizeCols();


			}
			catch
			{
			}

			
		}


		private void btn_LineCopy_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				btn_LineCopy.Text = "Copy for"; 
				cmb_LLLineCd1.Visible = true;
				btn_ApplyCopyLine.Visible = true;
			}
			catch
			{
			}
		}

		private void btn_ApplyCopyLine_Click(object sender, System.EventArgs e)
		{
			bool saveflag = false; 
			DataTable dt_ret;

			try
			{
				if(cmb_LLLineCd1.SelectedIndex == -1) return;

				saveflag = Insert_SPB_LINEOP_LEADTIME_LINE();

				if(!saveflag) return; 

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
  
				btn_LineCopy.Enabled = false; 
				btn_LineCopy.Text = "Copy";
				cmb_LLLineCd1.Visible = false;
				cmb_LLLineCd1.SelectedIndex = -1;
				btn_ApplyCopyLine.Visible = false; 

				dt_ret = Select_SPB_LINEOP_LEADTIME();
				Display_Grid(dt_ret, fgrid_LineOpLT); 

				

			}
			catch
			{
			} 
		}


		private void btn_Copy_Click(object sender, System.EventArgs e)
		{ 

			try
			{ 
				btn_Copy.Text = "Copy for"; 
				cmb_ApplyYMDCopy.Visible = true;
				btn_ApplyCopy.Visible = true;
			}
			catch
			{
			}
		}


		private void btn_ApplyCopy_Click(object sender, System.EventArgs e)
		{
			bool saveflag = false; 
			DataTable dt_ret;

			try
			{
				if(cmb_ApplyYMDCopy.SelectedIndex == -1) return;

				saveflag = Insert_SPB_LINEOP_LEADTIME();

				if(!saveflag) return; 

				dt_ret = Select_SPB_LINEOP_LEADTIME();
				Display_Grid(dt_ret, fgrid_LineOpLT); 

				btn_Copy.Enabled = false; 
				btn_Copy.Text = "Copy";
				cmb_ApplyYMDCopy.Visible = false;
				cmb_ApplyYMDCopy.SelectedIndex = -1;
				btn_ApplyCopy.Visible = false; 

			}
			catch
			{
			} 
		}


		private void btn_DisplayOp_Click(object sender, System.EventArgs e)
		{
			//{factory, bom_cd, line_cd}

			try
			{
				if(cmb_LLFactory.SelectedIndex == -1 || cmb_LLLineCd.SelectedIndex == -1 
					|| cmb_LTCd.SelectedIndex == -1 || cmb_ApplyYMD.SelectedIndex == -1) return;

//				ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_LLFactory.SelectedValue.ToString(), 
//																"-1", //ClassLib.ComVar.FactoryBomCd,
//																cmb_LLLineCd.SelectedValue.ToString(),
//																cmb_LTCd.SelectedValue.ToString(),
//															    cmb_ApplyYMD.SelectedValue.ToString()};
// 
//
//				Pop_DisplayOpLeadTime_bak pop_form = new Pop_DisplayOpLeadTime_bak();
//				pop_form.Show();


				ClassLib.ComVar.Parameter_PopUp = new string[] { cmb_ApplyYMD.SelectedValue.ToString(),
																   cmb_LLFactory.SelectedValue.ToString(),  
																   cmb_LLLineCd.SelectedValue.ToString(),
																   cmb_LTCd.SelectedValue.ToString() };
	

				Pop_DisplayOpLeadTime pop_form = new Pop_DisplayOpLeadTime();
				pop_form.Show(); 
				
			}
			catch
			{
			}

		}



		private void btn_CreateLTCd_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			string lt_cd = "", lt_desc = "";
			int lt_cd_ix = -1, apply_ymd_ix = -1;

			try
			{
				if(cmb_LLFactory.SelectedIndex == -1 || cmb_LLLineCd.SelectedIndex == -1) return;
 
				lt_cd_ix = cmb_LTCd.SelectedIndex;
				apply_ymd_ix = cmb_ApplyYMD.SelectedIndex;

//				if(cmb_LTCd.SelectedIndex == -1)
//				{
//					lt_cd = "";
//					lt_desc = "";
//				}
//				else
//				{
//					lt_cd = cmb_LTCd.SelectedValue.ToString();
//					lt_desc = cmb_LTCd.Columns[1].Text;
//				}


				lt_cd = "";
				lt_desc = "";


				//{loadevent, 
				// factory, factory_name, linecd, line_name,
				// leadtime_cd, leadtime_desc, default_yn} 
				ClassLib.ComVar.Parameter_PopUp = new string[] {"0",
																   cmb_LLFactory.SelectedValue.ToString(), cmb_LLFactory.Columns[1].Text,
																   cmb_LLLineCd.SelectedValue.ToString(), cmb_LLLineCd.Columns[1].Text,
																   lt_cd, lt_desc,
																   "FALSE"};   //chk_DefaultYN.Checked.ToString()};
 
				Pop_CreateLeadTimeCode pop_form = new Pop_CreateLeadTimeCode();

				pop_form.lbl_ApplyYMD.Visible = false;
				pop_form.txt_ApplyYMD.Visible = false;
				pop_form.lbl_ApplyYMDNew.Visible = false;
				pop_form.dpick_ApplyYMD.Visible = false;

				pop_form.ShowDialog();

				switch(pop_form._CloseEvent)
				{
						//신규로 리드타임 코드 생성했을 경우, DB에는 아직 반영되지 않음
					case "I":

						if(cmb_LTCd.ListCount == 0)
						{
							cmb_LTCd.InsertItem(ClassLib.ComVar.Parameter_PopUp[0] + ";" 
								+ ClassLib.ComVar.Parameter_PopUp[1] + ";" 
								+ ClassLib.ComVar.Parameter_PopUp[2], cmb_LTCd.ListCount); 

							cmb_LTCd.SelectedIndex = cmb_LTCd.ListCount - 1;
						}
						else
						{
							cmb_LTCd.InsertItem(ClassLib.ComVar.Parameter_PopUp[0] + ";" 
								+ ClassLib.ComVar.Parameter_PopUp[1] + ";" 
								+ ClassLib.ComVar.Parameter_PopUp[2], cmb_LTCd.ListCount - 1); 

							cmb_LTCd.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0]; 
						}
						

						

						fgrid_LineOpLT.Rows.Count = fgrid_LineOpLT.Rows.Fixed;

						break;

					case "U":

						//콤보박스 다시 세팅
						dt_ret = Select_LeadTimeCd_CMB();
 
						ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_LTCd, 0, 1, 2);
						cmb_LTCd.Splits[0].DisplayColumns[2].Visible = false;

						cmb_LTCd.SelectedIndex = lt_cd_ix;
						//cmb_ApplyYMD.SelectedIndex = apply_ymd_ix;
						break;

					case "D":
						cmb_LTCd.SelectedIndex = -1;
						cmb_ApplyYMD.SelectedIndex = -1;
						chk_DefaultYN.Checked = false;
						fgrid_LineOpLT.Rows.Count = fgrid_LineOpLT.Rows.Fixed;
 
						break;

					case "C":
						break;   
				}
			}
			catch
			{
			}
		}

		private void btn_CreateApplyYMD_Click(object sender, System.EventArgs e)
		{ 
			DataTable dt_ret;

			string apply_ymd = "";
			int apply_ymd_ix = -1; 

			try
			{
				if(cmb_LLFactory.SelectedIndex == -1 || cmb_LLLineCd.SelectedIndex == -1 || cmb_LTCd.SelectedIndex == -1) return;
				 
				apply_ymd_ix = cmb_ApplyYMD.SelectedIndex;

				//apply_ymd = (cmb_ApplyYMD.SelectedIndex == -1) ? " " : cmb_ApplyYMD.SelectedValue.ToString();

				apply_ymd = " ";

				//{loadevent, 
				// factory, factory_name, linecd, line_name,
				// leadtime_cd, leadtime_desc, default_yn,
				// apply_ymd} 
				ClassLib.ComVar.Parameter_PopUp = new string[] {"1",
																   cmb_LLFactory.SelectedValue.ToString(), cmb_LLFactory.Columns[1].Text,
																   cmb_LLLineCd.SelectedValue.ToString(), cmb_LLLineCd.Columns[1].Text,
																   cmb_LTCd.SelectedValue.ToString(), cmb_LTCd.Columns[1].Text,
																   chk_DefaultYN.Checked.ToString(),
																   apply_ymd};
 
				Pop_CreateLeadTimeCode pop_form = new Pop_CreateLeadTimeCode();

				pop_form.txt_LTCd.ReadOnly = true;
				pop_form.txt_LTDesc.ReadOnly = true;
				pop_form.chk_DefaultYN.Enabled = false;

				pop_form.txt_LTCd.BackColor = ClassLib.ComVar.ClrReadOnly;
				pop_form.txt_LTDesc.BackColor = ClassLib.ComVar.ClrReadOnly;

				pop_form.ShowDialog();

				switch(pop_form._CloseEvent)
				{
						//신규로 리드타임 코드 생성했을 경우, DB에는 아직 반영되지 않음
					case "I":
						
						if(cmb_ApplyYMD.ListCount == 0)
						{
							cmb_ApplyYMD.InsertItem(ClassLib.ComVar.Parameter_PopUp[0] + ";" + ClassLib.ComVar.Parameter_PopUp[0], cmb_ApplyYMD.ListCount);
							cmb_ApplyYMD.SelectedIndex = cmb_ApplyYMD.ListCount - 1;
						}
						else
						{
							cmb_ApplyYMD.InsertItem(ClassLib.ComVar.Parameter_PopUp[0] + ";" + ClassLib.ComVar.Parameter_PopUp[0], cmb_ApplyYMD.ListCount - 1);
							cmb_ApplyYMD.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0];
						}
						 

						break;

					case "U": 
						//콤보박스 다시 세팅
						dt_ret = Select_ApplyYMD_CMB();
 
						ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_ApplyYMD, 0, 0);
						cmb_ApplyYMD.Splits[0].DisplayColumns[1].Visible = false; 
						ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_ApplyYMDCopy, 0, 0);
						cmb_ApplyYMDCopy.Splits[0].DisplayColumns[1].Visible = false; 
 
						cmb_ApplyYMD.SelectedIndex = apply_ymd_ix;

						break;

					case "D": 
						cmb_ApplyYMD.SelectedIndex = -1; 
						fgrid_LineOpLT.Rows.Count = fgrid_LineOpLT.Rows.Fixed;
							
						break;

					case "C":
						break;   
				}
			}
			catch
			{
			}
		}

		



		#endregion


		#endregion

		#region DB Connect
 
	 
		/// <summary>
		/// Select_SPB_LINE : 라인 리스트 가져오기
		/// </summary>
		public static DataTable Select_SPB_LINE(string arg_factory)
		{
			 
			DataSet ds_ret;
			COM.OraDB MyOraDB = new COM.OraDB();

			string process_name = "PKG_SPB_LINE.SELECT_LINE_LIST";

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory; 
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[process_name]; 

 
		}





		/// <summary>
		/// Select_SPB_LINE_ROLE : 권한별 라인 리스트 가져오기
		/// </summary>
		/// <param name="arg_factory"></param>
		public static DataTable Select_SPB_LINE_ROLE(string arg_factory)
		{
			
			try
			{ 
				COM.OraDB myOraDB = new COM.OraDB();

				DataSet ds_ret;

				string all_linecd = "";
				string linecd = ClassLib.ComVar.This_Line.Replace("0", "");
				if(linecd.Length == 0) 
					all_linecd = "";
				else
					all_linecd = "000";



				string process_name = "PKG_SPB_LINE.SELECT_SPB_LINE_ROLE";

				myOraDB.ReDim_Parameter(4); 
 
				myOraDB.Process_Name = process_name;
  
				myOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				myOraDB.Parameter_Name[1] = "ARG_LINE_CD";
				myOraDB.Parameter_Name[2] = "ARG_ALL_LINE_CD";
				myOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				myOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				myOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				myOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				myOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			   
				myOraDB.Parameter_Values[0] = arg_factory; 
				myOraDB.Parameter_Values[1] = ClassLib.ComVar.This_Line;
				myOraDB.Parameter_Values[2] = all_linecd;
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





		/// <summary>
		/// Select_SPB_CAL_TYPE_CMB : Calendar Type 콤보 리스트 
		/// </summary>
		/// <param name="arg_factory"></param>
		private DataTable Select_SPB_CAL_TYPE_CMB(string arg_factory)
		{
		 
			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_WORKCAL.SELECT_CAL_TYPE_CMB";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
 
		}


	
		/// <summary>
		/// Select_SPB_SHIFT_CMB : Shift Type 콤보 리스트 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <returns></returns>
		private DataTable Select_SPB_SHIFT_CMB(string arg_factory)
		{

			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_WORKCAL.SELECT_SPB_SHIFT_CMB";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}


 

		/// <summary>
		/// Select_SPB_LINEOP : 라인별 공정 정보 
		/// </summary>
		private DataTable Select_SPB_LINEOP(string arg_factory, string arg_line)
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SPB_LINE.SELECT_LINEOP_LIST";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory; 
			MyOraDB.Parameter_Values[1] = arg_line; 
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 




		}

		
		 

		/// <summary>
		/// Select_Display_SPB_OPCD : 공정코드 리스트 (트리로 표현하기 위한 데이터 테이블 추출) 
		/// </summary>
		/// <param name="arg_factory"></param>
		private DataTable Select_SPB_OPCD_CMB(string arg_factory)
		{
			DataSet ds_ret; 
 
			try
			{
				// spb_opcd
				MyOraDB.ReDim_Parameter(2); 

				MyOraDB.Process_Name = "PKG_SPB_OPCD.SELECT_SPB_OPCD_CMB";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = "";

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
		/// Select_SPB_CMP_OPCD_CMB : 반제별 공정 리스트
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_cmpcd"></param>
		/// <returns></returns>
		private DataTable Select_SPB_CMP_OPCD_CMB(string arg_factory, string arg_cmpcd)
		{
			DataSet ds_ret; 
 
			try
			{ 
				MyOraDB.ReDim_Parameter(3); 

				MyOraDB.Process_Name = "PKG_SPB_OPCD.SELECT_SPB_CMP_OPCD_CMB";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_cmpcd; 
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
		/// Select_LINEOP_LIST_CMB : 공정 세부라인 콤보 리스트
		/// </summary>
		/// <returns></returns>
		private DataTable Select_LINEOP_LIST_CMB(string arg_factory, string arg_linecd)
		{
			DataSet ds_ret;
			string process_name = "PKG_SPB_LINE.SELECT_SPB_LINEOP_CMB";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_linecd;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}



		/// <summary>
		/// Select_SPB_LINEOP_MINI : 
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_LINEOP_MINI()
		{
			DataSet ds_ret;
			string process_name = "PKG_SPB_LINE.SELECT_SPB_LINEOP_MINI";

			MyOraDB.ReDim_Parameter(4); 
 
			MyOraDB.Process_Name = process_name;
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_OP_CD";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = cmb_MLFactory.SelectedValue.ToString(); 

			if(cmb_MLLineCd.SelectedValue.ToString().Trim() == "")
				MyOraDB.Parameter_Values[1] = "_";
			else
				MyOraDB.Parameter_Values[1] = cmb_MLLineCd.SelectedValue.ToString();  

			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(cmb_MLOpCd, " ");
			MyOraDB.Parameter_Values[3] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[process_name]; 
		}


		/// <summary>
		/// Select_LeadTimeCd_CMB : LeadTime Code Combo List 추출
		/// </summary>
		/// <returns></returns>
		private DataTable Select_LeadTimeCd_CMB()
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPB_LINE.SELECT_LEADTIME_CD_CMB";

				MyOraDB.ReDim_Parameter(3); 
  
				MyOraDB.Process_Name = process_name;
	  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LINE_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
				  
				MyOraDB.Parameter_Values[0] = cmb_LLFactory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_LLLineCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = ""; 

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
 

		/// <summary>
		/// Select_ApplyYMD_CMB : Apply YMD Combo List 추출
		/// </summary>
		/// <returns></returns>
		private DataTable Select_ApplyYMD_CMB()
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPB_LINE.SELECT_APPLY_YMD_CMB";

				MyOraDB.ReDim_Parameter(4); 
  
				MyOraDB.Process_Name = process_name;
	  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LINE_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_LEADTIME_CD"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
				  
				MyOraDB.Parameter_Values[0] = cmb_LLFactory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_LLLineCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = cmb_LTCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[3] = "";

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


		/// <summary>
		/// Select_SPB_LINEOP_LEADTIME : 
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_LINEOP_LEADTIME()
		{
			DataSet ds_ret;
			string process_name = "PKG_SPB_LINE.SELECT_SPB_LINEOP_LEADTIME";

			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
	 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LINE_CD"; 
			MyOraDB.Parameter_Name[2] = "ARG_LEADTIME_CD";
			MyOraDB.Parameter_Name[3] = "ARG_APPLY_YMD"; 
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
				 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_LLFactory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_LLLineCd.SelectedValue.ToString(); 
			MyOraDB.Parameter_Values[2] = cmb_LTCd.SelectedValue.ToString();; 
			MyOraDB.Parameter_Values[3] = cmb_ApplyYMD.SelectedValue.ToString();; 
			MyOraDB.Parameter_Values[4] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
				
			return ds_ret.Tables[process_name]; 
		}
 

		/// <summary>
		/// Select_SPB_RSC : SPB_RSC 리스트
		/// </summary>
		private DataTable Select_SPB_RSC(string arg_factory, string arg_rsc_type)
		{
			DataSet ds_ret;
			string process_name = "PKG_SPB_STDRSC.SELECT_SPB_RSC";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_RSC_TYPE";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory; 
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_String(arg_rsc_type, " "); 
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}


		
		/// <summary>
		/// Save_SPB_LINEOP_MINI : 공정 미니라인 저장
		/// </summary>
		private bool Save_SPB_LINEOP_MINI()
		{
			int arg_ct = 0;
			int save_ct =0 ;							// 저장 행 수
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 
	
			try
			{
				ClassLib.Arr_TBSPB_LINEOP_MINI arr_mini= new ClassLib.Arr_TBSPB_LINEOP_MINI();
			
				arg_ct = arr_mini.lx.GetLength(0) + 1;

				MyOraDB.ReDim_Parameter(arg_ct); 
		
				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SPB_LINE.SAVE_SPB_LINEOP_MINI";

			
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";

				for (int i = 0 ; i < arr_mini.lx.GetLength(0); i ++)
				{	
					MyOraDB.Parameter_Name[i + 1] = MiniHeadDT.Rows[0].ItemArray[arr_mini.lx[i]].ToString(); 
				}
		
				//03.DATA TYPE
				for (int i = 0 ; i < arg_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			
		
					
				//04.DATA 정의
				 
				// 저장 행 수 구하기
				for(int i = fgrid_MiniLine.Rows.Fixed ; i < fgrid_MiniLine.Rows.Count; i++)
				{
					if(fgrid_MiniLine[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}
 

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[arg_ct * save_ct ]; 
			         
				for (int i  = fgrid_MiniLine.Rows.Fixed; i < fgrid_MiniLine.Rows.Count; i++)
				{
					if(fgrid_MiniLine[i, 0].ToString() != "")
					{ 

						
						MyOraDB.Parameter_Values[para_ct] = fgrid_MiniLine[i, 0].ToString(); 
						para_ct ++;

						for(int j = 0; j < arr_mini.lx.GetLength(0); j++)
						{
							 
							// 데이터값 설정 
							if(fgrid_MiniLine.Cols[arr_mini.lx[j]].Style.DataType != null
									&& fgrid_MiniLine.Cols[arr_mini.lx[j]].DataType.Equals(typeof(bool)) )
							{
								if(fgrid_MiniLine[i, arr_mini.lx[j]] == null) fgrid_MiniLine[i, arr_mini.lx[j]] = false ;
								MyOraDB.Parameter_Values[para_ct] = (fgrid_MiniLine[i, arr_mini.lx[j]].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}
								//콤보리스트 처리 추가  
							else if(fgrid_MiniLine.Cols[arr_mini.lx[j]].ComboList.Length != 0)
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 
								 
								fgrid_MiniLine[i, arr_mini.lx[j]] = (fgrid_MiniLine[i, arr_mini.lx[j]] == null) ? "" : fgrid_MiniLine[i, arr_mini.lx[j]].ToString();
								token = fgrid_MiniLine[i, arr_mini.lx[j]].ToString().Split(delimiter); 
								MyOraDB.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
								
								para_ct ++;

							}
							else
							{
								MyOraDB.Parameter_Values[para_ct] = (fgrid_MiniLine[i, arr_mini.lx[j]] == null) ? "" : fgrid_MiniLine[i, arr_mini.lx[j]].ToString();
								para_ct ++;
							}			


						} // end for j 
 
					} // end if
	 
				} // end for i

				//05.Package연결
				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
					
				return true;



			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_SPB_LINEOP_MINI",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}


		}


		/// <summary>
		/// Save_SPB_LINEOP_LEADTIME : 라인 공정 리드타임 저장
		/// </summary>
		private void Save_SPB_LINEOP_LEADTIME()
		{
			int arg_ct = 0;
			int save_ct =0 ;							// 저장 행 수
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 
	
			try
			{
				ClassLib.Arr_TBSPB_LINEOP_LEADTIME arr_lt= new ClassLib.Arr_TBSPB_LINEOP_LEADTIME();
			
				arg_ct = arr_lt.lx.GetLength(0) + 1;

				MyOraDB.ReDim_Parameter(arg_ct); 
		
				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SPB_LINE.SAVE_SPB_LINEOP_LEADTIME";

			
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";

				for (int i = 0 ; i < arr_lt.lx.GetLength(0); i ++)
				{	
					MyOraDB.Parameter_Name[i + 1] = "ARG_" + fgrid_LineOpLT[0, arr_lt.lx[i]].ToString(); 
				}
		
				//03.DATA TYPE
				for (int i = 0 ; i < arg_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			
		
					
				//04.DATA 정의
				 
				// 저장 행 수 구하기
				for(int i = fgrid_LineOpLT.Rows.Fixed ; i < fgrid_LineOpLT.Rows.Count; i++)
				{
					if(fgrid_LineOpLT[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[arg_ct * save_ct ]; 
			         
				for (int i  = fgrid_LineOpLT.Rows.Fixed; i < fgrid_LineOpLT.Rows.Count; i++)
				{
					if(fgrid_LineOpLT[i, 0].ToString() != "")
					{ 

						
						MyOraDB.Parameter_Values[para_ct] = fgrid_LineOpLT[i, 0].ToString(); 
						para_ct ++;

						for(int j = 0; j < arr_lt.lx.GetLength(0); j++)
						{
							 
							// 데이터값 설정 
							if(fgrid_LineOpLT.Cols[arr_lt.lx[j]].Style.DataType != null
								&& fgrid_LineOpLT.Cols[arr_lt.lx[j]].DataType.Equals(typeof(bool)) )
							{
								if(fgrid_LineOpLT[i, arr_lt.lx[j]] == null) fgrid_LineOpLT[i, arr_lt.lx[j]] = false ;
								MyOraDB.Parameter_Values[para_ct] = (fgrid_LineOpLT[i, arr_lt.lx[j]].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}
								//콤보리스트 처리 추가  
							else if(fgrid_LineOpLT.Cols[arr_lt.lx[j]].ComboList.Length != 0)
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 
								 
								fgrid_LineOpLT[i, arr_lt.lx[j]] = (fgrid_LineOpLT[i, arr_lt.lx[j]] == null) ? "" : fgrid_LineOpLT[i, arr_lt.lx[j]].ToString();
								token = fgrid_LineOpLT[i, arr_lt.lx[j]].ToString().Split(delimiter); 
								MyOraDB.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
								
								para_ct ++;

							}
							else
							{
								if(arr_lt.lx[j] == (int)ClassLib.TBSPB_LINEOP_LEADTIME.IxUPD_USER)
								{
									MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User;;
								}
								else
									{
								MyOraDB.Parameter_Values[para_ct] = (fgrid_LineOpLT[i, arr_lt.lx[j]] == null) ? "" : fgrid_LineOpLT[i, arr_lt.lx[j]].ToString();
								}
								
								para_ct ++;
							}			


						} // end for j 
 
					} // end if
	 
				} // end for i

				//05.Package연결
				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
					 

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_SPB_LINEOP_LEADTIME",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
			}


		}
 

		
        /// <summary>
        /// Insert_SPB_LINEOP_LEADTIME_LINE : 라인별 복사
        /// </summary>
        /// <returns></returns>
		private bool Insert_SPB_LINEOP_LEADTIME_LINE()
		{ 
			try
			{
				MyOraDB.ReDim_Parameter(4);  
				MyOraDB.Process_Name = "PKG_SPB_LINE.INSERT_SPB_LINEOP_LT_LINE";
	 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LINE_CD_ORG"; 
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD_DST"; 
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				 
				MyOraDB.Parameter_Values[0] = cmb_LLFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_LLLineCd1.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2] = cmb_LLLineCd.SelectedValue.ToString(); 		 
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;  

				MyOraDB.Add_Modify_Parameter(true);	 
				MyOraDB.Exe_Modify_Procedure();		 
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Insert_SPB_LINEOP_LEADTIME_LINE",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}


		}
 
		private bool Insert_SPB_LINEOP_LEADTIME()
		{ 
			try
			{
				MyOraDB.ReDim_Parameter(6);  
				MyOraDB.Process_Name = "PKG_SPB_LINE.INSERT_SPB_LINEOP_LEADTIME";
	 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LINE_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_LEADTIME_CD";
				MyOraDB.Parameter_Name[3] = "ARG_APPLY_YMD_ORG";
				MyOraDB.Parameter_Name[4] = "ARG_APPLY_YMD_DST";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				 
				MyOraDB.Parameter_Values[0] = cmb_LLFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_LLLineCd.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2] = cmb_LTCd.SelectedValue.ToString();
				MyOraDB.Parameter_Values[3] = cmb_ApplyYMDCopy.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[4] = cmb_ApplyYMD.SelectedValue.ToString();	    		 
				MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;  

				MyOraDB.Add_Modify_Parameter(true);	 
				MyOraDB.Exe_Modify_Procedure();		 
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Insert_SPB_LINEOP_LEADTIME",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}


		}
 
	 




		#endregion



		private void Form_PB_Line_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



	 



 
		 
	}
}

