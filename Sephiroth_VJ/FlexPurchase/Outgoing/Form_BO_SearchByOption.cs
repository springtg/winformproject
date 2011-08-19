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
	public class Form_BO_SearchByOption : COM.PCHWinForm.Pop_Small
	{
	
   	    #region 컨트롤 정의 및 리소스
		private System.Windows.Forms.GroupBox grp_Group;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.Label lbl_item;
		private C1.Win.C1List.C1Combo cmb_workLine;
		private System.Windows.Forms.Label lbl_workLine;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label btn_groupSearch;
		private C1.Win.C1List.C1Combo cmb_Option;
		private System.Windows.Forms.Label lbl_Print;
		private System.Windows.Forms.Label lbl_workProcess;
		private C1.Win.C1List.C1Combo cmb_workProcess;
		private System.Windows.Forms.Label lbl_between;
		private System.Windows.Forms.DateTimePicker dpick_To_Ymd;
		private C1.Win.C1List.C1Combo cmb_outDiv;
		private System.Windows.Forms.Label lbl_ProcessDiv;
		private System.Windows.Forms.DateTimePicker dpick_From_Ymd;
		private System.Windows.Forms.Label lbl_workYmd;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Print;
		private System.Windows.Forms.Button btn_Calculation;
		private C1.Win.C1List.C1Combo cmb_workLine_to;
		private System.Windows.Forms.Label label2;

		private System.ComponentModel.IContainer components = null;


		public Form_BO_SearchByOption()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BO_SearchByOption));
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
            this.grp_Group = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_workLine_to = new C1.Win.C1List.C1Combo();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_workLine = new C1.Win.C1List.C1Combo();
            this.lbl_workLine = new System.Windows.Forms.Label();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.cmb_Option = new C1.Win.C1List.C1Combo();
            this.lbl_Print = new System.Windows.Forms.Label();
            this.lbl_workProcess = new System.Windows.Forms.Label();
            this.cmb_workProcess = new C1.Win.C1List.C1Combo();
            this.lbl_between = new System.Windows.Forms.Label();
            this.dpick_To_Ymd = new System.Windows.Forms.DateTimePicker();
            this.cmb_outDiv = new C1.Win.C1List.C1Combo();
            this.lbl_ProcessDiv = new System.Windows.Forms.Label();
            this.dpick_From_Ymd = new System.Windows.Forms.DateTimePicker();
            this.lbl_workYmd = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Calculation = new System.Windows.Forms.Button();
            this.grp_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outDiv)).BeginInit();
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
            this.lbl_MainTitle.Location = new System.Drawing.Point(32, 8);
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
            // grp_Group
            // 
            this.grp_Group.BackColor = System.Drawing.Color.Transparent;
            this.grp_Group.Controls.Add(this.label2);
            this.grp_Group.Controls.Add(this.cmb_workLine_to);
            this.grp_Group.Controls.Add(this.txt_itemNm);
            this.grp_Group.Controls.Add(this.txt_itemCd);
            this.grp_Group.Controls.Add(this.lbl_item);
            this.grp_Group.Controls.Add(this.cmb_workLine);
            this.grp_Group.Controls.Add(this.lbl_workLine);
            this.grp_Group.Controls.Add(this.cmb_itemGroup);
            this.grp_Group.Controls.Add(this.label1);
            this.grp_Group.Controls.Add(this.btn_groupSearch);
            this.grp_Group.Controls.Add(this.cmb_Option);
            this.grp_Group.Controls.Add(this.lbl_Print);
            this.grp_Group.Controls.Add(this.lbl_workProcess);
            this.grp_Group.Controls.Add(this.cmb_workProcess);
            this.grp_Group.Controls.Add(this.lbl_between);
            this.grp_Group.Controls.Add(this.dpick_To_Ymd);
            this.grp_Group.Controls.Add(this.cmb_outDiv);
            this.grp_Group.Controls.Add(this.lbl_ProcessDiv);
            this.grp_Group.Controls.Add(this.dpick_From_Ymd);
            this.grp_Group.Controls.Add(this.lbl_workYmd);
            this.grp_Group.Controls.Add(this.cmb_factory);
            this.grp_Group.Controls.Add(this.lbl_factory);
            this.grp_Group.Location = new System.Drawing.Point(6, 34);
            this.grp_Group.Name = "grp_Group";
            this.grp_Group.Size = new System.Drawing.Size(344, 200);
            this.grp_Group.TabIndex = 28;
            this.grp_Group.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(213, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 429;
            this.label2.Text = "~";
            // 
            // cmb_workLine_to
            // 
            this.cmb_workLine_to.AddItemCols = 0;
            this.cmb_workLine_to.AddItemSeparator = ';';
            this.cmb_workLine_to.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_workLine_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_workLine_to.Caption = "";
            this.cmb_workLine_to.CaptionHeight = 17;
            this.cmb_workLine_to.CaptionStyle = style1;
            this.cmb_workLine_to.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_workLine_to.ColumnCaptionHeight = 18;
            this.cmb_workLine_to.ColumnFooterHeight = 18;
            this.cmb_workLine_to.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_workLine_to.ContentHeight = 16;
            this.cmb_workLine_to.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_workLine_to.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_workLine_to.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_workLine_to.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_workLine_to.EditorHeight = 16;
            this.cmb_workLine_to.EvenRowStyle = style2;
            this.cmb_workLine_to.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_workLine_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_workLine_to.FooterStyle = style3;
            this.cmb_workLine_to.GapHeight = 2;
            this.cmb_workLine_to.HeadingStyle = style4;
            this.cmb_workLine_to.HighLightRowStyle = style5;
            this.cmb_workLine_to.ItemHeight = 15;
            this.cmb_workLine_to.Location = new System.Drawing.Point(230, 126);
            this.cmb_workLine_to.MatchEntryTimeout = ((long)(2000));
            this.cmb_workLine_to.MaxDropDownItems = ((short)(5));
            this.cmb_workLine_to.MaxLength = 32767;
            this.cmb_workLine_to.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_workLine_to.Name = "cmb_workLine_to";
            this.cmb_workLine_to.OddRowStyle = style6;
            this.cmb_workLine_to.PartialRightColumn = false;
            this.cmb_workLine_to.PropBag = resources.GetString("cmb_workLine_to.PropBag");
            this.cmb_workLine_to.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_workLine_to.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_workLine_to.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_workLine_to.SelectedStyle = style7;
            this.cmb_workLine_to.Size = new System.Drawing.Size(99, 20);
            this.cmb_workLine_to.Style = style8;
            this.cmb_workLine_to.TabIndex = 428;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(168, 170);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(160, 21);
            this.txt_itemNm.TabIndex = 427;
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(109, 170);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(56, 21);
            this.txt_itemCd.TabIndex = 426;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(8, 170);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 425;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_workLine
            // 
            this.cmb_workLine.AddItemCols = 0;
            this.cmb_workLine.AddItemSeparator = ';';
            this.cmb_workLine.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_workLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_workLine.Caption = "";
            this.cmb_workLine.CaptionHeight = 17;
            this.cmb_workLine.CaptionStyle = style9;
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
            this.cmb_workLine.EvenRowStyle = style10;
            this.cmb_workLine.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_workLine.FooterStyle = style11;
            this.cmb_workLine.GapHeight = 2;
            this.cmb_workLine.HeadingStyle = style12;
            this.cmb_workLine.HighLightRowStyle = style13;
            this.cmb_workLine.ItemHeight = 15;
            this.cmb_workLine.Location = new System.Drawing.Point(109, 126);
            this.cmb_workLine.MatchEntryTimeout = ((long)(2000));
            this.cmb_workLine.MaxDropDownItems = ((short)(5));
            this.cmb_workLine.MaxLength = 32767;
            this.cmb_workLine.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_workLine.Name = "cmb_workLine";
            this.cmb_workLine.OddRowStyle = style14;
            this.cmb_workLine.PartialRightColumn = false;
            this.cmb_workLine.PropBag = resources.GetString("cmb_workLine.PropBag");
            this.cmb_workLine.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_workLine.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_workLine.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_workLine.SelectedStyle = style15;
            this.cmb_workLine.Size = new System.Drawing.Size(99, 20);
            this.cmb_workLine.Style = style16;
            this.cmb_workLine.TabIndex = 423;
            this.cmb_workLine.SelectedValueChanged += new System.EventHandler(this.cmb_workLine_SelectedValueChanged);
            // 
            // lbl_workLine
            // 
            this.lbl_workLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workLine.ImageIndex = 1;
            this.lbl_workLine.ImageList = this.img_Label;
            this.lbl_workLine.Location = new System.Drawing.Point(8, 126);
            this.lbl_workLine.Name = "lbl_workLine";
            this.lbl_workLine.Size = new System.Drawing.Size(100, 21);
            this.lbl_workLine.TabIndex = 424;
            this.lbl_workLine.Text = "Work Line";
            this.lbl_workLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_itemGroup.Location = new System.Drawing.Point(109, 148);
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
            this.cmb_itemGroup.Size = new System.Drawing.Size(198, 20);
            this.cmb_itemGroup.Style = style24;
            this.cmb_itemGroup.TabIndex = 422;
            this.cmb_itemGroup.TextChanged += new System.EventHandler(this.cmb_itemGroup_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 421;
            this.label1.Text = "Item Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(306, 148);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(25, 21);
            this.btn_groupSearch.TabIndex = 420;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // cmb_Option
            // 
            this.cmb_Option.AddItemCols = 0;
            this.cmb_Option.AddItemSeparator = ';';
            this.cmb_Option.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Option.Caption = "";
            this.cmb_Option.CaptionHeight = 17;
            this.cmb_Option.CaptionStyle = style25;
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
            this.cmb_Option.EvenRowStyle = style26;
            this.cmb_Option.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Option.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Option.FooterStyle = style27;
            this.cmb_Option.GapHeight = 2;
            this.cmb_Option.HeadingStyle = style28;
            this.cmb_Option.HighLightRowStyle = style29;
            this.cmb_Option.ItemHeight = 15;
            this.cmb_Option.Location = new System.Drawing.Point(109, 38);
            this.cmb_Option.MatchEntryTimeout = ((long)(2000));
            this.cmb_Option.MaxDropDownItems = ((short)(5));
            this.cmb_Option.MaxLength = 32767;
            this.cmb_Option.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Option.Name = "cmb_Option";
            this.cmb_Option.OddRowStyle = style30;
            this.cmb_Option.PartialRightColumn = false;
            this.cmb_Option.PropBag = resources.GetString("cmb_Option.PropBag");
            this.cmb_Option.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Option.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Option.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Option.SelectedStyle = style31;
            this.cmb_Option.Size = new System.Drawing.Size(220, 20);
            this.cmb_Option.Style = style32;
            this.cmb_Option.TabIndex = 418;
            this.cmb_Option.TextChanged += new System.EventHandler(this.cmb_Option_TextChanged);
            // 
            // lbl_Print
            // 
            this.lbl_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Print.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Print.ImageIndex = 1;
            this.lbl_Print.ImageList = this.img_Label;
            this.lbl_Print.Location = new System.Drawing.Point(8, 38);
            this.lbl_Print.Name = "lbl_Print";
            this.lbl_Print.Size = new System.Drawing.Size(100, 21);
            this.lbl_Print.TabIndex = 419;
            this.lbl_Print.Text = "Option";
            this.lbl_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_workProcess
            // 
            this.lbl_workProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workProcess.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workProcess.ImageIndex = 1;
            this.lbl_workProcess.ImageList = this.img_Label;
            this.lbl_workProcess.Location = new System.Drawing.Point(8, 104);
            this.lbl_workProcess.Name = "lbl_workProcess";
            this.lbl_workProcess.Size = new System.Drawing.Size(100, 21);
            this.lbl_workProcess.TabIndex = 417;
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
            this.cmb_workProcess.CaptionStyle = style33;
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
            this.cmb_workProcess.EvenRowStyle = style34;
            this.cmb_workProcess.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_workProcess.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_workProcess.FooterStyle = style35;
            this.cmb_workProcess.GapHeight = 2;
            this.cmb_workProcess.HeadingStyle = style36;
            this.cmb_workProcess.HighLightRowStyle = style37;
            this.cmb_workProcess.ItemHeight = 15;
            this.cmb_workProcess.Location = new System.Drawing.Point(109, 104);
            this.cmb_workProcess.MatchEntryTimeout = ((long)(2000));
            this.cmb_workProcess.MaxDropDownItems = ((short)(5));
            this.cmb_workProcess.MaxLength = 32767;
            this.cmb_workProcess.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_workProcess.Name = "cmb_workProcess";
            this.cmb_workProcess.OddRowStyle = style38;
            this.cmb_workProcess.PartialRightColumn = false;
            this.cmb_workProcess.PropBag = resources.GetString("cmb_workProcess.PropBag");
            this.cmb_workProcess.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_workProcess.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_workProcess.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_workProcess.SelectedStyle = style39;
            this.cmb_workProcess.Size = new System.Drawing.Size(220, 20);
            this.cmb_workProcess.Style = style40;
            this.cmb_workProcess.TabIndex = 416;
            // 
            // lbl_between
            // 
            this.lbl_between.Location = new System.Drawing.Point(213, 84);
            this.lbl_between.Name = "lbl_between";
            this.lbl_between.Size = new System.Drawing.Size(16, 16);
            this.lbl_between.TabIndex = 413;
            this.lbl_between.Text = "~";
            // 
            // dpick_To_Ymd
            // 
            this.dpick_To_Ymd.CustomFormat = "";
            this.dpick_To_Ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_To_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_To_Ymd.Location = new System.Drawing.Point(232, 82);
            this.dpick_To_Ymd.Name = "dpick_To_Ymd";
            this.dpick_To_Ymd.Size = new System.Drawing.Size(99, 21);
            this.dpick_To_Ymd.TabIndex = 408;
            // 
            // cmb_outDiv
            // 
            this.cmb_outDiv.AddItemCols = 0;
            this.cmb_outDiv.AddItemSeparator = ';';
            this.cmb_outDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outDiv.Caption = "";
            this.cmb_outDiv.CaptionHeight = 17;
            this.cmb_outDiv.CaptionStyle = style41;
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
            this.cmb_outDiv.EvenRowStyle = style42;
            this.cmb_outDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_outDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outDiv.FooterStyle = style43;
            this.cmb_outDiv.GapHeight = 2;
            this.cmb_outDiv.HeadingStyle = style44;
            this.cmb_outDiv.HighLightRowStyle = style45;
            this.cmb_outDiv.ItemHeight = 15;
            this.cmb_outDiv.Location = new System.Drawing.Point(109, 60);
            this.cmb_outDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_outDiv.MaxDropDownItems = ((short)(5));
            this.cmb_outDiv.MaxLength = 32767;
            this.cmb_outDiv.MouseCursor = System.Windows.Forms.Cursors.IBeam;
            this.cmb_outDiv.Name = "cmb_outDiv";
            this.cmb_outDiv.OddRowStyle = style46;
            this.cmb_outDiv.PartialRightColumn = false;
            this.cmb_outDiv.PropBag = resources.GetString("cmb_outDiv.PropBag");
            this.cmb_outDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outDiv.SelectedStyle = style47;
            this.cmb_outDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_outDiv.Style = style48;
            this.cmb_outDiv.TabIndex = 411;
            // 
            // lbl_ProcessDiv
            // 
            this.lbl_ProcessDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ProcessDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProcessDiv.ImageIndex = 1;
            this.lbl_ProcessDiv.ImageList = this.img_Label;
            this.lbl_ProcessDiv.Location = new System.Drawing.Point(8, 60);
            this.lbl_ProcessDiv.Name = "lbl_ProcessDiv";
            this.lbl_ProcessDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_ProcessDiv.TabIndex = 412;
            this.lbl_ProcessDiv.Text = "Out Division";
            this.lbl_ProcessDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_From_Ymd
            // 
            this.dpick_From_Ymd.CustomFormat = "";
            this.dpick_From_Ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_From_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_From_Ymd.Location = new System.Drawing.Point(109, 82);
            this.dpick_From_Ymd.Name = "dpick_From_Ymd";
            this.dpick_From_Ymd.Size = new System.Drawing.Size(99, 21);
            this.dpick_From_Ymd.TabIndex = 407;
            // 
            // lbl_workYmd
            // 
            this.lbl_workYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workYmd.ImageIndex = 1;
            this.lbl_workYmd.ImageList = this.img_Label;
            this.lbl_workYmd.Location = new System.Drawing.Point(8, 82);
            this.lbl_workYmd.Name = "lbl_workYmd";
            this.lbl_workYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_workYmd.TabIndex = 410;
            this.lbl_workYmd.Text = "Work Date";
            this.lbl_workYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style49;
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
            this.cmb_factory.EvenRowStyle = style50;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style51;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style52;
            this.cmb_factory.HighLightRowStyle = style53;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 16);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style54;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style55;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style56;
            this.cmb_factory.TabIndex = 406;
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
            this.lbl_factory.TabIndex = 409;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Close.Location = new System.Drawing.Point(256, 240);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(90, 23);
            this.btn_Close.TabIndex = 36;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Print.Location = new System.Drawing.Point(98, 240);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(90, 23);
            this.btn_Print.TabIndex = 35;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Calculation
            // 
            this.btn_Calculation.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Calculation.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Calculation.ForeColor = System.Drawing.Color.Red;
            this.btn_Calculation.Location = new System.Drawing.Point(8, 240);
            this.btn_Calculation.Name = "btn_Calculation";
            this.btn_Calculation.Size = new System.Drawing.Size(90, 23);
            this.btn_Calculation.TabIndex = 34;
            this.btn_Calculation.Text = "Calculation";
            this.btn_Calculation.UseVisualStyleBackColor = false;
            this.btn_Calculation.Click += new System.EventHandler(this.btn_Calculation_Click);
            // 
            // Form_BO_SearchByOption
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(362, 268);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Calculation);
            this.Controls.Add(this.grp_Group);
            this.Name = "Form_BO_SearchByOption";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.grp_Group, 0);
            this.Controls.SetChildIndex(this.btn_Calculation, 0);
            this.Controls.SetChildIndex(this.btn_Print, 0);
            this.Controls.SetChildIndex(this.btn_Close, 0);
            this.grp_Group.ResumeLayout(false);
            this.grp_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의
		private COM.OraDB MyOraDB      = new COM.OraDB();
		private string _itemGroupCode  = " "; 

		#endregion

		#region  db 컨넥트

		
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

		#endregion

		#region 공통 메서드

		private void Init_Form()

		{						
			// Form Setting
            lbl_MainTitle.Text = "Outgoing By Option";
            this.Text = "Outgoing By Option";
            ClassLib.ComFunction.SetLangDic(this);

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// cmb_print_type		
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBO03");
			COM.ComCtl.Set_ComboList(vDt,cmb_Option, 1, 2, true, 56,0);
			cmb_Option.SelectedIndex = -1;

			// cmb_workLine, cmb_workLine_to
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
			COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
			vDt.Dispose() ;
 


			//	cmb_workProcess
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Opcd_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_workProcess, 1, 1, true);
			vDt.Dispose() ;


			// Item Group Combobox Setting
			vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
			vDt.Dispose();



			dpick_From_Ymd.Enabled  = false;
			dpick_To_Ymd.Enabled    = false;			   
			cmb_outDiv.Enabled	    = false;

			cmb_workProcess.Enabled = false;
			cmb_workLine.Enabled    = false;
			cmb_workLine_to.Enabled    = false;
			
			txt_itemNm.Enabled  = false;
			txt_itemCd.Enabled  = false;
			btn_groupSearch.Enabled  = false;

			

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
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd," ")              +		"' ";

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
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion

			#region  Option 4

			if (cmb_Option.SelectedValue.ToString() =="4")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_04");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";
				sPara += "'" + ( (_itemGroupCode == "") ? " " : _itemGroupCode ) +		"' ";   //item group cd 
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemNm, " ") +	"' ";


				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion

			#region  Option 5
			if (cmb_Option.SelectedValue.ToString() =="5")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_05");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();
				

			}
			#endregion 

			#region  Option 6
			if (cmb_Option.SelectedValue.ToString() =="6")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_06");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();
				

			}
			#endregion 

			#region  Option 7

			if (cmb_Option.SelectedValue.ToString() =="7")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_07");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";  
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion

			#region  Option 8

			if (cmb_Option.SelectedValue.ToString() =="8")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_08");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' "; 
				sPara += "'" + ( (_itemGroupCode == "") ? " " : _itemGroupCode ) +		"' ";   //item group cd 
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemNm, " ") +	"' ";


				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion 

			#region  Option 9

			if (cmb_Option.SelectedValue.ToString() =="9")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_09");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' "; 

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion

			#region  Option 10

			if (cmb_Option.SelectedValue.ToString() =="10")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_10");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine_to, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' "; 
				sPara += "'" + ( (_itemGroupCode == "") ? " " : _itemGroupCode ) +		"' ";   //item group cd 
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemNm, " ") +	"' ";


				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion 

			#region  Option 11

			if (cmb_Option.SelectedValue.ToString() =="11")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_11");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine_to, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' "; 
				sPara += "'" + ( (_itemGroupCode == "") ? " " : _itemGroupCode ) +		"' ";   //item group cd 
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemNm, " ") +	"' ";


				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion 

			#region  Option 12

			if (cmb_Option.SelectedValue.ToString() =="12")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_12");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";  
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion

			#region  Option 13

			if (cmb_Option.SelectedValue.ToString() =="13")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_13");
				
				string sPara  = " /rp ";

				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";  
				//sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion 

			#region  Option 14

			if (cmb_Option.SelectedValue.ToString() =="14")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_14");
				
				string sPara  = " /rp ";

				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";  
				//sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion 

			#region  Option 15

			if (cmb_Option.SelectedValue.ToString() =="15")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_15");
				
				string sPara  = " /rp ";

				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";  
				//sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion 

			#region  Option 16

			if (cmb_Option.SelectedValue.ToString() =="16")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_16");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";  
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion

			#region  Option 17

			if (cmb_Option.SelectedValue.ToString() =="17")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_17");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";  
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion


			#region  Option 18

			if (cmb_Option.SelectedValue.ToString() =="18")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_18");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";  
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion


			#region  Option 19

			if (cmb_Option.SelectedValue.ToString() =="19")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_19");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workProcess, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine, " ") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, " ") +	"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")      +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")        +		"' ";
				//sPara += "'" + COM.ComFunction.Empty_Combo(cmb_itemGroup, " ") +	"' ";  
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion


			#region  Option 20

			if (cmb_Option.SelectedValue.ToString() =="20")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_20");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")       +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")         +		"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, " ") +	"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion


			#region  Option 21

			if (cmb_Option.SelectedValue.ToString() =="21")
			{
				
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_By_Option_21");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")  +		"' ";
				sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")       +		"' ";
				sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")         +		"' ";				

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

				

			}

			#endregion


		}

		private void Set_Option_Print(string arg_flag)
		{	
			#region Option 1

			if (arg_flag =="1") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = false;
				cmb_workProcess.Enabled    = false;
				cmb_workLine.Enabled       = false;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = false;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = false;
			   
				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

				
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;

				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;

				
			   

			}
			
			#endregion  

			#region Option 2

			if (arg_flag =="2") 
			{
				dpick_From_Ymd.Enabled    = true;
				dpick_To_Ymd.Enabled      = true;
			   
				cmb_outDiv.Enabled        = false;
				cmb_workProcess.Enabled   = true;
				cmb_workLine.Enabled      = true;
				cmb_workLine.Enabled      = false;

				cmb_itemGroup.Enabled     = true;
				txt_itemNm.Enabled        = false;
				txt_itemCd.Enabled        = false;
				btn_groupSearch.Enabled   = true;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";


								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;


				

			}

			#endregion   

			#region Option 3

			
			if (arg_flag =="3") 
			{
				dpick_From_Ymd.Enabled   = true;
				dpick_To_Ymd.Enabled     = true;
			   
				cmb_outDiv.Enabled       = true;
				cmb_workProcess.Enabled  = true;
				cmb_workLine.Enabled     = true;
				cmb_workLine_to.Enabled  = false;

				cmb_itemGroup.Enabled	 = true;
				txt_itemNm.Enabled		 = false;
				txt_itemCd.Enabled		 = false;
				btn_groupSearch.Enabled  = true;

				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";


				
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;


				

			}


			#endregion   

			#region Option 4



			if (arg_flag =="4") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = true;
				txt_itemCd.Enabled         = true;
				btn_groupSearch.Enabled    = true;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;


				

			}

			#endregion   

			#region Option 5



			if (arg_flag =="5") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = false;
 
				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = true;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBO02");
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56,0);


				// cmb_group_line	
				//vDt = ClassLib.ComVar.Select_ComFilterCode(COM.ComVar.This_Factory,"SBO04");
				//vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);

                if (ClassLib.ComVar.This_Factory == "QD" || ClassLib.ComVar.This_Factory == "JJ")
				{
					vDt = ClassLib.ComVar.Select_ComFilterCode(COM.ComVar.This_Factory,"SBO04");
				}
				else
				{
					vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				}

				COM.ComCtl.Set_ComboList(vDt,cmb_workLine, 0, 1, true, 56,0);
				COM.ComCtl.Set_ComboList(vDt,cmb_workLine_to, 0, 1, true, 56,0);

				

			}
			#endregion   

			#region Option 6



			if (arg_flag =="6") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = false;
				cmb_workProcess.Enabled    = false;
				cmb_workLine.Enabled       = false;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = false;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = false;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBO02");
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56,0);


				// cmb_group_line	
				vDt = ClassLib.ComVar.Select_ComFilterCode(COM.ComVar.This_Factory,"SBO04");
				COM.ComCtl.Set_ComboList(vDt,cmb_workLine, 0, 1, true, 56,0);
				COM.ComCtl.Set_ComboList(vDt,cmb_workLine_to, 0, 1, true, 56,0);

				

			}
			#endregion    

			#region Option 7



			if (arg_flag =="7") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = true;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;


				

			}

			#endregion    
			
			#region Option 8



			if (arg_flag =="8") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine.Enabled       = false;

				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = true;
				txt_itemCd.Enabled         = true;
				btn_groupSearch.Enabled    = true;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;
 
 
				

			}

			#endregion    

			#region Option 9



			if (arg_flag =="9") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = false;
				cmb_workProcess.Enabled    = false;
				cmb_workLine.Enabled       = false;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = false;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = false;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;


				

			}

			#endregion   

			#region Option 10



			if (arg_flag =="10") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = true;

				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = true;
				txt_itemCd.Enabled         = true;
				btn_groupSearch.Enabled    = true;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, false);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, false);
				vDt.Dispose() ;
 
 
				

			}

			#endregion    

			#region Option 11



			if (arg_flag =="11") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = true;

				cmb_itemGroup.Enabled      = false;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = false;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, false);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, false);
				vDt.Dispose() ;
 
 
				

			}

			#endregion    

			#region Option 12



			if (arg_flag =="12") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = true;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;


				

			}

			#endregion    
			
			#region Option 13



			if (arg_flag =="13") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = true;

				cmb_itemGroup.Enabled      = false;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = false;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, false);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, false);
				vDt.Dispose() ;
 
 
				

			}

			#endregion    

			#region Option 14



			if (arg_flag =="14") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = true;

				cmb_itemGroup.Enabled      = false;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = false;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, false);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, false);
				vDt.Dispose() ;
 
 
				

			}

			#endregion    
 
			#region Option 15



			if (arg_flag =="15") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = true;

				cmb_itemGroup.Enabled      = false;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = false;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, false);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, false);
				vDt.Dispose() ;
 
 
				

			}

			#endregion    
			
			#region Option 16



			if (arg_flag =="16") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = true;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;


				

			}

			#endregion    
			
			#region Option 17



			if (arg_flag =="17") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = true;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;


				

			}

			#endregion    
 
			
			#region Option 18



			if (arg_flag =="18") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = true;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;


				

			}

			#endregion    
 
			
			#region Option 19



			if (arg_flag =="19") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = false;
				btn_groupSearch.Enabled    = true;


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;


				

			}

			#endregion    

			#region Option 20



			if (arg_flag =="20") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = true;
				btn_groupSearch.Enabled    = true;

				lbl_item.Text			   = "Price";


				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;

				
				

			}
			else
			{
				lbl_item.Text = "Item";
			}

			#endregion    

			#region Option 21



			if (arg_flag =="21") 
			{
				dpick_From_Ymd.Enabled     = true;
				dpick_To_Ymd.Enabled       = true;
			   
				cmb_outDiv.Enabled         = true;
				cmb_workProcess.Enabled    = true;
				cmb_workLine.Enabled       = true;
				cmb_workLine_to.Enabled    = false;

				cmb_itemGroup.Enabled      = true;
				txt_itemNm.Enabled         = false;
				txt_itemCd.Enabled         = true;
				btn_groupSearch.Enabled    = true;
			

				cmb_outDiv.SelectedIndex        = -1;
				cmb_workProcess.SelectedIndex   = -1;
				cmb_workLine.SelectedIndex      = -1;
				cmb_workLine_to.SelectedIndex   = -1;
				cmb_itemGroup.SelectedIndex     = -1;
				txt_itemNm.Text                 ="";
				txt_itemCd.Text                 ="";

								
				// out_div set    cmb_outDiv
				DataTable vDt = null;
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_outDiv, 1, 2, true, 56, 0);
				cmb_outDiv.SelectedIndex = 0;


				// cmb_workLine
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
				COM.ComCtl.Set_ComboList(vDt, cmb_workLine_to, 0, 1, true);
				vDt.Dispose() ;

				
				

			}

			#endregion    
 

			_itemGroupCode = "";

		}

		#endregion

		#region 이벤트 처리

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

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn_Print_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_PrintProcess(); 
		}



		private void cmb_Option_TextChanged(object sender, System.EventArgs e)
		{
			if ( cmb_Option.SelectedValue.ToString()  == "1" ) 
				Set_Option_Print("1");
			else if  ( cmb_Option.SelectedValue.ToString()  == "2") 
				Set_Option_Print("2");
			else if  ( cmb_Option.SelectedValue.ToString()  == "3") 
				Set_Option_Print("3");
			else if  ( cmb_Option.SelectedValue.ToString()  == "4") 
				Set_Option_Print("4");
			else if  ( cmb_Option.SelectedValue.ToString()  == "5") 
				Set_Option_Print("5");
			else if  ( cmb_Option.SelectedValue.ToString()  == "6") 
				Set_Option_Print("6"); 
			else if  ( cmb_Option.SelectedValue.ToString()  == "7") 
				Set_Option_Print("7"); 
			else if  ( cmb_Option.SelectedValue.ToString()  == "8") 
				Set_Option_Print("8"); 
			else if  ( cmb_Option.SelectedValue.ToString()  == "9") 
				Set_Option_Print("9"); 
			else if  ( cmb_Option.SelectedValue.ToString()  == "10") 
				Set_Option_Print("10"); 
			else if  ( cmb_Option.SelectedValue.ToString()  == "11") 
				Set_Option_Print("11"); 
			else
				Set_Option_Print("8");

		}



		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
			try
			{

				string vTyep = cmb_itemGroup.SelectedValue.ToString();
				FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);
				
				vPopup.ShowDialog();
			
				_itemGroupCode = COM.ComVar.Parameter_PopUp[3];
				txt_itemCd.Text	= _itemGroupCode;

				//if (cmb_Option.SelectedValue.ToString() =="4" || cmb_Option.SelectedValue.ToString() =="8")
				if(txt_itemCd.Enabled)
				{
					txt_itemCd.Text	= "";
				}

				vPopup.Dispose(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void cmb_itemGroup_TextChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 
			
				if(cmb_itemGroup.SelectedIndex == -1) return; 
				_itemGroupCode = cmb_itemGroup.SelectedValue.ToString();
				txt_itemCd.Text	= _itemGroupCode; 

				//if (cmb_Option.SelectedValue.ToString() =="4" || cmb_Option.SelectedValue.ToString() =="8")
				if(txt_itemCd.Enabled)
				{
					txt_itemCd.Text	= "";
				}


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void cmb_workLine_SelectedValueChanged(object sender, System.EventArgs e)
		{

			try
			{
				//if(cmb_workLine.SelectedIndex == -1) return;

				//cmb_workLine_to.SelectedValue = cmb_workLine.SelectedValue.ToString();

				cmb_workLine_to.SelectedIndex = cmb_workLine.SelectedIndex;

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_workLine_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

	 


		#endregion

		
		


	}


}