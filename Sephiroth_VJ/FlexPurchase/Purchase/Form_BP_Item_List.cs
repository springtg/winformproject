using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FarPoint.Win.Spread.Model;

namespace FlexPurchase.Purchase
{
	public class Form_BP_Item_List : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 변수

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.Label lbl_head;
		private System.Windows.Forms.Panel pnl_low;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Label lbl_order;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_value;
		private System.Windows.Forms.MenuItem mnu_cbd;

		private COM.SSP spd_main;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private C1.Win.C1List.C1Combo cmb_item_division;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private C1.Win.C1List.C1Combo cmb_factory;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		
		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FlexBase.MaterialBase.Pop_Item_List_Show _itemPop = null;


		private Hashtable _cellTypes = null;
		private const int Validate_Context = 100;
		private System.Windows.Forms.Panel pnl_Search;
		private string _itemGroupCode = " ";

		#endregion

		#region 생성자 / 소멸자

		public Form_BP_Item_List()
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

		#endregion

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BP_Item_List));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.spd_main = new COM.SSP();
			this.ctx_main = new System.Windows.Forms.ContextMenu();
			this.mnu_value = new System.Windows.Forms.MenuItem();
			this.mnu_cbd = new System.Windows.Forms.MenuItem();
			this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
			this.pnl_low = new System.Windows.Forms.Panel();
			this.btn_delete = new System.Windows.Forms.Label();
			this.btn_recover = new System.Windows.Forms.Label();
			this.btn_Insert = new System.Windows.Forms.Label();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.txt_itemGroup = new System.Windows.Forms.TextBox();
			this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
			this.txt_itemName = new System.Windows.Forms.TextBox();
			this.txt_itemCode = new System.Windows.Forms.TextBox();
			this.lbl_itemgroup = new System.Windows.Forms.Label();
			this.btn_groupSearch = new System.Windows.Forms.Label();
			this.lbl_item = new System.Windows.Forms.Label();
			this.cmb_item_division = new C1.Win.C1List.C1Combo();
			this.lbl_order = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_head = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
			this.pnl_low.SuspendLayout();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_item_division)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Menu
			// 
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Name = "c1ToolBar1";
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
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.Controls.Add(this.spd_main);
			this.c1Sizer1.Controls.Add(this.pnl_low);
			this.c1Sizer1.Controls.Add(this.pnl_Search);
			this.c1Sizer1.GridDefinition = "15.625:False:True;76.9097222222222:False:False;4.6875:False:False;\t0.393700787401" +
				"575:False:True;97.6377952755905:False:False;0.393700787401575:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// spd_main
			// 
			this.spd_main.ContextMenu = this.ctx_main;
			this.spd_main.Location = new System.Drawing.Point(12, 98);
			this.spd_main.Name = "spd_main";
			this.spd_main.Sheets.Add(this.spd_main_Sheet1);
			this.spd_main.Size = new System.Drawing.Size(992, 443);
			this.spd_main.TabIndex = 170;
			this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
			this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
			this.spd_main.EditModeOff += new System.EventHandler(this.spd_main_EditModeOff);
			// 
			// ctx_main
			// 
			this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnu_value,
																					 this.mnu_cbd});
			// 
			// mnu_value
			// 
			this.mnu_value.Index = 0;
			this.mnu_value.Text = "Value Change";
			this.mnu_value.Click += new System.EventHandler(this.mnu_value_Click);
			// 
			// mnu_cbd
			// 
			this.mnu_cbd.Index = 1;
			this.mnu_cbd.Text = "CBD Information";
			this.mnu_cbd.Click += new System.EventHandler(this.mnu_cbd_Click);
			// 
			// spd_main_Sheet1
			// 
			this.spd_main_Sheet1.SheetName = "Sheet1";
			// 
			// pnl_low
			// 
			this.pnl_low.BackColor = System.Drawing.Color.Transparent;
			this.pnl_low.Controls.Add(this.btn_delete);
			this.pnl_low.Controls.Add(this.btn_recover);
			this.pnl_low.Controls.Add(this.btn_Insert);
			this.pnl_low.Location = new System.Drawing.Point(12, 545);
			this.pnl_low.Name = "pnl_low";
			this.pnl_low.Size = new System.Drawing.Size(992, 27);
			this.pnl_low.TabIndex = 169;
			// 
			// btn_delete
			// 
			this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_delete.ImageIndex = 5;
			this.btn_delete.ImageList = this.image_List;
			this.btn_delete.Location = new System.Drawing.Point(830, 2);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 24);
			this.btn_delete.TabIndex = 363;
			this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			this.btn_delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseUp);
			this.btn_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseDown);
			// 
			// btn_recover
			// 
			this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_recover.ImageIndex = 1;
			this.btn_recover.ImageList = this.image_List;
			this.btn_recover.Location = new System.Drawing.Point(912, 2);
			this.btn_recover.Name = "btn_recover";
			this.btn_recover.Size = new System.Drawing.Size(80, 24);
			this.btn_recover.TabIndex = 353;
			this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
			this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
			this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
			// 
			// btn_Insert
			// 
			this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Insert.ImageIndex = 9;
			this.btn_Insert.ImageList = this.image_List;
			this.btn_Insert.Location = new System.Drawing.Point(748, 2);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(80, 24);
			this.btn_Insert.TabIndex = 352;
			this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
			this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseUp);
			this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseDown);
			// 
			// pnl_Search
			// 
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.txt_itemGroup);
			this.pnl_Search.Controls.Add(this.cmb_itemGroup);
			this.pnl_Search.Controls.Add(this.txt_itemName);
			this.pnl_Search.Controls.Add(this.txt_itemCode);
			this.pnl_Search.Controls.Add(this.lbl_itemgroup);
			this.pnl_Search.Controls.Add(this.btn_groupSearch);
			this.pnl_Search.Controls.Add(this.lbl_item);
			this.pnl_Search.Controls.Add(this.cmb_item_division);
			this.pnl_Search.Controls.Add(this.lbl_order);
			this.pnl_Search.Controls.Add(this.cmb_factory);
			this.pnl_Search.Controls.Add(this.lbl_factory);
			this.pnl_Search.Controls.Add(this.pictureBox1);
			this.pnl_Search.Controls.Add(this.pictureBox2);
			this.pnl_Search.Controls.Add(this.pictureBox3);
			this.pnl_Search.Controls.Add(this.lbl_head);
			this.pnl_Search.Controls.Add(this.pictureBox4);
			this.pnl_Search.Controls.Add(this.pictureBox5);
			this.pnl_Search.Controls.Add(this.pictureBox6);
			this.pnl_Search.Controls.Add(this.pictureBox7);
			this.pnl_Search.Controls.Add(this.pictureBox8);
			this.pnl_Search.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_Search.Location = new System.Drawing.Point(12, 4);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(992, 90);
			this.pnl_Search.TabIndex = 167;
			// 
			// txt_itemGroup
			// 
			this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_itemGroup.Location = new System.Drawing.Point(532, 40);
			this.txt_itemGroup.MaxLength = 10;
			this.txt_itemGroup.Name = "txt_itemGroup";
			this.txt_itemGroup.ReadOnly = true;
			this.txt_itemGroup.Size = new System.Drawing.Size(96, 21);
			this.txt_itemGroup.TabIndex = 554;
			this.txt_itemGroup.Text = "";
			// 
			// cmb_itemGroup
			// 
			this.cmb_itemGroup.AddItemCols = 0;
			this.cmb_itemGroup.AddItemSeparator = ';';
			this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_itemGroup.AutoSize = false;
			this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_itemGroup.Caption = "";
			this.cmb_itemGroup.CaptionHeight = 17;
			this.cmb_itemGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_itemGroup.ColumnCaptionHeight = 18;
			this.cmb_itemGroup.ColumnFooterHeight = 18;
			this.cmb_itemGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_itemGroup.ContentHeight = 17;
			this.cmb_itemGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_itemGroup.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_itemGroup.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_itemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_itemGroup.EditorHeight = 17;
			this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_itemGroup.GapHeight = 2;
			this.cmb_itemGroup.ItemHeight = 15;
			this.cmb_itemGroup.Location = new System.Drawing.Point(441, 40);
			this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
			this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
			this.cmb_itemGroup.MaxLength = 32767;
			this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_itemGroup.Name = "cmb_itemGroup";
			this.cmb_itemGroup.PartialRightColumn = false;
			this.cmb_itemGroup.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_itemGroup.Size = new System.Drawing.Size(90, 21);
			this.cmb_itemGroup.TabIndex = 553;
			this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
			// 
			// txt_itemName
			// 
			this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_itemName.Location = new System.Drawing.Point(501, 62);
			this.txt_itemName.MaxLength = 10;
			this.txt_itemName.Name = "txt_itemName";
			this.txt_itemName.Size = new System.Drawing.Size(150, 21);
			this.txt_itemName.TabIndex = 555;
			this.txt_itemName.Text = "";
			// 
			// txt_itemCode
			// 
			this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_itemCode.Location = new System.Drawing.Point(441, 62);
			this.txt_itemCode.MaxLength = 10;
			this.txt_itemCode.Name = "txt_itemCode";
			this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
			this.txt_itemCode.TabIndex = 551;
			this.txt_itemCode.Text = "";
			// 
			// lbl_itemgroup
			// 
			this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_itemgroup.ImageIndex = 0;
			this.lbl_itemgroup.ImageList = this.img_Label;
			this.lbl_itemgroup.Location = new System.Drawing.Point(340, 40);
			this.lbl_itemgroup.Name = "lbl_itemgroup";
			this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
			this.lbl_itemgroup.TabIndex = 549;
			this.lbl_itemgroup.Text = "Item Group";
			this.lbl_itemgroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_groupSearch
			// 
			this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
			this.btn_groupSearch.Enabled = false;
			this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_groupSearch.ImageIndex = 27;
			this.btn_groupSearch.ImageList = this.img_SmallButton;
			this.btn_groupSearch.Location = new System.Drawing.Point(629, 40);
			this.btn_groupSearch.Name = "btn_groupSearch";
			this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
			this.btn_groupSearch.TabIndex = 552;
			this.btn_groupSearch.Tag = "Search";
			this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
			// 
			// lbl_item
			// 
			this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_item.ImageIndex = 0;
			this.lbl_item.ImageList = this.img_Label;
			this.lbl_item.Location = new System.Drawing.Point(340, 62);
			this.lbl_item.Name = "lbl_item";
			this.lbl_item.Size = new System.Drawing.Size(100, 21);
			this.lbl_item.TabIndex = 550;
			this.lbl_item.Text = "Item";
			this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_item_division
			// 
			this.cmb_item_division.AddItemCols = 0;
			this.cmb_item_division.AddItemSeparator = ';';
			this.cmb_item_division.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_item_division.AutoSize = false;
			this.cmb_item_division.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_item_division.Caption = "";
			this.cmb_item_division.CaptionHeight = 17;
			this.cmb_item_division.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_item_division.ColumnCaptionHeight = 18;
			this.cmb_item_division.ColumnFooterHeight = 18;
			this.cmb_item_division.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_item_division.ContentHeight = 17;
			this.cmb_item_division.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_item_division.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_item_division.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_item_division.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_item_division.EditorHeight = 17;
			this.cmb_item_division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_item_division.GapHeight = 2;
			this.cmb_item_division.ItemHeight = 15;
			this.cmb_item_division.Location = new System.Drawing.Point(109, 62);
			this.cmb_item_division.MatchEntryTimeout = ((long)(2000));
			this.cmb_item_division.MaxDropDownItems = ((short)(5));
			this.cmb_item_division.MaxLength = 32767;
			this.cmb_item_division.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_item_division.Name = "cmb_item_division";
			this.cmb_item_division.PartialRightColumn = false;
			this.cmb_item_division.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_item_division.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_item_division.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_item_division.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_item_division.Size = new System.Drawing.Size(210, 21);
			this.cmb_item_division.TabIndex = 1;
			// 
			// lbl_order
			// 
			this.lbl_order.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_order.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_order.ImageIndex = 1;
			this.lbl_order.ImageList = this.img_Label;
			this.lbl_order.Location = new System.Drawing.Point(8, 62);
			this.lbl_order.Name = "lbl_order";
			this.lbl_order.Size = new System.Drawing.Size(100, 21);
			this.lbl_order.TabIndex = 180;
			this.lbl_order.Text = "Item Division";
			this.lbl_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_factory.AutoSize = false;
			this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_factory.Caption = "";
			this.cmb_factory.CaptionHeight = 17;
			this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_factory.ColumnCaptionHeight = 18;
			this.cmb_factory.ColumnFooterHeight = 18;
			this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_factory.ContentHeight = 17;
			this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(109, 40);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_factory.TabIndex = 1;
			this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 1;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 180;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(891, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(101, 52);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(976, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(224, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(944, 32);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_head
			// 
			this.lbl_head.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_head.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_head.ForeColor = System.Drawing.Color.Navy;
			this.lbl_head.Image = ((System.Drawing.Image)(resources.GetObject("lbl_head.Image")));
			this.lbl_head.Location = new System.Drawing.Point(0, 0);
			this.lbl_head.Name = "lbl_head";
			this.lbl_head.Size = new System.Drawing.Size(231, 30);
			this.lbl_head.TabIndex = 28;
			this.lbl_head.Text = "      Search Information.";
			this.lbl_head.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(976, 75);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 16);
			this.pictureBox4.TabIndex = 23;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(144, 74);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(944, 18);
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 75);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(168, 20);
			this.pictureBox6.TabIndex = 22;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(168, 57);
			this.pictureBox7.TabIndex = 25;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(160, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(944, 50);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// Form_BP_Item_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_BP_Item_List";
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
			this.pnl_low.ResumeLayout(false);
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_item_division)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
			try
			{
				this.Grid_EditModeOnProcess(spd_main);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "grid :: edit mode on", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void spd_main_EditModeOff(object sender, System.EventArgs e)
		{
			try
			{
				spd_main.Update_Row(img_Action);
				this.copyItemDiv();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "grid :: edit mode off", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			try
			{
				switch (e.Column)
				{
					case (int)ClassLib.TBSBP_ITEM_LIST.IxCUST_CD:
						this.setVendor();
						break;
					case (int)ClassLib.TBSBP_ITEM_LIST.IxCUST_NAME:
						this.setVendor();
						break;
					case (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_NAME:
						this.insertItem(false);
						break;
					case (int)ClassLib.TBSBP_ITEM_LIST.IxSPEC_NAME:
						this.insertItem(false);
						break;
					case (int)ClassLib.TBSBP_ITEM_LIST.IxCOLOR_NAME:
						this.insertItem(false);
						break;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "grid :: cell double click", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.clearForm();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "main button :: new", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{

			}
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
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

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (checkDuplicate())
				{
					this.saveData();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "main button :: save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "main button :: print", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{

			}
		}
	
		#endregion
	
		#region 컨트롤 이벤트 처리

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

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

		private void mnu_value_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (Etc_ProvisoValidateCheck(Validate_Context))
					valueChange();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "mnu_value_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void mnu_cbd_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (Etc_ProvisoValidateCheck(Validate_Context))
					getCBDData();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "mnu_cbd_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}

		#region 버튼 이벤트 - Insert, Delete, Cancel

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.insertItem(true);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "sub button :: insert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{

			}
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.deleteItem();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "main button :: delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{

			}
		}

		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.recorverGrid();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "main button :: recover", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{

			}
		}

		#endregion
		
		#region 버튼효과

		private void btn_insert_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 8;
		}

		private void btn_insert_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 9;
		}

		private void btn_delete_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 4;
		}

		private void btn_delete_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 5;
		}

		private void btn_cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		private void btn_cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}


		#endregion

		#endregion

		#region 이벤트 처리 메소드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
			lbl_MainTitle.Text = "Local/LLT Item List";
            this.Text = "Local/LLT Item List";

            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBP_ITEM_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			_mainSheet	= spd_main.ActiveSheet;
			this.Init_Combo();
			this.Init_GridHeader();
			this.init_GridDesign();

			tbtn_Delete.Enabled = false;
			tbtn_Print.Enabled = false;
			tbtn_Confirm.Enabled = false;
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
			COM.ComCtl.Set_ComboList(vDt, cmb_item_division, 1, 2, true);
			cmb_item_division.SelectedIndex = 0;
			vDt.Dispose();

			vDt = ClassLib.ComFunction.Select_GroupTypeCode();  
			ClassLib.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, false,  0, 130);  
			vDt.Dispose();

		}

		/// <summary>
		/// 그리드 헤더 초기화
		/// </summary>
		private void Init_GridHeader()
		{
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

		private void init_GridDesign()
		{
			spd_main.ActiveSheet.Columns[(int)ClassLib.TBSBP_ITEM_LIST.IxCUST_CD].ForeColor = Color.Blue;
			spd_main.ActiveSheet.Columns[(int)ClassLib.TBSBP_ITEM_LIST.IxCUST_NAME].ForeColor = Color.Blue;
		}

		#endregion
		
		#region 툴바 메뉴 이벤트

		private void clearForm()
		{
			cmb_factory.SelectedValue = COM.ComVar.This_Factory;
			cmb_item_division.SelectedIndex = 0;
			spd_main.ClearAll();
		}
		
		private void searchData()
		{
			spd_main.Display_Grid(SELECT_SBP_ORDER());
			setGridDesign();
		}

		private bool checkDuplicate()
		{
			// selection clear
			spd_main.Focus();

			int factoryCol	 = (int)ClassLib.TBSBP_ITEM_LIST.IxFACTORY;
			int itemDivCol	 = (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_DIV_CD;
			int itemCdCol	 = (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_CD;
			int specCdCol	 = (int)ClassLib.TBSBP_ITEM_LIST.IxSPEC_CD;
			int colorCdCol	 = (int)ClassLib.TBSBP_ITEM_LIST.IxCOLOR_CD;

			for (int row = 0 ; row < spd_main.ActiveSheet.RowCount ; row++)
			{
				if (ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[row, 0].Tag, "").Equals("I"))
				{
					string factory	 = spd_main.ActiveSheet.Cells[row, factoryCol].Text;
					string itemDiv	 = spd_main.ActiveSheet.Cells[row, itemDivCol].Text;
					string itemCd	 = spd_main.ActiveSheet.Cells[row, itemCdCol].Text;
					string specCd	 = spd_main.ActiveSheet.Cells[row, specCdCol].Text;
					string colorCd	 = spd_main.ActiveSheet.Cells[row, colorCdCol].Text;

					// Grid Check
					for (int row2 = 0 ; row2 < spd_main.ActiveSheet.RowCount ; row2++)
					{
						if (row2 == row) continue;

						if (spd_main.ActiveSheet.Cells[row2, factoryCol].Text.Equals(factory) &&
							spd_main.ActiveSheet.Cells[row2, itemDivCol].Text.Equals(itemDiv) && 
							spd_main.ActiveSheet.Cells[row2, itemCdCol].Text.Equals(itemCd) && 
							spd_main.ActiveSheet.Cells[row2, specCdCol].Text.Equals(specCd) && 
							spd_main.ActiveSheet.Cells[row2, colorCdCol].Text.Equals(colorCd))
						{
							spd_main.ActiveSheet.ClearSelection();
							spd_main.ActiveSheet.AddSelection(row, 0, 1, spd_main.ActiveSheet.ColumnCount);
						
							ClassLib.ComFunction.User_Message("Exist duplicate material!!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return false;
						}
					}

					// DB Check
					if (this.CHECK_ITEM_DUPLICATE(row) != -1)
					{
						spd_main.ActiveSheet.ClearSelection();
						spd_main.ActiveSheet.AddSelection(row, 0, 1, spd_main.ActiveSheet.ColumnCount);
						
						ClassLib.ComFunction.User_Message("Exist duplicate material!!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
				}
			}

			return true;
		}

		private void saveData()
		{
			if (ClassLib.ComFunction.User_Message("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (MyOraDB.Save_Spread("PKG_SBP_ITEM_LIST.SAVE_SBP_ITEM_LIST", spd_main))
				{
					spd_main.Refresh_Division();
					setGridDesign();
					ClassLib.ComFunction.User_Message("Save Complate!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void printData()
		{

		}

		private void setGridDesign()
		{
			for (int i = 0 ; i < spd_main.ActiveSheet.RowCount ; i++)
			{
				spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_DIV_VALUE].Locked = true;
			}
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

		private void copyItemDiv()
		{
			int vRow = spd_main.Sheets[0].ActiveRowIndex ;
			int vCol = spd_main.Sheets[0].ActiveColumnIndex ;

			if (vCol == (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_DIV_VALUE)
			{
				string itemDiv = ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[vRow, vCol].Value, "");
				spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_DIV_CD].Text = itemDiv;
			}
		}

		private void setVendor()
		{
			COM.ComVar.Parameter_PopUp = new string[] {"Vendor"};
			FlexPurchase.Shipping.Pop_BS_Shipping_List_Changer pop_changer = new FlexPurchase.Shipping.Pop_BS_Shipping_List_Changer();
			pop_changer.ShowDialog();

			if (COM.ComVar.Parameter_PopUp != null)
			{
				string cust_cd = ClassLib.ComVar.Parameter_PopUp[1];
				string cust_nm = ClassLib.ComVar.Parameter_PopUp[0];

				foreach(CellRange range in spd_main.ActiveSheet.GetSelections())
				{
					for (int i = range.Row ; i < range.Row + range.RowCount ; i++)
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_ITEM_LIST.IxCUST_CD].Text = cust_cd;
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_ITEM_LIST.IxCUST_NAME].Text = cust_nm;
						spd_main.Update_Row(i, img_Action);
					}
				}
			}
		}

		private void valueChange()//FarPoint.Win.Spread.CellClickEventArgs e)
		{
			try
			{ 
				int vRow = spd_main.Sheets[0].ActiveRowIndex;
				int vCol = spd_main.Sheets[0].ActiveColumnIndex;

				CellRange[] vSelectionRange = _mainSheet.GetSelections(); 

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp = new string[]{_mainSheet.ColumnHeader.Cells[1,vCol].Text};

					if (_cellTypes.ContainsKey(vCol))
					{
						ClassLib.ComVar.Parameter_PopUp_Object = new object[]{_cellTypes[vCol]};
					}

					FlexPurchase.Shipping.Pop_BS_Shipping_List_Changer pop_changer = new FlexPurchase.Shipping.Pop_BS_Shipping_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						for (int i = 0 ; i < vSelectionRange.Length; i++)
						{
							int start_row = vSelectionRange[i].Row;
							int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

							for (int j = start_row ; j < end_row; j++)
							{
								if (COM.ComVar.Parameter_PopUp.Length > 1)
								{
									_mainSheet.Cells[j, (int)ClassLib.TBSBP_ITEM_LIST.IxCUST_NAME].Value = COM.ComVar.Parameter_PopUp[0];
									_mainSheet.Cells[j, (int)ClassLib.TBSBP_ITEM_LIST.IxCUST_CD].Value = COM.ComVar.Parameter_PopUp[1];
								}
								else
								{
									_mainSheet.Cells[j, vCol].Value = COM.ComVar.Parameter_PopUp[0];
								}

								spd_main.Update_Row(j, img_Action);
							}
						}

					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "valueChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void getCBDData()
		{
			try
			{
				/*****************************************
				0 : FACTORY,	  		1 : PUR_USER,
				2 : CUST_CD,			3 : CUST_NAME,
				4 :	PK_UNIT_QTY,		5 : PUR_PRICE,
				6 :	PUR_CURRENCY, 		7 : OUTSIDE_PRICE,
				8 :	OUTSIDE_CURRENCY, 	9 : CBD_PRICE,
				10 : CBD_CURRENCY,		11 : SHIP_PRICE,
				12 : SHIP_CURRENCY, 	13 : CBM,
				14 : WEIGHT
				*****************************************/
				int[] keys = new int[]{ (int)ClassLib.TBSBP_ITEM_LIST.IxFACTORY,
										-1, 
										-1,
										(int)ClassLib.TBSBP_ITEM_LIST.IxITEM_CD,
										(int)ClassLib.TBSBP_ITEM_LIST.IxSPEC_CD,
										(int)ClassLib.TBSBP_ITEM_LIST.IxCOLOR_CD };

				int[] values = new int[]{ 
											-1,												-1,
											(int)ClassLib.TBSBP_ITEM_LIST.IxCUST_CD,		(int)ClassLib.TBSBP_ITEM_LIST.IxCUST_NAME,
											-1,
											(int)ClassLib.TBSBP_ITEM_LIST.IxPUR_PRICE,		(int)ClassLib.TBSBP_ITEM_LIST.IxPUR_CURRENCY,
											(int)ClassLib.TBSBP_ITEM_LIST.IxOUTSIDE_PRICE,	(int)ClassLib.TBSBP_ITEM_LIST.IxOUTSIDE_CURRENCY,
											(int)ClassLib.TBSBP_ITEM_LIST.IxCBD_PRICE,		(int)ClassLib.TBSBP_ITEM_LIST.IxCBD_CURRENCY,
											-1,												-1,
											(int)ClassLib.TBSBP_ITEM_LIST.IxCBM,			(int)ClassLib.TBSBP_ITEM_LIST.IxWEIGHT
										};

				// Todo : 팝업 명칭 변경, OBS ID 보내주기
				FlexPurchase.Shipping.Pop_BC_CBD_Information_3 vPop = new FlexPurchase.Shipping.Pop_BC_CBD_Information_3(spd_main, keys, values);
				vPop._obsId = "";
				vPop._style = "";

				vPop.ShowDialog(this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "getCBDData", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region 서브버튼 이벤트 

		private void insertItem(bool isNew)
		{
			try
			{
				if(_itemPop == null)
				{
					_itemPop = new FlexBase.MaterialBase.Pop_Item_List_Show(this, "", "", "", "", "", "", "", "", false);
				}

				if (isNew)
				{
					_itemPop.Clear_All();
					COM.ComVar.Parameter_PopUp = null;
				}
				else
				{
					int curRow = spd_main.ActiveSheet.ActiveRow.Index;

					if (!ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[curRow, 0].Tag, "").Equals("I"))
						return;

					_itemPop._ItemCd	= spd_main.ActiveSheet.Cells[curRow, (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_CD].Text;
					_itemPop._ItemName	= spd_main.ActiveSheet.Cells[curRow, (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_NAME].Text;
					_itemPop._SpecCd	= spd_main.ActiveSheet.Cells[curRow, (int)ClassLib.TBSBP_ITEM_LIST.IxSPEC_CD].Text;
					_itemPop._SpecName	= spd_main.ActiveSheet.Cells[curRow, (int)ClassLib.TBSBP_ITEM_LIST.IxSPEC_NAME].Text;
					_itemPop._ColorCd	= spd_main.ActiveSheet.Cells[curRow, (int)ClassLib.TBSBP_ITEM_LIST.IxCOLOR_CD].Text;
					_itemPop._ColorName = spd_main.ActiveSheet.Cells[curRow, (int)ClassLib.TBSBP_ITEM_LIST.IxCOLOR_NAME].Text;
					_itemPop._Unit		= spd_main.ActiveSheet.Cells[curRow, (int)ClassLib.TBSBP_ITEM_LIST.IxUNIT].Text;
				}

				//_itemPop.Init_Form();
				_itemPop.ShowDialog(); 

				if (!COM.ComVar.Parameter_PopUp[0].Equals(""))
				{
					applyItemInfo(isNew);
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void applyItemInfo(bool isNew)
		{
			int row = -1;

			if (isNew)
			{
				row = spd_main.Add_Row(img_Action);
				spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_DIV_VALUE].Locked = false;
			}
			else
			{
				spd_main.Update_Row(img_Action);
				row = spd_main.ActiveSheet.ActiveRow.Index;
			}

			if (row > -1)
			{
				// 디폴트 값 설정
				/*
				for (int i = 0 ; i < spd_main.ActiveSheet.ColumnCount ; i++)
				{
					
				}
				*/

				spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBP_ITEM_LIST.IxFACTORY].Value		= cmb_factory.SelectedValue;
				spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_CD].Value		= ClassLib.ComVar.Parameter_PopUp[0];
				spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_NAME].Value	= ClassLib.ComVar.Parameter_PopUp[1];
				spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBP_ITEM_LIST.IxSPEC_CD].Value		= ClassLib.ComVar.Parameter_PopUp[2];
				spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBP_ITEM_LIST.IxSPEC_NAME].Value	= ClassLib.ComVar.Parameter_PopUp[3];
				spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBP_ITEM_LIST.IxCOLOR_CD].Value		= ClassLib.ComVar.Parameter_PopUp[4];
				spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBP_ITEM_LIST.IxCOLOR_NAME].Value	= ClassLib.ComVar.Parameter_PopUp[5];
				spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBP_ITEM_LIST.IxUNIT].Value			= ClassLib.ComVar.Parameter_PopUp[6];
			}
		}

		private void deleteItem()
		{
			spd_main.Delete_Row(this.img_Action);;
		}

		private void recorverGrid()
		{
			spd_main.Recovery();
		}

		#endregion

		#region 정합성 체크

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			try
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
					case ClassLib.ComVar.Validate_Save:
			
						break;
					case ClassLib.ComVar.Validate_Delete:

						break;
					case ClassLib.ComVar.Validate_Confirm:

						break;
					case Validate_Context:
						if (spd_main.ActiveSheet.RowCount <= 0)
							return false;

						break;
				}

				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}

		#endregion

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
			MyOraDB.Process_Name = "PKG_SBP_ITEM_LIST.SELECT_SBP_ITEM_LIST";

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
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_item_division, "");;
			MyOraDB.Parameter_Values[3] = _itemGroupCode;
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_TextBox(txt_itemCode, "");
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_TextBox(txt_itemName, "");
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// CHECK_ITEM_DUPLICATE : 중복 체크
		/// </summary>
		/// <returns>DataTable</returns>
		public int CHECK_ITEM_DUPLICATE(int arg_row)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_ITEM_LIST.CHECK_ITEM_DUPLICATE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_ROW_INDEX";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_ITEM_DIVISION";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[5] = "ARG_COLOR_CD";
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
			MyOraDB.Parameter_Values[0] = arg_row.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBP_ITEM_LIST.IxFACTORY].Value, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_DIV_CD].Value, "");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBP_ITEM_LIST.IxITEM_CD].Value, "");
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBP_ITEM_LIST.IxSPEC_CD].Value, "");
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBP_ITEM_LIST.IxCOLOR_CD].Value, "");
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) throw new Exception("Duplicate check fail!!");

			return Convert.ToInt32(vds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString());
		}

		#endregion

	}
}

