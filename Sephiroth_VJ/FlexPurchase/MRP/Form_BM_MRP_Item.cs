using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using FlexMRP.ClassLib;


namespace FlexMRP.MRP
{
	public class Form_BM_MRP_Item : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 멤버

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_findData;
		private System.Windows.Forms.Label lbl_mrpno;
		private C1.Win.C1List.C1Combo cmb_mrpno;
		private C1.Win.C1List.C1Combo cmb_itemDiv;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem mnu_allSelect;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnu_header;
		private System.Windows.Forms.MenuItem mnu_all;
		private System.Windows.Forms.MenuItem mnu_value;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.Label lbl_shiptype1;
		private System.Windows.Forms.Label lbl_lotno;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_styleCd;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label lbl_stylecd;
		private System.Windows.Forms.Label lbl_shipyn;
		private System.Windows.Forms.Label lbl_itemdiv;
		private System.Windows.Forms.Label longyn;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label lbl_outside;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.TextBox txt_status;
		private C1.Win.C1List.C1Combo cmb_shipyn;
		private C1.Win.C1List.C1Combo cmb_outsideyn;
		private C1.Win.C1List.C1Combo cmb_longyn;
		private C1.Win.C1List.C1Combo cmb_obstype;
		private C1.Win.C1List.C1Combo cmb_reqReason;
		private System.Windows.Forms.TextBox txt_lotno;
		private System.Windows.Forms.Label label3;
		private C1.Win.C1List.C1Combo cmb_search;
		private System.Windows.Forms.PictureBox lbl_img;
		private C1.Win.C1List.C1Combo cmb_trantype;
		private System.Windows.Forms.Label lbl_transportyn;
		private System.Windows.Forms.Label lbl_obstype;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.Label label4;
		private C1.Win.C1List.C1Combo com_bom;
		private System.Windows.Forms.Label lbl_bom;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label btn_Recover;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Label btn_Tree;
		private System.Windows.Forms.MenuItem mnu_confirm;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnu_canfirmCancel;
		private System.Windows.Forms.Label btn_order;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버

		private Pop_Finder finder;
		private COM.OraDB MyOraDB	= new COM.OraDB();
		private Pop_BM_Shipping_Wait _pop;
		private const int _mnu_value = 10;
		private const int _insert = 100, _delete = 110, _valid = 120, _recover = 130;
		private string _vstyle_cd="",_vlot_no="",_vlot_seq="";
		private int _vparent=0;
		private string _itemGroupCode	= "";
		private ArrayList _duplicateData = new ArrayList();

		private string _process		=((int)ClassLib.ComVar.MRPProcessNum.MRPAdjust).ToString();

		private int _mrpShipNoCol	= (int)TBSBM_MRP_ITEM_LOT.IxMRP_SHIP_NO;
		private int _lotInfoCol		= (int)TBSBM_MRP_ITEM_LOT.IxITEM_NAME;
		private int _styleCodeCol	= (int)TBSBM_MRP_ITEM_LOT.IxSPEC_NAME;
		private int _styleNameCol	= (int)TBSBM_MRP_ITEM_LOT.IxCOLOR_NAME;
		private int _unitCol		= (int)TBSBM_MRP_ITEM_LOT.IxUNIT;
		private int _itemCodeCol	= (int)TBSBM_MRP_ITEM_LOT.IxITEM_CD;
		private int _specCodeCol	= (int)TBSBM_MRP_ITEM_LOT.IxSPEC_CD;
		private int _colorCodeCol	= (int)TBSBM_MRP_ITEM_LOT.IxCOLOR_CD;
		private int _confirmQtyCol	= (int)TBSBM_MRP_ITEM_LOT.IxCONFIRM_QTY;
		private int _pkQtyCol		= (int)TBSBM_MRP_ITEM_LOT.IxPK_QTY;
		private int _shipYnCol		= (int)TBSBM_MRP_ITEM_LOT.IxSHIP_YN;
		private int _itemNameCol	= (int)TBSBM_MRP_ITEM_LOT.IxITEM_NAME;
		private int _specNameCol	= (int)TBSBM_MRP_ITEM_LOT.IxSPEC_NAME;
		private int _colorNameCol	= (int)TBSBM_MRP_ITEM_LOT.IxCOLOR_NAME;

		private string[] _shipNoTitles;
		private int[] _shipNoWidth;
		private System.Windows.Forms.Label btn_forecast;
		private System.Windows.Forms.MenuItem mnu_Rate;
		private bool[] _shipNoVisible;


        private Thread tRun = null;
        delegate void DelegateSetn(); // 대리자 선언     



		#endregion

		#region 생성자 / 소멸자

		public Form_BM_MRP_Item()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BM_MRP_Item));
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
            C1.Win.C1List.Style style145 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style146 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style147 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style148 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style149 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style150 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style151 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style152 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style153 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style154 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style155 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style156 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style157 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style158 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style159 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style160 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style161 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style162 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style163 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style164 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style165 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style166 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style167 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style168 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style169 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style170 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style171 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style172 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style173 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style174 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style175 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style176 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style177 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style178 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style179 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style180 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style181 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style182 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style183 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style184 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style185 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style186 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style187 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style188 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style189 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style190 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style191 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style192 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style193 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style194 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style195 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style196 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style197 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style198 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style199 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style200 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style201 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style202 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style203 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style204 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style205 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style206 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style207 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style208 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style209 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style210 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style211 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style212 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style213 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style214 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style215 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style216 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style217 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style218 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style219 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style220 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style221 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style222 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style223 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style224 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Tree = new System.Windows.Forms.Label();
            this.btn_Recover = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.fgrid_main = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_forecast = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Label();
            this.lbl_bom = new System.Windows.Forms.Label();
            this.lbl_outside = new System.Windows.Forms.Label();
            this.longyn = new System.Windows.Forms.Label();
            this.lbl_shipyn = new System.Windows.Forms.Label();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.lbl_stylecd = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.com_bom = new C1.Win.C1List.C1Combo();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_obstype = new System.Windows.Forms.Label();
            this.lbl_transportyn = new System.Windows.Forms.Label();
            this.cmb_search = new C1.Win.C1List.C1Combo();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lotno = new System.Windows.Forms.TextBox();
            this.cmb_reqReason = new C1.Win.C1List.C1Combo();
            this.cmb_obstype = new C1.Win.C1List.C1Combo();
            this.cmb_longyn = new C1.Win.C1List.C1Combo();
            this.cmb_outsideyn = new C1.Win.C1List.C1Combo();
            this.cmb_shipyn = new C1.Win.C1List.C1Combo();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_itemdiv = new System.Windows.Forms.Label();
            this.cmb_trantype = new C1.Win.C1List.C1Combo();
            this.lbl_lotno = new System.Windows.Forms.Label();
            this.lbl_shiptype1 = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_itemDiv = new C1.Win.C1List.C1Combo();
            this.lbl_mrpno = new System.Windows.Forms.Label();
            this.cmb_mrpno = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.lbl_img = new System.Windows.Forms.PictureBox();
            this.ctx_main = new System.Windows.Forms.ContextMenu();
            this.mnu_findData = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mnu_allSelect = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnu_value = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnu_header = new System.Windows.Forms.MenuItem();
            this.mnu_all = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnu_confirm = new System.Windows.Forms.MenuItem();
            this.mnu_canfirmCancel = new System.Windows.Forms.MenuItem();
            this.mnu_Rate = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_bom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obstype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_longyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outsideyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_trantype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_mrpno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_img)).BeginInit();
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
            // tbtn_Confirm
            // 
            this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.panel3);
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 584);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Tree);
            this.panel3.Controls.Add(this.btn_Recover);
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Insert);
            this.panel3.Location = new System.Drawing.Point(0, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 30);
            this.panel3.TabIndex = 54;
            // 
            // btn_Tree
            // 
            this.btn_Tree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Tree.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tree.ImageIndex = 13;
            this.btn_Tree.ImageList = this.image_List;
            this.btn_Tree.Location = new System.Drawing.Point(684, 4);
            this.btn_Tree.Name = "btn_Tree";
            this.btn_Tree.Size = new System.Drawing.Size(80, 24);
            this.btn_Tree.TabIndex = 365;
            this.btn_Tree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Tree.Click += new System.EventHandler(this.btn_Tree_Click);
            this.btn_Tree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_tree_MouseDown);
            this.btn_Tree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_tree_MouseUp);
            // 
            // btn_Recover
            // 
            this.btn_Recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Recover.ImageIndex = 1;
            this.btn_Recover.ImageList = this.image_List;
            this.btn_Recover.Location = new System.Drawing.Point(927, 4);
            this.btn_Recover.Name = "btn_Recover";
            this.btn_Recover.Size = new System.Drawing.Size(80, 23);
            this.btn_Recover.TabIndex = 51;
            this.btn_Recover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Recover.Click += new System.EventHandler(this.btn_Recover_Click);
            this.btn_Recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
            this.btn_Recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Delete.ImageIndex = 5;
            this.btn_Delete.ImageList = this.image_List;
            this.btn_Delete.Location = new System.Drawing.Point(846, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 23);
            this.btn_Delete.TabIndex = 49;
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseDown);
            this.btn_Delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseUp);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(765, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 23);
            this.btn_Insert.TabIndex = 48;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseDown);
            this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseUp);
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(8, 193);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
            this.fgrid_main.Size = new System.Drawing.Size(999, 349);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 3;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.btn_forecast);
            this.pnl_head.Controls.Add(this.btn_order);
            this.pnl_head.Controls.Add(this.lbl_bom);
            this.pnl_head.Controls.Add(this.lbl_outside);
            this.pnl_head.Controls.Add(this.longyn);
            this.pnl_head.Controls.Add(this.lbl_shipyn);
            this.pnl_head.Controls.Add(this.lbl_itemgroup);
            this.pnl_head.Controls.Add(this.lbl_stylecd);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.com_bom);
            this.pnl_head.Controls.Add(this.label4);
            this.pnl_head.Controls.Add(this.lbl_obstype);
            this.pnl_head.Controls.Add(this.lbl_transportyn);
            this.pnl_head.Controls.Add(this.cmb_search);
            this.pnl_head.Controls.Add(this.label3);
            this.pnl_head.Controls.Add(this.txt_lotno);
            this.pnl_head.Controls.Add(this.cmb_reqReason);
            this.pnl_head.Controls.Add(this.cmb_obstype);
            this.pnl_head.Controls.Add(this.cmb_longyn);
            this.pnl_head.Controls.Add(this.cmb_outsideyn);
            this.pnl_head.Controls.Add(this.cmb_shipyn);
            this.pnl_head.Controls.Add(this.txt_status);
            this.pnl_head.Controls.Add(this.txt_styleCd);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.txt_itemName);
            this.pnl_head.Controls.Add(this.txt_itemCode);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_status);
            this.pnl_head.Controls.Add(this.lbl_itemdiv);
            this.pnl_head.Controls.Add(this.cmb_trantype);
            this.pnl_head.Controls.Add(this.lbl_lotno);
            this.pnl_head.Controls.Add(this.lbl_shiptype1);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.cmb_itemDiv);
            this.pnl_head.Controls.Add(this.lbl_mrpno);
            this.pnl_head.Controls.Add(this.cmb_mrpno);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.lbl_img);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(999, 189);
            this.pnl_head.TabIndex = 2;
            // 
            // btn_forecast
            // 
            this.btn_forecast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_forecast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_forecast.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_forecast.ImageIndex = 0;
            this.btn_forecast.ImageList = this.img_Button;
            this.btn_forecast.Location = new System.Drawing.Point(803, 150);
            this.btn_forecast.Name = "btn_forecast";
            this.btn_forecast.Size = new System.Drawing.Size(80, 23);
            this.btn_forecast.TabIndex = 448;
            this.btn_forecast.Text = "Forecast";
            this.btn_forecast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_forecast.Click += new System.EventHandler(this.btn_forecast_Click);
            this.btn_forecast.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_size_MouseDown);
            this.btn_forecast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_size_MouseUp);
            // 
            // btn_order
            // 
            this.btn_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_order.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_order.ImageIndex = 0;
            this.btn_order.ImageList = this.img_Button;
            this.btn_order.Location = new System.Drawing.Point(884, 150);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(80, 23);
            this.btn_order.TabIndex = 447;
            this.btn_order.Text = "Order";
            this.btn_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            this.btn_order.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_size_MouseDown);
            this.btn_order.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_size_MouseUp);
            // 
            // lbl_bom
            // 
            this.lbl_bom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_bom.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bom.ImageIndex = 0;
            this.lbl_bom.ImageList = this.img_Label;
            this.lbl_bom.Location = new System.Drawing.Point(330, 150);
            this.lbl_bom.Name = "lbl_bom";
            this.lbl_bom.Size = new System.Drawing.Size(100, 21);
            this.lbl_bom.TabIndex = 445;
            this.lbl_bom.Text = "BOM Y/N";
            this.lbl_bom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_outside
            // 
            this.lbl_outside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outside.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outside.ImageIndex = 0;
            this.lbl_outside.ImageList = this.img_Label;
            this.lbl_outside.Location = new System.Drawing.Point(330, 128);
            this.lbl_outside.Name = "lbl_outside";
            this.lbl_outside.Size = new System.Drawing.Size(100, 21);
            this.lbl_outside.TabIndex = 416;
            this.lbl_outside.Text = "Outside Y/N";
            this.lbl_outside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // longyn
            // 
            this.longyn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.longyn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longyn.ImageIndex = 0;
            this.longyn.ImageList = this.img_Label;
            this.longyn.Location = new System.Drawing.Point(330, 84);
            this.longyn.Name = "longyn";
            this.longyn.Size = new System.Drawing.Size(100, 21);
            this.longyn.TabIndex = 414;
            this.longyn.Text = "Long Y/N";
            this.longyn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipyn
            // 
            this.lbl_shipyn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipyn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipyn.ImageIndex = 0;
            this.lbl_shipyn.ImageList = this.img_Label;
            this.lbl_shipyn.Location = new System.Drawing.Point(330, 106);
            this.lbl_shipyn.Name = "lbl_shipyn";
            this.lbl_shipyn.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipyn.TabIndex = 411;
            this.lbl_shipyn.Text = "Ship Y/N";
            this.lbl_shipyn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_itemgroup
            // 
            this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemgroup.ImageIndex = 0;
            this.lbl_itemgroup.ImageList = this.img_Label;
            this.lbl_itemgroup.Location = new System.Drawing.Point(330, 62);
            this.lbl_itemgroup.Name = "lbl_itemgroup";
            this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemgroup.TabIndex = 50;
            this.lbl_itemgroup.Text = "Item Group";
            this.lbl_itemgroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_stylecd
            // 
            this.lbl_stylecd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_stylecd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stylecd.ImageIndex = 0;
            this.lbl_stylecd.ImageList = this.img_Label;
            this.lbl_stylecd.Location = new System.Drawing.Point(330, 40);
            this.lbl_stylecd.Name = "lbl_stylecd";
            this.lbl_stylecd.Size = new System.Drawing.Size(100, 21);
            this.lbl_stylecd.TabIndex = 50;
            this.lbl_stylecd.Text = "Style CD";
            this.lbl_stylecd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(972, 167);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(972, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // com_bom
            // 
            this.com_bom.AddItemCols = 0;
            this.com_bom.AddItemSeparator = ';';
            this.com_bom.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.com_bom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.com_bom.Caption = "";
            this.com_bom.CaptionHeight = 17;
            this.com_bom.CaptionStyle = style113;
            this.com_bom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.com_bom.ColumnCaptionHeight = 18;
            this.com_bom.ColumnFooterHeight = 18;
            this.com_bom.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.com_bom.ContentHeight = 16;
            this.com_bom.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.com_bom.EditorBackColor = System.Drawing.SystemColors.Window;
            this.com_bom.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.com_bom.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.com_bom.EditorHeight = 16;
            this.com_bom.Enabled = false;
            this.com_bom.EvenRowStyle = style114;
            this.com_bom.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.com_bom.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_bom.FooterStyle = style115;
            this.com_bom.GapHeight = 2;
            this.com_bom.HeadingStyle = style116;
            this.com_bom.HighLightRowStyle = style117;
            this.com_bom.ItemHeight = 15;
            this.com_bom.Location = new System.Drawing.Point(431, 150);
            this.com_bom.MatchEntryTimeout = ((long)(2000));
            this.com_bom.MaxDropDownItems = ((short)(5));
            this.com_bom.MaxLength = 32767;
            this.com_bom.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.com_bom.Name = "com_bom";
            this.com_bom.OddRowStyle = style118;
            this.com_bom.PartialRightColumn = false;
            this.com_bom.PropBag = resources.GetString("com_bom.PropBag");
            this.com_bom.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.com_bom.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.com_bom.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.com_bom.SelectedStyle = style119;
            this.com_bom.Size = new System.Drawing.Size(210, 20);
            this.com_bom.Style = style120;
            this.com_bom.TabIndex = 446;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageIndex = 0;
            this.label4.ImageList = this.img_Label;
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 444;
            this.label4.Text = "Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_obstype
            // 
            this.lbl_obstype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_obstype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obstype.ImageIndex = 0;
            this.lbl_obstype.ImageList = this.img_Label;
            this.lbl_obstype.Location = new System.Drawing.Point(8, 128);
            this.lbl_obstype.Name = "lbl_obstype";
            this.lbl_obstype.Size = new System.Drawing.Size(100, 21);
            this.lbl_obstype.TabIndex = 442;
            this.lbl_obstype.Text = "OBS Type";
            this.lbl_obstype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_transportyn
            // 
            this.lbl_transportyn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_transportyn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transportyn.ImageIndex = 0;
            this.lbl_transportyn.ImageList = this.img_Label;
            this.lbl_transportyn.Location = new System.Drawing.Point(653, 106);
            this.lbl_transportyn.Name = "lbl_transportyn";
            this.lbl_transportyn.Size = new System.Drawing.Size(100, 21);
            this.lbl_transportyn.TabIndex = 441;
            this.lbl_transportyn.Text = "Tranport Type";
            this.lbl_transportyn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_search
            // 
            this.cmb_search.AddItemCols = 0;
            this.cmb_search.AddItemSeparator = ';';
            this.cmb_search.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_search.Caption = "";
            this.cmb_search.CaptionHeight = 17;
            this.cmb_search.CaptionStyle = style121;
            this.cmb_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_search.ColumnCaptionHeight = 18;
            this.cmb_search.ColumnFooterHeight = 18;
            this.cmb_search.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_search.ContentHeight = 16;
            this.cmb_search.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_search.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_search.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_search.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_search.EditorHeight = 16;
            this.cmb_search.Enabled = false;
            this.cmb_search.EvenRowStyle = style122;
            this.cmb_search.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_search.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_search.FooterStyle = style123;
            this.cmb_search.GapHeight = 2;
            this.cmb_search.HeadingStyle = style124;
            this.cmb_search.HighLightRowStyle = style125;
            this.cmb_search.ItemHeight = 15;
            this.cmb_search.Location = new System.Drawing.Point(754, 40);
            this.cmb_search.MatchEntryTimeout = ((long)(2000));
            this.cmb_search.MaxDropDownItems = ((short)(5));
            this.cmb_search.MaxLength = 32767;
            this.cmb_search.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.OddRowStyle = style126;
            this.cmb_search.PartialRightColumn = false;
            this.cmb_search.PropBag = resources.GetString("cmb_search.PropBag");
            this.cmb_search.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_search.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_search.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_search.SelectedStyle = style127;
            this.cmb_search.Size = new System.Drawing.Size(210, 20);
            this.cmb_search.Style = style128;
            this.cmb_search.TabIndex = 440;
            this.cmb_search.TextChanged += new System.EventHandler(this.cmb_search_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(653, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 439;
            this.label3.Text = "Search";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_lotno
            // 
            this.txt_lotno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lotno.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_lotno.Location = new System.Drawing.Point(109, 106);
            this.txt_lotno.MaxLength = 10;
            this.txt_lotno.Name = "txt_lotno";
            this.txt_lotno.Size = new System.Drawing.Size(210, 21);
            this.txt_lotno.TabIndex = 437;
            // 
            // cmb_reqReason
            // 
            this.cmb_reqReason.AddItemCols = 0;
            this.cmb_reqReason.AddItemSeparator = ';';
            this.cmb_reqReason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqReason.Caption = "";
            this.cmb_reqReason.CaptionHeight = 17;
            this.cmb_reqReason.CaptionStyle = style129;
            this.cmb_reqReason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reqReason.ColumnCaptionHeight = 18;
            this.cmb_reqReason.ColumnFooterHeight = 18;
            this.cmb_reqReason.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reqReason.ContentHeight = 16;
            this.cmb_reqReason.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reqReason.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_reqReason.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reqReason.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reqReason.EditorHeight = 16;
            this.cmb_reqReason.Enabled = false;
            this.cmb_reqReason.EvenRowStyle = style130;
            this.cmb_reqReason.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqReason.FooterStyle = style131;
            this.cmb_reqReason.GapHeight = 2;
            this.cmb_reqReason.HeadingStyle = style132;
            this.cmb_reqReason.HighLightRowStyle = style133;
            this.cmb_reqReason.ItemHeight = 15;
            this.cmb_reqReason.Location = new System.Drawing.Point(754, 128);
            this.cmb_reqReason.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqReason.MaxDropDownItems = ((short)(5));
            this.cmb_reqReason.MaxLength = 32767;
            this.cmb_reqReason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqReason.Name = "cmb_reqReason";
            this.cmb_reqReason.OddRowStyle = style134;
            this.cmb_reqReason.PartialRightColumn = false;
            this.cmb_reqReason.PropBag = resources.GetString("cmb_reqReason.PropBag");
            this.cmb_reqReason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqReason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.SelectedStyle = style135;
            this.cmb_reqReason.Size = new System.Drawing.Size(210, 20);
            this.cmb_reqReason.Style = style136;
            this.cmb_reqReason.TabIndex = 436;
            // 
            // cmb_obstype
            // 
            this.cmb_obstype.AddItemCols = 0;
            this.cmb_obstype.AddItemSeparator = ';';
            this.cmb_obstype.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_obstype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_obstype.Caption = "";
            this.cmb_obstype.CaptionHeight = 17;
            this.cmb_obstype.CaptionStyle = style137;
            this.cmb_obstype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_obstype.ColumnCaptionHeight = 18;
            this.cmb_obstype.ColumnFooterHeight = 18;
            this.cmb_obstype.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_obstype.ContentHeight = 16;
            this.cmb_obstype.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_obstype.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_obstype.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_obstype.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_obstype.EditorHeight = 16;
            this.cmb_obstype.EvenRowStyle = style138;
            this.cmb_obstype.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_obstype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obstype.FooterStyle = style139;
            this.cmb_obstype.GapHeight = 2;
            this.cmb_obstype.HeadingStyle = style140;
            this.cmb_obstype.HighLightRowStyle = style141;
            this.cmb_obstype.ItemHeight = 15;
            this.cmb_obstype.Location = new System.Drawing.Point(109, 128);
            this.cmb_obstype.MatchEntryTimeout = ((long)(2000));
            this.cmb_obstype.MaxDropDownItems = ((short)(5));
            this.cmb_obstype.MaxLength = 32767;
            this.cmb_obstype.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_obstype.Name = "cmb_obstype";
            this.cmb_obstype.OddRowStyle = style142;
            this.cmb_obstype.PartialRightColumn = false;
            this.cmb_obstype.PropBag = resources.GetString("cmb_obstype.PropBag");
            this.cmb_obstype.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_obstype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_obstype.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_obstype.SelectedStyle = style143;
            this.cmb_obstype.Size = new System.Drawing.Size(210, 20);
            this.cmb_obstype.Style = style144;
            this.cmb_obstype.TabIndex = 435;
            // 
            // cmb_longyn
            // 
            this.cmb_longyn.AddItemCols = 0;
            this.cmb_longyn.AddItemSeparator = ';';
            this.cmb_longyn.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_longyn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_longyn.Caption = "";
            this.cmb_longyn.CaptionHeight = 17;
            this.cmb_longyn.CaptionStyle = style145;
            this.cmb_longyn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_longyn.ColumnCaptionHeight = 18;
            this.cmb_longyn.ColumnFooterHeight = 18;
            this.cmb_longyn.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_longyn.ContentHeight = 16;
            this.cmb_longyn.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_longyn.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_longyn.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_longyn.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_longyn.EditorHeight = 16;
            this.cmb_longyn.EvenRowStyle = style146;
            this.cmb_longyn.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_longyn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_longyn.FooterStyle = style147;
            this.cmb_longyn.GapHeight = 2;
            this.cmb_longyn.HeadingStyle = style148;
            this.cmb_longyn.HighLightRowStyle = style149;
            this.cmb_longyn.ItemHeight = 15;
            this.cmb_longyn.Location = new System.Drawing.Point(431, 84);
            this.cmb_longyn.MatchEntryTimeout = ((long)(2000));
            this.cmb_longyn.MaxDropDownItems = ((short)(5));
            this.cmb_longyn.MaxLength = 32767;
            this.cmb_longyn.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_longyn.Name = "cmb_longyn";
            this.cmb_longyn.OddRowStyle = style150;
            this.cmb_longyn.PartialRightColumn = false;
            this.cmb_longyn.PropBag = resources.GetString("cmb_longyn.PropBag");
            this.cmb_longyn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_longyn.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_longyn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_longyn.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_longyn.SelectedStyle = style151;
            this.cmb_longyn.Size = new System.Drawing.Size(210, 20);
            this.cmb_longyn.Style = style152;
            this.cmb_longyn.TabIndex = 433;
            // 
            // cmb_outsideyn
            // 
            this.cmb_outsideyn.AddItemCols = 0;
            this.cmb_outsideyn.AddItemSeparator = ';';
            this.cmb_outsideyn.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outsideyn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outsideyn.Caption = "";
            this.cmb_outsideyn.CaptionHeight = 17;
            this.cmb_outsideyn.CaptionStyle = style153;
            this.cmb_outsideyn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_outsideyn.ColumnCaptionHeight = 18;
            this.cmb_outsideyn.ColumnFooterHeight = 18;
            this.cmb_outsideyn.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_outsideyn.ContentHeight = 16;
            this.cmb_outsideyn.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_outsideyn.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_outsideyn.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_outsideyn.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_outsideyn.EditorHeight = 16;
            this.cmb_outsideyn.EvenRowStyle = style154;
            this.cmb_outsideyn.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_outsideyn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outsideyn.FooterStyle = style155;
            this.cmb_outsideyn.GapHeight = 2;
            this.cmb_outsideyn.HeadingStyle = style156;
            this.cmb_outsideyn.HighLightRowStyle = style157;
            this.cmb_outsideyn.ItemHeight = 15;
            this.cmb_outsideyn.Location = new System.Drawing.Point(431, 128);
            this.cmb_outsideyn.MatchEntryTimeout = ((long)(2000));
            this.cmb_outsideyn.MaxDropDownItems = ((short)(5));
            this.cmb_outsideyn.MaxLength = 32767;
            this.cmb_outsideyn.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_outsideyn.Name = "cmb_outsideyn";
            this.cmb_outsideyn.OddRowStyle = style158;
            this.cmb_outsideyn.PartialRightColumn = false;
            this.cmb_outsideyn.PropBag = resources.GetString("cmb_outsideyn.PropBag");
            this.cmb_outsideyn.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outsideyn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outsideyn.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outsideyn.SelectedStyle = style159;
            this.cmb_outsideyn.Size = new System.Drawing.Size(210, 20);
            this.cmb_outsideyn.Style = style160;
            this.cmb_outsideyn.TabIndex = 432;
            // 
            // cmb_shipyn
            // 
            this.cmb_shipyn.AddItemCols = 0;
            this.cmb_shipyn.AddItemSeparator = ';';
            this.cmb_shipyn.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipyn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipyn.Caption = "";
            this.cmb_shipyn.CaptionHeight = 17;
            this.cmb_shipyn.CaptionStyle = style161;
            this.cmb_shipyn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipyn.ColumnCaptionHeight = 18;
            this.cmb_shipyn.ColumnFooterHeight = 18;
            this.cmb_shipyn.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipyn.ContentHeight = 16;
            this.cmb_shipyn.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipyn.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipyn.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipyn.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipyn.EditorHeight = 16;
            this.cmb_shipyn.EvenRowStyle = style162;
            this.cmb_shipyn.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipyn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipyn.FooterStyle = style163;
            this.cmb_shipyn.GapHeight = 2;
            this.cmb_shipyn.HeadingStyle = style164;
            this.cmb_shipyn.HighLightRowStyle = style165;
            this.cmb_shipyn.ItemHeight = 15;
            this.cmb_shipyn.Location = new System.Drawing.Point(431, 106);
            this.cmb_shipyn.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipyn.MaxDropDownItems = ((short)(5));
            this.cmb_shipyn.MaxLength = 32767;
            this.cmb_shipyn.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipyn.Name = "cmb_shipyn";
            this.cmb_shipyn.OddRowStyle = style166;
            this.cmb_shipyn.PartialRightColumn = false;
            this.cmb_shipyn.PropBag = resources.GetString("cmb_shipyn.PropBag");
            this.cmb_shipyn.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipyn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipyn.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipyn.SelectedStyle = style167;
            this.cmb_shipyn.Size = new System.Drawing.Size(210, 20);
            this.cmb_shipyn.Style = style168;
            this.cmb_shipyn.TabIndex = 431;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_status.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_status.Location = new System.Drawing.Point(109, 150);
            this.txt_status.MaxLength = 10;
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(210, 21);
            this.txt_status.TabIndex = 429;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.Location = new System.Drawing.Point(431, 40);
            this.txt_styleCd.MaxLength = 10;
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.Size = new System.Drawing.Size(73, 21);
            this.txt_styleCd.TabIndex = 423;
            this.txt_styleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCd_KeyUp);
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemCols = 0;
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style169;
            this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_style.ColumnCaptionHeight = 18;
            this.cmb_style.ColumnFooterHeight = 18;
            this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_style.ContentHeight = 16;
            this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_style.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_style.EditorHeight = 16;
            this.cmb_style.EvenRowStyle = style170;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style171;
            this.cmb_style.GapHeight = 2;
            this.cmb_style.HeadingStyle = style172;
            this.cmb_style.HighLightRowStyle = style173;
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(505, 40);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style174;
            this.cmb_style.PartialRightColumn = false;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style175;
            this.cmb_style.Size = new System.Drawing.Size(136, 20);
            this.cmb_style.Style = style176;
            this.cmb_style.TabIndex = 424;
            this.cmb_style.TextChanged += new System.EventHandler(this.cmb_style_TextChanged);
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(815, 62);
            this.txt_itemName.MaxLength = 10;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(149, 21);
            this.txt_itemName.TabIndex = 422;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(754, 62);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(60, 21);
            this.txt_itemCode.TabIndex = 418;
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(546, 62);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(73, 21);
            this.txt_itemGroup.TabIndex = 421;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style177;
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
            this.cmb_itemGroup.EvenRowStyle = style178;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style179;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style180;
            this.cmb_itemGroup.HighLightRowStyle = style181;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(431, 62);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style182;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style183;
            this.cmb_itemGroup.Size = new System.Drawing.Size(114, 20);
            this.cmb_itemGroup.Style = style184;
            this.cmb_itemGroup.TabIndex = 420;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(619, 62);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 419;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ImageIndex = 0;
            this.lbl_status.ImageList = this.img_Label;
            this.lbl_status.Location = new System.Drawing.Point(653, 128);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_status.TabIndex = 415;
            this.lbl_status.Text = "Request Reason";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_itemdiv
            // 
            this.lbl_itemdiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemdiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemdiv.ImageIndex = 0;
            this.lbl_itemdiv.ImageList = this.img_Label;
            this.lbl_itemdiv.Location = new System.Drawing.Point(653, 84);
            this.lbl_itemdiv.Name = "lbl_itemdiv";
            this.lbl_itemdiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemdiv.TabIndex = 413;
            this.lbl_itemdiv.Text = "Item Division";
            this.lbl_itemdiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_trantype
            // 
            this.cmb_trantype.AddItemCols = 0;
            this.cmb_trantype.AddItemSeparator = ';';
            this.cmb_trantype.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_trantype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_trantype.Caption = "";
            this.cmb_trantype.CaptionHeight = 17;
            this.cmb_trantype.CaptionStyle = style185;
            this.cmb_trantype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_trantype.ColumnCaptionHeight = 18;
            this.cmb_trantype.ColumnFooterHeight = 18;
            this.cmb_trantype.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_trantype.ContentHeight = 16;
            this.cmb_trantype.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_trantype.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_trantype.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_trantype.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_trantype.EditorHeight = 16;
            this.cmb_trantype.EvenRowStyle = style186;
            this.cmb_trantype.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_trantype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_trantype.FooterStyle = style187;
            this.cmb_trantype.GapHeight = 2;
            this.cmb_trantype.HeadingStyle = style188;
            this.cmb_trantype.HighLightRowStyle = style189;
            this.cmb_trantype.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_trantype.ItemHeight = 15;
            this.cmb_trantype.Location = new System.Drawing.Point(754, 106);
            this.cmb_trantype.MatchEntryTimeout = ((long)(2000));
            this.cmb_trantype.MaxDropDownItems = ((short)(5));
            this.cmb_trantype.MaxLength = 32767;
            this.cmb_trantype.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_trantype.Name = "cmb_trantype";
            this.cmb_trantype.OddRowStyle = style190;
            this.cmb_trantype.PartialRightColumn = false;
            this.cmb_trantype.PropBag = resources.GetString("cmb_trantype.PropBag");
            this.cmb_trantype.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_trantype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_trantype.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_trantype.SelectedStyle = style191;
            this.cmb_trantype.Size = new System.Drawing.Size(210, 20);
            this.cmb_trantype.Style = style192;
            this.cmb_trantype.TabIndex = 410;
            this.cmb_trantype.SelectedValueChanged += new System.EventHandler(this.cmb_trantype_SelectedValueChanged);
            // 
            // lbl_lotno
            // 
            this.lbl_lotno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_lotno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lotno.ImageIndex = 0;
            this.lbl_lotno.ImageList = this.img_Label;
            this.lbl_lotno.Location = new System.Drawing.Point(8, 106);
            this.lbl_lotno.Name = "lbl_lotno";
            this.lbl_lotno.Size = new System.Drawing.Size(100, 21);
            this.lbl_lotno.TabIndex = 408;
            this.lbl_lotno.Text = "Lot No";
            this.lbl_lotno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shiptype1
            // 
            this.lbl_shiptype1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shiptype1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shiptype1.ImageIndex = 1;
            this.lbl_shiptype1.ImageList = this.img_Label;
            this.lbl_shiptype1.Location = new System.Drawing.Point(8, 62);
            this.lbl_shiptype1.Name = "lbl_shiptype1";
            this.lbl_shiptype1.Size = new System.Drawing.Size(100, 21);
            this.lbl_shiptype1.TabIndex = 406;
            this.lbl_shiptype1.Text = "Ship Type";
            this.lbl_shiptype1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(653, 62);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 404;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_itemDiv
            // 
            this.cmb_itemDiv.AddItemCols = 0;
            this.cmb_itemDiv.AddItemSeparator = ';';
            this.cmb_itemDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemDiv.Caption = "";
            this.cmb_itemDiv.CaptionHeight = 17;
            this.cmb_itemDiv.CaptionStyle = style193;
            this.cmb_itemDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_itemDiv.ColumnCaptionHeight = 18;
            this.cmb_itemDiv.ColumnFooterHeight = 18;
            this.cmb_itemDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_itemDiv.ContentHeight = 16;
            this.cmb_itemDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_itemDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_itemDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_itemDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_itemDiv.EditorHeight = 16;
            this.cmb_itemDiv.EvenRowStyle = style194;
            this.cmb_itemDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemDiv.FooterStyle = style195;
            this.cmb_itemDiv.GapHeight = 2;
            this.cmb_itemDiv.HeadingStyle = style196;
            this.cmb_itemDiv.HighLightRowStyle = style197;
            this.cmb_itemDiv.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_itemDiv.ItemHeight = 15;
            this.cmb_itemDiv.Location = new System.Drawing.Point(754, 84);
            this.cmb_itemDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemDiv.MaxDropDownItems = ((short)(5));
            this.cmb_itemDiv.MaxLength = 32767;
            this.cmb_itemDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemDiv.Name = "cmb_itemDiv";
            this.cmb_itemDiv.OddRowStyle = style198;
            this.cmb_itemDiv.PartialRightColumn = false;
            this.cmb_itemDiv.PropBag = resources.GetString("cmb_itemDiv.PropBag");
            this.cmb_itemDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemDiv.SelectedStyle = style199;
            this.cmb_itemDiv.Size = new System.Drawing.Size(210, 20);
            this.cmb_itemDiv.Style = style200;
            this.cmb_itemDiv.TabIndex = 5;
            this.cmb_itemDiv.SelectedValueChanged += new System.EventHandler(this.cmb_itemDiv_SelectedValueChanged);
            // 
            // lbl_mrpno
            // 
            this.lbl_mrpno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_mrpno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mrpno.ImageIndex = 1;
            this.lbl_mrpno.ImageList = this.img_Label;
            this.lbl_mrpno.Location = new System.Drawing.Point(8, 84);
            this.lbl_mrpno.Name = "lbl_mrpno";
            this.lbl_mrpno.Size = new System.Drawing.Size(100, 21);
            this.lbl_mrpno.TabIndex = 50;
            this.lbl_mrpno.Text = "MRP Ship No";
            this.lbl_mrpno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_mrpno
            // 
            this.cmb_mrpno.AddItemCols = 0;
            this.cmb_mrpno.AddItemSeparator = ';';
            this.cmb_mrpno.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_mrpno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_mrpno.Caption = "";
            this.cmb_mrpno.CaptionHeight = 17;
            this.cmb_mrpno.CaptionStyle = style201;
            this.cmb_mrpno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_mrpno.ColumnCaptionHeight = 18;
            this.cmb_mrpno.ColumnFooterHeight = 18;
            this.cmb_mrpno.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_mrpno.ContentHeight = 16;
            this.cmb_mrpno.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_mrpno.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_mrpno.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_mrpno.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_mrpno.EditorHeight = 16;
            this.cmb_mrpno.EvenRowStyle = style202;
            this.cmb_mrpno.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_mrpno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mrpno.FooterStyle = style203;
            this.cmb_mrpno.GapHeight = 2;
            this.cmb_mrpno.HeadingStyle = style204;
            this.cmb_mrpno.HighLightRowStyle = style205;
            this.cmb_mrpno.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_mrpno.ItemHeight = 15;
            this.cmb_mrpno.Location = new System.Drawing.Point(109, 84);
            this.cmb_mrpno.MatchEntryTimeout = ((long)(2000));
            this.cmb_mrpno.MaxDropDownItems = ((short)(5));
            this.cmb_mrpno.MaxLength = 32767;
            this.cmb_mrpno.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_mrpno.Name = "cmb_mrpno";
            this.cmb_mrpno.OddRowStyle = style206;
            this.cmb_mrpno.PartialRightColumn = false;
            this.cmb_mrpno.PropBag = resources.GetString("cmb_mrpno.PropBag");
            this.cmb_mrpno.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_mrpno.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_mrpno.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_mrpno.SelectedStyle = style207;
            this.cmb_mrpno.Size = new System.Drawing.Size(210, 20);
            this.cmb_mrpno.Style = style208;
            this.cmb_mrpno.TabIndex = 5;
            this.cmb_mrpno.SelectedValueChanged += new System.EventHandler(this.cmb_mrpno_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 393;
            this.label2.Text = "      MRP Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemCols = 0;
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style209;
            this.cmb_shipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipType.ColumnCaptionHeight = 18;
            this.cmb_shipType.ColumnFooterHeight = 18;
            this.cmb_shipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipType.ContentHeight = 16;
            this.cmb_shipType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipType.EditorHeight = 16;
            this.cmb_shipType.EvenRowStyle = style210;
            this.cmb_shipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style211;
            this.cmb_shipType.GapHeight = 2;
            this.cmb_shipType.HeadingStyle = style212;
            this.cmb_shipType.HighLightRowStyle = style213;
            this.cmb_shipType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(109, 62);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style214;
            this.cmb_shipType.PartialRightColumn = false;
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style215;
            this.cmb_shipType.Size = new System.Drawing.Size(210, 20);
            this.cmb_shipType.Style = style216;
            this.cmb_shipType.TabIndex = 5;
            this.cmb_shipType.SelectedValueChanged += new System.EventHandler(this.cmb_shipType_SelectedValueChanged);
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(144, 166);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(832, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style217;
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
            this.cmb_factory.EvenRowStyle = style218;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style219;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style220;
            this.cmb_factory.HighLightRowStyle = style221;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style222;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style223;
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style224;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 40);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 50;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 167);
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
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 169);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(160, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(815, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // lbl_img
            // 
            this.lbl_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_img.Image = ((System.Drawing.Image)(resources.GetObject("lbl_img.Image")));
            this.lbl_img.Location = new System.Drawing.Point(887, 30);
            this.lbl_img.Name = "lbl_img";
            this.lbl_img.Size = new System.Drawing.Size(101, 144);
            this.lbl_img.TabIndex = 46;
            this.lbl_img.TabStop = false;
            // 
            // ctx_main
            // 
            this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_findData,
            this.menuItem9,
            this.mnu_allSelect,
            this.menuItem5,
            this.mnu_value,
            this.menuItem10,
            this.menuItem3,
            this.menuItem4,
            this.menuItem2,
            this.mnu_confirm,
            this.mnu_canfirmCancel,
            this.mnu_Rate});
            // 
            // mnu_findData
            // 
            this.mnu_findData.Index = 0;
            this.mnu_findData.Text = "Find Data";
            this.mnu_findData.Click += new System.EventHandler(this.mnu_findData_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.Text = "-";
            // 
            // mnu_allSelect
            // 
            this.mnu_allSelect.Index = 2;
            this.mnu_allSelect.Text = "All Select";
            this.mnu_allSelect.Click += new System.EventHandler(this.mnu_allSelect_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "-";
            // 
            // mnu_value
            // 
            this.mnu_value.Index = 4;
            this.mnu_value.Text = "Value Change";
            this.mnu_value.Click += new System.EventHandler(this.mnu_value_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 5;
            this.menuItem10.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 6;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_header,
            this.mnu_all});
            this.menuItem3.Text = "Tree View Option";
            // 
            // mnu_header
            // 
            this.mnu_header.Index = 0;
            this.mnu_header.Text = "Header";
            this.mnu_header.Click += new System.EventHandler(this.mnu_header_Click);
            // 
            // mnu_all
            // 
            this.mnu_all.Index = 1;
            this.mnu_all.Text = "All";
            this.mnu_all.Click += new System.EventHandler(this.mnu_all_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 7;
            this.menuItem4.Text = "Usage Check";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 8;
            this.menuItem2.Text = "-";
            this.menuItem2.Visible = false;
            // 
            // mnu_confirm
            // 
            this.mnu_confirm.Index = 9;
            this.mnu_confirm.Text = "Confirm";
            this.mnu_confirm.Visible = false;
            // 
            // mnu_canfirmCancel
            // 
            this.mnu_canfirmCancel.Index = 10;
            this.mnu_canfirmCancel.Text = "Confirm Cancel";
            this.mnu_canfirmCancel.Visible = false;
            // 
            // mnu_Rate
            // 
            this.mnu_Rate.Index = 11;
            this.mnu_Rate.Text = "Rate";
            this.mnu_Rate.Click += new System.EventHandler(this.mnu_Rate_Click);
            // 
            // Form_BM_MRP_Item
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BM_MRP_Item";
            this.Load += new System.EventHandler(this.Form_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_tree_MouseUp);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_tree_MouseDown);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_bom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obstype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_longyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outsideyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_trantype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_mrpno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_img)).EndInit();
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

		#endregion

		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();	
			_duplicateData.Clear();
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
			{
				this.Tbtn_SearchProcess();
				_duplicateData.Clear();
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
                    tRun = new Thread(new ThreadStart(RunSave));

                    if (tRun != null)
                    {
                        tRun.Start();
                        _pop = new Pop_BM_Shipping_Wait();
                        _pop.Start();

                        //Display_Data();
                    }

                    tRun.Abort();
				}
			
			_duplicateData.Clear();
		}





        public void RunSave()
        {
            Invoke(new DelegateSetn(Tbtn_SaveProcess)); // 폼 스레드에 작업 넘김

        }







		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
			{
				if (ClassLib.ComFunction.User_Message("Do you want to Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Tbtn_ConfirmProcess();
				}
			}
		}


		#endregion

		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			int vChilds = this.MdiParent.MdiChildren.Length;

			for (int vIdx = vChilds - 1 ; vIdx >= 0 ; vIdx--)
			{
				if (this.MdiParent.MdiChildren[vIdx] is Form_BM_MRP_Operation)
					this.MdiParent.MdiChildren[vIdx].Close();
			}

			this.Dispose(true);
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_MrpShipNoSetting();
			CheckStatus();
			fgrid_main.ClearAll();
		}

		private void cmb_mrpno_SelectedValueChanged(object sender, System.EventArgs e)
		{
			CheckStatus();
			fgrid_main.ClearAll();
		}

		private void cmb_shipType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_MrpShipNoSetting();
		}

		private void cmb_trantype_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_MrpShipNoSetting();
		}

		private void cmb_itemDiv_SelectedValueChanged(object sender, System.EventArgs e)
		{
			fgrid_main.ClearAll();

			bool vUse = false;
			Color vBackground = Color.Black;
			
			if (cmb_itemDiv.SelectedIndex == 1)
			{
				vUse = true;
				vBackground = Color.Blue;
			}

			mnu_value.Visible = vUse;
			menuItem10.Visible = vUse;
			fgrid_main.Cols[(int)TBSBM_MRP_ITEM_LOT.IxSHIP_YN].AllowEditing = vUse;
			fgrid_main.Cols[(int)TBSBM_MRP_ITEM_LOT.IxPURCHASE_YN].AllowEditing = vUse;
			fgrid_main.Cols[(int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN].AllowEditing = vUse;

			fgrid_main.Cols[(int)TBSBM_MRP_ITEM_LOT.IxSHIP_YN].StyleNew.ForeColor = vBackground;
			fgrid_main.Cols[(int)TBSBM_MRP_ITEM_LOT.IxPURCHASE_YN].StyleNew.ForeColor = vBackground;
			fgrid_main.Cols[(int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN].StyleNew.ForeColor = vBackground;
		}

		private void txt_styleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				this.Txt_StyleCdKeyUpProcess();
		}

		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCd, " "));
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(vDt, cmb_style, 0, 1, 2, 3, 4, true, 100, 221); 
				vDt.Dispose();
				
				if (txt_styleCd.Text.Length == 9)
				{
					string vCode = txt_styleCd.Text;
					vCode = vCode.Substring(0, 6) + "-" + vCode.Substring(6, 3);
					cmb_style.SelectedValue = vCode;
				}
			}
			catch //(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs_StyleCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}

		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
			string vTyep = this.cmb_itemGroup.SelectedValue.ToString();
			FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);
				
			vPopup.ShowDialog();
			
			_itemGroupCode			= COM.ComVar.Parameter_PopUp[3];
			this.txt_itemGroup.Text	= COM.ComVar.Parameter_PopUp[4];

			vPopup.Dispose();		
		}

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if ( cmb_itemGroup.SelectedIndex >= 1 )
			{
				this.btn_groupSearch.Enabled = true;
			}
			else
			{
				txt_itemGroup.Text = "";
				_itemGroupCode = "";
				this.btn_groupSearch.Enabled = false;
			}
		}

		private void btn_valid_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_valid))
			{
				ClassLib.ComFunction.User_Message("Validation Check Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btn_order_Click(object sender, System.EventArgs e)
		{
			try
			{
				Pop_BM_Order_List vPop = new Pop_BM_Order_List("PKG_SBM_MRP_ITEM.RUN_SBM_USAGE");
				vPop.ShowDialog();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}



		#region Forecast 관련

		private void btn_forecast_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_shipType, cmb_mrpno}; 
				System.Windows.Forms.TextBox[] txt_array = {};  
				bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array); 
				if(! essential_check) return;


				string factory = cmb_factory.SelectedValue.ToString();
				string ship_type = cmb_shipType.SelectedValue.ToString();
				string mrp_ship_no = cmb_mrpno.SelectedValue.ToString();

				if(ship_type.Trim().Equals("") ) 
				{
					ClassLib.ComFunction.User_Message("Select ship type", "Forecast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}


				// mrp_ship_no confirm 여부 체크 후 작업 가능 
//				string mrp_confirm_yn = SELECT_SBM_READY_MRP_YN(factory, mrp_ship_no);
//
//				if(mrp_confirm_yn == "Y")
//				{
//					ClassLib.ComFunction.User_Message("Already confirm MRP shipping number.", "Forecast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//					return;
//				}
 

				if (txt_status.Text.ToUpper().Equals(ClassLib.ComVar.Status_CONFIRM))
				{
					ClassLib.ComFunction.User_Message("Already confirm MRP shipping number.", "Forecast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Pop_BM_Forecast_List vPop = new Pop_BM_Forecast_List(factory, ship_type, mrp_ship_no);
				vPop.ShowDialog();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Forecast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}



		/// <summary>
		/// SELECT_SBP_FORECAST_LIST : forecast 대상 리스트 찾기
		/// </summary>
		/// <returns>DataTable</returns>
		private string SELECT_SBM_READY_MRP_YN(string arg_factory, string arg_mrp_ship_no)
		{

			try
			{

				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_FORECAST.SELECT_SBM_READY_MRP_YN";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_mrp_ship_no; 
				MyOraDB.Parameter_Values[2] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();
			
				if(vds_ret == null) return ""; 
				return vds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString();
			}
			catch
			{
				return "";
			}

		}




		#endregion


		#region 컨텍스트 메뉴

		private void mnu_findData_Click(object sender, System.EventArgs e)
		{
			finder = new Pop_Finder(fgrid_main, 1, fgrid_main.Cols.Count - 1);
			finder.Location = new Point(MousePosition.X, MousePosition.Y);
			finder.Show();
		}

		private void mnu_allSelect_Click(object sender, System.EventArgs e)
		{
			fgrid_main.SelectAll();
		}

		private void mnu_header_Click(object sender, System.EventArgs e)
		{
            fgrid_main.Tree.Show(1);		
		}

		private void mnu_all_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);		
		}

		private void mnu_value_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_mnu_value))
				Mnu_ValueChange();
		}

		
		private void mnu_Rate_Click(object sender, System.EventArgs e)
		{
			Mnu_Rate();
		}

		#endregion

		#region 버튼 클릭

		private void btn_insert_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 8;
		}

		private void btn_insert_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 9;
		}

		private void btn_delete_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 4;
		}

		private void btn_delete_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 5;
		}

		private void btn_cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		private void btn_cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_tree_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 12;
		}

		private void btn_tree_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 13;
		}

		private void btn_size_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_size_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		#endregion

		#endregion 

		#region 이벤트 처리 메서드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
			// form set
			this.Text = "Check MRP Result-2";
            lbl_MainTitle.Text = "Check MRP Result-2";


            ClassLib.ComFunction.SetLangDic(this);



			// grid set
			fgrid_main.Set_Grid("SBM_MRP_ITEM_LOT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);
			Grid_SetFormat();

			// factory set
			DataTable vDt;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose();

			Init_YN();
			Init_COMBO();
			CheckStatus();

			// tbtn set
			this.tbtn_Delete.Enabled = false;
			this.tbtn_Print.Enabled  = true;
			this.tbtn_Create.Enabled = false;
		}

		private void Init_YN()
		{
			DataTable vDt;
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC00");
			COM.ComCtl.Set_ComboList(vDt, cmb_shipyn, 1, 2, true,40,50);
			cmb_shipyn.SelectedIndex = 0;

			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC00");
			COM.ComCtl.Set_ComboList(vDt, cmb_outsideyn, 1, 2, true,40,50);
			cmb_outsideyn.SelectedIndex = 0;

			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC00");
			COM.ComCtl.Set_ComboList(vDt, cmb_longyn, 1, 2, true,40,50);
			cmb_longyn.SelectedIndex = 0;

			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC00");
			COM.ComCtl.Set_ComboList(vDt, com_bom, 1, 2, true,40,50);
			com_bom.SelectedIndex =0;

		}

		private void Init_COMBO()
		{
			DataTable vDt;
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxOBSType);
			COM.ComCtl.Set_ComboList(vDt, cmb_obstype, 1, 2, true);
			cmb_obstype.SelectedIndex = 0;

			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM16");
			COM.ComCtl.Set_ComboList(vDt, cmb_trantype, 1, 2, false);
			cmb_trantype.SelectedIndex = 0;
			vDt.Dispose();

			vDt = ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true, 45, 60);
			cmb_itemGroup.SelectedIndex = 0;
			vDt.Dispose();

			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_reqReason, 1, 2, true);
			cmb_reqReason.SelectedIndex = 0;
			vDt.Dispose();

			// ship type set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
			COM.ComCtl.Set_ComboList(vDt, cmb_shipType, 1, 2, true);
			cmb_shipType.SelectedValue = (cmb_shipType.Tag == null) ? "11" : cmb_shipType.Tag;
			vDt.Dispose();

			// SEARCH
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM12");
			COM.ComCtl.Set_ComboList(vDt, cmb_search, 1, 2, false);
			cmb_search.SelectedIndex = 0;
			vDt.Dispose();


			// item division set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPItemDivision);
			COM.ComCtl.Set_ComboList(vDt, cmb_itemDiv, 1, 2, true);
			cmb_itemDiv.SelectedIndex = 1;
			vDt.Dispose();

			string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
			string vShipType = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			_shipNoTitles			= new string[]{"MRP Ship No", "Request Reason"};
			_shipNoWidth			= new int[]{	150,			60};
			_shipNoVisible			= new bool[]{true, true};

			vDt = ClassLib.ComFunction.SELECT_MRP_SHIP_NO_LIST(vFactory, vShipType);
			COM.ComCtl.Set_ComboList(vDt, cmb_mrpno, 0, 0, false, false);
			cmb_mrpno.SelectedValue = (cmb_mrpno.Tag == null) ? "" : cmb_mrpno.Tag;

			


		}


		public void SELECT_MRP_ADVICE_UPDATE(string arg_mrp_ship_no,string arg_lot_no,string arg_lot_seq,string arg_style_cd,string arg_item_cd,string arg_spec_cd,string arg_color_cd,string arg_confirm_qty,string arg_ship_yn)
		{
			COM.OraDB MyOraDB = new COM.OraDB();

			MyOraDB.ReDim_Parameter(11);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_MRP_SEARCH.SELECT_MRP_ADVICE_UPDATE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[4] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[7] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[8] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[9] = "ARG_CONFIRM_QTY";
			MyOraDB.Parameter_Name[10] = "ARG_SHIP_YN";
		

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


			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = arg_mrp_ship_no;
			MyOraDB.Parameter_Values[2] = arg_lot_no;
			MyOraDB.Parameter_Values[3] = arg_lot_seq;
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[5] = arg_style_cd;
			MyOraDB.Parameter_Values[6] = arg_item_cd;
			MyOraDB.Parameter_Values[7] = arg_spec_cd;
			MyOraDB.Parameter_Values[8] = arg_color_cd;
			MyOraDB.Parameter_Values[9] = arg_confirm_qty;
			MyOraDB.Parameter_Values[10] = arg_ship_yn;

			
			MyOraDB.Add_Select_Parameter(true);
			MyOraDB.Exe_Select_Procedure();
		
		}

		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				string pro_name="PKG_SBM_MRP_ITEM.SELECT_MRP_ITEM_LOT";

				this.Cursor = Cursors.WaitCursor;
				
				if(cmb_search.SelectedValue.ToString() =="1")
				{
					// grid set
					pro_name="PKG_SBM_MRP_ITEM.SELECT_MRP_ITEM_ITEM";
					fgrid_main.Cols[_confirmQtyCol].AllowEditing = true;

					mnu_value.Visible = false;
					menuItem10.Visible = false;
				}
				else
				{
					// grid set
					pro_name="PKG_SBM_MRP_ITEM.SELECT_MRP_ITEM_LOT";

					fgrid_main.Cols[_confirmQtyCol].AllowEditing = true;

					mnu_value.Visible = true;
					menuItem10.Visible = true;
				}
				
				DataTable vDt = SELECT_MRP_ADVICE_LIST(pro_name);

				if (vDt.Rows.Count > 0)
				{
					ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_main, vDt, 0);
					fgrid_main.Tree.Column = (int)TBSBM_MRP_ADJUST_MULTI.IxITEM_NAME;
					Grid_SetColor();
				}
				else
				{
					fgrid_main.ClearAll();
				}

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SearchProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_SaveProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SBM_MRP_ITEM())
				{
					fgrid_main.Refresh_Division();
					Grid_SetColor();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					ClassLib.ComFunction.User_Message("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
					ClassLib.ComFunction.User_Message("Save Fail", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SaveProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				if (_pop != null)
					_pop.Close();
			}
		}

		private void Tbtn_ConfirmProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				// Confirm
				if (SAVE_SBM_MRP_ADJUST_CONFIRM())
				{
					for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
					{
						fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ITEM_LOT.IxSTATUS] = "C";
					}

					fgrid_main.Refresh_Division();
					Grid_SetColor();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					ClassLib.ComFunction.User_Message("Confirm complete", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

					txt_status.Text = "Confirm";

					tbtn_Save.Enabled = false;
					tbtn_Confirm.Enabled = false;
					fgrid_main.AllowEditing = false;
					btn_Tree.Enabled = false;
					btn_Insert.Enabled = false;
					btn_Delete.Enabled = false;
					btn_Recover.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_ConfirmProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		
		#endregion

		#region 컨트롤 이벤트 처리 메서드

		private void Cmb_MrpShipNoSetting()
		{
			try
			{
				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vShipType = COM.ComFunction.Empty_Combo(cmb_shipType, "");

				DataTable vDt = ClassLib.ComFunction.SELECT_MRP_SHIP_NO_LIST(vFactory, vShipType);
				if (vDt.Rows.Count > 1)
				{
					COM.ComCtl.Set_ComboList(vDt, cmb_mrpno, 0, 1, false, 210, 100);
				}
				else
				{
					COM.ComCtl.Set_ComboList(vDt, cmb_mrpno, 0, 0, false, 210, 100);
				}
				
				ClassLib.ComFunction.SetComboStyle(cmb_mrpno, _shipNoTitles, _shipNoWidth, _shipNoVisible, "MRP Ship No");
				cmb_mrpno.SelectedIndex = -1;
			}
			catch {}
		}

		public void CheckStatus()
		{
			// status set
			txt_status.Text = ClassLib.ComFunction.ProcessStatus(_process, COM.ComFunction.Empty_Combo(cmb_factory, ""), COM.ComFunction.Empty_Combo(cmb_mrpno, ""));

			if (!txt_status.Text.ToUpper().Equals(ClassLib.ComVar.Status_SAVE))
			{
				fgrid_main.AllowEditing = false;
				btn_Tree.Enabled = false;
				btn_Insert.Enabled = false;
				btn_Delete.Enabled = false;
				btn_Recover.Enabled = false;
			}
			else
			{
				fgrid_main.AllowEditing = true;
				btn_Tree.Enabled = true;
				btn_Insert.Enabled = true;
				btn_Delete.Enabled = true;
				btn_Recover.Enabled = true;
			}

			// button enable set
			DataTable vDt			 = ClassLib.ComFunction.SELECT_PROCESS_CHARGE(cmb_factory.SelectedValue.ToString(), _process);

			tbtn_Save.Enabled		 = ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Save, txt_status.Text);
			tbtn_Confirm.Enabled	 = ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Confirm, txt_status.Text);
		}


		#endregion

		#region 그리드 이벤트 처리 메서드

		private void Grid_AfterEditProcess()
		{
			int vRow = fgrid_main.Row;
			int vCol = fgrid_main.Col;

			if (vCol == _confirmQtyCol)
			{
				Row vParent = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row;
				vParent[_confirmQtyCol] = Convert.ToDouble(vParent[_confirmQtyCol]) + (Convert.ToDouble(fgrid_main[vRow, vCol]) - Convert.ToDouble(fgrid_main.Buffer_CellData));
			}
			if (vCol == (int)ClassLib.TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN)
			{
				DuplicationCheck(fgrid_main.Rows[vRow]);
				return;
			}

			fgrid_main.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_main.Row < fgrid_main.Rows.Fixed)
				return;

			int vRow = fgrid_main.Row;

			if ( e.Button == MouseButtons.Right )
				ctx_main.Show(fgrid_main, new Point(e.X, e.Y));
		}

		private object DuplicationCheck(object arg_row)
		{			
			Row vCurRow = (Row)arg_row;
			Row vParentRow = vCurRow.Node.GetNode(NodeTypeEnum.Parent).Row;

			string vCurItem = ClassLib.ComFunction.NullToBlank(vCurRow[(int)ClassLib.TBSBM_MRP_ITEM_LOT.IxITEM_CD]);
			string vCurSpec = ClassLib.ComFunction.NullToBlank(vCurRow[(int)ClassLib.TBSBM_MRP_ITEM_LOT.IxSPEC_CD]);
			string vCurColor = ClassLib.ComFunction.NullToBlank(vCurRow[(int)ClassLib.TBSBM_MRP_ITEM_LOT.IxCOLOR_CD]);
			string vCurOutside = ClassLib.ComFunction.NullToBlank(vCurRow[(int)ClassLib.TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN]);
           
            int vStartIdx = vParentRow.Index + 1;
			int vEndIdx = vParentRow.Node.GetNode(NodeTypeEnum.NextSibling) == null ? fgrid_main.Rows.Count : vParentRow.Node.GetNode(NodeTypeEnum.NextSibling).Row.Index;

			for (int vIdx = vStartIdx ; vIdx < vEndIdx ; vIdx++)
			{
				if (vCurRow.Index == vIdx)
					continue;

				string vItem = ClassLib.ComFunction.NullToBlank(fgrid_main[vIdx, (int)ClassLib.TBSBM_MRP_ITEM_LOT.IxITEM_CD]);
				string vSpec = ClassLib.ComFunction.NullToBlank(fgrid_main[vIdx, (int)ClassLib.TBSBM_MRP_ITEM_LOT.IxSPEC_CD]);
				string vColor = ClassLib.ComFunction.NullToBlank(fgrid_main[vIdx, (int)ClassLib.TBSBM_MRP_ITEM_LOT.IxCOLOR_CD]);
				string vOutside = ClassLib.ComFunction.NullToBlank(fgrid_main[vIdx, (int)ClassLib.TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN]);

				if (vCurItem.Equals(vItem) && vCurSpec.Equals(vSpec) && vCurColor.Equals(vColor) && vCurOutside.Equals(vOutside))
				{
					ClassLib.ComFunction.User_Message("Exist Duplicated Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					fgrid_main.Select(vIdx, 0);
					fgrid_main.TopRow = vIdx + 1;
					return false;
				}
			}

			return true;
		}

		

		#endregion

		#region 컨텍스트 메뉴 이벤트 처리 메서드

		private void Mnu_ValueChange()
		{
			try
			{
				int vCol = fgrid_main.Col;

				ClassLib.ComVar.Parameter_PopUp = new string[]{"Shipping"};
				ClassLib.ComVar.Parameter_PopUp_Object = new object[]{fgrid_main.GetDataSourceWithCode(vCol)};
				Pop_BM_Changer _pop = new Pop_BM_Changer();
				_pop.ShowDialog();

				if (ClassLib.ComVar.Parameter_PopUp != null)
				{
					foreach (int vRow in fgrid_main.Selections)
					{
						if (fgrid_main.Rows[vRow].AllowEditing && fgrid_main.Rows[vRow].Node.Level == 2)
						{
							fgrid_main[vRow, fgrid_main.Col] = ClassLib.ComVar.Parameter_PopUp[0];
							fgrid_main.Update_Row(vRow);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBM_MRP_ITEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Mnu_Rate()
		{
			try
			{
				int vCol = fgrid_main.Col;

				ClassLib.ComVar.Parameter_PopUp = new string[]{"Value", "100"};
				//ClassLib.ComVar.Parameter_PopUp_Object = new object[]{fgrid_main.GetDataSourceWithCode(_confirmQtyCol)};
				Pop_BM_Changer _pop = new Pop_BM_Changer();
				_pop.ShowDialog();

				if (ClassLib.ComVar.Parameter_PopUp != null)
				{
					foreach (int vRow in fgrid_main.Selections)
					{
						if (fgrid_main.Rows[vRow].Node.Level == 2)
						{
							int    _ConfirmQty = Convert.ToInt32( fgrid_main[vRow, _confirmQtyCol] );
							double _Rate       = _ConfirmQty * ( Convert.ToDouble( ClassLib.ComVar.Parameter_PopUp[0] ) / 100 ) ;
							int    _Result     = (int)_Rate;
							string _Temp       = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxREMARKS]);
							string _Remarks    = _Temp + ", Rate : " + ClassLib.ComVar.Parameter_PopUp[0] + "%";

							fgrid_main[vRow, _confirmQtyCol] = _Result;
							fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxREMARKS] = _Remarks;

							//fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxCONFIRM_QTY] = ClassLib.ComVar.Parameter_PopUp[0]
							fgrid_main.Update_Row(vRow);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Rate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		#endregion

		#region 이벤트 처리시 사용되는 기능 메서드

		// grid format set
		private void Grid_SetFormat()
		{
			int vCol = 1;

			while (vCol < fgrid_main.Cols.Count)
			{
				if (fgrid_main.Cols[vCol].Style.Name.IndexOf("NUMBER") > -1)
				{
					if (vCol == _confirmQtyCol || vCol == _pkQtyCol)
						fgrid_main.Cols[vCol].Format = "#,##0";
					else
						fgrid_main.Cols[vCol].Format = "#,##0.00";
				}

				vCol++;
			}
		}

        // grid color set
		private void Grid_SetColor()
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				CellRange vRange = fgrid_main.GetCellRange(vRow, 1, vRow, fgrid_main.Cols.Count - 1);
				
				// 그리드 디자인
				switch (fgrid_main.Rows[vRow].Node.Level)
				{
					case 1:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						fgrid_main.Rows[vRow].AllowEditing = false;
						break;
					case 2:
						CellRange vOutsideRange = fgrid_main.GetCellRange(vRow, (int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN, vRow, (int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN);
                        vOutsideRange.UserData = fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN];

						if(fgrid_main[vRow,(int)TBSBM_MRP_ITEM_LOT.IxSHIP_YN].ToString().StartsWith(ClassLib.ComVar.Yes))
							vRange.StyleNew.BackColor = ClassLib.ComVar.RightBlue;
						else if(fgrid_main[vRow,(int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN].ToString().StartsWith(ClassLib.ComVar.Yes))
							vRange.StyleNew.BackColor = ClassLib.ComVar.RightYellow;
						else
							vRange.StyleNew.BackColor = ClassLib.ComVar.RightPink2;
				
						if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxSTATUS]).Equals("S"))
						{
							fgrid_main.Rows[vRow].AllowEditing = true;
						}
						else if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxSTATUS]).Equals(""))
						{
							fgrid_main.Rows[vRow].AllowEditing = true;
						}
						else
						{
							fgrid_main.Rows[vRow].AllowEditing = false;
						}
						break;
				}
			}
		}

		// get lot no, lot seq, style, ship ymd
		private string Etc_GetLotNo(int arg_row)
		{
			if (fgrid_main[arg_row, _lotInfoCol] != null)
			{
				return fgrid_main[arg_row, _lotInfoCol].ToString().Split('-')[0];
					
			}
			else
				return "";
		}

		private string Etc_GetLotSeq(int arg_row)
		{
			if (fgrid_main[arg_row, _lotInfoCol] != null)
			{
				return fgrid_main[arg_row, _lotInfoCol].ToString().Split('-')[1];
					
			}
			else
				return "";
		}

		private string Etc_GetStyleCode(int arg_row)
		{
			if (fgrid_main[arg_row, _lotInfoCol] != null)
			{
				return fgrid_main[arg_row, _styleCodeCol].ToString().Replace("-", "");
					
			}
			else
				return "";
		}

		private string Etc_GetShipYMD(int arg_row)
		{
			return fgrid_main[arg_row, _mrpShipNoCol].ToString().Substring(4);
		}

		#endregion

		#region Validate Check

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			try
			{
				// 공통 체크
				if (cmb_factory.SelectedIndex == -1)
				{
					ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					cmb_factory.Focus();
					return false;
				}

				if (cmb_shipType.SelectedIndex == -1)
				{
					ClassLib.ComFunction.User_Message("Select Ship Type", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					cmb_shipType.Focus();
					return false;
				}

				if (cmb_mrpno.SelectedIndex == -1)
				{
					ClassLib.ComFunction.User_Message("Select MRP Ship No", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					cmb_mrpno.Focus();
					return false;
				}
				
				// 부분별 체크 (Search, Save, Delete, Confirm..)
				switch (arg_type)
				{
					case ClassLib.ComVar.Validate_Search:

						break;
					case ClassLib.ComVar.Validate_Save:
						if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
						{
							ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}

						for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
						{
							if (fgrid_main.Rows[vRow].Node.Level == 2)
							{
								if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol]).StartsWith("Y") &&
									ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol + 2]).StartsWith("Y"))
								{
									ClassLib.ComFunction.User_Message("Invalidate Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									fgrid_main.Select(vRow, _shipYnCol);
									return false;
								}

								if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol]).Equals(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol + 2])) &&
									ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol + 1]).StartsWith("N") &&
									!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _confirmQtyCol]).Equals("0"))
								{
									ClassLib.ComFunction.User_Message("Invalidate Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									fgrid_main.Select(vRow, _shipYnCol);
									return false;
								}
							}
						}
						break;
					case ClassLib.ComVar.Validate_Delete:

						break;
					case ClassLib.ComVar.Validate_Confirm:
						ClassLib.ComFunction.Essentiality_check(new C1.Win.C1List.C1Combo[]{cmb_factory, cmb_shipType, cmb_mrpno}, null);

						if (fgrid_main.Rows.Fixed >= fgrid_main.Rows.Count)
						{
							ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}

						string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

						if (vTemp.Length > 0)
						{
							ClassLib.ComFunction.User_Message("Exist modify data. ", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
						break;
					case _mnu_value:
						if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
						{
							ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
						if (!(fgrid_main.Col == _shipYnCol || fgrid_main.Col == _shipYnCol + 1 || fgrid_main.Col == _shipYnCol + 2))
						{
							return false;
						}
						break;
					case _insert :
						if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
						{
							ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
						if (cmb_mrpno.SelectedIndex == -1)
						{
							ClassLib.ComFunction.User_Message("Select MRP Ship No", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
						break;
					case _delete :
						if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
						{
							ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
						if (!(ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, (int)TBSBM_MRP_ITEM_LOT.IxPUR_STATUS]).Equals("D") ||
							ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, (int)TBSBM_MRP_ITEM_LOT.IxPUR_STATUS]).Equals("")))
							return false;

						break;
					case _recover :
						if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
						{
							ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
						if (cmb_mrpno.SelectedIndex == -1)
						{
							ClassLib.ComFunction.User_Message("Select MRP Ship No", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
						break;
					case _valid :
						if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
						{
							ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}

						for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
						{
							if (fgrid_main.Rows[vRow].Node.Level == 2)
							{
								if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol]).StartsWith("Y") &&
									ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol + 2]).StartsWith("Y"))
								{
									ClassLib.ComFunction.User_Message("Invalidate Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									fgrid_main.Select(vRow, _shipYnCol);
									return false;
								}

								if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol]).Equals(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol + 2])) &&
									ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol + 1]).StartsWith("N") &&
									!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _confirmQtyCol]).Equals("0"))
								{
									fgrid_main.Select(vRow, _shipYnCol);

									if (ClassLib.ComFunction.User_Message("Change Purchase?", "Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
									{
										fgrid_main[vRow, _shipYnCol + 1] = ClassLib.ComVar.Yes;
									}
								}
							}
						}
						break;
				}

				return true;
			}
			catch
			{
				return false;
			}
		}

		#endregion

		#endregion

		#region DB Connect
	
		/// <summary>
		/// PKG_SBM_MRP_ADJUST : ITEM 리스트 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_MRP_ADVICE_LIST(string pro_name)
		{
	
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(17);

			//01.PROCEDURE명
			MyOraDB.Process_Name = pro_name;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[4] = "ARG_TRANSPORT_TYPE";
			MyOraDB.Parameter_Name[5] = "ARG_STATUS";
			MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[7] = "ARG_ITEM_GROUP";
			MyOraDB.Parameter_Name[8] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[9] = "ARG_SHIP_YN";
			MyOraDB.Parameter_Name[10] = "ARG_ITEM_DIV";
			MyOraDB.Parameter_Name[11] = "ARG_ITEM1";
			MyOraDB.Parameter_Name[12] = "ARG_ITEM2";
			MyOraDB.Parameter_Name[13] = "ARG_OUTSIDE_YN";
			MyOraDB.Parameter_Name[14] = "ARG_LONG_YN";
			MyOraDB.Parameter_Name[15] = "ARG_REQUEST_REASON";
			MyOraDB.Parameter_Name[16] = "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[16] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_mrpno, "");
			MyOraDB.Parameter_Values[2] = txt_lotno.Text.ToUpper();
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_trantype, " ");
			MyOraDB.Parameter_Values[5] = "";
			MyOraDB.Parameter_Values[6] = txt_styleCd.Text.Replace("-","");
			MyOraDB.Parameter_Values[7] = _itemGroupCode;
			MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_Combo(cmb_obstype, "");
			MyOraDB.Parameter_Values[9] = COM.ComFunction.Empty_Combo(cmb_shipyn, "");
			MyOraDB.Parameter_Values[10] = COM.ComFunction.Empty_Combo(cmb_itemDiv, "");
			MyOraDB.Parameter_Values[11] = txt_itemCode.Text;
			MyOraDB.Parameter_Values[12] = txt_itemName.Text.ToUpper();
			MyOraDB.Parameter_Values[13] = COM.ComFunction.Empty_Combo(cmb_outsideyn, "");
			MyOraDB.Parameter_Values[14] = COM.ComFunction.Empty_Combo(cmb_longyn, "");
			MyOraDB.Parameter_Values[15] = COM.ComFunction.Empty_Combo(cmb_reqReason, "");
			MyOraDB.Parameter_Values[16] = "";
			

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBM_MRP_ADJUST : 
		/// </summary>
		public bool SAVE_SBM_MRP_ADJUST_CONFIRM()
		{
			try
			{

				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_MRP_ADJUST.SAVE_SBM_MRP_ADJUST_CONFIRM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values = new string[4];
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_mrpno, "");
				MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() != null)
					return true;
				else
					return false;
			}
			catch
			{
				return false;
			}
		}


		/// <summary>
		/// PKG_SBM_MRP_ITEM : MRP REQUEST 저장하기
		/// </summary>
		public bool SAVE_SBM_MRP_ITEM()
		{
			try
			{

				MyOraDB.ReDim_Parameter(32);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_MRP_ITEM.SAVE_SBM_MRP_ITEM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_LEVEL";
				MyOraDB.Parameter_Name[4] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[5] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[6] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[7] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[8] = "ARG_STYLE_NAME";
				MyOraDB.Parameter_Name[9] = "ARG_UNIT";
				MyOraDB.Parameter_Name[10] = "ARG_PLAN_QTY";
				MyOraDB.Parameter_Name[11] = "ARG_SHIP_QTY";
				MyOraDB.Parameter_Name[12] = "ARG_CONFIRM_QTY";
				MyOraDB.Parameter_Name[13] = "ARG_PK_QTY";
				MyOraDB.Parameter_Name[14] = "ARG_SHIP_YN";
				MyOraDB.Parameter_Name[15] = "ARG_PURCHASE_YN";
				MyOraDB.Parameter_Name[16] = "ARG_ORIGINAL_OUTSIDE";
				MyOraDB.Parameter_Name[17] = "ARG_OUT_SIDE_YN";
				MyOraDB.Parameter_Name[18] = "ARG_STYLE_ITEM_DIV";
				MyOraDB.Parameter_Name[19] = "ARG_TRANSPORT_TYPE";
				MyOraDB.Parameter_Name[20] = "ARG_ATTRIBUTE";
				MyOraDB.Parameter_Name[21] = "ARG_SEND_CHK";
				MyOraDB.Parameter_Name[22] = "ARG_SEND_YMD";
				MyOraDB.Parameter_Name[23] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[24] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[25] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[26] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[27] = "ARG_STATUS";
				MyOraDB.Parameter_Name[28] = "ARG_USER";
				MyOraDB.Parameter_Name[29] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[30] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[31] = "ARG_PO_NO";

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
				MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[22] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[23] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[24] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[25] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[26] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[27] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[28] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[29] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[30] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[31] = (int)OracleType.VarChar;

				// 04.DATA 정의
				ArrayList vList = new ArrayList();

				// 데이터 삽입
				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (fgrid_main.Rows[vRow].Node.Level == 2)
					{
						if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]).Equals(""))
						{
							int vParentRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

							vList.Add(fgrid_main[vRow, 0].ToString());
							vList.Add(COM.ComFunction.Empty_Combo(cmb_factory, ""));
							vList.Add(COM.ComFunction.Empty_Combo(cmb_shipType, ""));
							vList.Add("2");
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxMRP_SHIP_NO]));

							int vIdx = ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, (int)TBSBM_MRP_ITEM_LOT.IxITEM_NAME]).IndexOf("-");
							string vLotNo = ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, (int)TBSBM_MRP_ITEM_LOT.IxITEM_NAME]).Substring(0, vIdx);
							string vLotSeq = ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, (int)TBSBM_MRP_ITEM_LOT.IxITEM_NAME]).Substring(vIdx + 1);

							vList.Add(vLotNo);
							vList.Add(vLotSeq);
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, (int)TBSBM_MRP_ITEM_LOT.IxSPEC_NAME]).Replace("-", ""));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, (int)TBSBM_MRP_ITEM_LOT.IxCOLOR_NAME]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxUNIT]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, (int)TBSBM_MRP_ITEM_LOT.IxPLAN_QTY]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, (int)TBSBM_MRP_ITEM_LOT.IxSHIP_QTY]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxCONFIRM_QTY]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxPK_QTY]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxSHIP_YN]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxPURCHASE_YN]));
							
							CellRange vOutsideRange = fgrid_main.GetCellRange(vRow, (int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN, vRow, (int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN);
							vList.Add(ClassLib.ComFunction.NullCheck(vOutsideRange.UserData, ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN])));

							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN]));
							
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxSTYLE_ITEM_DIV]));
							vList.Add(COM.ComFunction.Empty_Combo(cmb_trantype, ""));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxATTRIBUTE]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxSEND_CHK]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxSEND_YMD]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxREMARKS]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxITEM_CD]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxSPEC_CD]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxCOLOR_CD]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxSTATUS]));
							vList.Add(COM.ComVar.This_User);
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxOBS_ID]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxOBS_TYPE]));
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxPO_NO]));
						}
					}
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;

				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBM_MRP_ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		/// <summary>
		/// PKG_SBM_MRP_ITEM : 
		/// </summary>
		public bool SAVE_SBM_MRP_ITEM_CONFIRM()
		{
			try
			{
				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_MRP_ITEM.SAVE_SBM_MRP_ITEM_CONFIRM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_mrpno, "");
				MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() != null)
					return true;

				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Confirm",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return false;
			}
		}

		#endregion	

		#region 이벤트_버튼 프린트i

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			SetPrintYield();
		}

		private void  SetPrintYield()
		{
			try
			{   
	
						 
				string mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_BM_MRP_List.mrd" ;
				string Para         = " ";
				if(cmb_search.SelectedValue.ToString() =="1")
				{
					mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_BM_MRP_List1.mrd" ;
				}
				else
				{
					mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_BM_MRP_List.mrd" ;
				}
				#region 출력조건

				int  iCnt  = 21;
				string [] aHead =  new string[iCnt];	
				aHead[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				aHead[1] = COM.ComFunction.Empty_Combo(cmb_mrpno, "");
				aHead[2] = txt_lotno.Text.ToUpper();
				aHead[3] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				aHead[4] = COM.ComFunction.Empty_Combo(cmb_trantype, "");
				aHead[5] = txt_status.Text;
				aHead[6] = txt_styleCd.Text;
				aHead[7] = COM.ComFunction.Empty_Combo(cmb_itemGroup, "");
				aHead[8] = COM.ComFunction.Empty_Combo(cmb_obstype, "");
				aHead[9] = COM.ComFunction.Empty_Combo(cmb_shipyn, "");
				aHead[10] = COM.ComFunction.Empty_Combo(cmb_itemDiv, "");
				aHead[11] = txt_itemCode.Text;
				aHead[12] = txt_itemName.Text.ToUpper();
				aHead[13] = COM.ComFunction.Empty_Combo(cmb_outsideyn, "");
				aHead[14] = COM.ComFunction.Empty_Combo(cmb_longyn, "");
				aHead[15] = COM.ComFunction.Empty_Combo(cmb_reqReason, "");
				aHead[16] = cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1);
				aHead[17] = cmb_trantype.GetItemText(cmb_trantype.SelectedIndex, 1);
				aHead[18] = cmb_itemGroup.GetItemText(cmb_itemGroup.SelectedIndex, 1);
				aHead[19] = cmb_obstype.GetItemText(cmb_obstype.SelectedIndex, 1);
				aHead[20] = cmb_reqReason.GetItemText(cmb_reqReason.SelectedIndex, 1);
				
			
				#endregion
	
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
	
				FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
				report.Show();	

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}
		
		#endregion 


		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			int vRow = fgrid_main.Row;


			if(cmb_search.SelectedValue.ToString()=="1")
			{
				Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent);
			
				if (vNode == null)	return;

				int vParentRow = vNode.Row.Index;

				COM.ComVar.Parameter_PopUp		= new string[15];
				COM.ComVar.Parameter_PopUp[0]	= COM.ComFunction.Empty_Combo(cmb_factory, "");
				COM.ComVar.Parameter_PopUp[1]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _styleCodeCol]);
				COM.ComVar.Parameter_PopUp[2]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _styleNameCol]);
				COM.ComVar.Parameter_PopUp[3]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _itemNameCol]);
				COM.ComVar.Parameter_PopUp[4]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _specNameCol]);
				COM.ComVar.Parameter_PopUp[5]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _colorNameCol]);
				COM.ComVar.Parameter_PopUp[6]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _confirmQtyCol]);

				COM.ComVar.Parameter_PopUp[7]	= COM.ComFunction.Empty_Combo(cmb_shipType, "");
				COM.ComVar.Parameter_PopUp[8]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _mrpShipNoCol]);

				int vIdx = ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _lotInfoCol]).IndexOf("-");
				string vLotNo = ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, (int)TBSBM_MRP_ITEM_LOT.IxITEM_NAME]).Substring(0, vIdx);
				string vLotSeq = ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, (int)TBSBM_MRP_ITEM_LOT.IxITEM_NAME]).Substring(vIdx + 1);

				COM.ComVar.Parameter_PopUp[9]	= vLotNo;
				COM.ComVar.Parameter_PopUp[10]	= vLotSeq;
				COM.ComVar.Parameter_PopUp[11]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _itemCodeCol]);
				COM.ComVar.Parameter_PopUp[12]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _specCodeCol]);
				COM.ComVar.Parameter_PopUp[13]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _colorCodeCol]);
				COM.ComVar.Parameter_PopUp[14]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxOBS_TYPE]);

				Pop_BM_MRP_Adjust_Usage_Check vPop = new Pop_BM_MRP_Adjust_Usage_Check();
				vPop.ShowDialog();
			}
			else
			{
				Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent);
			
				if (vNode == null)	return;

				int vParentRow = vNode.Row.Index;

				COM.ComVar.Parameter_PopUp		= new string[15];
				COM.ComVar.Parameter_PopUp[0]	= COM.ComFunction.Empty_Combo(cmb_factory, "");
				COM.ComVar.Parameter_PopUp[1]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _styleCodeCol]);
				COM.ComVar.Parameter_PopUp[2]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _styleNameCol]);
				COM.ComVar.Parameter_PopUp[3]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _itemNameCol]);
				COM.ComVar.Parameter_PopUp[4]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _specNameCol]);
				COM.ComVar.Parameter_PopUp[5]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _colorNameCol]);
				COM.ComVar.Parameter_PopUp[6]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _confirmQtyCol]);

				COM.ComVar.Parameter_PopUp[7]	= COM.ComFunction.Empty_Combo(cmb_shipType, "");
				COM.ComVar.Parameter_PopUp[8]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _mrpShipNoCol]);

				int vIdx = ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _lotInfoCol]).IndexOf("-");
				string vLotNo = ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, (int)TBSBM_MRP_ITEM_LOT.IxITEM_NAME]).Substring(0, vIdx);
				string vLotSeq = ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, (int)TBSBM_MRP_ITEM_LOT.IxITEM_NAME]).Substring(vIdx + 1);

				COM.ComVar.Parameter_PopUp[9]	= vLotNo;
				COM.ComVar.Parameter_PopUp[10]	= vLotSeq;
				COM.ComVar.Parameter_PopUp[11]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _itemCodeCol]);
				COM.ComVar.Parameter_PopUp[12]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _specCodeCol]);
				COM.ComVar.Parameter_PopUp[13]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _colorCodeCol]);
				COM.ComVar.Parameter_PopUp[14]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxOBS_TYPE]);

				Pop_BM_MRP_Adjust_Usage_Check vPop = new Pop_BM_MRP_Adjust_Usage_Check();
				vPop.ShowDialog();
			}
		}

		private void cmb_search_TextChanged(object sender, System.EventArgs e)
		{
			if(cmb_search.SelectedValue.ToString() == "2")
			{
				fgrid_main.Set_Grid("SBM_MRP_ITEM_LOT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				btn_Tree.Enabled	= true;
				btn_Insert.Enabled	= true;
				btn_Delete.Enabled	= true;
				btn_Recover.Enabled	= true;
				
			}
			else
			{
				fgrid_main.Set_Grid("SBM_MRP_REQUEST_ITEM", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				btn_Tree.Enabled	= false;
				btn_Insert.Enabled	= false;
				btn_Delete.Enabled	= false;
				btn_Recover.Enabled	= false;
			}

			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);
			Grid_SetFormat();
		}

		private void cmb_style_TextChanged(object sender, System.EventArgs e)
		{
			if(cmb_style.SelectedIndex !=0)
			{
				txt_styleCd.Text = cmb_style.SelectedValue.ToString();
			}
		}

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{

			if (Etc_ProvisoValidateCheck(_insert))
				Btn_InsertProcess();
		}

		private void Btn_InsertProcess()
		{
			try
			{
				FlexBase.MaterialBase.Pop_Item_List vPopup = new FlexBase.MaterialBase.Pop_Item_List();
				vPopup.ShowDialog();	

				if(!ClassLib.ComVar.Parameter_PopUp[0].Trim().Equals(""))
				{
					int vErrorRow = CheckDuplicate();

					if (vErrorRow != 0)
					{
						ClassLib.ComFunction.User_Message("Row " + (vErrorRow - fgrid_main.Rows.Fixed) + " : Exist Duplicate Data", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}					
					
					int vRow = fgrid_main.Row;

					if (fgrid_main.Rows[fgrid_main.Row].Node.Level == 2)
						vRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

					int vInsertRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.LastChild).Row.Index+1;

					C1.Win.C1FlexGrid.Node newRow				= fgrid_main.Rows.InsertNode(vInsertRow, 2);

					int vSibling = fgrid_main.Rows[vInsertRow].Node.GetNode(NodeTypeEnum.PreviousSibling).Row.Index;

					for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
						fgrid_main[vInsertRow, vCol] = fgrid_main[vSibling, vCol];
	
					fgrid_main[newRow.Row.Index, _itemNameCol]	= ClassLib.ComVar.Parameter_PopUp[1];
					fgrid_main[newRow.Row.Index, _specNameCol]	= ClassLib.ComVar.Parameter_PopUp[3];
					fgrid_main[newRow.Row.Index, _colorNameCol]	= ClassLib.ComVar.Parameter_PopUp[5];

					fgrid_main[newRow.Row.Index, _itemCodeCol]	= ClassLib.ComVar.Parameter_PopUp[0];
					fgrid_main[newRow.Row.Index, _specCodeCol]	= ClassLib.ComVar.Parameter_PopUp[2];
					fgrid_main[newRow.Row.Index, _colorCodeCol]	= ClassLib.ComVar.Parameter_PopUp[4];

					fgrid_main[newRow.Row.Index, _confirmQtyCol] = 0;
					fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxADVICE_QTY] = 0;
					fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxUSAGE_QTY] = 0;
					fgrid_main[newRow.Row.Index, _unitCol]		= ClassLib.ComVar.Parameter_PopUp[6];
					fgrid_main[newRow.Row.Index, _pkQtyCol]		= ClassLib.ComVar.Parameter_PopUp[8];

					fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxUSER] = COM.ComVar.This_User;
					fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxSHIP_YN] = ClassLib.ComVar.Yes;
					fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxPURCHASE_YN] = ClassLib.ComVar.Yes;
					fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN] = ClassLib.ComVar.No;
				
					fgrid_main.Select(newRow.Row.Index, _confirmQtyCol);
					fgrid_main.Rows[newRow.Row.Index].StyleNew.BackColor = Color.White;
					fgrid_main[newRow.Row.Index, 0] = ClassLib.ComVar.Insert;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Btn_InsertProcess",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}
		}

		private int CheckDuplicate()
		{
			int vReturn = 0;

			int vRow = fgrid_main.Row;

			if (fgrid_main.Rows[fgrid_main.Row].Node.Level == 2)
				vRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

			string[] vData = new string[]{COM.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory),
											 COM.ComFunction.Empty_Combo(cmb_shipType, ""),
											 COM.ComFunction.Empty_Combo(cmb_mrpno, ""),
											 ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lotInfoCol]).Substring(0, 9),
											 ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lotInfoCol]).Substring(10, 2),
											 ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _styleCodeCol]),
											 ClassLib.ComVar.Parameter_PopUp[0],
											 ClassLib.ComVar.Parameter_PopUp[2],
											 ClassLib.ComVar.Parameter_PopUp[4]};

			if (ClassLib.ComFunction.SELECT_SBM_MRP_ITEM_SEARCH(vData))
			{
				string vMessage = "The selected item is already exists!!";

				vReturn = 1;
				MessageBox.Show(this, vMessage, "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			return vReturn;
		}

		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_delete))
				if (MessageBox.Show(this, "Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					Btn_DeleteProcess();
		}

		private void Btn_DeleteProcess()
		{
			try
			{
				if (fgrid_main.Rows[fgrid_main.Row].Node.Level == 2)
				{
					fgrid_main.Delete_Row();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_DeleteProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Recover_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_recover))
				if (MessageBox.Show(this, "Do you want to recover?", "Recover", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					fgrid_main.Recover_Row();
		}

		private void btn_Tree_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_insert))
				Show_Tree_Popup();
		}

		/// <summary>
		/// Show_Tree_Popup : 데이터 입력하는 팝업을 Tree로 실행
		/// </summary>
		private void Show_Tree_Popup()
		{
			try
			{
				if(fgrid_main[fgrid_main.Row,1].ToString() == "2")
				{
					_vparent = fgrid_main.Rows[fgrid_main.Row].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
				}
				else
				{
					_vparent=fgrid_main.Row;
				}

				_vstyle_cd = fgrid_main[_vparent,_styleCodeCol].ToString();
				string lot_no = fgrid_main[_vparent,_lotInfoCol].ToString();

				if(lot_no.Equals("")) 
				{
					MessageBox.Show("Select Lot No!!");
					return;
				}
		
				int vIdx = ClassLib.ComFunction.NullToBlank(lot_no).IndexOf("-");
				_vlot_no = ClassLib.ComFunction.NullToBlank(fgrid_main[_vparent, (int)TBSBM_MRP_ITEM_LOT.IxITEM_NAME]).Substring(0, vIdx);
				_vlot_seq = ClassLib.ComFunction.NullToBlank(fgrid_main[_vparent, (int)TBSBM_MRP_ITEM_LOT.IxITEM_NAME]).Substring(vIdx + 1);

				int[] vChecks = new int[]{_styleCodeCol, _itemCodeCol, _specCodeCol, _colorCodeCol};

				ClassLib.ComVar.Parameter_PopUp = new string[]{COM.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory), 
																  "M", 
																  COM.ComFunction.Empty_Combo(cmb_shipType, ""),
																  COM.ComFunction.Empty_Combo(cmb_mrpno, ""),
																  _vlot_no, _vlot_seq};

				_duplicateData.Clear();

				FlexBase.MaterialBase.Pop_BC_Yield_Info vPop = new FlexBase.MaterialBase.Pop_BC_Yield_Info(fgrid_main, vChecks);
				vPop._style = _vstyle_cd.Trim().Replace("_", "");

				vPop.ShowDialog();

				if ( ClassLib.ComVar.Parameter_PopUpTable.Rows.Count > 0 && vPop.DialogResult == DialogResult.OK)
				{
					_duplicateData = vPop._duplicate;
					Etc_SizeCalculation();
				}

				vPop.Dispose();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Etc_SizeCalculation()
		{
			try
			{
				// pop_up   의 내용을 SBT_TEMP_ITEM 에 저장
				bool vBoolTemp = SAVE_SBT_TEMP_ITEM();

				if(vBoolTemp == true)
				{
					if (MyOraDB.Exe_Modify_Procedure() != null)
					{
						// 소요량 조회하는 프로시져 호출
						DataTable vDt = SELECT_SBT_TEMP_ITEM(cmb_factory.SelectedValue.ToString(),  COM.ComVar.This_User);

						if (vDt.Rows.Count > 0)
						{
							for(int i = 0 ; i < vDt.Rows.Count ; i++)
							{
								InsertItem(vDt.Rows[i]);
							}
						}
						else
							vDt.Dispose();
					}
				}

				//_practicable = true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				ClassLib.ComVar.Parameter_PopUpTable.Dispose();
			}
		}


		private void InsertItem(DataRow arg_row)
		{
			try
			{
				int vRow = fgrid_main.Row;

				if (fgrid_main.Rows[fgrid_main.Row].Node.Level == 2)
					vRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

				int vInsertRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.LastChild).Row.Index+1;

				C1.Win.C1FlexGrid.Node newRow				= fgrid_main.Rows.InsertNode(vInsertRow, 2);

				int vSibling = fgrid_main.Rows[vInsertRow].Node.GetNode(NodeTypeEnum.PreviousSibling).Row.Index;

				for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
					fgrid_main[vInsertRow, vCol] = fgrid_main[vSibling, vCol];
	
				fgrid_main[newRow.Row.Index, _itemNameCol]	= arg_row[1];
				fgrid_main[newRow.Row.Index, _specNameCol]	= arg_row[3];
				fgrid_main[newRow.Row.Index, _colorNameCol]	= arg_row[5];

				fgrid_main[newRow.Row.Index, _itemCodeCol]	= arg_row[0];
				fgrid_main[newRow.Row.Index, _specCodeCol]	= arg_row[2];
				fgrid_main[newRow.Row.Index, _colorCodeCol]	= arg_row[4];

				fgrid_main[newRow.Row.Index, _confirmQtyCol] = arg_row[6];
				fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxADVICE_QTY] = arg_row[6];
				fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxUSAGE_QTY] = arg_row[6];

				fgrid_main[newRow.Row.Index, _unitCol]		= arg_row[9];
				fgrid_main[newRow.Row.Index, _pkQtyCol]		= arg_row[11];

				fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxUSER] = COM.ComVar.This_User;
				fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxSHIP_YN] = ClassLib.ComVar.Yes;
				fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxPURCHASE_YN] = ClassLib.ComVar.Yes;
				fgrid_main[newRow.Row.Index, (int)TBSBM_MRP_ITEM_LOT.IxOUT_SIDE_YN] = ClassLib.ComVar.No;
				
				fgrid_main.Select(newRow.Row.Index, _confirmQtyCol);
				fgrid_main.Rows[newRow.Row.Index].StyleNew.BackColor = Color.White;
				fgrid_main[newRow.Row.Index, 0] = ClassLib.ComVar.Insert;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_FlexGrid_Tree_Add",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}
		}

		/// <summary>
		/// PKG_SBT_TEMP_ITEM :  SELECT_SBT_TEMP_ITEM
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_req_no">청구번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBT_TEMP_ITEM(string arg_factory, string arg_action_user)
		{
			// SELECT_SBS_SHIPPING_SIZE_LIST 참고
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBT_TEMP_ITEM.SELECT_SBT_TEMP_ITEM_ORDER";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_ACTION_USER";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_action_user;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		public bool SAVE_SBT_TEMP_ITEM()
		{
			try
			{
				if(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][8].ToString() != _vstyle_cd.Replace("-",""))
				{
					MessageBox.Show("No Match Style CD !! ");
					return false;
				}

				MyOraDB.ReDim_Parameter(11);

				//01.PROCEDURE명
				MyOraDB.Process_Name    = "Pkg_Sbm_Mrp_SEARCH.SAVE_SBT_TEMP";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_ACTION_USER";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
				MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[5] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[6] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[8] = "ARG_SHIP_NO";
				MyOraDB.Parameter_Name[9] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[10] = "ARG_LOT_SEQ";

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
				MyOraDB.Parameter_Type[10]  = (int)OracleType.VarChar;


				//04.DATA 정의
				ArrayList vList = new ArrayList();
				vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][7].ToString());
				vList.Add(COM.ComVar.This_User);
				vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][8].ToString());
				vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][9].ToString());
				vList.Add(ClassLib.ComVar.Delete);
				vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][2].ToString());
				vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][4].ToString());
				vList.Add(COM.ComVar.This_User);
				vList.Add(COM.ComFunction.Empty_Combo(cmb_mrpno, ""));
				vList.Add(_vlot_no);
				vList.Add(_vlot_seq);

				for(int i = 0; i < ClassLib.ComVar.Parameter_PopUpTable.Rows.Count ; i++)
				{
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][7].ToString());
					vList.Add(COM.ComVar.This_User);
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][8].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][9].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][0].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][2].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][4].ToString());
					vList.Add(COM.ComVar.This_User);
					vList.Add(COM.ComFunction.Empty_Combo(cmb_mrpno, ""));
					vList.Add(_vlot_no);
					vList.Add(_vlot_seq);
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message, "SAVE_SBT_TEMP_ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}

	}
}

