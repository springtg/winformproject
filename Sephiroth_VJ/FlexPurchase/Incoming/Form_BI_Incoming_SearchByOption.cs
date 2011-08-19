using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Incoming
{
	public class Form_BI_Incoming_SearchByOption : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.GroupBox grp_Group;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_between;
		private System.Windows.Forms.DateTimePicker dpick_In_ToYmd;
		private C1.Win.C1List.C1Combo cmb_Vender;
		private System.Windows.Forms.Label lbl_Vender;
		private System.Windows.Forms.DateTimePicker dpick_inYmd;
		private System.Windows.Forms.Label lbl_inYmd;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cmb_Print_Type;
		private System.Windows.Forms.Label lbl_Print_Type;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.Label lbl_item;
		private C1.Win.C1List.C1Combo cmb_inType;
		private System.Windows.Forms.Label lbl_inType;
		private C1.Win.C1List.C1Combo cmb_inNo;
		private System.Windows.Forms.Label lbl_inNo;
		private System.Windows.Forms.Label btn_search;
		private C1.Win.C1List.C1Combo cmb_purDiv;
		private C1.Win.C1List.C1Combo cmb_buyDiv;
		private System.Windows.Forms.Label lbl_buyDiv;
		private System.Windows.Forms.Label lbl_purDiv;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Print;
		private System.ComponentModel.IContainer components = null;

		public Form_BI_Incoming_SearchByOption()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			Init_Form();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BI_Incoming_SearchByOption));
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
            this.grp_Group = new System.Windows.Forms.GroupBox();
            this.cmb_purDiv = new C1.Win.C1List.C1Combo();
            this.cmb_buyDiv = new C1.Win.C1List.C1Combo();
            this.lbl_buyDiv = new System.Windows.Forms.Label();
            this.lbl_purDiv = new System.Windows.Forms.Label();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_inType = new C1.Win.C1List.C1Combo();
            this.lbl_inType = new System.Windows.Forms.Label();
            this.cmb_inNo = new C1.Win.C1List.C1Combo();
            this.lbl_inNo = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Label();
            this.cmb_Print_Type = new C1.Win.C1List.C1Combo();
            this.lbl_Print_Type = new System.Windows.Forms.Label();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_between = new System.Windows.Forms.Label();
            this.dpick_In_ToYmd = new System.Windows.Forms.DateTimePicker();
            this.cmb_Vender = new C1.Win.C1List.C1Combo();
            this.lbl_Vender = new System.Windows.Forms.Label();
            this.dpick_inYmd = new System.Windows.Forms.DateTimePicker();
            this.lbl_inYmd = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.grp_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Print_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vender)).BeginInit();
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(320, 23);
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
            // grp_Group
            // 
            this.grp_Group.BackColor = System.Drawing.Color.Transparent;
            this.grp_Group.Controls.Add(this.cmb_purDiv);
            this.grp_Group.Controls.Add(this.cmb_buyDiv);
            this.grp_Group.Controls.Add(this.lbl_buyDiv);
            this.grp_Group.Controls.Add(this.lbl_purDiv);
            this.grp_Group.Controls.Add(this.txt_itemNm);
            this.grp_Group.Controls.Add(this.txt_itemCd);
            this.grp_Group.Controls.Add(this.lbl_item);
            this.grp_Group.Controls.Add(this.cmb_inType);
            this.grp_Group.Controls.Add(this.lbl_inType);
            this.grp_Group.Controls.Add(this.cmb_inNo);
            this.grp_Group.Controls.Add(this.lbl_inNo);
            this.grp_Group.Controls.Add(this.btn_search);
            this.grp_Group.Controls.Add(this.cmb_Print_Type);
            this.grp_Group.Controls.Add(this.lbl_Print_Type);
            this.grp_Group.Controls.Add(this.cmb_itemGroup);
            this.grp_Group.Controls.Add(this.label1);
            this.grp_Group.Controls.Add(this.btn_groupSearch);
            this.grp_Group.Controls.Add(this.lbl_between);
            this.grp_Group.Controls.Add(this.dpick_In_ToYmd);
            this.grp_Group.Controls.Add(this.cmb_Vender);
            this.grp_Group.Controls.Add(this.lbl_Vender);
            this.grp_Group.Controls.Add(this.dpick_inYmd);
            this.grp_Group.Controls.Add(this.lbl_inYmd);
            this.grp_Group.Controls.Add(this.cmb_factory);
            this.grp_Group.Controls.Add(this.lbl_factory);
            this.grp_Group.Location = new System.Drawing.Point(8, 32);
            this.grp_Group.Name = "grp_Group";
            this.grp_Group.Size = new System.Drawing.Size(336, 248);
            this.grp_Group.TabIndex = 27;
            this.grp_Group.TabStop = false;
            // 
            // cmb_purDiv
            // 
            this.cmb_purDiv.AddItemCols = 0;
            this.cmb_purDiv.AddItemSeparator = ';';
            this.cmb_purDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purDiv.Caption = "";
            this.cmb_purDiv.CaptionHeight = 17;
            this.cmb_purDiv.CaptionStyle = style1;
            this.cmb_purDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purDiv.ColumnCaptionHeight = 18;
            this.cmb_purDiv.ColumnFooterHeight = 18;
            this.cmb_purDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purDiv.ContentHeight = 16;
            this.cmb_purDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_purDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purDiv.EditorHeight = 16;
            this.cmb_purDiv.EvenRowStyle = style2;
            this.cmb_purDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purDiv.FooterStyle = style3;
            this.cmb_purDiv.GapHeight = 2;
            this.cmb_purDiv.HeadingStyle = style4;
            this.cmb_purDiv.HighLightRowStyle = style5;
            this.cmb_purDiv.ItemHeight = 15;
            this.cmb_purDiv.Location = new System.Drawing.Point(109, 148);
            this.cmb_purDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_purDiv.MaxDropDownItems = ((short)(5));
            this.cmb_purDiv.MaxLength = 32767;
            this.cmb_purDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purDiv.Name = "cmb_purDiv";
            this.cmb_purDiv.OddRowStyle = style6;
            this.cmb_purDiv.PartialRightColumn = false;
            this.cmb_purDiv.PropBag = resources.GetString("cmb_purDiv.PropBag");
            this.cmb_purDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.SelectedStyle = style7;
            this.cmb_purDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_purDiv.Style = style8;
            this.cmb_purDiv.TabIndex = 446;
            // 
            // cmb_buyDiv
            // 
            this.cmb_buyDiv.AddItemCols = 0;
            this.cmb_buyDiv.AddItemSeparator = ';';
            this.cmb_buyDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_buyDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_buyDiv.Caption = "";
            this.cmb_buyDiv.CaptionHeight = 17;
            this.cmb_buyDiv.CaptionStyle = style9;
            this.cmb_buyDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_buyDiv.ColumnCaptionHeight = 18;
            this.cmb_buyDiv.ColumnFooterHeight = 18;
            this.cmb_buyDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_buyDiv.ContentHeight = 16;
            this.cmb_buyDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_buyDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_buyDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_buyDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_buyDiv.EditorHeight = 16;
            this.cmb_buyDiv.EvenRowStyle = style10;
            this.cmb_buyDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_buyDiv.FooterStyle = style11;
            this.cmb_buyDiv.GapHeight = 2;
            this.cmb_buyDiv.HeadingStyle = style12;
            this.cmb_buyDiv.HighLightRowStyle = style13;
            this.cmb_buyDiv.ItemHeight = 15;
            this.cmb_buyDiv.Location = new System.Drawing.Point(109, 170);
            this.cmb_buyDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_buyDiv.MaxDropDownItems = ((short)(5));
            this.cmb_buyDiv.MaxLength = 32767;
            this.cmb_buyDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_buyDiv.Name = "cmb_buyDiv";
            this.cmb_buyDiv.OddRowStyle = style14;
            this.cmb_buyDiv.PartialRightColumn = false;
            this.cmb_buyDiv.PropBag = resources.GetString("cmb_buyDiv.PropBag");
            this.cmb_buyDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_buyDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.SelectedStyle = style15;
            this.cmb_buyDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_buyDiv.Style = style16;
            this.cmb_buyDiv.TabIndex = 445;
            // 
            // lbl_buyDiv
            // 
            this.lbl_buyDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buyDiv.ImageIndex = 2;
            this.lbl_buyDiv.ImageList = this.img_Label;
            this.lbl_buyDiv.Location = new System.Drawing.Point(8, 170);
            this.lbl_buyDiv.Name = "lbl_buyDiv";
            this.lbl_buyDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_buyDiv.TabIndex = 444;
            this.lbl_buyDiv.Text = "Buy Division";
            this.lbl_buyDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_purDiv
            // 
            this.lbl_purDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purDiv.ImageIndex = 2;
            this.lbl_purDiv.ImageList = this.img_Label;
            this.lbl_purDiv.Location = new System.Drawing.Point(8, 148);
            this.lbl_purDiv.Name = "lbl_purDiv";
            this.lbl_purDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_purDiv.TabIndex = 443;
            this.lbl_purDiv.Text = "Pur  Division";
            this.lbl_purDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(167, 214);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(162, 21);
            this.txt_itemNm.TabIndex = 442;
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(109, 214);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(56, 21);
            this.txt_itemCd.TabIndex = 441;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 2;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(8, 214);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 440;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_inType
            // 
            this.cmb_inType.AddItemCols = 0;
            this.cmb_inType.AddItemSeparator = ';';
            this.cmb_inType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_inType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inType.Caption = "";
            this.cmb_inType.CaptionHeight = 17;
            this.cmb_inType.CaptionStyle = style17;
            this.cmb_inType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inType.ColumnCaptionHeight = 18;
            this.cmb_inType.ColumnFooterHeight = 18;
            this.cmb_inType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inType.ContentHeight = 16;
            this.cmb_inType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_inType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inType.EditorHeight = 16;
            this.cmb_inType.EvenRowStyle = style18;
            this.cmb_inType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_inType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inType.FooterStyle = style19;
            this.cmb_inType.GapHeight = 2;
            this.cmb_inType.HeadingStyle = style20;
            this.cmb_inType.HighLightRowStyle = style21;
            this.cmb_inType.ItemHeight = 15;
            this.cmb_inType.Location = new System.Drawing.Point(109, 126);
            this.cmb_inType.MatchEntryTimeout = ((long)(2000));
            this.cmb_inType.MaxDropDownItems = ((short)(5));
            this.cmb_inType.MaxLength = 32767;
            this.cmb_inType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inType.Name = "cmb_inType";
            this.cmb_inType.OddRowStyle = style22;
            this.cmb_inType.PartialRightColumn = false;
            this.cmb_inType.PropBag = resources.GetString("cmb_inType.PropBag");
            this.cmb_inType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inType.SelectedStyle = style23;
            this.cmb_inType.Size = new System.Drawing.Size(220, 20);
            this.cmb_inType.Style = style24;
            this.cmb_inType.TabIndex = 439;
            // 
            // lbl_inType
            // 
            this.lbl_inType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inType.ImageIndex = 2;
            this.lbl_inType.ImageList = this.img_Label;
            this.lbl_inType.Location = new System.Drawing.Point(8, 126);
            this.lbl_inType.Name = "lbl_inType";
            this.lbl_inType.Size = new System.Drawing.Size(100, 21);
            this.lbl_inType.TabIndex = 438;
            this.lbl_inType.Text = "Incoming Type";
            this.lbl_inType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_inNo
            // 
            this.cmb_inNo.AddItemCols = 0;
            this.cmb_inNo.AddItemSeparator = ';';
            this.cmb_inNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_inNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inNo.Caption = "";
            this.cmb_inNo.CaptionHeight = 17;
            this.cmb_inNo.CaptionStyle = style25;
            this.cmb_inNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inNo.ColumnCaptionHeight = 18;
            this.cmb_inNo.ColumnFooterHeight = 18;
            this.cmb_inNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inNo.ContentHeight = 16;
            this.cmb_inNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_inNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inNo.EditorHeight = 16;
            this.cmb_inNo.EvenRowStyle = style26;
            this.cmb_inNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_inNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inNo.FooterStyle = style27;
            this.cmb_inNo.GapHeight = 2;
            this.cmb_inNo.HeadingStyle = style28;
            this.cmb_inNo.HighLightRowStyle = style29;
            this.cmb_inNo.ItemHeight = 15;
            this.cmb_inNo.Location = new System.Drawing.Point(109, 82);
            this.cmb_inNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_inNo.MaxDropDownItems = ((short)(5));
            this.cmb_inNo.MaxLength = 32767;
            this.cmb_inNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inNo.Name = "cmb_inNo";
            this.cmb_inNo.OddRowStyle = style30;
            this.cmb_inNo.PartialRightColumn = false;
            this.cmb_inNo.PropBag = resources.GetString("cmb_inNo.PropBag");
            this.cmb_inNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inNo.SelectedStyle = style31;
            this.cmb_inNo.Size = new System.Drawing.Size(198, 20);
            this.cmb_inNo.Style = style32;
            this.cmb_inNo.TabIndex = 435;
            // 
            // lbl_inNo
            // 
            this.lbl_inNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inNo.ImageIndex = 2;
            this.lbl_inNo.ImageList = this.img_Label;
            this.lbl_inNo.Location = new System.Drawing.Point(8, 82);
            this.lbl_inNo.Name = "lbl_inNo";
            this.lbl_inNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_inNo.TabIndex = 436;
            this.lbl_inNo.Text = "Incoming No";
            this.lbl_inNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Window;
            this.btn_search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(308, 82);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(21, 21);
            this.btn_search.TabIndex = 437;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Print_Type
            // 
            this.cmb_Print_Type.AddItemCols = 0;
            this.cmb_Print_Type.AddItemSeparator = ';';
            this.cmb_Print_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Print_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Print_Type.Caption = "";
            this.cmb_Print_Type.CaptionHeight = 17;
            this.cmb_Print_Type.CaptionStyle = style33;
            this.cmb_Print_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Print_Type.ColumnCaptionHeight = 18;
            this.cmb_Print_Type.ColumnFooterHeight = 18;
            this.cmb_Print_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Print_Type.ContentHeight = 16;
            this.cmb_Print_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Print_Type.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Print_Type.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Print_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Print_Type.EditorHeight = 16;
            this.cmb_Print_Type.EvenRowStyle = style34;
            this.cmb_Print_Type.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Print_Type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Print_Type.FooterStyle = style35;
            this.cmb_Print_Type.GapHeight = 2;
            this.cmb_Print_Type.HeadingStyle = style36;
            this.cmb_Print_Type.HighLightRowStyle = style37;
            this.cmb_Print_Type.ItemHeight = 15;
            this.cmb_Print_Type.Location = new System.Drawing.Point(109, 38);
            this.cmb_Print_Type.MatchEntryTimeout = ((long)(2000));
            this.cmb_Print_Type.MaxDropDownItems = ((short)(5));
            this.cmb_Print_Type.MaxLength = 32767;
            this.cmb_Print_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Print_Type.Name = "cmb_Print_Type";
            this.cmb_Print_Type.OddRowStyle = style38;
            this.cmb_Print_Type.PartialRightColumn = false;
            this.cmb_Print_Type.PropBag = resources.GetString("cmb_Print_Type.PropBag");
            this.cmb_Print_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Print_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Print_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Print_Type.SelectedStyle = style39;
            this.cmb_Print_Type.Size = new System.Drawing.Size(220, 20);
            this.cmb_Print_Type.Style = style40;
            this.cmb_Print_Type.TabIndex = 434;
            this.cmb_Print_Type.TextChanged += new System.EventHandler(this.cmb_Print_Type_TextChanged);
            // 
            // lbl_Print_Type
            // 
            this.lbl_Print_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Print_Type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Print_Type.ImageIndex = 1;
            this.lbl_Print_Type.ImageList = this.img_Label;
            this.lbl_Print_Type.Location = new System.Drawing.Point(8, 38);
            this.lbl_Print_Type.Name = "lbl_Print_Type";
            this.lbl_Print_Type.Size = new System.Drawing.Size(100, 21);
            this.lbl_Print_Type.TabIndex = 433;
            this.lbl_Print_Type.Text = "Print_Type";
            this.lbl_Print_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style41;
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
            this.cmb_itemGroup.EvenRowStyle = style42;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style43;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style44;
            this.cmb_itemGroup.HighLightRowStyle = style45;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(109, 192);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style46;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style47;
            this.cmb_itemGroup.Size = new System.Drawing.Size(200, 20);
            this.cmb_itemGroup.Style = style48;
            this.cmb_itemGroup.TabIndex = 432;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 2;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 431;
            this.label1.Text = "Item Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(308, 192);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(21, 21);
            this.btn_groupSearch.TabIndex = 430;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_between
            // 
            this.lbl_between.Location = new System.Drawing.Point(214, 64);
            this.lbl_between.Name = "lbl_between";
            this.lbl_between.Size = new System.Drawing.Size(16, 16);
            this.lbl_between.TabIndex = 429;
            this.lbl_between.Text = "~";
            // 
            // dpick_In_ToYmd
            // 
            this.dpick_In_ToYmd.CustomFormat = "";
            this.dpick_In_ToYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_In_ToYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_In_ToYmd.Location = new System.Drawing.Point(230, 60);
            this.dpick_In_ToYmd.Name = "dpick_In_ToYmd";
            this.dpick_In_ToYmd.Size = new System.Drawing.Size(99, 21);
            this.dpick_In_ToYmd.TabIndex = 428;
            // 
            // cmb_Vender
            // 
            this.cmb_Vender.AddItemCols = 0;
            this.cmb_Vender.AddItemSeparator = ';';
            this.cmb_Vender.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Vender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Vender.Caption = "";
            this.cmb_Vender.CaptionHeight = 17;
            this.cmb_Vender.CaptionStyle = style49;
            this.cmb_Vender.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Vender.ColumnCaptionHeight = 18;
            this.cmb_Vender.ColumnFooterHeight = 18;
            this.cmb_Vender.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Vender.ContentHeight = 16;
            this.cmb_Vender.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Vender.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Vender.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Vender.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Vender.EditorHeight = 16;
            this.cmb_Vender.EvenRowStyle = style50;
            this.cmb_Vender.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Vender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vender.FooterStyle = style51;
            this.cmb_Vender.GapHeight = 2;
            this.cmb_Vender.HeadingStyle = style52;
            this.cmb_Vender.HighLightRowStyle = style53;
            this.cmb_Vender.ItemHeight = 15;
            this.cmb_Vender.Location = new System.Drawing.Point(109, 104);
            this.cmb_Vender.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vender.MaxDropDownItems = ((short)(5));
            this.cmb_Vender.MaxLength = 32767;
            this.cmb_Vender.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vender.Name = "cmb_Vender";
            this.cmb_Vender.OddRowStyle = style54;
            this.cmb_Vender.PartialRightColumn = false;
            this.cmb_Vender.PropBag = resources.GetString("cmb_Vender.PropBag");
            this.cmb_Vender.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vender.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vender.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vender.SelectedStyle = style55;
            this.cmb_Vender.Size = new System.Drawing.Size(220, 20);
            this.cmb_Vender.Style = style56;
            this.cmb_Vender.TabIndex = 427;
            // 
            // lbl_Vender
            // 
            this.lbl_Vender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Vender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vender.ImageIndex = 2;
            this.lbl_Vender.ImageList = this.img_Label;
            this.lbl_Vender.Location = new System.Drawing.Point(8, 104);
            this.lbl_Vender.Name = "lbl_Vender";
            this.lbl_Vender.Size = new System.Drawing.Size(100, 21);
            this.lbl_Vender.TabIndex = 426;
            this.lbl_Vender.Text = "Vender";
            this.lbl_Vender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_inYmd
            // 
            this.dpick_inYmd.CustomFormat = "";
            this.dpick_inYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_inYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_inYmd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_inYmd.Location = new System.Drawing.Point(109, 60);
            this.dpick_inYmd.Name = "dpick_inYmd";
            this.dpick_inYmd.Size = new System.Drawing.Size(99, 21);
            this.dpick_inYmd.TabIndex = 425;
            this.dpick_inYmd.CloseUp += new System.EventHandler(this.dpick_inYmd_CloseUp);
            // 
            // lbl_inYmd
            // 
            this.lbl_inYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inYmd.ImageIndex = 1;
            this.lbl_inYmd.ImageList = this.img_Label;
            this.lbl_inYmd.Location = new System.Drawing.Point(8, 60);
            this.lbl_inYmd.Name = "lbl_inYmd";
            this.lbl_inYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_inYmd.TabIndex = 423;
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
            this.cmb_factory.Location = new System.Drawing.Point(109, 16);
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
            this.cmb_factory.TabIndex = 422;
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
            this.lbl_factory.TabIndex = 424;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Close.Location = new System.Drawing.Point(254, 284);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(90, 23);
            this.btn_Close.TabIndex = 42;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Print.Location = new System.Drawing.Point(8, 284);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(90, 23);
            this.btn_Print.TabIndex = 41;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // Form_BI_Incoming_SearchByOption
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(354, 312);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.grp_Group);
            this.Name = "Form_BI_Incoming_SearchByOption";
            this.Controls.SetChildIndex(this.grp_Group, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_Print, 0);
            this.Controls.SetChildIndex(this.btn_Close, 0);
            this.grp_Group.ResumeLayout(false);
            this.grp_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Print_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB   = new COM.OraDB();
		private bool _practicable	= false;
		private bool _vChgFalg		= false;
		private bool _vNewInNoSet	= false;

		string _vFactory			= "";
		string _vInNo			= "";
		string _vInYmd			= "";

		string _initYn   = "";

		private System.EventHandler _cmbInNoEventHandler		= null;

		#endregion 

		#region 공통 메서드
		private void Init_Form()
		{						
			// Form Setting

            lbl_MainTitle.Text = "Incoming By Option";
            this.Text = lbl_MainTitle.Text;
            ClassLib.ComFunction.SetLangDic(this);

			
			
			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			

			// pur_div set    cmb_purDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_purDiv, 1, 2, false, 56,0);
			cmb_purDiv.SelectedIndex = -1;

			// buy_div set    cmb_buyDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC01");
			COM.ComCtl.Set_ComboList(vDt, cmb_buyDiv, 1, 2, false, 56,0);
			cmb_buyDiv.SelectedIndex = -1;

			// in_type set    cmb_inType
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBI01");
			COM.ComCtl.Set_ComboList(vDt, cmb_inType, 1, 2, false, 56,0);
			cmb_inType.SelectedIndex = -1;

			
			// print_type   cmb_Print_type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBI02");
			COM.ComCtl.Set_ComboList(vDt, cmb_Print_Type, 1, 2, false, 56,0);
			cmb_inType.SelectedIndex = -1;
		
					
			// cust cd
			vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory," ");
			COM.ComCtl.Set_ComboList(vDt,cmb_Vender, 0, 1, false, 100,0);
			cmb_Vender.SelectedIndex = -1;


			dpick_In_ToYmd.Enabled = false;
			cmb_buyDiv.Enabled  = false;
			cmb_inType.Enabled  = false;
			cmb_purDiv.Enabled  = false;
			cmb_buyDiv.Enabled  = false;
			cmb_Vender.Enabled  = false;
			cmb_itemGroup.Enabled = false;
			btn_groupSearch.Enabled = false;
			txt_itemCd.Enabled  = false;
			txt_itemNm.Enabled  = false;


		}


		

		
		private void Tbtn_NewProcess()
		{

			try
			{ 
				cmb_buyDiv.SelectedIndex   = -1;
				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
				cmb_inNo.SelectedIndex  = -1;
				cmb_inType.SelectedIndex  =-1;
				//cmb_Print_Type.SelectedIndex   = -1;
				cmb_purDiv.SelectedIndex  =-1;

				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		}


		

		
		private void Tbtn_SearchProcess(bool arg_bool)
		{
			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 

			// 조회시 필수조건을 체크한다. 
			if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
			{
				//Check_sizeYN();

				_vFactory		= cmb_factory.SelectedValue.ToString();
				_vInYmd			= dpick_inYmd.Text.Replace("-", "");
				if (arg_bool)	_vInNo	= cmb_inNo.SelectedIndex > 0 ? cmb_inNo.SelectedValue.ToString().Trim() : "";

				//this.Tbtn_NewProcess();
				this.SearchHeadInfo();
				//this.SearchTailInfo();
			}
		}



		
		private void Btn_SearchClickProcess()
		{
			Pop_BI_Incoming_InNo vPopup = new Pop_BI_Incoming_InNo();
			COM.ComVar.Parameter_PopUp		= new string[1];
			COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");

			if (vPopup.ShowDialog() == DialogResult.OK)
			{
				_practicable = false;
				cmb_factory.SelectedValue		= COM.ComVar.Parameter_PopUp[0];
				dpick_inYmd.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
				_practicable = true;
				Cmb_inNoSettingProcess(true);
				cmb_inNo.SelectedValue			= COM.ComVar.Parameter_PopUp[2];
			}

			vPopup.Dispose();
		}


		

		private void Tbtn_PrintProcess()
		{
			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory,cmb_Print_Type}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 


			if (cmb_Print_Type.SelectedValue.ToString()  == "01")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_By_Option_01");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_inNo, " ") +		"' ";
				sPara += "'" + this.dpick_inYmd.Text.Replace("-","") +		"' ";
				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

				MyReport.Text = "Incoming sheet";
				MyReport.Show();	
			}

			
			if (cmb_Print_Type.SelectedValue.ToString()  == "02")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_By_Option_02");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
				sPara += "'" + this.dpick_inYmd.Text.Replace("-","") +		"' ";
				sPara += "'" + this.dpick_In_ToYmd.Text.Replace("-","") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_inType, " ") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_purDiv, " ") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_buyDiv, " ") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Vender, " ") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +		"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

				MyReport.Text = "Incoming sheet";
				MyReport.Show();	
			}


			
			if (cmb_Print_Type.SelectedValue.ToString()  == "03")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_By_Option_03");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
				sPara += "'" + this.dpick_inYmd.Text.Replace("-","") +		"' ";
				sPara += "'" + this.dpick_In_ToYmd.Text.Replace("-","") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_inType, " ") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_purDiv, " ") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_buyDiv, " ") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Vender, " ") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +		"' ";
				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

				MyReport.Text = "Incoming sheet";
				MyReport.Show();	
			}
					
		}



		
		
		private void Cmb_inNoSelectedValueChangedProcess()
		{
			try
			{
				if (!_vNewInNoSet)
				{
					if (cmb_inNo.SelectedIndex < 0)
						Tbtn_SearchProcess(false);
					Tbtn_SearchProcess(true);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void Cmb_inNoSettingProcess(bool arg_bool)
		{
			try
			{
				if (_practicable)
				{
					//Check_sizeYN();
					cmb_inNo.SelectedValueChanged -= _cmbInNoEventHandler;

					if(arg_bool) this.Tbtn_NewProcess();
					string[] vProviso = GetSearchProviso();
					DataTable vDt = SELECT_SBI_IN_NO(vProviso[0], vProviso[1]);
					COM.ComCtl.Set_ComboList(vDt, cmb_inNo, 0, 1, true, false);
					cmb_inNo.SelectedIndex = 0;
					//					_vInNo	= ""; 
					vDt.Dispose();

					cmb_inNo.SelectedValueChanged += _cmbInNoEventHandler;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}






		
		private void SearchHeadInfo()
		{
			if (_vInNo != null && _vInNo != "")
			{
				DataTable vTemp = this.SELECT_SBI_IN_HEAD(_vFactory, _vInNo);
				if (vTemp.Rows.Count > 0 && vTemp.Rows.Count < 2)
				{
					this.ClearHeadInfo();
					this.SetHeadInfo(vTemp);
				}
				else
					this.ClearHeadInfo();
				vTemp.Dispose();
			}
		}



//		private void SearchTailInfo()
//		{
//			try
//			{				
//				this.Cursor = Cursors.WaitCursor;
//                
//				int _seqCol				= (int)ClassLib.TBSBI_IN_TAIL.IxSEQ;
//
//				if (_vInNo != null && _vInNo != "")
//				{
//					// 조회조건에 따라 입고데이타를 Select 하여 DataTable형태로 Return 한다.
//					DataTable vTemp = this.SELECT_SBI_IN_TAIL_LIST(_vFactory, _vInNo, _vInYmd);
//					//  Return 된 데이타를 Grid에 display 한다. 
//					ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_main, vTemp);
//
//					// Row의 수로 Seq 값을 보여준다. 
//					if (fgrid_main.Rows.Count > 0 && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
//					{
//						for ( int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++ )
//						{
//							fgrid_main[i, _seqCol] = i + 1 - fgrid_main.Rows.Fixed;
//						}
//						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
//					}
//					else
//					{
//						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
//					}
//
//					//this.EnableControlCheckProcess(true);	// Control Enable Check
//				}
//			}
//			catch (Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			}
//			finally
//			{
//				this.Cursor = Cursors.Default;
//			}
//		}


		private void ClearHeadInfo()
		{
			cmb_inType.SelectedValue	= 0;
			cmb_purDiv.SelectedValue	= 0;
			cmb_buyDiv.SelectedValue	= 0;
		}
	



		private void SetHeadInfo(DataTable arg_dt)
		{
			cmb_inNo.SelectedValue		= arg_dt.Rows[0].ItemArray[1];
			cmb_inType.SelectedValue	= arg_dt.Rows[0].ItemArray[3];
			cmb_purDiv.SelectedValue	= arg_dt.Rows[0].ItemArray[4];
			cmb_buyDiv.SelectedValue	= arg_dt.Rows[0].ItemArray[5];
		}


		
		private void Set_Option(string arg_flag)
		{

			if (arg_flag  =="1") 
			{   
				dpick_In_ToYmd.Enabled = false;
				cmb_buyDiv.Enabled  = false;
				cmb_inType.Enabled  = false;
				cmb_purDiv.Enabled  = false;
				cmb_buyDiv.Enabled  = false;
				cmb_Vender.Enabled  = false;
				cmb_itemGroup.Enabled = false;
				btn_groupSearch.Enabled = false;
				txt_itemCd.Enabled  = false;
				txt_itemNm.Enabled  = false;

			}


			if (arg_flag  =="2") 
			{
				dpick_In_ToYmd.Enabled = true;
				cmb_buyDiv.Enabled  = true;
				cmb_inType.Enabled  = true;
				cmb_purDiv.Enabled  = true;
				cmb_buyDiv.Enabled  = true;
				cmb_Vender.Enabled  = true;
				cmb_itemGroup.Enabled = true;
				btn_groupSearch.Enabled = true;
				txt_itemCd.Enabled  = true;
				txt_itemNm.Enabled  = true;
				
			}


			if (arg_flag  =="3") 
			{
				dpick_In_ToYmd.Enabled = true;
				cmb_buyDiv.Enabled  = true;
				cmb_inType.Enabled  = true;
				cmb_purDiv.Enabled  = true;
				cmb_Vender.Enabled  = true;
				cmb_itemGroup.Enabled = true;
				btn_groupSearch.Enabled = true;
				txt_itemCd.Enabled  = true;
				txt_itemNm.Enabled  = true;
			}


		}





		private string[] GetSearchProviso()
		{
			string[] vProviso = new string[2];
			vProviso[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			vProviso[1] = (_vChgFalg) ? dpick_inYmd.Text.Replace("-", "") : dpick_inYmd.Text.Replace("-", "");

			return vProviso;
		}



		

		


		#endregion

		#region  이벤트 처리
		
		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
		private void btn_Print_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_PrintProcess();
		}


		private void btn_search_Click(object sender, System.EventArgs e)
		{
			this.Btn_SearchClickProcess();
		}
		
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_NewProcess();
		}





		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}




		private void dpick_inYmd_CloseUp(object sender, System.EventArgs e)
		{
			_vInNo	= "";
			 _practicable = true;
			this.Cmb_inNoSettingProcess(true);
			

//			if (!_initYn)
//				this.ClosingCheckProcess(true); 
		}

		

		private void cmb_inNo_TextChanged(object sender, System.EventArgs e)
		{
			this.Cmb_inNoSelectedValueChangedProcess();
		}


		private void cmb_Print_Type_TextChanged(object sender, System.EventArgs e)
		{
			if (cmb_Print_Type.SelectedValue.ToString() == "01")
			{
				Set_Option("1");
			}

			if  (cmb_Print_Type.SelectedValue.ToString() == "02")
			{
				Set_Option("2");

			}

			if  (cmb_Print_Type.SelectedValue.ToString() == "03")
			{
				Set_Option("3");

			}
 
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBI_IN_NO : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBI_IN_NO : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_NO(string arg_factory, string arg_in_ymd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_NO.SELECT_SBI_IN_NO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_YMD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_in_ymd;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBI_IN_HEAD : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBI_IN_HEAD : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_HEAD(string arg_factory, string arg_in_no)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_HEAD.SELECT_SBI_IN_HEAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_in_no;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}




		/// <summary>
		/// PKG_SBI_IN_TAIL : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBI_IN_TAIL : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_TAIL_LIST(string arg_factory, string arg_in_no, string arg_in_ymd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_TAIL.SELECT_SBI_IN_TAIL_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_NO";
			MyOraDB.Parameter_Name[2] = "ARG_IN_YMD";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_in_no;
			MyOraDB.Parameter_Values[2] = arg_in_ymd;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}




		#endregion 


	}
}

