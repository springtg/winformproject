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

namespace FlexCDC.CDC_Bom
{
	public class Form_Bom_Editer : COM.PCHWinForm.Form_Top
	{
		#region 컨트롤정의 및 리소스 정의
		private System.Windows.Forms.ImageList
            img_MiniButton;
		private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.TabControl tab_control;
		private System.Windows.Forms.TabPage srf_tail;
		private COM.FSP fgrid_desc;
		public COM.FSP fgrid_detail;
		private System.Windows.Forms.TabPage srf_order;
		private COM.FSP fgrid_order;
        private System.Windows.Forms.TabPage srf_vendor;
		private System.Windows.Forms.ContextMenu cmenu;
		private System.Windows.Forms.MenuItem mnu_copy_record;
		private System.Windows.Forms.MenuItem mnu_copy_specunit;
		private System.Windows.Forms.MenuItem mnu_edit_spec;
		private System.Windows.Forms.MenuItem mnu_sep_01;
		private System.Windows.Forms.MenuItem mnu_insert_record;
		private System.Windows.Forms.MenuItem mnu_delete_record;
		private System.Windows.Forms.MenuItem mnu_sep_02;
		private System.Windows.Forms.MenuItem mnu_pending;
		private System.Windows.Forms.MenuItem mnu_release;
        private COM.FSP fgrid_vendor;
		private System.Windows.Forms.MenuItem mnu_sep_03;
		private System.Windows.Forms.MenuItem mnu_multi_change;
		private System.Windows.Forms.MenuItem mnu_multi_corfirm;
		private System.Windows.Forms.ContextMenu cmenu_order;
		private System.Windows.Forms.MenuItem mnu_change_order;
		private System.Windows.Forms.MenuItem mnt_Confirm_Order;
        private MenuItem mnu_update_record;
        private MenuItem mnu_sep_04;
        private Panel pnl_total;
        private Panel pnl_grid;
        public Panel pnl_middle;
        private DateTimePicker dtp_current_ipw;
        private TextBox txt_mto_account_name;
        private Label lbl_mto_account;
        private TextBox txt_technology;
        private TextBox txt_sole_laying_method;
        private TextBox txt_bom_state;
        private TextBox txt_mtl_ver;
        private TextBox txt_nlo_dev;
        private Label lbl_nlo_dev;
        private TextBox txt_season;
        private Label lbl_whq_dev;
        private TextBox txt_whq_plm;
        private Label lbl_whq_plm;
        private TextBox txt_mo_alias;
        private Label lbl_season;
        private TextBox txt_whq_dev;
        private Label lbl_mo_alias;
        private Label lbl_product_code;
        private TextBox txt_model_name_bom;
        private TextBox txt_ms_method;
        private Label lbl_last_cd;
        private TextBox txt_product_code;
        private Label lbl_current_ipw;
        private TextBox txt_lasting_method;
        private TextBox txt_colo_ver;
        private TextBox txt_last_cd;
        private TextBox txt_silhouette;
        private Label lbl_sole_laying_me;
        private Label lbl_colo_ver;
        private Label lbl_mtl_ver;
        private Label lbl_silhouette;
        private Label lbl_ms_method;
        private Label lbl_lasting_method;
        private Label lbl_model_name_bom;
        private Label lbl_technology;
        private TextBox txt_bom_comments;
        private Label lbl_bom_comments;
        private Label lbl_bom_state;
        public Panel pnl_SearchImage;
        private Label btn_openfile;
        public PictureBox picb_MR;
        public PictureBox pictureBox2;
        public PictureBox pictureBox3;
        public Label lbl_title;
        public PictureBox pictureBox4;
        public PictureBox pictureBox5;
        public PictureBox pictureBox6;
        public PictureBox pictureBox7;
        public PictureBox pictureBox8;
        public PictureBox pictureBox9;
        public Panel panel5;
        private Label label5;
        public PictureBox pictureBox27;
        public PictureBox pictureBox28;
        public PictureBox pictureBox29;
        public Label label6;
        public PictureBox pictureBox30;
        public PictureBox pictureBox31;
        public PictureBox pictureBox32;
        public PictureBox pictureBox33;
        public PictureBox pictureBox34;
        public PictureBox pictureBox35;
        public Panel panel4;
        private Label label10;
        public PictureBox pictureBox18;
        public PictureBox pictureBox19;
        public PictureBox pictureBox20;
        public Label label11;
        public PictureBox pictureBox21;
        public PictureBox pictureBox22;
        public PictureBox pictureBox23;
        public PictureBox pictureBox24;
        public PictureBox pictureBox25;
        public PictureBox pictureBox26;
        public Panel pnl_top;
        private Label lbl_Style_Cd;
        private Label btn_open_file;
        private C1.Win.C1List.C1Combo cmb_gender;
        private Label lbl_gender;
        private TextBox txt_patten;
        private Label lbl_patten;
        private TextBox txt_style_cd;
        private Label lbl_need_by;
        private DateTimePicker dtp_need_by;
        private Label lbl_ets;
        private DateTimePicker dtp_ets;
        private Label lbl_order_date;
        private DateTimePicker dtp_order_date;
        private TextBox txt_requestor;
        private Label lbl_requestor;
        private TextBox txt_state;
        private Label lbl_state;
        private TextBox txt_factory_direct;
        private Label lbl_factory_direct;
        private TextBox txt_mo_id;
        private Label lbl_mo_id;
        private TextBox txt_model_name;
        private Label lbl_model_name;
        private C1.Win.C1List.C1Combo cmb_sampletypes;
        private Label lbl_sampletypes;
        public C1.Win.C1List.C1Combo cmb_level;
        private Label lbl_level;
        private TextBox txt_srno;
        private Label lbl_srno;
        private TextBox txt_srfno;
        private Label lbl_srfno;
        private TextBox txt_bomrev;
        private TextBox txt_bomid;
        private Label lbl_bom;
        private TextBox txt_Path;
        private Label lbl_srfpath;
        private C1.Win.C1List.C1Combo cmb_factory;
        private Label lbl_factory;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        public Panel panel3;
        private C1.Win.C1List.C1Combo cmb_td;
        private Label lbl_td;
        private Label lbl_mrp;
        private Label lbl_delete;
        private Label lbl_pend;
        private Label lbl_part;
        private Label label1;
        public PictureBox pictureBox1;
        public PictureBox pictureBox10;
        public PictureBox pictureBox11;
        public Label lbl_srf_info;
        public PictureBox pictureBox12;
        public PictureBox pictureBox13;
        public PictureBox pictureBox14;
        public PictureBox pictureBox15;
        public PictureBox pictureBox16;
        public PictureBox pictureBox17;
        public Panel pnl_bottom;
        private TextBox txt_platform;
        private TextBox txt_inline_size;
        private TextBox txt_sr_instruction;
        private TextBox txt_costmat_tfob;
        private TextBox txt_costmat_duty;
        private Label lbl_costmat_tfob;
        private Label lbl_costmat_duty;
        private Label lbl_costmat_name;
        private TextBox txt_last_dim;
        private TextBox txt_prod_id;
        private Label lbl_promo_size;
        private TextBox txt_costmat_name;
        private Label lbl_costmat_type;
        private TextBox txt_bom_method;
        private TextBox txt_promo_size;
        private TextBox txt_demension;
        private Label lbl_inline_size;
        private Label lbl_bom_dimension;
        private Label lbl_product_id;
        private Label lbl_bom_method;
        private Label lbl_last_dim;
        private Label lbl_platform;
        private Label lbl_sr_instreuction;
        public Panel panel6;
        private TextBox txt_extra_color;
        private Label lbl_extra_color;
        private TextBox txt_s_prod_fact;
        private Label lbl_s_prod_fact;
        private Label lbl_p_prod_fact;
        private TextBox txt_ss_factory;
        private Label lbl_ss_factory;
        private TextBox txt_pcc_factory;
        private Label lbl_pcc_factory;
        private Label lbl_cons_focus;
        private Label lbl_biz_org;
        private TextBox txt_cons_use;
        private TextBox txt_cons_focus;
        private Label lbl_cons_use;
        private TextBox txt_biz_org;
        private TextBox txt_costmat_type;
        private TextBox txt_plm;
        private Label label25;
        private Label lbl_plm;
        public PictureBox pictureBox36;
        public PictureBox pictureBox37;
        private Label lbl_td_code;
        public PictureBox pictureBox38;
        private TextBox txt_devproj_id;
        private TextBox txt_cons_purpose;
        public Label label26;
        private Label lbl_dev_proj_id;
        public PictureBox pictureBox39;
        private Label lnl_cons_purpose;
        private TextBox txt_td_code;
        public PictureBox pictureBox41;
        public PictureBox pictureBox42;
        public PictureBox pictureBox44;
        public PictureBox pictureBox43;
        public PictureBox pictureBox40;
        public Panel panel7;
        private Label label27;
        public PictureBox pictureBox45;
        public PictureBox pictureBox46;
        public PictureBox pictureBox47;
        public Label label28;
        public PictureBox pictureBox48;
        public PictureBox pictureBox49;
        public PictureBox pictureBox50;
        public PictureBox pictureBox51;
        public PictureBox pictureBox52;
        public PictureBox pictureBox53;
        public Panel panel8;
        private Label label29;
        public PictureBox pictureBox54;
        public PictureBox pictureBox55;
        public PictureBox pictureBox56;
        public Label label30;
        public PictureBox pictureBox57;
        public PictureBox pictureBox58;
        public PictureBox pictureBox59;
        public PictureBox pictureBox60;
        public PictureBox pictureBox61;
        public PictureBox pictureBox62;
        private TabPage srf_rule;
        private COM.FSP fgrid_rule;
        private C1.Win.C1List.C1Combo cmb_category;
        private Label lbl_category;
        private C1.Win.C1List.C1Combo cmb_p_prod_fact;
        private C1.Win.C1List.C1Combo cmb_spc_yn;
        private Label lbl_spc_yn;
        private CheckBox chk_gtm_2nd;
        private CheckBox chk_gtm_1st;
        private Label lbl_marketing;
        private TextBox txt_marketing;
        private TextBox txt_pupuck_desc;
        private Label lbl_pupuck_desc;
        private C1.Win.C1List.C1Combo cmb_pupuck_yn;
        private Label lbl_pu_puck;
        private C1.Win.C1List.C1Combo cmb_offshore;
        private Label lbl_offshore;
        private MenuItem mnu_combine;		

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bom_Editer));
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
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.srf_tail = new System.Windows.Forms.TabPage();
            this.fgrid_desc = new COM.FSP();
            this.fgrid_detail = new COM.FSP();
            this.cmenu = new System.Windows.Forms.ContextMenu();
            this.mnu_copy_record = new System.Windows.Forms.MenuItem();
            this.mnu_copy_specunit = new System.Windows.Forms.MenuItem();
            this.mnu_edit_spec = new System.Windows.Forms.MenuItem();
            this.mnu_sep_01 = new System.Windows.Forms.MenuItem();
            this.mnu_insert_record = new System.Windows.Forms.MenuItem();
            this.mnu_update_record = new System.Windows.Forms.MenuItem();
            this.mnu_delete_record = new System.Windows.Forms.MenuItem();
            this.mnu_sep_02 = new System.Windows.Forms.MenuItem();
            this.mnu_pending = new System.Windows.Forms.MenuItem();
            this.mnu_release = new System.Windows.Forms.MenuItem();
            this.mnu_sep_03 = new System.Windows.Forms.MenuItem();
            this.mnu_multi_change = new System.Windows.Forms.MenuItem();
            this.mnu_multi_corfirm = new System.Windows.Forms.MenuItem();
            this.mnu_sep_04 = new System.Windows.Forms.MenuItem();
            this.mnu_combine = new System.Windows.Forms.MenuItem();
            this.srf_order = new System.Windows.Forms.TabPage();
            this.fgrid_order = new COM.FSP();
            this.cmenu_order = new System.Windows.Forms.ContextMenu();
            this.mnu_change_order = new System.Windows.Forms.MenuItem();
            this.mnt_Confirm_Order = new System.Windows.Forms.MenuItem();
            this.srf_vendor = new System.Windows.Forms.TabPage();
            this.fgrid_vendor = new COM.FSP();
            this.srf_rule = new System.Windows.Forms.TabPage();
            this.fgrid_rule = new COM.FSP();
            this.pnl_total = new System.Windows.Forms.Panel();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.txt_platform = new System.Windows.Forms.TextBox();
            this.txt_inline_size = new System.Windows.Forms.TextBox();
            this.txt_sr_instruction = new System.Windows.Forms.TextBox();
            this.txt_costmat_tfob = new System.Windows.Forms.TextBox();
            this.txt_costmat_duty = new System.Windows.Forms.TextBox();
            this.lbl_costmat_tfob = new System.Windows.Forms.Label();
            this.lbl_costmat_duty = new System.Windows.Forms.Label();
            this.lbl_costmat_name = new System.Windows.Forms.Label();
            this.txt_last_dim = new System.Windows.Forms.TextBox();
            this.txt_prod_id = new System.Windows.Forms.TextBox();
            this.lbl_promo_size = new System.Windows.Forms.Label();
            this.txt_costmat_name = new System.Windows.Forms.TextBox();
            this.lbl_costmat_type = new System.Windows.Forms.Label();
            this.txt_bom_method = new System.Windows.Forms.TextBox();
            this.txt_promo_size = new System.Windows.Forms.TextBox();
            this.txt_demension = new System.Windows.Forms.TextBox();
            this.lbl_inline_size = new System.Windows.Forms.Label();
            this.lbl_bom_dimension = new System.Windows.Forms.Label();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.lbl_bom_method = new System.Windows.Forms.Label();
            this.lbl_last_dim = new System.Windows.Forms.Label();
            this.lbl_platform = new System.Windows.Forms.Label();
            this.lbl_sr_instreuction = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_extra_color = new System.Windows.Forms.TextBox();
            this.lbl_extra_color = new System.Windows.Forms.Label();
            this.txt_s_prod_fact = new System.Windows.Forms.TextBox();
            this.lbl_s_prod_fact = new System.Windows.Forms.Label();
            this.txt_ss_factory = new System.Windows.Forms.TextBox();
            this.lbl_ss_factory = new System.Windows.Forms.Label();
            this.txt_pcc_factory = new System.Windows.Forms.TextBox();
            this.lbl_pcc_factory = new System.Windows.Forms.Label();
            this.lbl_cons_focus = new System.Windows.Forms.Label();
            this.lbl_biz_org = new System.Windows.Forms.Label();
            this.txt_cons_use = new System.Windows.Forms.TextBox();
            this.txt_cons_focus = new System.Windows.Forms.TextBox();
            this.lbl_cons_use = new System.Windows.Forms.Label();
            this.txt_biz_org = new System.Windows.Forms.TextBox();
            this.txt_costmat_type = new System.Windows.Forms.TextBox();
            this.txt_plm = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_plm = new System.Windows.Forms.Label();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.lbl_td_code = new System.Windows.Forms.Label();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.txt_devproj_id = new System.Windows.Forms.TextBox();
            this.txt_cons_purpose = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lbl_dev_proj_id = new System.Windows.Forms.Label();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.lnl_cons_purpose = new System.Windows.Forms.Label();
            this.txt_td_code = new System.Windows.Forms.TextBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.label30 = new System.Windows.Forms.Label();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pnl_middle = new System.Windows.Forms.Panel();
            this.dtp_current_ipw = new System.Windows.Forms.DateTimePicker();
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_open_file = new System.Windows.Forms.Label();
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
            this.txt_Path = new System.Windows.Forms.TextBox();
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
            this.txt_pupuck_desc = new System.Windows.Forms.TextBox();
            this.lbl_pupuck_desc = new System.Windows.Forms.Label();
            this.cmb_pupuck_yn = new C1.Win.C1List.C1Combo();
            this.lbl_pu_puck = new System.Windows.Forms.Label();
            this.cmb_offshore = new C1.Win.C1List.C1Combo();
            this.lbl_offshore = new System.Windows.Forms.Label();
            this.lbl_marketing = new System.Windows.Forms.Label();
            this.txt_marketing = new System.Windows.Forms.TextBox();
            this.txt_factory_direct = new System.Windows.Forms.TextBox();
            this.chk_gtm_2nd = new System.Windows.Forms.CheckBox();
            this.lbl_factory_direct = new System.Windows.Forms.Label();
            this.chk_gtm_1st = new System.Windows.Forms.CheckBox();
            this.cmb_spc_yn = new C1.Win.C1List.C1Combo();
            this.lbl_Style_Cd = new System.Windows.Forms.Label();
            this.lbl_spc_yn = new System.Windows.Forms.Label();
            this.cmb_gender = new C1.Win.C1List.C1Combo();
            this.cmb_p_prod_fact = new C1.Win.C1List.C1Combo();
            this.cmb_category = new C1.Win.C1List.C1Combo();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cmb_td = new C1.Win.C1List.C1Combo();
            this.lbl_td = new System.Windows.Forms.Label();
            this.txt_patten = new System.Windows.Forms.TextBox();
            this.lbl_p_prod_fact = new System.Windows.Forms.Label();
            this.lbl_mrp = new System.Windows.Forms.Label();
            this.lbl_patten = new System.Windows.Forms.Label();
            this.txt_style_cd = new System.Windows.Forms.TextBox();
            this.lbl_delete = new System.Windows.Forms.Label();
            this.lbl_pend = new System.Windows.Forms.Label();
            this.lbl_ets = new System.Windows.Forms.Label();
            this.dtp_ets = new System.Windows.Forms.DateTimePicker();
            this.lbl_need_by = new System.Windows.Forms.Label();
            this.lbl_part = new System.Windows.Forms.Label();
            this.dtp_need_by = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lbl_order_date = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.dtp_order_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_srf_info = new System.Windows.Forms.Label();
            this.txt_requestor = new System.Windows.Forms.TextBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lbl_requestor = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.txt_mo_id = new System.Windows.Forms.TextBox();
            this.lbl_model_name = new System.Windows.Forms.Label();
            this.lbl_mo_id = new System.Windows.Forms.Label();
            this.txt_model_name = new System.Windows.Forms.TextBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.tab_control.SuspendLayout();
            this.srf_tail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_desc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_detail)).BeginInit();
            this.srf_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_order)).BeginInit();
            this.srf_vendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_vendor)).BeginInit();
            this.srf_rule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_rule)).BeginInit();
            this.pnl_total.SuspendLayout();
            this.pnl_grid.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            this.pnl_middle.SuspendLayout();
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
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pupuck_yn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_offshore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_spc_yn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_p_prod_fact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_td)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
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
            this.c1ToolBar1.AccessibleName = "Tool Bar";
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
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
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
            // tbtn_Confirm
            // 
            this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
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
            // tab_control
            // 
            this.tab_control.Controls.Add(this.srf_tail);
            this.tab_control.Controls.Add(this.srf_order);
            this.tab_control.Controls.Add(this.srf_vendor);
            this.tab_control.Controls.Add(this.srf_rule);
            this.tab_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_control.Location = new System.Drawing.Point(0, 0);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1016, 108);
            this.tab_control.TabIndex = 309;
            // 
            // srf_tail
            // 
            this.srf_tail.BackColor = System.Drawing.Color.Transparent;
            this.srf_tail.Controls.Add(this.fgrid_desc);
            this.srf_tail.Controls.Add(this.fgrid_detail);
            this.srf_tail.Location = new System.Drawing.Point(4, 23);
            this.srf_tail.Name = "srf_tail";
            this.srf_tail.Size = new System.Drawing.Size(1008, 81);
            this.srf_tail.TabIndex = 0;
            this.srf_tail.Text = "Part";
            this.srf_tail.UseVisualStyleBackColor = true;
            // 
            // fgrid_desc
            // 
            this.fgrid_desc.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_desc.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_desc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fgrid_desc.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgrid_desc.Location = new System.Drawing.Point(0, 33);
            this.fgrid_desc.Name = "fgrid_desc";
            this.fgrid_desc.Rows.DefaultSize = 19;
            this.fgrid_desc.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_desc.Size = new System.Drawing.Size(1008, 48);
            this.fgrid_desc.StyleInfo = resources.GetString("fgrid_desc.StyleInfo");
            this.fgrid_desc.TabIndex = 285;
            this.fgrid_desc.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_desc_AfterEdit);
            // 
            // fgrid_detail
            // 
            this.fgrid_detail.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_detail.AutoResize = false;
            this.fgrid_detail.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_detail.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_detail.ContextMenu = this.cmenu;
            this.fgrid_detail.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_detail.Location = new System.Drawing.Point(0, 0);
            this.fgrid_detail.Name = "fgrid_detail";
            this.fgrid_detail.Rows.DefaultSize = 19;
            this.fgrid_detail.Rows.Fixed = 0;
            this.fgrid_detail.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_detail.Size = new System.Drawing.Size(1008, 28);
            this.fgrid_detail.StyleInfo = resources.GetString("fgrid_detail.StyleInfo");
            this.fgrid_detail.TabIndex = 103;
            this.fgrid_detail.Click += new System.EventHandler(this.fgrid_detail_Click);
            this.fgrid_detail.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_detail_AfterSelChange);
            this.fgrid_detail.ChangeEdit += new System.EventHandler(this.fgrid_detail_ChangeEdit);
            this.fgrid_detail.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_detail_AfterEdit);
            this.fgrid_detail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_detail_MouseDown);
            this.fgrid_detail.DoubleClick += new System.EventHandler(this.fgrid_detail_DoubleClick);
            this.fgrid_detail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgrid_detail_KeyPress);
            // 
            // cmenu
            // 
            this.cmenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_copy_record,
            this.mnu_copy_specunit,
            this.mnu_edit_spec,
            this.mnu_sep_01,
            this.mnu_insert_record,
            this.mnu_update_record,
            this.mnu_delete_record,
            this.mnu_sep_02,
            this.mnu_pending,
            this.mnu_release,
            this.mnu_sep_03,
            this.mnu_multi_change,
            this.mnu_multi_corfirm,
            this.mnu_sep_04,
            this.mnu_combine});
            // 
            // mnu_copy_record
            // 
            this.mnu_copy_record.Index = 0;
            this.mnu_copy_record.Text = "Copy Record";
            this.mnu_copy_record.Visible = false;
            this.mnu_copy_record.Click += new System.EventHandler(this.mnu_copy_record_Click);
            // 
            // mnu_copy_specunit
            // 
            this.mnu_copy_specunit.Index = 1;
            this.mnu_copy_specunit.Text = "Copy Spec/Unit";
            this.mnu_copy_specunit.Click += new System.EventHandler(this.mnu_copy_specunit_Click);
            // 
            // mnu_edit_spec
            // 
            this.mnu_edit_spec.Index = 2;
            this.mnu_edit_spec.Text = "Edit Spec";
            this.mnu_edit_spec.Visible = false;
            this.mnu_edit_spec.Click += new System.EventHandler(this.mnu_edit_spec_Click);
            // 
            // mnu_sep_01
            // 
            this.mnu_sep_01.Index = 3;
            this.mnu_sep_01.Text = "-";
            // 
            // mnu_insert_record
            // 
            this.mnu_insert_record.Index = 4;
            this.mnu_insert_record.Text = "Insert Record";
            this.mnu_insert_record.Click += new System.EventHandler(this.mnu_insert_record_Click);
            // 
            // mnu_update_record
            // 
            this.mnu_update_record.Index = 5;
            this.mnu_update_record.Text = "Update Record";
            this.mnu_update_record.Click += new System.EventHandler(this.mnu_update_record_Click);
            // 
            // mnu_delete_record
            // 
            this.mnu_delete_record.Index = 6;
            this.mnu_delete_record.Text = "Delete Record";
            this.mnu_delete_record.Click += new System.EventHandler(this.mnu_delete_record_Click);
            // 
            // mnu_sep_02
            // 
            this.mnu_sep_02.Index = 7;
            this.mnu_sep_02.Text = "-";
            // 
            // mnu_pending
            // 
            this.mnu_pending.Index = 8;
            this.mnu_pending.Text = "Pending Record";
            this.mnu_pending.Click += new System.EventHandler(this.mnu_pending_Click);
            // 
            // mnu_release
            // 
            this.mnu_release.Index = 9;
            this.mnu_release.Text = "Release Record";
            this.mnu_release.Click += new System.EventHandler(this.mnu_release_Click);
            // 
            // mnu_sep_03
            // 
            this.mnu_sep_03.Index = 10;
            this.mnu_sep_03.Text = "-";
            // 
            // mnu_multi_change
            // 
            this.mnu_multi_change.Index = 11;
            this.mnu_multi_change.Text = "Muti Change Bom";
            this.mnu_multi_change.Click += new System.EventHandler(this.mnu_multi_change_Click);
            // 
            // mnu_multi_corfirm
            // 
            this.mnu_multi_corfirm.Index = 12;
            this.mnu_multi_corfirm.Text = "Muti Confirm Bom";
            this.mnu_multi_corfirm.Click += new System.EventHandler(this.mnu_multi_corfirm_Click);
            // 
            // mnu_sep_04
            // 
            this.mnu_sep_04.Index = 13;
            this.mnu_sep_04.Text = "-";
            // 
            // mnu_combine
            // 
            this.mnu_combine.Index = 14;
            this.mnu_combine.Text = "Material Combine";
            this.mnu_combine.Click += new System.EventHandler(this.mnu_combine_Click);
            // 
            // srf_order
            // 
            this.srf_order.Controls.Add(this.fgrid_order);
            this.srf_order.Location = new System.Drawing.Point(4, 23);
            this.srf_order.Name = "srf_order";
            this.srf_order.Size = new System.Drawing.Size(1008, 105);
            this.srf_order.TabIndex = 2;
            this.srf_order.Text = "Order";
            this.srf_order.UseVisualStyleBackColor = true;
            this.srf_order.Visible = false;
            // 
            // fgrid_order
            // 
            this.fgrid_order.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_order.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_order.ContextMenu = this.cmenu_order;
            this.fgrid_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_order.Location = new System.Drawing.Point(0, 0);
            this.fgrid_order.Name = "fgrid_order";
            this.fgrid_order.Rows.DefaultSize = 19;
            this.fgrid_order.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_order.Size = new System.Drawing.Size(1008, 105);
            this.fgrid_order.StyleInfo = resources.GetString("fgrid_order.StyleInfo");
            this.fgrid_order.TabIndex = 103;
            this.fgrid_order.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_order_AfterEdit);
            this.fgrid_order.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_detail_MouseDown);
            // 
            // cmenu_order
            // 
            this.cmenu_order.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_change_order,
            this.mnt_Confirm_Order});
            // 
            // mnu_change_order
            // 
            this.mnu_change_order.Index = 0;
            this.mnu_change_order.Text = "Muti Change Order";
            this.mnu_change_order.Click += new System.EventHandler(this.mnu_change_order_Click);
            // 
            // mnt_Confirm_Order
            // 
            this.mnt_Confirm_Order.Index = 1;
            this.mnt_Confirm_Order.Text = "Muti Confirm Order";
            this.mnt_Confirm_Order.Click += new System.EventHandler(this.mnt_Confirm_Order_Click);
            // 
            // srf_vendor
            // 
            this.srf_vendor.BackColor = System.Drawing.Color.Transparent;
            this.srf_vendor.Controls.Add(this.fgrid_vendor);
            this.srf_vendor.Location = new System.Drawing.Point(4, 23);
            this.srf_vendor.Name = "srf_vendor";
            this.srf_vendor.Size = new System.Drawing.Size(1008, 105);
            this.srf_vendor.TabIndex = 1;
            this.srf_vendor.Text = "Vendor";
            this.srf_vendor.UseVisualStyleBackColor = true;
            this.srf_vendor.Visible = false;
            // 
            // fgrid_vendor
            // 
            this.fgrid_vendor.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_vendor.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_vendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_vendor.Location = new System.Drawing.Point(0, 0);
            this.fgrid_vendor.Name = "fgrid_vendor";
            this.fgrid_vendor.Rows.DefaultSize = 19;
            this.fgrid_vendor.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_vendor.Size = new System.Drawing.Size(1008, 105);
            this.fgrid_vendor.StyleInfo = resources.GetString("fgrid_vendor.StyleInfo");
            this.fgrid_vendor.TabIndex = 103;
            this.fgrid_vendor.DoubleClick += new System.EventHandler(this.fgrid_vendor_DoubleClick);
            // 
            // srf_rule
            // 
            this.srf_rule.Controls.Add(this.fgrid_rule);
            this.srf_rule.Location = new System.Drawing.Point(4, 23);
            this.srf_rule.Name = "srf_rule";
            this.srf_rule.Size = new System.Drawing.Size(1008, 105);
            this.srf_rule.TabIndex = 3;
            this.srf_rule.Text = "Rule";
            this.srf_rule.UseVisualStyleBackColor = true;
            // 
            // fgrid_rule
            // 
            this.fgrid_rule.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_rule.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_rule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_rule.Location = new System.Drawing.Point(0, 0);
            this.fgrid_rule.Name = "fgrid_rule";
            this.fgrid_rule.Rows.DefaultSize = 19;
            this.fgrid_rule.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_rule.Size = new System.Drawing.Size(1008, 105);
            this.fgrid_rule.StyleInfo = resources.GetString("fgrid_rule.StyleInfo");
            this.fgrid_rule.TabIndex = 105;
            // 
            // pnl_total
            // 
            this.pnl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_total.Controls.Add(this.pnl_grid);
            this.pnl_total.Controls.Add(this.pnl_bottom);
            this.pnl_total.Controls.Add(this.pnl_middle);
            this.pnl_total.Controls.Add(this.pnl_top);
            this.pnl_total.Location = new System.Drawing.Point(0, 80);
            this.pnl_total.Name = "pnl_total";
            this.pnl_total.Size = new System.Drawing.Size(1016, 553);
            this.pnl_total.TabIndex = 310;
            // 
            // pnl_grid
            // 
            this.pnl_grid.Controls.Add(this.tab_control);
            this.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_grid.Location = new System.Drawing.Point(0, 445);
            this.pnl_grid.Name = "pnl_grid";
            this.pnl_grid.Size = new System.Drawing.Size(1016, 108);
            this.pnl_grid.TabIndex = 311;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_bottom.Controls.Add(this.txt_platform);
            this.pnl_bottom.Controls.Add(this.txt_inline_size);
            this.pnl_bottom.Controls.Add(this.txt_sr_instruction);
            this.pnl_bottom.Controls.Add(this.txt_costmat_tfob);
            this.pnl_bottom.Controls.Add(this.txt_costmat_duty);
            this.pnl_bottom.Controls.Add(this.lbl_costmat_tfob);
            this.pnl_bottom.Controls.Add(this.lbl_costmat_duty);
            this.pnl_bottom.Controls.Add(this.lbl_costmat_name);
            this.pnl_bottom.Controls.Add(this.txt_last_dim);
            this.pnl_bottom.Controls.Add(this.txt_prod_id);
            this.pnl_bottom.Controls.Add(this.lbl_promo_size);
            this.pnl_bottom.Controls.Add(this.txt_costmat_name);
            this.pnl_bottom.Controls.Add(this.lbl_costmat_type);
            this.pnl_bottom.Controls.Add(this.txt_bom_method);
            this.pnl_bottom.Controls.Add(this.txt_promo_size);
            this.pnl_bottom.Controls.Add(this.txt_demension);
            this.pnl_bottom.Controls.Add(this.lbl_inline_size);
            this.pnl_bottom.Controls.Add(this.lbl_bom_dimension);
            this.pnl_bottom.Controls.Add(this.lbl_product_id);
            this.pnl_bottom.Controls.Add(this.lbl_bom_method);
            this.pnl_bottom.Controls.Add(this.lbl_last_dim);
            this.pnl_bottom.Controls.Add(this.lbl_platform);
            this.pnl_bottom.Controls.Add(this.lbl_sr_instreuction);
            this.pnl_bottom.Controls.Add(this.panel6);
            this.pnl_bottom.Controls.Add(this.panel7);
            this.pnl_bottom.Controls.Add(this.panel8);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 335);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Padding = new System.Windows.Forms.Padding(8, 0, 8, 4);
            this.pnl_bottom.Size = new System.Drawing.Size(1016, 110);
            this.pnl_bottom.TabIndex = 312;
            // 
            // txt_platform
            // 
            this.txt_platform.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_platform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_platform.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_platform.ForeColor = System.Drawing.Color.Black;
            this.txt_platform.Location = new System.Drawing.Point(581, 8);
            this.txt_platform.MaxLength = 100;
            this.txt_platform.Name = "txt_platform";
            this.txt_platform.Size = new System.Drawing.Size(120, 21);
            this.txt_platform.TabIndex = 372;
            this.txt_platform.Tag = "60";
            // 
            // txt_inline_size
            // 
            this.txt_inline_size.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_inline_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_inline_size.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inline_size.ForeColor = System.Drawing.Color.Black;
            this.txt_inline_size.Location = new System.Drawing.Point(581, 31);
            this.txt_inline_size.MaxLength = 100;
            this.txt_inline_size.Name = "txt_inline_size";
            this.txt_inline_size.Size = new System.Drawing.Size(120, 21);
            this.txt_inline_size.TabIndex = 371;
            this.txt_inline_size.Tag = "60";
            // 
            // txt_sr_instruction
            // 
            this.txt_sr_instruction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_sr_instruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sr_instruction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sr_instruction.ForeColor = System.Drawing.Color.Black;
            this.txt_sr_instruction.Location = new System.Drawing.Point(117, 8);
            this.txt_sr_instruction.MaxLength = 100;
            this.txt_sr_instruction.Name = "txt_sr_instruction";
            this.txt_sr_instruction.Size = new System.Drawing.Size(120, 21);
            this.txt_sr_instruction.TabIndex = 370;
            this.txt_sr_instruction.Tag = "60";
            // 
            // txt_costmat_tfob
            // 
            this.txt_costmat_tfob.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_costmat_tfob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_costmat_tfob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costmat_tfob.ForeColor = System.Drawing.Color.Black;
            this.txt_costmat_tfob.Location = new System.Drawing.Point(813, 54);
            this.txt_costmat_tfob.MaxLength = 100;
            this.txt_costmat_tfob.Name = "txt_costmat_tfob";
            this.txt_costmat_tfob.Size = new System.Drawing.Size(120, 21);
            this.txt_costmat_tfob.TabIndex = 365;
            this.txt_costmat_tfob.Tag = "47";
            // 
            // txt_costmat_duty
            // 
            this.txt_costmat_duty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_costmat_duty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_costmat_duty.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costmat_duty.ForeColor = System.Drawing.Color.Black;
            this.txt_costmat_duty.Location = new System.Drawing.Point(581, 54);
            this.txt_costmat_duty.MaxLength = 100;
            this.txt_costmat_duty.Name = "txt_costmat_duty";
            this.txt_costmat_duty.Size = new System.Drawing.Size(120, 21);
            this.txt_costmat_duty.TabIndex = 361;
            this.txt_costmat_duty.Tag = "41";
            // 
            // lbl_costmat_tfob
            // 
            this.lbl_costmat_tfob.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costmat_tfob.ImageIndex = 0;
            this.lbl_costmat_tfob.ImageList = this.img_Label;
            this.lbl_costmat_tfob.Location = new System.Drawing.Point(712, 54);
            this.lbl_costmat_tfob.Name = "lbl_costmat_tfob";
            this.lbl_costmat_tfob.Size = new System.Drawing.Size(100, 21);
            this.lbl_costmat_tfob.TabIndex = 360;
            this.lbl_costmat_tfob.Tag = "10";
            this.lbl_costmat_tfob.Text = "CostMat.TFOB";
            this.lbl_costmat_tfob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_costmat_duty
            // 
            this.lbl_costmat_duty.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costmat_duty.ImageIndex = 0;
            this.lbl_costmat_duty.ImageList = this.img_Label;
            this.lbl_costmat_duty.Location = new System.Drawing.Point(480, 54);
            this.lbl_costmat_duty.Name = "lbl_costmat_duty";
            this.lbl_costmat_duty.Size = new System.Drawing.Size(100, 21);
            this.lbl_costmat_duty.TabIndex = 358;
            this.lbl_costmat_duty.Tag = "10";
            this.lbl_costmat_duty.Text = "CostMat.Duty";
            this.lbl_costmat_duty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_costmat_name
            // 
            this.lbl_costmat_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costmat_name.ImageIndex = 0;
            this.lbl_costmat_name.ImageList = this.img_Label;
            this.lbl_costmat_name.Location = new System.Drawing.Point(16, 54);
            this.lbl_costmat_name.Name = "lbl_costmat_name";
            this.lbl_costmat_name.Size = new System.Drawing.Size(100, 21);
            this.lbl_costmat_name.TabIndex = 356;
            this.lbl_costmat_name.Tag = "17";
            this.lbl_costmat_name.Text = "CostMat.Name";
            this.lbl_costmat_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_last_dim
            // 
            this.txt_last_dim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_last_dim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_last_dim.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_last_dim.ForeColor = System.Drawing.Color.Black;
            this.txt_last_dim.Location = new System.Drawing.Point(813, 8);
            this.txt_last_dim.MaxLength = 100;
            this.txt_last_dim.Name = "txt_last_dim";
            this.txt_last_dim.Size = new System.Drawing.Size(120, 21);
            this.txt_last_dim.TabIndex = 355;
            this.txt_last_dim.Tag = "41";
            // 
            // txt_prod_id
            // 
            this.txt_prod_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_prod_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prod_id.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prod_id.ForeColor = System.Drawing.Color.Black;
            this.txt_prod_id.Location = new System.Drawing.Point(349, 31);
            this.txt_prod_id.MaxLength = 100;
            this.txt_prod_id.Name = "txt_prod_id";
            this.txt_prod_id.Size = new System.Drawing.Size(120, 21);
            this.txt_prod_id.TabIndex = 354;
            this.txt_prod_id.Tag = "41";
            // 
            // lbl_promo_size
            // 
            this.lbl_promo_size.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_promo_size.ImageIndex = 0;
            this.lbl_promo_size.ImageList = this.img_Label;
            this.lbl_promo_size.Location = new System.Drawing.Point(712, 31);
            this.lbl_promo_size.Name = "lbl_promo_size";
            this.lbl_promo_size.Size = new System.Drawing.Size(100, 21);
            this.lbl_promo_size.TabIndex = 353;
            this.lbl_promo_size.Tag = "10";
            this.lbl_promo_size.Text = "Promo Size";
            this.lbl_promo_size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_costmat_name
            // 
            this.txt_costmat_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_costmat_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_costmat_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costmat_name.ForeColor = System.Drawing.Color.Black;
            this.txt_costmat_name.Location = new System.Drawing.Point(117, 54);
            this.txt_costmat_name.MaxLength = 100;
            this.txt_costmat_name.Name = "txt_costmat_name";
            this.txt_costmat_name.Size = new System.Drawing.Size(120, 21);
            this.txt_costmat_name.TabIndex = 352;
            this.txt_costmat_name.Tag = "39";
            // 
            // lbl_costmat_type
            // 
            this.lbl_costmat_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costmat_type.ImageIndex = 0;
            this.lbl_costmat_type.ImageList = this.img_Label;
            this.lbl_costmat_type.Location = new System.Drawing.Point(248, 54);
            this.lbl_costmat_type.Name = "lbl_costmat_type";
            this.lbl_costmat_type.Size = new System.Drawing.Size(100, 21);
            this.lbl_costmat_type.TabIndex = 351;
            this.lbl_costmat_type.Tag = "8";
            this.lbl_costmat_type.Text = "CostMat.Type";
            this.lbl_costmat_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_bom_method
            // 
            this.txt_bom_method.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_bom_method.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bom_method.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bom_method.ForeColor = System.Drawing.Color.Black;
            this.txt_bom_method.Location = new System.Drawing.Point(117, 31);
            this.txt_bom_method.MaxLength = 100;
            this.txt_bom_method.Name = "txt_bom_method";
            this.txt_bom_method.Size = new System.Drawing.Size(120, 21);
            this.txt_bom_method.TabIndex = 350;
            this.txt_bom_method.Tag = "60";
            // 
            // txt_promo_size
            // 
            this.txt_promo_size.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_promo_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_promo_size.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_promo_size.ForeColor = System.Drawing.Color.Black;
            this.txt_promo_size.Location = new System.Drawing.Point(813, 31);
            this.txt_promo_size.MaxLength = 100;
            this.txt_promo_size.Name = "txt_promo_size";
            this.txt_promo_size.Size = new System.Drawing.Size(120, 21);
            this.txt_promo_size.TabIndex = 348;
            this.txt_promo_size.Tag = "47";
            // 
            // txt_demension
            // 
            this.txt_demension.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_demension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_demension.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_demension.ForeColor = System.Drawing.Color.Black;
            this.txt_demension.Location = new System.Drawing.Point(349, 8);
            this.txt_demension.MaxLength = 100;
            this.txt_demension.Name = "txt_demension";
            this.txt_demension.Size = new System.Drawing.Size(120, 21);
            this.txt_demension.TabIndex = 347;
            this.txt_demension.Tag = "32";
            // 
            // lbl_inline_size
            // 
            this.lbl_inline_size.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inline_size.ImageIndex = 0;
            this.lbl_inline_size.ImageList = this.img_Label;
            this.lbl_inline_size.Location = new System.Drawing.Point(480, 31);
            this.lbl_inline_size.Name = "lbl_inline_size";
            this.lbl_inline_size.Size = new System.Drawing.Size(100, 21);
            this.lbl_inline_size.TabIndex = 346;
            this.lbl_inline_size.Tag = "29";
            this.lbl_inline_size.Text = "Inline Size";
            this.lbl_inline_size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_bom_dimension
            // 
            this.lbl_bom_dimension.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bom_dimension.ImageIndex = 0;
            this.lbl_bom_dimension.ImageList = this.img_Label;
            this.lbl_bom_dimension.Location = new System.Drawing.Point(248, 8);
            this.lbl_bom_dimension.Name = "lbl_bom_dimension";
            this.lbl_bom_dimension.Size = new System.Drawing.Size(100, 21);
            this.lbl_bom_dimension.TabIndex = 343;
            this.lbl_bom_dimension.Tag = "1";
            this.lbl_bom_dimension.Text = "Dimension";
            this.lbl_bom_dimension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_id.ImageIndex = 0;
            this.lbl_product_id.ImageList = this.img_Label;
            this.lbl_product_id.Location = new System.Drawing.Point(248, 31);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.Size = new System.Drawing.Size(100, 21);
            this.lbl_product_id.TabIndex = 341;
            this.lbl_product_id.Tag = "21";
            this.lbl_product_id.Text = "Product ID";
            this.lbl_product_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_bom_method
            // 
            this.lbl_bom_method.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bom_method.ImageIndex = 0;
            this.lbl_bom_method.ImageList = this.img_Label;
            this.lbl_bom_method.Location = new System.Drawing.Point(16, 31);
            this.lbl_bom_method.Name = "lbl_bom_method";
            this.lbl_bom_method.Size = new System.Drawing.Size(100, 21);
            this.lbl_bom_method.TabIndex = 339;
            this.lbl_bom_method.Tag = "21";
            this.lbl_bom_method.Text = "BOM Method";
            this.lbl_bom_method.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_last_dim
            // 
            this.lbl_last_dim.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_dim.ImageIndex = 0;
            this.lbl_last_dim.ImageList = this.img_Label;
            this.lbl_last_dim.Location = new System.Drawing.Point(712, 8);
            this.lbl_last_dim.Name = "lbl_last_dim";
            this.lbl_last_dim.Size = new System.Drawing.Size(100, 21);
            this.lbl_last_dim.TabIndex = 337;
            this.lbl_last_dim.Tag = "9";
            this.lbl_last_dim.Text = "Last Dim.";
            this.lbl_last_dim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_platform
            // 
            this.lbl_platform.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_platform.ImageIndex = 0;
            this.lbl_platform.ImageList = this.img_Label;
            this.lbl_platform.Location = new System.Drawing.Point(480, 8);
            this.lbl_platform.Name = "lbl_platform";
            this.lbl_platform.Size = new System.Drawing.Size(100, 21);
            this.lbl_platform.TabIndex = 335;
            this.lbl_platform.Tag = "21";
            this.lbl_platform.Text = "Platform";
            this.lbl_platform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sr_instreuction
            // 
            this.lbl_sr_instreuction.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sr_instreuction.ImageIndex = 0;
            this.lbl_sr_instreuction.ImageList = this.img_Label;
            this.lbl_sr_instreuction.Location = new System.Drawing.Point(16, 8);
            this.lbl_sr_instreuction.Name = "lbl_sr_instreuction";
            this.lbl_sr_instreuction.Size = new System.Drawing.Size(100, 21);
            this.lbl_sr_instreuction.TabIndex = 326;
            this.lbl_sr_instreuction.Tag = "21";
            this.lbl_sr_instreuction.Text = "SR Instruction";
            this.lbl_sr_instreuction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.txt_extra_color);
            this.panel6.Controls.Add(this.lbl_extra_color);
            this.panel6.Controls.Add(this.txt_s_prod_fact);
            this.panel6.Controls.Add(this.lbl_s_prod_fact);
            this.panel6.Controls.Add(this.txt_ss_factory);
            this.panel6.Controls.Add(this.lbl_ss_factory);
            this.panel6.Controls.Add(this.txt_pcc_factory);
            this.panel6.Controls.Add(this.lbl_pcc_factory);
            this.panel6.Controls.Add(this.lbl_cons_focus);
            this.panel6.Controls.Add(this.lbl_biz_org);
            this.panel6.Controls.Add(this.txt_cons_use);
            this.panel6.Controls.Add(this.txt_cons_focus);
            this.panel6.Controls.Add(this.lbl_cons_use);
            this.panel6.Controls.Add(this.txt_biz_org);
            this.panel6.Controls.Add(this.txt_costmat_type);
            this.panel6.Controls.Add(this.txt_plm);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.lbl_plm);
            this.panel6.Controls.Add(this.pictureBox36);
            this.panel6.Controls.Add(this.pictureBox37);
            this.panel6.Controls.Add(this.lbl_td_code);
            this.panel6.Controls.Add(this.pictureBox38);
            this.panel6.Controls.Add(this.txt_devproj_id);
            this.panel6.Controls.Add(this.txt_cons_purpose);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Controls.Add(this.lbl_dev_proj_id);
            this.panel6.Controls.Add(this.pictureBox39);
            this.panel6.Controls.Add(this.lnl_cons_purpose);
            this.panel6.Controls.Add(this.txt_td_code);
            this.panel6.Controls.Add(this.pictureBox41);
            this.panel6.Controls.Add(this.pictureBox42);
            this.panel6.Controls.Add(this.pictureBox44);
            this.panel6.Controls.Add(this.pictureBox43);
            this.panel6.Controls.Add(this.pictureBox40);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(8, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1000, 106);
            this.panel6.TabIndex = 18;
            // 
            // txt_extra_color
            // 
            this.txt_extra_color.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_extra_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_extra_color.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_extra_color.ForeColor = System.Drawing.Color.Black;
            this.txt_extra_color.Location = new System.Drawing.Point(805, 123);
            this.txt_extra_color.MaxLength = 9999;
            this.txt_extra_color.Name = "txt_extra_color";
            this.txt_extra_color.Size = new System.Drawing.Size(120, 21);
            this.txt_extra_color.TabIndex = 387;
            this.txt_extra_color.Tag = "41";
            // 
            // lbl_extra_color
            // 
            this.lbl_extra_color.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_extra_color.ImageIndex = 0;
            this.lbl_extra_color.ImageList = this.img_Label;
            this.lbl_extra_color.Location = new System.Drawing.Point(704, 123);
            this.lbl_extra_color.Name = "lbl_extra_color";
            this.lbl_extra_color.Size = new System.Drawing.Size(100, 21);
            this.lbl_extra_color.TabIndex = 386;
            this.lbl_extra_color.Tag = "21";
            this.lbl_extra_color.Text = "Extra Color";
            this.lbl_extra_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_s_prod_fact
            // 
            this.txt_s_prod_fact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_s_prod_fact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_s_prod_fact.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_prod_fact.ForeColor = System.Drawing.Color.Black;
            this.txt_s_prod_fact.Location = new System.Drawing.Point(573, 123);
            this.txt_s_prod_fact.MaxLength = 100;
            this.txt_s_prod_fact.Name = "txt_s_prod_fact";
            this.txt_s_prod_fact.Size = new System.Drawing.Size(120, 21);
            this.txt_s_prod_fact.TabIndex = 385;
            this.txt_s_prod_fact.Tag = "41";
            // 
            // lbl_s_prod_fact
            // 
            this.lbl_s_prod_fact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_s_prod_fact.ImageIndex = 0;
            this.lbl_s_prod_fact.ImageList = this.img_Label;
            this.lbl_s_prod_fact.Location = new System.Drawing.Point(472, 123);
            this.lbl_s_prod_fact.Name = "lbl_s_prod_fact";
            this.lbl_s_prod_fact.Size = new System.Drawing.Size(100, 21);
            this.lbl_s_prod_fact.TabIndex = 384;
            this.lbl_s_prod_fact.Tag = "21";
            this.lbl_s_prod_fact.Text = "Sec. Factory";
            this.lbl_s_prod_fact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ss_factory
            // 
            this.txt_ss_factory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ss_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ss_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ss_factory.ForeColor = System.Drawing.Color.Black;
            this.txt_ss_factory.Location = new System.Drawing.Point(109, 123);
            this.txt_ss_factory.MaxLength = 100;
            this.txt_ss_factory.Name = "txt_ss_factory";
            this.txt_ss_factory.Size = new System.Drawing.Size(120, 21);
            this.txt_ss_factory.TabIndex = 381;
            this.txt_ss_factory.Tag = "41";
            // 
            // lbl_ss_factory
            // 
            this.lbl_ss_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ss_factory.ImageIndex = 0;
            this.lbl_ss_factory.ImageList = this.img_Label;
            this.lbl_ss_factory.Location = new System.Drawing.Point(8, 123);
            this.lbl_ss_factory.Name = "lbl_ss_factory";
            this.lbl_ss_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_ss_factory.TabIndex = 380;
            this.lbl_ss_factory.Tag = "21";
            this.lbl_ss_factory.Text = "SS Factory";
            this.lbl_ss_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_pcc_factory
            // 
            this.txt_pcc_factory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pcc_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pcc_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pcc_factory.ForeColor = System.Drawing.Color.Black;
            this.txt_pcc_factory.Location = new System.Drawing.Point(805, 100);
            this.txt_pcc_factory.MaxLength = 100;
            this.txt_pcc_factory.Name = "txt_pcc_factory";
            this.txt_pcc_factory.Size = new System.Drawing.Size(120, 21);
            this.txt_pcc_factory.TabIndex = 379;
            this.txt_pcc_factory.Tag = "41";
            // 
            // lbl_pcc_factory
            // 
            this.lbl_pcc_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcc_factory.ImageIndex = 0;
            this.lbl_pcc_factory.ImageList = this.img_Label;
            this.lbl_pcc_factory.Location = new System.Drawing.Point(704, 100);
            this.lbl_pcc_factory.Name = "lbl_pcc_factory";
            this.lbl_pcc_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_pcc_factory.TabIndex = 378;
            this.lbl_pcc_factory.Tag = "21";
            this.lbl_pcc_factory.Text = "PCC Factory";
            this.lbl_pcc_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cons_focus
            // 
            this.lbl_cons_focus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cons_focus.ImageIndex = 0;
            this.lbl_cons_focus.ImageList = this.img_Label;
            this.lbl_cons_focus.Location = new System.Drawing.Point(240, 100);
            this.lbl_cons_focus.Name = "lbl_cons_focus";
            this.lbl_cons_focus.Size = new System.Drawing.Size(100, 21);
            this.lbl_cons_focus.TabIndex = 333;
            this.lbl_cons_focus.Tag = "21";
            this.lbl_cons_focus.Text = "Cons. Focus";
            this.lbl_cons_focus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_biz_org
            // 
            this.lbl_biz_org.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_biz_org.ImageIndex = 0;
            this.lbl_biz_org.ImageList = this.img_Label;
            this.lbl_biz_org.Location = new System.Drawing.Point(704, 77);
            this.lbl_biz_org.Name = "lbl_biz_org";
            this.lbl_biz_org.Size = new System.Drawing.Size(100, 21);
            this.lbl_biz_org.TabIndex = 344;
            this.lbl_biz_org.Tag = "16";
            this.lbl_biz_org.Text = "Biz. ORG";
            this.lbl_biz_org.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cons_use
            // 
            this.txt_cons_use.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cons_use.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cons_use.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cons_use.ForeColor = System.Drawing.Color.Black;
            this.txt_cons_use.Location = new System.Drawing.Point(573, 100);
            this.txt_cons_use.MaxLength = 100;
            this.txt_cons_use.Name = "txt_cons_use";
            this.txt_cons_use.Size = new System.Drawing.Size(120, 21);
            this.txt_cons_use.TabIndex = 377;
            this.txt_cons_use.Tag = "41";
            // 
            // txt_cons_focus
            // 
            this.txt_cons_focus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cons_focus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cons_focus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cons_focus.ForeColor = System.Drawing.Color.Black;
            this.txt_cons_focus.Location = new System.Drawing.Point(341, 100);
            this.txt_cons_focus.MaxLength = 100;
            this.txt_cons_focus.Name = "txt_cons_focus";
            this.txt_cons_focus.Size = new System.Drawing.Size(120, 21);
            this.txt_cons_focus.TabIndex = 375;
            this.txt_cons_focus.Tag = "41";
            // 
            // lbl_cons_use
            // 
            this.lbl_cons_use.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cons_use.ImageIndex = 0;
            this.lbl_cons_use.ImageList = this.img_Label;
            this.lbl_cons_use.Location = new System.Drawing.Point(472, 100);
            this.lbl_cons_use.Name = "lbl_cons_use";
            this.lbl_cons_use.Size = new System.Drawing.Size(100, 21);
            this.lbl_cons_use.TabIndex = 376;
            this.lbl_cons_use.Tag = "21";
            this.lbl_cons_use.Text = "Cons. Use";
            this.lbl_cons_use.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_biz_org
            // 
            this.txt_biz_org.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_biz_org.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_biz_org.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_biz_org.ForeColor = System.Drawing.Color.Black;
            this.txt_biz_org.Location = new System.Drawing.Point(805, 77);
            this.txt_biz_org.MaxLength = 100;
            this.txt_biz_org.Name = "txt_biz_org";
            this.txt_biz_org.Size = new System.Drawing.Size(120, 21);
            this.txt_biz_org.TabIndex = 368;
            this.txt_biz_org.Tag = "47";
            // 
            // txt_costmat_type
            // 
            this.txt_costmat_type.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_costmat_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_costmat_type.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costmat_type.ForeColor = System.Drawing.Color.Black;
            this.txt_costmat_type.Location = new System.Drawing.Point(341, 54);
            this.txt_costmat_type.MaxLength = 100;
            this.txt_costmat_type.Name = "txt_costmat_type";
            this.txt_costmat_type.Size = new System.Drawing.Size(120, 21);
            this.txt_costmat_type.TabIndex = 375;
            this.txt_costmat_type.Tag = "41";
            // 
            // txt_plm
            // 
            this.txt_plm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_plm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_plm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plm.ForeColor = System.Drawing.Color.Black;
            this.txt_plm.Location = new System.Drawing.Point(573, 77);
            this.txt_plm.MaxLength = 100;
            this.txt_plm.Name = "txt_plm";
            this.txt_plm.Size = new System.Drawing.Size(120, 21);
            this.txt_plm.TabIndex = 367;
            this.txt_plm.Tag = "47";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.SystemColors.Window;
            this.label25.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(426, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 21);
            this.label25.TabIndex = 112;
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_plm
            // 
            this.lbl_plm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plm.ImageIndex = 0;
            this.lbl_plm.ImageList = this.img_Label;
            this.lbl_plm.Location = new System.Drawing.Point(472, 77);
            this.lbl_plm.Name = "lbl_plm";
            this.lbl_plm.Size = new System.Drawing.Size(100, 21);
            this.lbl_plm.TabIndex = 366;
            this.lbl_plm.Tag = "16";
            this.lbl_plm.Text = "PLM";
            this.lbl_plm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox36.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(983, 30);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(24, 63);
            this.pictureBox36.TabIndex = 26;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox37.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
            this.pictureBox37.Location = new System.Drawing.Point(984, 0);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(16, 32);
            this.pictureBox37.TabIndex = 21;
            this.pictureBox37.TabStop = false;
            // 
            // lbl_td_code
            // 
            this.lbl_td_code.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_td_code.ImageIndex = 0;
            this.lbl_td_code.ImageList = this.img_Label;
            this.lbl_td_code.Location = new System.Drawing.Point(240, 77);
            this.lbl_td_code.Name = "lbl_td_code";
            this.lbl_td_code.Size = new System.Drawing.Size(100, 21);
            this.lbl_td_code.TabIndex = 364;
            this.lbl_td_code.Tag = "16";
            this.lbl_td_code.Text = "TD Code";
            this.lbl_td_code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox38.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
            this.pictureBox38.Location = new System.Drawing.Point(224, 0);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(774, 40);
            this.pictureBox38.TabIndex = 0;
            this.pictureBox38.TabStop = false;
            // 
            // txt_devproj_id
            // 
            this.txt_devproj_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_devproj_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_devproj_id.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_devproj_id.ForeColor = System.Drawing.Color.Black;
            this.txt_devproj_id.Location = new System.Drawing.Point(109, 77);
            this.txt_devproj_id.MaxLength = 100;
            this.txt_devproj_id.Name = "txt_devproj_id";
            this.txt_devproj_id.Size = new System.Drawing.Size(120, 21);
            this.txt_devproj_id.TabIndex = 363;
            this.txt_devproj_id.Tag = "47";
            // 
            // txt_cons_purpose
            // 
            this.txt_cons_purpose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cons_purpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cons_purpose.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cons_purpose.ForeColor = System.Drawing.Color.Black;
            this.txt_cons_purpose.Location = new System.Drawing.Point(109, 100);
            this.txt_cons_purpose.MaxLength = 100;
            this.txt_cons_purpose.Name = "txt_cons_purpose";
            this.txt_cons_purpose.Size = new System.Drawing.Size(120, 21);
            this.txt_cons_purpose.TabIndex = 349;
            this.txt_cons_purpose.Tag = "48";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.SystemColors.Window;
            this.label26.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Navy;
            this.label26.Image = ((System.Drawing.Image)(resources.GetObject("label26.Image")));
            this.label26.Location = new System.Drawing.Point(0, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(231, 30);
            this.label26.TabIndex = 28;
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_dev_proj_id
            // 
            this.lbl_dev_proj_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dev_proj_id.ImageIndex = 0;
            this.lbl_dev_proj_id.ImageList = this.img_Label;
            this.lbl_dev_proj_id.Location = new System.Drawing.Point(8, 77);
            this.lbl_dev_proj_id.Name = "lbl_dev_proj_id";
            this.lbl_dev_proj_id.Size = new System.Drawing.Size(100, 21);
            this.lbl_dev_proj_id.TabIndex = 362;
            this.lbl_dev_proj_id.Tag = "16";
            this.lbl_dev_proj_id.Text = "Dev.Proj. ID";
            this.lbl_dev_proj_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox39.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(984, 91);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(16, 16);
            this.pictureBox39.TabIndex = 23;
            this.pictureBox39.TabStop = false;
            // 
            // lnl_cons_purpose
            // 
            this.lnl_cons_purpose.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnl_cons_purpose.ImageIndex = 0;
            this.lnl_cons_purpose.ImageList = this.img_Label;
            this.lnl_cons_purpose.Location = new System.Drawing.Point(8, 100);
            this.lnl_cons_purpose.Name = "lnl_cons_purpose";
            this.lnl_cons_purpose.Size = new System.Drawing.Size(100, 21);
            this.lnl_cons_purpose.TabIndex = 345;
            this.lnl_cons_purpose.Tag = "17";
            this.lnl_cons_purpose.Text = "Cons. Purpose";
            this.lnl_cons_purpose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_td_code
            // 
            this.txt_td_code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_td_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_td_code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_td_code.ForeColor = System.Drawing.Color.Black;
            this.txt_td_code.Location = new System.Drawing.Point(341, 77);
            this.txt_td_code.MaxLength = 100;
            this.txt_td_code.Name = "txt_td_code";
            this.txt_td_code.Size = new System.Drawing.Size(120, 21);
            this.txt_td_code.TabIndex = 359;
            this.txt_td_code.Tag = "41";
            // 
            // pictureBox41
            // 
            this.pictureBox41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox41.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox41.Image")));
            this.pictureBox41.Location = new System.Drawing.Point(0, 91);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(168, 20);
            this.pictureBox41.TabIndex = 22;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox42
            // 
            this.pictureBox42.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox42.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox42.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox42.Image")));
            this.pictureBox42.Location = new System.Drawing.Point(0, 24);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(168, 73);
            this.pictureBox42.TabIndex = 25;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox44.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox44.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox44.Image")));
            this.pictureBox44.Location = new System.Drawing.Point(472, 72);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(1000, 66);
            this.pictureBox44.TabIndex = 27;
            this.pictureBox44.TabStop = false;
            // 
            // pictureBox43
            // 
            this.pictureBox43.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox43.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox43.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox43.Image")));
            this.pictureBox43.Location = new System.Drawing.Point(152, 24);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(846, 66);
            this.pictureBox43.TabIndex = 27;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox40.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
            this.pictureBox40.Location = new System.Drawing.Point(144, 90);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(854, 18);
            this.pictureBox40.TabIndex = 24;
            this.pictureBox40.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.label27);
            this.panel7.Controls.Add(this.pictureBox45);
            this.panel7.Controls.Add(this.pictureBox46);
            this.panel7.Controls.Add(this.pictureBox47);
            this.panel7.Controls.Add(this.label28);
            this.panel7.Controls.Add(this.pictureBox48);
            this.panel7.Controls.Add(this.pictureBox49);
            this.panel7.Controls.Add(this.pictureBox50);
            this.panel7.Controls.Add(this.pictureBox51);
            this.panel7.Controls.Add(this.pictureBox52);
            this.panel7.Controls.Add(this.pictureBox53);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(8, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1000, 106);
            this.panel7.TabIndex = 18;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.SystemColors.Window;
            this.label27.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(426, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(21, 21);
            this.label27.TabIndex = 112;
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox45
            // 
            this.pictureBox45.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox45.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox45.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox45.Image")));
            this.pictureBox45.Location = new System.Drawing.Point(983, 30);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(24, 63);
            this.pictureBox45.TabIndex = 26;
            this.pictureBox45.TabStop = false;
            // 
            // pictureBox46
            // 
            this.pictureBox46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox46.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox46.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox46.Image")));
            this.pictureBox46.Location = new System.Drawing.Point(984, 0);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(16, 32);
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
            this.pictureBox47.Size = new System.Drawing.Size(1000, 40);
            this.pictureBox47.TabIndex = 0;
            this.pictureBox47.TabStop = false;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.SystemColors.Window;
            this.label28.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Navy;
            this.label28.Image = ((System.Drawing.Image)(resources.GetObject("label28.Image")));
            this.label28.Location = new System.Drawing.Point(0, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(231, 30);
            this.label28.TabIndex = 28;
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox48
            // 
            this.pictureBox48.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox48.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox48.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox48.Image")));
            this.pictureBox48.Location = new System.Drawing.Point(984, 91);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(16, 16);
            this.pictureBox48.TabIndex = 23;
            this.pictureBox48.TabStop = false;
            // 
            // pictureBox49
            // 
            this.pictureBox49.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox49.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox49.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox49.Image")));
            this.pictureBox49.Location = new System.Drawing.Point(144, 90);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox49.TabIndex = 24;
            this.pictureBox49.TabStop = false;
            // 
            // pictureBox50
            // 
            this.pictureBox50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox50.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox50.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox50.Image")));
            this.pictureBox50.Location = new System.Drawing.Point(0, 91);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(168, 20);
            this.pictureBox50.TabIndex = 22;
            this.pictureBox50.TabStop = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox51.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox51.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox51.Image")));
            this.pictureBox51.Location = new System.Drawing.Point(0, 24);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(168, 73);
            this.pictureBox51.TabIndex = 25;
            this.pictureBox51.TabStop = false;
            // 
            // pictureBox52
            // 
            this.pictureBox52.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox52.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox52.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox52.Image")));
            this.pictureBox52.Location = new System.Drawing.Point(152, 24);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(1000, 66);
            this.pictureBox52.TabIndex = 27;
            this.pictureBox52.TabStop = false;
            // 
            // pictureBox53
            // 
            this.pictureBox53.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox53.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox53.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox53.Image")));
            this.pictureBox53.Location = new System.Drawing.Point(472, 72);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(1000, 66);
            this.pictureBox53.TabIndex = 27;
            this.pictureBox53.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Window;
            this.panel8.Controls.Add(this.label29);
            this.panel8.Controls.Add(this.pictureBox54);
            this.panel8.Controls.Add(this.pictureBox55);
            this.panel8.Controls.Add(this.pictureBox56);
            this.panel8.Controls.Add(this.label30);
            this.panel8.Controls.Add(this.pictureBox57);
            this.panel8.Controls.Add(this.pictureBox58);
            this.panel8.Controls.Add(this.pictureBox59);
            this.panel8.Controls.Add(this.pictureBox60);
            this.panel8.Controls.Add(this.pictureBox61);
            this.panel8.Controls.Add(this.pictureBox62);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(8, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1000, 106);
            this.panel8.TabIndex = 18;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.SystemColors.Window;
            this.label29.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(426, 36);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(21, 21);
            this.label29.TabIndex = 112;
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox54
            // 
            this.pictureBox54.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox54.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox54.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox54.Image")));
            this.pictureBox54.Location = new System.Drawing.Point(983, 30);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(24, 63);
            this.pictureBox54.TabIndex = 26;
            this.pictureBox54.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox55.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox55.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox55.Image")));
            this.pictureBox55.Location = new System.Drawing.Point(984, 0);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(16, 32);
            this.pictureBox55.TabIndex = 21;
            this.pictureBox55.TabStop = false;
            // 
            // pictureBox56
            // 
            this.pictureBox56.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox56.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox56.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox56.Image")));
            this.pictureBox56.Location = new System.Drawing.Point(224, 0);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(1000, 40);
            this.pictureBox56.TabIndex = 0;
            this.pictureBox56.TabStop = false;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.SystemColors.Window;
            this.label30.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Navy;
            this.label30.Image = ((System.Drawing.Image)(resources.GetObject("label30.Image")));
            this.label30.Location = new System.Drawing.Point(0, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(231, 30);
            this.label30.TabIndex = 28;
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox57
            // 
            this.pictureBox57.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox57.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox57.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox57.Image")));
            this.pictureBox57.Location = new System.Drawing.Point(984, 91);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(16, 16);
            this.pictureBox57.TabIndex = 23;
            this.pictureBox57.TabStop = false;
            // 
            // pictureBox58
            // 
            this.pictureBox58.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox58.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox58.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox58.Image")));
            this.pictureBox58.Location = new System.Drawing.Point(144, 90);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox58.TabIndex = 24;
            this.pictureBox58.TabStop = false;
            // 
            // pictureBox59
            // 
            this.pictureBox59.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox59.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox59.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox59.Image")));
            this.pictureBox59.Location = new System.Drawing.Point(0, 91);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(168, 20);
            this.pictureBox59.TabIndex = 22;
            this.pictureBox59.TabStop = false;
            // 
            // pictureBox60
            // 
            this.pictureBox60.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox60.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox60.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox60.Image")));
            this.pictureBox60.Location = new System.Drawing.Point(0, 24);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(168, 73);
            this.pictureBox60.TabIndex = 25;
            this.pictureBox60.TabStop = false;
            // 
            // pictureBox61
            // 
            this.pictureBox61.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox61.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox61.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox61.Image")));
            this.pictureBox61.Location = new System.Drawing.Point(152, 24);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(1000, 66);
            this.pictureBox61.TabIndex = 27;
            this.pictureBox61.TabStop = false;
            // 
            // pictureBox62
            // 
            this.pictureBox62.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox62.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox62.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox62.Image")));
            this.pictureBox62.Location = new System.Drawing.Point(472, 72);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(1000, 66);
            this.pictureBox62.TabIndex = 27;
            this.pictureBox62.TabStop = false;
            // 
            // pnl_middle
            // 
            this.pnl_middle.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_middle.Controls.Add(this.dtp_current_ipw);
            this.pnl_middle.Controls.Add(this.txt_mto_account_name);
            this.pnl_middle.Controls.Add(this.lbl_mto_account);
            this.pnl_middle.Controls.Add(this.txt_technology);
            this.pnl_middle.Controls.Add(this.txt_sole_laying_method);
            this.pnl_middle.Controls.Add(this.txt_bom_state);
            this.pnl_middle.Controls.Add(this.txt_mtl_ver);
            this.pnl_middle.Controls.Add(this.txt_nlo_dev);
            this.pnl_middle.Controls.Add(this.lbl_nlo_dev);
            this.pnl_middle.Controls.Add(this.txt_season);
            this.pnl_middle.Controls.Add(this.lbl_whq_dev);
            this.pnl_middle.Controls.Add(this.txt_whq_plm);
            this.pnl_middle.Controls.Add(this.lbl_whq_plm);
            this.pnl_middle.Controls.Add(this.txt_mo_alias);
            this.pnl_middle.Controls.Add(this.lbl_season);
            this.pnl_middle.Controls.Add(this.txt_whq_dev);
            this.pnl_middle.Controls.Add(this.lbl_mo_alias);
            this.pnl_middle.Controls.Add(this.lbl_product_code);
            this.pnl_middle.Controls.Add(this.txt_model_name_bom);
            this.pnl_middle.Controls.Add(this.txt_ms_method);
            this.pnl_middle.Controls.Add(this.lbl_last_cd);
            this.pnl_middle.Controls.Add(this.txt_product_code);
            this.pnl_middle.Controls.Add(this.lbl_current_ipw);
            this.pnl_middle.Controls.Add(this.txt_lasting_method);
            this.pnl_middle.Controls.Add(this.txt_colo_ver);
            this.pnl_middle.Controls.Add(this.txt_last_cd);
            this.pnl_middle.Controls.Add(this.txt_silhouette);
            this.pnl_middle.Controls.Add(this.lbl_sole_laying_me);
            this.pnl_middle.Controls.Add(this.lbl_colo_ver);
            this.pnl_middle.Controls.Add(this.lbl_mtl_ver);
            this.pnl_middle.Controls.Add(this.lbl_silhouette);
            this.pnl_middle.Controls.Add(this.lbl_ms_method);
            this.pnl_middle.Controls.Add(this.lbl_lasting_method);
            this.pnl_middle.Controls.Add(this.lbl_model_name_bom);
            this.pnl_middle.Controls.Add(this.lbl_technology);
            this.pnl_middle.Controls.Add(this.txt_bom_comments);
            this.pnl_middle.Controls.Add(this.lbl_bom_comments);
            this.pnl_middle.Controls.Add(this.lbl_bom_state);
            this.pnl_middle.Controls.Add(this.pnl_SearchImage);
            this.pnl_middle.Controls.Add(this.panel5);
            this.pnl_middle.Controls.Add(this.panel4);
            this.pnl_middle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_middle.Location = new System.Drawing.Point(0, 202);
            this.pnl_middle.Name = "pnl_middle";
            this.pnl_middle.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_middle.Size = new System.Drawing.Size(1016, 133);
            this.pnl_middle.TabIndex = 137;
            // 
            // dtp_current_ipw
            // 
            this.dtp_current_ipw.CustomFormat = "yyyyMMdd";
            this.dtp_current_ipw.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_current_ipw.Location = new System.Drawing.Point(349, 52);
            this.dtp_current_ipw.Name = "dtp_current_ipw";
            this.dtp_current_ipw.Size = new System.Drawing.Size(121, 22);
            this.dtp_current_ipw.TabIndex = 375;
            this.dtp_current_ipw.CloseUp += new System.EventHandler(this.dtp_current_ipw_CloseUp);
            // 
            // txt_mto_account_name
            // 
            this.txt_mto_account_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mto_account_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mto_account_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mto_account_name.ForeColor = System.Drawing.Color.Black;
            this.txt_mto_account_name.Location = new System.Drawing.Point(117, 74);
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
            this.lbl_mto_account.Location = new System.Drawing.Point(16, 74);
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
            this.txt_sole_laying_method.Location = new System.Drawing.Point(581, 30);
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
            this.txt_mtl_ver.Location = new System.Drawing.Point(117, 96);
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
            this.txt_nlo_dev.Location = new System.Drawing.Point(813, 74);
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
            this.lbl_nlo_dev.Location = new System.Drawing.Point(712, 73);
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
            this.txt_season.Location = new System.Drawing.Point(813, 52);
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
            this.lbl_whq_dev.Location = new System.Drawing.Point(480, 74);
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
            this.txt_whq_plm.Location = new System.Drawing.Point(349, 75);
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
            this.lbl_whq_plm.Location = new System.Drawing.Point(248, 74);
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
            this.txt_mo_alias.Location = new System.Drawing.Point(581, 52);
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
            this.lbl_season.Location = new System.Drawing.Point(712, 51);
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
            this.txt_whq_dev.Location = new System.Drawing.Point(581, 74);
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
            this.lbl_mo_alias.Location = new System.Drawing.Point(480, 52);
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
            this.lbl_product_code.Location = new System.Drawing.Point(16, 52);
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
            this.txt_ms_method.Location = new System.Drawing.Point(349, 30);
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
            this.lbl_last_cd.Location = new System.Drawing.Point(712, 30);
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
            this.txt_product_code.Location = new System.Drawing.Point(117, 52);
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
            this.lbl_current_ipw.Location = new System.Drawing.Point(248, 52);
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
            this.txt_lasting_method.Location = new System.Drawing.Point(117, 30);
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
            this.txt_colo_ver.Location = new System.Drawing.Point(349, 97);
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
            this.txt_last_cd.Location = new System.Drawing.Point(813, 30);
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
            this.lbl_sole_laying_me.Location = new System.Drawing.Point(480, 30);
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
            this.lbl_colo_ver.Location = new System.Drawing.Point(248, 96);
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
            this.lbl_mtl_ver.Location = new System.Drawing.Point(16, 96);
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
            this.lbl_ms_method.Location = new System.Drawing.Point(248, 30);
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
            this.lbl_lasting_method.Location = new System.Drawing.Point(16, 30);
            this.lbl_lasting_method.Name = "lbl_lasting_method";
            this.lbl_lasting_method.Size = new System.Drawing.Size(100, 21);
            this.lbl_lasting_method.TabIndex = 339;
            this.lbl_lasting_method.Tag = "21";
            this.lbl_lasting_method.Text = "LastingMethod";
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
            this.txt_bom_comments.Location = new System.Drawing.Point(581, 96);
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
            this.lbl_bom_comments.Location = new System.Drawing.Point(480, 96);
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
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 125);
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
            this.picb_MR.Size = new System.Drawing.Size(24, 82);
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
            this.pictureBox4.Location = new System.Drawing.Point(984, 110);
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
            this.pictureBox5.Location = new System.Drawing.Point(144, 109);
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
            this.pictureBox6.Location = new System.Drawing.Point(0, 110);
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
            this.pictureBox7.Size = new System.Drawing.Size(168, 92);
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
            this.pictureBox8.Size = new System.Drawing.Size(1000, 85);
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
            this.pictureBox9.Size = new System.Drawing.Size(1000, 85);
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
            this.panel5.Size = new System.Drawing.Size(1000, 125);
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
            this.pictureBox27.Size = new System.Drawing.Size(24, 82);
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
            this.pictureBox30.Location = new System.Drawing.Point(984, 110);
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
            this.pictureBox31.Location = new System.Drawing.Point(144, 109);
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
            this.pictureBox32.Location = new System.Drawing.Point(0, 110);
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
            this.pictureBox33.Size = new System.Drawing.Size(168, 92);
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
            this.pictureBox34.Size = new System.Drawing.Size(1000, 85);
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
            this.pictureBox35.Size = new System.Drawing.Size(1000, 85);
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
            this.panel4.Size = new System.Drawing.Size(1000, 125);
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
            this.pictureBox18.Size = new System.Drawing.Size(24, 82);
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
            this.pictureBox21.Location = new System.Drawing.Point(984, 110);
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
            this.pictureBox22.Location = new System.Drawing.Point(144, 109);
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
            this.pictureBox23.Location = new System.Drawing.Point(0, 110);
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
            this.pictureBox24.Size = new System.Drawing.Size(168, 92);
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
            this.pictureBox25.Size = new System.Drawing.Size(1000, 85);
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
            this.pictureBox26.Size = new System.Drawing.Size(1000, 85);
            this.pictureBox26.TabIndex = 27;
            this.pictureBox26.TabStop = false;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_top.Controls.Add(this.btn_open_file);
            this.pnl_top.Controls.Add(this.cmb_sampletypes);
            this.pnl_top.Controls.Add(this.lbl_sampletypes);
            this.pnl_top.Controls.Add(this.cmb_level);
            this.pnl_top.Controls.Add(this.lbl_level);
            this.pnl_top.Controls.Add(this.txt_srno);
            this.pnl_top.Controls.Add(this.lbl_srno);
            this.pnl_top.Controls.Add(this.txt_srfno);
            this.pnl_top.Controls.Add(this.lbl_srfno);
            this.pnl_top.Controls.Add(this.txt_bomrev);
            this.pnl_top.Controls.Add(this.txt_bomid);
            this.pnl_top.Controls.Add(this.lbl_bom);
            this.pnl_top.Controls.Add(this.txt_Path);
            this.pnl_top.Controls.Add(this.lbl_srfpath);
            this.pnl_top.Controls.Add(this.cmb_factory);
            this.pnl_top.Controls.Add(this.lbl_factory);
            this.pnl_top.Controls.Add(this.textBox1);
            this.pnl_top.Controls.Add(this.textBox2);
            this.pnl_top.Controls.Add(this.textBox3);
            this.pnl_top.Controls.Add(this.textBox4);
            this.pnl_top.Controls.Add(this.textBox5);
            this.pnl_top.Controls.Add(this.textBox6);
            this.pnl_top.Controls.Add(this.panel3);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_top.Size = new System.Drawing.Size(1016, 202);
            this.pnl_top.TabIndex = 136;
            // 
            // btn_open_file
            // 
            this.btn_open_file.BackColor = System.Drawing.SystemColors.Window;
            this.btn_open_file.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_file.ImageIndex = 0;
            this.btn_open_file.ImageList = this.img_MiniButton;
            this.btn_open_file.Location = new System.Drawing.Point(680, 36);
            this.btn_open_file.Name = "btn_open_file";
            this.btn_open_file.Size = new System.Drawing.Size(21, 21);
            this.btn_open_file.TabIndex = 305;
            this.btn_open_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_open_file.Click += new System.EventHandler(this.btn_open_file_Click);
            // 
            // cmb_sampletypes
            // 
            this.cmb_sampletypes.AddItemSeparator = ';';
            this.cmb_sampletypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sampletypes.Caption = "";
            this.cmb_sampletypes.CaptionHeight = 17;
            this.cmb_sampletypes.CaptionStyle = style1;
            this.cmb_sampletypes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_sampletypes.ColumnCaptionHeight = 18;
            this.cmb_sampletypes.ColumnFooterHeight = 18;
            this.cmb_sampletypes.ContentHeight = 17;
            this.cmb_sampletypes.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_sampletypes.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_sampletypes.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampletypes.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sampletypes.EditorHeight = 17;
            this.cmb_sampletypes.EvenRowStyle = style2;
            this.cmb_sampletypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampletypes.FooterStyle = style3;
            this.cmb_sampletypes.HeadingStyle = style4;
            this.cmb_sampletypes.HighLightRowStyle = style5;
            this.cmb_sampletypes.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_sampletypes.Images"))));
            this.cmb_sampletypes.ItemHeight = 15;
            this.cmb_sampletypes.Location = new System.Drawing.Point(581, 58);
            this.cmb_sampletypes.MatchEntryTimeout = ((long)(2000));
            this.cmb_sampletypes.MaxDropDownItems = ((short)(5));
            this.cmb_sampletypes.MaxLength = 32767;
            this.cmb_sampletypes.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sampletypes.Name = "cmb_sampletypes";
            this.cmb_sampletypes.OddRowStyle = style6;
            this.cmb_sampletypes.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sampletypes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sampletypes.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sampletypes.SelectedStyle = style7;
            this.cmb_sampletypes.Size = new System.Drawing.Size(120, 21);
            this.cmb_sampletypes.Style = style8;
            this.cmb_sampletypes.TabIndex = 347;
            this.cmb_sampletypes.SelectedValueChanged += new System.EventHandler(this.cmb_sampletypes_SelectedValueChanged);
            this.cmb_sampletypes.PropBag = resources.GetString("cmb_sampletypes.PropBag");
            // 
            // lbl_sampletypes
            // 
            this.lbl_sampletypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sampletypes.ImageIndex = 0;
            this.lbl_sampletypes.ImageList = this.img_Label;
            this.lbl_sampletypes.Location = new System.Drawing.Point(480, 58);
            this.lbl_sampletypes.Name = "lbl_sampletypes";
            this.lbl_sampletypes.Size = new System.Drawing.Size(100, 21);
            this.lbl_sampletypes.TabIndex = 346;
            this.lbl_sampletypes.Tag = "21";
            this.lbl_sampletypes.Text = "Sample Types";
            this.lbl_sampletypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_level
            // 
            this.cmb_level.AddItemSeparator = ';';
            this.cmb_level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_level.Caption = "";
            this.cmb_level.CaptionHeight = 17;
            this.cmb_level.CaptionStyle = style9;
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
            this.cmb_level.EvenRowStyle = style10;
            this.cmb_level.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_level.FooterStyle = style11;
            this.cmb_level.HeadingStyle = style12;
            this.cmb_level.HighLightRowStyle = style13;
            this.cmb_level.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_level.Images"))));
            this.cmb_level.ItemHeight = 15;
            this.cmb_level.Location = new System.Drawing.Point(581, 36);
            this.cmb_level.MatchEntryTimeout = ((long)(2000));
            this.cmb_level.MaxDropDownItems = ((short)(5));
            this.cmb_level.MaxLength = 32767;
            this.cmb_level.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_level.Name = "cmb_level";
            this.cmb_level.OddRowStyle = style14;
            this.cmb_level.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_level.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_level.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_level.SelectedStyle = style15;
            this.cmb_level.Size = new System.Drawing.Size(98, 21);
            this.cmb_level.Style = style16;
            this.cmb_level.TabIndex = 345;
            this.cmb_level.SelectedValueChanged += new System.EventHandler(this.cmb_level_SelectedValueChanged);
            this.cmb_level.PropBag = resources.GetString("cmb_level.PropBag");
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
            this.txt_srfno.Location = new System.Drawing.Point(117, 58);
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
            this.lbl_srfno.Location = new System.Drawing.Point(16, 58);
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
            this.txt_bomrev.Location = new System.Drawing.Point(430, 58);
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
            this.txt_bomid.Location = new System.Drawing.Point(349, 58);
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
            this.lbl_bom.Location = new System.Drawing.Point(248, 58);
            this.lbl_bom.Name = "lbl_bom";
            this.lbl_bom.Size = new System.Drawing.Size(100, 21);
            this.lbl_bom.TabIndex = 333;
            this.lbl_bom.Tag = "21";
            this.lbl_bom.Text = "BOM Id/Rev";
            this.lbl_bom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Path
            // 
            this.txt_Path.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Path.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_Path.ForeColor = System.Drawing.Color.Black;
            this.txt_Path.Location = new System.Drawing.Point(581, 36);
            this.txt_Path.MaxLength = 100;
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.ReadOnly = true;
            this.txt_Path.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Path.Size = new System.Drawing.Size(98, 20);
            this.txt_Path.TabIndex = 306;
            this.txt_Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style17;
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
            this.cmb_factory.EvenRowStyle = style18;
            this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style19;
            this.cmb_factory.HeadingStyle = style20;
            this.cmb_factory.HighLightRowStyle = style21;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(117, 36);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style22;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style23;
            this.cmb_factory.Size = new System.Drawing.Size(120, 21);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 272;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
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
            this.panel3.Controls.Add(this.txt_pupuck_desc);
            this.panel3.Controls.Add(this.lbl_pupuck_desc);
            this.panel3.Controls.Add(this.cmb_pupuck_yn);
            this.panel3.Controls.Add(this.lbl_pu_puck);
            this.panel3.Controls.Add(this.cmb_offshore);
            this.panel3.Controls.Add(this.lbl_offshore);
            this.panel3.Controls.Add(this.lbl_marketing);
            this.panel3.Controls.Add(this.txt_marketing);
            this.panel3.Controls.Add(this.txt_factory_direct);
            this.panel3.Controls.Add(this.chk_gtm_2nd);
            this.panel3.Controls.Add(this.lbl_factory_direct);
            this.panel3.Controls.Add(this.chk_gtm_1st);
            this.panel3.Controls.Add(this.cmb_spc_yn);
            this.panel3.Controls.Add(this.lbl_Style_Cd);
            this.panel3.Controls.Add(this.lbl_spc_yn);
            this.panel3.Controls.Add(this.cmb_gender);
            this.panel3.Controls.Add(this.cmb_p_prod_fact);
            this.panel3.Controls.Add(this.cmb_category);
            this.panel3.Controls.Add(this.lbl_gender);
            this.panel3.Controls.Add(this.lbl_category);
            this.panel3.Controls.Add(this.cmb_td);
            this.panel3.Controls.Add(this.lbl_td);
            this.panel3.Controls.Add(this.txt_patten);
            this.panel3.Controls.Add(this.lbl_p_prod_fact);
            this.panel3.Controls.Add(this.lbl_mrp);
            this.panel3.Controls.Add(this.lbl_patten);
            this.panel3.Controls.Add(this.txt_style_cd);
            this.panel3.Controls.Add(this.lbl_delete);
            this.panel3.Controls.Add(this.lbl_pend);
            this.panel3.Controls.Add(this.lbl_ets);
            this.panel3.Controls.Add(this.dtp_ets);
            this.panel3.Controls.Add(this.lbl_need_by);
            this.panel3.Controls.Add(this.lbl_part);
            this.panel3.Controls.Add(this.dtp_need_by);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox10);
            this.panel3.Controls.Add(this.lbl_order_date);
            this.panel3.Controls.Add(this.pictureBox11);
            this.panel3.Controls.Add(this.dtp_order_date);
            this.panel3.Controls.Add(this.lbl_srf_info);
            this.panel3.Controls.Add(this.txt_requestor);
            this.panel3.Controls.Add(this.pictureBox12);
            this.panel3.Controls.Add(this.lbl_requestor);
            this.panel3.Controls.Add(this.pictureBox13);
            this.panel3.Controls.Add(this.txt_state);
            this.panel3.Controls.Add(this.pictureBox14);
            this.panel3.Controls.Add(this.lbl_state);
            this.panel3.Controls.Add(this.pictureBox15);
            this.panel3.Controls.Add(this.txt_mo_id);
            this.panel3.Controls.Add(this.lbl_model_name);
            this.panel3.Controls.Add(this.lbl_mo_id);
            this.panel3.Controls.Add(this.txt_model_name);
            this.panel3.Controls.Add(this.pictureBox17);
            this.panel3.Controls.Add(this.pictureBox16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(8, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 194);
            this.panel3.TabIndex = 18;
            // 
            // txt_pupuck_desc
            // 
            this.txt_pupuck_desc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_pupuck_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pupuck_desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pupuck_desc.ForeColor = System.Drawing.Color.Black;
            this.txt_pupuck_desc.Location = new System.Drawing.Point(573, 169);
            this.txt_pupuck_desc.MaxLength = 9;
            this.txt_pupuck_desc.Name = "txt_pupuck_desc";
            this.txt_pupuck_desc.Size = new System.Drawing.Size(352, 21);
            this.txt_pupuck_desc.TabIndex = 2012;
            this.txt_pupuck_desc.Tag = "48";
            this.txt_pupuck_desc.Visible = false;
            // 
            // lbl_pupuck_desc
            // 
            this.lbl_pupuck_desc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pupuck_desc.ImageIndex = 0;
            this.lbl_pupuck_desc.ImageList = this.img_Label;
            this.lbl_pupuck_desc.Location = new System.Drawing.Point(472, 168);
            this.lbl_pupuck_desc.Name = "lbl_pupuck_desc";
            this.lbl_pupuck_desc.Size = new System.Drawing.Size(100, 21);
            this.lbl_pupuck_desc.TabIndex = 2011;
            this.lbl_pupuck_desc.Tag = "21";
            this.lbl_pupuck_desc.Text = "PU Puck Desc.";
            this.lbl_pupuck_desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_pupuck_desc.Visible = false;
            // 
            // cmb_pupuck_yn
            // 
            this.cmb_pupuck_yn.AddItemSeparator = ';';
            this.cmb_pupuck_yn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_pupuck_yn.Caption = "";
            this.cmb_pupuck_yn.CaptionHeight = 17;
            this.cmb_pupuck_yn.CaptionStyle = style25;
            this.cmb_pupuck_yn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_pupuck_yn.ColumnCaptionHeight = 18;
            this.cmb_pupuck_yn.ColumnFooterHeight = 18;
            this.cmb_pupuck_yn.ContentHeight = 17;
            this.cmb_pupuck_yn.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_pupuck_yn.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_pupuck_yn.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pupuck_yn.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_pupuck_yn.EditorHeight = 17;
            this.cmb_pupuck_yn.EvenRowStyle = style26;
            this.cmb_pupuck_yn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pupuck_yn.FooterStyle = style27;
            this.cmb_pupuck_yn.HeadingStyle = style28;
            this.cmb_pupuck_yn.HighLightRowStyle = style29;
            this.cmb_pupuck_yn.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_pupuck_yn.Images"))));
            this.cmb_pupuck_yn.ItemHeight = 15;
            this.cmb_pupuck_yn.Location = new System.Drawing.Point(341, 168);
            this.cmb_pupuck_yn.MatchEntryTimeout = ((long)(2000));
            this.cmb_pupuck_yn.MaxDropDownItems = ((short)(5));
            this.cmb_pupuck_yn.MaxLength = 32767;
            this.cmb_pupuck_yn.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_pupuck_yn.Name = "cmb_pupuck_yn";
            this.cmb_pupuck_yn.OddRowStyle = style30;
            this.cmb_pupuck_yn.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_pupuck_yn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_pupuck_yn.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_pupuck_yn.SelectedStyle = style31;
            this.cmb_pupuck_yn.Size = new System.Drawing.Size(120, 21);
            this.cmb_pupuck_yn.Style = style32;
            this.cmb_pupuck_yn.TabIndex = 2010;
            this.cmb_pupuck_yn.Visible = false;
            this.cmb_pupuck_yn.PropBag = resources.GetString("cmb_pupuck_yn.PropBag");
            // 
            // lbl_pu_puck
            // 
            this.lbl_pu_puck.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pu_puck.ImageIndex = 0;
            this.lbl_pu_puck.ImageList = this.img_Label;
            this.lbl_pu_puck.Location = new System.Drawing.Point(240, 168);
            this.lbl_pu_puck.Name = "lbl_pu_puck";
            this.lbl_pu_puck.Size = new System.Drawing.Size(100, 21);
            this.lbl_pu_puck.TabIndex = 2009;
            this.lbl_pu_puck.Tag = "21";
            this.lbl_pu_puck.Text = "PU Puck Y/N";
            this.lbl_pu_puck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_pu_puck.Visible = false;
            // 
            // cmb_offshore
            // 
            this.cmb_offshore.AddItemSeparator = ';';
            this.cmb_offshore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_offshore.Caption = "";
            this.cmb_offshore.CaptionHeight = 17;
            this.cmb_offshore.CaptionStyle = style33;
            this.cmb_offshore.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_offshore.ColumnCaptionHeight = 18;
            this.cmb_offshore.ColumnFooterHeight = 18;
            this.cmb_offshore.ContentHeight = 17;
            this.cmb_offshore.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_offshore.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_offshore.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_offshore.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_offshore.EditorHeight = 17;
            this.cmb_offshore.EvenRowStyle = style34;
            this.cmb_offshore.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_offshore.FooterStyle = style35;
            this.cmb_offshore.HeadingStyle = style36;
            this.cmb_offshore.HighLightRowStyle = style37;
            this.cmb_offshore.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_offshore.Images"))));
            this.cmb_offshore.ItemHeight = 15;
            this.cmb_offshore.Location = new System.Drawing.Point(109, 168);
            this.cmb_offshore.MatchEntryTimeout = ((long)(2000));
            this.cmb_offshore.MaxDropDownItems = ((short)(5));
            this.cmb_offshore.MaxLength = 32767;
            this.cmb_offshore.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_offshore.Name = "cmb_offshore";
            this.cmb_offshore.OddRowStyle = style38;
            this.cmb_offshore.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_offshore.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_offshore.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_offshore.SelectedStyle = style39;
            this.cmb_offshore.Size = new System.Drawing.Size(120, 21);
            this.cmb_offshore.Style = style40;
            this.cmb_offshore.TabIndex = 2008;
            this.cmb_offshore.PropBag = resources.GetString("cmb_offshore.PropBag");
            // 
            // lbl_offshore
            // 
            this.lbl_offshore.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offshore.ImageIndex = 0;
            this.lbl_offshore.ImageList = this.img_Label;
            this.lbl_offshore.Location = new System.Drawing.Point(8, 168);
            this.lbl_offshore.Name = "lbl_offshore";
            this.lbl_offshore.Size = new System.Drawing.Size(100, 21);
            this.lbl_offshore.TabIndex = 2007;
            this.lbl_offshore.Tag = "21";
            this.lbl_offshore.Text = "Offshore Y/N";
            this.lbl_offshore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_marketing
            // 
            this.lbl_marketing.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marketing.ImageIndex = 0;
            this.lbl_marketing.ImageList = this.img_Label;
            this.lbl_marketing.Location = new System.Drawing.Point(704, 146);
            this.lbl_marketing.Name = "lbl_marketing";
            this.lbl_marketing.Size = new System.Drawing.Size(100, 21);
            this.lbl_marketing.TabIndex = 2005;
            this.lbl_marketing.Tag = "21";
            this.lbl_marketing.Text = "Marketing Nm.";
            this.lbl_marketing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_marketing
            // 
            this.txt_marketing.BackColor = System.Drawing.SystemColors.Window;
            this.txt_marketing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_marketing.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_marketing.ForeColor = System.Drawing.Color.Black;
            this.txt_marketing.Location = new System.Drawing.Point(805, 147);
            this.txt_marketing.MaxLength = 100;
            this.txt_marketing.Name = "txt_marketing";
            this.txt_marketing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_marketing.Size = new System.Drawing.Size(120, 20);
            this.txt_marketing.TabIndex = 2006;
            // 
            // txt_factory_direct
            // 
            this.txt_factory_direct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_factory_direct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_factory_direct.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_factory_direct.ForeColor = System.Drawing.Color.Black;
            this.txt_factory_direct.Location = new System.Drawing.Point(805, 80);
            this.txt_factory_direct.MaxLength = 100;
            this.txt_factory_direct.Name = "txt_factory_direct";
            this.txt_factory_direct.ReadOnly = true;
            this.txt_factory_direct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_factory_direct.Size = new System.Drawing.Size(120, 20);
            this.txt_factory_direct.TabIndex = 353;
            // 
            // chk_gtm_2nd
            // 
            this.chk_gtm_2nd.AutoSize = true;
            this.chk_gtm_2nd.Location = new System.Drawing.Point(780, 60);
            this.chk_gtm_2nd.Name = "chk_gtm_2nd";
            this.chk_gtm_2nd.Size = new System.Drawing.Size(80, 18);
            this.chk_gtm_2nd.TabIndex = 2004;
            this.chk_gtm_2nd.Text = "GTM 2nd";
            this.chk_gtm_2nd.UseVisualStyleBackColor = true;
            this.chk_gtm_2nd.CheckedChanged += new System.EventHandler(this.chk_gtm_2nd_CheckedChanged);
            // 
            // lbl_factory_direct
            // 
            this.lbl_factory_direct.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory_direct.ImageIndex = 0;
            this.lbl_factory_direct.ImageList = this.img_Label;
            this.lbl_factory_direct.Location = new System.Drawing.Point(704, 80);
            this.lbl_factory_direct.Name = "lbl_factory_direct";
            this.lbl_factory_direct.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory_direct.TabIndex = 352;
            this.lbl_factory_direct.Tag = "21";
            this.lbl_factory_direct.Text = "Factory Direct";
            this.lbl_factory_direct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_gtm_1st
            // 
            this.chk_gtm_1st.AutoSize = true;
            this.chk_gtm_1st.Location = new System.Drawing.Point(705, 60);
            this.chk_gtm_1st.Name = "chk_gtm_1st";
            this.chk_gtm_1st.Size = new System.Drawing.Size(76, 18);
            this.chk_gtm_1st.TabIndex = 2003;
            this.chk_gtm_1st.Text = "GTM 1st";
            this.chk_gtm_1st.UseVisualStyleBackColor = true;
            this.chk_gtm_1st.CheckedChanged += new System.EventHandler(this.chk_gtm_1st_CheckedChanged);
            // 
            // cmb_spc_yn
            // 
            this.cmb_spc_yn.AddItemSeparator = ';';
            this.cmb_spc_yn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_spc_yn.Caption = "";
            this.cmb_spc_yn.CaptionHeight = 17;
            this.cmb_spc_yn.CaptionStyle = style41;
            this.cmb_spc_yn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_spc_yn.ColumnCaptionHeight = 18;
            this.cmb_spc_yn.ColumnFooterHeight = 18;
            this.cmb_spc_yn.ContentHeight = 17;
            this.cmb_spc_yn.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_spc_yn.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_spc_yn.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_spc_yn.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_spc_yn.EditorHeight = 17;
            this.cmb_spc_yn.EvenRowStyle = style42;
            this.cmb_spc_yn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_spc_yn.FooterStyle = style43;
            this.cmb_spc_yn.HeadingStyle = style44;
            this.cmb_spc_yn.HighLightRowStyle = style45;
            this.cmb_spc_yn.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_spc_yn.Images"))));
            this.cmb_spc_yn.ItemHeight = 15;
            this.cmb_spc_yn.Location = new System.Drawing.Point(573, 146);
            this.cmb_spc_yn.MatchEntryTimeout = ((long)(2000));
            this.cmb_spc_yn.MaxDropDownItems = ((short)(5));
            this.cmb_spc_yn.MaxLength = 32767;
            this.cmb_spc_yn.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_spc_yn.Name = "cmb_spc_yn";
            this.cmb_spc_yn.OddRowStyle = style46;
            this.cmb_spc_yn.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_spc_yn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_spc_yn.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_spc_yn.SelectedStyle = style47;
            this.cmb_spc_yn.Size = new System.Drawing.Size(120, 21);
            this.cmb_spc_yn.Style = style48;
            this.cmb_spc_yn.TabIndex = 385;
            this.cmb_spc_yn.PropBag = resources.GetString("cmb_spc_yn.PropBag");
            // 
            // lbl_Style_Cd
            // 
            this.lbl_Style_Cd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Style_Cd.ImageIndex = 0;
            this.lbl_Style_Cd.ImageList = this.img_Label;
            this.lbl_Style_Cd.Location = new System.Drawing.Point(472, 124);
            this.lbl_Style_Cd.Name = "lbl_Style_Cd";
            this.lbl_Style_Cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style_Cd.TabIndex = 373;
            this.lbl_Style_Cd.Tag = "23";
            this.lbl_Style_Cd.Text = "Style Code";
            this.lbl_Style_Cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_spc_yn
            // 
            this.lbl_spc_yn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spc_yn.ImageIndex = 0;
            this.lbl_spc_yn.ImageList = this.img_Label;
            this.lbl_spc_yn.Location = new System.Drawing.Point(472, 146);
            this.lbl_spc_yn.Name = "lbl_spc_yn";
            this.lbl_spc_yn.Size = new System.Drawing.Size(100, 21);
            this.lbl_spc_yn.TabIndex = 384;
            this.lbl_spc_yn.Tag = "21";
            this.lbl_spc_yn.Text = "SPC Y/N";
            this.lbl_spc_yn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_gender
            // 
            this.cmb_gender.AddItemSeparator = ';';
            this.cmb_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_gender.Caption = "";
            this.cmb_gender.CaptionHeight = 17;
            this.cmb_gender.CaptionStyle = style49;
            this.cmb_gender.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_gender.ColumnCaptionHeight = 18;
            this.cmb_gender.ColumnFooterHeight = 18;
            this.cmb_gender.ContentHeight = 17;
            this.cmb_gender.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_gender.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_gender.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_gender.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_gender.EditorHeight = 17;
            this.cmb_gender.EvenRowStyle = style50;
            this.cmb_gender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_gender.FooterStyle = style51;
            this.cmb_gender.HeadingStyle = style52;
            this.cmb_gender.HighLightRowStyle = style53;
            this.cmb_gender.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_gender.Images"))));
            this.cmb_gender.ItemHeight = 15;
            this.cmb_gender.Location = new System.Drawing.Point(805, 124);
            this.cmb_gender.MatchEntryTimeout = ((long)(2000));
            this.cmb_gender.MaxDropDownItems = ((short)(5));
            this.cmb_gender.MaxLength = 32767;
            this.cmb_gender.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.OddRowStyle = style54;
            this.cmb_gender.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_gender.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_gender.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_gender.SelectedStyle = style55;
            this.cmb_gender.Size = new System.Drawing.Size(120, 21);
            this.cmb_gender.Style = style56;
            this.cmb_gender.TabIndex = 372;
            this.cmb_gender.TextChanged += new System.EventHandler(this.cmb_gender_TextChanged);
            this.cmb_gender.PropBag = resources.GetString("cmb_gender.PropBag");
            // 
            // cmb_p_prod_fact
            // 
            this.cmb_p_prod_fact.AddItemSeparator = ';';
            this.cmb_p_prod_fact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_p_prod_fact.Caption = "";
            this.cmb_p_prod_fact.CaptionHeight = 17;
            this.cmb_p_prod_fact.CaptionStyle = style57;
            this.cmb_p_prod_fact.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_p_prod_fact.ColumnCaptionHeight = 18;
            this.cmb_p_prod_fact.ColumnFooterHeight = 18;
            this.cmb_p_prod_fact.ContentHeight = 17;
            this.cmb_p_prod_fact.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_p_prod_fact.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_p_prod_fact.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_p_prod_fact.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_p_prod_fact.EditorHeight = 17;
            this.cmb_p_prod_fact.EvenRowStyle = style58;
            this.cmb_p_prod_fact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_p_prod_fact.FooterStyle = style59;
            this.cmb_p_prod_fact.HeadingStyle = style60;
            this.cmb_p_prod_fact.HighLightRowStyle = style61;
            this.cmb_p_prod_fact.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_p_prod_fact.Images"))));
            this.cmb_p_prod_fact.ItemHeight = 15;
            this.cmb_p_prod_fact.Location = new System.Drawing.Point(341, 146);
            this.cmb_p_prod_fact.MatchEntryTimeout = ((long)(2000));
            this.cmb_p_prod_fact.MaxDropDownItems = ((short)(5));
            this.cmb_p_prod_fact.MaxLength = 32767;
            this.cmb_p_prod_fact.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_p_prod_fact.Name = "cmb_p_prod_fact";
            this.cmb_p_prod_fact.OddRowStyle = style62;
            this.cmb_p_prod_fact.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_p_prod_fact.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_p_prod_fact.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_p_prod_fact.SelectedStyle = style63;
            this.cmb_p_prod_fact.Size = new System.Drawing.Size(120, 21);
            this.cmb_p_prod_fact.Style = style64;
            this.cmb_p_prod_fact.TabIndex = 383;
            this.cmb_p_prod_fact.PropBag = resources.GetString("cmb_p_prod_fact.PropBag");
            // 
            // cmb_category
            // 
            this.cmb_category.AddItemSeparator = ';';
            this.cmb_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_category.Caption = "";
            this.cmb_category.CaptionHeight = 17;
            this.cmb_category.CaptionStyle = style65;
            this.cmb_category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_category.ColumnCaptionHeight = 18;
            this.cmb_category.ColumnFooterHeight = 18;
            this.cmb_category.ContentHeight = 17;
            this.cmb_category.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_category.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_category.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_category.EditorHeight = 17;
            this.cmb_category.EvenRowStyle = style66;
            this.cmb_category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.FooterStyle = style67;
            this.cmb_category.HeadingStyle = style68;
            this.cmb_category.HighLightRowStyle = style69;
            this.cmb_category.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_category.Images"))));
            this.cmb_category.ItemHeight = 15;
            this.cmb_category.Location = new System.Drawing.Point(109, 79);
            this.cmb_category.MatchEntryTimeout = ((long)(2000));
            this.cmb_category.MaxDropDownItems = ((short)(5));
            this.cmb_category.MaxLength = 32767;
            this.cmb_category.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.OddRowStyle = style70;
            this.cmb_category.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_category.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_category.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_category.SelectedStyle = style71;
            this.cmb_category.Size = new System.Drawing.Size(120, 21);
            this.cmb_category.Style = style72;
            this.cmb_category.TabIndex = 2001;
            this.cmb_category.PropBag = resources.GetString("cmb_category.PropBag");
            // 
            // lbl_gender
            // 
            this.lbl_gender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ImageIndex = 0;
            this.lbl_gender.ImageList = this.img_Label;
            this.lbl_gender.Location = new System.Drawing.Point(704, 124);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_gender.TabIndex = 370;
            this.lbl_gender.Tag = "21";
            this.lbl_gender.Text = "Gerder";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_category
            // 
            this.lbl_category.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_category.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ImageIndex = 0;
            this.lbl_category.ImageList = this.img_Label;
            this.lbl_category.Location = new System.Drawing.Point(8, 80);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(100, 21);
            this.lbl_category.TabIndex = 2002;
            this.lbl_category.Tag = "21";
            this.lbl_category.Text = "Category";
            this.lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_td
            // 
            this.cmb_td.AddItemSeparator = ';';
            this.cmb_td.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_td.Caption = "";
            this.cmb_td.CaptionHeight = 17;
            this.cmb_td.CaptionStyle = style73;
            this.cmb_td.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_td.ColumnCaptionHeight = 18;
            this.cmb_td.ColumnFooterHeight = 18;
            this.cmb_td.ContentHeight = 17;
            this.cmb_td.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_td.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_td.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_td.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_td.EditorHeight = 17;
            this.cmb_td.EvenRowStyle = style74;
            this.cmb_td.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_td.FooterStyle = style75;
            this.cmb_td.HeadingStyle = style76;
            this.cmb_td.HighLightRowStyle = style77;
            this.cmb_td.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_td.Images"))));
            this.cmb_td.ItemHeight = 15;
            this.cmb_td.Location = new System.Drawing.Point(109, 146);
            this.cmb_td.MatchEntryTimeout = ((long)(2000));
            this.cmb_td.MaxDropDownItems = ((short)(5));
            this.cmb_td.MaxLength = 32767;
            this.cmb_td.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_td.Name = "cmb_td";
            this.cmb_td.OddRowStyle = style78;
            this.cmb_td.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_td.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_td.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_td.SelectedStyle = style79;
            this.cmb_td.Size = new System.Drawing.Size(120, 21);
            this.cmb_td.Style = style80;
            this.cmb_td.TabIndex = 375;
            this.cmb_td.SelectedValueChanged += new System.EventHandler(this.cmb_td_SelectedValueChanged);
            this.cmb_td.PropBag = resources.GetString("cmb_td.PropBag");
            // 
            // lbl_td
            // 
            this.lbl_td.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_td.ImageIndex = 0;
            this.lbl_td.ImageList = this.img_Label;
            this.lbl_td.Location = new System.Drawing.Point(8, 146);
            this.lbl_td.Name = "lbl_td";
            this.lbl_td.Size = new System.Drawing.Size(100, 21);
            this.lbl_td.TabIndex = 374;
            this.lbl_td.Tag = "21";
            this.lbl_td.Text = "T/D";
            this.lbl_td.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_patten
            // 
            this.txt_patten.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_patten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patten.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_patten.ForeColor = System.Drawing.Color.Black;
            this.txt_patten.Location = new System.Drawing.Point(341, 124);
            this.txt_patten.MaxLength = 100;
            this.txt_patten.Name = "txt_patten";
            this.txt_patten.ReadOnly = true;
            this.txt_patten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_patten.Size = new System.Drawing.Size(120, 20);
            this.txt_patten.TabIndex = 369;
            // 
            // lbl_p_prod_fact
            // 
            this.lbl_p_prod_fact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_prod_fact.ImageIndex = 0;
            this.lbl_p_prod_fact.ImageList = this.img_Label;
            this.lbl_p_prod_fact.Location = new System.Drawing.Point(240, 146);
            this.lbl_p_prod_fact.Name = "lbl_p_prod_fact";
            this.lbl_p_prod_fact.Size = new System.Drawing.Size(100, 21);
            this.lbl_p_prod_fact.TabIndex = 382;
            this.lbl_p_prod_fact.Tag = "21";
            this.lbl_p_prod_fact.Text = "Prod. Factory";
            this.lbl_p_prod_fact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mrp
            // 
            this.lbl_mrp.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_mrp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_mrp.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mrp.ImageList = this.img_Label;
            this.lbl_mrp.Location = new System.Drawing.Point(760, 36);
            this.lbl_mrp.Name = "lbl_mrp";
            this.lbl_mrp.Size = new System.Drawing.Size(54, 21);
            this.lbl_mrp.TabIndex = 377;
            this.lbl_mrp.Tag = "21";
            this.lbl_mrp.Text = "MRP";
            this.lbl_mrp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_patten
            // 
            this.lbl_patten.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patten.ImageIndex = 0;
            this.lbl_patten.ImageList = this.img_Label;
            this.lbl_patten.Location = new System.Drawing.Point(240, 124);
            this.lbl_patten.Name = "lbl_patten";
            this.lbl_patten.Size = new System.Drawing.Size(100, 21);
            this.lbl_patten.TabIndex = 368;
            this.lbl_patten.Tag = "21";
            this.lbl_patten.Text = "Pattern";
            this.lbl_patten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_style_cd
            // 
            this.txt_style_cd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_style_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_style_cd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_style_cd.ForeColor = System.Drawing.Color.Black;
            this.txt_style_cd.Location = new System.Drawing.Point(573, 124);
            this.txt_style_cd.MaxLength = 9;
            this.txt_style_cd.Name = "txt_style_cd";
            this.txt_style_cd.Size = new System.Drawing.Size(120, 21);
            this.txt_style_cd.TabIndex = 367;
            this.txt_style_cd.Tag = "48";
            this.txt_style_cd.TextChanged += new System.EventHandler(this.txt_style_cd_TextChanged);
            // 
            // lbl_delete
            // 
            this.lbl_delete.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_delete.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delete.ImageList = this.img_Label;
            this.lbl_delete.Location = new System.Drawing.Point(871, 36);
            this.lbl_delete.Name = "lbl_delete";
            this.lbl_delete.Size = new System.Drawing.Size(54, 21);
            this.lbl_delete.TabIndex = 376;
            this.lbl_delete.Tag = "21";
            this.lbl_delete.Text = "Delete";
            this.lbl_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pend
            // 
            this.lbl_pend.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_pend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pend.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pend.ImageList = this.img_Label;
            this.lbl_pend.Location = new System.Drawing.Point(815, 36);
            this.lbl_pend.Name = "lbl_pend";
            this.lbl_pend.Size = new System.Drawing.Size(54, 21);
            this.lbl_pend.TabIndex = 375;
            this.lbl_pend.Tag = "21";
            this.lbl_pend.Text = "Pending";
            this.lbl_pend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ets
            // 
            this.lbl_ets.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ets.ImageIndex = 0;
            this.lbl_ets.ImageList = this.img_Label;
            this.lbl_ets.Location = new System.Drawing.Point(704, 102);
            this.lbl_ets.Name = "lbl_ets";
            this.lbl_ets.Size = new System.Drawing.Size(100, 21);
            this.lbl_ets.TabIndex = 360;
            this.lbl_ets.Tag = "23";
            this.lbl_ets.Text = "ETS";
            this.lbl_ets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_ets
            // 
            this.dtp_ets.CustomFormat = "yyyyMMdd";
            this.dtp_ets.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ets.Location = new System.Drawing.Point(805, 101);
            this.dtp_ets.Name = "dtp_ets";
            this.dtp_ets.Size = new System.Drawing.Size(121, 22);
            this.dtp_ets.TabIndex = 361;
            this.dtp_ets.CloseUp += new System.EventHandler(this.dtp_ets_CloseUp);
            // 
            // lbl_need_by
            // 
            this.lbl_need_by.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_need_by.ImageIndex = 0;
            this.lbl_need_by.ImageList = this.img_Label;
            this.lbl_need_by.Location = new System.Drawing.Point(472, 102);
            this.lbl_need_by.Name = "lbl_need_by";
            this.lbl_need_by.Size = new System.Drawing.Size(100, 21);
            this.lbl_need_by.TabIndex = 362;
            this.lbl_need_by.Tag = "23";
            this.lbl_need_by.Text = "Need By";
            this.lbl_need_by.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_part
            // 
            this.lbl_part.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_part.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_part.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_part.ImageList = this.img_Label;
            this.lbl_part.Location = new System.Drawing.Point(704, 36);
            this.lbl_part.Name = "lbl_part";
            this.lbl_part.Size = new System.Drawing.Size(54, 21);
            this.lbl_part.TabIndex = 374;
            this.lbl_part.Tag = "21";
            this.lbl_part.Text = "Upload";
            this.lbl_part.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_need_by
            // 
            this.dtp_need_by.CustomFormat = "yyyyMMdd";
            this.dtp_need_by.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_need_by.Location = new System.Drawing.Point(573, 101);
            this.dtp_need_by.Name = "dtp_need_by";
            this.dtp_need_by.Size = new System.Drawing.Size(121, 22);
            this.dtp_need_by.TabIndex = 363;
            this.dtp_need_by.CloseUp += new System.EventHandler(this.dtp_need_by_CloseUp);
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
            this.pictureBox1.Size = new System.Drawing.Size(24, 151);
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
            // lbl_order_date
            // 
            this.lbl_order_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.ImageIndex = 0;
            this.lbl_order_date.ImageList = this.img_Label;
            this.lbl_order_date.Location = new System.Drawing.Point(240, 102);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_order_date.TabIndex = 358;
            this.lbl_order_date.Tag = "23";
            this.lbl_order_date.Text = "Order Date";
            this.lbl_order_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // dtp_order_date
            // 
            this.dtp_order_date.CustomFormat = "yyyyMMdd";
            this.dtp_order_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_order_date.Location = new System.Drawing.Point(341, 101);
            this.dtp_order_date.Name = "dtp_order_date";
            this.dtp_order_date.Size = new System.Drawing.Size(121, 22);
            this.dtp_order_date.TabIndex = 359;
            this.dtp_order_date.CloseUp += new System.EventHandler(this.dtp_order_date_CloseUp);
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
            // txt_requestor
            // 
            this.txt_requestor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_requestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_requestor.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_requestor.ForeColor = System.Drawing.Color.Black;
            this.txt_requestor.Location = new System.Drawing.Point(109, 124);
            this.txt_requestor.MaxLength = 100;
            this.txt_requestor.Name = "txt_requestor";
            this.txt_requestor.ReadOnly = true;
            this.txt_requestor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_requestor.Size = new System.Drawing.Size(120, 20);
            this.txt_requestor.TabIndex = 357;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(984, 179);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(16, 16);
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            // 
            // lbl_requestor
            // 
            this.lbl_requestor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requestor.ImageIndex = 0;
            this.lbl_requestor.ImageList = this.img_Label;
            this.lbl_requestor.Location = new System.Drawing.Point(8, 124);
            this.lbl_requestor.Name = "lbl_requestor";
            this.lbl_requestor.Size = new System.Drawing.Size(100, 21);
            this.lbl_requestor.TabIndex = 356;
            this.lbl_requestor.Tag = "21";
            this.lbl_requestor.Text = "Requestor";
            this.lbl_requestor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(144, 178);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox13.TabIndex = 24;
            this.pictureBox13.TabStop = false;
            // 
            // txt_state
            // 
            this.txt_state.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_state.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_state.ForeColor = System.Drawing.Color.Black;
            this.txt_state.Location = new System.Drawing.Point(109, 102);
            this.txt_state.MaxLength = 100;
            this.txt_state.Name = "txt_state";
            this.txt_state.ReadOnly = true;
            this.txt_state.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_state.Size = new System.Drawing.Size(120, 20);
            this.txt_state.TabIndex = 355;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(0, 179);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(168, 20);
            this.pictureBox14.TabIndex = 22;
            this.pictureBox14.TabStop = false;
            // 
            // lbl_state
            // 
            this.lbl_state.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.ImageIndex = 0;
            this.lbl_state.ImageList = this.img_Label;
            this.lbl_state.Location = new System.Drawing.Point(8, 102);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(100, 21);
            this.lbl_state.TabIndex = 354;
            this.lbl_state.Tag = "21";
            this.lbl_state.Text = "State";
            this.lbl_state.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(0, 24);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(168, 161);
            this.pictureBox15.TabIndex = 25;
            this.pictureBox15.TabStop = false;
            // 
            // txt_mo_id
            // 
            this.txt_mo_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mo_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mo_id.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_mo_id.ForeColor = System.Drawing.Color.Black;
            this.txt_mo_id.Location = new System.Drawing.Point(573, 80);
            this.txt_mo_id.MaxLength = 100;
            this.txt_mo_id.Name = "txt_mo_id";
            this.txt_mo_id.ReadOnly = true;
            this.txt_mo_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_mo_id.Size = new System.Drawing.Size(120, 20);
            this.txt_mo_id.TabIndex = 351;
            // 
            // lbl_model_name
            // 
            this.lbl_model_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model_name.ImageIndex = 0;
            this.lbl_model_name.ImageList = this.img_Label;
            this.lbl_model_name.Location = new System.Drawing.Point(239, 80);
            this.lbl_model_name.Name = "lbl_model_name";
            this.lbl_model_name.Size = new System.Drawing.Size(100, 21);
            this.lbl_model_name.TabIndex = 348;
            this.lbl_model_name.Tag = "21";
            this.lbl_model_name.Text = "Model Name";
            this.lbl_model_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mo_id
            // 
            this.lbl_mo_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mo_id.ImageIndex = 0;
            this.lbl_mo_id.ImageList = this.img_Label;
            this.lbl_mo_id.Location = new System.Drawing.Point(472, 80);
            this.lbl_mo_id.Name = "lbl_mo_id";
            this.lbl_mo_id.Size = new System.Drawing.Size(100, 21);
            this.lbl_mo_id.TabIndex = 350;
            this.lbl_mo_id.Tag = "21";
            this.lbl_mo_id.Text = "Mo ID";
            this.lbl_mo_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_model_name
            // 
            this.txt_model_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_model_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_model_name.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_model_name.ForeColor = System.Drawing.Color.Black;
            this.txt_model_name.Location = new System.Drawing.Point(341, 80);
            this.txt_model_name.MaxLength = 100;
            this.txt_model_name.Name = "txt_model_name";
            this.txt_model_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_model_name.Size = new System.Drawing.Size(120, 20);
            this.txt_model_name.TabIndex = 349;
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
            this.pictureBox17.Size = new System.Drawing.Size(1000, 154);
            this.pictureBox17.TabIndex = 27;
            this.pictureBox17.TabStop = false;
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
            this.pictureBox16.Size = new System.Drawing.Size(1000, 154);
            this.pictureBox16.TabIndex = 27;
            this.pictureBox16.TabStop = false;
            // 
            // Form_Bom_Editer
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_total);
            this.Name = "Form_Bom_Editer";
            this.Load += new System.EventHandler(this.Form_Bom_Editer_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_total, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.tab_control.ResumeLayout(false);
            this.srf_tail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_desc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_detail)).EndInit();
            this.srf_order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_order)).EndInit();
            this.srf_vendor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_vendor)).EndInit();
            this.srf_rule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_rule)).EndInit();
            this.pnl_total.ResumeLayout(false);
            this.pnl_grid.ResumeLayout(false);
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_bottom.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            this.pnl_middle.ResumeLayout(false);
            this.pnl_middle.PerformLayout();
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
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pupuck_yn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_offshore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_spc_yn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_p_prod_fact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_td)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #region 사용자 정의 변수
        private COM.OraDB OraDB = new COM.OraDB();
        private COM.ComFunction comfunction = new COM.ComFunction();

        private string dateType           = "yyyyMMdd";
        private char   _CharDiv           = '"';
        private bool   show_head          = true;
        private bool   color_check        = false;
        private string default_color      = "X000";
        private string default_color_desc = "NA";
        private string _cs_gend           = "";
        private string _jobcount          = "0";

        private bool   factory_vj  = true;
        private bool   warning_chk = false;
        private string csv_type    = "D";//D BOM, E BOM구분        
        private string _Form_Type  = "I";
        private string save_srno   = null;
        private string _File_Type  = null;

        #region CSV용 변수
        public string _head_factory = null;
        public string _head_sr_no   = null;
        public string _head_srf_no  = null;
        public string _head_bom_id  = null;
        public string _head_bom_rev = null;

        public string _head_nf_cd     = null;
        public string _head_category  = null;
        public string _head_srf_seq   = null;
        public string _head_bom_state = null;
        public string _head_requestor = null;
        public string _head_ord_ymd   = null;

        public string _head_need_by  = null;
        public string _head_ets      = null;
        public string _head_mo_alias = null;
        public string _head_whq_plm  = null;
        public string _head_whq_dev  = null;

        public string _head_nlo_dev        = null;
        public string _head_silhouette     = null;
        public string _head_technology     = null;
        public string _head_lasting_method = null;
        public string _head_ms_method      = null;

        public string _head_sole_laying_method = null;
        public string _head_mto_account_name   = null;
        public string _head_bom_comment        = null;
        public string _head_factory_dv         = null;
        public string _head_sesn               = null;

        public string _head_pattern      = null;
        public string _head_last_cd      = null;
        public string _head_dev_name     = null;
        public string _head_mtl_ver      = null;
        public string _head_color_ver    = null;
        public string _head_sample_types = null;

        public string _head_sta          = null;
        public string _head_current_ipw  = null;
        public string _head_product_code = null;
        public string _head_pur_flg      = null;
        public string _head_style_cd     = null;

        public string _head_remarks       = null;
        public string _head_status        = null;
        public string _head_load_upd_user = null;
        public string _head_load_upd_ymd  = null;
        public string _head_upd_user      = null;
        public string _head_upd_ymd       = null;

        public string _head_size   = null;
        public string _head_gender = null;

        public string _head_dm_bom_flg     = null;
        public string _head_prod_ext_color = null;
        public string _head_pcc_factory    = null;
        public string _head_ss_factory     = null;
        public string _head_p_prod_factory = null;
        public string _head_s_prod_factory = null;

        public string _head_td_code = null;       

        public string _head_sr_instructions     = null;
        public string _head_bom_dimension       = null;
        public string _head_bom_platform        = null;
        public string _head_bom_lastdim         = null;
        public string _head_bom_method          = null;
        public string _head_productid           = null;
        public string _head_bom_inlinesizerange = null;
        public string _head_bom_promosizerange  = null;
        public string _head_cm_name             = null;
        public string _head_cm_type             = null;
        public string _head_cm_dutycode         = null;
        public string _head_cm_tfob             = null;
        public string _head_devproj_alias       = null;
        public string _head_devproj_id          = null;
        public string _head_tdcode              = null;
        public string _head_plm                 = null;
        public string _head_biz_org             = null;
        public string _head_consumer_purpose    = null;
        public string _head_consumer_focus      = null;
        public string _head_consumer_use        = null;
        public string _head_model_id            = null;
        public string _head_spc_yn              = null;
        public string _head_gtm_div             = null;
        public string _head_marketing_name      = null;
        public string _head_offshore_yn         = null;
        public string _head_pu_puck_yn          = null;
        public string _head_pu_puck_desc        = null;
        #endregion

        public int  _RowFixed_detali;
        private int _RowFixed_order;
        private int _RowFixed_desc;
        private int _RowFixed_vendor;

        private string spec_cd    = null;
        private string spec_name  = null;
        private string unit_value = null;

        private bool new_nf_cd = false;
        private int null_value = 1;
  
        #region XML File Head값 변수 지정

        //Sample Request
        private string xml_samplerequest_id           = "";
        private string xml_samplerequest_type         = "";
        private string xml_samplerequest_state        = "";
        private string xml_requestor                  = "";
        private string xml_orderdate                  = "";
        private string xml_needbydate                 = "";
        private string xml_estdate                    = "";
        private string xml_samplerequest_instructions = "";
        private string xml_pattern_id                 = "";
        private string xml_modelid                    = "";
        private string xml_modelname                  = "";
        private string xml_devproj_alias              = "";
        private string xml_devproj_id                 = "";
        private string xml_season                     = "";
        private string xml_tdcode                     = "";
        private string xml_factorydirect              = "";
        private string xml_pccfcty                    = "";
        private string xml_ssfcty                     = "";
        private string xml_primprodfcty               = "";
        private string xml_secprodfcty                = "";
        private string xml_whqdeveloper               = "";
        private string xml_nlodeveloper               = "";
        private string xml_plm                        = "";
        private string xml_biz_org                    = "";
        private string xml_consumer_purpose           = "";
        private string xml_consumer_focus             = "";
        private string xml_consumer_use               = "";

        //Sample Request Destination
        private string xml_samplerequest_dest         = "";

        //Sample Request Lineitem
        private string xml_lineitem_id                = "";
        private string xml_samplerequest_gender       = "";
        private string xml_samplerequest_size         = "";
        private string xml_samplerequest_width        = "";
        private string xml_samplerequest_fit          = "";
        private string xml_samplerequest_age          = "";
        private string xml_samplerequest_attentionto  = "";
        private string xml_samplerequest_side         = "";
        private string xml_samplerequest_quantity     = "";
                                                      
        //BOM Information                             
        private string xml_bom_id                     = "";
        private string xml_bom_rev                    = "";
        private string xml_bom_state                  = "";
        private string xml_bom_dimension              = "";
        private string xml_bom_silhouette             = "";
        private string xml_bom_platform               = "";
        private string xml_bom_lastcode               = "";
        private string xml_bom_lastdim                = "";
        private string xml_bom_method                 = "";
        private string xml_bom_midsolemethod          = "";
        private string xml_bom_solemethod             = "";
        private string xml_bom_materialversion        = "";
        private string xml_bom_colorversion           = "";
        private string xml_bom_comments               = "";
        private string xml_bom_prodcolorextabbrv      = "";
        private string xml_bom_productcode            = "";
        private string xml_productid                  = "";
        private string xml_bom_inlinesizerange        = "";
        private string xml_bom_promosizerange         = "";
        private string xml_bom_currentipw             = "";
                                                      
        //Costing Material                            
        private string xml_costingmaterial_name       = "";
        private string xml_costingmaterial_type       = "";
        private string xml_costingmaterial_dutycode   = "";
        private string xml_costingmaterial_tfob       = "";
                                                      
        //Rule                                        
        private string xml_globalexclusive_type       = "";
        private string xml_globalexclusive_to         = "";
        private string xml_initiating_region          = "";
        private string xml_initiatingexclusive_type   = "";
        private string xml_initiatingexclusive_to     = "";
                                                      
        //BOM Lineitem                                
        private string xml_bom_partnumber             = "";
        private string xml_bom_partname               = "";
        private string xml_bom_parttype               = "";
        private string xml_bom_partquantity           = "";
        private string xml_bom_partcomment            = "";
        private string xml_bom_colorid                = "";
        private string xml_bom_colorname              = "";
        private string xml_bom_colorcomment           = "";
        private string xml_material_name              = "";
        private string xml_material_number            = "";
        private string xml_mcs_number                 = "";
        private string xml_mxs_number                 = "";
        private string xml_bom_materialcoment         = "";
        private string xml_supplier_name              = "";
                                                      
        //Airbag                                      
        private string xml_airbag_number              = "";
        private string xml_airbag_name                = "";
        private string xml_airbag_size                = "";
        private string xml_airbag_min                 = "";
        private string xml_airbag_max                 = "";
        private string xml_airbag_state               = "";
                                                      
        //Box                                         
        private string xml_box_number                 = "";
        private string xml_box_name                   = "";
        private string xml_box_size                   = "";
        private string xml_box_min                    = "";
        private string xml_box_max                    = "";
        private string xml_box_state                  = "";
                                                      
        //Lace                                        
        private string xml_lace_number                = "";
        private string xml_lace_name                  = "";
        private string xml_lace_type                  = "";
        private string xml_lace_length                = "";
        private string xml_lace_min                   = "";
        private string xml_lace_max                   = "";
        private string xml_lace_state                 = "";


        private string xml_marketing_name             = "";
        #endregion                                    

        private string _source_type = "X";
        private bool _new_srf = false;
        #endregion

        #region 생성자
        public Form_Bom_Editer()
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }
        public Form_Bom_Editer(string arg_form_mode, string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd, string arg_category)
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

            _Form_Type = arg_form_mode;
            _head_factory = arg_factory;
            _head_sr_no = arg_sr_no;
            _head_srf_no = arg_srf_no;
            _head_bom_id = arg_bom_id;
            _head_bom_rev = arg_bom_rev;
            _head_nf_cd = arg_nf_cd;
            _head_category = arg_category;
        }
        #endregion

        #region Form Loading
        private void Form_Bom_Editer_Load(object sender, System.EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
        }
        private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_factory.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();

                Init_Form();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private void Init_Form()
        {
            this.Text = "PCC_Update Bom";
            this.lbl_MainTitle.Text = "PCC_Update Bom";
            ClassLib.ComFunction.SetLangDic(this);

            Type_Working(_Form_Type);

            #region ComboBox Setting
            //Sample Type
            DataTable dt_ret = SELECT_SAMPLE_TYPES();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletypes, 0, 1, false, false);

            //T_D
            dt_ret = SELECT_TD(cmb_factory.SelectedValue.ToString());            
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_td, 0, 1, false, 0, 120);
            
            //Gendor
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxGen);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_gender, 1, 2, false, false);

            //Category
            dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxCDC_Category);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1, 2, false, COM.ComVar.ComboList_Visible.Name);
            cmb_category.SelectedIndex = -1;

            #region Prod. Factory
            cmb_p_prod_fact.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_p_prod_fact.ClearItems();

            cmb_p_prod_fact.AddItemTitles("Code;Name");

            cmb_p_prod_fact.ValueMember = "Code";
            cmb_p_prod_fact.DisplayMember = "Name";

            cmb_p_prod_fact.AddItem("VJ;VJ");
            cmb_p_prod_fact.AddItem("QD;QD");

            cmb_p_prod_fact.SelectedIndex = -1;

            cmb_p_prod_fact.MaxDropDownItems = 10;
            cmb_p_prod_fact.Splits[0].DisplayColumns[0].Width = 0;
            cmb_p_prod_fact.Splits[0].DisplayColumns[1].Width = 120;

            cmb_p_prod_fact.ExtendRightColumn = true;
            cmb_p_prod_fact.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_p_prod_fact.HScrollBar.Height = 0;
                        
            if (COM.ComVar.This_Factory == "DS")
            {
                cmb_p_prod_fact.SelectedIndex = -1;
                cmb_p_prod_fact.Enabled = true;
            }
            else
            {
                cmb_p_prod_fact.SelectedValue = COM.ComVar.This_Factory;
                cmb_p_prod_fact.Enabled = false;
            }
            #endregion

            #region SPC Y/N
            cmb_spc_yn.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_spc_yn.ClearItems();

            cmb_spc_yn.AddItemTitles("Code;Name");

            cmb_spc_yn.ValueMember = "Code";
            cmb_spc_yn.DisplayMember = "Name";

            cmb_spc_yn.AddItem("Y;Y");
            cmb_spc_yn.AddItem("N;N");

            cmb_spc_yn.SelectedIndex = -1;

            cmb_spc_yn.MaxDropDownItems = 10;
            cmb_spc_yn.Splits[0].DisplayColumns[0].Width = 0;
            cmb_spc_yn.Splits[0].DisplayColumns[1].Width = 120;

            cmb_spc_yn.ExtendRightColumn = true;
            cmb_spc_yn.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_spc_yn.HScrollBar.Height = 0;

            cmb_spc_yn.SelectedIndex = -1;
            #endregion

            #region Offshore Y/N
            cmb_offshore.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_offshore.ClearItems();

            cmb_offshore.AddItemTitles("Code;Name");

            cmb_offshore.ValueMember = "Code";
            cmb_offshore.DisplayMember = "Name";

            cmb_offshore.AddItem("Y;Y");
            cmb_offshore.AddItem("N;N");

            cmb_offshore.SelectedIndex = -1;

            cmb_offshore.MaxDropDownItems = 10;
            cmb_offshore.Splits[0].DisplayColumns[0].Width = 0;
            cmb_offshore.Splits[0].DisplayColumns[1].Width = 120;

            cmb_offshore.ExtendRightColumn = true;
            cmb_offshore.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_offshore.HScrollBar.Height = 0;

            cmb_offshore.SelectedIndex = -1;
            #endregion

            #region PU Puck Y/N
            cmb_pupuck_yn.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_pupuck_yn.ClearItems();

            cmb_pupuck_yn.AddItemTitles("Code;Name");

            cmb_pupuck_yn.ValueMember = "Code";
            cmb_pupuck_yn.DisplayMember = "Name";

            cmb_pupuck_yn.AddItem("Y;Y");
            cmb_pupuck_yn.AddItem("N;N");

            cmb_pupuck_yn.SelectedIndex = -1;

            cmb_pupuck_yn.MaxDropDownItems = 10;
            cmb_pupuck_yn.Splits[0].DisplayColumns[0].Width = 0;
            cmb_pupuck_yn.Splits[0].DisplayColumns[1].Width = 120;

            cmb_pupuck_yn.ExtendRightColumn = true;
            cmb_pupuck_yn.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_pupuck_yn.HScrollBar.Height = 0;

            cmb_pupuck_yn.SelectedIndex = -1;
            #endregion

            #endregion

            #region Grid Setting
            fgrid_vendor.Set_Grid_CDC("SXD_SRF_VENDOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_vendor.Set_Action_Image(img_Action);
            fgrid_vendor.ExtendLastCol = false;
            _RowFixed_vendor = fgrid_vendor.Rows.Fixed;

            fgrid_desc.Set_Grid_CDC("SXD_SRF_DESC", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_desc.Set_Action_Image(img_Action);
            _RowFixed_desc = fgrid_desc.Rows.Fixed;
            fgrid_desc.ExtendLastCol = false;
            fgrid_desc.AutoSizeCols();

            fgrid_rule.Set_Grid_CDC("SXD_SRF_RULE_LOAD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_rule.Set_Action_Image(img_Action);
            fgrid_rule.Font = new Font("Verdana", 8);
            fgrid_rule.Styles.Normal.WordWrap = true;
            fgrid_rule.ExtendLastCol = false;
            
            #endregion

            #region Form Type Setting
            if (_Form_Type.Equals("S"))
            {
                cmb_factory.SelectedValue     = _head_factory;
                txt_srno.Text                 = _head_sr_no;
                txt_srfno.Text                = _head_srf_no;
                txt_bomid.Text                = _head_bom_id;
                txt_bomrev.Text               = _head_bom_rev;
                cmb_sampletypes.SelectedValue = _head_nf_cd;
                cmb_category.SelectedValue    = _head_category;

                txt_srno.Enabled   = false;
                txt_bomid.Enabled  = false;
                txt_bomrev.Enabled = false;
                txt_srfno.Enabled  = false;

                txt_srno.ReadOnly   = true;
                txt_bomid.ReadOnly = true;

                txt_bomrev.ReadOnly = true;
                txt_srfno.ReadOnly  = true;

                Select_srf_maxseq(cmb_factory.SelectedValue.ToString(), txt_srno.Text, txt_srfno.Text, txt_bomid.Text, txt_bomrev.Text, cmb_sampletypes.SelectedValue.ToString());
                tbtn_Search_Click(null, null);
            }
            if (_Form_Type.Equals("C"))
            {
                this.Text = "PCC_Copy Bom";
                this.lbl_MainTitle.Text = "PCC_Copy Bom";

                cmb_factory.SelectedValue     = _head_factory;
                txt_srno.Text                 = _head_sr_no;
                txt_srfno.Text                = _head_srf_no;
                txt_bomid.Text                = _head_bom_id;
                txt_bomrev.Text               = _head_bom_rev;
                cmb_sampletypes.SelectedValue = _head_nf_cd;
                
                Set_Copy_Base();

                txt_srno.Clear();
                txt_srno.Enabled   = false;
                txt_bomid.Enabled  = true;
                txt_bomrev.Enabled = true;
                txt_srfno.Enabled  = true;

                txt_srno.ReadOnly   = false;
                txt_bomid.ReadOnly  = false;
                txt_bomrev.ReadOnly = false;
                txt_srfno.ReadOnly  = false;

                cmb_sampletypes.Enabled = true;

                dtp_ets.Enabled         = true;
                dtp_need_by.Enabled     = true;
                dtp_order_date.Enabled  = false;
                dtp_current_ipw.Enabled = true;                
            }
            #endregion

            #region 그리드에 표시되는 색 정보
            lbl_part.BackColor   = Color.Red;
            lbl_mrp.BackColor    = Color.Orange;
            lbl_pend.BackColor   = Color.FromArgb(245, 173, 173);
            lbl_delete.BackColor = Color.FromArgb(110, 110, 110);
            #endregion

            Button_Control();

            mnu_sep_04.Visible  = false;
            mnu_combine.Visible = false;
            pnl_bottom.Height = 0;
            chk_gtm_1st.Enabled = false;
            chk_gtm_2nd.Enabled = false;

            if (cmb_sampletypes.SelectedIndex >= 0)
            {
                string _round = cmb_sampletypes.SelectedValue.ToString().Trim();

                if (_round.Equals("JC000") || _round.Equals("JE000") || _round.Equals("JG000") || _round.Equals("KC000") || _round.Equals("KE000") || _round.Equals("KG000"))
                {
                    chk_gtm_1st.Enabled = true;
                    chk_gtm_2nd.Enabled = true; 
                }
            }
        }
        private void Button_Control()
        {
            if ((ClassLib.ComVar.This_Factory == "DS") && ((cmb_factory.SelectedValue.ToString() == "VJ") || (cmb_factory.SelectedValue.ToString() == "QD")))
            {
                tbtn_Create.Enabled  = false;
                tbtn_Save.Enabled    = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Print.Enabled   = false;

                mnt_Confirm_Order.Enabled = false;                
                mnu_multi_corfirm.Enabled = false;
                mnu_update_record.Enabled = false;               
                mnu_multi_change.Enabled  = false;
                mnu_change_order.Enabled  = false;                
                mnu_insert_record.Enabled = false;
                mnu_edit_spec.Enabled     = false;
                mnu_copy_record.Enabled   = false;
                mnu_delete_record.Enabled = false;
                mnu_sep_03.Enabled        = false;
                mnu_copy_specunit.Enabled = false;
                mnu_sep_02.Enabled        = false;
                mnu_pending.Enabled       = false;
                mnu_release.Enabled       = false;
                mnu_sep_01.Enabled        = false;
            }
            else
            {
                tbtn_Create.Enabled  = true;
                tbtn_Save.Enabled    = true;
                tbtn_Confirm.Enabled = true;
                tbtn_Print.Enabled   = true;

                mnt_Confirm_Order.Enabled = true;                
                mnu_multi_corfirm.Enabled = true;
                mnu_update_record.Enabled = true;               
                mnu_multi_change.Enabled  = true;
                mnu_change_order.Enabled  = true;                

                mnu_insert_record.Enabled = true;
                mnu_edit_spec.Enabled     = true;
                mnu_copy_record.Enabled   = true;
                mnu_delete_record.Enabled = true;
                mnu_sep_03.Enabled        = true;
                mnu_copy_specunit.Enabled = true;
                mnu_sep_02.Enabled        = true;
                mnu_pending.Enabled       = true;
                mnu_release.Enabled       = true;
                mnu_sep_01.Enabled        = true;
            }

            if (COM.ComVar.This_CDCPower_Level.Equals("E01"))
            {
                tbtn_Create.Enabled  = false;
                tbtn_Save.Enabled    = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Print.Enabled   = false;

                mnt_Confirm_Order.Enabled = false;
                mnu_multi_corfirm.Enabled = false;
                mnu_update_record.Enabled = false;
                mnu_multi_change.Enabled  = false;
                mnu_change_order.Enabled  = false;

                mnu_insert_record.Enabled = false;
                mnu_edit_spec.Enabled     = false;
                mnu_copy_record.Enabled   = false;
                mnu_delete_record.Enabled = false;
                mnu_sep_03.Enabled        = false;
                mnu_copy_specunit.Enabled = false;
                mnu_sep_02.Enabled        = false;
                mnu_pending.Enabled       = false;
                mnu_release.Enabled       = false;
                mnu_sep_01.Enabled        = false;

                btn_open_file.Enabled = false;

                fgrid_detail.AllowEditing = false;
                fgrid_desc.AllowEditing   = false;
                fgrid_order.AllowEditing  = false;
                fgrid_rule.AllowEditing   = false;
                fgrid_vendor.AllowEditing = false;
            }
        }
        private void Type_Working(string arg_mode)
        {
            _Form_Type = arg_mode;

            if (_Form_Type.Equals("S"))
            {
                #region Select BOM에서 데이터를 불러왔을때
                lbl_srfpath.Visible = false;
                txt_Path.Visible    = false;
                lbl_level.Visible   = true;
                cmb_level.Visible   = true;

                lbl_srfpath.Visible = false;
                txt_Path.Visible    = false;

                tbtn_Create.Enabled  = false;
                tbtn_Append.Enabled  = false;
                tbtn_Color.Enabled   = false;
                tbtn_Confirm.Enabled = true;
                tbtn_Delete.Enabled  = false;
                tbtn_Insert.Enabled  = false;
                tbtn_New.Enabled     = false;
                tbtn_Print.Enabled   = true;
                tbtn_Save.Enabled    = true;
                tbtn_Search.Enabled  = true;

                fgrid_detail.AllowEditing = true;
                fgrid_order.AllowEditing  = true;
                fgrid_vendor.AllowEditing  = true;

                cmb_level.Visible  = true;
                cmb_gender.Enabled = false;

                txt_srfno.Enabled          = false;
                txt_bomid.Enabled          = false;
                txt_bomrev.Enabled         = false;
                txt_srno.Enabled           = false;
                txt_factory_direct.Enabled = false;
                txt_season.Enabled         = false;
                cmb_gender.Enabled         = false;
                txt_state.Enabled          = false;


                txt_mtl_ver.ReadOnly  = true;
                txt_colo_ver.ReadOnly = true;
                txt_patten.ReadOnly   = true;

                dtp_ets.Enabled         = false;
                dtp_need_by.Enabled     = false;
                dtp_current_ipw.Enabled = false;


                if (ClassLib.ComVar.This_CDCGroup_Code == "DEV")
                {
                    fgrid_detail.Set_Grid_CDC("SXD_SRF_TAIL", "6", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_detail.Set_Action_Image(img_Action);
                    fgrid_detail.Font = new Font("Verdana", 8);
                    _RowFixed_detali = fgrid_detail.Rows.Fixed;
                    fgrid_detail.Styles.Normal.WordWrap = true;
                    fgrid_detail.Tree.Column = (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_SEQ;
                }
                else
                {
                    fgrid_detail.Set_Grid_CDC("SXD_SRF_TAIL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_detail.Set_Action_Image(img_Action);
                    fgrid_detail.Font = new Font("Verdana", 8);
                    _RowFixed_detali = fgrid_detail.Rows.Fixed;
                    fgrid_detail.Styles.Normal.WordWrap = true;
                    fgrid_detail.Tree.Column = (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_SEQ;
                }

                fgrid_order.Set_Grid_CDC("SXD_SRF_ORDER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_order.Set_Action_Image(img_Action);
                fgrid_order.Font = new Font("Verdana", 8);
                _RowFixed_order = fgrid_order.Rows.Fixed;
                fgrid_order.Styles.Normal.WordWrap = true;
                fgrid_order.Tree.Column = (int)ClassLib.TBSXD_SRF_ORDER.IxSRF_SEQ;
                #endregion
            }
            else if (_Form_Type == "I")
            {
                #region BOM을 Uploading 할때
                lbl_srfpath.Visible = true;
                txt_Path.Visible  = true;
                lbl_level.Visible = false;
                cmb_level.Visible = false;

                txt_Path.Text = "";



                lbl_srfpath.Visible = true;
                txt_Path.Visible    = true;

                tbtn_Append.Enabled  = false;
                tbtn_Color.Enabled   = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Delete.Enabled  = false;
                tbtn_Insert.Enabled  = false;
                tbtn_New.Enabled     = false;
                tbtn_Print.Enabled   = false;
                tbtn_Save.Enabled    = true;
                tbtn_Search.Enabled  = false;
                tbtn_Create.Enabled  = false;

                fgrid_detail.AllowEditing = false;
                fgrid_vendor.AllowEditing  = false;


                cmb_level.Visible  = false;
                cmb_gender.Enabled = true;


                txt_srfno.Enabled          = false;
                txt_bomid.Enabled          = false;
                txt_bomrev.Enabled         = false;
                txt_srno.Enabled           = false;
                txt_factory_direct.Enabled = true;
                txt_season.Enabled         = false;
                cmb_gender.Enabled         = true;
                txt_state.Enabled          = false;
                txt_mtl_ver.ReadOnly       = false;
                txt_colo_ver.ReadOnly      = false;
                txt_patten.ReadOnly        = false;

                cmb_sampletypes.SelectedIndex = -1;
                cmb_gender.SelectedIndex      = -1;

                dtp_ets.Enabled         = true;
                dtp_need_by.Enabled     = true;
                dtp_current_ipw.Enabled = true;

                fgrid_detail.Set_Grid_CDC("SXD_SRF_TAIL_LOAD", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_detail.Set_Action_Image(img_Action);
                fgrid_detail.Font = new Font("Verdana", 8);
                _RowFixed_detali = fgrid_detail.Rows.Fixed;
                fgrid_detail.Styles.Normal.WordWrap = true;

                fgrid_order.Set_Grid_CDC("SXD_SRF_ORDER_LOAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_order.Set_Action_Image(img_Action);
                fgrid_order.Font = new Font("Verdana", 8);
                _RowFixed_order = fgrid_order.Rows.Fixed;
                fgrid_order.Styles.Normal.WordWrap = true;
                #endregion

            }
            else if (_Form_Type == "C")
            {
                #region Copy BOM
                lbl_srfpath.Visible = false;
                txt_Path.Visible    = false;
                lbl_level.Visible   = false;
                cmb_level.Visible   = false;
                txt_Path.Text       = "";

                lbl_srfpath.Visible = true;
                txt_Path.Visible    = true;

                tbtn_Append.Enabled  = false;
                tbtn_Color.Enabled   = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Delete.Enabled  = false;
                tbtn_Insert.Enabled  = false;
                tbtn_New.Enabled     = false;
                tbtn_Print.Enabled   = false;
                tbtn_Save.Enabled    = true;
                tbtn_Search.Enabled  = false;
                tbtn_Create.Enabled  = false;

                fgrid_detail.AllowEditing = false;
                fgrid_order.AllowEditing  = false;
                fgrid_vendor.AllowEditing  = false;

                cmb_level.Visible  = false;
                cmb_gender.Enabled = true;

                txt_srfno.Enabled          = false;
                txt_bomid.Enabled          = false;
                txt_bomrev.Enabled         = false;
                txt_srno.Enabled           = false;
                txt_factory_direct.Enabled = true;
                txt_season.Enabled         = false;
                cmb_gender.Enabled         = true;
                txt_state.Enabled          = false;
                txt_mtl_ver.ReadOnly       = false;
                txt_colo_ver.ReadOnly      = false;
                txt_patten.ReadOnly        = false;

                dtp_ets.Enabled         = true;
                dtp_need_by.Enabled     = true;
                dtp_current_ipw.Enabled = true;

                fgrid_detail.Set_Grid_CDC("SXD_SRF_TAIL_LOAD", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_detail.Set_Action_Image(img_Action);
                fgrid_detail.Font = new Font("Verdana", 8);
                _RowFixed_detali = fgrid_detail.Rows.Fixed;
                fgrid_detail.Styles.Normal.WordWrap = true;

                fgrid_order.Set_Grid_CDC("SXD_SRF_ORDER_LOAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_order.Set_Action_Image(img_Action);
                fgrid_order.Font = new Font("Verdana", 8);
                _RowFixed_order = fgrid_order.Rows.Fixed;
                fgrid_order.Styles.Normal.WordWrap = true;
                #endregion
            }

            fgrid_detail.Cols.Fixed = 0;
            fgrid_detail.AllowResizing = AllowResizingEnum.Both;
        }
        public void Select_srf_maxseq(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
        {

            DataTable dt = null;
            dt = SELECT_SXD_SRF_SEQ(arg_factory, arg_sr_no, arg_srf_no, arg_bom_id, arg_bom_rev, arg_nf_cd);
            ClassLib.ComCtl.Set_ComboList(dt, cmb_level, 0, 0, false, false);
            if (dt.Rows.Count.Equals(0))
            {
                cmb_level.SelectedIndex = -1;
            }
            else
            {
                cmb_level.SelectedIndex = 0;
            }
        }
        private bool Set_Copy_Base()
        {
            try
            {
                if (Set_head())
                {
                    if (Set_tail_copy())
                    {
                        Set_order_copy();
                    }
                }
                return true;
            }
            catch
            {

                return false;
            }


        }
        private bool Set_tail_copy()
        {


            try
            {
                DataTable dt = null;

                dt = SELECT_SXD_SRF_TAIL_COPY();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    fgrid_detail.AddItem(dt.Rows[i].ItemArray, fgrid_detail.Rows.Count, 1);


                    fgrid_detail[i + fgrid_detail.Rows.Fixed, 0] = "I";

                    fgrid_detail[i + fgrid_detail.Rows.Fixed, 1] = cmb_factory.SelectedValue.ToString();
                    fgrid_detail[i + fgrid_detail.Rows.Fixed, 2] = txt_srno.Text.Trim();
                    fgrid_detail[i + fgrid_detail.Rows.Fixed, 3] = txt_srfno.Text.Trim();
                    fgrid_detail[i + fgrid_detail.Rows.Fixed, 4] = txt_bomid.Text.Trim();
                    fgrid_detail[i + fgrid_detail.Rows.Fixed, 5] = txt_bomrev.Text.Trim();
                    fgrid_detail[i + fgrid_detail.Rows.Fixed, 6] = cmb_sampletypes.SelectedValue.ToString();                    
                }

                return true;
            }
            catch
            {

                return false;
            }



        }
        private bool Set_order_copy()
        {


            try
            {
                DataTable dt = null;

                dt = SELECT_SXD_SRF_ORDER_COPY();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    fgrid_order.AddItem(dt.Rows[i].ItemArray, fgrid_order.Rows.Count, 1);
                    fgrid_order[i + fgrid_order.Rows.Fixed, 0] = "I";

                    fgrid_order[i + fgrid_order.Rows.Fixed, 1] = cmb_factory.SelectedValue.ToString();
                    fgrid_order[i + fgrid_order.Rows.Fixed, 2] = txt_srno.Text.Trim();
                    fgrid_order[i + fgrid_order.Rows.Fixed, 3] = txt_srfno.Text.Trim();
                    fgrid_order[i + fgrid_order.Rows.Fixed, 4] = txt_bomid.Text.Trim();
                    fgrid_order[i + fgrid_order.Rows.Fixed, 5] = txt_bomrev.Text.Trim();
                    fgrid_order[i + fgrid_order.Rows.Fixed, 6] = cmb_sampletypes.SelectedValue.ToString();
                }
 
                return true;
            }
            catch
            {
                return false;
            }
        }

        private DataTable SELECT_SAMPLE_TYPES()
        {
            string Proc_Name = "pkg_sxd_srf_00_select.select_sxb_nf_desc_load";

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


        private DataTable SELECT_TD(string arg_factory)
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            OraDB.Process_Name = "pkg_sxg_mps_01_select.select_td_list";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "out_cursor";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        private DataTable SELECT_SXD_SRF_TAIL_COPY()
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_TAIL_COPY";

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

            OraDB.Parameter_Values[0] = _head_factory;
            OraDB.Parameter_Values[1] = _head_sr_no;
            OraDB.Parameter_Values[2] = _head_srf_no;
            OraDB.Parameter_Values[3] = _head_bom_id;
            OraDB.Parameter_Values[4] = _head_bom_rev;
            OraDB.Parameter_Values[5] = _head_nf_cd;
            OraDB.Parameter_Values[6] = "000";
            OraDB.Parameter_Values[7] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_SXD_SRF_ORDER_COPY()
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_ORDER_COPY";

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

            OraDB.Parameter_Values[0] = _head_factory;
            OraDB.Parameter_Values[1] = _head_sr_no;
            OraDB.Parameter_Values[2] = _head_srf_no;
            OraDB.Parameter_Values[3] = _head_bom_id;
            OraDB.Parameter_Values[4] = _head_bom_rev;
            OraDB.Parameter_Values[5] = _head_nf_cd;
            OraDB.Parameter_Values[6] = "000";
            OraDB.Parameter_Values[7] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable GET_SOURCE_TYPE()
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.GET_SOURCE_TYPE";

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

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_srno.Text.Trim();
            OraDB.Parameter_Values[2] = txt_srfno.Text.Trim();
            OraDB.Parameter_Values[3] = txt_bomid.Text.Trim();
            OraDB.Parameter_Values[4] = txt_bomrev.Text.Trim();
            OraDB.Parameter_Values[5] = cmb_sampletypes.SelectedValue.ToString();
            OraDB.Parameter_Values[6] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion
             
        #region BOM Loading
        private void btn_open_file_Click(object sender, System.EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (_Form_Type == "S")
                {
                    Type_Working("I");
                    save_srno = txt_srno.Text;
                }

                _Form_Type = "I";
                Init_Form();
                Clear_Control();


                if (!Get_file_type()) return;

                
                fgrid_detail.Rows.Count = fgrid_detail.Rows.Fixed;
                fgrid_desc.Rows.Count   = fgrid_desc.Rows.Fixed;
                fgrid_order.Rows.Count  = fgrid_order.Rows.Fixed;
                fgrid_vendor.Rows.Count = fgrid_vendor.Rows.Fixed;
                fgrid_rule.Rows.Count   = fgrid_rule.Rows.Fixed;
                                
                //if (_File_Type.Equals("csv"))
                //{
                //    //_source_type = "C";

                //    //Bom_reader();
                //}
                //else if (_File_Type.Equals("xml"))
                //{
                //    _source_type = "X";

                //    XML_BOM_Loading();
                //}
                //else
                //{
                //    //_source_type = "E";

                //    //Bom_reader();
                //}

                if (_File_Type.Equals("xml"))
                {
                    _source_type = "X";

                    XML_BOM_Loading();
                }
                else
                {
                    MessageBox.Show("Please Loading BOM by XML File.");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #region CSV File
        private void Clear_CSV_Data()
        {
            _head_factory = null;
            _head_sr_no   = null;
            _head_srf_no  = null;
            _head_bom_id  = null;
            _head_bom_rev = null;

            _head_nf_cd     = null;
            _head_srf_seq   = null;
            _head_bom_state = null;
            _head_requestor = null;
            _head_ord_ymd   = null;

            _head_need_by  = null;
            _head_ets      = null;
            _head_mo_alias = null;
            _head_whq_plm  = null;
            _head_whq_dev  = null;

            _head_nlo_dev        = null;
            _head_silhouette     = null;
            _head_technology     = null;
            _head_lasting_method = null;
            _head_ms_method      = null;

            _head_sole_laying_method = null;
            _head_mto_account_name   = null;
            _head_bom_comment        = null;
            _head_factory_dv         = null;
            _head_sesn               = null;

            _head_pattern      = null;
            _head_last_cd      = null;
            _head_dev_name     = null;
            _head_mtl_ver      = null;
            _head_color_ver    = null;
            _head_sample_types = null;

            _head_sta          = null;
            _head_current_ipw  = null;
            _head_product_code = null;
            _head_pur_flg      = null;
            _head_style_cd     = null;

            _head_remarks       = null;
            _head_status        = null;
            _head_load_upd_user = null;
            _head_load_upd_ymd  = null;
            _head_upd_user      = null;
            _head_upd_ymd       = null;

            _head_size   = null;
            _head_gender = null;

            _head_dm_bom_flg     = null;
            _head_prod_ext_color = null;
            _head_pcc_factory    = null;
            _head_ss_factory     = null;
            _head_p_prod_factory = null;
            _head_s_prod_factory = null;

            _head_td_code = null;   
 
        }
        private void Bom_reader()
        {
            Clear_CSV_Data();

            FileInfo file_scv = new FileInfo(txt_Path.Text.Trim());

            if (file_scv.Exists)
            {
                #region Bom 파일 읽기
                FileStream file = null;
                StreamReader sr = null;
                try
                {
                    file = new FileStream(file_scv.Name, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(file);
                }
                catch
                {
                    ClassLib.ComFunction.User_Message("Close CSV File", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string NextLine;
                char char_div   = '"';
                string div      = ",";
                string col_div  = null;
                string srf_data = null;


                string group_div = "§";
                string cols_div  = "◈";

                string line_div = "";
                bool part_type  = false;



                while ((NextLine = sr.ReadLine()) != null)
                {
                    #region D BOM 처리 부분
                    if (NextLine != "")
                    {
                        col_div = NextLine.Split(div.ToCharArray())[0].Replace(char_div.ToString(), "").Trim();
                       
                        if (col_div.Equals("########################################") || col_div.Equals("Airbag Schedule") || col_div.Equals("BOX Schedule") || col_div.Equals("Lace Schedule"))
                        {
                            break;
                        }

                        if (col_div.Equals("Sample Request#") || col_div.Equals("State") || col_div.Equals("Line Items") || col_div.Equals("BOM ID"))
                        {
                        }
                        else if (col_div.Equals("Destination") || col_div.Equals("BOM Data")) srf_data += group_div;                        
                        else if (col_div.Equals("SR Line Item ID"))
                        {
                            line_div = cols_div;
                        }
                        else if (col_div.Equals("BOM Data")) srf_data += group_div;
                        else if (col_div.Equals("Part#"))
                        {
                            srf_data += group_div;
                            part_type = true;
                        }
                        else
                        {
                            if (!part_type)
                            {
                                if (line_div.Equals(cols_div))
                                {
                                    srf_data += "$" + NextLine/*.Replace(div.ToString(), "$")*/ + line_div;
                                    line_div = "";
                                }
                                else
                                {
                                    srf_data += NextLine;
                                }
                            }
                            else
                            {                                
                                string part_end = NextLine.Substring(NextLine.Length - 1);
                                char div_1 = '"';

                                if (part_end == "," || part_end == div_1.ToString())
                                {
                                    srf_data += NextLine + "Ψ";
                                }
                                else
                                {
                                    srf_data += NextLine;
                                }
                            }
                        }
                    }
                    #endregion;
                }

                sr.Close();

                #endregion

                string[] srf_part = srf_data.Split(group_div.ToCharArray());

                if (srf_part.Length.Equals(2))          // M- Bom
                {
                    #region head 데이터 가져오기

                    #region Head 정리하기 - Comma

                    string head_line = "";
                    bool check_div   = false;
                    bool check_add   = true;
                    int col_start    = 0, col_end = 0;

                    for (int i = 0; i < srf_part[0].Length; i++)
                    {
                        char div_1 = '"';

                        if (srf_part[0].Substring(i, 1) == div_1.ToString())
                        {
                            if (check_div == false)
                            {
                                check_div = true;
                                check_add = false;
                                col_start = i;
                            }
                            else
                            {
                                check_div = false;
                                check_add = true;
                                col_end   = i;
                                head_line = head_line + srf_part[0].Substring(col_start, col_end - col_start).ToString().Replace(",", "");                                
                            }
                        }

                        if (check_add == true)
                        {
                            head_line = head_line + srf_part[0].Substring(i, 1).ToString();
                        }
                    }

                    string[] head_info = head_line.Replace(char_div.ToString(), "").Split(",".ToCharArray());

                    #endregion                                       

                    _head_factory       = cmb_factory.SelectedValue.ToString();                    
                    _head_nf_cd         = "";
                    _head_status        = "N";
                    _head_load_upd_user = ClassLib.ComVar.This_User;
                    _head_load_upd_ymd  = "";
                    _head_upd_user      = ClassLib.ComVar.This_User;


                    _head_srf_no  = head_info[4].Replace("-", "");
                    _head_bom_id  = head_info[0];
                    _head_bom_rev = (head_info[1].Trim().Length == 0) ? "0" : head_info[1].Trim();

                    //_head_nf_cd         = null;
                    _head_srf_seq   = null;
                    _head_bom_state = head_info[2];
                    _head_requestor = null;
                    _head_ord_ymd   = null;

                    _head_need_by  = null;
                    _head_ets      = null;
                    _head_mo_alias = head_info[4];
                    _head_whq_plm  = head_info[16];
                    _head_whq_dev  = head_info[17];

                    _head_nlo_dev        = head_info[18];
                    _head_silhouette     = head_info[5];
                    _head_technology     = head_info[6];
                    _head_lasting_method = null;
                    _head_ms_method      = null;

                    _head_sole_laying_method = null;
                    _head_mto_account_name   = null;

                    if (head_info.Length == 26)
                        _head_bom_comment = head_info[26].Replace("'", "");
                    else
                        _head_bom_comment = head_info[24].Replace("'", "");
                   
                    _head_sesn         = head_info[10];
                    _head_pattern      = null;
                    _head_last_cd      = head_info[15];
                    _head_dev_name     = head_info[3];
                    _head_mtl_ver      = head_info[19];
                    _head_color_ver    = head_info[20];
                    _head_sample_types = null;                    
                    _head_current_ipw  = head_info[8];
                    _head_product_code = null;
                    _head_pur_flg      = null;
                    _head_style_cd     = (head_info[7].ToString() == "NA") ? "" : head_info[7].Replace("-", "").Substring(0, 9);
                    _head_remarks      = null;                    
                    _head_size         = null;
                    _head_gender       = null;
                    _head_dm_bom_flg   = null;

                    _head_prod_ext_color = head_info[9];
                    _head_factory_dv     = head_info[21];
                    _head_pcc_factory    = head_info[22];
                    _head_ss_factory     = head_info[23];

                    if (head_info.Length == 27)
                    {
                        _head_p_prod_factory = head_info[24];
                        _head_s_prod_factory = head_info[25];
                    }
                    else
                    {
                        _head_p_prod_factory = "NA";
                        _head_s_prod_factory = "NA";
                    }

                    _head_sr_no = Select_Create_SR_No(_head_factory, _head_srf_no, _head_bom_id, _head_bom_rev).Rows[0].ItemArray[0].ToString();

                    Head_data_setting();

                    fgrid_order.Add_Row(fgrid_order.Rows.Count - 1);

                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSR_NO]   = _head_sr_no;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSRF_NO]  = _head_srf_no;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxBOM_ID]  = _head_bom_id;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxBOM_REV] = _head_bom_rev;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIZE_CD] = "";
                    _head_size = "";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_TYPE]     = "NIKE";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSR_LINE_ITEM] = "0000000000000000000000000";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIDE_TYPE]    = "";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_QTY]      = "0";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxREQUESTER]    = _head_requestor;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_YMD]      = _head_ord_ymd;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxNEED_BY]      = _head_need_by;
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxDESTINATION]  = "";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxGEN_CD]       = head_info[14];
                    //_head_gender = order_line_info[2];
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxWIDTH]    = head_info[13];
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxFIT]      = head_info[12];
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxAGE]      = head_info[11];
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxATTN]     = "";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxNIKE_FLG] = "N";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSTATUS]   = "N";
                    fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxUPD_USER] = ClassLib.ComVar.This_User;

                    fgrid_order.AutoSizeCols();

                    #region part 데이터 가져오기

                    try
                    {

                        string[] part_info = char_con(srf_part[1].Replace(char_div.ToString(), "^")).Replace("^", "").Split("Ψ".ToCharArray());

                        for (int i = 0; i < part_info.Length - 1; i++)
                        {
                            string[] part_line_info = part_info[i].Split("$".ToCharArray());

                            fgrid_detail.Add_Row(fgrid_detail.Rows.Count - 1);


                            if (!part_line_info.Length.Equals(13) && !part_line_info.Length.Equals(14))
                            {
                                fgrid_detail.GetCellRange(fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxFACTORY,
                                    fgrid_detail.Rows.Count - 1, fgrid_detail.Cols.Count - 1).StyleNew.BackColor = Color.Crimson;

                                warning_chk = true;
                            }
                            if (part_line_info.Length.Equals(14))
                            {
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSR_NO]   = _head_sr_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSRF_NO]  = _head_srf_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_ID]  = _head_bom_id;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_REV] = _head_bom_rev;

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]      = part_line_info[0];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]    = part_line_info[1];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]    = part_line_info[2];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT] = part_line_info[3];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]     = part_line_info[4];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = part_line_info[5];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = part_line_info[6];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = part_line_info[7];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]    = part_line_info[8];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]      = part_line_info[9];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]      = part_line_info[10];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT] = part_line_info[11];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]    = part_line_info[12];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSTATUS]   = "N";
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxUPD_USER] = ClassLib.ComVar.This_User;

                            }
                            else
                            {
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSR_NO]   = _head_sr_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSRF_NO]  = _head_srf_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_ID]  = _head_bom_id;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_REV] = _head_bom_rev;

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]      = part_line_info[0];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]    = part_line_info[1];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]    = part_line_info[2];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT] = part_line_info[3];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]     = part_line_info[4];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = part_line_info[5];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = part_line_info[6];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = part_line_info[7];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]    = part_line_info[8];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]      = part_line_info[9];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT] = part_line_info[10];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]    = part_line_info[11];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSTATUS]   = "N";
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxUPD_USER] = ClassLib.ComVar.This_User;
                            }
                        }

                        fgrid_detail.AutoSizeCols();

                        if (warning_chk)
                        {
                            ClassLib.ComFunction.User_Message("Red Color Data maybe have a problem. Please Check Part No..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            warning_chk = false;
                        }
                    }
                    catch
                    {
                        ClassLib.ComFunction.User_Message("Wrong Format : CSV File(Part)", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    #endregion
                    
                    #endregion
                }
                else if (srf_part.Length.Equals(4))    // D- Bom
                {

                    #region head 데이터 가져오기

                    try
                    {

                        string[] head_info = srf_part[0].Replace(char_div.ToString(), "").Split(",".ToCharArray());


                        _head_factory = cmb_factory.SelectedValue.ToString();
                        _head_factory_dv = cmb_factory.SelectedValue.ToString();
                        _head_nf_cd = "";
                        _head_status = "N";
                        _head_load_upd_user = ClassLib.ComVar.This_User;
                        _head_load_upd_ymd = "";
                        _head_upd_user = ClassLib.ComVar.This_User;


                        if (head_info.Length.Equals(14))
                        {
                            _head_sr_no = head_info[0];
                            _head_sample_types = head_info[1];
                            _head_dev_name = head_info[2];
                            _head_srf_no = head_info[3].Replace("-", "");
                            _head_mo_alias = head_info[3];
                            //= head_info[4];
                            _head_sta = head_info[5];
                            _head_requestor = head_info[6];
                            _head_ord_ymd = (head_info[7].Trim().Length > 0) ? DateTime.Parse(head_info[7]).ToString(dateType) : "";//System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); 
                            _head_need_by = (head_info[8].Trim().Length > 0) ? DateTime.Parse(head_info[8]).ToString(dateType) : "";
                            _head_ets = (head_info[9].Trim().Length > 0) ? DateTime.Parse(head_info[9]).ToString(dateType) : "";
                            _head_pattern = head_info[10];
                            _head_bom_id = head_info[12];
                            _head_bom_rev = (head_info[13].Trim().Length == 0) ? "0" : head_info[13].Trim();

                        }
                    }
                    catch
                    {
                        ClassLib.ComFunction.User_Message("Wrong Format : CSV File(BOM)", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {

                        string[] bom_info = char_con(srf_part[2].Replace(char_div.ToString(), "^")).Replace("^", "").Split("$".ToCharArray());

                        if (bom_info.Length.Equals(18))
                        {
                            _head_bom_state = bom_info[0];
                            _head_silhouette = bom_info[1];
                            txt_platform.Text = bom_info[2];
                            //_head_dev_name         = bom_info[3];
                            _head_lasting_method = bom_info[4];
                            _head_ms_method = bom_info[5];
                            _head_sole_laying_method = bom_info[6];
                            _head_last_cd = bom_info[7];
                            _head_product_code = bom_info[8];
                            _head_current_ipw = (bom_info[9].Trim().Length > 0) ? DateTime.Parse(bom_info[9]).ToString(dateType) : "";//= bom_info[9];// DateTime.Parse(bom_info[9]).ToString(dateType);
                            //_head_mo_alias         = bom_info[10].Replace("-","");
                            _head_sesn = bom_info[11];
                            //_head_mto_account_name = bom_info[12];
                            _head_whq_plm = bom_info[12];
                            _head_whq_dev = bom_info[13];
                            _head_nlo_dev = bom_info[14];
                            _head_mtl_ver = bom_info[15];
                            _head_color_ver = bom_info[16];
                            _head_bom_comment = bom_info[17];
                        }
                    }
                    catch
                    {
                        ClassLib.ComFunction.User_Message("Wrong Format : CSV File(BOM)", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cmb_sampletypes.Text = _head_sample_types;







                    #endregion

                    #region order 데이터 가져오기


                    try
                    {
                        string[] order_info = char_con(srf_part[1].Replace(char_div.ToString(), "^")).Replace("^", "").Split(cols_div.ToCharArray());

                        for (int j = 0; j < order_info.Length - 1; j++)
                        {
                            string[] order_line_info = order_info[j].Split("$".ToCharArray());




                            fgrid_order.Add_Row(fgrid_order.Rows.Count - 1);
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSR_NO] = _head_sr_no;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSRF_NO] = _head_srf_no;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxBOM_ID] = _head_bom_id;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxBOM_REV] = _head_bom_rev;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIZE_CD] = order_line_info[3].Replace("'", "");
                            _head_size = order_line_info[3].Replace("'", "");
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_TYPE] = "NIKE";
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSR_LINE_ITEM] = order_line_info[1];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIDE_TYPE] = order_line_info[8];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_QTY] = order_line_info[9];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxREQUESTER] = _head_requestor;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_YMD] = _head_ord_ymd;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxNEED_BY] = _head_need_by;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxDESTINATION] = order_line_info[0];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxGEN_CD] = order_line_info[2];
                            _head_gender = order_line_info[2];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxWIDTH] = order_line_info[4];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxFIT] = order_line_info[5];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxAGE] = order_line_info[6];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxATTN] = order_line_info[7];
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxNIKE_FLG] = "N";
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSTATUS] = "N";
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxUPD_USER] = ClassLib.ComVar.This_User;


                        }

                        fgrid_order.AutoSizeCols();
                    }
                    catch
                    {
                        ClassLib.ComFunction.User_Message("Wrong Format : CSV File(Order)", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    #endregion
                    
                    Head_data_setting();

                    #region part 데이터 가져오기

                    try
                    {

                        string[] part_info = char_con(srf_part[3].Replace(char_div.ToString(), "^")).Replace("^", "").Split("Ψ".ToCharArray());

                        for (int i = 0; i < part_info.Length - 1; i++)
                        {
                            string[] part_line_info = part_info[i].Split("$".ToCharArray());

                            fgrid_detail.Add_Row(fgrid_detail.Rows.Count - 1);


                            if (!part_line_info.Length.Equals(13) && !part_line_info.Length.Equals(14))
                            {
                                fgrid_detail.GetCellRange(fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxFACTORY,
                                    fgrid_detail.Rows.Count - 1, fgrid_detail.Cols.Count - 1).StyleNew.BackColor = Color.Crimson;
                                //ClassLib.ComFunction.User_Message("Wrong Format : CSV File(Part).. Please ask System", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                warning_chk = true;

                            }

                            if (part_line_info.Length.Equals(14))
                            {

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSR_NO] = _head_sr_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSRF_NO] = _head_srf_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_ID] = _head_bom_id;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_REV] = _head_bom_rev;



                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO] = (part_line_info[0] != "") ? part_line_info[0] : Convert.ToString((Convert.ToUInt64(fgrid_detail[fgrid_detail.Rows.Count - 2, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString()) + 0.01));
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE] = (part_line_info[1] != "") ? part_line_info[1] : fgrid_detail[fgrid_detail.Rows.Count - 2, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();

                                //fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO] = part_line_info[0];
                                //fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE] = part_line_info[1];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME] = part_line_info[2];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT] = part_line_info[3];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY] = part_line_info[4];


                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = part_line_info[5];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD] = part_line_info[6];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC] = part_line_info[7];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME] = part_line_info[8];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD] = part_line_info[9];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD] = part_line_info[10];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT] = part_line_info[11];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC] = part_line_info[12];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSTATUS] = "N";
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxUPD_USER] = ClassLib.ComVar.This_User;
                            }
                            else
                            {
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSR_NO] = _head_sr_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSRF_NO] = _head_srf_no;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_ID] = _head_bom_id;
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_REV] = _head_bom_rev;



                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO] = (part_line_info[0] != "") ? part_line_info[0] : Convert.ToString((Convert.ToUInt64(fgrid_detail[fgrid_detail.Rows.Count - 2, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NO].ToString()) + 0.01));
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE] = (part_line_info[1] != "") ? part_line_info[1] : fgrid_detail[fgrid_detail.Rows.Count - 2, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_TYPE].ToString();

                                //fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_NO] = part_line_info[0];
                                //fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD.IxPART_TYPE] = part_line_info[1];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME] = part_line_info[2];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT] = part_line_info[3];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY] = part_line_info[4];


                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = part_line_info[5];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD] = part_line_info[6];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC] = part_line_info[7];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME] = part_line_info[8];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD] = part_line_info[9];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT] = part_line_info[10];
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC] = part_line_info[11];

                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSTATUS] = "N";
                                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxUPD_USER] = ClassLib.ComVar.This_User;
                            }
                        }

                        fgrid_detail.AutoSizeCols();

                        if (warning_chk)
                        {
                            ClassLib.ComFunction.User_Message("Red Color Data maybe have a problem. Please Check Part No..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            warning_chk = false;
                        }
                    }
                    catch
                    {
                        ClassLib.ComFunction.User_Message("Wrong Format : CSV File(Part)", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    #endregion
                }


                DataTable dt_td = Get_max_td_code(cmb_factory.SelectedValue.ToString(), txt_srfno.Text.Trim());

                try
                {
                    if (dt_td.Rows.Count < 1)
                        cmb_td.SelectedIndex = 0;
                    else
                        cmb_td.SelectedValue = dt_td.Rows[0].ItemArray[0].ToString();
                }
                catch
                {
                    cmb_td.SelectedIndex = 0; 
                }
                
            }
        }
        private void Clear_Control()
        {
            txt_srno.Clear();
            txt_srfno.Clear();
            txt_bomid.Clear();
            txt_bomrev.Clear();
            cmb_sampletypes.SelectedIndex = -1;            
            txt_model_name.Clear();
            txt_mo_id.Clear();
            txt_factory_direct.Clear();
            txt_state.Clear();
            txt_requestor.Clear();
            dtp_order_date.Value = DateTime.Now;
            dtp_need_by.Value = DateTime.Now;
            dtp_ets.Value = DateTime.Now;
            txt_patten.Clear();
            txt_style_cd.Clear();
            cmb_gender.SelectedIndex = -1;            
            cmb_td.SelectedIndex = -1;
            cmb_category.SelectedIndex = -1;


            txt_bom_state.Clear();
            txt_silhouette.Clear();
            txt_technology.Clear();
            txt_model_name_bom.Clear();
            txt_lasting_method.Clear();
            txt_ms_method.Clear();
            txt_sole_laying_method.Clear();
            txt_last_cd.Clear();
            txt_product_code.Clear();
            dtp_current_ipw.Value = DateTime.Now;
            txt_mo_alias.Clear();
            txt_season.Clear();
            txt_mto_account_name.Clear();
            txt_whq_plm.Clear();
            txt_whq_dev.Clear();
            txt_nlo_dev.Clear();
            txt_mtl_ver.Clear();
            txt_colo_ver.Clear();
            txt_bom_comments.Clear();

            txt_sr_instruction.Clear();
            txt_demension.Clear();
            txt_platform.Clear();
            txt_last_dim.Clear();
            txt_bom_method.Clear();
            txt_prod_id.Clear();
            txt_inline_size.Clear();
            txt_promo_size.Clear();
            txt_costmat_name.Clear();
            txt_costmat_type.Clear();
            txt_costmat_duty.Clear();
            txt_costmat_tfob.Clear();
            txt_devproj_id.Clear();
            txt_td_code.Clear();
            txt_plm.Clear();
            txt_biz_org.Clear();
            txt_cons_purpose.Clear();
            txt_cons_focus.Clear();
            txt_cons_use.Clear();
            txt_pcc_factory.Clear();
            txt_ss_factory.Clear();

            if (COM.ComVar.This_Factory == "DS")
            {
                cmb_p_prod_fact.SelectedIndex = -1;
                cmb_p_prod_fact.Enabled = true;
            }
            else
            {
                cmb_p_prod_fact.SelectedValue = COM.ComVar.This_Factory;
                cmb_p_prod_fact.Enabled = false;
            }
            
            txt_s_prod_fact.Clear();
            txt_extra_color.Clear();

            null_value = 1;
        }
        private bool Get_file_type()
        {
            openFileDialog.InitialDirectory = "";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return false;
            }

            txt_Path.Text = openFileDialog.FileName;

            int point_position = txt_Path.Text.Trim().Length - 3;
            _File_Type = txt_Path.Text.Trim().ToLower().Substring(point_position);

            if (_File_Type != "xls" && _File_Type != "csv" && _File_Type != "xml") return false;

            return true;
        }
        private string Find_Gender(string arg_nike_gen)
        {
            if (arg_nike_gen != null)
            {
                if (arg_nike_gen.ToUpper() == "FEMALE")
                { _cs_gend = "WO"; }
                else if (arg_nike_gen.ToUpper() == "MALE")
                { _cs_gend = "ME"; }
                else
                { _cs_gend = arg_nike_gen.ToUpper(); }

                return _cs_gend;
            }
            else
            {
                _cs_gend = arg_nike_gen;
                return _cs_gend;
            }
        }
        private void Head_data_setting()
        {            
            _head_factory               = cmb_factory.SelectedValue.ToString();
            txt_srno.Text               = _head_sr_no;
            txt_srfno.Text              = _head_srf_no;
            txt_bomid.Text              = _head_bom_id;
            txt_bomrev.Text             = _head_bom_rev;
            txt_state.Text              = _head_sta;
            txt_bom_comments.Text       = _head_bom_comment;
            txt_season.Text             = _head_sesn;
            txt_factory_direct.Text     = _head_factory_dv;
            txt_bom_state.Text          = _head_sta;
            txt_colo_ver.Text           = _head_color_ver;
            txt_style_cd.Text           = _head_style_cd;
            txt_patten.Text             = _head_pattern;
            txt_model_name_bom.Text     = _head_dev_name;
            txt_last_cd.Text            = _head_last_cd;
            txt_whq_plm.Text            = _head_whq_plm;
            txt_whq_dev.Text            = _head_whq_dev;
            txt_nlo_dev.Text            = _head_nlo_dev;
            txt_bom_state.Text          = _head_bom_state;
            txt_silhouette.Text         = _head_silhouette;
            txt_technology.Text         = _head_technology;
            txt_lasting_method.Text     = _head_lasting_method;
            txt_ms_method.Text          = _head_ms_method;
            txt_sole_laying_method.Text = _head_sole_laying_method;
            txt_mto_account_name.Text   = _head_mto_account_name;
            txt_bom_comments.Text       = _head_bom_comment;
            txt_model_name.Text         = _head_dev_name;
            txt_mo_id.Text              = _head_mo_alias;
            txt_requestor.Text          = _head_requestor;
            txt_mo_alias.Text           = _head_mo_alias;
            txt_product_code.Text       = _head_product_code;
            txt_mtl_ver.Text            = _head_mtl_ver;
            txt_pcc_factory.Text        = _head_pcc_factory;
            txt_ss_factory.Text         = _head_ss_factory;
            txt_s_prod_fact.Text        = _head_s_prod_factory;


            txt_sr_instruction.Text     = _head_sr_instructions;
            txt_demension.Text          = _head_bom_dimension;
            txt_platform.Text           = _head_bom_platform;
            txt_last_dim.Text           = _head_bom_lastdim;
            txt_bom_method.Text         = _head_bom_method;
            txt_prod_id.Text            = _head_productid;
            txt_inline_size.Text        = _head_bom_inlinesizerange;
            txt_promo_size.Text         = _head_bom_promosizerange;
            txt_costmat_name.Text       = _head_cm_name;
            txt_costmat_type.Text       = _head_cm_type;
            txt_costmat_duty.Text       = _head_cm_dutycode;
            txt_costmat_tfob.Text       = _head_cm_tfob;
            txt_mo_alias.Text           = _head_devproj_alias;
            txt_devproj_id.Text         = _head_devproj_id;
            txt_td_code.Text            = _head_tdcode;
            txt_plm.Text                = _head_plm;
            txt_biz_org.Text            = _head_biz_org;
            txt_cons_purpose.Text       = _head_consumer_purpose;
            txt_cons_focus.Text         = _head_consumer_focus;
            txt_cons_use.Text           = _head_consumer_use;
            txt_mo_id.Text              = _head_model_id;
            cmb_spc_yn.SelectedValue    = _head_spc_yn;

            cmb_offshore.SelectedValue  = _head_offshore_yn;
            cmb_pupuck_yn.SelectedValue = _head_pu_puck_yn;
            txt_pupuck_desc.Text        = _head_pu_puck_desc;

            if (_head_gtm_div.Equals("001"))
                chk_gtm_1st.Checked = true;
            else if(_head_gtm_div.Equals("002"))
                chk_gtm_2nd.Checked = true;

            txt_marketing.Text = _head_marketing_name;

            #region Date Setting
            try
            {
                dtp_order_date.CustomFormat = dateType;
                dtp_order_date.Text = comfunction.ConvertDate2Type(_head_ord_ymd);
            }
            catch
            {
                dtp_order_date.CustomFormat = " ";
            }

            try
            {
                dtp_need_by.CustomFormat = dateType;
                dtp_need_by.Text = comfunction.ConvertDate2Type(_head_need_by);
            }
            catch
            {
                dtp_need_by.CustomFormat = " ";
            }

            try
            {
                dtp_ets.CustomFormat = dateType;
                dtp_ets.Text = comfunction.ConvertDate2Type(_head_ets);
            }
            catch
            {
                dtp_ets.CustomFormat = " ";
            }

            try
            {
                dtp_current_ipw.CustomFormat = dateType;
                dtp_current_ipw.Text = comfunction.ConvertDate2Type(_head_current_ipw);
            }
            catch
            {
                dtp_current_ipw.CustomFormat = " ";
            }
            #endregion

            #region PJ Master Setting
            //Gender Setting 
            DataTable dt_list = Select_Max_Gender();

            if (dt_list.Rows[0].ItemArray[0].ToString() == "00")
            {
                string _gen = Find_Gender(_head_gender);

                if (_gen != null)
                {
                    //cmb_gender.Text = _gen;
                    cmb_gender.SelectedValue = _gen;
                }
            }
            else
            {
                //cmb_gender.Text = dt_list.Rows[0].ItemArray[0].ToString();
                cmb_gender.SelectedValue = dt_list.Rows[0].ItemArray[0].ToString();
            }

            dt_list = Select_sxc_pj_mast();

            if (dt_list.Rows.Count < 1)
                cmb_td.SelectedIndex = 0;
            else
                cmb_td.SelectedValue = dt_list.Rows[0].ItemArray[0].ToString();

            //category
            string ref_srf_no = txt_srfno.Text.Trim().Substring(4, txt_srfno.Text.Trim().Length - 7);
            dt_list = Select_SRF_Category(cmb_factory.SelectedValue.ToString(), ref_srf_no);

            string vCategory = dt_list.Rows[0].ItemArray[0].ToString();

            if (!vCategory.Equals("99"))
            {
                cmb_category.SelectedValue = vCategory;
            }
            else
            {
                dt_list = Select_User_Category(cmb_factory.SelectedValue.ToString(), COM.ComVar.This_User);

                if (dt_list.Rows.Count > 0)
                {
                    vCategory = dt_list.Rows[0].ItemArray[0].ToString();
                    cmb_category.SelectedValue = vCategory;
                }
                else
                {
                    cmb_category.SelectedIndex = 0;
                }
            }

            try
            {
                if (COM.ComVar.This_Factory == "DS")
                {
                    if (_head_p_prod_factory.Equals("VJ") || _head_p_prod_factory.Equals("QD"))
                        cmb_p_prod_fact.SelectedValue = _head_p_prod_factory;
                    else
                        cmb_p_prod_fact.SelectedIndex = -1;

                    cmb_p_prod_fact.Enabled = true;
                }
                else
                {
                    cmb_p_prod_fact.SelectedValue = COM.ComVar.This_Factory;
                    cmb_p_prod_fact.Enabled = false;
                }

                
            }
            catch
            {
                if (COM.ComVar.This_Factory == "DS")
                {
                    cmb_p_prod_fact.SelectedIndex = -1;
                }
                else
                {
                    cmb_p_prod_fact.SelectedValue = COM.ComVar.This_Factory; 
                }
            }
            #endregion           
        }           
        #endregion
       
        #region XML File
        private void XML_Clear_Data()
        {
            //Sample Request
             xml_samplerequest_id           = "";
             xml_samplerequest_type         = "";
             xml_samplerequest_state        = "";
             xml_requestor                  = "";
             xml_orderdate                  = "";
             xml_needbydate                 = "";
             xml_estdate                    = "";
             xml_samplerequest_instructions = "";
             xml_pattern_id                 = "";
             xml_modelid                    = "";
             xml_modelname                  = "";
             xml_devproj_alias              = "";
             xml_devproj_id                 = "";
             xml_season                     = "";
             xml_tdcode                     = "";
             xml_factorydirect              = "";
             xml_pccfcty                    = "";
             xml_ssfcty                     = "";
             xml_primprodfcty               = "";
             xml_secprodfcty                = "";
             xml_whqdeveloper               = "";
             xml_nlodeveloper               = "";
             xml_plm                        = "";
             xml_biz_org                    = "";
             xml_consumer_purpose           = "";
             xml_consumer_focus             = "";
             xml_consumer_use               = "";

            //Sample Request Destination
             xml_samplerequest_dest         = "";

            //Sample Request Lineitem
            xml_lineitem_id                = "";
            xml_samplerequest_gender       = "";
            xml_samplerequest_size         = "";
            xml_samplerequest_width        = "";
            xml_samplerequest_fit          = "";
            xml_samplerequest_age          = "";
            xml_samplerequest_attentionto  = "";
            xml_samplerequest_side         = "";
            xml_samplerequest_quantity     = "";
                                                          
            //BOM Information                             
             xml_bom_id                     = "";
             xml_bom_rev                    = "";
             xml_bom_state                  = "";
             xml_bom_dimension              = "";
             xml_bom_silhouette             = "";
             xml_bom_platform               = "";
             xml_bom_lastcode               = "";
             xml_bom_lastdim                = "";
             xml_bom_method                 = "";
             xml_bom_midsolemethod          = "";
             xml_bom_solemethod             = "";
             xml_bom_materialversion        = "";
             xml_bom_colorversion           = "";
             xml_bom_comments               = "";
             xml_bom_prodcolorextabbrv      = "";
             xml_bom_productcode            = "";
             xml_productid                  = "";
             xml_bom_inlinesizerange        = "";
             xml_bom_promosizerange         = "";
             xml_bom_currentipw             = "";
                                                          
            //Costing Material                            
             xml_costingmaterial_name       = "";
             xml_costingmaterial_type       = "";
             xml_costingmaterial_dutycode   = "";
             xml_costingmaterial_tfob       = "";
                                                          
            //Rule                                        
             xml_globalexclusive_type       = "";
             xml_globalexclusive_to         = "";
             xml_initiating_region          = "";
             xml_initiatingexclusive_type   = "";
             xml_initiatingexclusive_to     = "";
                                                          
            //BOM Lineitem                                
             xml_bom_partnumber             = "";
             xml_bom_partname               = "";
             xml_bom_parttype               = "";
             xml_bom_partquantity           = "";
             xml_bom_partcomment            = "";
             xml_bom_colorid                = "";
             xml_bom_colorname              = "";
             xml_bom_colorcomment           = "";
             xml_material_name              = "";
             xml_material_number            = "";
             xml_mcs_number                 = "";
             xml_mxs_number                 = "";
             xml_bom_materialcoment         = "";
             xml_supplier_name              = "";
                                                          
            //Airbag                                      
             xml_airbag_number              = "";
             xml_airbag_name                = "";
             xml_airbag_size                = "";
             xml_airbag_min                 = "";
             xml_airbag_max                 = "";
             xml_airbag_state               = "";
                                                          
            //Box                                         
             xml_box_number                 = "";
             xml_box_name                   = "";
             xml_box_size                   = "";
             xml_box_min                    = "";
             xml_box_max                    = "";
             xml_box_state                  = "";
                                                          
            //Lace                                        
             xml_lace_number                = "";
             xml_lace_name                  = "";
             xml_lace_type                  = "";
             xml_lace_length                = "";
             xml_lace_min                   = "";
             xml_lace_max                   = "";
             xml_lace_state                 = "";
        
        }
        private void XML_BOM_Loading()
        {
            XML_Clear_Data();            
            XML_Init_Grid();
            XML_BOM_Reader(); 
        }
        private void XML_Init_Grid()
        {
            if (_Form_Type.Equals("I"))
            {
                #region BOM을 Uploading 할때
                fgrid_detail.Set_Grid_CDC("SXD_SRF_TAIL_LOAD", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_detail.Set_Action_Image(img_Action);
                fgrid_detail.Font = new Font("Verdana", 8);
                fgrid_detail.Styles.Normal.WordWrap = true;
                fgrid_detail.Rows.Count = fgrid_detail.Rows.Fixed;

                fgrid_order.Set_Grid_CDC("SXD_SRF_ORDER_LOAD", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_order.Set_Action_Image(img_Action);
                fgrid_order.Font = new Font("Verdana", 8);
                fgrid_order.Styles.Normal.WordWrap = true;
                fgrid_order.Rows.Count = fgrid_order.Rows.Fixed;

                fgrid_desc.Set_Grid_CDC("SXD_SRF_DESC", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_desc.Set_Action_Image(img_Action);
                fgrid_desc.ExtendLastCol = false;
                fgrid_desc.AutoSizeCols();
                fgrid_desc.Rows.Count = fgrid_desc.Rows.Fixed;

                fgrid_vendor.Set_Grid_CDC("SXD_SRF_VENDOR", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_vendor.Set_Action_Image(img_Action);
                fgrid_vendor.ExtendLastCol = false;
                fgrid_vendor.Rows.Count = fgrid_vendor.Rows.Fixed;

                fgrid_rule.Set_Grid_CDC("SXD_SRF_RULE_LOAD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_rule.Set_Action_Image(img_Action);
                fgrid_rule.Font = new Font("Verdana", 8);
                fgrid_rule.Styles.Normal.WordWrap = true;
                fgrid_rule.ExtendLastCol = false;
                fgrid_rule.Rows.Count = fgrid_rule.Rows.Fixed;
                #endregion
            }            
        }
        private void XML_BOM_Reader()
        {
            // Read XML File. 
            // Create new FileStream to read schema with. //
            System.IO.FileStream fsReadXml = new System.IO.FileStream(txt_Path.Text, System.IO.FileMode.Open);

            // Create an XmlTextReader to read the file. //
            System.Xml.XmlTextReader myXmlReader = new System.Xml.XmlTextReader(fsReadXml);

            // Read the XML document into the DataSet. //
            DataSet _newDataSet = new DataSet();
            _newDataSet.ReadXml(myXmlReader);

            // Close the XmlTextReader //
            myXmlReader.Close();

            string xml_type = "D";
            if(_newDataSet.DataSetName.Equals("nike_boms"))
                xml_type = "M";

            XML_Data_Setting(_newDataSet, xml_type);
        }
        private void XML_Data_Setting(DataSet arg_ds_xml, string arg_xml_type)
        {
            int table_cnt = arg_ds_xml.Tables.Count;

            for (int i = 0; i < table_cnt; i++)
            {
                string table_name = arg_ds_xml.Tables[i].TableName;
                
                #region D BOM
                if(arg_xml_type.Equals("D"))
                {
                    if (table_name.Equals("nike_samplerequest"))
                    {
                        #region Sample Requests
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if(arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_id"))
                                    xml_samplerequest_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_type"))
                                    xml_samplerequest_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_state"))
                                    xml_samplerequest_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_requestor"))
                                    xml_requestor = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_orderdate"))
                                    xml_orderdate = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_needbydate"))
                                    xml_needbydate = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_estdate"))
                                    xml_estdate = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_instructions"))
                                    xml_samplerequest_instructions = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_pattern_id"))
                                    xml_pattern_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_modelid"))
                                    xml_modelid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_modelname"))
                                    xml_modelname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_devproj_alias"))
                                    xml_devproj_alias = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_devproj_id"))
                                    xml_devproj_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_season"))
                                    xml_season = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_tdcode"))
                                    xml_tdcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_factorydirect"))
                                    xml_factorydirect = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_pccfcty"))
                                    xml_pccfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_ssfcty"))
                                    xml_ssfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_primprodfcty"))
                                    xml_primprodfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_secprodfcty"))
                                    xml_secprodfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_whqdeveloper"))
                                    xml_whqdeveloper = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_nlodeveloper"))
                                    xml_nlodeveloper = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_plm"))
                                    xml_plm = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_biz_org"))
                                    xml_biz_org = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_purpose"))
                                    xml_consumer_purpose = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_focus"))
                                    xml_consumer_focus = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_use"))
                                    xml_consumer_use = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }
                        }                    
                        #endregion                
                    }
                    else if (table_name.Equals("nike_samplerequest_destination"))
                    {
                        #region Sample Requests Destination
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_dest"))
                                    xml_samplerequest_dest = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            fgrid_order.Rows.Add();

                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxDIVISION] = "I";
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxDESTINATION] = xml_samplerequest_dest;
                            
                        }
                        #endregion            
                    }
                    else if (table_name.Equals("nike_samplerequest_lineitem"))
                    {
                        #region Sample Requests Lineitem
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lineitem_id"))
                                    xml_lineitem_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_gender"))
                                    xml_samplerequest_gender = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_size"))
                                    xml_samplerequest_size = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_width"))
                                    xml_samplerequest_width = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_fit"))
                                    xml_samplerequest_fit = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_age"))
                                    xml_samplerequest_age = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_attentionto"))
                                    xml_samplerequest_attentionto = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_side"))
                                    xml_samplerequest_side = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_samplerequest_quantity"))
                                    xml_samplerequest_quantity = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSR_LINE_ITEM] = xml_lineitem_id;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxGEN_CD]       = xml_samplerequest_gender;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSIZE_CD]      = xml_samplerequest_size;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxWIDTH]        = xml_samplerequest_width;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxFIT]          = xml_samplerequest_fit;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxAGE]          = xml_samplerequest_age;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxATTN]         = xml_samplerequest_attentionto;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSIDE_TYPE]    = xml_samplerequest_side;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxORD_QTY]      = xml_samplerequest_quantity;
                            fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxORD_TYPE]     = "NIKE SEND";
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_bom"))
                    {
                        #region BOM Information
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_id"))
                                    xml_bom_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_rev"))
                                    xml_bom_rev = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_state"))
                                    xml_bom_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_dimension"))
                                    xml_bom_dimension = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_silhouette"))
                                    xml_bom_silhouette = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_platform"))
                                    xml_bom_platform = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_lastcode"))
                                    xml_bom_lastcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_lastdim"))
                                    xml_bom_lastdim = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_method"))
                                    xml_bom_method = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_midsolemethod"))
                                    xml_bom_midsolemethod = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_solemethod"))
                                    xml_bom_solemethod = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_materialversion"))
                                    xml_bom_materialversion = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorversion"))
                                    xml_bom_colorversion = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_comments"))
                                    xml_bom_comments = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_prodcolorextabbrv"))
                                    xml_bom_prodcolorextabbrv = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_productcode"))
                                    xml_bom_productcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_productid"))
                                    xml_productid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_inlinesizerange"))
                                    xml_bom_inlinesizerange = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_promosizerange"))
                                    xml_bom_promosizerange = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_currentipw"))
                                    xml_bom_currentipw = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();                               
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_costingmaterial"))
                    {
                        #region Costing Material
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_name"))
                                    xml_costingmaterial_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_type"))
                                    xml_costingmaterial_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_dutycode"))
                                    xml_costingmaterial_dutycode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_tfob"))
                                    xml_costingmaterial_tfob = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();  
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_global_rule"))
                    {
                        #region Grobal Rule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_type"))
                                {
                                    xml_globalexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                   
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_globalexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_to"))
                                {
                                    xml_globalexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = xml_globalexclusive_to;
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_globalexclusive_type"))
                    {
                        #region Grobal Exclusive Type
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_type_text"))
                                {
                                    xml_globalexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                   
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_globalexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_globalexclusive_to"))
                    {
                        #region  Grobal Exclusive To
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_to_text"))
                                {
                                    xml_globalexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = xml_globalexclusive_to;
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingregion_rule"))
                    {
                        #region Initiatingregion Rule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiating_region"))
                                {
                                    xml_initiating_region = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = xml_initiating_region;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_type"))
                                {
                                    xml_initiatingexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_initiatingexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_to"))
                                {
                                    xml_initiatingexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = xml_initiatingexclusive_to;
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingexclusive_type"))
                    {
                        #region Initiatingregion Type
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_type_text"))
                                {
                                    xml_initiatingexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_initiatingexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingexclusive_to"))
                    {
                        #region Initiatingregion To
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_to_text"))
                                {
                                    xml_initiatingexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = xml_initiatingexclusive_to;
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_bom_lineitem"))
                    {
                        #region BOM Lineitem (Part)
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;                        

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partnumber"))
                                {
                                    xml_bom_partnumber = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString().Trim().ToUpper();                                    
                                }
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partname"))
                                    xml_bom_partname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_parttype"))
                                    xml_bom_parttype = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partquantity"))
                                    xml_bom_partquantity = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partcomment"))
                                    xml_bom_partcomment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorid"))
                                    xml_bom_colorid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorname"))
                                    xml_bom_colorname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorcomment"))
                                    xml_bom_colorcomment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_material_name"))
                                    xml_material_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_material_number"))
                                    xml_material_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_mcs_number"))
                                    xml_mcs_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_mxs_number"))
                                    xml_mxs_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_materialcoment"))
                                    xml_bom_materialcoment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_supplier_name"))
                                    xml_supplier_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();                                
                            }

                            fgrid_detail.Rows.Add();

                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";

                            try
                            {
                                if (xml_bom_partnumber.Equals("NULL"))
                                {                                    
                                    if(fgrid_detail.Rows.Count.Equals(fgrid_detail.Rows.Fixed))
                                    {
                                        xml_bom_partnumber = "0";
                                    }
                                    else
                                    {
                                        string pre_value = fgrid_detail[fgrid_detail.Rows.Count - 2, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString().Trim();

                                        int point = pre_value.IndexOf(".");

                                        if (point < 0)
                                        {
                                            xml_bom_partnumber = pre_value + ".0." + null_value.ToString();
                                        }
                                        else
                                        {
                                            xml_bom_partnumber = pre_value.Substring(0, point) + ".0." + null_value.ToString(); 
                                        }
                                    }
                                }
                            }
                            catch
                            {

                            }
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = xml_bom_partnumber;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = xml_bom_parttype;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = xml_bom_partname;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = xml_bom_partcomment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = xml_bom_partquantity;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_material_number;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_material_name;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = xml_bom_materialcoment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = xml_bom_colorid;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = xml_bom_colorname;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = xml_bom_colorcomment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = xml_mcs_number;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = xml_mxs_number;                    
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_airbag_sizeschedule"))
                    {
                        #region Airbag Size Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_number"))
                                    xml_airbag_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_name"))
                                    xml_airbag_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_size"))
                                    xml_airbag_size = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_min"))
                                    xml_airbag_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_max"))
                                    xml_airbag_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_state"))
                                    xml_airbag_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int air_row = fgrid_detail.Rows.Fixed; air_row < fgrid_detail.Rows.Count; air_row++)
                            {
                                string mat_cd = fgrid_detail[air_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_airbag_number.Equals(mat_cd))
                                    row_point = air_row;
                            }

                            if (row_point.Equals(0))
                            {
                                string part_no      = fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                row_point = fgrid_detail.Rows.Count - 1;
                                if(!part_no.IndexOf(".").Equals(-1))
                                    part_no =  Convert.ToString(int.Parse(part_no.Substring(0, part_no.IndexOf("."))) + 1);
                                else
                                    part_no = Convert.ToString(int.Parse(part_no) + 1);

                                part_no = part_no + "." + Convert.ToString(row + 1);                                
                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = "AIRBAG";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = "AIRBAG";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = "2";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_airbag_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_airbag_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_airbag_size;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_airbag_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_airbag_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_airbag_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";         
                            }
                            else
                            {
                                string part_no      = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                if(!part_no.IndexOf(".").Equals(-1))
                                    part_no = part_no.Substring(0, part_no.IndexOf("."));
                                part_no = part_no + "." + Convert.ToString(row + 1);
                                string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                                string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                                string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                                string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_airbag_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_airbag_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_airbag_size;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_airbag_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_airbag_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_airbag_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";                                    
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_box_sizeschedule"))
                    {
                        #region Box Size Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_number"))
                                    xml_box_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_name"))
                                    xml_box_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_size"))
                                    xml_box_size = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_min"))
                                    xml_box_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_max"))
                                    xml_box_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_state"))
                                    xml_box_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int box_row = fgrid_detail.Rows.Fixed; box_row < fgrid_detail.Rows.Count; box_row++)
                            {
                                string mat_cd = fgrid_detail[box_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_box_number.Equals(mat_cd))
                                    row_point = box_row;
                            }

                            if (row_point.Equals(0))
                            {
                                string part_no = fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                row_point = fgrid_detail.Rows.Count - 1;
                                if (!part_no.IndexOf(".").Equals(-1))
                                    part_no = Convert.ToString(int.Parse(part_no.Substring(0, part_no.IndexOf("."))) + 1);
                                else
                                    part_no = Convert.ToString(int.Parse(part_no) + 1);
                                
                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = "OTHER";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = "INNER BOX";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = "2";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_box_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_box_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_box_size;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_box_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_box_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_box_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = ""; 
                            }
                            else
                            {
                                string part_no      = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                if(!part_no.IndexOf(".").Equals(-1))
                                    part_no = part_no.Substring(0, part_no.IndexOf("."));
                                part_no = part_no + "." + Convert.ToString(row + 1);
                                string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                                string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                                string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                                string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_box_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_box_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_box_size;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_box_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_box_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_box_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";                                
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_lace_sizeschedule"))
                    {
                        #region Lace Size Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_number"))
                                    xml_lace_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_name"))
                                    xml_lace_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_type"))
                                    xml_lace_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_length"))
                                    xml_lace_length = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_min"))
                                    xml_lace_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_max"))
                                    xml_lace_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_state"))
                                    xml_lace_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int lace_row = fgrid_detail.Rows.Fixed; lace_row < fgrid_detail.Rows.Count; lace_row++)
                            {
                                string mat_cd = fgrid_detail[lace_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_lace_number.Equals(mat_cd))
                                    row_point = lace_row;
                            }

                            if (row_point.Equals(0))
                            {
                                string part_no = fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                row_point = fgrid_detail.Rows.Count - 1;


                                if (!part_no.IndexOf(".").Equals(-1))
                                    part_no = Convert.ToString(int.Parse(part_no.Substring(0, part_no.IndexOf("."))) + 1);
                                else
                                    part_no = Convert.ToString(int.Parse(part_no) + 1);                                

                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = "UPPER";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = "LACE";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = "2";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_lace_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_lace_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_lace_length;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_lace_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_lace_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_lace_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";
                            }
                            else
                            {
                                string part_no = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                if (row_point.Equals(0))
                                {
                                    row_point = fgrid_detail.Rows.Count - 1;
                                    part_no = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();

                                }
                                
                                if(!part_no.IndexOf(".").Equals(-1))
                                    part_no = part_no.Substring(0, part_no.IndexOf("."));
                                part_no = part_no + "." + Convert.ToString(row + 1);

                                string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                                string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                                string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                                string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_lace_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_lace_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_lace_length;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_lace_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_lace_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_lace_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";
                               
                            }
                        }
                        #endregion
                    }
                }
                #endregion                

                #region M BOM
                if(arg_xml_type.Equals("M"))
                {   
                    if (table_name.Equals("nike_bom"))
                    {
                        #region BOM Information
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_id"))
                                    xml_bom_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_rev"))
                                    xml_bom_rev = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_state"))
                                    xml_bom_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_dimension"))
                                    xml_bom_dimension = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_silhouette"))
                                    xml_bom_silhouette = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_platform"))
                                    xml_bom_platform = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_lastcode"))
                                    xml_bom_lastcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_lastdim"))
                                    xml_bom_lastdim = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_method"))
                                    xml_bom_method = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_midsolemethod"))
                                    xml_bom_midsolemethod = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_solemethod"))
                                    xml_bom_solemethod = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_materialversion"))
                                    xml_bom_materialversion = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorversion"))
                                    xml_bom_colorversion = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_comments"))
                                    xml_bom_comments = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_prodcolorextabbrv"))
                                    xml_bom_prodcolorextabbrv = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_productcode"))
                                    xml_bom_productcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_productid"))
                                    xml_productid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_inlinesizerange"))
                                    xml_bom_inlinesizerange = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_promosizerange"))
                                    xml_bom_promosizerange = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_currentipw"))
                                    xml_bom_currentipw = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_modelid"))
                                    xml_modelid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_modelname"))
                                    xml_modelname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_devproj_alias"))
                                    xml_devproj_alias = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_devproj_id"))
                                    xml_devproj_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_season"))
                                    xml_season = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_tdcode"))
                                    xml_tdcode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_factorydirect"))
                                    xml_factorydirect = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_pccfcty"))
                                    xml_pccfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_ssfcty"))
                                    xml_ssfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_primprodfcty"))
                                    xml_primprodfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_secprodfcty"))
                                    xml_secprodfcty = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_whqdeveloper"))
                                    xml_whqdeveloper = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_nlodeveloper"))
                                    xml_nlodeveloper = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_plm"))
                                    xml_plm = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_biz_org"))
                                    xml_biz_org = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_purpose"))
                                    xml_consumer_purpose = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_focus"))
                                    xml_consumer_focus = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_consumer_use"))
                                    xml_consumer_use = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                               
                            }
                        }
                        #endregion
                    }  
                    else if (table_name.Equals("nike_costingmaterial"))
                    {
                        #region Costing Material
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_name"))
                                    xml_costingmaterial_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_type"))
                                    xml_costingmaterial_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_dutycode"))
                                    xml_costingmaterial_dutycode = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_costingmaterial_tfob"))
                                    xml_costingmaterial_tfob = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();  
                            }
                        }
                        #endregion
                    }                    
                    else if (table_name.Equals("nike_global_rule"))
                    {
                        #region Grobal Rule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_type"))
                                {
                                    xml_globalexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION] = "I";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE] = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_globalexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO] = "";
                                }
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_to"))
                                {
                                    xml_globalexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION] = "I";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE] = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO] = xml_globalexclusive_to;
                                }                                
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_globalexclusive_type"))
                    {
                        #region Grobal Exclusive Type
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_type_text"))
                                {
                                    xml_globalexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                   
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_globalexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_globalexclusive_to"))
                    {
                        #region  Grobal Exclusive To
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_globalexclusive_to_text"))
                                {
                                    xml_globalexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "1";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = xml_globalexclusive_to;
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingregion_rule"))
                    {
                        #region Initiatingregion Rule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiating_region"))
                                {
                                    xml_initiating_region = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = xml_initiating_region;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_type"))
                                {
                                    xml_initiatingexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_initiatingexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_to"))
                                {
                                    xml_initiatingexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = xml_initiatingexclusive_to;
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingexclusive_type"))
                    {
                        #region Initiatingregion Type
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_type_text"))
                                {
                                    xml_initiatingexclusive_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = xml_initiatingexclusive_type;
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = "";
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_initiatingexclusive_to"))
                    {
                        #region Initiatingregion To
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_initiatingexclusive_to_text"))
                                {
                                    xml_initiatingexclusive_to = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();

                                    fgrid_rule.Rows.Add();

                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION]       = "I";                                    
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE]      = "2";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION]         = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE] = "";
                                    fgrid_rule[fgrid_rule.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO]   = xml_initiatingexclusive_to;
                                }
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_bom_lineitem"))
                    {
                        #region BOM Lineitem (Part)
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partnumber"))
                                    xml_bom_partnumber = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString().Trim().ToUpper();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partname"))
                                    xml_bom_partname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_parttype"))
                                    xml_bom_parttype = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partquantity"))
                                    xml_bom_partquantity = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_partcomment"))
                                    xml_bom_partcomment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorid"))
                                    xml_bom_colorid = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorname"))
                                    xml_bom_colorname = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_colorcomment"))
                                    xml_bom_colorcomment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_material_name"))
                                    xml_material_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_material_number"))
                                    xml_material_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_mcs_number"))
                                    xml_mcs_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_mxs_number"))
                                    xml_mxs_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_materialcoment"))
                                    xml_bom_materialcoment = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_supplier_name"))
                                    xml_supplier_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();                                
                            }

                            fgrid_detail.Rows.Add();

                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";

                            try
                            {
                                if (xml_bom_partnumber.Equals("NULL"))
                                {
                                    if (fgrid_detail.Rows.Count.Equals(fgrid_detail.Rows.Fixed))
                                    {
                                        xml_bom_partnumber = "0";
                                    }
                                    else
                                    {
                                        string pre_value = fgrid_detail[fgrid_detail.Rows.Count - 2, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString().Trim();

                                        int point = pre_value.IndexOf(".");

                                        if (point < 0)
                                        {
                                            xml_bom_partnumber = pre_value + ".0." + null_value.ToString();
                                        }
                                        else
                                        {
                                            xml_bom_partnumber = pre_value.Substring(0, point) + ".0." + null_value.ToString();
                                        }

                                        null_value++;
                                    }
                                }
                            }
                            catch
                            {

                            }

                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = xml_bom_partnumber;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = xml_bom_parttype;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = xml_bom_partname;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = xml_bom_partcomment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = xml_bom_partquantity;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_material_number;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_material_name;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = xml_bom_materialcoment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = xml_bom_colorid;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = xml_bom_colorname;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = xml_bom_colorcomment;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = xml_mcs_number;
                            fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = xml_mxs_number;                    
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_airbag_sizeschedule"))
                    {
                        #region Airbag Size Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_number"))
                                    xml_airbag_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_name"))
                                    xml_airbag_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_size"))
                                    xml_airbag_size = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_min"))
                                    xml_airbag_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_max"))
                                    xml_airbag_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_airbag_state"))
                                    xml_airbag_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int air_row = fgrid_detail.Rows.Fixed; air_row < fgrid_detail.Rows.Count; air_row++)
                            {
                                string mat_cd = fgrid_detail[air_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_airbag_number.Equals(mat_cd))
                                    row_point = air_row;
                            }

                            if (row_point.Equals(0))
                            {
                                string part_no      = fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                row_point = fgrid_detail.Rows.Count - 1;
                                if(!part_no.IndexOf(".").Equals(-1))
                                    part_no =  Convert.ToString(int.Parse(part_no.Substring(0, part_no.IndexOf("."))) + 1);
                                else
                                    part_no = Convert.ToString(int.Parse(part_no) + 1);

                                part_no = part_no + "." + Convert.ToString(row + 1);                                
                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = "AIRBAG";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = "AIRBAG";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = "2";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_airbag_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_airbag_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_airbag_size;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_airbag_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_airbag_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_airbag_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";         
                            }
                            else
                            {
                                string part_no      = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                if(!part_no.IndexOf(".").Equals(-1))
                                    part_no = part_no.Substring(0, part_no.IndexOf("."));
                                part_no = part_no + "." + Convert.ToString(row + 1);
                                string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                                string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                                string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                                string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_airbag_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_airbag_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_airbag_size;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_airbag_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_airbag_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_airbag_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";                                    
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_box_sizeschedule"))
                    {
                        #region Box Size Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_number"))
                                    xml_box_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_name"))
                                    xml_box_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_size"))
                                    xml_box_size = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_min"))
                                    xml_box_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_max"))
                                    xml_box_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_box_state"))
                                    xml_box_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int box_row = fgrid_detail.Rows.Fixed; box_row < fgrid_detail.Rows.Count; box_row++)
                            {
                                string mat_cd = fgrid_detail[box_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_box_number.Equals(mat_cd))
                                    row_point = box_row;
                            }

                            if (row_point.Equals(0))
                            {
                                string part_no = fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                row_point = fgrid_detail.Rows.Count - 1;
                                if (!part_no.IndexOf(".").Equals(-1))
                                    part_no = Convert.ToString(int.Parse(part_no.Substring(0, part_no.IndexOf("."))) + 1);
                                else
                                    part_no = Convert.ToString(int.Parse(part_no) + 1);
                                
                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = "OTHER";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = "INNER BOX";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = "2";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_box_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_box_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_box_size;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_box_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_box_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_box_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = ""; 
                            }
                            else
                            {
                                string part_no      = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                if(!part_no.IndexOf(".").Equals(-1))
                                    part_no = part_no.Substring(0, part_no.IndexOf("."));
                                part_no = part_no + "." + Convert.ToString(row + 1);
                                string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                                string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                                string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                                string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_box_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_box_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_box_size;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_box_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_box_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_box_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";                                
                            }
                        }
                        #endregion
                    }
                    else if (table_name.Equals("nike_lace_sizeschedule"))
                    {
                        #region Lace Size Schedule
                        int row_cnt = arg_ds_xml.Tables[i].Rows.Count;
                        int col_cnt = arg_ds_xml.Tables[i].Columns.Count;

                        for (int row = 0; row < row_cnt; row++)
                        {
                            for (int col = 0; col < col_cnt; col++)
                            {
                                if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_number"))
                                    xml_lace_number = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_name"))
                                    xml_lace_name = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_type"))
                                    xml_lace_type = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_length"))
                                    xml_lace_length = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_min"))
                                    xml_lace_min = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_max"))
                                    xml_lace_max = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                                else if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_lace_state"))
                                    xml_lace_state = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
                            }

                            int row_point = 0;
                            for (int lace_row = fgrid_detail.Rows.Fixed; lace_row < fgrid_detail.Rows.Count; lace_row++)
                            {
                                string mat_cd = fgrid_detail[lace_row, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD].ToString();

                                if (xml_lace_number.Equals(mat_cd))
                                    row_point = lace_row;
                            }

                            if (row_point.Equals(0))
                            {
                                string part_no = fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                row_point = fgrid_detail.Rows.Count - 1;


                                if (!part_no.IndexOf(".").Equals(-1))
                                    part_no = Convert.ToString(int.Parse(part_no.Substring(0, part_no.IndexOf("."))) + 1);
                                else
                                    part_no = Convert.ToString(int.Parse(part_no) + 1);                                

                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = "UPPER";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = "LACE";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = "2";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_lace_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_lace_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_lace_length;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_lace_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_lace_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_lace_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";
                            }
                            else
                            {
                                string part_no = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();
                                if (row_point.Equals(0))
                                {
                                    row_point = fgrid_detail.Rows.Count - 1;
                                    part_no = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO].ToString();

                                }
                                
                                if(!part_no.IndexOf(".").Equals(-1))
                                    part_no = part_no.Substring(0, part_no.IndexOf("."));
                                part_no = part_no + "." + Convert.ToString(row + 1);

                                string part_type    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE].ToString();
                                string part_name    = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME].ToString();
                                string part_comment = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT].ToString();
                                string part_qty     = fgrid_detail[row_point, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY].ToString();

                                fgrid_detail.Add_Row(row_point);

                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION]      = "I";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NO]       = part_no;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_TYPE]     = part_type;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_NAME]     = part_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_COMMENT]  = part_comment;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxPART_QTY]      = part_qty;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_CD]        = xml_lace_number;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_NAME]      = xml_lace_name;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_COMMENT]   = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_DESC]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_SIZE]      = xml_lace_length;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_MIN]       = xml_lace_min;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IXMAT_MAX]       = xml_lace_max;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_STATE]     = xml_lace_state;
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMAT_TYPE]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_CD]      = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_DESC]    = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxCOLOR_COMMENT] = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMCS_CD]        = "";
                                fgrid_detail[row_point + 1, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMXS_NUMBER]    = "";
                               
                            }
                        }
                        #endregion
                    }
                }
                #endregion                
            }

            if (arg_xml_type.Equals("M"))
            {
                string arg_factory = cmb_factory.SelectedValue.ToString();
                xml_samplerequest_id = Select_Create_SR_No(arg_factory, xml_devproj_alias.Replace("-", ""), xml_bom_id, xml_bom_rev).Rows[0].ItemArray[0].ToString();

                fgrid_order.Rows.Add();

                fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxDIVISION]     = "I";                
                fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSIDE_TYPE]    = "PAIR";
                fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxORD_QTY]      = "0";
                fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxORD_TYPE]     = "NIKE SEND";
                fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSR_LINE_ITEM] = "00000000000000000000000";
            }
            XML_Head_Setting();
        }
        private void XML_Head_Setting()
        {
            #region SR Information
            txt_srno.Text        = xml_samplerequest_id;
            cmb_sampletypes.Text = xml_samplerequest_type;
            txt_state.Text       = xml_samplerequest_state;
            txt_requestor.Text   = xml_requestor;
            
            try
            {
                string ord_date = xml_orderdate.Replace("/", "");
                int day   = int.Parse(ord_date.Substring(0, 2));
                int month = int.Parse(ord_date.Substring(2, 2));
                int year  = int.Parse(ord_date.Substring(4, 4));

                DateTime date_ord = new DateTime(year, month, day);
                dtp_order_date.Value = date_ord;
            }
            catch{}
            try
            {
                string needby_date = xml_needbydate.Replace("/", "");
                int day   = int.Parse(needby_date.Substring(0, 2));
                int month = int.Parse(needby_date.Substring(2, 2));
                int year  = int.Parse(needby_date.Substring(4, 4));

                DateTime date_needby = new DateTime(year, month, day);
                dtp_need_by.Value = date_needby;
            }
            catch{}
            try
            {
                string est_date = xml_estdate.Replace("/", "");
                int day   = int.Parse(est_date.Substring(0, 2));
                int month = int.Parse(est_date.Substring(2, 2));
                int year  = int.Parse(est_date.Substring(4, 4));

                DateTime date_ets = new DateTime(year, month, day);
                dtp_ets.Value = date_ets;
            }
            catch{}
                
            txt_sr_instruction.Text = xml_samplerequest_instructions;
            txt_patten.Text         = xml_pattern_id;
            txt_mo_id.Text          = xml_modelid;
            txt_model_name.Text     = xml_modelname;
            txt_model_name_bom.Text = xml_modelname;
            txt_mo_alias.Text       = xml_devproj_alias;
            txt_srfno.Text          = xml_devproj_alias.Replace("-", "");
            txt_devproj_id.Text     = xml_devproj_id;
            txt_season.Text         = xml_season;
            txt_td_code.Text        = xml_tdcode;
            txt_factory_direct.Text = xml_factorydirect;
            txt_pcc_factory.Text    = xml_pccfcty;
            txt_ss_factory.Text     = xml_ssfcty;

            try
            {
                if (COM.ComVar.This_Factory == "DS")
                {
                    if (xml_primprodfcty.Equals("VJ") || xml_primprodfcty.Equals("QD"))
                        cmb_p_prod_fact.SelectedValue = xml_primprodfcty;
                    else
                        cmb_p_prod_fact.SelectedIndex = -1;                     
                }
                else
                {
                    cmb_p_prod_fact.SelectedValue = COM.ComVar.This_Factory;
                }                
            }
            catch
            {
                if (COM.ComVar.This_Factory == "DS")
                {
                    cmb_p_prod_fact.SelectedIndex = -1;
                }
                else
                {
                    cmb_p_prod_fact.SelectedValue = COM.ComVar.This_Factory; 
                }
            }

            txt_s_prod_fact.Text    = xml_secprodfcty;
            txt_whq_dev.Text        = xml_whqdeveloper;
            txt_nlo_dev.Text        = xml_nlodeveloper;
            txt_plm.Text            = xml_plm;
            txt_biz_org.Text        = xml_biz_org;
            txt_cons_purpose.Text   = xml_consumer_purpose;
            txt_cons_focus.Text     = xml_consumer_focus;
            txt_cons_use.Text       = xml_consumer_use;
            #endregion

            #region BOM Information
            txt_bomid.Text              = xml_bom_id;

            if (xml_bom_rev.Equals(""))
                xml_bom_rev = "0";
            txt_bomrev.Text             = xml_bom_rev;
            txt_bom_state.Text          = xml_bom_state;
            txt_demension.Text          = xml_bom_dimension;
            txt_silhouette.Text         = xml_bom_silhouette;
            txt_platform.Text           = xml_bom_platform;
            txt_last_cd.Text            = xml_bom_lastcode;
            txt_last_dim.Text           = xml_bom_lastdim;
            txt_bom_method.Text         = xml_bom_method;
            txt_ms_method.Text          = xml_bom_midsolemethod;
            txt_sole_laying_method.Text = xml_bom_solemethod;
            txt_mtl_ver.Text            = xml_bom_materialversion;
            txt_colo_ver.Text           = xml_bom_colorversion;
            txt_bom_comments.Text       = xml_bom_comments;
            txt_extra_color.Text        = xml_bom_prodcolorextabbrv;
            txt_style_cd.Text           = xml_bom_productcode.Replace("-", "");
            txt_product_code.Text       = xml_bom_productcode.Replace("-", "");
            txt_prod_id.Text            = xml_productid;
            txt_inline_size.Text        = xml_bom_inlinesizerange;
            txt_promo_size.Text         = xml_bom_promosizerange;

            try
            {
                string ipw_date = xml_bom_currentipw.Replace("/", "");
                int day   = int.Parse(ipw_date.Substring(0, 2));
                int month = int.Parse(ipw_date.Substring(2, 2));
                int year  = int.Parse(ipw_date.Substring(4, 4));

                DateTime date_ipw = new DateTime(year, month, day);
                dtp_current_ipw.Value = date_ipw;
            }
            catch { }
            #endregion

            #region Costing Material
            txt_costmat_name.Text = xml_costingmaterial_name;
            txt_costmat_type.Text = xml_costingmaterial_type;
            txt_costmat_duty.Text = xml_costingmaterial_dutycode;
            txt_costmat_tfob.Text = xml_costingmaterial_tfob;
            #endregion

            string _gen = Find_Gender(xml_samplerequest_gender);

            if (_gen != null)
            {
                //cmb_gender.Text = ;
                cmb_gender.SelectedValue = _gen;
            }
            else
            {
                cmb_gender.SelectedIndex = -1; 
            }

            if (xml_samplerequest_type.Trim().ToUpper().Replace(" ", "").Equals("FINALADOPTION") || xml_samplerequest_type.Trim().ToUpper().Replace(" ", "").Equals("RLF"))
                cmb_sampletypes.SelectedValue = "G0000";
            else if (xml_samplerequest_type.Trim().ToUpper().Replace(" ", "").Equals("1" + '"' + "STADOPITION") || xml_samplerequest_type.Trim().ToUpper().Replace(" ", "").Equals("SMM"))
                cmb_sampletypes.SelectedValue = "C0000";
            else if (xml_samplerequest_type.Trim().ToUpper().Replace(" ", "").Equals("ACCOUNTSALESSAMPLE") || xml_samplerequest_type.Trim().ToUpper().Replace(" ", "").Equals("ACCOUNTSS") || xml_samplerequest_type.Trim().ToUpper().Replace(" ", "").Equals("ACSS"))
                cmb_sampletypes.SelectedValue = "H0000";            
            else
                cmb_sampletypes.Text = xml_samplerequest_type;

            DataTable dt_list = GET_TD_CODE(cmb_factory.SelectedValue.ToString(), xml_tdcode);

            if (dt_list.Rows.Count > 0)
            {
                cmb_td.SelectedValue = dt_list.Rows[0].ItemArray[0].ToString();
            }
            else
            {
                cmb_td.SelectedIndex = -1;                      
            }            


            //category
            string ref_srf_no = txt_srfno.Text.Trim().Substring(4, txt_srfno.Text.Trim().Length - 7);
            dt_list = Select_SRF_Category(cmb_factory.SelectedValue.ToString(), ref_srf_no);

            string vCategory = dt_list.Rows[0].ItemArray[0].ToString();

            if (!vCategory.Equals("99"))
            {                
                cmb_category.SelectedValue = vCategory;
            }
            else
            {
                _new_srf = true;

                dt_list = Select_User_Category(cmb_factory.SelectedValue.ToString(), COM.ComVar.This_User);

                if (dt_list.Rows.Count > 0)
                {
                    vCategory = dt_list.Rows[0].ItemArray[0].ToString();
                    cmb_category.SelectedValue = vCategory;
                }
                else
                {
                    cmb_category.SelectedIndex = 0;
                }
            }


            for (int detail = fgrid_detail.Rows.Fixed; detail < fgrid_detail.Rows.Count; detail++)
            {
                fgrid_detail[detail, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                fgrid_detail[detail, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSR_NO] = xml_samplerequest_id;
                fgrid_detail[detail, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSRF_NO] = xml_devproj_alias.Replace("-", "");
                fgrid_detail[detail, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_ID] = xml_bom_id;
                fgrid_detail[detail, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_REV] = xml_bom_rev; 
            }
            for (int order = fgrid_order.Rows.Fixed; order < fgrid_order.Rows.Count; order++)
            {
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSR_NO]   = xml_samplerequest_id;
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSRF_NO]  = xml_devproj_alias.Replace("-", "");
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxBOM_ID]  = xml_bom_id;
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxBOM_REV] = xml_bom_rev;

                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxGEN_CD]    = (cmb_gender.SelectedValue == null) ? "" : cmb_gender.SelectedValue.ToString();
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxREQUESTER] = xml_requestor;
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxORD_YMD]   = dtp_order_date.Value.ToString("yyyyMMdd");
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxNEED_BY]   = dtp_need_by.Value.ToString("yyyyMMdd");
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxNIKE_FLG]  = "Y";
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxSTATUS]    = "N";
                fgrid_order[order, (int)ClassLib.TBSXD_SRF_ORDER_LOAD_NEW.IxUPD_USER]  = COM.ComVar.This_User;
            }
            for (int rule = fgrid_rule.Rows.Fixed; rule < fgrid_rule.Rows.Count; rule++)
            {
                fgrid_rule[rule, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                fgrid_rule[rule, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxSR_NO]   = xml_samplerequest_id;
                fgrid_rule[rule, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxSRF_NO]  = xml_devproj_alias.Replace("-", "");
                fgrid_rule[rule, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxBOM_ID]  = xml_bom_id;
                fgrid_rule[rule, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxBOM_REV] = xml_bom_rev;
            }           
        }
        #endregion

        private DataTable Select_Max_Gender()
        {

            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_MAX_GENDER";

            int vCnt = 7, a = 0, b = 0, c = 0;

            OraDB.ReDim_Parameter(vCnt);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[a++] = "ARG_FACTORY";
            OraDB.Parameter_Name[a++] = "ARG_SR_NO";
            OraDB.Parameter_Name[a++] = "ARG_SRF_NO";
            OraDB.Parameter_Name[a++] = "ARG_BOM_ID";
            OraDB.Parameter_Name[a++] = "ARG_BOM_REV";
            OraDB.Parameter_Name[a++] = "ARG_NF_CD";
            OraDB.Parameter_Name[a++] = "OUT_CURSOR";


            OraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[b++] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[c++] = _head_factory;
            OraDB.Parameter_Values[c++] = _head_sr_no;
            OraDB.Parameter_Values[c++] = _head_srf_no;
            OraDB.Parameter_Values[c++] = _head_bom_id;
            OraDB.Parameter_Values[c++] = _head_bom_rev;
            OraDB.Parameter_Values[c++] = _head_nf_cd;
            OraDB.Parameter_Values[c++] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable Select_Create_SR_No(string arg_factory, string arg_srf_no, string arg_bom_id, string arg_bom_rev)
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_CREATE_SR_NO";

            OraDB.ReDim_Parameter(5);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SRF_NO";
            OraDB.Parameter_Name[2] = "ARG_BOM_ID";
            OraDB.Parameter_Name[3] = "ARG_BOM_REV";
            OraDB.Parameter_Name[4] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_srf_no;
            OraDB.Parameter_Values[2] = arg_bom_id;
            OraDB.Parameter_Values[3] = arg_bom_rev;
            OraDB.Parameter_Values[4] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable Select_sxc_pj_mast()
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXC_PJ_MAST";

            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SRF_NO";
            OraDB.Parameter_Name[2] = "ARG_BOM_ID";
            OraDB.Parameter_Name[3] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = _head_factory;
            OraDB.Parameter_Values[1] = _head_srf_no;
            OraDB.Parameter_Values[2] = _head_bom_id;
            OraDB.Parameter_Values[3] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable Get_max_td_code(string arg_factory, string arg_srf_no)
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "pkg_sxg_mps_01_select.get_max_td_code";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_srf_no";
            OraDB.Parameter_Name[2] = "out_cursor";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_srf_no;
            OraDB.Parameter_Values[2] = "";

            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        private DataTable Select_User_Category(string arg_factory, string arg_load_user)
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXD_SRF_01_SELECT.SELECT_USER_CATEGORY";

                OraDB.ReDim_Parameter(3);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_LOAD_USER";
                OraDB.Parameter_Name[2] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                OraDB.Parameter_Values[0] = arg_factory;
                OraDB.Parameter_Values[1] = arg_load_user;
                OraDB.Parameter_Values[2] = "";

                OraDB.Add_Select_Parameter(true);
                ds_ret = OraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];

            }
            catch
            {
                return null;
            }

        }
        private DataTable Select_SRF_Category(string arg_factory, string arg_srf_no)
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXD_SRF_01_SELECT.SELECT_SRF_CATEGORY";

                OraDB.ReDim_Parameter(3);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_SRF_NO";
                OraDB.Parameter_Name[2] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                OraDB.Parameter_Values[0] = arg_factory;
                OraDB.Parameter_Values[1] = arg_srf_no;
                OraDB.Parameter_Values[2] = "";

                OraDB.Add_Select_Parameter(true);
                ds_ret = OraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];

            }
            catch
            {
                return null;
            }

        }
        private DataTable GET_TD_CODE(string arg_factory, string arg_td)
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXD_SRF_01_SELECT.GET_TD_CODE";

                OraDB.ReDim_Parameter(3);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_TD";
                OraDB.Parameter_Name[2] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                OraDB.Parameter_Values[0] = arg_factory;
                OraDB.Parameter_Values[1] = arg_td;
                OraDB.Parameter_Values[2] = "";

                OraDB.Add_Select_Parameter(true);
                ds_ret = OraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];

            }
            catch
            {
                return null;
            }

        }
        #endregion

        #region Search Data
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

                if (Set_head())
                {
                    if (Set_tail())
                    {
                        Set_order();
                        Set_vendor();
                    }
                }
            }
            catch
            {                
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private bool Set_head()
        {
            DataTable dt = null;

            if (_Form_Type.Equals("C"))
                dt = SELECT_SXD_SRF_HEAD_COPY();
            else
                dt = SELECT_SXD_SRF_HEAD();

            if (dt.Rows.Count == 0) return false;

            _head_sr_no   = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSR_NO].ToString();
            _head_srf_no  = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSRF_NO].ToString();
            _head_bom_id  = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_ID].ToString();
            _head_bom_rev = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_REV].ToString();

            _head_bom_state = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_STATE].ToString();
            _head_requestor = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxREQUESTOR].ToString();
            _head_ord_ymd   = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxORD_YMD].ToString();
            _head_need_by   = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxNEED_BY].ToString();
            _head_ets       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxETS].ToString();

            _head_mo_alias   = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxMO_ALIAS].ToString();
            _head_whq_plm    = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxWHQ_PLM].ToString();
            _head_whq_dev    = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxWHQ_DEV].ToString();
            _head_nlo_dev    = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxNLO_DEV].ToString();
            _head_silhouette = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSILHOUETTE].ToString();

            _head_technology         = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxTECHNOLOGY].ToString();
            _head_lasting_method     = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxLASTING_ME].ToString();
            _head_ms_method          = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxMS_ME].ToString();
            _head_sole_laying_method = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSOLE_LAYING].ToString();
            _head_mto_account_name   = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxMTO_ACC].ToString();

            _head_bom_comment = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_COMMENT].ToString();
            _head_factory_dv  = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxFACTORY_DV].ToString();
            _head_sesn        = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSESN].ToString();
            _head_pattern     = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPATTERN].ToString();
            _head_last_cd     = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxLAST_CD].ToString();

            _head_dev_name     = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxDEV_NAME].ToString();
            _head_mtl_ver      = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxMTL_VER].ToString();
            _head_color_ver    = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxCOLOR_VER].ToString();
            _head_sample_types = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSAMPLE_TYPES].ToString();
            _head_sta          = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSTA].ToString();

            _head_current_ipw  = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxCURRENT_IPW].ToString();
            _head_product_code = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPRODUCT_CODE].ToString();
            _head_pur_flg      = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPUR_FLG].ToString();
            _head_style_cd     = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSTYLE_CD].ToString();

            _head_remarks = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxREMARKS].ToString();

            _head_status        = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSTATUS].ToString();
            _head_load_upd_user = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxLOAD_UPD_USER].ToString();

            _head_prod_ext_color = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPROD_EXT_COLOR].ToString();
            _head_pcc_factory    = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPCC_FACTORY].ToString();
            _head_ss_factory     = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSS_FACTORY].ToString();
            _head_p_prod_factory = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxP_PROD_FACTORY].ToString();
            _head_s_prod_factory = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxS_PROD_FACTORY].ToString();

            _head_sr_instructions     = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSR_INSTRUCTIONS    ].ToString();
            _head_bom_dimension       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_DIMENSION      ].ToString();
            _head_bom_platform        = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_PLATFORM       ].ToString();
            _head_bom_lastdim         = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_LASTDIM        ].ToString();
            _head_bom_method          = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_METHOD         ].ToString();
            _head_productid           = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPRODUCTID          ].ToString();
            _head_bom_inlinesizerange = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_INLINESIZERANGE].ToString();
            _head_bom_promosizerange  = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBOM_PROMOSIZERANGE ].ToString();
            _head_cm_name             = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxCM_NAME            ].ToString();
            _head_cm_type             = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxCM_TYPE            ].ToString();
            _head_cm_dutycode         = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxCM_DUTYCODE        ].ToString();
            _head_cm_tfob             = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxCM_TFOB            ].ToString();
            _head_devproj_alias       = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxDEVPROJ_ALIAS      ].ToString();
            _head_devproj_id          = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxDEVPROJ_ID         ].ToString();
            _head_tdcode              = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxTDCODE             ].ToString();
            _head_plm                 = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPLM                ].ToString();
            _head_biz_org             = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxBIZ_ORG            ].ToString();
            _head_consumer_purpose    = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxCONSUMER_PURPOSE   ].ToString();
            _head_consumer_focus      = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxCONSUMER_FOCUS     ].ToString();
            _head_consumer_use        = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxCONSUMER_USE       ].ToString();
            _head_model_id            = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxMODEL_ID           ].ToString();
            _head_spc_yn              = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxSPC_YN             ].ToString();
            _head_gtm_div             = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxGTM_DIV            ].ToString();
            _head_marketing_name      = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxMARKETING_NAME     ].ToString();
            _head_offshore_yn         = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxOFFSHORE_YN        ].ToString();
            _head_pu_puck_yn          = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPU_PUCK_YN         ].ToString();
            _head_pu_puck_desc        = dt.Rows[0].ItemArray[(int)ClassLib.TBSXD_SRF_HEAD.IxPU_PUCK_DESC       ].ToString();
            _head_upd_user            = ClassLib.ComVar.This_User;

            Head_data_setting();


            _source_type = GET_SOURCE_TYPE().Rows[0].ItemArray[0].ToString();

            return true;
        }
        private bool Set_tail()
        {
            DataTable dt = null;

            color_check = true;
            dt = SELECT_SXD_SRF_TAIL();
            if (dt.Rows.Count == 0) return false;



            int dt_rows = dt.Rows.Count;
            int dt_cols = dt.Columns.Count;

            fgrid_detail.Rows.Count = _RowFixed_detali;


            for (int i = 0; i < dt_rows; i++)
            {
                int tree_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].ToString());
                fgrid_detail.Rows.InsertNode(fgrid_detail.Rows.Count, tree_level);

                int mat_length = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString().Length;
                int color_length = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD].ToString().Length;
                string iskname = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxISKNAME].ToString();

                if (mat_length > 0 && color_length.Equals(0))
                {
                    fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
                    color_check = true;
                }


                if (!iskname.Equals("0"))
                {
                    fgrid_detail.GetCellRange(fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC,
                        fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC).StyleNew.ForeColor = Color.FromArgb(149, 153, 223);
                    fgrid_detail.GetCellRange(fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD,
                        fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD).StyleNew.ForeColor = Color.FromArgb(149, 153, 223);
                    fgrid_detail.GetCellRange(fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD,
                        fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD).StyleNew.ForeColor = Color.FromArgb(149, 153, 223);
                }

                fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;
                string change_r_flg = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG].ToString();

                #region MRP 조건 체크 & 경고
                string _mat_cd   = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString().Trim().Replace(" ", "");
                string _mat_name = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxMAT_NAME].ToString().Trim().Replace(" ", "");
                string _spec_cd  = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD].ToString().Trim().Replace(" ", "");
                string _unit_cd  = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD].ToString().Trim().Replace(" ", "");
                string _yield    = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxYIELD_VALUE].ToString().Trim().Replace(" ", "");
                string _pur_div  = dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL.IxPUR_DIV].ToString().Trim().Replace(" ", "");

                if (_mat_cd != "")
                {
                    if (_spec_cd.Equals("") || _unit_cd.Equals("") || _yield.Equals("0") || _yield.Equals("") || _pur_div.Equals(""))
                    {
                        fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].StyleNew.BackColor = Color.Orange;
                    }
                }
                else if(_mat_cd.Equals("") || _mat_name.Equals(""))
                {
                    fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].StyleNew.BackColor = Color.Orange; 
                }                
                #endregion

                if (change_r_flg.Equals("P"))//Pending
                {
                    fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(245, 173, 173);
                    fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].AllowEditing = false;
                }
                else if (change_r_flg.Equals("D"))//Delete
                {
                    fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(110, 110, 110);
                    fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].AllowEditing = false;
                }

                for (int j = 0; j < dt_cols; j++)
                {
                    fgrid_detail[fgrid_detail.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();

                    if (j == (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL)
                    {
                        if (!dt.Rows[i].ItemArray[j].Equals("1"))
                        {
                            fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].AllowEditing = false;
                        }
                    }


                }
            }

            fgrid_detail.Tree.Show(1);
            return true;
        }
        private bool Set_order()
        {
            DataTable dt = null;
            dt = SELECT_SXD_SRF_ORDER();

            if (dt.Rows.Count == 0) return false;

            int dt_rows = dt.Rows.Count;
            int dt_cols = dt.Columns.Count;

            fgrid_order.Rows.Count = _RowFixed_order;


            for (int i = 0; i < dt_rows; i++)
            {
                int tree_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_ORDER.IxSRF_LEVEL].ToString());
                fgrid_order.Rows.InsertNode(fgrid_order.Rows.Count, tree_level);

                for (int j = 0; j < dt_cols; j++)
                {
                    fgrid_order[fgrid_order.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();

                    if (j.Equals((int)ClassLib.TBSXD_SRF_ORDER.IxSRF_LEVEL))
                    {
                        if (!dt.Rows[i].ItemArray[j].Equals("1"))
                        {
                            fgrid_order.Rows[fgrid_order.Rows.Count - 1].AllowEditing = false;
                        }
                    }
                }
            }
            fgrid_order.Tree.Show(1);
            return true;
        }
        private void Set_vendor()
        {
            DataTable dt = null;
            dt = SELECT_SXD_SRF_VENDOR();

            int dt_rows = dt.Rows.Count;
            int dt_cols = dt.Columns.Count;

            fgrid_vendor.Rows.Count = _RowFixed_vendor;

            for (int i = 0; i < dt_rows; i++)
            {
                fgrid_vendor.AddItem(dt.Rows[i].ItemArray, fgrid_vendor.Rows.Count, 1);
            }

            fgrid_vendor.AllowMerging = AllowMergingEnum.Free;

            for (int i = 0; i < fgrid_vendor.Cols.Count; i++)
            {
                if (i == 7 || i == 8 || i == 9)
                    fgrid_vendor.Cols[i].AllowMerging = true;
                else
                    fgrid_vendor.Cols[i].AllowMerging = false;
            }

            fgrid_vendor.AutoSizeCols();
        }

        private DataTable SELECT_SXD_SRF_HEAD()
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
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_SXD_SRF_HEAD_COPY()
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_HEAD_COPY";

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

            OraDB.Parameter_Values[0] = _head_factory;
            OraDB.Parameter_Values[1] = _head_sr_no;
            OraDB.Parameter_Values[2] = _head_srf_no;
            OraDB.Parameter_Values[3] = _head_bom_id;
            OraDB.Parameter_Values[4] = _head_bom_rev;
            OraDB.Parameter_Values[5] = _head_nf_cd;
            OraDB.Parameter_Values[6] = "000";
            OraDB.Parameter_Values[7] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_SXD_SRF_TAIL()
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
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_SXD_SRF_ORDER()
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
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_SXD_SRF_VENDOR()
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
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                fgrid_detail.Select(fgrid_detail.Selection.r1, 0, fgrid_detail.Selection.r1, fgrid_detail.Cols.Count - 1, false);
                fgrid_order.Select(fgrid_order.Selection.r1, 0, fgrid_order.Selection.r1, fgrid_order.Cols.Count - 1, false);
                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;

                if (_Form_Type.Equals("C") && _jobcount == "0")
                {
                    DataTable dt;
                    dt = CREATE_SR_NO();
                    txt_srno.Text = dt.Rows[0].ItemArray[0].ToString();
                    _jobcount = "0";
                }

                if (_Form_Type.Equals("C") && _jobcount == "0")
                {
                    DataTable dt = CHECK_SXD_SRF_HEAD();
                    if (dt.Rows[0].ItemArray[0].ToString() != "0")
                    {
                        ClassLib.ComFunction.User_Message("Already Existed BOM", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Set_grid_key();
                    _jobcount = "1";
                }

                if (txt_srno.Text.Trim().Length.Equals(0))
                {
                    ClassLib.ComFunction.User_Message("Input Error : SR No", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmb_p_prod_fact.SelectedIndex == -1)
                {
                    ClassLib.ComFunction.User_Message("Input Error : Product Factory", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                if (cmb_spc_yn.SelectedIndex == -1)
                {
                    ClassLib.ComFunction.User_Message("Input Error : SPC Y/N", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmb_offshore.SelectedIndex == -1)
                {
                    ClassLib.ComFunction.User_Message("Input Error : Offshore Y/N", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //if (cmb_pupuck_yn.SelectedIndex == -1)
                //{
                //    ClassLib.ComFunction.User_Message("Input Error : PU Puck Y/N", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                string _round = cmb_sampletypes.SelectedValue.ToString().Trim();

                if (_round.Equals("JC000") || _round.Equals("JE000") || _round.Equals("JG000") || _round.Equals("KC000") || _round.Equals("KE000") || _round.Equals("KG000"))
                {
                    bool chk_1st = chk_gtm_1st.Checked;
                    bool chk_2nd = chk_gtm_2nd.Checked;

                    if (!chk_1st && !chk_2nd)
                    {
                        MessageBox.Show("Please check  GTM 1st or 2nd");
                        return;
                    }
                }

                if (_Form_Type.Equals("I") || _Form_Type.Equals("C"))
                {
                    if (Insert_SRF_Data())
                    {
                        tbtn_Search_Click(null, null);
                        cmb_td.SelectedValue = _head_td_code;
                    }
                }
                else
                {
                    if (Edit_SRF_Data())
                    {
                        Select_srf_maxseq(cmb_factory.SelectedValue.ToString(), txt_srno.Text, txt_srfno.Text, txt_bomid.Text, txt_bomrev.Text, cmb_sampletypes.SelectedValue.ToString());
                        tbtn_Search_Click(null, null);
                    }

                }

                fgrid_detail.Select(sct_row, sct_col);
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
        private bool Insert_SRF_Data()
        {
            #region Check Data
            if (cmb_sampletypes.SelectedIndex == -1)
            {
                ClassLib.ComFunction.User_Message("Input Error : Round Type", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_sampletypes.Focus();
                return false;
            }

            if (cmb_sampletypes.SelectedValue.ToString() == "Y0000")
            {
                if (txt_style_cd.Text.Trim().Length == 0)
                {
                    ClassLib.ComFunction.User_Message("Input Error : Style", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_style_cd.Enabled = true;
                    return false;
                }
                if (txt_style_cd.Text.Trim().Length != 9)
                {
                    ClassLib.ComFunction.User_Message("Input Error : Wrong Style", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_style_cd.Enabled = true;
                    return false;
                }

            }


            if (cmb_gender.SelectedIndex == -1)
            {
                ClassLib.ComFunction.User_Message("Input Error : Gender", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_gender.Focus();
                return false;
            }

            if (dtp_need_by.CustomFormat == " ")
            {
                ClassLib.ComFunction.User_Message("Input Error : Need By", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_need_by.Focus();
                return false;
            }
            else if (dtp_ets.CustomFormat == " ")
            {
                ClassLib.ComFunction.User_Message("Input Error : ETS", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_ets.Focus();
                return false;
            }
            else if (dtp_current_ipw.CustomFormat == " ")
            {
                ClassLib.ComFunction.User_Message("Input Error : IPW", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_current_ipw.Focus();
                return false;
            }
            else
            {
                _head_need_by = dtp_need_by.Text;
                _head_ets = dtp_ets.Text;
                _head_current_ipw = dtp_current_ipw.Text;
            }


            //date compare
            if (Convert.ToDouble(dtp_need_by.Text.ToString()) <= Convert.ToDouble(dtp_ets.Text.ToString()))
            {
                ClassLib.ComFunction.User_Message("Input Error : ETS Date is latter than Need By", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tab_control.SelectedIndex = 1;
                return false;
            }


            if (fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIZE_CD] == null || fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIZE_CD].ToString().Trim().Equals(""))
            {
                ClassLib.ComFunction.User_Message("Input Error : Size Code", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //dtp_current_ipw.Focus();
                tab_control.SelectedIndex = 1;
                return false;
            }
            else if (fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIDE_TYPE] == null || fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIDE_TYPE].ToString().Trim().Equals(""))
            {
                ClassLib.ComFunction.User_Message("Input Error : Side Type", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //dtp_current_ipw.Focus();
                tab_control.SelectedIndex = 1;
                return false;
            }
            else if (fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_QTY] == null || fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_QTY].ToString().Trim().Equals("0"))
            {
                ClassLib.ComFunction.User_Message("Input Error : Order Qty.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //dtp_current_ipw.Focus();
                tab_control.SelectedIndex = 1;
                return false;
            }
            #endregion

            DataTable dt = null;

            if (_Form_Type.Equals("C"))
                dt = SELECT_SXD_SRF_SEQ(cmb_factory.SelectedValue.ToString(), txt_srno.Text, txt_srfno.Text, txt_bomid.Text, txt_bomrev.Text, cmb_sampletypes.SelectedValue.ToString());
            else
                dt = SELECT_SXD_SRF_SEQ(cmb_factory.SelectedValue.ToString(), txt_srno.Text, txt_srfno.Text, txt_bomid.Text, txt_bomrev.Text, cmb_sampletypes.SelectedValue.ToString());

            if (dt.Rows.Count.Equals(0))
            {
                if (SAVE_SXD_SRF_HEAD_LOAD())
                {
                    #region Save Order 
                    for (int i = _RowFixed_order; i < fgrid_order.Rows.Count; i++)
                    {
                        string[] order_items = new string[(int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxMaxCt - 1];

                        
                        if (fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxDIVISION].Equals("I"))
                        {
                            string _size_cd = (fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIZE_CD] == null) ? "" : fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIZE_CD].ToString().Trim();

                            if (_size_cd.Equals(""))
                            {
                                MessageBox.Show("Pleas Insert Size Code");
                                tab_control.SelectedIndex = 1;
                            }

                            for (int j = (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxFACTORY; j < fgrid_order.Cols.Count; j++)
                            {
                                try
                                {
                                    order_items[j - 1] = fgrid_order[i, j].ToString();
                                }
                                catch
                                {   
                                    order_items[j - 1] = "";
                                }
                            }
                            SAVE_SXD_SRF_ORDER_LOAD(order_items);
                        }
                    }
                    #endregion

                    #region Save Tail
                    for (int i = _RowFixed_detali; i < fgrid_detail.Rows.Count; i++)
                    {
                        string[] tail_items = new string[(int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxMaxCt - 2];

                        if (fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxDIVISION].Equals("I"))
                        {
                            for (int j = (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxFACTORY; j < fgrid_detail.Cols.Count - 1; j++)
                            {
                                tail_items[j - 1] = (fgrid_detail[i, j] == null)?"": fgrid_detail[i, j].ToString();
                            }

                            SAVE_SXD_SRF_TAIL_LOAD(tail_items);
                        }
                    }
                    #endregion

                    #region Save Rule
                    for (int i = fgrid_rule.Rows.Fixed; i < fgrid_rule.Rows.Count; i++)
                    {
                        string[] rule_items = new string [10];

                        if (fgrid_rule[i, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxDIVISION].Equals("I"))
                        {
                            rule_items[0] = fgrid_rule[i, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxFACTORY].ToString();
                            rule_items[1] = fgrid_rule[i, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxSR_NO].ToString();
                            rule_items[2] = fgrid_rule[i, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxSRF_NO].ToString();
                            rule_items[3] = fgrid_rule[i, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxBOM_ID].ToString();
                            rule_items[4] = fgrid_rule[i, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxBOM_REV].ToString();
                            rule_items[5] = cmb_sampletypes.SelectedValue.ToString();
                            rule_items[6] = fgrid_rule[i, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxRULE_TYPE].ToString();
                            rule_items[7] = fgrid_rule[i, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxREGION].ToString();
                            rule_items[8] = fgrid_rule[i, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TYPE].ToString();
                            rule_items[9] = fgrid_rule[i, (int)ClassLib.TBSXD_SRF_RULE_LOAD_NEW.IxEXCLUSIVE_TO].ToString();

                            SAVE_SXD_SRF_RULE_LOAD(rule_items);
                        }
                    }
                    fgrid_rule.Rows.Count = fgrid_rule.Rows.Fixed;
                    #endregion

                    #region Copy BOM 일 경우
                    if (_Form_Type.Equals("C"))
                    {
                        Select_srf_maxseq(cmb_factory.SelectedValue.ToString(), txt_srno.Text, txt_srfno.Text, txt_bomid.Text, txt_bomrev.Text, cmb_sampletypes.SelectedValue.ToString());

                        _head_factory = cmb_factory.SelectedValue.ToString();
                        _head_sr_no   = txt_srno.Text;
                        _head_srf_no  = txt_srfno.Text;
                        _head_bom_id  = txt_bomid.Text;
                        _head_bom_rev = txt_bomrev.Text;
                        _head_nf_cd   = cmb_sampletypes.SelectedValue.ToString();

                        _Form_Type = "I";
                    }
                    #endregion

                    #region Save Project
                    //string IsBaseInfo = CHECK_SXC_PROJECT().Rows[0].ItemArray[0].ToString();

                    //if (IsBaseInfo.Equals("N"))
                    //{                       
                    //    string vCategory = cmb_category.SelectedValue.ToString();

                    //    SAVE_SXC_PROJECT(vCategory);
                    //}
                    string vCategory = cmb_category.SelectedValue.ToString();

                    SAVE_SXC_PROJECT(vCategory);
                                        
                    string v_srfno = txt_srfno.Text.Trim();

                    INSERT_SRF_MASTER(v_srfno, vCategory);
                    #endregion

                    CONFIRM_DATA();
                    Type_Working("S");
                    Select_srf_maxseq(cmb_factory.SelectedValue.ToString(), txt_srno.Text, txt_srfno.Text, txt_bomid.Text, txt_bomrev.Text, cmb_sampletypes.SelectedValue.ToString());
                }
            }
            else
            {
                Type_Working("S");
                ClassLib.ComCtl.Set_ComboList(dt, cmb_level, 0, 0, false, false);
                cmb_level.SelectedIndex = 0;
            }
            return true;
        }       
        private bool Edit_SRF_Data()
        {
            #region Check Data
            if (_head_nf_cd != cmb_sampletypes.SelectedValue.ToString())
            {
                COM.ComFunction comfunc = new COM.ComFunction();
                if (int.Parse(dtp_need_by.Text) <= int.Parse(_head_need_by))
                {
                    ClassLib.ComFunction.User_Message("Input Error :Need By , ETS shoule be later than before", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    dtp_need_by.Focus();
                    return false;
                }
                else if (int.Parse(dtp_ets.Text) <= int.Parse(_head_ets))
                {
                    ClassLib.ComFunction.User_Message("Input Error :Need By , ETS shoule be later than before", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtp_ets.Focus();
                    return false;
                }
            }

            //date compare
            if (Convert.ToDouble(dtp_need_by.Text.ToString()) <= Convert.ToDouble(dtp_ets.Text.ToString()))
            {
                ClassLib.ComFunction.User_Message("Input Error : ETS Date is latter than Need By", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tab_control.SelectedIndex = 1;
                return false;
            }
            if (cmb_sampletypes.SelectedValue.ToString() == "Y0000")
            {

                if (txt_style_cd.Text.Trim().Length == 0)
                {
                    ClassLib.ComFunction.User_Message("Input Error : Style", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_style_cd.Enabled = true;
                    return false;
                }
                if (txt_style_cd.Text.Trim().Length != 9)
                {
                    ClassLib.ComFunction.User_Message("Input Error : Wrong Style", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_style_cd.Enabled = true;
                    return false;
                }
            }
            if (cmb_td.SelectedValue == null)
            {                
                ClassLib.ComFunction.User_Message("Input Error : TD Code", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            #endregion

            try
            {
                Update_sdd_srf_head();

                fgrid_detail.Select(fgrid_detail.Selection.r1, 0, fgrid_detail.Selection.r1, fgrid_detail.Cols.Count - 1, false);


                if (!new_nf_cd)
                {

                    for (int i = _RowFixed_detali; i < fgrid_detail.Rows.Count; i++)
                    {
                        if (fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].Equals("1")
                            && !fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG].Equals("P")
                            && !fgrid_detail[i, 0].Equals("")
                            && fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString().Trim().Length > 0)
                        {
                            if (fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD].ToString().Trim().Length.Equals(0))
                            {
                                ClassLib.ComFunction.User_Message("Input Error : Color", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                fgrid_detail.Rows[i].Selected = true;
                                fgrid_detail.TopRow = i;
                                return false;
                            }
                            else if (!fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD].ToString().Trim().Length.Equals(0) && !fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD].ToString().Trim().Length.Equals(0))
                            {
                                string pcc_spec = fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD].ToString();
                                string pcc_unit = fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD].ToString();
                                if (Select_sdd_srf_spec_check(pcc_unit, pcc_spec).Rows[0].ItemArray[0].ToString() != "Success")
                                {
                                    ClassLib.ComFunction.User_Message("Input Error : Unit & Spec(Mismatch) ", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    fgrid_detail.Rows[i].Selected = true;
                                    fgrid_detail.TopRow = i;
                                    return false;
                                }
                            }
                        }
                    }
                }

                OraDB.Save_FlexGird("pkg_sxd_srf_03.save_sxd_srf_tail", fgrid_detail);
                OraDB.Save_FlexGird("pkg_sxd_srf_03.save_sxd_srf_order", fgrid_order);

                string vCategory = cmb_category.SelectedValue.ToString();

                SAVE_SXC_PROJECT(vCategory);

                //_head_nf_cd = cmb_sampletypes.SelectedValue.ToString();

                return true;

            }
            catch
            {
                return false;
            }
        }
        private void Set_grid_key()
        {

            if (_Form_Type.Equals("C"))
            {
                _head_nf_cd = cmb_sampletypes.SelectedValue.ToString();


                for (int i = _RowFixed_detali; i < fgrid_detail.Rows.Count; i++)
                {
                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSR_NO] = txt_srno.Text.Trim();
                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxSRF_NO] = txt_srfno.Text.Trim();
                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_ID] = txt_bomid.Text.Trim();
                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxBOM_REV] = txt_bomrev.Text.Trim();
                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxNF_CD] = cmb_sampletypes.SelectedValue.ToString();
                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxUPD_USER] = ClassLib.ComVar.This_User;

                }

                for (int i = _RowFixed_order; i < fgrid_order.Rows.Count; i++)
                {
                    fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                    fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSR_NO] = txt_srno.Text.Trim();
                    fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSRF_NO] = txt_srfno.Text.Trim();
                    fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxBOM_ID] = txt_bomid.Text.Trim();
                    fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxBOM_REV] = txt_bomrev.Text.Trim();
                    fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxNF_CD] = cmb_sampletypes.SelectedValue.ToString();
                    fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxUPD_USER] = ClassLib.ComVar.This_User;
                }

                new_nf_cd = false;
            }


        }

        private DataTable CREATE_SR_NO()
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_CREATE_SR_NO";

            OraDB.ReDim_Parameter(5);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SRF_NO";
            OraDB.Parameter_Name[2] = "ARG_BOM_ID";
            OraDB.Parameter_Name[3] = "ARG_BOM_REV";
            OraDB.Parameter_Name[4] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_srfno.Text.Trim();
            OraDB.Parameter_Values[2] = txt_bomid.Text.Trim();
            OraDB.Parameter_Values[3] = txt_bomrev.Text.Trim();
            OraDB.Parameter_Values[4] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable CHECK_SXD_SRF_HEAD()
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_HEAD_CHECK";

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

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_srno.Text.Trim();
            OraDB.Parameter_Values[2] = txt_srfno.Text.Trim();
            OraDB.Parameter_Values[3] = txt_bomid.Text.Trim();
            OraDB.Parameter_Values[4] = txt_bomrev.Text.Trim();
            OraDB.Parameter_Values[5] = cmb_sampletypes.SelectedValue.ToString();
            OraDB.Parameter_Values[6] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_SXD_SRF_SEQ(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
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
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }        
        private bool SAVE_SXD_SRF_HEAD_LOAD()
        {
            try
            {
                _head_dm_bom_flg = Select_DE_BOM_chk(cmb_factory.SelectedValue.ToString(), cmb_sampletypes.SelectedValue.ToString());
            }
            catch
            {
            }

            string Proc_Name = "pkg_sxd_srf_00.save_sxd_srf_head_load";
            try
            {
                OraDB.ReDim_Parameter(70);
                OraDB.Process_Name = Proc_Name;

                OraDB.Parameter_Name[0] = "arg_factory";
                OraDB.Parameter_Name[1] = "arg_sr_no";
                OraDB.Parameter_Name[2] = "arg_srf_no";
                OraDB.Parameter_Name[3] = "arg_bom_id";
                OraDB.Parameter_Name[4] = "arg_bom_rev";
                OraDB.Parameter_Name[5] = "arg_nf_cd";
                OraDB.Parameter_Name[6] = "arg_bom_state";
                OraDB.Parameter_Name[7] = "arg_requestor";
                OraDB.Parameter_Name[8] = "arg_ord_ymd";
                OraDB.Parameter_Name[9] = "arg_need_by";
                OraDB.Parameter_Name[10] = "arg_ets";
                OraDB.Parameter_Name[11] = "arg_mo_alias";
                OraDB.Parameter_Name[12] = "arg_whq_plm";
                OraDB.Parameter_Name[13] = "arg_whq_dev";
                OraDB.Parameter_Name[14] = "arg_nlo_dev";
                OraDB.Parameter_Name[15] = "arg_silhouette";
                OraDB.Parameter_Name[16] = "arg_technology";
                OraDB.Parameter_Name[17] = "arg_lasting_me";
                OraDB.Parameter_Name[18] = "arg_ms_me";
                OraDB.Parameter_Name[19] = "arg_sole_laying";
                OraDB.Parameter_Name[20] = "arg_mto_acc";
                OraDB.Parameter_Name[21] = "arg_bom_comment";
                OraDB.Parameter_Name[22] = "arg_factory_dv";
                OraDB.Parameter_Name[23] = "arg_sesn";
                OraDB.Parameter_Name[24] = "arg_pattern";
                OraDB.Parameter_Name[25] = "arg_last_cd";
                OraDB.Parameter_Name[26] = "arg_dev_name";
                OraDB.Parameter_Name[27] = "arg_mtl_ver";
                OraDB.Parameter_Name[28] = "arg_color_ver";
                OraDB.Parameter_Name[29] = "arg_sample_types";
                OraDB.Parameter_Name[30] = "arg_sta";
                OraDB.Parameter_Name[31] = "arg_current_ipw";
                OraDB.Parameter_Name[32] = "arg_product_code";
                OraDB.Parameter_Name[33] = "arg_dm_bom_flg";
                OraDB.Parameter_Name[34] = "arg_prod_ext_color";
                OraDB.Parameter_Name[35] = "arg_pcc_factory";
                OraDB.Parameter_Name[36] = "arg_ss_factory";
                OraDB.Parameter_Name[37] = "arg_p_prod_factory";
                OraDB.Parameter_Name[38] = "arg_s_prod_factory";
                OraDB.Parameter_Name[39] = "arg_style_cd";
                OraDB.Parameter_Name[40] = "arg_status";
                OraDB.Parameter_Name[41] = "arg_upd_user";
                OraDB.Parameter_Name[42] = "arg_sr_instructions";          
                OraDB.Parameter_Name[43] = "arg_bom_dimension";      
                OraDB.Parameter_Name[44] = "arg_bom_platform";       
                OraDB.Parameter_Name[45] = "arg_bom_lastdim";     
                OraDB.Parameter_Name[46] = "arg_bom_method";    
                OraDB.Parameter_Name[47] = "arg_productid";         
                OraDB.Parameter_Name[48] = "arg_bom_inlinesizerange";
                OraDB.Parameter_Name[49] = "arg_bom_promosizerange"; 
                OraDB.Parameter_Name[50] = "arg_cm_name";         
                OraDB.Parameter_Name[51] = "arg_cm_type";       
                OraDB.Parameter_Name[52] = "arg_cm_dutycode";       
                OraDB.Parameter_Name[53] = "arg_cm_tfob";            
                OraDB.Parameter_Name[54] = "arg_devproj_alias";      
                OraDB.Parameter_Name[55] = "arg_devproj_id";      
                OraDB.Parameter_Name[56] = "arg_tdcode";        
                OraDB.Parameter_Name[57] = "arg_plm";               
                OraDB.Parameter_Name[58] = "arg_biz_org";            
                OraDB.Parameter_Name[59] = "arg_consumer_purpose";   
                OraDB.Parameter_Name[60] = "arg_consumer_focus";  
                OraDB.Parameter_Name[61] = "arg_consumer_use";  
                OraDB.Parameter_Name[62] = "arg_model_id";
                OraDB.Parameter_Name[63] = "arg_source_type";
                OraDB.Parameter_Name[64] = "arg_spc_yn";
                OraDB.Parameter_Name[65] = "arg_gtm_div";
                OraDB.Parameter_Name[66] = "arg_marketing_name";
                OraDB.Parameter_Name[67] = "arg_offshore_yn";
                OraDB.Parameter_Name[68] = "arg_pu_puck_yn";
                OraDB.Parameter_Name[69] = "arg_pu_puck_desc";
               
                for (int i = 0; i < 70; i++)
                {
                    OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                if (_Form_Type.Equals("C"))
                {
                    OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
                    OraDB.Parameter_Values[1] = txt_srno.Text.Trim();
                    OraDB.Parameter_Values[2] = txt_srfno.Text.Trim();

                    OraDB.Parameter_Values[3] = txt_bomid.Text.Trim();
                    OraDB.Parameter_Values[4] = txt_bomrev.Text.Trim();
                    OraDB.Parameter_Values[5] = cmb_sampletypes.SelectedValue.ToString();
                }
                else
                {
                    OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
                    OraDB.Parameter_Values[1] = txt_srno.Text.Trim();
                    OraDB.Parameter_Values[2] = txt_srfno.Text.Trim();

                    OraDB.Parameter_Values[3] = txt_bomid.Text.Trim();
                    OraDB.Parameter_Values[4] = txt_bomrev.Text.Trim();
                    OraDB.Parameter_Values[5] = cmb_sampletypes.SelectedValue.ToString();//_head_nf_cd;
                }
                OraDB.Parameter_Values[6]  = txt_bom_state.Text.Trim();
                OraDB.Parameter_Values[7]  = txt_requestor.Text.Trim();
                OraDB.Parameter_Values[8]  = dtp_order_date.Value.ToString("yyyyMMdd");
                OraDB.Parameter_Values[9]  = dtp_need_by.Value.ToString("yyyyMMdd"); ;
                OraDB.Parameter_Values[10] = dtp_ets.Value.ToString("yyyyMMdd"); ;
                OraDB.Parameter_Values[11] = txt_mo_alias.Text.Trim();
                OraDB.Parameter_Values[12] = txt_whq_plm.Text.Trim();
                OraDB.Parameter_Values[13] = txt_whq_dev.Text.Trim();
                OraDB.Parameter_Values[14] = txt_nlo_dev.Text.Trim();
                OraDB.Parameter_Values[15] = txt_silhouette.Text.Trim();
                OraDB.Parameter_Values[16] = txt_technology.Text.Trim();// _head_technology;
                OraDB.Parameter_Values[17] = txt_lasting_method.Text.Trim();// _head_lasting_method;
                OraDB.Parameter_Values[18] = txt_ms_method.Text.Trim();// _head_ms_method;
                OraDB.Parameter_Values[19] = txt_sole_laying_method.Text.Trim();// _head_sole_laying_method;
                OraDB.Parameter_Values[20] = txt_mto_account_name.Text.Trim();// _head_mto_account_name;
                OraDB.Parameter_Values[21] = txt_bom_comments.Text.Trim();// _head_bom_comment;
                OraDB.Parameter_Values[22] = txt_factory_direct.Text.Trim();// _head_factory_dv;
                OraDB.Parameter_Values[23] = txt_season.Text.Trim();// _head_sesn;
                OraDB.Parameter_Values[24] = txt_patten.Text.Trim();// _head_pattern;
                OraDB.Parameter_Values[25] = txt_last_cd.Text.Trim();// _head_last_cd;
                OraDB.Parameter_Values[26] = txt_model_name_bom.Text.Trim();// _head_dev_name;
                OraDB.Parameter_Values[27] = txt_mtl_ver.Text.Trim();// _head_mtl_ver;
                OraDB.Parameter_Values[28] = txt_colo_ver.Text.Trim();// _head_color_ver;
                OraDB.Parameter_Values[29] = cmb_sampletypes.Text;// _head_sample_types;
                OraDB.Parameter_Values[30] = txt_state.Text.Trim();// _head_sta;
                OraDB.Parameter_Values[31] = dtp_current_ipw.Value.ToString("yyyyMMdd");// _head_current_ipw;
                OraDB.Parameter_Values[32] = txt_product_code.Text.Trim();// _head_product_code;                
                OraDB.Parameter_Values[33] = _head_dm_bom_flg;
                OraDB.Parameter_Values[34] = txt_extra_color.Text.Trim();
                OraDB.Parameter_Values[35] = txt_pcc_factory.Text.Trim();// _head_pcc_factory;
                OraDB.Parameter_Values[36] = txt_ss_factory.Text.Trim();// _head_ss_factory;
                OraDB.Parameter_Values[37] = cmb_p_prod_fact.SelectedValue.ToString();// _head_p_prod_factory;
                OraDB.Parameter_Values[38] = txt_s_prod_fact.Text.Trim();// _head_s_prod_factory;
                OraDB.Parameter_Values[39] = txt_style_cd.Text.Trim();// _head_style_cd;
                OraDB.Parameter_Values[40] = "N";// _head_status;
                OraDB.Parameter_Values[41] = COM.ComVar.This_User;// _head_upd_user;

                OraDB.Parameter_Values[42] = (txt_sr_instruction.Text.Trim().Length >= 200) ? txt_sr_instruction.Text.Trim().Substring(0, 200).ToString() : txt_sr_instruction.Text.Trim();
                OraDB.Parameter_Values[43] = txt_demension.Text.Trim();
                OraDB.Parameter_Values[44] = txt_platform.Text.Trim();
                OraDB.Parameter_Values[45] = txt_last_dim.Text.Trim();
                OraDB.Parameter_Values[46] = txt_bom_method.Text.Trim();
                OraDB.Parameter_Values[47] = txt_prod_id.Text.Trim();
                OraDB.Parameter_Values[48] = txt_inline_size.Text.Trim();
                OraDB.Parameter_Values[49] = txt_promo_size.Text.Trim();
                OraDB.Parameter_Values[50] = txt_costmat_name.Text.Trim();
                OraDB.Parameter_Values[51] = txt_costmat_type.Text.Trim();
                OraDB.Parameter_Values[52] = txt_costmat_duty.Text.Trim();
                OraDB.Parameter_Values[53] = txt_costmat_tfob.Text.Trim();
                OraDB.Parameter_Values[54] = txt_mo_alias.Text.Trim();
                OraDB.Parameter_Values[55] = txt_devproj_id.Text.Trim();
                OraDB.Parameter_Values[56] = txt_td_code.Text.Trim();
                OraDB.Parameter_Values[57] = txt_plm.Text.Trim();
                OraDB.Parameter_Values[58] = txt_biz_org.Text.Trim();
                OraDB.Parameter_Values[59] = txt_cons_purpose.Text.Trim();
                OraDB.Parameter_Values[60] = txt_cons_focus.Text.Trim();
                OraDB.Parameter_Values[61] = txt_cons_use.Text.Trim();
                OraDB.Parameter_Values[62] = txt_mo_id.Text.Trim();
                OraDB.Parameter_Values[63] = _source_type;
                OraDB.Parameter_Values[64] = (cmb_spc_yn.SelectedValue == null) ? "N" : cmb_spc_yn.SelectedValue.ToString().Trim();
                
                string _gtm_div = "";
                if (chk_gtm_1st.Checked)
                {
                    _gtm_div = "001"; 
                }
                else if (chk_gtm_2nd.Checked)
                {
                    _gtm_div = "002"; 
                }
                OraDB.Parameter_Values[65] = _gtm_div;
                OraDB.Parameter_Values[66] = txt_marketing.Text.Trim();
                OraDB.Parameter_Values[67] = (cmb_offshore.SelectedValue == null) ? "N" : cmb_offshore.SelectedValue.ToString().Trim();
                OraDB.Parameter_Values[68] = "N";// (cmb_pupuck_yn.SelectedValue == null) ? "N" : cmb_pupuck_yn.SelectedValue.ToString().Trim();
                OraDB.Parameter_Values[69] = "";// txt_pupuck_desc.Text.Trim();

                OraDB.Add_Modify_Parameter(true);
                DataSet ds = OraDB.Exe_Modify_Procedure();

                if (ds == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        private void SAVE_SXD_SRF_ORDER_LOAD(string[] arg_array)
        {
            string Proc_Name = "pkg_sxd_srf_00.save_sxd_srf_order_load";

            OraDB.ReDim_Parameter(arg_array.Length);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_sr_no";
            OraDB.Parameter_Name[2] = "arg_srf_no";

            OraDB.Parameter_Name[3] = "arg_bom_id";
            OraDB.Parameter_Name[4] = "arg_bom_rev";
            OraDB.Parameter_Name[5] = "arg_nf_cd";

            OraDB.Parameter_Name[6] = "arg_size_cd";
            OraDB.Parameter_Name[7] = "arg_ord_type";
            OraDB.Parameter_Name[8] = "arg_sr_line_item";

            OraDB.Parameter_Name[9] = "arg_side_type";
            OraDB.Parameter_Name[10] = "arg_ord_qty";
            OraDB.Parameter_Name[11] = "arg_requestor";

            OraDB.Parameter_Name[12] = "arg_ord_ymd";
            OraDB.Parameter_Name[13] = "arg_need_by";
            OraDB.Parameter_Name[14] = "arg_destination";

            OraDB.Parameter_Name[15] = "arg_gen_cd";
            OraDB.Parameter_Name[16] = "arg_width";
            OraDB.Parameter_Name[17] = "arg_fit";

            OraDB.Parameter_Name[18] = "arg_age";
            OraDB.Parameter_Name[19] = "arg_attn";
            OraDB.Parameter_Name[20] = "arg_nike_flg";

            OraDB.Parameter_Name[21] = "arg_status";
            OraDB.Parameter_Name[22] = "arg_upd_user";



            for (int i = 0; i < arg_array.Length; i++)
            {
                OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
            }

            for (int i = 0; i < arg_array.Length; i++)
            {
                OraDB.Parameter_Values[i] = arg_array[i].Replace("'", "");
            }

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }
        private void SAVE_SXD_SRF_TAIL_LOAD(string[] arg_array)
        {
            string Proc_Name = "pkg_sxd_srf_00.save_sxd_srf_tail_load";

            OraDB.ReDim_Parameter(arg_array.Length);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_sr_no";
            OraDB.Parameter_Name[2] = "arg_srf_no";

            OraDB.Parameter_Name[3] = "arg_bom_id";
            OraDB.Parameter_Name[4] = "arg_bom_rev";
            OraDB.Parameter_Name[5] = "arg_nf_cd";

            OraDB.Parameter_Name[6] = "arg_part_no";
            OraDB.Parameter_Name[7] = "arg_part_type";
            OraDB.Parameter_Name[8] = "arg_part_desc";

            OraDB.Parameter_Name[9] = "arg_part_comment";
            OraDB.Parameter_Name[10] = "arg_part_qty";
            OraDB.Parameter_Name[11] = "arg_mat_cd";

            OraDB.Parameter_Name[12] = "arg_mat_name";
            OraDB.Parameter_Name[13] = "arg_mat_comment";
            OraDB.Parameter_Name[14] = "arg_mat_desc";
            OraDB.Parameter_Name[15] = "arg_material_size";
            OraDB.Parameter_Name[16] = "arg_material_min";
            OraDB.Parameter_Name[17] = "arg_material_max";
            OraDB.Parameter_Name[18] = "arg_material_state";
            OraDB.Parameter_Name[19] = "arg_material_type";
            OraDB.Parameter_Name[20] = "arg_color_cd";
            OraDB.Parameter_Name[21] = "arg_color_desc";
            OraDB.Parameter_Name[22] = "arg_color_comment";
            OraDB.Parameter_Name[23] = "arg_mcs_cd";
            OraDB.Parameter_Name[24] = "arg_mxs_number";
            OraDB.Parameter_Name[25] = "arg_status";
            OraDB.Parameter_Name[26] = "arg_upd_user";


            for (int i = 0; i < arg_array.Length; i++)
            {
                OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
            }

            for (int i = 0; i < arg_array.Length; i++)
            {
                OraDB.Parameter_Values[i] = arg_array[i];
            }

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }
        private void SAVE_SXD_SRF_RULE_LOAD(string[] arg_array)
        {
            string Proc_Name = "pkg_sxd_srf_00.save_sxd_srf_rule_load";

            OraDB.ReDim_Parameter(12);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_sr_no";
            OraDB.Parameter_Name[2] = "arg_srf_no";
            OraDB.Parameter_Name[3] = "arg_bom_id";
            OraDB.Parameter_Name[4] = "arg_bom_rev";
            OraDB.Parameter_Name[5] = "arg_nf_cd";
            OraDB.Parameter_Name[6] = "arg_rule_type";
            OraDB.Parameter_Name[7] = "arg_region";
            OraDB.Parameter_Name[8] = "arg_exclusive_type";
            OraDB.Parameter_Name[9] = "arg_exclusive_to";
            OraDB.Parameter_Name[10] = "arg_status";
            OraDB.Parameter_Name[11] = "arg_upd_user";

            for (int i = 0; i < 12; i++)
            {
                OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
            }

            OraDB.Parameter_Values[0] = arg_array[0];
            OraDB.Parameter_Values[1] = arg_array[1];
            OraDB.Parameter_Values[2] = arg_array[2];
            OraDB.Parameter_Values[3] = arg_array[3];
            OraDB.Parameter_Values[4] = arg_array[4];
            OraDB.Parameter_Values[5] = arg_array[5];
            OraDB.Parameter_Values[6] = arg_array[6];
            OraDB.Parameter_Values[7] = arg_array[7];
            OraDB.Parameter_Values[8] = arg_array[8];
            OraDB.Parameter_Values[9] = arg_array[9];
            OraDB.Parameter_Values[10] = "N";
            OraDB.Parameter_Values[11] = COM.ComVar.This_User;


            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }
        private DataTable CHECK_SXC_PROJECT()
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.select_sxc_isproject";

            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_srf_no";
            OraDB.Parameter_Name[2] = "arg_bom_id";
            OraDB.Parameter_Name[3] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_srfno.Text.Trim();
            OraDB.Parameter_Values[2] = txt_bomid.Text.Trim();
            OraDB.Parameter_Values[3] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private bool SAVE_SXC_PROJECT(string arg_category)
        {
            string process_name = "pkg_sxd_srf_01.save_sxc_pj_mast";
            int vcnt = 24; int i = 0; int j = 0; int k = 0;

            OraDB.ReDim_Parameter(vcnt);

            OraDB.Process_Name = process_name;

            OraDB.Parameter_Name[i++] = "arg_factory";
            OraDB.Parameter_Name[i++] = "arg_srf_no";
            OraDB.Parameter_Name[i++] = "arg_bom_id";
            OraDB.Parameter_Name[i++] = "arg_category";
            OraDB.Parameter_Name[i++] = "arg_season_cd";
            OraDB.Parameter_Name[i++] = "arg_gen_cd";
            OraDB.Parameter_Name[i++] = "arg_style_cd";
            OraDB.Parameter_Name[i++] = "arg_xdm_dim_cd";
            OraDB.Parameter_Name[i++] = "arg_style_name";
            OraDB.Parameter_Name[i++] = "arg_bom_cd";
            OraDB.Parameter_Name[i++] = "arg_upper_mat";
            OraDB.Parameter_Name[i++] = "arg_ms_mat";
            OraDB.Parameter_Name[i++] = "arg_os_mat";
            OraDB.Parameter_Name[i++] = "arg_dev_prod";
            OraDB.Parameter_Name[i++] = "arg_t_d";
            OraDB.Parameter_Name[i++] = "arg_target_fob";
            OraDB.Parameter_Name[i++] = "arg_current_fob";
            OraDB.Parameter_Name[i++] = "arg_retail_price";
            OraDB.Parameter_Name[i++] = "arg_ipw_ymd";
            OraDB.Parameter_Name[i++] = "arg_lasting_me";
            OraDB.Parameter_Name[i++] = "arg_ms_me";
            OraDB.Parameter_Name[i++] = "arg_sole_laying";
            OraDB.Parameter_Name[i++] = "arg_remarks";
            OraDB.Parameter_Name[i++] = "arg_upd_user";

            for (j = 0; j < vcnt; j++)
                OraDB.Parameter_Type[j] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[k++] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[k++] = txt_srfno.Text.Trim();
            OraDB.Parameter_Values[k++] = txt_bomid.Text.Trim();
            OraDB.Parameter_Values[k++] = arg_category;
            OraDB.Parameter_Values[k++] = txt_season.Text.Trim();
            OraDB.Parameter_Values[k++] = cmb_gender.SelectedValue.ToString();
            OraDB.Parameter_Values[k++] = txt_style_cd.Text.Trim();
            OraDB.Parameter_Values[k++] = "00";
            OraDB.Parameter_Values[k++] = txt_model_name.Text.Trim();
            OraDB.Parameter_Values[k++] = "BDS0000001";
            OraDB.Parameter_Values[k++] = txt_mtl_ver.Text.Trim();
            OraDB.Parameter_Values[k++] = txt_ms_method.Text.Trim();
            OraDB.Parameter_Values[k++] = " ";
            OraDB.Parameter_Values[k++] = txt_factory_direct.Text.Trim();
            OraDB.Parameter_Values[k++] = (cmb_td.SelectedIndex == -1) ? "000" : cmb_td.SelectedValue.ToString();
            OraDB.Parameter_Values[k++] = "0";
            OraDB.Parameter_Values[k++] = "0";
            OraDB.Parameter_Values[k++] = "0";
            OraDB.Parameter_Values[k++] = dtp_current_ipw.Text.Trim();
            OraDB.Parameter_Values[k++] = txt_lasting_method.Text.Trim();
            OraDB.Parameter_Values[k++] = txt_ms_method.Text.Trim();
            OraDB.Parameter_Values[k++] = txt_sole_laying_method.Text.Trim();
            OraDB.Parameter_Values[k++] = " ";
            OraDB.Parameter_Values[k++] = COM.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
            OraDB.Exe_Modify_Procedure();			// Modify Procedure 실행

            return true;
        }
        private string Select_DE_BOM_chk(string arg_factory, string arg_nf_cd)
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_DE_BOM_CHK";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_nf_cd";
            OraDB.Parameter_Name[2] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_nf_cd;
            OraDB.Parameter_Values[2] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return "";

            return DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString();
        }
        private DataTable Select_sdd_srf_spec_check(string arg_pcc_unit, string arg_pcc_spec)
        {
            string Proc_Name = "pkg_sxd_srf_03_select.select_sdd_srf_spec_check";

            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_pcc_unit";
            OraDB.Parameter_Name[2] = "arg_pcc_spec";
            OraDB.Parameter_Name[3] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = arg_pcc_unit;
            OraDB.Parameter_Values[2] = arg_pcc_spec;
            OraDB.Parameter_Values[3] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private void Update_sdd_srf_head()
        {
            string Proc_Name = "pkg_sxd_srf_03.save_sxd_srf_head_01";

            OraDB.ReDim_Parameter(54);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_sr_no";
            OraDB.Parameter_Name[2] = "arg_srf_no";
            OraDB.Parameter_Name[3] = "arg_bom_id";
            OraDB.Parameter_Name[4] = "arg_bom_rev";
            OraDB.Parameter_Name[5] = "arg_nf_cd";
            OraDB.Parameter_Name[6] = "arg_srf_seq";
            OraDB.Parameter_Name[7] = "arg_bom_state";
            OraDB.Parameter_Name[8] = "arg_requestor";
            OraDB.Parameter_Name[9] = "arg_ord_ymd";
            OraDB.Parameter_Name[10] = "arg_need_by";
            OraDB.Parameter_Name[11] = "arg_ets";
            OraDB.Parameter_Name[12] = "arg_mo_alias";
            OraDB.Parameter_Name[13] = "arg_whq_plm";
            OraDB.Parameter_Name[14] = "arg_whq_dev";
            OraDB.Parameter_Name[15] = "arg_nlo_dev";
            OraDB.Parameter_Name[16] = "arg_silhouette";
            OraDB.Parameter_Name[17] = "arg_technology";
            OraDB.Parameter_Name[18] = "arg_lasting_me";
            OraDB.Parameter_Name[19] = "arg_ms_me";
            OraDB.Parameter_Name[20] = "arg_sole_laying";
            OraDB.Parameter_Name[21] = "arg_mto_acc";
            OraDB.Parameter_Name[22] = "arg_bom_comment";
            OraDB.Parameter_Name[23] = "arg_factory_dv";
            OraDB.Parameter_Name[24] = "arg_sesn";
            OraDB.Parameter_Name[25] = "arg_pattern";
            OraDB.Parameter_Name[26] = "arg_last_cd";
            OraDB.Parameter_Name[27] = "arg_dev_name";
            OraDB.Parameter_Name[28] = "arg_mtl_ver";
            OraDB.Parameter_Name[29] = "arg_color_ver";
            OraDB.Parameter_Name[30] = "arg_sample_types";
            OraDB.Parameter_Name[31] = "arg_sta";
            OraDB.Parameter_Name[32] = "arg_current_ipw";
            OraDB.Parameter_Name[33] = "arg_product_code";
            OraDB.Parameter_Name[34] = "arg_pur_flg";
            OraDB.Parameter_Name[35] = "arg_style_cd";
            OraDB.Parameter_Name[36] = "arg_remarks";
            OraDB.Parameter_Name[37] = "arg_status";
            OraDB.Parameter_Name[38] = "arg_load_upd_user";
            OraDB.Parameter_Name[39] = "arg_load_upd_ymd";
            OraDB.Parameter_Name[40] = "arg_upd_user";

            OraDB.Parameter_Name[41] = "arg_prod_ext_color";
            OraDB.Parameter_Name[42] = "arg_pcc_factory";
            OraDB.Parameter_Name[43] = "arg_ss_factory";
            OraDB.Parameter_Name[44] = "arg_p_prod_factory";
            OraDB.Parameter_Name[45] = "arg_s_prod_factory";
            OraDB.Parameter_Name[46] = "arg_td_code";
            OraDB.Parameter_Name[47] = "arg_p_factory";
            OraDB.Parameter_Name[48] = "arg_spc_yn";
            OraDB.Parameter_Name[49] = "arg_gtm_div";
            OraDB.Parameter_Name[50] = "arg_marketing_name";
            OraDB.Parameter_Name[51] = "arg_offshore_yn";
            OraDB.Parameter_Name[52] = "arg_pu_puck_yn";
            OraDB.Parameter_Name[53] = "arg_pu_puck_desc";
            
            for (int i = 0; i < 51; i++)
            {
                OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
            }

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();

            OraDB.Parameter_Values[1] = txt_srno.Text;
            OraDB.Parameter_Values[2] = txt_srfno.Text;
            OraDB.Parameter_Values[3] = txt_bomid.Text;
            OraDB.Parameter_Values[4] = txt_bomrev.Text;
            OraDB.Parameter_Values[5] = cmb_sampletypes.SelectedValue.ToString();

            OraDB.Parameter_Values[6] = cmb_level.SelectedValue.ToString();
            OraDB.Parameter_Values[7] = txt_bom_state.Text;
            OraDB.Parameter_Values[8] = txt_requestor.Text;
            OraDB.Parameter_Values[9] = dtp_order_date.Text;
            OraDB.Parameter_Values[10] = dtp_need_by.Text;

            OraDB.Parameter_Values[11] = dtp_ets.Text;
            OraDB.Parameter_Values[12] = txt_mo_alias.Text;
            OraDB.Parameter_Values[13] = txt_whq_plm.Text;
            OraDB.Parameter_Values[14] = txt_whq_dev.Text;
            OraDB.Parameter_Values[15] = txt_nlo_dev.Text;

            OraDB.Parameter_Values[16] = txt_silhouette.Text;
            OraDB.Parameter_Values[17] = txt_technology.Text;
            OraDB.Parameter_Values[18] = txt_lasting_method.Text;
            OraDB.Parameter_Values[19] = txt_ms_method.Text;
            OraDB.Parameter_Values[20] = txt_sole_laying_method.Text;

            OraDB.Parameter_Values[21] = txt_mto_account_name.Text;
            OraDB.Parameter_Values[22] = txt_bom_comments.Text;
            OraDB.Parameter_Values[23] = txt_factory_direct.Text;
            OraDB.Parameter_Values[24] = txt_season.Text;
            OraDB.Parameter_Values[25] = txt_patten.Text;

            OraDB.Parameter_Values[26] = txt_last_cd.Text;
            OraDB.Parameter_Values[27] = txt_model_name.Text;
            OraDB.Parameter_Values[28] = txt_mtl_ver.Text;
            OraDB.Parameter_Values[29] = txt_colo_ver.Text;
            OraDB.Parameter_Values[30] = cmb_sampletypes.GetItemText(cmb_sampletypes.SelectedIndex, 1);

            OraDB.Parameter_Values[31] = _head_sta;
            OraDB.Parameter_Values[32] = dtp_current_ipw.Text;
            OraDB.Parameter_Values[33] = txt_product_code.Text;
            OraDB.Parameter_Values[34] = _head_pur_flg;
            OraDB.Parameter_Values[35] = txt_style_cd.Text;

            OraDB.Parameter_Values[36] = _head_remarks;
            OraDB.Parameter_Values[37] = _head_status;
            OraDB.Parameter_Values[38] = _head_load_upd_user;
            OraDB.Parameter_Values[39] = _head_load_upd_ymd;
            OraDB.Parameter_Values[40] = COM.ComVar.This_User;

            OraDB.Parameter_Values[41] = txt_extra_color.Text;
            OraDB.Parameter_Values[42] = txt_pcc_factory.Text.Trim();
            OraDB.Parameter_Values[43] = txt_ss_factory.Text.Trim();
            OraDB.Parameter_Values[44] = cmb_p_prod_fact.SelectedValue.ToString();
            OraDB.Parameter_Values[45] = txt_s_prod_fact.Text.Trim();
            OraDB.Parameter_Values[46] = cmb_td.SelectedValue.ToString();
            OraDB.Parameter_Values[47] = cmb_p_prod_fact.SelectedValue.ToString();
            OraDB.Parameter_Values[48] = cmb_spc_yn.SelectedValue.ToString();
            
            string _gtm_div = "";
            if (chk_gtm_1st.Checked)
            {
                _gtm_div = "001";
            }
            else if (chk_gtm_2nd.Checked)
            {
                _gtm_div = "002";
            }
            OraDB.Parameter_Values[49] = _gtm_div;
            OraDB.Parameter_Values[50] = txt_marketing.Text.Trim();
            OraDB.Parameter_Values[51] = cmb_offshore.SelectedValue.ToString();
            OraDB.Parameter_Values[52] = "N";//cmb_pupuck_yn.SelectedValue.ToString();
            OraDB.Parameter_Values[53] = "";//txt_pupuck_desc.Text.Trim();


            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }

        private void INSERT_SRF_MASTER(string arg_srf_no, string arg_category)
        {
            string Proc_Name = "PKG_SXD_SRF_01.INSERT_SXD_SRF_M_CATEGORY";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_SRF_NO";
            OraDB.Parameter_Name[1] = "ARG_CATEGORY";
            OraDB.Parameter_Name[2] = "ARG_UPD_USER";

            
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            
            OraDB.Parameter_Values[0] = arg_srf_no;
            OraDB.Parameter_Values[1] = arg_category;
            OraDB.Parameter_Values[2] = COM.ComVar.This_User;


            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Confirm Data
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (txt_srno.Text.Trim().Length.Equals(0))
                {
                    ClassLib.ComFunction.User_Message("Input Error : SR No", "Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Check_Material_Empty())
                {
                    DialogResult dr_mat = MessageBox.Show("Blank Material Information is exist.\r\n\r\nDo you want to confirm??", "Exclamation", MessageBoxButtons.YesNo);
                    if (dr_mat == DialogResult.No)
                    {
                        return;
                    }                     
                }

                DialogResult dr01 = MessageBox.Show("Please check Unit/Spec again,\r\nFor correct information of Shoe Lace, Thread, Webbing Tape, Sub Material Unit/Spec\r\nDo you want to confirm??", "Exclamation", MessageBoxButtons.YesNo);
                if (dr01 == DialogResult.No)
                {
                    return;
                }
                dr01 = MessageBox.Show("When you confirm BOM. PMC makes ordersheet.\r\nPlease check it again!\r\nDo you want to confirm??", "Exclamation", MessageBoxButtons.YesNo);
                if (dr01 == DialogResult.Yes)
                {
                    if (cmb_sampletypes.SelectedValue.Equals("Y0000") && !txt_style_cd.Text.ToString().Length.Equals(9))
                    {
                        ClassLib.ComFunction.User_Message("Input Error : Style", "Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_style_cd.Focus();
                        return;
                    }

                    if (!cmb_level.SelectedValue.Equals("999"))
                    {
                        ClassLib.ComFunction.User_Message("Input Error : No Updating Data", "Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmb_level.Focus();
                        return;
                    }

                    float order_qty = 0;
                    for (int i = _RowFixed_order; i < fgrid_order.Rows.Count; i++)
                    {
                        order_qty += float.Parse(fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER.IxORD_QTY].ToString());
                    }
                    if (order_qty.Equals(0))
                    {
                        ClassLib.ComFunction.User_Message("Input Error : No order quantity", "Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    for (int i = _RowFixed_detali; i < fgrid_detail.Rows.Count; i++)
                    {
                        int mat_length = fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString().Length;
                        int color_length = fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD].ToString().Length;
                        string srf_level = fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].ToString();
                        
                        if (mat_length > 0 && color_length.Equals(0) && srf_level.Equals("1"))
                        {
                            if (!fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION].ToString().Trim().Equals(" ")) fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION] = "U";

                            fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxSTATUS] = "Y";
                            fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = "U";
                            fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD] = default_color;
                            fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_DESC] = default_color_desc;
                        }
                    }

                    OraDB.Save_FlexGird("pkg_sxd_srf_03.save_sxd_srf_tail", fgrid_detail);

                    CONFIRM_DATA();
                    Select_srf_maxseq(cmb_factory.SelectedValue.ToString(), txt_srno.Text, txt_srfno.Text, txt_bomid.Text, txt_bomrev.Text, cmb_sampletypes.SelectedValue.ToString());
                    tbtn_Search_Click(null, null);
                }
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
        private bool Check_Material_Empty()
        {
            try
            {
                bool chk_flg = true;

                for (int i = fgrid_detail.Rows.Fixed; i < fgrid_detail.Rows.Count; i++)
                {
                    int _level = fgrid_detail.Rows[i].Node.Level;

                    if (_level.Equals(1))
                    {
                        string _mat_cd   = (fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString().Trim().Replace(" ", "");
                        string _mat_name = (fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_NAME] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_NAME].ToString().Trim().Replace(" ", "");
                        
                        if (_mat_cd.Equals("") || _mat_name.Equals(""))
                        {
                            chk_flg = false;
                            break;
                        }
                    }
                    
                }

                return chk_flg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private void CONFIRM_DATA()
        {
            string Proc_Name = "pkg_sxd_srf_03.save_load_conform_srf";

            OraDB.ReDim_Parameter(7);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_sr_no";
            OraDB.Parameter_Name[2] = "arg_srf_no";
            OraDB.Parameter_Name[3] = "arg_bom_id";
            OraDB.Parameter_Name[4] = "arg_bom_rev";
            OraDB.Parameter_Name[5] = "arg_nf_cd";
            OraDB.Parameter_Name[6] = "arg_upd_user";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = txt_srno.Text;
            OraDB.Parameter_Values[2] = txt_srfno.Text;
            OraDB.Parameter_Values[3] = txt_bomid.Text;
            OraDB.Parameter_Values[4] = txt_bomrev.Text;
            OraDB.Parameter_Values[5] = cmb_sampletypes.SelectedValue.ToString();
            OraDB.Parameter_Values[6] = ClassLib.ComVar.This_User;

            OraDB.Add_Run_Parameter(true);
            OraDB.Exe_Run_Procedure();
        }
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string mrd_Filename = "";
                string sPara = "";

                mrd_Filename = Application.StartupPath + @"\SRF_Report" + ".mrd";
                sPara = " /rp " + "[" + cmb_factory.SelectedValue.ToString() + "]" + " [" + ClassLib.ComFunction.Empty_TextBox(txt_srno, "") + "]" + " [" + ClassLib.ComFunction.Empty_TextBox(txt_srfno, "") + "]" + " [" + ClassLib.ComFunction.Empty_TextBox(txt_bomid, "") + "]" + " [" + ClassLib.ComFunction.Empty_TextBox(txt_bomrev, "") + "]" + " [" + ClassLib.ComFunction.Empty_Combo(cmb_sampletypes, "") + "]" + " [000]";

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsNotPrint, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        #endregion
        
        #region Grid Event
        private void fgrid_detail_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {           

            try
            {
                int[] sct_rows = fgrid_detail.Selections;

                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;
                
                for (int i = 0; i < sct_rows.Length; i++)
                {
                    fgrid_detail[sct_rows[i], sct_col] = fgrid_detail[sct_row, sct_col].ToString();
                    fgrid_detail[sct_rows[i], (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION] = "U";
                }               

            }
            catch
            {

            }

        }
        private void fgrid_detail_ChangeEdit(object sender, System.EventArgs e)
        {
            
        }
        private void fgrid_detail_AfterSelChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
        {
            try
            {
                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;

                if (fgrid_detail[sct_row, 0].ToString() != "I")
                {

                    string factory = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxFACTORY].ToString();
                    string sr_no = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxSR_NO].ToString();
                    string srf_no = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_NO].ToString();
                    string bom_id = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxBOM_ID].ToString();
                    string bom_rev = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxBOM_REV].ToString();
                    string nf_cd = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxNF_CD].ToString();
                    string srf_seq = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_SEQ].ToString();
                    string part_no = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_NO].ToString();

                    try
                    {
                        if (fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].Equals("1"))
                        {
                            fgrid_desc.Enabled = true;

                            DataTable dt = Select_isdesckname(factory, sr_no, srf_no, bom_id, bom_rev, nf_cd, srf_seq, part_no);


                            fgrid_desc.Rows.Count = _RowFixed_desc;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                fgrid_desc.Rows.Add();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 0] = "";
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 1] = dt.Rows[i].ItemArray[0].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 2] = dt.Rows[i].ItemArray[1].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 3] = dt.Rows[i].ItemArray[2].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 4] = dt.Rows[i].ItemArray[3].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 5] = dt.Rows[i].ItemArray[4].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 6] = dt.Rows[i].ItemArray[5].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 7] = dt.Rows[i].ItemArray[6].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 8] = dt.Rows[i].ItemArray[7].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 9] = dt.Rows[i].ItemArray[8].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 10] = dt.Rows[i].ItemArray[9].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 11] = dt.Rows[i].ItemArray[10].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 12] = dt.Rows[i].ItemArray[11].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 13] = dt.Rows[i].ItemArray[12].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 14] = dt.Rows[i].ItemArray[13].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 15] = dt.Rows[i].ItemArray[14].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 16] = dt.Rows[i].ItemArray[15].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 17] = dt.Rows[i].ItemArray[16].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 18] = dt.Rows[i].ItemArray[17].ToString();
                                fgrid_desc[fgrid_desc.Rows.Count - 1, 19] = ClassLib.ComVar.This_User;
                            }
                        }
                        else
                        {
                            fgrid_desc.Enabled = false;
                        }
                    }
                    catch
                    {
                    }

                    fgrid_desc.AutoSizeCols();
                }
            }
            catch
            {
            }
        }
        private void fgrid_detail_Click(object sender, System.EventArgs e)
        {
            if (fgrid_detail.Rows.Count == fgrid_detail.Rows.Fixed)
                return;

            if (_Form_Type.Equals("S"))
            {
                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;

                if (cmb_level.SelectedIndex == 0)
                {
                    if (fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].Equals("1"))
                    {
                        if (fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG].Equals("D"))//Delete 상태일때
                        {
                            mnu_copy_record.Visible = false;
                            mnu_copy_specunit.Visible = false;
                            mnu_edit_spec.Visible = false;

                            mnu_sep_01.Visible = false;

                            mnu_insert_record.Visible = true;
                            mnu_update_record.Visible = false;
                            mnu_delete_record.Visible = false;

                            mnu_sep_02.Visible = true;

                            mnu_pending.Visible = false;
                            mnu_release.Visible = true;

                            mnu_sep_03.Visible = false;

                            mnu_multi_change.Visible = true;
                            mnu_multi_corfirm.Visible = true;
                        
                        }
                        else if (fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG].Equals("P"))//Pending 상태일때
                        {

                            mnu_copy_record.Visible = false;
                            mnu_copy_specunit.Visible = false;
                            mnu_edit_spec.Visible = false;

                            mnu_sep_01.Visible = false;

                            mnu_insert_record.Visible = true;
                            mnu_update_record.Visible = false;
                            mnu_delete_record.Visible = false;

                            mnu_sep_02.Visible = true;

                            mnu_pending.Visible = false;
                            mnu_release.Visible = true;

                            mnu_sep_03.Visible = false;

                            mnu_multi_change.Visible = true;
                            mnu_multi_corfirm.Visible = true;


                        }
                        else if (sct_col.Equals((int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD) || sct_col.Equals((int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD) || sct_col.Equals((int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_NAME))
                        {//Unit 또는 spec을 선택 했을때


                            mnu_copy_record.Visible = false;
                            mnu_copy_specunit.Visible = true;
                            mnu_edit_spec.Visible = false;

                            mnu_sep_01.Visible = true;

                            mnu_insert_record.Visible = true;
                            mnu_update_record.Visible = true;
                            mnu_delete_record.Visible = true;

                            mnu_sep_02.Visible = true;

                            mnu_pending.Visible = false;
                            mnu_release.Visible = true;

                            mnu_sep_03.Visible = true;

                            mnu_multi_change.Visible = true;
                            mnu_multi_corfirm.Visible = true;


                        }
                        else
                        {

                            mnu_copy_record.Visible = false;
                            mnu_copy_specunit.Visible = false;
                            mnu_edit_spec.Visible = false;

                            mnu_sep_01.Visible = false;

                            mnu_insert_record.Visible = true;
                            mnu_update_record.Visible = true;
                            mnu_delete_record.Visible = true;

                            mnu_sep_02.Visible = true;

                            mnu_pending.Visible = true;
                            mnu_release.Visible = false;

                            mnu_sep_03.Visible = true;

                            mnu_multi_change.Visible = true;
                            mnu_multi_corfirm.Visible = true;


                        }
                    }
                    else
                    {


                        mnu_copy_record.Visible = false;
                        mnu_copy_specunit.Visible = false;
                        mnu_edit_spec.Visible = false;

                        mnu_sep_01.Visible = false;

                        mnu_insert_record.Visible = false;
                        mnu_update_record.Visible = false;
                        mnu_delete_record.Visible = false;

                        mnu_sep_02.Visible = false;

                        mnu_pending.Visible = false;
                        mnu_release.Visible = false;

                        mnu_sep_03.Visible = false;

                        mnu_multi_change.Visible = false;
                        mnu_multi_corfirm.Visible = false;

                    }
                }
                else
                {

                    mnu_copy_record.Visible = false;
                    mnu_copy_specunit.Visible = false;
                    mnu_edit_spec.Visible = false;

                    mnu_sep_01.Visible = false;

                    mnu_insert_record.Visible = false;
                    mnu_update_record.Visible = false;
                    mnu_delete_record.Visible = false;

                    mnu_sep_02.Visible = false;

                    mnu_pending.Visible = false;
                    mnu_release.Visible = false;

                    mnu_sep_03.Visible = false;

                    mnu_multi_change.Visible = false;
                    mnu_multi_corfirm.Visible = false;
                }
            }
        }
        private void fgrid_detail_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (show_head)
                {
                    pnl_top.Height    = pnl_top.Height/2;
                    pnl_middle.Height = 0;
                    //tab_control.Location = new Point(8, 162);
                    //tab_control.Height = tab_control.Height + (384 - 162);
                    show_head = false;
                }
                else
                {
                    pnl_top.Height    = pnl_top.Height * 2;
                    pnl_middle.Height = 156;
                    //tab_control.Location = new Point(8, 384);
                    //tab_control.Height = tab_control.Height - (384 - 162);
                    show_head = true;
                }
            }
        }
        private void fgrid_detail_DoubleClick(object sender, System.EventArgs e)
        {

            if (COM.ComVar.This_CDCPower_Level.Equals("E01"))
                return;

            if (_Form_Type.Equals("S") && cmb_level.SelectedIndex.Equals(0))
            {

                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;

                if (sct_col <= (int)ClassLib.TBSXD_SRF_TAIL.IxSTATUS_DESC)
                {
                    Move_Vender(fgrid_detail.Selection.r1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD);
                    return;
                }


                if (fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].Equals("1") && !fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG].Equals("P") && !fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG].Equals("D"))
                {

                    string pop_type = null;
                    string edit_type = null;

                    if (sct_col >= (int)ClassLib.TBSXD_SRF_TAIL.IxPART_SEQ && sct_col <= (int)ClassLib.TBSXD_SRF_TAIL.IxPART_QTY)
                    {
                        pop_type = "Mcode";
                        edit_type = "P";
                    }
                    else if (sct_col >= (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD && sct_col <= (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_DESC)
                    {
                        pop_type = "Mcode";
                        edit_type = "M";
                    }
                    else if (sct_col >= (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD && sct_col <= (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_COMMENT)
                    {
                        pop_type = "Mcode";
                        edit_type = "C";
                    }
                    else if (sct_col.Equals((int)ClassLib.TBSXD_SRF_TAIL.IxMCS_CD))
                    {
                        pop_type = "Mcode";
                        edit_type = "MC";
                    }
                    else if (sct_col >= (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD && sct_col <= (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD)
                    {
                        pop_type = "Scode";
                        edit_type = "U";
                    }


                    if (edit_type == null) return;


                    #region  이전 :  Code Master Setting
                    int vCount = 17;
                    COM.ComVar.Parameter_PopUp = new string[vCount];

                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY - 1] = cmb_factory.SelectedValue.ToString();

                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_SEQ].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_TYPE].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_QTY].ToString();

                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString();

                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_COMMENT].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_NAME].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_DESC - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_DESC].ToString();



                    //COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_YIELD -1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxYIELD_VALUE].ToString();


                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_DESC].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_COMMENT].ToString();


                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_NAME].ToString();


                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMCS_CD].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD].ToString();

                    #endregion

                    BaseInfo.Pop_Material_Master codeMaster = new FlexCDC.BaseInfo.Pop_Material_Master(edit_type);
                    codeMaster.ShowDialog();

                    if (codeMaster.save_flg)
                    {
                        #region 이후 :  Code Master 값 받기
                        for (int i = fgrid_detail.Rows.Fixed; i < fgrid_detail.Rows.Count; i++)
                        {
                            if (fgrid_detail.Rows[i].Selected == true)
                            {
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION]     = "U";
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = "U";

                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_SEQ]  = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ - 1];
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_TYPE] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE - 1];
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC - 1];
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_QTY]  = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1];

                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD]      = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD - 1];
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1];
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_NAME]    = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME - 1];
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_DESC]    = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_DESC - 1];

                                //fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxYIELD_VALUE] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_YIELD -1];

                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD]      = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD - 1];
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_DESC]    = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1];
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1];

                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD]   = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1];
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1];

                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMCS_CD]      = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD - 1];
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1];
                            }

                        }

                        #endregion
                    }


                }
            }
        }        
        private void fgrid_detail_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                fgrid_desc.Focus();
                fgrid_desc.Select(fgrid_desc.Rows.Count - 1, 8, fgrid_desc.Rows.Count - 1, 8);
            }
        }
        private void fgrid_desc_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            int sct_row = fgrid_desc.Selection.r1;
            int sct_col = fgrid_desc.Selection.c1;

            fgrid_desc.Select(fgrid_desc.Selection.r1, 0, fgrid_desc.Selection.r1, fgrid_desc.Cols.Count - 1, false);


            string[] save_array = new string[19];
            for (int j = 0; j < save_array.Length; j++)
            {
                save_array[j] = fgrid_desc[_RowFixed_desc, j].ToString();
            }
            Update_sdd_srf_m_kname(save_array);
        }
        private void fgrid_order_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            int sct_row = fgrid_order.Selection.r1;
            int sct_col = fgrid_order.Selection.c1;
            fgrid_order.Update_Row(sct_row);
        }        
        private void fgrid_vendor_DoubleClick(object sender, System.EventArgs e)
        {

            if (fgrid_vendor.Selection.r1 >= fgrid_vendor.Rows.Fixed)
            {

                Move_Desc(fgrid_vendor.Selection.r1, (int)ClassLib.TBSDD_SRF_VENDOR.IxMAT_CD);

            }
        }

        private DataTable Select_isdesckname(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd, string arg_srf_seq, string arg_part_no)
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_ISDESCKNAME";

            OraDB.ReDim_Parameter(9);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_sr_no";
            OraDB.Parameter_Name[2] = "arg_srf_no";
            OraDB.Parameter_Name[3] = "arg_bom_id";
            OraDB.Parameter_Name[4] = "arg_bom_rev";
            OraDB.Parameter_Name[5] = "arg_nf_Cd";
            OraDB.Parameter_Name[6] = "arg_srf_seq";
            OraDB.Parameter_Name[7] = "arg_part_no";
            OraDB.Parameter_Name[8] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[8] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_sr_no;
            OraDB.Parameter_Values[2] = arg_srf_no;
            OraDB.Parameter_Values[3] = arg_bom_id;
            OraDB.Parameter_Values[4] = arg_bom_rev;
            OraDB.Parameter_Values[5] = arg_nf_cd;
            OraDB.Parameter_Values[6] = arg_srf_seq;
            OraDB.Parameter_Values[7] = arg_part_no;
            OraDB.Parameter_Values[8] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private void Update_sdd_srf_m_kname(string[] save_array)
        {
            string Proc_Name = "pkg_sxd_srf_03.update_sxd_m_desc";

            OraDB.ReDim_Parameter(save_array.Length);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_division";
            OraDB.Parameter_Name[1] = "arg_factory";
            OraDB.Parameter_Name[2] = "arg_sr_no";
            OraDB.Parameter_Name[3] = "arg_srf_no";
            OraDB.Parameter_Name[4] = "arg_bom_id";
            OraDB.Parameter_Name[5] = "arg_bom_rev";
            OraDB.Parameter_Name[6] = "arg_nf_cd";
            OraDB.Parameter_Name[7] = "arg_srf_seq";
            OraDB.Parameter_Name[8] = "arg_part_no";
            OraDB.Parameter_Name[9] = "arg_part_seq";
            OraDB.Parameter_Name[10] = "arg_part_desc";
            OraDB.Parameter_Name[11] = "arg_part_desc_kname";
            OraDB.Parameter_Name[12] = "arg_mat_cd";
            OraDB.Parameter_Name[13] = "arg_mat_name";
            OraDB.Parameter_Name[14] = "arg_mat_name_kname";
            OraDB.Parameter_Name[15] = "arg_color_cd";
            OraDB.Parameter_Name[16] = "arg_color_desc";
            OraDB.Parameter_Name[17] = "arg_color_desc_kname";
            OraDB.Parameter_Name[18] = "arg_upd_user";


            for (int i = 0; i < save_array.Length; i++)
            {
                OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
            }

            for (int i = 0; i < save_array.Length; i++)
            {
                OraDB.Parameter_Values[i] = save_array[i];
            }

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Control Event
        private void dtp_current_ipw_CloseUp(object sender, System.EventArgs e)
        {
            dtp_current_ipw.CustomFormat = dateType;
        }
        private void txt_style_cd_TextChanged(object sender, System.EventArgs e)
        {            

        }
        private void dtp_ets_CloseUp(object sender, System.EventArgs e)
        {
            dtp_ets.CustomFormat = dateType;
        }
        private void dtp_order_date_CloseUp(object sender, System.EventArgs e)
        {
            dtp_order_date.CustomFormat = dateType;
           
            for (int i = _RowFixed_order; i < fgrid_order.Rows.Count; i++)
            {
                fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxORD_YMD] = dtp_order_date.Value.ToString("yyyyMMdd");
            }
        }
        private void dtp_need_by_CloseUp(object sender, System.EventArgs e)
        {
            dtp_need_by.CustomFormat = dateType;
            
            for (int i = _RowFixed_order; i < fgrid_order.Rows.Count; i++)
            {
                fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxNEED_BY] = dtp_need_by.Value.ToString("yyyyMMdd");
            }
        }
        private void cmb_gender_TextChanged(object sender, System.EventArgs e)
        {
            if (_Form_Type.Equals("S")) return;
            if (cmb_gender.SelectedIndex == -1) return;

            for (int i = _RowFixed_order; i < fgrid_order.Rows.Count; i++)
            {
                fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxGEN_CD] = cmb_gender.SelectedValue.ToString();
                if (_head_size == "")
                {
                    fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxSIZE_CD] = Select_gen_size().Replace("'", "");
                }

            }
            _head_dm_bom_flg = "";            
        }
        private void cmb_level_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (cmb_level.SelectedIndex.Equals(-1))
            {
                return;
            }
            else if (cmb_level.SelectedIndex.Equals(0))
            {
                edite_check(false);
            }
            else
            {
                edite_check(true);
            }
        }
        private void cmb_sampletypes_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (cmb_sampletypes.SelectedIndex == -1) return;

            #region 
            if (_Form_Type.Equals("I"))
            {
                _head_nf_cd = cmb_sampletypes.SelectedValue.ToString();


                for (int i = _RowFixed_detali; i < fgrid_detail.Rows.Count; i++)
                {
                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL_LOAD_NEW.IxNF_CD] = _head_nf_cd;

                }

                for (int i = _RowFixed_order; i < fgrid_order.Rows.Count; i++)
                {
                    fgrid_order[i, (int)ClassLib.TBSXD_SRF_ORDER_LOAD.IxNF_CD] = _head_nf_cd;
                }

                new_nf_cd = false;
            }
            else if (_Form_Type.Equals("C"))
            {


            }
            else   //job type ="S"
            {
                try
                {
                    DataTable dt = Select_sdd_srf_nf_cd_check(cmb_factory.SelectedValue.ToString(), txt_srno.Text, txt_srfno.Text, txt_bomid.Text, txt_bomrev.Text, cmb_sampletypes.SelectedValue.ToString());


                    if (dt.Rows[0].ItemArray[0].Equals("N"))
                    {
                        _head_sample_types = cmb_sampletypes.GetItemText(cmb_sampletypes.SelectedIndex, 1);

                        if (_head_nf_cd != cmb_sampletypes.SelectedValue.ToString())
                        {
                            Type_Working("C");
                            
                            #region  Sample Type

                            fgrid_detail.Set_Grid_CDC("SXD_SRF_TAIL_LOAD", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                            fgrid_detail.Set_Action_Image(img_Action);
                            fgrid_detail.Font = new Font("Verdana", 8);
                            _RowFixed_detali = fgrid_detail.Rows.Fixed;
                            fgrid_detail.Styles.Normal.WordWrap = true;



                            fgrid_order.Set_Grid_CDC("SXD_SRF_ORDER_LOAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                            fgrid_order.Set_Action_Image(img_Action);
                            fgrid_order.Font = new Font("Verdana", 8);
                            _RowFixed_order = fgrid_order.Rows.Fixed;
                            fgrid_order.Styles.Normal.WordWrap = true;
                            #endregion

                            #region  Tail Loading구조로 뿌리기 //Level 000

                            dt = null;
                            dt = Select_sdd_srf_tail_for_load();

                            if (dt.Rows.Count == 0) return;

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                fgrid_detail.AddItem(dt.Rows[i].ItemArray, fgrid_detail.Rows.Count, 1);
                                fgrid_detail[i + fgrid_detail.Rows.Fixed, 0] = "I";
                            }

                            dtp_ets.Enabled = true;
                            dtp_need_by.Enabled = true;
                            dtp_order_date.Enabled = false;
                            dtp_current_ipw.Enabled = true;

                            #endregion

                            #region  Order Loading구조로 뿌리기  //Level 000
                            dt = null;
                            dt = Select_sdd_srf_order_for_load();


                            if (dt.Rows.Count == 0) return;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                fgrid_order.AddItem(dt.Rows[i].ItemArray, fgrid_order.Rows.Count, 1);
                                fgrid_order[i + fgrid_order.Rows.Fixed, 0] = "I";

                            }
                            fgrid_order.AllowEditing = true;
                            #endregion                            
                        }

                        new_nf_cd = true;
                        tbtn_Search.Enabled = false;
                    }
                    else
                    {
                        if (_head_nf_cd != cmb_sampletypes.SelectedValue.ToString())
                        {
                            _head_nf_cd = cmb_sampletypes.SelectedValue.ToString();
                            Select_srf_maxseq(cmb_factory.SelectedValue.ToString(), txt_srno.Text, txt_srfno.Text, txt_bomid.Text, txt_bomrev.Text, cmb_sampletypes.SelectedValue.ToString());
                            tbtn_Search_Click(null, null);
                        }
                        new_nf_cd = false;
                        tbtn_Search.Enabled = true;
                    }
                }
                catch
                {
                    new_nf_cd = false;
                }
            }
            

            dtp_need_by.Enabled = true;
            dtp_ets.Enabled = true;

            #endregion

            string _round = cmb_sampletypes.SelectedValue.ToString().Trim();

            if (_round.Equals("JC000") || _round.Equals("JE000") || _round.Equals("JG000") || _round.Equals("KC000") || _round.Equals("KE000") || _round.Equals("KG000"))
            {
                chk_gtm_1st.Enabled = true;
                chk_gtm_2nd.Enabled = true;
            }
            else
            {
                chk_gtm_1st.Enabled = false;
                chk_gtm_2nd.Enabled = false;

                chk_gtm_1st.Checked = false;
                chk_gtm_2nd.Checked = false;
            }
        }
        private void cmb_td_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_td.SelectedIndex == -1)
                return;

            _head_td_code = cmb_td.SelectedValue.ToString();
        }

        private void Clear_txtbox()
        {
            txt_srno.Text = "";
            txt_srfno.Text = "";
            txt_bomid.Text = "";
            txt_bomrev.Text = "";

            txt_bom_comments.Text = "";
            txt_season.Text = "";            
            txt_factory_direct.Text = "";
            txt_bom_state.Text = "";
            txt_last_cd.Text = "";
            txt_colo_ver.Text = "";
            txt_style_cd.Text = "";
            txt_patten.Text = "";
            txt_model_name_bom.Text = "";
            txt_last_cd.Text = "";

            txt_whq_plm.Text = "";
            txt_whq_dev.Text = "";
            txt_nlo_dev.Text = "";

            txt_bom_state.Text = "";
            txt_silhouette.Text = "";
            txt_technology.Text = "";

            txt_lasting_method.Text = "";
            txt_ms_method.Text = "";
            txt_sole_laying_method.Text = "";
            txt_mto_account_name.Text = "";
            txt_bom_comments.Text = "";

            txt_model_name.Text = "";
            txt_mo_id.Text = "";
            txt_requestor.Text = "";
            txt_mo_alias.Text = "";            
            txt_product_code.Text = "";
            txt_srno.Text = "";
            txt_srfno.Text = "";
            txt_bomid.Text = "";
            txt_bomrev.Text = "";

            cmb_category.SelectedIndex = -1;
            cmb_sampletypes.SelectedIndex = -1;
            cmb_gender.SelectedIndex = -1;
            cmb_td.SelectedIndex = -1;
        }
        private string char_con(string arg_data)
        {
            string aa_div = "^";
            bool tmp_replace = false;
            string data_tmp = "";

            if (arg_data != null)
            {

                for (int i = 0; i < arg_data.Length; i++)
                {

                    string aa = arg_data.Substring(i, 1);

                    if (arg_data.Substring(i, 1) == aa_div.ToString())
                    {
                        if (tmp_replace) tmp_replace = false;
                        else tmp_replace = true;
                    }

                    if (!tmp_replace) data_tmp += arg_data.Substring(i, 1).Replace(",", "$");
                    else data_tmp += arg_data.Substring(i, 1);
                }
            }

            return data_tmp;
        }                                    
        private void edite_check(bool arg_edite)
        {
            tbtn_Confirm.Enabled  = ((arg_edite == false) ? true : false);
            tbtn_Print.Enabled    = ((arg_edite == false) ? true : false);
            tbtn_Save.Enabled     = ((arg_edite == false) ? true : false);
            //tbtn_Search.Enabled = ((arg_edite == false)?true:false);
            

            txt_bom_state.ReadOnly          = arg_edite;
            txt_silhouette.ReadOnly         = arg_edite;
            txt_technology.ReadOnly         = arg_edite;
            txt_model_name_bom.ReadOnly     = arg_edite;
            txt_lasting_method.ReadOnly     = arg_edite;
            txt_ms_method.ReadOnly          = arg_edite;
            txt_sole_laying_method.ReadOnly = arg_edite;
            txt_last_cd.ReadOnly            = arg_edite;
            txt_product_code.ReadOnly       = arg_edite;
            //dtp_current_ipw.ReadOnly      = arg_edite;
            txt_mo_alias.ReadOnly           = arg_edite;
            txt_season.ReadOnly             = arg_edite;
            txt_mto_account_name.ReadOnly   = arg_edite;
            txt_whq_plm.ReadOnly            = arg_edite;
            txt_whq_dev.ReadOnly            = arg_edite;
            txt_nlo_dev.ReadOnly            = arg_edite;
            txt_mtl_ver.ReadOnly            = arg_edite;
            txt_colo_ver.ReadOnly           = arg_edite;
            txt_bom_comments.ReadOnly       = arg_edite;
            
            cmb_sampletypes.ReadOnly        = arg_edite;
            
            //txt_model_name.ReadOnly       = arg_edite;
            txt_mo_id.ReadOnly              = arg_edite;
            txt_factory_direct.ReadOnly     = arg_edite;
            txt_state.ReadOnly              = arg_edite;
            txt_requestor.ReadOnly          = arg_edite;
            txt_patten.ReadOnly             = arg_edite;
            //txt_style_cd.ReadOnly         = arg_edite;
            
            fgrid_detail.AllowEditing  = ((arg_edite == false) ? true : false);
            fgrid_order.AllowEditing   = ((arg_edite == false) ? true : false);
            fgrid_desc.AllowEditing    = ((arg_edite == false) ? true : false);
        }        
        private void Set_Information_By_Col(int arg_col)
        {
            int sct_row = fgrid_detail.Selection.r1;
            string pop_type = "M";

            if (fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].Equals("1") && !fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG].Equals("P") && !fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG].Equals("D"))
            {
                //string pop_type = null;
                string edit_type = null;

                if (arg_col >= (int)ClassLib.TBSXD_SRF_TAIL.IxPART_SEQ && arg_col <= (int)ClassLib.TBSXD_SRF_TAIL.IxPART_QTY)
                {
                    pop_type = "Mcode";
                    edit_type = "P";
                }
                else if (arg_col >= (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD && arg_col <= (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_DESC)
                {
                    pop_type = "Mcode";
                    edit_type = "M";
                }
                else if (arg_col >= (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD && arg_col <= (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_COMMENT)
                {
                    pop_type = "Mcode";
                    edit_type = "C";
                }
                else if (arg_col.Equals((int)ClassLib.TBSXD_SRF_TAIL.IxMCS_CD))
                {
                    pop_type = "Mcode";
                    edit_type = "MC";
                }
                else if (arg_col >= (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD && arg_col <= (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD)
                {
                    pop_type = "Scode";
                    edit_type = "U";
                }

                if (edit_type == null) return;

                #region  이전 :  Code Master Setting
                int vCount = 17;
                COM.ComVar.Parameter_PopUp = new string[vCount];

                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY - 1] = cmb_factory.SelectedValue.ToString();

                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_SEQ].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_TYPE].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_QTY].ToString();


                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString();

                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_COMMENT].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_NAME].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_DESC - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_DESC].ToString();


                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_DESC].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_COMMENT].ToString();


                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_NAME].ToString();


                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMCS_CD].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1] = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD].ToString();

                #endregion

                BaseInfo.Pop_Material_Master codeMaster = new FlexCDC.BaseInfo.Pop_Material_Master(edit_type, true);
                codeMaster.ShowDialog();
                if (!codeMaster.save_flg)
                    return;

                #region 이후 :  Code Master 값 받기
                for (int i = fgrid_detail.Rows.Fixed; i < fgrid_detail.Rows.Count; i++)
                {
                    if (fgrid_detail.Rows[i].Selected == true)
                    {
                        fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION] = "U";
                        fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = "U";


                        switch (edit_type)
                        {
                            case "P":
                                {
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_SEQ] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ - 1];
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_TYPE] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE - 1];
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC - 1];
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_QTY] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1];
                                    break;
                                }
                            case "M":
                                {
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD - 1];
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1];
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME - 1];
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_DESC - 1];
                                    break;
                                }

                            case "C":
                                {
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD - 1];
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1];
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1];
                                    break;
                                }
                            case "MC":
                                {
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMCS_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD - 1];
                                    break;
                                }
                            default:
                                {
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1];
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1];
                                    fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1];
                                    break;
                                }
                        }

                    }

                }
                #endregion

            }


        }        
        private void Move_Vender(int arg_row, int arg_col)
        {
            if ((fgrid_detail[arg_row, arg_col] == null) || (fgrid_detail[arg_row, arg_col].ToString() == "")) return;

            for (int i = fgrid_vendor.Rows.Fixed; i < fgrid_vendor.Rows.Count; i++)
            {
                if ((fgrid_vendor[i, (int)ClassLib.TBSDD_SRF_VENDOR.IxMAT_CD] == null) || (fgrid_vendor[i, (int)ClassLib.TBSDD_SRF_VENDOR.IxMAT_CD].ToString() == "")) continue;

                if (fgrid_detail[arg_row, arg_col].ToString() == fgrid_vendor[i, (int)ClassLib.TBSDD_SRF_VENDOR.IxMAT_CD].ToString())
                {
                    tab_control.SelectedIndex = 2;
                    fgrid_vendor.Select(i, 1, i, fgrid_vendor.Cols.Count - 1);
                    break;
                }
            }
        }
        private void Move_Desc(int arg_row, int arg_col)
        {
            if ((fgrid_vendor[arg_row, arg_col] == null) || (fgrid_vendor[arg_row, arg_col].ToString() == "")) return;

            for (int i = fgrid_detail.Rows.Fixed; i < fgrid_detail.Rows.Count; i++)
            {
                if ((fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD] == null) || (fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString() == "")) continue;

                if (fgrid_vendor[arg_row, arg_col].ToString() == fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString())
                {
                    tab_control.SelectedIndex = 0;
                    fgrid_detail.Select(i, 1, i, fgrid_detail.Cols.Count - 1);
                    break;
                }
            }
        }

        private string Select_gen_size()
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_GEN_SIZE_CD";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_GEN_CD";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = cmb_gender.SelectedValue.ToString();
            OraDB.Parameter_Values[2] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString();
        }
        private DataTable Select_sdd_srf_tail_for_load()
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXD_SRF_TAIL_FOR_LOAD";

            OraDB.ReDim_Parameter(14);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SR_NO";
            OraDB.Parameter_Name[2] = "ARG_SRF_NO";
            OraDB.Parameter_Name[3] = "ARG_BOM_ID";
            OraDB.Parameter_Name[4] = "ARG_BOM_REV";
            OraDB.Parameter_Name[5] = "ARG_NF_CD";
            OraDB.Parameter_Name[6] = "ARG_FACTORY_TO";
            OraDB.Parameter_Name[7] = "ARG_SR_NO_TO";
            OraDB.Parameter_Name[8] = "ARG_SRF_NO_TO";
            OraDB.Parameter_Name[9] = "ARG_BOM_ID_TO";
            OraDB.Parameter_Name[10] = "ARG_BOM_REV_TO";
            OraDB.Parameter_Name[11] = "ARG_NF_CD_TO";
            OraDB.Parameter_Name[12] = "ARG_UPD_USER";
            OraDB.Parameter_Name[13] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[9] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[12] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[13] = (int)OracleType.Cursor;



            OraDB.Parameter_Values[0] = _head_factory;
            OraDB.Parameter_Values[1] = _head_sr_no;
            OraDB.Parameter_Values[2] = _head_srf_no;
            OraDB.Parameter_Values[3] = _head_bom_id;
            OraDB.Parameter_Values[4] = _head_bom_rev;
            OraDB.Parameter_Values[5] = _head_nf_cd;
            OraDB.Parameter_Values[6] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[7] = txt_srno.Text.Trim();
            OraDB.Parameter_Values[8] = txt_srfno.Text.Trim();
            OraDB.Parameter_Values[9] = txt_bomid.Text.Trim();
            OraDB.Parameter_Values[10] = txt_bomrev.Text.Trim();
            OraDB.Parameter_Values[11] = cmb_sampletypes.SelectedValue.ToString();
            OraDB.Parameter_Values[12] = ClassLib.ComVar.This_User;
            OraDB.Parameter_Values[13] = "";


            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable Select_sdd_srf_order_for_load()
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXD_SRF_ORDER_FOR_LOAD";

            OraDB.ReDim_Parameter(14);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SR_NO";
            OraDB.Parameter_Name[2] = "ARG_SRF_NO";
            OraDB.Parameter_Name[3] = "ARG_BOM_ID";
            OraDB.Parameter_Name[4] = "ARG_BOM_REV";
            OraDB.Parameter_Name[5] = "ARG_NF_CD";
            OraDB.Parameter_Name[6] = "ARG_FACTORY_TO";
            OraDB.Parameter_Name[7] = "ARG_SR_NO_TO";
            OraDB.Parameter_Name[8] = "ARG_SRF_NO_TO";
            OraDB.Parameter_Name[9] = "ARG_BOM_ID_TO";
            OraDB.Parameter_Name[10] = "ARG_BOM_REV_TO";
            OraDB.Parameter_Name[11] = "ARG_NF_CD_TO";
            OraDB.Parameter_Name[12] = "ARG_UPD_USER";
            OraDB.Parameter_Name[13] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[9] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[12] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[13] = (int)OracleType.Cursor;



            OraDB.Parameter_Values[0] = _head_factory;
            OraDB.Parameter_Values[1] = _head_sr_no;
            OraDB.Parameter_Values[2] = _head_srf_no;
            OraDB.Parameter_Values[3] = _head_bom_id;
            OraDB.Parameter_Values[4] = _head_bom_rev;
            OraDB.Parameter_Values[5] = _head_nf_cd;
            OraDB.Parameter_Values[6] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[7] = txt_srno.Text.Trim();
            OraDB.Parameter_Values[8] = txt_srfno.Text.Trim();
            OraDB.Parameter_Values[9] = txt_bomid.Text.Trim();
            OraDB.Parameter_Values[10] = txt_bomrev.Text.Trim();
            OraDB.Parameter_Values[11] = cmb_sampletypes.SelectedValue.ToString();
            OraDB.Parameter_Values[12] = ClassLib.ComVar.This_User;
            OraDB.Parameter_Values[13] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable Select_sdd_srf_nf_cd_check(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
        {
            string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_NF_CD_CHECK";

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
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }



        private void chk_gtm_1st_CheckedChanged(object sender, EventArgs e)
        {
            bool chk_1st = chk_gtm_1st.Checked;
            bool chk_2nd = chk_gtm_2nd.Checked;

            if (chk_1st && chk_2nd)
            {
                chk_gtm_2nd.Checked = false;
            }
        }
        private void chk_gtm_2nd_CheckedChanged(object sender, EventArgs e)
        {
            bool chk_1st = chk_gtm_1st.Checked;
            bool chk_2nd = chk_gtm_2nd.Checked;

            if (chk_1st && chk_2nd)
            {
                chk_gtm_1st.Checked = false;
            }
        }
        #endregion

        #region Context Menu

        #region Part ContextMenu
        private void mnu_copy_record_Click(object sender, EventArgs e)
        {

        }
        private void mnu_copy_specunit_Click(object sender, EventArgs e)
        {
            int sct_row = fgrid_detail.Selection.r1;
            int sct_col = fgrid_detail.Selection.c1;

            if (spec_cd == null && unit_value == null)
            {
                cmenu.MenuItems[2].Text = "Paste Unit/Spec";

                spec_cd = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD].ToString();
                spec_name = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_NAME].ToString();
                unit_value = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD].ToString();
            }
            else if (spec_cd.Length > 0 && unit_value.Length > 0)
            {
                for (int i = _RowFixed_detali; i < fgrid_detail.Rows.Count; i++)
                {
                    if (fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].Equals("1"))
                    {
                        if (fgrid_detail.Rows[i].Selected)
                        {
                            if (!fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION].Equals("I"))
                            {
                                fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION] = "U";
                            }
                            fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = "U";
                            fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxSTATUS] = "Y";
                            fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD] = spec_cd;
                            fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_NAME] = spec_name;
                            fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD] = unit_value;
                        }
                    }
                }

                spec_cd = null;
                spec_name = null;
                unit_value = null;

                cmenu.MenuItems[2].Text = "Copy Unit/Spec";
            }
        }
        private void mnu_edit_spec_Click(object sender, EventArgs e)
        {
            try
            {
                BaseInfo.Pop_Spec_Editer specEditer = new FlexCDC.BaseInfo.Pop_Spec_Editer(this, "S", "U");
                specEditer.ShowDialog();
            }
            catch
            {

            }
        }

        private void mnu_insert_record_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_detail.Selection.r1;
                int sct_col = fgrid_detail.Selection.c1;

                fgrid_detail.Tree.Show(2);

                int insert_row = 0;
                string part_no = fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_NO].ToString();

                for (int i = sct_row; i < fgrid_detail.Rows.Count; i++)
                {
                    if (!fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_NO].Equals(part_no))
                    {
                        insert_row = i - 1;
                        break;
                    }
                }

                if (insert_row.Equals(0)) insert_row = fgrid_detail.Rows.Count - 1;


                int _newPartno = 0;
                for (int i = _RowFixed_detali; i < fgrid_detail.Rows.Count; i++)
                {
                    int Partno = int.Parse(fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_NO].ToString().Trim().Replace("@", "0").Split(".".ToCharArray())[0]);
                    if (_newPartno < Partno)
                    {
                        _newPartno = Partno;
                    }
                }

                fgrid_detail.Rows.InsertNode(insert_row + 1, 1);
                for (int j = 0; j < fgrid_detail.Cols.Count; j++)
                {
                    fgrid_detail[insert_row + 1, j] = " ";
                }

                fgrid_detail[insert_row + 1, 0] = "I";
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxFACTORY] = cmb_factory.SelectedValue.ToString();
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxSR_NO]   = txt_srno.Text.Trim();
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_NO]  = txt_srfno.Text.Trim();
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxBOM_ID]  = txt_bomid.Text.Trim();
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxBOM_REV] = txt_bomrev.Text.Trim();
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxNF_CD]   = cmb_sampletypes.SelectedValue.ToString();
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_SEQ] = cmb_level.SelectedValue.ToString();
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL]    = "1";
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxVEN_SEQ]      = "0";
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = "I";
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxAUTO_FLG]     = "N";
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxYIELD_VALUE]  = "0";
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxLOSS_VALUE]   = "0";
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCOMMON_YN]    = "False";
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCBD_PRICE]    = "0";
                        

                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_NO] = (_newPartno + 1).ToString();
                
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPUR_DIV] = "";

                int be_sort_no = int.Parse(fgrid_detail[sct_row, (int)ClassLib.TBSXD_SRF_TAIL.IxSORT_NO].ToString());

                try
                {
                    int af_sort_no = int.Parse(fgrid_detail[insert_row + 2, (int)ClassLib.TBSXD_SRF_TAIL.IxSORT_NO].ToString());

                    fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxSORT_NO] = (be_sort_no + ((af_sort_no - be_sort_no) / 2)).ToString();
                }
                catch
                {
                    fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxSORT_NO] = (be_sort_no + 100).ToString();
                }




                fgrid_detail.Tree.Show(1);

                #region  이전 :  Code Master Setting
                int vCount = 17;
                COM.ComVar.Parameter_PopUp = new string[vCount];

                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY - 1] = cmb_factory.SelectedValue.ToString();

                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ - 1]  = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_SEQ].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE - 1] = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_TYPE].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC - 1] = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1]  = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_QTY].ToString();

                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD - 1]      = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1] = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_COMMENT].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME - 1]    = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_NAME].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_DESC - 1]    = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_DESC].ToString();



                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_YIELD - 1] = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxYIELD_VALUE].ToString();


                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD - 1]      = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1]    = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_DESC].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1] = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_COMMENT].ToString();


                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1]   = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1] = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_NAME].ToString();


                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD - 1]  = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMCS_CD].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1] = fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD].ToString();


                #endregion

                BaseInfo.Pop_Material_Master codeMaster = new FlexCDC.BaseInfo.Pop_Material_Master("P");
                codeMaster.ShowDialog();

                #region 이후 :  Code Master 값 받기
                //fgrid_detail[insert_row+1, (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION] = "U";
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = "I";

                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_SEQ]  = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ - 1];
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_TYPE] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE - 1];
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC - 1];
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_QTY]  = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1];

                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD]      = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD - 1];
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1];
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_NAME]    = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME - 1];
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_DESC]    = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_DESC - 1];

                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxYIELD_VALUE] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_YIELD - 1];

                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD]      = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD - 1];
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_DESC]    = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1];
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1];

                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD]   = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1];
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1];

                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxMCS_CD]      = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD - 1];
                fgrid_detail[insert_row + 1, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1];

                #endregion

            }
            catch
            {

            }

        }
        private void mnu_update_record_Click(object sender, EventArgs e)
        {
            int sct_col = fgrid_detail.Selection.c1;
            int[] sct_rows = fgrid_detail.Selections;

            if (sct_rows.Length == 1)
                fgrid_detail_DoubleClick(null, null);
            else
                Set_Information_By_Col(sct_col);

        }
        private void mnu_delete_record_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = _RowFixed_detali; i < fgrid_detail.Rows.Count; i++)
                {
                    if (fgrid_detail.Rows[i].Selected && fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].Equals("1"))
                    {
                        fgrid_detail[i, 0] = "D";
                        fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = "D";
                    }
                }
            }
            catch
            {

            }
        }

        private void mnu_pending_Click(object sender, EventArgs e)
        {
            try
            {
                int[] sct_rows = fgrid_detail.Selections;
                int sct_col = fgrid_detail.Selection.c1;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].Equals("1"))
                    {                   
                        fgrid_detail[sct_rows[i], 0] = "U";
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = "P";
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG_DESC] = "Pending";
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXD_SRF_TAIL.IxSTATUS_DESC] = "Edited";
                        fgrid_detail.Rows[sct_rows[i]].StyleNew.BackColor = Color.FromArgb(245, 173, 173);
                    }
                }                
            }
            catch
            {

            }
        }
        private void mnu_release_Click(object sender, EventArgs e)
        {
            try
            {               
                int[] sct_rows = fgrid_detail.Selections;
                int sct_col = fgrid_detail.Selection.c1;


                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].Equals("1"))
                    {                        
                        fgrid_detail[sct_rows[i], 0] = "U";
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = "U";
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG_DESC] = "Updated";
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXD_SRF_TAIL.IxSTATUS_DESC] = "Edited";
                        fgrid_detail.Rows[sct_rows[i]].StyleNew.BackColor = Color.WhiteSmoke;
                    }
                }                
            }
            catch
            {

            }
        }

        private void mnu_multi_change_Click(object sender, EventArgs e)
        {
            try
            {
                int vCount = 9;

                COM.ComVar.Parameter_PopUp = new string[vCount];

                COM.ComVar.Parameter_PopUp[0] = cmb_factory.SelectedValue.ToString();
                COM.ComVar.Parameter_PopUp[1] = txt_srno.Text;
                COM.ComVar.Parameter_PopUp[2] = txt_srfno.Text;
                COM.ComVar.Parameter_PopUp[3] = txt_bomid.Text;
                COM.ComVar.Parameter_PopUp[4] = txt_bomrev.Text;
                COM.ComVar.Parameter_PopUp[5] = cmb_sampletypes.SelectedValue.ToString();
                COM.ComVar.Parameter_PopUp[6] = fgrid_detail[fgrid_detail.Selection.r1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC].ToString();
                COM.ComVar.Parameter_PopUp[7] = fgrid_detail[fgrid_detail.Selection.r1, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG].ToString();
                COM.ComVar.Parameter_PopUp[8] = fgrid_detail[fgrid_detail.Selection.r1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_NO].ToString();
                
                FlexCDC.CDC_Bom.Pop_Bom_Muti_Changge vpop = new FlexCDC.CDC_Bom.Pop_Bom_Muti_Changge();
                vpop.ShowDialog();
            }
            catch
            {

            }
        }
        private void mnu_multi_corfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int vCount = 7;

                COM.ComVar.Parameter_PopUp = new string[vCount];

                COM.ComVar.Parameter_PopUp[0] = cmb_factory.SelectedValue.ToString();
                COM.ComVar.Parameter_PopUp[1] = txt_srno.Text;
                COM.ComVar.Parameter_PopUp[2] = txt_srfno.Text;
                COM.ComVar.Parameter_PopUp[3] = txt_bomid.Text;
                COM.ComVar.Parameter_PopUp[4] = txt_bomrev.Text;
                COM.ComVar.Parameter_PopUp[5] = cmb_sampletypes.SelectedValue.ToString();
                COM.ComVar.Parameter_PopUp[6] = fgrid_detail[fgrid_detail.Selection.r1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_NO].ToString();
                
                FlexCDC.CDC_Bom.Pop_Bom_Muti_Confirm vpop = new FlexCDC.CDC_Bom.Pop_Bom_Muti_Confirm();
                vpop.ShowDialog();

                if (vpop.save_flg)
                {
                    //재조회 
                    Select_srf_maxseq(cmb_factory.SelectedValue.ToString(), txt_srno.Text, txt_srfno.Text, txt_bomid.Text, txt_bomrev.Text, cmb_sampletypes.SelectedValue.ToString());
                    tbtn_Search_Click(null, null);
                }
            }
            catch
            {

            }

        }
        private void mnu_combine_Click(object sender, EventArgs e)
        {
            Pop_Bom_Combine combine = new Pop_Bom_Combine(this);
            combine.Show();

        }
        #endregion

        #region Order ContextMenu
        private void mnu_change_order_Click(object sender, EventArgs e)
        {
            try
            {
                int vCount = 7;

                COM.ComVar.Parameter_PopUp = new string[vCount];

                COM.ComVar.Parameter_PopUp[0] = cmb_factory.SelectedValue.ToString();
                COM.ComVar.Parameter_PopUp[1] = txt_srno.Text;
                COM.ComVar.Parameter_PopUp[2] = txt_srfno.Text;
                COM.ComVar.Parameter_PopUp[3] = txt_bomid.Text;
                COM.ComVar.Parameter_PopUp[4] = txt_bomrev.Text;
                COM.ComVar.Parameter_PopUp[5] = cmb_sampletypes.SelectedValue.ToString();
                COM.ComVar.Parameter_PopUp[6] = fgrid_order[fgrid_order.Selection.r1, (int)ClassLib.TBSXD_SRF_ORDER.IxORD_TYPE].ToString();


                FlexCDC.CDC_Bom.Pop_Order_Muti_Change vpop = new FlexCDC.CDC_Bom.Pop_Order_Muti_Change();
                vpop.ShowDialog();
            }
            catch
            {

            }
        }

        private void mnt_Confirm_Order_Click(object sender, System.EventArgs e)
        {
            try
            {
                int vCount = 7;

                COM.ComVar.Parameter_PopUp = new string[vCount];

                COM.ComVar.Parameter_PopUp[0] = cmb_factory.SelectedValue.ToString();
                COM.ComVar.Parameter_PopUp[1] = txt_srno.Text;
                COM.ComVar.Parameter_PopUp[2] = txt_srfno.Text;
                COM.ComVar.Parameter_PopUp[3] = txt_bomid.Text;
                COM.ComVar.Parameter_PopUp[4] = txt_bomrev.Text;
                COM.ComVar.Parameter_PopUp[5] = cmb_sampletypes.SelectedValue.ToString();
                COM.ComVar.Parameter_PopUp[6] = fgrid_detail[fgrid_detail.Selection.r1, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_NO].ToString();

                FlexCDC.CDC_Bom.Pop_Bom_Muti_Confirm vpop = new FlexCDC.CDC_Bom.Pop_Bom_Muti_Confirm();
                vpop.ShowDialog();

                if (vpop.save_flg)
                {
                    Select_srf_maxseq(cmb_factory.SelectedValue.ToString(), txt_srno.Text, txt_srfno.Text, txt_bomid.Text, txt_bomrev.Text, cmb_sampletypes.SelectedValue.ToString());
                    tbtn_Search_Click(null, null);
                }
            }
            catch
            {

            }
        }
        #endregion

        #endregion               
	}
}



