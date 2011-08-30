using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;

namespace FlexCDC.Purchase
{
	public class Pop_Pur_Vendor : COM.PCHWinForm.Pop_Large_B
	{

		#region 로딩시 변수 처리 

		private int _RowFixed_mat = 0;
		private int _RowFixed_xxx = 0;
		private int sct_row1 = 0;
		private int sct_row2 = 0;
		private string factory  ="";
		private string mat_cd = null;
		private string ven_name = null;

		#endregion 

		#region 컨트롤정의 및 리소스 정의 

		private System.Windows.Forms.TextBox txt_popula;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_vendor;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage for_mat_cd;
		private COM.FSP fgrid_matsearch;
		private System.Windows.Forms.TabPage for_chang_cd;
		private COM.FSP fgrid_x_vendor;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_x_code;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		public System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		public System.Windows.Forms.PictureBox pictureBox17;
		private System.ComponentModel.IContainer components = null;
		private COM.OraDB OraDB = new COM.OraDB();
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_ColorDesc;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox pictureBox18;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
        public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.Button btn_Search;

		

		private Purchase.Form_Pur_Order_New orderForm = null;
		
	
		public Pop_Pur_Vendor()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		public Pop_Pur_Vendor(Purchase.Form_Pur_Order_New arg_form,string arg_factory, int arg_sct_row1,int arg_sct_row2, string arg_mat_cd, string arg_ven_name)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			orderForm = arg_form;
			factory  = arg_factory;
			sct_row1 = arg_sct_row1;
			sct_row2 = arg_sct_row2;
			mat_cd = arg_mat_cd;
			ven_name = arg_ven_name;
			
			txt_name.Text = ven_name;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Pur_Vendor));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.txt_popula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vendor = new System.Windows.Forms.TextBox();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.for_mat_cd = new System.Windows.Forms.TabPage();
            this.fgrid_matsearch = new COM.FSP();
            this.for_chang_cd = new System.Windows.Forms.TabPage();
            this.fgrid_x_vendor = new COM.FSP();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_x_code = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_ColorDesc = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.for_mat_cd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_matsearch)).BeginInit();
            this.for_chang_cd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_x_vendor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(577, 4);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(800, 23);
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
            // txt_popula
            // 
            this.txt_popula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_popula.Location = new System.Drawing.Point(112, 515);
            this.txt_popula.Name = "txt_popula";
            this.txt_popula.Size = new System.Drawing.Size(750, 21);
            this.txt_popula.TabIndex = 319;
            // 
            // label1
            // 
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 318;
            this.label1.Text = "Popula Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendor
            // 
            this.txt_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendor.Location = new System.Drawing.Point(112, 491);
            this.txt_vendor.Name = "txt_vendor";
            this.txt_vendor.Size = new System.Drawing.Size(750, 21);
            this.txt_vendor.TabIndex = 317;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(8, 491);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 316;
            this.lbl_vendor.Text = "Vendor Name";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.for_mat_cd);
            this.tabControl.Controls.Add(this.for_chang_cd);
            this.tabControl.Location = new System.Drawing.Point(8, 149);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(856, 335);
            this.tabControl.TabIndex = 315;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // for_mat_cd
            // 
            this.for_mat_cd.Controls.Add(this.fgrid_matsearch);
            this.for_mat_cd.Location = new System.Drawing.Point(4, 21);
            this.for_mat_cd.Name = "for_mat_cd";
            this.for_mat_cd.Size = new System.Drawing.Size(848, 310);
            this.for_mat_cd.TabIndex = 0;
            this.for_mat_cd.Text = "Search";
            // 
            // fgrid_matsearch
            // 
            this.fgrid_matsearch.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_matsearch.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgrid_matsearch.AutoResize = false;
            this.fgrid_matsearch.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_matsearch.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_matsearch.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_matsearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.fgrid_matsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_matsearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_matsearch.Location = new System.Drawing.Point(0, 0);
            this.fgrid_matsearch.Name = "fgrid_matsearch";
            this.fgrid_matsearch.Rows.Fixed = 0;
            this.fgrid_matsearch.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_matsearch.Size = new System.Drawing.Size(848, 310);
            this.fgrid_matsearch.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_matsearch.Styles"));
            this.fgrid_matsearch.TabIndex = 129;
            this.fgrid_matsearch.DoubleClick += new System.EventHandler(this.fgrid_matsearch_DoubleClick);
            this.fgrid_matsearch.Click += new System.EventHandler(this.fgrid_matsearch_Click);
            // 
            // for_chang_cd
            // 
            this.for_chang_cd.Controls.Add(this.fgrid_x_vendor);
            this.for_chang_cd.Controls.Add(this.panel1);
            this.for_chang_cd.Location = new System.Drawing.Point(4, 21);
            this.for_chang_cd.Name = "for_chang_cd";
            this.for_chang_cd.Size = new System.Drawing.Size(848, 303);
            this.for_chang_cd.TabIndex = 1;
            this.for_chang_cd.Text = "Save";
            this.for_chang_cd.Visible = false;
            // 
            // fgrid_x_vendor
            // 
            this.fgrid_x_vendor.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_x_vendor.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgrid_x_vendor.AutoResize = false;
            this.fgrid_x_vendor.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_x_vendor.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_x_vendor.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_x_vendor.Cursor = System.Windows.Forms.Cursors.Default;
            this.fgrid_x_vendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_x_vendor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_x_vendor.Location = new System.Drawing.Point(0, 0);
            this.fgrid_x_vendor.Name = "fgrid_x_vendor";
            this.fgrid_x_vendor.Rows.Fixed = 0;
            this.fgrid_x_vendor.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_x_vendor.Size = new System.Drawing.Size(848, 303);
            this.fgrid_x_vendor.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_x_vendor.Styles"));
            this.fgrid_x_vendor.TabIndex = 130;
            this.fgrid_x_vendor.DoubleClick += new System.EventHandler(this.fgrid_x_vendor_DoubleClick);
            this.fgrid_x_vendor.Click += new System.EventHandler(this.fgrid_x_vendor_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lbl_x_code);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panel1.Size = new System.Drawing.Size(848, 72);
            this.panel1.TabIndex = 129;
            // 
            // lbl_x_code
            // 
            this.lbl_x_code.ImageIndex = 0;
            this.lbl_x_code.ImageList = this.img_Label;
            this.lbl_x_code.Location = new System.Drawing.Point(8, 36);
            this.lbl_x_code.Name = "lbl_x_code";
            this.lbl_x_code.Size = new System.Drawing.Size(100, 21);
            this.lbl_x_code.TabIndex = 301;
            this.lbl_x_code.Text = "Code";
            this.lbl_x_code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(768, 304);
            this.textBox3.MaxLength = 100;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 21);
            this.textBox3.TabIndex = 270;
            this.textBox3.Tag = "60";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(560, 304);
            this.textBox4.MaxLength = 100;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 21);
            this.textBox4.TabIndex = 268;
            this.textBox4.Tag = "60";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(384, 328);
            this.textBox5.MaxLength = 100;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(416, 21);
            this.textBox5.TabIndex = 267;
            this.textBox5.Tag = "60";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(376, 304);
            this.textBox6.MaxLength = 100;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 21);
            this.textBox6.TabIndex = 264;
            this.textBox6.Tag = "60";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(200, 304);
            this.textBox7.MaxLength = 100;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 21);
            this.textBox7.TabIndex = 263;
            this.textBox7.Tag = "60";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(24, 304);
            this.textBox8.MaxLength = 100;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(150, 21);
            this.textBox8.TabIndex = 262;
            this.textBox8.Tag = "60";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Controls.Add(this.pictureBox14);
            this.panel2.Controls.Add(this.pictureBox15);
            this.panel2.Controls.Add(this.pictureBox16);
            this.panel2.Controls.Add(this.pictureBox17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 64);
            this.panel2.TabIndex = 18;
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(831, 30);
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
            this.pictureBox10.Location = new System.Drawing.Point(832, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(16, 32);
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(832, 49);
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
            this.pictureBox13.Size = new System.Drawing.Size(848, 18);
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
            this.pictureBox16.Size = new System.Drawing.Size(848, 24);
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
            this.pictureBox17.Size = new System.Drawing.Size(848, 24);
            this.pictureBox17.TabIndex = 27;
            this.pictureBox17.TabStop = false;
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.panel3);
            this.pnl_Search.Location = new System.Drawing.Point(0, 64);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(864, 83);
            this.pnl_Search.TabIndex = 329;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.btn_Search);
            this.panel3.Controls.Add(this.lbl_ColorDesc);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Controls.Add(this.cmb_Factory);
            this.panel3.Controls.Add(this.lbl_Factory);
            this.panel3.Controls.Add(this.pictureBox18);
            this.panel3.Controls.Add(this.picb_TR);
            this.panel3.Controls.Add(this.picb_TM);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.picb_BR);
            this.panel3.Controls.Add(this.picb_BM);
            this.panel3.Controls.Add(this.picb_BL);
            this.panel3.Controls.Add(this.picb_ML);
            this.panel3.Controls.Add(this.picb_MM);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 67);
            this.panel3.TabIndex = 19;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(736, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(95, 23);
            this.btn_Search.TabIndex = 550;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_ColorDesc
            // 
            this.lbl_ColorDesc.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ColorDesc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorDesc.ImageIndex = 0;
            this.lbl_ColorDesc.ImageList = this.img_Label;
            this.lbl_ColorDesc.Location = new System.Drawing.Point(374, 36);
            this.lbl_ColorDesc.Name = "lbl_ColorDesc";
            this.lbl_ColorDesc.Size = new System.Drawing.Size(99, 21);
            this.lbl_ColorDesc.TabIndex = 547;
            this.lbl_ColorDesc.Tag = "1";
            this.lbl_ColorDesc.Text = "Name";
            this.lbl_ColorDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(475, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(260, 22);
            this.txt_name.TabIndex = 549;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style4;
            this.cmb_Factory.HighLightRowStyle = style5;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 36);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style6;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style7;
            this.cmb_Factory.Size = new System.Drawing.Size(260, 21);
            this.cmb_Factory.Style = style8;
            this.cmb_Factory.TabIndex = 35;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(8, 36);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 36;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(747, 25);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(101, 27);
            this.pictureBox18.TabIndex = 26;
            this.pictureBox18.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(832, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(16, 32);
            this.picb_TR.TabIndex = 21;
            this.picb_TR.TabStop = false;
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(224, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(624, 32);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 28;
            this.label2.Tag = "";
            this.label2.Text = "      Code Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(832, 52);
            this.picb_BR.Name = "picb_BR";
            this.picb_BR.Size = new System.Drawing.Size(16, 16);
            this.picb_BR.TabIndex = 23;
            this.picb_BR.TabStop = false;
            // 
            // picb_BM
            // 
            this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
            this.picb_BM.Location = new System.Drawing.Point(144, 51);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(688, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 52);
            this.picb_BL.Name = "picb_BL";
            this.picb_BL.Size = new System.Drawing.Size(168, 20);
            this.picb_BL.TabIndex = 22;
            this.picb_BL.TabStop = false;
            // 
            // picb_ML
            // 
            this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
            this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
            this.picb_ML.Location = new System.Drawing.Point(0, 24);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(211, 34);
            this.picb_ML.TabIndex = 25;
            this.picb_ML.TabStop = false;
            // 
            // picb_MM
            // 
            this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
            this.picb_MM.Location = new System.Drawing.Point(160, 24);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(680, 27);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // Pop_Pur_Vendor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(864, 542);
            this.Controls.Add(this.pnl_Search);
            this.Controls.Add(this.txt_popula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_vendor);
            this.Controls.Add(this.lbl_vendor);
            this.Controls.Add(this.tabControl);
            this.Name = "Pop_Pur_Vendor";
            this.Text = "Vender Information";
            this.Load += new System.EventHandler(this.Pop_Pur_Vendor_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.tabControl, 0);
            this.Controls.SetChildIndex(this.lbl_vendor, 0);
            this.Controls.SetChildIndex(this.txt_vendor, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_popula, 0);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.for_mat_cd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_matsearch)).EndInit();
            this.for_chang_cd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_x_vendor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region 공통 메쏘드
		private void Init_Form()
		{


			this.Text = "Vendor Information";
			this.lbl_MainTitle.Text = "Vendor Information";
			//this.lbl_title.Text = "      Vendor Information";

			//ClassLib.ComFunction.SetLangDic(this); 


			tbtn_Append.Enabled  = false;
			tbtn_Color.Enabled   = false;
			tbtn_Conform.Enabled = false;
			tbtn_Create.Enabled  = false;
			tbtn_Delete.Enabled  = false;
			tbtn_Insert.Enabled  = false;
			tbtn_New.Enabled	 = false;
			tbtn_Print.Enabled   = false;
			tbtn_Save.Enabled    = true;
			tbtn_Search.Enabled  = false;




			DataTable  dt_list;		
			// Factory Combobox Add Items
			dt_list = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
			//cmb_Factory.Enabled  = false;



			fgrid_matsearch.Set_Grid_CDC("SXO_PUR_VENDOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_matsearch.Set_Action_Image(img_Action);
			_RowFixed_mat = fgrid_matsearch.Rows.Count;

			fgrid_x_vendor.Set_Grid_CDC("SXO_PUR_VENDOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_x_vendor.Set_Action_Image(img_Action);
			_RowFixed_xxx = fgrid_matsearch.Rows.Count;


			 textbox_control(false);



            //if(orderForm != null)
            //{
            //    //Search_Data(1 ,txt_code.Text.ToUpper(), txt_name.Text.ToUpper());
            //}
		}

		private void textbox_control(bool arg_enable)
		{           
            txt_name.Clear();
			txt_vendor.Enabled = arg_enable;
			txt_popula.Enabled = arg_enable;			
		}

		private void Search_Data(int grid_type, string arg_vendor)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (grid_type == 1)
                {
                    DataTable dt = Select_sxd_m_vendor(arg_vendor);

                    int dt_row = dt.Rows.Count;
                    int dt_col = dt.Columns.Count;

                    fgrid_matsearch.Rows.Count = _RowFixed_mat;
                    for (int i = 0; i < dt_row; i++)
                    {
                        fgrid_matsearch.AddItem(dt.Rows[i].ItemArray, fgrid_matsearch.Rows.Count, 0);
                    }
                }
                else
                {
                    DataTable dt = Select_sxd_m_vendor_xxx(arg_vendor);

                    int dt_row = dt.Rows.Count;
                    int dt_col = dt.Columns.Count;

                    fgrid_x_vendor.Rows.Count = _RowFixed_xxx;
                    for (int i = 0; i < dt_row; i++)
                    {
                        fgrid_x_vendor.AddItem(dt.Rows[i].ItemArray, fgrid_x_vendor.Rows.Count, 0);
                    }

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

		#endregion

		#region 이벤트처리

		private void tabControl_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(tabControl.SelectedIndex == 0)   //search
			{
				textbox_control(false);

				
				txt_name.Clear();
				
				txt_name.Enabled =true;

				txt_popula.Enabled =false;
				txt_vendor.Enabled =false;

			}
			else       //save
			{
				textbox_control(true);
				
				txt_name.Clear();

				
				txt_name.Enabled =true;


				txt_popula.Enabled =true;
				txt_vendor.Enabled =true;

				
			}
		}


	

		private void btn_Search_Click(object sender, System.EventArgs e)
		{

			if(tabControl.SelectedIndex == 0) 
			{
				Search_Data(1, txt_name.Text.ToUpper().Trim());

			}
			else
			{
				Search_Data(2, txt_name.Text.ToUpper().Trim());

			}
		
				

		}


		
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (txt_vendor.Text.Trim().Length == 0)
                {
                    
                    return;
                }


                #region  SH Vendor확인

                DataTable dt = Check_sxd_m_vendor(txt_name.Text.ToUpper().Trim());



                if (dt.Rows[0].ItemArray[0].ToString() == ClassLib.ComVar.ConsCDC_N)
                {

                    MessageBox.Show("Please.. Register SH Vendor Code..");


                    this.Close();
                    return;

                }
                #endregion 

                
                #region  Vendor수정

                dt = Modify_sxd_srf_m_vendor();

                int[] selectRow = orderForm.fgrid_order.Selections;

                if (orderForm != null)
                {

                    for (int i = 0; i < orderForm.fgrid_order.Selections.Length; i++)
                    {
                        orderForm.fgrid_order[selectRow[i], (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_NAME] = dt.Rows[0].ItemArray[0].ToString();


                        if (!orderForm.fgrid_order[selectRow[i], (int)ClassLib.TBSXP_PUR_ORDER.IxDIVISION].Equals("I"))
                        {
                            if (orderForm.fgrid_order[selectRow[i], (int)ClassLib.TBSXP_PUR_ORDER.IxT_LEVEL].ToString() == "1")
                                orderForm.fgrid_order[selectRow[i], (int)ClassLib.TBSXP_PUR_ORDER.IxDIVISION] = "U";
                        }

                        orderForm.fgrid_order[selectRow[i], (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_SEQ] =
                        orderForm.fgrid_order[selectRow[i], (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_NAME] = dt.Rows[0].ItemArray[0].ToString();
                    }

                }
                #endregion 

                this.Close();
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


		

//
//		private void btn_save_Click(object sender, System.EventArgs e)
//		{
////			if(txt_vendor.Text.Trim().Length == 0)
////			{
////				//MessageBox.Show("aaa");
////				return;
////			}
////
////			DataTable dt = Modify_sxd_srf_m_vendor();
////
////
////			if(orderForm != null)
////			{
////
////				for (int i = sct_row1; i<= sct_row2; i++)
////				{
////					orderForm.fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_NAME] = dt.Rows[0].ItemArray[0].ToString();
////
////				
////					if(!orderForm.fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxDIVISION].Equals("I"))
////					{
////						orderForm.fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxDIVISION] = "U";
////					}
////
////					orderForm.fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_SEQ] = 
////					orderForm.fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_NAME] = dt.Rows[0].ItemArray[0].ToString();
////				}
////
////			}
////
////			this.Close();
//		}

		#endregion

		#region 그리드 이벤트

        private void fgrid_matsearch_Click(object sender, EventArgs e)
        {
            int sct_row = fgrid_matsearch.Selection.r1;
            int sct_col = fgrid_matsearch.Selection.c1;

            if (sct_row >= _RowFixed_mat)
            {
                txt_vendor.Text = fgrid_matsearch[sct_row, (int)ClassLib.TBSXP_PUR_VENDOR.IxVENDOR].ToString();


            }
        }

        private void fgrid_x_vendor_Click(object sender, EventArgs e)
        {
            int sct_row = fgrid_x_vendor.Selection.r1;
            int sct_col = fgrid_x_vendor.Selection.c1;

            if (sct_row >= _RowFixed_mat)
            {
                txt_vendor.Text = fgrid_x_vendor[sct_row, (int)ClassLib.TBSXP_PUR_VENDOR.IxVENDOR].ToString();


            }
        }
		private void fgrid_matsearch_DoubleClick(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_matsearch.Selection.r1;
			int sct_col = fgrid_matsearch.Selection.c1;

			if(sct_row >= _RowFixed_mat)
			{
				txt_vendor.Text = fgrid_matsearch[sct_row, (int)ClassLib.TBSXP_PUR_VENDOR.IxVENDOR].ToString();


			}

            tbtn_Save_Click(null, null);
		}

		private void fgrid_x_vendor_DoubleClick(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_x_vendor.Selection.r1;
			int sct_col = fgrid_x_vendor.Selection.c1;

			if(sct_row >= _RowFixed_mat)
			{
				txt_vendor.Text = fgrid_x_vendor[sct_row, (int)ClassLib.TBSXP_PUR_VENDOR.IxVENDOR].ToString();
			

			}

            tbtn_Save_Click(null, null);

		}

		#endregion 

		#region DB컨넥트


        private DataTable Check_sxd_m_vendor(string arg_vendor)
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.CHECK_SELECT_SXD_VENDOR";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_VEN_DESC";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = ClassLib.ComVar.This_CDC_Factory;
            OraDB.Parameter_Values[1] = arg_vendor.ToUpper();
            OraDB.Parameter_Values[2] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }




		private DataTable Select_sxd_m_vendor(string arg_vendor)
		{
			string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXD_VENDOR";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";			
			OraDB.Parameter_Name[1] = "ARG_VEN_DESC";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;			
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = ClassLib.ComVar.This_CDC_Factory;			
			OraDB.Parameter_Values[1] = arg_vendor.ToUpper();
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null;
			
			return DS_Ret.Tables[Proc_Name];
		}
        private DataTable Select_sxd_m_vendor_xxx(string arg_vendor)
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXD_VENDOR_XXX";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_VEN_DESC";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = ClassLib.ComVar.This_CDC_Factory;
            OraDB.Parameter_Values[1] = arg_vendor.ToUpper();
            OraDB.Parameter_Values[2] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


	

		private DataTable Modify_sxd_srf_m_vendor()
		{
			string Proc_Name = "pkg_SXP_PUR_02.modify_sxd_srf_m_vendor";

			OraDB.ReDim_Parameter(5);
			OraDB.Process_Name = Proc_Name;
    
			OraDB.Parameter_Name[0] = "arg_factory";     
			OraDB.Parameter_Name[1] = "arg_ven_desc";          
			OraDB.Parameter_Name[2] = "arg_popula_name";
			OraDB.Parameter_Name[3] = "arg_upd_user";
			OraDB.Parameter_Name[4] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = ClassLib.ComVar.This_CDC_Factory;
			OraDB.Parameter_Values[1] = txt_vendor.Text.Trim().ToUpper();
			OraDB.Parameter_Values[2] = txt_popula.Text.Trim().ToUpper();
			OraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;
			OraDB.Parameter_Values[4] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}


		#endregion 

		private void Pop_Pur_Vendor_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
	}
}

