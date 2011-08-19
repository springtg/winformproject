using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Shipping_Request_Item_List : COM.PCHWinForm.Pop_Normal
	{
		private System.Windows.Forms.Panel pnl_main;
		private COM.SSP spd_spec;
		private FarPoint.Win.Spread.SheetView spd_spec_Sheet1;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.GroupBox gb_result;
		private System.Windows.Forms.CheckBox chk_Result_SizeYN;
		private System.Windows.Forms.TextBox txt_Result_Unit;
		private System.Windows.Forms.Label lbl_lbl_Result_Unit;
		private System.Windows.Forms.TextBox txt_Result_ColorName;
		private System.Windows.Forms.TextBox txt_Result_ItemName;
		private System.Windows.Forms.TextBox txt_Result_ColorCd;
		private System.Windows.Forms.Label lbl_Result_Color;
		private System.Windows.Forms.TextBox txt_Result_ItemCd;
		private System.Windows.Forms.Label lbl_Result_Item;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label btn_SearchSpec;
		private System.Windows.Forms.TextBox txt_SpecName;
		private C1.Win.C1List.C1Combo cmb_SpecDiv;
		private System.Windows.Forms.Label lbl_SpecDiv;
		private System.Windows.Forms.Label lbl_SpecName;
		private System.Windows.Forms.CheckBox chk_UseYN_Spec;
		private COM.SSP spd_result;
		private FarPoint.Win.Spread.SheetView spd_result_Sheet1;
		private System.ComponentModel.IContainer components = null;

		public Pop_BS_Shipping_Request_Item_List()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Shipping_Request_Item_List));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SearchSpec = new System.Windows.Forms.Label();
            this.txt_SpecName = new System.Windows.Forms.TextBox();
            this.cmb_SpecDiv = new C1.Win.C1List.C1Combo();
            this.lbl_SpecDiv = new System.Windows.Forms.Label();
            this.lbl_SpecName = new System.Windows.Forms.Label();
            this.gb_result = new System.Windows.Forms.GroupBox();
            this.chk_Result_SizeYN = new System.Windows.Forms.CheckBox();
            this.txt_Result_Unit = new System.Windows.Forms.TextBox();
            this.lbl_lbl_Result_Unit = new System.Windows.Forms.Label();
            this.txt_Result_ColorName = new System.Windows.Forms.TextBox();
            this.txt_Result_ItemName = new System.Windows.Forms.TextBox();
            this.txt_Result_ColorCd = new System.Windows.Forms.TextBox();
            this.lbl_Result_Color = new System.Windows.Forms.Label();
            this.txt_Result_ItemCd = new System.Windows.Forms.TextBox();
            this.lbl_Result_Item = new System.Windows.Forms.Label();
            this.spd_spec = new COM.SSP();
            this.spd_spec_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.spd_result = new COM.SSP();
            this.spd_result_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.chk_UseYN_Spec = new System.Windows.Forms.CheckBox();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.pnl_main.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SpecDiv)).BeginInit();
            this.gb_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_spec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_spec_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_result_Sheet1)).BeginInit();
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
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_main.Controls.Add(this.groupBox2);
            this.pnl_main.Controls.Add(this.gb_result);
            this.pnl_main.Controls.Add(this.spd_spec);
            this.pnl_main.Controls.Add(this.spd_result);
            this.pnl_main.Location = new System.Drawing.Point(7, 40);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(480, 496);
            this.pnl_main.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SearchSpec);
            this.groupBox2.Controls.Add(this.txt_SpecName);
            this.groupBox2.Controls.Add(this.cmb_SpecDiv);
            this.groupBox2.Controls.Add(this.lbl_SpecDiv);
            this.groupBox2.Controls.Add(this.lbl_SpecName);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 63);
            this.groupBox2.TabIndex = 354;
            this.groupBox2.TabStop = false;
            // 
            // btn_SearchSpec
            // 
            this.btn_SearchSpec.ImageIndex = 27;
            this.btn_SearchSpec.ImageList = this.img_SmallButton;
            this.btn_SearchSpec.Location = new System.Drawing.Point(448, 35);
            this.btn_SearchSpec.Name = "btn_SearchSpec";
            this.btn_SearchSpec.Size = new System.Drawing.Size(21, 21);
            this.btn_SearchSpec.TabIndex = 569;
            this.btn_SearchSpec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchSpec.Click += new System.EventHandler(this.btn_SearchSpec_Click);
            // 
            // txt_SpecName
            // 
            this.txt_SpecName.BackColor = System.Drawing.Color.White;
            this.txt_SpecName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SpecName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_SpecName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SpecName.Location = new System.Drawing.Point(108, 35);
            this.txt_SpecName.MaxLength = 100;
            this.txt_SpecName.Name = "txt_SpecName";
            this.txt_SpecName.Size = new System.Drawing.Size(339, 21);
            this.txt_SpecName.TabIndex = 567;
            // 
            // cmb_SpecDiv
            // 
            this.cmb_SpecDiv.AccessibleDescription = "";
            this.cmb_SpecDiv.AccessibleName = "";
            this.cmb_SpecDiv.AddItemCols = 0;
            this.cmb_SpecDiv.AddItemSeparator = ';';
            this.cmb_SpecDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_SpecDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SpecDiv.Caption = "";
            this.cmb_SpecDiv.CaptionHeight = 17;
            this.cmb_SpecDiv.CaptionStyle = style1;
            this.cmb_SpecDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SpecDiv.ColumnCaptionHeight = 18;
            this.cmb_SpecDiv.ColumnFooterHeight = 18;
            this.cmb_SpecDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SpecDiv.ContentHeight = 16;
            this.cmb_SpecDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SpecDiv.EditorBackColor = System.Drawing.Color.White;
            this.cmb_SpecDiv.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SpecDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SpecDiv.EditorHeight = 16;
            this.cmb_SpecDiv.EvenRowStyle = style2;
            this.cmb_SpecDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_SpecDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SpecDiv.FooterStyle = style3;
            this.cmb_SpecDiv.GapHeight = 2;
            this.cmb_SpecDiv.HeadingStyle = style4;
            this.cmb_SpecDiv.HighLightRowStyle = style5;
            this.cmb_SpecDiv.ItemHeight = 15;
            this.cmb_SpecDiv.Location = new System.Drawing.Point(108, 13);
            this.cmb_SpecDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_SpecDiv.MaxDropDownItems = ((short)(5));
            this.cmb_SpecDiv.MaxLength = 2;
            this.cmb_SpecDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SpecDiv.Name = "cmb_SpecDiv";
            this.cmb_SpecDiv.OddRowStyle = style6;
            this.cmb_SpecDiv.PartialRightColumn = false;
            this.cmb_SpecDiv.PropBag = resources.GetString("cmb_SpecDiv.PropBag");
            this.cmb_SpecDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SpecDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SpecDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SpecDiv.SelectedStyle = style7;
            this.cmb_SpecDiv.Size = new System.Drawing.Size(308, 20);
            this.cmb_SpecDiv.Style = style8;
            this.cmb_SpecDiv.TabIndex = 566;
            // 
            // lbl_SpecDiv
            // 
            this.lbl_SpecDiv.ImageIndex = 1;
            this.lbl_SpecDiv.ImageList = this.img_Label;
            this.lbl_SpecDiv.Location = new System.Drawing.Point(7, 13);
            this.lbl_SpecDiv.Name = "lbl_SpecDiv";
            this.lbl_SpecDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_SpecDiv.TabIndex = 564;
            this.lbl_SpecDiv.Text = "Division";
            this.lbl_SpecDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SpecName
            // 
            this.lbl_SpecName.ImageIndex = 0;
            this.lbl_SpecName.ImageList = this.img_Label;
            this.lbl_SpecName.Location = new System.Drawing.Point(7, 35);
            this.lbl_SpecName.Name = "lbl_SpecName";
            this.lbl_SpecName.Size = new System.Drawing.Size(100, 21);
            this.lbl_SpecName.TabIndex = 563;
            this.lbl_SpecName.Text = "Name";
            this.lbl_SpecName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_result
            // 
            this.gb_result.BackColor = System.Drawing.SystemColors.Window;
            this.gb_result.Controls.Add(this.chk_Result_SizeYN);
            this.gb_result.Controls.Add(this.txt_Result_Unit);
            this.gb_result.Controls.Add(this.lbl_lbl_Result_Unit);
            this.gb_result.Controls.Add(this.txt_Result_ColorName);
            this.gb_result.Controls.Add(this.txt_Result_ItemName);
            this.gb_result.Controls.Add(this.txt_Result_ColorCd);
            this.gb_result.Controls.Add(this.lbl_Result_Color);
            this.gb_result.Controls.Add(this.txt_Result_ItemCd);
            this.gb_result.Controls.Add(this.lbl_Result_Item);
            this.gb_result.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_result.Location = new System.Drawing.Point(0, 264);
            this.gb_result.Name = "gb_result";
            this.gb_result.Size = new System.Drawing.Size(480, 97);
            this.gb_result.TabIndex = 353;
            this.gb_result.TabStop = false;
            this.gb_result.Text = "Result";
            // 
            // chk_Result_SizeYN
            // 
            this.chk_Result_SizeYN.Enabled = false;
            this.chk_Result_SizeYN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_Result_SizeYN.Location = new System.Drawing.Point(415, 66);
            this.chk_Result_SizeYN.Name = "chk_Result_SizeYN";
            this.chk_Result_SizeYN.Size = new System.Drawing.Size(56, 21);
            this.chk_Result_SizeYN.TabIndex = 373;
            this.chk_Result_SizeYN.Text = "Size";
            this.chk_Result_SizeYN.ThreeState = true;
            // 
            // txt_Result_Unit
            // 
            this.txt_Result_Unit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Result_Unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Result_Unit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result_Unit.Location = new System.Drawing.Point(110, 65);
            this.txt_Result_Unit.Name = "txt_Result_Unit";
            this.txt_Result_Unit.ReadOnly = true;
            this.txt_Result_Unit.Size = new System.Drawing.Size(300, 21);
            this.txt_Result_Unit.TabIndex = 371;
            // 
            // lbl_lbl_Result_Unit
            // 
            this.lbl_lbl_Result_Unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_lbl_Result_Unit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lbl_Result_Unit.ImageIndex = 2;
            this.lbl_lbl_Result_Unit.ImageList = this.img_Label;
            this.lbl_lbl_Result_Unit.Location = new System.Drawing.Point(9, 65);
            this.lbl_lbl_Result_Unit.Name = "lbl_lbl_Result_Unit";
            this.lbl_lbl_Result_Unit.Size = new System.Drawing.Size(100, 21);
            this.lbl_lbl_Result_Unit.TabIndex = 370;
            this.lbl_lbl_Result_Unit.Text = "Unit";
            this.lbl_lbl_Result_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Result_ColorName
            // 
            this.txt_Result_ColorName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Result_ColorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Result_ColorName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result_ColorName.Location = new System.Drawing.Point(181, 43);
            this.txt_Result_ColorName.Name = "txt_Result_ColorName";
            this.txt_Result_ColorName.ReadOnly = true;
            this.txt_Result_ColorName.Size = new System.Drawing.Size(290, 21);
            this.txt_Result_ColorName.TabIndex = 369;
            // 
            // txt_Result_ItemName
            // 
            this.txt_Result_ItemName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Result_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Result_ItemName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result_ItemName.Location = new System.Drawing.Point(181, 21);
            this.txt_Result_ItemName.Name = "txt_Result_ItemName";
            this.txt_Result_ItemName.ReadOnly = true;
            this.txt_Result_ItemName.Size = new System.Drawing.Size(290, 21);
            this.txt_Result_ItemName.TabIndex = 367;
            // 
            // txt_Result_ColorCd
            // 
            this.txt_Result_ColorCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Result_ColorCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Result_ColorCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result_ColorCd.Location = new System.Drawing.Point(110, 43);
            this.txt_Result_ColorCd.Name = "txt_Result_ColorCd";
            this.txt_Result_ColorCd.ReadOnly = true;
            this.txt_Result_ColorCd.Size = new System.Drawing.Size(70, 21);
            this.txt_Result_ColorCd.TabIndex = 366;
            // 
            // lbl_Result_Color
            // 
            this.lbl_Result_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Result_Color.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result_Color.ImageIndex = 2;
            this.lbl_Result_Color.ImageList = this.img_Label;
            this.lbl_Result_Color.Location = new System.Drawing.Point(9, 43);
            this.lbl_Result_Color.Name = "lbl_Result_Color";
            this.lbl_Result_Color.Size = new System.Drawing.Size(100, 21);
            this.lbl_Result_Color.TabIndex = 365;
            this.lbl_Result_Color.Text = "Color";
            this.lbl_Result_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Result_ItemCd
            // 
            this.txt_Result_ItemCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Result_ItemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Result_ItemCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result_ItemCd.Location = new System.Drawing.Point(110, 21);
            this.txt_Result_ItemCd.Name = "txt_Result_ItemCd";
            this.txt_Result_ItemCd.ReadOnly = true;
            this.txt_Result_ItemCd.Size = new System.Drawing.Size(70, 21);
            this.txt_Result_ItemCd.TabIndex = 362;
            // 
            // lbl_Result_Item
            // 
            this.lbl_Result_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Result_Item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result_Item.ImageIndex = 2;
            this.lbl_Result_Item.ImageList = this.img_Label;
            this.lbl_Result_Item.Location = new System.Drawing.Point(9, 21);
            this.lbl_Result_Item.Name = "lbl_Result_Item";
            this.lbl_Result_Item.Size = new System.Drawing.Size(100, 21);
            this.lbl_Result_Item.TabIndex = 361;
            this.lbl_Result_Item.Text = "Item";
            this.lbl_Result_Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spd_spec
            // 
            this.spd_spec.Location = new System.Drawing.Point(0, 64);
            this.spd_spec.Name = "spd_spec";
            this.spd_spec.Sheets.Add(this.spd_spec_Sheet1);
            this.spd_spec.Size = new System.Drawing.Size(480, 200);
            this.spd_spec.TabIndex = 28;
            this.spd_spec.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_spec_CellDoubleClick);
            // 
            // spd_spec_Sheet1
            // 
            this.spd_spec_Sheet1.SheetName = "Sheet1";
            // 
            // spd_result
            // 
            this.spd_result.Location = new System.Drawing.Point(0, 360);
            this.spd_result.Name = "spd_result";
            this.spd_result.Sheets.Add(this.spd_result_Sheet1);
            this.spd_result.Size = new System.Drawing.Size(480, 136);
            this.spd_result.TabIndex = 29;
            this.spd_result.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_result_CellClick);
            // 
            // spd_result_Sheet1
            // 
            this.spd_result_Sheet1.SheetName = "Sheet1";
            // 
            // chk_UseYN_Spec
            // 
            this.chk_UseYN_Spec.Location = new System.Drawing.Point(0, 0);
            this.chk_UseYN_Spec.Name = "chk_UseYN_Spec";
            this.chk_UseYN_Spec.Size = new System.Drawing.Size(104, 24);
            this.chk_UseYN_Spec.TabIndex = 0;
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(345, 544);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(72, 23);
            this.btn_apply.TabIndex = 356;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(417, 544);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(72, 23);
            this.btn_cancel.TabIndex = 356;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Pop_BS_Shipping_Request_Item_List
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(494, 575);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.btn_cancel);
            this.Name = "Pop_BS_Shipping_Request_Item_List";
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.pnl_main, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.pnl_main.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SpecDiv)).EndInit();
            this.gb_result.ResumeLayout(false);
            this.gb_result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_spec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_spec_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_result_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void btn_SearchSpec_Click(object sender, System.EventArgs e)
		{
			Select_Specification();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			Return_Item_Data();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		
		private void spd_spec_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			Set_Return_Specification(e);
		}

		private void spd_result_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			Remove_ResultItem(e);
		}

		private void Init_Form()
        {
			this.Text = "Add Specification";
			lbl_MainTitle.Text = "Add Specification"; 
            ClassLib.ComFunction.SetLangDic(this);

			spd_spec.Set_Spread_Comm("SBC_SPEC_COMMON", "1", 1, COM.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false); 
			spd_result.Set_Spread_Comm("SBC_SPEC_COMMON", "1", 1, COM.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false); 

			// Specification Division Combo List
			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSpecDiv);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SpecDiv, 1, 4, false, ClassLib.ComVar.ComboList_Visible.Name); 
			dt_ret.Dispose();

			// 0 : item code, 1 : item name, 2 : spec code, 3 : spec name, 4 : color code, 5 : color name, 6 : unit
			this.txt_Result_ItemCd.Text = COM.ComVar.Parameter_PopUp[0];
			this.txt_Result_ItemName.Text = COM.ComVar.Parameter_PopUp[1];
			this.txt_Result_ColorCd.Text = COM.ComVar.Parameter_PopUp[4];
			this.txt_Result_ColorName.Text = COM.ComVar.Parameter_PopUp[5];
			this.txt_Result_Unit.Text = COM.ComVar.Parameter_PopUp[6];
		}

		/// <summary>
		/// Select_Specification : Specification Master 조회
		/// </summary>
		private void Select_Specification()
		{
			try
			{
				DataTable dt_ret;

				this.Cursor = Cursors.WaitCursor; 

				string spec_div = ClassLib.ComFunction.Empty_Combo(cmb_SpecDiv, " ");
				string spec_name = ClassLib.ComFunction.Empty_TextBox(txt_SpecName, " ");
				string use_yn = (chk_UseYN_Spec.Checked) ? "Y" : " ";

				dt_ret = Select_SBC_SPEC_COMMON(spec_div, spec_name, use_yn);

				spd_spec.Display_Grid(dt_ret);
                spd_spec.Set_FontColor_Row((int)FlexBase.ClassLib.TBSBC_SPEC_COMMON.IxUSE_YN, "False", System.Drawing.Color.Red);
                spd_spec.Set_FontColor_Row((int)FlexBase.ClassLib.TBSBC_SPEC_COMMON.IxUSE_YN, "True", System.Drawing.Color.Empty);
				
				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		/// <summary>
		/// Remove_ResultItem : 선택 항목 제거
		/// </summary>
		private void Remove_ResultItem(FarPoint.Win.Spread.CellClickEventArgs e)
		{
			spd_result.ActiveSheet.Rows[e.Row].Remove();
		}

		/// <summary>
		/// Set_Return_Specification : Specification Select
		/// </summary>
		private void Set_Return_Specification(FarPoint.Win.Spread.CellClickEventArgs e)
		{
			try
			{
				// IxSPEC_CD = 1, IxSPEC_NAME = 2, IxUSE_YN = 3,
				if(spd_spec.ActiveSheet.RowCount == 0) return;

				int vSelRowIndex = e.Row;
				int vNewRowIndex = spd_result.Add_Row(img_Action);

                object vSpecCode = spd_spec.ActiveSheet.Cells[vSelRowIndex, (int)FlexBase.ClassLib.TBSBC_SPEC_COMMON.IxSPEC_CD].Value;
                object vSpecName = spd_spec.ActiveSheet.Cells[vSelRowIndex, (int)FlexBase.ClassLib.TBSBC_SPEC_COMMON.IxSPEC_NAME].Value;
                object vUseYN = spd_spec.ActiveSheet.Cells[vSelRowIndex, (int)FlexBase.ClassLib.TBSBC_SPEC_COMMON.IxUSE_YN].Value;

                spd_result.ActiveSheet.Cells[vNewRowIndex, (int)FlexBase.ClassLib.TBSBC_SPEC_COMMON.IxSPEC_CD].Value = vSpecCode;
                spd_result.ActiveSheet.Cells[vNewRowIndex, (int)FlexBase.ClassLib.TBSBC_SPEC_COMMON.IxSPEC_NAME].Value = vSpecName;
                spd_result.ActiveSheet.Cells[vNewRowIndex, (int)FlexBase.ClassLib.TBSBC_SPEC_COMMON.IxUSE_YN].Value = vUseYN;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "spd_spec_CellDoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		/// <summary>
		/// Return_Item_Data : Return Data
		/// </summary>
		private void Return_Item_Data()
		{
			try
			{
				string[] vData = null;
				ArrayList vResult = new ArrayList();

				for (int vRow = 0 ; vRow < spd_result.ActiveSheet.Rows.Count ; vRow++)
				{
					vData = new string[2];
                    vData[0] = spd_spec.ActiveSheet.Cells[vRow, (int)FlexBase.ClassLib.TBSBC_SPEC_COMMON.IxSPEC_CD].Text;
                    vData[1] = spd_spec.ActiveSheet.Cells[vRow, (int)FlexBase.ClassLib.TBSBC_SPEC_COMMON.IxSPEC_NAME].Text;

					vResult.Add(vData);
				}

				ClassLib.ComVar.Parameter_PopUp_Object = new object[]{vResult};
				if (vResult.Count > 0)
					this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Item_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		/// <summary>
		/// Select_SBC_SPEC_COMMON : Sepcification LIST Combo
		/// </summary>
		/// <param name="arg_specdiv"></param>
		/// <param name="arg_specname"></param>
		/// <param name="arg_useyn"></param>
		/// <returns></returns>
		public static DataTable Select_SBC_SPEC_COMMON(string arg_specdiv, string arg_specname, string arg_useyn)
		{
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(4); 

			MyOraDB.Process_Name = "PKG_SBC_SPEC.SELECT_SBC_SPEC_COMMON"; 

			MyOraDB.Parameter_Name[0] = "ARG_SPEC_DIV";
			MyOraDB.Parameter_Name[1] = "ARG_SPEC_NAME"; 
			MyOraDB.Parameter_Name[2] = "ARG_USE_YN";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_specdiv; 
			MyOraDB.Parameter_Values[1] = arg_specname;  
			MyOraDB.Parameter_Values[2] = arg_useyn; 
			MyOraDB.Parameter_Values[3] = ""; 


			MyOraDB.Add_Select_Parameter(true);

			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name];
		}
	}
}

