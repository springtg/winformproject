using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

namespace FlexMRP.MRP
{
	public class Form_BM_Shipping_Master : COM.PCHWinForm.Form_Top, IOperation
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_reqYmd;
		private System.Windows.Forms.Label lbl_ShipType;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private C1.Win.C1List.C1Combo cmb_ShipType;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label btn_shift;
		private System.Windows.Forms.MenuItem mnu_ShiftDown;
		private System.Windows.Forms.MenuItem mnu_area;
		private System.Windows.Forms.MenuItem mnu_10;
		private System.Windows.Forms.MenuItem mnu_20;
		private System.Windows.Forms.MenuItem mnu_30;
		private System.Windows.Forms.MenuItem mnu_40;
		private System.Windows.Forms.MenuItem mnu_50;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private const int _validate_AutoShift = 10, _validate_ShiftUp = 20, _validate_ShiftDown = 30, _validate_context = 40;
		private string _process		= (int)ClassLib.ComVar.MRPProcessNum.Master + "";
		private int _factoryCol		= (int)ClassLib.TBSBM_SHIP_MASTER.IxFACTORY;
		private int _shipTypeCol	= (int)ClassLib.TBSBM_SHIP_MASTER.IxSHIP_TYPE;
		private int _mrpShipNoCol	= (int)ClassLib.TBSBM_SHIP_MASTER.IxMRP_SHIP_NO;
		private int _areaCodeCol	= (int)ClassLib.TBSBM_SHIP_MASTER.IxAREA_CD;
		private int _areaNameCol	= (int)ClassLib.TBSBM_SHIP_MASTER.IxAREA_NAME;
		private int _foreColorCol	= (int)ClassLib.TBSBM_SHIP_MASTER.IxFORE_COLOR;
		private int _backColorCol	= (int)ClassLib.TBSBM_SHIP_MASTER.IxBACK_COLOR;
		private int _remarksCol		= (int)ClassLib.TBSBM_SHIP_MASTER.IxREMARKS;

		//private bool _shift			= false;

		#endregion

		#region 생성자 / 소멸자

		public Form_BM_Shipping_Master()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BM_Shipping_Master));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_shift = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.cmb_ShipType = new C1.Win.C1List.C1Combo();
            this.lbl_ShipType = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_reqYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ctx_tail = new System.Windows.Forms.ContextMenu();
            this.mnu_ShiftDown = new System.Windows.Forms.MenuItem();
            this.mnu_area = new System.Windows.Forms.MenuItem();
            this.mnu_10 = new System.Windows.Forms.MenuItem();
            this.mnu_20 = new System.Windows.Forms.MenuItem();
            this.mnu_30 = new System.Windows.Forms.MenuItem();
            this.mnu_40 = new System.Windows.Forms.MenuItem();
            this.mnu_50 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            this.pnl_main.SuspendLayout();
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
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.GridDefinition = "15.9722222222222:False:True;83.3333333333333:False:False;\t0.393700787401575:False" +
                ":True;98.4251968503937:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.btn_shift);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.cmb_ShipType);
            this.pnl_head.Controls.Add(this.lbl_ShipType);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.lbl_reqYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 92);
            this.pnl_head.TabIndex = 0;
            // 
            // btn_shift
            // 
            this.btn_shift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_shift.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_shift.ImageIndex = 0;
            this.btn_shift.ImageList = this.img_Button;
            this.btn_shift.Location = new System.Drawing.Point(568, 62);
            this.btn_shift.Name = "btn_shift";
            this.btn_shift.Size = new System.Drawing.Size(80, 23);
            this.btn_shift.TabIndex = 398;
            this.btn_shift.Text = "Auto Shift";
            this.btn_shift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_shift.Click += new System.EventHandler(this.btn_shift_Click);
            this.btn_shift.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_shift_MouseDown);
            this.btn_shift.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_shift_MouseUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(206, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 397;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(225, 62);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_to.Size = new System.Drawing.Size(95, 21);
            this.dpick_to.TabIndex = 373;
            this.dpick_to.CloseUp += new System.EventHandler(this.dpick_to_CloseUp);
            // 
            // cmb_ShipType
            // 
            this.cmb_ShipType.AddItemCols = 0;
            this.cmb_ShipType.AddItemSeparator = ';';
            this.cmb_ShipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_ShipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ShipType.Caption = "";
            this.cmb_ShipType.CaptionHeight = 17;
            this.cmb_ShipType.CaptionStyle = style1;
            this.cmb_ShipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ShipType.ColumnCaptionHeight = 18;
            this.cmb_ShipType.ColumnFooterHeight = 18;
            this.cmb_ShipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ShipType.ContentHeight = 16;
            this.cmb_ShipType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ShipType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ShipType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_ShipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ShipType.EditorHeight = 16;
            this.cmb_ShipType.EvenRowStyle = style2;
            this.cmb_ShipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ShipType.FooterStyle = style3;
            this.cmb_ShipType.GapHeight = 2;
            this.cmb_ShipType.HeadingStyle = style4;
            this.cmb_ShipType.HighLightRowStyle = style5;
            this.cmb_ShipType.ItemHeight = 15;
            this.cmb_ShipType.Location = new System.Drawing.Point(438, 40);
            this.cmb_ShipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_ShipType.MaxDropDownItems = ((short)(5));
            this.cmb_ShipType.MaxLength = 32767;
            this.cmb_ShipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ShipType.Name = "cmb_ShipType";
            this.cmb_ShipType.OddRowStyle = style6;
            this.cmb_ShipType.PartialRightColumn = false;
            this.cmb_ShipType.PropBag = resources.GetString("cmb_ShipType.PropBag");
            this.cmb_ShipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ShipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.SelectedStyle = style7;
            this.cmb_ShipType.Size = new System.Drawing.Size(210, 20);
            this.cmb_ShipType.Style = style8;
            this.cmb_ShipType.TabIndex = 5;
            // 
            // lbl_ShipType
            // 
            this.lbl_ShipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShipType.ImageIndex = 1;
            this.lbl_ShipType.ImageList = this.img_Label;
            this.lbl_ShipType.Location = new System.Drawing.Point(337, 40);
            this.lbl_ShipType.Name = "lbl_ShipType";
            this.lbl_ShipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_ShipType.TabIndex = 50;
            this.lbl_ShipType.Text = "Ship Type";
            this.lbl_ShipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 76);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 62);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_from.Size = new System.Drawing.Size(95, 21);
            this.dpick_from.TabIndex = 2;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // lbl_reqYmd
            // 
            this.lbl_reqYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqYmd.ImageIndex = 1;
            this.lbl_reqYmd.ImageList = this.img_Label;
            this.lbl_reqYmd.Location = new System.Drawing.Point(8, 62);
            this.lbl_reqYmd.Name = "lbl_reqYmd";
            this.lbl_reqYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqYmd.TabIndex = 50;
            this.lbl_reqYmd.Text = "Date";
            this.lbl_reqYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 75);
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
            this.cmb_factory.CaptionStyle = style9;
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
            this.cmb_factory.EvenRowStyle = style10;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style11;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style12;
            this.cmb_factory.HighLightRowStyle = style13;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style14;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style15;
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style16;
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
            this.pic_head7.Size = new System.Drawing.Size(101, 51);
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "      Shipping Master Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(208, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(960, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 76);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 65);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.White;
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(8, 96);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1000, 480);
            this.pnl_main.TabIndex = 1;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(1000, 480);
            this.spd_main.TabIndex = 0;
            this.spd_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spd_main_MouseUp);
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // ctx_tail
            // 
            this.ctx_tail.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_ShiftDown,
            this.mnu_area});
            // 
            // mnu_ShiftDown
            // 
            this.mnu_ShiftDown.Index = 0;
            this.mnu_ShiftDown.Text = "Shift Down";
            this.mnu_ShiftDown.Click += new System.EventHandler(this.mnu_ShiftDown_Click);
            // 
            // mnu_area
            // 
            this.mnu_area.Index = 1;
            this.mnu_area.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_10,
            this.mnu_20,
            this.mnu_30,
            this.mnu_40,
            this.mnu_50});
            this.mnu_area.Text = "Area Setting";
            // 
            // mnu_10
            // 
            this.mnu_10.Index = 0;
            this.mnu_10.Text = "10 - Finish";
            this.mnu_10.Click += new System.EventHandler(this.mnu_10_Click);
            // 
            // mnu_20
            // 
            this.mnu_20.Index = 1;
            this.mnu_20.Text = "20 - Shipping";
            this.mnu_20.Click += new System.EventHandler(this.mnu_20_Click);
            // 
            // mnu_30
            // 
            this.mnu_30.Index = 2;
            this.mnu_30.Text = "30 - Ready";
            this.mnu_30.Click += new System.EventHandler(this.mnu_30_Click);
            // 
            // mnu_40
            // 
            this.mnu_40.Index = 3;
            this.mnu_40.Text = "40 - Request";
            this.mnu_40.Click += new System.EventHandler(this.mnu_40_Click);
            // 
            // mnu_50
            // 
            this.mnu_50.Index = 4;
            this.mnu_50.Text = "50 - Free";
            this.mnu_50.Click += new System.EventHandler(this.mnu_50_Click);
            // 
            // Form_BM_Shipping_Master
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BM_Shipping_Master";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{						
			Grid_EditModeOnProcess(spd_main) ;
		}		

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			spd_main.Update_Row(img_Action);
		}

		private void spd_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (Etc_ProvisoValidateCheck(_validate_context))
				{
					ctx_tail.Show(spd_main, new Point(e.X, e.Y));
				}
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
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
				this.Tbtn_SearchProcess(true);
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
			{
				if(ClassLib.ComFunction.User_Message("Do you want to confirm?","Confirm", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
				{
					if (SAVE_SHIPPING_MASTER_AREA())
					{
						Confirm();
						spd_main.Refresh_Division();
					}
				}
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			SAVE_SHIPPING_MASTER();
			spd_main.Refresh_Division();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Master.mrd" ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 4;
			string [] aHead =  new string[iCnt];
	

			aHead[0]    = COM.ComFunction.Empty_Combo(cmb_factory, "");
			aHead[1]    = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
			aHead[2]    = dpick_from.Text.Replace("-", "");
			aHead[3]    = dpick_to.Text.Replace("-", "");	
			
			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();		
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

		private void Form_BM_Ready_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(_mainSheet.Rows.Count > 0)
			{
				for (int i = 0  ; i < _mainSheet.Rows.Count ; i++)
					if (_mainSheet.Cells[i, 0].Tag  != null)
					{
						if(MessageBox.Show(this, "Exist Modify Data, Do you want to close?","Close", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.No )
							e.Cancel = true;
						break;
					}
			}
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
		}

		private void dpick_to_CloseUp(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
		}

		private void btn_shift_Click(object sender, System.EventArgs e)
		{
			Btn_AutoShift();
		}

		#region 컨텍스트 메뉴

		private void mnu_ShiftDown_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_ShiftDown))
			{
				Shift(_mainSheet.ActiveRow.Index);

				if (_mainSheet.Cells[_mainSheet.ActiveRow.Index, _areaCodeCol].Text.Equals("40"))
					Shift(_mainSheet.ActiveRow.Index - 1);
			}
		}

		#endregion

		#region 입력이동

		#endregion

		#region 버튼효과

		private void btn_shift_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_shift.ImageIndex = 1;
		}

		private void btn_shift_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_shift.ImageIndex = 0;
		}

		#endregion

		#endregion

		#region 공통 메서드

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
			// form initialize
			ClassLib.ComFunction.Init_Form_Control(this);

            lbl_MainTitle.Text = "Shipping Master";
            this.Text = "Shipping Master";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBM_SHIP_MASTER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			
			//입력부 setup
			Init_Combo();
			CheckStatus();
			
			// user define variable set
			_mainSheet	= spd_main.ActiveSheet;
			dpick_from.Value = DateTime.Now.AddMonths(-2);
			dpick_to.Value = DateTime.Now.AddMonths(1);

			for (int vCol = 0 ; vCol < _mainSheet.ColumnCount ; vCol++)
			{
				if (_mainSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim().Equals(_mainSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()))
				{
					_mainSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
				}
				else
				{
					int vCnt  = 0;
					for ( int j = vCol ; j < _mainSheet.ColumnCount ; j++)
					{
						if( vCnt > 0 &&  _mainSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != _mainSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
						{
							_mainSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
							break;
						}
						else if ( _mainSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == _mainSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							vCnt++;
					}
					vCol = vCol + vCnt-1;
				}
			}
		}

		private void Init_Combo()
		{
			try
			{
				DataTable vDt;

				// factory set
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, 40, 125);
				cmb_factory.SelectedValue = (cmb_factory.Tag == null) ? ClassLib.ComVar.This_Factory : cmb_factory.Tag;
				vDt.Dispose();

				// ship type set
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxMRPShipType);
				COM.ComCtl.Set_ComboList(vDt, cmb_ShipType, 1, 2, false);
				cmb_ShipType.SelectedValue = (cmb_ShipType.Tag == null) ? "11" : cmb_ShipType.Tag;
				vDt.Dispose();

				tbtn_Delete.Enabled = false;
				tbtn_Create.Enabled = false;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				spd_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Tbtn_SearchProcess(bool arg_doSearch)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = SELECT_SHIPPING_MASTER();
				spd_main.Display_Grid(vDt);
				Grid_SetColor();

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
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

		private void Grid_SetColor()
		{
			string vStrFore = "";
			string vStrBack = "";

			for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
			{
				vStrFore = _mainSheet.Cells[vRow, _foreColorCol].Text;
				vStrBack = _mainSheet.Cells[vRow, _backColorCol].Text;
				Color vFore = vStrFore.Equals("") ? Color.Black : Color.FromArgb(Convert.ToInt32(vStrFore));
				Color vBack = vStrBack.Equals("") ? Color.White : Color.FromArgb(Convert.ToInt32(vStrBack));

				_mainSheet.Cells[vRow, 1, vRow, _mainSheet.ColumnCount - 1].ForeColor = vFore;
				_mainSheet.Cells[vRow, 1, vRow, _mainSheet.ColumnCount - 1].BackColor = vBack;
			}
		}

		private void Btn_AutoShift()
		{
			string vCurArea = _mainSheet.Cells[_mainSheet.RowCount - 1, _areaCodeCol].Text;
			string vTempArea = "";

			for (int vRow = _mainSheet.RowCount - 1 ; vRow >= 0 ; vRow--)
			{
				vTempArea = _mainSheet.Cells[vRow, _areaCodeCol].Text;

				if (!vCurArea.Equals(vTempArea))
				{
					vCurArea = _mainSheet.Cells[vRow, _areaCodeCol].Text;
					Shift(vRow + 1);
				}
			}

			tbtn_Confirm.Enabled = true;
		}

		#region 컨텍스트 메뉴

		private void Shift(int arg_row)
		{
			_mainSheet.Cells[arg_row, _areaCodeCol].Text = _mainSheet.Cells[arg_row - 1, _areaCodeCol].Text;
			_mainSheet.Cells[arg_row, _areaNameCol].Text = _mainSheet.Cells[arg_row - 1, _areaNameCol].Text;
			_mainSheet.Cells[arg_row, _foreColorCol].Text = _mainSheet.Cells[arg_row - 1, _foreColorCol].Text;
			_mainSheet.Cells[arg_row, _backColorCol].Text = _mainSheet.Cells[arg_row - 1, _backColorCol].Text;
			_mainSheet.Cells[arg_row, _remarksCol].Text = _mainSheet.Cells[arg_row - 1, _remarksCol].Text;

			string vStrFore = _mainSheet.Cells[arg_row, _foreColorCol].Text;
			string vStrBack = _mainSheet.Cells[arg_row, _backColorCol].Text;
			Color vFore = vStrFore.Equals("") ? Color.Black : Color.FromArgb(Convert.ToInt32(vStrFore));
			Color vBack = vStrBack.Equals("") ? Color.White : Color.FromArgb(Convert.ToInt32(vStrBack));

			_mainSheet.Cells[arg_row, 1, arg_row, _mainSheet.ColumnCount - 1].ForeColor = vFore;
			_mainSheet.Cells[arg_row, 1, arg_row, _mainSheet.ColumnCount - 1].BackColor = vBack;
			spd_main.Update_Row(arg_row, img_Action);
		}

		private void mnu_10_Click(object sender, System.EventArgs e)
		{
			FarPoint.Win.Spread.Model.CellRange[] vSel = _mainSheet.GetSelections();
			foreach (CellRange vRange in vSel)
			{
				for (int vRow = vRange.Row ; vRow < vRange.Row + vRange.RowCount ; vRow++)
				{
					_mainSheet.Cells[vRow, _areaCodeCol].Text = "10";
					_mainSheet.Cells[vRow, _areaNameCol].Text = "Finish";
					
					spd_main.Update_Row(vRow, img_Action);
				}
			}
		
		}

		private void mnu_20_Click(object sender, System.EventArgs e)
		{
			FarPoint.Win.Spread.Model.CellRange[] vSel = _mainSheet.GetSelections();
			foreach (CellRange vRange in vSel)
			{
				for (int vRow = vRange.Row ; vRow < vRange.Row + vRange.RowCount ; vRow++)
				{
					_mainSheet.Cells[vRow, _areaCodeCol].Text = "20";
					_mainSheet.Cells[vRow, _areaNameCol].Text = "Shipping";
					
					spd_main.Update_Row(vRow, img_Action);
				}
			}
		
		}

		private void mnu_30_Click(object sender, System.EventArgs e)
		{
			FarPoint.Win.Spread.Model.CellRange[] vSel = _mainSheet.GetSelections();
			foreach (CellRange vRange in vSel)
			{
				for (int vRow = vRange.Row ; vRow < vRange.Row + vRange.RowCount ; vRow++)
				{
					_mainSheet.Cells[vRow, _areaCodeCol].Text = "30";
					_mainSheet.Cells[vRow, _areaNameCol].Text = "Ready";
					
					spd_main.Update_Row(vRow, img_Action);
				}
			}
		
		}

		private void mnu_40_Click(object sender, System.EventArgs e)
		{
			FarPoint.Win.Spread.Model.CellRange[] vSel = _mainSheet.GetSelections();
			foreach (CellRange vRange in vSel)
			{
				for (int vRow = vRange.Row ; vRow < vRange.Row + vRange.RowCount ; vRow++)
				{
					_mainSheet.Cells[vRow, _areaCodeCol].Text = "40";
					_mainSheet.Cells[vRow, _areaNameCol].Text = "Request";
					
					spd_main.Update_Row(vRow, img_Action);
				}
			}
		
		}

		private void mnu_50_Click(object sender, System.EventArgs e)
		{
			FarPoint.Win.Spread.Model.CellRange[] vSel = _mainSheet.GetSelections();
			foreach (CellRange vRange in vSel)
			{
				for (int vRow = vRange.Row ; vRow < vRange.Row + vRange.RowCount ; vRow++)
				{
					_mainSheet.Cells[vRow, _areaCodeCol].Text = "50";
					_mainSheet.Cells[vRow, _areaNameCol].Text = "Free";
					
					spd_main.Update_Row(vRow, img_Action);
				}
			}
		}

		#endregion

		#region 정합성 체크

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

				if (_mainSheet.RowCount <= 0					&& 
					(arg_type == ClassLib.ComVar.Validate_Save	||
					arg_type == _validate_AutoShift				||
					arg_type == _validate_ShiftUp				||
					arg_type == _validate_ShiftDown ))
				{
					ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}

				// 부분별 체크 (Search, Save, Delete, Confirm..)
				switch (arg_type)
				{
					case ClassLib.ComVar.Validate_Search:

						break;
					case ClassLib.ComVar.Validate_Save:					

						break;
					case ClassLib.ComVar.Validate_Delete:

						break;
					case ClassLib.ComVar.Validate_Confirm:
						if (cmb_ShipType.SelectedIndex == -1)
						{
							ClassLib.ComFunction.User_Message("Select Ship Type", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							cmb_ShipType.Focus();
							return false;
						}

						if (ClassLib.ComFunction.DoConfirm(cmb_factory.SelectedValue.ToString(), cmb_ShipType.SelectedValue.ToString(), "40", Convert.ToInt32(_process)) != 1)
							return false;

						int vTemp = -1;
						for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
						{
							if (_mainSheet.Cells[vRow, _areaCodeCol].Text.Equals("40"))
							{
								vTemp = vRow;
								break;
							}
						}
						if (vTemp == -1)
						{
							ClassLib.ComFunction.User_Message("Select Request Section", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
						break;
					case _validate_context:
						int vCurRow = _mainSheet.ActiveRow.Index;

						if (_mainSheet.RowCount <= 0)
						{
							return false;
						}
						if (vCurRow <= 1)
						{
							mnu_ShiftDown.Enabled = false;
						}
						else if (_mainSheet.Cells[vCurRow, _areaCodeCol].Text.Equals(_mainSheet.Cells[vCurRow - 1, _areaCodeCol].Text))
						{
							mnu_ShiftDown.Enabled = false;
						}
						else
						{
							mnu_ShiftDown.Enabled = true;
						}
						break;
					case _validate_AutoShift:

						break;
					case _validate_ShiftDown:
						int vCurRow2 = _mainSheet.ActiveRow.Index - 1;
						string vCurArea = _mainSheet.Cells[_mainSheet.ActiveRow.Index, _areaCodeCol].Text;

						if (!_mainSheet.Cells[_mainSheet.ActiveRow.Index, _areaCodeCol].Text.Equals("40") && !vCurArea.Equals(_mainSheet.Cells[_mainSheet.ActiveRow.Index - 1, _areaCodeCol].Text) && !vCurArea.Equals(_mainSheet.Cells[_mainSheet.ActiveRow.Index + 1, _areaCodeCol].Text))
						{
							ClassLib.ComFunction.User_Message("Can not shift", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
						if (_mainSheet.Cells[_mainSheet.ActiveRow.Index, _areaCodeCol].Text.Equals("40"))
						{
							Shift(_mainSheet.ActiveRow.Index + 1);
						}

						break;
				}

				return true;
			}
			catch
			{
				return false;
			}
		}

		#endregion

		#endregion

		#region 그리드 이벤트
	
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

		#endregion

		#region DB Connect

		/// <summary>
		/// PKG_SBM_READY : Shipping Master 정보 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SHIPPING_MASTER()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_READY.SELECT_SHIPPING_MASTER";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_DATE_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_DATE_TO";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBM_READY : 
		/// </summary>
		public bool SAVE_SHIPPING_MASTER_AREA()
		{

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_READY.SAVE_SHIPPING_MASTER_AREA";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[3] = "ARG_AREA_CODE";
			MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

			//04.DATA 정의
			ArrayList vList = new ArrayList();

			for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
			{
				if (_mainSheet.Cells[vRow, 0].Tag != null)
				{
					vList.Add(_mainSheet.Cells[vRow, _factoryCol].Text);
					vList.Add(_mainSheet.Cells[vRow, _shipTypeCol].Text);
					vList.Add(_mainSheet.Cells[vRow, _mrpShipNoCol].Text);
					vList.Add(_mainSheet.Cells[vRow, _areaCodeCol].Text);
					vList.Add(COM.ComVar.This_User);
				}
			}

			MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

			MyOraDB.Add_Modify_Parameter(true);
			if (MyOraDB.Exe_Modify_Procedure() != null)
				return true;
			else
				return false;
		}

		/// <summary>
		/// PKG_SBM_READY : 
		/// </summary>
		public bool SAVE_SHIPPING_MASTER()
		{

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_MASTER.SAVE_SHIPPING_MASTER";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[3] = "ARG_AREA_CD";
			MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

			//04.DATA 정의
			ArrayList vList = new ArrayList();

			for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
			{
				if (_mainSheet.Cells[vRow, 0].Tag != null)
				{
					vList.Add(_mainSheet.Cells[vRow, _factoryCol].Text);
					vList.Add(_mainSheet.Cells[vRow, _shipTypeCol].Text);
					vList.Add(_mainSheet.Cells[vRow, _mrpShipNoCol].Text);
					vList.Add(_mainSheet.Cells[vRow, _areaCodeCol].Text);
					vList.Add(COM.ComVar.This_User);
				}
			}

			MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

			MyOraDB.Add_Modify_Parameter(true);
			if (MyOraDB.Exe_Modify_Procedure() != null)
				return true;
			else
				return false;
		}

		#endregion

		#region Operation 멤버

		public void CheckStatus()
		{
			// status set
			string vStatus = ClassLib.ComFunction.ProcessStatus(_process, cmb_factory.SelectedValue.ToString(), null);

			// button enable set
			DataTable vDt = ClassLib.ComFunction.SELECT_PROCESS_CHARGE(cmb_factory.SelectedValue.ToString(), _process);
			tbtn_Save.Enabled = ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Save, vStatus);
			tbtn_Confirm.Enabled = ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Confirm, vStatus);

		}

		public bool Confirm()
		{
			if (ClassLib.ComFunction.Essentiality_check(new C1.Win.C1List.C1Combo[]{cmb_factory, cmb_ShipType}, null))
			{
				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vShipType = COM.ComFunction.Empty_Combo(this.cmb_ShipType, "");

				if (ClassLib.ComFunction.SAVE_CHECK_LIST_CONFIRM(_process, vFactory, vShipType, COM.ComVar.This_User, true))
				{
					ClassLib.ComFunction.User_Message("Confirm complete", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
					tbtn_Confirm.Enabled = false;
					return true;
				}
			}

			return false;
		}

		public void RunProcess(string arg_factory, string arg_ShipType, string arg_mrpNo, string arg_PlanStart, string arg_PlanEnd)
		{
			cmb_factory.Tag = arg_factory;
			cmb_ShipType.Tag = arg_ShipType;

			//Tbtn_SearchProcess(true);
		}

		public int GetSearchRows()
		{
			return spd_main.ActiveSheet.RowCount;
		}
		
		#endregion

	}
}

