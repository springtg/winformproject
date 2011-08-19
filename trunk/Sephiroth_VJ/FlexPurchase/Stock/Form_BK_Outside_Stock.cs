using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using FlexPurchase.Shipping;
using FlexPurchase.Incoming;
using System.Threading;


namespace FlexPurchase.Stock
{
	public class Form_BK_Outside_Stock : COM.PCHWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.PictureBox pic_head3;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private COM.FSP fgrid_main;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.Label lbl_headInfo;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_itemGroup;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.Label lbl_shipDate;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private System.Windows.Forms.Label lbl_shipType;
		private C1.Win.C1List.C1Combo cmb_searchType;
		private C1.Win.C1List.C1Combo cmb_status;
		private System.Windows.Forms.Label lbl_status;
		private C1.Win.C1List.C1Combo cmb_dateType;
		private System.Windows.Forms.Label lbl_dateType;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.TextBox txt_styleCode;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.ContextMenu cmenu_grid;
		private System.Windows.Forms.MenuItem menuItem_ValueChange;
		private System.Windows.Forms.MenuItem menuItem_Qty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label btn_Create;
		private System.Windows.Forms.Label btn_Outgoing;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.DateTimePicker dpick_Out;
		private System.Windows.Forms.TextBox txt_InSum;
		private System.Windows.Forms.TextBox txt_OutSum;
		private System.Windows.Forms.TextBox txt_Count;
		private System.Windows.Forms.Label lbl_date;
		private System.Windows.Forms.Label lbl_search;

		#region 생성자 / 소멸자

		public Form_BK_Outside_Stock()
		{
			InitializeComponent();
		}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BK_Outside_Stock));
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
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style49 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style50 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style51 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style52 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style53 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style54 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style55 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style56 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_main = new COM.FSP();
            this.cmenu_grid = new System.Windows.Forms.ContextMenu();
            this.menuItem_ValueChange = new System.Windows.Forms.MenuItem();
            this.menuItem_Qty = new System.Windows.Forms.MenuItem();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.txt_InSum = new System.Windows.Forms.TextBox();
            this.txt_OutSum = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_style = new System.Windows.Forms.Label();
            this.txt_styleCode = new System.Windows.Forms.TextBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.cmb_dateType = new C1.Win.C1List.C1Combo();
            this.lbl_dateType = new System.Windows.Forms.Label();
            this.cmb_status = new C1.Win.C1List.C1Combo();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cmb_searchType = new C1.Win.C1List.C1Combo();
            this.lbl_search = new System.Windows.Forms.Label();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_itemGroup = new System.Windows.Forms.Label();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Create = new System.Windows.Forms.Label();
            this.btn_Outgoing = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.dpick_Out = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_dateType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_searchType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 634);
            this.stbar.Size = new System.Drawing.Size(1016, 32);
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "25:False:True;72.8102189781022:False:False;\t0.393700787401575:False:True;97.63779" +
                "52755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 548);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ContextMenu = this.cmenu_grid;
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(12, 145);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(992, 399);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 34;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // cmenu_grid
            // 
            this.cmenu_grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_ValueChange,
            this.menuItem_Qty});
            // 
            // menuItem_ValueChange
            // 
            this.menuItem_ValueChange.Index = 0;
            this.menuItem_ValueChange.Text = "Value Change";
            this.menuItem_ValueChange.Click += new System.EventHandler(this.menuItem_ValueChange_Click);
            // 
            // menuItem_Qty
            // 
            this.menuItem_Qty.Index = 1;
            this.menuItem_Qty.Text = "Out Q\'ty => In Q\'ty";
            this.menuItem_Qty.Click += new System.EventHandler(this.menuItem_Qty_Click);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.txt_InSum);
            this.pnl_head.Controls.Add(this.txt_OutSum);
            this.pnl_head.Controls.Add(this.txt_Count);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.lbl_style);
            this.pnl_head.Controls.Add(this.txt_styleCode);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.cmb_dateType);
            this.pnl_head.Controls.Add(this.lbl_dateType);
            this.pnl_head.Controls.Add(this.cmb_status);
            this.pnl_head.Controls.Add(this.lbl_status);
            this.pnl_head.Controls.Add(this.cmb_searchType);
            this.pnl_head.Controls.Add(this.lbl_search);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_itemGroup);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.label5);
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.txt_itemNm);
            this.pnl_head.Controls.Add(this.txt_itemCd);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_shipDate);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pictureBox1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 137);
            this.pnl_head.TabIndex = 33;
            // 
            // txt_InSum
            // 
            this.txt_InSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InSum.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_InSum.Location = new System.Drawing.Point(587, 106);
            this.txt_InSum.MaxLength = 10;
            this.txt_InSum.Name = "txt_InSum";
            this.txt_InSum.Size = new System.Drawing.Size(69, 21);
            this.txt_InSum.TabIndex = 563;
            // 
            // txt_OutSum
            // 
            this.txt_OutSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OutSum.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_OutSum.Location = new System.Drawing.Point(513, 106);
            this.txt_OutSum.MaxLength = 10;
            this.txt_OutSum.Name = "txt_OutSum";
            this.txt_OutSum.Size = new System.Drawing.Size(72, 21);
            this.txt_OutSum.TabIndex = 562;
            // 
            // txt_Count
            // 
            this.txt_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Count.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Count.Location = new System.Drawing.Point(436, 106);
            this.txt_Count.MaxLength = 10;
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(76, 21);
            this.txt_Count.TabIndex = 561;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(335, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 560;
            this.label1.Text = "Count / Out / In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(335, 40);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 559;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCode
            // 
            this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCode.Location = new System.Drawing.Point(436, 40);
            this.txt_styleCode.MaxLength = 10;
            this.txt_styleCode.Name = "txt_styleCode";
            this.txt_styleCode.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCode.TabIndex = 557;
            this.txt_styleCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCode_KeyUp);
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemCols = 0;
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style1;
            this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_style.ColumnCaptionHeight = 18;
            this.cmb_style.ColumnFooterHeight = 18;
            this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_style.ContentHeight = 16;
            this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_style.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_style.EditorHeight = 16;
            this.cmb_style.EvenRowStyle = style2;
            this.cmb_style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style3;
            this.cmb_style.GapHeight = 2;
            this.cmb_style.HeadingStyle = style4;
            this.cmb_style.HighLightRowStyle = style5;
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(516, 40);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style6;
            this.cmb_style.PartialRightColumn = false;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style7;
            this.cmb_style.Size = new System.Drawing.Size(140, 20);
            this.cmb_style.Style = style8;
            this.cmb_style.TabIndex = 558;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            // 
            // cmb_dateType
            // 
            this.cmb_dateType.AddItemCols = 0;
            this.cmb_dateType.AddItemSeparator = ';';
            this.cmb_dateType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_dateType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_dateType.Caption = "";
            this.cmb_dateType.CaptionHeight = 17;
            this.cmb_dateType.CaptionStyle = style9;
            this.cmb_dateType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_dateType.ColumnCaptionHeight = 18;
            this.cmb_dateType.ColumnFooterHeight = 18;
            this.cmb_dateType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_dateType.ContentHeight = 16;
            this.cmb_dateType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_dateType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_dateType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_dateType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_dateType.EditorHeight = 16;
            this.cmb_dateType.EvenRowStyle = style10;
            this.cmb_dateType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_dateType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dateType.FooterStyle = style11;
            this.cmb_dateType.GapHeight = 2;
            this.cmb_dateType.HeadingStyle = style12;
            this.cmb_dateType.HighLightRowStyle = style13;
            this.cmb_dateType.ItemHeight = 15;
            this.cmb_dateType.Location = new System.Drawing.Point(763, 62);
            this.cmb_dateType.MatchEntryTimeout = ((long)(2000));
            this.cmb_dateType.MaxDropDownItems = ((short)(5));
            this.cmb_dateType.MaxLength = 32767;
            this.cmb_dateType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_dateType.Name = "cmb_dateType";
            this.cmb_dateType.OddRowStyle = style14;
            this.cmb_dateType.PartialRightColumn = false;
            this.cmb_dateType.PropBag = resources.GetString("cmb_dateType.PropBag");
            this.cmb_dateType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_dateType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_dateType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_dateType.SelectedStyle = style15;
            this.cmb_dateType.Size = new System.Drawing.Size(220, 20);
            this.cmb_dateType.Style = style16;
            this.cmb_dateType.TabIndex = 555;
            // 
            // lbl_dateType
            // 
            this.lbl_dateType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_dateType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateType.ImageIndex = 0;
            this.lbl_dateType.ImageList = this.img_Label;
            this.lbl_dateType.Location = new System.Drawing.Point(662, 62);
            this.lbl_dateType.Name = "lbl_dateType";
            this.lbl_dateType.Size = new System.Drawing.Size(100, 21);
            this.lbl_dateType.TabIndex = 556;
            this.lbl_dateType.Text = "Date Type";
            this.lbl_dateType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_status
            // 
            this.cmb_status.AddItemCols = 0;
            this.cmb_status.AddItemSeparator = ';';
            this.cmb_status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_status.Caption = "";
            this.cmb_status.CaptionHeight = 17;
            this.cmb_status.CaptionStyle = style17;
            this.cmb_status.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_status.ColumnCaptionHeight = 18;
            this.cmb_status.ColumnFooterHeight = 18;
            this.cmb_status.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_status.ContentHeight = 16;
            this.cmb_status.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_status.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_status.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_status.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_status.EditorHeight = 16;
            this.cmb_status.EvenRowStyle = style18;
            this.cmb_status.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FooterStyle = style19;
            this.cmb_status.GapHeight = 2;
            this.cmb_status.HeadingStyle = style20;
            this.cmb_status.HighLightRowStyle = style21;
            this.cmb_status.ItemHeight = 15;
            this.cmb_status.Location = new System.Drawing.Point(763, 84);
            this.cmb_status.MatchEntryTimeout = ((long)(2000));
            this.cmb_status.MaxDropDownItems = ((short)(5));
            this.cmb_status.MaxLength = 32767;
            this.cmb_status.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.OddRowStyle = style22;
            this.cmb_status.PartialRightColumn = false;
            this.cmb_status.PropBag = resources.GetString("cmb_status.PropBag");
            this.cmb_status.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_status.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_status.SelectedStyle = style23;
            this.cmb_status.Size = new System.Drawing.Size(220, 20);
            this.cmb_status.Style = style24;
            this.cmb_status.TabIndex = 553;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ImageIndex = 0;
            this.lbl_status.ImageList = this.img_Label;
            this.lbl_status.Location = new System.Drawing.Point(662, 84);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_status.TabIndex = 554;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_searchType
            // 
            this.cmb_searchType.AddItemCols = 0;
            this.cmb_searchType.AddItemSeparator = ';';
            this.cmb_searchType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_searchType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_searchType.Caption = "";
            this.cmb_searchType.CaptionHeight = 17;
            this.cmb_searchType.CaptionStyle = style25;
            this.cmb_searchType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_searchType.ColumnCaptionHeight = 18;
            this.cmb_searchType.ColumnFooterHeight = 18;
            this.cmb_searchType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_searchType.ContentHeight = 16;
            this.cmb_searchType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_searchType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_searchType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_searchType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_searchType.EditorHeight = 16;
            this.cmb_searchType.EvenRowStyle = style26;
            this.cmb_searchType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_searchType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_searchType.FooterStyle = style27;
            this.cmb_searchType.GapHeight = 2;
            this.cmb_searchType.HeadingStyle = style28;
            this.cmb_searchType.HighLightRowStyle = style29;
            this.cmb_searchType.ItemHeight = 15;
            this.cmb_searchType.Location = new System.Drawing.Point(763, 40);
            this.cmb_searchType.MatchEntryTimeout = ((long)(2000));
            this.cmb_searchType.MaxDropDownItems = ((short)(5));
            this.cmb_searchType.MaxLength = 32767;
            this.cmb_searchType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_searchType.Name = "cmb_searchType";
            this.cmb_searchType.OddRowStyle = style30;
            this.cmb_searchType.PartialRightColumn = false;
            this.cmb_searchType.PropBag = resources.GetString("cmb_searchType.PropBag");
            this.cmb_searchType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_searchType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_searchType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_searchType.SelectedStyle = style31;
            this.cmb_searchType.Size = new System.Drawing.Size(220, 20);
            this.cmb_searchType.Style = style32;
            this.cmb_searchType.TabIndex = 553;
            this.cmb_searchType.TextChanged += new System.EventHandler(this.cmb_searchType_TextChanged);
            this.cmb_searchType.SelectedValueChanged += new System.EventHandler(this.cmb_searchType_SelectedValueChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_search.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ImageIndex = 0;
            this.lbl_search.ImageList = this.img_Label;
            this.lbl_search.Location = new System.Drawing.Point(662, 40);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(100, 21);
            this.lbl_search.TabIndex = 554;
            this.lbl_search.Text = "Search Type";
            this.lbl_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemCols = 0;
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style33;
            this.cmb_shipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipType.ColumnCaptionHeight = 18;
            this.cmb_shipType.ColumnFooterHeight = 18;
            this.cmb_shipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipType.ContentHeight = 16;
            this.cmb_shipType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipType.EditorHeight = 16;
            this.cmb_shipType.EvenRowStyle = style34;
            this.cmb_shipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style35;
            this.cmb_shipType.GapHeight = 2;
            this.cmb_shipType.HeadingStyle = style36;
            this.cmb_shipType.HighLightRowStyle = style37;
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(109, 62);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style38;
            this.cmb_shipType.PartialRightColumn = false;
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style39;
            this.cmb_shipType.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipType.Style = style40;
            this.cmb_shipType.TabIndex = 551;
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 1;
            this.lbl_shipType.ImageList = this.img_Label;
            this.lbl_shipType.Location = new System.Drawing.Point(8, 62);
            this.lbl_shipType.Name = "lbl_shipType";
            this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipType.TabIndex = 552;
            this.lbl_shipType.Text = "Ship Type";
            this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(109, 106);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 549;
            this.txt_vendorCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_vendorCode_KeyUp);
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemCols = 0;
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style41;
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
            this.cmb_vendor.EvenRowStyle = style42;
            this.cmb_vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style43;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style44;
            this.cmb_vendor.HighLightRowStyle = style45;
            this.cmb_vendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(189, 106);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style46;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style47;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style48;
            this.cmb_vendor.TabIndex = 550;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(561, 62);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(73, 21);
            this.txt_itemGroup.TabIndex = 548;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style49;
            this.cmb_itemGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_itemGroup.ColumnCaptionHeight = 18;
            this.cmb_itemGroup.ColumnFooterHeight = 18;
            this.cmb_itemGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_itemGroup.ContentHeight = 16;
            this.cmb_itemGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_itemGroup.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_itemGroup.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_itemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_itemGroup.EditorHeight = 16;
            this.cmb_itemGroup.EvenRowStyle = style50;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style51;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style52;
            this.cmb_itemGroup.HighLightRowStyle = style53;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(436, 62);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style54;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style55;
            this.cmb_itemGroup.Size = new System.Drawing.Size(124, 20);
            this.cmb_itemGroup.Style = style56;
            this.cmb_itemGroup.TabIndex = 547;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(634, 62);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 546;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // lbl_itemGroup
            // 
            this.lbl_itemGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemGroup.ImageIndex = 0;
            this.lbl_itemGroup.ImageList = this.img_Label;
            this.lbl_itemGroup.Location = new System.Drawing.Point(335, 62);
            this.lbl_itemGroup.Name = "lbl_itemGroup";
            this.lbl_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemGroup.TabIndex = 545;
            this.lbl_itemGroup.Text = "Item Group";
            this.lbl_itemGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 84);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 424;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(231, 84);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 425;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(212, 84);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 426;
            this.label5.Text = "~";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(8, 106);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 423;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_headInfo
            // 
            this.lbl_headInfo.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_headInfo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_headInfo.ForeColor = System.Drawing.Color.Navy;
            this.lbl_headInfo.Image = ((System.Drawing.Image)(resources.GetObject("lbl_headInfo.Image")));
            this.lbl_headInfo.Location = new System.Drawing.Point(0, 0);
            this.lbl_headInfo.Name = "lbl_headInfo";
            this.lbl_headInfo.Size = new System.Drawing.Size(231, 30);
            this.lbl_headInfo.TabIndex = 416;
            this.lbl_headInfo.Text = "       Outside Stock Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(496, 84);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(160, 21);
            this.txt_itemNm.TabIndex = 408;
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(436, 84);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(100, 21);
            this.txt_itemCd.TabIndex = 402;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(335, 84);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 401;
            this.lbl_item.Text = "Sum / Row No.";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 121);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_shipDate
            // 
            this.lbl_shipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipDate.ImageIndex = 1;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 84);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 50;
            this.lbl_shipDate.Text = "Ship Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style57;
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
            this.cmb_factory.EvenRowStyle = style58;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style59;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style60;
            this.cmb_factory.HighLightRowStyle = style61;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style62;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style63;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style64;
            this.cmb_factory.TabIndex = 1;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 40);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 50;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 96);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(976, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 121);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 16);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 110);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(112, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(960, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 18);
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Create.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Create.ImageIndex = 0;
            this.btn_Create.ImageList = this.img_Button;
            this.btn_Create.Location = new System.Drawing.Point(8, 608);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(80, 23);
            this.btn_Create.TabIndex = 559;
            this.btn_Create.Text = "Create";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Create_MouseDown);
            this.btn_Create.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Create_MouseUp);
            // 
            // btn_Outgoing
            // 
            this.btn_Outgoing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Outgoing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Outgoing.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Outgoing.ImageIndex = 0;
            this.btn_Outgoing.ImageList = this.img_Button;
            this.btn_Outgoing.Location = new System.Drawing.Point(847, 608);
            this.btn_Outgoing.Name = "btn_Outgoing";
            this.btn_Outgoing.Size = new System.Drawing.Size(80, 23);
            this.btn_Outgoing.TabIndex = 559;
            this.btn_Outgoing.Text = "All Outgoing";
            this.btn_Outgoing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Outgoing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Outgoing_MouseDown);
            this.btn_Outgoing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Outgoing_MouseUp);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(928, 608);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 23);
            this.btn_Cancel.TabIndex = 559;
            this.btn_Cancel.Text = "All Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseDown);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseUp);
            // 
            // dpick_Out
            // 
            this.dpick_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dpick_Out.CustomFormat = "";
            this.dpick_Out.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_Out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_Out.Location = new System.Drawing.Point(744, 609);
            this.dpick_Out.Name = "dpick_Out";
            this.dpick_Out.Size = new System.Drawing.Size(100, 21);
            this.dpick_Out.TabIndex = 561;
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ImageIndex = 1;
            this.lbl_date.ImageList = this.img_Label;
            this.lbl_date.Location = new System.Drawing.Point(640, 609);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_date.TabIndex = 560;
            this.lbl_date.Text = "Out Date";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_BK_Outside_Stock
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.dpick_Out);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.c1Sizer1);
            this.Controls.Add(this.btn_Outgoing);
            this.Controls.Add(this.btn_Cancel);
            this.Name = "Form_BK_Outside_Stock";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.btn_Outgoing, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.btn_Create, 0);
            this.Controls.SetChildIndex(this.lbl_date, 0);
            this.Controls.SetChildIndex(this.dpick_Out, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_dateType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_searchType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	
		#region 사용자 정의 변수

		private const int CON_RAW_MATRIAL = 0, CON_OUTSIDE_INCOMING = 1, CON_OUTSIDE_MATRIAL = 2, CON_OUTSIDE_STOCK = 3;
		private const string CON_RAW_NOT = "N", CON_RAW_SAVE = "S", CON_RAW_OUTGOING = "O", CON_RAW_INCOMING = "I", CON_RAW_FINISH = "F";
		private const string CON_OUTSIDE_NOT = "N", CON_OUTSIDE_SAVE = "S", CON_OUTSIDE_OUTGOING = "O";
		private Hashtable _cellCombo = null;
		private FlexPurchase.Purchase.Pop_BP_Purchase_Wait _waitPop = null;
		private const string _stockF = "S", _outgoingF = "O", _incomingF = "I", _finishF = "F";
		private const string _outgoingT = "Outgoing", _incomingT = "Incoming", _cancelT = "Cancel", _finishT = "Finish";

		private COM.OraDB MyOraDB	= new COM.OraDB();
		private string _itemGroupCode = " ";

		#endregion

		#region 그리드 이벤트

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void Grid_AfterEditProcess()
		{
			object vsCurData = fgrid_main[fgrid_main.Row, fgrid_main.Col];

			int[] viSels = fgrid_main.Selections;
			for (int idx = 0 ; idx < viSels.Length ; idx++)
			{
				fgrid_main[viSels[idx], fgrid_main.Col] = vsCurData;
				fgrid_main.Update_Row(viSels[idx]);
			}			
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		#endregion
		
		#region 툴바 메뉴 이벤트
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.clear();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "new", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				if (checkSearch())
				{
					this.Cursor = Cursors.WaitCursor;
					this.search();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "search", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				if (checkSave())
				{
					if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
					{
						this.Cursor = Cursors.WaitCursor;
						this.save();
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
	
		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;
				this.confirm();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				this.print();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion
	
		#region 컨트롤 이벤트

		private void Form_Load(object sender, System.EventArgs e)
		{
			try
			{
				init_form();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "init", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

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
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void txt_vendorCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.searchVendor();;
			}
		}

		private void cmb_vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				selectVendor();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "vendor search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			dpick_to.Value = dpick_from.Value;
		}

		private void cmb_searchType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				string pg_id = null;
				string com_cd = null;


                cmb_dateType.SelectedValue = "30";

				switch (cmb_searchType.SelectedIndex)
				{
					case CON_RAW_MATRIAL:
						tbtn_Save.Enabled = true;
						cmb_dateType.Enabled = false;
						com_cd = "SBK10";
						lbl_date.Text     = "Out Date";
						btn_Outgoing.Text = "Outgoing";
						btn_Cancel.Text = "Out Cancel";
						break;

					case CON_OUTSIDE_INCOMING: 
						tbtn_Save.Enabled = false;
						cmb_dateType.Enabled = false;
						lbl_date.Text     = "in Date";
						btn_Outgoing.Text = "Incoming";
						btn_Cancel.Text = "In Cancel";
						break;

					case CON_OUTSIDE_MATRIAL:
						tbtn_Save.Enabled = false;
						com_cd = "SBK11";
						btn_Outgoing.Text = "Outgoing";
						btn_Cancel.Text = "Out Cancel";
						break;
					
					case CON_OUTSIDE_STOCK:
						tbtn_Save.Enabled = true;
						cmb_dateType.Enabled = true;
						btn_Outgoing.Text = "";
						btn_Cancel.Text = "";
                        cmb_dateType.SelectedValue = "10";
						break;
				}

				// grid set
				pg_id = "SBK_OUTSIDE_STOCK_" + cmb_searchType.SelectedValue;

				fgrid_main.Set_Grid(pg_id, "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_main.Rows[0].AllowMerging = true;
				fgrid_main.Rows[1].AllowMerging = true;
				fgrid_main.Set_Action_Image(img_Action);

				if ( com_cd != null )
				{
					lbl_status.Visible = true;
					cmb_status.Visible = true;

					DataTable vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, com_cd);
					COM.ComCtl.Set_ComboList(vDt, cmb_status, 1, 2, true, 0, 220);
					cmb_status.SelectedIndex = 0;
					vDt.Dispose();
				}
				else
				{
					lbl_status.Visible = false;
					cmb_status.Visible = false;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search type changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmb_style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				txt_styleCode.Text = cmb_style.SelectedValue.ToString().Trim();
			}
			catch {}
		}

		private void txt_styleCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && txt_styleCode.Text.Length > 3)
			{
				Txt_StyleCdKeyUpProcess();
			}
		}

		#endregion

		#region 이벤트 처리 메서드

		/// <summary> 
		/// Init_Form : Form Initialize
		/// </summary>
		private void init_form()
		{						
			// Form init

            lbl_MainTitle.Text = "Outside Stock";
            this.Text = lbl_MainTitle.Text;
            ClassLib.ComFunction.SetLangDic(this);
			
			DataTable vDt = null;

			// Factory combobox add items
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose();

			// Item Group Combobox Setting
			vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
			vDt.Dispose();

			// Ship Type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM09");
			COM.ComCtl.Set_ComboList(vDt, cmb_shipType, 1, 2, true, 80, 140);
			cmb_shipType.SelectedIndex = 0;
			vDt.Dispose();

			// Search Type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBK09");
			COM.ComCtl.Set_ComboList(vDt, cmb_searchType, 1, 2, false, 80, 140);
            
            if (cmb_searchType.ListCount < 1)
            {
                cmb_searchType.SelectedIndex = -1;
            }
            else
            {
                cmb_searchType.SelectedIndex = 0;
            }
			
			vDt.Dispose();

			// Date Type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBK14");
			COM.ComCtl.Set_ComboList(vDt, cmb_dateType, 1, 2, false, 80, 140);

            if (cmb_searchType.ListCount < 3)
            {
                cmb_searchType.SelectedIndex = -1;
            }
            else
            {
                cmb_dateType.SelectedIndex = 2;
            }

			
			vDt.Dispose();


			// Disabled tbutton
			tbtn_Confirm.Enabled = false;
			tbtn_Create.Enabled  = false;
			tbtn_Delete.Enabled	 = false;

			// grid set
			_cellCombo = new Hashtable(fgrid_main.Cols.Count);

		}

		private void clear()
		{
			fgrid_main.ClearAll();
			this.cmb_itemGroup.SelectedIndex	= -1;
			this.txt_itemCd.Text				= "";
			this.txt_itemNm.Text				= "";
		}

		private void search()
		{
			DataTable vDt = this.SELECT_SBK_OUTSIDE_STOCK_LIST();

			if (vDt != null)
			{
				fgrid_main.ClearAll();

				if (vDt.Rows.Count > 0)
				{
					ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_main, vDt);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
				}				

				vDt.Dispose();

				switch (cmb_searchType.SelectedIndex)
				{
					case CON_RAW_MATRIAL:
						setGridColor_10();
						break;

					case CON_OUTSIDE_INCOMING:
						setGridColor_10();
						break;

					case CON_OUTSIDE_MATRIAL:
						setGridColor_20();
						break;
					
					case CON_OUTSIDE_STOCK:
						setGridColor_30();
						break;
				}
			}
		}

		private void setGridColor_10()
		{
			int statusCol = (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxSTATUS;

			for (int row = fgrid_main.Rows.Fixed ; row < fgrid_main.Rows.Count ; row++)
			{
				CellRange range = fgrid_main.GetCellRange(row, fgrid_main.Cols.Frozen, row, fgrid_main.Cols.Count - 1);
				range.StyleNew.ForeColor = Color.Black;

				switch (fgrid_main[row, statusCol].ToString())
				{
                    case CON_RAW_NOT:
						range.StyleNew.BackColor = ClassLib.ComVar.RightPink2;
						range.StyleNew.ForeColor = Color.Red;
						break;
					case CON_RAW_SAVE:
						range.StyleNew.BackColor = ClassLib.ComVar.RightPink2;
						break;
					case CON_RAW_OUTGOING:
						range.StyleNew.BackColor = ClassLib.ComVar.RightBlue;
						break;
					case CON_RAW_INCOMING:
						range.StyleNew.BackColor = ClassLib.ComVar.RightYellow;
						break;
					case CON_RAW_FINISH:
						range.StyleNew.BackColor = ClassLib.ComVar.RightYellow;
						range.StyleNew.ForeColor = Color.DarkGray;
						break;
				}
			}
		}
		
		private void setGridColor_20()
		{
			int statusCol = (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxSTATUS;
			
			for (int row = fgrid_main.Rows.Fixed ; row < fgrid_main.Rows.Count ; row++)
			{
				CellRange range = fgrid_main.GetCellRange(row, fgrid_main.Cols.Frozen, row, fgrid_main.Cols.Count - 1);
				range.StyleNew.ForeColor = Color.Black;

				switch (fgrid_main[row, statusCol].ToString())
				{
					case CON_OUTSIDE_NOT:
						range.StyleNew.BackColor = ClassLib.ComVar.RightPink2;
						range.StyleNew.ForeColor = Color.Red;
						break;
					case CON_OUTSIDE_SAVE:
						range.StyleNew.BackColor = ClassLib.ComVar.RightPink2;
						break;
					case CON_OUTSIDE_OUTGOING:
						range.StyleNew.BackColor = ClassLib.ComVar.RightBlue;
						break;
				}
			}
		}

		private void setGridColor_30()
		{
			for (int row = fgrid_main.Rows.Fixed ; row < fgrid_main.Rows.Count ; row++)
			{
				CellRange range = fgrid_main.GetCellRange(row, fgrid_main.Cols.Frozen, row, fgrid_main.Cols.Count - 1);
				range.StyleNew.BackColor = ClassLib.ComVar.RightBlue;
				//range.StyleNew.ForeColor = Color.Black;
			}
		}

		private void print()
		{
			string factory		= ClassLib.ComFunction.NullCheck(cmb_factory.SelectedValue, "");
			string ship_type	= "11";
			string cust_cd		= txt_vendorCode.Text;
			string stock_ymd_from = dpick_from.Text.ToString().Replace("-", "");
			string stock_ymd_to = dpick_to.Text.ToString().Replace("-", "");
			string group_cd		= _itemGroupCode;
			string item_cd		= txt_itemCd.Text;
			string item_name	= txt_itemNm.Text;

			ClassLib.ComVar.Parameter_PopUp = new string[]{factory, ship_type, cust_cd, stock_ymd_from, 
															  stock_ymd_to, group_cd, item_cd, item_name};

			new Pop_BK_Outside_Stock_Print().ShowDialog();
		}

		private void save()
		{
			switch (cmb_searchType.SelectedIndex)
			{
				case CON_RAW_MATRIAL:
					if (MyOraDB.Save_FlexGird("PKG_SBK_OUTSIDE_STOCK_TEMP.SAVE_SBK_OUTSIDE_STOCK_LIST_01", fgrid_main))
					{
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
						ClassLib.ComFunction.User_Message("Save Complete!!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
						fgrid_main.Refresh_Division();
					}
					break;
				case CON_OUTSIDE_INCOMING:
					break;
				case CON_OUTSIDE_MATRIAL:
					break;
					
				case CON_OUTSIDE_STOCK:
					if (MyOraDB.Save_FlexGird("PKG_SBK_OUTSIDE_STOCK_TEMP.SAVE_SBK_OUTSIDE_STOCK_LIST", fgrid_main))
					{
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
						ClassLib.ComFunction.User_Message("Save Complete!!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
						fgrid_main.Refresh_Division();
					}
					break;
			}
		}


		private void confirm()
		{
			// confirm
		}

		private void searchVendor()
		{
			DataTable vDt;
			vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_vendorCode.Text);
			COM.ComCtl.Set_ComboList(vDt, cmb_vendor, 0, 1, true, 79, 141);
			if (vDt.Rows.Count == 1)
			{	cmb_vendor.SelectedIndex = 1;
			}
			vDt.Dispose();

			cmb_vendor.SelectedValue = txt_vendorCode.Text;
		}

		private void selectVendor()
		{
			if (cmb_vendor.SelectedIndex != -1)
				txt_vendorCode.Text		 = cmb_vendor.SelectedValue.ToString();
		}

		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCode, " "));

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				COM.ComCtl.Set_ComboList(vDt, cmb_style, 0, 1, true, 80, 130); 
				string vStyle = txt_styleCode.Text.Replace("-", "");
				vStyle = vStyle.Substring(0, 6) + "-" + vStyle.Substring(6, 3);
				cmb_style.SelectedValue = vStyle.Trim();
			}
			catch {}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}

		#endregion

		#region 사전체크

		private bool checkSearch()
		{
			C1.Win.C1List.C1Combo[] combo = new C1.Win.C1List.C1Combo[] {cmb_factory};
			if (!ClassLib.ComFunction.Essentiality_check(combo, null, false))
				return false;

			return true;
		}

		private bool checkSave()
		{
			C1.Win.C1List.C1Combo[] combo = new C1.Win.C1List.C1Combo[] {cmb_factory};
			if (!ClassLib.ComFunction.Essentiality_check(combo, null, false))
				return false;

			if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
			{
				ClassLib.ComFunction.User_Message("Data not found!!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			return true;
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBK_OUTSIDE_STOCK : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBK_OUTSIDE_STOCK_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(13);

			// 이후 안정화 되면 PKG_SBK_OUTSIDE_STOCK_TEMP 를 PKG_SBK_OUTSIDE_STOCK 로 교체합니다.

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBK_OUTSIDE_STOCK_TEMP.SELECT_SBK_OUTSIDE_STOCK_" + cmb_searchType.SelectedValue;

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[4] = "ARG_FROM";
			MyOraDB.Parameter_Name[5] = "ARG_TO";
			MyOraDB.Parameter_Name[6] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[7] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[8] = "ARG_ITEM_NM";
			MyOraDB.Parameter_Name[9] = "ARG_STATUS";
			MyOraDB.Parameter_Name[10] = "ARG_DATE_TYPE";
			MyOraDB.Parameter_Name[11] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[12] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[12] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[3] = this.cmb_vendor.SelectedIndex > -1 ? this.cmb_vendor.SelectedValue.ToString() : "";
			MyOraDB.Parameter_Values[4] = this.dpick_from.Text.Replace("-","");
			MyOraDB.Parameter_Values[5] = this.dpick_to.Text.Replace("-","");
			MyOraDB.Parameter_Values[6] = _itemGroupCode;
			MyOraDB.Parameter_Values[7] = this.txt_itemCd.Text;
			MyOraDB.Parameter_Values[8] = this.txt_itemNm.Text;
			MyOraDB.Parameter_Values[9] = COM.ComFunction.Empty_Combo(cmb_status, "");
			MyOraDB.Parameter_Values[10] = COM.ComFunction.Empty_Combo(cmb_dateType, "");
			MyOraDB.Parameter_Values[11] = COM.ComFunction.Empty_TextBox(txt_styleCode, "").Replace("-", "");
			MyOraDB.Parameter_Values[12] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SVN_OUTSIDE_STOCK_EXTEND.CREATE_OUTSIDE_STOCK_RAW 
		/// </summary>
		public bool CREATE_OUTSIDE_STOCK_RAW()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVN_OUTSIDE_STOCK_EXTEND.CREATE_OUTSIDE_STOCK_RAW";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_CUST_CD"; 


			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = this.dpick_from.Text.Replace("-","");
			MyOraDB.Parameter_Values[3] = this.dpick_to.Text.Replace("-","");
			MyOraDB.Parameter_Values[4] = this.cmb_vendor.SelectedIndex > -1 ? this.cmb_vendor.SelectedValue.ToString() : "";

			MyOraDB.Add_Modify_Parameter(true);
			vds_ret = MyOraDB.Exe_Modify_Procedure();
			if(vds_ret == null) return false ;

			return true;
		}


		/// <summary>
		/// PKG_SVN_OUTSIDE_STOCK_EXTEND : SAVE_OUTSIDE_STOCK_CUST_ALL
		/// </summary>
		/// <returns>DataTable</returns>
		/// public bool SAVE_OUTSIDE_STOCK_CUST_STATUS()
		public bool SAVE_OUTSIDE_STOCK_CUST_STATUS(string arg_cur_status, string arg_status, string arg_date) 
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(17);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVN_OUTSIDE_STOCK_EXTEND.SAVE_OUTSIDE_STOCK_CUST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[4] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[5] = "ARG_BAR_CODE_REP";
			MyOraDB.Parameter_Name[6] = "ARG_STOCK_SEQ";
			MyOraDB.Parameter_Name[7] = "ARG_OUT_QTY";
			MyOraDB.Parameter_Name[8] = "ARG_TRANSFER_QTY";
			MyOraDB.Parameter_Name[9] = "ARG_IN_QTY";
			MyOraDB.Parameter_Name[10] = "ARG_OUT_YMD";
			MyOraDB.Parameter_Name[11] = "ARG_IN_YMD";
			MyOraDB.Parameter_Name[12] = "ARG_DEST_CUST_CD";
			MyOraDB.Parameter_Name[13] = "ARG_STATUS";
			MyOraDB.Parameter_Name[14] = "ARG_MAT_TYPE";
			MyOraDB.Parameter_Name[15] = "ARG_ACTION";
			MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;

			//04.DATA 정의
			ArrayList parameter_Values = new ArrayList();

			int[] vSelectionRange = fgrid_main.Selections;
			foreach (int i in vSelectionRange) 
			{
				parameter_Values.Add("U");
				parameter_Values.Add(COM.ComFunction.Empty_Combo(cmb_factory, "") );
				parameter_Values.Add(COM.ComFunction.Empty_Combo(cmb_shipType, "") );
				parameter_Values.Add(this.cmb_vendor.SelectedIndex > -1 ? this.cmb_vendor.SelectedValue.ToString() : ""); // session : cust_cd 
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxREMARKS].ToString().Substring(0,8));  //SHIP_YMD
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxBAR_CODE_REP].ToString());
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxREMARKS].ToString().Substring(9));  //stock_seq
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxOUT_QTY].ToString());  
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxOUT_QTY].ToString());  
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxIN_QTY].ToString());    
				parameter_Values.Add(arg_date == null ? fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxOUT_YMD].ToString().Replace("-", "") : arg_date );   
				parameter_Values.Add(arg_date == null ? fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxIN_YMD].ToString().Replace("-", "")  : arg_date );  
                parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxDEST_CUST_CD].ToString());  
				parameter_Values.Add(arg_status);
				parameter_Values.Add(arg_cur_status);
				parameter_Values.Add("STATUS");
				parameter_Values.Add(ClassLib.ComVar.This_User.ToString()); // session : web id

			}	


			MyOraDB.Parameter_Values  = (string[])parameter_Values.ToArray(Type.GetType("System.String"));

			MyOraDB.Add_Modify_Parameter(true);
			vds_ret = MyOraDB.Exe_Modify_Procedure();
			if(vds_ret == null) return false ;

			return true;

		}

		
		/// <summary>
		/// PKG_SVN_OUTSIDE_STOCK : CREATE_OUTSIDE_STOCK_CUST
		/// </summary>
		/// <returns>bool</returns>
		public bool CREATE_OUTSIDE_STOCK_OUTSIDE()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVN_OUTSIDE_STOCK_EXTEND.CREATE_OUTSIDE_STOCK_OUTSIDE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_CUST_CD";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = this.dpick_from.Text.Replace("-","");
			MyOraDB.Parameter_Values[3] = this.dpick_to.Text.Replace("-","");
			MyOraDB.Parameter_Values[4] = this.cmb_vendor.SelectedIndex > -1 ? this.cmb_vendor.SelectedValue.ToString() : "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return false ;

			return true;
		}

		
		/// <summary>
		/// PKG_SVN_OUTSIDE_STOCK : SAVE_OUTSIDE_STOCK_OUT_STATUS
		/// </summary>
		/// <returns>bool</returns>
		public bool SAVE_OUTSIDE_STOCK_OUT_STATUS(string arg_cur_status, string arg_next_status, string arg_date)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(17);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVN_OUTSIDE_STOCK_EXTEND.SAVE_OUTSIDE_STOCK_OUTSIDE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_NO";
			MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[6] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[7] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[8] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[9] = "ARG_BAR_CODE_REP";
			MyOraDB.Parameter_Name[10] = "ARG_STOCK_SEQ";
			MyOraDB.Parameter_Name[11] = "ARG_OUT_QTY";
			MyOraDB.Parameter_Name[12] = "ARG_OUT_YMD";
			MyOraDB.Parameter_Name[13] = "ARG_DEST_CUST_CD";
			MyOraDB.Parameter_Name[14] = "ARG_STATUS";
			MyOraDB.Parameter_Name[15] = "ARG_ACTION";
			MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;

			//04.DATA 정의
			ArrayList parameter_Values = new ArrayList();

			int[] vSelectionRange = fgrid_main.Selections;
			foreach (int i in vSelectionRange) 
			{
				int v_pos = fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxREMARKS].ToString().IndexOf("-");
 
				parameter_Values.Add("U");
				parameter_Values.Add(COM.ComFunction.Empty_Combo(cmb_factory, "") );
				parameter_Values.Add(COM.ComFunction.Empty_Combo(cmb_shipType, "") );
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxREMARKS].ToString().Substring(0,v_pos));  // 수정필요 SHIP_NO
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxSTYLE_CD ].ToString().Replace("-", ""));
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxITEM_CD  ].ToString());
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxSPEC_CD  ].ToString());
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxCOLOR_CD ].ToString());
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxCUST_CD  ].ToString());
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxBAR_CODE_REP ].ToString());
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxREMARKS].ToString().Substring(v_pos+1));   // 수정필요 STOCK_SEQ
				parameter_Values.Add(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxOUT_QTY  ].ToString());
				parameter_Values.Add(arg_date == null ? fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxOUT_YMD ].ToString().Replace("-", "") : arg_date );   
				parameter_Values.Add("");  // 수정필요 dest_cust_cd
				parameter_Values.Add(arg_next_status);
				parameter_Values.Add("STATUS");
				parameter_Values.Add(ClassLib.ComVar.This_User.ToString()); // session : web id
			}


			MyOraDB.Parameter_Values  = (string[])parameter_Values.ToArray(Type.GetType("System.String"));

			MyOraDB.Add_Modify_Parameter(true);
			vds_ret = MyOraDB.Exe_Modify_Procedure();
			if(vds_ret == null) return false ;

			return true;

		}

		#endregion

		private void menuItem_ValueChange_Click(object sender, System.EventArgs e)
		{
			ValueExchangeProcessing();
		}


		private void ValueExchangeProcessing()
		{
			int[] vSelectionRange = fgrid_main.Selections;
			int vCol = fgrid_main.Selection.c1;			

			if (vSelectionRange.Length == 0)	return;
			

			COM.ComVar.Parameter_PopUp		= new string[2];
			COM.ComVar.Parameter_PopUp[0]	= fgrid_main[2, vCol].ToString();
			COM.ComVar.Parameter_PopUp[1]	= "Date";

			if (_cellCombo.ContainsKey(vCol))
				ClassLib.ComVar.Parameter_PopUp_Object = new object[]{_cellCombo[vCol]};

		
			Shipping.Pop_BS_Shipping_List_Changer pop_changer = new Shipping.Pop_BS_Shipping_List_Changer();
			pop_changer.ShowDialog();			

			if (COM.ComVar.Parameter_PopUp != null)
			{
				//if(_level1.Contains(vCol))
				SetData(1, vSelectionRange);
				//else
				//	SetData(2, vSelectionRange);
			}

			pop_changer.Dispose();

		
		}

		// 우선순위 : 헤더, 테일
		private void SetData(int arg_level, int[] arg_sel)
		{
			// Vendor를 위한
			//if (COM.ComVar.Parameter_PopUp.Length > 1)
			//{
			//	arg_level = 1;
			//}		

			foreach (int i in arg_sel) 
			{
				//if (fgrid_main.Rows[i].Node.Level == arg_level)
				//{
				if (COM.ComVar.Parameter_PopUp.Length > 1)
				{
					fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxDEST_CUST_NAME ] = COM.ComVar.Parameter_PopUp[0];
					fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxDEST_CUST_CD   ] = COM.ComVar.Parameter_PopUp[1];	          
				}
					
				else
				{
					fgrid_main[i, fgrid_main.Col] = COM.ComVar.Parameter_PopUp[0];
				}

				fgrid_main.Update_Row(i);
				//}
			}	

		}

		private void menuItem_Qty_Click(object sender, System.EventArgs e)
		{
			int[] vSelectionRange = fgrid_main.Selections;
			int vCol = fgrid_main.Selection.c1;			

			if (vSelectionRange.Length == 0)	return;

			foreach (int i in vSelectionRange) 
			{
				
				fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_30.IxOUT_QTY] = fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_30.IxIN_QTY].ToString();

				fgrid_main.Update_Row(i);
			}	
		
		}



		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int[] vSelectionRange = fgrid_main.Selections;
			int vCol = fgrid_main.Selection.c1;		
			int vRow = fgrid_main.Selection.r1 - 2;
			int vCount = 0;
			decimal vInSum = 0, vOutSum = 0;

			if (vSelectionRange.Length == 0)	return;

			foreach (int i in vSelectionRange) 
			{
				try 
				{
					
					switch (cmb_searchType.SelectedIndex)
					{
						case CON_RAW_MATRIAL:
							vInSum  += decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxIN_QTY ].ToString());
							vOutSum += decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxOUT_QTY].ToString());
							break;
						case CON_OUTSIDE_INCOMING:
							vInSum  += decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxIN_QTY ].ToString());
							vOutSum += decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_10.IxOUT_QTY].ToString());
							break;
						case CON_OUTSIDE_MATRIAL:
							vInSum  += 0;
							vOutSum += decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_20.IxOUT_QTY].ToString());
							break;
					
						case CON_OUTSIDE_STOCK:
							vInSum  += decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_30.IxIN_QTY ].ToString());
							vOutSum += decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBK_OUTSIDE_STOCK_30.IxOUT_QTY].ToString());
							break;
					}
					
				}
				catch (Exception ex)
				{
					vInSum  += 0;
					vOutSum += 0;
				}
				vCount +=1 ;
				

			}	

			txt_Count.Text      = vCount.ToString();
			txt_InSum.Text      = vInSum.ToString();
			txt_OutSum.Text     = vOutSum.ToString(); 
			
		}

		private void btn_Create_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Create.ImageIndex = 1;	
		}

		private void btn_Create_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{

			try
			{
				switch (cmb_searchType.SelectedIndex)
				{
					case CON_RAW_MATRIAL: 
						if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Create?", "Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
						{
							_waitPop = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
							Thread temp_thread = new Thread(new ThreadStart(_waitPop.Start));

							if (temp_thread != null)
							{
								temp_thread.Start(); 
								this.Create(); 
							} 
						}
						break;

					case CON_OUTSIDE_INCOMING:
						break;

					case CON_OUTSIDE_MATRIAL:
						if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Create?", "Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
						{
							_waitPop = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
							Thread temp_thread = new Thread(new ThreadStart(_waitPop.Start));

							if (temp_thread != null)
							{
								temp_thread.Start(); 
								this.Outside_Create(); 
							} 
						}
						break;
			
					case CON_OUTSIDE_STOCK:
						break;
				} 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Create", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				btn_Create.ImageIndex = 0;
			}
		}

		private void Create()
		{
			try
			{
				if (this.CREATE_OUTSIDE_STOCK_RAW())
				{
					this.search();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.User_Message("Create Fail!!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (_waitPop != null) _waitPop.Close();
			}
		}

		
		private void Outside_Create()
		{
			try
			{
				if (this.CREATE_OUTSIDE_STOCK_OUTSIDE())
				{
					this.search();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.User_Message("Create Fail!!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (_waitPop != null) _waitPop.Close();
			}
		}


		private void btn_Outgoing_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Outgoing.ImageIndex = 1;	
		}

		private void btn_Outgoing_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				switch (cmb_searchType.SelectedIndex)
				{
					case CON_RAW_MATRIAL: 
						if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to All Outgoing?", "Outgoing", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
						{
							_waitPop = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
							Thread temp_thread = new Thread(new ThreadStart(_waitPop.Start));
							if (temp_thread != null)
							{
								temp_thread.Start(); 
								this.Outgoing();
							}
						}
						break;
					case CON_OUTSIDE_INCOMING:
						if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to All Incoming?", "Incoming", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
						{
							_waitPop = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
							Thread temp_thread = new Thread(new ThreadStart(_waitPop.Start));
							if (temp_thread != null)
							{
								temp_thread.Start(); 
								this.Incoming();
							}
						}
						break;

					case CON_OUTSIDE_MATRIAL:
						if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to All Outgoing?", "Outgoing", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
						{
							_waitPop = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
							Thread temp_thread = new Thread(new ThreadStart(_waitPop.Start));
							if (temp_thread != null)
							{
								temp_thread.Start(); 
								this.Outside_Outgoing();
							}
						}
						break;
			
					case CON_OUTSIDE_STOCK:
						break;
				} 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Outgoing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				btn_Outgoing.ImageIndex = 0; 
			}
		}

		
		private void Outgoing()
		{
			string arg_date = this.dpick_Out.Text.Replace("-","");

			try
			{
				if (this.SAVE_OUTSIDE_STOCK_CUST_STATUS("Raw", _outgoingF, arg_date))
				{
					this.search();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.User_Message("Create Fail!!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (_waitPop != null) _waitPop.Close();
			}

		}


		private void Outside_Outgoing()
		{
			string arg_date = this.dpick_Out.Text.Replace("-","");

			try
			{
				if (this.SAVE_OUTSIDE_STOCK_OUT_STATUS("Outside", _outgoingF, arg_date))
				{
					this.search();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.User_Message("Create Fail!!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (_waitPop != null) _waitPop.Close();
			}

		}

		
		private void Incoming()
		{
			string arg_date = this.dpick_Out.Text.Replace("-","");

			try
			{
				if (this.SAVE_OUTSIDE_STOCK_CUST_STATUS("Outside", _finishF, arg_date))
				{
					this.search();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.User_Message("Create Fail!!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (_waitPop != null) _waitPop.Close();
			}

		}

		private void btn_Cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Cancel.ImageIndex = 1;	
		}

		private void btn_Cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				switch (cmb_searchType.SelectedIndex)
				{
					case CON_RAW_MATRIAL: 
						if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to All Outgoing Cancel?", "Outgoing", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
						{
							_waitPop = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
							Thread temp_thread = new Thread(new ThreadStart(_waitPop.Start));

							if (temp_thread != null)
							{
								temp_thread.Start(); 
								this.Outgoing_Cancel();
							}
						}
						break;
					case CON_OUTSIDE_INCOMING:
						if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to All Incoming Cancel?", "Incoming", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
						{
							_waitPop = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
							Thread temp_thread = new Thread(new ThreadStart(_waitPop.Start));

							if (temp_thread != null)
							{
								temp_thread.Start(); 
								this.Incoming_Cancel();
							}
						}
						break;

					case CON_OUTSIDE_MATRIAL:
						if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to All Outgoing Cancel?", "Outgoing", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
						{
							_waitPop = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
							Thread temp_thread = new Thread(new ThreadStart(_waitPop.Start));

							if (temp_thread != null)
							{
								temp_thread.Start(); 
								this.Outside_Outgoing_Cancel();
							}
						}
						break;
			
					case CON_OUTSIDE_STOCK:
						break;
				} 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Outgoing Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				btn_Cancel.ImageIndex = 0;
			}
		
		}


		private void Outgoing_Cancel()
		{
			string arg_date = this.dpick_Out.Text.Replace("-","");

			try
			{
				if (this.SAVE_OUTSIDE_STOCK_CUST_STATUS("Raw", _stockF, null))
				{
					this.search();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.User_Message("Outgoing Cancel Fail!!", "Outgoing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (_waitPop != null) _waitPop.Close();
			}
		}


		private void Incoming_Cancel()
		{
			string arg_date = this.dpick_Out.Text.Replace("-","");

			try
			{
				if (this.SAVE_OUTSIDE_STOCK_CUST_STATUS("Outside", _outgoingF, null))
				{
					this.search();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.User_Message("Incoming Cancel Fail!!", "Incoming", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (_waitPop != null) _waitPop.Close();
			}
		}

		
		private void Outside_Outgoing_Cancel()
		{
			string arg_date = this.dpick_Out.Text.Replace("-","");

			try
			{
				if (this.SAVE_OUTSIDE_STOCK_OUT_STATUS("Outside", _stockF, null))
				{
					this.search();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.User_Message("Outgoing Cancel Fail!!", "Outgoing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (_waitPop != null) _waitPop.Close();
			}
		}

		private void cmb_searchType_TextChanged(object sender, System.EventArgs e)
		{
		
		}


	}
}

