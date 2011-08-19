using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;


namespace FlexBase.Yield
{
	public class Pop_Style_Mcs : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_Style_From;
		private System.Windows.Forms.Label lbl_Year_From;
		private System.Windows.Forms.Label lbl_Factory_From;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		public COM.FSP fgrid_Mcs_Color;
		private C1.Win.C1List.C1Combo cmb_Style;
		private System.Windows.Forms.TextBox txt_Style;
		private C1.Win.C1List.C1Combo cmb_Season;
		private C1.Win.C1List.C1Combo cmb_Year;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;
		private C1.Win.C1List.C1Combo cmb_Mcs;
		private System.Windows.Forms.TextBox txt_Mcs;
		private System.Windows.Forms.Label lbl_Mcs;
		private C1.Win.C1List.C1Combo cmb_Mcs_Color;
		private System.Windows.Forms.TextBox txt_Mcs_Color;
		private System.Windows.Forms.Label lbl_Mcs_Color;
		private System.ComponentModel.IContainer components = null;

		public Pop_Style_Mcs()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Style_Mcs));
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_Mcs_Color = new COM.FSP();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmb_Mcs_Color = new C1.Win.C1List.C1Combo();
			this.txt_Mcs_Color = new System.Windows.Forms.TextBox();
			this.lbl_Mcs_Color = new System.Windows.Forms.Label();
			this.cmb_Mcs = new C1.Win.C1List.C1Combo();
			this.txt_Mcs = new System.Windows.Forms.TextBox();
			this.lbl_Mcs = new System.Windows.Forms.Label();
			this.cmb_Style = new C1.Win.C1List.C1Combo();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.cmb_Season = new C1.Win.C1List.C1Combo();
			this.cmb_Year = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Style_From = new System.Windows.Forms.Label();
			this.lbl_Year_From = new System.Windows.Forms.Label();
			this.lbl_Factory_From = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.btn_close = new System.Windows.Forms.Label();
			this.btn_apply = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs_Color)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs_Color)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(370, 23);
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
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.fgrid_Mcs_Color);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.pictureBox9);
			this.panel2.Controls.Add(this.pictureBox10);
			this.panel2.Controls.Add(this.pictureBox11);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox12);
			this.panel2.Controls.Add(this.pictureBox13);
			this.panel2.Controls.Add(this.pictureBox14);
			this.panel2.Controls.Add(this.pictureBox15);
			this.panel2.Controls.Add(this.pictureBox16);
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(-3, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(400, 504);
			this.panel2.TabIndex = 168;
			// 
			// fgrid_Mcs_Color
			// 
			this.fgrid_Mcs_Color.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Mcs_Color.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Mcs_Color.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Mcs_Color.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Mcs_Color.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fgrid_Mcs_Color.Location = new System.Drawing.Point(8, 165);
			this.fgrid_Mcs_Color.Name = "fgrid_Mcs_Color";
			this.fgrid_Mcs_Color.Size = new System.Drawing.Size(383, 340);
			this.fgrid_Mcs_Color.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Mcs_Color.TabIndex = 170;
			this.fgrid_Mcs_Color.DoubleClick += new System.EventHandler(this.fgrid_Mcs_Color_DoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmb_Mcs_Color);
			this.groupBox1.Controls.Add(this.txt_Mcs_Color);
			this.groupBox1.Controls.Add(this.lbl_Mcs_Color);
			this.groupBox1.Controls.Add(this.cmb_Mcs);
			this.groupBox1.Controls.Add(this.txt_Mcs);
			this.groupBox1.Controls.Add(this.lbl_Mcs);
			this.groupBox1.Controls.Add(this.cmb_Style);
			this.groupBox1.Controls.Add(this.txt_Style);
			this.groupBox1.Controls.Add(this.cmb_Season);
			this.groupBox1.Controls.Add(this.cmb_Year);
			this.groupBox1.Controls.Add(this.cmb_Factory);
			this.groupBox1.Controls.Add(this.lbl_Style_From);
			this.groupBox1.Controls.Add(this.lbl_Year_From);
			this.groupBox1.Controls.Add(this.lbl_Factory_From);
			this.groupBox1.Location = new System.Drawing.Point(7, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(386, 133);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source";
			// 
			// cmb_Mcs_Color
			// 
			this.cmb_Mcs_Color.AddItemCols = 0;
			this.cmb_Mcs_Color.AddItemSeparator = ';';
			this.cmb_Mcs_Color.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Mcs_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Mcs_Color.Caption = "";
			this.cmb_Mcs_Color.CaptionHeight = 17;
			this.cmb_Mcs_Color.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Mcs_Color.ColumnCaptionHeight = 18;
			this.cmb_Mcs_Color.ColumnFooterHeight = 18;
			this.cmb_Mcs_Color.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Mcs_Color.ContentHeight = 17;
			this.cmb_Mcs_Color.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Mcs_Color.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Mcs_Color.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs_Color.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Mcs_Color.EditorHeight = 17;
			this.cmb_Mcs_Color.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs_Color.GapHeight = 2;
			this.cmb_Mcs_Color.ItemHeight = 15;
			this.cmb_Mcs_Color.Location = new System.Drawing.Point(242, 102);
			this.cmb_Mcs_Color.MatchEntryTimeout = ((long)(2000));
			this.cmb_Mcs_Color.MaxDropDownItems = ((short)(5));
			this.cmb_Mcs_Color.MaxLength = 32767;
			this.cmb_Mcs_Color.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Mcs_Color.Name = "cmb_Mcs_Color";
			this.cmb_Mcs_Color.PartialRightColumn = false;
			this.cmb_Mcs_Color.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Mcs_Color.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Mcs_Color.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Mcs_Color.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Mcs_Color.Size = new System.Drawing.Size(132, 21);
			this.cmb_Mcs_Color.TabIndex = 184;
			this.cmb_Mcs_Color.TextChanged += new System.EventHandler(this.cmb_Mcs_Color_TextChanged);
			// 
			// txt_Mcs_Color
			// 
			this.txt_Mcs_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs_Color.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Mcs_Color.Location = new System.Drawing.Point(110, 102);
			this.txt_Mcs_Color.Name = "txt_Mcs_Color";
			this.txt_Mcs_Color.Size = new System.Drawing.Size(132, 21);
			this.txt_Mcs_Color.TabIndex = 183;
			this.txt_Mcs_Color.Text = "";
			this.txt_Mcs_Color.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mcs_Color_KeyPress);
			// 
			// lbl_Mcs_Color
			// 
			this.lbl_Mcs_Color.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Mcs_Color.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Mcs_Color.ImageIndex = 1;
			this.lbl_Mcs_Color.ImageList = this.img_Label;
			this.lbl_Mcs_Color.Location = new System.Drawing.Point(8, 102);
			this.lbl_Mcs_Color.Name = "lbl_Mcs_Color";
			this.lbl_Mcs_Color.Size = new System.Drawing.Size(100, 21);
			this.lbl_Mcs_Color.TabIndex = 182;
			this.lbl_Mcs_Color.Text = "Mcs Color";
			this.lbl_Mcs_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Mcs
			// 
			this.cmb_Mcs.AddItemCols = 0;
			this.cmb_Mcs.AddItemSeparator = ';';
			this.cmb_Mcs.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Mcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Mcs.Caption = "";
			this.cmb_Mcs.CaptionHeight = 17;
			this.cmb_Mcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Mcs.ColumnCaptionHeight = 18;
			this.cmb_Mcs.ColumnFooterHeight = 18;
			this.cmb_Mcs.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Mcs.ContentHeight = 17;
			this.cmb_Mcs.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Mcs.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Mcs.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Mcs.EditorHeight = 17;
			this.cmb_Mcs.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs.GapHeight = 2;
			this.cmb_Mcs.ItemHeight = 15;
			this.cmb_Mcs.Location = new System.Drawing.Point(242, 80);
			this.cmb_Mcs.MatchEntryTimeout = ((long)(2000));
			this.cmb_Mcs.MaxDropDownItems = ((short)(5));
			this.cmb_Mcs.MaxLength = 32767;
			this.cmb_Mcs.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Mcs.Name = "cmb_Mcs";
			this.cmb_Mcs.PartialRightColumn = false;
			this.cmb_Mcs.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Mcs.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Mcs.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Mcs.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Mcs.Size = new System.Drawing.Size(132, 21);
			this.cmb_Mcs.TabIndex = 181;
			this.cmb_Mcs.TextChanged += new System.EventHandler(this.cmb_Mcs_TextChanged);
			// 
			// txt_Mcs
			// 
			this.txt_Mcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Mcs.Location = new System.Drawing.Point(110, 80);
			this.txt_Mcs.Name = "txt_Mcs";
			this.txt_Mcs.Size = new System.Drawing.Size(132, 21);
			this.txt_Mcs.TabIndex = 180;
			this.txt_Mcs.Text = "";
			this.txt_Mcs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mcs_KeyPress);
			// 
			// lbl_Mcs
			// 
			this.lbl_Mcs.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Mcs.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Mcs.ImageIndex = 1;
			this.lbl_Mcs.ImageList = this.img_Label;
			this.lbl_Mcs.Location = new System.Drawing.Point(8, 80);
			this.lbl_Mcs.Name = "lbl_Mcs";
			this.lbl_Mcs.Size = new System.Drawing.Size(100, 21);
			this.lbl_Mcs.TabIndex = 179;
			this.lbl_Mcs.Text = "Mcs";
			this.lbl_Mcs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Style
			// 
			this.cmb_Style.AddItemCols = 0;
			this.cmb_Style.AddItemSeparator = ';';
			this.cmb_Style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Style.Caption = "";
			this.cmb_Style.CaptionHeight = 17;
			this.cmb_Style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Style.ColumnCaptionHeight = 18;
			this.cmb_Style.ColumnFooterHeight = 18;
			this.cmb_Style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Style.ContentHeight = 17;
			this.cmb_Style.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Style.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Style.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Style.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Style.EditorHeight = 17;
			this.cmb_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Style.GapHeight = 2;
			this.cmb_Style.ItemHeight = 15;
			this.cmb_Style.Location = new System.Drawing.Point(242, 58);
			this.cmb_Style.MatchEntryTimeout = ((long)(2000));
			this.cmb_Style.MaxDropDownItems = ((short)(5));
			this.cmb_Style.MaxLength = 32767;
			this.cmb_Style.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Style.Name = "cmb_Style";
			this.cmb_Style.PartialRightColumn = false;
			this.cmb_Style.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Style.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Style.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Style.Size = new System.Drawing.Size(132, 21);
			this.cmb_Style.TabIndex = 178;
			this.cmb_Style.TextChanged += new System.EventHandler(this.cmb_Style_TextChanged);
			// 
			// txt_Style
			// 
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Style.Location = new System.Drawing.Point(110, 58);
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.Size = new System.Drawing.Size(132, 21);
			this.txt_Style.TabIndex = 177;
			this.txt_Style.Text = "";
			this.txt_Style.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Style_KeyUp);
			// 
			// cmb_Season
			// 
			this.cmb_Season.AddItemCols = 0;
			this.cmb_Season.AddItemSeparator = ';';
			this.cmb_Season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Season.Caption = "";
			this.cmb_Season.CaptionHeight = 17;
			this.cmb_Season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Season.ColumnCaptionHeight = 18;
			this.cmb_Season.ColumnFooterHeight = 18;
			this.cmb_Season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Season.ContentHeight = 17;
			this.cmb_Season.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Season.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Season.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Season.EditorHeight = 17;
			this.cmb_Season.Enabled = false;
			this.cmb_Season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season.GapHeight = 2;
			this.cmb_Season.ItemHeight = 15;
			this.cmb_Season.Location = new System.Drawing.Point(242, 36);
			this.cmb_Season.MatchEntryTimeout = ((long)(2000));
			this.cmb_Season.MaxDropDownItems = ((short)(5));
			this.cmb_Season.MaxLength = 32767;
			this.cmb_Season.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Season.Name = "cmb_Season";
			this.cmb_Season.PartialRightColumn = false;
			this.cmb_Season.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Season.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Season.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Season.Size = new System.Drawing.Size(132, 21);
			this.cmb_Season.TabIndex = 176;
			// 
			// cmb_Year
			// 
			this.cmb_Year.AddItemCols = 0;
			this.cmb_Year.AddItemSeparator = ';';
			this.cmb_Year.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Year.Caption = "";
			this.cmb_Year.CaptionHeight = 17;
			this.cmb_Year.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Year.ColumnCaptionHeight = 18;
			this.cmb_Year.ColumnFooterHeight = 18;
			this.cmb_Year.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Year.ContentHeight = 17;
			this.cmb_Year.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			this.cmb_Year.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Year.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Year.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Year.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Year.EditorHeight = 17;
			this.cmb_Year.Enabled = false;
			this.cmb_Year.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Year.GapHeight = 2;
			this.cmb_Year.ItemHeight = 15;
			this.cmb_Year.Location = new System.Drawing.Point(110, 36);
			this.cmb_Year.MatchEntryTimeout = ((long)(2000));
			this.cmb_Year.MaxDropDownItems = ((short)(5));
			this.cmb_Year.MaxLength = 32767;
			this.cmb_Year.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Year.Name = "cmb_Year";
			this.cmb_Year.PartialRightColumn = false;
			this.cmb_Year.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Year.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Year.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Year.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Year.Size = new System.Drawing.Size(132, 21);
			this.cmb_Year.TabIndex = 175;
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory.Caption = "";
			this.cmb_Factory.CaptionHeight = 17;
			this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory.ColumnCaptionHeight = 18;
			this.cmb_Factory.ColumnFooterHeight = 18;
			this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.Enabled = false;
			this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(110, 14);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(265, 21);
			this.cmb_Factory.TabIndex = 174;
			// 
			// lbl_Style_From
			// 
			this.lbl_Style_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Style_From.ImageIndex = 1;
			this.lbl_Style_From.ImageList = this.img_Label;
			this.lbl_Style_From.Location = new System.Drawing.Point(8, 59);
			this.lbl_Style_From.Name = "lbl_Style_From";
			this.lbl_Style_From.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style_From.TabIndex = 173;
			this.lbl_Style_From.Text = "Style Code";
			this.lbl_Style_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Year_From
			// 
			this.lbl_Year_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Year_From.ImageIndex = 1;
			this.lbl_Year_From.ImageList = this.img_Label;
			this.lbl_Year_From.Location = new System.Drawing.Point(8, 36);
			this.lbl_Year_From.Name = "lbl_Year_From";
			this.lbl_Year_From.Size = new System.Drawing.Size(100, 21);
			this.lbl_Year_From.TabIndex = 172;
			this.lbl_Year_From.Text = "Year/Season";
			this.lbl_Year_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory_From
			// 
			this.lbl_Factory_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory_From.ImageIndex = 1;
			this.lbl_Factory_From.ImageList = this.img_Label;
			this.lbl_Factory_From.Location = new System.Drawing.Point(8, 13);
			this.lbl_Factory_From.Name = "lbl_Factory_From";
			this.lbl_Factory_From.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory_From.TabIndex = 171;
			this.lbl_Factory_From.Text = "Factory";
			this.lbl_Factory_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(299, 30);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(101, 466);
			this.pictureBox9.TabIndex = 26;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(384, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(16, 32);
			this.pictureBox10.TabIndex = 21;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(224, 0);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(352, 32);
			this.pictureBox11.TabIndex = 0;
			this.pictureBox11.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 28;
			this.label2.Text = "      Copy";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(384, 489);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(16, 16);
			this.pictureBox12.TabIndex = 23;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(144, 488);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(352, 18);
			this.pictureBox13.TabIndex = 24;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 489);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(168, 20);
			this.pictureBox14.TabIndex = 22;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(0, 24);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(168, 471);
			this.pictureBox15.TabIndex = 25;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(160, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(352, 464);
			this.pictureBox16.TabIndex = 27;
			this.pictureBox16.TabStop = false;
			// 
			// btn_close
			// 
			this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_close.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_close.ImageIndex = 0;
			this.btn_close.ImageList = this.img_Button;
			this.btn_close.Location = new System.Drawing.Point(330, 539);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(70, 24);
			this.btn_close.TabIndex = 546;
			this.btn_close.Text = "Cancel";
			this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// btn_apply
			// 
			this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_apply.ImageIndex = 0;
			this.btn_apply.ImageList = this.img_Button;
			this.btn_apply.Location = new System.Drawing.Point(258, 539);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(70, 24);
			this.btn_apply.TabIndex = 545;
			this.btn_apply.Text = "Apply";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// Pop_Style_Mcs
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(404, 568);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_apply);
			this.Controls.Add(this.panel2);
			this.Name = "Pop_Style_Mcs";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Style_Mcs_Closing);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.btn_apply, 0);
			this.Controls.SetChildIndex(this.btn_close, 0);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs_Color)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs_Color)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수정의 
		//int _Rowfixed = 2;
		private string vCheck = "";
		private COM.OraDB _MyOraDB = new COM.OraDB();
		#endregion

		#region 멤버메쏘드
		private void Init_Form()
		{
			DataTable dt_list;

			//Title
			this.Text = "Style Mcs";
			lbl_MainTitle.Text = "  Style Mcs";
			ClassLib.ComFunction.SetLangDic(this);

			// 그리드 설정(TBSBC_FORMULAN_YIELD )
			fgrid_Mcs_Color.Set_Grid("SBC_FORMULAN_COLOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			fgrid_Mcs_Color.Set_Action_Image(img_Action);
			fgrid_Mcs_Color.Cols[0].AllowEditing = false;

			// 공장코드
			dt_list = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			//year
			ClassLib.ComFunction.Set_Year(cmb_Year ,ClassLib.ComVar.ConsAll);
						
			// season 
			dt_list =  ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSeason);
			COM.ComCtl.Set_ComboList(dt_list, cmb_Season  , 1, 2,  false, false);
			cmb_Season.SelectedValue    = ClassLib.ComVar.ConsBaseSN;

			dt_list = ClassLib.ComFunction.Select_StyleList(" ");
			COM.ComCtl.Set_ComboList(dt_list, cmb_Style  , 0, 1, false,70,150);


			// Mcs
			dt_list = SelectMcsCode(" ", " ");
			ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Mcs, 0, 1,false,true);

			// Mcs Color
			dt_list = SelectMcsColorCode();
			ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Mcs_Color, 0, 1,false,true);


			dt_list.Dispose();

			SetProperty();	

		}


		private void SetProperty()
		{
			try
			{
				txt_Style.Enabled  = true;
				cmb_Style.Enabled  = true;
				cmb_Mcs.Enabled    = false;
				cmb_Mcs_Color.Enabled  = false;
				txt_Mcs.Enabled   = false;
				txt_Mcs_Color.Enabled  = false;
				vCheck   = ClassLib.ComVar.ConsFalse;

				cmb_Factory.SelectedValue = COM.ComVar.Parameter_PopUp[0]; 
				cmb_Year.SelectedValue    = COM.ComVar.Parameter_PopUp[1]; 
				cmb_Season.SelectedValue  = COM.ComVar.Parameter_PopUp[2]; 
				txt_Style.Text			  = COM.ComVar.Parameter_PopUp[3]; 

				
				// Style
				if (COM.ComVar.Parameter_PopUp[3] == ClassLib.ComVar.ConsBaseStyle)
				{
					cmb_Style.SelectedValue  = txt_Style.Text;
					txt_Style.Enabled  = false;
					cmb_Style.Enabled  = false;
					cmb_Mcs.Enabled    = true;
					cmb_Mcs_Color.Enabled   = true;
					txt_Mcs.Enabled = true;
					txt_Mcs_Color.Enabled  = true;
					
				}

				DataTable dt_ret;
				fgrid_Mcs_Color.Rows.Count = fgrid_Mcs_Color.Rows.Fixed;  
				dt_ret  = SelectStyleMcs();
				if (dt_ret.Rows.Count  == 0) return;

				DisPlayStyleFormula(dt_ret);

				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetProperty", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}



		/// <summary>
		///  DisPlayStyleFormula: Formula 뿌리기
		/// </summary>
		/// <returns></returns>
		private void DisPlayStyleFormula(DataTable arg_dt)
		{
			fgrid_Mcs_Color.Rows.Count = fgrid_Mcs_Color.Rows.Fixed;  
  
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_Mcs_Color.AddItem(arg_dt.Rows[i].ItemArray,fgrid_Mcs_Color.Rows.Count, 1);
				fgrid_Mcs_Color[fgrid_Mcs_Color.Rows.Count - 1, 0] = ""; 
			} 

			fgrid_Mcs_Color.AutoSizeCols();
		}

		

		
		/// <summary>
		/// Search_Color : 데이터 조회
		/// </summary>
		/// <param name="arg_code"></param>
		/// <param name="arg_name"></param>
		private DataTable Search_Color(string arg_code,string arg_name)
		{

			try
			{
				
				DataTable dt_ret; 
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor; 
				
				dt_ret  = this.Select_Sbc_Mcs_Color(arg_code,arg_name);
				
				return dt_ret;
				//dt_ret.Dispose();
 
			}
			catch(Exception ex)
			{  
				return null;

				ClassLib.ComFunction.User_Message(ex.Message, "Search_Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{   
				this.Cursor = System.Windows.Forms.Cursors.Default;
				
			}
		}


		/// <summary>
		/// SetStyleMcs : 데이터 조회
		/// </summary>
		/// <param name="arg_code"></param>
		/// <param name="arg_name"></param>
		private void SetStyleMcs()
		{
			DataTable dt_ret;
			dt_ret  = SelectStyleMcs();

			if (dt_ret.Rows.Count  == 0) return;

			DisPlayStyleFormula(dt_ret);

			dt_ret.Dispose();
		}


		/// <summary>
		/// ReturnValue : 데이터 리턴
		/// </summary>
		private void ReturnValue()
		{
			try
			{
				COM.ComVar.Parameter_PopUp = new string[]
									 {
										 fgrid_Mcs_Color[fgrid_Mcs_Color.Selection.r1,(int)ClassLib.TBSBC_STYLE_MCS.lxMCS_CD].ToString(),
										 fgrid_Mcs_Color[fgrid_Mcs_Color.Selection.r1,(int)ClassLib.TBSBC_STYLE_MCS.lxMCS_NAME].ToString(),
										 fgrid_Mcs_Color[fgrid_Mcs_Color.Selection.r1,(int)ClassLib.TBSBC_STYLE_MCS.lxMCS_COLOR_CD].ToString(),
										 fgrid_Mcs_Color[fgrid_Mcs_Color.Selection.r1,(int)ClassLib.TBSBC_STYLE_MCS.lxMCS_COLOR_NAME].ToString(),
										 txt_Style.Text,
										 ClassLib.ComVar.ConsTrue
									 };
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Pop_Mcs_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}




		#endregion

		#region DB 컨넥트


		
		/// <summary>
		/// SelectMcsCode: Mcs Code  조회
		/// </summary>
		/// <returns></returns>
		/// 
		public DataTable SelectMcsColorCode()
		{

			DataSet ds_ret; int iCnt;
			
			iCnt  =  4;
			_MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			_MyOraDB.Process_Name = "PKG_SBC_MCS_COLOR.SELECT_SBC_COLOR";
 
			//02.ARGURMENT명
			_MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			_MyOraDB.Parameter_Name[1] = "ARG_COLOR_CD";
			_MyOraDB.Parameter_Name[2] = "ARG_COLOR_NAME";
			_MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE
			_MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			_MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[1] = " ";
			_MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_Mcs_Color," ");
			_MyOraDB.Parameter_Values[3] = ""; 

			_MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_MyOraDB.Process_Name]; 
		}



		/// <summary>
		/// SelectMcsCode: Mcs Code  조회
		/// </summary>
		/// <returns></returns>
		public DataTable SelectMcsCode(string  arg_mcs_cd, string  arg_mcs_name)
		{

			DataSet ds_ret; int iCnt;
			
			iCnt  =  3;
			_MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			_MyOraDB.Process_Name = "PKG_SBC_MCS.SELECT_SBC_MCS";
 
			//02.ARGURMENT명
			_MyOraDB.Parameter_Name[0] = "ARG_VALUE1";
			_MyOraDB.Parameter_Name[1] = "ARG_VALUE2";
			_MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			_MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			_MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_mcs_cd," ");
			_MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_String(arg_mcs_name," ");
			_MyOraDB.Parameter_Values[2] = ""; 

			_MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_MyOraDB.Process_Name]; 
		}

		
		/// <summary>
		///Select_SBC_MCS_COLOR : MCS Color 조회
		/// </summary>
		/// <returns></returns>
		public  DataTable Select_Sbc_Mcs_Color(string arg_code,string arg_name)
		{ 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_MCS_COLOR.SELECT_SBC_COLOR";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[2] = "ARG_COLOR_NAME";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
			
			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_code," ");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(arg_name, " ");
			MyOraDB.Parameter_Values[3] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 

		}



		/// <summary>
		///SelectStyleMcs: Style별 Mcs조회
		/// </summary>
		/// <returns></returns>
		public DataTable SelectStyleMcs()
		{

			DataSet ds_ret; int iCnt;
			
			iCnt  =  7;
			_MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			_MyOraDB.Process_Name = "PKG_SBC_FORMULA.SELECT_SBC_STYLE_MCS";
 
			//02.ARGURMENT명
			_MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			_MyOraDB.Parameter_Name[1] = "ARG_FORMULA_YEAR";
			_MyOraDB.Parameter_Name[2] = "ARG_SEASON_CD";
			_MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";	
			_MyOraDB.Parameter_Name[4] = "ARG_MCS_CD";
			_MyOraDB.Parameter_Name[5] = "ARG_MCS_COLOR_CD";		
			_MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE
			_MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			_MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[1] = cmb_Year.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[2] = cmb_Season.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[3] = txt_Style.Text;
			_MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_Mcs," ");
			_MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(cmb_Mcs_Color," ");
			_MyOraDB.Parameter_Values[6] = ""; 

			_MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_MyOraDB.Process_Name]; 


		}




		#endregion

		#region 이벤트처리

		private void fgrid_Mcs_Color_DoubleClick(object sender, System.EventArgs e)
		{
			vCheck  = ClassLib.ComVar.ConsTrue;
			this.Close();
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			vCheck  = ClassLib.ComVar.ConsFalse;
			this.Close();
		}

		
		private void Pop_Style_Mcs_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{

			if  (vCheck  == ClassLib.ComVar.ConsTrue)
			{
				ReturnValue();
			}
			else
			{
				COM.ComVar.Parameter_PopUp = new string[]
										{
											"","","","","",ClassLib.ComVar.ConsFalse
										};
			}

			
		}



		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			vCheck  = ClassLib.ComVar.ConsTrue;
			this.Close();
		}

		private void txt_Style_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{

				if(e.KeyCode != Keys.Enter) return;

				fgrid_Mcs_Color.Rows.Count   = fgrid_Mcs_Color.Rows.Fixed;
				  
				DataTable dt_list;

				dt_list = ClassLib.ComFunction.Select_StyleList(COM.ComFunction.Empty_TextBox(txt_Style, " "));//txt_style_cd.Text == "" ? " " : txt_style_cd.Text);
				COM.ComCtl.Set_ComboList(dt_list, cmb_Style  , 0,1, false);
				cmb_Style.Splits[0].DisplayColumns["Code"].Width = 70;
				cmb_Style.Splits[0].DisplayColumns["Name"].Width = 150;
				dt_list.Dispose();

				

			}
			catch(Exception)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
			} 
		}




		private void cmb_Style_TextChanged(object sender, System.EventArgs e)
		{
		
			
			try
			{

				fgrid_Mcs_Color.Rows.Count  = fgrid_Mcs_Color.Rows.Fixed;

				txt_Style.Text = cmb_Style.SelectedValue.ToString();

				if (( cmb_Style.SelectedIndex == -1) || (txt_Style.Text.ToString().Length != 9))  return;
				
				DataTable dt_ret;
				dt_ret  = SelectStyleMcs();
				if (dt_ret.Rows.Count  == 0) return;

				DisPlayStyleFormula(dt_ret);

				dt_ret.Dispose();

			}
			catch(Exception)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
			} 

		}


		
		private void cmb_Mcs_TextChanged(object sender, System.EventArgs e)
		{
		   
//			fgrid_Mcs_Color.Rows.Count   = fgrid_Mcs_Color.Rows.Fixed;
//
//			SetStyleMcs();
			
		}

		private void cmb_Mcs_Color_TextChanged(object sender, System.EventArgs e)
		{ 
			fgrid_Mcs_Color.Rows.Count   = fgrid_Mcs_Color.Rows.Fixed;

			SetStyleMcs();
			
		}


		private void txt_Mcs_Color_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{


			if(e.KeyChar == (char)13)
			{
				string vcode =  "";
				string vname = ClassLib.ComFunction.Empty_TextBox(txt_Mcs_Color, " ").ToUpper();   //name

				
				DataTable dt_list;

				dt_list = Search_Color(vcode, vname); 

				ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Mcs_Color, 0, 1,false,true);

			}
		}


		private void txt_Mcs_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

			if(e.KeyChar == (char)13)
			{   
				DataTable dt_list;

				string vcode =  "";
				string vname = ClassLib.ComFunction.Empty_TextBox(txt_Mcs, " ").ToUpper();   //name
				dt_list = SelectMcsCode(vcode, vname);

				ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Mcs, 0, 1,false,true);

			}
		}


		#endregion

	}
}

