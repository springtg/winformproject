using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.Threading;

namespace FlexCDC.MRP
{
	public class Form_MRP_Request_Mast : COM.PCHWinForm.Form_Top
	{
		#region 컨트롤정의 및 리소스 정의 
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Panel pnl_grid;
		private System.Windows.Forms.Label lbl_Mrp_No;
		private System.Windows.Forms.Label lbl_Pur_Div;
		private C1.Win.C1List.C1Combo cmb_Pur_div;
		private C1.Win.C1List.C1Combo cmb_Mrp_No;
		private C1.Win.C1List.C1Combo c1Combo3;
		private C1.Win.C1List.C1Combo c1Combo4;
		public COM.FSP fgrid_Mast;
		private System.Windows.Forms.ContextMenu ctm_Item_Mat;
		private System.Windows.Forms.MenuItem mnt_Mrp_Sel_Change_M;
		private System.Windows.Forms.MenuItem mnt_Material_M;
		private System.Windows.Forms.MenuItem mnt_Bom_M;
        private Label lbl_Dash;
        private Label lbl_MRP_Ymd;
        private DateTimePicker dtp_From_Date;
        private DateTimePicker dtp_To_Date;
		private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MRP_Request_Mast));
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
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.lbl_Dash = new System.Windows.Forms.Label();
            this.lbl_MRP_Ymd = new System.Windows.Forms.Label();
            this.dtp_From_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_To_Date = new System.Windows.Forms.DateTimePicker();
            this.chk_print = new System.Windows.Forms.CheckBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.cmb_Mrp_No = new C1.Win.C1List.C1Combo();
            this.cmb_Pur_div = new C1.Win.C1List.C1Combo();
            this.lbl_Pur_Div = new System.Windows.Forms.Label();
            this.lbl_Mrp_No = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.c1Combo3 = new C1.Win.C1List.C1Combo();
            this.c1Combo4 = new C1.Win.C1List.C1Combo();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.fgrid_Mast = new COM.FSP();
            this.ctm_Item_Mat = new System.Windows.Forms.ContextMenu();
            this.mnt_Mrp_Sel_Change_M = new System.Windows.Forms.MenuItem();
            this.mnt_Material_M = new System.Windows.Forms.MenuItem();
            this.mnt_Bom_M = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mrp_No)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Pur_div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo4)).BeginInit();
            this.pnl_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Mast)).BeginInit();
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
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(952, 23);
            this.lbl_MainTitle.Text = "MRP Result";
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
            // tbtn_Confirm
            // 
            this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(0, 80);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(1016, 130);
            this.pnl_Search.TabIndex = 37;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.lbl_Dash);
            this.pnl_SearchImage.Controls.Add(this.lbl_MRP_Ymd);
            this.pnl_SearchImage.Controls.Add(this.dtp_From_Date);
            this.pnl_SearchImage.Controls.Add(this.dtp_To_Date);
            this.pnl_SearchImage.Controls.Add(this.chk_print);
            this.pnl_SearchImage.Controls.Add(this.btn_next);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.cmb_Mrp_No);
            this.pnl_SearchImage.Controls.Add(this.cmb_Pur_div);
            this.pnl_SearchImage.Controls.Add(this.lbl_Pur_Div);
            this.pnl_SearchImage.Controls.Add(this.lbl_Mrp_No);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Controls.Add(this.c1Combo3);
            this.pnl_SearchImage.Controls.Add(this.c1Combo4);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 114);
            this.pnl_SearchImage.TabIndex = 19;
            // 
            // lbl_Dash
            // 
            this.lbl_Dash.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dash.Location = new System.Drawing.Point(538, 42);
            this.lbl_Dash.Name = "lbl_Dash";
            this.lbl_Dash.Size = new System.Drawing.Size(14, 20);
            this.lbl_Dash.TabIndex = 491;
            this.lbl_Dash.Text = "~";
            // 
            // lbl_MRP_Ymd
            // 
            this.lbl_MRP_Ymd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MRP_Ymd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MRP_Ymd.ImageIndex = 0;
            this.lbl_MRP_Ymd.ImageList = this.img_Label;
            this.lbl_MRP_Ymd.Location = new System.Drawing.Point(343, 40);
            this.lbl_MRP_Ymd.Name = "lbl_MRP_Ymd";
            this.lbl_MRP_Ymd.Size = new System.Drawing.Size(100, 21);
            this.lbl_MRP_Ymd.TabIndex = 490;
            this.lbl_MRP_Ymd.Text = "MRP Date";
            this.lbl_MRP_Ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_From_Date
            // 
            this.dtp_From_Date.CustomFormat = "yyyyMMdd";
            this.dtp_From_Date.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_From_Date.Location = new System.Drawing.Point(444, 41);
            this.dtp_From_Date.Name = "dtp_From_Date";
            this.dtp_From_Date.Size = new System.Drawing.Size(95, 21);
            this.dtp_From_Date.TabIndex = 489;
            this.dtp_From_Date.ValueChanged += new System.EventHandler(this.dtp_From_Date_ValueChanged);
            // 
            // dtp_To_Date
            // 
            this.dtp_To_Date.CustomFormat = "yyyyMMdd";
            this.dtp_To_Date.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_To_Date.Location = new System.Drawing.Point(555, 41);
            this.dtp_To_Date.Name = "dtp_To_Date";
            this.dtp_To_Date.Size = new System.Drawing.Size(95, 21);
            this.dtp_To_Date.TabIndex = 488;
            this.dtp_To_Date.ValueChanged += new System.EventHandler(this.dtp_To_Date_ValueChanged);
            // 
            // chk_print
            // 
            this.chk_print.AutoSize = true;
            this.chk_print.Location = new System.Drawing.Point(773, 67);
            this.chk_print.Name = "chk_print";
            this.chk_print.Size = new System.Drawing.Size(116, 18);
            this.chk_print.TabIndex = 387;
            this.chk_print.Text = "Print for Detail";
            this.chk_print.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(910, 63);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 506;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
            this.lbl_title.Location = new System.Drawing.Point(8, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 30);
            this.lbl_title.TabIndex = 497;
            this.lbl_title.Text = "      MRP Manager";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Mrp_No
            // 
            this.cmb_Mrp_No.AddItemSeparator = ';';
            this.cmb_Mrp_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Mrp_No.Caption = "";
            this.cmb_Mrp_No.CaptionHeight = 17;
            this.cmb_Mrp_No.CaptionStyle = style1;
            this.cmb_Mrp_No.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Mrp_No.ColumnCaptionHeight = 18;
            this.cmb_Mrp_No.ColumnFooterHeight = 18;
            this.cmb_Mrp_No.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Mrp_No.ContentHeight = 16;
            this.cmb_Mrp_No.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Mrp_No.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Mrp_No.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mrp_No.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Mrp_No.EditorHeight = 16;
            this.cmb_Mrp_No.EvenRowStyle = style2;
            this.cmb_Mrp_No.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mrp_No.FooterStyle = style3;
            this.cmb_Mrp_No.HeadingStyle = style4;
            this.cmb_Mrp_No.HighLightRowStyle = style5;
            this.cmb_Mrp_No.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Mrp_No.Images"))));
            this.cmb_Mrp_No.ItemHeight = 15;
            this.cmb_Mrp_No.Location = new System.Drawing.Point(773, 41);
            this.cmb_Mrp_No.MatchEntryTimeout = ((long)(2000));
            this.cmb_Mrp_No.MaxDropDownItems = ((short)(5));
            this.cmb_Mrp_No.MaxLength = 32767;
            this.cmb_Mrp_No.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Mrp_No.Name = "cmb_Mrp_No";
            this.cmb_Mrp_No.OddRowStyle = style6;
            this.cmb_Mrp_No.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Mrp_No.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Mrp_No.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Mrp_No.SelectedStyle = style7;
            this.cmb_Mrp_No.Size = new System.Drawing.Size(211, 20);
            this.cmb_Mrp_No.Style = style8;
            this.cmb_Mrp_No.TabIndex = 496;
            this.cmb_Mrp_No.PropBag = resources.GetString("cmb_Mrp_No.PropBag");
            // 
            // cmb_Pur_div
            // 
            this.cmb_Pur_div.AddItemSeparator = ';';
            this.cmb_Pur_div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Pur_div.Caption = "";
            this.cmb_Pur_div.CaptionHeight = 17;
            this.cmb_Pur_div.CaptionStyle = style9;
            this.cmb_Pur_div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Pur_div.ColumnCaptionHeight = 18;
            this.cmb_Pur_div.ColumnFooterHeight = 18;
            this.cmb_Pur_div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Pur_div.ContentHeight = 16;
            this.cmb_Pur_div.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Pur_div.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Pur_div.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Pur_div.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Pur_div.EditorHeight = 16;
            this.cmb_Pur_div.EvenRowStyle = style10;
            this.cmb_Pur_div.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Pur_div.FooterStyle = style11;
            this.cmb_Pur_div.HeadingStyle = style12;
            this.cmb_Pur_div.HighLightRowStyle = style13;
            this.cmb_Pur_div.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Pur_div.Images"))));
            this.cmb_Pur_div.ItemHeight = 15;
            this.cmb_Pur_div.Location = new System.Drawing.Point(112, 61);
            this.cmb_Pur_div.MatchEntryTimeout = ((long)(2000));
            this.cmb_Pur_div.MaxDropDownItems = ((short)(5));
            this.cmb_Pur_div.MaxLength = 32767;
            this.cmb_Pur_div.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Pur_div.Name = "cmb_Pur_div";
            this.cmb_Pur_div.OddRowStyle = style14;
            this.cmb_Pur_div.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Pur_div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Pur_div.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Pur_div.SelectedStyle = style15;
            this.cmb_Pur_div.Size = new System.Drawing.Size(211, 20);
            this.cmb_Pur_div.Style = style16;
            this.cmb_Pur_div.TabIndex = 495;
            this.cmb_Pur_div.PropBag = resources.GetString("cmb_Pur_div.PropBag");
            // 
            // lbl_Pur_Div
            // 
            this.lbl_Pur_Div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Pur_Div.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pur_Div.ImageIndex = 0;
            this.lbl_Pur_Div.ImageList = this.img_Label;
            this.lbl_Pur_Div.Location = new System.Drawing.Point(11, 60);
            this.lbl_Pur_Div.Name = "lbl_Pur_Div";
            this.lbl_Pur_Div.Size = new System.Drawing.Size(100, 21);
            this.lbl_Pur_Div.TabIndex = 494;
            this.lbl_Pur_Div.Text = "Pur Div";
            this.lbl_Pur_Div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Mrp_No
            // 
            this.lbl_Mrp_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Mrp_No.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mrp_No.ImageIndex = 0;
            this.lbl_Mrp_No.ImageList = this.img_Label;
            this.lbl_Mrp_No.Location = new System.Drawing.Point(672, 40);
            this.lbl_Mrp_No.Name = "lbl_Mrp_No";
            this.lbl_Mrp_No.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mrp_No.TabIndex = 492;
            this.lbl_Mrp_No.Text = "MRP No";
            this.lbl_Mrp_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
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
            this.cmb_Factory.HeadingStyle = style20;
            this.cmb_Factory.HighLightRowStyle = style21;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(112, 40);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style22;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style23;
            this.cmb_Factory.Size = new System.Drawing.Size(211, 20);
            this.cmb_Factory.Style = style24;
            this.cmb_Factory.TabIndex = 35;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory.ImageIndex = 1;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(11, 39);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 36;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(899, 25);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 74);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(984, 0);
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
            this.picb_TM.Size = new System.Drawing.Size(776, 32);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(984, 99);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 98);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(840, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(8, 99);
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
            this.picb_ML.Location = new System.Drawing.Point(8, 24);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(211, 81);
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
            this.picb_MM.Size = new System.Drawing.Size(832, 74);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // c1Combo3
            // 
            this.c1Combo3.AddItemSeparator = ';';
            this.c1Combo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1Combo3.Caption = "";
            this.c1Combo3.CaptionHeight = 17;
            this.c1Combo3.CaptionStyle = style25;
            this.c1Combo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo3.ColumnCaptionHeight = 18;
            this.c1Combo3.ColumnFooterHeight = 18;
            this.c1Combo3.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.c1Combo3.ContentHeight = 16;
            this.c1Combo3.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo3.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo3.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo3.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo3.EditorHeight = 16;
            this.c1Combo3.EvenRowStyle = style26;
            this.c1Combo3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo3.FooterStyle = style27;
            this.c1Combo3.HeadingStyle = style28;
            this.c1Combo3.HighLightRowStyle = style29;
            this.c1Combo3.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo3.Images"))));
            this.c1Combo3.ItemHeight = 15;
            this.c1Combo3.Location = new System.Drawing.Point(824, 440);
            this.c1Combo3.MatchEntryTimeout = ((long)(2000));
            this.c1Combo3.MaxDropDownItems = ((short)(5));
            this.c1Combo3.MaxLength = 32767;
            this.c1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo3.Name = "c1Combo3";
            this.c1Combo3.OddRowStyle = style30;
            this.c1Combo3.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1Combo3.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo3.SelectedStyle = style31;
            this.c1Combo3.Size = new System.Drawing.Size(211, 20);
            this.c1Combo3.Style = style32;
            this.c1Combo3.TabIndex = 496;
            this.c1Combo3.PropBag = resources.GetString("c1Combo3.PropBag");
            // 
            // c1Combo4
            // 
            this.c1Combo4.AddItemSeparator = ';';
            this.c1Combo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1Combo4.Caption = "";
            this.c1Combo4.CaptionHeight = 17;
            this.c1Combo4.CaptionStyle = style33;
            this.c1Combo4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo4.ColumnCaptionHeight = 18;
            this.c1Combo4.ColumnFooterHeight = 18;
            this.c1Combo4.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.c1Combo4.ContentHeight = 16;
            this.c1Combo4.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo4.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo4.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo4.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo4.EditorHeight = 16;
            this.c1Combo4.EvenRowStyle = style34;
            this.c1Combo4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo4.FooterStyle = style35;
            this.c1Combo4.HeadingStyle = style36;
            this.c1Combo4.HighLightRowStyle = style37;
            this.c1Combo4.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo4.Images"))));
            this.c1Combo4.ItemHeight = 15;
            this.c1Combo4.Location = new System.Drawing.Point(1152, 440);
            this.c1Combo4.MatchEntryTimeout = ((long)(2000));
            this.c1Combo4.MaxDropDownItems = ((short)(5));
            this.c1Combo4.MaxLength = 32767;
            this.c1Combo4.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo4.Name = "c1Combo4";
            this.c1Combo4.OddRowStyle = style38;
            this.c1Combo4.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1Combo4.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo4.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo4.SelectedStyle = style39;
            this.c1Combo4.Size = new System.Drawing.Size(211, 20);
            this.c1Combo4.Style = style40;
            this.c1Combo4.TabIndex = 495;
            this.c1Combo4.PropBag = resources.GetString("c1Combo4.PropBag");
            // 
            // pnl_grid
            // 
            this.pnl_grid.Controls.Add(this.fgrid_Mast);
            this.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_grid.Location = new System.Drawing.Point(0, 210);
            this.pnl_grid.Name = "pnl_grid";
            this.pnl_grid.Size = new System.Drawing.Size(1016, 434);
            this.pnl_grid.TabIndex = 107;
            // 
            // fgrid_Mast
            // 
            this.fgrid_Mast.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Mast.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Mast.ContextMenu = this.ctm_Item_Mat;
            this.fgrid_Mast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Mast.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Mast.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Mast.Name = "fgrid_Mast";
            this.fgrid_Mast.Rows.DefaultSize = 18;
            this.fgrid_Mast.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Mast.Size = new System.Drawing.Size(1016, 434);
            this.fgrid_Mast.StyleInfo = resources.GetString("fgrid_Mast.StyleInfo");
            this.fgrid_Mast.TabIndex = 104;
            this.fgrid_Mast.Click += new System.EventHandler(this.fgrid_Mast_Click);
            this.fgrid_Mast.EnterCell += new System.EventHandler(this.fgrid_Mast_EnterCell);
            this.fgrid_Mast.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Mast_AfterEdit);
            // 
            // ctm_Item_Mat
            // 
            this.ctm_Item_Mat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnt_Mrp_Sel_Change_M,
            this.mnt_Material_M,
            this.mnt_Bom_M});
            // 
            // mnt_Mrp_Sel_Change_M
            // 
            this.mnt_Mrp_Sel_Change_M.Index = 0;
            this.mnt_Mrp_Sel_Change_M.Text = "Mrp Selected/Change";
            this.mnt_Mrp_Sel_Change_M.Click += new System.EventHandler(this.mnt_Mrp_Sel_Change_M_Click);
            // 
            // mnt_Material_M
            // 
            this.mnt_Material_M.Index = 1;
            this.mnt_Material_M.Text = "Material";
            this.mnt_Material_M.Click += new System.EventHandler(this.mnt_Material_M_Click);
            // 
            // mnt_Bom_M
            // 
            this.mnt_Bom_M.Index = 2;
            this.mnt_Bom_M.Text = "Bom";
            this.mnt_Bom_M.Click += new System.EventHandler(this.mnt_Bom_M_Click);
            // 
            // Form_MRP_Request_Mast
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_grid);
            this.Controls.Add(this.pnl_Search);
            this.Name = "Form_MRP_Request_Mast";
            this.Text = "MRP Result";
            this.Load += new System.EventHandler(this.Form_MRP_Request_Mast_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            this.Controls.SetChildIndex(this.pnl_grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mrp_No)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Pur_div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo4)).EndInit();
            this.pnl_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Mast)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자정의 변수
		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction  MyComFunction= new COM.ComFunction();
		private  string  _Level1 = "1",  _Level2 = "2",  _Level3 = "3",  _Level4 = "4", _Level5 ="5";
		private DataTable _dt_list =null;
        
        private FlexCDC.BaseInfo.Pop_BS_Shipping_List_Wait _pop = null;
        public System.Windows.Forms.Label lbl_title;
        private Button btn_next;
        private CheckBox chk_print;
        private string _loadingfromtype = "";        
		#endregion 

        #region 생성자
        public Form_MRP_Request_Mast()
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

            _loadingfromtype = ClassLib.ComVar.ConsCDC_LoadingFrom_Type;

        }

        public Form_MRP_Request_Mast(Form_MRP_Check arg_frm, string arg_job_type)
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();


            _loadingfromtype = arg_job_type;

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }
        #endregion

        #region Form Loading
        private void Form_MRP_Request_Mast_Load(object sender, System.EventArgs e)
        {
            // Factory Combobox Add Items
            DataTable dt_list;
            dt_list = COM.ComFunction.Select_Factory_List_CDC();
            COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

            Init_Form();
        }
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                ClassLib.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();
                Init_Form();
            }
            catch
            {
            }
        }
        private void Init_Form()
		{
			try
			{			 
				this.Text = "PCC_MRP Result";
				this.lbl_MainTitle.Text = "PCC_MRP Result";
				this.lbl_title.Text = "      Result Information";
				ClassLib.ComFunction.SetLangDic(this); 

				#region 버튼 권한
				tbtn_New.Enabled     = true;
                tbtn_Save.Enabled    = true;
				tbtn_Search.Enabled  = true;
				tbtn_Create.Enabled  = false;
				tbtn_Append.Enabled  = false;
				tbtn_Color.Enabled   = false;
				tbtn_Confirm.Enabled = false;		
				tbtn_Delete.Enabled  = false;
				tbtn_Insert.Enabled  = false;			
				tbtn_Print.Enabled   = true;

                if (ClassLib.ComVar.This_Factory != "DS")
                {
                    tbtn_Save.Enabled = false;
                    btn_next.Enabled = false;
                }
				#endregion  

				#region 속성 설정

                DataTable dt_list;

				//mat Div
				dt_list = ClassLib.ComFunction.Select_Pur_Div(cmb_Factory.SelectedValue.ToString());
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Pur_div, 1, 2, true, 0, 140);
				cmb_Pur_div.SelectedIndex  = 0;
				#endregion 

				//TBSXD_MRP_REQ_MAST
				fgrid_Mast.Set_Grid_CDC("SXD_MRP_ITEM_MAST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_Mast.Set_Action_Image(img_Action);
				fgrid_Mast.Font = new Font("Verdana", 8);

                dtp_From_Date_ValueChanged(null, null);

				if (_loadingfromtype == ClassLib.ComVar.ConsCDC_LoadingFrom_Type_B)
				tbtn_Search_Click(null,null);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
        #endregion

        #region Clear Data
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            fgrid_Mast.Rows.Count = fgrid_Mast.Rows.Fixed;
            cmb_Factory.SelectedIndex = -1;
            cmb_Mrp_No.SelectedIndex = -1;
            cmb_Pur_div.SelectedIndex = -1;
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                fgrid_Mast.Rows.Count = fgrid_Mast.Rows.Fixed;

                _dt_list = null;
                _dt_list = SELECT_MRP_ITEM_MAST();

                DisPlay_Grid(_dt_list, fgrid_Mast);
            }
            catch
            {
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotSearch, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void DisPlay_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
        {
            arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;
            int vTreeLevelCol = (int)ClassLib.TBSXD_MRP_REQ_MAST.lxITEM_01, vTreeLevel = 1;
            arg_fgrid.Tree.Column = vTreeLevelCol;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                vTreeLevel = Convert.ToInt16(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_MRP_REQ_MAST.lxLEVEL - 1].ToString());
                arg_fgrid.Rows.InsertNode(arg_fgrid.Rows.Count, vTreeLevel);

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    arg_fgrid[arg_fgrid.Rows.Fixed + i, j + 1] = arg_dt.Rows[i].ItemArray[j].ToString();
                }

                arg_fgrid[arg_fgrid.Rows.Fixed + i, 0] = "";
                arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].AllowEditing = false;

                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxLEVEL].ToString() == _Level1)
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 0, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Red;

                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxLEVEL].ToString() == _Level2)
                {
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 0, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Blue;
                    if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxPUR_FLG].ToString() == "0") arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].AllowEditing = true;
                }

                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxLEVEL].ToString() == _Level4)
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 0, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
            }
        }
        private DataTable SELECT_MRP_ITEM_MAST()
        {
            string Proc_Name = "PKG_SXM_MRP_03_SELECT.SELECT_SXM_MRP_REQ_MAST";

            int vCount = 6, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_F_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_T_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";

            for (int i = 0; i < vCount - 1; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Type[vCount - 1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = dtp_From_Date.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[b++] = dtp_To_Date.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[b++] = ClassLib.ComFunction.Empty_Combo(cmb_Mrp_No, " ");
            MyOraDB.Parameter_Values[b++] = ClassLib.ComFunction.Empty_Combo(cmb_Pur_div, " ");
            MyOraDB.Parameter_Values[b++] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        private DataTable SELECT_MRP_NO()
        {
            string Proc_Name = "PKG_SXM_MRP_03_SELECT.SELECT_SXM_MRP_REQ_NO";

            int vCount = 4, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_F_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_T_YMD";
            MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";

            for (int i = 0; i < vCount - 1; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Type[vCount - 1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = dtp_From_Date.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[b++] = dtp_To_Date.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[b++] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                SAVE_MRP_MAST();
                tbtn_Search_Click(null, null);
            }
            catch
            {
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotSave, this);
            }
        }

        private bool SAVE_MRP_MAST()
        {
            string Proc_Name = "PKG_SXM_MRP_04.UPDATE_SXM_MRP_REQ_MAST";
            int vCount = 10, a = 0, b = 0, vSaveCount = 0;

            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_MAT_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_PCC_SPEC_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_COLOR_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_PURCHASE_YN";
            MyOraDB.Parameter_Name[a++] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[a++] = "ARG_TRANSPORT_TYPE";
            MyOraDB.Parameter_Name[a++] = "ARG_PRICE_YN";
            MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";

            for (int i = 0; i < vCount; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            //save할 count
            for (int i = fgrid_Mast.Rows.Fixed; i < fgrid_Mast.Rows.Count; i++)
                if (fgrid_Mast[i, 0].ToString() == "U") vSaveCount++;

            MyOraDB.Parameter_Values = new string[vCount * vSaveCount];

            for (int i = fgrid_Mast.Rows.Fixed; i < fgrid_Mast.Rows.Count; i++)
            {
                if (fgrid_Mast[i, 0].ToString() != "U") continue;

                MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Mast[i, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxMRP_NO].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Mast[i, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxMAT_CD].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Mast[i, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxPCC_SPEC_CD].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Mast[i, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxCOLOR_CD].ToString();
                MyOraDB.Parameter_Values[b++] = (fgrid_Mast[i, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxPURCHASE_YN].ToString() == "True") ? ClassLib.ComVar.ConsCDC_Y : ClassLib.ComVar.ConsCDC_N;
                MyOraDB.Parameter_Values[b++] = (fgrid_Mast[i, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxPUR_DIV] == null) ? "" : fgrid_Mast[i, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxPUR_DIV].ToString();
                MyOraDB.Parameter_Values[b++] = (fgrid_Mast[i, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxTRANSPORT] == null) ? "" : fgrid_Mast[i, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxTRANSPORT].ToString();
                MyOraDB.Parameter_Values[b++] = (fgrid_Mast[i, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxPRICE_YN].ToString() == "True") ? ClassLib.ComVar.ConsCDC_Y : ClassLib.ComVar.ConsCDC_N;
                MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
            MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행

            return true;
        }
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string mrd_Filename = "";
                string sPara = "";

                string factory = cmb_Factory.SelectedValue.ToString();
                string mrpfromdate = dtp_From_Date.Value.ToString("yyyyMMdd");
                string mrptodate = dtp_To_Date.Value.ToString("yyyyMMdd");
                string mrpno = ClassLib.ComFunction.Empty_Combo(cmb_Mrp_No, " ").Trim();
                string purdiv = ClassLib.ComFunction.Empty_Combo(cmb_Pur_div, " ").Trim();

                if (chk_print.Checked == true)
                    mrd_Filename = Application.StartupPath + @"\MRP_Result_List_02" + ".mrd";
                else
                    mrd_Filename = Application.StartupPath + @"\MRP_Result_List_01" + ".mrd";

                sPara = " /rp " + "[" + factory + "]"
                                + " [" + mrpfromdate + "]"
                                + " [" + mrptodate + "]"
                                + " [" + mrpno + "]"
                                + " [" + purdiv + "]";

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
        #endregion

        #region Confirm Data
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

        }
        #endregion

        #region Button Event
        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                COM.MyItem item = new COM.MyItem("Purchase Manager", "FlexCDC.Purchase", "Form_Pur_manager");
                ClassMenu menu = new ClassMenu();

                menu.OpenFormByName(this.MdiParent, item, "FlexCDC.Purchase.Form_Pur_Manager_New_02", "Purchase Manager");
                this.Close();
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            FlexCDC.BaseInfo.Pop_Material_Master vEditor = new FlexCDC.BaseInfo.Pop_Material_Master();
            vEditor.ShowDialog();
        }


        private void dtp_From_Date_ValueChanged(object sender, EventArgs e)
        {

            //mrp no 
            DataTable dt_list;            
            dt_list = SELECT_MRP_NO();
            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Mrp_No, 1, 1, true, 0, 140);
            cmb_Mrp_No.SelectedIndex = 0;

        }


       

        private void dtp_To_Date_ValueChanged(object sender, EventArgs e)
        {


            //mrp no 
            DataTable dt_list;
            dt_list = SELECT_MRP_NO();
            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Mrp_No, 1, 1, true, 0, 140);
           cmb_Mrp_No.SelectedIndex = 0;



        }



        #endregion

        #region Grid Event
        private void fgrid_Mast_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_col = fgrid_Mast.Selection.c1;
                int sct_row = fgrid_Mast.Selection.r1;

                for (int i = fgrid_Mast.Rows.Fixed; i < fgrid_Mast.Rows.Count; i++)
                {
                    if (fgrid_Mast.Rows[i].Selected)
                    {
                        if (fgrid_Mast[i, (int)ClassLib.TBSXD_MRP_REQ_MAST.lxLEVEL].ToString() == "2")
                        {
                            fgrid_Mast[i, sct_col] = fgrid_Mast[sct_row, sct_col].ToString();
                            fgrid_Mast.Update_Row(i);
                        }
                    }
                }
            }
            catch
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsWrongInput, this);
            }
        }
        private void fgrid_Mast_EnterCell(object sender, System.EventArgs e)
        {
            mnt_Bom_M.Visible = false;
            mnt_Material_M.Visible = false;

            mnt_Mrp_Sel_Change_M.Visible = false;
            mnt_Material_M.Visible = false;

            if ((fgrid_Mast.Selection.c1 >= (int)ClassLib.TBSXD_MRP_REQ_MAST.lxITEM_01) &&
                (fgrid_Mast.Selection.c1 <= (int)ClassLib.TBSXD_MRP_REQ_MAST.lxITEM_05))
            {
                mnt_Bom_M.Visible = true;
                mnt_Material_M.Visible = true;
                mnt_Mrp_Sel_Change_M.Visible = true;
                mnt_Material_M.Visible = true;
            }
        }
        #endregion

        #region Context Menu Event
        private void mnt_Mrp_Sel_Change_M_Click(object sender, System.EventArgs e)
        {
            fgrid_Mast.Tree.Show(1);
        }
        private void mnt_Bom_M_Click(object sender, System.EventArgs e)
        {
            fgrid_Mast.Tree.Show(3);
        }
        private void mnt_Material_M_Click(object sender, System.EventArgs e)
        {
            fgrid_Mast.Tree.Show(2);
        }
        #endregion

        private void fgrid_Mast_Click(object sender, EventArgs e)
        {






        }


 

    
      
    }
}

