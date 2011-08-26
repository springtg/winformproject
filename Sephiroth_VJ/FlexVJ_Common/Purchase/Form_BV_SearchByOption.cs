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

namespace FlexVJ_Common.Purchase
{
	public class Form_BV_SearchByOption : COM.VJ_CommonWinForm.Pop_Small
	{
	
   	    #region 컨트롤 정의 및 리소스
		private System.Windows.Forms.GroupBox grp_Group;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.Label lbl_item;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label btn_groupSearch;
		private C1.Win.C1List.C1Combo cmb_Option;
		private System.Windows.Forms.Label lbl_Print;
		private System.Windows.Forms.Label lbl_between;
		private System.Windows.Forms.DateTimePicker dpick_To_Ymd;
		private System.Windows.Forms.DateTimePicker dpick_From_Ymd;
		private System.Windows.Forms.Label lbl_workYmd;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Print;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private System.Windows.Forms.TextBox txt_style_name;
		private System.Windows.Forms.Label lbl_purStatus;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.TextBox txt_style_code;

		private System.ComponentModel.IContainer components = null;


		public Form_BV_SearchByOption()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BV_SearchByOption));
			this.grp_Group = new System.Windows.Forms.GroupBox();
			this.txt_itemGroup = new System.Windows.Forms.TextBox();
			this.txt_itemNm = new System.Windows.Forms.TextBox();
			this.txt_itemCd = new System.Windows.Forms.TextBox();
			this.lbl_item = new System.Windows.Forms.Label();
			this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_groupSearch = new System.Windows.Forms.Label();
			this.cmb_Option = new C1.Win.C1List.C1Combo();
			this.lbl_Print = new System.Windows.Forms.Label();
			this.lbl_between = new System.Windows.Forms.Label();
			this.dpick_To_Ymd = new System.Windows.Forms.DateTimePicker();
			this.dpick_From_Ymd = new System.Windows.Forms.DateTimePicker();
			this.lbl_workYmd = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Print = new System.Windows.Forms.Button();
			this.txt_style_name = new System.Windows.Forms.TextBox();
			this.lbl_purStatus = new System.Windows.Forms.Label();
			this.cmb_style = new C1.Win.C1List.C1Combo();
			this.txtSize = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_style_code = new System.Windows.Forms.TextBox();
			this.grp_Group.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Option)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Location = new System.Drawing.Point(32, 8);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(328, 23);
			this.lbl_MainTitle.Text = "Usage Search By Option";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// grp_Group
			// 
			this.grp_Group.BackColor = System.Drawing.Color.Transparent;
			this.grp_Group.Controls.Add(this.txtSize);
			this.grp_Group.Controls.Add(this.label2);
			this.grp_Group.Controls.Add(this.txt_style_name);
			this.grp_Group.Controls.Add(this.lbl_purStatus);
			this.grp_Group.Controls.Add(this.cmb_style);
			this.grp_Group.Controls.Add(this.txt_itemGroup);
			this.grp_Group.Controls.Add(this.txt_itemNm);
			this.grp_Group.Controls.Add(this.txt_itemCd);
			this.grp_Group.Controls.Add(this.lbl_item);
			this.grp_Group.Controls.Add(this.cmb_itemGroup);
			this.grp_Group.Controls.Add(this.label1);
			this.grp_Group.Controls.Add(this.btn_groupSearch);
			this.grp_Group.Controls.Add(this.cmb_Option);
			this.grp_Group.Controls.Add(this.lbl_Print);
			this.grp_Group.Controls.Add(this.lbl_between);
			this.grp_Group.Controls.Add(this.dpick_To_Ymd);
			this.grp_Group.Controls.Add(this.dpick_From_Ymd);
			this.grp_Group.Controls.Add(this.lbl_workYmd);
			this.grp_Group.Controls.Add(this.cmb_factory);
			this.grp_Group.Controls.Add(this.lbl_factory);
			this.grp_Group.Controls.Add(this.txt_style_code);
			this.grp_Group.Location = new System.Drawing.Point(6, 34);
			this.grp_Group.Name = "grp_Group";
			this.grp_Group.Size = new System.Drawing.Size(344, 206);
			this.grp_Group.TabIndex = 28;
			this.grp_Group.TabStop = false;
			// 
			// txt_itemGroup
			// 
			this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_itemGroup.Font = new System.Drawing.Font("Gulim", 9F);
			this.txt_itemGroup.Location = new System.Drawing.Point(209, 102);
			this.txt_itemGroup.MaxLength = 10;
			this.txt_itemGroup.Name = "txt_itemGroup";
			this.txt_itemGroup.ReadOnly = true;
			this.txt_itemGroup.Size = new System.Drawing.Size(98, 21);
			this.txt_itemGroup.TabIndex = 548;
			this.txt_itemGroup.Text = "";
			// 
			// txt_itemNm
			// 
			this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_itemNm.Font = new System.Drawing.Font("Gulim", 9F);
			this.txt_itemNm.Location = new System.Drawing.Point(168, 124);
			this.txt_itemNm.MaxLength = 10;
			this.txt_itemNm.Name = "txt_itemNm";
			this.txt_itemNm.Size = new System.Drawing.Size(160, 21);
			this.txt_itemNm.TabIndex = 427;
			this.txt_itemNm.Text = "";
			// 
			// txt_itemCd
			// 
			this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_itemCd.Font = new System.Drawing.Font("Gulim", 9F);
			this.txt_itemCd.Location = new System.Drawing.Point(109, 124);
			this.txt_itemCd.MaxLength = 10;
			this.txt_itemCd.Name = "txt_itemCd";
			this.txt_itemCd.Size = new System.Drawing.Size(58, 21);
			this.txt_itemCd.TabIndex = 426;
			this.txt_itemCd.Text = "";
			// 
			// lbl_item
			// 
			this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_item.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_item.ImageIndex = 2;
			this.lbl_item.ImageList = this.img_Label;
			this.lbl_item.Location = new System.Drawing.Point(8, 124);
			this.lbl_item.Name = "lbl_item";
			this.lbl_item.Size = new System.Drawing.Size(100, 21);
			this.lbl_item.TabIndex = 425;
			this.lbl_item.Text = "Item ";
			this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_itemGroup.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_itemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_itemGroup.EditorHeight = 17;
			this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_itemGroup.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_itemGroup.GapHeight = 2;
			this.cmb_itemGroup.ItemHeight = 15;
			this.cmb_itemGroup.Location = new System.Drawing.Point(109, 102);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Cont" +
				"rol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}St" +
				"yle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_itemGroup.Size = new System.Drawing.Size(99, 21);
			this.cmb_itemGroup.TabIndex = 422;
			this.cmb_itemGroup.TextChanged += new System.EventHandler(this.cmb_itemGroup_TextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 2;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 421;
			this.label1.Text = "Item Group";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_groupSearch
			// 
			this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
			this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_groupSearch.ImageIndex = 27;
			this.btn_groupSearch.ImageList = this.img_SmallButton;
			this.btn_groupSearch.Location = new System.Drawing.Point(306, 102);
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
			this.cmb_Option.AutoSize = false;
			this.cmb_Option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Option.Caption = "";
			this.cmb_Option.CaptionHeight = 17;
			this.cmb_Option.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Option.ColumnCaptionHeight = 18;
			this.cmb_Option.ColumnFooterHeight = 18;
			this.cmb_Option.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Option.ContentHeight = 17;
			this.cmb_Option.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Option.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Option.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_Option.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Option.EditorHeight = 17;
			this.cmb_Option.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Option.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Option.GapHeight = 2;
			this.cmb_Option.ItemHeight = 15;
			this.cmb_Option.Location = new System.Drawing.Point(109, 38);
			this.cmb_Option.MatchEntryTimeout = ((long)(2000));
			this.cmb_Option.MaxDropDownItems = ((short)(5));
			this.cmb_Option.MaxLength = 32767;
			this.cmb_Option.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Option.Name = "cmb_Option";
			this.cmb_Option.PartialRightColumn = false;
			this.cmb_Option.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Cont" +
				"rol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Option.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Option.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Option.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Option.Size = new System.Drawing.Size(220, 21);
			this.cmb_Option.TabIndex = 418;
			this.cmb_Option.TextChanged += new System.EventHandler(this.cmb_Option_TextChanged);
			// 
			// lbl_Print
			// 
			this.lbl_Print.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Print.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Print.ImageIndex = 1;
			this.lbl_Print.ImageList = this.img_Label;
			this.lbl_Print.Location = new System.Drawing.Point(8, 38);
			this.lbl_Print.Name = "lbl_Print";
			this.lbl_Print.Size = new System.Drawing.Size(100, 21);
			this.lbl_Print.TabIndex = 419;
			this.lbl_Print.Text = "Option";
			this.lbl_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.dpick_To_Ymd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_To_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_To_Ymd.Location = new System.Drawing.Point(232, 80);
			this.dpick_To_Ymd.Name = "dpick_To_Ymd";
			this.dpick_To_Ymd.Size = new System.Drawing.Size(99, 21);
			this.dpick_To_Ymd.TabIndex = 408;
			// 
			// dpick_From_Ymd
			// 
			this.dpick_From_Ymd.CustomFormat = "";
			this.dpick_From_Ymd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_From_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_From_Ymd.Location = new System.Drawing.Point(109, 80);
			this.dpick_From_Ymd.Name = "dpick_From_Ymd";
			this.dpick_From_Ymd.Size = new System.Drawing.Size(99, 21);
			this.dpick_From_Ymd.TabIndex = 407;
			// 
			// lbl_workYmd
			// 
			this.lbl_workYmd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_workYmd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_workYmd.ImageIndex = 2;
			this.lbl_workYmd.ImageList = this.img_Label;
			this.lbl_workYmd.Location = new System.Drawing.Point(8, 80);
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
			this.cmb_factory.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(109, 16);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Cont" +
				"rol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}St" +
				"yle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(220, 21);
			this.cmb_factory.TabIndex = 406;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.btn_Close.Location = new System.Drawing.Point(256, 254);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(90, 23);
			this.btn_Close.TabIndex = 36;
			this.btn_Close.Text = "Close";
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Print
			// 
			this.btn_Print.BackColor = System.Drawing.Color.Gainsboro;
			this.btn_Print.Location = new System.Drawing.Point(166, 254);
			this.btn_Print.Name = "btn_Print";
			this.btn_Print.Size = new System.Drawing.Size(90, 23);
			this.btn_Print.TabIndex = 35;
			this.btn_Print.Text = "Print";
			this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
			// 
			// txt_style_name
			// 
			this.txt_style_name.BackColor = System.Drawing.SystemColors.Window;
			this.txt_style_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_style_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txt_style_name.Location = new System.Drawing.Point(109, 152);
			this.txt_style_name.MaxLength = 500;
			this.txt_style_name.Name = "txt_style_name";
			this.txt_style_name.Size = new System.Drawing.Size(200, 21);
			this.txt_style_name.TabIndex = 552;
			this.txt_style_name.Text = "";
			this.txt_style_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_style_name_KeyPress);
			// 
			// lbl_purStatus
			// 
			this.lbl_purStatus.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_purStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_purStatus.ImageIndex = 2;
			this.lbl_purStatus.ImageList = this.img_Label;
			this.lbl_purStatus.Location = new System.Drawing.Point(8, 152);
			this.lbl_purStatus.Name = "lbl_purStatus";
			this.lbl_purStatus.Size = new System.Drawing.Size(100, 21);
			this.lbl_purStatus.TabIndex = 551;
			this.lbl_purStatus.Text = "Style";
			this.lbl_purStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_style
			// 
			this.cmb_style.AddItemCols = 0;
			this.cmb_style.AddItemSeparator = ';';
			this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_style.AutoSize = false;
			this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_style.Caption = "";
			this.cmb_style.CaptionHeight = 17;
			this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_style.ColumnCaptionHeight = 18;
			this.cmb_style.ColumnFooterHeight = 18;
			this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_style.ContentHeight = 17;
			this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_style.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
			this.cmb_style.DropDownWidth = 400;
			this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_style.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_style.EditorHeight = 17;
			this.cmb_style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_style.GapHeight = 2;
			this.cmb_style.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmb_style.ItemHeight = 15;
			this.cmb_style.Location = new System.Drawing.Point(109, 152);
			this.cmb_style.MatchEntryTimeout = ((long)(2000));
			this.cmb_style.MaxDropDownItems = ((short)(5));
			this.cmb_style.MaxLength = 32767;
			this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_style.Name = "cmb_style";
			this.cmb_style.PartialRightColumn = false;
			this.cmb_style.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_style.Size = new System.Drawing.Size(220, 21);
			this.cmb_style.TabIndex = 553;
			this.cmb_style.TextChanged += new System.EventHandler(this.cmb_style_TextChanged);
			this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
			// 
			// txtSize
			// 
			this.txtSize.BackColor = System.Drawing.SystemColors.Window;
			this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txtSize.Location = new System.Drawing.Point(109, 174);
			this.txtSize.MaxLength = 500;
			this.txtSize.Name = "txtSize";
			this.txtSize.Size = new System.Drawing.Size(220, 21);
			this.txtSize.TabIndex = 555;
			this.txtSize.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ImageIndex = 2;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(8, 174);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 554;
			this.label2.Text = "Size";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_style_code
			// 
			this.txt_style_code.BackColor = System.Drawing.SystemColors.Window;
			this.txt_style_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_style_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txt_style_code.Location = new System.Drawing.Point(109, 152);
			this.txt_style_code.MaxLength = 500;
			this.txt_style_code.Name = "txt_style_code";
			this.txt_style_code.Size = new System.Drawing.Size(64, 21);
			this.txt_style_code.TabIndex = 553;
			this.txt_style_code.Text = "";
			// 
			// Form_BV_SearchByOption
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(362, 288);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_Print);
			this.Controls.Add(this.grp_Group);
			this.Name = "Form_BV_SearchByOption";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.grp_Group, 0);
			this.Controls.SetChildIndex(this.btn_Print, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			this.grp_Group.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Option)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의
		private COM.OraDB MyOraDB      = new COM.OraDB();
		private string _itemGroupCode  = " "; 

		#endregion



		#region 공통 메서드

		private void Init_Form()

		{						
			// Form Setting
			ClassLib.ComFunction.SetLangDic(this);

			lbl_MainTitle.Text = " Consumption Search";
			this.Text		   = " Consumption Search";

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// cmb_print_type		
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SVM14");
			COM.ComCtl.Set_ComboList(vDt,cmb_Option, 1, 2, true, 56,0);
			cmb_Option.SelectedIndex = -1;

			// Item Group Combobox Setting
			vDt = FlexBase.ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
			vDt.Dispose();


		}


		private void Tbtn_PrintProcess()
		{
			try
			{

				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 


				if (cmb_Option.SelectedValue.ToString() =="1")
				{

					string sDir = FlexVJ_Common.ClassLib.ComFunction.Set_RD_Directory("Form_SVM_Usage_By_Option_01");

					string sPara  = " /rp ";
					sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")        + "' ";
					sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")             + "' ";
					sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")               + "' ";
					//sPara += "'" + _itemGroupCode.Replace("00", " ").Trim()                     + "' ";					
					sPara += "'" + "01"        + "' ";	
					sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_itemCd, " ").Trim()   + "' ";
					FlexVJ_Common.Report.Form_RdViewer MyReport = new FlexVJ_Common.Report.Form_RdViewer(sDir, sPara);
					MyReport.Text = "Usage Information By Option";
					MyReport.Show();

				}
				else if (cmb_Option.SelectedValue.ToString() =="2")
				{

					string sDir = FlexVJ_Common.ClassLib.ComFunction.Set_RD_Directory("Form_SVM_Usage_By_Option_02");

					string sPara  = " /rp ";
					sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")        + "' ";
					sPara += "'" + this.dpick_From_Ymd.Text.Replace("-","")             + "' ";
					sPara += "'" + this.dpick_To_Ymd.Text.Replace("-","")               + "' ";
					//sPara += "'" + _itemGroupCode.Replace("00", " ").Trim()                     + "' ";					
					sPara += "'" + "01"        + "' ";	
					sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_itemCd, " ")  + "' ";

					FlexVJ_Common.Report.Form_RdViewer MyReport = new FlexVJ_Common.Report.Form_RdViewer(sDir, sPara);
					MyReport.Text = "Usage Information By Option";
					MyReport.Show();

				}
				else if (cmb_Option.SelectedValue.ToString() =="3")
				{

					string sDir = FlexVJ_Common.ClassLib.ComFunction.Set_RD_Directory("Form_SVM_Usage_By_Option_03");

					string sPara  = " /rp ";
					sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")          + "' ";
					sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_style_code, "") + "' ";
					sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txtSize, "")        + "' ";

					FlexVJ_Common.Report.Form_RdViewer MyReport = new FlexVJ_Common.Report.Form_RdViewer(sDir, sPara);
					MyReport.Text = "Material Yield/U-Price List By Style";
					MyReport.Show();

				}
				else if (cmb_Option.SelectedValue.ToString() =="4")
				{

					string sDir = FlexVJ_Common.ClassLib.ComFunction.Set_RD_Directory("Form_SVM_Usage_By_Option_04");

					string sPara  = " /rp ";
					sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, " ")          + "' ";
					sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_itemCd, "") + "' ";
					sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_itemNm, "")        + "' ";
//					sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_itemNm, "")      + "' ";

					FlexVJ_Common.Report.Form_RdViewer MyReport = new FlexVJ_Common.Report.Form_RdViewer(sDir, sPara);
					MyReport.Text = "Style List By Item";
					MyReport.Show();

				}

			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}

		}

		private void Set_Option_Print(string arg_flag)
		{	
			dpick_From_Ymd.Value = DateTime.Now;
			dpick_To_Ymd.Value   = DateTime.Now;
			cmb_itemGroup.SelectedIndex = -1;
			txt_itemGroup.Clear();
			txt_itemCd.Clear();
			txt_itemNm.Clear();

			_itemGroupCode = "";

			if ((cmb_Option.SelectedIndex == 1)||
			    (cmb_Option.SelectedIndex == 2) )
			{
				dpick_From_Ymd.Enabled  = true;
				dpick_To_Ymd.Enabled    = true;
				cmb_itemGroup.Enabled   = true;
				btn_groupSearch.Enabled = true;
				txt_itemCd.Enabled      = true;
				txt_itemNm.Enabled      = true;

				txt_style_name.Enabled  = false;
				cmb_style.Enabled       = false;
				txtSize.Enabled         = false;	
			}
			else if (cmb_Option.SelectedIndex == 3)
			{
				dpick_From_Ymd.Enabled  = false;
				dpick_To_Ymd.Enabled    = false;
				cmb_itemGroup.Enabled   = false;
				btn_groupSearch.Enabled = false;
				txt_itemCd.Enabled      = false;
				txt_itemNm.Enabled      = false;

				txt_style_name.Enabled  = true;
				cmb_style.Enabled       = true;
				txtSize.Enabled         = true;			
			}
			else if (cmb_Option.SelectedIndex == 4)
			{
				dpick_From_Ymd.Enabled  = false;
				dpick_To_Ymd.Enabled    = false;
				cmb_itemGroup.Enabled   = false;
				btn_groupSearch.Enabled = false;
				txt_itemCd.Enabled      = true;
				txt_itemNm.Enabled      = true;

				txt_style_name.Enabled  = false;
				cmb_style.Enabled       = false;
				txtSize.Enabled         = false;
			}

		}

		#endregion

		#region 이벤트 처리



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
			Set_Option_Print("");
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

				//if (cmb_Option.SelectedValue.ToString() =="4" || cmb_Option.SelectedValue.ToString() =="8")
				if(txt_itemGroup.Enabled)
				{
					txt_itemCd.Text	= "";
				}

				vPopup.Dispose(); 

			}
			catch (Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				//ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		#endregion

		private void cmb_style_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void cmb_style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_style.SelectedIndex == -1) return;
			 
			txt_style_name.Text = cmb_style.Columns[1].Text;
			txt_style_code.Text = cmb_style.Columns[0].Text;		
		}

		private void txt_style_name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar != 13) return;

			Event_KeyPress_txt_style(); 				
		}

		private void Event_KeyPress_txt_style()
		{

			DataTable dt_ret = Select_Style_List();

			// 프로그램 리스트 추가
			COM.ComCtl.Set_ComboList(dt_ret, cmb_style, 0, 1);

			cmb_style.Splits[0].DisplayColumns[0].Width = 80;
			cmb_style.Splits[0].DisplayColumns[1].Width = 180;				
		}

		private DataTable Select_Style_List()
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SVM_USAGE_REPORT.SELECT_SDC_STYLE";

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_STYLE_NM";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의   
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_TextBox(txt_style_name , "");
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}


	}


}