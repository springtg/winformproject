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
	public class Pop_Formula_Copy : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label lbl_Style_From;
		private System.Windows.Forms.Label lbl_Year_From;
		private System.Windows.Forms.Label lbl_Factory_From;
		private C1.Win.C1List.C1Combo cmb_Style_From;
		private System.Windows.Forms.TextBox txt_Style_From;
		private C1.Win.C1List.C1Combo cmb_Season_From;
		private C1.Win.C1List.C1Combo cmb_Year_From;
		private C1.Win.C1List.C1Combo cmb_Factory_From;
		private C1.Win.C1List.C1Combo cmb_Style_To;
		private System.Windows.Forms.TextBox txt_Style_To;
		private C1.Win.C1List.C1Combo cmb_Season_To;
		private C1.Win.C1List.C1Combo cmb_Year_To;
		private C1.Win.C1List.C1Combo cmb_Factory_To;
		private System.Windows.Forms.Label lbl_Style_To;
		private System.Windows.Forms.Label lbl_Year_To;
		private System.Windows.Forms.Label lbl_Factory_To;
		public COM.FSP fgrid_Formula;
		private System.Windows.Forms.CheckBox chk_Formula;
		private System.Windows.Forms.CheckBox chk_Weight;
		private System.Windows.Forms.CheckBox chk_Yield;
		private System.Windows.Forms.ImageList img_Type;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rad_All;
		private System.Windows.Forms.RadioButton rad_Comp;
		private System.Windows.Forms.ContextMenu cmd_popmenu;
		private System.Windows.Forms.MenuItem menu_AllSelect;
		private System.Windows.Forms.MenuItem menu_AllCancel;
		private System.ComponentModel.IContainer components = null;

		public Pop_Formula_Copy()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Formula_Copy));
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rad_All = new System.Windows.Forms.RadioButton();
			this.rad_Comp = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chk_Yield = new System.Windows.Forms.CheckBox();
			this.chk_Weight = new System.Windows.Forms.CheckBox();
			this.chk_Formula = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmb_Style_To = new C1.Win.C1List.C1Combo();
			this.txt_Style_To = new System.Windows.Forms.TextBox();
			this.cmb_Season_To = new C1.Win.C1List.C1Combo();
			this.cmb_Year_To = new C1.Win.C1List.C1Combo();
			this.cmb_Factory_To = new C1.Win.C1List.C1Combo();
			this.lbl_Style_To = new System.Windows.Forms.Label();
			this.lbl_Year_To = new System.Windows.Forms.Label();
			this.lbl_Factory_To = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmb_Style_From = new C1.Win.C1List.C1Combo();
			this.txt_Style_From = new System.Windows.Forms.TextBox();
			this.cmb_Season_From = new C1.Win.C1List.C1Combo();
			this.cmb_Year_From = new C1.Win.C1List.C1Combo();
			this.cmb_Factory_From = new C1.Win.C1List.C1Combo();
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
			this.fgrid_Formula = new COM.FSP();
			this.cmd_popmenu = new System.Windows.Forms.ContextMenu();
			this.menu_AllSelect = new System.Windows.Forms.MenuItem();
			this.menu_AllCancel = new System.Windows.Forms.MenuItem();
			this.btn_close = new System.Windows.Forms.Label();
			this.btn_apply = new System.Windows.Forms.Label();
			this.img_Type = new System.Windows.Forms.ImageList(this.components);
			this.panel2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style_To)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_To)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year_To)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_To)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style_From)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_From)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year_From)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_From)).BeginInit();
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(366, 23);
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
			this.panel2.Controls.Add(this.groupBox4);
			this.panel2.Controls.Add(this.groupBox3);
			this.panel2.Controls.Add(this.groupBox2);
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
			this.panel2.Size = new System.Drawing.Size(400, 240);
			this.panel2.TabIndex = 167;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.rad_All);
			this.groupBox4.Controls.Add(this.rad_Comp);
			this.groupBox4.Location = new System.Drawing.Point(248, 197);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(145, 35);
			this.groupBox4.TabIndex = 544;
			this.groupBox4.TabStop = false;
			// 
			// rad_All
			// 
			this.rad_All.Checked = true;
			this.rad_All.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rad_All.Location = new System.Drawing.Point(85, 15);
			this.rad_All.Name = "rad_All";
			this.rad_All.Size = new System.Drawing.Size(35, 16);
			this.rad_All.TabIndex = 36;
			this.rad_All.TabStop = true;
			this.rad_All.Tag = "-1";
			this.rad_All.Text = "All";
			this.rad_All.CheckedChanged += new System.EventHandler(this.rad_Comp_CheckedChanged);
			// 
			// rad_Comp
			// 
			this.rad_Comp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rad_Comp.Location = new System.Drawing.Point(16, 14);
			this.rad_Comp.Name = "rad_Comp";
			this.rad_Comp.Size = new System.Drawing.Size(64, 16);
			this.rad_Comp.TabIndex = 35;
			this.rad_Comp.Tag = "2";
			this.rad_Comp.Text = "Comp";
			this.rad_Comp.CheckedChanged += new System.EventHandler(this.rad_Comp_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chk_Yield);
			this.groupBox3.Controls.Add(this.chk_Weight);
			this.groupBox3.Controls.Add(this.chk_Formula);
			this.groupBox3.Location = new System.Drawing.Point(7, 197);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(233, 35);
			this.groupBox3.TabIndex = 31;
			this.groupBox3.TabStop = false;
			// 
			// chk_Yield
			// 
			this.chk_Yield.Location = new System.Drawing.Point(160, 10);
			this.chk_Yield.Name = "chk_Yield";
			this.chk_Yield.Size = new System.Drawing.Size(62, 20);
			this.chk_Yield.TabIndex = 3;
			this.chk_Yield.Text = "Yield";
			this.chk_Yield.CheckedChanged += new System.EventHandler(this.chk_Yield_Click);
			// 
			// chk_Weight
			// 
			this.chk_Weight.Location = new System.Drawing.Point(88, 10);
			this.chk_Weight.Name = "chk_Weight";
			this.chk_Weight.Size = new System.Drawing.Size(104, 20);
			this.chk_Weight.TabIndex = 2;
			this.chk_Weight.Text = "Weight";
			this.chk_Weight.CheckedChanged += new System.EventHandler(this.chk_Weight_Click);
			// 
			// chk_Formula
			// 
			this.chk_Formula.Location = new System.Drawing.Point(8, 10);
			this.chk_Formula.Name = "chk_Formula";
			this.chk_Formula.Size = new System.Drawing.Size(104, 20);
			this.chk_Formula.TabIndex = 1;
			this.chk_Formula.Text = "Formula";
			this.chk_Formula.CheckedChanged += new System.EventHandler(this.chk_Formula_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmb_Style_To);
			this.groupBox2.Controls.Add(this.txt_Style_To);
			this.groupBox2.Controls.Add(this.cmb_Season_To);
			this.groupBox2.Controls.Add(this.cmb_Year_To);
			this.groupBox2.Controls.Add(this.cmb_Factory_To);
			this.groupBox2.Controls.Add(this.lbl_Style_To);
			this.groupBox2.Controls.Add(this.lbl_Year_To);
			this.groupBox2.Controls.Add(this.lbl_Factory_To);
			this.groupBox2.Location = new System.Drawing.Point(7, 112);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(386, 85);
			this.groupBox2.TabIndex = 30;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Target";
			// 
			// cmb_Style_To
			// 
			this.cmb_Style_To.AddItemCols = 0;
			this.cmb_Style_To.AddItemSeparator = ';';
			this.cmb_Style_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Style_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Style_To.Caption = "";
			this.cmb_Style_To.CaptionHeight = 17;
			this.cmb_Style_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Style_To.ColumnCaptionHeight = 18;
			this.cmb_Style_To.ColumnFooterHeight = 18;
			this.cmb_Style_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Style_To.ContentHeight = 17;
			this.cmb_Style_To.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Style_To.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Style_To.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Style_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Style_To.EditorHeight = 17;
			this.cmb_Style_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Style_To.GapHeight = 2;
			this.cmb_Style_To.ItemHeight = 15;
			this.cmb_Style_To.Location = new System.Drawing.Point(242, 58);
			this.cmb_Style_To.MatchEntryTimeout = ((long)(2000));
			this.cmb_Style_To.MaxDropDownItems = ((short)(5));
			this.cmb_Style_To.MaxLength = 32767;
			this.cmb_Style_To.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Style_To.Name = "cmb_Style_To";
			this.cmb_Style_To.PartialRightColumn = false;
			this.cmb_Style_To.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Style_To.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Style_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Style_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Style_To.Size = new System.Drawing.Size(132, 21);
			this.cmb_Style_To.TabIndex = 178;
			this.cmb_Style_To.TextChanged += new System.EventHandler(this.cmb_Style_To_TextChanged);
			// 
			// txt_Style_To
			// 
			this.txt_Style_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_To.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Style_To.Location = new System.Drawing.Point(110, 58);
			this.txt_Style_To.Name = "txt_Style_To";
			this.txt_Style_To.Size = new System.Drawing.Size(132, 21);
			this.txt_Style_To.TabIndex = 177;
			this.txt_Style_To.Text = "";
			this.txt_Style_To.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Style_To_KeyUp);
			// 
			// cmb_Season_To
			// 
			this.cmb_Season_To.AddItemCols = 0;
			this.cmb_Season_To.AddItemSeparator = ';';
			this.cmb_Season_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Season_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Season_To.Caption = "";
			this.cmb_Season_To.CaptionHeight = 17;
			this.cmb_Season_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Season_To.ColumnCaptionHeight = 18;
			this.cmb_Season_To.ColumnFooterHeight = 18;
			this.cmb_Season_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Season_To.ContentHeight = 17;
			this.cmb_Season_To.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Season_To.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Season_To.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Season_To.EditorHeight = 17;
			this.cmb_Season_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season_To.GapHeight = 2;
			this.cmb_Season_To.ItemHeight = 15;
			this.cmb_Season_To.Location = new System.Drawing.Point(242, 36);
			this.cmb_Season_To.MatchEntryTimeout = ((long)(2000));
			this.cmb_Season_To.MaxDropDownItems = ((short)(5));
			this.cmb_Season_To.MaxLength = 32767;
			this.cmb_Season_To.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Season_To.Name = "cmb_Season_To";
			this.cmb_Season_To.PartialRightColumn = false;
			this.cmb_Season_To.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Season_To.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Season_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Season_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Season_To.Size = new System.Drawing.Size(132, 21);
			this.cmb_Season_To.TabIndex = 176;
			// 
			// cmb_Year_To
			// 
			this.cmb_Year_To.AddItemCols = 0;
			this.cmb_Year_To.AddItemSeparator = ';';
			this.cmb_Year_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Year_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Year_To.Caption = "";
			this.cmb_Year_To.CaptionHeight = 17;
			this.cmb_Year_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Year_To.ColumnCaptionHeight = 18;
			this.cmb_Year_To.ColumnFooterHeight = 18;
			this.cmb_Year_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Year_To.ContentHeight = 17;
			this.cmb_Year_To.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			this.cmb_Year_To.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Year_To.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Year_To.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Year_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Year_To.EditorHeight = 17;
			this.cmb_Year_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Year_To.GapHeight = 2;
			this.cmb_Year_To.ItemHeight = 15;
			this.cmb_Year_To.Location = new System.Drawing.Point(110, 36);
			this.cmb_Year_To.MatchEntryTimeout = ((long)(2000));
			this.cmb_Year_To.MaxDropDownItems = ((short)(5));
			this.cmb_Year_To.MaxLength = 32767;
			this.cmb_Year_To.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Year_To.Name = "cmb_Year_To";
			this.cmb_Year_To.PartialRightColumn = false;
			this.cmb_Year_To.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Year_To.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Year_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Year_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Year_To.Size = new System.Drawing.Size(132, 21);
			this.cmb_Year_To.TabIndex = 175;
			// 
			// cmb_Factory_To
			// 
			this.cmb_Factory_To.AddItemCols = 0;
			this.cmb_Factory_To.AddItemSeparator = ';';
			this.cmb_Factory_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory_To.Caption = "";
			this.cmb_Factory_To.CaptionHeight = 17;
			this.cmb_Factory_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory_To.ColumnCaptionHeight = 18;
			this.cmb_Factory_To.ColumnFooterHeight = 18;
			this.cmb_Factory_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory_To.ContentHeight = 17;
			this.cmb_Factory_To.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory_To.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory_To.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory_To.EditorHeight = 17;
			this.cmb_Factory_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory_To.GapHeight = 2;
			this.cmb_Factory_To.ItemHeight = 15;
			this.cmb_Factory_To.Location = new System.Drawing.Point(110, 14);
			this.cmb_Factory_To.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory_To.MaxDropDownItems = ((short)(5));
			this.cmb_Factory_To.MaxLength = 32767;
			this.cmb_Factory_To.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory_To.Name = "cmb_Factory_To";
			this.cmb_Factory_To.PartialRightColumn = false;
			this.cmb_Factory_To.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Factory_To.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory_To.Size = new System.Drawing.Size(265, 21);
			this.cmb_Factory_To.TabIndex = 174;
			this.cmb_Factory_To.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_To_SelectedValueChanged);
			// 
			// lbl_Style_To
			// 
			this.lbl_Style_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Style_To.ImageIndex = 1;
			this.lbl_Style_To.ImageList = this.img_Label;
			this.lbl_Style_To.Location = new System.Drawing.Point(8, 59);
			this.lbl_Style_To.Name = "lbl_Style_To";
			this.lbl_Style_To.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style_To.TabIndex = 173;
			this.lbl_Style_To.Text = "Style Code";
			this.lbl_Style_To.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Year_To
			// 
			this.lbl_Year_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Year_To.ImageIndex = 1;
			this.lbl_Year_To.ImageList = this.img_Label;
			this.lbl_Year_To.Location = new System.Drawing.Point(8, 37);
			this.lbl_Year_To.Name = "lbl_Year_To";
			this.lbl_Year_To.Size = new System.Drawing.Size(100, 21);
			this.lbl_Year_To.TabIndex = 172;
			this.lbl_Year_To.Text = "Year/Season";
			this.lbl_Year_To.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory_To
			// 
			this.lbl_Factory_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory_To.ImageIndex = 1;
			this.lbl_Factory_To.ImageList = this.img_Label;
			this.lbl_Factory_To.Location = new System.Drawing.Point(8, 13);
			this.lbl_Factory_To.Name = "lbl_Factory_To";
			this.lbl_Factory_To.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory_To.TabIndex = 171;
			this.lbl_Factory_To.Text = "Factory";
			this.lbl_Factory_To.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmb_Style_From);
			this.groupBox1.Controls.Add(this.txt_Style_From);
			this.groupBox1.Controls.Add(this.cmb_Season_From);
			this.groupBox1.Controls.Add(this.cmb_Year_From);
			this.groupBox1.Controls.Add(this.cmb_Factory_From);
			this.groupBox1.Controls.Add(this.lbl_Style_From);
			this.groupBox1.Controls.Add(this.lbl_Year_From);
			this.groupBox1.Controls.Add(this.lbl_Factory_From);
			this.groupBox1.Location = new System.Drawing.Point(7, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(386, 85);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source";
			// 
			// cmb_Style_From
			// 
			this.cmb_Style_From.AddItemCols = 0;
			this.cmb_Style_From.AddItemSeparator = ';';
			this.cmb_Style_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Style_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Style_From.Caption = "";
			this.cmb_Style_From.CaptionHeight = 17;
			this.cmb_Style_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Style_From.ColumnCaptionHeight = 18;
			this.cmb_Style_From.ColumnFooterHeight = 18;
			this.cmb_Style_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Style_From.ContentHeight = 17;
			this.cmb_Style_From.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Style_From.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Style_From.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Style_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Style_From.EditorHeight = 17;
			this.cmb_Style_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Style_From.GapHeight = 2;
			this.cmb_Style_From.ItemHeight = 15;
			this.cmb_Style_From.Location = new System.Drawing.Point(242, 58);
			this.cmb_Style_From.MatchEntryTimeout = ((long)(2000));
			this.cmb_Style_From.MaxDropDownItems = ((short)(5));
			this.cmb_Style_From.MaxLength = 32767;
			this.cmb_Style_From.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Style_From.Name = "cmb_Style_From";
			this.cmb_Style_From.PartialRightColumn = false;
			this.cmb_Style_From.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Style_From.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Style_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Style_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Style_From.Size = new System.Drawing.Size(132, 21);
			this.cmb_Style_From.TabIndex = 178;
			this.cmb_Style_From.TextChanged += new System.EventHandler(this.cmb_Style_From_TextChanged);
			// 
			// txt_Style_From
			// 
			this.txt_Style_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_From.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Style_From.Location = new System.Drawing.Point(110, 58);
			this.txt_Style_From.Name = "txt_Style_From";
			this.txt_Style_From.Size = new System.Drawing.Size(132, 21);
			this.txt_Style_From.TabIndex = 177;
			this.txt_Style_From.Text = "";
			this.txt_Style_From.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Style_From_KeyUp);
			// 
			// cmb_Season_From
			// 
			this.cmb_Season_From.AddItemCols = 0;
			this.cmb_Season_From.AddItemSeparator = ';';
			this.cmb_Season_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Season_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Season_From.Caption = "";
			this.cmb_Season_From.CaptionHeight = 17;
			this.cmb_Season_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Season_From.ColumnCaptionHeight = 18;
			this.cmb_Season_From.ColumnFooterHeight = 18;
			this.cmb_Season_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Season_From.ContentHeight = 17;
			this.cmb_Season_From.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Season_From.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Season_From.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Season_From.EditorHeight = 17;
			this.cmb_Season_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season_From.GapHeight = 2;
			this.cmb_Season_From.ItemHeight = 15;
			this.cmb_Season_From.Location = new System.Drawing.Point(242, 36);
			this.cmb_Season_From.MatchEntryTimeout = ((long)(2000));
			this.cmb_Season_From.MaxDropDownItems = ((short)(5));
			this.cmb_Season_From.MaxLength = 32767;
			this.cmb_Season_From.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Season_From.Name = "cmb_Season_From";
			this.cmb_Season_From.PartialRightColumn = false;
			this.cmb_Season_From.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Season_From.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Season_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Season_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Season_From.Size = new System.Drawing.Size(132, 21);
			this.cmb_Season_From.TabIndex = 176;
			// 
			// cmb_Year_From
			// 
			this.cmb_Year_From.AddItemCols = 0;
			this.cmb_Year_From.AddItemSeparator = ';';
			this.cmb_Year_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Year_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Year_From.Caption = "";
			this.cmb_Year_From.CaptionHeight = 17;
			this.cmb_Year_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Year_From.ColumnCaptionHeight = 18;
			this.cmb_Year_From.ColumnFooterHeight = 18;
			this.cmb_Year_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Year_From.ContentHeight = 17;
			this.cmb_Year_From.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			this.cmb_Year_From.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Year_From.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Year_From.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Year_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Year_From.EditorHeight = 17;
			this.cmb_Year_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Year_From.GapHeight = 2;
			this.cmb_Year_From.ItemHeight = 15;
			this.cmb_Year_From.Location = new System.Drawing.Point(110, 36);
			this.cmb_Year_From.MatchEntryTimeout = ((long)(2000));
			this.cmb_Year_From.MaxDropDownItems = ((short)(5));
			this.cmb_Year_From.MaxLength = 32767;
			this.cmb_Year_From.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Year_From.Name = "cmb_Year_From";
			this.cmb_Year_From.PartialRightColumn = false;
			this.cmb_Year_From.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Year_From.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Year_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Year_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Year_From.Size = new System.Drawing.Size(132, 21);
			this.cmb_Year_From.TabIndex = 175;
			// 
			// cmb_Factory_From
			// 
			this.cmb_Factory_From.AddItemCols = 0;
			this.cmb_Factory_From.AddItemSeparator = ';';
			this.cmb_Factory_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory_From.Caption = "";
			this.cmb_Factory_From.CaptionHeight = 17;
			this.cmb_Factory_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory_From.ColumnCaptionHeight = 18;
			this.cmb_Factory_From.ColumnFooterHeight = 18;
			this.cmb_Factory_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory_From.ContentHeight = 17;
			this.cmb_Factory_From.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory_From.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory_From.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory_From.EditorHeight = 17;
			this.cmb_Factory_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory_From.GapHeight = 2;
			this.cmb_Factory_From.ItemHeight = 15;
			this.cmb_Factory_From.Location = new System.Drawing.Point(110, 14);
			this.cmb_Factory_From.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory_From.MaxDropDownItems = ((short)(5));
			this.cmb_Factory_From.MaxLength = 32767;
			this.cmb_Factory_From.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory_From.Name = "cmb_Factory_From";
			this.cmb_Factory_From.PartialRightColumn = false;
			this.cmb_Factory_From.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Factory_From.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory_From.Size = new System.Drawing.Size(265, 21);
			this.cmb_Factory_From.TabIndex = 174;
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
			this.pictureBox9.Size = new System.Drawing.Size(101, 202);
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
			this.pictureBox12.Location = new System.Drawing.Point(384, 225);
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
			this.pictureBox13.Location = new System.Drawing.Point(144, 224);
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
			this.pictureBox14.Location = new System.Drawing.Point(0, 225);
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
			this.pictureBox15.Size = new System.Drawing.Size(168, 207);
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
			this.pictureBox16.Size = new System.Drawing.Size(352, 200);
			this.pictureBox16.TabIndex = 27;
			this.pictureBox16.TabStop = false;
			// 
			// fgrid_Formula
			// 
			this.fgrid_Formula.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Formula.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Formula.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Formula.ContextMenu = this.cmd_popmenu;
			this.fgrid_Formula.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Formula.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Formula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.fgrid_Formula.Location = new System.Drawing.Point(2, 275);
			this.fgrid_Formula.Name = "fgrid_Formula";
			this.fgrid_Formula.Size = new System.Drawing.Size(398, 260);
			this.fgrid_Formula.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Formula.TabIndex = 169;
			this.fgrid_Formula.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Formula_AfterEdit);
			// 
			// cmd_popmenu
			// 
			this.cmd_popmenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menu_AllSelect,
																						this.menu_AllCancel});
			// 
			// menu_AllSelect
			// 
			this.menu_AllSelect.Index = 0;
			this.menu_AllSelect.Text = "All Select";
			this.menu_AllSelect.Click += new System.EventHandler(this.menu_AllSelect_Click);
			// 
			// menu_AllCancel
			// 
			this.menu_AllCancel.Index = 1;
			this.menu_AllCancel.Text = "All Cancel";
			this.menu_AllCancel.Click += new System.EventHandler(this.menu_AllCancel_Click);
			// 
			// btn_close
			// 
			this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_close.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_close.ImageIndex = 0;
			this.btn_close.ImageList = this.img_Button;
			this.btn_close.Location = new System.Drawing.Point(334, 541);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(70, 24);
			this.btn_close.TabIndex = 348;
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
			this.btn_apply.Location = new System.Drawing.Point(259, 541);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(70, 24);
			this.btn_apply.TabIndex = 347;
			this.btn_apply.Text = "Apply";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// img_Type
			// 
			this.img_Type.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Type.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Type.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Type.ImageStream")));
			this.img_Type.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Pop_Formula_Copy
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(410, 568);
			this.Controls.Add(this.fgrid_Formula);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_apply);
			this.Controls.Add(this.panel2);
			this.Name = "Pop_Formula_Copy";
			this.Text = "77";
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.btn_apply, 0);
			this.Controls.SetChildIndex(this.btn_close, 0);
			this.Controls.SetChildIndex(this.fgrid_Formula, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.panel2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style_To)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_To)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year_To)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_To)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style_From)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_From)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year_From)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_From)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Formula)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수정의 

		#region 기본 변수
		int _Rowfixed = 2, _CopyValue  = 1, _Formula  = 1, _Weight  = 2, _Yield = 4;
		string _FormulaDiv = "B";
		bool _Checkin_Cancel = false;
		private COM.OraDB _MyOraDB = new COM.OraDB();
        string _remark ="Formula Copy";
		#endregion

		#region 칼라 설정
		private Color _Base_Color    = ClassLib.ComVar.ClrSel_Green;
		private Color _Pigment_Color = ClassLib.ComVar.ClrSel_Yellow;	
		#endregion

		#region  행 이미지 저장
		private Hashtable _Imgmap = new Hashtable();
		private Hashtable _ImgmapAction = new Hashtable();

		private const string _TypeSG = "S", _TypeCmp = "C", _TypeMat = "M", _TypeJoint = "J";

		private int _IxImage_SG = 1, _IxImage_Cmp = 2, _IxImage_Mat = 3, _IxImage_Joint = 4;
		//private int _IxImage_Move = 5; 
 

		#endregion


		#region 송수신 관련		
		// 체크 아웃 실패 되었을때, 다시 체크 인 표시 해 주고, 이벤트 태우지 않기 위함
		//private bool _FromCheckOut = false;

		private static bool _CheckInFail = false;
		private static bool _CheckOutFail = false;
		
		private string   _CheckInSeq ="0";
		




		#endregion 


		

		#endregion

		#region 멤버메쏘드
		private void Init_Form()
		{
			DataTable dt_list;

			//Title
			this.Text = "Formula Multi Change";
			lbl_MainTitle.Text = "   Formula Multi Change";
			ClassLib.ComFunction.SetLangDic(this);

			// 그리드 설정(TBSBC_FORMULAN_YIELD )
			fgrid_Formula.Set_Grid("SBC_FOMULAN_COPY", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			fgrid_Formula.Set_Action_Image(img_Action);
			fgrid_Formula.Cols[0].AllowEditing = false;

			fgrid_Formula.DragMode = DragModeEnum.Manual;//Automatic;
			fgrid_Formula.DropMode = DropModeEnum.Manual; 

			// 공장코드
			dt_list = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_list, cmb_Factory_From, 0, 1, false);
			cmb_Factory_From.SelectedValue = ClassLib.ComVar.This_Factory;

			dt_list = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_list, cmb_Factory_To, 0, 1, false);
			cmb_Factory_To.SelectedValue = ClassLib.ComVar.This_Factory;


			//year
			ClassLib.ComFunction.Set_Year(cmb_Year_From ,ClassLib.ComVar.ConsAll);
			ClassLib.ComFunction.Set_Year(cmb_Year_To ,ClassLib.ComVar.ConsAll);
			
			
			// season 
			dt_list =  ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSeason);
			COM.ComCtl.Set_ComboList(dt_list, cmb_Season_From  , 1, 2,  false, false);
			cmb_Season_From.SelectedValue    = ClassLib.ComVar.ConsBaseSN;

			dt_list =  ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSeason);
			COM.ComCtl.Set_ComboList(dt_list, cmb_Season_To  , 1, 2,  false, false);
			cmb_Season_To.SelectedValue    = ClassLib.ComVar.ConsBaseSN;


			// Style
			dt_list = ClassLib.ComFunction.Select_StyleList(" ");
			COM.ComCtl.Set_ComboList(dt_list, cmb_Style_From  , 0, 1, false,70,150);

			dt_list = ClassLib.ComFunction.Select_StyleList(" ");
			COM.ComCtl.Set_ComboList(dt_list, cmb_Style_To  , 0, 1, false,70,150);


			//임시 Setting..
			chk_Yield_Click(null,null);
			
			dt_list.Dispose();

			SetProperty();

		}



		
		private void Run_Check_In()
		{
			

			
			if( _CheckOutFail ) return;
 

			string division = "I"; // In
			string factory = cmb_Factory_To.SelectedValue.ToString();
			string stylecd = cmb_Style_To.SelectedValue.ToString().Replace("-", "");
			string checkuser = ClassLib.ComVar.This_User;
			string remarks = "formula Copy" + checkuser;



			
			if(_Checkin_Cancel)   // local 만 체크
			{
				Run_Check_In_Local(division, factory, stylecd, checkuser, remarks);
			}
			else  // remote, local 모두 체크
			{
				Run_Check_In_RemoteLocal(division, factory, stylecd, checkuser, remarks);
			}


		}


		private bool Run_Check_In_RemoteLocal(string arg_division, string arg_factory, string arg_stylecd, string arg_checkuser, string arg_remarks)
		{
 
	
			// 1) job factory Webservice 로 변경
			// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 3) user factory Webservice 로 변경
			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
			// 8) job factory Checkin table insert 처리
			// 9) user factory Webservice 로 변경
			// 10) 8) 성공 시 user factory Checkin table insert 처리 
			// 11) 10) 성공 시 최종 Checkin 성공
	
	
			try
			{
				// 1) job factory Webservice 로 변경
				string websvc_factory = ""; 
			
				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					websvc_factory = arg_factory;
				}
				else
				{
					websvc_factory = ClassLib.ComVar.DSFactory;
				} 
				
				// 2) job factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				// 3) user factory Webservice 로 변경
				DataTable dt_job = Form_BC_FormulaN.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory;
			

				string job_checkin_seq = "";
				string job_checkin_user = "";

				if(dt_job == null)
				{

					
			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error (Remote)"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					
					return false;


				}
				else
				{
					job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
					job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
				} 
			 

				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				DataTable dt_user =  Form_BC_FormulaN.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{

			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					
					return false;


				}
				else
				{
					user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
					user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
				}



				// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패 
 
				if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				{ 
				
				
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
	
					return false;

				} 


				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
				_CheckInSeq = checkinseq;


				// 7) 5) 가 아닌 경우,job factory Webservice 로 변경
				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					websvc_factory = arg_factory;
				}
				else
				{
					websvc_factory = ClassLib.ComVar.DSFactory;
				} 

			
				// 8) job factory Checkin table insert 처리
				// 9) user factory Webservice 로 변경
				DataSet ds_job = Form_BC_FormulaN.Save_Check_Formula_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory; 


				if(ds_job == null)
				{

			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error (Remote)"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
	
					return false;

				}
			

			
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Form_BC_FormulaN.Save_Check_Formula_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

		
				if(ds_user == null)
				{

					
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 

					return false;

				}


				// 11) 10) 성공 시 최종 Checkin 성공
				
		
				_CheckInFail = false;
				//ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

				return true;
 
			}
			catch
			{
				return false;
			}



		}


		private bool Run_Check_In_Local(string arg_division, string arg_factory, string arg_stylecd, string arg_checkuser, string arg_remarks)
		{

			
	
			// 1) job factory Webservice 로 변경
			// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 3) user factory Webservice 로 변경
			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
			// 8) job factory Checkin table insert 처리
			// 9) user factory Webservice 로 변경
			// 10) 8) 성공 시 user factory Checkin table insert 처리 
			// 11) 10) 성공 시 최종 Checkin 성공
	
	 
				
			try
			{
				// 3) user factory Webservice 로 변경 
				string websvc_factory = ""; 
				websvc_factory = ClassLib.ComVar.This_Factory;
			

				string job_checkin_seq = "0";
				string job_checkin_user = ClassLib.ComVar.This_User.Trim();

			
			 

				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				DataTable dt_user = Form_BC_FormulaN.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{

				
			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					 
	
					return false;


				}
				else
				{
					user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
					user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
				}




				// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패  

				job_checkin_user = user_checkin_user;
 
				if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				{ 
				
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
	
					return false;

				} 


				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
				_CheckInSeq = checkinseq;

 
		 
				// 9) user factory Webservice 로 변경 
				websvc_factory = ClassLib.ComVar.This_Factory;  

			
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Form_BC_FormulaN.Save_Check_Formula_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

				if(ds_user == null)
				{

				
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				
	
					return false;

				}


				// 11) 10) 성공 시 최종 Checkin 성공
				
		
				_CheckInFail = false;
				//ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

				return true;

			}
			catch
			{
				return false;
			}
  


		}


		private void Run_Check_Out()
		{
			

			if( _CheckInFail ) return;

		

			string division = "O"; // Out
			string factory = cmb_Factory_To.SelectedValue.ToString();
			string stylecd = cmb_Style_To.SelectedValue.ToString().Replace("-", "");
			string checkuser = ClassLib.ComVar.This_User;
			string remarks ="Formula Copy" + checkuser;
 

			string job_factory = ClassLib.ComVar.This_Factory; 
			DataSet ds_ret = Form_BC_FormulaN.Save_Check_Formula_InOut(division, factory, stylecd, _CheckInSeq, checkuser, remarks, job_factory);


			if(ds_ret == null)
			{
 

				_CheckOutFail = true;

				ClassLib.ComFunction.User_Message("Check Out Fail.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{


				_CheckOutFail = false;

				//ClassLib.ComFunction.User_Message("Check Out Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}



		}


		private void SetClear()
		{
			fgrid_Formula.Rows.Count  = _Rowfixed;
			//cmb_Style_To.SelectedIndex = -1;
			//txt_Style_To.Clear();

		}


		/// <summary>
		///  SetInit: 초기 화면  Setting
		/// </summary>
		/// <returns></returns>
		private void SetProperty()
		{
			try
			{
				cmb_Factory_From.SelectedValue =  COM.ComVar.Parameter_PopUp[0];
				cmb_Year_From.SelectedValue    =  COM.ComVar.Parameter_PopUp[1];
				cmb_Season_From.SelectedValue  =  COM.ComVar.Parameter_PopUp[2];
				cmb_Style_From.SelectedValue   =  COM.ComVar.Parameter_PopUp[3];
				txt_Style_From.Text            =  COM.ComVar.Parameter_PopUp[3];

				cmb_Factory_To.SelectedValue   =  COM.ComVar.Parameter_PopUp[0];
				cmb_Year_To.SelectedValue      =  COM.ComVar.Parameter_PopUp[1];
				cmb_Season_To.SelectedValue    =  COM.ComVar.Parameter_PopUp[2];

				cmb_Factory_From.Enabled  = false;
				cmb_Style_From.Enabled    = true;
				txt_Style_From.Enabled    = true;
				cmb_Season_From.Enabled   = false;
				cmb_Year_From.Enabled     = false;


				cmb_Factory_To.Enabled  = false;
				cmb_Season_To.Enabled   = false;
				cmb_Year_To.Enabled     = false;

				txt_Style_To.Focus();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetInit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		
	/// <summary>
	/// CheckCopy : Copy 전 사전 Check
	/// </summary>
	    private bool CheckCopy() 
	{
		if (cmb_Factory_To.SelectedValue.ToString().Length == 0) 
		{
			ClassLib.ComFunction.User_Message("Factory Shoulb be selected..");
			return false; 
		}
			

		if (cmb_Year_To.SelectedValue.ToString().Length == 0) 
		{
			ClassLib.ComFunction.User_Message("Year Shoulb be selected..");
			return false; 				
		}


		if (cmb_Season_To.SelectedValue.ToString().Length == 0) 
		{
			ClassLib.ComFunction.User_Message("Season Shoulb be selected..");
			return false; 
		}


		if (cmb_Style_To.SelectedValue.ToString().Length == 0) 
		{
			ClassLib.ComFunction.User_Message("Style Shoulb be selected..");
			return false; 
		}


		if ((cmb_Factory_From.SelectedValue.ToString()==cmb_Factory_To.SelectedValue.ToString()) &&
			(cmb_Year_From.ToString()==cmb_Style_To.SelectedValue.ToString()) &&
			(cmb_Season_From.SelectedValue.ToString()==cmb_Season_To.SelectedValue.ToString()) &&
			(cmb_Style_From.SelectedValue.ToString()==cmb_Style_To.SelectedValue.ToString()))
		{
			ClassLib.ComFunction.User_Message("Same Data");
			return false; 
		}

			
		return true;
	
	}


		/// <summary>
		///  SetCopyValue: Copy를위한 값 Setting
		/// </summary>
		/// <returns></returns>
		private void SetCopyValue()
		{
			try
			{
				_CopyValue= 0;

				if (chk_Yield.Checked == true)  
					_CopyValue = _Formula + _Weight + _Yield;
				else if  (chk_Weight.Checked  == true)   
					_CopyValue = _Formula + _Weight;
				else
					_CopyValue  = _Formula;
	 
				}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetCopyValue", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				SetClear();

				DataTable dt_ret;

				dt_ret = SelectFormula();

				if (dt_ret.Rows.Count  == 0) 
				{ ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch); return;}

                DisPlayFormula(dt_ret);

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

				//칼라 Setting
				fgrid_Formula.GetCellRange(i+_Rowfixed, (int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV).StyleNew.BackColor = 
					                      (fgrid_Formula[i+_Rowfixed,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV].ToString() == _FormulaDiv)?_Base_Color:_Pigment_Color;

				


			}		
	

			#region 그림이미지
			_Imgmap.Clear();

			for(int i =fgrid_Formula.Rows.Fixed; i < fgrid_Formula.Rows.Count; i++)
			{
				Display_Type_Image(i);

			}
  
			fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ImageAndText = true; 
			fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ImageMap     = _Imgmap;  

			#endregion


		}


		
		/// <summary>
		///  CheckAllChild:Child Node Check하기
		/// </summary>
		/// <returns></returns>
		private void CheckAllChild(int arg_row, int arg_col)
		{
			bool vBool;

			if (fgrid_Formula.GetCellCheck(arg_row,arg_col) == C1.Win.C1FlexGrid.CheckEnum.Checked) vBool = true; else vBool = false;				
					

			int vStartRow = fgrid_Formula.Rows[arg_row].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
			int vEndRow   = fgrid_Formula.Rows[arg_row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;						

			if (vStartRow  >_Rowfixed)
			{
				for(int i=vStartRow ; i<= vEndRow  ;i++)
				{
					fgrid_Formula[i, arg_col]   = vBool;
				}
			}
		}



		/// <summary>
		/// CheckParent :Parent Node Check하기
		/// </summary>
		/// <returns></returns>
		private void CheckParent(int arg_row, int arg_col)
		{
			//bool vBool = Convert.ToBoolean(C1.Win.C1FlexGrid.CheckEnum.Unchecked) ?  false : true;					
			bool vBool;
			if (fgrid_Formula.GetCellCheck(arg_row,arg_col) == C1.Win.C1FlexGrid.CheckEnum.Checked) vBool = true; else vBool = false;				
					

			int vParentRow       = fgrid_Formula.Rows[arg_row].Node.GetNode(NodeTypeEnum.Parent).Row.Index ;
			int vFirstSilingRow  = fgrid_Formula.Rows[vParentRow].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index ;
			int vLastSilingRow   = fgrid_Formula.Rows[vParentRow].Node.GetNode(NodeTypeEnum.LastChild).Row.Index ;

					

			if (  vFirstSilingRow >_Rowfixed)
			{						
				fgrid_Formula[arg_row, arg_col]   = vBool;

				for(int i=vFirstSilingRow; i<=  vLastSilingRow  ;i++)
				{
					if (fgrid_Formula.GetCellCheck(i,arg_col) == C1.Win.C1FlexGrid.CheckEnum.Checked)
					{  fgrid_Formula[ vParentRow, arg_col]  = true; break; }  //부모노드 true

				}
			}
		}


		/// <summary>
		/// Display_Type_Image : 이미지 표시
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Type_Image(int arg_row) 
		{

			if(_Imgmap.ContainsKey(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME ].ToString() ) ) return;

			switch(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxTYPE_DIVISION].ToString() )
					//switch(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ToString() )
			{ 		
				case _TypeSG:  
					fgrid_Formula.GetCellRange(arg_row, 1, arg_row,fgrid_Formula.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
					_Imgmap.Add(fgrid_Formula[arg_row,  (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_SG]); 
					break;

				case _TypeCmp:  
					_Imgmap.Add(fgrid_Formula[arg_row,  (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_Cmp]); 
					break;

				case _TypeMat:
					_Imgmap.Add(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_Mat]);
					break;
				
				case _TypeJoint:
					_Imgmap.Add(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_Joint]);
					break;
 
			} // end switch


		}


		#endregion 

		#region DB 컨넥트
		/// <summary>
		/// SelectFormula: Formula  조회
		/// </summary>
		/// <returns></returns>
		public DataTable SelectFormula()
		{

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
			_MyOraDB.Parameter_Values[0] = cmb_Factory_From.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[1] = cmb_Year_From.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[2] = cmb_Season_From.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[3] = cmb_Style_From.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[4] = " ";
			_MyOraDB.Parameter_Values[5] = " ";
			_MyOraDB.Parameter_Values[6] = ""; 

			_MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_MyOraDB.Process_Name]; 
		}



		
		/// <summary>
		/// CopyFormula : Bottom채산을 Option별로 복사한다.
		/// </summary>
		public void  CopyFormula()
		{
			DataSet ds_ret;
									    
			int  vCol =18;

			_MyOraDB.ReDim_Parameter(vCol); 

			_MyOraDB.Process_Name=  "PKG_SBC_FORMULA.SAVE_SBC_FORMULA_COPY";
			
			int i=0;
			_MyOraDB.Parameter_Name[i++] = "ARG_FLAG";
			_MyOraDB.Parameter_Name[i++] = "ARG_COPY_VALUE";
			_MyOraDB.Parameter_Name[i++] = "ARG_FACTORY_FROM";
			_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA_DIV";
			_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA_YEAR_FROM";
			_MyOraDB.Parameter_Name[i++] = "ARG_SEASON_CD_FROM";
			_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD_FROM";
			_MyOraDB.Parameter_Name[i++] = "ARG_MCS_CD";
			_MyOraDB.Parameter_Name[i++] = "ARG_MCS_COLOR_CD";
			_MyOraDB.Parameter_Name[i++] = "ARG_ITEM_CD";
			_MyOraDB.Parameter_Name[i++] = "ARG_SPEC_CD";
			_MyOraDB.Parameter_Name[i++] = "ARG_COLOR_CD";
			_MyOraDB.Parameter_Name[i++] = "ARG_FACTORY_TO";
			_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA_YEAR_TO";
			_MyOraDB.Parameter_Name[i++] = "ARG_SEASON_CD_TO";
			_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD_TO";
			_MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER";
			_MyOraDB.Parameter_Name[i++] = "ARG_UPD_YMD";

			for (int k=0 ; k< vCol; k++)
				_MyOraDB.Parameter_Type[k] = 1; 						


			#region Value 
			int  vRow  = 0;
			for(i =  _Rowfixed; i < fgrid_Formula.Rows.Count; i++)
			{
				if (fgrid_Formula.GetCellCheck(i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxJOB_FLAG) == C1.Win.C1FlexGrid.CheckEnum.Checked)
                   vRow ++;				
			}

			_MyOraDB.Parameter_Values = new string[vCol * vRow];

            int vCnt=0;
			for(i =  _Rowfixed; i < fgrid_Formula.Rows.Count; i++)
			{
				if(fgrid_Formula.GetCellCheck(i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxJOB_FLAG) == C1.Win.C1FlexGrid.CheckEnum.Checked)
				{ 
					if(fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxLEVEL].ToString() == "2")
					   _MyOraDB.Parameter_Values[vCnt++] = ClassLib.ComVar.ConsFirstRow;
					else
					   _MyOraDB.Parameter_Values[vCnt++] = ClassLib.ComVar.ConsOtherRow;

					_MyOraDB.Parameter_Values[vCnt++] =  Convert.ToString(_CopyValue);
					_MyOraDB.Parameter_Values[vCnt++] =  cmb_Factory_From.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV].ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  cmb_Year_From.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  cmb_Season_From.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  cmb_Style_From.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCS_CD].ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCS_COLOR_CD].ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_CD].ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_CD].ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_CD].ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  cmb_Factory_To.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  cmb_Year_To.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  cmb_Season_To.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  cmb_Style_To.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[vCnt++] =  ClassLib.ComVar.This_User;			
					_MyOraDB.Parameter_Values[vCnt++] =  System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				}
			}
			
			#endregion

			_MyOraDB.Add_Modify_Parameter(true);
			ds_ret  =  _MyOraDB.Exe_Modify_Procedure();	 



		}


		#endregion

		#region 이벤트처리

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			
			string vFactory = cmb_Factory_To.SelectedValue.ToString();
			string vStylecd = cmb_Style_To.SelectedValue.ToString().Replace("-", "");
			string vCheckuser = ClassLib.ComVar.This_User;

		


			try
			{ 

				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if((DialogResult.Yes != dr)  ||  (CheckCopy() != true) )
				{
					ClassLib.ComFunction.User_Message("" , "Target Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;

				}

                Run_Check_In ();

				if (_CheckInFail)
					ClassLib.ComFunction.User_Message("Check In Fail.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				else
					CopyFormula();				  

				
				Run_Check_Out ();


				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave,this);
				
			}
			catch(Exception ex)
			{
				Run_Check_Out ();

				ClassLib.ComFunction.User_Message(ex.Message, "btn_apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
		private void fgrid_Formula_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
							
			

			int  vR1      = fgrid_Formula.Selection.r1 ;
			int  vC1      = fgrid_Formula.Selection.c1 ;

			if (vC1 != (int)ClassLib.TBSBC_FORMULAN_COPY.lxJOB_FLAG)  return;

			string  vLevel   = fgrid_Formula[vR1,(int)ClassLib.TBSBC_FORMULAN_COPY.lxLEVEL].ToString()  ; 

			switch(vLevel)
			{
				case  "2":  //1level일때
				{
					CheckAllChild(vR1 ,vC1);
					break;
				}				
				case  "3":  //2level 일때
				{
				    CheckParent(vR1 ,vC1);
					break;
				}
			}
		}


		private void cmb_Style_From_TextChanged(object sender, System.EventArgs e)
		{
			txt_Style_From.Text = cmb_Style_From.SelectedValue.ToString();

			SetFormula();
		}

		private void chk_Formula_Click(object sender, System.EventArgs e)
		{
			chk_Formula.Checked = true;
			chk_Weight.Checked  = false;
			chk_Yield.Checked   = false;
			SetCopyValue();
		}

		private void chk_Weight_Click(object sender, System.EventArgs e)
		{
			chk_Formula.Checked = true;
			chk_Weight.Checked  = true;
			chk_Yield.Checked   = false;
			SetCopyValue();
		}		

		private void chk_Yield_Click(object sender, System.EventArgs e)
		{
			chk_Formula.Checked = true;
			chk_Weight.Checked  = true;
			chk_Yield.Checked   = true;
			SetCopyValue();
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}



		private void cmb_Style_To_TextChanged(object sender, System.EventArgs e)
		{
			if ( cmb_Style_To.SelectedIndex == -1) return;

			txt_Style_To.Text = cmb_Style_To.SelectedValue.ToString();

		}

		private void txt_Style_From_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
		
			try
			{

				if(e.KeyCode != Keys.Enter) return;
				  
				DataTable dt_list;

				dt_list = ClassLib.ComFunction.Select_StyleList(COM.ComFunction.Empty_TextBox(txt_Style_From , " "));
				COM.ComCtl.Set_ComboList(dt_list, cmb_Style_From, 0,1, false);
				cmb_Style_From.Splits[0].DisplayColumns["Code"].Width = 70;
				cmb_Style_From.Splits[0].DisplayColumns["Name"].Width = 150;
				dt_list.Dispose();

			}
			catch(Exception)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
			} 
		}

		private void txt_Style_To_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{

				if(e.KeyCode != Keys.Enter) return;
				  
				DataTable dt_list;

				dt_list = ClassLib.ComFunction.Select_StyleList(COM.ComFunction.Empty_TextBox(txt_Style_To, " "));//txt_style_cd.Text == "" ? " " : txt_style_cd.Text);
				COM.ComCtl.Set_ComboList(dt_list, cmb_Style_To  , 0,1, false);
				cmb_Style_To.Splits[0].DisplayColumns["Code"].Width = 70;
				cmb_Style_To.Splits[0].DisplayColumns["Name"].Width = 150;
				dt_list.Dispose();

			}
			catch(Exception)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
			} 


		}


		private void rad_Comp_CheckedChanged(object sender, System.EventArgs e)
		{

		
			try
			{
				RadioButton src = sender as RadioButton; 

				fgrid_Formula.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) ); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}


		private void cmb_Factory_To_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			// check in/out cancel 
			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory_To.SelectedValue.ToString(), ClassLib.ComVar.CxYieldCheckinCancel);

			if(dt_ret != null && dt_ret.Rows.Count > 0)
			{
				_Checkin_Cancel = (dt_ret.Rows[0].ItemArray[1].ToString().Trim().ToUpper().Equals("Y") ) ? true : false;
			}
			else
			{
				_Checkin_Cancel = false;
			}

		}

		#endregion


		#region 콘텍스트 메뉴


		private void menu_AllSelect_Click(object sender, System.EventArgs e)
		{
			for (int i = fgrid_Formula.Rows.Fixed ; i < fgrid_Formula.Rows.Count ; i++)
			{
				fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxLEVEL] = "True";
				//fgrid_Formula[i,] = "True";

			}
		}


		private void menu_AllCancel_Click(object sender, System.EventArgs e)
		{
		
			for (int i = fgrid_Formula.Rows.Fixed ; i < fgrid_Formula.Rows.Count  ; i++)
			{
				fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxLEVEL] = "false";
				//fgrid_Formula[i,1] = "false";


			}
		}


		#endregion


	

	}
}

