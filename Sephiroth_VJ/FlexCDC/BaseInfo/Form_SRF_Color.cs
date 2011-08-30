using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;
using System.Threading;
namespace FlexCDC.BaseInfo
{
	public class Form_SRF_Color : COM.CDCWinForm.Form_Top
	{
		
		#region 컨트롤 정의 및 리소스 정의
		public System.Windows.Forms.Panel pnl_Top;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.TextBox txt_Color_Desc;
		private System.Windows.Forms.TextBox txt_Color_Code;
		private System.Windows.Forms.Label lbl_ColorCode;
		private System.Windows.Forms.Label lbl_ColorDesc;
        private Panel pnl_Body;
        public COM.FSP fgrid_Main;
        private CheckBox chk_empty;
		private System.ComponentModel.IContainer components = null;

		public Form_SRF_Color()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SRF_Color));
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_ColorCode = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.chk_empty = new System.Windows.Forms.CheckBox();
            this.txt_Color_Desc = new System.Windows.Forms.TextBox();
            this.txt_Color_Code = new System.Windows.Forms.TextBox();
            this.lbl_ColorDesc = new System.Windows.Forms.Label();
            this.btn_openfile = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
            // c1CommandLink1
            // 
            this.c1CommandLink1.ToolTipText = "Clear";
            // 
            // tbtn_New
            // 
            this.tbtn_New.Text = "";
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.ToolTipText = "Search";
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Text = "";
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.ToolTipText = "Save";
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Text = "";
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // tbtn_Append
            // 
            this.tbtn_Append.Text = "";
            // 
            // tbtn_Insert
            // 
            this.tbtn_Insert.Text = "";
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Text = "";
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
            // 
            // c1CommandLink8
            // 
            this.c1CommandLink8.Text = "Confirm";
            // 
            // tbtn_Color
            // 
            this.tbtn_Color.Text = "";
            // 
            // c1CommandLink6
            // 
            this.c1CommandLink6.ToolTipText = "Delete";
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Text = "";
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.lbl_ColorCode);
            this.pnl_Top.Controls.Add(this.cmb_Factory);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 64);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 100);
            this.pnl_Top.TabIndex = 138;
            // 
            // lbl_ColorCode
            // 
            this.lbl_ColorCode.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ColorCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorCode.ImageIndex = 0;
            this.lbl_ColorCode.ImageList = this.img_Label;
            this.lbl_ColorCode.Location = new System.Drawing.Point(352, 35);
            this.lbl_ColorCode.Name = "lbl_ColorCode";
            this.lbl_ColorCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_ColorCode.TabIndex = 344;
            this.lbl_ColorCode.Tag = "1";
            this.lbl_ColorCode.Text = "Color Code";
            this.lbl_ColorCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style17;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.EvenRowStyle = style18;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style19;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style20;
            this.cmb_Factory.HighLightRowStyle = style21;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 35);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style22;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style23;
            this.cmb_Factory.Size = new System.Drawing.Size(200, 20);
            this.cmb_Factory.Style = style24;
            this.cmb_Factory.TabIndex = 272;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 35);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 271;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.chk_empty);
            this.pnl_SearchImage.Controls.Add(this.txt_Color_Desc);
            this.pnl_SearchImage.Controls.Add(this.txt_Color_Code);
            this.pnl_SearchImage.Controls.Add(this.lbl_ColorDesc);
            this.pnl_SearchImage.Controls.Add(this.btn_openfile);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.Controls.Add(this.pictureBox3);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 90);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // chk_empty
            // 
            this.chk_empty.AutoSize = true;
            this.chk_empty.Location = new System.Drawing.Point(11, 63);
            this.chk_empty.Name = "chk_empty";
            this.chk_empty.Size = new System.Drawing.Size(195, 18);
            this.chk_empty.TabIndex = 552;
            this.chk_empty.Text = "Display Empty Korea Name";
            this.chk_empty.UseVisualStyleBackColor = true;
            // 
            // txt_Color_Desc
            // 
            this.txt_Color_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Color_Desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Color_Desc.Location = new System.Drawing.Point(789, 35);
            this.txt_Color_Desc.Name = "txt_Color_Desc";
            this.txt_Color_Desc.Size = new System.Drawing.Size(200, 21);
            this.txt_Color_Desc.TabIndex = 545;
            // 
            // txt_Color_Code
            // 
            this.txt_Color_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Color_Code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Color_Code.Location = new System.Drawing.Point(445, 35);
            this.txt_Color_Code.Name = "txt_Color_Code";
            this.txt_Color_Code.Size = new System.Drawing.Size(200, 21);
            this.txt_Color_Code.TabIndex = 544;
            // 
            // lbl_ColorDesc
            // 
            this.lbl_ColorDesc.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ColorDesc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorDesc.ImageIndex = 0;
            this.lbl_ColorDesc.ImageList = this.img_Label;
            this.lbl_ColorDesc.Location = new System.Drawing.Point(688, 35);
            this.lbl_ColorDesc.Name = "lbl_ColorDesc";
            this.lbl_ColorDesc.Size = new System.Drawing.Size(100, 21);
            this.lbl_ColorDesc.TabIndex = 542;
            this.lbl_ColorDesc.Tag = "1";
            this.lbl_ColorDesc.Text = "Color Desc";
            this.lbl_ColorDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.picb_MR.Size = new System.Drawing.Size(24, 47);
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
            this.pictureBox4.Location = new System.Drawing.Point(984, 75);
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
            this.pictureBox5.Location = new System.Drawing.Point(136, 74);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(862, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 75);
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
            this.pictureBox7.Size = new System.Drawing.Size(168, 57);
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
            this.pictureBox8.Size = new System.Drawing.Size(846, 50);
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
            this.pictureBox9.Size = new System.Drawing.Size(1000, 50);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(224, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(774, 40);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
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
            this.lbl_title.Text = "        Color Information";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Body.Controls.Add(this.fgrid_Main);
            this.pnl_Body.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Body.Location = new System.Drawing.Point(0, 160);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(1016, 480);
            this.pnl_Body.TabIndex = 141;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_Main.AutoResize = false;
            this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_Main.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.Fixed = 0;
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(1016, 480);
            this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Main.Styles"));
            this.fgrid_Main.TabIndex = 318;
            this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
            this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
            // 
            // Form_SRF_Color
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_SRF_Color";
            this.Load += new System.EventHandler(this.Form_SRF_Color_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수 

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		#region 공통 메서드		
		private void Init_Form()
		{			
			this.Text = "PCC_Color Master";
			this.lbl_MainTitle.Text = "PCC_Color Master";
			this.lbl_title.Text = "      Color Information";

			ClassLib.ComFunction.SetLangDic(this);

			#region Button Setting			
			tbtn_Color.Enabled   = false;
			tbtn_Create.Enabled  = false;
			tbtn_Print.Enabled   = false;
			tbtn_Append.Enabled  = false;
			tbtn_Insert.Enabled  = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Save.Enabled    = true;
			#endregion						

			#region Grid Setting
			//Grid Setting 
			fgrid_Main.Set_Grid_CDC("SXD_SRF_M_COLOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Main.Set_Action_Image(img_Action);
			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;	
			#endregion

			#region TextBox Setting			
			txt_Color_Code.CharacterCasing = CharacterCasing.Upper;
			txt_Color_Desc.CharacterCasing = CharacterCasing.Upper;
			txt_Color_Code.Focus();
			#endregion					

            if (COM.ComVar.This_CDCPower_Level.Equals("E01"))
            {
                tbtn_Save.Enabled = false;
                fgrid_Main.AllowEditing = false;
            }
		}

		private void Display_Grid(DataTable arg_list, COM.FSP arg_fgrid)
		{			
			arg_fgrid.Rows.Count  = arg_fgrid.Rows.Fixed;
			
			for(int i=0; i< arg_list.Rows.Count  ; i++)
			{				
				arg_fgrid.AddItem(arg_list.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);			

				#region Use YN Setting 
				if( arg_list.Rows[i].ItemArray[ (int)ClassLib.TBSXD_SRF_M_COLOR.IxUSE_YN-1 ].ToString() == ClassLib.ComVar.ConsCDC_N )
				{					
					arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 1, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor
						=ClassLib.ComVar.Clr_Text_Red;
				}	
				#endregion
			}
		}
		#endregion

		#region 이벤트 처리
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(cmb_Factory.SelectedIndex == -1)
					return;

				COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();

				Init_Form();
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
		private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
			{
				if(fgrid_Main.Cols[fgrid_Main.Col].DataType == typeof(bool))
					fgrid_Main.Buffer_CellData = "";				
				else
					fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();				
			}
		}

		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
            fgrid_Main.Update_Row(fgrid_Main.Selection.r1);
		}
				
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{			
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
			txt_Color_Code.Clear();
			txt_Color_Desc.Clear();
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;			
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;

                string  vEmptycheck = (chk_empty.Checked == true) ? "Y" : "N";
                DataTable dt_ret = Select_Item(cmb_Factory.SelectedValue.ToString(), txt_Color_Code.Text, txt_Color_Desc.Text, vEmptycheck );
				Display_Grid(dt_ret, fgrid_Main); 				
				
				dt_ret.Dispose();
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

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				//행 수정 상태 해제
				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count - 1, false);  
					
				for(int i = fgrid_Main.Rows.Fixed ; i < fgrid_Main.Rows.Count ;i++)
				{
					if(fgrid_Main[ i, (int)ClassLib.TBSXD_SRF_M_COLOR.IxDIVISION] != null && fgrid_Main[ i, (int)ClassLib.TBSXD_SRF_M_COLOR.IxDIVISION].ToString() != "")										
						Update_Item(i);					
					
					fgrid_Main[i,0] = "";			
				}
			}
			catch
			{
				this.Cursor = Cursors.Default;				
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
			}
		}		
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{			
			fgrid_Main.Delete_Row();
		}
		#endregion

		#region DB Connect
		private DataTable Select_Item(string arg_factory,string arg_color_cd, string arg_color_desc, string arg_empty_check)
		{			
			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_COLOR";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[2] = "ARG_COLOR_DESC";
            MyOraDB.Parameter_Name[3] = "ARG_EMPTY_CHECK";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_color_cd;
			MyOraDB.Parameter_Values[2] = arg_color_desc;
            MyOraDB.Parameter_Values[3] = arg_empty_check;
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];
		}	
		
		private void Update_Item(int row_cnt)
		{

			MyOraDB.ReDim_Parameter(12);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SAVE_SXD_SRF_M_COLOR";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[3]  = "ARG_COLOR_DESC";
			MyOraDB.Parameter_Name[4]  = "ARG_COLOR_COMMENT";
			MyOraDB.Parameter_Name[5]  = "ARG_COLOR_DESC_KNAME";
			MyOraDB.Parameter_Name[6]  = "ARG_NIKE_FLG";
			MyOraDB.Parameter_Name[7]  = "ARG_USE_YN";
			MyOraDB.Parameter_Name[8]  = "ARG_SEND_CHK";
			MyOraDB.Parameter_Name[9]  = "ARG_SEND_YMD";
			MyOraDB.Parameter_Name[10] = "ARG_STATUS";
			MyOraDB.Parameter_Name[11] = "ARG_UPD_USER";
			

			//03.DATA TYPE 정의
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
			MyOraDB.Parameter_Type[10]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11]  = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxDIVISION] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxDIVISION].ToString();
			MyOraDB.Parameter_Values[1] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxFACTORY] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxFACTORY].ToString();
			MyOraDB.Parameter_Values[2] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxCOLOR_CD] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxCOLOR_CD].ToString();
			MyOraDB.Parameter_Values[3] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxCOLOR_DESC] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxCOLOR_DESC].ToString();
			MyOraDB.Parameter_Values[4] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxCOLOR_COMMENT] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxCOLOR_COMMENT].ToString();
			MyOraDB.Parameter_Values[5] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxCOLOR_DESC_KNAME] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxCOLOR_DESC_KNAME].ToString();
			MyOraDB.Parameter_Values[6] = "";
			MyOraDB.Parameter_Values[7] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxUSE_YN] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_COLOR.IxUSE_YN].ToString(); 
			MyOraDB.Parameter_Values[8] = "";
			MyOraDB.Parameter_Values[9] = "";
			MyOraDB.Parameter_Values[10] = "";
			MyOraDB.Parameter_Values[11] = ClassLib.ComVar.This_User;
			
			MyOraDB.Add_Modify_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Modify_Procedure();		

			
		}
		#endregion 

		private void Form_SRF_Color_Load(object sender, System.EventArgs e)
		{
			try
			{
				//factory 
				DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
				COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;			
			}
			catch
			{

			}
		}

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

		
	}
}

