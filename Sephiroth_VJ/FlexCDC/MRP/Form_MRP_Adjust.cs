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
	public class Form_MRP_Adjust : COM.PCHWinForm.Form_Top
	{
		#region 컨트롤정의 및 리소스 정의
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label lbl_Option;
		private System.Windows.Forms.GroupBox grpBox;
		private System.Windows.Forms.RadioButton rad_Mat;
		private System.Windows.Forms.RadioButton rad_Bom;
		private System.Windows.Forms.Label lbl_MRP_No;
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
		private System.Windows.Forms.ContextMenu ctm_Item_Mat;
		private System.Windows.Forms.MenuItem mnt_Mrp_Div_M;
		private System.Windows.Forms.MenuItem mnt_Material_M;
		private System.Windows.Forms.MenuItem mnt_Bom_M;
		private System.Windows.Forms.MenuItem mnt_ItemMat_Bar1;
		private System.Windows.Forms.MenuItem mnt_ItemMat_Check;
		private System.Windows.Forms.MenuItem mnt_ItemMat_UnCheck;
		private System.Windows.Forms.MenuItem mnt_ItemMat_Bar2;
		private System.Windows.Forms.MenuItem mnt_ItemMat_TextValue;
		private System.Windows.Forms.MenuItem mnt_ItemMat_ComboValue;
		private System.Windows.Forms.ContextMenu ctm_Item_Bom;
		private System.Windows.Forms.MenuItem mnt_Mrp_Div_B;
		private System.Windows.Forms.MenuItem mnt_Bom_B;
		private System.Windows.Forms.MenuItem mnt_Material_B;
		private System.Windows.Forms.MenuItem mnt_ItemBom_Bar1;
		private System.Windows.Forms.MenuItem mnt_ItemBom_Check;
		private System.Windows.Forms.MenuItem mnt_ItemBom_UnCheck;
		private System.Windows.Forms.MenuItem mnt_ItemBom_Bar2;
		private System.Windows.Forms.MenuItem mnt_ItemBom_TextValue;
		private System.Windows.Forms.MenuItem mnt_ItemBom_ComboValue;
		private System.Windows.Forms.ContextMenu ctm_Status;
		private System.Windows.Forms.MenuItem mnt_Editing_Item;
		private System.Windows.Forms.MenuItem mnt_Confirmed_Item;
		public COM.FSP fgrid_Item;
		private C1.Win.C1List.C1Combo cmb_Mrp_No;
		public System.Windows.Forms.Label lbl_title;
		private C1.Win.C1List.C1Combo cmb_Pur_User;
		private System.Windows.Forms.Label lbl_Pur_User;
        private CheckBox chk_Purchase;
        private Button btn_next;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MRP_Adjust));
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
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.chk_Purchase = new System.Windows.Forms.CheckBox();
            this.cmb_Pur_User = new C1.Win.C1List.C1Combo();
            this.lbl_Pur_User = new System.Windows.Forms.Label();
            this.cmb_Mrp_No = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Option = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.rad_Mat = new System.Windows.Forms.RadioButton();
            this.rad_Bom = new System.Windows.Forms.RadioButton();
            this.lbl_MRP_No = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.fgrid_Item = new COM.FSP();
            this.ctm_Item_Mat = new System.Windows.Forms.ContextMenu();
            this.mnt_Mrp_Div_M = new System.Windows.Forms.MenuItem();
            this.mnt_Material_M = new System.Windows.Forms.MenuItem();
            this.mnt_Bom_M = new System.Windows.Forms.MenuItem();
            this.mnt_ItemMat_Bar1 = new System.Windows.Forms.MenuItem();
            this.mnt_ItemMat_Check = new System.Windows.Forms.MenuItem();
            this.mnt_ItemMat_UnCheck = new System.Windows.Forms.MenuItem();
            this.mnt_ItemMat_Bar2 = new System.Windows.Forms.MenuItem();
            this.mnt_ItemMat_TextValue = new System.Windows.Forms.MenuItem();
            this.mnt_ItemMat_ComboValue = new System.Windows.Forms.MenuItem();
            this.ctm_Item_Bom = new System.Windows.Forms.ContextMenu();
            this.mnt_Mrp_Div_B = new System.Windows.Forms.MenuItem();
            this.mnt_Bom_B = new System.Windows.Forms.MenuItem();
            this.mnt_Material_B = new System.Windows.Forms.MenuItem();
            this.mnt_ItemBom_Bar1 = new System.Windows.Forms.MenuItem();
            this.mnt_ItemBom_Check = new System.Windows.Forms.MenuItem();
            this.mnt_ItemBom_UnCheck = new System.Windows.Forms.MenuItem();
            this.mnt_ItemBom_Bar2 = new System.Windows.Forms.MenuItem();
            this.mnt_ItemBom_TextValue = new System.Windows.Forms.MenuItem();
            this.mnt_ItemBom_ComboValue = new System.Windows.Forms.MenuItem();
            this.ctm_Status = new System.Windows.Forms.ContextMenu();
            this.mnt_Editing_Item = new System.Windows.Forms.MenuItem();
            this.mnt_Confirmed_Item = new System.Windows.Forms.MenuItem();
            this.btn_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Pur_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mrp_No)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            this.pnl_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Item)).BeginInit();
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
            // pnl_Search
            // 
            this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Location = new System.Drawing.Point(0, 64);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(1016, 104);
            this.pnl_Search.TabIndex = 37;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.btn_next);
            this.pnl_SearchImage.Controls.Add(this.chk_Purchase);
            this.pnl_SearchImage.Controls.Add(this.cmb_Pur_User);
            this.pnl_SearchImage.Controls.Add(this.lbl_Pur_User);
            this.pnl_SearchImage.Controls.Add(this.cmb_Mrp_No);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Option);
            this.pnl_SearchImage.Controls.Add(this.grpBox);
            this.pnl_SearchImage.Controls.Add(this.lbl_MRP_No);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 88);
            this.pnl_SearchImage.TabIndex = 19;
            // 
            // chk_Purchase
            // 
            this.chk_Purchase.AutoSize = true;
            this.chk_Purchase.Location = new System.Drawing.Point(683, 62);
            this.chk_Purchase.Name = "chk_Purchase";
            this.chk_Purchase.Size = new System.Drawing.Size(84, 18);
            this.chk_Purchase.TabIndex = 504;
            this.chk_Purchase.Text = "Purchase";
            this.chk_Purchase.UseVisualStyleBackColor = true;
            // 
            // cmb_Pur_User
            // 
            this.cmb_Pur_User.AddItemCols = 0;
            this.cmb_Pur_User.AddItemSeparator = ';';
            this.cmb_Pur_User.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Pur_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Pur_User.Caption = "";
            this.cmb_Pur_User.CaptionHeight = 17;
            this.cmb_Pur_User.CaptionStyle = style1;
            this.cmb_Pur_User.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Pur_User.ColumnCaptionHeight = 18;
            this.cmb_Pur_User.ColumnFooterHeight = 18;
            this.cmb_Pur_User.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Pur_User.ContentHeight = 16;
            this.cmb_Pur_User.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Pur_User.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Pur_User.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Pur_User.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Pur_User.EditorHeight = 16;
            this.cmb_Pur_User.EvenRowStyle = style2;
            this.cmb_Pur_User.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Pur_User.FooterStyle = style3;
            this.cmb_Pur_User.GapHeight = 2;
            this.cmb_Pur_User.HeadingStyle = style4;
            this.cmb_Pur_User.HighLightRowStyle = style5;
            this.cmb_Pur_User.ItemHeight = 15;
            this.cmb_Pur_User.Location = new System.Drawing.Point(112, 62);
            this.cmb_Pur_User.MatchEntryTimeout = ((long)(2000));
            this.cmb_Pur_User.MaxDropDownItems = ((short)(5));
            this.cmb_Pur_User.MaxLength = 32767;
            this.cmb_Pur_User.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Pur_User.Name = "cmb_Pur_User";
            this.cmb_Pur_User.OddRowStyle = style6;
            this.cmb_Pur_User.PartialRightColumn = false;
            this.cmb_Pur_User.PropBag = resources.GetString("cmb_Pur_User.PropBag");
            this.cmb_Pur_User.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Pur_User.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Pur_User.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Pur_User.SelectedStyle = style7;
            this.cmb_Pur_User.Size = new System.Drawing.Size(211, 20);
            this.cmb_Pur_User.Style = style8;
            this.cmb_Pur_User.TabIndex = 503;
            // 
            // lbl_Pur_User
            // 
            this.lbl_Pur_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Pur_User.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pur_User.ImageIndex = 0;
            this.lbl_Pur_User.ImageList = this.img_Label;
            this.lbl_Pur_User.Location = new System.Drawing.Point(11, 62);
            this.lbl_Pur_User.Name = "lbl_Pur_User";
            this.lbl_Pur_User.Size = new System.Drawing.Size(100, 21);
            this.lbl_Pur_User.TabIndex = 502;
            this.lbl_Pur_User.Text = "User";
            this.lbl_Pur_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Mrp_No
            // 
            this.cmb_Mrp_No.AddItemCols = 0;
            this.cmb_Mrp_No.AddItemSeparator = ';';
            this.cmb_Mrp_No.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Mrp_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Mrp_No.Caption = "";
            this.cmb_Mrp_No.CaptionHeight = 17;
            this.cmb_Mrp_No.CaptionStyle = style9;
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
            this.cmb_Mrp_No.EvenRowStyle = style10;
            this.cmb_Mrp_No.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mrp_No.FooterStyle = style11;
            this.cmb_Mrp_No.GapHeight = 2;
            this.cmb_Mrp_No.HeadingStyle = style12;
            this.cmb_Mrp_No.HighLightRowStyle = style13;
            this.cmb_Mrp_No.ItemHeight = 15;
            this.cmb_Mrp_No.Location = new System.Drawing.Point(445, 41);
            this.cmb_Mrp_No.MatchEntryTimeout = ((long)(2000));
            this.cmb_Mrp_No.MaxDropDownItems = ((short)(5));
            this.cmb_Mrp_No.MaxLength = 32767;
            this.cmb_Mrp_No.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Mrp_No.Name = "cmb_Mrp_No";
            this.cmb_Mrp_No.OddRowStyle = style14;
            this.cmb_Mrp_No.PartialRightColumn = false;
            this.cmb_Mrp_No.PropBag = resources.GetString("cmb_Mrp_No.PropBag");
            this.cmb_Mrp_No.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Mrp_No.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Mrp_No.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Mrp_No.SelectedStyle = style15;
            this.cmb_Mrp_No.Size = new System.Drawing.Size(211, 20);
            this.cmb_Mrp_No.Style = style16;
            this.cmb_Mrp_No.TabIndex = 501;
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
            this.cmb_Factory.Location = new System.Drawing.Point(112, 40);
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
            this.cmb_Factory.Size = new System.Drawing.Size(211, 20);
            this.cmb_Factory.Style = style24;
            this.cmb_Factory.TabIndex = 35;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // lbl_Option
            // 
            this.lbl_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Option.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Option.ImageIndex = 0;
            this.lbl_Option.ImageList = this.img_Label;
            this.lbl_Option.Location = new System.Drawing.Point(680, 40);
            this.lbl_Option.Name = "lbl_Option";
            this.lbl_Option.Size = new System.Drawing.Size(100, 21);
            this.lbl_Option.TabIndex = 500;
            this.lbl_Option.Text = "Option";
            this.lbl_Option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.rad_Mat);
            this.grpBox.Controls.Add(this.rad_Bom);
            this.grpBox.Location = new System.Drawing.Point(781, 33);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(208, 30);
            this.grpBox.TabIndex = 499;
            this.grpBox.TabStop = false;
            // 
            // rad_Mat
            // 
            this.rad_Mat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Mat.Location = new System.Drawing.Point(112, 11);
            this.rad_Mat.Name = "rad_Mat";
            this.rad_Mat.Size = new System.Drawing.Size(89, 15);
            this.rad_Mat.TabIndex = 1;
            this.rad_Mat.Text = "By Material";
            // 
            // rad_Bom
            // 
            this.rad_Bom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Bom.Location = new System.Drawing.Point(8, 12);
            this.rad_Bom.Name = "rad_Bom";
            this.rad_Bom.Size = new System.Drawing.Size(80, 15);
            this.rad_Bom.TabIndex = 0;
            this.rad_Bom.Text = "By Bom";
            // 
            // lbl_MRP_No
            // 
            this.lbl_MRP_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MRP_No.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MRP_No.ImageIndex = 0;
            this.lbl_MRP_No.ImageList = this.img_Label;
            this.lbl_MRP_No.Location = new System.Drawing.Point(344, 40);
            this.lbl_MRP_No.Name = "lbl_MRP_No";
            this.lbl_MRP_No.Size = new System.Drawing.Size(100, 21);
            this.lbl_MRP_No.TabIndex = 40;
            this.lbl_MRP_No.Text = "MRP No";
            this.lbl_MRP_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.picb_MR.Size = new System.Drawing.Size(101, 48);
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
            this.lbl_title.Text = "      MRP Manager";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(984, 73);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 72);
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
            this.picb_BL.Location = new System.Drawing.Point(0, 73);
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
            this.picb_ML.Size = new System.Drawing.Size(211, 55);
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
            this.picb_MM.Size = new System.Drawing.Size(832, 48);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // pnl_grid
            // 
            this.pnl_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_grid.Controls.Add(this.fgrid_Item);
            this.pnl_grid.Location = new System.Drawing.Point(0, 168);
            this.pnl_grid.Name = "pnl_grid";
            this.pnl_grid.Size = new System.Drawing.Size(1016, 464);
            this.pnl_grid.TabIndex = 107;
            // 
            // fgrid_Item
            // 
            this.fgrid_Item.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Item.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Item.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Item.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Item.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Item.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Item.Name = "fgrid_Item";
            this.fgrid_Item.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Item.Size = new System.Drawing.Size(1016, 464);
            this.fgrid_Item.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Item.Styles"));
            this.fgrid_Item.TabIndex = 105;
            this.fgrid_Item.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Item_AfterEdit);
            this.fgrid_Item.EnterCell += new System.EventHandler(this.fgrid_Item_EnterCell);
            // 
            // ctm_Item_Mat
            // 
            this.ctm_Item_Mat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnt_Mrp_Div_M,
            this.mnt_Material_M,
            this.mnt_Bom_M,
            this.mnt_ItemMat_Bar1,
            this.mnt_ItemMat_Check,
            this.mnt_ItemMat_UnCheck,
            this.mnt_ItemMat_Bar2,
            this.mnt_ItemMat_TextValue,
            this.mnt_ItemMat_ComboValue});
            // 
            // mnt_Mrp_Div_M
            // 
            this.mnt_Mrp_Div_M.Index = 0;
            this.mnt_Mrp_Div_M.Text = "Mrp Division";
            this.mnt_Mrp_Div_M.Click += new System.EventHandler(this.mnt_Mrp_Div_M_Click);
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
            // mnt_ItemMat_Bar1
            // 
            this.mnt_ItemMat_Bar1.Index = 3;
            this.mnt_ItemMat_Bar1.Text = "-";
            // 
            // mnt_ItemMat_Check
            // 
            this.mnt_ItemMat_Check.Index = 4;
            this.mnt_ItemMat_Check.Text = "Check";
            this.mnt_ItemMat_Check.Click += new System.EventHandler(this.mnt_ItemMat_Check_Click);
            // 
            // mnt_ItemMat_UnCheck
            // 
            this.mnt_ItemMat_UnCheck.Index = 5;
            this.mnt_ItemMat_UnCheck.Text = "UnCheck";
            this.mnt_ItemMat_UnCheck.Click += new System.EventHandler(this.mnt_ItemMat_UnCheck_Click);
            // 
            // mnt_ItemMat_Bar2
            // 
            this.mnt_ItemMat_Bar2.Index = 6;
            this.mnt_ItemMat_Bar2.Text = "-";
            // 
            // mnt_ItemMat_TextValue
            // 
            this.mnt_ItemMat_TextValue.Index = 7;
            this.mnt_ItemMat_TextValue.Text = "Value Change";
            this.mnt_ItemMat_TextValue.Click += new System.EventHandler(this.mnt_ItemMat_TextValue_Click);
            // 
            // mnt_ItemMat_ComboValue
            // 
            this.mnt_ItemMat_ComboValue.Index = 8;
            this.mnt_ItemMat_ComboValue.Text = "Value Change";
            this.mnt_ItemMat_ComboValue.Click += new System.EventHandler(this.mnt_ItemMat_ComboValue_Click);
            // 
            // ctm_Item_Bom
            // 
            this.ctm_Item_Bom.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnt_Mrp_Div_B,
            this.mnt_Bom_B,
            this.mnt_Material_B,
            this.mnt_ItemBom_Bar1,
            this.mnt_ItemBom_Check,
            this.mnt_ItemBom_UnCheck,
            this.mnt_ItemBom_Bar2,
            this.mnt_ItemBom_TextValue,
            this.mnt_ItemBom_ComboValue});
            // 
            // mnt_Mrp_Div_B
            // 
            this.mnt_Mrp_Div_B.Index = 0;
            this.mnt_Mrp_Div_B.Text = "Mrp Division";
            this.mnt_Mrp_Div_B.Click += new System.EventHandler(this.mnt_Mrp_Div_B_Click);
            // 
            // mnt_Bom_B
            // 
            this.mnt_Bom_B.Index = 1;
            this.mnt_Bom_B.Text = "Bom";
            this.mnt_Bom_B.Click += new System.EventHandler(this.mnt_Bom_B_Click);
            // 
            // mnt_Material_B
            // 
            this.mnt_Material_B.Index = 2;
            this.mnt_Material_B.Text = "Material";
            this.mnt_Material_B.Click += new System.EventHandler(this.mnt_Material_B_Click);
            // 
            // mnt_ItemBom_Bar1
            // 
            this.mnt_ItemBom_Bar1.Index = 3;
            this.mnt_ItemBom_Bar1.Text = "-";
            // 
            // mnt_ItemBom_Check
            // 
            this.mnt_ItemBom_Check.Index = 4;
            this.mnt_ItemBom_Check.Text = "Check";
            this.mnt_ItemBom_Check.Click += new System.EventHandler(this.mnt_ItemBom_Check_Click);
            // 
            // mnt_ItemBom_UnCheck
            // 
            this.mnt_ItemBom_UnCheck.Index = 5;
            this.mnt_ItemBom_UnCheck.Text = "Uncheck";
            this.mnt_ItemBom_UnCheck.Click += new System.EventHandler(this.mnt_ItemBom_UnCheck_Click);
            // 
            // mnt_ItemBom_Bar2
            // 
            this.mnt_ItemBom_Bar2.Index = 6;
            this.mnt_ItemBom_Bar2.Text = "-";
            // 
            // mnt_ItemBom_TextValue
            // 
            this.mnt_ItemBom_TextValue.Index = 7;
            this.mnt_ItemBom_TextValue.Text = "Value Change";
            this.mnt_ItemBom_TextValue.Click += new System.EventHandler(this.mnt_ItemBom_TextValue_Click);
            // 
            // mnt_ItemBom_ComboValue
            // 
            this.mnt_ItemBom_ComboValue.Index = 8;
            this.mnt_ItemBom_ComboValue.Text = "Value Change";
            this.mnt_ItemBom_ComboValue.Click += new System.EventHandler(this.mnt_ItemBom_ComboValue_Click);
            // 
            // ctm_Status
            // 
            this.ctm_Status.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnt_Editing_Item,
            this.mnt_Confirmed_Item});
            // 
            // mnt_Editing_Item
            // 
            this.mnt_Editing_Item.Index = 0;
            this.mnt_Editing_Item.Text = "Editing";
            // 
            // mnt_Confirmed_Item
            // 
            this.mnt_Confirmed_Item.Index = 1;
            this.mnt_Confirmed_Item.Text = "Confirmed";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(915, 63);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 505;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Form_MRP_Adjust
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_grid);
            this.Controls.Add(this.pnl_Search);
            this.Name = "Form_MRP_Adjust";
            this.Load += new System.EventHandler(this.Form_MRP_Adjust_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            this.Controls.SetChildIndex(this.pnl_grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Pur_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mrp_No)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.grpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.pnl_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Item)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자정의 변수		
		private COM.OraDB MyOraDB = new COM.OraDB(); // DB 객체
		private COM.ComFunction  MyComFunction= new COM.ComFunction(); //공통 Function 객체

		private  string  _Level1 = "1",  _Level2 = "2",  _Level3 = "3";
		private string  _Pur_div ="";
		private DataTable _dt_list;
		
		private string _ByBom = "B";
		private string _ByMat = "M";
		private string _MatLevel  ="4";

        private int _RecentLevel = 2;
        private int _col1  = 0 , _col2= 0,  _row1  =0, _row2  =0 ,_SCount =0, _CCount  = 0;
		#endregion 

        #region 생성자
        public Form_MRP_Adjust()
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }
        #endregion

        #region Form Loading
        private void Init_Form()
        {
            try
            {
                this.Text = "PCC_MRP_Adjust";
                this.lbl_MainTitle.Text = "PCC_MRP_Adjust";
                this.lbl_title.Text = "      MRP Information";
                ClassLib.ComFunction.SetLangDic(this);

                #region Control Setting
                tbtn_New.Enabled = true;
                tbtn_Save.Enabled = true;
                tbtn_Search.Enabled = true;

                tbtn_Append.Enabled = false;
                tbtn_Color.Enabled = false;

                tbtn_Delete.Enabled = false;
                tbtn_Insert.Enabled = false;
                tbtn_Print.Enabled = false;
                tbtn_Confirm.Enabled = true;
                tbtn_Create.Enabled = false;

                tbtn_Delete.ToolTipText = "Confirm Cancel";
                tbtn_Confirm.ToolTipText = "Sub Confirm";
                tbtn_Create.ToolTipText = "Confirm";

                if (ClassLib.ComVar.This_Factory != "DS") btn_next.Enabled = false;
                #endregion

                ClassLib.ComFunction.SetPowerMRPAdjust(this, ClassLib.ComVar.This_CDCPower_Level);

                #region ComboBox Setting
                DataTable dt_list;

                dt_list = null;
                dt_list = ClassLib.ComFunction.Select_MRP_Item_NoList(cmb_Factory.SelectedValue.ToString());
                ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Mrp_No, 1, 1, false, 0, 140);
                if (dt_list.Rows.Count != 0) cmb_Mrp_No.SelectedIndex = 0;

                dt_list = null;
                dt_list = SELECT_SXP_PUR_USER();

                cmb_Pur_User.Enabled = false;

                if (ClassLib.ComVar.This_CDCPower_Level.Substring(0, 1) == "P" || ClassLib.ComVar.This_CDCPower_Level == "S00")
                {
                    cmb_Pur_User.Enabled = true;
                    ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Pur_User, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
                    cmb_Pur_User.SelectedIndex = 0;

                    if (ClassLib.ComVar.This_CDCPower_Level.ToString() == "P02")
                    {
                        cmb_Pur_User.Enabled = false;

                        DataTable user_datatable = new DataTable("UserList");
                        DataRow newrow;

                        user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                        user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                        newrow = user_datatable.NewRow();
                        newrow["Code"] = ClassLib.ComVar.This_User;
                        newrow["Name"] = ClassLib.ComVar.This_User;

                        user_datatable.Rows.Add(newrow);

                        ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_Pur_User, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
                        cmb_Pur_User.SelectedValue = ClassLib.ComVar.This_User;
                    }
                }

                rad_Mat.Checked = true;
                rad_Mat.Enabled = true;
                rad_Bom.Enabled = true;
                chk_Purchase.Checked = false;

                if (rad_Bom.Checked == true)
                {
                    //TBSXD_MRP_ITEM_01
                    fgrid_Item.Set_Grid_CDC("SXD_MRP_ITEM_MANAGER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_Item.Set_Action_Image(img_Action);
                    fgrid_Item.Font = new Font("Verdana", 8);
                    fgrid_Item.Styles.Alternate.BackColor = Color.White;
                }
                else
                {
                    //TBSXD_MRP_ITEM_02
                    fgrid_Item.Set_Grid_CDC("SXD_MRP_ITEM_MANAGER", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_Item.Set_Action_Image(img_Action);
                    fgrid_Item.Font = new Font("Verdana", 8);
                    fgrid_Item.Styles.Alternate.BackColor = Color.White;
                }

                dt_list = SELECT_CONFIRM_DIV();
                _Pur_div = dt_list.Rows[0].ItemArray[0].ToString();
                #endregion
            }
            catch
            {
                
            }
        }

        private DataTable SELECT_SXP_PUR_USER()
        {
            string Proc_Name = "PKG_SXP_PUR_01_SELECT.SELECT_SXP_PURUSER";

            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_CONFIRM_DIV()
        {
            string Proc_Name = "PKG_SXM_MRP_03_SELECT.SELECT_CONFIRM_DIV";

            int vCount = 3, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_LOGIN_USER";
            MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";

            for (int i = 0; i < vCount - 1; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Type[vCount - 1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_Factory;
            MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;
            MyOraDB.Parameter_Values[b++] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }	
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                fgrid_Item.Rows.Count = fgrid_Item.Rows.Fixed;

                Set_Material_Stock();  //Thread....							
                DisPlay_Grid_Material_Stock(_dt_list, fgrid_Item);

                fgrid_Item.Tree.Show(_RecentLevel);

            }
            catch
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);

            }

        }

        private void Set_Material_Stock()
        {
            string vFlag = (rad_Bom.Checked == true) ? _ByBom : _ByMat;
            _dt_list = SELECT_MATERIAL_STOCK(vFlag);

        }
        private void DisPlay_Grid_Material_Stock(DataTable arg_dt, COM.FSP arg_fgrid)
        {
            fgrid_Item.Rows.Count = fgrid_Item.Rows.Fixed;
            _SCount = 0;

            string vFlag = (rad_Bom.Checked == true) ? _ByBom : _ByMat;

            if (vFlag == _ByBom)
            {
                fgrid_Item.ContextMenu = ctm_Item_Bom;
                //TBSXD_MRP_ITEM_01
                fgrid_Item.Set_Grid_CDC("SXD_MRP_ITEM_MANAGER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_Item.Set_Action_Image(img_Action);
                fgrid_Item.Font = new Font("Verdana", 8);
                fgrid_Item.Styles.Alternate.BackColor = Color.White;
            }
            else
            {
                fgrid_Item.ContextMenu = ctm_Item_Mat; _MatLevel = "2";

                //TBSXD_MRP_ITEM_01
                fgrid_Item.Set_Grid_CDC("SXD_MRP_ITEM_MANAGER", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_Item.Set_Action_Image(img_Action);
                fgrid_Item.Font = new Font("Verdana", 8);
                fgrid_Item.Styles.Alternate.BackColor = Color.White;
            }

            int vTreeLevelCol = (int)ClassLib.TBSXD_MRP_ITEM_01.lxITEM_01, vTreeLevel = 1;
            arg_fgrid.Tree.Column = vTreeLevelCol;

            _CCount = 0;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                vTreeLevel = Convert.ToInt16(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL - 1].ToString());

                arg_fgrid.Rows.InsertNode(arg_fgrid.Rows.Count, vTreeLevel);

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    arg_fgrid[arg_fgrid.Rows.Fixed + i, j + 1] = arg_dt.Rows[i].ItemArray[j].ToString();
                }
                arg_fgrid[arg_fgrid.Rows.Fixed + i, 0] = "";

                //Level Color
                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() == _Level1)
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 1, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Red;

                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() == _Level2)
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 1, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Blue;

                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() == _Level3)
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 1, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Black;

                //Sub Confirm Color
                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_MRP_ITEM_01.lxSTATUS].ToString() == ClassLib.ComVar.ConsCDC_Y)   //Subconfirm
                {
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 1, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.BackColor = Color.LightBlue;
                    arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].AllowEditing = false;
                }

                //Confirm Color
                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_MRP_ITEM_01.lxSTATUS].ToString() == ClassLib.ComVar.ConsCDC_C)  //Confirm
                {
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 1, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLightPink;
                    arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].AllowEditing = false;
                    _CCount++;
                }
            }
        }
        private DataTable SELECT_MATERIAL_STOCK(string arg_flag)
        {
            string Proc_Name = (arg_flag == _ByBom) ? "PKG_SXM_MRP_03_SELECT.SELECT_SXM_MRP_REQ_ITEM_BY_BOM" : "PKG_SXM_MRP_03_SELECT.SELECT_SXM_MRP_REQ_ITEM_BY_MAT";

            int vCount = 5, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(5);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_PUR_USER";
            MyOraDB.Parameter_Name[a++] = "ARG_PURCHASE_YN";
            MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";
            
            for (int i = 0; i < vCount - 1; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Type[vCount - 1] = (int)OracleType.Cursor;
            
            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = ClassLib.ComFunction.Empty_Combo(cmb_Mrp_No, " ");
            MyOraDB.Parameter_Values[b++] = ClassLib.ComFunction.Empty_Combo(cmb_Pur_User, " ");
            MyOraDB.Parameter_Values[b++] = (chk_Purchase.Checked == true) ? "Y" : " ";
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
            this.Cursor = Cursors.WaitCursor;

            int sct_row = fgrid_Item.Selection.r1;
            int sct_col = fgrid_Item.Selection.c1;

            Save_Material_Stock();
            Set_Flag_Clear(fgrid_Item);

            tbtn_Search_Click(null, null);
            fgrid_Item.Tree.Show(_RecentLevel);
            fgrid_Item.Select(sct_row, sct_col);

            this.Cursor = Cursors.Default;
        }

        private bool Save_Material_Stock()
        {
            fgrid_Item.Select(fgrid_Item.Selection.r1, 0, fgrid_Item.Selection.r2, fgrid_Item.Cols.Count - 1);

            if (UPDATE_MRP_REQ_ITEM() != true)
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotSave, this);
                return false;
            }

            return true;
        }
        private bool UPDATE_MRP_REQ_ITEM()
        {
            string Proc_Name = "PKG_SXM_MRP_03.UPDATE_SXM_MRP_REQ_ITEM";

            int vCount = 12, a = 0, b = 0, vSaveCount = 0;
            string vSaveLevel = (rad_Bom.Checked == true) ? _Level3 : _Level2;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_MAT_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_PCC_SPEC_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_COLOR_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_VALUE_ADJ_PUR";
            MyOraDB.Parameter_Name[a++] = "ARG_PURCHASE_YN";
            MyOraDB.Parameter_Name[a++] = "ARG_TRANSPORT_TYPE";
            MyOraDB.Parameter_Name[a++] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[a++] = "ARG_PUR_USER";
            MyOraDB.Parameter_Name[a++] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";

            for (int i = 0; i < vCount; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            //save할 count
            for (int i = fgrid_Item.Rows.Fixed; i < fgrid_Item.Rows.Count; i++)
                if ((fgrid_Item[i, 0].ToString() == "U") && (fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() == vSaveLevel)) vSaveCount++;

            MyOraDB.Parameter_Values = new string[vCount * vSaveCount];

            for (int i = fgrid_Item.Rows.Fixed; i < fgrid_Item.Rows.Count; i++)
            {
                if (fgrid_Item[i, 0].ToString() != "U") continue;
                if (fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_02.lxLEVEL].ToString() != vSaveLevel) continue;

                MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[b++] = cmb_Mrp_No.SelectedValue.ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_02.lxMAT_CD].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_02.lxPCC_SPEC_CD].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_02.lxCOLOR_CD].ToString();
                MyOraDB.Parameter_Values[b++] = ((fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_02.lxVALUE_ADJ_PUR] == null)
                    || (fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_01.lxVALUE_ADJ_PUR].ToString() == "")) ?
                    "0" : fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_01.lxVALUE_ADJ_PUR].ToString();
                MyOraDB.Parameter_Values[b++] = (fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_02.lxPURCHASE_YN].ToString() == "True") ? ClassLib.ComVar.ConsCDC_Y : ClassLib.ComVar.ConsCDC_N;

                MyOraDB.Parameter_Values[b++] = (fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_02.lxTRANSPORT_TYPE] == null) ? "" : fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_02.lxTRANSPORT_TYPE].ToString();
                MyOraDB.Parameter_Values[b++] = (fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_02.lxPUR_DIV] == null) ? "" : fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_02.lxPUR_DIV].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_02.lxPUR_USER].ToString();

                MyOraDB.Parameter_Values[b++] = " ";
                MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
            MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
            return true;
        }
        #endregion


        #region 공통메쏘드


        private void Set_Flag_Item(string arg_value,string arg_desc)
		{

			int  vRow1 = fgrid_Item.Selection.r1, vRow2  = fgrid_Item.Selection.r2;
			int  vCol1 = fgrid_Item.Selection.c1;

			
			for (int i = vRow1;  i<= vRow2 ; i++ )
			{

				if (fgrid_Item[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() != _MatLevel) return;

				if ((fgrid_Item[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxSTATUS] ==null) ||  (fgrid_Item[i,(int)ClassLib.SXB_SRF_MANAGER.lxSTATUS].ToString() =="")) continue;
				fgrid_Item[i,vCol1] =  arg_value ;
				fgrid_Item[i,vCol1-1] = arg_desc;
				fgrid_Item[i,0]="U";

			}

		}

		private void Set_Flag_Clear (COM.FSP arg_fgrid)
		{

			for (int i = arg_fgrid.Rows.Fixed ;i< arg_fgrid.Rows.Count ; i++)
				arg_fgrid[i,0] ="";


		}

		

		#endregion 

		#region 이벤트처리

		#region 버튼


		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			
			try
			{
				//Confirm Cancel
				this.Cursor  = Cursors.WaitCursor;

                
				DataTable dt_list  = Select_Mrp_Item_PurStatus();

				if  (dt_list.Rows[0].ItemArray[0].ToString()  != "0" )
				{
					ClassLib.ComFunction.User_Message("Cancel Error",  "Cancel Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				

				Confirm_Cancel_Adjust_Item();
				tbtn_Search_Click(null,null);

			}
			catch
			{
                ClassLib.ComFunction.User_Message("Cancel Error", "Cancel Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor  = Cursors.Default; 
			}


		}


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Item.Rows.Count  = fgrid_Item.Rows.Fixed;


		}


		
	

		//SubConfirm용버튼
		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			
			try
			{
				//Sub confirm..

				this.Cursor  = Cursors.WaitCursor;

				

				Sub_Confirm_Adjust_Item();
				
				tbtn_Search_Click(null,null);


			}
			catch
			{
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotRun, this);
			}
			finally
			{
				this.Cursor  = Cursors.Default; 
			}


			
		}



		//Confirm용 버튼
		private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
                this.Cursor = Cursors.WaitCursor;

				if (Check_Subconfirm().Rows[0].ItemArray[0].ToString() != "0")    //Subconfirm 미완성....
				{

					ClassLib.ComFunction.User_Message("Unconfirmed data is existed", "Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}



				Confirm_Adjust_Item();
				tbtn_Search_Click(null,null);

				}
				catch
				{

                    ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotRun, this);

				}
				finally
				{
					this.Cursor  = Cursors.Default; 
				}


		}




		

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                COM.MyItem item = new COM.MyItem("MRP Result", "FlexCDC.MRP", "Form_MRP_Request_Mast");
                ClassMenu menu = new ClassMenu();

                menu.OpenFormByName(this.MdiParent, item, "FlexCDC.MRP.Form_MRP_Request_Mast", "MRP Result");
                this.Close();
            }
            catch
            { 
            }
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
		#endregion



		#region 그리드

		private void fgrid_Item_EnterCell(object sender, System.EventArgs e)
		{
			if (fgrid_Item.Selection.r1 <= fgrid_Item.Rows.Fixed) return;

			mnt_Bom_B.Visible  = false;
			mnt_Material_B.Visible = false;
			mnt_Mrp_Div_B.Visible = false;
			mnt_Material_B.Visible = false;

			mnt_ItemBom_Bar1.Visible= false;
			mnt_ItemBom_Bar2.Visible= false;

			mnt_ItemBom_Check.Visible=false;
			mnt_ItemBom_UnCheck.Visible =false;

			mnt_ItemBom_TextValue.Visible  = false;
			mnt_ItemBom_ComboValue.Visible  = false;



			mnt_Bom_M.Visible  = false;
			mnt_Material_M.Visible = false;
			mnt_Mrp_Div_M.Visible = false;
			mnt_Material_M.Visible = false;

			mnt_ItemMat_Bar1.Visible =false;
			mnt_ItemMat_Bar2.Visible= false;

			mnt_ItemMat_Check.Visible=false;
			mnt_ItemMat_UnCheck.Visible =false;

			mnt_ItemMat_TextValue.Visible  = false;
			mnt_ItemMat_ComboValue.Visible  = false;







			if (fgrid_Item.Selection.c1 == (int)ClassLib.TBSXD_MRP_ITEM_01.lxSTATUS_DESC)
			{


				fgrid_Item.ContextMenu  = ctm_Status;


				//권한에 따른 Setting....

				mnt_Confirmed_Item.Visible = true;
				mnt_Editing_Item.Visible  = true;
	
				
			}



			

			if (rad_Bom.Checked  == true)
			{
				


				fgrid_Item.ContextMenu = ctm_Item_Bom;  _MatLevel = "4";

			
				if ((fgrid_Item.Selection.c1  >= (int)ClassLib.TBSXD_MRP_ITEM_01.lxITEM_01) &&
					(fgrid_Item.Selection.c1  <= (int)ClassLib.TBSXD_MRP_ITEM_01.lxITEM_05))
				{
					mnt_Bom_B.Visible  = true;
					mnt_Material_B.Visible = true;
					mnt_Mrp_Div_B.Visible = true;
					mnt_Material_B.Visible  = true;
					
				}



				if(Convert.ToInt16(fgrid_Item[fgrid_Item.Selection.r1,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString()) < Convert.ToInt16(_Level2)) 
				{
					
					ClassLib.ComFunction.User_Message("Input Error : Wrong Level", "Selection Level", MessageBoxButtons.OK, MessageBoxIcon.Error);
					

				}





			}
			else
			{

				

				fgrid_Item.ContextMenu = ctm_Item_Mat; _MatLevel = "3";

			
				if ((fgrid_Item.Selection.c1  >= (int)ClassLib.TBSXD_MRP_ITEM_01.lxITEM_01)&&
					(fgrid_Item.Selection.c1  <= (int)ClassLib.TBSXD_MRP_ITEM_01.lxITEM_05))
				{
					mnt_Bom_M.Visible  = true;
					mnt_Material_M.Visible = true;
					mnt_Mrp_Div_M.Visible = true;
					mnt_Material_M.Visible  = true;

					
		
				}

	

			}





		}



        //miyoung

		private void fgrid_Item_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

            try
            { 
                int sct_col = fgrid_Item.Selection.c1;
                int sct_row = fgrid_Item.Selection.r1;

                string vSaveLevel = (rad_Bom.Checked == true) ? _Level3 : _Level2;


                for (int i = fgrid_Item.Rows.Fixed; i < fgrid_Item.Rows.Count; i++)
                {
                    if (fgrid_Item.Rows[i].Selected)
                    {
                        if (fgrid_Item[i, (int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() == vSaveLevel)
                        {
                            fgrid_Item[i, sct_col] = fgrid_Item[sct_row, sct_col].ToString();
                            fgrid_Item.Update_Row(i);
                        }
                    }
                }




            }
            catch
            {

                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsWrongInput, this);

            }




         


		}


		private void fgrid_Item_Click(object sender, System.EventArgs e)
		{
		} 


		#endregion



		#endregion 

		#region DB컨넥트	
		
		
		private  DataTable Select_Mrp_Item_PurStatus()
		{

			string Proc_Name =  "PKG_SXM_MRP_03_SELECT.SELECT_PURCHASE_STATUS";
		

			int vCount = 3, a=0, b=0;
			MyOraDB.ReDim_Parameter(3);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_MRP_NO";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";





			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;


			MyOraDB.Parameter_Values[b++] =  ClassLib.ComVar.This_Factory;
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComVar.This_User;
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
		
			return DS_Ret.Tables[Proc_Name];			


		}

        private DataTable Check_Subconfirm()
		{

            string Proc_Name = "PKG_SXM_MRP_03_SELECT.SELECT_SXM_SUBCONFIRM_CHECK";
			

			int vCount = 3, a=0, b=0;
			MyOraDB.ReDim_Parameter(3);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_NO";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";



			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;


            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = cmb_Mrp_No.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];			


		}
					
		
	    private  bool Confirm_Cancel_Adjust_Item ()
	    {

		    string Proc_Name = "PKG_SXM_MRP_03.DELETE_CONF_SXM_MRP_REQ_ITEM";


		    int vCount = 3, a=0, b=0;
		    MyOraDB.ReDim_Parameter(vCount);
		    MyOraDB.Process_Name = Proc_Name ;

		    MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";	
		    MyOraDB.Parameter_Name[a++] = "ARG_MRP_NO";				
		    MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";



		    for (int i =0 ; i< vCount ; i++)
			    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  


		    MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
		    MyOraDB.Parameter_Values[b++] =  cmb_Mrp_No.SelectedValue.ToString();
		    MyOraDB.Parameter_Values[b++] =  ClassLib.ComVar.This_User;

		    MyOraDB.Add_Modify_Parameter(true);
		    DataSet DS_Ret = MyOraDB.Exe_Modify_Procedure();	

		    return true;
            


	    }		
		private  bool Confirm_Adjust_Item ()
		{

			string Proc_Name = "PKG_SXM_MRP_03.SAVE_CONF_SXM_MRP_REQ_ITEM";


			int vCount = 3, a=0, b=0;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_NO";				
			MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";



			for (int i =0 ; i< vCount ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  


			MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = cmb_Mrp_No.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Modify_Procedure();	

			return true;
        


		}		
		private  bool Sub_Confirm_Adjust_Item ()
		{

			string Proc_Name = "PKG_SXM_MRP_03.SAVE_SUBCONF_SXM_MRP_REQ_ITEM";


			int vCount = 4, a=0, b=0;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_PUR_USER";			
			MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";



			for (int i =0 ; i< vCount ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  


			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = cmb_Mrp_No.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_Combo(cmb_Pur_User, " ");
            MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Modify_Procedure();	

			return true;
        


		}
		#endregion 

		#region 콘텍스트메뉴
		#region 고정칼럼
		
		private void mnt_Mrp_Div_B_Click(object sender, System.EventArgs e)
		{
			fgrid_Item.Tree.Show(1);
            _RecentLevel = 1;
		}

		private void mnt_Bom_B_Click(object sender, System.EventArgs e)
		{
			fgrid_Item.Tree.Show(2);
            _RecentLevel = 2;
		}

		private void mnt_Material_B_Click(object sender, System.EventArgs e)
		{
			fgrid_Item.Tree.Show(3);
            _RecentLevel = 3;
		}

	

		private void mnt_Mrp_Div_M_Click(object sender, System.EventArgs e)
		{
		
			fgrid_Item.Tree.Show(1);
            _RecentLevel = 1;
		}


		private void mnt_Material_M_Click(object sender, System.EventArgs e)
		{
		
			fgrid_Item.Tree.Show(2);
            _RecentLevel = 2;
		}

		private void mnt_Bom_M_Click(object sender, System.EventArgs e)
		{
		
			fgrid_Item.Tree.Show(3);
            _RecentLevel = 3;
		}

		#endregion 

		#region  Check/UnCheck
		//level4  각자 반영 처리 + Level3일시 Level 4까지 설정 처리
		private void Find_Item_Level_One( COM.FSP arg_fgrid)
		{

			if ( arg_fgrid[arg_fgrid.Selection.r2, (int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() == _Level2)
				for (int i =  arg_fgrid.Selection.r2+1;i <arg_fgrid.Rows.Count ; i++)
					if ( arg_fgrid[i, (int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString()  ==_Level3) 
						_row2 = i;
					else break;
			else
				_row2 =  arg_fgrid.Selection.r2;

		}

	

		private void mnt_ItemBom_Check_Click(object sender, System.EventArgs e)
		{
			

			_col1 = fgrid_Item.Selection.c1;  _col2 = fgrid_Item.Selection.c2; _row1 = fgrid_Item.Selection.r1;  _row2 = fgrid_Item.Selection.r2; 

			Find_Item_Level_One (fgrid_Item);
			
			for (int i = _row1; i<=_row2; i++)
			{  
				//if (fgrid_Item[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() != _Level2) return;
				fgrid_Item[i,_col1] ="True";fgrid_Item.Update_Row(i);
			}

		}

		private void mnt_ItemBom_UnCheck_Click(object sender, System.EventArgs e)
		{
			
		
			_col1 = fgrid_Item.Selection.c1;  _col2 = fgrid_Item.Selection.c2; _row1 = fgrid_Item.Selection.r1;  _row2 = fgrid_Item.Selection.r2; 

			Find_Item_Level_One (fgrid_Item);
			for (int i = _row1; i<=_row2; i++)
			{ // if (fgrid_Item[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() != _Level2) return;
				fgrid_Item[i,_col1] ="False";fgrid_Item.Update_Row(i);
			}
		}

		private void mnt_ItemMat_Check_Click(object sender, System.EventArgs e)
		{
			_col1 = fgrid_Item.Selection.c1;  _col2 = fgrid_Item.Selection.c2; _row1 = fgrid_Item.Selection.r1;  _row2 = fgrid_Item.Selection.r2; 

			Find_Item_Level_One (fgrid_Item);
			
			for (int i = _row1; i<=_row2; i++)
			{  //if (fgrid_Item[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() != _Level2) return;
				fgrid_Item[i,_col1] ="True";fgrid_Item.Update_Row(i);
			}

		}

		private void mnt_ItemMat_UnCheck_Click(object sender, System.EventArgs e)
		{
			_col1 = fgrid_Item.Selection.c1;  _col2 = fgrid_Item.Selection.c2; _row1 = fgrid_Item.Selection.r1;  _row2 = fgrid_Item.Selection.r2; 

			Find_Item_Level_One (fgrid_Item);
			
			for (int i = _row1; i<=_row2; i++)
			{  //if (fgrid_Item[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() != _Level2) return;
				fgrid_Item[i,_col1] ="False";fgrid_Item.Update_Row(i);
			}
		}

		#endregion 

		#region 팝업처리
		private void mnt_ItemMat_TextValue_Click(object sender, System.EventArgs e)
		{
			Set_Item_TextValue(fgrid_Item);
		}

		private void mnt_ItemMat_ComboValue_Click(object sender, System.EventArgs e)
		{
			Set_Item_ComboValue(fgrid_Item);
		}

		private void mnt_ItemBom_TextValue_Click(object sender, System.EventArgs e)
		{
			Set_Item_TextValue(fgrid_Item);
		}

		private void mnt_ItemBom_ComboValue_Click(object sender, System.EventArgs e)
		{
			Set_Item_ComboValue(fgrid_Item);
		}

		private void Set_Item_TextValue(COM.FSP arg_fgrid)
		{



			FlexCDC.BaseInfo.Pop_Common_Text vEditor = new FlexCDC.BaseInfo.Pop_Common_Text( " ");
			vEditor.ShowDialog();


			_col1= arg_fgrid.Selection.c1; _col2 = arg_fgrid.Selection.c2;  _row1   = arg_fgrid.Selection.r1 ;_row2  = arg_fgrid.Selection.r2 ; 

			string vValue = COM.ComVar.This_Return;
			
			if ( (vValue == null) || (vValue =="") )  return;


			Find_Item_Level_One (fgrid_Item);

			for (int i = _row1; i<=_row2; i++)
			{  
				//if  (arg_fgrid[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() != _Level1) return;

				arg_fgrid[i,_col1]  =vValue;
				arg_fgrid.Update_Row(i);
			}




		}


		private void Set_Item_ComboValue(COM.FSP arg_fgrid)
		{



			COM.ComVar.Parameter_PopUp		= new string[2]; 
			COM.ComVar.Parameter_PopUp[0] = ClassLib.ComVar.ConsCDC_TransType;
			COM.ComVar.Parameter_PopUp[1] = arg_fgrid[arg_fgrid.Selection.r1,(int)ClassLib.TBSXD_MRP_ITEM_01.lxFACTORY].ToString();

			FlexCDC.BaseInfo.Pop_Common_Combo vEditor = new FlexCDC.BaseInfo.Pop_Common_Combo();
			vEditor.ShowDialog();


			_col1= arg_fgrid.Selection.c1; _col2 = arg_fgrid.Selection.c2;  _row1   = arg_fgrid.Selection.r1 ;_row2  = arg_fgrid.Selection.r2 ; 

			string vValue = COM.ComVar.This_Return;
			
			if ( (vValue == null) || (vValue =="") )  return;


			Find_Item_Level_One (fgrid_Item);

			for (int i = _row1; i<=_row2; i++)
			{  
				//if  (arg_fgrid[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() != _Level1) return;

				arg_fgrid[i,_col1]  =vValue;
				arg_fgrid.Update_Row(i);
			}




		}

		private void mnt_Editing_Item_Click(object sender, System.EventArgs e)
		{
			string vDesc =  ClassLib.ComVar.ConsCDC_Editing;
			string vValue =  ClassLib.ComVar.ConsCDC_Y;

			Set_Flag_Item(vDesc,vValue);

		}


		private void mnt_Confirmed_Item_Click(object sender, System.EventArgs e)
		{
		
			string vDesc =  ClassLib.ComVar.ConsCDC_Comfirmed;
			string vValue =  ClassLib.ComVar.ConsCDC_C;

			Set_Flag_Item(vDesc,vValue);


		}





		#endregion
		#endregion 
        
		private void Form_MRP_Adjust_Load(object sender, System.EventArgs e)
		{
			// Factory Combobox Add Items
			DataTable dt_list;
			dt_list = COM.ComFunction.Select_Factory_List_CDC();
			COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
			//cmb_Factory.Enabled = false;

			Init_Form();
		}
	}
}

