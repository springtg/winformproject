using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient; 


namespace FlexBase.MaterialBase
{
	public class Pop_Item_List : COM.PCHWinForm.Pop_Normal_Light
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Command.C1OutBar obar_Main;
		private C1.Win.C1Command.C1OutPage obarpg_Item;
		private C1.Win.C1Command.C1OutPage obarpg_Spec;
		private C1.Win.C1Command.C1OutPage obarpg_Color;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_ItemGroup;
		private System.Windows.Forms.Label lbl_ItemName;
		private System.Windows.Forms.TextBox txt_ItemName;
		private C1.Win.C1List.C1Combo cmb_ItemGroup;
		private System.Windows.Forms.TextBox txt_ItemCd;
		private COM.SSP grid_Item;
		private FarPoint.Win.Spread.SheetView grid_Item_Sheet1;
		private System.Windows.Forms.GroupBox groupBox2;
		private COM.SSP grid_Spec;
		private FarPoint.Win.Spread.SheetView grid_Spec_Sheet1;
		private C1.Win.C1List.C1Combo cmb_SpecDiv;
		private System.Windows.Forms.Label lbl_SpecDiv;
		private System.Windows.Forms.Label btn_SearchItem;
		private System.Windows.Forms.Label lbl_SpecName;
		private System.Windows.Forms.CheckBox chk_UseYN_Item;
		private System.Windows.Forms.CheckBox chk_UseYN_Spec;
		private System.Windows.Forms.Label btn_SearchSpec;
		private System.Windows.Forms.GroupBox groupBox3;
		private COM.SSP grid_Color;
		private FarPoint.Win.Spread.SheetView grid_Color_Sheet1;
		private System.Windows.Forms.Label btn_SearchColor;
		private System.Windows.Forms.Label lbl_Color;
		private System.Windows.Forms.CheckBox chk_UseYN_Color;
		private System.Windows.Forms.TextBox txt_ColorName;
		private System.Windows.Forms.TextBox txt_ColorCd;
		private System.Windows.Forms.GroupBox gb_result;
		private System.Windows.Forms.Label lbl_lbl_Result_Unit;
		private System.Windows.Forms.Label lbl_Result_Color;
		private System.Windows.Forms.Label lbl_Result_Spec;
		private System.Windows.Forms.Label lbl_Result_Item;
		private System.Windows.Forms.TextBox txt_Result_Unit;
		private System.Windows.Forms.TextBox txt_Result_ColorName;
		private System.Windows.Forms.TextBox txt_Result_SepcName;
		private System.Windows.Forms.TextBox txt_Result_ItemName;
		private System.Windows.Forms.TextBox txt_Result_ColorCd;
		private System.Windows.Forms.TextBox txt_Result_SepcCd;
		private System.Windows.Forms.TextBox txt_Result_ItemCd;
		private System.Windows.Forms.CheckBox chk_Result_SizeYN;
		private C1.Win.C1List.C1Combo cmb_ItemType;
		private System.Windows.Forms.Label btn_JointColor;
		public System.Windows.Forms.ImageList img_SmallButton;
		private System.Windows.Forms.Button btn_Return;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_AddNewItem;
		private System.ComponentModel.IContainer components = null;
		private bool bi_incoming_item_change_mode = false;
		private string item_code = null;
		private string item_name = null;
		private string spec_code = null;
		private string spec_name = null;
		private string color_code = null;
		private System.Windows.Forms.TextBox txt_SpecCd;
		private System.Windows.Forms.TextBox txt_SpecName;
		private System.Windows.Forms.ContextMenu cmenu_spec;
		private System.Windows.Forms.MenuItem menuItem_UseSpecDel;
		private string color_name = null;



		#endregion

		#region 생성자, 소멸자



		public Pop_Item_List()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다. 
		}


		public Pop_Item_List(bool arg_bi_incoming_item_change_mode, string arg_item_code, string arg_item_name, string arg_spec_code, string arg_spec_name, string arg_color_code, string arg_color_name)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			bi_incoming_item_change_mode = arg_bi_incoming_item_change_mode;
			item_code       = arg_item_code;
			item_name       = arg_item_name;
			spec_code       = arg_spec_code;
			spec_name       = arg_spec_name;
			color_code      = arg_color_code;
			color_name      = arg_color_name;
		}





		private System.Windows.Forms.Form _ThisForm = null;
		private string _ItemCd = "", _ItemName = "", _Unit = "", _SizeYN = "";
		private string _SpecCd = "", _SpecName = "";
		private string _ColorCd = "", _ColorName = "";
		private string _tabPage = ""; 
		private bool _DefaultView = false;

		public Pop_Item_List(string arg_itemcd, 
			string arg_itemname, 
			string arg_speccd, 
			string arg_specname, 
			string arg_colorcd, 
			string arg_colorname, 
			string arg_unit,
			string arg_sizeyn)
		{ 
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_ItemCd = arg_itemcd;
			_ItemName = arg_itemname;
			_SpecCd = arg_speccd;
			_SpecName = arg_specname;
			_ColorCd = arg_colorcd;
			_ColorName = arg_colorname;
			_Unit = arg_unit;
			_SizeYN = arg_sizeyn;

			Init_Form();  

		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg_itemcd"></param>
		/// <param name="arg_itemname"></param>
		/// <param name="arg_speccd"></param>
		/// <param name="arg_specname"></param>
		/// <param name="arg_colorcd"></param>
		/// <param name="arg_colorname"></param>
		/// <param name="arg_unit"></param>
		/// <param name="arg_sizeyn"></param>
		/// <param name="default_view">조회 텍스트 박스에 기본으로 Result 텍스트 박스 내용 기재</param>
		public Pop_Item_List(string arg_itemcd, 
			string arg_itemname, 
			string arg_speccd, 
			string arg_specname, 
			string arg_colorcd, 
			string arg_colorname, 
			string arg_unit,
			string arg_sizeyn,
			bool arg_default_view)
		{ 
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_ItemCd = arg_itemcd;
			_ItemName = arg_itemname;
			_SpecCd = arg_speccd;
			_SpecName = arg_specname;
			_ColorCd = arg_colorcd;
			_ColorName = arg_colorname;
			_Unit = arg_unit;
			_SizeYN = arg_sizeyn;

			_DefaultView = arg_default_view;

			Init_Form();  

		}






		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg_form">return 받을 대상 form</param>
		/// <param name="arg_itemcd"></param>
		/// <param name="arg_itemname"></param>
		/// <param name="arg_speccd"></param>
		/// <param name="arg_specname"></param>
		/// <param name="arg_colorcd"></param>
		/// <param name="arg_colorname"></param>
		/// <param name="arg_unit"></param> 
		/// <param name="arg_sizeyn"></param>
		/// <param name="arg_default_view">조회 텍스트 박스에 기본으로 Result 텍스트 박스 내용 기재</param> 
		public Pop_Item_List(System.Windows.Forms.Form arg_form,  
			string arg_itemcd, 
			string arg_itemname, 
			string arg_speccd, 
			string arg_specname, 
			string arg_colorcd, 
			string arg_colorname, 
			string arg_unit,
			string arg_sizeyn,
			bool arg_default_view)
		{ 
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_ThisForm = arg_form;
			_ItemCd = arg_itemcd;
			_ItemName = arg_itemname;
			_SpecCd = arg_speccd;
			_SpecName = arg_specname;
			_ColorCd = arg_colorcd;
			_ColorName = arg_colorname;
			_Unit = arg_unit;
			_SizeYN = arg_sizeyn;

			_DefaultView = arg_default_view;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Item_List));
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
            this.obar_Main = new C1.Win.C1Command.C1OutBar();
            this.obarpg_Item = new C1.Win.C1Command.C1OutPage();
            this.grid_Item = new COM.SSP();
            this.grid_Item_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_ItemType = new C1.Win.C1List.C1Combo();
            this.btn_SearchItem = new System.Windows.Forms.Label();
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.cmb_ItemGroup = new C1.Win.C1List.C1Combo();
            this.txt_ItemCd = new System.Windows.Forms.TextBox();
            this.lbl_ItemGroup = new System.Windows.Forms.Label();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.chk_UseYN_Item = new System.Windows.Forms.CheckBox();
            this.obarpg_Spec = new C1.Win.C1Command.C1OutPage();
            this.grid_Spec = new COM.SSP();
            this.cmenu_spec = new System.Windows.Forms.ContextMenu();
            this.menuItem_UseSpecDel = new System.Windows.Forms.MenuItem();
            this.grid_Spec_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_SpecCd = new System.Windows.Forms.TextBox();
            this.txt_SpecName = new System.Windows.Forms.TextBox();
            this.btn_SearchSpec = new System.Windows.Forms.Label();
            this.cmb_SpecDiv = new C1.Win.C1List.C1Combo();
            this.lbl_SpecDiv = new System.Windows.Forms.Label();
            this.lbl_SpecName = new System.Windows.Forms.Label();
            this.chk_UseYN_Spec = new System.Windows.Forms.CheckBox();
            this.obarpg_Color = new C1.Win.C1Command.C1OutPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_JointColor = new System.Windows.Forms.Label();
            this.txt_ColorName = new System.Windows.Forms.TextBox();
            this.txt_ColorCd = new System.Windows.Forms.TextBox();
            this.btn_SearchColor = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.chk_UseYN_Color = new System.Windows.Forms.CheckBox();
            this.grid_Color = new COM.SSP();
            this.grid_Color_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.gb_result = new System.Windows.Forms.GroupBox();
            this.chk_Result_SizeYN = new System.Windows.Forms.CheckBox();
            this.txt_Result_Unit = new System.Windows.Forms.TextBox();
            this.lbl_lbl_Result_Unit = new System.Windows.Forms.Label();
            this.txt_Result_ColorName = new System.Windows.Forms.TextBox();
            this.txt_Result_SepcName = new System.Windows.Forms.TextBox();
            this.txt_Result_ItemName = new System.Windows.Forms.TextBox();
            this.txt_Result_ColorCd = new System.Windows.Forms.TextBox();
            this.lbl_Result_Color = new System.Windows.Forms.Label();
            this.txt_Result_SepcCd = new System.Windows.Forms.TextBox();
            this.lbl_Result_Spec = new System.Windows.Forms.Label();
            this.txt_Result_ItemCd = new System.Windows.Forms.TextBox();
            this.lbl_Result_Item = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_AddNewItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
            this.obar_Main.SuspendLayout();
            this.obarpg_Item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Item_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ItemGroup)).BeginInit();
            this.obarpg_Spec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Spec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Spec_Sheet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SpecDiv)).BeginInit();
            this.obarpg_Color.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Color_Sheet1)).BeginInit();
            this.gb_result.SuspendLayout();
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
            // obar_Main
            // 
            this.obar_Main.Animate = false;
            this.obar_Main.BackColor = System.Drawing.SystemColors.Window;
            this.obar_Main.Controls.Add(this.obarpg_Item);
            this.obar_Main.Controls.Add(this.obarpg_Spec);
            this.obar_Main.Controls.Add(this.obarpg_Color);
            this.obar_Main.Location = new System.Drawing.Point(4, 39);
            this.obar_Main.Name = "obar_Main";
            this.obar_Main.SelectedIndex = 1;
            this.obar_Main.Size = new System.Drawing.Size(484, 337);
            // 
            // obarpg_Item
            // 
            this.obarpg_Item.Controls.Add(this.grid_Item);
            this.obarpg_Item.Controls.Add(this.groupBox1);
            this.obarpg_Item.Name = "obarpg_Item";
            this.obarpg_Item.Size = new System.Drawing.Size(484, 286);
            this.obarpg_Item.Text = "Item";
            // 
            // grid_Item
            // 
            this.grid_Item.Location = new System.Drawing.Point(8, 72);
            this.grid_Item.Name = "grid_Item";
            this.grid_Item.Sheets.Add(this.grid_Item_Sheet1);
            this.grid_Item.Size = new System.Drawing.Size(450, 200);
            this.grid_Item.TabIndex = 2;
            this.grid_Item.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.grid_Item_CellDoubleClick);
            // 
            // grid_Item_Sheet1
            // 
            this.grid_Item_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_ItemType);
            this.groupBox1.Controls.Add(this.btn_SearchItem);
            this.groupBox1.Controls.Add(this.txt_ItemName);
            this.groupBox1.Controls.Add(this.cmb_ItemGroup);
            this.groupBox1.Controls.Add(this.txt_ItemCd);
            this.groupBox1.Controls.Add(this.lbl_ItemGroup);
            this.groupBox1.Controls.Add(this.lbl_ItemName);
            this.groupBox1.Controls.Add(this.chk_UseYN_Item);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmb_ItemType
            // 
            this.cmb_ItemType.AccessibleDescription = "";
            this.cmb_ItemType.AccessibleName = "";
            this.cmb_ItemType.AddItemSeparator = ';';
            this.cmb_ItemType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ItemType.Caption = "";
            this.cmb_ItemType.CaptionHeight = 17;
            this.cmb_ItemType.CaptionStyle = style1;
            this.cmb_ItemType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ItemType.ColumnCaptionHeight = 18;
            this.cmb_ItemType.ColumnFooterHeight = 18;
            this.cmb_ItemType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ItemType.ContentHeight = 16;
            this.cmb_ItemType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ItemType.EditorBackColor = System.Drawing.Color.White;
            this.cmb_ItemType.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ItemType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ItemType.EditorHeight = 16;
            this.cmb_ItemType.EvenRowStyle = style2;
            this.cmb_ItemType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ItemType.FooterStyle = style3;
            this.cmb_ItemType.HeadingStyle = style4;
            this.cmb_ItemType.HighLightRowStyle = style5;
            this.cmb_ItemType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_ItemType.Images"))));
            this.cmb_ItemType.ItemHeight = 15;
            this.cmb_ItemType.Location = new System.Drawing.Point(108, 13);
            this.cmb_ItemType.MatchEntryTimeout = ((long)(2000));
            this.cmb_ItemType.MaxDropDownItems = ((short)(5));
            this.cmb_ItemType.MaxLength = 2;
            this.cmb_ItemType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ItemType.Name = "cmb_ItemType";
            this.cmb_ItemType.OddRowStyle = style6;
            this.cmb_ItemType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ItemType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ItemType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ItemType.SelectedStyle = style7;
            this.cmb_ItemType.Size = new System.Drawing.Size(140, 20);
            this.cmb_ItemType.Style = style8;
            this.cmb_ItemType.TabIndex = 570;
            this.cmb_ItemType.SelectedValueChanged += new System.EventHandler(this.cmb_ItemType_SelectedValueChanged);
            this.cmb_ItemType.PropBag = resources.GetString("cmb_ItemType.PropBag");
            // 
            // btn_SearchItem
            // 
            this.btn_SearchItem.ImageIndex = 0;
            this.btn_SearchItem.ImageList = this.img_SmallButton;
            this.btn_SearchItem.Location = new System.Drawing.Point(421, 35);
            this.btn_SearchItem.Name = "btn_SearchItem";
            this.btn_SearchItem.Size = new System.Drawing.Size(21, 21);
            this.btn_SearchItem.TabIndex = 569;
            this.btn_SearchItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchItem.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SearchItem.Click += new System.EventHandler(this.btn_search_item_Click);
            this.btn_SearchItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_SearchItem.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_SearchItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.BackColor = System.Drawing.Color.White;
            this.txt_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ItemName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_ItemName.Location = new System.Drawing.Point(249, 35);
            this.txt_ItemName.MaxLength = 100;
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(168, 21);
            this.txt_ItemName.TabIndex = 567;
            this.txt_ItemName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // cmb_ItemGroup
            // 
            this.cmb_ItemGroup.AccessibleDescription = "";
            this.cmb_ItemGroup.AccessibleName = "";
            this.cmb_ItemGroup.AddItemSeparator = ';';
            this.cmb_ItemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ItemGroup.Caption = "";
            this.cmb_ItemGroup.CaptionHeight = 17;
            this.cmb_ItemGroup.CaptionStyle = style9;
            this.cmb_ItemGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ItemGroup.ColumnCaptionHeight = 18;
            this.cmb_ItemGroup.ColumnFooterHeight = 18;
            this.cmb_ItemGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ItemGroup.ContentHeight = 16;
            this.cmb_ItemGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ItemGroup.EditorBackColor = System.Drawing.Color.White;
            this.cmb_ItemGroup.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ItemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ItemGroup.EditorHeight = 16;
            this.cmb_ItemGroup.EvenRowStyle = style10;
            this.cmb_ItemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ItemGroup.FooterStyle = style11;
            this.cmb_ItemGroup.HeadingStyle = style12;
            this.cmb_ItemGroup.HighLightRowStyle = style13;
            this.cmb_ItemGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_ItemGroup.Images"))));
            this.cmb_ItemGroup.ItemHeight = 15;
            this.cmb_ItemGroup.Location = new System.Drawing.Point(249, 13);
            this.cmb_ItemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_ItemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_ItemGroup.MaxLength = 2;
            this.cmb_ItemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ItemGroup.Name = "cmb_ItemGroup";
            this.cmb_ItemGroup.OddRowStyle = style14;
            this.cmb_ItemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ItemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ItemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ItemGroup.SelectedStyle = style15;
            this.cmb_ItemGroup.Size = new System.Drawing.Size(140, 20);
            this.cmb_ItemGroup.Style = style16;
            this.cmb_ItemGroup.TabIndex = 566;
            this.cmb_ItemGroup.PropBag = resources.GetString("cmb_ItemGroup.PropBag");
            // 
            // txt_ItemCd
            // 
            this.txt_ItemCd.BackColor = System.Drawing.Color.White;
            this.txt_ItemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ItemCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ItemCd.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_ItemCd.Location = new System.Drawing.Point(108, 35);
            this.txt_ItemCd.MaxLength = 10;
            this.txt_ItemCd.Name = "txt_ItemCd";
            this.txt_ItemCd.Size = new System.Drawing.Size(140, 21);
            this.txt_ItemCd.TabIndex = 565;
            this.txt_ItemCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // lbl_ItemGroup
            // 
            this.lbl_ItemGroup.ImageIndex = 0;
            this.lbl_ItemGroup.ImageList = this.img_Label;
            this.lbl_ItemGroup.Location = new System.Drawing.Point(7, 13);
            this.lbl_ItemGroup.Name = "lbl_ItemGroup";
            this.lbl_ItemGroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_ItemGroup.TabIndex = 564;
            this.lbl_ItemGroup.Text = "Group";
            this.lbl_ItemGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.ImageIndex = 0;
            this.lbl_ItemName.ImageList = this.img_Label;
            this.lbl_ItemName.Location = new System.Drawing.Point(7, 35);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(100, 21);
            this.lbl_ItemName.TabIndex = 563;
            this.lbl_ItemName.Text = "Item";
            this.lbl_ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_UseYN_Item
            // 
            this.chk_UseYN_Item.Enabled = false;
            this.chk_UseYN_Item.Location = new System.Drawing.Point(396, 13);
            this.chk_UseYN_Item.Name = "chk_UseYN_Item";
            this.chk_UseYN_Item.Size = new System.Drawing.Size(46, 21);
            this.chk_UseYN_Item.TabIndex = 51;
            this.chk_UseYN_Item.Text = "Use";
            // 
            // obarpg_Spec
            // 
            this.obarpg_Spec.Controls.Add(this.grid_Spec);
            this.obarpg_Spec.Controls.Add(this.groupBox2);
            this.obarpg_Spec.Name = "obarpg_Spec";
            this.obarpg_Spec.Size = new System.Drawing.Size(484, 286);
            this.obarpg_Spec.Text = "Sepcification";
            // 
            // grid_Spec
            // 
            this.grid_Spec.ContextMenu = this.cmenu_spec;
            this.grid_Spec.Location = new System.Drawing.Point(8, 72);
            this.grid_Spec.Name = "grid_Spec";
            this.grid_Spec.Sheets.Add(this.grid_Spec_Sheet1);
            this.grid_Spec.Size = new System.Drawing.Size(450, 200);
            this.grid_Spec.TabIndex = 29;
            this.grid_Spec.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.grid_Spec_CellDoubleClick);
            // 
            // cmenu_spec
            // 
            this.cmenu_spec.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_UseSpecDel});
            // 
            // menuItem_UseSpecDel
            // 
            this.menuItem_UseSpecDel.Index = 0;
            this.menuItem_UseSpecDel.Text = "Delete";
            this.menuItem_UseSpecDel.Click += new System.EventHandler(this.menuItem_UseSpecDel_Click);
            // 
            // grid_Spec_Sheet1
            // 
            this.grid_Spec_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_SpecCd);
            this.groupBox2.Controls.Add(this.txt_SpecName);
            this.groupBox2.Controls.Add(this.btn_SearchSpec);
            this.groupBox2.Controls.Add(this.cmb_SpecDiv);
            this.groupBox2.Controls.Add(this.lbl_SpecDiv);
            this.groupBox2.Controls.Add(this.lbl_SpecName);
            this.groupBox2.Controls.Add(this.chk_UseYN_Spec);
            this.groupBox2.Location = new System.Drawing.Point(7, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 63);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // txt_SpecCd
            // 
            this.txt_SpecCd.BackColor = System.Drawing.Color.White;
            this.txt_SpecCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SpecCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_SpecCd.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SpecCd.Location = new System.Drawing.Point(108, 35);
            this.txt_SpecCd.MaxLength = 10;
            this.txt_SpecCd.Name = "txt_SpecCd";
            this.txt_SpecCd.Size = new System.Drawing.Size(70, 21);
            this.txt_SpecCd.TabIndex = 573;
            this.txt_SpecCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // txt_SpecName
            // 
            this.txt_SpecName.BackColor = System.Drawing.Color.White;
            this.txt_SpecName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SpecName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_SpecName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SpecName.Location = new System.Drawing.Point(179, 35);
            this.txt_SpecName.MaxLength = 100;
            this.txt_SpecName.Name = "txt_SpecName";
            this.txt_SpecName.Size = new System.Drawing.Size(236, 21);
            this.txt_SpecName.TabIndex = 572;
            this.txt_SpecName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // btn_SearchSpec
            // 
            this.btn_SearchSpec.ImageIndex = 0;
            this.btn_SearchSpec.ImageList = this.img_SmallButton;
            this.btn_SearchSpec.Location = new System.Drawing.Point(421, 35);
            this.btn_SearchSpec.Name = "btn_SearchSpec";
            this.btn_SearchSpec.Size = new System.Drawing.Size(21, 21);
            this.btn_SearchSpec.TabIndex = 569;
            this.btn_SearchSpec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchSpec.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SearchSpec.Click += new System.EventHandler(this.btn_SearchSpec_Click);
            this.btn_SearchSpec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_SearchSpec.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_SearchSpec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // cmb_SpecDiv
            // 
            this.cmb_SpecDiv.AccessibleDescription = "";
            this.cmb_SpecDiv.AccessibleName = "";
            this.cmb_SpecDiv.AddItemSeparator = ';';
            this.cmb_SpecDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SpecDiv.Caption = "";
            this.cmb_SpecDiv.CaptionHeight = 17;
            this.cmb_SpecDiv.CaptionStyle = style17;
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
            this.cmb_SpecDiv.EvenRowStyle = style18;
            this.cmb_SpecDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SpecDiv.FooterStyle = style19;
            this.cmb_SpecDiv.HeadingStyle = style20;
            this.cmb_SpecDiv.HighLightRowStyle = style21;
            this.cmb_SpecDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_SpecDiv.Images"))));
            this.cmb_SpecDiv.ItemHeight = 15;
            this.cmb_SpecDiv.Location = new System.Drawing.Point(108, 13);
            this.cmb_SpecDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_SpecDiv.MaxDropDownItems = ((short)(5));
            this.cmb_SpecDiv.MaxLength = 2;
            this.cmb_SpecDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SpecDiv.Name = "cmb_SpecDiv";
            this.cmb_SpecDiv.OddRowStyle = style22;
            this.cmb_SpecDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SpecDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SpecDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SpecDiv.SelectedStyle = style23;
            this.cmb_SpecDiv.Size = new System.Drawing.Size(281, 20);
            this.cmb_SpecDiv.Style = style24;
            this.cmb_SpecDiv.TabIndex = 566;
            this.cmb_SpecDiv.PropBag = resources.GetString("cmb_SpecDiv.PropBag");
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
            // chk_UseYN_Spec
            // 
            this.chk_UseYN_Spec.Enabled = false;
            this.chk_UseYN_Spec.Location = new System.Drawing.Point(396, 13);
            this.chk_UseYN_Spec.Name = "chk_UseYN_Spec";
            this.chk_UseYN_Spec.Size = new System.Drawing.Size(46, 21);
            this.chk_UseYN_Spec.TabIndex = 51;
            this.chk_UseYN_Spec.Text = "Use";
            // 
            // obarpg_Color
            // 
            this.obarpg_Color.Controls.Add(this.groupBox3);
            this.obarpg_Color.Controls.Add(this.grid_Color);
            this.obarpg_Color.Name = "obarpg_Color";
            this.obarpg_Color.Size = new System.Drawing.Size(484, 269);
            this.obarpg_Color.Text = "Color";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_JointColor);
            this.groupBox3.Controls.Add(this.txt_ColorName);
            this.groupBox3.Controls.Add(this.txt_ColorCd);
            this.groupBox3.Controls.Add(this.btn_SearchColor);
            this.groupBox3.Controls.Add(this.lbl_Color);
            this.groupBox3.Controls.Add(this.chk_UseYN_Color);
            this.groupBox3.Location = new System.Drawing.Point(7, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 42);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // btn_JointColor
            // 
            this.btn_JointColor.ImageIndex = 2;
            this.btn_JointColor.ImageList = this.img_SmallButton;
            this.btn_JointColor.Location = new System.Drawing.Point(399, 13);
            this.btn_JointColor.Name = "btn_JointColor";
            this.btn_JointColor.Size = new System.Drawing.Size(21, 21);
            this.btn_JointColor.TabIndex = 572;
            this.btn_JointColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_JointColor.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_JointColor.Click += new System.EventHandler(this.btn_JointColor_Click);
            this.btn_JointColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_JointColor.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_JointColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // txt_ColorName
            // 
            this.txt_ColorName.BackColor = System.Drawing.Color.White;
            this.txt_ColorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ColorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ColorName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_ColorName.Location = new System.Drawing.Point(179, 13);
            this.txt_ColorName.MaxLength = 100;
            this.txt_ColorName.Name = "txt_ColorName";
            this.txt_ColorName.Size = new System.Drawing.Size(168, 21);
            this.txt_ColorName.TabIndex = 571;
            this.txt_ColorName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // txt_ColorCd
            // 
            this.txt_ColorCd.BackColor = System.Drawing.Color.White;
            this.txt_ColorCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ColorCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ColorCd.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_ColorCd.Location = new System.Drawing.Point(108, 13);
            this.txt_ColorCd.MaxLength = 10;
            this.txt_ColorCd.Name = "txt_ColorCd";
            this.txt_ColorCd.Size = new System.Drawing.Size(70, 21);
            this.txt_ColorCd.TabIndex = 570;
            this.txt_ColorCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // btn_SearchColor
            // 
            this.btn_SearchColor.ImageIndex = 0;
            this.btn_SearchColor.ImageList = this.img_SmallButton;
            this.btn_SearchColor.Location = new System.Drawing.Point(421, 13);
            this.btn_SearchColor.Name = "btn_SearchColor";
            this.btn_SearchColor.Size = new System.Drawing.Size(21, 21);
            this.btn_SearchColor.TabIndex = 569;
            this.btn_SearchColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchColor.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SearchColor.Click += new System.EventHandler(this.btn_SearchColor_Click);
            this.btn_SearchColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_SearchColor.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_SearchColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_Color
            // 
            this.lbl_Color.ImageIndex = 0;
            this.lbl_Color.ImageList = this.img_Label;
            this.lbl_Color.Location = new System.Drawing.Point(7, 13);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(100, 21);
            this.lbl_Color.TabIndex = 563;
            this.lbl_Color.Text = "Code/ Name";
            this.lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_UseYN_Color
            // 
            this.chk_UseYN_Color.Enabled = false;
            this.chk_UseYN_Color.Location = new System.Drawing.Point(353, 13);
            this.chk_UseYN_Color.Name = "chk_UseYN_Color";
            this.chk_UseYN_Color.Size = new System.Drawing.Size(46, 21);
            this.chk_UseYN_Color.TabIndex = 51;
            this.chk_UseYN_Color.Text = "Use";
            // 
            // grid_Color
            // 
            this.grid_Color.Location = new System.Drawing.Point(7, 48);
            this.grid_Color.Name = "grid_Color";
            this.grid_Color.Sheets.Add(this.grid_Color_Sheet1);
            this.grid_Color.Size = new System.Drawing.Size(450, 200);
            this.grid_Color.TabIndex = 30;
            this.grid_Color.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.grid_Color_CellDoubleClick);
            // 
            // grid_Color_Sheet1
            // 
            this.grid_Color_Sheet1.SheetName = "Sheet1";
            // 
            // gb_result
            // 
            this.gb_result.BackColor = System.Drawing.SystemColors.Window;
            this.gb_result.Controls.Add(this.chk_Result_SizeYN);
            this.gb_result.Controls.Add(this.txt_Result_Unit);
            this.gb_result.Controls.Add(this.lbl_lbl_Result_Unit);
            this.gb_result.Controls.Add(this.txt_Result_ColorName);
            this.gb_result.Controls.Add(this.txt_Result_SepcName);
            this.gb_result.Controls.Add(this.txt_Result_ItemName);
            this.gb_result.Controls.Add(this.txt_Result_ColorCd);
            this.gb_result.Controls.Add(this.lbl_Result_Color);
            this.gb_result.Controls.Add(this.txt_Result_SepcCd);
            this.gb_result.Controls.Add(this.lbl_Result_Spec);
            this.gb_result.Controls.Add(this.txt_Result_ItemCd);
            this.gb_result.Controls.Add(this.lbl_Result_Item);
            this.gb_result.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_result.Location = new System.Drawing.Point(4, 376);
            this.gb_result.Name = "gb_result";
            this.gb_result.Size = new System.Drawing.Size(484, 115);
            this.gb_result.TabIndex = 352;
            this.gb_result.TabStop = false;
            this.gb_result.Text = "Result";
            // 
            // chk_Result_SizeYN
            // 
            this.chk_Result_SizeYN.Enabled = false;
            this.chk_Result_SizeYN.Location = new System.Drawing.Point(415, 87);
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
            this.txt_Result_Unit.Location = new System.Drawing.Point(110, 87);
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
            this.lbl_lbl_Result_Unit.Location = new System.Drawing.Point(9, 87);
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
            this.txt_Result_ColorName.Location = new System.Drawing.Point(181, 65);
            this.txt_Result_ColorName.Name = "txt_Result_ColorName";
            this.txt_Result_ColorName.ReadOnly = true;
            this.txt_Result_ColorName.Size = new System.Drawing.Size(290, 21);
            this.txt_Result_ColorName.TabIndex = 369;
            // 
            // txt_Result_SepcName
            // 
            this.txt_Result_SepcName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Result_SepcName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Result_SepcName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result_SepcName.Location = new System.Drawing.Point(181, 43);
            this.txt_Result_SepcName.Name = "txt_Result_SepcName";
            this.txt_Result_SepcName.ReadOnly = true;
            this.txt_Result_SepcName.Size = new System.Drawing.Size(290, 21);
            this.txt_Result_SepcName.TabIndex = 368;
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
            this.txt_Result_ColorCd.Location = new System.Drawing.Point(110, 65);
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
            this.lbl_Result_Color.Location = new System.Drawing.Point(9, 65);
            this.lbl_Result_Color.Name = "lbl_Result_Color";
            this.lbl_Result_Color.Size = new System.Drawing.Size(100, 21);
            this.lbl_Result_Color.TabIndex = 365;
            this.lbl_Result_Color.Text = "Color";
            this.lbl_Result_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Result_SepcCd
            // 
            this.txt_Result_SepcCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Result_SepcCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Result_SepcCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result_SepcCd.Location = new System.Drawing.Point(110, 43);
            this.txt_Result_SepcCd.Name = "txt_Result_SepcCd";
            this.txt_Result_SepcCd.ReadOnly = true;
            this.txt_Result_SepcCd.Size = new System.Drawing.Size(70, 21);
            this.txt_Result_SepcCd.TabIndex = 364;
            // 
            // lbl_Result_Spec
            // 
            this.lbl_Result_Spec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Result_Spec.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result_Spec.ImageIndex = 2;
            this.lbl_Result_Spec.ImageList = this.img_Label;
            this.lbl_Result_Spec.Location = new System.Drawing.Point(9, 43);
            this.lbl_Result_Spec.Name = "lbl_Result_Spec";
            this.lbl_Result_Spec.Size = new System.Drawing.Size(100, 21);
            this.lbl_Result_Spec.TabIndex = 363;
            this.lbl_Result_Spec.Text = "Specification";
            this.lbl_Result_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btn_Return
            // 
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Return.ImageIndex = 0;
            this.btn_Return.ImageList = this.img_Button;
            this.btn_Return.Location = new System.Drawing.Point(345, 496);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(70, 23);
            this.btn_Return.TabIndex = 673;
            this.btn_Return.Text = "Apply";
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(416, 496);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_Cancel.TabIndex = 674;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_AddNewItem
            // 
            this.btn_AddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_AddNewItem.ImageIndex = 0;
            this.btn_AddNewItem.ImageList = this.img_Button;
            this.btn_AddNewItem.Location = new System.Drawing.Point(4, 496);
            this.btn_AddNewItem.Name = "btn_AddNewItem";
            this.btn_AddNewItem.Size = new System.Drawing.Size(70, 23);
            this.btn_AddNewItem.TabIndex = 675;
            this.btn_AddNewItem.Text = "Add New";
            this.btn_AddNewItem.Click += new System.EventHandler(this.btn_AddNewItem_Click);
            // 
            // Pop_Item_List
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(494, 528);
            this.Controls.Add(this.btn_AddNewItem);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.gb_result);
            this.Controls.Add(this.obar_Main);
            this.Name = "Pop_Item_List";
            this.Load += new System.EventHandler(this.Pop_Item_List_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Item_List_Closing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.obar_Main, 0);
            this.Controls.SetChildIndex(this.gb_result, 0);
            this.Controls.SetChildIndex(this.btn_Return, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.btn_AddNewItem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
            this.obar_Main.ResumeLayout(false);
            this.obarpg_Item.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Item_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ItemGroup)).EndInit();
            this.obarpg_Spec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Spec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Spec_Sheet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SpecDiv)).EndInit();
            this.obarpg_Color.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Color_Sheet1)).EndInit();
            this.gb_result.ResumeLayout(false);
            this.gb_result.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();

		//사이즈 Item 선택되었을 때 Specification Division을 [사이즈]로 고정시키기 위해서
		private string _Size_SpecDiv = "1";

		//return 또는 cancel 이벤트 체크
		private bool _CancelFlag = true;

		#endregion

		#region 멤버 메서드

		/// <summary>
		/// Init_Form : 
		/// </summary>
		private void Init_Form()
		{
			try
			{
				//Title
                this.Text = "Item/ Spec./ Color";
                lbl_MainTitle.Text = "Item/ Spec./ Color";

				//영문변환 사용
				ClassLib.ComFunction.SetLangDic(this);

				// 그리드 설정  
				grid_Item.Set_Spread_Comm("SBC_ITEM_COMMON", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);  
				grid_Spec.Set_Spread_Comm("SBC_SPEC_COMMON", "1", 1, COM.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false); 
				grid_Color.Set_Spread_Comm("SBC_COLOR_COMMON", "1", 1, COM.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false); 
  

				// 콤보박스 세팅
				Set_ComboBox_List();


				chk_UseYN_Item.Checked = true;
				chk_UseYN_Spec.Checked = true;
				chk_UseYN_Color.Checked = true;


				if(ClassLib.ComVar.This_PowerUser_YN == "Y")
				{
					btn_AddNewItem.Visible = true;
				}
				else
				{
					btn_AddNewItem.Visible = false;
				}
				


				//초기 결과값 세팅 - 파라미터로 데이터 기존 넘어왔을 경우 위해서
				txt_Result_ItemCd.Text = _ItemCd;
				txt_Result_ItemName.Text = _ItemName;
				txt_Result_SepcCd.Text = _SpecCd;
				txt_Result_SepcName.Text = _SpecName;
				txt_Result_ColorCd.Text = _ColorCd;
				txt_Result_ColorName.Text = _ColorName;
				txt_Result_Unit.Text = _Unit;
				chk_Result_SizeYN.Checked = (_SizeYN == "Y") ? true : false;



				if(chk_Result_SizeYN.Checked)
				{
					//cmb_SpecDiv.SelectedValue = _SpecCd.Substring(0, 1);
					cmb_SpecDiv.SelectedIndex = 0;
					//cmb_SpecDiv.Enabled = false;
				}

				if (COM.ComVar.Parameter_PopUp != null && COM.ComVar.Parameter_PopUp[0].ToString() != "")
					_tabPage	= COM.ComVar.Parameter_PopUp[0];
				
				if ( _tabPage == "Item" )
					obar_Main.SelectedPage = obarpg_Item;
				else if ( _tabPage == "Spec" )
				{
					obar_Main.SelectedPage   = obarpg_Spec;

					if(COM.ComVar.Parameter_PopUp.Length > 1) 
					{
						txt_Result_ItemCd.Text	 = COM.ComVar.Parameter_PopUp[1];
						txt_Result_ItemName.Text = COM.ComVar.Parameter_PopUp[2];
					}
				}
				else if ( _tabPage == "Color" )
					obar_Main.SelectedPage = obarpg_Color;
				else
				{
					//show default out bar page

					//if(_ItemCd.Trim() != "")
					if(txt_Result_ItemCd.Text.Trim() != "" && txt_Result_ItemName.Text.Trim() != "")
					{
						obar_Main.SelectedPage = obarpg_Spec;

						// item에 대한 default specification 정보 조회
						Search_Default_Spec();

					}
					else
					{
						obar_Main.SelectedPage = obarpg_Item;
					}
					
				}
					 


				//------------------------------------------------------------
				// 결과데이터를 조회부에도 표시
				//------------------------------------------------------------
				if(_DefaultView)
				{
					txt_ItemCd.Text = _ItemCd;
					txt_ItemName.Text = _ItemName;
					
					if(!_SpecCd.Trim().Equals("") )
					{
						cmb_SpecDiv.SelectedValue = _SpecCd.Substring(0, 1);
						txt_SpecName.Text = _SpecName;
					}

					txt_ColorCd.Text = _ColorCd;
					txt_ColorName.Text = _ColorName;




					obar_Main.SelectedPage = obarpg_Item;


				}
				//------------------------------------------------------------





				//------------------------------------------------------------
				// 입고 자재의 정보 변경
				//------------------------------------------------------------

				if(bi_incoming_item_change_mode)
				{
					//item 정보
					txt_ItemCd.Text = item_code;
					Select_Item();
					txt_Result_ItemCd.Text = item_code;
					txt_Result_ItemName.Text = item_name;



					//spec 정보
					txt_SpecName.Text = spec_name;
					Select_Specification();
					txt_Result_SepcCd.Text = spec_code;
					txt_Result_SepcName.Text = spec_name;


					txt_ColorCd.Text = color_code;
					Select_Color();
					txt_Result_ColorCd.Text = color_code;
					txt_Result_ColorName.Text = color_name;

				}




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		/// <summary>
		/// Clear_All : 
		/// </summary>
		private void Clear_All()
		{

			cmb_ItemType.SelectedIndex = -1;
			cmb_ItemGroup.SelectedIndex = -1;
			txt_ItemCd.Text = "";
			txt_ItemName.Text = ""; 
			cmb_SpecDiv.SelectedIndex = -1;
			txt_SpecCd.Text = "";
			txt_SpecName.Text = ""; 
			txt_ColorCd.Text = "";
			txt_ColorName.Text = ""; 
			txt_Result_ItemCd.Text = "";
			txt_Result_ItemName.Text = "";
			txt_Result_SepcCd.Text = "";
			txt_Result_SepcName.Text = "";
			txt_Result_ColorCd.Text = "";
			txt_Result_ColorName.Text = "";
			txt_Result_Unit.Text = "";
			chk_Result_SizeYN.Checked = false;

		}





		/// <summary>
		/// Set_ComboBox_List : 콤보박스 세팅
		/// </summary>
		private void Set_ComboBox_List()
		{
			DataTable dt_ret; 

			//그룹타입 콤보쿼리 
			dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
			ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_ItemType, 0, 1, false,  0, 130);  
			cmb_ItemType.SelectedIndex = 0;
 

			// Specification Division Combo List
			dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSpecDiv);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SpecDiv, 1, 4, true, ClassLib.ComVar.ComboList_Visible.Name); 

			dt_ret.Dispose();
			
		}



		/// <summary>
		/// item에 대한 default specification 정보 조회 
		/// </summary>
		private void Search_Default_Spec()
		{

			DataTable dt_ret; 

			string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_Result_ItemCd, " "); 

			dt_ret = Select_SBC_SPEC_MASTER(item_cd); 
			grid_Spec.Display_Grid(dt_ret);  

			dt_ret.Dispose();

		}



		/// <summary>
		/// Select_Item : Item Master 조회
		/// </summary>
		private void Select_Item()
		{
			try
			{


				DataTable dt_ret;

				this.Cursor = Cursors.WaitCursor;

				string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_ItemCd, " ");
				string group_cd = ClassLib.ComFunction.Empty_Combo(cmb_ItemType, " ") + ClassLib.ComFunction.Empty_Combo(cmb_ItemGroup, " ");
				string item_name = ClassLib.ComFunction.Empty_TextBox(txt_ItemName, " ");
				string use_yn = (chk_UseYN_Item.Checked) ? "Y" : " ";

				dt_ret = Select_SBC_ITEM_COMMON(item_cd, group_cd, item_name, use_yn);

				grid_Item.Display_Grid(dt_ret);
				grid_Item.Set_FontColor_Row((int)ClassLib.TBSBC_ITEM_COMMON.IxUSE_YN, "False", System.Drawing.Color.Red);
				grid_Item.Set_FontColor_Row((int)ClassLib.TBSBC_ITEM_COMMON.IxUSE_YN, "True", System.Drawing.Color.Empty);
				
				dt_ret.Dispose();


				

				//------------------------------------------------------------------------------------------------------------------------
				// 정확하게 일치하는 항목으로 결과값 할당
				//------------------------------------------------------------------------------------------------------------------------
				string diff_item = "";
				string current_item = "";

				for(int i = 0; i < grid_Item.ActiveSheet.RowCount; i++)
				{
				
					if(! txt_ItemCd.Text.Trim().Equals("") )
					{
						diff_item = txt_ItemCd.Text.Trim().ToUpper();
						current_item = grid_Item.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_CD].Text.Trim().ToUpper();
 
					}
					else if(! txt_ItemName.Text.Trim().Equals("") )
					{
						diff_item = txt_ItemName.Text.Trim().ToUpper();
						current_item = grid_Item.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_NAME1].Text.Trim().ToUpper();
					}

					
					if(diff_item == "" || current_item == "") break;

					if(diff_item == current_item)
					{
						grid_Item.ActiveSheet.ActiveRowIndex = i;

						//top row 기능
						grid_Item.Set_CellPosition(i, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_CD); 
						grid_Item.ActiveSheet.AddSelection(i, 0, 1, grid_Item.ActiveSheet.ColumnCount);


						Set_Return_Item(); 
						break;
					}


				}
				//------------------------------------------------------------------------------------------------------------------------
 			


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
		/// Select_Specification : Specification Master 조회
		/// </summary>
		private void Select_Specification()
		{
			try
			{


				DataTable dt_ret;

				this.Cursor = Cursors.WaitCursor; 

				string spec_div = ClassLib.ComFunction.Empty_Combo(cmb_SpecDiv, " ");
				string spec_cd = ClassLib.ComFunction.Empty_TextBox(txt_SpecCd, " ");
				string spec_name = ClassLib.ComFunction.Empty_TextBox(txt_SpecName, " ");
				string use_yn = (chk_UseYN_Spec.Checked) ? "Y" : " ";

				//dt_ret = Select_SBC_SPEC_COMMON(spec_div, spec_name, use_yn);
				dt_ret = Select_SBC_SPEC_CD_COMMON(spec_div, spec_cd, spec_name, use_yn);


				grid_Spec.Display_Grid(dt_ret);
				grid_Spec.Set_FontColor_Row((int)ClassLib.TBSBC_SPEC_COMMON.IxUSE_YN, "False", System.Drawing.Color.Red);
				grid_Spec.Set_FontColor_Row((int)ClassLib.TBSBC_SPEC_COMMON.IxUSE_YN, "True", System.Drawing.Color.Empty);
				
				dt_ret.Dispose();



				//------------------------------------------------------------------------------------------------------------------------
				// 정확하게 일치하는 항목으로 결과값 할당
				//------------------------------------------------------------------------------------------------------------------------
				string diff_item = "";
				string current_item = "";

				for(int i = 0; i < grid_Spec.ActiveSheet.RowCount; i++)
				{
				
					if(! txt_SpecName.Text.Trim().Equals("") )
					{
						diff_item = txt_SpecName.Text.Trim().ToUpper();
						current_item = grid_Spec.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_NAME].Text.Trim().ToUpper();
 
					} 

					if(diff_item == "" || current_item == "") break;

					if(diff_item == current_item)
					{
						grid_Spec.ActiveSheet.ActiveRowIndex = i;
						
						//top row 기능
						grid_Spec.Set_CellPosition(i, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_CD); 
						grid_Spec.ActiveSheet.AddSelection(i, 0, 1, grid_Spec.ActiveSheet.ColumnCount);

						Set_Return_Specification(); 
						break;

					}


				}
				//------------------------------------------------------------------------------------------------------------------------

 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_Specification", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

 

		/// <summary>
		/// Select_Color : Color Master 조회
		/// </summary>
		private void Select_Color()
		{
			try
			{
				DataTable dt_ret;

				this.Cursor = Cursors.WaitCursor; 

				string color_cd = ClassLib.ComFunction.Empty_TextBox(txt_ColorCd, " ");
				string color_name = ClassLib.ComFunction.Empty_TextBox(txt_ColorName, " ");
				string use_yn = (chk_UseYN_Color.Checked) ? "Y" : " ";

				dt_ret = Select_SBC_COLOR_COMMON(color_cd, color_name, use_yn);

				grid_Color.Display_Grid(dt_ret);
				grid_Color.Set_FontColor_Row((int)ClassLib.TBSBC_COLOR_COMMON.IxUSE_YN, "False", System.Drawing.Color.Red);
				grid_Color.Set_FontColor_Row((int)ClassLib.TBSBC_COLOR_COMMON.IxUSE_YN, "True", System.Drawing.Color.Empty);
				
				dt_ret.Dispose();


				//------------------------------------------------------------------------------------------------------------------------
				// 정확하게 일치하는 항목으로 결과값 할당
				//------------------------------------------------------------------------------------------------------------------------
				string diff_item = "";
				string current_item = "";

				for(int i = 0; i < grid_Color.ActiveSheet.RowCount; i++)
				{
				
					if(! txt_ColorCd.Text.Trim().Equals("") )
					{
						diff_item = txt_ColorCd.Text.Trim().ToUpper();
						current_item = grid_Color.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_CD].Text.Trim().ToUpper();
 
					}
					else if(! txt_ColorName.Text.Trim().Equals("") )
					{
						diff_item = txt_ColorName.Text.Trim().ToUpper();
						current_item = grid_Color.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_NAME].Text.Trim().ToUpper();
					}


					if(diff_item == "" || current_item == "") break;

					if(diff_item == current_item)
					{
						grid_Color.ActiveSheet.ActiveRowIndex = i;
						
						//top row 기능
						grid_Color.Set_CellPosition(i, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_CD);  
						grid_Color.ActiveSheet.AddSelection(i, 0, 1, grid_Color.ActiveSheet.ColumnCount);

						Set_Return_Color(); 
						break;

					}


				}
				//------------------------------------------------------------------------------------------------------------------------




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}



		/// <summary>
		/// Joint_Color : Color 조합
		/// </summary>
		private void Joint_Color()
		{
			try
			{ 
				string vresult = "";  
				 
				Pop_Color popup = new Pop_Color(false); 
				popup.ShowDialog();

				vresult = popup._ColorName;
				popup.Dispose(); 


				if(vresult.Trim().Equals("") ) return;

				txt_ColorName.Text = vresult; 
				Select_Color();
				
				 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Joint_Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		}



		/// <summary>
		/// Set_Return_Item : Item Select
		/// </summary>
		private void Set_Return_Item()
		{
			try
			{
				if(grid_Item.ActiveSheet.RowCount == 0) return;

				int sel_row = grid_Item.ActiveSheet.ActiveRowIndex;

				txt_Result_ItemCd.Text = grid_Item.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_CD].Text.ToString();
				txt_Result_ItemName.Text = grid_Item.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_ITEM_COMMON.IxITEM_NAME1].Text.ToString();
				txt_Result_ItemName.Tag = grid_Item.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_ITEM_COMMON.IxUSE_YN + 1].Text.ToString();

				txt_Result_Unit.Text = grid_Item.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_ITEM_COMMON.IxMNG_UNIT].Text.ToString();
				chk_Result_SizeYN.Checked = Convert.ToBoolean(grid_Item.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_ITEM_COMMON.IxSIZE_YN].Value.ToString() );

				if(chk_Result_SizeYN.Checked)
				{
					cmb_SpecDiv.SelectedValue = _Size_SpecDiv;  //_SpecCd.Substring(0, 1);
					//cmb_SpecDiv.Enabled = false;
				}
				else
				{
					cmb_SpecDiv.SelectedIndex = -1;
					grid_Spec.ClearAll();
					//cmb_SpecDiv.Enabled = true;
				}


//				if(_tabPage == "")
//				{
					obar_Main.SelectedPage = obarpg_Spec;
//				}

				// item에 대한 default specification 정보 조회
				Search_Default_Spec();



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_Return_Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		/// <summary>
		/// Set_Return_Specification : Specification Select
		/// </summary>
		private void Set_Return_Specification()
		{
			try
			{
				if(grid_Spec.ActiveSheet.RowCount == 0) return;

				int sel_row = grid_Spec.ActiveSheet.ActiveRowIndex;

				txt_Result_SepcCd.Text = grid_Spec.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_CD].Text.ToString();
				txt_Result_SepcName.Text = grid_Spec.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_NAME].Text.ToString(); 


//				if(_tabPage == "")
//				{
					obar_Main.SelectedPage = obarpg_Color;
//				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "grid_Spec_CellDoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		/// <summary>
		/// Set_Return_Color : Color Select
		/// </summary>
		private void Set_Return_Color()
		{
			try
			{
				if(grid_Color.ActiveSheet.RowCount == 0) return;
				
				int sel_row = grid_Color.ActiveSheet.ActiveRowIndex;

				txt_Result_ColorCd.Text = grid_Color.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_CD].Text.ToString();
				txt_Result_ColorName.Text = grid_Color.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_COLOR_COMMON.IxCOLOR_NAME].Text.ToString();  

				btn_Return.Focus();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "grid_Color_CellDoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		/// <summary>
		/// Return_Item_Data : Return Data
		/// </summary>
		private void Return_Item_Data()
		{
			try
			{
				if (_tabPage == "")
				{
					if(txt_Result_ItemCd.Text.Trim() == "")
					{
						ClassLib.ComFunction.User_Message("Select Item", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					if(! _SpecCd.Equals("")  && txt_Result_SepcCd.Text.Trim() == "")
					{
						ClassLib.ComFunction.User_Message("Select Sepcification", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					if(txt_Result_ColorCd.Text.Trim() == "")
					{
						ClassLib.ComFunction.User_Message("Select Color", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}
 

				this.Close();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Item_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		#endregion 

		#region 이벤트 처리


		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		
 

		#endregion  

 
		private void cmb_ItemType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_ItemType.SelectedIndex == -1) return;


				// Item Group First Class Combo List

				DataTable dt_ret;   
				
				dt_ret = ClassLib.ComFunction.Select_GroupLCode(cmb_ItemType.SelectedValue.ToString());    
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ItemGroup, 0, 1, true, 0, 130); 
				
				dt_ret.Dispose();



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_ItemType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		 
		/// <summary>
		/// Item Master 조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_search_item_Click(object sender, System.EventArgs e)
		{
			Select_Item();
		}
		

		/// <summary>
		/// Specification Master 조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_SearchSpec_Click(object sender, System.EventArgs e)
		{
			Select_Specification();
		}



		/// <summary>
		/// Color Master 조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_SearchColor_Click(object sender, System.EventArgs e)
		{
			Select_Color();
		}


		/// <summary>
		/// Color 코드 조합 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_JointColor_Click(object sender, System.EventArgs e)
		{
			Joint_Color();
		}



		/// <summary>
		/// Select Item
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void grid_Item_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			Set_Return_Item();
		}


		/// <summary>
		/// Select Specification
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void grid_Spec_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			Set_Return_Specification();
		}


		/// <summary>
		/// Select Color
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void grid_Color_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			Set_Return_Color();
		}

		


		/// <summary>
		/// return and close
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Return_Click(object sender, System.EventArgs e)
		{
			if(bi_incoming_item_change_mode)
			{
				COM.ComVar.Parameter_PopUp2 = new string[6];
				COM.ComVar.Parameter_PopUp2[0] = txt_Result_ItemCd.Text;
				COM.ComVar.Parameter_PopUp2[1] = txt_Result_ItemName.Text;

				COM.ComVar.Parameter_PopUp2[2] = txt_Result_SepcCd.Text;
				COM.ComVar.Parameter_PopUp2[3] = txt_Result_SepcName.Text;

				COM.ComVar.Parameter_PopUp2[4] = txt_Result_ColorCd.Text;
				COM.ComVar.Parameter_PopUp2[5] = txt_Result_ColorName.Text;


				this.Close();
			}
			else
			{
				_CancelFlag = false;
				Return_Item_Data();
			}
		}


		/// <summary>
		/// close
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_CancelFlag = true;
			this.Close();		
		}



		private void Pop_Item_List_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{

			try
			{
			
				
				if(_CancelFlag)
				{
					COM.ComVar.Parameter_PopUp = new string[] 
                    { 
						_ItemCd, 
						_ItemName,
					    _SpecCd,
						_SpecName,
						_ColorCd,
						_ColorName,
						_Unit,
						(_SizeYN == "Y") ? "True" : "False" 
					};
				}
				else
				{
					COM.ComVar.Parameter_PopUp = new string[]
					{
						txt_Result_ItemCd.Text,
						txt_Result_ItemName.Text,
						txt_Result_SepcCd.Text,
						txt_Result_SepcName.Text,
						txt_Result_ColorCd.Text,
						txt_Result_ColorName.Text,
						txt_Result_Unit.Text,
						(chk_Result_SizeYN.Checked) ? "True" : "False",
						(txt_Result_ItemName.Tag == null) ? "0" : txt_Result_ItemName.Tag.ToString()
					};


					if(_tabPage.Equals("") )
					{

						// SBC_SPEC_MASTER SAVE
						bool save_flag = Save_SBC_SPEC_MASTER(txt_Result_ItemCd.Text, txt_Result_SepcCd.Text, "I");

						if(!save_flag)
						{
							ClassLib.ComFunction.Data_Message("Save Specification Master", ClassLib.ComVar.MgsDoNotSave, this);
						}
					}




				} // end if

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Pop_Item_List_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void txt_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;
 

				if(obar_Main.SelectedPage.Equals(obarpg_Item) )
				{ 
					Select_Item(); 
				}
				else if(obar_Main.SelectedPage.Equals(obarpg_Spec) )
				{ 
					Select_Specification();
				}
				else if(obar_Main.SelectedPage.Equals(obarpg_Color) )
				{
					
					Select_Color();
				}



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}




		private void btn_AddNewItem_Click(object sender, System.EventArgs e)
		{
			try
			{


				if(obar_Main.SelectedPage.Equals(obarpg_Item) )
				{ 
					Add_New_Item(); 
				}
				else if(obar_Main.SelectedPage.Equals(obarpg_Spec) )
				{ 
					Add_New_Specification();
				}
				else if(obar_Main.SelectedPage.Equals(obarpg_Color) )
				{
					
					Add_New_Color();
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_AddNewItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		


		/// <summary>
		/// Add_New_Item : 
		/// </summary>
		private void Add_New_Item()
		{

			ClassLib.ComVar.Parameter_PopUp  = new string[4];
			ClassLib.ComVar.Parameter_PopUp[0] = "I";
			ClassLib.ComVar.Parameter_PopUp[1] = "";  // item_cd
			ClassLib.ComVar.Parameter_PopUp[2] = ClassLib.ComFunction.Empty_Combo(cmb_ItemType, "");
			ClassLib.ComVar.Parameter_PopUp[3] = "";  // group_l


            FlexBase.MaterialBase.Pop_Item_Show pop_form = new Pop_Item_Show(true);
			pop_form.ShowDialog();

			if(!pop_form._Close_Save) return;


			txt_ItemCd.Text = ClassLib.ComVar.Parameter_PopUp[0];
			txt_ItemName.Text = ClassLib.ComVar.Parameter_PopUp[1];

			txt_Result_ItemCd.Text = ClassLib.ComVar.Parameter_PopUp[0];
			txt_Result_ItemName.Text = ClassLib.ComVar.Parameter_PopUp[1]; 
			chk_Result_SizeYN.Checked = (ClassLib.ComVar.Parameter_PopUp[2] == "Y") ? true : false;
			txt_Result_Unit.Text = ClassLib.ComVar.Parameter_PopUp[3]; 
 

		}

		

		/// <summary>
		/// Add_New_Specification : 
		/// </summary>
		private void Add_New_Specification()
		{


			ClassLib.ComVar.Parameter_PopUp = null;

			FlexBase.MaterialBase.Form_BC_Spec pop_form = new Form_BC_Spec(true);
			pop_form.ShowDialog();

			if(ClassLib.ComVar.Parameter_PopUp == null) return;

			cmb_SpecDiv.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0].Substring(0, 1);
			txt_SpecName.Text = ClassLib.ComVar.Parameter_PopUp[1];

			txt_Result_SepcCd.Text = ClassLib.ComVar.Parameter_PopUp[0];
			txt_Result_SepcName.Text = ClassLib.ComVar.Parameter_PopUp[1]; 

		}



		/// <summary>
		/// Add_New_Color : 
		/// </summary>
		private void Add_New_Color()
		{

			ClassLib.ComVar.Parameter_PopUp = null;

			FlexBase.MaterialBase.Form_BC_Color pop_form = new Form_BC_Color(true);
			pop_form.ShowDialog();

			if(ClassLib.ComVar.Parameter_PopUp == null) return;

			txt_ColorCd.Text = ClassLib.ComVar.Parameter_PopUp[0];
			txt_ColorName.Text = ClassLib.ComVar.Parameter_PopUp[1];

			txt_Result_ColorCd.Text = ClassLib.ComVar.Parameter_PopUp[0];
			txt_Result_ColorName.Text = ClassLib.ComVar.Parameter_PopUp[1];


		}


		private void menuItem_UseSpecDel_Click(object sender, System.EventArgs e)
		{
		

			try
			{

				if(grid_Spec.ActiveSheet.RowCount == 0) return;

				// SBC_SPEC_MASTER SAVE
				string spec_cd = grid_Spec.ActiveSheet.Cells[grid_Spec.ActiveSheet.ActiveRowIndex, (int)ClassLib.TBSBC_SPEC_COMMON.IxSPEC_CD].Text;

				bool save_flag = Save_SBC_SPEC_MASTER(txt_Result_ItemCd.Text, spec_cd, "D");

				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message("Delete Specification Master", ClassLib.ComVar.MgsDoNotDelete, this);
				}
				else
				{
					grid_Spec.ActiveSheet.RemoveRows(grid_Spec.ActiveSheet.ActiveRowIndex, 1);
					ClassLib.ComFunction.Data_Message("Delete Specification Master", ClassLib.ComVar.MgsEndDelete, this); 
					

				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_UseSpecDel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		#endregion

		#region DB Connect
 


		/// <summary>
		/// Select_SBC_SPEC_MASTER : item에 대한 default specification 정보 조회 
		/// </summary>
		/// <param name="arg_itemcd"></param>
		/// <returns></returns>
		private DataTable Select_SBC_SPEC_MASTER(string arg_itemcd)
		{
			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(2); 

			MyOraDB.Process_Name = "PKG_SBC_SPEC.SELECT_SBC_SPEC_MASTER";

			MyOraDB.Parameter_Name[0] = "ARG_ITEM_CD"; 
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_itemcd;  
			MyOraDB.Parameter_Values[1] = "";  

			MyOraDB.Add_Select_Parameter(true);

			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name];

		}



		/// <summary>
		/// Select_SBC_ITEM_COMMON : Item LIST Combo
		/// </summary>
		/// <param name="arg_itemcd"></param>
		/// <param name="arg_groupcd"></param>
		/// <param name="arg_itemname1"></param>
		/// <param name="arg_useyn"></param>
		/// <returns></returns>
		public static DataTable Select_SBC_ITEM_COMMON(string arg_itemcd, string arg_groupcd, string arg_itemname1, string arg_useyn)
		{

			COM.OraDB OraDB = new COM.OraDB();

			DataSet ds_ret;
 
			OraDB.ReDim_Parameter(5); 

			OraDB.Process_Name = "PKG_SBC_ITEM.SELECT_SBC_ITEM_COMMON";

			OraDB.Parameter_Name[0] = "ARG_ITEM_CD";
			OraDB.Parameter_Name[1] = "ARG_GROUP_CD";
			OraDB.Parameter_Name[2] = "ARG_ITEM_NAME1";
			OraDB.Parameter_Name[3] = "ARG_USE_YN";
			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = arg_itemcd; 
			OraDB.Parameter_Values[1] = arg_groupcd; 
			OraDB.Parameter_Values[2] = arg_itemname1; 
			OraDB.Parameter_Values[3] = arg_useyn; 
			OraDB.Parameter_Values[4] = ""; 


			OraDB.Add_Select_Parameter(true);

			ds_ret = OraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[OraDB.Process_Name];
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


		/// <summary>
		/// Select_SBC_SPEC_COMMON : Sepcification LIST Combo
		/// </summary>
		/// <param name="arg_specdiv"></param>
		/// <param name="arg_specname"></param>
		/// <param name="arg_useyn"></param>
		/// <returns></returns>
		public static DataTable Select_SBC_SPEC_CD_COMMON(string arg_specdiv, string arg_speccd, string arg_specname, string arg_useyn)
		{
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(5); 

			MyOraDB.Process_Name = "PKG_SBC_SPEC.SELECT_SBC_SPEC_CD_COMMON"; 

			MyOraDB.Parameter_Name[0] = "ARG_SPEC_DIV";
			MyOraDB.Parameter_Name[1] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SPEC_NAME"; 
			MyOraDB.Parameter_Name[3] = "ARG_USE_YN";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_specdiv; 
			MyOraDB.Parameter_Values[1] = arg_speccd;  
			MyOraDB.Parameter_Values[2] = arg_specname;  
			MyOraDB.Parameter_Values[3] = arg_useyn; 
			MyOraDB.Parameter_Values[4] = ""; 


			MyOraDB.Add_Select_Parameter(true);

			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name];
		}

		

		/// <summary>
		/// Select_SBC_COLOR_COMMON : Color LIST Combo
		/// </summary>
		/// <param name="arg_colorcd"></param>
		/// <param name="arg_colorname"></param>
		/// <param name="arg_useyn"></param>
		/// <returns></returns>
		public static DataTable Select_SBC_COLOR_COMMON(string arg_colorcd, string arg_colorname, string arg_useyn)
		{
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(4); 

			MyOraDB.Process_Name = "PKG_SBC_COLOR.SELECT_SBC_COLOR_COMMON"; 

			MyOraDB.Parameter_Name[0] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[1] = "ARG_COLOR_NAME"; 
			MyOraDB.Parameter_Name[2] = "ARG_USE_YN";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_colorcd; 
			MyOraDB.Parameter_Values[1] = arg_colorname;  
			MyOraDB.Parameter_Values[2] = arg_useyn; 
			MyOraDB.Parameter_Values[3] = ""; 


			MyOraDB.Add_Select_Parameter(true);

			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// SBC_SPEC_MASTER SAVE : 
		/// </summary>
		/// <param name="arg_itemcd"></param>
		/// <param name="arg_speccd"></param>
		/// <param name="arg_division"></param>
		/// <returns></returns> 
		private bool Save_SBC_SPEC_MASTER(string arg_itemcd, string arg_speccd, string arg_division)
		{ 

			try
			{
				DataSet ds_ret;
 
				int col_ct = 8;

				MyOraDB.ReDim_Parameter(col_ct); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBC_SPEC.SAVE_SBC_SPEC_MASTER";
 
				//02.ARGURMENT명
				MyOraDB.Parameter_Name[0]  = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[1]  = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[2]  = "ARG_MCS_NO";
				MyOraDB.Parameter_Name[3]  = "ARG_LAST_DATE";
				MyOraDB.Parameter_Name[4]  = "ARG_REMARKS";
				MyOraDB.Parameter_Name[5]  = "ARG_SEND_CHK";
				MyOraDB.Parameter_Name[6]  = "ARG_SEND_YMD";
				MyOraDB.Parameter_Name[7]  = "ARG_UPD_USER";
 
				//03.DATA TYPE
				for (int i = 0; i < col_ct; i++) MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
			
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0]  = arg_itemcd; 
				MyOraDB.Parameter_Values[1]  = arg_speccd;
				MyOraDB.Parameter_Values[2]  = ""; 
				MyOraDB.Parameter_Values[3]  = ""; 
				MyOraDB.Parameter_Values[4]  = ""; 
				MyOraDB.Parameter_Values[5]  = arg_division; // delete, insert division
				MyOraDB.Parameter_Values[6]  = "";  
				MyOraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Modify_Procedure();		
			 
				if(ds_ret == null) 
				{
					ds_ret.Dispose();
					return false;
				}
				else
				{
					return true;
				}

			}
			catch 
			{ 
				return false;
			} 

		}




		#endregion 

		private void Pop_Item_List_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
 
		

	}
}

