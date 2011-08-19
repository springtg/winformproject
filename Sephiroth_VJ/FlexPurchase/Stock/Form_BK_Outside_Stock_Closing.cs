using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Threading;

using C1.Win.C1FlexGrid;

namespace FlexPurchase.Stock
{
	public class Form_BK_Outside_Stock_Closing : COM.PCHWinForm.Form_Top
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
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_itemGroup;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private C1.Win.C1List.C1Combo cmb_status;
		private System.Windows.Forms.Label lbl_StockYm;
		private C1.Win.C1List.C1Combo cmb_month;
		private C1.Win.C1List.C1Combo cmb_year;
		private System.Windows.Forms.Label btn_closing;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.TextBox txt_styleCode;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label lbl_status;

		#region 생성자 / 소멸자

		public Form_BK_Outside_Stock_Closing()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BK_Outside_Stock_Closing));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_main = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_style = new System.Windows.Forms.Label();
            this.txt_styleCode = new System.Windows.Forms.TextBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.btn_closing = new System.Windows.Forms.Label();
            this.cmb_month = new C1.Win.C1List.C1Combo();
            this.cmb_year = new C1.Win.C1List.C1Combo();
            this.lbl_StockYm = new System.Windows.Forms.Label();
            this.cmb_status = new C1.Win.C1List.C1Combo();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_itemGroup = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "19.6551724137931:False:True;78.2758620689655:False:False;\t0.393700787401575:False" +
                ":True;97.6377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(12, 122);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(992, 454);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 34;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.lbl_style);
            this.pnl_head.Controls.Add(this.txt_styleCode);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.btn_closing);
            this.pnl_head.Controls.Add(this.cmb_month);
            this.pnl_head.Controls.Add(this.cmb_year);
            this.pnl_head.Controls.Add(this.lbl_StockYm);
            this.pnl_head.Controls.Add(this.cmb_status);
            this.pnl_head.Controls.Add(this.lbl_status);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_itemGroup);
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.txt_itemNm);
            this.pnl_head.Controls.Add(this.txt_itemCd);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.pic_head3);
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
            this.pnl_head.Size = new System.Drawing.Size(1000, 114);
            this.pnl_head.TabIndex = 33;
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(338, 40);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 561;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCode
            // 
            this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCode.Location = new System.Drawing.Point(439, 40);
            this.txt_styleCode.MaxLength = 10;
            this.txt_styleCode.Name = "txt_styleCode";
            this.txt_styleCode.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCode.TabIndex = 559;
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
            this.cmb_style.Location = new System.Drawing.Point(519, 40);
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
            this.cmb_style.TabIndex = 560;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            // 
            // btn_closing
            // 
            this.btn_closing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_closing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_closing.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_closing.ImageIndex = 0;
            this.btn_closing.ImageList = this.img_Button;
            this.btn_closing.Location = new System.Drawing.Point(911, 80);
            this.btn_closing.Name = "btn_closing";
            this.btn_closing.Size = new System.Drawing.Size(80, 23);
            this.btn_closing.TabIndex = 558;
            this.btn_closing.Text = "Closing";
            this.btn_closing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_closing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_closing_MouseDown);
            this.btn_closing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_closing_MouseUp);
            // 
            // cmb_month
            // 
            this.cmb_month.AddItemCols = 0;
            this.cmb_month.AddItemSeparator = ';';
            this.cmb_month.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_month.Caption = "";
            this.cmb_month.CaptionHeight = 17;
            this.cmb_month.CaptionStyle = style9;
            this.cmb_month.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_month.ColumnCaptionHeight = 18;
            this.cmb_month.ColumnFooterHeight = 18;
            this.cmb_month.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_month.ContentHeight = 16;
            this.cmb_month.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_month.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_month.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_month.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_month.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_month.EditorHeight = 16;
            this.cmb_month.EvenRowStyle = style10;
            this.cmb_month.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_month.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_month.FooterStyle = style11;
            this.cmb_month.GapHeight = 2;
            this.cmb_month.HeadingStyle = style12;
            this.cmb_month.HighLightRowStyle = style13;
            this.cmb_month.ItemHeight = 15;
            this.cmb_month.Location = new System.Drawing.Point(225, 62);
            this.cmb_month.MatchEntryTimeout = ((long)(2000));
            this.cmb_month.MaxDropDownItems = ((short)(12));
            this.cmb_month.MaxLength = 32767;
            this.cmb_month.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.OddRowStyle = style14;
            this.cmb_month.PartialRightColumn = false;
            this.cmb_month.PropBag = resources.GetString("cmb_month.PropBag");
            this.cmb_month.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_month.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_month.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_month.SelectedStyle = style15;
            this.cmb_month.Size = new System.Drawing.Size(104, 20);
            this.cmb_month.Style = style16;
            this.cmb_month.TabIndex = 557;
            // 
            // cmb_year
            // 
            this.cmb_year.AddItemCols = 0;
            this.cmb_year.AddItemSeparator = ';';
            this.cmb_year.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_year.Caption = "";
            this.cmb_year.CaptionHeight = 17;
            this.cmb_year.CaptionStyle = style17;
            this.cmb_year.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_year.ColumnCaptionHeight = 18;
            this.cmb_year.ColumnFooterHeight = 18;
            this.cmb_year.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_year.ContentHeight = 16;
            this.cmb_year.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_year.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_year.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_year.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_year.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_year.EditorHeight = 16;
            this.cmb_year.EvenRowStyle = style18;
            this.cmb_year.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_year.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_year.FooterStyle = style19;
            this.cmb_year.GapHeight = 2;
            this.cmb_year.HeadingStyle = style20;
            this.cmb_year.HighLightRowStyle = style21;
            this.cmb_year.ItemHeight = 15;
            this.cmb_year.Location = new System.Drawing.Point(109, 62);
            this.cmb_year.MatchEntryTimeout = ((long)(2000));
            this.cmb_year.MaxDropDownItems = ((short)(5));
            this.cmb_year.MaxLength = 32767;
            this.cmb_year.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.OddRowStyle = style22;
            this.cmb_year.PartialRightColumn = false;
            this.cmb_year.PropBag = resources.GetString("cmb_year.PropBag");
            this.cmb_year.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_year.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_year.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_year.SelectedStyle = style23;
            this.cmb_year.Size = new System.Drawing.Size(115, 20);
            this.cmb_year.Style = style24;
            this.cmb_year.TabIndex = 556;
            // 
            // lbl_StockYm
            // 
            this.lbl_StockYm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_StockYm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockYm.ImageIndex = 1;
            this.lbl_StockYm.ImageList = this.img_Label;
            this.lbl_StockYm.Location = new System.Drawing.Point(8, 62);
            this.lbl_StockYm.Name = "lbl_StockYm";
            this.lbl_StockYm.Size = new System.Drawing.Size(100, 21);
            this.lbl_StockYm.TabIndex = 555;
            this.lbl_StockYm.Text = "Stock Date";
            this.lbl_StockYm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_status
            // 
            this.cmb_status.AddItemCols = 0;
            this.cmb_status.AddItemSeparator = ';';
            this.cmb_status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_status.Caption = "";
            this.cmb_status.CaptionHeight = 17;
            this.cmb_status.CaptionStyle = style25;
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
            this.cmb_status.EvenRowStyle = style26;
            this.cmb_status.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FooterStyle = style27;
            this.cmb_status.GapHeight = 2;
            this.cmb_status.HeadingStyle = style28;
            this.cmb_status.HighLightRowStyle = style29;
            this.cmb_status.ItemHeight = 15;
            this.cmb_status.Location = new System.Drawing.Point(772, 40);
            this.cmb_status.MatchEntryTimeout = ((long)(2000));
            this.cmb_status.MaxDropDownItems = ((short)(5));
            this.cmb_status.MaxLength = 32767;
            this.cmb_status.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.OddRowStyle = style30;
            this.cmb_status.PartialRightColumn = false;
            this.cmb_status.PropBag = resources.GetString("cmb_status.PropBag");
            this.cmb_status.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_status.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_status.SelectedStyle = style31;
            this.cmb_status.Size = new System.Drawing.Size(220, 20);
            this.cmb_status.Style = style32;
            this.cmb_status.TabIndex = 553;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ImageIndex = 0;
            this.lbl_status.ImageList = this.img_Label;
            this.lbl_status.Location = new System.Drawing.Point(668, 40);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_status.TabIndex = 554;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(109, 84);
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
            this.cmb_vendor.CaptionStyle = style33;
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
            this.cmb_vendor.EvenRowStyle = style34;
            this.cmb_vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style35;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style36;
            this.cmb_vendor.HighLightRowStyle = style37;
            this.cmb_vendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(189, 84);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style38;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style39;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style40;
            this.cmb_vendor.TabIndex = 550;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(564, 62);
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
            this.cmb_itemGroup.CaptionStyle = style41;
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
            this.cmb_itemGroup.EvenRowStyle = style42;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style43;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style44;
            this.cmb_itemGroup.HighLightRowStyle = style45;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(439, 62);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style46;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style47;
            this.cmb_itemGroup.Size = new System.Drawing.Size(124, 20);
            this.cmb_itemGroup.Style = style48;
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
            this.btn_groupSearch.Location = new System.Drawing.Point(637, 62);
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
            this.lbl_itemGroup.Location = new System.Drawing.Point(338, 62);
            this.lbl_itemGroup.Name = "lbl_itemGroup";
            this.lbl_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemGroup.TabIndex = 545;
            this.lbl_itemGroup.Text = "Item Group";
            this.lbl_itemGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(8, 84);
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
            this.txt_itemNm.Location = new System.Drawing.Point(499, 84);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(160, 21);
            this.txt_itemNm.TabIndex = 408;
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(439, 84);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCd.TabIndex = 402;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(338, 84);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 401;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 98);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style49;
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
            this.cmb_factory.EvenRowStyle = style50;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style51;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style52;
            this.cmb_factory.HighLightRowStyle = style53;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style54;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style55;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style56;
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
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 73);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 98);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 87);
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
            this.pictureBox1.Location = new System.Drawing.Point(168, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 18);
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // Form_BK_Outside_Stock_Closing
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BK_Outside_Stock_Closing";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).EndInit();
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

		private const int CON_RAW_MATRIAL = 0, CON_OUTSIDE_MATRIAL = 1, CON_OUTSIDE_STOCK = 2;
		private const string CON_RAW_NOT = "N", CON_RAW_SAVE = "S", CON_RAW_OUTGOING = "O", CON_RAW_INCOMING = "I", CON_RAW_FINISH = "F";
		private const string CON_OUTSIDE_NOT = "N", CON_OUTSIDE_SAVE = "S", CON_OUTSIDE_OUTGOING = "O";
		private const string STR_SUB_TOTAL = "TOTAL", STR_GRAND_TOTAL = "GRAND TOTAL";

		private COM.OraDB MyOraDB	= new COM.OraDB();
		private string _itemGroupCode = " ";
		private FlexPurchase.Purchase.Pop_BP_Purchase_Wait _waitPop = null;

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
			fgrid_main.Update_Row();
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

		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				if (checkSearch())
				{
					print();
				}
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

		private void btn_closing_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            btn_closing.ImageIndex = 0;		
		}

		private void btn_closing_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				_waitPop = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
				Thread temp_thread = new Thread(new ThreadStart(_waitPop.Start));

				if (temp_thread != null)
				{
					temp_thread.Start(); 
					this.closing();

				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				btn_closing.ImageIndex = 1;
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

            lbl_MainTitle.Text = "Outside Stock Closing";
            this.Text = lbl_MainTitle.Text;
            ClassLib.ComFunction.SetLangDic(this);
			
			fgrid_main.Set_Grid("SBK_OUTSIDE_STOCK_CLOSING", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Rows[0].AllowMerging = true;
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);

			DataTable vDt = null;

			// factory
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose();

			// Item Group
			vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
			vDt.Dispose();

			// Year 
			vDt = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxYear);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_year, 2, 2, false, ClassLib.ComVar.ComboList_Visible.Code);  
			cmb_year.SelectedValue = System.DateTime.Today.Year.ToString();
			vDt.Dispose();

			// Month
			cmb_month.AddItemTitles("Code");
			cmb_month.ValueMember = "Code"; 

			for (int i = 1; i <= 12; i++)
			{
				cmb_month.AddItem(i.ToString().PadLeft(2,'0'));
			}

			cmb_month.MaxDropDownItems = 10;
			cmb_month.SelectedValue = System.DateTime.Today.Month.ToString().PadLeft(2,'0');


			// Disabled tbutton
			tbtn_Confirm.Enabled = false;
			tbtn_Create.Enabled  = false;
			tbtn_Delete.Enabled	 = false;
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
					fgrid_main.Display_Grid(vDt, false);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
				}

				vDt.Dispose();
				setGridColor();
			}
		}

		private void print()
		{
			string factory		= ClassLib.ComFunction.NullCheck(cmb_factory.SelectedValue, "");
			string ship_type	= "11";
			string cust_cd		= txt_vendorCode.Text;
			string stock_ymd_from = ClassLib.ComFunction.Empty_Combo(cmb_year, "") + ClassLib.ComFunction.Empty_Combo(cmb_month, "");
			string stock_ymd_to = ClassLib.ComFunction.Empty_Combo(cmb_year, "") + ClassLib.ComFunction.Empty_Combo(cmb_month, "");
			string group_cd		= _itemGroupCode;
			string item_cd		= txt_itemCd.Text;
			string item_name	= txt_itemNm.Text;

			ClassLib.ComVar.Parameter_PopUp = new string[]{factory, ship_type, cust_cd, stock_ymd_from, 
															  stock_ymd_to, group_cd, item_cd, item_name};

			new Pop_BK_Outside_Stock_Close_Print().ShowDialog();
		}

		private void setGridColor()
		{
			for (int row = fgrid_main.Rows.Fixed ; row < fgrid_main.Rows.Count ; row++)
			{
				CellRange range = fgrid_main.GetCellRange(row, fgrid_main.Cols.Frozen, row, fgrid_main.Cols.Count - 1);
				range.StyleNew.BackColor = ClassLib.ComVar.RightBlue;
				//range.StyleNew.ForeColor = Color.Black;
			}
		}

		private void subTotal(int row)
		{
			int inQtyCol = (int)ClassLib.TBSBK_OUTSIDE_STOCK_30.IxIN_QTY;
			int outQtyCol = (int)ClassLib.TBSBK_OUTSIDE_STOCK_30.IxOUT_QTY;
			int itemCol = (int)ClassLib.TBSBK_OUTSIDE_STOCK_30.IxITEM_NAME;
			int totalRow = fgrid_main.Rows[row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index + 1;

			Node newNode = fgrid_main.Rows.InsertNode(totalRow, 1);
			newNode.Row[inQtyCol] = fgrid_main.Aggregate(AggregateEnum.Sum, row, inQtyCol, totalRow, inQtyCol);
			newNode.Row[outQtyCol] = fgrid_main.Aggregate(AggregateEnum.Sum, row, outQtyCol, totalRow, outQtyCol);
			newNode.Row[itemCol] = STR_SUB_TOTAL;
			fgrid_main.Rows[newNode.Row.Index].StyleNew.BackColor = ClassLib.ComVar.RightPink1;
		}

		private void grandTotal()
		{
			int inQtyCol = (int)ClassLib.TBSBK_OUTSIDE_STOCK_30.IxIN_QTY;
			int outQtyCol = (int)ClassLib.TBSBK_OUTSIDE_STOCK_30.IxOUT_QTY;
			int itemCol = (int)ClassLib.TBSBK_OUTSIDE_STOCK_30.IxITEM_NAME;
			int totalRow = fgrid_main.Rows.Count;

			Node newNode = fgrid_main.Rows.InsertNode(totalRow, 1);
			newNode.Row[inQtyCol] = fgrid_main.Aggregate(AggregateEnum.Sum, fgrid_main.Rows.Fixed, inQtyCol, totalRow, inQtyCol);
			newNode.Row[outQtyCol] = fgrid_main.Aggregate(AggregateEnum.Sum, fgrid_main.Rows.Fixed, outQtyCol, totalRow, outQtyCol);
			newNode.Row[itemCol] = STR_GRAND_TOTAL;
			fgrid_main.Rows[newNode.Row.Index].StyleNew.BackColor = ClassLib.ComVar.RightYellow;
		}

		private void save()
		{
			if (MyOraDB.Save_FlexGird("PKG_SBK_OUTSIDE_STOCK_CLOSE.SAVE_SBK_OUTSIDE_STOCK_CLOSE", fgrid_main))
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				ClassLib.ComFunction.User_Message("Save Complete!!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				fgrid_main.Refresh_Division();
			}
		}

		private void closing()
		{
			try
			{
				if (this.SAVE_SBK_OUTSIDE_STOCK_CLOSE())
				{
					this.search();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.User_Message("Closing Fail!!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void searchVendor()
		{
			DataTable vDt;
			vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_vendorCode.Text);
			COM.ComCtl.Set_ComboList(vDt, cmb_vendor, 0, 1, true, 79, 141);
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
			C1.Win.C1List.C1Combo[] combo = new C1.Win.C1List.C1Combo[] {cmb_factory, cmb_year, cmb_month};
			if (!ClassLib.ComFunction.Essentiality_check(combo, null, false))
				return false;

			return true;
		}

		private bool checkSave()
		{
			C1.Win.C1List.C1Combo[] combo = new C1.Win.C1List.C1Combo[] {cmb_factory, cmb_year, cmb_month};
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
		/// PKG_SBK_OUTSIDE_STOCK_CLOSE.SELECT_SBK_OUTSIDE_STOCK
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBK_OUTSIDE_STOCK_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(11);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBK_OUTSIDE_STOCK_CLOSE.SELECT_SBK_OUTSIDE_STOCK_CLOSE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[3] = "ARG_YEAR";
			MyOraDB.Parameter_Name[4] = "ARG_MONTH";
			MyOraDB.Parameter_Name[5] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[7] = "ARG_ITEM_NM";
			MyOraDB.Parameter_Name[8] = "ARG_STATUS";
			MyOraDB.Parameter_Name[9] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[10] = "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[2] = this.cmb_vendor.SelectedIndex > -1 ? this.cmb_vendor.SelectedValue.ToString() : "";
			MyOraDB.Parameter_Values[3] = this.cmb_year.Text;
			MyOraDB.Parameter_Values[4] = this.cmb_month.Text;
			MyOraDB.Parameter_Values[5] = _itemGroupCode;
			MyOraDB.Parameter_Values[6] = this.txt_itemCd.Text;
			MyOraDB.Parameter_Values[7] = this.txt_itemNm.Text;
			MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_Combo(cmb_status, "");
			MyOraDB.Parameter_Values[9] = COM.ComFunction.Empty_TextBox(txt_styleCode, "");
			MyOraDB.Parameter_Values[10] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBK_OUTSIDE_STOCK_CLOSE.SAVE_SBK_OUTSIDE_STOCK_CLOSE 
		/// </summary>
		public bool SAVE_SBK_OUTSIDE_STOCK_CLOSE()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBK_OUTSIDE_STOCK_CLOSE.INSERT_SBK_OUTSIDE_STOCK_CLOSE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[3] = "ARG_YEAR";
			MyOraDB.Parameter_Name[4] = "ARG_MONTH";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[2] = this.cmb_vendor.SelectedIndex > -1 ? this.cmb_vendor.SelectedValue.ToString() : "";
			MyOraDB.Parameter_Values[3] = this.cmb_year.Text;
			MyOraDB.Parameter_Values[4] = this.cmb_month.Text;

			MyOraDB.Add_Modify_Parameter(true);
			vds_ret = MyOraDB.Exe_Modify_Procedure();
			if(vds_ret == null) return false ;

			return true;
		}

		#endregion


	}
}

