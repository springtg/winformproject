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
	public class Form_BK_Stock_SearchByOption : COM.PCHWinForm.Pop_Small
	{   
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Print;
		private System.Windows.Forms.Button btn_Calculation;
		private System.Windows.Forms.GroupBox grp_Group;
		private System.Windows.Forms.Label lbl_between;
		private System.Windows.Forms.DateTimePicker dpick_To_Ymd;
		private System.Windows.Forms.DateTimePicker dpick_From_Ymd;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cmb_wareHouse;
		private System.Windows.Forms.Label lbl_wareHouse;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_StockYm;
		private System.Windows.Forms.Label lbl_Item_Group;
		private System.Windows.Forms.Label lbl_Option;
		private C1.Win.C1List.C1Combo cmb_Option;
		private System.Windows.Forms.TextBox txt_itemNm;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.TextBox txt_Amount;
		private System.Windows.Forms.Label lbl_Amount;
		private System.ComponentModel.IContainer components = null;

		public Form_BK_Stock_SearchByOption()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BK_Stock_SearchByOption));
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Calculation = new System.Windows.Forms.Button();
            this.grp_Group = new System.Windows.Forms.GroupBox();
            this.lbl_Item_Group = new System.Windows.Forms.Label();
            this.lbl_Option = new System.Windows.Forms.Label();
            this.cmb_Option = new C1.Win.C1List.C1Combo();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_between = new System.Windows.Forms.Label();
            this.dpick_To_Ymd = new System.Windows.Forms.DateTimePicker();
            this.dpick_From_Ymd = new System.Windows.Forms.DateTimePicker();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.cmb_wareHouse = new C1.Win.C1List.C1Combo();
            this.lbl_wareHouse = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_StockYm = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.grp_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_wareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(328, 23);
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
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
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
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Close.Location = new System.Drawing.Point(264, 200);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(90, 23);
            this.btn_Close.TabIndex = 40;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Print.Location = new System.Drawing.Point(98, 200);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(90, 23);
            this.btn_Print.TabIndex = 39;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Calculation
            // 
            this.btn_Calculation.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Calculation.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Calculation.ForeColor = System.Drawing.Color.Red;
            this.btn_Calculation.Location = new System.Drawing.Point(8, 200);
            this.btn_Calculation.Name = "btn_Calculation";
            this.btn_Calculation.Size = new System.Drawing.Size(90, 23);
            this.btn_Calculation.TabIndex = 38;
            this.btn_Calculation.Text = "Calculation";
            this.btn_Calculation.UseVisualStyleBackColor = false;
            this.btn_Calculation.Click += new System.EventHandler(this.btn_Calculation_Click);
            // 
            // grp_Group
            // 
            this.grp_Group.BackColor = System.Drawing.Color.Transparent;
            this.grp_Group.Controls.Add(this.lbl_Item_Group);
            this.grp_Group.Controls.Add(this.lbl_Option);
            this.grp_Group.Controls.Add(this.cmb_Option);
            this.grp_Group.Controls.Add(this.txt_itemNm);
            this.grp_Group.Controls.Add(this.cmb_itemGroup);
            this.grp_Group.Controls.Add(this.btn_groupSearch);
            this.grp_Group.Controls.Add(this.txt_itemCd);
            this.grp_Group.Controls.Add(this.lbl_item);
            this.grp_Group.Controls.Add(this.lbl_between);
            this.grp_Group.Controls.Add(this.dpick_To_Ymd);
            this.grp_Group.Controls.Add(this.dpick_From_Ymd);
            this.grp_Group.Controls.Add(this.lbl_factory);
            this.grp_Group.Controls.Add(this.cmb_wareHouse);
            this.grp_Group.Controls.Add(this.lbl_wareHouse);
            this.grp_Group.Controls.Add(this.cmb_factory);
            this.grp_Group.Controls.Add(this.lbl_StockYm);
            this.grp_Group.Controls.Add(this.lbl_Amount);
            this.grp_Group.Controls.Add(this.txt_Amount);
            this.grp_Group.Location = new System.Drawing.Point(8, 32);
            this.grp_Group.Name = "grp_Group";
            this.grp_Group.Size = new System.Drawing.Size(344, 160);
            this.grp_Group.TabIndex = 37;
            this.grp_Group.TabStop = false;
            // 
            // lbl_Item_Group
            // 
            this.lbl_Item_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Item_Group.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item_Group.ImageIndex = 0;
            this.lbl_Item_Group.ImageList = this.img_Label;
            this.lbl_Item_Group.Location = new System.Drawing.Point(8, 104);
            this.lbl_Item_Group.Name = "lbl_Item_Group";
            this.lbl_Item_Group.Size = new System.Drawing.Size(100, 21);
            this.lbl_Item_Group.TabIndex = 443;
            this.lbl_Item_Group.Text = "Item Group";
            this.lbl_Item_Group.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Option
            // 
            this.lbl_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Option.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Option.ImageIndex = 1;
            this.lbl_Option.ImageList = this.img_Label;
            this.lbl_Option.Location = new System.Drawing.Point(8, 38);
            this.lbl_Option.Name = "lbl_Option";
            this.lbl_Option.Size = new System.Drawing.Size(100, 21);
            this.lbl_Option.TabIndex = 442;
            this.lbl_Option.Text = "Option";
            this.lbl_Option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Option
            // 
            this.cmb_Option.AddItemCols = 0;
            this.cmb_Option.AddItemSeparator = ';';
            this.cmb_Option.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Option.Caption = "";
            this.cmb_Option.CaptionHeight = 17;
            this.cmb_Option.CaptionStyle = style1;
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
            this.cmb_Option.EvenRowStyle = style2;
            this.cmb_Option.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Option.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Option.FooterStyle = style3;
            this.cmb_Option.GapHeight = 2;
            this.cmb_Option.HeadingStyle = style4;
            this.cmb_Option.HighLightRowStyle = style5;
            this.cmb_Option.ItemHeight = 15;
            this.cmb_Option.Location = new System.Drawing.Point(109, 38);
            this.cmb_Option.MatchEntryTimeout = ((long)(2000));
            this.cmb_Option.MaxDropDownItems = ((short)(5));
            this.cmb_Option.MaxLength = 32767;
            this.cmb_Option.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Option.Name = "cmb_Option";
            this.cmb_Option.OddRowStyle = style6;
            this.cmb_Option.PartialRightColumn = false;
            this.cmb_Option.PropBag = resources.GetString("cmb_Option.PropBag");
            this.cmb_Option.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Option.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Option.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Option.SelectedStyle = style7;
            this.cmb_Option.Size = new System.Drawing.Size(220, 20);
            this.cmb_Option.Style = style8;
            this.cmb_Option.TabIndex = 441;
            this.cmb_Option.TextChanged += new System.EventHandler(this.cmb_Option_TextChanged);
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(188, 126);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(140, 21);
            this.txt_itemNm.TabIndex = 440;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style9;
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
            this.cmb_itemGroup.EvenRowStyle = style10;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style11;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style12;
            this.cmb_itemGroup.HighLightRowStyle = style13;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(109, 104);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style14;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style15;
            this.cmb_itemGroup.Size = new System.Drawing.Size(196, 20);
            this.cmb_itemGroup.Style = style16;
            this.cmb_itemGroup.TabIndex = 439;
            this.cmb_itemGroup.TextChanged += new System.EventHandler(this.cmb_itemGroup_TextChanged);
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(305, 104);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 438;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(109, 126);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(79, 21);
            this.txt_itemCd.TabIndex = 437;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(8, 126);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 436;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_between
            // 
            this.lbl_between.Location = new System.Drawing.Point(214, 62);
            this.lbl_between.Name = "lbl_between";
            this.lbl_between.Size = new System.Drawing.Size(16, 16);
            this.lbl_between.TabIndex = 435;
            this.lbl_between.Text = "~";
            // 
            // dpick_To_Ymd
            // 
            this.dpick_To_Ymd.CustomFormat = "";
            this.dpick_To_Ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_To_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_To_Ymd.Location = new System.Drawing.Point(230, 60);
            this.dpick_To_Ymd.Name = "dpick_To_Ymd";
            this.dpick_To_Ymd.Size = new System.Drawing.Size(99, 21);
            this.dpick_To_Ymd.TabIndex = 434;
            // 
            // dpick_From_Ymd
            // 
            this.dpick_From_Ymd.CustomFormat = "";
            this.dpick_From_Ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_From_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_From_Ymd.Location = new System.Drawing.Point(109, 60);
            this.dpick_From_Ymd.Name = "dpick_From_Ymd";
            this.dpick_From_Ymd.Size = new System.Drawing.Size(99, 21);
            this.dpick_From_Ymd.TabIndex = 433;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 16);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 429;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_wareHouse
            // 
            this.cmb_wareHouse.AddItemCols = 0;
            this.cmb_wareHouse.AddItemSeparator = ';';
            this.cmb_wareHouse.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_wareHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_wareHouse.Caption = "";
            this.cmb_wareHouse.CaptionHeight = 17;
            this.cmb_wareHouse.CaptionStyle = style17;
            this.cmb_wareHouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_wareHouse.ColumnCaptionHeight = 18;
            this.cmb_wareHouse.ColumnFooterHeight = 18;
            this.cmb_wareHouse.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_wareHouse.ContentHeight = 16;
            this.cmb_wareHouse.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_wareHouse.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_wareHouse.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_wareHouse.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_wareHouse.EditorHeight = 16;
            this.cmb_wareHouse.EvenRowStyle = style18;
            this.cmb_wareHouse.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_wareHouse.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_wareHouse.FooterStyle = style19;
            this.cmb_wareHouse.GapHeight = 2;
            this.cmb_wareHouse.HeadingStyle = style20;
            this.cmb_wareHouse.HighLightRowStyle = style21;
            this.cmb_wareHouse.ItemHeight = 15;
            this.cmb_wareHouse.Location = new System.Drawing.Point(109, 82);
            this.cmb_wareHouse.MatchEntryTimeout = ((long)(2000));
            this.cmb_wareHouse.MaxDropDownItems = ((short)(5));
            this.cmb_wareHouse.MaxLength = 32767;
            this.cmb_wareHouse.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_wareHouse.Name = "cmb_wareHouse";
            this.cmb_wareHouse.OddRowStyle = style22;
            this.cmb_wareHouse.PartialRightColumn = false;
            this.cmb_wareHouse.PropBag = resources.GetString("cmb_wareHouse.PropBag");
            this.cmb_wareHouse.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_wareHouse.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_wareHouse.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_wareHouse.SelectedStyle = style23;
            this.cmb_wareHouse.Size = new System.Drawing.Size(220, 20);
            this.cmb_wareHouse.Style = style24;
            this.cmb_wareHouse.TabIndex = 431;
            // 
            // lbl_wareHouse
            // 
            this.lbl_wareHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_wareHouse.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wareHouse.ImageIndex = 1;
            this.lbl_wareHouse.ImageList = this.img_Label;
            this.lbl_wareHouse.Location = new System.Drawing.Point(8, 82);
            this.lbl_wareHouse.Name = "lbl_wareHouse";
            this.lbl_wareHouse.Size = new System.Drawing.Size(100, 21);
            this.lbl_wareHouse.TabIndex = 432;
            this.lbl_wareHouse.Text = "WareHouse";
            this.lbl_wareHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_factory.Location = new System.Drawing.Point(109, 16);
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
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style32;
            this.cmb_factory.TabIndex = 428;
            // 
            // lbl_StockYm
            // 
            this.lbl_StockYm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_StockYm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockYm.ImageIndex = 1;
            this.lbl_StockYm.ImageList = this.img_Label;
            this.lbl_StockYm.Location = new System.Drawing.Point(8, 60);
            this.lbl_StockYm.Name = "lbl_StockYm";
            this.lbl_StockYm.Size = new System.Drawing.Size(100, 21);
            this.lbl_StockYm.TabIndex = 430;
            this.lbl_StockYm.Text = "Stock Ym";
            this.lbl_StockYm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Amount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.ImageIndex = 0;
            this.lbl_Amount.ImageList = this.img_Label;
            this.lbl_Amount.Location = new System.Drawing.Point(8, 144);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(100, 21);
            this.lbl_Amount.TabIndex = 441;
            this.lbl_Amount.Text = "Prod. Amount";
            this.lbl_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Amount.Visible = false;
            // 
            // txt_Amount
            // 
            this.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Amount.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Amount.Location = new System.Drawing.Point(109, 144);
            this.txt_Amount.MaxLength = 10;
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(220, 21);
            this.txt_Amount.TabIndex = 442;
            this.txt_Amount.Visible = false;
            // 
            // Form_BK_Stock_SearchByOption
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(362, 232);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Calculation);
            this.Controls.Add(this.grp_Group);
            this.Name = "Form_BK_Stock_SearchByOption";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.grp_Group, 0);
            this.Controls.SetChildIndex(this.btn_Calculation, 0);
            this.Controls.SetChildIndex(this.btn_Print, 0);
            this.Controls.SetChildIndex(this.btn_Close, 0);
            this.grp_Group.ResumeLayout(false);
            this.grp_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_wareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수
		private COM.OraDB MyOraDB   = new COM.OraDB();
		string _itemGroupCode = "";
		string _itemGroupName = "";

		#endregion

		#region DB 컨넥트

		private  bool Tbtn_ConfirmProcess()
		{
			try
			{   				
				
				MyOraDB.ReDim_Parameter(4);

				MyOraDB.Process_Name = "pkg_sbo_stock_print.save_sbo_stock_list_01";

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
				MyOraDB.Parameter_Values[1] = " ";
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
		#endregion

		#region 공통 메서드

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form init
			//			ClassLib.ComFunction.Init_Form_Control(this);
			//			ClassLib.ComFunction.Init_MenuRole(this,lbl_MainTitle,new C1.Win.C1Command.C1Command[]{tbtn_Search, tbtn_Save, tbtn_Delete, tbtn_Print, tbtn_New, tbtn_Confirm}) ;
			
            lbl_MainTitle.Text = "Stock By Option";
			this.Text		   = lbl_MainTitle.Text;
            ClassLib.ComFunction.SetLangDic(this);


			

			DataTable vDt = null;

			// Factory combobox add items
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue		= ClassLib.ComVar.This_Factory;
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// Item Group Combobox Setting
			vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
			vDt.Dispose();

			

			// cmb_print_type		
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBK02");
			COM.ComCtl.Set_ComboList(vDt, cmb_Option , 1, 2, false, 56,0);
			cmb_Option.SelectedIndex = -1;


			

			// WareHouse Combobox Setting
			vDt = FlexPurchase.ClassLib.ComFunction.SELECT_WAREHOUSE_LIST_USING(cmb_factory.SelectedValue.ToString());
			COM.ComCtl.Set_ComboList(vDt, cmb_wareHouse, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Name);  
			//cmb_wareHouse.SelectedIndex	= 0;
				
			vDt.Dispose();

		}

		private void Set_Option(string arg_flag)
		{


           #region Option 1
			if (arg_flag  == "1")
			{
				cmb_factory.Enabled  = true;
				dpick_From_Ymd.Enabled   = true;
				dpick_To_Ymd.Enabled  = true;
				cmb_wareHouse.Enabled  = true;
				cmb_itemGroup.Enabled  = true;
				btn_groupSearch.Enabled = true;
				txt_itemCd.Enabled  = true;
				txt_itemNm.Enabled  = true;
			}
			

		   #endregion  

		   #region Option 2
			if (arg_flag  == "2")
			{
				cmb_factory.Enabled  = true;
				dpick_From_Ymd.Enabled   = true;
				dpick_To_Ymd.Enabled  = true;
				cmb_wareHouse.Enabled  = true;
				cmb_itemGroup.Enabled  = true;
				btn_groupSearch.Enabled = true;
				txt_itemCd.Enabled  = true;
				txt_itemNm.Enabled  = true;
			}

		   #endregion  

		   #region Option 3
			if (arg_flag  == "3")
			{
				cmb_factory.Enabled  = true;
				dpick_From_Ymd.Enabled   = true;
				dpick_To_Ymd.Enabled  = false;
				cmb_wareHouse.Enabled  = true;
				cmb_itemGroup.Enabled  = true;
				btn_groupSearch.Enabled = true;
				txt_itemCd.Enabled  = true;
				txt_itemNm.Enabled  = true;
			}


		   #endregion  

		   #region Option 4
			if (arg_flag  == "4")
			{
				cmb_factory.Enabled  = true;
				dpick_From_Ymd.Enabled   = true;
				dpick_To_Ymd.Enabled  = true;
				cmb_wareHouse.Enabled  = true;
				cmb_itemGroup.Enabled  = true;
				btn_groupSearch.Enabled = true;
				txt_itemCd.Enabled  = true;
				txt_itemNm.Enabled  = true;
			
				btn_Calculation.Enabled = false;

				lbl_item.Visible = false;
				txt_itemCd.Visible  = false;
				txt_itemNm.Visible = false;
				lbl_Amount.Visible = true;
				txt_Amount.Visible = true;
				lbl_Amount.Location = new Point(8, 126);
				txt_Amount.Location = new Point(109, 126);

			}
			else
			{

				btn_Calculation.Enabled = true;

				lbl_item.Visible = true;
				txt_itemCd.Visible  = true;
				txt_itemNm.Visible = true;
				lbl_Amount.Visible = false;
				txt_Amount.Visible = false;
				lbl_Amount.Location = new Point(8, 144);
				txt_Amount.Location = new Point(109, 144); 

			}


		   #endregion  



			
			cmb_itemGroup.SelectedIndex = -1;
			txt_itemCd.Text = "";
			txt_itemNm.Text = "";
			txt_Amount.Text = "";
			_itemGroupCode = "";
			_itemGroupName = "";


		}
	
		private void Tbtn_PrintProcess()
		{
			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 

			#region  Option 1

			if (cmb_Option.SelectedValue.ToString() =="1")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Stock_By_Option_01");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","") +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","") +		"' ";
				sPara += "'" +  COM.ComFunction.Empty_TextBox(txt_itemCd," ") + "' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}


			#endregion
			
			#region  Option 2

			if (cmb_Option.SelectedValue.ToString() =="2")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Stock_By_Option_02");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","") +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","") +		"' ";
				sPara += "'" +  COM.ComFunction.Empty_TextBox(txt_itemCd," ") + "' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion

			#region  Option 3

			if (cmb_Option.SelectedValue.ToString() =="3")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Stock_By_Option_03");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ") +		"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_wareHouse, " ") +		"' ";
                sPara += "'" + COM.ComFunction.Empty_String(cmb_itemGroup.Columns[0].Text, " ") +		"' ";   //item group cd
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +		"' ";   //item group cd
				sPara += "'" +  COM.ComFunction.Empty_TextBox(txt_itemNm ," ") + "' ";


				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion

			#region  Option 4

			if (cmb_Option.SelectedValue.ToString() =="4")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Stock_By_Option_04");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ") +		"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","") +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_wareHouse, " ") +		"' ";
				sPara += "'" + ( (_itemGroupCode == "") ? " " : _itemGroupCode ) +		"' ";   //item group cd 
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_Amount, "1") + "' ";

				if(_itemGroupCode == "")
				{
					sPara += "'" + "" + "' ";  // item group type name
					sPara += "'" + "" + "' ";  // item first group name
				}
				else
				{
					sPara += "'" + COM.ComFunction.Empty_String(cmb_itemGroup.Columns[1].Text, " ") + "' ";  // item group type name
					sPara += "'" + _itemGroupName + "' ";  // item first group name
				}


				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Stock By Option";
				MyReport.Show();

				

			} 

			#endregion
                   
 
		}


		#endregion

		#region 이벤트처리

		private void btn_Calculation_Click(object sender, System.EventArgs e)
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


		
		private void cmb_Option_TextChanged(object sender, System.EventArgs e)
		{           
		    Set_Option(cmb_Option.SelectedValue.ToString());
		}

		private void cmb_itemGroup_TextChanged(object sender, System.EventArgs e)
		{
			if(cmb_itemGroup.SelectedIndex == -1) return; 
			_itemGroupCode = cmb_itemGroup.SelectedValue.ToString();
			_itemGroupName = cmb_itemGroup.Columns[1].Text;
		}

		private void btn_Print_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_PrintProcess(); 
		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
			try
			{

				string vTyep = cmb_itemGroup.SelectedValue.ToString();
				FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);
				
				vPopup.ShowDialog();
			
				_itemGroupCode	       = COM.ComVar.Parameter_PopUp[3];
				_itemGroupName         = COM.ComVar.Parameter_PopUp[4];
				txt_itemCd.Text 	   = _itemGroupCode;

				vPopup.Dispose(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		

	}

	#endregion

}

