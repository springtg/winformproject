using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Threading;

namespace FlexCDC.Product_VJ
{
	public class Form_Plan_sch_VJ : COM.PCHWinForm.Form_Top
	{
		#region Control Define
		public System.Windows.Forms.Panel pnl_Top;
        private C1.Win.C1List.C1Combo cmb_Factory;
        private System.Windows.Forms.DateTimePicker dpk_get_from;
		private System.Windows.Forms.Label lbl_hp;
		private System.Windows.Forms.DateTimePicker dpk_get_to;
		private System.Windows.Forms.Label lbl_get_date;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel pnl_all;
        private COM.ComFunction comfunction = new COM.ComFunction();
        private System.Windows.Forms.MenuItem menuItem1;
        private C1.Win.C1List.C1Combo cmb_opcd;
        private System.Windows.Forms.Label lbl_opcd;
        private ContextMenuStrip ctmnu_sch;
        private ToolStripMenuItem mnu_normal;
        private ToolStripMenuItem mnu_confirm;
        public COM.FSP flg_sch;
        private C1.Win.C1List.C1Combo cmb_category;
        private System.Windows.Forms.Label lbl_category_h;
        private C1.Win.C1List.C1Combo cmb_season;
        private System.Windows.Forms.Label lbl_season_h;
        private System.Windows.Forms.TextBox txt_srf_no_h;
        private System.Windows.Forms.Label lbl_srf_no_h;
        private System.Windows.Forms.TextBox txt_bom_id_h;
        private System.Windows.Forms.Label lbl_bom_id;
        private C1.Win.C1List.C1Combo cmb_sampetyps;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1List.C1Combo cmb_devuser;
        private System.Windows.Forms.Label lbl_devuser;
        private System.Windows.Forms.Label lbl_sort;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnu_worksheet;
        private ToolStripMenuItem mnu_upload;
        private ToolStripMenuItem mnu_edit;
        private ToolStripMenuItem mnu_download;
        private ToolStripMenuItem mnu_copy;
        private ToolStripMenuItem mnu_paste;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private OpenFileDialog openFileDialog1;
        private C1.Win.C1List.C1Combo cmb_sort;
        private ToolStripMenuItem mnu_tag;
        private ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.CheckBox chk_refresh;
        private System.Windows.Forms.Timer timer_01;
        private System.Windows.Forms.Label lbl_confirm;
        private System.Windows.Forms.Label lbl_normal;
        private ToolStripMenuItem mnu_return;
        private ToolStripMenuItem mnu_close;
        private ToolStripMenuItem mnu_pcard;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem mnu_level_1;
        private ToolStripMenuItem mnu_level_2;
        private ToolStripMenuItem mnu_pop_up;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem mnu_insert;
        private ToolStripMenuItem mnu_delete;
        private System.Windows.Forms.Label lbl_complete;
        private System.Windows.Forms.Label lbl_ing;
        private ToolStripMenuItem mnu_data_check;
        private ToolStripMenuItem mnu_tag_check;
        private ToolStripMenuItem mnu_formula;
        private ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Label lbl_style_cd;
        private System.Windows.Forms.TextBox txt_style_cd;
		private System.ComponentModel.IContainer components = null;

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

		#region Design		
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Plan_sch_VJ));
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.lbl_style_cd = new System.Windows.Forms.Label();
            this.txt_style_cd = new System.Windows.Forms.TextBox();
            this.lbl_complete = new System.Windows.Forms.Label();
            this.lbl_ing = new System.Windows.Forms.Label();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.lbl_normal = new System.Windows.Forms.Label();
            this.chk_refresh = new System.Windows.Forms.CheckBox();
            this.cmb_sort = new C1.Win.C1List.C1Combo();
            this.lbl_sort = new System.Windows.Forms.Label();
            this.cmb_opcd = new C1.Win.C1List.C1Combo();
            this.lbl_opcd = new System.Windows.Forms.Label();
            this.lbl_srf_no_h = new System.Windows.Forms.Label();
            this.txt_srf_no_h = new System.Windows.Forms.TextBox();
            this.lbl_get_date = new System.Windows.Forms.Label();
            this.cmb_devuser = new C1.Win.C1List.C1Combo();
            this.lbl_devuser = new System.Windows.Forms.Label();
            this.cmb_sampetyps = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bom_id_h = new System.Windows.Forms.TextBox();
            this.lbl_bom_id = new System.Windows.Forms.Label();
            this.cmb_season = new C1.Win.C1List.C1Combo();
            this.lbl_season_h = new System.Windows.Forms.Label();
            this.cmb_category = new C1.Win.C1List.C1Combo();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_category_h = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_openfile = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dpk_get_to = new System.Windows.Forms.DateTimePicker();
            this.dpk_get_from = new System.Windows.Forms.DateTimePicker();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pnl_all = new System.Windows.Forms.Panel();
            this.flg_sch = new COM.FSP();
            this.ctmnu_sch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_confirm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_normal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_return = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_upload = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_download = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_worksheet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_tag = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_pcard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_pop_up = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_data_check = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_tag_check = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_formula = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_level_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_level_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer_01 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_opcd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_devuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampetyps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pnl_all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flg_sch)).BeginInit();
            this.ctmnu_sch.SuspendLayout();
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
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.cmb_Factory);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 80);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 115);
            this.pnl_Top.TabIndex = 138;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style1;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style2;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style3;
            this.cmb_Factory.HeadingStyle = style4;
            this.cmb_Factory.HighLightRowStyle = style5;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 36);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style6;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style7;
            this.cmb_Factory.Size = new System.Drawing.Size(120, 21);
            this.cmb_Factory.Style = style8;
            this.cmb_Factory.TabIndex = 350;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
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
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.lbl_style_cd);
            this.pnl_SearchImage.Controls.Add(this.txt_style_cd);
            this.pnl_SearchImage.Controls.Add(this.lbl_complete);
            this.pnl_SearchImage.Controls.Add(this.lbl_ing);
            this.pnl_SearchImage.Controls.Add(this.lbl_confirm);
            this.pnl_SearchImage.Controls.Add(this.lbl_normal);
            this.pnl_SearchImage.Controls.Add(this.chk_refresh);
            this.pnl_SearchImage.Controls.Add(this.cmb_sort);
            this.pnl_SearchImage.Controls.Add(this.lbl_sort);
            this.pnl_SearchImage.Controls.Add(this.cmb_opcd);
            this.pnl_SearchImage.Controls.Add(this.lbl_opcd);
            this.pnl_SearchImage.Controls.Add(this.lbl_srf_no_h);
            this.pnl_SearchImage.Controls.Add(this.txt_srf_no_h);
            this.pnl_SearchImage.Controls.Add(this.lbl_get_date);
            this.pnl_SearchImage.Controls.Add(this.cmb_devuser);
            this.pnl_SearchImage.Controls.Add(this.lbl_devuser);
            this.pnl_SearchImage.Controls.Add(this.cmb_sampetyps);
            this.pnl_SearchImage.Controls.Add(this.label2);
            this.pnl_SearchImage.Controls.Add(this.txt_bom_id_h);
            this.pnl_SearchImage.Controls.Add(this.lbl_bom_id);
            this.pnl_SearchImage.Controls.Add(this.cmb_season);
            this.pnl_SearchImage.Controls.Add(this.lbl_season_h);
            this.pnl_SearchImage.Controls.Add(this.cmb_category);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_category_h);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.btn_openfile);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.lbl_hp);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.dpk_get_to);
            this.pnl_SearchImage.Controls.Add(this.dpk_get_from);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 107);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // lbl_style_cd
            // 
            this.lbl_style_cd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style_cd.ImageIndex = 0;
            this.lbl_style_cd.ImageList = this.img_Label;
            this.lbl_style_cd.Location = new System.Drawing.Point(8, 58);
            this.lbl_style_cd.Name = "lbl_style_cd";
            this.lbl_style_cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_style_cd.TabIndex = 714;
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
            this.txt_style_cd.Location = new System.Drawing.Point(109, 58);
            this.txt_style_cd.MaxLength = 100;
            this.txt_style_cd.Name = "txt_style_cd";
            this.txt_style_cd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_style_cd.Size = new System.Drawing.Size(120, 20);
            this.txt_style_cd.TabIndex = 715;
            // 
            // lbl_complete
            // 
            this.lbl_complete.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_complete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_complete.Font = new System.Drawing.Font("Verdana", 6F);
            this.lbl_complete.ImageList = this.img_Label;
            this.lbl_complete.Location = new System.Drawing.Point(921, 82);
            this.lbl_complete.Name = "lbl_complete";
            this.lbl_complete.Size = new System.Drawing.Size(54, 21);
            this.lbl_complete.TabIndex = 713;
            this.lbl_complete.Tag = "21";
            this.lbl_complete.Text = "Complete";
            this.lbl_complete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ing
            // 
            this.lbl_ing.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ing.Font = new System.Drawing.Font("Verdana", 6F);
            this.lbl_ing.ImageList = this.img_Label;
            this.lbl_ing.Location = new System.Drawing.Point(866, 82);
            this.lbl_ing.Name = "lbl_ing";
            this.lbl_ing.Size = new System.Drawing.Size(54, 21);
            this.lbl_ing.TabIndex = 712;
            this.lbl_ing.Tag = "21";
            this.lbl_ing.Text = "Progress";
            this.lbl_ing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_confirm.Font = new System.Drawing.Font("Verdana", 6F);
            this.lbl_confirm.ImageList = this.img_Label;
            this.lbl_confirm.Location = new System.Drawing.Point(755, 82);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(54, 21);
            this.lbl_confirm.TabIndex = 711;
            this.lbl_confirm.Tag = "21";
            this.lbl_confirm.Text = "Confirm";
            this.lbl_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_normal
            // 
            this.lbl_normal.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_normal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_normal.Font = new System.Drawing.Font("Verdana", 6F);
            this.lbl_normal.ImageList = this.img_Label;
            this.lbl_normal.Location = new System.Drawing.Point(810, 82);
            this.lbl_normal.Name = "lbl_normal";
            this.lbl_normal.Size = new System.Drawing.Size(54, 21);
            this.lbl_normal.TabIndex = 710;
            this.lbl_normal.Tag = "21";
            this.lbl_normal.Text = "Release";
            this.lbl_normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_refresh
            // 
            this.chk_refresh.AutoSize = true;
            this.chk_refresh.BackColor = System.Drawing.Color.Beige;
            this.chk_refresh.Location = new System.Drawing.Point(598, 84);
            this.chk_refresh.Name = "chk_refresh";
            this.chk_refresh.Size = new System.Drawing.Size(15, 14);
            this.chk_refresh.TabIndex = 709;
            this.chk_refresh.UseVisualStyleBackColor = false;
            this.chk_refresh.CheckedChanged += new System.EventHandler(this.chk_refresh_CheckedChanged);
            // 
            // cmb_sort
            // 
            this.cmb_sort.AddItemSeparator = ';';
            this.cmb_sort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sort.Caption = "";
            this.cmb_sort.CaptionHeight = 17;
            this.cmb_sort.CaptionStyle = style9;
            this.cmb_sort.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_sort.ColumnCaptionHeight = 18;
            this.cmb_sort.ColumnFooterHeight = 18;
            this.cmb_sort.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_sort.ContentHeight = 17;
            this.cmb_sort.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_sort.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_sort.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sort.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sort.EditorHeight = 17;
            this.cmb_sort.EvenRowStyle = style10;
            this.cmb_sort.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sort.FooterStyle = style11;
            this.cmb_sort.HeadingStyle = style12;
            this.cmb_sort.HighLightRowStyle = style13;
            this.cmb_sort.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_sort.Images"))));
            this.cmb_sort.ItemHeight = 15;
            this.cmb_sort.Location = new System.Drawing.Point(616, 80);
            this.cmb_sort.MatchEntryTimeout = ((long)(2000));
            this.cmb_sort.MaxDropDownItems = ((short)(5));
            this.cmb_sort.MaxLength = 32767;
            this.cmb_sort.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sort.Name = "cmb_sort";
            this.cmb_sort.OddRowStyle = style14;
            this.cmb_sort.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sort.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sort.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sort.SelectedStyle = style15;
            this.cmb_sort.Size = new System.Drawing.Size(120, 21);
            this.cmb_sort.Style = style16;
            this.cmb_sort.TabIndex = 708;
            this.cmb_sort.PropBag = resources.GetString("cmb_sort.PropBag");
            // 
            // lbl_sort
            // 
            this.lbl_sort.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sort.ImageIndex = 0;
            this.lbl_sort.ImageList = this.img_Label;
            this.lbl_sort.Location = new System.Drawing.Point(515, 80);
            this.lbl_sort.Name = "lbl_sort";
            this.lbl_sort.Size = new System.Drawing.Size(100, 21);
            this.lbl_sort.TabIndex = 707;
            this.lbl_sort.Tag = "0";
            this.lbl_sort.Text = "Sort";
            this.lbl_sort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_opcd
            // 
            this.cmb_opcd.AddItemSeparator = ';';
            this.cmb_opcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_opcd.Caption = "";
            this.cmb_opcd.CaptionHeight = 17;
            this.cmb_opcd.CaptionStyle = style17;
            this.cmb_opcd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_opcd.ColumnCaptionHeight = 18;
            this.cmb_opcd.ColumnFooterHeight = 18;
            this.cmb_opcd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_opcd.ContentHeight = 17;
            this.cmb_opcd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_opcd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_opcd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_opcd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_opcd.EditorHeight = 17;
            this.cmb_opcd.EvenRowStyle = style18;
            this.cmb_opcd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_opcd.FooterStyle = style19;
            this.cmb_opcd.HeadingStyle = style20;
            this.cmb_opcd.HighLightRowStyle = style21;
            this.cmb_opcd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_opcd.Images"))));
            this.cmb_opcd.ItemHeight = 15;
            this.cmb_opcd.Location = new System.Drawing.Point(109, 80);
            this.cmb_opcd.MatchEntryTimeout = ((long)(2000));
            this.cmb_opcd.MaxDropDownItems = ((short)(5));
            this.cmb_opcd.MaxLength = 32767;
            this.cmb_opcd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_opcd.Name = "cmb_opcd";
            this.cmb_opcd.OddRowStyle = style22;
            this.cmb_opcd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_opcd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_opcd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_opcd.SelectedStyle = style23;
            this.cmb_opcd.Size = new System.Drawing.Size(120, 21);
            this.cmb_opcd.Style = style24;
            this.cmb_opcd.TabIndex = 367;
            this.cmb_opcd.PropBag = resources.GetString("cmb_opcd.PropBag");
            // 
            // lbl_opcd
            // 
            this.lbl_opcd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_opcd.ImageIndex = 0;
            this.lbl_opcd.ImageList = this.img_Label;
            this.lbl_opcd.Location = new System.Drawing.Point(8, 80);
            this.lbl_opcd.Name = "lbl_opcd";
            this.lbl_opcd.Size = new System.Drawing.Size(100, 21);
            this.lbl_opcd.TabIndex = 366;
            this.lbl_opcd.Text = "Operation";
            this.lbl_opcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_srf_no_h
            // 
            this.lbl_srf_no_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srf_no_h.ImageIndex = 0;
            this.lbl_srf_no_h.ImageList = this.img_Label;
            this.lbl_srf_no_h.Location = new System.Drawing.Point(754, 36);
            this.lbl_srf_no_h.Name = "lbl_srf_no_h";
            this.lbl_srf_no_h.Size = new System.Drawing.Size(100, 21);
            this.lbl_srf_no_h.TabIndex = 697;
            this.lbl_srf_no_h.Tag = "21";
            this.lbl_srf_no_h.Text = "SRF No";
            this.lbl_srf_no_h.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_srf_no_h
            // 
            this.txt_srf_no_h.BackColor = System.Drawing.SystemColors.Window;
            this.txt_srf_no_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_srf_no_h.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_srf_no_h.ForeColor = System.Drawing.Color.Black;
            this.txt_srf_no_h.Location = new System.Drawing.Point(855, 36);
            this.txt_srf_no_h.MaxLength = 100;
            this.txt_srf_no_h.Name = "txt_srf_no_h";
            this.txt_srf_no_h.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_srf_no_h.Size = new System.Drawing.Size(120, 20);
            this.txt_srf_no_h.TabIndex = 698;
            // 
            // lbl_get_date
            // 
            this.lbl_get_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_get_date.ImageIndex = 0;
            this.lbl_get_date.ImageList = this.img_Label;
            this.lbl_get_date.Location = new System.Drawing.Point(245, 80);
            this.lbl_get_date.Name = "lbl_get_date";
            this.lbl_get_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_get_date.TabIndex = 313;
            this.lbl_get_date.Text = "ETS Date";
            this.lbl_get_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_devuser
            // 
            this.cmb_devuser.AddItemSeparator = ';';
            this.cmb_devuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_devuser.Caption = "";
            this.cmb_devuser.CaptionHeight = 17;
            this.cmb_devuser.CaptionStyle = style25;
            this.cmb_devuser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_devuser.ColumnCaptionHeight = 18;
            this.cmb_devuser.ColumnFooterHeight = 18;
            this.cmb_devuser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_devuser.ContentHeight = 17;
            this.cmb_devuser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_devuser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_devuser.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_devuser.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_devuser.EditorHeight = 17;
            this.cmb_devuser.EvenRowStyle = style26;
            this.cmb_devuser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_devuser.FooterStyle = style27;
            this.cmb_devuser.HeadingStyle = style28;
            this.cmb_devuser.HighLightRowStyle = style29;
            this.cmb_devuser.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_devuser.Images"))));
            this.cmb_devuser.ItemHeight = 15;
            this.cmb_devuser.Location = new System.Drawing.Point(855, 58);
            this.cmb_devuser.MatchEntryTimeout = ((long)(2000));
            this.cmb_devuser.MaxDropDownItems = ((short)(5));
            this.cmb_devuser.MaxLength = 32767;
            this.cmb_devuser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_devuser.Name = "cmb_devuser";
            this.cmb_devuser.OddRowStyle = style30;
            this.cmb_devuser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_devuser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_devuser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_devuser.SelectedStyle = style31;
            this.cmb_devuser.Size = new System.Drawing.Size(120, 21);
            this.cmb_devuser.Style = style32;
            this.cmb_devuser.TabIndex = 704;
            this.cmb_devuser.PropBag = resources.GetString("cmb_devuser.PropBag");
            // 
            // lbl_devuser
            // 
            this.lbl_devuser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_devuser.ImageIndex = 0;
            this.lbl_devuser.ImageList = this.img_Label;
            this.lbl_devuser.Location = new System.Drawing.Point(754, 58);
            this.lbl_devuser.Name = "lbl_devuser";
            this.lbl_devuser.Size = new System.Drawing.Size(100, 21);
            this.lbl_devuser.TabIndex = 703;
            this.lbl_devuser.Tag = "0";
            this.lbl_devuser.Text = "User";
            this.lbl_devuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_sampetyps
            // 
            this.cmb_sampetyps.AddItemSeparator = ';';
            this.cmb_sampetyps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sampetyps.Caption = "";
            this.cmb_sampetyps.CaptionHeight = 17;
            this.cmb_sampetyps.CaptionStyle = style33;
            this.cmb_sampetyps.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_sampetyps.ColumnCaptionHeight = 18;
            this.cmb_sampetyps.ColumnFooterHeight = 18;
            this.cmb_sampetyps.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_sampetyps.ContentHeight = 17;
            this.cmb_sampetyps.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_sampetyps.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_sampetyps.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampetyps.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sampetyps.EditorHeight = 17;
            this.cmb_sampetyps.EvenRowStyle = style34;
            this.cmb_sampetyps.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampetyps.FooterStyle = style35;
            this.cmb_sampetyps.HeadingStyle = style36;
            this.cmb_sampetyps.HighLightRowStyle = style37;
            this.cmb_sampetyps.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_sampetyps.Images"))));
            this.cmb_sampetyps.ItemHeight = 15;
            this.cmb_sampetyps.Location = new System.Drawing.Point(616, 58);
            this.cmb_sampetyps.MatchEntryTimeout = ((long)(2000));
            this.cmb_sampetyps.MaxDropDownItems = ((short)(5));
            this.cmb_sampetyps.MaxLength = 32767;
            this.cmb_sampetyps.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sampetyps.Name = "cmb_sampetyps";
            this.cmb_sampetyps.OddRowStyle = style38;
            this.cmb_sampetyps.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sampetyps.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sampetyps.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sampetyps.SelectedStyle = style39;
            this.cmb_sampetyps.Size = new System.Drawing.Size(120, 21);
            this.cmb_sampetyps.Style = style40;
            this.cmb_sampetyps.TabIndex = 702;
            this.cmb_sampetyps.PropBag = resources.GetString("cmb_sampetyps.PropBag");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(515, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 701;
            this.label2.Tag = "0";
            this.label2.Text = "Sample Types";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_bom_id_h
            // 
            this.txt_bom_id_h.BackColor = System.Drawing.SystemColors.Window;
            this.txt_bom_id_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bom_id_h.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_bom_id_h.ForeColor = System.Drawing.Color.Black;
            this.txt_bom_id_h.Location = new System.Drawing.Point(346, 58);
            this.txt_bom_id_h.MaxLength = 100;
            this.txt_bom_id_h.Name = "txt_bom_id_h";
            this.txt_bom_id_h.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_bom_id_h.Size = new System.Drawing.Size(150, 20);
            this.txt_bom_id_h.TabIndex = 0;
            // 
            // lbl_bom_id
            // 
            this.lbl_bom_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bom_id.ImageIndex = 0;
            this.lbl_bom_id.ImageList = this.img_Label;
            this.lbl_bom_id.Location = new System.Drawing.Point(245, 58);
            this.lbl_bom_id.Name = "lbl_bom_id";
            this.lbl_bom_id.Size = new System.Drawing.Size(100, 21);
            this.lbl_bom_id.TabIndex = 700;
            this.lbl_bom_id.Tag = "21";
            this.lbl_bom_id.Text = "BOM Id";
            this.lbl_bom_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_season
            // 
            this.cmb_season.AddItemSeparator = ';';
            this.cmb_season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_season.Caption = "";
            this.cmb_season.CaptionHeight = 17;
            this.cmb_season.CaptionStyle = style41;
            this.cmb_season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_season.ColumnCaptionHeight = 18;
            this.cmb_season.ColumnFooterHeight = 18;
            this.cmb_season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_season.ContentHeight = 17;
            this.cmb_season.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_season.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_season.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_season.EditorHeight = 17;
            this.cmb_season.EvenRowStyle = style42;
            this.cmb_season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season.FooterStyle = style43;
            this.cmb_season.HeadingStyle = style44;
            this.cmb_season.HighLightRowStyle = style45;
            this.cmb_season.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_season.Images"))));
            this.cmb_season.ItemHeight = 15;
            this.cmb_season.Location = new System.Drawing.Point(616, 36);
            this.cmb_season.MatchEntryTimeout = ((long)(2000));
            this.cmb_season.MaxDropDownItems = ((short)(5));
            this.cmb_season.MaxLength = 32767;
            this.cmb_season.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_season.Name = "cmb_season";
            this.cmb_season.OddRowStyle = style46;
            this.cmb_season.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_season.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_season.SelectedStyle = style47;
            this.cmb_season.Size = new System.Drawing.Size(120, 21);
            this.cmb_season.Style = style48;
            this.cmb_season.TabIndex = 694;
            this.cmb_season.PropBag = resources.GetString("cmb_season.PropBag");
            // 
            // lbl_season_h
            // 
            this.lbl_season_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_season_h.ImageIndex = 0;
            this.lbl_season_h.ImageList = this.img_Label;
            this.lbl_season_h.Location = new System.Drawing.Point(515, 36);
            this.lbl_season_h.Name = "lbl_season_h";
            this.lbl_season_h.Size = new System.Drawing.Size(100, 21);
            this.lbl_season_h.TabIndex = 693;
            this.lbl_season_h.Tag = "0";
            this.lbl_season_h.Text = "Season";
            this.lbl_season_h.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_category
            // 
            this.cmb_category.AddItemSeparator = ';';
            this.cmb_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_category.Caption = "";
            this.cmb_category.CaptionHeight = 17;
            this.cmb_category.CaptionStyle = style49;
            this.cmb_category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_category.ColumnCaptionHeight = 18;
            this.cmb_category.ColumnFooterHeight = 18;
            this.cmb_category.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_category.ContentHeight = 17;
            this.cmb_category.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_category.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_category.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_category.EditorHeight = 17;
            this.cmb_category.EvenRowStyle = style50;
            this.cmb_category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.FooterStyle = style51;
            this.cmb_category.HeadingStyle = style52;
            this.cmb_category.HighLightRowStyle = style53;
            this.cmb_category.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_category.Images"))));
            this.cmb_category.ItemHeight = 15;
            this.cmb_category.Location = new System.Drawing.Point(346, 36);
            this.cmb_category.MatchEntryTimeout = ((long)(2000));
            this.cmb_category.MaxDropDownItems = ((short)(5));
            this.cmb_category.MaxLength = 32767;
            this.cmb_category.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.OddRowStyle = style54;
            this.cmb_category.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_category.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_category.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_category.SelectedStyle = style55;
            this.cmb_category.Size = new System.Drawing.Size(150, 21);
            this.cmb_category.Style = style56;
            this.cmb_category.TabIndex = 692;
            this.cmb_category.PropBag = resources.GetString("cmb_category.PropBag");
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(219, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(776, 32);
            this.picb_TM.TabIndex = 113;
            this.picb_TM.TabStop = false;
            // 
            // lbl_category_h
            // 
            this.lbl_category_h.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category_h.ImageIndex = 0;
            this.lbl_category_h.ImageList = this.img_Label;
            this.lbl_category_h.Location = new System.Drawing.Point(245, 36);
            this.lbl_category_h.Name = "lbl_category_h";
            this.lbl_category_h.Size = new System.Drawing.Size(100, 21);
            this.lbl_category_h.TabIndex = 691;
            this.lbl_category_h.Tag = "21";
            this.lbl_category_h.Text = "Category";
            this.lbl_category_h.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbl_title.Text = "      Product Lot Infomation";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.picb_MR.Size = new System.Drawing.Size(24, 64);
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
            // lbl_hp
            // 
            this.lbl_hp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hp.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hp.Location = new System.Drawing.Point(417, 79);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(10, 21);
            this.lbl_hp.TabIndex = 315;
            this.lbl_hp.Text = "~";
            this.lbl_hp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 92);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // dpk_get_to
            // 
            this.dpk_get_to.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_get_to.CustomFormat = "yyMMdd";
            this.dpk_get_to.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_get_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_get_to.Location = new System.Drawing.Point(427, 79);
            this.dpk_get_to.Name = "dpk_get_to";
            this.dpk_get_to.Size = new System.Drawing.Size(71, 22);
            this.dpk_get_to.TabIndex = 314;
            // 
            // dpk_get_from
            // 
            this.dpk_get_from.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_get_from.CustomFormat = "yyMMdd";
            this.dpk_get_from.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_get_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_get_from.Location = new System.Drawing.Point(346, 79);
            this.dpk_get_from.Name = "dpk_get_from";
            this.dpk_get_from.Size = new System.Drawing.Size(71, 22);
            this.dpk_get_from.TabIndex = 324;
            this.dpk_get_from.Value = new System.DateTime(2008, 2, 20, 0, 0, 0, 0);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(144, 91);
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
            this.pictureBox6.Location = new System.Drawing.Point(0, 92);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
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
            this.pictureBox9.Size = new System.Drawing.Size(1000, 67);
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
            this.pictureBox8.Location = new System.Drawing.Point(150, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1000, 67);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 74);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pnl_all
            // 
            this.pnl_all.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_all.Controls.Add(this.flg_sch);
            this.pnl_all.Location = new System.Drawing.Point(8, 195);
            this.pnl_all.Name = "pnl_all";
            this.pnl_all.Size = new System.Drawing.Size(1000, 449);
            this.pnl_all.TabIndex = 139;
            // 
            // flg_sch
            // 
            this.flg_sch.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.flg_sch.AutoResize = false;
            this.flg_sch.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flg_sch.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.flg_sch.ContextMenuStrip = this.ctmnu_sch;
            this.flg_sch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flg_sch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flg_sch.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.flg_sch.Location = new System.Drawing.Point(0, 0);
            this.flg_sch.Name = "flg_sch";
            this.flg_sch.Rows.DefaultSize = 18;
            this.flg_sch.Rows.Fixed = 0;
            this.flg_sch.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.flg_sch.Size = new System.Drawing.Size(1000, 449);
            this.flg_sch.StyleInfo = resources.GetString("flg_sch.StyleInfo");
            this.flg_sch.TabIndex = 327;
            this.flg_sch.Click += new System.EventHandler(this.flg_sch_Click);
            this.flg_sch.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.flg_sch_AfterEdit);
            this.flg_sch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flg_sch_MouseDown);
            this.flg_sch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.flg_sch_MouseDoubleClick);
            // 
            // ctmnu_sch
            // 
            this.ctmnu_sch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_confirm,
            this.mnu_normal,
            this.mnu_return,
            this.mnu_close,
            this.toolStripSeparator1,
            this.mnu_upload,
            this.mnu_download,
            this.toolStripSeparator2,
            this.mnu_copy,
            this.mnu_paste,
            this.toolStripSeparator3,
            this.mnu_worksheet,
            this.toolStripSeparator4,
            this.mnu_edit,
            this.mnu_tag,
            this.mnu_pcard,
            this.toolStripSeparator5,
            this.mnu_insert,
            this.mnu_delete,
            this.mnu_pop_up,
            this.mnu_data_check,
            this.mnu_tag_check,
            this.toolStripSeparator6,
            this.mnu_formula,
            this.toolStripSeparator7,
            this.mnu_level_1,
            this.mnu_level_2});
            this.ctmnu_sch.Name = "conMenu_status1";
            this.ctmnu_sch.Size = new System.Drawing.Size(225, 486);
            // 
            // mnu_confirm
            // 
            this.mnu_confirm.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_confirm.Name = "mnu_confirm";
            this.mnu_confirm.Size = new System.Drawing.Size(224, 22);
            this.mnu_confirm.Text = "Confirm";
            this.mnu_confirm.Click += new System.EventHandler(this.mnu_confirm_Click);
            // 
            // mnu_normal
            // 
            this.mnu_normal.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_normal.Name = "mnu_normal";
            this.mnu_normal.Size = new System.Drawing.Size(224, 22);
            this.mnu_normal.Text = "Release";
            this.mnu_normal.Click += new System.EventHandler(this.mnu_normal_Click);
            // 
            // mnu_return
            // 
            this.mnu_return.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_return.Name = "mnu_return";
            this.mnu_return.Size = new System.Drawing.Size(224, 22);
            this.mnu_return.Text = "Return";
            this.mnu_return.Click += new System.EventHandler(this.mnu_return_Click);
            // 
            // mnu_close
            // 
            this.mnu_close.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_close.Name = "mnu_close";
            this.mnu_close.Size = new System.Drawing.Size(224, 22);
            this.mnu_close.Text = "Close";
            this.mnu_close.Click += new System.EventHandler(this.mnu_close_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnu_upload
            // 
            this.mnu_upload.Name = "mnu_upload";
            this.mnu_upload.Size = new System.Drawing.Size(224, 22);
            this.mnu_upload.Text = "Upload Excel";
            this.mnu_upload.Click += new System.EventHandler(this.mnu_upload_Click);
            // 
            // mnu_download
            // 
            this.mnu_download.Name = "mnu_download";
            this.mnu_download.Size = new System.Drawing.Size(224, 22);
            this.mnu_download.Text = "Download Excel";
            this.mnu_download.Click += new System.EventHandler(this.mnu_download_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnu_copy
            // 
            this.mnu_copy.Name = "mnu_copy";
            this.mnu_copy.Size = new System.Drawing.Size(224, 22);
            this.mnu_copy.Text = "Copy Excel";
            this.mnu_copy.Click += new System.EventHandler(this.mnu_copy_Click);
            // 
            // mnu_paste
            // 
            this.mnu_paste.Name = "mnu_paste";
            this.mnu_paste.Size = new System.Drawing.Size(224, 22);
            this.mnu_paste.Text = "Paste Excel";
            this.mnu_paste.Click += new System.EventHandler(this.mnu_paste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // mnu_worksheet
            // 
            this.mnu_worksheet.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_worksheet.Name = "mnu_worksheet";
            this.mnu_worksheet.Size = new System.Drawing.Size(224, 22);
            this.mnu_worksheet.Text = "Production Result by Operation";
            this.mnu_worksheet.Click += new System.EventHandler(this.mnu_worksheet_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // mnu_edit
            // 
            this.mnu_edit.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_edit.Name = "mnu_edit";
            this.mnu_edit.Size = new System.Drawing.Size(224, 22);
            this.mnu_edit.Text = "Worksheet";
            this.mnu_edit.Click += new System.EventHandler(this.mnu_edit_Click);
            // 
            // mnu_tag
            // 
            this.mnu_tag.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_tag.Name = "mnu_tag";
            this.mnu_tag.Size = new System.Drawing.Size(224, 22);
            this.mnu_tag.Text = "Tag Label";
            this.mnu_tag.Click += new System.EventHandler(this.mnu_tag_Click);
            // 
            // mnu_pcard
            // 
            this.mnu_pcard.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_pcard.Name = "mnu_pcard";
            this.mnu_pcard.Size = new System.Drawing.Size(224, 22);
            this.mnu_pcard.Text = "Passcard";
            this.mnu_pcard.Click += new System.EventHandler(this.mnu_pcard_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // mnu_insert
            // 
            this.mnu_insert.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_insert.Name = "mnu_insert";
            this.mnu_insert.Size = new System.Drawing.Size(224, 22);
            this.mnu_insert.Text = "Insert Record";
            this.mnu_insert.Click += new System.EventHandler(this.mnu_insert_Click);
            // 
            // mnu_delete
            // 
            this.mnu_delete.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_delete.Name = "mnu_delete";
            this.mnu_delete.Size = new System.Drawing.Size(224, 22);
            this.mnu_delete.Text = "Delete Record";
            this.mnu_delete.Click += new System.EventHandler(this.mnu_delete_Click);
            // 
            // mnu_pop_up
            // 
            this.mnu_pop_up.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_pop_up.Name = "mnu_pop_up";
            this.mnu_pop_up.Size = new System.Drawing.Size(224, 22);
            this.mnu_pop_up.Text = "Data Multi Change";
            this.mnu_pop_up.Click += new System.EventHandler(this.mnu_pop_up_Click);
            // 
            // mnu_data_check
            // 
            this.mnu_data_check.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_data_check.Name = "mnu_data_check";
            this.mnu_data_check.Size = new System.Drawing.Size(224, 22);
            this.mnu_data_check.Text = "Data Check Completed";
            this.mnu_data_check.Click += new System.EventHandler(this.mnu_data_check_Click);
            // 
            // mnu_tag_check
            // 
            this.mnu_tag_check.Name = "mnu_tag_check";
            this.mnu_tag_check.Size = new System.Drawing.Size(224, 22);
            this.mnu_tag_check.Text = "Tag Label Check Completed";
            this.mnu_tag_check.Click += new System.EventHandler(this.mnu_tag_check_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(221, 6);
            this.toolStripSeparator6.Visible = false;
            // 
            // mnu_formula
            // 
            this.mnu_formula.Name = "mnu_formula";
            this.mnu_formula.Size = new System.Drawing.Size(224, 22);
            this.mnu_formula.Text = "Tracking Sheet";
            this.mnu_formula.Visible = false;
            this.mnu_formula.Click += new System.EventHandler(this.mnu_formula_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(221, 6);
            // 
            // mnu_level_1
            // 
            this.mnu_level_1.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_level_1.Name = "mnu_level_1";
            this.mnu_level_1.Size = new System.Drawing.Size(224, 22);
            this.mnu_level_1.Text = "Lot";
            this.mnu_level_1.Click += new System.EventHandler(this.mnu_level_1_Click);
            // 
            // mnu_level_2
            // 
            this.mnu_level_2.BackColor = System.Drawing.SystemColors.Control;
            this.mnu_level_2.Name = "mnu_level_2";
            this.mnu_level_2.Size = new System.Drawing.Size(224, 22);
            this.mnu_level_2.Text = "Operation";
            this.mnu_level_2.Click += new System.EventHandler(this.mnu_level_2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer_01
            // 
            this.timer_01.Enabled = true;
            this.timer_01.Interval = 300000;
            this.timer_01.Tick += new System.EventHandler(this.timer_01_Tick);
            // 
            // Form_Plan_sch_VJ
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pnl_all);
            this.Name = "Form_Plan_sch_VJ";
            this.Load += new System.EventHandler(this.Form_Plan_sch_Load);
            this.Controls.SetChildIndex(this.pnl_all, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_opcd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_devuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampetyps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pnl_all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flg_sch)).EndInit();
            this.ctmnu_sch.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region User Define Variable

		private int _RowFixed;
		private int _RowFixed_M;

		private bool mat_grid = true;
		private bool first    = true;
		private bool col_show = false;

		private COM.OraDB OraDB = new COM.OraDB();
        public Color color_nomal    = Color.White;
        public Color color_confirm  = Color.FromArgb(245, 173, 173);
        public Color color_ing      = Color.Yellow;
        public Color color_complete = Color.Aqua;
                
        private Color default_color = Color.FromArgb(255, 255, 255);
		private string arg_cutting_ymd = null;
		private int endpoint;

        Microsoft.Office.Interop.Excel.Workbook workbook       = null;
        Microsoft.Office.Interop.Excel.Worksheet worksheet     = null;
        Microsoft.Office.Interop.Excel.Application application = null;
        private bool copy_excel = false;
        private string copy_file_name = "", copy_file_path = "";
        private int copy_row;
        private string server_path = "";
        private string server_tag_path = @"\\203.228.108.19\PCC_Sephiroth_File\ws_tag_02.xls";

        private DateTime date_now = DateTime.Now;

        private string power_level = "";
        private string save_date   = "";
        private string save_qty    = "";
        private string save_cmp_cd = "";

        public string confirm_date  = "";
        public string limit_date    = "";        
		#endregion

        #region Resource
        public Form_Plan_sch_VJ()
		{			
			InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Plan_sch_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                System.Data.DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (cmb_Factory.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();

                Init_Form();
            }
            catch
            {
 
            }
        }
		private void Init_Form()
		{
            this.WindowState = FormWindowState.Maximized;

			this.Text               = "PCC_MPS";
			this.lbl_MainTitle.Text = "PCC_MPS";
			ClassLib.ComFunction.SetLangDic(this);

			#region ComboBox Setting
            //Category
            System.Data.DataTable dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxCDC_Category);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1, 2, true, 0, 120);
            cmb_category.SelectedIndex = 0;

            //Season
            dt_ret = SELECT_SDC_PJ_TAIL_SEASON();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1, true, 0, 120);
            cmb_season.SelectedIndex = 0;

            //Sample Type
            dt_ret = SELECT_SDC_NF_DESC();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampetyps, 0, 1, true, 0, 170);
            cmb_sampetyps.SelectedIndex = 0;

            //op cd
            dt_ret = SELECT_OP_CD();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_opcd, 0, 1, false, 0, 120);                        
            cmb_opcd.SelectedValue = "";

            //Dev User
            dt_ret = SELECT_SDD_SRF_LOADUSER();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_devuser, 0, 0, true, 0, 120);
            cmb_devuser.SelectedIndex = 0;		

            //Sort
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_OutSch_Order_type);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sort, 1, 2, false, 0, 120);
            cmb_sort.SelectedIndex = 1;            

            dpk_get_from.Value = date_now.AddMonths(-1); 
            dt_ret = SELECT_MAX_DATE();
            string max_date = dt_ret.Rows[0].ItemArray[0].ToString().Trim();

            if (max_date.Equals(""))
            {
                dpk_get_from.Value = DateTime.Now.AddDays(14);
                dpk_get_to.Value = DateTime.Now.AddDays(-14);
            }
            else
            {
                DateTime date = new DateTime(int.Parse(max_date.Substring(0, 4)), int.Parse(max_date.Substring(4, 2)), int.Parse(max_date.Substring(6, 2)));
                dpk_get_to.Value = date.AddMonths(1);
            }
            
            
            #endregion  
			
			#region Grid Setting
			flg_sch.Set_Grid_CDC("SXG_MPS_VJ", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			flg_sch.Set_Action_Image(img_Action);
			_RowFixed = flg_sch.Rows.Count;
			flg_sch.ExtendLastCol = false;
            flg_sch.Tree.Column = (int)ClassLib.TBSXG_MPS_VJ.IxOP_NAME;
            flg_sch.GetCellRange(flg_sch.Rows.Fixed - 1, (int)ClassLib.TBSXG_MPS_VJ.IxPRINT_CHK).StyleNew.TextAlign = TextAlignEnum.LeftCenter;
            flg_sch.GetCellRange(flg_sch.Rows.Fixed - 2, (int)ClassLib.TBSXG_MPS_VJ.IxPRINT_CHK).StyleNew.TextAlign = TextAlignEnum.LeftCenter;
			#endregion           

			Col_control(col_show);		

			#region Button Setting
			tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
			tbtn_Save.Enabled    = true;
			tbtn_Delete.Enabled  = false;
			tbtn_Print.Enabled   = true;
			tbtn_Insert.Enabled  = false;

            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;
			#endregion
                        
            //File Server Setting
            if (COM.ComVar.This_Factory == "DS")
            {
                server_path = @"\\203.228.108.19\PCC_Sephiroth_File\";
                server_tag_path = @"\\203.228.108.19\PCC_Sephiroth_File\ws_tag_02.xls";
            }
            if (COM.ComVar.This_Factory == "VJ")
            {
                server_path = @"\\211.54.128.14\PCC_Sephiroth_File\";
                server_tag_path = @"\\211.54.128.14\PCC_Sephiroth_File\ws_tag_02.xls";
            }
            if (COM.ComVar.This_Factory == "QD")
            {
                server_path = @"\\119.119.119.19\PCC_Sephiroth_File\";
                server_tag_path = @"\\203.228.108.19\PCC_Sephiroth_File\ws_tag_02.xls";
            }

            mnu_copy.Visible     = false;
            mnu_upload.Visible   = false;
            mnu_paste.Visible    = false;
            mnu_download.Visible = false;            

            toolStripSeparator2.Visible = false;
            toolStripSeparator3.Visible = false;

            timer_01.Enabled = false;
                        
            lbl_confirm.BackColor  = color_confirm;
            lbl_normal.BackColor   = color_nomal;
            lbl_ing.BackColor      = color_ing;
            lbl_complete.BackColor = color_complete;

            this.WindowState = FormWindowState.Maximized;
            txt_bom_id_h.Focus();
                        
            try
            {
                power_level = ClassLib.ComVar.This_CDCPower_Level.ToString();

                if (power_level.Substring(0, 1) != "W" && power_level != "S00")
                    tbtn_Save.Enabled = false;
            }
            catch
            {

            }
        }

        #region DB Connect
        private System.Data.DataTable SELECT_SDC_PJ_TAIL_SEASON()
        {
            string Proc_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private System.Data.DataTable SELECT_SDC_NF_DESC()
        {
            string Proc_Name = "PKG_SXG_MPS_01_SELECT.SELECT_SAMPLE_TYPES";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private System.Data.DataTable SELECT_OP_CD()
        {
            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.SELECT_OP_CD_ADD_ETS";

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[OraDB.Process_Name];
        }
        private System.Data.DataTable SELECT_SDD_SRF_LOADUSER()
        {
            string Proc_Name = "PKG_SXG_MPS_01_SELECT.SELECT_USER";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private System.Data.DataTable SELECT_MAX_DATE()
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.GET_SXG_MAX_DATE";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

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
            OraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        #endregion

        #endregion

        #region Search
        public void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Display_Data();

                if (cmb_opcd.SelectedValue.ToString() != "")
                    flg_sch.Tree.Show(2);
                else
                    flg_sch.Tree.Show(1);
                
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
        private void Display_Data()
        {
            flg_sch.Rows.Count = flg_sch.Rows.Fixed;
            flg_sch.Cols.Count = (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS + 1;          

            flg_sch.AllowEditing = true;

            string arg_from_date = dpk_get_from.Value.ToString("yyyyMMdd");
            string arg_to_date   = dpk_get_to.Value.ToString("yyyyMMdd");

            System.Data.DataTable dt = SELECT_CONFIRM_DATE();
            confirm_date  = dt.Rows[0].ItemArray[0].ToString().Trim();
            limit_date    = dt.Rows[0].ItemArray[1].ToString().Trim();
            
            #region  Date Grid Setting

            dt = GET_MIN_DATE(cmb_Factory.SelectedValue.ToString(), arg_from_date, arg_to_date);
            string min = dt.Rows[0].ItemArray[0].ToString();
            int from_ymd = int.Parse(arg_from_date);
            int min_ymd  = int.Parse(min);

            if (min_ymd > from_ymd)
                min = arg_from_date;

            dt = SELECT_WORK_YMD(cmb_Factory.SelectedValue.ToString(), min, arg_to_date);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                flg_sch.Cols.Add();
                flg_sch.Cols[flg_sch.Cols.Count - 1].Width = 45;
                //flg_sch.Cols[flg_sch.Cols.Count - 1].AllowEditing = false;
                flg_sch[_RowFixed - 2, flg_sch.Cols.Count - 1] = dt.Rows[i].ItemArray[1].ToString();
                flg_sch[_RowFixed - 1, flg_sch.Cols.Count - 1] = dt.Rows[i].ItemArray[2].ToString();
                
                int today    = int.Parse(date_now.ToString("yyyyMMdd"));
                int date     = int.Parse(dt.Rows[i].ItemArray[1].ToString() + dt.Rows[i].ItemArray[2].ToString());
                int confirm  = int.Parse(confirm_date);
                int limit    = int.Parse(limit_date);

                if (date <= confirm)
                {
                    flg_sch.Cols[flg_sch.Cols.Count - 1].StyleNew.BackColor = color_confirm;
                }
                else if (confirm < date && date <= limit)
                {
                    flg_sch.Cols[flg_sch.Cols.Count - 1].StyleNew.BackColor = Color.Orange;
                }
                else
                {
                    flg_sch.Cols[flg_sch.Cols.Count - 1].StyleNew.BackColor = Color.White; 
                }
                if (dt.Rows[i].ItemArray[3].Equals("Y"))
                {
                    flg_sch.Cols[flg_sch.Cols.Count - 1].StyleNew.BackColor = Color.LightGray;
                }
            }
            flg_sch.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly;
            flg_sch.Rows[_RowFixed - 2].AllowMerging = true;
            flg_sch.Rows[_RowFixed - 1].AllowMerging = true;

            flg_sch.Rows.Add();
            //flg_sch[flg_sch.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_VJ.IxDIR_YMD] = "Qty";
            flg_sch.Rows.Frozen = 5;
            #endregion

            #region Data Grid Setting
            
            string[] arg_value = new string[12];
            arg_value[0]  = cmb_Factory.SelectedValue.ToString();
            arg_value[1]  = cmb_category.SelectedValue.ToString();
            arg_value[2]  = cmb_season.SelectedValue.ToString();
            arg_value[3]  = txt_srf_no_h.Text.Trim();
            arg_value[4]  = txt_style_cd.Text.Trim();
            arg_value[5]  = txt_bom_id_h.Text.Trim();
            arg_value[6]  = cmb_sampetyps.SelectedValue.ToString();
            arg_value[7]  = cmb_devuser.SelectedValue.ToString();
            arg_value[8]  = cmb_opcd.SelectedValue.ToString();
            arg_value[9]  = arg_from_date;
            arg_value[10] = arg_to_date;
            arg_value[11] = cmb_sort.SelectedValue.ToString();

            dt = SEARCH_MAT_SCH(arg_value);
            int min_date = 99999999; 

            for (int i = 0; i < dt.Rows.Count; i++)
            {                
                string level       = dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString();
                string arg_lot_seq = dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                
                int tree_level = 1;
                if (!level.Equals("99"))
                    tree_level = 2;

                flg_sch.Rows.InsertNode(flg_sch.Rows.Count, tree_level);
                
                #region Level -  Grid Edit & BackColor Setting
                if (tree_level == 1)
                {
                    if (arg_lot_seq.Equals("00"))
                        flg_sch.GetCellRange(flg_sch.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_VJ.IxMODEL_NAME, flg_sch.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_VJ.IxMODEL_NAME).StyleNew.ForeColor = Color.Red;                    
                }
                else if (tree_level == 2)
                {                    
                }
                #endregion

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    flg_sch[flg_sch.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();
                }

                string arg_dir_ymd      = dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_MPS_VJ.IxWORK_DATE].ToString();
                string arg_yyyymm       = arg_dir_ymd.Substring(0, 6);
                string arg_day          = arg_dir_ymd.Substring(6, 2);
                string arg_dir_qty      = dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_MPS_VJ.IxWORK_QTY].ToString();
                string arg_status       = dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString();
                string arg_pcard_status = dt.Rows[i].ItemArray[(int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS].ToString();                
                                                
                for (int j = (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS; j < flg_sch.Cols.Count; j++)
                {
                    if (flg_sch[flg_sch.Rows.Fixed - 2, j].Equals(arg_yyyymm) && flg_sch[flg_sch.Rows.Fixed - 1, j].Equals(arg_day))
                    {
                        flg_sch.Cols[j].TextAlign = TextAlignEnum.RightCenter;
                        
                        
                        flg_sch[flg_sch.Rows.Count - 1, j] = arg_dir_qty;

                        if (cmb_opcd.SelectedValue.ToString() == "")
                        {
                            if(flg_sch[flg_sch.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                            {
                                float sum_qty = float.Parse((flg_sch[flg_sch.Rows.Fixed, j] == null || flg_sch[flg_sch.Rows.Fixed, j].ToString().Trim().Equals("")) ? "0" : flg_sch[flg_sch.Rows.Fixed, j].ToString().Trim());
                                sum_qty = sum_qty + float.Parse(arg_dir_qty);
                                flg_sch[flg_sch.Rows.Fixed, j] = sum_qty.ToString();
                                if (sum_qty >= 130)
                                    flg_sch.GetCellRange(flg_sch.Rows.Fixed, j).StyleNew.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            if (flg_sch[flg_sch.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString() == cmb_opcd.SelectedValue.ToString().Trim() && flg_sch[flg_sch.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() != "99")
                            {
                                float sum_qty = float.Parse((flg_sch[flg_sch.Rows.Fixed, j] == null || flg_sch[flg_sch.Rows.Fixed, j].ToString().Trim().Equals("")) ? "0" : flg_sch[flg_sch.Rows.Fixed, j].ToString().Trim());
                                sum_qty = sum_qty + float.Parse(arg_dir_qty);
                                flg_sch[flg_sch.Rows.Fixed, j] = sum_qty.ToString();
                                if (sum_qty >= 130)
                                    flg_sch.GetCellRange(flg_sch.Rows.Fixed, j).StyleNew.ForeColor = Color.Red;
                            } 
                        }
                        
                        if (min_date > int.Parse(arg_dir_ymd))
                        {
                            min_date = int.Parse(arg_dir_ymd);
                            flg_sch.LeftCol = j - 2;
                        }

                        if (arg_status.Equals("C"))
                        {
                            flg_sch.GetCellRange(flg_sch.Rows.Count - 1, j).StyleNew.BackColor = color_confirm;
                        }
                        else if (arg_status.Equals("Y") || arg_status.Equals("U") || arg_status.Equals("T"))
                        {
                            flg_sch.GetCellRange(flg_sch.Rows.Count - 1, j).StyleNew.BackColor = color_nomal;

                            if(arg_status.Equals("T"))
                                flg_sch.GetCellRange(flg_sch.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS).StyleNew.BackColor = Color.Red;
                        }

                        if(arg_pcard_status.Equals("Y"))
                        {
                            flg_sch.GetCellRange(flg_sch.Rows.Count - 1, j).StyleNew.BackColor = color_ing;
                        }
                        else if (arg_pcard_status.Equals("N"))
                        {
                            flg_sch.GetCellRange(flg_sch.Rows.Count - 1, j).StyleNew.BackColor = color_nomal;
                        }
                        else if(arg_pcard_status.Equals("C"))
                        {
                            flg_sch.GetCellRange(flg_sch.Rows.Count - 1, j).StyleNew.BackColor = color_complete;
                        }

                    }
                }

                if (arg_status.Equals("X"))
                    flg_sch.GetCellRange(flg_sch.Rows.Count - 1, (int)ClassLib.TBSXG_MPS_VJ.IxDIVISION, flg_sch.Rows.Count - 1, flg_sch.Cols.Count - 1).StyleNew.BackColor = Color.DarkGray;
                

                flg_sch.Rows[flg_sch.Rows.Count - 1].AllowEditing = false;
                
            }
            #endregion
            
            flg_sch.Rows[flg_sch.Rows.Fixed].AllowEditing = false;
            flg_sch.AllowSorting = AllowSortingEnum.None;
            first = true;            
        }


        private System.Data.DataTable GET_MIN_DATE(string arg_factory, string arg_from_date, string arg_to_date)
        {
            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.GET_SXG_MIN_DATE";

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            OraDB.Parameter_Name[2] = "ARG_TO_DATE";
            OraDB.Parameter_Name[3] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_from_date;
            OraDB.Parameter_Values[2] = arg_to_date;
            OraDB.Parameter_Values[3] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[OraDB.Process_Name];
        }
        private System.Data.DataTable SELECT_WORK_YMD(string arg_factory, string arg_from_date, string arg_to_date)
        {
            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.SELECT_WORK_YMD";

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            OraDB.Parameter_Name[2] = "ARG_TO_DATE";
            OraDB.Parameter_Name[3] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_from_date;
            OraDB.Parameter_Values[2] = arg_to_date;
            OraDB.Parameter_Values[3] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[OraDB.Process_Name];
        }
        private System.Data.DataTable SEARCH_MAT_SCH(string[] arg_value)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(13);

            //01.PROCEDURE명
            if(arg_value[8].Equals(""))
                OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.SELECT_SRF_SCH_01";
            else
                OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.SELECT_SRF_SCH_02";
            
            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_CATEGORY";
            OraDB.Parameter_Name[2] = "ARG_SEASON";
            OraDB.Parameter_Name[3] = "ARG_SRF_NO";
            OraDB.Parameter_Name[4] = "ARG_STYLE_CD";
            OraDB.Parameter_Name[5] = "ARG_BOM_ID";
            OraDB.Parameter_Name[6] = "ARG_SAMPLE_TYPE";
            OraDB.Parameter_Name[7] = "ARG_DEV_USER";
            OraDB.Parameter_Name[8] = "ARG_OP_CD";
            OraDB.Parameter_Name[9] = "ARG_FROM_DATE";
            OraDB.Parameter_Name[10] = "ARG_TO_DATE";
            OraDB.Parameter_Name[11] = "ARG_ORDER_TYPE";
            OraDB.Parameter_Name[12] = "OUT_CURSOR";

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
            OraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[12] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_value[0];//arg_factory
            OraDB.Parameter_Values[1] = arg_value[1];//arg_category
            OraDB.Parameter_Values[2] = arg_value[2];//arg_season
            OraDB.Parameter_Values[3] = arg_value[3];//arg_sr_no
            OraDB.Parameter_Values[4] = arg_value[4];//arg_srf_no
            OraDB.Parameter_Values[5] = arg_value[5];//arg_bom_id
            OraDB.Parameter_Values[6] = arg_value[6];//arg_sample_type
            OraDB.Parameter_Values[7] = arg_value[7];//arg_dev_user
            OraDB.Parameter_Values[8] = arg_value[8];//arg_op_cd
            OraDB.Parameter_Values[9] = arg_value[9];//arg_cutting_from
            OraDB.Parameter_Values[10] = arg_value[10];//arg_cutting_to
            OraDB.Parameter_Values[11] = arg_value[11];//arg_order_type
            OraDB.Parameter_Values[12] = "";

            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }        
        #endregion

        #region Save
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                int sct_row = flg_sch.Selection.r1;
                int x_point = flg_sch.ScrollPosition.X;
                int y_point = flg_sch.ScrollPosition.Y;

                for (int i = flg_sch.Rows.Fixed + 1; i < flg_sch.Rows.Count; i++)
                {
                    if (flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxDIVISION].ToString() == "I")
                    {
                        if (!Data_Check(i))
                        {
                            flg_sch.Select(i, (int)ClassLib.TBSXG_MPS_VJ.IxOP_NAME);
                            break;
                        }
                        else
                        {
                            Get_date_qty(i);
                            save_cmp_cd = GET_CMP_CD(i).Rows[0].ItemArray[1].ToString();
                            string holiday = SAVE_DATA(i);
                            if (holiday == "Y")
                            {
                                MessageBox.Show("This is Holiyday");
                                flg_sch.Select(i, (int)ClassLib.TBSXG_MPS_VJ.IxOP_NAME);
                                break; 
                            }                            
                        }
                    }
                    if (flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxDIVISION].ToString() == "D")
                    {
                        Get_date_qty(i);
                        save_cmp_cd = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxCMP_CD].ToString();

                        SAVE_DATA(i); 
                    }
                }

                Display_Data();

                if (sct_row > flg_sch.Rows.Count - 1)
                    sct_row = flg_sch.Rows.Count - 1;
                flg_sch.Tree.Show(1);
                flg_sch.ScrollPosition = new System.Drawing.Point(x_point, y_point);
                flg_sch.Select(sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxOP_NAME);                
            }
            catch
            {
 
            }
        }
        private bool Data_Check(int arg_row)
        {
            string _lot_no  = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
            string _lot_seq = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
            string _op_cd   = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();

            for (int i = flg_sch.Rows.Fixed +1; i < flg_sch.Rows.Count; i++)
            {
                string tmp_lot_no  = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                string tmp_lot_seq = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                string tmp_op_cd   = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();

                if (_lot_no == tmp_lot_no && _lot_seq == tmp_lot_seq && arg_row != i)
                {
                    if (_op_cd == tmp_op_cd)
                    {
                        MessageBox.Show("This Operation already exist");
                        return false;
                    }
                }
            }           

            return true;
        }
        private void Get_date_qty(int arg_row)
        {
            string tmp_date = "";
            string tmp_qty  = "";

            for (int i = (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS + 1; i < flg_sch.Cols.Count; i++)
            {
                tmp_qty = (flg_sch[arg_row, i] == null)?"":flg_sch[arg_row, i].ToString().Trim();

                if (tmp_qty != "")
                {
                    tmp_date = flg_sch[flg_sch.Rows.Fixed - 2, i].ToString().Trim() + flg_sch[flg_sch.Rows.Fixed - 1, i].ToString().Trim();
                    break;
                }
            }

            save_date = tmp_date;
            save_qty  = tmp_qty;
        }

        private System.Data.DataTable GET_CMP_CD(int arg_row)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.GET_SXG_OP_CD";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_OP_CD";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;            
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
            OraDB.Parameter_Values[1] = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();            
            OraDB.Parameter_Values[2] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        private string SAVE_DATA(int arg_row)
        {
            OraDB.ReDim_Parameter(13);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02.SAVE_SXG_MPS_LEV_02";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0]  = "ARG_DIVISION";
            OraDB.Parameter_Name[1]  = "ARG_FACTORY";
            OraDB.Parameter_Name[2]  = "ARG_LOT_NO";
            OraDB.Parameter_Name[3]  = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[4]  = "ARG_DAY_SEQ";
            OraDB.Parameter_Name[5]  = "ARG_LINE_CD";
            OraDB.Parameter_Name[6]  = "ARG_CMP_CD";
            OraDB.Parameter_Name[7]  = "ARG_OP_CD";
            OraDB.Parameter_Name[8]  = "ARG_DIR_YMD";
            OraDB.Parameter_Name[9]  = "ARG_DIR_QTY";
            OraDB.Parameter_Name[10] = "ARG_REMARKS";
            OraDB.Parameter_Name[11] = "ARG_UPD_USER";
            OraDB.Parameter_Name[12] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[12] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0]  = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxDIVISION].ToString();
            OraDB.Parameter_Values[1]  = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
            OraDB.Parameter_Values[2]  = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
            OraDB.Parameter_Values[3]  = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
            OraDB.Parameter_Values[4]  = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxDAY_SEQ].ToString();
            OraDB.Parameter_Values[5]  = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxLINE_CD].ToString();
            OraDB.Parameter_Values[6]  = save_cmp_cd;
            OraDB.Parameter_Values[7]  = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();
            OraDB.Parameter_Values[8]  = save_date;
            OraDB.Parameter_Values[9]  = save_qty;
            OraDB.Parameter_Values[10] = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxREMARKS].ToString();
            OraDB.Parameter_Values[11] = COM.ComVar.This_User;
            OraDB.Parameter_Values[12] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet ds_ret = OraDB.Exe_Select_Procedure();

            if (ds_ret == null) return "Y";
            return ds_ret.Tables[OraDB.Process_Name].Rows[0].ItemArray[0].ToString();
        }
        private void CONFIRM_SIMULATION(string [] arg_value)
        {
            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02.SAVE_SXG_MPS_STATUS_YMD_00";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_DIR_YMD";
            OraDB.Parameter_Name[2] = "ARG_STATUS";
            OraDB.Parameter_Name[3] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_value[0];
            OraDB.Parameter_Values[1] = arg_value[1];
            OraDB.Parameter_Values[2] = arg_value[2];
            OraDB.Parameter_Values[3] = arg_value[3];

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();

            //_pop.Close();
        }
        private void CONFIRM_SIMULATION_LOT(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_day_seq, string arg_cmp_cd, string arg_op_cd, string arg_cnf_type)
        {
            OraDB.ReDim_Parameter(9);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02.SAVE_SXG_MPS_STATUS_YMD_02";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_LOT_NO";
            OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[3] = "ARG_DAY_SEQ";
            OraDB.Parameter_Name[4] = "ARG_LINE_CD";
            OraDB.Parameter_Name[5] = "ARG_CMP_CD";
            OraDB.Parameter_Name[6] = "ARG_OP_CD";
            OraDB.Parameter_Name[7] = "ARG_STATUS";
            OraDB.Parameter_Name[8] = "ARG_UPD_USER";

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

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = arg_day_seq;
            OraDB.Parameter_Values[4] = "001";
            OraDB.Parameter_Values[5] = arg_cmp_cd;
            OraDB.Parameter_Values[6] = arg_op_cd;
            OraDB.Parameter_Values[7] = arg_cnf_type;
            OraDB.Parameter_Values[8] = COM.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();

        }
        private void SAVE_LOT_CLOSE(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_cnf_type)
        {
            OraDB.ReDim_Parameter(5);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02.SAVE_SXE_LOT_CLOSE";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_LOT_NO";
            OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[3] = "ARG_STATUS";
            OraDB.Parameter_Name[4] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = arg_cnf_type;
            OraDB.Parameter_Values[4] = COM.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();

        }
        #endregion

        #region Grid Click Event
        private void flg_sch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
                return;

            if (power_level.Substring(0, 1) != "W" && power_level != "S00")
                return;
                     
            int sct_row = flg_sch.Selection.r1;
            int sct_col = flg_sch.Selection.c1;

            if (flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxDIVISION] == null || flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxDIVISION].ToString() == "I")
                return;

            if (sct_row < _RowFixed || flg_sch[sct_row, sct_col] == null || flg_sch[sct_row, sct_col].ToString().Trim() == "")
            {
                return;
            }
            else if (sct_row.Equals(_RowFixed) || sct_col < (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS)
            {
                return;
            }
            else if (flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString() == "Y" || flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString() == "U" || flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString() == "T")
            {

                string arg_factory = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                string arg_ets = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxWORK_DATE].ToString();
                string arg_qty = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxWORK_QTY].ToString();
                string arg_sort_no = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString();

                Pop_Plan_sch_VJ pop = new Pop_Plan_sch_VJ(arg_factory, arg_ets, arg_qty, arg_sort_no, this);
                pop.ShowDialog();                
            }
       }        
        private void flg_sch_Click(object sender, System.EventArgs e)
        {
            int sct_row = flg_sch.Selection.r1;
            int sct_col = flg_sch.Selection.c1;

            if (sct_row < flg_sch.Rows.Fixed)
                return;

            if (confirm_date.Equals(""))
                return;

            #region Colunm
            
            if (sct_row.Equals(_RowFixed))//상단 Total 부분
            {
                for (int i = flg_sch.Rows.Fixed + 1; i < flg_sch.Rows.Count; i++)
                {
                    if (flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                    {
                        if (flg_sch[i, sct_col] != null && flg_sch[i, sct_col].ToString() != "")
                        {
                            flg_sch.TopRow = i;                            
                            break;
                        }
                    }
                }
                flg_sch.LeftCol = sct_col - 7;
            }
            else //Lot
            {                
                int move = 9999;
                if (sct_col < (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS)
                { 
                    string lot_no = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                    string lot_seq = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();

                    int nod_cnt = flg_sch.Rows[sct_row].Node.Children;

                    for (int j = (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS + 1; j < flg_sch.Cols.Count; j++)
                    {
                        if (flg_sch[sct_row + nod_cnt, j] != null && flg_sch[sct_row + nod_cnt, j].ToString().Trim() != "")
                        {
                            if (move > j)
                                move = j;

                            break;
                        }
                    }

                    flg_sch.LeftCol = move - 1;

                    //if (lot_seq.Equals("00"))
                    //{
                    //    int nod_cnt = flg_sch.Rows[sct_row].Node.Children;

                    //    for (int j = (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS + 1; j < flg_sch.Cols.Count; j++)
                    //    {
                    //        if (flg_sch[sct_row + nod_cnt, j] != null && flg_sch[sct_row + nod_cnt, j].ToString().Trim() != "")
                    //        {
                    //            if (move > j)
                    //                move = j;

                    //            break;
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    for (int j = (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS + 1; j < flg_sch.Cols.Count; j++)
                    //    {
                    //        if (flg_sch[sct_row, j] != null && flg_sch[sct_row, j].ToString().Trim() != "")
                    //        {
                    //            if (move > j)
                    //                move = j;

                    //            break;
                    //        }
                    //    }
                    //}

                    //if(lot_seq.Equals("00"))
                    //    flg_sch.LeftCol = move - 1;
                    //else
                    //    flg_sch.LeftCol = move - 4;
                }
            }

            #endregion
                                              
            #region Context Menu
            
            #region WorkDate Check
            if (sct_col > (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS)
            {
                int date  = int.Parse(flg_sch[1, sct_col].ToString().Trim() + flg_sch[2, sct_col].ToString().Trim());
                int year  = int.Parse(flg_sch[1, sct_col].ToString().Trim().Substring(0, 4));
                int month = int.Parse(flg_sch[1, sct_col].ToString().Trim().Substring(4, 2));
                int day   = int.Parse(flg_sch[2, sct_col].ToString().Trim());
            
                DateTime daycheck = new DateTime(year, month, day);

                System.Data.DataTable dt = SELECT_WORK_YMD(cmb_Factory.SelectedValue.ToString(), date.ToString(), date.ToString());

                if (dt.Rows[0].ItemArray[3].Equals("Y"))
                {
                    mnu_normal.Enabled    = false;
                    mnu_confirm.Enabled   = false;
                    mnu_worksheet.Enabled = false;
                    mnu_edit.Enabled      = false;
                    mnu_tag.Enabled       = false;
                    mnu_pcard.Enabled     = false;
                    mnu_return.Enabled    = false;
                    mnu_pop_up.Enabled    = false;
                    mnu_insert.Enabled    = false;
                    mnu_delete.Enabled    = false;
                    return; 
                }               
            }
            #endregion           

            #region Confirm Date
            int cfm_date = int.Parse(confirm_date);// Confirm한 일자
            int sct_date = 0;                      // 선택한 일자

            try
            {
                if (sct_col > (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS)// 선택한 컬럼이 날짜 부분일때 
                {
                    //상단 타이틀의 날짜 가져오기
                    sct_date = int.Parse(flg_sch[flg_sch.Rows.Fixed - 2, sct_col].ToString() + flg_sch[flg_sch.Rows.Fixed - 1, sct_col].ToString());
                }
                else                                                     //선택한 컬럼이 Lot 정보 부분일떄
                {
                    //Work Date 가져오기
                    sct_date = int.Parse(flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxWORK_DATE].ToString());
                }
            }
            catch
            {
                sct_date = 0;
            }
            #endregion

            #region Status
            string status    = (flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS] == null)? "": flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString();
            string col_value = (flg_sch[sct_row, sct_col] == null) ? "" : flg_sch[sct_row, sct_col].ToString().Trim();                       
            #endregion

            #region Context Menu
            if (power_level.Substring(0, 1) == "W" || power_level == "S00")//PMC System
            {                
                if (sct_row.Equals(_RowFixed))//Total
                {
                    #region 0 Level
                    if (!col_value.Equals(""))
                    {//선택한 컬럼에 데이터가 있을떄
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
                        mnu_normal.Enabled     = false;                        
                        mnu_worksheet.Enabled  = true;
                        mnu_edit.Enabled       = false;
                        mnu_tag.Enabled        = false;
                        mnu_pcard.Enabled      = true;
                        mnu_return.Enabled     = false;
                        mnu_pop_up.Enabled     = false;
                        mnu_insert.Enabled     = false;
                        mnu_delete.Enabled     = false;
                        mnu_data_check.Enabled = false;
                        mnu_close.Enabled      = false;

                        if (sct_date <= cfm_date) // Confirm일때 
                            mnu_confirm.Enabled = false;
                        else                      // Normal일때
                        {
                            if (power_level.Equals("W00") || power_level == "S00")
                                mnu_confirm.Enabled = true;
                            else
                                mnu_confirm.Enabled = false;
                        }
                    }
                    else
                    {//데이터가 없을때

                        mnu_normal.Enabled     = true;                        
                        mnu_worksheet.Enabled  = false;
                        mnu_edit.Enabled       = false;
                        mnu_tag.Enabled        = false;
                        mnu_pcard.Enabled      = false;
                        mnu_return.Enabled     = false;
                        mnu_pop_up.Enabled     = false;
                        mnu_insert.Enabled     = false;
                        mnu_delete.Enabled     = false;
                        mnu_data_check.Enabled = false;
                        mnu_close.Enabled      = false;
                        
                        if (sct_date <= cfm_date) // Confirm일때 
                            mnu_confirm.Enabled = false;
                        else                      // Normal일때
                        {
                            if (power_level.Equals("W00") || power_level == "S00")
                                mnu_confirm.Enabled = true;
                            else
                                mnu_confirm.Enabled = false;

                            mnu_normal.Enabled = false; 
                        }
                    }
                    
                    arg_cutting_ymd = flg_sch[_RowFixed - 2, sct_col].ToString() + flg_sch[_RowFixed - 1, sct_col].ToString();
                    #endregion
                }
                else 
                {
                    if (flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                    {
                        #region 1 Level
                        if (!col_value.Equals("") && sct_col > (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS) 
                        {// 선택한 일자에 데이터가 있고 선택한 컬럼이 날짜 부분일때
                            
                            mnu_normal.Enabled     = false;
                            mnu_confirm.Enabled    = false;
                            mnu_worksheet.Enabled  = true;
                            mnu_edit.Enabled       = true;
                            mnu_tag.Enabled        = true;
                            mnu_return.Enabled     = true;
                            mnu_insert.Enabled     = false;
                            mnu_delete.Enabled     = false;
                            mnu_data_check.Enabled = true;
                            mnu_pcard.Enabled      = true;

                            if (status.Equals("C")) // Confirm일때 
                            {
                                mnu_normal.Enabled     = true;
                                mnu_confirm.Enabled    = false;
                                mnu_pop_up.Enabled     = false;
                                mnu_close.Enabled      = true;
                            }
                            else if (status.Equals("X")) // Close 일때 
                            {
                                mnu_normal.Enabled     = false;
                                mnu_confirm.Enabled    = false;
                                mnu_worksheet.Enabled  = false;
                                mnu_edit.Enabled       = false;
                                mnu_tag.Enabled        = false;
                                mnu_return.Enabled     = false;
                                mnu_insert.Enabled     = false;
                                mnu_delete.Enabled     = false;
                                mnu_data_check.Enabled = false;
                                mnu_pcard.Enabled      = false;
                                mnu_pop_up.Enabled     = false;
                                mnu_close.Enabled      = false;
                            }
                            else                   // Normal일때
                            {
                                mnu_normal.Enabled  = false;
                                mnu_confirm.Enabled = true;
                                mnu_pop_up.Enabled  = true;
                                mnu_close.Enabled   = false;
                            }
                        }
                        else // 데이터가 없을떄
                        {
                            mnu_normal.Enabled     = false;
                            mnu_confirm.Enabled    = false;
                            mnu_worksheet.Enabled  = false;
                            mnu_edit.Enabled       = true;
                            mnu_tag.Enabled        = false;
                            mnu_pcard.Enabled      = false;
                            mnu_return.Enabled     = false;
                            mnu_pop_up.Enabled     = false;
                            mnu_insert.Enabled     = false;
                            mnu_delete.Enabled     = false;
                            mnu_data_check.Enabled = true;

                            if (status.Equals("C")) // Confirm일때 
                            {
                                mnu_close.Enabled  = true;
                            }
                            else if (status.Equals("X")) // Close 일때 
                            {
                                mnu_normal.Enabled     = false;
                                mnu_confirm.Enabled    = false;
                                mnu_worksheet.Enabled  = false;
                                mnu_edit.Enabled       = false;
                                mnu_tag.Enabled        = false;
                                mnu_return.Enabled     = false;
                                mnu_insert.Enabled     = false;
                                mnu_delete.Enabled     = false;
                                mnu_data_check.Enabled = false;
                                mnu_pcard.Enabled      = false;
                                mnu_pop_up.Enabled     = false;
                                mnu_close.Enabled      = false;
                            }
                            else                   // Normal일때
                            {
                                mnu_close.Enabled  = false;
                            }
                        }

                        arg_cutting_ymd = flg_sch[_RowFixed - 2, sct_col].ToString() + flg_sch[_RowFixed - 1, sct_col].ToString();
                        #endregion
                    }
                    else
                    {
                        #region 2 Level
                        if (!col_value.Equals("") && sct_col > (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS)
                        { // 선택한 일자에 데이터가 있고 선택한 컬럼이 날짜 부분일때
                            mnu_worksheet.Enabled  = true;
                            mnu_edit.Enabled       = false;
                            mnu_tag.Enabled        = false;                            
                            mnu_return.Enabled     = false;                       
                            mnu_pcard.Enabled      = false;
                            mnu_data_check.Enabled = false;
                            mnu_close.Enabled      = false;

                            if(status.Equals("C")) // Confirm일때 
                            {
                                mnu_normal.Enabled    = true;
                                mnu_confirm.Enabled   = false; 
                                mnu_pop_up.Enabled    = false;
                                mnu_insert.Enabled    = false;
                                mnu_delete.Enabled    = false;
                            }
                            else if (status.Equals("X")) // Close 일때 
                            {
                                mnu_normal.Enabled     = false;
                                mnu_confirm.Enabled    = false;
                                mnu_worksheet.Enabled  = false;
                                mnu_edit.Enabled       = false;
                                mnu_tag.Enabled        = false;
                                mnu_return.Enabled     = false;
                                mnu_insert.Enabled     = false;
                                mnu_delete.Enabled     = false;
                                mnu_data_check.Enabled = false;
                                mnu_pcard.Enabled      = false;
                                mnu_pop_up.Enabled     = false;
                                mnu_close.Enabled      = false;
                            }
                            else                   // Normal일때
                            {
                                mnu_normal.Enabled    = false;
                                mnu_confirm.Enabled   = true;                                
                                mnu_pop_up.Enabled    = true;
                                mnu_insert.Enabled    = true;
                                mnu_delete.Enabled    = true;
                            }
                        }
                        else // 데이터가 없을떄
                        {
                            mnu_normal.Enabled     = false;
                            mnu_confirm.Enabled    = false;
                            mnu_worksheet.Enabled  = false;
                            mnu_edit.Enabled       = false;
                            mnu_tag.Enabled        = false;
                            mnu_pcard.Enabled      = false;
                            mnu_return.Enabled     = false;
                            mnu_pop_up.Enabled     = false;
                            mnu_insert.Enabled     = false;
                            mnu_delete.Enabled     = false;
                            mnu_data_check.Enabled = false;
                            mnu_close.Enabled      = false;
                        }

                        arg_cutting_ymd = flg_sch[_RowFixed - 2, sct_col].ToString() + flg_sch[_RowFixed - 1, sct_col].ToString();
                        #endregion
                    }
                }
            }                     
            else //워크샵이나 관리자가 아닐때
            {
                if (sct_row.Equals(_RowFixed)) //Total 부분
                {
                    #region 0 Level
                    mnu_normal.Enabled     = false;
                    mnu_confirm.Enabled    = false;                    
                    mnu_return.Enabled     = false;
                    mnu_edit.Enabled       = false;
                    mnu_tag.Enabled        = false;
                    mnu_pcard.Enabled      = false;
                    mnu_pop_up.Enabled     = false;
                    mnu_insert.Enabled     = false;
                    mnu_delete.Enabled     = false;
                    mnu_data_check.Enabled = false;
                    mnu_close.Enabled      = false;

                    if (!col_value.Equals(""))
                    {//선택한 컬럼에 데이터가 있을떄
                        mnu_worksheet.Enabled = true;                        
                    }
                    else
                    {
                        mnu_worksheet.Enabled = false;
                    }
                    #endregion
                }
                else
                {
                    if (flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                    {
                        #region ! Level
                        if (!col_value.Equals("") && sct_col > (int)ClassLib.TBSXG_MPS_VJ.IxPCARD_STATUS)
                        {//선택한 컬럼에 데이터가 있고 날짜 부분일때

                            mnu_normal.Enabled     = false;
                            mnu_confirm.Enabled    = false;
                            mnu_worksheet.Enabled  = true;
                            mnu_edit.Enabled       = true;
                            mnu_tag.Enabled        = false;
                            mnu_pcard.Enabled      = false;
                            mnu_return.Enabled     = false;
                            mnu_pop_up.Enabled     = false;
                            mnu_insert.Enabled     = false;
                            mnu_delete.Enabled     = false;
                            mnu_data_check.Enabled = false;
                            mnu_close.Enabled      = false;
                        }
                        else
                        {
                            mnu_normal.Enabled     = false;
                            mnu_confirm.Enabled    = false;
                            mnu_worksheet.Enabled  = false;
                            mnu_edit.Enabled       = false;
                            mnu_tag.Enabled        = false;
                            mnu_pcard.Enabled      = false;
                            mnu_return.Enabled     = false;
                            mnu_pop_up.Enabled     = false;
                            mnu_insert.Enabled     = false;
                            mnu_delete.Enabled     = false;
                            mnu_data_check.Enabled = false;
                            mnu_close.Enabled      = false;
                        }
                        #endregion
                    }
                    else
                    {
                        #region 2 Level
                        mnu_normal.Enabled     = false;
                        mnu_confirm.Enabled    = false;
                        mnu_worksheet.Enabled  = true;
                        mnu_edit.Enabled       = false;
                        mnu_tag.Enabled        = false;
                        mnu_pcard.Enabled      = false;
                        mnu_return.Enabled     = false;
                        mnu_pop_up.Enabled     = false;
                        mnu_insert.Enabled     = false;
                        mnu_delete.Enabled     = false;
                        mnu_data_check.Enabled = false;
                        mnu_close.Enabled      = false;
                        #endregion
                    }
                } 
            }
            #endregion
            #endregion
        }
        private void flg_sch_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (col_show)
                {                    
                    col_show = false;
                    Col_control(col_show);
                }
                else
                {
                    col_show = true;
                    Col_control(col_show);
                }
            }
        }
        private void flg_sch_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = flg_sch.Selection.r1;
                int sct_col = flg_sch.Selection.c1;

                if (sct_col == (int)ClassLib.TBSXG_MPS_VJ.IxOP_NAME)
                {
                    flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD] = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxOP_NAME].ToString();
                }
            }
            catch
            {
 
            }

        }
        private void Col_control(bool arg_col_show)
        {
            flg_sch.Cols[(int)ClassLib.TBSXG_MPS_VJ.IxCAT].Visible            = arg_col_show;
            flg_sch.Cols[(int)ClassLib.TBSXG_MPS_VJ.IxSEASON].Visible         = arg_col_show;
            //flg_sch.Cols[(int)ClassLib.TBSXG_MPS_VJ.IxBOM_STYLECD].Visible  = arg_col_show;
            flg_sch.Cols[(int)ClassLib.TBSXG_MPS_VJ.IxGEN_SIZE].Visible       = arg_col_show;
            flg_sch.Cols[(int)ClassLib.TBSXG_MPS_VJ.IxREQ_YMD].Visible        = arg_col_show;
            //flg_sch.Cols[(int)ClassLib.TBSXG_MPS_VJ.IxWORK_QTY].Visible     = arg_col_show;
            //flg_sch.Cols[(int)ClassLib.TBSXG_MPS_VJ.IxWORK_DATE].Visible    = arg_col_show;
            flg_sch.Cols[(int)ClassLib.TBSXG_MPS_VJ.IxMAT_YMD].Visible        = arg_col_show;
            flg_sch.Cols[(int)ClassLib.TBSXG_MPS_VJ.IxIPW_YMD].Visible        = arg_col_show;
            flg_sch.Cols[(int)ClassLib.TBSXG_MPS_VJ.IxREMARKS].Visible        = arg_col_show;
        }
        #endregion
        
        #region Control Event
        private void timer_01_Tick(object sender, EventArgs e)
        {
            int sct_row = flg_sch.Selection.r1;
            int sct_col = flg_sch.Selection.c1;
            int x_point = flg_sch.ScrollPosition.X;
            int y_point = flg_sch.ScrollPosition.Y;

            Display_Data();
            flg_sch.Tree.Show(1);
            flg_sch.ScrollPosition = new System.Drawing.Point(x_point, y_point);
            flg_sch.Select(sct_col, sct_row);
        }

        private void chk_refresh_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_refresh.Checked)
                timer_01.Enabled = true;
            else
                timer_01.Enabled = false;
        }        
		#endregion

		#region Context Menu Event

        #region Lot Data Control
        private void mnu_normal_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_sch.Selection.r1;
                int sct_col = flg_sch.Selection.c1;
                int [] sct_rows = flg_sch.Selections;

                if(sct_row.Equals(flg_sch.Rows.Fixed))
                {
                    string[] arg_value = new string[4];
                    arg_value[0] = cmb_Factory.SelectedValue.ToString();
                    arg_value[1] = flg_sch[1, sct_col].ToString() + flg_sch[2, sct_col].ToString();
                    arg_value[2] = "Y";
                    arg_value[3] = COM.ComVar.This_User;

                    CONFIRM_SIMULATION(arg_value);

                    string set_date = flg_sch[1, sct_col - 1].ToString() + flg_sch[2, sct_col - 1].ToString();

                    for (int i = 1; i < 7; i++)
                    {
                        set_date = flg_sch[1, sct_col - i].ToString() + flg_sch[2, sct_col - i].ToString();
                        string holy_yn = SELECT_WORK_YMD(arg_value[0], set_date, set_date).Rows[0].ItemArray[3].ToString();

                        if (holy_yn.Equals("N"))
                            break;
                    }

                    arg_value[1] = set_date;
                    arg_value[2] = "C";

                    CONFIRM_SIMULATION(arg_value);
                }
                else
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        if (flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString() != "Y")
                        {
                            string arg_factory = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                            string arg_lot_no = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                            string arg_lot_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                            string arg_day_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxDAY_SEQ].ToString();
                            string arg_cmp_cd  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCMP_CD].ToString();
                            string arg_op_cd   = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();
                            string arg_cnf_type = "Y";

                            CONFIRM_SIMULATION_LOT(arg_factory, arg_lot_no, arg_lot_seq, arg_day_seq, arg_cmp_cd, arg_op_cd, arg_cnf_type);                        
                        }
                    }
                }

                int x_point = flg_sch.ScrollPosition.X;
                int y_point = flg_sch.ScrollPosition.Y;

                Display_Data();
                flg_sch.Tree.Show(1);
                flg_sch.ScrollPosition = new System.Drawing.Point(x_point, y_point);
                flg_sch.Select(sct_col, sct_row);
            }
            catch
            {
 
            }

        }
        private void mnu_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_sch.Selection.r1;
                int sct_col = flg_sch.Selection.c1;
                int[] sct_rows = flg_sch.Selections;

                if (sct_row.Equals(flg_sch.Rows.Fixed))
                {
                    string[] arg_value = new string[4];
                    arg_value[0] = cmb_Factory.SelectedValue.ToString();
                    arg_value[1] = flg_sch[1, sct_col].ToString() + flg_sch[2, sct_col].ToString();
                    arg_value[2] = "C";
                    arg_value[3] = COM.ComVar.This_User;

                    CONFIRM_SIMULATION(arg_value);
                }
                else
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        if (flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString() != "C")
                        {
                            string arg_factory = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                            string arg_lot_no  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                            string arg_lot_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                            string arg_day_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxDAY_SEQ].ToString();
                            string arg_cmp_cd  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCMP_CD].ToString();
                            string arg_op_cd   = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();
                            string arg_cnf_type = "C";

                            CONFIRM_SIMULATION_LOT(arg_factory, arg_lot_no, arg_lot_seq, arg_day_seq, arg_cmp_cd, arg_op_cd, arg_cnf_type);
                        }
                    }
                }

                int x_point = flg_sch.ScrollPosition.X;
                int y_point = flg_sch.ScrollPosition.Y;

                Display_Data();
                flg_sch.Tree.Show(1);
                flg_sch.ScrollPosition = new System.Drawing.Point(x_point, y_point);
                flg_sch.Select(sct_col, sct_row);
            }
            catch
            {
 
            }
        }
        
        private void mnu_return_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_sch.Selection.r1;
                int sct_col = flg_sch.Selection.c1;
                int[] sct_rows = flg_sch.Selections;
                                
                if (sct_row.Equals(flg_sch.Rows.Fixed))
                {
                    //string arg_factory = cmb_Factory.SelectedValue.ToString();
                    //string arg_dir_ymd = flg_sch[1, sct_col].ToString() + flg_sch[2, sct_col].ToString();
                    //string arg_op_cd = cmb_opcd.SelectedValue.ToString();
                    //string arg_status = "R";


                    //CONFIRM_SIMULATION(arg_factory, arg_dir_ymd, arg_op_cd, arg_status);
                }
                else
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        string arg_factory = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                        string arg_lot_no  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                        string arg_lot_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                        string arg_day_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxDAY_SEQ].ToString();                        
                        string arg_status  = "R";

                        System.Data.DataTable dt_ret = GET_PCARD_STATUS(arg_factory, arg_lot_no, arg_lot_seq);

                        if (dt_ret.Rows.Count > 0)
                        {
                            MessageBox.Show("This is already exist Production Result");
                            return;
                        }

                        RETURN_DATA(arg_factory, arg_lot_no, arg_lot_seq, arg_day_seq, arg_status);

                    }
                }
                int x_point = flg_sch.ScrollPosition.X;
                int y_point = flg_sch.ScrollPosition.Y;

                Display_Data();
                flg_sch.Tree.Show(1);
                flg_sch.ScrollPosition = new System.Drawing.Point(x_point, y_point);
            }
            catch
            {

            }
        }
        private void mnu_close_Click(object sender, EventArgs e)
        {
            int sct_row = flg_sch.Selection.r1;
            int sct_col = flg_sch.Selection.c1;
            int [] sct_rows = flg_sch.Selections;


            for (int i = 0; i < sct_rows.Length; i++)
            {
                
                string arg_factory = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                string arg_lot_no = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                string arg_lot_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                string arg_status  = "X";

                SAVE_LOT_CLOSE(arg_factory, arg_lot_no, arg_lot_seq, arg_status);                    
                
            }
        }
        
        private void mnu_pop_up_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_sch.Selection.r1;
                int sct_col = flg_sch.Selection.c1;
                int x_point = flg_sch.ScrollPosition.X;
                int y_point = flg_sch.ScrollPosition.Y;

                string arg_factory = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                string arg_ets     = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxWORK_DATE].ToString();
                string arg_qty     = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxWORK_QTY].ToString();
                string arg_sort_no = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString();

                Pop_Plan_sch_VJ pop = new Pop_Plan_sch_VJ(arg_factory, arg_ets, arg_qty, arg_sort_no, this);
                pop.ShowDialog();

                if (pop.save_flg)
                {
                    //Display_Data();
                    //flg_sch.Tree.Show(1);
                    //flg_sch.ScrollPosition = new System.Drawing.Point(x_point, y_point);
                    //flg_sch.Select(sct_row, sct_col);
                }
            }
            catch
            {

            }
        }
        private void mnu_insert_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_col    = flg_sch.Selection.c1;
                int sct_row    = flg_sch.Selection.r1;
                int insert_row = sct_row + 1;

                flg_sch.Rows.InsertNode(insert_row, 2);
                flg_sch.Rows[insert_row].AllowEditing = true;

                flg_sch[insert_row, (int)ClassLib.TBSXG_MPS_VJ.IxDIVISION] = "I";
                for (int i = (int)ClassLib.TBSXG_MPS_VJ.IxDIVISION + 1; i < flg_sch.Cols.Count; i++)
                {
                    flg_sch.Cols[i].AllowEditing = true;
                    flg_sch[insert_row, i] = (flg_sch[sct_row, i] == null) ? "" : flg_sch[sct_row, i].ToString();
                }

                flg_sch.Select(insert_row, sct_col);
            }
            catch
            {

            }
        }
        private void mnu_delete_Click(object sender, EventArgs e)
        {
            int [] sct_rows = flg_sch.Selections;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                if(flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() != "99")
                    flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxDIVISION] = "D"; 
            }

            
        }
        private void mnu_data_check_Click(object sender, EventArgs e)
        {
            try
            {
                int[] sct_rows = flg_sch.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                    {                      
                        flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxPRINT_CHK] = "True";
                        //flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxDIVISION]  = "U";
                        
                        string arg_factory  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                        string arg_lot_no   = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                        string arg_lot_seq  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                        string arg_print_yn = "Y";

                        CHECK_DATA(arg_factory, arg_lot_no, arg_lot_seq, arg_print_yn);

                        for (int child = 0; child <= flg_sch.Rows[sct_rows[i]].Node.Children; child++)
                        {
                            if (!flg_sch[child + sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString().Trim().Equals("C"))
                            {
                                flg_sch[child + sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS] = "U";
                                flg_sch.GetCellRange(child + sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS).StyleNew.BackColor = Color.Beige;
                            }
                        }                        
                    }
                }
            }
            catch
            {
 
            }
        }
        private void mnu_tag_check_Click(object sender, EventArgs e)
        {
            try
            {
                int[] sct_rows = flg_sch.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                    {
                        string tag_chk = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxTAG_CHK].ToString().Trim().ToUpper();

                        if (tag_chk.Equals("FALSE"))
                        {
                            flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxTAG_CHK] = "True";

                            string arg_factory = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                            string arg_lot_no = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                            string arg_lot_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                            string arg_print_yn = "Y";

                            CHECK_TAG(arg_factory, arg_lot_no, arg_lot_seq, arg_print_yn);

                            for (int child = 0; child <= flg_sch.Rows[sct_rows[i]].Node.Children; child++)
                            {
                                if (!flg_sch[child + sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString().Trim().Equals("C"))
                                {
                                    flg_sch[child + sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS] = "U";
                                    flg_sch.GetCellRange(child + sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS).StyleNew.BackColor = Color.Beige;
                                }
                            }
                        }
                        else
                        {
                            flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxTAG_CHK] = "False";

                            string arg_factory = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                            string arg_lot_no = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
                            string arg_lot_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
                            string arg_print_yn = "N";

                            CHECK_TAG(arg_factory, arg_lot_no, arg_lot_seq, arg_print_yn);

                            for (int child = 0; child <= flg_sch.Rows[sct_rows[i]].Node.Children; child++)
                            {
                                if (!flg_sch[child + sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS].ToString().Trim().Equals("C"))
                                {
                                    flg_sch[child + sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS] = "U";
                                    flg_sch.GetCellRange(child + sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSTATUS).StyleNew.BackColor = Color.Beige;
                                }
                            }
                        }

                    }

                }
            }
            catch
            {

            }
        }


        private System.Data.DataTable GET_PCARD_STATUS(string arg_factory, string arg_lot_no, string arg_lot_seq)
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.GET_PCARD_STATUS";

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
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];
        }
        private void RETURN_DATA(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_day_seq, string arg_status)
        {
            OraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02.SAVE_SXG_MPS_STATUS_LOT";

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
        private void CHECK_DATA(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_print_yn)
        {
            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02.SAVE_SXG_MPS_CHECK";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_LOT_NO";
            OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[3] = "ARG_PRINT_YN";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = arg_print_yn;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();

        }
        private void CHECK_TAG(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_print_yn)
        {
            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02.SAVE_SXG_MPS_TAG_CHECK";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_LOT_NO";
            OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[3] = "ARG_TAG_PRINT_YN";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = arg_print_yn;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();

        }
        #endregion

        #region Excel Control
        private void mnu_upload_Click(object sender, EventArgs e)
        {
            try
            {

                int sct_row = flg_sch.Selection.r1;
                int sct_col = flg_sch.Selection.c1;

                openFileDialog1.InitialDirectory = "";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

                string file_name = openFileDialog1.FileName;
                int point_position = file_name.Trim().Length - 3;
                string _filetype = file_name.Trim().ToLower().Substring(point_position);


                if ((file_name == null) || (file_name == ""))
                {
                    ClassLib.ComFunction.User_Message("No file to upload", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string _sr_no   = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSR_NO].ToString().Replace(" ", "");
                string _srf_no  = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSRF_NO].ToString().Replace(" ", "");
                string _bom_id  = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxBOM_ID].ToString().Replace(" ", "");
                string _lot_no  = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString().Replace(" ", "");
                string _lot_seq = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                string file_dir  = server_path + _srf_no + "\\";
                string new_file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                string file_path = file_dir + new_file_name;   



                // Determine whether the directory exists.
                if (!Directory.Exists(file_dir))
                {
                    DirectoryInfo di = Directory.CreateDirectory(file_dir);
                }
                
                FileInfo fi = new FileInfo(file_name);
                fi.CopyTo(file_path, true);

                MessageBox.Show(new_file_name + " : " + "File Upload Complete.");
                flg_sch.Select(sct_row, sct_col);
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
                int sct_row = flg_sch.Selection.r1;

                string _sr_no   = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSR_NO].ToString().Replace(" ", "");
                string _srf_no  = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSRF_NO].ToString().Replace(" ", "");
                string _bom_id  = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxBOM_ID].ToString().Replace(" ", "");
                string _lot_no  = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString().Replace(" ", "");
                string _lot_seq = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

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
                    string down_path = fb.SelectedPath + "\\";
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
            catch
            {
 
            }

        }
        private void mnu_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row    = flg_sch.Selection.r1;
                int sct_col    = flg_sch.Selection.c1;
                int[] sct_rows = flg_sch.Selections;

                if (sct_row.Equals(flg_sch.Rows.Fixed))
                {
                    int row_fix = flg_sch.Rows.Fixed + 1;
                    int row_cnt = flg_sch.Rows.Count;

                    for (int i = row_fix; i < row_cnt; i++)
                    {
                        if (flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                        {
                            string qty = (flg_sch[i, sct_col] == null) ? "" : flg_sch[i, sct_col].ToString().Trim();

                            if (!qty.Equals(""))
                            {
                                string _sr_no   = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxSR_NO].ToString().Replace(" ", "");
                                string _srf_no  = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxSRF_NO].ToString().Replace(" ", "");
                                string _bom_id  = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxBOM_ID].ToString().Replace(" ", "");
                                string _lot_no  = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString().Replace(" ", "");
                                string _lot_seq = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                                string file_dir  = server_path + _srf_no + "\\";
                                string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                                string file_path = file_dir + file_name;

                                if (!Directory.Exists(file_dir))
                                {
                                    MessageBox.Show("This File is not exist, Please ask System.");
                                    return;
                                }

                                FileInfo fi = new FileInfo(file_path);
                                if (!fi.Exists)
                                {
                                    MessageBox.Show("This File is not exist, Please ask System.");
                                    return;
                                }

                                Process.Start("EXCEL.EXE", file_path);
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        if (flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                        {
                            string _sr_no   = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSR_NO].ToString().Replace(" ", "");
                            string _srf_no  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSRF_NO].ToString().Replace(" ", "");
                            string _bom_id  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxBOM_ID].ToString().Replace(" ", "");
                            string _lot_no  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString().Replace(" ", "");
                            string _lot_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                            string file_dir  = server_path + _srf_no + "\\";
                            string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                            string file_path = file_dir + file_name;

                            if (!Directory.Exists(file_dir))
                            {
                                MessageBox.Show("This File is not exist, Please ask System.");
                                return;
                            }

                            FileInfo fi = new FileInfo(file_path);
                            if (!fi.Exists)
                            {
                                MessageBox.Show("This File is not exist, Please ask System.");
                                return;
                            }

                            Process.Start("EXCEL.EXE", file_path);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void mnu_tag_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_sch.Selection.r1;
                int sct_col = flg_sch.Selection.c1;
                int[] sct_rows = flg_sch.Selections;


                if (sct_row.Equals(flg_sch.Rows.Fixed))
                {
                    int row_fix = flg_sch.Rows.Fixed + 1;
                    int row_cnt = flg_sch.Rows.Count;

                    for (int i = row_fix; i < row_cnt; i++)
                    {
                        if (flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                        {
                            string qty = (flg_sch[i, sct_col] == null) ? "" : flg_sch[i, sct_col].ToString().Trim();

                            if (!qty.Equals(""))
                            {
                                #region Get Data
                                string _sr_no   = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxSR_NO].ToString().Replace(" ", "");
                                string _srf_no  = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxSRF_NO].ToString().Replace(" ", "");
                                string _bom_id  = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxBOM_ID].ToString().Replace(" ", "");
                                string _lot_no  = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString().Replace(" ", "");
                                string _lot_seq = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                                string file_dir  = server_path + _srf_no + "\\";
                                string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                                string file_path = file_dir + file_name;

                                string _factory = flg_sch[i, (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                                System.Data.DataTable dt_yn = GET_PCC_DD_YN(_factory, _lot_no, _lot_seq);

                                string pcc_dd_yn = dt_yn.Rows[0].ItemArray[0].ToString().Trim();

                                // Determine whether the directory exists.
                                if (!Directory.Exists(file_dir))
                                {
                                    DirectoryInfo di = Directory.CreateDirectory(file_dir);
                                }
                                FileInfo fi = new FileInfo(file_path);

                                if (!fi.Exists)
                                {
                                    MessageBox.Show("This File is not exist, Please ask System.");
                                    return;
                                }

                                application = new Microsoft.Office.Interop.Excel.Application();
                                application.Visible = false;
                                application.DisplayAlerts = false;

                                workbook = (Workbook)(application.Workbooks.Open(file_path, Type.Missing, Type.Missing,

                                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,

                                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));

                                worksheet = workbook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;


                                string[] ws_value_01 = new string[21];
                                string lot_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();//2레벨(생성된 Lot은 SR No를 표시하지 않음)
                                if (!lot_seq.Equals("00"))
                                    ws_value_01[0] = "";
                                else
                                    ws_value_01[0] = (worksheet.get_Range(worksheet.Cells[2, 3], worksheet.Cells[2, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[2, 3], worksheet.Cells[2, 3]).Value2.ToString();   //SR_NO

                                ws_value_01[1] = (worksheet.get_Range(worksheet.Cells[3, 3], worksheet.Cells[3, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 3], worksheet.Cells[3, 3]).Value2.ToString();   //ETS          
                                ws_value_01[2] = (worksheet.get_Range(worksheet.Cells[4, 3], worksheet.Cells[4, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 3], worksheet.Cells[4, 3]).Value2.ToString();   //STYLE_NAME   
                                ws_value_01[3] = (worksheet.get_Range(worksheet.Cells[5, 3], worksheet.Cells[5, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 3], worksheet.Cells[5, 3]).Value2.ToString();   //SRF_NO       
                                ws_value_01[4] = (worksheet.get_Range(worksheet.Cells[6, 3], worksheet.Cells[6, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[6, 3], worksheet.Cells[6, 3]).Value2.ToString();   //CATEGORY     
                                ws_value_01[5] = (worksheet.get_Range(worksheet.Cells[7, 3], worksheet.Cells[7, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 3], worksheet.Cells[7, 3]).Value2.ToString();   //MTO_ACC
                                ws_value_01[6] = (worksheet.get_Range(worksheet.Cells[8, 3], worksheet.Cells[8, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[8, 3], worksheet.Cells[8, 3]).Value2.ToString(); //SEASON_CD
                                ws_value_01[7] = (worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString(); //GEN_NAME
                                ws_value_01[8] = (worksheet.get_Range(worksheet.Cells[10, 3], worksheet.Cells[10, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[10, 3], worksheet.Cells[10, 3]).Value2.ToString(); //WHQ_DEV
                                ws_value_01[9] = (worksheet.get_Range(worksheet.Cells[11, 3], worksheet.Cells[11, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[11, 3], worksheet.Cells[11, 3]).Value2.ToString(); //DEV_PROD
                                ws_value_01[10] = (worksheet.get_Range(worksheet.Cells[12, 3], worksheet.Cells[12, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[12, 3], worksheet.Cells[12, 3]).Value2.ToString(); //BOM_ID
                                ws_value_01[11] = (worksheet.get_Range(worksheet.Cells[13, 3], worksheet.Cells[13, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[13, 3], worksheet.Cells[13, 3]).Value2.ToString(); //LASTING_ME
                                ws_value_01[12] = (worksheet.get_Range(worksheet.Cells[14, 3], worksheet.Cells[14, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[14, 3], worksheet.Cells[14, 3]).Value2.ToString(); //MS_ME
                                ws_value_01[13] = (worksheet.get_Range(worksheet.Cells[15, 3], worksheet.Cells[15, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[15, 3], worksheet.Cells[15, 3]).Value2.ToString(); //SOLELAYING
                                ws_value_01[14] = (worksheet.get_Range(worksheet.Cells[16, 3], worksheet.Cells[16, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[16, 3], worksheet.Cells[16, 3]).Value2.ToString(); //COLOR_VER
                                ws_value_01[15] = (worksheet.get_Range(worksheet.Cells[17, 3], worksheet.Cells[17, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 3], worksheet.Cells[17, 3]).Value2.ToString(); //LAST_CD
                                ws_value_01[16] = (worksheet.get_Range(worksheet.Cells[18, 3], worksheet.Cells[18, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[18, 3], worksheet.Cells[18, 3]).Value2.ToString(); //PATTERN
                                ws_value_01[17] = (worksheet.get_Range(worksheet.Cells[19, 3], worksheet.Cells[19, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[19, 3], worksheet.Cells[19, 3]).Value2.ToString(); //STL_FILE
                                
                                if(pcc_dd_yn.Equals("Y"))
                                    ws_value_01[18] = (worksheet.get_Range(worksheet.Cells[20, 3], worksheet.Cells[20, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 3], worksheet.Cells[20, 3]).Value2.ToString() + " SAMPLE" + "(PCC DD)"; //SAMPLE_TPYES
                                else
                                    ws_value_01[18] = (worksheet.get_Range(worksheet.Cells[20, 3], worksheet.Cells[20, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 3], worksheet.Cells[20, 3]).Value2.ToString() + " SAMPLE"; //SAMPLE_TPYES

                                ws_value_01[19] = (worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().Substring(0, worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().IndexOf("/"));
                                ws_value_01[20] = (worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().Substring(worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().IndexOf("/") + 1, worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().Length - (worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().IndexOf("/") + 1));
                                string[] ws_value_02 = new string[9];
                                ws_value_02[0] = (worksheet.get_Range(worksheet.Cells[2, 15], worksheet.Cells[2, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[2, 15], worksheet.Cells[2, 15]).Value2.ToString();     //IxSAMPLE_WEI
                                ws_value_02[1] = (worksheet.get_Range(worksheet.Cells[3, 15], worksheet.Cells[3, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 15], worksheet.Cells[3, 15]).Value2.ToString();     //IxCOLLAR_HEI
                                ws_value_02[2] = (worksheet.get_Range(worksheet.Cells[4, 15], worksheet.Cells[4, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 15], worksheet.Cells[4, 15]).Value2.ToString();     //IxHEEL_HEI
                                ws_value_02[3] = (worksheet.get_Range(worksheet.Cells[5, 15], worksheet.Cells[5, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 15], worksheet.Cells[5, 15]).Value2.ToString();   //IxMEDIAL_HEI  
                                ws_value_02[4] = (worksheet.get_Range(worksheet.Cells[6, 15], worksheet.Cells[6, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[6, 15], worksheet.Cells[6, 15]).Value2.ToString();   //IxLATERAL_HEI 
                                ws_value_02[5] = (worksheet.get_Range(worksheet.Cells[7, 15], worksheet.Cells[7, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 15], worksheet.Cells[7, 15]).Value2.ToString();   //IxLACE_LENGTH 
                                ws_value_02[6] = (worksheet.get_Range(worksheet.Cells[8, 15], worksheet.Cells[8, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[8, 15], worksheet.Cells[8, 15]).Value2.ToString();   //IxMS_HARDNESS 
                                ws_value_02[7] = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2.ToString(); //IxIDS_LENGTH  
                                ws_value_02[8] = (worksheet.get_Range(worksheet.Cells[10, 15], worksheet.Cells[10, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[10, 15], worksheet.Cells[10, 15]).Value2.ToString();  //IxBARCODE_DATE

                                string[] ws_value_03 = new string[7];
                                ws_value_03[0] = (worksheet.get_Range(worksheet.Cells[2, 22], worksheet.Cells[2, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[2, 22], worksheet.Cells[2, 22]).Value2.ToString();   //REQ_YMD
                                ws_value_03[1] = (worksheet.get_Range(worksheet.Cells[3, 22], worksheet.Cells[3, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 22], worksheet.Cells[3, 22]).Value2.ToString();   //DISPATCH_YMD
                                ws_value_03[2] = (worksheet.get_Range(worksheet.Cells[4, 22], worksheet.Cells[4, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 22], worksheet.Cells[4, 22]).Value2.ToString();   //CDC_DEV
                                ws_value_03[3] = (worksheet.get_Range(worksheet.Cells[5, 22], worksheet.Cells[5, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 22], worksheet.Cells[5, 22]).Value2.ToString();   //NLO_DEV
                                ws_value_03[4] = (worksheet.get_Range(worksheet.Cells[6, 22], worksheet.Cells[6, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[6, 22], worksheet.Cells[6, 22]).Value2.ToString();   //FGA_QTY
                                ws_value_03[5] = (worksheet.get_Range(worksheet.Cells[7, 22], worksheet.Cells[7, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 22], worksheet.Cells[7, 22]).Value2.ToString();   //DISPATCH_YMD
                                ws_value_03[6] = (worksheet.get_Range(worksheet.Cells[8, 22], worksheet.Cells[8, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[8, 22], worksheet.Cells[8, 22]).Value2.ToString();   //FIT
                                #endregion

                                #region Tag Data Flush
                                fi = new FileInfo(server_tag_path);
                                if (!fi.Exists)
                                {
                                    MessageBox.Show("This File is not exist, Please ask System.");
                                    return;
                                }
                                
                                file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_ws.xls";
                                file_path = file_dir + file_name;

                                fi.CopyTo(file_path, true);

                                application = new Microsoft.Office.Interop.Excel.Application();
                                application.Visible = false;
                                application.DisplayAlerts = false;

                                workbook = (Workbook)(application.Workbooks.Open(file_path, Type.Missing, Type.Missing,

                                                         Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,

                                                         Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));

                                #region Image Insert
                                try
                                {
                                    System.Data.DataTable dt_image = GET_SXE_SPEC_IMAGE(i);

                                    if (dt_image.Rows.Count > 0)
                                    {
                                        byte[] MyData = null;
                                        MyData = (byte[])dt_image.Rows[0].ItemArray[0];

                                        MemoryStream ms = new MemoryStream(MyData);
                                        System.Drawing.Bitmap true_image = new System.Drawing.Bitmap(ms);

                                        int image_width = true_image.Width;
                                        int image_height = true_image.Height;

                                        if (image_height > image_width)
                                            true_image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                                        worksheet = workbook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;
                                        Microsoft.Office.Interop.Excel.Range range = worksheet.get_Range(worksheet.Cells[11, 3], worksheet.Cells[11, 3]);
                                        Clipboard.SetDataObject(true_image);
                                        object oMissing = System.Reflection.Missing.Value;

                                        worksheet.Paste(range, oMissing);

                                        worksheet = workbook.Worksheets[3] as Microsoft.Office.Interop.Excel.Worksheet;
                                        true_image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                                        for (int k = 5; k <= 20; k++)
                                        {
                                            if (k % 5 == 0)
                                            {
                                                range = worksheet.get_Range(worksheet.Cells[1, k], worksheet.Cells[1, k]);
                                                Clipboard.SetDataObject(true_image);
                                                worksheet.Paste(range, oMissing);

                                                range = worksheet.get_Range(worksheet.Cells[22, k], worksheet.Cells[22, k]);
                                                Clipboard.SetDataObject(true_image);
                                                worksheet.Paste(range, oMissing);
                                            }
                                        }


                                        worksheet = workbook.Worksheets[4] as Microsoft.Office.Interop.Excel.Worksheet;
                                        true_image.RotateFlip(RotateFlipType.Rotate270FlipNone);

                                        range = worksheet.get_Range(worksheet.Cells[13, 2], worksheet.Cells[14, 3]);
                                        Clipboard.SetDataObject(true_image);
                                        worksheet.Paste(range, oMissing);

                                        range = worksheet.get_Range(worksheet.Cells[27, 2], worksheet.Cells[29, 3]);
                                        Clipboard.SetDataObject(true_image);
                                        worksheet.Paste(range, oMissing);
                                    }
                                }
                                catch
                                {
 
                                }
                                #endregion

                                #region Data Insert
                                worksheet = workbook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;

                                for (int j = 1; j <= 21; j++)
                                {
                                    worksheet.Cells[j, 2] = ws_value_01[j - 1];
                                    if (j < ws_value_02.Length)
                                        worksheet.Cells[j, 4] = ws_value_02[j - 1];
                                    if (j < ws_value_03.Length)
                                        worksheet.Cells[j, 6] = ws_value_03[j - 1];
                                }
                                #endregion

                                worksheet = workbook.Worksheets[2] as Microsoft.Office.Interop.Excel.Worksheet;
                                worksheet.Cells[1, 1] = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCDC_DEV_NAME].ToString();

                                worksheet = workbook.Worksheets[3] as Microsoft.Office.Interop.Excel.Worksheet;
                                worksheet.Cells[11, 2] = "CONSIDERD INDEX :"+ flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxTAG_COMMENT].ToString();


                                try
                                {
                                    worksheet.SaveAs(file_path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                                    workbook.Close(false, file_path, null);
                                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                                    application.Quit();
                                    System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

                                    GC.Collect();
                                }

                                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                                workbook.Close(false, file_path, null);
                                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                                application.Quit();
                                System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

                                GC.Collect();
                                #endregion

                                Process.Start("EXCEL.EXE", file_path);
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        if (flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() == "99")
                        {
                            #region Get Data

                            string _sr_no   = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSR_NO].ToString().Replace(" ", "");
                            string _srf_no  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxSRF_NO].ToString().Replace(" ", "");
                            string _bom_id  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxBOM_ID].ToString().Replace(" ", "");
                            string _lot_no  = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString().Replace(" ", "");
                            string _lot_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString().Replace(" ", "");

                            string file_dir  = server_path + _srf_no + "\\";
                            string file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_dev.xls";
                            string file_path = file_dir + file_name;

                            string _factory = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
                            System.Data.DataTable dt_yn = GET_PCC_DD_YN(_factory, _lot_no, _lot_seq);

                            string pcc_dd_yn = dt_yn.Rows[0].ItemArray[0].ToString().Trim();

                            // Determine whether the directory exists.
                            if (!Directory.Exists(file_dir))
                            {
                                DirectoryInfo di = Directory.CreateDirectory(file_dir);
                            }

                            FileInfo fi = new FileInfo(file_path);

                            if (!fi.Exists)
                            {
                                MessageBox.Show("This File is not exist, Please ask System.");
                                return;
                            }

                            application = new Microsoft.Office.Interop.Excel.Application();
                            application.Visible = false;
                            application.DisplayAlerts = false;

                            workbook = (Workbook)(application.Workbooks.Open(file_path, Type.Missing, Type.Missing,

                                                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,

                                                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));

                            worksheet = workbook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;

                            string[] ws_value_01 = new string[21];
                            string lot_seq = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();//2레벨(생성된 Lot은 SR No를 표시하지 않음)
                            if (!lot_seq.Equals("00"))
                                ws_value_01[0] = "";
                            else
                                ws_value_01[0] = (worksheet.get_Range(worksheet.Cells[2, 3], worksheet.Cells[2, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[2, 3], worksheet.Cells[2, 3]).Value2.ToString();   //SR_NO

                            ws_value_01[1] = (worksheet.get_Range(worksheet.Cells[3, 3], worksheet.Cells[3, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 3], worksheet.Cells[3, 3]).Value2.ToString();   //ETS          
                            ws_value_01[2] = (worksheet.get_Range(worksheet.Cells[4, 3], worksheet.Cells[4, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 3], worksheet.Cells[4, 3]).Value2.ToString();   //STYLE_NAME   

                            string srf_no = (worksheet.get_Range(worksheet.Cells[5, 3], worksheet.Cells[5, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 3], worksheet.Cells[5, 3]).Value2.ToString();

                            int string_div = 0;

                            for (int t = 4; t < srf_no.Length; t++)
                            {
                                try
                                {
                                    string tmp_string = srf_no.Substring(t, 1);

                                    int tmp_value = int.Parse(tmp_string);

                                    string_div = t;
                                    break;
                                }
                                catch
                                {

                                }

                            }

                            try
                            {
                                srf_no = srf_no.Substring(0, 4) + "-" + srf_no.Substring(4, string_div - 4) + "-" + srf_no.Substring(string_div, srf_no.Length - string_div);
                            }
                            catch
                            {
                                 
                            }
                            ws_value_01[3] = srf_no;


                            ws_value_01[4] = (worksheet.get_Range(worksheet.Cells[6, 3], worksheet.Cells[6, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[6, 3], worksheet.Cells[6, 3]).Value2.ToString();      //CATEGORY     
                            ws_value_01[5] = (worksheet.get_Range(worksheet.Cells[7, 3], worksheet.Cells[7, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 3], worksheet.Cells[7, 3]).Value2.ToString();      //MTO_ACC
                            ws_value_01[6] = (worksheet.get_Range(worksheet.Cells[8, 3], worksheet.Cells[8, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[8, 3], worksheet.Cells[8, 3]).Value2.ToString();      //SEASON_CD
                            ws_value_01[7] = (worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString();      //GEN_NAME
                            ws_value_01[8] = (worksheet.get_Range(worksheet.Cells[10, 3], worksheet.Cells[10, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[10, 3], worksheet.Cells[10, 3]).Value2.ToString();  //WHQ_DEV
                            ws_value_01[9] = (worksheet.get_Range(worksheet.Cells[11, 3], worksheet.Cells[11, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[11, 3], worksheet.Cells[11, 3]).Value2.ToString();  //DEV_PROD

                            string bom_style = (worksheet.get_Range(worksheet.Cells[12, 3], worksheet.Cells[12, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[12, 3], worksheet.Cells[12, 3]).Value2.ToString();

                            if (bom_style.IndexOf("/") != -1)
                            {
                                bom_style = bom_style.Substring(0, bom_style.IndexOf("/") + 1) + bom_style.Substring(bom_style.IndexOf("/") + 1, 6) + "-" + bom_style.Substring(bom_style.IndexOf("/") + 7, 3);
                            }

                            ws_value_01[10] = bom_style; //BOM_ID
                            ws_value_01[11] = (worksheet.get_Range(worksheet.Cells[13, 3], worksheet.Cells[13, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[13, 3], worksheet.Cells[13, 3]).Value2.ToString(); //LASTING_ME
                            ws_value_01[12] = (worksheet.get_Range(worksheet.Cells[14, 3], worksheet.Cells[14, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[14, 3], worksheet.Cells[14, 3]).Value2.ToString(); //MS_ME
                            ws_value_01[13] = (worksheet.get_Range(worksheet.Cells[15, 3], worksheet.Cells[15, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[15, 3], worksheet.Cells[15, 3]).Value2.ToString(); //SOLELAYING
                            ws_value_01[14] = (worksheet.get_Range(worksheet.Cells[16, 3], worksheet.Cells[16, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[16, 3], worksheet.Cells[16, 3]).Value2.ToString(); //COLOR_VER
                            ws_value_01[15] = (worksheet.get_Range(worksheet.Cells[17, 3], worksheet.Cells[17, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[17, 3], worksheet.Cells[17, 3]).Value2.ToString(); //LAST_CD
                            ws_value_01[16] = (worksheet.get_Range(worksheet.Cells[18, 3], worksheet.Cells[18, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[18, 3], worksheet.Cells[18, 3]).Value2.ToString(); //PATTERN
                            ws_value_01[17] = (worksheet.get_Range(worksheet.Cells[19, 3], worksheet.Cells[19, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[19, 3], worksheet.Cells[19, 3]).Value2.ToString(); //STL_FILE
                            
                            if(pcc_dd_yn.Equals("Y"))
                                ws_value_01[18] = (worksheet.get_Range(worksheet.Cells[20, 3], worksheet.Cells[20, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 3], worksheet.Cells[20, 3]).Value2.ToString() + " SAMPLE" + "(PCC DD)"; //SAMPLE_TPYES
                            else
                                ws_value_01[18] = (worksheet.get_Range(worksheet.Cells[20, 3], worksheet.Cells[20, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[20, 3], worksheet.Cells[20, 3]).Value2.ToString() + " SAMPLE"; //SAMPLE_TPYES

                            ws_value_01[19] = (worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().Substring(0, worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().IndexOf("/"));
                            ws_value_01[20] = (worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().Substring(worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().IndexOf("/") + 1, worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().Length - (worksheet.get_Range(worksheet.Cells[9, 3], worksheet.Cells[9, 3]).Value2.ToString().IndexOf("/") + 1));

                            string[] ws_value_02 = new string[9];
                            ws_value_02[0] = (worksheet.get_Range(worksheet.Cells[2, 15], worksheet.Cells[2, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[2, 15], worksheet.Cells[2, 15]).Value2.ToString();     //IxSAMPLE_WEI
                            ws_value_02[1] = (worksheet.get_Range(worksheet.Cells[3, 15], worksheet.Cells[3, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 15], worksheet.Cells[3, 15]).Value2.ToString();     //IxCOLLAR_HEI
                            ws_value_02[2] = (worksheet.get_Range(worksheet.Cells[4, 15], worksheet.Cells[4, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 15], worksheet.Cells[4, 15]).Value2.ToString();     //IxHEEL_HEI
                            ws_value_02[3] = (worksheet.get_Range(worksheet.Cells[5, 15], worksheet.Cells[5, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 15], worksheet.Cells[5, 15]).Value2.ToString();     //IxMEDIAL_HEI  
                            ws_value_02[4] = (worksheet.get_Range(worksheet.Cells[6, 15], worksheet.Cells[6, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[6, 15], worksheet.Cells[6, 15]).Value2.ToString();     //IxLATERAL_HEI 
                            ws_value_02[5] = (worksheet.get_Range(worksheet.Cells[7, 15], worksheet.Cells[7, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 15], worksheet.Cells[7, 15]).Value2.ToString();     //IxLACE_LENGTH 
                            ws_value_02[6] = (worksheet.get_Range(worksheet.Cells[8, 15], worksheet.Cells[8, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[8, 15], worksheet.Cells[8, 15]).Value2.ToString();     //IxMS_HARDNESS 
                            ws_value_02[7] = (worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[9, 15], worksheet.Cells[9, 15]).Value2.ToString();     //IxIDS_LENGTH  
                            ws_value_02[8] = (worksheet.get_Range(worksheet.Cells[10, 15], worksheet.Cells[10, 15]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[10, 15], worksheet.Cells[10, 15]).Value2.ToString(); //IxBARCODE_DATE

                            string[] ws_value_03 = new string[7];
                            ws_value_03[0] = (worksheet.get_Range(worksheet.Cells[2, 22], worksheet.Cells[2, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[2, 22], worksheet.Cells[2, 22]).Value2.ToString();   //REQ_YMD
                            ws_value_03[1] = (worksheet.get_Range(worksheet.Cells[3, 22], worksheet.Cells[3, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 22], worksheet.Cells[3, 22]).Value2.ToString();   //DISPATCH_YMD
                            ws_value_03[2] = (worksheet.get_Range(worksheet.Cells[4, 22], worksheet.Cells[4, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 22], worksheet.Cells[4, 22]).Value2.ToString();   //CDC_DEV
                            ws_value_03[3] = (worksheet.get_Range(worksheet.Cells[5, 22], worksheet.Cells[5, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 22], worksheet.Cells[5, 22]).Value2.ToString();   //NLO_DEV
                            ws_value_03[4] = (worksheet.get_Range(worksheet.Cells[6, 22], worksheet.Cells[6, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[6, 22], worksheet.Cells[6, 22]).Value2.ToString();   //FGA_QTY
                            ws_value_03[5] = (worksheet.get_Range(worksheet.Cells[7, 22], worksheet.Cells[7, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 22], worksheet.Cells[7, 22]).Value2.ToString();   //DISPATCH_YMD
                            ws_value_03[6] = (worksheet.get_Range(worksheet.Cells[8, 22], worksheet.Cells[8, 22]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[8, 22], worksheet.Cells[8, 22]).Value2.ToString();   //FIT


                            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                            workbook.Close(false, file_path, null);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                            application.Quit();
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
                            //application.Workbooks.Close();
                            GC.Collect();
                            #endregion
                            
                            #region Tag Data Flush
                            fi = new FileInfo(server_tag_path);
                            if (!fi.Exists)
                            {
                                MessageBox.Show("This File is not exist, Please ask System.");
                                return;
                            }

                            file_name = _sr_no + "-" + _srf_no + "-" + _bom_id + "-" + _lot_no + "-" + _lot_seq + "_ws.xls";
                            file_path = file_dir + file_name;


                            fi.CopyTo(file_path, true);

                            application = new Microsoft.Office.Interop.Excel.Application();
                            application.Visible = false;
                            application.DisplayAlerts = false;

                            workbook = (Workbook)(application.Workbooks.Open(file_path, Type.Missing, Type.Missing,
                                                     Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                     Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));

                            #region Data Insert
                            worksheet = workbook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;

                            for (int j = 1; j <= 21; j++)
                            {
                                worksheet.Cells[j, 2] = ws_value_01[j - 1];
                                if (j < ws_value_02.Length)
                                    worksheet.Cells[j, 4] = ws_value_02[j - 1];
                                if (j < ws_value_03.Length)
                                    worksheet.Cells[j, 6] = ws_value_03[j - 1];
                            }

                            worksheet = workbook.Worksheets[2] as Microsoft.Office.Interop.Excel.Worksheet;
                            worksheet.Cells[1, 1] = flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxCDC_DEV_NAME].ToString();

                            worksheet = workbook.Worksheets[3] as Microsoft.Office.Interop.Excel.Worksheet;
                            worksheet.Cells[11, 2] = "CONSIDERD INDEX :" + flg_sch[sct_rows[i], (int)ClassLib.TBSXG_MPS_VJ.IxTAG_COMMENT].ToString();
                            #endregion
                            
                            try
                            {
                                #region Image Insert
                                System.Data.DataTable dt_image = GET_SXE_SPEC_IMAGE(sct_rows[i]);

                                if (dt_image.Rows.Count > 0)
                                {
                                    byte[] MyData = null;
                                    MyData = (byte[])dt_image.Rows[0].ItemArray[0];

                                    MemoryStream ms = new MemoryStream(MyData);
                                    System.Drawing.Bitmap true_image = new System.Drawing.Bitmap(ms);

                                    int image_width = true_image.Width;
                                    int image_height = true_image.Height;

                                    if (image_height > image_width)
                                        true_image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                                    worksheet = workbook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;
                                    Microsoft.Office.Interop.Excel.Range range = worksheet.get_Range(worksheet.Cells[11, 3], worksheet.Cells[11, 3]);
                                    Clipboard.SetDataObject(true_image);
                                    object oMissing = System.Reflection.Missing.Value;

                                    worksheet.Paste(range, oMissing);

                                    worksheet = workbook.Worksheets[3] as Microsoft.Office.Interop.Excel.Worksheet;
                                    true_image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                                    for (int k = 5; k <= 20; k++)
                                    {
                                        if (k % 5 == 0)
                                        {
                                            range = worksheet.get_Range(worksheet.Cells[1, k], worksheet.Cells[1, k]);
                                            Clipboard.SetDataObject(true_image);
                                            worksheet.Paste(range, oMissing);

                                            range = worksheet.get_Range(worksheet.Cells[22, k], worksheet.Cells[22, k]);
                                            Clipboard.SetDataObject(true_image);
                                            worksheet.Paste(range, oMissing);
                                        }
                                    }


                                    worksheet = workbook.Worksheets[4] as Microsoft.Office.Interop.Excel.Worksheet;
                                    true_image.RotateFlip(RotateFlipType.Rotate270FlipNone);

                                    range = worksheet.get_Range(worksheet.Cells[13, 2], worksheet.Cells[14, 3]);
                                    Clipboard.SetDataObject(true_image);
                                    worksheet.Paste(range, oMissing);

                                    range = worksheet.get_Range(worksheet.Cells[27, 2], worksheet.Cells[29, 3]);
                                    Clipboard.SetDataObject(true_image);
                                    worksheet.Paste(range, oMissing);

                                    //range = worksheet.get_Range(worksheet.Cells[44, 3], worksheet.Cells[44, 3]);
                                    //Clipboard.SetDataObject(true_image);
                                    //worksheet.Paste(range, oMissing);
                                }
                           
                                #endregion                                
                            }
                            catch
                            {

                            }

                            
                            try
                            {
                                worksheet.SaveAs(file_path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                                workbook.Close(false, file_path, null);
                                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                                application.Quit();
                                System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

                                GC.Collect();
                            }

                            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                            workbook.Close(false, file_path, null);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                            application.Quit();
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(application);


                            GC.Collect();
                            #endregion

                            Process.Start("EXCEL.EXE", file_path);
                        }
                    }
                }
                
            }
            catch
            {
                
            }
        }
        
        private void mnu_copy_Click(object sender, EventArgs e)
        {
            try
            {
                //int sct_row = flg_sch.Selection.r1;

                //string vmodelname = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSRF_NO].ToString().Replace(" ", "");
                //string vuploadfile_dir = server_path + vmodelname + "\\";


                //string vfilename = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSR_NO].ToString().Replace(" ", "") + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSRF_NO].ToString().Replace(" ", "") + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxBOM_ID].ToString().Replace(" ", "").Replace("/", "") + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSAMPLE_TYPE].ToString().Replace("\r\n", "").Replace(" ", "") + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxCAT].ToString().Replace(" ", "") + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSEASON].ToString() + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString() + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString() + "_dev.xls";
                //mnu_paste.ToolTipText = vfilename;
                //copy_file_name = vfilename;
                //copy_file_path = vuploadfile_dir;
                //copy_row = sct_row;
                //copy_excel = true;
                
            }
            catch
            {
 
            }

        }
        private void mnu_paste_Click(object sender, EventArgs e)
        {
            try
            {

                //int sct_row = flg_sch.Selection.r1;

                ////File Copy                
                //FileInfo fi = new FileInfo(copy_file_path + copy_file_name);

                //if (!fi.Exists)
                //{
                //    MessageBox.Show("This File is not exist, Please ask System.");
                //    return;
                //}
                //else
                //{
                //    if (MessageBox.Show("This File is already exist, Overwrite this file?.", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                //        return;
                //}




                //string vmodelname = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSRF_NO].ToString().Replace(" ", "");
                //string vuploadfile_dir = server_path + vmodelname + "\\";

                //string vfilename = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSR_NO].ToString().Replace(" ", "") + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSRF_NO].ToString().Replace(" ", "") + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxBOM_ID].ToString().Replace(" ", "").Replace("/", "") + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSAMPLE_TYPE].ToString().Replace("\r\n", "").Replace(" ", "") + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxCAT].ToString().Replace(" ", "") + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSEASON].ToString() + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString() + "-" +
                //                   flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString() + "_dev.xls";


                //// Determine whether the directory exists.
                //if (!Directory.Exists(vuploadfile_dir))
                //{
                //    DirectoryInfo di = Directory.CreateDirectory(vuploadfile_dir);
                //}

                //string vuploadfilepath = vuploadfile_dir + vfilename;

                //fi.CopyTo(vuploadfilepath, true);
                 
                   


                ////Excel 수정
                //application = new Microsoft.Office.Interop.Excel.Application();


                //workbook = (Workbook)(application.Workbooks.Open(vuploadfilepath, Type.Missing, Type.Missing,

                //                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,

                //                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));

                //worksheet = workbook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;

                //worksheet.Cells[3, 4] = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSR_NO].ToString();
                //worksheet.Cells[6, 4] = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSRF_NO].ToString().Replace(" ", "");
                ////worksheet.Cells[13, 4] = cmb_p_bom.SelectedValue.ToString() + "/" + flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSTYLE_CD_H].ToString().Trim();

                //worksheet.Cells[7, 4]  = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxCAT].ToString();
                //worksheet.Cells[9, 4]  = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSEASON].ToString();
                //worksheet.Cells[21, 4] = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSAMPLE_TYPE].ToString().Replace("\r\n", "");

                //application.Visible = false;

                //application.DisplayAlerts = false;

                //worksheet.SaveAs(vuploadfilepath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                ////workbook.Save();

                //this.NAR(this.worksheet);
                //workbook.Close(false, vuploadfilepath, null);
                //this.NAR(this.workbook);
                //this.application.Quit();
                //this.NAR(this.application);

                //GC.Collect();

                

                //MessageBox.Show(vfilename + " : " + "File Copy Complete.");
            }
            catch
            {

            }
        }

        private System.Data.DataTable GET_PCC_DD_YN(string arg_factory, string arg_lot_no, string arg_lot_seq)
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.GET_PCC_DD_YN";

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
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];


        }
        private System.Data.DataTable GET_SXE_SPEC_IMAGE(int arg_row)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.GET_SXE_SPEC_IMAGE";

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
            OraDB.Parameter_Values[0] = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxFACTORY].ToString();
            OraDB.Parameter_Values[1] = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
            OraDB.Parameter_Values[2] = flg_sch[arg_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
            OraDB.Parameter_Values[3] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }

        private void NAR(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);

            }
            catch
            {
            }

            finally
            {

                obj = null;

            }

        }
        #endregion

        #region ETC
        private void mnu_worksheet_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_sch.Selection.r1;
                int sct_col = flg_sch.Selection.c1;                

                string arg_factory  = cmb_Factory.SelectedValue.ToString();
                string arg_category = cmb_category.SelectedValue.ToString();
                string arg_season   = cmb_season.SelectedValue.ToString();
                string arg_sr_no    = "";
                string arg_srf_no   = txt_srf_no_h.Text;
                string arg_bom_id   = txt_bom_id_h.Text;
                string arg_round    = cmb_sampetyps.SelectedValue.ToString();
                string arg_user     = cmb_devuser.SelectedValue.ToString();
                string arg_op_cd    = cmb_opcd.SelectedValue.ToString();

                if (flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO] != null && flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxSORT_NO].ToString() != "99")
                    arg_op_cd = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxOP_CD].ToString();

                string arg_sort     = cmb_sort.SelectedValue.ToString();
                string arg_date     = DateTime.Now.ToString("yyyyMMdd");

                try
                {
                    arg_date = flg_sch[flg_sch.Rows.Fixed - 2, sct_col].ToString() + flg_sch[flg_sch.Rows.Fixed - 1, sct_col].ToString();
                }
                catch
                {
 
                }

                Product_VJ.Form_Prod_Result_OPCD_VJ op_result = new FlexCDC.Product_VJ.Form_Prod_Result_OPCD_VJ("MPS", arg_factory, arg_category, arg_season, arg_sr_no, arg_srf_no, arg_bom_id, arg_round, arg_user, arg_op_cd, arg_date, arg_sort);
                op_result.MdiParent = this.MdiParent;
                op_result.Show();
                
                //ws.WindowState  = FormWindowState.Maximized;
                //ws.Show();
            }
            catch
            {
 
            }
        }
        private void mnu_pcard_Click(object sender, EventArgs e)
        {
            int sct_row = flg_sch.Selection.r1;

            string factory = cmb_Factory.SelectedValue.ToString();
            string lot_no = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
            string lot_seq = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
            string op_cd = cmb_opcd.SelectedValue.ToString();

            Product_VJ.Pop_Prod_PrintOption_VJ pcard_print = new FlexCDC.Product_VJ.Pop_Prod_PrintOption_VJ("PCARD", this);
            pcard_print.ShowDialog();            
        }        
        private void mnu_level_1_Click(object sender, EventArgs e)
        {
            //int sct_row = flg_sch.Selection.r1;
            //flg_sch.TopRow = sct_row;

            flg_sch.Tree.Show(1);
        }
        private void mnu_level_2_Click(object sender, EventArgs e)
        {
            int sct_row = flg_sch.Selection.r1;
            flg_sch.TopRow = sct_row;

            flg_sch.Tree.Show(2);
        }

        private void mnu_formula_Click(object sender, EventArgs e)
        {
            int sct_row = flg_sch.Selection.r1;

            string factory = cmb_Factory.SelectedValue.ToString();
            string lot_no  = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_NO].ToString();
            string lot_seq = flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxLOT_SEQ].ToString();
            
            Pop_Plan_sch_Formula_VJ pop = new Pop_Plan_sch_Formula_VJ(factory, lot_no, lot_seq);
            pop.ShowDialog();

            if (pop._save_flg)
            {
                flg_sch[sct_row, (int)ClassLib.TBSXG_MPS_VJ.IxFORMULA_CHK] = "True";
            }
        }  
        #endregion

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            MessageBox.Show("OK");
        }
                
        #endregion               
    }
}

