using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;

namespace FlexTrade.Nego
{
	public class Form_TN_Nego : COM.TradeWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		public COM.FSP fgrid_main;
		private System.Windows.Forms.Panel pnl_head;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chk_ship;
		private System.Windows.Forms.DateTimePicker dpick_ship_from;
		private System.Windows.Forms.DateTimePicker dpick_ship_to;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbl_po_type;
		private System.Windows.Forms.CheckBox chk_nego;
		private System.Windows.Forms.DateTimePicker dpick_nego_from;
		private System.Windows.Forms.DateTimePicker dpick_nego_to;
		private System.Windows.Forms.Label lbl_nego_date;
		private C1.Win.C1List.C1Combo cmb_po_type;
		private System.Windows.Forms.TextBox txt_invoice_div;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_invoice_no_to;
		private System.Windows.Forms.TextBox txt_invoice_no_from;
		private System.ComponentModel.IContainer components = null;

		public Form_TN_Nego()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_TN_Nego));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.txt_invoice_div = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_invoice_no_to = new System.Windows.Forms.TextBox();
			this.txt_invoice_no_from = new System.Windows.Forms.TextBox();
			this.cmb_po_type = new C1.Win.C1List.C1Combo();
			this.lbl_po_type = new System.Windows.Forms.Label();
			this.chk_nego = new System.Windows.Forms.CheckBox();
			this.dpick_nego_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_nego_to = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_nego_date = new System.Windows.Forms.Label();
			this.chk_ship = new System.Windows.Forms.CheckBox();
			this.dpick_ship_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_ship_to = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_po_type)).BeginInit();
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
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
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
			this.c1Sizer1.BorderWidth = 0;
			this.c1Sizer1.Controls.Add(this.panel2);
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.GridDefinition = "19.8961937716263:False:True;79.4117647058823:False:False;\t0.392156862745098:False" +
				":True;98.4313725490196:False:False;0.392156862745098:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1020, 578);
			this.c1Sizer1.TabIndex = 30;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Location = new System.Drawing.Point(8, 119);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1004, 459);
			this.panel2.TabIndex = 5;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.Color.White;
			this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 3;
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_main.Size = new System.Drawing.Size(1004, 459);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 36;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.txt_invoice_div);
			this.pnl_head.Controls.Add(this.label6);
			this.pnl_head.Controls.Add(this.txt_invoice_no_to);
			this.pnl_head.Controls.Add(this.txt_invoice_no_from);
			this.pnl_head.Controls.Add(this.cmb_po_type);
			this.pnl_head.Controls.Add(this.lbl_po_type);
			this.pnl_head.Controls.Add(this.chk_nego);
			this.pnl_head.Controls.Add(this.dpick_nego_from);
			this.pnl_head.Controls.Add(this.dpick_nego_to);
			this.pnl_head.Controls.Add(this.label4);
			this.pnl_head.Controls.Add(this.lbl_nego_date);
			this.pnl_head.Controls.Add(this.chk_ship);
			this.pnl_head.Controls.Add(this.dpick_ship_from);
			this.pnl_head.Controls.Add(this.dpick_ship_to);
			this.pnl_head.Controls.Add(this.label5);
			this.pnl_head.Controls.Add(this.label3);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.lbl_factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Location = new System.Drawing.Point(8, 0);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1004, 115);
			this.pnl_head.TabIndex = 4;
			// 
			// txt_invoice_div
			// 
			this.txt_invoice_div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_invoice_div.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_invoice_div.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_invoice_div.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_invoice_div.Location = new System.Drawing.Point(109, 84);
			this.txt_invoice_div.MaxLength = 4;
			this.txt_invoice_div.Name = "txt_invoice_div";
			this.txt_invoice_div.Size = new System.Drawing.Size(40, 21);
			this.txt_invoice_div.TabIndex = 576;
			this.txt_invoice_div.Text = "";
			this.txt_invoice_div.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(225, 88);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(8, 16);
			this.label6.TabIndex = 577;
			this.label6.Text = "~";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_invoice_no_to
			// 
			this.txt_invoice_no_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_invoice_no_to.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_invoice_no_to.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_invoice_no_to.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_invoice_no_to.Location = new System.Drawing.Point(237, 84);
			this.txt_invoice_no_to.MaxLength = 8;
			this.txt_invoice_no_to.Name = "txt_invoice_no_to";
			this.txt_invoice_no_to.Size = new System.Drawing.Size(72, 21);
			this.txt_invoice_no_to.TabIndex = 575;
			this.txt_invoice_no_to.Text = "";
			// 
			// txt_invoice_no_from
			// 
			this.txt_invoice_no_from.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_invoice_no_from.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_invoice_no_from.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_invoice_no_from.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_invoice_no_from.Location = new System.Drawing.Point(150, 84);
			this.txt_invoice_no_from.MaxLength = 8;
			this.txt_invoice_no_from.Name = "txt_invoice_no_from";
			this.txt_invoice_no_from.Size = new System.Drawing.Size(72, 21);
			this.txt_invoice_no_from.TabIndex = 574;
			this.txt_invoice_no_from.Text = "";
			// 
			// cmb_po_type
			// 
			this.cmb_po_type.AddItemCols = 0;
			this.cmb_po_type.AddItemSeparator = ';';
			this.cmb_po_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_po_type.AutoSize = false;
			this.cmb_po_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_po_type.Caption = "";
			this.cmb_po_type.CaptionHeight = 17;
			this.cmb_po_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_po_type.ColumnCaptionHeight = 18;
			this.cmb_po_type.ColumnFooterHeight = 18;
			this.cmb_po_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_po_type.ContentHeight = 17;
			this.cmb_po_type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_po_type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_po_type.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_po_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_po_type.EditorHeight = 17;
			this.cmb_po_type.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_po_type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_po_type.GapHeight = 2;
			this.cmb_po_type.ItemHeight = 15;
			this.cmb_po_type.Location = new System.Drawing.Point(109, 62);
			this.cmb_po_type.MatchEntryTimeout = ((long)(2000));
			this.cmb_po_type.MaxDropDownItems = ((short)(5));
			this.cmb_po_type.MaxLength = 32767;
			this.cmb_po_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_po_type.Name = "cmb_po_type";
			this.cmb_po_type.PartialRightColumn = false;
			this.cmb_po_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_po_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_po_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_po_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_po_type.Size = new System.Drawing.Size(200, 21);
			this.cmb_po_type.TabIndex = 2;
			// 
			// lbl_po_type
			// 
			this.lbl_po_type.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_po_type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_po_type.ImageIndex = 0;
			this.lbl_po_type.ImageList = this.img_Label;
			this.lbl_po_type.Location = new System.Drawing.Point(8, 62);
			this.lbl_po_type.Name = "lbl_po_type";
			this.lbl_po_type.Size = new System.Drawing.Size(100, 21);
			this.lbl_po_type.TabIndex = 573;
			this.lbl_po_type.Text = "PO Type";
			this.lbl_po_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chk_nego
			// 
			this.chk_nego.Location = new System.Drawing.Point(468, 66);
			this.chk_nego.Name = "chk_nego";
			this.chk_nego.Size = new System.Drawing.Size(13, 13);
			this.chk_nego.TabIndex = 571;
			this.chk_nego.CheckedChanged += new System.EventHandler(this.chk_nego_CheckedChanged);
			// 
			// dpick_nego_from
			// 
			this.dpick_nego_from.CustomFormat = "";
			this.dpick_nego_from.Enabled = false;
			this.dpick_nego_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_nego_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_nego_from.Location = new System.Drawing.Point(485, 62);
			this.dpick_nego_from.Name = "dpick_nego_from";
			this.dpick_nego_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_nego_from.TabIndex = 6;
			// 
			// dpick_nego_to
			// 
			this.dpick_nego_to.CustomFormat = "";
			this.dpick_nego_to.Enabled = false;
			this.dpick_nego_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_nego_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_nego_to.Location = new System.Drawing.Point(594, 62);
			this.dpick_nego_to.Name = "dpick_nego_to";
			this.dpick_nego_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_nego_to.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(576, 64);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(16, 16);
			this.label4.TabIndex = 570;
			this.label4.Text = "~";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_nego_date
			// 
			this.lbl_nego_date.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_nego_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_nego_date.ImageIndex = 0;
			this.lbl_nego_date.ImageList = this.img_Label;
			this.lbl_nego_date.Location = new System.Drawing.Point(384, 62);
			this.lbl_nego_date.Name = "lbl_nego_date";
			this.lbl_nego_date.Size = new System.Drawing.Size(100, 21);
			this.lbl_nego_date.TabIndex = 569;
			this.lbl_nego_date.Text = "Nego Date";
			this.lbl_nego_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chk_ship
			// 
			this.chk_ship.Location = new System.Drawing.Point(468, 44);
			this.chk_ship.Name = "chk_ship";
			this.chk_ship.Size = new System.Drawing.Size(13, 13);
			this.chk_ship.TabIndex = 566;
			this.chk_ship.CheckedChanged += new System.EventHandler(this.chk_ship_CheckedChanged);
			// 
			// dpick_ship_from
			// 
			this.dpick_ship_from.CustomFormat = "";
			this.dpick_ship_from.Enabled = false;
			this.dpick_ship_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ship_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ship_from.Location = new System.Drawing.Point(485, 40);
			this.dpick_ship_from.Name = "dpick_ship_from";
			this.dpick_ship_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_ship_from.TabIndex = 4;
			this.dpick_ship_from.ValueChanged += new System.EventHandler(this.dpick_ship_from_ValueChanged);
			// 
			// dpick_ship_to
			// 
			this.dpick_ship_to.CustomFormat = "";
			this.dpick_ship_to.Enabled = false;
			this.dpick_ship_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ship_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ship_to.Location = new System.Drawing.Point(594, 40);
			this.dpick_ship_to.Name = "dpick_ship_to";
			this.dpick_ship_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_ship_to.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(576, 42);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(16, 16);
			this.label5.TabIndex = 565;
			this.label5.Text = "~";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(384, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 564;
			this.label3.Text = "Ship Date";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 556;
			this.label1.Text = "Invoice #";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
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
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_factory.TabIndex = 1;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(988, 99);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 98);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(964, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 50;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(903, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 74);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
			this.pic_head2.Location = new System.Drawing.Point(988, 0);
			this.pic_head2.Name = "pic_head2";
			this.pic_head2.Size = new System.Drawing.Size(16, 32);
			this.pic_head2.TabIndex = 44;
			this.pic_head2.TabStop = false;
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
			this.label2.TabIndex = 42;
			this.label2.Text = "      Nego Info.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head1
			// 
			this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
			this.pic_head1.Location = new System.Drawing.Point(208, 0);
			this.pic_head1.Name = "pic_head1";
			this.pic_head1.Size = new System.Drawing.Size(964, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// pic_head5
			// 
			this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
			this.pic_head5.Location = new System.Drawing.Point(0, 99);
			this.pic_head5.Name = "pic_head5";
			this.pic_head5.Size = new System.Drawing.Size(168, 20);
			this.pic_head5.TabIndex = 43;
			this.pic_head5.TabStop = false;
			// 
			// pic_head6
			// 
			this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
			this.pic_head6.Location = new System.Drawing.Point(0, 16);
			this.pic_head6.Name = "pic_head6";
			this.pic_head6.Size = new System.Drawing.Size(168, 88);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// Form_TN_Nego
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_TN_Nego";
			this.Load += new System.EventHandler(this.Form_TN_Nego_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_po_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion



		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed;
		private int _temp_row = 0, _temp_col = 0;


		private int _colCHECK			  = (int)ClassLib.TBSTM_NEGO.IxCHECK;
		private int _colFACTORY			  = (int)ClassLib.TBSTM_NEGO.IxFACTORY;
		private int _colPO_NO			  = (int)ClassLib.TBSTM_NEGO.IxPO_NO;
		private int _colPO_ITEM			  = (int)ClassLib.TBSTM_NEGO.IxPO_ITEM;
		private int _colINVOICE_KEY		  = (int)ClassLib.TBSTM_NEGO.IxINVOICE_KEY;
		private int _colSTYLE_CD		  = (int)ClassLib.TBSTM_NEGO.IxSTYLE_CD;
		private int _colSHIP_DATE		  = (int)ClassLib.TBSTM_NEGO.IxSHIP_DATE;
		private int _colCGAC_DATE		  = (int)ClassLib.TBSTM_NEGO.IxCGAC_DATE;
		private int _colINVOICE_NO		  = (int)ClassLib.TBSTM_NEGO.IxINVOICE_NO;
		private int _colINVOICE_SHOE_QTY  = (int)ClassLib.TBSTM_NEGO.IxINVOICE_SHOE_QTY;
		private int _colFACTORY_AMOUNT    = (int)ClassLib.TBSTM_NEGO.IxFACTORY_AMOUNT;
		private int _colNEGO_AMOUNT		  = (int)ClassLib.TBSTM_NEGO.IxNEGO_AMOUNT;
		private int _colLC_NO			  = (int)ClassLib.TBSTM_NEGO.IxLC_NO;
		private int _colNEGO_DATE		  = (int)ClassLib.TBSTM_NEGO.IxNEGO_DATE;
		private int _colNEGO_SEQ		  = (int)ClassLib.TBSTM_NEGO.IxNEGO_SEQ;
		private int _colBANK_CD			  = (int)ClassLib.TBSTM_NEGO.IxBANK_CD;
		private int _colBANK_NM           = (int)ClassLib.TBSTM_NEGO.IxBANK_NM;
		private int _colEXPIRY_DATE       = (int)ClassLib.TBSTM_NEGO.IxEXPIRY_DATE;
		private int _colEXPIRY_DESC       = (int)ClassLib.TBSTM_NEGO.IxEXPIRY_DESC;
		private int _colBOOKING_NO        = (int)ClassLib.TBSTM_NEGO.IxBOOKING_NO;


		#endregion




		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Nego Management";
			this.Text		   = "Nego";

			// grid set
			fgrid_main.Set_Grid("STM_NEGO", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";
			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 

			fgrid_main.Rows[1].AllowMerging = true;

			//입력부 setup
			Init_Combo();

			txt_invoice_div.Text = System.DateTime.Now.ToString("yy")+cmb_factory.SelectedValue.ToString();

			txt_invoice_no_from.Select();

			fgrid_main.Cols[_colINVOICE_SHOE_QTY].Format  = "#,###";
			fgrid_main.Cols[_colFACTORY_AMOUNT].Format	  = "#,##0.00";
			fgrid_main.Cols[_colNEGO_AMOUNT].Format		  = "#,##0.00";
			fgrid_main.Cols[_colNEGO_DATE].Format         = "yyyy-MM-dd";
			fgrid_main.Cols[_colEXPIRY_DATE].Format       = "yyyy-MM-dd";
		}

		private void Init_Combo()
		{
			try
			{
				DataTable vDt;
				
				// factory set
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;

				//	cmb_po_type
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "STM01");
				COM.ComCtl.Set_ComboList(vDt, cmb_po_type, 1, 2, false, 80, 140);
				cmb_po_type.SelectedIndex = 0;
				vDt.Dispose();
				
			
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}


		private void Form_TN_Nego_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_STM_NEGO.SELECT_STM_NEGO";

				DataTable vDt = SELECT_STM_NEGO(vProcedure);

				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);
					GridSetColor();

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		public DataTable SELECT_STM_NEGO(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_SHIP_DATE_FROM";
			MyOraDB.Parameter_Name[2]  = "ARG_SHIP_DATE_TO";			
			MyOraDB.Parameter_Name[3]  = "ARG_PO_TYPE";
			MyOraDB.Parameter_Name[4]  = "ARG_NEGO_DATE_FROM";
			MyOraDB.Parameter_Name[5]  = "ARG_NEGO_DATE_TO";
			MyOraDB.Parameter_Name[6]  = "ARG_INVOICE_DIV";
			MyOraDB.Parameter_Name[7]  = "ARG_INVOICE_FROM";
			MyOraDB.Parameter_Name[8]  = "ARG_INVOICE_TO";			
			MyOraDB.Parameter_Name[9]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");

			if (chk_ship.Checked)
			{
				MyOraDB.Parameter_Values[1] = this.dpick_ship_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[2] = this.dpick_ship_to.Text.Replace("-", "");
			}
			else
			{
				MyOraDB.Parameter_Values[1] = "________";
				MyOraDB.Parameter_Values[2] = "________";
			}

			MyOraDB.Parameter_Values[3]   = ClassLib.ComFunction.Empty_Combo(cmb_po_type, "");

			if (chk_nego.Checked)
			{
				MyOraDB.Parameter_Values[4] = this.dpick_nego_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[5] = this.dpick_nego_to.Text.Replace("-", "");
			}
			else
			{
				MyOraDB.Parameter_Values[4] = "________";
				MyOraDB.Parameter_Values[5] = "________";
			}

			MyOraDB.Parameter_Values[6]   = ClassLib.ComFunction.Empty_TextBox(txt_invoice_div, "");
			MyOraDB.Parameter_Values[7]   = ClassLib.ComFunction.Empty_TextBox(txt_invoice_no_from, "");
			MyOraDB.Parameter_Values[8]   = ClassLib.ComFunction.Empty_TextBox(txt_invoice_no_to, "");

			MyOraDB.Parameter_Values[9]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private void Display_FlexGrid(DataTable arg_dt)
		{
			
			fgrid_main.Rows.Count = _Rowfixed;
			fgrid_main.Cols.Count = arg_dt.Columns.Count + 1; 
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_main.AddItem(arg_dt.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);
				fgrid_main[i + fgrid_main.Rows.Fixed, 0] = ""; 

			} 
		}

		// set grid color
		private void GridSetColor()
		{			
			try
			{												
				fgrid_main.Cols[_colNEGO_AMOUNT].StyleNew.ForeColor  = Color.Red;
				fgrid_main.Cols[_colLC_NO].StyleNew.ForeColor        = Color.Black;

				fgrid_main.Cols[_colPO_NO].StyleNew.ForeColor        = Color.RoyalBlue;
				fgrid_main.Cols[_colSTYLE_CD].StyleNew.ForeColor     = Color.DarkGray;
				fgrid_main.Cols[_colSHIP_DATE].StyleNew.ForeColor    = Color.DarkGray;
				fgrid_main.Cols[_colCGAC_DATE].StyleNew.ForeColor    = Color.DarkGray;
				fgrid_main.Cols[_colINVOICE_NO].StyleNew.ForeColor   = Color.DarkViolet;

				fgrid_main.Cols[_colBANK_NM].StyleNew.ForeColor      = Color.DarkGray;
				fgrid_main.Cols[_colEXPIRY_DESC].StyleNew.ForeColor  = Color.DarkGray;

				fgrid_main.Cols[_colBANK_CD].StyleNew.ForeColor  = Color.Black;
				fgrid_main.Cols[_colBANK_NM].StyleNew.ForeColor  = Color.DarkGray;

				fgrid_main.Cols[_colEXPIRY_DATE].StyleNew.ForeColor  = Color.Black;
				fgrid_main.Cols[_colEXPIRY_DESC].StyleNew.ForeColor  = Color.DarkGray;

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.btn_PrintProcess();
		}

		private void btn_PrintProcess()
		{
			string sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TN_Nego");

			string sPara;
			
			sPara  = " /rp ";
			sPara += "'" + cmb_factory.SelectedValue.ToString()  +	"' ";
			sPara += "'" + dpick_ship_from.Text.Replace("-", "") +	"' ";
			sPara += "'" + dpick_ship_to.Text.Replace("-", "")   +	"' ";

			FlexTrade.Report.Form_RdViewer MyReport = new FlexTrade.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Monthly Nego Status";
			MyReport.Show();
				
		}

		private void dpick_ship_from_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();		
		}

		private void Grid_AfterEditProcess()
		{			
			int iSel_Row = fgrid_main.Selection.r1;
			int iSel_Col = fgrid_main.Selection.c1;

			for (int iRow=_Rowfixed; iRow<fgrid_main.Rows.Count; iRow++)
			{	
				if (iSel_Col == _colCHECK)
					continue;

				Edit_MultiRow(iSel_Row, iSel_Col);
			}

			fgrid_main.Update_Row();			

			if (fgrid_main[iSel_Row, _colCHECK].ToString() == "False")
			{
				fgrid_main[iSel_Row, 0] = "";

				int dResult;
				int iDiv = Math.DivRem(iSel_Row, 2, out dResult);

				fgrid_main.GetCellRange(iSel_Row, _colCHECK,   iSel_Row, _colLC_NO).StyleNew.BackColor = Color.Lavender;
				
				if (dResult==0)					
				{
					fgrid_main.GetCellRange(iSel_Row, _colNEGO_DATE  ).StyleNew.BackColor = Color.White;
					fgrid_main.GetCellRange(iSel_Row, _colNEGO_SEQ   ).StyleNew.BackColor = Color.White;
					fgrid_main.GetCellRange(iSel_Row, _colBANK_CD    ).StyleNew.BackColor = Color.White;
					fgrid_main.GetCellRange(iSel_Row, _colBANK_NM    ).StyleNew.BackColor = Color.White;
					fgrid_main.GetCellRange(iSel_Row, _colEXPIRY_DATE).StyleNew.BackColor = Color.White;
					fgrid_main.GetCellRange(iSel_Row, _colEXPIRY_DESC).StyleNew.BackColor = Color.White;
					fgrid_main.GetCellRange(iSel_Row, _colBOOKING_NO ).StyleNew.BackColor = Color.White;
				}	
				else
				{
					fgrid_main.GetCellRange(iSel_Row, _colNEGO_DATE  ).StyleNew.BackColor = Color.FromArgb(240, 244, 250);
					fgrid_main.GetCellRange(iSel_Row, _colNEGO_SEQ   ).StyleNew.BackColor = Color.FromArgb(240, 244, 250);
					fgrid_main.GetCellRange(iSel_Row, _colBANK_CD    ).StyleNew.BackColor = Color.FromArgb(240, 244, 250);
					fgrid_main.GetCellRange(iSel_Row, _colBANK_NM    ).StyleNew.BackColor = Color.FromArgb(240, 244, 250);
					fgrid_main.GetCellRange(iSel_Row, _colEXPIRY_DATE).StyleNew.BackColor = Color.FromArgb(240, 244, 250);
					fgrid_main.GetCellRange(iSel_Row, _colEXPIRY_DESC).StyleNew.BackColor = Color.FromArgb(240, 244, 250);
					fgrid_main.GetCellRange(iSel_Row, _colBOOKING_NO ).StyleNew.BackColor = Color.FromArgb(240, 244, 250);				
				}
				
			}
			else
			{
				fgrid_main.GetCellRange(iSel_Row, _colCHECK,   iSel_Row, _colLC_NO).StyleNew.BackColor = Color.FromArgb(193, 221, 253);

				fgrid_main.GetCellRange(iSel_Row, _colNEGO_DATE  ).StyleNew.BackColor = Color.FromArgb(193, 221, 253);
				fgrid_main.GetCellRange(iSel_Row, _colNEGO_SEQ   ).StyleNew.BackColor = Color.FromArgb(193, 221, 253);
				fgrid_main.GetCellRange(iSel_Row, _colBANK_CD    ).StyleNew.BackColor = Color.FromArgb(193, 221, 253);
				fgrid_main.GetCellRange(iSel_Row, _colBANK_NM    ).StyleNew.BackColor = Color.FromArgb(193, 221, 253);
				fgrid_main.GetCellRange(iSel_Row, _colEXPIRY_DATE).StyleNew.BackColor = Color.FromArgb(193, 221, 253);
				fgrid_main.GetCellRange(iSel_Row, _colEXPIRY_DESC).StyleNew.BackColor = Color.FromArgb(193, 221, 253);
				fgrid_main.GetCellRange(iSel_Row, _colBOOKING_NO ).StyleNew.BackColor = Color.FromArgb(193, 221, 253);
			}

		}

		/// <summary>
		/// Edit_MultiRow : 여러 행 수정
		/// </summary>
		private void Edit_MultiRow(int arg_row, int arg_col)
		{	
			try
			{				
				string sTmp   = fgrid_main[arg_row, arg_col].ToString();			

				for (int iRow=_Rowfixed; iRow<fgrid_main.Rows.Count; iRow++)
				{
					if (fgrid_main[iRow, _colCHECK].ToString() == "True")
					{
						fgrid_main[iRow, arg_col] = sTmp;

						if (arg_col == _colBANK_CD)
							fgrid_main[iRow, _colBANK_NM] = fgrid_main[arg_row, _colBANK_NM];
					}

				}
 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			int    iRow   = fgrid_main.Selection.r1;
			int    iCol   = fgrid_main.Selection.c1;

			if ((iCol == _colBANK_CD)&&(fgrid_main.Cols[iCol].ComboList == "...")&&(_temp_row==iRow)&&(_temp_col==iCol))
			{					
				Get_Bank_Data();
				Edit_MultiRow(iRow, iCol);
			}
			else if (fgrid_main.Selection.r1 >= _Rowfixed)
			{
				if ((iCol == _colBANK_CD))
				{
					fgrid_main.Cols[iCol].Style.DataType = typeof(string);
					fgrid_main.Cols[iCol].ComboList = "...";
				}

					_temp_row = iRow;
					_temp_col = iCol;
			}
		}


		private void Get_Bank_Data()
		{
			int iRow = fgrid_main.Selection.r1;

			string[] keys = new string[]{ fgrid_main[iRow, _colFACTORY].ToString() };

			COM.ComVar.Parameter_PopUp = new string[0];
			Pop_TN_Bank pop_bank = new Pop_TN_Bank(keys);
			pop_bank.ShowDialog();

			if (COM.ComVar.Parameter_PopUp.Length > 1)
			{
				fgrid_main[iRow, _colBANK_CD] = COM.ComVar.Parameter_PopUp[0];
				fgrid_main[iRow, _colBANK_NM] = COM.ComVar.Parameter_PopUp[1];

				fgrid_main.Update_Row(iRow);

				COM.ComVar.Parameter_PopUp		= new string[0];
			}
			
			pop_bank.Dispose();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Validate_Check())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
				{
					this.Tbtn_SaveProcess();
				}
			}
		}

		private bool Validate_Check()
		{
			string sNego_Date = "________";
			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
			{
				if ((fgrid_main[iRow,      _colNEGO_DATE] == null) || (fgrid_main[iRow,      _colNEGO_DATE].ToString().Length == 0) ||
					(fgrid_main[iRow,          _colLC_NO] == null) || (fgrid_main[iRow,          _colLC_NO].ToString().Length == 0) ||
					(fgrid_main[iRow, _colFACTORY_AMOUNT] == null) || (fgrid_main[iRow, _colFACTORY_AMOUNT].ToString().Length == 0)  )
				{
					fgrid_main[iRow, 0] = "";
				}

				if (fgrid_main[iRow, 0].ToString() == "U")
				{
					if (sNego_Date == "________")
						sNego_Date = fgrid_main[iRow, _colNEGO_DATE].ToString();

					if (sNego_Date != fgrid_main[iRow, _colNEGO_DATE].ToString())
						fgrid_main[iRow, 0] = "";
				}

			}			

			return true;
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_STM_NEGO(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();
					MessageBox.Show("Save Complete","Save", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				}
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


		public bool SAVE_STM_NEGO(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 17;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_STM_NEGO.SAVE_STM_NEGO";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_RECORD_DIV";
				MyOraDB.Parameter_Name[ 2] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 3] = "ARG_PO_NO";
				MyOraDB.Parameter_Name[ 4] = "ARG_PO_ITEM";
				MyOraDB.Parameter_Name[ 5] = "ARG_INVOICE_KEY";
				MyOraDB.Parameter_Name[ 6] = "ARG_INVOICE_NO";
				MyOraDB.Parameter_Name[ 7] = "ARG_FACTORY_AMOUNT";
				MyOraDB.Parameter_Name[ 8] = "ARG_NEGO_DATE";
				MyOraDB.Parameter_Name[ 9] = "ARG_NEGO_SEQ";
				MyOraDB.Parameter_Name[10] = "ARG_BANK_CD";
				MyOraDB.Parameter_Name[11] = "ARG_EXPIRY_DATE";
				MyOraDB.Parameter_Name[12] = "ARG_EXPIRY_DESC";
				MyOraDB.Parameter_Name[13] = "ARG_LC_NO";
				MyOraDB.Parameter_Name[14] = "ARG_INVOICE_SHOE_QTY";
				MyOraDB.Parameter_Name[15] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				bool b = true;
				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if(fgrid_main[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();

						if (b)
							MyOraDB.Parameter_Values[para_ct+ 1] = "T";
						else
							MyOraDB.Parameter_Values[para_ct+ 1] = "F";

						b = false;
						
						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow, _colPO_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main[iRow, _colPO_ITEM].ToString();
						MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main[iRow, _colINVOICE_KEY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 6] = fgrid_main[iRow, _colINVOICE_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+ 7] = fgrid_main[iRow, _colFACTORY_AMOUNT].ToString();

						if ((fgrid_main[iRow, _colNEGO_DATE] == null)||(fgrid_main[iRow, _colNEGO_DATE].ToString().Length == 0))
							MyOraDB.Parameter_Values[para_ct+8] = "________";
						else
							MyOraDB.Parameter_Values[para_ct+8] = Convert.ToDateTime(fgrid_main[iRow, _colNEGO_DATE]).ToString("yyyyMMdd");

						if ((fgrid_main[iRow, _colNEGO_SEQ] == null)||(fgrid_main[iRow, _colNEGO_SEQ].ToString().Length == 0))
							MyOraDB.Parameter_Values[para_ct+ 9] = "0";
						else
							MyOraDB.Parameter_Values[para_ct+ 9] = fgrid_main[iRow, _colNEGO_SEQ].ToString();

						if (fgrid_main[iRow, _colBANK_CD] == null)
							MyOraDB.Parameter_Values[para_ct+10] = "";
						else
							MyOraDB.Parameter_Values[para_ct+10] = fgrid_main[iRow, _colBANK_CD].ToString();

						if ((fgrid_main[iRow, _colEXPIRY_DATE] == null)||(fgrid_main[iRow, _colEXPIRY_DATE].ToString().Length == 0))
							MyOraDB.Parameter_Values[para_ct+11] = "________";
						else
							MyOraDB.Parameter_Values[para_ct+11] = Convert.ToDateTime(fgrid_main[iRow, _colEXPIRY_DATE]).ToString("yyyyMMdd");

						if (fgrid_main[iRow, _colEXPIRY_DESC] == null)
							MyOraDB.Parameter_Values[para_ct+12] = "";
						else
							MyOraDB.Parameter_Values[para_ct+12] = fgrid_main[iRow, _colEXPIRY_DESC].ToString();

						MyOraDB.Parameter_Values[para_ct+13] = fgrid_main[iRow, _colLC_NO].ToString();

						if (fgrid_main[iRow, _colINVOICE_SHOE_QTY] == null)
							MyOraDB.Parameter_Values[para_ct+14] = "0";
						else
							MyOraDB.Parameter_Values[para_ct+14] = fgrid_main[iRow, _colINVOICE_SHOE_QTY].ToString();

						if (fgrid_main[iRow, _colSTYLE_CD] == null)
							MyOraDB.Parameter_Values[para_ct+15] = "";
						else
							MyOraDB.Parameter_Values[para_ct+15] = fgrid_main[iRow, _colSTYLE_CD].ToString().Substring(0,6)+fgrid_main[iRow, _colSTYLE_CD].ToString().Substring(7,3);
							
						MyOraDB.Parameter_Values[para_ct+16] = COM.ComVar.This_User;

						para_ct += iCount;	
					}
				
				}

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;

			}
			catch
			{
				return false;
			}
		}

		private void chk_nego_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chk_nego.Checked)
			{
				dpick_nego_from.Enabled = true;
				dpick_nego_to.Enabled   = true;
			}
			else
			{
				dpick_nego_from.Enabled = false;
				dpick_nego_to.Enabled   = false;
			}				
		}

		private void chk_ship_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chk_ship.Checked)
			{
				dpick_ship_from.Enabled = true;
				dpick_ship_to.Enabled   = true;
			}
			else
			{
				dpick_ship_from.Enabled = false;
				dpick_ship_to.Enabled   = false;
			}					
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int sel_row = fgrid_main.Selection.r1;

			if (sel_row < _Rowfixed) 
				return;			

			fgrid_main.Delete_Row();		
		}




	}
}

