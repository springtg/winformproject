using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP
{
	/// <summary>
	/// Form_First에 대한 요약 설명입니다.
	/// </summary>
	public class Form_Home : System.Windows.Forms.Form
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ImageList img_Exit;
		private System.Windows.Forms.PictureBox pictureBox44;
		private C1.Win.C1Command.C1CommandLink c1CommandLink1;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private System.Windows.Forms.Label lbl_main_pic;
		private System.Windows.Forms.Label lbl_haed_pic;
		public System.Windows.Forms.Panel pal_DataBase;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label14;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.Label label15;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		private C1.Win.C1Command.C1ToolBar c1ToolBar3;
		private System.Windows.Forms.PictureBox pictureBox41;
		public System.Windows.Forms.Panel pnl_notice_user;
		public System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox45;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		private C1.Win.C1Command.C1ToolBar c1ToolBar1;
		public System.Windows.Forms.PictureBox pictureBox16;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label13;
		private COM.FSP fgrid_ingwork;
		public System.Windows.Forms.PictureBox pictureBox17;
		public System.Windows.Forms.PictureBox pictureBox18;
		public System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox42;
		public System.Windows.Forms.PictureBox pictureBox19;
		public System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.PictureBox pictureBox21;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.PictureBox pictureBox22;
		public System.Windows.Forms.PictureBox pictureBox23;
		private C1.Win.C1Command.C1ToolBar c1ToolBar2;
		public System.Windows.Forms.PictureBox pictureBox24;
		public System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label10;
		private COM.FSP fgrid_automess;
		public System.Windows.Forms.PictureBox pictureBox25;
		public System.Windows.Forms.PictureBox pictureBox26;
		public System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.PictureBox pictureBox43;
		public System.Windows.Forms.PictureBox pictureBox27;
		public System.Windows.Forms.PictureBox pictureBox28;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.PictureBox pictureBox29;
		public System.Windows.Forms.Label label9;
		public System.Windows.Forms.PictureBox pictureBox30;
		public System.Windows.Forms.PictureBox pictureBox31;
		private C1.Win.C1Command.C1ToolBar c1ToolBar4;
		public System.Windows.Forms.PictureBox pictureBox32;
		public System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lbltomow_content;
		private System.Windows.Forms.Label lbltomow;
		public System.Windows.Forms.PictureBox pictureBox33;
		public System.Windows.Forms.PictureBox pictureBox34;
		public System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label lbltodate_content;
		private System.Windows.Forms.PictureBox pictureBox35;
		private System.Windows.Forms.Label lbltodate;
		public System.Windows.Forms.PictureBox pictureBox36;
		public System.Windows.Forms.PictureBox pictureBox37;
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.PictureBox pictureBox38;
		public System.Windows.Forms.Label label12;
		public System.Windows.Forms.PictureBox pictureBox39;
		public System.Windows.Forms.PictureBox pictureBox40;
		private C1.Win.C1Command.C1ToolBar c1ToolBar5;
		public System.Windows.Forms.PictureBox pictureBox46;  
		private C1.Win.C1List.C1Combo cmb_dpt;
		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.ImageList new_check;
		public System.Windows.Forms.PictureBox pictureBox47;
		private COM.FSP fgrid_message;
		private COM.FSP fgrid_home;
		private System.Windows.Forms.ContextMenu cmessdelete;
		private System.Windows.Forms.MenuItem menuItem1;
		

		

		public Form_Home()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.img_Exit = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.lbl_main_pic = new System.Windows.Forms.Label();
            this.lbl_haed_pic = new System.Windows.Forms.Label();
            this.pal_DataBase = new System.Windows.Forms.Panel();
            this.fgrid_home = new COM.FSP();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.c1ToolBar3 = new C1.Win.C1Command.C1ToolBar();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_notice_user = new System.Windows.Forms.Panel();
            this.fgrid_message = new COM.FSP();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.fgrid_ingwork = new COM.FSP();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.c1ToolBar2 = new C1.Win.C1Command.C1ToolBar();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.fgrid_automess = new COM.FSP();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.c1ToolBar4 = new C1.Win.C1Command.C1ToolBar();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lbltomow_content = new System.Windows.Forms.Label();
            this.lbltomow = new System.Windows.Forms.Label();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbltodate_content = new System.Windows.Forms.Label();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.lbltodate = new System.Windows.Forms.Label();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.c1ToolBar5 = new C1.Win.C1Command.C1ToolBar();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.cmb_dpt = new C1.Win.C1List.C1Combo();
            this.lbl_name = new System.Windows.Forms.Label();
            this.new_check = new System.Windows.Forms.ImageList(this.components);
            this.cmessdelete = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pal_DataBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_notice_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_ingwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_automess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_dpt)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Exit
            // 
            this.img_Exit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Exit.ImageStream")));
            this.img_Exit.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Exit.Images.SetKeyName(0, "");
            this.img_Exit.Images.SetKeyName(1, "");
            // 
            // pictureBox44
            // 
            this.pictureBox44.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox44.Location = new System.Drawing.Point(152, 24);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(368, 112);
            this.pictureBox44.TabIndex = 38;
            this.pictureBox44.TabStop = false;
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Owner = this;
            // 
            // lbl_main_pic
            // 
            this.lbl_main_pic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_main_pic.Image = ((System.Drawing.Image)(resources.GetObject("lbl_main_pic.Image")));
            this.lbl_main_pic.Location = new System.Drawing.Point(92, 52);
            this.lbl_main_pic.Name = "lbl_main_pic";
            this.lbl_main_pic.Size = new System.Drawing.Size(779, 182);
            this.lbl_main_pic.TabIndex = 106;
            this.lbl_main_pic.DoubleClick += new System.EventHandler(this.lbl_main_pic_DoubleClick);
            // 
            // lbl_haed_pic
            // 
            this.lbl_haed_pic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_haed_pic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_haed_pic.Image = ((System.Drawing.Image)(resources.GetObject("lbl_haed_pic.Image")));
            this.lbl_haed_pic.Location = new System.Drawing.Point(92, 0);
            this.lbl_haed_pic.Name = "lbl_haed_pic";
            this.lbl_haed_pic.Size = new System.Drawing.Size(779, 52);
            this.lbl_haed_pic.TabIndex = 107;
            // 
            // pal_DataBase
            // 
            this.pal_DataBase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pal_DataBase.BackColor = System.Drawing.SystemColors.Window;
            this.pal_DataBase.Controls.Add(this.fgrid_home);
            this.pal_DataBase.Controls.Add(this.pictureBox47);
            this.pal_DataBase.Controls.Add(this.pictureBox1);
            this.pal_DataBase.Controls.Add(this.panel2);
            this.pal_DataBase.Controls.Add(this.pictureBox2);
            this.pal_DataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pal_DataBase.Location = new System.Drawing.Point(93, 245);
            this.pal_DataBase.Name = "pal_DataBase";
            this.pal_DataBase.Size = new System.Drawing.Size(435, 149);
            this.pal_DataBase.TabIndex = 108;
            // 
            // fgrid_home
            // 
            this.fgrid_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fgrid_home.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.fgrid_home.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_home.Location = new System.Drawing.Point(9, 26);
            this.fgrid_home.Name = "fgrid_home";
            this.fgrid_home.Rows.DefaultSize = 18;
            this.fgrid_home.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.fgrid_home.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_home.Size = new System.Drawing.Size(417, 115);
            this.fgrid_home.StyleInfo = resources.GetString("fgrid_home.StyleInfo");
            this.fgrid_home.TabIndex = 98;
            this.fgrid_home.DoubleClick += new System.EventHandler(this.fgrid_home_DoubleClick_1);
            // 
            // pictureBox47
            // 
            this.pictureBox47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox47.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox47.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox47.Image")));
            this.pictureBox47.Location = new System.Drawing.Point(0, 130);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(27, 19);
            this.pictureBox47.TabIndex = 96;
            this.pictureBox47.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 15);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.c1ToolBar3);
            this.panel2.Controls.Add(this.pictureBox41);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 149);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(127, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(305, 123);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(397, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 36;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(422, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(13, 111);
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(421, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(14, 30);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(343, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 20);
            this.label14.TabIndex = 34;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(187, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1254, 30);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 28);
            this.label15.TabIndex = 28;
            this.label15.Text = "      Event";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1, 132);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(794, 17);
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 22);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(140, 661);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // c1ToolBar3
            // 
            this.c1ToolBar3.BackColor = System.Drawing.SystemColors.Window;
            this.c1ToolBar3.ButtonLookVert = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1ToolBar3.CommandHolder = null;
            this.c1ToolBar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1ToolBar3.Horizontal = false;
            this.c1ToolBar3.Location = new System.Drawing.Point(0, 0);
            this.c1ToolBar3.Movable = false;
            this.c1ToolBar3.Name = "c1ToolBar3";
            this.c1ToolBar3.Size = new System.Drawing.Size(435, 149);
            this.c1ToolBar3.Text = "Page 1";
            // 
            // pictureBox41
            // 
            this.pictureBox41.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox41.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox41.Image")));
            this.pictureBox41.Location = new System.Drawing.Point(133, 22);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(1302, 661);
            this.pictureBox41.TabIndex = 27;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 19);
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            // 
            // pnl_notice_user
            // 
            this.pnl_notice_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnl_notice_user.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_notice_user.Controls.Add(this.fgrid_message);
            this.pnl_notice_user.Controls.Add(this.pictureBox9);
            this.pnl_notice_user.Controls.Add(this.label5);
            this.pnl_notice_user.Controls.Add(this.pictureBox10);
            this.pnl_notice_user.Controls.Add(this.panel3);
            this.pnl_notice_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_notice_user.Location = new System.Drawing.Point(92, 401);
            this.pnl_notice_user.Name = "pnl_notice_user";
            this.pnl_notice_user.Size = new System.Drawing.Size(436, 202);
            this.pnl_notice_user.TabIndex = 109;
            // 
            // fgrid_message
            // 
            this.fgrid_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fgrid_message.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.fgrid_message.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_message.Location = new System.Drawing.Point(10, 26);
            this.fgrid_message.Name = "fgrid_message";
            this.fgrid_message.Rows.DefaultSize = 18;
            this.fgrid_message.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_message.Size = new System.Drawing.Size(417, 169);
            this.fgrid_message.StyleInfo = resources.GetString("fgrid_message.StyleInfo");
            this.fgrid_message.TabIndex = 99;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(422, 187);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(14, 15);
            this.pictureBox9.TabIndex = 95;
            this.pictureBox9.TabStop = false;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(347, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 98;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 183);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(27, 19);
            this.pictureBox10.TabIndex = 94;
            this.pictureBox10.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.pictureBox45);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox11);
            this.panel3.Controls.Add(this.pictureBox12);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox13);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox14);
            this.panel3.Controls.Add(this.pictureBox15);
            this.panel3.Controls.Add(this.c1ToolBar1);
            this.panel3.Controls.Add(this.pictureBox16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 202);
            this.panel3.TabIndex = 18;
            // 
            // pictureBox45
            // 
            this.pictureBox45.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox45.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox45.Image")));
            this.pictureBox45.Location = new System.Drawing.Point(127, 22);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(306, 169);
            this.pictureBox45.TabIndex = 38;
            this.pictureBox45.TabStop = false;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(397, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 36;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(423, 24);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(13, 164);
            this.pictureBox11.TabIndex = 26;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(422, 0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(14, 30);
            this.pictureBox12.TabIndex = 21;
            this.pictureBox12.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(343, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 34;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(187, 0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(1255, 30);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "      On Air";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(-172, 185);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(793, 17);
            this.pictureBox14.TabIndex = 24;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(0, 22);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(140, 715);
            this.pictureBox15.TabIndex = 25;
            this.pictureBox15.TabStop = false;
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.BackColor = System.Drawing.SystemColors.Window;
            this.c1ToolBar1.ButtonLookVert = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1ToolBar1.CommandHolder = null;
            this.c1ToolBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1ToolBar1.Horizontal = false;
            this.c1ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.c1ToolBar1.Movable = false;
            this.c1ToolBar1.Name = "c1ToolBar1";
            this.c1ToolBar1.Size = new System.Drawing.Size(436, 202);
            this.c1ToolBar1.Text = "Page 1";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(133, 22);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(1303, 715);
            this.pictureBox16.TabIndex = 27;
            this.pictureBox16.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.fgrid_ingwork);
            this.panel1.Controls.Add(this.pictureBox17);
            this.panel1.Controls.Add(this.pictureBox18);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(534, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 149);
            this.panel1.TabIndex = 110;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(294, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 100;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // fgrid_ingwork
            // 
            this.fgrid_ingwork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.fgrid_ingwork.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_ingwork.Location = new System.Drawing.Point(7, 31);
            this.fgrid_ingwork.Name = "fgrid_ingwork";
            this.fgrid_ingwork.Rows.DefaultSize = 18;
            this.fgrid_ingwork.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_ingwork.Size = new System.Drawing.Size(324, 110);
            this.fgrid_ingwork.StyleInfo = resources.GetString("fgrid_ingwork.StyleInfo");
            this.fgrid_ingwork.TabIndex = 98;
            this.fgrid_ingwork.DoubleClick += new System.EventHandler(this.fgrid_ingwork_DoubleClick);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(323, 134);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(14, 15);
            this.pictureBox17.TabIndex = 95;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(0, 130);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(27, 19);
            this.pictureBox18.TabIndex = 94;
            this.pictureBox18.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox42);
            this.panel4.Controls.Add(this.pictureBox19);
            this.panel4.Controls.Add(this.pictureBox20);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox21);
            this.panel4.Controls.Add(this.pictureBox22);
            this.panel4.Controls.Add(this.pictureBox23);
            this.panel4.Controls.Add(this.c1ToolBar2);
            this.panel4.Controls.Add(this.pictureBox24);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 149);
            this.panel4.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 28);
            this.label7.TabIndex = 28;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox42
            // 
            this.pictureBox42.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox42.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox42.Image")));
            this.pictureBox42.Location = new System.Drawing.Point(127, 22);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(206, 115);
            this.pictureBox42.TabIndex = 36;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(324, 24);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(13, 111);
            this.pictureBox19.TabIndex = 26;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox20.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(323, 0);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(14, 30);
            this.pictureBox20.TabIndex = 21;
            this.pictureBox20.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(343, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 34;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(187, 0);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(1156, 30);
            this.pictureBox21.TabIndex = 0;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox22.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(-222, 132);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(794, 17);
            this.pictureBox22.TabIndex = 24;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox23.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(0, 22);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(140, 661);
            this.pictureBox23.TabIndex = 25;
            this.pictureBox23.TabStop = false;
            // 
            // c1ToolBar2
            // 
            this.c1ToolBar2.BackColor = System.Drawing.SystemColors.Window;
            this.c1ToolBar2.ButtonLookVert = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1ToolBar2.CommandHolder = null;
            this.c1ToolBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1ToolBar2.Horizontal = false;
            this.c1ToolBar2.Location = new System.Drawing.Point(0, 0);
            this.c1ToolBar2.Movable = false;
            this.c1ToolBar2.Name = "c1ToolBar2";
            this.c1ToolBar2.Size = new System.Drawing.Size(337, 149);
            this.c1ToolBar2.Text = "Page 1";
            // 
            // pictureBox24
            // 
            this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox24.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(133, 22);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(1204, 661);
            this.pictureBox24.TabIndex = 27;
            this.pictureBox24.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.fgrid_automess);
            this.panel5.Controls.Add(this.pictureBox25);
            this.panel5.Controls.Add(this.pictureBox26);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(534, 401);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 202);
            this.panel5.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(294, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 99;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // fgrid_automess
            // 
            this.fgrid_automess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fgrid_automess.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.fgrid_automess.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_automess.Location = new System.Drawing.Point(7, 31);
            this.fgrid_automess.Name = "fgrid_automess";
            this.fgrid_automess.Rows.DefaultSize = 18;
            this.fgrid_automess.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_automess.Size = new System.Drawing.Size(324, 164);
            this.fgrid_automess.StyleInfo = resources.GetString("fgrid_automess.StyleInfo");
            this.fgrid_automess.TabIndex = 98;
            this.fgrid_automess.DoubleClick += new System.EventHandler(this.fgrid_automess_DoubleClick);
            // 
            // pictureBox25
            // 
            this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox25.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
            this.pictureBox25.Location = new System.Drawing.Point(324, 187);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(13, 15);
            this.pictureBox25.TabIndex = 95;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox26.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(0, 183);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(27, 19);
            this.pictureBox26.TabIndex = 94;
            this.pictureBox26.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.pictureBox43);
            this.panel6.Controls.Add(this.pictureBox27);
            this.panel6.Controls.Add(this.pictureBox28);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.pictureBox29);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.pictureBox30);
            this.panel6.Controls.Add(this.pictureBox31);
            this.panel6.Controls.Add(this.c1ToolBar4);
            this.panel6.Controls.Add(this.pictureBox32);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(338, 202);
            this.panel6.TabIndex = 18;
            // 
            // pictureBox43
            // 
            this.pictureBox43.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox43.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox43.Image")));
            this.pictureBox43.Location = new System.Drawing.Point(120, 15);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(214, 176);
            this.pictureBox43.TabIndex = 36;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox27.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(326, 24);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(12, 164);
            this.pictureBox27.TabIndex = 26;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox28.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
            this.pictureBox28.Location = new System.Drawing.Point(325, 0);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(13, 30);
            this.pictureBox28.TabIndex = 21;
            this.pictureBox28.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(343, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 34;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox29.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
            this.pictureBox29.Location = new System.Drawing.Point(187, 0);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(1158, 30);
            this.pictureBox29.TabIndex = 0;
            this.pictureBox29.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 28);
            this.label9.TabIndex = 28;
            this.label9.Text = "        Please, do it ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox30.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
            this.pictureBox30.Location = new System.Drawing.Point(-221, 185);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(794, 17);
            this.pictureBox30.TabIndex = 24;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox31.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
            this.pictureBox31.Location = new System.Drawing.Point(0, 22);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(140, 715);
            this.pictureBox31.TabIndex = 25;
            this.pictureBox31.TabStop = false;
            // 
            // c1ToolBar4
            // 
            this.c1ToolBar4.BackColor = System.Drawing.SystemColors.Window;
            this.c1ToolBar4.ButtonLookVert = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1ToolBar4.CommandHolder = null;
            this.c1ToolBar4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1ToolBar4.Horizontal = false;
            this.c1ToolBar4.Location = new System.Drawing.Point(0, 0);
            this.c1ToolBar4.Movable = false;
            this.c1ToolBar4.Name = "c1ToolBar4";
            this.c1ToolBar4.Size = new System.Drawing.Size(338, 202);
            this.c1ToolBar4.Text = "Page 1";
            // 
            // pictureBox32
            // 
            this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox32.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
            this.pictureBox32.Location = new System.Drawing.Point(133, 22);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(1205, 715);
            this.pictureBox32.TabIndex = 27;
            this.pictureBox32.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.lbltomow_content);
            this.panel7.Controls.Add(this.lbltomow);
            this.panel7.Controls.Add(this.pictureBox33);
            this.panel7.Controls.Add(this.pictureBox34);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(534, 52);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(337, 182);
            this.panel7.TabIndex = 112;
            this.panel7.Visible = false;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.Location = new System.Drawing.Point(293, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 16);
            this.label16.TabIndex = 101;
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.DoubleClick += new System.EventHandler(this.label16_DoubleClick);
            // 
            // lbltomow_content
            // 
            this.lbltomow_content.Location = new System.Drawing.Point(72, 121);
            this.lbltomow_content.Name = "lbltomow_content";
            this.lbltomow_content.Size = new System.Drawing.Size(255, 48);
            this.lbltomow_content.TabIndex = 97;
            this.lbltomow_content.DoubleClick += new System.EventHandler(this.lbltomow_content_DoubleClick);
            // 
            // lbltomow
            // 
            this.lbltomow.Image = ((System.Drawing.Image)(resources.GetObject("lbltomow.Image")));
            this.lbltomow.Location = new System.Drawing.Point(12, 102);
            this.lbltomow.Name = "lbltomow";
            this.lbltomow.Size = new System.Drawing.Size(54, 72);
            this.lbltomow.TabIndex = 96;
            this.lbltomow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox33.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox33.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox33.Image")));
            this.pictureBox33.Location = new System.Drawing.Point(323, 167);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(14, 15);
            this.pictureBox33.TabIndex = 95;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox34.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
            this.pictureBox34.Location = new System.Drawing.Point(0, 163);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(27, 19);
            this.pictureBox34.TabIndex = 94;
            this.pictureBox34.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Window;
            this.panel8.Controls.Add(this.lbltodate_content);
            this.panel8.Controls.Add(this.pictureBox35);
            this.panel8.Controls.Add(this.lbltodate);
            this.panel8.Controls.Add(this.pictureBox36);
            this.panel8.Controls.Add(this.pictureBox37);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.pictureBox38);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.pictureBox39);
            this.panel8.Controls.Add(this.pictureBox40);
            this.panel8.Controls.Add(this.c1ToolBar5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(337, 182);
            this.panel8.TabIndex = 18;
            // 
            // lbltodate_content
            // 
            this.lbltodate_content.Location = new System.Drawing.Point(72, 41);
            this.lbltodate_content.Name = "lbltodate_content";
            this.lbltodate_content.Size = new System.Drawing.Size(255, 48);
            this.lbltodate_content.TabIndex = 37;
            this.lbltodate_content.DoubleClick += new System.EventHandler(this.lbltodate_content_DoubleClick);
            // 
            // pictureBox35
            // 
            this.pictureBox35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(127, 22);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(206, 112);
            this.pictureBox35.TabIndex = 39;
            this.pictureBox35.TabStop = false;
            // 
            // lbltodate
            // 
            this.lbltodate.Image = ((System.Drawing.Image)(resources.GetObject("lbltodate.Image")));
            this.lbltodate.Location = new System.Drawing.Point(13, 27);
            this.lbltodate.Name = "lbltodate";
            this.lbltodate.Size = new System.Drawing.Size(54, 71);
            this.lbltodate.TabIndex = 36;
            this.lbltodate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox36.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(324, 24);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(13, 144);
            this.pictureBox36.TabIndex = 26;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox37.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
            this.pictureBox37.Location = new System.Drawing.Point(323, 0);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(14, 30);
            this.pictureBox37.TabIndex = 21;
            this.pictureBox37.TabStop = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(343, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 34;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox38.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
            this.pictureBox38.Location = new System.Drawing.Point(187, 0);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(1156, 30);
            this.pictureBox38.TabIndex = 0;
            this.pictureBox38.TabStop = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 28);
            this.label12.TabIndex = 28;
            this.label12.Text = "        Schedule";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox39.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(-222, 165);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(794, 17);
            this.pictureBox39.TabIndex = 24;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox40.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
            this.pictureBox40.Location = new System.Drawing.Point(0, 22);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(140, 695);
            this.pictureBox40.TabIndex = 25;
            this.pictureBox40.TabStop = false;
            // 
            // c1ToolBar5
            // 
            this.c1ToolBar5.BackColor = System.Drawing.SystemColors.Window;
            this.c1ToolBar5.ButtonLookVert = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1ToolBar5.CommandHolder = null;
            this.c1ToolBar5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1ToolBar5.Horizontal = false;
            this.c1ToolBar5.Location = new System.Drawing.Point(0, 0);
            this.c1ToolBar5.Movable = false;
            this.c1ToolBar5.Name = "c1ToolBar5";
            this.c1ToolBar5.Size = new System.Drawing.Size(337, 182);
            this.c1ToolBar5.Text = "Page 1";
            // 
            // pictureBox46
            // 
            this.pictureBox46.Location = new System.Drawing.Point(0, 0);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(100, 50);
            this.pictureBox46.TabIndex = 0;
            this.pictureBox46.TabStop = false;
            // 
            // cmb_dpt
            // 
            this.cmb_dpt.AddItemSeparator = ';';
            this.cmb_dpt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_dpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_dpt.Caption = "";
            this.cmb_dpt.CaptionHeight = 17;
            this.cmb_dpt.CaptionStyle = style1;
            this.cmb_dpt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_dpt.ColumnCaptionHeight = 18;
            this.cmb_dpt.ColumnFooterHeight = 18;
            this.cmb_dpt.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_dpt.ContentHeight = 17;
            this.cmb_dpt.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_dpt.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_dpt.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dpt.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_dpt.EditorHeight = 17;
            this.cmb_dpt.EvenRowStyle = style2;
            this.cmb_dpt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dpt.FooterStyle = style3;
            this.cmb_dpt.HeadingStyle = style4;
            this.cmb_dpt.HighLightRowStyle = style5;
            this.cmb_dpt.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_dpt.Images"))));
            this.cmb_dpt.ItemHeight = 15;
            this.cmb_dpt.Location = new System.Drawing.Point(708, 0);
            this.cmb_dpt.MatchEntryTimeout = ((long)(2000));
            this.cmb_dpt.MaxDropDownItems = ((short)(5));
            this.cmb_dpt.MaxLength = 32767;
            this.cmb_dpt.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_dpt.Name = "cmb_dpt";
            this.cmb_dpt.OddRowStyle = style6;
            this.cmb_dpt.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_dpt.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_dpt.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_dpt.SelectedStyle = style7;
            this.cmb_dpt.Size = new System.Drawing.Size(150, 21);
            this.cmb_dpt.Style = style8;
            this.cmb_dpt.TabIndex = 118;
            this.cmb_dpt.Visible = false;
            this.cmb_dpt.SelectedValueChanged += new System.EventHandler(this.cmb_dpt_SelectedValueChanged);
            this.cmb_dpt.PropBag = resources.GetString("cmb_dpt.PropBag");
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_name.Location = new System.Drawing.Point(514, 25);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(340, 20);
            this.lbl_name.TabIndex = 117;
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // new_check
            // 
            this.new_check.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("new_check.ImageStream")));
            this.new_check.TransparentColor = System.Drawing.Color.Transparent;
            this.new_check.Images.SetKeyName(0, "");
            // 
            // cmessdelete
            // 
            this.cmessdelete.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Delete Item";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 640);
            this.Controls.Add(this.cmb_dpt);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_main_pic);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_notice_user);
            this.Controls.Add(this.pal_DataBase);
            this.Controls.Add(this.lbl_haed_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form_Home_Load);
            this.Closed += new System.EventHandler(this.Form_Home_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pal_DataBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_notice_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_ingwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_automess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_dpt)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 변수
		
		private COM.OraDB oraDB = null;
		private int _RowFixed = 2;
		
		//private ClassMenu ClsMenu = null;

		#endregion 

		#region 멤버 메소드

		private void init_Form()
		{

			ClassLib.ComFunction.SetLangDic(this);

			int homeX = ClassLib.ComVar.arg_form.Width/2;
			this.Width = 968;
			int homeW = this.Width/2;
			this.Location = new Point(homeX-homeW, 10);
			this.Height = (int)(ClassLib.ComVar.arg_form.Height*0.85);




			lbl_haed_pic.Location = new Point(13, 0);
			lbl_haed_pic.Size = new Size(935, 56);

			lbl_main_pic.Location = new Point(13, 56);
			lbl_main_pic.Size = new Size(935, 196);




			#region 뉴스 좌표

//			pal_DataBase.Location = new Point(14, 264);
//			pal_DataBase.Size = new Size(523, 336);
//
//			fgrid_home.Location = new Point(11, 28);
//			fgrid_home.Size = new Size(500, 300);
//
//			label1.Location = new Point(476, 0);
//			label1.Size = new Size(47, 18);
//
//			label15.Location = new Point(0,0);
//			label15.Size = new Size(231, 30); 
//
//			pictureBox4.Location = new Point(508, 26);
//			pictureBox4.Size = new Size(15, 300);


			#endregion

			#region 업무 메시지 좌표
//			panel1.Location = new Point(544, 264);
//			panel1.Size = new Size(404, 160);
//
//			fgrid_ingwork.Location = new Point(8, 33);
//			fgrid_ingwork.Size = new Size(389, 96);
//
//			label13.Location = new Point(353, 4);
//			label13.Size = new Size(47, 18);
//
//			label7.Location = new Point(0,0);
//			label7.Size = new Size(364, 30);
//
//			pictureBox19.Location = new Point(389, 26);
//			pictureBox19.Size = new Size(15, 160);
//
//			pictureBox20.Location = new Point(388,0);
//			pictureBox20.Size = new Size(16, 32);

			#endregion

    		#region ON AIR

//			pnl_notice_user.Location = new Point(13, 416);
//			pnl_notice_user.Size = new Size(523, 168);
//			//pnl_notice_user.Width = 523;
//
//			label4.Location = new Point(0,0);
//			label4.Size = new Size(231, 30);
//
//			label5.Location = new Point(416, 0);
//			label5.Size = new Size(55, 18);
//
//			label2.Location = new Point(476, 0);
//			label2.Size = new Size(47, 18);
//
//			fgrid_message.Location = new Point(12, 28);
//			fgrid_message.Size  = new Size(500, 96);
//
//			pictureBox11.Location = new Point(508, 26);
//			pictureBox11.Size = new Size(15, 168);
//
//
//			//pnl_notice_user.Anchor = AnchorStyles.Top;
//			//pnl_notice_user.Anchor = AnchorStyles.Bottom;
//
//			//fgrid_message.Anchor = AnchorStyles.Top;
//			//fgrid_message.Anchor = AnchorStyles.Bottom;
//
//
			#endregion

			#region do it

//			panel5.Location = new Point(544, 432);
//			panel5.Size = new Size(406, 168);
//
//			label9.Location = new Point(0,0);
//			label9.Size = new Size(231, 30);
//
//			label10.Location = new Point(353, 4);
//			label10.Size = new Size(47, 18);
//
//			fgrid_automess.Location = new Point(8, 33);
//			fgrid_automess.Size = new Size(389, 96);
//
//			pictureBox27.Location = new Point(390, 26);
//			pictureBox27.Size = new Size(15, 168);
//
//			pictureBox28.Location = new Point(389,0);
//			pictureBox28.Size = new Size(16, 32);

			#endregion







			oraDB = new COM.OraDB();



			lbl_name.BackColor = Color.FromArgb(247, 227, 141);



			//lbl_name.Text = ClassLib.ComVar.This_User + " / " ;
			lbl_name.Text = ClassLib.ComVar.This_User_AD + " / " ;



			//DataTable dt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxJobCd);
			DataTable dt = Show_JobCD_CD();
			ClassLib.ComCtl.Set_ComboList(dt, cmb_dpt, 0, 1, false);
			cmb_dpt.SelectedValue = ClassLib.ComVar.This_JobCdoe;







			//공지 사항 그리드 설정
			fgrid_home.Set_Grid("SPS_NOTICE_HOME","1", 1,ClassLib.ComVar.This_Lang,ClassLib.ComVar.Grid_Type.ForSearch, false);
			fgrid_home.Rows.Count = _RowFixed;
			Grid_Setting(fgrid_home);
			fgrid_home.ScrollBars = ScrollBars.Both;
			Get_Notice();

			//개인 업무 그리드 설정
//			fgrid_message.Set_Grid("SPS_NOTICE_USER","3", 1,ClassLib.ComVar.This_Lang,ClassLib.ComVar.Grid_Type.ForSearch, false);
//			fgrid_message.Rows.Count = _RowFixed;
//			Grid_Setting(fgrid_message);
//			Get_Message();


			fgrid_message.Set_Grid("SPS_AUTO_INFO", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false);
			fgrid_message.Rows.Count = _RowFixed;
			Grid_Setting(fgrid_message);
			fgrid_message.ScrollBars = ScrollBars.Vertical;
			Get_Auto_Info();

			if(ClassLib.ComVar.This_Admin_YN == "Y")
			{
				fgrid_message.ContextMenu = cmessdelete;
			}



			//진행중인 업무
			fgrid_ingwork.Set_Grid("SPS_NOTICE_INGWORK","2", 1,ClassLib.ComVar.This_Lang,ClassLib.ComVar.Grid_Type.ForSearch, false);
			fgrid_ingwork.Rows.Count = _RowFixed;
			Grid_Setting(fgrid_ingwork);
			Get_ing();




			//업무 자동 알림 그리드 설정
			fgrid_automess.Set_Grid("SPS_NOTICE_USER","3", 1,ClassLib.ComVar.This_Lang,ClassLib.ComVar.Grid_Type.ForSearch, false);
			fgrid_automess.Rows.Count = _RowFixed;
			Grid_Setting(fgrid_automess);
			Get_AutoMess();
			//fgrid_automess.Cols[5].Width = 290;



			
			


//			//개인 일정
//			lbltodate.Text = DateTime.Now.Day.ToString() + "\r\n" + DateTime.Now.DayOfWeek.ToString().Substring(0,3);
//			lbltomow.Text  = DateTime.Now.AddDays(1).Day.ToString() + "\r\n" + DateTime.Now.AddDays(1).DayOfWeek.ToString().Substring(0,3);
//
//
//			schedule = new ERP.SysBase.Class_PS_Schedule();
//			lbltodate_content.Text =  schedule.Date_Schedule(schedule.NowDate());
//			if(lbltodate_content.Text.Length == 0)
//				lbltodate_content.Text = "등록 된 일정이 없습니다.";
//
//			lbltomow_content.Text  =  schedule.Date_Schedule(schedule.NowDate(1));
//			if(lbltomow_content.Text.Length == 0)
//				lbltomow_content.Text = "등록 된 일정이 없습니다.";



			

		}


		public void Get_Notice()
		{
			fgrid_home.Rows.Count = _RowFixed;
			DataTable dt = Select_SPS_Notice();
			int rownum = dt.Rows.Count;
			int colnum = dt.Columns.Count;

			COM.ComFunction comfunc = new COM.ComFunction();

			for(int i=0; i<rownum; i++)
			{
				string[] ArrayItem = new string[colnum];
				
				for(int j=0; j<colnum; j++)
				{
					if(j == (int)ClassLib.TBSPS_NOTICE_HOME.IxSYMD)
					{
						ArrayItem[j] = "[ " + comfunc.ConvertDate2Type(dt.Rows[i].ItemArray[j].ToString()) + " ]";

					}
					else
					{
						ArrayItem[j] = dt.Rows[i].ItemArray[j].ToString();
					}

				}

				fgrid_home.AddItem(ArrayItem, fgrid_home.Rows.Count, 1);
			}
		}


		public void Get_Auto_Info()
		{
			fgrid_message.Rows.Count = _RowFixed;

			// 7행만 표시
			int max_display_row = 7; 
			DataTable dt = Select_SPS_Auto_Info(max_display_row);

			int rownum = dt.Rows.Count;
			int colnum = dt.Columns.Count;

			COM.ComFunction comfunc = new COM.ComFunction();
			for(int i=0; i<rownum; i++)
			{
				fgrid_message.Rows.Add();
				int row_num = fgrid_message.Rows.Count-1;
				string[] ArrayItem = new string[colnum];
				for(int j=0; j<colnum; j++)
				{

					string db_date = dt.Rows[i].ItemArray[j].ToString();
 
					if(j != (int)ClassLib.TBSPS_AUTO_INFO_HOME.IxUPD_YMD)
					{
						fgrid_message[_RowFixed + i, 1+j] = db_date;
					}
					else
					{
						fgrid_message[_RowFixed + i, 1+j] = "[ " + comfunc.ConvertDate2Type(db_date) + " ]";
					}
				}
			}

			//fgrid_message.AutoSizeCols();
		}

		private void Get_Message()
		{
			fgrid_message.Rows.Count = _RowFixed;

			string div = "R";

			DataTable dt = Select_SPS_Notice_UserHome(div);

			int rownum = dt.Rows.Count;
			int colnum = dt.Columns.Count;
			COM.ComFunction comfunc = new COM.ComFunction();

			for(int i=0; i<rownum; i++)
			{
				string[] ArrayItem = new string[colnum];

				for(int j=0; j<colnum; j++)
				{
					if(j == (int)ClassLib.TBSPS_NOTICE_USER_HOME.IxUPD_YMD)
					{ 
						ArrayItem[j] = "[ " + comfunc.ConvertDate2Type(dt.Rows[i].ItemArray[j].ToString()) + " ]";
					}
					else
					{
						ArrayItem[j] = dt.Rows[i].ItemArray[j].ToString();
					}
				}
				
				
				fgrid_message.AddItem(ArrayItem, fgrid_message.Rows.Count, 1);
			}
		}


		public void Get_AutoMess()
		{
			fgrid_automess.Rows.Count = _RowFixed;

			string div = "I";

			DataTable dt = Select_SPS_Notice_IngWork11(div); //Select_SPS_Notice_UserHome(div);

			int rownum = dt.Rows.Count;
			int colnum = dt.Columns.Count;
			COM.ComFunction comfunc = new COM.ComFunction();

			if(rownum > 6)
			{
				rownum = 6;
			}

			for(int i=0; i<rownum; i++)
			{
				string[] ArrayItem = new string[colnum];
				
				for(int j=0; j<colnum; j++)
				{
					if(j == (int)ClassLib.TBSPS_WORKINFO_USER_HOME.IxUPD_YMD )
					{
						ArrayItem[j] = "[ " + comfunc.ConvertDate2Type(dt.Rows[i].ItemArray[j].ToString()) + " ]";
					}
					else
					{
						ArrayItem[j] = dt.Rows[i].ItemArray[j].ToString();
					}

				}

				fgrid_automess.AddItem(ArrayItem, fgrid_automess.Rows.Count, 1);
			}
		}


		public void Get_ing()
		{
			fgrid_ingwork.Rows.Count = _RowFixed;

			if(cmb_dpt.SelectedIndex == -1) return;

			DataTable dt = Select_SPS_Notice_IngWork(cmb_dpt.SelectedValue.ToString());
			int rownum = dt.Rows.Count;
			int colnum = dt.Columns.Count;

			COM.ComFunction comfunc = new COM.ComFunction();
			for(int i=0; i<rownum; i++)
			{
				string[] ArrayItem = new string[colnum];
				for(int j=0; j<colnum; j++)
				{
					if(j == (int)ClassLib.TBSPS_NOTICE_INGWORK_HOME.IxUPD_YMD)
					{ 
						ArrayItem[j] = "[ " + comfunc.ConvertDate2Type(dt.Rows[i].ItemArray[j].ToString()) + " ]";
					}
					else if(j == (int)ClassLib.TBSPS_NOTICE_INGWORK_HOME.IxJOB_CD)
					{
						ArrayItem[j] = Get_JobCD_Name(dt.Rows[i].ItemArray[j].ToString());
					}
					else
					{
						ArrayItem[j] = dt.Rows[i].ItemArray[j].ToString();
					}


				}
				fgrid_ingwork.AddItem(ArrayItem, fgrid_ingwork.Rows.Count, 1);
			}
		}





		private void Grid_Setting(C1.Win.C1FlexGrid.C1FlexGrid arg_fgrid)
		{
			arg_fgrid.Cols[0].Visible = false;

			arg_fgrid.ScrollBars = ScrollBars.None;
			arg_fgrid.Styles.Alternate.BackColor = Color.White;
			arg_fgrid.Rows[0].Height = 0;
			arg_fgrid.Rows[1].Height = 0;

			
			arg_fgrid.Styles.Normal.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Horizontal;
			arg_fgrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			arg_fgrid.Styles.EmptyArea.Border.Width = 0;

			arg_fgrid.ExtendLastCol =true;
		}

		#endregion

		#region 이벤트 처리

		private void Form_Home_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}


		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void fgrid_home_DoubleClick_1(object sender, System.EventArgs e)
		{
			int rownum = fgrid_home.Selection.r1;
			
			if(rownum < _RowFixed) return;

			string arg_factory = fgrid_home[rownum, (int)ClassLib.TBSPS_NOTICE_HOME.IxFACTORY + 1].ToString();
			string arg_seq     = fgrid_home[rownum, (int)ClassLib.TBSPS_NOTICE_HOME.IxSEQ + 1].ToString();

			SysBase.Pop_PS_NoticeView psNoticeView = new SysBase.Pop_PS_NoticeView(this, arg_factory, arg_seq);
			psNoticeView.MdiParent = ClassLib.ComVar.arg_form;
			ClassLib.ComVar.MenuClick_Flag = true;
			psNoticeView.Show();

		}

		private void label1_Click(object sender, System.EventArgs e)
		{
			SysBase.Pop_PS_NoticeAdmin ad = new ERP.SysBase.Pop_PS_NoticeAdmin(this);
			ad.MdiParent =ClassLib.ComVar.arg_form;
			ClassLib.ComVar.MenuClick_Flag = true;
			ad.Show();
		}
		private void fgrid_message_DoubleClick(object sender, System.EventArgs e)
		{
			int rownum = fgrid_message.Selection.r1;

			string arg_factory =  fgrid_message[rownum,1].ToString();
			string arg_div = fgrid_message[rownum, 2].ToString();
			string arg_seq = fgrid_message[rownum, 3].ToString();

			SysBase.Pop_PS_NoticeUser_Receiver receiver = new ERP.SysBase.Pop_PS_NoticeUser_Receiver(this, arg_factory, arg_div, arg_seq);
			receiver.MdiParent =ClassLib.ComVar.arg_form;
			ClassLib.ComVar.MenuClick_Flag = true;
			receiver.Show();
		}

		private void label2_Click(object sender, System.EventArgs e)
		{


			SysBase.Pop_PS_Auto_Info psautoinfo = new ERP.SysBase.Pop_PS_Auto_Info(this); 
			psautoinfo.MdiParent = ClassLib.ComVar.arg_form;
			ClassLib.ComVar.MenuClick_Flag = true;
			psautoinfo.Show();





		}

		private void label5_Click(object sender, System.EventArgs e)
		{
			SysBase.Pop_PS_NoticeUser_Sender ad = new ERP.SysBase.Pop_PS_NoticeUser_Sender();
			ad.MdiParent = ClassLib.ComVar.arg_form;
			ClassLib.ComVar.MenuClick_Flag = true;
			ad.Show();

		}

		private void fgrid_automess_DoubleClick(object sender, System.EventArgs e)
		{
			//			int rownum = fgrid_automess.Selection.r1;
			//
			//			if(rownum < _RowFixed) return;
			//
			//			string arg_factory =  fgrid_automess[rownum,1].ToString();
			//			string arg_div = fgrid_automess[rownum, 2].ToString();
			//			string arg_seq = fgrid_automess[rownum, 3].ToString();
			//
			//			SysBase.Pop_PS_NoticeUser_Receiver receiver = new ERP.SysBase.Pop_PS_NoticeUser_Receiver(this, arg_factory, arg_div, arg_seq);
			//			receiver.MdiParent = ClassLib.ComVar.arg_form;
			//			ClassLib.ComVar.MenuClick_Flag = true;
			//			receiver.Show();
		}

		private void label10_Click(object sender, System.EventArgs e)
		{
			//			SysBase.Pop_PS_NoticeAuto_User autoUser = new ERP.SysBase.Pop_PS_NoticeAuto_User(this);
			//			autoUser.MdiParent = ClassLib.ComVar.arg_form;
			//			ClassLib.ComVar.MenuClick_Flag = true;
			//			autoUser.Show();


			SysBase.Pop_PS_Work_Info_User user = new ERP.SysBase.Pop_PS_Work_Info_User(this);
			user.ShowDialog();
		}

		private void label13_Click(object sender, System.EventArgs e)
		{
			SysBase.Pop_PS_NoticeING_List list = new ERP.SysBase.Pop_PS_NoticeING_List(this);

			list.MdiParent = ClassLib.ComVar.arg_form;
			ClassLib.ComVar.MenuClick_Flag = true;
			list.Show();

		}

		private void fgrid_ingwork_DoubleClick(object sender, System.EventArgs e)
		{
			int rownum = fgrid_ingwork.Selection.r1;

			if(rownum < _RowFixed) return;

			string arg_factory = fgrid_ingwork[rownum, 1].ToString();
			string arg_seq     = fgrid_ingwork[rownum, 2].ToString();

			SysBase.Pop_PS_NoticeING_View view = new ERP.SysBase.Pop_PS_NoticeING_View(arg_factory, arg_seq);
			
			view.MdiParent = ClassLib.ComVar.arg_form;
			ClassLib.ComVar.MenuClick_Flag = true;
			view.Show();
		}


		private void lbltodate_content_DoubleClick(object sender, System.EventArgs e)
		{
			//			SysBase.Pop_PS_Schedule_View view =new ERP.SysBase.Pop_PS_Schedule_View(schedule.NowDate());
			//			view.Show();
		}

		private void lbltomow_content_DoubleClick(object sender, System.EventArgs e)
		{
			//			SysBase.Pop_PS_Schedule_View view =new ERP.SysBase.Pop_PS_Schedule_View(schedule.NowDate(1));
			//			view.Show();
		}
		
		private void label16_DoubleClick(object sender, System.EventArgs e)
		{
			//			//SysBase.Form_PS_Schedule_List list = new ERP.SysBase.Form_PS_Schedule_List();
			//			SysBase.Pop_PS_Schedule_List list = new ERP.SysBase.Pop_PS_Schedule_List();
			//			list.MdiParent = ClassLib.ComVar.arg_form;
			//			ClassLib.ComVar.MenuClick_Flag = true;
			//			list.Show();
		}


		/// <summary>
		/// 업무 콤보리스트를 변경시 발생
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmb_dpt_SelectedValueChanged(object sender, System.EventArgs e)
		{
			label7.Text ="        Notice [" + cmb_dpt.Splits[0].DisplayColumns["Name"].DataColumn.Value.ToString() + "]";

			Get_ing();

			ClassLib.ComVar.This_JobCdoe = cmb_dpt.SelectedValue.ToString();

			LogBase.ClassLog.Select_Depart();
			
			lbl_name.Text += cmb_dpt.Columns[1].Text;

			
		}


		private void lbl_main_pic_DoubleClick(object sender, System.EventArgs e)
		{
			Close();
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_message.Selection.r1;

			if(sct_row < _RowFixed) return;
			

			string seq = fgrid_message[sct_row, 2].ToString();

			Delete_SPS_Auto_Info(seq);
			Get_Auto_Info();
		}






		private void Form_Home_Closed(object sender, System.EventArgs e)
		{
			try
			{
				string menu_pg = this.GetType().ToString(); 
				COM.ComFunction.Delete_Window_Menu(this.ParentForm, menu_pg);
			}
			catch(Exception ex)
			{
				COM.ComFunction.User_Message(ex.Message, "Form Closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		#endregion

		#region DB 연결

		/// <summary>
		/// Select_SPS_Notice : 공지사항 리스트 가져오기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>정상:DATETABLE 오류:NULL</returns>
		private DataTable Select_SPS_Notice()
		{

			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_HOME";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		/// <summary>
		/// Select_SPS_Notice_UserHome : 개인 업무 메시지 가져오기
		/// </summary>
		/// <returns>정상:DataTable  오류:null</returns>
		private DataTable Select_SPS_Notice_UserHome(string arg_div)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICEHOME";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_DIV";
			oraDB.Parameter_Name[2] = "ARG_RUSER_ID";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_div;
			oraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		/// <summary>
		/// Select_SPS_Notice_IngWork : 진행중인 업무 가져오기
		/// </summary>
		/// <returns>정상:DATETABLE 오류:NULL</returns>
		private DataTable Select_SPS_Notice_IngWork(string arg_jobcd)
		{

			string Proc_Name = "PKG_SPS_HOME.SELECT_NOTICE_INGWORK_HOME";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_JOB_CD";
			oraDB.Parameter_Name[2] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_jobcd;			
			oraDB.Parameter_Values[2] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Get_JobCD_Name : 업무 코드로 업무 이름 가져오기
		/// </summary>
		/// <param name="arg_com_value1">업무코드</param>
		/// <returns>정상:업무이름 , 오류:null</returns>
		private string Get_JobCD_Name(string arg_com_value1)
		{
			string Proc_Name = "PKG_SPS_HOME.GET_JOBCD_NAME";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_COM_CD";
			oraDB.Parameter_Name[2] = "ARG_COM_VALUE1";
			oraDB.Parameter_Name[3] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = "CM01";
			oraDB.Parameter_Values[2] = arg_com_value1;
			oraDB.Parameter_Values[3] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[3].ToString();
		}



		private DataTable Show_JobCD_CD()
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_JOB_CD";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}



		/// <summary>
		/// Select_SPS_Auto_Info : 자동 업무 메시지 가져오기
		/// </summary>
		/// <returns>정상:DataTable  오류:null</returns>
		private DataTable Select_SPS_Auto_Info(int arg_max_display_row)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_AUTO_INFO_1";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_ROWNUM";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_max_display_row.ToString();
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Delete_SPS_Auto_Info : 자동 업무 메시지 지우기
		/// </summary>
		private void Delete_SPS_Auto_Info(string arg_seq)
		{
			string Proc_Name = "PKG_SPS_HOME.DELETE_AUTO_INFO";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_SEQ";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_seq;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}

		private DataTable Select_SPS_Notice_IngWork11(string arg_division)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_WORKINFO_USER";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_USER_ID";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_division;
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			return  DS_Ret.Tables[Proc_Name];
		}

		#endregion

		


		 
	}
}
