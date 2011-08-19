using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using FarPoint.Win.Spread.Model;





namespace FlexBase.Develop
{
	public class Form_DC_Style : COM.PCHWinForm.Pop_Large
	{  
		#region 컨트롤정의 및 리소스정의
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Label lbl_StyleNo;
		private System.Windows.Forms.TextBox txt_styleCd;
		private System.Windows.Forms.TextBox txt_StyleName;
		private System.ComponentModel.IContainer components = null;
		private FarPoint.Win.Spread.CellType.ComboBoxCellType vComboType = null;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.TextBox txt_Model;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.ContextMenu ctm_Style;
		private System.Windows.Forms.MenuItem mnt_Style;
		private System.Windows.Forms.Label label2;

	

		public Form_DC_Style()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DC_Style));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.spd_main = new COM.SSP();
            this.ctm_Style = new System.Windows.Forms.ContextMenu();
            this.mnt_Style = new System.Windows.Forms.MenuItem();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Label();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_StyleName = new System.Windows.Forms.TextBox();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.lbl_StyleNo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.pnl_Menu.SuspendLayout();
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.pnl_Menu);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(792, 516);
            this.c1Sizer1.TabIndex = 25;
            this.c1Sizer1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.ContextMenu = this.ctm_Style;
            this.spd_main.Location = new System.Drawing.Point(8, 94);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(776, 370);
            this.spd_main.TabIndex = 45;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
            // 
            // ctm_Style
            // 
            this.ctm_Style.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnt_Style});
            // 
            // mnt_Style
            // 
            this.mnt_Style.Index = 0;
            this.mnt_Style.Text = "Style Name";
            this.mnt_Style.Click += new System.EventHandler(this.mnt_Style_Click);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_Model);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_StyleName);
            this.panel1.Controls.Add(this.txt_styleCd);
            this.panel1.Controls.Add(this.lbl_StyleNo);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 90);
            this.panel1.TabIndex = 168;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Window;
            this.btn_search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(224, 60);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 151;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_Model
            // 
            this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Model.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Model.Location = new System.Drawing.Point(109, 60);
            this.txt_Model.MaxLength = 15;
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(115, 21);
            this.txt_Model.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 149;
            this.label3.Text = "Model";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(264, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 148;
            this.label2.Text = "Style Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StyleName
            // 
            this.txt_StyleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StyleName.Location = new System.Drawing.Point(368, 38);
            this.txt_StyleName.MaxLength = 50;
            this.txt_StyleName.Name = "txt_StyleName";
            this.txt_StyleName.Size = new System.Drawing.Size(395, 21);
            this.txt_StyleName.TabIndex = 147;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_styleCd.Location = new System.Drawing.Point(109, 38);
            this.txt_styleCd.MaxLength = 15;
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.Size = new System.Drawing.Size(115, 21);
            this.txt_styleCd.TabIndex = 146;
            // 
            // lbl_StyleNo
            // 
            this.lbl_StyleNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_StyleNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StyleNo.ImageIndex = 0;
            this.lbl_StyleNo.ImageList = this.img_Label;
            this.lbl_StyleNo.Location = new System.Drawing.Point(8, 38);
            this.lbl_StyleNo.Name = "lbl_StyleNo";
            this.lbl_StyleNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_StyleNo.TabIndex = 36;
            this.lbl_StyleNo.Text = "Code";
            this.lbl_StyleNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(675, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 52);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(760, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 32);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(224, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(728, 32);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "      Style Master Info.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(760, 75);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(16, 16);
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(144, 74);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(728, 18);
            this.pictureBox9.TabIndex = 24;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 75);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(168, 20);
            this.pictureBox10.TabIndex = 22;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(0, 24);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(168, 57);
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(160, 24);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(728, 50);
            this.pictureBox12.TabIndex = 27;
            this.pictureBox12.TabStop = false;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Menu.Controls.Add(this.btn_delete);
            this.pnl_Menu.Controls.Add(this.btn_recover);
            this.pnl_Menu.Controls.Add(this.btn_Insert);
            this.pnl_Menu.Location = new System.Drawing.Point(8, 468);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(784, 40);
            this.pnl_Menu.TabIndex = 47;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_delete.ImageIndex = 5;
            this.btn_delete.ImageList = this.image_List;
            this.btn_delete.Location = new System.Drawing.Point(611, 8);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 24);
            this.btn_delete.TabIndex = 362;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            this.btn_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseDown);
            this.btn_delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseUp);
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(692, 8);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(82, 24);
            this.btn_recover.TabIndex = 349;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
            this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(530, 8);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(82, 24);
            this.btn_Insert.TabIndex = 344;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_insert_Click);
            this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseDown);
            this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseUp);
            // 
            // Form_DC_Style
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_DC_Style";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자정의변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet				 = null;		
		private FarPoint.Win.Spread.CellType.TextCellType vTextType		 = null;

		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{						
			this.Grid_EditModeOnProcess(spd_main) ;
		}		

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			spd_main.Update_Row(img_Action);
		}

		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader)
				Grid_CellDoubleClickProcess(e.Row);
		}

		private void mnt_Style_Click(object sender, System.EventArgs e)
		{
			int ir = spd_main.ActiveSheet.ActiveRowIndex ;
			int ic = spd_main.ActiveSheet.ActiveColumnIndex ;

			int sel_col= spd_main.ActiveSheet.ActiveColumnIndex ;
			
			if(sel_col != (int)ClassLib.TBSDC_STYLE.IxSTYLE_NAME)	return;				
			
			Pop_DC_StyleName vPopup = new Pop_DC_StyleName();
			vPopup.ShowDialog();
			vPopup.Dispose();

			if (COM.ComVar.Parameter_PopUp[0] ==null) return;

			//--------------------------------------------------------------------------------------
			// set update list
			//--------------------------------------------------------------------------------------
			CellRange[] selection_range = spd_main.ActiveSheet.GetSelections(); 
			int start_row = 0; 
			int end_row = 0;
			

			for (int i = 0 ; i < selection_range.Length; i++)
			{

				start_row = selection_range[i].Row;
				end_row = selection_range[i].Row + selection_range[i].RowCount;

				for (int j = start_row ; j < end_row; j++)
				{
					spd_main.ActiveSheet.Cells[j, sel_col].Text = COM.ComVar.Parameter_PopUp[0];  //name 						
					spd_main.Update_Row(j, img_Action);
				}

		
			}
		    
		}

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			int sel_col= spd_main.ActiveSheet.ActiveColumnIndex ;

			if(sel_col == (int)ClassLib.TBSDC_STYLE.IxSTYLE_NAME)	ctm_Style.MenuItems[0].Visible =true;
			else 
				ctm_Style.MenuItems[0].Visible =false;
		}


		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SaveProcess();
		}						

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			SetPrintYield();
		}

		#endregion
	
		#region 컨트롤 이벤트 처리


		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			this.Btn_InsertProcess();
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			this.Btn_DeleteProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Btn_CancelProcess();
		}

		private void txt_styleCd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.numeric_Type(e);
		}
	
		#region 입력이동

		#endregion

		#region 버튼효과

		private void btn_insert_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 8;
		}

		private void btn_insert_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 9;
		}

		private void btn_delete_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 4;
		}

		private void btn_delete_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 5;
		}

		private void btn_cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		private void btn_cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		#endregion

		#endregion

		#region 공통 메서드

		// GridSet : Fore color setting
		private void GridSetInitGrid()
		{
			int vRowCount = spd_main.Sheets[0].Rows.Count;

			for (int i = vRowCount - 1 ; i >= 0 ; i--)
			{
				string vDiv = (spd_main.Sheets[0].Cells[i, 0].Tag == null) ? "" : spd_main.Sheets[0].Cells[i, 0].Tag.ToString();
				if (vDiv.Equals(ClassLib.ComVar.Delete))
				{
					spd_main.Sheets[0].Rows[i].Remove();
					vRowCount--;
				}
			}

			spd_main.Sheets[0].ClearRange(0, 0, vRowCount, 1, false);
		}

		// GridSet : Combo cell change
		private void GridSetComboCell(bool arg_isCombo, ListBox arg_list, int arg_row, int arg_col)
		{
			FarPoint.Win.Spread.CellType.ICellType vNewCellType = null;
			object vOldValue = _mainSheet.Cells[arg_row, arg_col].Value;

			if (arg_isCombo)
			{
				vComboType.ListControl = arg_list;
				vComboType.ListAlignment = FarPoint.Win.ListAlignment.Left;
				vNewCellType = vComboType;
			}
			else
				vNewCellType = vTextType;
			
			_mainSheet.Cells[arg_row, arg_col].CellType = vNewCellType;
			_mainSheet.Cells[arg_row, arg_col].Value = vOldValue;
		}

		private void GridSetData(int arg_row)
		{
			try
				
			{
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxSTYLE_CD].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxSTYLE_CD];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxMODEL_CD].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxMODEL_CD];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxSTYLE_NAME].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxSTYLE_NAME];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxSTYLE_YEAR].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxSTYLE_YEAR];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxSEASON].Value			= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxSEASON];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxDEV_FACT].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxDEV_FACT];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxDEV_CD].Value			= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxDEV_CD];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxCFM_CHK].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxCFM_CHK];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxTEST_CHK].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxTEST_CHK];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxUPPER_CHK].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxUPPER_CHK];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxBOTTOM_CHK].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxBOTTOM_CHK];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxGENDER].Value			= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxGENDER];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxLAST_CD].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxLAST_CD];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxSILUET].Value			= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxSILUET];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxCURRENCY].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxCURRENCY];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxCOST].Value			= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxCOST];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxB_COST].Value			= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxB_COST];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxPRESTO_YN].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxPRESTO_YN];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxWIDTH_DIV].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxWIDTH_DIV];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxREMARKS].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxREMARKS];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxBOM_ID].Value		    = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxBOM_ID];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxBOM_REV].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxBOM_REV];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxUPD_YMD].Value		= "";
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxUPD_USER].Value		= COM.ComVar.This_User;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void GridGetData(int arg_row)
		{
			try
			{
				COM.ComVar.Parameter_PopUp[0]										= ClassLib.ComVar.Insert;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_STYLE.IxSTYLE_CD]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxSTYLE_CD].Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
			
			//Title
            this.Text = "Style Master";
            lbl_MainTitle.Text = "Style Master"; 
            ClassLib.ComFunction.SetLangDic(this);


			// Form Setting
			ClassLib.ComFunction.Init_Form_Control(this);
			ClassLib.ComFunction.Init_MenuRole(this,lbl_MainTitle,tbtn_Search ,tbtn_Save,tbtn_Print) ;

			// Grid Setting
			spd_main.Set_Spread_Comm("SDC_STYLE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			
			_mainSheet = spd_main.Sheets[0];
			//_mainSheet = spd_main.ActiveSheet;

			// Disabled tbutton
			tbtn_Delete.Enabled  = false;
			tbtn_Conform.Enabled = false;
		}		

		private void Tbtn_NewProcess()
		{
			try
			{
				this.txt_styleCd.Text	= "";
				this.txt_StyleName.Text = "";
				
				spd_main.ClearAll();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
			
				string vStyleCd    = this.txt_styleCd.Text;
				string vStyleNm	   = this.txt_StyleName.Text;
				string vModelCD	   = this.txt_Model.Text;

				DataTable vDt = SELECT_SDC_STYLE(vStyleCd, vStyleNm, vModelCD);
				spd_main.Display_Grid(vDt); 
				vDt.Dispose();

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_SaveProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				//Webservice Change - DS 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);
				bool save_flag = MyOraDB.Save_Spread("PKG_SDC_STYLE.SAVE_SDC_STYLE", spd_main);
				
				if(save_flag)
				{
					GridSetInitGrid();

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					this.Tbtn_SearchProcess();

				}

				
			}
			catch (Exception ex)
			{			
				MessageBox.Show(ex.Message);
			}
			finally
			{

				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);

				this.Cursor = Cursors.Default;
			}
		}

		private void Btn_InsertProcess()
		{
			COM.ComVar.Parameter_PopUp		= null;

			Pop_DC_Style popup = new Pop_DC_Style();
			popup.ShowDialog();
			if (popup.DialogResult == DialogResult.OK)
			{
//				int vStyleCdCol  = (int)ClassLib.TBSDC_STYLE.IxSTYLE_CD;
				//				int vShipFactCol = (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT;

				int vRow = spd_main.Add_Row(img_Action);
				GridSetData(vRow);
			}
			popup.Dispose();


			//top row 기능
			spd_main.Set_CellPosition(_mainSheet.RowCount - 1, (int)ClassLib.TBSDC_STYLE.IxSTYLE_CD); 



		}

		private void Btn_DeleteProcess()
		{
			spd_main.Delete_Row(img_Action);
		}

		private void Btn_CancelProcess()
		{
			spd_main.Recovery();
		}

		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
			if (vTemp == "CheckBoxCellType" || vTemp == "SSPComboBoxCellType")
			{
				arg_grid.Buffer_CellData = "000" ;
				arg_grid.Update_Row(img_Action) ;
			}
 

		}

		private void Grid_CellDoubleClickProcess(int arg_row)
		{
			try
			{
				string vDiv = (spd_main.Sheets[0].Cells[arg_row, 0].Tag == null) ? "" : spd_main.Sheets[0].Cells[arg_row, 0].Tag.ToString();

				if (vDiv.Equals(ClassLib.ComVar.Insert))
				{
					COM.ComVar.Parameter_PopUp = new string[(int)ClassLib.TBSDC_STYLE.IxMaxCt + 1];
					this.GridGetData(arg_row);
				}
				else
				{
					COM.ComVar.Parameter_PopUp = new string[4];

					COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComVar.Update;
					COM.ComVar.Parameter_PopUp[1]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_STYLE.IxSTYLE_CD].Text;
				}


				Pop_DC_Style popup = null;

				if (!vDiv.Equals(ClassLib.ComVar.Insert))
				{
					if(_mainSheet.ActiveColumnIndex == (int)ClassLib.TBSDC_STYLE.IxSTYLE_CD)
					{
						popup = new Pop_DC_Style();
						popup.ShowDialog();

					}
				}
				else
				{

					popup = new Pop_DC_Style();
					popup.ShowDialog();

				}



//				Pop_DC_Style popup = new Pop_DC_Style();
//				popup.ShowDialog();



				if(popup == null) return;

				if (popup.DialogResult == DialogResult.OK)
				{
					GridSetData(arg_row);
					if (!vDiv.Equals(ClassLib.ComVar.Insert))
						spd_main.Update_Row(arg_row, img_Action) ;
				}
				popup.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void  SetPrintYield()
		{
			try
			{   
	
						 
				string mrd_Filename = "Report/Material/Form_DC_Style_Master.mrd" ;
				string Para         = " ";

				#region 출력조건

				int  iCnt  = 4;
				string [] aHead =  new string[iCnt];	

				string vStyleCd    = this.txt_styleCd.Text;
				string vStyleNm	   = this.txt_StyleName.Text;

				aHead[0]    = vStyleCd;
				aHead[1]    = vStyleNm;
				
				#endregion
	
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
	
				FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
				report.Show();	

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SDC_STYLE : 
		/// </summary>
		/// <param name="arg_styleCd">  style cd</param>
		/// <param name="arg_styleName">style name</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SDC_STYLE(string arg_styleCd, string  arg_styleName, string  arg_ModelCode)
		{
			try
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(4);

				//Webservice Change - DS 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);


				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SDC_STYLE.SELECT_SDC_STYLE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_NAME";
				MyOraDB.Parameter_Name[2] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_styleCd;
				MyOraDB.Parameter_Values[1] = arg_styleName;
				MyOraDB.Parameter_Values[2] = arg_ModelCode;
				MyOraDB.Parameter_Values[3] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();

				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);


				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];
			}
			catch
			{

				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);
				return null;
			}
		}


		
		private void btn_search_Click(object sender, System.EventArgs e)
		{
			this.Btn_SearchClickProcess();
		}

		#endregion																								

		
		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}


		

		#region 버튼 이벤트 처리

		private void Btn_SearchClickProcess()
		{
			Pop_DC_ModelSearch vPopup = new Pop_DC_ModelSearch();

			if (vPopup.ShowDialog() == DialogResult.OK)
			{
				txt_Model.Text = COM.ComVar.Parameter_PopUp[0];
			}

			vPopup.Dispose();
		}

		#endregion

	

	}
}

