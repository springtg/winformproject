using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.Threading;

namespace FlexCDC.CDC_Bom
{
	public class Form_Bom_Selecter_In_DS : COM.CDCWinForm.Pop_Large_B//COM.PCHWinForm.Pop_Large_B
	{

		#region 사용자 정의 변수 
		private COM.OraDB OraDB = new COM.OraDB();
		private int _RowFixed;
        private BaseInfo.Pop_BS_Shipping_List_Wait _pop = null;

		#endregion  

		#region  컨트롤정의 및 리소스 정의  
		public System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_sampletype;
		private System.Windows.Forms.Label lbl_sampletype;
		private C1.Win.C1List.C1Combo cmb_dep_flg;
		private System.Windows.Forms.Label lbl_dep_flg;
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
		private System.Windows.Forms.TextBox txt_stylename;
        private System.Windows.Forms.Label lbl_stylelname;
        private System.ComponentModel.IContainer components = null;
		private string Group_Dir = null;
		private int _TailRowFixed;

        private string req_reason = null;

		private Purchase.Form_Pur_request_master requestMaster = null;

		public Form_Bom_Selecter_In_DS()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


		public Form_Bom_Selecter_In_DS(Purchase.Form_Pur_request_master arg_form, string arg_req_reason)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bom_Selecter_In_DS));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_sampletype = new C1.Win.C1List.C1Combo();
            this.lbl_sampletype = new System.Windows.Forms.Label();
            this.cmb_dep_flg = new C1.Win.C1List.C1Combo();
            this.lbl_dep_flg = new System.Windows.Forms.Label();
            this.cmb_category = new C1.Win.C1List.C1Combo();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cmb_status = new C1.Win.C1List.C1Combo();
            this.txt_status = new System.Windows.Forms.Label();
            this.txt_sr_no01 = new System.Windows.Forms.Label();
            this.txt_sr_no = new System.Windows.Forms.TextBox();
            this.cmb_season = new C1.Win.C1List.C1Combo();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.lbl_user = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.fgrid_model = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_dep_flg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_model)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(713, 4);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(936, 23);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cmb_sampletype);
            this.panel1.Controls.Add(this.lbl_sampletype);
            this.panel1.Controls.Add(this.cmb_dep_flg);
            this.panel1.Controls.Add(this.lbl_dep_flg);
            this.panel1.Controls.Add(this.cmb_category);
            this.panel1.Controls.Add(this.lbl_category);
            this.panel1.Controls.Add(this.cmb_status);
            this.panel1.Controls.Add(this.txt_status);
            this.panel1.Controls.Add(this.txt_sr_no01);
            this.panel1.Controls.Add(this.txt_sr_no);
            this.panel1.Controls.Add(this.cmb_season);
            this.panel1.Controls.Add(this.cmb_user);
            this.panel1.Controls.Add(this.lbl_user);
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
            this.panel1.Font = new System.Drawing.Font("굴림", 9F);
            this.panel1.Location = new System.Drawing.Point(8, 80);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.panel1.Size = new System.Drawing.Size(986, 120);
            this.panel1.TabIndex = 130;
            // 
            // cmb_sampletype
            // 
            this.cmb_sampletype.AddItemCols = 0;
            this.cmb_sampletype.AddItemSeparator = ';';
            this.cmb_sampletype.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_sampletype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sampletype.Caption = "";
            this.cmb_sampletype.CaptionHeight = 17;
            this.cmb_sampletype.CaptionStyle = style1;
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
            this.cmb_sampletype.EvenRowStyle = style2;
            this.cmb_sampletype.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampletype.FooterStyle = style3;
            this.cmb_sampletype.GapHeight = 2;
            this.cmb_sampletype.HeadingStyle = style4;
            this.cmb_sampletype.HighLightRowStyle = style5;
            this.cmb_sampletype.ItemHeight = 15;
            this.cmb_sampletype.Location = new System.Drawing.Point(117, 59);
            this.cmb_sampletype.MatchEntryTimeout = ((long)(2000));
            this.cmb_sampletype.MaxDropDownItems = ((short)(5));
            this.cmb_sampletype.MaxLength = 32767;
            this.cmb_sampletype.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sampletype.Name = "cmb_sampletype";
            this.cmb_sampletype.OddRowStyle = style6;
            this.cmb_sampletype.PartialRightColumn = false;
            this.cmb_sampletype.PropBag = resources.GetString("cmb_sampletype.PropBag");
            this.cmb_sampletype.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sampletype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sampletype.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sampletype.SelectedStyle = style7;
            this.cmb_sampletype.Size = new System.Drawing.Size(120, 21);
            this.cmb_sampletype.Style = style8;
            this.cmb_sampletype.TabIndex = 353;
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
            // cmb_dep_flg
            // 
            this.cmb_dep_flg.AddItemCols = 0;
            this.cmb_dep_flg.AddItemSeparator = ';';
            this.cmb_dep_flg.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_dep_flg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_dep_flg.Caption = "";
            this.cmb_dep_flg.CaptionHeight = 17;
            this.cmb_dep_flg.CaptionStyle = style9;
            this.cmb_dep_flg.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_dep_flg.ColumnCaptionHeight = 18;
            this.cmb_dep_flg.ColumnFooterHeight = 18;
            this.cmb_dep_flg.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_dep_flg.ContentHeight = 17;
            this.cmb_dep_flg.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_dep_flg.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_dep_flg.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dep_flg.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_dep_flg.EditorHeight = 17;
            this.cmb_dep_flg.EvenRowStyle = style10;
            this.cmb_dep_flg.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dep_flg.FooterStyle = style11;
            this.cmb_dep_flg.GapHeight = 2;
            this.cmb_dep_flg.HeadingStyle = style12;
            this.cmb_dep_flg.HighLightRowStyle = style13;
            this.cmb_dep_flg.ItemHeight = 15;
            this.cmb_dep_flg.Location = new System.Drawing.Point(357, 82);
            this.cmb_dep_flg.MatchEntryTimeout = ((long)(2000));
            this.cmb_dep_flg.MaxDropDownItems = ((short)(5));
            this.cmb_dep_flg.MaxLength = 32767;
            this.cmb_dep_flg.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_dep_flg.Name = "cmb_dep_flg";
            this.cmb_dep_flg.OddRowStyle = style14;
            this.cmb_dep_flg.PartialRightColumn = false;
            this.cmb_dep_flg.PropBag = resources.GetString("cmb_dep_flg.PropBag");
            this.cmb_dep_flg.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_dep_flg.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_dep_flg.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_dep_flg.SelectedStyle = style15;
            this.cmb_dep_flg.Size = new System.Drawing.Size(120, 21);
            this.cmb_dep_flg.Style = style16;
            this.cmb_dep_flg.TabIndex = 351;
            // 
            // lbl_dep_flg
            // 
            this.lbl_dep_flg.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_dep_flg.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dep_flg.ImageIndex = 0;
            this.lbl_dep_flg.ImageList = this.img_Label;
            this.lbl_dep_flg.Location = new System.Drawing.Point(256, 82);
            this.lbl_dep_flg.Name = "lbl_dep_flg";
            this.lbl_dep_flg.Size = new System.Drawing.Size(100, 21);
            this.lbl_dep_flg.TabIndex = 350;
            this.lbl_dep_flg.Tag = "1";
            this.lbl_dep_flg.Text = "Pur Ready";
            this.lbl_dep_flg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_category
            // 
            this.cmb_category.AddItemCols = 0;
            this.cmb_category.AddItemSeparator = ';';
            this.cmb_category.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_category.Caption = "";
            this.cmb_category.CaptionHeight = 17;
            this.cmb_category.CaptionStyle = style17;
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
            this.cmb_category.EvenRowStyle = style18;
            this.cmb_category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.FooterStyle = style19;
            this.cmb_category.GapHeight = 2;
            this.cmb_category.HeadingStyle = style20;
            this.cmb_category.HighLightRowStyle = style21;
            this.cmb_category.ItemHeight = 15;
            this.cmb_category.Location = new System.Drawing.Point(357, 59);
            this.cmb_category.MatchEntryTimeout = ((long)(2000));
            this.cmb_category.MaxDropDownItems = ((short)(5));
            this.cmb_category.MaxLength = 32767;
            this.cmb_category.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.OddRowStyle = style22;
            this.cmb_category.PartialRightColumn = false;
            this.cmb_category.PropBag = resources.GetString("cmb_category.PropBag");
            this.cmb_category.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_category.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_category.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_category.SelectedStyle = style23;
            this.cmb_category.Size = new System.Drawing.Size(120, 21);
            this.cmb_category.Style = style24;
            this.cmb_category.TabIndex = 349;
            // 
            // lbl_category
            // 
            this.lbl_category.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ImageIndex = 0;
            this.lbl_category.ImageList = this.img_Label;
            this.lbl_category.Location = new System.Drawing.Point(256, 59);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(100, 21);
            this.lbl_category.TabIndex = 348;
            this.lbl_category.Tag = "1";
            this.lbl_category.Text = "Category";
            this.lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_status
            // 
            this.cmb_status.AddItemCols = 0;
            this.cmb_status.AddItemSeparator = ';';
            this.cmb_status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_status.Caption = "";
            this.cmb_status.CaptionHeight = 17;
            this.cmb_status.CaptionStyle = style25;
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
            this.cmb_status.EvenRowStyle = style26;
            this.cmb_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FooterStyle = style27;
            this.cmb_status.GapHeight = 2;
            this.cmb_status.HeadingStyle = style28;
            this.cmb_status.HighLightRowStyle = style29;
            this.cmb_status.ItemHeight = 15;
            this.cmb_status.Location = new System.Drawing.Point(605, 82);
            this.cmb_status.MatchEntryTimeout = ((long)(2000));
            this.cmb_status.MaxDropDownItems = ((short)(5));
            this.cmb_status.MaxLength = 32767;
            this.cmb_status.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.OddRowStyle = style30;
            this.cmb_status.PartialRightColumn = false;
            this.cmb_status.PropBag = resources.GetString("cmb_status.PropBag");
            this.cmb_status.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_status.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_status.SelectedStyle = style31;
            this.cmb_status.Size = new System.Drawing.Size(120, 21);
            this.cmb_status.Style = style32;
            this.cmb_status.TabIndex = 347;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.SystemColors.Window;
            this.txt_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.ImageIndex = 0;
            this.txt_status.ImageList = this.img_Label;
            this.txt_status.Location = new System.Drawing.Point(504, 82);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(100, 21);
            this.txt_status.TabIndex = 346;
            this.txt_status.Tag = "1";
            this.txt_status.Text = "Status";
            this.txt_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sr_no01
            // 
            this.txt_sr_no01.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sr_no01.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sr_no01.ImageIndex = 0;
            this.txt_sr_no01.ImageList = this.img_Label;
            this.txt_sr_no01.Location = new System.Drawing.Point(256, 36);
            this.txt_sr_no01.Name = "txt_sr_no01";
            this.txt_sr_no01.Size = new System.Drawing.Size(100, 21);
            this.txt_sr_no01.TabIndex = 345;
            this.txt_sr_no01.Tag = "1";
            this.txt_sr_no01.Text = "SR No";
            this.txt_sr_no01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sr_no
            // 
            this.txt_sr_no.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_sr_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sr_no.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_sr_no.ForeColor = System.Drawing.Color.Black;
            this.txt_sr_no.Location = new System.Drawing.Point(357, 36);
            this.txt_sr_no.MaxLength = 100;
            this.txt_sr_no.Name = "txt_sr_no";
            this.txt_sr_no.Size = new System.Drawing.Size(120, 20);
            this.txt_sr_no.TabIndex = 344;
            // 
            // cmb_season
            // 
            this.cmb_season.AddItemCols = 0;
            this.cmb_season.AddItemSeparator = ';';
            this.cmb_season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_season.Caption = "";
            this.cmb_season.CaptionHeight = 17;
            this.cmb_season.CaptionStyle = style33;
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
            this.cmb_season.EvenRowStyle = style34;
            this.cmb_season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season.FooterStyle = style35;
            this.cmb_season.GapHeight = 2;
            this.cmb_season.HeadingStyle = style36;
            this.cmb_season.HighLightRowStyle = style37;
            this.cmb_season.ItemHeight = 15;
            this.cmb_season.Location = new System.Drawing.Point(605, 59);
            this.cmb_season.MatchEntryTimeout = ((long)(2000));
            this.cmb_season.MaxDropDownItems = ((short)(5));
            this.cmb_season.MaxLength = 32767;
            this.cmb_season.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_season.Name = "cmb_season";
            this.cmb_season.OddRowStyle = style38;
            this.cmb_season.PartialRightColumn = false;
            this.cmb_season.PropBag = resources.GetString("cmb_season.PropBag");
            this.cmb_season.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_season.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_season.SelectedStyle = style39;
            this.cmb_season.Size = new System.Drawing.Size(120, 21);
            this.cmb_season.Style = style40;
            this.cmb_season.TabIndex = 343;
            // 
            // cmb_user
            // 
            this.cmb_user.AddItemCols = 0;
            this.cmb_user.AddItemSeparator = ';';
            this.cmb_user.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_user.Caption = "";
            this.cmb_user.CaptionHeight = 17;
            this.cmb_user.CaptionStyle = style41;
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
            this.cmb_user.EvenRowStyle = style42;
            this.cmb_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FooterStyle = style43;
            this.cmb_user.GapHeight = 2;
            this.cmb_user.HeadingStyle = style44;
            this.cmb_user.HighLightRowStyle = style45;
            this.cmb_user.ItemHeight = 15;
            this.cmb_user.Location = new System.Drawing.Point(117, 82);
            this.cmb_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_user.MaxDropDownItems = ((short)(5));
            this.cmb_user.MaxLength = 32767;
            this.cmb_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.OddRowStyle = style46;
            this.cmb_user.PartialRightColumn = false;
            this.cmb_user.PropBag = resources.GetString("cmb_user.PropBag");
            this.cmb_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_user.SelectedStyle = style47;
            this.cmb_user.Size = new System.Drawing.Size(120, 21);
            this.cmb_user.Style = style48;
            this.cmb_user.TabIndex = 341;
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ImageIndex = 0;
            this.lbl_user.ImageList = this.img_Label;
            this.lbl_user.Location = new System.Drawing.Point(16, 82);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_user.TabIndex = 340;
            this.lbl_user.Tag = "1";
            this.lbl_user.Text = "Dev User";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style49;
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
            this.cmb_factory.EvenRowStyle = style50;
            this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style51;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style52;
            this.cmb_factory.HighLightRowStyle = style53;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(117, 36);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style54;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style55;
            this.cmb_factory.Size = new System.Drawing.Size(120, 21);
            this.cmb_factory.Style = style56;
            this.cmb_factory.TabIndex = 331;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Controls.Add(this.pictureBox14);
            this.panel2.Controls.Add(this.pictureBox15);
            this.panel2.Controls.Add(this.pictureBox16);
            this.panel2.Controls.Add(this.pictureBox17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("굴림", 9F);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 112);
            this.panel2.TabIndex = 18;
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
            this.pictureBox1.Size = new System.Drawing.Size(24, 69);
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
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(954, 97);
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
            this.pictureBox13.Location = new System.Drawing.Point(144, 96);
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
            this.pictureBox14.Location = new System.Drawing.Point(0, 97);
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
            this.pictureBox15.Size = new System.Drawing.Size(168, 79);
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
            this.pictureBox16.Size = new System.Drawing.Size(970, 72);
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
            this.pictureBox17.Size = new System.Drawing.Size(970, 72);
            this.pictureBox17.TabIndex = 27;
            this.pictureBox17.TabStop = false;
            // 
            // fgrid_model
            // 
            this.fgrid_model.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_model.AutoResize = false;
            this.fgrid_model.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_model.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_model.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_model.Font = new System.Drawing.Font("굴림", 9F);
            this.fgrid_model.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_model.Location = new System.Drawing.Point(15, 200);
            this.fgrid_model.Name = "fgrid_model";
            this.fgrid_model.Rows.Fixed = 0;
            this.fgrid_model.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_model.Size = new System.Drawing.Size(969, 433);
            this.fgrid_model.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_model.Styles"));
            this.fgrid_model.TabIndex = 131;
            this.fgrid_model.DoubleClick += new System.EventHandler(this.fgrid_model_DoubleClick);
            // 
            // Form_Bom_Selecter_In_DS
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(1000, 645);
            this.Controls.Add(this.fgrid_model);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Bom_Selecter_In_DS";
            this.Load += new System.EventHandler(this.Form_Bom_Selecter_In_DS_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.fgrid_model, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_dep_flg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_model)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	
		#region 공통메쏘드
		private void Init_Form()
		{

		
			this.Text = "PCC_Select Bom In DS";
			this.lbl_MainTitle.Text = "PCC_Select Bom In DS";
			ClassLib.ComFunction.SetLangDic(this); 

//			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
//			ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
//			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			DataTable dt_ret = Select_sdc_pj_tail_season();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1,true, COM.ComVar.ComboList_Visible.Name);
			cmb_season.SelectedIndex = 0;

			dt_ret = dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory.SelectedValue.ToString(),ClassLib.ComVar.CxCDC_Category );
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1,2, true, COM.ComVar.ComboList_Visible.Name);
			cmb_category.SelectedIndex  = 0;

			dt_ret = Select_sdc_nf_desc();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletype, 0,2 , true, COM.ComVar.ComboList_Visible.Name);
			cmb_sampletype.SelectedIndex= 0;

			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(),"SXC21");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_dep_flg, 1, 2 , true, COM.ComVar.ComboList_Visible.Name);
			cmb_dep_flg.SelectedIndex= 0;

			dt_ret = Select_sdd_srf_loaduser();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_user.SelectedIndex = 0;


			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(),"SXC20");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2,false, false);
			cmb_status.SelectedIndex = 0;


			fgrid_model.Set_Grid_CDC("SXC_PJ_MAST", "4", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_model.Set_Action_Image(img_Action);
			fgrid_model.ExtendLastCol = false;
			_RowFixed = fgrid_model.Rows.Fixed;


            fgrid_model.Cols[(int)ClassLib.TBSXC_PJ_MAST_SCTER.IxXML_CRT].Visible = false;



            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Conform.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Save.Enabled = false;
            tbtn_Search.Enabled = true;
            tbtn_Create.Enabled = false;



		}


	

		#endregion 

		#region 이벤트처리 

		#region 버튼이벤트

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            
            
            try
            {


                

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
            }
            catch
            {

            }
            finally
            {
            }
		}

		#endregion    

		#endregion 


        private void Open_waiting_Form()
        {
            _pop = new FlexCDC.BaseInfo.Pop_BS_Shipping_List_Wait();
            _pop.Searching_Start();
        }

		#region DB컨넥트 


		private DataTable Select_sdc_pj_tail_season()
		{
			string Proc_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

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

		private DataTable Select_sdd_srf_loaduser()
		{
            

            

			string Proc_Name = "PKG_SXD_SRF_01_SELECT.SELECT_SXD_SRF_LOADUSER";

			OraDB.ReDim_Parameter(2);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = "";

			OraDB.Add_Select_Parameter(true);



            this.Cursor = Cursors.WaitCursor;
            COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if(COM.ComVar.This_Factory == "VJ")
                COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
            if (COM.ComVar.This_Factory == "QD")
                COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;

            this.Cursor = Cursors.Default;



			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

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

		private DataTable Select_sdc_nf_desc()
		{
			string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC";

			OraDB.ReDim_Parameter(2);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}


		private DataTable Select_sxc_pj_head_list()
		{

			string Proc_Name = "PKG_SXD_SRF_01_SELECT.SELECT_SXC_PJ_MAST";

			OraDB.ReDim_Parameter(12);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "arg_sr_no";
			OraDB.Parameter_Name[2] = "arg_srf_no";
			OraDB.Parameter_Name[3] = "arg_bom_id";
			OraDB.Parameter_Name[4] = "arg_nf_cd";
			OraDB.Parameter_Name[5] = "arg_category";
			OraDB.Parameter_Name[6] = "arg_season";
			OraDB.Parameter_Name[7] = "arg_stylenm";
			OraDB.Parameter_Name[8] = "arg_dep_flg";
			OraDB.Parameter_Name[9] = "arg_status";
			OraDB.Parameter_Name[10] = "arg_load_upd_user";
			OraDB.Parameter_Name[11] = "out_cursor";

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
			OraDB.Parameter_Type[11] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = txt_sr_no.Text.Trim().ToUpper();
			OraDB.Parameter_Values[2] = txt_srfno.Text.Trim().ToUpper();
			OraDB.Parameter_Values[3] = txt_bomid.Text.Trim().ToUpper();
			OraDB.Parameter_Values[4] = cmb_sampletype.SelectedValue.ToString();
			OraDB.Parameter_Values[5] = cmb_category.SelectedValue.ToString();
			OraDB.Parameter_Values[6] = cmb_season.SelectedValue.ToString();
			OraDB.Parameter_Values[7] = txt_stylename.Text.Trim().ToUpper();
			OraDB.Parameter_Values[8] = cmb_dep_flg.SelectedValue.ToString();
			OraDB.Parameter_Values[9] = cmb_status.SelectedValue.ToString();
			OraDB.Parameter_Values[10] = cmb_user.SelectedValue.ToString();
			OraDB.Parameter_Values[11] = "";

			

			OraDB.Add_Select_Parameter(true);


            Thread vCreate = new Thread(new ThreadStart(Open_waiting_Form));
            vCreate.Start();
            tbtn_Search.Enabled = false;
            this.Enabled = false;
            
            COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (COM.ComVar.This_Factory == "VJ")
                COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
            if (COM.ComVar.This_Factory == "QD")
                COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;
            
            this.Enabled = true;
            tbtn_Search.Enabled = true;
            vCreate.Abort();

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




		#endregion 

		private void Form_Bom_Selecter_In_DS_Load(object sender, System.EventArgs e)
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

        private void fgrid_model_DoubleClick(object sender, EventArgs e)
        {
            if (fgrid_model.Selection.r1 <= fgrid_model.Rows.Fixed - 1) return;


            int sct_row = fgrid_model.Selection.r1;
            int sct_col = fgrid_model.Selection.c1;



            string _factory = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxFACTORY].ToString();
            string _sr_no = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSR_NO].ToString();
            string _srf_no = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxSRF_NO].ToString();
            string _bom_id = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_ID].ToString();
            string _bom_rev = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxBOM_REV].ToString();
            string _nf_cd = fgrid_model[sct_row, (int)ClassLib.TBSXC_PJ_MAST_SCTER.IxNF_CD].ToString();


            Thread vCreate = new Thread(new ThreadStart(Open_waiting_Form));
            vCreate.Start();
            tbtn_Search.Enabled = false;
            this.Enabled = false;
            
            FlexCDC.CDC_Bom.Form_Bom_Editer_In_DS bomEditer = new FlexCDC.CDC_Bom.Form_Bom_Editer_In_DS(_factory, _sr_no, _srf_no, _bom_id, _bom_rev, _nf_cd);
            bomEditer.MdiParent = COM.ComVar.static_form;
           // ClassLib.ComVar.MenuClick_Flag = true;
            bomEditer.Show();
            //this.Close();

            this.Enabled = true;
            tbtn_Search.Enabled = true;
            vCreate.Abort();
        }
	}
}

