using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;


namespace FlexPurchase.Incoming
{
	public class Pop_BI_Incoming_Purchase_Overseas : COM.PCHWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_purNo;
		private System.Windows.Forms.Label lbl_purNo;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private COM.FSP fgrid_Main;
		private System.Windows.Forms.ContextMenu cmenu_Grid;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_DeSelectAll;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem_SelectCR;
		private System.Windows.Forms.MenuItem menuItem_DeselectCR;
		private System.Windows.Forms.MenuItem menuItem_TreeViewOption;
		private System.Windows.Forms.MenuItem menuItem_TreeViewHead;
		private System.Windows.Forms.MenuItem menuItem_TreeViewDetail;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자


		public Pop_BI_Incoming_Purchase_Overseas()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		COM.FSP _Fgrid_Main = null;
		private string _Factory = "";
		private string _InYmd = "";


		public Pop_BI_Incoming_Purchase_Overseas(COM.FSP arg_fgrid, string arg_factory, string arg_in_ymd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Fgrid_Main = arg_fgrid;
			_Factory = arg_factory;
			_InYmd = arg_in_ymd;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BI_Incoming_Purchase_Overseas));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_Main = new COM.FSP();
            this.cmenu_Grid = new System.Windows.Forms.ContextMenu();
            this.menuItem_TreeViewOption = new System.Windows.Forms.MenuItem();
            this.menuItem_TreeViewHead = new System.Windows.Forms.MenuItem();
            this.menuItem_TreeViewDetail = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
            this.menuitem_DeSelectAll = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem_SelectCR = new System.Windows.Forms.MenuItem();
            this.menuItem_DeselectCR = new System.Windows.Forms.MenuItem();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_purNo = new C1.Win.C1List.C1Combo();
            this.lbl_purNo = new System.Windows.Forms.Label();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.fgrid_Main);
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.GridDefinition = "17.4:False:True;73.4:False:False;6:False:True;\t0.505050505050505:False:True;96.96" +
                "9696969697:False:False;0.505050505050505:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(792, 500);
            this.c1Sizer1.TabIndex = 26;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this.fgrid_Main.ContextMenu = this.cmenu_Grid;
            this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Main.Location = new System.Drawing.Point(12, 95);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Size = new System.Drawing.Size(768, 367);
            this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Main.Styles"));
            this.fgrid_Main.TabIndex = 173;
            this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // cmenu_Grid
            // 
            this.cmenu_Grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_TreeViewOption,
            this.menuItem5,
            this.menuitem_SelectAll,
            this.menuitem_DeSelectAll,
            this.menuItem3,
            this.menuItem_SelectCR,
            this.menuItem_DeselectCR});
            // 
            // menuItem_TreeViewOption
            // 
            this.menuItem_TreeViewOption.Index = 0;
            this.menuItem_TreeViewOption.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_TreeViewHead,
            this.menuItem_TreeViewDetail});
            this.menuItem_TreeViewOption.Text = "Tree View Option";
            // 
            // menuItem_TreeViewHead
            // 
            this.menuItem_TreeViewHead.Index = 0;
            this.menuItem_TreeViewHead.Text = "Head";
            this.menuItem_TreeViewHead.Click += new System.EventHandler(this.menuItem_TreeViewHead_Click);
            // 
            // menuItem_TreeViewDetail
            // 
            this.menuItem_TreeViewDetail.Index = 1;
            this.menuItem_TreeViewDetail.Text = "Detail";
            this.menuItem_TreeViewDetail.Click += new System.EventHandler(this.menuItem_TreeViewDetail_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "-";
            // 
            // menuitem_SelectAll
            // 
            this.menuitem_SelectAll.Index = 2;
            this.menuitem_SelectAll.Text = "Select All";
            this.menuitem_SelectAll.Click += new System.EventHandler(this.menuitem_SelectAll_Click);
            // 
            // menuitem_DeSelectAll
            // 
            this.menuitem_DeSelectAll.Index = 3;
            this.menuitem_DeSelectAll.Text = "DeSelect All";
            this.menuitem_DeSelectAll.Click += new System.EventHandler(this.menuitem_DeSelectAll_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            this.menuItem3.Text = "-";
            // 
            // menuItem_SelectCR
            // 
            this.menuItem_SelectCR.Index = 5;
            this.menuItem_SelectCR.Text = "Select Selection Range";
            this.menuItem_SelectCR.Click += new System.EventHandler(this.menuItem_SelectCR_Click);
            // 
            // menuItem_DeselectCR
            // 
            this.menuItem_DeselectCR.Index = 6;
            this.menuItem_DeselectCR.Text = "Deselect Selection Range";
            this.menuItem_DeselectCR.Click += new System.EventHandler(this.menuItem_DeselectCR_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Controls.Add(this.btn_close);
            this.pnl_menu.Controls.Add(this.btn_apply);
            this.pnl_menu.Location = new System.Drawing.Point(12, 466);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(768, 30);
            this.pnl_menu.TabIndex = 172;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(680, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(80, 23);
            this.btn_close.TabIndex = 547;
            this.btn_close.Text = "Cancel";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_close.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(599, 3);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(80, 23);
            this.btn_apply.TabIndex = 546;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmb_purNo);
            this.panel1.Controls.Add(this.lbl_purNo);
            this.panel1.Controls.Add(this.cmb_user);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.lbl_vendor);
            this.panel1.Controls.Add(this.txt_vendorCode);
            this.panel1.Controls.Add(this.cmb_vendor);
            this.panel1.Controls.Add(this.cmb_factory);
            this.panel1.Controls.Add(this.lbl_factory);
            this.panel1.Controls.Add(this.lbl_shipDate);
            this.panel1.Controls.Add(this.lblexcep_mark);
            this.panel1.Controls.Add(this.dpick_to);
            this.panel1.Controls.Add(this.dpick_from);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 87);
            this.panel1.TabIndex = 170;
            // 
            // cmb_purNo
            // 
            this.cmb_purNo.AddItemCols = 0;
            this.cmb_purNo.AddItemSeparator = ';';
            this.cmb_purNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purNo.Caption = "";
            this.cmb_purNo.CaptionHeight = 17;
            this.cmb_purNo.CaptionStyle = style1;
            this.cmb_purNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purNo.ColumnCaptionHeight = 18;
            this.cmb_purNo.ColumnFooterHeight = 18;
            this.cmb_purNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purNo.ContentHeight = 16;
            this.cmb_purNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_purNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purNo.EditorHeight = 16;
            this.cmb_purNo.EvenRowStyle = style2;
            this.cmb_purNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purNo.FooterStyle = style3;
            this.cmb_purNo.GapHeight = 2;
            this.cmb_purNo.HeadingStyle = style4;
            this.cmb_purNo.HighLightRowStyle = style5;
            this.cmb_purNo.ItemHeight = 15;
            this.cmb_purNo.Location = new System.Drawing.Point(447, 15);
            this.cmb_purNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_purNo.MaxDropDownItems = ((short)(5));
            this.cmb_purNo.MaxLength = 32767;
            this.cmb_purNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purNo.Name = "cmb_purNo";
            this.cmb_purNo.OddRowStyle = style6;
            this.cmb_purNo.PartialRightColumn = false;
            this.cmb_purNo.PropBag = resources.GetString("cmb_purNo.PropBag");
            this.cmb_purNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purNo.SelectedStyle = style7;
            this.cmb_purNo.Size = new System.Drawing.Size(220, 20);
            this.cmb_purNo.Style = style8;
            this.cmb_purNo.TabIndex = 379;
            this.cmb_purNo.SelectedValueChanged += new System.EventHandler(this.cmb_purNo_SelectedValueChanged);
            // 
            // lbl_purNo
            // 
            this.lbl_purNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purNo.ImageIndex = 0;
            this.lbl_purNo.ImageList = this.img_Label;
            this.lbl_purNo.Location = new System.Drawing.Point(346, 15);
            this.lbl_purNo.Name = "lbl_purNo";
            this.lbl_purNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_purNo.TabIndex = 378;
            this.lbl_purNo.Text = "Purchase No";
            this.lbl_purNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_user
            // 
            this.cmb_user.AddItemCols = 0;
            this.cmb_user.AddItemSeparator = ';';
            this.cmb_user.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_user.Caption = "";
            this.cmb_user.CaptionHeight = 17;
            this.cmb_user.CaptionStyle = style9;
            this.cmb_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_user.ColumnCaptionHeight = 18;
            this.cmb_user.ColumnFooterHeight = 18;
            this.cmb_user.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_user.ContentHeight = 16;
            this.cmb_user.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_user.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_user.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_user.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_user.EditorHeight = 16;
            this.cmb_user.EvenRowStyle = style10;
            this.cmb_user.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FooterStyle = style11;
            this.cmb_user.GapHeight = 2;
            this.cmb_user.HeadingStyle = style12;
            this.cmb_user.HighLightRowStyle = style13;
            this.cmb_user.ItemHeight = 15;
            this.cmb_user.Location = new System.Drawing.Point(109, 59);
            this.cmb_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_user.MaxDropDownItems = ((short)(5));
            this.cmb_user.MaxLength = 32767;
            this.cmb_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.OddRowStyle = style14;
            this.cmb_user.PartialRightColumn = false;
            this.cmb_user.PropBag = resources.GetString("cmb_user.PropBag");
            this.cmb_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_user.SelectedStyle = style15;
            this.cmb_user.Size = new System.Drawing.Size(220, 20);
            this.cmb_user.Style = style16;
            this.cmb_user.TabIndex = 369;
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ImageIndex = 0;
            this.lbl_user.ImageList = this.img_Label;
            this.lbl_user.Location = new System.Drawing.Point(8, 59);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_user.TabIndex = 370;
            this.lbl_user.Text = "User";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(346, 37);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 368;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(447, 37);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 366;
            this.txt_vendorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vendorCode_KeyPress);
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemCols = 0;
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style17;
            this.cmb_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_vendor.ColumnCaptionHeight = 18;
            this.cmb_vendor.ColumnFooterHeight = 18;
            this.cmb_vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_vendor.ContentHeight = 16;
            this.cmb_vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_vendor.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_vendor.EditorHeight = 16;
            this.cmb_vendor.EvenRowStyle = style18;
            this.cmb_vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style19;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style20;
            this.cmb_vendor.HighLightRowStyle = style21;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(527, 37);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style22;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style23;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style24;
            this.cmb_vendor.TabIndex = 367;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style25;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 16;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 16;
            this.cmb_factory.EvenRowStyle = style26;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style27;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style28;
            this.cmb_factory.HighLightRowStyle = style29;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 15);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style30;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style31;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style32;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 15);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 180;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipDate
            // 
            this.lbl_shipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipDate.ImageIndex = 1;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 37);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 52;
            this.lbl_shipDate.Text = "Purchase Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(216, 37);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(8, 16);
            this.lblexcep_mark.TabIndex = 178;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(231, 37);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 5;
            this.dpick_to.CloseUp += new System.EventHandler(this.dpick_to_CloseUp);
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 37);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 4;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // Pop_BI_Incoming_Purchase_Overseas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.c1Sizer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pop_BI_Incoming_Purchase_Overseas";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

 
		private COM.OraDB MyOraDB = new COM.OraDB();   

		// tree level
		private int _LevelHead = 0;
		private int _LevelDetail = 1; 


		// return table
		public DataTable _DT_Return = null;



		#endregion 

		#region 멤버 메서드


		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			
			try
			{ 
			
				 
				//Title
				this.Text = "Incoming Purchase";
                lbl_MainTitle.Text = "Incoming Purchase";
                ClassLib.ComFunction.SetLangDic(this);
 

				fgrid_Main.Set_Grid("SBI_IN_OVERSEAS_PUR", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
				fgrid_Main.ExtendLastCol = false; 
				//fgrid_Main.Font = new Font("Verdana", 7);
				fgrid_Main.AllowSorting = AllowSortingEnum.None;
				fgrid_Main.AllowDragging = AllowDraggingEnum.None;
				fgrid_Main.Tree.Style = TreeStyleFlags.Complete;
				fgrid_Main.Tree.Column = (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1; 




				Init_Control();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

  
		}


		
		/// <summary>
		/// Init_Control : 
		/// </summary>
		private void Init_Control()
		{
  

			// Disabled tbutton
			tbtn_Save.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Conform.Enabled = false;
			tbtn_Create.Enabled = false;

 
			 
			 
			// Factory Combobox Add Items
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			dt_ret.Dispose();

			 

			if(! _Factory.Trim().Equals("") )
			{
				cmb_factory.SelectedValue = _Factory;
				dpick_from.Value = ClassLib.ComFunction.StringToDateTime(_InYmd);
				dpick_to.Value = ClassLib.ComFunction.StringToDateTime(_InYmd);

				Init_Control_cmb_PurNo();

			}
			else
			{
				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			}


		}  



		#endregion
		  
		#region 조회

 
		#endregion
 
		#region 툴바 이벤트 메서드



		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary> 
		private void Event_Tbtn_New()
		{ 

			dpick_from.Value = System.DateTime.Now;
			dpick_to.Value = System.DateTime.Now;
			
			cmb_user.SelectedIndex = -1;
			cmb_purNo.SelectedIndex = -1;
			txt_vendorCode.Text = "";
			cmb_vendor.SelectedIndex = -1;

			fgrid_Main.ClearAll();

		}



		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{
    
			// 조회시 필수조건 체크 
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory}; 
			System.Windows.Forms.TextBox[] txt_array = {};  
			bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array); 
			if(! previous_check) return;


			string factory = cmb_factory.SelectedValue.ToString();
			string pur_ymd_from = dpick_from.Value.ToString("yyyyMMdd");
			string pur_ymd_to = dpick_to.Value.ToString("yyyyMMdd");
			string pur_no = ClassLib.ComFunction.Empty_Combo(cmb_purNo, "");
			string user = ClassLib.ComFunction.Empty_Combo(cmb_user, "");
			string vendor = ClassLib.ComFunction.Empty_Combo(cmb_vendor, ""); 
		
			DataTable dt_ret = Select_SBI_IN_PURCHASE(factory, pur_ymd_from, pur_ymd_to, pur_no, user, vendor); 
			Display_Grid(dt_ret); 
			dt_ret.Dispose();



		} 



		private void Event_Tbtn_Print()
		{
  
			string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Purchase");


			string sPara  = " /rp ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
			sPara += "'" + dpick_from.Text.Replace("-","") +		"' ";
			sPara += "'" + dpick_to.Text.Replace("-", "") +		"' ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_purNo, "") +	"' ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_user, "") +	"' ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_vendor, "") +	"' ";

			if(ClassLib.ComFunction.Empty_Combo(cmb_vendor, "") == "")
			{
				sPara += "'" + "" +	"' ";
			}
			else
			{
				sPara += "'" + cmb_vendor.Columns[1].Text +	"' ";
			}
  

			FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Purchase List";
			MyReport.Show();	


		}



		#region Event_Tbtn_Search



		/// <summary>
		/// Display_Grid : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Grid(DataTable arg_dt)
		{

			  
			fgrid_Main.ClearAll(); 

			if(arg_dt.Rows.Count == 0) return; 

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				int level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxTREE_LEVEL - 1].ToString() );
				fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, level);

				fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "";

				for(int j = (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxTREE_LEVEL; j <= (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxCOLOR_CD; j++)
				{

					fgrid_Main[fgrid_Main.Rows.Count - 1, j] = (arg_dt.Rows[i].ItemArray[j - 1] == null) ? "" : arg_dt.Rows[i].ItemArray[j - 1].ToString();

					// 공백 처리 한번 더
					if(fgrid_Main[fgrid_Main.Rows.Count - 1, j] == null)
					{
						fgrid_Main[fgrid_Main.Rows.Count - 1, j] = "";
					}


				} // end for j



				fgrid_Main.SetCellCheck(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1, CheckEnum.Unchecked);




				CellRange cr = fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, 1, fgrid_Main.Rows.Count - 1, fgrid_Main.Cols.Count - 1);

				if(level == _LevelHead)
				{
					cr.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;	
				}
				else
				{
					cr.StyleNew.BackColor = Color.Empty;
				}

			} // end for i
 
			fgrid_Main.Tree.Show(_LevelHead);
			fgrid_Main.Tree.Style = TreeStyleFlags.Complete;
			fgrid_Main.Tree.Column = (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1; 


		}



		#endregion


		#endregion 

		#region 그리드 이벤트 메서드


		/// <summary>
		/// Event_fgrid_Main_BeforeEdit : 
		/// </summary>
		private void Event_fgrid_Main_BeforeEdit()
		{
			if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
			{
				fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
			}

		}


		/// <summary>
		/// Event_fgrid_Main_AfterEdit : 
		/// </summary>
		private void Event_fgrid_Main_AfterEdit()
		{ 

			bool check = (fgrid_Main.GetCellCheck(fgrid_Main.Row, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1) == CheckEnum.Checked) ? true : false;
 

			if(fgrid_Main.Rows[fgrid_Main.Row].AllowEditing && fgrid_Main.Rows[fgrid_Main.Row].Node.Level == _LevelHead)
			{ 
				Check_Child(fgrid_Main.Row, check); 
			}
			else if(fgrid_Main.Rows[fgrid_Main.Row].AllowEditing && fgrid_Main.Rows[fgrid_Main.Row].Node.Level == _LevelDetail)
			{ 
				Check_Parent(fgrid_Main.Row, check); 
			} 


		}
 
		
		/// <summary>
		/// Event_fgrid_Main_DoubleClick : 
		/// </summary>
		private void Event_fgrid_Main_DoubleClick()
		{
		}


  
		#endregion

		#region 버튼 및 기타 이벤트 메서드

	 

		/// <summary>
		/// Event_cmb_factory_SelectedValueChanged : 
		/// </summary>
		private void Event_cmb_factory_SelectedValueChanged()
		{


			if(cmb_factory.SelectedIndex == -1) return;


			Event_Tbtn_New(); 


			string factory = cmb_factory.SelectedValue.ToString();

			// user
			DataTable dt_ret = ClassLib.ComFunction.Select_Man_Charge(ClassLib.ComVar.This_Factory);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 1, 2, (dt_ret.Rows.Count > 1) ? true : false);
			cmb_user.SelectedIndex = 0;

 

			// pur_no
			Init_Control_cmb_PurNo();

			dt_ret.Dispose();

 

		}

 

		/// <summary>
		/// Init_Control_cmb_PurNo : 
		/// </summary>
		private void Init_Control_cmb_PurNo()
		{

			if(cmb_factory.SelectedIndex == -1) return;  



			string factory = cmb_factory.SelectedValue.ToString();
			string pur_ymd_from = dpick_from.Value.ToString("yyyyMMdd");
			string pur_ymd_to = dpick_to.Value.ToString("yyyyMMdd");

			DataTable dt_ret = Select_Pur_No(factory, pur_ymd_from, pur_ymd_to);
			//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_purNo, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
			ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_purNo, 0, 1, true, 0, cmb_purNo.Width - 10);
			dt_ret.Dispose();



		}



		/// <summary>
		/// Event_txt_vendorCode_KeyPress : 
		/// </summary>
		private void Event_txt_vendorCode_KeyPress()
		{

			DataTable dt_ret = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(ClassLib.ComVar.This_Factory,  txt_vendorCode.Text.Trim());
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_vendor, 0, 1, true, 79, 141);

			if (dt_ret.Rows.Count > 0 && dt_ret.Rows.Count < 2)
			{
				cmb_vendor.SelectedIndex = 1; 
			}
			else if (dt_ret == null || dt_ret.Rows.Count <= 0) 
			{
				cmb_vendor.SelectedIndex = 0; 
			}

			dt_ret.Dispose();

		}





		/// <summary>
		/// Return_Data : 
		/// </summary>
		private void Return_Data()
		{

			ClassLib.ComVar.Parameter_PopUp = new string[2]; 
			ClassLib.ComVar.Parameter_PopUp[1]	= "Select Incoming WareHouse";
			ClassLib.ComVar.Parameter_PopUp[0]	= "WareHouse";

			DataTable dt_ret = FlexPurchase.ClassLib.ComFunction.SELECT_WAREHOUSE_LIST_USING(ClassLib.ComVar.This_Factory);
			ClassLib.ComVar.Parameter_PopUpTable = dt_ret;
			dt_ret.Dispose();

			Pop_BI_Incoming_List_Changer pop_changer = new Pop_BI_Incoming_List_Changer();
			pop_changer.ShowDialog();


			if(ClassLib.ComVar.Parameter_PopUp == null)
			{
				 
				_DT_Return = null;
				pop_changer.Dispose();
				return;
				 
			}
 

			string wh_cd = ClassLib.ComVar.Parameter_PopUp[0]; 
			pop_changer.Dispose();


			Make_DT_OVERSEAS(wh_cd); 

		}



		/// <summary>
		/// Make_DT_OVERSEAS : 
		/// </summary>
		/// <param name="arg_wh_cd"></param>
		private void Make_DT_OVERSEAS(string arg_wh_cd)
		{


			_DT_Return = null;
			_DT_Return = new DataTable("Purchase");

			for(int i = (int)ClassLib.TBSBI_IN_OVERSEAS.IxDIVISION; i <= (int)ClassLib.TBSBI_IN_OVERSEAS.IxCOLOR_CD; i++)
			{
				_DT_Return.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			}


			DataRow datarow = null; 
			int duplicate_flag = 0;

			for(int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
			{

				if(fgrid_Main.GetCellCheck(i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1).Equals(CheckEnum.Unchecked) ) continue;



				duplicate_flag = Etc_DataDuplicateCheck_FSP(i);


				// duplicate_flag
				// 0 : 메인 화면 그리드에서 항목 삭제 처리 하여 중복 제거
				// 1 : 선택하지 않음, 선택해제
				// -1 : 적용 모두 취소
				if(duplicate_flag == 0) 
				{ 

					datarow = _DT_Return.NewRow();

					for(int aa = 0; aa < _DT_Return.Columns.Count; aa++)
					{
						datarow[aa] = "";
					}


 
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxTREE_LEVEL - 1]	= fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxTREE_LEVEL].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxDESC1 - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxDESC2 - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC2].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxDESC3 - 1 ]= fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC3].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxITEM_NAME - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxITEM_NAME].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSPEC_NAME - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxSPEC_NAME].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCOLOR_NAME - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxCOLOR_NAME].ToString();
				
					//datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxIN_QTY - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxNOW_QTY].ToString();

					if(fgrid_Main.Rows[i].Node.Level == _LevelHead)
					{
						int first_child_row = fgrid_Main.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
						int last_child_row = fgrid_Main.Rows[i].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;
						double sum_in_qty = 0;

						for(int aa = first_child_row; aa <= last_child_row; aa++)
						{

							if(fgrid_Main.GetCellCheck(aa, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1).Equals(CheckEnum.Unchecked) ) continue;

							sum_in_qty += Convert.ToDouble(fgrid_Main[aa, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxNOW_QTY].ToString() );

						} // end for aa

						datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxIN_QTY - 1] = sum_in_qty.ToString();


					}
					else if(fgrid_Main.Rows[i].Node.Level == _LevelDetail)
					{
						datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxIN_QTY - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxNOW_QTY].ToString();
					}
				
				
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxUNIT - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxUNIT].ToString(); 
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPUR_CURRENCY - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxPUR_CURRENCY].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPUR_PRICE - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxPUR_PRICE].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCUST_CD - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxCUST_CD].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCUST_NAME - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxCUST_NAME].ToString(); 
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxOUTSIDE_CURRENCY - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxOUTSIDE_CURRENCY].ToString(); 
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxOUTSIDE_PRICE - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxOUTSIDE_PRICE].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCBD_CURRENCY - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxCBD_CURRENCY].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCBD_PRICE - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxCBD_PRICE].ToString(); 
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxLEDGER_CURRENCY - 1] = "";
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxLEDGER_PRICE - 1] =  "0"; 
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPK_UNIT_QTY - 1] =  fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxPK_UNIT_QTY].ToString(); 
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPRICE_YN - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxPRICE_YN].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxTAX_CD - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxTAX_CD].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSHIP_YMD - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxSHIP_YMD].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSHIP_NO - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxSHIP_NO].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSHIP_QTY - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxSHIP_QTY].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSTYLE_CD - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxSTYLE_CD].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSTYLE_NAME - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxSTYLE_NAME].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxWH_CD - 1] = arg_wh_cd;
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPAY_CD - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxPAY_CD].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPUR_NO - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxPUR_NO].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPUR_SEQ - 1] = fgrid_Main[i,(int)ClassLib.TBSBI_IN_OVERSEAS_PUR. IxPUR_SEQ].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPUR_USER - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxPUR_USER].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPUR_DEPT - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxPUR_DEPT].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxTRAN_DIV - 1] = "P";
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxITEM_CD - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxITEM_CD].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSPEC_CD - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxSPEC_CD].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCOLOR_CD - 1] = fgrid_Main[i,(int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxCOLOR_CD].ToString();
					datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxMOD_QTY - 1] = fgrid_Main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxNOW_QTY].ToString();
						 
 

					
					_DT_Return.Rows.Add(datarow); 	

				}
				else if(duplicate_flag == -1)
				{
					_DT_Return = null;
					break;
				}


			} // end for i


			

		}




		/// <summary>
		/// Etc_DataDuplicateCheck_FSP : 메인 데이터 중복 체크
		/// </summary>
		/// <param name="arg_row"></param>
		/// <returns></returns>
		private int Etc_DataDuplicateCheck_FSP(int arg_row)
		{
			int vReturn = 0;

			for ( int vRow = _Fgrid_Main.Rows.Fixed ; vRow < _Fgrid_Main.Rows.Count ; vRow++ )
			{
				if( _Fgrid_Main[vRow, (int)ClassLib.TBSBI_IN_OVERSEAS.IxSTYLE_CD].ToString().Trim().Equals(fgrid_Main[arg_row, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxSTYLE_CD].ToString().Trim() ) &&
					_Fgrid_Main[vRow, (int)ClassLib.TBSBI_IN_OVERSEAS.IxITEM_CD].ToString().Trim().Equals(fgrid_Main[arg_row, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxITEM_CD].ToString().Trim() ) &&
					_Fgrid_Main[vRow, (int)ClassLib.TBSBI_IN_OVERSEAS.IxSPEC_CD].ToString().Trim().Equals(fgrid_Main[arg_row, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxSPEC_CD].ToString().Trim() ) &&
					_Fgrid_Main[vRow, (int)ClassLib.TBSBI_IN_OVERSEAS.IxCOLOR_CD].ToString().Trim().Equals(fgrid_Main[arg_row, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxCOLOR_CD].ToString().Trim() ) &&
					_Fgrid_Main[vRow, (int)ClassLib.TBSBI_IN_OVERSEAS.IxPUR_NO].ToString().Trim().Equals(fgrid_Main[arg_row, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxPUR_NO].ToString().Trim() ) &&
					_Fgrid_Main[vRow, (int)ClassLib.TBSBI_IN_OVERSEAS.IxPUR_SEQ].ToString().Trim().Equals(fgrid_Main[arg_row, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxPUR_SEQ].ToString().Trim() )) 
				{
					string vMessage = "The selected item is already exists \r\n" +
						"Choose process.. \r\n\r\n" +
						"[Yes] : overwrite the existing data \r\n" +
						"[No] : deselect current item \r\n" +
						"[Cancel] : process abort \r\n\r\n" +
						"Row Number : " + arg_row + 1 + "\r\n" + 
						"Item : " + fgrid_Main[arg_row, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxITEM_NAME].ToString().Trim() + 
						"  Spec : " + fgrid_Main[arg_row, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxSPEC_NAME].ToString().Trim() +
						"  Color : "+ fgrid_Main[arg_row, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxCOLOR_NAME].ToString().Trim() + "\t";

					_Fgrid_Main.Select(vRow, 1);

					switch (MessageBox.Show(this, vMessage, "Duplicate Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
					{
						case DialogResult.Yes:
							
							string vTag = (_Fgrid_Main[vRow, 0] == null) ? "" : _Fgrid_Main[vRow, 0].ToString();
						
							if (vTag.Equals(ClassLib.ComVar.Insert))
							{
								_Fgrid_Main.RemoveItem(vRow);
							}
							else
							{
								_Fgrid_Main.Delete_Row(vRow);
							}
							
							vReturn = 0;
							
							break;

						case DialogResult.No:

							vReturn = 1;

							break;

						case DialogResult.Cancel:

							vReturn = -1;

							break;

					} // end switch


					break;
				}				
			}

			return vReturn;
		}





		 
		#endregion
 
		#region 컨텍스트 메뉴 이벤트 메서드



		private void Event_menuItem_TreeViewHead()
		{
			fgrid_Main.Tree.Show(_LevelHead);
		}



		private void Event_menuItem_TreeViewDetail()
		{
			fgrid_Main.Tree.Show(_LevelDetail);
		}



		private void Select_SelectionAll(bool arg_select)
		{ 
			 
			for(int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
			{
				if(! fgrid_Main.Rows[i].AllowEditing) continue;

				fgrid_Main.SetCellCheck(i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1, (arg_select) ? CheckEnum.Checked : CheckEnum.Unchecked);
			} 

		}



		private void Select_SelectionRange(bool arg_select)
		{


			foreach (int i in fgrid_Main.Selections)
			{

				fgrid_Main.SetCellCheck(i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1, (arg_select) ? CheckEnum.Checked : CheckEnum.Unchecked);


				if(fgrid_Main.Rows[i].AllowEditing && fgrid_Main.Rows[i].Node.Level == _LevelHead)
				{ 
					Check_Child(i, arg_select);
				}
				else if(fgrid_Main.Rows[i].AllowEditing && fgrid_Main.Rows[i].Node.Level == _LevelDetail)
				{ 
					Check_Parent(i, arg_select);
				} 

			} // end foreach

 

		} 

 

		private void Check_Child(int arg_row, bool arg_select)
		{

			C1.Win.C1FlexGrid.Node parent_node = fgrid_Main.Rows[arg_row].Node;
			int first_child_row = parent_node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
			int last_child_row = parent_node.GetNode(NodeTypeEnum.LastChild).Row.Index;

			for(int i = first_child_row; i <= last_child_row; i++)
			{
				if(! fgrid_Main.Rows[i].AllowEditing) continue;

				fgrid_Main.SetCellCheck(i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1, (arg_select) ? CheckEnum.Checked : CheckEnum.Unchecked);
			} 

		}



		private void Check_Parent(int arg_row, bool arg_select)
		{

			C1.Win.C1FlexGrid.Node parent_node = fgrid_Main.Rows[arg_row].Node.GetNode(NodeTypeEnum.Parent);

			if(arg_select)
			{ 
				fgrid_Main.SetCellCheck(parent_node.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1, CheckEnum.Checked);
			}
			else
			{
				
				int first_child_row = parent_node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
				int last_child_row = parent_node.GetNode(NodeTypeEnum.LastChild).Row.Index;

				int check_count = 0;

				for(int i = first_child_row; i <= last_child_row; i++)
				{
					 
					if(fgrid_Main.GetCellCheck(i, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1).Equals(CheckEnum.Checked) )
					{
						check_count++;
					}

				} // end for i


				if(check_count == 0)
				{
					fgrid_Main.SetCellCheck(parent_node.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1, CheckEnum.Unchecked);
				}
				else
				{
					fgrid_Main.SetCellCheck(parent_node.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_PUR.IxDESC1, CheckEnum.Checked);
				}


			} // end if(arg_select)


		}



		#endregion    


		#endregion 

		#region 이벤트 처리

		#region 툴바 이벤트


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_New();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

				Event_Tbtn_Search(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}  
		 
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Print(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 


		#endregion

		#region 그리드 이벤트

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				Event_fgrid_Main_AfterEdit();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				Event_fgrid_Main_BeforeEdit();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_main_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_fgrid_Main_DoubleClick();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_main_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}
	 
		


		#endregion

		#region 버튼 및 기타 이벤트


		#region 버튼 이미지 이벤트

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  
		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			} 
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  
		}

		#endregion

		 

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_cmb_factory_SelectedValueChanged();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			try
			{ 
				fgrid_Main.ClearAll();

				dpick_to.Value = dpick_from.Value; 
				Init_Control_cmb_PurNo();	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_from_CloseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

	 
		private void dpick_to_CloseUp(object sender, System.EventArgs e)
		{
			try
			{ 
				fgrid_Main.ClearAll();

				Init_Control_cmb_PurNo();		 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_to_CloseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		
		}
 

		private void cmb_purNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{ 
				//Event_Tbtn_Search();		 

				fgrid_Main.ClearAll();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_purNo_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		
		      
		private void txt_vendorCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

			try
			{

				if( (int)e.KeyChar != 13) return;

				fgrid_Main.ClearAll();

				Event_txt_vendorCode_KeyPress();

				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_vendorCode_KeyPress", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}





		private void btn_apply_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Return_Data();
				this.Close(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			
			try
			{
				_DT_Return = null;
				this.Close(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_close_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		


		#endregion   

		#region 컨텍스트 메뉴 이벤트


		private void menuItem_TreeViewHead_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_menuItem_TreeViewHead(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_TreeViewHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuItem_TreeViewDetail_Click(object sender, System.EventArgs e)
		{
			
			try
			{
				Event_menuItem_TreeViewDetail(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_TreeViewDetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuitem_SelectAll_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Select_SelectionAll(true);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_SelectionAll", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void menuitem_DeSelectAll_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Select_SelectionAll(false);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_SelectionAll", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

 

		private void menuItem_SelectCR_Click(object sender, System.EventArgs e)
		{
			
			try
			{ 
				Select_SelectionRange(true);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_SelectionRange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuItem_DeselectCR_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Select_SelectionRange(false);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_SelectionRange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		 
		#endregion

		#endregion 

		#region 디비 연결


		#region 콤보
  


		/// <summary>
		/// Select_Pur_No : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_pur_ymd_from"></param>
		/// <param name="arg_pur_ymd_to"></param>
		/// <returns></returns>
		private DataTable Select_Pur_No(string arg_factory, string arg_pur_ymd_from, string arg_pur_ymd_to)
		{

			try
			{

				DataSet ds_rert;

				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBI_IN_PURCHASE.SELECT_SBI_PUR_NO";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM";
				MyOraDB.Parameter_Name[2] = "ARG_TO";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_pur_ymd_from;
				MyOraDB.Parameter_Values[2] = arg_pur_ymd_to;
				MyOraDB.Parameter_Values[3] = "";

				MyOraDB.Add_Select_Parameter(true);
				ds_rert = MyOraDB.Exe_Select_Procedure();

				if(ds_rert == null) return null;
				return ds_rert.Tables[MyOraDB.Process_Name];

			}
			catch
			{
				return null;
			}

		}


		#endregion
 
		#region 조회

		
		/// <summary>
		/// Select_SBI_IN_PURCHASE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_pur_ymd_from"></param>
		/// <param name="arg_pur_ymd_to"></param>
		/// <param name="arg_pur_no"></param>
		/// <param name="arg_user"></param>
		/// <param name="arg_vendor"></param>
		/// <returns></returns>
		private DataTable Select_SBI_IN_PURCHASE(string arg_factory, 
			string arg_pur_ymd_from, 
			string arg_pur_ymd_to, 
			string arg_pur_no, 
			string arg_user, 
			string arg_vendor)
		{
 

			try
			{

				MyOraDB.ReDim_Parameter(7);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBI_IN_OVERSEAS.SELECT_SBI_IN_PUR_OVERSEAS";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_PUR_YMD_FROM";
				MyOraDB.Parameter_Name[2] = "ARG_PUR_YMD_TO";
				MyOraDB.Parameter_Name[3] = "ARG_PUR_NO";
				MyOraDB.Parameter_Name[4] = "ARG_USER";
				MyOraDB.Parameter_Name[5] = "ARG_VENDOR"; 
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
				MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(this.cmb_factory, "");
				MyOraDB.Parameter_Values[1] = dpick_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[2] = dpick_to.Text.Replace("-", "");
				MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(this.cmb_purNo, "");
				MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(this.cmb_user, "");
				MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(this.cmb_vendor, "");
				MyOraDB.Parameter_Values[6] = "";

				MyOraDB.Add_Select_Parameter(true);
				DataSet ds_ret = MyOraDB.Exe_Select_Procedure();
				if(ds_ret == null) return null ;

				return ds_ret.Tables[MyOraDB.Process_Name];	

			}
			catch
			{
				return null;
			}


		}



		 
		#endregion      

		
		#endregion

		

	



	}
}

