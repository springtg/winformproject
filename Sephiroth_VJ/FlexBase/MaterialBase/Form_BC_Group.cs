using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;

namespace FlexBase.MaterialBase
{
	public class Form_BC_Group : COM.PCHWinForm.Pop_Large 
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.ImageList img_MiniButton;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenu cmenu_menu1;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.MenuItem menuItem13;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.FSP fgrid_GroupTree;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_Group_Type;
		private C1.Win.C1List.C1Combo cmb_Group_L;
		private System.Windows.Forms.Label lbl_Group_L;
		private System.Windows.Forms.Label lbl_Group_Type;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.MenuItem menuItem_Separator1;
		private System.Windows.Forms.MenuItem menuItem_Return;
		public System.Windows.Forms.ImageList imageList1;

		public Form_BC_Group()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			 
			Init_Form();

		}




		private bool _ReturnYN = false;


		public Form_BC_Group(bool arg_return)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			 
			_ReturnYN = arg_return;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_Group));
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
            this.cmenu_menu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem_Separator1 = new System.Windows.Forms.MenuItem();
            this.menuItem_Return = new System.Windows.Forms.MenuItem();
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_BT = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.cmb_Group_Type = new C1.Win.C1List.C1Combo();
            this.cmb_Group_L = new C1.Win.C1List.C1Combo();
            this.lbl_Group_L = new System.Windows.Forms.Label();
            this.lbl_Group_Type = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.fgrid_GroupTree = new COM.FSP();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.stbar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_BT.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_GroupTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(504, 8);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
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
            // cmenu_menu1
            // 
            this.cmenu_menu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11,
            this.menuItem12,
            this.menuItem13,
            this.menuItem_Separator1,
            this.menuItem_Return});
            this.cmenu_menu1.Popup += new System.EventHandler(this.cmenu_menu1_Popup);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.Text = "Add";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 1;
            this.menuItem12.Text = "Modify";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.menuItem13.Text = "Delete";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem_Separator1
            // 
            this.menuItem_Separator1.Index = 3;
            this.menuItem_Separator1.Text = "-";
            // 
            // menuItem_Return
            // 
            this.menuItem_Return.Index = 4;
            this.menuItem_Return.Text = "Return";
            this.menuItem_Return.Click += new System.EventHandler(this.menuItem_Return_Click);
            // 
            // img_MiniButton
            // 
            this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
            this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_MiniButton.Images.SetKeyName(0, "");
            this.img_MiniButton.Images.SetKeyName(1, "");
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.pnl_BT);
            this.c1Sizer1.Controls.Add(this.fgrid_GroupTree);
            this.c1Sizer1.GridDefinition = "14.5833333333333:False:False;83.75:False:False;\t0.631313131313131:False:True;97.7" +
                "272727272727:False:False;0.631313131313131:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(792, 480);
            this.c1Sizer1.SplitterWidth = 0;
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_BT
            // 
            this.pnl_BT.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_BT.Controls.Add(this.pnl_SearchImage);
            this.pnl_BT.Location = new System.Drawing.Point(4, 4);
            this.pnl_BT.Name = "pnl_BT";
            this.pnl_BT.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pnl_BT.Size = new System.Drawing.Size(784, 70);
            this.pnl_BT.TabIndex = 45;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.cmb_Group_Type);
            this.pnl_SearchImage.Controls.Add(this.cmb_Group_L);
            this.pnl_SearchImage.Controls.Add(this.lbl_Group_L);
            this.pnl_SearchImage.Controls.Add(this.lbl_Group_Type);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(5, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(774, 65);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // cmb_Group_Type
            // 
            this.cmb_Group_Type.AddItemCols = 0;
            this.cmb_Group_Type.AddItemSeparator = ';';
            this.cmb_Group_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Group_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Group_Type.Caption = "";
            this.cmb_Group_Type.CaptionHeight = 17;
            this.cmb_Group_Type.CaptionStyle = style17;
            this.cmb_Group_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Group_Type.ColumnCaptionHeight = 18;
            this.cmb_Group_Type.ColumnFooterHeight = 18;
            this.cmb_Group_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Group_Type.ContentHeight = 17;
            this.cmb_Group_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Group_Type.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Group_Type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Group_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Group_Type.EditorHeight = 17;
            this.cmb_Group_Type.EvenRowStyle = style18;
            this.cmb_Group_Type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Group_Type.FooterStyle = style19;
            this.cmb_Group_Type.GapHeight = 2;
            this.cmb_Group_Type.HeadingStyle = style20;
            this.cmb_Group_Type.HighLightRowStyle = style21;
            this.cmb_Group_Type.ItemHeight = 15;
            this.cmb_Group_Type.Location = new System.Drawing.Point(111, 32);
            this.cmb_Group_Type.MatchEntryTimeout = ((long)(2000));
            this.cmb_Group_Type.MaxDropDownItems = ((short)(5));
            this.cmb_Group_Type.MaxLength = 32767;
            this.cmb_Group_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Group_Type.Name = "cmb_Group_Type";
            this.cmb_Group_Type.OddRowStyle = style22;
            this.cmb_Group_Type.PartialRightColumn = false;
            this.cmb_Group_Type.PropBag = resources.GetString("cmb_Group_Type.PropBag");
            this.cmb_Group_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Group_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Group_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Group_Type.SelectedStyle = style23;
            this.cmb_Group_Type.Size = new System.Drawing.Size(180, 21);
            this.cmb_Group_Type.Style = style24;
            this.cmb_Group_Type.TabIndex = 1;
            this.cmb_Group_Type.Tag = "";
            this.cmb_Group_Type.SelectedValueChanged += new System.EventHandler(this.cmb_Group_Type_SelectedValueChanged);
            // 
            // cmb_Group_L
            // 
            this.cmb_Group_L.AccessibleDescription = "";
            this.cmb_Group_L.AccessibleName = "";
            this.cmb_Group_L.AddItemCols = 0;
            this.cmb_Group_L.AddItemSeparator = ';';
            this.cmb_Group_L.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Group_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Group_L.Caption = "";
            this.cmb_Group_L.CaptionHeight = 17;
            this.cmb_Group_L.CaptionStyle = style25;
            this.cmb_Group_L.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Group_L.ColumnCaptionHeight = 18;
            this.cmb_Group_L.ColumnFooterHeight = 18;
            this.cmb_Group_L.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Group_L.ContentHeight = 16;
            this.cmb_Group_L.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Group_L.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Group_L.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Group_L.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Group_L.EditorHeight = 16;
            this.cmb_Group_L.EvenRowStyle = style26;
            this.cmb_Group_L.Font = new System.Drawing.Font("Verdana", 9F);
            this.cmb_Group_L.FooterStyle = style27;
            this.cmb_Group_L.GapHeight = 2;
            this.cmb_Group_L.HeadingStyle = style28;
            this.cmb_Group_L.HighLightRowStyle = style29;
            this.cmb_Group_L.ItemHeight = 15;
            this.cmb_Group_L.Location = new System.Drawing.Point(408, 33);
            this.cmb_Group_L.MatchEntryTimeout = ((long)(2000));
            this.cmb_Group_L.MaxDropDownItems = ((short)(5));
            this.cmb_Group_L.MaxLength = 32767;
            this.cmb_Group_L.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Group_L.Name = "cmb_Group_L";
            this.cmb_Group_L.OddRowStyle = style30;
            this.cmb_Group_L.PartialRightColumn = false;
            this.cmb_Group_L.PropBag = resources.GetString("cmb_Group_L.PropBag");
            this.cmb_Group_L.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Group_L.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Group_L.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Group_L.SelectedStyle = style31;
            this.cmb_Group_L.Size = new System.Drawing.Size(180, 20);
            this.cmb_Group_L.Style = style32;
            this.cmb_Group_L.TabIndex = 2;
            this.cmb_Group_L.SelectedValueChanged += new System.EventHandler(this.cmb_Group_L_SelectedValueChanged);
            // 
            // lbl_Group_L
            // 
            this.lbl_Group_L.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Group_L.ImageIndex = 0;
            this.lbl_Group_L.ImageList = this.img_Label;
            this.lbl_Group_L.Location = new System.Drawing.Point(307, 32);
            this.lbl_Group_L.Name = "lbl_Group_L";
            this.lbl_Group_L.Size = new System.Drawing.Size(100, 21);
            this.lbl_Group_L.TabIndex = 527;
            this.lbl_Group_L.Text = "Class (First)";
            this.lbl_Group_L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Group_Type
            // 
            this.lbl_Group_Type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Group_Type.ImageIndex = 0;
            this.lbl_Group_Type.ImageList = this.img_Label;
            this.lbl_Group_Type.Location = new System.Drawing.Point(10, 32);
            this.lbl_Group_Type.Name = "lbl_Group_Type";
            this.lbl_Group_Type.Size = new System.Drawing.Size(100, 21);
            this.lbl_Group_Type.TabIndex = 526;
            this.lbl_Group_Type.Text = "Group Type";
            this.lbl_Group_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(673, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 25);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(758, 0);
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
            this.picb_TM.Size = new System.Drawing.Size(550, 40);
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
            this.lbl_SubTitle1.Text = "      Item Group Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(758, 50);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 49);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(614, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 50);
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
            this.picb_ML.Size = new System.Drawing.Size(168, 32);
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
            this.picb_MM.Location = new System.Drawing.Point(144, 32);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(606, 33);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // fgrid_GroupTree
            // 
            this.fgrid_GroupTree.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_GroupTree.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this.fgrid_GroupTree.ContextMenu = this.cmenu_menu1;
            this.fgrid_GroupTree.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_GroupTree.Location = new System.Drawing.Point(9, 74);
            this.fgrid_GroupTree.Name = "fgrid_GroupTree";
            this.fgrid_GroupTree.Size = new System.Drawing.Size(774, 402);
            this.fgrid_GroupTree.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_GroupTree.Styles"));
            this.fgrid_GroupTree.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            // 
            // stbar
            // 
            this.stbar.CausesValidation = false;
            this.stbar.Enabled = false;
            this.stbar.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbar.Location = new System.Drawing.Point(0, 544);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(792, 22);
            this.stbar.TabIndex = 29;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 200;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 300;
            // 
            // Form_BC_Group
            // 
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.stbar);
            this.Controls.Add(this.c1Sizer1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_BC_Group";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_BT.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_GroupTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private int _Rowfixed = 3;
		public string Delete_Result = null;
		public int DeleteRow; 
		private COM.OraDB oraDB = null;
		public string arg_datamode;
		private COM.OraDB MyOraDB = new COM.OraDB();


		// 마지막 아이템 그룹 레벨
		private int _Level_SecondClass = 3;
		private int _Level_ThirdClass = 4;
 

		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			try
			{
                this.Text = "Item Group Master";
                this.lbl_MainTitle.Text = "Item Group Master";
				ClassLib.ComFunction.SetLangDic(this);

				oraDB = new COM.OraDB();

				#region 버튼 권한
				//			try
				//			{
				//				COM.OraDB btn_control = new COM.OraDB();
				//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
				//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
				//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
				//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
				//				btn_control = null;
				//			}
				//			catch
				//			{
				//			}
				#endregion

				//영문변환 사용
				ClassLib.ComFunction.SetLangDic(this);

				tbtn_New.Enabled = false;
				tbtn_Save.Enabled  = false;
				tbtn_Delete.Enabled = false;
				tbtn_Print.Enabled  = false;
				tbtn_Conform.Enabled  = false;


				// 그리드 설정 Tree
				fgrid_GroupTree.Set_Grid("SBC_ITEM_GROUP", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false);
				fgrid_GroupTree.Set_Action_Image(img_Action); 
				fgrid_GroupTree.Styles.Alternate.BackColor = Color.Empty;
 

				ClassLib.ComFunction.Set_TreeHeader(fgrid_GroupTree);


				


				//그룹타입 콤보쿼리
				DataTable dt_ret;
				dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
				ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_Group_Type, 0, 1, true, 40, 130);  
				dt_ret.Dispose();
 



				//Select_Menu_List(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		/// <summary>
		/// Select_Menu_List : 조회부에 맞는 데이터 그리드에 표시
		/// </summary>
		private void Select_Menu_List()
		{
			try
			{

				this.Cursor = Cursors.WaitCursor;

				DataTable dt_list; 
				 
				string group_type = ClassLib.ComFunction.Empty_Combo(cmb_Group_Type, " ");
				string group_l = ClassLib.ComFunction.Empty_Combo(cmb_Group_L, " ");
				string group_level = _Level_SecondClass.ToString();

				dt_list = Select_Group_List(group_type, group_l, group_level);

				fgrid_GroupTree.Rows.Count = _Rowfixed - 1;
				fgrid_GroupTree.Cols.Count = dt_list.Columns.Count + 1;
  
				fgrid_GroupTree.Rows.InsertNode(2, 0);
				Set_root(_Rowfixed - 1);

				for(int i=0; i < dt_list.Rows.Count; i++)
				{
					fgrid_GroupTree.Rows.InsertNode(i + _Rowfixed, int.Parse(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL-1].ToString()));
					insertcell(i, dt_list.Rows[i].ItemArray);

					//UseYN 에서 N 인 경우에 글자색을 빨간색으로... 
					if((string)dt_list.Rows[i].ItemArray[(int)ClassLib.TBSBC_ITEM_GROUP.IxUSE_YN - 1] == "FALSE")
					{
						fgrid_GroupTree.GetCellRange(i + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME, i + _Rowfixed, fgrid_GroupTree.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 
					}
 
					switch(int.Parse(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL-1].ToString()) )
					{
						case 1:  // group type
							fgrid_GroupTree.Rows[i + _Rowfixed].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
							break;

						case 2:  // first class
							fgrid_GroupTree.Rows[i + _Rowfixed].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
							break;

						case 3:  // second class
							fgrid_GroupTree.Rows[i + _Rowfixed].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
							break;
  
							
					}


					
				}

				SetCols();

				dt_list.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_Menu_List", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		/// <summary>
		/// Set_root : root menu 
		/// </summary>
		/// <param name="arg_rootrowcount"></param>
		private void Set_root(int arg_rootrowcount)
		{
			fgrid_GroupTree[arg_rootrowcount, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME] = "Group"; 
		}


		/// <summary>
		/// insertcell : 그리드에 값 넣기
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_incell"></param>
		private void insertcell(int arg_row, object[] arg_incell)
		{
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxDIVISION] = "";
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME] = arg_incell[0].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_CD] = arg_incell[1].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL] = arg_incell[2].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_TYPE] = arg_incell[3].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_L] = arg_incell[4].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_M] = arg_incell[5].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_S] = arg_incell[6].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxATTRIBUTE_MODEL] = arg_incell[7].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxATTRIBUTE_STYLE]  = arg_incell[8].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxATTRIBUTE_CMP] = arg_incell[9].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxATTRIBUTE_GENDER] = arg_incell[10].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxATTRIBUTE] = arg_incell[11].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxUSE_YN] = arg_incell[12].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_DS] = arg_incell[13].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_QD] = arg_incell[14].ToString();
            fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_VJ] = arg_incell[15].ToString();
            fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_JJ] = arg_incell[16].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxVALIDATION_KEY_01] = arg_incell[17].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP.IxVALIDATION_VALUE_01] = arg_incell[18].ToString();
		}


		 
		/// <summary>
		/// setCols : 그리드를 트리 형식으로 표시
		/// </summary>
		private void SetCols()
		{
			fgrid_GroupTree.Tree.Column = (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME;
			fgrid_GroupTree.Tree.Style = TreeStyleFlags.Complete;
			fgrid_GroupTree.Tree.Show(_Level_ThirdClass - 1); 
		}
		 



		#endregion 

		#region	이벤트 처리

		#region 콤보 이벤트


		private void cmb_Group_Type_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				DataTable dt_ret;

				cmb_Group_L.SelectedIndex = -1;
				fgrid_GroupTree.Rows.Count = fgrid_GroupTree.Rows.Fixed;

				if(cmb_Group_Type.SelectedIndex == -1) return; 

				dt_ret = ClassLib.ComFunction.Select_GroupLCode(cmb_Group_Type.SelectedValue.ToString());    
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Group_L, 0, 1, true, 20, 150);  

				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Group_Type_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}



		private void cmb_Group_L_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				//if(cmb_Group_Type.SelectedIndex == -1) return;

				//Select_Menu_List();

				fgrid_GroupTree.Rows.Count = fgrid_GroupTree.Rows.Fixed;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Group_L_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}


		}


		#endregion

		#region 버튼,그리드 이벤트

		/// <summary>
		/// 그룹 조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Select_Menu_List();

			if(fgrid_GroupTree.Rows.Count < _Rowfixed)
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
			}
			else
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}
 
 
		#endregion 

		#region	ContextMenu 이벤트



		private void cmenu_menu1_Popup(object sender, System.EventArgs e)
		{
			try
			{  

				if(fgrid_GroupTree.Rows.Count <= fgrid_GroupTree.Rows.Fixed) return;

				int sel_row = fgrid_GroupTree.Selection.r1;

//				if(Convert.ToInt32(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString() ) == _Level_SecondClass )
//				{
//					menuItem11.Enabled = true;
//				}
//				else
//				{
//					menuItem11.Enabled = false;
//				}


				fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL]
					= (fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL] == null) ? "0" : fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString();


				if(Convert.ToInt32(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString() ) >= _Level_SecondClass )
				{
					menuItem11.Enabled = false;
				}
				else
				{
					menuItem11.Enabled = true; 
				}




				if(_ReturnYN)
				{
					menuItem_Separator1.Visible = true;
					menuItem_Return.Visible = true;
				}
				else
				{
					menuItem_Separator1.Visible = false;
					menuItem_Return.Visible = false;
				}


				 
			} 
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message ,"cmenu_menu1_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}

		}
 





		/// <summary>
		/// 그룹추가
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			try
			{  
				//행 수정 상태 해제
				fgrid_GroupTree.Select(fgrid_GroupTree.Selection.r1, 0, fgrid_GroupTree.Selection.r1, fgrid_GroupTree.Cols.Count-1, false);
				
				int sel_row = fgrid_GroupTree.Selection.r1;
				
				int level = 0; 
				if(sel_row > fgrid_GroupTree.Rows.Fixed)
				{
					level = Convert.ToInt32(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString() );
				} 

				if(level == _Level_ThirdClass) return;





				if(sel_row >= fgrid_GroupTree.Rows.Fixed)
				{ 
					if(sel_row == fgrid_GroupTree.Rows.Fixed)
					{
						COM.ComVar.Parameter_PopUp = new string[]
						{
							arg_datamode = "I",
							"",
							"",
							"0",
							"",
							"",
							"",
							"",
							"0000",
							"",
							"",
							"",
							"",
							"",
							"",
                            ""
						};
					}
					else
					{ 
						COM.ComVar.Parameter_PopUp = new string[]
						{
							arg_datamode = "I",
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_CD].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_TYPE].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_L].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_M].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_S].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxATTRIBUTE].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxUSE_YN].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_DS].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_QD].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_VJ].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_JJ].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxVALIDATION_KEY_01].ToString(), " "),
							ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxVALIDATION_VALUE_01].ToString(), " ")


						};

					}

					Pop_GroupInfo pop_form = new Pop_GroupInfo();
					pop_form.ShowDialog();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this); 
					
					/*
					Select_Menu_List(); 
					fgrid_GroupTree.Tree.Show(level + 1);
					//fgrid_GroupTree.TopRow = sel_row;
					fgrid_GroupTree.Select(sel_row, 0, sel_row, fgrid_GroupTree.Cols.Count - 1, true);
					*/

					if(! pop_form._Close_Save) return;
					Refresh_Save_Data(sel_row, "I");



				}
			}

			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message ,"Item Group Add", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}



		/// <summary>
		/// Refresh_Save_Data : 
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_division"></param>
		private void Refresh_Save_Data(int arg_row, string arg_division)
		{

			string[] incell = new string[18];

			incell[0] = COM.ComVar.Parameter_PopUp[0];
			incell[1] = COM.ComVar.Parameter_PopUp[1];
			incell[2] = COM.ComVar.Parameter_PopUp[2];
			incell[3] = COM.ComVar.Parameter_PopUp[3];
			incell[4] = COM.ComVar.Parameter_PopUp[4];
			incell[5] = COM.ComVar.Parameter_PopUp[5];
			incell[6] = COM.ComVar.Parameter_PopUp[6];

			incell[7] = (COM.ComVar.Parameter_PopUp[7].Substring(0, 1) == "1") ? "True" : "False";
			incell[8] = (COM.ComVar.Parameter_PopUp[7].Substring(1, 1) == "1") ? "True" : "False";
			incell[9] = (COM.ComVar.Parameter_PopUp[7].Substring(2, 1) == "1") ? "True" : "False";
			incell[10] = (COM.ComVar.Parameter_PopUp[7].Substring(3, 1) == "1") ? "True" : "False";
			incell[11] = COM.ComVar.Parameter_PopUp[7];

			incell[12] = COM.ComVar.Parameter_PopUp[8]; //use_yn

			incell[13] = COM.ComVar.Parameter_PopUp[9];
			incell[14] = COM.ComVar.Parameter_PopUp[10];
            incell[15] = COM.ComVar.Parameter_PopUp[11];
            incell[16] = COM.ComVar.Parameter_PopUp[12];


			// purchase cbd validation data
			incell[17] = COM.ComVar.Parameter_PopUp[13];
			incell[18] = COM.ComVar.Parameter_PopUp[14];


			C1.Win.C1FlexGrid.Node node = fgrid_GroupTree.Rows[arg_row].Node;

			int current_row = -1; 

			if(arg_division == "I")
			{  
				node.AddNode(NodeTypeEnum.LastChild, "");

				current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
			}
			else
			{
				current_row = arg_row;
			}

			insertcell(current_row - _Rowfixed, incell);
  

			if(Convert.ToBoolean(COM.ComVar.Parameter_PopUp[8]) )
			{ 
				//use
				fgrid_GroupTree.GetCellRange(current_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME, current_row, fgrid_GroupTree.Cols.Count - 1).StyleNew.ForeColor = Color.Black; 
 
				if(COM.ComVar.Parameter_PopUp[3] != "1")
				{
					//하위 레벨 그룹이 사용 가능할때 상위는 항상 사용 가능으로 처리
					int parent_row = node.GetNode(NodeTypeEnum.Parent).Row.Index; 

					fgrid_GroupTree[parent_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxUSE_YN] = "True";
					fgrid_GroupTree.GetCellRange(parent_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME, parent_row, fgrid_GroupTree.Cols.Count - 1).StyleNew.ForeColor = Color.Black; 
				} 

			}
			else
			{
				//not use
				fgrid_GroupTree.GetCellRange(current_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME, current_row, fgrid_GroupTree.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 
			}




			//-------------------------------------------------------------------------------------------
			//하위 레벨 그룹 모두 사용자, 사용 여부, Validation 값 수정 처리 
			//-------------------------------------------------------------------------------------------
			if(node.GetNode(NodeTypeEnum.FirstChild) != null)
			{
 


				int parent_level = Convert.ToInt32(fgrid_GroupTree[node.Row.Index, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString() );
				int now_level = 0;

				for(int i = node.Row.Index + 1; i < fgrid_GroupTree.Rows.Count; i++)
				{
					now_level = Convert.ToInt32(fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString() );


					if(parent_level < now_level)  // 하위 레벨
					{


//						if(now_level == _Level_ThirdClass)
//						{
							fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_DS] = COM.ComVar.Parameter_PopUp[9];
							fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_QD] = COM.ComVar.Parameter_PopUp[10];
                            fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_VJ] = COM.ComVar.Parameter_PopUp[11];
                            fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_JJ] = COM.ComVar.Parameter_PopUp[12]; 

							fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxVALIDATION_KEY_01] = COM.ComVar.Parameter_PopUp[13]; 
							fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxVALIDATION_VALUE_01] = COM.ComVar.Parameter_PopUp[14]; 

//						}


						//-------------------------------------------------------------------------------------------
						if(Convert.ToBoolean(COM.ComVar.Parameter_PopUp[8]) )
						{ 
							//use
							fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxUSE_YN] = "True";
							fgrid_GroupTree.GetCellRange(i, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME, i, fgrid_GroupTree.Cols.Count - 1).StyleNew.ForeColor = Color.Black; 

						}
						else
						{
							//not use
							fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxUSE_YN] = "False";
							fgrid_GroupTree.GetCellRange(i, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME, i, fgrid_GroupTree.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 

						}
						//------------------------------------------------------------------------------------------- 


					} // end if(parent_level < now_level)  // 하위 레벨 
					else
					{
						// 상위가 틀릴 경우이므로, break
						break;
					}

				} // end for i




			}
			//-------------------------------------------------------------------------------------------





			fgrid_GroupTree.TopRow = current_row - 1;
			fgrid_GroupTree.Select(current_row, 1, current_row, fgrid_GroupTree.Cols.Count - 1, true);

		}




		/// <summary>
		/// 그룹수정
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			try
			{
				//행 수정 상태 해제
				fgrid_GroupTree.Select(fgrid_GroupTree.Selection.r1, 0, fgrid_GroupTree.Selection.r1, fgrid_GroupTree.Cols.Count-1, false);
				
				int sel_row = fgrid_GroupTree.Selection.r1;

				int level = 0; 
				if(sel_row > fgrid_GroupTree.Rows.Fixed)
				{
					level = Convert.ToInt32(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString() );
				} 	

				if(sel_row >= fgrid_GroupTree.Rows.Fixed)
				{
					COM.ComVar.Parameter_PopUp = new string[]
					{
						arg_datamode = "U",
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_CD].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_TYPE].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_L].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_M].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_S].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxATTRIBUTE].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxUSE_YN].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_DS].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_QD].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_VJ].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_JJ].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxVALIDATION_KEY_01].ToString(), " "),
						ClassLib.ComFunction.Empty_String(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxVALIDATION_VALUE_01].ToString(), " ")

					};

					

					
					Pop_GroupInfo pop_form = new Pop_GroupInfo(); 
					pop_form.ShowDialog();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);

					if(! pop_form._Close_Save) return;
					Refresh_Save_Data(sel_row, "U");

					 
				}
			}

			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		}

		/// <summary>
		/// 그룹삭제 => 실제 삭제가 아니고 USE_YN을 "N"으로 Update
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			try
			{
				//행 수정 상태 해제
				fgrid_GroupTree.Select(fgrid_GroupTree.Selection.r1, 0, fgrid_GroupTree.Selection.r1, fgrid_GroupTree.Cols.Count-1, false);
				
				int sel_row = fgrid_GroupTree.Selection.r1;
				
				int level = 0; 
				if(sel_row > fgrid_GroupTree.Rows.Fixed)
				{
					level = Convert.ToInt32(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString() );
				} 

				if(sel_row >= fgrid_GroupTree.Rows.Fixed)
				{
					Delete_Group(sel_row);

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
 

					//not use
					fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxUSE_YN] = "False";
					fgrid_GroupTree.GetCellRange(sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME, sel_row, fgrid_GroupTree.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 

					//하위 레벨 그룹 모두 not use 처리
					C1.Win.C1FlexGrid.Node node = fgrid_GroupTree.Rows[sel_row].Node;

					if(node.GetNode(NodeTypeEnum.FirstChild) == null) return;

//					int child_row1 = node.GetNode(NodeTypeEnum.FirstChild).Row.Index; 
//					int child_row2 = node.GetNode(NodeTypeEnum.LastChild).Row.Index; 
//
//					for(int i = child_row1; i <= child_row2; i++)
//					{
//						fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxUSE_YN] = "False";
//						fgrid_GroupTree.GetCellRange(i, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME, i, fgrid_GroupTree.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 
//					}


					int parent_level = Convert.ToInt32(fgrid_GroupTree[node.Row.Index, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString() );
					int now_level = 0;

					for(int i = node.Row.Index + 1; i < fgrid_GroupTree.Rows.Count; i++)
					{
						now_level = Convert.ToInt32(fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString() );


						if(parent_level < now_level)  // 하위 레벨
						{
							//not use
							fgrid_GroupTree[i, (int)ClassLib.TBSBC_ITEM_GROUP.IxUSE_YN] = "False";
							fgrid_GroupTree.GetCellRange(i, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME, i, fgrid_GroupTree.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 


						} // end if(parent_level < now_level)  // 하위 레벨 
						else
						{
							// 상위가 틀릴 경우이므로, break
							break;
						}

					} // end for i



					
				}
		
			}

			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}

		}




		private void menuItem_Return_Click(object sender, System.EventArgs e)
		{
			try
			{
				Return_GroupCode();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message,"menuItem_Return_Click",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		}


		/// <summary>
		/// Return_GroupCode : 
		/// </summary>
		private void Return_GroupCode()
		{
			try
			{
				int sel_row = 0, sel_level = 0; 

				sel_row = fgrid_GroupTree.Selection.r1; 
				if(sel_row < fgrid_GroupTree.Rows.Fixed) return;
				
				sel_level = Convert.ToInt32(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString() );
				if(sel_level != _Level_SecondClass) //!= _Level_ThirdClass) 
				{
					//ClassLib.ComFunction.User_Message("Return Only Third Class", "Item Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					ClassLib.ComFunction.User_Message("Return Only Second Class", "Item Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

 
				//DataTable dt_ret;

				string group_cd = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_CD].ToString();
//				dt_ret = Check_Duplicate_DB(group_cd);


				string group_type = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_TYPE].ToString();

				//bool return_yn = Convert.IsDBNull(dt_ret.Rows[0].ItemArray[0]);
				bool return_yn = true;


				// 중복 아님, 저장 가능
				if(return_yn)  
				{


					ClassLib.ComVar.Parameter_PopUp = new string[] {group_type, 
																	   fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_L].ToString(), 
																	   fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_M].ToString(), 
																	   fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_CD].ToString(), 
																	   fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME].ToString(),
																	   fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_DS].ToString(),
																	   fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_QD].ToString(),
																	   fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_VJ].ToString(),
																	   fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxMAN_CHARGE_JJ].ToString() };
 

					//dt_ret.Dispose(); 
					this.Close();

				} // end if
				else
				{
					ClassLib.ComFunction.User_Message("Duplicate Group Code : [" + group_cd + "]", "Return", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
					ClassLib.ComVar.Parameter_PopUp = new string[] {group_type, 
																	   "", 
																	   "", 
																	   "", 
																	   "",
																	   "",
																	   "",
																	   "",
                                                                       ""}; 
					 

					//dt_ret.Dispose(); 

				} 


				this.Close();

			} 
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message,"Return_GroupCode",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		}



		/// <summary>
		/// Check_Duplicate_DB : 
		/// </summary>
		///<param name="arg_groupcd"></param>
		/// <returns></returns>
		private DataTable Check_Duplicate_DB(string arg_groupcd)
		{  
			try
			{
				DataSet ds_ret;  

				MyOraDB.ReDim_Parameter(2);
				MyOraDB.Process_Name = "PKG_SBC_ITEM.CHECK_GROUP_CD_EXIST"; 
				
				MyOraDB.Parameter_Name[0] = "ARG_GROUP_CD"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = @"'" + arg_groupcd + @"'";
				MyOraDB.Parameter_Values[1] = ""; 
				 
				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
				  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Check_Duplicate_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			} 
		}




		#endregion


		#endregion 

		#region  DB Connect


		/// <summary>
		/// Select_Group_List : Group List 조회
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Group_List(string arg_group_type, string arg_group_l, string arg_group_level)
		{
			 
			DataSet ds_ret;

			string process_name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_TO_LEVEL";

			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_GROUP_TYPE";
			MyOraDB.Parameter_Name[1] = "ARG_GROUP_L";
			MyOraDB.Parameter_Name[2] = "ARG_GROUP_LEVEL";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_group_type; 
			MyOraDB.Parameter_Values[1] = arg_group_l;
			MyOraDB.Parameter_Values[2] = arg_group_level;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}



		/// <summary>
		/// Master에는 삭제가 없으므로 UseYN 필드를 "N"으로 업데이트...
		/// </summary>
		private void Delete_Group(int sel_row)
		{

			try
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(17); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBC_ITEM_GROUP.SAVE_SBC_ITEM_GROUP";

				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_GROUP_TYPE";
				MyOraDB.Parameter_Name[2]  = "ARG_GROUP_L"; 
				MyOraDB.Parameter_Name[3]  = "ARG_GROUP_M";
				MyOraDB.Parameter_Name[4]  = "ARG_GROUP_S";
				MyOraDB.Parameter_Name[5]  = "ARG_GROUP_NAME";
				MyOraDB.Parameter_Name[6]  = "ARG_GROUP_CD";
				MyOraDB.Parameter_Name[7]  = "ARG_GROUP_LEVEL";
				MyOraDB.Parameter_Name[8]  = "ARG_MAN_CHARGE_DS";
				MyOraDB.Parameter_Name[9]  = "ARG_MAN_CHARGE_QD";
                MyOraDB.Parameter_Name[10] = "ARG_MAN_CHARGE_VJ";
                MyOraDB.Parameter_Name[11] = "ARG_MAN_CHARGE_JJ";
				MyOraDB.Parameter_Name[12]  = "ARG_USE_YN";
				MyOraDB.Parameter_Name[13]  = "ARG_ATTRIBUTE";
				MyOraDB.Parameter_Name[14]  = "ARG_VALIDATION_KEY_01"; 
				MyOraDB.Parameter_Name[15]  = "ARG_VALIDATION_VALUE_01";
				MyOraDB.Parameter_Name[16]  = "ARG_UPD_USER"; 



				//03.DATA TYPE
				for (int i = 0; i < 14; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			

				//04.DATA 정의 
				MyOraDB.Parameter_Values[0]   = "D";
				MyOraDB.Parameter_Values[1]   = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_TYPE].ToString();
				MyOraDB.Parameter_Values[2]   = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_L].ToString();
				MyOraDB.Parameter_Values[3]   = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_M].ToString();
				MyOraDB.Parameter_Values[4]   = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_S].ToString();
				MyOraDB.Parameter_Values[5]   = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_NAME].ToString();
				MyOraDB.Parameter_Values[6]   = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_CD].ToString();
				MyOraDB.Parameter_Values[7]   = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_LEVEL].ToString();
				MyOraDB.Parameter_Values[8]   = "";
				MyOraDB.Parameter_Values[9]   = "";
                MyOraDB.Parameter_Values[10] = "";
                MyOraDB.Parameter_Values[11] = "";
                MyOraDB.Parameter_Values[12] = "N";
                MyOraDB.Parameter_Values[13] = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxATTRIBUTE].ToString();
                MyOraDB.Parameter_Values[14] = "";
                MyOraDB.Parameter_Values[15] = "";
				MyOraDB.Parameter_Values[16]  = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true); 

				ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행		
					
				//Error 처리
				if(ds_ret == null) 
				{
					ClassLib.ComFunction.Data_Message("Delete", ClassLib.ComVar.MgsDoNotSave, this); 
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message ,"Delete_Group", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}





		#endregion

		

		
 

	}
}

