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
	public class Pop_Formula_Base_Register : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox1;
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
		private C1.Win.C1List.C1Combo cmb_Mcs_Cd;
		private System.Windows.Forms.Label lbl_Mcs_Cd;
		private System.Windows.Forms.Label lbl_Formula_Div;
		private C1.Win.C1List.C1Combo cmb_Formula_Div;
		private COM.FSP fgrid_Formula;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_Save;
		private C1.Win.C1List.C1Combo cmb_Season;
		private C1.Win.C1List.C1Combo cmb_Year;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.ImageList img_Type;
		private System.Windows.Forms.ContextMenu cmenu_Pop;
		private System.Windows.Forms.MenuItem menu_Item_ins;
		private System.Windows.Forms.MenuItem menu_Item_del;
		private System.Windows.Forms.CheckBox chkSpec;
		private System.Windows.Forms.Label lbl_Mcs_Color;
		private C1.Win.C1List.C1Combo cmb_Mcs_Color_Cd;
		private System.Windows.Forms.Label btn_Mcs;
		private System.Windows.Forms.Label lbl_Delete;
		private System.Windows.Forms.Button btn_BaseMcs;
		private System.Windows.Forms.CheckBox chkKeep;
		private System.Windows.Forms.TextBox txt_Mcs_Color;
		private System.Windows.Forms.TextBox txt_Mcs;
		private System.ComponentModel.IContainer components = null;

		public Pop_Formula_Base_Register()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Formula_Base_Register));
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_Mcs_Color = new System.Windows.Forms.TextBox();
			this.txt_Mcs = new System.Windows.Forms.TextBox();
			this.chkKeep = new System.Windows.Forms.CheckBox();
			this.btn_BaseMcs = new System.Windows.Forms.Button();
			this.btn_Mcs = new System.Windows.Forms.Label();
			this.cmb_Mcs_Color_Cd = new C1.Win.C1List.C1Combo();
			this.lbl_Mcs_Color = new System.Windows.Forms.Label();
			this.chkSpec = new System.Windows.Forms.CheckBox();
			this.cmb_Formula_Div = new C1.Win.C1List.C1Combo();
			this.lbl_Formula_Div = new System.Windows.Forms.Label();
			this.cmb_Mcs_Cd = new C1.Win.C1List.C1Combo();
			this.cmb_Season = new C1.Win.C1List.C1Combo();
			this.cmb_Year = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Mcs_Cd = new System.Windows.Forms.Label();
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
			this.fgrid_Formula = new COM.FSP();
			this.cmenu_Pop = new System.Windows.Forms.ContextMenu();
			this.menu_Item_ins = new System.Windows.Forms.MenuItem();
			this.menu_Item_del = new System.Windows.Forms.MenuItem();
			this.btn_close = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Label();
			this.img_Type = new System.Windows.Forms.ImageList(this.components);
			this.lbl_Delete = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs_Color_Cd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Div)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs_Cd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Formula)).BeginInit();
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
			this.panel2.Location = new System.Drawing.Point(2, 31);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(400, 169);
			this.panel2.TabIndex = 168;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_Mcs_Color);
			this.groupBox1.Controls.Add(this.txt_Mcs);
			this.groupBox1.Controls.Add(this.chkKeep);
			this.groupBox1.Controls.Add(this.btn_BaseMcs);
			this.groupBox1.Controls.Add(this.btn_Mcs);
			this.groupBox1.Controls.Add(this.cmb_Mcs_Color_Cd);
			this.groupBox1.Controls.Add(this.lbl_Mcs_Color);
			this.groupBox1.Controls.Add(this.chkSpec);
			this.groupBox1.Controls.Add(this.cmb_Formula_Div);
			this.groupBox1.Controls.Add(this.lbl_Formula_Div);
			this.groupBox1.Controls.Add(this.cmb_Mcs_Cd);
			this.groupBox1.Controls.Add(this.cmb_Season);
			this.groupBox1.Controls.Add(this.cmb_Year);
			this.groupBox1.Controls.Add(this.cmb_Factory);
			this.groupBox1.Controls.Add(this.lbl_Mcs_Cd);
			this.groupBox1.Controls.Add(this.lbl_Year_From);
			this.groupBox1.Controls.Add(this.lbl_Factory_From);
			this.groupBox1.Location = new System.Drawing.Point(7, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(386, 133);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source";
			// 
			// txt_Mcs_Color
			// 
			this.txt_Mcs_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs_Color.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Mcs_Color.Location = new System.Drawing.Point(110, 81);
			this.txt_Mcs_Color.Name = "txt_Mcs_Color";
			this.txt_Mcs_Color.Size = new System.Drawing.Size(132, 21);
			this.txt_Mcs_Color.TabIndex = 682;
			this.txt_Mcs_Color.Text = "";
			this.txt_Mcs_Color.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mcs_Color_KeyPress);
			// 
			// txt_Mcs
			// 
			this.txt_Mcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Mcs.Location = new System.Drawing.Point(110, 59);
			this.txt_Mcs.Name = "txt_Mcs";
			this.txt_Mcs.Size = new System.Drawing.Size(132, 21);
			this.txt_Mcs.TabIndex = 681;
			this.txt_Mcs.Text = "";
			this.txt_Mcs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mcs_KeyPress);
			// 
			// chkKeep
			// 
			this.chkKeep.Location = new System.Drawing.Point(357, 105);
			this.chkKeep.Name = "chkKeep";
			this.chkKeep.Size = new System.Drawing.Size(16, 24);
			this.chkKeep.TabIndex = 680;
			// 
			// btn_BaseMcs
			// 
			this.btn_BaseMcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_BaseMcs.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_BaseMcs.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_BaseMcs.Location = new System.Drawing.Point(240, 103);
			this.btn_BaseMcs.Name = "btn_BaseMcs";
			this.btn_BaseMcs.Size = new System.Drawing.Size(112, 23);
			this.btn_BaseMcs.TabIndex = 679;
			this.btn_BaseMcs.Text = "Base Formula";
			this.btn_BaseMcs.Click += new System.EventHandler(this.btn_BaseMcs_Click);
			// 
			// btn_Mcs
			// 
			this.btn_Mcs.ImageIndex = 27;
			this.btn_Mcs.ImageList = this.img_SmallButton;
			this.btn_Mcs.Location = new System.Drawing.Point(355, 59);
			this.btn_Mcs.Name = "btn_Mcs";
			this.btn_Mcs.Size = new System.Drawing.Size(21, 21);
			this.btn_Mcs.TabIndex = 670;
			this.btn_Mcs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Mcs.Click += new System.EventHandler(this.btn_Mcs_Click);
			// 
			// cmb_Mcs_Color_Cd
			// 
			this.cmb_Mcs_Color_Cd.AddItemCols = 0;
			this.cmb_Mcs_Color_Cd.AddItemSeparator = ';';
			this.cmb_Mcs_Color_Cd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Mcs_Color_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Mcs_Color_Cd.Caption = "";
			this.cmb_Mcs_Color_Cd.CaptionHeight = 17;
			this.cmb_Mcs_Color_Cd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Mcs_Color_Cd.ColumnCaptionHeight = 18;
			this.cmb_Mcs_Color_Cd.ColumnFooterHeight = 18;
			this.cmb_Mcs_Color_Cd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Mcs_Color_Cd.ContentHeight = 17;
			this.cmb_Mcs_Color_Cd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Mcs_Color_Cd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Mcs_Color_Cd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs_Color_Cd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Mcs_Color_Cd.EditorHeight = 17;
			this.cmb_Mcs_Color_Cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs_Color_Cd.GapHeight = 2;
			this.cmb_Mcs_Color_Cd.ItemHeight = 15;
			this.cmb_Mcs_Color_Cd.Location = new System.Drawing.Point(242, 81);
			this.cmb_Mcs_Color_Cd.MatchEntryTimeout = ((long)(2000));
			this.cmb_Mcs_Color_Cd.MaxDropDownItems = ((short)(5));
			this.cmb_Mcs_Color_Cd.MaxLength = 32767;
			this.cmb_Mcs_Color_Cd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Mcs_Color_Cd.Name = "cmb_Mcs_Color_Cd";
			this.cmb_Mcs_Color_Cd.PartialRightColumn = false;
			this.cmb_Mcs_Color_Cd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Mcs_Color_Cd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Mcs_Color_Cd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Mcs_Color_Cd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Mcs_Color_Cd.Size = new System.Drawing.Size(115, 21);
			this.cmb_Mcs_Color_Cd.TabIndex = 183;
			this.cmb_Mcs_Color_Cd.TextChanged += new System.EventHandler(this.cmb_Mcs_Color_Cd_TextChanged);
			// 
			// lbl_Mcs_Color
			// 
			this.lbl_Mcs_Color.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Mcs_Color.ImageIndex = 1;
			this.lbl_Mcs_Color.ImageList = this.img_Label;
			this.lbl_Mcs_Color.Location = new System.Drawing.Point(8, 81);
			this.lbl_Mcs_Color.Name = "lbl_Mcs_Color";
			this.lbl_Mcs_Color.Size = new System.Drawing.Size(100, 21);
			this.lbl_Mcs_Color.TabIndex = 182;
			this.lbl_Mcs_Color.Text = "Mcs Color";
			this.lbl_Mcs_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkSpec
			// 
			this.chkSpec.Location = new System.Drawing.Point(357, 80);
			this.chkSpec.Name = "chkSpec";
			this.chkSpec.Size = new System.Drawing.Size(16, 24);
			this.chkSpec.TabIndex = 181;
			this.chkSpec.CheckedChanged += new System.EventHandler(this.chkSpec_CheckedChanged);
			// 
			// cmb_Formula_Div
			// 
			this.cmb_Formula_Div.AddItemCols = 0;
			this.cmb_Formula_Div.AddItemSeparator = ';';
			this.cmb_Formula_Div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Formula_Div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Formula_Div.Caption = "";
			this.cmb_Formula_Div.CaptionHeight = 17;
			this.cmb_Formula_Div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Formula_Div.ColumnCaptionHeight = 18;
			this.cmb_Formula_Div.ColumnFooterHeight = 18;
			this.cmb_Formula_Div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Formula_Div.ContentHeight = 17;
			this.cmb_Formula_Div.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Formula_Div.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Formula_Div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Formula_Div.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Formula_Div.EditorHeight = 17;
			this.cmb_Formula_Div.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Formula_Div.GapHeight = 2;
			this.cmb_Formula_Div.ItemHeight = 15;
			this.cmb_Formula_Div.Location = new System.Drawing.Point(110, 104);
			this.cmb_Formula_Div.MatchEntryTimeout = ((long)(2000));
			this.cmb_Formula_Div.MaxDropDownItems = ((short)(5));
			this.cmb_Formula_Div.MaxLength = 32767;
			this.cmb_Formula_Div.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Formula_Div.Name = "cmb_Formula_Div";
			this.cmb_Formula_Div.PartialRightColumn = false;
			this.cmb_Formula_Div.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Formula_Div.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Formula_Div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Formula_Div.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Formula_Div.Size = new System.Drawing.Size(130, 21);
			this.cmb_Formula_Div.TabIndex = 180;
			// 
			// lbl_Formula_Div
			// 
			this.lbl_Formula_Div.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Formula_Div.ImageIndex = 1;
			this.lbl_Formula_Div.ImageList = this.img_Label;
			this.lbl_Formula_Div.Location = new System.Drawing.Point(8, 104);
			this.lbl_Formula_Div.Name = "lbl_Formula_Div";
			this.lbl_Formula_Div.Size = new System.Drawing.Size(100, 21);
			this.lbl_Formula_Div.TabIndex = 179;
			this.lbl_Formula_Div.Text = "Formula Division";
			this.lbl_Formula_Div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Mcs_Cd
			// 
			this.cmb_Mcs_Cd.AddItemCols = 0;
			this.cmb_Mcs_Cd.AddItemSeparator = ';';
			this.cmb_Mcs_Cd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Mcs_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Mcs_Cd.Caption = "";
			this.cmb_Mcs_Cd.CaptionHeight = 17;
			this.cmb_Mcs_Cd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Mcs_Cd.ColumnCaptionHeight = 18;
			this.cmb_Mcs_Cd.ColumnFooterHeight = 18;
			this.cmb_Mcs_Cd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Mcs_Cd.ContentHeight = 17;
			this.cmb_Mcs_Cd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Mcs_Cd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Mcs_Cd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs_Cd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Mcs_Cd.EditorHeight = 17;
			this.cmb_Mcs_Cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs_Cd.GapHeight = 2;
			this.cmb_Mcs_Cd.ItemHeight = 15;
			this.cmb_Mcs_Cd.Location = new System.Drawing.Point(242, 59);
			this.cmb_Mcs_Cd.MatchEntryTimeout = ((long)(2000));
			this.cmb_Mcs_Cd.MaxDropDownItems = ((short)(5));
			this.cmb_Mcs_Cd.MaxLength = 32767;
			this.cmb_Mcs_Cd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Mcs_Cd.Name = "cmb_Mcs_Cd";
			this.cmb_Mcs_Cd.PartialRightColumn = false;
			this.cmb_Mcs_Cd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Mcs_Cd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Mcs_Cd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Mcs_Cd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Mcs_Cd.Size = new System.Drawing.Size(115, 21);
			this.cmb_Mcs_Cd.TabIndex = 178;
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(265, 21);
			this.cmb_Factory.TabIndex = 174;
			// 
			// lbl_Mcs_Cd
			// 
			this.lbl_Mcs_Cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Mcs_Cd.ImageIndex = 1;
			this.lbl_Mcs_Cd.ImageList = this.img_Label;
			this.lbl_Mcs_Cd.Location = new System.Drawing.Point(8, 59);
			this.lbl_Mcs_Cd.Name = "lbl_Mcs_Cd";
			this.lbl_Mcs_Cd.Size = new System.Drawing.Size(100, 21);
			this.lbl_Mcs_Cd.TabIndex = 173;
			this.lbl_Mcs_Cd.Text = "Mcs";
			this.lbl_Mcs_Cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Year_From
			// 
			this.lbl_Year_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Year_From.ImageIndex = 1;
			this.lbl_Year_From.ImageList = this.img_Label;
			this.lbl_Year_From.Location = new System.Drawing.Point(8, 37);
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
			this.lbl_Factory_From.Location = new System.Drawing.Point(8, 14);
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
			this.pictureBox9.Size = new System.Drawing.Size(101, 131);
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
			this.label2.Text = "      Base Formula";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(384, 154);
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
			this.pictureBox13.Location = new System.Drawing.Point(144, 153);
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
			this.pictureBox14.Location = new System.Drawing.Point(0, 154);
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
			this.pictureBox15.Size = new System.Drawing.Size(168, 136);
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
			this.pictureBox16.Size = new System.Drawing.Size(352, 129);
			this.pictureBox16.TabIndex = 27;
			this.pictureBox16.TabStop = false;
			// 
			// fgrid_Formula
			// 
			this.fgrid_Formula.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Formula.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Formula.ContextMenu = this.cmenu_Pop;
			this.fgrid_Formula.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Formula.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Formula.Location = new System.Drawing.Point(6, 206);
			this.fgrid_Formula.Name = "fgrid_Formula";
			this.fgrid_Formula.Size = new System.Drawing.Size(394, 330);
			this.fgrid_Formula.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Formula.TabIndex = 661;
			this.fgrid_Formula.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Formula_AfterEdit);
			this.fgrid_Formula.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_Formula_KeyUp);
			// 
			// cmenu_Pop
			// 
			this.cmenu_Pop.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menu_Item_ins,
																					  this.menu_Item_del});
			// 
			// menu_Item_ins
			// 
			this.menu_Item_ins.Index = 0;
			this.menu_Item_ins.Text = "Item Register";
			this.menu_Item_ins.Click += new System.EventHandler(this.menu_Item_Click);
			// 
			// menu_Item_del
			// 
			this.menu_Item_del.Index = 1;
			this.menu_Item_del.Text = "Item Delete";
			this.menu_Item_del.Click += new System.EventHandler(this.menu_Item_del_Click);
			// 
			// btn_close
			// 
			this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_close.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_close.ImageIndex = 0;
			this.btn_close.ImageList = this.img_Button;
			this.btn_close.Location = new System.Drawing.Point(328, 541);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(70, 24);
			this.btn_close.TabIndex = 663;
			this.btn_close.Text = "Cancel";
			this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.ImageIndex = 0;
			this.btn_Save.ImageList = this.img_Button;
			this.btn_Save.Location = new System.Drawing.Point(256, 541);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(70, 24);
			this.btn_Save.TabIndex = 662;
			this.btn_Save.Text = "Save";
			this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// img_Type
			// 
			this.img_Type.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Type.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Type.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Type.ImageStream")));
			this.img_Type.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_Delete
			// 
			this.lbl_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Delete.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Delete.ImageIndex = 0;
			this.lbl_Delete.ImageList = this.img_Button;
			this.lbl_Delete.Location = new System.Drawing.Point(6, 538);
			this.lbl_Delete.Name = "lbl_Delete";
			this.lbl_Delete.Size = new System.Drawing.Size(70, 24);
			this.lbl_Delete.TabIndex = 664;
			this.lbl_Delete.Text = "Delete";
			this.lbl_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_Delete.Click += new System.EventHandler(this.lbl_Delete_Click);
			// 
			// Pop_Formula_Base_Register
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(404, 568);
			this.Controls.Add(this.lbl_Delete);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.fgrid_Formula);
			this.Controls.Add(this.panel2);
			this.Name = "Pop_Formula_Base_Register";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Formula_Base_Register_Closing);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.fgrid_Formula, 0);
			this.Controls.SetChildIndex(this.btn_Save, 0);
			this.Controls.SetChildIndex(this.btn_close, 0);
			this.Controls.SetChildIndex(this.lbl_Delete, 0);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs_Color_Cd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Div)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs_Cd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Formula)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion	

		#region 변수정의 

		#region 기본변수
		int _Rowfixed = 2;

		string 	_BlankText=" ",
		       _CompLevel = "2",			_CompType ="C",					_MatLevel ="3",   
			   _InitValue = "0",			_Seq="0",						_Flag    ="True",
			   _MateialType  = "M",         _Formula="B",					_Blank   =" ",                 		
			   _SendCheck    = " ",         _Head = "H",                    _Tail = "T",
			   _Material     ="M",          _Component  = "C",              _StyleCd  ="";

		

		private COM.OraDB _MyOraDB = new COM.OraDB();
		#endregion

		#region  행 이미지 저장
		private Hashtable _Imgmap = new Hashtable();
		private Hashtable _ImgmapAction = new Hashtable();

		private const string _TypeSG = "S", _TypeCmp = "C", _TypeMat = "M", _TypeJoint = "J";

		private int _IxImage_SG = 1, _IxImage_Cmp = 2, _IxImage_Mat = 3, _IxImage_Joint = 4;
		//private int _IxImage_Move = 5; 
 

		#endregion

		#region 칼라 설정
		private Color _Base_Color    = ClassLib.ComVar.ClrSel_Green;	
		private Color _Pigment_Color = ClassLib.ComVar.ClrSel_Yellow;
		#endregion

		#endregion 

		#region 멤버메쏘드
		private void Init_Form()
		{
			DataTable dt_list;
	
			#region 그리드 설정(TBSBC_FORMULAN_COPY)
			fgrid_Formula.Set_Grid_Comm("SBC_FOMULAN_COPY", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			fgrid_Formula.Set_Action_Image(img_Action);
			fgrid_Formula.Cols[0].AllowEditing = false;
			#endregion

       
			//Title
			this.Text = "Base Formula Register";
			lbl_MainTitle.Text = "   Base Formula Register";
			ClassLib.ComFunction.SetLangDic(this);

		
			// 공장코드
			dt_list = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
			cmb_Factory.Enabled  = false;
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;


			//year
			ClassLib.ComFunction.Set_Year(cmb_Year ,ClassLib.ComVar.ConsAll);
			cmb_Year.SelectedValue = ClassLib.ComVar.ConsBaseYear;
			cmb_Year.Enabled  =false;
			
			
			// season 
			dt_list =  ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSeason);
			COM.ComCtl.Set_ComboList(dt_list, cmb_Season  , 1, 2,  false, false);
			cmb_Season.Enabled  = false;
			cmb_Season.SelectedValue    = ClassLib.ComVar.ConsBaseSN;

			
			// Mcs
			dt_list = SelectMcsCode(" "," ");
			ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Mcs_Cd, 0, 1,false, 64,178);

			// Mcs Color
			dt_list = SelectMcsColorCode(cmb_Factory.SelectedValue.ToString()," "," ");
			ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Mcs_Color_Cd, 0, 1,false, 64,178);


			//Formula Division
			dt_list = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,ClassLib.ComVar.CxFormulaDiv);
			ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Formula_Div , 1, 2, false, false);
			cmb_Formula_Div.SelectedValue  = ClassLib.ComVar.ConsBaseFormula;
			//cmb_Formula_Div.Enabled  = false;
			dt_list.Dispose();


			_StyleCd   = ClassLib.ComVar.ConsBaseStyle;
			COM.ComVar.Parameter_PopUp = null;
			fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_NAME].Visible   = false;
			fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_NAME].Visible  = false;
			

			chkSpec.Checked  = false;
			chkKeep.Checked  = true;



		}



		
		/// <summary>
		/// SetStyleMcs :Style별 McsColor Setting
		/// </summary>
		private void  SetStyleMcs(string arg_Base)
		{
			try
			{   //공통 팝업이므로 아규머트 조정 잘 할것...
				string  vStyle_Cd = ClassLib.ComVar.ConsBaseStyle;

				COM.ComVar.Parameter_PopUp = new string[] 
						{
							cmb_Factory.SelectedValue.ToString(),
							cmb_Year.SelectedValue.ToString(),
							cmb_Season.SelectedValue.ToString(),
							vStyle_Cd
						};
						 
				FlexBase.Yield.Pop_Style_Mcs Pop_Style_Mcs = new  FlexBase.Yield.Pop_Style_Mcs();
				Pop_Style_Mcs.ShowDialog();
  
				if ( COM.ComVar.Parameter_PopUp[5] == ClassLib.ComVar.ConsTrue) 
				{  
					cmb_Mcs_Cd.SelectedValue          = COM.ComVar.Parameter_PopUp[0]; 
					//txt_Mcs_Name.Text               = COM.ComVar.Parameter_PopUp[1]; 
					cmb_Mcs_Color_Cd.SelectedValue    = COM.ComVar.Parameter_PopUp[2]; 
					//txt_Mcs_Color_Name.Text         = COM.ComVar.Parameter_PopUp[3]; 

					vStyle_Cd  = ClassLib.ComVar.ConsBaseStyle;
									 
					fgrid_Formula.Rows.Count  = fgrid_Formula.Rows.Fixed;
					SetFormula();	

					
					
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetStyleMcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}


	
		
		/// <summary>
		///  SetFormula: Formula Setting
		/// </summary>
		/// <returns></returns>
		private void SetFormula()
		{
			try
			{

				DataTable dt_ret;

				//if CheckSelectFormula()
				dt_ret = SelectFormula();

				if ((dt_ret == null)||(dt_ret.Rows.Count  == 0)  ) 
				{// ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch); 
						
					
					return;
				}

				DisPlayFormula(dt_ret);

				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetFormula", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		
		/// <summary>
		///  DisPlayFormula: Formula 뿌리기
		/// </summary>
		/// <returns></returns>
		private void DisPlayFormula(DataTable arg_dt)
		{
			fgrid_Formula.Rows.Count = _Rowfixed;
			fgrid_Formula.Tree.Column = (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME;

			for (int i =0; i < arg_dt.Rows.Count ; i++)
			{
				
				int vLevel = Convert.ToInt32(arg_dt.Rows[i].ItemArray[0].ToString());

				fgrid_Formula.Rows.InsertNode(i+ _Rowfixed, vLevel);
                
				
				//그리드수와 데이타셋의 칼럼수가 틀림
				for (int  j=0 ;j<arg_dt.Columns.Count ;j++)
				{  					
					if (arg_dt.Rows[i].ItemArray[j] == null)  break;
					fgrid_Formula[i+ _Rowfixed,j+1] =  ClassLib.ComFunction.Empty_String(arg_dt.Rows[i].ItemArray[j].ToString()," ");
				}
			}

			
			#region 그림이미지
			_Imgmap.Clear();

			for(int i = _Rowfixed; i < fgrid_Formula.Rows.Count; i++)
			{
				Display_Type_Image(i);

			}
  
			fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY].ImageAndText = true; 
			fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY].ImageMap     = _Imgmap;  

			#endregion
					


			//Subtotal
			MakeSubTotal(_Rowfixed,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA, (int)ClassLib.TBSBC_FORMULAN_COPY.lxMIX);

			fgrid_Formula.Select(fgrid_Formula.Rows.Fixed + 1, 0, fgrid_Formula.Rows.Fixed + 1, fgrid_Formula.Cols.Count - 1, false);


		}


				

		/// <summary>
		///  MakeSubTotal: Mix/Weight Subtotal 만들기
		/// </summary>
		/// <returns></returns>
		private void MakeSubTotal(int arg_set_row, int arg_formula_col, int arg_mix_col)
		{
			
			double  iTotalFormula  =  0;
			double  iTotalMix      =100;
			double  iRemMix        =  0; 
			

			
			for (int i =_Rowfixed+1; i < fgrid_Formula.Rows.Count ; i++)
			{
				if (fgrid_Formula[i, arg_formula_col]== null)  break;

				iTotalFormula = iTotalFormula +  Convert.ToDouble(fgrid_Formula[i,arg_formula_col].ToString());
			}

			fgrid_Formula[arg_set_row , arg_formula_col] = iTotalFormula;
			fgrid_Formula[arg_set_row , arg_mix_col]     = iTotalMix;
			
			
			for (int i =_Rowfixed+1; i < fgrid_Formula.Rows.Count ; i++)
			{
				if (fgrid_Formula[i, arg_mix_col]== null)  break;

				// Row별  Mix 값Setting
				iTotalFormula = (iTotalFormula == 0)?1: iTotalFormula;
				fgrid_Formula[i , arg_mix_col] = Math.Round(Convert.ToDouble(fgrid_Formula[i, arg_formula_col].ToString()) /iTotalFormula*100,3);


				//마지막 Row의  Mix값 Setting 				
				iRemMix  =iRemMix + Math.Round(((i<fgrid_Formula.Rows.Count -1)?Convert.ToDouble(fgrid_Formula[i , arg_mix_col].ToString()):0),3);
				fgrid_Formula[fgrid_Formula.Rows.Count -1 , arg_mix_col]  = Math.Round(iTotalMix - iRemMix,3);
				
				//칼라 Setting
				fgrid_Formula.GetCellRange(i, (int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV).StyleNew.BackColor = 
					(fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV].ToString() == _Formula)?_Base_Color:_Pigment_Color;

								
				//칼라 Setting
				fgrid_Formula.GetCellRange(i, (int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA).StyleNew.ForeColor  = ClassLib.ComVar.ClrFormulaEdit;				

			}

		}





		// <summary>
		/// CheckItemList() : Item Return값의 정합성 검증
		/// </summary>
		/// <returns>bool</returns>
		private bool CheckItemList()
		{
			try
			{

				if (COM.ComVar.Parameter_PopUp[0].ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Item Shoulb be selected..");
					return false; 
				}
				

				if (COM.ComVar.Parameter_PopUp[2].ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Spec Shoulb be selected..");
					return false; 				
				}


				if (COM.ComVar.Parameter_PopUp[4].ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Color Shoulb be selected..");
					return false; 
				}
				
				//Formula별 동일 자재가 존재시 중복 검증
				for (int i  = _Rowfixed   ;  i< fgrid_Formula.Rows.Count  ;i++)
				{
					
					string  sOldItem = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_CD].ToString() +
						fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_CD].ToString() +
						fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_CD].ToString() +
						fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV].ToString() ;

					
					
					string  sNewItem = COM.ComVar.Parameter_PopUp[0]+
						COM.ComVar.Parameter_PopUp[2]+
						COM.ComVar.Parameter_PopUp[4]+
						cmb_Formula_Div.SelectedValue.ToString();


					if (sOldItem  == sNewItem )
					{
						ClassLib.ComFunction.User_Message("Duplication Check");
						return false;
					}

				}

				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "CheckItemList", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false; 
			}
		}



		
		/// <summary>
		/// SetItem: Item Register Pop
		/// </summary>
		private void  SetItem()
		{
			try
			{   

				FlexBase.MaterialBase.Pop_Item_List  pop_Form = new  FlexBase.MaterialBase.Pop_Item_List();

				COM.ComVar.Parameter_PopUp		= new string[1];

				COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");

				pop_Form.ShowDialog();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetItem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}


		
		/// <summary>
		/// Display_Type_Image : 이미지 표시
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Type_Image(int arg_row) 
		{

			if(_Imgmap.ContainsKey(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString() ) ) return;

			switch(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxTYPE_DIVISION].ToString() )
					//switch(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ToString() )
			{ 		
				case _TypeSG:  
					fgrid_Formula.GetCellRange(arg_row, 1, arg_row, fgrid_Formula.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
					_Imgmap.Add(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_SG]); 
					break;

				case _TypeCmp:  
					fgrid_Formula.GetCellRange(arg_row, 1, arg_row, fgrid_Formula.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
					_Imgmap.Add(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_Cmp]); 
					break;

				case _TypeMat:
					_Imgmap.Add(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_Mat]);
					break;
				
				case _TypeJoint:
					_Imgmap.Add(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_Joint]);
					break;
 
			} // end switch
		}



		/// <summary>
		///  DisPlayItem() : Item  Setting
		/// </summary>
		/// <returns></returns>
		private void DisPlayItem()
		{
			try
			{
				

				if (CheckItemList() != true) return;

				int iR1  = fgrid_Formula.Selection.r1;

                //int iR1 = fgrid_Formula.Rows.Count-1;


				fgrid_Formula.Rows.InsertNode(iR1+1,Convert.ToInt32(_MatLevel));
				
				fgrid_Formula.Select(fgrid_Formula.Selection.r1, 0, fgrid_Formula.Selection.r1, fgrid_Formula.Cols.Count-1,false);
				fgrid_Formula.Select(fgrid_Formula.Selection.r1+1, 0, fgrid_Formula.Selection.r1+1, fgrid_Formula.Cols.Count-1,true);

				int iR2  = fgrid_Formula.Selection.r1;

				#region  칼럼값
				fgrid_Formula[iR2,0]          = "I";
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxLEVEL]          = _MatLevel;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY]    
					= cmb_Mcs_Cd.SelectedValue.ToString()+cmb_Mcs_Color_Cd.SelectedValue.ToString()
					+ _Formula + COM.ComVar.Parameter_PopUp[0]
					+ COM.ComVar.Parameter_PopUp[4];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxTYPE_DIVISION]  = _MateialType ; 
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV]    = cmb_Formula_Div.SelectedValue.ToString() ;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxJOB_FLAG]       = _Flag; 
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME]      = COM.ComVar.Parameter_PopUp[1];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_NAME]      = COM.ComVar.Parameter_PopUp[3];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_NAME]	  = COM.ComVar.Parameter_PopUp[5];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxUNIT]			  = COM.ComVar.Parameter_PopUp[6];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_CD]		  = COM.ComVar.Parameter_PopUp[0];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_CD]		  = COM.ComVar.Parameter_PopUp[2];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_CD]		  = COM.ComVar.Parameter_PopUp[4];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA]		  = _InitValue;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMIX]			  = _InitValue;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFACTORY]		  = cmb_Factory.SelectedValue.ToString();
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSEQ]			  = _Seq; 
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_YEAR]   = cmb_Year.SelectedValue.ToString();
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSEASON_CD]      = cmb_Season.SelectedValue.ToString();
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSTYLE_CD]       = ClassLib.ComVar.ConsBaseStyle;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCS_CD]         = cmb_Mcs_Cd.SelectedValue.ToString();
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCS_COLOR_CD]   = cmb_Mcs_Color_Cd.SelectedValue.ToString();			
				#endregion

				MakeSubTotal(_Rowfixed,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA, (int)ClassLib.TBSBC_FORMULAN_COPY.lxMIX);
			
				#region 그림이미지
				_Imgmap.Clear();

				for(int i = _Rowfixed; i < fgrid_Formula.Rows.Count; i++)
				{
					Display_Type_Image(i);

				}
  
				fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageAndText = true; 
				fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageMap     = _Imgmap;  

				#endregion

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "CheckItemList", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}




		/// <summary>
		///  DisPlayItem() : Item  Setting
		/// </summary>
		/// <returns></returns>
		private void SetGridFlagClear()
		{
			for(int i =_Rowfixed; i< fgrid_Formula.Rows.Count ;i++)
			{
				fgrid_Formula[i,0] = "";	
			}

		}



		
		private bool SaveBaseFormula()
		{


			bool make_flag = false;


			make_flag = SaveFormula(); 

			if(!make_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return false;
			}
			else
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				return true;
			}
		}



		/// <summary>
		/// SaveFormula: Formula저장
		/// </summary>
		/// <returns></returns>
		private bool SaveFormula()
		{   
			try
			{
				//DataSet ds_ret;
									    
				int  iCol =20;

				_MyOraDB.ReDim_Parameter(iCol); 

				_MyOraDB.Process_Name=  "PKG_SBC_FORMULA.SAVE_SBC_BASE_FORMULA";
			
				int i=0;
				_MyOraDB.Parameter_Name[i++] = "ARG_FLAG";  
				_MyOraDB.Parameter_Name[i++] = "ARG_DIVISION";  
				_MyOraDB.Parameter_Name[i++] = "ARG_FACTORY";     
				_MyOraDB.Parameter_Name[i++] = "ARG_SEQ";             
				_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA_DIV";
  
				_MyOraDB.Parameter_Name[i++] = "ARG_ITEM_CD";     
				_MyOraDB.Parameter_Name[i++] = "ARG_COLOR_CD";     
				_MyOraDB.Parameter_Name[i++] = "ARG_SPEC_CD";      
				_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA_YEAR"; 
				_MyOraDB.Parameter_Name[i++] = "ARG_SEASON_CD";    

				_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD";     
				_MyOraDB.Parameter_Name[i++] = "ARG_MCS_CD";       
				_MyOraDB.Parameter_Name[i++] = "ARG_MCS_COLOR_CD"; 
				_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA";      
				_MyOraDB.Parameter_Name[i++] = "ARG_MIX";          

				_MyOraDB.Parameter_Name[i++] = "ARG_REMARKS";      
				_MyOraDB.Parameter_Name[i++] = "ARG_SEND_CHK";     
				_MyOraDB.Parameter_Name[i++] = "ARG_SEND_YMD";     
				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER";     
				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_YMD"; 

				for (i = 0 ; i< iCol; i++)
					_MyOraDB.Parameter_Type[i] = 1; 						

				#region Value 
				int  iRow   = 0;
				for(i =  _Rowfixed; i < fgrid_Formula.Rows.Count; i++)
				{
					if ((fgrid_Formula[i,0] == null) || fgrid_Formula[i,0].ToString() == "" || fgrid_Formula[i,0].ToString() == " ")  continue;	
					if(fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _Material)
						iRow ++;
				}

				_MyOraDB.Parameter_Values = new string[iCol * iRow];


				int iCnt=0;
				for(i =  _Rowfixed; i < fgrid_Formula.Rows.Count; i++)                  //Component>자재별 생성
				{
					if ((fgrid_Formula[i,0] == null) || fgrid_Formula[i,0].ToString() == "" || fgrid_Formula[i,0].ToString() == " ")  continue;	
					if(fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxTYPE_DIVISION].ToString() != _Material) continue;

					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Formula[i,0].ToString();
					if(fgrid_Formula[i-1,(int)ClassLib.TBSBC_FORMULAN_COPY.lxTYPE_DIVISION ].ToString() == _Component ) 
						_MyOraDB.Parameter_Values[iCnt++] =  _Head;
					else
						_MyOraDB.Parameter_Values[iCnt++] =  _Tail;

					_MyOraDB.Parameter_Values[iCnt++] =  cmb_Factory.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  ClassLib.ComFunction.Empty_String(fgrid_Formula[iRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA_SEQ].ToString()," ");
					_MyOraDB.Parameter_Values[iCnt++] =  ClassLib.ComVar.ConsBaseFormula;

					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_CD].ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_CD].ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_CD ].ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  cmb_Year.SelectedValue.ToString ();
					_MyOraDB.Parameter_Values[iCnt++] =  cmb_Season.SelectedValue.ToString();

					_MyOraDB.Parameter_Values[iCnt++] =  ClassLib.ComVar.ConsBaseStyle;
					_MyOraDB.Parameter_Values[iCnt++] =  cmb_Mcs_Cd.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  cmb_Mcs_Color_Cd.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA].ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMIX].ToString();

					_MyOraDB.Parameter_Values[iCnt++] =  _Blank;
					_MyOraDB.Parameter_Values[iCnt++] =  _SendCheck;
					_MyOraDB.Parameter_Values[iCnt++] =  System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
					_MyOraDB.Parameter_Values[iCnt++] =  ClassLib.ComVar.This_User;	
					_MyOraDB.Parameter_Values[iCnt++] =  System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				
				}
			
				#endregion

				_MyOraDB.Add_Modify_Parameter(true);						// 파라미터 데이터를 DataSet에 추가
				DataSet ds_Set = _MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				if (ds_Set == null) return false;
				else return true;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SaveFormula", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			
			}		
		}



		/// <summary>
		/// SelectFormula: Formula  조회
		/// </summary>
		/// <returns></returns>
		public DataTable SelectFormula()
		{
		
			if ( (cmb_Mcs_Cd.SelectedValue.ToString()   == _BlankText ) ||  (cmb_Mcs_Color_Cd.SelectedValue.ToString() == _BlankText ) ) return null;

			DataSet ds_ret; int iCnt;
			
			iCnt  =  7;
			_MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			_MyOraDB.Process_Name = "PKG_SBC_FORMULA.SELECT_SBC_FORMULA";
 
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
			_MyOraDB.Parameter_Values[3] = ClassLib.ComVar.ConsBaseStyle;
			_MyOraDB.Parameter_Values[4] = cmb_Mcs_Cd.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[5] = cmb_Mcs_Color_Cd.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[6] = ""; 

			_MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_MyOraDB.Process_Name]; 
		}



		



		#endregion

        #region 이벤트 


		private void fgrid_Formula_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			for ( int i = fgrid_Formula.Rows.Fixed  ; i <fgrid_Formula.Rows.Count    ;i++)
			{
				fgrid_Formula.Update_Row(i);
			}
		}



		private void fgrid_Formula_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if((e.KeyCode  !=Keys.Enter)  ||  (fgrid_Formula.Selection.c1 != (int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA)) return;
			   MakeSubTotal(_Rowfixed,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA, (int)ClassLib.TBSBC_FORMULAN_COPY.lxMIX);

		

		}

		private void txt_Mcs_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			
			if(e.KeyChar == (char)13)
			{   
				DataTable dt_list;

				string vcode =  "";
				string vname = ClassLib.ComFunction.Empty_TextBox(txt_Mcs, " ").ToUpper();   //name
				dt_list = SelectMcsCode(vcode, vname);



				ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Mcs_Cd, 0, 1,false,true);

			}
		
		}




		private void txt_Mcs_Color_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			
			


			if(e.KeyChar == (char)13)
			{
				string vcode =  "";
				string vname = ClassLib.ComFunction.Empty_TextBox(txt_Mcs_Color, " ").ToUpper();   //name

				
				DataTable dt_list;

				dt_list = SelectMcsColorCode(cmb_Factory.SelectedValue.ToString(),vcode, vname); 

				ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Mcs_Color_Cd , 0, 1,false,true);

			}
		}



		private void btn_BaseMcs_Click(object sender, System.EventArgs e)
		{
			_StyleCd  = ClassLib.ComVar.ConsBaseStyle;
			SetStyleMcs(ClassLib.ComVar.ConsTrue);

			for (int  i  = fgrid_Formula.Rows.Fixed  ;  i< fgrid_Formula.Rows.Count   ;i++)
				 fgrid_Formula[i,0] = "I";
		}




		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			try
			{  
				

				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

				if  (SaveBaseFormula() == true) 
				{
					SetGridFlagClear();
					//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
					btn_Mcs_Click(null,null);
				}
				else
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					

				this.Cursor = System.Windows.Forms.Cursors.Default ;

				


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);

			} 

		}


		
		private void lbl_Delete_Click(object sender, System.EventArgs e)
		{
			for ( int i = fgrid_Formula.Rows.Fixed  ; i <fgrid_Formula.Rows.Count    ;i++)
			{
				fgrid_Formula.Delete_Row(i);
			}
		}


		
		private void btn_Mcs_Click(object sender, System.EventArgs e)
		{
			 
			try
			{  
				

				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

				fgrid_Formula.Rows.Count = fgrid_Formula.Rows.Fixed ;

				SetFormula();

				this.Cursor = System.Windows.Forms.Cursors.Default ;

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch, this);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Mcs_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);

			} 

			

		}



		private void btn_close_Click(object sender, System.EventArgs e)
		{
            this.Dispose();

		}


		private void Pop_Formula_Base_Register_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
            this.Dispose();
		}


		private void chkSpec_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkSpec.Checked  == true) 
			{  
				fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_NAME].Visible   = true;
				fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_NAME].Visible  = true;

			}

			if (chkSpec.Checked  == false) 
			{
				fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_NAME].Visible   = false;
				fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_NAME].Visible  = false;


			}

		}

		private void cmb_Mcs_Color_Cd_TextChanged(object sender, System.EventArgs e)
		{
           
			if (chkKeep.Checked  == true) 
			{ 
				if (COM.ComVar.Parameter_PopUp  == null) return;

				if ( COM.ComVar.Parameter_PopUp[5] == ClassLib.ComVar.ConsTrue)
				{    COM.ComVar.Parameter_PopUp[5] =  ClassLib.ComVar.ConsFalse; return;}

				//기존의 자재 구성 유지
				fgrid_Formula[_Rowfixed,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME] = cmb_Mcs_Cd.Columns[1].Text +"-"+ cmb_Mcs_Color_Cd.Columns[1].Text;

				for (int i = _Rowfixed+1 ;i<fgrid_Formula.Rows.Count ; i++)
				{  					
					string sOldMcs = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY].ToString().Substring(0,10);
					string sNewMcs = cmb_Mcs_Cd.SelectedValue.ToString() +cmb_Mcs_Color_Cd.SelectedValue.ToString();
					string sInfoKey = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY].ToString().Replace(sOldMcs,sNewMcs);;
					fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY]    = sInfoKey;
					fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCS_CD]         = cmb_Mcs_Cd.SelectedValue.ToString();
					fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCS_COLOR_CD]   = cmb_Mcs_Color_Cd.SelectedValue.ToString();		

					return;
				}
				return;
			}
		
			fgrid_Formula.Rows.Count = _Rowfixed;   
			if (fgrid_Formula.Rows.Count == _Rowfixed )  
			{
				int vLevel = Convert.ToInt32(_CompLevel);
	
				fgrid_Formula.Rows.InsertNode(_Rowfixed, vLevel);
						
				for (int i=(int)ClassLib.TBSBC_FORMULAN_COPY.lxLEVEL; i< fgrid_Formula.Cols.Count  ;i++)
				{
					fgrid_Formula[fgrid_Formula.Rows.Count-1, i] =_BlankText;
				}
	
				fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxLEVEL] = _CompLevel;
				fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY]   =
					cmb_Mcs_Cd.SelectedValue.ToString() + cmb_Mcs_Color_Cd.SelectedValue.ToString();
				fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxTYPE_DIVISION]  = _CompType;
				fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_CD]   = _BlankText;
				fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_CD]  = _BlankText;
				fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME]     
					=  cmb_Mcs_Cd.Columns[1].Text.ToString() +"-" + cmb_Mcs_Color_Cd.Columns[1].Text.ToString();
			}

			SetFormula();				
		
		}


		#endregion

		#region DB컨넥트
		/// <summary>
		/// SelectMcsCode: Mcs Code  조회
		/// </summary>
		/// <returns></returns>
		public DataTable   SelectMcsCode(string arg_mcs, string arg_mcs_name)
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
			_MyOraDB.Parameter_Values[0] = arg_mcs;
			_MyOraDB.Parameter_Values[1] = arg_mcs_name;
			_MyOraDB.Parameter_Values[2] = ""; 

			_MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_MyOraDB.Process_Name]; 
		}



		/// <summary>
		/// SelectMcsCode: Mcs Code  조회
		/// </summary>
		/// <returns></returns>
		/// 
		public static DataTable SelectMcsColorCode(string  arg_factory ,string arg_color, string arg_color_name)
		{

			COM.OraDB _LMyOraDB = new COM.OraDB();

			DataSet ds_ret; int iCnt;
			
			iCnt  =  4;
			_LMyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			_LMyOraDB.Process_Name = "PKG_SBC_MCS_COLOR.SELECT_SBC_COLOR";
 
			//02.ARGURMENT명
			_LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			_LMyOraDB.Parameter_Name[1] = "ARG_COLOR_CD";
			_LMyOraDB.Parameter_Name[2] = "ARG_COLOR_NAME";
			_LMyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE
			_LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_LMyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			_LMyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			_LMyOraDB.Parameter_Values[0] =arg_factory;
			_LMyOraDB.Parameter_Values[1] =arg_color.ToUpper();
			_LMyOraDB.Parameter_Values[2] =arg_color_name.ToUpper();
			_LMyOraDB.Parameter_Values[3] = ""; 

			_LMyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _LMyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_LMyOraDB.Process_Name]; 
		}


		#endregion

		#region 콘텍스트 메뉴

		private void menu_Item_Click(object sender, System.EventArgs e)
		{ 
			SetItem();

			DisPlayItem();

			for (int i = fgrid_Formula.Rows.Fixed  ; i < fgrid_Formula.Rows.Count  ;   i++)
			{
				fgrid_Formula[i,0] = "I";
			}

		}


		private void menu_Item_del_Click(object sender, System.EventArgs e)
		{
			
			fgrid_Formula.Rows.Remove(fgrid_Formula.Selection.r1);

			for (int i = fgrid_Formula.Rows.Fixed  ; i < fgrid_Formula.Rows.Count  ;   i++)
			{
				fgrid_Formula[i,0] = "I";
			}

		}

		#endregion 


	


	}
}

