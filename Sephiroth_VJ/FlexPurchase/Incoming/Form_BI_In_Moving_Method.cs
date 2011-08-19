using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Incoming
{
	public class Form_BI_In_Moving_Method : COM.PCHWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label lbl_inYmd;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private C1.Win.C1List.C1Combo cmb_barKind;
		private System.Windows.Forms.Label lbl_barKind;
		private COM.FSP fgrid_main;
		private System.ComponentModel.IContainer components = null;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB	= new COM.OraDB();
		private bool _isAccessible	= false;
		private System.Windows.Forms.Label lbl_headInfo;
		
//		private int _lxCustCdCol		= (int)ClassLib.TBSBI_IN_MOVING_METHOD.IxCUST_CD;
		private int _lxCustNameCol		= (int)ClassLib.TBSBI_IN_MOVING_METHOD.IxCUST_NAME;
		private int _lxFirstClassCol	= (int)ClassLib.TBSBI_IN_MOVING_METHOD.IxFIRST_CLASS;
		private int _lxFactoryCol		= (int)ClassLib.TBSBI_IN_MOVING_METHOD.IxFACTORY;

		#endregion

		#region 생성자 / 소멸자
		public Form_BI_In_Moving_Method()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BI_In_Moving_Method));
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
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_main = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.cmb_barKind = new C1.Win.C1List.C1Combo();
            this.lbl_barKind = new System.Windows.Forms.Label();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_inYmd = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barKind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
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
            this.c1Sizer1.GridDefinition = "13.9655172413793:False:True;83.9655172413793:False:False;\t0.393700787401575:False" +
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
            this.fgrid_main.Location = new System.Drawing.Point(12, 89);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(992, 487);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 34;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.cmb_barKind);
            this.pnl_head.Controls.Add(this.lbl_barKind);
            this.pnl_head.Controls.Add(this.cmb_user);
            this.pnl_head.Controls.Add(this.lbl_user);
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_inYmd);
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
            this.pnl_head.Size = new System.Drawing.Size(1000, 81);
            this.pnl_head.TabIndex = 33;
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
            this.lbl_headInfo.TabIndex = 411;
            this.lbl_headInfo.Text = "       Item Moving Method  Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_barKind
            // 
            this.cmb_barKind.AddItemCols = 0;
            this.cmb_barKind.AddItemSeparator = ';';
            this.cmb_barKind.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_barKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_barKind.Caption = "";
            this.cmb_barKind.CaptionHeight = 17;
            this.cmb_barKind.CaptionStyle = style33;
            this.cmb_barKind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_barKind.ColumnCaptionHeight = 18;
            this.cmb_barKind.ColumnFooterHeight = 18;
            this.cmb_barKind.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_barKind.ContentHeight = 16;
            this.cmb_barKind.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_barKind.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_barKind.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_barKind.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_barKind.EditorHeight = 16;
            this.cmb_barKind.EvenRowStyle = style34;
            this.cmb_barKind.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_barKind.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barKind.FooterStyle = style35;
            this.cmb_barKind.GapHeight = 2;
            this.cmb_barKind.HeadingStyle = style36;
            this.cmb_barKind.HighLightRowStyle = style37;
            this.cmb_barKind.ItemHeight = 15;
            this.cmb_barKind.Location = new System.Drawing.Point(773, 33);
            this.cmb_barKind.MatchEntryTimeout = ((long)(2000));
            this.cmb_barKind.MaxDropDownItems = ((short)(5));
            this.cmb_barKind.MaxLength = 32767;
            this.cmb_barKind.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_barKind.Name = "cmb_barKind";
            this.cmb_barKind.OddRowStyle = style38;
            this.cmb_barKind.PartialRightColumn = false;
            this.cmb_barKind.PropBag = resources.GetString("cmb_barKind.PropBag");
            this.cmb_barKind.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_barKind.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_barKind.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_barKind.SelectedStyle = style39;
            this.cmb_barKind.Size = new System.Drawing.Size(220, 20);
            this.cmb_barKind.Style = style40;
            this.cmb_barKind.TabIndex = 410;
            // 
            // lbl_barKind
            // 
            this.lbl_barKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_barKind.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barKind.ImageIndex = 0;
            this.lbl_barKind.ImageList = this.img_Label;
            this.lbl_barKind.Location = new System.Drawing.Point(672, 33);
            this.lbl_barKind.Name = "lbl_barKind";
            this.lbl_barKind.Size = new System.Drawing.Size(100, 21);
            this.lbl_barKind.TabIndex = 409;
            this.lbl_barKind.Text = "Barcode Kind";
            this.lbl_barKind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_user
            // 
            this.cmb_user.AddItemCols = 0;
            this.cmb_user.AddItemSeparator = ';';
            this.cmb_user.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_user.Caption = "";
            this.cmb_user.CaptionHeight = 17;
            this.cmb_user.CaptionStyle = style41;
            this.cmb_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_user.ColumnCaptionHeight = 18;
            this.cmb_user.ColumnFooterHeight = 18;
            this.cmb_user.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_user.ContentHeight = 16;
            this.cmb_user.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_user.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_user.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_user.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_user.EditorHeight = 16;
            this.cmb_user.EvenRowStyle = style42;
            this.cmb_user.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FooterStyle = style43;
            this.cmb_user.GapHeight = 2;
            this.cmb_user.HeadingStyle = style44;
            this.cmb_user.HighLightRowStyle = style45;
            this.cmb_user.ItemHeight = 15;
            this.cmb_user.Location = new System.Drawing.Point(440, 55);
            this.cmb_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_user.MaxDropDownItems = ((short)(5));
            this.cmb_user.MaxLength = 32767;
            this.cmb_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.OddRowStyle = style46;
            this.cmb_user.PartialRightColumn = false;
            this.cmb_user.PropBag = resources.GetString("cmb_user.PropBag");
            this.cmb_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_user.SelectedStyle = style47;
            this.cmb_user.Size = new System.Drawing.Size(220, 20);
            this.cmb_user.Style = style48;
            this.cmb_user.TabIndex = 390;
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ImageIndex = 0;
            this.lbl_user.ImageList = this.img_Label;
            this.lbl_user.Location = new System.Drawing.Point(339, 55);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_user.TabIndex = 391;
            this.lbl_user.Text = "User";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(339, 33);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 389;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(440, 33);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 387;
            this.txt_vendorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vendorCode_KeyPress);
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemCols = 0;
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style49;
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
            this.cmb_vendor.EvenRowStyle = style50;
            this.cmb_vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style51;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style52;
            this.cmb_vendor.HighLightRowStyle = style53;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(520, 33);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style54;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style55;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style56;
            this.cmb_vendor.TabIndex = 388;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(212, 56);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(8, 16);
            this.lblexcep_mark.TabIndex = 386;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(230, 55);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(99, 21);
            this.dpick_to.TabIndex = 385;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 55);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(99, 21);
            this.dpick_from.TabIndex = 381;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 65);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_inYmd
            // 
            this.lbl_inYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inYmd.ImageIndex = 1;
            this.lbl_inYmd.ImageList = this.img_Label;
            this.lbl_inYmd.Location = new System.Drawing.Point(8, 55);
            this.lbl_inYmd.Name = "lbl_inYmd";
            this.lbl_inYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_inYmd.TabIndex = 50;
            this.lbl_inYmd.Text = "Incoming Date";
            this.lbl_inYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style57;
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
            this.cmb_factory.EvenRowStyle = style58;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style59;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style60;
            this.cmb_factory.HighLightRowStyle = style61;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 33);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style62;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style63;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style64;
            this.cmb_factory.TabIndex = 1;
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
            this.pic_head7.Size = new System.Drawing.Size(101, 40);
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
            this.pictureBox1.Location = new System.Drawing.Point(168, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 18);
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // Form_BI_In_Moving_Method
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BI_In_Moving_Method";
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barKind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
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
	
		#region 그리드 이벤트 처리

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

		private void cmb_vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_VendorSelectedValueChangedProcess();
		}

		private void txt_vendorCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
			{
				Txt_VendorCodeTextChangedProcess();		
				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
			}
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			dpick_to.Value = dpick_from.Value; 
		}

		#region 입력이동

		#endregion

		#region 버튼효과

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
			// Form init
//			ClassLib.ComFunction.Init_Form_Control(this);


            lbl_MainTitle.Text = "Inquire Incoming by Transport Method";
            this.Text = lbl_MainTitle.Text;
            ClassLib.ComFunction.SetLangDic(this);


			// Grid setting
			fgrid_main.Set_Grid("SBI_IN_MOVING_METHOD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Rows[0].AllowMerging = true;
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);
			
			DataTable vDt = null;

			// Factory combobox add items
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, true);
			cmb_factory.SelectedValue		= ClassLib.ComVar.This_Factory;
			vDt.Dispose();
			cmb_factory.SelectedIndex = 0;

			// cmb_user
			vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_user,1,2,(vDt.Rows.Count > 1) ? true : false);
			cmb_user.SelectedValue = COM.ComVar.This_User;
			vDt.Dispose();

			// bar_kind set    cmb_barKind
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBS05");
			COM.ComCtl.Set_ComboList(vDt, cmb_barKind, 1, 2, true, 56,0);
			cmb_barKind.SelectedIndex = -1;
			
			// Disabled tbutton
			tbtn_Save.Enabled	 = false;
			tbtn_Delete.Enabled  = false;
			tbtn_Confirm.Enabled = false;
			tbtn_Create.Enabled  = false;

			// set up styles
			CellStyle s = fgrid_main.Styles[CellStyleEnum.Subtotal0];
			s.BackColor = ClassLib.ComVar.ClrLevel_1st;
			s.ForeColor = Color.Black;

			s = fgrid_main.Styles[CellStyleEnum.Subtotal1];
			s.BackColor = ClassLib.ComVar.ClrLevel_2nd;
			s.ForeColor = Color.Black;

			s = fgrid_main.Styles[CellStyleEnum.Subtotal2];
			s.BackColor = ClassLib.ComVar.ClrLevel_3rd;
			s.ForeColor = Color.Black;

			s = fgrid_main.Styles[CellStyleEnum.Subtotal3];
			s.BackColor = ClassLib.ComVar.ClrLightSel;
			s.ForeColor = Color.Black;
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();
				this.cmb_factory.SelectedIndex		= -1;
				this.cmb_user.SelectedIndex			= -1;
				this.cmb_barKind.SelectedIndex		= -1;
//				this.cmb_vendor.SelectedIndex		= -1;
				this.txt_vendorCode.Text			= "";	
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				DataTable vTemp = this.SELECT_ITEM_MOVING_METHOD_LIST();
//				DataTable vDt   = new DataTable();
//				DataRow[] newRow = vTemp.Select("ORDER BY", "GROUP_CD");
//				vDt.Rows.Add(newRow);


				if (vTemp.Rows.Count > 0)
				{
					ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_main, vTemp);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
					SubTotalProcess();		
				}
				else
				{
					fgrid_main.ClearAll();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
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

		private void Tbtn_PrintProcess()
		{
			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 

			if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
			{

				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_In_Moving_Method");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Param_Combo(cmb_factory, "%") +		"' ";
				sPara += "'" + this.dpick_from.Text.Replace("-","") +		"' ";
				sPara += "'" + this.dpick_to.Text.Replace("-","") +		"' ";
				sPara += "'" + COM.ComFunction.Param_Combo(cmb_vendor, "%") +	"' ";
				sPara += "'" + COM.ComFunction.Param_Combo(cmb_user, "%") +	"' ";
				sPara += "'" + COM.ComFunction.Param_Combo(cmb_barKind, "%") +	"' ";
				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

				MyReport.Text = "Incoming Moving Method sheet";
				MyReport.Show();			
			}
		}

		private void SubTotalProcess()
		{
			// more setup
			fgrid_main.SubtotalPosition = SubtotalPositionEnum.AboveData;								
			fgrid_main.AllowDragging	= AllowDraggingEnum.None;
			fgrid_main.Tree.Column		= 3;

			fgrid_main.Subtotal(AggregateEnum.Clear);
			for (int c = 1; c < fgrid_main.Cols.Count; c++)
			{
				if ( fgrid_main.Cols[c].Style.Name.ToString().StartsWith("NUMBER"))
				{
					// calculate subtotals (three levels, totals on every column)
					fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1,			    c, "Total");
					fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxFactoryCol,    c,  "{0}");
					fgrid_main.Subtotal(AggregateEnum.Sum, 2, _lxCustNameCol,   c,  "{0}");
					fgrid_main.Subtotal(AggregateEnum.Sum, 3, _lxFirstClassCol, c,  "{0}");
				}
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
					txt_vendorCode.Text		 = cmb_vendor.SelectedValue.ToString();
					cmb_vendor.SelectedValue = txt_vendorCode.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBI_IN_ADJUST_VENDOR : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_style_cd">스타일코드</param>
		/// <param name="arg_gender">젠더</param>
		/// <param name="arg_dev">Dev</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_ITEM_MOVING_METHOD_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_MOVING_METHOD.SELECT_ITEM_MOVING_METHOD_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_IN_TO";
			MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[4] = "ARG_USER";
			MyOraDB.Parameter_Name[5] = "ARG_BAR_KIND";
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
			MyOraDB.Parameter_Values[0] = this.cmb_factory.SelectedIndex > -1 ? this.cmb_factory.SelectedValue.ToString() : "";
			MyOraDB.Parameter_Values[1] = this.dpick_from.Text.Replace("-","");
			MyOraDB.Parameter_Values[2] = this.dpick_to.Text.Replace("-","");
			MyOraDB.Parameter_Values[3] = this.cmb_vendor.SelectedIndex  > -1 ? this.cmb_vendor.SelectedValue.ToString()  : "";
			MyOraDB.Parameter_Values[4] = this.cmb_user.SelectedIndex    > -1 ? this.cmb_user.SelectedValue.ToString()    : "";
			MyOraDB.Parameter_Values[5] = this.cmb_barKind.SelectedIndex > -1 ? this.cmb_barKind.SelectedValue.ToString() : "";
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion																								




	}
}

