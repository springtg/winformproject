using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;

namespace FlexCDC.BaseInfo
{
	public class Pop_Code_Editer : COM.PCHWinForm.Pop_Large_B
	{

		private COM.OraDB OraDB = new COM.OraDB();
		private int _MatRowFixed;
		private int _ColRowFixed;
		private int _PartRowFixed;
		private int _McsRowFixed;
		private string pcc_unit = null;


		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage tab_part;
		private COM.FSP fgrid_part;
		public System.Windows.Forms.Panel pnl_part;
		private System.Windows.Forms.TextBox txt_part_code;
		private System.Windows.Forms.Label lbl_part_code;
		private System.Windows.Forms.Label btn_part_search;
		private System.Windows.Forms.TextBox txt_part_name;
		private System.Windows.Forms.Label lbl_part_name;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.TextBox textBox20;
		public System.Windows.Forms.Panel panel6;
		public System.Windows.Forms.PictureBox pictureBox36;
		public System.Windows.Forms.PictureBox pictureBox37;
		public System.Windows.Forms.PictureBox pictureBox38;
		public System.Windows.Forms.Label lbl_part_title;
		public System.Windows.Forms.PictureBox pictureBox39;
		public System.Windows.Forms.PictureBox pictureBox40;
		public System.Windows.Forms.PictureBox pictureBox41;
		public System.Windows.Forms.PictureBox pictureBox42;
		public System.Windows.Forms.PictureBox pictureBox43;
		public System.Windows.Forms.PictureBox pictureBox44;
		private System.Windows.Forms.TabPage tab_mat;
		private COM.FSP fgrid_matcd;
		public System.Windows.Forms.Panel pnl_mat;
		private System.Windows.Forms.Label btn_Search;
		private System.Windows.Forms.TextBox txt_matname;
		private System.Windows.Forms.Label lbl_matname;
		private System.Windows.Forms.TextBox txt_matcd;
		private System.Windows.Forms.Label lbl_matcd;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.TextBox textBox34;
		private System.Windows.Forms.TextBox textBox36;
		private System.Windows.Forms.TextBox textBox33;
		private System.Windows.Forms.TextBox textBox32;
		private System.Windows.Forms.TextBox textBox31;
		public System.Windows.Forms.Panel pnl_SearchImage;
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
		private System.Windows.Forms.TabPage tab_color;
		private COM.FSP fgrid_colorcd;
		public System.Windows.Forms.Panel pnl_color;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_colorname;
		private System.Windows.Forms.Label lbl_colorname;
		private System.Windows.Forms.TextBox txt_colorcode;
		private System.Windows.Forms.Label lbl_colorcd;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		public System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.TabPage tab_mcs;
		private COM.FSP fgrid_mcs;
		public System.Windows.Forms.Panel pnl_mcs;
		private System.Windows.Forms.Label btn_mcs;
		private System.Windows.Forms.TextBox txt_mcs;
		private System.Windows.Forms.Label lbl_mcs;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		public System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.PictureBox pictureBox18;
		public System.Windows.Forms.PictureBox pictureBox19;
		public System.Windows.Forms.PictureBox pictureBox20;
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.PictureBox pictureBox21;
		public System.Windows.Forms.PictureBox pictureBox22;
		public System.Windows.Forms.PictureBox pictureBox23;
		public System.Windows.Forms.PictureBox pictureBox24;
		public System.Windows.Forms.PictureBox pictureBox25;
		public System.Windows.Forms.PictureBox pictureBox26;
		private System.Windows.Forms.TextBox txt_m_spec;
		private System.Windows.Forms.Label lbl_m_spec;
		public System.Windows.Forms.Panel pnl_code;
		private System.Windows.Forms.TextBox txt_m_mat_comp_seq;
		private System.Windows.Forms.Label lbl_m_mat_comp_seq;
		private System.Windows.Forms.TextBox txt_m_matcd;
		private System.Windows.Forms.Label lbl_m_matcd;
		private System.Windows.Forms.TextBox txt_m_desc;
		private System.Windows.Forms.Label lbl_m_desc;
		private System.Windows.Forms.TextBox txt_s_mcs;
		private System.Windows.Forms.Label lbl_s_mcs;
		private System.Windows.Forms.TextBox txt_c_comp;
		private System.Windows.Forms.TextBox txt_c_name;
		private System.Windows.Forms.TextBox txt_c_code;
		private System.Windows.Forms.Label lbl_c_name;
		private System.Windows.Forms.Label lbl_c_comp;
		private System.Windows.Forms.Label lbl_c_code;
		private System.Windows.Forms.TextBox txt_m_comp;
		private System.Windows.Forms.TextBox txt_m_name;
		private System.Windows.Forms.Label lbl_m_comp;
		private System.Windows.Forms.Label lbl_m_name;
		public System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.PictureBox pictureBox27;
		public System.Windows.Forms.PictureBox pictureBox28;
		public System.Windows.Forms.PictureBox pictureBox29;
		public System.Windows.Forms.Label lbl_titel01;
		public System.Windows.Forms.PictureBox pictureBox30;
		public System.Windows.Forms.PictureBox pictureBox31;
		public System.Windows.Forms.PictureBox pictureBox32;
		public System.Windows.Forms.PictureBox pictureBox33;
		public System.Windows.Forms.PictureBox pictureBox34;
		public System.Windows.Forms.PictureBox pictureBox35;
		private System.Windows.Forms.TextBox txt_m_yield;
		private System.Windows.Forms.Label lbl_m_yield;
		private System.Windows.Forms.Label lbl_m_unit;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Panel pnl_part_code;
		private System.Windows.Forms.TextBox txt_p_qty;
		private System.Windows.Forms.Label lbl_p_qty;
		private System.Windows.Forms.TextBox txt_p_desc;
		private System.Windows.Forms.Label lbl_p_desc;
		private System.Windows.Forms.TextBox txt_p_type;
		private System.Windows.Forms.Label lbl_p_type;
		private System.Windows.Forms.TextBox txt_p_seq;
		private System.Windows.Forms.Label lbl_p_seq;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.TextBox textBox25;
		public System.Windows.Forms.Panel panel7;
		public System.Windows.Forms.PictureBox pictureBox45;
		public System.Windows.Forms.PictureBox pictureBox46;
		public System.Windows.Forms.PictureBox pictureBox47;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.PictureBox pictureBox48;
		public System.Windows.Forms.PictureBox pictureBox49;
		public System.Windows.Forms.PictureBox pictureBox50;
		public System.Windows.Forms.PictureBox pictureBox51;
		public System.Windows.Forms.PictureBox pictureBox52;
		public System.Windows.Forms.PictureBox pictureBox53;
		private C1.Win.C1List.C1Combo cmb_unit;
		private System.Windows.Forms.TextBox textBox26;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox27;
		private System.Windows.Forms.Label label7;
		private System.ComponentModel.IContainer components = null;

		private CDC_Bom.Form_Bom_Editer formBomEditer = null;
		private Purchase.Form_Pur_request_master formReqEditer = null;
		private string edit_type = "P";
		private int edit_row =0;
		private string change_r_flg = "U";

		public Pop_Code_Editer()
		{
			// ¿Ã »£√‚¿∫ Windows Form µ¿⁄¿Ã≥ ø° « ø‰«’¥œ¥Ÿ.
			InitializeComponent();

			// TODO: InitializeComponent∏¶ »£√‚«— ¥Ÿ¿Ω √ ±‚»≠ ¿€æ˜¿ª √ﬂ∞°«’¥œ¥Ÿ.
		}


		public Pop_Code_Editer(CDC_Bom.Form_Bom_Editer arg_form, string arg_edit_type, int arg_edit_row, string arg_change_r_flg)
		{
			// ¿Ã »£√‚¿∫ Windows Form µ¿⁄¿Ã≥ ø° « ø‰«’¥œ¥Ÿ.
			InitializeComponent();

			// TODO: InitializeComponent∏¶ »£√‚«— ¥Ÿ¿Ω √ ±‚»≠ ¿€æ˜¿ª √ﬂ∞°«’¥œ¥Ÿ.

			formBomEditer = arg_form;
			edit_type = arg_edit_type;
			edit_row = arg_edit_row;
			change_r_flg = arg_change_r_flg;
		}

		public Pop_Code_Editer(Purchase.Form_Pur_request_master arg_form, string arg_edit_type, int arg_edit_row, string arg_change_r_flg)
		{
			// ¿Ã »£√‚¿∫ Windows Form µ¿⁄¿Ã≥ ø° « ø‰«’¥œ¥Ÿ.
			InitializeComponent();

			// TODO: InitializeComponent∏¶ »£√‚«— ¥Ÿ¿Ω √ ±‚»≠ ¿€æ˜¿ª √ﬂ∞°«’¥œ¥Ÿ.

			formReqEditer = arg_form;
			edit_type = arg_edit_type;
			edit_row = arg_edit_row;
			change_r_flg = arg_change_r_flg;
		}

		/// <summary>
		/// ªÁøÎ ¡ﬂ¿Œ ∏µÁ ∏Æº“Ω∫∏¶ ¡§∏Æ«’¥œ¥Ÿ.
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

		#region µ¿⁄¿Ã≥ ø°º≠ ª˝º∫«— ƒ⁄µÂ
		/// <summary>
		/// µ¿⁄¿Ã≥  ¡ˆø¯ø° « ø‰«— ∏ﬁº≠µÂ¿‘¥œ¥Ÿ.
		/// ¿Ã ∏ﬁº≠µÂ¿« ≥ªøÎ¿ª ƒ⁄µÂ ∆Ì¡˝±‚∑Œ ºˆ¡§«œ¡ˆ ∏∂Ω Ω√ø¿.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Code_Editer));
			this.TabControl = new System.Windows.Forms.TabControl();
			this.tab_part = new System.Windows.Forms.TabPage();
			this.fgrid_part = new COM.FSP();
			this.pnl_part = new System.Windows.Forms.Panel();
			this.txt_part_code = new System.Windows.Forms.TextBox();
			this.lbl_part_code = new System.Windows.Forms.Label();
			this.btn_part_search = new System.Windows.Forms.Label();
			this.txt_part_name = new System.Windows.Forms.TextBox();
			this.lbl_part_name = new System.Windows.Forms.Label();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.pictureBox36 = new System.Windows.Forms.PictureBox();
			this.pictureBox37 = new System.Windows.Forms.PictureBox();
			this.pictureBox38 = new System.Windows.Forms.PictureBox();
			this.lbl_part_title = new System.Windows.Forms.Label();
			this.pictureBox39 = new System.Windows.Forms.PictureBox();
			this.pictureBox40 = new System.Windows.Forms.PictureBox();
			this.pictureBox41 = new System.Windows.Forms.PictureBox();
			this.pictureBox42 = new System.Windows.Forms.PictureBox();
			this.pictureBox43 = new System.Windows.Forms.PictureBox();
			this.pictureBox44 = new System.Windows.Forms.PictureBox();
			this.tab_mat = new System.Windows.Forms.TabPage();
			this.fgrid_matcd = new COM.FSP();
			this.pnl_mat = new System.Windows.Forms.Panel();
			this.btn_Search = new System.Windows.Forms.Label();
			this.txt_matname = new System.Windows.Forms.TextBox();
			this.lbl_matname = new System.Windows.Forms.Label();
			this.txt_matcd = new System.Windows.Forms.TextBox();
			this.lbl_matcd = new System.Windows.Forms.Label();
			this.textBox35 = new System.Windows.Forms.TextBox();
			this.textBox34 = new System.Windows.Forms.TextBox();
			this.textBox36 = new System.Windows.Forms.TextBox();
			this.textBox33 = new System.Windows.Forms.TextBox();
			this.textBox32 = new System.Windows.Forms.TextBox();
			this.textBox31 = new System.Windows.Forms.TextBox();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
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
			this.tab_color = new System.Windows.Forms.TabPage();
			this.fgrid_colorcd = new COM.FSP();
			this.pnl_color = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_colorname = new System.Windows.Forms.TextBox();
			this.lbl_colorname = new System.Windows.Forms.Label();
			this.txt_colorcode = new System.Windows.Forms.TextBox();
			this.lbl_colorcd = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.tab_mcs = new System.Windows.Forms.TabPage();
			this.fgrid_mcs = new COM.FSP();
			this.pnl_mcs = new System.Windows.Forms.Panel();
			this.btn_mcs = new System.Windows.Forms.Label();
			this.txt_mcs = new System.Windows.Forms.TextBox();
			this.lbl_mcs = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
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
			this.txt_m_spec = new System.Windows.Forms.TextBox();
			this.lbl_m_spec = new System.Windows.Forms.Label();
			this.pnl_code = new System.Windows.Forms.Panel();
			this.cmb_unit = new C1.Win.C1List.C1Combo();
			this.textBox26 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox27 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_m_mat_comp_seq = new System.Windows.Forms.TextBox();
			this.lbl_m_mat_comp_seq = new System.Windows.Forms.Label();
			this.txt_m_matcd = new System.Windows.Forms.TextBox();
			this.lbl_m_matcd = new System.Windows.Forms.Label();
			this.txt_m_desc = new System.Windows.Forms.TextBox();
			this.lbl_m_desc = new System.Windows.Forms.Label();
			this.txt_s_mcs = new System.Windows.Forms.TextBox();
			this.lbl_s_mcs = new System.Windows.Forms.Label();
			this.txt_c_comp = new System.Windows.Forms.TextBox();
			this.txt_c_name = new System.Windows.Forms.TextBox();
			this.txt_c_code = new System.Windows.Forms.TextBox();
			this.lbl_c_name = new System.Windows.Forms.Label();
			this.lbl_c_comp = new System.Windows.Forms.Label();
			this.lbl_c_code = new System.Windows.Forms.Label();
			this.txt_m_comp = new System.Windows.Forms.TextBox();
			this.txt_m_name = new System.Windows.Forms.TextBox();
			this.lbl_m_comp = new System.Windows.Forms.Label();
			this.lbl_m_name = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.pictureBox28 = new System.Windows.Forms.PictureBox();
			this.pictureBox29 = new System.Windows.Forms.PictureBox();
			this.lbl_titel01 = new System.Windows.Forms.Label();
			this.pictureBox30 = new System.Windows.Forms.PictureBox();
			this.pictureBox31 = new System.Windows.Forms.PictureBox();
			this.pictureBox32 = new System.Windows.Forms.PictureBox();
			this.pictureBox33 = new System.Windows.Forms.PictureBox();
			this.pictureBox34 = new System.Windows.Forms.PictureBox();
			this.pictureBox35 = new System.Windows.Forms.PictureBox();
			this.txt_m_yield = new System.Windows.Forms.TextBox();
			this.lbl_m_yield = new System.Windows.Forms.Label();
			this.lbl_m_unit = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pnl_part_code = new System.Windows.Forms.Panel();
			this.txt_p_qty = new System.Windows.Forms.TextBox();
			this.lbl_p_qty = new System.Windows.Forms.Label();
			this.txt_p_desc = new System.Windows.Forms.TextBox();
			this.lbl_p_desc = new System.Windows.Forms.Label();
			this.txt_p_type = new System.Windows.Forms.TextBox();
			this.lbl_p_type = new System.Windows.Forms.Label();
			this.txt_p_seq = new System.Windows.Forms.TextBox();
			this.lbl_p_seq = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox21 = new System.Windows.Forms.TextBox();
			this.textBox22 = new System.Windows.Forms.TextBox();
			this.textBox23 = new System.Windows.Forms.TextBox();
			this.textBox24 = new System.Windows.Forms.TextBox();
			this.textBox25 = new System.Windows.Forms.TextBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.pictureBox45 = new System.Windows.Forms.PictureBox();
			this.pictureBox46 = new System.Windows.Forms.PictureBox();
			this.pictureBox47 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox48 = new System.Windows.Forms.PictureBox();
			this.pictureBox49 = new System.Windows.Forms.PictureBox();
			this.pictureBox50 = new System.Windows.Forms.PictureBox();
			this.pictureBox51 = new System.Windows.Forms.PictureBox();
			this.pictureBox52 = new System.Windows.Forms.PictureBox();
			this.pictureBox53 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.TabControl.SuspendLayout();
			this.tab_part.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_part)).BeginInit();
			this.pnl_part.SuspendLayout();
			this.panel6.SuspendLayout();
			this.tab_mat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_matcd)).BeginInit();
			this.pnl_mat.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.tab_color.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_colorcd)).BeginInit();
			this.pnl_color.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tab_mcs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_mcs)).BeginInit();
			this.pnl_mcs.SuspendLayout();
			this.panel4.SuspendLayout();
			this.pnl_code.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_unit)).BeginInit();
			this.panel3.SuspendLayout();
			this.pnl_part_code.SuspendLayout();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Menu
			// 
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// TabControl
			// 
			this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.TabControl.Controls.Add(this.tab_part);
			this.TabControl.Controls.Add(this.tab_mat);
			this.TabControl.Controls.Add(this.tab_color);
			this.TabControl.Controls.Add(this.tab_mcs);
			this.TabControl.Location = new System.Drawing.Point(8, 80);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(776, 352);
			this.TabControl.TabIndex = 137;
			this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
			// 
			// tab_part
			// 
			this.tab_part.BackColor = System.Drawing.Color.Transparent;
			this.tab_part.Controls.Add(this.fgrid_part);
			this.tab_part.Controls.Add(this.pnl_part);
			this.tab_part.Location = new System.Drawing.Point(4, 21);
			this.tab_part.Name = "tab_part";
			this.tab_part.Size = new System.Drawing.Size(768, 327);
			this.tab_part.TabIndex = 0;
			this.tab_part.Text = "Part";
			// 
			// fgrid_part
			// 
			this.fgrid_part.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.fgrid_part.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_part.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_part.AutoResize = false;
			this.fgrid_part.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_part.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_part.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_part.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_part.Location = new System.Drawing.Point(0, 79);
			this.fgrid_part.Name = "fgrid_part";
			this.fgrid_part.Rows.Fixed = 0;
			this.fgrid_part.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_part.Size = new System.Drawing.Size(768, 248);
			this.fgrid_part.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:±º∏≤, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_part.TabIndex = 133;
			this.fgrid_part.DoubleClick += new System.EventHandler(this.fgrid_part_DoubleClick);
			// 
			// pnl_part
			// 
			this.pnl_part.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_part.Controls.Add(this.txt_part_code);
			this.pnl_part.Controls.Add(this.lbl_part_code);
			this.pnl_part.Controls.Add(this.btn_part_search);
			this.pnl_part.Controls.Add(this.txt_part_name);
			this.pnl_part.Controls.Add(this.lbl_part_name);
			this.pnl_part.Controls.Add(this.textBox15);
			this.pnl_part.Controls.Add(this.textBox16);
			this.pnl_part.Controls.Add(this.textBox17);
			this.pnl_part.Controls.Add(this.textBox18);
			this.pnl_part.Controls.Add(this.textBox19);
			this.pnl_part.Controls.Add(this.textBox20);
			this.pnl_part.Controls.Add(this.panel6);
			this.pnl_part.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_part.DockPadding.Bottom = 8;
			this.pnl_part.DockPadding.Top = 8;
			this.pnl_part.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.pnl_part.Location = new System.Drawing.Point(0, 0);
			this.pnl_part.Name = "pnl_part";
			this.pnl_part.Size = new System.Drawing.Size(768, 80);
			this.pnl_part.TabIndex = 131;
			// 
			// txt_part_code
			// 
			this.txt_part_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_part_code.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_part_code.Location = new System.Drawing.Point(109, 40);
			this.txt_part_code.Name = "txt_part_code";
			this.txt_part_code.TabIndex = 306;
			this.txt_part_code.Text = "";
			// 
			// lbl_part_code
			// 
			this.lbl_part_code.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_part_code.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_part_code.ImageIndex = 0;
			this.lbl_part_code.ImageList = this.img_Label;
			this.lbl_part_code.Location = new System.Drawing.Point(8, 40);
			this.lbl_part_code.Name = "lbl_part_code";
			this.lbl_part_code.Size = new System.Drawing.Size(100, 21);
			this.lbl_part_code.TabIndex = 305;
			this.lbl_part_code.Text = "Part Code";
			this.lbl_part_code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_part_search
			// 
			this.btn_part_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_part_search.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_part_search.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.btn_part_search.ImageIndex = 0;
			this.btn_part_search.ImageList = this.img_Button;
			this.btn_part_search.Location = new System.Drawing.Point(672, 39);
			this.btn_part_search.Name = "btn_part_search";
			this.btn_part_search.Size = new System.Drawing.Size(80, 23);
			this.btn_part_search.TabIndex = 304;
			this.btn_part_search.Text = "Search";
			this.btn_part_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_part_search.Click += new System.EventHandler(this.btn_part_search_Click);
			// 
			// txt_part_name
			// 
			this.txt_part_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_part_name.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_part_name.Location = new System.Drawing.Point(317, 40);
			this.txt_part_name.Name = "txt_part_name";
			this.txt_part_name.Size = new System.Drawing.Size(200, 21);
			this.txt_part_name.TabIndex = 301;
			this.txt_part_name.Text = "";
			// 
			// lbl_part_name
			// 
			this.lbl_part_name.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_part_name.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_part_name.ImageIndex = 0;
			this.lbl_part_name.ImageList = this.img_Label;
			this.lbl_part_name.Location = new System.Drawing.Point(216, 40);
			this.lbl_part_name.Name = "lbl_part_name";
			this.lbl_part_name.Size = new System.Drawing.Size(100, 21);
			this.lbl_part_name.TabIndex = 296;
			this.lbl_part_name.Text = "Part Name";
			this.lbl_part_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox15
			// 
			this.textBox15.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox15.ForeColor = System.Drawing.Color.Black;
			this.textBox15.Location = new System.Drawing.Point(768, 304);
			this.textBox15.MaxLength = 100;
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(150, 21);
			this.textBox15.TabIndex = 270;
			this.textBox15.Tag = "60";
			this.textBox15.Text = "";
			// 
			// textBox16
			// 
			this.textBox16.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox16.ForeColor = System.Drawing.Color.Black;
			this.textBox16.Location = new System.Drawing.Point(560, 304);
			this.textBox16.MaxLength = 100;
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(150, 21);
			this.textBox16.TabIndex = 268;
			this.textBox16.Tag = "60";
			this.textBox16.Text = "";
			// 
			// textBox17
			// 
			this.textBox17.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox17.ForeColor = System.Drawing.Color.Black;
			this.textBox17.Location = new System.Drawing.Point(384, 328);
			this.textBox17.MaxLength = 100;
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(416, 21);
			this.textBox17.TabIndex = 267;
			this.textBox17.Tag = "60";
			this.textBox17.Text = "";
			// 
			// textBox18
			// 
			this.textBox18.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox18.ForeColor = System.Drawing.Color.Black;
			this.textBox18.Location = new System.Drawing.Point(376, 304);
			this.textBox18.MaxLength = 100;
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(150, 21);
			this.textBox18.TabIndex = 264;
			this.textBox18.Tag = "60";
			this.textBox18.Text = "";
			// 
			// textBox19
			// 
			this.textBox19.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox19.ForeColor = System.Drawing.Color.Black;
			this.textBox19.Location = new System.Drawing.Point(200, 304);
			this.textBox19.MaxLength = 100;
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new System.Drawing.Size(150, 21);
			this.textBox19.TabIndex = 263;
			this.textBox19.Tag = "60";
			this.textBox19.Text = "";
			// 
			// textBox20
			// 
			this.textBox20.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox20.ForeColor = System.Drawing.Color.Black;
			this.textBox20.Location = new System.Drawing.Point(24, 304);
			this.textBox20.MaxLength = 100;
			this.textBox20.Name = "textBox20";
			this.textBox20.Size = new System.Drawing.Size(150, 21);
			this.textBox20.TabIndex = 262;
			this.textBox20.Tag = "60";
			this.textBox20.Text = "";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.Window;
			this.panel6.Controls.Add(this.pictureBox36);
			this.panel6.Controls.Add(this.pictureBox37);
			this.panel6.Controls.Add(this.pictureBox38);
			this.panel6.Controls.Add(this.lbl_part_title);
			this.panel6.Controls.Add(this.pictureBox39);
			this.panel6.Controls.Add(this.pictureBox40);
			this.panel6.Controls.Add(this.pictureBox41);
			this.panel6.Controls.Add(this.pictureBox42);
			this.panel6.Controls.Add(this.pictureBox43);
			this.panel6.Controls.Add(this.pictureBox44);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel6.Location = new System.Drawing.Point(0, 8);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(768, 64);
			this.panel6.TabIndex = 18;
			// 
			// pictureBox36
			// 
			this.pictureBox36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox36.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
			this.pictureBox36.Location = new System.Drawing.Point(751, 30);
			this.pictureBox36.Name = "pictureBox36";
			this.pictureBox36.Size = new System.Drawing.Size(24, 21);
			this.pictureBox36.TabIndex = 26;
			this.pictureBox36.TabStop = false;
			// 
			// pictureBox37
			// 
			this.pictureBox37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox37.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
			this.pictureBox37.Location = new System.Drawing.Point(752, 0);
			this.pictureBox37.Name = "pictureBox37";
			this.pictureBox37.Size = new System.Drawing.Size(16, 32);
			this.pictureBox37.TabIndex = 21;
			this.pictureBox37.TabStop = false;
			// 
			// pictureBox38
			// 
			this.pictureBox38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox38.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
			this.pictureBox38.Location = new System.Drawing.Point(224, 0);
			this.pictureBox38.Name = "pictureBox38";
			this.pictureBox38.Size = new System.Drawing.Size(768, 40);
			this.pictureBox38.TabIndex = 0;
			this.pictureBox38.TabStop = false;
			// 
			// lbl_part_title
			// 
			this.lbl_part_title.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_part_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_part_title.ForeColor = System.Drawing.Color.Navy;
			this.lbl_part_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_part_title.Image")));
			this.lbl_part_title.Location = new System.Drawing.Point(0, 0);
			this.lbl_part_title.Name = "lbl_part_title";
			this.lbl_part_title.Size = new System.Drawing.Size(231, 30);
			this.lbl_part_title.TabIndex = 28;
			this.lbl_part_title.Text = "      Search Part";
			this.lbl_part_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox39
			// 
			this.pictureBox39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox39.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
			this.pictureBox39.Location = new System.Drawing.Point(752, 49);
			this.pictureBox39.Name = "pictureBox39";
			this.pictureBox39.Size = new System.Drawing.Size(16, 16);
			this.pictureBox39.TabIndex = 23;
			this.pictureBox39.TabStop = false;
			// 
			// pictureBox40
			// 
			this.pictureBox40.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox40.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
			this.pictureBox40.Location = new System.Drawing.Point(144, 48);
			this.pictureBox40.Name = "pictureBox40";
			this.pictureBox40.Size = new System.Drawing.Size(768, 18);
			this.pictureBox40.TabIndex = 24;
			this.pictureBox40.TabStop = false;
			// 
			// pictureBox41
			// 
			this.pictureBox41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox41.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox41.Image")));
			this.pictureBox41.Location = new System.Drawing.Point(0, 49);
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
			this.pictureBox42.Size = new System.Drawing.Size(168, 31);
			this.pictureBox42.TabIndex = 25;
			this.pictureBox42.TabStop = false;
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
			this.pictureBox43.Size = new System.Drawing.Size(768, 24);
			this.pictureBox43.TabIndex = 27;
			this.pictureBox43.TabStop = false;
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
			this.pictureBox44.Size = new System.Drawing.Size(768, 24);
			this.pictureBox44.TabIndex = 27;
			this.pictureBox44.TabStop = false;
			// 
			// tab_mat
			// 
			this.tab_mat.BackColor = System.Drawing.Color.Transparent;
			this.tab_mat.Controls.Add(this.fgrid_matcd);
			this.tab_mat.Controls.Add(this.pnl_mat);
			this.tab_mat.Location = new System.Drawing.Point(4, 21);
			this.tab_mat.Name = "tab_mat";
			this.tab_mat.Size = new System.Drawing.Size(768, 327);
			this.tab_mat.TabIndex = 1;
			this.tab_mat.Text = "Material";
			this.tab_mat.Visible = false;
			// 
			// fgrid_matcd
			// 
			this.fgrid_matcd.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.fgrid_matcd.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_matcd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_matcd.AutoResize = false;
			this.fgrid_matcd.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_matcd.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_matcd.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_matcd.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_matcd.Location = new System.Drawing.Point(0, 79);
			this.fgrid_matcd.Name = "fgrid_matcd";
			this.fgrid_matcd.Rows.Fixed = 0;
			this.fgrid_matcd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_matcd.Size = new System.Drawing.Size(768, 248);
			this.fgrid_matcd.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:±º∏≤, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_matcd.TabIndex = 132;
			this.fgrid_matcd.DoubleClick += new System.EventHandler(this.fgrid_matcd_DoubleClick);
			// 
			// pnl_mat
			// 
			this.pnl_mat.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_mat.Controls.Add(this.btn_Search);
			this.pnl_mat.Controls.Add(this.txt_matname);
			this.pnl_mat.Controls.Add(this.lbl_matname);
			this.pnl_mat.Controls.Add(this.txt_matcd);
			this.pnl_mat.Controls.Add(this.lbl_matcd);
			this.pnl_mat.Controls.Add(this.textBox35);
			this.pnl_mat.Controls.Add(this.textBox34);
			this.pnl_mat.Controls.Add(this.textBox36);
			this.pnl_mat.Controls.Add(this.textBox33);
			this.pnl_mat.Controls.Add(this.textBox32);
			this.pnl_mat.Controls.Add(this.textBox31);
			this.pnl_mat.Controls.Add(this.pnl_SearchImage);
			this.pnl_mat.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_mat.DockPadding.Bottom = 8;
			this.pnl_mat.DockPadding.Top = 8;
			this.pnl_mat.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.pnl_mat.Location = new System.Drawing.Point(0, 0);
			this.pnl_mat.Name = "pnl_mat";
			this.pnl_mat.Size = new System.Drawing.Size(768, 80);
			this.pnl_mat.TabIndex = 130;
			// 
			// btn_Search
			// 
			this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Search.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_Button;
			this.btn_Search.Location = new System.Drawing.Point(672, 39);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(80, 23);
			this.btn_Search.TabIndex = 304;
			this.btn_Search.Text = "Search";
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// txt_matname
			// 
			this.txt_matname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_matname.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_matname.Location = new System.Drawing.Point(317, 40);
			this.txt_matname.Name = "txt_matname";
			this.txt_matname.Size = new System.Drawing.Size(200, 21);
			this.txt_matname.TabIndex = 303;
			this.txt_matname.Text = "";
			// 
			// lbl_matname
			// 
			this.lbl_matname.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_matname.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_matname.ImageIndex = 0;
			this.lbl_matname.ImageList = this.img_Label;
			this.lbl_matname.Location = new System.Drawing.Point(216, 40);
			this.lbl_matname.Name = "lbl_matname";
			this.lbl_matname.Size = new System.Drawing.Size(100, 21);
			this.lbl_matname.TabIndex = 302;
			this.lbl_matname.Text = "Mat Name";
			this.lbl_matname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_matcd
			// 
			this.txt_matcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_matcd.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_matcd.Location = new System.Drawing.Point(109, 40);
			this.txt_matcd.Name = "txt_matcd";
			this.txt_matcd.TabIndex = 301;
			this.txt_matcd.Text = "";
			// 
			// lbl_matcd
			// 
			this.lbl_matcd.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_matcd.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_matcd.ImageIndex = 0;
			this.lbl_matcd.ImageList = this.img_Label;
			this.lbl_matcd.Location = new System.Drawing.Point(8, 40);
			this.lbl_matcd.Name = "lbl_matcd";
			this.lbl_matcd.Size = new System.Drawing.Size(100, 21);
			this.lbl_matcd.TabIndex = 296;
			this.lbl_matcd.Text = "Mat Code";
			this.lbl_matcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox35
			// 
			this.textBox35.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox35.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox35.ForeColor = System.Drawing.Color.Black;
			this.textBox35.Location = new System.Drawing.Point(768, 304);
			this.textBox35.MaxLength = 100;
			this.textBox35.Name = "textBox35";
			this.textBox35.Size = new System.Drawing.Size(150, 21);
			this.textBox35.TabIndex = 270;
			this.textBox35.Tag = "60";
			this.textBox35.Text = "";
			// 
			// textBox34
			// 
			this.textBox34.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox34.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox34.ForeColor = System.Drawing.Color.Black;
			this.textBox34.Location = new System.Drawing.Point(560, 304);
			this.textBox34.MaxLength = 100;
			this.textBox34.Name = "textBox34";
			this.textBox34.Size = new System.Drawing.Size(150, 21);
			this.textBox34.TabIndex = 268;
			this.textBox34.Tag = "60";
			this.textBox34.Text = "";
			// 
			// textBox36
			// 
			this.textBox36.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox36.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox36.ForeColor = System.Drawing.Color.Black;
			this.textBox36.Location = new System.Drawing.Point(384, 328);
			this.textBox36.MaxLength = 100;
			this.textBox36.Name = "textBox36";
			this.textBox36.Size = new System.Drawing.Size(416, 21);
			this.textBox36.TabIndex = 267;
			this.textBox36.Tag = "60";
			this.textBox36.Text = "";
			// 
			// textBox33
			// 
			this.textBox33.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox33.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox33.ForeColor = System.Drawing.Color.Black;
			this.textBox33.Location = new System.Drawing.Point(376, 304);
			this.textBox33.MaxLength = 100;
			this.textBox33.Name = "textBox33";
			this.textBox33.Size = new System.Drawing.Size(150, 21);
			this.textBox33.TabIndex = 264;
			this.textBox33.Tag = "60";
			this.textBox33.Text = "";
			// 
			// textBox32
			// 
			this.textBox32.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox32.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox32.ForeColor = System.Drawing.Color.Black;
			this.textBox32.Location = new System.Drawing.Point(200, 304);
			this.textBox32.MaxLength = 100;
			this.textBox32.Name = "textBox32";
			this.textBox32.Size = new System.Drawing.Size(150, 21);
			this.textBox32.TabIndex = 263;
			this.textBox32.Tag = "60";
			this.textBox32.Text = "";
			// 
			// textBox31
			// 
			this.textBox31.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox31.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox31.ForeColor = System.Drawing.Color.Black;
			this.textBox31.Location = new System.Drawing.Point(24, 304);
			this.textBox31.MaxLength = 100;
			this.textBox31.Name = "textBox31";
			this.textBox31.Size = new System.Drawing.Size(150, 21);
			this.textBox31.TabIndex = 262;
			this.textBox31.Tag = "60";
			this.textBox31.Text = "";
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
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
			this.pnl_SearchImage.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(768, 64);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(751, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(24, 21);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(752, 0);
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
			this.pictureBox3.Size = new System.Drawing.Size(768, 40);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_title
			// 
			this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_title.ForeColor = System.Drawing.Color.Navy;
			this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
			this.lbl_title.Location = new System.Drawing.Point(0, 0);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(231, 30);
			this.lbl_title.TabIndex = 28;
			this.lbl_title.Text = "      Search Material";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(752, 49);
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
			this.pictureBox5.Location = new System.Drawing.Point(144, 48);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(768, 18);
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 49);
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
			this.pictureBox7.Size = new System.Drawing.Size(168, 31);
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
			this.pictureBox8.Size = new System.Drawing.Size(768, 24);
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
			this.pictureBox9.Size = new System.Drawing.Size(768, 24);
			this.pictureBox9.TabIndex = 27;
			this.pictureBox9.TabStop = false;
			// 
			// tab_color
			// 
			this.tab_color.BackColor = System.Drawing.Color.Transparent;
			this.tab_color.Controls.Add(this.fgrid_colorcd);
			this.tab_color.Controls.Add(this.pnl_color);
			this.tab_color.Location = new System.Drawing.Point(4, 21);
			this.tab_color.Name = "tab_color";
			this.tab_color.Size = new System.Drawing.Size(768, 327);
			this.tab_color.TabIndex = 2;
			this.tab_color.Text = "Color";
			this.tab_color.Visible = false;
			// 
			// fgrid_colorcd
			// 
			this.fgrid_colorcd.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.fgrid_colorcd.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_colorcd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_colorcd.AutoResize = false;
			this.fgrid_colorcd.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_colorcd.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_colorcd.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_colorcd.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_colorcd.Location = new System.Drawing.Point(0, 79);
			this.fgrid_colorcd.Name = "fgrid_colorcd";
			this.fgrid_colorcd.Rows.Fixed = 0;
			this.fgrid_colorcd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_colorcd.Size = new System.Drawing.Size(768, 248);
			this.fgrid_colorcd.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:±º∏≤, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_colorcd.TabIndex = 134;
			this.fgrid_colorcd.DoubleClick += new System.EventHandler(this.fgrid_colorcd_DoubleClick);
			// 
			// pnl_color
			// 
			this.pnl_color.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_color.Controls.Add(this.label1);
			this.pnl_color.Controls.Add(this.txt_colorname);
			this.pnl_color.Controls.Add(this.lbl_colorname);
			this.pnl_color.Controls.Add(this.txt_colorcode);
			this.pnl_color.Controls.Add(this.lbl_colorcd);
			this.pnl_color.Controls.Add(this.textBox3);
			this.pnl_color.Controls.Add(this.textBox4);
			this.pnl_color.Controls.Add(this.textBox5);
			this.pnl_color.Controls.Add(this.textBox6);
			this.pnl_color.Controls.Add(this.textBox7);
			this.pnl_color.Controls.Add(this.textBox8);
			this.pnl_color.Controls.Add(this.panel2);
			this.pnl_color.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_color.DockPadding.Bottom = 8;
			this.pnl_color.DockPadding.Top = 8;
			this.pnl_color.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.pnl_color.Location = new System.Drawing.Point(0, 0);
			this.pnl_color.Name = "pnl_color";
			this.pnl_color.Size = new System.Drawing.Size(768, 80);
			this.pnl_color.TabIndex = 133;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Button;
			this.label1.Location = new System.Drawing.Point(672, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 304;
			this.label1.Text = "Search";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txt_colorname
			// 
			this.txt_colorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_colorname.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_colorname.Location = new System.Drawing.Point(317, 40);
			this.txt_colorname.Name = "txt_colorname";
			this.txt_colorname.Size = new System.Drawing.Size(200, 21);
			this.txt_colorname.TabIndex = 303;
			this.txt_colorname.Text = "";
			// 
			// lbl_colorname
			// 
			this.lbl_colorname.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_colorname.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_colorname.ImageIndex = 0;
			this.lbl_colorname.ImageList = this.img_Label;
			this.lbl_colorname.Location = new System.Drawing.Point(216, 40);
			this.lbl_colorname.Name = "lbl_colorname";
			this.lbl_colorname.Size = new System.Drawing.Size(100, 21);
			this.lbl_colorname.TabIndex = 302;
			this.lbl_colorname.Text = "Color Name";
			this.lbl_colorname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_colorcode
			// 
			this.txt_colorcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_colorcode.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_colorcode.Location = new System.Drawing.Point(109, 40);
			this.txt_colorcode.Name = "txt_colorcode";
			this.txt_colorcode.TabIndex = 301;
			this.txt_colorcode.Text = "";
			// 
			// lbl_colorcd
			// 
			this.lbl_colorcd.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_colorcd.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_colorcd.ImageIndex = 0;
			this.lbl_colorcd.ImageList = this.img_Label;
			this.lbl_colorcd.Location = new System.Drawing.Point(8, 40);
			this.lbl_colorcd.Name = "lbl_colorcd";
			this.lbl_colorcd.Size = new System.Drawing.Size(100, 21);
			this.lbl_colorcd.TabIndex = 296;
			this.lbl_colorcd.Text = "Color Code";
			this.lbl_colorcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox3.ForeColor = System.Drawing.Color.Black;
			this.textBox3.Location = new System.Drawing.Point(768, 304);
			this.textBox3.MaxLength = 100;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(150, 21);
			this.textBox3.TabIndex = 270;
			this.textBox3.Tag = "60";
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox4.ForeColor = System.Drawing.Color.Black;
			this.textBox4.Location = new System.Drawing.Point(560, 304);
			this.textBox4.MaxLength = 100;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(150, 21);
			this.textBox4.TabIndex = 268;
			this.textBox4.Tag = "60";
			this.textBox4.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox5.ForeColor = System.Drawing.Color.Black;
			this.textBox5.Location = new System.Drawing.Point(384, 328);
			this.textBox5.MaxLength = 100;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(416, 21);
			this.textBox5.TabIndex = 267;
			this.textBox5.Tag = "60";
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox6.ForeColor = System.Drawing.Color.Black;
			this.textBox6.Location = new System.Drawing.Point(376, 304);
			this.textBox6.MaxLength = 100;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(150, 21);
			this.textBox6.TabIndex = 264;
			this.textBox6.Tag = "60";
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox7.ForeColor = System.Drawing.Color.Black;
			this.textBox7.Location = new System.Drawing.Point(200, 304);
			this.textBox7.MaxLength = 100;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(150, 21);
			this.textBox7.TabIndex = 263;
			this.textBox7.Tag = "60";
			this.textBox7.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox8.ForeColor = System.Drawing.Color.Black;
			this.textBox8.Location = new System.Drawing.Point(24, 304);
			this.textBox8.MaxLength = 100;
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(150, 21);
			this.textBox8.TabIndex = 262;
			this.textBox8.Tag = "60";
			this.textBox8.Text = "";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.pictureBox10);
			this.panel2.Controls.Add(this.pictureBox11);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.pictureBox12);
			this.panel2.Controls.Add(this.pictureBox13);
			this.panel2.Controls.Add(this.pictureBox14);
			this.panel2.Controls.Add(this.pictureBox15);
			this.panel2.Controls.Add(this.pictureBox16);
			this.panel2.Controls.Add(this.pictureBox17);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(0, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 64);
			this.panel2.TabIndex = 18;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(751, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 21);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(752, 0);
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
			this.pictureBox11.Size = new System.Drawing.Size(768, 40);
			this.pictureBox11.TabIndex = 0;
			this.pictureBox11.TabStop = false;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.Window;
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Navy;
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(231, 30);
			this.label6.TabIndex = 28;
			this.label6.Text = "      Search Color";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(752, 49);
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
			this.pictureBox13.Location = new System.Drawing.Point(144, 48);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(768, 18);
			this.pictureBox13.TabIndex = 24;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 49);
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
			this.pictureBox15.Size = new System.Drawing.Size(168, 31);
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
			this.pictureBox16.Size = new System.Drawing.Size(768, 24);
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
			this.pictureBox17.Size = new System.Drawing.Size(768, 24);
			this.pictureBox17.TabIndex = 27;
			this.pictureBox17.TabStop = false;
			// 
			// tab_mcs
			// 
			this.tab_mcs.BackColor = System.Drawing.Color.Transparent;
			this.tab_mcs.Controls.Add(this.fgrid_mcs);
			this.tab_mcs.Controls.Add(this.pnl_mcs);
			this.tab_mcs.Location = new System.Drawing.Point(4, 21);
			this.tab_mcs.Name = "tab_mcs";
			this.tab_mcs.Size = new System.Drawing.Size(768, 327);
			this.tab_mcs.TabIndex = 3;
			this.tab_mcs.Text = "MCS";
			this.tab_mcs.Visible = false;
			// 
			// fgrid_mcs
			// 
			this.fgrid_mcs.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.fgrid_mcs.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_mcs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_mcs.AutoResize = false;
			this.fgrid_mcs.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_mcs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_mcs.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_mcs.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_mcs.Location = new System.Drawing.Point(0, 79);
			this.fgrid_mcs.Name = "fgrid_mcs";
			this.fgrid_mcs.Rows.Fixed = 0;
			this.fgrid_mcs.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_mcs.Size = new System.Drawing.Size(768, 248);
			this.fgrid_mcs.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:±º∏≤, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_mcs.TabIndex = 136;
			this.fgrid_mcs.DoubleClick += new System.EventHandler(this.fgrid_mcs_DoubleClick);
			// 
			// pnl_mcs
			// 
			this.pnl_mcs.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_mcs.Controls.Add(this.btn_mcs);
			this.pnl_mcs.Controls.Add(this.txt_mcs);
			this.pnl_mcs.Controls.Add(this.lbl_mcs);
			this.pnl_mcs.Controls.Add(this.textBox9);
			this.pnl_mcs.Controls.Add(this.textBox10);
			this.pnl_mcs.Controls.Add(this.textBox11);
			this.pnl_mcs.Controls.Add(this.textBox12);
			this.pnl_mcs.Controls.Add(this.textBox13);
			this.pnl_mcs.Controls.Add(this.textBox14);
			this.pnl_mcs.Controls.Add(this.panel4);
			this.pnl_mcs.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_mcs.DockPadding.Bottom = 8;
			this.pnl_mcs.DockPadding.Top = 8;
			this.pnl_mcs.Location = new System.Drawing.Point(0, 0);
			this.pnl_mcs.Name = "pnl_mcs";
			this.pnl_mcs.Size = new System.Drawing.Size(768, 80);
			this.pnl_mcs.TabIndex = 135;
			// 
			// btn_mcs
			// 
			this.btn_mcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_mcs.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_mcs.ImageIndex = 0;
			this.btn_mcs.ImageList = this.img_Button;
			this.btn_mcs.Location = new System.Drawing.Point(672, 39);
			this.btn_mcs.Name = "btn_mcs";
			this.btn_mcs.Size = new System.Drawing.Size(80, 23);
			this.btn_mcs.TabIndex = 304;
			this.btn_mcs.Text = "Search";
			this.btn_mcs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_mcs.Click += new System.EventHandler(this.btn_mcs_Click);
			// 
			// txt_mcs
			// 
			this.txt_mcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_mcs.Location = new System.Drawing.Point(109, 40);
			this.txt_mcs.Name = "txt_mcs";
			this.txt_mcs.Size = new System.Drawing.Size(200, 21);
			this.txt_mcs.TabIndex = 303;
			this.txt_mcs.Text = "";
			// 
			// lbl_mcs
			// 
			this.lbl_mcs.ImageIndex = 0;
			this.lbl_mcs.ImageList = this.img_Label;
			this.lbl_mcs.Location = new System.Drawing.Point(8, 40);
			this.lbl_mcs.Name = "lbl_mcs";
			this.lbl_mcs.Size = new System.Drawing.Size(100, 21);
			this.lbl_mcs.TabIndex = 302;
			this.lbl_mcs.Text = "MCS Name";
			this.lbl_mcs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox9
			// 
			this.textBox9.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox9.ForeColor = System.Drawing.Color.Black;
			this.textBox9.Location = new System.Drawing.Point(768, 304);
			this.textBox9.MaxLength = 100;
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(150, 21);
			this.textBox9.TabIndex = 270;
			this.textBox9.Tag = "60";
			this.textBox9.Text = "";
			// 
			// textBox10
			// 
			this.textBox10.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox10.ForeColor = System.Drawing.Color.Black;
			this.textBox10.Location = new System.Drawing.Point(560, 304);
			this.textBox10.MaxLength = 100;
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(150, 21);
			this.textBox10.TabIndex = 268;
			this.textBox10.Tag = "60";
			this.textBox10.Text = "";
			// 
			// textBox11
			// 
			this.textBox11.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox11.ForeColor = System.Drawing.Color.Black;
			this.textBox11.Location = new System.Drawing.Point(384, 328);
			this.textBox11.MaxLength = 100;
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(416, 21);
			this.textBox11.TabIndex = 267;
			this.textBox11.Tag = "60";
			this.textBox11.Text = "";
			// 
			// textBox12
			// 
			this.textBox12.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox12.ForeColor = System.Drawing.Color.Black;
			this.textBox12.Location = new System.Drawing.Point(376, 304);
			this.textBox12.MaxLength = 100;
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(150, 21);
			this.textBox12.TabIndex = 264;
			this.textBox12.Tag = "60";
			this.textBox12.Text = "";
			// 
			// textBox13
			// 
			this.textBox13.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox13.ForeColor = System.Drawing.Color.Black;
			this.textBox13.Location = new System.Drawing.Point(200, 304);
			this.textBox13.MaxLength = 100;
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(150, 21);
			this.textBox13.TabIndex = 263;
			this.textBox13.Tag = "60";
			this.textBox13.Text = "";
			// 
			// textBox14
			// 
			this.textBox14.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox14.ForeColor = System.Drawing.Color.Black;
			this.textBox14.Location = new System.Drawing.Point(24, 304);
			this.textBox14.MaxLength = 100;
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(150, 21);
			this.textBox14.TabIndex = 262;
			this.textBox14.Tag = "60";
			this.textBox14.Text = "";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Window;
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
			this.panel4.Location = new System.Drawing.Point(0, 8);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(768, 64);
			this.panel4.TabIndex = 18;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(751, 30);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(24, 21);
			this.pictureBox18.TabIndex = 26;
			this.pictureBox18.TabStop = false;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(752, 0);
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
			this.pictureBox20.Size = new System.Drawing.Size(768, 40);
			this.pictureBox20.TabIndex = 0;
			this.pictureBox20.TabStop = false;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.Window;
			this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Navy;
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(231, 30);
			this.label8.TabIndex = 28;
			this.label8.Text = "      Search MCS";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(752, 49);
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
			this.pictureBox22.Location = new System.Drawing.Point(144, 48);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(768, 18);
			this.pictureBox22.TabIndex = 24;
			this.pictureBox22.TabStop = false;
			// 
			// pictureBox23
			// 
			this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox23.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
			this.pictureBox23.Location = new System.Drawing.Point(0, 49);
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
			this.pictureBox24.Size = new System.Drawing.Size(168, 31);
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
			this.pictureBox25.Size = new System.Drawing.Size(768, 24);
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
			this.pictureBox26.Size = new System.Drawing.Size(768, 24);
			this.pictureBox26.TabIndex = 27;
			this.pictureBox26.TabStop = false;
			// 
			// txt_m_spec
			// 
			this.txt_m_spec.Location = new System.Drawing.Point(0, 0);
			this.txt_m_spec.Name = "txt_m_spec";
			this.txt_m_spec.TabIndex = 0;
			this.txt_m_spec.Text = "";
			// 
			// lbl_m_spec
			// 
			this.lbl_m_spec.Location = new System.Drawing.Point(0, 0);
			this.lbl_m_spec.Name = "lbl_m_spec";
			this.lbl_m_spec.TabIndex = 0;
			// 
			// pnl_code
			// 
			this.pnl_code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_code.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_code.Controls.Add(this.cmb_unit);
			this.pnl_code.Controls.Add(this.textBox26);
			this.pnl_code.Controls.Add(this.label3);
			this.pnl_code.Controls.Add(this.label5);
			this.pnl_code.Controls.Add(this.textBox27);
			this.pnl_code.Controls.Add(this.label7);
			this.pnl_code.Controls.Add(this.txt_m_mat_comp_seq);
			this.pnl_code.Controls.Add(this.lbl_m_mat_comp_seq);
			this.pnl_code.Controls.Add(this.txt_m_matcd);
			this.pnl_code.Controls.Add(this.lbl_m_matcd);
			this.pnl_code.Controls.Add(this.txt_m_desc);
			this.pnl_code.Controls.Add(this.lbl_m_desc);
			this.pnl_code.Controls.Add(this.txt_s_mcs);
			this.pnl_code.Controls.Add(this.lbl_s_mcs);
			this.pnl_code.Controls.Add(this.txt_c_comp);
			this.pnl_code.Controls.Add(this.txt_c_name);
			this.pnl_code.Controls.Add(this.txt_c_code);
			this.pnl_code.Controls.Add(this.lbl_c_name);
			this.pnl_code.Controls.Add(this.lbl_c_comp);
			this.pnl_code.Controls.Add(this.lbl_c_code);
			this.pnl_code.Controls.Add(this.txt_m_comp);
			this.pnl_code.Controls.Add(this.txt_m_name);
			this.pnl_code.Controls.Add(this.lbl_m_comp);
			this.pnl_code.Controls.Add(this.lbl_m_name);
			this.pnl_code.Controls.Add(this.panel3);
			this.pnl_code.Controls.Add(this.txt_m_yield);
			this.pnl_code.Controls.Add(this.lbl_m_yield);
			this.pnl_code.Controls.Add(this.lbl_m_unit);
			this.pnl_code.Controls.Add(this.textBox1);
			this.pnl_code.Controls.Add(this.label2);
			this.pnl_code.DockPadding.Bottom = 8;
			this.pnl_code.DockPadding.Top = 8;
			this.pnl_code.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.pnl_code.Location = new System.Drawing.Point(8, 432);
			this.pnl_code.Name = "pnl_code";
			this.pnl_code.Size = new System.Drawing.Size(776, 344);
			this.pnl_code.TabIndex = 299;
			this.pnl_code.Visible = false;
			// 
			// cmb_unit
			// 
			this.cmb_unit.AddItemCols = 0;
			this.cmb_unit.AddItemSeparator = ';';
			this.cmb_unit.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_unit.Caption = "";
			this.cmb_unit.CaptionHeight = 17;
			this.cmb_unit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_unit.ColumnCaptionHeight = 18;
			this.cmb_unit.ColumnFooterHeight = 18;
			this.cmb_unit.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_unit.ContentHeight = 17;
			this.cmb_unit.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_unit.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_unit.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_unit.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_unit.EditorHeight = 17;
			this.cmb_unit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_unit.GapHeight = 2;
			this.cmb_unit.ItemHeight = 15;
			this.cmb_unit.Location = new System.Drawing.Point(341, 170);
			this.cmb_unit.MatchEntryTimeout = ((long)(2000));
			this.cmb_unit.MaxDropDownItems = ((short)(5));
			this.cmb_unit.MaxLength = 32767;
			this.cmb_unit.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_unit.Name = "cmb_unit";
			this.cmb_unit.PartialRightColumn = false;
			this.cmb_unit.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_unit.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_unit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_unit.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_unit.Size = new System.Drawing.Size(125, 21);
			this.cmb_unit.TabIndex = 336;
			this.cmb_unit.Visible = false;
			// 
			// textBox26
			// 
			this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox26.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.textBox26.Location = new System.Drawing.Point(573, 170);
			this.textBox26.Name = "textBox26";
			this.textBox26.Size = new System.Drawing.Size(125, 21);
			this.textBox26.TabIndex = 335;
			this.textBox26.Text = "";
			this.textBox26.Visible = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Window;
			this.label3.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(472, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 334;
			this.label3.Text = "Yeild";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Visible = false;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.Window;
			this.label5.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.label5.ImageIndex = 0;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(240, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 333;
			this.label5.Text = "Unit";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Visible = false;
			// 
			// textBox27
			// 
			this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox27.Enabled = false;
			this.textBox27.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.textBox27.Location = new System.Drawing.Point(109, 170);
			this.textBox27.Name = "textBox27";
			this.textBox27.Size = new System.Drawing.Size(125, 21);
			this.textBox27.TabIndex = 332;
			this.textBox27.Text = "";
			this.textBox27.Visible = false;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.Window;
			this.label7.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.label7.ImageIndex = 0;
			this.label7.ImageList = this.img_Label;
			this.label7.Location = new System.Drawing.Point(8, 170);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 21);
			this.label7.TabIndex = 331;
			this.label7.Text = "Spec";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label7.Visible = false;
			// 
			// txt_m_mat_comp_seq
			// 
			this.txt_m_mat_comp_seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_m_mat_comp_seq.Enabled = false;
			this.txt_m_mat_comp_seq.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_m_mat_comp_seq.Location = new System.Drawing.Point(341, 40);
			this.txt_m_mat_comp_seq.Name = "txt_m_mat_comp_seq";
			this.txt_m_mat_comp_seq.Size = new System.Drawing.Size(125, 21);
			this.txt_m_mat_comp_seq.TabIndex = 325;
			this.txt_m_mat_comp_seq.Text = "";
			this.txt_m_mat_comp_seq.Visible = false;
			// 
			// lbl_m_mat_comp_seq
			// 
			this.lbl_m_mat_comp_seq.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_m_mat_comp_seq.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_m_mat_comp_seq.ImageIndex = 0;
			this.lbl_m_mat_comp_seq.ImageList = this.img_Label;
			this.lbl_m_mat_comp_seq.Location = new System.Drawing.Point(240, 40);
			this.lbl_m_mat_comp_seq.Name = "lbl_m_mat_comp_seq";
			this.lbl_m_mat_comp_seq.Size = new System.Drawing.Size(100, 21);
			this.lbl_m_mat_comp_seq.TabIndex = 324;
			this.lbl_m_mat_comp_seq.Text = "Comment Seq";
			this.lbl_m_mat_comp_seq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_m_mat_comp_seq.Visible = false;
			// 
			// txt_m_matcd
			// 
			this.txt_m_matcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_m_matcd.Enabled = false;
			this.txt_m_matcd.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_m_matcd.Location = new System.Drawing.Point(109, 40);
			this.txt_m_matcd.Name = "txt_m_matcd";
			this.txt_m_matcd.Size = new System.Drawing.Size(125, 21);
			this.txt_m_matcd.TabIndex = 323;
			this.txt_m_matcd.Text = "";
			// 
			// lbl_m_matcd
			// 
			this.lbl_m_matcd.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_m_matcd.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_m_matcd.ImageIndex = 0;
			this.lbl_m_matcd.ImageList = this.img_Label;
			this.lbl_m_matcd.Location = new System.Drawing.Point(8, 40);
			this.lbl_m_matcd.Name = "lbl_m_matcd";
			this.lbl_m_matcd.Size = new System.Drawing.Size(100, 21);
			this.lbl_m_matcd.TabIndex = 322;
			this.lbl_m_matcd.Text = "MTL#";
			this.lbl_m_matcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_m_desc
			// 
			this.txt_m_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_m_desc.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_m_desc.Location = new System.Drawing.Point(109, 127);
			this.txt_m_desc.Multiline = true;
			this.txt_m_desc.Name = "txt_m_desc";
			this.txt_m_desc.ReadOnly = true;
			this.txt_m_desc.Size = new System.Drawing.Size(659, 42);
			this.txt_m_desc.TabIndex = 321;
			this.txt_m_desc.Text = "";
			// 
			// lbl_m_desc
			// 
			this.lbl_m_desc.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_m_desc.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_m_desc.ImageIndex = 0;
			this.lbl_m_desc.ImageList = this.img_Label;
			this.lbl_m_desc.Location = new System.Drawing.Point(8, 127);
			this.lbl_m_desc.Name = "lbl_m_desc";
			this.lbl_m_desc.Size = new System.Drawing.Size(100, 21);
			this.lbl_m_desc.TabIndex = 320;
			this.lbl_m_desc.Text = "Mat Desc";
			this.lbl_m_desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_s_mcs
			// 
			this.txt_s_mcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_s_mcs.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_s_mcs.Location = new System.Drawing.Point(109, 304);
			this.txt_s_mcs.Name = "txt_s_mcs";
			this.txt_s_mcs.Size = new System.Drawing.Size(659, 21);
			this.txt_s_mcs.TabIndex = 319;
			this.txt_s_mcs.Text = "";
			// 
			// lbl_s_mcs
			// 
			this.lbl_s_mcs.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_s_mcs.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_s_mcs.ImageIndex = 0;
			this.lbl_s_mcs.ImageList = this.img_Label;
			this.lbl_s_mcs.Location = new System.Drawing.Point(8, 304);
			this.lbl_s_mcs.Name = "lbl_s_mcs";
			this.lbl_s_mcs.Size = new System.Drawing.Size(100, 21);
			this.lbl_s_mcs.TabIndex = 318;
			this.lbl_s_mcs.Text = "MCS";
			this.lbl_s_mcs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_c_comp
			// 
			this.txt_c_comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_c_comp.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_c_comp.Location = new System.Drawing.Point(109, 260);
			this.txt_c_comp.Name = "txt_c_comp";
			this.txt_c_comp.Size = new System.Drawing.Size(659, 21);
			this.txt_c_comp.TabIndex = 317;
			this.txt_c_comp.Text = "";
			// 
			// txt_c_name
			// 
			this.txt_c_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_c_name.Enabled = false;
			this.txt_c_name.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_c_name.Location = new System.Drawing.Point(109, 238);
			this.txt_c_name.Name = "txt_c_name";
			this.txt_c_name.Size = new System.Drawing.Size(659, 21);
			this.txt_c_name.TabIndex = 316;
			this.txt_c_name.Text = "";
			// 
			// txt_c_code
			// 
			this.txt_c_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_c_code.Enabled = false;
			this.txt_c_code.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_c_code.Location = new System.Drawing.Point(109, 216);
			this.txt_c_code.Name = "txt_c_code";
			this.txt_c_code.Size = new System.Drawing.Size(125, 21);
			this.txt_c_code.TabIndex = 315;
			this.txt_c_code.Text = "";
			// 
			// lbl_c_name
			// 
			this.lbl_c_name.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_c_name.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_c_name.ImageIndex = 0;
			this.lbl_c_name.ImageList = this.img_Label;
			this.lbl_c_name.Location = new System.Drawing.Point(8, 238);
			this.lbl_c_name.Name = "lbl_c_name";
			this.lbl_c_name.Size = new System.Drawing.Size(100, 21);
			this.lbl_c_name.TabIndex = 314;
			this.lbl_c_name.Text = "Color Desc";
			this.lbl_c_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_c_comp
			// 
			this.lbl_c_comp.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_c_comp.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_c_comp.ImageIndex = 0;
			this.lbl_c_comp.ImageList = this.img_Label;
			this.lbl_c_comp.Location = new System.Drawing.Point(8, 260);
			this.lbl_c_comp.Name = "lbl_c_comp";
			this.lbl_c_comp.Size = new System.Drawing.Size(100, 21);
			this.lbl_c_comp.TabIndex = 313;
			this.lbl_c_comp.Text = "Color Comment";
			this.lbl_c_comp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_c_code
			// 
			this.lbl_c_code.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_c_code.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_c_code.ImageIndex = 0;
			this.lbl_c_code.ImageList = this.img_Label;
			this.lbl_c_code.Location = new System.Drawing.Point(8, 216);
			this.lbl_c_code.Name = "lbl_c_code";
			this.lbl_c_code.Size = new System.Drawing.Size(100, 21);
			this.lbl_c_code.TabIndex = 312;
			this.lbl_c_code.Text = "Color";
			this.lbl_c_code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_m_comp
			// 
			this.txt_m_comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_m_comp.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_m_comp.Location = new System.Drawing.Point(109, 105);
			this.txt_m_comp.Name = "txt_m_comp";
			this.txt_m_comp.Size = new System.Drawing.Size(659, 21);
			this.txt_m_comp.TabIndex = 305;
			this.txt_m_comp.Text = "";
			// 
			// txt_m_name
			// 
			this.txt_m_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_m_name.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_m_name.Location = new System.Drawing.Point(109, 62);
			this.txt_m_name.Multiline = true;
			this.txt_m_name.Name = "txt_m_name";
			this.txt_m_name.Size = new System.Drawing.Size(659, 42);
			this.txt_m_name.TabIndex = 304;
			this.txt_m_name.Text = "";
			// 
			// lbl_m_comp
			// 
			this.lbl_m_comp.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_m_comp.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_m_comp.ImageIndex = 0;
			this.lbl_m_comp.ImageList = this.img_Label;
			this.lbl_m_comp.Location = new System.Drawing.Point(8, 105);
			this.lbl_m_comp.Name = "lbl_m_comp";
			this.lbl_m_comp.Size = new System.Drawing.Size(100, 21);
			this.lbl_m_comp.TabIndex = 298;
			this.lbl_m_comp.Text = "Mat Comment";
			this.lbl_m_comp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_m_name
			// 
			this.lbl_m_name.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_m_name.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_m_name.ImageIndex = 0;
			this.lbl_m_name.ImageList = this.img_Label;
			this.lbl_m_name.Location = new System.Drawing.Point(8, 62);
			this.lbl_m_name.Name = "lbl_m_name";
			this.lbl_m_name.Size = new System.Drawing.Size(100, 21);
			this.lbl_m_name.TabIndex = 297;
			this.lbl_m_name.Text = "Mat Name";
			this.lbl_m_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.pictureBox27);
			this.panel3.Controls.Add(this.pictureBox28);
			this.panel3.Controls.Add(this.pictureBox29);
			this.panel3.Controls.Add(this.lbl_titel01);
			this.panel3.Controls.Add(this.pictureBox30);
			this.panel3.Controls.Add(this.pictureBox31);
			this.panel3.Controls.Add(this.pictureBox32);
			this.panel3.Controls.Add(this.pictureBox33);
			this.panel3.Controls.Add(this.pictureBox34);
			this.panel3.Controls.Add(this.pictureBox35);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel3.Location = new System.Drawing.Point(0, 8);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(776, 328);
			this.panel3.TabIndex = 18;
			// 
			// pictureBox27
			// 
			this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox27.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
			this.pictureBox27.Location = new System.Drawing.Point(759, 30);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(24, 285);
			this.pictureBox27.TabIndex = 26;
			this.pictureBox27.TabStop = false;
			// 
			// pictureBox28
			// 
			this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox28.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
			this.pictureBox28.Location = new System.Drawing.Point(760, 0);
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
			this.pictureBox29.Size = new System.Drawing.Size(776, 40);
			this.pictureBox29.TabIndex = 0;
			this.pictureBox29.TabStop = false;
			// 
			// lbl_titel01
			// 
			this.lbl_titel01.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_titel01.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_titel01.ForeColor = System.Drawing.Color.Navy;
			this.lbl_titel01.Image = ((System.Drawing.Image)(resources.GetObject("lbl_titel01.Image")));
			this.lbl_titel01.Location = new System.Drawing.Point(0, 0);
			this.lbl_titel01.Name = "lbl_titel01";
			this.lbl_titel01.Size = new System.Drawing.Size(231, 30);
			this.lbl_titel01.TabIndex = 28;
			this.lbl_titel01.Text = "      Selected Code";
			this.lbl_titel01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox30
			// 
			this.pictureBox30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox30.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
			this.pictureBox30.Location = new System.Drawing.Point(760, 313);
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
			this.pictureBox31.Location = new System.Drawing.Point(144, 312);
			this.pictureBox31.Name = "pictureBox31";
			this.pictureBox31.Size = new System.Drawing.Size(776, 18);
			this.pictureBox31.TabIndex = 24;
			this.pictureBox31.TabStop = false;
			// 
			// pictureBox32
			// 
			this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox32.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
			this.pictureBox32.Location = new System.Drawing.Point(0, 313);
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
			this.pictureBox33.Size = new System.Drawing.Size(168, 295);
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
			this.pictureBox34.Size = new System.Drawing.Size(776, 288);
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
			this.pictureBox35.Size = new System.Drawing.Size(776, 288);
			this.pictureBox35.TabIndex = 27;
			this.pictureBox35.TabStop = false;
			// 
			// txt_m_yield
			// 
			this.txt_m_yield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_m_yield.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_m_yield.Location = new System.Drawing.Point(573, 170);
			this.txt_m_yield.Name = "txt_m_yield";
			this.txt_m_yield.Size = new System.Drawing.Size(125, 21);
			this.txt_m_yield.TabIndex = 311;
			this.txt_m_yield.Text = "";
			this.txt_m_yield.Visible = false;
			// 
			// lbl_m_yield
			// 
			this.lbl_m_yield.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_m_yield.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_m_yield.ImageIndex = 0;
			this.lbl_m_yield.ImageList = this.img_Label;
			this.lbl_m_yield.Location = new System.Drawing.Point(472, 170);
			this.lbl_m_yield.Name = "lbl_m_yield";
			this.lbl_m_yield.Size = new System.Drawing.Size(100, 21);
			this.lbl_m_yield.TabIndex = 310;
			this.lbl_m_yield.Text = "Yeild";
			this.lbl_m_yield.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_m_yield.Visible = false;
			// 
			// lbl_m_unit
			// 
			this.lbl_m_unit.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_m_unit.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_m_unit.ImageIndex = 0;
			this.lbl_m_unit.ImageList = this.img_Label;
			this.lbl_m_unit.Location = new System.Drawing.Point(240, 170);
			this.lbl_m_unit.Name = "lbl_m_unit";
			this.lbl_m_unit.Size = new System.Drawing.Size(100, 21);
			this.lbl_m_unit.TabIndex = 308;
			this.lbl_m_unit.Text = "Unit";
			this.lbl_m_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_m_unit.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.textBox1.Location = new System.Drawing.Point(109, 170);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(125, 21);
			this.textBox1.TabIndex = 307;
			this.textBox1.Text = "";
			this.textBox1.Visible = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(8, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 306;
			this.label2.Text = "Spec";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Visible = false;
			// 
			// pnl_part_code
			// 
			this.pnl_part_code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_part_code.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_part_code.Controls.Add(this.txt_p_qty);
			this.pnl_part_code.Controls.Add(this.lbl_p_qty);
			this.pnl_part_code.Controls.Add(this.txt_p_desc);
			this.pnl_part_code.Controls.Add(this.lbl_p_desc);
			this.pnl_part_code.Controls.Add(this.txt_p_type);
			this.pnl_part_code.Controls.Add(this.lbl_p_type);
			this.pnl_part_code.Controls.Add(this.txt_p_seq);
			this.pnl_part_code.Controls.Add(this.lbl_p_seq);
			this.pnl_part_code.Controls.Add(this.textBox2);
			this.pnl_part_code.Controls.Add(this.textBox21);
			this.pnl_part_code.Controls.Add(this.textBox22);
			this.pnl_part_code.Controls.Add(this.textBox23);
			this.pnl_part_code.Controls.Add(this.textBox24);
			this.pnl_part_code.Controls.Add(this.textBox25);
			this.pnl_part_code.Controls.Add(this.panel7);
			this.pnl_part_code.DockPadding.Bottom = 8;
			this.pnl_part_code.DockPadding.Top = 8;
			this.pnl_part_code.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.pnl_part_code.Location = new System.Drawing.Point(8, 432);
			this.pnl_part_code.Name = "pnl_part_code";
			this.pnl_part_code.Size = new System.Drawing.Size(776, 144);
			this.pnl_part_code.TabIndex = 329;
			// 
			// txt_p_qty
			// 
			this.txt_p_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_p_qty.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_p_qty.Location = new System.Drawing.Point(109, 106);
			this.txt_p_qty.Name = "txt_p_qty";
			this.txt_p_qty.ReadOnly = true;
			this.txt_p_qty.Size = new System.Drawing.Size(50, 21);
			this.txt_p_qty.TabIndex = 307;
			this.txt_p_qty.Text = "2";
			// 
			// lbl_p_qty
			// 
			this.lbl_p_qty.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_p_qty.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_p_qty.ImageIndex = 0;
			this.lbl_p_qty.ImageList = this.img_Label;
			this.lbl_p_qty.Location = new System.Drawing.Point(8, 106);
			this.lbl_p_qty.Name = "lbl_p_qty";
			this.lbl_p_qty.Size = new System.Drawing.Size(100, 21);
			this.lbl_p_qty.TabIndex = 306;
			this.lbl_p_qty.Text = "Part Qty";
			this.lbl_p_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_p_desc
			// 
			this.txt_p_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_p_desc.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_p_desc.Location = new System.Drawing.Point(109, 84);
			this.txt_p_desc.Name = "txt_p_desc";
			this.txt_p_desc.Size = new System.Drawing.Size(660, 21);
			this.txt_p_desc.TabIndex = 305;
			this.txt_p_desc.Text = "";
			// 
			// lbl_p_desc
			// 
			this.lbl_p_desc.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_p_desc.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_p_desc.ImageIndex = 0;
			this.lbl_p_desc.ImageList = this.img_Label;
			this.lbl_p_desc.Location = new System.Drawing.Point(8, 84);
			this.lbl_p_desc.Name = "lbl_p_desc";
			this.lbl_p_desc.Size = new System.Drawing.Size(100, 21);
			this.lbl_p_desc.TabIndex = 304;
			this.lbl_p_desc.Text = "Part Desc";
			this.lbl_p_desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_p_type
			// 
			this.txt_p_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_p_type.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_p_type.Location = new System.Drawing.Point(109, 62);
			this.txt_p_type.Name = "txt_p_type";
			this.txt_p_type.Size = new System.Drawing.Size(200, 21);
			this.txt_p_type.TabIndex = 303;
			this.txt_p_type.Text = "";
			// 
			// lbl_p_type
			// 
			this.lbl_p_type.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_p_type.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_p_type.ImageIndex = 0;
			this.lbl_p_type.ImageList = this.img_Label;
			this.lbl_p_type.Location = new System.Drawing.Point(8, 62);
			this.lbl_p_type.Name = "lbl_p_type";
			this.lbl_p_type.Size = new System.Drawing.Size(100, 21);
			this.lbl_p_type.TabIndex = 302;
			this.lbl_p_type.Text = "Part Type";
			this.lbl_p_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_p_seq
			// 
			this.txt_p_seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_p_seq.Enabled = false;
			this.txt_p_seq.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.txt_p_seq.Location = new System.Drawing.Point(109, 40);
			this.txt_p_seq.Name = "txt_p_seq";
			this.txt_p_seq.TabIndex = 301;
			this.txt_p_seq.Text = "";
			// 
			// lbl_p_seq
			// 
			this.lbl_p_seq.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_p_seq.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.lbl_p_seq.ImageIndex = 0;
			this.lbl_p_seq.ImageList = this.img_Label;
			this.lbl_p_seq.Location = new System.Drawing.Point(8, 40);
			this.lbl_p_seq.Name = "lbl_p_seq";
			this.lbl_p_seq.Size = new System.Drawing.Size(100, 21);
			this.lbl_p_seq.TabIndex = 296;
			this.lbl_p_seq.Text = "Part Seq";
			this.lbl_p_seq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_p_seq.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox2.ForeColor = System.Drawing.Color.Black;
			this.textBox2.Location = new System.Drawing.Point(768, 304);
			this.textBox2.MaxLength = 100;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(150, 21);
			this.textBox2.TabIndex = 270;
			this.textBox2.Tag = "60";
			this.textBox2.Text = "";
			// 
			// textBox21
			// 
			this.textBox21.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox21.ForeColor = System.Drawing.Color.Black;
			this.textBox21.Location = new System.Drawing.Point(560, 304);
			this.textBox21.MaxLength = 100;
			this.textBox21.Name = "textBox21";
			this.textBox21.Size = new System.Drawing.Size(150, 21);
			this.textBox21.TabIndex = 268;
			this.textBox21.Tag = "60";
			this.textBox21.Text = "";
			// 
			// textBox22
			// 
			this.textBox22.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox22.ForeColor = System.Drawing.Color.Black;
			this.textBox22.Location = new System.Drawing.Point(384, 328);
			this.textBox22.MaxLength = 100;
			this.textBox22.Name = "textBox22";
			this.textBox22.Size = new System.Drawing.Size(416, 21);
			this.textBox22.TabIndex = 267;
			this.textBox22.Tag = "60";
			this.textBox22.Text = "";
			// 
			// textBox23
			// 
			this.textBox23.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox23.ForeColor = System.Drawing.Color.Black;
			this.textBox23.Location = new System.Drawing.Point(376, 304);
			this.textBox23.MaxLength = 100;
			this.textBox23.Name = "textBox23";
			this.textBox23.Size = new System.Drawing.Size(150, 21);
			this.textBox23.TabIndex = 264;
			this.textBox23.Tag = "60";
			this.textBox23.Text = "";
			// 
			// textBox24
			// 
			this.textBox24.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox24.ForeColor = System.Drawing.Color.Black;
			this.textBox24.Location = new System.Drawing.Point(200, 304);
			this.textBox24.MaxLength = 100;
			this.textBox24.Name = "textBox24";
			this.textBox24.Size = new System.Drawing.Size(150, 21);
			this.textBox24.TabIndex = 263;
			this.textBox24.Tag = "60";
			this.textBox24.Text = "";
			// 
			// textBox25
			// 
			this.textBox25.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox25.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox25.ForeColor = System.Drawing.Color.Black;
			this.textBox25.Location = new System.Drawing.Point(24, 304);
			this.textBox25.MaxLength = 100;
			this.textBox25.Name = "textBox25";
			this.textBox25.Size = new System.Drawing.Size(150, 21);
			this.textBox25.TabIndex = 262;
			this.textBox25.Tag = "60";
			this.textBox25.Text = "";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.SystemColors.Window;
			this.panel7.Controls.Add(this.pictureBox45);
			this.panel7.Controls.Add(this.pictureBox46);
			this.panel7.Controls.Add(this.pictureBox47);
			this.panel7.Controls.Add(this.label4);
			this.panel7.Controls.Add(this.pictureBox48);
			this.panel7.Controls.Add(this.pictureBox49);
			this.panel7.Controls.Add(this.pictureBox50);
			this.panel7.Controls.Add(this.pictureBox51);
			this.panel7.Controls.Add(this.pictureBox52);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Font = new System.Drawing.Font("±º∏≤", 9F);
			this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel7.Location = new System.Drawing.Point(0, 8);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(776, 128);
			this.panel7.TabIndex = 18;
			// 
			// pictureBox45
			// 
			this.pictureBox45.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox45.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox45.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox45.Image")));
			this.pictureBox45.Location = new System.Drawing.Point(759, 30);
			this.pictureBox45.Name = "pictureBox45";
			this.pictureBox45.Size = new System.Drawing.Size(24, 85);
			this.pictureBox45.TabIndex = 26;
			this.pictureBox45.TabStop = false;
			// 
			// pictureBox46
			// 
			this.pictureBox46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox46.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox46.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox46.Image")));
			this.pictureBox46.Location = new System.Drawing.Point(760, 0);
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
			this.pictureBox47.Size = new System.Drawing.Size(776, 40);
			this.pictureBox47.TabIndex = 0;
			this.pictureBox47.TabStop = false;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Window;
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Navy;
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(231, 30);
			this.label4.TabIndex = 28;
			this.label4.Text = "      Selected Code";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox48
			// 
			this.pictureBox48.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox48.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox48.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox48.Image")));
			this.pictureBox48.Location = new System.Drawing.Point(760, 113);
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
			this.pictureBox49.Location = new System.Drawing.Point(144, 112);
			this.pictureBox49.Name = "pictureBox49";
			this.pictureBox49.Size = new System.Drawing.Size(776, 18);
			this.pictureBox49.TabIndex = 24;
			this.pictureBox49.TabStop = false;
			// 
			// pictureBox50
			// 
			this.pictureBox50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox50.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox50.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox50.Image")));
			this.pictureBox50.Location = new System.Drawing.Point(0, 113);
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
			this.pictureBox51.Size = new System.Drawing.Size(168, 95);
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
			this.pictureBox52.Size = new System.Drawing.Size(776, 88);
			this.pictureBox52.TabIndex = 27;
			this.pictureBox52.TabStop = false;
			// 
			// pictureBox53
			// 
			this.pictureBox53.Location = new System.Drawing.Point(0, 0);
			this.pictureBox53.Name = "pictureBox53";
			this.pictureBox53.TabIndex = 0;
			this.pictureBox53.TabStop = false;
			// 
			// Pop_Code_Editer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(792, 781);
			this.Controls.Add(this.pnl_part_code);
			this.Controls.Add(this.pnl_code);
			this.Controls.Add(this.TabControl);
			this.Name = "Pop_Code_Editer";
			this.Load += new System.EventHandler(this.Pop_Code_Editer_Load);
			this.Controls.SetChildIndex(this.TabControl, 0);
			this.Controls.SetChildIndex(this.pnl_code, 0);
			this.Controls.SetChildIndex(this.pnl_part_code, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.TabControl.ResumeLayout(false);
			this.tab_part.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_part)).EndInit();
			this.pnl_part.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.tab_mat.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_matcd)).EndInit();
			this.pnl_mat.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.tab_color.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_colorcd)).EndInit();
			this.pnl_color.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.tab_mcs.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_mcs)).EndInit();
			this.pnl_mcs.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.pnl_code.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_unit)).EndInit();
			this.panel3.ResumeLayout(false);
			this.pnl_part_code.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_Code_Editer_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{
			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SXC07");
			COM.ComCtl.Set_ComboList(dt_ret, cmb_unit, 1, 2,  true, COM.ComVar.ComboList_Visible.Code);

			if(pcc_unit != null) cmb_unit.SelectedValue = pcc_unit;
			else cmb_unit.SelectedIndex = 0;

			fgrid_part.Set_Grid("SXD_SRF_M_PART", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_part.Set_Action_Image(img_Action);
			fgrid_part.ExtendLastCol = false;
			_PartRowFixed = fgrid_part.Rows.Fixed;
			fgrid_part.AutoSizeCols();

			fgrid_matcd.Set_Grid("SXD_SRF_M_MAT", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_matcd.Set_Action_Image(img_Action);
			fgrid_matcd.ExtendLastCol = false;
			_MatRowFixed = fgrid_matcd.Rows.Fixed;
			fgrid_matcd.AutoSizeCols();

			fgrid_colorcd.Set_Grid("SXD_SRF_M_COLOR", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_colorcd.Set_Action_Image(img_Action);
			fgrid_colorcd.ExtendLastCol = false;
			_ColRowFixed = fgrid_colorcd.Rows.Fixed;
			fgrid_colorcd.AutoSizeCols();

			fgrid_mcs.Set_Grid("SXD_SRF_M_MCS", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_mcs.Set_Action_Image(img_Action);
			fgrid_mcs.ExtendLastCol = false;
			_McsRowFixed = fgrid_mcs.Rows.Fixed;
			fgrid_mcs.AutoSizeCols();




			if(formBomEditer!=null)
			{
				//part
				txt_p_seq.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_SEQ].ToString();
				txt_p_type.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_TYPE].ToString();
				txt_p_desc.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC].ToString();

				//mat
				txt_m_matcd.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD].ToString();
				txt_m_name.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_NAME].ToString();
				txt_m_comp.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_COMMENT].ToString();
				txt_m_desc.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_DESC].ToString();

				//				cmb_unit.SelectedValue = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD].ToString();
				//				txt_m_spec.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD].ToString();

				//color
				txt_c_code.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD].ToString();
				txt_c_name.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_DESC].ToString();
				txt_c_comp.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_COMMENT].ToString();

				//mcs
				txt_mcs.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMCS_CD].ToString();
			}
			else if(formReqEditer != null)
			{
				//part
				txt_p_seq.Text = formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_SEQ].ToString();
				txt_p_type.Text = formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_TYPE].ToString();
				txt_p_desc.Text = formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_DESC].ToString();

				//mat
				txt_m_matcd.Text = formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_CD].ToString();
				txt_m_name.Text = formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_NAME].ToString();
				txt_m_comp.Text = formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_COMMENT].ToString();

				//				cmb_unit.SelectedValue = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD].ToString();
				//				txt_m_spec.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD].ToString();

				//color
				txt_c_code.Text = formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_CD].ToString();
				txt_c_name.Text = formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_DESC].ToString();
				txt_c_comp.Text = formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_COMMENT].ToString();

				//mcs
				txt_mcs.Text = formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxMCS_CD].ToString();
			}

			
			if(edit_type.Equals("P")) TabControl.SelectedIndex = 0;
			else if(edit_type.Equals("M")) TabControl.SelectedIndex = 1;
			else if(edit_type.Equals("C")) TabControl.SelectedIndex = 2;
			else if(edit_type.Equals("S")) TabControl.SelectedIndex = 3;
		}

		private void TabControl_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(TabControl.SelectedTab == tab_part)
			{
				pnl_part_code.Visible = true;
				pnl_code.Visible = false;
			}
			else
			{
				pnl_part_code.Visible = false;
				pnl_code.Visible = true;
			}
		}

		private void btn_part_search_Click(object sender, System.EventArgs e)
		{
			Part_Show_data();
		}

		private void Part_Show_data()
		{
			fgrid_part.Rows.Count = _PartRowFixed;

			DataTable dt = Select_sdd_srf_m_part();
			int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;

			for(int i=0; i<dt_rows; i++)
			{
				fgrid_part.AddItem(dt.Rows[i].ItemArray, fgrid_part.Rows.Count, 1);
			}

			fgrid_part.AutoSizeCols();
		}

		private DataTable Select_sdd_srf_m_part()
		{
			string Proc_Name = "PKG_SXD_SRF_03_SELECT.select_sxd_srf_m_part";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "arg_part_seq";
			OraDB.Parameter_Name[2] = "arg_part_desc";
			OraDB.Parameter_Name[3] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			OraDB.Parameter_Values[1] = txt_part_code.Text.ToUpper();
			OraDB.Parameter_Values[2] = txt_part_name.Text.ToUpper();
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private void fgrid_part_DoubleClick(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_part.Selection.r1;
			int sct_col = fgrid_part.Selection.c1;

			string part_seq  = fgrid_part[sct_row, (int)ClassLib.TBSELECT_SDO_REQ_PART_INFO.IxPART_SEQ].ToString();
			string part_type = fgrid_part[sct_row, (int)ClassLib.TBSELECT_SDO_REQ_PART_INFO.IxPART_TYPE].ToString();
			string part_desc = fgrid_part[sct_row, (int)ClassLib.TBSELECT_SDO_REQ_PART_INFO.IxPART_DESC].ToString();

			txt_p_seq.Text = part_seq;
			txt_p_type.Text = part_type;
			txt_p_desc.Text = part_desc;

			//TabControl.SelectedIndex = 1;
		}

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			Mat_Show_data();
		}

		private void Mat_Show_data()
		{
			fgrid_matcd.Rows.Count = _MatRowFixed;

			DataTable dt = Select_sdd_srf_m_mat();
			int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;

			for(int i=0; i<dt_rows; i++)
			{
				fgrid_matcd.AddItem(dt.Rows[i].ItemArray, fgrid_matcd.Rows.Count, 1);
			}

			fgrid_matcd.AutoSizeCols();
		}

		private DataTable Select_sdd_srf_m_mat()
		{
			string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_M_MAT";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "arg_mat_cd";
			OraDB.Parameter_Name[2] = "arg_mat_name";
			OraDB.Parameter_Name[3] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			OraDB.Parameter_Values[1] = txt_matcd.Text.ToUpper();
			OraDB.Parameter_Values[2] = txt_matname.Text.ToUpper();
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private void fgrid_matcd_DoubleClick(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_matcd.Selection.r1;
			int sct_col = fgrid_matcd.Selection.c1;

			if(sct_row >= _MatRowFixed)
			{
				string mat_cd = fgrid_matcd[sct_row, (int)ClassLib.TBSELECT_SDO_REQ_MAT_INFO.IxMAT_CD].ToString();
				string mat_name = fgrid_matcd[sct_row, (int)ClassLib.TBSELECT_SDO_REQ_MAT_INFO.IxMAT_NAME].ToString();
				string mat_comment = fgrid_matcd[sct_row, (int)ClassLib.TBSELECT_SDO_REQ_MAT_INFO.IxMAT_COMMENT].ToString();
				string mat_desc = fgrid_matcd[sct_row, (int)ClassLib.TBSELECT_SDO_REQ_MAT_INFO.IxMAT_NAME].ToString();
				string unit = fgrid_matcd[sct_row, (int)ClassLib.TBSELECT_SDO_REQ_MAT_INFO.IxPCC_UNIT].ToString();
				string spec = fgrid_matcd[sct_row, (int)ClassLib.TBSELECT_SDO_REQ_MAT_INFO.IxPCC_SPEC].ToString();
				string yield = fgrid_matcd[sct_row, (int)ClassLib.TBSELECT_SDO_REQ_MAT_INFO.IxYIELD_VALUE].ToString();


				txt_m_matcd.Text = mat_cd;
				txt_m_desc.Text = mat_desc;
				txt_m_name.Text = mat_name;
				txt_m_comp.Text = mat_comment;
				txt_m_spec.Text = spec;
				cmb_unit.SelectedValue = unit;
				txt_m_yield.Text = yield;
			}
		}

		private void label1_Click(object sender, System.EventArgs e)
		{
			Color_Show_data();
		}

		private void Color_Show_data()
		{
			fgrid_colorcd.Rows.Count = _ColRowFixed;

			DataTable dt = Select_sdd_srf_m_color();
			int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;

			for(int i=0; i<dt_rows; i++)
			{
				fgrid_colorcd.AddItem(dt.Rows[i].ItemArray, fgrid_colorcd.Rows.Count, 1);
			}

			fgrid_colorcd.AutoSizeCols();
		}

		private DataTable Select_sdd_srf_m_color()
		{
			string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_M_COLOR";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "arg_color_cd";
			OraDB.Parameter_Name[2] = "arg_color_name";
			OraDB.Parameter_Name[3] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			OraDB.Parameter_Values[1] = txt_colorcode.Text.ToUpper();
			OraDB.Parameter_Values[2] = txt_colorname.Text.ToUpper();
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private void fgrid_colorcd_DoubleClick(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_colorcd.Selection.r1;
			int sct_col = fgrid_colorcd.Selection.c1;

			if(sct_row >= _ColRowFixed)
			{
				string color_cd = fgrid_colorcd[sct_row,(int)ClassLib.TBSELECT_SDO_REQ_COLOR_INFO.IxCOLOR_CD].ToString();
				string color_name = fgrid_colorcd[sct_row,(int)ClassLib.TBSELECT_SDO_REQ_COLOR_INFO.IxCOLOR_NAME].ToString();

				txt_c_code.Text = color_cd;
				txt_c_name.Text = color_name;
				txt_c_comp.Text = fgrid_colorcd[sct_row,(int)ClassLib.TBSELECT_SDO_REQ_COLOR_INFO.IxCOLOR_COMMENT].ToString();
			}
		}

		private void btn_mcs_Click(object sender, System.EventArgs e)
		{
			MCS_Show_data();
		}

		private void MCS_Show_data()
		{
			fgrid_mcs.Rows.Count = _McsRowFixed;

			DataTable dt = Select_sdd_srf_m_mcs();
			int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;

			for(int i=0; i<dt_rows; i++)
			{
				fgrid_mcs.AddItem(dt.Rows[i].ItemArray, fgrid_mcs.Rows.Count, 1);
			}

			fgrid_mcs.AutoSizeCols();
		}

		private DataTable Select_sdd_srf_m_mcs()
		{
			string Proc_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_M_MCS";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "arg_mcs_cd";
			OraDB.Parameter_Name[2] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			OraDB.Parameter_Values[1] = txt_mcs.Text.ToUpper();
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private void fgrid_mcs_DoubleClick(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_mcs.Selection.r1;
			int sct_col = fgrid_mcs.Selection.c1;

			if(sct_row >= _McsRowFixed)
			{

				string mcs_name  = fgrid_mcs[sct_row,(int)ClassLib.TBSELECT_SDO_REQ_MCS_INFO.IxMCS_NAME].ToString();

				txt_s_mcs.Text = mcs_name;
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(formBomEditer!=null)
			{
				//part
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_SEQ] = txt_p_seq.Text;
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_TYPE] = txt_p_type.Text;
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_DESC] = txt_p_desc.Text;
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPART_QTY] = txt_p_qty.Text;

				//mat
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_CD] = txt_m_matcd.Text;
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_NAME] = txt_m_name.Text;
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_COMMENT] = txt_m_comp.Text;
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMAT_DESC] = txt_m_desc.Text;

//				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD] = cmb_unit.SelectedValue.ToString();
//				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD] = txt_m_spec.Text;



				//color
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_CD] = txt_c_code.Text;
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_DESC] = txt_c_name.Text;
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCOLOR_COMMENT] = txt_c_comp.Text;

				//mcs
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxMCS_CD] = txt_mcs.Text;

				//flg √≥∏Æ
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION] = change_r_flg;
				formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = change_r_flg;
			}
			else if(formReqEditer != null)
			{

				if(!formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION].Equals("I"))
				{
					formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION] = "U";
				}

				//part
				formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_SEQ] = txt_p_seq.Text;
				formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_TYPE] = txt_p_type.Text; 
				formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_DESC] = txt_p_desc.Text;

				//mat
				formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_CD]= txt_m_matcd.Text;
				formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_NAME] = txt_m_name.Text;
				formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_COMMENT] = txt_m_comp.Text;

				//				cmb_unit.SelectedValue = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_UNIT_CD].ToString();
				//				txt_m_spec.Text = formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD].ToString();

				//color
				formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_CD] = txt_c_code.Text; 
				formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_DESC]= txt_c_name.Text;
				formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_COMMENT] = txt_c_comp.Text;

				//mcs
				formReqEditer.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxMCS_CD] = txt_s_mcs.Text;
			}


			this.Close();
		}
	}
}

