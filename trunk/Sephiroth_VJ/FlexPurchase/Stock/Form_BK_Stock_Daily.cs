using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient; 
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;
using System.Threading; 

namespace FlexPurchase.Stock
{
	public class Form_BK_Stock_Daily : COM.PCHWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_wareHouse;
		private System.Windows.Forms.Label lbl_wareHouse;
		private System.Windows.Forms.Label lbl_StockYm;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_item;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
        private System.Windows.Forms.ContextMenu cmenu_grid;
		private System.Windows.Forms.MenuItem menuItem_In;
		private System.Windows.Forms.MenuItem menuItem_Out;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem_ItemRelation;
		private System.Windows.Forms.MenuItem menuItem_SpecRelation;
		private System.Windows.Forms.MenuItem menuItem_ColorRelation;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem_ItemChange;
		private System.Windows.Forms.MenuItem menuItem_SpecChange;
		private System.Windows.Forms.MenuItem menuItem_ColorChange;
		private System.Windows.Forms.Label btn_Research;
		private System.Windows.Forms.Label lbl_headInfo;

		 
  
		public Form_BK_Stock_Daily()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BK_Stock_Daily));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_Research = new System.Windows.Forms.Label();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_wareHouse = new C1.Win.C1List.C1Combo();
            this.lbl_wareHouse = new System.Windows.Forms.Label();
            this.lbl_StockYm = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spd_main = new COM.SSP();
            this.cmenu_grid = new System.Windows.Forms.ContextMenu();
            this.menuItem_In = new System.Windows.Forms.MenuItem();
            this.menuItem_Out = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem_ItemRelation = new System.Windows.Forms.MenuItem();
            this.menuItem_SpecRelation = new System.Windows.Forms.MenuItem();
            this.menuItem_ColorRelation = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem_ItemChange = new System.Windows.Forms.MenuItem();
            this.menuItem_SpecChange = new System.Windows.Forms.MenuItem();
            this.menuItem_ColorChange = new System.Windows.Forms.MenuItem();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_wareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "18.1034482758621:False:True;79.8275862068966:False:False;\t0.393700787401575:False" +
                ":True;97.6377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.btn_Research);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.txt_itemName);
            this.pnl_head.Controls.Add(this.txt_itemCode);
            this.pnl_head.Controls.Add(this.lbl_itemgroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.cmb_wareHouse);
            this.pnl_head.Controls.Add(this.lbl_wareHouse);
            this.pnl_head.Controls.Add(this.lbl_StockYm);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pictureBox1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 105);
            this.pnl_head.TabIndex = 33;
            // 
            // btn_Research
            // 
            this.btn_Research.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Research.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Research.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Research.ImageIndex = 1;
            this.btn_Research.ImageList = this.img_Button;
            this.btn_Research.Location = new System.Drawing.Point(912, 72);
            this.btn_Research.Name = "btn_Research";
            this.btn_Research.Size = new System.Drawing.Size(80, 23);
            this.btn_Research.TabIndex = 444;
            this.btn_Research.Text = "ReSearch";
            this.btn_Research.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Research.Click += new System.EventHandler(this.btn_Research_Click);
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(546, 33);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.txt_itemGroup.TabIndex = 442;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style1;
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
            this.cmb_itemGroup.EvenRowStyle = style2;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style3;
            this.cmb_itemGroup.HeadingStyle = style4;
            this.cmb_itemGroup.HighLightRowStyle = style5;
            this.cmb_itemGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_itemGroup.Images"))));
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(445, 33);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style6;
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style7;
            this.cmb_itemGroup.Size = new System.Drawing.Size(100, 20);
            this.cmb_itemGroup.Style = style8;
            this.cmb_itemGroup.TabIndex = 441;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(505, 55);
            this.txt_itemName.MaxLength = 500;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(163, 21);
            this.txt_itemName.TabIndex = 443;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(445, 55);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 439;
            // 
            // lbl_itemgroup
            // 
            this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemgroup.ImageIndex = 0;
            this.lbl_itemgroup.ImageList = this.img_Label;
            this.lbl_itemgroup.Location = new System.Drawing.Point(344, 33);
            this.lbl_itemgroup.Name = "lbl_itemgroup";
            this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemgroup.TabIndex = 437;
            this.lbl_itemgroup.Text = "Item Group";
            this.lbl_itemgroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(646, 33);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 440;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            this.btn_groupSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_groupSearch.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_groupSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(344, 55);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 438;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_wareHouse
            // 
            this.cmb_wareHouse.AddItemSeparator = ';';
            this.cmb_wareHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_wareHouse.Caption = "";
            this.cmb_wareHouse.CaptionHeight = 17;
            this.cmb_wareHouse.CaptionStyle = style9;
            this.cmb_wareHouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_wareHouse.ColumnCaptionHeight = 18;
            this.cmb_wareHouse.ColumnFooterHeight = 18;
            this.cmb_wareHouse.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_wareHouse.ContentHeight = 16;
            this.cmb_wareHouse.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_wareHouse.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_wareHouse.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_wareHouse.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_wareHouse.EditorHeight = 16;
            this.cmb_wareHouse.EvenRowStyle = style10;
            this.cmb_wareHouse.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_wareHouse.FooterStyle = style11;
            this.cmb_wareHouse.HeadingStyle = style12;
            this.cmb_wareHouse.HighLightRowStyle = style13;
            this.cmb_wareHouse.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_wareHouse.Images"))));
            this.cmb_wareHouse.ItemHeight = 15;
            this.cmb_wareHouse.Location = new System.Drawing.Point(109, 77);
            this.cmb_wareHouse.MatchEntryTimeout = ((long)(2000));
            this.cmb_wareHouse.MaxDropDownItems = ((short)(5));
            this.cmb_wareHouse.MaxLength = 32767;
            this.cmb_wareHouse.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_wareHouse.Name = "cmb_wareHouse";
            this.cmb_wareHouse.OddRowStyle = style14;
            this.cmb_wareHouse.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_wareHouse.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_wareHouse.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_wareHouse.SelectedStyle = style15;
            this.cmb_wareHouse.Size = new System.Drawing.Size(210, 20);
            this.cmb_wareHouse.Style = style16;
            this.cmb_wareHouse.TabIndex = 425;
            this.cmb_wareHouse.SelectedValueChanged += new System.EventHandler(this.cmb_wareHouse_SelectedValueChanged);
            this.cmb_wareHouse.PropBag = resources.GetString("cmb_wareHouse.PropBag");
            // 
            // lbl_wareHouse
            // 
            this.lbl_wareHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_wareHouse.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wareHouse.ImageIndex = 1;
            this.lbl_wareHouse.ImageList = this.img_Label;
            this.lbl_wareHouse.Location = new System.Drawing.Point(8, 77);
            this.lbl_wareHouse.Name = "lbl_wareHouse";
            this.lbl_wareHouse.Size = new System.Drawing.Size(100, 21);
            this.lbl_wareHouse.TabIndex = 426;
            this.lbl_wareHouse.Text = "WareHouse";
            this.lbl_wareHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_StockYm
            // 
            this.lbl_StockYm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_StockYm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockYm.ImageIndex = 1;
            this.lbl_StockYm.ImageList = this.img_Label;
            this.lbl_StockYm.Location = new System.Drawing.Point(8, 55);
            this.lbl_StockYm.Name = "lbl_StockYm";
            this.lbl_StockYm.Size = new System.Drawing.Size(100, 21);
            this.lbl_StockYm.TabIndex = 424;
            this.lbl_StockYm.Text = "Stock Date";
            this.lbl_StockYm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style17;
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
            this.cmb_factory.EvenRowStyle = style18;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style19;
            this.cmb_factory.HeadingStyle = style20;
            this.cmb_factory.HighLightRowStyle = style21;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 33);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style22;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style23;
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 422;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 33);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 423;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbl_headInfo.Text = "       Stock Daily  Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(208, 56);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(12, 16);
            this.lblexcep_mark.TabIndex = 386;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(221, 56);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(99, 21);
            this.dpick_to.TabIndex = 385;
            this.dpick_to.ValueChanged += new System.EventHandler(this.dpick_to_ValueChanged);
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 56);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(99, 21);
            this.dpick_from.TabIndex = 381;
            this.dpick_from.ValueChanged += new System.EventHandler(this.dpick_from_ValueChanged);
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 89);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 64);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(984, 0);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 89);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 78);
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
            this.pic_head1.Size = new System.Drawing.Size(968, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 18);
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.ContextMenu = this.cmenu_grid;
            this.spd_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spd_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.spd_main.Location = new System.Drawing.Point(12, 113);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(992, 463);
            this.spd_main.TabIndex = 173;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // cmenu_grid
            // 
            this.cmenu_grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_In,
            this.menuItem_Out,
            this.menuItem2,
            this.menuItem_ItemRelation,
            this.menuItem_SpecRelation,
            this.menuItem_ColorRelation,
            this.menuItem3,
            this.menuItem_ItemChange,
            this.menuItem_SpecChange,
            this.menuItem_ColorChange});
            // 
            // menuItem_In
            // 
            this.menuItem_In.Index = 0;
            this.menuItem_In.Text = "Incoming Infomation";
            this.menuItem_In.Click += new System.EventHandler(this.menuItem_In_Click);
            // 
            // menuItem_Out
            // 
            this.menuItem_Out.Index = 1;
            this.menuItem_Out.Text = "Outgoing Infomation";
            this.menuItem_Out.Click += new System.EventHandler(this.menuItem_Out_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "-";
            this.menuItem2.Visible = false;
            // 
            // menuItem_ItemRelation
            // 
            this.menuItem_ItemRelation.Index = 3;
            this.menuItem_ItemRelation.Text = "Make Item Relation";
            this.menuItem_ItemRelation.Visible = false;
            this.menuItem_ItemRelation.Click += new System.EventHandler(this.menuItem_MakeRelation_Click);
            // 
            // menuItem_SpecRelation
            // 
            this.menuItem_SpecRelation.Index = 4;
            this.menuItem_SpecRelation.Text = "Make Specification Relation";
            this.menuItem_SpecRelation.Visible = false;
            this.menuItem_SpecRelation.Click += new System.EventHandler(this.menuItem_MakeRelation_Click);
            // 
            // menuItem_ColorRelation
            // 
            this.menuItem_ColorRelation.Index = 5;
            this.menuItem_ColorRelation.Text = "Make Color Relation";
            this.menuItem_ColorRelation.Visible = false;
            this.menuItem_ColorRelation.Click += new System.EventHandler(this.menuItem_MakeRelation_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 6;
            this.menuItem3.Text = "-";
            // 
            // menuItem_ItemChange
            // 
            this.menuItem_ItemChange.Index = 7;
            this.menuItem_ItemChange.Text = "incoming Item Code Changes";
            this.menuItem_ItemChange.Click += new System.EventHandler(this.menuItem_ItemChange_Click);
            // 
            // menuItem_SpecChange
            // 
            this.menuItem_SpecChange.Index = 8;
            this.menuItem_SpecChange.Text = "incoming Spec Code Changes";
            this.menuItem_SpecChange.Click += new System.EventHandler(this.menuItem_ItemChange_Click);
            // 
            // menuItem_ColorChange
            // 
            this.menuItem_ColorChange.Index = 9;
            this.menuItem_ColorChange.Text = "incoming Color Code Changes";
            this.menuItem_ColorChange.Click += new System.EventHandler(this.menuItem_ItemChange_Click);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // Form_BK_Stock_Daily
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BK_Stock_Daily";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_wareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	
		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction();
 

		private Hashtable _cellTypes = null;
		private Hashtable _cellData  = null;


        private Thread tRun = null;
        delegate void DelegateSetn(); // 대리자 선언    



		#endregion 

		#region 멤버 메소드
 

		/// <summary>
		/// Init_Form : 
		/// </summary>
		private void Init_Form()
		{
			try
			{

                //Title
                this.Text = "Daily Stock";
                lbl_MainTitle.Text = "Daily Stock";
                ClassLib.ComFunction.SetLangDic(this); 

 
 
				// Grid Setting
				spd_main.Set_Spread_Comm("SBK_STOCK_DAILY", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
				// Farpoint Spread Header Merge
				Mearge_GridHead();


				//combobox setting
				Init_Control(); 
                

                //not used menu 
                menuItem2.Visible = false;
                menuItem_SpecRelation.Visible = false;
                menuItem_ItemRelation.Visible = false;
                menuItem_ColorRelation.Visible = false;
                tbtn_Create.Enabled = false;


 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		/// <summary>
		/// Mearge_GridHead : Farpoint Spread Header Merge
		/// </summary>
		private void Mearge_GridHead()
		{
			
			try
			{

				for (int vCol = 0 ; vCol < spd_main.ActiveSheet.ColumnCount ; vCol++)
				{
					
					if (spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim().Equals(spd_main.ActiveSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()))
					{
						spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
					}
					else
					{
						int vCnt  = 0;
						
						for ( int j = vCol ; j < spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if( vCnt > 0 &&  spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								break;
							}
							else if ( spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							{
								vCnt++;
							}
						}

						vCol = vCol + vCnt-1;
					}
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mearge_GridHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

 

		/// <summary>
		/// Init_Control : combobox setting
		/// </summary>
		private void Init_Control()
		{
			DataTable dt_ret;


			// toolbar button disable setting
			tbtn_Delete.Enabled = false;
			tbtn_Confirm.Enabled = false;
 

			// factory set
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
 

			//그룹타입 콤보쿼리 
			dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_itemGroup, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);   

			dt_ret.Dispose(); 


			//date 초기화  
			string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

			dpick_from.Text = MyComFunction.ConvertDate2Type(nowymd);
			dpick_to.Text = MyComFunction.ConvertDate2Type(nowymd); 



			// grid set
			_cellTypes = new Hashtable();
			_cellData  = new Hashtable();

			for (int vCount = 1 ; vCount < spd_main.ActiveSheet.Columns.Count ; vCount++)
			{
				if (spd_main.ActiveSheet.Columns[vCount].CellType.ToString().Equals(ClassLib.ComVar.SSPComboBoxCell))
				{
					COM.SSPComboBoxCellType sspBox = (COM.SSPComboBoxCellType)spd_main.ActiveSheet.Columns[vCount].CellType; 
					_cellTypes.Add(vCount, sspBox.DataDisplay);
					_cellData.Add( vCount, sspBox.DataValue);
				}

			} // end for




		}


		#endregion

		#region 이벤트 관련


		#region 툴바 관련

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_NewProcess();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_SaveProcess();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_wareHouse};   
			bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

			if(! essential_check) return;

			string factory = cmb_factory.SelectedValue.ToString();
			string stock_ymd_from = MyComFunction.ConvertDate2DbType(dpick_from.Text);
			string stock_ymd_to = MyComFunction.ConvertDate2DbType(dpick_to.Text);
			string warehouse = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " ");  
			string item_group = _itemGroupCode;
			string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
			string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");
			string warehouse_name = cmb_wareHouse.Columns[1].Text;

			string item_group_name = "";
				
			if(cmb_itemGroup.SelectedIndex != -1) 
			{
				item_group_name = cmb_itemGroup.Columns[1].Text + ", " + txt_itemGroup.Text;
			} 

			COM.ComVar.Parameter_PopUp = new string[] {factory, stock_ymd_from, stock_ymd_to, warehouse, item_group, item_cd, item_name, warehouse_name, item_group_name};

			Pop_BK_Stock_Daily_Print printPop = new Pop_BK_Stock_Daily_Print();
			printPop.ShowDialog();



 

			//			string mrd_Filename = @"Report/Material/Form_BK_Stock_Daily.mrd";
			//			string Para         = " ";
			//
			//			#region 출력조건
			//
			//			int  iCnt  = 9;
			//			string [] aHead =  new string[iCnt];	
			//
			//			string factory = cmb_factory.SelectedValue.ToString();
			//			string stock_ymd_from = MyComFunction.ConvertDate2DbType(dpick_from.Text);
			//			string stock_ymd_to = MyComFunction.ConvertDate2DbType(dpick_to.Text);
			//			string warehouse = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " ");  
			//			string item_group = _itemGroupCode;
			//			string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
			//			string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");
			//			string warehouse_name = cmb_wareHouse.Columns[1].Text;
			//			 
			//
			//			string item_group_name = "";
			//				
			//			if(cmb_itemGroup.SelectedIndex != -1) 
			//			{
			//				item_group_name = cmb_itemGroup.Columns[1].Text + ", " + txt_itemGroup.Text;
			//			} 
			//
			//
			//			aHead[0]    = factory;
			//			aHead[1]    = stock_ymd_from;
			//			aHead[2]    = stock_ymd_to;
			//			aHead[3]    = warehouse;
			//			aHead[4]    = item_group;
			//			aHead[5]    = item_cd;
			//			aHead[6]    = item_name;
			//			aHead[7]    = warehouse_name;
			//			aHead[8]    = item_group_name;
			//			 
			//			
			//			#endregion
			//			
			//			Para = 	" /rp ";
			//			for (int i  = 1 ; i<= iCnt ; i++)
			//			{				
			//				Para = Para + "[" + aHead[i-1] + "] ";
			//			}
			//			
			//			FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			//			report.Show();


		}




		private void Tbtn_NewProcess()
		{
			try
			{
				spd_main.ClearAll();

				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd");
				dpick_from.Text = MyComFunction.ConvertDate2Type(nowymd);
				dpick_to.Text = MyComFunction.ConvertDate2Type(nowymd); 
				
				cmb_wareHouse.SelectedIndex = -1;

				cmb_itemGroup.SelectedIndex = -1;
				txt_itemGroup.Text = "";
				txt_itemCode.Text = "";
				txt_itemName.Text = "";


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{		
		
				this.Cursor = Cursors.WaitCursor;


				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) return;
 
				string factory = cmb_factory.SelectedValue.ToString();
				string warehouse = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " "); 
				string stock_ymd_from = MyComFunction.ConvertDate2DbType(dpick_from.Text);
				string stock_ymd_to = MyComFunction.ConvertDate2DbType(dpick_to.Text);
				string item_group = _itemGroupCode;
				string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
				string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");
				 

				DataTable dt_ret = Select_SBK_STOCK(factory, warehouse, stock_ymd_from, stock_ymd_to, item_group, item_cd, item_name);

				if(dt_ret.Rows.Count == 0) 
				{
					spd_main.ClearAll();  
					return;
				}


				spd_main.Display_Grid(dt_ret);

				ClassLib.ComFunction.MergeCell(spd_main, 
					new int[]{ (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_NAME, 
								 (int)ClassLib.TBSBK_STOCK_DAILY.IxSPEC_NAME, 
								 (int)ClassLib.TBSBK_STOCK_DAILY.IxCOLOR_NAME } );



				//-----------------------------------------------------------
				// relation 관계 적용된 행 표시
				for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
				{
					if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBK_STOCK_DAILY.IxRELATION_EXIST_YN].Value.ToString().Equals("Y") )
					{

						for(int j = 0; j < spd_main.ActiveSheet.ColumnCount; j++)
						{
							if(spd_main.ActiveSheet.Columns[j].Locked)
							{ 
								spd_main.ActiveSheet.Cells[i, j].ForeColor = ClassLib.ComVar.Clr_Text_Red;
							}
						} // end for j
						
					}
					else
					{

						for(int j = 0; j < spd_main.ActiveSheet.ColumnCount; j++)
						{
							if(spd_main.ActiveSheet.Columns[j].Locked)
							{ 
								spd_main.ActiveSheet.Cells[i, j].ForeColor = Color.Black;
							}
						} // end for j


					}

				}
				//-----------------------------------------------------------



 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SearchProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) return;


				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					if(MyOraDB.Save_Spread("PKG_SBK_STOCK_DAILY.SAVE_SBK_STOCK", spd_main))
					{ 
						spd_main.Refresh_Division();

						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					}
				}


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SaveProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		#endregion

		#region 조회부 관련

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
 
			if(cmb_factory.SelectedIndex == -1) return;

			// WareHouse Combobox Setting
			DataTable dt_ret = FlexPurchase.ClassLib.ComFunction.SELECT_WAREHOUSE_LIST_USING(cmb_factory.SelectedValue.ToString());
			COM.ComCtl.Set_ComboList(dt_ret, cmb_wareHouse, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Name);   
			dt_ret.Dispose();




			//date 초기화  
			string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

			//			dpick_from.Text = MyComFunction.ConvertDate2Type(nowymd);
			//			dpick_to.Text = MyComFunction.ConvertDate2Type(nowymd); 
			// 
			//			cmb_wareHouse.SelectedIndex = -1;
			//	
			//			cmb_itemGroup.SelectedIndex = -1;
			//			txt_itemGroup.Text = "";
			//			txt_itemCode.Text = "";
			//			txt_itemName.Text = "";


			spd_main.ClearAll();

		}

		private void dpick_from_ValueChanged(object sender, System.EventArgs e)
		{
		
			//date 초기화  
			string nowymd = System.DateTime.Now.ToString("yyyyMMdd");
 
			//			dpick_to.Text = MyComFunction.ConvertDate2Type(nowymd); 
			// 
			//			cmb_wareHouse.SelectedIndex = -1;
			//				
			//			cmb_itemGroup.SelectedIndex = -1;
			//			txt_itemGroup.Text = "";
			//			txt_itemCode.Text = "";
			//			txt_itemName.Text = "";


			spd_main.ClearAll();

		}

		private void dpick_to_ValueChanged(object sender, System.EventArgs e)
		{
		
			//			cmb_wareHouse.SelectedIndex = -1;

			spd_main.ClearAll();

		}

		private void cmb_wareHouse_SelectedValueChanged(object sender, System.EventArgs e)
		{

			//			cmb_itemGroup.SelectedIndex = -1;
			//			txt_itemGroup.Text = "";
			//			txt_itemCode.Text = "";
			//			txt_itemName.Text = "";

			spd_main.ClearAll(); 

		}

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



		#endregion

		#region 그리드 관련


		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{

			if(e.Button != MouseButtons.Right) return;
			
			int vRow = spd_main.ActiveSheet.ActiveRowIndex;
			int vCol = spd_main.ActiveSheet.ActiveColumnIndex;

			if (spd_main.ActiveSheet.OperationMode != OperationMode.ReadOnly && !spd_main.ActiveSheet.Columns[vCol].Locked)
			{

				// relation 에 의해서 합쳐진 데이터에 대해서는
				// old 코드에 대한 팝업 리스트 표시 후, 바로 디비 적용
				if(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxRELATION_EXIST_YN].Value.ToString().Equals("Y") )
				{
					ValueExchangeProcessing_Relation(vRow, vCol);
				}
				else
				{
					ValueExchangeProcessing(vCol);
				}


			}

										
		}


		private void ValueExchangeProcessing_Relation(int vRow, int vCol)
		{

			try
			{
				string factory = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxFACTORY].Value.ToString();
				string whcd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxWH_CD].Value.ToString();
				string stockymd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxSTOCK_YMD].Value.ToString();
				string itemcd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_CD].Value.ToString();
				string speccd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxSPEC_CD].Value.ToString();
				string colorcd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxCOLOR_CD].Value.ToString();

				string tablehead_pgid = "SBK_STOCK_DAILY";

				DataTable dt_ret = Select_SBK_STOCK_RELATION(factory, whcd, stockymd, itemcd, speccd, colorcd);

				Pop_BK_Material_Relation_Modify pop_form = new Pop_BK_Material_Relation_Modify(dt_ret, tablehead_pgid);
				pop_form.ShowDialog();


				//---------------------------------------------------------------
				// 데이터 수정된 후 그리드에 새로운 데이터 표시 

				if(ClassLib.ComVar.Parameter_PopUpTable == null || ClassLib.ComVar.Parameter_PopUpTable.Rows.Count == 0) return;

				for(int i = 1; i < spd_main.ActiveSheet.ColumnCount; i++)
				{
					if (spd_main.ActiveSheet.Columns[i].Locked) continue;

					spd_main.ActiveSheet.Cells[vRow, i].Value = ClassLib.ComVar.Parameter_PopUpTable.Rows[0].ItemArray[i]; 

				}

				//---------------------------------------------------------------
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ValueExchangeProcessing_Relation", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}


		private void ValueExchangeProcessing(int vCol)
		{
			try
			{ 
				ClassLib.ComVar.Parameter_PopUp_Object  = null;
				ClassLib.ComVar.Parameter_PopUp_Object2 = null;
				ClassLib.ComVar.Parameter_PopUpTable	= null; 

				CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[1];
					COM.ComVar.Parameter_PopUp[0]	= spd_main.ActiveSheet.ColumnHeader.Cells[2,vCol].Text;  
				
					if (_cellTypes.ContainsKey(vCol))  
					{
						ClassLib.ComVar.Parameter_PopUp_Object  = new object[]{_cellData[vCol]};
						ClassLib.ComVar.Parameter_PopUp_Object2 = new object[]{_cellTypes[vCol]};
					}
					FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer pop_changer = new FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						for (int i = 0 ; i < vSelectionRange.Length; i++)
						{
							int start_row = vSelectionRange[i].Row;
							int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

							for (int j = start_row ; j < end_row; j++)
							{
								spd_main.ActiveSheet.Cells[j, vCol].Value		= COM.ComVar.Parameter_PopUp[0];    // Set TextBox Text

								if (COM.ComVar.Parameter_PopUp.Length > 1)
									spd_main.ActiveSheet.Cells[j, vCol].Value = COM.ComVar.Parameter_PopUp[1];	// Set SSPComboBox Value
								
								spd_main.Update_Row(j, img_Action);
							}
						}		  

					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ValueExchangeProcessing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}




		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{						
			Grid_EditModeOnProcess(spd_main);
		}		


		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
			if (vTemp == "CheckBoxCellType" || vTemp == "SSPComboBoxCellType"  )
			{
				arg_grid.Buffer_CellData = "000" ;
				arg_grid.Update_Row(img_Action) ;
			}
		}



		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{	
		
			int vRow = spd_main.ActiveSheet.ActiveRowIndex;
			int vCol = spd_main.ActiveSheet.ActiveColumnIndex;

			if(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxRELATION_EXIST_YN].Value.ToString().Equals("Y") ) return; 

			spd_main.Update_Row(img_Action);

		}


		#endregion
		
		#endregion

		#region DB Connect


		/// <summary>
		/// Select_SBK_STOCK : 
		/// </summary> 
		private DataTable Select_SBK_STOCK(string arg_factory, 
			string arg_warehouse, 
			string arg_stock_ymd_from, 
			string arg_stock_ymd_to, 
			string arg_item_group, 
			string arg_item_cd, 
			string arg_item_name)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBK_STOCK_DAILY.SELECT_SBK_STOCK";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_WH_CD";
			MyOraDB.Parameter_Name[2] = "ARG_STOCK_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_STOCK_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_GROUP";
			MyOraDB.Parameter_Name[5] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[6] = "ARG_ITEM_NAME";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR"; 

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_warehouse;
			MyOraDB.Parameter_Values[2] = arg_stock_ymd_from;
			MyOraDB.Parameter_Values[3] = arg_stock_ymd_to;
			MyOraDB.Parameter_Values[4] = arg_item_group;
			MyOraDB.Parameter_Values[5] = arg_item_cd;
			MyOraDB.Parameter_Values[6] = arg_item_name;
			MyOraDB.Parameter_Values[7] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null; 

			return ds_ret.Tables[MyOraDB.Process_Name];

		}



		/// <summary>
		/// Select_SBK_STOCK : 
		/// </summary> 
		private DataTable Select_SBK_STOCK_RELATION(string arg_factory, 
			string arg_whcd, 
			string arg_stockymd, 
			string arg_itemcd, 
			string arg_speccd, 
			string arg_colorcd)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBK_STOCK_DAILY.SELECT_SBK_STOCK_RELATION";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_WH_CD";
			MyOraDB.Parameter_Name[2] = "ARG_STOCK_YMD";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[5] = "ARG_COLOR_CD"; 
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
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_whcd;
			MyOraDB.Parameter_Values[2] = arg_stockymd;
			MyOraDB.Parameter_Values[3] = arg_itemcd;
			MyOraDB.Parameter_Values[4] = arg_speccd;
			MyOraDB.Parameter_Values[5] = arg_colorcd; 
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null; 

			return ds_ret.Tables[MyOraDB.Process_Name];

		}


		
		/// <summary>
		/// SAVE_CODE_UPDATE : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		public static bool SAVE_CODE_UPDATE(string[] arg_parameter)
		{

			try
			{

				COM.OraDB LMyOraDB	= new COM.OraDB();
 
				DataSet ds_ret; 

				int col_ct = 9;    
				 
				LMyOraDB.ReDim_Parameter(col_ct);
				LMyOraDB.Process_Name = "PKG_SBK_STOCK_DAILY.SAVE_CODE_UPDATE";

				// 파라미터 이름 설정
				LMyOraDB.Parameter_Name[0] = "ARG_DIVISION";   
				LMyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				LMyOraDB.Parameter_Name[2] = "ARG_WH_CD";
				LMyOraDB.Parameter_Name[3] = "ARG_DATE"; 
				LMyOraDB.Parameter_Name[4] = "ARG_ITEM_CD"; 
				LMyOraDB.Parameter_Name[5] = "ARG_SPEC_CD";   
				LMyOraDB.Parameter_Name[6] = "ARG_COLOR_CD";
				LMyOraDB.Parameter_Name[7] = "ARG_NEW_CODE"; 
				LMyOraDB.Parameter_Name[8] = "ARG_UPD_USER"; 

				
				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					LMyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 
				LMyOraDB.Parameter_Values[0] = arg_parameter[0];
				LMyOraDB.Parameter_Values[1] = arg_parameter[1];
				LMyOraDB.Parameter_Values[2] = arg_parameter[2];
				LMyOraDB.Parameter_Values[3] = arg_parameter[3];
				LMyOraDB.Parameter_Values[4] = arg_parameter[4];
				LMyOraDB.Parameter_Values[5] = arg_parameter[5];
				LMyOraDB.Parameter_Values[6] = arg_parameter[6];
				LMyOraDB.Parameter_Values[7] = arg_parameter[7];
				LMyOraDB.Parameter_Values[8] = ClassLib.ComVar.This_User; 

 
				LMyOraDB.Add_Modify_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}


			}
			catch
			{
				return false;
			}

		}


		#endregion

		private void menuItem_In_Click(object sender, System.EventArgs e)
		{
			
			try
			{ 
				

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;

				if(spd_main.ActiveSheet.RowCount == 0) return;


				MenuItem src = sender as MenuItem;
				string division = "";
				if(src.Equals(menuItem_In) )
				{
					division = "I";
				}
				else if(src.Equals(menuItem_Out) )
				{
					division = "O";
				}

				 
				string factory = cmb_factory.SelectedValue.ToString();
				string stock_ym = MyComFunction.ConvertDate2DbType(dpick_from.Text).Substring(0, 6);
				string warehouse = cmb_wareHouse.SelectedValue.ToString();  

				int vRow = spd_main.ActiveSheet.ActiveRowIndex;
				string item_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_CD].Value.ToString();
				string spec_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxSPEC_CD].Value.ToString();
				string color_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxCOLOR_CD].Value.ToString(); 
				string item_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_NAME].Value.ToString();
				string spec_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxSPEC_NAME].Value.ToString();
				string color_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxCOLOR_NAME].Value.ToString(); 
 

				string[] pop_parameter = new string[] { division, 
														  factory, 
														  stock_ym, 
														  warehouse,
														  item_cd, 
														  spec_cd, 
														  color_cd, 
														  item_name, 
														  spec_name, 
														  color_name };

				Pop_BK_InOut_Infomation pop_form = new Pop_BK_InOut_Infomation(pop_parameter);
				pop_form.ShowDialog();




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_InOut_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuItem_Out_Click(object sender, System.EventArgs e)
		{
			
			try
			{ 
				

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;

				if(spd_main.ActiveSheet.RowCount == 0) return;


				MenuItem src = sender as MenuItem;
				string division = "";
				if(src.Equals(menuItem_In) )
				{
					division = "I";
				}
				else if(src.Equals(menuItem_Out) )
				{
					division = "O";
				}

				 
				string factory = cmb_factory.SelectedValue.ToString();
				string stock_ym = MyComFunction.ConvertDate2DbType(dpick_from.Text).Substring(0, 6);
				string warehouse = cmb_wareHouse.SelectedValue.ToString();  

				int vRow = spd_main.ActiveSheet.ActiveRowIndex;
				string item_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_CD].Value.ToString();
				string spec_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxSPEC_CD].Value.ToString();
				string color_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxCOLOR_CD].Value.ToString(); 
				string item_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_NAME].Value.ToString();
				string spec_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxSPEC_NAME].Value.ToString();
				string color_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxCOLOR_NAME].Value.ToString(); 
 

				string[] pop_parameter = new string[] { division, 
														  factory, 
														  stock_ym, 
														  warehouse,
														  item_cd, 
														  spec_cd, 
														  color_cd, 
														  item_name, 
														  spec_name, 
														  color_name };

				Pop_BK_InOut_Infomation pop_form = new Pop_BK_InOut_Infomation(pop_parameter);
				pop_form.ShowDialog();




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_InOut_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuItem_MakeRelation_Click(object sender, System.EventArgs e)
		{
			
			try
			{ 
				

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;

				if(spd_main.ActiveSheet.RowCount == 0) return;


				MenuItem src = sender as MenuItem;
				
				int vRow = spd_main.ActiveSheet.ActiveRowIndex;
				string factory = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxFACTORY].Value.ToString();
				
				string division = "";

				if(src.Equals(menuItem_ItemRelation) )
				{
					division = "1";
				}
				else if(src.Equals(menuItem_SpecRelation) )
				{
					division = "2";
				}
				else if(src.Equals(menuItem_ColorRelation) )
				{
					division = "3";
				}

				  
				if(src.Equals(menuItem_ItemRelation) )
				{
					


					CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

					DataSet temp_DataSet = new System.Data.DataSet();
					DataRow newrow; 

					ClassLib.ComVar.Parameter_PopUpTable2 = temp_DataSet.Tables.Add("Item List");
					ClassLib.ComVar.Parameter_PopUpTable2.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
					ClassLib.ComVar.Parameter_PopUpTable2.Columns.Add(new DataColumn("Name", Type.GetType("System.String"))); 


					for (int i = 0 ; i < vSelectionRange.Length; i++)
					{
						int start_row = vSelectionRange[i].Row;
						int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

						for (int j = start_row ; j < end_row; j++)
						{
							newrow = ClassLib.ComVar.Parameter_PopUpTable2.NewRow(); 
							newrow[0] = spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_CD].Value.ToString();
							newrow[1] = spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_NAME].Value.ToString();  
							ClassLib.ComVar.Parameter_PopUpTable2.Rows.Add(newrow);
						}
					}		  



					Pop_BK_Material_Relation pop_form = new Pop_BK_Material_Relation(factory, division, ClassLib.ComVar.Parameter_PopUpTable2);
					pop_form.ShowDialog();

				}
				else 
				{

					
					string item_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_CD].Value.ToString();
					string spec_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxSPEC_CD].Value.ToString();
					string color_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxCOLOR_CD].Value.ToString(); 
					string item_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_NAME].Value.ToString();
					string spec_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxSPEC_NAME].Value.ToString();
					string color_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxCOLOR_NAME].Value.ToString(); 
					string unit = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxMNG_UNIT].Value.ToString(); 
 

					string[] pop_parameter = new string[] {factory, division, item_cd, spec_cd, color_cd, item_name, spec_name, color_name, unit};

					Pop_BK_Material_Relation pop_form = new Pop_BK_Material_Relation(pop_parameter);
					pop_form.ShowDialog();
					
 
				} 
				

				



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_InOut_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuItem_ItemChange_Click(object sender, System.EventArgs e)
		{
			

			try
			{ 
				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory };   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;

				if(spd_main.ActiveSheet.RowCount == 0) return; 

				MenuItem src = sender as MenuItem;
				string division = "";

				if(src.Equals(menuItem_ItemChange) )
				{
					division = "I";
				}
				else if(src.Equals(menuItem_SpecChange) )
				{
					division = "S";
				}
				else if(src.Equals(menuItem_ColorChange) )
				{
					division = "C";
				}


				string factory = cmb_factory.SelectedValue.ToString();
				string date = dpick_from.Value.ToString();

				int vRow = spd_main.ActiveSheet.ActiveRowIndex;
				string ItemCode  = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_CD].Value.ToString();
				string ItemName  = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_NAME].Value.ToString();
				string SpecCode  = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxSPEC_CD].Value.ToString();
				string SpecName  = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxSPEC_NAME].Value.ToString();
				string ColorCode = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxCOLOR_CD].Value.ToString();
				string ColorName = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_DAILY.IxCOLOR_NAME].Value.ToString();

				string[] pop_parameter = new string[] { division, factory, date, ItemCode, ItemName, SpecCode, SpecName, ColorCode, ColorName};

				Pop_BK_CodeChange pop_form = new Pop_BK_CodeChange(pop_parameter);
				pop_form.ShowDialog();

				if(COM.ComVar.Parameter_PopUp2[0].Trim() != "")
					ItemChange(pop_parameter);


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_InOut_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		private void ItemChange(string[] arg_parameter)
		{
			try
			{			
	
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) return;


				string _Date = "";
				string wh_cd     = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " ");  
				CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

				for (int i = 0 ; i < vSelectionRange.Length; i++)
				{
					int start_row = vSelectionRange[i].Row;
					int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

					for (int j = start_row ; j < end_row; j++)
					{
						_Date = spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBK_STOCK_DAILY.IxSTOCK_YMD].Value.ToString();
						string[] _parameter = new string[] { arg_parameter[0], arg_parameter[1], wh_cd, _Date, arg_parameter[3], arg_parameter[5], arg_parameter[7], COM.ComVar.Parameter_PopUp2[0] };
						SAVE_CODE_UPDATE(_parameter);
					}
				}		  

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SaveProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void btn_Research_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_ResearchProcess();
		}
		


		private void Tbtn_ResearchProcess()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;

				
                Thread tRun = null;
                tRun = new Thread(new ThreadStart(RunStockResearch));

                if (tRun != null)
                {
                    tRun.Start();
                    _popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
                    _popWait.Start();


                }



                tRun.Abort();
 


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





        public void RunStockResearch()
        {
            Invoke(new DelegateSetn(Run_Stock_Research)); // 폼 스레드에 작업 넘김

        }




		private FlexPurchase.Purchase.Pop_BP_Purchase_Wait _popWait = null;

		/// <summary>
		/// Run_Stock_Research : Stock Research
		/// </summary>
		private void Run_Stock_Research()
		{
  		
		
			bool save_flag = false;

			
			try
			{

				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory,  cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) 
				{
					_popWait.Close();
					return;
				}


				//				if(cmb_factory.SelectedIndex == -1 
				//					|| cmb_stockYY.SelectedIndex == -1 
				//					|| cmb_stockMM.SelectedIndex == -1
				//					|| cmb_wareHouse.SelectedIndex == -1) return;
				//					

				if (DialogResult.No == ClassLib.ComFunction.User_Message("Do you want to Run?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) 
				{
					_popWait.Close();
					return;
				}


				string factory = cmb_factory.SelectedValue.ToString();
				string warehouse = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " ");
				string stock_ym = MyComFunction.ConvertDate2DbType(dpick_from.Text).ToString().Substring(0, 6);
				string upd_user = ClassLib.ComVar.This_User;

				save_flag = RUN_SBK_STOCK_RESEARCH(factory, warehouse, stock_ym, upd_user);


				_popWait.Close(); 

				if(!save_flag)
				{ 
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);

				}
				else
				{

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
				} 
 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{



			}



		}


		/// <summary>
		/// RUN_SBK_STOCK_RESEARCH : 
		/// </summary>
		/// <returns>DataTable</returns>
		private bool RUN_SBK_STOCK_RESEARCH(string arg_factory, 
			string arg_warehouse, 
			string arg_stock_ym, 
			string arg_upd_user)
		{

			try
			{
 
				DataSet ds_ret; 

				int col_ct = 4;    
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBK_STOCK_CLOSE.RUN_SBK_STOCK_RESEARCH";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";   
				MyOraDB.Parameter_Name[1] = "ARG_WH_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_STOCK_YMD"; 
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER"; 


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 

				 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_warehouse;
				MyOraDB.Parameter_Values[2] = arg_stock_ym;
				MyOraDB.Parameter_Values[3] = arg_upd_user; 
 
				MyOraDB.Add_Modify_Parameter(true); 
				ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}


			}
			catch
			{
				return false;
			}


		}
         


	}
}
