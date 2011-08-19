using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.Threading;
using System.IO;
using System.Text;
namespace FlexPurchase.Incoming
{
	public class Form_BI_Incoming_Item_Inspection : COM.PCHWinForm.Form_Top
	{
		#region 컨트롤정의 및 리소스
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.PictureBox pictureBox1;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_styleCd;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.Label lbl_vendor;
        private System.Windows.Forms.TextBox txt_vendorCode;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private C1.Win.C1List.C1Combo cmb_purDiv;
		private C1.Win.C1List.C1Combo cmb_buyDiv;
		private System.Windows.Forms.Label lbl_buyDiv;
		private System.Windows.Forms.Label lbl_purDiv;
		private C1.Win.C1List.C1Combo cmb_priceYn;
		private System.Windows.Forms.Label lbl_priceYN;
		private System.Windows.Forms.PictureBox pic_head3;
        private System.Windows.Forms.Label lbl_inYmd;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private C1.Win.C1List.C1Combo cmb_barKind;
		private System.Windows.Forms.Label lbl_barKind;
		private C1.Win.C1List.C1Combo cmb_searchType;
		private System.Windows.Forms.Label lbl_searchType;
		private System.Windows.Forms.TextBox txt_lotNo;
		private System.Windows.Forms.Label lbl_lotNo;
		private COM.FSP fgrid_main;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.TextBox txt_styleCd;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_all;
		private System.Windows.Forms.MenuItem mnu_vendor;
		private System.Windows.Forms.MenuItem mnu_material;
		private System.Windows.Forms.MenuItem mnu_classtype;
		private System.Windows.Forms.MenuItem mnu_firstclass;
		private System.Windows.Forms.MenuItem mnu_secondclass;
		private System.Windows.Forms.MenuItem mnu_factory;
		private System.Windows.Forms.MenuItem mnu_item;
		private System.Windows.Forms.MenuItem mnu_ymd;
		private System.Windows.Forms.MenuItem mnu_color;
		private System.Windows.Forms.MenuItem mnu_spec;
		private System.Windows.Forms.MenuItem mnu_date;
		private int _rowFixed = 0;
		private Encoding K_Encode = Encoding.GetEncoding("euc-kr");
		private int tree_level = 4;
		private bool date_view = false;
		#endregion 

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB	= new COM.OraDB();
//		private int  _fixedRow		= 0;
		private bool _isAccessible	= false;
		private string _vSelType	= "";
		private System.Windows.Forms.Label lbl_headInfo;
		private string _vBarMove	= "";

		private int _lxMTotalCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxTOTAL;
		private int _lxMCustNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxCUST_NAME;
		private int _lxMCustCdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxCUST_CD;
		private int _lxMVendorItemCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxVENDOR_ITEM;
		private int _lxMItemNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxITEM_NAME;
		private int _lxMSpecNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxSPEC_NAME;
		private int _lxMColorNameCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxCOLOR_NAME;
		private int _lxMPurPriceCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxPUR_PRICE;
		private int _lxMorderByCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxORDER_BY;
		private int _lxMInYmdCol  		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxIN_YMD;
		//private int _lxMPurPriceCol   	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxPUR_PRICE;


		private int _lxFTotalCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_F.IxTOTAL;
		private int _lxFFactoryCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_F.IxFACTORY;
		private int _lxFCustNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_F.IxCUST_NAME;
		private int _lxFVendorItemCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_F.IxVENDOR_ITEM;
		private int _lxFItemNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_F.IxITEM_NAME;
		private int _lxFPurpriceCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_F.IxPUR_PRICE;

//		private int _lxMYmdVendorCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxYMD_VENDOR;
//		private int _lxMYmdItemCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxYMD_ITEM;
//		private int _lxMItemCol			= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxITEM;
//		private int _lxMInYmdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxIN_YMD;
//		private int _lxMCustCdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxCUST_CD;

		private int _lxVTotalCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxTOTAL;
		private int _lxVCustNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxCUST_NAME;
		private int _lxVVendorItemCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxVENDOR_ITEM;
		private int _lxVFactoryCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxFACTORY;
		private int _lxVPurpriceCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxPUR_PRICE;
//		private int _lxVYmdVendorCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxYMD_VENDOR;
//		private int _lxVYmdItemCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxYMD_ITEM;
//		private int _lxVItemCol			= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxITEM;
//		private int _lxVItemNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxITEM_NAME;
//		private int _lxVInYmdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxIN_YMD;
//		private int _lxVCustCdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxCUST_CD;
					
		private int _lxDTotalCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxTOTAL;
		private int _lxDFactoryCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxFACTORY;
		private int _lxDInYmdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxIN_YMD;
		private int _lxDCustNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxCUST_NAME;
		private int _lxDYmdVendorCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxYMD_VENDOR;
		private int _lxDPurpriceCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxPUR_PRICE;
//		private int _lxDYmdItemCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxYMD_ITEM;
//		private int _lxDVendorItemCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxVENDOR_ITEM;
//		private int _lxDItemCol			= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxITEM;
//		private int _lxDItemNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxITEM_NAME;
//		private int _lxDCustCdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxCUST_CD;

		private int _lxCTotalCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxTOTAL;
		private int _lxCGroupMCdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxGROUP_M_CD;
		private int _lxCClassTypeCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxCLASS_TYPE ;
		private int _lxCFirstClassCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxFIRST_CLASS ;
		private int _lxCSecondClassCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxSECOND_CLASS ;
		private int _lxCPurPriceCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxPUR_PRICE;
		private int _lxCFactoryCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxFACTORY;		
		private int _lxCPurpriceCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxPUR_PRICE;
//		private int _lxCYmdVendorCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxYMD_VENDOR;
//		private int _lxCYmdItemCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxYMD_ITEM;
//		private int _lxCVendorItemCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxVENDOR_ITEM;
//		private int _lxCItemCol			= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxITEM;
//		private int _lxCItemNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxITEM_NAME;
//		private int _lxCCustCdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxCUST_CD;
//		private int _lxCInYmdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxIN_YMD;
//		private int _lxCGroupTCdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxGROUP_T_CD;
//		private int _lxCGroupLCdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxGROUP_L_CD;
//		private int _lxCGroupCdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxGROUP_CD;

		private int _lxHTotalCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxTOTAL;
		private int _lxHVendorItemCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxVENDOR_ITEM;
		private int _lxHItemNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxITEM_NAME;
		private int _lxHCustNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxCUST_NAME;
		private int _lxHFactoryCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxFACTORY;
		private int _lxHPurpriceCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxPUR_PRICE;
//		private int _lxHYmdVendorCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxYMD_VENDOR;
//		private int _lxHYmdItemCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxYMD_ITEM;
//		private int _lxHItemCol			= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxITEM;
//		private int _lxHCustCdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxCUST_CD;
//		private int _lxHInYmdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxIN_YMD;
		
		private int _lxATotalCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxTOTAL;
		private int _lxAYmdItemCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxYMD_ITEM;
		private int _lxAItemNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxITEM_NAME;
		private int _lxAInYmdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxIN_YMD;
		private C1.Win.C1List.C1Combo cmb_inType;
		private System.Windows.Forms.Label lbl_inType;
		private int _lxAFactoryCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxFACTORY;
		private System.Windows.Forms.CheckBox chk_not_ss;
        private System.Windows.Forms.Label lbl_printtype;
		private C1.Win.C1List.C1Combo cmb_pur_factory;
		private System.Windows.Forms.Label lbl_SH_CDC;
		private System.Windows.Forms.CheckBox chk_ship_date;
		private System.Windows.Forms.Label lbl_Ship_Date;
		private System.Windows.Forms.DateTimePicker dpick_Ship_Date;
        private C1.Win.C1List.C1Combo cmb_factory;
        private C1.Win.C1List.C1Combo cmb_printtype;
        private C1.Win.C1List.C1Combo cmb_vendor;
        private C1.Win.C1List.C1Combo cmb_InRemarks;
        private Label lbl_InRemarks;
		private int _lxAPurpriceCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxPUR_PRICE;
//		private int _lxAYmdVendorCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxYMD_VENDOR;
//		private int _lxAVendorItemCol	= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxVENDOR_ITEM;
//		private int _lxAItemCol			= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxITEM;
//		private int _lxACustCdCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxCUST_CD;
//		private int _lxACustNameCol		= (int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxCUST_NAME;

		#endregion

		#region 생성자 / 소멸자
		public Form_BI_Incoming_Item_Inspection()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BI_Incoming_Item_Inspection));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_main = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_InRemarks = new C1.Win.C1List.C1Combo();
            this.lbl_InRemarks = new System.Windows.Forms.Label();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.cmb_printtype = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.chk_ship_date = new System.Windows.Forms.CheckBox();
            this.dpick_Ship_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Ship_Date = new System.Windows.Forms.Label();
            this.cmb_pur_factory = new C1.Win.C1List.C1Combo();
            this.lbl_SH_CDC = new System.Windows.Forms.Label();
            this.lbl_printtype = new System.Windows.Forms.Label();
            this.chk_not_ss = new System.Windows.Forms.CheckBox();
            this.cmb_inType = new C1.Win.C1List.C1Combo();
            this.lbl_inType = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.txt_lotNo = new System.Windows.Forms.TextBox();
            this.lbl_lotNo = new System.Windows.Forms.Label();
            this.cmb_searchType = new C1.Win.C1List.C1Combo();
            this.lbl_searchType = new System.Windows.Forms.Label();
            this.cmb_barKind = new C1.Win.C1List.C1Combo();
            this.lbl_barKind = new System.Windows.Forms.Label();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.lbl_styleCd = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.cmb_purDiv = new C1.Win.C1List.C1Combo();
            this.cmb_buyDiv = new C1.Win.C1List.C1Combo();
            this.lbl_buyDiv = new System.Windows.Forms.Label();
            this.lbl_purDiv = new System.Windows.Forms.Label();
            this.cmb_priceYn = new C1.Win.C1List.C1Combo();
            this.lbl_priceYN = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_inYmd = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.ctx_main = new System.Windows.Forms.ContextMenu();
            this.mnu_factory = new System.Windows.Forms.MenuItem();
            this.mnu_vendor = new System.Windows.Forms.MenuItem();
            this.mnu_material = new System.Windows.Forms.MenuItem();
            this.mnu_spec = new System.Windows.Forms.MenuItem();
            this.mnu_color = new System.Windows.Forms.MenuItem();
            this.mnu_classtype = new System.Windows.Forms.MenuItem();
            this.mnu_firstclass = new System.Windows.Forms.MenuItem();
            this.mnu_secondclass = new System.Windows.Forms.MenuItem();
            this.mnu_item = new System.Windows.Forms.MenuItem();
            this.mnu_ymd = new System.Windows.Forms.MenuItem();
            this.mnu_date = new System.Windows.Forms.MenuItem();
            this.mnu_all = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_InRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_searchType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barKind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_priceYn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
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
            this.c1CommandHolder1.Commands.Add(this.tbtn_Confirm);
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
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(952, 23);
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
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "28.9655172413793:False:True;68.9655172413793:False:False;\t0.393700787401575:False" +
                ":True;97.6377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.Location = new System.Drawing.Point(4, 176);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 19;
            this.fgrid_main.Size = new System.Drawing.Size(1000, 400);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 34;
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_InRemarks);
            this.pnl_head.Controls.Add(this.lbl_InRemarks);
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.cmb_printtype);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.chk_ship_date);
            this.pnl_head.Controls.Add(this.dpick_Ship_Date);
            this.pnl_head.Controls.Add(this.lbl_Ship_Date);
            this.pnl_head.Controls.Add(this.cmb_pur_factory);
            this.pnl_head.Controls.Add(this.lbl_SH_CDC);
            this.pnl_head.Controls.Add(this.lbl_printtype);
            this.pnl_head.Controls.Add(this.chk_not_ss);
            this.pnl_head.Controls.Add(this.cmb_inType);
            this.pnl_head.Controls.Add(this.lbl_inType);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.txt_styleCd);
            this.pnl_head.Controls.Add(this.txt_lotNo);
            this.pnl_head.Controls.Add(this.lbl_lotNo);
            this.pnl_head.Controls.Add(this.cmb_searchType);
            this.pnl_head.Controls.Add(this.lbl_searchType);
            this.pnl_head.Controls.Add(this.cmb_barKind);
            this.pnl_head.Controls.Add(this.lbl_barKind);
            this.pnl_head.Controls.Add(this.txt_itemNm);
            this.pnl_head.Controls.Add(this.cmb_user);
            this.pnl_head.Controls.Add(this.pictureBox1);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.txt_itemCd);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.lbl_styleCd);
            this.pnl_head.Controls.Add(this.lbl_user);
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.cmb_purDiv);
            this.pnl_head.Controls.Add(this.cmb_buyDiv);
            this.pnl_head.Controls.Add(this.lbl_buyDiv);
            this.pnl_head.Controls.Add(this.lbl_purDiv);
            this.pnl_head.Controls.Add(this.cmb_priceYn);
            this.pnl_head.Controls.Add(this.lbl_priceYN);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_inYmd);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 168);
            this.pnl_head.TabIndex = 33;
            // 
            // cmb_InRemarks
            // 
            this.cmb_InRemarks.AddItemSeparator = ';';
            this.cmb_InRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_InRemarks.Caption = "";
            this.cmb_InRemarks.CaptionHeight = 17;
            this.cmb_InRemarks.CaptionStyle = style1;
            this.cmb_InRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_InRemarks.ColumnCaptionHeight = 18;
            this.cmb_InRemarks.ColumnFooterHeight = 18;
            this.cmb_InRemarks.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_InRemarks.ContentHeight = 16;
            this.cmb_InRemarks.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_InRemarks.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_InRemarks.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_InRemarks.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_InRemarks.EditorHeight = 16;
            this.cmb_InRemarks.EvenRowStyle = style2;
            this.cmb_InRemarks.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_InRemarks.FooterStyle = style3;
            this.cmb_InRemarks.HeadingStyle = style4;
            this.cmb_InRemarks.HighLightRowStyle = style5;
            this.cmb_InRemarks.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_InRemarks.Images"))));
            this.cmb_InRemarks.ItemHeight = 15;
            this.cmb_InRemarks.Location = new System.Drawing.Point(773, 143);
            this.cmb_InRemarks.MatchEntryTimeout = ((long)(2000));
            this.cmb_InRemarks.MaxDropDownItems = ((short)(5));
            this.cmb_InRemarks.MaxLength = 32767;
            this.cmb_InRemarks.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_InRemarks.Name = "cmb_InRemarks";
            this.cmb_InRemarks.OddRowStyle = style6;
            this.cmb_InRemarks.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_InRemarks.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_InRemarks.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_InRemarks.SelectedStyle = style7;
            this.cmb_InRemarks.Size = new System.Drawing.Size(220, 20);
            this.cmb_InRemarks.Style = style8;
            this.cmb_InRemarks.TabIndex = 566;
            this.cmb_InRemarks.PropBag = resources.GetString("cmb_InRemarks.PropBag");
            // 
            // lbl_InRemarks
            // 
            this.lbl_InRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_InRemarks.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InRemarks.ImageIndex = 0;
            this.lbl_InRemarks.ImageList = this.img_Label;
            this.lbl_InRemarks.Location = new System.Drawing.Point(672, 143);
            this.lbl_InRemarks.Name = "lbl_InRemarks";
            this.lbl_InRemarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_InRemarks.TabIndex = 565;
            this.lbl_InRemarks.Text = "Remarks";
            this.lbl_InRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style9;
            this.cmb_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_vendor.ColumnCaptionHeight = 18;
            this.cmb_vendor.ColumnFooterHeight = 18;
            this.cmb_vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_vendor.ContentHeight = 16;
            this.cmb_vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_vendor.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_vendor.EditorHeight = 16;
            this.cmb_vendor.EvenRowStyle = style10;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style11;
            this.cmb_vendor.HeadingStyle = style12;
            this.cmb_vendor.HighLightRowStyle = style13;
            this.cmb_vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_vendor.Images"))));
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(189, 77);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style14;
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style15;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style16;
            this.cmb_vendor.TabIndex = 564;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            // 
            // cmb_printtype
            // 
            this.cmb_printtype.AddItemSeparator = ';';
            this.cmb_printtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_printtype.Caption = "";
            this.cmb_printtype.CaptionHeight = 17;
            this.cmb_printtype.CaptionStyle = style17;
            this.cmb_printtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_printtype.ColumnCaptionHeight = 18;
            this.cmb_printtype.ColumnFooterHeight = 18;
            this.cmb_printtype.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_printtype.ContentHeight = 16;
            this.cmb_printtype.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_printtype.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_printtype.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_printtype.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_printtype.EditorHeight = 16;
            this.cmb_printtype.EvenRowStyle = style18;
            this.cmb_printtype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_printtype.FooterStyle = style19;
            this.cmb_printtype.HeadingStyle = style20;
            this.cmb_printtype.HighLightRowStyle = style21;
            this.cmb_printtype.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_printtype.Images"))));
            this.cmb_printtype.ItemHeight = 15;
            this.cmb_printtype.Location = new System.Drawing.Point(773, 121);
            this.cmb_printtype.MatchEntryTimeout = ((long)(2000));
            this.cmb_printtype.MaxDropDownItems = ((short)(5));
            this.cmb_printtype.MaxLength = 32767;
            this.cmb_printtype.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_printtype.Name = "cmb_printtype";
            this.cmb_printtype.OddRowStyle = style22;
            this.cmb_printtype.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_printtype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_printtype.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_printtype.SelectedStyle = style23;
            this.cmb_printtype.Size = new System.Drawing.Size(220, 20);
            this.cmb_printtype.Style = style24;
            this.cmb_printtype.TabIndex = 563;
            this.cmb_printtype.PropBag = resources.GetString("cmb_printtype.PropBag");
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style25;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 16;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 16;
            this.cmb_factory.EvenRowStyle = style26;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style27;
            this.cmb_factory.HeadingStyle = style28;
            this.cmb_factory.HighLightRowStyle = style29;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 34);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style30;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style31;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style32;
            this.cmb_factory.TabIndex = 562;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // chk_ship_date
            // 
            this.chk_ship_date.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_ship_date.Location = new System.Drawing.Point(642, 146);
            this.chk_ship_date.Name = "chk_ship_date";
            this.chk_ship_date.Size = new System.Drawing.Size(18, 16);
            this.chk_ship_date.TabIndex = 561;
            this.chk_ship_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_Ship_Date
            // 
            this.dpick_Ship_Date.CustomFormat = "";
            this.dpick_Ship_Date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_Ship_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_Ship_Date.Location = new System.Drawing.Point(440, 143);
            this.dpick_Ship_Date.Name = "dpick_Ship_Date";
            this.dpick_Ship_Date.Size = new System.Drawing.Size(200, 21);
            this.dpick_Ship_Date.TabIndex = 560;
            // 
            // lbl_Ship_Date
            // 
            this.lbl_Ship_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Ship_Date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ship_Date.ImageIndex = 0;
            this.lbl_Ship_Date.ImageList = this.img_Label;
            this.lbl_Ship_Date.Location = new System.Drawing.Point(339, 143);
            this.lbl_Ship_Date.Name = "lbl_Ship_Date";
            this.lbl_Ship_Date.Size = new System.Drawing.Size(100, 21);
            this.lbl_Ship_Date.TabIndex = 559;
            this.lbl_Ship_Date.Text = "Ship Date";
            this.lbl_Ship_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_pur_factory
            // 
            this.cmb_pur_factory.AddItemSeparator = ';';
            this.cmb_pur_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_pur_factory.Caption = "";
            this.cmb_pur_factory.CaptionHeight = 17;
            this.cmb_pur_factory.CaptionStyle = style33;
            this.cmb_pur_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_pur_factory.ColumnCaptionHeight = 18;
            this.cmb_pur_factory.ColumnFooterHeight = 18;
            this.cmb_pur_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_pur_factory.ContentHeight = 16;
            this.cmb_pur_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_pur_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_pur_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_pur_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_pur_factory.EditorHeight = 16;
            this.cmb_pur_factory.EvenRowStyle = style34;
            this.cmb_pur_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pur_factory.FooterStyle = style35;
            this.cmb_pur_factory.HeadingStyle = style36;
            this.cmb_pur_factory.HighLightRowStyle = style37;
            this.cmb_pur_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_pur_factory.Images"))));
            this.cmb_pur_factory.ItemHeight = 15;
            this.cmb_pur_factory.Location = new System.Drawing.Point(109, 143);
            this.cmb_pur_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_pur_factory.MaxDropDownItems = ((short)(5));
            this.cmb_pur_factory.MaxLength = 32767;
            this.cmb_pur_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_pur_factory.Name = "cmb_pur_factory";
            this.cmb_pur_factory.OddRowStyle = style38;
            this.cmb_pur_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_pur_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_pur_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_pur_factory.SelectedStyle = style39;
            this.cmb_pur_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_pur_factory.Style = style40;
            this.cmb_pur_factory.TabIndex = 557;
            this.cmb_pur_factory.PropBag = resources.GetString("cmb_pur_factory.PropBag");
            // 
            // lbl_SH_CDC
            // 
            this.lbl_SH_CDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SH_CDC.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SH_CDC.ImageIndex = 0;
            this.lbl_SH_CDC.ImageList = this.img_Label;
            this.lbl_SH_CDC.Location = new System.Drawing.Point(8, 143);
            this.lbl_SH_CDC.Name = "lbl_SH_CDC";
            this.lbl_SH_CDC.Size = new System.Drawing.Size(100, 21);
            this.lbl_SH_CDC.TabIndex = 558;
            this.lbl_SH_CDC.Text = "Pur Factory";
            this.lbl_SH_CDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_printtype
            // 
            this.lbl_printtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_printtype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_printtype.ImageIndex = 0;
            this.lbl_printtype.ImageList = this.img_Label;
            this.lbl_printtype.Location = new System.Drawing.Point(672, 121);
            this.lbl_printtype.Name = "lbl_printtype";
            this.lbl_printtype.Size = new System.Drawing.Size(100, 21);
            this.lbl_printtype.TabIndex = 420;
            this.lbl_printtype.Text = "Print Type";
            this.lbl_printtype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_not_ss
            // 
            this.chk_not_ss.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_not_ss.Location = new System.Drawing.Point(643, 36);
            this.chk_not_ss.Name = "chk_not_ss";
            this.chk_not_ss.Size = new System.Drawing.Size(19, 16);
            this.chk_not_ss.TabIndex = 419;
            this.chk_not_ss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_not_ss.CheckedChanged += new System.EventHandler(this.chk_not_ss_CheckedChanged);
            // 
            // cmb_inType
            // 
            this.cmb_inType.AddItemSeparator = ';';
            this.cmb_inType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inType.Caption = "";
            this.cmb_inType.CaptionHeight = 17;
            this.cmb_inType.CaptionStyle = style41;
            this.cmb_inType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inType.ColumnCaptionHeight = 18;
            this.cmb_inType.ColumnFooterHeight = 18;
            this.cmb_inType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inType.ContentHeight = 16;
            this.cmb_inType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_inType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inType.EditorHeight = 16;
            this.cmb_inType.EvenRowStyle = style42;
            this.cmb_inType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inType.FooterStyle = style43;
            this.cmb_inType.HeadingStyle = style44;
            this.cmb_inType.HighLightRowStyle = style45;
            this.cmb_inType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_inType.Images"))));
            this.cmb_inType.ItemHeight = 15;
            this.cmb_inType.Location = new System.Drawing.Point(440, 121);
            this.cmb_inType.MatchEntryTimeout = ((long)(2000));
            this.cmb_inType.MaxDropDownItems = ((short)(5));
            this.cmb_inType.MaxLength = 32767;
            this.cmb_inType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inType.Name = "cmb_inType";
            this.cmb_inType.OddRowStyle = style46;
            this.cmb_inType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inType.SelectedStyle = style47;
            this.cmb_inType.Size = new System.Drawing.Size(220, 20);
            this.cmb_inType.Style = style48;
            this.cmb_inType.TabIndex = 418;
            this.cmb_inType.PropBag = resources.GetString("cmb_inType.PropBag");
            // 
            // lbl_inType
            // 
            this.lbl_inType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inType.ImageIndex = 1;
            this.lbl_inType.ImageList = this.img_Label;
            this.lbl_inType.Location = new System.Drawing.Point(339, 121);
            this.lbl_inType.Name = "lbl_inType";
            this.lbl_inType.Size = new System.Drawing.Size(100, 21);
            this.lbl_inType.TabIndex = 417;
            this.lbl_inType.Text = "Incoming Type";
            this.lbl_inType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_headInfo
            // 
            this.lbl_headInfo.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_headInfo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_headInfo.ForeColor = System.Drawing.Color.Navy;
            this.lbl_headInfo.Image = ((System.Drawing.Image)(resources.GetObject("lbl_headInfo.Image")));
            this.lbl_headInfo.Location = new System.Drawing.Point(0, 0);
            this.lbl_headInfo.Name = "lbl_headInfo";
            this.lbl_headInfo.Size = new System.Drawing.Size(231, 30);
            this.lbl_headInfo.TabIndex = 416;
            this.lbl_headInfo.Text = "       Item Inspection  Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.Location = new System.Drawing.Point(772, 77);
            this.txt_styleCd.MaxLength = 10;
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCd.TabIndex = 415;
            this.txt_styleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCd_KeyUp);
            // 
            // txt_lotNo
            // 
            this.txt_lotNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lotNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_lotNo.Location = new System.Drawing.Point(772, 99);
            this.txt_lotNo.MaxLength = 10;
            this.txt_lotNo.Name = "txt_lotNo";
            this.txt_lotNo.Size = new System.Drawing.Size(220, 21);
            this.txt_lotNo.TabIndex = 414;
            // 
            // lbl_lotNo
            // 
            this.lbl_lotNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_lotNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lotNo.ImageIndex = 0;
            this.lbl_lotNo.ImageList = this.img_Label;
            this.lbl_lotNo.Location = new System.Drawing.Point(672, 99);
            this.lbl_lotNo.Name = "lbl_lotNo";
            this.lbl_lotNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_lotNo.TabIndex = 413;
            this.lbl_lotNo.Text = "Lot No";
            this.lbl_lotNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_searchType
            // 
            this.cmb_searchType.AddItemSeparator = ';';
            this.cmb_searchType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_searchType.Caption = "";
            this.cmb_searchType.CaptionHeight = 17;
            this.cmb_searchType.CaptionStyle = style49;
            this.cmb_searchType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_searchType.ColumnCaptionHeight = 18;
            this.cmb_searchType.ColumnFooterHeight = 18;
            this.cmb_searchType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_searchType.ContentHeight = 16;
            this.cmb_searchType.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_searchType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_searchType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_searchType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_searchType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_searchType.EditorHeight = 16;
            this.cmb_searchType.EvenRowStyle = style50;
            this.cmb_searchType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_searchType.FooterStyle = style51;
            this.cmb_searchType.HeadingStyle = style52;
            this.cmb_searchType.HighLightRowStyle = style53;
            this.cmb_searchType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_searchType.Images"))));
            this.cmb_searchType.ItemHeight = 15;
            this.cmb_searchType.Location = new System.Drawing.Point(109, 121);
            this.cmb_searchType.MatchEntryTimeout = ((long)(2000));
            this.cmb_searchType.MaxDropDownItems = ((short)(5));
            this.cmb_searchType.MaxLength = 32767;
            this.cmb_searchType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_searchType.Name = "cmb_searchType";
            this.cmb_searchType.OddRowStyle = style54;
            this.cmb_searchType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_searchType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_searchType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_searchType.SelectedStyle = style55;
            this.cmb_searchType.Size = new System.Drawing.Size(220, 20);
            this.cmb_searchType.Style = style56;
            this.cmb_searchType.TabIndex = 412;
            this.cmb_searchType.SelectedValueChanged += new System.EventHandler(this.cmb_searchType_SelectedValueChanged);
            this.cmb_searchType.PropBag = resources.GetString("cmb_searchType.PropBag");
            // 
            // lbl_searchType
            // 
            this.lbl_searchType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_searchType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchType.ImageIndex = 1;
            this.lbl_searchType.ImageList = this.img_Label;
            this.lbl_searchType.Location = new System.Drawing.Point(8, 121);
            this.lbl_searchType.Name = "lbl_searchType";
            this.lbl_searchType.Size = new System.Drawing.Size(100, 21);
            this.lbl_searchType.TabIndex = 411;
            this.lbl_searchType.Text = "Search Type";
            this.lbl_searchType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_barKind
            // 
            this.cmb_barKind.AddItemSeparator = ';';
            this.cmb_barKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_barKind.Caption = "";
            this.cmb_barKind.CaptionHeight = 17;
            this.cmb_barKind.CaptionStyle = style57;
            this.cmb_barKind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_barKind.ColumnCaptionHeight = 18;
            this.cmb_barKind.ColumnFooterHeight = 18;
            this.cmb_barKind.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_barKind.ContentHeight = 16;
            this.cmb_barKind.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_barKind.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_barKind.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_barKind.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_barKind.EditorHeight = 16;
            this.cmb_barKind.EvenRowStyle = style58;
            this.cmb_barKind.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barKind.FooterStyle = style59;
            this.cmb_barKind.HeadingStyle = style60;
            this.cmb_barKind.HighLightRowStyle = style61;
            this.cmb_barKind.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_barKind.Images"))));
            this.cmb_barKind.ItemHeight = 15;
            this.cmb_barKind.Location = new System.Drawing.Point(440, 99);
            this.cmb_barKind.MatchEntryTimeout = ((long)(2000));
            this.cmb_barKind.MaxDropDownItems = ((short)(5));
            this.cmb_barKind.MaxLength = 32767;
            this.cmb_barKind.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_barKind.Name = "cmb_barKind";
            this.cmb_barKind.OddRowStyle = style62;
            this.cmb_barKind.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_barKind.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_barKind.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_barKind.SelectedStyle = style63;
            this.cmb_barKind.Size = new System.Drawing.Size(220, 20);
            this.cmb_barKind.Style = style64;
            this.cmb_barKind.TabIndex = 410;
            this.cmb_barKind.PropBag = resources.GetString("cmb_barKind.PropBag");
            // 
            // lbl_barKind
            // 
            this.lbl_barKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_barKind.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barKind.ImageIndex = 0;
            this.lbl_barKind.ImageList = this.img_Label;
            this.lbl_barKind.Location = new System.Drawing.Point(339, 99);
            this.lbl_barKind.Name = "lbl_barKind";
            this.lbl_barKind.Size = new System.Drawing.Size(100, 21);
            this.lbl_barKind.TabIndex = 409;
            this.lbl_barKind.Text = "Barcode Kind";
            this.lbl_barKind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(852, 55);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(140, 21);
            this.txt_itemNm.TabIndex = 408;
            // 
            // cmb_user
            // 
            this.cmb_user.AddItemSeparator = ';';
            this.cmb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_user.Caption = "";
            this.cmb_user.CaptionHeight = 17;
            this.cmb_user.CaptionStyle = style65;
            this.cmb_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_user.ColumnCaptionHeight = 18;
            this.cmb_user.ColumnFooterHeight = 18;
            this.cmb_user.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_user.ContentHeight = 16;
            this.cmb_user.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_user.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_user.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_user.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_user.EditorHeight = 16;
            this.cmb_user.EvenRowStyle = style66;
            this.cmb_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FooterStyle = style67;
            this.cmb_user.HeadingStyle = style68;
            this.cmb_user.HighLightRowStyle = style69;
            this.cmb_user.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_user.Images"))));
            this.cmb_user.ItemHeight = 15;
            this.cmb_user.Location = new System.Drawing.Point(109, 99);
            this.cmb_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_user.MaxDropDownItems = ((short)(5));
            this.cmb_user.MaxLength = 32767;
            this.cmb_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.OddRowStyle = style70;
            this.cmb_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_user.SelectedStyle = style71;
            this.cmb_user.Size = new System.Drawing.Size(220, 20);
            this.cmb_user.Style = style72;
            this.cmb_user.TabIndex = 390;
            this.cmb_user.PropBag = resources.GetString("cmb_user.PropBag");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 18);
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style73;
            this.cmb_itemGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_itemGroup.ColumnCaptionHeight = 18;
            this.cmb_itemGroup.ColumnFooterHeight = 18;
            this.cmb_itemGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_itemGroup.ContentHeight = 16;
            this.cmb_itemGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_itemGroup.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_itemGroup.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_itemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_itemGroup.EditorHeight = 16;
            this.cmb_itemGroup.EvenRowStyle = style74;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style75;
            this.cmb_itemGroup.HeadingStyle = style76;
            this.cmb_itemGroup.HighLightRowStyle = style77;
            this.cmb_itemGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_itemGroup.Images"))));
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(772, 33);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style78;
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style79;
            this.cmb_itemGroup.Size = new System.Drawing.Size(197, 20);
            this.cmb_itemGroup.Style = style80;
            this.cmb_itemGroup.TabIndex = 404;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(968, 33);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 403;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(772, 55);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(79, 21);
            this.txt_itemCd.TabIndex = 402;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(672, 55);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 401;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(671, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 400;
            this.label1.Text = "Item Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style81;
            this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_style.ColumnCaptionHeight = 18;
            this.cmb_style.ColumnFooterHeight = 18;
            this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_style.ContentHeight = 16;
            this.cmb_style.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_style.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_style.EditorHeight = 16;
            this.cmb_style.EvenRowStyle = style82;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style83;
            this.cmb_style.HeadingStyle = style84;
            this.cmb_style.HighLightRowStyle = style85;
            this.cmb_style.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_style.Images"))));
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(852, 77);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style86;
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style87;
            this.cmb_style.Size = new System.Drawing.Size(140, 20);
            this.cmb_style.Style = style88;
            this.cmb_style.TabIndex = 395;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            // 
            // lbl_styleCd
            // 
            this.lbl_styleCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_styleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_styleCd.ImageIndex = 0;
            this.lbl_styleCd.ImageList = this.img_Label;
            this.lbl_styleCd.Location = new System.Drawing.Point(672, 77);
            this.lbl_styleCd.Name = "lbl_styleCd";
            this.lbl_styleCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_styleCd.TabIndex = 394;
            this.lbl_styleCd.Text = "Style";
            this.lbl_styleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ImageIndex = 0;
            this.lbl_user.ImageList = this.img_Label;
            this.lbl_user.Location = new System.Drawing.Point(8, 99);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_user.TabIndex = 391;
            this.lbl_user.Text = "User";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(8, 77);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 389;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(109, 77);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 387;
            this.txt_vendorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vendorCode_KeyPress);
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(212, 56);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(8, 16);
            this.lblexcep_mark.TabIndex = 386;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(230, 55);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(99, 21);
            this.dpick_to.TabIndex = 385;
            this.dpick_to.CloseUp += new System.EventHandler(this.dpick_from_CloseUp_1);
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 55);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(99, 21);
            this.dpick_from.TabIndex = 381;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp_1);
            // 
            // cmb_purDiv
            // 
            this.cmb_purDiv.AddItemSeparator = ';';
            this.cmb_purDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purDiv.Caption = "";
            this.cmb_purDiv.CaptionHeight = 17;
            this.cmb_purDiv.CaptionStyle = style89;
            this.cmb_purDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purDiv.ColumnCaptionHeight = 18;
            this.cmb_purDiv.ColumnFooterHeight = 18;
            this.cmb_purDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purDiv.ContentHeight = 16;
            this.cmb_purDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_purDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purDiv.EditorHeight = 16;
            this.cmb_purDiv.EvenRowStyle = style90;
            this.cmb_purDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purDiv.FooterStyle = style91;
            this.cmb_purDiv.HeadingStyle = style92;
            this.cmb_purDiv.HighLightRowStyle = style93;
            this.cmb_purDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_purDiv.Images"))));
            this.cmb_purDiv.ItemHeight = 15;
            this.cmb_purDiv.Location = new System.Drawing.Point(440, 33);
            this.cmb_purDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_purDiv.MaxDropDownItems = ((short)(5));
            this.cmb_purDiv.MaxLength = 32767;
            this.cmb_purDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purDiv.Name = "cmb_purDiv";
            this.cmb_purDiv.OddRowStyle = style94;
            this.cmb_purDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.SelectedStyle = style95;
            this.cmb_purDiv.Size = new System.Drawing.Size(200, 20);
            this.cmb_purDiv.Style = style96;
            this.cmb_purDiv.TabIndex = 362;
            this.cmb_purDiv.PropBag = resources.GetString("cmb_purDiv.PropBag");
            // 
            // cmb_buyDiv
            // 
            this.cmb_buyDiv.AddItemSeparator = ';';
            this.cmb_buyDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_buyDiv.Caption = "";
            this.cmb_buyDiv.CaptionHeight = 17;
            this.cmb_buyDiv.CaptionStyle = style97;
            this.cmb_buyDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_buyDiv.ColumnCaptionHeight = 18;
            this.cmb_buyDiv.ColumnFooterHeight = 18;
            this.cmb_buyDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_buyDiv.ContentHeight = 16;
            this.cmb_buyDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_buyDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_buyDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_buyDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_buyDiv.EditorHeight = 16;
            this.cmb_buyDiv.EvenRowStyle = style98;
            this.cmb_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_buyDiv.FooterStyle = style99;
            this.cmb_buyDiv.HeadingStyle = style100;
            this.cmb_buyDiv.HighLightRowStyle = style101;
            this.cmb_buyDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_buyDiv.Images"))));
            this.cmb_buyDiv.ItemHeight = 15;
            this.cmb_buyDiv.Location = new System.Drawing.Point(440, 55);
            this.cmb_buyDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_buyDiv.MaxDropDownItems = ((short)(5));
            this.cmb_buyDiv.MaxLength = 32767;
            this.cmb_buyDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_buyDiv.Name = "cmb_buyDiv";
            this.cmb_buyDiv.OddRowStyle = style102;
            this.cmb_buyDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_buyDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.SelectedStyle = style103;
            this.cmb_buyDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_buyDiv.Style = style104;
            this.cmb_buyDiv.TabIndex = 361;
            this.cmb_buyDiv.PropBag = resources.GetString("cmb_buyDiv.PropBag");
            // 
            // lbl_buyDiv
            // 
            this.lbl_buyDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buyDiv.ImageIndex = 0;
            this.lbl_buyDiv.ImageList = this.img_Label;
            this.lbl_buyDiv.Location = new System.Drawing.Point(339, 55);
            this.lbl_buyDiv.Name = "lbl_buyDiv";
            this.lbl_buyDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_buyDiv.TabIndex = 360;
            this.lbl_buyDiv.Text = "Buy Division";
            this.lbl_buyDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_purDiv
            // 
            this.lbl_purDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purDiv.ImageIndex = 0;
            this.lbl_purDiv.ImageList = this.img_Label;
            this.lbl_purDiv.Location = new System.Drawing.Point(339, 33);
            this.lbl_purDiv.Name = "lbl_purDiv";
            this.lbl_purDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_purDiv.TabIndex = 359;
            this.lbl_purDiv.Text = "Pur  Division";
            this.lbl_purDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_priceYn
            // 
            this.cmb_priceYn.AddItemSeparator = ';';
            this.cmb_priceYn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_priceYn.Caption = "";
            this.cmb_priceYn.CaptionHeight = 17;
            this.cmb_priceYn.CaptionStyle = style105;
            this.cmb_priceYn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_priceYn.ColumnCaptionHeight = 18;
            this.cmb_priceYn.ColumnFooterHeight = 18;
            this.cmb_priceYn.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_priceYn.ContentHeight = 16;
            this.cmb_priceYn.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_priceYn.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_priceYn.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_priceYn.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_priceYn.EditorHeight = 16;
            this.cmb_priceYn.EvenRowStyle = style106;
            this.cmb_priceYn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_priceYn.FooterStyle = style107;
            this.cmb_priceYn.HeadingStyle = style108;
            this.cmb_priceYn.HighLightRowStyle = style109;
            this.cmb_priceYn.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_priceYn.Images"))));
            this.cmb_priceYn.ItemHeight = 15;
            this.cmb_priceYn.Location = new System.Drawing.Point(440, 77);
            this.cmb_priceYn.MatchEntryTimeout = ((long)(2000));
            this.cmb_priceYn.MaxDropDownItems = ((short)(5));
            this.cmb_priceYn.MaxLength = 32767;
            this.cmb_priceYn.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_priceYn.Name = "cmb_priceYn";
            this.cmb_priceYn.OddRowStyle = style110;
            this.cmb_priceYn.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_priceYn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_priceYn.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_priceYn.SelectedStyle = style111;
            this.cmb_priceYn.Size = new System.Drawing.Size(220, 20);
            this.cmb_priceYn.Style = style112;
            this.cmb_priceYn.TabIndex = 358;
            this.cmb_priceYn.PropBag = resources.GetString("cmb_priceYn.PropBag");
            // 
            // lbl_priceYN
            // 
            this.lbl_priceYN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_priceYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priceYN.ImageIndex = 0;
            this.lbl_priceYN.ImageList = this.img_Label;
            this.lbl_priceYN.Location = new System.Drawing.Point(339, 77);
            this.lbl_priceYN.Name = "lbl_priceYN";
            this.lbl_priceYN.Size = new System.Drawing.Size(100, 21);
            this.lbl_priceYN.TabIndex = 357;
            this.lbl_priceYN.Text = "Price Y/N";
            this.lbl_priceYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 152);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_inYmd
            // 
            this.lbl_inYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inYmd.ImageIndex = 1;
            this.lbl_inYmd.ImageList = this.img_Label;
            this.lbl_inYmd.Location = new System.Drawing.Point(8, 55);
            this.lbl_inYmd.Name = "lbl_inYmd";
            this.lbl_inYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_inYmd.TabIndex = 50;
            this.lbl_inYmd.Text = "Incoming Date";
            this.lbl_inYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 33);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 50;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 127);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(984, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 152);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 16);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 141);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(112, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(968, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // ctx_main
            // 
            this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_factory,
            this.mnu_vendor,
            this.mnu_material,
            this.mnu_spec,
            this.mnu_color,
            this.mnu_classtype,
            this.mnu_firstclass,
            this.mnu_secondclass,
            this.mnu_item,
            this.mnu_ymd,
            this.mnu_date,
            this.mnu_all});
            // 
            // mnu_factory
            // 
            this.mnu_factory.Index = 0;
            this.mnu_factory.Text = "Factory Viewer";
            this.mnu_factory.Click += new System.EventHandler(this.mnu_factory_Click);
            // 
            // mnu_vendor
            // 
            this.mnu_vendor.Index = 1;
            this.mnu_vendor.Text = "Vendor Viewer";
            this.mnu_vendor.Click += new System.EventHandler(this.mnu_vendor_Click);
            // 
            // mnu_material
            // 
            this.mnu_material.Index = 2;
            this.mnu_material.Text = "Material Viewer";
            this.mnu_material.Click += new System.EventHandler(this.mnu_material_Click);
            // 
            // mnu_spec
            // 
            this.mnu_spec.Index = 3;
            this.mnu_spec.Text = "Spec Viewer";
            this.mnu_spec.Click += new System.EventHandler(this.mnu_spec_Click);
            // 
            // mnu_color
            // 
            this.mnu_color.Index = 4;
            this.mnu_color.Text = "Color Viewer";
            this.mnu_color.Click += new System.EventHandler(this.mnu_color_Click);
            // 
            // mnu_classtype
            // 
            this.mnu_classtype.Index = 5;
            this.mnu_classtype.Text = "Class Type Viewer";
            this.mnu_classtype.Click += new System.EventHandler(this.mnu_classtype_Click);
            // 
            // mnu_firstclass
            // 
            this.mnu_firstclass.Index = 6;
            this.mnu_firstclass.Text = "First Class Viewer";
            this.mnu_firstclass.Click += new System.EventHandler(this.mnu_firstclass_Click);
            // 
            // mnu_secondclass
            // 
            this.mnu_secondclass.Index = 7;
            this.mnu_secondclass.Text = "Second Class Viewer";
            this.mnu_secondclass.Click += new System.EventHandler(this.mnu_secondclass_Click);
            // 
            // mnu_item
            // 
            this.mnu_item.Index = 8;
            this.mnu_item.Text = "Item Viewer";
            this.mnu_item.Click += new System.EventHandler(this.mnu_item_Click);
            // 
            // mnu_ymd
            // 
            this.mnu_ymd.Index = 9;
            this.mnu_ymd.Text = "Date Viewer";
            this.mnu_ymd.Click += new System.EventHandler(this.mnu_ymd_Click);
            // 
            // mnu_date
            // 
            this.mnu_date.Index = 10;
            this.mnu_date.Text = "In Date View";
            this.mnu_date.Click += new System.EventHandler(this.mnu_date_Click);
            // 
            // mnu_all
            // 
            this.mnu_all.Index = 11;
            this.mnu_all.Text = "All Viewer";
            this.mnu_all.Click += new System.EventHandler(this.mnu_all_Click);
            // 
            // Form_BI_Incoming_Item_Inspection
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BI_Incoming_Item_Inspection";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_InRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_searchType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barKind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_priceYn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	
		#region 그리드 이벤트 처리

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
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

		private void cmb_vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_factory.SelectedIndex == -1 || cmb_vendor.SelectedIndex == -1) return;

				Cmb_VendorSelectedValueChangedProcess();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_vendor_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}

		private void txt_vendorCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			try
			{
				if ((int)e.KeyChar != 13) return;

				cmb_vendor.SelectedIndex = -1;

				Txt_VendorCodeTextChangedProcess();		
				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_styleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 스타일 콤보박스 세팅
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txt_styleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				cmb_style.SelectedIndex = -1;

				DataTable dt_ret;
				
				dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCd, " ") ); 
				 
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_style, 0, 1, 2, 3, 4, true, 80, 200); 

				//ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_style, 0, 1,  true, 79, 141);
				if (dt_ret.Rows.Count > 0 && dt_ret.Rows.Count < 2)
					cmb_style.SelectedIndex = 0;
				else if (dt_ret == null || dt_ret.Rows.Count <= 0) 
					cmb_vendor.SelectedIndex = -1; 

				dt_ret.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_styleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}	

		private void cmb_style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_factory.SelectedIndex == -1 || cmb_style.SelectedIndex == -1) return;

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name

				txt_styleCd.Text = cmb_style.SelectedValue.ToString();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_style_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        string _sel_group_cd = "";
		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
			string vTyep = this.cmb_itemGroup.SelectedValue.ToString();
			FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);

			vPopup.ShowDialog();
			
			string _group_cd	= COM.ComVar.Parameter_PopUp[3];
			string _group_name	= COM.ComVar.Parameter_PopUp[4];
			//txt_itemCd.Text		= _group_cd;
			//txt_itemNm.Text		= _group_name;
            _sel_group_cd = _group_cd;
			
			vPopup.Dispose();		
		}

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
            if (cmb_itemGroup.SelectedIndex >= 0)
            {
                this.btn_groupSearch.Enabled = true;
            }
            else
            {
                this.btn_groupSearch.Enabled = false;
            }

            _sel_group_cd = COM.ComFunction.Empty_Combo(cmb_itemGroup, "");
		}

		private void cmb_searchType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_SearchTypeSelectedValueChangedProcess();
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			dpick_to.Value = dpick_from.Value; 
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{	
				if (e.Button == MouseButtons.Right && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
				{
		
					_vSelType = cmb_searchType.SelectedIndex > 0 ? cmb_searchType.SelectedValue.ToString() : "M";
					switch (_vSelType)
					{
						case ("M") :
							mnu_all.Visible			= true; 
							mnu_vendor.Visible		= true; 
							mnu_item.Visible		= true;
							mnu_color.Visible       = true;
							mnu_date.Visible        = true;
							

							mnu_vendor.Index		= 0; 
							mnu_item.Index			= 1;
							mnu_color.Index         = 2;
							mnu_all.Index			= 3;

							mnu_factory.Visible		= false; 
							mnu_ymd.Visible			= false; 
							mnu_classtype.Visible	= false; 
							mnu_firstclass.Visible	= false; 
							mnu_secondclass.Visible	= false;
							mnu_material.Visible    = false;
							mnu_spec.Visible        = false;

							break;

						case ("F") :
							mnu_all.Visible			= true; 
							mnu_factory.Visible		= true; 
							mnu_vendor.Visible		= true; 
							mnu_item.Visible		= true; 

							mnu_factory.Index		= 0; 
							mnu_vendor.Index		= 1; 
							mnu_item.Index			= 2; 
							mnu_all.Index			= 3; 

							mnu_ymd.Visible			= false; 
							mnu_classtype.Visible	= false; 
							mnu_firstclass.Visible	= false; 
							mnu_secondclass.Visible	= false; 
							mnu_material.Visible	= false; 
							mnu_color.Visible       = false;
							mnu_spec.Visible        = false;
							mnu_date.Visible        = false;
							break;

						case ("V") :
							mnu_all.Visible			= true; 
							mnu_factory.Visible		= true; 
							mnu_vendor.Visible		= true; 

							mnu_factory.Index		= 0; 
							mnu_vendor.Index		= 1; 
							mnu_all.Index			= 2; 

							mnu_item.Visible		= false; 
							mnu_ymd.Visible			= false; 
							mnu_classtype.Visible	= false; 
							mnu_firstclass.Visible	= false; 
							mnu_secondclass.Visible	= false; 
							mnu_material.Visible	= false; 
							mnu_color.Visible       = false;
							mnu_spec.Visible        = false;
							mnu_date.Visible        = false;
							break;

						case ("D") :
							mnu_all.Visible			= true; 
							mnu_ymd.Visible			= true; 
							mnu_vendor.Visible		= true; 

							mnu_ymd.Index			= 0; 
							mnu_vendor.Index		= 1; 
							mnu_all.Index			= 2; 

							mnu_item.Visible		= false; 
							mnu_classtype.Visible	= false; 
							mnu_firstclass.Visible	= false; 
							mnu_secondclass.Visible	= false; 
							mnu_material.Visible	= false; 
							mnu_color.Visible       = false;
							mnu_spec.Visible        = false;
							mnu_date.Visible        = false;
							mnu_factory.Visible		= false;
							break;

						case ("C") :
							mnu_all.Visible			= true; 
							mnu_classtype.Visible	= true; 
							mnu_firstclass.Visible	= true; 
							mnu_secondclass.Visible	= true; 

							mnu_classtype.Index		= 0; 
							mnu_firstclass.Index	= 1; 
							mnu_secondclass.Index	= 2; 
							mnu_all.Index			= 3; 

							mnu_item.Visible		= false; 
							mnu_ymd.Visible			= false; 
							mnu_vendor.Visible		= false; 
							mnu_material.Visible	= false; 
							mnu_color.Visible       = false;
							mnu_spec.Visible        = false;
							mnu_date.Visible        = false;
							mnu_factory.Visible		= false;
							break;

						case ("A") :
							mnu_all.Visible			= true; 
							mnu_ymd.Visible			= true; 
							mnu_item.Visible		= true; 

							mnu_ymd.Index			= 0; 
							mnu_item.Index			= 1; 
							mnu_all.Index			= 2; 

							mnu_vendor.Visible		= false; 
							mnu_classtype.Visible	= false; 
							mnu_firstclass.Visible	= false; 
							mnu_secondclass.Visible	= false; 
							mnu_material.Visible	= false; 
							mnu_color.Visible       = false;
							mnu_spec.Visible        = false;
							mnu_date.Visible        = false;
							mnu_factory.Visible		= false;
							break;

						case ("H") :
							mnu_all.Visible			= true; 
							mnu_vendor.Visible		= true; 
							mnu_item.Visible		= true; 

							mnu_vendor.Index		= 0; 
							mnu_item.Index			= 1; 
							mnu_all.Index			= 2; 

							mnu_ymd.Visible			= false; 
							mnu_classtype.Visible	= false; 
							mnu_firstclass.Visible	= false; 
							mnu_secondclass.Visible	= false; 
							mnu_material.Visible	= false; 
							mnu_color.Visible       = false;
							mnu_spec.Visible        = false;
							mnu_date.Visible        = false;
							mnu_factory.Visible		= false;
							break;
					}

					ctx_main.Show(fgrid_main, new Point(e.X, e.Y));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void chk_not_ss_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chk_not_ss.Checked) cmb_purDiv.Enabled = false;
			else cmb_purDiv.Enabled = true;
		}

        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            Cmb_inNoSettingProcess();
        }

        private void dpick_from_CloseUp_1(object sender, EventArgs e)
        {
            Cmb_inNoSettingProcess();
        }


		#region 입력이동

		#endregion

		#region 버튼효과

		#endregion

		#region 컨텍스트 메뉴


		private void mnu_all_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(true);
			tree_level = mnu_all.Index+1;
			fgrid_main.Tree.Show(mnu_all.Index+1);		
		}

		private void mnu_vendor_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(true);
			tree_level = mnu_vendor.Index+1;
			fgrid_main.Tree.Show(mnu_vendor.Index+1);		
		}

		private void mnu_material_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(true);
			tree_level = mnu_material.Index+1;
			fgrid_main.Tree.Show(mnu_material.Index+1);		
		}

		private void mnu_classtype_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(true);
			tree_level = mnu_classtype.Index+1;
			fgrid_main.Tree.Show(mnu_classtype.Index+1);		
		}

		private void mnu_firstclass_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(true);
			tree_level = mnu_firstclass.Index+1;
			fgrid_main.Tree.Show(mnu_firstclass.Index+1);		
		}

		private void mnu_secondclass_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(true);
			tree_level = mnu_secondclass.Index+1;
			fgrid_main.Tree.Show(mnu_secondclass.Index+1);		
		}

		private void mnu_factory_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(true);
			tree_level = mnu_factory.Index+1;
			fgrid_main.Tree.Show(mnu_factory.Index+1);		
		}

		private void mnu_item_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(true);
			tree_level = mnu_item.Index+1;
			fgrid_main.Tree.Show(mnu_item.Index+1);		
		}

		private void mnu_ymd_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(true);
			tree_level = mnu_ymd.Index+1;
			fgrid_main.Tree.Show(mnu_ymd.Index+1);		
		}

		private void mnu_color_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(true);
			tree_level = mnu_color.Index+1;
			fgrid_main.Tree.Show(mnu_color.Index+1);		
		}

		private void mnu_spec_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(true);
			tree_level = mnu_spec.Index+1;
			fgrid_main.Tree.Show(mnu_spec.Index+1);		
		}

		private void mnu_date_Click(object sender, System.EventArgs e)
		{
			Set_M_Grid_Type(false);
		}


		private void Set_M_Grid_Type(bool arg_bool)
		{
			if(cmb_searchType.SelectedValue.ToString() == "M")
			{
				if(arg_bool)
				{
					date_view = false;

					fgrid_main.SubtotalPosition = SubtotalPositionEnum.AboveData;								
					fgrid_main.AllowDragging	= AllowDraggingEnum.None;

					fgrid_main.Subtotal(AggregateEnum.Clear);
					for (int c = 1; c < fgrid_main.Cols.Count; c++)
					{
						if (c != _lxMPurPriceCol && c != _lxCPurPriceCol && fgrid_main.Cols[c].Style.Name.ToString().StartsWith("NUMBER"))
						{
							fgrid_main.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, _lxMorderByCol/*_lxMCustCdCol, _lxMItemNameCol*//*, _lxMSpecNameCol, _lxMColorNameCol*/);  // CUST_NAME, ITEM_NAME
							// calculate subtotals (three levels, totals on every column)
							fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1,			   c, "Total");

							//fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxMCustNameCol, _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxMCustNameCol, c, "{0}");


							//fgrid_main.Subtotal(AggregateEnum.Max, 2, _lxMItemNameCol, _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxMItemNameCol, c, "{0}");
							
							
							fgrid_main.Subtotal(AggregateEnum.Max, 3, _lxMColorNameCol, _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxMColorNameCol, c, "{0}");
						}
					}
				}
				else
				{
					date_view = true;
					
					fgrid_main.SubtotalPosition = SubtotalPositionEnum.AboveData;								
					fgrid_main.AllowDragging	= AllowDraggingEnum.None;

					fgrid_main.Subtotal(AggregateEnum.Clear);
					for (int c = 1; c < fgrid_main.Cols.Count; c++)
					{
						if (c != _lxMPurPriceCol && c != _lxCPurPriceCol && fgrid_main.Cols[c].Style.Name.ToString().StartsWith("NUMBER"))
						{
							fgrid_main.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, _lxMorderByCol/*_lxMCustCdCol, _lxMItemNameCol*//*, _lxMSpecNameCol, _lxMColorNameCol*/);  // CUST_NAME, ITEM_NAME
							// calculate subtotals (three levels, totals on every column)
							fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1,			   c, "Total");

							//fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxMCustNameCol, _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxMCustNameCol, c, "{0}");


							//fgrid_main.Subtotal(AggregateEnum.Max, 2, _lxMItemNameCol, _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxMItemNameCol, c, "{0}");
							
							
							fgrid_main.Subtotal(AggregateEnum.Max, 3, _lxMColorNameCol, _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxMColorNameCol, c, "{0}");

							//fgrid_main.Subtotal(AggregateEnum.Max, 4, _lxMInYmdCol,        _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 4, _lxMInYmdCol,        c, "{0}");
						}
					}
				}

				tbtn_Print.Enabled = arg_bool;
			}
		}

		#endregion

		#endregion

		#region 공통 메서드

		#endregion

		#region DB 컨넥트

		/// <summary>
		/// PKG_SBI_IN_ADJUST_VENDOR : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_style_cd">스타일코드</param>
		/// <param name="arg_gender">젠더</param>
		/// <param name="arg_dev">Dev</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_ITEM_INSPECTION_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(21);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ITEM_INSPECTION.SELECT_ITEM_INSPECTION_LIST01";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_IN_TO";
			MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[4] = "ARG_USER";
			MyOraDB.Parameter_Name[5] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[7] = "ARG_ITEM_NM";
			MyOraDB.Parameter_Name[8] = "ARG_BUY_DIV";
			MyOraDB.Parameter_Name[9] = "ARG_PUR_DIV";
			MyOraDB.Parameter_Name[10]= "ARG_PRICE_YN";
			MyOraDB.Parameter_Name[11]= "ARG_BAR_KIND";
			MyOraDB.Parameter_Name[12]= "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[13]= "ARG_LOT_NO";
			MyOraDB.Parameter_Name[14]= "ARG_BAR_MOVE";
			MyOraDB.Parameter_Name[15]= "ARG_IN_TYPE";
			MyOraDB.Parameter_Name[16]= "ARG_LOC_FACTORY";
			MyOraDB.Parameter_Name[17]= "ARG_SS_NOT_IN";
            MyOraDB.Parameter_Name[18]= "ARG_PUR_FACTORY";
			MyOraDB.Parameter_Name[19]= "ARG_SHIP_YMD";			
			MyOraDB.Parameter_Name[20]= "OUT_CURSOR";

			//03.DATA TYPE 정의
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
			MyOraDB.Parameter_Type[10]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[12]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[13]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[14]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[15]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[16]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[17]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[18]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[19]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[20]= (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = this.cmb_factory.SelectedIndex > -1 ? this.cmb_factory.SelectedValue.ToString() : "";
			MyOraDB.Parameter_Values[1] = this.dpick_from.Text.Replace("-","");
			MyOraDB.Parameter_Values[2] = this.dpick_to.Text.Replace("-","");
			MyOraDB.Parameter_Values[3] = this.cmb_vendor.SelectedIndex  > -1 ? this.cmb_vendor.SelectedValue.ToString()  : "";
			MyOraDB.Parameter_Values[4] = this.cmb_user.SelectedIndex    > -1 ? this.cmb_user.SelectedValue.ToString()    : "";
            MyOraDB.Parameter_Values[5] = _sel_group_cd;
			//MyOraDB.Parameter_Values[5] = this.cmb_itemGroup.SelectedIndex > -1 ? this.cmb_itemGroup.SelectedValue.ToString() : "";
			MyOraDB.Parameter_Values[6] = this.txt_itemCd.Text;
			MyOraDB.Parameter_Values[7] = this.txt_itemNm.Text;
			MyOraDB.Parameter_Values[8] = this.cmb_buyDiv.SelectedIndex  > -1 ? this.cmb_buyDiv.SelectedValue.ToString()  : "";
			MyOraDB.Parameter_Values[9] = this.cmb_purDiv.SelectedIndex  > -1 ? this.cmb_purDiv.SelectedValue.ToString()  : "";
			MyOraDB.Parameter_Values[10]= this.cmb_priceYn.SelectedIndex > -1 ? this.cmb_priceYn.SelectedValue.ToString() : "";
			MyOraDB.Parameter_Values[11]= this.cmb_barKind.SelectedIndex > -1 ? this.cmb_barKind.SelectedValue.ToString() : "";
			MyOraDB.Parameter_Values[12]= txt_styleCd.Text.Replace("-","").Trim();//this.cmb_style.SelectedIndex   > -1 ? this.cmb_style.SelectedValue.ToString().Replace("-","") : "";
			MyOraDB.Parameter_Values[13]= this.txt_lotNo.Text;
			MyOraDB.Parameter_Values[14]= _vBarMove;
			MyOraDB.Parameter_Values[15]= cmb_inType.SelectedValue.ToString();
			MyOraDB.Parameter_Values[16]= COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[17]= (chk_not_ss.Checked == true)?"T":"F";
			MyOraDB.Parameter_Values[18]= ClassLib.ComFunction.Empty_Combo(cmb_pur_factory ," ");
			MyOraDB.Parameter_Values[19]= (chk_ship_date.Checked == true)? this.dpick_Ship_Date.Text.Replace("-",""): " ";
			MyOraDB.Parameter_Values[20]= "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

        /// <summary>
        /// PKG_SBI_IN_ADJUST_VENDOR : 
        /// </summary>
        /// <param name="arg_factory">공장코드</param>
        /// <param name="arg_style_cd">스타일코드</param>
        /// <param name="arg_gender">젠더</param>
        /// <param name="arg_dev">Dev</param>
        /// <returns>DataTable</returns>
        public DataTable SELECT_ITEM_INSPECTION_LIST02()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(22);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBI_IN_ITEM_INSPECTION.SELECT_ITEM_INSPECTION_LIST02";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_IN_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_IN_TO";
            MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
            MyOraDB.Parameter_Name[4] = "ARG_USER";
            MyOraDB.Parameter_Name[5] = "ARG_GROUP_CD";
            MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
            MyOraDB.Parameter_Name[7] = "ARG_ITEM_NM";
            MyOraDB.Parameter_Name[8] = "ARG_BUY_DIV";
            MyOraDB.Parameter_Name[9] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[10] = "ARG_PRICE_YN";
            MyOraDB.Parameter_Name[11] = "ARG_BAR_KIND";
            MyOraDB.Parameter_Name[12] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[13] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[14] = "ARG_BAR_MOVE";
            MyOraDB.Parameter_Name[15] = "ARG_IN_TYPE";
            MyOraDB.Parameter_Name[16] = "ARG_LOC_FACTORY";
            MyOraDB.Parameter_Name[17] = "ARG_SS_NOT_IN";
            MyOraDB.Parameter_Name[18] = "ARG_PUR_FACTORY";
            MyOraDB.Parameter_Name[19] = "ARG_SHIP_YMD";
            MyOraDB.Parameter_Name[20] = "ARG_IN_NO";
            MyOraDB.Parameter_Name[21] = "OUT_CURSOR";

            //03.DATA TYPE 정의
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
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[21] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = this.cmb_factory.SelectedIndex > -1 ? this.cmb_factory.SelectedValue.ToString() : "";
            MyOraDB.Parameter_Values[1] = this.dpick_from.Text.Replace("-", "");
            MyOraDB.Parameter_Values[2] = this.dpick_to.Text.Replace("-", "");
            MyOraDB.Parameter_Values[3] = this.cmb_vendor.SelectedIndex > -1 ? this.cmb_vendor.SelectedValue.ToString() : "";
            MyOraDB.Parameter_Values[4] = this.cmb_user.SelectedIndex > -1 ? this.cmb_user.SelectedValue.ToString() : "";
            MyOraDB.Parameter_Values[5] = _sel_group_cd;
            //MyOraDB.Parameter_Values[5] = this.cmb_itemGroup.SelectedIndex > -1 ? this.cmb_itemGroup.SelectedValue.ToString() : "";
            MyOraDB.Parameter_Values[6] = this.txt_itemCd.Text;
            MyOraDB.Parameter_Values[7] = this.txt_itemNm.Text;
            MyOraDB.Parameter_Values[8] = this.cmb_buyDiv.SelectedIndex > -1 ? this.cmb_buyDiv.SelectedValue.ToString() : "";
            MyOraDB.Parameter_Values[9] = this.cmb_purDiv.SelectedIndex > -1 ? this.cmb_purDiv.SelectedValue.ToString() : "";
            MyOraDB.Parameter_Values[10] = this.cmb_priceYn.SelectedIndex > -1 ? this.cmb_priceYn.SelectedValue.ToString() : "";
            MyOraDB.Parameter_Values[11] = this.cmb_barKind.SelectedIndex > -1 ? this.cmb_barKind.SelectedValue.ToString() : "";
            MyOraDB.Parameter_Values[12] = txt_styleCd.Text.Replace("-", "").Trim();//this.cmb_style.SelectedIndex   > -1 ? this.cmb_style.SelectedValue.ToString().Replace("-","") : "";
            MyOraDB.Parameter_Values[13] = this.txt_lotNo.Text;
            MyOraDB.Parameter_Values[14] = _vBarMove;
            MyOraDB.Parameter_Values[15] = cmb_inType.SelectedValue.ToString();
            MyOraDB.Parameter_Values[16] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[17] = (chk_not_ss.Checked == true) ? "T" : "F";
            MyOraDB.Parameter_Values[18] = ClassLib.ComFunction.Empty_Combo(cmb_pur_factory, " ");
            MyOraDB.Parameter_Values[19] = (chk_ship_date.Checked == true) ? this.dpick_Ship_Date.Text.Replace("-", "") : " ";
            MyOraDB.Parameter_Values[20] = COM.ComFunction.Empty_Combo(cmb_InRemarks, "");
            MyOraDB.Parameter_Values[21] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }

        /// <summary>
        /// PKG_SBI_IN_NO.SELECT_SBI_IN_NO_DATE_AREA : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SBI_IN_NO_DATE_AREA(string arg_factory, string arg_in_ymd_from, string arg_in_ymd_to)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SBI_IN_NO.SELECT_SBI_IN_NO_DATE_AREA";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_IN_YMD_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_IN_YMD_TO";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_in_ymd_from;
                MyOraDB.Parameter_Values[2] = arg_in_ymd_to;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



		#endregion 

		#region 이벤트 처리 메서드

		/// <summary> 
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form init
//			ClassLib.ComFunction.Init_Form_Control(this);

            lbl_MainTitle.Text = "Analysis Incoming";
            this.Text = lbl_MainTitle.Text;
            ClassLib.ComFunction.SetLangDic(this);

			// Grid setting
			fgrid_main.Set_Grid("SBI_IN_ITEM_INSPECT_M", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Rows[0].AllowMerging = true;
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);



			_rowFixed = fgrid_main.Rows.Count; 
			

			DataTable vDt = null;

            //vDt = FlexPurchase.ClassLib.ComFunction.Select_Data_List(ClassLib.ComVar.This_Factory , "SBI06");
            vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBI06");
            COM.ComCtl.Set_ComboList(vDt, cmb_factory, 1, 1, false, false);
            cmb_factory.SelectedIndex = 0;
            vDt.Dispose();
            //cmb_factory.SelectedValue = ClassLib.ComVar. This_Factory;



			// pur_div set    cmb_purDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_purDiv, 1, 2, true, 56,0);
			cmb_purDiv.SelectedIndex = 0;

			// buy_div set    cmb_buyDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC01");
			COM.ComCtl.Set_ComboList(vDt, cmb_buyDiv, 1, 2, true, 56,0);
			cmb_buyDiv.SelectedIndex = 0;
			
			// cmb_user
			vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_user,1,2,(vDt.Rows.Count > 1) ? true : false);
			//cmb_user.SelectedValue = COM.ComVar.This_User;
			cmb_user.SelectedIndex = 0;
			vDt.Dispose();

			// Item Group Combobox Setting
			vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
			cmb_itemGroup.SelectedIndex = 0;
			vDt.Dispose();

			// price yn set    cmb_priceYn
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SEM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_priceYn, 1, 2, true, 56,0);
			cmb_priceYn.SelectedIndex	= 1;

			// bar_kind set    cmb_barKind
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBS05");
			COM.ComCtl.Set_ComboList(vDt, cmb_barKind, 1, 2, true, 56,0);
			cmb_barKind.SelectedIndex = 0;

			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBI01");
			COM.ComCtl.Set_ComboList(vDt, cmb_inType, 1, 2, true, 56,0);
			cmb_inType.SelectedIndex = 0;


			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBI09");
			COM.ComCtl.Set_ComboList(vDt, cmb_printtype, 1, 2, true, 56,0);
			cmb_printtype.SelectedIndex = 1;

            // Pur  Factory Combobox Setting		
            //vDt = ClassLib.ComFunction.Select_Data_List(ClassLib.ComVar.This_Factory, "SBI04");
            vDt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, "SBI04");
            COM.ComCtl.Set_ComboList(vDt, cmb_pur_factory, 1, 1, true, false);
            cmb_pur_factory.SelectedIndex = 0;
            vDt.Dispose();
			


			
			// secarh type Set  cmb_searchType
			cmb_searchType.AddItemTitles("Code;Name");
			cmb_searchType.ValueMember		= "Code";
			cmb_searchType.DisplayMember	= "Name";
			cmb_searchType.AddItem("M;Meterial");
			cmb_searchType.AddItem("F;Factory");
			//cmb_searchType.AddItem("V;Vendor");
			cmb_searchType.AddItem("D;Date");
			cmb_searchType.AddItem("C;Classification");
			cmb_searchType.AddItem("H;Air/Hand");
			cmb_searchType.AddItem("A;Accound Only");
			cmb_searchType.SelectedValue = "M";  

			cmb_searchType.DropDownWidth		= 320;
			cmb_searchType.Splits[0].DisplayColumns["Code"].Width = 100;
			cmb_searchType.Splits[0].DisplayColumns["Name"].Width = 220-25;//스크롤 방지
			cmb_searchType.ExtendRightColumn = true; 
			cmb_searchType.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

			// Disabled tbutton
			tbtn_Save.Enabled	 = false;
			tbtn_Delete.Enabled  = false;
			tbtn_Confirm.Enabled = false;
			tbtn_Create.Enabled  = false;

			// set up styles
			CellStyle s = fgrid_main.Styles[CellStyleEnum.Subtotal0];
			s.BackColor = ClassLib.ComVar.ClrLevel_1st;
			s.ForeColor = Color.Black;
			s.Font = new Font(fgrid_main.Font, FontStyle.Bold);
			s.ForeColor = Color.Red;
			
			s = fgrid_main.Styles[CellStyleEnum.Subtotal1];
			s.BackColor = ClassLib.ComVar.ClrLevel_2nd;
			s.ForeColor = Color.Blue;

			s = fgrid_main.Styles[CellStyleEnum.Subtotal2];
			s.BackColor = ClassLib.ComVar.ClrLevel_3rd;
			s.Font = new Font(fgrid_main.Font, FontStyle.Bold);
			s.ForeColor = Color.Violet;

			s = fgrid_main.Styles[CellStyleEnum.Subtotal3];
			s.BackColor = ClassLib.ComVar.ClrLightSel;
			s.Font = new Font(fgrid_main.Font, FontStyle.Bold);
			s.ForeColor = Color.Green;

			s = fgrid_main.Styles[CellStyleEnum.Subtotal4];
			s.BackColor = ClassLib.ComVar.ClrOA;
			s.Font = new Font(fgrid_main.Font, FontStyle.Bold);
			s.ForeColor = Color.MediumSeaGreen;

			s = fgrid_main.Styles[CellStyleEnum.Subtotal5];
			s.BackColor = ClassLib.ComVar.ClrOA;
			s.ForeColor = Color.Black;
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();
				this.cmb_buyDiv.SelectedIndex		= -1;
				this.cmb_factory.SelectedIndex		= -1;
				this.cmb_itemGroup.SelectedIndex	= -1;
				this.cmb_priceYn.SelectedIndex		= -1;
				this.cmb_purDiv.SelectedIndex		= -1;
				this.cmb_user.SelectedIndex			= -1;
//				this.cmb_vendor.SelectedIndex		= -1;
				this.cmb_barKind.SelectedIndex		= -1;
				this.cmb_searchType.SelectedIndex	= -1;
				this.txt_vendorCode.Text			= "";	
				this.txt_itemCd.Text				= "";
				this.txt_itemNm.Text				= "";
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

                fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
				DataTable vTemp = this.SELECT_ITEM_INSPECTION_LIST02();

				if (vTemp.Rows.Count > 0)
				{
					ClassLib.ComFunction.Display_FlexGrid_Variable(fgrid_main, vTemp);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
//					for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
//					{
//						fgrid_main.Rows[i].StyleNew.BackColor = Color.White;
//					}
					SubTotalProcess();

					for(int i=_rowFixed; i<fgrid_main.Rows.Count; i++)
					{
						if(fgrid_main[i, (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxPUR_DIV] != null && fgrid_main[i, (int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxPUR_DIV].ToString() == "50")
						{
							fgrid_main.Rows[i].StyleNew.BackColor = Color.FromArgb(247, 255, 187);
						}
					}



				}
				else
				{
					fgrid_main.ClearAll();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
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
			COM.ComFunction comfunc = new COM.ComFunction();

            C1.Win.C1List.C1Combo[] cmb_array = { cmb_factory };
            System.Windows.Forms.TextBox[] txt_array = {};


            string sDir = null;


            if (FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) == false) return;

            if (cmb_printtype.SelectedValue.ToString() =="01")
            {
                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_Spec");
            }
            else if (cmb_printtype.SelectedValue.ToString() == "02")
            {
                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_M");
            }
            else if (cmb_printtype.SelectedValue.ToString() == "03")
            {
                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_M_list");
            }
            else if (cmb_printtype.SelectedValue.ToString() == "04")
            {
                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_Color");
            }
            else if (cmb_printtype.SelectedValue.ToString() == "05")
            {
                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_Color_list");
            }
            else if (cmb_printtype.SelectedValue.ToString() == "06")
            {
                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_C");
            }
            else if (cmb_printtype.SelectedValue.ToString() == "07")
            {
                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_Cust");
            }
            else if (cmb_printtype.SelectedValue.ToString() == "08")
            {
                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_Cust_Cover");
            }




            #region 출력 변수
            int iCnt = 19;
            string[] aHead = new string[iCnt];


            aHead[0] = COM.ComFunction.Param_Combo(cmb_factory, " ");
            aHead[1] = this.dpick_from.Text.Replace("-", "");
            aHead[2] = this.dpick_to.Text.Replace("-", "");
            aHead[3] = COM.ComFunction.Param_Combo(cmb_vendor, " ");
            aHead[4] = COM.ComFunction.Param_Combo(cmb_user, " ");
            aHead[5] = COM.ComFunction.Param_Combo(cmb_itemGroup, " ");
            aHead[6] = COM.ComFunction.Empty_TextBox(txt_itemCd, " ");
            aHead[7] = COM.ComFunction.Empty_TextBox(txt_itemNm, " ");
            aHead[8] = COM.ComFunction.Param_Combo(cmb_buyDiv, " ");
            aHead[9] = COM.ComFunction.Param_Combo(cmb_purDiv, " ");
            aHead[10] = COM.ComFunction.Param_Combo(cmb_priceYn, " ");
            aHead[11] = COM.ComFunction.Param_Combo(cmb_barKind, " ");
            aHead[12] = COM.ComFunction.Param_Combo(cmb_style, " ");
            aHead[13] = COM.ComFunction.Empty_TextBox(txt_lotNo, " ");
            aHead[14] = _vBarMove;
            aHead[15] = COM.ComFunction.Param_Combo(cmb_inType, " ");
            aHead[16] = COM.ComVar.This_Factory;
            aHead[17] = COM.ComFunction.Empty_Combo(cmb_pur_factory, " ");
            aHead[18] = (chk_ship_date.Checked == true) ? this.dpick_Ship_Date.Text.Replace("-", "") : " ";

            #endregion

            string sPara = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                sPara = sPara + "[" + aHead[i - 1] + "] ";
            }


            FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
            MyReport.Text = "Incoming Item Inspection sheet";
            MyReport.Show();		


            //if(cmb_searchType.SelectedValue.ToString() == "M")
            //{
            //    #region Search Type : M
			
            //    C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
            //    System.Windows.Forms.TextBox[] txt_array = {}; 

            //    if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
            //    {
            //        string sDir = null;
					
            //        if(tree_level == 2)
            //        {
            //            #region Level : 2  //Report명지정

            //            if(cmb_printtype.SelectedValue.ToString() == "D")
            //            {
            //                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_Spec");
            //            }
            //            else
            //            {
            //                return;
            //            }

            //            #endregion 

            //        }					
            //        else if (tree_level == 4)
            //        {
            //            #region Level : 4   //Report명지정

            //            if(cmb_printtype.SelectedValue.ToString() == "D")
            //            {
            //                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_M");
            //            }
            //            else if(cmb_printtype.SelectedValue.ToString() == "L")
            //            {
            //                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_M_list");
            //            }
            //            else if(cmb_printtype.SelectedValue.ToString() == "A")
            //            {
            //                return;
            //            }
            //            else
            //            {
            //                return;
            //            }

            //           #endregion 

            //        }					
            //        else
            //        {

            //            #region  Level: not 4 ,1       //Report명지정
            //            if(cmb_printtype.SelectedValue.ToString() == "D")
            //            {
            //                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_Color");
            //            }
            //            else if(cmb_printtype.SelectedValue.ToString() == "L")
            //            {
            //                sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_Color_list");
            //            }
            //            else if(cmb_printtype.SelectedValue.ToString() == "A")
            //            {
            //                return;
            //            }
            //            else
            //            {
            //                return;
            //            }
            //            #endregion 

            //        }

                    
            //        #region 출력 변수   
            //        int  iCnt  = 19;
            //        string [] aHead =  new string[iCnt];	
			

            //        aHead[0]    = COM.ComFunction.Param_Combo(cmb_factory, " ");
            //        aHead[1]    = this.dpick_from.Text.Replace("-","");
            //        aHead[2]    = this.dpick_to.Text.Replace("-","");
            //        aHead[3]    = COM.ComFunction.Param_Combo(cmb_vendor, " ");
            //        aHead[4]    = COM.ComFunction.Param_Combo(cmb_user, " ");
            //        aHead[5]    = COM.ComFunction.Param_Combo(cmb_itemGroup, " ");
            //        aHead[6]    = COM.ComFunction.Empty_TextBox(txt_itemCd, " ");
            //        aHead[7]    = COM.ComFunction.Empty_TextBox(txt_itemNm, " ");
            //        aHead[8]    = COM.ComFunction.Param_Combo(cmb_buyDiv, " ");
            //        aHead[9]    = COM.ComFunction.Param_Combo(cmb_purDiv, " ");		
            //        aHead[10]   = COM.ComFunction.Param_Combo(cmb_priceYn, " ");
            //        aHead[11]	= COM.ComFunction.Param_Combo(cmb_barKind, " ");
            //        aHead[12]	= COM.ComFunction.Param_Combo(cmb_style, " ");
            //        aHead[13]	= COM.ComFunction.Empty_TextBox(txt_lotNo, " ");
            //        aHead[14]	= _vBarMove;
            //        aHead[15]	= COM.ComFunction.Param_Combo(cmb_inType, " ");
            //        aHead[16]	= COM.ComVar.This_Factory;
            //        aHead[17]	= COM.ComFunction.Empty_Combo(cmb_pur_factory," ");
            //        aHead[18]	= (chk_ship_date.Checked  == true)? this.dpick_Ship_Date.Text.Replace("-",""): " ";
          
            //        #endregion 

            //        string sPara = 	" /rp ";
            //        for (int i  = 1 ; i<= iCnt ; i++)
            //        {				
            //            sPara = sPara + "[" + aHead[i-1] + "] ";
            //        }


            //        FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
            //        MyReport.Text = "Incoming Item Inspection sheet";
            //        MyReport.Show();		
            //    }

            //}
            //#endregion

            //else if(cmb_searchType.SelectedValue.ToString() == "C")
            //{
            //    #region Search Type :C
            //        C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
            //        System.Windows.Forms.TextBox[] txt_array = {}; 
		
            //        if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
            //        {
            //            #region  //Report명 지정

            //            string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Item_Inspection_C");                        

            //            #endregion 
 

            //            #region 출력변수 
            //            string sPara  = " /rp ";
            //            sPara += "'" + cmb_factory.SelectedValue.ToString() +		"' ";
            //            sPara += "'" + this.dpick_from.Text.Replace("-","") +		"' ";
            //            sPara += "'" + this.dpick_to.Text.Replace("-","") +		"' ";
            //            sPara += "'" + COM.ComFunction.Param_Combo(cmb_vendor, " ") +	"' ";
            //            sPara += "'" + COM.ComFunction.Param_Combo(cmb_user, " ") +	"' ";
            //            sPara += "'" + COM.ComFunction.Param_Combo(cmb_itemGroup, " ") +	"' ";
            //            sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";
            //            sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemNm, " ") +	"' ";
            //            sPara += "'" + COM.ComFunction.Param_Combo(cmb_buyDiv, " ") +	"' ";
            //            sPara += "'" + COM.ComFunction.Param_Combo(cmb_purDiv, " ") +	"' ";
            //            sPara += "'" + COM.ComFunction.Param_Combo(cmb_priceYn, " ") +	"' ";
            //            sPara += "'" + COM.ComFunction.Param_Combo(cmb_barKind, " ") +	"' ";
            //            sPara += "'" + COM.ComFunction.Param_Combo(cmb_style, " ") +	"' ";
            //            sPara += "'" + COM.ComFunction.Empty_TextBox(txt_lotNo, " ") +	"' ";
            //            sPara += "'" + _vBarMove +	"' ";
            //            sPara += "'" + COM.ComFunction.Param_Combo(cmb_inType, " ") +	"' ";
            //            sPara += "'" + COM.ComVar.This_Factory +  	"' ";
            //            sPara += "'" + COM.ComFunction.Param_Combo(cmb_pur_factory, " ") +	"' ";

            //            if  (chk_ship_date.Checked  == true)
            //                sPara += "'" +  this.dpick_Ship_Date.Text.Replace("-","") +	"' ";
            //            else 
            //                sPara +=  "'" + " " +	"' ";

            //            #endregion 

            //            FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
		
            //            MyReport.Text = "Incoming Item Inspection sheet";
            //            MyReport.Show();			
            //        }

            //    #endregion 
            //}
			
		}


		private void Cmb_SearchTypeSelectedValueChangedProcess()
		{
			try
			{				
				_vSelType = cmb_searchType.SelectedIndex > 0 ? cmb_searchType.SelectedValue.ToString() : "M";
				switch (_vSelType)
				{
					case ("M") :
						fgrid_main.Set_Grid("SBI_IN_ITEM_INSPECT_M", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
						fgrid_main.Tree.Column		= _lxMTotalCol;
						fgrid_main.Cols[(int)ClassLib.TBSBI_IN_ITEM_INSPECT_M.IxCOLOR_NAME].Visible = true;
						_vBarMove	= "N";
						break;
					case ("F") :
						fgrid_main.Set_Grid("SBI_IN_ITEM_INSPECT_F", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
						fgrid_main.Tree.Column		= _lxFTotalCol;
						fgrid_main.Cols[(int)ClassLib.TBSBI_IN_ITEM_INSPECT_F.IxCOLOR_NAME].Visible = true;
						_vBarMove	= "N";
						break;
					case ("V") :
						fgrid_main.Set_Grid("SBI_IN_ITEM_INSPECT_V", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
						fgrid_main.Tree.Column		= _lxVTotalCol;
						fgrid_main.Cols[(int)ClassLib.TBSBI_IN_ITEM_INSPECT_V.IxCOLOR_NAME].Visible = true;
						_vBarMove	= "N";
						break;
					case ("D") :
						fgrid_main.Set_Grid("SBI_IN_ITEM_INSPECT_D", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
						_vBarMove	= "N";
						fgrid_main.Cols[(int)ClassLib.TBSBI_IN_ITEM_INSPECT_D.IxCOLOR_NAME].Visible = true;
						fgrid_main.Tree.Column		= _lxDTotalCol;
						break;
					case ("C") :
						fgrid_main.Set_Grid("SBI_IN_ITEM_INSPECT_C", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
						fgrid_main.Tree.Column		= _lxCTotalCol;
						fgrid_main.Cols[(int)ClassLib.TBSBI_IN_ITEM_INSPECT_C.IxCOLOR_NAME].Visible = true;
						_vBarMove	= "N";
						break;
					case ("A") :
						fgrid_main.Set_Grid("SBI_IN_ITEM_INSPECT_A", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
						fgrid_main.Tree.Column		= _lxATotalCol;
						fgrid_main.Cols[(int)ClassLib.TBSBI_IN_ITEM_INSPECT_A.IxCOLOR_NAME].Visible = true;
						_vBarMove	= "N";
						break;
					case ("H") :
						fgrid_main.Set_Grid("SBI_IN_ITEM_INSPECT_H", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
						fgrid_main.Tree.Column		= _lxHTotalCol;
						fgrid_main.Cols[(int)ClassLib.TBSBI_IN_ITEM_INSPECT_H.IxCOLOR_NAME].Visible = true;
						_vBarMove	= "Y";
						break;
				}

				fgrid_main.Rows[0].AllowMerging = true;
				fgrid_main.Rows[1].AllowMerging = true;

				//Tbtn_SearchProcess();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}



		private void SubTotalProcess()
		{
			// more setup
			fgrid_main.SubtotalPosition = SubtotalPositionEnum.AboveData;								
			fgrid_main.AllowDragging	= AllowDraggingEnum.None;

			fgrid_main.Subtotal(AggregateEnum.Clear);
			for (int c = 1; c < fgrid_main.Cols.Count; c++)
			{
				if (c != _lxMPurPriceCol && c != _lxCPurPriceCol && fgrid_main.Cols[c].Style.Name.ToString().StartsWith("NUMBER"))
				{
					switch (_vSelType)
					{ 
						case ("M") :
//							fgrid_main.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, _lxMorderByCol/*_lxMCustCdCol, _lxMItemNameCol*//*, _lxMSpecNameCol, _lxMColorNameCol*/);  // CUST_NAME, ITEM_NAME
//							// calculate subtotals (three levels, totals on every column)
//							fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1,			   c, "Total");
//
//							//fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxMCustNameCol, _lxMPurPriceCol, "{0}");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxMCustNameCol, c, "{0}");
//
//
//							fgrid_main.Subtotal(AggregateEnum.Max, 2, _lxMItemNameCol, _lxMPurPriceCol, "{0}");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxMItemNameCol, c, "{0}");
//							
//							
//							fgrid_main.Subtotal(AggregateEnum.Max, 3, _lxMColorNameCol, _lxMPurPriceCol, "{0}");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxMColorNameCol, c, "{0}");
//
//							fgrid_main.Subtotal(AggregateEnum.Max, 4, _lxMPurPriceCol, _lxMPurPriceCol, "{0}");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 4, _lxMPurPriceCol, c, "{0}");
							


							fgrid_main.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, _lxMorderByCol/*_lxMCustCdCol, _lxMItemNameCol*//*, _lxMSpecNameCol, _lxMColorNameCol*/);  // CUST_NAME, ITEM_NAME
							// calculate subtotals (three levels, totals on every column)
							fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1,			   c, "Total");

							//fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxMCustNameCol, _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxMCustNameCol, c, "{0}");


							//fgrid_main.Subtotal(AggregateEnum.Max, 2, _lxMItemNameCol, _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxMItemNameCol, c, "{0}");
							
							
							fgrid_main.Subtotal(AggregateEnum.Max, 3, _lxMColorNameCol, _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxMColorNameCol, c, "{0}");
							break;



						case ("F") :
							fgrid_main.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, _lxFFactoryCol, _lxFVendorItemCol);  // CUST_NAME, ITEM_NAME
							// calculate subtotals (three levels, totals on every column)
							fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1,			   c, "Total");

							fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxFFactoryCol, _lxFPurpriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxFFactoryCol,  c, "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 2, _lxFCustNameCol, _lxMPurPriceCol,"{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxFCustNameCol, c, "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 3, _lxFItemNameCol, _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxFItemNameCol, c, "{0}");
							//							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxMCustCdCol, c,   "VENDOR");
							//							fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxMItemCdCol, c,   "ITEM");
							break;
						case ("V") :
							fgrid_main.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, _lxVFactoryCol, _lxVVendorItemCol);  // CUST_NAME, ITEM_NAME
							// calculate subtotals (three levels, totals on every column)
							fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1,			    c,  "Total");

							//fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxVFactoryCol, _lxVPurpriceCol, "{0}");
							//fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxVFactoryCol,   c,  "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxVCustNameCol, _lxVPurpriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxVCustNameCol,  c,  "{0}");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxVFactoryCol,   c,  "FACTORY");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxVCustCdCol,    c,  "VENDOR");
							break;
						case ("D") :
							fgrid_main.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, _lxDYmdVendorCol); // IN_YMD, CUST_NAME
							// calculate subtotals (three levels, totals on every column)
							fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1,			   c,  "Total");

							//fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxDFactoryCol, _lxDPurpriceCol, "{0}");
							//fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxDFactoryCol,  c,  "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxDInYmdCol, _lxDPurpriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxDInYmdCol,    c,  "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 2, _lxDCustNameCol, _lxDPurpriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxDCustNameCol, c,  "{0}");
//							
							
							
							//fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxDInYmdCol,   c,  "INCOMING YMD");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxDCustCdCol,  c,  "VENDER");
							break;
						case ("C") :
							fgrid_main.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, _lxCGroupMCdCol); // GROUP_CD, CLASS_TYPE
							// calculate subtotals (three levels, totals on every column)
							fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1,			      c,  "Total");

							//fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxCFactoryCol, _lxCPurPriceCol, "{0}");
							//fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxCFactoryCol,     c,  "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxCClassTypeCol, _lxCPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxCClassTypeCol,   c,  "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 2, _lxCFirstClassCol, _lxMPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxCFirstClassCol,  c,  "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 3, _lxCSecondClassCol, _lxCPurPriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxCSecondClassCol, c,  "{0}");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxGroupTCdCol, c,  "CLASS TYPE");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxGroupLCdCol, c,  "FIRST CLASS");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 4, _lxGroupMCdCol, c,  "SECOND CLASS");							
							break;
						case ("A") :
							fgrid_main.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, _lxAYmdItemCol);
							// calculate subtotals (three levels, totals on every column)
							fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1,			   c,  "Total");

							//fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxAFactoryCol, _lxAPurpriceCol, "{0}");
							//fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxAFactoryCol,  c,  "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxAInYmdCol, _lxAPurpriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxAInYmdCol,    c,  "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 2, _lxAItemNameCol, _lxAPurpriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxAItemNameCol, c,  "{0}");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxAItemCdCol, c,  "ITEM");
							break;
						case ("H") :
							fgrid_main.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, _lxHVendorItemCol);
							// calculate subtotals (three levels, totals on every column)
							fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1,			   c,  "Total");

							//fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxHFactoryCol, _lxHPurpriceCol, "{0}");
							//fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxHFactoryCol,  c,  "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 1, _lxHCustNameCol, _lxHPurpriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxHCustNameCol, c,  "{0}");

							fgrid_main.Subtotal(AggregateEnum.Max, 2, _lxHItemNameCol, _lxHPurpriceCol, "{0}");
							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxHItemNameCol, c,  "{0}");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxHCustCdCol,  c,  "VENDER");
//							fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxHItemCol,    c,  "ITEM");
							break;
					}

//					for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
//					{
//						C1.Win.C1FlexGrid.Node node = fgrid_main.Rows[i].Node;
//						if (node.Level.Equals(1))						
//						{
//							int vFrom_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
//							int vTo_row   = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
//							fgrid_main.Rows[vFrom_row].AllowMerging = true; 
//							fgrid_main.Rows[vTo_row].AllowMerging   = true;
//						}
//					}
				}
			}
		}

		private void Txt_VendorCodeTextChangedProcess()
		{
			try
			{
				_isAccessible = false;
				DataTable vDt = new DataTable();
				vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_vendorCode.Text.Trim());
				COM.ComCtl.Set_ComboList(vDt, cmb_vendor, 0, 1, true, 79, 141);

				if (vDt.Rows.Count > 0 && vDt.Rows.Count < 2)
					cmb_vendor.SelectedIndex = 1; 
				else if (vDt == null || vDt.Rows.Count <= 0) 
					cmb_vendor.SelectedIndex = 0; 
					
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

		private void Cmb_VendorSelectedValueChangedProcess()
		{
			try
			{
				if (_isAccessible)
				{
					txt_vendorCode.Text		 = cmb_vendor.SelectedValue.ToString();
					cmb_vendor.SelectedValue = txt_vendorCode.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private void Cmb_inNoSettingProcess()
        {
            try
            {
                fgrid_main.ClearAll();

                string sFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
                string sInYmdFrom = dpick_from.Value.ToString("yyyyMMdd");
                string sInYmdTo = dpick_to.Value.ToString("yyyyMMdd");
                DataTable vDt = SELECT_SBI_IN_NO_DATE_AREA(sFactory, sInYmdFrom, sInYmdTo);
                COM.ComCtl.Set_ComboList(vDt, cmb_InRemarks, 0, 1, true, false);
                cmb_InRemarks.SelectedIndex = 0;
                vDt.Dispose();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Get Incoming No", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		#endregion

	}
}

