using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;

namespace FlexCDC.CDC_Bom
{
	public class Form_Bom_List : COM.CDCWinForm.Pop_Large_B//COM.PCHWinForm.Pop_Large_B
	{
		#region 사용자 정의 변수 
		private COM.OraDB OraDB = new COM.OraDB();
		private int _RowFixed;
		private string _form_type = null;

		#endregion  

		#region  컨트롤정의 및 리소스 정의  
		public System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_sampletype;
        private System.Windows.Forms.Label lbl_sampletype;
		private C1.Win.C1List.C1Combo cmb_category;
		private System.Windows.Forms.Label lbl_category;
		private C1.Win.C1List.C1Combo cmb_status;
		private System.Windows.Forms.Label txt_status;
		private System.Windows.Forms.Label txt_sr_no01;
		private System.Windows.Forms.TextBox txt_sr_no;
		private C1.Win.C1List.C1Combo cmb_season;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.TextBox txt_bomid;
		private System.Windows.Forms.Label lbl_bomid;
		private System.Windows.Forms.TextBox txt_srfno;
		private System.Windows.Forms.Label lbl_sefno;
		private System.Windows.Forms.Label lbl_season;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		public System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		public System.Windows.Forms.PictureBox pictureBox17;
		private COM.FSP fgrid_model;
		private COM.FSP fgrid_part;
		private System.Windows.Forms.TextBox txt_stylename;
		private System.Windows.Forms.Label lbl_stylelname;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label btn_crt_xml;
		private System.Windows.Forms.ContextMenu cMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private string Group_Dir = null;
		private int _TailRowFixed;

		private string req_reason = null;
		private System.Windows.Forms.MenuItem cmt_Bom_Copy;
		private System.Windows.Forms.MenuItem menuItem3;
        private CheckBox chk_except_mrp;
        private TextBox txt_style_cd;
        private Label lbl_style_cd;
        private DateTimePicker dtp_to;
        private Label label1;
        private DateTimePicker dtp_from;
        private Label lbl_Uploaddate;

		private Purchase.Form_Pur_request_master requestMaster = null;

		public Form_Bom_List()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


		public Form_Bom_List(Purchase.Form_Pur_request_master arg_form, string arg_req_reason)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			requestMaster = arg_form;
			req_reason = arg_req_reason;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bom_List));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_sampletype = new C1.Win.C1List.C1Combo();
            this.lbl_sampletype = new System.Windows.Forms.Label();
            this.cmb_category = new C1.Win.C1List.C1Combo();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txt_sr_no01 = new System.Windows.Forms.Label();
            this.cmb_season = new C1.Win.C1List.C1Combo();
            this.txt_bomid = new System.Windows.Forms.TextBox();
            this.lbl_bomid = new System.Windows.Forms.Label();
            this.txt_srfno = new System.Windows.Forms.TextBox();
            this.lbl_sefno = new System.Windows.Forms.Label();
            this.txt_stylename = new System.Windows.Forms.TextBox();
            this.lbl_stylelname = new System.Windows.Forms.Label();
            this.lbl_season = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_Uploaddate = new System.Windows.Forms.Label();
            this.btn_crt_xml = new System.Windows.Forms.Label();
            this.txt_sr_no = new System.Windows.Forms.TextBox();
            this.txt_style_cd = new System.Windows.Forms.TextBox();
            this.lbl_style_cd = new System.Windows.Forms.Label();
            this.chk_except_mrp = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.cmb_status = new C1.Win.C1List.C1Combo();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.Label();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.fgrid_model = new COM.FSP();
            this.cMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.cmt_Bom_Copy = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.fgrid_part = new COM.FSP();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_part)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(713, 4);
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
            this.c1CommandHolder1.Commands.Add(this.tbtn_Conform);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(936, 23);
            // 
            // tbtn_Create
            // 
            this.tbtn_Create.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Create_Click);
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
            // tbtn_Conform
            // 
            this.tbtn_Conform.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Conform_Click);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cmb_sampletype);
            this.panel1.Controls.Add(this.lbl_sampletype);
            this.panel1.Controls.Add(this.cmb_category);
            this.panel1.Controls.Add(this.lbl_category);
            this.panel1.Controls.Add(this.txt_sr_no01);
            this.panel1.Controls.Add(this.cmb_season);
            this.panel1.Controls.Add(this.txt_bomid);
            this.panel1.Controls.Add(this.lbl_bomid);
            this.panel1.Controls.Add(this.txt_srfno);
            this.panel1.Controls.Add(this.lbl_sefno);
            this.panel1.Controls.Add(this.txt_stylename);
            this.panel1.Controls.Add(this.lbl_stylelname);
            this.panel1.Controls.Add(this.lbl_season);
            this.panel1.Controls.Add(this.cmb_factory);
            this.panel1.Controls.Add(this.lbl_factory);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.panel1.Location = new System.Drawing.Point(8, 80);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.panel1.Size = new System.Drawing.Size(986, 157);
            this.panel1.TabIndex = 130;
            // 
            // cmb_sampletype
            // 
            this.cmb_sampletype.AddItemSeparator = ';';
            this.cmb_sampletype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sampletype.Caption = "";
            this.cmb_sampletype.CaptionHeight = 17;
            this.cmb_sampletype.CaptionStyle = style97;
            this.cmb_sampletype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_sampletype.ColumnCaptionHeight = 18;
            this.cmb_sampletype.ColumnFooterHeight = 18;
            this.cmb_sampletype.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_sampletype.ContentHeight = 17;
            this.cmb_sampletype.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_sampletype.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_sampletype.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampletype.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sampletype.EditorHeight = 17;
            this.cmb_sampletype.EvenRowStyle = style98;
            this.cmb_sampletype.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampletype.FooterStyle = style99;
            this.cmb_sampletype.HeadingStyle = style100;
            this.cmb_sampletype.HighLightRowStyle = style101;
            this.cmb_sampletype.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_sampletype.Images"))));
            this.cmb_sampletype.ItemHeight = 15;
            this.cmb_sampletype.Location = new System.Drawing.Point(117, 59);
            this.cmb_sampletype.MatchEntryTimeout = ((long)(2000));
            this.cmb_sampletype.MaxDropDownItems = ((short)(5));
            this.cmb_sampletype.MaxLength = 32767;
            this.cmb_sampletype.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sampletype.Name = "cmb_sampletype";
            this.cmb_sampletype.OddRowStyle = style102;
            this.cmb_sampletype.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sampletype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sampletype.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sampletype.SelectedStyle = style103;
            this.cmb_sampletype.Size = new System.Drawing.Size(120, 21);
            this.cmb_sampletype.Style = style104;
            this.cmb_sampletype.TabIndex = 353;
            this.cmb_sampletype.PropBag = resources.GetString("cmb_sampletype.PropBag");
            // 
            // lbl_sampletype
            // 
            this.lbl_sampletype.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sampletype.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sampletype.ImageIndex = 0;
            this.lbl_sampletype.ImageList = this.img_Label;
            this.lbl_sampletype.Location = new System.Drawing.Point(16, 59);
            this.lbl_sampletype.Name = "lbl_sampletype";
            this.lbl_sampletype.Size = new System.Drawing.Size(100, 21);
            this.lbl_sampletype.TabIndex = 352;
            this.lbl_sampletype.Tag = "1";
            this.lbl_sampletype.Text = "Sample Types";
            this.lbl_sampletype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_category
            // 
            this.cmb_category.AddItemSeparator = ';';
            this.cmb_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_category.Caption = "";
            this.cmb_category.CaptionHeight = 17;
            this.cmb_category.CaptionStyle = style105;
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
            this.cmb_category.EvenRowStyle = style106;
            this.cmb_category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.FooterStyle = style107;
            this.cmb_category.HeadingStyle = style108;
            this.cmb_category.HighLightRowStyle = style109;
            this.cmb_category.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_category.Images"))));
            this.cmb_category.ItemHeight = 15;
            this.cmb_category.Location = new System.Drawing.Point(376, 59);
            this.cmb_category.MatchEntryTimeout = ((long)(2000));
            this.cmb_category.MaxDropDownItems = ((short)(5));
            this.cmb_category.MaxLength = 32767;
            this.cmb_category.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.OddRowStyle = style110;
            this.cmb_category.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_category.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_category.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_category.SelectedStyle = style111;
            this.cmb_category.Size = new System.Drawing.Size(120, 21);
            this.cmb_category.Style = style112;
            this.cmb_category.TabIndex = 349;
            this.cmb_category.PropBag = resources.GetString("cmb_category.PropBag");
            // 
            // lbl_category
            // 
            this.lbl_category.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ImageIndex = 0;
            this.lbl_category.ImageList = this.img_Label;
            this.lbl_category.Location = new System.Drawing.Point(270, 59);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(105, 21);
            this.lbl_category.TabIndex = 348;
            this.lbl_category.Tag = "1";
            this.lbl_category.Text = "   Category";
            this.lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sr_no01
            // 
            this.txt_sr_no01.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sr_no01.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sr_no01.ImageIndex = 0;
            this.txt_sr_no01.ImageList = this.img_Label;
            this.txt_sr_no01.Location = new System.Drawing.Point(274, 36);
            this.txt_sr_no01.Name = "txt_sr_no01";
            this.txt_sr_no01.Size = new System.Drawing.Size(98, 21);
            this.txt_sr_no01.TabIndex = 345;
            this.txt_sr_no01.Tag = "1";
            this.txt_sr_no01.Text = "  SR No";
            this.txt_sr_no01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_season
            // 
            this.cmb_season.AddItemSeparator = ';';
            this.cmb_season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_season.Caption = "";
            this.cmb_season.CaptionHeight = 17;
            this.cmb_season.CaptionStyle = style113;
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
            this.cmb_season.EvenRowStyle = style114;
            this.cmb_season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season.FooterStyle = style115;
            this.cmb_season.HeadingStyle = style116;
            this.cmb_season.HighLightRowStyle = style117;
            this.cmb_season.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_season.Images"))));
            this.cmb_season.ItemHeight = 15;
            this.cmb_season.Location = new System.Drawing.Point(605, 59);
            this.cmb_season.MatchEntryTimeout = ((long)(2000));
            this.cmb_season.MaxDropDownItems = ((short)(5));
            this.cmb_season.MaxLength = 32767;
            this.cmb_season.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_season.Name = "cmb_season";
            this.cmb_season.OddRowStyle = style118;
            this.cmb_season.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_season.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_season.SelectedStyle = style119;
            this.cmb_season.Size = new System.Drawing.Size(120, 21);
            this.cmb_season.Style = style120;
            this.cmb_season.TabIndex = 343;
            this.cmb_season.PropBag = resources.GetString("cmb_season.PropBag");
            // 
            // txt_bomid
            // 
            this.txt_bomid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_bomid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bomid.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_bomid.ForeColor = System.Drawing.Color.Black;
            this.txt_bomid.Location = new System.Drawing.Point(853, 36);
            this.txt_bomid.MaxLength = 100;
            this.txt_bomid.Name = "txt_bomid";
            this.txt_bomid.Size = new System.Drawing.Size(120, 20);
            this.txt_bomid.TabIndex = 339;
            // 
            // lbl_bomid
            // 
            this.lbl_bomid.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_bomid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bomid.ImageIndex = 0;
            this.lbl_bomid.ImageList = this.img_Label;
            this.lbl_bomid.Location = new System.Drawing.Point(752, 36);
            this.lbl_bomid.Name = "lbl_bomid";
            this.lbl_bomid.Size = new System.Drawing.Size(100, 21);
            this.lbl_bomid.TabIndex = 338;
            this.lbl_bomid.Tag = "1";
            this.lbl_bomid.Text = "BOM ID";
            this.lbl_bomid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_srfno
            // 
            this.txt_srfno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_srfno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_srfno.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_srfno.ForeColor = System.Drawing.Color.Black;
            this.txt_srfno.Location = new System.Drawing.Point(605, 36);
            this.txt_srfno.MaxLength = 100;
            this.txt_srfno.Name = "txt_srfno";
            this.txt_srfno.Size = new System.Drawing.Size(120, 20);
            this.txt_srfno.TabIndex = 337;
            // 
            // lbl_sefno
            // 
            this.lbl_sefno.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sefno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sefno.ImageIndex = 0;
            this.lbl_sefno.ImageList = this.img_Label;
            this.lbl_sefno.Location = new System.Drawing.Point(504, 36);
            this.lbl_sefno.Name = "lbl_sefno";
            this.lbl_sefno.Size = new System.Drawing.Size(100, 21);
            this.lbl_sefno.TabIndex = 336;
            this.lbl_sefno.Tag = "1";
            this.lbl_sefno.Text = "Proj. Alias";
            this.lbl_sefno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_stylename
            // 
            this.txt_stylename.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_stylename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stylename.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_stylename.ForeColor = System.Drawing.Color.Black;
            this.txt_stylename.Location = new System.Drawing.Point(853, 59);
            this.txt_stylename.MaxLength = 100;
            this.txt_stylename.Name = "txt_stylename";
            this.txt_stylename.Size = new System.Drawing.Size(120, 20);
            this.txt_stylename.TabIndex = 334;
            // 
            // lbl_stylelname
            // 
            this.lbl_stylelname.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_stylelname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stylelname.ImageIndex = 0;
            this.lbl_stylelname.ImageList = this.img_Label;
            this.lbl_stylelname.Location = new System.Drawing.Point(752, 59);
            this.lbl_stylelname.Name = "lbl_stylelname";
            this.lbl_stylelname.Size = new System.Drawing.Size(100, 21);
            this.lbl_stylelname.TabIndex = 333;
            this.lbl_stylelname.Tag = "1";
            this.lbl_stylelname.Text = "Style Name";
            this.lbl_stylelname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_season
            // 
            this.lbl_season.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_season.ImageIndex = 0;
            this.lbl_season.ImageList = this.img_Label;
            this.lbl_season.Location = new System.Drawing.Point(504, 59);
            this.lbl_season.Name = "lbl_season";
            this.lbl_season.Size = new System.Drawing.Size(100, 21);
            this.lbl_season.TabIndex = 332;
            this.lbl_season.Tag = "1";
            this.lbl_season.Text = "Season";
            this.lbl_season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style121;
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
            this.cmb_factory.EvenRowStyle = style122;
            this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style123;
            this.cmb_factory.HeadingStyle = style124;
            this.cmb_factory.HighLightRowStyle = style125;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(117, 36);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style126;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style127;
            this.cmb_factory.Size = new System.Drawing.Size(120, 21);
            this.cmb_factory.Style = style128;
            this.cmb_factory.TabIndex = 331;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 36);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 330;
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
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(376, 304);
            this.textBox5.MaxLength = 100;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 21);
            this.textBox5.TabIndex = 264;
            this.textBox5.Tag = "60";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(200, 304);
            this.textBox6.MaxLength = 100;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 21);
            this.textBox6.TabIndex = 263;
            this.textBox6.Tag = "60";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(24, 304);
            this.textBox7.MaxLength = 100;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 21);
            this.textBox7.TabIndex = 262;
            this.textBox7.Tag = "60";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.dtp_to);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtp_from);
            this.panel2.Controls.Add(this.lbl_Uploaddate);
            this.panel2.Controls.Add(this.btn_crt_xml);
            this.panel2.Controls.Add(this.txt_sr_no);
            this.panel2.Controls.Add(this.txt_style_cd);
            this.panel2.Controls.Add(this.lbl_style_cd);
            this.panel2.Controls.Add(this.chk_except_mrp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.cmb_status);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_status);
            this.panel2.Controls.Add(this.cmb_user);
            this.panel2.Controls.Add(this.lbl_user);
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Controls.Add(this.pictureBox14);
            this.panel2.Controls.Add(this.pictureBox15);
            this.panel2.Controls.Add(this.pictureBox16);
            this.panel2.Controls.Add(this.pictureBox17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 149);
            this.panel2.TabIndex = 18;
            // 
            // dtp_to
            // 
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(257, 104);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(112, 21);
            this.dtp_to.TabIndex = 360;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 359;
            this.label1.Text = "~";
            // 
            // dtp_from
            // 
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(109, 104);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(120, 21);
            this.dtp_from.TabIndex = 358;
            // 
            // lbl_Uploaddate
            // 
            this.lbl_Uploaddate.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Uploaddate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uploaddate.ImageIndex = 0;
            this.lbl_Uploaddate.ImageList = this.img_Label;
            this.lbl_Uploaddate.Location = new System.Drawing.Point(8, 103);
            this.lbl_Uploaddate.Name = "lbl_Uploaddate";
            this.lbl_Uploaddate.Size = new System.Drawing.Size(100, 21);
            this.lbl_Uploaddate.TabIndex = 357;
            this.lbl_Uploaddate.Tag = "1";
            this.lbl_Uploaddate.Text = "Upload Date";
            this.lbl_Uploaddate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_crt_xml
            // 
            this.btn_crt_xml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_crt_xml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_crt_xml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_crt_xml.ImageIndex = 0;
            this.btn_crt_xml.ImageList = this.img_Button;
            this.btn_crt_xml.Location = new System.Drawing.Point(847, 83);
            this.btn_crt_xml.Name = "btn_crt_xml";
            this.btn_crt_xml.Size = new System.Drawing.Size(80, 23);
            this.btn_crt_xml.TabIndex = 354;
            this.btn_crt_xml.Text = "Create XML";
            this.btn_crt_xml.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_crt_xml.Click += new System.EventHandler(this.tbtn_Create_Click);
            // 
            // txt_sr_no
            // 
            this.txt_sr_no.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_sr_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sr_no.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_sr_no.ForeColor = System.Drawing.Color.Black;
            this.txt_sr_no.Location = new System.Drawing.Point(368, 37);
            this.txt_sr_no.MaxLength = 100;
            this.txt_sr_no.Name = "txt_sr_no";
            this.txt_sr_no.Size = new System.Drawing.Size(120, 20);
            this.txt_sr_no.TabIndex = 344;
            // 
            // txt_style_cd
            // 
            this.txt_style_cd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_style_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_style_cd.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_style_cd.ForeColor = System.Drawing.Color.Black;
            this.txt_style_cd.Location = new System.Drawing.Point(109, 82);
            this.txt_style_cd.MaxLength = 100;
            this.txt_style_cd.Name = "txt_style_cd";
            this.txt_style_cd.Size = new System.Drawing.Size(120, 20);
            this.txt_style_cd.TabIndex = 356;
            // 
            // lbl_style_cd
            // 
            this.lbl_style_cd.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_style_cd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style_cd.ImageIndex = 0;
            this.lbl_style_cd.ImageList = this.img_Label;
            this.lbl_style_cd.Location = new System.Drawing.Point(8, 82);
            this.lbl_style_cd.Name = "lbl_style_cd";
            this.lbl_style_cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_style_cd.TabIndex = 355;
            this.lbl_style_cd.Tag = "1";
            this.lbl_style_cd.Text = "Style Code";
            this.lbl_style_cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_except_mrp
            // 
            this.chk_except_mrp.AutoSize = true;
            this.chk_except_mrp.Location = new System.Drawing.Point(747, 86);
            this.chk_except_mrp.Name = "chk_except_mrp";
            this.chk_except_mrp.Size = new System.Drawing.Size(94, 19);
            this.chk_except_mrp.TabIndex = 113;
            this.chk_except_mrp.Text = "Except MRP";
            this.chk_except_mrp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 21);
            this.label2.TabIndex = 112;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(953, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 106);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(954, 0);
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
            this.pictureBox11.Size = new System.Drawing.Size(970, 40);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // cmb_status
            // 
            this.cmb_status.AddItemSeparator = ';';
            this.cmb_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_status.Caption = "";
            this.cmb_status.CaptionHeight = 17;
            this.cmb_status.CaptionStyle = style129;
            this.cmb_status.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_status.ColumnCaptionHeight = 18;
            this.cmb_status.ColumnFooterHeight = 18;
            this.cmb_status.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_status.ContentHeight = 17;
            this.cmb_status.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_status.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_status.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_status.EditorHeight = 17;
            this.cmb_status.EvenRowStyle = style130;
            this.cmb_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FooterStyle = style131;
            this.cmb_status.HeadingStyle = style132;
            this.cmb_status.HighLightRowStyle = style133;
            this.cmb_status.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_status.Images"))));
            this.cmb_status.ItemHeight = 15;
            this.cmb_status.Location = new System.Drawing.Point(597, 82);
            this.cmb_status.MatchEntryTimeout = ((long)(2000));
            this.cmb_status.MaxDropDownItems = ((short)(5));
            this.cmb_status.MaxLength = 32767;
            this.cmb_status.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.OddRowStyle = style134;
            this.cmb_status.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_status.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_status.SelectedStyle = style135;
            this.cmb_status.Size = new System.Drawing.Size(120, 21);
            this.cmb_status.Style = style136;
            this.cmb_status.TabIndex = 347;
            this.cmb_status.PropBag = resources.GetString("cmb_status.PropBag");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "      Project Information";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.SystemColors.Window;
            this.txt_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.ImageIndex = 0;
            this.txt_status.ImageList = this.img_Label;
            this.txt_status.Location = new System.Drawing.Point(496, 82);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(100, 21);
            this.txt_status.TabIndex = 346;
            this.txt_status.Tag = "1";
            this.txt_status.Text = "Status";
            this.txt_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_user
            // 
            this.cmb_user.AddItemSeparator = ';';
            this.cmb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_user.Caption = "";
            this.cmb_user.CaptionHeight = 17;
            this.cmb_user.CaptionStyle = style137;
            this.cmb_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_user.ColumnCaptionHeight = 18;
            this.cmb_user.ColumnFooterHeight = 18;
            this.cmb_user.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_user.ContentHeight = 17;
            this.cmb_user.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_user.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_user.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_user.EditorHeight = 17;
            this.cmb_user.EvenRowStyle = style138;
            this.cmb_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FooterStyle = style139;
            this.cmb_user.HeadingStyle = style140;
            this.cmb_user.HighLightRowStyle = style141;
            this.cmb_user.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_user.Images"))));
            this.cmb_user.ItemHeight = 15;
            this.cmb_user.Location = new System.Drawing.Point(368, 82);
            this.cmb_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_user.MaxDropDownItems = ((short)(5));
            this.cmb_user.MaxLength = 32767;
            this.cmb_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.OddRowStyle = style142;
            this.cmb_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_user.SelectedStyle = style143;
            this.cmb_user.Size = new System.Drawing.Size(120, 21);
            this.cmb_user.Style = style144;
            this.cmb_user.TabIndex = 341;
            this.cmb_user.PropBag = resources.GetString("cmb_user.PropBag");
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ImageIndex = 0;
            this.lbl_user.ImageList = this.img_Label;
            this.lbl_user.Location = new System.Drawing.Point(263, 82);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(105, 21);
            this.lbl_user.TabIndex = 340;
            this.lbl_user.Tag = "1";
            this.lbl_user.Text = "   Dev User";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(954, 134);
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
            this.pictureBox13.Location = new System.Drawing.Point(144, 133);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(970, 18);
            this.pictureBox13.TabIndex = 24;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(0, 134);
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
            this.pictureBox15.Size = new System.Drawing.Size(168, 116);
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
            this.pictureBox16.Size = new System.Drawing.Size(970, 109);
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
            this.pictureBox17.Size = new System.Drawing.Size(970, 109);
            this.pictureBox17.TabIndex = 27;
            this.pictureBox17.TabStop = false;
            // 
            // fgrid_model
            // 
            this.fgrid_model.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_model.AutoResize = false;
            this.fgrid_model.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_model.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_model.ContextMenu = this.cMenu;
            this.fgrid_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fgrid_model.Location = new System.Drawing.Point(15, 235);
            this.fgrid_model.Name = "fgrid_model";
            this.fgrid_model.Rows.DefaultSize = 18;
            this.fgrid_model.Rows.Fixed = 0;
            this.fgrid_model.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_model.Size = new System.Drawing.Size(969, 189);
            this.fgrid_model.StyleInfo = resources.GetString("fgrid_model.StyleInfo");
            this.fgrid_model.TabIndex = 131;
            this.fgrid_model.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_model_AfterEdit);
            this.fgrid_model.DoubleClick += new System.EventHandler(this.fgrid_model_DoubleClick);
            // 
            // cMenu
            // 
            this.cMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.cmt_Bom_Copy,
            this.menuItem3,
            this.menuItem1});
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Update Bom";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // cmt_Bom_Copy
            // 
            this.cmt_Bom_Copy.Index = 1;
            this.cmt_Bom_Copy.Text = "Copy Bom";
            this.cmt_Bom_Copy.Click += new System.EventHandler(this.cmt_Bom_Copy_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.Text = "Worksheet for Developer";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // fgrid_part
            // 
            this.fgrid_part.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_part.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgrid_part.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_part.AutoResize = false;
            this.fgrid_part.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_part.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_part.Location = new System.Drawing.Point(15, 432);
            this.fgrid_part.Name = "fgrid_part";
            this.fgrid_part.Rows.DefaultSize = 18;
            this.fgrid_part.Rows.Fixed = 0;
            this.fgrid_part.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_part.Size = new System.Drawing.Size(969, 208);
            this.fgrid_part.StyleInfo = resources.GetString("fgrid_part.StyleInfo");
            this.fgrid_part.TabIndex = 132;
            // 
            // Form_Bom_List
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(1000, 645);
            this.Controls.Add(this.fgrid_part);
            this.Controls.Add(this.fgrid_model);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Bom_List";
            this.Load += new System.EventHandler(this.Form_Bom_Selecter_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.fgrid_model, 0);
            this.Controls.SetChildIndex(this.fgrid_part, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_part)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Loading
        private void Form_Bom_Selecter_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (cmb_factory.SelectedIndex == -1) return;
            COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
            Init_Form();
        }

        private void Init_Form()
		{		
			this.Text = "PCC_Select Bom";
			this.lbl_MainTitle.Text = "PCC_Select Bom";
			ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting 
            DataTable dt_ret = SELECT_SDC_PJ_TAIL_SEASON();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1,true, COM.ComVar.ComboList_Visible.Name);
			cmb_season.SelectedIndex = 0;

			dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory.SelectedValue.ToString(),ClassLib.ComVar.CxCDC_Category );
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1,2, true, COM.ComVar.ComboList_Visible.Name);
			cmb_category.SelectedIndex  = 0;

			dt_ret = SELECT_SDC_NF_DESC();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletype, 0,2 , true, COM.ComVar.ComboList_Visible.Name);
			cmb_sampletype.SelectedIndex= 0;

			#region Upload  User설정
            dt_ret = SELECT_SDD_SRF_LOADUSER();

            //if(ClassLib.ComVar.This_Admin_YN.Equals("Y"))
            //{
				cmb_user.Enabled = true;
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
				cmb_user.SelectedIndex = 0;
            //}
            //else if (COM.ComVar.This_CDCPower_Level.Equals("E01") || COM.ComVar.This_CDCPower_Level.Substring(0, 1).Equals("C"))
            //{
            //    cmb_user.Enabled = true;
            //    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            //    cmb_user.SelectedIndex = 0; 
            //}
            //else
            //{
            //    cmb_user.Enabled = false;

            //    DataTable user_datatable = new DataTable("UserList");
            //    DataRow newrow;

            //    user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
            //    user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

            //    newrow = user_datatable.NewRow();
            //    newrow["Code"] = ClassLib.ComVar.This_User;
            //    newrow["Name"] = ClassLib.ComVar.This_User;

            //    user_datatable.Rows.Add(newrow);

            //    ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_user, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
            //    cmb_user.SelectedValue = "";
            //}

			#endregion  

			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(),"SXC20");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2,false, false);
			cmb_status.SelectedIndex = 0;
            #endregion

            #region Grid Setting 
            fgrid_model.Set_Grid_CDC("SXC_PJ_MAST", "4", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_model.Set_Action_Image(img_Action);
			fgrid_model.ExtendLastCol = false;
			_RowFixed = fgrid_model.Rows.Fixed;
            #endregion

            #region Form Type Setting
            if (requestMaster != null/*|| _form_type == "yield"*/)
			{
				fgrid_part.Set_Grid_CDC("SXD_SRF_TAIL", "4", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_part.Set_Action_Image(img_Action);
				fgrid_part.Font = new Font("Verdana", 8);
				_TailRowFixed = fgrid_part.Rows.Fixed;


				tbtn_Append.Enabled  = false;
				tbtn_Color.Enabled   = false;
				tbtn_Conform.Enabled = false;
				tbtn_Create.Enabled  = false;
				tbtn_Delete.Enabled  = false;
				tbtn_Insert.Enabled  = false;
				tbtn_New.Enabled     = false;
				tbtn_Print.Enabled   = true;
				tbtn_Save.Enabled    = true;
				tbtn_Search.Enabled  = true;


				fgrid_model.Height = 224;
				fgrid_part.Visible = true;

				fgrid_model.Anchor = (AnchorStyles.Right |AnchorStyles.Top | AnchorStyles.Left);
			}            
			else
			{
				tbtn_Append.Enabled  = false;
				tbtn_Color.Enabled   = false;
				tbtn_Conform.Enabled = false;
				tbtn_Create.Enabled  = false;
				tbtn_Delete.Enabled  = false;
				tbtn_Insert.Enabled  = false;
				tbtn_New.Enabled     = false;
				tbtn_Print.Enabled   = true;
				tbtn_Save.Enabled    = false;
				tbtn_Search.Enabled  = true;

				fgrid_part.Visible = false;
				fgrid_model.Height = 440;

				fgrid_model.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right |AnchorStyles.Top | AnchorStyles.Left);

			}

            if (bool.Parse((ClassLib.ComVar.This_Dept == "XML" || ClassLib.ComVar.This_Dept == "PMC") ? "true" : "false"))
            {
                btn_crt_xml.Enabled = true;
                fgrid_model.Cols[(int)ClassLib.TBSXC_PJ_MAST_SCTER.IxXML_CRT].Visible = true;
                fgrid_model.Cols[(int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSTYLE_CD].AllowEditing = true;
                tbtn_Save.Enabled = true;
            }
			
            #endregion

        }

        private DataTable SELECT_SDC_PJ_TAIL_SEASON()
        {
            string Proc_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
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
        private DataTable SELECT_SDC_NF_DESC()
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
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
        private DataTable SELECT_SDD_SRF_LOADUSER()
        {
            string Proc_Name = "PKG_SXD_SRF_01_SELECT.SELECT_SXD_SRF_LOADUSER";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
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
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                fgrid_model.Rows.Count = _RowFixed;
                DataTable dt = Select_sxc_pj_head_list();
                int dt_rows = dt.Rows.Count;
                int dt_cols = dt.Columns.Count;
                if (dt_rows > 0)
                {
                    for (int i = 0; i < dt_rows; i++)
                    {
                        fgrid_model.Rows.Add();
                        if (dt.Rows[i].ItemArray[(int)ClassLib.TBSXC_PJ_MAST_SCTER.IxDEP_FLG].ToString() == "D")
                        {
                            fgrid_model.Rows[fgrid_model.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(245, 173, 173);
                        }

                        for (int j = 0; j < dt_cols; j++)
                        {
                            fgrid_model[fgrid_model.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();
                        }
                    }
                }

                if (COM.ComVar.This_User.Equals("wansu.bae"))
                    fgrid_model.Sort(SortFlags.Descending, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxORD_YMD);
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


        #region 공통메쏘드

        private void create_xml(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
		{
       
            XmlDocument doc = new XmlDocument();

            string filr_path = Group_Dir + @"\" + arg_srf_no + "-" + arg_bom_id + ".xml";
            FileInfo file_info = new FileInfo(filr_path);

            if (file_info.Exists)
            {
                file_info.Delete();
                file_info.Create().Close();
            }
            else
            {
                file_info.Create().Close();
            }

            doc.Load(Application.StartupPath + @"\default.xml");
            doc.Save(filr_path);


            DataTable dt = Select_create_xml_head(arg_factory, arg_sr_no, arg_srf_no, arg_bom_id, arg_bom_rev, arg_nf_cd);

            int _Data_row = 0;

            int _col_nike_sy_sty_nbr = 0;
            int _col_nike_sy_colr_cd_id = 1;
            int _col_nike_xdm_dim_cd = 2;
            int _col_nike_srf_no = 3;
            int _col_nike_dev_code = 4;

            #region	XMl 만들기
            doc.Load(filr_path);

            XmlElement Pcc = doc.CreateElement("pcc");
            XmlElement Pcc_list = doc.DocumentElement;
            Pcc_list.AppendChild(Pcc);
            XmlText Pcc_text = doc.CreateTextNode("DS");
            Pcc.AppendChild(Pcc_text);

            XmlElement ProductCode = doc.CreateElement("ProductCode");
            XmlElement ProductCode_list = doc.DocumentElement;
            ProductCode_list.AppendChild(ProductCode);

            //nike_sy_sty_nbr
            XmlElement nike_sy_sty_nbr = doc.CreateElement("nike_sy_sty_nbr");
            ProductCode.AppendChild(nike_sy_sty_nbr);
            XmlText nike_sy_sty_nbr_text = doc.CreateTextNode(dt.Rows[_Data_row].ItemArray[_col_nike_sy_sty_nbr].ToString());
            nike_sy_sty_nbr.AppendChild(nike_sy_sty_nbr_text);


            //nike_sy_colr_cd_id
            XmlElement nike_sy_colr_cd_id = doc.CreateElement("nike_sy_colr_cd_id");
            ProductCode.AppendChild(nike_sy_colr_cd_id);
            XmlText nike_sy_colr_cd_id_text = doc.CreateTextNode(dt.Rows[_Data_row].ItemArray[_col_nike_sy_colr_cd_id].ToString());
            nike_sy_colr_cd_id.AppendChild(nike_sy_colr_cd_id_text);


            //nike_xdm_dim_cd
            XmlElement nike_xdm_dim_cd = doc.CreateElement("nike_xdm_dim_cd");
            ProductCode.AppendChild(nike_xdm_dim_cd);
            XmlText nike_xdm_dim_cd_text = doc.CreateTextNode(dt.Rows[_Data_row].ItemArray[_col_nike_xdm_dim_cd].ToString());
            nike_xdm_dim_cd.AppendChild(nike_xdm_dim_cd_text);


            //nike_bom_id
            XmlElement nike_srf_no = doc.CreateElement("nike_bom_id");
            ProductCode.AppendChild(nike_srf_no);
            XmlText nike_srf_no_text = doc.CreateTextNode(dt.Rows[_Data_row].ItemArray[_col_nike_srf_no].ToString());
            nike_srf_no.AppendChild(nike_srf_no_text);


            //nike_model_offerings_id
            XmlElement nike_dev_code = doc.CreateElement("nike_model_offering_id");
            ProductCode.AppendChild(nike_dev_code);
            XmlText nike_dev_code_text = doc.CreateTextNode(dt.Rows[_Data_row].ItemArray[_col_nike_dev_code].ToString());
            nike_dev_code.AppendChild(nike_dev_code_text);

            dt = Select_create_xml_tail(arg_factory, arg_sr_no, arg_srf_no, arg_bom_id, arg_bom_rev, arg_nf_cd);

            int dt_row = dt.Rows.Count;
            int dt_col = dt.Columns.Count;

            int _col_nike_material_id = 0;
            int _col_nike_material_by_supplier = 1;
            int _col_nike_color_cd = 2;
            int _col_pcc_seq_no = 3;
            int _col_pcc_part_name = 4;
            int _col_pcc_yield = 5;
            int _col_pcc_loss_percent = 6;
            int _col_pcc_usage = 7;
            int _col_pcc_length = 8;
            int _pcc_lengthUOM = 9;
            int _pcc_width = 10;
            int _col_pcc_widthUOM = 11;
            int _col_pcc_qtyUOM = 12;

            for (int i = 0; i < dt_row; i++)
            {

                //MaterialByColor
                XmlElement MaterialByColor = doc.CreateElement("MaterialByColor");
                ProductCode.AppendChild(MaterialByColor);

                //nike_material_id
                XmlElement nike_material_id = doc.CreateElement("nike_material_id");
                MaterialByColor.AppendChild(nike_material_id);
                XmlText nike_material_id_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_nike_material_id].ToString());
                nike_material_id.AppendChild(nike_material_id_text);


                //nike_material_by_supplier
                XmlElement nike_material_by_supplier = doc.CreateElement("nike_material_by_supplier");
                MaterialByColor.AppendChild(nike_material_by_supplier);
                XmlText nike_material_by_supplier_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_nike_material_by_supplier].ToString());
                nike_material_by_supplier.AppendChild(nike_material_by_supplier_text);



                //nike_color_cd
                XmlElement nike_color_cd = doc.CreateElement("nike_color_cd");
                MaterialByColor.AppendChild(nike_color_cd);
                XmlText nike_color_cd_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_nike_color_cd].ToString());
                nike_color_cd.AppendChild(nike_color_cd_text);






                XmlElement Part = doc.CreateElement("Part");
                MaterialByColor.AppendChild(Part);




                XmlElement pcc_seq_no = doc.CreateElement("pcc_seq_no");
                Part.AppendChild(pcc_seq_no);
                XmlText pcc_seq_no_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_seq_no].ToString());
                pcc_seq_no.AppendChild(pcc_seq_no_text);


                XmlElement pcc_part_name = doc.CreateElement("pcc_part_name");
                Part.AppendChild(pcc_part_name);
                XmlText pcc_part_name_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_part_name].ToString());
                pcc_part_name.AppendChild(pcc_part_name_text);


                XmlElement pcc_yield = doc.CreateElement("pcc_yield");
                Part.AppendChild(pcc_yield);
                XmlText pcc_yield_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_yield].ToString());
                pcc_yield.AppendChild(pcc_yield_text);


                XmlElement pcc_loss_percent = doc.CreateElement("pcc_loss_percent");
                Part.AppendChild(pcc_loss_percent);
                XmlText pcc_loss_percent_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_loss_percent].ToString());
                pcc_loss_percent.AppendChild(pcc_loss_percent_text);


                XmlElement pcc_usage = doc.CreateElement("pcc_usage");
                Part.AppendChild(pcc_usage);
                XmlText pcc_usage_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_usage].ToString());
                pcc_usage.AppendChild(pcc_usage_text);


                XmlElement pcc_length = doc.CreateElement("pcc_length");
                Part.AppendChild(pcc_length);
                XmlText pcc_length_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_length].ToString());
                pcc_length.AppendChild(pcc_length_text);


                XmlElement pcc_lengthUOM = doc.CreateElement("pcc_lengthUOM");
                Part.AppendChild(pcc_lengthUOM);
                XmlText pcc_lengthUOM_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_pcc_lengthUOM].ToString());
                pcc_lengthUOM.AppendChild(pcc_lengthUOM_text);


                XmlElement pcc_width = doc.CreateElement("pcc_width");
                Part.AppendChild(pcc_width);
                XmlText pcc_width_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_pcc_width].ToString());
                pcc_width.AppendChild(pcc_width_text);


                XmlElement pcc_widthUOM = doc.CreateElement("pcc_widthUOM");
                Part.AppendChild(pcc_widthUOM);
                XmlText pcc_widthUOM_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_widthUOM].ToString());
                pcc_widthUOM.AppendChild(pcc_widthUOM_text);


                XmlElement pcc_qtyUOM = doc.CreateElement("pcc_qtyUOM");
                Part.AppendChild(pcc_qtyUOM);
                XmlText pcc_qtyUOM_text = doc.CreateTextNode(dt.Rows[i].ItemArray[_col_pcc_qtyUOM].ToString());
                pcc_qtyUOM.AppendChild(pcc_qtyUOM_text);
            }
            doc.Save(filr_path);



            Make_Srf_Nike_File(arg_factory, arg_sr_no, arg_srf_no, arg_bom_id, arg_bom_rev, arg_nf_cd);



            #endregion
    

            
		}
		#endregion 

		#region 이벤트처리 
		#region Button Event
        
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int sct_row = fgrid_model.Selection.r1;
                int sct_col = fgrid_model.Selection.c1;


                if (requestMaster != null)
                {
                    string _round = fgrid_model[fgrid_model.Selection.r1, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxNF_CD].ToString();
                    for (int i = _TailRowFixed; i < fgrid_part.Rows.Count - 1; i++)
                    {

                        if (fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxSTATUS_DESC].ToString().Equals("True"))
                        {
                            int inst_row = requestMaster.flg_request1.Rows.Count;
                            requestMaster.flg_request1.Add_Row(inst_row - 1);

                            #region Data --> Grid
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION] = "I";

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxFACTORY] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxFACTORY].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_DEPT] = COM.ComVar.This_Dept;
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_DEPT_DESC] = "";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_USER] = COM.ComVar.This_User;
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxUSE_DEPT] = "";

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxUSE_DEPT_DESC] = "";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_YMD] = "";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_NO] = "";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_SEQ] = "";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxPUR_FLG] = "false";

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxIN_FLG] = "false";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxCATEGORY] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxCATEGORY].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxSEASON_CD] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxSEASON_CD].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxSEASON_NAME] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxSEASON_NAME].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxSTYLE_CD] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxSTYLE_CD].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxSTYLE_NAME] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxSTYLE_NAME].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxNF_CD] = _round;

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxLOT_NO] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxLOT_NO].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxLOT_SEQ] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxLOT_SEQ].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxSRF_SEQ] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxSRF_SEQ_MAX].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxCS_SIZE] = "";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_SEQ] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxPART_SEQ].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_NO] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxPART_NO].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_TYPE] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxPART_TYPE].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_DESC] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxPART_DESC].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_COMMENT] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxPART_COMMENT].ToString();

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_CD] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxMAT_CD].ToString();

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_NAME] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxMAT_NAME].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_COMMENT] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxMAT_COMMENT].ToString();

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_CD] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxPCC_SPEC_CD].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_DESC] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxPCC_SPEC_NAME].ToString();

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_CD] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxCOLOR_CD].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_DESC] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxCOLOR_DESC].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_COMMENT] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxCOLOR_COMMENT].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_UNIT_CD] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxPCC_UNIT_CD].ToString();

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxMCS_CD] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxMCS_CD].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxPRICE_YN] = "";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOMMON_YN] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxCOMMON_YN].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxCBD_PRICE] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxCBD_PRICE].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxPUR_DIV] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxPUR_DIV].ToString();

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxTRANSPORT_TYPE] = "";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_REASON] = req_reason;
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxQTY_REQ] = "0";
                            //requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ]       = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxYIELD_VALUE].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxRTA_YMD] = "";

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxETC_YMD] = "";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxREMARKS] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxREMARKS].ToString();
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxSEND_CHK] = "";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxSEND_YMD] = "";
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxSTATUS] = "N";

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxCS_SIZE] = fgrid_part[i, (int)ClassLib.TBSXD_SRF_TAIL_SELECTER.IxCS_SIZE].ToString();

                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxUPD_USER] = COM.ComVar.This_User;
                            requestMaster.flg_request1[inst_row, (int)ClassLib.TBSXO_PUR_REQ.IxUPD_YMD] = " ";
                            #endregion
                        }
                    }
                    this.Close();
                }
                else
                {
                    for(int i = fgrid_model.Rows.Fixed; i < fgrid_model.Rows.Count; i++)
                    {
                        if (fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxDIVISION].ToString() == "U")
                        {
                            string _factory  = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxFACTORY].ToString();
                            string _sr_no    = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSR_NO].ToString();
                            string _srf_no   = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSRF_NO].ToString();
                            string _bom_id   = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_ID].ToString();
                            string _bom_rev  = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_REV].ToString();
                            string _nf_cd    = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxNF_CD].ToString();
                            string _stlye_cd = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSTYLE_CD].ToString();


                            Update_style_code(_factory, _sr_no, _srf_no, _bom_id, _bom_rev, _nf_cd, _stlye_cd);

                            tbtn_Search_Click(null, null);
                            fgrid_model.Select(sct_row, sct_col);
                        }
                        
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
        private void tbtn_Create_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                //folderBrowserDialog1.RootFolder = @"C:";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel) return;
                Group_Dir = folderBrowserDialog1.SelectedPath;

                for (int i = _RowFixed; i < fgrid_model.Rows.Count; i++)
                {
                    if (fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxXML_CRT].ToString() == "True")
                    {
                        if (fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSTYLE_CD].ToString().Trim().Length > 0)
                        {

                            string _factory = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxFACTORY].ToString();
                            string _sr_no = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSR_NO].ToString();
                            string _srf_no = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSRF_NO].ToString();
                            string _bom_id = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_ID].ToString();
                            string _bom_rev = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_REV].ToString();
                            string _nf_cd = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxNF_CD].ToString();

                            create_xml(_factory, _sr_no, _srf_no, _bom_id, _bom_rev, _nf_cd);

                        }
                        else
                        {
                            string arg_srf_no = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSRF_NO].ToString();
                            string arg_bom_id = fgrid_model[i, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_ID].ToString();

                            ClassLib.ComFunction.User_Message("No Style :"+ arg_srf_no + "-" + arg_bom_id, "Create Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
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
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string mrd_Filename = "";
                string sPara = "";

                string factory  = cmb_factory.SelectedValue.ToString();
                string srno     = ClassLib.ComFunction.Empty_TextBox(txt_sr_no, "").Trim();
                string srfno    = ClassLib.ComFunction.Empty_TextBox(txt_srfno, "").Trim();
                string bomid    = ClassLib.ComFunction.Empty_TextBox(txt_bomid, "").Trim();
                string nfcd     = ClassLib.ComFunction.Empty_Combo(cmb_sampletype, "").Trim();
                string category = ClassLib.ComFunction.Empty_Combo(cmb_category, "").Trim();
                string season   = ClassLib.ComFunction.Empty_Combo(cmb_season, "").Trim();
                string model    = ClassLib.ComFunction.Empty_TextBox(txt_stylename, "").Trim();
                string purready = (chk_except_mrp.Checked)?"D":"";
                string loaduser = ClassLib.ComFunction.Empty_Combo(cmb_user, "").Trim();
                string fromYMD  = dtp_from.Value.ToString("yyyyMMdd");
                string toYMD    = dtp_to.Value.ToString("yyyyMMdd");

                if (COM.ComVar.This_CDCPower_Level.Substring(0, 1).Equals("C"))
                {
                    mrd_Filename = Application.StartupPath + @"\SampleRequest_List_Cost" + ".mrd";
                }
                else
                {
                    mrd_Filename = Application.StartupPath + @"\SampleRequest_List_Date" + ".mrd"; 
                }
                
                sPara = " /rp " + "[" + factory + "]"
                                + " [" + srno + "]"
                                + " [" + srfno + "]"
                                + " [" + bomid + "]"
                                + " [" + nfcd + "]"
                                + " [" + category + "]"
                                + " [" + season + "]"
                                + " [" + model + "]"
                                + " [" + purready + "]"
                                + " [" + loaduser + "]"
                                + " [" + fromYMD + "]"
                                + " [" + toYMD + "]";

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
        private void tbtn_Conform_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
        }
        private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
        }
		#endregion

		#region Grid Event
		private void fgrid_model_DoubleClick(object sender, System.EventArgs e)
		{

            //if (fgrid_model.Selection.r1 <= fgrid_model.Rows.Fixed-1)  return;

            //if (bool.Parse((ClassLib.ComVar.This_Dept == "XML" || ClassLib.ComVar.This_Dept == "PMC") ? "true" : "false"))
            //{
            //    if (fgrid_model.Selection.c1 == (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSTYLE_CD)
            //        return;                 
            //}

            //int sct_row = fgrid_model.Selection.r1;
            //int sct_col = fgrid_model.Selection.c1;
            //fgrid_part.Rows.Count = fgrid_part.Rows.Fixed;	

            //string _factory  = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxFACTORY].ToString();
            //string _sr_no    = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSR_NO].ToString();
            //string _srf_no   = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSRF_NO].ToString();
            //string _bom_id   = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_ID].ToString();
            //string _bom_rev  = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_REV].ToString();
            //string _nf_cd    = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxNF_CD].ToString();
            //string _category = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxCATEGORY].ToString();
			


            //if( requestMaster != null)
            //{
            //    DataTable dt =  Select_sxd_srf_tail(_factory, _sr_no, _srf_no, _bom_id, _bom_rev, _nf_cd);
            //    for(int i=0; i<dt.Rows.Count; i++)
            //    {
            //        fgrid_part.AddItem(dt.Rows[i].ItemArray, fgrid_part.Rows.Count, 0);
            //    }
            //}
            //else
            //{
            //    FlexCDC.CDC_Bom.Form_Bom_Editer bomEditer = new FlexCDC.CDC_Bom.Form_Bom_Editer("S", _factory, _sr_no, _srf_no, _bom_id, _bom_rev, _nf_cd, _category);
            //    bomEditer.MdiParent = COM.ComVar.static_form;				
            //    bomEditer.Show();
            //    this.Close();
            //}
		}

        private void fgrid_model_AfterEdit(object sender, RowColEventArgs e)
        {
            //int sct_row = fgrid_model.Selection.r1;
            //int sct_col = fgrid_model.Selection.c1;

            //if(sct_col == (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSTYLE_CD)
            //{
            //    string style_cd = (fgrid_model[sct_row, sct_col] == null || fgrid_model[sct_row, sct_col].ToString().Trim() == "")? "" :fgrid_model[sct_row, sct_col].ToString().Trim();

            //    if (style_cd.Length != 9 && style_cd != "")
            //    {
            //        MessageBox.Show("Format Error : Stlye Code");                    
            //        return;
            //    }
            //}

            
            //fgrid_model.Update_Row(sct_row);
        }
        #endregion

		#region ContextMenu Event
		//miyoung.kim

		private void cmt_Bom_Copy_Click(object sender, System.EventArgs e)
		{

            //int sct_row = fgrid_model.Selection.r1;
            //int sct_col = fgrid_model.Selection.c1;

            //string _factory = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxFACTORY].ToString();
            //string _sr_no = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSR_NO].ToString();
            //string _srf_no = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSRF_NO].ToString();
            //string _bom_id = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_ID].ToString();
            //string _bom_rev = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_REV].ToString();
            //string _nf_cd = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxNF_CD].ToString();
            //string _category = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxCATEGORY].ToString();

            //FlexCDC.CDC_Bom.Form_Bom_Editer bomEditer = new FlexCDC.CDC_Bom.Form_Bom_Editer("C", _factory, _sr_no, _srf_no, _bom_id, _bom_rev, _nf_cd, _category);
            //bomEditer.MdiParent = COM.ComVar.static_form;
            ////ClassLib.ComVar.MenuClick_Flag = true;
            //bomEditer.Show();
            //this.Close();

		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
            //int sct_row = fgrid_model.Selection.r1;
            //int sct_col = fgrid_model.Selection.c1;

            //string _factory = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxFACTORY].ToString();
            //string _sr_no   = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSR_NO].ToString();
            //string _srf_no  = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSRF_NO].ToString();
            //string _bom_id  = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_ID].ToString();
            //string _bom_rev = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_REV].ToString();
            //string _nf_cd   = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxNF_CD].ToString();
            //string _category = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxCATEGORY].ToString();

            //FlexCDC.CDC_Bom.Form_Bom_Editer bomEditer = new FlexCDC.CDC_Bom.Form_Bom_Editer("S", _factory, _sr_no, _srf_no, _bom_id, _bom_rev, _nf_cd, _category);
            //bomEditer.MdiParent = COM.ComVar.static_form;
            ////ClassLib.ComVar.MenuClick_Flag = true;
            //bomEditer.Show();
            //this.Close();
		}


		private void menuItem1_Click(object sender, System.EventArgs e)
		{
            //int sct_row = fgrid_model.Selection.r1;
            //int sct_col = fgrid_model.Selection.c1;
            


            //string _factory      = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxFACTORY].ToString();
            //string _category     = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxCATEGORY].ToString();
            //string _season       = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSEASON_CD].ToString();

            //string _sr_no        = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSR_NO].ToString();
            //string _srf_no       = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSRF_NO].ToString();
            //string _bom_id       = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_ID].ToString();
            //string _sample_types = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSAMPLE_TYPES].ToString();
            //string _upload_user  = ClassLib.ComFunction.Empty_Combo(cmb_user, " ");

            //Form_Project_Manager projectManager = new Form_Project_Manager("S", _factory, _category, _season, _sr_no, _srf_no, _bom_id, _sample_types,_upload_user );
            //projectManager.MdiParent = COM.ComVar.static_form;
            ////ClassLib.ComVar.MenuClick_Flag = true;
            //projectManager.Show();
           
            //this.Close();
		}


		#endregion  

		#endregion 

		#region DB Connect
		

		

		private DataTable Select_model_categoty_list()
		{
			string Proc_Name = "PKG_SXD_SRF_01_SELECT.select_model_categoty_list";

			OraDB.ReDim_Parameter(2);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private DataTable Select_Sdd_Srf_Nf_Cd(string arg_factory, string arg_sr_no, string arg_pj_seq)
		{
			string Proc_Name = "pkg_sdd_srf_01_select.select_sdd_srf_nf_cd";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "arg_sr_no";
			OraDB.Parameter_Name[2] = "arg_pj_seq";
			OraDB.Parameter_Name[3] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = arg_factory;
			OraDB.Parameter_Values[1] = arg_sr_no;
			OraDB.Parameter_Values[2] = arg_pj_seq;
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		

		private DataTable Select_sxc_pj_head_list()
		{
			string Proc_Name = "PKG_SXD_SRF_01_SELECT.SELECT_SXC_PJ_MAST_LIST";

			OraDB.ReDim_Parameter(15);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "arg_sr_no";
			OraDB.Parameter_Name[2] = "arg_srf_no";
			OraDB.Parameter_Name[3] = "arg_bom_id";
			OraDB.Parameter_Name[4] = "arg_nf_cd";
			OraDB.Parameter_Name[5] = "arg_category";
			OraDB.Parameter_Name[6] = "arg_season";
			OraDB.Parameter_Name[7] = "arg_stylenm";
            OraDB.Parameter_Name[8] = "arg_stylecd";
			OraDB.Parameter_Name[9] = "arg_dep_flg";
			OraDB.Parameter_Name[10] = "arg_status";
            OraDB.Parameter_Name[11] = "arg_load_upd_user";
			OraDB.Parameter_Name[12] = "arg_from_date";
            OraDB.Parameter_Name[13] = "arg_to_date";
            OraDB.Parameter_Name[14] = "out_cursor";

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
            OraDB.Parameter_Type[13] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[14] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = txt_sr_no.Text.Trim().ToUpper();
			OraDB.Parameter_Values[2] = txt_srfno.Text.Trim().ToUpper();
			OraDB.Parameter_Values[3] = txt_bomid.Text.Trim().ToUpper();
			OraDB.Parameter_Values[4] = cmb_sampletype.SelectedValue.ToString();
			OraDB.Parameter_Values[5] = cmb_category.SelectedValue.ToString();
			OraDB.Parameter_Values[6] = cmb_season.SelectedValue.ToString();
			OraDB.Parameter_Values[7] = txt_stylename.Text.Trim().ToUpper();
            OraDB.Parameter_Values[8] = txt_style_cd.Text.Trim();
            OraDB.Parameter_Values[9] = (chk_except_mrp.Checked) ? "D" : "";
			OraDB.Parameter_Values[10] = cmb_status.SelectedValue.ToString();
			OraDB.Parameter_Values[11] = cmb_user.SelectedValue.ToString();    
            OraDB.Parameter_Values[12] = dtp_from.Value.ToString("yyyyMMdd"); 
            OraDB.Parameter_Values[13] = dtp_to.Value.ToString("yyyyMMdd"); 
			OraDB.Parameter_Values[14] = "";			

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private DataTable Select_sxd_srf_tail(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
		{
			string Proc_Name = "pkg_SXP_PUR_01_select.SELECT_SXD_SRF_TAIL";

			OraDB.ReDim_Parameter(7);
			OraDB.Process_Name = Proc_Name ;

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

			OraDB.Parameter_Values[0] = arg_factory;
			OraDB.Parameter_Values[1] = arg_sr_no;
			OraDB.Parameter_Values[2] = arg_srf_no;
			OraDB.Parameter_Values[3] = arg_bom_id;
			OraDB.Parameter_Values[4] = arg_bom_rev;
			OraDB.Parameter_Values[5] = arg_nf_cd;
			OraDB.Parameter_Values[6] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private DataTable Select_create_xml_head(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
		{
			string Proc_Name = "PKG_SXD_SRF_03_SELECT.select_create_xml_head";

			OraDB.ReDim_Parameter(7);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "arg_sr_no";
			OraDB.Parameter_Name[2] = "arg_srf_no";
			OraDB.Parameter_Name[3] = "arg_bom_id";
			OraDB.Parameter_Name[4] = "arg_bom_rev";
			OraDB.Parameter_Name[5] = "arg_nf_cd";
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

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private DataTable Select_create_xml_tail(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
		{
			string Proc_Name = "PKG_SXD_SRF_03_SELECT.select_create_xml_tail";

			OraDB.ReDim_Parameter(7);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "arg_sr_no";
			OraDB.Parameter_Name[2] = "arg_srf_no";
			OraDB.Parameter_Name[3] = "arg_bom_id";
			OraDB.Parameter_Name[4] = "arg_bom_rev";
			OraDB.Parameter_Name[5] = "arg_nf_cd";
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

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}


        private void  Make_Srf_Nike_File(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd)
        {

            OraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXD_SRF_03.make_sxd_srf_nike_file";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_sr_no";
            OraDB.Parameter_Name[2] = "arg_srf_no";
            OraDB.Parameter_Name[3] = "arg_bom_id";
            OraDB.Parameter_Name[4] = "arg_bom_rev";
            OraDB.Parameter_Name[5] = "arg_nf_cd";
            OraDB.Parameter_Name[6] = "arg_upd_user";

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
            OraDB.Parameter_Values[1] = arg_sr_no;
            OraDB.Parameter_Values[2] = arg_srf_no;
            OraDB.Parameter_Values[3] = arg_bom_id;
            OraDB.Parameter_Values[4] = arg_bom_rev;
            OraDB.Parameter_Values[5] = arg_nf_cd;
            OraDB.Parameter_Values[6] = ClassLib.ComVar.This_User;


            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();           

        }
        private void Update_style_code(string arg_factory, string arg_sr_no, string arg_srf_no, string arg_bom_id, string arg_bom_rev, string arg_nf_cd, string arg_style_cd)
        {

            OraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXD_SRF_03.update_style_code";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_sr_no";
            OraDB.Parameter_Name[2] = "arg_srf_no";
            OraDB.Parameter_Name[3] = "arg_bom_id";
            OraDB.Parameter_Name[4] = "arg_bom_rev";
            OraDB.Parameter_Name[5] = "arg_nf_cd";
            OraDB.Parameter_Name[6] = "arg_style_cd";

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
            OraDB.Parameter_Values[1] = arg_sr_no;
            OraDB.Parameter_Values[2] = arg_srf_no;
            OraDB.Parameter_Values[3] = arg_bom_id;
            OraDB.Parameter_Values[4] = arg_bom_rev;
            OraDB.Parameter_Values[5] = arg_nf_cd;
            OraDB.Parameter_Values[6] = arg_style_cd;


            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();

        }


		#endregion 

		  
	}
}

