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

namespace FlexPurchase.Stock
{
	public class Form_BK_Remainder : COM.PCHWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_item;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private C1.Win.C1List.C1Combo cmb_Process;
		private C1.Win.C1List.C1Combo cmb_Line;
		private System.Windows.Forms.Label lbl_Line;
		private System.Windows.Forms.Label lbl_Process;
		private System.Windows.Forms.Label lbl_WorkDate;
		private System.Windows.Forms.TextBox txt_WorkDate;
		private System.Windows.Forms.Label lbl_headInfo;

		 
  
		public Form_BK_Remainder()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BK_Remainder));
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
            this.txt_WorkDate = new System.Windows.Forms.TextBox();
            this.lbl_WorkDate = new System.Windows.Forms.Label();
            this.cmb_Process = new C1.Win.C1List.C1Combo();
            this.cmb_Line = new C1.Win.C1List.C1Combo();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_Line = new System.Windows.Forms.Label();
            this.lbl_Process = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "18.1034482758621:False:True;79.8275862068966:False:False;\t0.393700787401575:False" +
                ":True;97.6377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.txt_WorkDate);
            this.pnl_head.Controls.Add(this.lbl_WorkDate);
            this.pnl_head.Controls.Add(this.cmb_Process);
            this.pnl_head.Controls.Add(this.cmb_Line);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.txt_itemName);
            this.pnl_head.Controls.Add(this.txt_itemCode);
            this.pnl_head.Controls.Add(this.lbl_itemgroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.lbl_Line);
            this.pnl_head.Controls.Add(this.lbl_Process);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pictureBox1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 105);
            this.pnl_head.TabIndex = 33;
            // 
            // txt_WorkDate
            // 
            this.txt_WorkDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_WorkDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_WorkDate.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_WorkDate.Location = new System.Drawing.Point(445, 77);
            this.txt_WorkDate.MaxLength = 500;
            this.txt_WorkDate.Name = "txt_WorkDate";
            this.txt_WorkDate.ReadOnly = true;
            this.txt_WorkDate.Size = new System.Drawing.Size(223, 21);
            this.txt_WorkDate.TabIndex = 447;
            // 
            // lbl_WorkDate
            // 
            this.lbl_WorkDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_WorkDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WorkDate.ImageIndex = 0;
            this.lbl_WorkDate.ImageList = this.img_Label;
            this.lbl_WorkDate.Location = new System.Drawing.Point(344, 77);
            this.lbl_WorkDate.Name = "lbl_WorkDate";
            this.lbl_WorkDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_WorkDate.TabIndex = 446;
            this.lbl_WorkDate.Text = "Work Date";
            this.lbl_WorkDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Process
            // 
            this.cmb_Process.AddItemCols = 0;
            this.cmb_Process.AddItemSeparator = ';';
            this.cmb_Process.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Process.Caption = "";
            this.cmb_Process.CaptionHeight = 17;
            this.cmb_Process.CaptionStyle = style1;
            this.cmb_Process.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Process.ColumnCaptionHeight = 18;
            this.cmb_Process.ColumnFooterHeight = 18;
            this.cmb_Process.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Process.ContentHeight = 16;
            this.cmb_Process.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Process.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Process.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Process.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Process.EditorHeight = 16;
            this.cmb_Process.EvenRowStyle = style2;
            this.cmb_Process.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Process.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Process.FooterStyle = style3;
            this.cmb_Process.GapHeight = 2;
            this.cmb_Process.HeadingStyle = style4;
            this.cmb_Process.HighLightRowStyle = style5;
            this.cmb_Process.ItemHeight = 15;
            this.cmb_Process.Location = new System.Drawing.Point(109, 55);
            this.cmb_Process.MatchEntryTimeout = ((long)(2000));
            this.cmb_Process.MaxDropDownItems = ((short)(5));
            this.cmb_Process.MaxLength = 32767;
            this.cmb_Process.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Process.Name = "cmb_Process";
            this.cmb_Process.OddRowStyle = style6;
            this.cmb_Process.PartialRightColumn = false;
            this.cmb_Process.PropBag = resources.GetString("cmb_Process.PropBag");
            this.cmb_Process.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Process.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Process.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Process.SelectedStyle = style7;
            this.cmb_Process.Size = new System.Drawing.Size(210, 20);
            this.cmb_Process.Style = style8;
            this.cmb_Process.TabIndex = 444;
            this.cmb_Process.SelectedValueChanged += new System.EventHandler(this.cmb_Process_SelectedValueChanged);
            // 
            // cmb_Line
            // 
            this.cmb_Line.AddItemCols = 0;
            this.cmb_Line.AddItemSeparator = ';';
            this.cmb_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Line.Caption = "";
            this.cmb_Line.CaptionHeight = 17;
            this.cmb_Line.CaptionStyle = style9;
            this.cmb_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Line.ColumnCaptionHeight = 18;
            this.cmb_Line.ColumnFooterHeight = 18;
            this.cmb_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Line.ContentHeight = 16;
            this.cmb_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Line.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Line.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Line.EditorHeight = 16;
            this.cmb_Line.EvenRowStyle = style10;
            this.cmb_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Line.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Line.FooterStyle = style11;
            this.cmb_Line.GapHeight = 2;
            this.cmb_Line.HeadingStyle = style12;
            this.cmb_Line.HighLightRowStyle = style13;
            this.cmb_Line.ItemHeight = 15;
            this.cmb_Line.Location = new System.Drawing.Point(109, 77);
            this.cmb_Line.MatchEntryTimeout = ((long)(2000));
            this.cmb_Line.MaxDropDownItems = ((short)(5));
            this.cmb_Line.MaxLength = 32767;
            this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Line.Name = "cmb_Line";
            this.cmb_Line.OddRowStyle = style14;
            this.cmb_Line.PartialRightColumn = false;
            this.cmb_Line.PropBag = resources.GetString("cmb_Line.PropBag");
            this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Line.SelectedStyle = style15;
            this.cmb_Line.Size = new System.Drawing.Size(210, 20);
            this.cmb_Line.Style = style16;
            this.cmb_Line.TabIndex = 445;
            this.cmb_Line.SelectedValueChanged += new System.EventHandler(this.cmb_Line_SelectedValueChanged);
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(546, 33);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.txt_itemGroup.TabIndex = 442;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style17;
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
            this.cmb_itemGroup.EvenRowStyle = style18;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style19;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style20;
            this.cmb_itemGroup.HighLightRowStyle = style21;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(445, 33);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style22;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style23;
            this.cmb_itemGroup.Size = new System.Drawing.Size(100, 20);
            this.cmb_itemGroup.Style = style24;
            this.cmb_itemGroup.TabIndex = 441;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(505, 55);
            this.txt_itemName.MaxLength = 500;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(163, 21);
            this.txt_itemName.TabIndex = 443;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(445, 55);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 439;
            // 
            // lbl_itemgroup
            // 
            this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemgroup.ImageIndex = 0;
            this.lbl_itemgroup.ImageList = this.img_Label;
            this.lbl_itemgroup.Location = new System.Drawing.Point(344, 33);
            this.lbl_itemgroup.Name = "lbl_itemgroup";
            this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemgroup.TabIndex = 437;
            this.lbl_itemgroup.Text = "Item Group";
            this.lbl_itemgroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(646, 33);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 440;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            this.btn_groupSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_groupSearch.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_groupSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(344, 55);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 438;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Line
            // 
            this.lbl_Line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Line.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Line.ImageIndex = 1;
            this.lbl_Line.ImageList = this.img_Label;
            this.lbl_Line.Location = new System.Drawing.Point(8, 77);
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(100, 21);
            this.lbl_Line.TabIndex = 426;
            this.lbl_Line.Text = "Line";
            this.lbl_Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Process
            // 
            this.lbl_Process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Process.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Process.ImageIndex = 1;
            this.lbl_Process.ImageList = this.img_Label;
            this.lbl_Process.Location = new System.Drawing.Point(8, 55);
            this.lbl_Process.Name = "lbl_Process";
            this.lbl_Process.Size = new System.Drawing.Size(100, 21);
            this.lbl_Process.TabIndex = 424;
            this.lbl_Process.Text = "Process";
            this.lbl_Process.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_factory.Location = new System.Drawing.Point(109, 33);
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
            this.cmb_factory.TabIndex = 422;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
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
            this.lbl_factory.TabIndex = 423;
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
            this.lbl_headInfo.TabIndex = 416;
            this.lbl_headInfo.Text = "       Remainder  Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 89);
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
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 64);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 89);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 78);
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
            this.pictureBox1.Location = new System.Drawing.Point(168, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 18);
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spd_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.spd_main.Location = new System.Drawing.Point(12, 113);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(992, 463);
            this.spd_main.TabIndex = 173;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // Form_BK_Remainder
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BK_Remainder";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	
		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction();
 

		private Hashtable _cellTypes = null;
		private Hashtable _cellData  = null;


		#endregion 

		#region 멤버 메소드
 

		/// <summary>
		/// Init_Form : 
		/// </summary>
		private void Init_Form()
		{
			try
			{

                //Title
                this.Text = "Remainder Adjust";
                lbl_MainTitle.Text = "Remainder Adjust";
                ClassLib.ComFunction.SetLangDic(this);
 
 
 
				// Grid Setting
				spd_main.Set_Spread_Comm("SBK_REMAINDER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
				// Farpoint Spread Header Merge
				Mearge_GridHead();


				//combobox setting
				Init_Control(); 
 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		/// <summary>
		/// Mearge_GridHead : Farpoint Spread Header Merge
		/// </summary>
		private void Mearge_GridHead()
		{
			
			try
			{

				for (int vCol = 0 ; vCol < spd_main.ActiveSheet.ColumnCount ; vCol++)
				{
					
					if (spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim().Equals(spd_main.ActiveSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()))
					{
						spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
					}
					else
					{
						int vCnt  = 0;
						
						for ( int j = vCol ; j < spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if( vCnt > 0 &&  spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								break;
							}
							else if ( spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							{
								vCnt++;
							}
						}

						vCol = vCol + vCnt-1;
					}
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mearge_GridHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

 

		/// <summary>
		/// Init_Control : combobox setting
		/// </summary>
		private void Init_Control()
		{
			DataTable dt_ret;


			// toolbar button disable setting
			tbtn_Delete.Enabled = false;
			tbtn_Confirm.Enabled = false;
 

			// factory set
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
 

			//그룹타입 콤보쿼리 
			dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_itemGroup, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);   

			dt_ret.Dispose(); 


			 


			// grid set
			_cellTypes = new Hashtable();
			_cellData  = new Hashtable();

			for (int vCount = 1 ; vCount < spd_main.ActiveSheet.Columns.Count ; vCount++)
			{
				if (spd_main.ActiveSheet.Columns[vCount].CellType.ToString().Equals(ClassLib.ComVar.SSPComboBoxCell))
				{
					COM.SSPComboBoxCellType sspBox = (COM.SSPComboBoxCellType)spd_main.ActiveSheet.Columns[vCount].CellType; 
					_cellTypes.Add(vCount, sspBox.DataDisplay);
					_cellData.Add( vCount, sspBox.DataValue);
				}

			} // end for




		}


		#endregion

		#region 이벤트 관련


		#region 툴바 관련

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_NewProcess();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_SaveProcess();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_PrintProcess();
		}




		private void Tbtn_NewProcess()
		{
			try
			{
				spd_main.ClearAll();

				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
				cmb_Process.SelectedIndex = -1;
				cmb_Line.SelectedIndex = -1;

				cmb_itemGroup.SelectedIndex = -1;
				txt_itemGroup.Text = "";
				txt_itemCode.Text = "";
				txt_itemName.Text = "";

				txt_WorkDate.Text = "";


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{		
		
				this.Cursor = Cursors.WaitCursor;


				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_Process, cmb_Line};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) return; 
 

				string factory = cmb_factory.SelectedValue.ToString();
				string process = cmb_Process.SelectedValue.ToString();
				string line = cmb_Line.SelectedValue.ToString(); 
				string item_group = _itemGroupCode;
				string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
				string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");
				 

				DataTable dt_ret = Select_SBK_REMAINDER(factory, process, line, item_group, item_cd, item_name);

				if(dt_ret.Rows.Count == 0) 
				{
					spd_main.ClearAll();
					txt_WorkDate.Text = "";
					return;
				}


				spd_main.Display_Grid(dt_ret);

				txt_WorkDate.Text = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBK_REMAINDER.IxWORK_YMD - 1].ToString() );


				ClassLib.ComFunction.MergeCell(spd_main, 
					                           new int[]{ (int)ClassLib.TBSBK_REMAINDER.IxITEM_NAME, 
															(int)ClassLib.TBSBK_REMAINDER.IxSPEC_NAME, 
															(int)ClassLib.TBSBK_REMAINDER.IxCOLOR_NAME } );



				string out_status = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBK_REMAINDER.IxOUT_STATUS - 1].ToString();

				if(out_status.Trim().Equals("S") )
				{ 
					string message = "Not yet confirm [" + txt_WorkDate.Text + "] outgoing production.";
					ClassLib.ComFunction.User_Message(message, "Remainder", MessageBoxButtons.OK, MessageBoxIcon.Information);
 

					spd_main.ActiveSheet.OperationMode = OperationMode.ReadOnly;
					tbtn_Save.Enabled = false;

				}
				else
				{ 
					spd_main.ActiveSheet.OperationMode = OperationMode.Normal; 
					tbtn_Save.Enabled = true;
				}

				dt_ret.Dispose();

 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SearchProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_Process, cmb_Line};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) return;


				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					if(MyOraDB.Save_Spread("PKG_SBK_REMAINDER.SAVE_SBK_REMAINDER", spd_main))
					{ 
						
						//spd_main.Refresh_Division();

						for(int i = spd_main.ActiveSheet.Rows.Count - 1; i >= 0; i--)
						{
							if(spd_main.ActiveSheet.Cells[i, 0].Tag == null || spd_main.ActiveSheet.Cells[i, 0].Tag.ToString() == "") continue;


							if(spd_main.ActiveSheet.Cells[i, 0].Tag.ToString() == "D")
							{
								spd_main.ActiveSheet.Rows.Remove(i, 1);
							} 

							

							//--------------------------------------------------------------------------------------
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBK_REMAINDER.IxREMAINDER_QTY].Value 
								= spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBK_REMAINDER.IxADJUST_QTY].Value; 
							//-------------------------------------------------------------------------------------- 



						} // end for i

						spd_main.ActiveSheet.ClearRange(0, 0, spd_main.ActiveSheet.Rows.Count, 1, false);  




						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					}
				}


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SaveProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		private void Tbtn_PrintProcess()
		{
		}


		#endregion

		#region 조회부 관련

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
 

			try
			{

				if(cmb_factory.SelectedIndex == -1) return;


				spd_main.ClearAll();
 
				cmb_Process.SelectedIndex = -1;
				cmb_Line.SelectedIndex = -1;

				cmb_itemGroup.SelectedIndex = -1;
				txt_itemGroup.Text = "";
				txt_itemCode.Text = "";
				txt_itemName.Text = "";

				txt_WorkDate.Text = "";



				DataTable dt_ret;

				//process setting 
				dt_ret = FlexPurchase.ClassLib.ComFunction.Select_Opcd_List(cmb_factory.SelectedValue.ToString() );
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Process, 1, 1, false, ClassLib.ComVar.ComboList_Visible.Code); 


				//line setting 
				dt_ret = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(cmb_factory.SelectedValue.ToString() );
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);  
  

				dt_ret.Dispose();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			

		}

		 

		private void cmb_Process_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
			try
			{ 

				spd_main.ClearAll(); 

				txt_WorkDate.Text = ""; 


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Process_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void cmb_Line_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
			try
			{ 

				spd_main.ClearAll(); 

				txt_WorkDate.Text = ""; 


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Line_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		private string _itemGroupCode = " "; 

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try 
			{
				if ( cmb_itemGroup.SelectedIndex != -1 )
				{
					btn_groupSearch.Enabled = true;
					txt_itemGroup.Text = "";
					_itemGroupCode = cmb_itemGroup.SelectedValue.ToString();

				}
				else
				{
					
					btn_groupSearch.Enabled = false;
					txt_itemGroup.Text = "";
					_itemGroupCode = " ";
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_itemGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				string vTyep = cmb_itemGroup.SelectedValue.ToString();
				FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);
				
				vPopup.ShowDialog();
			
				_itemGroupCode = COM.ComVar.Parameter_PopUp[3];
				txt_itemGroup.Text	= COM.ComVar.Parameter_PopUp[4];

				vPopup.Dispose(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
			
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
			
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		
 

		#endregion  



		#endregion

		#region 그리드 관련


		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{

			if(e.Button != MouseButtons.Right) return;
			
			int vCol = spd_main.ActiveSheet.ActiveColumnIndex;

			if (spd_main.ActiveSheet.OperationMode != OperationMode.ReadOnly && !spd_main.ActiveSheet.Columns[vCol].Locked)
			{
				ValueExchangeProcessing(vCol);
			}

										
		}



		private void ValueExchangeProcessing(int vCol)
		{
			try
			{ 
				ClassLib.ComVar.Parameter_PopUp_Object  = null;
				ClassLib.ComVar.Parameter_PopUp_Object2 = null;
				ClassLib.ComVar.Parameter_PopUpTable	= null; 

				CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[1];
					COM.ComVar.Parameter_PopUp[0]	= spd_main.ActiveSheet.ColumnHeader.Cells[2,vCol].Text;  
				
					if (_cellTypes.ContainsKey(vCol))  
					{
						ClassLib.ComVar.Parameter_PopUp_Object  = new object[]{_cellData[vCol]};
						ClassLib.ComVar.Parameter_PopUp_Object2 = new object[]{_cellTypes[vCol]};
					}
					FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer pop_changer = new FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						for (int i = 0 ; i < vSelectionRange.Length; i++)
						{
							int start_row = vSelectionRange[i].Row;
							int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

							for (int j = start_row ; j < end_row; j++)
							{
								spd_main.ActiveSheet.Cells[j, vCol].Value		= COM.ComVar.Parameter_PopUp[0];    // Set TextBox Text

								if (COM.ComVar.Parameter_PopUp.Length > 1)
									spd_main.ActiveSheet.Cells[j, vCol].Value = COM.ComVar.Parameter_PopUp[1];	// Set SSPComboBox Value
								
								spd_main.Update_Row(j, img_Action);
							}
						}		  

					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ValueExchangeProcessing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}




		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{						
			Grid_EditModeOnProcess(spd_main);
		}		


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



		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			spd_main.Update_Row(img_Action);
		}


		#endregion
		
		#endregion

		#region DB Connect


		/// <summary>
		/// Select_SBK_REMAINDER : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_line"></param>
		/// <param name="arg_item_group"></param>
		/// <param name="arg_item_cd"></param>
		/// <param name="arg_item_name"></param>
		/// <returns></returns>
		private DataTable Select_SBK_REMAINDER(string arg_factory, 
			string arg_process, 
			string arg_line, 
			string arg_item_group, 
			string arg_item_cd, 
			string arg_item_name)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBK_REMAINDER.SELECT_SBK_REMAINDER";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PROCESS";
			MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_GROUP";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[5] = "ARG_ITEM_NAME";
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
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_process;
			MyOraDB.Parameter_Values[2] = arg_line;
			MyOraDB.Parameter_Values[3] = arg_item_group;
			MyOraDB.Parameter_Values[4] = arg_item_cd;
			MyOraDB.Parameter_Values[5] = arg_item_name; 
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null; 

			return ds_ret.Tables[MyOraDB.Process_Name];

		}



		#endregion

		

		


	}
}

