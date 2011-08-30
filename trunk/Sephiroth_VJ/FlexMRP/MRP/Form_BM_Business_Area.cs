using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexMRP.MRP
{
	public class Form_BM_Business_Area : COM.PCHWinForm.Pop_Medium
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label btn_new;
		private System.Windows.Forms.Label btn_save;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_shipType;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label btn_delete;
		private C1.Win.C1List.C1Combo cmb_areaCode;
		private System.Windows.Forms.Label lbl_areaCode;
		private System.Windows.Forms.TextBox txt_areaName;
		private System.Windows.Forms.ColorDialog color;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		int _foreColor = (int)ClassLib.TBSBM_BUSINESS_AREA.IxFORE_COLOR;
		int _backColor = (int)ClassLib.TBSBM_BUSINESS_AREA.IxBACK_COLOR;
		int _foreCode = (int)ClassLib.TBSBM_BUSINESS_AREA.IxFORE_CODE;
		int _backCode = (int)ClassLib.TBSBM_BUSINESS_AREA.IxBACK_CODE;

		#endregion

		#region 생성자 / 소멸자

		public Form_BM_Business_Area()
		{
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BM_Business_Area));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_recover = new System.Windows.Forms.Label();
			this.btn_insert = new System.Windows.Forms.Label();
			this.btn_delete = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_areaName = new System.Windows.Forms.TextBox();
			this.btn_new = new System.Windows.Forms.Label();
			this.btn_save = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.cmb_areaCode = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.lbl_shipType = new System.Windows.Forms.Label();
			this.btn_search = new System.Windows.Forms.Label();
			this.lbl_areaCode = new System.Windows.Forms.Label();
			this.spd_main = new COM.SSP();
			this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
			this.color = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_areaCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
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
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.Controls.Add(this.panel1);
			this.c1Sizer1.Controls.Add(this.groupBox1);
			this.c1Sizer1.Controls.Add(this.spd_main);
			this.c1Sizer1.GridDefinition = "15.8878504672897:False:False;71.4953271028037:False:False;7.00934579439252:False:" +
				"False;0.934579439252336:False:True;\t0.576368876080692:False:True;96.541786743515" +
				"9:False:False;0.576368876080692:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
			this.c1Sizer1.TabIndex = 26;
			this.c1Sizer1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.btn_recover);
			this.panel1.Controls.Add(this.btn_insert);
			this.panel1.Controls.Add(this.btn_delete);
			this.panel1.Location = new System.Drawing.Point(12, 386);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(670, 30);
			this.panel1.TabIndex = 31;
			// 
			// btn_recover
			// 
			this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_recover.Image = ((System.Drawing.Image)(resources.GetObject("btn_recover.Image")));
			this.btn_recover.Location = new System.Drawing.Point(589, 3);
			this.btn_recover.Name = "btn_recover";
			this.btn_recover.Size = new System.Drawing.Size(80, 24);
			this.btn_recover.TabIndex = 354;
			this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_recover.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_insert
			// 
			this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_insert.Image = ((System.Drawing.Image)(resources.GetObject("btn_insert.Image")));
			this.btn_insert.Location = new System.Drawing.Point(427, 3);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(80, 24);
			this.btn_insert.TabIndex = 353;
			this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_delete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
			this.btn_delete.Location = new System.Drawing.Point(508, 3);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 24);
			this.btn_delete.TabIndex = 352;
			this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_areaName);
			this.groupBox1.Controls.Add(this.btn_new);
			this.groupBox1.Controls.Add(this.btn_save);
			this.groupBox1.Controls.Add(this.cmb_factory);
			this.groupBox1.Controls.Add(this.cmb_areaCode);
			this.groupBox1.Controls.Add(this.lbl_factory);
			this.groupBox1.Controls.Add(this.lbl_shipType);
			this.groupBox1.Controls.Add(this.btn_search);
			this.groupBox1.Controls.Add(this.lbl_areaCode);
			this.groupBox1.Location = new System.Drawing.Point(12, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(670, 68);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			// 
			// txt_areaName
			// 
			this.txt_areaName.BackColor = System.Drawing.SystemColors.Window;
			this.txt_areaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_areaName.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_areaName.Location = new System.Drawing.Point(109, 38);
			this.txt_areaName.MaxLength = 4;
			this.txt_areaName.Name = "txt_areaName";
			this.txt_areaName.Size = new System.Drawing.Size(200, 21);
			this.txt_areaName.TabIndex = 360;
			this.txt_areaName.Text = "";
			// 
			// btn_new
			// 
			this.btn_new.ImageIndex = 15;
			this.btn_new.ImageList = this.img_SmallButton;
			this.btn_new.Location = new System.Drawing.Point(610, 38);
			this.btn_new.Name = "btn_new";
			this.btn_new.Size = new System.Drawing.Size(21, 21);
			this.btn_new.TabIndex = 186;
			this.btn_new.Tag = "Search";
			this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
			this.btn_new.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_new_MouseUp);
			this.btn_new.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_new_MouseDown);
			// 
			// btn_save
			// 
			this.btn_save.ImageIndex = 25;
			this.btn_save.ImageList = this.img_SmallButton;
			this.btn_save.Location = new System.Drawing.Point(632, 38);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(21, 21);
			this.btn_save.TabIndex = 185;
			this.btn_save.Tag = "Search";
			this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			this.btn_save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseUp);
			this.btn_save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseDown);
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
			this.cmb_factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_factory.TabIndex = 1;
			// 
			// cmb_areaCode
			// 
			this.cmb_areaCode.AddItemCols = 0;
			this.cmb_areaCode.AddItemSeparator = ';';
			this.cmb_areaCode.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_areaCode.AutoSize = false;
			this.cmb_areaCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_areaCode.Caption = "";
			this.cmb_areaCode.CaptionHeight = 17;
			this.cmb_areaCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_areaCode.ColumnCaptionHeight = 18;
			this.cmb_areaCode.ColumnFooterHeight = 18;
			this.cmb_areaCode.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_areaCode.ContentHeight = 17;
			this.cmb_areaCode.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_areaCode.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_areaCode.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_areaCode.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_areaCode.EditorHeight = 17;
			this.cmb_areaCode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_areaCode.GapHeight = 2;
			this.cmb_areaCode.ItemHeight = 15;
			this.cmb_areaCode.Location = new System.Drawing.Point(431, 16);
			this.cmb_areaCode.MatchEntryTimeout = ((long)(2000));
			this.cmb_areaCode.MaxDropDownItems = ((short)(5));
			this.cmb_areaCode.MaxLength = 32767;
			this.cmb_areaCode.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_areaCode.Name = "cmb_areaCode";
			this.cmb_areaCode.PartialRightColumn = false;
			this.cmb_areaCode.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_areaCode.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_areaCode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_areaCode.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_areaCode.Size = new System.Drawing.Size(200, 21);
			this.cmb_areaCode.TabIndex = 3;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 1;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 16);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 180;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_shipType
			// 
			this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_shipType.ImageIndex = 0;
			this.lbl_shipType.ImageList = this.img_Label;
			this.lbl_shipType.Location = new System.Drawing.Point(8, 38);
			this.lbl_shipType.Name = "lbl_shipType";
			this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
			this.lbl_shipType.TabIndex = 52;
			this.lbl_shipType.Text = "Area Name";
			this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_search
			// 
			this.btn_search.ImageIndex = 27;
			this.btn_search.ImageList = this.img_SmallButton;
			this.btn_search.Location = new System.Drawing.Point(632, 16);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(21, 21);
			this.btn_search.TabIndex = 184;
			this.btn_search.Tag = "Search";
			this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			this.btn_search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
			this.btn_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
			// 
			// lbl_areaCode
			// 
			this.lbl_areaCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_areaCode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_areaCode.ImageIndex = 0;
			this.lbl_areaCode.ImageList = this.img_Label;
			this.lbl_areaCode.Location = new System.Drawing.Point(330, 16);
			this.lbl_areaCode.Name = "lbl_areaCode";
			this.lbl_areaCode.Size = new System.Drawing.Size(100, 21);
			this.lbl_areaCode.TabIndex = 52;
			this.lbl_areaCode.Text = "Area Code";
			this.lbl_areaCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// spd_main
			// 
			this.spd_main.Location = new System.Drawing.Point(12, 76);
			this.spd_main.Name = "spd_main";
			this.spd_main.Sheets.Add(this.spd_main_Sheet1);
			this.spd_main.Size = new System.Drawing.Size(670, 306);
			this.spd_main.TabIndex = 0;
			this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
			this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
			this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
			// 
			// spd_main_Sheet1
			// 
			this.spd_main_Sheet1.SheetName = "Sheet1";
			// 
			// Form_BM_Business_Area
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_BM_Business_Area";
			this.Load += new System.EventHandler(this.Form_Load);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_areaCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
			this.Grid_EditModeOnProcess(spd_main) ;
		}

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			spd_main.Update_Row(img_Action);
		}

		#endregion

		#region 컨트롤 이벤트

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		private void btn_new_Click(object sender, System.EventArgs e)
		{
			this.btn_NewProcess();
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			this.btn_SearchProcess();
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			this.btn_SaveProcess();
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			this.Btn_InsertProcess();
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			this.Btn_DeleteProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Btn_CancelProcess();
		}

		#region 버튼 클릭

		private void btn_search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_search.ImageIndex = 27;
		}

		private void btn_search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_search.ImageIndex = 26;
		}

		private void btn_save_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_save.ImageIndex = 25;
		}

		private void btn_save_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_save.ImageIndex = 24;		
		}

		private void btn_new_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_new.ImageIndex = 15;		
		}

		private void btn_new_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_new.ImageIndex = 14;
		}

		#endregion
	
		#endregion

		#region 이벤트 처리 메서드

		#region 초기화

		private void Init_Form()
		{
			this.Text = "Business Area";
			lbl_MainTitle.Text = "Business Area";

			// factory set
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose() ;

			// area code set
			vDt = SELECT_AREA_CODE(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_areaCode, 0, 1, true);
			cmb_areaCode.SelectedIndex = 0;
			vDt.Dispose() ;

			// grid set
			spd_main.Set_Spread_Comm("SBM_BUSINESS_AREA", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			
			for (int vCol = 0 ; vCol < spd_main.Sheets[0].ColumnCount ; vCol++)
			{
				if (spd_main.Sheets[0].ColumnHeader.Cells[1, vCol].Text.Equals(spd_main.Sheets[0].ColumnHeader.Cells[2, vCol].Text))
				{
					spd_main.Sheets[0].ColumnHeader.Cells[1, vCol].RowSpan = 2;
				}
				else
				{					
					if (spd_main.Sheets[0].ColumnHeader.Cells[1, vCol].Text.Equals(spd_main.Sheets[0].ColumnHeader.Cells[1, vCol + 1].Text))
					{
						spd_main.Sheets[0].ColumnHeader.Cells[1, vCol].ColumnSpan = 2;
                        vCol++;
					}					
				}
			}
		}

		#endregion

		#region 툴바 메뉴 이벤트

		private void btn_NewProcess()
		{
			try
			{
				spd_main.ClearAll();
				txt_areaName.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
		}

		private void btn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vAreaCode = COM.ComFunction.Empty_Combo(cmb_areaCode, "");
				string vAreaName = COM.ComFunction.Empty_TextBox(txt_areaName, "");

                DataTable vDt = this.SELECT_SBM_BUSINESS_AREA(vFactory, vAreaCode, vAreaName);

				if (vDt.Rows.Count > 0)
				{
					spd_main.Sheets[0].RowCount = 0;
					spd_main.Display_Grid(vDt);

					for (int i = 0 ; i < spd_main.Sheets[0].RowCount ; i++)
					{
						if (!spd_main.Sheets[0].Cells[i, _foreCode].Text.Equals(""))
							spd_main.Sheets[0].Cells[i, _foreColor].BackColor = Color.FromArgb(Convert.ToInt32(spd_main.Sheets[0].Cells[i, _foreCode].Text));
						if (!spd_main.Sheets[0].Cells[i, _backCode].Text.Equals(""))
							spd_main.Sheets[0].Cells[i, _backColor].BackColor = Color.FromArgb(Convert.ToInt32(spd_main.Sheets[0].Cells[i, _backCode].Text));
					}
				}
				else
				{
					spd_main.ClearAll();
				}			

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void btn_SaveProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					MyOraDB.Save_Spread("PKG_SBM_BUSINESS_AREA.SAVE_SBM_BUSINESS_AREA", spd_main);

					// area code set
					DataTable vDt = SELECT_AREA_CODE(ClassLib.ComVar.This_Factory);
					COM.ComCtl.Set_ComboList(vDt, cmb_areaCode, 0, 1, true);
					cmb_areaCode.SelectedIndex = 0;
					vDt.Dispose() ;

					spd_main.Refresh_Division();
				}

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
			}
			catch (Exception ex)
			{			
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		#endregion

		#region 컨트롤 이벤트

		private void Btn_InsertProcess()
		{
			int vRow = spd_main.Add_Row(img_Action);
			spd_main.Sheets[0].Cells[vRow, (int)ClassLib.TBSBM_BUSINESS_AREA.IxFACTORY].Text = COM.ComVar.This_Factory;
		}

		private void Btn_DeleteProcess()
		{
			spd_main.Delete_Row(img_Action);
		}

		private void Btn_CancelProcess()
		{
			spd_main.Recovery();
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
			if (vTemp == "CheckBoxCellType" )
			{
				arg_grid.Buffer_CellData = "000" ;
				arg_grid.Update_Row(img_Action) ;
			}
		}

		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (e.Column == _foreColor || e.Column == _backColor)
			{
				color.Color = spd_main.Sheets[0].Cells[e.Row, e.Column].BackColor;
				if (color.ShowDialog(spd_main) == DialogResult.OK)
				{
					if (e.Column == _foreColor)
					{
						spd_main.Sheets[0].Cells[e.Row, e.Column].BackColor = color.Color;
						spd_main.Sheets[0].Cells[e.Row, _foreCode].Text = color.Color.ToArgb().ToString();
					}
					else
					{
						spd_main.Sheets[0].Cells[e.Row, e.Column].BackColor = color.Color;
						spd_main.Sheets[0].Cells[e.Row, _backCode].Text = color.Color.ToArgb().ToString();
					}

					spd_main.Update_Row(e.Row, img_Action);
				}

				e.Cancel = true;
			}
		}

		#endregion

		#endregion

		#region DBConnect

		/// <summary>
		/// PKG_SBM_BUSINESS_AREA : BUSINESS AREA 리스트 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBM_BUSINESS_AREA(string arg_factory, string arg_area_cd, string arg_area_name)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_BUSINESS_AREA.SELECT_SBM_BUSINESS_AREA";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_AREA_CD";
			MyOraDB.Parameter_Name[2] = "ARG_AREA_NAME";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_area_cd;
			MyOraDB.Parameter_Values[2] = arg_area_name;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBM_BUSINESS_AREA : AREA CODE 리스트 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_AREA_CODE(string arg_factory)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_BUSINESS_AREA.SELECT_AREA_CODE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

	}
}

