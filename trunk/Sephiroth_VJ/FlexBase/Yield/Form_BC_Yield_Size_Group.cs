using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient; 
using C1.Win.C1FlexGrid; 

namespace FlexBase.Yield
{
	public class Form_BC_Yield_Size_Group : COM.PCHWinForm.Pop_Large_Light
	{

		#region 컨트롤 정의 및 리소스 정리


		private System.Windows.Forms.Panel pnl_B;
		public System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel info_bar;
		private System.Windows.Forms.StatusBarPanel formname_bar;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.ImageList img_Action;
		public System.Windows.Forms.ImageList img_Button;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label lbl_item;
		public System.Windows.Forms.ImageList img_SmallButton;
		private System.Windows.Forms.Label btn_groupSearch;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.ContextMenu cmenu_Main;
		private System.Windows.Forms.MenuItem menuItem_AddItem;
		private System.Windows.Forms.MenuItem menuItem_DeleteItem;
		private System.Windows.Forms.CheckBox chk_CreateSizeBySize;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자



		public Form_BC_Yield_Size_Group()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form(); 



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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_Yield_Size_Group));
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
            this.pnl_B = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            this.cmenu_Main = new System.Windows.Forms.ContextMenu();
            this.menuItem_AddItem = new System.Windows.Forms.MenuItem();
            this.menuItem_DeleteItem = new System.Windows.Forms.MenuItem();
            this.pnl_BT = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.chk_CreateSizeBySize = new System.Windows.Forms.CheckBox();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.img_Button = new System.Windows.Forms.ImageList(this.components);
            this.stbar = new System.Windows.Forms.StatusBar();
            this.info_bar = new System.Windows.Forms.StatusBarPanel();
            this.formname_bar = new System.Windows.Forms.StatusBarPanel();
            this.img_Action = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.pnl_BT.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formname_bar)).BeginInit();
            this.SuspendLayout();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(729, 4);
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
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(952, 23);
            // 
            // pnl_B
            // 
            this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_B.Controls.Add(this.fgrid_Main);
            this.pnl_B.Controls.Add(this.pnl_BT);
            this.pnl_B.Font = new System.Drawing.Font("Verdana", 9F);
            this.pnl_B.Location = new System.Drawing.Point(0, 56);
            this.pnl_B.Name = "pnl_B";
            this.pnl_B.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pnl_B.Size = new System.Drawing.Size(1016, 488);
            this.pnl_B.TabIndex = 26;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Main.ContextMenu = this.cmenu_Main;
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Location = new System.Drawing.Point(5, 88);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 19;
            this.fgrid_Main.Size = new System.Drawing.Size(1006, 395);
            this.fgrid_Main.StyleInfo = resources.GetString("fgrid_Main.StyleInfo");
            this.fgrid_Main.TabIndex = 666;
            this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
            this.fgrid_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_Main_MouseUp);
            this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
            this.fgrid_Main.DoubleClick += new System.EventHandler(this.fgrid_Main_DoubleClick);
            // 
            // cmenu_Main
            // 
            this.cmenu_Main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_AddItem,
            this.menuItem_DeleteItem});
            this.cmenu_Main.Popup += new System.EventHandler(this.cmenu_Main_Popup);
            // 
            // menuItem_AddItem
            // 
            this.menuItem_AddItem.Index = 0;
            this.menuItem_AddItem.Text = "Add Item";
            this.menuItem_AddItem.Click += new System.EventHandler(this.menuItem_AddItem_Click);
            // 
            // menuItem_DeleteItem
            // 
            this.menuItem_DeleteItem.Index = 1;
            this.menuItem_DeleteItem.Text = "Delete Item";
            this.menuItem_DeleteItem.Click += new System.EventHandler(this.menuItem_DeleteItem_Click);
            // 
            // pnl_BT
            // 
            this.pnl_BT.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_BT.Controls.Add(this.pnl_SearchImage);
            this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BT.Location = new System.Drawing.Point(5, 0);
            this.pnl_BT.Name = "pnl_BT";
            this.pnl_BT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_BT.Size = new System.Drawing.Size(1006, 88);
            this.pnl_BT.TabIndex = 47;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.chk_CreateSizeBySize);
            this.pnl_SearchImage.Controls.Add(this.btn_groupSearch);
            this.pnl_SearchImage.Controls.Add(this.txt_itemGroup);
            this.pnl_SearchImage.Controls.Add(this.cmb_itemGroup);
            this.pnl_SearchImage.Controls.Add(this.txt_itemName);
            this.pnl_SearchImage.Controls.Add(this.txt_itemCode);
            this.pnl_SearchImage.Controls.Add(this.lbl_itemgroup);
            this.pnl_SearchImage.Controls.Add(this.lbl_item);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1006, 83);
            this.pnl_SearchImage.TabIndex = 19;
            // 
            // chk_CreateSizeBySize
            // 
            this.chk_CreateSizeBySize.BackColor = System.Drawing.SystemColors.Window;
            this.chk_CreateSizeBySize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_CreateSizeBySize.Font = new System.Drawing.Font("Verdana", 9F);
            this.chk_CreateSizeBySize.Location = new System.Drawing.Point(608, 58);
            this.chk_CreateSizeBySize.Name = "chk_CreateSizeBySize";
            this.chk_CreateSizeBySize.Size = new System.Drawing.Size(192, 17);
            this.chk_CreateSizeBySize.TabIndex = 664;
            this.chk_CreateSizeBySize.Text = "size spec. creation by size";
            this.chk_CreateSizeBySize.UseVisualStyleBackColor = false;
            this.chk_CreateSizeBySize.CheckedChanged += new System.EventHandler(this.chk_CreateSizeBySize_CheckedChanged);
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(574, 32);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 536;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            this.btn_groupSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_groupSearch.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_groupSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
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
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(474, 32);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.txt_itemGroup.TabIndex = 534;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style17;
            this.cmb_itemGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_itemGroup.ColumnCaptionHeight = 18;
            this.cmb_itemGroup.ColumnFooterHeight = 18;
            this.cmb_itemGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_itemGroup.ContentHeight = 17;
            this.cmb_itemGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_itemGroup.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_itemGroup.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_itemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_itemGroup.EditorHeight = 17;
            this.cmb_itemGroup.EvenRowStyle = style18;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style19;
            this.cmb_itemGroup.HeadingStyle = style20;
            this.cmb_itemGroup.HighLightRowStyle = style21;
            this.cmb_itemGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_itemGroup.Images"))));
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(373, 32);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style22;
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style23;
            this.cmb_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.cmb_itemGroup.Style = style24;
            this.cmb_itemGroup.TabIndex = 533;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(433, 54);
            this.txt_itemName.MaxLength = 500;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(163, 21);
            this.txt_itemName.TabIndex = 535;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(373, 54);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 531;
            // 
            // lbl_itemgroup
            // 
            this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemgroup.ImageIndex = 0;
            this.lbl_itemgroup.ImageList = this.img_Label;
            this.lbl_itemgroup.Location = new System.Drawing.Point(272, 32);
            this.lbl_itemgroup.Name = "lbl_itemgroup";
            this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemgroup.TabIndex = 529;
            this.lbl_itemgroup.Text = "Item Group";
            this.lbl_itemgroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(272, 54);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 530;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style25;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style26;
            this.cmb_Factory.FooterStyle = style27;
            this.cmb_Factory.HeadingStyle = style28;
            this.cmb_Factory.HighLightRowStyle = style29;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 32);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style30;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style31;
            this.cmb_Factory.Size = new System.Drawing.Size(150, 21);
            this.cmb_Factory.Style = style32;
            this.cmb_Factory.TabIndex = 54;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(8, 32);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 528;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(905, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 43);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(990, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(16, 40);
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
            this.picb_TM.Size = new System.Drawing.Size(782, 40);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle1.TabIndex = 28;
            this.lbl_SubTitle1.Text = "      Item Information";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(990, 68);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 67);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(846, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 68);
            this.picb_BL.Name = "picb_BL";
            this.picb_BL.Size = new System.Drawing.Size(168, 20);
            this.picb_BL.TabIndex = 22;
            this.picb_BL.TabStop = false;
            // 
            // picb_MM
            // 
            this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
            this.picb_MM.Location = new System.Drawing.Point(144, 32);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(838, 51);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // picb_ML
            // 
            this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
            this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
            this.picb_ML.Location = new System.Drawing.Point(0, 24);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(168, 50);
            this.picb_ML.TabIndex = 25;
            this.picb_ML.TabStop = false;
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 544);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.info_bar,
            this.formname_bar});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            this.stbar.TabIndex = 27;
            // 
            // info_bar
            // 
            this.info_bar.Name = "info_bar";
            this.info_bar.Width = 150;
            // 
            // formname_bar
            // 
            this.formname_bar.Name = "formname_bar";
            this.formname_bar.Width = 300;
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // Form_BC_Yield_Size_Group
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(1016, 566);
            this.Controls.Add(this.stbar);
            this.Controls.Add(this.pnl_B);
            this.Name = "Form_BC_Yield_Size_Group";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_B, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_B.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.pnl_BT.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formname_bar)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 

		 
		// Grid
		
		// group_count : 사이즈 선택 그룹별로 색깔 처리하기 위한 플래그 
		private int _GroupCount = 0;  

		// 사이즈 선택 그룹별로 색깔 구분
		private Color _SizeColor1 = ClassLib.ComVar.ClrSel_Green;
		private Color _SizeColor2 = ClassLib.ComVar.ClrSel_Yellow;
		private Color _CurrentColor; 



		#endregion

		#region 멤버 메소드
 

		#region initialize


		/// <summary>
		/// Init_Form : 
		/// </summary>
		private void Init_Form()
		{
			try
			{
 
				//Title
				this.Text = "Yield Size Group";
				lbl_MainTitle.Text = "Yield Size Group";

                ClassLib.ComFunction.SetLangDic(this); 


				// 툴바 설정
				tbtn_Delete.Enabled = false;
				tbtn_Print.Enabled = false;
				tbtn_Conform.Enabled = false;



				// 그리드 설정
				fgrid_Main.Set_Grid("SBC_YIELD_SIZE_GROUP", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_Main.Font = new Font(fgrid_Main.Font.Name, 8);
				fgrid_Main.Set_Action_Image(img_Action); 
				fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;

				// 사이즈 그룹 설정위한 사이즈 문대 표시
				Set_SizeHead();

  
				// 공장코드
				DataTable dt_ret = COM.ComFunction.Select_Factory_List();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);  
  

				//그룹타입 콤보쿼리 
				dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_itemGroup, 0, 1, false,  0, 130);  


				dt_ret.Dispose();


 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
 


		/// <summary>
		/// Set_SizeHead : 사이즈 그룹 설정위한 사이즈 문대 표시 
		/// </summary>
		private void Set_SizeHead()
		{

			DataTable dt_ret = ClassLib.ComFunction.Select_SIZE_COLHEAD_ALL(ClassLib.ComVar.This_Factory);
			fgrid_Main.Display_CrossTab_Head(dt_ret, 25, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCS_SIZE_START); 
			dt_ret.Dispose();
			
		}


		#endregion

		#region Grid


		/// <summary>
		/// Display_Grid : 
		/// </summary>
		/// <param name="dt_ret"></param>
		private void Display_Grid(DataTable arg_dt)
		{

			string before_item = "", now_item = "";     
			string cs_size_from = "", cs_size_to = "";
			int size_f = -1, size_t = -1;
			int group_count = 0;


			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
   
			if(arg_dt.Rows.Count == 0) return; 

  
			CellRange cr = fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCS_SIZE_START);


			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
      	 
				now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxFACTORY - 1].ToString()
								+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD - 1].ToString();
 

				if(before_item != now_item)
				{
  
					fgrid_Main.Rows.Add();  // data_row
					fgrid_Main.Rows.Add();  // data_division_row
								
					//default data setting
					for(int j = 1; j < (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCS_SIZE_START; j++)
					{
						fgrid_Main[fgrid_Main.Rows.Count - 2, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();  // data
						fgrid_Main[fgrid_Main.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();  // data_division
					}
 					

					fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].Visible = false;  // data_division_row

					before_item = now_item;  

				}
 
 

				//-----------------------------------------------------------------------------------------------
				// size group setting
				//----------------------------------------------------------------------------------------------- 
				cs_size_from = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCS_SIZE_FROM - 1].ToString();
				cs_size_to = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCS_SIZE_TO - 1].ToString();

				for(int a = (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCS_SIZE_START; a < fgrid_Main.Cols.Count; a++)
				{
					if(cs_size_from == fgrid_Main[1, a].ToString())
					{
						size_f = a;
						break;
					} 

				}

				for(int a = size_f; a < fgrid_Main.Cols.Count; a++)
				{
					if(cs_size_to == fgrid_Main[1, a].ToString())
					{
						size_t = a;
						break;
					} 

				} 


				cr = fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 2, size_f, fgrid_Main.Rows.Count - 2, size_t); 
				cr.UserData = group_count++;  

				cr = fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, size_f, fgrid_Main.Rows.Count - 1, size_t); 

				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxSPEC_CD - 1].ToString().Substring(0, 1) == "0")
				{
					cr.Data = "";
				}
				else
				{
					cr.Data = "Y";
				}

 				//-----------------------------------------------------------------------------------------------



				// Set Size Group Color
				Display_SizeGroup_Color(fgrid_Main.Rows.Count - 2);



			} // end for 


			 arg_dt.Dispose();


		} 


		/// <summary>
		/// Set_SizeGroup : 사이즈 그룹 세팅
		/// </summary>
		/// <param name="arg_mousebutton"></param>
		private void Set_SizeGroup(MouseButtons arg_mousebutton)
		{

			if(fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;
		
			int sel_row = fgrid_Main.Selection.r1;
			int sel_col1 = fgrid_Main.Selection.c1;
			int sel_col2 = fgrid_Main.Selection.c2;

			int start_col = (sel_col1 < sel_col2) ? sel_col1 : sel_col2;

			if(start_col < (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCS_SIZE_START) return;


			if(arg_mousebutton != MouseButtons.Right) return;


			_GroupCount++;
			 


			CellRange cr;
			cr = fgrid_Main.GetCellRange(sel_row, sel_col1, sel_row, sel_col2);
			cr.UserData = _GroupCount.ToString();
			

			// user setting flag
			cr = fgrid_Main.GetCellRange(sel_row + 1, sel_col1, sel_row + 1, sel_col2);
			cr.Data = "Y";

 


			// Set Size Group Color
			Display_SizeGroup_Color(sel_row);


			// update 표시
			fgrid_Main.Update_Row(sel_row);
		

		}



		/// <summary>
		/// Display_SizeGroup_Color : 색깔 표시
		/// </summary>
		private void Display_SizeGroup_Color(int arg_row)
		{

			int size_f = -1, size_t = -1;
			string before_flag = "", now_flag = "";
			_CurrentColor = _SizeColor2;

			size_f = (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCS_SIZE_START;

			CellRange cr;

			while(true)
			{
				cr = fgrid_Main.GetCellRange(arg_row, size_f); 

				before_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 


				for(int k = size_f; k < fgrid_Main.Cols.Count; k++)
				{   

					cr = fgrid_Main.GetCellRange(arg_row, k); 

					now_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 

					if(before_flag == now_flag)
					{
						size_t = k;
					}
					else
					{
						break;
					}

				}
 


				// 색깔 표시
				if(_CurrentColor.Equals(_SizeColor1) )
				{
					_CurrentColor = _SizeColor2;
				}
				else
				{
					_CurrentColor = _SizeColor1;
				}

 

				for(int i = size_f; i <= size_t; i++)
				{
					fgrid_Main.GetCellRange(arg_row, i, arg_row, i).StyleNew.BackColor = _CurrentColor;
				}
 
 


				size_f = size_t + 1;

				if(size_f == fgrid_Main.Cols.Count) break;

			} // end while 


		}


		#endregion

		#region Contextmenu


		private FlexBase.MaterialBase.Pop_Item_List_Show pop_form = null;


		/// <summary>
		/// Show_Item_Popup : Item 기타 데이터 입력하는 팝업 실행 : Item/ Specification/ Color
		/// </summary>
		private void Show_Item_Popup()
		{
			try
			{

				int sel_row = fgrid_Main.Selection.r1;
				int sel_col = fgrid_Main.Selection.c1;

				if(sel_row < fgrid_Main.Rows.Fixed) return;

				string item_cd = (fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD] == null) 
					? "" : fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD].ToString();

				string item_name = (fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_NAME] == null) 
					? "" : fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_NAME].ToString();
				
				string spec_cd = "";
				string spec_name = "";
				string color_cd = "";
				string color_name = "";
				string unit = ""; 
				string size_yn = ""; 

				//----------------------------------------------------------------------------------------------------------------------------
				// 선택 항목 바로 설정할 수 있도록 팝업 창 페이지 초기 설정
				//----------------------------------------------------------------------------------------------------------------------------
				string select = "Item";
				COM.ComVar.Parameter_PopUp = new string[] { select };
				//----------------------------------------------------------------------------------------------------------------------------

//				FlexBase.MaterialBase.Pop_Item_List pop_form = new FlexBase.MaterialBase.Pop_Item_List(item_cd, item_name, spec_cd, spec_name, color_cd, color_name, unit, size_yn);   


				if(pop_form == null)
				{

					pop_form = new FlexBase.MaterialBase.Pop_Item_List_Show(item_cd, item_name, spec_cd, spec_name, color_cd, color_name, unit, size_yn);
				 
				}
				else
				{
   
					pop_form._ItemCd = item_cd;
					pop_form._ItemName = item_name;
					pop_form._SpecCd = spec_cd;
					pop_form._SpecName = spec_name; 
					pop_form._ColorCd = color_cd;
					pop_form._ColorName = color_name;
					pop_form._Unit = unit;
					pop_form._SizeYN = size_yn; 


					pop_form.Init_Form(); 

				}



				pop_form.ShowDialog();
 
				fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxFACTORY] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
				fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD] = ClassLib.ComVar.Parameter_PopUp[0];
				fgrid_Main[sel_row, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_NAME] = ClassLib.ComVar.Parameter_PopUp[1];
				fgrid_Main[sel_row + 1, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxFACTORY] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
				fgrid_Main[sel_row + 1, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD] = ClassLib.ComVar.Parameter_PopUp[0];
				fgrid_Main[sel_row + 1, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_NAME] = ClassLib.ComVar.Parameter_PopUp[1];


				pop_form.Clear_All();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		#endregion

		#region event


		/// <summary>
		/// Create_Size_Group : 채산값 범위 또는 사이즈문대로 사이즈 Spec, Group 구성
		/// </summary>
		private void Create_Size_Group()
		{


			if(! chk_CreateSizeBySize.Checked) return;
			


			int size_f = -1, size_t = -1;
			int sel_row = fgrid_Main.Selection.r1;

			_CurrentColor = _SizeColor2;
			size_f = (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCS_SIZE_START;

			while(true)
			{


				// 사이즈 문대마다 sepc grouping  
				size_t = size_f; 



				_GroupCount++;
			 


				CellRange cr;
				cr = fgrid_Main.GetCellRange(sel_row, size_t, sel_row, size_f);
				cr.UserData = _GroupCount.ToString();
			

				// user setting flag
				cr = fgrid_Main.GetCellRange(sel_row + 1, size_t, sel_row + 1, size_f);
				cr.Data = "Y";

 


				// Set Size Group Color
				Display_SizeGroup_Color(sel_row);


				// update 표시
				fgrid_Main.Update_Row(sel_row);





				size_f = size_t + 1;

				if(size_f == fgrid_Main.Cols.Count) break;

			} // end while



			chk_CreateSizeBySize.Checked = false;

		}


		#endregion

 
		#endregion 

		#region 이벤트 처리

	
		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
			
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
			
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		
 

		#endregion   

		
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try 
			{
				 fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_itemGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void chk_CreateSizeBySize_CheckedChanged(object sender, System.EventArgs e)
		{
			try 
			{
				Create_Size_Group(); 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "chk_CreateSizeBySize_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		#region 아이템 조회 조건

		private string _itemGroupCode = " "; 

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try 
			{
				if ( cmb_itemGroup.SelectedIndex != -1 )
				{
					btn_groupSearch.Enabled = true;
					txt_itemGroup.Text = "";
					_itemGroupCode = cmb_itemGroup.SelectedValue.ToString();

				}
				else
				{
					
					btn_groupSearch.Enabled = false;
					txt_itemGroup.Text = "";
					_itemGroupCode = " ";
				}



				 fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_itemGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				string vTyep = cmb_itemGroup.SelectedValue.ToString();
				FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);
				
				vPopup.ShowDialog();
			
				_itemGroupCode = COM.ComVar.Parameter_PopUp[3];
				txt_itemGroup.Text	= COM.ComVar.Parameter_PopUp[4];

				vPopup.Dispose(); 

				 fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		#endregion

		#region 툴바


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{

				cmb_Factory.SelectedIndex = -1;
				cmb_itemGroup.SelectedIndex = -1;
				txt_itemGroup.Text = "";
				txt_itemCode.Text = "";
				txt_itemName.Text = "";
				fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{

				this.Cursor = Cursors.WaitCursor;


				string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
				string item_group = _itemGroupCode;
				string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
				string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");
				string this_factory = ClassLib.ComVar.This_Factory;

				DataTable dt_ret = Select_SBC_YIELD_SIZE_GROUP(factory, item_group, item_cd, item_name, this_factory);
				Display_Grid(dt_ret);
				dt_ret.Dispose();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
 

				int count_empty = 0;


				//행 수정 상태 해제
				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count-1, false);

 
				// factory, item empty check
				for(int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
				{

					if(fgrid_Main[i, 0] == null || fgrid_Main[i, 0].ToString().Trim().Equals("") ) continue;


					if(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxFACTORY] == null
						|| fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxFACTORY].ToString().Trim().Equals("") )
					{

						
						fgrid_Main.Select(i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxFACTORY, true); 
						count_empty++;
						
						break;
					}

					if(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD] == null
						|| fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD].ToString().Trim().Equals("") )
					{

						
						fgrid_Main.Select(i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD, true); 
						count_empty++;
						
						break;
					} 


				} 

				if(count_empty > 0)
				{
					ClassLib.ComFunction.Data_Message("Exist empty data.", ClassLib.ComVar.MgsDoNotSave, this);
					return; 
				}






				bool save_flag = Save_SBC_YIELD_SIZE_GROUP();
				
				if(save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);

					fgrid_Main.Refresh_Division();

				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				}


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


  
		#endregion

		#region Grid


		private void fgrid_Main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
			try
			{

				Set_SizeGroup(e.Button);

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_MouseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{

				if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
				{
					fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{ 
				fgrid_Main.Update_Row();  
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void fgrid_Main_DoubleClick(object sender, System.EventArgs e)
		{
		
			try
			{ 
				
				if(fgrid_Main.Col != (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD 
					&& fgrid_Main.Col != (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_NAME) return;
				

				Show_Item_Popup();

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		#endregion

		#region Contextmenu

		private void cmenu_Main_Popup(object sender, System.EventArgs e)
		{
		
			try
			{ 
				
				if(fgrid_Main.Selection.c1 < (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCS_SIZE_START)
				{
					//fgrid_Main.ContextMenu = cmenu_Main;
					menuItem_AddItem.Visible = true;
					menuItem_DeleteItem.Visible = true;
				}
				else
				{
					//fgrid_Main.ContextMenu = null;
					menuItem_AddItem.Visible = false;
					menuItem_DeleteItem.Visible = false;
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Main_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		} 


		private void menuItem_AddItem_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 

				this.Cursor = Cursors.WaitCursor;


				fgrid_Main.Add_Row(fgrid_Main.Rows.Count - 1);  
				fgrid_Main.Add_Row(fgrid_Main.Rows.Count - 1);  

				fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].Visible = false; // data_division
				fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "";  // data_division

				fgrid_Main.Select(fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD, true);  // data

				Show_Item_Popup();

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_AddItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}


		private void menuItem_DeleteItem_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				fgrid_Main.Delete_Row(); 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_DeleteItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}
 


		#endregion

        #endregion  
		
		#region DB Connect


		/// <summary>
		/// Select_SBC_YIELD_SIZE_GROUP : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_item_group"></param>
		/// <param name="arg_item_cd"></param>
		/// <param name="arg_item_name"></param>
		/// <param name="arg_this_factory"></param>
		/// <returns></returns>
		private DataTable Select_SBC_YIELD_SIZE_GROUP( string arg_factory, string arg_item_group, string arg_item_cd, string arg_item_name, string arg_this_factory)
		{

			try
			{

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBC_YIELD_SIZE_GROUP.SELECT_SBC_YIELD_SIZE_GROUP";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_ITEM_GROUP";
				MyOraDB.Parameter_Name[2] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[3] = "ARG_ITEM_NAME"; 
				MyOraDB.Parameter_Name[4] = "ARG_THIS_FACTORY"; 
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

				//04.DATA 정의
 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_item_group;
				MyOraDB.Parameter_Values[2] = arg_item_cd;
				MyOraDB.Parameter_Values[3] = arg_item_name; 
				MyOraDB.Parameter_Values[4] = arg_this_factory;
				MyOraDB.Parameter_Values[5] = "";

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();
				if(ds_ret == null) return null;

				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch
			{
				return null;
			}


		}




		/// <summary>
		/// Save_SBC_YIELD_SIZE_GROUP : 
		/// </summary>
		/// <returns></returns>
		private bool Save_SBC_YIELD_SIZE_GROUP()
		{

			try
			{ 

				
				int col_ct = 16;  	 
				CellRange cr;
				int size_f = -1, size_t = -1;
				string before_flag = "", now_flag = ""; 


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD_SIZE_GROUP.SAVE_SBC_YIELD_SIZE_GROUP";


				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[3] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[4] = "ARG_CS_SIZE_FROM";
				MyOraDB.Parameter_Name[5] = "ARG_CS_SIZE_TO";
				MyOraDB.Parameter_Name[6] = "ARG_CBD_CURRENCY";
				MyOraDB.Parameter_Name[7] = "ARG_CBD_PRICE";
				MyOraDB.Parameter_Name[8] = "ARG_WEIGHT";
				MyOraDB.Parameter_Name[9] = "ARG_CT_BOX_QTY";
				MyOraDB.Parameter_Name[10] = "ARG_SEASON"; 
				MyOraDB.Parameter_Name[11] = "ARG_CUST_CD"; 
				MyOraDB.Parameter_Name[12] = "ARG_REMARKS"; 
				MyOraDB.Parameter_Name[13] = "ARG_UPD_USER"; 
				MyOraDB.Parameter_Name[14] = "ARG_FACTORY_KEY"; 
				MyOraDB.Parameter_Name[15] = "ARG_ITEM_CD_KEY";  



				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 

				
			
				for(int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count ; i = i + 2)
				{
					
					if(fgrid_Main[i, 0] == null || fgrid_Main[i, 0].ToString().Trim().Equals("") ) continue;


					vList.Add("D"); 
					vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxFACTORY_KEY].ToString() ); 
					vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD_KEY].ToString() );  
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(ClassLib.ComVar.This_User);  
					vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxFACTORY_KEY].ToString() ); 
					vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD_KEY].ToString() );  



					if(fgrid_Main[i, 0].ToString().Trim().Equals("D") ) continue;


				    size_f = (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCS_SIZE_START;

						

					while(true)
					{

						cr = fgrid_Main.GetCellRange(i, size_f); 

						before_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 


						for(int k = size_f; k < fgrid_Main.Cols.Count; k++)
						{   

							cr = fgrid_Main.GetCellRange(i, k); 

							now_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 

							if(before_flag == now_flag)
							{
								size_t = k;
							}
							else
							{
								break;
							}

						}



						vList.Add("I"); 
						vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxFACTORY].ToString() ); 
						vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD].ToString() );  

//						vList.Add(fgrid_Main[1, size_f].ToString() + "-" + fgrid_Main[1, size_t].ToString());  // spec_cd

						
						if(fgrid_Main[i + 1, size_f] == null || ! fgrid_Main[i + 1, size_f].ToString().Trim().Equals("Y") )
						{
							vList.Add("NOTHING"); 
						}
						else
						{
							vList.Add(fgrid_Main[1, size_f].ToString() + "-" + fgrid_Main[1, size_t].ToString()); 
						}


						

						vList.Add(fgrid_Main[1, size_f].ToString() ); 
						vList.Add(fgrid_Main[1, size_t].ToString() );  
						vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCBD_CURRENCY].ToString() ); 
						vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCBD_PRICE].ToString() ); 
						vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxWEIGHT].ToString() ); 
						vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCT_BOX_QTY].ToString() ); 
						vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxSEASON].ToString() ); 
						vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxCUST_CD].ToString() ); 
						vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxREMARKS].ToString() ); 
						vList.Add(ClassLib.ComVar.This_User);  
						vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxFACTORY_KEY].ToString() ); 
						vList.Add(fgrid_Main[i, (int)ClassLib.TBSBC_YIELD_SIZE_GROUP.IxITEM_CD_KEY].ToString() );  
  


						size_f = size_t + 1;

						if(size_f == fgrid_Main.Cols.Count) break;

					} // end while 
					 
				} // end for i 

  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}

			}
			catch(Exception ex)
			{ 
				MessageBox.Show(ex.ToString() );
				return false;
			} 



		}


		#endregion 

		
	
	 

 

	}
}

