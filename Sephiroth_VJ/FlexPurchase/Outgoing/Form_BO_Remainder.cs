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

namespace FlexPurchase.Outgoing
{
	public class Form_BO_Remainder : COM.PCHWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label btn_purchase;
		private System.Windows.Forms.Label btn_invoice;
		private System.Windows.Forms.Label btn_noShipping;
		private System.Windows.Forms.Label lbl_outYmd;
		private System.Windows.Forms.Label lbl_headInfo;
		private System.Windows.Forms.Label lbl_cont;
		private C1.Win.C1List.C1Combo cmb_outProcess;
		private COM.FSP fgrid_main;
		private C1.Win.C1List.C1Combo cmb_workLine;
		private System.Windows.Forms.Label lbl_workLine;
		private System.Windows.Forms.TextBox txt_itemNm;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_stockMM;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private C1.Win.C1List.C1Combo cmb_stockYY;
		private System.Windows.Forms.ContextMenu cmenu_Remainder;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_ValueExchange;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB    = new COM.OraDB();
		private bool _vConfirmYn	 = false;
		private bool _initYn		 = false;

		private Hashtable _cellCombo = null;
		private Hashtable _cellData  = null;

		private int	_vActiveCol		= 0;
		private int _vSaveCount		= 0;
		private int _vCommitCount	= 0;

		private string _vClosingYn		= "";
		
		private int _remarksCol	     = (int)ClassLib.TBSBB_REMAINDER.IxREMARKS;
		private int _reasonCol	     = (int)ClassLib.TBSBB_REMAINDER.IxREASON;
		private int _remainderQtyCol = (int)ClassLib.TBSBB_REMAINDER.IxREMAINDER_QTY;
		private int _adjustQtyCol    = (int)ClassLib.TBSBB_REMAINDER.IxADJUST_QTY;

		#endregion

		#region 생성자 / 소멸자
		public Form_BO_Remainder()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BO_Remainder));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_main = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_stockMM = new C1.Win.C1List.C1Combo();
            this.cmb_stockYY = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_workLine = new C1.Win.C1List.C1Combo();
            this.lbl_workLine = new System.Windows.Forms.Label();
            this.cmb_outProcess = new C1.Win.C1List.C1Combo();
            this.lbl_cont = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.btn_invoice = new System.Windows.Forms.Label();
            this.btn_noShipping = new System.Windows.Forms.Label();
            this.btn_purchase = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_outYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_insert = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.cmenu_Remainder = new System.Windows.Forms.ContextMenu();
            this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
            this.menuitem_ValueExchange = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockYY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            this.pnl_menu.SuspendLayout();
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
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.GridDefinition = "13.8698630136986:False:True;78.2534246575343:False:False;5.13698630136986:False:T" +
                "rue;\t0.393700787401575:False:True;97.6377952755905:False:False;0.393700787401575" +
                ":False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 584);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(12, 89);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(992, 457);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 171;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_stockMM);
            this.pnl_head.Controls.Add(this.cmb_stockYY);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.txt_itemNm);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.txt_itemCd);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.cmb_workLine);
            this.pnl_head.Controls.Add(this.lbl_workLine);
            this.pnl_head.Controls.Add(this.cmb_outProcess);
            this.pnl_head.Controls.Add(this.lbl_cont);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.btn_invoice);
            this.pnl_head.Controls.Add(this.btn_noShipping);
            this.pnl_head.Controls.Add(this.btn_purchase);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_outYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pictureBox3);
            this.pnl_head.Controls.Add(this.pictureBox2);
            this.pnl_head.Controls.Add(this.pictureBox1);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 81);
            this.pnl_head.TabIndex = 1;
            // 
            // cmb_stockMM
            // 
            this.cmb_stockMM.AddItemCols = 0;
            this.cmb_stockMM.AddItemSeparator = ';';
            this.cmb_stockMM.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_stockMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_stockMM.Caption = "";
            this.cmb_stockMM.CaptionHeight = 17;
            this.cmb_stockMM.CaptionStyle = style1;
            this.cmb_stockMM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_stockMM.ColumnCaptionHeight = 18;
            this.cmb_stockMM.ColumnFooterHeight = 18;
            this.cmb_stockMM.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_stockMM.ContentHeight = 16;
            this.cmb_stockMM.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_stockMM.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_stockMM.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_stockMM.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_stockMM.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_stockMM.EditorHeight = 16;
            this.cmb_stockMM.EvenRowStyle = style2;
            this.cmb_stockMM.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_stockMM.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stockMM.FooterStyle = style3;
            this.cmb_stockMM.GapHeight = 2;
            this.cmb_stockMM.HeadingStyle = style4;
            this.cmb_stockMM.HighLightRowStyle = style5;
            this.cmb_stockMM.ItemHeight = 15;
            this.cmb_stockMM.Location = new System.Drawing.Point(228, 55);
            this.cmb_stockMM.MatchEntryTimeout = ((long)(2000));
            this.cmb_stockMM.MaxDropDownItems = ((short)(12));
            this.cmb_stockMM.MaxLength = 32767;
            this.cmb_stockMM.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_stockMM.Name = "cmb_stockMM";
            this.cmb_stockMM.OddRowStyle = style6;
            this.cmb_stockMM.PartialRightColumn = false;
            this.cmb_stockMM.PropBag = resources.GetString("cmb_stockMM.PropBag");
            this.cmb_stockMM.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_stockMM.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_stockMM.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_stockMM.SelectedStyle = style7;
            this.cmb_stockMM.Size = new System.Drawing.Size(95, 20);
            this.cmb_stockMM.Style = style8;
            this.cmb_stockMM.TabIndex = 421;
            this.cmb_stockMM.SelectedValueChanged += new System.EventHandler(this.cmb_stockMM_SelectedValueChanged);
            // 
            // cmb_stockYY
            // 
            this.cmb_stockYY.AddItemCols = 0;
            this.cmb_stockYY.AddItemSeparator = ';';
            this.cmb_stockYY.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_stockYY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_stockYY.Caption = "";
            this.cmb_stockYY.CaptionHeight = 17;
            this.cmb_stockYY.CaptionStyle = style9;
            this.cmb_stockYY.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_stockYY.ColumnCaptionHeight = 18;
            this.cmb_stockYY.ColumnFooterHeight = 18;
            this.cmb_stockYY.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_stockYY.ContentHeight = 16;
            this.cmb_stockYY.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_stockYY.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_stockYY.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_stockYY.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_stockYY.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_stockYY.EditorHeight = 16;
            this.cmb_stockYY.EvenRowStyle = style10;
            this.cmb_stockYY.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_stockYY.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stockYY.FooterStyle = style11;
            this.cmb_stockYY.GapHeight = 2;
            this.cmb_stockYY.HeadingStyle = style12;
            this.cmb_stockYY.HighLightRowStyle = style13;
            this.cmb_stockYY.ItemHeight = 15;
            this.cmb_stockYY.Location = new System.Drawing.Point(104, 55);
            this.cmb_stockYY.MatchEntryTimeout = ((long)(2000));
            this.cmb_stockYY.MaxDropDownItems = ((short)(5));
            this.cmb_stockYY.MaxLength = 32767;
            this.cmb_stockYY.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_stockYY.Name = "cmb_stockYY";
            this.cmb_stockYY.OddRowStyle = style14;
            this.cmb_stockYY.PartialRightColumn = false;
            this.cmb_stockYY.PropBag = resources.GetString("cmb_stockYY.PropBag");
            this.cmb_stockYY.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_stockYY.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_stockYY.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_stockYY.SelectedStyle = style15;
            this.cmb_stockYY.Size = new System.Drawing.Size(123, 20);
            this.cmb_stockYY.Style = style16;
            this.cmb_stockYY.TabIndex = 420;
            this.cmb_stockYY.SelectedValueChanged += new System.EventHandler(this.cmb_stockYY_SelectedValueChanged);
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style19;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style20;
            this.cmb_factory.HighLightRowStyle = style21;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(104, 33);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style22;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style23;
            this.cmb_factory.Size = new System.Drawing.Size(218, 20);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(845, 55);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(138, 21);
            this.txt_itemNm.TabIndex = 414;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style25;
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
            this.cmb_itemGroup.EvenRowStyle = style26;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style27;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style28;
            this.cmb_itemGroup.HighLightRowStyle = style29;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(765, 33);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style30;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style31;
            this.cmb_itemGroup.Size = new System.Drawing.Size(196, 20);
            this.cmb_itemGroup.Style = style32;
            this.cmb_itemGroup.TabIndex = 413;
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(961, 33);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 412;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(765, 55);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(79, 21);
            this.txt_itemCd.TabIndex = 411;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(669, 55);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(94, 21);
            this.lbl_item.TabIndex = 410;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(669, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 409;
            this.label1.Text = "Item Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_workLine
            // 
            this.cmb_workLine.AddItemCols = 0;
            this.cmb_workLine.AddItemSeparator = ';';
            this.cmb_workLine.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_workLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_workLine.Caption = "";
            this.cmb_workLine.CaptionHeight = 17;
            this.cmb_workLine.CaptionStyle = style33;
            this.cmb_workLine.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_workLine.ColumnCaptionHeight = 18;
            this.cmb_workLine.ColumnFooterHeight = 18;
            this.cmb_workLine.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_workLine.ContentHeight = 16;
            this.cmb_workLine.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_workLine.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_workLine.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_workLine.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_workLine.EditorHeight = 16;
            this.cmb_workLine.EvenRowStyle = style34;
            this.cmb_workLine.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_workLine.FooterStyle = style35;
            this.cmb_workLine.GapHeight = 2;
            this.cmb_workLine.HeadingStyle = style36;
            this.cmb_workLine.HighLightRowStyle = style37;
            this.cmb_workLine.ItemHeight = 15;
            this.cmb_workLine.Location = new System.Drawing.Point(432, 55);
            this.cmb_workLine.MatchEntryTimeout = ((long)(2000));
            this.cmb_workLine.MaxDropDownItems = ((short)(5));
            this.cmb_workLine.MaxLength = 32767;
            this.cmb_workLine.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_workLine.Name = "cmb_workLine";
            this.cmb_workLine.OddRowStyle = style38;
            this.cmb_workLine.PartialRightColumn = false;
            this.cmb_workLine.PropBag = resources.GetString("cmb_workLine.PropBag");
            this.cmb_workLine.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_workLine.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_workLine.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_workLine.SelectedStyle = style39;
            this.cmb_workLine.Size = new System.Drawing.Size(220, 20);
            this.cmb_workLine.Style = style40;
            this.cmb_workLine.TabIndex = 398;
            // 
            // lbl_workLine
            // 
            this.lbl_workLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workLine.ImageIndex = 0;
            this.lbl_workLine.ImageList = this.img_Label;
            this.lbl_workLine.Location = new System.Drawing.Point(336, 55);
            this.lbl_workLine.Name = "lbl_workLine";
            this.lbl_workLine.Size = new System.Drawing.Size(94, 21);
            this.lbl_workLine.TabIndex = 399;
            this.lbl_workLine.Text = "Work Line";
            this.lbl_workLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_outProcess
            // 
            this.cmb_outProcess.AddItemCols = 0;
            this.cmb_outProcess.AddItemSeparator = ';';
            this.cmb_outProcess.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outProcess.Caption = "";
            this.cmb_outProcess.CaptionHeight = 17;
            this.cmb_outProcess.CaptionStyle = style41;
            this.cmb_outProcess.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_outProcess.ColumnCaptionHeight = 18;
            this.cmb_outProcess.ColumnFooterHeight = 18;
            this.cmb_outProcess.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_outProcess.ContentHeight = 16;
            this.cmb_outProcess.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_outProcess.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_outProcess.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_outProcess.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_outProcess.EditorHeight = 16;
            this.cmb_outProcess.EvenRowStyle = style42;
            this.cmb_outProcess.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_outProcess.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outProcess.FooterStyle = style43;
            this.cmb_outProcess.GapHeight = 2;
            this.cmb_outProcess.HeadingStyle = style44;
            this.cmb_outProcess.HighLightRowStyle = style45;
            this.cmb_outProcess.ItemHeight = 15;
            this.cmb_outProcess.Location = new System.Drawing.Point(432, 33);
            this.cmb_outProcess.MatchEntryTimeout = ((long)(2000));
            this.cmb_outProcess.MaxDropDownItems = ((short)(5));
            this.cmb_outProcess.MaxLength = 32767;
            this.cmb_outProcess.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_outProcess.Name = "cmb_outProcess";
            this.cmb_outProcess.OddRowStyle = style46;
            this.cmb_outProcess.PartialRightColumn = false;
            this.cmb_outProcess.PropBag = resources.GetString("cmb_outProcess.PropBag");
            this.cmb_outProcess.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outProcess.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outProcess.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outProcess.SelectedStyle = style47;
            this.cmb_outProcess.Size = new System.Drawing.Size(220, 20);
            this.cmb_outProcess.Style = style48;
            this.cmb_outProcess.TabIndex = 397;
            // 
            // lbl_cont
            // 
            this.lbl_cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_cont.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cont.ImageIndex = 1;
            this.lbl_cont.ImageList = this.img_Label;
            this.lbl_cont.Location = new System.Drawing.Point(336, 33);
            this.lbl_cont.Name = "lbl_cont";
            this.lbl_cont.Size = new System.Drawing.Size(94, 21);
            this.lbl_cont.TabIndex = 394;
            this.lbl_cont.Text = "Work Process";
            this.lbl_cont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbl_headInfo.TabIndex = 392;
            this.lbl_headInfo.Text = "      Outgoing Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_invoice
            // 
            this.btn_invoice.Location = new System.Drawing.Point(0, 0);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(100, 23);
            this.btn_invoice.TabIndex = 388;
            // 
            // btn_noShipping
            // 
            this.btn_noShipping.Location = new System.Drawing.Point(0, 0);
            this.btn_noShipping.Name = "btn_noShipping";
            this.btn_noShipping.Size = new System.Drawing.Size(100, 23);
            this.btn_noShipping.TabIndex = 389;
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(0, 0);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(100, 23);
            this.btn_purchase.TabIndex = 390;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 373);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_outYmd
            // 
            this.lbl_outYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outYmd.ImageIndex = 1;
            this.lbl_outYmd.ImageList = this.img_Label;
            this.lbl_outYmd.Location = new System.Drawing.Point(8, 55);
            this.lbl_outYmd.Name = "lbl_outYmd";
            this.lbl_outYmd.Size = new System.Drawing.Size(94, 21);
            this.lbl_outYmd.TabIndex = 50;
            this.lbl_outYmd.Text = "Outgoing Date";
            this.lbl_outYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 372);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 33);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(94, 21);
            this.lbl_factory.TabIndex = 50;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pic_head5.Location = new System.Drawing.Point(0, 373);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
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
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(960, 18);
            this.pictureBox3.TabIndex = 424;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(976, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 423;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 20);
            this.pictureBox1.TabIndex = 422;
            this.pictureBox1.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 16);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 362);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 348);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Controls.Add(this.btn_insert);
            this.pnl_menu.Controls.Add(this.btn_cancel);
            this.pnl_menu.Location = new System.Drawing.Point(12, 550);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(992, 30);
            this.pnl_menu.TabIndex = 170;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(0, 0);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(100, 23);
            this.btn_insert.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(0, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 23);
            this.btn_cancel.TabIndex = 1;
            // 
            // cmenu_Remainder
            // 
            this.cmenu_Remainder.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuitem_SelectAll,
            this.menuitem_ValueExchange});
            this.cmenu_Remainder.Popup += new System.EventHandler(this.cmenu_Remainder_Popup);
            // 
            // menuitem_SelectAll
            // 
            this.menuitem_SelectAll.Index = 0;
            this.menuitem_SelectAll.Text = "Select All";
            this.menuitem_SelectAll.Click += new System.EventHandler(this.menuitem_SelectAll_Click);
            // 
            // menuitem_ValueExchange
            // 
            this.menuitem_ValueExchange.Index = 1;
            this.menuitem_ValueExchange.Text = "Value Exchange";
            this.menuitem_ValueExchange.Click += new System.EventHandler(this.menuitem_ValueExchange_Click);
            // 
            // Form_BO_Remainder
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BO_Remainder";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BO_Remainder_Closing);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockYY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
			{
				_vActiveCol = fgrid_main.Cols[fgrid_main.Col].Index; 

				Set_MenuItem_Visible();
				
				this.cmenu_Remainder.Show(fgrid_main, new Point(e.X, e.Y));
			}
		}

//		private void fgrid_main_EditModeOn(object sender, System.EventArgs e)
//		{						
//			Grid_EditModeOnProcess(fgrid_main) ;
//		}		
//
//		private void fgrid_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
//		{			
//			fgrid_main.Update_Row(img_Action);
//		}
//
//		private void fgrid_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
//		{
//			if (e.Button == MouseButtons.Right)
//				Grid_CellClickProcess(e);
//		}

		//		private void fgrid_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		//		{
		//			if (!e.ColumnHeader)
		//				Grid_DoubleClickProcess(fgrid_main,e.Row,e.Column);
		//		}
		private void Grid_AfterEditProcess()
		{
			if ((fgrid_main.Col == _remarksCol))
			{
				fgrid_main[fgrid_main.Row, _reasonCol] = fgrid_main.CursorCell.DataDisplay.ToString();				
			}

			if(fgrid_main.Col == _adjustQtyCol)
			{
				double remainder_qty = (fgrid_main[fgrid_main.Row, _remainderQtyCol] == null) ? 0 : Convert.ToDouble(fgrid_main[fgrid_main.Row, _remainderQtyCol] );
				double adjust_qty = (fgrid_main[fgrid_main.Row, _adjustQtyCol] == null) ? 0 : Convert.ToDouble(fgrid_main[fgrid_main.Row, _adjustQtyCol] );
 

				//remainder_qty = remainder_qty + adjust_qty;


				remainder_qty = adjust_qty;
				fgrid_main[fgrid_main.Row, _remainderQtyCol] = remainder_qty.ToString();

			}


			fgrid_main.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{ 
			this.Tbtn_SearchProcess(true);
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SaveProcess(true);
		}						

//		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
//		{
//			this.Tbtn_DeleteProcess();
//		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(_vConfirmYn) 
				this.Tbtn_ConfirmCancelProcess();
			else
				this.Tbtn_ConfirmProcess();
		}

		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		private void Form_BO_Remainder_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}

		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
			string vTyep = this.cmb_itemGroup.SelectedValue.ToString();
			FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);

			vPopup.ShowDialog();
			
			string _group_cd	= COM.ComVar.Parameter_PopUp[3];				
			string _group_name	= COM.ComVar.Parameter_PopUp[4];				
			txt_itemCd.Text		= _group_cd;
			txt_itemNm.Text		= _group_name;
			
			vPopup.Dispose();		
		}

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (cmb_itemGroup.SelectedIndex >= 0 )
				this.btn_groupSearch.Enabled = true;
			else
				this.btn_groupSearch.Enabled = false;
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (!_initYn)
				this.ClosingCheckProcess(true); 			
		}

		private void cmb_stockYY_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (!_initYn)
				this.ClosingCheckProcess(true); 			
		}

		private void cmb_stockMM_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (!_initYn)
				this.ClosingCheckProcess(true); 			
		}

		private void ClosingCheckProcess(bool arg_check)
		{
			try
			{
				if (arg_check)
				{
					DataTable vDt = FlexPurchase.ClassLib.ComFunction.Select_Close_Yn(	cmb_factory.SelectedValue.ToString().Trim(), 
																						FlexPurchase.ClassLib.ComVar.Month, 
																						COM.ComFunction.Empty_Combo(cmb_stockYY, "")+COM.ComFunction.Empty_Combo(cmb_stockMM, ""), 
																						FlexPurchase.ClassLib.ComVar.Stock);
				
					if (vDt.Rows.Count > 0)
						_vClosingYn = vDt.Rows[0][0].ToString(); 
					else
						_vClosingYn = "N";

					if (_vClosingYn == "Y")
					{
						ClassLib.ComFunction.User_Message("Already Closed Stock At This Month.", "Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}

					this.EnableControlCheckProcess(true);	// Control Enable Check
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void EnableControlCheckProcess(bool arg_bool)
		{
			try
			{
				if (arg_bool)
				{
					if(_vClosingYn == "Y")   // 재고마감이 된 경우
					{
						tbtn_Confirm.Enabled		= false;
						fgrid_main.AllowEditing		= false;
						tbtn_Save.Enabled			= false;
					}
					else
					{
						_vSaveCount		= 0;
						_vCommitCount	= 0;

						if (fgrid_main.Rows.Count > 0 && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
						{
							// Status 확인
							for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
							{
								if (fgrid_main[vRow, (int)ClassLib.TBSBB_REMAINDER.IxSTATUS].ToString() == "C")
								{
									_vCommitCount = _vCommitCount + 1; 
									fgrid_main.Rows[vRow].AllowEditing = false;
								}
								else 
								{
									_vSaveCount   = _vSaveCount + 1;
									fgrid_main.Rows[vRow].AllowEditing = true;
								}
							}

							if (_vSaveCount > 0 && _vCommitCount > 0)
							{
								tbtn_Confirm.Enabled		= false;
								tbtn_Save.Enabled			= true;
							}
							else 
							{
								tbtn_Confirm.Enabled		= true;
								if ( _vCommitCount > 0 )
								{
									_vConfirmYn				= true;
									fgrid_main.AllowEditing = false;
									tbtn_Save.Enabled		= false;
								}
								else 
								{
									_vConfirmYn				= false;
									fgrid_main.AllowEditing = true;
									tbtn_Save.Enabled		= true;
								}
							}
						}
						else
						{
							fgrid_main.ClearAll();
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
							tbtn_Confirm.Enabled    = false;
							tbtn_Save.Enabled		= true;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#region 입력이동

		#endregion

		#region 버튼효과

		#endregion

		#region 롤오버 이미지 처리

		#endregion


		#endregion

		#region 버튼 이벤트 처리

		#endregion

		#region 공통 메서드

		private void GridSetSelectCorrection(FarPoint.Win.Spread.Model.CellRange arg_range)
		{
			int vStartRow    = arg_range.Row;
			int vEndRow	     = arg_range.Row + arg_range.RowCount;

			if (fgrid_main[vStartRow, 0] == null)
			{
				fgrid_main.Update_Row(vStartRow);
			}
			else
			{
				fgrid_main[vStartRow,0] = "";
			}

			while (vStartRow < vEndRow)
			{
				vStartRow++;
			}
		}

		#endregion

		#region 컨텍스트(팝업) 메뉴 이벤트

		private void cmenu_Remainder_Popup(object sender, System.EventArgs e)
		{
			try
			{
				//				int vCol = _mainSheet.ActiveColumnIndex;
				// 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Remainder_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

  		
		/// <summary>
		/// Set_MenuItem_Visible : 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
		/// </summary>
		private void Set_MenuItem_Visible()
		{
			if (!fgrid_main.AllowEditing || !fgrid_main.Cols[_vActiveCol].AllowEditing)
				this.menuitem_ValueExchange.Visible		= false;
			else
				this.menuitem_ValueExchange.Visible		= true;

			this.menuitem_SelectAll.Visible			= true;
		}

		/// <summary>
		/// Select_All : 모든 Row 선택
		/// </summary>
		private void menuitem_SelectAll_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				fgrid_main.SelectAll();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_SelectAll_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void menuitem_ValueExchange_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				ValueExchangeProcessing(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_ValueExchange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary> 
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
			_initYn	= true;

            lbl_MainTitle.Text = "Remainder Closing";
            this.Text = "Remainder Closing";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			fgrid_main.Set_Grid("SBB_REMAINDER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true; 

			

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// Item Group Combobox Setting
			vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
			vDt.Dispose();

			// StockYY add items
			cmb_stockYY.AddItemTitles("Code");
			cmb_stockYY.ValueMember		= "Code";
			cmb_stockYY.Splits[0].DisplayColumns["Code"].Width = 103;
			for (int i = 2000; i <= 2500; i++)
			{
				cmb_stockYY.AddItem(i.ToString());
			}
			cmb_stockYY.SelectedValue = System.DateTime.Today.Year.ToString();

			// StockMM add Items
			cmb_stockMM.AddItemTitles("Code");
			cmb_stockMM.ValueMember		= "Code";
			cmb_stockMM.Splits[0].DisplayColumns["Code"].Width = 92;

			for (int i = 1; i <= 12; i++)
			{
				cmb_stockMM.AddItem(i.ToString().PadLeft(2,'0'));
			}
			cmb_stockMM.SelectedValue = System.DateTime.Today.Month.ToString().PadLeft(2,'0');

			//	cmb_outProcess
			//vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Process_List(ClassLib.ComVar.This_Factory);
			//COM.ComCtl.Set_ComboList(vDt, cmb_outProcess, 0, 1, false);
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Opcd_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_outProcess, 1, 1, false);
			
			cmb_outProcess.SelectedIndex = -1;

			// cmb_workLine
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, false);
			vDt.Dispose() ;

			// Disabled tbutton
			tbtn_Confirm.Enabled	= false;
			tbtn_Create.Enabled		= false;
			tbtn_Print.Enabled		= false;
			tbtn_Delete.Enabled		= false;
			btn_insert.Enabled		= false;

			// set grid cell type
			_cellData  = new Hashtable(fgrid_main.Cols.Count);
			_cellCombo = new Hashtable(fgrid_main.Cols.Count);
			IDictionary vDic = null;
			IEnumerator vEnum  = null;
			IEnumerator vEnum2 = null;
			string[] vTemp = null;
			string[] vData = null;

			for (int vCol = 1, vCnt = 0 ; vCol < fgrid_main.Cols.Count ; vCol++)
			{
 

				if(fgrid_main.Cols[vCol].DataType.Equals(typeof(double) ) )
				{
					fgrid_main.Cols[vCol].Format = "#,##0.00";
				}


				if (fgrid_main.Cols[vCol].AllowEditing)
				{
					if (fgrid_main.Cols[vCol].DataMap != null)
					{
						vDic = fgrid_main.Cols[vCol].DataMap;
						vTemp = new string[vDic.Count];
						vData = new string[vDic.Count];
						vEnum  = vDic.Values.GetEnumerator();
						vEnum2 = vDic.Keys.GetEnumerator();
						while (vEnum.MoveNext())
							vTemp[vCnt++] = vEnum.Current.ToString();

						vCnt = 0;
						_cellCombo.Add(vCol, vTemp);

						while (vEnum2.MoveNext())
							vData[vCnt++] = vEnum2.Current.ToString();

						vCnt = 0;
						_cellData.Add(vCol, vData);
					}
				}
			}
	
			_initYn	= false; 

			// 자재 마감 여부 체크
			this.ClosingCheckProcess(true); 
		}
				
		private void ValueExchangeProcessing()
		{
			try
			{ 
				int vCol = _vActiveCol; 
				ClassLib.ComVar.Parameter_PopUp_Object  = null;
				ClassLib.ComVar.Parameter_PopUp_Object2 = null;
				ClassLib.ComVar.Parameter_PopUpTable	= null; 

				int[] vSelectionRange = fgrid_main.Selections;

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[1];
					COM.ComVar.Parameter_PopUp[0]	= fgrid_main[1, vCol].ToString();
				
					if (_cellCombo.ContainsKey(vCol))  
					{
						ClassLib.ComVar.Parameter_PopUp_Object  = new object[]{_cellData[vCol]};
						ClassLib.ComVar.Parameter_PopUp_Object2 = new object[]{_cellCombo[vCol]};
					}
					FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer pop_changer = new FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						foreach (int i in vSelectionRange)
						{
							fgrid_main[i, vCol] = COM.ComVar.Parameter_PopUp[0];							
							if (COM.ComVar.Parameter_PopUp.Length > 1)
							{
								fgrid_main[i, vCol]			= COM.ComVar.Parameter_PopUp[1];	// Set SSPComboBox Value
								fgrid_main[i, vCol +1]		= COM.ComVar.Parameter_PopUp[0];	// Set SSPComboBox Display
							}
							fgrid_main.Update_Row(i);
						}
					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_ValueExchange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}	
		
		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();
				this.cmb_itemGroup.SelectedIndex	= -1;
				this.cmb_outProcess.SelectedIndex	= -1;
				this.cmb_workLine.SelectedIndex		= -1;
				this.txt_itemCd.Text	= ""; 
				this.txt_itemNm.Text	= ""; 
				this.btn_groupSearch.Enabled = false;
				
				tbtn_Save.Enabled		= true;
				fgrid_main.AllowEditing	= true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess(bool arg_bool)
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory, cmb_stockYY, cmb_stockMM, cmb_outProcess}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					DataTable vTemp = this.SELECT_SBB_REMAINDER_LIST();

					//					_vSaveCount		= 0;
					//					_vCommitCount	= 0;

					if (vTemp.Rows.Count > 0)
					{
						ClassLib.ComFunction.Display_FlexGrid_Variable(fgrid_main, vTemp);
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);

						//						// Status 확인
						//						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
						//						{
						//							if (fgrid_main[vRow, (int)ClassLib.TBSBB_REMAINDER.IxSTATUS].ToString() == "C")
						//							{
						//								_vCommitCount = _vCommitCount + 1; 
						//								fgrid_main.Rows[vRow].AllowEditing = false;
						//							}
						//							else 
						//							{
						//								_vSaveCount   = _vSaveCount + 1;
						//								fgrid_main.Rows[vRow].AllowEditing = true;
						//							}
						//						}
						//
						//						if (_vSaveCount > 0 && _vCommitCount > 0)
						//						{
						//							tbtn_Confirm.Enabled		= false;
						//							tbtn_Save.Enabled			= true;
						//						}
						//						else 
						//						{
						//							tbtn_Confirm.Enabled		= true;
						//							if ( _vCommitCount > 0 )
						//							{
						//								_vConfirmYn				= true;
						//								fgrid_main.AllowEditing = false;
						//								tbtn_Save.Enabled		= false;
						//							}
						//							else 
						//							{
						//								_vConfirmYn				= false;
						//								fgrid_main.AllowEditing = true;
						//								tbtn_Save.Enabled		= true;
						//							}
						//						}
						//					}
						//					else
						//					{
						//						fgrid_main.ClearAll();
						//						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
						//						tbtn_Confirm.Enabled    = false;
						//						tbtn_Save.Enabled		= true;
					}
					else
					{
						fgrid_main.ClearAll();
					}

					this.EnableControlCheckProcess(true);	// Control Enable Check
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_AfterSaveProcess(bool arg_bool)
		{
			try
			{				
				for(int i = fgrid_main.Rows.Count - 1; i >= fgrid_main.Rows.Fixed; i--)
				{
					if(fgrid_main[i,0] == null || fgrid_main[i, 0].ToString() == "") continue; 
							

					if( fgrid_main[i, 0].ToString() == "D" )
					{ 
						fgrid_main.Rows.Remove(i);
					}
					else
					{
						fgrid_main[i, 0] = "";
					}
				}

				this.EnableControlCheckProcess(true);	// Control Enable Check

//				// Status 확인
//				int _vCommitCount	= 0;
//				int _vSaveCount		= 0;
//				for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
//				{
//					if (fgrid_main[vRow, (int)ClassLib.TBSBB_REMAINDER.IxSTATUS].ToString() == "C")
//						_vCommitCount = _vCommitCount + 1; 
//					else 
//						_vSaveCount   = _vSaveCount + 1;
//				}
//
//				if (_vSaveCount > 0 && _vCommitCount > 0)
//					tbtn_Confirm.Enabled	= false;
//				else 
//				{
//					tbtn_Confirm.Enabled	= true;
//					if ( _vCommitCount > 0 )
//						_vConfirmYn			= true;
//					else 
//						_vConfirmYn			= false;
//				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}		

		private bool Tbtn_SaveProcess(bool arg_bool)
		{
			try
			{ 
				DialogResult result = new DialogResult(); 

				if (arg_bool) 
				{	
					result = ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				if ((!arg_bool) || result.ToString() == "Yes")
				{
					fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1); 
					if (MyOraDB.Save_FlexGird("PKG_SBB_REMAINDER.SAVE_SBB_REMAINDER", fgrid_main))
					{
						Tbtn_AfterSaveProcess(true);
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
						return true;
					}
				}
				return false;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
				return false;
			}		
		}

		private bool Tbtn_AfterConfirmProcess(string arg_div)
		{
			try
			{ 
				SELECT_SBB_PROCESS_CLOSING(arg_div); 		
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
				return false;
			}		
		}

		private void Tbtn_ConfirmProcess()
		{
			try
			{ 
				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					if ( fgrid_main.Rows.Count > fgrid_main.Rows.Fixed && fgrid_main.Rows.Count > 0)
					{
						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
						{
							if (fgrid_main[vRow, 0] != null && fgrid_main[vRow, 0].ToString() != "")
							{
								bool vBool = Tbtn_SaveProcess(false);
							}
						}

						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
						{
							fgrid_main[vRow, (int)ClassLib.TBSBB_REMAINDER.IxSTATUS] = "C";
							fgrid_main[vRow,0] =  "C";	
						}
								
						if (Tbtn_SaveProcess(false) )
						{
							if ( Tbtn_AfterConfirmProcess("C") )
							{
								ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
								ClassLib.ComFunction.User_Message("Completed Comfirm", "Confirm_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Information);

								this.EnableControlCheckProcess(true);	// Control Enable Check
					
//								tbtn_Confirm.Enabled	= true;
//								tbtn_Save.Enabled		= false;
//								fgrid_main.AllowEditing	= false;
							}
						}
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}
		
		private void Tbtn_ConfirmCancelProcess()
		{
			try
			{ 
				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you Cancel to Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
					{
						if (fgrid_main[vRow, 0] != null && fgrid_main[vRow, 0].ToString() != "")
						{
							bool vBool = Tbtn_SaveProcess(false); 
						}
					}	
	
					for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
					{
						fgrid_main[vRow, (int)ClassLib.TBSBB_REMAINDER.IxSTATUS] = "S";
						fgrid_main[vRow,0] =  "C";	
					}
	
					if ( Tbtn_SaveProcess(false) )
					{		
						if ( Tbtn_AfterConfirmProcess("S") )
						{
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
							ClassLib.ComFunction.User_Message("Completed Cancel", "Cancel_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Information);

							this.EnableControlCheckProcess(true);	// Control Enable Check
					
							//						tbtn_Save.Enabled		= true;
							//						tbtn_Confirm.Enabled	= true;
							//						fgrid_main.AllowEditing	= true;
						}
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

//		private void Tbtn_DeleteProcess()
//		{
//			try
//			{ 
//				string  vOutNo = "";
//				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Delete?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
//				{
//					vOutNo = SAVE_SBO_OUT_HEAD("D");
//
//					if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
//					{
//						fgrid_main.Select(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0);
//					}
//					fgrid_main.Delete_Row();
//
//					if (MyOraDB.Save_FlexGird("PKG_SBO_OUT_TAIL.SAVE_SBO_OUT_TAIL", fgrid_main))
//						this.Cmb_outNoSettingProcess(true);				
//				}
//			}
//
//			catch(Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.ToString());
//			}		
//		}
//
		#endregion

		#region DB Connect
 				
		/// <summary>
		/// SELECT_SBB_REMAINDER : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// SELECT_SBB_REMAINDER : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBB_REMAINDER_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBB_REMAINDER.SELECT_SBB_REMAINDER_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_WORK_MONTH";
			MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[3] = "ARG_OP_CD";
			MyOraDB.Parameter_Name[4] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[5] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[6] = "ARG_ITEM_NM";
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
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_stockYY, "")+COM.ComFunction.Empty_Combo(cmb_stockMM, "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_workLine, "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_outProcess, "");
			MyOraDB.Parameter_Values[4] = this.cmb_itemGroup.SelectedIndex > -1 ? this.cmb_itemGroup.SelectedValue.ToString() : "";
			MyOraDB.Parameter_Values[5] = this.txt_itemCd.Text;
			MyOraDB.Parameter_Values[6] = this.txt_itemNm.Text;
			MyOraDB.Parameter_Values[7] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

 				
		/// <summary>
		/// SELECT_SBB_REMAINDER : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// SELECT_SBB_REMAINDER : 
		/// </summary>
		/// <returns>DataTable</returns>
		public void SELECT_SBB_PROCESS_CLOSING(string arg_div)
		{
			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBB_REMAINDER.SELECT_SBB_PROCESS_CLOSING";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_TERM_DIV";
			MyOraDB.Parameter_Name[2] = "ARG_TERM_YMD";
			MyOraDB.Parameter_Name[3] = "ARG_PROCESS_DIV";
			MyOraDB.Parameter_Name[4] = "ARG_CONFER_YN";
			MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = FlexPurchase.ClassLib.ComVar.Month;
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_stockYY, "")+COM.ComFunction.Empty_Combo(cmb_stockMM, "");
			MyOraDB.Parameter_Values[3] = FlexPurchase.ClassLib.ComVar.Remainder;
			MyOraDB.Parameter_Values[4] = arg_div; 
			MyOraDB.Parameter_Values[5] = COM.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}

		#endregion



	}
}

