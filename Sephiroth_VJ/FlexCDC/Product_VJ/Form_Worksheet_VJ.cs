using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Xml;
using System.IO;
using C1.Win.C1FlexGrid;
using System.Diagnostics;
using System.Text;
using Microsoft.Office.Interop.Excel;

namespace FlexCDC.Product_VJ
{
	public class Form_Worksheet_VJ : COM.PCHWinForm.Form_Top
	{	
		#region Control Define
        private System.Windows.Forms.ContextMenu cmenu_img;
        private System.Windows.Forms.MenuItem mnu_image;
        private OpenFileDialog openFileDialog1;      
        private System.Windows.Forms.GroupBox groupBox1;
        private ContextMenuStrip ctm_Menu;
        private ToolStripMenuItem mnu_insert;
        private Panel pnl_main;
        private Panel pnl_Body;
        public Panel pnl_info;
        private System.Windows.Forms.TextBox txt_barcode_date;
        private System.Windows.Forms.TextBox txt_medial_height;
        private System.Windows.Forms.TextBox txt_fit;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.TextBox txt_sample_weight;
        private System.Windows.Forms.TextBox txt_fag_qty;
        private System.Windows.Forms.TextBox txt_dispatch_qty;
        private System.Windows.Forms.TextBox txt_ids_length;
        private System.Windows.Forms.TextBox txt_nike_dev;
        private System.Windows.Forms.TextBox txt_midsole_hardness;
        private System.Windows.Forms.TextBox txt_cdc_dev;
        private System.Windows.Forms.TextBox txt_lace_length;
        private System.Windows.Forms.TextBox txt_laterial_height;
        private System.Windows.Forms.TextBox txt_heel_height;
        private System.Windows.Forms.TextBox txt_collar_height;
        private System.Windows.Forms.Label lbl_medial_height;
        private DateTimePicker dtp_dispatch_date;
        private DateTimePicker dtp_request_date;
        private System.Windows.Forms.Label lbl_fit;
        private System.Windows.Forms.Label lbl_sample_weigt;
        private System.Windows.Forms.Label lbl_shoe_lace;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_insole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_IDS_length;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_midsole_hardness;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_lace_length;
        private System.Windows.Forms.Label lbl_lateral_height;
        private System.Windows.Forms.Label lbl_heel_height;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_collar_height;
        private System.Windows.Forms.Label lbl_req_date;
        private System.Windows.Forms.TextBox txt_solelaying_method;
        private System.Windows.Forms.TextBox txt_midsole_method;
        private System.Windows.Forms.TextBox txt_lasting_method;
        private System.Windows.Forms.Label lbl_solelaying_method;
        private System.Windows.Forms.Label lbl_ms_method;
        private System.Windows.Forms.Label lbl_last;
        private C1.Win.C1List.C1Combo cmb_p_bom;
        private System.Windows.Forms.Label lbl_p_bom;
        public Panel pnl_SearchImage;
        private System.Windows.Forms.TextBox txt_whq_dev;
        private C1.Win.C1List.C1Combo cmb_gender;
        private System.Windows.Forms.Label lbl_style_cd;
        private System.Windows.Forms.TextBox txt_style_cd;
        private System.Windows.Forms.TextBox txt_mto_acc;
        private System.Windows.Forms.Label lbl_mto_acc;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.Label lbl_barcodekey;
        private System.Windows.Forms.TextBox txt_insole;
        private System.Windows.Forms.TextBox txt_upper_mat;
        private System.Windows.Forms.TextBox txt_srno;
        private System.Windows.Forms.TextBox txt_stl_file;
        private System.Windows.Forms.Label lbl_srno;
        private System.Windows.Forms.Label lbl_seasonyear;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_whq_dev;
        private System.Windows.Forms.TextBox txt_bom_id;
        private System.Windows.Forms.Label lbl_bomid;
        private System.Windows.Forms.Label lbl_t_d;
        private System.Windows.Forms.Label lbl_current_fob;
        private System.Windows.Forms.Label lbl_retail_price;
        private System.Windows.Forms.Label lbl_barcode;
        private System.Windows.Forms.Label lbl_stl_file;
        private System.Windows.Forms.Label lbl_ipw_ymd;
        private System.Windows.Forms.TextBox txt_retail_price;
        private System.Windows.Forms.TextBox txt_current_fob;
        private System.Windows.Forms.TextBox txt_colors;
        private System.Windows.Forms.Label lbl_colors;
        private System.Windows.Forms.TextBox txt_lastcd;
        private System.Windows.Forms.TextBox txt_pattern;
        private System.Windows.Forms.Label lbl_lastcd;
        private System.Windows.Forms.Label lbl_pattern;
        private System.Windows.Forms.Label lbl_sampletype;
        private System.Windows.Forms.TextBox txt_srfno;
        private System.Windows.Forms.Label lbl_srfno;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.TextBox txt_modelname;
        private System.Windows.Forms.Label lbl_modelname;
        private System.Windows.Forms.Label lbl_rts;
        private System.Windows.Forms.TextBox txt_dev_prod;
        public PictureBox picb_MR;
        private System.Windows.Forms.TextBox txt_lace_desc;
        public PictureBox pictureBox2;
        public PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_upper_mat;
        public System.Windows.Forms.Label lbl_title;
        public PictureBox pictureBox4;
        public PictureBox pictureBox5;
        public PictureBox pictureBox6;
        private C1.Win.C1List.C1Combo cmb_category;
        public PictureBox pictureBox7;
        private System.Windows.Forms.Label lbl_category;
        public PictureBox pictureBox9;
        public PictureBox pictureBox8;
        public Panel panel5;
        private System.Windows.Forms.Label label3;
        public PictureBox pictureBox27;
        public PictureBox pictureBox28;
        public PictureBox pictureBox29;
        public System.Windows.Forms.Label label6;
        public PictureBox pictureBox30;
        public PictureBox pictureBox31;
        public PictureBox pictureBox32;
        public PictureBox pictureBox33;
        public PictureBox pictureBox34;
        public PictureBox pictureBox35;
        public Panel panel4;
        private System.Windows.Forms.Label label10;
        public PictureBox pictureBox18;
        public PictureBox pictureBox19;
        public PictureBox pictureBox20;
        public System.Windows.Forms.Label label8;
        public PictureBox pictureBox21;
        public PictureBox pictureBox22;
        public PictureBox pictureBox23;
        public PictureBox pictureBox24;
        public PictureBox pictureBox25;
        public PictureBox pictureBox26;
        public Panel pnl_head;
        private Panel panel2;
        private Panel pnl_grid;
        public COM.FSP flg_project;
        public Panel panel3;
        private C1.Win.C1List.C1Combo cmb_sampetyps_h;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1List.C1Combo cmb_devuser_h;
        private System.Windows.Forms.TextBox txt_bom_id_h;
        private System.Windows.Forms.Label lbl_devuser;
        private C1.Win.C1List.C1Combo cmb_factory_h;
        private System.Windows.Forms.Label lbl_factory;
        private System.Windows.Forms.Label label4;
        public PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_bom_id;
        public PictureBox pictureBox10;
        public PictureBox pictureBox11;
        public System.Windows.Forms.Label lbl_srf_info;
        public PictureBox pictureBox12;
        public PictureBox pictureBox13;
        public PictureBox pictureBox14;
        public PictureBox pictureBox15;
        public PictureBox pictureBox16;
        public PictureBox pictureBox17;
        private System.Windows.Forms.TextBox txt_sr_no_h;
        private System.Windows.Forms.Label lbl_sr_no_h;
        private C1.Win.C1List.C1Combo cmb_season_h;
        private System.Windows.Forms.Label lbl_season_h;
        private C1.Win.C1List.C1Combo cmb_category_h;
        private System.Windows.Forms.Label lbl_category_h;
        private System.Windows.Forms.TextBox txt_srf_no_h;
        private System.Windows.Forms.Label lbl_srf_no_h;
        private ToolStripMenuItem mnu_delete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnu_upload;
        private ToolStripMenuItem mnu_download;
        private ToolStripMenuItem mnu_edit;
        private ToolStripMenuItem mnu_copy;
        private ToolStripMenuItem mnu_paste;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnu_forecast;
        private DateTimePicker dtp_ets;
        private DateTimePicker dtp_ipw;
        private ToolStripMenuItem mnu_copy_record;
        private C1.Win.C1List.C1Combo cmb_round;
        private ToolStripMenuItem mnu_upload_tag;
        private ToolStripMenuItem mnu_request;
        private ToolStripSeparator mnu_sp1;
        private System.Windows.Forms.Label lbl_dev_prod;
        private C1.Win.C1List.C1Combo cmb_season_s;
        private System.Windows.Forms.Label lbl_tag_cmt;
        private System.Windows.Forms.TextBox txt_tag_cmt;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnu_multi;
        private Panel pnl_tab_process_upper;
        private System.Windows.Forms.GroupBox grb_op;
        private System.Windows.Forms.TextBox txt_cutting;
        private System.Windows.Forms.CheckBox chk_cutting;
        private System.Windows.Forms.TextBox txt_fss;
        private System.Windows.Forms.CheckBox chk_fss;
        private System.Windows.Forms.TextBox txt_ups;
        private System.Windows.Forms.CheckBox chk_ups;
        private System.Windows.Forms.TextBox txt_ems;
        private System.Windows.Forms.CheckBox chk_ems;
        private System.Windows.Forms.TextBox txt_abs;
        private System.Windows.Forms.CheckBox chk_abs;
        private System.Windows.Forms.TextBox txt_upe;
        private System.Windows.Forms.CheckBox chk_upe;
        private System.Windows.Forms.TextBox txt_os;
        private System.Windows.Forms.CheckBox chk_os;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.CheckBox chk_ip;
        private System.Windows.Forms.TextBox txt_pu;
        private System.Windows.Forms.CheckBox chk_pu;
        private System.Windows.Forms.TextBox txt_ph;
        private System.Windows.Forms.CheckBox chk_ph;
        private System.Windows.Forms.TextBox txt_fga;
        private System.Windows.Forms.CheckBox chk_fga;
        private System.Windows.Forms.Label lbl_cutting;
        private System.Windows.Forms.Label lbl_fga;
        private System.Windows.Forms.Label lbl_fss;
        private System.Windows.Forms.Label lbl_ups;
        private System.Windows.Forms.Label lbl_emb;
        private System.Windows.Forms.Label lbl_abs;
        private System.Windows.Forms.Label lbl_ems;
        private System.Windows.Forms.Label lbl_pr;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_pu;
        private System.Windows.Forms.Label lbl_ph;
        private ToolStripMenuItem mnu_release;
        private System.Windows.Forms.TextBox txt_mat_ymd;
        private System.Windows.Forms.Label lbl_mat_ymd;
        public C1.Win.C1List.C1Combo cmb_sms_mold;
        public C1.Win.C1List.C1Combo cmb_sms_dev;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mnu_pattern;
        private System.Windows.Forms.CheckBox chk_pcc_dd;
        public C1.Win.C1List.C1Combo cmb_t_d;
        private System.Windows.Forms.Label btn_sms_mold;
        private System.Windows.Forms.Label lbl_sms_mold;
        private System.Windows.Forms.Label lbl_sms_dev;
        private System.Windows.Forms.Label btn_sms_dev;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem mnu_retry;
        private System.Windows.Forms.Label btn_sms_chem;
        public C1.Win.C1List.C1Combo cmb_sms_chem;
        private System.Windows.Forms.Label lbl_sms_chem;
		private System.ComponentModel.IContainer components = null;


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

		#region Designer
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Worksheet_VJ));
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
            C1.Win.C1List.Style style113 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style114 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style115 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style116 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style117 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style118 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style119 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style120 = new C1.Win.C1List.Style();
            this.cmenu_img = new System.Windows.Forms.ContextMenu();
            this.mnu_image = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ctm_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_copy_record = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_sp1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_request = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_release = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_upload = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_download = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_upload_tag = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_forecast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_multi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_pattern = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_retry = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.pnl_tab_process_upper = new System.Windows.Forms.Panel();
            this.grb_op = new System.Windows.Forms.GroupBox();
            this.lbl_fga = new System.Windows.Forms.Label();
            this.lbl_fss = new System.Windows.Forms.Label();
            this.lbl_ups = new System.Windows.Forms.Label();
            this.lbl_emb = new System.Windows.Forms.Label();
            this.lbl_abs = new System.Windows.Forms.Label();
            this.lbl_ems = new System.Windows.Forms.Label();
            this.lbl_pr = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_pu = new System.Windows.Forms.Label();
            this.lbl_ph = new System.Windows.Forms.Label();
            this.lbl_cutting = new System.Windows.Forms.Label();
            this.txt_fga = new System.Windows.Forms.TextBox();
            this.chk_fga = new System.Windows.Forms.CheckBox();
            this.txt_fss = new System.Windows.Forms.TextBox();
            this.chk_fss = new System.Windows.Forms.CheckBox();
            this.txt_ups = new System.Windows.Forms.TextBox();
            this.chk_ups = new System.Windows.Forms.CheckBox();
            this.txt_ems = new System.Windows.Forms.TextBox();
            this.chk_ems = new System.Windows.Forms.CheckBox();
            this.txt_abs = new System.Windows.Forms.TextBox();
            this.chk_abs = new System.Windows.Forms.CheckBox();
            this.txt_upe = new System.Windows.Forms.TextBox();
            this.chk_upe = new System.Windows.Forms.CheckBox();
            this.txt_os = new System.Windows.Forms.TextBox();
            this.chk_os = new System.Windows.Forms.CheckBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.chk_ip = new System.Windows.Forms.CheckBox();
            this.txt_pu = new System.Windows.Forms.TextBox();
            this.chk_pu = new System.Windows.Forms.CheckBox();
            this.txt_ph = new System.Windows.Forms.TextBox();
            this.chk_ph = new System.Windows.Forms.CheckBox();
            this.txt_cutting = new System.Windows.Forms.TextBox();
            this.chk_cutting = new System.Windows.Forms.CheckBox();
            this.pnl_info = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.btn_sms_dev = new System.Windows.Forms.Label();
            this.lbl_sms_mold = new System.Windows.Forms.Label();
            this.lbl_sms_dev = new System.Windows.Forms.Label();
            this.btn_sms_mold = new System.Windows.Forms.Label();
            this.cmb_t_d = new C1.Win.C1List.C1Combo();
            this.chk_pcc_dd = new System.Windows.Forms.CheckBox();
            this.cmb_sms_mold = new C1.Win.C1List.C1Combo();
            this.cmb_sms_dev = new C1.Win.C1List.C1Combo();
            this.txt_mat_ymd = new System.Windows.Forms.TextBox();
            this.lbl_mat_ymd = new System.Windows.Forms.Label();
            this.lbl_tag_cmt = new System.Windows.Forms.Label();
            this.txt_tag_cmt = new System.Windows.Forms.TextBox();
            this.cmb_season_s = new C1.Win.C1List.C1Combo();
            this.lbl_dev_prod = new System.Windows.Forms.Label();
            this.cmb_round = new C1.Win.C1List.C1Combo();
            this.dtp_ipw = new System.Windows.Forms.DateTimePicker();
            this.dtp_ets = new System.Windows.Forms.DateTimePicker();
            this.cmb_p_bom = new C1.Win.C1List.C1Combo();
            this.lbl_fit = new System.Windows.Forms.Label();
            this.txt_fit = new System.Windows.Forms.TextBox();
            this.txt_barcode_date = new System.Windows.Forms.TextBox();
            this.txt_fag_qty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dispatch_qty = new System.Windows.Forms.TextBox();
            this.lbl_IDS_length = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ids_length = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_medial_height = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_nike_dev = new System.Windows.Forms.TextBox();
            this.lbl_req_date = new System.Windows.Forms.Label();
            this.txt_cdc_dev = new System.Windows.Forms.TextBox();
            this.txt_whq_dev = new System.Windows.Forms.TextBox();
            this.dtp_dispatch_date = new System.Windows.Forms.DateTimePicker();
            this.cmb_gender = new C1.Win.C1List.C1Combo();
            this.dtp_request_date = new System.Windows.Forms.DateTimePicker();
            this.txt_sample_weight = new System.Windows.Forms.TextBox();
            this.lbl_style_cd = new System.Windows.Forms.Label();
            this.txt_style_cd = new System.Windows.Forms.TextBox();
            this.lbl_medial_height = new System.Windows.Forms.Label();
            this.txt_midsole_hardness = new System.Windows.Forms.TextBox();
            this.txt_mto_acc = new System.Windows.Forms.TextBox();
            this.lbl_mto_acc = new System.Windows.Forms.Label();
            this.txt_lace_length = new System.Windows.Forms.TextBox();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.lbl_barcodekey = new System.Windows.Forms.Label();
            this.txt_laterial_height = new System.Windows.Forms.TextBox();
            this.txt_insole = new System.Windows.Forms.TextBox();
            this.lbl_midsole_hardness = new System.Windows.Forms.Label();
            this.txt_heel_height = new System.Windows.Forms.TextBox();
            this.txt_upper_mat = new System.Windows.Forms.TextBox();
            this.lbl_lace_length = new System.Windows.Forms.Label();
            this.txt_collar_height = new System.Windows.Forms.TextBox();
            this.lbl_lateral_height = new System.Windows.Forms.Label();
            this.txt_srno = new System.Windows.Forms.TextBox();
            this.txt_stl_file = new System.Windows.Forms.TextBox();
            this.lbl_srno = new System.Windows.Forms.Label();
            this.lbl_seasonyear = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.lbl_sample_weigt = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_whq_dev = new System.Windows.Forms.Label();
            this.txt_bom_id = new System.Windows.Forms.TextBox();
            this.lbl_heel_height = new System.Windows.Forms.Label();
            this.lbl_insole = new System.Windows.Forms.Label();
            this.lbl_shoe_lace = new System.Windows.Forms.Label();
            this.lbl_bomid = new System.Windows.Forms.Label();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_collar_height = new System.Windows.Forms.Label();
            this.lbl_t_d = new System.Windows.Forms.Label();
            this.lbl_current_fob = new System.Windows.Forms.Label();
            this.lbl_retail_price = new System.Windows.Forms.Label();
            this.lbl_barcode = new System.Windows.Forms.Label();
            this.lbl_stl_file = new System.Windows.Forms.Label();
            this.lbl_ipw_ymd = new System.Windows.Forms.Label();
            this.txt_retail_price = new System.Windows.Forms.TextBox();
            this.txt_current_fob = new System.Windows.Forms.TextBox();
            this.txt_colors = new System.Windows.Forms.TextBox();
            this.lbl_colors = new System.Windows.Forms.Label();
            this.txt_lastcd = new System.Windows.Forms.TextBox();
            this.txt_pattern = new System.Windows.Forms.TextBox();
            this.txt_solelaying_method = new System.Windows.Forms.TextBox();
            this.lbl_p_bom = new System.Windows.Forms.Label();
            this.lbl_lastcd = new System.Windows.Forms.Label();
            this.txt_midsole_method = new System.Windows.Forms.TextBox();
            this.lbl_pattern = new System.Windows.Forms.Label();
            this.txt_lasting_method = new System.Windows.Forms.TextBox();
            this.lbl_solelaying_method = new System.Windows.Forms.Label();
            this.lbl_sampletype = new System.Windows.Forms.Label();
            this.lbl_ms_method = new System.Windows.Forms.Label();
            this.txt_srfno = new System.Windows.Forms.TextBox();
            this.lbl_last = new System.Windows.Forms.Label();
            this.lbl_srfno = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txt_modelname = new System.Windows.Forms.TextBox();
            this.lbl_modelname = new System.Windows.Forms.Label();
            this.lbl_rts = new System.Windows.Forms.Label();
            this.txt_dev_prod = new System.Windows.Forms.TextBox();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.txt_lace_desc = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_upper_mat = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cmb_category = new C1.Win.C1List.C1Combo();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.flg_project = new COM.FSP();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_srf_no_h = new System.Windows.Forms.TextBox();
            this.lbl_srf_no_h = new System.Windows.Forms.Label();
            this.txt_sr_no_h = new System.Windows.Forms.TextBox();
            this.lbl_sr_no_h = new System.Windows.Forms.Label();
            this.cmb_season_h = new C1.Win.C1List.C1Combo();
            this.lbl_season_h = new System.Windows.Forms.Label();
            this.cmb_category_h = new C1.Win.C1List.C1Combo();
            this.lbl_category_h = new System.Windows.Forms.Label();
            this.cmb_sampetyps_h = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_devuser_h = new C1.Win.C1List.C1Combo();
            this.txt_bom_id_h = new System.Windows.Forms.TextBox();
            this.lbl_devuser = new System.Windows.Forms.Label();
            this.cmb_factory_h = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_bom_id = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lbl_srf_info = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.lbl_sms_chem = new System.Windows.Forms.Label();
            this.cmb_sms_chem = new C1.Win.C1List.C1Combo();
            this.btn_sms_chem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.ctm_Menu.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.pnl_Body.SuspendLayout();
            this.pnl_tab_process_upper.SuspendLayout();
            this.grb_op.SuspendLayout();
            this.pnl_info.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_t_d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sms_mold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sms_dev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_round)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_p_bom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
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
            this.pnl_head.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flg_project)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampetyps_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_devuser_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sms_chem)).BeginInit();
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
            // cmenu_img
            // 
            this.cmenu_img.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_image});
            // 
            // mnu_image
            // 
            this.mnu_image.Index = 0;
            this.mnu_image.Text = "Images Edit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ctm_Menu
            // 
            this.ctm_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_insert,
            this.mnu_copy_record,
            this.mnu_delete,
            this.mnu_sp1,
            this.mnu_request,
            this.mnu_release,
            this.toolStripSeparator1,
            this.mnu_upload,
            this.mnu_download,
            this.toolStripSeparator2,
            this.mnu_edit,
            this.mnu_copy,
            this.mnu_paste,
            this.mnu_upload_tag,
            this.mnu_forecast,
            this.toolStripSeparator3,
            this.mnu_multi,
            this.toolStripSeparator4,
            this.mnu_pattern,
            this.toolStripSeparator5,
            this.mnu_retry});
            this.ctm_Menu.Name = "ctm_Menu";
            this.ctm_Menu.Size = new System.Drawing.Size(219, 370);
            // 
            // mnu_insert
            // 
            this.mnu_insert.Name = "mnu_insert";
            this.mnu_insert.Size = new System.Drawing.Size(218, 22);
            this.mnu_insert.Text = "Insert Record";
            this.mnu_insert.Click += new System.EventHandler(this.mnu_insert_Click);
            // 
            // mnu_copy_record
            // 
            this.mnu_copy_record.Name = "mnu_copy_record";
            this.mnu_copy_record.Size = new System.Drawing.Size(218, 22);
            this.mnu_copy_record.Text = "Copy Record";
            this.mnu_copy_record.Visible = false;
            // 
            // mnu_delete
            // 
            this.mnu_delete.Name = "mnu_delete";
            this.mnu_delete.Size = new System.Drawing.Size(218, 22);
            this.mnu_delete.Text = "Delete Record";
            this.mnu_delete.Click += new System.EventHandler(this.mnu_delete_Click);
            // 
            // mnu_sp1
            // 
            this.mnu_sp1.Name = "mnu_sp1";
            this.mnu_sp1.Size = new System.Drawing.Size(215, 6);
            // 
            // mnu_request
            // 
            this.mnu_request.Name = "mnu_request";
            this.mnu_request.Size = new System.Drawing.Size(218, 22);
            this.mnu_request.Text = "Request Record";
            this.mnu_request.Click += new System.EventHandler(this.mnu_request_Click);
            // 
            // mnu_release
            // 
            this.mnu_release.Name = "mnu_release";
            this.mnu_release.Size = new System.Drawing.Size(218, 22);
            this.mnu_release.Text = "Release Record";
            this.mnu_release.Click += new System.EventHandler(this.mnu_release_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // mnu_upload
            // 
            this.mnu_upload.Name = "mnu_upload";
            this.mnu_upload.Size = new System.Drawing.Size(218, 22);
            this.mnu_upload.Text = "Upload Excel";
            this.mnu_upload.Click += new System.EventHandler(this.mnu_upload_Click);
            // 
            // mnu_download
            // 
            this.mnu_download.Name = "mnu_download";
            this.mnu_download.Size = new System.Drawing.Size(218, 22);
            this.mnu_download.Text = "Download Excel";
            this.mnu_download.Click += new System.EventHandler(this.mnu_download_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // mnu_edit
            // 
            this.mnu_edit.Name = "mnu_edit";
            this.mnu_edit.Size = new System.Drawing.Size(218, 22);
            this.mnu_edit.Text = "Edit Excel";
            this.mnu_edit.Click += new System.EventHandler(this.mnu_edit_Click);
            // 
            // mnu_copy
            // 
            this.mnu_copy.Name = "mnu_copy";
            this.mnu_copy.Size = new System.Drawing.Size(218, 22);
            this.mnu_copy.Text = "Copy Excel";
            this.mnu_copy.Click += new System.EventHandler(this.mnu_copy_Click);
            // 
            // mnu_paste
            // 
            this.mnu_paste.Name = "mnu_paste";
            this.mnu_paste.Size = new System.Drawing.Size(218, 22);
            this.mnu_paste.Text = "Paste Excel";
            this.mnu_paste.Click += new System.EventHandler(this.mnu_paste_Click);
            // 
            // mnu_upload_tag
            // 
            this.mnu_upload_tag.Name = "mnu_upload_tag";
            this.mnu_upload_tag.Size = new System.Drawing.Size(218, 22);
            this.mnu_upload_tag.Text = "Upload Tag Label";
            this.mnu_upload_tag.Click += new System.EventHandler(this.mnu_upload_tag_Click);
            // 
            // mnu_forecast
            // 
            this.mnu_forecast.Name = "mnu_forecast";
            this.mnu_forecast.Size = new System.Drawing.Size(218, 22);
            this.mnu_forecast.Text = "Forecast Mat. Stock for Model";
            this.mnu_forecast.Click += new System.EventHandler(this.mnu_forecast_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            this.toolStripSeparator3.Visible = false;
            // 
            // mnu_multi
            // 
            this.mnu_multi.Name = "mnu_multi";
            this.mnu_multi.Size = new System.Drawing.Size(218, 22);
            this.mnu_multi.Text = "Specification Multi Change";
            this.mnu_multi.Visible = false;
            this.mnu_multi.Click += new System.EventHandler(this.mnu_multi_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(215, 6);
            this.toolStripSeparator4.Visible = false;
            // 
            // mnu_pattern
            // 
            this.mnu_pattern.Name = "mnu_pattern";
            this.mnu_pattern.Size = new System.Drawing.Size(218, 22);
            this.mnu_pattern.Text = "Pattern/Mold for SMS";
            this.mnu_pattern.Visible = false;
            this.mnu_pattern.Click += new System.EventHandler(this.mnu_pattern_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(215, 6);
            // 
            // mnu_retry
            // 
            this.mnu_retry.Name = "mnu_retry";
            this.mnu_retry.Size = new System.Drawing.Size(218, 22);
            this.mnu_retry.Text = "Retry Worksheet";
            this.mnu_retry.Click += new System.EventHandler(this.mnu_retry_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.Controls.Add(this.pnl_Body);
            this.pnl_main.Controls.Add(this.pnl_head);
            this.pnl_main.Location = new System.Drawing.Point(0, 48);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1013, 590);
            this.pnl_main.TabIndex = 30;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Controls.Add(this.pnl_tab_process_upper);
            this.pnl_Body.Controls.Add(this.pnl_info);
            this.pnl_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Body.Location = new System.Drawing.Point(0, 149);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.pnl_Body.Size = new System.Drawing.Size(1013, 441);
            this.pnl_Body.TabIndex = 394;
            // 
            // pnl_tab_process_upper
            // 
            this.pnl_tab_process_upper.Controls.Add(this.grb_op);
            this.pnl_tab_process_upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_tab_process_upper.Location = new System.Drawing.Point(4, 366);
            this.pnl_tab_process_upper.Name = "pnl_tab_process_upper";
            this.pnl_tab_process_upper.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnl_tab_process_upper.Size = new System.Drawing.Size(1005, 62);
            this.pnl_tab_process_upper.TabIndex = 19;
            // 
            // grb_op
            // 
            this.grb_op.Controls.Add(this.lbl_fga);
            this.grb_op.Controls.Add(this.lbl_fss);
            this.grb_op.Controls.Add(this.lbl_ups);
            this.grb_op.Controls.Add(this.lbl_emb);
            this.grb_op.Controls.Add(this.lbl_abs);
            this.grb_op.Controls.Add(this.lbl_ems);
            this.grb_op.Controls.Add(this.lbl_pr);
            this.grb_op.Controls.Add(this.lbl_ip);
            this.grb_op.Controls.Add(this.lbl_pu);
            this.grb_op.Controls.Add(this.lbl_ph);
            this.grb_op.Controls.Add(this.lbl_cutting);
            this.grb_op.Controls.Add(this.txt_fga);
            this.grb_op.Controls.Add(this.chk_fga);
            this.grb_op.Controls.Add(this.txt_fss);
            this.grb_op.Controls.Add(this.chk_fss);
            this.grb_op.Controls.Add(this.txt_ups);
            this.grb_op.Controls.Add(this.chk_ups);
            this.grb_op.Controls.Add(this.txt_ems);
            this.grb_op.Controls.Add(this.chk_ems);
            this.grb_op.Controls.Add(this.txt_abs);
            this.grb_op.Controls.Add(this.chk_abs);
            this.grb_op.Controls.Add(this.txt_upe);
            this.grb_op.Controls.Add(this.chk_upe);
            this.grb_op.Controls.Add(this.txt_os);
            this.grb_op.Controls.Add(this.chk_os);
            this.grb_op.Controls.Add(this.txt_ip);
            this.grb_op.Controls.Add(this.chk_ip);
            this.grb_op.Controls.Add(this.txt_pu);
            this.grb_op.Controls.Add(this.chk_pu);
            this.grb_op.Controls.Add(this.txt_ph);
            this.grb_op.Controls.Add(this.chk_ph);
            this.grb_op.Controls.Add(this.txt_cutting);
            this.grb_op.Controls.Add(this.chk_cutting);
            this.grb_op.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_op.Location = new System.Drawing.Point(4, 0);
            this.grb_op.Name = "grb_op";
            this.grb_op.Size = new System.Drawing.Size(997, 62);
            this.grb_op.TabIndex = 0;
            this.grb_op.TabStop = false;
            this.grb_op.Text = "Process";
            // 
            // lbl_fga
            // 
            this.lbl_fga.BackColor = System.Drawing.Color.Beige;
            this.lbl_fga.Location = new System.Drawing.Point(893, 18);
            this.lbl_fga.Name = "lbl_fga";
            this.lbl_fga.Size = new System.Drawing.Size(81, 16);
            this.lbl_fga.TabIndex = 2040;
            this.lbl_fga.Text = "Assembly";
            this.lbl_fga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fss
            // 
            this.lbl_fss.BackColor = System.Drawing.Color.Beige;
            this.lbl_fss.Location = new System.Drawing.Point(806, 18);
            this.lbl_fss.Name = "lbl_fss";
            this.lbl_fss.Size = new System.Drawing.Size(78, 16);
            this.lbl_fss.TabIndex = 2039;
            this.lbl_fss.Text = "Stockfit";
            this.lbl_fss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ups
            // 
            this.lbl_ups.BackColor = System.Drawing.Color.Beige;
            this.lbl_ups.Location = new System.Drawing.Point(719, 18);
            this.lbl_ups.Name = "lbl_ups";
            this.lbl_ups.Size = new System.Drawing.Size(78, 16);
            this.lbl_ups.TabIndex = 2038;
            this.lbl_ups.Text = "Stitching";
            this.lbl_ups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_emb
            // 
            this.lbl_emb.BackColor = System.Drawing.Color.Beige;
            this.lbl_emb.Location = new System.Drawing.Point(630, 18);
            this.lbl_emb.Name = "lbl_emb";
            this.lbl_emb.Size = new System.Drawing.Size(78, 16);
            this.lbl_emb.TabIndex = 2037;
            this.lbl_emb.Text = "H/P";
            this.lbl_emb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_abs
            // 
            this.lbl_abs.BackColor = System.Drawing.Color.Beige;
            this.lbl_abs.Location = new System.Drawing.Point(541, 18);
            this.lbl_abs.Name = "lbl_abs";
            this.lbl_abs.Size = new System.Drawing.Size(78, 16);
            this.lbl_abs.TabIndex = 2036;
            this.lbl_abs.Text = "H/F";
            this.lbl_abs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ems
            // 
            this.lbl_ems.BackColor = System.Drawing.Color.Beige;
            this.lbl_ems.Location = new System.Drawing.Point(452, 18);
            this.lbl_ems.Name = "lbl_ems";
            this.lbl_ems.Size = new System.Drawing.Size(78, 16);
            this.lbl_ems.TabIndex = 2035;
            this.lbl_ems.Text = "Embroidery";
            this.lbl_ems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pr
            // 
            this.lbl_pr.BackColor = System.Drawing.Color.Beige;
            this.lbl_pr.Location = new System.Drawing.Point(363, 18);
            this.lbl_pr.Name = "lbl_pr";
            this.lbl_pr.Size = new System.Drawing.Size(78, 16);
            this.lbl_pr.TabIndex = 2034;
            this.lbl_pr.Text = "OS";
            this.lbl_pr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ip
            // 
            this.lbl_ip.BackColor = System.Drawing.Color.Beige;
            this.lbl_ip.Location = new System.Drawing.Point(274, 18);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(78, 16);
            this.lbl_ip.TabIndex = 2033;
            this.lbl_ip.Text = "IP";
            this.lbl_ip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pu
            // 
            this.lbl_pu.BackColor = System.Drawing.Color.Beige;
            this.lbl_pu.Location = new System.Drawing.Point(185, 18);
            this.lbl_pu.Name = "lbl_pu";
            this.lbl_pu.Size = new System.Drawing.Size(78, 16);
            this.lbl_pu.TabIndex = 2032;
            this.lbl_pu.Text = "PU";
            this.lbl_pu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ph
            // 
            this.lbl_ph.BackColor = System.Drawing.Color.Beige;
            this.lbl_ph.Location = new System.Drawing.Point(96, 18);
            this.lbl_ph.Name = "lbl_ph";
            this.lbl_ph.Size = new System.Drawing.Size(78, 16);
            this.lbl_ph.TabIndex = 2031;
            this.lbl_ph.Text = "PH";
            this.lbl_ph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cutting
            // 
            this.lbl_cutting.BackColor = System.Drawing.Color.Beige;
            this.lbl_cutting.Location = new System.Drawing.Point(7, 18);
            this.lbl_cutting.Name = "lbl_cutting";
            this.lbl_cutting.Size = new System.Drawing.Size(78, 16);
            this.lbl_cutting.TabIndex = 2030;
            this.lbl_cutting.Text = "Cutting";
            this.lbl_cutting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_fga
            // 
            this.txt_fga.Location = new System.Drawing.Point(911, 36);
            this.txt_fga.Name = "txt_fga";
            this.txt_fga.Size = new System.Drawing.Size(63, 22);
            this.txt_fga.TabIndex = 2029;
            this.txt_fga.TextChanged += new System.EventHandler(this.txt_fga_TextChanged);
            // 
            // chk_fga
            // 
            this.chk_fga.AutoSize = true;
            this.chk_fga.Location = new System.Drawing.Point(894, 37);
            this.chk_fga.Name = "chk_fga";
            this.chk_fga.Size = new System.Drawing.Size(15, 14);
            this.chk_fga.TabIndex = 2028;
            this.chk_fga.UseVisualStyleBackColor = true;
            this.chk_fga.CheckedChanged += new System.EventHandler(this.chk_fga_CheckedChanged);
            // 
            // txt_fss
            // 
            this.txt_fss.Location = new System.Drawing.Point(822, 36);
            this.txt_fss.Name = "txt_fss";
            this.txt_fss.Size = new System.Drawing.Size(63, 22);
            this.txt_fss.TabIndex = 2027;
            this.txt_fss.TextChanged += new System.EventHandler(this.txt_fss_TextChanged);
            // 
            // chk_fss
            // 
            this.chk_fss.AutoSize = true;
            this.chk_fss.Location = new System.Drawing.Point(806, 37);
            this.chk_fss.Name = "chk_fss";
            this.chk_fss.Size = new System.Drawing.Size(15, 14);
            this.chk_fss.TabIndex = 2026;
            this.chk_fss.UseVisualStyleBackColor = true;
            this.chk_fss.CheckedChanged += new System.EventHandler(this.chk_fss_CheckedChanged);
            // 
            // txt_ups
            // 
            this.txt_ups.Location = new System.Drawing.Point(735, 37);
            this.txt_ups.Name = "txt_ups";
            this.txt_ups.Size = new System.Drawing.Size(63, 22);
            this.txt_ups.TabIndex = 2024;
            this.txt_ups.TextChanged += new System.EventHandler(this.txt_ups_TextChanged);
            // 
            // chk_ups
            // 
            this.chk_ups.AutoSize = true;
            this.chk_ups.Location = new System.Drawing.Point(719, 38);
            this.chk_ups.Name = "chk_ups";
            this.chk_ups.Size = new System.Drawing.Size(15, 14);
            this.chk_ups.TabIndex = 2023;
            this.chk_ups.UseVisualStyleBackColor = true;
            this.chk_ups.CheckedChanged += new System.EventHandler(this.chk_ups_CheckedChanged);
            // 
            // txt_ems
            // 
            this.txt_ems.Location = new System.Drawing.Point(646, 37);
            this.txt_ems.Name = "txt_ems";
            this.txt_ems.Size = new System.Drawing.Size(63, 22);
            this.txt_ems.TabIndex = 2021;
            this.txt_ems.TextChanged += new System.EventHandler(this.txt_ems_TextChanged);
            // 
            // chk_ems
            // 
            this.chk_ems.AutoSize = true;
            this.chk_ems.Location = new System.Drawing.Point(630, 38);
            this.chk_ems.Name = "chk_ems";
            this.chk_ems.Size = new System.Drawing.Size(15, 14);
            this.chk_ems.TabIndex = 2020;
            this.chk_ems.UseVisualStyleBackColor = true;
            this.chk_ems.CheckedChanged += new System.EventHandler(this.chk_ems_CheckedChanged);
            // 
            // txt_abs
            // 
            this.txt_abs.Location = new System.Drawing.Point(557, 37);
            this.txt_abs.Name = "txt_abs";
            this.txt_abs.Size = new System.Drawing.Size(63, 22);
            this.txt_abs.TabIndex = 2018;
            this.txt_abs.TextChanged += new System.EventHandler(this.txt_abs_TextChanged);
            // 
            // chk_abs
            // 
            this.chk_abs.AutoSize = true;
            this.chk_abs.Location = new System.Drawing.Point(541, 38);
            this.chk_abs.Name = "chk_abs";
            this.chk_abs.Size = new System.Drawing.Size(15, 14);
            this.chk_abs.TabIndex = 2017;
            this.chk_abs.UseVisualStyleBackColor = true;
            this.chk_abs.CheckedChanged += new System.EventHandler(this.chk_abs_CheckedChanged);
            // 
            // txt_upe
            // 
            this.txt_upe.Location = new System.Drawing.Point(468, 37);
            this.txt_upe.Name = "txt_upe";
            this.txt_upe.Size = new System.Drawing.Size(63, 22);
            this.txt_upe.TabIndex = 2015;
            this.txt_upe.TextChanged += new System.EventHandler(this.txt_upe_TextChanged);
            // 
            // chk_upe
            // 
            this.chk_upe.AutoSize = true;
            this.chk_upe.Location = new System.Drawing.Point(452, 38);
            this.chk_upe.Name = "chk_upe";
            this.chk_upe.Size = new System.Drawing.Size(15, 14);
            this.chk_upe.TabIndex = 2014;
            this.chk_upe.UseVisualStyleBackColor = true;
            this.chk_upe.CheckedChanged += new System.EventHandler(this.chk_upe_CheckedChanged);
            // 
            // txt_os
            // 
            this.txt_os.Location = new System.Drawing.Point(379, 37);
            this.txt_os.Name = "txt_os";
            this.txt_os.Size = new System.Drawing.Size(63, 22);
            this.txt_os.TabIndex = 2012;
            this.txt_os.TextChanged += new System.EventHandler(this.txt_os_TextChanged);
            // 
            // chk_os
            // 
            this.chk_os.AutoSize = true;
            this.chk_os.Location = new System.Drawing.Point(363, 38);
            this.chk_os.Name = "chk_os";
            this.chk_os.Size = new System.Drawing.Size(15, 14);
            this.chk_os.TabIndex = 2011;
            this.chk_os.UseVisualStyleBackColor = true;
            this.chk_os.CheckedChanged += new System.EventHandler(this.chk_os_CheckedChanged);
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(290, 37);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(63, 22);
            this.txt_ip.TabIndex = 2009;
            this.txt_ip.TextChanged += new System.EventHandler(this.txt_ip_TextChanged);
            // 
            // chk_ip
            // 
            this.chk_ip.AutoSize = true;
            this.chk_ip.Location = new System.Drawing.Point(274, 38);
            this.chk_ip.Name = "chk_ip";
            this.chk_ip.Size = new System.Drawing.Size(15, 14);
            this.chk_ip.TabIndex = 2008;
            this.chk_ip.UseVisualStyleBackColor = true;
            this.chk_ip.CheckedChanged += new System.EventHandler(this.chk_ip_CheckedChanged);
            // 
            // txt_pu
            // 
            this.txt_pu.Location = new System.Drawing.Point(202, 37);
            this.txt_pu.Name = "txt_pu";
            this.txt_pu.Size = new System.Drawing.Size(63, 22);
            this.txt_pu.TabIndex = 2006;
            this.txt_pu.TextChanged += new System.EventHandler(this.txt_pu_TextChanged);
            // 
            // chk_pu
            // 
            this.chk_pu.AutoSize = true;
            this.chk_pu.Location = new System.Drawing.Point(186, 38);
            this.chk_pu.Name = "chk_pu";
            this.chk_pu.Size = new System.Drawing.Size(15, 14);
            this.chk_pu.TabIndex = 2005;
            this.chk_pu.UseVisualStyleBackColor = true;
            this.chk_pu.CheckedChanged += new System.EventHandler(this.chk_pu_CheckedChanged);
            // 
            // txt_ph
            // 
            this.txt_ph.Location = new System.Drawing.Point(111, 37);
            this.txt_ph.Name = "txt_ph";
            this.txt_ph.Size = new System.Drawing.Size(63, 22);
            this.txt_ph.TabIndex = 2003;
            this.txt_ph.TextChanged += new System.EventHandler(this.txt_ph_TextChanged);
            // 
            // chk_ph
            // 
            this.chk_ph.AutoSize = true;
            this.chk_ph.Location = new System.Drawing.Point(95, 38);
            this.chk_ph.Name = "chk_ph";
            this.chk_ph.Size = new System.Drawing.Size(15, 14);
            this.chk_ph.TabIndex = 2002;
            this.chk_ph.UseVisualStyleBackColor = true;
            this.chk_ph.CheckedChanged += new System.EventHandler(this.chk_ph_CheckedChanged);
            // 
            // txt_cutting
            // 
            this.txt_cutting.Location = new System.Drawing.Point(23, 37);
            this.txt_cutting.Name = "txt_cutting";
            this.txt_cutting.Size = new System.Drawing.Size(62, 22);
            this.txt_cutting.TabIndex = 1;
            this.txt_cutting.TextChanged += new System.EventHandler(this.txt_cutting_TextChanged);
            // 
            // chk_cutting
            // 
            this.chk_cutting.AutoSize = true;
            this.chk_cutting.Location = new System.Drawing.Point(7, 38);
            this.chk_cutting.Name = "chk_cutting";
            this.chk_cutting.Size = new System.Drawing.Size(15, 14);
            this.chk_cutting.TabIndex = 0;
            this.chk_cutting.UseVisualStyleBackColor = true;
            this.chk_cutting.CheckedChanged += new System.EventHandler(this.chk_cutting_CheckedChanged);
            // 
            // pnl_info
            // 
            this.pnl_info.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_info.Controls.Add(this.pnl_SearchImage);
            this.pnl_info.Controls.Add(this.panel5);
            this.pnl_info.Controls.Add(this.panel4);
            this.pnl_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_info.Location = new System.Drawing.Point(4, 4);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnl_info.Size = new System.Drawing.Size(1005, 362);
            this.pnl_info.TabIndex = 547;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.btn_sms_chem);
            this.pnl_SearchImage.Controls.Add(this.cmb_sms_chem);
            this.pnl_SearchImage.Controls.Add(this.lbl_sms_chem);
            this.pnl_SearchImage.Controls.Add(this.btn_sms_dev);
            this.pnl_SearchImage.Controls.Add(this.lbl_sms_mold);
            this.pnl_SearchImage.Controls.Add(this.lbl_sms_dev);
            this.pnl_SearchImage.Controls.Add(this.btn_sms_mold);
            this.pnl_SearchImage.Controls.Add(this.cmb_t_d);
            this.pnl_SearchImage.Controls.Add(this.chk_pcc_dd);
            this.pnl_SearchImage.Controls.Add(this.cmb_sms_mold);
            this.pnl_SearchImage.Controls.Add(this.cmb_sms_dev);
            this.pnl_SearchImage.Controls.Add(this.txt_mat_ymd);
            this.pnl_SearchImage.Controls.Add(this.lbl_mat_ymd);
            this.pnl_SearchImage.Controls.Add(this.lbl_tag_cmt);
            this.pnl_SearchImage.Controls.Add(this.txt_tag_cmt);
            this.pnl_SearchImage.Controls.Add(this.cmb_season_s);
            this.pnl_SearchImage.Controls.Add(this.lbl_dev_prod);
            this.pnl_SearchImage.Controls.Add(this.cmb_round);
            this.pnl_SearchImage.Controls.Add(this.dtp_ipw);
            this.pnl_SearchImage.Controls.Add(this.dtp_ets);
            this.pnl_SearchImage.Controls.Add(this.cmb_p_bom);
            this.pnl_SearchImage.Controls.Add(this.lbl_fit);
            this.pnl_SearchImage.Controls.Add(this.txt_fit);
            this.pnl_SearchImage.Controls.Add(this.txt_barcode_date);
            this.pnl_SearchImage.Controls.Add(this.txt_fag_qty);
            this.pnl_SearchImage.Controls.Add(this.label5);
            this.pnl_SearchImage.Controls.Add(this.txt_width);
            this.pnl_SearchImage.Controls.Add(this.label7);
            this.pnl_SearchImage.Controls.Add(this.txt_dispatch_qty);
            this.pnl_SearchImage.Controls.Add(this.lbl_IDS_length);
            this.pnl_SearchImage.Controls.Add(this.label9);
            this.pnl_SearchImage.Controls.Add(this.txt_ids_length);
            this.pnl_SearchImage.Controls.Add(this.label11);
            this.pnl_SearchImage.Controls.Add(this.txt_medial_height);
            this.pnl_SearchImage.Controls.Add(this.label16);
            this.pnl_SearchImage.Controls.Add(this.txt_nike_dev);
            this.pnl_SearchImage.Controls.Add(this.lbl_req_date);
            this.pnl_SearchImage.Controls.Add(this.txt_cdc_dev);
            this.pnl_SearchImage.Controls.Add(this.txt_whq_dev);
            this.pnl_SearchImage.Controls.Add(this.dtp_dispatch_date);
            this.pnl_SearchImage.Controls.Add(this.cmb_gender);
            this.pnl_SearchImage.Controls.Add(this.dtp_request_date);
            this.pnl_SearchImage.Controls.Add(this.txt_sample_weight);
            this.pnl_SearchImage.Controls.Add(this.lbl_style_cd);
            this.pnl_SearchImage.Controls.Add(this.txt_style_cd);
            this.pnl_SearchImage.Controls.Add(this.lbl_medial_height);
            this.pnl_SearchImage.Controls.Add(this.txt_midsole_hardness);
            this.pnl_SearchImage.Controls.Add(this.txt_mto_acc);
            this.pnl_SearchImage.Controls.Add(this.lbl_mto_acc);
            this.pnl_SearchImage.Controls.Add(this.txt_lace_length);
            this.pnl_SearchImage.Controls.Add(this.txt_size);
            this.pnl_SearchImage.Controls.Add(this.lbl_barcodekey);
            this.pnl_SearchImage.Controls.Add(this.txt_laterial_height);
            this.pnl_SearchImage.Controls.Add(this.txt_insole);
            this.pnl_SearchImage.Controls.Add(this.lbl_midsole_hardness);
            this.pnl_SearchImage.Controls.Add(this.txt_heel_height);
            this.pnl_SearchImage.Controls.Add(this.txt_upper_mat);
            this.pnl_SearchImage.Controls.Add(this.lbl_lace_length);
            this.pnl_SearchImage.Controls.Add(this.txt_collar_height);
            this.pnl_SearchImage.Controls.Add(this.lbl_lateral_height);
            this.pnl_SearchImage.Controls.Add(this.txt_srno);
            this.pnl_SearchImage.Controls.Add(this.txt_stl_file);
            this.pnl_SearchImage.Controls.Add(this.lbl_srno);
            this.pnl_SearchImage.Controls.Add(this.lbl_seasonyear);
            this.pnl_SearchImage.Controls.Add(this.txt_barcode);
            this.pnl_SearchImage.Controls.Add(this.lbl_sample_weigt);
            this.pnl_SearchImage.Controls.Add(this.lbl_size);
            this.pnl_SearchImage.Controls.Add(this.lbl_whq_dev);
            this.pnl_SearchImage.Controls.Add(this.txt_bom_id);
            this.pnl_SearchImage.Controls.Add(this.lbl_heel_height);
            this.pnl_SearchImage.Controls.Add(this.lbl_insole);
            this.pnl_SearchImage.Controls.Add(this.lbl_shoe_lace);
            this.pnl_SearchImage.Controls.Add(this.lbl_bomid);
            this.pnl_SearchImage.Controls.Add(this.lbl_width);
            this.pnl_SearchImage.Controls.Add(this.lbl_collar_height);
            this.pnl_SearchImage.Controls.Add(this.lbl_t_d);
            this.pnl_SearchImage.Controls.Add(this.lbl_current_fob);
            this.pnl_SearchImage.Controls.Add(this.lbl_retail_price);
            this.pnl_SearchImage.Controls.Add(this.lbl_barcode);
            this.pnl_SearchImage.Controls.Add(this.lbl_stl_file);
            this.pnl_SearchImage.Controls.Add(this.lbl_ipw_ymd);
            this.pnl_SearchImage.Controls.Add(this.txt_retail_price);
            this.pnl_SearchImage.Controls.Add(this.txt_current_fob);
            this.pnl_SearchImage.Controls.Add(this.txt_colors);
            this.pnl_SearchImage.Controls.Add(this.lbl_colors);
            this.pnl_SearchImage.Controls.Add(this.txt_lastcd);
            this.pnl_SearchImage.Controls.Add(this.txt_pattern);
            this.pnl_SearchImage.Controls.Add(this.txt_solelaying_method);
            this.pnl_SearchImage.Controls.Add(this.lbl_p_bom);
            this.pnl_SearchImage.Controls.Add(this.lbl_lastcd);
            this.pnl_SearchImage.Controls.Add(this.txt_midsole_method);
            this.pnl_SearchImage.Controls.Add(this.lbl_pattern);
            this.pnl_SearchImage.Controls.Add(this.txt_lasting_method);
            this.pnl_SearchImage.Controls.Add(this.lbl_solelaying_method);
            this.pnl_SearchImage.Controls.Add(this.lbl_sampletype);
            this.pnl_SearchImage.Controls.Add(this.lbl_ms_method);
            this.pnl_SearchImage.Controls.Add(this.txt_srfno);
            this.pnl_SearchImage.Controls.Add(this.lbl_last);
            this.pnl_SearchImage.Controls.Add(this.lbl_srfno);
            this.pnl_SearchImage.Controls.Add(this.lbl_gender);
            this.pnl_SearchImage.Controls.Add(this.txt_modelname);
            this.pnl_SearchImage.Controls.Add(this.lbl_modelname);
            this.pnl_SearchImage.Controls.Add(this.lbl_rts);
            this.pnl_SearchImage.Controls.Add(this.txt_dev_prod);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.txt_lace_desc);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox3);
            this.pnl_SearchImage.Controls.Add(this.lbl_upper_mat);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.cmb_category);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.lbl_category);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(4, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(997, 362);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // btn_sms_dev
            // 
            this.btn_sms_dev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_sms_dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_sms_dev.Image = ((System.Drawing.Image)(resources.GetObject("btn_sms_dev.Image")));
            this.btn_sms_dev.Location = new System.Drawing.Point(714, 314);
            this.btn_sms_dev.Name = "btn_sms_dev";
            this.btn_sms_dev.Size = new System.Drawing.Size(22, 22);
            this.btn_sms_dev.TabIndex = 2052;
            this.btn_sms_dev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sms_dev.Click += new System.EventHandler(this.btn_sms_dev_Click);
            // 
            // lbl_sms_mold
            // 
            this.lbl_sms_mold.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sms_mold.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sms_mold.ImageIndex = 0;
            this.lbl_sms_mold.ImageList = this.img_Label;
            this.lbl_sms_mold.Location = new System.Drawing.Point(754, 314);
            this.lbl_sms_mold.Name = "lbl_sms_mold";
            this.lbl_sms_mold.Size = new System.Drawing.Size(100, 21);
            this.lbl_sms_mold.TabIndex = 2049;
            this.lbl_sms_mold.Tag = "21";
            this.lbl_sms_mold.Text = "TE for SMS";
            this.lbl_sms_mold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sms_dev
            // 
            this.lbl_sms_dev.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sms_dev.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sms_dev.ImageIndex = 0;
            this.lbl_sms_dev.ImageList = this.img_Label;
            this.lbl_sms_dev.Location = new System.Drawing.Point(515, 314);
            this.lbl_sms_dev.Name = "lbl_sms_dev";
            this.lbl_sms_dev.Size = new System.Drawing.Size(100, 21);
            this.lbl_sms_dev.TabIndex = 2048;
            this.lbl_sms_dev.Tag = "21";
            this.lbl_sms_dev.Text = "PE. for SMS";
            this.lbl_sms_dev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_sms_mold
            // 
            this.btn_sms_mold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_sms_mold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_sms_mold.Image = ((System.Drawing.Image)(resources.GetObject("btn_sms_mold.Image")));
            this.btn_sms_mold.Location = new System.Drawing.Point(953, 314);
            this.btn_sms_mold.Name = "btn_sms_mold";
            this.btn_sms_mold.Size = new System.Drawing.Size(22, 22);
            this.btn_sms_mold.TabIndex = 2045;
            this.btn_sms_mold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sms_mold.Click += new System.EventHandler(this.btn_sms_mold_Click);
            // 
            // cmb_t_d
            // 
            this.cmb_t_d.AddItemSeparator = ';';
            this.cmb_t_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_t_d.Caption = "";
            this.cmb_t_d.CaptionHeight = 17;
            this.cmb_t_d.CaptionStyle = style121;
            this.cmb_t_d.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_t_d.ColumnCaptionHeight = 18;
            this.cmb_t_d.ColumnFooterHeight = 18;
            this.cmb_t_d.ContentHeight = 17;
            this.cmb_t_d.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_t_d.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_t_d.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_t_d.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_t_d.EditorHeight = 17;
            this.cmb_t_d.EvenRowStyle = style122;
            this.cmb_t_d.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_t_d.FooterStyle = style123;
            this.cmb_t_d.HeadingStyle = style124;
            this.cmb_t_d.HighLightRowStyle = style125;
            this.cmb_t_d.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_t_d.Images"))));
            this.cmb_t_d.ItemHeight = 15;
            this.cmb_t_d.Location = new System.Drawing.Point(616, 292);
            this.cmb_t_d.MatchEntryTimeout = ((long)(2000));
            this.cmb_t_d.MaxDropDownItems = ((short)(5));
            this.cmb_t_d.MaxLength = 32767;
            this.cmb_t_d.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_t_d.Name = "cmb_t_d";
            this.cmb_t_d.OddRowStyle = style126;
            this.cmb_t_d.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_t_d.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_t_d.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_t_d.SelectedStyle = style127;
            this.cmb_t_d.Size = new System.Drawing.Size(120, 21);
            this.cmb_t_d.Style = style128;
            this.cmb_t_d.TabIndex = 2043;
            this.cmb_t_d.SelectedValueChanged += new System.EventHandler(this.cmb_t_d_SelectedValueChanged);
            this.cmb_t_d.PropBag = resources.GetString("cmb_t_d.PropBag");
            // 
            // chk_pcc_dd
            // 
            this.chk_pcc_dd.AutoSize = true;
            this.chk_pcc_dd.Location = new System.Drawing.Point(396, 294);
            this.chk_pcc_dd.Name = "chk_pcc_dd";
            this.chk_pcc_dd.Size = new System.Drawing.Size(74, 18);
            this.chk_pcc_dd.TabIndex = 2041;
            this.chk_pcc_dd.Text = "PCC DD";
            this.chk_pcc_dd.UseVisualStyleBackColor = true;
            this.chk_pcc_dd.CheckedChanged += new System.EventHandler(this.chk_pcc_dd_CheckedChanged);
            // 
            // cmb_sms_mold
            // 
            this.cmb_sms_mold.AddItemSeparator = ';';
            this.cmb_sms_mold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sms_mold.Caption = "";
            this.cmb_sms_mold.CaptionHeight = 17;
            this.cmb_sms_mold.CaptionStyle = style129;
            this.cmb_sms_mold.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_sms_mold.ColumnCaptionHeight = 18;
            this.cmb_sms_mold.ColumnFooterHeight = 18;
            this.cmb_sms_mold.ContentHeight = 17;
            this.cmb_sms_mold.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_sms_mold.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_sms_mold.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sms_mold.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sms_mold.EditorHeight = 17;
            this.cmb_sms_mold.EvenRowStyle = style130;
            this.cmb_sms_mold.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sms_mold.FooterStyle = style131;
            this.cmb_sms_mold.HeadingStyle = style132;
            this.cmb_sms_mold.HighLightRowStyle = style133;
            this.cmb_sms_mold.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_sms_mold.Images"))));
            this.cmb_sms_mold.ItemHeight = 15;
            this.cmb_sms_mold.Location = new System.Drawing.Point(855, 315);
            this.cmb_sms_mold.MatchEntryTimeout = ((long)(2000));
            this.cmb_sms_mold.MaxDropDownItems = ((short)(5));
            this.cmb_sms_mold.MaxLength = 32767;
            this.cmb_sms_mold.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sms_mold.Name = "cmb_sms_mold";
            this.cmb_sms_mold.OddRowStyle = style134;
            this.cmb_sms_mold.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sms_mold.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sms_mold.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sms_mold.SelectedStyle = style135;
            this.cmb_sms_mold.Size = new System.Drawing.Size(97, 21);
            this.cmb_sms_mold.Style = style136;
            this.cmb_sms_mold.TabIndex = 2041;
            this.cmb_sms_mold.PropBag = resources.GetString("cmb_sms_mold.PropBag");
            // 
            // cmb_sms_dev
            // 
            this.cmb_sms_dev.AddItemSeparator = ';';
            this.cmb_sms_dev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sms_dev.Caption = "";
            this.cmb_sms_dev.CaptionHeight = 17;
            this.cmb_sms_dev.CaptionStyle = style137;
            this.cmb_sms_dev.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_sms_dev.ColumnCaptionHeight = 18;
            this.cmb_sms_dev.ColumnFooterHeight = 18;
            this.cmb_sms_dev.ContentHeight = 17;
            this.cmb_sms_dev.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_sms_dev.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_sms_dev.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sms_dev.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sms_dev.EditorHeight = 17;
            this.cmb_sms_dev.EvenRowStyle = style138;
            this.cmb_sms_dev.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sms_dev.FooterStyle = style139;
            this.cmb_sms_dev.HeadingStyle = style140;
            this.cmb_sms_dev.HighLightRowStyle = style141;
            this.cmb_sms_dev.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_sms_dev.Images"))));
            this.cmb_sms_dev.ItemHeight = 15;
            this.cmb_sms_dev.Location = new System.Drawing.Point(616, 314);
            this.cmb_sms_dev.MatchEntryTimeout = ((long)(2000));
            this.cmb_sms_dev.MaxDropDownItems = ((short)(5));
            this.cmb_sms_dev.MaxLength = 32767;
            this.cmb_sms_dev.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sms_dev.Name = "cmb_sms_dev";
            this.cmb_sms_dev.OddRowStyle = style142;
            this.cmb_sms_dev.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sms_dev.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sms_dev.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sms_dev.SelectedStyle = style143;
            this.cmb_sms_dev.Size = new System.Drawing.Size(97, 21);
            this.cmb_sms_dev.Style = style144;
            this.cmb_sms_dev.TabIndex = 2011;
            this.cmb_sms_dev.PropBag = resources.GetString("cmb_sms_dev.PropBag");
            // 
            // txt_mat_ymd
            // 
            this.txt_mat_ymd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_mat_ymd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mat_ymd.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_mat_ymd.ForeColor = System.Drawing.Color.Black;
            this.txt_mat_ymd.Location = new System.Drawing.Point(107, 336);
            this.txt_mat_ymd.MaxLength = 8;
            this.txt_mat_ymd.Name = "txt_mat_ymd";
            this.txt_mat_ymd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_mat_ymd.Size = new System.Drawing.Size(120, 20);
            this.txt_mat_ymd.TabIndex = 2010;
            this.txt_mat_ymd.TextChanged += new System.EventHandler(this.txt_mat_ymd_TextChanged);
            // 
            // lbl_mat_ymd
            // 
            this.lbl_mat_ymd.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mat_ymd.ImageIndex = 0;
            this.lbl_mat_ymd.ImageList = this.img_Label;
            this.lbl_mat_ymd.Location = new System.Drawing.Point(6, 336);
            this.lbl_mat_ymd.Name = "lbl_mat_ymd";
            this.lbl_mat_ymd.Size = new System.Drawing.Size(100, 21);
            this.lbl_mat_ymd.TabIndex = 2009;
            this.lbl_mat_ymd.Tag = "21";
            this.lbl_mat_ymd.Text = "Mat. Date";
            this.lbl_mat_ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_tag_cmt
            // 
            this.lbl_tag_cmt.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tag_cmt.ImageIndex = 0;
            this.lbl_tag_cmt.ImageList = this.img_Label;
            this.lbl_tag_cmt.Location = new System.Drawing.Point(245, 336);
            this.lbl_tag_cmt.Name = "lbl_tag_cmt";
            this.lbl_tag_cmt.Size = new System.Drawing.Size(100, 21);
            this.lbl_tag_cmt.TabIndex = 2008;
            this.lbl_tag_cmt.Tag = "21";
            this.lbl_tag_cmt.Text = "Tag Comment";
            this.lbl_tag_cmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_tag_cmt
            // 
            this.txt_tag_cmt.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tag_cmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tag_cmt.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_tag_cmt.ForeColor = System.Drawing.Color.Black;
            this.txt_tag_cmt.Location = new System.Drawing.Point(346, 337);
            this.txt_tag_cmt.MaxLength = 99999999;
            this.txt_tag_cmt.Name = "txt_tag_cmt";
            this.txt_tag_cmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_tag_cmt.Size = new System.Drawing.Size(121, 20);
            this.txt_tag_cmt.TabIndex = 2007;
            this.txt_tag_cmt.TextChanged += new System.EventHandler(this.txt_tag_cmt_TextChanged);
            // 
            // cmb_season_s
            // 
            this.cmb_season_s.AddItemSeparator = ';';
            this.cmb_season_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_season_s.Caption = "";
            this.cmb_season_s.CaptionHeight = 17;
            this.cmb_season_s.CaptionStyle = style145;
            this.cmb_season_s.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_season_s.ColumnCaptionHeight = 18;
            this.cmb_season_s.ColumnFooterHeight = 18;
            this.cmb_season_s.ContentHeight = 17;
            this.cmb_season_s.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_season_s.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_season_s.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season_s.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_season_s.EditorHeight = 17;
            this.cmb_season_s.EvenRowStyle = style146;
            this.cmb_season_s.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season_s.FooterStyle = style147;
            this.cmb_season_s.HeadingStyle = style148;
            this.cmb_season_s.HighLightRowStyle = style149;
            this.cmb_season_s.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_season_s.Images"))));
            this.cmb_season_s.ItemHeight = 15;
            this.cmb_season_s.Location = new System.Drawing.Point(346, 94);
            this.cmb_season_s.MatchEntryTimeout = ((long)(2000));
            this.cmb_season_s.MaxDropDownItems = ((short)(5));
            this.cmb_season_s.MaxLength = 32767;
            this.cmb_season_s.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_season_s.Name = "cmb_season_s";
            this.cmb_season_s.OddRowStyle = style150;
            this.cmb_season_s.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_season_s.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_season_s.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_season_s.SelectedStyle = style151;
            this.cmb_season_s.Size = new System.Drawing.Size(120, 21);
            this.cmb_season_s.Style = style152;
            this.cmb_season_s.TabIndex = 2006;
            this.cmb_season_s.SelectedValueChanged += new System.EventHandler(this.cmb_season_s_SelectedValueChanged_1);
            this.cmb_season_s.PropBag = resources.GetString("cmb_season_s.PropBag");
            // 
            // lbl_dev_prod
            // 
            this.lbl_dev_prod.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dev_prod.ImageIndex = 0;
            this.lbl_dev_prod.ImageList = this.img_Label;
            this.lbl_dev_prod.Location = new System.Drawing.Point(245, 138);
            this.lbl_dev_prod.Name = "lbl_dev_prod";
            this.lbl_dev_prod.Size = new System.Drawing.Size(100, 21);
            this.lbl_dev_prod.TabIndex = 2005;
            this.lbl_dev_prod.Tag = "21";
            this.lbl_dev_prod.Text = "Dev/Prod Fcty";
            this.lbl_dev_prod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_round
            // 
            this.cmb_round.AddItemSeparator = ';';
            this.cmb_round.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_round.Caption = "";
            this.cmb_round.CaptionHeight = 17;
            this.cmb_round.CaptionStyle = style153;
            this.cmb_round.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_round.ColumnCaptionHeight = 18;
            this.cmb_round.ColumnFooterHeight = 18;
            this.cmb_round.ContentHeight = 17;
            this.cmb_round.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_round.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_round.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_round.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_round.EditorHeight = 17;
            this.cmb_round.EvenRowStyle = style154;
            this.cmb_round.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_round.FooterStyle = style155;
            this.cmb_round.HeadingStyle = style156;
            this.cmb_round.HighLightRowStyle = style157;
            this.cmb_round.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_round.Images"))));
            this.cmb_round.ItemHeight = 15;
            this.cmb_round.Location = new System.Drawing.Point(346, 270);
            this.cmb_round.MatchEntryTimeout = ((long)(2000));
            this.cmb_round.MaxDropDownItems = ((short)(5));
            this.cmb_round.MaxLength = 32767;
            this.cmb_round.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_round.Name = "cmb_round";
            this.cmb_round.OddRowStyle = style158;
            this.cmb_round.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_round.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_round.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_round.SelectedStyle = style159;
            this.cmb_round.Size = new System.Drawing.Size(120, 21);
            this.cmb_round.Style = style160;
            this.cmb_round.TabIndex = 2004;
            this.cmb_round.SelectedValueChanged += new System.EventHandler(this.cmb_round_SelectedValueChanged);
            this.cmb_round.PropBag = resources.GetString("cmb_round.PropBag");
            // 
            // dtp_ipw
            // 
            this.dtp_ipw.CustomFormat = "yyyyMMdd";
            this.dtp_ipw.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ipw.Location = new System.Drawing.Point(855, 292);
            this.dtp_ipw.Name = "dtp_ipw";
            this.dtp_ipw.Size = new System.Drawing.Size(121, 22);
            this.dtp_ipw.TabIndex = 2003;
            this.dtp_ipw.ValueChanged += new System.EventHandler(this.dtp_ipw_ValueChanged);
            // 
            // dtp_ets
            // 
            this.dtp_ets.CustomFormat = "yyyyMMdd";
            this.dtp_ets.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ets.Location = new System.Drawing.Point(107, 27);
            this.dtp_ets.Name = "dtp_ets";
            this.dtp_ets.Size = new System.Drawing.Size(121, 22);
            this.dtp_ets.TabIndex = 2002;
            this.dtp_ets.ValueChanged += new System.EventHandler(this.dtp_ets_ValueChanged);
            // 
            // cmb_p_bom
            // 
            this.cmb_p_bom.AddItemSeparator = ';';
            this.cmb_p_bom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_p_bom.Caption = "";
            this.cmb_p_bom.CaptionHeight = 17;
            this.cmb_p_bom.CaptionStyle = style161;
            this.cmb_p_bom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_p_bom.ColumnCaptionHeight = 18;
            this.cmb_p_bom.ColumnFooterHeight = 18;
            this.cmb_p_bom.ContentHeight = 17;
            this.cmb_p_bom.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_p_bom.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_p_bom.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_p_bom.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_p_bom.EditorHeight = 17;
            this.cmb_p_bom.EvenRowStyle = style162;
            this.cmb_p_bom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_p_bom.FooterStyle = style163;
            this.cmb_p_bom.HeadingStyle = style164;
            this.cmb_p_bom.HighLightRowStyle = style165;
            this.cmb_p_bom.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_p_bom.Images"))));
            this.cmb_p_bom.ItemHeight = 15;
            this.cmb_p_bom.Location = new System.Drawing.Point(346, 6);
            this.cmb_p_bom.MatchEntryTimeout = ((long)(2000));
            this.cmb_p_bom.MaxDropDownItems = ((short)(5));
            this.cmb_p_bom.MaxLength = 32767;
            this.cmb_p_bom.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_p_bom.Name = "cmb_p_bom";
            this.cmb_p_bom.OddRowStyle = style166;
            this.cmb_p_bom.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_p_bom.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_p_bom.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_p_bom.SelectedStyle = style167;
            this.cmb_p_bom.Size = new System.Drawing.Size(120, 21);
            this.cmb_p_bom.Style = style168;
            this.cmb_p_bom.TabIndex = 4;
            this.cmb_p_bom.PropBag = resources.GetString("cmb_p_bom.PropBag");
            // 
            // lbl_fit
            // 
            this.lbl_fit.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fit.ImageIndex = 0;
            this.lbl_fit.ImageList = this.img_Label;
            this.lbl_fit.Location = new System.Drawing.Point(754, 182);
            this.lbl_fit.Name = "lbl_fit";
            this.lbl_fit.Size = new System.Drawing.Size(100, 21);
            this.lbl_fit.TabIndex = 2000;
            this.lbl_fit.Tag = "21";
            this.lbl_fit.Text = "Fit";
            this.lbl_fit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_fit
            // 
            this.txt_fit.BackColor = System.Drawing.SystemColors.Window;
            this.txt_fit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fit.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_fit.ForeColor = System.Drawing.Color.Black;
            this.txt_fit.Location = new System.Drawing.Point(855, 182);
            this.txt_fit.MaxLength = 50;
            this.txt_fit.Name = "txt_fit";
            this.txt_fit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_fit.Size = new System.Drawing.Size(120, 20);
            this.txt_fit.TabIndex = 94;
            this.txt_fit.TextChanged += new System.EventHandler(this.txt_fit_TextChanged);
            // 
            // txt_barcode_date
            // 
            this.txt_barcode_date.BackColor = System.Drawing.SystemColors.Window;
            this.txt_barcode_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_barcode_date.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_barcode_date.ForeColor = System.Drawing.Color.Black;
            this.txt_barcode_date.Location = new System.Drawing.Point(616, 160);
            this.txt_barcode_date.MaxLength = 50;
            this.txt_barcode_date.Name = "txt_barcode_date";
            this.txt_barcode_date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_barcode_date.Size = new System.Drawing.Size(359, 20);
            this.txt_barcode_date.TabIndex = 90;
            this.txt_barcode_date.TextChanged += new System.EventHandler(this.txt_barcode_date_TextChanged);
            // 
            // txt_fag_qty
            // 
            this.txt_fag_qty.BackColor = System.Drawing.SystemColors.Window;
            this.txt_fag_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fag_qty.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.txt_fag_qty.ForeColor = System.Drawing.Color.Black;
            this.txt_fag_qty.Location = new System.Drawing.Point(855, 94);
            this.txt_fag_qty.MaxLength = 25;
            this.txt_fag_qty.Name = "txt_fag_qty";
            this.txt_fag_qty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_fag_qty.Size = new System.Drawing.Size(120, 20);
            this.txt_fag_qty.TabIndex = 84;
            this.txt_fag_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_fag_qty.TextChanged += new System.EventHandler(this.txt_fag_qty_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageIndex = 0;
            this.label5.ImageList = this.img_Label;
            this.label5.Location = new System.Drawing.Point(754, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 2000;
            this.label5.Tag = "21";
            this.label5.Text = "FGA Qty";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_width
            // 
            this.txt_width.BackColor = System.Drawing.SystemColors.Window;
            this.txt_width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_width.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_width.ForeColor = System.Drawing.Color.Black;
            this.txt_width.Location = new System.Drawing.Point(616, 182);
            this.txt_width.MaxLength = 50;
            this.txt_width.Name = "txt_width";
            this.txt_width.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_width.Size = new System.Drawing.Size(120, 20);
            this.txt_width.TabIndex = 92;
            this.txt_width.TextChanged += new System.EventHandler(this.txt_width_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageIndex = 0;
            this.label7.ImageList = this.img_Label;
            this.label7.Location = new System.Drawing.Point(754, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 2000;
            this.label7.Tag = "21";
            this.label7.Text = "Dispatch Qty";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_dispatch_qty
            // 
            this.txt_dispatch_qty.BackColor = System.Drawing.SystemColors.Window;
            this.txt_dispatch_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dispatch_qty.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.txt_dispatch_qty.ForeColor = System.Drawing.Color.Black;
            this.txt_dispatch_qty.Location = new System.Drawing.Point(855, 116);
            this.txt_dispatch_qty.MaxLength = 25;
            this.txt_dispatch_qty.Name = "txt_dispatch_qty";
            this.txt_dispatch_qty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_dispatch_qty.Size = new System.Drawing.Size(120, 20);
            this.txt_dispatch_qty.TabIndex = 80;
            this.txt_dispatch_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_dispatch_qty.TextChanged += new System.EventHandler(this.txt_dispatch_qty_TextChanged);
            // 
            // lbl_IDS_length
            // 
            this.lbl_IDS_length.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDS_length.ImageIndex = 0;
            this.lbl_IDS_length.ImageList = this.img_Label;
            this.lbl_IDS_length.Location = new System.Drawing.Point(754, 138);
            this.lbl_IDS_length.Name = "lbl_IDS_length";
            this.lbl_IDS_length.Size = new System.Drawing.Size(100, 21);
            this.lbl_IDS_length.TabIndex = 2000;
            this.lbl_IDS_length.Tag = "21";
            this.lbl_IDS_length.Text = "IDS Length";
            this.lbl_IDS_length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageIndex = 0;
            this.label9.ImageList = this.img_Label;
            this.label9.Location = new System.Drawing.Point(754, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 21);
            this.label9.TabIndex = 2000;
            this.label9.Tag = "21";
            this.label9.Text = "Nike Dev";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ids_length
            // 
            this.txt_ids_length.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ids_length.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ids_length.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_ids_length.ForeColor = System.Drawing.Color.Black;
            this.txt_ids_length.Location = new System.Drawing.Point(855, 138);
            this.txt_ids_length.MaxLength = 50;
            this.txt_ids_length.Name = "txt_ids_length";
            this.txt_ids_length.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ids_length.Size = new System.Drawing.Size(120, 20);
            this.txt_ids_length.TabIndex = 88;
            this.txt_ids_length.TextChanged += new System.EventHandler(this.txt_ids_length_TextChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageIndex = 0;
            this.label11.ImageList = this.img_Label;
            this.label11.Location = new System.Drawing.Point(754, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 2000;
            this.label11.Tag = "21";
            this.label11.Text = "CDC Dev";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_medial_height
            // 
            this.txt_medial_height.BackColor = System.Drawing.SystemColors.Window;
            this.txt_medial_height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_medial_height.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_medial_height.ForeColor = System.Drawing.Color.Black;
            this.txt_medial_height.Location = new System.Drawing.Point(616, 72);
            this.txt_medial_height.MaxLength = 50;
            this.txt_medial_height.Name = "txt_medial_height";
            this.txt_medial_height.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_medial_height.Size = new System.Drawing.Size(120, 20);
            this.txt_medial_height.TabIndex = 78;
            this.txt_medial_height.TextChanged += new System.EventHandler(this.txt_medial_height_TextChanged);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImageIndex = 0;
            this.label16.ImageList = this.img_Label;
            this.label16.Location = new System.Drawing.Point(754, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 21);
            this.label16.TabIndex = 2000;
            this.label16.Tag = "21";
            this.label16.Text = "Dispatch Date";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nike_dev
            // 
            this.txt_nike_dev.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nike_dev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nike_dev.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_nike_dev.ForeColor = System.Drawing.Color.Black;
            this.txt_nike_dev.Location = new System.Drawing.Point(855, 72);
            this.txt_nike_dev.MaxLength = 50;
            this.txt_nike_dev.Name = "txt_nike_dev";
            this.txt_nike_dev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_nike_dev.Size = new System.Drawing.Size(120, 20);
            this.txt_nike_dev.TabIndex = 76;
            this.txt_nike_dev.TextChanged += new System.EventHandler(this.txt_nike_dev_TextChanged);
            // 
            // lbl_req_date
            // 
            this.lbl_req_date.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_req_date.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req_date.ImageIndex = 0;
            this.lbl_req_date.ImageList = this.img_Label;
            this.lbl_req_date.Location = new System.Drawing.Point(754, 6);
            this.lbl_req_date.Name = "lbl_req_date";
            this.lbl_req_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_req_date.TabIndex = 2000;
            this.lbl_req_date.Tag = "21";
            this.lbl_req_date.Text = "Request Date";
            this.lbl_req_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cdc_dev
            // 
            this.txt_cdc_dev.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cdc_dev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cdc_dev.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_cdc_dev.ForeColor = System.Drawing.Color.Black;
            this.txt_cdc_dev.Location = new System.Drawing.Point(855, 50);
            this.txt_cdc_dev.MaxLength = 50;
            this.txt_cdc_dev.Name = "txt_cdc_dev";
            this.txt_cdc_dev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_cdc_dev.Size = new System.Drawing.Size(120, 20);
            this.txt_cdc_dev.TabIndex = 72;
            this.txt_cdc_dev.TextChanged += new System.EventHandler(this.txt_cdc_dev_TextChanged);
            // 
            // txt_whq_dev
            // 
            this.txt_whq_dev.BackColor = System.Drawing.SystemColors.Window;
            this.txt_whq_dev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_whq_dev.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_whq_dev.ForeColor = System.Drawing.Color.Black;
            this.txt_whq_dev.Location = new System.Drawing.Point(107, 138);
            this.txt_whq_dev.MaxLength = 50;
            this.txt_whq_dev.Name = "txt_whq_dev";
            this.txt_whq_dev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_whq_dev.Size = new System.Drawing.Size(120, 20);
            this.txt_whq_dev.TabIndex = 22;
            this.txt_whq_dev.TextChanged += new System.EventHandler(this.txt_whq_dev_TextChanged);
            // 
            // dtp_dispatch_date
            // 
            this.dtp_dispatch_date.CustomFormat = "yyyyMMdd";
            this.dtp_dispatch_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dispatch_date.Location = new System.Drawing.Point(855, 27);
            this.dtp_dispatch_date.Name = "dtp_dispatch_date";
            this.dtp_dispatch_date.Size = new System.Drawing.Size(121, 22);
            this.dtp_dispatch_date.TabIndex = 68;
            this.dtp_dispatch_date.ValueChanged += new System.EventHandler(this.dtp_dispatch_date_ValueChanged);
            // 
            // cmb_gender
            // 
            this.cmb_gender.AddItemSeparator = ';';
            this.cmb_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_gender.Caption = "";
            this.cmb_gender.CaptionHeight = 17;
            this.cmb_gender.CaptionStyle = style169;
            this.cmb_gender.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_gender.ColumnCaptionHeight = 18;
            this.cmb_gender.ColumnFooterHeight = 18;
            this.cmb_gender.ContentHeight = 17;
            this.cmb_gender.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_gender.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_gender.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_gender.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_gender.EditorHeight = 17;
            this.cmb_gender.EvenRowStyle = style170;
            this.cmb_gender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_gender.FooterStyle = style171;
            this.cmb_gender.HeadingStyle = style172;
            this.cmb_gender.HighLightRowStyle = style173;
            this.cmb_gender.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_gender.Images"))));
            this.cmb_gender.ItemHeight = 15;
            this.cmb_gender.Location = new System.Drawing.Point(346, 116);
            this.cmb_gender.MatchEntryTimeout = ((long)(2000));
            this.cmb_gender.MaxDropDownItems = ((short)(5));
            this.cmb_gender.MaxLength = 32767;
            this.cmb_gender.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.OddRowStyle = style174;
            this.cmb_gender.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_gender.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_gender.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_gender.SelectedStyle = style175;
            this.cmb_gender.Size = new System.Drawing.Size(120, 21);
            this.cmb_gender.Style = style176;
            this.cmb_gender.TabIndex = 20;
            this.cmb_gender.SelectedValueChanged += new System.EventHandler(this.cmb_gender_SelectedValueChanged);
            this.cmb_gender.PropBag = resources.GetString("cmb_gender.PropBag");
            // 
            // dtp_request_date
            // 
            this.dtp_request_date.CustomFormat = "yyyyMMdd";
            this.dtp_request_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_request_date.Location = new System.Drawing.Point(855, 6);
            this.dtp_request_date.Name = "dtp_request_date";
            this.dtp_request_date.Size = new System.Drawing.Size(121, 22);
            this.dtp_request_date.TabIndex = 62;
            this.dtp_request_date.ValueChanged += new System.EventHandler(this.dtp_request_date_ValueChanged);
            // 
            // txt_sample_weight
            // 
            this.txt_sample_weight.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sample_weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sample_weight.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_sample_weight.ForeColor = System.Drawing.Color.Black;
            this.txt_sample_weight.Location = new System.Drawing.Point(616, 6);
            this.txt_sample_weight.MaxLength = 50;
            this.txt_sample_weight.Name = "txt_sample_weight";
            this.txt_sample_weight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_sample_weight.Size = new System.Drawing.Size(120, 20);
            this.txt_sample_weight.TabIndex = 60;
            this.txt_sample_weight.TextChanged += new System.EventHandler(this.txt_sample_weight_TextChanged);
            // 
            // lbl_style_cd
            // 
            this.lbl_style_cd.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_style_cd.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style_cd.ImageIndex = 0;
            this.lbl_style_cd.ImageList = this.img_Label;
            this.lbl_style_cd.Location = new System.Drawing.Point(245, 28);
            this.lbl_style_cd.Name = "lbl_style_cd";
            this.lbl_style_cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_style_cd.TabIndex = 2000;
            this.lbl_style_cd.Tag = "21";
            this.lbl_style_cd.Text = "Style Code";
            this.lbl_style_cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_style_cd
            // 
            this.txt_style_cd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_style_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_style_cd.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_style_cd.ForeColor = System.Drawing.Color.Black;
            this.txt_style_cd.Location = new System.Drawing.Point(346, 28);
            this.txt_style_cd.MaxLength = 9;
            this.txt_style_cd.Name = "txt_style_cd";
            this.txt_style_cd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_style_cd.Size = new System.Drawing.Size(120, 20);
            this.txt_style_cd.TabIndex = 6;
            this.txt_style_cd.TextChanged += new System.EventHandler(this.txt_style_cd_TextChanged);
            // 
            // lbl_medial_height
            // 
            this.lbl_medial_height.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medial_height.ImageIndex = 0;
            this.lbl_medial_height.ImageList = this.img_Label;
            this.lbl_medial_height.Location = new System.Drawing.Point(515, 72);
            this.lbl_medial_height.Name = "lbl_medial_height";
            this.lbl_medial_height.Size = new System.Drawing.Size(100, 21);
            this.lbl_medial_height.TabIndex = 2000;
            this.lbl_medial_height.Tag = "21";
            this.lbl_medial_height.Text = "Medial Height";
            this.lbl_medial_height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_midsole_hardness
            // 
            this.txt_midsole_hardness.BackColor = System.Drawing.SystemColors.Window;
            this.txt_midsole_hardness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_midsole_hardness.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_midsole_hardness.ForeColor = System.Drawing.Color.Black;
            this.txt_midsole_hardness.Location = new System.Drawing.Point(616, 138);
            this.txt_midsole_hardness.MaxLength = 50;
            this.txt_midsole_hardness.Name = "txt_midsole_hardness";
            this.txt_midsole_hardness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_midsole_hardness.Size = new System.Drawing.Size(120, 20);
            this.txt_midsole_hardness.TabIndex = 86;
            this.txt_midsole_hardness.TextChanged += new System.EventHandler(this.txt_midsole_hardness_TextChanged);
            // 
            // txt_mto_acc
            // 
            this.txt_mto_acc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_mto_acc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mto_acc.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_mto_acc.ForeColor = System.Drawing.Color.Black;
            this.txt_mto_acc.Location = new System.Drawing.Point(107, 94);
            this.txt_mto_acc.MaxLength = 100;
            this.txt_mto_acc.Name = "txt_mto_acc";
            this.txt_mto_acc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_mto_acc.Size = new System.Drawing.Size(120, 20);
            this.txt_mto_acc.TabIndex = 684;
            this.txt_mto_acc.TextChanged += new System.EventHandler(this.txt_mto_acc_TextChanged);
            // 
            // lbl_mto_acc
            // 
            this.lbl_mto_acc.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mto_acc.ImageIndex = 0;
            this.lbl_mto_acc.ImageList = this.img_Label;
            this.lbl_mto_acc.Location = new System.Drawing.Point(6, 94);
            this.lbl_mto_acc.Name = "lbl_mto_acc";
            this.lbl_mto_acc.Size = new System.Drawing.Size(100, 21);
            this.lbl_mto_acc.TabIndex = 2000;
            this.lbl_mto_acc.Tag = "21";
            this.lbl_mto_acc.Text = "MTO Acc. Name";
            this.lbl_mto_acc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_lace_length
            // 
            this.txt_lace_length.BackColor = System.Drawing.SystemColors.Window;
            this.txt_lace_length.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lace_length.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_lace_length.ForeColor = System.Drawing.Color.Black;
            this.txt_lace_length.Location = new System.Drawing.Point(616, 116);
            this.txt_lace_length.MaxLength = 50;
            this.txt_lace_length.Name = "txt_lace_length";
            this.txt_lace_length.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_lace_length.Size = new System.Drawing.Size(120, 20);
            this.txt_lace_length.TabIndex = 82;
            this.txt_lace_length.TextChanged += new System.EventHandler(this.txt_lace_length_TextChanged);
            // 
            // txt_size
            // 
            this.txt_size.BackColor = System.Drawing.SystemColors.Window;
            this.txt_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_size.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_size.ForeColor = System.Drawing.Color.Black;
            this.txt_size.Location = new System.Drawing.Point(107, 116);
            this.txt_size.MaxLength = 50;
            this.txt_size.Name = "txt_size";
            this.txt_size.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_size.Size = new System.Drawing.Size(120, 20);
            this.txt_size.TabIndex = 18;
            this.txt_size.TextChanged += new System.EventHandler(this.txt_size_TextChanged);
            // 
            // lbl_barcodekey
            // 
            this.lbl_barcodekey.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barcodekey.ImageIndex = 0;
            this.lbl_barcodekey.ImageList = this.img_Label;
            this.lbl_barcodekey.Location = new System.Drawing.Point(515, 226);
            this.lbl_barcodekey.Name = "lbl_barcodekey";
            this.lbl_barcodekey.Size = new System.Drawing.Size(100, 21);
            this.lbl_barcodekey.TabIndex = 2000;
            this.lbl_barcodekey.Tag = "21";
            this.lbl_barcodekey.Text = "Barcode";
            this.lbl_barcodekey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_laterial_height
            // 
            this.txt_laterial_height.BackColor = System.Drawing.SystemColors.Window;
            this.txt_laterial_height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_laterial_height.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_laterial_height.ForeColor = System.Drawing.Color.Black;
            this.txt_laterial_height.Location = new System.Drawing.Point(616, 94);
            this.txt_laterial_height.MaxLength = 50;
            this.txt_laterial_height.Name = "txt_laterial_height";
            this.txt_laterial_height.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_laterial_height.Size = new System.Drawing.Size(120, 20);
            this.txt_laterial_height.TabIndex = 74;
            this.txt_laterial_height.TextChanged += new System.EventHandler(this.txt_laterial_height_TextChanged);
            // 
            // txt_insole
            // 
            this.txt_insole.BackColor = System.Drawing.SystemColors.Window;
            this.txt_insole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_insole.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_insole.ForeColor = System.Drawing.Color.Black;
            this.txt_insole.Location = new System.Drawing.Point(616, 270);
            this.txt_insole.MaxLength = 200;
            this.txt_insole.Name = "txt_insole";
            this.txt_insole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_insole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_insole.Size = new System.Drawing.Size(359, 20);
            this.txt_insole.TabIndex = 102;
            this.txt_insole.TextChanged += new System.EventHandler(this.txt_insole_TextChanged);
            // 
            // lbl_midsole_hardness
            // 
            this.lbl_midsole_hardness.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_midsole_hardness.ImageIndex = 0;
            this.lbl_midsole_hardness.ImageList = this.img_Label;
            this.lbl_midsole_hardness.Location = new System.Drawing.Point(515, 138);
            this.lbl_midsole_hardness.Name = "lbl_midsole_hardness";
            this.lbl_midsole_hardness.Size = new System.Drawing.Size(100, 21);
            this.lbl_midsole_hardness.TabIndex = 2000;
            this.lbl_midsole_hardness.Tag = "21";
            this.lbl_midsole_hardness.Text = "M/S Hardness";
            this.lbl_midsole_hardness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_heel_height
            // 
            this.txt_heel_height.BackColor = System.Drawing.SystemColors.Window;
            this.txt_heel_height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_heel_height.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_heel_height.ForeColor = System.Drawing.Color.Black;
            this.txt_heel_height.Location = new System.Drawing.Point(616, 50);
            this.txt_heel_height.MaxLength = 50;
            this.txt_heel_height.Name = "txt_heel_height";
            this.txt_heel_height.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_heel_height.Size = new System.Drawing.Size(120, 20);
            this.txt_heel_height.TabIndex = 70;
            this.txt_heel_height.TextChanged += new System.EventHandler(this.txt_heel_height_TextChanged);
            // 
            // txt_upper_mat
            // 
            this.txt_upper_mat.BackColor = System.Drawing.SystemColors.Window;
            this.txt_upper_mat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_upper_mat.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_upper_mat.ForeColor = System.Drawing.Color.Black;
            this.txt_upper_mat.Location = new System.Drawing.Point(616, 204);
            this.txt_upper_mat.MaxLength = 200;
            this.txt_upper_mat.Name = "txt_upper_mat";
            this.txt_upper_mat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_upper_mat.Size = new System.Drawing.Size(359, 20);
            this.txt_upper_mat.TabIndex = 96;
            this.txt_upper_mat.TextChanged += new System.EventHandler(this.txt_upper_mat_TextChanged);
            // 
            // lbl_lace_length
            // 
            this.lbl_lace_length.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lace_length.ImageIndex = 0;
            this.lbl_lace_length.ImageList = this.img_Label;
            this.lbl_lace_length.Location = new System.Drawing.Point(515, 116);
            this.lbl_lace_length.Name = "lbl_lace_length";
            this.lbl_lace_length.Size = new System.Drawing.Size(100, 21);
            this.lbl_lace_length.TabIndex = 2000;
            this.lbl_lace_length.Tag = "21";
            this.lbl_lace_length.Text = "lace Length";
            this.lbl_lace_length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_collar_height
            // 
            this.txt_collar_height.BackColor = System.Drawing.SystemColors.Window;
            this.txt_collar_height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_collar_height.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_collar_height.ForeColor = System.Drawing.Color.Black;
            this.txt_collar_height.Location = new System.Drawing.Point(616, 28);
            this.txt_collar_height.MaxLength = 50;
            this.txt_collar_height.Name = "txt_collar_height";
            this.txt_collar_height.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_collar_height.Size = new System.Drawing.Size(120, 20);
            this.txt_collar_height.TabIndex = 64;
            this.txt_collar_height.TextChanged += new System.EventHandler(this.txt_collar_height_TextChanged);
            // 
            // lbl_lateral_height
            // 
            this.lbl_lateral_height.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lateral_height.ImageIndex = 0;
            this.lbl_lateral_height.ImageList = this.img_Label;
            this.lbl_lateral_height.Location = new System.Drawing.Point(515, 94);
            this.lbl_lateral_height.Name = "lbl_lateral_height";
            this.lbl_lateral_height.Size = new System.Drawing.Size(100, 21);
            this.lbl_lateral_height.TabIndex = 2000;
            this.lbl_lateral_height.Tag = "21";
            this.lbl_lateral_height.Text = "Lateral Height";
            this.lbl_lateral_height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_srno
            // 
            this.txt_srno.BackColor = System.Drawing.SystemColors.Window;
            this.txt_srno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_srno.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.txt_srno.ForeColor = System.Drawing.Color.Black;
            this.txt_srno.Location = new System.Drawing.Point(107, 6);
            this.txt_srno.MaxLength = 10;
            this.txt_srno.Name = "txt_srno";
            this.txt_srno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_srno.Size = new System.Drawing.Size(120, 20);
            this.txt_srno.TabIndex = 2;
            this.txt_srno.TextChanged += new System.EventHandler(this.txt_srno_TextChanged);
            // 
            // txt_stl_file
            // 
            this.txt_stl_file.BackColor = System.Drawing.SystemColors.Window;
            this.txt_stl_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stl_file.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_stl_file.ForeColor = System.Drawing.Color.Black;
            this.txt_stl_file.Location = new System.Drawing.Point(107, 292);
            this.txt_stl_file.MaxLength = 50;
            this.txt_stl_file.Name = "txt_stl_file";
            this.txt_stl_file.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_stl_file.Size = new System.Drawing.Size(120, 20);
            this.txt_stl_file.TabIndex = 40;
            this.txt_stl_file.TextChanged += new System.EventHandler(this.txt_stl_file_TextChanged);
            // 
            // lbl_srno
            // 
            this.lbl_srno.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srno.ImageIndex = 0;
            this.lbl_srno.ImageList = this.img_Label;
            this.lbl_srno.Location = new System.Drawing.Point(6, 6);
            this.lbl_srno.Name = "lbl_srno";
            this.lbl_srno.Size = new System.Drawing.Size(100, 21);
            this.lbl_srno.TabIndex = 2000;
            this.lbl_srno.Tag = "21";
            this.lbl_srno.Text = "Sample Request";
            this.lbl_srno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_seasonyear
            // 
            this.lbl_seasonyear.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_seasonyear.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seasonyear.ImageIndex = 0;
            this.lbl_seasonyear.ImageList = this.img_Label;
            this.lbl_seasonyear.Location = new System.Drawing.Point(245, 94);
            this.lbl_seasonyear.Name = "lbl_seasonyear";
            this.lbl_seasonyear.Size = new System.Drawing.Size(100, 21);
            this.lbl_seasonyear.TabIndex = 2000;
            this.lbl_seasonyear.Tag = "21";
            this.lbl_seasonyear.Text = "Season/Year";
            this.lbl_seasonyear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_barcode
            // 
            this.txt_barcode.BackColor = System.Drawing.SystemColors.Window;
            this.txt_barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_barcode.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_barcode.ForeColor = System.Drawing.Color.Black;
            this.txt_barcode.Location = new System.Drawing.Point(616, 226);
            this.txt_barcode.MaxLength = 50;
            this.txt_barcode.Multiline = true;
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_barcode.Size = new System.Drawing.Size(359, 20);
            this.txt_barcode.TabIndex = 98;
            this.txt_barcode.TextChanged += new System.EventHandler(this.txt_barcode_TextChanged);
            // 
            // lbl_sample_weigt
            // 
            this.lbl_sample_weigt.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sample_weigt.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sample_weigt.ImageIndex = 0;
            this.lbl_sample_weigt.ImageList = this.img_Label;
            this.lbl_sample_weigt.Location = new System.Drawing.Point(515, 6);
            this.lbl_sample_weigt.Name = "lbl_sample_weigt";
            this.lbl_sample_weigt.Size = new System.Drawing.Size(100, 21);
            this.lbl_sample_weigt.TabIndex = 2000;
            this.lbl_sample_weigt.Tag = "21";
            this.lbl_sample_weigt.Text = "Sample Weight";
            this.lbl_sample_weigt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_size
            // 
            this.lbl_size.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.ImageIndex = 0;
            this.lbl_size.ImageList = this.img_Label;
            this.lbl_size.Location = new System.Drawing.Point(6, 116);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(100, 21);
            this.lbl_size.TabIndex = 2000;
            this.lbl_size.Tag = "21";
            this.lbl_size.Text = "Size";
            this.lbl_size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_whq_dev
            // 
            this.lbl_whq_dev.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_whq_dev.ImageIndex = 0;
            this.lbl_whq_dev.ImageList = this.img_Label;
            this.lbl_whq_dev.Location = new System.Drawing.Point(6, 138);
            this.lbl_whq_dev.Name = "lbl_whq_dev";
            this.lbl_whq_dev.Size = new System.Drawing.Size(100, 21);
            this.lbl_whq_dev.TabIndex = 2000;
            this.lbl_whq_dev.Tag = "21";
            this.lbl_whq_dev.Text = "WHQ Developer";
            this.lbl_whq_dev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_bom_id
            // 
            this.txt_bom_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_bom_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bom_id.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_bom_id.ForeColor = System.Drawing.Color.Black;
            this.txt_bom_id.Location = new System.Drawing.Point(107, 160);
            this.txt_bom_id.MaxLength = 17;
            this.txt_bom_id.Name = "txt_bom_id";
            this.txt_bom_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_bom_id.Size = new System.Drawing.Size(120, 20);
            this.txt_bom_id.TabIndex = 26;
            this.txt_bom_id.TextChanged += new System.EventHandler(this.txt_bom_id_TextChanged);
            // 
            // lbl_heel_height
            // 
            this.lbl_heel_height.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heel_height.ImageIndex = 0;
            this.lbl_heel_height.ImageList = this.img_Label;
            this.lbl_heel_height.Location = new System.Drawing.Point(515, 50);
            this.lbl_heel_height.Name = "lbl_heel_height";
            this.lbl_heel_height.Size = new System.Drawing.Size(100, 21);
            this.lbl_heel_height.TabIndex = 2000;
            this.lbl_heel_height.Tag = "21";
            this.lbl_heel_height.Text = "Heel Height";
            this.lbl_heel_height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_insole
            // 
            this.lbl_insole.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_insole.ImageIndex = 0;
            this.lbl_insole.ImageList = this.img_Label;
            this.lbl_insole.Location = new System.Drawing.Point(515, 270);
            this.lbl_insole.Name = "lbl_insole";
            this.lbl_insole.Size = new System.Drawing.Size(100, 21);
            this.lbl_insole.TabIndex = 2000;
            this.lbl_insole.Tag = "21";
            this.lbl_insole.Text = "Insole";
            this.lbl_insole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shoe_lace
            // 
            this.lbl_shoe_lace.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shoe_lace.ImageIndex = 0;
            this.lbl_shoe_lace.ImageList = this.img_Label;
            this.lbl_shoe_lace.Location = new System.Drawing.Point(515, 248);
            this.lbl_shoe_lace.Name = "lbl_shoe_lace";
            this.lbl_shoe_lace.Size = new System.Drawing.Size(100, 21);
            this.lbl_shoe_lace.TabIndex = 2000;
            this.lbl_shoe_lace.Tag = "21";
            this.lbl_shoe_lace.Text = "Shoe lace";
            this.lbl_shoe_lace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_bomid
            // 
            this.lbl_bomid.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bomid.ImageIndex = 0;
            this.lbl_bomid.ImageList = this.img_Label;
            this.lbl_bomid.Location = new System.Drawing.Point(6, 160);
            this.lbl_bomid.Name = "lbl_bomid";
            this.lbl_bomid.Size = new System.Drawing.Size(100, 21);
            this.lbl_bomid.TabIndex = 2000;
            this.lbl_bomid.Tag = "21";
            this.lbl_bomid.Text = "BOM ID";
            this.lbl_bomid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_width
            // 
            this.lbl_width.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_width.ImageIndex = 0;
            this.lbl_width.ImageList = this.img_Label;
            this.lbl_width.Location = new System.Drawing.Point(515, 182);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(100, 21);
            this.lbl_width.TabIndex = 2000;
            this.lbl_width.Tag = "21";
            this.lbl_width.Text = "Width";
            this.lbl_width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_collar_height
            // 
            this.lbl_collar_height.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_collar_height.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_collar_height.ImageIndex = 0;
            this.lbl_collar_height.ImageList = this.img_Label;
            this.lbl_collar_height.Location = new System.Drawing.Point(515, 28);
            this.lbl_collar_height.Name = "lbl_collar_height";
            this.lbl_collar_height.Size = new System.Drawing.Size(100, 21);
            this.lbl_collar_height.TabIndex = 2000;
            this.lbl_collar_height.Tag = "21";
            this.lbl_collar_height.Text = "Collar Height";
            this.lbl_collar_height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_t_d
            // 
            this.lbl_t_d.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t_d.ImageIndex = 0;
            this.lbl_t_d.ImageList = this.img_Label;
            this.lbl_t_d.Location = new System.Drawing.Point(515, 292);
            this.lbl_t_d.Name = "lbl_t_d";
            this.lbl_t_d.Size = new System.Drawing.Size(100, 21);
            this.lbl_t_d.TabIndex = 2000;
            this.lbl_t_d.Tag = "21";
            this.lbl_t_d.Text = "T_D";
            this.lbl_t_d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_current_fob
            // 
            this.lbl_current_fob.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_fob.ImageIndex = 0;
            this.lbl_current_fob.ImageList = this.img_Label;
            this.lbl_current_fob.Location = new System.Drawing.Point(245, 314);
            this.lbl_current_fob.Name = "lbl_current_fob";
            this.lbl_current_fob.Size = new System.Drawing.Size(100, 21);
            this.lbl_current_fob.TabIndex = 2000;
            this.lbl_current_fob.Tag = "21";
            this.lbl_current_fob.Text = "Current FOB";
            this.lbl_current_fob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_retail_price
            // 
            this.lbl_retail_price.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_retail_price.ImageIndex = 0;
            this.lbl_retail_price.ImageList = this.img_Label;
            this.lbl_retail_price.Location = new System.Drawing.Point(6, 314);
            this.lbl_retail_price.Name = "lbl_retail_price";
            this.lbl_retail_price.Size = new System.Drawing.Size(100, 21);
            this.lbl_retail_price.TabIndex = 2000;
            this.lbl_retail_price.Tag = "21";
            this.lbl_retail_price.Text = "Retail Price";
            this.lbl_retail_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barcode.ImageIndex = 0;
            this.lbl_barcode.ImageList = this.img_Label;
            this.lbl_barcode.Location = new System.Drawing.Point(515, 160);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(100, 21);
            this.lbl_barcode.TabIndex = 2000;
            this.lbl_barcode.Tag = "21";
            this.lbl_barcode.Text = "Barcode Date";
            this.lbl_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_stl_file
            // 
            this.lbl_stl_file.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stl_file.ImageIndex = 0;
            this.lbl_stl_file.ImageList = this.img_Label;
            this.lbl_stl_file.Location = new System.Drawing.Point(6, 292);
            this.lbl_stl_file.Name = "lbl_stl_file";
            this.lbl_stl_file.Size = new System.Drawing.Size(100, 21);
            this.lbl_stl_file.TabIndex = 2000;
            this.lbl_stl_file.Tag = "21";
            this.lbl_stl_file.Text = "STL File";
            this.lbl_stl_file.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ipw_ymd
            // 
            this.lbl_ipw_ymd.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ipw_ymd.ImageIndex = 0;
            this.lbl_ipw_ymd.ImageList = this.img_Label;
            this.lbl_ipw_ymd.Location = new System.Drawing.Point(754, 292);
            this.lbl_ipw_ymd.Name = "lbl_ipw_ymd";
            this.lbl_ipw_ymd.Size = new System.Drawing.Size(100, 21);
            this.lbl_ipw_ymd.TabIndex = 2000;
            this.lbl_ipw_ymd.Tag = "21";
            this.lbl_ipw_ymd.Text = "IPW Date";
            this.lbl_ipw_ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_retail_price
            // 
            this.txt_retail_price.BackColor = System.Drawing.SystemColors.Window;
            this.txt_retail_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_retail_price.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_retail_price.ForeColor = System.Drawing.Color.Black;
            this.txt_retail_price.Location = new System.Drawing.Point(107, 314);
            this.txt_retail_price.MaxLength = 25;
            this.txt_retail_price.Name = "txt_retail_price";
            this.txt_retail_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_retail_price.Size = new System.Drawing.Size(120, 20);
            this.txt_retail_price.TabIndex = 54;
            this.txt_retail_price.TextChanged += new System.EventHandler(this.txt_retail_price_TextChanged);
            // 
            // txt_current_fob
            // 
            this.txt_current_fob.BackColor = System.Drawing.SystemColors.Window;
            this.txt_current_fob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_current_fob.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_current_fob.ForeColor = System.Drawing.Color.Black;
            this.txt_current_fob.Location = new System.Drawing.Point(346, 315);
            this.txt_current_fob.MaxLength = 25;
            this.txt_current_fob.Name = "txt_current_fob";
            this.txt_current_fob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_current_fob.Size = new System.Drawing.Size(120, 20);
            this.txt_current_fob.TabIndex = 56;
            this.txt_current_fob.TextChanged += new System.EventHandler(this.txt_current_fob_TextChanged);
            // 
            // txt_colors
            // 
            this.txt_colors.BackColor = System.Drawing.SystemColors.Window;
            this.txt_colors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_colors.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_colors.ForeColor = System.Drawing.Color.Black;
            this.txt_colors.Location = new System.Drawing.Point(107, 248);
            this.txt_colors.MaxLength = 100;
            this.txt_colors.Name = "txt_colors";
            this.txt_colors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_colors.Size = new System.Drawing.Size(359, 20);
            this.txt_colors.TabIndex = 34;
            this.txt_colors.TextChanged += new System.EventHandler(this.txt_colors_TextChanged);
            // 
            // lbl_colors
            // 
            this.lbl_colors.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_colors.ImageIndex = 0;
            this.lbl_colors.ImageList = this.img_Label;
            this.lbl_colors.Location = new System.Drawing.Point(6, 248);
            this.lbl_colors.Name = "lbl_colors";
            this.lbl_colors.Size = new System.Drawing.Size(100, 21);
            this.lbl_colors.TabIndex = 2000;
            this.lbl_colors.Tag = "21";
            this.lbl_colors.Text = "Colors";
            this.lbl_colors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_lastcd
            // 
            this.txt_lastcd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_lastcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lastcd.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_lastcd.ForeColor = System.Drawing.Color.Black;
            this.txt_lastcd.Location = new System.Drawing.Point(107, 270);
            this.txt_lastcd.MaxLength = 50;
            this.txt_lastcd.Name = "txt_lastcd";
            this.txt_lastcd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_lastcd.Size = new System.Drawing.Size(120, 20);
            this.txt_lastcd.TabIndex = 36;
            this.txt_lastcd.TextChanged += new System.EventHandler(this.txt_lastcd_TextChanged);
            // 
            // txt_pattern
            // 
            this.txt_pattern.BackColor = System.Drawing.SystemColors.Window;
            this.txt_pattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pattern.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_pattern.ForeColor = System.Drawing.Color.Black;
            this.txt_pattern.Location = new System.Drawing.Point(346, 160);
            this.txt_pattern.MaxLength = 50;
            this.txt_pattern.Name = "txt_pattern";
            this.txt_pattern.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_pattern.Size = new System.Drawing.Size(120, 20);
            this.txt_pattern.TabIndex = 38;
            this.txt_pattern.TextChanged += new System.EventHandler(this.txt_pattern_TextChanged);
            // 
            // txt_solelaying_method
            // 
            this.txt_solelaying_method.BackColor = System.Drawing.SystemColors.Window;
            this.txt_solelaying_method.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_solelaying_method.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_solelaying_method.ForeColor = System.Drawing.Color.Black;
            this.txt_solelaying_method.Location = new System.Drawing.Point(107, 226);
            this.txt_solelaying_method.MaxLength = 100;
            this.txt_solelaying_method.Name = "txt_solelaying_method";
            this.txt_solelaying_method.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_solelaying_method.Size = new System.Drawing.Size(359, 20);
            this.txt_solelaying_method.TabIndex = 32;
            this.txt_solelaying_method.TextChanged += new System.EventHandler(this.txt_solelaying_method_TextChanged);
            // 
            // lbl_p_bom
            // 
            this.lbl_p_bom.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_bom.ImageIndex = 0;
            this.lbl_p_bom.ImageList = this.img_Label;
            this.lbl_p_bom.Location = new System.Drawing.Point(245, 6);
            this.lbl_p_bom.Name = "lbl_p_bom";
            this.lbl_p_bom.Size = new System.Drawing.Size(100, 21);
            this.lbl_p_bom.TabIndex = 2000;
            this.lbl_p_bom.Tag = "21";
            this.lbl_p_bom.Text = "Product BOM";
            this.lbl_p_bom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_lastcd
            // 
            this.lbl_lastcd.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastcd.ImageIndex = 0;
            this.lbl_lastcd.ImageList = this.img_Label;
            this.lbl_lastcd.Location = new System.Drawing.Point(6, 270);
            this.lbl_lastcd.Name = "lbl_lastcd";
            this.lbl_lastcd.Size = new System.Drawing.Size(100, 21);
            this.lbl_lastcd.TabIndex = 2000;
            this.lbl_lastcd.Tag = "21";
            this.lbl_lastcd.Text = "Last ID";
            this.lbl_lastcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_midsole_method
            // 
            this.txt_midsole_method.BackColor = System.Drawing.SystemColors.Window;
            this.txt_midsole_method.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_midsole_method.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_midsole_method.ForeColor = System.Drawing.Color.Black;
            this.txt_midsole_method.Location = new System.Drawing.Point(107, 204);
            this.txt_midsole_method.MaxLength = 100;
            this.txt_midsole_method.Name = "txt_midsole_method";
            this.txt_midsole_method.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_midsole_method.Size = new System.Drawing.Size(359, 20);
            this.txt_midsole_method.TabIndex = 30;
            this.txt_midsole_method.TextChanged += new System.EventHandler(this.txt_midsole_method_TextChanged);
            // 
            // lbl_pattern
            // 
            this.lbl_pattern.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pattern.ImageIndex = 0;
            this.lbl_pattern.ImageList = this.img_Label;
            this.lbl_pattern.Location = new System.Drawing.Point(245, 160);
            this.lbl_pattern.Name = "lbl_pattern";
            this.lbl_pattern.Size = new System.Drawing.Size(100, 21);
            this.lbl_pattern.TabIndex = 2000;
            this.lbl_pattern.Tag = "21";
            this.lbl_pattern.Text = "Pattern";
            this.lbl_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_lasting_method
            // 
            this.txt_lasting_method.BackColor = System.Drawing.SystemColors.Window;
            this.txt_lasting_method.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lasting_method.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_lasting_method.ForeColor = System.Drawing.Color.Black;
            this.txt_lasting_method.Location = new System.Drawing.Point(107, 182);
            this.txt_lasting_method.MaxLength = 100;
            this.txt_lasting_method.Name = "txt_lasting_method";
            this.txt_lasting_method.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_lasting_method.Size = new System.Drawing.Size(359, 20);
            this.txt_lasting_method.TabIndex = 28;
            this.txt_lasting_method.TextChanged += new System.EventHandler(this.txt_lasting_method_TextChanged);
            // 
            // lbl_solelaying_method
            // 
            this.lbl_solelaying_method.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solelaying_method.ImageIndex = 0;
            this.lbl_solelaying_method.ImageList = this.img_Label;
            this.lbl_solelaying_method.Location = new System.Drawing.Point(6, 226);
            this.lbl_solelaying_method.Name = "lbl_solelaying_method";
            this.lbl_solelaying_method.Size = new System.Drawing.Size(100, 21);
            this.lbl_solelaying_method.TabIndex = 2000;
            this.lbl_solelaying_method.Tag = "21";
            this.lbl_solelaying_method.Text = "S/L Method";
            this.lbl_solelaying_method.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sampletype
            // 
            this.lbl_sampletype.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sampletype.ImageIndex = 0;
            this.lbl_sampletype.ImageList = this.img_Label;
            this.lbl_sampletype.Location = new System.Drawing.Point(245, 270);
            this.lbl_sampletype.Name = "lbl_sampletype";
            this.lbl_sampletype.Size = new System.Drawing.Size(100, 21);
            this.lbl_sampletype.TabIndex = 2000;
            this.lbl_sampletype.Tag = "21";
            this.lbl_sampletype.Text = "Sample Type";
            this.lbl_sampletype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ms_method
            // 
            this.lbl_ms_method.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ms_method.ImageIndex = 0;
            this.lbl_ms_method.ImageList = this.img_Label;
            this.lbl_ms_method.Location = new System.Drawing.Point(6, 204);
            this.lbl_ms_method.Name = "lbl_ms_method";
            this.lbl_ms_method.Size = new System.Drawing.Size(100, 21);
            this.lbl_ms_method.TabIndex = 2000;
            this.lbl_ms_method.Tag = "21";
            this.lbl_ms_method.Text = "M/S Method";
            this.lbl_ms_method.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_srfno
            // 
            this.txt_srfno.BackColor = System.Drawing.SystemColors.Window;
            this.txt_srfno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_srfno.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.txt_srfno.ForeColor = System.Drawing.Color.Black;
            this.txt_srfno.Location = new System.Drawing.Point(107, 72);
            this.txt_srfno.MaxLength = 20;
            this.txt_srfno.Name = "txt_srfno";
            this.txt_srfno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_srfno.Size = new System.Drawing.Size(120, 20);
            this.txt_srfno.TabIndex = 10;
            this.txt_srfno.TextChanged += new System.EventHandler(this.txt_srfno_TextChanged);
            // 
            // lbl_last
            // 
            this.lbl_last.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last.ImageIndex = 0;
            this.lbl_last.ImageList = this.img_Label;
            this.lbl_last.Location = new System.Drawing.Point(6, 182);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(100, 21);
            this.lbl_last.TabIndex = 2000;
            this.lbl_last.Tag = "21";
            this.lbl_last.Text = "Lasting Method";
            this.lbl_last.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_srfno
            // 
            this.lbl_srfno.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srfno.ImageIndex = 0;
            this.lbl_srfno.ImageList = this.img_Label;
            this.lbl_srfno.Location = new System.Drawing.Point(6, 72);
            this.lbl_srfno.Name = "lbl_srfno";
            this.lbl_srfno.Size = new System.Drawing.Size(100, 21);
            this.lbl_srfno.TabIndex = 2000;
            this.lbl_srfno.Tag = "21";
            this.lbl_srfno.Text = "ModelOfferingId";
            this.lbl_srfno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_gender
            // 
            this.lbl_gender.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ImageIndex = 0;
            this.lbl_gender.ImageList = this.img_Label;
            this.lbl_gender.Location = new System.Drawing.Point(245, 116);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_gender.TabIndex = 2000;
            this.lbl_gender.Tag = "21";
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_modelname
            // 
            this.txt_modelname.BackColor = System.Drawing.SystemColors.Window;
            this.txt_modelname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_modelname.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.txt_modelname.ForeColor = System.Drawing.Color.Black;
            this.txt_modelname.Location = new System.Drawing.Point(107, 50);
            this.txt_modelname.MaxLength = 50;
            this.txt_modelname.Name = "txt_modelname";
            this.txt_modelname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_modelname.Size = new System.Drawing.Size(359, 20);
            this.txt_modelname.TabIndex = 8;
            this.txt_modelname.TextChanged += new System.EventHandler(this.txt_modelname_TextChanged);
            // 
            // lbl_modelname
            // 
            this.lbl_modelname.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modelname.ImageIndex = 0;
            this.lbl_modelname.ImageList = this.img_Label;
            this.lbl_modelname.Location = new System.Drawing.Point(6, 50);
            this.lbl_modelname.Name = "lbl_modelname";
            this.lbl_modelname.Size = new System.Drawing.Size(100, 21);
            this.lbl_modelname.TabIndex = 2000;
            this.lbl_modelname.Tag = "21";
            this.lbl_modelname.Text = "DevModel Name";
            this.lbl_modelname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_rts
            // 
            this.lbl_rts.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rts.ImageIndex = 0;
            this.lbl_rts.ImageList = this.img_Label;
            this.lbl_rts.Location = new System.Drawing.Point(6, 28);
            this.lbl_rts.Name = "lbl_rts";
            this.lbl_rts.Size = new System.Drawing.Size(100, 21);
            this.lbl_rts.TabIndex = 2000;
            this.lbl_rts.Tag = "21";
            this.lbl_rts.Text = "Completed Date";
            this.lbl_rts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_dev_prod
            // 
            this.txt_dev_prod.BackColor = System.Drawing.SystemColors.Window;
            this.txt_dev_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dev_prod.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_dev_prod.ForeColor = System.Drawing.Color.Black;
            this.txt_dev_prod.Location = new System.Drawing.Point(346, 138);
            this.txt_dev_prod.MaxLength = 200;
            this.txt_dev_prod.Name = "txt_dev_prod";
            this.txt_dev_prod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_dev_prod.Size = new System.Drawing.Size(120, 20);
            this.txt_dev_prod.TabIndex = 24;
            this.txt_dev_prod.TextChanged += new System.EventHandler(this.txt_dev_prod_TextChanged);
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(980, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 319);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // txt_lace_desc
            // 
            this.txt_lace_desc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_lace_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lace_desc.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_lace_desc.ForeColor = System.Drawing.Color.Black;
            this.txt_lace_desc.Location = new System.Drawing.Point(616, 248);
            this.txt_lace_desc.MaxLength = 50;
            this.txt_lace_desc.Name = "txt_lace_desc";
            this.txt_lace_desc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_lace_desc.Size = new System.Drawing.Size(359, 20);
            this.txt_lace_desc.TabIndex = 100;
            this.txt_lace_desc.TextChanged += new System.EventHandler(this.txt_lace_desc_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(981, 0);
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
            this.pictureBox3.Size = new System.Drawing.Size(772, 40);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_upper_mat
            // 
            this.lbl_upper_mat.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upper_mat.ImageIndex = 0;
            this.lbl_upper_mat.ImageList = this.img_Label;
            this.lbl_upper_mat.Location = new System.Drawing.Point(515, 204);
            this.lbl_upper_mat.Name = "lbl_upper_mat";
            this.lbl_upper_mat.Size = new System.Drawing.Size(100, 21);
            this.lbl_upper_mat.TabIndex = 2000;
            this.lbl_upper_mat.Tag = "21";
            this.lbl_upper_mat.Text = "Upper Material";
            this.lbl_upper_mat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pictureBox4.Location = new System.Drawing.Point(981, 347);
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
            this.pictureBox5.Location = new System.Drawing.Point(144, 346);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(847, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 347);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // cmb_category
            // 
            this.cmb_category.AddItemSeparator = ';';
            this.cmb_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_category.Caption = "";
            this.cmb_category.CaptionHeight = 17;
            this.cmb_category.CaptionStyle = style177;
            this.cmb_category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_category.ColumnCaptionHeight = 18;
            this.cmb_category.ColumnFooterHeight = 18;
            this.cmb_category.ContentHeight = 17;
            this.cmb_category.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_category.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_category.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_category.EditorHeight = 17;
            this.cmb_category.EvenRowStyle = style178;
            this.cmb_category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.FooterStyle = style179;
            this.cmb_category.HeadingStyle = style180;
            this.cmb_category.HighLightRowStyle = style181;
            this.cmb_category.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_category.Images"))));
            this.cmb_category.ItemHeight = 15;
            this.cmb_category.Location = new System.Drawing.Point(346, 72);
            this.cmb_category.MatchEntryTimeout = ((long)(2000));
            this.cmb_category.MaxDropDownItems = ((short)(5));
            this.cmb_category.MaxLength = 32767;
            this.cmb_category.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.OddRowStyle = style182;
            this.cmb_category.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_category.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_category.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_category.SelectedStyle = style183;
            this.cmb_category.Size = new System.Drawing.Size(120, 21);
            this.cmb_category.Style = style184;
            this.cmb_category.TabIndex = 12;
            this.cmb_category.SelectedValueChanged += new System.EventHandler(this.cmb_category_SelectedValueChanged);
            this.cmb_category.PropBag = resources.GetString("cmb_category.PropBag");
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 329);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // lbl_category
            // 
            this.lbl_category.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_category.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ImageIndex = 0;
            this.lbl_category.ImageList = this.img_Label;
            this.lbl_category.Location = new System.Drawing.Point(245, 72);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(100, 21);
            this.lbl_category.TabIndex = 2000;
            this.lbl_category.Tag = "21";
            this.lbl_category.Text = "Category";
            this.lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pictureBox9.Size = new System.Drawing.Size(997, 322);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
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
            this.pictureBox8.Size = new System.Drawing.Size(841, 322);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.label3);
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
            this.panel5.Location = new System.Drawing.Point(4, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(997, 362);
            this.panel5.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 112;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox27.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(980, 30);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(24, 319);
            this.pictureBox27.TabIndex = 26;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox28.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
            this.pictureBox28.Location = new System.Drawing.Point(981, 0);
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
            this.pictureBox29.Size = new System.Drawing.Size(997, 40);
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
            this.pictureBox30.Location = new System.Drawing.Point(981, 347);
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
            this.pictureBox31.Location = new System.Drawing.Point(144, 346);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(997, 18);
            this.pictureBox31.TabIndex = 24;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox32.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
            this.pictureBox32.Location = new System.Drawing.Point(0, 347);
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
            this.pictureBox33.Size = new System.Drawing.Size(168, 329);
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
            this.pictureBox34.Size = new System.Drawing.Size(997, 322);
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
            this.pictureBox35.Size = new System.Drawing.Size(997, 322);
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
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.pictureBox21);
            this.panel4.Controls.Add(this.pictureBox22);
            this.panel4.Controls.Add(this.pictureBox23);
            this.panel4.Controls.Add(this.pictureBox24);
            this.panel4.Controls.Add(this.pictureBox25);
            this.panel4.Controls.Add(this.pictureBox26);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(4, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(997, 362);
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
            this.pictureBox18.Location = new System.Drawing.Point(980, 30);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(24, 319);
            this.pictureBox18.TabIndex = 26;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(981, 0);
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
            this.pictureBox20.Size = new System.Drawing.Size(997, 40);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 30);
            this.label8.TabIndex = 28;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(981, 347);
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
            this.pictureBox22.Location = new System.Drawing.Point(144, 346);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(997, 18);
            this.pictureBox22.TabIndex = 24;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox23.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(0, 347);
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
            this.pictureBox24.Size = new System.Drawing.Size(168, 329);
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
            this.pictureBox25.Size = new System.Drawing.Size(997, 322);
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
            this.pictureBox26.Size = new System.Drawing.Size(997, 322);
            this.pictureBox26.TabIndex = 27;
            this.pictureBox26.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.panel2);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pnl_head.Size = new System.Drawing.Size(1013, 149);
            this.pnl_head.TabIndex = 393;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_grid);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.panel2.Size = new System.Drawing.Size(997, 149);
            this.panel2.TabIndex = 401;
            // 
            // pnl_grid
            // 
            this.pnl_grid.Controls.Add(this.flg_project);
            this.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_grid.Location = new System.Drawing.Point(0, 79);
            this.pnl_grid.Name = "pnl_grid";
            this.pnl_grid.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pnl_grid.Size = new System.Drawing.Size(993, 70);
            this.pnl_grid.TabIndex = 404;
            // 
            // flg_project
            // 
            this.flg_project.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flg_project.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"link bom\";}\t";
            this.flg_project.ContextMenuStrip = this.ctm_Menu;
            this.flg_project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flg_project.Location = new System.Drawing.Point(0, 4);
            this.flg_project.Name = "flg_project";
            this.flg_project.Rows.DefaultSize = 19;
            this.flg_project.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.flg_project.Size = new System.Drawing.Size(993, 66);
            this.flg_project.StyleInfo = resources.GetString("flg_project.StyleInfo");
            this.flg_project.TabIndex = 138;
            this.flg_project.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flg_project_MouseClick);
            this.flg_project.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.flg_project_AfterEdit);
            this.flg_project.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.flg_project_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.txt_srf_no_h);
            this.panel3.Controls.Add(this.lbl_srf_no_h);
            this.panel3.Controls.Add(this.txt_sr_no_h);
            this.panel3.Controls.Add(this.lbl_sr_no_h);
            this.panel3.Controls.Add(this.cmb_season_h);
            this.panel3.Controls.Add(this.lbl_season_h);
            this.panel3.Controls.Add(this.cmb_category_h);
            this.panel3.Controls.Add(this.lbl_category_h);
            this.panel3.Controls.Add(this.cmb_sampetyps_h);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmb_devuser_h);
            this.panel3.Controls.Add(this.txt_bom_id_h);
            this.panel3.Controls.Add(this.lbl_devuser);
            this.panel3.Controls.Add(this.cmb_factory_h);
            this.panel3.Controls.Add(this.lbl_factory);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbl_bom_id);
            this.panel3.Controls.Add(this.pictureBox10);
            this.panel3.Controls.Add(this.pictureBox11);
            this.panel3.Controls.Add(this.lbl_srf_info);
            this.panel3.Controls.Add(this.pictureBox12);
            this.panel3.Controls.Add(this.pictureBox13);
            this.panel3.Controls.Add(this.pictureBox14);
            this.panel3.Controls.Add(this.pictureBox15);
            this.panel3.Controls.Add(this.pictureBox16);
            this.panel3.Controls.Add(this.pictureBox17);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 75);
            this.panel3.TabIndex = 402;
            // 
            // txt_srf_no_h
            // 
            this.txt_srf_no_h.BackColor = System.Drawing.SystemColors.Window;
            this.txt_srf_no_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_srf_no_h.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_srf_no_h.ForeColor = System.Drawing.Color.Black;
            this.txt_srf_no_h.Location = new System.Drawing.Point(107, 50);
            this.txt_srf_no_h.MaxLength = 100;
            this.txt_srf_no_h.Name = "txt_srf_no_h";
            this.txt_srf_no_h.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_srf_no_h.Size = new System.Drawing.Size(120, 20);
            this.txt_srf_no_h.TabIndex = 696;
            // 
            // lbl_srf_no_h
            // 
            this.lbl_srf_no_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srf_no_h.ImageIndex = 0;
            this.lbl_srf_no_h.ImageList = this.img_Label;
            this.lbl_srf_no_h.Location = new System.Drawing.Point(6, 50);
            this.lbl_srf_no_h.Name = "lbl_srf_no_h";
            this.lbl_srf_no_h.Size = new System.Drawing.Size(100, 21);
            this.lbl_srf_no_h.TabIndex = 695;
            this.lbl_srf_no_h.Tag = "21";
            this.lbl_srf_no_h.Text = "SRF No";
            this.lbl_srf_no_h.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sr_no_h
            // 
            this.txt_sr_no_h.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sr_no_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sr_no_h.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_sr_no_h.ForeColor = System.Drawing.Color.Black;
            this.txt_sr_no_h.Location = new System.Drawing.Point(855, 28);
            this.txt_sr_no_h.MaxLength = 100;
            this.txt_sr_no_h.Name = "txt_sr_no_h";
            this.txt_sr_no_h.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_sr_no_h.Size = new System.Drawing.Size(120, 20);
            this.txt_sr_no_h.TabIndex = 694;
            // 
            // lbl_sr_no_h
            // 
            this.lbl_sr_no_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sr_no_h.ImageIndex = 0;
            this.lbl_sr_no_h.ImageList = this.img_Label;
            this.lbl_sr_no_h.Location = new System.Drawing.Point(754, 28);
            this.lbl_sr_no_h.Name = "lbl_sr_no_h";
            this.lbl_sr_no_h.Size = new System.Drawing.Size(100, 21);
            this.lbl_sr_no_h.TabIndex = 693;
            this.lbl_sr_no_h.Tag = "0";
            this.lbl_sr_no_h.Text = "SR No";
            this.lbl_sr_no_h.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_season_h
            // 
            this.cmb_season_h.AddItemSeparator = ';';
            this.cmb_season_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_season_h.Caption = "";
            this.cmb_season_h.CaptionHeight = 17;
            this.cmb_season_h.CaptionStyle = style185;
            this.cmb_season_h.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_season_h.ColumnCaptionHeight = 18;
            this.cmb_season_h.ColumnFooterHeight = 18;
            this.cmb_season_h.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_season_h.ContentHeight = 17;
            this.cmb_season_h.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_season_h.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_season_h.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season_h.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_season_h.EditorHeight = 17;
            this.cmb_season_h.EvenRowStyle = style186;
            this.cmb_season_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season_h.FooterStyle = style187;
            this.cmb_season_h.HeadingStyle = style188;
            this.cmb_season_h.HighLightRowStyle = style189;
            this.cmb_season_h.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_season_h.Images"))));
            this.cmb_season_h.ItemHeight = 15;
            this.cmb_season_h.Location = new System.Drawing.Point(616, 28);
            this.cmb_season_h.MatchEntryTimeout = ((long)(2000));
            this.cmb_season_h.MaxDropDownItems = ((short)(5));
            this.cmb_season_h.MaxLength = 32767;
            this.cmb_season_h.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_season_h.Name = "cmb_season_h";
            this.cmb_season_h.OddRowStyle = style190;
            this.cmb_season_h.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_season_h.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_season_h.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_season_h.SelectedStyle = style191;
            this.cmb_season_h.Size = new System.Drawing.Size(120, 21);
            this.cmb_season_h.Style = style192;
            this.cmb_season_h.TabIndex = 692;
            this.cmb_season_h.PropBag = resources.GetString("cmb_season_h.PropBag");
            // 
            // lbl_season_h
            // 
            this.lbl_season_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_season_h.ImageIndex = 0;
            this.lbl_season_h.ImageList = this.img_Label;
            this.lbl_season_h.Location = new System.Drawing.Point(515, 28);
            this.lbl_season_h.Name = "lbl_season_h";
            this.lbl_season_h.Size = new System.Drawing.Size(100, 21);
            this.lbl_season_h.TabIndex = 691;
            this.lbl_season_h.Tag = "0";
            this.lbl_season_h.Text = "Season";
            this.lbl_season_h.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_category_h
            // 
            this.cmb_category_h.AddItemSeparator = ';';
            this.cmb_category_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_category_h.Caption = "";
            this.cmb_category_h.CaptionHeight = 17;
            this.cmb_category_h.CaptionStyle = style193;
            this.cmb_category_h.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_category_h.ColumnCaptionHeight = 18;
            this.cmb_category_h.ColumnFooterHeight = 18;
            this.cmb_category_h.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_category_h.ContentHeight = 17;
            this.cmb_category_h.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_category_h.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_category_h.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category_h.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_category_h.EditorHeight = 17;
            this.cmb_category_h.EvenRowStyle = style194;
            this.cmb_category_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category_h.FooterStyle = style195;
            this.cmb_category_h.HeadingStyle = style196;
            this.cmb_category_h.HighLightRowStyle = style197;
            this.cmb_category_h.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_category_h.Images"))));
            this.cmb_category_h.ItemHeight = 15;
            this.cmb_category_h.Location = new System.Drawing.Point(346, 27);
            this.cmb_category_h.MatchEntryTimeout = ((long)(2000));
            this.cmb_category_h.MaxDropDownItems = ((short)(5));
            this.cmb_category_h.MaxLength = 32767;
            this.cmb_category_h.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_category_h.Name = "cmb_category_h";
            this.cmb_category_h.OddRowStyle = style198;
            this.cmb_category_h.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_category_h.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_category_h.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_category_h.SelectedStyle = style199;
            this.cmb_category_h.Size = new System.Drawing.Size(120, 21);
            this.cmb_category_h.Style = style200;
            this.cmb_category_h.TabIndex = 690;
            this.cmb_category_h.PropBag = resources.GetString("cmb_category_h.PropBag");
            // 
            // lbl_category_h
            // 
            this.lbl_category_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category_h.ImageIndex = 0;
            this.lbl_category_h.ImageList = this.img_Label;
            this.lbl_category_h.Location = new System.Drawing.Point(245, 28);
            this.lbl_category_h.Name = "lbl_category_h";
            this.lbl_category_h.Size = new System.Drawing.Size(100, 21);
            this.lbl_category_h.TabIndex = 689;
            this.lbl_category_h.Tag = "21";
            this.lbl_category_h.Text = "Category";
            this.lbl_category_h.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_sampetyps_h
            // 
            this.cmb_sampetyps_h.AddItemSeparator = ';';
            this.cmb_sampetyps_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sampetyps_h.Caption = "";
            this.cmb_sampetyps_h.CaptionHeight = 17;
            this.cmb_sampetyps_h.CaptionStyle = style201;
            this.cmb_sampetyps_h.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_sampetyps_h.ColumnCaptionHeight = 18;
            this.cmb_sampetyps_h.ColumnFooterHeight = 18;
            this.cmb_sampetyps_h.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_sampetyps_h.ContentHeight = 17;
            this.cmb_sampetyps_h.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_sampetyps_h.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_sampetyps_h.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampetyps_h.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sampetyps_h.EditorHeight = 17;
            this.cmb_sampetyps_h.EvenRowStyle = style202;
            this.cmb_sampetyps_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampetyps_h.FooterStyle = style203;
            this.cmb_sampetyps_h.HeadingStyle = style204;
            this.cmb_sampetyps_h.HighLightRowStyle = style205;
            this.cmb_sampetyps_h.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_sampetyps_h.Images"))));
            this.cmb_sampetyps_h.ItemHeight = 15;
            this.cmb_sampetyps_h.Location = new System.Drawing.Point(616, 50);
            this.cmb_sampetyps_h.MatchEntryTimeout = ((long)(2000));
            this.cmb_sampetyps_h.MaxDropDownItems = ((short)(5));
            this.cmb_sampetyps_h.MaxLength = 32767;
            this.cmb_sampetyps_h.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sampetyps_h.Name = "cmb_sampetyps_h";
            this.cmb_sampetyps_h.OddRowStyle = style206;
            this.cmb_sampetyps_h.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sampetyps_h.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sampetyps_h.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sampetyps_h.SelectedStyle = style207;
            this.cmb_sampetyps_h.Size = new System.Drawing.Size(120, 21);
            this.cmb_sampetyps_h.Style = style208;
            this.cmb_sampetyps_h.TabIndex = 688;
            this.cmb_sampetyps_h.PropBag = resources.GetString("cmb_sampetyps_h.PropBag");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(515, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 687;
            this.label2.Tag = "0";
            this.label2.Text = "Sample Types";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_devuser_h
            // 
            this.cmb_devuser_h.AddItemSeparator = ';';
            this.cmb_devuser_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_devuser_h.Caption = "";
            this.cmb_devuser_h.CaptionHeight = 17;
            this.cmb_devuser_h.CaptionStyle = style209;
            this.cmb_devuser_h.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_devuser_h.ColumnCaptionHeight = 18;
            this.cmb_devuser_h.ColumnFooterHeight = 18;
            this.cmb_devuser_h.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_devuser_h.ContentHeight = 17;
            this.cmb_devuser_h.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_devuser_h.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_devuser_h.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_devuser_h.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_devuser_h.EditorHeight = 17;
            this.cmb_devuser_h.EvenRowStyle = style210;
            this.cmb_devuser_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_devuser_h.FooterStyle = style211;
            this.cmb_devuser_h.HeadingStyle = style212;
            this.cmb_devuser_h.HighLightRowStyle = style213;
            this.cmb_devuser_h.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_devuser_h.Images"))));
            this.cmb_devuser_h.ItemHeight = 15;
            this.cmb_devuser_h.Location = new System.Drawing.Point(855, 50);
            this.cmb_devuser_h.MatchEntryTimeout = ((long)(2000));
            this.cmb_devuser_h.MaxDropDownItems = ((short)(5));
            this.cmb_devuser_h.MaxLength = 32767;
            this.cmb_devuser_h.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_devuser_h.Name = "cmb_devuser_h";
            this.cmb_devuser_h.OddRowStyle = style214;
            this.cmb_devuser_h.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_devuser_h.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_devuser_h.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_devuser_h.SelectedStyle = style215;
            this.cmb_devuser_h.Size = new System.Drawing.Size(120, 21);
            this.cmb_devuser_h.Style = style216;
            this.cmb_devuser_h.TabIndex = 405;
            this.cmb_devuser_h.PropBag = resources.GetString("cmb_devuser_h.PropBag");
            // 
            // txt_bom_id_h
            // 
            this.txt_bom_id_h.BackColor = System.Drawing.SystemColors.Window;
            this.txt_bom_id_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bom_id_h.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_bom_id_h.ForeColor = System.Drawing.Color.Black;
            this.txt_bom_id_h.Location = new System.Drawing.Point(346, 50);
            this.txt_bom_id_h.MaxLength = 100;
            this.txt_bom_id_h.Name = "txt_bom_id_h";
            this.txt_bom_id_h.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_bom_id_h.Size = new System.Drawing.Size(120, 20);
            this.txt_bom_id_h.TabIndex = 0;
            // 
            // lbl_devuser
            // 
            this.lbl_devuser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_devuser.ImageIndex = 0;
            this.lbl_devuser.ImageList = this.img_Label;
            this.lbl_devuser.Location = new System.Drawing.Point(754, 50);
            this.lbl_devuser.Name = "lbl_devuser";
            this.lbl_devuser.Size = new System.Drawing.Size(100, 21);
            this.lbl_devuser.TabIndex = 404;
            this.lbl_devuser.Tag = "0";
            this.lbl_devuser.Text = "User";
            this.lbl_devuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory_h
            // 
            this.cmb_factory_h.AddItemSeparator = ';';
            this.cmb_factory_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory_h.Caption = "";
            this.cmb_factory_h.CaptionHeight = 17;
            this.cmb_factory_h.CaptionStyle = style217;
            this.cmb_factory_h.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory_h.ColumnCaptionHeight = 18;
            this.cmb_factory_h.ColumnFooterHeight = 18;
            this.cmb_factory_h.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory_h.ContentHeight = 17;
            this.cmb_factory_h.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory_h.EditorBackColor = System.Drawing.Color.White;
            this.cmb_factory_h.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory_h.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory_h.EditorHeight = 17;
            this.cmb_factory_h.EvenRowStyle = style218;
            this.cmb_factory_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory_h.FooterStyle = style219;
            this.cmb_factory_h.HeadingStyle = style220;
            this.cmb_factory_h.HighLightRowStyle = style221;
            this.cmb_factory_h.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory_h.Images"))));
            this.cmb_factory_h.ItemHeight = 15;
            this.cmb_factory_h.Location = new System.Drawing.Point(107, 28);
            this.cmb_factory_h.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory_h.MaxDropDownItems = ((short)(5));
            this.cmb_factory_h.MaxLength = 32767;
            this.cmb_factory_h.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory_h.Name = "cmb_factory_h";
            this.cmb_factory_h.OddRowStyle = style222;
            this.cmb_factory_h.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory_h.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory_h.RowSubDividerColor = System.Drawing.Color.White;
            this.cmb_factory_h.SelectedStyle = style223;
            this.cmb_factory_h.Size = new System.Drawing.Size(120, 21);
            this.cmb_factory_h.Style = style224;
            this.cmb_factory_h.TabIndex = 397;
            this.cmb_factory_h.SelectedValueChanged += new System.EventHandler(this.cmb_factory_h_SelectedValueChanged);
            this.cmb_factory_h.PropBag = resources.GetString("cmb_factory_h.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(6, 28);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 396;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 112;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(976, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 32);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_bom_id
            // 
            this.lbl_bom_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bom_id.ImageIndex = 0;
            this.lbl_bom_id.ImageList = this.img_Label;
            this.lbl_bom_id.Location = new System.Drawing.Point(245, 50);
            this.lbl_bom_id.Name = "lbl_bom_id";
            this.lbl_bom_id.Size = new System.Drawing.Size(100, 21);
            this.lbl_bom_id.TabIndex = 392;
            this.lbl_bom_id.Tag = "21";
            this.lbl_bom_id.Text = "BOM Id";
            this.lbl_bom_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(977, 0);
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
            this.pictureBox11.Size = new System.Drawing.Size(993, 40);
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
            this.pictureBox12.Location = new System.Drawing.Point(977, 60);
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
            this.pictureBox13.Location = new System.Drawing.Point(144, 59);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(993, 18);
            this.pictureBox13.TabIndex = 24;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(0, 60);
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
            this.pictureBox15.Size = new System.Drawing.Size(168, 42);
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
            this.pictureBox16.Size = new System.Drawing.Size(993, 35);
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
            this.pictureBox17.Size = new System.Drawing.Size(993, 35);
            this.pictureBox17.TabIndex = 27;
            this.pictureBox17.TabStop = false;
            // 
            // lbl_sms_chem
            // 
            this.lbl_sms_chem.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sms_chem.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sms_chem.ImageIndex = 0;
            this.lbl_sms_chem.ImageList = this.img_Label;
            this.lbl_sms_chem.Location = new System.Drawing.Point(515, 336);
            this.lbl_sms_chem.Name = "lbl_sms_chem";
            this.lbl_sms_chem.Size = new System.Drawing.Size(100, 17);
            this.lbl_sms_chem.TabIndex = 2053;
            this.lbl_sms_chem.Tag = "21";
            this.lbl_sms_chem.Text = "CE. for SMS";
            this.lbl_sms_chem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_sms_chem
            // 
            this.cmb_sms_chem.AddItemSeparator = ';';
            this.cmb_sms_chem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sms_chem.Caption = "";
            this.cmb_sms_chem.CaptionHeight = 17;
            this.cmb_sms_chem.CaptionStyle = style113;
            this.cmb_sms_chem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_sms_chem.ColumnCaptionHeight = 18;
            this.cmb_sms_chem.ColumnFooterHeight = 18;
            this.cmb_sms_chem.ContentHeight = 17;
            this.cmb_sms_chem.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_sms_chem.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_sms_chem.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sms_chem.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sms_chem.EditorHeight = 17;
            this.cmb_sms_chem.EvenRowStyle = style114;
            this.cmb_sms_chem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sms_chem.FooterStyle = style115;
            this.cmb_sms_chem.HeadingStyle = style116;
            this.cmb_sms_chem.HighLightRowStyle = style117;
            this.cmb_sms_chem.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_sms_chem.Images"))));
            this.cmb_sms_chem.ItemHeight = 15;
            this.cmb_sms_chem.Location = new System.Drawing.Point(616, 336);
            this.cmb_sms_chem.MatchEntryTimeout = ((long)(2000));
            this.cmb_sms_chem.MaxDropDownItems = ((short)(5));
            this.cmb_sms_chem.MaxLength = 32767;
            this.cmb_sms_chem.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sms_chem.Name = "cmb_sms_chem";
            this.cmb_sms_chem.OddRowStyle = style118;
            this.cmb_sms_chem.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sms_chem.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sms_chem.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sms_chem.SelectedStyle = style119;
            this.cmb_sms_chem.Size = new System.Drawing.Size(97, 21);
            this.cmb_sms_chem.Style = style120;
            this.cmb_sms_chem.TabIndex = 2054;
            this.cmb_sms_chem.PropBag = resources.GetString("cmb_sms_chem.PropBag");
            // 
            // btn_sms_chem
            // 
            this.btn_sms_chem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_sms_chem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_sms_chem.Image = ((System.Drawing.Image)(resources.GetObject("btn_sms_chem.Image")));
            this.btn_sms_chem.Location = new System.Drawing.Point(714, 336);
            this.btn_sms_chem.Name = "btn_sms_chem";
            this.btn_sms_chem.Size = new System.Drawing.Size(22, 22);
            this.btn_sms_chem.TabIndex = 2055;
            this.btn_sms_chem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sms_chem.Click += new System.EventHandler(this.btn_sms_chem_Click);
            // 
            // Form_Worksheet_VJ
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_main);
            this.Name = "Form_Worksheet_VJ";
            this.Load += new System.EventHandler(this.Form_Project_Manager_Load);
            this.Controls.SetChildIndex(this.pnl_main, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ctm_Menu.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            this.pnl_Body.ResumeLayout(false);
            this.pnl_tab_process_upper.ResumeLayout(false);
            this.grb_op.ResumeLayout(false);
            this.grb_op.PerformLayout();
            this.pnl_info.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_t_d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sms_mold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sms_dev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_round)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_p_bom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
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
            this.pnl_head.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flg_project)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampetyps_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_devuser_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sms_chem)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #region User Define Variable
        private COM.OraDB OraDB = new COM.OraDB();
        private COM.ComFunction comfunction = new COM.ComFunction();
        Microsoft.Office.Interop.Excel.Workbook workbook = null;
        Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
        Microsoft.Office.Interop.Excel.Application application = null;            

        private string _form_mode = "";
        private string _factory = COM.ComVar.This_Factory;
        private string _category = null;
        private string _season   = null;
        private string _srf_no   = null;
        private string _bom_id   = null;
        private string _upload_user="";

        private string _sample_types = " ";
        private string _sr_no = " ";   

        private string dateType = "yyyyMMdd";

        private bool show_head   = true;
        private bool show_tail   = true;     
        private string _filetype = null;        

        //Copy Excel
        private bool copy_excel = false;
        private string copy_file_path = "";
        private int copy_row;
        private int insert_row;

        private string server_path = "";
        private bool click_flg = false;
        private string File_Bakcup = "";        
        #endregion       
        
        #region Resource
        public Form_Worksheet_VJ()
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();  //Menu에서  call -""

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }

        public Form_Worksheet_VJ(string arg_form_mode, string arg_factory, string arg_category, string arg_season, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_round, string arg_upload_user)
        {
            InitializeComponent();            
            _form_mode = arg_form_mode;
            _factory = arg_factory;
            _category = arg_category;
            _season = arg_season;
            _sr_no = arg_sr_no;
            _srf_no = arg_srf_no;
            _bom_id = arg_bom_id;
            _sample_types = arg_round;
            _upload_user = arg_upload_user;
        }
        #endregion

        #region Form Loading
        private void Form_Project_Manager_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                System.Data.DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory_h, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_factory_h.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void cmb_factory_h_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_factory_h.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_factory_h.SelectedValue.ToString();
                Init_Form();
            }
            catch
            {

            }
        }    
        private void Init_Form()
        {
            this.Text = "PCC_Worksheet for Developer";
            this.lbl_MainTitle.Text = "PCC_Worksheet for Developer";
                                    
            #region ComboBox Setting
            //Sample Type
            System.Data.DataTable dt_ret = SELECT_SAMPLE_TYPE();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampetyps_h, 0, 1, true, 0, 120);
            cmb_sampetyps_h.SelectedIndex = 0;            
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, false, 0, 120);            

            //Category
            dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory_h.SelectedValue.ToString(), ClassLib.ComVar.CxCDC_Category);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category_h, 1, 2, true, 0, 120);
            cmb_category_h.SelectedIndex = 0;            
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1, 2, false, 0, 120);
            
            //Season
            dt_ret = SELECT_SEASON();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_h, 0, 1, true, 0, 120);
            cmb_season_h.SelectedIndex = 0;            
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_s, 0, 1, false, 0, 120);

            //Product bom code setting
            dt_ret = SELECT_BOM_CD();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_p_bom, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code);            

            //Gender
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory_h.SelectedValue.ToString(), ClassLib.ComVar.CxGen);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_gender, 1, 2, false, 0, 120);

            //T_D
            dt_ret = SELECT_TD(cmb_factory_h.SelectedValue.ToString());
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_t_d, 0, 1, false, 0, 120);

            #region User Setting for SMS          
            //Dev
            dt_ret = SELECT_HUSER_LIST(cmb_factory_h.SelectedValue.ToString(), "P", "");
            DataRow row = dt_ret.NewRow();
            row["sabun"] = "000000000";
            row["name"] = "N/A";
            dt_ret.Rows.Add(row);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sms_dev, 1, 2, false, 0, 120);
            cmb_sms_dev.SelectedValue = "000000000";
            cmb_sms_dev.Enabled = false;
            cmb_sms_dev.BackColor = SystemColors.Control;

            // Mold 
            dt_ret = SELECT_HUSER_LIST(cmb_factory_h.SelectedValue.ToString(), "M", "");
            row = dt_ret.NewRow();
            row["sabun"] = "000000000";
            row["name"] = "N/A";
            dt_ret.Rows.Add(row);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sms_mold, 1, 2, false, 0, 120);
            cmb_sms_mold.SelectedValue = "000000000";
            cmb_sms_mold.Enabled = false;
            cmb_sms_mold.BackColor = SystemColors.Control;

            //CHEMICAL
            dt_ret = SELECT_HUSER_LIST(cmb_factory_h.SelectedValue.ToString(), "P", "");
            row = dt_ret.NewRow();
            row["sabun"] = "000000000";
            row["name"] = "N/A";
            dt_ret.Rows.Add(row);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sms_chem, 1, 2, false, 0, 120);
            cmb_sms_chem.SelectedValue = "000000000";
            cmb_sms_chem.Enabled = false;
            cmb_sms_chem.BackColor = SystemColors.Control;
            #endregion

            #region Upload  User
            dt_ret = SELECT_LOADUSER();
            string power_level = "";

            try
            {
                power_level = ClassLib.ComVar.This_CDCPower_Level.ToString().Substring(0, 1);
            }
            catch
            {
 
            }

            if (power_level.Equals("P") || power_level.Equals("I") || power_level.Equals("W") || power_level.Equals("S"))
            {
                cmb_devuser_h.Enabled = true;
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_devuser_h, 0, 0, true, 0, 120);
                cmb_devuser_h.SelectedIndex = 0;
            }
            else
            {
                cmb_devuser_h.Enabled = false;

                System.Data.DataTable user_datatable = new System.Data.DataTable("UserList");
                DataRow newrow;

                user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                newrow = user_datatable.NewRow();
                newrow["Code"] = ClassLib.ComVar.This_User;
                newrow["Name"] = ClassLib.ComVar.This_User;

                user_datatable.Rows.Add(newrow);

                ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_devuser_h, 0, 0, false, 0, 120);
                cmb_devuser_h.SelectedValue = ClassLib.ComVar.This_User;
            }
            #endregion
            #endregion

            #region Grid Setting
            flg_project.Set_Grid_CDC("SXG_PROJ_MANAGER_VJ", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_project.Set_Action_Image(img_Action);
            flg_project.Font = new System.Drawing.Font("Verdana", 8);
            flg_project.Tree.Column = (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS;            
            flg_project.GetCellRange(0, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN, 1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIMAGE_CHK).StyleNew.TextAlign = TextAlignEnum.LeftCenter;
                        
            #endregion
            
            #region Button & TextBox Control
            tbtn_Append.Enabled  = false;
            tbtn_Color.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Insert.Enabled  = false;
            tbtn_New.Enabled     = false;
            tbtn_Print.Enabled   = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            
            mnu_insert.Enabled      = false;
            mnu_delete.Enabled      = false;
            mnu_upload.Enabled      = false;
            mnu_download.Enabled    = false;
            mnu_edit.Enabled        = false;
            mnu_copy.Enabled        = false;
            mnu_paste.Enabled       = false;
            mnu_forecast.Visible    = false;
            mnu_copy_record.Visible = false;

            cmb_p_bom.Enabled     = false;
            txt_mat_ymd.Enabled   = false;
            txt_mat_ymd.BackColor = SystemColors.Control; 

            txt_bom_id_h.CharacterCasing          = CharacterCasing.Upper;
            txt_sr_no_h.CharacterCasing           = CharacterCasing.Upper;
            txt_srf_no_h.CharacterCasing          = CharacterCasing.Upper;
            txt_barcode.CharacterCasing           = CharacterCasing.Upper;
            txt_barcode_date.CharacterCasing      = CharacterCasing.Upper;
            txt_bom_id.CharacterCasing            = CharacterCasing.Upper;
            txt_collar_height.CharacterCasing     = CharacterCasing.Upper;
            txt_colors.CharacterCasing            = CharacterCasing.Upper;
            txt_current_fob.CharacterCasing       = CharacterCasing.Upper;
            txt_dev_prod.CharacterCasing          = CharacterCasing.Upper;
            txt_dispatch_qty.CharacterCasing      = CharacterCasing.Upper;
            txt_fag_qty.CharacterCasing           = CharacterCasing.Upper;
            txt_fit.CharacterCasing               = CharacterCasing.Upper;
            txt_heel_height.CharacterCasing       = CharacterCasing.Upper;
            txt_ids_length.CharacterCasing        = CharacterCasing.Upper;
            txt_insole.CharacterCasing            = CharacterCasing.Upper;
            txt_lace_desc.CharacterCasing         = CharacterCasing.Upper;
            txt_lace_length.CharacterCasing       = CharacterCasing.Upper;
            txt_lastcd.CharacterCasing            = CharacterCasing.Upper;
            txt_lasting_method.CharacterCasing    = CharacterCasing.Upper;
            txt_laterial_height.CharacterCasing   = CharacterCasing.Upper;
            txt_medial_height.CharacterCasing     = CharacterCasing.Upper;
            txt_midsole_hardness.CharacterCasing  = CharacterCasing.Upper;
            txt_midsole_method.CharacterCasing    = CharacterCasing.Upper;
            txt_modelname.CharacterCasing         = CharacterCasing.Upper;
            txt_mto_acc.CharacterCasing           = CharacterCasing.Upper;
            txt_nike_dev.CharacterCasing          = CharacterCasing.Upper;
            txt_pattern.CharacterCasing           = CharacterCasing.Upper;
            txt_retail_price.CharacterCasing      = CharacterCasing.Upper;
            txt_sample_weight.CharacterCasing     = CharacterCasing.Upper;
            txt_size.CharacterCasing              = CharacterCasing.Upper;
            txt_solelaying_method.CharacterCasing = CharacterCasing.Upper;
            txt_srfno.CharacterCasing             = CharacterCasing.Upper;
            txt_srno.CharacterCasing              = CharacterCasing.Upper;
            txt_stl_file.CharacterCasing          = CharacterCasing.Upper;
            txt_style_cd.CharacterCasing          = CharacterCasing.Upper;            
            txt_upper_mat.CharacterCasing         = CharacterCasing.Upper;
            txt_width.CharacterCasing             = CharacterCasing.Upper;

            txt_bom_id_h.Focus();            
            #endregion

            #region File Server Path
            if (COM.ComVar.This_Factory == "DS")
            {
                server_path = @"\\203.228.108.19\PCC_Sephiroth_File\";
                File_Bakcup = @"\\203.228.108.14\PCC-WorkSheet\";
            }
            if (COM.ComVar.This_Factory == "VJ")
            {
                server_path = @"\\211.54.128.14\PCC_Sephiroth_File\";
                File_Bakcup = @"\\211.54.128.14\PCC_Sephiroth_File_BK\";
            }
            if (COM.ComVar.This_Factory == "QD")
            {
                server_path = @"\\119.119.119.19\PCC_Sephiroth_File\";
            }
            #endregion
            
            pnl_head.Height = 200;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;            
        }

        private System.Data.DataTable SELECT_SAMPLE_TYPE()
        {
            string Proc_Name = "PKG_SXG_MPS_01_SELECT.SELECT_SAMPLE_TYPES";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory_h.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private System.Data.DataTable SELECT_SEASON()
        {
            string Proc_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory_h.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private System.Data.DataTable SELECT_BOM_CD()
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXB_PJ_BOM.SELECT_SXB_BOM_CD";

                OraDB.ReDim_Parameter(2);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = cmb_factory_h.SelectedValue.ToString();
                OraDB.Parameter_Values[1] = "";

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
        private System.Data.DataTable SELECT_TD(string arg_factory)
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_01_SELECT.SELECT_TD_LIST";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

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
        private System.Data.DataTable SELECT_LOADUSER()
        {
            string Proc_Name = "PKG_SXG_MPS_01_SELECT.SELECT_USER";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory_h.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private System.Data.DataTable SELECT_HUSER_LIST(string arg_factory, string arg_dept_div, string arg_user_name)
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_01_SELECT.SELECT_HUSER_LIST";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_DEPT_DIV";
            OraDB.Parameter_Name[2] = "ARG_USER_NAME";
            OraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_dept_div;
            OraDB.Parameter_Values[2] = arg_user_name;
            OraDB.Parameter_Values[3] = "";

            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        #endregion

        #region Search
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        { 
            try
            {                
                flg_project.Rows.Count = flg_project.Rows.Fixed;

                string[] arg_value = new string[8];

                arg_value[0] = cmb_factory_h.SelectedValue.ToString();
                arg_value[1] = cmb_category_h.SelectedValue.ToString();
                arg_value[2] = cmb_season_h.SelectedValue.ToString();
                arg_value[3] = txt_sr_no_h.Text.Trim();
                arg_value[4] = txt_srf_no_h.Text.Trim();
                arg_value[5] = txt_bom_id_h.Text.Trim();
                arg_value[6] = cmb_sampetyps_h.SelectedValue.ToString();
                arg_value[7] = cmb_devuser_h.SelectedValue.ToString();

                System.Data.DataTable dt = SEARCH_DATA(arg_value);

                if (dt.Rows.Count > 0)
                {
                    Display_Data(dt);

                    flg_project.Select(flg_project.Rows.Fixed, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME);
                    MouseEventArgs _mouse = new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0);
                    flg_project_MouseClick(null, _mouse);
                    flg_project.Tree.Show(0);
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

        private void Display_Data(System.Data.DataTable arg_dt)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                int t_level = int.Parse(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_WS_DEV_VJ.IxT_LEVEL].ToString());
                flg_project.Rows.InsertNode(flg_project.Rows.Count, t_level);

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    flg_project[flg_project.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                }

                #region Grid Style Setting
                if (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_WS_DEV_VJ.IxT_LEVEL].Equals("0"))
                    flg_project.Rows[flg_project.Rows.Count - 1].StyleNew.BackColor = Color.White;      // 1 Level
                else
                    flg_project.Rows[flg_project.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke; // 2 Level           

                //Status - Normal
                if (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Equals("N"))
                    flg_project.Rows[flg_project.Rows.Count - 1].AllowEditing = true;
                else
                {
                    //Status - Return
                    if (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Equals("R"))
                    {
                        flg_project.GetCellRange(flg_project.Rows.Count - 1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS).StyleNew.BackColor = Color.Red;
                        flg_project.Rows[flg_project.Rows.Count - 1].AllowEditing = true;
                    }
                    //Status - Confirm
                    else if (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Equals("C"))
                    {
                        flg_project.GetCellRange(flg_project.Rows.Count - 1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS).StyleNew.BackColor = Color.FromArgb(245, 173, 173);
                        flg_project.Rows[flg_project.Rows.Count - 1].AllowEditing = false;
                    }
                    //Status - Retry
                    else if (arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Equals("T"))
                    {
                        flg_project.GetCellRange(flg_project.Rows.Count - 1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS).StyleNew.BackColor = Color.Yellow;
                        flg_project.Rows[flg_project.Rows.Count - 1].AllowEditing = false;
                    }
                    else
                        flg_project.Rows[flg_project.Rows.Count - 1].AllowEditing = false;
                }

                //Copy User
                string upload_user = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_WS_DEV_VJ.IxLOAD_UPD_USER].ToString();
                string copy_user   = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_WS_DEV_VJ.IxCOPY_USER].ToString();
                string lot_seq     = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();

                if (!lot_seq.Equals("00") && upload_user != copy_user)
                    flg_project.GetCellRange(flg_project.Rows.Count - 1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOAD_UPD_USER).StyleNew.BackColor = Color.Red;
                #endregion
            } 
        }

        private System.Data.DataTable SEARCH_DATA(string [] arg_value)
        {
            string Proc_Name = "PKG_SXG_MPS_01_SELECT.SELECT_SXE_BOM_LOT_INFO_01";

            OraDB.ReDim_Parameter(9);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_CATEGORY";
            OraDB.Parameter_Name[2] = "ARG_SEASON";
            OraDB.Parameter_Name[3] = "ARG_SR_NO";
            OraDB.Parameter_Name[4] = "ARG_SRF_NO";
            OraDB.Parameter_Name[5] = "ARG_BOM_ID";
            OraDB.Parameter_Name[6] = "ARG_NF_CD";
            OraDB.Parameter_Name[7] = "ARG_LOAD_UPD_USER";
            OraDB.Parameter_Name[8] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[8] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_value[0];
            OraDB.Parameter_Values[1] = arg_value[1];
            OraDB.Parameter_Values[2] = arg_value[2];
            OraDB.Parameter_Values[3] = arg_value[3];
            OraDB.Parameter_Values[4] = arg_value[4];
            OraDB.Parameter_Values[5] = arg_value[5];
            OraDB.Parameter_Values[6] = arg_value[6];
            OraDB.Parameter_Values[7] = arg_value[7];
            OraDB.Parameter_Values[8] = "";


            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }        
        #endregion

        #region Save
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Default;

                int sct_col = flg_project.Selection.c1;
                int sct_row = flg_project.Selection.r1;

                
                for (int i = flg_project.Rows.Fixed; i < flg_project.Rows.Count; i++)
                {                    
                    #region OP Setting
                    if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString().Trim() != "")
                    {
                        if (!Op_Check(i))
                        {
                            flg_project.Select(i, sct_col);
                            click_flg = true;
                            Set_DataToControl(i);
                            click_flg = false;
                            return;
                        }
                    }
                    #endregion

                    #region Insert Record
                    if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString().Trim() == "I")
                    {
                        #region Data Check
                        if (!Check_Save_Specification(i))
                            return;

                        //OP Check
                        string opcd_check = "false";
                        for (int k = (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING; k < (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY; k++)
                        {
                            if (flg_project[i, k].ToString() == "true")
                            {
                                opcd_check = flg_project[i, k].ToString();
                                break;
                            }
                        }
                        if (opcd_check == "false")
                        {
                            MessageBox.Show("Select Process Code");
                            flg_project.Select(i, sct_col);
                            Set_DataToControl(i);
                            return;
                        }
                        #endregion

                        Save_Project_Specification(i);

                        System.Data.DataTable dt = get_lot_seq(i);
                        flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ] = dt.Rows[0].ItemArray[0].ToString();
                        flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO]   = dt.Rows[0].ItemArray[1].ToString();

                        Save_Opcd(i);

                        if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWH_COVER].ToString() == "True")
                        {
                            Insert_Excel(i);
                            Save_Excel("I", i);
                            Upload_Excel_OtherServer(i);
                        }

                    }
                    #endregion

                    #region Update Record
                    else if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() == "U")
                    {
                        #region Save Check
                        if (!Check_Save_Specification(i))
                        {
                            return;
                        }
                        
                        //OP Check
                        string opcd_check = "false";
                        for (int k = (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING; k < (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY; k++)
                        {
                            if (flg_project[i, k].ToString() == "true")
                            {
                                opcd_check = flg_project[i, k].ToString();
                                break;
                            }
                        }
                        if (opcd_check == "false")
                        {
                            MessageBox.Show("Select Process Code");
                            flg_project.Select(i, sct_col);
                            Set_DataToControl(i);
                            return;
                        }

                        //Check
                        if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWH_COVER].ToString().Equals("True"))
                        {
                            string file_path = flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFILE_PATH].ToString().Replace(" ", "").Replace("/", "");
                            if (!Save_Excel_Check(file_path))
                                return;
                        }
                        
                        if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN].ToString() == "True")
                        {
                            if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_CHK].ToString().Equals("False"))
                            {
                                MessageBox.Show("Select Product BOM Code");
                                flg_project.Select(i, sct_col);
                                click_flg = true;
                                Set_DataToControl(i);
                                click_flg = false;
                                return;
                            }
                            else if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWH_COVER].ToString().Equals("False"))
                            {
                                MessageBox.Show("Worksheet File is not exist");
                                flg_project.Select(i, sct_col);
                                click_flg = true;
                                Set_DataToControl(i);
                                click_flg = false;
                                return;
                            }

                        }
                        #endregion

                        #region Data Save
                        if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN].ToString() == "True")
                        {
                            Save_Project_Specification(i);

                            if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Trim().Equals("T"))
                            {
                                string[] arg_value = new string[10];
                                arg_value[0] = "I";
                                arg_value[1] = flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString().Trim();
                                arg_value[2] = flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Trim();
                                arg_value[3] = flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Trim();
                                arg_value[4] = cmb_p_bom.SelectedValue.ToString();
                                arg_value[5] = "";
                                arg_value[6] = "";
                                arg_value[7] = dtp_ets.Value.ToString("yyyyMMdd");
                                arg_value[8] = "0";
                                arg_value[9] = COM.ComVar.This_User;

                                #region OP Save
                                if (chk_fga.Enabled)
                                {
                                    arg_value[5] = "FG";
                                    arg_value[6] = "FGA";
                                    arg_value[8] = txt_fga.Text.Trim();

                                    if (!chk_fga.Checked)
                                        arg_value[0] = "D";
                                    else
                                        arg_value[0] = "I";

                                    SAVE_RETURN_DATA(arg_value);
                                }
                                if (chk_fss.Enabled)
                                {
                                    arg_value[5] = "FS";
                                    arg_value[6] = "FSS";
                                    arg_value[8] = txt_fss.Text.Trim();

                                    if (!chk_fss.Checked)
                                        arg_value[0] = "D";
                                    else
                                        arg_value[0] = "I";

                                    SAVE_RETURN_DATA(arg_value);
                                }
                                if (chk_ups.Enabled)
                                {
                                    arg_value[5] = "UP";
                                    arg_value[6] = "UPS";
                                    arg_value[8] = txt_ups.Text.Trim();

                                    if (!chk_ups.Checked)
                                        arg_value[0] = "D";
                                    else
                                        arg_value[0] = "I";

                                    SAVE_RETURN_DATA(arg_value);
                                }
                                if (chk_ems.Enabled)
                                {
                                    arg_value[5] = "EM01";
                                    arg_value[6] = "EMS";
                                    arg_value[8] = txt_ems.Text.Trim();

                                    if (!chk_ems.Checked)
                                        arg_value[0] = "D";
                                    else
                                        arg_value[0] = "I";

                                    SAVE_RETURN_DATA(arg_value);
                                }
                                if (chk_abs.Enabled)
                                {
                                    arg_value[5] = "AB01";
                                    arg_value[6] = "ABS";
                                    arg_value[8] = txt_abs.Text.Trim();

                                    if (!chk_abs.Checked)
                                        arg_value[0] = "D";
                                    else
                                        arg_value[0] = "I";

                                    SAVE_RETURN_DATA(arg_value);
                                }
                                if (chk_upe.Enabled)
                                {
                                    arg_value[5] = "UP02";
                                    arg_value[6] = "UPE";
                                    arg_value[8] = txt_upe.Text.Trim();

                                    if (!chk_upe.Checked)
                                        arg_value[0] = "D";
                                    else
                                        arg_value[0] = "I";

                                    SAVE_RETURN_DATA(arg_value);
                                }
                                if (chk_os.Enabled)
                                {
                                    arg_value[5] = "OS01";
                                    arg_value[6] = "OSP";
                                    arg_value[8] = txt_os.Text.Trim();

                                    if (!chk_os.Checked)
                                        arg_value[0] = "D";
                                    else
                                        arg_value[0] = "I";

                                    SAVE_RETURN_DATA(arg_value);
                                }
                                if (chk_ip.Enabled)
                                {
                                    arg_value[5] = "IP01";
                                    arg_value[6] = "IPS";
                                    arg_value[8] = txt_ip.Text.Trim();

                                    if (!chk_ip.Checked)
                                        arg_value[0] = "D";
                                    else
                                        arg_value[0] = "I";

                                    SAVE_RETURN_DATA(arg_value);
                                }
                                if (chk_pu.Enabled)
                                {
                                    arg_value[5] = "PU01";
                                    arg_value[6] = "PUS";
                                    arg_value[8] = txt_pu.Text.Trim();

                                    if (!chk_pu.Checked)
                                        arg_value[0] = "D";
                                    else
                                        arg_value[0] = "I";

                                    SAVE_RETURN_DATA(arg_value);
                                }
                                if (chk_ph.Enabled)
                                {
                                    arg_value[5] = "PH01";
                                    arg_value[6] = "PHC";
                                    arg_value[8] = txt_ph.Text.Trim();

                                    if (!chk_ph.Checked)
                                        arg_value[0] = "D";
                                    else
                                        arg_value[0] = "I";

                                    SAVE_RETURN_DATA(arg_value);
                                }
                                if (chk_cutting.Enabled)
                                {
                                    arg_value[5] = "UP01";
                                    arg_value[6] = "UPC";
                                    arg_value[8] = txt_cutting.Text.Trim();

                                    if (!chk_cutting.Checked)
                                        arg_value[0] = "D";
                                    else
                                        arg_value[0] = "I";

                                    SAVE_RETURN_DATA(arg_value);
                                }
                                #endregion
                            }
                            else
                            {
                                Save_Opcd(i);
                                Save_mps_lot_daily("Y", i);
                            }
                            string req_ymd = get_req_ymd().Rows[0].ItemArray[0].ToString();
                            flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YMD] = req_ymd;
                            Save_Excel("S", i);
                            Upload_Excel_OtherServer(i);
                        }
                        else
                        {
                            Save_Project_Specification(i);
                            Save_Opcd(i);
                            if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWH_COVER].ToString() == "True")
                            {
                                Save_Excel("S", i);
                                Upload_Excel_OtherServer(i);
                            }
                        }
                        #endregion
                    }
                    #endregion

                    #region Delete Record
                    else if (flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() == "D")
                    {
                        save_lot("D", i);
                    }
                    #endregion

                    flg_project[i, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "";
                }

                tbtn_Search_Click(null, null);

                flg_project.Tree.Show(1);

                try
                {
                    flg_project.Select(sct_row, sct_col);
                }
                catch
                {
 
                }

                click_flg = true;
                Set_DataToControl(sct_row);
                click_flg = false;
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
        
        private void Insert_Excel(int arg_sct_row)
        {
           
            string old_file_path = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFILE_PATH].ToString().Replace(" ", "").Replace("/", "");
            FileInfo fi = new FileInfo(old_file_path);

            string _sr_no   = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
            string _srf_no  = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
            string _bom_id  = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Replace(" ", "");
            string _lot_no  = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Replace(" ", "");
            string _lot_seq = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

            string file_dir  = server_path + _srf_no + "\\";
            string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
            string file_path = file_dir + file_name;          
            
            // Determine whether the directory exists.
            if (!Directory.Exists(file_dir))
            {
                DirectoryInfo di = Directory.CreateDirectory(file_dir);
            }


            fi.CopyTo(file_path, true);
            Update_Spec_File(flg_project.Selection.r1, file_path);
            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFILE_PATH] = file_path;
            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWH_COVER] = "True";           
        }
        private void Save_Excel(string arg_division, int arg_sct_row)
        {

            if (arg_division == "S")
            {
                #region 
                string file_path_old = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFILE_PATH].ToString().Replace(" ", "").Replace("/", "");
                FileInfo old_file = new FileInfo(file_path_old);


                if (!old_file.Exists)
                {
                    MessageBox.Show("This File is not existed, Please ask System.");
                    return;
                }


                string _sr_no   = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
                string _srf_no  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
                string _bom_id  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Replace(" ", "");
                string _lot_no  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Replace(" ", "");
                string _lot_seq = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                string file_dir  = server_path + _srf_no + "\\";
                string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                string file_path = file_dir + file_name;          


                
                // Determine whether the directory exists.
                if (!Directory.Exists(file_dir))
                {
                    DirectoryInfo di = Directory.CreateDirectory(file_dir);
                }

                if (file_path_old != file_path)
                {
                    old_file.CopyTo(file_path, true);
                    old_file.Delete();
                }
                #endregion

                application = new Microsoft.Office.Interop.Excel.Application();

                workbook = (Workbook)(application.Workbooks.Open(file_path, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));
                worksheet = workbook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;

                string _status = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Trim();


                #region 

                #region 
                worksheet.Cells[2, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
                worksheet.Cells[3, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxETS].ToString();
                worksheet.Cells[4, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME].ToString();
                worksheet.Cells[5, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
                worksheet.Cells[6, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCATEGORY].ToString();
                worksheet.Cells[7, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMTO_ACC].ToString();
                worksheet.Cells[8, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSEASON_CD].ToString();
                worksheet.Cells[9, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSIZE_CD].ToString() + "/" + flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxGEN_NAME].ToString();
                worksheet.Cells[10, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWHQ_DEV].ToString();
                worksheet.Cells[11, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDEV_PROD].ToString();
                
                string style_cd = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_CD].ToString().Trim();
                string bom_id = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString();
                if (style_cd == "")
                {
                    worksheet.Cells[12, 3] = bom_id;
                }
                else
                {
                    worksheet.Cells[12, 3] = bom_id + "/" + style_cd; 
                }
                
                
                //worksheet.Cells[12, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_STYLE].ToString();


                worksheet.Cells[13, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLASTING_ME].ToString();
                worksheet.Cells[14, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMS_ME].ToString();
                worksheet.Cells[15, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSOLELAYING].ToString();
                worksheet.Cells[16, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCOLOR_VER].ToString();
                worksheet.Cells[17, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLAST_CD].ToString();
                worksheet.Cells[18, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPATTERN].ToString();
                worksheet.Cells[19, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTL_FILE].ToString();
                worksheet.Cells[20, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSAMPLE_TPYES].ToString().Replace("\r\n", "");
                
                worksheet.Cells[2, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSAMPLE_WEI].ToString();
                worksheet.Cells[3, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCOLLAR_HEI].ToString();
                worksheet.Cells[4, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHEEL_HEI].ToString();
                worksheet.Cells[5, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMEDIAL_HEI].ToString();
                worksheet.Cells[6, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLATERAL_HEI].ToString();
                worksheet.Cells[7, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLACE_LENGTH].ToString();
                worksheet.Cells[8, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMS_HARDNESS].ToString();
                worksheet.Cells[9, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIDS_LENGTH].ToString();
                worksheet.Cells[10, 15] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBARCODE_DATE].ToString();
                worksheet.Cells[11, 15] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWIDTH].ToString();
                worksheet.Cells[12, 15] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxUPPER_MAT].ToString();
                worksheet.Cells[16, 15] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLACE_DESC].ToString();
                worksheet.Cells[17, 15] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxINSOLE_DESC].ToString();
                
                worksheet.Cells[2, 22]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YMD].ToString();
                worksheet.Cells[3, 22]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxETS].ToString();

                System.Data.DataTable dt_dev = Get_cdc_dev_kname(flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString(), flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString(), flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString());
                string _cdc_dev = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_DEV].ToString();

                if (dt_dev.Rows.Count > 0)
                {
                    if (dt_dev.Rows[0].ItemArray[0].ToString().Trim() != "")
                    {
                        _cdc_dev = dt_dev.Rows[0].ItemArray[0].ToString().Trim();
                    }
                }
                
                
                worksheet.Cells[4, 22]  = _cdc_dev;
                worksheet.Cells[5, 22]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxNLO_DEV].ToString();
                worksheet.Cells[6, 22]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                worksheet.Cells[7, 22]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDISPATCH_QTY].ToString();
                worksheet.Cells[11, 21] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFIT].ToString();

                string mat_ymd = (worksheet.get_Range(worksheet.Cells[21, 1], worksheet.Cells[21, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 1], worksheet.Cells[21, 1]).Value2.ToString().Trim();

                if(mat_ymd.Equals("Material"))
                    worksheet.Cells[22, 1] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMAT_LEADTIME].ToString();

                #endregion

                #region OP Setting

                int excel_start_row = 21;
                int excel_final_row = 70;

                for (int i = excel_start_row; i < excel_final_row; i++)
                {
                    string op = "";
                    string op_yn = "";
                    string op_qty = "";
                    string op_name = "";

                    try
                    {
                        op = (worksheet.get_Range(worksheet.Cells[i, 1], worksheet.Cells[i, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[i, 1], worksheet.Cells[i, 1]).Value2.ToString();
                        op_yn = (worksheet.get_Range(worksheet.Cells[i + 1, 1], worksheet.Cells[i + 1, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[i + 1, 1], worksheet.Cells[i + 1, 1]).Value2.ToString();
                        op_qty = (worksheet.get_Range(worksheet.Cells[i + 2, 1], worksheet.Cells[i + 2, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[i + 2, 1], worksheet.Cells[i + 2, 1]).Value2.ToString();
                    }
                    catch
                    {
                        op = "";
                    }
                    if (op.Equals("Operation"))
                    {
                        if (op_yn.Equals("Set"))
                        {
                            if (op_qty.Equals("Qty"))
                            {

                                for (int j = 2; j < 25; j++)
                                {
                                    try
                                    {
                                        op_name = (worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Value2.ToString().Replace("\n", "").Replace("\n", "");
                                    }
                                    catch
                                    {
                                        op_name = "";
                                    }

                                    if (op_name.Equals("Cutting"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_cutting.Enabled && chk_cutting.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("Embroidery"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_upe.Enabled && chk_upe.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("EMS"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ems.Enabled && chk_ems.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }


                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP].ToString().Equals("true")) ? "O" : "X";
                                        worksheet.Cells[i, j] = "H/P";
                                    }
                                    if (op_name.Equals("H/P"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ems.Enabled && chk_ems.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }


                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("Stitching"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ups.Enabled && chk_ups.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("OS"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_os.Enabled && chk_os.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("P/R(OS)"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_os.Enabled && chk_os.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS].ToString().Equals("true")) ? "O" : "X";
                                        worksheet.Cells[i, j] = "OS";
                                    }
                                    if (op_name.Equals("IP"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ip.Enabled && chk_ip.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("P/H(CMP)"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ph.Enabled && chk_ph.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS].ToString().Equals("true")) ? "O" : "X";
                                        worksheet.Cells[i, j] = "P/H";
                                    }
                                    if (op_name.Equals("P/H"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ph.Enabled && chk_ph.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("H/F"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_abs.Enabled && chk_abs.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF].ToString().Equals("true")) ? "O" : "X";

                                    }
                                    if (op_name.Equals("Spray"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_abs.Enabled && chk_abs.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF].ToString().Equals("true")) ? "O" : "X";
                                        worksheet.Cells[i, j] = "H/F";
                                    }
                                    if (op_name.Equals("PU"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_pu.Enabled && chk_pu.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("Stockfit"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_fss.Enabled && chk_fss.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("Assembly"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_fga.Enabled && chk_fga.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY].ToString().Equals("true")) ? "O" : "X";
                                    }
                                }
                            }
                        }
                    }
                }


                #endregion               

                               
                application.Visible = false;
                application.DisplayAlerts = false;

                try
                {
                    worksheet.SaveAs(file_path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                workbook.Close(false, file_path_old, null);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                application.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
               
                GC.Collect();
                #endregion

                Update_Spec_File(arg_sct_row, file_path);
            }
            else
            {
                string _sr_no   = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
                string _srf_no  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
                string _bom_id  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Replace(" ", "");
                string _lot_no  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Replace(" ", "");
                string _lot_seq = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                string file_dir  = server_path + _srf_no + "\\";
                string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                string file_path = file_dir + file_name;
                
                application = new Microsoft.Office.Interop.Excel.Application();
                workbook = (Workbook)(application.Workbooks.Open(file_path, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));

                worksheet = workbook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;

                string _status = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Trim();

                #region 
                worksheet.Cells[2, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
                worksheet.Cells[3, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxETS].ToString();
                worksheet.Cells[4, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME].ToString();
                worksheet.Cells[5, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
                worksheet.Cells[6, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCATEGORY].ToString();
                worksheet.Cells[7, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMTO_ACC].ToString();
                worksheet.Cells[8, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSEASON_CD].ToString();
                worksheet.Cells[9, 3]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSIZE_CD].ToString() + "/" + flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxGEN_NAME].ToString();
                worksheet.Cells[10, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWHQ_DEV].ToString();
                worksheet.Cells[11, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDEV_PROD].ToString();


                string style_cd = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_CD].ToString().Trim();
                string bom_id = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString();
                if (style_cd == "")
                {
                    worksheet.Cells[12, 3] = bom_id;
                }
                else
                {
                    worksheet.Cells[12, 3] = bom_id + "/" + style_cd;
                }

                //worksheet.Cells[12, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_STYLE].ToString();

                worksheet.Cells[13, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLASTING_ME].ToString();
                worksheet.Cells[14, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMS_ME].ToString();
                worksheet.Cells[15, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSOLELAYING].ToString();
                worksheet.Cells[16, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCOLOR_VER].ToString();
                worksheet.Cells[17, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLAST_CD].ToString();
                worksheet.Cells[18, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPATTERN].ToString();
                worksheet.Cells[19, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTL_FILE].ToString();
                worksheet.Cells[20, 3] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSAMPLE_TPYES].ToString().Replace("\r\n", "");


                worksheet.Cells[2, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSAMPLE_WEI].ToString();
                worksheet.Cells[3, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCOLLAR_HEI].ToString();
                worksheet.Cells[4, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHEEL_HEI].ToString();
                worksheet.Cells[5, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMEDIAL_HEI].ToString();
                worksheet.Cells[6, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLATERAL_HEI].ToString();
                worksheet.Cells[7, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLACE_LENGTH].ToString();
                worksheet.Cells[8, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMS_HARDNESS].ToString();
                worksheet.Cells[9, 15]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIDS_LENGTH].ToString();
                worksheet.Cells[10, 15] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBARCODE_DATE].ToString();
                worksheet.Cells[11, 15] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWIDTH].ToString();
                worksheet.Cells[12, 15] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxUPPER_MAT].ToString();
                worksheet.Cells[16, 15] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLACE_DESC].ToString();
                worksheet.Cells[17, 15] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxINSOLE_DESC].ToString();


                worksheet.Cells[2, 22]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YMD].ToString();
                worksheet.Cells[3, 22]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxETS].ToString();


                System.Data.DataTable dt_dev = Get_cdc_dev_kname(flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString(), flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString(), flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString());
                string _cdc_dev = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_DEV].ToString();

                if (dt_dev.Rows.Count > 0)
                {
                    if (dt_dev.Rows[0].ItemArray[0].ToString().Trim() != "")
                    {
                        _cdc_dev = dt_dev.Rows[0].ItemArray[0].ToString().Trim();
                    }
                }


                worksheet.Cells[4, 22] = _cdc_dev;
                worksheet.Cells[5, 22]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxNLO_DEV].ToString();
                worksheet.Cells[6, 22]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                worksheet.Cells[7, 22]  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDISPATCH_QTY].ToString();
                worksheet.Cells[11, 21] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFIT].ToString();

                string mat_ymd = (worksheet.get_Range(worksheet.Cells[21, 1], worksheet.Cells[21, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[21, 1], worksheet.Cells[21, 1]).Value2.ToString().Trim();

                if (mat_ymd.Equals("Material"))
                    worksheet.Cells[22, 1] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMAT_LEADTIME].ToString();

                #region OP Setting

                int excel_start_row = 21;
                int excel_final_row = 70;

                for (int i = excel_start_row; i < excel_final_row; i++)
                {
                    string op = "";
                    string op_yn = "";
                    string op_qty = "";
                    string op_name = "";

                    try
                    {
                        op = (worksheet.get_Range(worksheet.Cells[i, 1], worksheet.Cells[i, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[i, 1], worksheet.Cells[i, 1]).Value2.ToString();
                        op_yn = (worksheet.get_Range(worksheet.Cells[i + 1, 1], worksheet.Cells[i + 1, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[i + 1, 1], worksheet.Cells[i + 1, 1]).Value2.ToString();
                        op_qty = (worksheet.get_Range(worksheet.Cells[i + 2, 1], worksheet.Cells[i + 2, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[i + 2, 1], worksheet.Cells[i + 2, 1]).Value2.ToString();
                    }
                    catch
                    {
                        op = "";
                    }
                    if (op.Equals("Operation"))
                    {
                        if (op_yn.Equals("Set"))
                        {
                            if (op_qty.Equals("Qty"))
                            {

                                for (int j = 2; j < 25; j++)
                                {
                                    try
                                    {
                                        op_name = (worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Value2.ToString().Replace("\n", "").Replace("\n", "");
                                    }
                                    catch
                                    {
                                        op_name = "";
                                    }

                                    if (op_name.Equals("Cutting"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_cutting.Enabled && chk_cutting.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("Embroidery"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_upe.Enabled && chk_upe.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("EMS"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ems.Enabled && chk_ems.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }


                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP].ToString().Equals("true")) ? "O" : "X";
                                        worksheet.Cells[i, j] = "H/P";
                                    }
                                    if (op_name.Equals("H/P"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ems.Enabled && chk_ems.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }


                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("Stitching"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ups.Enabled && chk_ups.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("OS"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_os.Enabled && chk_os.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("P/R(OS)"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_os.Enabled && chk_os.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS].ToString().Equals("true")) ? "O" : "X";
                                        worksheet.Cells[i, j] = "OS";
                                    }
                                    if (op_name.Equals("IP"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ip.Enabled && chk_ip.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("P/H(CMP)"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ph.Enabled && chk_ph.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS].ToString().Equals("true")) ? "O" : "X";
                                        worksheet.Cells[i, j] = "P/H";
                                    }
                                    if (op_name.Equals("P/H"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_ph.Enabled && chk_ph.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("H/F"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_abs.Enabled && chk_abs.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF].ToString().Equals("true")) ? "O" : "X";
                                        
                                    }
                                    if (op_name.Equals("Spray"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_abs.Enabled && chk_abs.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF].ToString().Equals("true")) ? "O" : "X";
                                        worksheet.Cells[i, j] = "H/F";
                                    }
                                    if (op_name.Equals("PU"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_pu.Enabled && chk_pu.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("Stockfit"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_fss.Enabled && chk_fss.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT].ToString().Equals("true")) ? "O" : "X";
                                    }
                                    if (op_name.Equals("Assembly"))
                                    {
                                        if (_status.Equals("T"))
                                        {
                                            if (chk_fga.Enabled && chk_fga.Checked)
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 3;
                                            }
                                            else
                                            {
                                                worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                            }
                                        }
                                        else
                                        {
                                            worksheet.get_Range(worksheet.Cells[i, j], worksheet.Cells[i, j]).Font.ColorIndex = 1;
                                        }

                                        worksheet.Cells[i + 2, j] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY_QTY].ToString();
                                        worksheet.Cells[i + 1, j] = (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY].ToString().Equals("true")) ? "O" : "X";
                                    }
                                }
                            }
                        }
                    }
                }


                #endregion               

                application.Visible = false;
                application.DisplayAlerts = false;

                try
                {
                    worksheet.SaveAs(file_path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                workbook.Close(false, file_path, null);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                application.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

                GC.Collect();
                #endregion

            }
           
        }
        private bool Save_Excel_Check(string arg_file_name)
        {

            application = new Microsoft.Office.Interop.Excel.Application();
            workbook = (Workbook)(application.Workbooks.Open(arg_file_name, Type.Missing, Type.Missing,

                                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,

                                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));

            worksheet = workbook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;

            //Format Check
            string sample_request = (worksheet.get_Range(worksheet.Cells[2, 1], worksheet.Cells[2, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[2, 1], worksheet.Cells[2, 1]).Value2.ToString();
            string sample_type    = (worksheet.get_Range(worksheet.Cells[20, 1], worksheet.Cells[20, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 1], worksheet.Cells[20, 1]).Value2.ToString();
            string sample_wei     = (worksheet.get_Range(worksheet.Cells[2, 10], worksheet.Cells[2, 10]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[2, 10], worksheet.Cells[2, 10]).Value2.ToString();
            string insole         = (worksheet.get_Range(worksheet.Cells[17, 10], worksheet.Cells[17, 10]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 10], worksheet.Cells[17, 10]).Value2.ToString();

            if (sample_request != "Sample Request" || sample_type != "Sample Type" || sample_wei != "Sample Weight" || insole != "Insole")
            {
                MessageBox.Show("Wrong Format : Please Check Excel File");
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                workbook.Close(false, arg_file_name, null);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                application.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

                GC.Collect();
                return false;
            }
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            workbook.Close(false, arg_file_name, null);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            application.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

            GC.Collect();
            return true;
        }
        private void Upload_Excel_OtherServer(int arg_row)
        {
            try
            {
                #region 서버에 올린 파일
                string _sr_no   = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
                string _srf_no  = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
                string _bom_id  = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Replace(" ", "");
                string _lot_no  = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Replace(" ", "");
                string _lot_seq = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                string file_dir  = server_path + _srf_no + "\\";
                string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                string file_path = file_dir + file_name;

                FileInfo file = new FileInfo(file_path);

                if (!file.Exists)
                {
                    MessageBox.Show("This file is not exist");
                    return;
                }

                string uploadfile_dir = File_Bakcup + _srf_no + "\\";

                if (!Directory.Exists(uploadfile_dir))
                {
                    DirectoryInfo di = Directory.CreateDirectory(uploadfile_dir);
                }

                string uploadfilepath = uploadfile_dir + file_name.Replace(" ", "");
                file.CopyTo(uploadfilepath, true);
                #endregion
            }
            catch
            {
 
            }
        }
        private bool Check_Save_Specification(int arg_row)
        {
            try
            {
                string factory = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString();
                string ets     = (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxETS] == null) ? "" :flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxETS].ToString().Trim();

                #region ETS Check
                if (ets.Equals(""))
                {
                    MessageBox.Show("Please Insert Complete Date.");
                    return false;
                }

                System.Data.DataTable dt = GET_HOLIDAY_YN(factory, ets);

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0].ItemArray[0].ToString() == "Y")
                    {
                        MessageBox.Show("This Date is holiday");
                        return false;
                    }
                }

                if (chk_ph.Checked || chk_pu.Checked || chk_ip.Checked || chk_os.Checked || chk_abs.Checked || chk_ems.Checked)
                {
                    dt = SELECT_CONFIRM_DATE();

                    int confirm_date = int.Parse(dt.Rows[0].ItemArray[0].ToString().Trim());
                    int limit_date   = int.Parse(dt.Rows[0].ItemArray[1].ToString().Trim());
                    int stop_date    = int.Parse(dt.Rows[0].ItemArray[2].ToString().Trim());                    
                    int ets_date     = int.Parse(dtp_ets.Value.ToString("yyyyMMdd"));


                    if (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN].ToString() == "True")
                    {
                        if (ets_date <= confirm_date)
                        {
                            MessageBox.Show("Input Error : This date is already confirmed");
                            return false;
                        }
                    }
                    if (ets_date <= limit_date)
                    {
                        if (ets_date <= stop_date)
                        {
                            MessageBox.Show("Complete Date is too early.");
                            return false;
                        }
                        else
                        {
                            DialogResult dr01 = MessageBox.Show("Complete Date is too early.\r\nDo you want continue?", "Exclamation", MessageBoxButtons.YesNo);

                            if (dr01 == DialogResult.No)
                            {
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    dt = SELECT_UPPER_CONFIRM_DATE();

                    int confirm_date = int.Parse(dt.Rows[0].ItemArray[0].ToString().Trim());
                    int limit_date   = int.Parse(dt.Rows[0].ItemArray[1].ToString().Trim());
                    int stop_date    = int.Parse(dt.Rows[0].ItemArray[2].ToString().Trim());                    
                    int ets_date     = int.Parse(dtp_ets.Value.ToString("yyyyMMdd"));

                    if (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN].ToString() == "True")
                    {
                        if (ets_date <= confirm_date)
                        {
                            MessageBox.Show("Input Error : This date is already confirmed");
                            return false;
                        }
                    }
                    if (ets_date <= limit_date)
                    {
                        if (ets_date <= stop_date)
                        {
                            MessageBox.Show("Complete Date is too early.");
                            return false;
                        }
                        else
                        {
                            DialogResult dr01 = MessageBox.Show("Complete Date is too early.\r\nDo you want continue?", "Exclamation", MessageBoxButtons.YesNo);

                            if (dr01 == DialogResult.No)
                            {
                                return false;
                            }

                        }
                    }
                }
                #endregion

                #region Model Info Check
                //Model Name
                if (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME] == null || flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME].ToString().Trim() == "")
                {
                    MessageBox.Show("Input Error : Dev.Model Name is empty.");
                    flg_project.Select(arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME);
                    Set_DataToControl(arg_row);
                    txt_modelname.Focus();
                    return false;
                }
                //SRF No
                if (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO] == null || flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Trim().Replace(" ", "") == "")
                {
                    MessageBox.Show("Input Error : ModelOfferingId is empty.");
                    flg_project.Select(arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO);
                    Set_DataToControl(arg_row);
                    txt_srfno.Focus();
                    return false;
                }
                //BOM ID
                if (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID] == null || flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Trim().Replace(" ", "") == "")
                {
                    MessageBox.Show("Input Error : BOM ID is empty.");
                    flg_project.Select(arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID);
                    Set_DataToControl(arg_row);
                    txt_bom_id.Focus();
                    return false;
                }
                //Style Code
                if (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_CD] != null && flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_CD].ToString().Trim() != "" && flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_CD].ToString().Trim().Length != 9)
                {
                    MessageBox.Show("Input Error : Style Code is wrong.");
                    flg_project.Select(arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID);
                    Set_DataToControl(arg_row);
                    txt_bom_id.Focus();
                    return false;
                }
                else
                {
                    try
                    {
                        int change_to_int = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Trim().Length;
                       
                    }
                    catch
                    {
                        MessageBox.Show("Input Error : BOM ID  is wrong format.");
                        flg_project.Select(arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID);
                        Set_DataToControl(arg_row);
                        txt_bom_id.Focus();
                        return false;
                    }
                }
                //Size
                if (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSIZE_CD] == null || flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSIZE_CD].ToString().Trim() == "")
                {
                    MessageBox.Show("Input Error : Size CD is empty.");
                    flg_project.Select(arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME);
                    Set_DataToControl(arg_row);
                    txt_size.Focus();
                    return false;
                }

                if (cmb_t_d.SelectedIndex == -1 || cmb_t_d.SelectedValue == null)
                {
                    MessageBox.Show("Input Error : TD Code is empty.");
                    flg_project.Select(arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME);
                    Set_DataToControl(arg_row);
                    cmb_t_d.Focus();
                    return false;
                }

                if (cmb_gender.SelectedIndex == -1 || cmb_gender.SelectedValue == null)
                {
                    MessageBox.Show("Input Error : Gender is empty.");
                    flg_project.Select(arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME);
                    Set_DataToControl(arg_row);
                    cmb_gender.Focus();
                    return false;
                }
                #endregion

                string [] value = new string[4];                
                value[0] = (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY]      == null || flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString().Trim() == "") ? "0" : flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString().Trim();
                value[1] = (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDISPATCH_QTY] == null || flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDISPATCH_QTY].ToString().Trim() == "") ? "0" : flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDISPATCH_QTY].ToString().Trim();
                value[2] = (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxRETAIL_PRICE] == null || flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxRETAIL_PRICE].ToString().Trim() == "") ? "0" : flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxRETAIL_PRICE].ToString().Trim();
                value[3] = (flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCURRENT_FOB]  == null || flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCURRENT_FOB].ToString().Trim() == "") ? "0" : flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCURRENT_FOB].ToString().Trim();

                try
                {
                    for (int i = 0; i < 4; i++)
                    {
                        double change_to_int = Double.Parse(value[i]);
                    }
                }
                catch
                {
                    MessageBox.Show("Input Error : Please Check FGA Qty, Dispatch Qty, Retail Price, Current FOB");
                    flg_project.Select(arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME);
                    Set_DataToControl(arg_row);
                    return false;
                }

                return true;
            }
            catch
            {                
                return false; 
            }            
            
        }
        private bool Save_Project_Specification(int arg_row)
        {            
            bool vSaveFlag = false;            
                        
            vSaveFlag = Save_Specification(arg_row);

            if (!vSaveFlag)
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                return false;
            }
            else
            {                
                return true;
            }           
        }
        private void Save_Opcd(int arg_row)
        {

            string arg_factory  = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString();
            string arg_lot_no   = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
            string arg_lot_seq  = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();
            string arg_bom_cd   = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_CD].ToString();
            string arg_first_yn = "Y";

            for (int i = 0; i < 22; i++)
            {                
                int sct_col = i + (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING;

                if (flg_project[arg_row, sct_col].ToString().Equals("true"))
                {
                    if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF)
                    {
                        Save_Specific_Opcd(arg_first_yn, arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd, "UP03", "UPF", flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF_QTY].ToString());
                        arg_first_yn = "N";
                    }
                    if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY)
                    {
                        Save_Specific_Opcd(arg_first_yn, arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd, "FG", "FGA", flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY_QTY].ToString());
                        arg_first_yn = "N";
                    }
                    if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS)
                    {
                        Save_Specific_Opcd(arg_first_yn, arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd, "PH01", "PHC", flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS_QTY].ToString());
                        arg_first_yn = "N";
                    }
                    if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING)
                    {
                        Save_Specific_Opcd(arg_first_yn, arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd, "UP01", "UPC", flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING_QTY].ToString());
                        arg_first_yn = "N";
                    }
                    if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY)
                    {
                        Save_Specific_Opcd(arg_first_yn, arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd, "UP02", "UPE", flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY_QTY].ToString());
                        arg_first_yn = "N";
                    }
                    if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP)
                    {
                        Save_Specific_Opcd(arg_first_yn, arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd, "UP04", "UPH", flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP_QTY].ToString());
                        arg_first_yn = "N";
                    }
                    if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY)
                    {
                        Save_Specific_Opcd(arg_first_yn, arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd, "IP01", "IPS", flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY_QTY].ToString());
                        arg_first_yn = "N";
                    }
                    if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS)
                    {
                        Save_Specific_Opcd(arg_first_yn, arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd, "OS01", "OSP", flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS_QTY].ToString());
                        arg_first_yn = "N";
                    }
                    if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY)
                    {
                        Save_Specific_Opcd(arg_first_yn, arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd, "PU01", "PUS", flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY_QTY].ToString());
                        arg_first_yn = "N";
                    }
                    if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING)
                    {
                        Save_Specific_Opcd(arg_first_yn, arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd, "UP", "UPS", flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING_QTY].ToString());
                        arg_first_yn = "N";
                    }
                    if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT)
                    {
                        Save_Specific_Opcd(arg_first_yn, arg_factory, arg_lot_no, arg_lot_seq, arg_bom_cd, "FS", "FSS", flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT_QTY].ToString());
                        arg_first_yn = "N";
                    }
                }
                
            }
 
        }
        private bool Op_Check(int arg_row)
        {
            try
            {
                for (int i = (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING; i <= (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY_QTY; i++)
                {
                    string check = flg_project[arg_row, i].ToString();


                    if (check == "true")
                    {
                        string value= flg_project[arg_row, i + 1].ToString();

                        if (value.Equals("0"))
                        {
                            MessageBox.Show("This Operation Qty is empty");
                            return false;
                        }
                    }
                }
                
            }
            catch
            {
                return false;
            }

            return true;

        }
                
        private System.Data.DataTable SELECT_CONFIRM_DATE()
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.GET_SXG_CONFIRM_DATE";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = cmb_factory_h.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        private System.Data.DataTable SELECT_UPPER_CONFIRM_DATE()
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.GET_SXG_UPPER_CONF_DATE";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = cmb_factory_h.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        private System.Data.DataTable GET_HOLIDAY_YN(string arg_factory, string arg_date)
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_01_SELECT.GET_HOLIDAY_YN";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_DATE";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_date;
            OraDB.Parameter_Values[2] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        #endregion

        #region Print
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                string mrd_Filename = "";
                string sPara = "";

                string factory = cmb_factory_h.SelectedValue.ToString();

                string lotno = "", lotseq = "", printuser = "";


                lotno     = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
                lotseq    = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();
                printuser = ClassLib.ComVar.This_User;

                mrd_Filename = System.Windows.Forms.Application.StartupPath + @"\Report_VJ\Project_Manager_VJ" + ".mrd";
                sPara = " /rp " + "[" + factory + "]"
                                + " [" + lotno + "]"
                                + " [" + lotseq + "]"
                                + " [" + printuser + "]";

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
        private void flg_project_AfterEdit(object sender, RowColEventArgs e)
        {
            int[] sct_rows = flg_project.Selections;
            int sct_row = flg_project.Selection.r1;
            int sct_col = flg_project.Selection.c1;

            if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN)
            {
                for (int i = 0; i < sct_rows.Length; i++)
                {                    
                     flg_project.Update_Row(sct_rows[i]);
                }
            }

        }
        private void flg_project_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                if (e.Button == MouseButtons.Middle)
                    Change_Grid_Size("L");

                else if (e.Button == MouseButtons.Left)
                {                  
                    int sct_rows = flg_project.Selection.r1;
                    int sct_cols = flg_project.Selection.c1;
                    int[] _sct_rows = flg_project.Selections;

                    if (sct_cols.Equals(0) || sct_rows < flg_project.Rows.Fixed)
                        return;

                    if (flg_project.Rows.Count.Equals(flg_project.Rows.Fixed)) 
                        return;

                    Set_Control();

                    click_flg = true;
                    Set_DataToControl(sct_rows);
                    click_flg = false;                   
                    
                }
                
            }
            catch
            {
                click_flg = false;  //test
            }
        }
        private void flg_project_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(flg_project[flg_project.RowSel,2].ToString());
            try
            {            
                int sct_row = flg_project.Selection.r1;
                int sct_col = flg_project.Selection.c1;

                if (flg_project.Rows.Count == flg_project.Rows.Fixed)
                    return;

                if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString().Trim() == "I")
                {
                    MessageBox.Show("Please Save this Data");                    
                    return;
                }

                if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWH_COVER].ToString() == "False")
                    return;
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxETS ||
                   sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_QTY ||
                   sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxROUND ||
                   sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxNEED_BY ||
                   sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxREMARKS ||
                   sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN )
                    return;

                string _sr_no   = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
                string _srf_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
                string _bom_id  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Replace(" ", "");
                string _lot_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Replace(" ", "");
                string _lot_seq = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                string file_dir = server_path + _srf_no + "\\";
                string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                string file_path = file_dir + file_name;
              
                FileInfo fi = new FileInfo(file_path);
                if (!fi.Exists)
                {
                    MessageBox.Show("This File is not exist, Please ask System.");                    
                    return;
                }
                if (flg_project[flg_project.RowSel, 2].ToString() == "N" || flg_project[flg_project.RowSel, 2].ToString() == "R")
                    Process.Start("EXCEL.EXE", file_path); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Change_Grid_Size(string arg_div)
        {
            if (arg_div == "L")
            {
                if (show_head)
                {
                    pnl_head.Height = 300;
                    show_head = false;
                }
                else
                {
                    pnl_head.Height = 180;
                    show_head = true;
                }
            }
            if (arg_div == "B")
            {
                if (show_tail)
                {
                    pnl_head.Height = 140;
                    show_tail = false;
                }
                else
                {
                    pnl_head.Height = 180;
                    show_tail = true;
                }
            }
        }
        private void Set_Control()
        {
            int sct_row = flg_project.Selection.r1;

            string _bom_chk = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_CHK].ToString().ToUpper();
            string _ws_chk  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWH_COVER].ToString().ToUpper();
            string _status  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString();
            string _level   = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxT_LEVEL].ToString();

            //Always
            mnu_insert.Enabled = true;

            if (_status.Equals("N") || _status.Equals("R"))
            {
                #region Status - Normal, Return
                mnu_pattern.Enabled = true;
                mnu_release.Enabled = false;

                if (_level.Equals("0"))
                    mnu_delete.Enabled = false;
                else
                    mnu_delete.Enabled = true;

                if (_bom_chk.Equals("TRUE")) // BOM Checked
                {
                    tbtn_Print.Enabled = true;

                    mnu_upload.Enabled = true;

                    if (_ws_chk.Equals("TRUE")) //Wirksheet Checked
                    {
                        mnu_download.Enabled = true;
                        mnu_edit.Enabled     = true;
                        mnu_copy.Enabled     = true;
                        mnu_request.Enabled  = true;
                    }
                    else
                    {
                        mnu_download.Enabled = false;
                        mnu_edit.Enabled     = false;
                        mnu_copy.Enabled     = false;
                        mnu_request.Enabled  = false;
                    }

                    if (copy_excel)
                    {
                        if (sct_row == copy_row)
                            mnu_paste.Enabled = false;
                        else
                            mnu_paste.Enabled = true;
                    }
                    else
                        mnu_paste.Enabled = false;
                }
                else
                {
                    tbtn_Print.Enabled = false; 

                    mnu_upload.Enabled   = false;
                    mnu_download.Enabled = false;
                    mnu_edit.Enabled     = false;
                    mnu_copy.Enabled     = false;
                    mnu_request.Enabled  = false;

                    mnu_paste.Enabled = false;

                }
                #endregion
            }
            else
            {
                mnu_pattern.Enabled  = false;
                mnu_download.Enabled = true;
                mnu_copy.Enabled     = true;

                mnu_upload.Enabled   = false;
                mnu_edit.Enabled     = false;
                mnu_paste.Enabled    = false;
                mnu_delete.Enabled   = false;
                mnu_request.Enabled  = false;
                mnu_release.Enabled  = false;

                if (_status.Equals("Y"))//Request
                {
                    mnu_release.Enabled = true;
                }
                else if (_status.Equals("T"))//Retry
                {
                    mnu_upload.Enabled   = true;
                    mnu_edit.Enabled     = true;
                    mnu_pattern.Enabled  = true;                    
                }
            }

            if (chk_fga.Checked || _status.Equals("N") || _status.Equals("R") || _status.Equals("T") || _status.Equals("Y"))
            {
                mnu_retry.Enabled = false;
            }
            else
            {
                mnu_retry.Enabled = true;
            }
        }
        private void Set_DataToControl(int arg_sct_row)
        {
            #region Set by Level

            string _req_yn      = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN].ToString().ToUpper();
            string _upd_user    = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOAD_UPD_USER].ToString().ToLower();
            string _this_user   = COM.ComVar.This_User.ToLower();
            string _power_level = ClassLib.ComVar.This_CDCPower_Level;
            string _status      = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Trim();

            if (_req_yn.Equals("TRUE") || (_upd_user != _this_user && _power_level != "S00"))
            {
                if (_status.Equals("T") && (_upd_user == _this_user || _power_level == "S00"))
                {
                    #region Retry
                    txt_srno.Enabled              = false;
                    dtp_ets.Enabled               = true;
                    txt_style_cd.Enabled          = true;
                    txt_modelname.Enabled         = true;
                    txt_srfno.Enabled             = true;
                    cmb_category.Enabled          = true;
                    txt_mto_acc.Enabled           = true;
                    cmb_season_s.Enabled          = true;
                    txt_size.Enabled              = true;
                    cmb_gender.Enabled            = true;
                    txt_whq_dev.Enabled           = true;
                    txt_dev_prod.Enabled          = true;
                    txt_bom_id.Enabled            = true;
                    txt_lasting_method.Enabled    = true;
                    txt_midsole_method.Enabled    = true;
                    txt_solelaying_method.Enabled = true;
                    txt_colors.Enabled            = true;
                    txt_lastcd.Enabled            = true;
                    txt_pattern.Enabled           = true;
                    txt_stl_file.Enabled          = true;
                    cmb_round.Enabled             = true;
                    txt_retail_price.Enabled      = true;
                    txt_current_fob.Enabled       = true;

                    txt_sample_weight.Enabled     = true;
                    dtp_request_date.Enabled      = false;
                    txt_collar_height.Enabled     = true;
                    dtp_dispatch_date.Enabled     = true;
                    txt_heel_height.Enabled       = true;
                    txt_cdc_dev.Enabled           = false;
                    txt_medial_height.Enabled     = true;
                    txt_nike_dev.Enabled          = true;
                    txt_laterial_height.Enabled   = true;
                    txt_fag_qty.Enabled           = true;
                    txt_lace_length.Enabled       = true;
                    txt_dispatch_qty.Enabled      = true;
                    txt_midsole_hardness.Enabled  = true;
                    txt_ids_length.Enabled        = true;
                    txt_barcode_date.Enabled      = true;
                    txt_width.Enabled             = true;
                    txt_fit.Enabled               = true;
                    txt_upper_mat.Enabled         = true;
                    txt_barcode.Enabled           = true;
                    txt_lace_desc.Enabled         = true;
                    txt_insole.Enabled            = true;
                    cmb_t_d.Enabled               = true;
                    dtp_ipw.Enabled               = true;
                    chk_pcc_dd.Enabled            = true;                  
                    
                    #region  Specification opcd info
                    chk_abs.Enabled     = true;
                    chk_cutting.Enabled = true;
                    chk_ems.Enabled     = true;
                    chk_fga.Enabled     = true;
                    chk_fss.Enabled     = true;
                    chk_ip.Enabled      = true;
                    chk_os.Enabled      = true;
                    chk_ph.Enabled      = true;
                    chk_pu.Enabled      = true;
                    chk_upe.Enabled     = true;
                    chk_ups.Enabled     = true;
                    
                    for (int i = (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING; i <= (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY_QTY; i++)
                    {
                        Set_op_cd("01", flg_project.Selection.r1, i);
                        Set_op_cd("02", flg_project.Selection.r1, i);
                    }

                    string[] arg_value = new string[3];
                    arg_value[0] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString().Trim();
                    arg_value[1] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Trim();
                    arg_value[2] = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Trim();

                    System.Data.DataTable dt_ret = GET_OP_INFO(arg_value);

                    for (int op = 0; op < dt_ret.Rows.Count; op++)
                    {
                        string _op_cd = dt_ret.Rows[op].ItemArray[0].ToString().Trim();

                        if (_op_cd.Equals("ABS"))
                        {
                            chk_abs.Enabled = false;
                            txt_abs.Enabled = false;
                        }
                        else if (_op_cd.Equals("UPE"))
                        {
                            chk_upe.Enabled = false;
                            txt_upe.Enabled = false;
                        }
                        else if (_op_cd.Equals("FGA"))
                        {
                            chk_fga.Enabled = false;
                            txt_fga.Enabled = false;
                        }
                        else if (_op_cd.Equals("FSS"))
                        {
                            chk_fss.Enabled = false;
                            txt_fss.Enabled = false;
                        }
                        else if (_op_cd.Equals("EMS"))
                        {
                            chk_ems.Enabled = false;
                            txt_ems.Enabled = false;
                        }
                        else if (_op_cd.Equals("UPC"))
                        {
                            chk_cutting.Enabled = false;
                            txt_cutting.Enabled = false;
                        }
                        else if (_op_cd.Equals("UPS"))
                        {
                            chk_ups.Enabled = false;
                            txt_ups.Enabled = false;
                        }
                        else if (_op_cd.Equals("IPS"))
                        {
                            chk_ip.Enabled = false;
                            txt_ip.Enabled = false;
                        }
                        else if (_op_cd.Equals("OSP"))
                        {
                            chk_os.Enabled = false;
                            txt_os.Enabled = false;
                        }
                        else if (_op_cd.Equals("PHC"))
                        {
                            chk_ph.Enabled = false;
                            txt_ph.Enabled = false;
                        }
                        else if (_op_cd.Equals("PUS"))
                        {
                            chk_pu.Enabled = false;
                            txt_pu.Enabled = false;
                        }
                    }
                    #endregion                    
                    #endregion
                }
                else
                {
                    #region Request
                    txt_srno.Enabled              = false;
                    dtp_ets.Enabled               = false;
                    txt_style_cd.Enabled          = false;
                    txt_modelname.Enabled         = false;
                    txt_srfno.Enabled             = false;
                    cmb_category.Enabled          = false;
                    txt_mto_acc.Enabled           = false;
                    cmb_season_s.Enabled          = false;
                    txt_size.Enabled              = false;
                    cmb_gender.Enabled            = false;
                    txt_whq_dev.Enabled           = false;
                    txt_dev_prod.Enabled          = false;
                    txt_bom_id.Enabled            = false;
                    txt_lasting_method.Enabled    = false;
                    txt_midsole_method.Enabled    = false;
                    txt_solelaying_method.Enabled = false;
                    txt_colors.Enabled            = false;
                    txt_lastcd.Enabled            = false;
                    txt_pattern.Enabled           = false;
                    txt_stl_file.Enabled          = false;
                    cmb_round.Enabled             = false;
                    txt_retail_price.Enabled      = false;
                    txt_current_fob.Enabled       = false;

                    txt_sample_weight.Enabled    = false;
                    dtp_request_date.Enabled     = false;
                    txt_collar_height.Enabled    = false;
                    dtp_dispatch_date.Enabled    = false;
                    txt_heel_height.Enabled      = false;
                    txt_cdc_dev.Enabled          = false;
                    txt_medial_height.Enabled    = false;
                    txt_nike_dev.Enabled         = false;
                    txt_laterial_height.Enabled  = false;
                    txt_fag_qty.Enabled          = false;
                    txt_lace_length.Enabled      = false;
                    txt_dispatch_qty.Enabled     = false;
                    txt_midsole_hardness.Enabled = false;
                    txt_ids_length.Enabled       = false;
                    txt_barcode_date.Enabled     = false;
                    txt_width.Enabled            = false;
                    txt_fit.Enabled              = false;
                    txt_upper_mat.Enabled        = false;
                    txt_barcode.Enabled          = false;
                    txt_lace_desc.Enabled        = false;
                    txt_insole.Enabled           = false;
                    cmb_t_d.Enabled              = false;
                    dtp_ipw.Enabled              = false;
                    chk_pcc_dd.Enabled           = false;

                    #region  Specification opcd info
                    for (int i = (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING; i <= (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY_QTY; i++)
                    {
                        Set_op_cd("01", flg_project.Selection.r1, i);
                        Set_op_cd("02", flg_project.Selection.r1, i);
                    }

                    chk_abs.Enabled     = false;
                    chk_cutting.Enabled = false;
                    chk_ems.Enabled     = false;
                    chk_fga.Enabled     = false;
                    chk_fss.Enabled     = false;
                    chk_ip.Enabled      = false;
                    chk_os.Enabled      = false;
                    chk_ph.Enabled      = false;
                    chk_pu.Enabled      = false;
                    chk_upe.Enabled     = false;
                    chk_ups.Enabled     = false;

                    txt_abs.Enabled     = false;
                    txt_cutting.Enabled = false;
                    txt_ems.Enabled     = false;
                    txt_fga.Enabled     = false;
                    txt_fss.Enabled     = false;
                    txt_ip.Enabled      = false;
                    txt_os.Enabled      = false;
                    txt_ph.Enabled      = false;
                    txt_pu.Enabled      = false;
                    txt_upe.Enabled     = false;
                    txt_ups.Enabled     = false;
                    #endregion                    
                    #endregion
                }
                
                if (flg_project.Rows[arg_sct_row].Node.Level.Equals(1))
                {
                    #region 1 Level
                    if (_status.Equals("T") && (_upd_user == _this_user || _power_level == "S00"))
                    {
                        txt_srno.Enabled      = false;
                        txt_srfno.Enabled     = true;
                        txt_mto_acc.Enabled   = true;
                        txt_whq_dev.Enabled   = true;
                        txt_bom_id.Enabled    = true;
                        txt_modelname.Enabled = true;
                        txt_colors.Enabled    = true;
                        txt_lastcd.Enabled    = true;

                        txt_modelname.Enabled         = true;
                        txt_size.Enabled              = true;
                        txt_lasting_method.Enabled    = true;
                        txt_midsole_method.Enabled    = true;
                        txt_solelaying_method.Enabled = true;

                        cmb_p_bom.Enabled = false;
                        dtp_ets.Enabled   = true;
                        cmb_round.Enabled = true;

                        txt_fag_qty.Enabled = true;
                        txt_pattern.Enabled = true;                        
                    }

                    txt_srno.BackColor      = SystemColors.Control;
                    txt_srfno.BackColor     = SystemColors.Window;
                    txt_mto_acc.BackColor   = SystemColors.Window;
                    txt_whq_dev.BackColor   = SystemColors.Window;
                    txt_bom_id.BackColor    = SystemColors.Window;
                    txt_modelname.BackColor = SystemColors.Window;
                    txt_colors.BackColor    = SystemColors.Window;
                    txt_lastcd.BackColor    = SystemColors.Window;

                    txt_modelname.BackColor         = SystemColors.Window;
                    txt_size.BackColor              = SystemColors.Window;
                    txt_lasting_method.BackColor    = SystemColors.Window;
                    txt_midsole_method.BackColor    = SystemColors.Window;
                    txt_solelaying_method.BackColor = SystemColors.Window;
                    

                    cmb_p_bom.BackColor = SystemColors.Control;
                    
                    dtp_ets.BackColor   = SystemColors.Window;
                    txt_fag_qty.BackColor = SystemColors.Window;
                    txt_pattern.BackColor = SystemColors.Window;

                    dtp_dispatch_date.BackColor = SystemColors.Control;
                    #endregion
                }
                else
                {
                    #region 2 Level
                    if (_status.Equals("T") && (_upd_user == _this_user || _power_level == "S00"))
                    {
                        txt_srno.Enabled    = false;
                        txt_srfno.Enabled   = false;
                        txt_mto_acc.Enabled = true;
                        txt_whq_dev.Enabled = true;
                        txt_bom_id.Enabled  = false;

                        txt_modelname.Enabled         = false;
                        txt_size.Enabled              = true;
                        txt_lasting_method.Enabled    = true;
                        txt_midsole_method.Enabled    = true;
                        txt_solelaying_method.Enabled = true;
                        txt_colors.Enabled            = true;
                        txt_lastcd.Enabled            = true;
                        cmb_p_bom.Enabled             = false;
                        dtp_ets.Enabled               = true;
                        cmb_round.Enabled             = false;

                        txt_fag_qty.Enabled = true;
                        txt_pattern.Enabled = true;
                    }

                    txt_srno.BackColor      = SystemColors.Control;
                    txt_srfno.BackColor     = SystemColors.Control;
                    txt_mto_acc.BackColor   = SystemColors.Window;
                    txt_whq_dev.BackColor   = SystemColors.Window;
                    txt_bom_id.BackColor    = SystemColors.Control;
                    txt_modelname.BackColor = SystemColors.Control;
                    txt_colors.BackColor    = SystemColors.Window;
                    txt_lastcd.BackColor    = SystemColors.Window;

                    txt_modelname.BackColor         = SystemColors.Control;
                    txt_size.BackColor              = SystemColors.Window;
                    txt_lasting_method.BackColor    = SystemColors.Window;
                    txt_midsole_method.BackColor    = SystemColors.Window;
                    txt_solelaying_method.BackColor = SystemColors.Window;
                                        
                    cmb_p_bom.BackColor         = SystemColors.Control;
                    dtp_ets.BackColor           = SystemColors.Window;                    
                    txt_fag_qty.BackColor       = SystemColors.Window;
                    dtp_dispatch_date.BackColor = SystemColors.Control;
                    #endregion
                }                
            }
            else
            {
                #region Ready, Return
                txt_srno.Enabled              = false;
                dtp_ets.Enabled               = true;
                txt_style_cd.Enabled          = true;
                txt_modelname.Enabled         = true;
                txt_srfno.Enabled             = true;
                cmb_category.Enabled          = true;
                txt_mto_acc.Enabled           = true;
                cmb_season_s.Enabled          = true;
                txt_size.Enabled              = true;
                cmb_gender.Enabled            = true;
                txt_whq_dev.Enabled           = true;
                txt_dev_prod.Enabled          = true;
                txt_bom_id.Enabled            = true;
                txt_lasting_method.Enabled    = true;
                txt_midsole_method.Enabled    = true;
                txt_solelaying_method.Enabled = true;
                txt_colors.Enabled            = true;
                txt_lastcd.Enabled            = true;
                txt_pattern.Enabled           = true;
                txt_stl_file.Enabled          = true;
                cmb_round.Enabled             = true;
                txt_retail_price.Enabled      = true;
                txt_current_fob.Enabled       = true;

                txt_sample_weight.Enabled     = true;
                dtp_request_date.Enabled      = false;
                txt_collar_height.Enabled     = true;
                dtp_dispatch_date.Enabled     = true;
                txt_heel_height.Enabled       = true;
                txt_cdc_dev.Enabled           = false;
                txt_medial_height.Enabled     = true;
                txt_nike_dev.Enabled          = true;
                txt_laterial_height.Enabled   = true;
                txt_fag_qty.Enabled           = true;
                txt_lace_length.Enabled       = true;
                txt_dispatch_qty.Enabled      = true;
                txt_midsole_hardness.Enabled  = true;
                txt_ids_length.Enabled        = true;
                txt_barcode_date.Enabled      = true;
                txt_width.Enabled             = true;
                txt_fit.Enabled               = true;
                txt_upper_mat.Enabled         = true;
                txt_barcode.Enabled           = true;
                txt_lace_desc.Enabled         = true;
                txt_insole.Enabled            = true;
                cmb_t_d.Enabled               = true;
                dtp_ipw.Enabled               = true;
                chk_pcc_dd.Enabled            = true;
               
                chk_abs.Enabled = true;
                chk_cutting.Enabled = true;
                chk_ems.Enabled = true;
                chk_fga.Enabled = true;
                chk_fss.Enabled = true;
                chk_ip.Enabled = true;
                chk_os.Enabled = true;
                chk_ph.Enabled = true;
                chk_pu.Enabled = true;
                chk_upe.Enabled = true;
                chk_ups.Enabled = true;

                #region  Specification opcd info

                if (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_CHK].ToString() == "True")
                {
                    for (int i = (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING; i <= (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY_QTY; i++)
                    {
                        Set_op_cd("01", flg_project.Selection.r1, i);
                        Set_op_cd("02", flg_project.Selection.r1, i);
                    }
                }
                else
                {
                    chk_abs.Checked     = true;
                    chk_cutting.Checked = true;
                    chk_ems.Checked     = true;
                    chk_fga.Checked     = true;
                    chk_fss.Checked     = true;
                    chk_ip.Checked      = true;
                    chk_os.Checked      = true;
                    chk_ph.Checked      = true;
                    chk_pu.Checked      = true;
                    chk_upe.Checked     = true;
                    chk_ups.Checked     = true;

                    txt_abs.Text     = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                    txt_cutting.Text = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                    txt_ems.Text     = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                    txt_fga.Text     = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                    txt_fss.Text     = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                    txt_ip.Text      = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                    txt_os.Text      = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                    txt_ph.Text      = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                    txt_pu.Text      = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                    txt_upe.Text     = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                    txt_ups.Text     = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();

                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING]        = "true";
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING_QTY]    = txt_fag_qty.Text;
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS]      = "true";
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS_QTY]  = txt_fag_qty.Text;
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY]       = "true";
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY_QTY]   = txt_fag_qty.Text;
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY]       = "true";
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY_QTY]   = txt_fag_qty.Text;
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS]       = "true";
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS_QTY]   = txt_fag_qty.Text;
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY]     = "true";
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY_QTY] = txt_fag_qty.Text;
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF]             = "true";
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF_QTY]         = txt_fag_qty.Text;
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP]             = "true";
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP_QTY]         = txt_fag_qty.Text;
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING]      = "true";
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING_QTY]  = txt_fag_qty.Text;
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT]       = "true";
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT_QTY]   = txt_fag_qty.Text;
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY]       = "true";
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY_QTY]   = txt_fag_qty.Text;
                
                }
                #endregion

                if (flg_project.Rows[arg_sct_row].Node.Level.Equals(1))
                {
                    txt_srno.Enabled      = false;
                    txt_srfno.Enabled     = true;
                    txt_mto_acc.Enabled   = true;
                    txt_whq_dev.Enabled   = true;
                    txt_bom_id.Enabled    = true;
                    txt_modelname.Enabled = true;
                    txt_colors.Enabled    = true;
                    txt_lastcd.Enabled    = true;

                    txt_modelname.Enabled = true;
                    txt_size.Enabled      = true;
                    txt_lasting_method.Enabled    = true;
                    txt_midsole_method.Enabled    = true;
                    txt_solelaying_method.Enabled = true;



                    cmb_p_bom.Enabled = false;
                    dtp_ets.Enabled   = true;
                    cmb_round.Enabled = true;


                    txt_fag_qty.Enabled = true;
                    txt_pattern.Enabled = true;
                    //dtp_dispatch_date.Enabled = false;
                   
                    txt_srno.BackColor      = SystemColors.Control;
                    txt_srfno.BackColor     = SystemColors.Window;
                    txt_mto_acc.BackColor   = SystemColors.Window;
                    txt_whq_dev.BackColor   = SystemColors.Window;
                    txt_bom_id.BackColor    = SystemColors.Window;
                    txt_modelname.BackColor = SystemColors.Window;
                    txt_colors.BackColor    = SystemColors.Window;
                    txt_lastcd.BackColor    = SystemColors.Window;

                    txt_modelname.BackColor = SystemColors.Window;
                    txt_size.BackColor      = SystemColors.Window;
                    txt_lasting_method.BackColor    = SystemColors.Window;
                    txt_midsole_method.BackColor    = SystemColors.Window;
                    txt_solelaying_method.BackColor = SystemColors.Window;



                    cmb_p_bom.BackColor    = SystemColors.Control;
                    dtp_ets.BackColor      = SystemColors.Window;
                    //cmb_round.BackColor  = SystemColors.Window;
                    //cmb_season.BackColor = SystemColors.Window;

                    txt_fag_qty.BackColor = SystemColors.Window;
                    txt_pattern.BackColor = SystemColors.Window;



                    
                    dtp_dispatch_date.BackColor = SystemColors.Control;

                }
                else
                {
                    txt_srno.Enabled    = false;
                    txt_srfno.Enabled   = false;
                    txt_mto_acc.Enabled = true;
                    txt_whq_dev.Enabled = true;
                    txt_bom_id.Enabled  = false;

                    txt_modelname.Enabled         = false;
                    txt_size.Enabled              = true;
                    txt_lasting_method.Enabled    = true;
                    txt_midsole_method.Enabled    = true;
                    txt_solelaying_method.Enabled = true;




                    txt_colors.Enabled = true;
                    txt_lastcd.Enabled = true;


                    cmb_p_bom.Enabled = false;
                    dtp_ets.Enabled   = true;
                    cmb_round.Enabled = false;

                    txt_fag_qty.Enabled = true;
                    txt_pattern.Enabled = true;

                    //dtp_dispatch_date.Enabled = false;

                    txt_srno.BackColor      = SystemColors.Control;
                    txt_srfno.BackColor     = SystemColors.Control;
                    txt_mto_acc.BackColor   = SystemColors.Window;
                    txt_whq_dev.BackColor   = SystemColors.Window;
                    txt_bom_id.BackColor    = SystemColors.Control;
                    txt_modelname.BackColor = SystemColors.Control;
                    txt_colors.BackColor    = SystemColors.Window;
                    txt_lastcd.BackColor    = SystemColors.Window;

                    txt_modelname.BackColor         = SystemColors.Control;
                    txt_size.BackColor              = SystemColors.Window;
                    txt_lasting_method.BackColor    = SystemColors.Window;
                    txt_midsole_method.BackColor    = SystemColors.Window;
                    txt_solelaying_method.BackColor = SystemColors.Window;


                  
                    cmb_p_bom.BackColor = SystemColors.Control;
                    dtp_ets.BackColor   = SystemColors.Window;
                    //cmb_round.BackColor = SystemColors.Control;
                    //cmb_season.BackColor = SystemColors.Window;


                    txt_fag_qty.BackColor = SystemColors.Window;

                    
                    dtp_dispatch_date.BackColor = SystemColors.Control;

                }

                #endregion
            }       
            

            #endregion

            #region Specification info
            cmb_category.SelectedValue  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCATEGORY_S].ToString();
            cmb_gender.SelectedValue    = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxGENDER].ToString();
            cmb_season_s.SelectedValue  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSEASON].ToString();
            txt_style_cd.Text           = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_CD].ToString().Trim();
            txt_modelname.Text          = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME].ToString().Trim();
            txt_srfno.Text = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Trim().Trim().Replace(" ", "");
            txt_mto_acc.Text            = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMTO_ACC].ToString().Trim();
            cmb_p_bom.SelectedValue     = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_CD].ToString().Trim();
            txt_upper_mat.Text          = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxUPPER_MAT].ToString().Trim();
            txt_dev_prod.Text           = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDEV_PROD].ToString().Trim();

            txt_bom_id.Text             = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Trim();

            string td_code = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxT_D].ToString().Trim();
            if(td_code.Equals("000"))
            {
                td_code = GET_MAX_TD_CODE(flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString(), flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString()).Rows[0].ItemArray[0].ToString();
                cmb_t_d.SelectedValue = td_code;
                flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxT_D] = td_code;
            }
            else
            {
                cmb_t_d.SelectedValue = td_code;
            }

            txt_current_fob.Text        = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCURRENT_FOB].ToString().Trim();
            txt_retail_price.Text       = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxRETAIL_PRICE].ToString().Trim();

            try
            {
                dtp_ipw.CustomFormat = dateType;
                dtp_ipw.Text = comfunction.ConvertDate2Type(flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIPW_YMD].ToString());
            }
            catch
            {

            }
            txt_lasting_method.Text    = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLASTING_ME].ToString().Trim();
            txt_midsole_method.Text    = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMS_ME].ToString().Trim();
            txt_solelaying_method.Text = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSOLELAYING].ToString().Trim();
            txt_srno.Text              = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Trim();

            try
            {
                dtp_ets.CustomFormat = dateType;
                dtp_ets.Text = comfunction.ConvertDate2Type(flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxETS].ToString());
            }
            catch
            {
 
            }

            txt_size.Text           = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSIZE_CD].ToString().Trim();
            txt_whq_dev.Text        = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWHQ_DEV].ToString().Trim();
            txt_colors.Text         = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCOLOR_VER].ToString().Trim();
            txt_lastcd.Text         = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLAST_CD].ToString().Trim();
            cmb_round.SelectedValue = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxROUND].ToString();

            txt_sample_weight.Text   = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSAMPLE_WEI].ToString().Trim();
            txt_collar_height.Text   = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCOLLAR_HEI].ToString().Trim();
            txt_heel_height.Text     = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHEEL_HEI].ToString().Trim();
            txt_medial_height.Text   = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMEDIAL_HEI].ToString().Trim();
            txt_laterial_height.Text = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLATERAL_HEI].ToString().Trim();
            txt_lace_length.Text     = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLACE_LENGTH].ToString().Trim();
            txt_lace_desc.Text       = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLACE_DESC].ToString().Trim();
            txt_insole.Text          = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxINSOLE_DESC].ToString().Trim();
            
            try
            {
                dtp_request_date.CustomFormat = dateType;
                string vrequest_date = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YMD].ToString();
                dtp_request_date.Text = comfunction.ConvertDate2Type(vrequest_date);
            }
            catch
            {

            }

            try
            {
                dtp_dispatch_date.CustomFormat = dateType;
                string vdispatch_date = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDISPATCH_YMD].ToString();
                dtp_dispatch_date.Text = comfunction.ConvertDate2Type(vdispatch_date);
            }
            catch
            {

            }

            txt_dispatch_qty.Text  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDISPATCH_QTY].ToString().Trim();
            txt_fag_qty.Text       = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString().Trim();
            txt_nike_dev.Text      = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxNLO_DEV].ToString().Trim();
            txt_cdc_dev.Text       = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_DEV].ToString().Trim();
            txt_pattern.Text       = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPATTERN].ToString().Trim();
            txt_stl_file.Text      = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTL_FILE].ToString().Trim();
            txt_barcode_date.Text  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBARCODE_DATE].ToString().Trim();
            txt_barcode.Text       = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBARCODE].ToString().Trim();
            txt_width.Text         = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWIDTH].ToString().Trim();
            txt_fit.Text           = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFIT].ToString().Trim();

            txt_midsole_hardness.Text = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMS_HARDNESS].ToString().Trim();
            txt_ids_length.Text       = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIDS_LENGTH].ToString().Trim();
            txt_tag_cmt.Text          = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxTAG_COMMENT].ToString().Trim();
            txt_mat_ymd.Text          = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMAT_LEADTIME].ToString().Trim();

            

            cmb_sms_dev.SelectedValue  = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_PE_SABUN].ToString().Trim();
            cmb_sms_mold.SelectedValue = flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_TE_SABUN].ToString().Trim();


            if (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPCC_DD].ToString().Trim() == "Y")
                chk_pcc_dd.Checked = true;
            else
                chk_pcc_dd.Checked = false;

            #endregion            
            
        }
        private void Set_op_cd(string arg_div, int sct_row, int sct_col)
        {

            if (arg_div == "01")
            {
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF)
                {
                    if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF].ToString() == "true")
                    {
                        chk_abs.Checked = true;
                        txt_abs.Enabled = true;
                    }
                    else
                    {
                        chk_abs.Checked = false;
                        txt_abs.Enabled = false;
                    }
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY)
                {
                    if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY].ToString() == "true")
                    {
                        chk_fga.Checked = true;
                        txt_fga.Enabled = true;
                    }
                    else
                    {
                        chk_fga.Checked = false;
                        txt_fga.Enabled = false;
                    }
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS)
                {
                    if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS].ToString() == "true")
                    {
                        chk_ph.Checked = true;
                        txt_ph.Enabled = true;
                    }
                    else
                    {
                        chk_ph.Checked = false;
                        txt_ph.Enabled = false;
                    }
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING)
                {
                    if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING].ToString() == "true")
                    {
                        chk_cutting.Checked = true;
                        txt_cutting.Enabled = true;
                    }
                    else
                    {
                        chk_cutting.Checked = false;
                        txt_cutting.Enabled = false;
                    }
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY)
                {
                    if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY].ToString() == "true")
                    {
                        chk_upe.Checked = true;
                        txt_upe.Enabled = true;
                    }
                    else
                    {
                        chk_upe.Checked = false;
                        txt_upe.Enabled = false;
                    }
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP)
                {
                    if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP].ToString() == "true")
                    {
                        chk_ems.Checked = true;
                        txt_ems.Enabled = true;
                    }
                    else
                    {
                        chk_ems.Checked = false;
                        txt_ems.Enabled = false;
                    }
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY)
                {
                    if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY].ToString() == "true")
                    {
                        chk_ip.Checked = true;
                        txt_ip.Enabled = true;
                    }
                    else
                    {
                        chk_ip.Checked = false;
                        txt_ip.Enabled = false;
                    }
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS)
                {
                    if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS].ToString() == "true")
                    {
                        chk_os.Checked = true;
                        txt_os.Enabled = true;
                    }
                    else
                    {
                        chk_os.Checked = false;
                        txt_os.Enabled = false;
                    }
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY)
                {
                    if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY].ToString() == "true")
                    {
                        chk_pu.Checked = true;
                        txt_pu.Enabled = true;
                    }
                    else
                    {
                        chk_pu.Checked = false;
                        txt_pu.Enabled = false;
                    }
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING)
                {
                    if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING].ToString() == "true")
                    {
                        chk_ups.Checked = true;
                        txt_ups.Enabled = true;
                    }
                    else
                    {
                        chk_ups.Checked = false;
                        txt_ups.Enabled = false;
                    }
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT)
                {

                    if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT].ToString() == "true")
                    {
                        chk_fss.Checked = true;
                        txt_fss.Enabled = true;
                    }
                    else
                    {
                        chk_fss.Checked = false;
                        txt_fss.Enabled = false;
                    }
                }
            }
            else if (arg_div == "02")
            {
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF_QTY)
                {
                    txt_abs.Text = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF_QTY].ToString();
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY_QTY)
                {
                    txt_fga.Text = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY_QTY].ToString();
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS_QTY)
                {
                    txt_ph.Text = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS_QTY].ToString();
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING_QTY)
                {
                    txt_cutting.Text = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING_QTY].ToString();
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY_QTY)
                {
                    txt_upe.Text = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY_QTY].ToString();
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP_QTY)
                {
                    txt_ems.Text = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP_QTY].ToString();
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY_QTY)
                {
                    txt_ip.Text = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY_QTY].ToString();
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS_QTY)
                {
                    txt_os.Text = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS_QTY].ToString();
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY_QTY)
                {
                    txt_pu.Text = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY_QTY].ToString();
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING_QTY)
                {
                    txt_ups.Text = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING_QTY].ToString();
                }
                if (sct_col == (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT_QTY)
                {
                    txt_fss.Text = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT_QTY].ToString();
                }
            }            
        }
        private void Set_fga_qty()
        {            
            if (chk_fga.Checked)
                txt_fga.Text = txt_fag_qty.Text;
            if (chk_fss.Checked)
                txt_fss.Text = txt_fag_qty.Text;
            if (chk_ups.Checked)
                txt_ups.Text = txt_fag_qty.Text;
            if (chk_ems.Checked)
                txt_ems.Text = txt_fag_qty.Text;
            if (chk_abs.Checked)
                txt_abs.Text = txt_fag_qty.Text;
            if (chk_upe.Checked)
                txt_upe.Text = txt_fag_qty.Text;
            if (chk_os.Checked)
                txt_os.Text = txt_fag_qty.Text;
            if (chk_ip.Checked)
                txt_ip.Text = txt_fag_qty.Text;
            if (chk_pu.Checked)
                txt_pu.Text = txt_fag_qty.Text;
            if (chk_ph.Checked)
                txt_ph.Text = txt_fag_qty.Text;
            if (chk_cutting.Checked)
                txt_cutting.Text = txt_fag_qty.Text;            
        }       
        
        private System.Data.DataTable GET_OP_INFO(string[] arg_value)
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_01_SELECT.GET_LOT_OP_INFO";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_LOT_NO";
            OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_value[0];
            OraDB.Parameter_Values[1] = arg_value[1];
            OraDB.Parameter_Values[2] = arg_value[2];
            OraDB.Parameter_Values[3] = "";

            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        private System.Data.DataTable GET_MAX_TD_CODE(string arg_factory, string arg_srf_no)
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_01_SELECT.GET_MAX_TD_CODE";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SRF_NO";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

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
        #endregion

        #region ContextMenu Event

        #region Data Control
        private void mnu_insert_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_col = flg_project.Selection.c1;
                int sct_row = flg_project.Selection.r1;
                insert_row = sct_row;

                flg_project.Tree.Show(1);

                string file_path = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFILE_PATH].ToString().Replace(" ", "").Replace("/", "");
                if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWH_COVER].ToString() == "True")
                {
                    if (!Save_Excel_Check(file_path))
                        return;
                }
                flg_project.Rows.InsertNode(sct_row + 1, 1);
                for (int i = flg_project.Cols.Fixed; i < flg_project.Cols.Count; i++)
                {
                    if (i == (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION)
                        flg_project[sct_row + 1, i] = "I";
                    else if (i == (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS)
                        flg_project[sct_row + 1, i] = "Ready";
                    else if (i == (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN)
                        flg_project[sct_row + 1, i] = "False";
                    else if (i == (int)ClassLib.TBSXG_WS_DEV_VJ.IxIMAGE_CHK)
                        flg_project[sct_row + 1, i] = "False";
                    else if (i == (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOAD_UPD_USER)
                        flg_project[sct_row + 1, i] = COM.ComVar.This_User;
                    else
                    {
                        flg_project[sct_row + 1, i] = flg_project[sct_row, i].ToString();
                    }
                }

                flg_project.Select(sct_row + 1, sct_col);

                click_flg = true;
                Set_DataToControl(sct_row + 1);
                click_flg = false;

            }
            catch
            {
 
            }
        }        
        private void mnu_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int[] sct_rows = flg_project.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Equals("N") || flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Equals("R"))
                        flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "D";
                }
            }
            catch
            {
 
            }
        }
        private void mnu_request_Click(object sender, EventArgs e)
        {
            try
            {
                int[] sct_rows = flg_project.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Equals("N") || flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Equals("R"))
                    {
                        if (flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN].ToString().Equals("True"))
                        {
                            flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN] = "False";
                            flg_project.Update_Row(sct_rows[i]);
                        }
                        else
                        {
                            flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YN] = "True";
                            flg_project.Update_Row(sct_rows[i]);
                        }
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
                int[] sct_rows = flg_project.Selections;
                int sct_row    = flg_project.Selection.r1;
                int sct_col    = flg_project.Selection.c1;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS].ToString().Trim() == "Y")
                    {
                        string arg_factory = flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString();
                        string arg_lot_no  = flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
                        string arg_lot_seq = flg_project[sct_rows[i], (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();
                        string arg_day_seq = "1";
                        string arg_status  = "R";

                        Return_data(arg_factory, arg_lot_no, arg_lot_seq, arg_day_seq, arg_status);
                    }
                }

                tbtn_Search_Click(null, null);
                flg_project.Select(sct_row, sct_col);
                click_flg = true;
                Set_DataToControl(sct_row);
                click_flg = false;
            }
            catch
            {
 
            }
        }
        private void mnu_upload_tag_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int sct_row = flg_project.Selection.r1;
                int sct_col = flg_project.Selection.c1;

                #region File Open
                openFileDialog1.InitialDirectory = "";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

                string file_name = openFileDialog1.FileName;
                int point_position = file_name.Trim().Length - 3;
                _filetype = file_name.Trim().ToLower().Substring(point_position);

                if ((file_name == null) || (file_name == ""))
                {
                    ClassLib.ComFunction.User_Message("No file to upload", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FileInfo fi = new FileInfo(file_name);

                if (flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIMAGE_CHK].ToString() == "True")
                {
                    if (MessageBox.Show("This File is already exist, Overwrite this file?.", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                }
                #endregion

                Save_sxg_specific_image(file_name, sct_row);


                tbtn_Search_Click(null, null);
                flg_project.Select(sct_row, sct_col);
                click_flg = true;
                Set_DataToControl(sct_row);
                click_flg = false;

                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("File Upload Failed");
            }


        }
        private void mnu_pattern_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_project.Selection.r1;

                Pop_Worksheet_Huser_VJ user = new Pop_Worksheet_Huser_VJ(this, "P");
                user.ShowDialog();

                click_flg = true;
                Set_DataToControl(sct_row);
                click_flg = false;

            }
            catch
            {

            }
        }
        #endregion

        #region Excel Control
        private void mnu_upload_Click(object sender, EventArgs e)
        {
            try
            {                
                int sct_row = flg_project.Selection.r1;

                openFileDialog1.InitialDirectory = "";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;


                string file_name = openFileDialog1.FileName;

                int point_position = file_name.Trim().Length - 3;
                _filetype = file_name.Trim().ToLower().Substring(point_position);


                if ((file_name == null) || (file_name == ""))
                {
                    ClassLib.ComFunction.User_Message("No file to upload", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Save_Excel_Check(file_name))
                    return;


                string _sr_no   = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
                string _srf_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
                string _bom_id  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Replace(" ", "");
                string _lot_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Replace(" ", "");
                string _lot_seq = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                string file_dir = server_path + _srf_no + "\\";
                string new_file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                string file_path = file_dir + new_file_name;          
                                
                // Determine whether the directory exists.
                if (!Directory.Exists(file_dir))
                {
                    DirectoryInfo di = Directory.CreateDirectory(file_dir);
                }               

                FileInfo fi = new FileInfo(file_name);
                fi.CopyTo(file_path, true);
                file_name = file_path;

                file_dir = File_Bakcup + _srf_no + "\\";
                new_file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                file_path = file_dir + new_file_name;

                // Determine whether the directory exists.
                if (!Directory.Exists(file_dir))
                {
                    DirectoryInfo di = Directory.CreateDirectory(file_dir);
                }

                fi = new FileInfo(file_name);
                fi.CopyTo(file_path, true);
                

                Save_Excel("N", sct_row);

                if (!Update_Spec_File(sct_row, file_name))
                    MessageBox.Show(new_file_name + " : " + "File Upload Fail.");
                else
                    MessageBox.Show(new_file_name + " : " + "File Upload Complete.");

                
                tbtn_Search_Click(null, null);
                flg_project.Select(sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_INFO);
                mnu_download.Enabled = true;
                mnu_edit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void mnu_download_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_project.Selection.r1;

                string _sr_no   = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
                string _srf_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
                string _bom_id  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Replace(" ", "");
                string _lot_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Replace(" ", "");
                string _lot_seq = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                string file_dir  = server_path + _srf_no + "\\";
                string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                string file_path = file_dir + file_name;         
                
                // Determine whether the directory exists.
                if (!Directory.Exists(file_dir))
                {                   
                    MessageBox.Show("This File is not exist, Please ask System.");
                    return;
                }

                FolderBrowserDialog fb = new FolderBrowserDialog();
                if (fb.ShowDialog() == DialogResult.OK)
                {
                    string down_path = fb.SelectedPath +"\\";
                    FileInfo fi = new FileInfo(file_path);
                    if (!fi.Exists)
                    {
                        MessageBox.Show("This File is not exist, Please ask System.");
                        return;
                    }

                    fi.CopyTo(down_path + file_name, true);

                    MessageBox.Show(file_name + " : " + "File Download Complete.. "); 
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void mnu_edit_Click(object sender, EventArgs e)
        {
            try
            {                          
                int sct_row = flg_project.Selection.r1;

                string _sr_no   = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
                string _srf_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
                string _bom_id  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Replace(" ", "");
                string _lot_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Replace(" ", "");
                string _lot_seq = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                string file_dir  = server_path + _srf_no + "\\";
                string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                string file_path = file_dir + file_name;         
                
                FileInfo fi = new FileInfo(file_path);
                if (!fi.Exists)
                {
                    MessageBox.Show("This File is not exist, Please ask System.");
                    return;
                }
                Process.Start("EXCEL.EXE", file_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void mnu_copy_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_project.Selection.r1;

                string _sr_no   = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
                string _srf_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
                string _bom_id  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Replace(" ", "");
                string _lot_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Replace(" ", "");
                string _lot_seq = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                string file_dir  = server_path + _srf_no + "\\";
                string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                string file_path = file_dir + file_name;         
                
                copy_file_path = file_path;
                copy_row       = sct_row;
                copy_excel     = true;                
            }
            catch
            {
 
            }
        }
        private void mnu_paste_Click(object sender, EventArgs e)
        {
            try
            {

                int sct_row = flg_project.Selection.r1;

                //File Copy                
                FileInfo fi = new FileInfo(copy_file_path);

                if (!fi.Exists)
                {
                    MessageBox.Show("This File is not exist, Please ask System.");
                    return;
                }

                if(flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWH_COVER].ToString() == "True")
                {
                    if(MessageBox.Show("This File is already exist, Overwrite this file?.", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                }

                if (!Save_Excel_Check(copy_file_path))
                    return;

                string _sr_no   = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace(" ", "");
                string _srf_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace(" ", "");
                string _bom_id  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Replace(" ", "");
                string _lot_no  = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Replace(" ", "");
                string _lot_seq = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                string file_dir  = server_path + _srf_no + "\\";
                string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                string file_path = file_dir + file_name;   

                // Determine whether the directory exists.
                if (!Directory.Exists(file_dir))
                {
                    DirectoryInfo di = Directory.CreateDirectory(file_dir);
                }

                fi.CopyTo(file_path, true);

                Save_Excel("C", sct_row);

                if (!Update_Spec_File(sct_row, file_path))
                    MessageBox.Show(file_name + " : " + "File Copy Fail.");
                else
                    MessageBox.Show(file_name + " : " + "File Copy Complete.");

                flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFILE_PATH] = file_path;
                flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWH_COVER] = "True";
            }
            catch
            {
 
            }
        }
        #endregion

        #region Not Using
        private void mnu_multi_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_project.Selection.r1;
                int sct_col = flg_project.Selection.c1;

                string factory = cmb_factory_h.SelectedValue.ToString();
                string lot_no = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
                string lot_seq = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();


                Pop_Worksheet_Multi_Change_VJ ws_multi = new Pop_Worksheet_Multi_Change_VJ(this, factory, lot_no, lot_seq);
                ws_multi.ShowDialog();

                if (ws_multi.save_flg)
                {
                    tbtn_Search_Click(null, null);
                    flg_project.Select(sct_row, sct_col);

                    click_flg = true;
                    Set_DataToControl(sct_row);
                    click_flg = false;
                }
            }
            catch
            {

            }
        }
        private void mnu_forecast_Click(object sender, EventArgs e)
        {
            try
            {
                COM.MyItem item = new COM.MyItem("Forecast Mat. Stock for Model", "Form_Outgoing_mat_list.cs", "Form_Outgoing_mat_list");                        
                ClassMenu menu = new ClassMenu();                
                
                menu.OpenFormByName(this.MdiParent, item, "FlexCDC.Outgoing.Form_Outgoing_mat_list", "Forecast Mat. Stock for Model");                
            }
            catch
            {
            }
        }
        #endregion

        #endregion

        #region Specification Change Event
        private void save_tail_temp(int arg_sct_row, int arg_sct_col, string arg_value)
        {
            try
            {
                if (flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I" && flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "D")
                {
                    flg_project[arg_sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
                }
                flg_project[arg_sct_row, arg_sct_col] = arg_value;
            }
            catch
            {
 
            }
        }
        private void txt_srno_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO, txt_srno.Text);
        }

        private void txt_style_cd_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_CD, txt_style_cd.Text);

        }

        private void txt_modelname_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME, txt_modelname.Text);

        }

        private void txt_srfno_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO, txt_srfno.Text);
        }

        private void cmb_category_SelectedValueChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCATEGORY, cmb_category.Text);
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCATEGORY_S, cmb_category.SelectedValue.ToString());
        }

        private void txt_mto_acc_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMTO_ACC, txt_mto_acc.Text);
        }        

        private void cmb_season_s_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSEASON_CD, cmb_season_s.Text);
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSEASON, cmb_season_s.SelectedValue.ToString());
        }

        private void txt_size_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSIZE_CD, txt_size.Text);
        }

        private void cmb_gender_SelectedValueChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxGENDER, cmb_gender.SelectedValue.ToString());
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxGEN_NAME, cmb_gender.Text);
        }

        private void txt_whq_dev_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWHQ_DEV, txt_whq_dev.Text);
        }

        private void txt_dev_prod_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDEV_PROD, txt_dev_prod.Text);
        }

        private void txt_bom_id_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID, txt_bom_id.Text);
        }

        private void txt_lasting_method_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLASTING_ME, txt_lasting_method.Text);
        }

        private void txt_midsole_method_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMS_ME, txt_midsole_method.Text);
        }

        private void txt_solelaying_method_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSOLELAYING, txt_solelaying_method.Text);
        }

        private void txt_colors_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCOLOR_VER, txt_colors.Text);
        }

        private void txt_lastcd_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLAST_CD, txt_lastcd.Text);
        }

        private void txt_pattern_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPATTERN, txt_pattern.Text);
        }

        private void txt_stl_file_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTL_FILE, txt_stl_file.Text);
        }

        private void txt_retail_price_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxRETAIL_PRICE, txt_retail_price.Text);
        }

        private void txt_current_fob_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCURRENT_FOB, txt_current_fob.Text);
        }

        private void txt_sample_weight_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSAMPLE_WEI, txt_sample_weight.Text);
        }

        private void dtp_request_date_ValueChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YMD, dtp_request_date.Value.ToString("yyyyMMdd"));
        }

        private void txt_collar_height_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCOLLAR_HEI, txt_collar_height.Text);
        }

        private void dtp_dispatch_date_ValueChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDISPATCH_YMD, dtp_dispatch_date.Value.ToString("yyyyMMdd"));
        }

        private void txt_heel_height_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHEEL_HEI, txt_heel_height.Text);
        }

        private void txt_cdc_dev_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_DEV, txt_cdc_dev.Text);
        }

        private void txt_medial_height_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMEDIAL_HEI, txt_medial_height.Text);
        }

        private void txt_nike_dev_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxNLO_DEV, txt_nike_dev.Text);
        }

        private void txt_laterial_height_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLATERAL_HEI, txt_laterial_height.Text);
        }

        private void txt_fag_qty_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_QTY, txt_fag_qty.Text);
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY, txt_fag_qty.Text);

            Set_fga_qty();
            
        }

        private void txt_lace_length_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLACE_LENGTH, txt_lace_length.Text);
        }

        private void txt_dispatch_qty_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDISPATCH_QTY, txt_dispatch_qty.Text);
        }

        private void txt_midsole_hardness_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMS_HARDNESS, txt_midsole_hardness.Text);
        }

        private void txt_ids_length_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIDS_LENGTH, txt_ids_length.Text);
        }

        private void txt_barcode_date_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBARCODE_DATE, txt_barcode_date.Text);
        }

        private void txt_width_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWIDTH, txt_width.Text);
        }

        private void txt_fit_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFIT, txt_fit.Text);
        }

        private void txt_upper_mat_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxUPPER_MAT, txt_upper_mat.Text);
        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBARCODE, txt_barcode.Text);
        }

        private void txt_lace_desc_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLACE_DESC, txt_lace_desc.Text);
        }

        private void txt_insole_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxINSOLE_DESC, txt_insole.Text);
        }
        
        private void cmb_t_d_SelectedValueChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxT_D, cmb_t_d.SelectedValue.ToString());
        }

        private void dtp_ipw_ValueChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIPW_YMD, dtp_ipw.Value.ToString("yyyyMMdd"));
        }       

        private void dtp_ets_ValueChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxETS, dtp_ets.Value.ToString("yyyyMMdd"));
            
            dtp_dispatch_date.Value = dtp_ets.Value;            
        }

        private void cmb_sampletype_SelectedValueChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxROUND, cmb_round.SelectedValue.ToString());
        }

        private void cmb_round_SelectedValueChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSAMPLE_TPYES, cmb_round.Text);
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxROUND, cmb_round.SelectedValue.ToString());
        }

        private void txt_tag_cmt_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxTAG_COMMENT, txt_tag_cmt.Text);
        }

        private void txt_mat_ymd_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMAT_LEADTIME, txt_mat_ymd.Text);
        }
        private void chk_pcc_dd_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;   
         
            if(chk_pcc_dd.Checked)
                save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPCC_DD, "Y");
            else
                save_tail_temp(flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPCC_DD, "N");
        }
        #endregion

        #region Control Event
        private void cmb_bom_id_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_bom_id_h.Clear();
        }        
        
        private void btn_sms_dev_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_project.Selection.r1;

                Pop_Worksheet_Huser_VJ user = new Pop_Worksheet_Huser_VJ(this, "P");
                user.ShowDialog();

                click_flg = true;
                Set_DataToControl(sct_row);
                click_flg = false;

            }
            catch
            {

            }
        }

        private void btn_sms_mold_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_project.Selection.r1;

                Pop_Worksheet_Huser_VJ user = new Pop_Worksheet_Huser_VJ(this, "M");
                user.ShowDialog();

                click_flg = true;
                Set_DataToControl(sct_row);
                click_flg = false;

            }
            catch
            {

            }
        }
        #endregion

        #region DB Connect 

        #region Select Data
        

        
        
        
        private System.Data.DataTable Get_cdc_dev_kname(string arg_factory, string arg_lot_no, string arg_lot_seq)
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "pkg_sxg_mps_01_select.get_cdc_dev_kname";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_lot_no";
            OraDB.Parameter_Name[2] = "arg_lot_seq";
            OraDB.Parameter_Name[3] = "out_cursor";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        
        private System.Data.DataTable get_sxe_spec_image(int arg_row)
        {


            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.get_sxe_spec_image";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_lot_no";
            OraDB.Parameter_Name[2] = "arg_lot_seq";
            OraDB.Parameter_Name[3] = "out_cursor";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString();
            OraDB.Parameter_Values[1] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
            OraDB.Parameter_Values[2] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();
            OraDB.Parameter_Values[3] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet ds_Search = OraDB.Exe_Select_Procedure();
                        
            return ds_Search.Tables[OraDB.Process_Name];

        }
        private System.Data.DataTable Select_Sxb_Rout_Bom()
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXG_MPS_01_SELECT.SELECT_SXB_ROUT_BOM";

                OraDB.ReDim_Parameter(2);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = cmb_factory_h.SelectedValue.ToString();
                OraDB.Parameter_Values[1] = "";

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
        private System.Data.DataTable Select_Sxb_Rout_Bom_List()
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXG_MPS_01_SELECT.SELECT_SXB_ROUT_BOM_LIST";

                OraDB.ReDim_Parameter(2);

                OraDB.Process_Name = process_name;
                
                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = cmb_factory_h.SelectedValue.ToString();
                OraDB.Parameter_Values[1] = "";

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
        private System.Data.DataTable Select_Sxd_Srf_Specification(string arf_factory, string arg_lot_no, string arg_lot_seq)
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXG_MPS_01_SELECT.SELECT_SXD_SRF_SPEC";

                OraDB.ReDim_Parameter(4);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_LOT_NO";
                OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
                OraDB.Parameter_Name[3] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = arf_factory;
                OraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_lot_no, " ");
                OraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(arg_lot_seq, " ");
                OraDB.Parameter_Values[3] = "";

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
        private System.Data.DataTable Select_Sxd_Srf_Specification_opcd(string arf_factory, string arg_lot_no, string arg_lot_seq)
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXG_MPS_01_SELECT.SELECT_SXD_SRF_SPECIFIC_OPCD";

                OraDB.ReDim_Parameter(4);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_LOT_NO";
                OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";                
                OraDB.Parameter_Name[3] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = arf_factory;
                OraDB.Parameter_Values[1] = arg_lot_no;
                OraDB.Parameter_Values[2] = arg_lot_seq;
                OraDB.Parameter_Values[3] = "";

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
        private System.Data.DataTable Select_Sxc_Spec_Mast(string arf_factory, string arg_lot_no, string arg_lot_seq)
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXG_MPS_01_SELECT.SELECT_SXD_SRF_MAST_S";

                OraDB.ReDim_Parameter(4);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_LOT_NO";
                OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
                OraDB.Parameter_Name[3] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = arf_factory;
                OraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_lot_no, " ");
                OraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(arg_lot_seq, " ");
                OraDB.Parameter_Values[3] = "";

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
        
        private System.Data.DataTable Select_Nf_Code(string arg_factory, string arg_season_name)
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXD_SRF_01_SELECT.SELECT_NF_CODE";

                OraDB.ReDim_Parameter(3);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_SEASON_NAME";
                OraDB.Parameter_Name[2] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                OraDB.Parameter_Values[0] = arg_factory;
                OraDB.Parameter_Values[1] = arg_season_name;
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
        private System.Data.DataTable Select_sdc_nf_desc()
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory_h.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        

        
        private System.Data.DataTable Select_Srf_No_Insert()
        {
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SXD_SRF_01_SELECT.SELECT_SXD_SRF_NO";

                OraDB.ReDim_Parameter(2);

                OraDB.Process_Name = process_name;

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "OUT_CURSOR";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                OraDB.Parameter_Values[0] = cmb_factory_h.SelectedValue.ToString();
                OraDB.Parameter_Values[1] = "";

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
        
        
        private System.Data.DataTable Select_Project_List(string arg_factory, string arg_srf_no, string arg_bomid, string arg_load_upd_user)
        {
            DataSet ds_ret;

            string process_name = "PKG_SXD_SRF_01_SELECT.SELECT_PROJECT_MASTER_NEW";

            OraDB.ReDim_Parameter(5);

            OraDB.Process_Name = process_name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SRF_NO";
            OraDB.Parameter_Name[2] = "ARG_BOM_ID";
            OraDB.Parameter_Name[3] = "ARG_LOAD_UPD_USER";
            OraDB.Parameter_Name[4] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_srf_no, " ");
            OraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(arg_bomid, " ");
            OraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_String(arg_load_upd_user, " ");
            OraDB.Parameter_Values[4] = "";

            OraDB.Add_Select_Parameter(true);
            ds_ret = OraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[process_name];

        }
        private System.Data.DataTable Select_Lot_Spec(string arg_factory, string arg_srf_no, string arg_bomid, string arg_lot_no, string arg_lot_seq, string arg_load_upd_user)
        {
            DataSet ds_ret;

            string process_name = "PKG_SXG_MPS_01_SELECT.SELECT_SXD_SRF_LOT_SPEC";

            OraDB.ReDim_Parameter(7);

            OraDB.Process_Name = process_name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SRF_NO";
            OraDB.Parameter_Name[2] = "ARG_BOM_ID";
            OraDB.Parameter_Name[3] = "ARG_LOT_NO";
            OraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[5] = "ARG_LOAD_UPD_USER";
            OraDB.Parameter_Name[6] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_srf_no, " ");
            OraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(arg_bomid, " ");
            OraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_String(arg_lot_no, " ");
            OraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_String(arg_lot_seq, " ");
            OraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_String(arg_load_upd_user, " ");
            OraDB.Parameter_Values[6] = "";

            OraDB.Add_Select_Parameter(true);
            ds_ret = OraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[process_name];

        }
        
        private System.Data.DataTable get_lot_seq(int arg_row)
        {
            string Proc_Name = "PKG_SXG_MPS_01_SELECT.GET_LOT_SEQ";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_LOT_NO";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString();
            OraDB.Parameter_Values[1] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
            OraDB.Parameter_Values[2] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
            
        }
        private System.Data.DataTable get_req_ymd()
        {
            string Proc_Name = "PKG_SXG_MPS_01_SELECT.GET_REQ_YMD";

            OraDB.ReDim_Parameter(1);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }
        #endregion

        #region Save Data
        private void Return_data(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_day_seq, string arg_status)
        {
            OraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            OraDB.Process_Name = "pkg_sxg_mps_02.save_sxg_mps_status_lot";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_LOT_NO";
            OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[3] = "ARG_DAY_SEQ";
            OraDB.Parameter_Name[4] = "ARG_LINE_CD";
            OraDB.Parameter_Name[5] = "ARG_STATUS";
            OraDB.Parameter_Name[6] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = arg_day_seq;
            OraDB.Parameter_Values[4] = "001";
            OraDB.Parameter_Values[5] = arg_status;
            OraDB.Parameter_Values[6] = COM.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }

        private void SAVE_RETURN_DATA(string [] arg_value)
        {
            OraDB.ReDim_Parameter(10);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_01.SAVE_SXD_SRF_RETURN_OPCD";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_DIVISION";
            OraDB.Parameter_Name[1] = "ARG_FACTORY";
            OraDB.Parameter_Name[2] = "ARG_LOT_NO";
            OraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[4] = "ARG_BOM_CD";
            OraDB.Parameter_Name[5] = "ARG_CMP_CD";
            OraDB.Parameter_Name[6] = "ARG_OP_CD";
            OraDB.Parameter_Name[7] = "ARG_PLAN_YMD";
            OraDB.Parameter_Name[8] = "ARG_OP_QTY";
            OraDB.Parameter_Name[9] = "ARG_UPD_USER";
            
            //03. DATA TYPE 정의
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

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_value[0];
            OraDB.Parameter_Values[1] = arg_value[1];
            OraDB.Parameter_Values[2] = arg_value[2];
            OraDB.Parameter_Values[3] = arg_value[3];
            OraDB.Parameter_Values[4] = arg_value[4];
            OraDB.Parameter_Values[5] = arg_value[5];
            OraDB.Parameter_Values[6] = arg_value[6];
            OraDB.Parameter_Values[7] = arg_value[7];
            OraDB.Parameter_Values[8] = arg_value[8];
            OraDB.Parameter_Values[9] = arg_value[9];

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }

        private void save_lot(string arg_division, int arg_row)
        {
            string Proc_Name = "PKG_SXG_MPS_01.SAVE_SXE_LOT";

            OraDB.ReDim_Parameter(5);
            OraDB.Process_Name = Proc_Name;           

            OraDB.Parameter_Name[0]  = "ARG_DIVISION";
            OraDB.Parameter_Name[1]  = "ARG_FACTORY";
            OraDB.Parameter_Name[2]  = "ARG_LOT_NO";
            OraDB.Parameter_Name[3]  = "ARG_LOT_SEQ";            
            OraDB.Parameter_Name[4]  = "ARG_UPD_USER";
            
            OraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4]  = (int)OracleType.VarChar;            

            OraDB.Parameter_Values[0] = arg_division;
            OraDB.Parameter_Values[1] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString();
            OraDB.Parameter_Values[2] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
            OraDB.Parameter_Values[3] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();           
            OraDB.Parameter_Values[4] = COM.ComVar.This_User;
           
            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }
        private bool Update_Spec_File(int arg_row, string arg_file_path)
        {
            string process_name = "PKG_SXG_MPS_01.UPDATE_SXD_SRF_SPECIFICATION";

            int vcnt = 5; int i = 0; int j = 0; int k = 0;
            OraDB.ReDim_Parameter(vcnt);

            OraDB.Process_Name = process_name;

            OraDB.Parameter_Name[i++] = "ARG_FACTORY";
            OraDB.Parameter_Name[i++] = "ARG_LOT_NO";
            OraDB.Parameter_Name[i++] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[i++] = "ARG_FILE_PATH";
            OraDB.Parameter_Name[i++] = "ARG_UPD_USER";

            for (j = 0; j < vcnt; j++)
                OraDB.Parameter_Type[j] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[k++] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString();
            OraDB.Parameter_Values[k++] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
            OraDB.Parameter_Values[k++] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();
            OraDB.Parameter_Values[k++] = arg_file_path;
            OraDB.Parameter_Values[k++] = COM.ComVar.This_User.Replace("'", "");

            OraDB.Add_Modify_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Modify_Procedure();

            return true;
        }
        
        private bool Save_Specification(int arg_row)
        {
            string process_name = "PKG_SXG_MPS_01.SAVE_SXD_SRF_SPECIFICATION";

            int vcnt = 60; int i = 0; int j = 0; int k = 0;
            OraDB.ReDim_Parameter(vcnt);

            OraDB.Process_Name = process_name;

            OraDB.Parameter_Name[0]  = "ARG_FACTORY";                  
            OraDB.Parameter_Name[1]  = "ARG_LOT_NO";       
            OraDB.Parameter_Name[2]  = "ARG_LOT_SEQ"; 
            OraDB.Parameter_Name[3]  = "ARG_SR_NO";                    
            OraDB.Parameter_Name[4]  = "ARG_BOM_CD";       
            OraDB.Parameter_Name[5]  = "ARG_STYLE_CD";     
            OraDB.Parameter_Name[6]  = "ARG_STYLE_NAME";   
            OraDB.Parameter_Name[7]  = "ARG_SRF_NO";       
            OraDB.Parameter_Name[8]  = "ARG_CATEGORY";     
            OraDB.Parameter_Name[9]  = "ARG_MTO_ACC";      
            OraDB.Parameter_Name[10] = "ARG_SEASON_CD";    
            OraDB.Parameter_Name[11] = "ARG_SIZE_CD";      
            OraDB.Parameter_Name[12] = "ARG_GEN_CD";       
            OraDB.Parameter_Name[13] = "ARG_WHQ_DEV";      
            OraDB.Parameter_Name[14] = "ARG_DEV_PROD";     
            OraDB.Parameter_Name[15] = "ARG_BOM_ID";       
            OraDB.Parameter_Name[16] = "ARG_LASTING_ME";   
            OraDB.Parameter_Name[17] = "ARG_MS_ME";        
            OraDB.Parameter_Name[18] = "ARG_SOLE_LAYING";  
            OraDB.Parameter_Name[19] = "ARG_COLOR_VER";    
            OraDB.Parameter_Name[20] = "ARG_LAST_CD";      
            OraDB.Parameter_Name[21] = "ARG_PATTERN";      
            OraDB.Parameter_Name[22] = "ARG_STF_FILE";     
            OraDB.Parameter_Name[23] = "ARG_RETAIL_PRICE"; 
            OraDB.Parameter_Name[24] = "ARG_CURRENT_FOB";  
            OraDB.Parameter_Name[25] = "ARG_SAMPLE_WEI";   
            OraDB.Parameter_Name[26] = "ARG_COLLAR_HEI";   
            OraDB.Parameter_Name[27] = "ARG_HEEL_HEI";     
            OraDB.Parameter_Name[28] = "ARG_LATERAL_HEI";  
            OraDB.Parameter_Name[29] = "ARG_MEDIAL_HEI";   
            OraDB.Parameter_Name[30] = "ARG_LACE_LEN";     
            OraDB.Parameter_Name[31] = "ARG_REQ_YMD";      
            OraDB.Parameter_Name[32] = "ARG_DISPATCH_YMD"; 
            OraDB.Parameter_Name[33] = "ARG_CDC_DEV";      
            OraDB.Parameter_Name[34] = "ARG_NLO_DEV";      
            OraDB.Parameter_Name[35] = "ARG_DISPATCH_QTY"; 
            OraDB.Parameter_Name[36] = "ARG_FGA_QTY";      
            OraDB.Parameter_Name[37] = "ARG_IDS_LENGTH";   
            OraDB.Parameter_Name[38] = "ARG_BARCODE_DATE"; 
            OraDB.Parameter_Name[39] = "ARG_WIDTH";        
            OraDB.Parameter_Name[40] = "ARG_FIT";          
            OraDB.Parameter_Name[41] = "ARG_UPPER_MAT";    
            OraDB.Parameter_Name[42] = "ARG_BARCODE";      
            OraDB.Parameter_Name[43] = "ARG_LACE_DESC";    
            OraDB.Parameter_Name[44] = "ARG_INSOLE_DESC";  
            OraDB.Parameter_Name[45] = "ARG_T_D";          
            OraDB.Parameter_Name[46] = "ARG_IPW_DATE";
            OraDB.Parameter_Name[47] = "ARG_UPD_USER";     

            OraDB.Parameter_Name[48] = "ARG_NF_CD";      
            OraDB.Parameter_Name[49] = "ARG_NEED_BY";   
            OraDB.Parameter_Name[50] = "ARG_ETS";
            OraDB.Parameter_Name[51] = "ARG_LOT_QTY";
            OraDB.Parameter_Name[52] = "ARG_REMARKS";
            OraDB.Parameter_Name[53] = "ARG_MS_HARDNESS";
            OraDB.Parameter_Name[54] = "ARG_DIVISION";
            OraDB.Parameter_Name[55] = "ARG_TAG_COMMENT";
            OraDB.Parameter_Name[56] = "ARG_MAT_YMD";
            OraDB.Parameter_Name[57] = "ARG_PE_SABUN";
            OraDB.Parameter_Name[58] = "ARG_TE_SABUN";
            OraDB.Parameter_Name[59] = "ARG_PCC_DD";
  

            for (j = 0; j < vcnt; j++)
                OraDB.Parameter_Type[j] = (int)OracleType.VarChar;


            OraDB.Parameter_Values[0] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString();
            OraDB.Parameter_Values[1] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
            OraDB.Parameter_Values[2] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();
            OraDB.Parameter_Values[3] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSR_NO].ToString().Replace("'", "");
            OraDB.Parameter_Values[4] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_CD].ToString();
            OraDB.Parameter_Values[5] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_CD].ToString();
            OraDB.Parameter_Values[6] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTYLE_NAME].ToString();
            OraDB.Parameter_Values[7] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSRF_NO].ToString().Replace("'", "");
            OraDB.Parameter_Values[8] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCATEGORY_S].ToString();
            OraDB.Parameter_Values[9] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMTO_ACC].ToString();
            OraDB.Parameter_Values[10] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSEASON].ToString();
            OraDB.Parameter_Values[11] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSIZE_CD].ToString().Replace("'", "");
            OraDB.Parameter_Values[12] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxGENDER].ToString();
            OraDB.Parameter_Values[13] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWHQ_DEV].ToString();
            OraDB.Parameter_Values[14] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDEV_PROD].ToString();
            OraDB.Parameter_Values[15] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBOM_ID].ToString().Replace("'", "");
            OraDB.Parameter_Values[16] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLASTING_ME].ToString();
            OraDB.Parameter_Values[17] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMS_ME].ToString();
            OraDB.Parameter_Values[18] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSOLELAYING].ToString();
            OraDB.Parameter_Values[19] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCOLOR_VER].ToString();
            OraDB.Parameter_Values[20] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLAST_CD].ToString();
            OraDB.Parameter_Values[21] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPATTERN].ToString();
            OraDB.Parameter_Values[22] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTL_FILE].ToString();
            OraDB.Parameter_Values[23] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxRETAIL_PRICE].ToString().Trim().Replace(" ", "");
            OraDB.Parameter_Values[24] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCURRENT_FOB].ToString();
            OraDB.Parameter_Values[25] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSAMPLE_WEI].ToString();
            OraDB.Parameter_Values[26] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCOLLAR_HEI].ToString();
            OraDB.Parameter_Values[27] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHEEL_HEI].ToString();
            OraDB.Parameter_Values[28] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLATERAL_HEI].ToString();
            OraDB.Parameter_Values[29] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMEDIAL_HEI].ToString();
            OraDB.Parameter_Values[30] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLACE_LENGTH].ToString();
            OraDB.Parameter_Values[31] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREQ_YMD].ToString();
            OraDB.Parameter_Values[32] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDISPATCH_YMD].ToString();
            OraDB.Parameter_Values[33] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_DEV].ToString();
            OraDB.Parameter_Values[34] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxNLO_DEV].ToString();
            OraDB.Parameter_Values[35] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDISPATCH_QTY].ToString();
            OraDB.Parameter_Values[36] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
            OraDB.Parameter_Values[37] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIDS_LENGTH].ToString();
            OraDB.Parameter_Values[38] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBARCODE_DATE].ToString();
            OraDB.Parameter_Values[39] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxWIDTH].ToString();
            OraDB.Parameter_Values[40] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFIT].ToString();
            OraDB.Parameter_Values[41] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxUPPER_MAT].ToString();
            OraDB.Parameter_Values[42] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxBARCODE].ToString();
            OraDB.Parameter_Values[43] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLACE_DESC].ToString();
            OraDB.Parameter_Values[44] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxINSOLE_DESC].ToString();
            OraDB.Parameter_Values[45] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxT_D].ToString();
            OraDB.Parameter_Values[46] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIPW_YMD].ToString();
            OraDB.Parameter_Values[47] = COM.ComVar.This_User.ToLower();

            OraDB.Parameter_Values[48] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxROUND].ToString();
            OraDB.Parameter_Values[49] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxNEED_BY].ToString();
            OraDB.Parameter_Values[50] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxETS].ToString();
            OraDB.Parameter_Values[51] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_QTY].ToString();
            OraDB.Parameter_Values[52] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxREMARKS].ToString();
            OraDB.Parameter_Values[53] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMS_HARDNESS].ToString();
            OraDB.Parameter_Values[54] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString();
            OraDB.Parameter_Values[55] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxTAG_COMMENT].ToString();
            OraDB.Parameter_Values[56] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxMAT_LEADTIME].ToString();
            OraDB.Parameter_Values[57] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_PE_SABUN].ToString();
            OraDB.Parameter_Values[58] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCDC_TE_SABUN].ToString();
            OraDB.Parameter_Values[59] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPCC_DD].ToString();

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure(); 
            return true;

        }
        private bool Save_Specific_Opcd(string arg_first, string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_bom_cd, string arg_cmp_cd, string arg_op_cd, string arg_op_qty)
        {
            string process_name = "PKG_SXG_MPS_01.SAVE_SXD_SRF_SPECIFIC_OPCD";
            
            OraDB.ReDim_Parameter(11);

            OraDB.Process_Name = process_name;


            OraDB.Parameter_Name[0] = "ARG_FIRST_YN";
            OraDB.Parameter_Name[1] = "ARG_FACTORY";
            OraDB.Parameter_Name[2] = "ARG_LOT_NO";
            OraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[4] = "ARG_BOM_CD";
            OraDB.Parameter_Name[5] = "ARG_CMP_CD";
            OraDB.Parameter_Name[6] = "ARG_OP_CD";
            OraDB.Parameter_Name[7] = "ARG_OP_QTY";
            OraDB.Parameter_Name[8] = "ARG_REMARKS";
            OraDB.Parameter_Name[9] = "ARG_STATUS";
            OraDB.Parameter_Name[10] = "ARG_UPD_USER";

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

            OraDB.Parameter_Values[0] = arg_first;
            OraDB.Parameter_Values[1] = arg_factory;
            OraDB.Parameter_Values[2] = arg_lot_no;
            OraDB.Parameter_Values[3] = arg_lot_seq;
            OraDB.Parameter_Values[4] = arg_bom_cd;
            OraDB.Parameter_Values[5] = arg_cmp_cd;
            OraDB.Parameter_Values[6] = arg_op_cd;
            OraDB.Parameter_Values[7] = arg_op_qty;
            OraDB.Parameter_Values[8] = " ";
            OraDB.Parameter_Values[9] = "N";
            OraDB.Parameter_Values[10] = ClassLib.ComVar.This_User;            

            OraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
            OraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
            return true;
        }
        private void Save_mps_lot_daily(string arg_status, int arg_row)
        {
            string Proc_Name = "PKG_SXG_MPS_01.SAVE_SXG_MPS_LOT_DAILY";

            OraDB.ReDim_Parameter(5);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_LOT_NO";
            OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[3] = "ARG_STATUS";
            OraDB.Parameter_Name[4] = "ARG_UPD_USER";
            
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString();
            OraDB.Parameter_Values[1] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
            OraDB.Parameter_Values[2] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();
            OraDB.Parameter_Values[3] = arg_status;                   
            OraDB.Parameter_Values[4] = COM.ComVar.This_User;          

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure(); 
            
        }        
        private bool Save_sxg_specific_image(string arg_file_name, int arg_row)
        {
            try
            {

                bool ret;

                OraDB.ReDim_Parameter(9);


                //01.PROCEDURE명
                OraDB.Process_Name = "PKG_SXG_MPS_01.SAVE_SXG_SPECIFIC_IMAGE";

                //02.ARGURMENT 명
                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_LOT_NO";
                OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
                OraDB.Parameter_Name[3] = "ARG_IMAGE_SEQ";
                OraDB.Parameter_Name[4] = "ARG_IMAGE";
                OraDB.Parameter_Name[5] = "ARG_POINT";
                OraDB.Parameter_Name[6] = "ARG_REMARKS";
                OraDB.Parameter_Name[7] = "ARG_STATUS";
                OraDB.Parameter_Name[8] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[4] = (int)OracleType.Blob;
                OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[8] = (int)OracleType.VarChar;                

                //04.DATA 정의
                OraDB.Parameter_Values[0] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString();
                OraDB.Parameter_Values[1] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString();
                OraDB.Parameter_Values[2] = flg_project[arg_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString();
                OraDB.Parameter_Values[3] = "1";
                OraDB.Parameter_Values[4] = " ";
                OraDB.Parameter_Values[5] = " ";
                OraDB.Parameter_Values[6] = "";
                OraDB.Parameter_Values[7] = " ";
                OraDB.Parameter_Values[8] = ClassLib.ComVar.This_User;

                byte[] photo = null;
                photo = GetPhoto(arg_file_name);
                ret = OraDB.Exe_Modify_Procedure_Blob(photo);
                return ret;

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save_Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private byte[] GetPhoto(string arg_filename)
        {
            FileStream fs = new FileStream(arg_filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] photo = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return photo;

        }
        #endregion      

        
        #endregion

        #region CheckBox Setting
        private void chk_cutting_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            
            if (chk_cutting.Checked)
            {
                txt_cutting.Enabled = true;
                txt_cutting.Text = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING] = "true";

            }
            else
            {
                txt_cutting.Enabled = false;
                txt_cutting.Text = "0";
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING] = "false";
            }
            
            
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
            
        }

        private void chk_ph_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            if (chk_ph.Checked)
            {
                txt_ph.Enabled = true;
                txt_ph.Text = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS] = "true";
            }
            else
            {
                txt_ph.Enabled = false;
                txt_ph.Text = "0";
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS] = "false";
            }
            
            
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
            
        }

        private void chk_pu_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            if (chk_pu.Checked)
            {
                txt_pu.Enabled = true;
                txt_pu.Text = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY] = "true";
            }
            else
            {
                txt_pu.Enabled = false;
                txt_pu.Text = "0";
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY] = "false";
            }

           
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
            
        }

        private void chk_ip_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            
            if (chk_ip.Checked)
            {
                txt_ip.Enabled = true;
                txt_ip.Text = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY] = "true";
            }
            else
            {
                txt_ip.Enabled = false;
                txt_ip.Text = "0";
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY] = "false";
            }
       
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
            
        }

        private void chk_os_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            if (chk_os.Checked)
            {
                txt_os.Enabled = true;
                txt_os.Text = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS] = "true";
            }
            else
            {
                txt_os.Enabled = false;
                txt_os.Text = "0";
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS] = "false";
            }

            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
       
        }

        private void chk_upe_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            
            if (chk_upe.Checked)
            {
                txt_upe.Enabled = true;
                txt_upe.Text = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY] = "true";
            }
            else
            {
                txt_upe.Enabled = false;
                txt_upe.Text = "0";
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY] = "false";
            }

            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
           
        }

        private void chk_abs_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            if (chk_abs.Checked)
            {
                txt_abs.Enabled = true;
                txt_abs.Text = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF] = "true";
            }
            else
            {
                txt_abs.Enabled = false;
                txt_abs.Text = "0";
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF] = "false";
            }

            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
           
        }

        private void chk_ems_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;


            if (chk_ems.Checked)
            {
                txt_ems.Enabled = true;
                txt_ems.Text = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP] = "true";
            }
            else
            {
                txt_ems.Enabled = false;
                txt_ems.Text = "0";
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP] = "false";
            }

            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
            
        }

        private void chk_ups_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            
            if (chk_ups.Checked)
            {
                txt_ups.Enabled = true;
                txt_ups.Text = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING] = "true";
            }
            else
            {
                txt_ups.Enabled = false;
                txt_ups.Text = "0";
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING] = "false";
            }

            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
            
        }

        private void chk_fss_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            if (chk_fss.Checked)
            {
                txt_fss.Enabled = true;
                txt_fss.Text = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT] = "true";
            }
            else
            {
                txt_fss.Enabled = false;
                txt_fss.Text = "0";
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT] = "false";
            }

            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
           
        }

        private void chk_fga_CheckedChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;


            if (chk_fga.Checked)
            {
                txt_fga.Enabled = true;
                txt_fga.Text = flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFGA_QTY].ToString();
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY] = "true";
            }
            else
            {
                txt_fga.Enabled = false;
                txt_fga.Text = "0";
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY] = "false";
            }
        
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
            
        }
        #endregion

        #region TextBox Setting
        private void txt_cutting_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
              return;
                
            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCUTTING_QTY] = txt_cutting.Text;
                
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")                    
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";

        }

        private void txt_ph_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxCMP_PRESS_QTY] = txt_ph.Text;

            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";

           
        }

        private void txt_pu_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxPU_SPRAY_QTY] = txt_pu.Text;
             
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";

 
        }

        private void txt_ip_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxIP_SPRAY_QTY] = txt_ip.Text;

            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";


        }

        private void txt_os_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxOS_PRESS_QTY] = txt_os.Text;

            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";


        }

        private void txt_upe_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxEMBROIDERY_QTY] = txt_upe.Text;
                        
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";

        
        }

        private void txt_abs_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHF_QTY] = txt_abs.Text;
                        
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";

        
        }

        private void txt_ems_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxHP_QTY] = txt_ems.Text;
                        
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";

            
        }

        private void txt_ups_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTITCHING_QTY] = txt_ups.Text;
                    
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";

        
        }

        private void txt_fss_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;

            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTOCKFIT_QTY] = txt_fss.Text;
            
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";

            
        }

        private void txt_fga_TextChanged(object sender, EventArgs e)
        {
            if (click_flg)
                return;
            
            flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxASSEMBLY_QTY] = txt_fga.Text;
                        
            if (flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION].ToString() != "I")
                flg_project[flg_project.Selection.r1, (int)ClassLib.TBSXG_WS_DEV_VJ.IxDIVISION] = "U";
        
        }
        #endregion

        #region Data Retry
        private void mnu_retry_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int sct_row = flg_project.Selection.r1;

                string[] arg_value = new string[4];
                
                arg_value[0] = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxFACTORY].ToString().Trim();
                arg_value[1] = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_NO].ToString().Trim();
                arg_value[2] = flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxLOT_SEQ].ToString().Trim();
                arg_value[3] = "T";

                if (Retry_Data(arg_value))
                {
                    flg_project[sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS] = arg_value[3];
                    flg_project.GetCellRange(sct_row, (int)ClassLib.TBSXG_WS_DEV_VJ.IxSTATUS).StyleNew.BackColor = Color.Yellow;

                    click_flg = true;
                    Set_DataToControl(sct_row);
                    click_flg = false;

                    mnu_retry.Enabled = false;
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

        private bool Retry_Data(string [] arg_value)
        {
            try
            {
                OraDB.ReDim_Parameter(5);
                OraDB.Process_Name = "PKG_SXG_MPS_01.SAVE_SXG_MPS_RETURN";

                OraDB.Parameter_Name[0] = "ARG_FACTORY";
                OraDB.Parameter_Name[1] = "ARG_LOT_NO";
                OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
                OraDB.Parameter_Name[3] = "ARG_STATUS";
                OraDB.Parameter_Name[4] = "ARG_UPD_USER";

                OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                OraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                OraDB.Parameter_Values[0] = arg_value[0];
                OraDB.Parameter_Values[1] = arg_value[1];
                OraDB.Parameter_Values[2] = arg_value[2];
                OraDB.Parameter_Values[3] = arg_value[3];
                OraDB.Parameter_Values[4] = COM.ComVar.This_User;

                OraDB.Add_Modify_Parameter(true);
                OraDB.Exe_Modify_Procedure();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }        
        #endregion

        private void btn_sms_chem_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_project.Selection.r1;

                Pop_Worksheet_Huser_VJ user = new Pop_Worksheet_Huser_VJ(this, "C");
                user.ShowDialog();

                click_flg = true;
                Set_DataToControl(sct_row);
                click_flg = false;

            }
            catch
            {

            }
        }
        

        /*Status 값 변경         
         * N - Ready
         * Y - Request
         * U - Editing
         * C - Confirm
         * X - Close
         * T - Retry
         */
    }
}



