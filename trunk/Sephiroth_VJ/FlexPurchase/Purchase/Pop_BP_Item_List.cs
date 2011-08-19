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

namespace FlexPurchase.Purchase
{
	public class Pop_BP_Item_List : COM.PCHWinForm.Pop_Medium
	{

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label lbl_itemDiv;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemDivision;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.TextBox txt_itemCode;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label lbl_search;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_allChk;
		private System.Windows.Forms.MenuItem mnu_allUnchk;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_allSel;
		private System.Windows.Forms.MenuItem mnu_allDesel;

		private System.ComponentModel.IContainer components = null;

		public Pop_BP_Item_List()
		{
			InitializeComponent();
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BP_Item_List));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_itemDivision = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_itemDiv = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.ctx_main = new System.Windows.Forms.ContextMenu();
            this.mnu_allSel = new System.Windows.Forms.MenuItem();
            this.mnu_allDesel = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_allChk = new System.Windows.Forms.MenuItem();
            this.mnu_allUnchk = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.TabIndex = 27;
            this.c1Sizer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_apply);
            this.panel2.Location = new System.Drawing.Point(14, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 30);
            this.panel2.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(598, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(71, 24);
            this.btn_cancel.TabIndex = 354;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(527, 3);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(71, 24);
            this.btn_apply.TabIndex = 353;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_itemDivision);
            this.panel1.Controls.Add(this.cmb_factory);
            this.panel1.Controls.Add(this.txt_itemCode);
            this.panel1.Controls.Add(this.cmb_itemGroup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_itemGroup);
            this.panel1.Controls.Add(this.txt_itemName);
            this.panel1.Controls.Add(this.lbl_item);
            this.panel1.Controls.Add(this.lbl_itemDiv);
            this.panel1.Controls.Add(this.lbl_factory);
            this.panel1.Controls.Add(this.lbl_itemgroup);
            this.panel1.Controls.Add(this.lbl_search);
            this.panel1.Location = new System.Drawing.Point(14, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 81);
            this.panel1.TabIndex = 1;
            // 
            // cmb_itemDivision
            // 
            this.cmb_itemDivision.AddItemCols = 0;
            this.cmb_itemDivision.AddItemSeparator = ';';
            this.cmb_itemDivision.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemDivision.Caption = "";
            this.cmb_itemDivision.CaptionHeight = 17;
            this.cmb_itemDivision.CaptionStyle = style1;
            this.cmb_itemDivision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_itemDivision.ColumnCaptionHeight = 18;
            this.cmb_itemDivision.ColumnFooterHeight = 18;
            this.cmb_itemDivision.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_itemDivision.ContentHeight = 16;
            this.cmb_itemDivision.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_itemDivision.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_itemDivision.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_itemDivision.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_itemDivision.EditorHeight = 16;
            this.cmb_itemDivision.EvenRowStyle = style2;
            this.cmb_itemDivision.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemDivision.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemDivision.FooterStyle = style3;
            this.cmb_itemDivision.GapHeight = 2;
            this.cmb_itemDivision.HeadingStyle = style4;
            this.cmb_itemDivision.HighLightRowStyle = style5;
            this.cmb_itemDivision.ItemHeight = 15;
            this.cmb_itemDivision.Location = new System.Drawing.Point(109, 30);
            this.cmb_itemDivision.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemDivision.MaxDropDownItems = ((short)(5));
            this.cmb_itemDivision.MaxLength = 32767;
            this.cmb_itemDivision.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemDivision.Name = "cmb_itemDivision";
            this.cmb_itemDivision.OddRowStyle = style6;
            this.cmb_itemDivision.PartialRightColumn = false;
            this.cmb_itemDivision.PropBag = resources.GetString("cmb_itemDivision.PropBag");
            this.cmb_itemDivision.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemDivision.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemDivision.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemDivision.SelectedStyle = style7;
            this.cmb_itemDivision.Size = new System.Drawing.Size(210, 20);
            this.cmb_itemDivision.Style = style8;
            this.cmb_itemDivision.TabIndex = 567;
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
            this.cmb_factory.Location = new System.Drawing.Point(109, 8);
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
            this.cmb_factory.TabIndex = 566;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(437, 30);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 565;
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
            this.cmb_itemGroup.Location = new System.Drawing.Point(437, 8);
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
            this.cmb_itemGroup.Size = new System.Drawing.Size(115, 20);
            this.cmb_itemGroup.Style = style24;
            this.cmb_itemGroup.TabIndex = 564;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 27;
            this.label1.ImageList = this.img_SmallButton;
            this.label1.Location = new System.Drawing.Point(625, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 21);
            this.label1.TabIndex = 563;
            this.label1.Tag = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(553, 8);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(72, 21);
            this.txt_itemGroup.TabIndex = 562;
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(497, 30);
            this.txt_itemName.MaxLength = 10;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(149, 21);
            this.txt_itemName.TabIndex = 561;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(336, 30);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 556;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_itemDiv
            // 
            this.lbl_itemDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemDiv.ImageIndex = 1;
            this.lbl_itemDiv.ImageList = this.img_Label;
            this.lbl_itemDiv.Location = new System.Drawing.Point(8, 30);
            this.lbl_itemDiv.Name = "lbl_itemDiv";
            this.lbl_itemDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemDiv.TabIndex = 555;
            this.lbl_itemDiv.Text = "Item Division";
            this.lbl_itemDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 8);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 554;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_itemgroup
            // 
            this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemgroup.ImageIndex = 0;
            this.lbl_itemgroup.ImageList = this.img_Label;
            this.lbl_itemgroup.Location = new System.Drawing.Point(336, 8);
            this.lbl_itemgroup.Name = "lbl_itemgroup";
            this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemgroup.TabIndex = 553;
            this.lbl_itemgroup.Text = "Item Group";
            this.lbl_itemgroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_search
            // 
            this.lbl_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_search.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ImageIndex = 0;
            this.lbl_search.ImageList = this.img_Button;
            this.lbl_search.Location = new System.Drawing.Point(576, 52);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(71, 24);
            this.lbl_search.TabIndex = 354;
            this.lbl_search.Text = "Search";
            this.lbl_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_search.Click += new System.EventHandler(this.lbl_search_Click);
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(14, 89);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(668, 293);
            this.spd_main.TabIndex = 0;
            this.spd_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spd_main_KeyDown);
            this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
            this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.Location = new System.Drawing.Point(0, 0);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(100, 23);
            this.btn_groupSearch.TabIndex = 0;
            // 
            // ctx_main
            // 
            this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_allSel,
            this.mnu_allDesel,
            this.menuItem1,
            this.mnu_allChk,
            this.mnu_allUnchk});
            // 
            // mnu_allSel
            // 
            this.mnu_allSel.Index = 0;
            this.mnu_allSel.Text = "All Select";
            this.mnu_allSel.Click += new System.EventHandler(this.mnu_allSel_Click);
            // 
            // mnu_allDesel
            // 
            this.mnu_allDesel.Index = 1;
            this.mnu_allDesel.Text = "All Deselect";
            this.mnu_allDesel.Click += new System.EventHandler(this.mnu_allDesel_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // mnu_allChk
            // 
            this.mnu_allChk.Index = 3;
            this.mnu_allChk.Text = "All check";
            this.mnu_allChk.Click += new System.EventHandler(this.mnu_allChk_Click);
            // 
            // mnu_allUnchk
            // 
            this.mnu_allUnchk.Index = 4;
            this.mnu_allUnchk.Text = "All uncheck";
            this.mnu_allUnchk.Click += new System.EventHandler(this.mnu_allUnchk_Click);
            // 
            // Pop_BP_Item_List
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 468);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BP_Item_List";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 전역변수정의

		private string _itemGroupCode = " ";
		private COM.OraDB MyOraDB = new COM.OraDB();
		private DataTable rtnDT = null;

		#endregion

		#region 이벤트 핸들러

		private void lbl_search_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				this.searchData();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "main button :: search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}	
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				this.returnData();
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "main button :: search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "main button :: search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
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

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (e.Column == (int)ClassLib.TBSBP_ITEM_LIST_POP.IxCHK)
			{
				e.Cancel = true;
				
				if (containsRow(e.Row))
				{
					onCheck(!(bool)spd_main.ActiveSheet.Cells[e.Row, e.Column].Value);
				}
				else
				{
					spd_main.ActiveSheet.ClearSelection();
					spd_main.ActiveSheet.AddSelection(e.Row, 0, 1, spd_main.ActiveSheet.ColumnCount);
					spd_main.ActiveSheet.Cells[e.Row, e.Column].Value = !(bool)spd_main.ActiveSheet.Cells[e.Row, e.Column].Value;
				}
			}
		}


		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			e.Cancel = true;
		}
		
		private void mnu_allChk_Click(object sender, System.EventArgs e)
		{
			allCheck(true);
		}

		private void mnu_allUnchk_Click(object sender, System.EventArgs e)
		{
			allCheck(false);
		}

		private void mnu_allSel_Click(object sender, System.EventArgs e)
		{
			allSelect(true);
		}

		private void mnu_allDesel_Click(object sender, System.EventArgs e)
		{
			allSelect(false);
		}

		private void spd_main_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Control)
			{
				if (e.KeyCode == Keys.A)
				{
					allSelect(true);
				}
			}
		}

		#endregion

		#region 이벤트 처리

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{


			lbl_MainTitle.Text = "Purchase Item List";
            this.Text = "Purchase Item List";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBP_ITEM_LIST", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			_mainSheet	= spd_main.ActiveSheet;
			this.Init_Combo();
			this.Init_GridHeader();
			this.init_GridDesign();
		}
		
		private void Init_Combo()
		{
			DataTable vDt;

			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, 40, 125);
			cmb_factory.SelectedValue = (cmb_factory.Tag == null) ? ClassLib.ComVar.This_Factory : cmb_factory.Tag;
			vDt.Dispose();

			// llt item division
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBP15");
			COM.ComCtl.Set_ComboList(vDt, cmb_itemDivision, 1, 2, true);
			cmb_itemDivision.SelectedIndex = 0;
			vDt.Dispose();
		}

		/// <summary>
		/// 그리드 헤더 초기화
		/// </summary>
		private void Init_GridHeader()
		{
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

		private void init_GridDesign()
		{
			spd_main.ActiveSheet.Columns[(int)ClassLib.TBSBP_ITEM_LIST.IxCUST_CD].ForeColor = Color.Blue;
			spd_main.ActiveSheet.Columns[(int)ClassLib.TBSBP_ITEM_LIST.IxCUST_NAME].ForeColor = Color.Blue;
		}

		private void searchData()
		{
			DataTable vDt = SELECT_SBP_ORDER();
			spd_main.Display_Grid(vDt);

			this.rtnDT = new DataTable();

			rtnDT.Columns.Add("TEMP");
			for (int col = 0 ; col < vDt.Columns.Count ; col++)
			{
				rtnDT.Columns.Add(vDt.Columns[col].ColumnName, vDt.Columns[col].DataType);
			}

			vDt.Dispose();
		}

		private void returnData()
		{
			rtnDT.Clear();

			for (int row = 0 ; row < spd_main.ActiveSheet.RowCount ; row++)
			{
				if ((bool)spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBP_ITEM_LIST_POP.IxCHK].Value)
				{
					DataRow newRow = rtnDT.NewRow();

					for (int col = 0 ; col < rtnDT.Columns.Count ; col++)
					{
						newRow[col] = spd_main.ActiveSheet.Cells[row, col].Text;
					}

					rtnDT.Rows.Add(newRow);
				}
			}
		}

		private bool containsRow(int arg_row)
		{
			CellRange[] ranges = spd_main.ActiveSheet.GetSelections();

			for (int outerIdx = 0 ; outerIdx < ranges.Length ; outerIdx++)
			{
				int strRow = ranges[outerIdx].Row;
				int endRow = ranges[outerIdx].Row + ranges[outerIdx].RowCount;

				for (int inneridx = strRow ; inneridx < endRow ; inneridx++)
				{
					if (inneridx == arg_row)
						return true;
				}
			}

			return false;
		}

		private void onCheck(bool arg_chk)
		{
			int chkCol = (int)ClassLib.TBSBP_ITEM_LIST_POP.IxCHK;

			CellRange[] ranges = spd_main.ActiveSheet.GetSelections();

			for (int outerIdx = 0 ; outerIdx < ranges.Length ; outerIdx++)
			{
				int strRow = ranges[outerIdx].Row;
				int endRow = ranges[outerIdx].Row + ranges[outerIdx].RowCount;

				for (int inneridx = strRow ; inneridx < endRow ; inneridx++)
				{
					spd_main.ActiveSheet.Cells[inneridx, chkCol].Value = arg_chk;
				}
			}
		}

		private void allCheck(bool arg_chk)
		{
			int chkCol = (int)ClassLib.TBSBP_ITEM_LIST_POP.IxCHK;

			for (int row = 0 ; row < spd_main.ActiveSheet.RowCount ; row++)
			{
				spd_main.ActiveSheet.Cells[row, chkCol].Value = arg_chk;
			}
		}

		private void allSelect(bool arg_sel)
		{
			if (arg_sel)
			{
				spd_main.ActiveSheet.AddSelection(0, 0, spd_main.ActiveSheet.RowCount, spd_main.ActiveSheet.ColumnCount);
			}
			else
			{
				spd_main.ActiveSheet.ClearSelection();
			}
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBP_ORDER : 오더 정보 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_ORDER()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_ITEM_LIST.SELECT_SBP_ITEM_LIST_POP";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_ITEM_DIVISION";
			MyOraDB.Parameter_Name[3] = "ARG_GROUP_CD";
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
			MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_itemDivision, "");;
			MyOraDB.Parameter_Values[3] = _itemGroupCode;
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_TextBox(txt_itemCode, "");
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_TextBox(txt_itemName, "");
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

		#region getter/setter

		public object factory
		{
			set 
			{
				cmb_factory.SelectedValue = value;
				cmb_factory.Enabled = false;
			}
		}
		
		public DataTable SelectedData
		{
			get
			{
				return rtnDT;
			}
		}

		#endregion

	}
}

