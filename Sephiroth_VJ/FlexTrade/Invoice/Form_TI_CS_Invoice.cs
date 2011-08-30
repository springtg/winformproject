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

namespace FlexTrade.Invoice
{
	public class Form_TI_CS_Invoice : COM.TradeWinForm.Form_Top
	{

		#region Resource

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
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
		private System.Windows.Forms.Label lbl_po_item;
		private System.Windows.Forms.Label lbl_po_no;
		private System.Windows.Forms.TextBox txt_po_no;
		private System.Windows.Forms.TextBox txt_po_item;
		private System.Windows.Forms.Panel panel2;
		public COM.FSP fgrid_main;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Label lbl_invoice_date;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_trans_cd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dpick_ship_from;
		private System.Windows.Forms.DateTimePicker dpick_ship_to;
		private System.Windows.Forms.DateTimePicker dpick_invoice_from;
		private System.Windows.Forms.DateTimePicker dpick_invoice_to;
		private System.Windows.Forms.CheckBox chk_invoice;
		private System.Windows.Forms.CheckBox chk_ship;
		private C1.Win.C1List.C1Combo cmb_trans;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label btn_trans;
		private System.Windows.Forms.Label btn_mercury;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_lvl2;
		private System.Windows.Forms.RadioButton rad_lvl1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox chkORD;
		private System.Windows.Forms.DateTimePicker dpick_ord_date_from;
		private System.Windows.Forms.DateTimePicker dpick_ord_date_to;
		private C1.Win.C1List.C1Combo cmbTransmission;
		private C1.Win.C1List.C1Combo cmb_po_type;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rad_p2;
		private System.Windows.Forms.RadioButton rad_p1;
		private System.Windows.Forms.TextBox txt_invoice_no;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region Design Source
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_TI_CS_Invoice));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rad_p2 = new System.Windows.Forms.RadioButton();
			this.rad_p1 = new System.Windows.Forms.RadioButton();
			this.cmb_po_type = new C1.Win.C1List.C1Combo();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbTransmission = new C1.Win.C1List.C1Combo();
			this.chkORD = new System.Windows.Forms.CheckBox();
			this.dpick_ord_date_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_ord_date_to = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rad_lvl2 = new System.Windows.Forms.RadioButton();
			this.rad_lvl1 = new System.Windows.Forms.RadioButton();
			this.btn_mercury = new System.Windows.Forms.Label();
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_trans = new System.Windows.Forms.Label();
			this.chk_ship = new System.Windows.Forms.CheckBox();
			this.chk_invoice = new System.Windows.Forms.CheckBox();
			this.cmb_trans = new C1.Win.C1List.C1Combo();
			this.dpick_invoice_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_invoice_to = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dpick_ship_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_ship_to = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_invoice_no = new System.Windows.Forms.TextBox();
			this.lbl_trans_cd = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_invoice_date = new System.Windows.Forms.Label();
			this.txt_po_no = new System.Windows.Forms.TextBox();
			this.lbl_po_item = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.txt_po_item = new System.Windows.Forms.TextBox();
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
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_head.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_po_type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbTransmission)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_trans)).BeginInit();
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
			this.tbtn_Delete.Enabled = false;
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
			// tbtn_Create
			// 
			this.tbtn_Create.Enabled = false;
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
			// tbtn_Confirm
			// 
			this.tbtn_Confirm.Enabled = false;
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
			this.c1Sizer1.GridDefinition = "23.5294117647059:False:True;75.7785467128028:False:False;\t0.392156862745098:False" +
				":True;98.4313725490196:False:False;0.392156862745098:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1020, 578);
			this.c1Sizer1.TabIndex = 29;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Location = new System.Drawing.Point(8, 140);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1004, 438);
			this.panel2.TabIndex = 5;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(240)), ((System.Byte)(244)), ((System.Byte)(250)));
			this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.ContextMenu = this.contextMenu1;
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 3;
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_main.Size = new System.Drawing.Size(1004, 438);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:240, 244, 250;}	Alternate{BackColor:Window;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 36;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			this.fgrid_main.KeyPressEdit += new C1.Win.C1FlexGrid.KeyPressEditEventHandler(this.fgrid_main_KeyPressEdit);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem3});
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "Select All";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.groupBox2);
			this.pnl_head.Controls.Add(this.cmb_po_type);
			this.pnl_head.Controls.Add(this.label9);
			this.pnl_head.Controls.Add(this.cmbTransmission);
			this.pnl_head.Controls.Add(this.chkORD);
			this.pnl_head.Controls.Add(this.dpick_ord_date_from);
			this.pnl_head.Controls.Add(this.dpick_ord_date_to);
			this.pnl_head.Controls.Add(this.label7);
			this.pnl_head.Controls.Add(this.label8);
			this.pnl_head.Controls.Add(this.groupBox1);
			this.pnl_head.Controls.Add(this.btn_mercury);
			this.pnl_head.Controls.Add(this.btn_trans);
			this.pnl_head.Controls.Add(this.chk_ship);
			this.pnl_head.Controls.Add(this.chk_invoice);
			this.pnl_head.Controls.Add(this.cmb_trans);
			this.pnl_head.Controls.Add(this.dpick_invoice_from);
			this.pnl_head.Controls.Add(this.dpick_invoice_to);
			this.pnl_head.Controls.Add(this.label4);
			this.pnl_head.Controls.Add(this.dpick_ship_from);
			this.pnl_head.Controls.Add(this.dpick_ship_to);
			this.pnl_head.Controls.Add(this.label5);
			this.pnl_head.Controls.Add(this.txt_invoice_no);
			this.pnl_head.Controls.Add(this.lbl_trans_cd);
			this.pnl_head.Controls.Add(this.label3);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.lbl_invoice_date);
			this.pnl_head.Controls.Add(this.txt_po_no);
			this.pnl_head.Controls.Add(this.lbl_po_item);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.txt_po_item);
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
			this.pnl_head.Size = new System.Drawing.Size(1004, 136);
			this.pnl_head.TabIndex = 4;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.rad_p2);
			this.groupBox2.Controls.Add(this.rad_p1);
			this.groupBox2.Location = new System.Drawing.Point(831, 63);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(168, 39);
			this.groupBox2.TabIndex = 576;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Print Option";
			// 
			// rad_p2
			// 
			this.rad_p2.Location = new System.Drawing.Point(88, 19);
			this.rad_p2.Name = "rad_p2";
			this.rad_p2.Size = new System.Drawing.Size(72, 16);
			this.rad_p2.TabIndex = 35;
			this.rad_p2.Tag = "2";
			this.rad_p2.Text = "Account";
			// 
			// rad_p1
			// 
			this.rad_p1.Checked = true;
			this.rad_p1.Location = new System.Drawing.Point(8, 19);
			this.rad_p1.Name = "rad_p1";
			this.rad_p1.Size = new System.Drawing.Size(72, 16);
			this.rad_p1.TabIndex = 34;
			this.rad_p1.TabStop = true;
			this.rad_p1.Tag = "1";
			this.rad_p1.Text = "Invoice";
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
			this.cmb_po_type.Location = new System.Drawing.Point(429, 40);
			this.cmb_po_type.MatchEntryTimeout = ((long)(2000));
			this.cmb_po_type.MaxDropDownItems = ((short)(5));
			this.cmb_po_type.MaxLength = 32767;
			this.cmb_po_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_po_type.Name = "cmb_po_type";
			this.cmb_po_type.PartialRightColumn = false;
			this.cmb_po_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_po_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_po_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_po_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_po_type.Size = new System.Drawing.Size(200, 21);
			this.cmb_po_type.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ImageIndex = 0;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(328, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 575;
			this.label9.Text = "Buy Group";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbTransmission
			// 
			this.cmbTransmission.AddItemCols = 0;
			this.cmbTransmission.AddItemSeparator = ';';
			this.cmbTransmission.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbTransmission.AutoSize = false;
			this.cmbTransmission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbTransmission.Caption = "";
			this.cmbTransmission.CaptionHeight = 17;
			this.cmbTransmission.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbTransmission.ColumnCaptionHeight = 18;
			this.cmbTransmission.ColumnFooterHeight = 18;
			this.cmbTransmission.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbTransmission.ContentHeight = 17;
			this.cmbTransmission.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbTransmission.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbTransmission.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmbTransmission.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbTransmission.EditorHeight = 17;
			this.cmbTransmission.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmbTransmission.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbTransmission.GapHeight = 2;
			this.cmbTransmission.ItemHeight = 15;
			this.cmbTransmission.Location = new System.Drawing.Point(757, 40);
			this.cmbTransmission.MatchEntryTimeout = ((long)(2000));
			this.cmbTransmission.MaxDropDownItems = ((short)(5));
			this.cmbTransmission.MaxLength = 32767;
			this.cmbTransmission.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbTransmission.Name = "cmbTransmission";
			this.cmbTransmission.PartialRightColumn = false;
			this.cmbTransmission.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbTransmission.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbTransmission.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbTransmission.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbTransmission.Size = new System.Drawing.Size(67, 21);
			this.cmbTransmission.TabIndex = 573;
			// 
			// chkORD
			// 
			this.chkORD.Location = new System.Drawing.Point(412, 110);
			this.chkORD.Name = "chkORD";
			this.chkORD.Size = new System.Drawing.Size(13, 13);
			this.chkORD.TabIndex = 572;
			this.chkORD.CheckedChanged += new System.EventHandler(this.chkORD_CheckedChanged);
			// 
			// dpick_ord_date_from
			// 
			this.dpick_ord_date_from.CustomFormat = "";
			this.dpick_ord_date_from.Enabled = false;
			this.dpick_ord_date_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ord_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ord_date_from.Location = new System.Drawing.Point(429, 106);
			this.dpick_ord_date_from.Name = "dpick_ord_date_from";
			this.dpick_ord_date_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_ord_date_from.TabIndex = 568;
			this.dpick_ord_date_from.ValueChanged += new System.EventHandler(this.dpick_ord_date_from_ValueChanged);
			// 
			// dpick_ord_date_to
			// 
			this.dpick_ord_date_to.CustomFormat = "";
			this.dpick_ord_date_to.Enabled = false;
			this.dpick_ord_date_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ord_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ord_date_to.Location = new System.Drawing.Point(538, 106);
			this.dpick_ord_date_to.Name = "dpick_ord_date_to";
			this.dpick_ord_date_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_ord_date_to.TabIndex = 569;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(519, 108);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label7.Size = new System.Drawing.Size(16, 16);
			this.label7.TabIndex = 571;
			this.label7.Text = "~";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ImageIndex = 0;
			this.label8.ImageList = this.img_Label;
			this.label8.Location = new System.Drawing.Point(328, 106);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 21);
			this.label8.TabIndex = 570;
			this.label8.Text = "ORD.";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rad_lvl2);
			this.groupBox1.Controls.Add(this.rad_lvl1);
			this.groupBox1.Location = new System.Drawing.Point(831, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(168, 39);
			this.groupBox1.TabIndex = 567;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tree View Option";
			// 
			// rad_lvl2
			// 
			this.rad_lvl2.Location = new System.Drawing.Point(88, 19);
			this.rad_lvl2.Name = "rad_lvl2";
			this.rad_lvl2.Size = new System.Drawing.Size(72, 16);
			this.rad_lvl2.TabIndex = 35;
			this.rad_lvl2.Tag = "2";
			this.rad_lvl2.Text = "Invoice";
			this.rad_lvl2.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_lvl1
			// 
			this.rad_lvl1.Location = new System.Drawing.Point(9, 19);
			this.rad_lvl1.Name = "rad_lvl1";
			this.rad_lvl1.Size = new System.Drawing.Size(63, 16);
			this.rad_lvl1.TabIndex = 34;
			this.rad_lvl1.Tag = "1";
			this.rad_lvl1.Text = "Order";
			this.rad_lvl1.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// btn_mercury
			// 
			this.btn_mercury.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_mercury.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_mercury.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_mercury.ImageIndex = 0;
			this.btn_mercury.ImageList = this.img_LongButton;
			this.btn_mercury.Location = new System.Drawing.Point(798, 104);
			this.btn_mercury.Name = "btn_mercury";
			this.btn_mercury.TabIndex = 563;
			this.btn_mercury.Text = "Mercury";
			this.btn_mercury.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_mercury.Click += new System.EventHandler(this.btn_mercury_Click);
			this.btn_mercury.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_mercury_MouseUp);
			this.btn_mercury.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_mercury_MouseDown);
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_trans
			// 
			this.btn_trans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_trans.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_trans.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_trans.ImageIndex = 0;
			this.btn_trans.ImageList = this.img_LongButton;
			this.btn_trans.Location = new System.Drawing.Point(899, 104);
			this.btn_trans.Name = "btn_trans";
			this.btn_trans.TabIndex = 562;
			this.btn_trans.Text = "Transmission";
			this.btn_trans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_trans.Click += new System.EventHandler(this.btn_trans_Click);
			this.btn_trans.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_trans_MouseUp);
			this.btn_trans.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_trans_MouseDown);
			// 
			// chk_ship
			// 
			this.chk_ship.Location = new System.Drawing.Point(91, 66);
			this.chk_ship.Name = "chk_ship";
			this.chk_ship.Size = new System.Drawing.Size(13, 13);
			this.chk_ship.TabIndex = 561;
			this.chk_ship.CheckedChanged += new System.EventHandler(this.chk_ship_CheckedChanged);
			// 
			// chk_invoice
			// 
			this.chk_invoice.Location = new System.Drawing.Point(91, 88);
			this.chk_invoice.Name = "chk_invoice";
			this.chk_invoice.Size = new System.Drawing.Size(13, 13);
			this.chk_invoice.TabIndex = 559;
			this.chk_invoice.CheckedChanged += new System.EventHandler(this.chk_invoice_CheckedChanged);
			// 
			// cmb_trans
			// 
			this.cmb_trans.AddItemCols = 0;
			this.cmb_trans.AddItemSeparator = ';';
			this.cmb_trans.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_trans.AutoSize = false;
			this.cmb_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_trans.Caption = "";
			this.cmb_trans.CaptionHeight = 17;
			this.cmb_trans.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_trans.ColumnCaptionHeight = 18;
			this.cmb_trans.ColumnFooterHeight = 18;
			this.cmb_trans.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_trans.ContentHeight = 17;
			this.cmb_trans.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_trans.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_trans.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_trans.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_trans.EditorHeight = 17;
			this.cmb_trans.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_trans.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_trans.GapHeight = 2;
			this.cmb_trans.ItemHeight = 15;
			this.cmb_trans.Location = new System.Drawing.Point(429, 84);
			this.cmb_trans.MatchEntryTimeout = ((long)(2000));
			this.cmb_trans.MaxDropDownItems = ((short)(5));
			this.cmb_trans.MaxLength = 32767;
			this.cmb_trans.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_trans.Name = "cmb_trans";
			this.cmb_trans.PartialRightColumn = false;
			this.cmb_trans.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_trans.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_trans.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_trans.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_trans.Size = new System.Drawing.Size(200, 21);
			this.cmb_trans.TabIndex = 10;
			this.cmb_trans.TextChanged += new System.EventHandler(this.cmb_trans_TextChanged);
			// 
			// dpick_invoice_from
			// 
			this.dpick_invoice_from.CustomFormat = "";
			this.dpick_invoice_from.Enabled = false;
			this.dpick_invoice_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_invoice_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_invoice_from.Location = new System.Drawing.Point(109, 84);
			this.dpick_invoice_from.Name = "dpick_invoice_from";
			this.dpick_invoice_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_invoice_from.TabIndex = 4;
			this.dpick_invoice_from.ValueChanged += new System.EventHandler(this.dpick_invoice_from_ValueChanged);
			// 
			// dpick_invoice_to
			// 
			this.dpick_invoice_to.CustomFormat = "";
			this.dpick_invoice_to.Enabled = false;
			this.dpick_invoice_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_invoice_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_invoice_to.Location = new System.Drawing.Point(219, 84);
			this.dpick_invoice_to.Name = "dpick_invoice_to";
			this.dpick_invoice_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_invoice_to.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(200, 86);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(16, 16);
			this.label4.TabIndex = 557;
			this.label4.Text = "~";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dpick_ship_from
			// 
			this.dpick_ship_from.CustomFormat = "";
			this.dpick_ship_from.Enabled = false;
			this.dpick_ship_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ship_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ship_from.Location = new System.Drawing.Point(109, 62);
			this.dpick_ship_from.Name = "dpick_ship_from";
			this.dpick_ship_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_ship_from.TabIndex = 2;
			this.dpick_ship_from.ValueChanged += new System.EventHandler(this.dpick_ship_from_ValueChanged);
			// 
			// dpick_ship_to
			// 
			this.dpick_ship_to.CustomFormat = "";
			this.dpick_ship_to.Enabled = false;
			this.dpick_ship_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ship_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ship_to.Location = new System.Drawing.Point(219, 62);
			this.dpick_ship_to.Name = "dpick_ship_to";
			this.dpick_ship_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_ship_to.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(200, 64);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(16, 16);
			this.label5.TabIndex = 554;
			this.label5.Text = "~";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_invoice_no
			// 
			this.txt_invoice_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_invoice_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_invoice_no.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_invoice_no.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_invoice_no.Location = new System.Drawing.Point(109, 106);
			this.txt_invoice_no.MaxLength = 20;
			this.txt_invoice_no.Name = "txt_invoice_no";
			this.txt_invoice_no.Size = new System.Drawing.Size(200, 21);
			this.txt_invoice_no.TabIndex = 6;
			this.txt_invoice_no.Text = "";
			// 
			// lbl_trans_cd
			// 
			this.lbl_trans_cd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_trans_cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_trans_cd.ImageIndex = 0;
			this.lbl_trans_cd.ImageList = this.img_Label;
			this.lbl_trans_cd.Location = new System.Drawing.Point(328, 84);
			this.lbl_trans_cd.Name = "lbl_trans_cd";
			this.lbl_trans_cd.Size = new System.Drawing.Size(100, 21);
			this.lbl_trans_cd.TabIndex = 548;
			this.lbl_trans_cd.Text = "Transport Div.";
			this.lbl_trans_cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(8, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 547;
			this.label3.Text = "Ship Date";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 546;
			this.label1.Text = "Invoice #";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_invoice_date
			// 
			this.lbl_invoice_date.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_invoice_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_invoice_date.ImageIndex = 0;
			this.lbl_invoice_date.ImageList = this.img_Label;
			this.lbl_invoice_date.Location = new System.Drawing.Point(8, 84);
			this.lbl_invoice_date.Name = "lbl_invoice_date";
			this.lbl_invoice_date.Size = new System.Drawing.Size(100, 21);
			this.lbl_invoice_date.TabIndex = 545;
			this.lbl_invoice_date.Text = "Invoice Date";
			this.lbl_invoice_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_po_no
			// 
			this.txt_po_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_po_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_po_no.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_po_no.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_po_no.Location = new System.Drawing.Point(429, 62);
			this.txt_po_no.MaxLength = 10;
			this.txt_po_no.Name = "txt_po_no";
			this.txt_po_no.Size = new System.Drawing.Size(150, 21);
			this.txt_po_no.TabIndex = 8;
			this.txt_po_no.Text = "";
			// 
			// lbl_po_item
			// 
			this.lbl_po_item.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_po_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_po_item.ImageIndex = 0;
			this.lbl_po_item.ImageList = this.img_Label;
			this.lbl_po_item.Location = new System.Drawing.Point(656, 40);
			this.lbl_po_item.Name = "lbl_po_item";
			this.lbl_po_item.Size = new System.Drawing.Size(100, 21);
			this.lbl_po_item.TabIndex = 381;
			this.lbl_po_item.Text = "Transmission";
			this.lbl_po_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// txt_po_item
			// 
			this.txt_po_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_po_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_po_item.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_po_item.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_po_item.Location = new System.Drawing.Point(580, 62);
			this.txt_po_item.MaxLength = 5;
			this.txt_po_item.Name = "txt_po_item";
			this.txt_po_item.Size = new System.Drawing.Size(49, 21);
			this.txt_po_item.TabIndex = 9;
			this.txt_po_item.Text = "";
			// 
			// lbl_po_no
			// 
			this.lbl_po_no.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_po_no.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_po_no.ImageIndex = 0;
			this.lbl_po_no.ImageList = this.img_Label;
			this.lbl_po_no.Location = new System.Drawing.Point(328, 62);
			this.lbl_po_no.Name = "lbl_po_no";
			this.lbl_po_no.Size = new System.Drawing.Size(100, 21);
			this.lbl_po_no.TabIndex = 365;
			this.lbl_po_no.Text = "Po# / Item#";
			this.lbl_po_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(988, 120);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 119);
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
			this.pic_head7.Size = new System.Drawing.Size(101, 95);
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
			this.label2.Text = "      Invoice Info.";
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
			this.pic_head5.Location = new System.Drawing.Point(0, 120);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 109);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// menuItem1
			// 
			this.menuItem1.Index = -1;
			this.menuItem1.Text = "";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = -1;
			this.menuItem2.Text = "";
			// 
			// Form_TI_CS_Invoice
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_TI_CS_Invoice";
			this.Load += new System.EventHandler(this.Form_Load);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_head.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_po_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbTransmission)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_trans)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed;

		private int _colT_LEVEL			     = (int)ClassLib.TBSTM_INVOICE_CS.IxT_LEVEL;
		private int _colCHK			         = (int)ClassLib.TBSTM_INVOICE_CS.IxCHK;
		private int _colFACTORY 		     = (int)ClassLib.TBSTM_INVOICE_CS.IxFACTORY;
		private int _colSTYLE_CD		     = (int)ClassLib.TBSTM_INVOICE_CS.IxSTYLE_CD;
		private int _colSTYLE_NM		     = (int)ClassLib.TBSTM_INVOICE_CS.IxSTYLE_NM;
		private int _colINVOICE_DATE	     = (int)ClassLib.TBSTM_INVOICE_CS.IxSTYLE_CD;
		private int _colINVOICE_NO		     = (int)ClassLib.TBSTM_INVOICE_CS.IxSTYLE_NM;
		private int _colSHIP_DATE		     = (int)ClassLib.TBSTM_INVOICE_CS.IxGEN_NM;
		private int _colGEN_NM			     = (int)ClassLib.TBSTM_INVOICE_CS.IxGEN_NM;
		private int _colORDER_SHOE_QTY       = (int)ClassLib.TBSTM_INVOICE_CS.IxORDER_SHOE_QTY;
		private int _colINVOICE_SHOE_QTY     = (int)ClassLib.TBSTM_INVOICE_CS.IxINVOICE_SHOE_QTY;
		private int _colINVOICE_CT_QTY       = (int)ClassLib.TBSTM_INVOICE_CS.IxINVOICE_CT_QTY;
		private int _colPO_NO                = (int)ClassLib.TBSTM_INVOICE_CS.IxPO_NO;
		private int _colPO_ITEM              = (int)ClassLib.TBSTM_INVOICE_CS.IxPO_ITEM;
		private int _colPO_NO_K              = (int)ClassLib.TBSTM_INVOICE_CS.IxPO_NO_K;
		private int _colPO_ITEM_K            = (int)ClassLib.TBSTM_INVOICE_CS.IxPO_ITEM_K;

		private int _colCURRENCY	         = (int)ClassLib.TBSTM_INVOICE_CS.IxCURRENCY;
		private int _colTRADE_CS_FOB         = (int)ClassLib.TBSTM_INVOICE_CS.IxTRADE_CS_FOB;
		private int _colTRADE_FACTORY_FOB    = (int)ClassLib.TBSTM_INVOICE_CS.IxTRADE_FACTORY_FOB;

		private int _colAMOUNT               = (int)ClassLib.TBSTM_INVOICE_CS.IxAMOUNT;
		private int _colINVOICE_KEY    	     = (int)ClassLib.TBSTM_INVOICE_CS.IxINVOICE_KEY;
		private int _colLOT        	         = (int)ClassLib.TBSTM_INVOICE_CS.IxLOT;
										     
		private int _colCI_WEIGHT     	     = (int)ClassLib.TBSTM_INVOICE_CS.IxCI_WEIGHT;
		private int _colCI_NO      	         = (int)ClassLib.TBSTM_INVOICE_CS.IxCI_NO;
		private int _colCCIB      	         = (int)ClassLib.TBSTM_INVOICE_CS.IxCCIB;
										     
		private int _colCBM     	         = (int)ClassLib.TBSTM_INVOICE_CS.IxCBM;
		private int _colNET_WEIGHT     	     = (int)ClassLib.TBSTM_INVOICE_CS.IxNET_WEIGHT;
		private int _colGROSS_WEIGHT         = (int)ClassLib.TBSTM_INVOICE_CS.IxGROSS_WEIGHT;
		private int _colORD_DATE             = (int)ClassLib.TBSTM_INVOICE_CS.IxORD_DATE;
										     
		private int _colBOOKING_NO           = (int)ClassLib.TBSTM_INVOICE_CS.IxBOOKING_NO;
		private int _colBOOKING_DATE         = (int)ClassLib.TBSTM_INVOICE_CS.IxBOOKING_DATE;
		private int _colDELIVERY_DATE        = (int)ClassLib.TBSTM_INVOICE_CS.IxDELIVERY_DATE;	
		private int _colFFS_STENCIL_DEST     = (int)ClassLib.TBSTM_INVOICE_CS.IxFFS_STENCIL_DEST;
										     
		private int _colBUKRS			     = (int)ClassLib.TBSTM_INVOICE_CS.IxBUKRS;
		private int _colFFS_SOLDTO_CD	     = (int)ClassLib.TBSTM_INVOICE_CS.IxFFS_SOLDTO_CD;
		private int _colFFS_NAME2		     = (int)ClassLib.TBSTM_INVOICE_CS.IxFFS_NAME2;
		private int _colNOTIFY_KEY		     = (int)ClassLib.TBSTM_INVOICE_CS.IxNOTIFY_KEY;
		private int _colNOTIFY_NAME1	     = (int)ClassLib.TBSTM_INVOICE_CS.IxNOTIFY_NAME1;
										     
		private int _colCUST_XREF		     = (int)ClassLib.TBSTM_INVOICE_CS.IxCUST_XREF;
		private int _colWERKS			     = (int)ClassLib.TBSTM_INVOICE_CS.IxWERKS;
		private int _colFFS_SHP_TO_ACCT	     = (int)ClassLib.TBSTM_INVOICE_CS.IxFFS_SHP_TO_ACCT;

		private int _colFFS_STENCIL_SHIPTO	 = (int)ClassLib.TBSTM_INVOICE_CS.IxFFS_STENCIL_SHIPTO;
		private int _colFFS_STENCIL_ORIGIN	 = (int)ClassLib.TBSTM_INVOICE_CS.IxFFS_STENCIL_ORIGIN;
		private int _colTRANS_CD			 = (int)ClassLib.TBSTM_INVOICE_CS.IxTRANS_CD;

		private int _colMERCURY_GROSS_WEIGHT = (int)ClassLib.TBSTM_INVOICE_CS.IxMERCURY_GROSS_WEIGHT;
		private int _colMERCURY_FOB		     = (int)ClassLib.TBSTM_INVOICE_CS.IxMERCURY_FOB;
		private int _colMERCURY_AMOUNT		 = (int)ClassLib.TBSTM_INVOICE_CS.IxMERCURY_AMOUNT;
		private int _colMERCURY_CT_QTY	     = (int)ClassLib.TBSTM_INVOICE_CS.IxMERCURY_CT_QTY;
		private int _colMERCURY_SHOE_QTY	 = (int)ClassLib.TBSTM_INVOICE_CS.IxMERCURY_SHOE_QTY;
		private int _colMERCURY_LC_NO  	     = (int)ClassLib.TBSTM_INVOICE_CS.IxMERCURY_LC_NO;
		private int _colMERCURY_SHIP_DATE    = (int)ClassLib.TBSTM_INVOICE_CS.IxMERCURY_SHIP_DATE;

		private int _colRGAC_DATE            = (int)ClassLib.TBSTM_INVOICE_CS.IxRGAC_DATE;
		private int _colCUSTOM_NO            = (int)ClassLib.TBSTM_INVOICE_CS.IxCUSTOM_NO;
		private int _colCUSTOM_DATE          = (int)ClassLib.TBSTM_INVOICE_CS.IxCUSTOM_DATE;
		private int _colHXD                  = (int)ClassLib.TBSTM_INVOICE_CS.IxHXD;





		#endregion

		#region constructor / destructor

		public Form_TI_CS_Invoice()
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

		#endregion

		#region Grid Event

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			
		}


		#endregion

		#region ToolBar Menu Event

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
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

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int sel_row = fgrid_main.Selection.r1;

			if (sel_row < _Rowfixed) 
				return;

			if (fgrid_main[sel_row, _colT_LEVEL].ToString() == "1")
				return;

			if (fgrid_main[sel_row+1, _colT_LEVEL].ToString() != "1")
				return;
			

			fgrid_main.Delete_Row();
			
		}

		#endregion

		#region Control Event

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
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

		private void chk_invoice_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chk_invoice.Checked)
			{
				dpick_invoice_from.Enabled = true;
				dpick_invoice_to.Enabled   = true;
			}
			else
			{
				dpick_invoice_from.Enabled = false;
				dpick_invoice_to.Enabled   = false;
			}		
		}

		private void dpick_ship_from_ValueChanged(object sender, System.EventArgs e)
		{
			dpick_ship_to.Value = dpick_ship_from.Value;
		}

		private void dpick_invoice_from_ValueChanged(object sender, System.EventArgs e)
		{
			dpick_invoice_to.Value = dpick_invoice_from.Value;
		}

		private void btn_mercury_Click(object sender, System.EventArgs e)
		{
			if(ClassLib.ComFunction.User_Message("Do you want to apply mercury data?","Apply", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
			{
				this.btn_MercuryProcess();					
			}

		}

		private void btn_mercury_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_mercury.ImageIndex = 1;
		}

		private void btn_mercury_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_mercury.ImageIndex = 0;
		}

		private void btn_trans_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_trans.ImageIndex = 1;
		}

		private void btn_trans_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_trans.ImageIndex = 0;
		}



		#endregion

		#region DB Connect

		/// <summary>
		/// PKG_STM_INVOICE
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_STM_INVOICE(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(14);

			//01.PROCEDURE명
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_SHIP_DATE_FROM";
			MyOraDB.Parameter_Name[ 2]  = "ARG_SHIP_DATE_TO";			
			MyOraDB.Parameter_Name[ 3]  = "ARG_INVOICE_DATE_FROM";
			MyOraDB.Parameter_Name[ 4]  = "ARG_INVOICE_DATE_TO";
			MyOraDB.Parameter_Name[ 5]  = "ARG_INVOICE_NO";
			MyOraDB.Parameter_Name[ 6]  = "ARG_PO_NO";
			MyOraDB.Parameter_Name[ 7]  = "ARG_PO_ITEM";			
			MyOraDB.Parameter_Name[ 8]  = "ARG_TRANS_CD";
			MyOraDB.Parameter_Name[ 9]  = "ARG_ORD_DATE_FROM";
			MyOraDB.Parameter_Name[10]  = "ARG_ORD_DATE_TO";
			MyOraDB.Parameter_Name[11]  = "ARG_TRANSMISSION_YN";
			MyOraDB.Parameter_Name[12]  = "ARG_PO_TYPE";
			MyOraDB.Parameter_Name[13]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 8]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 9]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[10]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[12]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[13]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");

			if (chk_ship.Checked)
			{
				MyOraDB.Parameter_Values[ 1]   = this.dpick_ship_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[ 2]   = this.dpick_ship_to.Text.Replace("-", "");
			}
			else
			{
				MyOraDB.Parameter_Values[ 1]   = "________";
				MyOraDB.Parameter_Values[ 2]   = "________";
			}

			if (chk_invoice.Checked)
			{
				MyOraDB.Parameter_Values[ 3]   = this.dpick_invoice_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[ 4]   = this.dpick_invoice_to.Text.Replace("-", "");
			}
			else
			{
				MyOraDB.Parameter_Values[ 3]   = "________";
				MyOraDB.Parameter_Values[ 4]   = "________";
			}

			MyOraDB.Parameter_Values[ 5]   = ClassLib.ComFunction.Empty_TextBox(txt_invoice_no, "");

			MyOraDB.Parameter_Values[ 6]   = ClassLib.ComFunction.Empty_TextBox(txt_po_no, "");
			MyOraDB.Parameter_Values[ 7]   = ClassLib.ComFunction.Empty_TextBox(txt_po_item, "");
			MyOraDB.Parameter_Values[ 8]   = ClassLib.ComFunction.Empty_Combo(cmb_trans, "");

			if (chkORD.Checked)
			{
				MyOraDB.Parameter_Values[ 9]   = this.dpick_ord_date_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[10]   = this.dpick_ord_date_to.Text.Replace("-", "");
			}
			else
			{
				MyOraDB.Parameter_Values[ 9]   = "________";
				MyOraDB.Parameter_Values[10]   = "________";
			}
			
			MyOraDB.Parameter_Values[11]   = ClassLib.ComFunction.Empty_Combo(cmbTransmission, "");

			MyOraDB.Parameter_Values[12]   = ClassLib.ComFunction.Empty_Combo(cmb_po_type, "");

			MyOraDB.Parameter_Values[13]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}



		public bool SAVE_STM_INVOICE(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 18;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_STM_INVOICE_CS.SAVE_STM_INVOICE_CS";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_PO_NO";
				MyOraDB.Parameter_Name[ 3] = "ARG_PO_ITEM";
				MyOraDB.Parameter_Name[ 4] = "ARG_INVOICE_KEY";
				MyOraDB.Parameter_Name[ 5] = "ARG_DS_FOB";
				MyOraDB.Parameter_Name[ 6] = "ARG_FACTORY_FOB";
				MyOraDB.Parameter_Name[ 7] = "ARG_AMOUNT";
				MyOraDB.Parameter_Name[ 8] = "ARG_MERCURY_CT_QTY";
				MyOraDB.Parameter_Name[ 9] = "ARG_MERCURY_SHOE_QTY";
				MyOraDB.Parameter_Name[10] = "ARG_MERCURY_FOB";
				MyOraDB.Parameter_Name[11] = "ARG_MERCURY_AMOUNT";
				MyOraDB.Parameter_Name[12] = "ARG_MERCURY_LC_NO";
				MyOraDB.Parameter_Name[13] = "ARG_MERCURY_SHIP_DATE";
				MyOraDB.Parameter_Name[14] = "ARG_CUSTOM_NO";
				MyOraDB.Parameter_Name[15] = "ARG_CUSTOM_DATE";
				MyOraDB.Parameter_Name[16] = "ARG_HXD";
				MyOraDB.Parameter_Name[17] = "ARG_UPD_USER";


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if (fgrid_main[iRow, _colT_LEVEL].ToString() == "1")
						continue;

					if (fgrid_main[iRow, 0] == null)
						continue;

					if (fgrid_main[iRow, 0].ToString() == "")
						continue;
				
					MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
					MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iRow, _colFACTORY].ToString();
					MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colPO_NO_K].ToString();
					MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow, _colPO_ITEM_K].ToString();
					MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main[iRow, _colINVOICE_KEY].ToString();
					MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main[iRow, _colTRADE_CS_FOB].ToString();
					MyOraDB.Parameter_Values[para_ct+ 6] = fgrid_main[iRow, _colTRADE_FACTORY_FOB].ToString();
					MyOraDB.Parameter_Values[para_ct+ 7] = fgrid_main[iRow, _colAMOUNT].ToString();
					
					if (fgrid_main[iRow, _colMERCURY_CT_QTY] == null)
						MyOraDB.Parameter_Values[para_ct+8] = "0";
					else
						MyOraDB.Parameter_Values[para_ct+8] = fgrid_main[iRow, _colMERCURY_CT_QTY].ToString();
					
					if (fgrid_main[iRow, _colMERCURY_SHOE_QTY] == null)
						MyOraDB.Parameter_Values[para_ct+9] = "0";
					else
						MyOraDB.Parameter_Values[para_ct+9] = fgrid_main[iRow, _colMERCURY_SHOE_QTY].ToString();						

					if (fgrid_main[iRow, _colMERCURY_FOB] == null)
						MyOraDB.Parameter_Values[para_ct+10] = "0";
					else
						MyOraDB.Parameter_Values[para_ct+10] = fgrid_main[iRow, _colMERCURY_FOB].ToString();						

					if (fgrid_main[iRow, _colMERCURY_AMOUNT] == null)
						MyOraDB.Parameter_Values[para_ct+11] = "0";
					else
						MyOraDB.Parameter_Values[para_ct+11] = fgrid_main[iRow, _colMERCURY_AMOUNT].ToString();						

					if (fgrid_main[iRow, _colMERCURY_LC_NO] == null)
						MyOraDB.Parameter_Values[para_ct+12] = "";
					else
						MyOraDB.Parameter_Values[para_ct+12] = fgrid_main[iRow, _colMERCURY_LC_NO].ToString();

					if (fgrid_main[iRow, _colMERCURY_SHIP_DATE] == null)
						MyOraDB.Parameter_Values[para_ct+13] = "";
					else if (fgrid_main[iRow, _colMERCURY_SHIP_DATE].ToString().Length < 2)
						MyOraDB.Parameter_Values[para_ct+13] = "";
					else
						MyOraDB.Parameter_Values[para_ct+13] = Convert.ToDateTime(fgrid_main[iRow, _colMERCURY_SHIP_DATE]).ToString("yyyyMMdd");

					if (fgrid_main[iRow, _colCUSTOM_NO] == null)
						MyOraDB.Parameter_Values[para_ct+14] = "";
					else
						MyOraDB.Parameter_Values[para_ct+14] = fgrid_main[iRow, _colCUSTOM_NO].ToString();						

					if ((fgrid_main[iRow, _colCUSTOM_DATE] == null)||(fgrid_main[iRow, _colCUSTOM_DATE].ToString().Length == 0))
						MyOraDB.Parameter_Values[para_ct+ 15] = "________";
					else
						MyOraDB.Parameter_Values[para_ct+ 15] = Convert.ToDateTime(fgrid_main[iRow, _colCUSTOM_DATE]).ToString("yyyyMMdd");

					if (fgrid_main[iRow, _colHXD] == null)
						MyOraDB.Parameter_Values[para_ct+16] = "";
					else
						MyOraDB.Parameter_Values[para_ct+16] = fgrid_main[iRow, _colHXD].ToString();

					MyOraDB.Parameter_Values[para_ct+17] = COM.ComVar.This_User;

					para_ct += iCount;	
				
				
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

		private bool APPLY_MERCURY_INVOICE(bool doExecute)
		{
			try
			{
				DataTable dt_list = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxSQL);

				string sDataSource = dt_list.Rows[0].ItemArray[1].ToString();
				string sID		   = dt_list.Rows[0].ItemArray[3].ToString();
				string sPassword   = dt_list.Rows[0].ItemArray[5].ToString();

				string MSSQLCon;

				if (sPassword.Length == 0)
					MSSQLCon=@"Provider=SQLOLEDB.1;Data Source="+sDataSource+";User ID="+sID+";Persist Security Info=False;Initial Catalog=MercuryFFSdb";
				else
					MSSQLCon=@"Provider=SQLOLEDB.1;Data Source="+sDataSource+";User ID="+sID+";Password="+sPassword+";Persist Security Info=False;Initial Catalog=MercuryFFSdb";

				OleDbConnection AdoConn = null;		
				AdoConn = new OleDbConnection(MSSQLCon);
			
				OleDbDataReader myreader;
				OleDbCommand Cmd;

				for (int iRow = _Rowfixed; iRow < fgrid_main.Rows.Count; iRow++)
				{
					if (fgrid_main[iRow, _colT_LEVEL].ToString() == "1")
						continue;

					if (fgrid_main[iRow, _colCHK].ToString() == "True")
					{
						AdoConn.Close();
						AdoConn.Open();

						string sQUERY = MERCURY_QUERY_STRING(cmb_factory.SelectedValue.ToString(), 
															 fgrid_main[iRow, _colINVOICE_NO].ToString(),
															 fgrid_main[iRow, _colPO_NO_K].ToString(),
															 fgrid_main[iRow, _colPO_ITEM_K].ToString()  );

						Cmd = new OleDbCommand(sQUERY, AdoConn);               
						myreader = Cmd.ExecuteReader();

						myreader.Read();

						if (Convert.ToInt32(myreader[1]) > 0 )
						{
							fgrid_main[iRow, _colMERCURY_CT_QTY]    = myreader[0].ToString();
							fgrid_main[iRow, _colMERCURY_SHOE_QTY]  = myreader[1].ToString();
							fgrid_main[iRow, _colMERCURY_FOB]	    = myreader[2].ToString();
							fgrid_main[iRow, _colMERCURY_AMOUNT]    = myreader[3].ToString();
							fgrid_main[iRow, _colMERCURY_LC_NO]     = myreader[4].ToString();
							fgrid_main[iRow, _colMERCURY_SHIP_DATE] = myreader[5].ToString().Substring(0, 10);
							

							fgrid_main[iRow, 0] = "U";

							if (fgrid_main[iRow, _colMERCURY_SHOE_QTY].ToString() != fgrid_main[iRow, _colINVOICE_SHOE_QTY].ToString()) 
							{
								fgrid_main.GetCellRange(iRow, _colMERCURY_SHOE_QTY).StyleNew.BackColor = Color.Red;
								fgrid_main.GetCellRange(iRow, _colMERCURY_SHOE_QTY).StyleNew.ForeColor = Color.White;							
							}

							if (fgrid_main[iRow, _colMERCURY_FOB].ToString()      != fgrid_main[iRow, _colTRADE_CS_FOB].ToString())
							{
								fgrid_main.GetCellRange(iRow, _colMERCURY_FOB).StyleNew.BackColor = Color.Red;
								fgrid_main.GetCellRange(iRow, _colMERCURY_FOB).StyleNew.ForeColor = Color.White;								
							}
						}
						else if (myreader[4].ToString().Length > 0 )
						{
							fgrid_main[iRow, _colMERCURY_LC_NO] = myreader[4].ToString();
							fgrid_main[iRow, 0] = "U";
						}
						else
						{
							fgrid_main[iRow, _colCHK] = "False";
						}

						Cmd.Dispose();
						myreader = null;
														
					}
			
				}
				
				return true;

			}
			catch
			{
				return false;
			}
		}
	


		#endregion

		#region Method

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "CS Invoice Management";
			this.Text		   = "CS Invoice";


			// grid set
			fgrid_main.Set_Grid("STM_INVOICE_CS", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.ListBox;

					

			//입력부 setup
			Init_Combo();		

			fgrid_main.Cols[_colINVOICE_CT_QTY].Format		= "#,###";
			fgrid_main.Cols[_colORDER_SHOE_QTY].Format		= "#,###";
			fgrid_main.Cols[_colINVOICE_SHOE_QTY].Format	= "#,###";
			fgrid_main.Cols[_colTRADE_CS_FOB].Format		= "#,##0.00";
			fgrid_main.Cols[_colTRADE_FACTORY_FOB].Format	= "#,##0.00";
			fgrid_main.Cols[_colAMOUNT].Format				= "#,##0.00";

			fgrid_main.Cols[_colMERCURY_CT_QTY].Format	    = "#,###";
			fgrid_main.Cols[_colMERCURY_SHOE_QTY].Format	= "#,###";
			fgrid_main.Cols[_colMERCURY_FOB].Format			= "#,##0.00";
			fgrid_main.Cols[_colMERCURY_AMOUNT].Format		= "#,##0.00";

			fgrid_main.Cols[_colCI_WEIGHT].Format			= "#,###";
			fgrid_main.Cols[_colCBM].Format					= "#,##0.0";
			fgrid_main.Cols[_colNET_WEIGHT].Format			= "#,##0";
			fgrid_main.Cols[_colGROSS_WEIGHT].Format		= "#,##0";

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

				//	cmb_trans
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "STM03");
				COM.ComCtl.Set_ComboList(vDt, cmb_trans, 1, 2, true, 80, 140);
				cmb_trans.SelectedIndex = 0;
				vDt.Dispose();

				//	cmb_po_type
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "STM01");
				COM.ComCtl.Set_ComboList(vDt, cmb_po_type, 1, 2, true, 80, 140);
				cmb_po_type.SelectedIndex = 0;
				vDt.Dispose();

				//	yn
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "STM08");
				COM.ComCtl.Set_ComboList(vDt, cmbTransmission, 1, 2, true, 80, 140);
				cmbTransmission.SelectedIndex = 0;
				vDt.Dispose();
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_STM_INVOICE_CS.SELECT_STM_INVOICE_CS";

				DataTable vDt = SELECT_STM_INVOICE(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					fgrid_main.Tree.Column = _colT_LEVEL; 
										
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
			int iRow_fixed = fgrid_main.Rows.Fixed;
			int iLevel = 0; 
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{
				iLevel = Convert.ToInt32(arg_dt.Rows[iRow].ItemArray[_colT_LEVEL-1].ToString() );
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(iRow_fixed + iRow, iLevel);

				// data setting
				fgrid_main[newRow.Row.Index, _colCHK] = "";
				fgrid_main[newRow.Row.Index, _colSTYLE_CD] = "";
				fgrid_main[newRow.Row.Index, _colGEN_NM] = "";


				// design setting
				if (iLevel == 1)
				{										
					
					fgrid_main.Cols[_colSTYLE_CD].Style.DataType = typeof(string);
					fgrid_main.Cols[  _colGEN_NM].Style.DataType = typeof(string);

					fgrid_main.Rows[newRow.Row.Index].AllowEditing = false;
					
				}
				else if(iLevel == 2)
				{				
					fgrid_main.Cols[_colBOOKING_DATE].Style.Format   = "yyyy-MM-dd";
					fgrid_main.Cols[_colDELIVERY_DATE].Style.Format  = "yyyy-MM-dd";					
					fgrid_main.Cols[_colORD_DATE].Style.Format       = "yyyy-MM-dd";
					fgrid_main.Cols[_colCUSTOM_DATE].Style.Format    = "yyyy-MM-dd";
				}


				for (int iCol = 1 ; iCol < arg_dt.Columns.Count ; iCol++)
				{
					fgrid_main[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}

				fgrid_main.Tree.Column = _colSTYLE_CD;
			}

			rad_lvl1.Checked = true;
			fgrid_main.Tree.Show(2); 

		}

		// set grid color
		private void GridSetColor()
		{
			try
			{				
				string sLevel = "";
				CellRange vRange;
				CellRange vRange_1;
				CellRange vRange_2;
				CellRange vRange_3;
				CellRange vRange_4;
//				CellRange vRange_5;
//				CellRange vRange_6;
//				CellRange vRange_7;


				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{


					sLevel      = fgrid_main[iRow, _colT_LEVEL].ToString();
					vRange      = fgrid_main.GetCellRange(iRow, 1, iRow, fgrid_main.Cols.Count-1);
					vRange_1    = fgrid_main.GetCellRange(iRow, 1, iRow, _colGEN_NM);

					vRange_2    = fgrid_main.GetCellRange(iRow, _colTRANS_CD,			iRow,   _colAMOUNT);
					vRange_3    = fgrid_main.GetCellRange(iRow, _colAMOUNT+1,           iRow,   _colHXD);

					vRange_4    = fgrid_main.GetCellRange(iRow, _colWERKS,              iRow,   fgrid_main.Cols.Count-1);

//					vRange_5    = fgrid_main.GetCellRange(iRow, _colFFS_STENCIL_DEST+1, iRow,   _colGAC_DATE);
//					vRange_6    = fgrid_main.GetCellRange(iRow, _colNOTIFY_NAME1+1,     iRow,   fgrid_main.Cols.Count-1);


					if (sLevel.Equals("1"))
					{						
						fgrid_main.GetCellRange(iRow, _colINVOICE_SHOE_QTY).StyleNew.ForeColor = Color.Red;

						fgrid_main.GetCellRange(iRow, _colAMOUNT).StyleNew.ForeColor = Color.Red;						

						fgrid_main.GetCellRange(iRow, _colCURRENCY, iRow, _colTRADE_FACTORY_FOB).StyleNew.ForeColor = Color.DarkGray;
	
						vRange_4.StyleNew.ForeColor = Color.DarkGray;
//						vRange_5.StyleNew.ForeColor = Color.DarkGray;

						fgrid_main.GetCellRange(iRow, _colPO_NO).StyleNew.ForeColor   = Color.RoyalBlue;
						fgrid_main.GetCellRange(iRow, _colPO_ITEM).StyleNew.ForeColor = Color.RoyalBlue;

						fgrid_main.GetCellRange(iRow, _colSTYLE_CD).StyleNew.ForeColor = Color.DarkGray;
						fgrid_main.GetCellRange(iRow, _colSTYLE_NM).StyleNew.ForeColor = Color.DarkGray;
						fgrid_main.GetCellRange(iRow, _colGEN_NM).StyleNew.ForeColor   = Color.Black;

					}
					else if (sLevel.Equals("2"))
					{
						fgrid_main.GetCellRange(iRow,      _colAMOUNT).StyleNew.ForeColor = Color.RoyalBlue;
						fgrid_main.GetCellRange(iRow, _colTRADE_CS_FOB).StyleNew.ForeColor = Color.DarkGreen;

						vRange_1.StyleNew.BackColor = Color.WhiteSmoke;
						vRange_2.StyleNew.BackColor = Color.White;


						vRange_3.StyleNew.BackColor = Color.LightYellow;
//						fgrid_main.GetCellRange(iRow, _colMERCURY_CT_QTY).StyleNew.BackColor       = Color.LightYellow;
//						fgrid_main.GetCellRange(iRow, _colMERCURY_SHOE_QTY).StyleNew.BackColor     = Color.LightYellow;
//						fgrid_main.GetCellRange(iRow, _colMERCURY_FOB).StyleNew.BackColor	       = Color.LightYellow;
//						fgrid_main.GetCellRange(iRow, _colMERCURY_AMOUNT).StyleNew.BackColor       = Color.LightYellow;
//						fgrid_main.GetCellRange(iRow, _colMERCURY_GROSS_WEIGHT).StyleNew.BackColor = Color.LightYellow;
//						fgrid_main.GetCellRange(iRow, _colMERCURY_LC_NO).StyleNew.BackColor        = Color.LightYellow;

						vRange_4.StyleNew.BackColor = Color.White;
//						vRange_5.StyleNew.BackColor = Color.White;
//						vRange_6.StyleNew.BackColor = Color.White;

//						fgrid_main.GetCellRange(iRow, _colFFS_SOLDTO_CD).StyleNew.ForeColor = Color.Black;
//						fgrid_main.GetCellRange(iRow, _colNOTIFY_KEY).StyleNew.ForeColor = Color.DarkGreen;
						fgrid_main.GetCellRange(iRow, _colFFS_SOLDTO_CD, iRow, _colNOTIFY_NAME1).StyleNew.BackColor = Color.White;
						
						
						fgrid_main.GetCellRange(iRow, _colSTYLE_CD).StyleNew.ForeColor = Color.DarkViolet;
						fgrid_main.GetCellRange(iRow, _colSTYLE_NM).StyleNew.ForeColor = Color.DarkViolet;

					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}

		private void Grid_AfterEditProcess()
		{
			int iCol = fgrid_main.Selection.c1;
			int iRow = fgrid_main.Selection.r1;

			if (iCol == _colCHK)
				return;

			fgrid_main.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_STM_INVOICE(true))
				{
					fgrid_main.Refresh_Division();
					//this.Tbtn_SearchProcess();
					MessageBox.Show("Create Complete","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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



		private bool Validate_Check()
		{
			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
			{
				if (fgrid_main[iRow, _colSTYLE_NM].ToString().Replace(" ", "").Trim().Length == 0)
				{
					fgrid_main[iRow, 0] = "";
				}
			}			

			txt_po_no.Select();

			return true;
		}


		private void btn_MercuryProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (APPLY_MERCURY_INVOICE(true))
				{
					MessageBox.Show("Apply Complete","Mercury", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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



		private string MERCURY_QUERY_STRING(string arg_factory, string arg_invoice_no, string arg_po_no, string arg_po_item)
		{

			string sQUERY =
							" SELECT ISNULL(MAX(A.CARTONS),    0) AS MERCURY_CT_QTY,                               " +
							"        ISNULL(MAX(A.SHOE_QTY),   0) AS MERCURY_SHOE_QTY,                             " +
							"        ISNULL(MAX(A.FOB),        0) AS MERCURY_FOB,                                  " +
							"        ISNULL(MAX(A.AMOUNT),     0) AS MERCURY_AMOUNT,                               " +
							"        ISNULL(MAX(A.LC),       '_') AS LC,                                           " +
							"        ISNULL(MAX(A.SHIPDATE),  '') AS SHIPDATE                                      " +
							"  FROM (                                                                              " +
							"        SELECT CARTONS, 0 AS SHOE_QTY, 0 AS FOB, 0 AS AMOUNT, LC, SHIPDATE            " +
							"          FROM RPTCIHEADER                                                            " +
							"         WHERE FACTORYCODE   = '" + arg_factory							       + "'" +
							"           AND REPORTREQUEST = ( SELECT MAX(REPORTREQUEST)                            " +
							"                                   FROM RPTCIHEADER                                   " +
							"                                  WHERE FACTORYCODE = '" + arg_factory		       + "'" +
							"                                    AND INVOICENO   = '" + arg_invoice_no	       + "'" +
							"                                    AND PONUMBER    = '" + arg_po_no		       + "'" +
							"                                  GROUP BY INVOICENO              )                   " +
							"           AND INVOICENO     = '" + arg_invoice_no							       + "'" +
							"           AND PONUMBER      = '" + arg_po_no								       + "'" +
							"         UNION ALL                                                                    " +
							"        SELECT 0 AS CARTONS, TOTALQTY AS SHOE_QTY, PRICE AS FOB,                      " +
							"               (TOTALQTY*PRICE) AS AMOUNT, '' AS LC, '' AS SHIPDATE                   " +
							"          FROM RPTCILINE                                                              " +
							"         WHERE FACTORYCODE   = '" + arg_factory							       + "'" +
							"           AND REPORTREQUEST = ( SELECT MAX(REPORTREQUEST)                            " +
							"                                   FROM RPTCILINE                                     " +
							"                                  WHERE FACTORYCODE = '" + arg_factory		       + "'" +
							"                                    AND INVOICENO   = '" + arg_invoice_no	       + "'" +
							"                                    AND PONUMBER    = '" + arg_po_no		       + "'" +
							"                                    AND ITEMSEQ     = '" + arg_po_item		       + "'" +
							"                                  GROUP BY INVOICENO             )                    " +
							"           AND INVOICENO     = '" + arg_invoice_no							       + "'" +
							"           AND PONUMBER      = '" + arg_po_no								       + "'" +
							"           AND ITEMSEQ       = '" + arg_po_item							       + "'" +
				            "         UNION ALL                                                                    " +
                            "        SELECT 0 AS CARTONS, 0 AS SHOE_QTY, 0 AS FOB, 0 AS AMOUNT,                    " +
                            "               CASE WHEN XBLNR IS NULL THEN FFS_LC_REF_NBR ELSE XBLNR END AS LC,      " +
                            "               '' AS SHIPDATE                                                         " +
                            "          FROM LIKP                                                                   " +
                            "         WHERE PRONU = '" + arg_invoice_no							               + "'" +
							"       ) A                                                                            " ;

			return sQUERY;

		}


		#endregion

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}

		private void Tbtn_PrintProcess()
		{
			string sDir = "";
			if (ClassLib.ComVar.This_Factory == "DS")
				sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Invoice_List_CS");
			else if (ClassLib.ComVar.This_Factory == "VJ")
			{
				if (rad_p1.Checked)
					sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Invoice_List");
				else
					sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Invoice_Account");
			}

			string sPara;
			
			sPara  = " /rp ";
			sPara += "'" + cmb_factory.SelectedValue.ToString()  +	"' ";

			if (chk_ship.Checked)
			{
				sPara += "'" + dpick_ship_from.Text.Replace("-", "")  +	"' ";
				sPara += "'" + dpick_ship_to.Text.Replace("-", "")    +	"' ";
			}
			else
			{
				sPara += "'" + "________"  + "' ";
				sPara += "'" + "________"  + "' ";
			}

			if (chkORD.Checked)
			{
				sPara += "'" + dpick_ord_date_from.Text.Replace("-", "")  +	"' ";
				sPara += "'" + dpick_ord_date_to.Text.Replace("-", "")    +	"' ";
			}
			else
			{
				sPara += "'" + "________"  + "' ";
				sPara += "'" + "________"  + "' ";
			}

			sPara += "'" + cmb_trans.SelectedValue.ToString()    +	"' ";

			if (chk_invoice.Checked)
			{
				sPara += "'" + dpick_invoice_from.Text.Replace("-", "")  +	"' ";
				sPara += "'" + dpick_invoice_to.Text.Replace("-", "")    +	"' ";
			}
			else
			{
				sPara += "'" + "________"  + "' ";
				sPara += "'" + "________"  + "' ";
			}

			FlexTrade.Report.Form_RdViewer MyReport = new FlexTrade.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Invoice LIst";
			MyReport.Show();
		}

		private void cmb_trans_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void fgrid_main_KeyPressEdit(object sender, C1.Win.C1FlexGrid.KeyPressEditEventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			int iCol = fgrid_main.Selection.c1;

			if (fgrid_main.Cols[iCol].DataType.Equals(typeof(DateTime)))				
			{
				if (e.KeyChar == 8)
				{
					fgrid_main.Col = iCol+1;
					fgrid_main[iRow, iCol] = null;
				}
			}		
		}

		private void btn_trans_Click(object sender, System.EventArgs e)
		{
			if(ClassLib.ComFunction.User_Message("Do you want to transmission?","transmission", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
			{
				this.Tbtn_TransProcess();					
			}
		}

		private void Tbtn_TransProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_TRANS_INVOICE(true))
				{
					fgrid_main.Refresh_Division();
					//this.Tbtn_SearchProcess();
					MessageBox.Show("transmission Complete","transmission", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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


		public bool SAVE_TRANS_INVOICE(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 7;
				int iKey_Row = 0;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_STM_MASTER.TRANSMISSION_INVOICE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 1] = "ARG_PO_NO";
				MyOraDB.Parameter_Name[ 2] = "ARG_PO_ITEM";
				MyOraDB.Parameter_Name[ 3] = "ARG_INVOICE_KEY";
				MyOraDB.Parameter_Name[ 4] = "ARG_INVOICE_NO";
				MyOraDB.Parameter_Name[ 5] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[ 6] = "ARG_UPD_USER";


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colCHK]).Equals("True") )
						save_ct += 1;

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if (fgrid_main[iRow, _colT_LEVEL].ToString() == "1") 
					{
						iKey_Row = iRow;
						continue;
					}

					if (fgrid_main[iRow, _colCHK].ToString() == "True")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow,   _colFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iRow,   _colPO_NO_K].ToString();
						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow,   _colPO_ITEM_K].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow,   _colINVOICE_KEY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main[iRow,   _colINVOICE_NO].ToString();
//						MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main[iRow-1, _colSTYLE_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main[iKey_Row, _colSTYLE_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 6] = COM.ComVar.This_User;

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

		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				RadioButton src = sender as RadioButton; 

				fgrid_main.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) ); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			string sbool;

			if (fgrid_main[_Rowfixed+1, _colCHK].ToString() == "True")
				sbool = "False";
			else
				sbool = "True";

			for (int iRow=_Rowfixed+1; iRow<fgrid_main.Rows.Count; iRow++)
			{
				if (fgrid_main[iRow, _colT_LEVEL].ToString() == "1") 
					continue;

				fgrid_main[iRow, _colCHK] = sbool;
			}		
		}

		private void chkORD_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkORD.Checked)
			{
				dpick_ord_date_from.Enabled = true;
				dpick_ord_date_to.Enabled   = true;
			}
			else
			{
				dpick_ord_date_from.Enabled = false;
				dpick_ord_date_to.Enabled   = false;
			}				
		}

		private void dpick_ord_date_from_ValueChanged(object sender, System.EventArgs e)
		{
			dpick_ord_date_to.Value = dpick_ord_date_from.Value;		
		}

	}
}

