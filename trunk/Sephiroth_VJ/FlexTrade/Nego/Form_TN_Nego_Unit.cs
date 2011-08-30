using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexTrade.Nego
{
	public class Form_TN_Nego_Unit : COM.TradeWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		public COM.FSP fgrid_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.TextBox txt_nego_seq;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chk_nego;
		private System.Windows.Forms.DateTimePicker dpick_nego_from;
		private System.Windows.Forms.DateTimePicker dpick_nego_to;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_nego_date;
		private System.Windows.Forms.TextBox txt_invoice_no;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_po_no;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_po_no;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.TextBox txtstyle_cd;
		private System.Windows.Forms.Label label6;
		private System.ComponentModel.IContainer components = null;

		public Form_TN_Nego_Unit()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_TN_Nego_Unit));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.txtstyle_cd = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_nego_seq = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.chk_nego = new System.Windows.Forms.CheckBox();
			this.dpick_nego_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_nego_to = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_nego_date = new System.Windows.Forms.Label();
			this.txt_invoice_no = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_po_no = new System.Windows.Forms.TextBox();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_po_no = new System.Windows.Forms.Label();
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
				":True;98.8235294117647:False:False;0:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1020, 578);
			this.c1Sizer1.TabIndex = 31;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Location = new System.Drawing.Point(8, 119);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1008, 459);
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
			this.fgrid_main.Size = new System.Drawing.Size(1008, 459);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 36;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.txtstyle_cd);
			this.pnl_head.Controls.Add(this.label6);
			this.pnl_head.Controls.Add(this.txt_nego_seq);
			this.pnl_head.Controls.Add(this.label5);
			this.pnl_head.Controls.Add(this.chk_nego);
			this.pnl_head.Controls.Add(this.dpick_nego_from);
			this.pnl_head.Controls.Add(this.dpick_nego_to);
			this.pnl_head.Controls.Add(this.label3);
			this.pnl_head.Controls.Add(this.lbl_nego_date);
			this.pnl_head.Controls.Add(this.txt_invoice_no);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.txt_po_no);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.lbl_po_no);
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
			this.pnl_head.Size = new System.Drawing.Size(1008, 115);
			this.pnl_head.TabIndex = 4;
			// 
			// txtstyle_cd
			// 
			this.txtstyle_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtstyle_cd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtstyle_cd.Font = new System.Drawing.Font("굴림", 9F);
			this.txtstyle_cd.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtstyle_cd.Location = new System.Drawing.Point(485, 84);
			this.txtstyle_cd.MaxLength = 20;
			this.txtstyle_cd.Name = "txtstyle_cd";
			this.txtstyle_cd.Size = new System.Drawing.Size(200, 21);
			this.txtstyle_cd.TabIndex = 581;
			this.txtstyle_cd.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ImageIndex = 0;
			this.label6.ImageList = this.img_Label;
			this.label6.Location = new System.Drawing.Point(384, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 582;
			this.label6.Text = "Style #";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_nego_seq
			// 
			this.txt_nego_seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_nego_seq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_nego_seq.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_nego_seq.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_nego_seq.Location = new System.Drawing.Point(109, 84);
			this.txt_nego_seq.MaxLength = 20;
			this.txt_nego_seq.Name = "txt_nego_seq";
			this.txt_nego_seq.Size = new System.Drawing.Size(200, 21);
			this.txt_nego_seq.TabIndex = 577;
			this.txt_nego_seq.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ImageIndex = 0;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(8, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 578;
			this.label5.Text = "Nego Seq.#";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chk_nego
			// 
			this.chk_nego.Checked = true;
			this.chk_nego.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_nego.Location = new System.Drawing.Point(92, 66);
			this.chk_nego.Name = "chk_nego";
			this.chk_nego.Size = new System.Drawing.Size(13, 13);
			this.chk_nego.TabIndex = 576;
			this.chk_nego.CheckedChanged += new System.EventHandler(this.chk_nego_CheckedChanged);
			// 
			// dpick_nego_from
			// 
			this.dpick_nego_from.CustomFormat = "";
			this.dpick_nego_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_nego_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_nego_from.Location = new System.Drawing.Point(109, 62);
			this.dpick_nego_from.Name = "dpick_nego_from";
			this.dpick_nego_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_nego_from.TabIndex = 572;
			// 
			// dpick_nego_to
			// 
			this.dpick_nego_to.CustomFormat = "";
			this.dpick_nego_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_nego_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_nego_to.Location = new System.Drawing.Point(219, 61);
			this.dpick_nego_to.Name = "dpick_nego_to";
			this.dpick_nego_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_nego_to.TabIndex = 573;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(200, 64);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(16, 16);
			this.label3.TabIndex = 575;
			this.label3.Text = "~";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_nego_date
			// 
			this.lbl_nego_date.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_nego_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_nego_date.ImageIndex = 0;
			this.lbl_nego_date.ImageList = this.img_Label;
			this.lbl_nego_date.Location = new System.Drawing.Point(8, 62);
			this.lbl_nego_date.Name = "lbl_nego_date";
			this.lbl_nego_date.Size = new System.Drawing.Size(100, 21);
			this.lbl_nego_date.TabIndex = 574;
			this.lbl_nego_date.Text = "Nego Date";
			this.lbl_nego_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_invoice_no
			// 
			this.txt_invoice_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_invoice_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_invoice_no.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_invoice_no.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_invoice_no.Location = new System.Drawing.Point(485, 40);
			this.txt_invoice_no.MaxLength = 20;
			this.txt_invoice_no.Name = "txt_invoice_no";
			this.txt_invoice_no.Size = new System.Drawing.Size(200, 21);
			this.txt_invoice_no.TabIndex = 7;
			this.txt_invoice_no.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(384, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 546;
			this.label1.Text = "Invoice #";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_po_no
			// 
			this.txt_po_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_po_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_po_no.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_po_no.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_po_no.Location = new System.Drawing.Point(485, 62);
			this.txt_po_no.MaxLength = 10;
			this.txt_po_no.Name = "txt_po_no";
			this.txt_po_no.Size = new System.Drawing.Size(200, 21);
			this.txt_po_no.TabIndex = 8;
			this.txt_po_no.Text = "";
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
			// lbl_po_no
			// 
			this.lbl_po_no.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_po_no.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_po_no.ImageIndex = 0;
			this.lbl_po_no.ImageList = this.img_Label;
			this.lbl_po_no.Location = new System.Drawing.Point(384, 62);
			this.lbl_po_no.Name = "lbl_po_no";
			this.lbl_po_no.Size = new System.Drawing.Size(100, 21);
			this.lbl_po_no.TabIndex = 365;
			this.lbl_po_no.Text = "Po #";
			this.lbl_po_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(992, 99);
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
			this.pic_head4.Size = new System.Drawing.Size(968, 18);
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
			this.pic_head7.Location = new System.Drawing.Point(907, 30);
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
			this.pic_head2.Location = new System.Drawing.Point(992, 0);
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
			this.pic_head1.Size = new System.Drawing.Size(968, 32);
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
			// Form_TN_Nego_Unit
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_TN_Nego_Unit";
			this.Load += new System.EventHandler(this.Form_TN_Nego_Unit_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed;

		private int _colFACTORY			 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxFACTORY;
		private int _colNEGO_DATE		 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxNEGO_DATE;		    
		private int _colINVOICE_NO		 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxINVOICE_NO;		
		private int _colSTYLE_CD		 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxSTYLE_CD;			
		private int _colINVOICE_QTY		 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxINVOICE_QTY;		
		private int _colFACTORY_AMOUNT	 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxFACTORY_AMOUNT;	
		private int _colRATE_AA			 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxRATE_AA;			
		private int _colRATE_AB			 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxRATE_AB;			
		private int _colBALANCE_A		 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxBALANCE_A;			
		private int _colRATE_BA			 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxRATE_BA;			
		private int _colRATE_BB			 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxRATE_BB;			
		private int _colBALANCE_B		 = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxBALANCE_B;			
		private int _colBALANCE_A_AMOUNT = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxBALANCE_A_AMOUNT;	
		private int _colBALANCE_B_AMOUNT = (int)ClassLib.TBSTM_NEGO_UNIT_STATUS.IxBALANCE_B_AMOUNT;	


		#endregion


		private void Form_TN_Nego_Unit_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Nego Unit Price Status";
			this.Text		   = "Nego";


			// grid set
			fgrid_main.Set_Grid("STM_NEGO", "3", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			//fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;
			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.ListBox;
					
			//입력부 setup
			Init_Combo();					



			fgrid_main.Cols[_colINVOICE_QTY].Format		 = "#,##0";
			fgrid_main.Cols[_colFACTORY_AMOUNT].Format	 = "#,##0.00";
			fgrid_main.Cols[_colRATE_AA].Format	         = "#,##0.00";
			fgrid_main.Cols[_colRATE_AB].Format	         = "#,##0.00";
			fgrid_main.Cols[_colRATE_BA].Format	         = "#,##0.00";
			fgrid_main.Cols[_colRATE_BB].Format	         = "#,##0.00";
			fgrid_main.Cols[_colBALANCE_A].Format	     = "#,##0.00";
			fgrid_main.Cols[_colBALANCE_B].Format	     = "#,##0.00";
			fgrid_main.Cols[_colBALANCE_A_AMOUNT].Format = "#,##0.00";
			fgrid_main.Cols[_colBALANCE_B_AMOUNT].Format = "#,##0.00";
			
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
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
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
                
				string vProcedure     = "PKG_STM_NEGO.SELECT_STM_NEGO_UNIT";

				DataTable vDt = SELECT_STM_NEGO_UNIT(vProcedure);

				Clear_FlexGrid();
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


		public DataTable SELECT_STM_NEGO_UNIT(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_NEGO_DATE_FROM";
			MyOraDB.Parameter_Name[2]  = "ARG_NEGO_DATE_TO";			
			MyOraDB.Parameter_Name[3]  = "ARG_NEGO_SEQ";
			MyOraDB.Parameter_Name[4]  = "ARG_INVOICE_NO";
			MyOraDB.Parameter_Name[5]  = "ARG_PO_NO";
			MyOraDB.Parameter_Name[6]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[7]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");

			if (chk_nego.Checked)
			{
				MyOraDB.Parameter_Values[ 1]   = this.dpick_nego_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[ 2]   = this.dpick_nego_to.Text.Replace("-", "");
			}
			else
			{
				MyOraDB.Parameter_Values[ 1]   = "________";
				MyOraDB.Parameter_Values[ 2]   = "________";
			}

			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_TextBox(txt_nego_seq, "");
			MyOraDB.Parameter_Values[ 4]   = ClassLib.ComFunction.Empty_TextBox(txt_invoice_no, "");
			MyOraDB.Parameter_Values[ 5]   = ClassLib.ComFunction.Empty_TextBox(txt_po_no, "");
			MyOraDB.Parameter_Values[ 6]   = ClassLib.ComFunction.Empty_TextBox(txtstyle_cd, "");
			MyOraDB.Parameter_Values[ 7]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void Clear_FlexGrid()
		{
			if (fgrid_main.Rows.Fixed != fgrid_main.Rows.Count)
			{				
				fgrid_main.Clear(ClearFlags.UserData, fgrid_main.Rows.Fixed, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
			}
		}


		private void Display_FlexGrid(DataTable arg_dt)
		{			
			fgrid_main.Rows.Count = _Rowfixed;
			fgrid_main.Cols.Count = arg_dt.Columns.Count + 1; 

			string sNego_Date = "________";
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_main.AddItem(arg_dt.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);
				fgrid_main[i + fgrid_main.Rows.Fixed, 0] = ""; 
			
				if (sNego_Date == fgrid_main[i + fgrid_main.Rows.Fixed, _colNEGO_DATE].ToString())
					fgrid_main[i + fgrid_main.Rows.Fixed, _colNEGO_DATE] = "";
				else
					sNego_Date = fgrid_main[i + fgrid_main.Rows.Fixed, _colNEGO_DATE].ToString();
			} 

		}

		// set grid color
		private void GridSetColor()
		{
			try
			{	
				fgrid_main.Cols[_colNEGO_DATE].StyleNew.ForeColor         = Color.RoyalBlue;
				fgrid_main.Cols[_colINVOICE_NO].StyleNew.ForeColor        = Color.DarkViolet;
				fgrid_main.Cols[_colINVOICE_QTY].StyleNew.ForeColor       = Color.RoyalBlue;
				fgrid_main.Cols[_colFACTORY_AMOUNT].StyleNew.ForeColor    = Color.Red;
				fgrid_main.Cols[_colBALANCE_A].StyleNew.ForeColor         = Color.RoyalBlue;
				fgrid_main.Cols[_colBALANCE_B].StyleNew.ForeColor         = Color.RoyalBlue;
				fgrid_main.Cols[_colBALANCE_A_AMOUNT].StyleNew.ForeColor  = Color.Red;
				fgrid_main.Cols[_colBALANCE_B_AMOUNT].StyleNew.ForeColor  = Color.Red;			
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (chk_nego.Checked)
				this.btn_PrintProcess();			
		}


		private void btn_PrintProcess()
		{
			string sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TN_Nego_Unit");

			string sPara;
			
			sPara  = " /rp ";
			sPara += "'" + cmb_factory.SelectedValue.ToString()          +	"' ";
			sPara += "'" + dpick_nego_from.Text.Replace("-", "")         +	"' ";
			sPara += "'" + dpick_nego_to.Text.Replace("-", "")           +	"' ";

			FlexTrade.Report.Form_RdViewer MyReport = new FlexTrade.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Monthly Nego Unit Status";
			MyReport.Show();
				
		}



	}
}

