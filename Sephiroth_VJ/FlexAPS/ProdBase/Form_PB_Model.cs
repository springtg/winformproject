using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using Lassalle.Flow;

namespace FlexAPS.ProdBase
{
	public class Form_PB_Model : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리 

		private C1.Win.C1Command.C1OutBar obar_Main;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1OutPage obarpg_ModelMold;
		private C1.Win.C1Command.C1OutPage obarpg_ModelLine;
		private System.Windows.Forms.Panel pnl_MBody;
		private C1.Win.C1Command.C1OutPage obarpg_Model;
		public System.Windows.Forms.PictureBox pictureBox24;
		private System.Windows.Forms.Panel pnl_MBodyRightTop;
		public System.Windows.Forms.Panel pnl_SearchSplitRight;
		public System.Windows.Forms.Panel pnl_SearchRightImage;
		public C1.Win.C1List.C1Combo cmb_MDYear;
		private System.Windows.Forms.Label lbl_MDYear;
		public C1.Win.C1List.C1Combo cmb_MFactory;
		private System.Windows.Forms.Label lbl_MFactory;
		public System.Windows.Forms.PictureBox picb_RBR;
		public System.Windows.Forms.PictureBox picb_RMR;
		public System.Windows.Forms.PictureBox picb_RBM;
		public System.Windows.Forms.PictureBox picb_RTR;
		public System.Windows.Forms.PictureBox picb_RTM;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.PictureBox picb_RMM;
		public System.Windows.Forms.PictureBox picb_RBL;
		public System.Windows.Forms.PictureBox picb_RML;  
		private C1.Win.C1List.C1Combo c1Combo1;
		private System.Windows.Forms.Panel pnl_MLBody;
		private System.Windows.Forms.Panel pnl_MLLeft;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel pnl_MLLeftBottom;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel pnl_MLLeftBody;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.Label lbl_SubTitle3;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Panel pnl_MLLeftBodySearch;
		private System.Windows.Forms.Panel pnl_MLLeftBottomSearch;
		private System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_MLMYear;
		private System.Windows.Forms.Label lbl_MLMYear;
		private C1.Win.C1List.C1Combo cmb_MLMFactory;
		private System.Windows.Forms.Label lbl_MLMFactory;
		public System.Windows.Forms.Label lbl_SubTitle4;
		public COM.FSP fgrid_MLModel;
		public COM.FSP fgrid_MLLine;
		public COM.FSP fgrid_ModelLine;
		private C1.Win.C1List.C1Combo cmb_MLLFactory;
		private System.Windows.Forms.Label lbl_MLLFactory; 
		public System.Windows.Forms.PictureBox pictureBox58;
		public System.Windows.Forms.PictureBox pictureBox59;
		public System.Windows.Forms.PictureBox pictureBox60; 
		public System.Windows.Forms.PictureBox pictureBox61;
		public System.Windows.Forms.PictureBox pictureBox62;
		public System.Windows.Forms.PictureBox pictureBox63;
		public System.Windows.Forms.PictureBox pictureBox64;
		public System.Windows.Forms.PictureBox pictureBox65; 
		public System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		public System.Windows.Forms.PictureBox pictureBox50;
		public System.Windows.Forms.PictureBox pictureBox51;
		public System.Windows.Forms.PictureBox pictureBox52;
		public System.Windows.Forms.Label label14;
		public System.Windows.Forms.PictureBox pictureBox53;
		public System.Windows.Forms.PictureBox pictureBox54;
		public System.Windows.Forms.PictureBox pictureBox55;
		public System.Windows.Forms.PictureBox pictureBox56;
		public System.Windows.Forms.PictureBox pictureBox57;
		private System.Windows.Forms.Panel pnl_MM;
		private System.Windows.Forms.Panel pnl_MMTR;
		private System.Windows.Forms.Splitter splitter4;
		private System.Windows.Forms.Panel pnl_MMBodyLeftTop;
		public COM.FSP fgrid_ModelOpCd;
		public COM.FSP fgrid_Mold;
		private System.Windows.Forms.Panel pnl_MR;
		private System.Windows.Forms.Splitter splitter3;
		public COM.FSP fgrid_MModelDetail;
		public COM.FSP fgrid_LinkRout;
		public COM.FSP fgrid_NodeRout;
		public COM.FSP fgrid_BomNode;
		public COM.FSP fgrid_BomLink;
		private Lassalle.Flow.AddFlow addflow_BOM;
		public COM.FSP fgrid_BOM;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lbl_MLDLineSeq;
		private System.Windows.Forms.TextBox txt_MLAloRate;
		private System.Windows.Forms.Label lbl_MLDAloRate;
		private System.Windows.Forms.Label btn_AppendRow;
		private System.Windows.Forms.TextBox txt_MLLineSeq;
		private System.Windows.Forms.TextBox txt_MLLineName;
		private System.Windows.Forms.TextBox txt_MLLineCd;
		private System.Windows.Forms.TextBox txt_MLModelName;
		private System.Windows.Forms.TextBox txt_MLRemarks;
		private System.Windows.Forms.TextBox txt_MLModelCd;
		private System.Windows.Forms.Label lbl_MLDRemarks;
		private System.Windows.Forms.Label lbl_MLDLine;
		private System.Windows.Forms.Label lbl_MLDModel;
		public System.Windows.Forms.PictureBox pictureBox17;
		public System.Windows.Forms.PictureBox pictureBox18;
		public System.Windows.Forms.PictureBox pictureBox19;
		public System.Windows.Forms.PictureBox pictureBox20;
		public System.Windows.Forms.PictureBox pictureBox21;
		public System.Windows.Forms.Label lbl_SubTitle5;
		public System.Windows.Forms.PictureBox pictureBox22;
		public System.Windows.Forms.PictureBox pictureBox23;
		public System.Windows.Forms.PictureBox pictureBox25;
		private System.Windows.Forms.Panel panel5;
		public System.Windows.Forms.Panel panel6;
		public System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel11;
		private C1.Win.C1List.C1Combo cmb_MLFactory;
		private C1.Win.C1List.C1Combo cmb_MLModel;
		private System.Windows.Forms.Label lbl_MLModel;
		private System.Windows.Forms.Label lbl_MLFactory;
		public System.Windows.Forms.PictureBox pictureBox26;
		public System.Windows.Forms.PictureBox pictureBox27;
		public System.Windows.Forms.PictureBox pictureBox28;
		public System.Windows.Forms.PictureBox pictureBox29;
		public System.Windows.Forms.PictureBox pictureBox30;
		public System.Windows.Forms.Label lbl_SubTitle6;
		public System.Windows.Forms.PictureBox pictureBox31;
		public System.Windows.Forms.PictureBox pictureBox32;
		public System.Windows.Forms.PictureBox pictureBox33;
		public System.Windows.Forms.Panel pnl_MMBodyLeftTopImage;
		private C1.Win.C1List.C1Combo cmb_MMMold;
		public System.Windows.Forms.PictureBox pictureBox34;
		private System.Windows.Forms.Label lbl_MMMold;
		private C1.Win.C1List.C1Combo cmb_MMModel;
		private System.Windows.Forms.Label lbl_MMModel;
		private C1.Win.C1List.C1Combo cmb_MMFactory;
		private System.Windows.Forms.Label lbl_MMFactory;
		public System.Windows.Forms.PictureBox pictureBox35;
		public System.Windows.Forms.PictureBox pictureBox36;
		public System.Windows.Forms.PictureBox pictureBox37;
		public System.Windows.Forms.PictureBox pictureBox38;
		public System.Windows.Forms.PictureBox pictureBox39;
		public System.Windows.Forms.PictureBox pictureBox40;
		public System.Windows.Forms.Label lbl_SubTitle7;
		public System.Windows.Forms.PictureBox pictureBox41;
		private System.Windows.Forms.Panel panel8;
		public System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.TextBox txt_TypeName;
		private System.Windows.Forms.TextBox txt_MoldPart;
		private System.Windows.Forms.Label lbl_MoldPart;
		public System.Windows.Forms.PictureBox pictureBox42;
		public System.Windows.Forms.PictureBox pictureBox43;
		public System.Windows.Forms.PictureBox pictureBox44;
		public System.Windows.Forms.PictureBox pictureBox45;
		public System.Windows.Forms.PictureBox pictureBox46;
		public System.Windows.Forms.PictureBox pictureBox47;
		public System.Windows.Forms.PictureBox pictureBox48;
		public System.Windows.Forms.Label lbl_SubTitle8;
		public System.Windows.Forms.PictureBox pictureBox49;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private C1.Win.C1List.C1Combo cmb_MMGen;
		private System.Windows.Forms.Label lbl_MMGen;
		public System.Windows.Forms.TextBox txt_MDModel;
		private System.Windows.Forms.Label lbl_MDModel;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label btn_TranModel;
		private System.Windows.Forms.Panel pnl_Body;
		public System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_Style; 
		private System.ComponentModel.IContainer components = null;

		public Form_PB_Model()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PB_Model));
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
            this.obar_Main = new C1.Win.C1Command.C1OutBar();
            this.obarpg_Model = new C1.Win.C1Command.C1OutPage();
            this.pnl_MBody = new System.Windows.Forms.Panel();
            this.fgrid_MModelDetail = new COM.FSP();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.pnl_MR = new System.Windows.Forms.Panel();
            this.fgrid_BOM = new COM.FSP();
            this.fgrid_LinkRout = new COM.FSP();
            this.fgrid_NodeRout = new COM.FSP();
            this.fgrid_BomNode = new COM.FSP();
            this.fgrid_BomLink = new COM.FSP();
            this.addflow_BOM = new Lassalle.Flow.AddFlow();
            this.pnl_MBodyRightTop = new System.Windows.Forms.Panel();
            this.pnl_SearchSplitRight = new System.Windows.Forms.Panel();
            this.pnl_SearchRightImage = new System.Windows.Forms.Panel();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.btn_TranModel = new System.Windows.Forms.Label();
            this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
            this.txt_MDModel = new System.Windows.Forms.TextBox();
            this.lbl_MDModel = new System.Windows.Forms.Label();
            this.cmb_MDYear = new C1.Win.C1List.C1Combo();
            this.lbl_MDYear = new System.Windows.Forms.Label();
            this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
            this.cmb_MFactory = new C1.Win.C1List.C1Combo();
            this.lbl_MFactory = new System.Windows.Forms.Label();
            this.picb_RBR = new System.Windows.Forms.PictureBox();
            this.picb_RMR = new System.Windows.Forms.PictureBox();
            this.picb_RBM = new System.Windows.Forms.PictureBox();
            this.picb_RTR = new System.Windows.Forms.PictureBox();
            this.picb_RTM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle2 = new System.Windows.Forms.Label();
            this.picb_RMM = new System.Windows.Forms.PictureBox();
            this.picb_RBL = new System.Windows.Forms.PictureBox();
            this.picb_RML = new System.Windows.Forms.PictureBox();
            this.obarpg_ModelLine = new C1.Win.C1Command.C1OutPage();
            this.pnl_MLBody = new System.Windows.Forms.Panel();
            this.fgrid_ModelLine = new COM.FSP();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cmb_MLFactory = new C1.Win.C1List.C1Combo();
            this.cmb_MLModel = new C1.Win.C1List.C1Combo();
            this.lbl_MLModel = new System.Windows.Forms.Label();
            this.lbl_MLFactory = new System.Windows.Forms.Label();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle6 = new System.Windows.Forms.Label();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_MLDLineSeq = new System.Windows.Forms.Label();
            this.txt_MLAloRate = new System.Windows.Forms.TextBox();
            this.lbl_MLDAloRate = new System.Windows.Forms.Label();
            this.btn_AppendRow = new System.Windows.Forms.Label();
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.txt_MLLineSeq = new System.Windows.Forms.TextBox();
            this.txt_MLLineName = new System.Windows.Forms.TextBox();
            this.txt_MLLineCd = new System.Windows.Forms.TextBox();
            this.txt_MLModelName = new System.Windows.Forms.TextBox();
            this.txt_MLRemarks = new System.Windows.Forms.TextBox();
            this.txt_MLModelCd = new System.Windows.Forms.TextBox();
            this.lbl_MLDRemarks = new System.Windows.Forms.Label();
            this.lbl_MLDLine = new System.Windows.Forms.Label();
            this.lbl_MLDModel = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle5 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_MLLeft = new System.Windows.Forms.Panel();
            this.pnl_MLLeftBody = new System.Windows.Forms.Panel();
            this.fgrid_MLModel = new COM.FSP();
            this.pnl_MLLeftBodySearch = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_MLMFactory = new C1.Win.C1List.C1Combo();
            this.lbl_MLMYear = new System.Windows.Forms.Label();
            this.lbl_MLMFactory = new System.Windows.Forms.Label();
            this.cmb_MLMYear = new C1.Win.C1List.C1Combo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnl_MLLeftBottom = new System.Windows.Forms.Panel();
            this.fgrid_MLLine = new COM.FSP();
            this.pnl_MLLeftBottomSearch = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmb_MLLFactory = new C1.Win.C1List.C1Combo();
            this.lbl_MLLFactory = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle4 = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.obarpg_ModelMold = new C1.Win.C1Command.C1OutPage();
            this.pnl_MM = new System.Windows.Forms.Panel();
            this.fgrid_ModelOpCd = new COM.FSP();
            this.pnl_MMBodyLeftTop = new System.Windows.Forms.Panel();
            this.pnl_MMBodyLeftTopImage = new System.Windows.Forms.Panel();
            this.cmb_MMMold = new C1.Win.C1List.C1Combo();
            this.lbl_MMMold = new System.Windows.Forms.Label();
            this.cmb_MMGen = new C1.Win.C1List.C1Combo();
            this.lbl_MMGen = new System.Windows.Forms.Label();
            this.cmb_MMModel = new C1.Win.C1List.C1Combo();
            this.lbl_MMModel = new System.Windows.Forms.Label();
            this.cmb_MMFactory = new C1.Win.C1List.C1Combo();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.lbl_MMFactory = new System.Windows.Forms.Label();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle7 = new System.Windows.Forms.Label();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.pnl_MMTR = new System.Windows.Forms.Panel();
            this.fgrid_Mold = new COM.FSP();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_TypeName = new System.Windows.Forms.TextBox();
            this.txt_MoldPart = new System.Windows.Forms.TextBox();
            this.lbl_MoldPart = new System.Windows.Forms.Label();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle8 = new System.Windows.Forms.Label();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pnl_Body = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
            this.obar_Main.SuspendLayout();
            this.obarpg_Model.SuspendLayout();
            this.pnl_MBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MModelDetail)).BeginInit();
            this.pnl_MR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkRout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeRout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BomNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BomLink)).BeginInit();
            this.pnl_MBodyRightTop.SuspendLayout();
            this.pnl_SearchSplitRight.SuspendLayout();
            this.pnl_SearchRightImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MDYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RML)).BeginInit();
            this.obarpg_ModelLine.SuspendLayout();
            this.pnl_MLBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_ModelLine)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            this.pnl_MLLeft.SuspendLayout();
            this.pnl_MLLeftBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MLModel)).BeginInit();
            this.pnl_MLLeftBodySearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLMFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLMYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.pnl_MLLeftBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MLLine)).BeginInit();
            this.pnl_MLLeftBottomSearch.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLLFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.obarpg_ModelMold.SuspendLayout();
            this.pnl_MM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_ModelOpCd)).BeginInit();
            this.pnl_MMBodyLeftTop.SuspendLayout();
            this.pnl_MMBodyLeftTopImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MMMold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MMGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MMModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MMFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            this.pnl_MMTR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
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
            // obar_Main
            // 
            this.obar_Main.Animate = false;
            this.obar_Main.BackColor = System.Drawing.SystemColors.Window;
            this.obar_Main.Controls.Add(this.obarpg_Model);
            this.obar_Main.Controls.Add(this.obarpg_ModelLine);
            this.obar_Main.Controls.Add(this.obarpg_ModelMold);
            this.obar_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obar_Main.Location = new System.Drawing.Point(8, 0);
            this.obar_Main.Name = "obar_Main";
            this.obar_Main.SelectedIndex = 0;
            this.obar_Main.Size = new System.Drawing.Size(1000, 584);
            this.obar_Main.SelectedPageChanged += new System.EventHandler(this.obar_Main_SelectedPageChanged);
            // 
            // obarpg_Model
            // 
            this.obarpg_Model.Controls.Add(this.pnl_MBody);
            this.obarpg_Model.Name = "obarpg_Model";
            this.obarpg_Model.Size = new System.Drawing.Size(1000, 524);
            this.obarpg_Model.Text = "Model Information";
            // 
            // pnl_MBody
            // 
            this.pnl_MBody.Controls.Add(this.fgrid_MModelDetail);
            this.pnl_MBody.Controls.Add(this.splitter3);
            this.pnl_MBody.Controls.Add(this.pnl_MR);
            this.pnl_MBody.Controls.Add(this.pnl_MBodyRightTop);
            this.pnl_MBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MBody.Location = new System.Drawing.Point(0, 0);
            this.pnl_MBody.Name = "pnl_MBody";
            this.pnl_MBody.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_MBody.Size = new System.Drawing.Size(1000, 524);
            this.pnl_MBody.TabIndex = 37;
            // 
            // fgrid_MModelDetail
            // 
            this.fgrid_MModelDetail.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_MModelDetail.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_MModelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_MModelDetail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_MModelDetail.Location = new System.Drawing.Point(8, 80);
            this.fgrid_MModelDetail.Name = "fgrid_MModelDetail";
            this.fgrid_MModelDetail.Rows.DefaultSize = 19;
            this.fgrid_MModelDetail.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_MModelDetail.Size = new System.Drawing.Size(492, 436);
            this.fgrid_MModelDetail.StyleInfo = resources.GetString("fgrid_MModelDetail.StyleInfo");
            this.fgrid_MModelDetail.TabIndex = 47;
            this.fgrid_MModelDetail.Click += new System.EventHandler(this.fgrid_MModelDetail_Click);
            this.fgrid_MModelDetail.ComboCloseUp += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MModelDetail_ComboCloseUp);
            this.fgrid_MModelDetail.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MModelDetail_AfterEdit);
            this.fgrid_MModelDetail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_MModelDetail_MouseDown);
            this.fgrid_MModelDetail.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MModelDetail_BeforeEdit);
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(500, 80);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(4, 436);
            this.splitter3.TabIndex = 27;
            this.splitter3.TabStop = false;
            // 
            // pnl_MR
            // 
            this.pnl_MR.Controls.Add(this.fgrid_BOM);
            this.pnl_MR.Controls.Add(this.fgrid_LinkRout);
            this.pnl_MR.Controls.Add(this.fgrid_NodeRout);
            this.pnl_MR.Controls.Add(this.fgrid_BomNode);
            this.pnl_MR.Controls.Add(this.fgrid_BomLink);
            this.pnl_MR.Controls.Add(this.addflow_BOM);
            this.pnl_MR.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_MR.Location = new System.Drawing.Point(504, 80);
            this.pnl_MR.Name = "pnl_MR";
            this.pnl_MR.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnl_MR.Size = new System.Drawing.Size(488, 436);
            this.pnl_MR.TabIndex = 26;
            // 
            // fgrid_BOM
            // 
            this.fgrid_BOM.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_BOM.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"bom tree\";}\t";
            this.fgrid_BOM.Location = new System.Drawing.Point(56, 256);
            this.fgrid_BOM.Name = "fgrid_BOM";
            this.fgrid_BOM.Rows.DefaultSize = 19;
            this.fgrid_BOM.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_BOM.Size = new System.Drawing.Size(160, 112);
            this.fgrid_BOM.StyleInfo = resources.GetString("fgrid_BOM.StyleInfo");
            this.fgrid_BOM.TabIndex = 49;
            this.fgrid_BOM.Visible = false;
            // 
            // fgrid_LinkRout
            // 
            this.fgrid_LinkRout.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_LinkRout.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"link rout\";}\t";
            this.fgrid_LinkRout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_LinkRout.Location = new System.Drawing.Point(320, 256);
            this.fgrid_LinkRout.Name = "fgrid_LinkRout";
            this.fgrid_LinkRout.Rows.DefaultSize = 19;
            this.fgrid_LinkRout.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_LinkRout.Size = new System.Drawing.Size(104, 56);
            this.fgrid_LinkRout.StyleInfo = resources.GetString("fgrid_LinkRout.StyleInfo");
            this.fgrid_LinkRout.TabIndex = 48;
            this.fgrid_LinkRout.Visible = false;
            // 
            // fgrid_NodeRout
            // 
            this.fgrid_NodeRout.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_NodeRout.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"node rout\";}\t";
            this.fgrid_NodeRout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_NodeRout.Location = new System.Drawing.Point(216, 256);
            this.fgrid_NodeRout.Name = "fgrid_NodeRout";
            this.fgrid_NodeRout.Rows.DefaultSize = 19;
            this.fgrid_NodeRout.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_NodeRout.Size = new System.Drawing.Size(104, 56);
            this.fgrid_NodeRout.StyleInfo = resources.GetString("fgrid_NodeRout.StyleInfo");
            this.fgrid_NodeRout.TabIndex = 47;
            this.fgrid_NodeRout.Visible = false;
            // 
            // fgrid_BomNode
            // 
            this.fgrid_BomNode.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_BomNode.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"node bom\";}\t";
            this.fgrid_BomNode.Location = new System.Drawing.Point(216, 312);
            this.fgrid_BomNode.Name = "fgrid_BomNode";
            this.fgrid_BomNode.Rows.DefaultSize = 19;
            this.fgrid_BomNode.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_BomNode.Size = new System.Drawing.Size(104, 56);
            this.fgrid_BomNode.StyleInfo = resources.GetString("fgrid_BomNode.StyleInfo");
            this.fgrid_BomNode.TabIndex = 45;
            this.fgrid_BomNode.Visible = false;
            // 
            // fgrid_BomLink
            // 
            this.fgrid_BomLink.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_BomLink.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"link bom\";}\t";
            this.fgrid_BomLink.Location = new System.Drawing.Point(320, 312);
            this.fgrid_BomLink.Name = "fgrid_BomLink";
            this.fgrid_BomLink.Rows.DefaultSize = 19;
            this.fgrid_BomLink.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_BomLink.Size = new System.Drawing.Size(104, 56);
            this.fgrid_BomLink.StyleInfo = resources.GetString("fgrid_BomLink.StyleInfo");
            this.fgrid_BomLink.TabIndex = 46;
            this.fgrid_BomLink.Visible = false;
            // 
            // addflow_BOM
            // 
            this.addflow_BOM.AutoScroll = true;
            this.addflow_BOM.AutoScrollMinSize = new System.Drawing.Size(640, 567);
            this.addflow_BOM.CanDrawLink = false;
            this.addflow_BOM.CanDrawNode = false;
            this.addflow_BOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addflow_BOM.Location = new System.Drawing.Point(5, 0);
            this.addflow_BOM.Name = "addflow_BOM";
            this.addflow_BOM.Size = new System.Drawing.Size(483, 436);
            this.addflow_BOM.TabIndex = 44;
            // 
            // pnl_MBodyRightTop
            // 
            this.pnl_MBodyRightTop.Controls.Add(this.pnl_SearchSplitRight);
            this.pnl_MBodyRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MBodyRightTop.Location = new System.Drawing.Point(8, 8);
            this.pnl_MBodyRightTop.Name = "pnl_MBodyRightTop";
            this.pnl_MBodyRightTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_MBodyRightTop.Size = new System.Drawing.Size(984, 72);
            this.pnl_MBodyRightTop.TabIndex = 25;
            // 
            // pnl_SearchSplitRight
            // 
            this.pnl_SearchSplitRight.Controls.Add(this.pnl_SearchRightImage);
            this.pnl_SearchSplitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchSplitRight.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchSplitRight.Name = "pnl_SearchSplitRight";
            this.pnl_SearchSplitRight.Size = new System.Drawing.Size(984, 64);
            this.pnl_SearchSplitRight.TabIndex = 27;
            // 
            // pnl_SearchRightImage
            // 
            this.pnl_SearchRightImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchRightImage.Controls.Add(this.txt_StyleCd);
            this.pnl_SearchRightImage.Controls.Add(this.lbl_Style);
            this.pnl_SearchRightImage.Controls.Add(this.btn_TranModel);
            this.pnl_SearchRightImage.Controls.Add(this.txt_MDModel);
            this.pnl_SearchRightImage.Controls.Add(this.lbl_MDModel);
            this.pnl_SearchRightImage.Controls.Add(this.cmb_MDYear);
            this.pnl_SearchRightImage.Controls.Add(this.lbl_MDYear);
            this.pnl_SearchRightImage.Controls.Add(this.cmb_MFactory);
            this.pnl_SearchRightImage.Controls.Add(this.lbl_MFactory);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RBR);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RMR);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RBM);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RTR);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RTM);
            this.pnl_SearchRightImage.Controls.Add(this.lbl_SubTitle2);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RMM);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RBL);
            this.pnl_SearchRightImage.Controls.Add(this.picb_RML);
            this.pnl_SearchRightImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchRightImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchRightImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchRightImage.Name = "pnl_SearchRightImage";
            this.pnl_SearchRightImage.Size = new System.Drawing.Size(984, 64);
            this.pnl_SearchRightImage.TabIndex = 20;
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_StyleCd.Location = new System.Drawing.Point(712, 36);
            this.txt_StyleCd.MaxLength = 60;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(150, 21);
            this.txt_StyleCd.TabIndex = 125;
            this.txt_StyleCd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StyleCd_KeyPress);
            // 
            // lbl_Style
            // 
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(611, 36);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 124;
            this.lbl_Style.Text = "Style Code";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_TranModel
            // 
            this.btn_TranModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TranModel.ImageIndex = 0;
            this.btn_TranModel.ImageList = this.img_LongButton;
            this.btn_TranModel.Location = new System.Drawing.Point(877, 34);
            this.btn_TranModel.Name = "btn_TranModel";
            this.btn_TranModel.Size = new System.Drawing.Size(100, 23);
            this.btn_TranModel.TabIndex = 123;
            this.btn_TranModel.Text = "Trans Model";
            this.btn_TranModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_TranModel.Click += new System.EventHandler(this.btn_TranModel_Click);
            this.btn_TranModel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_TranModel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_LongButton
            // 
            this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
            this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongButton.Images.SetKeyName(0, "");
            this.img_LongButton.Images.SetKeyName(1, "");
            // 
            // txt_MDModel
            // 
            this.txt_MDModel.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MDModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MDModel.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_MDModel.Location = new System.Drawing.Point(445, 36);
            this.txt_MDModel.MaxLength = 60;
            this.txt_MDModel.Name = "txt_MDModel";
            this.txt_MDModel.Size = new System.Drawing.Size(150, 21);
            this.txt_MDModel.TabIndex = 114;
            this.txt_MDModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MDModel_KeyPress);
            // 
            // lbl_MDModel
            // 
            this.lbl_MDModel.ImageIndex = 0;
            this.lbl_MDModel.ImageList = this.img_Label;
            this.lbl_MDModel.Location = new System.Drawing.Point(344, 36);
            this.lbl_MDModel.Name = "lbl_MDModel";
            this.lbl_MDModel.Size = new System.Drawing.Size(100, 21);
            this.lbl_MDModel.TabIndex = 43;
            this.lbl_MDModel.Text = "Model Name";
            this.lbl_MDModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_MDYear
            // 
            this.cmb_MDYear.AddItemSeparator = ';';
            this.cmb_MDYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MDYear.Caption = "";
            this.cmb_MDYear.CaptionHeight = 17;
            this.cmb_MDYear.CaptionStyle = style1;
            this.cmb_MDYear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MDYear.ColumnCaptionHeight = 18;
            this.cmb_MDYear.ColumnFooterHeight = 18;
            this.cmb_MDYear.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MDYear.ContentHeight = 17;
            this.cmb_MDYear.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MDYear.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MDYear.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MDYear.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MDYear.EditorHeight = 17;
            this.cmb_MDYear.EvenRowStyle = style2;
            this.cmb_MDYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MDYear.FooterStyle = style3;
            this.cmb_MDYear.HeadingStyle = style4;
            this.cmb_MDYear.HighLightRowStyle = style5;
            this.cmb_MDYear.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MDYear.Images"))));
            this.cmb_MDYear.ItemHeight = 15;
            this.cmb_MDYear.Location = new System.Drawing.Point(227, 36);
            this.cmb_MDYear.MatchEntryTimeout = ((long)(2000));
            this.cmb_MDYear.MaxDropDownItems = ((short)(5));
            this.cmb_MDYear.MaxLength = 32767;
            this.cmb_MDYear.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MDYear.Name = "cmb_MDYear";
            this.cmb_MDYear.OddRowStyle = style6;
            this.cmb_MDYear.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MDYear.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MDYear.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MDYear.SelectedStyle = style7;
            this.cmb_MDYear.Size = new System.Drawing.Size(100, 21);
            this.cmb_MDYear.Style = style8;
            this.cmb_MDYear.TabIndex = 42;
            this.cmb_MDYear.SelectedValueChanged += new System.EventHandler(this.cmb_MDYear_SelectedValueChanged);
            this.cmb_MDYear.PropBag = resources.GetString("cmb_MDYear.PropBag");
            // 
            // lbl_MDYear
            // 
            this.lbl_MDYear.ImageIndex = 0;
            this.lbl_MDYear.ImageList = this.img_SmallLabel;
            this.lbl_MDYear.Location = new System.Drawing.Point(176, 36);
            this.lbl_MDYear.Name = "lbl_MDYear";
            this.lbl_MDYear.Size = new System.Drawing.Size(50, 21);
            this.lbl_MDYear.TabIndex = 41;
            this.lbl_MDYear.Text = "Year";
            this.lbl_MDYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img_SmallLabel
            // 
            this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
            this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallLabel.Images.SetKeyName(0, "");
            this.img_SmallLabel.Images.SetKeyName(1, "");
            this.img_SmallLabel.Images.SetKeyName(2, "");
            // 
            // cmb_MFactory
            // 
            this.cmb_MFactory.AddItemSeparator = ';';
            this.cmb_MFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MFactory.Caption = "";
            this.cmb_MFactory.CaptionHeight = 17;
            this.cmb_MFactory.CaptionStyle = style9;
            this.cmb_MFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MFactory.ColumnCaptionHeight = 18;
            this.cmb_MFactory.ColumnFooterHeight = 18;
            this.cmb_MFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MFactory.ContentHeight = 17;
            this.cmb_MFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MFactory.EditorHeight = 17;
            this.cmb_MFactory.EvenRowStyle = style10;
            this.cmb_MFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MFactory.FooterStyle = style11;
            this.cmb_MFactory.HeadingStyle = style12;
            this.cmb_MFactory.HighLightRowStyle = style13;
            this.cmb_MFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MFactory.Images"))));
            this.cmb_MFactory.ItemHeight = 15;
            this.cmb_MFactory.Location = new System.Drawing.Point(61, 36);
            this.cmb_MFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_MFactory.MaxDropDownItems = ((short)(5));
            this.cmb_MFactory.MaxLength = 32767;
            this.cmb_MFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MFactory.Name = "cmb_MFactory";
            this.cmb_MFactory.OddRowStyle = style14;
            this.cmb_MFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MFactory.SelectedStyle = style15;
            this.cmb_MFactory.Size = new System.Drawing.Size(100, 21);
            this.cmb_MFactory.Style = style16;
            this.cmb_MFactory.TabIndex = 40;
            this.cmb_MFactory.SelectedValueChanged += new System.EventHandler(this.cmb_MFactory_SelectedValueChanged);
            this.cmb_MFactory.PropBag = resources.GetString("cmb_MFactory.PropBag");
            // 
            // lbl_MFactory
            // 
            this.lbl_MFactory.ImageIndex = 0;
            this.lbl_MFactory.ImageList = this.img_SmallLabel;
            this.lbl_MFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_MFactory.Name = "lbl_MFactory";
            this.lbl_MFactory.Size = new System.Drawing.Size(50, 21);
            this.lbl_MFactory.TabIndex = 39;
            this.lbl_MFactory.Text = "Factoty";
            this.lbl_MFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_RBR
            // 
            this.picb_RBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_RBR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_RBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_RBR.Image")));
            this.picb_RBR.Location = new System.Drawing.Point(968, 48);
            this.picb_RBR.Name = "picb_RBR";
            this.picb_RBR.Size = new System.Drawing.Size(20, 16);
            this.picb_RBR.TabIndex = 23;
            this.picb_RBR.TabStop = false;
            // 
            // picb_RMR
            // 
            this.picb_RMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_RMR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_RMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_RMR.Image")));
            this.picb_RMR.Location = new System.Drawing.Point(969, 24);
            this.picb_RMR.Name = "picb_RMR";
            this.picb_RMR.Size = new System.Drawing.Size(19, 64);
            this.picb_RMR.TabIndex = 26;
            this.picb_RMR.TabStop = false;
            // 
            // picb_RBM
            // 
            this.picb_RBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_RBM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_RBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_RBM.Image")));
            this.picb_RBM.Location = new System.Drawing.Point(144, 46);
            this.picb_RBM.Name = "picb_RBM";
            this.picb_RBM.Size = new System.Drawing.Size(984, 18);
            this.picb_RBM.TabIndex = 24;
            this.picb_RBM.TabStop = false;
            // 
            // picb_RTR
            // 
            this.picb_RTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_RTR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_RTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_RTR.Image")));
            this.picb_RTR.Location = new System.Drawing.Point(968, 0);
            this.picb_RTR.Name = "picb_RTR";
            this.picb_RTR.Size = new System.Drawing.Size(20, 32);
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
            this.picb_RTM.Size = new System.Drawing.Size(984, 39);
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
            this.lbl_SubTitle2.Text = "      Detail Model Info.";
            this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_RMM
            // 
            this.picb_RMM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_RMM.Image = ((System.Drawing.Image)(resources.GetObject("picb_RMM.Image")));
            this.picb_RMM.Location = new System.Drawing.Point(160, 24);
            this.picb_RMM.Name = "picb_RMM";
            this.picb_RMM.Size = new System.Drawing.Size(982, 87);
            this.picb_RMM.TabIndex = 27;
            this.picb_RMM.TabStop = false;
            // 
            // picb_RBL
            // 
            this.picb_RBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_RBL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_RBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_RBL.Image")));
            this.picb_RBL.Location = new System.Drawing.Point(0, 44);
            this.picb_RBL.Name = "picb_RBL";
            this.picb_RBL.Size = new System.Drawing.Size(168, 20);
            this.picb_RBL.TabIndex = 22;
            this.picb_RBL.TabStop = false;
            // 
            // picb_RML
            // 
            this.picb_RML.BackColor = System.Drawing.SystemColors.Window;
            this.picb_RML.Image = ((System.Drawing.Image)(resources.GetObject("picb_RML.Image")));
            this.picb_RML.Location = new System.Drawing.Point(0, 24);
            this.picb_RML.Name = "picb_RML";
            this.picb_RML.Size = new System.Drawing.Size(168, 87);
            this.picb_RML.TabIndex = 25;
            this.picb_RML.TabStop = false;
            // 
            // obarpg_ModelLine
            // 
            this.obarpg_ModelLine.Controls.Add(this.pnl_MLBody);
            this.obarpg_ModelLine.Name = "obarpg_ModelLine";
            this.obarpg_ModelLine.PageVisible = false;
            this.obarpg_ModelLine.Size = new System.Drawing.Size(1000, 524);
            this.obarpg_ModelLine.Text = "Model Assambly Line Information";
            // 
            // pnl_MLBody
            // 
            this.pnl_MLBody.Controls.Add(this.fgrid_ModelLine);
            this.pnl_MLBody.Controls.Add(this.panel5);
            this.pnl_MLBody.Controls.Add(this.panel1);
            this.pnl_MLBody.Controls.Add(this.splitter1);
            this.pnl_MLBody.Controls.Add(this.pnl_MLLeft);
            this.pnl_MLBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MLBody.Location = new System.Drawing.Point(0, 0);
            this.pnl_MLBody.Name = "pnl_MLBody";
            this.pnl_MLBody.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_MLBody.Size = new System.Drawing.Size(1000, 524);
            this.pnl_MLBody.TabIndex = 38;
            // 
            // fgrid_ModelLine
            // 
            this.fgrid_ModelLine.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_ModelLine.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_ModelLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_ModelLine.Location = new System.Drawing.Point(507, 243);
            this.fgrid_ModelLine.Name = "fgrid_ModelLine";
            this.fgrid_ModelLine.Rows.DefaultSize = 19;
            this.fgrid_ModelLine.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_ModelLine.Size = new System.Drawing.Size(485, 273);
            this.fgrid_ModelLine.StyleInfo = resources.GetString("fgrid_ModelLine.StyleInfo");
            this.fgrid_ModelLine.TabIndex = 48;
            this.fgrid_ModelLine.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_ModelLine_AfterEdit);
            this.fgrid_ModelLine.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_ModelLine_BeforeEdit);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(507, 148);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panel5.Size = new System.Drawing.Size(485, 95);
            this.panel5.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(485, 87);
            this.panel6.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(485, 87);
            this.panel7.TabIndex = 28;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Window;
            this.panel11.Controls.Add(this.cmb_MLFactory);
            this.panel11.Controls.Add(this.cmb_MLModel);
            this.panel11.Controls.Add(this.lbl_MLModel);
            this.panel11.Controls.Add(this.lbl_MLFactory);
            this.panel11.Controls.Add(this.pictureBox26);
            this.panel11.Controls.Add(this.pictureBox27);
            this.panel11.Controls.Add(this.pictureBox28);
            this.panel11.Controls.Add(this.pictureBox29);
            this.panel11.Controls.Add(this.pictureBox30);
            this.panel11.Controls.Add(this.lbl_SubTitle6);
            this.panel11.Controls.Add(this.pictureBox31);
            this.panel11.Controls.Add(this.pictureBox32);
            this.panel11.Controls.Add(this.pictureBox33);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(485, 87);
            this.panel11.TabIndex = 20;
            // 
            // cmb_MLFactory
            // 
            this.cmb_MLFactory.AddItemSeparator = ';';
            this.cmb_MLFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MLFactory.Caption = "";
            this.cmb_MLFactory.CaptionHeight = 17;
            this.cmb_MLFactory.CaptionStyle = style17;
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
            this.cmb_MLFactory.EvenRowStyle = style18;
            this.cmb_MLFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLFactory.FooterStyle = style19;
            this.cmb_MLFactory.HeadingStyle = style20;
            this.cmb_MLFactory.HighLightRowStyle = style21;
            this.cmb_MLFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MLFactory.Images"))));
            this.cmb_MLFactory.ItemHeight = 15;
            this.cmb_MLFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_MLFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_MLFactory.MaxDropDownItems = ((short)(5));
            this.cmb_MLFactory.MaxLength = 32767;
            this.cmb_MLFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MLFactory.Name = "cmb_MLFactory";
            this.cmb_MLFactory.OddRowStyle = style22;
            this.cmb_MLFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MLFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MLFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MLFactory.SelectedStyle = style23;
            this.cmb_MLFactory.Size = new System.Drawing.Size(210, 21);
            this.cmb_MLFactory.Style = style24;
            this.cmb_MLFactory.TabIndex = 32;
            this.cmb_MLFactory.SelectedValueChanged += new System.EventHandler(this.cmb_MLFactory_SelectedValueChanged);
            this.cmb_MLFactory.PropBag = resources.GetString("cmb_MLFactory.PropBag");
            // 
            // cmb_MLModel
            // 
            this.cmb_MLModel.AddItemSeparator = ';';
            this.cmb_MLModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MLModel.Caption = "";
            this.cmb_MLModel.CaptionHeight = 17;
            this.cmb_MLModel.CaptionStyle = style25;
            this.cmb_MLModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MLModel.ColumnCaptionHeight = 18;
            this.cmb_MLModel.ColumnFooterHeight = 18;
            this.cmb_MLModel.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MLModel.ContentHeight = 17;
            this.cmb_MLModel.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MLModel.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MLModel.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLModel.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MLModel.EditorHeight = 17;
            this.cmb_MLModel.EvenRowStyle = style26;
            this.cmb_MLModel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLModel.FooterStyle = style27;
            this.cmb_MLModel.HeadingStyle = style28;
            this.cmb_MLModel.HighLightRowStyle = style29;
            this.cmb_MLModel.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MLModel.Images"))));
            this.cmb_MLModel.ItemHeight = 15;
            this.cmb_MLModel.Location = new System.Drawing.Point(111, 58);
            this.cmb_MLModel.MatchEntryTimeout = ((long)(2000));
            this.cmb_MLModel.MaxDropDownItems = ((short)(5));
            this.cmb_MLModel.MaxLength = 32767;
            this.cmb_MLModel.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MLModel.Name = "cmb_MLModel";
            this.cmb_MLModel.OddRowStyle = style30;
            this.cmb_MLModel.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MLModel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MLModel.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MLModel.SelectedStyle = style31;
            this.cmb_MLModel.Size = new System.Drawing.Size(210, 21);
            this.cmb_MLModel.Style = style32;
            this.cmb_MLModel.TabIndex = 34;
            this.cmb_MLModel.SelectedValueChanged += new System.EventHandler(this.cmb_MLModel_SelectedValueChanged);
            this.cmb_MLModel.PropBag = resources.GetString("cmb_MLModel.PropBag");
            // 
            // lbl_MLModel
            // 
            this.lbl_MLModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MLModel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MLModel.ImageIndex = 0;
            this.lbl_MLModel.ImageList = this.img_Label;
            this.lbl_MLModel.Location = new System.Drawing.Point(10, 58);
            this.lbl_MLModel.Name = "lbl_MLModel";
            this.lbl_MLModel.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLModel.TabIndex = 33;
            this.lbl_MLModel.Text = "Model";
            this.lbl_MLModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MLFactory
            // 
            this.lbl_MLFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MLFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MLFactory.ImageIndex = 0;
            this.lbl_MLFactory.ImageList = this.img_Label;
            this.lbl_MLFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_MLFactory.Name = "lbl_MLFactory";
            this.lbl_MLFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLFactory.TabIndex = 31;
            this.lbl_MLFactory.Text = "Factory";
            this.lbl_MLFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox26.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(469, 71);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(20, 16);
            this.pictureBox26.TabIndex = 23;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox27.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(470, 24);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(19, 87);
            this.pictureBox27.TabIndex = 26;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox28.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
            this.pictureBox28.Location = new System.Drawing.Point(144, 69);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(485, 18);
            this.pictureBox28.TabIndex = 24;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox29.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
            this.pictureBox29.Location = new System.Drawing.Point(469, 0);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(20, 32);
            this.pictureBox29.TabIndex = 21;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox30.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
            this.pictureBox30.Location = new System.Drawing.Point(224, 0);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(485, 39);
            this.pictureBox30.TabIndex = 0;
            this.pictureBox30.TabStop = false;
            // 
            // lbl_SubTitle6
            // 
            this.lbl_SubTitle6.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_SubTitle6.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle6.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle6.Image")));
            this.lbl_SubTitle6.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle6.Name = "lbl_SubTitle6";
            this.lbl_SubTitle6.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle6.TabIndex = 20;
            this.lbl_SubTitle6.Text = "      Model Assembly Line Info.";
            this.lbl_SubTitle6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox31.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
            this.pictureBox31.Location = new System.Drawing.Point(160, 24);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(485, 87);
            this.pictureBox31.TabIndex = 27;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox32.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
            this.pictureBox32.Location = new System.Drawing.Point(0, 67);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(168, 20);
            this.pictureBox32.TabIndex = 22;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox33.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox33.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox33.Image")));
            this.pictureBox33.Location = new System.Drawing.Point(0, 24);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(168, 87);
            this.pictureBox33.TabIndex = 25;
            this.pictureBox33.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(507, 8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panel1.Size = new System.Drawing.Size(485, 140);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.lbl_MLDLineSeq);
            this.panel3.Controls.Add(this.txt_MLAloRate);
            this.panel3.Controls.Add(this.lbl_MLDAloRate);
            this.panel3.Controls.Add(this.btn_AppendRow);
            this.panel3.Controls.Add(this.txt_MLLineSeq);
            this.panel3.Controls.Add(this.txt_MLLineName);
            this.panel3.Controls.Add(this.txt_MLLineCd);
            this.panel3.Controls.Add(this.txt_MLModelName);
            this.panel3.Controls.Add(this.txt_MLRemarks);
            this.panel3.Controls.Add(this.txt_MLModelCd);
            this.panel3.Controls.Add(this.lbl_MLDRemarks);
            this.panel3.Controls.Add(this.lbl_MLDLine);
            this.panel3.Controls.Add(this.lbl_MLDModel);
            this.panel3.Controls.Add(this.pictureBox17);
            this.panel3.Controls.Add(this.pictureBox18);
            this.panel3.Controls.Add(this.pictureBox19);
            this.panel3.Controls.Add(this.pictureBox20);
            this.panel3.Controls.Add(this.pictureBox21);
            this.panel3.Controls.Add(this.lbl_SubTitle5);
            this.panel3.Controls.Add(this.pictureBox22);
            this.panel3.Controls.Add(this.pictureBox23);
            this.panel3.Controls.Add(this.pictureBox25);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 132);
            this.panel3.TabIndex = 20;
            // 
            // lbl_MLDLineSeq
            // 
            this.lbl_MLDLineSeq.ImageIndex = 0;
            this.lbl_MLDLineSeq.ImageList = this.img_Label;
            this.lbl_MLDLineSeq.Location = new System.Drawing.Point(10, 80);
            this.lbl_MLDLineSeq.Name = "lbl_MLDLineSeq";
            this.lbl_MLDLineSeq.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLDLineSeq.TabIndex = 112;
            this.lbl_MLDLineSeq.Text = "Line Priority";
            this.lbl_MLDLineSeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MLAloRate
            // 
            this.txt_MLAloRate.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MLAloRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MLAloRate.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_MLAloRate.Location = new System.Drawing.Point(389, 8);
            this.txt_MLAloRate.MaxLength = 60;
            this.txt_MLAloRate.Name = "txt_MLAloRate";
            this.txt_MLAloRate.Size = new System.Drawing.Size(80, 21);
            this.txt_MLAloRate.TabIndex = 116;
            this.txt_MLAloRate.Visible = false;
            // 
            // lbl_MLDAloRate
            // 
            this.lbl_MLDAloRate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MLDAloRate.ImageIndex = 0;
            this.lbl_MLDAloRate.ImageList = this.img_Label;
            this.lbl_MLDAloRate.Location = new System.Drawing.Point(288, 8);
            this.lbl_MLDAloRate.Name = "lbl_MLDAloRate";
            this.lbl_MLDAloRate.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLDAloRate.TabIndex = 115;
            this.lbl_MLDAloRate.Text = "CAPA 할당비율";
            this.lbl_MLDAloRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_MLDAloRate.Visible = false;
            // 
            // btn_AppendRow
            // 
            this.btn_AppendRow.ImageIndex = 0;
            this.btn_AppendRow.ImageList = this.img_MiniButton;
            this.btn_AppendRow.Location = new System.Drawing.Point(322, 102);
            this.btn_AppendRow.Name = "btn_AppendRow";
            this.btn_AppendRow.Size = new System.Drawing.Size(21, 21);
            this.btn_AppendRow.TabIndex = 114;
            this.btn_AppendRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AppendRow.Click += new System.EventHandler(this.btn_AppendRow_Click);
            this.btn_AppendRow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_AppendRow_MouseDown);
            this.btn_AppendRow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_AppendRow_MouseUp);
            // 
            // img_MiniButton
            // 
            this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
            this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_MiniButton.Images.SetKeyName(0, "");
            this.img_MiniButton.Images.SetKeyName(1, "");
            // 
            // txt_MLLineSeq
            // 
            this.txt_MLLineSeq.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MLLineSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MLLineSeq.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_MLLineSeq.Location = new System.Drawing.Point(111, 80);
            this.txt_MLLineSeq.MaxLength = 60;
            this.txt_MLLineSeq.Name = "txt_MLLineSeq";
            this.txt_MLLineSeq.Size = new System.Drawing.Size(210, 21);
            this.txt_MLLineSeq.TabIndex = 113;
            // 
            // txt_MLLineName
            // 
            this.txt_MLLineName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_MLLineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MLLineName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_MLLineName.Location = new System.Drawing.Point(177, 58);
            this.txt_MLLineName.MaxLength = 60;
            this.txt_MLLineName.Name = "txt_MLLineName";
            this.txt_MLLineName.ReadOnly = true;
            this.txt_MLLineName.Size = new System.Drawing.Size(144, 21);
            this.txt_MLLineName.TabIndex = 111;
            // 
            // txt_MLLineCd
            // 
            this.txt_MLLineCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_MLLineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MLLineCd.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_MLLineCd.Location = new System.Drawing.Point(111, 58);
            this.txt_MLLineCd.MaxLength = 60;
            this.txt_MLLineCd.Name = "txt_MLLineCd";
            this.txt_MLLineCd.ReadOnly = true;
            this.txt_MLLineCd.Size = new System.Drawing.Size(65, 21);
            this.txt_MLLineCd.TabIndex = 110;
            // 
            // txt_MLModelName
            // 
            this.txt_MLModelName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_MLModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MLModelName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_MLModelName.Location = new System.Drawing.Point(177, 36);
            this.txt_MLModelName.MaxLength = 60;
            this.txt_MLModelName.Name = "txt_MLModelName";
            this.txt_MLModelName.ReadOnly = true;
            this.txt_MLModelName.Size = new System.Drawing.Size(144, 21);
            this.txt_MLModelName.TabIndex = 109;
            // 
            // txt_MLRemarks
            // 
            this.txt_MLRemarks.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MLRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MLRemarks.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_MLRemarks.Location = new System.Drawing.Point(111, 102);
            this.txt_MLRemarks.MaxLength = 60;
            this.txt_MLRemarks.Name = "txt_MLRemarks";
            this.txt_MLRemarks.Size = new System.Drawing.Size(210, 21);
            this.txt_MLRemarks.TabIndex = 108;
            // 
            // txt_MLModelCd
            // 
            this.txt_MLModelCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_MLModelCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MLModelCd.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_MLModelCd.Location = new System.Drawing.Point(111, 36);
            this.txt_MLModelCd.MaxLength = 60;
            this.txt_MLModelCd.Name = "txt_MLModelCd";
            this.txt_MLModelCd.ReadOnly = true;
            this.txt_MLModelCd.Size = new System.Drawing.Size(65, 21);
            this.txt_MLModelCd.TabIndex = 107;
            // 
            // lbl_MLDRemarks
            // 
            this.lbl_MLDRemarks.ImageIndex = 0;
            this.lbl_MLDRemarks.ImageList = this.img_Label;
            this.lbl_MLDRemarks.Location = new System.Drawing.Point(10, 102);
            this.lbl_MLDRemarks.Name = "lbl_MLDRemarks";
            this.lbl_MLDRemarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLDRemarks.TabIndex = 106;
            this.lbl_MLDRemarks.Text = "Remarks";
            this.lbl_MLDRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MLDLine
            // 
            this.lbl_MLDLine.ImageIndex = 0;
            this.lbl_MLDLine.ImageList = this.img_Label;
            this.lbl_MLDLine.Location = new System.Drawing.Point(10, 58);
            this.lbl_MLDLine.Name = "lbl_MLDLine";
            this.lbl_MLDLine.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLDLine.TabIndex = 105;
            this.lbl_MLDLine.Text = "Line";
            this.lbl_MLDLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MLDModel
            // 
            this.lbl_MLDModel.ImageIndex = 0;
            this.lbl_MLDModel.ImageList = this.img_Label;
            this.lbl_MLDModel.Location = new System.Drawing.Point(10, 36);
            this.lbl_MLDModel.Name = "lbl_MLDModel";
            this.lbl_MLDModel.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLDModel.TabIndex = 104;
            this.lbl_MLDModel.Text = "Model";
            this.lbl_MLDModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(469, 116);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(16, 16);
            this.pictureBox17.TabIndex = 23;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(0, 112);
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
            this.pictureBox19.Location = new System.Drawing.Point(470, 24);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(15, 132);
            this.pictureBox19.TabIndex = 26;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox20.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(469, 0);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(16, 32);
            this.pictureBox20.TabIndex = 21;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(224, 0);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(485, 32);
            this.pictureBox21.TabIndex = 0;
            this.pictureBox21.TabStop = false;
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
            this.lbl_SubTitle5.Text = "      Display Select Info.";
            this.lbl_SubTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox22.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(131, 114);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(485, 18);
            this.pictureBox22.TabIndex = 28;
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
            this.pictureBox23.Size = new System.Drawing.Size(485, 132);
            this.pictureBox23.TabIndex = 27;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox25.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
            this.pictureBox25.Location = new System.Drawing.Point(0, 24);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(168, 132);
            this.pictureBox25.TabIndex = 25;
            this.pictureBox25.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(504, 8);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 508);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnl_MLLeft
            // 
            this.pnl_MLLeft.Controls.Add(this.pnl_MLLeftBody);
            this.pnl_MLLeft.Controls.Add(this.splitter2);
            this.pnl_MLLeft.Controls.Add(this.pnl_MLLeftBottom);
            this.pnl_MLLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MLLeft.Location = new System.Drawing.Point(8, 8);
            this.pnl_MLLeft.Name = "pnl_MLLeft";
            this.pnl_MLLeft.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnl_MLLeft.Size = new System.Drawing.Size(496, 508);
            this.pnl_MLLeft.TabIndex = 0;
            // 
            // pnl_MLLeftBody
            // 
            this.pnl_MLLeftBody.Controls.Add(this.fgrid_MLModel);
            this.pnl_MLLeftBody.Controls.Add(this.pnl_MLLeftBodySearch);
            this.pnl_MLLeftBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MLLeftBody.Location = new System.Drawing.Point(0, 0);
            this.pnl_MLLeftBody.Name = "pnl_MLLeftBody";
            this.pnl_MLLeftBody.Size = new System.Drawing.Size(491, 231);
            this.pnl_MLLeftBody.TabIndex = 2;
            // 
            // fgrid_MLModel
            // 
            this.fgrid_MLModel.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_MLModel.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_MLModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_MLModel.Location = new System.Drawing.Point(0, 95);
            this.fgrid_MLModel.Name = "fgrid_MLModel";
            this.fgrid_MLModel.Rows.DefaultSize = 19;
            this.fgrid_MLModel.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_MLModel.Size = new System.Drawing.Size(491, 136);
            this.fgrid_MLModel.StyleInfo = resources.GetString("fgrid_MLModel.StyleInfo");
            this.fgrid_MLModel.TabIndex = 47;
            this.fgrid_MLModel.Click += new System.EventHandler(this.fgrid_MLModel_Click);
            // 
            // pnl_MLLeftBodySearch
            // 
            this.pnl_MLLeftBodySearch.Controls.Add(this.panel2);
            this.pnl_MLLeftBodySearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MLLeftBodySearch.Location = new System.Drawing.Point(0, 0);
            this.pnl_MLLeftBodySearch.Name = "pnl_MLLeftBodySearch";
            this.pnl_MLLeftBodySearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_MLLeftBodySearch.Size = new System.Drawing.Size(491, 95);
            this.pnl_MLLeftBodySearch.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.cmb_MLMFactory);
            this.panel2.Controls.Add(this.lbl_MLMYear);
            this.panel2.Controls.Add(this.lbl_MLMFactory);
            this.panel2.Controls.Add(this.cmb_MLMYear);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.lbl_SubTitle3);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 87);
            this.panel2.TabIndex = 19;
            // 
            // cmb_MLMFactory
            // 
            this.cmb_MLMFactory.AddItemSeparator = ';';
            this.cmb_MLMFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MLMFactory.Caption = "";
            this.cmb_MLMFactory.CaptionHeight = 17;
            this.cmb_MLMFactory.CaptionStyle = style33;
            this.cmb_MLMFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MLMFactory.ColumnCaptionHeight = 18;
            this.cmb_MLMFactory.ColumnFooterHeight = 18;
            this.cmb_MLMFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MLMFactory.ContentHeight = 17;
            this.cmb_MLMFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MLMFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MLMFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLMFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MLMFactory.EditorHeight = 17;
            this.cmb_MLMFactory.EvenRowStyle = style34;
            this.cmb_MLMFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLMFactory.FooterStyle = style35;
            this.cmb_MLMFactory.HeadingStyle = style36;
            this.cmb_MLMFactory.HighLightRowStyle = style37;
            this.cmb_MLMFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MLMFactory.Images"))));
            this.cmb_MLMFactory.ItemHeight = 15;
            this.cmb_MLMFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_MLMFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_MLMFactory.MaxDropDownItems = ((short)(5));
            this.cmb_MLMFactory.MaxLength = 32767;
            this.cmb_MLMFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MLMFactory.Name = "cmb_MLMFactory";
            this.cmb_MLMFactory.OddRowStyle = style38;
            this.cmb_MLMFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MLMFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MLMFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MLMFactory.SelectedStyle = style39;
            this.cmb_MLMFactory.Size = new System.Drawing.Size(210, 21);
            this.cmb_MLMFactory.Style = style40;
            this.cmb_MLMFactory.TabIndex = 46;
            this.cmb_MLMFactory.SelectedValueChanged += new System.EventHandler(this.cmb_MLMFactory_SelectedValueChanged);
            this.cmb_MLMFactory.PropBag = resources.GetString("cmb_MLMFactory.PropBag");
            // 
            // lbl_MLMYear
            // 
            this.lbl_MLMYear.ImageIndex = 0;
            this.lbl_MLMYear.ImageList = this.img_Label;
            this.lbl_MLMYear.Location = new System.Drawing.Point(10, 58);
            this.lbl_MLMYear.Name = "lbl_MLMYear";
            this.lbl_MLMYear.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLMYear.TabIndex = 47;
            this.lbl_MLMYear.Text = "Year";
            this.lbl_MLMYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MLMFactory
            // 
            this.lbl_MLMFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MLMFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MLMFactory.ImageIndex = 0;
            this.lbl_MLMFactory.ImageList = this.img_Label;
            this.lbl_MLMFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_MLMFactory.Name = "lbl_MLMFactory";
            this.lbl_MLMFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLMFactory.TabIndex = 45;
            this.lbl_MLMFactory.Text = "Factory";
            this.lbl_MLMFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_MLMYear
            // 
            this.cmb_MLMYear.AddItemSeparator = ';';
            this.cmb_MLMYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MLMYear.Caption = "";
            this.cmb_MLMYear.CaptionHeight = 17;
            this.cmb_MLMYear.CaptionStyle = style41;
            this.cmb_MLMYear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MLMYear.ColumnCaptionHeight = 18;
            this.cmb_MLMYear.ColumnFooterHeight = 18;
            this.cmb_MLMYear.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MLMYear.ContentHeight = 17;
            this.cmb_MLMYear.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MLMYear.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MLMYear.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLMYear.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MLMYear.EditorHeight = 17;
            this.cmb_MLMYear.EvenRowStyle = style42;
            this.cmb_MLMYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLMYear.FooterStyle = style43;
            this.cmb_MLMYear.HeadingStyle = style44;
            this.cmb_MLMYear.HighLightRowStyle = style45;
            this.cmb_MLMYear.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MLMYear.Images"))));
            this.cmb_MLMYear.ItemHeight = 15;
            this.cmb_MLMYear.Location = new System.Drawing.Point(111, 58);
            this.cmb_MLMYear.MatchEntryTimeout = ((long)(2000));
            this.cmb_MLMYear.MaxDropDownItems = ((short)(5));
            this.cmb_MLMYear.MaxLength = 32767;
            this.cmb_MLMYear.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MLMYear.Name = "cmb_MLMYear";
            this.cmb_MLMYear.OddRowStyle = style46;
            this.cmb_MLMYear.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MLMYear.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MLMYear.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MLMYear.SelectedStyle = style47;
            this.cmb_MLMYear.Size = new System.Drawing.Size(210, 21);
            this.cmb_MLMYear.Style = style48;
            this.cmb_MLMYear.TabIndex = 48;
            this.cmb_MLMYear.SelectedValueChanged += new System.EventHandler(this.cmb_MLMYear_SelectedValueChanged);
            this.cmb_MLMYear.PropBag = resources.GetString("cmb_MLMYear.PropBag");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(475, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 20);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(476, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 87);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(475, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 32);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(224, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(291, 32);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
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
            this.lbl_SubTitle3.Text = "      Select Model Info.";
            this.lbl_SubTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(131, 69);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(344, 18);
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(160, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(323, 87);
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(168, 87);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 231);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(491, 21);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // pnl_MLLeftBottom
            // 
            this.pnl_MLLeftBottom.Controls.Add(this.fgrid_MLLine);
            this.pnl_MLLeftBottom.Controls.Add(this.pnl_MLLeftBottomSearch);
            this.pnl_MLLeftBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_MLLeftBottom.Location = new System.Drawing.Point(0, 252);
            this.pnl_MLLeftBottom.Name = "pnl_MLLeftBottom";
            this.pnl_MLLeftBottom.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnl_MLLeftBottom.Size = new System.Drawing.Size(491, 256);
            this.pnl_MLLeftBottom.TabIndex = 0;
            // 
            // fgrid_MLLine
            // 
            this.fgrid_MLLine.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_MLLine.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_MLLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_MLLine.Location = new System.Drawing.Point(0, 78);
            this.fgrid_MLLine.Name = "fgrid_MLLine";
            this.fgrid_MLLine.Rows.DefaultSize = 19;
            this.fgrid_MLLine.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_MLLine.Size = new System.Drawing.Size(491, 178);
            this.fgrid_MLLine.StyleInfo = resources.GetString("fgrid_MLLine.StyleInfo");
            this.fgrid_MLLine.TabIndex = 47;
            this.fgrid_MLLine.Click += new System.EventHandler(this.fgrid_MLLine_Click);
            // 
            // pnl_MLLeftBottomSearch
            // 
            this.pnl_MLLeftBottomSearch.Controls.Add(this.panel4);
            this.pnl_MLLeftBottomSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MLLeftBottomSearch.Location = new System.Drawing.Point(0, 5);
            this.pnl_MLLeftBottomSearch.Name = "pnl_MLLeftBottomSearch";
            this.pnl_MLLeftBottomSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_MLLeftBottomSearch.Size = new System.Drawing.Size(491, 73);
            this.pnl_MLLeftBottomSearch.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.cmb_MLLFactory);
            this.panel4.Controls.Add(this.lbl_MLLFactory);
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Controls.Add(this.pictureBox10);
            this.panel4.Controls.Add(this.pictureBox11);
            this.panel4.Controls.Add(this.pictureBox12);
            this.panel4.Controls.Add(this.pictureBox13);
            this.panel4.Controls.Add(this.lbl_SubTitle4);
            this.panel4.Controls.Add(this.pictureBox14);
            this.panel4.Controls.Add(this.pictureBox15);
            this.panel4.Controls.Add(this.pictureBox16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(491, 65);
            this.panel4.TabIndex = 19;
            // 
            // cmb_MLLFactory
            // 
            this.cmb_MLLFactory.AddItemSeparator = ';';
            this.cmb_MLLFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MLLFactory.Caption = "";
            this.cmb_MLLFactory.CaptionHeight = 17;
            this.cmb_MLLFactory.CaptionStyle = style49;
            this.cmb_MLLFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MLLFactory.ColumnCaptionHeight = 18;
            this.cmb_MLLFactory.ColumnFooterHeight = 18;
            this.cmb_MLLFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MLLFactory.ContentHeight = 17;
            this.cmb_MLLFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MLLFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MLLFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLLFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MLLFactory.EditorHeight = 17;
            this.cmb_MLLFactory.EvenRowStyle = style50;
            this.cmb_MLLFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MLLFactory.FooterStyle = style51;
            this.cmb_MLLFactory.HeadingStyle = style52;
            this.cmb_MLLFactory.HighLightRowStyle = style53;
            this.cmb_MLLFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MLLFactory.Images"))));
            this.cmb_MLLFactory.ItemHeight = 15;
            this.cmb_MLLFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_MLLFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_MLLFactory.MaxDropDownItems = ((short)(5));
            this.cmb_MLLFactory.MaxLength = 32767;
            this.cmb_MLLFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MLLFactory.Name = "cmb_MLLFactory";
            this.cmb_MLLFactory.OddRowStyle = style54;
            this.cmb_MLLFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MLLFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MLLFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MLLFactory.SelectedStyle = style55;
            this.cmb_MLLFactory.Size = new System.Drawing.Size(219, 21);
            this.cmb_MLLFactory.Style = style56;
            this.cmb_MLLFactory.TabIndex = 30;
            this.cmb_MLLFactory.SelectedValueChanged += new System.EventHandler(this.cmb_MLLFactory_SelectedValueChanged);
            this.cmb_MLLFactory.PropBag = resources.GetString("cmb_MLLFactory.PropBag");
            // 
            // lbl_MLLFactory
            // 
            this.lbl_MLLFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MLLFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MLLFactory.ImageIndex = 0;
            this.lbl_MLLFactory.ImageList = this.img_Label;
            this.lbl_MLLFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_MLLFactory.Name = "lbl_MLLFactory";
            this.lbl_MLLFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_MLLFactory.TabIndex = 29;
            this.lbl_MLLFactory.Text = "Factory";
            this.lbl_MLLFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(475, 49);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(16, 16);
            this.pictureBox9.TabIndex = 23;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 45);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(168, 20);
            this.pictureBox10.TabIndex = 22;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(476, 24);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(15, 65);
            this.pictureBox11.TabIndex = 26;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(475, 0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(16, 32);
            this.pictureBox12.TabIndex = 21;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(224, 0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(291, 32);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
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
            this.lbl_SubTitle4.Text = "      Select Line Info.";
            this.lbl_SubTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(131, 47);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(344, 18);
            this.pictureBox14.TabIndex = 28;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(160, 24);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(323, 65);
            this.pictureBox15.TabIndex = 27;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(0, 24);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(168, 65);
            this.pictureBox16.TabIndex = 25;
            this.pictureBox16.TabStop = false;
            // 
            // obarpg_ModelMold
            // 
            this.obarpg_ModelMold.Controls.Add(this.pnl_MM);
            this.obarpg_ModelMold.Name = "obarpg_ModelMold";
            this.obarpg_ModelMold.PageVisible = false;
            this.obarpg_ModelMold.Size = new System.Drawing.Size(1000, 504);
            this.obarpg_ModelMold.Text = "Model Mold Information";
            // 
            // pnl_MM
            // 
            this.pnl_MM.Controls.Add(this.fgrid_ModelOpCd);
            this.pnl_MM.Controls.Add(this.pnl_MMBodyLeftTop);
            this.pnl_MM.Controls.Add(this.splitter4);
            this.pnl_MM.Controls.Add(this.pnl_MMTR);
            this.pnl_MM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MM.Location = new System.Drawing.Point(0, 0);
            this.pnl_MM.Name = "pnl_MM";
            this.pnl_MM.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_MM.Size = new System.Drawing.Size(1000, 504);
            this.pnl_MM.TabIndex = 38;
            // 
            // fgrid_ModelOpCd
            // 
            this.fgrid_ModelOpCd.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_ModelOpCd.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_ModelOpCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_ModelOpCd.Location = new System.Drawing.Point(8, 76);
            this.fgrid_ModelOpCd.Name = "fgrid_ModelOpCd";
            this.fgrid_ModelOpCd.Rows.DefaultSize = 19;
            this.fgrid_ModelOpCd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_ModelOpCd.Size = new System.Drawing.Size(625, 420);
            this.fgrid_ModelOpCd.StyleInfo = resources.GetString("fgrid_ModelOpCd.StyleInfo");
            this.fgrid_ModelOpCd.TabIndex = 48;
            this.fgrid_ModelOpCd.Click += new System.EventHandler(this.fgrid_ModelOpCd_Click);
            this.fgrid_ModelOpCd.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_ModelOpCd_AfterEdit);
            this.fgrid_ModelOpCd.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_ModelOpCd_BeforeEdit);
            this.fgrid_ModelOpCd.DoubleClick += new System.EventHandler(this.fgrid_ModelOpCd_DoubleClick);
            // 
            // pnl_MMBodyLeftTop
            // 
            this.pnl_MMBodyLeftTop.Controls.Add(this.pnl_MMBodyLeftTopImage);
            this.pnl_MMBodyLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MMBodyLeftTop.Location = new System.Drawing.Point(8, 8);
            this.pnl_MMBodyLeftTop.Name = "pnl_MMBodyLeftTop";
            this.pnl_MMBodyLeftTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_MMBodyLeftTop.Size = new System.Drawing.Size(625, 68);
            this.pnl_MMBodyLeftTop.TabIndex = 5;
            // 
            // pnl_MMBodyLeftTopImage
            // 
            this.pnl_MMBodyLeftTopImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.cmb_MMMold);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.lbl_MMMold);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.cmb_MMGen);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.lbl_MMGen);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.cmb_MMModel);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.lbl_MMModel);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.cmb_MMFactory);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox36);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox37);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox34);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.lbl_MMFactory);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox35);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox38);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox39);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.lbl_SubTitle7);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox41);
            this.pnl_MMBodyLeftTopImage.Controls.Add(this.pictureBox40);
            this.pnl_MMBodyLeftTopImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MMBodyLeftTopImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_MMBodyLeftTopImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_MMBodyLeftTopImage.Name = "pnl_MMBodyLeftTopImage";
            this.pnl_MMBodyLeftTopImage.Size = new System.Drawing.Size(625, 63);
            this.pnl_MMBodyLeftTopImage.TabIndex = 21;
            // 
            // cmb_MMMold
            // 
            this.cmb_MMMold.AddItemSeparator = ';';
            this.cmb_MMMold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MMMold.Caption = "";
            this.cmb_MMMold.CaptionHeight = 17;
            this.cmb_MMMold.CaptionStyle = style57;
            this.cmb_MMMold.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MMMold.ColumnCaptionHeight = 18;
            this.cmb_MMMold.ColumnFooterHeight = 18;
            this.cmb_MMMold.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MMMold.ContentHeight = 17;
            this.cmb_MMMold.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MMMold.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MMMold.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MMMold.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MMMold.EditorHeight = 17;
            this.cmb_MMMold.EvenRowStyle = style58;
            this.cmb_MMMold.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MMMold.FooterStyle = style59;
            this.cmb_MMMold.HeadingStyle = style60;
            this.cmb_MMMold.HighLightRowStyle = style61;
            this.cmb_MMMold.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MMMold.Images"))));
            this.cmb_MMMold.ItemHeight = 15;
            this.cmb_MMMold.Location = new System.Drawing.Point(448, 0);
            this.cmb_MMMold.MatchEntryTimeout = ((long)(2000));
            this.cmb_MMMold.MaxDropDownItems = ((short)(5));
            this.cmb_MMMold.MaxLength = 32767;
            this.cmb_MMMold.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MMMold.Name = "cmb_MMMold";
            this.cmb_MMMold.OddRowStyle = style62;
            this.cmb_MMMold.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MMMold.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MMMold.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MMMold.SelectedStyle = style63;
            this.cmb_MMMold.Size = new System.Drawing.Size(150, 21);
            this.cmb_MMMold.Style = style64;
            this.cmb_MMMold.TabIndex = 32;
            this.cmb_MMMold.Visible = false;
            this.cmb_MMMold.SelectedValueChanged += new System.EventHandler(this.cmb_MMMold_SelectedValueChanged);
            this.cmb_MMMold.PropBag = resources.GetString("cmb_MMMold.PropBag");
            // 
            // lbl_MMMold
            // 
            this.lbl_MMMold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MMMold.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MMMold.ImageIndex = 0;
            this.lbl_MMMold.ImageList = this.img_Label;
            this.lbl_MMMold.Location = new System.Drawing.Point(352, 0);
            this.lbl_MMMold.Name = "lbl_MMMold";
            this.lbl_MMMold.Size = new System.Drawing.Size(100, 21);
            this.lbl_MMMold.TabIndex = 31;
            this.lbl_MMMold.Text = "몰드 공정 여부";
            this.lbl_MMMold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_MMMold.Visible = false;
            // 
            // cmb_MMGen
            // 
            this.cmb_MMGen.AddItemSeparator = ';';
            this.cmb_MMGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MMGen.Caption = "";
            this.cmb_MMGen.CaptionHeight = 17;
            this.cmb_MMGen.CaptionStyle = style65;
            this.cmb_MMGen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MMGen.ColumnCaptionHeight = 18;
            this.cmb_MMGen.ColumnFooterHeight = 18;
            this.cmb_MMGen.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MMGen.ContentHeight = 17;
            this.cmb_MMGen.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MMGen.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MMGen.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MMGen.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MMGen.EditorHeight = 17;
            this.cmb_MMGen.EvenRowStyle = style66;
            this.cmb_MMGen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MMGen.FooterStyle = style67;
            this.cmb_MMGen.HeadingStyle = style68;
            this.cmb_MMGen.HighLightRowStyle = style69;
            this.cmb_MMGen.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MMGen.Images"))));
            this.cmb_MMGen.ItemHeight = 15;
            this.cmb_MMGen.Location = new System.Drawing.Point(524, 36);
            this.cmb_MMGen.MatchEntryTimeout = ((long)(2000));
            this.cmb_MMGen.MaxDropDownItems = ((short)(5));
            this.cmb_MMGen.MaxLength = 32767;
            this.cmb_MMGen.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MMGen.Name = "cmb_MMGen";
            this.cmb_MMGen.OddRowStyle = style70;
            this.cmb_MMGen.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MMGen.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MMGen.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MMGen.SelectedStyle = style71;
            this.cmb_MMGen.Size = new System.Drawing.Size(80, 21);
            this.cmb_MMGen.Style = style72;
            this.cmb_MMGen.TabIndex = 32;
            this.cmb_MMGen.SelectedValueChanged += new System.EventHandler(this.cmb_MMGen_SelectedValueChanged);
            this.cmb_MMGen.PropBag = resources.GetString("cmb_MMGen.PropBag");
            // 
            // lbl_MMGen
            // 
            this.lbl_MMGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MMGen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MMGen.ImageIndex = 0;
            this.lbl_MMGen.ImageList = this.img_SmallLabel;
            this.lbl_MMGen.Location = new System.Drawing.Point(473, 36);
            this.lbl_MMGen.Name = "lbl_MMGen";
            this.lbl_MMGen.Size = new System.Drawing.Size(50, 21);
            this.lbl_MMGen.TabIndex = 31;
            this.lbl_MMGen.Text = "Gender";
            this.lbl_MMGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_MMModel
            // 
            this.cmb_MMModel.AddItemSeparator = ';';
            this.cmb_MMModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MMModel.Caption = "";
            this.cmb_MMModel.CaptionHeight = 17;
            this.cmb_MMModel.CaptionStyle = style73;
            this.cmb_MMModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MMModel.ColumnCaptionHeight = 18;
            this.cmb_MMModel.ColumnFooterHeight = 18;
            this.cmb_MMModel.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MMModel.ContentHeight = 17;
            this.cmb_MMModel.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MMModel.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MMModel.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MMModel.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MMModel.EditorHeight = 17;
            this.cmb_MMModel.EvenRowStyle = style74;
            this.cmb_MMModel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MMModel.FooterStyle = style75;
            this.cmb_MMModel.HeadingStyle = style76;
            this.cmb_MMModel.HighLightRowStyle = style77;
            this.cmb_MMModel.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MMModel.Images"))));
            this.cmb_MMModel.ItemHeight = 15;
            this.cmb_MMModel.Location = new System.Drawing.Point(193, 36);
            this.cmb_MMModel.MatchEntryTimeout = ((long)(2000));
            this.cmb_MMModel.MaxDropDownItems = ((short)(5));
            this.cmb_MMModel.MaxLength = 32767;
            this.cmb_MMModel.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MMModel.Name = "cmb_MMModel";
            this.cmb_MMModel.OddRowStyle = style78;
            this.cmb_MMModel.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MMModel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MMModel.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MMModel.SelectedStyle = style79;
            this.cmb_MMModel.Size = new System.Drawing.Size(279, 21);
            this.cmb_MMModel.Style = style80;
            this.cmb_MMModel.TabIndex = 30;
            this.cmb_MMModel.SelectedValueChanged += new System.EventHandler(this.cmb_MMModel_SelectedValueChanged);
            this.cmb_MMModel.PropBag = resources.GetString("cmb_MMModel.PropBag");
            // 
            // lbl_MMModel
            // 
            this.lbl_MMModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MMModel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MMModel.ImageIndex = 0;
            this.lbl_MMModel.ImageList = this.img_SmallLabel;
            this.lbl_MMModel.Location = new System.Drawing.Point(142, 36);
            this.lbl_MMModel.Name = "lbl_MMModel";
            this.lbl_MMModel.Size = new System.Drawing.Size(50, 21);
            this.lbl_MMModel.TabIndex = 29;
            this.lbl_MMModel.Text = "Model";
            this.lbl_MMModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_MMFactory
            // 
            this.cmb_MMFactory.AddItemSeparator = ';';
            this.cmb_MMFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_MMFactory.Caption = "";
            this.cmb_MMFactory.CaptionHeight = 17;
            this.cmb_MMFactory.CaptionStyle = style81;
            this.cmb_MMFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_MMFactory.ColumnCaptionHeight = 18;
            this.cmb_MMFactory.ColumnFooterHeight = 18;
            this.cmb_MMFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_MMFactory.ContentHeight = 17;
            this.cmb_MMFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_MMFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_MMFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MMFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MMFactory.EditorHeight = 17;
            this.cmb_MMFactory.EvenRowStyle = style82;
            this.cmb_MMFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MMFactory.FooterStyle = style83;
            this.cmb_MMFactory.HeadingStyle = style84;
            this.cmb_MMFactory.HighLightRowStyle = style85;
            this.cmb_MMFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_MMFactory.Images"))));
            this.cmb_MMFactory.ItemHeight = 15;
            this.cmb_MMFactory.Location = new System.Drawing.Point(61, 36);
            this.cmb_MMFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_MMFactory.MaxDropDownItems = ((short)(5));
            this.cmb_MMFactory.MaxLength = 32767;
            this.cmb_MMFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_MMFactory.Name = "cmb_MMFactory";
            this.cmb_MMFactory.OddRowStyle = style86;
            this.cmb_MMFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_MMFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_MMFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_MMFactory.SelectedStyle = style87;
            this.cmb_MMFactory.Size = new System.Drawing.Size(80, 21);
            this.cmb_MMFactory.Style = style88;
            this.cmb_MMFactory.TabIndex = 14;
            this.cmb_MMFactory.SelectedValueChanged += new System.EventHandler(this.cmb_MMFactory_SelectedValueChanged);
            this.cmb_MMFactory.PropBag = resources.GetString("cmb_MMFactory.PropBag");
            // 
            // pictureBox36
            // 
            this.pictureBox36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox36.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(607, 24);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(18, 26);
            this.pictureBox36.TabIndex = 26;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox37.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
            this.pictureBox37.Location = new System.Drawing.Point(152, 47);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(625, 18);
            this.pictureBox37.TabIndex = 28;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox34.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
            this.pictureBox34.Location = new System.Drawing.Point(608, 48);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(17, 16);
            this.pictureBox34.TabIndex = 23;
            this.pictureBox34.TabStop = false;
            // 
            // lbl_MMFactory
            // 
            this.lbl_MMFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MMFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MMFactory.ImageIndex = 0;
            this.lbl_MMFactory.ImageList = this.img_SmallLabel;
            this.lbl_MMFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_MMFactory.Name = "lbl_MMFactory";
            this.lbl_MMFactory.Size = new System.Drawing.Size(50, 21);
            this.lbl_MMFactory.TabIndex = 13;
            this.lbl_MMFactory.Text = "Factory";
            this.lbl_MMFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox35.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(0, 48);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(168, 20);
            this.pictureBox35.TabIndex = 22;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox38.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
            this.pictureBox38.Location = new System.Drawing.Point(608, 0);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(21, 32);
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
            this.pictureBox39.Size = new System.Drawing.Size(625, 32);
            this.pictureBox39.TabIndex = 0;
            this.pictureBox39.TabStop = false;
            // 
            // lbl_SubTitle7
            // 
            this.lbl_SubTitle7.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle7.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle7.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle7.Image")));
            this.lbl_SubTitle7.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle7.Name = "lbl_SubTitle7";
            this.lbl_SubTitle7.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle7.TabIndex = 20;
            this.lbl_SubTitle7.Text = "      Model/ OpCd Info.";
            this.lbl_SubTitle7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox41
            // 
            this.pictureBox41.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox41.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox41.Image")));
            this.pictureBox41.Location = new System.Drawing.Point(0, 24);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(168, 63);
            this.pictureBox41.TabIndex = 25;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox40.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
            this.pictureBox40.Location = new System.Drawing.Point(168, 32);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(625, 18);
            this.pictureBox40.TabIndex = 27;
            this.pictureBox40.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter4.Location = new System.Drawing.Point(633, 8);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(9, 488);
            this.splitter4.TabIndex = 4;
            this.splitter4.TabStop = false;
            // 
            // pnl_MMTR
            // 
            this.pnl_MMTR.Controls.Add(this.fgrid_Mold);
            this.pnl_MMTR.Controls.Add(this.panel8);
            this.pnl_MMTR.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_MMTR.Location = new System.Drawing.Point(642, 8);
            this.pnl_MMTR.Name = "pnl_MMTR";
            this.pnl_MMTR.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnl_MMTR.Size = new System.Drawing.Size(350, 488);
            this.pnl_MMTR.TabIndex = 3;
            // 
            // fgrid_Mold
            // 
            this.fgrid_Mold.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Mold.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Mold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Mold.Location = new System.Drawing.Point(5, 68);
            this.fgrid_Mold.Name = "fgrid_Mold";
            this.fgrid_Mold.Rows.DefaultSize = 19;
            this.fgrid_Mold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Mold.Size = new System.Drawing.Size(345, 420);
            this.fgrid_Mold.StyleInfo = resources.GetString("fgrid_Mold.StyleInfo");
            this.fgrid_Mold.TabIndex = 49;
            this.fgrid_Mold.DoubleClick += new System.EventHandler(this.fgrid_Mold_DoubleClick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Window;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(5, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel8.Size = new System.Drawing.Size(345, 68);
            this.panel8.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Window;
            this.panel9.Controls.Add(this.txt_TypeName);
            this.panel9.Controls.Add(this.txt_MoldPart);
            this.panel9.Controls.Add(this.lbl_MoldPart);
            this.panel9.Controls.Add(this.pictureBox42);
            this.panel9.Controls.Add(this.pictureBox43);
            this.panel9.Controls.Add(this.pictureBox44);
            this.panel9.Controls.Add(this.pictureBox45);
            this.panel9.Controls.Add(this.pictureBox46);
            this.panel9.Controls.Add(this.pictureBox47);
            this.panel9.Controls.Add(this.pictureBox48);
            this.panel9.Controls.Add(this.lbl_SubTitle8);
            this.panel9.Controls.Add(this.pictureBox49);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(345, 63);
            this.panel9.TabIndex = 21;
            // 
            // txt_TypeName
            // 
            this.txt_TypeName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TypeName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_TypeName.Location = new System.Drawing.Point(161, 36);
            this.txt_TypeName.MaxLength = 60;
            this.txt_TypeName.Name = "txt_TypeName";
            this.txt_TypeName.ReadOnly = true;
            this.txt_TypeName.Size = new System.Drawing.Size(150, 21);
            this.txt_TypeName.TabIndex = 113;
            // 
            // txt_MoldPart
            // 
            this.txt_MoldPart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_MoldPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MoldPart.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_MoldPart.Location = new System.Drawing.Point(111, 36);
            this.txt_MoldPart.MaxLength = 60;
            this.txt_MoldPart.Name = "txt_MoldPart";
            this.txt_MoldPart.ReadOnly = true;
            this.txt_MoldPart.Size = new System.Drawing.Size(49, 21);
            this.txt_MoldPart.TabIndex = 112;
            // 
            // lbl_MoldPart
            // 
            this.lbl_MoldPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MoldPart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoldPart.ImageIndex = 0;
            this.lbl_MoldPart.ImageList = this.img_Label;
            this.lbl_MoldPart.Location = new System.Drawing.Point(10, 36);
            this.lbl_MoldPart.Name = "lbl_MoldPart";
            this.lbl_MoldPart.Size = new System.Drawing.Size(100, 21);
            this.lbl_MoldPart.TabIndex = 13;
            this.lbl_MoldPart.Text = "Mold";
            this.lbl_MoldPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox42
            // 
            this.pictureBox42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox42.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox42.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox42.Image")));
            this.pictureBox42.Location = new System.Drawing.Point(328, 47);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(21, 16);
            this.pictureBox42.TabIndex = 23;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox43
            // 
            this.pictureBox43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox43.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox43.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox43.Image")));
            this.pictureBox43.Location = new System.Drawing.Point(0, 43);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(168, 20);
            this.pictureBox43.TabIndex = 22;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox44.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox44.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox44.Image")));
            this.pictureBox44.Location = new System.Drawing.Point(329, 24);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(20, 63);
            this.pictureBox44.TabIndex = 26;
            this.pictureBox44.TabStop = false;
            // 
            // pictureBox45
            // 
            this.pictureBox45.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox45.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox45.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox45.Image")));
            this.pictureBox45.Location = new System.Drawing.Point(131, 45);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(345, 18);
            this.pictureBox45.TabIndex = 28;
            this.pictureBox45.TabStop = false;
            // 
            // pictureBox46
            // 
            this.pictureBox46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox46.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox46.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox46.Image")));
            this.pictureBox46.Location = new System.Drawing.Point(328, 0);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(21, 32);
            this.pictureBox46.TabIndex = 21;
            this.pictureBox46.TabStop = false;
            // 
            // pictureBox47
            // 
            this.pictureBox47.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox47.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox47.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox47.Image")));
            this.pictureBox47.Location = new System.Drawing.Point(224, 0);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(345, 32);
            this.pictureBox47.TabIndex = 0;
            this.pictureBox47.TabStop = false;
            // 
            // pictureBox48
            // 
            this.pictureBox48.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox48.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox48.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox48.Image")));
            this.pictureBox48.Location = new System.Drawing.Point(160, 24);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(345, 63);
            this.pictureBox48.TabIndex = 27;
            this.pictureBox48.TabStop = false;
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
            this.lbl_SubTitle8.Text = "      Mold Info.";
            this.lbl_SubTitle8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox49
            // 
            this.pictureBox49.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox49.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox49.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox49.Image")));
            this.pictureBox49.Location = new System.Drawing.Point(0, 24);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(168, 63);
            this.pictureBox49.TabIndex = 25;
            this.pictureBox49.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Location = new System.Drawing.Point(0, 0);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(100, 50);
            this.pictureBox24.TabIndex = 0;
            this.pictureBox24.TabStop = false;
            // 
            // c1Combo1
            // 
            this.c1Combo1.AddItemSeparator = ';';
            this.c1Combo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1Combo1.Caption = "";
            this.c1Combo1.CaptionHeight = 17;
            this.c1Combo1.CaptionStyle = style89;
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.ColumnCaptionHeight = 18;
            this.c1Combo1.ColumnFooterHeight = 18;
            this.c1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.c1Combo1.ContentHeight = 17;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.EditorHeight = 17;
            this.c1Combo1.EvenRowStyle = style90;
            this.c1Combo1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo1.FooterStyle = style91;
            this.c1Combo1.HeadingStyle = style92;
            this.c1Combo1.HighLightRowStyle = style93;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.ItemHeight = 15;
            this.c1Combo1.Location = new System.Drawing.Point(111, 36);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(5));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.OddRowStyle = style94;
            this.c1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.SelectedStyle = style95;
            this.c1Combo1.Size = new System.Drawing.Size(210, 21);
            this.c1Combo1.Style = style96;
            this.c1Combo1.TabIndex = 36;
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            // 
            // pictureBox58
            // 
            this.pictureBox58.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox58.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox58.Image")));
            this.pictureBox58.Location = new System.Drawing.Point(334, 24);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(15, 155);
            this.pictureBox58.TabIndex = 26;
            this.pictureBox58.TabStop = false;
            // 
            // pictureBox59
            // 
            this.pictureBox59.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox59.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox59.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox59.Image")));
            this.pictureBox59.Location = new System.Drawing.Point(333, 0);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(16, 32);
            this.pictureBox59.TabIndex = 21;
            this.pictureBox59.TabStop = false;
            // 
            // pictureBox60
            // 
            this.pictureBox60.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox60.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox60.Image")));
            this.pictureBox60.Location = new System.Drawing.Point(216, 0);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(351, 40);
            this.pictureBox60.TabIndex = 0;
            this.pictureBox60.TabStop = false;
            // 
            // pictureBox61
            // 
            this.pictureBox61.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox61.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox61.Image")));
            this.pictureBox61.Location = new System.Drawing.Point(160, 24);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(349, 155);
            this.pictureBox61.TabIndex = 27;
            this.pictureBox61.TabStop = false;
            // 
            // pictureBox62
            // 
            this.pictureBox62.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox62.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox62.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox62.Image")));
            this.pictureBox62.Location = new System.Drawing.Point(333, 179);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(16, 16);
            this.pictureBox62.TabIndex = 23;
            this.pictureBox62.TabStop = false;
            // 
            // pictureBox63
            // 
            this.pictureBox63.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox63.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox63.Image")));
            this.pictureBox63.Location = new System.Drawing.Point(144, 177);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(349, 18);
            this.pictureBox63.TabIndex = 24;
            this.pictureBox63.TabStop = false;
            // 
            // pictureBox64
            // 
            this.pictureBox64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox64.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox64.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox64.Image")));
            this.pictureBox64.Location = new System.Drawing.Point(0, 175);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(168, 20);
            this.pictureBox64.TabIndex = 22;
            this.pictureBox64.TabStop = false;
            // 
            // pictureBox65
            // 
            this.pictureBox65.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox65.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox65.Image")));
            this.pictureBox65.Location = new System.Drawing.Point(0, 24);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(168, 155);
            this.pictureBox65.TabIndex = 25;
            this.pictureBox65.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Window;
            this.panel10.Controls.Add(this.textBox1);
            this.panel10.Controls.Add(this.textBox2);
            this.panel10.Controls.Add(this.textBox3);
            this.panel10.Controls.Add(this.textBox4);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.textBox5);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.textBox6);
            this.panel10.Controls.Add(this.textBox7);
            this.panel10.Controls.Add(this.textBox8);
            this.panel10.Controls.Add(this.textBox9);
            this.panel10.Controls.Add(this.textBox10);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.pictureBox50);
            this.panel10.Controls.Add(this.pictureBox51);
            this.panel10.Controls.Add(this.pictureBox52);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Controls.Add(this.pictureBox53);
            this.panel10.Controls.Add(this.pictureBox54);
            this.panel10.Controls.Add(this.pictureBox55);
            this.panel10.Controls.Add(this.pictureBox56);
            this.panel10.Controls.Add(this.pictureBox57);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(349, 175);
            this.panel10.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.textBox1.Location = new System.Drawing.Point(177, 102);
            this.textBox1.MaxLength = 60;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 21);
            this.textBox1.TabIndex = 108;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.textBox2.Location = new System.Drawing.Point(177, 80);
            this.textBox2.MaxLength = 60;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(153, 21);
            this.textBox2.TabIndex = 107;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.textBox3.Location = new System.Drawing.Point(111, 80);
            this.textBox3.MaxLength = 60;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(65, 21);
            this.textBox3.TabIndex = 106;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.textBox4.Location = new System.Drawing.Point(111, 124);
            this.textBox4.MaxLength = 60;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 21);
            this.textBox4.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageIndex = 0;
            this.label7.ImageList = this.img_Label;
            this.label7.Location = new System.Drawing.Point(10, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 104;
            this.label7.Text = "표시순번";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.textBox5.Location = new System.Drawing.Point(111, 102);
            this.textBox5.MaxLength = 60;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(65, 21);
            this.textBox5.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageIndex = 0;
            this.label8.ImageList = this.img_Label;
            this.label8.Location = new System.Drawing.Point(10, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 102;
            this.label8.Text = "몰드코드";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.ImageIndex = 0;
            this.label9.ImageList = this.img_MiniButton;
            this.label9.Location = new System.Drawing.Point(331, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 21);
            this.label9.TabIndex = 101;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.ImageIndex = 0;
            this.label10.ImageList = this.img_Label;
            this.label10.Location = new System.Drawing.Point(10, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 99;
            this.label10.Text = "몰드유형";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.textBox6.Location = new System.Drawing.Point(177, 58);
            this.textBox6.MaxLength = 60;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(153, 21);
            this.textBox6.TabIndex = 98;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.textBox7.Location = new System.Drawing.Point(111, 58);
            this.textBox7.MaxLength = 60;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(65, 21);
            this.textBox7.TabIndex = 97;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.textBox8.Location = new System.Drawing.Point(177, 36);
            this.textBox8.MaxLength = 60;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(153, 21);
            this.textBox8.TabIndex = 96;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Window;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.textBox9.Location = new System.Drawing.Point(111, 146);
            this.textBox9.MaxLength = 60;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(210, 21);
            this.textBox9.TabIndex = 94;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.textBox10.Location = new System.Drawing.Point(111, 36);
            this.textBox10.MaxLength = 60;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(65, 21);
            this.textBox10.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.ImageIndex = 0;
            this.label11.ImageList = this.img_Label;
            this.label11.Location = new System.Drawing.Point(10, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 41;
            this.label11.Text = "비고";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.ImageIndex = 0;
            this.label12.ImageList = this.img_Label;
            this.label12.Location = new System.Drawing.Point(10, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 21);
            this.label12.TabIndex = 39;
            this.label12.Text = "반제품목";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.ImageIndex = 0;
            this.label13.ImageList = this.img_Label;
            this.label13.Location = new System.Drawing.Point(10, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 21);
            this.label13.TabIndex = 38;
            this.label13.Text = "모델";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox50
            // 
            this.pictureBox50.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox50.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox50.Image")));
            this.pictureBox50.Location = new System.Drawing.Point(334, 24);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(15, 135);
            this.pictureBox50.TabIndex = 26;
            this.pictureBox50.TabStop = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox51.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox51.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox51.Image")));
            this.pictureBox51.Location = new System.Drawing.Point(333, 0);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(16, 32);
            this.pictureBox51.TabIndex = 21;
            this.pictureBox51.TabStop = false;
            // 
            // pictureBox52
            // 
            this.pictureBox52.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox52.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox52.Image")));
            this.pictureBox52.Location = new System.Drawing.Point(216, 0);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(351, 40);
            this.pictureBox52.TabIndex = 0;
            this.pictureBox52.TabStop = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 30);
            this.label14.TabIndex = 20;
            this.label14.Text = "      Display Select Info.";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox53
            // 
            this.pictureBox53.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox53.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox53.Image")));
            this.pictureBox53.Location = new System.Drawing.Point(160, 24);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(349, 135);
            this.pictureBox53.TabIndex = 27;
            this.pictureBox53.TabStop = false;
            // 
            // pictureBox54
            // 
            this.pictureBox54.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox54.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox54.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox54.Image")));
            this.pictureBox54.Location = new System.Drawing.Point(333, 159);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(16, 16);
            this.pictureBox54.TabIndex = 23;
            this.pictureBox54.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox55.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox55.Image")));
            this.pictureBox55.Location = new System.Drawing.Point(144, 157);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(349, 18);
            this.pictureBox55.TabIndex = 24;
            this.pictureBox55.TabStop = false;
            // 
            // pictureBox56
            // 
            this.pictureBox56.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox56.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox56.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox56.Image")));
            this.pictureBox56.Location = new System.Drawing.Point(0, 155);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(168, 20);
            this.pictureBox56.TabIndex = 22;
            this.pictureBox56.TabStop = false;
            // 
            // pictureBox57
            // 
            this.pictureBox57.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox57.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox57.Image")));
            this.pictureBox57.Location = new System.Drawing.Point(0, 24);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(168, 135);
            this.pictureBox57.TabIndex = 25;
            this.pictureBox57.TabStop = false;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Body.Controls.Add(this.obar_Main);
            this.pnl_Body.Location = new System.Drawing.Point(0, 56);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pnl_Body.Size = new System.Drawing.Size(1016, 584);
            this.pnl_Body.TabIndex = 29;
            // 
            // Form_PB_Model
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Body);
            this.Name = "Form_PB_Model";
            this.Text = "Model Information";
            this.Load += new System.EventHandler(this.Form_PB_Model_Load);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
            this.obar_Main.ResumeLayout(false);
            this.obarpg_Model.ResumeLayout(false);
            this.pnl_MBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MModelDetail)).EndInit();
            this.pnl_MR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkRout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeRout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BomNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BomLink)).EndInit();
            this.pnl_MBodyRightTop.ResumeLayout(false);
            this.pnl_SearchSplitRight.ResumeLayout(false);
            this.pnl_SearchRightImage.ResumeLayout(false);
            this.pnl_SearchRightImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MDYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_RML)).EndInit();
            this.obarpg_ModelLine.ResumeLayout(false);
            this.pnl_MLBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_ModelLine)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            this.pnl_MLLeft.ResumeLayout(false);
            this.pnl_MLLeftBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MLModel)).EndInit();
            this.pnl_MLLeftBodySearch.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLMFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLMYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.pnl_MLLeftBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MLLine)).EndInit();
            this.pnl_MLLeftBottomSearch.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MLLFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.obarpg_ModelMold.ResumeLayout(false);
            this.pnl_MM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_ModelOpCd)).EndInit();
            this.pnl_MMBodyLeftTop.ResumeLayout(false);
            this.pnl_MMBodyLeftTopImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MMMold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MMGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MMModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MMFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            this.pnl_MMTR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

	 
		#region 변수 정의
    

		private COM.OraDB MyOraDB = new COM.OraDB();

		private DataTable HeadDT = new DataTable("HeadTitle");

		//노드 수 -> 공정에 링크 그릴때 필요
		private int _Node_Count = 0; 
		//새로 그려지는 공정 노드 수
		private int _Op_Count = 0;
		
		private int _Rowfixed; 

		#endregion  

		#region 멤버 메서드 
  

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			DataTable dt_ret;
			DataRow datarow;


			//Title
			this.Text = "Model Information";
			this.lbl_MainTitle.Text = "Model Information"; 


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


//			cmb_MFactory.Enabled = false; 
//			cmb_MLMFactory.Enabled = false; 
//			cmb_MLLFactory.Enabled = false;
//			cmb_MLFactory.Enabled = false;
//			cmb_MMFactory.Enabled = false;
// 
  
 

			// 모델정보 
			fgrid_MModelDetail.Set_Grid("SPB_MODEL_CODE", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);  
			fgrid_MModelDetail.Set_Action_Image(img_Action);
 	 
			ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
 
			fgrid_BOM.Set_Grid("STANDARD_BOM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_BOM.ExtendLastCol = true;
			fgrid_BOM.Tree.Column = 1;  
			_Rowfixed = fgrid_BOM.Rows.Fixed;

			//숨겨진 그리드 세팅 
			fgrid_BomNode.Set_Grid("NODE_BOM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_BomLink.Set_Grid("LINK_BOM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_NodeRout.Set_Grid("NODE_ROUT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_LinkRout.Set_Grid("LINK_ROUT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);

 
			// 모델 라인 정보 
			fgrid_MLModel.Set_Grid("SPB_MODEL_CODE", "3", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
			fgrid_MLLine.Set_Grid("SPB_LINE_CODE", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  
			fgrid_ModelLine.Set_Grid("SPB_MODEL_LINE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);  
			fgrid_ModelLine.Set_Action_Image(img_Action); 

 
			// 모델 몰드 정보 
			fgrid_ModelOpCd.Set_Grid("SPB_MODEL_OPCD", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			fgrid_ModelOpCd.Set_Action_Image(img_Action);
			fgrid_Mold.Set_Grid("SPB_DT_MOLD", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 


			//-------------------------------------------------------
			//첫번째 행 헤더 정보 저장 (실제 디비 필드명)
  
			for(int i = 0; i < fgrid_ModelOpCd.Cols.Count; i++)
			{
				HeadDT.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			} 

			datarow = HeadDT.NewRow();
				 
			for(int i = 1; i < fgrid_ModelOpCd.Cols.Count; i++)
			{ 
				datarow[i] = "ARG_" + fgrid_ModelOpCd[0, i].ToString(); 

				//첫번째 행에 두번째 행 정보 저장 (그리드 타이틀)
				fgrid_ModelOpCd[0, i] = fgrid_ModelOpCd[1, i].ToString();
			} 
			 
			HeadDT.Rows.Add(datarow);

			fgrid_ModelOpCd.Rows[0].Visible = true;
			fgrid_ModelOpCd.Rows[1].Visible = false;

			//------------------------------------------------------- 
			dt_ret = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLMFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLLFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MMFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
 
			cmb_MFactory.SelectedValue = ClassLib.ComVar.This_Factory;   
			cmb_MFactory.SelectedValue = ClassLib.ComVar.This_Factory; 
			cmb_MLMFactory.SelectedValue = ClassLib.ComVar.This_Factory;  
			cmb_MMFactory.SelectedValue = ClassLib.ComVar.This_Factory;  


			 
			// 모델 연도 세팅
			dt_ret = Select_Model_Year(); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MDYear, 0, 0, true, COM.ComVar.ComboList_Visible.Code); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLMYear, 0, 0, false, COM.ComVar.ComboList_Visible.Code); 
 

			// Yes/No 세팅
			dt_ret = MyOraDB.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxYesNo); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MMMold, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
			cmb_MMMold.SelectedValue = "Y";


			if(COM.ComVar.Model_ModelCd != "")
				obar_Main.SelectedPage = obarpg_ModelMold;  
			else
				obar_Main.SelectedPage = obarpg_Model; 


			 

		}

 


		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			if(arg_dt == null) return;

			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;  
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = "";
			} 

			arg_fgrid.AutoSizeCols();
		}
 

		#endregion 

		#region 이벤트 처리  
		

		#region 공통 이벤트 

		private void obar_Main_SelectedPageChanged(object sender, System.EventArgs e)
		{
 
			switch(obar_Main.SelectedPage.Name)
			{
				 
				case "obarpg_Model": 

					tbtn_Append.Enabled = false;
					tbtn_Insert.Enabled = false;
 						  
					break;

				case "obarpg_ModelLine": 
					 
					tbtn_Append.Enabled = false;
					tbtn_Insert.Enabled = false;
 							  
					break;

				case "obarpg_ModelMold":
 
					tbtn_Append.Enabled = false;
					tbtn_Insert.Enabled = false;
					 
					break;


			}
		}


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Model": 
					//cmb_MFactory.SelectedIndex = -1;
					//cmb_MDYear.SelectedIndex = -1; 

					txt_MDModel.Text = "";
					fgrid_MModelDetail.Rows.Count = fgrid_MModelDetail.Rows.Fixed;

					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);

					break;

				case "obarpg_ModelLine": 
					 
					//cmb_MLMFactory.SelectedIndex = -1;
					//cmb_MLMYear.SelectedIndex = -1;
					//cmb_MLLFactory.SelectedIndex = -1;
					//cmb_MLFactory.SelectedIndex = -1;
					//cmb_MLModel.SelectedIndex = -1; 

					//fgrid_MLModel.Rows.Count = fgrid_MLModel.Rows.Fixed;
					//fgrid_MLLine.Rows.Count = fgrid_MLLine.Rows.Fixed;
					fgrid_ModelLine.Rows.Count = fgrid_ModelLine.Rows.Fixed;

					txt_MLModelCd.Text = "";
					txt_MLModelName.Text = "";
					txt_MLLineCd.Text = "";
					txt_MLLineName.Text = ""; 
					txt_MLLineSeq.Text = ""; 
					txt_MLAloRate.Text = "";
					txt_MLRemarks.Text = "";

					break;
					
				case "obarpg_ModelMold": 
				 
					//cmb_MMFactory.SelectedIndex = -1;
					//cmb_MMModel.SelectedIndex = -1;
					//cmb_MMMold.SelectedIndex = -1;

					fgrid_ModelOpCd.Rows.Count = fgrid_ModelOpCd.Rows.Fixed;
					fgrid_Mold.Rows.Count = fgrid_Mold.Rows.Fixed;

					txt_MoldPart.Text = "";
					txt_TypeName.Text = "";



					break;


			}
 
		}



		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Model": 

					if(cmb_MFactory.SelectedIndex == -1 || cmb_MDYear.SelectedIndex == -1) return;
					  
					dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
						ClassLib.ComFunction.Empty_Combo(cmb_MDYear, " "));
					Display_Grid(dt_ret, fgrid_MModelDetail);

					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);

					break;
 

				case "obarpg_ModelLine":  

					if(cmb_MLFactory.SelectedIndex == -1 && cmb_MLModel.SelectedIndex == -1) return;
					 
					dt_ret = Select_Model_Line();
					Display_Grid(dt_ret, fgrid_ModelLine);

					txt_MLModelCd.Text = "";
					txt_MLModelName.Text = "";
					txt_MLLineCd.Text = "";
					txt_MLLineName.Text = ""; 
					txt_MLLineSeq.Text = ""; 
					txt_MLAloRate.Text = "";
					txt_MLRemarks.Text = ""; 

					break;
				
				case "obarpg_ModelMold": 
					
					if(cmb_MMFactory.SelectedIndex == -1 || cmb_MMModel.SelectedIndex == -1 || cmb_MMGen.SelectedIndex == -1) return;
 
					dt_ret = Select_ModelOpCd_List();  
					Display_TreeGrid(dt_ret, fgrid_ModelOpCd);

					break; 

			}
		}



		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Model": 
					//행 수정 상태 해제
					fgrid_MModelDetail.Select(fgrid_MModelDetail.Selection.r1, 0, fgrid_MModelDetail.Selection.r1, fgrid_MModelDetail.Cols.Count-1, false);
  
//					for(int i = fgrid_MModelDetail.Rows.Fixed; i < fgrid_MModelDetail.Rows.Count; i++)
//					{
//						if(fgrid_MModelDetail[i, (int)ClassLib.TBSPB_MODEL.IxBOM_CD] == null || fgrid_MModelDetail[i, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString() == "") 
//						{
//							ClassLib.ComFunction.Data_Message("BOM Code", ClassLib.ComVar.MgsDoNotSave, this);
//							return;
//						}
//					}

//					MyOraDB.Save_FlexGird("PKG_SPB_MODEL_BSC.SAVE_SPB_MODEL", fgrid_MModelDetail);
//
//					dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
//						ClassLib.ComFunction.Empty_Combo(cmb_MDYear, " "));
//					Display_Grid(dt_ret, fgrid_MModelDetail);


					string message_text = "Do you want to apply on MPS LOT ?";
					DialogResult message = ClassLib.ComFunction.User_Message(message_text, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

					bool save_flag = false;






					if(message == DialogResult.Yes)
					{
						save_flag = Save_SPB_MODEL_WITH_MPS_LOT();  
					}
					else
					{
						save_flag = MyOraDB.Save_FlexGird("PKG_SPB_MODEL_BSC.SAVE_SPB_MODEL", fgrid_MModelDetail);
					}


					



					string factory = ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " ");
					string style_cd  = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ");

					if(save_flag)
					{
						dt_ret = Select_Model_List_Style(factory, style_cd);
						Display_Grid(dt_ret, fgrid_MModelDetail);

						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
					}
					else
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					}


					break;

				case "obarpg_ModelLine":  
					//행 수정 상태 해제
					fgrid_ModelLine.Select(fgrid_ModelLine.Selection.r1, 0, fgrid_ModelLine.Selection.r1, fgrid_ModelLine.Cols.Count-1, false);
					  
					MyOraDB.Save_FlexGird("PKG_SPB_MODEL_BSC.SAVE_MODEL_LINE", fgrid_ModelLine); 

					dt_ret = Select_Model_Line();
					Display_Grid(dt_ret, fgrid_ModelLine);
					
					//					txt_MLModelCd.Text = "";
					//					txt_MLModelName.Text = "";
					//					txt_MLLineCd.Text = "";
					//					txt_MLLineName.Text = ""; 
					//					txt_MLLineSeq.Text = ""; 
					//					txt_MLAloRate.Text = "";
					//					txt_MLRemarks.Text = "";

					break;
					
				case "obarpg_ModelMold": 
					
					int sel_row = fgrid_ModelOpCd.Selection.r1;
					//
					//					//행 수정 상태 해제
					fgrid_ModelOpCd.Select(fgrid_ModelOpCd.Selection.r1, 0, fgrid_ModelOpCd.Selection.r1, fgrid_ModelOpCd.Cols.Count-1, false);
					// 
					//					Save_ModelOpMold();
					//
					//					tbtn_Search_Click(null, null);
					//
					//					fgrid_ModelOpCd.TopRow = sel_row;
					// 
					//					x 




					Delete_Model_Opmold();

					for(int i=_Rowfixed; i<fgrid_ModelOpCd.Rows.Count; i++)
					{
						if(fgrid_ModelOpCd[i, 12].ToString().Trim() != "")
						{
							string[] arraylist = new string[12];

							arraylist[0] = fgrid_ModelOpCd[i, 0].ToString();
							arraylist[1] = fgrid_ModelOpCd[i, 16].ToString();
							arraylist[2] = fgrid_ModelOpCd[i, 9].ToString();
							arraylist[3] = fgrid_ModelOpCd[i, 17].ToString();
							arraylist[4] = fgrid_ModelOpCd[i, 10].ToString();
							arraylist[5] = fgrid_ModelOpCd[i, 11].ToString();
							arraylist[6] = fgrid_ModelOpCd[i, 6].ToString();
							arraylist[7] = fgrid_ModelOpCd[i, 12].ToString();
							arraylist[8] = fgrid_ModelOpCd[i, 13].ToString();
							arraylist[9] = fgrid_ModelOpCd[i, 14].ToString();
							arraylist[10]= fgrid_ModelOpCd[i, 15].ToString();
							arraylist[11]= ClassLib.ComVar.This_User;
							
						
							Save_Model_Opmold(arraylist);
						}

						
					}


					//Save_ModelOpMold();

					tbtn_Search_Click(null, null);

					fgrid_ModelOpCd.TopRow = sel_row;

					break;


			} 
		}



		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Model": 
								  
					break;

				case "obarpg_ModelMold": 
					 
					break;


				case "obarpg_ModelLine":  

					break;
			}
		}



		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Model": 
								  
					break;

				case "obarpg_ModelMold": 
					 
					break;


				case "obarpg_ModelLine":  

					break;
			}
		}



		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Model": 
					fgrid_MModelDetail.Delete_Row(); 			  
					break;

				
				case "obarpg_ModelLine":  
					fgrid_ModelLine.Delete_Row(); 
					break;

				case "obarpg_ModelMold":
					fgrid_ModelOpCd.Delete_Row();
					break;


			}
		}


		#endregion

		#region 모델정보
 
		
		private void cmb_MFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_MFactory.SelectedIndex == -1) return;
			 


			// 공장별 BOM code list
			Set_BOM_Code(); 


			//cmb_MDYear.SelectedIndex = 0;   
		}

 

		private void cmb_MDYear_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			if(cmb_MFactory.SelectedIndex == -1) return;     // || cmb_MDYear.SelectedIndex == -1

			for(int i = fgrid_MModelDetail.Rows.Fixed; i < fgrid_MModelDetail.Rows.Count; i++)
			{
				if(fgrid_MModelDetail[i, 0].ToString() == "I" || fgrid_MModelDetail[i, 0].ToString() == "U") 
				{
					//MessageBox.Show("저장되지 않은 데이터가 있습니다");
					return;
				}
			}
			 
			dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
				ClassLib.ComFunction.Empty_Combo(cmb_MDYear, " "));
			Display_Grid(dt_ret, fgrid_MModelDetail);
			 
		}


 
 
		private void fgrid_MModelDetail_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_MModelDetail.Rows.Fixed > 0) && (fgrid_MModelDetail.Row >= fgrid_MModelDetail.Rows.Fixed))
			{
				if(fgrid_MModelDetail.Cols[fgrid_MModelDetail.Col].DataType != typeof(string))
				{
					fgrid_MModelDetail.Buffer_CellData = "";
				}
				else
				{
					fgrid_MModelDetail.Buffer_CellData = (fgrid_MModelDetail[fgrid_MModelDetail.Row, fgrid_MModelDetail.Col] == null) ? "" : fgrid_MModelDetail[fgrid_MModelDetail.Row, fgrid_MModelDetail.Col].ToString();
				}

 

			} // end if rows.fixed

		}

		 
	 


		private void fgrid_MModelDetail_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_MModelDetail[e.Row, e.Col] = (fgrid_MModelDetail[e.Row, e.Col].ToString() == "") ? fgrid_MModelDetail.Buffer_CellData : fgrid_MModelDetail[e.Row, e.Col].ToString();
			fgrid_MModelDetail.Update_Row();  
			fgrid_MModelDetail.AutoSizeCols();
		}


		private void txt_MDModel_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			DataTable dt_ret;

			try
			{
				//13 : enter
				if(e.KeyChar == (char)13) 
				{
					txt_MDModel.Text = txt_MDModel.Text.ToUpper();

					if(cmb_MFactory.SelectedIndex == -1 || cmb_MDYear.SelectedIndex == -1) return;
					  
					dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
						ClassLib.ComFunction.Empty_Combo(cmb_MDYear, " "));
					Display_Grid(dt_ret, fgrid_MModelDetail);

					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);

				}
			}
			catch
			{
			}
		}

		


		
		private void txt_StyleCd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			DataTable dt_ret;

			try
			{
				//13 : enter
				if(e.KeyChar == (char)13) 
				{
					 
					if(cmb_MFactory.SelectedIndex == -1) return;
					  
					dt_ret = Select_Model_List_Style(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
						                             ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "") );
					
					Display_Grid(dt_ret, fgrid_MModelDetail);

					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);

				}
			}
			catch
			{
			}
		}



		#endregion

		#region 모델 라인 정보
 
		private void cmb_MLMFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			cmb_MLLFactory.SelectedIndex = cmb_MLMFactory.SelectedIndex;
			cmb_MLFactory.SelectedIndex = cmb_MLMFactory.SelectedIndex;
		}


		private void cmb_MLMYear_SelectedValueChanged(object sender, System.EventArgs e)
		{ 
			DataTable dt_ret;

			if(cmb_MLMFactory.SelectedIndex == -1 || cmb_MLMYear.SelectedIndex == -1) return;
			  
			dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MLMFactory, " "),
				ClassLib.ComFunction.Empty_Combo(cmb_MLMYear, " "));
			Display_Grid(dt_ret, fgrid_MLModel);

		}

		

		private void cmb_MLLFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			cmb_MLMFactory.SelectedIndex = cmb_MLLFactory.SelectedIndex;
			cmb_MLFactory.SelectedIndex = cmb_MLLFactory.SelectedIndex;

			if(cmb_MLLFactory.SelectedIndex == -1) return; 

			dt_ret = Select_Line_List();
			Display_Grid(dt_ret, fgrid_MLLine);


		}


		private void cmb_MLFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			cmb_MLMFactory.SelectedIndex = cmb_MLFactory.SelectedIndex;
			cmb_MLLFactory.SelectedIndex = cmb_MLFactory.SelectedIndex;

			if(cmb_MLFactory.SelectedIndex == -1) return;
			 
			dt_ret = Select_Model_CmbList(cmb_MLFactory.SelectedValue.ToString());

			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLModel, 0, 1, false);
			 
		}
		
		 
		private void cmb_MLModel_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			if(cmb_MLFactory.SelectedIndex == -1 || cmb_MLModel.SelectedIndex == -1) return;
			 
			dt_ret = Select_Model_Line();
			Display_Grid(dt_ret, fgrid_ModelLine);
			  
		}

		 

		private void fgrid_MLModel_Click(object sender, System.EventArgs e)
		{
			if(fgrid_MLModel.Rows.Count <= fgrid_MLLine.Rows.Fixed) return;

			txt_MLModelCd.Text = "";
			txt_MLModelName.Text = "";

			txt_MLModelCd.Text = fgrid_MLModel[fgrid_MLModel.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxMODEL_CD].ToString();
			txt_MLModelName.Text = fgrid_MLModel[fgrid_MLModel.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxMODEL_NAME].ToString();

			//if(cmb_MLModel.SelectedIndex != -1) return;

			for(int i = fgrid_ModelLine.Rows.Fixed; i < fgrid_ModelLine.Rows.Count; i++)
			{
				if(fgrid_ModelLine[i, 0].ToString() == "I" || fgrid_ModelLine[i, 0].ToString() == "U") 
				{
					//MessageBox.Show("저장되지 않은 데이터가 있습니다");
					return;
				}
			}

			 
			cmb_MLModel.SelectedValue = txt_MLModelCd.Text;
			 

		}

  
		
		private void fgrid_MLLine_Click(object sender, System.EventArgs e)
		{
			if(fgrid_MLLine.Rows.Count <= fgrid_MLLine.Rows.Fixed) return;

			txt_MLLineCd.Text = "";
			txt_MLLineName.Text = "";

			txt_MLLineCd.Text = fgrid_MLLine[fgrid_MLLine.Selection.r1, (int)ClassLib.TBSPB_LINE.IxLINE_CD].ToString();
			txt_MLLineName.Text = fgrid_MLLine[fgrid_MLLine.Selection.r1, (int)ClassLib.TBSPB_LINE.IxLINE_NAME].ToString();
 
		}
 

		private void btn_AppendRow_Click(object sender, System.EventArgs e)
		{
			int i;

			if(cmb_MLFactory.SelectedIndex == -1 || cmb_MLModel.SelectedIndex == -1) return;

					
			//			if(txt_MLModelCd.Text != cmb_MLModel.SelectedValue.ToString())
			//			{
			//				MessageBox.Show("모델코드 불일치");
			//				return;
			//			}
			
			//			if(Convert.ToInt32(fgrid_MLModel[fgrid_MLModel.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxLINE_QTY].ToString())
			//				== fgrid_ModelLine.Rows.Count - fgrid_ModelLine.Rows.Fixed)
			//			{
			//				MessageBox.Show("할당 가능 제조라인수 초과"); 
			//
			//				txt_MLModelCd.Text = "";
			//				txt_MLModelName.Text = "";
			//				txt_MLLineCd.Text = "";
			//				txt_MLLineName.Text = ""; 
			//				txt_MLLineSeq.Text = ""; 
			//				txt_MLAloRate.Text = "";
			//				txt_MLRemarks.Text = "";
			//
			//				return;
			//			}
			
			if(txt_MLLineSeq.Text == "")
			{
				ClassLib.ComFunction.Data_Message("Line Priority", ClassLib.ComVar.MgsWrongInput, this);
				return;
			}


			for(i = fgrid_MLLine.Rows.Fixed; i < fgrid_ModelLine.Rows.Count; i++)
			{
 
				if(txt_MLLineSeq.Text == fgrid_ModelLine[i, (int)ClassLib.TBSPB_MODEL_LINE.IxLINE_SEQ].ToString())
				{
					MessageBox.Show("Duplicate Line Priority");
					txt_MLLineSeq.Text = "";
					return;
				}
			}

			fgrid_ModelLine.Add_Row(fgrid_ModelLine.Rows.Count - 1);
			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxFACTORY] = cmb_MLFactory.SelectedValue.ToString();
			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxMODEL_CD] = txt_MLModelCd.Text;
			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxLINE_SEQ] = txt_MLLineSeq.Text;
			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxLINE_CD] = txt_MLLineCd.Text;
			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxALO_RATE] = (txt_MLAloRate.Text == "") ? "" : txt_MLAloRate.Text;
			fgrid_ModelLine[fgrid_ModelLine.Rows.Count - 1, (int)ClassLib.TBSPB_MODEL_LINE.IxREMARKS] = txt_MLRemarks.Text;
			 

		}


		private void btn_AppendRow_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_AppendRow.ImageIndex = 1; 
		}

		private void btn_AppendRow_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_AppendRow.ImageIndex = 0; 
		}


		private void fgrid_ModelLine_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_ModelLine.Rows.Fixed > 0) && (fgrid_ModelLine.Row >= fgrid_ModelLine.Rows.Fixed))
			{
				if(fgrid_ModelLine.Cols[fgrid_ModelLine.Col].DataType == typeof(bool))
				{
					fgrid_ModelLine.Buffer_CellData = "";
				}
				else
				{
					fgrid_ModelLine.Buffer_CellData = (fgrid_ModelLine[fgrid_ModelLine.Row, fgrid_ModelLine.Col] == null) ? "" : fgrid_ModelLine[fgrid_ModelLine.Row, fgrid_ModelLine.Col].ToString();
				}
			}
		}


		private void fgrid_ModelLine_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_ModelLine.Update_Row(); 
		}



		#endregion

		#region 모델 몰드 정보
			
			
		private void cmb_MMFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;
 
			if(cmb_MMFactory.SelectedIndex == -1) return;
 
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_MMFactory.SelectedValue.ToString(), ClassLib.ComVar.CxGen);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MMGen, 1, 2, false, COM.ComVar.ComboList_Visible.Code);  

			//dt_ret = Select_Model_CmbList(cmb_MMFactory.SelectedValue.ToString()); 
			dt_ret = Select_Model_ExistBOM_CmbList();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MMModel, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);

			if(COM.ComVar.Model_ModelCd.Trim().Length > 0 && COM.ComVar.Model_ModelCd.Trim().Length > 0)
				cmb_MMModel.SelectedValue = COM.ComVar.Model_ModelCd;
			else
				cmb_MMModel.SelectedValue = 0; 


			
		}
			
			
		private void cmb_MMModel_SelectedValueChanged(object sender, System.EventArgs e)
		{ 
			DataTable dt_ret;

			try
			{
				if(cmb_MMFactory.SelectedIndex == -1 || cmb_MMModel.SelectedIndex == -1 || cmb_MMGen.SelectedIndex == -1) return;
 
				dt_ret = Select_ModelOpCd_List();  
				Display_TreeGrid(dt_ret, fgrid_ModelOpCd);
			}
			catch
			{
			}

		}


		
		private void cmb_MMMold_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
			//			if(cmb_MMFactory.SelectedIndex == -1 || cmb_MMModel.SelectedIndex == -1 || cmb_MMGen.SelectedIndex == -1) return;
			// 
			//			dt_ret = Select_ModelOpCd_List();  
			//			Display_TreeGrid(dt_ret, fgrid_ModelOpCd);

		}

		
		private void cmb_MMGen_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_MMFactory.SelectedIndex == -1 || cmb_MMModel.SelectedIndex == -1 || cmb_MMGen.SelectedIndex == -1) return;
 
				dt_ret = Select_ModelOpCd_List();  
				Display_TreeGrid(dt_ret, fgrid_ModelOpCd);
			}
			catch
			{
			}
		}


 

		/// <summary>
		/// Display_TreeGrid : 트리 형태로 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_TreeGrid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			
			CellRange cellrg;

			int level = (int)ClassLib.TBSPB_MODEL_OPCD.IxLEVEL;

			int grid_cd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxCODE;
			int grid_name = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxNAME;
			int grid_bomcd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxBOM_CD;
			int grid_bomname = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxBOM_NAME;
			int grid_moldyn = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_YN;
			int grid_moldtype = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_TYPE;
			int grid_typename = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxTYPE_NAME;
			int grid_level = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxLEVEL;
			int grid_modelcd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMODEL_CD;
			int grid_cmpcd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxCMP_CD;
			int grid_opcd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxOP_CD;
			int grid_moldcd = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CD;
			int grid_moldord = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_ORD;
			int grid_moldcycle = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CYCLE;
			int grid_remarks = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxREMARKS;
			int grid_factory = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxFACTORY;
			int grid_gen = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxGEN;
			
			 
			arg_fgrid.Tree.Column = grid_cd;
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;
			arg_fgrid.Cols.Count = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMaxCt + 1;

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.Rows.InsertNode(i + arg_fgrid.Rows.Fixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[level].ToString()) - 1);

				arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = "";

				switch(arg_dt.Rows[i].ItemArray[level].ToString())
				{
					case "1":    //model
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMODEL_CD].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_name] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMODEL_NAME].ToString();
						break;

					case "2":   //cmp
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxCMP_CD].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_name] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxCMP_NAME].ToString();
						break;

					case "3":    //op
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxOP_CD].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_name] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxOP_NAME].ToString();
						break;

					case "4":    //mold type
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_TYPE].ToString();
						arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_name] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxTYPE_NAME].ToString();
						break;
				}

				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_bomcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxBOM_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_bomname] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxBOM_NAME].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldyn] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_YN].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldtype] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_TYPE].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_typename] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxTYPE_NAME].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_level] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxLEVEL].ToString();
 
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_modelcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMODEL_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_cmpcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxCMP_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxOP_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_CD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldord] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_ORD].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldcycle] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxMOLD_CYCLE].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_remarks] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxREMARKS].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_factory] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_OPCD.IxFACTORY].ToString();
				arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_gen] = cmb_MMGen.SelectedValue.ToString();
  

				if (arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldyn].ToString() == "Y")
				{
					 
					cellrg = arg_fgrid.GetCellRange(i + arg_fgrid.Rows.Fixed, grid_cd, i + arg_fgrid.Rows.Fixed, grid_name);
					cellrg.StyleNew.ForeColor = ClassLib.ComVar.ClrImportant;

					if(arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldcd].ToString() == "")
					{

						cellrg = arg_fgrid.GetCellRange(i + arg_fgrid.Rows.Fixed, grid_moldtype, i + arg_fgrid.Rows.Fixed, grid_typename);
						cellrg.StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
					}

				}

				


				arg_fgrid.AutoSizeCols(); 
				arg_fgrid.Tree.Style = TreeStyleFlags.Complete;
 


			} 
 

		}


		private void fgrid_ModelOpCd_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_ModelOpCd.Rows.Fixed > 0) && (fgrid_ModelOpCd.Row >= fgrid_ModelOpCd.Rows.Fixed))
			{
				if(fgrid_ModelOpCd.Cols[fgrid_ModelOpCd.Col].DataType == typeof(bool))
				{
					fgrid_ModelOpCd.Buffer_CellData = "";
				}
				else
				{
					fgrid_ModelOpCd.Buffer_CellData = (fgrid_ModelOpCd[fgrid_ModelOpCd.Row, fgrid_ModelOpCd.Col] == null) ? "" : fgrid_ModelOpCd[fgrid_ModelOpCd.Row, fgrid_ModelOpCd.Col].ToString();
				}
			}
		}



		private void fgrid_ModelOpCd_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			bool digit_flag;

			if (e.Col != (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_ORD 
				&& e.Col != (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CYCLE)  
			{
				fgrid_ModelOpCd.Update_Row(); 
			}
			else
			{
				digit_flag = COM.ComFunction.Check_Digit(fgrid_ModelOpCd[e.Row, e.Col].ToString());

				if(digit_flag == false) return; 

				fgrid_ModelOpCd.Update_Row();

			
			}

			

		}


		
		private void fgrid_ModelOpCd_Click(object sender, System.EventArgs e)
		{
			if(fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_TYPE].ToString() == "")
				fgrid_ModelOpCd.Rows[fgrid_ModelOpCd.Selection.r1].AllowEditing = false;
			else
				fgrid_ModelOpCd.Rows[fgrid_ModelOpCd.Selection.r1].AllowEditing = true;
		}

 
	


		private void fgrid_ModelOpCd_DoubleClick(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				int sel_row = fgrid_ModelOpCd.Selection.r1;

			
				if(fgrid_ModelOpCd[sel_row, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_YN].ToString() == "Y"
					&& fgrid_ModelOpCd[sel_row, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_TYPE].ToString() != "")
				{
					txt_MoldPart.Text = fgrid_ModelOpCd[sel_row, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_TYPE].ToString();
					txt_TypeName.Text = fgrid_ModelOpCd[sel_row, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxTYPE_NAME].ToString();

					dt_ret = Select_MoldType_List();
					Display_Grid(dt_ret, fgrid_Mold);

				}
				else
				{
					txt_MoldPart.Text = "";
					txt_TypeName.Text = "";

					fgrid_Mold.Rows.Count = fgrid_Mold.Rows.Fixed;

				}
		 

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"fgrid_ModelOpCd_Click",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

	

	 

		private void fgrid_Mold_DoubleClick(object sender, System.EventArgs e)
		{

			try
			{
				if(fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_TYPE].ToString() 
					!= txt_MoldPart.Text)
				{
					MessageBox.Show("Discordance Mold Type");
					return;
				}

				//신규
				if(fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CD].ToString() == "")
				{
					fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, 0] = "I";
				}
				else
				{
					if(fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, 0].ToString() != "I")
						fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, 0] = "U";
				}


				fgrid_ModelOpCd[fgrid_ModelOpCd.Selection.r1, (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CD] = 
					fgrid_Mold[fgrid_Mold.Selection.r1, (int)ClassLib.TBDT_TOOL.IxTOOL_CD].ToString();
		 
				fgrid_ModelOpCd.LeftCol = (int)ClassLib.TBSPB_MODEL_OPCD_GRID.IxMOLD_CD;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"fgrid_Mold_Click",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}


		}




		#endregion
		 

		#endregion 
	 
		#region DB Connect


		/// <summary>
		/// Select_Model_Year : 모델에 대한 연도 리스트 찾기
		/// </summary>
		private DataTable Select_Model_Year()
		{
 
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(1); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_YEAR";
 
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

 
		/// <summary>
		/// Select_Model_List : 모델 리스트 가져오기
		/// </summary>
		private DataTable Select_Model_List(string arg_factory, string arg_year)
		{

			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_LIST";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_YEAR";
			MyOraDB.Parameter_Name[2] = "ARG_MODEL_NAME";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_year, " ");

			switch(obar_Main.SelectedPage.Name)
			{ 
				case "obarpg_Model":  
					MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_MDModel, " ");
					break;

				case "obarpg_ModelLine": 
					MyOraDB.Parameter_Values[2] = " ";
					break; 
			} 

			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 

		}





		/// <summary>
		/// Select_Model_List_Style : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <returns></returns>
		private DataTable Select_Model_List_Style(string arg_factory, string arg_stylecd)
		{

			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_LIST_STYLE";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stylecd;  
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 

		}




		/// <summary>
		/// Select_Model_Line : 모델 라인 리스트 가져오기
		/// </summary>
		private DataTable Select_Model_Line()
		{
			 
			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_LINE";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_MODEL_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_MLFactory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_MLModel, " ");
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 

		}



		/// <summary>
		/// Select_Line_List : 라인 리스트 가져오기
		/// </summary>
		private DataTable Select_Line_List()
		{
			 
			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_LINE.SELECT_LINE_LIST";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_MLLFactory.SelectedValue.ToString(); ;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name];  

		}

		/// <summary>
		/// Select_Model_ExistBOM_CmbList : BOm 코드 있는 모델  콤보 리스트 찾기 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_cmb">적용시킬 콤보박스</param>
		public DataTable Select_Model_ExistBOM_CmbList()
		{ 
			 
			DataSet ds_ret; 
 
			try
			{
				MyOraDB.ReDim_Parameter(2); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_SPB_MODEL_EXISTBOM";
 
				//02.ARGURMENT명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				//03.DATA TYPE
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = cmb_MMFactory.SelectedValue.ToString();
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
		/// Select_Model_CmbList : 모델  콤보 리스트 찾기, 리스트 추가
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_cmb">적용시킬 콤보박스</param>
		public DataTable Select_Model_CmbList(string arg_factory)
		{ 
			 
			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_CMBLIST";
 
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
		/// Save_ModelOpMold : 모델 공정 몰드 저장
		/// </summary>
		private bool Save_ModelOpMold()
		{
			int arg_ct = 0;
			int save_ct =0 ;							// 저장 행 수
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 
	
			try
			{
				ClassLib.Arr_TBSPB_MODEL_OPMOLD  arr_opmold= new ClassLib.Arr_TBSPB_MODEL_OPMOLD();
			
				arg_ct = arr_opmold.lx.GetLength(0) + 2;

				MyOraDB.ReDim_Parameter(arg_ct); 
		
				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SAVE_SPB_MODEL_OPMOLD";

			
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";

				for (int i = 0 ; i < arr_opmold.lx.GetLength(0); i ++)
				{	
					MyOraDB.Parameter_Name[i + 1] = HeadDT.Rows[0].ItemArray[arr_opmold.lx[i]].ToString(); 
				}
				MyOraDB.Parameter_Name[arg_ct - 1] = "ARG_UPD_USER"; 
		
				//03.DATA TYPE
				for (int i = 0 ; i < arg_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			
		
					
				//04.DATA 정의
				 
				// 저장 행 수 구하기
				for(int i = fgrid_ModelOpCd.Rows.Fixed ; i < fgrid_ModelOpCd.Rows.Count; i++)
				{
					if(fgrid_ModelOpCd[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[arg_ct * save_ct ]; 
			         
				for (int i  = fgrid_ModelOpCd.Rows.Fixed; i < fgrid_ModelOpCd.Rows.Count; i++)
				{
					if(fgrid_ModelOpCd[i, 0].ToString() != "")
					{ 

						MyOraDB.Parameter_Values[para_ct] = fgrid_ModelOpCd[i, 0].ToString(); 
						para_ct ++;

						for(int j = 0; j < arr_opmold.lx.GetLength(0); j++)
						{
							MyOraDB.Parameter_Values[para_ct] = (fgrid_ModelOpCd[i, arr_opmold.lx[j]] == null) ? "" : fgrid_ModelOpCd[i, arr_opmold.lx[j]].ToString();
							para_ct ++;
						} // end for j 
						MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User;
						para_ct ++;
					} // end if
	 
				} // end for i

				//05.Package연결
				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
					
				return true;



			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_ModelOpMold",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}


		}



		/// <summary>
		/// Select_ModelOpCd_List : 모델 -> 반제 -> 공정  -> 몰드 리스트 추출
		/// </summary>
		/// <returns></returns>
		private DataTable Select_ModelOpCd_List()
		{
			DataSet ds_ret; 
 
			try
			{
				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_OPCD_LIST";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[2] = "ARG_GEN";
				MyOraDB.Parameter_Name[3] = "ARG_MOLD_YN";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

				//03.DATA TYPE
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = cmb_MMFactory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_MMModel.SelectedValue.ToString();     //ClassLib.ComFunction.Empty_Combo(cmb_MMModel, " ");
				MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(cmb_MMGen, " ");
				MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_MMMold, " ");
				MyOraDB.Parameter_Values[4] = "";

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[MyOraDB.Process_Name];  
			}
			catch
			{
				return null;
			}
		}


	 
		/// <summary>
		/// Select_MoldType_List : 몰드 유형에 따른 몰드 리스트 
		/// </summary>
		/// <returns></returns> 
		private DataTable Select_MoldType_List()
		{

			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_MOLD_LIST";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "ARG_PART_CD"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_MMFactory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_TextBox(txt_MoldPart, " ");
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name];  
		}



		private void Delete_Model_Opmold()
		{
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name =  "PKG_SPB_MODEL_BSC.DELETE_SPB_MODEL_OPMOLD";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "ARG_MODEL_CD"; 
			MyOraDB.Parameter_Name[2] = "ARG_GEN";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 

			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_MMFactory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_MMModel.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = cmb_MMGen.SelectedValue.ToString();

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();	
		}


		private void Save_Model_Opmold(string[] arg_arraylist)
		{
			MyOraDB.ReDim_Parameter(arg_arraylist.Length); 

			//01.PROCEDURE명
			MyOraDB.Process_Name =  "PKG_SPB_MODEL_BSC.SAVE_SPB_MODEL_OPMOLD";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[2] = "ARG_MODEL_CD"; 
			MyOraDB.Parameter_Name[3] = "ARG_GEN"; 
			MyOraDB.Parameter_Name[4] = "ARG_CMP_CD";
			MyOraDB.Parameter_Name[5] = "ARG_OP_CD";
			MyOraDB.Parameter_Name[6] = "ARG_MOLD_TYPE"; 
			MyOraDB.Parameter_Name[7] = "ARG_MOLD_CD"; 
			MyOraDB.Parameter_Name[8] = "ARG_MOLD_ORD"; 
			MyOraDB.Parameter_Name[9] = "ARG_MOLD_CYCLE"; 
			MyOraDB.Parameter_Name[10] = "ARG_REMARKS";
			MyOraDB.Parameter_Name[11] = "ARG_UPD_USER";

			//03.DATA TYPE
			for(int i=0; i<arg_arraylist.Length; i++)
			{
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
			}
						 
			//04.DATA 정의  
			for(int i=0; i<arg_arraylist.Length; i++)
			{
				MyOraDB.Parameter_Values[i] = arg_arraylist[i];
			}
			
			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();	
		}




		#endregion


		private void Form_PB_Model_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

	 

		#region BOM 표시


		
		private void fgrid_MModelDetail_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
//			if(e.Button != MouseButtons.Left) return;
//
//		    Set_BOM_Code();
		}



		private void fgrid_MModelDetail_Click(object sender, System.EventArgs e)
		{
			try
			{
				//txt_MDModel.Text = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxMODEL_NAME].ToString();
				Display_BOM();
			}
			catch
			{
			}
		}

		 
		private void fgrid_MModelDetail_ComboCloseUp(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			//			try
			//			{
			//				Display_BOM();
			//			}
			//			catch
			//			{
			//			}
		}


		#region 모델 BOM Routing 표시


		/// <summary>
		/// Set_BOM_Code : 
		/// </summary>
		private void Set_BOM_Code()
		{

			try
			{

				
				//if(fgrid_MModelDetail.Rows.Count == fgrid_MModelDetail.Rows.Fixed) return;
 

				if(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, "").Equals("") ) return;


				string factory = ClassLib.ComFunction.Empty_Combo(cmb_MFactory, ""); 

				DataTable dt_ret = null;
				string cmb_list = "";


				dt_ret = Select_SPB_BOM_CD(factory); 

				for(int i = 0; i < dt_ret.Rows.Count; i++) 
				{
					cmb_list += "|" + dt_ret.Rows[i].ItemArray[0].ToString(); 
				}

				fgrid_MModelDetail.Cols[(int)ClassLib.TBSPB_MODEL.IxBOM_CD].ComboList = cmb_list; 
				
 
				dt_ret.Dispose(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_BOM_Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}



		private DataTable Select_SPB_BOM_CD(string arg_factory)
		{

			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SELECT_SPB_BOM_CD";
 
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
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}




		public void Display_BOM()
		{
			try
			{ 
				DataTable dt_ret; 
				Lassalle.Flow.Node node;


				_Rowfixed = fgrid_BomNode.Rows.Fixed;

				ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
			
				dt_ret = Select_StdBom_List(); 
   
				if(dt_ret.Rows.Count > 0)
				{
					Set_Tree(dt_ret);   
					Select_StdBom_Node_List();
					Select_StdBom_Link_List();

					for(int i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
					{
						foreach(Item item in addflow_BOM.Items)
						{
							if(item is Lassalle.Flow.Node)
							{
								node = (Lassalle.Flow.Node)item; 

								if(fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString() == node.Tag.ToString())
								{
									Select_StdRout_Node(node.Tag.ToString(), node); 
									break;
								}
							} 
						}//end foreach 
					
						Select_StdRout_Link(fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString()); 
					

					}
 
				}
				else
				{
					fgrid_BOM.Tree.Column = 1; 
					fgrid_BOM.Rows.Count = _Rowfixed; 
				}

			}
			catch
			{
			}
		}


		/// <summary>
		/// Set_Tree : 그리드에 트리 형태로 데이터 구현
		/// </summary>
		/// <param name="arg_dt">트리로 적용될 데이터테이블</param>
		private void Set_Tree(DataTable arg_dt)
		{
			try
			{
				fgrid_BOM.Tree.Column = 1; 
				fgrid_BOM.Rows.Count = _Rowfixed;
  
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					fgrid_BOM.Rows.InsertNode(i + _Rowfixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_BOM.IxCMP_LEVEL - 1].ToString()) - 1);

					fgrid_BOM[i + _Rowfixed, 0] = "";

					for(int j = 1; j < fgrid_BOM.Cols.Count; j++)
					{
						fgrid_BOM[i + _Rowfixed, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
					}

					fgrid_BOM.AutoSizeCols();
 
				}
	   

				fgrid_BOM.Tree.Style = TreeStyleFlags.Complete;
			}
			catch
			{
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
				string process_name = "PKG_SPB_BOM.SELECT_STDBOM_NODELIST";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString();  
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//-------------------------------------------------------------------------------- 
				fgrid_BomNode.Rows.Count = _Rowfixed; 
				fgrid_BomNode.Cols.Count = dt_ret.Columns.Count + 1; 
				_Node_Count = dt_ret.Rows.Count;

 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_BomNode.AddItem(dt_ret.Rows[i].ItemArray, fgrid_BomNode.Rows.Count, 1); 
				} 


			 
				for(int i = _Rowfixed; i < fgrid_BomNode.Rows.Count; i++)
				{ 
					node = new Lassalle.Flow.Node();

					node = addflow_BOM.Nodes.Add(Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxLEFT].ToString()), 
						Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTOP].ToString()), 
						Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxWIDTH].ToString()), 
						Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxHEIGHT].ToString()), "");

					//node.Text =  fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTEXT].ToString();
					node.Text =  fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTAG].ToString();

					node.Tooltip = node.Text;
					node.Tag = fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTAG].ToString();  
				
					ClassLib.ComFunction.Set_NodeProp(fgrid_BomNode, node, i); 

					//node.DrawColor = Color.LightGray;
					//node.TextColor = Color.Gray;
					node.Alignment = Alignment.CenterTOP; 
  
				} //end for 
				//--------------------------------------------------------------------------------
 
			}
			catch
			{  
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
			int org_index, dst_index;

			try
			{ 
				string process_name = "PKG_SPB_BOM.SELECT_STDBOM_LINKLIST";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString(); 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//-------------------------------------------------------------------------------- 
				fgrid_BomLink.Rows.Count = _Rowfixed; 
				//			fgrid_BomLink.Cols.Count = dt_ret.Columns.Count + 1; 
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_BomLink.AddItem(dt_ret.Rows[i].ItemArray, fgrid_BomLink.Rows.Count, 1); 
				} 


				////////////////////////////////////////////////////////////////
				for(int i = _Rowfixed; i < fgrid_BomLink.Rows.Count; i++)
				{ 
					link = new Lassalle.Flow.Link(); 
	  
					org_index = ClassLib.ComFunction.Get_Index(fgrid_BomNode, fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxORG_NODE].ToString(), (int)ClassLib.TBSPB_NODE_BOM.IxNODE_CD, _Rowfixed);
					dst_index = ClassLib.ComFunction.Get_Index(fgrid_BomNode, fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxDST_NODE].ToString(), (int)ClassLib.TBSPB_NODE_BOM.IxNODE_CD, _Rowfixed);

					link = addflow_BOM.Nodes[org_index].OutLinks.Add(addflow_BOM.Nodes[dst_index]);
				
					link.Tag = fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxTAG].ToString();  

					ClassLib.ComFunction.Set_LinkProp(fgrid_BomLink, link, i);

					//link.DrawColor =  Color.LightGray;

 
				} // end for

				//			_Link_Index = max_index + 1;
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
				string process_name = "PKG_SPB_BOM.SELECT_STDBOM_ROUT";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD";
				MyOraDB.Parameter_Name[2] = "ARG_ROUT";  //"ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString(); 
				MyOraDB.Parameter_Values[2] = ClassLib.ComVar.Rout_Type;
				MyOraDB.Parameter_Values[3] = "";  

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
		///  Select_StdRout_Node : Standard Routing Node 리스트 찾기  
		/// </summary>
		private void  Select_StdRout_Node(string arg_cmpcd, Lassalle.Flow.Node arg_node)
		{
			DataSet ds_ret; 
			DataTable dt_ret;
			Lassalle.Flow.Node node;
			int location_x = 0, location_y = 0;
			int pre_level, my_level;  
			 

			try
			{ 
				string process_name = "PKG_SPB_ROUT.SELECT_BOMROUT_NODE";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";  
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString(); 
				MyOraDB.Parameter_Values[2] = arg_cmpcd; 
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.Rout_Type; 
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//-------------------------------------------------------------------------------- 
				fgrid_NodeRout.Rows.Count = _Rowfixed;


				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_NodeRout.AddItem(dt_ret.Rows[i].ItemArray, fgrid_NodeRout.Rows.Count, 1);
				}  

				///////////////////////////////////////////////////////////
			
				location_x = (int)(arg_node.Location.X + 5);
				location_y = (int)(arg_node.Location.Y + 10); 
				
				for(int i = _Rowfixed; i < fgrid_NodeRout.Rows.Count; i++)
				{ 
					node = new Lassalle.Flow.Node();

					node = addflow_BOM.Nodes.Add(Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxLEFT].ToString()), 
						Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTOP].ToString()), 
						Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxWIDTH].ToString()), 
						Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxHEIGHT].ToString()), "");
				
					node.Text =  fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTEXT].ToString(); 
					node.Tooltip = node.Text;

					//tag = pcardyn (1) + routseq (3) + tag
					//node.Tag = fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTAG].ToString();  
					//node.Tag = arg_node.Tag;

					node.Tag = fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTAG].ToString() 
						+ fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString() 
						+ arg_cmpcd;

					if(node.Tag.ToString().Substring(0, 1) == "Y") node.Text = "*" + node.Text; 
 
				
					if(_Op_Count != 0)
					{
				 
						//					pre_level = Convert.ToInt32(fgrid_NodeRout[i - 1, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 1));
						//					my_level = Convert.ToInt32(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 1));

                        //if (i > 1)
                        //{
                            pre_level = Convert.ToInt32(fgrid_NodeRout[i - 1, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 2));
                            my_level = Convert.ToInt32(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 2));

                            if (pre_level == my_level)    //같은 레벨이 뒤따라 올때 X 좌표값 증가해서 옆에 표시
                            {
                                location_x = location_x + (int)node.Size.Width + 5;
                            }
                            else                         //다른 레벨이 뒤따라 올때 Y 좌표값 증가해서 아래에 표시
                            {
                                location_y = location_y + (int)node.Size.Height + 30;
                            }

                        //} // end if (i > 1)

					}

					node.Location = new Point(location_x, location_y); 

					ClassLib.ComFunction.Set_NodeProp(fgrid_NodeRout, node, i); 

					//				arg_node.Hidden = true;

					_Op_Count++;
  
				} //end for  
				//--------------------------------------------------------------------------------
 
			}
			catch 
			{ 
			}
 
		}



		/// <summary>
		/// Select_StdRout_Link : Standard Routing  Link 리스트 찾기 
		/// </summary>
		private void Select_StdRout_Link(string arg_cmpcd)
		{
			DataSet ds_ret; 
			DataTable dt_ret;
			Lassalle.Flow.Link link; 
			int org_index, dst_index; 

			try
			{ 
				string process_name =  "PKG_SPB_ROUT.SELECT_BOMROUT_LINK";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";  
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = fgrid_MModelDetail[fgrid_MModelDetail.Selection.r1, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString(); 
				MyOraDB.Parameter_Values[2] = arg_cmpcd; 
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.Rout_Type;  
				MyOraDB.Parameter_Values[4] = "";  

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//-------------------------------------------------------------------------------- 
				fgrid_LinkRout.Rows.Count = _Rowfixed;  
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_LinkRout.AddItem(dt_ret.Rows[i].ItemArray, fgrid_LinkRout.Rows.Count, 1); 
				} 


				////////////////////////////////////////////////////////////////
				for(int i = _Rowfixed; i < fgrid_LinkRout.Rows.Count; i++)
				{ 
					link = new Lassalle.Flow.Link(); 
	  
					org_index = ClassLib.ComFunction.Get_Index(fgrid_NodeRout, fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxORG_NODE].ToString(), (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD, _Rowfixed) + _Node_Count;
					dst_index = ClassLib.ComFunction.Get_Index(fgrid_NodeRout, fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxDST_NODE].ToString(), (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD, _Rowfixed) + _Node_Count;
				
					link = addflow_BOM.Nodes[org_index].OutLinks.Add(addflow_BOM.Nodes[dst_index]);
				
					link.Tag = fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxTAG].ToString(); 
 
					ClassLib.ComFunction.Set_LinkProp(fgrid_LinkRout, link, i);


					//				if(max_index <= Convert.ToInt32(link.Tag))  max_index = Convert.ToInt32(link.Tag); 
				
				
				} // end for

				//			_Link_Index = max_index + 1;

			 
				_Node_Count = _Node_Count + _Op_Count;
				_Op_Count = 0;
			
				//--------------------------------------------------------------------------------
 
			}
			catch
			{  
			}    
		  


		}


		#endregion  
 


		#endregion 
	
		#region model tran
		
	
		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				Label src = sender as Label;
				src.ImageIndex = 1;
			}
			catch
			{
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				Label src = sender as Label;
				src.ImageIndex = 0;
			}
			catch
			{
			}
		}

		private void btn_TranModel_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;
			bool save_flag = false;

			try
			{
				dt_ret = Save_ModelTran();
				
				if(dt_ret == null) return;

				save_flag = Save_StyleTran(); 

				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					return;
				}
				else
				{
					// 신규 모델 info
					int dt_row = dt_ret.Rows.Count;

					if(dt_row > 0)
					{
						string message = "";

						int model_name = 1;

						for(int i=0; i<dt_row; i++)
						{
							message += dt_ret.Rows[i].ItemArray[model_name].ToString() + "\r\n";
						}


						ClassLib.ComFunction comfunc = new FlexAPS.ClassLib.ComFunction();
						comfunc.AutoWorkMessage(this.Name, "E001", message);
					}

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
				
					//refresh
					dt_ret = Select_Model_List(ClassLib.ComFunction.Empty_Combo(cmb_MFactory, " "),
						ClassLib.ComFunction.Empty_Combo(cmb_MDYear, " "));
					Display_Grid(dt_ret, fgrid_MModelDetail);

					ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);

 				}

			}
			catch
			{
			}
		}
		

		/// <summary>
		/// Save_ModelTran : 신규 모델 자동 저장 -> 신규 모델 리스트 리턴
		/// </summary>
		/// <returns></returns>
		private DataTable Save_ModelTran()
		{
			DataSet ds_ret;

			try
			{
				MyOraDB.ReDim_Parameter(3); 
  
				string process_name = "PKG_SPB_MODEL_BSC.TRANS_MODEL";
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";  
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString();  
				MyOraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;
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
		/// Save_StyleTran : 신규 스타일 자동 저장
		/// </summary>
		/// <returns></returns>
		private bool Save_StyleTran()
		{
			try
			{
				MyOraDB.ReDim_Parameter(2);
				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.TRANS_STYLE";

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
			
				MyOraDB.Parameter_Values[0] = cmb_MFactory.SelectedValue.ToString();  
				MyOraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;  

				MyOraDB.Add_Modify_Parameter(true);	 
				MyOraDB.Exe_Modify_Procedure();	 
				return true;
			}
			catch
			{
				return false;
			}
		}




		/// <summary>
		/// Save_SPB_MODEL_WITH_MPS_LOT : 
		/// </summary>
		/// <returns></returns>
		private bool Save_SPB_MODEL_WITH_MPS_LOT()
		{

			try
			{ 


				this.Cursor = Cursors.WaitCursor;
 
				//---------------------------------------------------------------------------
				//1. spb_model
				//--------------------------------------------------------------------------- 
				int col_ct = 10;  						 
				int row = 0;
				


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.SAVE_SPB_MODEL";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_MODEL_CD"; 
				MyOraDB.Parameter_Name[3] = "ARG_MODEL_NAME";
				MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
				MyOraDB.Parameter_Name[5] = "ARG_BOM_CD";
				MyOraDB.Parameter_Name[6] = "ARG_LINE_QTY"; 
				MyOraDB.Parameter_Name[7] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[8] = "ARG_BOM_CD_OLD"; 
				MyOraDB.Parameter_Name[9] = "ARG_UPD_USER";  
 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList();  


				for(row = fgrid_MModelDetail.Rows.Fixed; row < fgrid_MModelDetail.Rows.Count; row++)
				{

					if(fgrid_MModelDetail[row, 0] == null || fgrid_MModelDetail[row, 0].ToString().Trim().Equals("") ) continue;

    
					vList.Add(fgrid_MModelDetail[row, 0].ToString());
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxFACTORY].ToString());
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxMODEL_CD].ToString()); 
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxMODEL_NAME].ToString()); 
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxCATEGORY].ToString()); 
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString()); 
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxLINE_QTY].ToString()); 
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxREMARKS].ToString()); 
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxBOM_CD_OLD].ToString()); 
					vList.Add(ClassLib.ComVar.This_User); 


				} // end for row


				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 





				//---------------------------------------------------------------------------
				//1. Model BOM 이 수정되었을 경우, MPS 의 LOT 에도 BOM 변경 사항 반영
				//--------------------------------------------------------------------------- 
				col_ct = 5;  	
 

				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_MODEL_BSC.CHANGE_MODEL_BOM_IN_MPS_LOT";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[2] = "ARG_BOM_CD_OLD"; 
				MyOraDB.Parameter_Name[3] = "ARG_BOM_CD_NEW";
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER"; 
 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				vList.Clear();
				// 파라미터 값에 저장할 배열
				vList = new ArrayList();  


				for(row = fgrid_MModelDetail.Rows.Fixed; row < fgrid_MModelDetail.Rows.Count; row++)
				{

					if(fgrid_MModelDetail[row, 0] == null || fgrid_MModelDetail[row, 0].ToString().Trim().Equals("") ) continue;

     
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxFACTORY].ToString());
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxMODEL_CD].ToString());  
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxBOM_CD_OLD].ToString()); 
					vList.Add(fgrid_MModelDetail[row, (int)ClassLib.TBSPB_MODEL.IxBOM_CD].ToString());   
					vList.Add(ClassLib.ComVar.This_User); 


				} // end for row


				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(false);		// 파라미터 데이터를 DataSet에 추가 






				// db 반영
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행

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
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}




		#endregion






	}
}

