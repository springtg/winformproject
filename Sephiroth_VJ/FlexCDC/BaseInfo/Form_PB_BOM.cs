using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
using Lassalle.Flow;
using Lassalle.Flow.Layout.Tree;

namespace FlexCDC.BaseInfo
{
	public class Form_PB_BOM : COM.PCHWinForm.Form_Top
	{
		public C1.Win.C1Command.C1OutBar obar_Main;

		#region 컨트롤 정의 및 리소스 정리 

		private C1.Win.C1Command.C1OutPage obarpg_BOMCd;
		private C1.Win.C1Command.C1OutPage obarpg_CmpType;
		private C1.Win.C1Command.C1OutPage obarpg_LinkProp;
		public C1.Win.C1Command.C1OutPage obarpg_StdBOM;
		private System.Windows.Forms.Panel pnl_BCBody;
		private System.Windows.Forms.Panel pnl_BCBodyRight;
		public System.Windows.Forms.Panel panel5;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.Panel pnl_BCBodyLeftTop;
		public System.Windows.Forms.Panel pnl_BCBodyRightTop;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox16;
		public System.Windows.Forms.Panel pnl_BCBodyRightBody;
		public System.Windows.Forms.Panel panel7;
		public System.Windows.Forms.PictureBox pictureBox25;
		public System.Windows.Forms.PictureBox pictureBox26;
		public System.Windows.Forms.PictureBox pictureBox27;
		public System.Windows.Forms.PictureBox pictureBox28;
		public System.Windows.Forms.PictureBox pictureBox29;
		public System.Windows.Forms.PictureBox pictureBox30;
		public System.Windows.Forms.PictureBox pictureBox31;
		public System.Windows.Forms.PictureBox pictureBox32;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.Label lbl_SubTitle3;
		private C1.Win.C1List.C1Combo cmb_BCFactory;
		private System.Windows.Forms.Label lbl_BCFactory;
		public COM.FSP fgrid_BomCd;
		public System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.CheckBox chk_BCFactoryYN;
		private System.Windows.Forms.CheckBox chk_BCModelYN;
		private System.Windows.Forms.CheckBox chk_BCStyleYN;
		private System.Windows.Forms.CheckBox chk_BCLineYN;
		private System.Windows.Forms.TextBox txt_BomCd;
		private System.Windows.Forms.Label lbl_BomCd;
		private System.Windows.Forms.Label btn_PopBomCd;
		private System.Windows.Forms.Label lbl_BCDStyle;
		private System.Windows.Forms.Label lbl_BCDModel;
		private System.Windows.Forms.Label lbl_BCDJob;
		private System.Windows.Forms.Label lbl_BCDDesc;
		private System.Windows.Forms.Label lbl_BCDCode;
		private System.Windows.Forms.Label lbl_BCDLine;
		private System.Windows.Forms.Label lbl_BCDLink;
		private System.Windows.Forms.Label lbl_BCDRemarks;
		private System.Windows.Forms.TextBox txt_BCDStyle;
		private System.Windows.Forms.TextBox txt_BCDModel;
		private System.Windows.Forms.TextBox txt_BCDDesc;
		private System.Windows.Forms.TextBox txt_BCDCode;
		private System.Windows.Forms.TextBox txt_BCDRemarks;
		private System.Windows.Forms.TextBox txt_BCDLine;
		private C1.Win.C1List.C1Combo cmb_BCDLinkType;
		private C1.Win.C1List.C1Combo cmb_BCDJobCd;
		private System.Windows.Forms.Label btn_CreateBomCd;
		private System.Windows.Forms.TextBox txt_BCLine;
		private System.Windows.Forms.TextBox txt_BCStyle;
		private System.Windows.Forms.TextBox txt_BCModel;
		public System.Windows.Forms.Panel pnl_SearchRight;
		public System.Windows.Forms.Panel pnl_SearchRightImage;
		public System.Windows.Forms.PictureBox picb_RBR;
		public System.Windows.Forms.PictureBox picb_RBM;
		public System.Windows.Forms.PictureBox picb_RMR;
		public System.Windows.Forms.PictureBox picb_RTR;
		public System.Windows.Forms.PictureBox picb_RTM;
		public System.Windows.Forms.PictureBox picb_RMM;
		public System.Windows.Forms.PictureBox picb_RBL;
		public System.Windows.Forms.PictureBox picb_RML;
		private System.Windows.Forms.Splitter splitter_Body;
		public System.Windows.Forms.Panel pnl_SearchLeft;
		public System.Windows.Forms.Panel pnl_SearchLeftImage;
		public System.Windows.Forms.PictureBox picb_LBL;
		public System.Windows.Forms.PictureBox picb_LBR;
		public System.Windows.Forms.PictureBox picb_LBM;
		public System.Windows.Forms.PictureBox picb_LMR;
		public System.Windows.Forms.PictureBox picb_LTR;
		public System.Windows.Forms.PictureBox picb_LTM;
		public System.Windows.Forms.PictureBox picb_LMM;
		public System.Windows.Forms.PictureBox picb_LML;
		public System.Windows.Forms.Label lbl_SubTitle5;
		public System.Windows.Forms.Label lbl_SubTitle4;
		private C1.Win.C1List.C1Combo cmb_BTFactory;
		private System.Windows.Forms.Label lbl_BTFactory;
		public COM.FSP fgrid_CmpType;
		private System.Windows.Forms.Panel pnl_BTBody;
		private System.Windows.Forms.Panel pnl_BTBodyLeft;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.PictureBox pictureBox18;
		public System.Windows.Forms.PictureBox pictureBox19;
		public System.Windows.Forms.PictureBox pictureBox20;
		public System.Windows.Forms.PictureBox pictureBox21;
		public System.Windows.Forms.PictureBox pictureBox22;
		public System.Windows.Forms.PictureBox pictureBox23;
		public System.Windows.Forms.PictureBox pictureBox24;
		public System.Windows.Forms.PictureBox pictureBox33;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel6;
		public System.Windows.Forms.Panel panel8;
		public System.Windows.Forms.Panel panel9;
		public System.Windows.Forms.PictureBox pictureBox34;
		public System.Windows.Forms.PictureBox pictureBox35;
		public System.Windows.Forms.PictureBox pictureBox36;
		public System.Windows.Forms.PictureBox pictureBox37;
		public System.Windows.Forms.PictureBox pictureBox38;
		public System.Windows.Forms.PictureBox pictureBox39;
		public System.Windows.Forms.PictureBox pictureBox40;
		public System.Windows.Forms.PictureBox pictureBox41;
		private Lassalle.Flow.AddFlow addflow_CmpType;
		public COM.FSP fgrid_LinkProp;
		private C1.Win.C1List.C1Combo cmb_BLFactory;
		private System.Windows.Forms.Label lbl_BLFactory;
		private Lassalle.Flow.AddFlow addflow_LinkProp;
		public System.Windows.Forms.Label lbl_SubTitle7;
		public System.Windows.Forms.Label lbl_SubTitle6;
		private System.Windows.Forms.ImageList img_Tree;
		private System.Windows.Forms.ContextMenu cmenu_Prop;
		private System.Windows.Forms.MenuItem menuItem_NodeProp;
		private System.Windows.Forms.MenuItem menuItem_LinkProp;
		private System.Windows.Forms.MenuItem menuItem_DeleteItem;
		private System.Windows.Forms.ContextMenu cmenu_Tree;
		private System.Windows.Forms.MenuItem menuItem_EAppend;
		private System.Windows.Forms.MenuItem menuItem_LAppend;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem_EInsert;
		private System.Windows.Forms.MenuItem menuItem_LInsert;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem_Update;
		private System.Windows.Forms.MenuItem menuItem_Delete;
		private System.Windows.Forms.MenuItem menuItem_Tree;
		private System.Windows.Forms.MenuItem menuItem_Print;
		public System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.CheckBox chk_BCUser;
		private System.Windows.Forms.TextBox txt_BCUser;
		private System.Windows.Forms.Label lbl_BCDDefault;
		private System.Windows.Forms.CheckBox chk_BCDDefault;
		private System.Windows.Forms.Label lbl_BCDOrd;
		private System.Windows.Forms.TextBox txt_BCDOrder;
		private System.Windows.Forms.MenuItem menuItem_Save;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem_ViewRout;
		private System.Windows.Forms.MenuItem menuItem_SetRout;
		private System.Windows.Forms.Panel pnl_B;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel13;
		public System.Windows.Forms.Panel panel14;
		public System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.Label btn_Copy;
		public C1.Win.C1List.C1Combo cmb_SBBomCd;
		private System.Windows.Forms.Label lbl_SBBomCd;
		public System.Windows.Forms.PictureBox pictureBox50;
		public System.Windows.Forms.PictureBox pictureBox51;
		public C1.Win.C1List.C1Combo cmb_SBFactory;
		private System.Windows.Forms.Label lbl_SBFactory;
		public System.Windows.Forms.PictureBox pictureBox52;
		public System.Windows.Forms.PictureBox pictureBox53;
		public System.Windows.Forms.PictureBox pictureBox54;
		public System.Windows.Forms.PictureBox pictureBox55;
		public System.Windows.Forms.PictureBox pictureBox56;
		public System.Windows.Forms.Label lbl_SubTitle8;
		public System.Windows.Forms.PictureBox pictureBox57;
		private System.Windows.Forms.Panel pnl_BL;
		public COM.FSP fgrid_BOM;
		private System.Windows.Forms.Splitter splitter2;
        private Lassalle.Flow.AddFlow addflow_BOM;
        private COM.FSP fgrid_BomNode;
        private COM.FSP fgrid_BomLink;
        private COM.FSP fgrid_NodeDef;
        private COM.FSP fgrid_LinkDef;
		private System.ComponentModel.IContainer components = null;

		public Form_PB_BOM()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PB_BOM));
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
            this.obar_Main = new C1.Win.C1Command.C1OutBar();
            this.obarpg_BOMCd = new C1.Win.C1Command.C1OutPage();
            this.pnl_BCBody = new System.Windows.Forms.Panel();
            this.fgrid_BomCd = new COM.FSP();
            this.pnl_BCBodyLeftTop = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmb_BCFactory = new C1.Win.C1List.C1Combo();
            this.lbl_BCFactory = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pnl_BCBodyRight = new System.Windows.Forms.Panel();
            this.pnl_BCBodyRightBody = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_BCDOrder = new System.Windows.Forms.TextBox();
            this.lbl_BCDOrd = new System.Windows.Forms.Label();
            this.chk_BCDDefault = new System.Windows.Forms.CheckBox();
            this.lbl_BCDDefault = new System.Windows.Forms.Label();
            this.txt_BCDRemarks = new System.Windows.Forms.TextBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.cmb_BCDLinkType = new C1.Win.C1List.C1Combo();
            this.cmb_BCDJobCd = new C1.Win.C1List.C1Combo();
            this.txt_BCDLine = new System.Windows.Forms.TextBox();
            this.lbl_BCDRemarks = new System.Windows.Forms.Label();
            this.lbl_BCDLink = new System.Windows.Forms.Label();
            this.lbl_BCDLine = new System.Windows.Forms.Label();
            this.txt_BCDStyle = new System.Windows.Forms.TextBox();
            this.lbl_BCDStyle = new System.Windows.Forms.Label();
            this.txt_BCDModel = new System.Windows.Forms.TextBox();
            this.lbl_BCDModel = new System.Windows.Forms.Label();
            this.lbl_BCDJob = new System.Windows.Forms.Label();
            this.txt_BCDDesc = new System.Windows.Forms.TextBox();
            this.lbl_BCDDesc = new System.Windows.Forms.Label();
            this.txt_BCDCode = new System.Windows.Forms.TextBox();
            this.lbl_BCDCode = new System.Windows.Forms.Label();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle3 = new System.Windows.Forms.Label();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pnl_BCBodyRightTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_BCUser = new System.Windows.Forms.TextBox();
            this.chk_BCUser = new System.Windows.Forms.CheckBox();
            this.btn_CreateBomCd = new System.Windows.Forms.Label();
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.txt_BomCd = new System.Windows.Forms.TextBox();
            this.lbl_BomCd = new System.Windows.Forms.Label();
            this.btn_PopBomCd = new System.Windows.Forms.Label();
            this.txt_BCLine = new System.Windows.Forms.TextBox();
            this.txt_BCStyle = new System.Windows.Forms.TextBox();
            this.txt_BCModel = new System.Windows.Forms.TextBox();
            this.chk_BCLineYN = new System.Windows.Forms.CheckBox();
            this.chk_BCStyleYN = new System.Windows.Forms.CheckBox();
            this.chk_BCModelYN = new System.Windows.Forms.CheckBox();
            this.chk_BCFactoryYN = new System.Windows.Forms.CheckBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle2 = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.obarpg_StdBOM = new C1.Win.C1Command.C1OutPage();
            this.pnl_B = new System.Windows.Forms.Panel();
            this.fgrid_BomNode = new COM.FSP();
            this.cmenu_Tree = new System.Windows.Forms.ContextMenu();
            this.menuItem_EAppend = new System.Windows.Forms.MenuItem();
            this.menuItem_LAppend = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem_EInsert = new System.Windows.Forms.MenuItem();
            this.menuItem_LInsert = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem_Update = new System.Windows.Forms.MenuItem();
            this.menuItem_Delete = new System.Windows.Forms.MenuItem();
            this.fgrid_BomLink = new COM.FSP();
            this.fgrid_NodeDef = new COM.FSP();
            this.fgrid_LinkDef = new COM.FSP();
            this.addflow_BOM = new Lassalle.Flow.AddFlow();
            this.cmenu_Prop = new System.Windows.Forms.ContextMenu();
            this.menuItem_NodeProp = new System.Windows.Forms.MenuItem();
            this.menuItem_LinkProp = new System.Windows.Forms.MenuItem();
            this.menuItem_DeleteItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem_Tree = new System.Windows.Forms.MenuItem();
            this.menuItem_Print = new System.Windows.Forms.MenuItem();
            this.menuItem_Save = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem_ViewRout = new System.Windows.Forms.MenuItem();
            this.menuItem_SetRout = new System.Windows.Forms.MenuItem();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnl_BL = new System.Windows.Forms.Panel();
            this.fgrid_BOM = new COM.FSP();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btn_Copy = new System.Windows.Forms.Label();
            this.cmb_SBBomCd = new C1.Win.C1List.C1Combo();
            this.lbl_SBBomCd = new System.Windows.Forms.Label();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.cmb_SBFactory = new C1.Win.C1List.C1Combo();
            this.lbl_SBFactory = new System.Windows.Forms.Label();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle8 = new System.Windows.Forms.Label();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.obarpg_CmpType = new C1.Win.C1Command.C1OutPage();
            this.pnl_BTBody = new System.Windows.Forms.Panel();
            this.pnl_SearchRight = new System.Windows.Forms.Panel();
            this.pnl_SearchRightImage = new System.Windows.Forms.Panel();
            this.addflow_CmpType = new Lassalle.Flow.AddFlow();
            this.picb_RBR = new System.Windows.Forms.PictureBox();
            this.picb_RBM = new System.Windows.Forms.PictureBox();
            this.picb_RMR = new System.Windows.Forms.PictureBox();
            this.picb_RTR = new System.Windows.Forms.PictureBox();
            this.picb_RTM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle5 = new System.Windows.Forms.Label();
            this.picb_RMM = new System.Windows.Forms.PictureBox();
            this.picb_RBL = new System.Windows.Forms.PictureBox();
            this.picb_RML = new System.Windows.Forms.PictureBox();
            this.splitter_Body = new System.Windows.Forms.Splitter();
            this.pnl_BTBodyLeft = new System.Windows.Forms.Panel();
            this.pnl_SearchLeft = new System.Windows.Forms.Panel();
            this.pnl_SearchLeftImage = new System.Windows.Forms.Panel();
            this.fgrid_CmpType = new COM.FSP();
            this.picb_LBL = new System.Windows.Forms.PictureBox();
            this.picb_LBR = new System.Windows.Forms.PictureBox();
            this.cmb_BTFactory = new C1.Win.C1List.C1Combo();
            this.lbl_BTFactory = new System.Windows.Forms.Label();
            this.picb_LBM = new System.Windows.Forms.PictureBox();
            this.picb_LMR = new System.Windows.Forms.PictureBox();
            this.picb_LTR = new System.Windows.Forms.PictureBox();
            this.picb_LTM = new System.Windows.Forms.PictureBox();
            this.picb_LMM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle4 = new System.Windows.Forms.Label();
            this.picb_LML = new System.Windows.Forms.PictureBox();
            this.obarpg_LinkProp = new C1.Win.C1Command.C1OutPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addflow_LinkProp = new Lassalle.Flow.AddFlow();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle7 = new System.Windows.Forms.Label();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.fgrid_LinkProp = new COM.FSP();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.cmb_BLFactory = new C1.Win.C1List.C1Combo();
            this.lbl_BLFactory = new System.Windows.Forms.Label();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle6 = new System.Windows.Forms.Label();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.img_Tree = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
            this.obar_Main.SuspendLayout();
            this.obarpg_BOMCd.SuspendLayout();
            this.pnl_BCBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BomCd)).BeginInit();
            this.pnl_BCBodyLeftTop.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BCFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.pnl_BCBodyRight.SuspendLayout();
            this.pnl_BCBodyRightBody.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BCDLinkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BCDJobCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            this.pnl_BCBodyRightTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.obarpg_StdBOM.SuspendLayout();
            this.pnl_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BomNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BomLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkDef)).BeginInit();
            this.pnl_BL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BOM)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SBBomCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SBFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            this.obarpg_CmpType.SuspendLayout();
            this.pnl_BTBody.SuspendLayout();
            this.pnl_SearchRight.SuspendLayout();
            this.pnl_SearchRightImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RML)).BeginInit();
            this.pnl_BTBodyLeft.SuspendLayout();
            this.pnl_SearchLeft.SuspendLayout();
            this.pnl_SearchLeftImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_CmpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BTFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LML)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BLFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
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
            this.stbar.Location = new System.Drawing.Point(0, 623);
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
            // obar_Main
            // 
            this.obar_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.obar_Main.BackColor = System.Drawing.SystemColors.Window;
            this.obar_Main.Controls.Add(this.obarpg_BOMCd);
            this.obar_Main.Controls.Add(this.obarpg_StdBOM);
            this.obar_Main.Controls.Add(this.obarpg_CmpType);
            this.obar_Main.Controls.Add(this.obarpg_LinkProp);
            this.obar_Main.Location = new System.Drawing.Point(8, 64);
            this.obar_Main.Name = "obar_Main";
            this.obar_Main.Pages.Add(this.obarpg_BOMCd);
            this.obar_Main.Pages.Add(this.obarpg_StdBOM);
            this.obar_Main.Pages.Add(this.obarpg_CmpType);
            this.obar_Main.Pages.Add(this.obarpg_LinkProp);
            this.obar_Main.SelectedIndex = 1;
            this.obar_Main.Size = new System.Drawing.Size(1000, 552);
            this.obar_Main.Text = "c1OutBar1";
            this.obar_Main.SelectedPageChanged += new System.EventHandler(this.obar_Main_SelectedPageChanged);
            // 
            // obarpg_BOMCd
            // 
            this.obarpg_BOMCd.Controls.Add(this.pnl_BCBody);
            this.obarpg_BOMCd.Location = new System.Drawing.Point(0, 0);
            this.obarpg_BOMCd.Name = "obarpg_BOMCd";
            this.obarpg_BOMCd.Size = new System.Drawing.Size(0, 0);
            this.obarpg_BOMCd.TabIndex = 0;
            this.obarpg_BOMCd.Text = "BOM Code";
            // 
            // pnl_BCBody
            // 
            this.pnl_BCBody.Controls.Add(this.fgrid_BomCd);
            this.pnl_BCBody.Controls.Add(this.pnl_BCBodyLeftTop);
            this.pnl_BCBody.Controls.Add(this.pnl_BCBodyRight);
            this.pnl_BCBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BCBody.Location = new System.Drawing.Point(0, 0);
            this.pnl_BCBody.Name = "pnl_BCBody";
            this.pnl_BCBody.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_BCBody.Size = new System.Drawing.Size(0, 0);
            this.pnl_BCBody.TabIndex = 0;
            // 
            // fgrid_BomCd
            // 
            this.fgrid_BomCd.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_BomCd.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_BomCd.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_BomCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_BomCd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_BomCd.Location = new System.Drawing.Point(8, 81);
            this.fgrid_BomCd.Name = "fgrid_BomCd";
            this.fgrid_BomCd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_BomCd.Size = new System.Drawing.Size(0, 0);
            this.fgrid_BomCd.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_BomCd.Styles"));
            this.fgrid_BomCd.TabIndex = 37;
            this.fgrid_BomCd.DoubleClick += new System.EventHandler(this.fgrid_BomCd_DoubleClick);
            this.fgrid_BomCd.Click += new System.EventHandler(this.fgrid_BomCd_Click);
            // 
            // pnl_BCBodyLeftTop
            // 
            this.pnl_BCBodyLeftTop.Controls.Add(this.panel5);
            this.pnl_BCBodyLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BCBodyLeftTop.Location = new System.Drawing.Point(8, 8);
            this.pnl_BCBodyLeftTop.Name = "pnl_BCBodyLeftTop";
            this.pnl_BCBodyLeftTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_BCBodyLeftTop.Size = new System.Drawing.Size(0, 73);
            this.pnl_BCBodyLeftTop.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.pictureBox17);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.cmb_BCFactory);
            this.panel5.Controls.Add(this.lbl_BCFactory);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Controls.Add(this.lbl_SubTitle1);
            this.panel5.Controls.Add(this.pictureBox7);
            this.panel5.Controls.Add(this.pictureBox8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 65);
            this.panel5.TabIndex = 19;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(-15, 32);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(20, 21);
            this.pictureBox17.TabIndex = 29;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 15);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-16, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 16);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // cmb_BCFactory
            // 
            this.cmb_BCFactory.AddItemCols = 0;
            this.cmb_BCFactory.AddItemSeparator = ';';
            this.cmb_BCFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_BCFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_BCFactory.Caption = "";
            this.cmb_BCFactory.CaptionHeight = 17;
            this.cmb_BCFactory.CaptionStyle = style1;
            this.cmb_BCFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_BCFactory.ColumnCaptionHeight = 18;
            this.cmb_BCFactory.ColumnFooterHeight = 18;
            this.cmb_BCFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_BCFactory.ContentHeight = 17;
            this.cmb_BCFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_BCFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_BCFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BCFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_BCFactory.EditorHeight = 17;
            this.cmb_BCFactory.Enabled = false;
            this.cmb_BCFactory.EvenRowStyle = style2;
            this.cmb_BCFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BCFactory.FooterStyle = style3;
            this.cmb_BCFactory.GapHeight = 2;
            this.cmb_BCFactory.HeadingStyle = style4;
            this.cmb_BCFactory.HighLightRowStyle = style5;
            this.cmb_BCFactory.ItemHeight = 15;
            this.cmb_BCFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_BCFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_BCFactory.MaxDropDownItems = ((short)(5));
            this.cmb_BCFactory.MaxLength = 32767;
            this.cmb_BCFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_BCFactory.Name = "cmb_BCFactory";
            this.cmb_BCFactory.OddRowStyle = style6;
            this.cmb_BCFactory.PartialRightColumn = false;
            this.cmb_BCFactory.PropBag = resources.GetString("cmb_BCFactory.PropBag");
            this.cmb_BCFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_BCFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_BCFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_BCFactory.SelectedStyle = style7;
            this.cmb_BCFactory.Size = new System.Drawing.Size(180, 21);
            this.cmb_BCFactory.Style = style8;
            this.cmb_BCFactory.TabIndex = 14;
            this.cmb_BCFactory.SelectedValueChanged += new System.EventHandler(this.cmb_BCFactory_SelectedValueChanged);
            // 
            // lbl_BCFactory
            // 
            this.lbl_BCFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_BCFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCFactory.ImageIndex = 0;
            this.lbl_BCFactory.ImageList = this.img_Label;
            this.lbl_BCFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_BCFactory.Name = "lbl_BCFactory";
            this.lbl_BCFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCFactory.TabIndex = 13;
            this.lbl_BCFactory.Text = "Factory";
            this.lbl_BCFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(131, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(0, 18);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-16, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 32);
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
            this.pictureBox5.Size = new System.Drawing.Size(0, 32);
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
            this.pictureBox6.Size = new System.Drawing.Size(0, 25);
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
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
            this.lbl_SubTitle1.Text = "      BOM Code Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 25);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 45);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(168, 20);
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            // 
            // pnl_BCBodyRight
            // 
            this.pnl_BCBodyRight.Controls.Add(this.pnl_BCBodyRightBody);
            this.pnl_BCBodyRight.Controls.Add(this.pnl_BCBodyRightTop);
            this.pnl_BCBodyRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_BCBodyRight.Location = new System.Drawing.Point(-361, 8);
            this.pnl_BCBodyRight.Name = "pnl_BCBodyRight";
            this.pnl_BCBodyRight.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnl_BCBodyRight.Size = new System.Drawing.Size(353, 0);
            this.pnl_BCBodyRight.TabIndex = 0;
            // 
            // pnl_BCBodyRightBody
            // 
            this.pnl_BCBodyRightBody.Controls.Add(this.panel7);
            this.pnl_BCBodyRightBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BCBodyRightBody.Location = new System.Drawing.Point(8, 152);
            this.pnl_BCBodyRightBody.Name = "pnl_BCBodyRightBody";
            this.pnl_BCBodyRightBody.Size = new System.Drawing.Size(345, 0);
            this.pnl_BCBodyRightBody.TabIndex = 38;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.txt_BCDOrder);
            this.panel7.Controls.Add(this.lbl_BCDOrd);
            this.panel7.Controls.Add(this.chk_BCDDefault);
            this.panel7.Controls.Add(this.lbl_BCDDefault);
            this.panel7.Controls.Add(this.txt_BCDRemarks);
            this.panel7.Controls.Add(this.pictureBox29);
            this.panel7.Controls.Add(this.pictureBox30);
            this.panel7.Controls.Add(this.cmb_BCDLinkType);
            this.panel7.Controls.Add(this.cmb_BCDJobCd);
            this.panel7.Controls.Add(this.txt_BCDLine);
            this.panel7.Controls.Add(this.lbl_BCDRemarks);
            this.panel7.Controls.Add(this.lbl_BCDLink);
            this.panel7.Controls.Add(this.lbl_BCDLine);
            this.panel7.Controls.Add(this.txt_BCDStyle);
            this.panel7.Controls.Add(this.lbl_BCDStyle);
            this.panel7.Controls.Add(this.txt_BCDModel);
            this.panel7.Controls.Add(this.lbl_BCDModel);
            this.panel7.Controls.Add(this.lbl_BCDJob);
            this.panel7.Controls.Add(this.txt_BCDDesc);
            this.panel7.Controls.Add(this.lbl_BCDDesc);
            this.panel7.Controls.Add(this.txt_BCDCode);
            this.panel7.Controls.Add(this.lbl_BCDCode);
            this.panel7.Controls.Add(this.pictureBox25);
            this.panel7.Controls.Add(this.pictureBox26);
            this.panel7.Controls.Add(this.pictureBox27);
            this.panel7.Controls.Add(this.lbl_SubTitle3);
            this.panel7.Controls.Add(this.pictureBox28);
            this.panel7.Controls.Add(this.pictureBox31);
            this.panel7.Controls.Add(this.pictureBox32);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(345, 0);
            this.panel7.TabIndex = 20;
            // 
            // txt_BCDOrder
            // 
            this.txt_BCDOrder.BackColor = System.Drawing.SystemColors.Window;
            this.txt_BCDOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCDOrder.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BCDOrder.Location = new System.Drawing.Point(237, 80);
            this.txt_BCDOrder.MaxLength = 60;
            this.txt_BCDOrder.Name = "txt_BCDOrder";
            this.txt_BCDOrder.Size = new System.Drawing.Size(54, 21);
            this.txt_BCDOrder.TabIndex = 164;
            // 
            // lbl_BCDOrd
            // 
            this.lbl_BCDOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_BCDOrd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCDOrd.ImageIndex = 0;
            this.lbl_BCDOrd.ImageList = this.img_Label;
            this.lbl_BCDOrd.Location = new System.Drawing.Point(136, 80);
            this.lbl_BCDOrd.Name = "lbl_BCDOrd";
            this.lbl_BCDOrd.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCDOrd.TabIndex = 163;
            this.lbl_BCDOrd.Text = "Order";
            this.lbl_BCDOrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_BCDDefault
            // 
            this.chk_BCDDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_BCDDefault.Location = new System.Drawing.Point(112, 80);
            this.chk_BCDDefault.Name = "chk_BCDDefault";
            this.chk_BCDDefault.Size = new System.Drawing.Size(16, 21);
            this.chk_BCDDefault.TabIndex = 162;
            // 
            // lbl_BCDDefault
            // 
            this.lbl_BCDDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_BCDDefault.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCDDefault.ImageIndex = 0;
            this.lbl_BCDDefault.ImageList = this.img_Label;
            this.lbl_BCDDefault.Location = new System.Drawing.Point(10, 80);
            this.lbl_BCDDefault.Name = "lbl_BCDDefault";
            this.lbl_BCDDefault.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCDDefault.TabIndex = 117;
            this.lbl_BCDDefault.Text = "Default";
            this.lbl_BCDDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_BCDRemarks
            // 
            this.txt_BCDRemarks.BackColor = System.Drawing.SystemColors.Window;
            this.txt_BCDRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCDRemarks.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BCDRemarks.Location = new System.Drawing.Point(111, 102);
            this.txt_BCDRemarks.MaxLength = 60;
            this.txt_BCDRemarks.Name = "txt_BCDRemarks";
            this.txt_BCDRemarks.Size = new System.Drawing.Size(180, 21);
            this.txt_BCDRemarks.TabIndex = 94;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox29.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
            this.pictureBox29.Location = new System.Drawing.Point(329, -16);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(16, 16);
            this.pictureBox29.TabIndex = 23;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox30.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
            this.pictureBox30.Location = new System.Drawing.Point(144, -18);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(345, 18);
            this.pictureBox30.TabIndex = 24;
            this.pictureBox30.TabStop = false;
            // 
            // cmb_BCDLinkType
            // 
            this.cmb_BCDLinkType.AddItemCols = 0;
            this.cmb_BCDLinkType.AddItemSeparator = ';';
            this.cmb_BCDLinkType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_BCDLinkType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_BCDLinkType.Caption = "";
            this.cmb_BCDLinkType.CaptionHeight = 17;
            this.cmb_BCDLinkType.CaptionStyle = style9;
            this.cmb_BCDLinkType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_BCDLinkType.ColumnCaptionHeight = 18;
            this.cmb_BCDLinkType.ColumnFooterHeight = 18;
            this.cmb_BCDLinkType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_BCDLinkType.ContentHeight = 17;
            this.cmb_BCDLinkType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_BCDLinkType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_BCDLinkType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BCDLinkType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_BCDLinkType.EditorHeight = 17;
            this.cmb_BCDLinkType.EvenRowStyle = style10;
            this.cmb_BCDLinkType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BCDLinkType.FooterStyle = style11;
            this.cmb_BCDLinkType.GapHeight = 2;
            this.cmb_BCDLinkType.HeadingStyle = style12;
            this.cmb_BCDLinkType.HighLightRowStyle = style13;
            this.cmb_BCDLinkType.ItemHeight = 15;
            this.cmb_BCDLinkType.Location = new System.Drawing.Point(112, 248);
            this.cmb_BCDLinkType.MatchEntryTimeout = ((long)(2000));
            this.cmb_BCDLinkType.MaxDropDownItems = ((short)(5));
            this.cmb_BCDLinkType.MaxLength = 32767;
            this.cmb_BCDLinkType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_BCDLinkType.Name = "cmb_BCDLinkType";
            this.cmb_BCDLinkType.OddRowStyle = style14;
            this.cmb_BCDLinkType.PartialRightColumn = false;
            this.cmb_BCDLinkType.PropBag = resources.GetString("cmb_BCDLinkType.PropBag");
            this.cmb_BCDLinkType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_BCDLinkType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_BCDLinkType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_BCDLinkType.SelectedStyle = style15;
            this.cmb_BCDLinkType.Size = new System.Drawing.Size(180, 21);
            this.cmb_BCDLinkType.Style = style16;
            this.cmb_BCDLinkType.TabIndex = 116;
            this.cmb_BCDLinkType.Visible = false;
            // 
            // cmb_BCDJobCd
            // 
            this.cmb_BCDJobCd.AddItemCols = 0;
            this.cmb_BCDJobCd.AddItemSeparator = ';';
            this.cmb_BCDJobCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_BCDJobCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_BCDJobCd.Caption = "";
            this.cmb_BCDJobCd.CaptionHeight = 17;
            this.cmb_BCDJobCd.CaptionStyle = style17;
            this.cmb_BCDJobCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_BCDJobCd.ColumnCaptionHeight = 18;
            this.cmb_BCDJobCd.ColumnFooterHeight = 18;
            this.cmb_BCDJobCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_BCDJobCd.ContentHeight = 17;
            this.cmb_BCDJobCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_BCDJobCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_BCDJobCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BCDJobCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_BCDJobCd.EditorHeight = 17;
            this.cmb_BCDJobCd.EvenRowStyle = style18;
            this.cmb_BCDJobCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BCDJobCd.FooterStyle = style19;
            this.cmb_BCDJobCd.GapHeight = 2;
            this.cmb_BCDJobCd.HeadingStyle = style20;
            this.cmb_BCDJobCd.HighLightRowStyle = style21;
            this.cmb_BCDJobCd.ItemHeight = 15;
            this.cmb_BCDJobCd.Location = new System.Drawing.Point(120, 200);
            this.cmb_BCDJobCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_BCDJobCd.MaxDropDownItems = ((short)(5));
            this.cmb_BCDJobCd.MaxLength = 32767;
            this.cmb_BCDJobCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_BCDJobCd.Name = "cmb_BCDJobCd";
            this.cmb_BCDJobCd.OddRowStyle = style22;
            this.cmb_BCDJobCd.PartialRightColumn = false;
            this.cmb_BCDJobCd.PropBag = resources.GetString("cmb_BCDJobCd.PropBag");
            this.cmb_BCDJobCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_BCDJobCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_BCDJobCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_BCDJobCd.SelectedStyle = style23;
            this.cmb_BCDJobCd.Size = new System.Drawing.Size(180, 21);
            this.cmb_BCDJobCd.Style = style24;
            this.cmb_BCDJobCd.TabIndex = 115;
            this.cmb_BCDJobCd.Visible = false;
            // 
            // txt_BCDLine
            // 
            this.txt_BCDLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_BCDLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCDLine.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BCDLine.Location = new System.Drawing.Point(120, 224);
            this.txt_BCDLine.MaxLength = 60;
            this.txt_BCDLine.Name = "txt_BCDLine";
            this.txt_BCDLine.ReadOnly = true;
            this.txt_BCDLine.Size = new System.Drawing.Size(180, 21);
            this.txt_BCDLine.TabIndex = 113;
            this.txt_BCDLine.Visible = false;
            // 
            // lbl_BCDRemarks
            // 
            this.lbl_BCDRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_BCDRemarks.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCDRemarks.ImageIndex = 0;
            this.lbl_BCDRemarks.ImageList = this.img_Label;
            this.lbl_BCDRemarks.Location = new System.Drawing.Point(10, 102);
            this.lbl_BCDRemarks.Name = "lbl_BCDRemarks";
            this.lbl_BCDRemarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCDRemarks.TabIndex = 111;
            this.lbl_BCDRemarks.Text = "Remarks";
            this.lbl_BCDRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_BCDLink
            // 
            this.lbl_BCDLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_BCDLink.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCDLink.ImageIndex = 0;
            this.lbl_BCDLink.ImageList = this.img_Label;
            this.lbl_BCDLink.Location = new System.Drawing.Point(16, 248);
            this.lbl_BCDLink.Name = "lbl_BCDLink";
            this.lbl_BCDLink.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCDLink.TabIndex = 110;
            this.lbl_BCDLink.Text = "Link Type";
            this.lbl_BCDLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_BCDLink.Visible = false;
            // 
            // lbl_BCDLine
            // 
            this.lbl_BCDLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_BCDLine.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCDLine.ImageIndex = 0;
            this.lbl_BCDLine.ImageList = this.img_Label;
            this.lbl_BCDLine.Location = new System.Drawing.Point(16, 200);
            this.lbl_BCDLine.Name = "lbl_BCDLine";
            this.lbl_BCDLine.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCDLine.TabIndex = 109;
            this.lbl_BCDLine.Text = "Line";
            this.lbl_BCDLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_BCDLine.Visible = false;
            // 
            // txt_BCDStyle
            // 
            this.txt_BCDStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_BCDStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCDStyle.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BCDStyle.Location = new System.Drawing.Point(120, 176);
            this.txt_BCDStyle.MaxLength = 60;
            this.txt_BCDStyle.Name = "txt_BCDStyle";
            this.txt_BCDStyle.ReadOnly = true;
            this.txt_BCDStyle.Size = new System.Drawing.Size(180, 21);
            this.txt_BCDStyle.TabIndex = 106;
            this.txt_BCDStyle.Visible = false;
            // 
            // lbl_BCDStyle
            // 
            this.lbl_BCDStyle.ImageIndex = 0;
            this.lbl_BCDStyle.ImageList = this.img_Label;
            this.lbl_BCDStyle.Location = new System.Drawing.Point(16, 176);
            this.lbl_BCDStyle.Name = "lbl_BCDStyle";
            this.lbl_BCDStyle.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCDStyle.TabIndex = 105;
            this.lbl_BCDStyle.Text = "Style";
            this.lbl_BCDStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_BCDStyle.Visible = false;
            // 
            // txt_BCDModel
            // 
            this.txt_BCDModel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_BCDModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCDModel.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BCDModel.Location = new System.Drawing.Point(120, 152);
            this.txt_BCDModel.MaxLength = 60;
            this.txt_BCDModel.Name = "txt_BCDModel";
            this.txt_BCDModel.ReadOnly = true;
            this.txt_BCDModel.Size = new System.Drawing.Size(180, 21);
            this.txt_BCDModel.TabIndex = 104;
            this.txt_BCDModel.Visible = false;
            // 
            // lbl_BCDModel
            // 
            this.lbl_BCDModel.ImageIndex = 0;
            this.lbl_BCDModel.ImageList = this.img_Label;
            this.lbl_BCDModel.Location = new System.Drawing.Point(16, 152);
            this.lbl_BCDModel.Name = "lbl_BCDModel";
            this.lbl_BCDModel.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCDModel.TabIndex = 103;
            this.lbl_BCDModel.Text = "Model";
            this.lbl_BCDModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_BCDModel.Visible = false;
            // 
            // lbl_BCDJob
            // 
            this.lbl_BCDJob.ImageIndex = 0;
            this.lbl_BCDJob.ImageList = this.img_Label;
            this.lbl_BCDJob.Location = new System.Drawing.Point(16, 224);
            this.lbl_BCDJob.Name = "lbl_BCDJob";
            this.lbl_BCDJob.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCDJob.TabIndex = 101;
            this.lbl_BCDJob.Text = "Job Code";
            this.lbl_BCDJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_BCDJob.Visible = false;
            // 
            // txt_BCDDesc
            // 
            this.txt_BCDDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_BCDDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCDDesc.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BCDDesc.Location = new System.Drawing.Point(111, 58);
            this.txt_BCDDesc.MaxLength = 60;
            this.txt_BCDDesc.Name = "txt_BCDDesc";
            this.txt_BCDDesc.Size = new System.Drawing.Size(180, 21);
            this.txt_BCDDesc.TabIndex = 100;
            // 
            // lbl_BCDDesc
            // 
            this.lbl_BCDDesc.ImageIndex = 0;
            this.lbl_BCDDesc.ImageList = this.img_Label;
            this.lbl_BCDDesc.Location = new System.Drawing.Point(10, 58);
            this.lbl_BCDDesc.Name = "lbl_BCDDesc";
            this.lbl_BCDDesc.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCDDesc.TabIndex = 99;
            this.lbl_BCDDesc.Text = "Description";
            this.lbl_BCDDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_BCDCode
            // 
            this.txt_BCDCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_BCDCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCDCode.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BCDCode.Location = new System.Drawing.Point(111, 36);
            this.txt_BCDCode.MaxLength = 60;
            this.txt_BCDCode.Name = "txt_BCDCode";
            this.txt_BCDCode.ReadOnly = true;
            this.txt_BCDCode.Size = new System.Drawing.Size(180, 21);
            this.txt_BCDCode.TabIndex = 98;
            // 
            // lbl_BCDCode
            // 
            this.lbl_BCDCode.ImageIndex = 0;
            this.lbl_BCDCode.ImageList = this.img_Label;
            this.lbl_BCDCode.Location = new System.Drawing.Point(10, 36);
            this.lbl_BCDCode.Name = "lbl_BCDCode";
            this.lbl_BCDCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_BCDCode.TabIndex = 39;
            this.lbl_BCDCode.Text = "Code";
            this.lbl_BCDCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox25.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
            this.pictureBox25.Location = new System.Drawing.Point(330, 24);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(15, 0);
            this.pictureBox25.TabIndex = 26;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox26.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(329, 0);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(16, 32);
            this.pictureBox26.TabIndex = 21;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox27.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(216, 0);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(347, 40);
            this.pictureBox27.TabIndex = 0;
            this.pictureBox27.TabStop = false;
            // 
            // lbl_SubTitle3
            // 
            this.lbl_SubTitle3.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_SubTitle3.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle3.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle3.Image")));
            this.lbl_SubTitle3.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle3.Name = "lbl_SubTitle3";
            this.lbl_SubTitle3.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle3.TabIndex = 20;
            this.lbl_SubTitle3.Text = "      Display BOM Code Info.";
            this.lbl_SubTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox28.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
            this.pictureBox28.Location = new System.Drawing.Point(160, 24);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(345, 0);
            this.pictureBox28.TabIndex = 27;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox31.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
            this.pictureBox31.Location = new System.Drawing.Point(0, -20);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(168, 20);
            this.pictureBox31.TabIndex = 22;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox32.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
            this.pictureBox32.Location = new System.Drawing.Point(0, 24);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(168, 0);
            this.pictureBox32.TabIndex = 25;
            this.pictureBox32.TabStop = false;
            // 
            // pnl_BCBodyRightTop
            // 
            this.pnl_BCBodyRightTop.Controls.Add(this.panel2);
            this.pnl_BCBodyRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BCBodyRightTop.Location = new System.Drawing.Point(8, 0);
            this.pnl_BCBodyRightTop.Name = "pnl_BCBodyRightTop";
            this.pnl_BCBodyRightTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_BCBodyRightTop.Size = new System.Drawing.Size(345, 152);
            this.pnl_BCBodyRightTop.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.txt_BCUser);
            this.panel2.Controls.Add(this.chk_BCUser);
            this.panel2.Controls.Add(this.btn_CreateBomCd);
            this.panel2.Controls.Add(this.txt_BomCd);
            this.panel2.Controls.Add(this.lbl_BomCd);
            this.panel2.Controls.Add(this.btn_PopBomCd);
            this.panel2.Controls.Add(this.txt_BCLine);
            this.panel2.Controls.Add(this.txt_BCStyle);
            this.panel2.Controls.Add(this.txt_BCModel);
            this.panel2.Controls.Add(this.chk_BCLineYN);
            this.panel2.Controls.Add(this.chk_BCStyleYN);
            this.panel2.Controls.Add(this.chk_BCModelYN);
            this.panel2.Controls.Add(this.chk_BCFactoryYN);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Controls.Add(this.pictureBox14);
            this.panel2.Controls.Add(this.lbl_SubTitle2);
            this.panel2.Controls.Add(this.pictureBox15);
            this.panel2.Controls.Add(this.pictureBox16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 144);
            this.panel2.TabIndex = 19;
            // 
            // txt_BCUser
            // 
            this.txt_BCUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_BCUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCUser.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BCUser.Location = new System.Drawing.Point(249, 80);
            this.txt_BCUser.MaxLength = 5;
            this.txt_BCUser.Name = "txt_BCUser";
            this.txt_BCUser.ReadOnly = true;
            this.txt_BCUser.Size = new System.Drawing.Size(60, 21);
            this.txt_BCUser.TabIndex = 162;
            // 
            // chk_BCUser
            // 
            this.chk_BCUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_BCUser.Location = new System.Drawing.Point(152, 80);
            this.chk_BCUser.Name = "chk_BCUser";
            this.chk_BCUser.Size = new System.Drawing.Size(96, 21);
            this.chk_BCUser.TabIndex = 161;
            this.chk_BCUser.Text = "User Define";
            this.chk_BCUser.CheckStateChanged += new System.EventHandler(this.chk_BomCdMemberYN_CheckStateChanged);
            // 
            // btn_CreateBomCd
            // 
            this.btn_CreateBomCd.ImageIndex = 2;
            this.btn_CreateBomCd.ImageList = this.img_MiniButton;
            this.btn_CreateBomCd.Location = new System.Drawing.Point(292, 112);
            this.btn_CreateBomCd.Name = "btn_CreateBomCd";
            this.btn_CreateBomCd.Size = new System.Drawing.Size(21, 21);
            this.btn_CreateBomCd.TabIndex = 159;
            this.btn_CreateBomCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CreateBomCd.Click += new System.EventHandler(this.btn_CreateBomCd_Click);
            this.btn_CreateBomCd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_CreateBomCd_MouseDown);
            this.btn_CreateBomCd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CreateBomCd_MouseUp);
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
            // txt_BomCd
            // 
            this.txt_BomCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_BomCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BomCd.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BomCd.Location = new System.Drawing.Point(111, 112);
            this.txt_BomCd.MaxLength = 60;
            this.txt_BomCd.Name = "txt_BomCd";
            this.txt_BomCd.ReadOnly = true;
            this.txt_BomCd.Size = new System.Drawing.Size(180, 21);
            this.txt_BomCd.TabIndex = 158;
            // 
            // lbl_BomCd
            // 
            this.lbl_BomCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_BomCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BomCd.ImageIndex = 1;
            this.lbl_BomCd.ImageList = this.img_Label;
            this.lbl_BomCd.Location = new System.Drawing.Point(10, 112);
            this.lbl_BomCd.Name = "lbl_BomCd";
            this.lbl_BomCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_BomCd.TabIndex = 157;
            this.lbl_BomCd.Text = "BOM Code";
            this.lbl_BomCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_PopBomCd
            // 
            this.btn_PopBomCd.ImageIndex = 0;
            this.btn_PopBomCd.ImageList = this.img_MiniButton;
            this.btn_PopBomCd.Location = new System.Drawing.Point(81, 36);
            this.btn_PopBomCd.Name = "btn_PopBomCd";
            this.btn_PopBomCd.Size = new System.Drawing.Size(21, 21);
            this.btn_PopBomCd.TabIndex = 156;
            this.btn_PopBomCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PopBomCd.Click += new System.EventHandler(this.btn_PopBomCd_Click);
            this.btn_PopBomCd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_PopBomCd_MouseDown);
            this.btn_PopBomCd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_PopBomCd_MouseUp);
            // 
            // txt_BCLine
            // 
            this.txt_BCLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_BCLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCLine.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BCLine.Location = new System.Drawing.Point(249, 58);
            this.txt_BCLine.MaxLength = 2;
            this.txt_BCLine.Name = "txt_BCLine";
            this.txt_BCLine.ReadOnly = true;
            this.txt_BCLine.Size = new System.Drawing.Size(60, 21);
            this.txt_BCLine.TabIndex = 152;
            // 
            // txt_BCStyle
            // 
            this.txt_BCStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_BCStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCStyle.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BCStyle.Location = new System.Drawing.Point(81, 80);
            this.txt_BCStyle.MaxLength = 6;
            this.txt_BCStyle.Name = "txt_BCStyle";
            this.txt_BCStyle.ReadOnly = true;
            this.txt_BCStyle.Size = new System.Drawing.Size(60, 21);
            this.txt_BCStyle.TabIndex = 149;
            // 
            // txt_BCModel
            // 
            this.txt_BCModel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_BCModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BCModel.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BCModel.Location = new System.Drawing.Point(81, 58);
            this.txt_BCModel.MaxLength = 6;
            this.txt_BCModel.Name = "txt_BCModel";
            this.txt_BCModel.ReadOnly = true;
            this.txt_BCModel.Size = new System.Drawing.Size(60, 21);
            this.txt_BCModel.TabIndex = 148;
            // 
            // chk_BCLineYN
            // 
            this.chk_BCLineYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_BCLineYN.Location = new System.Drawing.Point(152, 58);
            this.chk_BCLineYN.Name = "chk_BCLineYN";
            this.chk_BCLineYN.Size = new System.Drawing.Size(100, 21);
            this.chk_BCLineYN.TabIndex = 147;
            this.chk_BCLineYN.Text = "Line";
            this.chk_BCLineYN.CheckStateChanged += new System.EventHandler(this.chk_BomCdMemberYN_CheckStateChanged);
            // 
            // chk_BCStyleYN
            // 
            this.chk_BCStyleYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_BCStyleYN.Location = new System.Drawing.Point(10, 80);
            this.chk_BCStyleYN.Name = "chk_BCStyleYN";
            this.chk_BCStyleYN.Size = new System.Drawing.Size(70, 21);
            this.chk_BCStyleYN.TabIndex = 144;
            this.chk_BCStyleYN.Text = "Style";
            this.chk_BCStyleYN.CheckStateChanged += new System.EventHandler(this.chk_BomCdMemberYN_CheckStateChanged);
            // 
            // chk_BCModelYN
            // 
            this.chk_BCModelYN.BackColor = System.Drawing.SystemColors.Window;
            this.chk_BCModelYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_BCModelYN.Location = new System.Drawing.Point(10, 58);
            this.chk_BCModelYN.Name = "chk_BCModelYN";
            this.chk_BCModelYN.Size = new System.Drawing.Size(70, 21);
            this.chk_BCModelYN.TabIndex = 143;
            this.chk_BCModelYN.Text = "Model";
            this.chk_BCModelYN.ThreeState = true;
            this.chk_BCModelYN.UseVisualStyleBackColor = false;
            this.chk_BCModelYN.CheckStateChanged += new System.EventHandler(this.chk_BomCdMemberYN_CheckStateChanged);
            // 
            // chk_BCFactoryYN
            // 
            this.chk_BCFactoryYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_BCFactoryYN.Location = new System.Drawing.Point(10, 36);
            this.chk_BCFactoryYN.Name = "chk_BCFactoryYN";
            this.chk_BCFactoryYN.Size = new System.Drawing.Size(70, 21);
            this.chk_BCFactoryYN.TabIndex = 142;
            this.chk_BCFactoryYN.Text = "Factory";
            this.chk_BCFactoryYN.CheckStateChanged += new System.EventHandler(this.chk_BCFactoryYN_CheckStateChanged);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(330, 24);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 104);
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(329, 128);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(21, 16);
            this.pictureBox10.TabIndex = 23;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(131, 126);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(345, 18);
            this.pictureBox11.TabIndex = 28;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(329, 0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(21, 32);
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
            this.pictureBox13.Size = new System.Drawing.Size(345, 32);
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
            this.pictureBox14.Size = new System.Drawing.Size(345, 104);
            this.pictureBox14.TabIndex = 27;
            this.pictureBox14.TabStop = false;
            // 
            // lbl_SubTitle2
            // 
            this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
            this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle2.Name = "lbl_SubTitle2";
            this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle2.TabIndex = 20;
            this.lbl_SubTitle2.Text = "      Insert BOM Code Info.";
            this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(0, 24);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(168, 104);
            this.pictureBox15.TabIndex = 25;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(0, 124);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(168, 20);
            this.pictureBox16.TabIndex = 22;
            this.pictureBox16.TabStop = false;
            // 
            // obarpg_StdBOM
            // 
            this.obarpg_StdBOM.Controls.Add(this.pnl_B);
            this.obarpg_StdBOM.Location = new System.Drawing.Point(0, 40);
            this.obarpg_StdBOM.Name = "obarpg_StdBOM";
            this.obarpg_StdBOM.Size = new System.Drawing.Size(1000, 472);
            this.obarpg_StdBOM.TabIndex = 3;
            this.obarpg_StdBOM.Text = "Standard BOM";
            // 
            // pnl_B
            // 
            this.pnl_B.Controls.Add(this.fgrid_BomNode);
            this.pnl_B.Controls.Add(this.fgrid_BomLink);
            this.pnl_B.Controls.Add(this.fgrid_NodeDef);
            this.pnl_B.Controls.Add(this.fgrid_LinkDef);
            this.pnl_B.Controls.Add(this.addflow_BOM);
            this.pnl_B.Controls.Add(this.splitter2);
            this.pnl_B.Controls.Add(this.pnl_BL);
            this.pnl_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_B.Location = new System.Drawing.Point(0, 0);
            this.pnl_B.Name = "pnl_B";
            this.pnl_B.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_B.Size = new System.Drawing.Size(1000, 472);
            this.pnl_B.TabIndex = 1;
            // 
            // fgrid_BomNode
            // 
            this.fgrid_BomNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_BomNode.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_BomNode.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_BomNode.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_BomNode.ContextMenu = this.cmenu_Tree;
            this.fgrid_BomNode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_BomNode.Location = new System.Drawing.Point(412, 332);
            this.fgrid_BomNode.Name = "fgrid_BomNode";
            this.fgrid_BomNode.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_BomNode.Size = new System.Drawing.Size(500, 100);
            this.fgrid_BomNode.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_BomNode.Styles"));
            this.fgrid_BomNode.TabIndex = 45;
            this.fgrid_BomNode.Visible = false;
            // 
            // cmenu_Tree
            // 
            this.cmenu_Tree.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_EAppend,
            this.menuItem_LAppend,
            this.menuItem4,
            this.menuItem_EInsert,
            this.menuItem_LInsert,
            this.menuItem7,
            this.menuItem_Update,
            this.menuItem_Delete});
            // 
            // menuItem_EAppend
            // 
            this.menuItem_EAppend.Index = 0;
            this.menuItem_EAppend.Text = "Equal Level Append";
            this.menuItem_EAppend.Click += new System.EventHandler(this.menuItem_EAppend_Click);
            // 
            // menuItem_LAppend
            // 
            this.menuItem_LAppend.Index = 1;
            this.menuItem_LAppend.Text = "Low Level Append";
            this.menuItem_LAppend.Click += new System.EventHandler(this.menuItem_LAppend_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // menuItem_EInsert
            // 
            this.menuItem_EInsert.Index = 3;
            this.menuItem_EInsert.Text = "Equal Level Insert";
            this.menuItem_EInsert.Visible = false;
            this.menuItem_EInsert.Click += new System.EventHandler(this.menuItem_EInsert_Click);
            // 
            // menuItem_LInsert
            // 
            this.menuItem_LInsert.Index = 4;
            this.menuItem_LInsert.Text = "Low Level Insert";
            this.menuItem_LInsert.Visible = false;
            this.menuItem_LInsert.Click += new System.EventHandler(this.menuItem_LInsert_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 5;
            this.menuItem7.Text = "-";
            this.menuItem7.Visible = false;
            // 
            // menuItem_Update
            // 
            this.menuItem_Update.Index = 6;
            this.menuItem_Update.Text = "Update ";
            this.menuItem_Update.Visible = false;
            this.menuItem_Update.Click += new System.EventHandler(this.menuItem_Update_Click);
            // 
            // menuItem_Delete
            // 
            this.menuItem_Delete.Index = 7;
            this.menuItem_Delete.Text = "Delete";
            this.menuItem_Delete.Click += new System.EventHandler(this.menuItem_Delete_Click);
            // 
            // fgrid_BomLink
            // 
            this.fgrid_BomLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_BomLink.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_BomLink.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_BomLink.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_BomLink.ContextMenu = this.cmenu_Tree;
            this.fgrid_BomLink.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_BomLink.Location = new System.Drawing.Point(628, 222);
            this.fgrid_BomLink.Name = "fgrid_BomLink";
            this.fgrid_BomLink.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_BomLink.Size = new System.Drawing.Size(100, 100);
            this.fgrid_BomLink.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_BomLink.Styles"));
            this.fgrid_BomLink.TabIndex = 44;
            this.fgrid_BomLink.Visible = false;
            // 
            // fgrid_NodeDef
            // 
            this.fgrid_NodeDef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_NodeDef.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_NodeDef.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_NodeDef.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_NodeDef.ContextMenu = this.cmenu_Tree;
            this.fgrid_NodeDef.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_NodeDef.Location = new System.Drawing.Point(518, 217);
            this.fgrid_NodeDef.Name = "fgrid_NodeDef";
            this.fgrid_NodeDef.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_NodeDef.Size = new System.Drawing.Size(100, 100);
            this.fgrid_NodeDef.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_NodeDef.Styles"));
            this.fgrid_NodeDef.TabIndex = 43;
            this.fgrid_NodeDef.Visible = false;
            // 
            // fgrid_LinkDef
            // 
            this.fgrid_LinkDef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_LinkDef.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_LinkDef.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_LinkDef.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_LinkDef.ContextMenu = this.cmenu_Tree;
            this.fgrid_LinkDef.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_LinkDef.Location = new System.Drawing.Point(412, 217);
            this.fgrid_LinkDef.Name = "fgrid_LinkDef";
            this.fgrid_LinkDef.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_LinkDef.Size = new System.Drawing.Size(100, 100);
            this.fgrid_LinkDef.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_LinkDef.Styles"));
            this.fgrid_LinkDef.TabIndex = 42;
            this.fgrid_LinkDef.Visible = false;
            // 
            // addflow_BOM
            // 
            this.addflow_BOM.AutoScroll = true;
            this.addflow_BOM.AutoScrollMinSize = new System.Drawing.Size(745, 586);
            this.addflow_BOM.CanDrawLink = false;
            this.addflow_BOM.CanDrawNode = false;
            this.addflow_BOM.ContextMenu = this.cmenu_Prop;
            this.addflow_BOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addflow_BOM.Location = new System.Drawing.Point(403, 8);
            this.addflow_BOM.Name = "addflow_BOM";
            this.addflow_BOM.Size = new System.Drawing.Size(589, 456);
            this.addflow_BOM.TabIndex = 40;
            this.addflow_BOM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addflow_BOM_MouseDown);
            this.addflow_BOM.AfterResize += new Lassalle.Flow.AddFlow.AfterResizeEventHandler(this.addflow_BOM_AfterResize);
            this.addflow_BOM.AfterAddLink += new Lassalle.Flow.AddFlow.AfterAddLinkEventHandler(this.addflow_BOM_AfterAddLink);
            this.addflow_BOM.AfterMove += new Lassalle.Flow.AddFlow.AfterMoveEventHandler(this.addflow_BOM_AfterMove);
            // 
            // cmenu_Prop
            // 
            this.cmenu_Prop.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_NodeProp,
            this.menuItem_LinkProp,
            this.menuItem_DeleteItem,
            this.menuItem3,
            this.menuItem_Tree,
            this.menuItem_Print,
            this.menuItem_Save,
            this.menuItem5,
            this.menuItem_ViewRout,
            this.menuItem_SetRout});
            // 
            // menuItem_NodeProp
            // 
            this.menuItem_NodeProp.Index = 0;
            this.menuItem_NodeProp.Text = "Node Property";
            this.menuItem_NodeProp.Click += new System.EventHandler(this.menuItem_NodeProp_Click);
            // 
            // menuItem_LinkProp
            // 
            this.menuItem_LinkProp.Index = 1;
            this.menuItem_LinkProp.Text = "Link Property";
            this.menuItem_LinkProp.Click += new System.EventHandler(this.menuItem_LinkProp_Click);
            // 
            // menuItem_DeleteItem
            // 
            this.menuItem_DeleteItem.Index = 2;
            this.menuItem_DeleteItem.Text = "Delete Item";
            this.menuItem_DeleteItem.Click += new System.EventHandler(this.menuItem_DeleteItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "-";
            // 
            // menuItem_Tree
            // 
            this.menuItem_Tree.Index = 4;
            this.menuItem_Tree.Text = "Set Tree";
            this.menuItem_Tree.Click += new System.EventHandler(this.menuItem_Tree_Click);
            // 
            // menuItem_Print
            // 
            this.menuItem_Print.Index = 5;
            this.menuItem_Print.Text = "Print BOM";
            this.menuItem_Print.Click += new System.EventHandler(this.menuItem_Print_Click);
            // 
            // menuItem_Save
            // 
            this.menuItem_Save.Index = 6;
            this.menuItem_Save.Text = "Save BOM";
            this.menuItem_Save.Visible = false;
            this.menuItem_Save.Click += new System.EventHandler(this.menuItem_Save_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 7;
            this.menuItem5.Text = "-";
            // 
            // menuItem_ViewRout
            // 
            this.menuItem_ViewRout.Index = 8;
            this.menuItem_ViewRout.Text = "View Routing";
            this.menuItem_ViewRout.Click += new System.EventHandler(this.menuItem_ViewRout_Click);
            // 
            // menuItem_SetRout
            // 
            this.menuItem_SetRout.Index = 9;
            this.menuItem_SetRout.Text = "Set Routing";
            this.menuItem_SetRout.Visible = false;
            this.menuItem_SetRout.Click += new System.EventHandler(this.menuItem_SetRout_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(400, 8);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 456);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // pnl_BL
            // 
            this.pnl_BL.Controls.Add(this.fgrid_BOM);
            this.pnl_BL.Controls.Add(this.panel10);
            this.pnl_BL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_BL.Location = new System.Drawing.Point(8, 8);
            this.pnl_BL.Name = "pnl_BL";
            this.pnl_BL.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnl_BL.Size = new System.Drawing.Size(392, 456);
            this.pnl_BL.TabIndex = 1;
            // 
            // fgrid_BOM
            // 
            this.fgrid_BOM.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_BOM.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_BOM.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_BOM.ContextMenu = this.cmenu_Tree;
            this.fgrid_BOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_BOM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_BOM.Location = new System.Drawing.Point(0, 96);
            this.fgrid_BOM.Name = "fgrid_BOM";
            this.fgrid_BOM.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_BOM.Size = new System.Drawing.Size(387, 360);
            this.fgrid_BOM.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_BOM.Styles"));
            this.fgrid_BOM.TabIndex = 30;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel10.Size = new System.Drawing.Size(387, 96);
            this.panel10.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(387, 91);
            this.panel13.TabIndex = 25;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(387, 91);
            this.panel14.TabIndex = 20;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.Window;
            this.panel15.Controls.Add(this.btn_Copy);
            this.panel15.Controls.Add(this.cmb_SBBomCd);
            this.panel15.Controls.Add(this.lbl_SBBomCd);
            this.panel15.Controls.Add(this.pictureBox50);
            this.panel15.Controls.Add(this.pictureBox51);
            this.panel15.Controls.Add(this.cmb_SBFactory);
            this.panel15.Controls.Add(this.lbl_SBFactory);
            this.panel15.Controls.Add(this.pictureBox52);
            this.panel15.Controls.Add(this.pictureBox53);
            this.panel15.Controls.Add(this.pictureBox54);
            this.panel15.Controls.Add(this.pictureBox55);
            this.panel15.Controls.Add(this.pictureBox56);
            this.panel15.Controls.Add(this.lbl_SubTitle8);
            this.panel15.Controls.Add(this.pictureBox57);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(387, 91);
            this.panel15.TabIndex = 19;
            // 
            // btn_Copy
            // 
            this.btn_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Copy.ImageIndex = 0;
            this.btn_Copy.ImageList = this.img_Button;
            this.btn_Copy.Location = new System.Drawing.Point(304, 58);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(80, 23);
            this.btn_Copy.TabIndex = 67;
            this.btn_Copy.Text = "BOM Copy";
            this.btn_Copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            this.btn_Copy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Copy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // cmb_SBBomCd
            // 
            this.cmb_SBBomCd.AddItemCols = 0;
            this.cmb_SBBomCd.AddItemSeparator = ';';
            this.cmb_SBBomCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_SBBomCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SBBomCd.Caption = "";
            this.cmb_SBBomCd.CaptionHeight = 17;
            this.cmb_SBBomCd.CaptionStyle = style25;
            this.cmb_SBBomCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SBBomCd.ColumnCaptionHeight = 18;
            this.cmb_SBBomCd.ColumnFooterHeight = 18;
            this.cmb_SBBomCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SBBomCd.ContentHeight = 17;
            this.cmb_SBBomCd.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_SBBomCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SBBomCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SBBomCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SBBomCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SBBomCd.EditorHeight = 17;
            this.cmb_SBBomCd.EvenRowStyle = style26;
            this.cmb_SBBomCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SBBomCd.FooterStyle = style27;
            this.cmb_SBBomCd.GapHeight = 2;
            this.cmb_SBBomCd.HeadingStyle = style28;
            this.cmb_SBBomCd.HighLightRowStyle = style29;
            this.cmb_SBBomCd.ItemHeight = 15;
            this.cmb_SBBomCd.Location = new System.Drawing.Point(111, 58);
            this.cmb_SBBomCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_SBBomCd.MaxDropDownItems = ((short)(5));
            this.cmb_SBBomCd.MaxLength = 32767;
            this.cmb_SBBomCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SBBomCd.Name = "cmb_SBBomCd";
            this.cmb_SBBomCd.OddRowStyle = style30;
            this.cmb_SBBomCd.PartialRightColumn = false;
            this.cmb_SBBomCd.PropBag = resources.GetString("cmb_SBBomCd.PropBag");
            this.cmb_SBBomCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SBBomCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SBBomCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SBBomCd.SelectedStyle = style31;
            this.cmb_SBBomCd.Size = new System.Drawing.Size(192, 21);
            this.cmb_SBBomCd.Style = style32;
            this.cmb_SBBomCd.TabIndex = 31;
            this.cmb_SBBomCd.SelectedValueChanged += new System.EventHandler(this.cmb_SBBomCd_SelectedValueChanged);
            // 
            // lbl_SBBomCd
            // 
            this.lbl_SBBomCd.ImageIndex = 0;
            this.lbl_SBBomCd.ImageList = this.img_Label;
            this.lbl_SBBomCd.Location = new System.Drawing.Point(10, 58);
            this.lbl_SBBomCd.Name = "lbl_SBBomCd";
            this.lbl_SBBomCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_SBBomCd.TabIndex = 30;
            this.lbl_SBBomCd.Text = "BOM Code";
            this.lbl_SBBomCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox50
            // 
            this.pictureBox50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox50.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox50.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox50.Image")));
            this.pictureBox50.Location = new System.Drawing.Point(0, 71);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(168, 20);
            this.pictureBox50.TabIndex = 22;
            this.pictureBox50.TabStop = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox51.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox51.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox51.Image")));
            this.pictureBox51.Location = new System.Drawing.Point(371, 75);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(16, 16);
            this.pictureBox51.TabIndex = 23;
            this.pictureBox51.TabStop = false;
            // 
            // cmb_SBFactory
            // 
            this.cmb_SBFactory.AddItemCols = 0;
            this.cmb_SBFactory.AddItemSeparator = ';';
            this.cmb_SBFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_SBFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SBFactory.Caption = "";
            this.cmb_SBFactory.CaptionHeight = 17;
            this.cmb_SBFactory.CaptionStyle = style33;
            this.cmb_SBFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SBFactory.ColumnCaptionHeight = 18;
            this.cmb_SBFactory.ColumnFooterHeight = 18;
            this.cmb_SBFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SBFactory.ContentHeight = 17;
            this.cmb_SBFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SBFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SBFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SBFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SBFactory.EditorHeight = 17;
            this.cmb_SBFactory.Enabled = false;
            this.cmb_SBFactory.EvenRowStyle = style34;
            this.cmb_SBFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SBFactory.FooterStyle = style35;
            this.cmb_SBFactory.GapHeight = 2;
            this.cmb_SBFactory.HeadingStyle = style36;
            this.cmb_SBFactory.HighLightRowStyle = style37;
            this.cmb_SBFactory.ItemHeight = 15;
            this.cmb_SBFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_SBFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_SBFactory.MaxDropDownItems = ((short)(5));
            this.cmb_SBFactory.MaxLength = 32767;
            this.cmb_SBFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SBFactory.Name = "cmb_SBFactory";
            this.cmb_SBFactory.OddRowStyle = style38;
            this.cmb_SBFactory.PartialRightColumn = false;
            this.cmb_SBFactory.PropBag = resources.GetString("cmb_SBFactory.PropBag");
            this.cmb_SBFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SBFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SBFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SBFactory.SelectedStyle = style39;
            this.cmb_SBFactory.Size = new System.Drawing.Size(192, 21);
            this.cmb_SBFactory.Style = style40;
            this.cmb_SBFactory.TabIndex = 18;
            this.cmb_SBFactory.SelectedValueChanged += new System.EventHandler(this.cmb_SBFactory_SelectedValueChanged);
            // 
            // lbl_SBFactory
            // 
            this.lbl_SBFactory.ImageIndex = 0;
            this.lbl_SBFactory.ImageList = this.img_Label;
            this.lbl_SBFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_SBFactory.Name = "lbl_SBFactory";
            this.lbl_SBFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_SBFactory.TabIndex = 17;
            this.lbl_SBFactory.Text = "Factory";
            this.lbl_SBFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox52
            // 
            this.pictureBox52.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox52.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox52.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox52.Image")));
            this.pictureBox52.Location = new System.Drawing.Point(131, 73);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(240, 18);
            this.pictureBox52.TabIndex = 28;
            this.pictureBox52.TabStop = false;
            // 
            // pictureBox53
            // 
            this.pictureBox53.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox53.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox53.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox53.Image")));
            this.pictureBox53.Location = new System.Drawing.Point(372, 24);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(15, 91);
            this.pictureBox53.TabIndex = 26;
            this.pictureBox53.TabStop = false;
            // 
            // pictureBox54
            // 
            this.pictureBox54.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox54.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox54.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox54.Image")));
            this.pictureBox54.Location = new System.Drawing.Point(371, 0);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(16, 32);
            this.pictureBox54.TabIndex = 21;
            this.pictureBox54.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox55.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox55.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox55.Image")));
            this.pictureBox55.Location = new System.Drawing.Point(224, 0);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(187, 32);
            this.pictureBox55.TabIndex = 0;
            this.pictureBox55.TabStop = false;
            // 
            // pictureBox56
            // 
            this.pictureBox56.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox56.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox56.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox56.Image")));
            this.pictureBox56.Location = new System.Drawing.Point(160, 24);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(219, 91);
            this.pictureBox56.TabIndex = 27;
            this.pictureBox56.TabStop = false;
            // 
            // lbl_SubTitle8
            // 
            this.lbl_SubTitle8.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle8.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle8.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle8.Image")));
            this.lbl_SubTitle8.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle8.Name = "lbl_SubTitle8";
            this.lbl_SubTitle8.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle8.TabIndex = 20;
            this.lbl_SubTitle8.Text = "      Standard BOM Info.";
            this.lbl_SubTitle8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox57
            // 
            this.pictureBox57.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox57.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox57.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox57.Image")));
            this.pictureBox57.Location = new System.Drawing.Point(0, 24);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(168, 91);
            this.pictureBox57.TabIndex = 25;
            this.pictureBox57.TabStop = false;
            // 
            // obarpg_CmpType
            // 
            this.obarpg_CmpType.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.obarpg_CmpType.CausesValidation = false;
            this.obarpg_CmpType.Controls.Add(this.pnl_BTBody);
            this.obarpg_CmpType.Enabled = false;
            this.obarpg_CmpType.Location = new System.Drawing.Point(0, 0);
            this.obarpg_CmpType.Name = "obarpg_CmpType";
            this.obarpg_CmpType.Size = new System.Drawing.Size(0, 0);
            this.obarpg_CmpType.TabIndex = 1;
            this.obarpg_CmpType.Text = "BOM Component Type Information";
            this.obarpg_CmpType.Visible = false;
            // 
            // pnl_BTBody
            // 
            this.pnl_BTBody.Controls.Add(this.pnl_SearchRight);
            this.pnl_BTBody.Controls.Add(this.splitter_Body);
            this.pnl_BTBody.Controls.Add(this.pnl_BTBodyLeft);
            this.pnl_BTBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BTBody.Location = new System.Drawing.Point(0, 0);
            this.pnl_BTBody.Name = "pnl_BTBody";
            this.pnl_BTBody.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_BTBody.Size = new System.Drawing.Size(0, 0);
            this.pnl_BTBody.TabIndex = 35;
            // 
            // pnl_SearchRight
            // 
            this.pnl_SearchRight.Controls.Add(this.pnl_SearchRightImage);
            this.pnl_SearchRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchRight.Location = new System.Drawing.Point(404, 8);
            this.pnl_SearchRight.Name = "pnl_SearchRight";
            this.pnl_SearchRight.Size = new System.Drawing.Size(0, 0);
            this.pnl_SearchRight.TabIndex = 25;
            // 
            // pnl_SearchRightImage
            // 
            this.pnl_SearchRightImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchRightImage.Controls.Add(this.addflow_CmpType);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RBR);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RBM);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RMR);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RTR);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RTM);
            this.pnl_SearchRightImage.Controls.Add(this.lbl_SubTitle5);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RMM);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RBL);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RML);
            this.pnl_SearchRightImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchRightImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchRightImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchRightImage.Name = "pnl_SearchRightImage";
            this.pnl_SearchRightImage.Size = new System.Drawing.Size(0, 0);
            this.pnl_SearchRightImage.TabIndex = 20;
            // 
            // addflow_CmpType
            // 
            this.addflow_CmpType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.addflow_CmpType.AutoScroll = true;
            this.addflow_CmpType.AutoScrollMinSize = new System.Drawing.Size(173, 147);
            this.addflow_CmpType.CanDrawLink = false;
            this.addflow_CmpType.CanDrawNode = false;
            this.addflow_CmpType.ContextMenu = this.cmenu_Prop;
            this.addflow_CmpType.Location = new System.Drawing.Point(8, 40);
            this.addflow_CmpType.Name = "addflow_CmpType";
            this.addflow_CmpType.Size = new System.Drawing.Size(0, 0);
            this.addflow_CmpType.TabIndex = 28;
            this.addflow_CmpType.AfterEdit += new Lassalle.Flow.AddFlow.AfterEditEventHandler(this.addflow_CmpType_AfterEdit);
            this.addflow_CmpType.AfterResize += new Lassalle.Flow.AddFlow.AfterResizeEventHandler(this.addflow_CmpType_AfterResize);
            // 
            // picb_RBR
            // 
            this.picb_RBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_RBR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_RBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_RBR.Image")));
            this.picb_RBR.Location = new System.Drawing.Point(-16, -16);
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
            this.picb_RBM.Location = new System.Drawing.Point(144, -18);
            this.picb_RBM.Name = "picb_RBM";
            this.picb_RBM.Size = new System.Drawing.Size(0, 18);
            this.picb_RBM.TabIndex = 24;
            this.picb_RBM.TabStop = false;
            // 
            // picb_RMR
            // 
            this.picb_RMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_RMR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_RMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_RMR.Image")));
            this.picb_RMR.Location = new System.Drawing.Point(-15, 24);
            this.picb_RMR.Name = "picb_RMR";
            this.picb_RMR.Size = new System.Drawing.Size(15, 0);
            this.picb_RMR.TabIndex = 26;
            this.picb_RMR.TabStop = false;
            // 
            // picb_RTR
            // 
            this.picb_RTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_RTR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_RTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_RTR.Image")));
            this.picb_RTR.Location = new System.Drawing.Point(-16, 0);
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
            this.picb_RTM.Size = new System.Drawing.Size(0, 39);
            this.picb_RTM.TabIndex = 0;
            this.picb_RTM.TabStop = false;
            // 
            // lbl_SubTitle5
            // 
            this.lbl_SubTitle5.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_SubTitle5.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle5.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle5.Image")));
            this.lbl_SubTitle5.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle5.Name = "lbl_SubTitle5";
            this.lbl_SubTitle5.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle5.TabIndex = 20;
            this.lbl_SubTitle5.Text = "      Display Node Prop.";
            this.lbl_SubTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.picb_RMM.Size = new System.Drawing.Size(0, 0);
            this.picb_RMM.TabIndex = 27;
            this.picb_RMM.TabStop = false;
            // 
            // picb_RBL
            // 
            this.picb_RBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_RBL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_RBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_RBL.Image")));
            this.picb_RBL.Location = new System.Drawing.Point(0, -20);
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
            this.picb_RML.Size = new System.Drawing.Size(168, 0);
            this.picb_RML.TabIndex = 25;
            this.picb_RML.TabStop = false;
            // 
            // splitter_Body
            // 
            this.splitter_Body.Location = new System.Drawing.Point(401, 8);
            this.splitter_Body.Name = "splitter_Body";
            this.splitter_Body.Size = new System.Drawing.Size(3, 0);
            this.splitter_Body.TabIndex = 24;
            this.splitter_Body.TabStop = false;
            // 
            // pnl_BTBodyLeft
            // 
            this.pnl_BTBodyLeft.Controls.Add(this.pnl_SearchLeft);
            this.pnl_BTBodyLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_BTBodyLeft.Location = new System.Drawing.Point(8, 8);
            this.pnl_BTBodyLeft.Name = "pnl_BTBodyLeft";
            this.pnl_BTBodyLeft.Size = new System.Drawing.Size(393, 0);
            this.pnl_BTBodyLeft.TabIndex = 23;
            // 
            // pnl_SearchLeft
            // 
            this.pnl_SearchLeft.Controls.Add(this.pnl_SearchLeftImage);
            this.pnl_SearchLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchLeft.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchLeft.Name = "pnl_SearchLeft";
            this.pnl_SearchLeft.Size = new System.Drawing.Size(393, 0);
            this.pnl_SearchLeft.TabIndex = 20;
            // 
            // pnl_SearchLeftImage
            // 
            this.pnl_SearchLeftImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchLeftImage.Controls.Add(this.fgrid_CmpType);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LBL);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LBR);
            this.pnl_SearchLeftImage.Controls.Add(this.cmb_BTFactory);
            this.pnl_SearchLeftImage.Controls.Add(this.lbl_BTFactory);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LBM);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LMR);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LTR);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LTM);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LMM);
            this.pnl_SearchLeftImage.Controls.Add(this.lbl_SubTitle4);
            this.pnl_SearchLeftImage.Controls.Add(this.picb_LML);
            this.pnl_SearchLeftImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchLeftImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchLeftImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchLeftImage.Name = "pnl_SearchLeftImage";
            this.pnl_SearchLeftImage.Size = new System.Drawing.Size(393, 0);
            this.pnl_SearchLeftImage.TabIndex = 19;
            // 
            // fgrid_CmpType
            // 
            this.fgrid_CmpType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_CmpType.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_CmpType.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_CmpType.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_CmpType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_CmpType.Location = new System.Drawing.Point(10, 64);
            this.fgrid_CmpType.Name = "fgrid_CmpType";
            this.fgrid_CmpType.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_CmpType.Size = new System.Drawing.Size(377, 0);
            this.fgrid_CmpType.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_CmpType.Styles"));
            this.fgrid_CmpType.TabIndex = 29;
            this.fgrid_CmpType.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_CmpType_AfterEdit);
            // 
            // picb_LBL
            // 
            this.picb_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_LBL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBL.Image")));
            this.picb_LBL.Location = new System.Drawing.Point(0, -20);
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
            this.picb_LBR.Location = new System.Drawing.Point(377, -16);
            this.picb_LBR.Name = "picb_LBR";
            this.picb_LBR.Size = new System.Drawing.Size(16, 16);
            this.picb_LBR.TabIndex = 23;
            this.picb_LBR.TabStop = false;
            // 
            // cmb_BTFactory
            // 
            this.cmb_BTFactory.AddItemCols = 0;
            this.cmb_BTFactory.AddItemSeparator = ';';
            this.cmb_BTFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_BTFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_BTFactory.Caption = "";
            this.cmb_BTFactory.CaptionHeight = 17;
            this.cmb_BTFactory.CaptionStyle = style41;
            this.cmb_BTFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_BTFactory.ColumnCaptionHeight = 18;
            this.cmb_BTFactory.ColumnFooterHeight = 18;
            this.cmb_BTFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_BTFactory.ContentHeight = 17;
            this.cmb_BTFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_BTFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_BTFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BTFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_BTFactory.EditorHeight = 17;
            this.cmb_BTFactory.Enabled = false;
            this.cmb_BTFactory.EvenRowStyle = style42;
            this.cmb_BTFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BTFactory.FooterStyle = style43;
            this.cmb_BTFactory.GapHeight = 2;
            this.cmb_BTFactory.HeadingStyle = style44;
            this.cmb_BTFactory.HighLightRowStyle = style45;
            this.cmb_BTFactory.ItemHeight = 15;
            this.cmb_BTFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_BTFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_BTFactory.MaxDropDownItems = ((short)(5));
            this.cmb_BTFactory.MaxLength = 32767;
            this.cmb_BTFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_BTFactory.Name = "cmb_BTFactory";
            this.cmb_BTFactory.OddRowStyle = style46;
            this.cmb_BTFactory.PartialRightColumn = false;
            this.cmb_BTFactory.PropBag = resources.GetString("cmb_BTFactory.PropBag");
            this.cmb_BTFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_BTFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_BTFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_BTFactory.SelectedStyle = style47;
            this.cmb_BTFactory.Size = new System.Drawing.Size(217, 21);
            this.cmb_BTFactory.Style = style48;
            this.cmb_BTFactory.TabIndex = 18;
            this.cmb_BTFactory.SelectedValueChanged += new System.EventHandler(this.cmb_BTFactory_SelectedValueChanged);
            // 
            // lbl_BTFactory
            // 
            this.lbl_BTFactory.ImageIndex = 0;
            this.lbl_BTFactory.ImageList = this.img_Label;
            this.lbl_BTFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_BTFactory.Name = "lbl_BTFactory";
            this.lbl_BTFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_BTFactory.TabIndex = 17;
            this.lbl_BTFactory.Text = "Factory";
            this.lbl_BTFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_LBM
            // 
            this.picb_LBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_LBM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBM.Image")));
            this.picb_LBM.Location = new System.Drawing.Point(131, -18);
            this.picb_LBM.Name = "picb_LBM";
            this.picb_LBM.Size = new System.Drawing.Size(246, 18);
            this.picb_LBM.TabIndex = 28;
            this.picb_LBM.TabStop = false;
            // 
            // picb_LMR
            // 
            this.picb_LMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_LMR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMR.Image")));
            this.picb_LMR.Location = new System.Drawing.Point(378, 24);
            this.picb_LMR.Name = "picb_LMR";
            this.picb_LMR.Size = new System.Drawing.Size(15, 0);
            this.picb_LMR.TabIndex = 26;
            this.picb_LMR.TabStop = false;
            // 
            // picb_LTR
            // 
            this.picb_LTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_LTR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTR.Image")));
            this.picb_LTR.Location = new System.Drawing.Point(377, 0);
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
            this.picb_LTM.Size = new System.Drawing.Size(193, 32);
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
            this.picb_LMM.Size = new System.Drawing.Size(225, 0);
            this.picb_LMM.TabIndex = 27;
            this.picb_LMM.TabStop = false;
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
            this.lbl_SubTitle4.Text = "      BOM CMP Type Info.";
            this.lbl_SubTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_LML
            // 
            this.picb_LML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_LML.BackColor = System.Drawing.SystemColors.Window;
            this.picb_LML.Image = ((System.Drawing.Image)(resources.GetObject("picb_LML.Image")));
            this.picb_LML.Location = new System.Drawing.Point(0, 24);
            this.picb_LML.Name = "picb_LML";
            this.picb_LML.Size = new System.Drawing.Size(168, 0);
            this.picb_LML.TabIndex = 25;
            this.picb_LML.TabStop = false;
            // 
            // obarpg_LinkProp
            // 
            this.obarpg_LinkProp.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.obarpg_LinkProp.CausesValidation = false;
            this.obarpg_LinkProp.Enabled = false;
            this.obarpg_LinkProp.Location = new System.Drawing.Point(0, 0);
            this.obarpg_LinkProp.Name = "obarpg_LinkProp";
            this.obarpg_LinkProp.Size = new System.Drawing.Size(0, 0);
            this.obarpg_LinkProp.TabIndex = 2;
            this.obarpg_LinkProp.Text = "BOM Link Property";
            this.obarpg_LinkProp.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(1000, 452);
            this.panel1.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(404, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 436);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.addflow_LinkProp);
            this.panel4.Controls.Add(this.pictureBox18);
            this.panel4.Controls.Add(this.pictureBox19);
            this.panel4.Controls.Add(this.pictureBox20);
            this.panel4.Controls.Add(this.pictureBox21);
            this.panel4.Controls.Add(this.pictureBox22);
            this.panel4.Controls.Add(this.lbl_SubTitle7);
            this.panel4.Controls.Add(this.pictureBox23);
            this.panel4.Controls.Add(this.pictureBox24);
            this.panel4.Controls.Add(this.pictureBox33);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 436);
            this.panel4.TabIndex = 20;
            // 
            // addflow_LinkProp
            // 
            this.addflow_LinkProp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.addflow_LinkProp.AutoScroll = true;
            this.addflow_LinkProp.AutoScrollMinSize = new System.Drawing.Size(744, 566);
            this.addflow_LinkProp.CanDrawLink = false;
            this.addflow_LinkProp.CanDrawNode = false;
            this.addflow_LinkProp.ContextMenu = this.cmenu_Prop;
            this.addflow_LinkProp.Location = new System.Drawing.Point(9, 35);
            this.addflow_LinkProp.Name = "addflow_LinkProp";
            this.addflow_LinkProp.Size = new System.Drawing.Size(588, 436);
            this.addflow_LinkProp.TabIndex = 28;
            this.addflow_LinkProp.AfterEdit += new Lassalle.Flow.AddFlow.AfterEditEventHandler(this.addflow_LinkProp_AfterEdit);
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(572, 420);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(16, 16);
            this.pictureBox18.TabIndex = 23;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(144, 418);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(588, 18);
            this.pictureBox19.TabIndex = 24;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox20.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(573, 24);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(15, 436);
            this.pictureBox20.TabIndex = 26;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(572, 0);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(16, 32);
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
            this.pictureBox22.Size = new System.Drawing.Size(588, 39);
            this.pictureBox22.TabIndex = 0;
            this.pictureBox22.TabStop = false;
            // 
            // lbl_SubTitle7
            // 
            this.lbl_SubTitle7.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_SubTitle7.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle7.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle7.Image")));
            this.lbl_SubTitle7.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle7.Name = "lbl_SubTitle7";
            this.lbl_SubTitle7.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle7.TabIndex = 20;
            this.lbl_SubTitle7.Text = "      Display Node Prop.";
            this.lbl_SubTitle7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pictureBox23.Size = new System.Drawing.Size(588, 436);
            this.pictureBox23.TabIndex = 27;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox24.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(0, 416);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(168, 20);
            this.pictureBox24.TabIndex = 22;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox33.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox33.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox33.Image")));
            this.pictureBox33.Location = new System.Drawing.Point(0, 24);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(168, 436);
            this.pictureBox33.TabIndex = 25;
            this.pictureBox33.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(401, 8);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 436);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(8, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(393, 436);
            this.panel6.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(393, 436);
            this.panel8.TabIndex = 20;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Window;
            this.panel9.Controls.Add(this.fgrid_LinkProp);
            this.panel9.Controls.Add(this.pictureBox34);
            this.panel9.Controls.Add(this.pictureBox35);
            this.panel9.Controls.Add(this.cmb_BLFactory);
            this.panel9.Controls.Add(this.lbl_BLFactory);
            this.panel9.Controls.Add(this.pictureBox36);
            this.panel9.Controls.Add(this.pictureBox37);
            this.panel9.Controls.Add(this.pictureBox38);
            this.panel9.Controls.Add(this.pictureBox39);
            this.panel9.Controls.Add(this.pictureBox40);
            this.panel9.Controls.Add(this.lbl_SubTitle6);
            this.panel9.Controls.Add(this.pictureBox41);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(393, 436);
            this.panel9.TabIndex = 19;
            // 
            // fgrid_LinkProp
            // 
            this.fgrid_LinkProp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_LinkProp.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_LinkProp.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_LinkProp.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_LinkProp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_LinkProp.Location = new System.Drawing.Point(9, 64);
            this.fgrid_LinkProp.Name = "fgrid_LinkProp";
            this.fgrid_LinkProp.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_LinkProp.Size = new System.Drawing.Size(377, 436);
            this.fgrid_LinkProp.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_LinkProp.Styles"));
            this.fgrid_LinkProp.TabIndex = 29;
            this.fgrid_LinkProp.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_LinkProp_AfterEdit);
            // 
            // pictureBox34
            // 
            this.pictureBox34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox34.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
            this.pictureBox34.Location = new System.Drawing.Point(0, 416);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(168, 20);
            this.pictureBox34.TabIndex = 22;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox35.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(377, 420);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(16, 16);
            this.pictureBox35.TabIndex = 23;
            this.pictureBox35.TabStop = false;
            // 
            // cmb_BLFactory
            // 
            this.cmb_BLFactory.AddItemCols = 0;
            this.cmb_BLFactory.AddItemSeparator = ';';
            this.cmb_BLFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_BLFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_BLFactory.Caption = "";
            this.cmb_BLFactory.CaptionHeight = 17;
            this.cmb_BLFactory.CaptionStyle = style49;
            this.cmb_BLFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_BLFactory.ColumnCaptionHeight = 18;
            this.cmb_BLFactory.ColumnFooterHeight = 18;
            this.cmb_BLFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_BLFactory.ContentHeight = 17;
            this.cmb_BLFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_BLFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_BLFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BLFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_BLFactory.EditorHeight = 17;
            this.cmb_BLFactory.Enabled = false;
            this.cmb_BLFactory.EvenRowStyle = style50;
            this.cmb_BLFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BLFactory.FooterStyle = style51;
            this.cmb_BLFactory.GapHeight = 2;
            this.cmb_BLFactory.HeadingStyle = style52;
            this.cmb_BLFactory.HighLightRowStyle = style53;
            this.cmb_BLFactory.ItemHeight = 15;
            this.cmb_BLFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_BLFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_BLFactory.MaxDropDownItems = ((short)(5));
            this.cmb_BLFactory.MaxLength = 32767;
            this.cmb_BLFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_BLFactory.Name = "cmb_BLFactory";
            this.cmb_BLFactory.OddRowStyle = style54;
            this.cmb_BLFactory.PartialRightColumn = false;
            this.cmb_BLFactory.PropBag = resources.GetString("cmb_BLFactory.PropBag");
            this.cmb_BLFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_BLFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_BLFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_BLFactory.SelectedStyle = style55;
            this.cmb_BLFactory.Size = new System.Drawing.Size(217, 21);
            this.cmb_BLFactory.Style = style56;
            this.cmb_BLFactory.TabIndex = 18;
            this.cmb_BLFactory.SelectedValueChanged += new System.EventHandler(this.cmb_BLFactory_SelectedValueChanged);
            // 
            // lbl_BLFactory
            // 
            this.lbl_BLFactory.ImageIndex = 0;
            this.lbl_BLFactory.ImageList = this.img_Label;
            this.lbl_BLFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_BLFactory.Name = "lbl_BLFactory";
            this.lbl_BLFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_BLFactory.TabIndex = 17;
            this.lbl_BLFactory.Text = "Factory";
            this.lbl_BLFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox36.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(131, 418);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(246, 18);
            this.pictureBox36.TabIndex = 28;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox37.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
            this.pictureBox37.Location = new System.Drawing.Point(378, 24);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(15, 436);
            this.pictureBox37.TabIndex = 26;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox38.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
            this.pictureBox38.Location = new System.Drawing.Point(377, 0);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(16, 32);
            this.pictureBox38.TabIndex = 21;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox39.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(224, 0);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(193, 32);
            this.pictureBox39.TabIndex = 0;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox40.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
            this.pictureBox40.Location = new System.Drawing.Point(160, 24);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(225, 436);
            this.pictureBox40.TabIndex = 27;
            this.pictureBox40.TabStop = false;
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
            this.lbl_SubTitle6.Text = "      Link Default Node Info.";
            this.lbl_SubTitle6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox41
            // 
            this.pictureBox41.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox41.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox41.Image")));
            this.pictureBox41.Location = new System.Drawing.Point(0, 24);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(168, 436);
            this.pictureBox41.TabIndex = 25;
            this.pictureBox41.TabStop = false;
            // 
            // img_Tree
            // 
            this.img_Tree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Tree.ImageStream")));
            this.img_Tree.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Tree.Images.SetKeyName(0, "");
            this.img_Tree.Images.SetKeyName(1, "");
            this.img_Tree.Images.SetKeyName(2, "");
            this.img_Tree.Images.SetKeyName(3, "");
            // 
            // Form_PB_BOM
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 645);
            this.Controls.Add(this.obar_Main);
            this.Name = "Form_PB_BOM";
            this.Text = "Standard BOM";
            this.Load += new System.EventHandler(this.Form_PB_BOM_Load);
            this.Controls.SetChildIndex(this.obar_Main, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
            this.obar_Main.ResumeLayout(false);
            this.obarpg_BOMCd.ResumeLayout(false);
            this.pnl_BCBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BomCd)).EndInit();
            this.pnl_BCBodyLeftTop.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BCFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.pnl_BCBodyRight.ResumeLayout(false);
            this.pnl_BCBodyRightBody.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BCDLinkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BCDJobCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            this.pnl_BCBodyRightTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.obarpg_StdBOM.ResumeLayout(false);
            this.pnl_B.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BomNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BomLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkDef)).EndInit();
            this.pnl_BL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BOM)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SBBomCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SBFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            this.obarpg_CmpType.ResumeLayout(false);
            this.pnl_BTBody.ResumeLayout(false);
            this.pnl_SearchRight.ResumeLayout(false);
            this.pnl_SearchRightImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RML)).EndInit();
            this.pnl_BTBodyLeft.ResumeLayout(false);
            this.pnl_SearchLeft.ResumeLayout(false);
            this.pnl_SearchLeftImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_CmpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BTFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_LML)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BLFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion



		#region 변수 정의
	  
		private COM.OraDB MyOraDB = new COM.OraDB();
		public Hashtable _ImgTree = new Hashtable();  

		private int _Rowfixed;
 
		//새로 생기는 노드, 링크
		private Lassalle.Flow.Node _AddNode; 
		private Lassalle.Flow.Link _AddLink; 

		//새로 생기는 링크 순번, 중복 없애기 위함 
		private int _Link_Index = 0;

//		//삭제되어지는 노드 인덱스 기억, 해당 링크 없애주기 위함
//		private int[] _DelNode_ix;
 

		#endregion 

		#region 멤버 메서드


		
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
            this.WindowState = FormWindowState.Maximized;

			DataTable dt_ret;

			// Title 
			this.Text = "Standard BOM";
			this.lbl_MainTitle.Text = "Standard BOM";
			ClassLib.ComFunction.SetLangDic(this);
 

			fgrid_BomCd.Set_Grid("SXB_P_BOM_CD", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			fgrid_BomCd.Set_Action_Image(img_Action);
			_Rowfixed = fgrid_BomCd.Rows.Fixed;

            fgrid_BOM.Set_Grid("SXB_STANDARD_BOM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_BOM.Set_Action_Image(img_Action); 
			
			fgrid_BOM.ExtendLastCol = true;
			fgrid_BOM.Tree.Column = 1;


            dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();

			ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_BCFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
			ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_SBFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);   
			ClassLib.ComFunction.Clear_AddFlow(addflow_BOM); 
			
			cmb_BCFactory.SelectedValue = ClassLib.ComVar.This_Factory; 
			cmb_SBFactory.SelectedValue = ClassLib.ComVar.This_Factory; 
  
			obar_Main.SelectedPage = obarpg_BOMCd;


            chk_BCFactoryYN.Checked = true;
            chk_BCFactoryYN.Enabled = false;


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
				} 

				arg_fgrid.AutoSizeCols();
			}
			catch
			{
			}
 
		} 


		/// <summary>
		/// Select_LinkProp_Node_List : Addflow로 링크 타입 표시
		/// </summary>
		private void Select_LinkProp_Node_List()
		{
			int i;
			int top_point = 50;

			Lassalle.Flow.Node node_org; 
			Lassalle.Flow.Node node_dest; 
			Lassalle.Flow.Link link;  

			 
			for(i = _Rowfixed; i < fgrid_LinkProp.Rows.Count ; i++)
			{

				node_org = new Lassalle.Flow.Node();
				node_dest = new Lassalle.Flow.Node();

				link = new Lassalle.Flow.Link();

				node_org = addflow_LinkProp.Nodes.Add(100, top_point, 30, 20, "Org.");  
				node_dest = addflow_LinkProp.Nodes.Add(200, top_point, 30, 20, "Dest.");

				link = addflow_LinkProp.Nodes[node_org.Index].OutLinks.Add(addflow_LinkProp.Nodes[node_dest.Index]);
				link.Tag = fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxLINK_TYPE].ToString();
				link.Text = fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxLINK_TYPE].ToString();

				ClassLib.ComFunction.Set_LinkProp(fgrid_LinkProp, link, i);

				top_point = top_point + 50;

				

			} //end for  


		}

 


		/// <summary>
		/// Set_Tree : 그리드에 트리 형태로 데이터 구현
		/// </summary>
		/// <param name="arg_dt">트리로 적용될 데이터테이블</param>
		private void Set_Tree(DataTable arg_dt)
		{
			int i, j; 
 
			fgrid_BOM.Tree.Column = 1; 
			fgrid_BOM.Rows.Count = _Rowfixed;
  
			for(i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_BOM.Rows.InsertNode(i + _Rowfixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_BOM.IxCMP_LEVEL - 1].ToString()) - 1);

				fgrid_BOM[i + _Rowfixed, 0] = "";

				for(j = 1; j < fgrid_BOM.Cols.Count; j++)
				{
					fgrid_BOM[i + _Rowfixed, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
				}

				fgrid_BOM.AutoSizeCols();
 
			}
	   

			Get_Tree_Img(); 

			fgrid_BOM.Tree.Style = TreeStyleFlags.Complete;
			 
		}

	 
		/// <summary>
		/// Get_Tree_Img : CMP Type 에 따라 그리드 트리에 이미지 표시
		/// </summary>
		private void Get_Tree_Img()
		{ 
			_ImgTree.Clear();

			_ImgTree.Add("SG", img_Tree.Images[0]);
			_ImgTree.Add("TY", img_Tree.Images[1]);
			_ImgTree.Add("GP", img_Tree.Images[2]);
			_ImgTree.Add("BM", img_Tree.Images[3]);  
 
			fgrid_BOM.Cols[(int)ClassLib.TBSPB_BOM.IxCMP_TYPE].Clear(ClearFlags.Style); 
			fgrid_BOM.Cols[(int)ClassLib.TBSPB_BOM.IxCMP_TYPE].ImageAndText = false; 
 			fgrid_BOM.Cols[(int)ClassLib.TBSPB_BOM.IxCMP_TYPE].ImageMap = _ImgTree;  
			
 
		}


	
		/// <summary>
		/// Add_Node : 품목 코드 addflow 노드 추가
		/// </summary>
		/// <param name="arg_Type">추가할 노드의 default 속성위해서 품목코드 이용</param>
		private Lassalle.Flow.Node Add_Node(string arg_cd, string arg_name, string arg_type)
		{
			int i; 
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();

			//add(left, top, width, height) 
			//node = addflow_BOM.Nodes.Add(200, 50 * (fgrid_BOM.Selection.r1 + 1), 70, 20); 
 
			float left = 30 * Convert.ToInt32(fgrid_BOM[fgrid_BOM.Rows.Count - 1, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString());
			float top = 50 * Convert.ToInt32(fgrid_BOM[fgrid_BOM.Rows.Count - 1, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString());

			node = addflow_BOM.Nodes.Add(left, top, 70, 20);
 
			node.Tag = arg_cd;

			//node.Text = arg_name;
			node.Text = arg_cd;

			node.Tooltip = node.Text;

			for(i = _Rowfixed; i < fgrid_NodeDef.Rows.Count; i++)
			{
				if(fgrid_NodeDef[i, (int)ClassLib.TBSPB_NODE_DEF.IxCMP_TYPE].ToString() == arg_type)
				{ 
					ClassLib.ComFunction.Set_NodeProp(fgrid_NodeDef, node, i);  
					break;
				}
			}

			return node;

		}

			

		
		/// <summary>
		/// Add_Link :추가된 addflow 노드에 링크 추가
		/// </summary>
		/// <param name="arg_node">도착 노드(새로생긴 노드)</param>
		/// <param name="arg_upcmp_cd">상위코드(시작 노드 인덱스 찾기 위함)</param>
		private void Add_Link(Lassalle.Flow.Node arg_node, string arg_upcmp_cd)
		{ 
			int org_index = 0;

			Lassalle.Flow.Node node = new Lassalle.Flow.Node();
			Lassalle.Flow.Link link = new Lassalle.Flow.Link();

			foreach(Item item in addflow_BOM.Items)
			{
				if(item is Lassalle.Flow.Node)
				{
					node = (Lassalle.Flow.Node)item;

					if((node.Tag).ToString() == arg_upcmp_cd)
					{
						org_index = node.Index;
						break;
					} 
				} 

			} //end foreach

			link = addflow_BOM.Nodes[arg_node.Index].InLinks.Add(addflow_BOM.Nodes[node.Index]);

			if(_Link_Index == -1) _Link_Index = 0;
			
			link.Tag = _Link_Index;
			_Link_Index++;

			ClassLib.ComFunction.Set_LinkProp(fgrid_LinkDef, link, _Rowfixed);   



		}



		/// <summary>
		/// Add_CmpCd : 추가될 품목코드 그리드에 삽입, 노드, 링크 추가
		/// </summary>
		/// <param name="arg_row">추가될 그리드 행</param>
		private void Add_CmpCd(int arg_row)
		{
            int i;
            Lassalle.Flow.Node node = new Lassalle.Flow.Node();


            try
            {
                Pop_SetCmpInfo pop_form = new Pop_SetCmpInfo();

                pop_form.ShowDialog();

                /////////////////////////////////////////////////////////////////////////
                //{폼 닫힐때 이벤트(확인, 취소), 타입, 코드, 상위코드, 코드명, 레벨, 순서, 동일순서레벨, 기간, 비고} 

                if (ClassLib.ComVar.Parameter_PopUp[0] == "N") return;

                fgrid_BOM.Rows.InsertNode(arg_row, Convert.ToInt32(ClassLib.ComVar.Parameter_PopUp[5]) - 1);

                fgrid_BOM[arg_row, 0] = "I";

                for (i = 1; i < fgrid_BOM.Cols.Count - 1; i++)
                {
                    fgrid_BOM[arg_row, i] = ClassLib.ComVar.Parameter_PopUp[i];
                }

                fgrid_BOM.AutoSizeCols();

                //bom cmp type 이미지 적용
                Get_Tree_Img();

                //addflow node 추가
                node = Add_Node(fgrid_BOM[arg_row, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString(),
                    fgrid_BOM[arg_row, (int)ClassLib.TBSPB_BOM.IxCMP_NAME].ToString(),
                    fgrid_BOM[arg_row, (int)ClassLib.TBSPB_BOM.IxCMP_TYPE].ToString());
                //node.

                //addflow link 추가

                //--Root일때는 링크 추가 안함
                if (fgrid_BOM[arg_row, (int)ClassLib.TBSPB_BOM.IxUP_CMP_CD].ToString() == "-1") return;

                Add_Link(node, fgrid_BOM[arg_row, (int)ClassLib.TBSPB_BOM.IxUP_CMP_CD].ToString());

            }
            catch
            {
            }
		}

		

		/// <summary>
		/// TreeLayout : 트리로 재구성
		/// </summary>
		/// <param name="orientation"></param>
		private void TreeLayout(Lassalle.Flow.Layout.Tree.Orientation orientation)
		{
			Lassalle.Flow.Link link = new Lassalle.Flow.Link();

			try
			{

				// So that the user will be able to undo the layout in one time
				addflow_BOM.BeginAction(1005);

				// Obtain the maximum node width and height
				// These values will be used to set the values of the LayerDistance and VertexDistance properties
				//Node node;
				float maxNodeWidth = 0;
				float maxNodeHeight = 0;

				foreach(Lassalle.Flow.Node node in addflow_BOM.Nodes)
				{
					maxNodeWidth = Math.Max(maxNodeWidth, node.Size.Width);
					maxNodeHeight = Math.Max(maxNodeHeight, node.Size.Height);
				}
 
				// Create the TFlow component and perform the Tree Layout
				TFlow tflow = new TFlow();
				tflow.LayerDistance = 1 * maxNodeHeight;
				tflow.VertexDistance = 1 * maxNodeWidth;
				tflow.DrawingStyle = DrawingStyle.Layered;
				tflow.Orientation = orientation;
				tflow.Layout(addflow_BOM); 
				 
				foreach(Item item in addflow_BOM.Items)
				{
					if (item is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item;
						
						ClassLib.ComFunction.Set_LinkProp(fgrid_LinkDef, link, _Rowfixed); 
					}
				}

				addflow_BOM.EndAction();

			}
			catch (TFlowException e)
			{      
				MessageBox.Show(e.Message, this.Text);                
			}	 
		}



		
		
		#endregion 

		#region 이벤트 처리


		#region 공통 이벤트

		private void obar_Main_SelectedPageChanged(object sender, System.EventArgs e)
 		{
//			DataTable dt_ret;
//
//			tbtn_New_Click(null, null);

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_BOMCd":
 
					tbtn_Append.Enabled = false;
					tbtn_Insert.Enabled = false;
					tbtn_Delete.Enabled = true;
					tbtn_Color.Enabled = false;
					tbtn_Print.Enabled = false;
 
					break;

				case "obarpg_CmpType": 

					tbtn_Append.Enabled = true;
					tbtn_Insert.Enabled = true;
					tbtn_Delete.Enabled = true;

					menuItem_NodeProp.Visible = true;
					menuItem_LinkProp.Visible = false;
					menuItem_DeleteItem.Visible = true;
					menuItem_Tree.Visible = false; 
					menuItem_ViewRout.Visible = false;

					break;

				case "obarpg_LinkProp":
         
					tbtn_Append.Enabled = true;
					tbtn_Insert.Enabled = true;
					tbtn_Delete.Enabled = true;

					menuItem_NodeProp.Visible = false;
					menuItem_LinkProp.Visible = true;
					menuItem_DeleteItem.Visible = true;
					menuItem_Tree.Visible = false; 
					menuItem_ViewRout.Visible = false;

					break; 

				case "obarpg_StdBOM": 

					tbtn_Append.Enabled = false;
					tbtn_Insert.Enabled = false;
					tbtn_Delete.Enabled = false;

					menuItem_NodeProp.Visible = true;
					menuItem_LinkProp.Visible = true;
					menuItem_DeleteItem.Visible = false;
					menuItem_Tree.Visible = true; 
					menuItem_ViewRout.Visible = true;

					string bomcd = "BU51021014";

 
					break;

			}

		}
 

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_BOMCd":
					//cmb_BCFactory.SelectedIndex = -1;
					fgrid_BomCd.Rows.Count = _Rowfixed;

					chk_BCFactoryYN.CheckState = CheckState.Unchecked;
					chk_BCModelYN.CheckState = CheckState.Unchecked;
					chk_BCStyleYN.CheckState = CheckState.Unchecked; 
					chk_BCLineYN.CheckState = CheckState.Unchecked;
					chk_BCUser.CheckState = CheckState.Unchecked;

					txt_BCModel.Text = "";
					txt_BCStyle.Text = ""; 
					txt_BCLine.Text = "";
					txt_BCUser.Text = "";
					txt_BomCd.Text = "";

					txt_BCDCode.Text = "";
					txt_BCDDesc.Text = "";
					//cmb_BCDJobCd.SelectedIndex = -1;
					txt_BCDModel.Text = "";
					txt_BCDStyle.Text = ""; 
					txt_BCDLine.Text = "";
					chk_BCDDefault.CheckState = CheckState.Unchecked; 
					txt_BCDOrder.Text = "";
					cmb_BCDLinkType.SelectedIndex = -1;
					txt_BCDRemarks.Text = "";
					

					break;

				case "obarpg_CmpType": 
					//cmb_BTFactory.SelectedIndex = -1;
					fgrid_CmpType.Rows.Count = _Rowfixed;
					ClassLib.ComFunction.Clear_AddFlow(addflow_CmpType);
				 
					break;

				case "obarpg_LinkProp":
					//cmb_BLFactory.SelectedIndex = -1;
					fgrid_LinkProp.Rows.Count = _Rowfixed;
					ClassLib.ComFunction.Clear_AddFlow(addflow_LinkProp);

					break;

				case "obarpg_StdBOM": 
					//cmb_SBFactory.SelectedIndex = -1;
					cmb_SBBomCd.SelectedIndex = -1;
					fgrid_BOM.Rows.Count = _Rowfixed;
					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);

					break;

			}
		}
 

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_BOMCd":
					
					if(cmb_BCFactory.SelectedIndex == -1) return;

					dt_ret = Select_SPB_BOM_CD();
					Display_Grid(dt_ret, fgrid_BomCd);

					break;

				case "obarpg_CmpType": 
                
					if(cmb_BTFactory.SelectedIndex == -1) return;

					Select_BomCmpType_List();
					ClassLib.ComFunction.Clear_AddFlow(addflow_CmpType);
					Select_BomCmpType_Node_List(); 
				 
					break;

				case "obarpg_LinkProp":
                    
					if(cmb_BLFactory.SelectedIndex == -1) return;

					Select_LinkProp_List();
					ClassLib.ComFunction.Clear_AddFlow(addflow_LinkProp);
					Select_LinkProp_Node_List(); 

					break;

				case "obarpg_StdBOM":  

					if(cmb_SBFactory.SelectedIndex == -1 || cmb_SBBomCd.SelectedIndex == -1) return;

					//BOM 코드에 따른 링크 타입 데이터 가져오기
					Select_LinkType();

					//addflow 초기화
					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);

					dt_ret = Select_StdBom_List(); 
   
					if(dt_ret.Rows.Count > 0)
					{
						Set_Tree(dt_ret); 
						
						Select_StdBom_Node_List();
						Select_StdBom_Link_List();
 
						menuItem_LAppend.Enabled = true; 
						menuItem_EInsert.Enabled = true; 
						menuItem_LInsert.Enabled = true; 

					}
					else
					{
						fgrid_BOM.Tree.Column = 1; 
						fgrid_BOM.Rows.Count = _Rowfixed;

						//데이터 없을때, 초기상태 
						menuItem_LAppend.Enabled = false; 
						menuItem_EInsert.Enabled = false; 
						menuItem_LInsert.Enabled = false; 

					}


					break;

			}
		}

		  
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataSet ds_ret;
			DataTable dt_ret;
			bool save_flag = false;

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_BOMCd":
 
					Save_BomCd("I");
					
					dt_ret = Select_SPB_BOM_CD();
					Display_Grid(dt_ret, fgrid_BomCd);


					// 변경된 BOM Code 기준 BOM Combo에 다시 세팅 
					dt_ret = Select_BomCd_CmbList();
					cmb_SBBomCd.DataSource = null;
					ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SBBomCd, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code); 
					
					cmb_SBBomCd.SelectedIndex = -1;
					fgrid_BOM.Rows.Count = _Rowfixed;
					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);

					break;

				case "obarpg_CmpType": 

					//행 수정 상태 해제
					fgrid_CmpType.Select(fgrid_CmpType.Selection.r1, 0, fgrid_CmpType.Selection.r1, fgrid_CmpType.Cols.Count-1, false);
  
					//ClassLib.ComFunction.Save_List(24, "PKG_SPB_BOM.SAVE_CMPTYPE_LIST", fgrid_CmpType, _Rowfixed); 
                    MyOraDB.Save_FlexGird("PKG_SXB_P_BOM.SAVE_CMPTYPE_LIST", fgrid_CmpType); 

					Select_BomCmpType_List();
					ClassLib.ComFunction.Clear_AddFlow(addflow_CmpType);
					Select_BomCmpType_Node_List();
				 
					break;

				case "obarpg_LinkProp":
 
					//행 수정 상태 해제
					fgrid_LinkProp.Select(fgrid_LinkProp.Selection.r1, 0, fgrid_LinkProp.Selection.r1, fgrid_LinkProp.Cols.Count-1, false);
  
					//ClassLib.ComFunction.Save_List(19, "PKG_SPB_BOM.SAVE_LINKPROP_LIST", fgrid_LinkProp, _Rowfixed);
                    MyOraDB.Save_FlexGird("PKG_SXB_P_BOM.SAVE_LINKPROP_LIST", fgrid_LinkProp); 

					Select_LinkProp_List();
					ClassLib.ComFunction.Clear_AddFlow(addflow_LinkProp);
					Select_LinkProp_Node_List();

					break;

				case "obarpg_StdBOM": 
					

					//addflow 저장(노드, 링크)
					save_flag = Save_StdBom_Node_List();

					if(!save_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						break;
					}
					else
					{
						save_flag = Save_StdBom_Link_List(); 
						
						if(!save_flag)
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							break;
						}
						else
						{
							//BOM 품목 코드 저장
							save_flag = Save_StdBom_List();

							if(!save_flag)
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
								break;
							}
							else
							{
								ds_ret = MyOraDB.Exe_Modify_Procedure();

								if(ds_ret == null)
								{
									ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
									break;
								}
								else
								{
									//조회
									Set_Tree(Select_StdBom_List()); 
									ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
									Select_StdBom_Node_List();
									Select_StdBom_Link_List();
								} // end if 저장 실행
							} // end if spb_bom 저장

						} // end if spb_link_bom

					} // end if spb_node_bom
					 
					break;

			}


		}
 

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_BOMCd":
  
					break;

				case "obarpg_CmpType": 

					fgrid_CmpType.Add_Row(fgrid_CmpType.Rows.Count - 1);
					fgrid_CmpType[fgrid_CmpType.Rows.Count - 1, (int)ClassLib.TBSPB_NODE_DEF.IxFACTORY] = cmb_BTFactory.SelectedValue.ToString();
					
					//add(left, top, width, height) 
					_AddNode = addflow_CmpType.Nodes.Add(200, 50 * (fgrid_CmpType.Rows.Count - 1 - _Rowfixed), 70, 20); 
                   
				 
					break;

				case "obarpg_LinkProp":
 
					fgrid_LinkProp.Add_Row(fgrid_LinkProp.Rows.Count - 1);
					fgrid_LinkProp[fgrid_LinkProp.Rows.Count - 1, (int)ClassLib.TBSPB_LINK_DEF.IxFACTORY] = cmb_BLFactory.SelectedValue.ToString();

					Lassalle.Flow.Node node_org = new Lassalle.Flow.Node(); 
					Lassalle.Flow.Node node_dest = new Lassalle.Flow.Node();  

					node_org = addflow_LinkProp.Nodes.Add(250, 50 * (fgrid_LinkProp.Rows.Count - 1 - _Rowfixed), 30, 20, "Org.");  
					node_dest = addflow_LinkProp.Nodes.Add(350, 50 * (fgrid_LinkProp.Rows.Count - 1 - _Rowfixed), 30, 20, "Dest."); 

					_AddLink = addflow_LinkProp.Nodes[node_org.Index].OutLinks.Add(addflow_LinkProp.Nodes[node_dest.Index]);


					break; 

			}
		}
 

		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_BOMCd":
 
					break;

				case "obarpg_CmpType": 

					fgrid_CmpType.Add_Row(fgrid_CmpType.Selection.r1);
					fgrid_CmpType[fgrid_CmpType.Selection.r1, (int)ClassLib.TBSPB_NODE_DEF.IxFACTORY] = cmb_BTFactory.SelectedValue.ToString();
					
					//add(left, top, width, height) 
					_AddNode = addflow_CmpType.Nodes.Add(200, 30 * (fgrid_CmpType.Selection.r1), 70, 20);
                   
					break;

				case "obarpg_LinkProp":
 
					fgrid_LinkProp.Add_Row(fgrid_LinkProp.Selection.r1);
					fgrid_LinkProp[fgrid_LinkProp.Selection.r1, (int)ClassLib.TBSPB_LINK_DEF.IxFACTORY] = cmb_BLFactory.SelectedValue.ToString();

					Lassalle.Flow.Node node_org = new Lassalle.Flow.Node(); 
					Lassalle.Flow.Node node_dest = new Lassalle.Flow.Node();  

					node_org = addflow_LinkProp.Nodes.Add(250, 30 * (fgrid_LinkProp.Selection.r1), 30, 20, "Org.");  
					node_dest = addflow_LinkProp.Nodes.Add(350, 30 * (fgrid_LinkProp.Selection.r1), 30, 20, "Dest."); 

					_AddLink = addflow_LinkProp.Nodes[node_org.Index].OutLinks.Add(addflow_LinkProp.Nodes[node_dest.Index]);

					break;
 

			}
		}
 

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_BOMCd":
					
					DialogResult message_result; 
					message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this); 
					if(message_result == DialogResult.No) return; 

					Save_BomCd("D");

					dt_ret = Select_SPB_BOM_CD();
					Display_Grid(dt_ret, fgrid_BomCd);


					// 변경된 BOM Code 기준 BOM Combo에 다시 세팅 
					dt_ret = Select_BomCd_CmbList();
					cmb_SBBomCd.DataSource = null;
					ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SBBomCd, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code); 
					
					cmb_SBBomCd.SelectedIndex = -1;
					fgrid_BOM.Rows.Count = _Rowfixed;
					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);



					break;

				case "obarpg_CmpType": 

					fgrid_CmpType.Delete_Row(fgrid_CmpType.Selection.r1); 
				 
					break;

				case "obarpg_LinkProp":
 
					fgrid_LinkProp.Delete_Row(fgrid_LinkProp.Selection.r1);

					break; 

			}
		}

		 
 
		#endregion

		 
		#region BOM 코드 등록

		private void cmb_BCFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_BCFactory.SelectedIndex == -1) return;

				dt_ret = Select_SPB_BOM_CD();
				Display_Grid(dt_ret, fgrid_BomCd);

				
				dt_ret = Select_LinkType_CmbList();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_BCDLinkType, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Code);   
				cmb_BCDLinkType.SelectedValue = ClassLib.ComVar.BOMLinkType;

				dt_ret = ClassLib.ComVar.Select_ComCode(cmb_BCFactory.SelectedValue.ToString(), ClassLib.ComVar.CxJobCd);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_BCDJobCd, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name);  
				cmb_BCDJobCd.SelectedValue = ClassLib.ComVar.This_SysJob;


			}
			catch
			{
			}
		}



		//공장 BOM 생성 
		private void chk_BCFactoryYN_CheckStateChanged(object sender, System.EventArgs e)
		{
			try
			{
				//공장 BOM 생성할때는 나머지 비 활성화
				if(Convert.ToBoolean(chk_BCFactoryYN.CheckState))
				{
					chk_BCModelYN.Enabled = false;
					chk_BCStyleYN.Enabled = false; 
					chk_BCLineYN.Enabled = false;
					chk_BCUser.Enabled = false;

					chk_BCModelYN.CheckState = CheckState.Unchecked; 
					chk_BCStyleYN.CheckState = CheckState.Unchecked;  
					chk_BCLineYN.CheckState = CheckState.Unchecked;
					chk_BCUser.CheckState = CheckState.Unchecked; 

					btn_PopBomCd.Enabled = false;

				}
				else
				{
					chk_BCModelYN.Enabled = true;
					chk_BCStyleYN.Enabled = true; 
					chk_BCLineYN.Enabled = true;
					chk_BCUser.Enabled = true; 

					btn_PopBomCd.Enabled = true;
				}
 
				txt_BomCd.Text = "";

				txt_BCDCode.Text = "";
				txt_BCDDesc.Text = "";
				//cmb_BCDJobCd.SelectedIndex = -1;
				txt_BCDModel.Text = "";
				txt_BCDStyle.Text = ""; 
				txt_BCDLine.Text = "";
				chk_BCDDefault.CheckState = CheckState.Unchecked; 
				txt_BCDOrder.Text = "";
				cmb_BCDLinkType.SelectedIndex = -1;
				txt_BCDRemarks.Text = "";
 
			}
			catch
			{
			}

		}

		
		//모델, 스타일, 라인, User Define
		private void chk_BomCdMemberYN_CheckStateChanged(object sender, System.EventArgs e)
		{
			CheckBox src = sender as CheckBox;

			if(Convert.ToBoolean(src.CheckState))
			{
				if(src.Equals(chk_BCModelYN))
				{
					txt_BCModel.ReadOnly = false;
					txt_BCModel.BackColor = Color.FromKnownColor(KnownColor.Window);

					chk_BCFactoryYN.Enabled = false;
					chk_BCStyleYN.Enabled = false; 
					chk_BCLineYN.Enabled = false;
					chk_BCUser.Enabled = false;

				}
				else if(src.Equals(chk_BCStyleYN))
				{
					txt_BCStyle.ReadOnly = false;
					txt_BCStyle.BackColor = Color.FromKnownColor(KnownColor.Window);

					chk_BCFactoryYN.Enabled = false;
					chk_BCModelYN.Enabled = false; 
					chk_BCLineYN.Enabled = false;
					chk_BCUser.Enabled = false;

				}
				else if(src.Equals(chk_BCLineYN))
				{
					txt_BCLine.ReadOnly = false;
					txt_BCLine.BackColor = Color.FromKnownColor(KnownColor.Window);

					chk_BCFactoryYN.Enabled = false;
					chk_BCModelYN.Enabled = false; 
					chk_BCStyleYN.Enabled = false; 
					chk_BCUser.Enabled = false;

				}
				else if(src.Equals(chk_BCUser))
				{
					txt_BCUser.ReadOnly = false;
					txt_BCUser.BackColor = Color.FromKnownColor(KnownColor.Window);

					chk_BCFactoryYN.Enabled = false;
					chk_BCModelYN.Enabled = false; 
					chk_BCStyleYN.Enabled = false; 
					chk_BCLineYN.Enabled = false;

				}

				
			}
			else
			{ 
				if(src.Equals(chk_BCModelYN))
				{
					txt_BCModel.Text = "";
					txt_BCModel.ReadOnly = true;
					txt_BCModel.BackColor = Color.WhiteSmoke; 
				}
				else if(src.Equals(chk_BCStyleYN))
				{
					txt_BCStyle.Text = "";
					txt_BCStyle.ReadOnly = true;
					txt_BCStyle.BackColor = Color.WhiteSmoke; 
				}
				else if(src.Equals(chk_BCLineYN))
				{
					txt_BCLine.Text = "";
					txt_BCLine.ReadOnly = true;
					txt_BCLine.BackColor = Color.WhiteSmoke; 
				}
				else if(src.Equals(chk_BCUser))
				{
					txt_BCUser.Text = "";
					txt_BCUser.ReadOnly = true;
					txt_BCUser.BackColor = Color.WhiteSmoke; 
				}

				chk_BCFactoryYN.Enabled = true;
				chk_BCModelYN.Enabled = true; 
				chk_BCStyleYN.Enabled = true; 
				chk_BCLineYN.Enabled = true;
				chk_BCUser.Enabled = true;


			}

			txt_BomCd.Text = "";

			txt_BCDCode.Text = "";
			txt_BCDDesc.Text = "";
			//cmb_BCDJobCd.SelectedIndex = -1;
			txt_BCDModel.Text = "";
			txt_BCDStyle.Text = ""; 
			txt_BCDLine.Text = "";
			chk_BCDDefault.CheckState = CheckState.Unchecked; 
			txt_BCDOrder.Text = "";
			cmb_BCDLinkType.SelectedIndex = -1;
			txt_BCDRemarks.Text = "";
		
			btn_PopBomCd.Enabled = true;

		}

 


		private void btn_PopBomCd_Click(object sender, System.EventArgs e)
		{
			string div = "";

			try
			{
               
				Pop_GetBomCdInfo pop_form = new Pop_GetBomCdInfo(); 

				if(cmb_BCFactory.SelectedIndex == -1)
				{
					return;
				} 
				else
				{ 
					
					if(Convert.ToBoolean(chk_BCModelYN.CheckState)) div = "M";  
					if(Convert.ToBoolean(chk_BCStyleYN.CheckState)) div = "S";    
					if(Convert.ToBoolean(chk_BCLineYN.CheckState)) div = "L";  
				  
 
					ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_BCFactory.SelectedValue.ToString(), div}; 

					pop_form.ShowDialog(); 

					if (!pop_form._CloseSave) return;

					////////////////////////////////////////////////////////////////////////// 
					switch(div)
					{
						case "M":
							txt_BCModel.Text = ClassLib.ComVar.Parameter_PopUp[0]; 
							break;
						case "S":
							txt_BCStyle.Text = ClassLib.ComVar.Parameter_PopUp[0]; 
							break;
						case "L":
							txt_BCLine.Text = Convert.ToInt32(ClassLib.ComVar.Parameter_PopUp[0]).ToString().PadLeft(2, '0'); 
							break; 
					}


 
				}
			}
			catch
			{
			}
 
		}


		private void btn_PopBomCd_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopBomCd.ImageIndex = 1;
		}

		private void btn_PopBomCd_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopBomCd.ImageIndex = 0;

		}


		private void fgrid_BomCd_Click(object sender, System.EventArgs e)
		{
			try
			{
				int sel_row = fgrid_BomCd.Selection.r1;
 
				if(sel_row >= _Rowfixed)
				{
					txt_BCDCode.Text = fgrid_BomCd[sel_row, (int)ClassLib.TBSPB_BOM_CD.IxBOM_CD].ToString();
					txt_BCDDesc.Text = fgrid_BomCd[sel_row, (int)ClassLib.TBSPB_BOM_CD.IxBOM_DESC].ToString();
					cmb_BCDJobCd.SelectedValue = fgrid_BomCd[sel_row, (int)ClassLib.TBSPB_BOM_CD.IxJOB_CD].ToString();
					txt_BCDModel.Text = fgrid_BomCd[sel_row, (int)ClassLib.TBSPB_BOM_CD.IxMODEL_CD].ToString(); 
					txt_BCDStyle.Text = fgrid_BomCd[sel_row, (int)ClassLib.TBSPB_BOM_CD.IxSTYLE_CD].ToString(); 
					txt_BCDLine.Text = fgrid_BomCd[sel_row, (int)ClassLib.TBSPB_BOM_CD.IxLINE_CD].ToString();
					chk_BCDDefault.Checked = Convert.ToBoolean(fgrid_BomCd[sel_row, (int)ClassLib.TBSPB_BOM_CD.IxDEFAULT_YN].ToString());
					txt_BCDOrder.Text = fgrid_BomCd[sel_row, (int)ClassLib.TBSPB_BOM_CD.IxORD].ToString();
					cmb_BCDLinkType.SelectedValue = fgrid_BomCd[sel_row, (int)ClassLib.TBSPB_BOM_CD.IxLINK_TYPE].ToString();  
					txt_BCDRemarks.Text = fgrid_BomCd[sel_row, (int)ClassLib.TBSPB_BOM_CD.IxREMARKS].ToString(); 
 
						
				}
			}
			catch
			{
			}
		}

		 

		private void btn_CreateBomCd_Click(object sender, System.EventArgs e)
		{
			string nextbomcd = "";
			string compare = "";

			try
			{
				txt_BCDCode.Text = "";
				txt_BCDDesc.Text = "";
				//cmb_BCDJobCd.SelectedIndex = -1;
				txt_BCDModel.Text = "";
				txt_BCDStyle.Text = ""; 
				txt_BCDLine.Text = "";
				chk_BCDDefault.Checked = false;
				txt_BCDOrder.Text = "";
				cmb_BCDLinkType.SelectedIndex = -1;
				txt_BCDRemarks.Text = "";

				//-----------------------------------------------------------------------
				
				if(Convert.ToBoolean(chk_BCFactoryYN.CheckState)) compare = cmb_BCFactory.SelectedValue.ToString().PadRight(6, '0'); 
				if(Convert.ToBoolean(chk_BCModelYN.CheckState) && txt_BCModel.Text != "") compare = txt_BCModel.Text; 
				if(Convert.ToBoolean(chk_BCStyleYN.CheckState) && txt_BCStyle.Text != "") compare = txt_BCStyle.Text;  
				if(Convert.ToBoolean(chk_BCLineYN.CheckState) && txt_BCLine.Text != "") compare = "LINE" + txt_BCLine.Text.PadLeft(2, '0'); 
				if(Convert.ToBoolean(chk_BCUser.CheckState) && txt_BCUser.Text != "") compare = "U" + txt_BCUser.Text.PadRight(5, '0');  

				if(compare == "") return;

				nextbomcd = Create_BomCd(compare);
				txt_BomCd.Text = nextbomcd;
				txt_BCDCode.Text = nextbomcd;

				if(Convert.ToBoolean(chk_BCUser.CheckState))
				{
					txt_BCDModel.ReadOnly = false;
					txt_BCDModel.BackColor = Color.FromKnownColor(KnownColor.Window);
					txt_BCDStyle.ReadOnly = false;
					txt_BCDStyle.BackColor = Color.FromKnownColor(KnownColor.Window); 
					txt_BCDLine.ReadOnly = false;
					txt_BCDLine.BackColor = Color.FromKnownColor(KnownColor.Window);
				}
				else
				{
					txt_BCDModel.Text = "";
					txt_BCDModel.ReadOnly = true;
					txt_BCDModel.BackColor = Color.WhiteSmoke; 
					txt_BCDStyle.Text = "";
					txt_BCDStyle.ReadOnly = true;
					txt_BCDStyle.BackColor = Color.WhiteSmoke; 
					txt_BCDLine.Text = "";
					txt_BCDLine.ReadOnly = true;
					txt_BCDLine.BackColor = Color.WhiteSmoke;  
				}
			}
			catch
			{
			}
		}



		private void btn_CreateBomCd_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_CreateBomCd.ImageIndex = 3;
		}

		private void btn_CreateBomCd_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_CreateBomCd.ImageIndex = 2;  
		}


		private void fgrid_BomCd_DoubleClick(object sender, System.EventArgs e)
		{ 
			try
			{
				Form_PB_BOMRout pop_form = new Form_PB_BOMRout(); 
   
				ClassLib.ComVar.MenuClick_Flag = true;  

				pop_form.WindowState = System.Windows.Forms.FormWindowState.Normal;
				pop_form.Show();

				pop_form.Set_Factory(cmb_BCFactory.SelectedValue.ToString());
				pop_form.Set_BomCd(fgrid_BomCd[fgrid_BomCd.Selection.r1, (int)ClassLib.TBSPB_BOM_CD.IxBOM_CD].ToString());
				pop_form.Set_RoutType(ClassLib.ComVar.Rout_Type);
				
			}
			catch
			{
			}
		}

		

	 

		#endregion

		#region BOM 타입 등록 


		private void cmb_BTFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_BTFactory.SelectedIndex == -1) return;

			Select_BomCmpType_List();
			ClassLib.ComFunction.Clear_AddFlow(addflow_CmpType);
			Select_BomCmpType_Node_List();
		}


		private void fgrid_CmpType_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			switch(fgrid_CmpType[fgrid_CmpType.Selection.r1, 0].ToString())
			{
				case "I":
					if(fgrid_CmpType[fgrid_CmpType.Selection.r1, (int)ClassLib.TBSPB_NODE_DEF.IxCMP_TYPE].ToString() != "")  
					{
						_AddNode.Tag = fgrid_CmpType[fgrid_CmpType.Selection.r1, (int)ClassLib.TBSPB_NODE_DEF.IxCMP_TYPE].ToString();
			
						if(fgrid_CmpType[fgrid_CmpType.Selection.r1, (int)ClassLib.TBSPB_NODE_DEF.IxTYPE_NAME].ToString() != "")
						{	
							_AddNode.Text = fgrid_CmpType[fgrid_CmpType.Selection.r1, (int)ClassLib.TBSPB_NODE_DEF.IxTYPE_NAME].ToString(); 
						}
						else
						{
							_AddNode.Text = fgrid_CmpType[fgrid_CmpType.Selection.r1, (int)ClassLib.TBSPB_NODE_DEF.IxCMP_TYPE].ToString();
						}
									
						_AddNode.Tooltip = _AddNode.Text;
							
					}
					else
					{
						ClassLib.ComFunction.Data_Message("Code, Namme", ClassLib.ComVar.MgsWrongInput, this);
					}
			
					break;
			
				default:
					fgrid_CmpType.Update_Row(fgrid_CmpType.Selection.r1);
					fgrid_CmpType[fgrid_CmpType.Selection.r1, (int)ClassLib.TBSPB_NODE_DEF.IxTEXT] = fgrid_CmpType[fgrid_CmpType.Selection.r1, (int)ClassLib.TBSPB_NODE_DEF.IxTYPE_NAME];
					break;

			} //end switch 
		}


		private void addflow_CmpType_AfterEdit(object sender, Lassalle.Flow.AfterEditEventArgs e)
		{
			int i;
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();

			if(addflow_CmpType.SelectedItem.Tag != null)
			{
				for(i = _Rowfixed; i < fgrid_CmpType.Rows.Count; i++)
				{
					node = (Lassalle.Flow.Node)addflow_CmpType.SelectedItem;

					if(node.Tag.ToString() == fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxCMP_TYPE].ToString())
					{
						fgrid_CmpType.Update_Row(i); 

						RectangleF rc = node.Rect; 
   
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxTYPE_NAME] = node.Text.ToString();

						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxALIGNMENT] = node.Alignment.GetHashCode().ToString();
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxDASHSTYLE] = node.DashStyle.GetHashCode().ToString();
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxDRAWCOLOR] = node.DrawColor.ToArgb().ToString(); 
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxDRAWWIDTH] = node.DrawWidth.ToString(); 
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxFILLCOLOR] = node.FillColor.ToArgb().ToString();
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxFONT] = node.Font.Name + "/"
							+ node.Font.Size + "/"
							+ node.Font.Bold + "/"
							+ (node.Font.Italic ? true : false) + "/"
							+ (node.Font.Strikeout ? true : false) + "/"
							+ (node.Font.Underline ? true : false)  ;
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxGRADI_YN] = (node.Gradient ? "Y" : "N");
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxGRADICOLOR] = node.GradientColor.ToArgb().ToString();
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxGRADIMODE] = node.GradientMode.GetHashCode().ToString();
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxHEIGHT] = rc.Height.ToString(); 
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxSHADOW] = node.Shadow.Style.GetHashCode().ToString() + "/"
							+ node.Shadow.Color.ToArgb().ToString() + "/"
							+ node.Shadow.Size.Width.ToString() + "/"
							+ node.Shadow.Size.Height.ToString();
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxSHAPE] = node.Shape.Style.GetHashCode().ToString(); 
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxTAG] = node.Tag.ToString();
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxTEXT] = node.Text.ToString();
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxTEXTCOLOR] = node.TextColor.ToArgb().ToString(); 
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxTOOLTIP] = node.Tooltip.ToString();
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxWIDTH] = rc.Width.ToString();  
       
					}
				} //end for
			} 
		}


		private void addflow_CmpType_AfterResize(object sender, System.EventArgs e)
		{
			int i;
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();

			if(addflow_CmpType.SelectedItem.Tag != null)
			{
				for(i = _Rowfixed; i < fgrid_CmpType.Rows.Count; i++)
				{
					node = (Lassalle.Flow.Node)addflow_CmpType.SelectedItem;

					if(node.Tag.ToString() == fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxCMP_TYPE].ToString())
					{
						fgrid_CmpType.Update_Row(i); 

						RectangleF rc = node.Rect; 
   
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxHEIGHT] = rc.Height.ToString();  
						fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxWIDTH] = rc.Width.ToString();  
       

					}
				} //end for
			}
		}
   
		#endregion

		#region 링크 타입 등록  

		private void cmb_BLFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_BLFactory.SelectedIndex == -1) return;

			Select_LinkProp_List();
			ClassLib.ComFunction.Clear_AddFlow(addflow_LinkProp);
			Select_LinkProp_Node_List();
		}


		private void fgrid_LinkProp_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			switch(fgrid_LinkProp[fgrid_LinkProp.Selection.r1, 0].ToString())
			{
				case "I":
					if(fgrid_LinkProp[fgrid_LinkProp.Selection.r1, (int)ClassLib.TBSPB_LINK_DEF.IxLINK_TYPE].ToString() != "")  
					{
						_AddLink.Tag = fgrid_LinkProp[fgrid_LinkProp.Selection.r1, (int)ClassLib.TBSPB_LINK_DEF.IxLINK_TYPE].ToString(); 
					}
					else
					{
						ClassLib.ComFunction.Data_Message("Code", ClassLib.ComVar.MgsWrongInput, this);
					}
			
					break;
			
				default:
					fgrid_LinkProp.Update_Row(fgrid_LinkProp.Selection.r1);

					break;

			} //end switch 
		}
 
		

		private void addflow_LinkProp_AfterEdit(object sender, Lassalle.Flow.AfterEditEventArgs e)
		{
			int i;
			Lassalle.Flow.Link link = new Lassalle.Flow.Link();

			if(addflow_LinkProp.SelectedItem.Tag != null)
			{
				for(i = _Rowfixed; i < fgrid_LinkProp.Rows.Count; i++)
				{
					link = (Lassalle.Flow.Link)addflow_LinkProp.SelectedItem;

					if(link.Tag.ToString() == fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxLINK_TYPE].ToString())
					{
						fgrid_LinkProp.Update_Row(i);  
   
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxARROW_DST] = link.ArrowDst.Style.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Size.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Filled.ToString(); 
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxARROW_MID] = link.ArrowMid.Style.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Size.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Filled.ToString();
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxARROW_ORG] = link.ArrowOrg.Style.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Size.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Filled.ToString();
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxDASHSTYLE] = link.DashStyle.GetHashCode().ToString(); 
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxDRAWCOLOR] =  link.DrawColor.ToArgb().ToString();
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxDRAWWIDTH] = link.DrawWidth.ToString();
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxFONT] = link.Font.Name + "/"
							+ link.Font.Size + "/"
							+ link.Font.Bold + "/"
							+ (link.Font.Italic ? true : false) + "/"
							+ (link.Font.Strikeout ? true : false) + "/"
							+ (link.Font.Underline ? true : false)  ;
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxJUMP] = link.Jump.GetHashCode().ToString();
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxLINE_STYLE] = link.Line.Style.GetHashCode().ToString();
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxLINE_ROUND] = link.Line.RoundedCorner.ToString();
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxTAG] = link.Tag.ToString();
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxTEXT] = link.Tag.ToString();
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxTEXTCOLOR] = link.TextColor.ToArgb().ToString();
						fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxTOOLTIP] = link.Tooltip.ToString(); 
		 
								
 
       

					}
				} //end for
			} 
		}

		#endregion


		#region 표준 BOM 등록

		private void cmb_SBFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			if(cmb_SBFactory.SelectedIndex == -1) return;

			fgrid_BOM.Rows.Count = _Rowfixed;
			ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);

			//cmb_SBBomCd.SelectedIndex = -1; 
 			//cmb_SBBomCd.ClearItems();

			//default node 속성 리스트 표시
			Select_NodeDef_List();

			//default link 속성 리스트 표시
			Select_LinkDef_List();

			dt_ret = Select_BomCd_CmbList();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SBBomCd, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code); 
		}

		 
		private void cmb_SBBomCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			if(cmb_SBFactory.SelectedIndex == -1 || cmb_SBBomCd.SelectedIndex == -1) return;

			//BOM 코드에 따른 링크 타입 데이터 가져오기
			Select_LinkType();

			//BOM에 대한 노드, 링크 데이터 가지고 있는 숨겨진 그리드 세팅
			//필드명 저장할때 이용하기 위해서 세팅
			fgrid_BomNode.Set_Grid("NODE_BOM", "1", 1, ClassLib.ComVar.This_Lang, true); 
			fgrid_BomLink.Set_Grid("LINK_BOM", "1", 1, ClassLib.ComVar.This_Lang, true); 

			_Rowfixed = fgrid_BomNode.Rows.Fixed;

			ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
			
			dt_ret = Select_StdBom_List(); 
   
			if(dt_ret.Rows.Count > 0)
			{
				Set_Tree(dt_ret); 
				
				Select_StdBom_Node_List();
				Select_StdBom_Link_List();
			}
			else
			{
				fgrid_BOM.Tree.Column = 1; 
				fgrid_BOM.Rows.Count = _Rowfixed;
  
				//데이터 없을때, 초기상태 
				menuItem_LAppend.Enabled = false; 
				menuItem_EInsert.Enabled = false; 
				menuItem_LInsert.Enabled = false; 

			}
 
		}

		
		private void menuItem_NodeProp_Click(object sender, System.EventArgs e)
		{
			Item item;
			Lassalle.DlgFlow.DlgFlow dlgflow = new Lassalle.DlgFlow.DlgFlow();
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();
			int i;

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_CmpType": 
					
					item = addflow_CmpType.PointedItem;

					if (item is Lassalle.Flow.Node)
					{
						node = (Lassalle.Flow.Node)item;
						dlgflow.NodePropertyPage(addflow_CmpType, node);


						///////////////////////////////////////////////////////////////
						if(node.Tag != null)
						{
							for(i = _Rowfixed; i < fgrid_CmpType.Rows.Count; i++)
							{
								if(node.Tag.ToString() == fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxCMP_TYPE].ToString())
								{
									fgrid_CmpType.Update_Row(i); 
 
									RectangleF rc = node.Rect; 
 
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxCMP_TYPE] = node.Tag.ToString();
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxTYPE_NAME] = node.Text.ToString();

									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxALIGNMENT] = node.Alignment.GetHashCode().ToString();
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxDASHSTYLE] = node.DashStyle.GetHashCode().ToString();
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxDRAWCOLOR] = node.DrawColor.ToArgb().ToString(); 
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxDRAWWIDTH] = node.DrawWidth.ToString(); 
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxFILLCOLOR] = node.FillColor.ToArgb().ToString();
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxFONT] = node.Font.Name + "/"
										+ node.Font.Size + "/"
										+ node.Font.Bold + "/"
										+ (node.Font.Italic ? true : false) + "/"
										+ (node.Font.Strikeout ? true : false) + "/"
										+ (node.Font.Underline ? true : false)  ;
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxGRADI_YN] = (node.Gradient ? "Y" : "N");
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxGRADICOLOR] = node.GradientColor.ToArgb().ToString();
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxGRADIMODE] = node.GradientMode.GetHashCode().ToString();
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxHEIGHT] = rc.Height.ToString(); 
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxSHADOW] = node.Shadow.Style.GetHashCode().ToString() + "/"
										+ node.Shadow.Color.ToArgb().ToString() + "/"
										+ node.Shadow.Size.Width.ToString() + "/"
										+ node.Shadow.Size.Height.ToString();
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxSHAPE] = node.Shape.Style.GetHashCode().ToString(); 
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxTAG] = node.Tag.ToString();
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxTEXT] = node.Text.ToString();
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxTEXTCOLOR] = node.TextColor.ToArgb().ToString(); 
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxTOOLTIP] = node.Tooltip.ToString();
									fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxWIDTH] = rc.Width.ToString();  
       

								}// end if
							} //end for
						} //end if(node.Tag != null)
					}// end if(item is Lassalle.Flow.Node)

					break;
 
                     
				case "obarpg_StdBOM":

					item = addflow_BOM.PointedItem;

					if (item is Lassalle.Flow.Node)
					{
						node = (Lassalle.Flow.Node)item;
						dlgflow.NodePropertyPage(addflow_BOM, node);
 

						for(i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
						{
							if(node.Tag.ToString() == fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString())
							{
								fgrid_BOM[i, 0] = (fgrid_BOM[i, 0] == null) ? "" : fgrid_BOM[i, 0].ToString();

								if(fgrid_BOM[i, 0].ToString() == "I") return;

								fgrid_BOM[i, 0] = "U";
							} // end if
						} // end for

					}

					break;
 
					 
 
			} //end switch 
			
		}
 

		private void menuItem_LinkProp_Click(object sender, System.EventArgs e)
		{
			Item item;
			Lassalle.DlgFlow.DlgFlow dlgflow = new Lassalle.DlgFlow.DlgFlow();
			Lassalle.Flow.Link link = new Lassalle.Flow.Link();
			Lassalle.Flow.Node node = new Lassalle.Flow.Node(); 
 
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_LinkProp": 
					
					item = addflow_LinkProp.PointedItem;
					
					if (item is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item;
						dlgflow.LinkPropertyPage(addflow_LinkProp, link);
 
						if(link.Tag != null)
						{
							for(int i = _Rowfixed; i < fgrid_LinkProp.Rows.Count; i++)
							{
								if(link.Tag.ToString() == fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxLINK_TYPE].ToString())
								{
									fgrid_LinkProp.Update_Row(i); 
   
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxARROW_DST] = link.ArrowDst.Style.GetHashCode().ToString() + "/"
										+ link.ArrowDst.Size.GetHashCode().ToString() + "/"
										+ link.ArrowDst.Angle.GetHashCode().ToString() + "/"
										+ link.ArrowDst.Filled.ToString(); 
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxARROW_MID] = link.ArrowMid.Style.GetHashCode().ToString() + "/"
										+ link.ArrowMid.Size.GetHashCode().ToString() + "/"
										+ link.ArrowMid.Angle.GetHashCode().ToString() + "/"
										+ link.ArrowMid.Filled.ToString();
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxARROW_ORG] = link.ArrowOrg.Style.GetHashCode().ToString() + "/"
										+ link.ArrowOrg.Size.GetHashCode().ToString() + "/"
										+ link.ArrowOrg.Angle.GetHashCode().ToString() + "/"
										+ link.ArrowOrg.Filled.ToString();
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxDASHSTYLE] = link.DashStyle.GetHashCode().ToString(); 
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxDRAWCOLOR] =  link.DrawColor.ToArgb().ToString();
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxDRAWWIDTH] = link.DrawWidth.ToString();
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxFONT] = link.Font.Name + "/"
										+ link.Font.Size + "/"
										+ link.Font.Bold + "/"
										+ (link.Font.Italic ? true : false) + "/"
										+ (link.Font.Strikeout ? true : false) + "/"
										+ (link.Font.Underline ? true : false)  ;
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxJUMP] = link.Jump.GetHashCode().ToString();
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxLINE_STYLE] = link.Line.Style.GetHashCode().ToString();
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxLINE_ROUND] = link.Line.RoundedCorner.ToString();
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxTAG] = link.Tag.ToString();
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxTEXT] = link.Tag.ToString();
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxTEXTCOLOR] = link.TextColor.ToArgb().ToString();
									fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxTOOLTIP] = link.Tooltip.ToString(); 
		 
								
								}// end if
							} //end for
						} //end if(node.Tag != null)
					}// end if(item is Lassalle.Flow.Node)

					break;
 
                     
				case "obarpg_StdBOM":

					item = addflow_BOM.PointedItem;

					if (item is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item;
						dlgflow.LinkPropertyPage(addflow_BOM, link);
 
						 
						foreach(Item item1 in addflow_BOM.Items)
						{
							if(item1 is Lassalle.Flow.Node)
							{
								node = (Lassalle.Flow.Node)item1;

								if(link.Org.Index != node.Index && link.Dst.Index != node.Index) continue;

								for(int i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
								{
									//저장 대상 품목 코드와 일치하는 노드
									if((node.Tag).ToString() == fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString())
									{
										fgrid_BOM[i, 0] = (fgrid_BOM[i, 0] == null) ? "" : fgrid_BOM[i, 0].ToString();

										if(fgrid_BOM[i, 0].ToString() == "I") return;

										fgrid_BOM[i, 0] = "U";

										break;
									}
								}

								
							} // end if (node) 
						} // end foreach

 
					} 
					break;
 
					 
 
			} //end switch 
 
		}

	 

		private void menuItem_DeleteItem_Click(object sender, System.EventArgs e)
		{
			int i;
			
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_CmpType": 

					if(addflow_CmpType.SelectedItem.Tag != null)
					{
						for(i = _Rowfixed; i < fgrid_CmpType.Rows.Count; i++)
						{
							if(addflow_CmpType.SelectedItem.Tag.ToString() == fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxCMP_TYPE].ToString())
							{
								fgrid_CmpType.Delete_Row(i); 
							}
						} //end for
					}
				 
					break;

				case "obarpg_LinkProp":
 
					if(addflow_LinkProp.SelectedItem.Tag != null)
					{
						for(i = _Rowfixed; i < fgrid_LinkProp.Rows.Count; i++)
						{
							if(addflow_LinkProp.SelectedItem.Tag.ToString() == fgrid_LinkProp[i, (int)ClassLib.TBSPB_LINK_DEF.IxLINK_TYPE].ToString())
							{
								fgrid_LinkProp.Delete_Row(i); 
							}
						} //end for
					}
					break;

				case "obarpg_StdBOM":

					//					if(addflow_BOM.SelectedItem.Tag != null)
					//					{
					//						for(i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
					//						{
					//							if(addflow_BOM.SelectedItem.Tag.ToString() == fgrid_BOM[i, _SBCmpCd_ix + 1].ToString())
					//							{
					//								fgrid_BOM.Delete_Row(i); 
					//							}
					//						} //end for
					//					}
					break; 
					 




 
			} //end switch
		}



		private void menuItem_Tree_Click(object sender, System.EventArgs e)
		{
			int i;

			//트리형태로 변형, 링크 속성 재설정
			TreeLayout(Lassalle.Flow.Layout.Tree.Orientation.North);  

			for(i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
			{
				fgrid_BOM[i, 0] = (fgrid_BOM[i, 0] == null) ? "" : fgrid_BOM[i, 0].ToString();

				if(fgrid_BOM[i, 0].ToString() == "I") return;

				fgrid_BOM[i, 0] = "U";
			}


//			//BOM 품목 코드 저장
//			Save_StdBom_List();
//
//			//addflow 저장(노드, 링크)
//			Save_StdBom_Node_List();
//			Save_StdBom_Link_List();
//
//			Set_Tree(Select_StdBom_List());

		}
  


		private void menuItem_EAppend_Click(object sender, System.EventArgs e)
		{
			int sel_row = 0;
			int i;
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();

			//초기 데이터
			if(fgrid_BOM.Rows.Count <= _Rowfixed)
			{
				
				menuItem_EInsert.Enabled = true;
				menuItem_LAppend.Enabled = true;
				menuItem_LInsert.Enabled = true;

				sel_row = fgrid_BOM.Rows.Count;

				//{공장, 상위품목코드, 타입, 레벨, 동일레벨내 순번}
				ClassLib.ComVar.Parameter_PopUp = new string[] {"Insert", cmb_SBFactory.SelectedValue.ToString(), "-1", "SG", "1", "1"};
			}
			else
			{
 
				sel_row = fgrid_BOM.Selection.r1;

				ClassLib.ComVar.Parameter_PopUp = new string[] {"Insert", 
																   cmb_SBFactory.SelectedValue.ToString(), 
																   fgrid_BOM[sel_row,(int)ClassLib.TBSPB_BOM.IxUP_CMP_CD].ToString(), 
																   fgrid_BOM[sel_row, (int)ClassLib.TBSPB_BOM.IxCMP_TYPE].ToString(), 
																   fgrid_BOM[sel_row, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString(), ""};

				if(sel_row == fgrid_BOM.Rows.Count - 1)
				{
					sel_row = fgrid_BOM.Rows.Count;
				}
				else
				{
					for(i = sel_row; i < fgrid_BOM.Rows.Count; i++)
					{
//						if(i == fgrid_BOM.Rows.Count - 1)
//						{
//							sel_row = i + 1;
//						}
//						else
//						{
							//레벨이 같은 제일 아래 row 
							if(Convert.ToInt32(fgrid_BOM[sel_row,(int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString()) > Convert.ToInt32(fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString()))
							{
								sel_row = i;
								break;
							} 
//						} //end if
					} // end for

				}// end if
  
			}


			// 추가될 품목코드 그리드에 삽입, 노드, 링크 추가
			Add_CmpCd(sel_row);


		}


		private void menuItem_EInsert_Click(object sender, System.EventArgs e)
		{
			int sel_row = 0; 
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();

			//초기 데이터
			if(fgrid_BOM.Rows.Count <= _Rowfixed)
			{

				menuItem_EInsert.Enabled = true;
				menuItem_LAppend.Enabled = true;
				menuItem_LInsert.Enabled = true;


				sel_row = fgrid_BOM.Rows.Count - 1;

				//{공장, 상위품목코드, 타입, 레벨, 동일레벨내 순번}
				ClassLib.ComVar.Parameter_PopUp = new string[] {"Insert", 
																   cmb_SBFactory.SelectedValue.ToString(), 
                                                                   "-1", 
                                                                   "SG", 
																   "1", 
																   "1"};
			}
			else
			{
 
				sel_row = fgrid_BOM.Selection.r1;

				ClassLib.ComVar.Parameter_PopUp = new string[] {"Insert", 
																   cmb_SBFactory.SelectedValue.ToString(), 
																   fgrid_BOM[sel_row, (int)ClassLib.TBSPB_BOM.IxUP_CMP_CD].ToString(), 
																   fgrid_BOM[sel_row, (int)ClassLib.TBSPB_BOM.IxCMP_TYPE].ToString(), 
																   fgrid_BOM[sel_row, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString(),
																   ""};
           

			}


			// 추가될 품목코드 그리드에 삽입, 노드, 링크 추가
			Add_CmpCd(sel_row); 


		}
  

		private void menuItem_LAppend_Click(object sender, System.EventArgs e)
		{
			int sel_row = 0; 
			int i;
			
 
			sel_row = fgrid_BOM.Selection.r1;

			ClassLib.ComVar.Parameter_PopUp = new string[] {"Insert", 
															   cmb_SBFactory.SelectedValue.ToString(), 
															   fgrid_BOM[sel_row, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString(), 
                                                               "", 
															   Convert.ToString(Convert.ToInt32(fgrid_BOM[sel_row, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString()) + 1), 
                                                               ""};

			if(sel_row + 1 == fgrid_BOM.Rows.Count)
			{
				sel_row = fgrid_BOM.Rows.Count;
			}
			else
			{
				for(i = sel_row + 1; i < fgrid_BOM.Rows.Count; i++)
				{
					//레벨 + 1 이 같은 제일 아래 row 
					if(Convert.ToInt32(ClassLib.ComVar.Parameter_PopUp[4]) > Convert.ToInt32(fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString()))
					{
						sel_row = i;
						break;
					} 
				} // end for
			}
               

			// 추가될 품목코드 그리드에 삽입, 노드, 링크 추가
			Add_CmpCd(sel_row);
 
		}

		
		private void menuItem_LInsert_Click(object sender, System.EventArgs e)
		{
			int sel_row = 0; 
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();
			 
			sel_row = fgrid_BOM.Selection.r1;

			ClassLib.ComVar.Parameter_PopUp = new string[] {"Insert", 
															   cmb_SBFactory.SelectedValue.ToString(), 
															   fgrid_BOM[sel_row, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString(), 
															   "", 
															   Convert.ToString(Convert.ToInt32(fgrid_BOM[sel_row, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString()) + 1), 
															   ""};

 


			// 추가될 품목코드 그리드에 삽입, 노드, 링크 추가
			Add_CmpCd(sel_row); 
		}
 

		private void menuItem_Update_Click(object sender, System.EventArgs e)
		{
//			int i;
//			int sel_row = fgrid_BOM.Selection.r1;
//
//			ClassLib.ComVar.Parameter_PopUp = new string[fgrid_BOM.Cols.Count + 2];
//
//			ClassLib.ComVar.Parameter_PopUp[0] = "Update";
//			ClassLib.ComVar.Parameter_PopUp[1] = cmb_SBFactory.SelectedValue.ToString();
//
//			for(i = 1; i < fgrid_BOM.Cols.Count; i++)
//			{
//				ClassLib.ComVar.Parameter_PopUp[i + 1] = fgrid_BOM[sel_row, i].ToString();
//			}
//
//			ProdBase.Pop_SetCmpInfo pop_form = new ProdBase.Pop_SetCmpInfo();
//
//			pop_form.ShowDialog();
//
//			/////////////////////////////////////////////////////////////////////////
//			//{폼 닫힐때 이벤트(확인, 취소), 타입, 코드, 상위코드, 코드명, 레벨, 순서, 동일순서레벨, 기간, 비고} 
//
//			if(ClassLib.ComVar.Parameter_PopUp[0] == "Cancel") return;
// 
//			if(fgrid_BOM[sel_row, 0].ToString() != "I") fgrid_BOM[sel_row, 0] = "U"; 
//
//			for(i = 1; i < fgrid_BOM.Cols.Count; i++)
//			{
//				fgrid_BOM[sel_row, i] = ClassLib.ComVar.Parameter_PopUp[i];
//			}
//
//			fgrid_BOM.AutoSizeCols(); 

		}


		private void menuItem_Delete_Click(object sender, System.EventArgs e)
		{
			//품목코드 삭제, 노드삭제, 링크삭제
		
			int sel_row = fgrid_BOM.Selection.r1;
			int del_to_row = 0; 

			Lassalle.Flow.Node node = new Lassalle.Flow.Node(); 
			Lassalle.Flow.Link link = new Lassalle.Flow.Link();
			Lassalle.Flow.Node current_node = null;  // = new Lassalle.Flow.Node(); 
			Lassalle.Flow.Link current_link = null;  //new Lassalle.Flow.Link();
 

			for(int i = sel_row + 1; i < fgrid_BOM.Rows.Count ; i++)
			{
				if (Convert.ToInt32(fgrid_BOM[sel_row, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString()) 
					>= Convert.ToInt32(fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString()))
				{
					del_to_row = i - 1;
					break;
				}
			}

			del_to_row = (del_to_row == 0) ? fgrid_BOM.Rows.Count - 1 : del_to_row;
 
 
		
			for(int i = del_to_row; i >= sel_row; i--)
			{
				foreach(Item item in addflow_BOM.Items)
				{
					if(item is Lassalle.Flow.Node)
					{
						node = (Lassalle.Flow.Node)item;

						if((node.Tag).ToString() == fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString())
						{
							current_node = node;
							
						}
					}// end if(node) 

					if(item is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item;

						if((link.Dst.Tag).ToString() == fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString())
						{
							current_link = link;
							
						}
					}// end if(link)

				}// end foreach
 
					
				//delete link, node
				if(current_link != null) addflow_BOM.Nodes[current_node.Index].Links.Remove(current_link);
				if(current_node != null) addflow_BOM.Nodes.Remove(current_node); 

				//delete fgrid_BOM
				if(fgrid_BOM[sel_row, 0].ToString() != "I")  
					fgrid_BOM.Delete_Row(i); 
				else
					fgrid_BOM.Rows.Remove(i);


				current_link = null;
				current_node = null;

			}// end for
 
		}
   




		private void addflow_BOM_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int i; 
			Item item = addflow_BOM.PointedItem;
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();

			if (item is Lassalle.Flow.Node)
			{
				node = (Lassalle.Flow.Node)item;

				for(i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
				{
					if(node.Tag.ToString() == fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString())
					{
						fgrid_BOM.Select(i, 0, i, fgrid_BOM.Cols.Count - 1, false);
					} // end if
				} // end for

			}
 

		}


		private void addflow_BOM_AfterResize(object sender, System.EventArgs e)
		{
			 
			for(int i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
			{
				if(addflow_BOM.SelectedItem.Tag.ToString() == fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString())
				{
					fgrid_BOM[i, 0] = (fgrid_BOM[i, 0] == null) ? "" : fgrid_BOM[i, 0].ToString();

					if(fgrid_BOM[i, 0].ToString() == "I") return;

					fgrid_BOM[i, 0] = "U";
				}
			}


		}


		private void addflow_BOM_AfterMove(object sender, System.EventArgs e)
		{ 
			for(int i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
			{
				if(addflow_BOM.SelectedItem.Tag.ToString() == fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString())
				{
					fgrid_BOM[i, 0] = (fgrid_BOM[i, 0] == null) ? "" : fgrid_BOM[i, 0].ToString();

					if(fgrid_BOM[i, 0].ToString() == "I") return;

					fgrid_BOM[i, 0] = "U";
				}
			}
		}



        private int index = 0;

		private void addflow_BOM_AfterAddLink(object sender, Lassalle.Flow.AfterAddLinkEventArgs e)
		{
			e.Link.Tag = index;
			index++; 
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

		private void btn_Copy_Click(object sender, System.EventArgs e)
		{
			string factory, bom_cd;

			try
			{
				if(cmb_SBFactory.SelectedIndex == -1 || cmb_SBBomCd.SelectedIndex == -1) return;

				factory = cmb_SBFactory.SelectedValue.ToString();
				bom_cd = cmb_SBBomCd.SelectedValue.ToString(); 

				Pop_CreateCopyBom pop_form = new Pop_CreateCopyBom();

				//공장, BOM 코드
				ClassLib.ComVar.Parameter_PopUp = new string[] {factory, bom_cd};

				pop_form.ShowDialog();

				//노드, 링크 인덱스 정리
				tbtn_Search_Click(null, null);
				
				//addflow 저장(노드, 링크)
				Save_StdBom_Node_List();
				Save_StdBom_Link_List();  

			}
			catch
			{
			}

		}
 

		
		//public ProdBase.Form_PB_BOMRout Form_Rout;

		
		private void menuItem_SetRout_Click(object sender, System.EventArgs e)
		{
			//			try
			//			{
			//				ClassLib.ComFunction comfunc = new FlexAPS.ClassLib.ComFunction();
			//				Form_Rout = comfunc.Show_Rout();
			//
			//				string factory = cmb_SBFactory.SelectedValue.ToString();
			//				string bom_cd = cmb_SBBomCd.SelectedValue.ToString();
			//				string cmp_cd = addflow_BOM.SelectedItem.Tag.ToString();
			//			    string rout_type = "";
			//				Lassalle.Flow.Node node = new Lassalle.Flow.Node();
			// 
			//				ClassLib.ComVar.FormClick_Flag = true;
			//
			//				int findrow = fgrid_BOM.FindRow(cmp_cd, fgrid_BOM.Rows.Fixed, (int)ClassLib.TBSPB_BOM.IxCMP_CD, false, true, false);
			//				if(findrow == -1) return;
			//
			//				
			//				if(fgrid_BOM[findrow, (int)ClassLib.TBSPB_BOM.IxROUT_YN].ToString() == "Y")
			//				{ 
			//					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
			//					return;
			//				}
			//				else
			//				{ 
			//					ProdBase.Form_PB_Rout pop_form = new ProdBase.Form_PB_Rout(); 
			//					ClassLib.ComVar.Parameter_PopUp = new string[] {factory, bom_cd, cmp_cd, rout_type}; 
			//					pop_form.ShowDialog();
			//
			//					fgrid_BOM[findrow, (int)ClassLib.TBSPB_BOM.IxROUT_YN] = "Y";
			//					ClassLib.ComVar.FormClick_Flag = false;
			//
			//
			////					node = (Lassalle.Flow.Node)addflow_BOM.SelectedItem;
			////
			////					node.FillColor = Color.Pink;
			////					node.Tag = "x"; 
			//
			//					//공정 표시 창 다시 search
			//					Form_Rout.Search_Bom_Rout_List();
			//
			//				}
			//			}
			//			catch
			//			{
			//			}
		}



		private void menuItem_ViewRout_Click(object sender, System.EventArgs e)
		{
			try
			{
				Form_PB_BOMRout pop_form = new Form_PB_BOMRout(); 
   
				ClassLib.ComVar.MenuClick_Flag = true;  

				pop_form.WindowState = System.Windows.Forms.FormWindowState.Normal;
				pop_form.Show();

				pop_form.Set_Factory(cmb_SBFactory.SelectedValue.ToString());
				pop_form.Set_BomCd(cmb_SBBomCd.SelectedValue.ToString());
				pop_form.Set_RoutType(ClassLib.ComVar.Rout_Type);
				
			}
			catch
			{
			}

		}


		#endregion



		#endregion 
		 
		#region DB Connect
 

		#region BOM Code

		/// <summary>
		/// Select_SPB_BOM_CD : BOM 코드 리스트 찾기
		/// </summary>
		private DataTable Select_SPB_BOM_CD()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SXB_P_BOM.SELECT_SXB_BOM_CD";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_BCFactory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 

			}
			catch
			{ 
				return null; 
			} 
		}



		/// <summary>
		/// Select_LinkType_CmbList : 링크 타입 콤보 리스트 조회
		/// </summary>
		/// <returns></returns>
		private  DataTable Select_LinkType_CmbList()
		{
			DataSet ds_ret; 

			try
			{
                string process_name = "PKG_SXB_PJ_BOM.SELECT_LINKTYPE_CMBLIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_BCFactory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 

			}
			catch
			{ 
				return null; 
			} 
 
		}



		/// <summary>
		/// Create_BomCd : BOM 코드 중복 체크, 코드 생성
		/// </summary>
		private string Create_BomCd(string arg_compare)
		{
			DataSet ds_ret; 

			try
			{
                string process_name = "PKG_SXB_P_BOM.CREATE_BOM_CD";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_COMPARE"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_BCFactory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = arg_compare; 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString(); 
 
			}
			catch
			{ 
				return null; 
			}  
		}
 
		/// <summary>
		/// Save_BomCd : BOM 코드 저장
		/// </summary>
		private void Save_BomCd(string arg_division)
		{
			DataSet ds_ret;
   
			try
			{
				int col_ct = 13;

				MyOraDB.ReDim_Parameter(col_ct);

                MyOraDB.Process_Name = "PKG_SXB_P_BOM.SAVE_SXB_P_BOM_CD";

				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				for(int i = 1; i < col_ct; i++) MyOraDB.Parameter_Name[i] = "ARG_" + fgrid_BomCd[0, i].ToString();  
 
				for(int i = 0; i < col_ct ; i++) MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  
			    
				MyOraDB.Parameter_Values[0] = arg_division;  
				MyOraDB.Parameter_Values[1] = cmb_BCFactory.SelectedValue.ToString();   
				MyOraDB.Parameter_Values[2] = txt_BCDCode.Text; 
				MyOraDB.Parameter_Values[3] = txt_BCDDesc.Text;   
				MyOraDB.Parameter_Values[4] = cmb_BCDJobCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[5] = txt_BCDModel.Text;   
				MyOraDB.Parameter_Values[6] = txt_BCDStyle.Text; 
				MyOraDB.Parameter_Values[7] = txt_BCDLine.Text;   
				MyOraDB.Parameter_Values[8] = ClassLib.ComVar.BOMLinkType;   //cmb_BCDLinkType.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[9] = (chk_BCDDefault.Checked) ? "Y" : "N";   
				MyOraDB.Parameter_Values[10] = txt_BCDOrder.Text; 
				MyOraDB.Parameter_Values[11] = txt_BCDRemarks.Text;    
				MyOraDB.Parameter_Values[12] = ClassLib.ComVar.This_User;  


				MyOraDB.Add_Modify_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행		

			
				//Error 처리
				if(ds_ret == null) 
				{
					MessageBox.Show("Error") ;
				
				}
			}
			catch
			{
			}
		 
		}

 

		#endregion 


		#region BOM CMP Type

		/// <summary>
		/// Select_BomCmpType_List : BOM CMP 타입 리스트 찾기
		/// </summary>
		private void Select_BomCmpType_List()
		{ 
			DataSet ds_ret; 
			DataTable dt_ret;

			try
			{
                string process_name = "PKG_SXB_PJ_BOM.SELECT_CMPTYPE_LIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_BCFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//--------------------------------------------------------------------------------
				fgrid_CmpType.Rows.Count = _Rowfixed;
				fgrid_CmpType.Cols.Count = dt_ret.Columns.Count + 1;
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_CmpType.AddItem(dt_ret.Rows[i].ItemArray, fgrid_CmpType.Rows.Count, 1);
					fgrid_CmpType[fgrid_CmpType.Rows.Count - 1, 0] = "";
				} 

				fgrid_CmpType.AutoSizeCols(); 
				//--------------------------------------------------------------------------------
 
			}
			catch
			{  
			}  


		}


		/// <summary>
		/// Select_OpType_Node_List : Node List Select
		/// </summary>
		private void Select_BomCmpType_Node_List()
		{
			int i;
			int top_point = 50;

			Lassalle.Flow.Node node; 

			 
			for(i = _Rowfixed; i < fgrid_CmpType.Rows.Count ; i++)
			{

				node = new Lassalle.Flow.Node();

				node = addflow_CmpType.Nodes.Add(100, top_point,  
					Convert.ToSingle(fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxWIDTH].ToString()), 
					Convert.ToSingle(fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxHEIGHT].ToString()), "");

				node.Text =  fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxTYPE_NAME].ToString(); 
				node.Tooltip = node.Text;
				node.Tag = fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxCMP_TYPE].ToString(); 
 
				ClassLib.ComFunction.Set_NodeProp(fgrid_CmpType, node, i); 

				top_point = top_point + Convert.ToInt32(fgrid_CmpType[i, (int)ClassLib.TBSPB_NODE_DEF.IxHEIGHT].ToString()) + 10;

			} //end for  

		}


  

		#endregion


		#region LINK Type

		/// <summary>
		/// Select_LinkProp_List : Default Link Property 찾기
		/// </summary>
		private void Select_LinkProp_List()
		{ 
			DataSet ds_ret; 
			DataTable dt_ret;

			try
			{
                string process_name = "PKG_SXB_PJ_BOM.SELECT_LINKPROP_LIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_BCFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//--------------------------------------------------------------------------------
				fgrid_LinkProp.Rows.Count = _Rowfixed;  
				fgrid_LinkProp.Cols.Count = dt_ret.Columns.Count + 1;
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_LinkProp.AddItem(dt_ret.Rows[i].ItemArray, fgrid_LinkProp.Rows.Count, 1);
					fgrid_LinkProp[fgrid_LinkProp.Rows.Count - 1, 0] = "";
				} 

				fgrid_LinkProp.AutoSizeCols(); 
				//--------------------------------------------------------------------------------
 
			}
			catch
			{  
			}  

		}






		#endregion


		#region BOM

		
		/// <summary>
		/// Select_NodeDef_List : 타입에 따른 default 노드 속성 그리드에 표시
		/// </summary>
		private void Select_NodeDef_List()
		{
		 
			DataSet ds_ret; 
			DataTable dt_ret;

			try
			{
                string process_name = "PKG_SXB_PJ_BOM.SELECT_CMPTYPE_LIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_SBFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//--------------------------------------------------------------------------------
				fgrid_NodeDef.Rows.Count = _Rowfixed;  
				fgrid_NodeDef.Cols.Count = dt_ret.Columns.Count + 1;
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_NodeDef.AddItem(dt_ret.Rows[i].ItemArray, fgrid_NodeDef.Rows.Count, 1); 
				} 
				//--------------------------------------------------------------------------------
 
			}
			catch
			{  
			}  


		}



		/// <summary>
		/// Select_LinkDef_List : 타입에 따른 default 링크 속성 그리드에 표시
		/// </summary>
		private void Select_LinkDef_List()
		{ 
			DataSet ds_ret; 
			DataTable dt_ret;

			try
			{
                string process_name = "PKG_SXB_PJ_BOM.SELECT_LINKPROP_LIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_SBFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//--------------------------------------------------------------------------------
				fgrid_LinkDef.Rows.Count = _Rowfixed;  
				fgrid_LinkDef.Cols.Count = dt_ret.Columns.Count + 1;
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_LinkDef.AddItem(dt_ret.Rows[i].ItemArray, fgrid_LinkDef.Rows.Count, 1); 
				}  
				//--------------------------------------------------------------------------------
 
			}
			catch
			{  
			}  



		}


	
		/// <summary>
		/// Select_BomCd_CmbList : BOM Code Combo List 찾기
		/// </summary>
		private DataTable Select_BomCd_CmbList()
		{ 

			DataSet ds_ret;  

			try
			{
                string process_name = "PKG_SXB_P_BOM.SELECT_SXB_BOM_CD";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_SBFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 
 
			}
			catch
			{  
				return null; 
			}  



		}



		/// <summary>
		/// Select_LinkType : BOM 코드에 따른 링크 타입 데이터 가져오기 
		/// </summary>
		/// <returns></returns>
		private void Select_LinkType()
		{ 
			DataSet ds_ret; 
			DataTable dt_ret;

			try
			{
                string process_name = "PKG_SXB_P_BOM.SELECT_BOMCD_LINKLIST";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_SBFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_SBBomCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//--------------------------------------------------------------------------------
				fgrid_LinkDef.Rows.Count = _Rowfixed; 
				fgrid_LinkDef.Cols.Count = dt_ret.Columns.Count + 1;
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_LinkDef.AddItem(dt_ret.Rows[i].ItemArray, fgrid_LinkDef.Rows.Count, 1); 
				} 
				//--------------------------------------------------------------------------------
 
			}
			catch
			{  
			}  


		}


		/// <summary>
		/// Select_StdBom_List : 표준 BOM 리스트 찾기
		/// </summary>
		private DataTable Select_StdBom_List()
		{ 

			DataSet ds_ret;  

			try
			{
                string process_name = "PKG_SXB_P_BOM.SELECT_STDBOM_LIST";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_SBFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_SBBomCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 
 
			}
			catch
			{  
				return null; 
			}  

		}



		/// <summary>
		/// Select_StdBom_Node_List : Standard BOM Node 리스트 찾기  
		/// </summary>
		private void Select_StdBom_Node_List()
		{
		  
			DataSet ds_ret; 
			DataTable dt_ret;
			Lassalle.Flow.Node node;

			try
			{
                string process_name = "PKG_SXB_P_BOM.SELECT_STDBOM_NODELIST";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_SBFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_SBBomCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//-------------------------------------------------------------------------------- 
				fgrid_BomNode.Rows.Count = _Rowfixed;
				fgrid_BomNode.Cols.Count = dt_ret.Columns.Count + 1;
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_BomNode.AddItem(dt_ret.Rows[i].ItemArray, fgrid_BomNode.Rows.Count, 1); 
				}



                for (int i = _Rowfixed; i < fgrid_BomNode.Rows.Count; i++)
                {
                    node = new Lassalle.Flow.Node();

                    node = addflow_BOM.Nodes.Add(Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxLEFT].ToString()),
                        Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTOP].ToString()),
                        Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxWIDTH].ToString()),
                        Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxHEIGHT].ToString()), "");

                    //node.Text = fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTEXT].ToString();
                    node.Text = fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTAG].ToString();

                    node.Tooltip = node.Text;
                    node.Tag = fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTAG].ToString();

                    ClassLib.ComFunction.Set_NodeProp(fgrid_BomNode, node, i);



                } //end for 
				//--------------------------------------------------------------------------------
 
			}
			catch(Exception ex)
			{
                MessageBox.Show(ex.ToString());
			}  

		}



		/// <summary>
		/// Select_StdBom_Link_List : Standard BOM Link 리스트 찾기 
		/// </summary>
		private void Select_StdBom_Link_List()
		{ 

			DataSet ds_ret; 
			DataTable dt_ret; 
			Lassalle.Flow.Link link; 
			int org_node, dst_node;
			int max_index = _Link_Index;

			try
			{
                string process_name = "PKG_SXB_P_BOM.SELECT_STDBOM_LINKLIST";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_SBFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_SBBomCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//-------------------------------------------------------------------------------- 
				fgrid_BomLink.Rows.Count = _Rowfixed; 
				fgrid_BomLink.Cols.Count = dt_ret.Columns.Count + 1; 
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_BomLink.AddItem(dt_ret.Rows[i].ItemArray, fgrid_BomLink.Rows.Count, 1); 
				} 


				////////////////////////////////////////////////////////////////
                for (int i = _Rowfixed; i < fgrid_BomLink.Rows.Count; i++)
                {
                    link = new Lassalle.Flow.Link();

                    org_node = ClassLib.ComFunction.Get_Index(fgrid_BomNode, fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxORG_NODE].ToString(), (int)ClassLib.TBSPB_NODE_BOM.IxNODE_CD, _Rowfixed);
                    dst_node = ClassLib.ComFunction.Get_Index(fgrid_BomNode, fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxDST_NODE].ToString(), (int)ClassLib.TBSPB_NODE_BOM.IxNODE_CD, _Rowfixed);


                    link = addflow_BOM.Nodes[org_node].OutLinks.Add(addflow_BOM.Nodes[dst_node]);

                    link.Tag = fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxTAG].ToString();

                    ClassLib.ComFunction.Set_LinkProp(fgrid_BomLink, link, i);

                    if (max_index <= Convert.ToInt32(link.Tag)) max_index = Convert.ToInt32(link.Tag);


                } // end for

				_Link_Index = max_index + 1;
				//--------------------------------------------------------------------------------
 
			}
			catch
			{  
			}  

		}

 

		/// <summary>
		/// Save_StdBom_List : BOM 품목코드 리스트 저장
		/// </summary>
		private bool Save_StdBom_List()
		{
			 
			int col_ct = 13;		 
			int save_ct =0 ;		 
			int para_ct =0;								   

			try
			{

				MyOraDB.ReDim_Parameter(col_ct);

                MyOraDB.Process_Name = "PKG_SXB_P_BOM.SAVE_STDBOM_LIST";
 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_BOM_CD";

				for(int i = 1; i < fgrid_BOM.Cols.Count; i++)
				{
					if(i == (int)ClassLib.TBSPB_BOM.IxROUT_YN) continue;
					MyOraDB.Parameter_Name[i + 2] = "ARG_" + fgrid_BOM[0, i].ToString(); 
				}
 
				MyOraDB.Parameter_Name[col_ct - 1] = "ARG_UPD_USER";

				/////////////////////////////////////////////////////////////////////////
				for(int i = 0; i < col_ct; i++) MyOraDB.Parameter_Type[i] = 1;  
			  

				/////////////////////////////////////////////////////////////////////////
				for(int i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
				{
					if(fgrid_BOM[i, 0].ToString() != "") save_ct += 1; 
				} 

				MyOraDB.Parameter_Values = new string[col_ct * save_ct + 1];

	
				for(int i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
				{
					if(fgrid_BOM[i, 0].ToString() != "")
					{ 

						MyOraDB.Parameter_Values[para_ct] = fgrid_BOM[i, 0].ToString();
						MyOraDB.Parameter_Values[para_ct + 1] = cmb_SBFactory.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct + 2] = cmb_SBBomCd.SelectedValue.ToString();

						para_ct += 3;
          
						for(int j = 1; j < fgrid_BOM.Cols.Count; j++)
						{ 
							if(j == (int)ClassLib.TBSPB_BOM.IxROUT_YN) continue;

							MyOraDB.Parameter_Values[para_ct] = (fgrid_BOM[i, j] == null) ? "" : fgrid_BOM[i, j].ToString();
							para_ct++;
						} 
						MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User;  
						para_ct++;  
					}

				}
  
				MyOraDB.Add_Modify_Parameter(false); 
				return true;
		  
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_StdBom_List",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}



		/// <summary>
		/// Save_StdBom_Node_List : 노드 리스트 저장
		/// </summary>
		private bool Save_StdBom_Node_List()
		{
			int col_ct = 25;		 
			int save_ct =0 ;							// 저장 행 수
 
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 

			Lassalle.Flow.Node node;


			try
			{
			 
				MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_SXB_P_BOM.SAVE_STDBOM_NODE_LIST"; 
				 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_BOM_CD"; 
				for(int i = (int)ClassLib.TBSPB_NODE_BOM.IxCMP_CD; i <= (int)ClassLib.TBSPB_NODE_BOM.IxWIDTH; i++) 
				{
					MyOraDB.Parameter_Name[i + 2] = "ARG_" + fgrid_BomNode[0, i].ToString(); 
				}
				MyOraDB.Parameter_Name[24] = "ARG_UPD_USER";
  
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}

				foreach(Item item in addflow_BOM.Items)
				{
					if(item is Lassalle.Flow.Node) save_ct++; 
				}
 
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[col_ct * (save_ct + 1)];
 

				// 각 행의 변경값 Setting
 
				//전부 삭제 후 다시 Insert 작업
				MyOraDB.Parameter_Values[para_ct + 0] = "D";
				MyOraDB.Parameter_Values[para_ct + 1] = cmb_SBFactory.SelectedValue.ToString();  
				MyOraDB.Parameter_Values[para_ct + 2] = cmb_SBBomCd.SelectedValue.ToString();

				for(int i = 3; i <= 24; i++)
					MyOraDB.Parameter_Values[para_ct + i] = "";
 
				para_ct += col_ct; 



				foreach(Item item in addflow_BOM.Items)
				{
					if(item is Lassalle.Flow.Node)
					{
						node = (Lassalle.Flow.Node)item;

						index = node.Index;
						RectangleF rc = node.Rect; 

						MyOraDB.Parameter_Values[para_ct + 0] = "I";
						MyOraDB.Parameter_Values[para_ct + 1] = cmb_SBFactory.SelectedValue.ToString();  
						MyOraDB.Parameter_Values[para_ct + 2] = cmb_SBBomCd.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct + 3] = node.Tag.ToString();
						MyOraDB.Parameter_Values[para_ct + 4] = cmb_SBFactory.SelectedValue.ToString() + cmb_SBBomCd.SelectedValue.ToString() + string.Format("{0:0000}", index);
						MyOraDB.Parameter_Values[para_ct + 5] = rc.Left.ToString();
						MyOraDB.Parameter_Values[para_ct + 6] = rc.Top.ToString();
						MyOraDB.Parameter_Values[para_ct + 7] = node.Alignment.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 8] = node.DashStyle.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 9] = node.DrawColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 10] = node.DrawWidth.ToString();
						MyOraDB.Parameter_Values[para_ct + 11] = node.FillColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 12] = node.Font.Name + "/"
							+ node.Font.Size + "/"
							+ node.Font.Bold + "/"
							+ (node.Font.Italic ? true : false) + "/"
							+ (node.Font.Strikeout ? true : false) + "/"
							+ (node.Font.Underline ? true : false); 
						MyOraDB.Parameter_Values[para_ct + 13] = (node.Gradient ? "Y" : "N");
						MyOraDB.Parameter_Values[para_ct + 14] = node.GradientColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 15] = node.GradientMode.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 16] = rc.Height.ToString();
						MyOraDB.Parameter_Values[para_ct + 17] = node.Shadow.Style.GetHashCode().ToString() + "/"
							+ node.Shadow.Color.ToArgb().ToString() + "/"
							+ node.Shadow.Size.Width.ToString() + "/"
							+ node.Shadow.Size.Height.ToString();
						MyOraDB.Parameter_Values[para_ct + 18] = node.Shape.Style.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 19] = node.Tag.ToString();
						MyOraDB.Parameter_Values[para_ct + 20] = node.Text.ToString();
						MyOraDB.Parameter_Values[para_ct + 21] = node.TextColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 22] = node.Tooltip.ToString();
						MyOraDB.Parameter_Values[para_ct + 23] = rc.Width.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 24] = ClassLib.ComVar.This_User;
	
						para_ct += col_ct;  
							
					} 


				}//end foreach 
						 
 

				MyOraDB.Add_Modify_Parameter(true);	  
				return true;
		 
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_StdBOM_Node_List",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}
 


		/// <summary>
		/// Save_StdBom_Link_List : 링크 리스트 저장
		/// </summary>
		private bool Save_StdBom_Link_List()
		{
			int col_ct = 22;		 
			int save_ct =0 ;							// 저장 행 수
 
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 
 
			int index = 0;
 
			Lassalle.Flow.Link link;
  
			try
			{
			 
				MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_SXB_P_BOM.SAVE_STDBOM_LINK_LIST"; 
				 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[3] = "ARG_LINK_SEQ"; 
				MyOraDB.Parameter_Name[4] = "ARG_ORG_NODE"; 
				MyOraDB.Parameter_Name[5] = "ARG_DST_NODE"; 
				MyOraDB.Parameter_Name[6] = "ARG_POINT";  

				for(int i = (int)ClassLib.TBSPB_LINK_BOM.IxARROW_DST; i <= (int)ClassLib.TBSPB_LINK_BOM.IxTOOLTIP; i++) 
				{
					MyOraDB.Parameter_Name[i + 4] = "ARG_" + fgrid_BomLink[0, i].ToString(); 
				}
				MyOraDB.Parameter_Name[21] = "ARG_UPD_USER";
  
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
				 
				// 저장 행 수 구하기 
				foreach(Item item in addflow_BOM.Items)
				{
					if(item is Lassalle.Flow.Link) save_ct++;
				} // end foreach 
					 
				  
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[col_ct * (save_ct + 1)];
 
				
				// 각 행의 변경값 Setting 
				//전부 삭제 후 다시 Insert 작업
				MyOraDB.Parameter_Values[para_ct + 0] = "D";
				MyOraDB.Parameter_Values[para_ct + 1] = cmb_SBFactory.SelectedValue.ToString();  
				MyOraDB.Parameter_Values[para_ct + 2] = cmb_SBBomCd.SelectedValue.ToString();

				for(int i = 3; i <= 21; i++)
					MyOraDB.Parameter_Values[para_ct + i] = "";
 
				para_ct += col_ct; 


				foreach(Item item in addflow_BOM.Items)
				{
					if(item is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item;
						// 
						//						index = Convert.ToInt32(link.Tag.ToString()); 

						MyOraDB.Parameter_Values[para_ct + 0] = "I";
						MyOraDB.Parameter_Values[para_ct + 1] = cmb_SBFactory.SelectedValue.ToString();  
						MyOraDB.Parameter_Values[para_ct + 2] = cmb_SBBomCd.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct + 3] = string.Format("{0:000000}", index);
						MyOraDB.Parameter_Values[para_ct + 4] = link.Org.Index.ToString();
						MyOraDB.Parameter_Values[para_ct + 5] = link.Dst.Index.ToString();
						MyOraDB.Parameter_Values[para_ct + 6] = "";  //point
						MyOraDB.Parameter_Values[para_ct + 7] = link.ArrowDst.Style.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Size.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 8] = link.ArrowMid.Style.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Size.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 9] = link.ArrowOrg.Style.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Size.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 10] = link.DashStyle.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 11] = link.DrawColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 12] = link.DrawWidth.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 13] = link.Font.Name + "/"
							+ link.Font.Size + "/"
							+ link.Font.Bold + "/"
							+ (link.Font.Italic ? true : false) + "/"
							+ (link.Font.Strikeout ? true : false) + "/"
							+ (link.Font.Underline ? true : false) ;
						MyOraDB.Parameter_Values[para_ct + 14] = link.Jump.GetHashCode().ToString(); 
						MyOraDB.Parameter_Values[para_ct + 15] = link.Line.Style.GetHashCode().ToString(); 
						MyOraDB.Parameter_Values[para_ct + 16] = link.Line.RoundedCorner.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 17] = link.Tag.ToString();
						MyOraDB.Parameter_Values[para_ct + 18] = "";     //link.Text.ToString();
						MyOraDB.Parameter_Values[para_ct + 19] = "";     //link.TextColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 20] = "";     //link.Tooltip.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 21] = ClassLib.ComVar.This_User;  
						
						para_ct += col_ct;  
						index++;

					} // end if (link) 
				} // end foreach
  

				MyOraDB.Add_Modify_Parameter(false); 
				return true;
		 
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_StdBom_Link_List",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}

  
		#endregion


		

		

		#endregion 

		#region addflow 프린트, 저장 관련

		private Lassalle.PrnFlow.PrnFlow prnflow = new Lassalle.PrnFlow.PrnFlow();

		private void menuItem_Print_Click(object sender, System.EventArgs e)
		{
			//prnflow.Print(addflow_BOM);

			prnflow.Preview(addflow_BOM);
		}

		private void menuItem_Save_Click(object sender, System.EventArgs e)
		{
			 
		}

		#endregion


		private void Form_PB_BOM_Load(object sender, System.EventArgs e)
		{
			Init_Form();	
			
		}



	


	} 
}

