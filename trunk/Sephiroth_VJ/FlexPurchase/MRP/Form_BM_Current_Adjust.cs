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
	public class Form_BM_Current_Adjust : COM.PCHWinForm.Form_Top
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
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_Data;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_useDivide;
		private System.Windows.Forms.MenuItem mnu_mrp;
		private System.Windows.Forms.MenuItem mnu_local;
		private System.Windows.Forms.MenuItem mnu_notUse;
		private C1.Win.C1List.C1Combo cmb_ObsType;
		private C1.Win.C1List.C1Combo cmb_ShipType;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.TextBox txt_lotNo;
		private System.Windows.Forms.TextBox txt_lotSeq;
		private System.Windows.Forms.Label lbl_lot;
		private System.Windows.Forms.Label lbl_obsType;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.Label lbl_shipType;
		private System.Windows.Forms.Label lbl_planStart;
		private System.Windows.Forms.Label btn_autoNo;
		private System.Windows.Forms.Label btn_runMRP;
		private FarPoint.Win.Spread.SheetView _mainSheet = null;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private Hashtable _cellTypes = null;
		private const int _validate_AutoMRPShipNo = 10, _validate_RunMRP = 20;
		
		#endregion

		#region 생성자 / 소멸자

		public Form_BM_Current_Adjust()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BM_Current_Adjust));
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
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_runMRP = new System.Windows.Forms.Label();
            this.btn_autoNo = new System.Windows.Forms.Label();
            this.txt_lotSeq = new System.Windows.Forms.TextBox();
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.txt_lotNo = new System.Windows.Forms.TextBox();
            this.lbl_lot = new System.Windows.Forms.Label();
            this.cmb_ObsType = new C1.Win.C1List.C1Combo();
            this.lbl_obsType = new System.Windows.Forms.Label();
            this.lbl_style = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.cmb_ShipType = new C1.Win.C1List.C1Combo();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_planStart = new System.Windows.Forms.Label();
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
            this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
            this.mnu_Data = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_useDivide = new System.Windows.Forms.MenuItem();
            this.mnu_mrp = new System.Windows.Forms.MenuItem();
            this.mnu_local = new System.Windows.Forms.MenuItem();
            this.mnu_notUse = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ObsType)).BeginInit();
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
            this.c1Sizer1.GridDefinition = "19.9652777777778:False:True;79.3402777777778:False:False;\t0.393700787401575:False" +
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
            this.pnl_head.Controls.Add(this.btn_runMRP);
            this.pnl_head.Controls.Add(this.btn_autoNo);
            this.pnl_head.Controls.Add(this.txt_lotSeq);
            this.pnl_head.Controls.Add(this.cmb_StyleCd);
            this.pnl_head.Controls.Add(this.txt_StyleCd);
            this.pnl_head.Controls.Add(this.txt_lotNo);
            this.pnl_head.Controls.Add(this.lbl_lot);
            this.pnl_head.Controls.Add(this.cmb_ObsType);
            this.pnl_head.Controls.Add(this.lbl_obsType);
            this.pnl_head.Controls.Add(this.lbl_style);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.cmb_ShipType);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.lbl_planStart);
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
            this.pnl_head.Size = new System.Drawing.Size(1000, 115);
            this.pnl_head.TabIndex = 0;
            // 
            // btn_runMRP
            // 
            this.btn_runMRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_runMRP.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_runMRP.ImageIndex = 0;
            this.btn_runMRP.ImageList = this.img_Button;
            this.btn_runMRP.Location = new System.Drawing.Point(898, 84);
            this.btn_runMRP.Name = "btn_runMRP";
            this.btn_runMRP.Size = new System.Drawing.Size(80, 23);
            this.btn_runMRP.TabIndex = 535;
            this.btn_runMRP.Text = "Run MRP";
            this.btn_runMRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_runMRP.Click += new System.EventHandler(this.btn_runMRP_Click);
            this.btn_runMRP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_runMRP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_autoNo
            // 
            this.btn_autoNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_autoNo.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_autoNo.ImageIndex = 0;
            this.btn_autoNo.ImageList = this.img_Button;
            this.btn_autoNo.Location = new System.Drawing.Point(817, 84);
            this.btn_autoNo.Name = "btn_autoNo";
            this.btn_autoNo.Size = new System.Drawing.Size(80, 23);
            this.btn_autoNo.TabIndex = 535;
            this.btn_autoNo.Text = "Auto Number";
            this.btn_autoNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_autoNo.Click += new System.EventHandler(this.btn_autoNo_Click);
            this.btn_autoNo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_autoNo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // txt_lotSeq
            // 
            this.txt_lotSeq.BackColor = System.Drawing.Color.White;
            this.txt_lotSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lotSeq.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_lotSeq.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_lotSeq.Location = new System.Drawing.Point(898, 62);
            this.txt_lotSeq.MaxLength = 10;
            this.txt_lotSeq.Name = "txt_lotSeq";
            this.txt_lotSeq.Size = new System.Drawing.Size(79, 21);
            this.txt_lotSeq.TabIndex = 533;
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AccessibleDescription = "";
            this.cmb_StyleCd.AccessibleName = "";
            this.cmb_StyleCd.AddItemCols = 0;
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style1;
            this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_StyleCd.ColumnCaptionHeight = 18;
            this.cmb_StyleCd.ColumnFooterHeight = 18;
            this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_StyleCd.ContentHeight = 17;
            this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_StyleCd.EditorHeight = 17;
            this.cmb_StyleCd.EvenRowStyle = style2;
            this.cmb_StyleCd.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StyleCd.FooterStyle = style3;
            this.cmb_StyleCd.GapHeight = 2;
            this.cmb_StyleCd.HeadingStyle = style4;
            this.cmb_StyleCd.HighLightRowStyle = style5;
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(838, 40);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style6;
            this.cmb_StyleCd.PartialRightColumn = false;
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style7;
            this.cmb_StyleCd.Size = new System.Drawing.Size(139, 21);
            this.cmb_StyleCd.Style = style8;
            this.cmb_StyleCd.TabIndex = 534;
            this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.White;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleCd.Location = new System.Drawing.Point(767, 40);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(70, 21);
            this.txt_StyleCd.TabIndex = 533;
            this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
            // 
            // txt_lotNo
            // 
            this.txt_lotNo.BackColor = System.Drawing.Color.White;
            this.txt_lotNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lotNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_lotNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_lotNo.Location = new System.Drawing.Point(767, 62);
            this.txt_lotNo.MaxLength = 10;
            this.txt_lotNo.Name = "txt_lotNo";
            this.txt_lotNo.Size = new System.Drawing.Size(130, 21);
            this.txt_lotNo.TabIndex = 533;
            // 
            // lbl_lot
            // 
            this.lbl_lot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_lot.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lot.ImageIndex = 0;
            this.lbl_lot.ImageList = this.img_Label;
            this.lbl_lot.Location = new System.Drawing.Point(666, 62);
            this.lbl_lot.Name = "lbl_lot";
            this.lbl_lot.Size = new System.Drawing.Size(100, 21);
            this.lbl_lot.TabIndex = 410;
            this.lbl_lot.Text = "Lot No";
            this.lbl_lot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ObsType
            // 
            this.cmb_ObsType.AddItemCols = 0;
            this.cmb_ObsType.AddItemSeparator = ';';
            this.cmb_ObsType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_ObsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ObsType.Caption = "";
            this.cmb_ObsType.CaptionHeight = 17;
            this.cmb_ObsType.CaptionStyle = style9;
            this.cmb_ObsType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ObsType.ColumnCaptionHeight = 18;
            this.cmb_ObsType.ColumnFooterHeight = 18;
            this.cmb_ObsType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ObsType.ContentHeight = 16;
            this.cmb_ObsType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ObsType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ObsType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_ObsType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ObsType.EditorHeight = 16;
            this.cmb_ObsType.EvenRowStyle = style10;
            this.cmb_ObsType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_ObsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ObsType.FooterStyle = style11;
            this.cmb_ObsType.GapHeight = 2;
            this.cmb_ObsType.HeadingStyle = style12;
            this.cmb_ObsType.HighLightRowStyle = style13;
            this.cmb_ObsType.ItemHeight = 15;
            this.cmb_ObsType.Location = new System.Drawing.Point(438, 62);
            this.cmb_ObsType.MatchEntryTimeout = ((long)(2000));
            this.cmb_ObsType.MaxDropDownItems = ((short)(5));
            this.cmb_ObsType.MaxLength = 32767;
            this.cmb_ObsType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ObsType.Name = "cmb_ObsType";
            this.cmb_ObsType.OddRowStyle = style14;
            this.cmb_ObsType.PartialRightColumn = false;
            this.cmb_ObsType.PropBag = resources.GetString("cmb_ObsType.PropBag");
            this.cmb_ObsType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ObsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ObsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ObsType.SelectedStyle = style15;
            this.cmb_ObsType.Size = new System.Drawing.Size(210, 20);
            this.cmb_ObsType.Style = style16;
            this.cmb_ObsType.TabIndex = 408;
            // 
            // lbl_obsType
            // 
            this.lbl_obsType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obsType.ImageIndex = 0;
            this.lbl_obsType.ImageList = this.img_Label;
            this.lbl_obsType.Location = new System.Drawing.Point(337, 62);
            this.lbl_obsType.Name = "lbl_obsType";
            this.lbl_obsType.Size = new System.Drawing.Size(100, 21);
            this.lbl_obsType.TabIndex = 409;
            this.lbl_obsType.Text = "Order Type";
            this.lbl_obsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(666, 40);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 410;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // cmb_ShipType
            // 
            this.cmb_ShipType.AddItemCols = 0;
            this.cmb_ShipType.AddItemSeparator = ';';
            this.cmb_ShipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_ShipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ShipType.Caption = "";
            this.cmb_ShipType.CaptionHeight = 17;
            this.cmb_ShipType.CaptionStyle = style17;
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
            this.cmb_ShipType.EvenRowStyle = style18;
            this.cmb_ShipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ShipType.FooterStyle = style19;
            this.cmb_ShipType.GapHeight = 2;
            this.cmb_ShipType.HeadingStyle = style20;
            this.cmb_ShipType.HighLightRowStyle = style21;
            this.cmb_ShipType.ItemHeight = 15;
            this.cmb_ShipType.Location = new System.Drawing.Point(438, 40);
            this.cmb_ShipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_ShipType.MaxDropDownItems = ((short)(5));
            this.cmb_ShipType.MaxLength = 32767;
            this.cmb_ShipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ShipType.Name = "cmb_ShipType";
            this.cmb_ShipType.OddRowStyle = style22;
            this.cmb_ShipType.PartialRightColumn = false;
            this.cmb_ShipType.PropBag = resources.GetString("cmb_ShipType.PropBag");
            this.cmb_ShipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ShipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.SelectedStyle = style23;
            this.cmb_ShipType.Size = new System.Drawing.Size(210, 20);
            this.cmb_ShipType.Style = style24;
            this.cmb_ShipType.TabIndex = 5;
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 1;
            this.lbl_shipType.ImageList = this.img_Label;
            this.lbl_shipType.Location = new System.Drawing.Point(337, 40);
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
            this.pic_head3.Location = new System.Drawing.Point(984, 99);
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
            // 
            // lbl_planStart
            // 
            this.lbl_planStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_planStart.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_planStart.ImageIndex = 1;
            this.lbl_planStart.ImageList = this.img_Label;
            this.lbl_planStart.Location = new System.Drawing.Point(8, 62);
            this.lbl_planStart.Name = "lbl_planStart";
            this.lbl_planStart.Size = new System.Drawing.Size(100, 21);
            this.lbl_planStart.TabIndex = 50;
            this.lbl_planStart.Text = "Date";
            this.lbl_planStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 98);
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
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
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
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
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
            this.pic_head7.Size = new System.Drawing.Size(101, 74);
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
            this.label2.Text = "      Lot Info";
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
            this.pic_head5.Location = new System.Drawing.Point(0, 99);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 88);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.White;
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(8, 119);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1000, 457);
            this.pnl_main.TabIndex = 1;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(1000, 457);
            this.spd_main.TabIndex = 0;
            this.spd_main.EditModeOff += new System.EventHandler(this.spd_main_EditModeOff);
            this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // ctx_tail
            // 
            this.ctx_tail.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_AllSelect,
            this.mnu_Data,
            this.menuItem1,
            this.mnu_useDivide});
            // 
            // mnu_AllSelect
            // 
            this.mnu_AllSelect.Index = 0;
            this.mnu_AllSelect.Text = "All Select";
            // 
            // mnu_Data
            // 
            this.mnu_Data.Index = 1;
            this.mnu_Data.Text = "Value Change";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // mnu_useDivide
            // 
            this.mnu_useDivide.Index = 3;
            this.mnu_useDivide.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_mrp,
            this.mnu_local,
            this.mnu_notUse});
            this.mnu_useDivide.Text = "Use Divide";
            // 
            // mnu_mrp
            // 
            this.mnu_mrp.Index = 0;
            this.mnu_mrp.Text = "MRP";
            // 
            // mnu_local
            // 
            this.mnu_local.Index = 1;
            this.mnu_local.Text = "Local";
            // 
            // mnu_notUse
            // 
            this.mnu_notUse.Index = 2;
            this.mnu_notUse.Text = "Not Using";
            // 
            // Form_BM_Current_Adjust
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BM_Current_Adjust";
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
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ObsType)).EndInit();
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

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (SAVE_SBM_CURRENT_ADJUST())
					{
						spd_main.Refresh_Division();
						ClassLib.ComFunction.User_Message("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
					}
					else
					{
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
					}
				}
			}
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
			{
				if (MessageBox.Show(this, "Do you want to confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{

				}
			}
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

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
		}

		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				//-------------------------------------------------------------------------
				// 기타 콘트롤 초기화 
				cmb_StyleCd.SelectedIndex = -1;
				DataTable dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ") ); 
				 
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				COM.ComCtl.Set_ComboList(dt_ret, cmb_StyleCd, 0, 1, false, 70, 140); 
				cmb_StyleCd.SelectedValue = txt_StyleCd.Text;

				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;
				txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_autoNo_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_AutoMRPShipNo))
			{
				if (MessageBox.Show(this, "Do you want to MRP Ship Number auto setting?", "Auto Set", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					AutoMRPShipNoSetting();
				}
			}
		}

		private void btn_runMRP_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_RunMRP))
			{
				if (MessageBox.Show(this, "Do you want to Run MRP Process?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					RunMRPProcess();
				}
			}
		}

		#region 입력이동

		#endregion

		#region 버튼효과

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		#endregion

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form initialize
			// ClassLib.ComFunction.Init_Form_Control(this);

			lbl_MainTitle.Text = "Urgent Shipping";
			this.Text		   = "Urgent Shipping";

            ClassLib.ComFunction.SetLangDic(this);


			// grid set
			spd_main.Set_Spread_Comm("SBM_CURRENT_ADJUST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			
			//입력부 setup
			Init_Combo();
			
			// user define variable set
			_mainSheet	= spd_main.ActiveSheet;
			_cellTypes	= new Hashtable();

			for (int vCount = 1 ; vCount < _mainSheet.Columns.Count ; vCount++)
				if (_mainSheet.Columns[vCount].CellType.ToString().Equals(ClassLib.ComVar.SSPComboBoxCell))
				{
					COM.SSPComboBoxCellType sspBox = (COM.SSPComboBoxCellType)_mainSheet.Columns[vCount].CellType; 
					_cellTypes.Add(vCount, sspBox.DataSourceWithCode);
				}

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
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
				COM.ComCtl.Set_ComboList(vDt, cmb_ShipType, 1, 2, false);
				cmb_ShipType.SelectedIndex = 0;
				vDt.Dispose();

				// obs type set
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxOBSType);
				COM.ComCtl.Set_ComboList(vDt, cmb_ObsType, 1, 2, true);
				cmb_ObsType.SelectedIndex = 0;
				vDt.Dispose();

				tbtn_Save.Enabled = false;
				tbtn_Delete.Enabled = false;
				tbtn_Print.Enabled = false;
				tbtn_Create.Enabled = false;
				tbtn_Confirm.Enabled = false;
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

				DataTable vDt = SELECT_LOT_INFORMATION();

				if (vDt.Rows.Count > 0)
				{
					spd_main.ActiveSheet.RowCount = 0;
					spd_main.Display_Grid(vDt);
				}
				else
				{
					spd_main.ClearAll();
				}

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
			int vPlanYmdCol = (int)ClassLib.TBSBM_READY_ORDER.IxREQ_NO;

			for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
			{
				switch (_mainSheet.Cells[vRow, vPlanYmdCol].Text)
				{
					case null :
						_mainSheet.Cells[vRow, 1, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightPink2;
						break;
					default :
						_mainSheet.Cells[vRow, 1, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightBlue;
						break;
				}
			}
		}

		private void AutoMRPShipNoSetting()
		{
			try
			{
				for (int vRow = 0 ; vRow < spd_main.ActiveSheet.RowCount ; vRow++)
				{
					if (Convert.ToBoolean(ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[vRow, 1].Value, "false")))
					{
						string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
						string vShipType = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
						string vLotNo = ClassLib.ComFunction.NullToBlank(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxLOT_NO].Value);
						string vLotSeq = ClassLib.ComFunction.NullToBlank(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxLOT_SEQ].Value);

						DataTable vDt = SELECT_MRP_SHIPPING_NO(vFactory, vShipType, vLotNo, vLotSeq);

						if (vDt.Rows.Count > 0)
						{
							spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxMRP_SHIP_NO].Value	= vDt.Rows[0][0].ToString();
							spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxAREA_NAME].Value		= vDt.Rows[0][1].ToString();
							Color vBackColor = Color.FromArgb(Convert.ToInt32(vDt.Rows[0][2].ToString()));
							spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxMRP_SHIP_NO, vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxAREA_NAME].BackColor = vBackColor;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Auto Mrp No Setting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void RunMRPProcess()
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (!SAVE_SBM_CURRENT_ADJUST())
					{
						return;
					}
					
					if (!RUN_SHIPPING_ADJUST())
					{
						return;
					}

					
					spd_main.Refresh_Division();
					ClassLib.ComFunction.User_Message("Run MRP Process Complete", "Run MRP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
			}
		}

		private bool Etc_ProvisoValidateCheck(int arg_type)
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
				case ClassLib.ComVar.Validate_Save:	// Run MRP 버튼
					int vBeforeQtyCol = (int)ClassLib.TBSBM_CURRENT_ADJUST.IxBEFORE_QTY;

					for (int vRow = 0 ; vRow < spd_main.ActiveSheet.RowCount ; vRow++)
					{
						if (Convert.ToBoolean(ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[vRow, 1].Value, "false")))
						{
						
							string vShipQty = ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxSHIP_QTY].Text, "0");
							string vMrpNo = ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxMRP_SHIP_NO].Text, "");
							spd_main.ActiveSheet.ClearSelection();

							if (vShipQty.Equals("0") || vShipQty.Equals(""))
							{
								ClassLib.ComFunction.User_Message("Input Ship Q`ty", "Run", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								spd_main.ActiveSheet.SetActiveCell(vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxSHIP_QTY);
								spd_main.ActiveSheet.AddSelection(vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxSHIP_QTY, 1, 1);
								return false;
							}

							if (vMrpNo.Equals(""))
							{
								ClassLib.ComFunction.User_Message("Select MRP Ship No", "Run", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								spd_main.ActiveSheet.SetActiveCell(vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxMRP_SHIP_NO);
								spd_main.ActiveSheet.AddSelection(vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxMRP_SHIP_NO, 1, 1);
								return false;
							}

							if (spd_main.ActiveSheet.Cells[vRow, 1, vRow, vBeforeQtyCol].ForeColor.ToArgb() == Color.Red.ToArgb())
							{
								ClassLib.ComFunction.User_Message("Invalidate Qty", "Run", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								spd_main.ActiveSheet.SetActiveCell(vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxSHIP_QTY);
								spd_main.ActiveSheet.AddSelection(vRow, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxSHIP_QTY, 1, 1);
								return false;
							}
						}
					}
					break;
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:

					break;
				case _validate_AutoMRPShipNo:
					if (spd_main.ActiveSheet.RowCount <= 0)
					{
						ClassLib.ComFunction.User_Message("Data Not Found", "Auto MRP Ship No", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}

					break;
				case _validate_RunMRP:

					break;

			}

			return true;
		}

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

		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader && e.Column == (int)ClassLib.TBSBM_CURRENT_ADJUST.IxMRP_SHIP_NO)
			{
				COM.ComVar.Parameter_PopUp = new string[8];
				COM.ComVar.Parameter_PopUp[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				COM.ComVar.Parameter_PopUp[1] = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
				COM.ComVar.Parameter_PopUp[2] = spd_main.ActiveSheet.Cells[e.Row, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxLOT_NO].Text;
				COM.ComVar.Parameter_PopUp[3] = spd_main.ActiveSheet.Cells[e.Row, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxLOT_SEQ].Text;
				COM.ComVar.Parameter_PopUp[4] = spd_main.ActiveSheet.Cells[e.Row, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxSTYLE_CD].Text;
				COM.ComVar.Parameter_PopUp[5] = dpick_from.Text.Replace("-", "");
				COM.ComVar.Parameter_PopUp[6] = dpick_to.Text.Replace("-", "");

				Pop_BM_MRP_Ship_No_List vPop = new Pop_BM_MRP_Ship_No_List();
				if (vPop.ShowDialog() == DialogResult.OK)
					spd_main.ActiveSheet.Cells[e.Row, (int)ClassLib.TBSBM_CURRENT_ADJUST.IxMRP_SHIP_NO].Text = COM.ComVar.Parameter_PopUp[0];
			}
		}

		private void spd_main_EditModeOff(object sender, System.EventArgs e)
		{
			Cell vCell		= spd_main.ActiveSheet.ActiveCell;

			if (vCell.Column.Index == (int)ClassLib.TBSBM_CURRENT_ADJUST.IxSHIP_QTY)
			{
				int vLotQtyCol	= (int)ClassLib.TBSBM_CURRENT_ADJUST.IxLOT_QTY;
				int vLossQtyCol	= (int)ClassLib.TBSBM_CURRENT_ADJUST.IxLOSS_QTY;
				int vBeforeQtyCol	= (int)ClassLib.TBSBM_CURRENT_ADJUST.IxBEFORE_QTY;

				int vCurQty		= Convert.ToInt32(ClassLib.ComFunction.NullCheck(vCell.Value, "0"));
				int vLotQty		= Convert.ToInt32(ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[vCell.Row.Index, vLotQtyCol].Value, "0"));
				int vLossQty	= Convert.ToInt32(ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[vCell.Row.Index, vLossQtyCol].Value, "0"));
				int vBeforeQty	= Convert.ToInt32(ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[vCell.Row.Index, vBeforeQtyCol].Value, "0"));

				if ((vLotQty + vLossQty) < (vCurQty + vBeforeQty))
					spd_main.ActiveSheet.Cells[vCell.Row.Index, 1, vCell.Row.Index, vBeforeQtyCol].ForeColor = Color.Red;
				else
					spd_main.ActiveSheet.Cells[vCell.Row.Index, 1, vCell.Row.Index, vBeforeQtyCol].ForeColor = Color.Black;
			}
		}

		#endregion

		#region DB Connect

		/// <summary>
		/// PKG_SBM_CURRENT_ADJUST : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_LOT_INFORMATION()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_CURRENT_ADJUST.SELECT_LOT_INFORMATION";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_DATE_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_DATE_TO";
			MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[5] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[6] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[7] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = dpick_to.Text.Replace("-", "");
			if (cmb_StyleCd.SelectedIndex == -1)
				MyOraDB.Parameter_Values[3] = txt_StyleCd.Text.Replace("-", "").Trim();
			else
				MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_StyleCd, "");
			MyOraDB.Parameter_Values[4] = txt_lotNo.Text.Trim();
			MyOraDB.Parameter_Values[5] = txt_lotSeq.Text.Trim();
			MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_Combo(cmb_ObsType, "");
			MyOraDB.Parameter_Values[7] = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
			MyOraDB.Parameter_Values[8] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// SELECT_MRP_SHIPPING_NO : Auto Number 기능
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_MRP_SHIPPING_NO(string arg_factory, string arg_ship_type, string arg_lot_no, string arg_lot_seq)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_CURRENT_ADJUST.SELECT_MRP_SHIPPING_NO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_ship_type;
			MyOraDB.Parameter_Values[2] = arg_lot_no;
			MyOraDB.Parameter_Values[3] = arg_lot_seq;
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBM_CURRENT_ADJUST : Run MRP 전에 임시 테이블에 데이터 저장
		/// </summary>
		public bool SAVE_SBM_CURRENT_ADJUST()
		{
			try
			{
				MyOraDB.ReDim_Parameter(25);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_CURRENT_ADJUST.SAVE_SBM_CURRENT_ADJUST";

				//02.ARGURMENT 명
				int i = 0;

				MyOraDB.Parameter_Name[i]	= "ARG_DIVISION";
				MyOraDB.Parameter_Type[i++] = (int)OracleType.VarChar;
				for ( ; i < spd_main.ActiveSheet.ColumnCount ; i++)
				{
					MyOraDB.Parameter_Name[i] = "ARG_" + spd_main.ActiveSheet.ColumnHeader.Cells[0, i].Text;
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}
				MyOraDB.Parameter_Name[i]	= "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Type[i++] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Name[i]	= "ARG_UPD_USER";
				MyOraDB.Parameter_Type[i++] = (int)OracleType.VarChar;

				//04.DATA 정의
				ArrayList vList = new ArrayList();
				string vShipType = COM.ComFunction.Empty_Combo(cmb_ShipType, "");

				//Delete
				vList.Add(ClassLib.ComVar.Delete);
				vList.AddRange(new string[24]);

				//Insert 
				for (int vRow = 0 ; vRow < spd_main.ActiveSheet.RowCount ; vRow++)
				{
					if (Convert.ToBoolean(ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[vRow, 1].Value, "false")))
					{
						vList.Add(ClassLib.ComVar.Insert);

						int vCol = 1;
				
						while (vCol < spd_main.ActiveSheet.ColumnCount)
						{
							vList.Add(ClassLib.ComFunction.NullToBlank(spd_main.ActiveSheet.Cells[vRow, vCol].Value));
							vCol++;
						}
						vList.Add(vShipType);
						vList.Add(COM.ComVar.This_User);
					}
				}

				if (vList.Count == 0)
					return false;

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);

				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}


		/// <summary>
		/// RUN_SHIPPING_ADJUST : Run Shipping Adjust
		/// </summary>
		public bool RUN_SHIPPING_ADJUST()
		{
			try
			{
				MyOraDB.ReDim_Parameter(2);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_CURRENT_ADJUST.RUN_SHIPPING_ADJUST";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(false);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;

				return true;
			}
			catch (Exception ex)
			{
                ClassLib.ComFunction.User_Message(ex.Message, "Run MRP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}


		#endregion

	}
}

