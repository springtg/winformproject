using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexMRP.MRP
{
	public class Form_BM_Shipping_Confirm : COM.PCHWinForm.Form_Top, IOperation
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
		private System.Windows.Forms.Label lbl_ymd;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label label1;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.MenuItem mnu_size;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_findData;
		private System.Windows.Forms.MenuItem menuItem2;
		private C1.Win.C1List.C1Combo cmb_ObsType;
		private System.Windows.Forms.Label lbl_ObsType;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_advice;
		private System.Windows.Forms.MenuItem mnu_all;
		private System.Windows.Forms.MenuItem mnu_remarks;
		private System.Windows.Forms.MenuItem menuItem4;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버

		private string _process		= (int)ClassLib.ComVar.MRPProcessNum.ShippingConfirm + "";
		private COM.OraDB MyOraDB	= new COM.OraDB();
		private ArrayList _columnIndex	= new ArrayList();
		private Pop_Finder finder;

		private int _mrpShipNoRow	= 4;
		private int _lotNoCol		= (int)ClassLib.TBSBM_SHIP_CONFIRM.IxLOT_NO;
		private int _lotSeqCol		= (int)ClassLib.TBSBM_SHIP_CONFIRM.IxLOT_SEQ;
		private int _styleCodeCol	= (int)ClassLib.TBSBM_SHIP_CONFIRM.IxSTYLE_CD;

		private string _airFlag = "A", _silhouetteFlag = "S", _jitFlag = "J";

		private Color vAirColor;
		private Color vSilhouetteColor;
		private Color vJitColor;

		private Color _newStyleColor;

		private const int _validate_remarks = 30;


		#endregion

		#region 생성자 / 소멸자

		public Form_BM_Shipping_Confirm()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BM_Shipping_Confirm));
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
            this.txt_status = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cmb_ObsType = new C1.Win.C1List.C1Combo();
            this.lbl_ObsType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_ymd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.ctx_main = new System.Windows.Forms.ContextMenu();
            this.mnu_remarks = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnu_findData = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnu_size = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_advice = new System.Windows.Forms.MenuItem();
            this.mnu_all = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ObsType)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "15.9722222222222:False:True;81.9444444444444:False:False;0.694444444444444:False:" +
                "True;\t0.393700787401575:False:True;98.4251968503937:False:False;0.39370078740157" +
                "5:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(8, 96);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
            this.fgrid_main.Size = new System.Drawing.Size(1000, 472);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 3;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.txt_status);
            this.pnl_head.Controls.Add(this.lbl_status);
            this.pnl_head.Controls.Add(this.cmb_ObsType);
            this.pnl_head.Controls.Add(this.lbl_ObsType);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_ymd);
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
            this.pnl_head.Size = new System.Drawing.Size(1000, 92);
            this.pnl_head.TabIndex = 2;
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
            this.txt_status.TabIndex = 419;
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
            this.lbl_status.TabIndex = 418;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ObsType
            // 
            this.cmb_ObsType.AddItemCols = 0;
            this.cmb_ObsType.AddItemSeparator = ';';
            this.cmb_ObsType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_ObsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ObsType.Caption = "";
            this.cmb_ObsType.CaptionHeight = 17;
            this.cmb_ObsType.CaptionStyle = style1;
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
            this.cmb_ObsType.EvenRowStyle = style2;
            this.cmb_ObsType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_ObsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ObsType.FooterStyle = style3;
            this.cmb_ObsType.GapHeight = 2;
            this.cmb_ObsType.HeadingStyle = style4;
            this.cmb_ObsType.HighLightRowStyle = style5;
            this.cmb_ObsType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_ObsType.ItemHeight = 15;
            this.cmb_ObsType.Location = new System.Drawing.Point(431, 62);
            this.cmb_ObsType.MatchEntryTimeout = ((long)(2000));
            this.cmb_ObsType.MaxDropDownItems = ((short)(5));
            this.cmb_ObsType.MaxLength = 32767;
            this.cmb_ObsType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ObsType.Name = "cmb_ObsType";
            this.cmb_ObsType.OddRowStyle = style6;
            this.cmb_ObsType.PartialRightColumn = false;
            this.cmb_ObsType.PropBag = resources.GetString("cmb_ObsType.PropBag");
            this.cmb_ObsType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ObsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ObsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ObsType.SelectedStyle = style7;
            this.cmb_ObsType.Size = new System.Drawing.Size(210, 20);
            this.cmb_ObsType.Style = style8;
            this.cmb_ObsType.TabIndex = 402;
            // 
            // lbl_ObsType
            // 
            this.lbl_ObsType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ObsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ObsType.ImageIndex = 0;
            this.lbl_ObsType.ImageList = this.img_Label;
            this.lbl_ObsType.Location = new System.Drawing.Point(330, 62);
            this.lbl_ObsType.Name = "lbl_ObsType";
            this.lbl_ObsType.Size = new System.Drawing.Size(100, 21);
            this.lbl_ObsType.TabIndex = 403;
            this.lbl_ObsType.Text = "Obs Type";
            this.lbl_ObsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(207, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 396;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label2.Text = "      Shipping Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 62);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(95, 21);
            this.dpick_from.TabIndex = 394;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(225, 62);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(95, 21);
            this.dpick_to.TabIndex = 395;
            // 
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemCols = 0;
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style9;
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
            this.cmb_shipType.EvenRowStyle = style10;
            this.cmb_shipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style11;
            this.cmb_shipType.GapHeight = 2;
            this.cmb_shipType.HeadingStyle = style12;
            this.cmb_shipType.HighLightRowStyle = style13;
            this.cmb_shipType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(431, 40);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style14;
            this.cmb_shipType.PartialRightColumn = false;
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style15;
            this.cmb_shipType.Size = new System.Drawing.Size(210, 20);
            this.cmb_shipType.Style = style16;
            this.cmb_shipType.TabIndex = 5;
            this.cmb_shipType.SelectedValueChanged += new System.EventHandler(this.cmb_shipType_SelectedValueChanged);
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 1;
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
            this.pic_head3.Location = new System.Drawing.Point(984, 76);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_ymd
            // 
            this.lbl_ymd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ymd.ImageIndex = 1;
            this.lbl_ymd.ImageList = this.img_Label;
            this.lbl_ymd.Location = new System.Drawing.Point(8, 62);
            this.lbl_ymd.Name = "lbl_ymd";
            this.lbl_ymd.Size = new System.Drawing.Size(100, 21);
            this.lbl_ymd.TabIndex = 50;
            this.lbl_ymd.Text = "Date";
            this.lbl_ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
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
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style24;
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
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 74);
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
            this.mnu_remarks,
            this.menuItem4,
            this.mnu_findData,
            this.menuItem2,
            this.mnu_size,
            this.menuItem1});
            // 
            // mnu_remarks
            // 
            this.mnu_remarks.Index = 0;
            this.mnu_remarks.Text = "Remarks";
            this.mnu_remarks.Click += new System.EventHandler(this.mnu_Remarks_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // mnu_findData
            // 
            this.mnu_findData.Index = 2;
            this.mnu_findData.Text = "Find Data";
            this.mnu_findData.Click += new System.EventHandler(this.mnu_findData_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "-";
            // 
            // mnu_size
            // 
            this.mnu_size.Index = 4;
            this.mnu_size.Text = "Size Information";
            this.mnu_size.Click += new System.EventHandler(this.mnu_size_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 5;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_advice,
            this.mnu_all});
            this.menuItem1.Text = "Tree View Option";
            // 
            // mnu_advice
            // 
            this.mnu_advice.Index = 0;
            this.mnu_advice.Text = "Advice";
            this.mnu_advice.Click += new System.EventHandler(this.mnu_advice_Click);
            // 
            // mnu_all
            // 
            this.mnu_all.Index = 1;
            this.mnu_all.Text = "All";
            this.mnu_all.Click += new System.EventHandler(this.mnu_all_Click);
            // 
            // Form_BM_Shipping_Confirm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BM_Shipping_Confirm";
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ObsType)).EndInit();
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
			{
				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (SAVE_SHIPPING_CONFIRM_UPDATE())
					{
						fgrid_main.Refresh_Division();
						ClassLib.ComFunction.User_Message("Confirm complete", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}				
			}		
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            DataTable vDT;

			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
			{
				if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
				{
					if (MessageBox.Show(this, "Do you want to confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
                        vDT = SAVE_SHIPPING_CONFIRM();


                        if (vDT.Rows[0].ItemArray[0].ToString() == "Y")
                            Confirm();
                        else
                        {

                            Pop_BM_Shipping_Confirm vPop = new Pop_BM_Shipping_Confirm(vDT);
			                vPop.ShowDialog();


                            txt_status.Text = "Save";
                            tbtn_Save.Enabled = true;
                            tbtn_Confirm.Enabled = true;

                            ClassLib.ComFunction.User_Message("MPS Check!!.Now you can't confirm shipping schedule.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
					}				
				}
				else
				{
					ClassLib.ComFunction.User_Message("No Data.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Print))
				Tbtn_PrintProcess();
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
			try
			{
				CheckStatus();
				fgrid_main.ClearAll();
			}
			catch //(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Set Factory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void cmb_shipType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			CheckStatus();
			fgrid_main.ClearAll();
		}


		#endregion 

		#region Validate Check

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (cmb_factory.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}

			if (cmb_shipType.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Ship Type", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_shipType.Focus();
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
					if (cmb_shipType.SelectedIndex == -1)
					{
						ClassLib.ComFunction.User_Message("Select ShipType", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}

					string vFactory = cmb_factory.SelectedValue.ToString();
					string vShipType = cmb_shipType.SelectedValue.ToString();
					if (ClassLib.ComFunction.DoConfirm(vFactory, vShipType, "40", Convert.ToInt32(_process)) != 1)
						return false;

					break;
				case _validate_remarks:
					if (fgrid_main.Rows[fgrid_main.Row].Node.Level != 1 || fgrid_main.Col < fgrid_main.Cols.Frozen)
					{
						return false;
					}
				break;
			}

			return true;
		}

		#endregion

		#region 이벤트 처리 메서드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
            this.Text = "Shipping Confirm";
            lbl_MainTitle.Text = "Shipping Confirm";

            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			fgrid_main.Set_Grid("SBM_SHIP_CONFIRM_2", "1", 4, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Rows[4].Visible = false;
			fgrid_main.Set_Action_Image(img_Action);

			// factory set
			DataTable vDt;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = (cmb_factory.Tag == null) ? ClassLib.ComVar.This_Factory : cmb_factory.Tag;
			vDt.Dispose();

			// ship type set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM09");
			COM.ComCtl.Set_ComboList(vDt, cmb_shipType, 1, 2, false);
			cmb_shipType.SelectedValue = (cmb_shipType.Tag == null) ? "11" : cmb_shipType.Tag;
			vDt.Dispose();

			// obs type set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxOBSType);
			COM.ComCtl.Set_ComboList(vDt, cmb_ObsType, 1, 2, true);
			cmb_ObsType.SelectedIndex = 0;
			vDt.Dispose();

			CheckStatus();

			fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;

			this.tbtn_Delete.Enabled = false;
			this.tbtn_Create.Enabled = false;

			vAirColor		 = ClassLib.ComVar.AirColor;
			vSilhouetteColor = ClassLib.ComVar.SilhouetteColor;
			vJitColor		 = ClassLib.ComVar.JitColor;

			_newStyleColor	 = ClassLib.ComVar.NewStyleColor;


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
				MessageBox.Show(ex.Message);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				// header info set
                Grid_DisplayHeader();

				// tail info set
				Grid_DisplayTail();

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);

               
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_PrintProcess()
		{
			string mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Confirm.mrd" ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 7;
			string [] aHead =  new string[iCnt];	
			aHead[0]    = ClassLib.ComFunction.Empty_Combo(cmb_factory, " ");
			aHead[1]    = ClassLib.ComFunction.Empty_Combo(cmb_shipType, " ");
			aHead[2]    = ClassLib.ComFunction.Empty_String(dpick_from.Text.ToString().Replace("-",""), " ");
			aHead[3]    = ClassLib.ComFunction.Empty_String(dpick_to.Text.ToString().Replace("-",""), " ");
			aHead[4]    = " ";
			aHead[5]    = ClassLib.ComFunction.Empty_Combo(cmb_ObsType, " ");
			aHead[6]    = cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1);
			
			
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

		#region 컨트롤 이벤트 처리 메서드

		private void mnu_size_Click(object sender, System.EventArgs e)
		{
			try
			{
				int vRow = fgrid_main.Row;

				if (fgrid_main.Rows[vRow].Node.Level == 2)
					vRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

				COM.ComVar.Parameter_PopUp = new string[] { COM.ComFunction.Empty_Combo(cmb_factory, ""),
															  COM.ComFunction.Empty_Combo(cmb_shipType, ""),
															  cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_CONFIRM.IxLOT_NO].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_CONFIRM.IxLOT_SEQ].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_CONFIRM.IxSTYLE_CD].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_CONFIRM.IxSTYLE_NAME].ToString(),
															  "",
															  dpick_from.Value.ToString("yyyyMMdd"),
															  dpick_to.Value.ToString("yyyyMMdd"),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_CONFIRM.IxGENDER].ToString(),
															  "PKG_SBM_SHIPPING_CONFIRM.SELECT_SHIPPING_SCHEDULE_SIZE"
														  };

				Pop_BM_Shipping_Schedule_Size vPop = new Pop_BM_Shipping_Schedule_Size();
				vPop.ShowDialog();
			}
			catch
			{

			}
		}
		
		private void mnu_advice_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(1);		
		}

		private void mnu_all_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);		
		}

		private void mnu_Remarks_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (!Etc_ProvisoValidateCheck(_validate_remarks))
					return;

				int vRow = fgrid_main.Row;
				int vCol = fgrid_main.Col;
				CellRange vRange = fgrid_main.GetCellRange(vRow, vCol, vRow, vCol);

				if (vRange.UserData == null)
					vRange.UserData = new string[5]{"", "", "", "", ""};

				string[] vData = (string[])vRange.UserData;


				COM.ComVar.Parameter_PopUp = new string[] { COM.ComFunction.Empty_Combo(cmb_factory, ""),
															  COM.ComFunction.Empty_Combo(cmb_shipType, ""),
															  cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLOT_NO].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLOT_SEQ].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxSTYLE_CD].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxSTYLE_NAME].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLINE_CD].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxGENDER].ToString(),
															  //fgrid_main[_mrpShipNoRow, vCol].ToString(),
															  vData[0], vData[1], vData[2], vData[3], vData[4], "", "",
															  ClassLib.ComFunction.NullCheck(fgrid_main[vRow, vCol], "0"), "true"
														  };

				Pop_BM_Shipping_Schedule_OA vPop = new Pop_BM_Shipping_Schedule_OA(fgrid_main);

				if (vPop.ShowDialog() == DialogResult.OK)
				{
					fgrid_main.Update_Row(vRow);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Remarks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}		
		}

		#endregion

		#region 그리드 이벤트 처리 메서드

		private void Grid_AfterEditProcess()
		{
			fgrid_main.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_main.Row <= fgrid_main.Rows.Fixed)
				return;
			
			int vRow = fgrid_main.Row;

			if ( e.Button == MouseButtons.Right && vRow > fgrid_main.Rows.Fixed )
				ctx_main.Show(fgrid_main, new Point(e.X, e.Y));
			else if ( e.Button == MouseButtons.Left )
			{
				if (fgrid_main.Col < fgrid_main.Cols.Frozen)
				{
					if (fgrid_main.Rows[vRow].Node.Level == 2)
						vRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

					int vCol = fgrid_main.Cols.Frozen;

					while (vCol < fgrid_main.Cols.Count)
					{
						if ( fgrid_main[vRow, vCol] != null || fgrid_main[vRow + 1, vCol] != null || fgrid_main[vRow + 2, vCol] != null )
						{
							fgrid_main.LeftCol = vCol;
							break;
						}
						vCol++;
					}
				}
			}
		}
		
		private void mnu_findData_Click(object sender, System.EventArgs e)
		{
			finder = new Pop_Finder(fgrid_main, 1, fgrid_main.Cols.Frozen - 1);
			finder.Show();
		}


		#endregion

		#region 이벤트 처리시 사용되는 기능 메서드

		private int Grid_DisplayHeader()
		{
			_columnIndex.Clear();

			DataTable vDt = SELECT_SHIPPING_HEADER_INFO();

			if ( vDt.Rows.Count > 0 )
			{
				int vStartCol	= fgrid_main.Cols.Frozen;
				int vEndCol		= fgrid_main.Cols.Count = vStartCol + vDt.Rows.Count;

				for (int vIdx = 0, vCol = vStartCol ; vIdx < vDt.Rows.Count ; vIdx++, vCol++)
				{
					_columnIndex.Add(vDt.Rows[vIdx].ItemArray[3]);
					fgrid_main.Cols[vCol].Width				= 60;
					fgrid_main.Cols[vCol].DataType			= typeof(double);
					fgrid_main.Cols[vCol].Format			= "#,##0";

					fgrid_main[1, vCol] = vDt.Rows[vIdx].ItemArray[0];
					fgrid_main[2, vCol] = vDt.Rows[vIdx].ItemArray[1];
					fgrid_main[3, vCol] = vDt.Rows[vIdx].ItemArray[2];
					fgrid_main[4, vCol] = vDt.Rows[vIdx].ItemArray[3];

					if (!vDt.Rows[vIdx].ItemArray[4].ToString().Equals(""))
						fgrid_main.Cols[vCol].StyleNew.ForeColor = Color.FromArgb(Convert.ToInt32(vDt.Rows[vIdx].ItemArray[5]));
					else
						fgrid_main.Cols[vCol].StyleNew.ForeColor = Color.Blue;

					if (!vDt.Rows[vIdx].ItemArray[5].ToString().Equals(""))
						fgrid_main.Cols[vCol].StyleNew.BackColor = Color.FromArgb(Convert.ToInt32(vDt.Rows[vIdx].ItemArray[5]));
					else
						fgrid_main.Cols[vCol].StyleNew.BackColor = Color.White;

					if (!(vDt.Rows[vIdx].ItemArray[6].ToString().Equals("40") || vDt.Rows[vIdx].ItemArray[6].ToString().Equals("50")))
                        fgrid_main.Cols[vCol].AllowEditing = false;
					else
						fgrid_main.Cols[vCol].AllowEditing = true;
				}

				CellRange vRange = fgrid_main.GetCellRange(3, vStartCol, 3, fgrid_main.Cols.Count - 1);

				vRange.StyleNew.TextAlign	= C1.Win.C1FlexGrid.TextAlignEnum.RightCenter;
				vRange.StyleNew.Format		= "#,##0";
			}

			return vDt.Rows.Count;
		}

		// display grid
		private int Grid_DisplayTail()
		{
			DataTable vDt = SELECT_SHIPPING_SCHEDULE();

			if ( vDt.Rows.Count > 0 )
			{
				//Display_FlexGrid_Tree(fgrid_main, vDt, 0);
				Display_FlexGrid(vDt);
				fgrid_main.Tree.Column = 1;
				Grid_SetColor();
			}
			else
			{
				fgrid_main.ClearAll();
			}

			return vDt.Rows.Count;

		}


		// display grid
		private void Display_FlexGrid(DataTable arg_dt)
		{
			try
			{
				ArrayList vRowIndex = new ArrayList();
				int vStartCol	= fgrid_main.Cols.Frozen;
				int vDataStart	= fgrid_main.Cols.Frozen - 2;
				int vMrpShipNo	= vDataStart;
				int vAdviceQty	= vDataStart + 1;
				int vMpsQty		= vDataStart + 2;
				int vShipQty	= vDataStart + 3;
				int vKey		= vDataStart + 4;
				int vNewStyle	= vDataStart + 5;
				int vRemarks	= vDataStart + 6;
				int vReason		= vDataStart + 7;
				int vAttribute	= vDataStart + 8;
				int vShipDate	= vDataStart + 9;

				fgrid_main.ClearAll();
				int vFixed = fgrid_main.Rows.Fixed;
				int vCol = 0;
				int vCount = 2;
				int vAdviceRow = vFixed, vMpsRow = vFixed + 1, vShipRow = vFixed + 2;

				for (int vIdx = 0 ; vIdx < arg_dt.Rows.Count ; vIdx++)
				{
					if (!_columnIndex.Contains(arg_dt.Rows[vIdx].ItemArray[vMrpShipNo]))
						continue;

					// row, column index 구하기
					vCol = _columnIndex.IndexOf(arg_dt.Rows[vIdx].ItemArray[vMrpShipNo]) + vStartCol;
					bool vTemp = vRowIndex.Contains(arg_dt.Rows[vIdx].ItemArray[vKey]);

					// Advice
					if (!vTemp)
					{
						C1.Win.C1FlexGrid.Row vNewRow = fgrid_main.Rows.Add();
						vNewRow.IsNode = true;
						vNewRow.Node.Level = 1;
						vNewRow[1] = "Advice";
						vAdviceRow = vNewRow.Node.Row.Index;

						while (vCount < vStartCol - 1)
						{
							vNewRow[vCount++] = arg_dt.Rows[vIdx].ItemArray[vCount - 2];
						}
						vCount = 2;


						vNewRow = fgrid_main.Rows.Add();
						vNewRow.IsNode = true;
						vNewRow.Node.Level = 2;
						vNewRow[1] = "MPS";
						vMpsRow = vNewRow.Node.Row.Index;

						vNewRow = fgrid_main.Rows.Add();
						vNewRow.IsNode = true;
						vNewRow.Node.Level = 2;
						vNewRow[1] = "Shipping";
						vShipRow = vNewRow.Node.Row.Index;

						vRowIndex.Add(arg_dt.Rows[vIdx].ItemArray[vKey]);
					}

					// Advice
					fgrid_main[vAdviceRow, vCol] = arg_dt.Rows[vIdx].ItemArray[vAdviceQty].ToString();
					CellRange vRange = fgrid_main.GetCellRange(vAdviceRow, vCol, vAdviceRow, vCol);
					vRange.UserData = new string[]{arg_dt.Rows[vIdx].ItemArray[vNewStyle].ToString(), arg_dt.Rows[vIdx].ItemArray[vRemarks].ToString(),
													  arg_dt.Rows[vIdx].ItemArray[vReason].ToString(), arg_dt.Rows[vIdx].ItemArray[vAttribute].ToString(),
													  arg_dt.Rows[vIdx].ItemArray[vShipDate].ToString()};


					// New Style
					if (arg_dt.Rows[vIdx].ItemArray[vNewStyle].ToString().Equals("Y"))
						fgrid_main.Rows[vAdviceRow].StyleNew.ForeColor = Color.Violet;

					// Silhouette / Air Flight
					if (arg_dt.Rows[vIdx].ItemArray[vAttribute].ToString().Equals(_silhouetteFlag))
						fgrid_main.GetCellRange(vAdviceRow, vCol, vAdviceRow, vCol).StyleNew.ForeColor = vSilhouetteColor;
					else if (arg_dt.Rows[vIdx].ItemArray[vAttribute].ToString().ToUpper().Equals(_airFlag))
						fgrid_main.GetCellRange(vAdviceRow, vCol, vAdviceRow, vCol).StyleNew.ForeColor = vAirColor;
					else if (arg_dt.Rows[vIdx].ItemArray[vAttribute].ToString().ToUpper().Equals(_jitFlag))
						fgrid_main.GetCellRange(vAdviceRow, vCol, vAdviceRow, vCol).StyleNew.ForeColor = vJitColor;


					// Mps
					fgrid_main[vMpsRow, vCol] = arg_dt.Rows[vIdx].ItemArray[vMpsQty].ToString();

					// Shipping
					fgrid_main[vShipRow, vCol] = arg_dt.Rows[vIdx].ItemArray[vShipQty].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_FlexGrid_Tree",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}
		}

        // grid color set
		private void Grid_SetColor()
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				CellRange vRange = fgrid_main.GetCellRange(vRow, 1, vRow, fgrid_main.Cols.Count - 1);

				switch (fgrid_main.Rows[vRow].Node.Level)
				{
					case 1:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;

						for (int vCol = fgrid_main.Cols.Frozen ; vCol < fgrid_main.Cols.Count ; vCol++)
						{
							CellRange vRange2 = fgrid_main.GetCellRange(vRow, vCol, vRow, vCol);
							vRange2.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						}

						//RowTotal(vRow);
						break;
					case 2:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
						//fgrid_main[vRow, _totalQtyCol] = fgrid_main.Aggregate(AggregateEnum.Sum, vRow, fgrid_main.Cols.Frozen, vRow, fgrid_main.Cols.Count - 1);
						break;
				}

				fgrid_main.Rows[vRow].AllowEditing = false;
			}
		}

		private void RowTotal(int arg_row)
		{
			Node vCurNode = fgrid_main.Rows[arg_row].Node;
			Node vNextNode = vCurNode.GetNode(NodeTypeEnum.NextSibling);

			int vCol = fgrid_main.Cols.Frozen;
			int vr1 = vCurNode.Row.Index + 1;
			int vr2 = (vNextNode == null) ? fgrid_main.Rows.Count - 1 : vNextNode.Row.Index - 1;

			while (vCol < fgrid_main.Cols.Count)
			{
				int vSumData = 0;
				vr1 = vCurNode.Row.Index + 1;

				while (vr1 < vr2)
				{
					if (fgrid_main.Rows[vr1].Node.Level == 2)
						vSumData += Convert.ToInt32(fgrid_main[vr1, vCol]);

					vr1++;
				}

				fgrid_main[arg_row, vCol] = vSumData;
				fgrid_main[3, vCol] = Convert.ToInt32(fgrid_main[3, vCol]) + vSumData;

				vCol++;
			}
		}

		#endregion

		#endregion

		#region DB Connect
	
		/// <summary>
		/// PKG_SBM_SHIPPING_MASTER : 헤더 정보 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SHIPPING_HEADER_INFO()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_MASTER.SELECT_SHIPPING_HEADER_INFO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBM_SHIPPING_SCHEDULE : Shipping schedule 데이터 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SHIPPING_SCHEDULE()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_CONFIRM.SELECT_SHIPPING_SCHEDULE_2";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
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
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_ObsType, "");
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBM_SHIPPING_CONFIRM : 
		/// </summary>
		public bool SAVE_SHIPPING_CONFIRM_UPDATE()
		{
			try
			{
				MyOraDB.ReDim_Parameter(8);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_CONFIRM.SAVE_SHIPPING_CONFIRM_UPDATE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[6] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

				//04.DATA 정의
				ArrayList vList = new ArrayList();

				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]).Equals(""))
					{
						for (int vCol = fgrid_main.Cols.Frozen ; vCol < fgrid_main.Cols.Count ; vCol++)
						{
							if (fgrid_main.GetCellRange(vRow, vCol, vRow, vCol).UserData != null)
							{
								vList.Add(cmb_factory.SelectedValue.ToString());
								vList.Add(cmb_shipType.SelectedValue.ToString());
								vList.Add(fgrid_main[_mrpShipNoRow, vCol].ToString());
								vList.Add(fgrid_main[vRow, _lotNoCol].ToString());
								vList.Add(fgrid_main[vRow, _lotSeqCol].ToString());
								vList.Add(fgrid_main[vRow, _styleCodeCol].ToString().Replace("-", ""));
								CellRange vRange = fgrid_main.GetCellRange(vRow, vCol, vRow, vCol);
								string vRemarks = ((string[])vRange.UserData)[1];
								vList.Add(ClassLib.ComFunction.NullToBlank(vRemarks));
								vList.Add(COM.ComVar.This_User);
							}
						}
					}
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}

		/// <summary>
		/// PKG_SBM_SHIPPING_CONFIRM : SHIPPING CONFIRM
		/// </summary>
		public DataTable SAVE_SHIPPING_CONFIRM()
		{
			
               DataSet vds_ret;

				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_CONFIRM.SAVE_SHIPPING_CONFIRM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
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
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
				MyOraDB.Parameter_Values[4] = COM.ComVar.This_User;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];


		
		}

		#endregion	

		#region IOperation 멤버

		public void CheckStatus()
		{
			// status set
			txt_status.Text = ClassLib.ComFunction.ProcessStatus(_process, cmb_factory.SelectedValue.ToString(), cmb_shipType.SelectedValue.ToString());

			// button enable set
			DataTable vDt = ClassLib.ComFunction.SELECT_PROCESS_CHARGE(cmb_factory.SelectedValue.ToString(), _process);
			tbtn_Save.Enabled			= ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Save, txt_status.Text);
			tbtn_Confirm.Enabled		= ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Confirm, txt_status.Text);
		}

		public bool Confirm()
		{
			if (ClassLib.ComFunction.Essentiality_check(new C1.Win.C1List.C1Combo[]{cmb_factory, cmb_shipType}, null))
			{
				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vShipType = COM.ComFunction.Empty_Combo(this.cmb_shipType, "");

				if (ClassLib.ComFunction.SAVE_CHECK_LIST_CONFIRM(_process, vFactory, vShipType, COM.ComVar.This_User, true))
				{
					ClassLib.ComFunction.User_Message("Confirm complete", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txt_status.Text = "Confirm";
					tbtn_Save.Enabled = false;
					tbtn_Confirm.Enabled = false;
					return true;
				}			
			}

			return false;
		}

		public void RunProcess(string arg_factory, string arg_ShipType, string arg_mrpNo, string arg_PlanStart, string arg_PlanEnd)
		{
			cmb_factory.Tag = arg_factory;
			cmb_shipType.Tag = arg_ShipType;

			dpick_from.Value = ClassLib.ComFunction.StringToDateTime(arg_PlanStart).AddDays(-45);
			dpick_to.Value = ClassLib.ComFunction.StringToDateTime(arg_PlanEnd);
			//Tbtn_SearchProcess();
		}

		public int GetSearchRows()
		{
			return fgrid_main.Rows.Count - fgrid_main.Rows.Fixed;
		}
		
		#endregion


	}
}

