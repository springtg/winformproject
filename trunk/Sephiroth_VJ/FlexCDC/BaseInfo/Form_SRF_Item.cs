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
	public class Form_SRF_Item : COM.CDCWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정의

		public System.Windows.Forms.Panel pnl_Top;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_title;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.TextBox txt_Mat_Name;
		private System.Windows.Forms.TextBox txt_Mat_Code;
		private System.Windows.Forms.Label lbl_MatCode;
		private System.Windows.Forms.Label lbl_MatName;
		private System.Windows.Forms.Label lbl_Mat_Type;
		private System.Windows.Forms.Label lbl_SubType;
		private System.Windows.Forms.ContextMenu ctMnu01;
		private System.Windows.Forms.MenuItem mnu_PurUser;
		private C1.Win.C1List.C1Combo cmb_Type;
		private C1.Win.C1List.C1Combo cmb_SubType;
		private System.Windows.Forms.MenuItem mnu_Vendor;
		private System.Windows.Forms.Label lbl_Vendor;
		private C1.Win.C1List.C1Combo cmb_Vendor;
        private CheckBox chk_empty;
		private System.ComponentModel.IContainer components = null;

		public Form_SRF_Item()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SRF_Item));
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_SubType = new System.Windows.Forms.Label();
            this.lbl_Mat_Type = new System.Windows.Forms.Label();
            this.lbl_MatCode = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.chk_empty = new System.Windows.Forms.CheckBox();
            this.cmb_Vendor = new C1.Win.C1List.C1Combo();
            this.lbl_Vendor = new System.Windows.Forms.Label();
            this.cmb_SubType = new C1.Win.C1List.C1Combo();
            this.cmb_Type = new C1.Win.C1List.C1Combo();
            this.txt_Mat_Code = new System.Windows.Forms.TextBox();
            this.txt_Mat_Name = new System.Windows.Forms.TextBox();
            this.lbl_MatName = new System.Windows.Forms.Label();
            this.btn_openfile = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            this.ctMnu01 = new System.Windows.Forms.ContextMenu();
            this.mnu_PurUser = new System.Windows.Forms.MenuItem();
            this.mnu_Vendor = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SubType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
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
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.lbl_SubType);
            this.pnl_Top.Controls.Add(this.lbl_Mat_Type);
            this.pnl_Top.Controls.Add(this.lbl_MatCode);
            this.pnl_Top.Controls.Add(this.cmb_Factory);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 64);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 110);
            this.pnl_Top.TabIndex = 136;
            // 
            // lbl_SubType
            // 
            this.lbl_SubType.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubType.ImageIndex = 0;
            this.lbl_SubType.ImageList = this.img_Label;
            this.lbl_SubType.Location = new System.Drawing.Point(352, 58);
            this.lbl_SubType.Name = "lbl_SubType";
            this.lbl_SubType.Size = new System.Drawing.Size(100, 21);
            this.lbl_SubType.TabIndex = 346;
            this.lbl_SubType.Tag = "1";
            this.lbl_SubType.Text = "SubType";
            this.lbl_SubType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Mat_Type
            // 
            this.lbl_Mat_Type.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Mat_Type.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mat_Type.ImageIndex = 0;
            this.lbl_Mat_Type.ImageList = this.img_Label;
            this.lbl_Mat_Type.Location = new System.Drawing.Point(16, 58);
            this.lbl_Mat_Type.Name = "lbl_Mat_Type";
            this.lbl_Mat_Type.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mat_Type.TabIndex = 345;
            this.lbl_Mat_Type.Tag = "1";
            this.lbl_Mat_Type.Text = "Type";
            this.lbl_Mat_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MatCode
            // 
            this.lbl_MatCode.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_MatCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatCode.ImageIndex = 0;
            this.lbl_MatCode.ImageList = this.img_Label;
            this.lbl_MatCode.Location = new System.Drawing.Point(352, 35);
            this.lbl_MatCode.Name = "lbl_MatCode";
            this.lbl_MatCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_MatCode.TabIndex = 344;
            this.lbl_MatCode.Tag = "1";
            this.lbl_MatCode.Text = "Code";
            this.lbl_MatCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.EvenRowStyle = style2;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style3;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style4;
            this.cmb_Factory.HighLightRowStyle = style5;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 35);
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
            this.cmb_Factory.Size = new System.Drawing.Size(200, 20);
            this.cmb_Factory.Style = style8;
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
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.chk_empty);
            this.pnl_SearchImage.Controls.Add(this.cmb_Vendor);
            this.pnl_SearchImage.Controls.Add(this.lbl_Vendor);
            this.pnl_SearchImage.Controls.Add(this.cmb_SubType);
            this.pnl_SearchImage.Controls.Add(this.cmb_Type);
            this.pnl_SearchImage.Controls.Add(this.txt_Mat_Code);
            this.pnl_SearchImage.Controls.Add(this.txt_Mat_Name);
            this.pnl_SearchImage.Controls.Add(this.lbl_MatName);
            this.pnl_SearchImage.Controls.Add(this.btn_openfile);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox3);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 110);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(983, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 67);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // chk_empty
            // 
            this.chk_empty.AutoSize = true;
            this.chk_empty.Location = new System.Drawing.Point(689, 80);
            this.chk_empty.Name = "chk_empty";
            this.chk_empty.Size = new System.Drawing.Size(213, 18);
            this.chk_empty.TabIndex = 551;
            this.chk_empty.Text = "Display Empty Essential Data ";
            this.chk_empty.UseVisualStyleBackColor = true;
            // 
            // cmb_Vendor
            // 
            this.cmb_Vendor.AddItemCols = 0;
            this.cmb_Vendor.AddItemSeparator = ';';
            this.cmb_Vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Vendor.Caption = "";
            this.cmb_Vendor.CaptionHeight = 17;
            this.cmb_Vendor.CaptionStyle = style9;
            this.cmb_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Vendor.ColumnCaptionHeight = 18;
            this.cmb_Vendor.ColumnFooterHeight = 18;
            this.cmb_Vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Vendor.ContentHeight = 16;
            this.cmb_Vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Vendor.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Vendor.EditorHeight = 16;
            this.cmb_Vendor.EvenRowStyle = style10;
            this.cmb_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.FooterStyle = style11;
            this.cmb_Vendor.GapHeight = 2;
            this.cmb_Vendor.HeadingStyle = style12;
            this.cmb_Vendor.HighLightRowStyle = style13;
            this.cmb_Vendor.ItemHeight = 15;
            this.cmb_Vendor.Location = new System.Drawing.Point(789, 58);
            this.cmb_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_Vendor.MaxLength = 32767;
            this.cmb_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vendor.Name = "cmb_Vendor";
            this.cmb_Vendor.OddRowStyle = style14;
            this.cmb_Vendor.PartialRightColumn = false;
            this.cmb_Vendor.PropBag = resources.GetString("cmb_Vendor.PropBag");
            this.cmb_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.SelectedStyle = style15;
            this.cmb_Vendor.Size = new System.Drawing.Size(200, 20);
            this.cmb_Vendor.Style = style16;
            this.cmb_Vendor.TabIndex = 550;
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vendor.ImageIndex = 0;
            this.lbl_Vendor.ImageList = this.img_Label;
            this.lbl_Vendor.Location = new System.Drawing.Point(688, 58);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_Vendor.TabIndex = 549;
            this.lbl_Vendor.Tag = "1";
            this.lbl_Vendor.Text = "Vendor";
            this.lbl_Vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_SubType
            // 
            this.cmb_SubType.AddItemCols = 0;
            this.cmb_SubType.AddItemSeparator = ';';
            this.cmb_SubType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_SubType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SubType.Caption = "";
            this.cmb_SubType.CaptionHeight = 17;
            this.cmb_SubType.CaptionStyle = style17;
            this.cmb_SubType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SubType.ColumnCaptionHeight = 18;
            this.cmb_SubType.ColumnFooterHeight = 18;
            this.cmb_SubType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SubType.ContentHeight = 16;
            this.cmb_SubType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SubType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SubType.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SubType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SubType.EditorHeight = 16;
            this.cmb_SubType.EvenRowStyle = style18;
            this.cmb_SubType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SubType.FooterStyle = style19;
            this.cmb_SubType.GapHeight = 2;
            this.cmb_SubType.HeadingStyle = style20;
            this.cmb_SubType.HighLightRowStyle = style21;
            this.cmb_SubType.ItemHeight = 15;
            this.cmb_SubType.Location = new System.Drawing.Point(445, 58);
            this.cmb_SubType.MatchEntryTimeout = ((long)(2000));
            this.cmb_SubType.MaxDropDownItems = ((short)(5));
            this.cmb_SubType.MaxLength = 32767;
            this.cmb_SubType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SubType.Name = "cmb_SubType";
            this.cmb_SubType.OddRowStyle = style22;
            this.cmb_SubType.PartialRightColumn = false;
            this.cmb_SubType.PropBag = resources.GetString("cmb_SubType.PropBag");
            this.cmb_SubType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SubType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SubType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SubType.SelectedStyle = style23;
            this.cmb_SubType.Size = new System.Drawing.Size(200, 20);
            this.cmb_SubType.Style = style24;
            this.cmb_SubType.TabIndex = 548;
            this.cmb_SubType.SelectedValueChanged += new System.EventHandler(this.cmb_SubType_SelectedValueChanged);
            // 
            // cmb_Type
            // 
            this.cmb_Type.AddItemCols = 0;
            this.cmb_Type.AddItemSeparator = ';';
            this.cmb_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Type.Caption = "";
            this.cmb_Type.CaptionHeight = 17;
            this.cmb_Type.CaptionStyle = style25;
            this.cmb_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Type.ColumnCaptionHeight = 18;
            this.cmb_Type.ColumnFooterHeight = 18;
            this.cmb_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Type.ContentHeight = 16;
            this.cmb_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Type.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Type.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Type.EditorHeight = 16;
            this.cmb_Type.EvenRowStyle = style26;
            this.cmb_Type.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.FooterStyle = style27;
            this.cmb_Type.GapHeight = 2;
            this.cmb_Type.HeadingStyle = style28;
            this.cmb_Type.HighLightRowStyle = style29;
            this.cmb_Type.ItemHeight = 15;
            this.cmb_Type.Location = new System.Drawing.Point(109, 58);
            this.cmb_Type.MatchEntryTimeout = ((long)(2000));
            this.cmb_Type.MaxDropDownItems = ((short)(5));
            this.cmb_Type.MaxLength = 32767;
            this.cmb_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.OddRowStyle = style30;
            this.cmb_Type.PartialRightColumn = false;
            this.cmb_Type.PropBag = resources.GetString("cmb_Type.PropBag");
            this.cmb_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Type.SelectedStyle = style31;
            this.cmb_Type.Size = new System.Drawing.Size(200, 20);
            this.cmb_Type.Style = style32;
            this.cmb_Type.TabIndex = 547;
            this.cmb_Type.SelectedValueChanged += new System.EventHandler(this.cmb_Type_SelectedValueChanged);
            // 
            // txt_Mat_Code
            // 
            this.txt_Mat_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mat_Code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mat_Code.Location = new System.Drawing.Point(445, 35);
            this.txt_Mat_Code.Name = "txt_Mat_Code";
            this.txt_Mat_Code.Size = new System.Drawing.Size(200, 21);
            this.txt_Mat_Code.TabIndex = 544;
            this.txt_Mat_Code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Mat_Code_KeyUp);
            // 
            // txt_Mat_Name
            // 
            this.txt_Mat_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mat_Name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mat_Name.Location = new System.Drawing.Point(789, 35);
            this.txt_Mat_Name.Name = "txt_Mat_Name";
            this.txt_Mat_Name.Size = new System.Drawing.Size(200, 21);
            this.txt_Mat_Name.TabIndex = 543;
            this.txt_Mat_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Mat_Name_KeyUp);
            // 
            // lbl_MatName
            // 
            this.lbl_MatName.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_MatName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatName.ImageIndex = 0;
            this.lbl_MatName.ImageList = this.img_Label;
            this.lbl_MatName.Location = new System.Drawing.Point(688, 35);
            this.lbl_MatName.Name = "lbl_MatName";
            this.lbl_MatName.Size = new System.Drawing.Size(100, 21);
            this.lbl_MatName.TabIndex = 542;
            this.lbl_MatName.Tag = "1";
            this.lbl_MatName.Text = "Name";
            this.lbl_MatName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(224, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1000, 40);
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
            this.lbl_title.Text = "        Material Information";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 95);
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
            this.pictureBox5.Location = new System.Drawing.Point(136, 94);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 95);
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
            this.pictureBox7.Size = new System.Drawing.Size(168, 77);
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
            this.pictureBox8.Size = new System.Drawing.Size(1000, 70);
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
            this.pictureBox9.Size = new System.Drawing.Size(1000, 70);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Body.Controls.Add(this.fgrid_Main);
            this.pnl_Body.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Body.Location = new System.Drawing.Point(0, 174);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(1016, 468);
            this.pnl_Body.TabIndex = 137;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_Main.AutoResize = false;
            this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Main.ContextMenu = this.ctMnu01;
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_Main.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.Fixed = 0;
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(1016, 468);
            this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Main.Styles"));
            this.fgrid_Main.TabIndex = 318;
            this.fgrid_Main.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Main_AfterSelChange);
            this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
            this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
            // 
            // ctMnu01
            // 
            this.ctMnu01.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_PurUser,
            this.mnu_Vendor});
            // 
            // mnu_PurUser
            // 
            this.mnu_PurUser.Index = 0;
            this.mnu_PurUser.Text = "Purchase User";
            this.mnu_PurUser.Click += new System.EventHandler(this.mnu_PurUser_Click);
            // 
            // mnu_Vendor
            // 
            this.mnu_Vendor.Index = 1;
            this.mnu_Vendor.Text = "Vendor";
            this.mnu_Vendor.Click += new System.EventHandler(this.mnu_Vendor_Click);
            // 
            // Form_SRF_Item
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_SRF_Item";
            this.Load += new System.EventHandler(this.Form_SRF_Item_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SubType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수 

		private COM.OraDB MyOraDB = new COM.OraDB();
		public string _Pur_User = "" ;

		#endregion

		#region 공통 메서드		
		private void Init_Form()
		{			
			this.Text = "PCC_Material Master";
			this.lbl_MainTitle.Text = "PCC_Material Master";
			this.lbl_title.Text = "      Material Information";	
			ClassLib.ComFunction.SetLangDic(this);		

			#region Button Setting			
			tbtn_Print.Enabled  = false;
			tbtn_Color.Enabled  = false;
			tbtn_Insert.Enabled = false;
			tbtn_Append.Enabled = false;			
			#endregion
					
			#region ComboBox Setting 
			//MAT TYPE Setting
			DataTable dt_ret = Select_Mat_Type_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Type, 0, 0, true, 0, 200);
			cmb_Type.SelectedIndex = 0;		
			
			#endregion

			#region Grid Setting
			//Grid Setting 
			fgrid_Main.Set_Grid_CDC("SXD_SRF_M_MAT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Main.Set_Action_Image(img_Action);
			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;		
			#endregion

			#region TextBox Setting			
			txt_Mat_Code.CharacterCasing = CharacterCasing.Upper;
			txt_Mat_Name.CharacterCasing = CharacterCasing.Upper;
			txt_Mat_Code.Focus();
			#endregion		

            if (COM.ComVar.This_CDCPower_Level.Equals("E01"))
            {
                tbtn_Save.Enabled = false;
                tbtn_Delete.Enabled = false;

                fgrid_Main.ContextMenu = null;
                fgrid_Main.AllowEditing = false;
            }
		}

		private void Display_Grid(DataTable arg_list, COM.FSP arg_fgrid)
		{			
			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;
			
			for(int i=0; i< arg_list.Rows.Count  ; i++)
			{					
				arg_fgrid.AddItem(arg_list.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
			}

		}
		
		#endregion

		#region 이벤트 처리

        #region Control Event 
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
		private void txt_Mat_Name_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(e.KeyData == Keys.Enter)
				{	
					//MAT TYPE Setting
					DataTable dt_ret = Select_Mat_Type_List();
					COM.ComCtl.Set_ComboList(dt_ret, cmb_Type, 0, 0, true, 0, 200);
					cmb_Type.SelectedIndex = 0;
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
		private void txt_Mat_Code_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(e.KeyData == Keys.Enter)
				{	
					//MAT TYPE Setting
					DataTable dt_ret = Select_Mat_Type_List();
					COM.ComCtl.Set_ComboList(dt_ret, cmb_Type, 0, 0, true, 0, 200);
					cmb_Type.SelectedIndex = 0;
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
		private void cmb_Type_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(cmb_Type.SelectedIndex == -1)
					return;
				//Mat SubType Setting 
				DataTable dt_ret = Select_Mat_SubType_List();
				COM.ComCtl.Set_ComboList(dt_ret, cmb_SubType, 0, 0, true, 0, 200);
				cmb_SubType.SelectedIndex = 0;
				dt_ret.Dispose();	
				
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
		private void cmb_SubType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(cmb_SubType.SelectedIndex == -1)
					return;
				//Vendor Setting 
				DataTable dt_ret = Select_Vendor_List();
				COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, 0, 200);
				cmb_Vendor.SelectedIndex = 0;
				dt_ret.Dispose();
				
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

        #region Grid Event
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
			fgrid_Main.Update_Row();
        }
        private void fgrid_Main_AfterSelChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
        {
            ctMnu01.MenuItems[0].Visible = false;
            ctMnu01.MenuItems[1].Visible = false;

            switch (fgrid_Main.Selection.c1)
            {

                case (int)ClassLib.TBSXD_SRF_M_MAT.IxPUR_USER:
                    {
                        ctMnu01.MenuItems[0].Text = "Purchase User";
                        ctMnu01.MenuItems[0].Visible = true;
                        ctMnu01.MenuItems[1].Visible = false;
                        break;
                    }
                case (int)ClassLib.TBSXD_SRF_M_MAT.IxVENDOR_DESC:
                    {
                        ctMnu01.MenuItems[1].Text = "Vendor";
                        ctMnu01.MenuItems[1].Visible = true;
                        ctMnu01.MenuItems[0].Visible = false;
                        break;
                    }

            }
        }
        #endregion

        #region ToolBar Button Event 
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Init_Form();
			txt_Mat_Code.Clear();
			txt_Mat_Name.Clear();

			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
		}
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;				
				
				DataTable dt_ret = Select_Item();
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
				//행 수정 상태 해제
				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count - 1, false);
				MyOraDB.Save_FlexGird("PKG_SXB_BASE_02.SAVE_SXD_SRF_M_MAT", fgrid_Main, (int)ClassLib.TBSXD_SRF_M_MAT.IxMaxCt);
				
				for(int i = fgrid_Main.Rows.Fixed ; i < fgrid_Main.Rows.Count ;i++)
				{
//					if(fgrid_Main[i, (int)ClassLib.TBSXD_SRF_M_MAT.IxDIVISION] != null && fgrid_Main[i, (int)ClassLib.TBSXD_SRF_M_MAT.IxDIVISION].ToString() != "")
//					{
//						Update_Item(i);				 
//					}
					fgrid_Main[i,0] = "";	
				}

				//MAT TYPE Setting
                //DataTable dt_ret = Select_Mat_Type_List();
                //COM.ComCtl.Set_ComboList(dt_ret, cmb_Type, 0, 0, true, 0, 200);
                //cmb_Type.SelectedIndex = 0;


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

        #region ContextMenu Event
        private void mnu_PurUser_Click(object sender, System.EventArgs e)
		{
			BaseInfo.Pop_Purchase_User pur_user = new Pop_Purchase_User(this);
			pur_user.r1 = fgrid_Main.Selection.r1;
			pur_user.r2 = fgrid_Main.Selection.r2;            
            
			pur_user.div = "M";
			pur_user.ShowDialog();			
		}
		private void mnu_Vendor_Click(object sender, System.EventArgs e)
		{
			BaseInfo.Pop_Vendor Vendor = new Pop_Vendor(this);
			Vendor.r1 = fgrid_Main.Selection.r1;
			Vendor.r2 = fgrid_Main.Selection.r2;
			Vendor.div = "M";
			Vendor.ShowDialog();
        }
        #endregion

        #endregion

        #region DB Connect
        private DataTable Select_Mat_Type_List()
		{		
			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_MAT_TYPE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "ARG_MAT_CD";
			MyOraDB.Parameter_Name[2] = "ARG_MAT_NAME";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_Mat_Code, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_Mat_Name, "");	
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];
		}

		private DataTable Select_Mat_SubType_List()
		{		
			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_MAT_SUBTYPE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "ARG_MAT_CD";
			MyOraDB.Parameter_Name[2] = "ARG_MAT_NAME";
		    MyOraDB.Parameter_Name[3] = "ARG_MAT_TYPE";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_Mat_Code, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_Mat_Name, "");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_Type, "");
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];
		}

		private DataTable Select_Vendor_List()
		{		
			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_MAT_VENDOR";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "ARG_MAT_CD";
			MyOraDB.Parameter_Name[2] = "ARG_MAT_NAME";
			MyOraDB.Parameter_Name[3] = "ARG_MAT_TYPE";
			MyOraDB.Parameter_Name[4] = "ARG_MAT_SUBTYPE";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_Mat_Code, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_Mat_Name, "");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_Type, "");
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_SubType, "");
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];
		}


		private DataTable Select_Item()
		{		
			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
            if(!chk_empty.Checked)
			    MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_MAT";
            else
                MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_MAT_CHECK";
			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_MAT_CD";
			MyOraDB.Parameter_Name[2] = "ARG_MAT_NAME";
			MyOraDB.Parameter_Name[3] = "ARG_MAT_TYPE";
			MyOraDB.Parameter_Name[4] = "ARG_MAT_SUBTYPE";
			MyOraDB.Parameter_Name[5] = "ARG_VEN_SEQ";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_Mat_Code, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_Mat_Name, "");
			MyOraDB.Parameter_Values[3] = cmb_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4] = cmb_SubType.SelectedValue.ToString();
			MyOraDB.Parameter_Values[5] = cmb_Vendor.SelectedValue.ToString();
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];
		}      

		private void Update_Item( int row_cnt )
		{
			MyOraDB.ReDim_Parameter(44);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SAVE_SXD_SRF_M_MAT";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_MAT_CD";
			MyOraDB.Parameter_Name[3]  = "ARG_MAT_NAME";
			MyOraDB.Parameter_Name[4]  = "ARG_MAT_COMMENT";
			MyOraDB.Parameter_Name[5]  = "ARG_MAT_DESC";
			MyOraDB.Parameter_Name[6]  = "ARG_MAT_NAME_KNAME";
			MyOraDB.Parameter_Name[7]  = "ARG_MAT_TYPE";
			MyOraDB.Parameter_Name[8]  = "ARG_MAT_SUBTYPE";
			MyOraDB.Parameter_Name[9]  = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[10]  = "ARG_PCC_UNIT_CD";
			MyOraDB.Parameter_Name[11]  = "ARG_PCC_SPEC_CD";
			MyOraDB.Parameter_Name[12]  = "ARG_PCC_LENGTH";
			MyOraDB.Parameter_Name[13] = "ARG_PCC_LENGTHUOM";
			MyOraDB.Parameter_Name[14] = "ARG_PCC_WIDTH";
			MyOraDB.Parameter_Name[15] = "ARG_PCC_WIDTHUOM";
			MyOraDB.Parameter_Name[16] = "ARG_PCC_QTYUOM";
			MyOraDB.Parameter_Name[17] = "ARG_YIELD_VALUE";
			MyOraDB.Parameter_Name[18] = "ARG_LOSS_VALUE";
			MyOraDB.Parameter_Name[19] = "ARG_COMMON_YN";
			MyOraDB.Parameter_Name[20] = "ARG_SHIP_YN";
			MyOraDB.Parameter_Name[21] = "ARG_MRP_YN";
			MyOraDB.Parameter_Name[22] = "ARG_PK_QTY";
			MyOraDB.Parameter_Name[23] = "ARG_STYLE_ITEM_DIV";
			MyOraDB.Parameter_Name[24] = "ARG_PUR_PRICE";
			MyOraDB.Parameter_Name[25] = "ARG_PUR_CURRENCY";
			MyOraDB.Parameter_Name[26] = "ARG_CBD_PRICE";
			MyOraDB.Parameter_Name[27] = "ARG_CBD_CURRENCY";
			MyOraDB.Parameter_Name[28] = "ARG_LAMINATION_PRICE";
			MyOraDB.Parameter_Name[29] = "ARG_LAMINATION_CURRENCY";
			MyOraDB.Parameter_Name[30] = "ARG_VEN_SEQ";
			MyOraDB.Parameter_Name[31] = "ARG_PRICE_YN";
			MyOraDB.Parameter_Name[32] = "ARG_PUR_DIV";
			MyOraDB.Parameter_Name[33] = "ARG_DELIVERY_DAYS";
			MyOraDB.Parameter_Name[34] = "ARG_HS_NO";
			MyOraDB.Parameter_Name[35] = "ARG_CBM";
			MyOraDB.Parameter_Name[36] = "ARG_GROSS_WEIGHT";
			MyOraDB.Parameter_Name[37] = "ARG_NET_WEIGHT";
			MyOraDB.Parameter_Name[38] = "ARG_NIKE_FLG";
			MyOraDB.Parameter_Name[39] = "ARG_USE_YN";
			MyOraDB.Parameter_Name[40] = "ARG_SEND_CHK";
			MyOraDB.Parameter_Name[41] = "ARG_SEND_YMD";
			MyOraDB.Parameter_Name[42] = "ARG_STATUS";
			MyOraDB.Parameter_Name[43] = "ARG_UPD_USER";			
  
			//03.DATA TYPE 정의
			for(int i = 0; i < (int)ClassLib.TBSXD_SRF_M_MAT.IxMaxCt -1 ; i++)
			{
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}			

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]  = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxDIVISION].ToString();
			MyOraDB.Parameter_Values[1]  = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxFACTORY].ToString();
			MyOraDB.Parameter_Values[2]  = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxMAT_CD].ToString();
			MyOraDB.Parameter_Values[3]  = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxMAT_NAME].ToString();
			MyOraDB.Parameter_Values[4]  = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxMAT_COMMENT].ToString();
			MyOraDB.Parameter_Values[5]  = "";
			MyOraDB.Parameter_Values[6]  = "";
			MyOraDB.Parameter_Values[7]  = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxMAT_TYPE].ToString();
			MyOraDB.Parameter_Values[8]  = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxMAT_SUBTYPE].ToString();
			MyOraDB.Parameter_Values[9]  = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPUR_USER].ToString();
			MyOraDB.Parameter_Values[10]  = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPCC_UNIT_CD].ToString();
			MyOraDB.Parameter_Values[11]  = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPCC_SPEC_CD].ToString();
			MyOraDB.Parameter_Values[12]  = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPCC_LENGTH].ToString();
			MyOraDB.Parameter_Values[13] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPCC_LENGTHUOM].ToString();
			MyOraDB.Parameter_Values[14] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPCC_WIDTH].ToString();
			MyOraDB.Parameter_Values[15] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPCC_WIDTHUOM].ToString();
			MyOraDB.Parameter_Values[16] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPCC_QTYUOM].ToString();
			MyOraDB.Parameter_Values[17] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxYIELD_VALUE].ToString();
			MyOraDB.Parameter_Values[18] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxLOSS_VALUE].ToString();
			MyOraDB.Parameter_Values[19] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxCOMMON_YN].ToString();
			MyOraDB.Parameter_Values[20] = "";
			MyOraDB.Parameter_Values[21] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxMRP_YN].ToString();
			MyOraDB.Parameter_Values[22] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPK_QTY].ToString();
			MyOraDB.Parameter_Values[23] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxSTYLE_ITEM_DIV].ToString();
			MyOraDB.Parameter_Values[24] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPUR_PRICE].ToString();
			MyOraDB.Parameter_Values[25] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPUR_CURRENCY].ToString();
			MyOraDB.Parameter_Values[26] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxCBD_PRICE].ToString();
			MyOraDB.Parameter_Values[27] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxCBD_CURRENCY].ToString();
			MyOraDB.Parameter_Values[28] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxLAMINATION_PRICE].ToString();
			MyOraDB.Parameter_Values[29] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxLAMINATION_CURRENCY].ToString();
			MyOraDB.Parameter_Values[30] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxVEN_SEQ].ToString();
			MyOraDB.Parameter_Values[31] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPRICE_YN].ToString();
			MyOraDB.Parameter_Values[32] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxPUR_DIV].ToString();
			MyOraDB.Parameter_Values[33] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxDELIVERY_DAYS].ToString();
			MyOraDB.Parameter_Values[34] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxHS_NO].ToString();
			MyOraDB.Parameter_Values[35] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxCBM] == null)? "":fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxCBM].ToString();
			MyOraDB.Parameter_Values[36] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxGROSS_WEIGHT].ToString();
			MyOraDB.Parameter_Values[37] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxNET_WEIGHT].ToString();
			MyOraDB.Parameter_Values[38] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxNIKE_FLG].ToString();
			MyOraDB.Parameter_Values[39] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MAT.IxUSE_YN].ToString();
			MyOraDB.Parameter_Values[40] = "";
			MyOraDB.Parameter_Values[41] = "";
			MyOraDB.Parameter_Values[42] = "";
			MyOraDB.Parameter_Values[43] = ClassLib.ComVar.This_User;
				
			MyOraDB.Add_Modify_Parameter(true);				
			MyOraDB.Exe_Modify_Procedure();	
			
		}
		
		#endregion 
		
		private void Form_SRF_Item_Load(object sender, System.EventArgs e)
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

		
	}

}

