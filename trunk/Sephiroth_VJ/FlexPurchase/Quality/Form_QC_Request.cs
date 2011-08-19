using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Quality
{
	public class Form_QC_Request : COM.PCHWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label btn_purchase;
		private System.Windows.Forms.Label btn_invoice;
		private System.Windows.Forms.Label btn_noShipping;
		private System.Windows.Forms.Label lbl_headInfo;
		private System.Windows.Forms.Label lbl_vendor;
        private System.Windows.Forms.TextBox txt_vendorCode;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.DateTimePicker dpick_reqYmd;
		private System.Windows.Forms.Label btn_shipping;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label lbl_color;
		private System.Windows.Forms.TextBox txt_colorNm;
		private System.Windows.Forms.Label btn_itemSearch;
		private System.Windows.Forms.Label btn_colorSearch;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.TextBox txt_colorCd;
		private System.Windows.Forms.Label lbl_reqYmd;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.RadioButton rad_tail;
		private System.Windows.Forms.RadioButton rad_head;
		private C1.Win.C1List.C1Combo cmb_printType;
		private System.Windows.Forms.Label lbl_printType;
		private System.Windows.Forms.GroupBox groupBox1;
		private string vReqNoSeq = "0000";
		public string inspQty = "0";

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB   = new COM.OraDB();
		private bool _vConfirmYn	= false;
		private bool _practicable	= false;
		private bool _isAccessible	= false;
 
		private int _ldLevCol			= (int)ClassLib.TBSQL_LAB_REQUEST.IxLEV; 
		private int _ldFactoryCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxFACTORY; 
		private int _ldReqYmdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxREQ_YMD; 
		private int _ldReqNoCol			= (int)ClassLib.TBSQL_LAB_REQUEST.IxREQ_NO; 
		private int _ldReqSeqCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxREQ_SEQ; 
		private int _ldReqQtyCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxREQ_QTY;
		private int _ldStatusCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSTATUS;
        private C1.Win.C1List.C1Combo cmb_vendor;
		private int _ldDirQtyCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxCUST_DIR_QTY;
//		private int _ldItemCdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxITEM_CD; 
//		private int _ldItemNameCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxITEM_NAME;
//		private int _ldSpecCdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSPEC_CD;
//		private int _ldSpecNameCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSPEC_NAME;
//		private int _ldColorCdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxCOLOR_CD; 
//		private int _ldColorNameCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxCOLOR_NAME; 
//		private int _ldUnitCol			= (int)ClassLib.TBSQL_LAB_REQUEST.IxUNIT;
//		private int _ldCustCdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxCUST_CD;
//		private int _ldCustNameCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxCUST_NAME;
//		private int _ldStyleCdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSTYLE_CD;
//		private int _ldDefQtyCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxDEF_QTY;
//		private int _ldDefTypeCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxDEF_TYPE;
//		private int _ldResultCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxRESULT;
//		private int _ldShipNoCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSHIP_NO;
//		private int _ldShipSeqCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSHIP_SEQ;
//		private int _ldShipYmdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSHIP_YMD;
//		private int _ldPurUserCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxPUR_USER;
//		private int _ldLotNoCol			= (int)ClassLib.TBSQL_LAB_REQUEST.IxLOT_NO;
//		private int _ldLotSeqCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxLOT_SEQ;
//		private int _ldObsTypeCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxOBS_TYPE;
//		private int _ldUpdUserCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxUPD_USER;			

		#endregion

		#region 생성자 / 소멸자
		public Form_QC_Request()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QC_Request));
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
            this.fgrid_main = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.cmb_printType = new C1.Win.C1List.C1Combo();
            this.lbl_printType = new System.Windows.Forms.Label();
            this.rad_tail = new System.Windows.Forms.RadioButton();
            this.rad_head = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.btn_shipping = new System.Windows.Forms.Label();
            this.btn_colorSearch = new System.Windows.Forms.Label();
            this.btn_itemSearch = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.txt_colorNm = new System.Windows.Forms.TextBox();
            this.txt_colorCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.btn_invoice = new System.Windows.Forms.Label();
            this.btn_noShipping = new System.Windows.Forms.Label();
            this.btn_purchase = new System.Windows.Forms.Label();
            this.dpick_reqYmd = new System.Windows.Forms.DateTimePicker();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_reqYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
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
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
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
            this.c1Sizer1.GridDefinition = "17.6369863013699:False:True;78.9383561643836:False:False;0.684931506849315:False:" +
                "True;\t0.393700787401575:False:True;97.6377952755905:False:False;0.39370078740157" +
                "5:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 584);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.Location = new System.Drawing.Point(12, 111);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 19;
            this.fgrid_main.Size = new System.Drawing.Size(1000, 461);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 173;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.cmb_printType);
            this.pnl_head.Controls.Add(this.lbl_printType);
            this.pnl_head.Controls.Add(this.rad_tail);
            this.pnl_head.Controls.Add(this.rad_head);
            this.pnl_head.Controls.Add(this.groupBox1);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.btn_shipping);
            this.pnl_head.Controls.Add(this.btn_colorSearch);
            this.pnl_head.Controls.Add(this.btn_itemSearch);
            this.pnl_head.Controls.Add(this.lbl_color);
            this.pnl_head.Controls.Add(this.txt_colorNm);
            this.pnl_head.Controls.Add(this.txt_colorCd);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.txt_itemNm);
            this.pnl_head.Controls.Add(this.txt_itemCd);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.btn_invoice);
            this.pnl_head.Controls.Add(this.btn_noShipping);
            this.pnl_head.Controls.Add(this.btn_purchase);
            this.pnl_head.Controls.Add(this.dpick_reqYmd);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_reqYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 103);
            this.pnl_head.TabIndex = 1;
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style1;
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
            this.cmb_vendor.EvenRowStyle = style2;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style3;
            this.cmb_vendor.HeadingStyle = style4;
            this.cmb_vendor.HighLightRowStyle = style5;
            this.cmb_vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_vendor.Images"))));
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(189, 77);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style6;
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style7;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style8;
            this.cmb_vendor.TabIndex = 429;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            // 
            // cmb_printType
            // 
            this.cmb_printType.AddItemSeparator = ';';
            this.cmb_printType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_printType.Caption = "";
            this.cmb_printType.CaptionHeight = 17;
            this.cmb_printType.CaptionStyle = style9;
            this.cmb_printType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_printType.ColumnCaptionHeight = 18;
            this.cmb_printType.ColumnFooterHeight = 18;
            this.cmb_printType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_printType.ContentHeight = 16;
            this.cmb_printType.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_printType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_printType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_printType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_printType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_printType.EditorHeight = 16;
            this.cmb_printType.EvenRowStyle = style10;
            this.cmb_printType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_printType.FooterStyle = style11;
            this.cmb_printType.HeadingStyle = style12;
            this.cmb_printType.HighLightRowStyle = style13;
            this.cmb_printType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_printType.Images"))));
            this.cmb_printType.ItemHeight = 15;
            this.cmb_printType.Location = new System.Drawing.Point(453, 77);
            this.cmb_printType.MatchEntryTimeout = ((long)(2000));
            this.cmb_printType.MaxDropDownItems = ((short)(5));
            this.cmb_printType.MaxLength = 32767;
            this.cmb_printType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_printType.Name = "cmb_printType";
            this.cmb_printType.OddRowStyle = style14;
            this.cmb_printType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_printType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_printType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_printType.SelectedStyle = style15;
            this.cmb_printType.Size = new System.Drawing.Size(220, 20);
            this.cmb_printType.Style = style16;
            this.cmb_printType.TabIndex = 428;
            this.cmb_printType.PropBag = resources.GetString("cmb_printType.PropBag");
            // 
            // lbl_printType
            // 
            this.lbl_printType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_printType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_printType.ImageIndex = 0;
            this.lbl_printType.ImageList = this.img_Label;
            this.lbl_printType.Location = new System.Drawing.Point(352, 77);
            this.lbl_printType.Name = "lbl_printType";
            this.lbl_printType.Size = new System.Drawing.Size(100, 21);
            this.lbl_printType.TabIndex = 427;
            this.lbl_printType.Text = "Print Type";
            this.lbl_printType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rad_tail
            // 
            this.rad_tail.Location = new System.Drawing.Point(880, 51);
            this.rad_tail.Name = "rad_tail";
            this.rad_tail.Size = new System.Drawing.Size(88, 16);
            this.rad_tail.TabIndex = 425;
            this.rad_tail.Text = "Detaile";
            this.rad_tail.CheckedChanged += new System.EventHandler(this.rad_tail_CheckedChanged);
            // 
            // rad_head
            // 
            this.rad_head.Checked = true;
            this.rad_head.Location = new System.Drawing.Point(768, 51);
            this.rad_head.Name = "rad_head";
            this.rad_head.Size = new System.Drawing.Size(96, 16);
            this.rad_head.TabIndex = 424;
            this.rad_head.TabStop = true;
            this.rad_head.Text = "Header";
            this.rad_head.CheckedChanged += new System.EventHandler(this.rad_head_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(723, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 44);
            this.groupBox1.TabIndex = 426;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TreeView Option";
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
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 423;
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
            this.lbl_factory.TabIndex = 52;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 1;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(8, 77);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 398;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(109, 77);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 396;
            this.txt_vendorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vendorCode_KeyPress);
            // 
            // btn_shipping
            // 
            this.btn_shipping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shipping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_shipping.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_shipping.ImageIndex = 0;
            this.btn_shipping.ImageList = this.img_Button;
            this.btn_shipping.Location = new System.Drawing.Point(906, 77);
            this.btn_shipping.Name = "btn_shipping";
            this.btn_shipping.Size = new System.Drawing.Size(80, 23);
            this.btn_shipping.TabIndex = 415;
            this.btn_shipping.Text = "Shipping List";
            this.btn_shipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_shipping.Click += new System.EventHandler(this.btn_shipping_Click);
            // 
            // btn_colorSearch
            // 
            this.btn_colorSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_colorSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_colorSearch.ImageIndex = 27;
            this.btn_colorSearch.ImageList = this.img_SmallButton;
            this.btn_colorSearch.Location = new System.Drawing.Point(673, 55);
            this.btn_colorSearch.Name = "btn_colorSearch";
            this.btn_colorSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_colorSearch.TabIndex = 422;
            this.btn_colorSearch.Tag = "Search";
            this.btn_colorSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_colorSearch.Click += new System.EventHandler(this.btn_colorSearch_Click);
            // 
            // btn_itemSearch
            // 
            this.btn_itemSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_itemSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemSearch.ImageIndex = 27;
            this.btn_itemSearch.ImageList = this.img_SmallButton;
            this.btn_itemSearch.Location = new System.Drawing.Point(673, 33);
            this.btn_itemSearch.Name = "btn_itemSearch";
            this.btn_itemSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_itemSearch.TabIndex = 412;
            this.btn_itemSearch.Tag = "Search";
            this.btn_itemSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_itemSearch.Click += new System.EventHandler(this.btn_itemSearch_Click);
            // 
            // lbl_color
            // 
            this.lbl_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_color.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.ImageIndex = 0;
            this.lbl_color.ImageList = this.img_Label;
            this.lbl_color.Location = new System.Drawing.Point(352, 55);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(100, 21);
            this.lbl_color.TabIndex = 419;
            this.lbl_color.Text = "Color";
            this.lbl_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_colorNm
            // 
            this.txt_colorNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_colorNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_colorNm.Location = new System.Drawing.Point(533, 55);
            this.txt_colorNm.MaxLength = 10;
            this.txt_colorNm.Name = "txt_colorNm";
            this.txt_colorNm.Size = new System.Drawing.Size(140, 21);
            this.txt_colorNm.TabIndex = 421;
            // 
            // txt_colorCd
            // 
            this.txt_colorCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_colorCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_colorCd.Location = new System.Drawing.Point(453, 55);
            this.txt_colorCd.MaxLength = 10;
            this.txt_colorCd.Name = "txt_colorCd";
            this.txt_colorCd.Size = new System.Drawing.Size(79, 21);
            this.txt_colorCd.TabIndex = 420;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(352, 33);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 416;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(533, 33);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(140, 21);
            this.txt_itemNm.TabIndex = 418;
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(453, 33);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(79, 21);
            this.txt_itemCd.TabIndex = 417;
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
            this.lbl_headInfo.Text = "      Request Info.";
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
            // dpick_reqYmd
            // 
            this.dpick_reqYmd.CustomFormat = "";
            this.dpick_reqYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_reqYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_reqYmd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_reqYmd.Location = new System.Drawing.Point(109, 55);
            this.dpick_reqYmd.Name = "dpick_reqYmd";
            this.dpick_reqYmd.Size = new System.Drawing.Size(220, 21);
            this.dpick_reqYmd.TabIndex = 381;
            this.dpick_reqYmd.CloseUp += new System.EventHandler(this.dpick_reqYmd_CloseUp);
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 87);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_reqYmd
            // 
            this.lbl_reqYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqYmd.ImageIndex = 1;
            this.lbl_reqYmd.ImageList = this.img_Label;
            this.lbl_reqYmd.Location = new System.Drawing.Point(8, 55);
            this.lbl_reqYmd.Name = "lbl_reqYmd";
            this.lbl_reqYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqYmd.TabIndex = 50;
            this.lbl_reqYmd.Text = "Request Date";
            this.lbl_reqYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 86);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 62);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 87);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 76);
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
            // Form_QC_Request
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_QC_Request";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_QC_Request_Closing);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
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

//		private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
//		{
//			int vRow = fgrid_main.Selection.r1 ;
//
//			if(vRow > fgrid_main.Rows.Fixed)
//				Grid_DoubleClickProcess(vRow);
//		}

		private void Grid_AfterEditProcess()
		{
			fgrid_main.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

//		private void Grid_DoubleClickProcess(int vRow)
//		{
//			try
//			{
//				Pop_QC_Result_List vPopup = new Pop_QC_Result_List();
//			
////				COM.ComVar.Parameter_PopUp		= new string[2];
////
////				COM.ComVar.Parameter_PopUp[0]	= fgrid_main[vRow, _ldReqYmdCol].ToString();
////				COM.ComVar.Parameter_PopUp[1]	= fgrid_main[vRow, _ldReqSeqCol].ToString();
////				COM.ComVar.Parameter_PopUp[2]	= fgrid_main[vRow, _ldFactoryCol].ToString();
////				COM.ComVar.Parameter_PopUp[3]	= fgrid_main[vRow, _ldCustCdCol].ToString();
//			
//				vPopup.ShowDialog();
//			}
//			catch (Exception ex)
//			{
//				COM.ComFunction.User_Message(ex.Message, "Grid_DoubleClickProcess");
//			}
//		}

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{ 
			this.Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SaveProcess(true);
		}						

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_DeleteProcess();
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(_vConfirmYn) 
				this.Tbtn_ConfirmCancelProcess();
			else
				this.Tbtn_ConfirmProcess();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess(); 
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

		private void Form_QC_Request_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}

		private void cmb_vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{			
			this.Cmb_VendorSelectedValueChangedProcess();
		}

		private void txt_vendorCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
			{
				Txt_VendorCodeTextChangedProcess();		
				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
			}
		}

		private void btn_itemSearch_Click(object sender, System.EventArgs e)
		{
			try
			{	
				COM.ComVar.Parameter_PopUp		= new string[1];
				COM.ComVar.Parameter_PopUp[0]	= "Item";

				FlexBase.MaterialBase.Pop_Item_List vPopup = new FlexBase.MaterialBase.Pop_Item_List();
				vPopup.ShowDialog(); 
			
				if (COM.ComVar.Parameter_PopUp[0] != "")
				{
					txt_itemCd.Text		= ClassLib.ComVar.Parameter_PopUp[0];
					txt_itemNm.Text		= ClassLib.ComVar.Parameter_PopUp[1];
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void btn_colorSearch_Click(object sender, System.EventArgs e)
		{
			try
			{	
				COM.ComVar.Parameter_PopUp		= new string[1];
				COM.ComVar.Parameter_PopUp[0]	= "Color";

				FlexBase.MaterialBase.Pop_Item_List vPopup = new FlexBase.MaterialBase.Pop_Item_List();
				vPopup.ShowDialog(); 
			
				if (COM.ComVar.Parameter_PopUp[4] != "")
				{
					txt_colorCd.Text	= ClassLib.ComVar.Parameter_PopUp[4];
					txt_colorNm.Text	= ClassLib.ComVar.Parameter_PopUp[5];
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void btn_shipping_Click(object sender, System.EventArgs e)
		{
			this.Btn_ShippingClickProcess(); 
		}

		private void rad_head_CheckedChanged(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(1);
		}

		private void rad_tail_CheckedChanged(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);
		}

		#region 입력이동

		#endregion

		#region 버튼효과

		#endregion

		#region 롤오버 이미지 처리

		#endregion


		#endregion

		#region 버튼 이벤트 처리

		private void Btn_ShippingClickProcess()
		{
			COM.ComVar.Parameter_PopUp		= new string[2];
			COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			COM.ComVar.Parameter_PopUp[1]	= ClassLib.ComFunction.Empty_Combo(cmb_vendor, "");

			Pop_QC_Shipping_List vPopup = new Pop_QC_Shipping_List(this, txt_vendorCode.Text);
						
			vPopup.ShowDialog();

			if (vPopup._DT != null && vPopup._DT.Rows.Count > 0 && vPopup.DialogResult == DialogResult.OK)
			{
				System.Data.DataRow[] newDr = vPopup._DT.Select("", "LEV ASC");
				DataTable vDT = vPopup._DT.Clone();

				for (int i = 0; i < newDr.Length; i++)
				{
					vDT.ImportRow(newDr[i]); 
				}

				// 그리드에 Container 정보 추가
				Apply_Grid(vDT); 
			}
		}

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

		#region 이벤트 처리 메서드
		
		/// <summary> 
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
			//			ClassLib.ComFunction.Init_Form_Control(this);

            lbl_MainTitle.Text = "Request for Testing";
            this.Text = "Request for Testing";
            ClassLib.ComFunction.SetLangDic(this);

			_practicable = true;

			// Grid Setting
			fgrid_main.Set_Grid("SQL_LAB_REQUEST", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
//			cmb_factory.SelectedIndex = 0;
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// Print type Set  cmb_printType
			cmb_printType.AddItemTitles("Code;Name");
			cmb_printType.ValueMember		= "Code";
			cmb_printType.DisplayMember		= "Name";
			cmb_printType.AddItem("M;Request Physical Lab Test");
			cmb_printType.AddItem("L;Request List");
			cmb_printType.SelectedValue = "M";  
			cmb_printType.DropDownWidth		= 260;
			cmb_printType.Splits[0].DisplayColumns["Code"].Width = 56;
			cmb_printType.Splits[0].DisplayColumns["Name"].Width = 220-25;//스크롤 방지
			cmb_printType.ExtendRightColumn = true; 
			cmb_printType.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

			// Disabled tbutton
			tbtn_Confirm.Enabled	= false;
			tbtn_Create.Enabled		= false;

			fgrid_main.Tree.Column = _ldLevCol;
		}
		
		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();
				this.cmb_factory.SelectedIndex		= 0; 
				this.txt_vendorCode.Text			= "";	
				this.txt_itemCd.Text				= "";
				this.txt_itemNm.Text				= "";
				this.txt_colorCd.Text				= "";
				this.txt_colorNm.Text				= "";

				tbtn_Save.Enabled		= true;
				tbtn_Delete.Enabled		= true;
				tbtn_Confirm.Enabled	= false;
				fgrid_main.AllowEditing	= true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					this.Cursor = Cursors.WaitCursor;

					fgrid_main.ClearAll();
					DataTable vTemp = SELECT_SQL_LAB_REQUEST_LIST();
					if (vTemp.Rows.Count > 0)
					{
						ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_main, vTemp, _ldLevCol-1);
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);

						for ( int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
						{
							if (fgrid_main[i, _ldLevCol].ToString() == "1")
								fgrid_main.Rows[i].StyleNew.BackColor	= ClassLib.ComVar.ClrLevel_1st; 
							else
								fgrid_main.Rows[i].StyleNew.BackColor	= Color.White; 

							if (fgrid_main[i, _ldStatusCol].ToString() == "C")
								fgrid_main.Rows[i].AllowEditing		= false; 
							else
								fgrid_main.Rows[i].AllowEditing		= true; 
						}

						fgrid_main.Tree.Column = _ldLevCol;
						fgrid_main.Tree.Show(rad_head.Checked ? 1 : 2);
						tbtn_Confirm.Enabled	= true;
					}
					else
					{
						fgrid_main.ClearAll();
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
					}				
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_PrintProcess()
		{
			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory, cmb_printType}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 

			if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
			{
				string sDir		= "";
				string sPara	= "";

				if (cmb_printType.SelectedValue.ToString() == "M")
				{
					string vReqNo	= ""; 
					int[] vSelectionRange = fgrid_main.Selections;
				
					if (vSelectionRange != null && vSelectionRange.Length > 0)
					{
						if ( vSelectionRange.Length < 2 )
						{
							vReqNo = "'" + fgrid_main[vSelectionRange[0], _ldReqNoCol].ToString() + "'";  
						}
						else
						{
							foreach (int i in vSelectionRange)
							{
								vReqNo += ",'" + fgrid_main[i, _ldReqNoCol].ToString() + "'"; 
							}
							vReqNo	= vReqNo.Substring(1, vReqNo.Length-1); 
						}

						sDir   = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_QC_Request");
						sPara  = " /rp ";
						sPara += "['" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"'] ";
						sPara += "[" + vReqNo +		"] ";
					}
					else
						return;
				}
				else if (cmb_printType.SelectedValue.ToString() == "L")
				{
					sDir   = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_QC_Request_List");
					sPara  = " /rp ";
					sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
					sPara += "'" + this.dpick_reqYmd.Text.Replace("-","") +		"' ";
					sPara += "'" + COM.ComFunction.Empty_Combo(cmb_vendor, "%") +		"' ";
					sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, "%") +	"' ";
					sPara += "'" + COM.ComFunction.Empty_TextBox(txt_colorCd, "%") +	"' ";
				}

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

				MyReport.Text = "Request sheet";
				MyReport.Show();			
			}
		}

		private void Tbtn_AfterSaveProcess()
		{
			try
			{				
				if (cmb_factory.SelectedIndex > -1)
				{
					for(int i = fgrid_main.Rows.Count - 1; i >= fgrid_main.Rows.Fixed; i--)
					{
						if(fgrid_main[i,0] == null || fgrid_main[i, 0].ToString() == "") continue; 
							

						if( fgrid_main[i, 0].ToString() == "D" || fgrid_main[i, 0].ToString() == "-D" )
						{ 
							fgrid_main.Rows.Remove(i);
						}
						else
						{
							fgrid_main[i, 0] = "";
						}
					}
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

		private void Tbtn_SaveProcess(bool arg_bool)
		{
			try
			{ 
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory};
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					DialogResult result = new DialogResult(); 
					
					if (arg_bool) 
					{	
						result = ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					}
					if ((!arg_bool) || result.ToString() == "Yes")
					{
						fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1); 

						for (int i= fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
						{
							// Summary Data(Lev = '1')는 SQL_LAB_REQUEST_REP에 저장
							if( fgrid_main[i, 0] != null && fgrid_main[i, 0].ToString() != "" && fgrid_main[i, _ldLevCol].ToString() == "2") 
							{
								fgrid_main[i, 0] =  "-" + fgrid_main[i, 0].ToString();	
							}
						}

						if (!MyOraDB.Save_FlexGird_Ready("PKG_SQL_LAB_REQUEST_REP.SAVE_SQL_LAB_REQUEST_REP_NEW", fgrid_main, true))
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}

						for (int i= fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
						{
							// Detail Data는 SQL_LAB_REQUEST에 저장
							if(fgrid_main[i, 0] != null && fgrid_main[i, 0].ToString() != "" && fgrid_main[i, _ldLevCol].ToString() == "2") 
								fgrid_main[i, 0] =  fgrid_main[i, 0].ToString().Substring(1,1);	
							else if(fgrid_main[i, 0] != null && fgrid_main[i, 0].ToString() != "" && fgrid_main[i, _ldLevCol].ToString() == "1") 
							{
									if (fgrid_main[i, 0].ToString() == "D")
										fgrid_main[i, 0] =  "-D";	
									else
										fgrid_main[i, 0] =  "";	
							}
						}

						if (!MyOraDB.Save_FlexGird_Ready("PKG_SQL_LAB_REQUEST.SAVE_SQL_LAB_REQUEST_NEW", fgrid_main, false))
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}

						// 저장 완료
						if (MyOraDB.Exe_Modify_Procedure_all())
						{
							Tbtn_AfterSaveProcess();
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
							tbtn_Confirm.Enabled	= true;
							this.Tbtn_SearchProcess();
						}
						else
							return;
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

		private void Tbtn_ConfirmProcess()
		{
			try
			{ 
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
					{
						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= 0 ; vRow--)
						{
							if (fgrid_main[vRow, 0] != null && fgrid_main[vRow, 0].ToString() != "")
							{
								Tbtn_SaveProcess(false); 
							}
						}		

						for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
						{				 
							fgrid_main[i,0] = ClassLib.ComVar.Update;;
							fgrid_main[i, _ldStatusCol] = "C";
							fgrid_main.Rows[i].AllowEditing	= false;
						}

						this.Tbtn_SaveProcess(false);
					
						_vConfirmYn				= true;
						tbtn_Save.Enabled		= false;
						tbtn_Delete.Enabled		= false;
						tbtn_Confirm.Enabled	= true; 
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
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you Cancel to Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
					{
						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= 0 ; vRow--)
						{
							if (fgrid_main[vRow, 0] != null && fgrid_main[vRow, 0].ToString() != "")
							{
								Tbtn_SaveProcess(false); 
							}
						}		

						for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
						{				 
							fgrid_main[i,0] = ClassLib.ComVar.Update;
							fgrid_main[i, _ldStatusCol]		= "S";
							fgrid_main.Rows[i].AllowEditing	= true;
						}

						this.Tbtn_SaveProcess(false);					
													
						_vConfirmYn				= false;
						tbtn_Save.Enabled		= true;
						tbtn_Delete.Enabled		= true;
						tbtn_Confirm.Enabled	= true;
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

		private void Tbtn_DeleteProcess()
		{
			try
			{ 
					fgrid_main.Delete_Row();
			}

			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

		private void Txt_VendorCodeTextChangedProcess()
		{
			try
			{
				_isAccessible = false;
				DataTable vDt = new DataTable();
				vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_vendorCode.Text.Trim());
				COM.ComCtl.Set_ComboList(vDt, cmb_vendor, 0, 1, true, 79, 141);

				if (vDt.Rows.Count > 0 && vDt.Rows.Count < 2)
					cmb_vendor.SelectedIndex = 1; 
				else if (vDt == null || vDt.Rows.Count <= 0) 
					cmb_vendor.SelectedIndex = 0; 

				vDt.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				_isAccessible = true;
			}
		}

		private void Cmb_VendorSelectedValueChangedProcess()
		{
			try
			{
				if (_isAccessible)
				{
					txt_vendorCode.Text			= cmb_vendor.SelectedValue.ToString();
					cmb_vendor.SelectedValue	= txt_vendorCode.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Apply_Grid : 그리드에 추가된 행 표시, 채산값 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_dt_tail"></param> 
		/// <param name="arg_row"></param>
		private void Apply_Grid(DataTable arg_dt)
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

//				fgrid_main.Display_Grid_Add(arg_dt, false); 
				ClassLib.ComFunction.Display_FlexGrid_Tree_Add(fgrid_main, arg_dt, _ldLevCol-1);

				if (fgrid_main.Rows.Count > 0 && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
				{
					// head Setting
					_practicable	= false;		
					if (fgrid_main[fgrid_main.Rows.Fixed, _ldFactoryCol].ToString().Trim() == "ALL")
						this.cmb_factory.SelectedIndex = 0; 
					else
						this.cmb_factory.SelectedValue	= fgrid_main[fgrid_main.Rows.Fixed, _ldFactoryCol].ToString().Trim();
					_practicable	= true;							

					// ReqNo Select 
					string vFactory		= COM.ComFunction.Empty_Combo(cmb_factory, "AL") == " " ? "AL" : COM.ComFunction.Empty_Combo(cmb_factory, "AL");
					string vDocDivision = ClassLib.ComVar.QC_REQUEST;
					string vDocType		= "00";
					string vDate		= System.DateTime.Today.ToString().Substring(0,10).Replace("-","");
					string vUser		= COM.ComVar.This_User;
						 
					DataTable vDt = SELECT_DOCUMENT_NO_QUALITY(vFactory, vDocDivision, vDocType, vDate, vUser);

					string vReqNo = vDt.Rows[0].ItemArray[0].ToString();
//					if(vReqNoSeq == "0000")
//					{
//						vReqNoSeq = vReqNo.Substring(12,4);
//					}
//					else
//					{
//						vReqNoSeq = (int.Parse(vReqNoSeq)+1).ToString().PadLeft(4,'0');
//					}
//
//					vReqNo = vReqNo.Substring(0,12) + vReqNoSeq;

					int vRow   = fgrid_main.Rows.Count - arg_dt.Rows.Count; 
					int vReqSeq = 0;

					for (int i= vRow; i < fgrid_main.Rows.Count; i++)
					{
						fgrid_main[i, 0] =  ClassLib.ComVar.Insert;	
						fgrid_main[i, _ldReqNoCol]  = vReqNo;
						fgrid_main[i, _ldReqSeqCol] = vReqSeq;
						fgrid_main[i, _ldReqYmdCol] = this.dpick_reqYmd.Text.Replace("-","");
						fgrid_main[i, _ldStatusCol] = "S";
						fgrid_main.Rows[i].AllowEditing	= true; 
						vReqSeq = vReqSeq +1;

						if (fgrid_main[i, _ldLevCol].ToString() == "1")
						{
							fgrid_main[i, _ldDirQtyCol]	= fgrid_main[i, _ldReqQtyCol].ToString(); 
							fgrid_main.Rows[i].StyleNew.BackColor	= ClassLib.ComVar.ClrLevel_1st; 
						}
						else
							fgrid_main.Rows[i].StyleNew.BackColor	= Color.White; 
					}
					fgrid_main.Tree.Show(rad_head.Checked ? 1 : 2);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);	

					_vConfirmYn				= false;
					tbtn_Save.Enabled		= true;
					tbtn_Delete.Enabled		= true;
					tbtn_Confirm.Enabled	= false;



					//

					if(int.Parse(inspQty) > 0)
					{
						fgrid_main[vRow, _ldReqQtyCol] = inspQty;
						inspQty = "0";
					}

					this.Tbtn_SaveProcess(false);
				}
				else
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		#endregion

		#region DB Connect
 		
	
		/// <summary>
		/// PKG_SBO_OUT_TAIL : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBO_OUT_TAIL : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SQL_LAB_REQUEST_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SQL_LAB_REQUEST.SELECT_SQL_LAB_REQUEST_LIST_N";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = this.dpick_reqYmd.Text.Replace("-","");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_vendor, "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_TextBox(txt_itemCd, "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_TextBox(txt_colorCd, "");
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		private DataTable SELECT_DOCUMENT_NO_QUALITY(string arg_factory, string arg_doc_division, string arg_doc_type, string agr_doc_date, string arg_upd_user)
		{
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_DOCUMENT_QC_REQ";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_DOC_DIVISION";
			MyOraDB.Parameter_Name[2] = "ARG_DOC_TYPE";
			MyOraDB.Parameter_Name[3] = "AGR_DOC_DATE";
			MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";
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
			MyOraDB.Parameter_Values[1] = arg_doc_division;
			MyOraDB.Parameter_Values[2] = arg_doc_type;
			MyOraDB.Parameter_Values[3] = agr_doc_date;
			MyOraDB.Parameter_Values[4] = arg_upd_user;
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

		private void dpick_reqYmd_CloseUp(object sender, System.EventArgs e)
		{
			string now_date = DateTime.Today.ToShortDateString();
			string set_date = dpick_reqYmd.Value.ToShortDateString();


			btn_shipping.Enabled = bool.Parse((now_date == set_date)?"true":"false");
		}

	}
}


