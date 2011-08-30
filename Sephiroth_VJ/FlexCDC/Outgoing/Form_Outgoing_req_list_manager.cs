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
	public class Form_Outgoing_req_list_manager : COM.PCHWinForm.Form_Top
    {
        #region 컨트롤 정의 및 리소스 정의
        public COM.FSP flg_out_req;
		private System.ComponentModel.IContainer components = null;        
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        public Panel pnl_SearchImage;
        public C1.Win.C1List.C1Combo cmb_req_div;
        private Label lbl_req_div;
        public PictureBox picb_TM;
        public Label lbl_title;
        private Label btn_openfile;
        public PictureBox picb_MR;
        public PictureBox pictureBox2;
        public PictureBox pictureBox4;
        public PictureBox pictureBox5;
        public PictureBox pictureBox6;
        public PictureBox pictureBox7;
        public PictureBox pictureBox8;
        public PictureBox pictureBox9;
        private Label lbl_factory;
        private Label lbl_req_reason;
        private TextBox txt_bom_id;
        private TextBox txt_mat_name;
        private Label lbl_srf_no;
        private TextBox txt_srf_no;
        private C1.Win.C1List.C1Combo cmb_factory;
        private Label lbl_sr_no;
        private TextBox txt_sr_no;
        public Panel pnl_Top;
        private Label lbl_bom_id;
        private DateTimePicker dpk_req_date;
        private Label lbl_req_date;
        private C1.Win.C1List.C1Combo cmb_sampletype;
        private Label lbl_sampletype;		

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Outgoing_req_list_manager));
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
            C1.Win.C1List.Style style97 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style98 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style99 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style100 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style101 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style102 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style103 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style104 = new C1.Win.C1List.Style();
            this.flg_out_req = new COM.FSP();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.btn_openfile = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_req_div = new System.Windows.Forms.Label();
            this.cmb_req_div = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_req_reason = new System.Windows.Forms.Label();
            this.txt_bom_id = new System.Windows.Forms.TextBox();
            this.txt_mat_name = new System.Windows.Forms.TextBox();
            this.lbl_srf_no = new System.Windows.Forms.Label();
            this.txt_srf_no = new System.Windows.Forms.TextBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_sr_no = new System.Windows.Forms.Label();
            this.txt_sr_no = new System.Windows.Forms.TextBox();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_bom_id = new System.Windows.Forms.Label();
            this.dpk_req_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_req_date = new System.Windows.Forms.Label();
            this.cmb_sampletype = new C1.Win.C1List.C1Combo();
            this.lbl_sampletype = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flg_out_req)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletype)).BeginInit();
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
            // flg_out_req
            // 
            this.flg_out_req.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.flg_out_req.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flg_out_req.AutoResize = false;
            this.flg_out_req.BackColor = System.Drawing.SystemColors.Window;
            this.flg_out_req.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flg_out_req.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.flg_out_req.ContextMenu = this.contextMenu1;
            this.flg_out_req.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flg_out_req.ForeColor = System.Drawing.SystemColors.WindowText;
            this.flg_out_req.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.flg_out_req.Location = new System.Drawing.Point(8, 180);
            this.flg_out_req.Name = "flg_out_req";
            this.flg_out_req.Rows.Fixed = 0;
            this.flg_out_req.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.flg_out_req.Size = new System.Drawing.Size(1002, 460);
            this.flg_out_req.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("flg_out_req.Styles"));
            this.flg_out_req.TabIndex = 322;
            this.flg_out_req.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.flg_out_req_AfterEdit);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Material";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click_1);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "BOM";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click_1);
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.cmb_sampletype);
            this.pnl_SearchImage.Controls.Add(this.cmb_req_div);
            this.pnl_SearchImage.Controls.Add(this.lbl_sampletype);
            this.pnl_SearchImage.Controls.Add(this.lbl_req_div);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.btn_openfile);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
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
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 92);
            this.pnl_SearchImage.TabIndex = 18;
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
            this.pictureBox9.Size = new System.Drawing.Size(1000, 52);
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
            this.pictureBox8.Size = new System.Drawing.Size(1000, 52);
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
            this.pictureBox7.Size = new System.Drawing.Size(168, 59);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 77);
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
            this.pictureBox5.Location = new System.Drawing.Point(144, 76);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 77);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
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
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(983, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 49);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
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
            this.lbl_title.Text = "      Request Information";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lbl_req_div
            // 
            this.lbl_req_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req_div.ImageIndex = 0;
            this.lbl_req_div.ImageList = this.img_Label;
            this.lbl_req_div.Location = new System.Drawing.Point(504, 36);
            this.lbl_req_div.Name = "lbl_req_div";
            this.lbl_req_div.Size = new System.Drawing.Size(100, 21);
            this.lbl_req_div.TabIndex = 319;
            this.lbl_req_div.Text = "Req Div.";
            this.lbl_req_div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_req_div
            // 
            this.cmb_req_div.AddItemCols = 0;
            this.cmb_req_div.AddItemSeparator = ';';
            this.cmb_req_div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_req_div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_req_div.Caption = "";
            this.cmb_req_div.CaptionHeight = 17;
            this.cmb_req_div.CaptionStyle = style105;
            this.cmb_req_div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_req_div.ColumnCaptionHeight = 18;
            this.cmb_req_div.ColumnFooterHeight = 18;
            this.cmb_req_div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_req_div.ContentHeight = 17;
            this.cmb_req_div.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_req_div.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_req_div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_div.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_req_div.EditorHeight = 17;
            this.cmb_req_div.EvenRowStyle = style106;
            this.cmb_req_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_div.FooterStyle = style107;
            this.cmb_req_div.GapHeight = 2;
            this.cmb_req_div.HeadingStyle = style108;
            this.cmb_req_div.HighLightRowStyle = style109;
            this.cmb_req_div.ItemHeight = 15;
            this.cmb_req_div.Location = new System.Drawing.Point(605, 36);
            this.cmb_req_div.MatchEntryTimeout = ((long)(2000));
            this.cmb_req_div.MaxDropDownItems = ((short)(5));
            this.cmb_req_div.MaxLength = 32767;
            this.cmb_req_div.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_req_div.Name = "cmb_req_div";
            this.cmb_req_div.OddRowStyle = style110;
            this.cmb_req_div.PartialRightColumn = false;
            this.cmb_req_div.PropBag = resources.GetString("cmb_req_div.PropBag");
            this.cmb_req_div.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_req_div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_req_div.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_req_div.SelectedStyle = style111;
            this.cmb_req_div.Size = new System.Drawing.Size(120, 21);
            this.cmb_req_div.Style = style112;
            this.cmb_req_div.TabIndex = 320;
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 36);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 271;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_req_reason
            // 
            this.lbl_req_reason.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_req_reason.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req_reason.ImageIndex = 0;
            this.lbl_req_reason.ImageList = this.img_Label;
            this.lbl_req_reason.Location = new System.Drawing.Point(752, 59);
            this.lbl_req_reason.Name = "lbl_req_reason";
            this.lbl_req_reason.Size = new System.Drawing.Size(100, 21);
            this.lbl_req_reason.TabIndex = 327;
            this.lbl_req_reason.Text = "Mat. Name";
            this.lbl_req_reason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_bom_id
            // 
            this.txt_bom_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_bom_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bom_id.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_bom_id.ForeColor = System.Drawing.Color.Black;
            this.txt_bom_id.Location = new System.Drawing.Point(357, 59);
            this.txt_bom_id.MaxLength = 100;
            this.txt_bom_id.Name = "txt_bom_id";
            this.txt_bom_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_bom_id.Size = new System.Drawing.Size(120, 20);
            this.txt_bom_id.TabIndex = 353;
            // 
            // txt_mat_name
            // 
            this.txt_mat_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mat_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mat_name.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_mat_name.ForeColor = System.Drawing.Color.Black;
            this.txt_mat_name.Location = new System.Drawing.Point(853, 59);
            this.txt_mat_name.MaxLength = 100;
            this.txt_mat_name.Name = "txt_mat_name";
            this.txt_mat_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_mat_name.Size = new System.Drawing.Size(120, 20);
            this.txt_mat_name.TabIndex = 354;
            // 
            // lbl_srf_no
            // 
            this.lbl_srf_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srf_no.ImageIndex = 0;
            this.lbl_srf_no.ImageList = this.img_Label;
            this.lbl_srf_no.Location = new System.Drawing.Point(16, 59);
            this.lbl_srf_no.Name = "lbl_srf_no";
            this.lbl_srf_no.Size = new System.Drawing.Size(100, 21);
            this.lbl_srf_no.TabIndex = 356;
            this.lbl_srf_no.Text = "SRF No";
            this.lbl_srf_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_srf_no
            // 
            this.txt_srf_no.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_srf_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_srf_no.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_srf_no.ForeColor = System.Drawing.Color.Black;
            this.txt_srf_no.Location = new System.Drawing.Point(117, 59);
            this.txt_srf_no.MaxLength = 100;
            this.txt_srf_no.Name = "txt_srf_no";
            this.txt_srf_no.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_srf_no.Size = new System.Drawing.Size(120, 20);
            this.txt_srf_no.TabIndex = 357;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style113;
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
            this.cmb_factory.EvenRowStyle = style114;
            this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style115;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style116;
            this.cmb_factory.HighLightRowStyle = style117;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(117, 36);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style118;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style119;
            this.cmb_factory.Size = new System.Drawing.Size(120, 21);
            this.cmb_factory.Style = style120;
            this.cmb_factory.TabIndex = 358;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // lbl_sr_no
            // 
            this.lbl_sr_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sr_no.ImageIndex = 0;
            this.lbl_sr_no.ImageList = this.img_Label;
            this.lbl_sr_no.Location = new System.Drawing.Point(752, 36);
            this.lbl_sr_no.Name = "lbl_sr_no";
            this.lbl_sr_no.Size = new System.Drawing.Size(100, 21);
            this.lbl_sr_no.TabIndex = 359;
            this.lbl_sr_no.Text = "SR No";
            this.lbl_sr_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sr_no
            // 
            this.txt_sr_no.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_sr_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sr_no.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_sr_no.ForeColor = System.Drawing.Color.Black;
            this.txt_sr_no.Location = new System.Drawing.Point(853, 36);
            this.txt_sr_no.MaxLength = 100;
            this.txt_sr_no.Name = "txt_sr_no";
            this.txt_sr_no.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_sr_no.Size = new System.Drawing.Size(120, 20);
            this.txt_sr_no.TabIndex = 360;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.dpk_req_date);
            this.pnl_Top.Controls.Add(this.lbl_req_date);
            this.pnl_Top.Controls.Add(this.lbl_bom_id);
            this.pnl_Top.Controls.Add(this.txt_sr_no);
            this.pnl_Top.Controls.Add(this.lbl_sr_no);
            this.pnl_Top.Controls.Add(this.cmb_factory);
            this.pnl_Top.Controls.Add(this.txt_srf_no);
            this.pnl_Top.Controls.Add(this.lbl_srf_no);
            this.pnl_Top.Controls.Add(this.txt_mat_name);
            this.pnl_Top.Controls.Add(this.txt_bom_id);
            this.pnl_Top.Controls.Add(this.lbl_req_reason);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 80);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 100);
            this.pnl_Top.TabIndex = 138;
            // 
            // lbl_bom_id
            // 
            this.lbl_bom_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bom_id.ImageIndex = 0;
            this.lbl_bom_id.ImageList = this.img_Label;
            this.lbl_bom_id.Location = new System.Drawing.Point(256, 59);
            this.lbl_bom_id.Name = "lbl_bom_id";
            this.lbl_bom_id.Size = new System.Drawing.Size(100, 21);
            this.lbl_bom_id.TabIndex = 361;
            this.lbl_bom_id.Text = "BOM ID";
            this.lbl_bom_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpk_req_date
            // 
            this.dpk_req_date.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_req_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_req_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_req_date.Location = new System.Drawing.Point(357, 36);
            this.dpk_req_date.Name = "dpk_req_date";
            this.dpk_req_date.Size = new System.Drawing.Size(120, 22);
            this.dpk_req_date.TabIndex = 363;
            this.dpk_req_date.Value = new System.DateTime(2007, 11, 19, 14, 18, 56, 968);
            // 
            // lbl_req_date
            // 
            this.lbl_req_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req_date.ImageIndex = 0;
            this.lbl_req_date.ImageList = this.img_Label;
            this.lbl_req_date.Location = new System.Drawing.Point(256, 36);
            this.lbl_req_date.Name = "lbl_req_date";
            this.lbl_req_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_req_date.TabIndex = 362;
            this.lbl_req_date.Text = "Req Date";
            this.lbl_req_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_sampletype
            // 
            this.cmb_sampletype.AddItemCols = 0;
            this.cmb_sampletype.AddItemSeparator = ';';
            this.cmb_sampletype.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
            this.cmb_sampletype.GapHeight = 2;
            this.cmb_sampletype.HeadingStyle = style100;
            this.cmb_sampletype.HighLightRowStyle = style101;
            this.cmb_sampletype.ItemHeight = 15;
            this.cmb_sampletype.Location = new System.Drawing.Point(605, 59);
            this.cmb_sampletype.MatchEntryTimeout = ((long)(2000));
            this.cmb_sampletype.MaxDropDownItems = ((short)(5));
            this.cmb_sampletype.MaxLength = 32767;
            this.cmb_sampletype.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sampletype.Name = "cmb_sampletype";
            this.cmb_sampletype.OddRowStyle = style102;
            this.cmb_sampletype.PartialRightColumn = false;
            this.cmb_sampletype.PropBag = resources.GetString("cmb_sampletype.PropBag");
            this.cmb_sampletype.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sampletype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sampletype.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sampletype.SelectedStyle = style103;
            this.cmb_sampletype.Size = new System.Drawing.Size(120, 21);
            this.cmb_sampletype.Style = style104;
            this.cmb_sampletype.TabIndex = 365;
            // 
            // lbl_sampletype
            // 
            this.lbl_sampletype.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sampletype.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sampletype.ImageIndex = 0;
            this.lbl_sampletype.ImageList = this.img_Label;
            this.lbl_sampletype.Location = new System.Drawing.Point(504, 59);
            this.lbl_sampletype.Name = "lbl_sampletype";
            this.lbl_sampletype.Size = new System.Drawing.Size(100, 21);
            this.lbl_sampletype.TabIndex = 364;
            this.lbl_sampletype.Tag = "1";
            this.lbl_sampletype.Text = "Sample Types";
            this.lbl_sampletype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Outgoing_req_list_manager
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.flg_out_req);
            this.Name = "Form_Outgoing_req_list_manager";
            this.Load += new System.EventHandler(this.Form_Outgoing_req_list_Load);
            this.Controls.SetChildIndex(this.flg_out_req, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flg_out_req)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletype)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #region 사용자 정의 변수
        private int show_lev = 0;
        private string req_no = null;
        private int _RowFixed = 0;
        private COM.OraDB OraDB = new COM.OraDB();
        #endregion

        #region 생성자
        public Form_Outgoing_req_list_manager()
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }
        #endregion

        #region Form Loading
        private void Form_Outgoing_req_list_Load(object sender, System.EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;            
        }
        private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (cmb_factory.SelectedIndex == -1) return;
            COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
            Init_Form();
        }

        private void Init_Form()
        {
            #region Title Setting
            this.Text = "PCC_Request Manager";
            this.lbl_MainTitle.Text = "PCC_Request Manager";
            ClassLib.ComFunction.SetLangDic(this);
            #endregion

            #region ComboBox Setting
            DataTable dt_ret = null;

            dpk_req_date.Value = DateTime.Now;

            //pur master Status
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_OutRequest_Div);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_req_div, 1, 2, true, 0, 120);
            cmb_req_div.SelectedIndex = 0;

            dt_ret = SELECT_ROUND();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletype, 0, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_sampletype.SelectedIndex = 0;           
            #endregion

            #region Grid Event
            flg_out_req.Set_Grid_CDC("SXO_REQ_TAIL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_out_req.Set_Action_Image(img_Action);
            _RowFixed = flg_out_req.Rows.Count;

            flg_out_req.ExtendLastCol = false;
            flg_out_req.Tree.Column = (int)ClassLib.TBSXO_REQ_TAIL.IxCOL3;
            #endregion

            Button_Control();            
        }
        private void Button_Control()
        {
            tbtn_Create.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_New.Enabled    = false;
            tbtn_Color.Enabled  = false;
            tbtn_Append.Enabled = false;
        }

        private DataTable SELECT_ROUND()
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC";

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
        #endregion

        #region Create Data
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            string arg_factory = cmb_factory.SelectedValue.ToString();
            string arg_date = dpk_req_date.Value.ToString("yyyyMMdd");

            GET_REQ_DATA(arg_factory, arg_date);
            tbtn_Search_Click(null, null);
        }

        private void GET_REQ_DATA(string arg_factory, string arg_req_ymd)
        {

            string Proc_Name = "pkg_sxo_out_01.CONFIRM_PROD_REQ_02";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_REQ_YMD";
            OraDB.Parameter_Name[2] = "ARG_UPD_USER";


            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_req_ymd;
            OraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }
        #endregion
        
        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                SAVE_SXO_REQ(cmb_factory.SelectedValue.ToString(), dpk_req_date.Value.ToString("yyyyMMdd"));

                flg_out_req.Rows.Count = _RowFixed;

                string[] arg_value = new string[9];
                
                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = dpk_req_date.Value.ToString("yyyyMMdd");
                arg_value[2] = cmb_req_div.SelectedValue.ToString();
                arg_value[3] = txt_sr_no.Text.Trim();
                arg_value[4] = txt_srf_no.Text.Trim();
                arg_value[5] = txt_bom_id.Text.Trim();
                arg_value[6] = cmb_sampletype.SelectedValue.ToString();
                arg_value[7] = txt_mat_name.Text.Trim();
                arg_value[8] = Search_Condition();

                DataTable dt = SEARCH_DATA(arg_value);

                int dt_rows = dt.Rows.Count;
                int dt_cols = dt.Columns.Count;

                if (dt_rows > 0)
                {
                    for (int i = 0; i < dt_rows; i++)
                    {
                        int t_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXO_REQ_TAIL.IxT_LEV].ToString());
                        flg_out_req.Rows.InsertNode(flg_out_req.Rows.Count, t_level);

                        for (int j = 0; j < dt_cols; j++)
                        {
                            flg_out_req[flg_out_req.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();

                            if (j == (int)ClassLib.TBSXO_REQ_TAIL.IxT_LEV)
                            {
                                if (!dt.Rows[i].ItemArray[j].ToString().Equals("0"))
                                {
                                    flg_out_req.Rows[flg_out_req.Rows.Count - 1].AllowEditing = false;
                                    flg_out_req.Rows[flg_out_req.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
                                }
                            }
                        }
                    }

                    flg_out_req.Tree.Show(show_lev);
                }
            }
            catch
            {

            }
        }

        private string Search_Condition()
        {
            if (!cmb_req_div.SelectedIndex.Equals(0) || txt_sr_no.Text.Trim().Length > 0 || txt_srf_no.Text.Trim().Length > 0 || txt_bom_id.Text.Trim().Length > 0 || !cmb_sampletype.SelectedIndex.Equals(0) || txt_mat_name.Text.Trim().Length > 0)
            {
                return "N";
            }
            else
            {
                return "Y";
            }
        }

        private void SAVE_SXO_REQ(string arg_factory, string arg_req_ymd)
        {

            string Proc_Name = "pkg_sxo_out_01.SAVE_SXO_REQ";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_REQ_YMD";
            OraDB.Parameter_Name[2] = "ARG_UPD_USER";


            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_req_ymd;
            OraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }
        private DataTable SEARCH_DATA(string[] arg_value)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(10);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXO_OUT_01_SELECT.SELECT_REQ_INFO";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_REQ_YMD";
            OraDB.Parameter_Name[2] = "ARG_REQ_DIV";
            OraDB.Parameter_Name[3] = "ARG_SR_NO";
            OraDB.Parameter_Name[4] = "ARG_SRF_NO";
            OraDB.Parameter_Name[5] = "ARG_BOM_ID";
            OraDB.Parameter_Name[6] = "ARG_NF_CD";
            OraDB.Parameter_Name[7] = "ARG_MAT_NAME";
            OraDB.Parameter_Name[8] = "ARG_CONDITION";
            OraDB.Parameter_Name[9] = "OUT_CURSOR";

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
            OraDB.Parameter_Type[9] = (int)OracleType.Cursor;

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
            OraDB.Parameter_Values[9] = "";

            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                flg_out_req.Select(flg_out_req.Selection.r1, 0, flg_out_req.Selection.r1, flg_out_req.Cols.Count - 1, false);

                for (int i = _RowFixed; i < flg_out_req.Rows.Count; i++)
                {
                    if (flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxDIVISION].ToString().Trim().Length > 0)
                    {
                        string arg_out_value = "0";
                        string arg_in_value = "0";
                        string arg_out_yn = "N";

                        try
                        {
                            arg_out_value = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxCOL12].ToString();
                            double tmp_out_value = double.Parse(arg_out_value);
                        }
                        catch
                        {
                            ClassLib.ComFunction.User_Message("Input Error :Wrong Datatype!!", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            flg_out_req.Select(i, (int)ClassLib.TBSXO_REQ_TAIL.IxCOL12);
                            return;
                        }


                        try
                        {
                            arg_in_value = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxCOL13].ToString();
                            double tmp_in_value = double.Parse(arg_in_value);
                        }
                        catch
                        {
                            ClassLib.ComFunction.User_Message("Input Error :Wrong Datatype!!", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            flg_out_req.Select(i, (int)ClassLib.TBSXO_REQ_TAIL.IxCOL12);
                            return;
                        }
                                                
                        if (!arg_out_value.Equals("0") || !arg_in_value.Equals("0"))
                        {
                            arg_out_yn = "Y";
                        }



                        string arg_factory = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxFACTORY].ToString();
                        string arg_req_ymd = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxREQ_YMD].ToString();
                        string arg_lot_no = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxLOT_NO].ToString();
                        string arg_lot_seq = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxLOT_SEQ].ToString();
                        string arg_part_no = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxCOL5].ToString();
                        string arg_mat_cd = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxMAT_CD].ToString();
                        string arg_spec_cd = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxPCC_SPEC_CD].ToString();
                        string arg_clor_cd = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxCOLOR_CD].ToString();
                        string arg_status = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxCOL1].ToString();
                        string arg_edit_lev = flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxT_LEV].ToString();

                        edit_sxo_req(arg_factory, arg_req_ymd, arg_lot_no, arg_lot_seq, arg_part_no, arg_mat_cd, arg_spec_cd, arg_clor_cd, arg_out_yn, arg_out_value, arg_in_value, arg_status, arg_edit_lev);
                    }
                }

                int x_point = flg_out_req.ScrollPosition.X;
                int y_point = flg_out_req.ScrollPosition.Y;

                tbtn_Search_Click(null, null);

                flg_out_req.ScrollPosition = new Point(x_point, y_point);
            }
            catch
            {

            }
        }
        #endregion

        #region 공통 메서드



        private void get_req_status()
        {
            //			DataTable dt_ret = Search_req_status(cmb_factory.SelectedValue.ToString(), cmb_out_no.SelectedValue.ToString());
            //			if(dt_ret.Rows.Count > 0)
            //			{
            //				cmb.Text = dt_ret.Rows[0].ItemArray[0].ToString();
            //			}
            //			else
            //			{
            //				txt_status.Text = "";
            //			}
        }
        #endregion

        #region 이벤트 처리

        #region Tbtn_Button Event
        
        
        
        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                int sct_row = flg_out_req.Selection.r1;
                int sct_col = flg_out_req.Selection.c1;


                if (flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL.IxT_LEV].Equals("1"))
                {
                    flg_out_req.Delete_Row(sct_row);
                }
            }
            catch
            {
 
            }
        }
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                confirm_req_data(cmb_factory.SelectedValue.ToString(), dpk_req_date.Value.ToString("yyyyMMdd"));
                tbtn_Search_Click(null, null);
            }
            catch
            {
 
            }
        }
        #endregion

        #region Control Event
        private void dpk_out_date_CloseUp(object sender, System.EventArgs e)
        {
        }
        
        #endregion

        #region Grid Event
        private void flg_out_req_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            int sct_row = flg_out_req.Selection.r1;
            int sct_col = flg_out_req.Selection.c1;

            if (sct_col.Equals((int)ClassLib.TBSXO_REQ_TAIL.IxOUT_YN))
            {
                for (int i = _RowFixed; i < flg_out_req.Rows.Count; i++)
                {
                    if (flg_out_req.Rows[i].Selected && flg_out_req[i, (int)ClassLib.TBSXO_REQ_TAIL.IxT_LEV].ToString().Equals("0"))
                    {
                        flg_out_req.Update_Row(i);
                    }
                }
            }
            else
            {
                flg_out_req.Update_Row(sct_row);
            }




        }
        #endregion

        #region Context Menu Event
        private void menuItem2_Click_1(object sender, System.EventArgs e)
        {
            show_lev = 1;
            flg_out_req.Tree.Show(show_lev);
        }
        private void menuItem1_Click_1(object sender, System.EventArgs e)
        {
            show_lev = 0;
            flg_out_req.Tree.Show(show_lev);
        }
        #endregion

        #endregion

        #region DB Connect
        private DataTable Search_req_no(string arg_factory, string arg_req_ymd, string arg_req_div)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            OraDB.Process_Name = "pkg_sxo_out_01_select.SELECT_REQ_NO";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_REQ_YMD";
            OraDB.Parameter_Name[2] = "ARG_REQ_DIV";
            OraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_req_ymd;
            OraDB.Parameter_Values[2] = arg_req_div;
            OraDB.Parameter_Values[3] = "";




            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        private DataTable Search_req_status(string arg_factory, string arg_req_no)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "pkg_sxo_out_01_select.SELECT_REQ_STATUS";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_REQ_NO";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_req_no;
            OraDB.Parameter_Values[2] = "";




            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        
        

        private void save_req_tail(string arg_division, string arg_factory, string arg_req_ymd, string arg_req_div, string arg_req_no, string arg_mat_cd, string arg_spec_cd, string arg_clor_cd, string arg_unit_cd, string arg_mcs_cd,
            string arg_out_yn, string arg_out_value, string arg_in_value)
        {

            string Proc_Name = "pkg_sxo_out_01.SAVE_SXO_REQ_IN_OUT_VALUE";

            OraDB.ReDim_Parameter(14);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_DIVISION";
            OraDB.Parameter_Name[1] = "ARG_FACTORY";
            OraDB.Parameter_Name[2] = "ARG_REQ_YMD";
            OraDB.Parameter_Name[3] = "ARG_REQ_DIV";
            OraDB.Parameter_Name[4] = "ARG_REQ_NO";
            OraDB.Parameter_Name[5] = "ARG_MAT_CD";
            OraDB.Parameter_Name[6] = "ARG_SPEC_CD";
            OraDB.Parameter_Name[7] = "ARG_COLOR_CD";
            OraDB.Parameter_Name[8] = "ARG_UNIT_CD";
            OraDB.Parameter_Name[9] = "ARG_MCS_CD";
            OraDB.Parameter_Name[10] = "ARG_OUT_YN";
            OraDB.Parameter_Name[11] = "ARG_OUT_VALUE";
            OraDB.Parameter_Name[12] = "ARG_IN_VALUE";
            OraDB.Parameter_Name[13] = "ARG_UPD_USER";


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

            OraDB.Parameter_Values[0] = arg_division;
            OraDB.Parameter_Values[1] = arg_factory;
            OraDB.Parameter_Values[2] = arg_req_ymd;
            OraDB.Parameter_Values[3] = arg_req_div;
            OraDB.Parameter_Values[4] = arg_req_no;
            OraDB.Parameter_Values[5] = arg_mat_cd;
            OraDB.Parameter_Values[6] = arg_spec_cd;
            OraDB.Parameter_Values[7] = arg_clor_cd;
            OraDB.Parameter_Values[8] = arg_unit_cd;
            OraDB.Parameter_Values[9] = arg_mcs_cd;
            OraDB.Parameter_Values[10] = arg_out_yn;
            OraDB.Parameter_Values[11] = arg_out_value;
            OraDB.Parameter_Values[12] = arg_in_value;
            OraDB.Parameter_Values[13] = ClassLib.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }
        private void edit_sxo_req(string arg_factory, string arg_req_ymd, string arg_lot_no, string arg_lot_seq, string arg_part_no, string arg_mat_cd, string arg_spec_cd, string arg_clor_cd, string arg_out_yn, string arg_out_value,
            string arg_in_value, string arg_status, string arg_edit_lev)
        {

            string Proc_Name = "PKG_SXO_OUT_01.EDIT_SXO_REQ";

            OraDB.ReDim_Parameter(14);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_REQ_YMD";
            OraDB.Parameter_Name[2] = "ARG_LOT_NO";
            OraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[4] = "ARG_PART_NO";
            OraDB.Parameter_Name[5] = "ARG_MAT_CD";
            OraDB.Parameter_Name[6] = "ARG_SPEC_CD";
            OraDB.Parameter_Name[7] = "ARG_COLOR_CD";
            OraDB.Parameter_Name[8] = "ARG_OUT_YN";
            OraDB.Parameter_Name[9] = "ARG_OUT_VALUE";
            OraDB.Parameter_Name[10] = "ARG_IN_VALUE";
            OraDB.Parameter_Name[11] = "ARG_STATUS";
            OraDB.Parameter_Name[12] = "ARG_EDIT_LEV";
            OraDB.Parameter_Name[13] = "ARG_UPD_USER";


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

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_req_ymd;
            OraDB.Parameter_Values[2] = arg_lot_no;
            OraDB.Parameter_Values[3] = arg_lot_seq;
            OraDB.Parameter_Values[4] = arg_part_no;
            OraDB.Parameter_Values[5] = arg_mat_cd;
            OraDB.Parameter_Values[6] = arg_spec_cd;
            OraDB.Parameter_Values[7] = arg_clor_cd;
            OraDB.Parameter_Values[8] = arg_out_yn;
            OraDB.Parameter_Values[9] = arg_out_value;
            OraDB.Parameter_Values[10] = arg_in_value;
            OraDB.Parameter_Values[11] = arg_status;
            OraDB.Parameter_Values[12] = arg_edit_lev;
            OraDB.Parameter_Values[13] = ClassLib.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }        
        
        private DataTable create_req_no(string arg_factory, string arg_req_ymd)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXO_OUT_01_SELECT.GET_REQ_NO";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_REQ_YMD";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_req_ymd;
            OraDB.Parameter_Values[2] = "";




            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        
        private void confirm_req_data(string arg_factory, string arg_req_ymd)
        {

            string Proc_Name = "pkg_sxo_out_01.CONFIRM_PROD_REQ";

            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_REQ_YMD";
            OraDB.Parameter_Name[2] = "ARG_UPD_USER";


            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_req_ymd;
            OraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }        
        #endregion 	
	}
}

