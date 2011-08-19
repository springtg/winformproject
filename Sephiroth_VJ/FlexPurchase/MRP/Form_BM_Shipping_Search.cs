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
	public class Form_BM_Shipping_Search : COM.PCHWinForm.Form_Top, IOperation
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
		private C1.Win.C1List.C1Combo cmb_ObsType;
		private System.Windows.Forms.Label lbl_ObsType;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.TextBox txt_styleCd;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label lbl_stylecd;
		private System.Windows.Forms.TextBox txt_lotno;
		private System.Windows.Forms.Label lbl_lotno;
		private C1.Win.C1List.C1Combo cmb_division;
		private System.Windows.Forms.Label lbl_division;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_Remarks;
		private System.Windows.Forms.MenuItem mnu_findData;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_printUsage;
		private System.Windows.Forms.MenuItem mnu_size;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버

		private string _process		= (int)ClassLib.ComVar.MRPProcessNum.ShippingConfirm + "";
		private COM.OraDB MyOraDB	= new COM.OraDB();
		private ArrayList _columnIndex	= new ArrayList();
		private object[][] _copyRange;
		private Pop_Finder finder;

		private int _mrpShipNoRow	= 4;
		private int _lotNoCol		= (int)ClassLib.TBSBM_SHIP_CONFIRM.IxLOT_NO;
		private int _lotSeqCol		= (int)ClassLib.TBSBM_SHIP_CONFIRM.IxLOT_SEQ;
		private int _styleCodeCol	= (int)ClassLib.TBSBM_SHIP_CONFIRM.IxSTYLE_CD;
        

        private COM.FSP fgrid_main;
        private Button btn_SSInspection;

		private const int _validate_remarks = 30;
    

		#endregion

		#region 생성자 / 소멸자

		public Form_BM_Shipping_Search()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BM_Shipping_Search));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_main = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_ymd = new System.Windows.Forms.Label();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.cmb_division = new C1.Win.C1List.C1Combo();
            this.lbl_division = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_lotno = new System.Windows.Forms.TextBox();
            this.lbl_lotno = new System.Windows.Forms.Label();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.lbl_stylecd = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cmb_ObsType = new C1.Win.C1List.C1Combo();
            this.lbl_ObsType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.ctx_main = new System.Windows.Forms.ContextMenu();
            this.mnu_findData = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_printUsage = new System.Windows.Forms.MenuItem();
            this.mnu_size = new System.Windows.Forms.MenuItem();
            this.mnu_Remarks = new System.Windows.Forms.MenuItem();
            this.btn_SSInspection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_division)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ObsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
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
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "19.7916666666667:False:True;78.125:False:False;0.694444444444444:False:True;\t0.39" +
                "3700787401575:False:True;98.4251968503937:False:False;0.393700787401575:False:Tr" +
                "ue;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.Location = new System.Drawing.Point(8, 118);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 19;
            this.fgrid_main.Size = new System.Drawing.Size(1000, 450);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 3;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyDown);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            this.fgrid_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyUp);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.btn_SSInspection);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.lbl_ymd);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.cmb_division);
            this.pnl_head.Controls.Add(this.lbl_division);
            this.pnl_head.Controls.Add(this.pictureBox3);
            this.pnl_head.Controls.Add(this.pictureBox2);
            this.pnl_head.Controls.Add(this.txt_lotno);
            this.pnl_head.Controls.Add(this.lbl_lotno);
            this.pnl_head.Controls.Add(this.txt_styleCd);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.lbl_stylecd);
            this.pnl_head.Controls.Add(this.txt_status);
            this.pnl_head.Controls.Add(this.lbl_status);
            this.pnl_head.Controls.Add(this.cmb_ObsType);
            this.pnl_head.Controls.Add(this.lbl_ObsType);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pictureBox1);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 114);
            this.pnl_head.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(207, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 396;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(225, 84);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(95, 21);
            this.dpick_to.TabIndex = 395;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 84);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(95, 21);
            this.dpick_from.TabIndex = 394;
            // 
            // lbl_ymd
            // 
            this.lbl_ymd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ymd.ImageIndex = 1;
            this.lbl_ymd.ImageList = this.img_Label;
            this.lbl_ymd.Location = new System.Drawing.Point(8, 84);
            this.lbl_ymd.Name = "lbl_ymd";
            this.lbl_ymd.Size = new System.Drawing.Size(100, 21);
            this.lbl_ymd.TabIndex = 50;
            this.lbl_ymd.Text = "Ship Date";
            this.lbl_ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 98);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(200, 24);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // cmb_division
            // 
            this.cmb_division.AddItemSeparator = ';';
            this.cmb_division.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_division.Caption = "";
            this.cmb_division.CaptionHeight = 17;
            this.cmb_division.CaptionStyle = style1;
            this.cmb_division.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_division.ColumnCaptionHeight = 18;
            this.cmb_division.ColumnFooterHeight = 18;
            this.cmb_division.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_division.ContentHeight = 16;
            this.cmb_division.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_division.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_division.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_division.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_division.EditorHeight = 16;
            this.cmb_division.Enabled = false;
            this.cmb_division.EvenRowStyle = style2;
            this.cmb_division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_division.FooterStyle = style3;
            this.cmb_division.HeadingStyle = style4;
            this.cmb_division.HighLightRowStyle = style5;
            this.cmb_division.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_division.Images"))));
            this.cmb_division.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_division.ItemHeight = 15;
            this.cmb_division.Location = new System.Drawing.Point(431, 84);
            this.cmb_division.MatchEntryTimeout = ((long)(2000));
            this.cmb_division.MaxDropDownItems = ((short)(5));
            this.cmb_division.MaxLength = 32767;
            this.cmb_division.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_division.Name = "cmb_division";
            this.cmb_division.OddRowStyle = style6;
            this.cmb_division.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_division.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_division.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_division.SelectedStyle = style7;
            this.cmb_division.Size = new System.Drawing.Size(210, 20);
            this.cmb_division.Style = style8;
            this.cmb_division.TabIndex = 440;
            this.cmb_division.PropBag = resources.GetString("cmb_division.PropBag");
            // 
            // lbl_division
            // 
            this.lbl_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_division.ImageIndex = 0;
            this.lbl_division.ImageList = this.img_Label;
            this.lbl_division.Location = new System.Drawing.Point(330, 84);
            this.lbl_division.Name = "lbl_division";
            this.lbl_division.Size = new System.Drawing.Size(100, 21);
            this.lbl_division.TabIndex = 441;
            this.lbl_division.Text = "Division";
            this.lbl_division.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(968, 18);
            this.pictureBox3.TabIndex = 444;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(984, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 32);
            this.pictureBox2.TabIndex = 443;
            this.pictureBox2.TabStop = false;
            // 
            // txt_lotno
            // 
            this.txt_lotno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lotno.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_lotno.Location = new System.Drawing.Point(754, 40);
            this.txt_lotno.MaxLength = 10;
            this.txt_lotno.Name = "txt_lotno";
            this.txt_lotno.Size = new System.Drawing.Size(211, 21);
            this.txt_lotno.TabIndex = 439;
            // 
            // lbl_lotno
            // 
            this.lbl_lotno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_lotno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lotno.ImageIndex = 0;
            this.lbl_lotno.ImageList = this.img_Label;
            this.lbl_lotno.Location = new System.Drawing.Point(653, 40);
            this.lbl_lotno.Name = "lbl_lotno";
            this.lbl_lotno.Size = new System.Drawing.Size(100, 21);
            this.lbl_lotno.TabIndex = 438;
            this.lbl_lotno.Text = "Lot No";
            this.lbl_lotno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.Location = new System.Drawing.Point(431, 40);
            this.txt_styleCd.MaxLength = 10;
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.Size = new System.Drawing.Size(73, 21);
            this.txt_styleCd.TabIndex = 426;
            this.txt_styleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCd_KeyUp);
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style9;
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
            this.cmb_style.EvenRowStyle = style10;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style11;
            this.cmb_style.HeadingStyle = style12;
            this.cmb_style.HighLightRowStyle = style13;
            this.cmb_style.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_style.Images"))));
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(505, 40);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style14;
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style15;
            this.cmb_style.Size = new System.Drawing.Size(136, 20);
            this.cmb_style.Style = style16;
            this.cmb_style.TabIndex = 427;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            // 
            // lbl_stylecd
            // 
            this.lbl_stylecd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_stylecd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stylecd.ImageIndex = 0;
            this.lbl_stylecd.ImageList = this.img_Label;
            this.lbl_stylecd.Location = new System.Drawing.Point(330, 40);
            this.lbl_stylecd.Name = "lbl_stylecd";
            this.lbl_stylecd.Size = new System.Drawing.Size(100, 21);
            this.lbl_stylecd.TabIndex = 425;
            this.lbl_stylecd.Text = "Style";
            this.lbl_stylecd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_status.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_status.Location = new System.Drawing.Point(754, 62);
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
            this.lbl_status.Location = new System.Drawing.Point(653, 62);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_status.TabIndex = 418;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ObsType
            // 
            this.cmb_ObsType.AddItemSeparator = ';';
            this.cmb_ObsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ObsType.Caption = "";
            this.cmb_ObsType.CaptionHeight = 17;
            this.cmb_ObsType.CaptionStyle = style17;
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
            this.cmb_ObsType.EvenRowStyle = style18;
            this.cmb_ObsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ObsType.FooterStyle = style19;
            this.cmb_ObsType.HeadingStyle = style20;
            this.cmb_ObsType.HighLightRowStyle = style21;
            this.cmb_ObsType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_ObsType.Images"))));
            this.cmb_ObsType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_ObsType.ItemHeight = 15;
            this.cmb_ObsType.Location = new System.Drawing.Point(431, 62);
            this.cmb_ObsType.MatchEntryTimeout = ((long)(2000));
            this.cmb_ObsType.MaxDropDownItems = ((short)(5));
            this.cmb_ObsType.MaxLength = 32767;
            this.cmb_ObsType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ObsType.Name = "cmb_ObsType";
            this.cmb_ObsType.OddRowStyle = style22;
            this.cmb_ObsType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ObsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ObsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ObsType.SelectedStyle = style23;
            this.cmb_ObsType.Size = new System.Drawing.Size(210, 20);
            this.cmb_ObsType.Style = style24;
            this.cmb_ObsType.TabIndex = 402;
            this.cmb_ObsType.PropBag = resources.GetString("cmb_ObsType.PropBag");
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
            this.lbl_ObsType.Text = "Order Type";
            this.lbl_ObsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style25;
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
            this.cmb_shipType.EvenRowStyle = style26;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style27;
            this.cmb_shipType.HeadingStyle = style28;
            this.cmb_shipType.HighLightRowStyle = style29;
            this.cmb_shipType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_shipType.Images"))));
            this.cmb_shipType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(109, 62);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style30;
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style31;
            this.cmb_shipType.Size = new System.Drawing.Size(210, 20);
            this.cmb_shipType.Style = style32;
            this.cmb_shipType.TabIndex = 5;
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
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
            this.pic_head4.Size = new System.Drawing.Size(0, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style33;
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
            this.cmb_factory.EvenRowStyle = style34;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style35;
            this.cmb_factory.HeadingStyle = style36;
            this.cmb_factory.HighLightRowStyle = style37;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style38;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style39;
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style40;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
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
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(-12, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
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
            this.pic_head1.Size = new System.Drawing.Size(0, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 32);
            this.pictureBox1.TabIndex = 442;
            this.pictureBox1.TabStop = false;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(899, 16);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 88);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // ctx_main
            // 
            this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_findData,
            this.menuItem1,
            this.mnu_printUsage,
            this.mnu_size,
            this.mnu_Remarks});
            // 
            // mnu_findData
            // 
            this.mnu_findData.Index = 0;
            this.mnu_findData.Text = "Find Data";
            this.mnu_findData.Click += new System.EventHandler(this.mnu_findData_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "-";
            // 
            // mnu_printUsage
            // 
            this.mnu_printUsage.Index = 2;
            this.mnu_printUsage.Text = "Print Usage";
            this.mnu_printUsage.Click += new System.EventHandler(this.mnu_printUsage_Click);
            // 
            // mnu_size
            // 
            this.mnu_size.Index = 3;
            this.mnu_size.Text = "Size Information";
            this.mnu_size.Click += new System.EventHandler(this.mnu_size_Click);
            // 
            // mnu_Remarks
            // 
            this.mnu_Remarks.Index = 4;
            this.mnu_Remarks.Text = "Remarks";
            this.mnu_Remarks.Click += new System.EventHandler(this.mnu_Remarks_Click_1);
            // 
            // btn_SSInspection
            // 
            this.btn_SSInspection.BackColor = System.Drawing.SystemColors.Window;
            this.btn_SSInspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SSInspection.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SSInspection.Location = new System.Drawing.Point(657, 84);
            this.btn_SSInspection.Name = "btn_SSInspection";
            this.btn_SSInspection.Size = new System.Drawing.Size(100, 23);
            this.btn_SSInspection.TabIndex = 445;
            this.btn_SSInspection.Text = "SS Inspection";
            this.btn_SSInspection.UseVisualStyleBackColor = false;
            this.btn_SSInspection.Click += new System.EventHandler(this.btn_SSInspection_Click);
            // 
            // Form_BM_Shipping_Search
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BM_Shipping_Search";
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_division)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ObsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
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

		private void mnu_printUsage_Click(object sender, System.EventArgs e)
		{
			string mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Search_Usage.mrd" ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 6;
			string [] aHead =  new string[iCnt];	

			aHead[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			aHead[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			aHead[2] = ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, _lotNoCol]);
			aHead[3] = ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, _lotSeqCol]);
			aHead[4] = "301270";
			aHead[5] = "";
			
			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();
		}

		private void mnu_size_Click(object sender, System.EventArgs e)
		{
			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Size.mrd" ;
				string Para         = " ";

				#region 출력조건

				int  iCnt  = 7;
				string [] aHead =  new string[iCnt];	

				aHead[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				aHead[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				aHead[2] = dpick_from.Value.ToString("yyyyMMdd");
				aHead[3] = dpick_to.Value.ToString("yyyyMMdd");
				aHead[4] = ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, _lotNoCol]);
				aHead[5] = ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, _lotSeqCol]);
				aHead[6] = "";

				#endregion
			
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{
					Para = Para + "[" + aHead[i-1] + "] ";
				}
			
				FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
				report.Show();		
			}
			else
			{
				ClassLib.ComFunction.User_Message("No Data.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
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
					if (fgrid_main.Col < fgrid_main.Cols.Frozen)
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
			this.Text = "Check Shipping Schedule";
            lbl_MainTitle.Text = "Check Shipping Schedule";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			fgrid_main.Set_Grid("SBM_SHIP_CONFIRM_2", "3", 4, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
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
			this.tbtn_Print.Enabled = true;
			this.tbtn_Create.Enabled = false;
			this.tbtn_Confirm.Enabled = false;

			fgrid_main.AllowSorting = AllowSortingEnum.SingleColumn;
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
//			try
//			{
//				this.Cursor = Cursors.WaitCursor;

				// header info set
                Grid_DisplayHeader();

				// tail info set
				Grid_DisplayTail();

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show(ex.Message);
//			}			
//			finally
//			{
//				this.Cursor = Cursors.Default;
//			}
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
				Display_FlexGrid(vDt);
				//ColumnTotal();
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
				//int vDataStart	= fgrid_main.Cols.Frozen - 1;
				int vMrpShipNo	= vDataStart;
				int vAdviceQty	= vDataStart + 1;
				int vMpsQty		= vDataStart + 2;
				int vShipQty	= vDataStart + 3;
				int vRemarks	= vDataStart + 4;
				int vKey		= vDataStart + 5;
				int vNewStyle	= vDataStart + 6;
				int vAttribute	= vDataStart + 8;
				
				
				fgrid_main.ClearAll();
				int vFixed = fgrid_main.Rows.Fixed;
				int vCol = 0;
				int vCount = 2;
				int vAdviceRow = vFixed, vMpsRow = vFixed + 1, vShipRow = vFixed + 2;

				// 반복 처리 관련 변수
				string lot_no, lot_seq,style_no,style_nm,obs_id,date1, status1;
				string slot_no="", slot_seq="",sstyle_no="",sstyle_nm="",sobs_id="",sdate1="", sstatus1 = "";
				string vfl="T";
				int vForstart = 1;
				int vLot_no   = vForstart;
				int vLot_seq  = vForstart + 1;
				int vStyle_no = vForstart + 2;
				int vStyle_nm = vForstart + 3;
				int vObs_id   = vForstart + 4;
				int vDate     = vForstart + 5;
				int vStatus   = vForstart + 6;

				C1.Win.C1FlexGrid.Row vNewRow=null;


				for (int vIdx = 0 ; vIdx < arg_dt.Rows.Count ; vIdx++)
				{
					if (!_columnIndex.Contains(arg_dt.Rows[vIdx].ItemArray[vMrpShipNo]))
						continue;

					vCol = _columnIndex.IndexOf(arg_dt.Rows[vIdx].ItemArray[vMrpShipNo]) + vStartCol;
					
					bool vTemp = vRowIndex.Contains(arg_dt.Rows[vIdx].ItemArray[vKey]);

					lot_no   = arg_dt.Rows[vIdx].ItemArray[vLot_no ].ToString();
					lot_seq  = arg_dt.Rows[vIdx].ItemArray[vLot_seq ].ToString();
					style_no = arg_dt.Rows[vIdx].ItemArray[vStyle_no].ToString();
					style_nm = arg_dt.Rows[vIdx].ItemArray[vStyle_nm ].ToString();
					obs_id   = arg_dt.Rows[vIdx].ItemArray[vObs_id ].ToString();
					date1    = arg_dt.Rows[vIdx].ItemArray[vDate].ToString();				
					status1  = arg_dt.Rows[vIdx].ItemArray[vStatus].ToString();				
					
					vfl="T";
					if(lot_no == slot_no)
					{
						if(lot_seq == slot_seq)
						{
							if(style_no == sstyle_no)
							{
								if(style_nm == sstyle_nm)
								{
									if(obs_id == sobs_id)
									{
										if(date1 == sdate1)
										{ 
											vfl="F"; 
										}
									}
								}
							}
						}
					}
					if(vfl=="T")
					{
						vNewRow =  fgrid_main.Rows.Add();
						vNewRow[1] = "Advice";
						vAdviceRow = vNewRow.Index;

						slot_no   = arg_dt.Rows[vIdx].ItemArray[vLot_no ].ToString();
						slot_seq  = arg_dt.Rows[vIdx].ItemArray[vLot_seq ].ToString();
						sstyle_no = arg_dt.Rows[vIdx].ItemArray[vStyle_no].ToString();
						sstyle_nm = arg_dt.Rows[vIdx].ItemArray[vStyle_nm ].ToString();
						sobs_id   = arg_dt.Rows[vIdx].ItemArray[vObs_id ].ToString();
						sdate1    = arg_dt.Rows[vIdx].ItemArray[vDate].ToString();			
						sstatus1  = arg_dt.Rows[vIdx].ItemArray[vStatus].ToString();
					}

					//while (vCount < vStartCol - 1) 
					while (vCount < vStartCol) 
					{
						vNewRow[vCount++] = arg_dt.Rows[vIdx].ItemArray[vCount - 2];
					}
					vCount   = 2;
						
					// New Style
					if (arg_dt.Rows[vIdx].ItemArray[vNewStyle].ToString().ToUpper().Equals("Y"))
						fgrid_main.Rows[vAdviceRow].StyleNew.ForeColor = Color.Violet;

					// Silhouette / Air Flight
					if (arg_dt.Rows[vIdx].ItemArray[vAttribute].ToString().ToUpper().Equals("S"))
						fgrid_main.GetCellRange(vAdviceRow, vCol, vAdviceRow, vCol).StyleNew.ForeColor = ClassLib.ComVar.SilhouetteColor;
					else if (arg_dt.Rows[vIdx].ItemArray[vAttribute].ToString().ToUpper().Equals("A"))
						fgrid_main.GetCellRange(vAdviceRow, vCol, vAdviceRow, vCol).StyleNew.ForeColor = ClassLib.ComVar.AirColor;
					else if (arg_dt.Rows[vIdx].ItemArray[vAttribute].ToString().ToUpper().Equals("J"))
						fgrid_main.GetCellRange(vAdviceRow, vCol, vAdviceRow, vCol).StyleNew.ForeColor = ClassLib.ComVar.JitColor;
                    else
                        fgrid_main.GetCellRange(vAdviceRow, vCol, vAdviceRow, vCol).StyleNew.ForeColor = Color.Black;

					vRowIndex.Add(arg_dt.Rows[vIdx].ItemArray[vKey]);

					// Advice
					fgrid_main[vAdviceRow, vCol] = arg_dt.Rows[vIdx].ItemArray[vAdviceQty].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Search",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}
		}

		private void ColumnTotal()
		{
			int vCol = fgrid_main.Cols.Frozen;

			while (vCol < fgrid_main.Cols.Count)
			{
				fgrid_main[fgrid_main.Rows.Fixed - 2, vCol] = fgrid_main.Aggregate(AggregateEnum.Sum, fgrid_main.Rows.Fixed, vCol, fgrid_main.Rows.Count - 1, vCol);
				fgrid_main.Cols[vCol].AllowEditing = false;
				vCol++;
			}
		}




        /// <summary>
        /// Event_Click_btn_YieldInspection : 선적일자의 스타일에 대한 채산 정합성 체크
        /// </summary>
        private void Event_Click_btn_SSInspection()
        {

            // DS, 각 스타일의 Factory 간의 채산 정합성 체크 (sbc_yield_info 의 ship_yn 체크)


            C1.Win.C1List.C1Combo[] cmb_array = { cmb_factory, cmb_shipType };
            bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);
            if (!essential_check) return;


            string factory = cmb_factory.SelectedValue.ToString();
            string ship_type = cmb_shipType.SelectedValue.ToString();
            string this_factory = ClassLib.ComVar.This_Factory;

            DataTable dt_ret = Run_SS_Inspection(factory, ship_type, this_factory);

            string message = "";

            // 오류
            if (dt_ret == null)
            {
            }


            // 채산, shipping material 완료
            if (dt_ret.Rows.Count == 0)
            {
                message = "Completed verification." + "\r\n\r\n" + "Data agrees.";
            }
            else  // 채산, shipping material 완료 안됨
            {
                message = "Completed verification" +":" + dt_ret.Rows[0].ItemArray[1].ToString() + "\r\n\r\n" + "Data does not agree." + "\r\n\r\n";

                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {
                    message += dt_ret.Rows[i].ItemArray[2].ToString() + "  ||  " + dt_ret.Rows[i].ItemArray[3].ToString() + "  ||  " + dt_ret.Rows[i].ItemArray[4].ToString() + "              " + "\r\n";

                } // end for i

            } // end if


            ClassLib.ComFunction.User_Message(message, "Yield Inspection", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // 체크 후 처리






        }

		#endregion

		#endregion

		#region DB Connect


        private DataTable Run_SS_Inspection(string arg_factory, string arg_ship_type, string arg_this_factory)
        {

            try
            {

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SBM_SHIPPING_SEARCH.RUN_SHIPPING_INSPECTION";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
                MyOraDB.Parameter_Name[2] = "ARG_THIS_FACTORY";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_ship_type;
                MyOraDB.Parameter_Values[2] = arg_this_factory;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();
                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch
            {
                return null;
            }

        }



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

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_Search.SELECT_SHIPPING_SCHEDULE_2";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[6] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[7] = "ARG_STATUS";
			MyOraDB.Parameter_Name[8] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[9] = "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = txt_styleCd.Text;
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(cmb_ObsType, "");
			MyOraDB.Parameter_Values[6] = txt_lotno.Text;
			MyOraDB.Parameter_Values[7] = txt_status.Text;
			MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_Combo(cmb_division, "");
			MyOraDB.Parameter_Values[9] = "";

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
								vList.Add(fgrid_main.GetCellRange(vRow, vCol, vRow, vCol).UserData.ToString());
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
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// PKG_SBM_SHIPPING_CONFIRM : SHIPPING CONFIRM
		/// </summary>
		public bool SAVE_SHIPPING_CONFIRM()
		{
			try
			{
				MyOraDB.ReDim_Parameter(5);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_CONFIRM.SAVE_SHIPPING_CONFIRM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
				MyOraDB.Parameter_Values[4] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();
                return true;
			}
			catch
			{
				return false;
			}
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

		#region 이벤트_버튼 프린트

        private void btn_SSInspection_Click(object sender, EventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;

                Event_Click_btn_SSInspection();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_YieldInspection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Search.mrd" ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 12;
			string [] aHead =  new string[iCnt];	

			aHead[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			aHead[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			aHead[2] = dpick_from.Text.Replace("-", "");
			aHead[3] = dpick_to.Text.Replace("-", "");
			aHead[4] = txt_styleCd.Text;
			aHead[5] = COM.ComFunction.Empty_Combo(cmb_ObsType, "");
			aHead[6] = txt_lotno.Text;
			aHead[7] = txt_status.Text;
			aHead[8] = COM.ComFunction.Empty_Combo(cmb_division, "");
			aHead[9] = ClassLib.ComFunction.Empty_Combo(cmb_ObsType, " ");
			aHead[10] = cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1);
			aHead[11] = cmb_ObsType.GetItemText(cmb_ObsType.SelectedIndex, 1);

			
			
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

		private void txt_styleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				this.Txt_StyleCdKeyUpProcess();
		}

		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCd, " "));
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(vDt, cmb_style, 0, 1, 2, 3, 4, true, 100, 221); 
				vDt.Dispose();
				
				if (txt_styleCd.Text.Length == 9)
				{
					string vCode = txt_styleCd.Text;
					vCode = vCode.Substring(0, 6) + "-" + vCode.Substring(6, 3);
					cmb_style.SelectedValue = vCode;

					if (cmb_style.SelectedValue != null)
					{
						Tbtn_SearchProcess();
					}
				}
			}
			catch //(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs_StyleCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}

		private void mnu_Remarks_Click_1(object sender, System.EventArgs e)
		{
			try
			{
				if (!Etc_ProvisoValidateCheck(_validate_remarks))
					return;

				int vRow = fgrid_main.Row;
				int vCol = fgrid_main.Col;

				string[] vData;
				CellRange vRange = fgrid_main.GetCellRange(vRow, vCol, vRow, vCol);
				string vEditable = fgrid_main.Cols[vCol].AllowEditing.ToString();

				if (vRange.UserData == null)
					vRange.UserData = new string[4];

				vData = (string[])vRange.UserData;

				COM.ComVar.Parameter_PopUp = new string[] { COM.ComFunction.Empty_Combo(cmb_factory, ""),
															  COM.ComFunction.Empty_Combo(cmb_shipType, ""),
															  cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLOT_NO].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLOT_SEQ].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxSTYLE_CD].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxSTYLE_NAME].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLINE_CD].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxGENDER].ToString(),
															  fgrid_main[_mrpShipNoRow, vCol].ToString(),
															  vData[0], vData[1], vData[2], vData[3], vEditable
														  };

				Pop_BM_Shipping_Schedule_Remarks vPop = new Pop_BM_Shipping_Schedule_Remarks();
				vPop.ShowDialog();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Remarks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}		
		}

		private void mnu_findData_Click(object sender, System.EventArgs e)
		{
			finder = new Pop_Finder(fgrid_main, 1, fgrid_main.Cols.Count - 1);
			finder.Show();
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
				return;

			int vRow = fgrid_main.Row;

			if ( e.Button == MouseButtons.Right && vRow >= fgrid_main.Rows.Fixed )
				ctx_main.Show(fgrid_main, new Point(e.X, e.Y));
			else
			{
				if (fgrid_main.MouseRow < fgrid_main.Rows.Fixed)
				{
					fgrid_main.Sort(SortFlags.Ascending, fgrid_main.MouseCol);
				}
				else
				{
					if (fgrid_main.Col < fgrid_main.Cols.Frozen)
					{
						int vCol = fgrid_main.Cols.Frozen;

						while (vCol < fgrid_main.Cols.Count)
						{
							if ( fgrid_main[vRow, vCol] != null )
							{
								fgrid_main.LeftCol = vCol - 1;
								break;
							}

							vCol++;
						}
					}
					else
					{
						CellRange vRange = fgrid_main.Selection;
						int vTemp = 0;

						for (int i = fgrid_main.Cols.Frozen ; i <= vRange.c2 ; i++)
							vTemp += Convert.ToInt32(ClassLib.ComFunction.NullCheck(fgrid_main[vRow, i], "0"));

						stbar.Panels[1].Text = vTemp.ToString();
					}
				}
			}
		}

		private void fgrid_main_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="F" || e.KeyValue.ToString()=="f")
			{		
				if(e.Modifiers.ToString().Equals("Control")) mnu_findData_Click(null, null);	
			}			
		}

		private void fgrid_main_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if (e.Control && e.KeyCode == Keys.A)
				{
					fgrid_main.SelectAll();
				}
				else if (e.Control && e.KeyCode == Keys.C)
				{
					DataCopy(sender as COM.FSP);
				}
			}
			catch (Exception ex) 
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void DataCopy(COM.FSP arg_grid)
		{
			int rIdx = (arg_grid.Selection.r2 - arg_grid.Selection.r1) + 1;
			rIdx += arg_grid.Rows.Fixed - 1;
			int cIdx = (arg_grid.Selection.c2 - arg_grid.Selection.c1) + 1;

			string copyData = "";
			_copyRange = new object[rIdx][];

			for (int idx = 0; idx < _copyRange.Length; idx++)
			{
				_copyRange[idx] = new object[cIdx];
			}

			// Title
			for (int nRow = 1, oRow = 0; nRow <= arg_grid.Rows.Fixed - 2; nRow++, oRow++)
			{
				for (int nCol = arg_grid.Selection.c1, oCol = 0; nCol <= arg_grid.Selection.c2; nCol++, oCol++)
				{
					_copyRange[oRow][oCol] = arg_grid[nRow, nCol];
					copyData += arg_grid[nRow, nCol] + (nCol == arg_grid.Selection.c2 ? "\n" : "\t");
				}
			}

			// Data
			for (int nRow = arg_grid.Selection.r1, oRow = arg_grid.Rows.Fixed - 1; nRow <= arg_grid.Selection.r2; nRow++, oRow++)
			{
				for (int nCol = arg_grid.Selection.c1, oCol = 0; nCol <= arg_grid.Selection.c2; nCol++, oCol++)
				{
					_copyRange[oRow][oCol] = arg_grid[nRow, nCol];
					copyData += arg_grid[nRow, nCol] + (nCol == arg_grid.Selection.c2 ? "\n" : "\t");
				}
			}

			Clipboard.SetDataObject(copyData, true);
		}

      
	}
}

