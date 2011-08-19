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
	public class Form_BO_Search : COM.PCHWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label lbl_between;
		private C1.Win.C1List.C1Combo cmb_outDiv;
		private System.Windows.Forms.Label lbl_ProcessDiv;
		private System.Windows.Forms.Label lbl_workYmd;
		private System.Windows.Forms.Label lbl_workProcess;
		private C1.Win.C1List.C1Combo cmb_workProcess;
		private C1.Win.C1List.C1Combo cmb_workLine;
		private System.Windows.Forms.Label lbl_workLine;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private COM.FSP fgrid_main;
		private C1.Win.C1List.C1Combo cmb_Option;
		private System.Windows.Forms.Label lbl_Print;
		private System.Windows.Forms.DateTimePicker dpick_From_Ymd;
		private System.Windows.Forms.DateTimePicker dpick_To_Ymd;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.TextBox txt_itemCd;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public Form_BO_Search()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();

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

		#region 사용자 정의 변수
		private COM.OraDB MyOraDB   = new COM.OraDB();
		#endregion

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BO_Search));
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
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_Option = new C1.Win.C1List.C1Combo();
            this.lbl_Print = new System.Windows.Forms.Label();
            this.lbl_between = new System.Windows.Forms.Label();
            this.dpick_To_Ymd = new System.Windows.Forms.DateTimePicker();
            this.cmb_outDiv = new C1.Win.C1List.C1Combo();
            this.lbl_ProcessDiv = new System.Windows.Forms.Label();
            this.dpick_From_Ymd = new System.Windows.Forms.DateTimePicker();
            this.lbl_workYmd = new System.Windows.Forms.Label();
            this.lbl_workProcess = new System.Windows.Forms.Label();
            this.cmb_workProcess = new C1.Win.C1List.C1Combo();
            this.cmb_workLine = new C1.Win.C1List.C1Combo();
            this.lbl_workLine = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.fgrid_main = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.GridDefinition = "17.9310344827586:False:True;81.3793103448276:False:False;\t0.393700787401575:False" +
                ":True;98.4251968503937:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 43);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
            this.c1Sizer1.TabIndex = 29;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.txt_itemNm);
            this.pnl_head.Controls.Add(this.txt_itemCd);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.cmb_Option);
            this.pnl_head.Controls.Add(this.lbl_Print);
            this.pnl_head.Controls.Add(this.lbl_between);
            this.pnl_head.Controls.Add(this.dpick_To_Ymd);
            this.pnl_head.Controls.Add(this.cmb_outDiv);
            this.pnl_head.Controls.Add(this.lbl_ProcessDiv);
            this.pnl_head.Controls.Add(this.dpick_From_Ymd);
            this.pnl_head.Controls.Add(this.lbl_workYmd);
            this.pnl_head.Controls.Add(this.lbl_workProcess);
            this.pnl_head.Controls.Add(this.cmb_workProcess);
            this.pnl_head.Controls.Add(this.cmb_workLine);
            this.pnl_head.Controls.Add(this.lbl_workLine);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 104);
            this.pnl_head.TabIndex = 1;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style1;
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
            this.cmb_itemGroup.EvenRowStyle = style2;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style3;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style4;
            this.cmb_itemGroup.HighLightRowStyle = style5;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(441, 78);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style6;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style7;
            this.cmb_itemGroup.Size = new System.Drawing.Size(200, 20);
            this.cmb_itemGroup.Style = style8;
            this.cmb_itemGroup.TabIndex = 415;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(340, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 414;
            this.label1.Text = "Item Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(831, 78);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(162, 21);
            this.txt_itemNm.TabIndex = 413;
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(774, 78);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(56, 21);
            this.txt_itemCd.TabIndex = 412;
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(635, 78);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(32, 21);
            this.btn_groupSearch.TabIndex = 411;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(673, 78);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 409;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Option
            // 
            this.cmb_Option.AddItemCols = 0;
            this.cmb_Option.AddItemSeparator = ';';
            this.cmb_Option.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Option.Caption = "";
            this.cmb_Option.CaptionHeight = 17;
            this.cmb_Option.CaptionStyle = style9;
            this.cmb_Option.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Option.ColumnCaptionHeight = 18;
            this.cmb_Option.ColumnFooterHeight = 18;
            this.cmb_Option.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Option.ContentHeight = 16;
            this.cmb_Option.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Option.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Option.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Option.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Option.EditorHeight = 16;
            this.cmb_Option.EvenRowStyle = style10;
            this.cmb_Option.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Option.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Option.FooterStyle = style11;
            this.cmb_Option.GapHeight = 2;
            this.cmb_Option.HeadingStyle = style12;
            this.cmb_Option.HighLightRowStyle = style13;
            this.cmb_Option.ItemHeight = 15;
            this.cmb_Option.Location = new System.Drawing.Point(441, 34);
            this.cmb_Option.MatchEntryTimeout = ((long)(2000));
            this.cmb_Option.MaxDropDownItems = ((short)(5));
            this.cmb_Option.MaxLength = 32767;
            this.cmb_Option.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Option.Name = "cmb_Option";
            this.cmb_Option.OddRowStyle = style14;
            this.cmb_Option.PartialRightColumn = false;
            this.cmb_Option.PropBag = resources.GetString("cmb_Option.PropBag");
            this.cmb_Option.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Option.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Option.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Option.SelectedStyle = style15;
            this.cmb_Option.Size = new System.Drawing.Size(553, 20);
            this.cmb_Option.Style = style16;
            this.cmb_Option.TabIndex = 406;
            this.cmb_Option.TextChanged += new System.EventHandler(this.cmb_Option_TextChanged);
            // 
            // lbl_Print
            // 
            this.lbl_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Print.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Print.ImageIndex = 1;
            this.lbl_Print.ImageList = this.img_Label;
            this.lbl_Print.Location = new System.Drawing.Point(340, 34);
            this.lbl_Print.Name = "lbl_Print";
            this.lbl_Print.Size = new System.Drawing.Size(100, 21);
            this.lbl_Print.TabIndex = 407;
            this.lbl_Print.Text = "Option";
            this.lbl_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_between
            // 
            this.lbl_between.Location = new System.Drawing.Point(211, 78);
            this.lbl_between.Name = "lbl_between";
            this.lbl_between.Size = new System.Drawing.Size(16, 16);
            this.lbl_between.TabIndex = 405;
            this.lbl_between.Text = "~";
            // 
            // dpick_To_Ymd
            // 
            this.dpick_To_Ymd.CustomFormat = "";
            this.dpick_To_Ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_To_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_To_Ymd.Location = new System.Drawing.Point(231, 78);
            this.dpick_To_Ymd.Name = "dpick_To_Ymd";
            this.dpick_To_Ymd.Size = new System.Drawing.Size(99, 21);
            this.dpick_To_Ymd.TabIndex = 6;
            // 
            // cmb_outDiv
            // 
            this.cmb_outDiv.AddItemCols = 0;
            this.cmb_outDiv.AddItemSeparator = ';';
            this.cmb_outDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outDiv.Caption = "";
            this.cmb_outDiv.CaptionHeight = 17;
            this.cmb_outDiv.CaptionStyle = style17;
            this.cmb_outDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_outDiv.ColumnCaptionHeight = 18;
            this.cmb_outDiv.ColumnFooterHeight = 18;
            this.cmb_outDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_outDiv.ContentHeight = 16;
            this.cmb_outDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_outDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_outDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_outDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_outDiv.EditorHeight = 16;
            this.cmb_outDiv.EvenRowStyle = style18;
            this.cmb_outDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_outDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outDiv.FooterStyle = style19;
            this.cmb_outDiv.GapHeight = 2;
            this.cmb_outDiv.HeadingStyle = style20;
            this.cmb_outDiv.HighLightRowStyle = style21;
            this.cmb_outDiv.ItemHeight = 15;
            this.cmb_outDiv.Location = new System.Drawing.Point(109, 56);
            this.cmb_outDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_outDiv.MaxDropDownItems = ((short)(5));
            this.cmb_outDiv.MaxLength = 32767;
            this.cmb_outDiv.MouseCursor = System.Windows.Forms.Cursors.IBeam;
            this.cmb_outDiv.Name = "cmb_outDiv";
            this.cmb_outDiv.OddRowStyle = style22;
            this.cmb_outDiv.PartialRightColumn = false;
            this.cmb_outDiv.PropBag = resources.GetString("cmb_outDiv.PropBag");
            this.cmb_outDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outDiv.SelectedStyle = style23;
            this.cmb_outDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_outDiv.Style = style24;
            this.cmb_outDiv.TabIndex = 397;
            // 
            // lbl_ProcessDiv
            // 
            this.lbl_ProcessDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ProcessDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProcessDiv.ImageIndex = 1;
            this.lbl_ProcessDiv.ImageList = this.img_Label;
            this.lbl_ProcessDiv.Location = new System.Drawing.Point(8, 56);
            this.lbl_ProcessDiv.Name = "lbl_ProcessDiv";
            this.lbl_ProcessDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_ProcessDiv.TabIndex = 398;
            this.lbl_ProcessDiv.Text = "Out Division";
            this.lbl_ProcessDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_From_Ymd
            // 
            this.dpick_From_Ymd.CustomFormat = "";
            this.dpick_From_Ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_From_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_From_Ymd.Location = new System.Drawing.Point(109, 78);
            this.dpick_From_Ymd.Name = "dpick_From_Ymd";
            this.dpick_From_Ymd.Size = new System.Drawing.Size(99, 21);
            this.dpick_From_Ymd.TabIndex = 5;
            // 
            // lbl_workYmd
            // 
            this.lbl_workYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workYmd.ImageIndex = 1;
            this.lbl_workYmd.ImageList = this.img_Label;
            this.lbl_workYmd.Location = new System.Drawing.Point(8, 78);
            this.lbl_workYmd.Name = "lbl_workYmd";
            this.lbl_workYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_workYmd.TabIndex = 50;
            this.lbl_workYmd.Text = "Work Date";
            this.lbl_workYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_workProcess
            // 
            this.lbl_workProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workProcess.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workProcess.ImageIndex = 1;
            this.lbl_workProcess.ImageList = this.img_Label;
            this.lbl_workProcess.Location = new System.Drawing.Point(340, 56);
            this.lbl_workProcess.Name = "lbl_workProcess";
            this.lbl_workProcess.Size = new System.Drawing.Size(100, 21);
            this.lbl_workProcess.TabIndex = 379;
            this.lbl_workProcess.Text = "Work Process";
            this.lbl_workProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_workProcess
            // 
            this.cmb_workProcess.AddItemCols = 0;
            this.cmb_workProcess.AddItemSeparator = ';';
            this.cmb_workProcess.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_workProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_workProcess.Caption = "";
            this.cmb_workProcess.CaptionHeight = 17;
            this.cmb_workProcess.CaptionStyle = style25;
            this.cmb_workProcess.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_workProcess.ColumnCaptionHeight = 18;
            this.cmb_workProcess.ColumnFooterHeight = 18;
            this.cmb_workProcess.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_workProcess.ContentHeight = 16;
            this.cmb_workProcess.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_workProcess.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_workProcess.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_workProcess.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_workProcess.EditorHeight = 16;
            this.cmb_workProcess.EvenRowStyle = style26;
            this.cmb_workProcess.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_workProcess.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_workProcess.FooterStyle = style27;
            this.cmb_workProcess.GapHeight = 2;
            this.cmb_workProcess.HeadingStyle = style28;
            this.cmb_workProcess.HighLightRowStyle = style29;
            this.cmb_workProcess.ItemHeight = 15;
            this.cmb_workProcess.Location = new System.Drawing.Point(441, 56);
            this.cmb_workProcess.MatchEntryTimeout = ((long)(2000));
            this.cmb_workProcess.MaxDropDownItems = ((short)(5));
            this.cmb_workProcess.MaxLength = 32767;
            this.cmb_workProcess.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_workProcess.Name = "cmb_workProcess";
            this.cmb_workProcess.OddRowStyle = style30;
            this.cmb_workProcess.PartialRightColumn = false;
            this.cmb_workProcess.PropBag = resources.GetString("cmb_workProcess.PropBag");
            this.cmb_workProcess.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_workProcess.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_workProcess.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_workProcess.SelectedStyle = style31;
            this.cmb_workProcess.Size = new System.Drawing.Size(220, 20);
            this.cmb_workProcess.Style = style32;
            this.cmb_workProcess.TabIndex = 0;
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
            this.cmb_workLine.Location = new System.Drawing.Point(774, 56);
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
            this.cmb_workLine.TabIndex = 8;
            // 
            // lbl_workLine
            // 
            this.lbl_workLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workLine.ImageIndex = 1;
            this.lbl_workLine.ImageList = this.img_Label;
            this.lbl_workLine.Location = new System.Drawing.Point(673, 56);
            this.lbl_workLine.Name = "lbl_workLine";
            this.lbl_workLine.Size = new System.Drawing.Size(100, 21);
            this.lbl_workLine.TabIndex = 375;
            this.lbl_workLine.Text = "Work Line";
            this.lbl_workLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style41;
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
            this.cmb_factory.EvenRowStyle = style42;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style43;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style44;
            this.cmb_factory.HighLightRowStyle = style45;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 34);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style46;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style47;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style48;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.TextChanged += new System.EventHandler(this.cmb_factory_TextChanged);
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 88);
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
            this.pic_head4.Location = new System.Drawing.Point(136, 87);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 34);
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
            this.pic_head7.Size = new System.Drawing.Size(101, 63);
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
            this.label2.Text = "      Production Outgoin  Info";
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
            this.pic_head5.Location = new System.Drawing.Point(0, 88);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 77);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(8, 108);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(1000, 472);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 13;
            // 
            // Form_BO_Search
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BO_Search";
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 공통 메서드
		private void Init_Form()
		{						
			// Form Setting

			lbl_MainTitle.Text = " Outgoing Search";
            this.Text = " Outgoing Search";
            ClassLib.ComFunction.SetLangDic(this);

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// cmb_print_type		
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBO03");
			COM.ComCtl.Set_ComboList(vDt,cmb_Option, 1, 2, false, 56,0);
			cmb_Option.SelectedIndex = -1;

			// cmb_workLine
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, false);
			vDt.Dispose() ;

			//	cmb_workProcess
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Opcd_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_workProcess, 1, 1, false);
			vDt.Dispose() ;

			// Process Outgoing division set    cmb_outDiv
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, false, 56, 0);
			cmb_outDiv.SelectedIndex = 0;

			// Grid Setting
			fgrid_main.Set_Grid("SBO_OUTGOING_SEARCH", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Rows[0].AllowMerging = true;
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);


			// Item Group Combobox Setting
			vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
			vDt.Dispose();


            //--------------------------------------
			tbtn_Save.Enabled     = false;
			tbtn_Append.Enabled   = false;
			tbtn_Delete.Enabled   = false;
			tbtn_Insert.Enabled   = false;
			tbtn_Create.Enabled   = false;


			//-----------------------------------
			dpick_From_Ymd.Enabled  = false;
			dpick_To_Ymd.Enabled    = false;			   
			cmb_outDiv.Enabled	    = false;

			cmb_workProcess.Enabled = false;
			cmb_workLine.Enabled    = false;
			
			txt_itemNm.Enabled  = false;
			txt_itemCd.Enabled  = false;
			btn_groupSearch.Enabled  = false;

			

		}


		private void Set_Option_Print(string arg_flag)
		{		
			if (arg_flag =="1") 
			{
               dpick_From_Ymd.Enabled     = true;
			   dpick_To_Ymd.Enabled       = true;
			   
			   cmb_outDiv.Enabled         = false;
			   cmb_workProcess.Enabled    = false;
			   cmb_workLine.Enabled       = false;

			   cmb_itemGroup.Enabled      = false;
			   txt_itemNm.Enabled         = false;
			   txt_itemCd.Enabled         = false;
			   btn_groupSearch.Enabled    = false;
			   fgrid_main.Set_Grid("SBO_OUTGOING_SEARCH", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			}


			if (arg_flag =="2") 
			{
				dpick_From_Ymd.Enabled    = true;
				dpick_To_Ymd.Enabled      = true;
			   
				cmb_outDiv.Enabled        = false;
				cmb_workProcess.Enabled   = true;
				cmb_workLine.Enabled      = true;

				cmb_itemGroup.Enabled     = true;
				txt_itemNm.Enabled        = true;
				txt_itemCd.Enabled        = true;
				btn_groupSearch.Enabled   = true;

				fgrid_main.Set_Grid("SBO_OUTGOING_SEARCH", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			}


			
			if (arg_flag =="3") 
			{
				dpick_From_Ymd.Enabled   = true;
				dpick_To_Ymd.Enabled     = true;
			   
				cmb_outDiv.Enabled       = true;
				cmb_workProcess.Enabled  = true;
				cmb_workLine.Enabled     = true;

				cmb_itemGroup.Enabled	 = true;
				txt_itemNm.Enabled		 = true;
				txt_itemCd.Enabled		 = true;
				btn_groupSearch.Enabled  = true;

				fgrid_main.Set_Grid("SBO_OUTGOING_SEARCH", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			}

		}


		private  bool Tbtn_ConfirmProcess()
		{
			try
			{   				
				
				MyOraDB.ReDim_Parameter(4);

				MyOraDB.Process_Name = "pkg_sbo_out_print.save_sbo_out_list_01";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "arg_factory";
				MyOraDB.Parameter_Name[1] = "arg_work_proc";
				MyOraDB.Parameter_Name[2] = "arg_out_from_ymd";
				MyOraDB.Parameter_Name[3] = "arg_out_to_ymd";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, " ");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_workProcess, " ");
				MyOraDB.Parameter_Values[2] = this.dpick_From_Ymd.Text.Replace("-","");
				MyOraDB.Parameter_Values[3] = this.dpick_To_Ymd.Text.Replace("-","");

				MyOraDB.Add_Modify_Parameter(true);

				MyOraDB.Exe_Modify_Procedure();
					
		

			return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
				return false;
			}		
		}



		private void Tbtn_PrintProcess()
		{
			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 

			#region  Option 1

			if (cmb_Option.SelectedValue.ToString() =="1")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_01");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","") +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","") +		"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion

			#region  Option 2

			if (cmb_Option.SelectedValue.ToString() =="2")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_02");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				sPara += "'" + this.txt_itemCd.Text                          +		"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion


			#region  Option 3

			if (cmb_Option.SelectedValue.ToString() =="3")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_03");
				
				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd," ") +		"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion

		}

		#endregion

		#region  이벤트 처리
		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess(); 
		}


		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			DialogResult result = new DialogResult(); 

			result = ClassLib.ComFunction.User_Message("Do you want to calculate?", "Calculation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if ( result.ToString() == "Yes")
			{

				if (this.Tbtn_ConfirmProcess() == true)
					ClassLib.ComFunction.User_Message("Calcualation", "Okay", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					ClassLib.ComFunction.User_Message("Caution", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			else

				return;



		}


		
		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
			string vType = this.cmb_itemGroup.SelectedValue.ToString();
			FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vType);

			vPopup.ShowDialog();
			
			string _group_cd	= COM.ComVar.Parameter_PopUp[3];				
			string _group_name	= COM.ComVar.Parameter_PopUp[4];				
			txt_itemCd.Text		= _group_cd;
			txt_itemNm.Text		= _group_name;
			
			vPopup.Dispose();
		}


		
		private void cmb_Option_TextChanged(object sender, System.EventArgs e)
		{
			if ( cmb_Option.SelectedValue.ToString()  == "1" ) 
				Set_Option_Print("1");
			else if  ( cmb_Option.SelectedValue.ToString()  == "2") 
				Set_Option_Print("2");
			else if  ( cmb_Option.SelectedValue.ToString()  == "3") 
				Set_Option_Print("3");
			else
				Set_Option_Print("3");



		}



		#endregion

		private void cmb_factory_TextChanged(object sender, System.EventArgs e)
		{
		
		}



	}
}

