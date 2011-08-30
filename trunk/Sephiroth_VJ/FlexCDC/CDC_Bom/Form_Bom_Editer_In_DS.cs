using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;
using System.Threading;

namespace FlexCDC.CDC_Bom
{
	public class Form_Bom_Editer_In_DS : COM.PCHWinForm.Form_Top
	{

		#region 컨트롤정의 및 사용자정의 변수


        private bool show_head = true;
        private BaseInfo.Pop_BS_Shipping_List_Wait _pop = null;
        //private bool warning_chk = false; 
        //private string csv_type = "D";//D BOM, E BOM구분

		private COM.OraDB OraDB = new COM.OraDB();
		private COM.ComFunction comfunction = new COM.ComFunction();
		private string dateType = "yyyyMMdd";
        //private char   _CharDiv = '"';
        //private bool show_head = true;
        //private bool color_check = false;
        //private string default_color = "X000";
        //private string default_color_desc = "NA";
        private string _cs_gend = "";

        //private  string  _jobcount ="0";

		//사용자 변수
		//private string _Form_Type = "I";
        //private string save_srno = null;
        //private string _File_Type = null;


		public string _head_factory       = null; 
		public string _head_sr_no         = null; 
		public string _head_srf_no        = null; 
		public string _head_bom_id        = null; 
		public string _head_bom_rev       = null; 

		public string _head_nf_cd         = null;
		public string _head_srf_seq       = null; 
		public string _head_bom_state     = null; 
		public string _head_requestor     = null; 
		public string _head_ord_ymd       = null; 

		public string _head_need_by       = null; 
		public string _head_ets           = null;
		public string _head_mo_alias      = null;
		public string _head_whq_plm       = null; 
		public string _head_whq_dev       = null; 

		public string _head_nlo_dev       = null; 
		public string _head_silhouette    = null; 
		public string _head_technology    = null;
		public string _head_lasting_method     = null; 
		public string _head_ms_method          = null; 

		public string _head_sole_laying_method = null; 
		public string _head_mto_account_name   = null; 
		public string _head_bom_comment        = null; 
		public string _head_factory_dv    = null; 
		public string _head_sesn          = null; 

		public string _head_pattern         = null; 

		public string _head_last_cd       = null; 
		public string _head_dev_name      = null; 
		public string _head_mtl_ver       = null; 
		public string _head_color_ver     = null;
		public string _head_sample_types  = null; 

		public string _head_sta           = null; 
		public string _head_current_ipw = null;
		public string _head_product_code =null;
		public string _head_pur_flg       = null; 
		public string _head_style_cd      = null;

		public string _head_remarks       = null;
		public string _head_status        = null;
		public string _head_load_upd_user = null;
		public string _head_load_upd_ymd = null;
		public string _head_upd_user = null;

		public string _head_upd_ymd = null;


		public string _head_size = null;
		public string _head_gender = null;



        public string _head_dm_bom_flg = null;
        public string _head_prod_ext_color = null;
        public string _head_pcc_factory = null;
        public string _head_ss_factory = null;
        public string _head_p_prod_factory = null;
        public string _head_s_prod_factory = null;



		public int _RowFixed_detali;
		private int _RowFixed_order;
        //private int _RowFixed_desc;
		private int _RowFixed_vendor;

        //private string spec_cd = null;
        //private string spec_name = null;
        //private string unit_value = null;


		private System.Windows.Forms.ImageList 
			img_MiniButton;
		public System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txt_bomrev;
		private System.Windows.Forms.TextBox txt_bomid;
        private System.Windows.Forms.Label lbl_bom;
		private System.Windows.Forms.Label lbl_srfpath;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.Label lbl_srf_info;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		public System.Windows.Forms.PictureBox pictureBox17;
		private System.ComponentModel.IContainer components = null;




		
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.TextBox txt_srfno;
		private System.Windows.Forms.Label lbl_srfno;
		private System.Windows.Forms.TextBox txt_srno;
		private System.Windows.Forms.Label lbl_srno;
		public C1.Win.C1List.C1Combo cmb_level;
		private C1.Win.C1List.C1Combo cmb_sampletypes;
		private System.Windows.Forms.Label lbl_sampletypes;
		private System.Windows.Forms.TextBox txt_model_name;
		private System.Windows.Forms.Label lbl_model_name;
		private System.Windows.Forms.TextBox txt_mo_id;
		private System.Windows.Forms.Label lbl_mo_id;
		private System.Windows.Forms.TextBox txt_factory_direct;
		private System.Windows.Forms.Label lbl_factory_direct;
		private System.Windows.Forms.TextBox txt_state;
		private System.Windows.Forms.Label lbl_state;
		private System.Windows.Forms.Label lbl_requestor;
		private System.Windows.Forms.TextBox txt_requestor;
		private System.Windows.Forms.Label lbl_order_date;
		private System.Windows.Forms.DateTimePicker txt_order_date;
		private System.Windows.Forms.Label lbl_ets;
		private System.Windows.Forms.DateTimePicker txt_ets;
		private System.Windows.Forms.Label lbl_need_by;
		private System.Windows.Forms.TextBox txt_style_cd;
		private System.Windows.Forms.DateTimePicker txt_need_by;
		private System.Windows.Forms.Label lbl_patten;
		private System.Windows.Forms.TextBox txt_patten;
		public System.Windows.Forms.Panel lbl_sampletype;
		private System.Windows.Forms.Label lbl_silhouette;
		private System.Windows.Forms.Label lbl_lasting_method;
		private System.Windows.Forms.Label lbl_model_name_bom;
		private System.Windows.Forms.Label lbl_technology;
		private System.Windows.Forms.Label lbl_bom_state;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_title;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.PictureBox pictureBox27;
		public System.Windows.Forms.PictureBox pictureBox28;
		public System.Windows.Forms.PictureBox pictureBox29;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.PictureBox pictureBox30;
		public System.Windows.Forms.PictureBox pictureBox31;
		public System.Windows.Forms.PictureBox pictureBox32;
		public System.Windows.Forms.PictureBox pictureBox33;
		public System.Windows.Forms.PictureBox pictureBox34;
		public System.Windows.Forms.PictureBox pictureBox35;
		public System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label10;
		public System.Windows.Forms.PictureBox pictureBox18;
		public System.Windows.Forms.PictureBox pictureBox19;
		public System.Windows.Forms.PictureBox pictureBox20;
		public System.Windows.Forms.Label label11;
		public System.Windows.Forms.PictureBox pictureBox21;
		public System.Windows.Forms.PictureBox pictureBox22;
		public System.Windows.Forms.PictureBox pictureBox23;
		public System.Windows.Forms.PictureBox pictureBox24;
		public System.Windows.Forms.PictureBox pictureBox25;
		public System.Windows.Forms.PictureBox pictureBox26;
		private System.Windows.Forms.Label lbl_product_code;
		private System.Windows.Forms.Label lbl_mo_alias;
		private System.Windows.Forms.Label lbl_season;
		private System.Windows.Forms.TextBox txt_mtl_ver;
		private System.Windows.Forms.TextBox txt_nlo_dev;
		private System.Windows.Forms.Label lbl_nlo_dev;
		private System.Windows.Forms.Label lbl_whq_dev;
		private System.Windows.Forms.TextBox txt_whq_plm;
		private System.Windows.Forms.Label lbl_whq_plm;
		private System.Windows.Forms.TextBox txt_whq_dev;
		private System.Windows.Forms.TextBox txt_model_name_bom;
		private System.Windows.Forms.TextBox txt_ms_method;
		private System.Windows.Forms.TextBox txt_product_code;
		private System.Windows.Forms.Label lbl_current_ipw;
		private System.Windows.Forms.TextBox txt_lasting_method;
		private System.Windows.Forms.TextBox txt_colo_ver;
		private System.Windows.Forms.TextBox txt_silhouette;
		private System.Windows.Forms.Label lbl_colo_ver;
		private System.Windows.Forms.Label lbl_mtl_ver;
		private System.Windows.Forms.Label lbl_ms_method;
		private System.Windows.Forms.Label lbl_bom_comments;
		private System.Windows.Forms.TextBox txt_bom_state;
		private System.Windows.Forms.TextBox txt_bom_comments;
		private System.Windows.Forms.TextBox txt_season;
		private System.Windows.Forms.TextBox txt_technology;
		private System.Windows.Forms.TextBox txt_sole_laying_method;
		private System.Windows.Forms.Label lbl_last_cd;
		private System.Windows.Forms.TextBox txt_last_cd;
		private System.Windows.Forms.TextBox txt_mto_account_name;
		private System.Windows.Forms.TextBox txt_mo_alias;
		private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage srf_tail;
		public COM.FSP fgrid_detail;
		private System.Windows.Forms.TabPage srf_order;
		private COM.FSP fgrid_order;
		private System.Windows.Forms.TabPage srf_vendor;
		private System.Windows.Forms.Label lbl_gender;
		private C1.Win.C1List.C1Combo cmb_gender;
		private System.Windows.Forms.Label lbl_mto_account;
        private System.Windows.Forms.Label lbl_sole_laying_me;
		private COM.FSP fgrid_round;
		private System.Windows.Forms.Label lbl_level;
		private System.Windows.Forms.Label lbl_Style_Cd;
        private System.Windows.Forms.DateTimePicker txt_current_ipw;


		//private bool new_nf_cd = false;
		

		public Form_Bom_Editer_In_DS()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		public Form_Bom_Editer_In_DS(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			//_Form_Type = arg_form_mode;
			_head_factory = arg_factory;
			_head_sr_no = arg_sr_no;
			_head_srf_no = arg_srf_no;
			_head_bom_id = arg_bom_id;
			_head_bom_rev = arg_bom_rev;
			_head_nf_cd = arg_nf_cd;



			
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bom_Editer_In_DS));
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
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Style_Cd = new System.Windows.Forms.Label();
            this.cmb_gender = new C1.Win.C1List.C1Combo();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txt_patten = new System.Windows.Forms.TextBox();
            this.lbl_patten = new System.Windows.Forms.Label();
            this.txt_style_cd = new System.Windows.Forms.TextBox();
            this.lbl_need_by = new System.Windows.Forms.Label();
            this.txt_need_by = new System.Windows.Forms.DateTimePicker();
            this.lbl_ets = new System.Windows.Forms.Label();
            this.txt_ets = new System.Windows.Forms.DateTimePicker();
            this.lbl_order_date = new System.Windows.Forms.Label();
            this.txt_order_date = new System.Windows.Forms.DateTimePicker();
            this.txt_requestor = new System.Windows.Forms.TextBox();
            this.lbl_requestor = new System.Windows.Forms.Label();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.txt_factory_direct = new System.Windows.Forms.TextBox();
            this.lbl_factory_direct = new System.Windows.Forms.Label();
            this.txt_mo_id = new System.Windows.Forms.TextBox();
            this.lbl_mo_id = new System.Windows.Forms.Label();
            this.txt_model_name = new System.Windows.Forms.TextBox();
            this.lbl_model_name = new System.Windows.Forms.Label();
            this.cmb_sampletypes = new C1.Win.C1List.C1Combo();
            this.lbl_sampletypes = new System.Windows.Forms.Label();
            this.cmb_level = new C1.Win.C1List.C1Combo();
            this.lbl_level = new System.Windows.Forms.Label();
            this.txt_srno = new System.Windows.Forms.TextBox();
            this.lbl_srno = new System.Windows.Forms.Label();
            this.txt_srfno = new System.Windows.Forms.TextBox();
            this.lbl_srfno = new System.Windows.Forms.Label();
            this.txt_bomrev = new System.Windows.Forms.TextBox();
            this.txt_bomid = new System.Windows.Forms.TextBox();
            this.lbl_bom = new System.Windows.Forms.Label();
            this.lbl_srfpath = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lbl_srf_info = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_sampletype = new System.Windows.Forms.Panel();
            this.txt_current_ipw = new System.Windows.Forms.DateTimePicker();
            this.txt_mto_account_name = new System.Windows.Forms.TextBox();
            this.lbl_mto_account = new System.Windows.Forms.Label();
            this.txt_technology = new System.Windows.Forms.TextBox();
            this.txt_sole_laying_method = new System.Windows.Forms.TextBox();
            this.txt_bom_state = new System.Windows.Forms.TextBox();
            this.txt_mtl_ver = new System.Windows.Forms.TextBox();
            this.txt_nlo_dev = new System.Windows.Forms.TextBox();
            this.lbl_nlo_dev = new System.Windows.Forms.Label();
            this.txt_season = new System.Windows.Forms.TextBox();
            this.lbl_whq_dev = new System.Windows.Forms.Label();
            this.txt_whq_plm = new System.Windows.Forms.TextBox();
            this.lbl_whq_plm = new System.Windows.Forms.Label();
            this.txt_mo_alias = new System.Windows.Forms.TextBox();
            this.lbl_season = new System.Windows.Forms.Label();
            this.txt_whq_dev = new System.Windows.Forms.TextBox();
            this.lbl_mo_alias = new System.Windows.Forms.Label();
            this.lbl_product_code = new System.Windows.Forms.Label();
            this.txt_model_name_bom = new System.Windows.Forms.TextBox();
            this.txt_ms_method = new System.Windows.Forms.TextBox();
            this.lbl_last_cd = new System.Windows.Forms.Label();
            this.txt_product_code = new System.Windows.Forms.TextBox();
            this.lbl_current_ipw = new System.Windows.Forms.Label();
            this.txt_lasting_method = new System.Windows.Forms.TextBox();
            this.txt_colo_ver = new System.Windows.Forms.TextBox();
            this.txt_last_cd = new System.Windows.Forms.TextBox();
            this.txt_silhouette = new System.Windows.Forms.TextBox();
            this.lbl_sole_laying_me = new System.Windows.Forms.Label();
            this.lbl_colo_ver = new System.Windows.Forms.Label();
            this.lbl_mtl_ver = new System.Windows.Forms.Label();
            this.lbl_silhouette = new System.Windows.Forms.Label();
            this.lbl_ms_method = new System.Windows.Forms.Label();
            this.lbl_lasting_method = new System.Windows.Forms.Label();
            this.lbl_model_name_bom = new System.Windows.Forms.Label();
            this.lbl_technology = new System.Windows.Forms.Label();
            this.txt_bom_comments = new System.Windows.Forms.TextBox();
            this.lbl_bom_comments = new System.Windows.Forms.Label();
            this.lbl_bom_state = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.btn_openfile = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.srf_tail = new System.Windows.Forms.TabPage();
            this.fgrid_detail = new COM.FSP();
            this.srf_order = new System.Windows.Forms.TabPage();
            this.fgrid_order = new COM.FSP();
            this.srf_vendor = new System.Windows.Forms.TabPage();
            this.fgrid_round = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.lbl_sampletype.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            this.tab_control.SuspendLayout();
            this.srf_tail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_detail)).BeginInit();
            this.srf_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_order)).BeginInit();
            this.srf_vendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_round)).BeginInit();
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
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
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
            this.img_MiniButton.Images.SetKeyName(6, "");
            this.img_MiniButton.Images.SetKeyName(7, "");
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.lbl_Style_Cd);
            this.panel2.Controls.Add(this.cmb_gender);
            this.panel2.Controls.Add(this.lbl_gender);
            this.panel2.Controls.Add(this.txt_patten);
            this.panel2.Controls.Add(this.lbl_patten);
            this.panel2.Controls.Add(this.txt_style_cd);
            this.panel2.Controls.Add(this.lbl_need_by);
            this.panel2.Controls.Add(this.txt_need_by);
            this.panel2.Controls.Add(this.lbl_ets);
            this.panel2.Controls.Add(this.txt_ets);
            this.panel2.Controls.Add(this.lbl_order_date);
            this.panel2.Controls.Add(this.txt_order_date);
            this.panel2.Controls.Add(this.txt_requestor);
            this.panel2.Controls.Add(this.lbl_requestor);
            this.panel2.Controls.Add(this.txt_state);
            this.panel2.Controls.Add(this.lbl_state);
            this.panel2.Controls.Add(this.txt_factory_direct);
            this.panel2.Controls.Add(this.lbl_factory_direct);
            this.panel2.Controls.Add(this.txt_mo_id);
            this.panel2.Controls.Add(this.lbl_mo_id);
            this.panel2.Controls.Add(this.txt_model_name);
            this.panel2.Controls.Add(this.lbl_model_name);
            this.panel2.Controls.Add(this.cmb_sampletypes);
            this.panel2.Controls.Add(this.lbl_sampletypes);
            this.panel2.Controls.Add(this.cmb_level);
            this.panel2.Controls.Add(this.lbl_level);
            this.panel2.Controls.Add(this.txt_srno);
            this.panel2.Controls.Add(this.lbl_srno);
            this.panel2.Controls.Add(this.txt_srfno);
            this.panel2.Controls.Add(this.lbl_srfno);
            this.panel2.Controls.Add(this.txt_bomrev);
            this.panel2.Controls.Add(this.txt_bomid);
            this.panel2.Controls.Add(this.lbl_bom);
            this.panel2.Controls.Add(this.lbl_srfpath);
            this.panel2.Controls.Add(this.cmb_factory);
            this.panel2.Controls.Add(this.lbl_factory);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.panel2.Size = new System.Drawing.Size(1016, 160);
            this.panel2.TabIndex = 135;
            // 
            // lbl_Style_Cd
            // 
            this.lbl_Style_Cd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Style_Cd.ImageIndex = 0;
            this.lbl_Style_Cd.ImageList = this.img_Label;
            this.lbl_Style_Cd.Location = new System.Drawing.Point(248, 127);
            this.lbl_Style_Cd.Name = "lbl_Style_Cd";
            this.lbl_Style_Cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style_Cd.TabIndex = 373;
            this.lbl_Style_Cd.Tag = "23";
            this.lbl_Style_Cd.Text = "Style Code";
            this.lbl_Style_Cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_gender
            // 
            this.cmb_gender.AddItemCols = 0;
            this.cmb_gender.AddItemSeparator = ';';
            this.cmb_gender.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_gender.Caption = "";
            this.cmb_gender.CaptionHeight = 17;
            this.cmb_gender.CaptionStyle = style1;
            this.cmb_gender.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_gender.ColumnCaptionHeight = 18;
            this.cmb_gender.ColumnFooterHeight = 18;
            this.cmb_gender.ContentHeight = 17;
            this.cmb_gender.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_gender.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_gender.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_gender.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_gender.EditorHeight = 17;
            this.cmb_gender.EvenRowStyle = style2;
            this.cmb_gender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_gender.FooterStyle = style3;
            this.cmb_gender.GapHeight = 2;
            this.cmb_gender.HeadingStyle = style4;
            this.cmb_gender.HighLightRowStyle = style5;
            this.cmb_gender.ItemHeight = 15;
            this.cmb_gender.Location = new System.Drawing.Point(581, 127);
            this.cmb_gender.MatchEntryTimeout = ((long)(2000));
            this.cmb_gender.MaxDropDownItems = ((short)(5));
            this.cmb_gender.MaxLength = 32767;
            this.cmb_gender.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.OddRowStyle = style6;
            this.cmb_gender.PartialRightColumn = false;
            this.cmb_gender.PropBag = resources.GetString("cmb_gender.PropBag");
            this.cmb_gender.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_gender.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_gender.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_gender.SelectedStyle = style7;
            this.cmb_gender.Size = new System.Drawing.Size(120, 21);
            this.cmb_gender.Style = style8;
            this.cmb_gender.TabIndex = 372;
            // 
            // lbl_gender
            // 
            this.lbl_gender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ImageIndex = 0;
            this.lbl_gender.ImageList = this.img_Label;
            this.lbl_gender.Location = new System.Drawing.Point(480, 127);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_gender.TabIndex = 370;
            this.lbl_gender.Tag = "21";
            this.lbl_gender.Text = "Gerder";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_patten
            // 
            this.txt_patten.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_patten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patten.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_patten.ForeColor = System.Drawing.Color.Black;
            this.txt_patten.Location = new System.Drawing.Point(117, 127);
            this.txt_patten.MaxLength = 100;
            this.txt_patten.Name = "txt_patten";
            this.txt_patten.ReadOnly = true;
            this.txt_patten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_patten.Size = new System.Drawing.Size(120, 20);
            this.txt_patten.TabIndex = 369;
            // 
            // lbl_patten
            // 
            this.lbl_patten.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patten.ImageIndex = 0;
            this.lbl_patten.ImageList = this.img_Label;
            this.lbl_patten.Location = new System.Drawing.Point(16, 127);
            this.lbl_patten.Name = "lbl_patten";
            this.lbl_patten.Size = new System.Drawing.Size(100, 21);
            this.lbl_patten.TabIndex = 368;
            this.lbl_patten.Tag = "21";
            this.lbl_patten.Text = "Pattern";
            this.lbl_patten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_style_cd
            // 
            this.txt_style_cd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_style_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_style_cd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_style_cd.ForeColor = System.Drawing.Color.Black;
            this.txt_style_cd.Location = new System.Drawing.Point(349, 127);
            this.txt_style_cd.MaxLength = 9;
            this.txt_style_cd.Name = "txt_style_cd";
            this.txt_style_cd.Size = new System.Drawing.Size(120, 21);
            this.txt_style_cd.TabIndex = 367;
            this.txt_style_cd.Tag = "48";
            // 
            // lbl_need_by
            // 
            this.lbl_need_by.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_need_by.ImageIndex = 0;
            this.lbl_need_by.ImageList = this.img_Label;
            this.lbl_need_by.Location = new System.Drawing.Point(480, 105);
            this.lbl_need_by.Name = "lbl_need_by";
            this.lbl_need_by.Size = new System.Drawing.Size(100, 21);
            this.lbl_need_by.TabIndex = 362;
            this.lbl_need_by.Tag = "23";
            this.lbl_need_by.Text = "Need By";
            this.lbl_need_by.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_need_by
            // 
            this.txt_need_by.CustomFormat = "yyyyMMdd";
            this.txt_need_by.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_need_by.Location = new System.Drawing.Point(581, 104);
            this.txt_need_by.Name = "txt_need_by";
            this.txt_need_by.Size = new System.Drawing.Size(120, 22);
            this.txt_need_by.TabIndex = 363;
            // 
            // lbl_ets
            // 
            this.lbl_ets.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ets.ImageIndex = 0;
            this.lbl_ets.ImageList = this.img_Label;
            this.lbl_ets.Location = new System.Drawing.Point(712, 105);
            this.lbl_ets.Name = "lbl_ets";
            this.lbl_ets.Size = new System.Drawing.Size(100, 21);
            this.lbl_ets.TabIndex = 360;
            this.lbl_ets.Tag = "23";
            this.lbl_ets.Text = "ETS";
            this.lbl_ets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ets
            // 
            this.txt_ets.CustomFormat = "yyyyMMdd";
            this.txt_ets.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_ets.Location = new System.Drawing.Point(813, 104);
            this.txt_ets.Name = "txt_ets";
            this.txt_ets.Size = new System.Drawing.Size(120, 22);
            this.txt_ets.TabIndex = 361;
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.ImageIndex = 0;
            this.lbl_order_date.ImageList = this.img_Label;
            this.lbl_order_date.Location = new System.Drawing.Point(248, 105);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_order_date.TabIndex = 358;
            this.lbl_order_date.Tag = "23";
            this.lbl_order_date.Text = "Order Date";
            this.lbl_order_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_order_date
            // 
            this.txt_order_date.CustomFormat = "yyyyMMdd";
            this.txt_order_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_order_date.Location = new System.Drawing.Point(349, 104);
            this.txt_order_date.Name = "txt_order_date";
            this.txt_order_date.Size = new System.Drawing.Size(120, 22);
            this.txt_order_date.TabIndex = 359;
            // 
            // txt_requestor
            // 
            this.txt_requestor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_requestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_requestor.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_requestor.ForeColor = System.Drawing.Color.Black;
            this.txt_requestor.Location = new System.Drawing.Point(117, 105);
            this.txt_requestor.MaxLength = 100;
            this.txt_requestor.Name = "txt_requestor";
            this.txt_requestor.ReadOnly = true;
            this.txt_requestor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_requestor.Size = new System.Drawing.Size(120, 20);
            this.txt_requestor.TabIndex = 357;
            // 
            // lbl_requestor
            // 
            this.lbl_requestor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requestor.ImageIndex = 0;
            this.lbl_requestor.ImageList = this.img_Label;
            this.lbl_requestor.Location = new System.Drawing.Point(16, 105);
            this.lbl_requestor.Name = "lbl_requestor";
            this.lbl_requestor.Size = new System.Drawing.Size(100, 21);
            this.lbl_requestor.TabIndex = 356;
            this.lbl_requestor.Tag = "21";
            this.lbl_requestor.Text = "Requestor";
            this.lbl_requestor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_state
            // 
            this.txt_state.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_state.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_state.ForeColor = System.Drawing.Color.Black;
            this.txt_state.Location = new System.Drawing.Point(813, 82);
            this.txt_state.MaxLength = 100;
            this.txt_state.Name = "txt_state";
            this.txt_state.ReadOnly = true;
            this.txt_state.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_state.Size = new System.Drawing.Size(120, 20);
            this.txt_state.TabIndex = 355;
            // 
            // lbl_state
            // 
            this.lbl_state.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.ImageIndex = 0;
            this.lbl_state.ImageList = this.img_Label;
            this.lbl_state.Location = new System.Drawing.Point(712, 82);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(100, 21);
            this.lbl_state.TabIndex = 354;
            this.lbl_state.Tag = "21";
            this.lbl_state.Text = "State";
            this.lbl_state.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_factory_direct
            // 
            this.txt_factory_direct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_factory_direct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_factory_direct.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_factory_direct.ForeColor = System.Drawing.Color.Black;
            this.txt_factory_direct.Location = new System.Drawing.Point(581, 82);
            this.txt_factory_direct.MaxLength = 100;
            this.txt_factory_direct.Name = "txt_factory_direct";
            this.txt_factory_direct.ReadOnly = true;
            this.txt_factory_direct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_factory_direct.Size = new System.Drawing.Size(120, 20);
            this.txt_factory_direct.TabIndex = 353;
            // 
            // lbl_factory_direct
            // 
            this.lbl_factory_direct.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory_direct.ImageIndex = 0;
            this.lbl_factory_direct.ImageList = this.img_Label;
            this.lbl_factory_direct.Location = new System.Drawing.Point(480, 82);
            this.lbl_factory_direct.Name = "lbl_factory_direct";
            this.lbl_factory_direct.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory_direct.TabIndex = 352;
            this.lbl_factory_direct.Tag = "21";
            this.lbl_factory_direct.Text = "Factory Direct";
            this.lbl_factory_direct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_mo_id
            // 
            this.txt_mo_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mo_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mo_id.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_mo_id.ForeColor = System.Drawing.Color.Black;
            this.txt_mo_id.Location = new System.Drawing.Point(349, 82);
            this.txt_mo_id.MaxLength = 100;
            this.txt_mo_id.Name = "txt_mo_id";
            this.txt_mo_id.ReadOnly = true;
            this.txt_mo_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_mo_id.Size = new System.Drawing.Size(120, 20);
            this.txt_mo_id.TabIndex = 351;
            // 
            // lbl_mo_id
            // 
            this.lbl_mo_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mo_id.ImageIndex = 0;
            this.lbl_mo_id.ImageList = this.img_Label;
            this.lbl_mo_id.Location = new System.Drawing.Point(248, 82);
            this.lbl_mo_id.Name = "lbl_mo_id";
            this.lbl_mo_id.Size = new System.Drawing.Size(100, 21);
            this.lbl_mo_id.TabIndex = 350;
            this.lbl_mo_id.Tag = "21";
            this.lbl_mo_id.Text = "Mo ID";
            this.lbl_mo_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_model_name
            // 
            this.txt_model_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_model_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_model_name.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_model_name.ForeColor = System.Drawing.Color.Black;
            this.txt_model_name.Location = new System.Drawing.Point(117, 82);
            this.txt_model_name.MaxLength = 100;
            this.txt_model_name.Name = "txt_model_name";
            this.txt_model_name.ReadOnly = true;
            this.txt_model_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_model_name.Size = new System.Drawing.Size(120, 20);
            this.txt_model_name.TabIndex = 349;
            // 
            // lbl_model_name
            // 
            this.lbl_model_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model_name.ImageIndex = 0;
            this.lbl_model_name.ImageList = this.img_Label;
            this.lbl_model_name.Location = new System.Drawing.Point(16, 82);
            this.lbl_model_name.Name = "lbl_model_name";
            this.lbl_model_name.Size = new System.Drawing.Size(100, 21);
            this.lbl_model_name.TabIndex = 348;
            this.lbl_model_name.Tag = "21";
            this.lbl_model_name.Text = "Model Name";
            this.lbl_model_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_sampletypes
            // 
            this.cmb_sampletypes.AddItemCols = 0;
            this.cmb_sampletypes.AddItemSeparator = ';';
            this.cmb_sampletypes.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_sampletypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sampletypes.Caption = "";
            this.cmb_sampletypes.CaptionHeight = 17;
            this.cmb_sampletypes.CaptionStyle = style9;
            this.cmb_sampletypes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_sampletypes.ColumnCaptionHeight = 18;
            this.cmb_sampletypes.ColumnFooterHeight = 18;
            this.cmb_sampletypes.ContentHeight = 17;
            this.cmb_sampletypes.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_sampletypes.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_sampletypes.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampletypes.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sampletypes.EditorHeight = 17;
            this.cmb_sampletypes.EvenRowStyle = style10;
            this.cmb_sampletypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampletypes.FooterStyle = style11;
            this.cmb_sampletypes.GapHeight = 2;
            this.cmb_sampletypes.HeadingStyle = style12;
            this.cmb_sampletypes.HighLightRowStyle = style13;
            this.cmb_sampletypes.ItemHeight = 15;
            this.cmb_sampletypes.Location = new System.Drawing.Point(581, 59);
            this.cmb_sampletypes.MatchEntryTimeout = ((long)(2000));
            this.cmb_sampletypes.MaxDropDownItems = ((short)(5));
            this.cmb_sampletypes.MaxLength = 32767;
            this.cmb_sampletypes.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sampletypes.Name = "cmb_sampletypes";
            this.cmb_sampletypes.OddRowStyle = style14;
            this.cmb_sampletypes.PartialRightColumn = false;
            this.cmb_sampletypes.PropBag = resources.GetString("cmb_sampletypes.PropBag");
            this.cmb_sampletypes.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sampletypes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sampletypes.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sampletypes.SelectedStyle = style15;
            this.cmb_sampletypes.Size = new System.Drawing.Size(120, 21);
            this.cmb_sampletypes.Style = style16;
            this.cmb_sampletypes.TabIndex = 347;
            // 
            // lbl_sampletypes
            // 
            this.lbl_sampletypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sampletypes.ImageIndex = 0;
            this.lbl_sampletypes.ImageList = this.img_Label;
            this.lbl_sampletypes.Location = new System.Drawing.Point(480, 59);
            this.lbl_sampletypes.Name = "lbl_sampletypes";
            this.lbl_sampletypes.Size = new System.Drawing.Size(100, 21);
            this.lbl_sampletypes.TabIndex = 346;
            this.lbl_sampletypes.Tag = "21";
            this.lbl_sampletypes.Text = "Sample Types";
            this.lbl_sampletypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_level
            // 
            this.cmb_level.AddItemCols = 0;
            this.cmb_level.AddItemSeparator = ';';
            this.cmb_level.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_level.Caption = "";
            this.cmb_level.CaptionHeight = 17;
            this.cmb_level.CaptionStyle = style17;
            this.cmb_level.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_level.ColumnCaptionHeight = 18;
            this.cmb_level.ColumnFooterHeight = 18;
            this.cmb_level.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_level.ContentHeight = 17;
            this.cmb_level.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_level.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_level.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_level.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_level.EditorHeight = 17;
            this.cmb_level.EvenRowStyle = style18;
            this.cmb_level.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_level.FooterStyle = style19;
            this.cmb_level.GapHeight = 2;
            this.cmb_level.HeadingStyle = style20;
            this.cmb_level.HighLightRowStyle = style21;
            this.cmb_level.ItemHeight = 15;
            this.cmb_level.Location = new System.Drawing.Point(581, 36);
            this.cmb_level.MatchEntryTimeout = ((long)(2000));
            this.cmb_level.MaxDropDownItems = ((short)(5));
            this.cmb_level.MaxLength = 32767;
            this.cmb_level.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_level.Name = "cmb_level";
            this.cmb_level.OddRowStyle = style22;
            this.cmb_level.PartialRightColumn = false;
            this.cmb_level.PropBag = resources.GetString("cmb_level.PropBag");
            this.cmb_level.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_level.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_level.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_level.SelectedStyle = style23;
            this.cmb_level.Size = new System.Drawing.Size(120, 21);
            this.cmb_level.Style = style24;
            this.cmb_level.TabIndex = 345;
            // 
            // lbl_level
            // 
            this.lbl_level.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_level.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.ImageIndex = 0;
            this.lbl_level.ImageList = this.img_Label;
            this.lbl_level.Location = new System.Drawing.Point(480, 36);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(100, 21);
            this.lbl_level.TabIndex = 344;
            this.lbl_level.Tag = "21";
            this.lbl_level.Text = "Level";
            this.lbl_level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_srno
            // 
            this.txt_srno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_srno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_srno.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_srno.ForeColor = System.Drawing.Color.Black;
            this.txt_srno.Location = new System.Drawing.Point(349, 36);
            this.txt_srno.MaxLength = 100;
            this.txt_srno.Name = "txt_srno";
            this.txt_srno.ReadOnly = true;
            this.txt_srno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_srno.Size = new System.Drawing.Size(120, 20);
            this.txt_srno.TabIndex = 343;
            // 
            // lbl_srno
            // 
            this.lbl_srno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srno.ImageIndex = 0;
            this.lbl_srno.ImageList = this.img_Label;
            this.lbl_srno.Location = new System.Drawing.Point(248, 36);
            this.lbl_srno.Name = "lbl_srno";
            this.lbl_srno.Size = new System.Drawing.Size(100, 21);
            this.lbl_srno.TabIndex = 342;
            this.lbl_srno.Tag = "21";
            this.lbl_srno.Text = "Sample Req.#";
            this.lbl_srno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_srfno
            // 
            this.txt_srfno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_srfno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_srfno.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_srfno.ForeColor = System.Drawing.Color.Black;
            this.txt_srfno.Location = new System.Drawing.Point(117, 59);
            this.txt_srfno.MaxLength = 100;
            this.txt_srfno.Name = "txt_srfno";
            this.txt_srfno.ReadOnly = true;
            this.txt_srfno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_srfno.Size = new System.Drawing.Size(120, 20);
            this.txt_srfno.TabIndex = 341;
            // 
            // lbl_srfno
            // 
            this.lbl_srfno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srfno.ImageIndex = 0;
            this.lbl_srfno.ImageList = this.img_Label;
            this.lbl_srfno.Location = new System.Drawing.Point(16, 59);
            this.lbl_srfno.Name = "lbl_srfno";
            this.lbl_srfno.Size = new System.Drawing.Size(100, 21);
            this.lbl_srfno.TabIndex = 340;
            this.lbl_srfno.Tag = "21";
            this.lbl_srfno.Text = "Proj. Alias";
            this.lbl_srfno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_bomrev
            // 
            this.txt_bomrev.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_bomrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bomrev.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_bomrev.ForeColor = System.Drawing.Color.Black;
            this.txt_bomrev.Location = new System.Drawing.Point(430, 59);
            this.txt_bomrev.MaxLength = 100;
            this.txt_bomrev.Name = "txt_bomrev";
            this.txt_bomrev.ReadOnly = true;
            this.txt_bomrev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_bomrev.Size = new System.Drawing.Size(39, 20);
            this.txt_bomrev.TabIndex = 335;
            // 
            // txt_bomid
            // 
            this.txt_bomid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_bomid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bomid.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_bomid.ForeColor = System.Drawing.Color.Black;
            this.txt_bomid.Location = new System.Drawing.Point(349, 59);
            this.txt_bomid.MaxLength = 100;
            this.txt_bomid.Name = "txt_bomid";
            this.txt_bomid.ReadOnly = true;
            this.txt_bomid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_bomid.Size = new System.Drawing.Size(80, 20);
            this.txt_bomid.TabIndex = 334;
            // 
            // lbl_bom
            // 
            this.lbl_bom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bom.ImageIndex = 0;
            this.lbl_bom.ImageList = this.img_Label;
            this.lbl_bom.Location = new System.Drawing.Point(248, 59);
            this.lbl_bom.Name = "lbl_bom";
            this.lbl_bom.Size = new System.Drawing.Size(100, 21);
            this.lbl_bom.TabIndex = 333;
            this.lbl_bom.Tag = "21";
            this.lbl_bom.Text = "BOM Id/Rev";
            this.lbl_bom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_srfpath
            // 
            this.lbl_srfpath.ImageIndex = 0;
            this.lbl_srfpath.ImageList = this.img_Label;
            this.lbl_srfpath.Location = new System.Drawing.Point(480, 36);
            this.lbl_srfpath.Name = "lbl_srfpath";
            this.lbl_srfpath.Size = new System.Drawing.Size(100, 21);
            this.lbl_srfpath.TabIndex = 303;
            this.lbl_srfpath.Text = "SRF Path";
            this.lbl_srfpath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style25;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 17;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Control;
            this.cmb_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 17;
            this.cmb_factory.EvenRowStyle = style26;
            this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style27;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style28;
            this.cmb_factory.HighLightRowStyle = style29;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(117, 36);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style30;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style31;
            this.cmb_factory.Size = new System.Drawing.Size(120, 21);
            this.cmb_factory.Style = style32;
            this.cmb_factory.TabIndex = 272;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 36);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 271;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(768, 304);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 21);
            this.textBox1.TabIndex = 270;
            this.textBox1.Tag = "60";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(560, 304);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 21);
            this.textBox2.TabIndex = 268;
            this.textBox2.Tag = "60";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(384, 328);
            this.textBox3.MaxLength = 100;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(416, 21);
            this.textBox3.TabIndex = 267;
            this.textBox3.Tag = "60";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(376, 304);
            this.textBox4.MaxLength = 100;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 21);
            this.textBox4.TabIndex = 264;
            this.textBox4.Tag = "60";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(200, 304);
            this.textBox5.MaxLength = 100;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 21);
            this.textBox5.TabIndex = 263;
            this.textBox5.Tag = "60";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(24, 304);
            this.textBox6.MaxLength = 100;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 21);
            this.textBox6.TabIndex = 262;
            this.textBox6.Tag = "60";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox10);
            this.panel3.Controls.Add(this.pictureBox11);
            this.panel3.Controls.Add(this.lbl_srf_info);
            this.panel3.Controls.Add(this.pictureBox12);
            this.panel3.Controls.Add(this.pictureBox13);
            this.panel3.Controls.Add(this.pictureBox14);
            this.panel3.Controls.Add(this.pictureBox15);
            this.panel3.Controls.Add(this.pictureBox16);
            this.panel3.Controls.Add(this.pictureBox17);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(8, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 152);
            this.panel3.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 112;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(983, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 109);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(984, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(16, 32);
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(224, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(1000, 40);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // lbl_srf_info
            // 
            this.lbl_srf_info.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_srf_info.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srf_info.ForeColor = System.Drawing.Color.Navy;
            this.lbl_srf_info.Image = ((System.Drawing.Image)(resources.GetObject("lbl_srf_info.Image")));
            this.lbl_srf_info.Location = new System.Drawing.Point(0, 0);
            this.lbl_srf_info.Name = "lbl_srf_info";
            this.lbl_srf_info.Size = new System.Drawing.Size(231, 30);
            this.lbl_srf_info.TabIndex = 28;
            this.lbl_srf_info.Text = "      SR Information";
            this.lbl_srf_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(984, 137);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(16, 16);
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(144, 136);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox13.TabIndex = 24;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(0, 137);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(168, 20);
            this.pictureBox14.TabIndex = 22;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(0, 24);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(168, 119);
            this.pictureBox15.TabIndex = 25;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(152, 24);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(1000, 112);
            this.pictureBox16.TabIndex = 27;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(472, 72);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(1000, 112);
            this.pictureBox17.TabIndex = 27;
            this.pictureBox17.TabStop = false;
            // 
            // lbl_sampletype
            // 
            this.lbl_sampletype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sampletype.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sampletype.Controls.Add(this.txt_current_ipw);
            this.lbl_sampletype.Controls.Add(this.txt_mto_account_name);
            this.lbl_sampletype.Controls.Add(this.lbl_mto_account);
            this.lbl_sampletype.Controls.Add(this.txt_technology);
            this.lbl_sampletype.Controls.Add(this.txt_sole_laying_method);
            this.lbl_sampletype.Controls.Add(this.txt_bom_state);
            this.lbl_sampletype.Controls.Add(this.txt_mtl_ver);
            this.lbl_sampletype.Controls.Add(this.txt_nlo_dev);
            this.lbl_sampletype.Controls.Add(this.lbl_nlo_dev);
            this.lbl_sampletype.Controls.Add(this.txt_season);
            this.lbl_sampletype.Controls.Add(this.lbl_whq_dev);
            this.lbl_sampletype.Controls.Add(this.txt_whq_plm);
            this.lbl_sampletype.Controls.Add(this.lbl_whq_plm);
            this.lbl_sampletype.Controls.Add(this.txt_mo_alias);
            this.lbl_sampletype.Controls.Add(this.lbl_season);
            this.lbl_sampletype.Controls.Add(this.txt_whq_dev);
            this.lbl_sampletype.Controls.Add(this.lbl_mo_alias);
            this.lbl_sampletype.Controls.Add(this.lbl_product_code);
            this.lbl_sampletype.Controls.Add(this.txt_model_name_bom);
            this.lbl_sampletype.Controls.Add(this.txt_ms_method);
            this.lbl_sampletype.Controls.Add(this.lbl_last_cd);
            this.lbl_sampletype.Controls.Add(this.txt_product_code);
            this.lbl_sampletype.Controls.Add(this.lbl_current_ipw);
            this.lbl_sampletype.Controls.Add(this.txt_lasting_method);
            this.lbl_sampletype.Controls.Add(this.txt_colo_ver);
            this.lbl_sampletype.Controls.Add(this.txt_last_cd);
            this.lbl_sampletype.Controls.Add(this.txt_silhouette);
            this.lbl_sampletype.Controls.Add(this.lbl_sole_laying_me);
            this.lbl_sampletype.Controls.Add(this.lbl_colo_ver);
            this.lbl_sampletype.Controls.Add(this.lbl_mtl_ver);
            this.lbl_sampletype.Controls.Add(this.lbl_silhouette);
            this.lbl_sampletype.Controls.Add(this.lbl_ms_method);
            this.lbl_sampletype.Controls.Add(this.lbl_lasting_method);
            this.lbl_sampletype.Controls.Add(this.lbl_model_name_bom);
            this.lbl_sampletype.Controls.Add(this.lbl_technology);
            this.lbl_sampletype.Controls.Add(this.txt_bom_comments);
            this.lbl_sampletype.Controls.Add(this.lbl_bom_comments);
            this.lbl_sampletype.Controls.Add(this.lbl_bom_state);
            this.lbl_sampletype.Controls.Add(this.pnl_SearchImage);
            this.lbl_sampletype.Controls.Add(this.panel5);
            this.lbl_sampletype.Controls.Add(this.panel4);
            this.lbl_sampletype.Location = new System.Drawing.Point(0, 248);
            this.lbl_sampletype.Name = "lbl_sampletype";
            this.lbl_sampletype.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.lbl_sampletype.Size = new System.Drawing.Size(1016, 136);
            this.lbl_sampletype.TabIndex = 136;
            // 
            // txt_current_ipw
            // 
            this.txt_current_ipw.CustomFormat = "yyyyMMdd";
            this.txt_current_ipw.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_current_ipw.Location = new System.Drawing.Point(349, 53);
            this.txt_current_ipw.Name = "txt_current_ipw";
            this.txt_current_ipw.Size = new System.Drawing.Size(120, 22);
            this.txt_current_ipw.TabIndex = 375;
            // 
            // txt_mto_account_name
            // 
            this.txt_mto_account_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mto_account_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mto_account_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mto_account_name.ForeColor = System.Drawing.Color.Black;
            this.txt_mto_account_name.Location = new System.Drawing.Point(117, 77);
            this.txt_mto_account_name.MaxLength = 100;
            this.txt_mto_account_name.Name = "txt_mto_account_name";
            this.txt_mto_account_name.Size = new System.Drawing.Size(120, 21);
            this.txt_mto_account_name.TabIndex = 374;
            this.txt_mto_account_name.Tag = "47";
            // 
            // lbl_mto_account
            // 
            this.lbl_mto_account.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mto_account.ImageIndex = 0;
            this.lbl_mto_account.ImageList = this.img_Label;
            this.lbl_mto_account.Location = new System.Drawing.Point(16, 77);
            this.lbl_mto_account.Name = "lbl_mto_account";
            this.lbl_mto_account.Size = new System.Drawing.Size(100, 21);
            this.lbl_mto_account.TabIndex = 373;
            this.lbl_mto_account.Tag = "16";
            this.lbl_mto_account.Text = "MTO Account";
            this.lbl_mto_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_technology
            // 
            this.txt_technology.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_technology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_technology.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_technology.ForeColor = System.Drawing.Color.Black;
            this.txt_technology.Location = new System.Drawing.Point(581, 8);
            this.txt_technology.MaxLength = 100;
            this.txt_technology.Name = "txt_technology";
            this.txt_technology.Size = new System.Drawing.Size(120, 21);
            this.txt_technology.TabIndex = 372;
            this.txt_technology.Tag = "60";
            // 
            // txt_sole_laying_method
            // 
            this.txt_sole_laying_method.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_sole_laying_method.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sole_laying_method.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sole_laying_method.ForeColor = System.Drawing.Color.Black;
            this.txt_sole_laying_method.Location = new System.Drawing.Point(581, 31);
            this.txt_sole_laying_method.MaxLength = 100;
            this.txt_sole_laying_method.Name = "txt_sole_laying_method";
            this.txt_sole_laying_method.Size = new System.Drawing.Size(120, 21);
            this.txt_sole_laying_method.TabIndex = 371;
            this.txt_sole_laying_method.Tag = "60";
            // 
            // txt_bom_state
            // 
            this.txt_bom_state.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_bom_state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bom_state.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bom_state.ForeColor = System.Drawing.Color.Black;
            this.txt_bom_state.Location = new System.Drawing.Point(117, 8);
            this.txt_bom_state.MaxLength = 100;
            this.txt_bom_state.Name = "txt_bom_state";
            this.txt_bom_state.Size = new System.Drawing.Size(120, 21);
            this.txt_bom_state.TabIndex = 370;
            this.txt_bom_state.Tag = "60";
            // 
            // txt_mtl_ver
            // 
            this.txt_mtl_ver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mtl_ver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mtl_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mtl_ver.ForeColor = System.Drawing.Color.Black;
            this.txt_mtl_ver.Location = new System.Drawing.Point(117, 100);
            this.txt_mtl_ver.MaxLength = 100;
            this.txt_mtl_ver.Name = "txt_mtl_ver";
            this.txt_mtl_ver.Size = new System.Drawing.Size(120, 21);
            this.txt_mtl_ver.TabIndex = 368;
            this.txt_mtl_ver.Tag = "47";
            // 
            // txt_nlo_dev
            // 
            this.txt_nlo_dev.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nlo_dev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nlo_dev.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nlo_dev.ForeColor = System.Drawing.Color.Black;
            this.txt_nlo_dev.Location = new System.Drawing.Point(813, 77);
            this.txt_nlo_dev.MaxLength = 100;
            this.txt_nlo_dev.Name = "txt_nlo_dev";
            this.txt_nlo_dev.Size = new System.Drawing.Size(120, 21);
            this.txt_nlo_dev.TabIndex = 367;
            this.txt_nlo_dev.Tag = "47";
            // 
            // lbl_nlo_dev
            // 
            this.lbl_nlo_dev.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nlo_dev.ImageIndex = 0;
            this.lbl_nlo_dev.ImageList = this.img_Label;
            this.lbl_nlo_dev.Location = new System.Drawing.Point(712, 77);
            this.lbl_nlo_dev.Name = "lbl_nlo_dev";
            this.lbl_nlo_dev.Size = new System.Drawing.Size(100, 21);
            this.lbl_nlo_dev.TabIndex = 366;
            this.lbl_nlo_dev.Tag = "16";
            this.lbl_nlo_dev.Text = "NLO Dev";
            this.lbl_nlo_dev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_season
            // 
            this.txt_season.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_season.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_season.ForeColor = System.Drawing.Color.Black;
            this.txt_season.Location = new System.Drawing.Point(813, 54);
            this.txt_season.MaxLength = 100;
            this.txt_season.Name = "txt_season";
            this.txt_season.Size = new System.Drawing.Size(120, 21);
            this.txt_season.TabIndex = 365;
            this.txt_season.Tag = "47";
            // 
            // lbl_whq_dev
            // 
            this.lbl_whq_dev.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_whq_dev.ImageIndex = 0;
            this.lbl_whq_dev.ImageList = this.img_Label;
            this.lbl_whq_dev.Location = new System.Drawing.Point(480, 77);
            this.lbl_whq_dev.Name = "lbl_whq_dev";
            this.lbl_whq_dev.Size = new System.Drawing.Size(100, 21);
            this.lbl_whq_dev.TabIndex = 364;
            this.lbl_whq_dev.Tag = "16";
            this.lbl_whq_dev.Text = "WHQ Dev";
            this.lbl_whq_dev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_whq_plm
            // 
            this.txt_whq_plm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_whq_plm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_whq_plm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_whq_plm.ForeColor = System.Drawing.Color.Black;
            this.txt_whq_plm.Location = new System.Drawing.Point(349, 77);
            this.txt_whq_plm.MaxLength = 100;
            this.txt_whq_plm.Name = "txt_whq_plm";
            this.txt_whq_plm.Size = new System.Drawing.Size(120, 21);
            this.txt_whq_plm.TabIndex = 363;
            this.txt_whq_plm.Tag = "47";
            // 
            // lbl_whq_plm
            // 
            this.lbl_whq_plm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_whq_plm.ImageIndex = 0;
            this.lbl_whq_plm.ImageList = this.img_Label;
            this.lbl_whq_plm.Location = new System.Drawing.Point(248, 77);
            this.lbl_whq_plm.Name = "lbl_whq_plm";
            this.lbl_whq_plm.Size = new System.Drawing.Size(100, 21);
            this.lbl_whq_plm.TabIndex = 362;
            this.lbl_whq_plm.Tag = "16";
            this.lbl_whq_plm.Text = "WHQ PLM";
            this.lbl_whq_plm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_mo_alias
            // 
            this.txt_mo_alias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mo_alias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mo_alias.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mo_alias.ForeColor = System.Drawing.Color.Black;
            this.txt_mo_alias.Location = new System.Drawing.Point(581, 54);
            this.txt_mo_alias.MaxLength = 100;
            this.txt_mo_alias.Name = "txt_mo_alias";
            this.txt_mo_alias.Size = new System.Drawing.Size(120, 21);
            this.txt_mo_alias.TabIndex = 361;
            this.txt_mo_alias.Tag = "41";
            // 
            // lbl_season
            // 
            this.lbl_season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_season.ImageIndex = 0;
            this.lbl_season.ImageList = this.img_Label;
            this.lbl_season.Location = new System.Drawing.Point(712, 53);
            this.lbl_season.Name = "lbl_season";
            this.lbl_season.Size = new System.Drawing.Size(100, 21);
            this.lbl_season.TabIndex = 360;
            this.lbl_season.Tag = "10";
            this.lbl_season.Text = "Season";
            this.lbl_season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_whq_dev
            // 
            this.txt_whq_dev.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_whq_dev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_whq_dev.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_whq_dev.ForeColor = System.Drawing.Color.Black;
            this.txt_whq_dev.Location = new System.Drawing.Point(581, 77);
            this.txt_whq_dev.MaxLength = 100;
            this.txt_whq_dev.Name = "txt_whq_dev";
            this.txt_whq_dev.Size = new System.Drawing.Size(120, 21);
            this.txt_whq_dev.TabIndex = 359;
            this.txt_whq_dev.Tag = "41";
            // 
            // lbl_mo_alias
            // 
            this.lbl_mo_alias.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mo_alias.ImageIndex = 0;
            this.lbl_mo_alias.ImageList = this.img_Label;
            this.lbl_mo_alias.Location = new System.Drawing.Point(480, 54);
            this.lbl_mo_alias.Name = "lbl_mo_alias";
            this.lbl_mo_alias.Size = new System.Drawing.Size(100, 21);
            this.lbl_mo_alias.TabIndex = 358;
            this.lbl_mo_alias.Tag = "10";
            this.lbl_mo_alias.Text = "MO Alias";
            this.lbl_mo_alias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_product_code
            // 
            this.lbl_product_code.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_code.ImageIndex = 0;
            this.lbl_product_code.ImageList = this.img_Label;
            this.lbl_product_code.Location = new System.Drawing.Point(16, 54);
            this.lbl_product_code.Name = "lbl_product_code";
            this.lbl_product_code.Size = new System.Drawing.Size(100, 21);
            this.lbl_product_code.TabIndex = 356;
            this.lbl_product_code.Tag = "17";
            this.lbl_product_code.Text = "Product Code";
            this.lbl_product_code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_model_name_bom
            // 
            this.txt_model_name_bom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_model_name_bom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_model_name_bom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_model_name_bom.ForeColor = System.Drawing.Color.Black;
            this.txt_model_name_bom.Location = new System.Drawing.Point(813, 8);
            this.txt_model_name_bom.MaxLength = 100;
            this.txt_model_name_bom.Name = "txt_model_name_bom";
            this.txt_model_name_bom.Size = new System.Drawing.Size(120, 21);
            this.txt_model_name_bom.TabIndex = 355;
            this.txt_model_name_bom.Tag = "41";
            // 
            // txt_ms_method
            // 
            this.txt_ms_method.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ms_method.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ms_method.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ms_method.ForeColor = System.Drawing.Color.Black;
            this.txt_ms_method.Location = new System.Drawing.Point(349, 31);
            this.txt_ms_method.MaxLength = 100;
            this.txt_ms_method.Name = "txt_ms_method";
            this.txt_ms_method.Size = new System.Drawing.Size(120, 21);
            this.txt_ms_method.TabIndex = 354;
            this.txt_ms_method.Tag = "41";
            // 
            // lbl_last_cd
            // 
            this.lbl_last_cd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_cd.ImageIndex = 0;
            this.lbl_last_cd.ImageList = this.img_Label;
            this.lbl_last_cd.Location = new System.Drawing.Point(712, 31);
            this.lbl_last_cd.Name = "lbl_last_cd";
            this.lbl_last_cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_last_cd.TabIndex = 353;
            this.lbl_last_cd.Tag = "10";
            this.lbl_last_cd.Text = "Last Cd";
            this.lbl_last_cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_product_code
            // 
            this.txt_product_code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_product_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_product_code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_code.ForeColor = System.Drawing.Color.Black;
            this.txt_product_code.Location = new System.Drawing.Point(117, 54);
            this.txt_product_code.MaxLength = 100;
            this.txt_product_code.Name = "txt_product_code";
            this.txt_product_code.Size = new System.Drawing.Size(120, 21);
            this.txt_product_code.TabIndex = 352;
            this.txt_product_code.Tag = "39";
            // 
            // lbl_current_ipw
            // 
            this.lbl_current_ipw.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_ipw.ImageIndex = 0;
            this.lbl_current_ipw.ImageList = this.img_Label;
            this.lbl_current_ipw.Location = new System.Drawing.Point(248, 54);
            this.lbl_current_ipw.Name = "lbl_current_ipw";
            this.lbl_current_ipw.Size = new System.Drawing.Size(100, 21);
            this.lbl_current_ipw.TabIndex = 351;
            this.lbl_current_ipw.Tag = "8";
            this.lbl_current_ipw.Text = "Current IPW";
            this.lbl_current_ipw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_lasting_method
            // 
            this.txt_lasting_method.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_lasting_method.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lasting_method.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lasting_method.ForeColor = System.Drawing.Color.Black;
            this.txt_lasting_method.Location = new System.Drawing.Point(117, 31);
            this.txt_lasting_method.MaxLength = 100;
            this.txt_lasting_method.Name = "txt_lasting_method";
            this.txt_lasting_method.Size = new System.Drawing.Size(120, 21);
            this.txt_lasting_method.TabIndex = 350;
            this.txt_lasting_method.Tag = "60";
            // 
            // txt_colo_ver
            // 
            this.txt_colo_ver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_colo_ver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_colo_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_colo_ver.ForeColor = System.Drawing.Color.Black;
            this.txt_colo_ver.Location = new System.Drawing.Point(349, 100);
            this.txt_colo_ver.MaxLength = 100;
            this.txt_colo_ver.Name = "txt_colo_ver";
            this.txt_colo_ver.Size = new System.Drawing.Size(120, 21);
            this.txt_colo_ver.TabIndex = 349;
            this.txt_colo_ver.Tag = "48";
            // 
            // txt_last_cd
            // 
            this.txt_last_cd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_last_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_last_cd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_last_cd.ForeColor = System.Drawing.Color.Black;
            this.txt_last_cd.Location = new System.Drawing.Point(813, 31);
            this.txt_last_cd.MaxLength = 100;
            this.txt_last_cd.Name = "txt_last_cd";
            this.txt_last_cd.Size = new System.Drawing.Size(120, 21);
            this.txt_last_cd.TabIndex = 348;
            this.txt_last_cd.Tag = "47";
            // 
            // txt_silhouette
            // 
            this.txt_silhouette.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_silhouette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_silhouette.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_silhouette.ForeColor = System.Drawing.Color.Black;
            this.txt_silhouette.Location = new System.Drawing.Point(349, 8);
            this.txt_silhouette.MaxLength = 100;
            this.txt_silhouette.Name = "txt_silhouette";
            this.txt_silhouette.Size = new System.Drawing.Size(120, 21);
            this.txt_silhouette.TabIndex = 347;
            this.txt_silhouette.Tag = "32";
            // 
            // lbl_sole_laying_me
            // 
            this.lbl_sole_laying_me.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sole_laying_me.ImageIndex = 0;
            this.lbl_sole_laying_me.ImageList = this.img_Label;
            this.lbl_sole_laying_me.Location = new System.Drawing.Point(480, 31);
            this.lbl_sole_laying_me.Name = "lbl_sole_laying_me";
            this.lbl_sole_laying_me.Size = new System.Drawing.Size(100, 21);
            this.lbl_sole_laying_me.TabIndex = 346;
            this.lbl_sole_laying_me.Tag = "29";
            this.lbl_sole_laying_me.Text = "Sole Laying";
            this.lbl_sole_laying_me.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_colo_ver
            // 
            this.lbl_colo_ver.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_colo_ver.ImageIndex = 0;
            this.lbl_colo_ver.ImageList = this.img_Label;
            this.lbl_colo_ver.Location = new System.Drawing.Point(248, 100);
            this.lbl_colo_ver.Name = "lbl_colo_ver";
            this.lbl_colo_ver.Size = new System.Drawing.Size(100, 21);
            this.lbl_colo_ver.TabIndex = 345;
            this.lbl_colo_ver.Tag = "17";
            this.lbl_colo_ver.Text = "Color Ver";
            this.lbl_colo_ver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mtl_ver
            // 
            this.lbl_mtl_ver.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mtl_ver.ImageIndex = 0;
            this.lbl_mtl_ver.ImageList = this.img_Label;
            this.lbl_mtl_ver.Location = new System.Drawing.Point(16, 100);
            this.lbl_mtl_ver.Name = "lbl_mtl_ver";
            this.lbl_mtl_ver.Size = new System.Drawing.Size(100, 21);
            this.lbl_mtl_ver.TabIndex = 344;
            this.lbl_mtl_ver.Tag = "16";
            this.lbl_mtl_ver.Text = "Mtl Ver";
            this.lbl_mtl_ver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_silhouette
            // 
            this.lbl_silhouette.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_silhouette.ImageIndex = 0;
            this.lbl_silhouette.ImageList = this.img_Label;
            this.lbl_silhouette.Location = new System.Drawing.Point(248, 8);
            this.lbl_silhouette.Name = "lbl_silhouette";
            this.lbl_silhouette.Size = new System.Drawing.Size(100, 21);
            this.lbl_silhouette.TabIndex = 343;
            this.lbl_silhouette.Tag = "1";
            this.lbl_silhouette.Text = "Silhouette";
            this.lbl_silhouette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ms_method
            // 
            this.lbl_ms_method.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ms_method.ImageIndex = 0;
            this.lbl_ms_method.ImageList = this.img_Label;
            this.lbl_ms_method.Location = new System.Drawing.Point(248, 31);
            this.lbl_ms_method.Name = "lbl_ms_method";
            this.lbl_ms_method.Size = new System.Drawing.Size(100, 21);
            this.lbl_ms_method.TabIndex = 341;
            this.lbl_ms_method.Tag = "21";
            this.lbl_ms_method.Text = "M/S Method";
            this.lbl_ms_method.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_lasting_method
            // 
            this.lbl_lasting_method.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lasting_method.ImageIndex = 0;
            this.lbl_lasting_method.ImageList = this.img_Label;
            this.lbl_lasting_method.Location = new System.Drawing.Point(16, 31);
            this.lbl_lasting_method.Name = "lbl_lasting_method";
            this.lbl_lasting_method.Size = new System.Drawing.Size(100, 21);
            this.lbl_lasting_method.TabIndex = 339;
            this.lbl_lasting_method.Tag = "21";
            this.lbl_lasting_method.Text = "Lasting Method";
            this.lbl_lasting_method.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_model_name_bom
            // 
            this.lbl_model_name_bom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model_name_bom.ImageIndex = 0;
            this.lbl_model_name_bom.ImageList = this.img_Label;
            this.lbl_model_name_bom.Location = new System.Drawing.Point(712, 8);
            this.lbl_model_name_bom.Name = "lbl_model_name_bom";
            this.lbl_model_name_bom.Size = new System.Drawing.Size(100, 21);
            this.lbl_model_name_bom.TabIndex = 337;
            this.lbl_model_name_bom.Tag = "9";
            this.lbl_model_name_bom.Text = "Model Name";
            this.lbl_model_name_bom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_technology
            // 
            this.lbl_technology.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_technology.ImageIndex = 0;
            this.lbl_technology.ImageList = this.img_Label;
            this.lbl_technology.Location = new System.Drawing.Point(480, 8);
            this.lbl_technology.Name = "lbl_technology";
            this.lbl_technology.Size = new System.Drawing.Size(100, 21);
            this.lbl_technology.TabIndex = 335;
            this.lbl_technology.Tag = "21";
            this.lbl_technology.Text = "Technology";
            this.lbl_technology.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_bom_comments
            // 
            this.txt_bom_comments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_bom_comments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bom_comments.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_bom_comments.ForeColor = System.Drawing.Color.Black;
            this.txt_bom_comments.Location = new System.Drawing.Point(581, 100);
            this.txt_bom_comments.MaxLength = 100;
            this.txt_bom_comments.Multiline = true;
            this.txt_bom_comments.Name = "txt_bom_comments";
            this.txt_bom_comments.ReadOnly = true;
            this.txt_bom_comments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_bom_comments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_bom_comments.Size = new System.Drawing.Size(352, 21);
            this.txt_bom_comments.TabIndex = 334;
            // 
            // lbl_bom_comments
            // 
            this.lbl_bom_comments.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bom_comments.ImageIndex = 0;
            this.lbl_bom_comments.ImageList = this.img_Label;
            this.lbl_bom_comments.Location = new System.Drawing.Point(480, 100);
            this.lbl_bom_comments.Name = "lbl_bom_comments";
            this.lbl_bom_comments.Size = new System.Drawing.Size(100, 21);
            this.lbl_bom_comments.TabIndex = 333;
            this.lbl_bom_comments.Tag = "21";
            this.lbl_bom_comments.Text = "Bom Coment";
            this.lbl_bom_comments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_bom_state
            // 
            this.lbl_bom_state.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bom_state.ImageIndex = 0;
            this.lbl_bom_state.ImageList = this.img_Label;
            this.lbl_bom_state.Location = new System.Drawing.Point(16, 8);
            this.lbl_bom_state.Name = "lbl_bom_state";
            this.lbl_bom_state.Size = new System.Drawing.Size(100, 21);
            this.lbl_bom_state.TabIndex = 326;
            this.lbl_bom_state.Tag = "21";
            this.lbl_bom_state.Text = "Bom State";
            this.lbl_bom_state.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.btn_openfile);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox3);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 128);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // btn_openfile
            // 
            this.btn_openfile.BackColor = System.Drawing.SystemColors.Window;
            this.btn_openfile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openfile.Location = new System.Drawing.Point(426, 36);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(21, 21);
            this.btn_openfile.TabIndex = 112;
            this.btn_openfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(983, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 85);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(984, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 32);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(224, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1000, 40);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 30);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 113);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(144, 112);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 113);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 95);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(152, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1000, 88);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(472, 72);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1000, 88);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pictureBox27);
            this.panel5.Controls.Add(this.pictureBox28);
            this.panel5.Controls.Add(this.pictureBox29);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.pictureBox30);
            this.panel5.Controls.Add(this.pictureBox31);
            this.panel5.Controls.Add(this.pictureBox32);
            this.panel5.Controls.Add(this.pictureBox33);
            this.panel5.Controls.Add(this.pictureBox34);
            this.panel5.Controls.Add(this.pictureBox35);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(8, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1000, 128);
            this.panel5.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 21);
            this.label5.TabIndex = 112;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox27.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(983, 30);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(24, 85);
            this.pictureBox27.TabIndex = 26;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox28.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
            this.pictureBox28.Location = new System.Drawing.Point(984, 0);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(16, 32);
            this.pictureBox28.TabIndex = 21;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox29.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
            this.pictureBox29.Location = new System.Drawing.Point(224, 0);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(1000, 40);
            this.pictureBox29.TabIndex = 0;
            this.pictureBox29.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 30);
            this.label6.TabIndex = 28;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox30.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
            this.pictureBox30.Location = new System.Drawing.Point(984, 113);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(16, 16);
            this.pictureBox30.TabIndex = 23;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox31.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
            this.pictureBox31.Location = new System.Drawing.Point(144, 112);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox31.TabIndex = 24;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox32.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
            this.pictureBox32.Location = new System.Drawing.Point(0, 113);
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
            this.pictureBox33.Size = new System.Drawing.Size(168, 95);
            this.pictureBox33.TabIndex = 25;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox34.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
            this.pictureBox34.Location = new System.Drawing.Point(152, 24);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(1000, 88);
            this.pictureBox34.TabIndex = 27;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox35.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(472, 72);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(1000, 88);
            this.pictureBox35.TabIndex = 27;
            this.pictureBox35.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.pictureBox18);
            this.panel4.Controls.Add(this.pictureBox19);
            this.panel4.Controls.Add(this.pictureBox20);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.pictureBox21);
            this.panel4.Controls.Add(this.pictureBox22);
            this.panel4.Controls.Add(this.pictureBox23);
            this.panel4.Controls.Add(this.pictureBox24);
            this.panel4.Controls.Add(this.pictureBox25);
            this.panel4.Controls.Add(this.pictureBox26);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(8, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 128);
            this.panel4.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(426, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 21);
            this.label10.TabIndex = 112;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(983, 30);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(24, 85);
            this.pictureBox18.TabIndex = 26;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(984, 0);
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
            this.pictureBox20.Size = new System.Drawing.Size(1000, 40);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 30);
            this.label11.TabIndex = 28;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(984, 113);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(16, 16);
            this.pictureBox21.TabIndex = 23;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox22.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(144, 112);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox22.TabIndex = 24;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox23.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(0, 113);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(168, 20);
            this.pictureBox23.TabIndex = 22;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox24.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(0, 24);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(168, 95);
            this.pictureBox24.TabIndex = 25;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox25.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
            this.pictureBox25.Location = new System.Drawing.Point(152, 24);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(1000, 88);
            this.pictureBox25.TabIndex = 27;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox26.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(472, 72);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(1000, 88);
            this.pictureBox26.TabIndex = 27;
            this.pictureBox26.TabStop = false;
            // 
            // tab_control
            // 
            this.tab_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_control.Controls.Add(this.srf_tail);
            this.tab_control.Controls.Add(this.srf_order);
            this.tab_control.Controls.Add(this.srf_vendor);
            this.tab_control.Location = new System.Drawing.Point(8, 384);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1000, 256);
            this.tab_control.TabIndex = 309;
            // 
            // srf_tail
            // 
            this.srf_tail.BackColor = System.Drawing.Color.Transparent;
            this.srf_tail.Controls.Add(this.fgrid_detail);
            this.srf_tail.Location = new System.Drawing.Point(4, 23);
            this.srf_tail.Name = "srf_tail";
            this.srf_tail.Size = new System.Drawing.Size(992, 229);
            this.srf_tail.TabIndex = 0;
            this.srf_tail.Text = "Part";
            // 
            // fgrid_detail
            // 
            this.fgrid_detail.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_detail.AutoResize = false;
            this.fgrid_detail.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_detail.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_detail.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_detail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_detail.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_detail.Location = new System.Drawing.Point(0, 0);
            this.fgrid_detail.Name = "fgrid_detail";
            this.fgrid_detail.Rows.Fixed = 0;
            this.fgrid_detail.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_detail.Size = new System.Drawing.Size(992, 229);
            this.fgrid_detail.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_detail.Styles"));
            this.fgrid_detail.TabIndex = 103;
            this.fgrid_detail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_detail_MouseDown);
            // 
            // srf_order
            // 
            this.srf_order.Controls.Add(this.fgrid_order);
            this.srf_order.Location = new System.Drawing.Point(4, 23);
            this.srf_order.Name = "srf_order";
            this.srf_order.Size = new System.Drawing.Size(992, 229);
            this.srf_order.TabIndex = 2;
            this.srf_order.Text = "Order";
            this.srf_order.Visible = false;
            // 
            // fgrid_order
            // 
            this.fgrid_order.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_order.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_order.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_order.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_order.Location = new System.Drawing.Point(0, 0);
            this.fgrid_order.Name = "fgrid_order";
            this.fgrid_order.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_order.Size = new System.Drawing.Size(992, 229);
            this.fgrid_order.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_order.Styles"));
            this.fgrid_order.TabIndex = 103;
            // 
            // srf_vendor
            // 
            this.srf_vendor.BackColor = System.Drawing.Color.Transparent;
            this.srf_vendor.Controls.Add(this.fgrid_round);
            this.srf_vendor.Location = new System.Drawing.Point(4, 23);
            this.srf_vendor.Name = "srf_vendor";
            this.srf_vendor.Size = new System.Drawing.Size(992, 229);
            this.srf_vendor.TabIndex = 1;
            this.srf_vendor.Text = "Vendor";
            this.srf_vendor.Visible = false;
            // 
            // fgrid_round
            // 
            this.fgrid_round.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_round.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_round.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_round.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_round.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_round.Location = new System.Drawing.Point(0, 0);
            this.fgrid_round.Name = "fgrid_round";
            this.fgrid_round.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_round.Size = new System.Drawing.Size(992, 229);
            this.fgrid_round.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_round.Styles"));
            this.fgrid_round.TabIndex = 103;
            // 
            // Form_Bom_Editer_In_DS
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.tab_control);
            this.Controls.Add(this.lbl_sampletype);
            this.Controls.Add(this.panel2);
            this.Name = "Form_Bom_Editer_In_DS";
            this.Load += new System.EventHandler(this.Form_Bom_Editer_In_DS_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lbl_sampletype, 0);
            this.Controls.SetChildIndex(this.tab_control, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.lbl_sampletype.ResumeLayout(false);
            this.lbl_sampletype.PerformLayout();
            this.pnl_SearchImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            this.tab_control.ResumeLayout(false);
            this.srf_tail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_detail)).EndInit();
            this.srf_order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_order)).EndInit();
            this.srf_vendor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_round)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 공통메쏘드

		private void Init_Form()
		{

			
			this.Text = "PCC_Update Bom In DS";
			this.lbl_MainTitle.Text = "PCC_Update Bom In DS";
			ClassLib.ComFunction.SetLangDic(this); 
			

			DataTable dt_ret = Select_sdc_nf_desc();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletypes, 0,2 , false, false);
			//cmb_sampletypes.SelectedIndex= -1;


			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxGen);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_gender, 1, 2, false, false);


			fgrid_round.Set_Grid_CDC("SXD_SRF_VENDOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_round.Set_Action_Image(img_Action);
			fgrid_round.ExtendLastCol = false;
			_RowFixed_vendor = fgrid_round.Rows.Fixed;	


			Type_Working();

		    cmb_factory.SelectedValue = _head_factory;
		    txt_srno.Text = _head_sr_no;
		    txt_srfno.Text = _head_srf_no;
		    txt_bomid.Text = _head_bom_id;
		    txt_bomrev.Text = _head_bom_rev;
		    cmb_sampletypes.SelectedValue = _head_nf_cd;


		    txt_srno.Enabled  = false;				
		    txt_bomid.Enabled =false;
		    txt_bomrev.Enabled =false;
		    txt_srfno.Enabled  =false;


		    txt_srno.ReadOnly  = true;
		    txt_bomid.ReadOnly=true;
		    txt_bomrev.ReadOnly=true;
		    txt_srfno.ReadOnly =true;



		    Select_srf_maxseq(_head_factory, _head_sr_no, _head_srf_no, _head_bom_id, _head_bom_rev, _head_nf_cd);
		    tbtn_Search_Click(null, null);




		}








			
		





		private bool Set_sdd_srf_head()
		{
			DataTable dt = Select_sdd_srf_head();


			if(dt.Rows.Count == 0) return false;


			//_head_factory       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxFACTORY].ToString();
			//_head_sr_no         = dt.Rows[0].ItemArray[(int)ClassLib.TBSDD_SRF_HEADII.IxSR_NO].ToString();
			//_head_srf_no        = dt.Rows[0].ItemArray[(int)ClassLib.TBSDD_SRF_HEADII.IxSRF_NO].ToString();
			//_head_bom_id        = dt.Rows[0].ItemArray[(int)ClassLib.TBSDD_SRF_HEADII.IxBOM_ID].ToString();
			//_head_bom_rev       = dt.Rows[0].ItemArray[(int)ClassLib.TBSDD_SRF_HEADII.IxBOM_REV].ToString();
			//_head_nf_cd         = dt.Rows[0].ItemArray[(int)ClassLib.TBSDD_SRF_HEADII.IxNF_CD].ToString();
			//_head_srf_seq       = dt.Rows[0].ItemArray[(int)ClassLib.TBSDD_SRF_HEADII.IxSRF_SEQ].ToString();

			_head_bom_state     = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_STATE -1].ToString();
			_head_requestor     = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxREQUESTOR-1].ToString();
			_head_ord_ymd       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxORD_YMD-1].ToString();
			_head_need_by       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxNEED_BY-1].ToString();
			_head_ets           = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxETS-1].ToString();

			_head_mo_alias      = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxMO_ALIAS-1].ToString();
			_head_whq_plm       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxWHQ_PLM-1].ToString();
			_head_whq_dev       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxWHQ_DEV-1].ToString();
			_head_nlo_dev       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxNLO_DEV-1].ToString();
			_head_silhouette    = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSILHOUETTE-1].ToString();

			_head_technology    = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxTECHNOLOGY-1].ToString();
			_head_lasting_method     = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxLASTING_ME-1].ToString();
			_head_ms_method          = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxMS_ME-1].ToString();
			_head_sole_laying_method = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSOLE_LAYING-1].ToString();
			_head_mto_account_name   = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxMTO_ACC-1].ToString();

			_head_bom_comment        = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_COMMENT-1].ToString();
			_head_factory_dv    = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxFACTORY_DV-1].ToString();
			_head_sesn          = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSESN-1].ToString();
			_head_pattern         = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPATTERN-1].ToString();
			_head_last_cd       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxLAST_CD-1].ToString();

			_head_dev_name      = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxDEV_NAME-1].ToString();
			_head_mtl_ver       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxMTL_VER-1].ToString();
			_head_color_ver     = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxCOLOR_VER-1].ToString();
			_head_sample_types  = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSAMPLE_TYPES-1].ToString();
			_head_sta           = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSTA-1].ToString();

			_head_current_ipw = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxCURRENT_IPW-1].ToString();
			_head_product_code = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPRODUCT_CODE-1].ToString();
			_head_pur_flg       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPUR_FLG-1].ToString();
			_head_style_cd      = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSTYLE_CD-1].ToString();
			
			_head_remarks       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxREMARKS-1].ToString();

			_head_status        = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSTATUS-1].ToString();
			_head_load_upd_user = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxLOAD_UPD_USER-1].ToString();
			//_head_upd_user = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxUPD_USER-1].ToString();
			_head_upd_user = ClassLib.ComVar.This_User;


			Head_data_setting();

			return true;
		}


		private bool Set_sdd_srf_tail()
		{
			DataTable dt = null;

			//color_check = true;
			dt = Select_sdd_srf_tail();
			if(dt.Rows.Count == 0) return false;



			int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;

			fgrid_detail.Rows.Count = _RowFixed_detali;


			for(int i=0; i<dt_rows; i++)
			{
				int tree_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].ToString());
				fgrid_detail.Rows.InsertNode(fgrid_detail.Rows.Count, tree_level);

				int mat_length = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString().Length;
				int color_length = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD].ToString().Length;
				string iskname = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxISKNAME].ToString();

				if(mat_length > 0 && color_length.Equals(0))
				{
					fgrid_detail.Rows[fgrid_detail.Rows.Count-1].StyleNew.BackColor =  Color.Bisque;
					//color_check = true;
				}


				if(!iskname.Equals("0"))
				{
					fgrid_detail.GetCellRange(fgrid_detail.Rows.Count-1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC, 
						fgrid_detail.Rows.Count-1,(int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC).StyleNew.ForeColor = Color.FromArgb(149,153,223);
					fgrid_detail.GetCellRange(fgrid_detail.Rows.Count-1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD,
						fgrid_detail.Rows.Count-1,(int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD).StyleNew.ForeColor = Color.FromArgb(149,153,223);
					fgrid_detail.GetCellRange(fgrid_detail.Rows.Count-1, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD, 
						fgrid_detail.Rows.Count-1,(int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD).StyleNew.ForeColor = Color.FromArgb(149,153,223);
				}

				string change_r_flg = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG].ToString();

				if(change_r_flg.Equals("P"))
				{
					fgrid_detail.Rows[fgrid_detail.Rows.Count-1].StyleNew.BackColor =  Color.FromArgb(245, 173, 173);
					fgrid_detail.Rows[fgrid_detail.Rows.Count-1].AllowEditing = false;
				}
				else if(change_r_flg.Equals("D"))
				{
					fgrid_detail.Rows[fgrid_detail.Rows.Count-1].StyleNew.BackColor =  Color.FromArgb(110, 110,110);
					fgrid_detail.Rows[fgrid_detail.Rows.Count-1].AllowEditing = false;
				}








				for(int j=0; j<dt_cols; j++)
				{
					fgrid_detail[fgrid_detail.Rows.Count-1, j] = dt.Rows[i].ItemArray[j].ToString();

					if(j==(int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL)
					{
						if(!dt.Rows[i].ItemArray[j].Equals("1"))
						{
							fgrid_detail.Rows[fgrid_detail.Rows.Count-1].AllowEditing = false;
						}
					}


				}
			}

			fgrid_detail.Tree.Show(1);
			return true;
		}


		private bool Set_sdd_srf_order()
		{
			DataTable dt = null;

			dt = Select_sdd_srf_order();


			if(dt.Rows.Count == 0) return false;



			int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;

			fgrid_order.Rows.Count = _RowFixed_order;


			for(int i=0; i<dt_rows; i++)
			{
				int tree_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_ORDER.IxSRF_LEVEL].ToString());
				fgrid_order.Rows.InsertNode(fgrid_order.Rows.Count, tree_level);

				for(int j=0; j<dt_cols; j++)
				{
					fgrid_order[fgrid_order.Rows.Count-1, j] = dt.Rows[i].ItemArray[j].ToString();

					if(j.Equals((int)ClassLib.TBSXD_SRF_ORDER.IxSRF_LEVEL))
					{
						if(!dt.Rows[i].ItemArray[j].Equals("1"))
						{
							fgrid_order.Rows[fgrid_order.Rows.Count-1].AllowEditing = false;
						}
					}
				}
			}
			fgrid_order.Tree.Show(1);
			return true;
		}

        private void Type_Working()
        {
            //_Form_Type = arg_mode;


            lbl_srfpath.Visible = false;
            lbl_level.Visible = true;
            cmb_level.Enabled = false;
            cmb_gender.Enabled = false;
            cmb_sampletypes.Enabled = false;
            


            lbl_srfpath.Visible = false;
            lbl_level.Visible = true;


            lbl_srfpath.Visible = false;


            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Save.Enabled = false;
            tbtn_Search.Enabled = true;
            tbtn_Create.Enabled = false;


            fgrid_detail.AllowEditing = false;
            fgrid_order.AllowEditing = false;
            fgrid_round.AllowEditing = false;

            cmb_level.Enabled = false;
            cmb_gender.Enabled = false;


            txt_srfno.Enabled = false;
            txt_bomid.Enabled = false;
            txt_bomrev.Enabled = false;
            txt_srno.Enabled = false;
            txt_factory_direct.Enabled = false;
            txt_season.Enabled = false;
            cmb_gender.Enabled = false;
            txt_state.Enabled = false;


            txt_mtl_ver.ReadOnly = false;
            txt_colo_ver.ReadOnly = false;
            txt_patten.ReadOnly = false;
            txt_order_date.Enabled = false;




            txt_ets.Enabled = false;
            txt_need_by.Enabled = false;
            txt_current_ipw.Enabled = false;



            fgrid_detail.Set_Grid_CDC("SXD_SRF_TAIL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_detail.Set_Action_Image(img_Action);
            fgrid_detail.Font = new Font("Verdana", 8);
            _RowFixed_detali = fgrid_detail.Rows.Fixed;
            fgrid_detail.Styles.Normal.WordWrap = true;
            fgrid_detail.Tree.Column = (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_SEQ;

            fgrid_order.Set_Grid_CDC("SXD_SRF_ORDER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_order.Set_Action_Image(img_Action);
            fgrid_order.Font = new Font("Verdana", 8);
            _RowFixed_order = fgrid_order.Rows.Fixed;
            fgrid_order.Styles.Normal.WordWrap = true;
            fgrid_order.Tree.Column = (int)ClassLib.TBSXD_SRF_ORDER.IxSRF_SEQ;


            cmb_factory.Enabled = false;

            fgrid_detail.Cols.Fixed = 0;
            fgrid_detail.AllowResizing = AllowResizingEnum.Both;
        }



		private void Clear_txtbox()
		{

			txt_srno.Text           = "";
			txt_srfno.Text          = "";
			txt_bomid.Text          = "";
			txt_bomrev.Text         = "";


			txt_bom_comments.Text   = "";
			txt_season.Text         = "";
			//cmb_sampletypes.Text    = "";
			txt_factory_direct.Text = "";
			txt_bom_state.Text      = "";
			txt_last_cd.Text      = "";
			txt_colo_ver.Text    = "";
			txt_style_cd.Text    = "";
			txt_patten.Text     = "";

			txt_model_name_bom.Text = "";
			txt_last_cd.Text = "";


			
			txt_whq_plm.Text           = "";
			txt_whq_dev.Text           = "";
			txt_nlo_dev.Text           = "";

			txt_bom_state.Text         = "";
			txt_silhouette.Text      = "";
			txt_technology.Text       = "";

			txt_lasting_method.Text    = "";
			txt_ms_method.Text         = "";
			txt_sole_laying_method.Text = "";
			txt_mto_account_name.Text   = "";
			txt_bom_comments.Text      = "";
			

			txt_model_name.Text= "";
			txt_mo_id.Text   = "";
			txt_requestor.Text = "";

			txt_mo_alias.Text = "";


			//txt_current_ipw.Text = "";
			txt_product_code.Text = "";



			txt_srno.Text                 = "";
			txt_srfno.Text                = "";
			txt_bomid.Text                = "";
			txt_bomrev.Text               = "";
		}


		private string char_con(string arg_data)
		{
			string aa_div = "^";
			bool tmp_replace = false;
			string data_tmp = "";

			if(arg_data != null)
			{

				for(int i=0; i<arg_data.Length; i++)
				{

					string aa = arg_data.Substring(i,1);
				
					if(arg_data.Substring(i,1) == aa_div.ToString())
					{
						if(tmp_replace) tmp_replace= false;
						else tmp_replace= true;
					}	

					if(!tmp_replace) data_tmp += arg_data.Substring(i,1).Replace(",","$");
					else data_tmp += arg_data.Substring(i,1);
				}
			}

			return data_tmp;
		}


		private void Head_data_setting()
		{
			//Clear_txtbox();
			_head_factory        = cmb_factory.SelectedValue.ToString();
			txt_srno.Text        = _head_sr_no;
			txt_srfno.Text       = _head_srf_no;
			txt_bomid.Text       = _head_bom_id;
			txt_bomrev.Text      = _head_bom_rev;

			txt_state.Text = _head_sta;


			txt_bom_comments.Text    = _head_bom_comment;
			txt_season.Text      = _head_sesn;
			//cmb_sampletypes.SelectedValue = _head_nf_cd;
			//cmb_sampletypes.SelectedIndex
			txt_factory_direct.Text   = _head_factory_dv;
			txt_bom_state.Text         = _head_sta;
			
			txt_colo_ver.Text    = _head_color_ver;
			txt_style_cd.Text    = _head_style_cd;
			txt_patten.Text     = _head_pattern;

			txt_model_name_bom.Text = _head_dev_name;
			txt_last_cd.Text = _head_last_cd;


			
			txt_whq_plm.Text           = _head_whq_plm;
			txt_whq_dev.Text           = _head_whq_dev;
			txt_nlo_dev.Text           = _head_nlo_dev;

			txt_bom_state.Text         = _head_bom_state;
			txt_silhouette.Text       = _head_silhouette;
			txt_technology.Text       = _head_technology;

			txt_lasting_method.Text    = _head_lasting_method;
			txt_ms_method.Text         = _head_ms_method;
			txt_sole_laying_method.Text = _head_sole_laying_method;
			txt_mto_account_name.Text   = _head_mto_account_name;
			txt_bom_comments.Text      = _head_bom_comment;
			

			txt_model_name.Text = _head_dev_name;
			txt_mo_id.Text   = _head_mo_alias;
			txt_requestor.Text = _head_requestor;

			txt_mo_alias.Text = _head_mo_alias;


			//txt_current_ipw.Text = _head_current_ipw;
			txt_product_code.Text = _head_product_code;

			txt_mtl_ver.Text = _head_mtl_ver;


			try
			{
				txt_order_date.CustomFormat = dateType;
				txt_order_date.Text = comfunction.ConvertDate2Type(_head_ord_ymd);
			}
			catch
			{
				txt_order_date.CustomFormat = " ";
			}


			try
			{
				txt_need_by.CustomFormat = dateType;
				txt_need_by.Text = comfunction.ConvertDate2Type(_head_need_by);
			}
			catch
			{
				txt_need_by.CustomFormat = " ";
			}




			try
			{

                txt_ets.CustomFormat = dateType;
                txt_ets.Text = comfunction.ConvertDate2Type(_head_ets);

			}
			catch
			{
				txt_ets.CustomFormat = " ";
			}


			try
			{
				txt_current_ipw.CustomFormat = dateType;
				txt_current_ipw.Text = comfunction.ConvertDate2Type(_head_current_ipw);
			}
			catch
			{
				txt_current_ipw.CustomFormat = " ";
			}

   

            //cmb_gender.Text = _gen;
            //cmb_gender.SelectedValue = _cs_gend;

           


          
		}


		public void Select_srf_maxseq(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
		{

			DataTable dt = null;
			dt = Select_sdd_srf_seq(arg_factory, arg_sr_no, arg_srf_no, arg_bom_id, arg_bom_rev, arg_nf_cd);
			ClassLib.ComCtl.Set_ComboList(dt, cmb_level, 0, 0, false, false);
			if(dt.Rows.Count.Equals(0))
			{
				cmb_level.SelectedIndex = -1;
			}
			else
			{
				cmb_level.SelectedIndex = 0;
			}
		}

		


		private void Set_sdd_srf_vendor()
		{
			DataTable dt = null;
			dt =Select_SDD_SRF_VENDOR();

			int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;

			fgrid_round.Rows.Count = _RowFixed_vendor;

			for(int i=0; i<dt_rows; i++)
			{
				fgrid_round.AddItem(dt.Rows[i].ItemArray, fgrid_round.Rows.Count,1);
			}

			fgrid_round.AllowMerging = AllowMergingEnum.Free;

			for( int i=0; i<fgrid_round.Cols.Count; i++)
			{
				if(i == 7 || i== 8 || i== 9)
					fgrid_round.Cols[i].AllowMerging = true;
				else
					fgrid_round.Cols[i].AllowMerging = false;
			}

			fgrid_round.AutoSizeCols();
		}



		#endregion 

		#region 공통이벤트
		
		#region 버튼관련 	
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_sampletypes.SelectedValue == null)
                {
                    ClassLib.ComFunction.User_Message("Input Error : Round Type", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (txt_srno.Text.Trim().Length.Equals(0))
                {
                    ClassLib.ComFunction.User_Message("Input Error : SR No", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }




                Thread vCreate = new Thread(new ThreadStart(Open_waiting_Form));
                vCreate.Start();

                
                tbtn_Search.Enabled = false;
                this.Enabled = false;



                if (Set_sdd_srf_head())
                {
                    if (Set_sdd_srf_tail())
                    {
                        Set_sdd_srf_order();
                        Set_sdd_srf_vendor();
                    }
                }

                
                this.Enabled = true;
                tbtn_Search.Enabled = true;
                vCreate.Abort();

            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
			
		
		}
		#endregion 

        #region Control Event


        #endregion

        #endregion

        #region  DB컨넥트

        #region Select 관련

        private DataTable Select_sdc_nf_desc()
        {
            string Proc_Name = "pkg_sxd_srf_00_select.select_sxb_nf_desc";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private DataTable Select_sdd_srf_seq(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_HEAD_SEQ";

            OraDB.ReDim_Parameter(7);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SR_NO";
            OraDB.Parameter_Name[2] = "ARG_SRF_NO";
            OraDB.Parameter_Name[3] = "ARG_BOM_ID";
            OraDB.Parameter_Name[4] = "ARG_BOM_REV";
            OraDB.Parameter_Name[5] = "ARG_NF_CD";
            OraDB.Parameter_Name[6] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_sr_no;
            OraDB.Parameter_Values[2] = arg_srf_no;
            OraDB.Parameter_Values[3] = arg_bom_id;
            OraDB.Parameter_Values[4] = arg_bom_rev;
            OraDB.Parameter_Values[5] = arg_nf_cd;
            OraDB.Parameter_Values[6] = "";

            OraDB.Add_Select_Parameter(true);



            COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();
            if (COM.ComVar.This_Factory == "QD")
                COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;

            if (COM.ComVar.This_Factory == "VJ")
                COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        //private DataTable Select_sdd_srf_tail_copy()
        //{
        //    string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_TAIL_COPY";

        //    OraDB.ReDim_Parameter(8);
        //    OraDB.Process_Name = Proc_Name;

        //    OraDB.Parameter_Name[0] = "ARG_FACTORY";
        //    OraDB.Parameter_Name[1] = "ARG_SR_NO";
        //    OraDB.Parameter_Name[2] = "ARG_SRF_NO";
        //    OraDB.Parameter_Name[3] = "ARG_BOM_ID";
        //    OraDB.Parameter_Name[4] = "ARG_BOM_REV";
        //    OraDB.Parameter_Name[5] = "ARG_NF_CD";
        //    OraDB.Parameter_Name[6] = "ARG_SRF_SEQ";
        //    OraDB.Parameter_Name[7] = "OUT_CURSOR";

        //    OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[7] = (int)OracleType.Cursor;

        //    OraDB.Parameter_Values[0] = _head_factory;
        //    OraDB.Parameter_Values[1] = _head_sr_no;
        //    OraDB.Parameter_Values[2] = _head_srf_no;
        //    OraDB.Parameter_Values[3] = _head_bom_id;
        //    OraDB.Parameter_Values[4] = _head_bom_rev;
        //    OraDB.Parameter_Values[5] = _head_nf_cd;
        //    OraDB.Parameter_Values[6] = "000";
        //    OraDB.Parameter_Values[7] = "";

        //    OraDB.Add_Select_Parameter(true);
        //    DataSet DS_Ret = OraDB.Exe_Select_Procedure();

        //    if (DS_Ret == null) return null;

        //    return DS_Ret.Tables[Proc_Name];
        //}

        //private DataTable Select_sdd_srf_order_copy()
        //{
        //    string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_ORDER_COPY";

        //    OraDB.ReDim_Parameter(8);
        //    OraDB.Process_Name = Proc_Name;

        //    OraDB.Parameter_Name[0] = "ARG_FACTORY";
        //    OraDB.Parameter_Name[1] = "ARG_SR_NO";
        //    OraDB.Parameter_Name[2] = "ARG_SRF_NO";
        //    OraDB.Parameter_Name[3] = "ARG_BOM_ID";
        //    OraDB.Parameter_Name[4] = "ARG_BOM_REV";
        //    OraDB.Parameter_Name[5] = "ARG_NF_CD";
        //    OraDB.Parameter_Name[6] = "ARG_SRF_SEQ";
        //    OraDB.Parameter_Name[7] = "OUT_CURSOR";

        //    OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[7] = (int)OracleType.Cursor;

        //    OraDB.Parameter_Values[0] = _head_factory;
        //    OraDB.Parameter_Values[1] = _head_sr_no;
        //    OraDB.Parameter_Values[2] = _head_srf_no;
        //    OraDB.Parameter_Values[3] = _head_bom_id;
        //    OraDB.Parameter_Values[4] = _head_bom_rev;
        //    OraDB.Parameter_Values[5] = _head_nf_cd;
        //    OraDB.Parameter_Values[6] = "000";
        //    OraDB.Parameter_Values[7] = "";

        //    OraDB.Add_Select_Parameter(true);
        //    DataSet DS_Ret = OraDB.Exe_Select_Procedure();

        //    if (DS_Ret == null) return null;

        //    return DS_Ret.Tables[Proc_Name];
        //}

        //private string Select_gen_size()
        //{
        //    string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_GEN_SIZE_CD";

        //    OraDB.ReDim_Parameter(3);
        //    OraDB.Process_Name = Proc_Name;

        //    OraDB.Parameter_Name[0] = "ARG_FACTORY";
        //    OraDB.Parameter_Name[1] = "ARG_GEN_CD";
        //    OraDB.Parameter_Name[2] = "OUT_CURSOR";

        //    OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

        //    OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
        //    OraDB.Parameter_Values[1] = cmb_gender.SelectedValue.ToString();
        //    OraDB.Parameter_Values[2] = "";

        //    OraDB.Add_Select_Parameter(true);
        //    DataSet DS_Ret = OraDB.Exe_Select_Procedure();

        //    if (DS_Ret == null) return null;

        //    return DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString();
        //}

        private DataTable Select_sdd_srf_head()
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_HEAD";

            OraDB.ReDim_Parameter(8);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SR_NO";
            OraDB.Parameter_Name[2] = "ARG_SRF_NO";
            OraDB.Parameter_Name[3] = "ARG_BOM_ID";
            OraDB.Parameter_Name[4] = "ARG_BOM_REV";
            OraDB.Parameter_Name[5] = "ARG_NF_CD";
            OraDB.Parameter_Name[6] = "ARG_SRF_SEQ";
            OraDB.Parameter_Name[7] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_srno.Text.Trim();
            OraDB.Parameter_Values[2] = txt_srfno.Text.Trim();
            OraDB.Parameter_Values[3] = txt_bomid.Text.Trim();
            OraDB.Parameter_Values[4] = txt_bomrev.Text.Trim();
            OraDB.Parameter_Values[5] = cmb_sampletypes.SelectedValue.ToString();
            OraDB.Parameter_Values[6] = cmb_level.SelectedValue.ToString();
            OraDB.Parameter_Values[7] = "";

            OraDB.Add_Select_Parameter(true);

            COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (COM.ComVar.This_Factory == "QD")
                COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;

            if (COM.ComVar.This_Factory == "VJ")
                COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private DataTable Select_sdd_srf_tail()
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_TAIL";

            OraDB.ReDim_Parameter(8);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SR_NO";
            OraDB.Parameter_Name[2] = "ARG_SRF_NO";
            OraDB.Parameter_Name[3] = "ARG_BOM_ID";
            OraDB.Parameter_Name[4] = "ARG_BOM_REV";
            OraDB.Parameter_Name[5] = "ARG_NF_CD";
            OraDB.Parameter_Name[6] = "ARG_SRF_SEQ";
            OraDB.Parameter_Name[7] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_srno.Text.Trim();
            OraDB.Parameter_Values[2] = txt_srfno.Text.Trim();
            OraDB.Parameter_Values[3] = txt_bomid.Text.Trim();
            OraDB.Parameter_Values[4] = txt_bomrev.Text.Trim();
            OraDB.Parameter_Values[5] = cmb_sampletypes.SelectedValue.ToString();
            OraDB.Parameter_Values[6] = cmb_level.SelectedValue.ToString();
            OraDB.Parameter_Values[7] = "";

            OraDB.Add_Select_Parameter(true);

            COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();
            if (COM.ComVar.This_Factory == "QD")
                COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;

            if (COM.ComVar.This_Factory == "VJ")
                COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private DataTable Select_sdd_srf_order()
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_ORDER";

            OraDB.ReDim_Parameter(8);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SR_NO";
            OraDB.Parameter_Name[2] = "ARG_SRF_NO";
            OraDB.Parameter_Name[3] = "ARG_BOM_ID";
            OraDB.Parameter_Name[4] = "ARG_BOM_REV";
            OraDB.Parameter_Name[5] = "ARG_NF_CD";
            OraDB.Parameter_Name[6] = "ARG_SRF_SEQ";
            OraDB.Parameter_Name[7] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_srno.Text.Trim();
            OraDB.Parameter_Values[2] = txt_srfno.Text.Trim();
            OraDB.Parameter_Values[3] = txt_bomid.Text.Trim();
            OraDB.Parameter_Values[4] = txt_bomrev.Text.Trim();
            OraDB.Parameter_Values[5] = cmb_sampletypes.SelectedValue.ToString();
            OraDB.Parameter_Values[6] = cmb_level.SelectedValue.ToString();
            OraDB.Parameter_Values[7] = "";

            OraDB.Add_Select_Parameter(true);

            COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();
            if (COM.ComVar.This_Factory == "QD")
                COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;

            if (COM.ComVar.This_Factory == "VJ")
                COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        //private DataTable Select_sdd_srf_spec_check(string arg_pcc_unit, string arg_pcc_spec)
        //{
        //    string Proc_Name = "pkg_sxd_srf_03_select.select_sdd_srf_spec_check";

        //    OraDB.ReDim_Parameter(4);
        //    OraDB.Process_Name = Proc_Name;

        //    OraDB.Parameter_Name[0] = "arg_factory";
        //    OraDB.Parameter_Name[1] = "arg_pcc_unit";
        //    OraDB.Parameter_Name[2] = "arg_pcc_spec";
        //    OraDB.Parameter_Name[3] = "out_cursor";

        //    OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

        //    OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
        //    OraDB.Parameter_Values[1] = arg_pcc_unit;
        //    OraDB.Parameter_Values[2] = arg_pcc_spec;
        //    OraDB.Parameter_Values[3] = "";

        //    OraDB.Add_Select_Parameter(true);
        //    DataSet DS_Ret = OraDB.Exe_Select_Procedure();

        //    if (DS_Ret == null) return null;

        //    return DS_Ret.Tables[Proc_Name];
        //}

        //private DataTable Check_sxd_srf_head()
        //{
        //    string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_HEAD_CHECK";

        //    OraDB.ReDim_Parameter(7);
        //    OraDB.Process_Name = Proc_Name;

        //    OraDB.Parameter_Name[0] = "ARG_FACTORY";
        //    OraDB.Parameter_Name[1] = "ARG_SR_NO";
        //    OraDB.Parameter_Name[2] = "ARG_SRF_NO";
        //    OraDB.Parameter_Name[3] = "ARG_BOM_ID";
        //    OraDB.Parameter_Name[4] = "ARG_BOM_REV";
        //    OraDB.Parameter_Name[5] = "ARG_NF_CD";
        //    OraDB.Parameter_Name[6] = "OUT_CURSOR";

        //    OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[6] = (int)OracleType.Cursor;

        //    OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
        //    OraDB.Parameter_Values[1] = txt_srno.Text.Trim();
        //    OraDB.Parameter_Values[2] = txt_srfno.Text.Trim();
        //    OraDB.Parameter_Values[3] = txt_bomid.Text.Trim();
        //    OraDB.Parameter_Values[4] = txt_bomrev.Text.Trim();
        //    OraDB.Parameter_Values[5] = cmb_sampletypes.SelectedValue.ToString();
        //    OraDB.Parameter_Values[6] = "";

        //    OraDB.Add_Select_Parameter(true);
        //    DataSet DS_Ret = OraDB.Exe_Select_Procedure();

        //    if (DS_Ret == null) return null;

        //    return DS_Ret.Tables[Proc_Name];
        //}

        //private DataTable Select_sdd_srf_nf_cd_check(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
        //{
        //    string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_NF_CD_CHECK";

        //    OraDB.ReDim_Parameter(7);
        //    OraDB.Process_Name = Proc_Name;

        //    OraDB.Parameter_Name[0] = "ARG_FACTORY";
        //    OraDB.Parameter_Name[1] = "ARG_SR_NO";
        //    OraDB.Parameter_Name[2] = "ARG_SRF_NO";
        //    OraDB.Parameter_Name[3] = "ARG_BOM_ID";
        //    OraDB.Parameter_Name[4] = "ARG_BOM_REV";
        //    OraDB.Parameter_Name[5] = "ARG_NF_CD";
        //    OraDB.Parameter_Name[6] = "OUT_CURSOR";

        //    OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[6] = (int)OracleType.Cursor;

        //    OraDB.Parameter_Values[0] = arg_factory;
        //    OraDB.Parameter_Values[1] = arg_sr_no;
        //    OraDB.Parameter_Values[2] = arg_srf_no;
        //    OraDB.Parameter_Values[3] = arg_bom_id;
        //    OraDB.Parameter_Values[4] = arg_bom_rev;
        //    OraDB.Parameter_Values[5] = arg_nf_cd;
        //    OraDB.Parameter_Values[6] = "";

        //    OraDB.Add_Select_Parameter(true);
        //    DataSet DS_Ret = OraDB.Exe_Select_Procedure();

        //    if (DS_Ret == null) return null;

        //    return DS_Ret.Tables[Proc_Name];
        //}

        private DataTable Select_SDD_SRF_VENDOR()
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_VENDOR";

            OraDB.ReDim_Parameter(7);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_sr_no";
            OraDB.Parameter_Name[2] = "arg_srf_no";
            OraDB.Parameter_Name[3] = "arg_bom_id";
            OraDB.Parameter_Name[4] = "arg_bom_rev";
            OraDB.Parameter_Name[5] = "arg_nf_cd";
            OraDB.Parameter_Name[6] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_srno.Text;
            OraDB.Parameter_Values[2] = txt_srfno.Text;
            OraDB.Parameter_Values[3] = txt_bomid.Text;
            OraDB.Parameter_Values[4] = txt_bomrev.Text;
            OraDB.Parameter_Values[5] = cmb_sampletypes.SelectedValue.ToString();
            OraDB.Parameter_Values[6] = "";

            OraDB.Add_Select_Parameter(true);

            COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();
            if (COM.ComVar.This_Factory == "QD")
                COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;

            if (COM.ComVar.This_Factory == "VJ")
                COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        //private DataTable Select_sdc_nf_desc_ss(string arg_nf_div)
        //{
        //    string Proc_Name = "PKG_SXD_SRF_00_SELECT.select_sxb_nf_desc_ss";

        //    OraDB.ReDim_Parameter(3);
        //    OraDB.Process_Name = Proc_Name;

        //    OraDB.Parameter_Name[0] = "arg_factory";
        //    OraDB.Parameter_Name[1] = "arg_nf_div";
        //    OraDB.Parameter_Name[2] = "OUT_CURSOR";

        //    OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //    OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

        //    OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
        //    OraDB.Parameter_Values[1] = arg_nf_div;
        //    OraDB.Parameter_Values[2] = "";

        //    OraDB.Add_Select_Parameter(true);
        //    DataSet DS_Ret = OraDB.Exe_Select_Procedure();

        //    if (DS_Ret == null) return null;

        //    return DS_Ret.Tables[Proc_Name];
        //}
        
        #endregion

    

		#endregion 

		private void Form_Bom_Editer_In_DS_Load(object sender, System.EventArgs e)
		{
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
			ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            cmb_factory.SelectedValue = "DS";
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{

			if(cmb_factory.SelectedIndex == -1) return;
			Init_Form();
		}

        private void Open_waiting_Form()
        {
            _pop = new FlexCDC.BaseInfo.Pop_BS_Shipping_List_Wait();
            _pop.Searching_Start();
        }

        private void fgrid_detail_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (show_head)
                {
                    tab_control.Location = new Point(8, 162);
                    tab_control.Height = tab_control.Height + (384 - 162);
                    show_head = false;
                }
                else
                {
                    tab_control.Location = new Point(8, 384);
                    tab_control.Height = tab_control.Height - (384 - 162);
                    show_head = true;
                }
            }
        }

       
     

	}
}

