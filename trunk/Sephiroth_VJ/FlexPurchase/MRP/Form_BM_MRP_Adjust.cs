using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using FlexMRP.ClassLib;

namespace FlexMRP.MRP
{
	public class Form_BM_MRP_Adjust : COM.PCHWinForm.Form_Top, IOperation
	{
		#region 디자이너에서 생성한 멤버

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label lbl_shipType;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_findData;
		private System.Windows.Forms.Label lbl_mrpno;
		private C1.Win.C1List.C1Combo cmb_mrpno;
		private C1.Win.C1List.C1Combo cmb_itemDiv;
		private System.Windows.Forms.Label lbl_itemDiv;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnu_ceiling;
		private System.Windows.Forms.MenuItem mnu_truncate;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem mnu_rounding;
		private System.Windows.Forms.MenuItem mnu_allSelect;
		private System.Windows.Forms.MenuItem mnu_pk;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnu_header;
		private System.Windows.Forms.MenuItem mnu_all;
		private System.Windows.Forms.MenuItem mnu_value;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label btn_Recover;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.Label btn_RunProcess;
		private System.Windows.Forms.MenuItem mnu_usageCheck;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버

		private string _process		= (int)ClassLib.ComVar.MRPProcessNum.MRPAdjust + "";
		private Pop_Finder finder;
		private COM.OraDB MyOraDB	= new COM.OraDB();
		private Pop_BM_Shipping_Wait _pop;
		private const int _mnu_value = 10;
		private const int _insert = 100, _delete = 110;

		private int _mrpShipNoCol	= (int)TBSBM_MRP_ADJUST.IxMRP_SHIP_NO;
		private int _lotInfoCol		= (int)TBSBM_MRP_ADJUST.IxITEM_NAME;
		private int _styleCodeCol	= (int)TBSBM_MRP_ADJUST.IxSPEC_NAME;
		private int _styleNameCol	= (int)TBSBM_MRP_ADJUST.IxCOLOR_NAME;
		private int _unitCol		= (int)TBSBM_MRP_ADJUST.IxUNIT;
		private int _itemCodeCol	= (int)TBSBM_MRP_ADJUST.IxITEM_CD;
		private int _specCodeCol	= (int)TBSBM_MRP_ADJUST.IxSPEC_CD;
		private int _colorCodeCol	= (int)TBSBM_MRP_ADJUST.IxCOLOR_CD;
		private int _itemNameCol	= (int)TBSBM_MRP_ADJUST.IxITEM_NAME;
		private int _specNameCol	= (int)TBSBM_MRP_ADJUST.IxSPEC_NAME;
		private int _colorNameCol	= (int)TBSBM_MRP_ADJUST.IxCOLOR_NAME;
		private int _confirmQtyCol	= (int)TBSBM_MRP_ADJUST.IxCONFIRM_QTY;
		private int _adviceQtyCol	= (int)TBSBM_MRP_ADJUST.IxADVICE_QTY;
		private int _pkQtyCol		= (int)TBSBM_MRP_ADJUST.IxPK_QTY;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private int _shipYnCol		= (int)TBSBM_MRP_ADJUST.IxSHIP_YN;
		private System.Windows.Forms.Label lbl_groupCd;
		private C1.Win.C1List.C1Combo cmb_moveType;
		private System.Windows.Forms.Label lbl_moveType;

		private string _itemGroupCode	= "";


        private Thread tRun = null;
        delegate void DelegateSetn(); // 대리자 선언     


		#endregion

		#region 생성자 / 소멸자

		public Form_BM_MRP_Adjust()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BM_MRP_Adjust));
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
            C1.Win.C1List.Style style65 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style66 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style67 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style68 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style69 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style70 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style71 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style72 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style73 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style74 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style75 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style76 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style77 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style78 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style79 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style80 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style81 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style82 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style83 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style84 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style85 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style86 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style87 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style88 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style89 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style90 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style91 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style92 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style93 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style94 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style95 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style96 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Recover = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.fgrid_main = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_moveType = new C1.Win.C1List.C1Combo();
            this.lbl_moveType = new System.Windows.Forms.Label();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_groupCd = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_RunProcess = new System.Windows.Forms.Label();
            this.cmb_itemDiv = new C1.Win.C1List.C1Combo();
            this.lbl_itemDiv = new System.Windows.Forms.Label();
            this.lbl_mrpno = new System.Windows.Forms.Label();
            this.cmb_mrpno = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.ctx_main = new System.Windows.Forms.ContextMenu();
            this.mnu_findData = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mnu_allSelect = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnu_value = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnu_ceiling = new System.Windows.Forms.MenuItem();
            this.mnu_rounding = new System.Windows.Forms.MenuItem();
            this.mnu_truncate = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_pk = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnu_header = new System.Windows.Forms.MenuItem();
            this.mnu_all = new System.Windows.Forms.MenuItem();
            this.mnu_usageCheck = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_moveType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_mrpno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.panel3);
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Recover);
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Insert);
            this.panel3.Location = new System.Drawing.Point(8, 538);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 30);
            this.panel3.TabIndex = 53;
            // 
            // btn_Recover
            // 
            this.btn_Recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Recover.ImageIndex = 1;
            this.btn_Recover.ImageList = this.image_List;
            this.btn_Recover.Location = new System.Drawing.Point(919, 4);
            this.btn_Recover.Name = "btn_Recover";
            this.btn_Recover.Size = new System.Drawing.Size(80, 23);
            this.btn_Recover.TabIndex = 51;
            this.btn_Recover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Recover.Click += new System.EventHandler(this.btn_Recover_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Delete.ImageIndex = 5;
            this.btn_Delete.ImageList = this.image_List;
            this.btn_Delete.Location = new System.Drawing.Point(837, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 23);
            this.btn_Delete.TabIndex = 49;
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(755, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 23);
            this.btn_Insert.TabIndex = 48;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(8, 118);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
            this.fgrid_main.Size = new System.Drawing.Size(1000, 416);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 3;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            this.fgrid_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyUp);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_moveType);
            this.pnl_head.Controls.Add(this.lbl_moveType);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_groupCd);
            this.pnl_head.Controls.Add(this.txt_status);
            this.pnl_head.Controls.Add(this.lbl_status);
            this.pnl_head.Controls.Add(this.btn_RunProcess);
            this.pnl_head.Controls.Add(this.cmb_itemDiv);
            this.pnl_head.Controls.Add(this.lbl_itemDiv);
            this.pnl_head.Controls.Add(this.lbl_mrpno);
            this.pnl_head.Controls.Add(this.cmb_mrpno);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 114);
            this.pnl_head.TabIndex = 2;
            // 
            // cmb_moveType
            // 
            this.cmb_moveType.AddItemCols = 0;
            this.cmb_moveType.AddItemSeparator = ';';
            this.cmb_moveType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_moveType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_moveType.Caption = "";
            this.cmb_moveType.CaptionHeight = 17;
            this.cmb_moveType.CaptionStyle = style49;
            this.cmb_moveType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_moveType.ColumnCaptionHeight = 18;
            this.cmb_moveType.ColumnFooterHeight = 18;
            this.cmb_moveType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_moveType.ContentHeight = 16;
            this.cmb_moveType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_moveType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_moveType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_moveType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_moveType.EditorHeight = 16;
            this.cmb_moveType.EvenRowStyle = style50;
            this.cmb_moveType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_moveType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_moveType.FooterStyle = style51;
            this.cmb_moveType.GapHeight = 2;
            this.cmb_moveType.HeadingStyle = style52;
            this.cmb_moveType.HighLightRowStyle = style53;
            this.cmb_moveType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_moveType.ItemHeight = 15;
            this.cmb_moveType.Location = new System.Drawing.Point(109, 84);
            this.cmb_moveType.MatchEntryTimeout = ((long)(2000));
            this.cmb_moveType.MaxDropDownItems = ((short)(5));
            this.cmb_moveType.MaxLength = 32767;
            this.cmb_moveType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_moveType.Name = "cmb_moveType";
            this.cmb_moveType.OddRowStyle = style54;
            this.cmb_moveType.PartialRightColumn = false;
            this.cmb_moveType.PropBag = resources.GetString("cmb_moveType.PropBag");
            this.cmb_moveType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_moveType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_moveType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_moveType.SelectedStyle = style55;
            this.cmb_moveType.Size = new System.Drawing.Size(210, 20);
            this.cmb_moveType.Style = style56;
            this.cmb_moveType.TabIndex = 5;
            // 
            // lbl_moveType
            // 
            this.lbl_moveType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_moveType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moveType.ImageIndex = 0;
            this.lbl_moveType.ImageList = this.img_Label;
            this.lbl_moveType.Location = new System.Drawing.Point(8, 84);
            this.lbl_moveType.Name = "lbl_moveType";
            this.lbl_moveType.Size = new System.Drawing.Size(100, 21);
            this.lbl_moveType.TabIndex = 50;
            this.lbl_moveType.Text = "Transfer Type";
            this.lbl_moveType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(870, 62);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(73, 21);
            this.txt_itemGroup.TabIndex = 412;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style57;
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
            this.cmb_itemGroup.EvenRowStyle = style58;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style59;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style60;
            this.cmb_itemGroup.HighLightRowStyle = style61;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(754, 62);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style62;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style63;
            this.cmb_itemGroup.Size = new System.Drawing.Size(115, 20);
            this.cmb_itemGroup.Style = style64;
            this.cmb_itemGroup.TabIndex = 411;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(944, 62);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(21, 21);
            this.btn_groupSearch.TabIndex = 410;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // lbl_groupCd
            // 
            this.lbl_groupCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_groupCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_groupCd.ImageIndex = 0;
            this.lbl_groupCd.ImageList = this.img_Label;
            this.lbl_groupCd.Location = new System.Drawing.Point(653, 62);
            this.lbl_groupCd.Name = "lbl_groupCd";
            this.lbl_groupCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_groupCd.TabIndex = 409;
            this.lbl_groupCd.Text = "Item Group";
            this.lbl_groupCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_status.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_status.Location = new System.Drawing.Point(754, 40);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(210, 21);
            this.txt_status.TabIndex = 405;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ImageIndex = 0;
            this.lbl_status.ImageList = this.img_Label;
            this.lbl_status.Location = new System.Drawing.Point(653, 40);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_status.TabIndex = 404;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_RunProcess
            // 
            this.btn_RunProcess.ImageIndex = 0;
            this.btn_RunProcess.ImageList = this.img_Button;
            this.btn_RunProcess.Location = new System.Drawing.Point(885, 84);
            this.btn_RunProcess.Name = "btn_RunProcess";
            this.btn_RunProcess.Size = new System.Drawing.Size(80, 23);
            this.btn_RunProcess.TabIndex = 403;
            this.btn_RunProcess.Text = "Run";
            this.btn_RunProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_RunProcess.Click += new System.EventHandler(this.lbl_RunProcess_Click);
            this.btn_RunProcess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_RunProcess_MouseDown);
            this.btn_RunProcess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_RunProcess_MouseUp);
            // 
            // cmb_itemDiv
            // 
            this.cmb_itemDiv.AddItemCols = 0;
            this.cmb_itemDiv.AddItemSeparator = ';';
            this.cmb_itemDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemDiv.Caption = "";
            this.cmb_itemDiv.CaptionHeight = 17;
            this.cmb_itemDiv.CaptionStyle = style65;
            this.cmb_itemDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_itemDiv.ColumnCaptionHeight = 18;
            this.cmb_itemDiv.ColumnFooterHeight = 18;
            this.cmb_itemDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_itemDiv.ContentHeight = 16;
            this.cmb_itemDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_itemDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_itemDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_itemDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_itemDiv.EditorHeight = 16;
            this.cmb_itemDiv.EvenRowStyle = style66;
            this.cmb_itemDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemDiv.FooterStyle = style67;
            this.cmb_itemDiv.GapHeight = 2;
            this.cmb_itemDiv.HeadingStyle = style68;
            this.cmb_itemDiv.HighLightRowStyle = style69;
            this.cmb_itemDiv.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_itemDiv.ItemHeight = 15;
            this.cmb_itemDiv.Location = new System.Drawing.Point(431, 62);
            this.cmb_itemDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemDiv.MaxDropDownItems = ((short)(5));
            this.cmb_itemDiv.MaxLength = 32767;
            this.cmb_itemDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemDiv.Name = "cmb_itemDiv";
            this.cmb_itemDiv.OddRowStyle = style70;
            this.cmb_itemDiv.PartialRightColumn = false;
            this.cmb_itemDiv.PropBag = resources.GetString("cmb_itemDiv.PropBag");
            this.cmb_itemDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemDiv.SelectedStyle = style71;
            this.cmb_itemDiv.Size = new System.Drawing.Size(210, 20);
            this.cmb_itemDiv.Style = style72;
            this.cmb_itemDiv.TabIndex = 5;
            this.cmb_itemDiv.SelectedValueChanged += new System.EventHandler(this.cmb_itemDiv_SelectedValueChanged);
            // 
            // lbl_itemDiv
            // 
            this.lbl_itemDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemDiv.ImageIndex = 0;
            this.lbl_itemDiv.ImageList = this.img_Label;
            this.lbl_itemDiv.Location = new System.Drawing.Point(330, 62);
            this.lbl_itemDiv.Name = "lbl_itemDiv";
            this.lbl_itemDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemDiv.TabIndex = 50;
            this.lbl_itemDiv.Text = "Item Division";
            this.lbl_itemDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mrpno
            // 
            this.lbl_mrpno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_mrpno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mrpno.ImageIndex = 1;
            this.lbl_mrpno.ImageList = this.img_Label;
            this.lbl_mrpno.Location = new System.Drawing.Point(8, 62);
            this.lbl_mrpno.Name = "lbl_mrpno";
            this.lbl_mrpno.Size = new System.Drawing.Size(100, 21);
            this.lbl_mrpno.TabIndex = 50;
            this.lbl_mrpno.Text = "MRP Ship No";
            this.lbl_mrpno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_mrpno
            // 
            this.cmb_mrpno.AddItemCols = 0;
            this.cmb_mrpno.AddItemSeparator = ';';
            this.cmb_mrpno.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_mrpno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_mrpno.Caption = "";
            this.cmb_mrpno.CaptionHeight = 17;
            this.cmb_mrpno.CaptionStyle = style73;
            this.cmb_mrpno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_mrpno.ColumnCaptionHeight = 18;
            this.cmb_mrpno.ColumnFooterHeight = 18;
            this.cmb_mrpno.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_mrpno.ContentHeight = 16;
            this.cmb_mrpno.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_mrpno.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_mrpno.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_mrpno.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_mrpno.EditorHeight = 16;
            this.cmb_mrpno.EvenRowStyle = style74;
            this.cmb_mrpno.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_mrpno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mrpno.FooterStyle = style75;
            this.cmb_mrpno.GapHeight = 2;
            this.cmb_mrpno.HeadingStyle = style76;
            this.cmb_mrpno.HighLightRowStyle = style77;
            this.cmb_mrpno.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_mrpno.ItemHeight = 15;
            this.cmb_mrpno.Location = new System.Drawing.Point(109, 62);
            this.cmb_mrpno.MatchEntryTimeout = ((long)(2000));
            this.cmb_mrpno.MaxDropDownItems = ((short)(5));
            this.cmb_mrpno.MaxLength = 32767;
            this.cmb_mrpno.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_mrpno.Name = "cmb_mrpno";
            this.cmb_mrpno.OddRowStyle = style78;
            this.cmb_mrpno.PartialRightColumn = false;
            this.cmb_mrpno.PropBag = resources.GetString("cmb_mrpno.PropBag");
            this.cmb_mrpno.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_mrpno.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_mrpno.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_mrpno.SelectedStyle = style79;
            this.cmb_mrpno.Size = new System.Drawing.Size(210, 20);
            this.cmb_mrpno.Style = style80;
            this.cmb_mrpno.TabIndex = 5;
            this.cmb_mrpno.SelectedValueChanged += new System.EventHandler(this.cmb_mrpno_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 393;
            this.label2.Text = "      MRP Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemCols = 0;
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style81;
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
            this.cmb_shipType.EvenRowStyle = style82;
            this.cmb_shipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style83;
            this.cmb_shipType.GapHeight = 2;
            this.cmb_shipType.HeadingStyle = style84;
            this.cmb_shipType.HighLightRowStyle = style85;
            this.cmb_shipType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(431, 40);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style86;
            this.cmb_shipType.PartialRightColumn = false;
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style87;
            this.cmb_shipType.Size = new System.Drawing.Size(210, 20);
            this.cmb_shipType.Style = style88;
            this.cmb_shipType.TabIndex = 5;
            this.cmb_shipType.SelectedValueChanged += new System.EventHandler(this.cmb_shipType_SelectedValueChanged);
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 0;
            this.lbl_shipType.ImageList = this.img_Label;
            this.lbl_shipType.Location = new System.Drawing.Point(330, 40);
            this.lbl_shipType.Name = "lbl_shipType";
            this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipType.TabIndex = 50;
            this.lbl_shipType.Text = "Ship Type";
            this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 97);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style89;
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
            this.cmb_factory.EvenRowStyle = style90;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style91;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style92;
            this.cmb_factory.HighLightRowStyle = style93;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style94;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style95;
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style96;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
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
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 96);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(160, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(920, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // ctx_main
            // 
            this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_findData,
            this.menuItem9,
            this.mnu_allSelect,
            this.menuItem5,
            this.mnu_value,
            this.menuItem10,
            this.menuItem2,
            this.menuItem3,
            this.mnu_usageCheck});
            // 
            // mnu_findData
            // 
            this.mnu_findData.Index = 0;
            this.mnu_findData.Text = "Find Data";
            this.mnu_findData.Click += new System.EventHandler(this.mnu_findData_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.Text = "-";
            // 
            // mnu_allSelect
            // 
            this.mnu_allSelect.Index = 2;
            this.mnu_allSelect.Text = "All Select";
            this.mnu_allSelect.Click += new System.EventHandler(this.mnu_allSelect_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "-";
            // 
            // mnu_value
            // 
            this.mnu_value.Index = 4;
            this.mnu_value.Text = "Value Change";
            this.mnu_value.Click += new System.EventHandler(this.mnu_value_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 5;
            this.menuItem10.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 6;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_ceiling,
            this.mnu_rounding,
            this.mnu_truncate,
            this.menuItem1,
            this.mnu_pk});
            this.menuItem2.Text = "Auto Calculation";
            // 
            // mnu_ceiling
            // 
            this.mnu_ceiling.Index = 0;
            this.mnu_ceiling.Text = "Ceiling";
            this.mnu_ceiling.Click += new System.EventHandler(this.mnu_ceiling_Click);
            // 
            // mnu_rounding
            // 
            this.mnu_rounding.Index = 1;
            this.mnu_rounding.Text = "Rounding";
            this.mnu_rounding.Click += new System.EventHandler(this.mnu_roundUp_Click);
            // 
            // mnu_truncate
            // 
            this.mnu_truncate.Index = 2;
            this.mnu_truncate.Text = "Truncate";
            this.mnu_truncate.Click += new System.EventHandler(this.mnu_truncate_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.Text = "-";
            // 
            // mnu_pk
            // 
            this.mnu_pk.Index = 4;
            this.mnu_pk.Text = "PK Unit Qty";
            this.mnu_pk.Click += new System.EventHandler(this.mnu_pk_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 7;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_header,
            this.mnu_all});
            this.menuItem3.Text = "Tree View Option";
            // 
            // mnu_header
            // 
            this.mnu_header.Index = 0;
            this.mnu_header.Text = "Header";
            this.mnu_header.Click += new System.EventHandler(this.mnu_header_Click);
            // 
            // mnu_all
            // 
            this.mnu_all.Index = 1;
            this.mnu_all.Text = "All";
            this.mnu_all.Click += new System.EventHandler(this.mnu_all_Click);
            // 
            // mnu_usageCheck
            // 
            this.mnu_usageCheck.Index = 8;
            this.mnu_usageCheck.Text = "Usage Check";
            this.mnu_usageCheck.Click += new System.EventHandler(this.mnu_usageCheck_Click);
            // 
            // Form_BM_MRP_Adjust
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BM_MRP_Adjust";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_moveType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_mrpno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
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

		private void fgrid_main_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
			{
				finder = new Pop_Finder(fgrid_main, 1, fgrid_main.Cols.Frozen - 1);
				finder.Show();
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
         

                if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
                    if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tRun = new Thread(new ThreadStart(RunSave));

                        if (tRun != null)
                        {
                            tRun.Start();
                            _pop = new Pop_BM_Shipping_Wait();
                            _pop.Start();

                            //Display_Data();
                        }

                        tRun.Abort();
                    }

           

        }


     


        public void RunSave()
        {
            Invoke(new DelegateSetn(Tbtn_SaveProcess)); // 폼 스레드에 작업 넘김
            //   Invoke(new DelegateSetn(Display_Data));
        }








		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
				if (MessageBox.Show(this, "Do you want to confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Tbtn_ConfirmProcess();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Print))
				SetPrintYield();
		}

		#endregion

		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			int vChilds = this.MdiParent.MdiChildren.Length;

			for (int vIdx = vChilds - 1 ; vIdx >= 0 ; vIdx--)
			{
				if (this.MdiParent.MdiChildren[vIdx] is Form_BM_MRP_Operation)
					this.MdiParent.MdiChildren[vIdx].Close();
			}

			this.Dispose(true);
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
            Cmb_MrpShipNoSetting();
			CheckStatus();
			fgrid_main.ClearAll();
		}

		private void cmb_mrpno_SelectedValueChanged(object sender, System.EventArgs e)
		{
			CheckStatus();
			fgrid_main.ClearAll();
		}

		private void cmb_shipType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_MrpShipNoSetting();
			CheckStatus();
			fgrid_main.ClearAll();
		}

		private void cmb_itemDiv_SelectedValueChanged(object sender, System.EventArgs e)
		{
			fgrid_main.ClearAll();

			if (cmb_itemDiv.SelectedIndex == 0)
			{
				mnu_value.Visible = false;
				menuItem5.Visible = false;

				btn_Insert.Enabled = false;
				btn_Delete.Enabled = false;
				btn_Recover.Enabled = false;
				fgrid_main.Cols[_shipYnCol].AllowEditing = false;
				fgrid_main.Cols[_shipYnCol].StyleNew.ForeColor = Color.Black;
			}
			else if (cmb_itemDiv.SelectedIndex == 1)
			{
				mnu_value.Visible = true;
				menuItem5.Visible = true;

				btn_Insert.Enabled = true;
				btn_Delete.Enabled = true;
				btn_Recover.Enabled = true;
				fgrid_main.Cols[_shipYnCol].AllowEditing = true;
				fgrid_main.Cols[_shipYnCol].StyleNew.ForeColor = Color.Blue;
			}
			else if  (cmb_itemDiv.SelectedIndex == 2)
			{
				mnu_value.Visible = false;
				menuItem5.Visible = false;

				btn_Insert.Enabled = false;
				btn_Delete.Enabled = false;
				btn_Recover.Enabled = false;
				fgrid_main.Cols[_shipYnCol].AllowEditing = false;
				fgrid_main.Cols[_shipYnCol].StyleNew.ForeColor = Color.Black;
			}
		}



		private void lbl_RunProcess_Click(object sender, System.EventArgs e)
		{
            
                if (MessageBox.Show(this, "Do you want to run mrp process?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    COM.ComVar.Parameter_PopUp = new string[] { "Password" };
                    Pop_BM_Changer vPop = new Pop_BM_Changer();
                    vPop.ShowDialog();

                    if (COM.ComVar.Parameter_PopUp == null)
                        return;

                    System.Threading.Thread tSize = new System.Threading.Thread(new System.Threading.ThreadStart(RunMRP));
                    tSize.Start();

                    _pop = new Pop_BM_Shipping_Wait();
                    _pop.Processing();
                    _pop.Start();
                }
          
            

		}




        public void RunMRP()
        {
            Invoke(new DelegateSetn(RunMRPPRocess)); // 폼 스레드에 작업 넘김           

        }



        public void RunMRPPRocess()
        {
           try
           {
               RUN_MRP_PROCESS();
               _pop.Close();
           }
           catch (Exception ex)
		   {
				ClassLib.ComFunction.User_Message(ex.Message, "RunMRPPRocess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		   }	
           finally
           {

                _pop.Close();
           }

           

        }




		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_insert))
				Btn_InsertProcess();
		}

		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_delete))
				if (MessageBox.Show(this, "Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					Btn_DeleteProcess();
		}

		private void btn_Recover_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show(this, "Do you want to recover?", "Recover", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				fgrid_main.Recover_Row();
		}

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if ( cmb_itemGroup.SelectedIndex >= 1 )
			{
				this.btn_groupSearch.Enabled = true;
			}
			else
			{
				txt_itemGroup.Text = "";
				_itemGroupCode = "";
				this.btn_groupSearch.Enabled = false;
			}
		}

		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
			string vTyep = this.cmb_itemGroup.SelectedValue.ToString();
			FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);

			vPopup.ShowDialog();
			
			_itemGroupCode			= COM.ComVar.Parameter_PopUp[3];
			this.txt_itemGroup.Text	= COM.ComVar.Parameter_PopUp[4];

			vPopup.Dispose();		
		}

		#region 컨텍스트 메뉴

		private void mnu_findData_Click(object sender, System.EventArgs e)
		{
			finder = new Pop_Finder(fgrid_main, 1, fgrid_main.Cols.Frozen - 1);
			finder.Show();
		}

		private void mnu_ceiling_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(1);
		}

		private void mnu_roundUp_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(2);		
		}

		private void mnu_truncate_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(3);
		}

		private void mnu_pk_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(5);
		}

		private void mnu_allSelect_Click(object sender, System.EventArgs e)
		{
			fgrid_main.SelectAll();
		}

		private void mnu_header_Click(object sender, System.EventArgs e)
		{
            fgrid_main.Tree.Show(1);		
		}

		private void mnu_all_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);		
		}

		private void mnu_value_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_mnu_value))
				Mnu_ValueChange();
		}

		#endregion

		#region 버튼 클릭

		private void btn_RunProcess_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_RunProcess.ImageIndex = 1;			
		}

		private void btn_RunProcess_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_RunProcess.ImageIndex = 0;
		}

		#endregion

		#endregion 

		#region 이벤트 처리 메서드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "MRP Adjust";
			lbl_MainTitle.Text = "MRP Adjust";


            ClassLib.ComFunction.SetLangDic(this);



			// grid set
			fgrid_main.Set_Grid("SBM_MRP_ADJUST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);
			Grid_SetFormat();

			// factory set
			DataTable vDt;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = (cmb_factory.Tag == null) ? ClassLib.ComVar.This_Factory : cmb_factory.Tag;
			vDt.Dispose();

			// ship type set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
			COM.ComCtl.Set_ComboList(vDt, cmb_shipType, 1, 2, false);
			cmb_shipType.SelectedValue = (cmb_shipType.Tag == null) ? "11" : cmb_shipType.Tag;
			vDt.Dispose();

			// item division set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPItemDivision);
			COM.ComCtl.Set_ComboList(vDt, cmb_itemDiv, 1, 2, false);
			cmb_itemDiv.SelectedIndex = 0;
			vDt.Dispose();

			// item division set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM16");
			COM.ComCtl.Set_ComboList(vDt, cmb_moveType, 1, 2, false);
			cmb_moveType.SelectedIndex = 0;
			vDt.Dispose();

			// Item Group Combobox Setting
			vDt = ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true, 45, 60);
			cmb_itemGroup.SelectedIndex = 0;
			vDt.Dispose();

			_itemGroupCode = "";

			CheckStatus();

			// tbtn set
			this.tbtn_Delete.Enabled = false;
			this.tbtn_Create.Enabled = false;

		}

		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = SELECT_MRP_ADVICE_LIST();

				if (vDt.Rows.Count > 0)
				{
					ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_main, vDt, 0);
					fgrid_main.Tree.Column = (int)TBSBM_MRP_ADJUST.IxITEM_NAME;
					Grid_SetColor();
				}
				else
				{
					fgrid_main.ClearAll();
				}

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SearchProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

				if (SAVE_SBM_MRP_ADJUST())
				{
					ClassLib.ComFunction.User_Message("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
					fgrid_main.ClearFlags();
					this.Grid_SetColor();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
				else
				{
					ClassLib.ComFunction.User_Message("Save Fail", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SaveProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				_pop.Close();
			}
		}

		private void Tbtn_ConfirmProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				// Confirm
				if (SAVE_SBM_MRP_ADJUST_CONFIRM())
				{
					Confirm();
					fgrid_main.ClearFlags();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_ConfirmProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void  SetPrintYield()
		{
			try
			{
				string mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_BM_MRP_Adjust.mrd" ;
				string Para         = " ";

				#region 출력조건

				int  iCnt  = 6;
				string [] aHead =  new string[iCnt];	

				aHead[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				aHead[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				aHead[2] = COM.ComFunction.Empty_Combo(cmb_mrpno, "");
				aHead[3] = COM.ComFunction.Empty_Combo(cmb_itemDiv, "");
				aHead[4] = COM.ComFunction.Empty_Combo(cmb_moveType, "");
				aHead[5] = _itemGroupCode;

			
				#endregion
	
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
	
				FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
				report.Show();	

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}

		#endregion

		#region 컨트롤 이벤트 처리 메서드

		private void Cmb_MrpShipNoSetting()
		{
			try
			{
				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vShipType = COM.ComFunction.Empty_Combo(cmb_shipType, "");

				DataTable vDt = ClassLib.ComFunction.SELECT_MRP_SHIP_NO_LIST(vFactory, vShipType);
				COM.ComCtl.Set_ComboList(vDt, cmb_mrpno, 0, 0, false, false);
				cmb_mrpno.SelectedValue = (cmb_mrpno.Tag == null) ? "" : cmb_mrpno.Tag;
			}
			catch {}
		}

		private void Btn_InsertProcess()
		{
			try
			{
				FlexBase.MaterialBase.Pop_Item_List vPopup = new FlexBase.MaterialBase.Pop_Item_List();
				vPopup.ShowDialog(); 

				if(ClassLib.ComVar.Parameter_PopUp[0].Trim() != "")
				{
					int vErrorRow = CheckDuplicate();
					if (fgrid_main.Rows.Count != vErrorRow)
					{
						ClassLib.ComFunction.User_Message("Row " + (vErrorRow - fgrid_main.Rows.Fixed) + " : Exist Duplicate Data", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					C1.Win.C1FlexGrid.Node newRow1				= fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, 1);
					C1.Win.C1FlexGrid.Node newRow2				= fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, 2);

					// default 값 세팅 ( 현재 선택된 스타일 정보가 저장됨 )
					int vRow = fgrid_main.Row;
					int vHead = 0;
					int vTail = 0;

					if (fgrid_main.Rows[vRow].Node.Level == 2)
					{
						vHead = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
                        vTail = vRow;				
					}
					else
					{
						vHead = vRow;
						vTail = vRow + 1;
					}

					for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
					{
						newRow1.Row[vCol] = fgrid_main[vHead, vCol];
						newRow2.Row[vCol] = fgrid_main[vTail, vCol];
					}

					fgrid_main[newRow1.Row.Index, _mrpShipNoCol]	= cmb_mrpno.SelectedValue.ToString();
					fgrid_main[newRow1.Row.Index, _itemCodeCol]		= ClassLib.ComVar.Parameter_PopUp[0];
					fgrid_main[newRow1.Row.Index, _lotInfoCol]		= ClassLib.ComVar.Parameter_PopUp[1];
					fgrid_main[newRow1.Row.Index, _specCodeCol]		= ClassLib.ComVar.Parameter_PopUp[2];
					fgrid_main[newRow1.Row.Index, _styleCodeCol]	= ClassLib.ComVar.Parameter_PopUp[3];
					fgrid_main[newRow1.Row.Index, _colorCodeCol]	= ClassLib.ComVar.Parameter_PopUp[4];
					fgrid_main[newRow1.Row.Index, _styleNameCol]	= ClassLib.ComVar.Parameter_PopUp[5];
					fgrid_main[newRow1.Row.Index, _unitCol]			= ClassLib.ComVar.Parameter_PopUp[6];
					fgrid_main[newRow1.Row.Index, _pkQtyCol]		= ClassLib.ComVar.Parameter_PopUp[7];
					fgrid_main[newRow1.Row.Index, _confirmQtyCol]	= 0;
					fgrid_main[newRow1.Row.Index, _adviceQtyCol]	= 0;
					fgrid_main[newRow1.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxUSAGE_QTY]	= 0;
					fgrid_main[newRow1.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxOUT_SIDE_YN]	= ClassLib.ComVar.No;
					fgrid_main[newRow1.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxSTYLE_ITEM_DIV]	= cmb_itemDiv.SelectedValue;
					fgrid_main[newRow1.Row.Index, 0]				= ClassLib.ComVar.Insert;

					
					//fgrid_main[newRow2.Row.Index, _lotInfoCol]	= "NONE";
					//fgrid_main[newRow2.Row.Index, _styleCodeCol]	= "NONE";
					//fgrid_main[newRow2.Row.Index, _styleNameCol]	= "NONE";
					fgrid_main[newRow2.Row.Index, _confirmQtyCol]	= 0;
					fgrid_main[newRow2.Row.Index, _adviceQtyCol]	= 0;
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxUSAGE_QTY]		= 0;
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxREQUEST_QTY]		= 0;
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxSHIPPING_QTY]	= 0;
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxWAREHOUSE_QTY]	= 0;
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxPRODUCTION_QTY]	= 0;
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxPK_QTY]			= ClassLib.ComVar.Parameter_PopUp[7];
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxSHIP_YN]			= ClassLib.ComVar.Yes;
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxOUT_SIDE_YN]		= ClassLib.ComVar.No;
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxSTYLE_ITEM_DIV]	= cmb_itemDiv.SelectedValue;
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxREMARKS]			= "Add New";
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxSTATUS]			= "S";
					fgrid_main[newRow2.Row.Index, (int)ClassLib.TBSBM_MRP_ADJUST.IxUPD_USER]		= COM.ComVar.This_User;
					fgrid_main[newRow2.Row.Index, 0]	= ClassLib.ComVar.Insert;

					fgrid_main.Select(newRow2.Row.Index, _confirmQtyCol);
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_InsertProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Btn_DeleteProcess()
		{
			try
			{
				int vStartRow	= fgrid_main.Row;
				int vEndRow		= fgrid_main.Row;

				if (ClassLib.ComFunction.NullToBlank(fgrid_main[vStartRow, 0]).Equals(ClassLib.ComVar.Insert))
				{
					if (fgrid_main.Rows[vStartRow].Node.Level == 2)
					{
						vStartRow = fgrid_main.Rows[vStartRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
					}

					Node vNextNode = fgrid_main.Rows[vStartRow].Node.GetNode(NodeTypeEnum.NextSibling);
					if (vNextNode == null)
						vEndRow = fgrid_main.Rows.Count - 1;
					else
						vEndRow = vNextNode.Row.Index - 1;

					while (vStartRow <= vEndRow)
					{
						fgrid_main.Rows[vEndRow].Node.RemoveNode();
						vEndRow--;
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_DeleteProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private int CheckDuplicate()
		{
			string vOriginalData = ClassLib.ComVar.Parameter_PopUp[0] + ClassLib.ComVar.Parameter_PopUp[2] + ClassLib.ComVar.Parameter_PopUp[4];

			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				if (fgrid_main.Rows[vRow].Node.Level == 2)
				{
					int vParentRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

					string vCurrentData = fgrid_main[vParentRow, _itemCodeCol].ToString() +
											fgrid_main[vParentRow, _specCodeCol].ToString() + 
											fgrid_main[vParentRow, _colorCodeCol].ToString();

					if (vOriginalData.Equals(vCurrentData))
					{
						return vRow;
					}
				}
			}

			return fgrid_main.Rows.Count;
		}

		#endregion

		#region 그리드 이벤트 처리 메서드

		private void Grid_AfterEditProcess()
		{
			int vRow = fgrid_main.Row;
			int vCol = fgrid_main.Col;

			if (fgrid_main.Rows[vRow].Node.Level == 1 && vCol == _confirmQtyCol)
			{
				Grid_QtyCalculation(vRow);
			}
			else if (vCol == _confirmQtyCol)
			{
				Row vParent = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row;
				vParent[_confirmQtyCol] = Convert.ToDouble(vParent[_confirmQtyCol]) + (Convert.ToDouble(fgrid_main[vRow, vCol]) - Convert.ToDouble(fgrid_main.Buffer_CellData));
			}

			fgrid_main.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_main.Row < fgrid_main.Rows.Fixed)
				return;

			int vRow = fgrid_main.Row;

			if ( e.Button == MouseButtons.Right )
				ctx_main.Show(fgrid_main, new Point(e.X, e.Y));
//			else if ( e.Button == MouseButtons.Left )
//			{
//				if (fgrid_main.Rows[vRow].Node.Level == 2)
//					vRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
//
//				int vCol = fgrid_main.Cols.Frozen;
//
//				while (vCol < fgrid_main.Cols.Count)
//				{
//					if ( fgrid_main[vRow, vCol] != null || fgrid_main[vRow + 1, vCol] != null )
//					{
//						fgrid_main.LeftCol = vCol;
//						break;
//					}
//					vCol++;
//				}
//			}
		}

		#endregion

		#region 컨텍스트 메뉴 이벤트 처리 메서드

		private void Mnu_AutoCalculation(int arg_kind)
		{
			int[] vSel = fgrid_main.Selections;

			foreach (int vRow in vSel)
			{
				if ( fgrid_main.Rows[vRow].Node.Level == 1 )
				{
					int vQty = Get_ConvertedNumber(vRow, arg_kind);
					if (vQty != -1)
					{
						fgrid_main[vRow, _confirmQtyCol] = vQty;
						Grid_QtyCalculation(vRow);
					}
				}
			}
		}

		private int Get_ConvertedNumber(int arg_row, int arg_kind)
		{
			int vResult = -1;
			double vAdviceQty = Convert.ToDouble(fgrid_main[arg_row, _adviceQtyCol]);

			switch (arg_kind)
			{
				case 1:
					vResult = (int)Math.Ceiling(vAdviceQty);
					break;
				case 2:
					vResult = (int)Math.Round(vAdviceQty);
					break;
				case 3:
					vResult = (int)vAdviceQty;
					break;
                case 4:
					vResult = (int)Math.Floor(vAdviceQty);
					break;
				case 5:
					int vPKQty = Convert.ToInt32(fgrid_main[arg_row, _pkQtyCol]);

					if ( vPKQty == 0 )	return -1;

					double vTemp = ((int)(vAdviceQty / vPKQty)) * vPKQty;

                    vResult = (int)vTemp;

					if ( vTemp < vAdviceQty )
						vResult = (int)(vTemp + vPKQty);
					break;
			}

			return vResult;
		}

		private void Mnu_ValueChange()
		{
			try
			{
				int vCol = fgrid_main.Col;

				if (vCol != _shipYnCol)
					return;

				ClassLib.ComVar.Parameter_PopUp = new string[]{"Shipping"};
				ClassLib.ComVar.Parameter_PopUp_Object = new object[]{fgrid_main.GetDataSourceWithCode(vCol)};
				Pop_BM_Changer _pop = new Pop_BM_Changer();
				_pop.ShowDialog();

				if (ClassLib.ComVar.Parameter_PopUp != null)
				{
					foreach (int vRow in fgrid_main.Selections)
					{
						if (fgrid_main.Rows[vRow].Node.Level == 2)
						{
							fgrid_main[vRow, _shipYnCol] = ClassLib.ComVar.Parameter_PopUp[0];
							fgrid_main.Update_Row(vRow);
						}
					}
				}
			}
			catch
			{
			}
		}

		private void mnu_usageCheck_Click(object sender, System.EventArgs e)
		{
			int vRow = fgrid_main.Row;

			Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent);

			if (vNode == null)	return;

			int vParentRow = vNode.Row.Index;

			COM.ComVar.Parameter_PopUp		= new string[15];
			COM.ComVar.Parameter_PopUp[0]	= COM.ComFunction.Empty_Combo(cmb_factory, "");
			COM.ComVar.Parameter_PopUp[1]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _styleCodeCol]);
			COM.ComVar.Parameter_PopUp[2]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _styleNameCol]);
			COM.ComVar.Parameter_PopUp[3]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _itemNameCol]);
			COM.ComVar.Parameter_PopUp[4]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _specNameCol]);
			COM.ComVar.Parameter_PopUp[5]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _colorNameCol]);
			COM.ComVar.Parameter_PopUp[6]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _confirmQtyCol]);

			COM.ComVar.Parameter_PopUp[7]	= COM.ComFunction.Empty_Combo(cmb_shipType, "");
			COM.ComVar.Parameter_PopUp[8]	= COM.ComFunction.Empty_Combo(cmb_mrpno, "");
			COM.ComVar.Parameter_PopUp[9]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lotInfoCol]).Substring(0, 9);
			COM.ComVar.Parameter_PopUp[10]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lotInfoCol]).Substring(10, 2);
			COM.ComVar.Parameter_PopUp[11]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _itemCodeCol]);
			COM.ComVar.Parameter_PopUp[12]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _specCodeCol]);
			COM.ComVar.Parameter_PopUp[13]	= ClassLib.ComFunction.NullToBlank(fgrid_main[vParentRow, _colorCodeCol]);
			COM.ComVar.Parameter_PopUp[14]	= "";

			Pop_BM_MRP_Adjust_Usage_Check vPop = new Pop_BM_MRP_Adjust_Usage_Check();
			vPop.ShowDialog();
		}

		#endregion

		#region 이벤트 처리시 사용되는 기능 메서드

		// grid format set
		private void Grid_SetFormat()
		{
			int vCol = 1;

			while (vCol < fgrid_main.Cols.Count)
			{
				if (fgrid_main.Cols[vCol].Style.Name.IndexOf("NUMBER") > -1)
				{
					if (vCol == _confirmQtyCol || vCol == _pkQtyCol)
						fgrid_main.Cols[vCol].Format = "#,##0";
					else
						fgrid_main.Cols[vCol].Format = "#,##0.00";
				}

				vCol++;
			}
		}

        // grid color set
		private void Grid_SetColor()
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				switch (fgrid_main.Rows[vRow].Node.Level)
				{
					case 1:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						break;
					case 2:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;

						if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol]).Equals("") 
							|| ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol]).Substring(0, 1).Equals("N"))
						{
							fgrid_main.Rows[vRow].StyleNew.ForeColor = ClassLib.ComVar.RightRed;
						} 

						if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ADJUST.IxSTATUS]).Equals("S"))
						{
							fgrid_main.Rows[vRow].AllowEditing = true;
						}
						else
						{
							fgrid_main.Rows[vRow].AllowEditing = false;
						}
						break;
				}
			}
		}

		// Advice qty calculation
		private void Grid_QtyCalculation(int arg_row)
		{
			try
			{
				int vStartRow	= arg_row + 1;
				Node vNode		= fgrid_main.Rows[arg_row].Node.GetNode(NodeTypeEnum.NextSibling);
				int vEndRow		= (vNode == null) ? fgrid_main.Rows.Count : vNode.Row.Index;

				double vOldQty	= Convert.ToDouble(fgrid_main[arg_row, _adviceQtyCol]);
				double vNewQty	= Convert.ToDouble(fgrid_main[arg_row, _confirmQtyCol]);
				int vSumQty	= 0;
				int vTempQty = 0;

				for (int vRow = vStartRow ; vRow < vEndRow ; vRow++)
				{
					double vCurQty = Convert.ToDouble(fgrid_main[vRow, _adviceQtyCol]);

					vCurQty = (vCurQty == 0) ? 1 : vCurQty;
					vOldQty = (vOldQty == 0) ? 1 : vOldQty;

					vTempQty = Convert.ToInt32((vCurQty / vOldQty) * vNewQty);
					
					fgrid_main[vRow, _confirmQtyCol] = vTempQty;
					vSumQty += vTempQty;
					
					fgrid_main.Update_Row(vRow);
				}

				if ( vSumQty != vNewQty )
				{
					double vDiv = (vSumQty - vNewQty);

					for (int vRow2 = vEndRow - 1 ; vRow2 >= vStartRow ; vRow2--)
					{
//						if (Convert.ToInt32(fgrid_main[vRow2, _confirmQtyCol]) > 0)
//						{
							if (Convert.ToInt32(fgrid_main[vRow2, _confirmQtyCol]) >= vDiv)
							{
								fgrid_main[vRow2, _confirmQtyCol] = Convert.ToInt32(fgrid_main[vRow2, _confirmQtyCol]) - vDiv;
								break;
							}
							else
							{
								vDiv = vDiv - Convert.ToInt32(fgrid_main[vRow2, _confirmQtyCol]);
								fgrid_main[vRow2, _confirmQtyCol] = 0;
							}
//						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Grid_QtyCalculation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// get lot no, lot seq, style, ship ymd
		private string Etc_GetLotNo(int arg_row)
		{
			if (fgrid_main[arg_row, _lotInfoCol] != null)
			{
				return fgrid_main[arg_row, _lotInfoCol].ToString().Split('-')[0];
			}
			else
				return "NONE";
		}

		private string Etc_GetLotSeq(int arg_row)
		{
			if (fgrid_main[arg_row, _lotInfoCol] != null)
			{
				return fgrid_main[arg_row, _lotInfoCol].ToString().Split('-')[1];
			}
			else
				return "00";
		}

		private string Etc_GetStyleCode(int arg_row)
		{
			if (fgrid_main[arg_row, _lotInfoCol] != null)
			{
				return fgrid_main[arg_row, _styleCodeCol].ToString().Replace("-", "");
			}
			else
				return "NONE";
		}

		private string Etc_GetShipYMD(int arg_row)
		{
			return fgrid_main[arg_row, _mrpShipNoCol].ToString().Substring(4);
		}

		#endregion

		#region Validate Check

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			try
			{
				// 공통 체크
				if (cmb_factory.SelectedIndex == -1)
				{
					ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					cmb_factory.Focus();
					return false;
				}

				// 부분별 체크 (Search, Save, Delete, Confirm..)
				switch (arg_type)
				{
					case ClassLib.ComVar.Validate_Search:

						break;
					case ClassLib.ComVar.Validate_Save:
						if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
						{
							ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
						break;
					case ClassLib.ComVar.Validate_Delete:

						break;
					case ClassLib.ComVar.Validate_Confirm:
						for (int vRow1 = fgrid_main.Rows.Fixed ; vRow1 < fgrid_main.Rows.Count ; vRow1++)
						{
							int vQty = Convert.ToInt32(ClassLib.ComFunction.NullCheck(fgrid_main[vRow1, _confirmQtyCol], "0"));

							if (vQty < 0)
							{
								ClassLib.ComFunction.User_Message("Invalid Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow1, _confirmQtyCol);
								return false;
							}
						}
						if (cmb_shipType.SelectedIndex == -1)
						{
							ClassLib.ComFunction.User_Message("Select Ship Type", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							cmb_shipType.Focus();
							return false;
						}
                        //if (fgrid_main.Rows.Fixed >= fgrid_main.Rows.Count)
                        //{
                        //    ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    return false;
                        //}

                        if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
                        {
                            string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

                            if (vTemp.Length > 0)
                            {
                                ClassLib.ComFunction.User_Message("Exist modify data. ", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }

                        }

						if (ClassLib.ComFunction.DoConfirm(cmb_factory.SelectedValue.ToString(), cmb_shipType.SelectedValue.ToString(), "40", Convert.ToInt32(_process)) != 1)
							return false;


						break;
					case _mnu_value:
						if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
						{
							ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}						
						//if (fgrid_main.Col != this._shipYnCol)
						//{
						//	return false;
						//}
						break;
					case _insert :
						if (COM.ComFunction.Empty_Combo(cmb_mrpno, "").Equals(""))
						{
							ClassLib.ComFunction.User_Message("Select MRP Ship No", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
						break;
					case _delete :
						int vRow = fgrid_main.Row;

						if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]).Equals(ClassLib.ComVar.Insert))
						{
							return false;
						}
						break;
				}

				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}

		#endregion

		#endregion

		#region DB Connect
	
		/// <summary>
		/// PKG_SBM_MRP_ADJUST : ITEM 리스트 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_MRP_ADVICE_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_MRP_ADJUST.SELECT_MRP_ADVICE_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_DIVISION";
			MyOraDB.Parameter_Name[4] = "ARG_MOVE_TYPE";
			MyOraDB.Parameter_Name[5] = "ARG_GROUP_CD";
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
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_mrpno, "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_itemDiv, "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_moveType, "");
			MyOraDB.Parameter_Values[5] = _itemGroupCode;
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBM_MRP_ADJUST : 
		/// </summary>
		public bool SAVE_SBM_MRP_ADJUST()
		{
			_pop.Message = "Data Creating..";

			MyOraDB.ReDim_Parameter(27);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_MRP_ADJUST.SAVE_SBM_MRP_ADJUST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[4] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[5] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[7] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[8] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[9] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[10] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[11] = "ARG_CONFIRM_QTY";
			MyOraDB.Parameter_Name[12] = "ARG_ADVICE_QTY";
			MyOraDB.Parameter_Name[13] = "ARG_USAGE_QTY";
			MyOraDB.Parameter_Name[14] = "ARG_REQUEST_QTY";
			MyOraDB.Parameter_Name[15] = "ARG_SHIPPING_QTY";
			MyOraDB.Parameter_Name[16] = "ARG_WAREHOUSE_QTY";
			MyOraDB.Parameter_Name[17] = "ARG_PRODUCTION_QTY";
			MyOraDB.Parameter_Name[18] = "ARG_PK_QTY";
			MyOraDB.Parameter_Name[19] = "ARG_SHIP_YN";
			MyOraDB.Parameter_Name[20] = "ARG_OUT_SIDE_YN";
			MyOraDB.Parameter_Name[21] = "ARG_STYLE_ITEM_DIV";
			MyOraDB.Parameter_Name[22] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[23] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[24] = "ARG_REMARKS";
			MyOraDB.Parameter_Name[25] = "ARG_STATUS";
			MyOraDB.Parameter_Name[26] = "ARG_UPD_USER";

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
			MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[22] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[23] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[24] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[25] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[26] = (int)OracleType.VarChar;


			//04.DATA 정의
			ArrayList vModifyList	= new ArrayList(fgrid_main.Rows.Count);
			string vFactory			= COM.ComFunction.Empty_Combo(cmb_factory, "");
			string vShipType		= COM.ComFunction.Empty_Combo(cmb_shipType, "");
			
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]).Equals("") && fgrid_main.Rows[vRow].Node.Level != 1)
				{
					int vParentRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

					string vMrpShipNo = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _mrpShipNoCol]);;
					if (fgrid_main[vRow, 0].ToString().Equals(ClassLib.ComVar.Insert))
						vMrpShipNo = COM.ComFunction.Empty_Combo(cmb_mrpno, "");

					string vShipYMD			= vMrpShipNo.Substring(4);

					vModifyList.Add(fgrid_main[vRow, 0].ToString());
					vModifyList.Add(vFactory);
					vModifyList.Add(vShipType);
					vModifyList.Add(vMrpShipNo);
					vModifyList.Add(Etc_GetLotNo(vRow));
					vModifyList.Add(Etc_GetLotSeq(vRow));
					vModifyList.Add(Etc_GetStyleCode(vRow));
					vModifyList.Add(fgrid_main[vParentRow, _itemCodeCol].ToString());
					vModifyList.Add(fgrid_main[vParentRow, _specCodeCol].ToString());
					vModifyList.Add(fgrid_main[vParentRow, _colorCodeCol].ToString());
					vModifyList.Add(vShipYMD);
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _confirmQtyCol]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _adviceQtyCol]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxUSAGE_QTY]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxREQUEST_QTY]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxSHIPPING_QTY]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxWAREHOUSE_QTY]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxPRODUCTION_QTY]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxPK_QTY]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxSHIP_YN]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxOUT_SIDE_YN]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxSTYLE_ITEM_DIV]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxOBS_ID]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxOBS_TYPE]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxREMARKS]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_ADJUST.IxSTATUS]));
					vModifyList.Add(COM.ComVar.This_User);
				}
			}

			MyOraDB.Parameter_Values = (string[])vModifyList.ToArray(Type.GetType("System.String"));


			_pop.Message = "Saving...";

			MyOraDB.Add_Modify_Parameter(true);
			DataSet vDs = MyOraDB.Exe_Modify_Procedure();

			if (vDs != null)
				return true;
			else
				return false;
		}

		/// <summary>
		/// PKG_SBM_MRP_ADJUST : 
		/// </summary>
		public bool SAVE_SBM_MRP_ADJUST_CONFIRM()
		{
			try
			{

				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_MRP_ADJUST.SAVE_SBM_MRP_ADJUST_CONFIRM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values = new string[4];
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_mrpno, "");
				MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() != null)
					return true;
				else
					return false;
			}
			catch
			{
				return false;
			}

		}

		/// <summary>
		/// PKG_SBM_SHIPPING : Run Process
		/// </summary>
		public void RUN_MRP_PROCESS()
		{
           
                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SBM_MRP.RUN_MRP_PROCESS";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
                MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
                MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
                MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = cmb_shipType.SelectedValue.ToString();
                MyOraDB.Parameter_Values[2] = " ";
                MyOraDB.Parameter_Values[3] = " ";
                MyOraDB.Parameter_Values[4] = " ";

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

          
		}

		#endregion	

		#region IOperation 멤버

		public void CheckStatus()
		{
		

            // status set
            //txt_status.Text = ClassLib.ComFunction.ProcessStatus(_process, COM.ComFunction.Empty_Combo(cmb_factory, ""), COM.ComFunction.Empty_Combo(cmb_mrpno, ""));
            if ((cmb_mrpno.SelectedValue == null) || (cmb_shipType.SelectedValue == null))
            {

                txt_status.Text = ClassLib.ComFunction.ProcessStatus(_process, cmb_factory.SelectedValue.ToString(), COM.ComFunction.Empty_Combo(cmb_mrpno, ""));

            }
            else
            {
                txt_status.Text = ClassLib.ComFunction.ProcessStatus(_process, cmb_factory.SelectedValue.ToString(),
                        COM.ComFunction.Empty_Combo(cmb_mrpno, ""), cmb_shipType.SelectedValue.ToString());

            }



			

			if (!txt_status.Text.ToUpper().Equals(ClassLib.ComVar.Status_SAVE))
			{
				fgrid_main.AllowEditing = false;
				btn_Insert.Enabled = false;
				btn_Delete.Enabled = false;
				btn_Recover.Enabled = false;
			}
			else
			{
				fgrid_main.AllowEditing = true;
				btn_Insert.Enabled = true;
				btn_Delete.Enabled = true;
				btn_Recover.Enabled = true;
			}

			// button enable set
			DataTable vDt			 = ClassLib.ComFunction.SELECT_PROCESS_CHARGE(cmb_factory.SelectedValue.ToString(), _process);
			tbtn_Save.Enabled		 = ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Save, txt_status.Text);
			tbtn_Confirm.Enabled	 = ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Confirm, txt_status.Text);
			btn_RunProcess.Enabled	 = ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Confirm, txt_status.Text);
		}

		public bool Confirm()
		{
			if (ClassLib.ComFunction.Essentiality_check(new C1.Win.C1List.C1Combo[]{cmb_factory, cmb_shipType, cmb_mrpno}, null))
			{
				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vShipType = COM.ComFunction.Empty_Combo(cmb_shipType, "");

				if (ClassLib.ComFunction.SAVE_CHECK_LIST_CONFIRM(_process, vFactory, vShipType, COM.ComVar.This_User, true))
				{
					ClassLib.ComFunction.User_Message("Confirm complete", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txt_status.Text = "Confirm";
					tbtn_Save.Enabled = false;
					tbtn_Confirm.Enabled = false;
					btn_RunProcess.Enabled = false;
					btn_Insert.Enabled = false;
					btn_Delete.Enabled = false;
					btn_Recover.Enabled = false;
					fgrid_main.AllowEditing = false;
					return true;
				}
			}

			return false;
		}

		public void RunProcess(string arg_factory, string arg_ShipType, string arg_mrpNo, string arg_PlanStart, string arg_PlanEnd)
		{
			cmb_factory.Tag = arg_factory;
			cmb_shipType.Tag = arg_ShipType;
			cmb_mrpno.Tag = arg_mrpNo;
		}

		public int GetSearchRows()
		{
			return fgrid_main.Rows.Count - fgrid_main.Rows.Fixed;
		}

		#endregion

	}
}

