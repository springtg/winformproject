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
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Quality
{
	public class Form_QC_Lab_Test : COM.PCHWinForm.Form_Top
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
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cmb_factory;
		private C1.Win.C1List.C1Combo cmb_searchDiv;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.DateTimePicker dpick_shipFrom;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.DateTimePicker dpick_shipTo;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.Label lbl_searchDiv;
		private System.Windows.Forms.Label lbl_printType;
		private C1.Win.C1List.C1Combo cmb_printType;
		private System.Windows.Forms.ContextMenu cmenu_Qc_Test;
		private System.Windows.Forms.MenuItem menuitem_CopyResult;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB   = new COM.OraDB();
		private bool _vMenuClick	= false;
		
		private int	_vActiveCol		= 0;
		private int	_vActiveRow		= 0;
		private int _vCount			= 0;  // Target Rows Count

//		private int _lxUnitCol			= (int)ClassLib.TBSQL_LAB_TEST.IxUNIT;
//		private int _lxResultValueCol	= (int)ClassLib.TBSQL_LAB_TEST.IxRESULT_VALUE;
//		private int _lxResultSaltCol	= (int)ClassLib.TBSQL_LAB_TEST.IxRESULT_SALT;
//		private int _lxResultWaterCol	= (int)ClassLib.TBSQL_LAB_TEST.IxRESULT_WATER;
//		private int _lxSpecMinCol		= (int)ClassLib.TBSQL_LAB_TEST.IxSEPC_MIN;
//		private int _lxSpecMaxCol		= (int)ClassLib.TBSQL_LAB_TEST.IxSPEC_MAX;
//		private int _lxMethodCol		= (int)ClassLib.TBSQL_LAB_TEST.IxMETHOD;
//		private int _lxReqNoCol			= (int)ClassLib.TBSQL_LAB_TEST.IxREQ_NO;
//		private int _lxReqSeqCol		= (int)ClassLib.TBSQL_LAB_TEST.IxREQ_SEQ;
//		private int _lxRemarksCol		= (int)ClassLib.TBSQL_LAB_TEST.IxREMARKS;
//		private int _lxStatusCol		= (int)ClassLib.TBSQL_LAB_TEST.IxSTATUS;
//		private int _lxUpdUserCol		= (int)ClassLib.TBSQL_LAB_TEST.IxUPD_USER;
//		private int _lxUpdYmdCol		= (int)ClassLib.TBSQL_LAB_TEST.IxUPD_YMD;
//		private int _lxFactoryCol		= (int)ClassLib.TBSQL_LAB_TEST.IxFACTORY;
//		private int _lxLabNoCol			= (int)ClassLib.TBSQL_LAB_TEST.IxLAB_NO;
//		private int _lxLabSeqCol		= (int)ClassLib.TBSQL_LAB_TEST.IxLAB_SEQ;
//		private int _lxLabYmdCol		= (int)ClassLib.TBSQL_LAB_TEST.IxLAB_YMD;
//		private int _lxMcsNoCol			= (int)ClassLib.TBSQL_LAB_TEST.IxMCS_NO;
//		private int _lxLabCompCdCol		= (int)ClassLib.TBSQL_LAB_TEST.IxLAB_COMP_CD;
//		private int _lxTestCdCol		= (int)ClassLib.TBSQL_LAB_TEST.IxTEST_CD;
//		private int _lxTestNameCol		= (int)ClassLib.TBSQL_LAB_TEST.IxTEST_NAME;

		private int _ldReqNoCol			= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxREQ_NO;
		private int _ldReqSeqCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxREQ_SEQ;
		private int _ldStatusCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxSTATUS;
		private int _ldLabNoCol			= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxLAB_NO;
		private int _ldLabSeqCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxLAB_SEQ;
//		private int _ldFactoryCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxFACTORY;
//		private int _ldReqYmdCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxREQ_YMD;
//		private int _ldItemCdCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxITEM_CD;
//		private int _ldItemNameCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxITEM_NAME;
//		private int _ldSpecCdCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxSPEC_CD;
//		private int _ldSpecNameCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxSPEC_NAME;
//		private int _ldColorCdCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxCOLOR_CD;
//		private int _ldColorNameCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxCOLOR_NAME;
//		private int _ldUnitCol			= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxUNIT;
//		private int _ldStyleCdCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxSTYLE_CD;
//		private int _ldStyleNameCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxSTYLE_NAME;
//		private int _ldReqQtyCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxREQ_QTY;
//		private int _ldDefQtyCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxDEF_QTY;
//		private int _ldDefTypeCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxDEF_TYPE;
//		private int _ldResultCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxRESULT;
//		private int _ldCustCdCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxCUST_CD;
//		private int _ldCustNameCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxCUST_NAME;
//		private int _ldShipNoCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxSHIP_NO;
//		private int _ldShipSeqCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxSHIP_SEQ;
//		private int _ldShipYmdCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxSHIP_YMD;
//		private int _ldPurUserCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxPUR_USER;
//		private int _ldLotNoCol			= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxLOT_NO;
//		private int _ldLotSeqCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxLOT_SEQ;
//		private int _ldObsTypeCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxOBS_TYPE;
//		private int _ldUpdUserCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxUPD_USER;
//		private int _ldUpdYmdCol		= (int)ClassLib.TBSQL_LAB_REQ_LIST.IxUPD_YMD;
			
		#endregion

		#region 생성자 / 소멸자
		public Form_QC_Lab_Test()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QC_Lab_Test));
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
            this.lbl_printType = new System.Windows.Forms.Label();
            this.cmb_printType = new C1.Win.C1List.C1Combo();
            this.dpick_shipTo = new System.Windows.Forms.DateTimePicker();
            this.dpick_shipFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.cmb_searchDiv = new C1.Win.C1List.C1Combo();
            this.lbl_searchDiv = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.btn_invoice = new System.Windows.Forms.Label();
            this.btn_noShipping = new System.Windows.Forms.Label();
            this.btn_purchase = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmenu_Qc_Test = new System.Windows.Forms.ContextMenu();
            this.menuitem_CopyResult = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_searchDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
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
            this.c1Sizer1.GridDefinition = "13.8698630136986:False:True;84.0753424657534:False:False;\t0.393700787401575:False" +
                ":True;97.6377952755905:False:False;0.393700787401575:False:True;";
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
            this.fgrid_main.Size = new System.Drawing.Size(992, 491);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 173;
            this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.DoubleClick += new System.EventHandler(this.fgrid_main_DoubleClick);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.lbl_printType);
            this.pnl_head.Controls.Add(this.cmb_printType);
            this.pnl_head.Controls.Add(this.dpick_shipTo);
            this.pnl_head.Controls.Add(this.dpick_shipFrom);
            this.pnl_head.Controls.Add(this.lbl_shipDate);
            this.pnl_head.Controls.Add(this.cmb_searchDiv);
            this.pnl_head.Controls.Add(this.lbl_searchDiv);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.btn_invoice);
            this.pnl_head.Controls.Add(this.btn_noShipping);
            this.pnl_head.Controls.Add(this.btn_purchase);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 81);
            this.pnl_head.TabIndex = 1;
            // 
            // lbl_printType
            // 
            this.lbl_printType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_printType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_printType.ImageIndex = 0;
            this.lbl_printType.ImageList = this.img_Label;
            this.lbl_printType.Location = new System.Drawing.Point(384, 56);
            this.lbl_printType.Name = "lbl_printType";
            this.lbl_printType.Size = new System.Drawing.Size(100, 21);
            this.lbl_printType.TabIndex = 431;
            this.lbl_printType.Text = "Print Type";
            this.lbl_printType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_printType
            // 
            this.cmb_printType.AddItemCols = 0;
            this.cmb_printType.AddItemSeparator = ';';
            this.cmb_printType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_printType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_printType.Caption = "";
            this.cmb_printType.CaptionHeight = 17;
            this.cmb_printType.CaptionStyle = style1;
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
            this.cmb_printType.EvenRowStyle = style2;
            this.cmb_printType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_printType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_printType.FooterStyle = style3;
            this.cmb_printType.GapHeight = 2;
            this.cmb_printType.HeadingStyle = style4;
            this.cmb_printType.HighLightRowStyle = style5;
            this.cmb_printType.ItemHeight = 15;
            this.cmb_printType.Location = new System.Drawing.Point(486, 56);
            this.cmb_printType.MatchEntryTimeout = ((long)(2000));
            this.cmb_printType.MaxDropDownItems = ((short)(5));
            this.cmb_printType.MaxLength = 32767;
            this.cmb_printType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_printType.Name = "cmb_printType";
            this.cmb_printType.OddRowStyle = style6;
            this.cmb_printType.PartialRightColumn = false;
            this.cmb_printType.PropBag = resources.GetString("cmb_printType.PropBag");
            this.cmb_printType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_printType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_printType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_printType.SelectedStyle = style7;
            this.cmb_printType.Size = new System.Drawing.Size(220, 20);
            this.cmb_printType.Style = style8;
            this.cmb_printType.TabIndex = 430;
            // 
            // dpick_shipTo
            // 
            this.dpick_shipTo.CustomFormat = "";
            this.dpick_shipTo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_shipTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_shipTo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_shipTo.Location = new System.Drawing.Point(245, 56);
            this.dpick_shipTo.Name = "dpick_shipTo";
            this.dpick_shipTo.Size = new System.Drawing.Size(123, 21);
            this.dpick_shipTo.TabIndex = 428;
            // 
            // dpick_shipFrom
            // 
            this.dpick_shipFrom.CustomFormat = "";
            this.dpick_shipFrom.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_shipFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_shipFrom.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_shipFrom.Location = new System.Drawing.Point(109, 56);
            this.dpick_shipFrom.Name = "dpick_shipFrom";
            this.dpick_shipFrom.Size = new System.Drawing.Size(123, 21);
            this.dpick_shipFrom.TabIndex = 427;
            this.dpick_shipFrom.CloseUp += new System.EventHandler(this.dpick_shipFrom_CloseUp);
            // 
            // lbl_shipDate
            // 
            this.lbl_shipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipDate.ImageIndex = 1;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 56);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 426;
            this.lbl_shipDate.Text = "Lab Test Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_searchDiv
            // 
            this.cmb_searchDiv.AddItemCols = 0;
            this.cmb_searchDiv.AddItemSeparator = ';';
            this.cmb_searchDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_searchDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_searchDiv.Caption = "";
            this.cmb_searchDiv.CaptionHeight = 17;
            this.cmb_searchDiv.CaptionStyle = style9;
            this.cmb_searchDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_searchDiv.ColumnCaptionHeight = 18;
            this.cmb_searchDiv.ColumnFooterHeight = 18;
            this.cmb_searchDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_searchDiv.ContentHeight = 16;
            this.cmb_searchDiv.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_searchDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_searchDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_searchDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_searchDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_searchDiv.EditorHeight = 16;
            this.cmb_searchDiv.EvenRowStyle = style10;
            this.cmb_searchDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_searchDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_searchDiv.FooterStyle = style11;
            this.cmb_searchDiv.GapHeight = 2;
            this.cmb_searchDiv.HeadingStyle = style12;
            this.cmb_searchDiv.HighLightRowStyle = style13;
            this.cmb_searchDiv.ItemHeight = 15;
            this.cmb_searchDiv.Location = new System.Drawing.Point(486, 33);
            this.cmb_searchDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_searchDiv.MaxDropDownItems = ((short)(5));
            this.cmb_searchDiv.MaxLength = 32767;
            this.cmb_searchDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_searchDiv.Name = "cmb_searchDiv";
            this.cmb_searchDiv.OddRowStyle = style14;
            this.cmb_searchDiv.PartialRightColumn = false;
            this.cmb_searchDiv.PropBag = resources.GetString("cmb_searchDiv.PropBag");
            this.cmb_searchDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_searchDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_searchDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_searchDiv.SelectedStyle = style15;
            this.cmb_searchDiv.Size = new System.Drawing.Size(282, 20);
            this.cmb_searchDiv.Style = style16;
            this.cmb_searchDiv.TabIndex = 425;
            // 
            // lbl_searchDiv
            // 
            this.lbl_searchDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_searchDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchDiv.ImageIndex = 1;
            this.lbl_searchDiv.ImageList = this.img_Label;
            this.lbl_searchDiv.Location = new System.Drawing.Point(384, 33);
            this.lbl_searchDiv.Name = "lbl_searchDiv";
            this.lbl_searchDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_searchDiv.TabIndex = 424;
            this.lbl_searchDiv.Text = "Search Division";
            this.lbl_searchDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_factory.Location = new System.Drawing.Point(109, 33);
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
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 423;
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
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 65);
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
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 40);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 65);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 54);
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
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(234, 56);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(8, 16);
            this.lblexcep_mark.TabIndex = 387;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(133, 64);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmenu_Qc_Test
            // 
            this.cmenu_Qc_Test.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuitem_CopyResult});
            this.cmenu_Qc_Test.Popup += new System.EventHandler(this.cmenu_Qc_Test_Popup);
            // 
            // menuitem_CopyResult
            // 
            this.menuitem_CopyResult.Index = 0;
            this.menuitem_CopyResult.Text = "Copy Test Result";
            this.menuitem_CopyResult.Click += new System.EventHandler(this.menuitem_CopyResult_Click);
            // 
            // Form_QC_Lab_Test
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_QC_Lab_Test";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_QC_Lab_Test_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_searchDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
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

		private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
		{
			int vRow = fgrid_main.Selection.r1 ;

			if(vRow >= fgrid_main.Rows.Fixed)
				Grid_DoubleClickProcess(vRow);
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
			{
				_vActiveCol = fgrid_main.Cols[fgrid_main.Col].Index; 
				_vActiveRow = fgrid_main.Rows[fgrid_main.Row].Index; 
				Set_MenuItem_Visible();
				
				this.cmenu_Qc_Test.Show(fgrid_main, new Point(e.X, e.Y));
			}
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			if (_vMenuClick)  // Copy Result Menu Clicked
			{
				this.SelectSourceRows();
				_vMenuClick			= false;
			}
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

		private void Grid_DoubleClickProcess(int vRow)
		{
			try
			{
				Pop_QC_Result_List vPopup = new Pop_QC_Result_List();
			
				COM.ComVar.Parameter_PopUp		= new string[5];

				COM.ComVar.Parameter_PopUp[0]	= COM.ComFunction.Empty_Combo(cmb_factory, "");
				COM.ComVar.Parameter_PopUp[1]	= fgrid_main[vRow, _ldLabNoCol].ToString();
				COM.ComVar.Parameter_PopUp[2]	= fgrid_main[vRow, _ldLabSeqCol].ToString();
				COM.ComVar.Parameter_PopUp[3]	= fgrid_main[vRow, _ldReqNoCol].ToString();
				COM.ComVar.Parameter_PopUp[4]	= fgrid_main[vRow, _ldReqSeqCol].ToString();
			
				vPopup.ShowDialog();

				if (COM.ComVar.Parameter_PopUp != null)
				{
					fgrid_main[vRow, _ldLabNoCol]	= COM.ComVar.Parameter_PopUp[0].ToString(); 
					fgrid_main[vRow, _ldLabSeqCol]	= COM.ComVar.Parameter_PopUp[1].ToString(); 
					fgrid_main[vRow, _ldStatusCol]	= COM.ComVar.Parameter_PopUp[2].ToString(); 

					if (COM.ComVar.Parameter_PopUp[0] != null && COM.ComVar.Parameter_PopUp[0] != "")
						fgrid_main.Rows[vRow].StyleNew.BackColor	= Color.Gold; 
				}
			}
			catch (Exception ex)
			{
				COM.ComFunction.User_Message(ex.Message, "Grid_DoubleClickProcess");
			}
		}

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

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
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

		private void Form_QC_Lab_Test_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}

		private void dpick_shipFrom_CloseUp(object sender, System.EventArgs e)
		{
			string vCurDate	= dpick_shipFrom.Text.Replace("-",""); 
			DataTable vDt1  = ClassLib.ComFunction.Get_WeekDay(vCurDate, "+", "7");  // 해당일의 후 토요일
			dpick_shipTo.Value		= ClassLib.ComFunction.StringToDateTime(vDt1.Rows[0][0].ToString());
			vDt1.Dispose(); 
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

		private void cmenu_Qc_Test_Popup(object sender, System.EventArgs e)
		{
			try
			{
				//				int vCol = _mainSheet.ActiveColumnIndex;
				// 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Qc_Test_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

  		
		/// <summary>
		/// Set_MenuItem_Visible : 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
		/// </summary>
		private void Set_MenuItem_Visible()
		{
//			if (!fgrid_main.AllowEditing || !fgrid_main.Rows[_vActiveRow].AllowEditing) 
//			{
//				this.menuitem_CopyResult.Visible		= false;
//			}
//			else
//			{
				this.menuitem_CopyResult.Visible		= true;
//			}
		}
 
		private void menuitem_CopyResult_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				int[] vSelectionRange_T = fgrid_main.Selections;

				if (vSelectionRange_T != null)
				{
					foreach (int i in vSelectionRange_T)
					{
						if (fgrid_main[i, _ldLabNoCol] == null || fgrid_main[i, _ldLabNoCol].ToString() == "")
						{
							fgrid_main[i, 0]	= "S";  
							_vCount	+= 1; 
						}
					}							
				}
				if (_vCount < 1)
					return; 
				
				_vMenuClick	= true;

				ClassLib.ComFunction.User_Message("Select Source Row. Just One Selection", "Copy Test Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
//				ClassLib.ComFunction.User_Message("Select Target Rows. Enable Multy Selection", "Copy Test Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_CopyResult_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void SelectSourceRows()
		{
			try
			{
				int[] vSelectionRange_S = fgrid_main.Selections;

				if (vSelectionRange_S != null)
				{
					int	vRow = vSelectionRange_S[0]; 
					string vLabNo	= fgrid_main[vRow, _ldLabNoCol].ToString(); 
					string vLabSeq	= fgrid_main[vRow, _ldLabSeqCol].ToString();

					if (vLabNo != null && vLabNo != "")
						this.CopyResult(vLabNo, vLabSeq);
					else
						ClassLib.ComFunction.User_Message("Not Exist Test Result Data of Select Source Row", "menuitem_CopyResult_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Qc_Test_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void CopyResult(string vLabNo, string vLabSeq)
		{
			try
			{
				// LAB Test Date Select PopUp Show
				FlexPurchase.Outgoing.Pop_BO_Outgoing_RealYmd_Exchanger vPopup = new FlexPurchase.Outgoing.Pop_BO_Outgoing_RealYmd_Exchanger();
			
				COM.ComVar.Parameter_PopUp		= new string[2];

				COM.ComVar.Parameter_PopUp[0]	= "Select LAB Test Date";
				COM.ComVar.Parameter_PopUp[1]	= "Lab Test Ymd";

				vPopup.ShowDialog();

				if(COM.ComVar.Parameter_PopUp[0] == null || COM.ComVar.Parameter_PopUp[0].ToString() == "") return;
				
				string vLabYmd	= COM.ComVar.Parameter_PopUp[0].ToString();

				vPopup.Dispose();

				if (COPY_LAB_TEST_RESULT(vLabNo, vLabSeq, vLabYmd))
				{
					ClassLib.ComFunction.User_Message("Completed Copy LAB Test Result", "Copy_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}	
				_vCount	= 0; 
				
				for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
				{
					fgrid_main[i, 0]	= ""; 
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Qc_Test_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            lbl_MainTitle.Text = "LAB Results";
            this.Text = "LAB Results";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			fgrid_main.Set_Grid("SQL_LAB_REQ_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			//			cmb_factory.SelectedIndex = 0;
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
	
			// secarh type Set  cmb_searchDiv
			cmb_searchDiv.AddItemTitles("Code;Name");
			cmb_searchDiv.ValueMember		= "Code";
			cmb_searchDiv.DisplayMember		= "Name";
			cmb_searchDiv.AddItem("A;ALL");
			cmb_searchDiv.AddItem("R;Request");
			cmb_searchDiv.AddItem("T;LAB Test");
			cmb_searchDiv.SelectedValue = "A";  
			cmb_searchDiv.ExtendRightColumn = true; 
			cmb_searchDiv.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

			// Print type Set  cmb_printType
			cmb_printType.AddItemTitles("Code;Name");
			cmb_printType.ValueMember		= "Code";
			cmb_printType.DisplayMember		= "Name";
			cmb_printType.AddItem("M;Physical Lab Test");
			cmb_printType.AddItem("L;LAB Test List");
			cmb_printType.SelectedValue = "M";  
			cmb_printType.DropDownWidth		= 260;
			cmb_printType.Splits[0].DisplayColumns["Code"].Width = 56;
			cmb_printType.Splits[0].DisplayColumns["Name"].Width = 220-25;//스크롤 방지
			cmb_printType.ExtendRightColumn = true; 
			cmb_printType.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

			string vCurDate	= System.DateTime.Today.ToString().Substring(0,10).Replace("-",""); 
			vDt				= ClassLib.ComFunction.Get_WeekDay(vCurDate, "-", "2");  // 해당일의 전 월요일
			DataTable vDt1  = ClassLib.ComFunction.Get_WeekDay(vCurDate, "+", "7");  // 해당일의 후 토요일 (MAX SYSDATE)
			dpick_shipFrom.Value	= ClassLib.ComFunction.StringToDateTime(vDt.Rows[0][0].ToString()); 
			dpick_shipTo.Value		= ClassLib.ComFunction.StringToDateTime(vDt1.Rows[0][0].ToString());
			vDt.Dispose();
			vDt1.Dispose();

			// Disabled tbutton
			tbtn_Delete.Enabled		= false;
			tbtn_Save.Enabled		= false;
			tbtn_Create.Enabled		= false;
		}
		
		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();

				this.cmb_searchDiv.SelectedIndex	= -1; 

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

				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory, cmb_searchDiv}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					this.Cursor = Cursors.WaitCursor;

					DataTable vTemp = SELECT_SQL_LAB_TEST_LIST();
					if (vTemp.Rows.Count > 0)
					{
						ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_main, vTemp);
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);

						for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
						{
							if (fgrid_main[i, _ldLabNoCol] != null && fgrid_main[i, _ldLabNoCol].ToString() != "")
								fgrid_main.Rows[i].StyleNew.BackColor	= Color.Gold; 
						}
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
					string vLabNo	= ""; 
					int[] vSelectionRange = fgrid_main.Selections;
				
					if (vSelectionRange != null && vSelectionRange.Length > 0)
					{
						if ( vSelectionRange.Length < 2 )
						{
							vLabNo = "'" + fgrid_main[vSelectionRange[0], _ldLabNoCol].ToString() + "'";  
						}
						else
						{
							foreach (int i in vSelectionRange)
							{
								vLabNo += ",'" + fgrid_main[i, _ldLabNoCol].ToString() + "'"; 
							}
							vLabNo	= vLabNo.Substring(1, vLabNo.Length-1); 
						}

						sDir   = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_QC_Lab_Test");
						sPara  = " /rp ";
						sPara += "['" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"'] ";
						sPara += "[" + vLabNo +		"] ";
					}
					else
						return;
				}
				else if (cmb_printType.SelectedValue.ToString() == "L")
				{
					sDir   = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_QC_Lab_Test_List");
					sPara  = " /rp ";
					sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
					sPara += "'" + this.dpick_shipFrom.Text.Replace("-","") +		"' ";
					sPara += "'" + this.dpick_shipTo.Text.Replace("-","") +		"' ";
					sPara += "'" + COM.ComFunction.Empty_Combo(cmb_searchDiv, "%") +		"' ";
				}

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

				MyReport.Text = "Lab Test sheet";
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
							

						if( fgrid_main[i, 0].ToString() == "D" )
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
						if (MyOraDB.Save_FlexGird("PKG_SQL_LAB_TEST_HEAD.UPDATE_SQL_LAB_TEST_HEAD", fgrid_main))
						{
							Tbtn_AfterSaveProcess();
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
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
						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
						{
							if (fgrid_main[vRow, 0] != null && fgrid_main[vRow, 0].ToString() != "")
							{
								Tbtn_SaveProcess(false); 
							}
						}	

						int[] vSelectionRange = fgrid_main.Selections;
				
						if (vSelectionRange != null)
						{
							foreach (int i in vSelectionRange)
							{
								if ( fgrid_main[i, _ldLabNoCol] != null && fgrid_main[i, _ldLabNoCol].ToString() != "")
								{
									fgrid_main[i,0] = ClassLib.ComVar.Update;
									fgrid_main[i, _ldStatusCol] = "C";
								}
							}

							this.Tbtn_SaveProcess(false);
						}
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
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
		public DataTable SELECT_SQL_LAB_TEST_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SQL_LAB_TEST_TAIL.SELECT_SQL_LAB_TEST_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TO";
			MyOraDB.Parameter_Name[3] = "ARG_DIV";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = this.dpick_shipFrom.Text.Replace("-","");
			MyOraDB.Parameter_Values[2] = this.dpick_shipTo.Text.Replace("-","");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_searchDiv, "");
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		public bool COPY_LAB_TEST_RESULT(string arg_source_lab_no, string arg_source_lab_seq, string arg_lab_ymd)
		{
			try
			{
				MyOraDB.ReDim_Parameter(9);

				//01.PROCEDURE명
				MyOraDB.Process_Name    = "PKG_SQL_LAB_TEST_HEAD.COPY_LAB_TEST_RESULT";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LAB_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_LAB_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LAB_SEQ";
				MyOraDB.Parameter_Name[4] = "ARG_SOURCE_LAB_NO";
				MyOraDB.Parameter_Name[5] = "ARG_SOURCE_LAB_SEQ";
				MyOraDB.Parameter_Name[6] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[7] = "ARG_REQ_SEQ";
				MyOraDB.Parameter_Name[8] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;

				MyOraDB.Parameter_Values   = new string[_vCount * 9 ];
				int		vRow = 0; 	

				//04.DATA 정의
				for( int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
				{ 
					if (fgrid_main[i, 0] != null && fgrid_main[i, 0].ToString() == "S")  // Copy Source Row이면
					{
						// LabNo Select 
						string vFactory		= COM.ComFunction.Empty_Combo(cmb_factory, "");
						string vDocDivision = ClassLib.ComVar.QC_TEST;
						string vDocType		= "00";
						string vDate		= System.DateTime.Today.ToString().Substring(0,10).Replace("-","");
						string vUser		= COM.ComVar.This_User;
						 
						DataTable vDt = ClassLib.ComFunction.SELECT_DOCUMENT_NO(vFactory, vDocDivision, vDocType, vDate, vUser);

						string vLabNo  = vDt.Rows[0].ItemArray[0].ToString().Trim();
						int vLabSeq	   = int.Parse(vLabNo.Substring(12,4));

						MyOraDB.Parameter_Values[vRow*9]	 = COM.ComFunction.Empty_Combo(cmb_factory, "");
						MyOraDB.Parameter_Values[vRow*9+1]	 = arg_lab_ymd;							           
						MyOraDB.Parameter_Values[vRow*9+2]	 = vLabNo;
						MyOraDB.Parameter_Values[vRow*9+3]	 = vLabSeq.ToString(); 
						MyOraDB.Parameter_Values[vRow*9+4]	 = arg_source_lab_no;  
						MyOraDB.Parameter_Values[vRow*9+5]	 = arg_source_lab_seq;
						MyOraDB.Parameter_Values[vRow*9+6]	 = fgrid_main[i, _ldReqNoCol].ToString();
						MyOraDB.Parameter_Values[vRow*9+7]	 = fgrid_main[i, _ldReqSeqCol].ToString();
						MyOraDB.Parameter_Values[vRow*9+8]	 = COM.ComVar.This_User;

						vRow += 1; 
					}
				}

				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_Spread",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}

		#endregion

	
	}
}


