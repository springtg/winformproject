using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
using Lassalle.Flow; 

namespace FlexAPS.ProdBase
{
	public class Form_PB_OpCd : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Command.C1OutBar obar_Main;
		private C1.Win.C1Command.C1OutPage obarpg_OpType;
		private C1.Win.C1Command.C1OutPage obarpg_OpCd;
		private System.Windows.Forms.Panel pnl_OTBody;
		private System.Windows.Forms.Splitter splitter_Body;
		private System.Windows.Forms.Panel pnl_OTBodyLeft;
		public System.Windows.Forms.Panel pnl_SearchSplitLeft;
		public System.Windows.Forms.Panel pnl_SearchLeftImage;
		public System.Windows.Forms.PictureBox picb_LMR;
		public System.Windows.Forms.PictureBox picb_LBR;
		public System.Windows.Forms.PictureBox picb_LTR;
		public System.Windows.Forms.PictureBox picb_LTM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		private C1.Win.C1List.C1Combo cmb_OTFactory;
		private System.Windows.Forms.Label lbl_OTFactory;
		public System.Windows.Forms.PictureBox picb_LBM;
		public System.Windows.Forms.PictureBox picb_LMM;
		public System.Windows.Forms.PictureBox picb_LML;
		public System.Windows.Forms.PictureBox picb_LBL;
		private System.Windows.Forms.Panel pnl_SBody;
		public System.Windows.Forms.Panel pnl_SBodyTop;
		public System.Windows.Forms.Panel panel3;
		private C1.Win.C1List.C1Combo cmb_OCFactory;
		private System.Windows.Forms.Label lbl_OCFactory;
		public System.Windows.Forms.PictureBox pictureBox18;
		public System.Windows.Forms.PictureBox pictureBox24;
		public System.Windows.Forms.PictureBox pictureBox17;
		public System.Windows.Forms.PictureBox pictureBox19;
		public System.Windows.Forms.PictureBox pictureBox20;
		public System.Windows.Forms.PictureBox pictureBox21;
		public System.Windows.Forms.Label lbl_SubTitle3;
		public System.Windows.Forms.PictureBox pictureBox22;
		public System.Windows.Forms.PictureBox pictureBox23;
		public COM.FSP fgrid_OpType;
		public COM.FSP fgrid_OpCd;
		private System.Windows.Forms.ContextMenu cmenu_Node;
		private System.Windows.Forms.MenuItem menuItem_NodeProp;
		private System.Windows.Forms.MenuItem menuItem_NodeDel;
		private C1.Win.C1Command.C1OutPage obarpg_OpLine;
		private System.Windows.Forms.Panel pnl_OLB;
		private System.Windows.Forms.ImageList img_MiniButton;
		private Lassalle.Flow.AddFlow addflow_Main;
		private System.Windows.Forms.Label btn_SetDetailOpCd;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label lbl_ODetailQty;
		private System.Windows.Forms.Label btn_OAppendRow;
		private System.Windows.Forms.TextBox txt_ODetailQty;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		private C1.Win.C1List.C1Combo cmb_OLFactory;
		private System.Windows.Forms.Label lbl_OLFactory;
		public System.Windows.Forms.Label lbl_SubTitle4;
		private C1.Win.C1List.C1Combo cmb_OLLineGroup;
		private System.Windows.Forms.Label lbl_OLLineGroup;
		public System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.Panel panel5;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Panel pnl_OLBL;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel pnl_OLBM;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel pnl_OLBR;
		public COM.FSP fgrid_OLOpCd;
		public COM.FSP fgrid_OLLine;
		public COM.FSP fgrid_OpCdLine;
		public System.Windows.Forms.Label lbl_SubTitle5;
		private System.Windows.Forms.RadioButton rad_Op;
		private System.Windows.Forms.RadioButton rad_Line;
		private System.Windows.Forms.Label lbl_OLCopy1;
		private C1.Win.C1List.C1Combo cmb_OLOpCd2;
		private C1.Win.C1List.C1Combo cmb_OLOpCd1;
		private C1.Win.C1List.C1Combo cmb_OLOpCd3;
		private System.Windows.Forms.Label lbl_OLCopy2;
		private C1.Win.C1List.C1Combo cmb_OLLine2;
		private C1.Win.C1List.C1Combo cmb_OLLine1;
		private System.Windows.Forms.Label btn_RunCopy;
		private System.Windows.Forms.Panel panel6;
		private System.ComponentModel.IContainer components = null;

		public Form_PB_OpCd()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PB_OpCd));
            C1.Win.C1List.Style style73 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style74 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style75 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style76 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style77 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style78 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style79 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style80 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style81 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style82 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style83 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style84 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style85 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style86 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style87 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style88 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style89 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style90 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style91 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style92 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style93 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style94 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style95 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style96 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style97 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style98 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style99 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style100 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style101 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style102 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style103 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style104 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style105 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style106 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style107 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style108 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style109 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style110 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style111 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style112 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style113 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style114 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style115 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style116 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style117 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style118 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style119 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style120 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style121 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style122 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style123 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style124 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style125 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style126 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style127 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style128 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style129 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style130 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style131 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style132 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style133 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style134 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style135 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style136 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style137 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style138 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style139 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style140 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style141 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style142 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style143 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style144 = new C1.Win.C1List.Style();
            this.obar_Main = new C1.Win.C1Command.C1OutBar();
            this.obarpg_OpCd = new C1.Win.C1Command.C1OutPage();
            this.pnl_SBody = new System.Windows.Forms.Panel();
            this.fgrid_OpCd = new COM.FSP();
            this.pnl_SBodyTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_OAppendRow = new System.Windows.Forms.Label();
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.txt_ODetailQty = new System.Windows.Forms.TextBox();
            this.lbl_ODetailQty = new System.Windows.Forms.Label();
            this.btn_SetDetailOpCd = new System.Windows.Forms.Label();
            this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
            this.cmb_OCFactory = new C1.Win.C1List.C1Combo();
            this.lbl_OCFactory = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle3 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.obarpg_OpLine = new C1.Win.C1Command.C1OutPage();
            this.pnl_OLB = new System.Windows.Forms.Panel();
            this.pnl_OLBR = new System.Windows.Forms.Panel();
            this.fgrid_OpCdLine = new COM.FSP();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnl_OLBM = new System.Windows.Forms.Panel();
            this.fgrid_OLLine = new COM.FSP();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_OLBL = new System.Windows.Forms.Panel();
            this.fgrid_OLOpCd = new COM.FSP();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_OLCopy2 = new System.Windows.Forms.Label();
            this.cmb_OLLine2 = new C1.Win.C1List.C1Combo();
            this.cmb_OLLine1 = new C1.Win.C1List.C1Combo();
            this.cmb_OLOpCd3 = new C1.Win.C1List.C1Combo();
            this.btn_RunCopy = new System.Windows.Forms.Label();
            this.lbl_OLCopy1 = new System.Windows.Forms.Label();
            this.cmb_OLOpCd2 = new C1.Win.C1List.C1Combo();
            this.cmb_OLOpCd1 = new C1.Win.C1List.C1Combo();
            this.rad_Line = new System.Windows.Forms.RadioButton();
            this.rad_Op = new System.Windows.Forms.RadioButton();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle5 = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_OLLineGroup = new C1.Win.C1List.C1Combo();
            this.lbl_OLLineGroup = new System.Windows.Forms.Label();
            this.cmb_OLFactory = new C1.Win.C1List.C1Combo();
            this.lbl_OLFactory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle4 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.obarpg_OpType = new C1.Win.C1Command.C1OutPage();
            this.pnl_OTBody = new System.Windows.Forms.Panel();
            this.addflow_Main = new Lassalle.Flow.AddFlow();
            this.cmenu_Node = new System.Windows.Forms.ContextMenu();
            this.menuItem_NodeProp = new System.Windows.Forms.MenuItem();
            this.menuItem_NodeDel = new System.Windows.Forms.MenuItem();
            this.splitter_Body = new System.Windows.Forms.Splitter();
            this.pnl_OTBodyLeft = new System.Windows.Forms.Panel();
            this.fgrid_OpType = new COM.FSP();
            this.pnl_SearchSplitLeft = new System.Windows.Forms.Panel();
            this.pnl_SearchLeftImage = new System.Windows.Forms.Panel();
            this.cmb_OTFactory = new C1.Win.C1List.C1Combo();
            this.picb_LMR = new System.Windows.Forms.PictureBox();
            this.picb_LTR = new System.Windows.Forms.PictureBox();
            this.picb_LTM = new System.Windows.Forms.PictureBox();
            this.picb_LBR = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.lbl_OTFactory = new System.Windows.Forms.Label();
            this.picb_LBM = new System.Windows.Forms.PictureBox();
            this.picb_LMM = new System.Windows.Forms.PictureBox();
            this.picb_LML = new System.Windows.Forms.PictureBox();
            this.picb_LBL = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
            this.obar_Main.SuspendLayout();
            this.obarpg_OpCd.SuspendLayout();
            this.pnl_SBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OpCd)).BeginInit();
            this.pnl_SBodyTop.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OCFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.obarpg_OpLine.SuspendLayout();
            this.pnl_OLB.SuspendLayout();
            this.pnl_OLBR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OpCdLine)).BeginInit();
            this.pnl_OLBM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OLLine)).BeginInit();
            this.pnl_OLBL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OLOpCd)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLOpCd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLOpCd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLOpCd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLLineGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.obarpg_OpType.SuspendLayout();
            this.pnl_OTBody.SuspendLayout();
            this.pnl_OTBodyLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OpType)).BeginInit();
            this.pnl_SearchSplitLeft.SuspendLayout();
            this.pnl_SearchLeftImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OTFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBL)).BeginInit();
            this.panel6.SuspendLayout();
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
            this.obar_Main.Controls.Add(this.obarpg_OpCd);
            this.obar_Main.Controls.Add(this.obarpg_OpLine);
            this.obar_Main.Controls.Add(this.obarpg_OpType);
            this.obar_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obar_Main.Location = new System.Drawing.Point(8, 0);
            this.obar_Main.Name = "obar_Main";
            this.obar_Main.SelectedIndex = 0;
            this.obar_Main.Size = new System.Drawing.Size(998, 576);
            this.obar_Main.SelectedPageChanged += new System.EventHandler(this.obar_Main_SelectedPageChanged);
            // 
            // obarpg_OpCd
            // 
            this.obarpg_OpCd.Controls.Add(this.pnl_SBody);
            this.obarpg_OpCd.Name = "obarpg_OpCd";
            this.obarpg_OpCd.Size = new System.Drawing.Size(998, 516);
            this.obarpg_OpCd.Text = "Production Operation";
            // 
            // pnl_SBody
            // 
            this.pnl_SBody.Controls.Add(this.fgrid_OpCd);
            this.pnl_SBody.Controls.Add(this.pnl_SBodyTop);
            this.pnl_SBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SBody.Location = new System.Drawing.Point(0, 0);
            this.pnl_SBody.Name = "pnl_SBody";
            this.pnl_SBody.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_SBody.Size = new System.Drawing.Size(998, 516);
            this.pnl_SBody.TabIndex = 3;
            // 
            // fgrid_OpCd
            // 
            this.fgrid_OpCd.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_OpCd.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_OpCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_OpCd.Location = new System.Drawing.Point(8, 81);
            this.fgrid_OpCd.Name = "fgrid_OpCd";
            this.fgrid_OpCd.Rows.DefaultSize = 19;
            this.fgrid_OpCd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_OpCd.Size = new System.Drawing.Size(982, 427);
            this.fgrid_OpCd.StyleInfo = resources.GetString("fgrid_OpCd.StyleInfo");
            this.fgrid_OpCd.TabIndex = 33;
            this.fgrid_OpCd.Click += new System.EventHandler(this.fgrid_OpCd_Click);
            this.fgrid_OpCd.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_OpCd_AfterEdit);
            this.fgrid_OpCd.CellButtonClick += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_OpCd_CellButtonClick);
            // 
            // pnl_SBodyTop
            // 
            this.pnl_SBodyTop.Controls.Add(this.panel3);
            this.pnl_SBodyTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_SBodyTop.Location = new System.Drawing.Point(8, 8);
            this.pnl_SBodyTop.Name = "pnl_SBodyTop";
            this.pnl_SBodyTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_SBodyTop.Size = new System.Drawing.Size(982, 73);
            this.pnl_SBodyTop.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.btn_OAppendRow);
            this.panel3.Controls.Add(this.txt_ODetailQty);
            this.panel3.Controls.Add(this.lbl_ODetailQty);
            this.panel3.Controls.Add(this.btn_SetDetailOpCd);
            this.panel3.Controls.Add(this.cmb_OCFactory);
            this.panel3.Controls.Add(this.lbl_OCFactory);
            this.panel3.Controls.Add(this.pictureBox18);
            this.panel3.Controls.Add(this.pictureBox24);
            this.panel3.Controls.Add(this.pictureBox17);
            this.panel3.Controls.Add(this.pictureBox19);
            this.panel3.Controls.Add(this.pictureBox20);
            this.panel3.Controls.Add(this.pictureBox21);
            this.panel3.Controls.Add(this.lbl_SubTitle3);
            this.panel3.Controls.Add(this.pictureBox22);
            this.panel3.Controls.Add(this.pictureBox23);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 65);
            this.panel3.TabIndex = 19;
            // 
            // btn_OAppendRow
            // 
            this.btn_OAppendRow.ImageIndex = 0;
            this.btn_OAppendRow.ImageList = this.img_MiniButton;
            this.btn_OAppendRow.Location = new System.Drawing.Point(589, 36);
            this.btn_OAppendRow.Name = "btn_OAppendRow";
            this.btn_OAppendRow.Size = new System.Drawing.Size(21, 21);
            this.btn_OAppendRow.TabIndex = 199;
            this.btn_OAppendRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_OAppendRow.Click += new System.EventHandler(this.btn_OAppendRow_Click);
            this.btn_OAppendRow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_OAppendRow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_MiniButton
            // 
            this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
            this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_MiniButton.Images.SetKeyName(0, "");
            this.img_MiniButton.Images.SetKeyName(1, "");
            // 
            // txt_ODetailQty
            // 
            this.txt_ODetailQty.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ODetailQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ODetailQty.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_ODetailQty.Location = new System.Drawing.Point(533, 36);
            this.txt_ODetailQty.MaxLength = 60;
            this.txt_ODetailQty.Name = "txt_ODetailQty";
            this.txt_ODetailQty.Size = new System.Drawing.Size(55, 21);
            this.txt_ODetailQty.TabIndex = 198;
            this.txt_ODetailQty.Leave += new System.EventHandler(this.txt_ODetailQty_Leave);
            // 
            // lbl_ODetailQty
            // 
            this.lbl_ODetailQty.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ODetailQty.ImageIndex = 0;
            this.lbl_ODetailQty.ImageList = this.img_Label;
            this.lbl_ODetailQty.Location = new System.Drawing.Point(432, 36);
            this.lbl_ODetailQty.Name = "lbl_ODetailQty";
            this.lbl_ODetailQty.Size = new System.Drawing.Size(100, 21);
            this.lbl_ODetailQty.TabIndex = 197;
            this.lbl_ODetailQty.Text = "Detail Qty";
            this.lbl_ODetailQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_SetDetailOpCd
            // 
            this.btn_SetDetailOpCd.ImageIndex = 0;
            this.btn_SetDetailOpCd.ImageList = this.img_LongButton;
            this.btn_SetDetailOpCd.Location = new System.Drawing.Point(328, 35);
            this.btn_SetDetailOpCd.Name = "btn_SetDetailOpCd";
            this.btn_SetDetailOpCd.Size = new System.Drawing.Size(100, 23);
            this.btn_SetDetailOpCd.TabIndex = 122;
            this.btn_SetDetailOpCd.Text = "Set Detail Proc";
            this.btn_SetDetailOpCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SetDetailOpCd.Click += new System.EventHandler(this.btn_SetDetailOpCd_Click);
            this.btn_SetDetailOpCd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_SetDetailOpCd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_LongButton
            // 
            this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
            this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongButton.Images.SetKeyName(0, "");
            this.img_LongButton.Images.SetKeyName(1, "");
            // 
            // cmb_OCFactory
            // 
            this.cmb_OCFactory.AddItemSeparator = ';';
            this.cmb_OCFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OCFactory.Caption = "";
            this.cmb_OCFactory.CaptionHeight = 17;
            this.cmb_OCFactory.CaptionStyle = style73;
            this.cmb_OCFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OCFactory.ColumnCaptionHeight = 18;
            this.cmb_OCFactory.ColumnFooterHeight = 18;
            this.cmb_OCFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OCFactory.ContentHeight = 17;
            this.cmb_OCFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OCFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OCFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OCFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OCFactory.EditorHeight = 17;
            this.cmb_OCFactory.EvenRowStyle = style74;
            this.cmb_OCFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OCFactory.FooterStyle = style75;
            this.cmb_OCFactory.HeadingStyle = style76;
            this.cmb_OCFactory.HighLightRowStyle = style77;
            this.cmb_OCFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OCFactory.Images"))));
            this.cmb_OCFactory.ItemHeight = 15;
            this.cmb_OCFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_OCFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_OCFactory.MaxDropDownItems = ((short)(5));
            this.cmb_OCFactory.MaxLength = 32767;
            this.cmb_OCFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OCFactory.Name = "cmb_OCFactory";
            this.cmb_OCFactory.OddRowStyle = style78;
            this.cmb_OCFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OCFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OCFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OCFactory.SelectedStyle = style79;
            this.cmb_OCFactory.Size = new System.Drawing.Size(180, 21);
            this.cmb_OCFactory.Style = style80;
            this.cmb_OCFactory.TabIndex = 38;
            this.cmb_OCFactory.SelectedValueChanged += new System.EventHandler(this.cmb_OCFactory_SelectedValueChanged);
            this.cmb_OCFactory.PropBag = resources.GetString("cmb_OCFactory.PropBag");
            // 
            // lbl_OCFactory
            // 
            this.lbl_OCFactory.ImageIndex = 0;
            this.lbl_OCFactory.ImageList = this.img_Label;
            this.lbl_OCFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_OCFactory.Name = "lbl_OCFactory";
            this.lbl_OCFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_OCFactory.TabIndex = 37;
            this.lbl_OCFactory.Text = "Factory";
            this.lbl_OCFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(965, 24);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(17, 30);
            this.pictureBox18.TabIndex = 26;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox24.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(966, 50);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(16, 16);
            this.pictureBox24.TabIndex = 23;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(131, 49);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(982, 18);
            this.pictureBox17.TabIndex = 28;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(966, 0);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(16, 32);
            this.pictureBox19.TabIndex = 21;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox20.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(224, 0);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(982, 32);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(160, 24);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(982, 25);
            this.pictureBox21.TabIndex = 27;
            this.pictureBox21.TabStop = false;
            // 
            // lbl_SubTitle3
            // 
            this.lbl_SubTitle3.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle3.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle3.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle3.Image")));
            this.lbl_SubTitle3.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle3.Name = "lbl_SubTitle3";
            this.lbl_SubTitle3.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle3.TabIndex = 20;
            this.lbl_SubTitle3.Text = "      Production Operation";
            this.lbl_SubTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox22.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(0, 24);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(168, 32);
            this.pictureBox22.TabIndex = 25;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox23.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(0, 50);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(168, 20);
            this.pictureBox23.TabIndex = 22;
            this.pictureBox23.TabStop = false;
            // 
            // obarpg_OpLine
            // 
            this.obarpg_OpLine.Controls.Add(this.pnl_OLB);
            this.obarpg_OpLine.Name = "obarpg_OpLine";
            this.obarpg_OpLine.Size = new System.Drawing.Size(998, 516);
            this.obarpg_OpLine.Text = "Production Operation of MiniLine";
            // 
            // pnl_OLB
            // 
            this.pnl_OLB.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_OLB.Controls.Add(this.pnl_OLBR);
            this.pnl_OLB.Controls.Add(this.splitter2);
            this.pnl_OLB.Controls.Add(this.pnl_OLBM);
            this.pnl_OLB.Controls.Add(this.splitter1);
            this.pnl_OLB.Controls.Add(this.pnl_OLBL);
            this.pnl_OLB.Controls.Add(this.panel4);
            this.pnl_OLB.Controls.Add(this.panel1);
            this.pnl_OLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_OLB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_OLB.Location = new System.Drawing.Point(0, 0);
            this.pnl_OLB.Name = "pnl_OLB";
            this.pnl_OLB.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_OLB.Size = new System.Drawing.Size(998, 516);
            this.pnl_OLB.TabIndex = 2;
            // 
            // pnl_OLBR
            // 
            this.pnl_OLBR.Controls.Add(this.fgrid_OpCdLine);
            this.pnl_OLBR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_OLBR.Location = new System.Drawing.Point(478, 78);
            this.pnl_OLBR.Name = "pnl_OLBR";
            this.pnl_OLBR.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnl_OLBR.Size = new System.Drawing.Size(512, 340);
            this.pnl_OLBR.TabIndex = 34;
            // 
            // fgrid_OpCdLine
            // 
            this.fgrid_OpCdLine.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_OpCdLine.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_OpCdLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_OpCdLine.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgrid_OpCdLine.Location = new System.Drawing.Point(0, 0);
            this.fgrid_OpCdLine.Name = "fgrid_OpCdLine";
            this.fgrid_OpCdLine.Rows.DefaultSize = 19;
            this.fgrid_OpCdLine.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_OpCdLine.Size = new System.Drawing.Size(507, 340);
            this.fgrid_OpCdLine.StyleInfo = resources.GetString("fgrid_OpCdLine.StyleInfo");
            this.fgrid_OpCdLine.TabIndex = 51;
            this.fgrid_OpCdLine.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_OpCdLine_AfterEdit);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(475, 78);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 340);
            this.splitter2.TabIndex = 33;
            this.splitter2.TabStop = false;
            // 
            // pnl_OLBM
            // 
            this.pnl_OLBM.Controls.Add(this.fgrid_OLLine);
            this.pnl_OLBM.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_OLBM.Location = new System.Drawing.Point(243, 78);
            this.pnl_OLBM.Name = "pnl_OLBM";
            this.pnl_OLBM.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnl_OLBM.Size = new System.Drawing.Size(232, 340);
            this.pnl_OLBM.TabIndex = 32;
            // 
            // fgrid_OLLine
            // 
            this.fgrid_OLLine.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_OLLine.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_OLLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_OLLine.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgrid_OLLine.Location = new System.Drawing.Point(0, 0);
            this.fgrid_OLLine.Name = "fgrid_OLLine";
            this.fgrid_OLLine.Rows.DefaultSize = 19;
            this.fgrid_OLLine.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_OLLine.Size = new System.Drawing.Size(227, 340);
            this.fgrid_OLLine.StyleInfo = resources.GetString("fgrid_OLLine.StyleInfo");
            this.fgrid_OLLine.TabIndex = 51;
            this.fgrid_OLLine.Click += new System.EventHandler(this.fgrid_OLLine_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(240, 78);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 340);
            this.splitter1.TabIndex = 31;
            this.splitter1.TabStop = false;
            // 
            // pnl_OLBL
            // 
            this.pnl_OLBL.Controls.Add(this.fgrid_OLOpCd);
            this.pnl_OLBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_OLBL.Location = new System.Drawing.Point(8, 78);
            this.pnl_OLBL.Name = "pnl_OLBL";
            this.pnl_OLBL.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnl_OLBL.Size = new System.Drawing.Size(232, 340);
            this.pnl_OLBL.TabIndex = 30;
            // 
            // fgrid_OLOpCd
            // 
            this.fgrid_OLOpCd.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_OLOpCd.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_OLOpCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_OLOpCd.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgrid_OLOpCd.Location = new System.Drawing.Point(0, 0);
            this.fgrid_OLOpCd.Name = "fgrid_OLOpCd";
            this.fgrid_OLOpCd.Rows.DefaultSize = 19;
            this.fgrid_OLOpCd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_OLOpCd.Size = new System.Drawing.Size(227, 340);
            this.fgrid_OLOpCd.StyleInfo = resources.GetString("fgrid_OLOpCd.StyleInfo");
            this.fgrid_OLOpCd.TabIndex = 50;
            this.fgrid_OLOpCd.Click += new System.EventHandler(this.fgrid_OLOpCd_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(8, 418);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel4.Size = new System.Drawing.Size(982, 90);
            this.panel4.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.lbl_OLCopy2);
            this.panel5.Controls.Add(this.cmb_OLLine2);
            this.panel5.Controls.Add(this.cmb_OLLine1);
            this.panel5.Controls.Add(this.cmb_OLOpCd3);
            this.panel5.Controls.Add(this.btn_RunCopy);
            this.panel5.Controls.Add(this.lbl_OLCopy1);
            this.panel5.Controls.Add(this.cmb_OLOpCd2);
            this.panel5.Controls.Add(this.cmb_OLOpCd1);
            this.panel5.Controls.Add(this.rad_Line);
            this.panel5.Controls.Add(this.rad_Op);
            this.panel5.Controls.Add(this.pictureBox9);
            this.panel5.Controls.Add(this.pictureBox10);
            this.panel5.Controls.Add(this.pictureBox11);
            this.panel5.Controls.Add(this.pictureBox12);
            this.panel5.Controls.Add(this.pictureBox13);
            this.panel5.Controls.Add(this.pictureBox14);
            this.panel5.Controls.Add(this.lbl_SubTitle5);
            this.panel5.Controls.Add(this.pictureBox15);
            this.panel5.Controls.Add(this.pictureBox16);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(0, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(982, 85);
            this.panel5.TabIndex = 19;
            // 
            // lbl_OLCopy2
            // 
            this.lbl_OLCopy2.Location = new System.Drawing.Point(344, 56);
            this.lbl_OLCopy2.Name = "lbl_OLCopy2";
            this.lbl_OLCopy2.Size = new System.Drawing.Size(66, 21);
            this.lbl_OLCopy2.TabIndex = 126;
            this.lbl_OLCopy2.Text = "Copy to";
            this.lbl_OLCopy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_OLLine2
            // 
            this.cmb_OLLine2.AddItemSeparator = ';';
            this.cmb_OLLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OLLine2.Caption = "";
            this.cmb_OLLine2.CaptionHeight = 17;
            this.cmb_OLLine2.CaptionStyle = style81;
            this.cmb_OLLine2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OLLine2.ColumnCaptionHeight = 18;
            this.cmb_OLLine2.ColumnFooterHeight = 18;
            this.cmb_OLLine2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OLLine2.ContentHeight = 17;
            this.cmb_OLLine2.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OLLine2.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OLLine2.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLLine2.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OLLine2.EditorHeight = 17;
            this.cmb_OLLine2.EvenRowStyle = style82;
            this.cmb_OLLine2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLLine2.FooterStyle = style83;
            this.cmb_OLLine2.HeadingStyle = style84;
            this.cmb_OLLine2.HighLightRowStyle = style85;
            this.cmb_OLLine2.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OLLine2.Images"))));
            this.cmb_OLLine2.ItemHeight = 15;
            this.cmb_OLLine2.Location = new System.Drawing.Point(410, 56);
            this.cmb_OLLine2.MatchEntryTimeout = ((long)(2000));
            this.cmb_OLLine2.MaxDropDownItems = ((short)(5));
            this.cmb_OLLine2.MaxLength = 32767;
            this.cmb_OLLine2.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OLLine2.Name = "cmb_OLLine2";
            this.cmb_OLLine2.OddRowStyle = style86;
            this.cmb_OLLine2.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OLLine2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OLLine2.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OLLine2.SelectedStyle = style87;
            this.cmb_OLLine2.Size = new System.Drawing.Size(113, 21);
            this.cmb_OLLine2.Style = style88;
            this.cmb_OLLine2.TabIndex = 125;
            this.cmb_OLLine2.PropBag = resources.GetString("cmb_OLLine2.PropBag");
            // 
            // cmb_OLLine1
            // 
            this.cmb_OLLine1.AddItemSeparator = ';';
            this.cmb_OLLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OLLine1.Caption = "";
            this.cmb_OLLine1.CaptionHeight = 17;
            this.cmb_OLLine1.CaptionStyle = style89;
            this.cmb_OLLine1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OLLine1.ColumnCaptionHeight = 18;
            this.cmb_OLLine1.ColumnFooterHeight = 18;
            this.cmb_OLLine1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OLLine1.ContentHeight = 17;
            this.cmb_OLLine1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OLLine1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OLLine1.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLLine1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OLLine1.EditorHeight = 17;
            this.cmb_OLLine1.EvenRowStyle = style90;
            this.cmb_OLLine1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLLine1.FooterStyle = style91;
            this.cmb_OLLine1.HeadingStyle = style92;
            this.cmb_OLLine1.HighLightRowStyle = style93;
            this.cmb_OLLine1.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OLLine1.Images"))));
            this.cmb_OLLine1.ItemHeight = 15;
            this.cmb_OLLine1.Location = new System.Drawing.Point(232, 56);
            this.cmb_OLLine1.MatchEntryTimeout = ((long)(2000));
            this.cmb_OLLine1.MaxDropDownItems = ((short)(5));
            this.cmb_OLLine1.MaxLength = 32767;
            this.cmb_OLLine1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OLLine1.Name = "cmb_OLLine1";
            this.cmb_OLLine1.OddRowStyle = style94;
            this.cmb_OLLine1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OLLine1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OLLine1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OLLine1.SelectedStyle = style95;
            this.cmb_OLLine1.Size = new System.Drawing.Size(113, 21);
            this.cmb_OLLine1.Style = style96;
            this.cmb_OLLine1.TabIndex = 124;
            this.cmb_OLLine1.PropBag = resources.GetString("cmb_OLLine1.PropBag");
            // 
            // cmb_OLOpCd3
            // 
            this.cmb_OLOpCd3.AddItemSeparator = ';';
            this.cmb_OLOpCd3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OLOpCd3.Caption = "";
            this.cmb_OLOpCd3.CaptionHeight = 17;
            this.cmb_OLOpCd3.CaptionStyle = style97;
            this.cmb_OLOpCd3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OLOpCd3.ColumnCaptionHeight = 18;
            this.cmb_OLOpCd3.ColumnFooterHeight = 18;
            this.cmb_OLOpCd3.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OLOpCd3.ContentHeight = 17;
            this.cmb_OLOpCd3.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OLOpCd3.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OLOpCd3.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLOpCd3.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OLOpCd3.EditorHeight = 17;
            this.cmb_OLOpCd3.EvenRowStyle = style98;
            this.cmb_OLOpCd3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLOpCd3.FooterStyle = style99;
            this.cmb_OLOpCd3.HeadingStyle = style100;
            this.cmb_OLOpCd3.HighLightRowStyle = style101;
            this.cmb_OLOpCd3.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OLOpCd3.Images"))));
            this.cmb_OLOpCd3.ItemHeight = 15;
            this.cmb_OLOpCd3.Location = new System.Drawing.Point(104, 56);
            this.cmb_OLOpCd3.MatchEntryTimeout = ((long)(2000));
            this.cmb_OLOpCd3.MaxDropDownItems = ((short)(5));
            this.cmb_OLOpCd3.MaxLength = 32767;
            this.cmb_OLOpCd3.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OLOpCd3.Name = "cmb_OLOpCd3";
            this.cmb_OLOpCd3.OddRowStyle = style102;
            this.cmb_OLOpCd3.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OLOpCd3.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OLOpCd3.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OLOpCd3.SelectedStyle = style103;
            this.cmb_OLOpCd3.Size = new System.Drawing.Size(113, 21);
            this.cmb_OLOpCd3.Style = style104;
            this.cmb_OLOpCd3.TabIndex = 123;
            this.cmb_OLOpCd3.PropBag = resources.GetString("cmb_OLOpCd3.PropBag");
            // 
            // btn_RunCopy
            // 
            this.btn_RunCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RunCopy.ImageIndex = 0;
            this.btn_RunCopy.ImageList = this.img_Button;
            this.btn_RunCopy.Location = new System.Drawing.Point(896, 32);
            this.btn_RunCopy.Name = "btn_RunCopy";
            this.btn_RunCopy.Size = new System.Drawing.Size(82, 23);
            this.btn_RunCopy.TabIndex = 122;
            this.btn_RunCopy.Text = "Run Copy";
            this.btn_RunCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_RunCopy.Click += new System.EventHandler(this.btn_RunCopy_Click);
            this.btn_RunCopy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_RunCopy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_OLCopy1
            // 
            this.lbl_OLCopy1.Location = new System.Drawing.Point(217, 34);
            this.lbl_OLCopy1.Name = "lbl_OLCopy1";
            this.lbl_OLCopy1.Size = new System.Drawing.Size(66, 21);
            this.lbl_OLCopy1.TabIndex = 51;
            this.lbl_OLCopy1.Text = "Copy to";
            this.lbl_OLCopy1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_OLOpCd2
            // 
            this.cmb_OLOpCd2.AddItemSeparator = ';';
            this.cmb_OLOpCd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OLOpCd2.Caption = "";
            this.cmb_OLOpCd2.CaptionHeight = 17;
            this.cmb_OLOpCd2.CaptionStyle = style105;
            this.cmb_OLOpCd2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OLOpCd2.ColumnCaptionHeight = 18;
            this.cmb_OLOpCd2.ColumnFooterHeight = 18;
            this.cmb_OLOpCd2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OLOpCd2.ContentHeight = 17;
            this.cmb_OLOpCd2.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OLOpCd2.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OLOpCd2.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLOpCd2.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OLOpCd2.EditorHeight = 17;
            this.cmb_OLOpCd2.EvenRowStyle = style106;
            this.cmb_OLOpCd2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLOpCd2.FooterStyle = style107;
            this.cmb_OLOpCd2.HeadingStyle = style108;
            this.cmb_OLOpCd2.HighLightRowStyle = style109;
            this.cmb_OLOpCd2.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OLOpCd2.Images"))));
            this.cmb_OLOpCd2.ItemHeight = 15;
            this.cmb_OLOpCd2.Location = new System.Drawing.Point(283, 34);
            this.cmb_OLOpCd2.MatchEntryTimeout = ((long)(2000));
            this.cmb_OLOpCd2.MaxDropDownItems = ((short)(5));
            this.cmb_OLOpCd2.MaxLength = 32767;
            this.cmb_OLOpCd2.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OLOpCd2.Name = "cmb_OLOpCd2";
            this.cmb_OLOpCd2.OddRowStyle = style110;
            this.cmb_OLOpCd2.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OLOpCd2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OLOpCd2.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OLOpCd2.SelectedStyle = style111;
            this.cmb_OLOpCd2.Size = new System.Drawing.Size(113, 21);
            this.cmb_OLOpCd2.Style = style112;
            this.cmb_OLOpCd2.TabIndex = 50;
            this.cmb_OLOpCd2.PropBag = resources.GetString("cmb_OLOpCd2.PropBag");
            // 
            // cmb_OLOpCd1
            // 
            this.cmb_OLOpCd1.AddItemSeparator = ';';
            this.cmb_OLOpCd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OLOpCd1.Caption = "";
            this.cmb_OLOpCd1.CaptionHeight = 17;
            this.cmb_OLOpCd1.CaptionStyle = style113;
            this.cmb_OLOpCd1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OLOpCd1.ColumnCaptionHeight = 18;
            this.cmb_OLOpCd1.ColumnFooterHeight = 18;
            this.cmb_OLOpCd1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OLOpCd1.ContentHeight = 17;
            this.cmb_OLOpCd1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OLOpCd1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OLOpCd1.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLOpCd1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OLOpCd1.EditorHeight = 17;
            this.cmb_OLOpCd1.EvenRowStyle = style114;
            this.cmb_OLOpCd1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLOpCd1.FooterStyle = style115;
            this.cmb_OLOpCd1.HeadingStyle = style116;
            this.cmb_OLOpCd1.HighLightRowStyle = style117;
            this.cmb_OLOpCd1.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OLOpCd1.Images"))));
            this.cmb_OLOpCd1.ItemHeight = 15;
            this.cmb_OLOpCd1.Location = new System.Drawing.Point(104, 34);
            this.cmb_OLOpCd1.MatchEntryTimeout = ((long)(2000));
            this.cmb_OLOpCd1.MaxDropDownItems = ((short)(5));
            this.cmb_OLOpCd1.MaxLength = 32767;
            this.cmb_OLOpCd1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OLOpCd1.Name = "cmb_OLOpCd1";
            this.cmb_OLOpCd1.OddRowStyle = style118;
            this.cmb_OLOpCd1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OLOpCd1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OLOpCd1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OLOpCd1.SelectedStyle = style119;
            this.cmb_OLOpCd1.Size = new System.Drawing.Size(113, 21);
            this.cmb_OLOpCd1.Style = style120;
            this.cmb_OLOpCd1.TabIndex = 48;
            this.cmb_OLOpCd1.PropBag = resources.GetString("cmb_OLOpCd1.PropBag");
            // 
            // rad_Line
            // 
            this.rad_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_Line.Location = new System.Drawing.Point(10, 57);
            this.rad_Line.Name = "rad_Line";
            this.rad_Line.Size = new System.Drawing.Size(86, 21);
            this.rad_Line.TabIndex = 46;
            this.rad_Line.Text = "Assy. Line";
            this.rad_Line.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_Op
            // 
            this.rad_Op.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_Op.Location = new System.Drawing.Point(10, 36);
            this.rad_Op.Name = "rad_Op";
            this.rad_Op.Size = new System.Drawing.Size(86, 21);
            this.rad_Op.TabIndex = 45;
            this.rad_Op.Text = "Proc";
            this.rad_Op.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(965, 24);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(17, 50);
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(966, 70);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(16, 16);
            this.pictureBox10.TabIndex = 23;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(131, 69);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(982, 18);
            this.pictureBox11.TabIndex = 28;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(966, 0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(16, 32);
            this.pictureBox12.TabIndex = 21;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(224, 0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(982, 32);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(160, 24);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(982, 45);
            this.pictureBox14.TabIndex = 27;
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
            this.lbl_SubTitle5.Text = "      Copy Option";
            this.lbl_SubTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(0, 24);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(168, 52);
            this.pictureBox15.TabIndex = 25;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(0, 70);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(168, 20);
            this.pictureBox16.TabIndex = 22;
            this.pictureBox16.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel1.Size = new System.Drawing.Size(982, 70);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.cmb_OLLineGroup);
            this.panel2.Controls.Add(this.lbl_OLLineGroup);
            this.panel2.Controls.Add(this.cmb_OLFactory);
            this.panel2.Controls.Add(this.lbl_OLFactory);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.lbl_SubTitle4);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 65);
            this.panel2.TabIndex = 19;
            // 
            // cmb_OLLineGroup
            // 
            this.cmb_OLLineGroup.AddItemSeparator = ';';
            this.cmb_OLLineGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OLLineGroup.Caption = "";
            this.cmb_OLLineGroup.CaptionHeight = 17;
            this.cmb_OLLineGroup.CaptionStyle = style121;
            this.cmb_OLLineGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OLLineGroup.ColumnCaptionHeight = 18;
            this.cmb_OLLineGroup.ColumnFooterHeight = 18;
            this.cmb_OLLineGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OLLineGroup.ContentHeight = 17;
            this.cmb_OLLineGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OLLineGroup.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OLLineGroup.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLLineGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OLLineGroup.EditorHeight = 17;
            this.cmb_OLLineGroup.EvenRowStyle = style122;
            this.cmb_OLLineGroup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLLineGroup.FooterStyle = style123;
            this.cmb_OLLineGroup.HeadingStyle = style124;
            this.cmb_OLLineGroup.HighLightRowStyle = style125;
            this.cmb_OLLineGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OLLineGroup.Images"))));
            this.cmb_OLLineGroup.ItemHeight = 15;
            this.cmb_OLLineGroup.Location = new System.Drawing.Point(341, 36);
            this.cmb_OLLineGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_OLLineGroup.MaxDropDownItems = ((short)(5));
            this.cmb_OLLineGroup.MaxLength = 32767;
            this.cmb_OLLineGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OLLineGroup.Name = "cmb_OLLineGroup";
            this.cmb_OLLineGroup.OddRowStyle = style126;
            this.cmb_OLLineGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OLLineGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OLLineGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OLLineGroup.SelectedStyle = style127;
            this.cmb_OLLineGroup.Size = new System.Drawing.Size(113, 21);
            this.cmb_OLLineGroup.Style = style128;
            this.cmb_OLLineGroup.TabIndex = 40;
            this.cmb_OLLineGroup.SelectedValueChanged += new System.EventHandler(this.cmb_OLLineGroup_SelectedValueChanged);
            this.cmb_OLLineGroup.PropBag = resources.GetString("cmb_OLLineGroup.PropBag");
            // 
            // lbl_OLLineGroup
            // 
            this.lbl_OLLineGroup.ImageIndex = 0;
            this.lbl_OLLineGroup.ImageList = this.img_Label;
            this.lbl_OLLineGroup.Location = new System.Drawing.Point(240, 36);
            this.lbl_OLLineGroup.Name = "lbl_OLLineGroup";
            this.lbl_OLLineGroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_OLLineGroup.TabIndex = 39;
            this.lbl_OLLineGroup.Text = "Line Group";
            this.lbl_OLLineGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_OLFactory
            // 
            this.cmb_OLFactory.AddItemSeparator = ';';
            this.cmb_OLFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OLFactory.Caption = "";
            this.cmb_OLFactory.CaptionHeight = 17;
            this.cmb_OLFactory.CaptionStyle = style129;
            this.cmb_OLFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OLFactory.ColumnCaptionHeight = 18;
            this.cmb_OLFactory.ColumnFooterHeight = 18;
            this.cmb_OLFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OLFactory.ContentHeight = 17;
            this.cmb_OLFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OLFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OLFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OLFactory.EditorHeight = 17;
            this.cmb_OLFactory.EvenRowStyle = style130;
            this.cmb_OLFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OLFactory.FooterStyle = style131;
            this.cmb_OLFactory.HeadingStyle = style132;
            this.cmb_OLFactory.HighLightRowStyle = style133;
            this.cmb_OLFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OLFactory.Images"))));
            this.cmb_OLFactory.ItemHeight = 15;
            this.cmb_OLFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_OLFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_OLFactory.MaxDropDownItems = ((short)(5));
            this.cmb_OLFactory.MaxLength = 32767;
            this.cmb_OLFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OLFactory.Name = "cmb_OLFactory";
            this.cmb_OLFactory.OddRowStyle = style134;
            this.cmb_OLFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OLFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OLFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OLFactory.SelectedStyle = style135;
            this.cmb_OLFactory.Size = new System.Drawing.Size(113, 21);
            this.cmb_OLFactory.Style = style136;
            this.cmb_OLFactory.TabIndex = 38;
            this.cmb_OLFactory.SelectedValueChanged += new System.EventHandler(this.cmb_OLFactory_SelectedValueChanged);
            this.cmb_OLFactory.PropBag = resources.GetString("cmb_OLFactory.PropBag");
            // 
            // lbl_OLFactory
            // 
            this.lbl_OLFactory.ImageIndex = 0;
            this.lbl_OLFactory.ImageList = this.img_Label;
            this.lbl_OLFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_OLFactory.Name = "lbl_OLFactory";
            this.lbl_OLFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_OLFactory.TabIndex = 37;
            this.lbl_OLFactory.Text = "Factory";
            this.lbl_OLFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(965, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 30);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(966, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(131, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(982, 18);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(966, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 32);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(224, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(982, 32);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(160, 24);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(982, 25);
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // lbl_SubTitle4
            // 
            this.lbl_SubTitle4.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle4.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle4.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle4.Image")));
            this.lbl_SubTitle4.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle4.Name = "lbl_SubTitle4";
            this.lbl_SubTitle4.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle4.TabIndex = 20;
            this.lbl_SubTitle4.Text = "      Production OP of MiniLine";
            this.lbl_SubTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 32);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 50);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(168, 20);
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            // 
            // obarpg_OpType
            // 
            this.obarpg_OpType.Controls.Add(this.pnl_OTBody);
            this.obarpg_OpType.Name = "obarpg_OpType";
            this.obarpg_OpType.PageVisible = false;
            this.obarpg_OpType.Size = new System.Drawing.Size(998, 496);
            this.obarpg_OpType.Text = "Operation Code Type Information and Default Node Property";
            // 
            // pnl_OTBody
            // 
            this.pnl_OTBody.Controls.Add(this.addflow_Main);
            this.pnl_OTBody.Controls.Add(this.splitter_Body);
            this.pnl_OTBody.Controls.Add(this.pnl_OTBodyLeft);
            this.pnl_OTBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_OTBody.Location = new System.Drawing.Point(0, 0);
            this.pnl_OTBody.Name = "pnl_OTBody";
            this.pnl_OTBody.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_OTBody.Size = new System.Drawing.Size(998, 496);
            this.pnl_OTBody.TabIndex = 36;
            // 
            // addflow_Main
            // 
            this.addflow_Main.AutoScroll = true;
            this.addflow_Main.AutoScrollMinSize = new System.Drawing.Size(792, 611);
            this.addflow_Main.CanDrawLink = false;
            this.addflow_Main.CanDrawNode = false;
            this.addflow_Main.ContextMenu = this.cmenu_Node;
            this.addflow_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addflow_Main.Location = new System.Drawing.Point(355, 8);
            this.addflow_Main.Name = "addflow_Main";
            this.addflow_Main.Size = new System.Drawing.Size(635, 480);
            this.addflow_Main.TabIndex = 26;
            this.addflow_Main.AfterResize += new Lassalle.Flow.AddFlow.AfterResizeEventHandler(this.addflow_Main_AfterResize);
            this.addflow_Main.AfterEdit += new Lassalle.Flow.AddFlow.AfterEditEventHandler(this.addflow_Main_AfterEdit);
            // 
            // cmenu_Node
            // 
            this.cmenu_Node.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_NodeProp,
            this.menuItem_NodeDel});
            // 
            // menuItem_NodeProp
            // 
            this.menuItem_NodeProp.Index = 0;
            this.menuItem_NodeProp.Text = "Node Property";
            this.menuItem_NodeProp.Click += new System.EventHandler(this.menuItem_NodeProp_Click);
            // 
            // menuItem_NodeDel
            // 
            this.menuItem_NodeDel.Index = 1;
            this.menuItem_NodeDel.Text = "Delete Node";
            this.menuItem_NodeDel.Click += new System.EventHandler(this.menuItem_NodeDel_Click);
            // 
            // splitter_Body
            // 
            this.splitter_Body.Location = new System.Drawing.Point(352, 8);
            this.splitter_Body.Name = "splitter_Body";
            this.splitter_Body.Size = new System.Drawing.Size(3, 480);
            this.splitter_Body.TabIndex = 24;
            this.splitter_Body.TabStop = false;
            // 
            // pnl_OTBodyLeft
            // 
            this.pnl_OTBodyLeft.Controls.Add(this.fgrid_OpType);
            this.pnl_OTBodyLeft.Controls.Add(this.pnl_SearchSplitLeft);
            this.pnl_OTBodyLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_OTBodyLeft.Location = new System.Drawing.Point(8, 8);
            this.pnl_OTBodyLeft.Name = "pnl_OTBodyLeft";
            this.pnl_OTBodyLeft.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnl_OTBodyLeft.Size = new System.Drawing.Size(344, 480);
            this.pnl_OTBodyLeft.TabIndex = 23;
            // 
            // fgrid_OpType
            // 
            this.fgrid_OpType.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_OpType.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_OpType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_OpType.Location = new System.Drawing.Point(0, 73);
            this.fgrid_OpType.Name = "fgrid_OpType";
            this.fgrid_OpType.Rows.DefaultSize = 19;
            this.fgrid_OpType.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_OpType.Size = new System.Drawing.Size(339, 407);
            this.fgrid_OpType.StyleInfo = resources.GetString("fgrid_OpType.StyleInfo");
            this.fgrid_OpType.TabIndex = 33;
            this.fgrid_OpType.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_OpType_AfterEdit);
            // 
            // pnl_SearchSplitLeft
            // 
            this.pnl_SearchSplitLeft.Controls.Add(this.pnl_SearchLeftImage);
            this.pnl_SearchSplitLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_SearchSplitLeft.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchSplitLeft.Name = "pnl_SearchSplitLeft";
            this.pnl_SearchSplitLeft.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_SearchSplitLeft.Size = new System.Drawing.Size(339, 73);
            this.pnl_SearchSplitLeft.TabIndex = 20;
            // 
            // pnl_SearchLeftImage
            // 
            this.pnl_SearchLeftImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchLeftImage.Controls.Add(this.cmb_OTFactory);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LMR);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LTR);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LTM);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LBR);
            this.pnl_SearchLeftImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchLeftImage.Controls.Add(this.lbl_OTFactory);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LBM);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LMM);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LML);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LBL);
            this.pnl_SearchLeftImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchLeftImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchLeftImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchLeftImage.Name = "pnl_SearchLeftImage";
            this.pnl_SearchLeftImage.Size = new System.Drawing.Size(339, 65);
            this.pnl_SearchLeftImage.TabIndex = 19;
            // 
            // cmb_OTFactory
            // 
            this.cmb_OTFactory.AddItemSeparator = ';';
            this.cmb_OTFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OTFactory.Caption = "";
            this.cmb_OTFactory.CaptionHeight = 17;
            this.cmb_OTFactory.CaptionStyle = style137;
            this.cmb_OTFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OTFactory.ColumnCaptionHeight = 18;
            this.cmb_OTFactory.ColumnFooterHeight = 18;
            this.cmb_OTFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OTFactory.ContentHeight = 17;
            this.cmb_OTFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OTFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OTFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OTFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OTFactory.EditorHeight = 17;
            this.cmb_OTFactory.EvenRowStyle = style138;
            this.cmb_OTFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OTFactory.FooterStyle = style139;
            this.cmb_OTFactory.HeadingStyle = style140;
            this.cmb_OTFactory.HighLightRowStyle = style141;
            this.cmb_OTFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OTFactory.Images"))));
            this.cmb_OTFactory.ItemHeight = 15;
            this.cmb_OTFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_OTFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_OTFactory.MaxDropDownItems = ((short)(5));
            this.cmb_OTFactory.MaxLength = 32767;
            this.cmb_OTFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OTFactory.Name = "cmb_OTFactory";
            this.cmb_OTFactory.OddRowStyle = style142;
            this.cmb_OTFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OTFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OTFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OTFactory.SelectedStyle = style143;
            this.cmb_OTFactory.Size = new System.Drawing.Size(210, 21);
            this.cmb_OTFactory.Style = style144;
            this.cmb_OTFactory.TabIndex = 36;
            this.cmb_OTFactory.SelectedValueChanged += new System.EventHandler(this.cmb_OTFactory_SelectedValueChanged);
            this.cmb_OTFactory.PropBag = resources.GetString("cmb_OTFactory.PropBag");
            // 
            // picb_LMR
            // 
            this.picb_LMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_LMR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMR.Image")));
            this.picb_LMR.Location = new System.Drawing.Point(322, 24);
            this.picb_LMR.Name = "picb_LMR";
            this.picb_LMR.Size = new System.Drawing.Size(17, 32);
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
            // picb_LBR
            // 
            this.picb_LBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_LBR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBR.Image")));
            this.picb_LBR.Location = new System.Drawing.Point(323, 50);
            this.picb_LBR.Name = "picb_LBR";
            this.picb_LBR.Size = new System.Drawing.Size(16, 16);
            this.picb_LBR.TabIndex = 23;
            this.picb_LBR.TabStop = false;
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
            this.lbl_SubTitle1.Text = "      Operation Type Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_OTFactory
            // 
            this.lbl_OTFactory.ImageIndex = 0;
            this.lbl_OTFactory.ImageList = this.img_Label;
            this.lbl_OTFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_OTFactory.Name = "lbl_OTFactory";
            this.lbl_OTFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_OTFactory.TabIndex = 35;
            this.lbl_OTFactory.Text = "Factory";
            this.lbl_OTFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_LBM
            // 
            this.picb_LBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_LBM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBM.Image")));
            this.picb_LBM.Location = new System.Drawing.Point(131, 49);
            this.picb_LBM.Name = "picb_LBM";
            this.picb_LBM.Size = new System.Drawing.Size(192, 18);
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
            this.picb_LMM.Size = new System.Drawing.Size(171, 25);
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
            this.picb_LML.Size = new System.Drawing.Size(168, 32);
            this.picb_LML.TabIndex = 25;
            this.picb_LML.TabStop = false;
            // 
            // picb_LBL
            // 
            this.picb_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_LBL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBL.Image")));
            this.picb_LBL.Location = new System.Drawing.Point(0, 50);
            this.picb_LBL.Name = "picb_LBL";
            this.picb_LBL.Size = new System.Drawing.Size(168, 20);
            this.picb_LBL.TabIndex = 22;
            this.picb_LBL.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.obar_Main);
            this.panel6.Location = new System.Drawing.Point(0, 65);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel6.Size = new System.Drawing.Size(1014, 576);
            this.panel6.TabIndex = 29;
            // 
            // Form_PB_OpCd
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.panel6);
            this.Name = "Form_PB_OpCd";
            this.Text = "Production Operation";
            this.Load += new System.EventHandler(this.Form_PB_OpCd_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
            this.obar_Main.ResumeLayout(false);
            this.obarpg_OpCd.ResumeLayout(false);
            this.pnl_SBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OpCd)).EndInit();
            this.pnl_SBodyTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OCFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.obarpg_OpLine.ResumeLayout(false);
            this.pnl_OLB.ResumeLayout(false);
            this.pnl_OLBR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OpCdLine)).EndInit();
            this.pnl_OLBM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OLLine)).EndInit();
            this.pnl_OLBL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OLOpCd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLOpCd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLOpCd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLOpCd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLLineGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OLFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.obarpg_OpType.ResumeLayout(false);
            this.pnl_OTBody.ResumeLayout(false);
            this.pnl_OTBodyLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OpType)).EndInit();
            this.pnl_SearchSplitLeft.ResumeLayout(false);
            this.pnl_SearchLeftImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OTFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBL)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion


		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();

		private int _Rowfixed;
		
		private Hashtable _Imgmap = new Hashtable();

		//삽입때마다 새로 그려지는 노드 정보
		private Lassalle.Flow.Node _AddNode;



		private int _OpCd_SelRow;
		private int _Line_SelRow;

		// opcd header 정보
		private DataTable _OpCdHeadDT = new DataTable("OpCdHeadTitle");


  
		#endregion 

		#region 멤버 메서드 
 

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{  

			DataTable dt_list;
			CellStyle cellst;
			 
			//Title
			this.Text = "Production Operation";
			this.lbl_MainTitle.Text = "Production Operation";  
 

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

			tbtn_Print.Enabled = false; 


//			cmb_OCFactory.Enabled = false;
//			cmb_OLFactory.Enabled = false;


			rad_Line.Checked = true;


			//공정 타입 
			ClassLib.ComFunction.Clear_AddFlow(addflow_Main); 

			fgrid_OpType.Set_Grid("NODE_OP_DEF", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			_Rowfixed = fgrid_OpType.Rows.Fixed;
			fgrid_OpType.Set_Action_Image(img_Action);

			//공정 코드
			fgrid_OpCd.Set_Grid("OP_CODE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			_Rowfixed = fgrid_OpCd.Rows.Fixed;
			fgrid_OpCd.Set_Action_Image(img_Action); 
			fgrid_OpCd.Cols[(int)ClassLib.TBSPB_OPCD.IxMOLD_TYPE].ComboList = "..."; 

			btn_SetDetailOpCd.Enabled = false;
			lbl_ODetailQty.Visible = false;
			txt_ODetailQty.Visible = false;
			btn_OAppendRow.Visible = false;

			

			//-------------------------------------------------------
			//첫번째 행 헤더 정보 저장 (실제 디비 필드명)
  
			DataRow datarow;

			for(int i = 0; i < fgrid_OpCd.Cols.Count; i++)
			{
				_OpCdHeadDT.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			} 

			//opcd
			datarow = _OpCdHeadDT.NewRow();
				 
			datarow[0] = "ARG_DIVISION";

			for(int i = 1; i < fgrid_OpCd.Cols.Count; i++)
			{ 
				datarow[i] = "ARG_" + fgrid_OpCd[0, i].ToString(); 

//				//첫번째 행에 두번째 행 정보 저장 (그리드 타이틀)
//				fgrid_OpCd[0, i] = fgrid_OpCd[1, i].ToString();
			} 
			 
			_OpCdHeadDT.Rows.Add(datarow); 

//			fgrid_OpCd.Rows[0].Visible = true;
//			fgrid_OpCd.Rows[1].Visible = false;
			//-------------------------------------------------------

 

			//공정 라인
			//SPB_OPCD_LINE
			fgrid_OLOpCd.Set_Grid("SPB_OPCD", "3", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);
			fgrid_OLLine.Set_Grid("SPB_LINE_CODE", "3", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);
			//fgrid_OpCdLine.Set_Grid("SPB_OPCD_LINE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_OpCdLine.Set_Grid("SPB_OPCD_LINE_AREA", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_OpCdLine.Set_Action_Image(img_Action); 


			cellst = fgrid_OpCdLine.Styles.Add("MASK");
			cellst.DataType = typeof(string);		 
			cellst.EditMask = "00D00H00M";

			fgrid_OpCdLine.Cols[(int)ClassLib.TBSPB_OPCD_LINE_AREA.IxPROD_TIME].Style = fgrid_OpCdLine.Styles["MASK"];




			//공장 리스트 
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OCFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OLFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 

			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OTFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
 

			
			cmb_OCFactory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_OLFactory.SelectedValue = ClassLib.ComVar.This_Factory;
 
			obar_Main.SelectedPage = obarpg_OpCd;


		}

		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			int grid_opcd = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_CD;
			int grid_areacd = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxAREA_CD;
			int grid_opname = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_NAME;
			int grid_remarks = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxREMARKS;
			int grid_count = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxCOUNT;
			int grid_div = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxDIV;
			int grid_parentopcd = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxPARENT_OPCD;


			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;  
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;
 
			if(arg_fgrid.Equals(fgrid_OpCd))
			{ 
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = "";
				
					if(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_COLOR].ToString() == "") continue;

					arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD).StyleNew.BackColor 
						= Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_COLOR].ToString()) );
				 
				}
			} 


			if(arg_fgrid.Equals(fgrid_OLOpCd))
			{

				arg_fgrid.Tree.Column = grid_opcd;
				arg_fgrid.Tree.Style = TreeStyleFlags.Complete; 
				arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 

				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxDIV - 1].ToString() == "1")
					{
						arg_fgrid.Rows.InsertNode(i + arg_fgrid.Rows.Fixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxDIV - 1].ToString()) - 1);

						arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_CD - 1].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_areacd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxAREA_CD - 1].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opname] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_NAME - 1].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_remarks] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxREMARKS - 1].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_count] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxCOUNT - 1].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_div] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxDIV - 1].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_parentopcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxPARENT_OPCD - 1].ToString();

						if(arg_fgrid[i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxCOUNT].ToString() == "0")
						{
							arg_fgrid.Rows[i + arg_fgrid.Rows.Fixed].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
						}

					}
					else if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxDIV - 1].ToString() == "2")
					{
						for(int j = arg_fgrid.Rows.Fixed; j < arg_fgrid.Rows.Count; j++)
						{
							if(arg_fgrid[j, (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_CD].ToString()
								== arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxPARENT_OPCD - 1].ToString() )
							{
								arg_fgrid.Rows.InsertNode(j + 1, Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxDIV - 1].ToString()) - 1);

								arg_fgrid[j + 1, 0] = ""; 
								arg_fgrid[j + 1, grid_opcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_CD - 1].ToString();
								arg_fgrid[j + 1, grid_areacd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxAREA_CD - 1].ToString();
								arg_fgrid[j + 1, grid_opname] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_NAME - 1].ToString();
								arg_fgrid[j + 1, grid_remarks] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxREMARKS - 1].ToString();
								arg_fgrid[j + 1, grid_count] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxCOUNT - 1].ToString();
								arg_fgrid[j + 1, grid_div] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxDIV - 1].ToString();
								arg_fgrid[j + 1, grid_parentopcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxPARENT_OPCD - 1].ToString();
 
								if(arg_fgrid[j + 1, (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxCOUNT].ToString() == "0")
								{
									arg_fgrid.Rows[j + 1].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
								}
							}

						}

						

					} // end if
 
				}
  
			} // end if

			
			if(arg_fgrid.Equals(fgrid_OLLine))
			{ 
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = ""; 

					if(arg_fgrid[arg_fgrid.Rows.Count - 1 , (int)ClassLib.TBSPB_OPCD_LINE_LINE.IxCOUNT].ToString() == "0") 
					{
						arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
					}

				}
			}  


			if(arg_fgrid.Equals(fgrid_OpCdLine))
			{ 

				//--------------------------------------------------------------------------------------
				// release_area_cd 콤보 리스트
				//--------------------------------------------------------------------------------------
				System.Collections.Specialized.ListDictionary ld = new System.Collections.Specialized.ListDictionary(); 

				string factory = cmb_OLFactory.SelectedValue.ToString();
				string op_cd = "UPS";
				DataTable dt_ret = Select_SPB_OPCD_AREA_CD(factory, op_cd);

				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					ld.Add(dt_ret.Rows[i].ItemArray[0].ToString(), dt_ret.Rows[i].ItemArray[1].ToString());  
				}

				fgrid_OpCdLine.Cols[(int)ClassLib.TBSPB_OPCD_LINE_AREA.IxRELEASE_AREA_CD].DataMap = ld; 
			
				dt_ret.Dispose();
				//--------------------------------------------------------------------------------------



				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = ""; 
				}

				

			} 

			 arg_fgrid.AutoSizeCols();
 
		}


		/// <summary>
		/// Display_TreeGrid : 트리 형태로 표시 
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_TreeGrid(DataTable arg_dt, COM.FSP arg_fgrid)
		{  
			int level = (int)ClassLib.TBSPB_OPCD.IxOP_LEVEL;
 
			int grid_factory = (int)ClassLib.TBSPB_OPCD_GRID.IxFACTORY; 
			int grid_opcd = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD;
			int grid_upcd = (int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD;
			int grid_areacd = (int)ClassLib.TBSPB_OPCD_GRID.IxAREA_CD;
			int grid_opname = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_NAME;
			int grid_optype = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_TYPE;
			int grid_deptcd = (int)ClassLib.TBSPB_OPCD_GRID.IxDEPT_CD;
			int grid_opcolor = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_COLOR;

			int grid_real = (int)ClassLib.TBSPB_OPCD_GRID.IxREAL_YN;
			int grid_capa = (int)ClassLib.TBSPB_OPCD_GRID.IxCAPA_YN;
			int grid_mold = (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN;
			int grid_out = (int)ClassLib.TBSPB_OPCD_GRID.IxOUT_YN;
			int grid_job = (int)ClassLib.TBSPB_OPCD_GRID.IxJOB_YN;
			int grid_pcard = (int)ClassLib.TBSPB_OPCD_GRID.IxPCARD_YN;
			int grid_rst = (int)ClassLib.TBSPB_OPCD_GRID.IxRST_YN;
			int grid_jit = (int)ClassLib.TBSPB_OPCD_GRID.IxMAT_AREA_YN;
			int grid_indetail = (int)ClassLib.TBSPB_OPCD_GRID.IxIN_DETAIL_YN;

			int grid_moldtype = (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE;
			int grid_dirmargin = (int)ClassLib.TBSPB_OPCD_GRID.IxDIR_MARGIN;
			int grid_remarks = (int)ClassLib.TBSPB_OPCD_GRID.IxREMARKS;
			int grid_upduser = (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_USER; 
			int grid_updymd = (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_YMD; 
			int grid_level = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL; 
			int grid_hopcd = (int)ClassLib.TBSPB_OPCD_GRID.IxH_OP_CD; 
			 
			try
			{
				arg_fgrid.Tree.Column = grid_opcd;
				arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 

				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.Rows.InsertNode(i + arg_fgrid.Rows.Fixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[level].ToString()) - 1);

					arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opname] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_NAME].ToString();

					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_factory] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxFACTORY].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_upcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxSG_CMP_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_areacd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxAREA_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_optype] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_TYPE].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_deptcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxDEPT_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opcolor] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_COLOR].ToString();

					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_real] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxREAL_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_capa] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxCAPA_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_mold] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxMOLD_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_out] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOUT_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_job] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxJOB_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_pcard] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxPCARD_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_rst] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxRST_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_jit] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxMAT_AREA_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_indetail] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxIN_DETAIL_YN].ToString();

					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldtype] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxMOLD_TYPE].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_dirmargin] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxDIR_MARGIN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_remarks] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxREMARKS].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_upduser] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxUPD_USER].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_updymd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxUPD_YMD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_level] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_LEVEL].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_hopcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxH_OP_CD].ToString();


				

					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_COLOR].ToString() == "") continue; 
					arg_fgrid.GetCellRange(i + arg_fgrid.Rows.Fixed, grid_opcd).StyleNew.BackColor 
						= Color.FromArgb(Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_COLOR].ToString()) ); 
					
//					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_LEVEL].ToString() == "2") continue;
//					arg_fgrid.Rows[i + arg_fgrid.Rows.Fixed].AllowEditing = true;

					

 
				} // end for i 

				arg_fgrid.AutoSizeCols();
				arg_fgrid.Tree.Style = TreeStyleFlags.Complete; 

			}
			catch
			{
			}

		}

		

		/// <summary>
		/// Display_TreeGrid_InDetail : 세부 공정을 상위공정아래 행에 삽입
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_TreeGrid_InDetail(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			int level = (int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_LEVEL;
 
			int grid_factory = (int)ClassLib.TBSPB_OPCD_GRID.IxFACTORY; 
			int grid_opcd = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD;
			int grid_upcd = (int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD;
			int grid_areacd = (int)ClassLib.TBSPB_OPCD_GRID.IxAREA_CD;
			int grid_opname = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_NAME;
			int grid_optype = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_TYPE;
			int grid_deptcd = (int)ClassLib.TBSPB_OPCD_GRID.IxDEPT_CD;
			int grid_opcolor = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_COLOR;

			int grid_real = (int)ClassLib.TBSPB_OPCD_GRID.IxREAL_YN;
			int grid_capa = (int)ClassLib.TBSPB_OPCD_GRID.IxCAPA_YN;
			int grid_mold = (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN;
			int grid_out = (int)ClassLib.TBSPB_OPCD_GRID.IxOUT_YN;
			int grid_job = (int)ClassLib.TBSPB_OPCD_GRID.IxJOB_YN;
			int grid_pcard = (int)ClassLib.TBSPB_OPCD_GRID.IxPCARD_YN;
			int grid_rst = (int)ClassLib.TBSPB_OPCD_GRID.IxRST_YN;
			int grid_jit = (int)ClassLib.TBSPB_OPCD_GRID.IxMAT_AREA_YN;
			int grid_indetail = (int)ClassLib.TBSPB_OPCD_GRID.IxIN_DETAIL_YN;

			int grid_moldtype = (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE;
			int grid_dirmargin = (int)ClassLib.TBSPB_OPCD_GRID.IxDIR_MARGIN;
			int grid_remarks = (int)ClassLib.TBSPB_OPCD_GRID.IxREMARKS;
			int grid_upduser = (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_USER; 
			int grid_updymd = (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_YMD; 
			int grid_level = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL; 
			int grid_hopcd = (int)ClassLib.TBSPB_OPCD_GRID.IxH_OP_CD; 

			try
			{
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					for(int j = arg_fgrid.Rows.Count - 1; j >= arg_fgrid.Rows.Fixed; j--)
					{
						//spb_opcd_indetail : parent_cmp == spb_opcd : cmp_cd
						//spb_opcd_indetail : parent_opcd == spb_opcd : op_cd

//						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD - 1].ToString()
//							== arg_fgrid[j, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD].ToString())

						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxPARENT_CMP].ToString()
							== arg_fgrid[j, (int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD].ToString()
							&& arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxPARENT_OPCD].ToString()
							== arg_fgrid[j, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD].ToString() )
						{
							arg_fgrid.Rows.InsertNode(j + 1, Convert.ToInt32(arg_dt.Rows[i].ItemArray[level].ToString()) - 1);

							arg_fgrid[j + 1, 0] = ""; 
							arg_fgrid[j + 1, grid_opcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_CD].ToString();
							arg_fgrid[j + 1, grid_opname] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_NAME].ToString();

							arg_fgrid[j + 1, grid_factory] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxFACTORY].ToString();
							arg_fgrid[j + 1, grid_upcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxPARENT_CMP].ToString();
							arg_fgrid[j + 1, grid_areacd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxAREA_CD].ToString();
							arg_fgrid[j + 1, grid_optype] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_TYPE].ToString();
							arg_fgrid[j + 1, grid_deptcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxDEPT_CD].ToString();
							arg_fgrid[j + 1, grid_opcolor] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_COLOR].ToString();

							arg_fgrid[j + 1, grid_real] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxREAL_YN].ToString();
							arg_fgrid[j + 1, grid_capa] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxCAPA_YN].ToString();
							arg_fgrid[j + 1, grid_mold] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxMOLD_YN].ToString();
							arg_fgrid[j + 1, grid_out] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOUT_YN].ToString();
							arg_fgrid[j + 1, grid_job] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxJOB_YN].ToString();
							arg_fgrid[j + 1, grid_pcard] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxPCARD_YN].ToString();
							arg_fgrid[j + 1, grid_rst] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxRST_YN].ToString();
							arg_fgrid[j + 1, grid_jit] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxJIT_YN].ToString();
							arg_fgrid[j + 1, grid_indetail] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxIN_DETAIL_YN].ToString();

							arg_fgrid[j + 1, grid_moldtype] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxMOLD_TYPE].ToString();
							arg_fgrid[j + 1, grid_dirmargin] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxDIR_MARGIN].ToString();
							arg_fgrid[j + 1, grid_remarks] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxREMARKS].ToString();
							arg_fgrid[j + 1, grid_upduser] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxUPD_USER].ToString();
							arg_fgrid[j + 1, grid_updymd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxUPD_YMD].ToString();
							arg_fgrid[j + 1, grid_level] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_LEVEL].ToString();
							arg_fgrid[j + 1, grid_hopcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxH_OP_CD].ToString();
 

							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_COLOR].ToString() == "") continue; 
							arg_fgrid.GetCellRange(j + 1, grid_opcd).StyleNew.BackColor 
								= Color.FromArgb(Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_COLOR].ToString()) ); 
					
						} 

					} // end for j 
				} // end for i

				arg_fgrid.AutoSizeCols();

			}
			catch
			{
			}
		}


		/// <summary>
		/// Select_OpType_Node_List : Node List Select
		/// </summary>
		private void Select_OpType_Node_List()
		{
			int i;
			int top_point = 50;

			Lassalle.Flow.Node node; 

			 
			for(i = _Rowfixed; i < fgrid_OpType.Rows.Count ; i++)
			{

				node = new Lassalle.Flow.Node();

				node = addflow_Main.Nodes.Add(100, top_point,  
					Convert.ToSingle(fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxWIDTH].ToString()), 
					Convert.ToSingle(fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxHEIGHT].ToString()), "");

				node.Text =  fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE_NAME].ToString(); 
				node.Tooltip = node.Text;
				node.Tag = fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE].ToString(); 
 
				Set_NodeProp(fgrid_OpType, node, i); 

				top_point = top_point + Convert.ToInt32(fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxHEIGHT].ToString()) + 10;

			} //end for  

		}




		/// <summary>
		/// 노드 정보 가져오기
		/// </summary>
		private void Set_NodeProp(C1FlexGrid arg_fgrid, Lassalle.Flow.Node arg_node, int arg_index)
		{ 
			   
		
			//Alignment
			foreach (Alignment v in Enum.GetValues(typeof(Alignment)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxALIGNMENT].ToString() == v.GetHashCode().ToString())
				{
					arg_node.Alignment = v; 
					break;
				}
			}

			//DashStyle
			foreach (System.Drawing.Drawing2D.DashStyle v in Enum.GetValues(typeof(System.Drawing.Drawing2D.DashStyle)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxDASHSTYLE].ToString() == v.GetHashCode().ToString())
				{
					arg_node.DashStyle = v;
					break;
				}
			}

			arg_node.DrawColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxDRAWCOLOR].ToString()));
			arg_node.DrawWidth = Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxDRAWWIDTH].ToString());
			arg_node.FillColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxFILLCOLOR].ToString()));

			//Font 속성
			arg_node.Font = ClassLib.ComFunction.ToFont(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxFONT].ToString());

			//Gradient 속성
			arg_node.Gradient = (arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADI_YN].ToString() == "Y" ? true : false);

			if (arg_node.Gradient)
			{
				arg_node.GradientColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADICOLOR].ToString()));
				
				foreach (System.Drawing.Drawing2D.LinearGradientMode v in Enum.GetValues(typeof(System.Drawing.Drawing2D.LinearGradientMode)))
				{
					if(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADIMODE].ToString() == v.GetHashCode().ToString())
					{
						arg_node.GradientMode = v;
						break;
					}
				}
			}   //end if
    
			//Shaow 
			if(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHADOW].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHADOW].ToString().Split(delimiter); 

				/////shadow -> style
				foreach (ShadowStyle v in Enum.GetValues(typeof(ShadowStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shadow.Style = v;
						break;
					}
				}
              
				/////shadow -> color, width, height
				arg_node.Shadow.Color = Color.FromArgb(Convert.ToInt32(token[1]));
				arg_node.Shadow.Size = new Size(Convert.ToInt32(token[2]), Convert.ToInt32(token[3]));

			}

			//Shape
			if(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHAPE].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHAPE].ToString().Split(delimiter); 

				////shape -> style
				foreach (ShapeStyle v in Enum.GetValues(typeof(ShapeStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shape.Style = v;
						break;
					}
				}  
		 
				////shape -> orientation
				foreach (ShapeOrientation v in Enum.GetValues(typeof(ShapeOrientation)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shape.Orientation = v;
						break;
					}
				}  
			}
 
			//TextColor
			arg_node.TextColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxTEXTCOLOR].ToString()));
 
		}

 
 
		/// <summary>
		/// Set_Color : 배경색, 글자색 지정
		/// </summary>
		private void Set_Color()
		{
			ColorDialog clrdig = new ColorDialog();
			int r1, r2;
			int from_row, to_row;
			int i; 

			r1 = fgrid_OpCd.Selection.r1;
			r2 = fgrid_OpCd.Selection.r2;
 

			from_row = (r1 < r2) ? r1 : r2;
			to_row = (r1 < r2) ? r2 : r1;

			if(clrdig.ShowDialog() == DialogResult.OK)
			{
				for(i = from_row; i <= to_row; i++)
				{
					fgrid_OpCd[i, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_COLOR] = clrdig.Color.ToArgb().ToString(); 
					if(fgrid_OpCd[i, 0].ToString() == "") fgrid_OpCd[i, 0] = "U"; 
					fgrid_OpCd.GetCellRange(i, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD).StyleNew.BackColor = clrdig.Color;
				} //end for
			} // end if


		}

		/// <summary>
		/// Delete_SPB_OPCD : 삭제
		/// </summary>
		private void Delete_SPB_OPCD()
		{
			try
			{
				int sel_row = fgrid_OpCd.Selection.r1;
				string sel_level = fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL].ToString();

				int torow = 0;

				//신규로 삽입 상태
				if(fgrid_OpCd[sel_row, 0].ToString() == "I")
				{
					switch(sel_level)
					{
							//하위까지 삭제
						case "1":   
 
							torow = fgrid_OpCd.FindRow(sel_level.ToString(), sel_row + 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL, false, true, false);
							if(torow == -1) torow = fgrid_OpCd.Rows.Count;

							for(int i = torow - 1; i >= sel_row; i--) fgrid_OpCd.Rows.Remove(i);

							break;
					
							//현재행만 삭제
						case "2":

							fgrid_OpCd.Rows.Remove(sel_row);

							break;
					}
				
				}
					//수정, 삭제 상태
				else
				{
					switch(sel_level)
					{
							//하위까지 삭제
						case "1":   
 
//							torow = fgrid_OpCd.FindRow(sel_level.ToString(), sel_row + 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL, false, true, false);
//							if(torow == -1) torow = fgrid_OpCd.Rows.Count;
//							
//							for(int i = torow - 1; i >= sel_row; i--) fgrid_OpCd[i, 0] = "D"; 
 							 
							int sel_r1 = fgrid_OpCd.Selection.r1;
							int sel_r2 = fgrid_OpCd.Selection.r2; 
							int start_row, end_row;
 
							start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
							end_row = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

							for(int i = start_row; i <= end_row; i++)
							{
								torow = fgrid_OpCd.FindRow(sel_level.ToString(), i + 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL, false, true, false);
								if(torow == -1) torow = fgrid_OpCd.Rows.Count;
								
								for(int j = torow - 1; j >= i; j--) fgrid_OpCd[j, 0] = "D";
							}

							break;
					
							//현재행만 삭제
						case "2":

							//fgrid_OpCd[sel_row, 0] = "D";
							fgrid_OpCd.Delete_Row();

							break;
					}

				} // end if
			}
			catch
			{
			}

		}

		#endregion 

		#region 이벤트 처리


		#region 공통 이벤트
		
		private void obar_Main_SelectedPageChanged(object sender, System.EventArgs e)
		{
 
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_OpType":
					_Rowfixed = fgrid_OpType.Rows.Fixed;
 
					tbtn_Append.Enabled = true;
					tbtn_Insert.Enabled = true;
					tbtn_Color.Enabled = false;

					break;

				case "obarpg_OpCd": 
					_Rowfixed = fgrid_OpCd.Rows.Fixed;  

					tbtn_Append.Enabled = true;
					tbtn_Insert.Enabled = true;
					tbtn_Color.Enabled = true;

					break;  

				case "obarpg_OpLine": 
					_Rowfixed = fgrid_OpCdLine.Rows.Fixed; 

					tbtn_Append.Enabled = true;
					tbtn_Insert.Enabled = true;
					tbtn_Color.Enabled = false;
 
					break;

			}


		}


 
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_OpType":
					//cmb_OTFactory.SelectedIndex = -1;
					fgrid_OpType.Rows.Count = _Rowfixed;
					ClassLib.ComFunction.Clear_AddFlow(addflow_Main);

					break;

				case "obarpg_OpCd": 
					//cmb_OCFactory.SelectedIndex = -1;
					fgrid_OpCd.Rows.Count = _Rowfixed;  

					break;
 
				case "obarpg_OpLine": 
					 
					//cmb_OLFactory.SelectedIndex = -1;
					
					fgrid_OLOpCd.Rows.Count = fgrid_OLOpCd.Rows.Fixed;
					fgrid_OLLine.Rows.Count = fgrid_OLLine.Rows.Fixed;
					fgrid_OpCdLine.Rows.Count = fgrid_OpCdLine.Rows.Fixed;
 

					break;


			}
		}



		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_OpType":
					if(cmb_OTFactory.SelectedIndex == -1) return;
					 
					dt_ret = Select_OpType_List();
					Display_Grid(dt_ret, fgrid_OpType);

					ClassLib.ComFunction.Clear_AddFlow(addflow_Main);
					Select_OpType_Node_List(); 
 
					break;

				case "obarpg_OpCd": 

					DataSet ds_ret;
					DataTable dt_opcd, dt_detail_opcd;

					if(cmb_OCFactory.SelectedIndex == -1) return;
			  
					ds_ret = Select_Display_SPB_OPCD(cmb_OCFactory.SelectedValue.ToString());
					dt_opcd = ds_ret.Tables["PKG_SPB_OPCD.SELECT_SPB_OPCD_H"];
					dt_detail_opcd = ds_ret.Tables["PKG_SPB_OPCD.SELECT_SPB_OPCD_INDETAIL_D"];
					Display_TreeGrid(dt_opcd, fgrid_OpCd);
					Display_TreeGrid_InDetail(dt_detail_opcd, fgrid_OpCd);
		 
					break;
 
				case "obarpg_OpLine":  

					dt_ret = Select_OpCd_List_ForOpLine(cmb_OLFactory.SelectedValue.ToString() );
					Display_Grid(dt_ret, fgrid_OLOpCd);
					fgrid_OLOpCd.Select(fgrid_OLOpCd.Rows.Fixed, 1, fgrid_OLOpCd.Rows.Fixed, fgrid_OLOpCd.Cols.Count - 1, true);
					fgrid_OLOpCd_Click(null, null);

					dt_ret = Select_SPB_LINE();
					Display_Grid(dt_ret, fgrid_OLLine);
					fgrid_OLLine.Select(fgrid_OLLine.Rows.Fixed, 1, fgrid_OLLine.Rows.Fixed, fgrid_OLLine.Cols.Count - 1, true);
					fgrid_OLLine_Click(null, null); 

					break;

			}
 

		}



		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_OpType":
					//행 수정 상태 해제
					fgrid_OpType.Select(fgrid_OpType.Selection.r1, 0, fgrid_OpType.Selection.r1, fgrid_OpType.Cols.Count-1, false);
 
					//ClassLib.ComFunction.Save_List(24, "PKG_SPB_OPCD.SAVE_OPTYPE_LIST", fgrid_OpType, _Rowfixed);

					MyOraDB.Save_FlexGird("PKG_SPB_OPCD.SAVE_OPTYPE_LIST", fgrid_OpType);

					dt_ret = Select_OpType_List();
					Display_Grid(dt_ret, fgrid_OpType);

					ClassLib.ComFunction.Clear_AddFlow(addflow_Main);
					Select_OpType_Node_List();
 
					break;

				case "obarpg_OpCd": 
					//행 수정 상태 해제
					fgrid_OpCd.Select(fgrid_OpCd.Selection.r1, 0, fgrid_OpCd.Selection.r1, fgrid_OpCd.Cols.Count-1, false);
  
					//MyOraDB.Save_FlexGird("PKG_SPB_OPCD.SAVE_OPCD_LIST", fgrid_OpCd);

					Save_SPB_OPCD();

					DataSet ds_ret;
					DataTable dt_opcd, dt_detail_opcd;

					if(cmb_OCFactory.SelectedIndex == -1) return;
			  
					ds_ret = Select_Display_SPB_OPCD(cmb_OCFactory.SelectedValue.ToString());
					dt_opcd = ds_ret.Tables["PKG_SPB_OPCD.SELECT_SPB_OPCD_H"];
					dt_detail_opcd = ds_ret.Tables["PKG_SPB_OPCD.SELECT_SPB_OPCD_INDETAIL_D"];
					Display_TreeGrid(dt_opcd, fgrid_OpCd);
					Display_TreeGrid_InDetail(dt_detail_opcd, fgrid_OpCd);


					//-----------------------------------------------------------------------
					//삭제, 추가된 공정에 대해서 공정 미니라인 입력 콤보박스 다시 세팅
					//-----------------------------------------------------------------------
 
					dt_ret = Select_OpCd_List_ForOpLine( cmb_OLFactory.SelectedValue.ToString()); 
				
					Display_Grid(dt_ret, fgrid_OLOpCd);
					fgrid_OLOpCd.Select(fgrid_OLOpCd.Rows.Fixed, 1, fgrid_OLOpCd.Rows.Fixed, fgrid_OLOpCd.Cols.Count - 1, true);
					fgrid_OLOpCd_Click(null, null);
 
					//---------------------------------------------------------------------------------------------------------
					//copy combo setting
					ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OLOpCd1, 0, 2, false, COM.ComVar.ComboList_Visible.Code); 
					ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OLOpCd2, 0, 2, true, COM.ComVar.ComboList_Visible.Code);
					cmb_OLOpCd2.SelectedIndex = 0;
					ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OLOpCd3, 0, 2, false, COM.ComVar.ComboList_Visible.Code); 
 
					//-----------------------------------------------------------------------


					break; 

				case "obarpg_OpLine": 
					 
					//행 수정 상태 해제
					fgrid_OpCdLine.Select(fgrid_OpCdLine.Selection.r1, 0, fgrid_OpCdLine.Selection.r1, fgrid_OpCdLine.Cols.Count-1, false);
  
					Save_SPB_OPCD_LINE();

//					MyOraDB.Save_FlexGird("PKG_SPB_OPCD.SAVE_SPB_OPCD_LINE", fgrid_OpCdLine);
//
//					dt_ret = Select_OpCd_List_ForOpLine( cmb_OLFactory.SelectedValue.ToString());
//					Display_Grid(dt_ret, fgrid_OLOpCd);
//
//					dt_ret = Select_SPB_OPCD_LINE();
//					Display_Grid(dt_ret, fgrid_OpCdLine); 


					break;

			}
		} 



		/// <summary>
		/// Save_SPB_OPCD_LINE
		/// </summary>
		private void Save_SPB_OPCD_LINE()
		{
			string exist_line = "";
			string line = "", miniline = "";
			DialogResult message_result;
			string msg = "", caption = "";

			DataTable dt_ret;

			try
			{


				bool wrong_data_yn = false;
				int wrong_data_row = 0;


				// 미니라인 코드 입력 사전 체크
				for(int i = fgrid_OpCdLine.Rows.Fixed; i < fgrid_OpCdLine.Rows.Count; i++)
				{


					if(fgrid_OpCdLine[i, 0] == null || fgrid_OpCdLine[i, 0].ToString() == "") continue;


					// 미니라인 코드 자릿수가 3자리가 넘으면 잘못된 데이터 발생
					if(fgrid_OpCdLine[i, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxMLINE_CD] == null
						|| fgrid_OpCdLine[i, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxMLINE_CD].ToString().Trim().Equals("") 
						|| fgrid_OpCdLine[i, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxMLINE_CD].ToString().Length > 3)
					{
						wrong_data_yn = true;
						wrong_data_row = i;
						ClassLib.ComFunction.Data_Message("Miniline Code - only 3 characters, numeric data.", ClassLib.ComVar.MgsWrongInput, this);
						break;
					}




				} // end for i


				if(wrong_data_yn)
				{

					fgrid_OpCdLine.Select(wrong_data_row, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxMLINE_CD, false);

					return;
				}
				else
				{


					for(int i = fgrid_OpCdLine.Rows.Fixed; i < fgrid_OpCdLine.Rows.Count; i++)
					{
						if(fgrid_OpCdLine[i, 0] == null || fgrid_OpCdLine[i, 0].ToString() == "") continue;

						if(fgrid_OpCdLine[i, 0].ToString() != "I")
						{
							Save_SPB_OPCD_LINE(i, fgrid_OpCdLine[i, 0].ToString()); 
						}
						else
						{
					
							line = fgrid_OpCdLine[i, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxLINE_CD].ToString();
							miniline = fgrid_OpCdLine[i, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxMLINE_CD].ToString();

							//메인 라인 그룹만 중복 체크
							if(cmb_OLLineGroup.SelectedValue.ToString() == "Group 1" || cmb_OLLineGroup.SelectedValue.ToString() == "000")
							{
								exist_line = Check_Exist_MiniLine(line, miniline);
							}
							else
							{
								exist_line = "";
							}

							//중복 데이터 있으면
							if(exist_line.Trim() != "")
							{
								msg = @"Would you remove miniline '" + miniline + @"' of line '" + exist_line + @"'" + "\r\n\r\n";
								msg += @"and insert miniline '" + miniline + @"' of line '" + line + @"' ?";

								caption = @"Used in line '" + exist_line + "'";

								message_result = MessageBox.Show(msg, caption, MessageBoxButtons.OKCancel);

								if(message_result == DialogResult.Cancel) return;
							
								fgrid_OpCdLine[i, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxH_LINE_CD] = exist_line;
								Save_SPB_OPCD_LINE(i, "U");
							}
							else
							{
								Save_SPB_OPCD_LINE(i, "I");
							}
						} // end if(fgrid_OpCdLine[i, 0].ToString() != "I")
					} // end for i


					dt_ret = Select_SPB_OPCD_LINE();
					Display_Grid(dt_ret, fgrid_OpCdLine); 

				}



			}
			catch
			{
			}
		}


		/// <summary>
		/// Check_Exist_MiniLine : 중복체크
		/// </summary>
		/// <param name="arg_line"></param>
		/// <param name="arg_miniline"></param>
		/// <returns></returns>
		private string Check_Exist_MiniLine(string arg_line, string arg_miniline)
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPB_OPCD.EXIST_SPB_OPCD_LINE";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OP_CD";
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_MLINE_CD";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_OLFactory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = fgrid_OLOpCd[_OpCd_SelRow, (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_CD].ToString();
				MyOraDB.Parameter_Values[2] = arg_line; 
				MyOraDB.Parameter_Values[3] = arg_miniline; 
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString(); 
			}
			catch
			{
				return "";
			}
		}



		/// <summary>
		/// Save_SPB_OPCD_LINE : 실제 디비 저장
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_division"></param>
		private bool Save_SPB_OPCD_LINE(int arg_row, string arg_division)
		{
			int col_ct = fgrid_OpCdLine.Cols.Count-1;		 
			int row_fixed = fgrid_OpCdLine.Rows.Fixed;		// 그리드 고정행 값  
			int para_ct = 0;

			try
			{
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_OPCD.SAVE_SPB_OPCD_LINE_AREA";  //"PKG_SPB_OPCD.SAVE_SPB_OPCD_LINE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				for(int i = 1; i < col_ct; i++)
				{
					MyOraDB.Parameter_Name[i] = "ARG_" + fgrid_OpCdLine[0, i].ToString(); 
				}

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
	  
  



				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList();  

				vList.Add( arg_division );

				for(int col = 1; col < col_ct - 1 ; col++)	 
				{  
					// 데이터값 설정 
					if(fgrid_OpCdLine.Cols[col].Style.DataType != null && fgrid_OpCdLine.Cols[col].DataType.Equals(typeof(bool)) )
					{ 
 
						fgrid_OpCdLine[arg_row, col] = (fgrid_OpCdLine[arg_row, col] == null) ? "False" : fgrid_OpCdLine[arg_row, col].ToString();
						vList.Add( (fgrid_OpCdLine[arg_row,col].ToString() == "True") ? "Y" : "N" ); 
					}
					//콤보리스트 처리 추가  
					else if(fgrid_OpCdLine.Cols[col].ComboList.Length != 0)
					{
						char[] delimiter = ":".ToCharArray();
						string[] token = null; 
								 
						fgrid_OpCdLine[arg_row, col] = (fgrid_OpCdLine[arg_row, col] == null) ? "" : fgrid_OpCdLine[arg_row, col].ToString();
						token = fgrid_OpCdLine[arg_row, col].ToString().Split(delimiter); 
						vList.Add( (token[0] == null) ? "" : token[0].Trim() );

					}
					else
					{
						vList.Add( (fgrid_OpCdLine[arg_row, col] == null) ? "" : fgrid_OpCdLine[arg_row,col].ToString() );
					}			

				}

				vList.Add( ClassLib.ComVar.This_User );

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_FlexGird",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}





		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{	
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_OpType":
					fgrid_OpType.Add_Row(fgrid_OpType.Rows.Count - 1);
					fgrid_OpType[fgrid_OpType.Rows.Count - 1, (int)ClassLib.TBSPB_NODE_OPDEF.IxFACTORY] = cmb_OTFactory.SelectedValue.ToString();
					
					//add(left, top, width, height) 
					_AddNode = addflow_Main.Nodes.Add(200, 50 * (fgrid_OpType.Rows.Count - 1 - _Rowfixed), 70, 20); 
                   
					break;

				case "obarpg_OpCd": 
					fgrid_OpCd.Add_Row(fgrid_OpCd.Rows.Count - 1); 
					fgrid_OpCd[fgrid_OpCd.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_GRID.IxFACTORY] = cmb_OCFactory.SelectedValue.ToString();
					fgrid_OpCd[fgrid_OpCd.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL] = "1";
					//fgrid_OpCd[fgrid_OpCd.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_GRID.IxDIR_MARGIN] = "1";
					 
					break;

				case "obarpg_OpLine": 
					 
					fgrid_OpCdLine.Add_Row(fgrid_OpCdLine.Rows.Count - 1); 
					fgrid_OpCdLine[fgrid_OpCdLine.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxFACTORY] = cmb_OLFactory.SelectedValue.ToString();
					fgrid_OpCdLine[fgrid_OpCdLine.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxOP_CD] = fgrid_OLOpCd[_OpCd_SelRow, (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_CD].ToString(); 
					fgrid_OpCdLine[fgrid_OpCdLine.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxLINE_CD] = fgrid_OLLine[_Line_SelRow, (int)ClassLib.TBSPB_OPCD_LINE_LINE.IxLINE_CD].ToString(); 
					fgrid_OpCdLine[fgrid_OpCdLine.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxMAT_AREA] = "000";
					fgrid_OpCdLine[fgrid_OpCdLine.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxH_LINE_CD] = fgrid_OLLine[_Line_SelRow, (int)ClassLib.TBSPB_OPCD_LINE_LINE.IxLINE_CD].ToString(); 
					fgrid_OpCdLine[fgrid_OpCdLine.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxREAL_YN] = "TRUE";

					break;
  
			}
		}
 

		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_OpType":
					fgrid_OpType.Add_Row(fgrid_OpType.Selection.r1);
					fgrid_OpType[fgrid_OpType.Selection.r1, (int)ClassLib.TBSPB_NODE_OPDEF.IxFACTORY] = cmb_OTFactory.SelectedValue.ToString();
					
					//add(left, top, width, height) 
					_AddNode = addflow_Main.Nodes.Add(200, 30 * (fgrid_OpType.Selection.r1), 70, 20);
 
					break;

				case "obarpg_OpCd": 
					fgrid_OpCd.Add_Row(fgrid_OpCd.Selection.r1); 
					fgrid_OpCd[fgrid_OpCd.Selection.r1, (int)ClassLib.TBSPB_OPCD_GRID.IxFACTORY] = cmb_OCFactory.SelectedValue.ToString();
					fgrid_OpCd[fgrid_OpCd.Selection.r1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL] = "1";
					//fgrid_OpCd[fgrid_OpCd.Selection.r1, (int)ClassLib.TBSPB_OPCD_GRID.IxDIR_MARGIN] = "1";

					break;  

				case "obarpg_OpLine": 
					 
					fgrid_OpCdLine.Add_Row(fgrid_OpCdLine.Selection.r1); 
					fgrid_OpCdLine[fgrid_OpCdLine.Selection.r1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxFACTORY] = cmb_OLFactory.SelectedValue.ToString();
					fgrid_OpCdLine[fgrid_OpCdLine.Selection.r1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxOP_CD] = fgrid_OLOpCd[_OpCd_SelRow, (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_CD].ToString(); 
					fgrid_OpCdLine[fgrid_OpCdLine.Selection.r1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxLINE_CD] = fgrid_OLLine[_Line_SelRow, (int)ClassLib.TBSPB_OPCD_LINE_LINE.IxLINE_CD].ToString(); 
					fgrid_OpCdLine[fgrid_OpCdLine.Selection.r1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxMAT_AREA] = "000";
					fgrid_OpCdLine[fgrid_OpCdLine.Selection.r1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxH_LINE_CD] = fgrid_OLLine[_Line_SelRow, (int)ClassLib.TBSPB_OPCD_LINE_LINE.IxLINE_CD].ToString(); 
					fgrid_OpCdLine[fgrid_OpCdLine.Selection.r1, (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxREAL_YN] = "TRUE";

					break;
			}
		}



		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_OpType":
					fgrid_OpType.Delete_Row(); 
					break;

				case "obarpg_OpCd":  
					Delete_SPB_OPCD();

					break; 

				case "obarpg_OpLine":  

					int sel_r1 = fgrid_OpCdLine.Selection.r1;
					int sel_r2 = fgrid_OpCdLine.Selection.r2; 
					int start_row, end_row;

					start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
					end_row = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

					for(int i = end_row; i >= start_row;  i--) 
					{
						if(fgrid_OpCdLine[i, 0].ToString() == "I") 
							fgrid_OpCdLine.Rows.Remove(i); 
						else
							fgrid_OpCdLine.Delete_Row();   //fgrid_OpCdLine[i, 0] = "D";

					} 
					break;
			}
		}

		private void tbtn_Color_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_OpCd": 

					Set_Color();

					break;
			}
 
		}

		 

		#endregion 

		#region 공정 타입


		private void cmb_OTFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			if(cmb_OTFactory.SelectedIndex == -1) return;
			 
			dt_ret = Select_OpType_List();
			Display_Grid(dt_ret, fgrid_OpType);

			ClassLib.ComFunction.Clear_AddFlow(addflow_Main);
			Select_OpType_Node_List(); 
			 
		}
 

		private void fgrid_OpType_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			switch(fgrid_OpType[fgrid_OpType.Selection.r1, 0].ToString())
			{
				case "I":
					if(fgrid_OpType[fgrid_OpType.Selection.r1, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE].ToString() != "")  
					{
						_AddNode.Tag = fgrid_OpType[fgrid_OpType.Selection.r1, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE].ToString();
			
						if(fgrid_OpType[fgrid_OpType.Selection.r1, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE_NAME].ToString() != "")
						{	
							_AddNode.Text = fgrid_OpType[fgrid_OpType.Selection.r1, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE_NAME].ToString(); 
						}
						else
						{
							_AddNode.Text = fgrid_OpType[fgrid_OpType.Selection.r1, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE].ToString();
						}
									
						_AddNode.Tooltip = _AddNode.Text;
							
					}
					else
					{
						ClassLib.ComFunction.Data_Message("Code, Name", ClassLib.ComVar.MgsWrongInput, this);
					}
			
					break;
			
				default:
					fgrid_OpType.Update_Row();
					fgrid_OpType[fgrid_OpType.Selection.r1, (int)ClassLib.TBSPB_NODE_OPDEF.IxTEXT] = fgrid_OpType[fgrid_OpType.Selection.r1, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE_NAME];
					break;

			} //end switch 
		}


		private void menuItem_NodeProp_Click(object sender, System.EventArgs e)
		{
			Item item = addflow_Main.PointedItem;
			Lassalle.DlgFlow.DlgFlow dlgflow = new Lassalle.DlgFlow.DlgFlow();
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();
			int i;
 
			if (item is Lassalle.Flow.Node)
			{
				node = (Lassalle.Flow.Node)item;
				dlgflow.NodePropertyPage(addflow_Main,node);


				///////////////////////////////////////////////////////////////
				if(node.Tag != null)
				{
					for(i = _Rowfixed; i < fgrid_OpType.Rows.Count; i++)
					{
						if(node.Tag.ToString() == fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE].ToString())
						{
							fgrid_OpType.Update_Row(i); 
 
							RectangleF rc = node.Rect; 
 
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE] = node.Tag.ToString();
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE_NAME] = node.Text.ToString();

							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxALIGNMENT] = node.Alignment.GetHashCode().ToString();
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxDASHSTYLE] = node.DashStyle.GetHashCode().ToString();
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxDRAWCOLOR] = node.DrawColor.ToArgb().ToString(); 
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxDRAWWIDTH] = node.DrawWidth.ToString(); 
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxFILLCOLOR] = node.FillColor.ToArgb().ToString();
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxFONT] = node.Font.Name + "/"
								+ node.Font.Size + "/"
								+ node.Font.Bold + "/"
								+ (node.Font.Italic ? true : false) + "/"
								+ (node.Font.Strikeout ? true : false) + "/"
								+ (node.Font.Underline ? true : false)  ;
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADI_YN] = (node.Gradient ? "Y" : "N");
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADICOLOR] = node.GradientColor.ToArgb().ToString();
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADIMODE] = node.GradientMode.GetHashCode().ToString();
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxHEIGHT] = rc.Height.ToString(); 
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHADOW] = node.Shadow.Style.GetHashCode().ToString() + "/"
								+ node.Shadow.Color.ToArgb().ToString() + "/"
								+ node.Shadow.Size.Width.ToString() + "/"
								+ node.Shadow.Size.Height.ToString();
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHAPE] = node.Shape.Style.GetHashCode().ToString(); 
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxTAG] = node.Tag.ToString();
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxTEXT] = node.Text.ToString();
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxTEXTCOLOR] = node.TextColor.ToArgb().ToString(); 
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxTOOLTIP] = node.Tooltip.ToString();
							fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxWIDTH] = rc.Width.ToString();  
       

						}
					} //end for
				}
				///////////////////////////////////////////////////////////////

			} 

		}
 

		private void menuItem_NodeDel_Click(object sender, System.EventArgs e)
		{
			int i;
			
			if(addflow_Main.SelectedItem.Tag != null)
			{
				for(i = _Rowfixed; i < fgrid_OpType.Rows.Count; i++)
				{
					if(addflow_Main.SelectedItem.Tag.ToString() == fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE].ToString())
					{
						fgrid_OpType.Delete_Row(); 
					}
				} //end for
			}
		}
 

		private void addflow_Main_AfterEdit(object sender, Lassalle.Flow.AfterEditEventArgs e)
		{
			int i;
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();

			if(addflow_Main.SelectedItem.Tag != null)
			{
				for(i = _Rowfixed; i < fgrid_OpType.Rows.Count; i++)
				{
					node = (Lassalle.Flow.Node)addflow_Main.SelectedItem;

					if(node.Tag.ToString() == fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE].ToString())
					{
						fgrid_OpType.Update_Row(i); 

						RectangleF rc = node.Rect; 
   
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE_NAME] = node.Text.ToString();

						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxALIGNMENT] = node.Alignment.GetHashCode().ToString();
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxDASHSTYLE] = node.DashStyle.GetHashCode().ToString();
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxDRAWCOLOR] = node.DrawColor.ToArgb().ToString(); 
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxDRAWWIDTH] = node.DrawWidth.ToString(); 
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxFILLCOLOR] = node.FillColor.ToArgb().ToString();
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxFONT] = node.Font.Name + "/"
							+ node.Font.Size + "/"
							+ node.Font.Bold + "/"
							+ (node.Font.Italic ? true : false) + "/"
							+ (node.Font.Strikeout ? true : false) + "/"
							+ (node.Font.Underline ? true : false)  ;
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADI_YN] = (node.Gradient ? "Y" : "N");
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADICOLOR] = node.GradientColor.ToArgb().ToString();
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADIMODE] = node.GradientMode.GetHashCode().ToString();
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxHEIGHT] = rc.Height.ToString(); 
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHADOW] = node.Shadow.Style.GetHashCode().ToString() + "/"
							+ node.Shadow.Color.ToArgb().ToString() + "/"
							+ node.Shadow.Size.Width.ToString() + "/"
							+ node.Shadow.Size.Height.ToString();
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHAPE] = node.Shape.Style.GetHashCode().ToString(); 
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxTAG] = node.Tag.ToString();
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxTEXT] = node.Text.ToString();
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxTEXTCOLOR] = node.TextColor.ToArgb().ToString(); 
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxTOOLTIP] = node.Tooltip.ToString();
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxWIDTH] = rc.Width.ToString();  
       
       

					}
				} //end for
			} 
		}
  
		 
		private void addflow_Main_AfterResize(object sender, System.EventArgs e)
		{
			int i;
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();

			if(addflow_Main.SelectedItem.Tag != null)
			{
				for(i = _Rowfixed; i < fgrid_OpType.Rows.Count; i++)
				{
					node = (Lassalle.Flow.Node)addflow_Main.SelectedItem;

					if(node.Tag.ToString() == fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE].ToString())
					{
						fgrid_OpType.Update_Row(i); 

						RectangleF rc = node.Rect; 
   
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxHEIGHT] = rc.Height.ToString();  
						fgrid_OpType[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxWIDTH] = rc.Width.ToString();  
       

					}
				} //end for
			}
		}


		#endregion

		#region 공정 코드
 

		private void cmb_OCFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataSet ds_ret;
			DataTable dt_opcd, dt_detail_opcd;

			if(cmb_OCFactory.SelectedIndex == -1) return;
			  
			ds_ret = Select_Display_SPB_OPCD(cmb_OCFactory.SelectedValue.ToString());
			dt_opcd = ds_ret.Tables["PKG_SPB_OPCD.SELECT_SPB_OPCD_H"];
			dt_detail_opcd = ds_ret.Tables["PKG_SPB_OPCD.SELECT_SPB_OPCD_INDETAIL_D"];
			Display_TreeGrid(dt_opcd, fgrid_OpCd);
			Display_TreeGrid_InDetail(dt_detail_opcd, fgrid_OpCd);
			 
		}
 

		private void fgrid_OpCd_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			bool digit_flag;
  	
			try
			{
				if(e.Col == (int)ClassLib.TBSPB_OPCD_GRID.IxDIR_MARGIN)
				{
					digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_OpCd[e.Row, e.Col].ToString());

					if(digit_flag == false) 
					{
						fgrid_OpCd[e.Row, e.Col] = "";
						return;
					}
				}
  

				//------------------------------------------------------------
				fgrid_OpCd.AutoSizeCols();

				if(fgrid_OpCd[e.Row, 0].ToString() == "I") return;
				fgrid_OpCd.Update_Row(); 



				//------------------------------------------------------------
				int sel_row = fgrid_OpCd.Selection.r1;
  
				if(sel_row >= _Rowfixed)
				{ 
					if(Convert.ToBoolean(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxIN_DETAIL_YN].ToString()) ) 
						btn_SetDetailOpCd.Enabled = true;  
					else
					{
						btn_SetDetailOpCd.Enabled = false;
						lbl_ODetailQty.Visible = false;
						txt_ODetailQty.Visible = false;
						btn_OAppendRow.Visible = false;
					}



					//------------------------------------------ 
					if(Convert.ToBoolean(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN].ToString()) ) 
						fgrid_OpCd.Cols[(int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE].ComboList = "...";
					else
						fgrid_OpCd.Cols[(int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE].ComboList = ""; 

				} 

				
			}
			catch
			{
			}
		}
 

		private void fgrid_OpCd_Click(object sender, System.EventArgs e)
		{
			int sel_row = fgrid_OpCd.Selection.r1;
 
			try
			{
				if(sel_row >= _Rowfixed)
				{ 
 
					if(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxDETAIL_OPCD] != null)
					{
						if(Convert.ToBoolean(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxDETAIL_OPCD].ToString()) ) 
							btn_SetDetailOpCd.Enabled = true;  
						else
						{
							btn_SetDetailOpCd.Enabled = false;
							lbl_ODetailQty.Visible = false;
							txt_ODetailQty.Visible = false;
							btn_OAppendRow.Visible = false;
						}
					}


					//------------------------------------------
					if(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN] != null)
					{
					 
						if(Convert.ToBoolean(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN].ToString()) ) 
							fgrid_OpCd.Cols[(int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE].ComboList = "...";
						else
							fgrid_OpCd.Cols[(int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE].ComboList = ""; 
					}

				}




			}
			catch 
			{ 
			}

		}
  

		private void fgrid_OpCd_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		 
			int sel_row = fgrid_OpCd.Selection.r1;
			int sel_col = fgrid_OpCd.Selection.c1;
			int moldyn = (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN;

			fgrid_OpCd[sel_row, moldyn] = (fgrid_OpCd[sel_row, moldyn] == null) ? "FALSE" : fgrid_OpCd[sel_row, moldyn].ToString();

			if(!Convert.ToBoolean(fgrid_OpCd[sel_row, moldyn].ToString())) return; 
			
			//몰드타입 입력하는 팝업
			//Pop_SetMoldType pop_form = new Pop_SetMoldType();

			Pop_CreateOPMoldTypes pop_form = new Pop_CreateOPMoldTypes();

			fgrid_OpCd[sel_row, fgrid_OpCd.Selection.c1] 
				= (fgrid_OpCd[sel_row, fgrid_OpCd.Selection.c1] == null) ? "" : fgrid_OpCd[sel_row, fgrid_OpCd.Selection.c1].ToString();

			ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_OCFactory.SelectedValue.ToString(),
															   fgrid_OpCd[sel_row, fgrid_OpCd.Selection.c1].ToString()};

			pop_form.ShowDialog();

			if(pop_form._CloseSave)
			{
				fgrid_OpCd[sel_row, sel_col] = ClassLib.ComVar.Parameter_PopUp[0];
				fgrid_OpCd.Update_Row();
			}


		}	 
 
		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 1;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 0;
		}

		private void btn_SetDetailOpCd_Click(object sender, System.EventArgs e)
		{
			try
			{
				txt_ODetailQty.Text = "";

				lbl_ODetailQty.Visible = true;
				txt_ODetailQty.Visible = true;
				btn_OAppendRow.Visible = true;
			}
			catch
			{
			}
		}
 
	
		private void txt_ODetailQty_Leave(object sender, System.EventArgs e)
		{
			ClassLib.ComFunction.Set_NumberTextBox(txt_ODetailQty, 3);
		} 

		private void btn_OAppendRow_Click(object sender, System.EventArgs e)
		{
			try
			{  
				int sel_row = fgrid_OpCd.Selection.r1; 
				int sel_level = Convert.ToInt32(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL].ToString() );
				string sel_opcd = fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD].ToString();
				string sel_cmpcd = fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD].ToString();

				int findrow = 0, insert_row = 0;

				findrow = fgrid_OpCd.FindRow(sel_level.ToString(), sel_row + 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL, false, true, false);

				if(findrow == -1) findrow = fgrid_OpCd.Rows.Count;

				insert_row = findrow;

				for(int i = 0; i < Convert.ToInt32(txt_ODetailQty.Text); i++)
				{
					//fgrid_OpCd.Rows.InsertNode(insert_row, sel_level);  
 
					fgrid_OpCd.Rows.Insert(insert_row);

					fgrid_OpCd[insert_row, 0] = "I";
					fgrid_OpCd[insert_row, (int)ClassLib.TBSPB_OPCD_GRID.IxFACTORY] = cmb_OCFactory.SelectedValue.ToString();
					fgrid_OpCd[insert_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD] = sel_opcd + "_";
					fgrid_OpCd[insert_row, (int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD] = sel_cmpcd;
					fgrid_OpCd[insert_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL] = Convert.ToString((sel_level + 1));
 
					insert_row++; 
 
				}

				

			}
			catch
			{
			}

 
		}

		

		#endregion


		#region 공정 라인 (공정의 미니라인 정의)


		private void cmb_OLFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret; 

			try
			{
				if(cmb_OLFactory.SelectedIndex == -1) return; 
				
				//---------------------------------------------------------------------------------------------------------
				dt_ret = ClassLib.ComVar.Select_ComCode(cmb_OLFactory.SelectedValue.ToString(), ClassLib.ComVar.CxLineType);

				cmb_OLLineGroup.AddItem("" + ";" + "ALL");
				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_OLLineGroup, 1, 2);  
				cmb_OLLineGroup.AddItem("000" + ";" + "Out Side");

				cmb_OLLineGroup.Splits[0].DisplayColumns["Code"].Visible = false;

				cmb_OLLineGroup.SelectedIndex = 0;

				//---------------------------------------------------------------------------------------------------------
				dt_ret = Select_OpCd_List_ForOpLine( cmb_OLFactory.SelectedValue.ToString()); 
				
				Display_Grid(dt_ret, fgrid_OLOpCd);
				fgrid_OLOpCd.Select(fgrid_OLOpCd.Rows.Fixed, 1, fgrid_OLOpCd.Rows.Fixed, fgrid_OLOpCd.Cols.Count - 1, true);
				fgrid_OLOpCd_Click(null, null);
 
				//---------------------------------------------------------------------------------------------------------
				//copy combo setting
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OLOpCd1, 0, 2, false, COM.ComVar.ComboList_Visible.Code); 
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OLOpCd2, 0, 2, true, COM.ComVar.ComboList_Visible.Code);
				cmb_OLOpCd2.SelectedIndex = 0;
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OLOpCd3, 0, 2, false, COM.ComVar.ComboList_Visible.Code); 


				dt_ret.Dispose();

			}
			catch
			{
			}
 
		}
 

		private void cmb_OLLineGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret; 

			try
			{
				if(cmb_OLFactory.SelectedIndex == -1 || cmb_OLLineGroup.SelectedIndex == -1) return;  

				dt_ret = Select_SPB_LINE();
				Display_Grid(dt_ret, fgrid_OLLine);
				fgrid_OLLine.Select(fgrid_OLLine.Rows.Fixed, 1, fgrid_OLLine.Rows.Fixed, fgrid_OLLine.Cols.Count - 1, true);
				fgrid_OLLine_Click(null, null);
 
				//---------------------------------------------------------------------------------------------------------
				//copy combo setting

				if(cmb_OLLineGroup.SelectedValue.ToString() != "Group 1" && cmb_OLLineGroup.SelectedValue.ToString() != "000")
				{
					ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OLLine1, 0, 1, false, COM.ComVar.ComboList_Visible.Name); 
					ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OLLine2, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
					cmb_OLLine2.SelectedIndex = 0;
				}
				else
				{
					cmb_OLLine1.DataSource = null;
					cmb_OLLine2.DataSource = null;
					cmb_OLLine1.SelectedIndex = -1;
					cmb_OLLine2.SelectedIndex = -1;
				}

				dt_ret.Dispose();

			}
			catch
			{
			}
		}

		 
		private void fgrid_OLOpCd_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret = null;

			try
			{
				if(fgrid_OLOpCd.Rows.Count <= fgrid_OLOpCd.Rows.Fixed) return;
 
				_OpCd_SelRow = fgrid_OLOpCd.Selection.r1;

				//if(_Line_SelRow == "") return;

//				//--------------------------------------------------------------------------------------
//				// release_area_cd 콤보 리스트
//				//--------------------------------------------------------------------------------------
//				System.Collections.Specialized.ListDictionary ld = new System.Collections.Specialized.ListDictionary(); 
//
//				string factory = cmb_OLFactory.SelectedValue.ToString();
//				string op_cd = "UPS";
//				dt_ret = Select_SPB_OPCD_AREA_CD(factory, op_cd);
//
//				for(int i = 0; i < dt_ret.Rows.Count; i++)
//				{
//					ld.Add(dt_ret.Rows[i].ItemArray[0].ToString(), dt_ret.Rows[i].ItemArray[1].ToString());  
//				}
//
//				fgrid_OpCdLine.Cols[(int)ClassLib.TBSPB_OPCD_LINE_AREA.IxRELEASE_AREA_CD].DataMap = ld; 
//
//				//--------------------------------------------------------------------------------------



				dt_ret = Select_SPB_OPCD_LINE();
				Display_Grid(dt_ret, fgrid_OpCdLine);

				
				dt_ret.Dispose();

			}
			catch
			{
			}
 
		}

		private void fgrid_OLLine_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(fgrid_OLLine.Rows.Count <= fgrid_OLLine.Rows.Fixed) return;
 
				_Line_SelRow = fgrid_OLLine.Selection.r1;

				//if(_OpCd_SelRow == "") return; 

				dt_ret = Select_SPB_OPCD_LINE();
				Display_Grid(dt_ret, fgrid_OpCdLine);

			}
			catch
			{
			}
		}
 



		private void fgrid_OpCdLine_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			bool digit_flag;

			if(e.Col == (int)ClassLib.TBSPB_OPCD_LINE_AREA.IxSTD_CAPA)
			{
				digit_flag = COM.ComFunction.Check_Digit(fgrid_OpCdLine[e.Row, e.Col].ToString());
					
				if(digit_flag == false) 
				{
					fgrid_OpCdLine[e.Row, e.Col] = "";
					return;
				}
					
			}

			fgrid_OpCdLine.Update_Row();
			fgrid_OpCdLine.AutoSizeCols();

		}

  

		private void btn_AdaptAllOp_Click(object sender, System.EventArgs e)
		{
			bool save_flag = false;

			try
			{
				this.Cursor = Cursors.WaitCursor;

				//공정에 일괄적용
				save_flag = Adapt_AllOperation();
				
				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					return;
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);

					DataTable dt_ret;
					dt_ret = Select_OpCd_List_ForOpLine( cmb_OLFactory.SelectedValue.ToString());
					Display_Grid(dt_ret, fgrid_OLOpCd);

				}

				this.Cursor = Cursors.Default;

			}
			catch
			{
			}
		}



		/// <summary>
		/// Adapt_AllOperation : 공정에 일괄적용
		/// </summary>
		/// <returns></returns>
		private bool Adapt_AllOperation()
		{
			try
			{ 
				string process_name = "PKG_SPB_LINE.SAVE_SPB_OPCD_LINE_ADAPT_ALLOP";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OP_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			  
				MyOraDB.Parameter_Values[0] = cmb_OLFactory.SelectedValue.ToString();
				//MyOraDB.Parameter_Values[1] = txt_OLCode.Text;  
				MyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;  

				MyOraDB.Add_Modify_Parameter(true); 
				MyOraDB.Exe_Modify_Procedure();
				return true;

			}
			catch
			{ 
				return false; 
			}  
		}


		#region Copy

		private void btn_RunCopy_Click(object sender, System.EventArgs e)
		{
			DialogResult message_result;
			bool save_flag = false;

			try
			{
				

				if(rad_Op.Checked == true)
				{
					if(cmb_OLFactory.SelectedIndex == -1 || cmb_OLOpCd1.SelectedIndex == -1 || cmb_OLOpCd2.SelectedIndex == -1) return;
				}

				if(rad_Line.Checked == true)
				{
					if(cmb_OLFactory.SelectedIndex == -1 || cmb_OLOpCd3.SelectedIndex == -1 
						|| cmb_OLLine1.SelectedIndex == -1 || cmb_OLLine2.SelectedIndex == -1) return;
				}


				//--------------------------------------------------------------------------------------
				string msg = "Would you remove before miniline data and insert new miniline data ? ";

				message_result = MessageBox.Show(msg, "", MessageBoxButtons.OKCancel);

				if(message_result == DialogResult.Cancel) return; 

				this.Cursor = Cursors.WaitCursor; 
				save_flag = Copy_OpcdLine();  
				this.Cursor = Cursors.Default;

				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					return;
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
				}

			}
			catch
			{
			}

		}

		

		/// <summary>
		/// Copy_OpcdLine : 
		/// </summary>
		/// <returns></returns>
		private bool Copy_OpcdLine()
		{ 
			try
			{

				if(rad_Op.Checked == true)
				{
					MyOraDB.ReDim_Parameter(4);
					MyOraDB.Process_Name = "PKG_SPB_OPCD.COPY_SPB_OPCD_LINE_BYOP";

					MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
					MyOraDB.Parameter_Name[1] = "ARG_OP_CD_ORG"; 
					MyOraDB.Parameter_Name[2] = "ARG_OP_CD_DST";
					MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

					for(int i = 0; i < 4 ; i++)
					{
						MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
					}

					MyOraDB.Parameter_Values[0] = cmb_OLFactory.SelectedValue.ToString();
					MyOraDB.Parameter_Values[1] = cmb_OLOpCd1.SelectedValue.ToString();

					//if(cmb_OLOpCd2.SelectedText.Trim() == "")
					if(cmb_OLOpCd2.SelectedIndex == -1 || cmb_OLOpCd2.SelectedValue.ToString().Trim() == "")
					{
						MyOraDB.Parameter_Values[2] = "_";
					}
					else
					{
						MyOraDB.Parameter_Values[2] = cmb_OLOpCd2.SelectedValue.ToString();
					}

					
					MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User; 

				}


				if(rad_Line.Checked == true)
				{
					MyOraDB.ReDim_Parameter(5);
					MyOraDB.Process_Name = "PKG_SPB_OPCD.COPY_SPB_OPCD_LINE_BYLINE";

					MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
					MyOraDB.Parameter_Name[1] = "ARG_OP_CD"; 
					MyOraDB.Parameter_Name[2] = "ARG_LINE_CD_ORG";
					MyOraDB.Parameter_Name[3] = "ARG_LINE_CD_DST";
					MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

					for(int i = 0; i < 5 ; i++)
					{
						MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
					}

					MyOraDB.Parameter_Values[0] = cmb_OLFactory.SelectedValue.ToString();
					MyOraDB.Parameter_Values[1] = cmb_OLOpCd3.SelectedValue.ToString();
					MyOraDB.Parameter_Values[2] = cmb_OLLine1.SelectedValue.ToString();

					//if(cmb_OLLine2.SelectedText.Trim() == "")
					if(cmb_OLLine2.SelectedIndex == -1 || cmb_OLLine2.SelectedValue.ToString().Trim() == "")
					{
						MyOraDB.Parameter_Values[3] = "_";
					}
					else
					{
						MyOraDB.Parameter_Values[3] = cmb_OLLine2.SelectedValue.ToString();
					}

					
					MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;

				}

 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Copy_OpcdLine",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}



		#endregion


		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
			RadioButton src = sender as RadioButton;

			try
			{
				//				if(src.Equals(rad_Op))
				//				{
				//					if(src.Checked == true)
				//					{
				//						cmb_OLOpCd1.Enabled = true;
				//						cmb_OLOpCd2.Enabled = true;
				//					}
				//					else
				//					{
				//						cmb_OLOpCd1.Enabled = false;
				//						cmb_OLOpCd2.Enabled = false;
				//					}
				//				}
				
				if(src.Equals(rad_Line))
				{
					if(src.Checked == true)
					{
						cmb_OLOpCd1.Visible = false;
						cmb_OLOpCd2.Visible = false;
						lbl_OLCopy1.Visible = false;

						cmb_OLOpCd3.Visible = true;
						cmb_OLLine1.Visible = true;
						cmb_OLLine2.Visible = true;
						lbl_OLCopy2.Visible = true;
					}
					else
					{
						cmb_OLOpCd1.Visible = true;
						cmb_OLOpCd2.Visible = true;
						lbl_OLCopy1.Visible = true;

						cmb_OLOpCd3.Visible = false;
						cmb_OLLine1.Visible = false;
						cmb_OLLine2.Visible = false;
						lbl_OLCopy2.Visible = false;
					}
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
		/// Select_OpType_List : 그리드에 Op Type 리스트 표시
		/// </summary>
		private DataTable Select_OpType_List()
		{
 
			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_OPCD.SELECT_OPTYPE_LIST";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_OTFactory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		} 

		/// <summary>
		/// Select_OpCd_List_ForOpLine : 공정코드 리스트 
		/// (공정라인 입력 화면에서 공정코드 리스트 표시)
		/// </summary>
		public static DataTable Select_OpCd_List_ForOpLine(string arg_factory)
		{
 
			 
			COM.OraDB LMyOraDB = new COM.OraDB();

			DataSet ds_ret; 
 
			LMyOraDB.ReDim_Parameter(2); 
 
			LMyOraDB.Process_Name = "PKG_SPB_OPCD.SELECT_SPB_OPCD";
  
			LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			LMyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
			LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			LMyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
			LMyOraDB.Parameter_Values[0] = arg_factory; 
			LMyOraDB.Parameter_Values[1] = "";

			LMyOraDB.Add_Select_Parameter(true); 
			ds_ret = LMyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ; 
			return ds_ret.Tables[LMyOraDB.Process_Name]; 

		}


		/// <summary>
		/// Select_OpCode_List : 공정코드 리스트 
		/// </summary>
		public static DataTable Select_OpCd_List(string arg_factory)
		{
			 
			COM.OraDB LMyOraDB = new COM.OraDB();

			DataSet ds_ret; 
 
			LMyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			LMyOraDB.Process_Name = "PKG_SPB_OPCD.SELECT_OPCD_LIST";
 
			//02.ARGURMENT명
			LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			LMyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			LMyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			LMyOraDB.Parameter_Values[0] = arg_factory;
			LMyOraDB.Parameter_Values[1] = "";

			LMyOraDB.Add_Select_Parameter(true);
 
			ds_ret = LMyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[LMyOraDB.Process_Name]; 
		}



		/// <summary>
		/// Select_SPB_LINE : 라인 리스트 가져오기
		/// </summary>
		private DataTable Select_SPB_LINE()
		{
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SPB_LINE.SELECT_SPB_LINE_GROUP";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LINE_GROUP"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_OLFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_OLLineGroup.SelectedValue.ToString(); 
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
		/// Select_SPB_OPCD_AREA_CD :  
		/// </summary>
		private DataTable Select_SPB_OPCD_AREA_CD()
		{
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SPB_OPCD.SELECT_SPB_OPCD_AREA_CD";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OP_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_OLFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = fgrid_OLOpCd[_OpCd_SelRow, (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_CD].ToString(); 
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
		/// Select_SPB_OPCD_AREA_CD :  
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_op_cd"></param>
		private DataTable Select_SPB_OPCD_AREA_CD(string arg_factory, string arg_op_cd)
		{
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SPB_OPCD.SELECT_SPB_OPCD_AREA_CD";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OP_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_op_cd; 
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
		/// Select_SPB_OPCD_LINE : 공정 세부라인 리스트
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_OPCD_LINE()
		{
			DataSet ds_ret;
			string process_name = "PKG_SPB_OPCD.SELECT_SPB_OPCD_LINE_AREA";  // "PKG_SPB_OPCD.SELECT_SPB_OPCD_LINE";

			MyOraDB.ReDim_Parameter(4); 
 
			MyOraDB.Process_Name = process_name;
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OP_CD";
			MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = cmb_OLFactory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = fgrid_OLOpCd[_OpCd_SelRow, (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_CD].ToString();
			MyOraDB.Parameter_Values[2] = fgrid_OLLine[_Line_SelRow, (int)ClassLib.TBSPB_OPCD_LINE_LINE.IxLINE_CD].ToString(); 
			MyOraDB.Parameter_Values[3] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[process_name]; 
		}


		/// <summary>
		/// Save_SPB_OPCD : SPB_OPCD, SPB_OPCD_INDETAIL 저장
		/// </summary>
		private bool Save_SPB_OPCD()
		{
			int col_ct = (int)ClassLib.TBSPB_OPCD_GRID.IxH_OP_CD + 1;	    // 칼럼의 수
			int row_fixed = fgrid_OpCd.Rows.Fixed;						// 그리드 고정행 값
			int count = 0, save_ct =0 ;											// 저장 행 수
 
			int para_ct =0;												// 파라미터 값의 저장 배열의 수
			int row,col;

			try
			{
				MyOraDB.ReDim_Parameter(col_ct - 1);
				MyOraDB.Process_Name = "PKG_SPB_OPCD.SAVE_SPB_OPCD";

				// 파라미터 이름 설정 
				for(int i = 0; i <= col_ct - 1; i++)
				{
					if(i == (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_YMD) continue;
					if(i == (int)ClassLib.TBSPB_OPCD_GRID.IxDETAIL_OPCD) continue;

					MyOraDB.Parameter_Name[count] = _OpCdHeadDT.Rows[0].ItemArray[i].ToString(); 
					count++;
				}
                MyOraDB.Parameter_Name[col_ct - 2] = "ARG_PARENT_OPCD"; 


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct - 1; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 	 
	
				}
	
				// 저장 행 수 구하기
				for(int i = row_fixed ; i < fgrid_OpCd.Rows.Count; i++)
				{
					if(fgrid_OpCd[i, 0].ToString() != "") save_ct += 1; 
				}
			
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[(col_ct - 1) * save_ct];


				// 각 행의 변경값 Setting
				for(row = row_fixed; row < fgrid_OpCd.Rows.Count ; row++)
				{
					if(fgrid_OpCd[row, 0].ToString() != "")
					{ 
						for(col = 0; col <= col_ct - 1 ; col++)	// 각 열의 값 Setting
						{
							if(col == (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_YMD) continue;
							if(col == (int)ClassLib.TBSPB_OPCD_GRID.IxDETAIL_OPCD) continue;

							// 데이터값 설정 
							if(fgrid_OpCd.Cols[col].Style.DataType != null
								&& fgrid_OpCd.Cols[col].DataType.Equals(typeof(bool)) )
							{
								fgrid_OpCd[row, col] = (fgrid_OpCd[row, col] == null) ? "False" : fgrid_OpCd[row, col].ToString();
								MyOraDB.Parameter_Values[para_ct] = (fgrid_OpCd[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}
								//콤보리스트 처리 추가 
							else if(fgrid_OpCd.Cols[col].ComboList.Length != 0)
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 

								if(col == (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE)
								{
									MyOraDB.Parameter_Values[para_ct] = (fgrid_OpCd[row, col] == null) ? "" : fgrid_OpCd[row,col].ToString();
								}
								else
								{
									fgrid_OpCd[row, col] = (fgrid_OpCd[row, col] == null) ? "" : fgrid_OpCd[row, col].ToString();
  
									token = fgrid_OpCd[row,col].ToString().Split(delimiter);  
									MyOraDB.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
  
								}

								para_ct ++;

							}
							else
							{
								//if(col == (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE) continue;

								if(col == (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_USER) 
									MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User; 
								else 
									MyOraDB.Parameter_Values[para_ct] = (fgrid_OpCd[row, col] == null) ? "" : fgrid_OpCd[row,col].ToString();
								 
								para_ct ++;

							} // end if( 데이터값 설정 )	
		
						} // end for col 

 

						//------------------------------------------------------------------------------------------------------------
						// 세부 공정 저장 시 상위 공정 코드 설정
						int up_opcd_row = -1;

						for(int a = row - 1; a >= fgrid_OpCd.Rows.Fixed; a--)
						{
							if(fgrid_OpCd[a, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL].ToString() == "1")
							{
								up_opcd_row = a;
								break;
							} 
						}

						if(up_opcd_row == -1)
						{
							MyOraDB.Parameter_Values[para_ct] = "";
						}
						else
						{
							MyOraDB.Parameter_Values[para_ct] = fgrid_OpCd[up_opcd_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD].ToString();
						}
						para_ct ++;
						//------------------------------------------------------------------------------------------------------------





					} // end if
				} // end for row

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_SPB_OPCD",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}

			

		/// <summary>
		/// Select_Display_SPB_OPCD : 공정코드 리스트 (트리로 표현하기 위한 데이터 테이블 추출) 
		/// </summary>
		/// <param name="arg_factory"></param>
		private DataSet Select_Display_SPB_OPCD(string arg_factory)
		{
			DataSet ds_ret; 
 
			try
			{
				// spb_opcd
				MyOraDB.ReDim_Parameter(2); 

				MyOraDB.Process_Name = "PKG_SPB_OPCD.SELECT_SPB_OPCD_H";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = "";

				MyOraDB.Add_Select_Parameter(true);
 
				// spb_opcd_indetail
				MyOraDB.ReDim_Parameter(2); 

				MyOraDB.Process_Name = "PKG_SPB_OPCD.SELECT_SPB_OPCD_INDETAIL_D";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = "";

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


		#endregion
 

		private void Form_PB_OpCd_Load(object sender, System.EventArgs e)
		{
			Init_Form();	
		}

		




	}
}


