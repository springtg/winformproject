using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;


namespace FlexCDC.Outgoing
{
	public class Form_Outgoing : COM.PCHWinForm.Form_Top
    {
        #region 컨트롤 정의 및 리소스 정의
        public System.Windows.Forms.Panel pnl_Top;
		private System.Windows.Forms.Label lbl_out_no;
		private C1.Win.C1List.C1Combo cmb_factory;
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
		public COM.FSP flg_out;
		private System.Windows.Forms.Label lbl_out_div;
		private System.Windows.Forms.Label lbl_out_date;
		private System.ComponentModel.IContainer components = null;
		
		public C1.Win.C1List.C1Combo cmb_out_no;
		private System.Windows.Forms.DateTimePicker dpk_out_date;
		public C1.Win.C1List.C1Combo cmb_out_div;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.TextBox txt_spec_name;
		private System.Windows.Forms.Label lbl_spec_name;
		private System.Windows.Forms.TextBox txt_mat_name;
		private System.Windows.Forms.TextBox txt_color_name;
		private System.Windows.Forms.Label lbl_mat_name;
		private System.Windows.Forms.Label lbl_color_name;
        private ContextMenuStrip ct_mnu;
        private ToolStripMenuItem mnu_mat;
        private ToolStripMenuItem mnu_bom;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnu_insert;
        private ToolStripMenuItem mnu_delete;
        private C1.Win.C1List.C1Combo cmb_status;
		

		public Form_Outgoing()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Outgoing));
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
            C1.Win.C1List.Style style81 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style82 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style83 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style84 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style85 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style86 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style87 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style88 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style89 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style90 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style91 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style92 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style93 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style94 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style95 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style96 = new C1.Win.C1List.Style();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.txt_spec_name = new System.Windows.Forms.TextBox();
            this.lbl_spec_name = new System.Windows.Forms.Label();
            this.txt_mat_name = new System.Windows.Forms.TextBox();
            this.txt_color_name = new System.Windows.Forms.TextBox();
            this.lbl_mat_name = new System.Windows.Forms.Label();
            this.lbl_color_name = new System.Windows.Forms.Label();
            this.cmb_status = new C1.Win.C1List.C1Combo();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.dpk_out_date = new System.Windows.Forms.DateTimePicker();
            this.cmb_out_div = new C1.Win.C1List.C1Combo();
            this.lbl_out_div = new System.Windows.Forms.Label();
            this.lbl_out_date = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_openfile = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_out_no = new System.Windows.Forms.Label();
            this.cmb_out_no = new C1.Win.C1List.C1Combo();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.flg_out = new COM.FSP();
            this.ct_mnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_mat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_bom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_out_div)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_out_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flg_out)).BeginInit();
            this.ct_mnu.SuspendLayout();
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
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
            // 
            // tbtn_Create
            // 
            this.tbtn_Create.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Create_Click);
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
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.txt_spec_name);
            this.pnl_Top.Controls.Add(this.lbl_spec_name);
            this.pnl_Top.Controls.Add(this.txt_mat_name);
            this.pnl_Top.Controls.Add(this.txt_color_name);
            this.pnl_Top.Controls.Add(this.lbl_mat_name);
            this.pnl_Top.Controls.Add(this.lbl_color_name);
            this.pnl_Top.Controls.Add(this.cmb_status);
            this.pnl_Top.Controls.Add(this.lbl_status);
            this.pnl_Top.Controls.Add(this.cmb_factory);
            this.pnl_Top.Controls.Add(this.dpk_out_date);
            this.pnl_Top.Controls.Add(this.cmb_out_div);
            this.pnl_Top.Controls.Add(this.lbl_out_div);
            this.pnl_Top.Controls.Add(this.lbl_out_date);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 80);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 95);
            this.pnl_Top.TabIndex = 139;
            // 
            // txt_spec_name
            // 
            this.txt_spec_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_spec_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_spec_name.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_spec_name.ForeColor = System.Drawing.Color.Black;
            this.txt_spec_name.Location = new System.Drawing.Point(840, 58);
            this.txt_spec_name.MaxLength = 100;
            this.txt_spec_name.Name = "txt_spec_name";
            this.txt_spec_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_spec_name.Size = new System.Drawing.Size(130, 20);
            this.txt_spec_name.TabIndex = 371;
            // 
            // lbl_spec_name
            // 
            this.lbl_spec_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spec_name.ImageIndex = 0;
            this.lbl_spec_name.ImageList = this.img_Label;
            this.lbl_spec_name.Location = new System.Drawing.Point(739, 58);
            this.lbl_spec_name.Name = "lbl_spec_name";
            this.lbl_spec_name.Size = new System.Drawing.Size(100, 21);
            this.lbl_spec_name.TabIndex = 370;
            this.lbl_spec_name.Text = "Spec";
            this.lbl_spec_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_mat_name
            // 
            this.txt_mat_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mat_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mat_name.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_mat_name.ForeColor = System.Drawing.Color.Black;
            this.txt_mat_name.Location = new System.Drawing.Point(358, 58);
            this.txt_mat_name.MaxLength = 100;
            this.txt_mat_name.Name = "txt_mat_name";
            this.txt_mat_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_mat_name.Size = new System.Drawing.Size(130, 20);
            this.txt_mat_name.TabIndex = 0;
            // 
            // txt_color_name
            // 
            this.txt_color_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_color_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_color_name.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_color_name.ForeColor = System.Drawing.Color.Black;
            this.txt_color_name.Location = new System.Drawing.Point(599, 58);
            this.txt_color_name.MaxLength = 100;
            this.txt_color_name.Name = "txt_color_name";
            this.txt_color_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_color_name.Size = new System.Drawing.Size(130, 20);
            this.txt_color_name.TabIndex = 368;
            // 
            // lbl_mat_name
            // 
            this.lbl_mat_name.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_mat_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mat_name.ImageIndex = 0;
            this.lbl_mat_name.ImageList = this.img_Label;
            this.lbl_mat_name.Location = new System.Drawing.Point(257, 58);
            this.lbl_mat_name.Name = "lbl_mat_name";
            this.lbl_mat_name.Size = new System.Drawing.Size(100, 21);
            this.lbl_mat_name.TabIndex = 367;
            this.lbl_mat_name.Text = "Material";
            this.lbl_mat_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_color_name
            // 
            this.lbl_color_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color_name.ImageIndex = 0;
            this.lbl_color_name.ImageList = this.img_Label;
            this.lbl_color_name.Location = new System.Drawing.Point(498, 58);
            this.lbl_color_name.Name = "lbl_color_name";
            this.lbl_color_name.Size = new System.Drawing.Size(100, 21);
            this.lbl_color_name.TabIndex = 366;
            this.lbl_color_name.Text = "Color";
            this.lbl_color_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_status
            // 
            this.cmb_status.AddItemCols = 0;
            this.cmb_status.AddItemSeparator = ';';
            this.cmb_status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_status.Caption = "";
            this.cmb_status.CaptionHeight = 17;
            this.cmb_status.CaptionStyle = style65;
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
            this.cmb_status.EvenRowStyle = style66;
            this.cmb_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FooterStyle = style67;
            this.cmb_status.GapHeight = 2;
            this.cmb_status.HeadingStyle = style68;
            this.cmb_status.HighLightRowStyle = style69;
            this.cmb_status.ItemHeight = 15;
            this.cmb_status.Location = new System.Drawing.Point(840, 36);
            this.cmb_status.MatchEntryTimeout = ((long)(2000));
            this.cmb_status.MaxDropDownItems = ((short)(5));
            this.cmb_status.MaxLength = 32767;
            this.cmb_status.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.OddRowStyle = style70;
            this.cmb_status.PartialRightColumn = false;
            this.cmb_status.PropBag = resources.GetString("cmb_status.PropBag");
            this.cmb_status.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_status.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_status.SelectedStyle = style71;
            this.cmb_status.Size = new System.Drawing.Size(130, 21);
            this.cmb_status.Style = style72;
            this.cmb_status.TabIndex = 365;
            this.cmb_status.SelectedValueChanged += new System.EventHandler(this.cmb_status_SelectedValueChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ImageIndex = 0;
            this.lbl_status.ImageList = this.img_Label;
            this.lbl_status.Location = new System.Drawing.Point(739, 36);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_status.TabIndex = 364;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style73;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 17;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 17;
            this.cmb_factory.EvenRowStyle = style74;
            this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style75;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style76;
            this.cmb_factory.HighLightRowStyle = style77;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(117, 36);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style78;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style79;
            this.cmb_factory.Size = new System.Drawing.Size(130, 21);
            this.cmb_factory.Style = style80;
            this.cmb_factory.TabIndex = 350;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // dpk_out_date
            // 
            this.dpk_out_date.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_out_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_out_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_out_date.Location = new System.Drawing.Point(358, 35);
            this.dpk_out_date.Name = "dpk_out_date";
            this.dpk_out_date.Size = new System.Drawing.Size(131, 22);
            this.dpk_out_date.TabIndex = 324;
            this.dpk_out_date.Value = new System.DateTime(2008, 6, 27, 0, 0, 0, 0);
            this.dpk_out_date.CloseUp += new System.EventHandler(this.dpk_out_date_CloseUp);
            // 
            // cmb_out_div
            // 
            this.cmb_out_div.AddItemCols = 0;
            this.cmb_out_div.AddItemSeparator = ';';
            this.cmb_out_div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_out_div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_out_div.Caption = "";
            this.cmb_out_div.CaptionHeight = 17;
            this.cmb_out_div.CaptionStyle = style81;
            this.cmb_out_div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_out_div.ColumnCaptionHeight = 18;
            this.cmb_out_div.ColumnFooterHeight = 18;
            this.cmb_out_div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_out_div.ContentHeight = 17;
            this.cmb_out_div.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_out_div.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_out_div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_out_div.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_out_div.EditorHeight = 17;
            this.cmb_out_div.EvenRowStyle = style82;
            this.cmb_out_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_out_div.FooterStyle = style83;
            this.cmb_out_div.GapHeight = 2;
            this.cmb_out_div.HeadingStyle = style84;
            this.cmb_out_div.HighLightRowStyle = style85;
            this.cmb_out_div.ItemHeight = 15;
            this.cmb_out_div.Location = new System.Drawing.Point(599, 36);
            this.cmb_out_div.MatchEntryTimeout = ((long)(2000));
            this.cmb_out_div.MaxDropDownItems = ((short)(5));
            this.cmb_out_div.MaxLength = 32767;
            this.cmb_out_div.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_out_div.Name = "cmb_out_div";
            this.cmb_out_div.OddRowStyle = style86;
            this.cmb_out_div.PartialRightColumn = false;
            this.cmb_out_div.PropBag = resources.GetString("cmb_out_div.PropBag");
            this.cmb_out_div.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_out_div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_out_div.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_out_div.SelectedStyle = style87;
            this.cmb_out_div.Size = new System.Drawing.Size(130, 21);
            this.cmb_out_div.Style = style88;
            this.cmb_out_div.TabIndex = 320;
            this.cmb_out_div.SelectedValueChanged += new System.EventHandler(this.cmb_out_div_SelectedValueChanged);
            // 
            // lbl_out_div
            // 
            this.lbl_out_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_out_div.ImageIndex = 0;
            this.lbl_out_div.ImageList = this.img_Label;
            this.lbl_out_div.Location = new System.Drawing.Point(498, 36);
            this.lbl_out_div.Name = "lbl_out_div";
            this.lbl_out_div.Size = new System.Drawing.Size(100, 21);
            this.lbl_out_div.TabIndex = 319;
            this.lbl_out_div.Text = "Division";
            this.lbl_out_div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_out_date
            // 
            this.lbl_out_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_out_date.ImageIndex = 0;
            this.lbl_out_date.ImageList = this.img_Label;
            this.lbl_out_date.Location = new System.Drawing.Point(257, 36);
            this.lbl_out_date.Name = "lbl_out_date";
            this.lbl_out_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_out_date.TabIndex = 313;
            this.lbl_out_date.Text = "Date";
            this.lbl_out_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.btn_openfile);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.lbl_out_no);
            this.pnl_SearchImage.Controls.Add(this.cmb_out_no);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 87);
            this.pnl_SearchImage.TabIndex = 18;
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
            this.lbl_title.Text = "      Outgoing Information";
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
            this.picb_MR.Size = new System.Drawing.Size(24, 44);
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
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_out_no
            // 
            this.lbl_out_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_out_no.ImageIndex = 0;
            this.lbl_out_no.ImageList = this.img_Label;
            this.lbl_out_no.Location = new System.Drawing.Point(8, 58);
            this.lbl_out_no.Name = "lbl_out_no";
            this.lbl_out_no.Size = new System.Drawing.Size(100, 21);
            this.lbl_out_no.TabIndex = 358;
            this.lbl_out_no.Text = "No";
            this.lbl_out_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_out_no
            // 
            this.cmb_out_no.AddItemCols = 0;
            this.cmb_out_no.AddItemSeparator = ';';
            this.cmb_out_no.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_out_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_out_no.Caption = "";
            this.cmb_out_no.CaptionHeight = 17;
            this.cmb_out_no.CaptionStyle = style89;
            this.cmb_out_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_out_no.ColumnCaptionHeight = 18;
            this.cmb_out_no.ColumnFooterHeight = 18;
            this.cmb_out_no.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_out_no.ContentHeight = 17;
            this.cmb_out_no.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_out_no.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_out_no.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_out_no.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_out_no.EditorHeight = 17;
            this.cmb_out_no.EvenRowStyle = style90;
            this.cmb_out_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_out_no.FooterStyle = style91;
            this.cmb_out_no.GapHeight = 2;
            this.cmb_out_no.HeadingStyle = style92;
            this.cmb_out_no.HighLightRowStyle = style93;
            this.cmb_out_no.ItemHeight = 15;
            this.cmb_out_no.Location = new System.Drawing.Point(109, 58);
            this.cmb_out_no.MatchEntryTimeout = ((long)(2000));
            this.cmb_out_no.MaxDropDownItems = ((short)(5));
            this.cmb_out_no.MaxLength = 32767;
            this.cmb_out_no.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_out_no.Name = "cmb_out_no";
            this.cmb_out_no.OddRowStyle = style94;
            this.cmb_out_no.PartialRightColumn = false;
            this.cmb_out_no.PropBag = resources.GetString("cmb_out_no.PropBag");
            this.cmb_out_no.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_out_no.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_out_no.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_out_no.SelectedStyle = style95;
            this.cmb_out_no.Size = new System.Drawing.Size(130, 21);
            this.cmb_out_no.Style = style96;
            this.cmb_out_no.TabIndex = 359;
            this.cmb_out_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmb_out_no.SelectedValueChanged += new System.EventHandler(this.cmb_out_no_SelectedValueChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 54);
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
            this.pictureBox8.Location = new System.Drawing.Point(150, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1000, 47);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 72);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(144, 71);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
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
            this.pictureBox9.Size = new System.Drawing.Size(1000, 47);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // flg_out
            // 
            this.flg_out.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.flg_out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flg_out.AutoResize = false;
            this.flg_out.BackColor = System.Drawing.SystemColors.Window;
            this.flg_out.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flg_out.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.flg_out.ContextMenuStrip = this.ct_mnu;
            this.flg_out.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flg_out.ForeColor = System.Drawing.SystemColors.WindowText;
            this.flg_out.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.flg_out.Location = new System.Drawing.Point(8, 174);
            this.flg_out.Name = "flg_out";
            this.flg_out.Rows.Fixed = 0;
            this.flg_out.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.flg_out.Size = new System.Drawing.Size(1000, 471);
            this.flg_out.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("flg_out.Styles"));
            this.flg_out.TabIndex = 323;
            this.flg_out.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.flg_out_AfterEdit);
            this.flg_out.Click += new System.EventHandler(this.flg_out_Click);
            // 
            // ct_mnu
            // 
            this.ct_mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_mat,
            this.mnu_bom,
            this.toolStripSeparator1,
            this.mnu_insert,
            this.mnu_delete});
            this.ct_mnu.Name = "ct_mnu";
            this.ct_mnu.Size = new System.Drawing.Size(156, 120);
            // 
            // mnu_mat
            // 
            this.mnu_mat.Name = "mnu_mat";
            this.mnu_mat.Size = new System.Drawing.Size(155, 22);
            this.mnu_mat.Text = "Material";
            this.mnu_mat.Click += new System.EventHandler(this.mnu_mat_Click);
            // 
            // mnu_bom
            // 
            this.mnu_bom.Name = "mnu_bom";
            this.mnu_bom.Size = new System.Drawing.Size(155, 22);
            this.mnu_bom.Text = "BOM";
            this.mnu_bom.Click += new System.EventHandler(this.mnu_bom_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // mnu_insert
            // 
            this.mnu_insert.Name = "mnu_insert";
            this.mnu_insert.Size = new System.Drawing.Size(155, 22);
            this.mnu_insert.Text = "Insert Record";
            this.mnu_insert.Click += new System.EventHandler(this.mnu_insert_Click);
            // 
            // mnu_delete
            // 
            this.mnu_delete.Name = "mnu_delete";
            this.mnu_delete.Size = new System.Drawing.Size(155, 22);
            this.mnu_delete.Text = "Delete Record";
            this.mnu_delete.Click += new System.EventHandler(this.mnu_delete_Click);
            // 
            // Form_Outgoing
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.flg_out);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_Outgoing";
            this.Load += new System.EventHandler(this.Form_Outgoing_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.flg_out, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_out_div)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_out_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flg_out)).EndInit();
            this.ct_mnu.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        #region 사용자 정의 변수
        private int _RowFixed;
        private int tree_level;
        private COM.OraDB MyOraDB = new COM.OraDB();
        #endregion

        private void Form_Outgoing_Load(object sender, System.EventArgs e)
		{
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, 0, 150);
			//ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
        }

        #region 공통 메서드
        private void Init_Form()
        {
            #region Title Setting
            this.Text               = "PCC_Outgoing Manager";
			this.lbl_MainTitle.Text = "PCC_Outgoing Manager";
			ClassLib.ComFunction.SetLangDic(this);
            #endregion

            #region ComboBox Setting
            //Status
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_Outgoing_status);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2, true, 0, 130);
			cmb_status.SelectedIndex = 0;
			//cmb_status.Enabled = false;

			//Date			
			dpk_out_date.Value = DateTime.Now;
            
			//Outgoing Division
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_Outgoing_div);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_out_div, 1, 2, true, 0, 130);
			cmb_out_div.SelectedIndex = 0;
            #endregion

            #region Grid Setting
            flg_out.Set_Grid_CDC("SXO_OUT_TAIL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			flg_out.Set_Action_Image(img_Action);
			//flg_out.ExtendLastCol = false;
			_RowFixed = flg_out.Rows.Count;
            flg_out.Tree.Column = (int)ClassLib.TBSXO_OUT_LIST.IxITEM_01;		
            #endregion

            #region TextBox Setting
            txt_mat_name.CharacterCasing = CharacterCasing.Upper;
            txt_color_name.CharacterCasing = CharacterCasing.Upper;
            txt_spec_name.CharacterCasing = CharacterCasing.Upper;

            txt_mat_name.Focus();
            #endregion

            button_control();
        }
        private void get_out_no()
        {
            //Outgoing No Setting
            DataTable dt_ret = Search_out_no(cmb_factory.SelectedValue.ToString(), dpk_out_date.Value.ToString("yyyyMMdd"), cmb_out_div.SelectedValue.ToString());
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_out_no, 0, 1, true, 0, 200);
            cmb_out_no.SelectedIndex = 0;
        }
        private void button_control()
        {

            if (cmb_status.SelectedIndex.Equals(2))
            {
                               
                tbtn_Confirm.Enabled = true;
                
            }
            else
            {                
                tbtn_Confirm.Enabled = false;
            }

            if (cmb_out_no.SelectedIndex.Equals(0))
            {
                tbtn_Create.Enabled = true;
                tbtn_Delete.Enabled = false;
            }
            else
            {
                tbtn_Create.Enabled = false;
                tbtn_Delete.Enabled = true;
            }

            tbtn_Save.Enabled = true;                  
            

            tbtn_New.Enabled = true;            
            tbtn_Print.Enabled = false;
        }
        private void display_data(int arg_row, int arg_tree_level)
        {

            if (arg_row != 0)
            {
                                 
            }

            string out_no = cmb_out_no.SelectedValue.ToString();

            //Outgoing No Setting
            DataTable dt_ret = Search_out_no(cmb_factory.SelectedValue.ToString(), dpk_out_date.Value.ToString("yyyyMMdd"), cmb_out_div.SelectedValue.ToString());
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_out_no, 0, 1, true, 0, 200);
            cmb_out_no.SelectedValue = out_no;

            flg_out.Select(flg_out.Selection.r1, 0, flg_out.Selection.r1, flg_out.Cols.Count - 1, false);//행 수정 상태 해제
            flg_out.Rows.Count = _RowFixed;//Grid 초기화

            //조회 조건
            string arg_factory    = cmb_factory.SelectedValue.ToString();
            string arg_out_ymd    = dpk_out_date.Value.ToString("yyyyMMdd");
            string arg_out_no     = cmb_out_no.SelectedValue.ToString();
            string arg_out_div    = cmb_out_div.SelectedValue.ToString();
            string arg_mat_name   = txt_mat_name.Text.Trim().ToUpper();
            string arg_color_name = txt_color_name.Text.Trim().ToUpper();
            string arg_spec_name  = txt_spec_name.Text.Trim().ToUpper();
            string arg_status     = cmb_status.SelectedValue.ToString();
            //DB Connect
            DataTable dt_list = Search_out_tail(arg_factory, arg_out_ymd, arg_out_no, arg_out_div, arg_mat_name, arg_color_name, arg_spec_name, arg_status);

            #region Display Datalist

            for (int i = 0; i < dt_list.Rows.Count; i++)
            {

                int tree_level = int.Parse(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_OUT_LIST.IxLEVEL].ToString());
                string status  = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_OUT_LIST.IxSTATUS].ToString();
                flg_out.Rows.InsertNode(flg_out.Rows.Count, tree_level);

                #region Level에 따른 Grid Edit & BackColor 설정
                if (tree_level == 1)
                {                                             
                    flg_out.Rows[flg_out.Rows.Count - 1].AllowEditing = true;                        
                    flg_out.Rows[flg_out.Rows.Count - 1].StyleNew.BackColor = Color.White;                        
                }
                else if (tree_level == 2)
                {
                    flg_out.Rows[flg_out.Rows.Count - 1].AllowEditing = false;
                    flg_out.Rows[flg_out.Rows.Count - 1].StyleNew.BackColor = Color.Beige;
                }
                #endregion

                for (int j = 0; j < dt_list.Columns.Count; j++)
                {
                    flg_out[flg_out.Rows.Count - 1, j] = dt_list.Rows[i].ItemArray[j].ToString();
                }                  

            }
            #endregion

            flg_out.Tree.Show(arg_tree_level); 
        }
        #endregion

        #region 이벤트 처리

        #region tbtn Button Event
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            flg_out.Rows.Count = flg_out.Rows.Fixed;

            cmb_out_div.SelectedIndex = 0;
            cmb_out_no.SelectedIndex = 0;
            cmb_status.SelectedIndex = 0;

            txt_mat_name.Clear();
            txt_spec_name.Clear();
            txt_color_name.Clear();
        }
        private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string factory = cmb_factory.SelectedValue.ToString();
                string req_ymd = dpk_out_date.Value.ToString("yyyyMMdd");
                
                create_req_out(factory, req_ymd);

                get_out_no();
                tbtn_Search_Click(null, null);
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
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                display_data(0, 1);
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
        }
        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string factory    = cmb_factory.SelectedValue.ToString();
                string out_ymd    = dpk_out_date.Value.ToString("yyyyMMdd");
                string status = cmb_status.SelectedValue.ToString();
                string out_no = cmb_out_no.SelectedValue.ToString();

                delete_sxo_out(factory, out_ymd, status, out_no);

                cmb_out_no.SelectedIndex = 0;
                display_data(0,1);
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
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                flg_out.Select(flg_out.Selection.r1, 0, flg_out.Selection.r1, flg_out.Cols.Count - 1, false);//행 수정 상태 해제

                int last_row = 0;
                for (int i = _RowFixed; i < flg_out.Rows.Count; i++)
                {
                    if (flg_out[i, (int)ClassLib.TBSXO_OUT_TAIL.IxDIVISION].ToString().Trim().Length > 0)
                    {
                        //수정 데이터
                        string arg_division   = flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxDIVISION].ToString(); 
                        string arg_factory    = flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxFACTORY].ToString();                        
                        string arg_out_no     = flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxOUT_NO].ToString();
                        string arg_mat_cd     = flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxMAT_CD].ToString();
                        string arg_spec_cd    = flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxPCC_SPEC_CD].ToString();
                        string arg_color_cd   = flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxCOLOR_CD].ToString();
                        string arg_value_prod = flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxPROD_YIELD].ToString();
                        string arg_value_out  = flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxOUT_VALUE].ToString();
                        string arg_value_in   = flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxIN_VALUE].ToString();
                        string arg_value_real = Convert.ToString( int.Parse(arg_value_out) - int.Parse(arg_value_in) );
                        string arg_remarks    = flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxREMARKS].ToString();

                        //Product Value Check
                        if (arg_value_prod == "0")
                        {
                            MessageBox.Show("Check Prod.Value");
                            flg_out.Select(i, (int)ClassLib.TBSXO_OUT_LIST.IxPROD_YIELD);
                            return;
                        }


                        update_out_tail(arg_division, arg_factory, arg_out_no, arg_mat_cd, arg_spec_cd, arg_color_cd, arg_value_prod, arg_value_out, arg_value_in, arg_value_real, arg_remarks);
                        last_row = i;
                    }
                }

                //수정 후 조회                
               display_data(last_row, tree_level);
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSave, this);	
            }
        }
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                for (int i = flg_out.Rows.Fixed; i < flg_out.Rows.Count; i++)
                {
                    if (flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxLEVEL].ToString() == "1" && flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxSTATUS].ToString() == "Y")
                    {
                        if (flg_out[i, (int)ClassLib.TBSXO_OUT_LIST.IxREAL_VALUE].ToString() == "0")
                        {
                            MessageBox.Show("Check Value Real");
                            flg_out.Select(i, (int)ClassLib.TBSXO_OUT_LIST.IxREAL_VALUE);
                            return;
                        }
                    }
                }

                confirm_out(cmb_factory.SelectedValue.ToString(), dpk_out_date.Value.ToString("yyyyMMdd"), cmb_out_no.SelectedValue.ToString());
                
                tbtn_Search_Click(null, null);
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndRun, this);	
            }
        }
        #endregion

        #region Control Event
        private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (cmb_factory.SelectedIndex == -1) return;
            COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
            Init_Form();
        }
        private void cmb_status_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_status.SelectedIndex == -1) return;
            button_control();
        }
        private void dpk_out_date_CloseUp(object sender, System.EventArgs e)
        {
            get_out_no();
        }
        private void cmb_out_div_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (cmb_out_div.SelectedIndex == -1) return;            
            get_out_no();
        }
        private void cmb_out_no_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (cmb_out_no.SelectedIndex == -1) return;
            button_control();
        }        
        #endregion

        #region Grid Event
        private void flg_out_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            int sct_row = flg_out.Selection.r1;
            int sct_col = flg_out.Selection.c1;
            flg_out.Update_Row(sct_row);
        }
        private void flg_out_Click(object sender, EventArgs e)
        {
            int sct_row = flg_out.Selection.r1;

            if (sct_row <= 0)
            {
                mnu_insert.Visible = true;
                mnu_delete.Visible = false;
            }
            else
            {
                if (flg_out[sct_row, (int)ClassLib.TBSXO_OUT_LIST.IxSTATUS].ToString() == "C")
                {
                    mnu_insert.Visible = false;
                    mnu_delete.Visible = false;
                }
                else
                {
                    mnu_insert.Visible = true;
                    mnu_delete.Visible = true;
                }
                if (flg_out[sct_row, (int)ClassLib.TBSXO_OUT_LIST.IxLEVEL].ToString() == "2")
                {
                    mnu_insert.Visible = false;
                    mnu_delete.Visible = false;
                }
            }

            

        }
        
        #endregion

        #region Context Menu Event
        private void mnu_insert_Click(object sender, EventArgs e)
        {
            int sct_row = flg_out.Selection.r1;

            flg_out.Tree.Show(2);
            string arg_out_no = (sct_row <= 0) ? "" : flg_out[sct_row, (int)ClassLib.TBSXO_OUT_LIST.IxOUT_NO_V].ToString();

            BaseInfo.Pop_Material_Master codeMaster = new FlexCDC.BaseInfo.Pop_Material_Master("O", arg_out_no, this);
            codeMaster.ShowDialog();
        }
        private void mnu_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int[] sct_rows = flg_out.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    if (flg_out[sct_rows[i], (int)ClassLib.TBSXO_OUT_LIST.IxLEVEL].Equals("1") && flg_out[sct_rows[i], (int)ClassLib.TBSXO_OUT_LIST.IxSTATUS].ToString() != "C")
                    {
                        if (flg_out[sct_rows[i], (int)ClassLib.TBSXO_OUT_LIST.IxDIVISION].ToString() == "D")
                            flg_out[sct_rows[i], (int)ClassLib.TBSXO_OUT_LIST.IxDIVISION] = "";
                        else
                            flg_out.Delete_Row(sct_rows[i]);
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
        private void mnu_mat_Click(object sender, EventArgs e)
        {
            flg_out.Tree.Show(1);
            tree_level = 1;
        }
        private void mnu_bom_Click(object sender, EventArgs e)
        {
            flg_out.Tree.Show(2);
            tree_level = 2;
        }
        #endregion

        #endregion

        #region DB Connect
        private void create_req_out(string arg_factory, string arg_req_ymd)
        {
            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXO_OUT_01.CREATE_REQ_OUT";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_REQ_YMD";            
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;            

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_req_ymd;            
            MyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure(); 
        }
        private DataTable Search_out_no(string arg_factory, string arg_out_ymd, string arg_out_div)
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXO_OUT_01_SELECT.SELECT_OUT_NO";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_OUT_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_OUT_DIV";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_out_ymd;
            MyOraDB.Parameter_Values[2] = arg_out_div;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_Search = MyOraDB.Exe_Select_Procedure();

            return ds_Search.Tables[MyOraDB.Process_Name];

        }
        private DataTable Search_out_tail(string arg_factory, string arg_out_ymd, string arg_out_no, string arg_out_div, string arg_mat_name, string arg_color_name, string arg_spce_name, string arg_status)
		{
			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXO_OUT_01_SELECT.SELECT_OUT_TAIL" ; 

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_NO";
			MyOraDB.Parameter_Name[3] = "ARG_OUT_DIV";
			MyOraDB.Parameter_Name[4] = "ARG_MAT_NAME";
			MyOraDB.Parameter_Name[5] = "ARG_COLOR_NAME";
			MyOraDB.Parameter_Name[6] = "ARG_SPEC_NAME";
			MyOraDB.Parameter_Name[7] = "ARG_STATUS";
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

			//03. DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor; 

			//04. DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_out_ymd;
			MyOraDB.Parameter_Values[2] = arg_out_no;
			MyOraDB.Parameter_Values[3] = arg_out_div;
			MyOraDB.Parameter_Values[4] = arg_mat_name;
			MyOraDB.Parameter_Values[5] = arg_color_name;
			MyOraDB.Parameter_Values[6] = arg_spce_name;
			MyOraDB.Parameter_Values[7] = arg_status;
			MyOraDB.Parameter_Values[8] = "";

			MyOraDB.Add_Select_Parameter(true);
            DataSet ds_Search = MyOraDB.Exe_Select_Procedure();	

			return ds_Search.Tables[MyOraDB.Process_Name];
        }


        private void update_out_tail(string arg_division, string arg_factory, string arg_out_no, string arg_mat_cd, string arg_spec_cd, string arg_color_cd, string arg_value_prod, string arg_value_out, string arg_value_in, string arg_value_real, string arg_remarks)
        {

            MyOraDB.ReDim_Parameter(12);
            
            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXO_OUT_01.UPDATE_SXO_OUT"; ;
            
            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
            MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
            MyOraDB.Parameter_Name[2]  = "ARG_OUT_NO";
            MyOraDB.Parameter_Name[3]  = "ARG_MAT_CD";
            MyOraDB.Parameter_Name[4]  = "ARG_SPEC_CD";
            MyOraDB.Parameter_Name[5]  = "ARG_COLOR_CD";
            MyOraDB.Parameter_Name[6] = "ARG_VALUE_PROD";
            MyOraDB.Parameter_Name[7]  = "ARG_VALUE_OUT";
            MyOraDB.Parameter_Name[8]  = "ARG_VALUE_IN";
            MyOraDB.Parameter_Name[9]  = "ARG_VALUE_REAL";            
            MyOraDB.Parameter_Name[10]  = "ARG_REMARKS";
            MyOraDB.Parameter_Name[11] = "ARG_UPD_USER";
            
            //03. DATA TYPE 정의
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
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0]  = arg_division;
            MyOraDB.Parameter_Values[1]  = arg_factory;
            MyOraDB.Parameter_Values[2]  = arg_out_no;
            MyOraDB.Parameter_Values[3]  = arg_mat_cd;
            MyOraDB.Parameter_Values[4]  = arg_spec_cd;
            MyOraDB.Parameter_Values[5]  = arg_color_cd;
            MyOraDB.Parameter_Values[6]  = arg_value_prod;
            MyOraDB.Parameter_Values[7]  = arg_value_out;
            MyOraDB.Parameter_Values[8]  = arg_value_in;
            MyOraDB.Parameter_Values[9]  = arg_value_real;
            MyOraDB.Parameter_Values[10]  = arg_remarks;
            MyOraDB.Parameter_Values[11] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        private void delete_sxo_out(string arg_factory, string arg_out_ymd, string arg_status, string arg_out_no)
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXO_OUT_01.DELETE_SXO_OUT";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_OUT_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_STATUS";
            MyOraDB.Parameter_Name[3] = "ARG_OUT_NO";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_out_ymd;
            MyOraDB.Parameter_Values[2] = arg_status;
            MyOraDB.Parameter_Values[3] = arg_out_no;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        private void confirm_out(string arg_factory, string arg_cnf_ymd, string arg_out_no)
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXO_OUT_01.CONFIRM_OUT";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_CNF_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_OUT_NO";
            MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_cnf_ymd;
            MyOraDB.Parameter_Values[2] = arg_out_no;
            MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion    

                
	}
}

