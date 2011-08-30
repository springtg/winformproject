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
	public class Form_TI_Invoice_Irregular : COM.TradeWinForm.Form_Top
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_lvl2;
		private System.Windows.Forms.RadioButton rad_lvl1;
		private System.Windows.Forms.Panel panel2;
		public COM.FSP fgrid_main;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtstyle_cd;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label btn_Tax;
		private System.Windows.Forms.Label btn_Invoice;
		private System.Windows.Forms.TextBox txt_invoice_no;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_po_type;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPlant;
		private System.Windows.Forms.DateTimePicker dpick_doc_date_from;
		private System.Windows.Forms.DateTimePicker dpick_doc_date_to;
		private System.Windows.Forms.Label lbl_doc_date;
		private System.Windows.Forms.CheckBox chkdoc;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_TI_Invoice_Irregular));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.pnl_head = new System.Windows.Forms.Panel();
			this.chkdoc = new System.Windows.Forms.CheckBox();
			this.dpick_doc_date_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_doc_date_to = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_doc_date = new System.Windows.Forms.Label();
			this.txtPlant = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmb_po_type = new C1.Win.C1List.C1Combo();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_invoice_no = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Tax = new System.Windows.Forms.Label();
			this.btn_Invoice = new System.Windows.Forms.Label();
			this.txtstyle_cd = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rad_lvl2 = new System.Windows.Forms.RadioButton();
			this.rad_lvl1 = new System.Windows.Forms.RadioButton();
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
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_po_type)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			this.c1Sizer1.GridDefinition = "24.2214532871972:False:True;75.0865051903114:False:False;\t0.392156862745098:False" +
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
			this.panel2.Location = new System.Drawing.Point(8, 144);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1004, 434);
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
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 3;
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_main.Size = new System.Drawing.Size(1004, 434);
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
																						 this.menuItem1,
																						 this.menuItem2,
																						 this.menuItem3,
																						 this.menuItem5,
																						 this.menuItem4});
			this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "Ceate Invoice";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "-";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "Apply Mercury Info.";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "Apply Mercury Info.[Carton Q\'ty]";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 4;
			this.menuItem4.Text = "Apply OA Info.";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.chkdoc);
			this.pnl_head.Controls.Add(this.dpick_doc_date_from);
			this.pnl_head.Controls.Add(this.dpick_doc_date_to);
			this.pnl_head.Controls.Add(this.label4);
			this.pnl_head.Controls.Add(this.lbl_doc_date);
			this.pnl_head.Controls.Add(this.txtPlant);
			this.pnl_head.Controls.Add(this.label3);
			this.pnl_head.Controls.Add(this.cmb_po_type);
			this.pnl_head.Controls.Add(this.label9);
			this.pnl_head.Controls.Add(this.txt_invoice_no);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.btn_Tax);
			this.pnl_head.Controls.Add(this.btn_Invoice);
			this.pnl_head.Controls.Add(this.txtstyle_cd);
			this.pnl_head.Controls.Add(this.label6);
			this.pnl_head.Controls.Add(this.groupBox1);
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
			this.pnl_head.Size = new System.Drawing.Size(1004, 140);
			this.pnl_head.TabIndex = 4;
			// 
			// chkdoc
			// 
			this.chkdoc.Location = new System.Drawing.Point(91, 109);
			this.chkdoc.Name = "chkdoc";
			this.chkdoc.Size = new System.Drawing.Size(13, 13);
			this.chkdoc.TabIndex = 589;
			this.chkdoc.CheckedChanged += new System.EventHandler(this.chkdoc_CheckedChanged);
			// 
			// dpick_doc_date_from
			// 
			this.dpick_doc_date_from.CustomFormat = "";
			this.dpick_doc_date_from.Enabled = false;
			this.dpick_doc_date_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_doc_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_doc_date_from.Location = new System.Drawing.Point(109, 106);
			this.dpick_doc_date_from.Name = "dpick_doc_date_from";
			this.dpick_doc_date_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_doc_date_from.TabIndex = 585;
			// 
			// dpick_doc_date_to
			// 
			this.dpick_doc_date_to.CustomFormat = "";
			this.dpick_doc_date_to.Enabled = false;
			this.dpick_doc_date_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_doc_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_doc_date_to.Location = new System.Drawing.Point(220, 106);
			this.dpick_doc_date_to.Name = "dpick_doc_date_to";
			this.dpick_doc_date_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_doc_date_to.TabIndex = 586;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(200, 109);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(16, 16);
			this.label4.TabIndex = 588;
			this.label4.Text = "~";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_doc_date
			// 
			this.lbl_doc_date.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_doc_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_doc_date.ImageIndex = 0;
			this.lbl_doc_date.ImageList = this.img_Label;
			this.lbl_doc_date.Location = new System.Drawing.Point(8, 106);
			this.lbl_doc_date.Name = "lbl_doc_date";
			this.lbl_doc_date.Size = new System.Drawing.Size(100, 21);
			this.lbl_doc_date.TabIndex = 587;
			this.lbl_doc_date.Text = "Doc. Date";
			this.lbl_doc_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPlant
			// 
			this.txtPlant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPlant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPlant.Font = new System.Drawing.Font("굴림", 9F);
			this.txtPlant.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtPlant.Location = new System.Drawing.Point(109, 84);
			this.txtPlant.MaxLength = 20;
			this.txtPlant.Name = "txtPlant";
			this.txtPlant.Size = new System.Drawing.Size(200, 21);
			this.txtPlant.TabIndex = 583;
			this.txtPlant.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(8, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 584;
			this.label3.Text = "Plant";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_po_type.TabIndex = 581;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ImageIndex = 0;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(8, 62);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 582;
			this.label9.Text = "Buy Group";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_invoice_no
			// 
			this.txt_invoice_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_invoice_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_invoice_no.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_invoice_no.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_invoice_no.Location = new System.Drawing.Point(485, 106);
			this.txt_invoice_no.MaxLength = 20;
			this.txt_invoice_no.Name = "txt_invoice_no";
			this.txt_invoice_no.Size = new System.Drawing.Size(200, 21);
			this.txt_invoice_no.TabIndex = 578;
			this.txt_invoice_no.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(384, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 579;
			this.label1.Text = "Invoice #";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Tax
			// 
			this.btn_Tax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Tax.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Tax.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_Tax.ImageIndex = 0;
			this.btn_Tax.ImageList = this.img_LongButton;
			this.btn_Tax.Location = new System.Drawing.Point(899, 110);
			this.btn_Tax.Name = "btn_Tax";
			this.btn_Tax.TabIndex = 577;
			this.btn_Tax.Text = "Tax Invoice";
			this.btn_Tax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Tax.Click += new System.EventHandler(this.btn_Tax_Click);
			this.btn_Tax.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Tax_MouseUp);
			this.btn_Tax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Tax_MouseDown);
			// 
			// btn_Invoice
			// 
			this.btn_Invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Invoice.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Invoice.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_Invoice.ImageIndex = 0;
			this.btn_Invoice.ImageList = this.img_LongButton;
			this.btn_Invoice.Location = new System.Drawing.Point(798, 110);
			this.btn_Invoice.Name = "btn_Invoice";
			this.btn_Invoice.TabIndex = 576;
			this.btn_Invoice.Text = "Invoice";
			this.btn_Invoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Invoice.Click += new System.EventHandler(this.btn_Invoice_Click);
			this.btn_Invoice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Invoice_MouseUp);
			this.btn_Invoice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Invoice_MouseDown);
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
			this.txtstyle_cd.TabIndex = 4;
			this.txtstyle_cd.Text = "";
			this.txtstyle_cd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_po_no_KeyPress);
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
			this.label6.TabIndex = 575;
			this.label6.Text = "Style #";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rad_lvl2);
			this.groupBox1.Controls.Add(this.rad_lvl1);
			this.groupBox1.Location = new System.Drawing.Point(831, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(168, 39);
			this.groupBox1.TabIndex = 544;
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
			this.rad_lvl1.Location = new System.Drawing.Point(16, 19);
			this.rad_lvl1.Name = "rad_lvl1";
			this.rad_lvl1.Size = new System.Drawing.Size(60, 16);
			this.rad_lvl1.TabIndex = 34;
			this.rad_lvl1.Tag = "1";
			this.rad_lvl1.Text = "Order";
			this.rad_lvl1.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// txt_po_no
			// 
			this.txt_po_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_po_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_po_no.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_po_no.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_po_no.Location = new System.Drawing.Point(485, 40);
			this.txt_po_no.MaxLength = 10;
			this.txt_po_no.Name = "txt_po_no";
			this.txt_po_no.Size = new System.Drawing.Size(200, 21);
			this.txt_po_no.TabIndex = 2;
			this.txt_po_no.Text = "";
			this.txt_po_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_po_no_KeyPress);
			// 
			// lbl_po_item
			// 
			this.lbl_po_item.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_po_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_po_item.ImageIndex = 0;
			this.lbl_po_item.ImageList = this.img_Label;
			this.lbl_po_item.Location = new System.Drawing.Point(384, 62);
			this.lbl_po_item.Name = "lbl_po_item";
			this.lbl_po_item.Size = new System.Drawing.Size(100, 21);
			this.lbl_po_item.TabIndex = 381;
			this.lbl_po_item.Text = "Po Item #";
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
			// txt_po_item
			// 
			this.txt_po_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_po_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_po_item.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_po_item.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_po_item.Location = new System.Drawing.Point(485, 62);
			this.txt_po_item.MaxLength = 10;
			this.txt_po_item.Name = "txt_po_item";
			this.txt_po_item.Size = new System.Drawing.Size(200, 21);
			this.txt_po_item.TabIndex = 3;
			this.txt_po_item.Text = "";
			this.txt_po_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_po_item_KeyPress);
			// 
			// lbl_po_no
			// 
			this.lbl_po_no.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_po_no.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_po_no.ImageIndex = 0;
			this.lbl_po_no.ImageList = this.img_Label;
			this.lbl_po_no.Location = new System.Drawing.Point(384, 40);
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
			this.pic_head3.Location = new System.Drawing.Point(988, 124);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 123);
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
			this.pic_head7.Size = new System.Drawing.Size(101, 99);
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
			this.label2.Text = "      Order Info.";
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
			this.pic_head5.Location = new System.Drawing.Point(0, 124);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 113);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(100, 23);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form_TI_Invoice_Irregular
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_TI_Invoice_Irregular";
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
			((System.ComponentModel.ISupportInitialize)(this.cmb_po_type)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed;
		private	double	_mediation_margin;
		private int _temp_row = 0, _temp_col = 0;
		private	string	_ReportTag;
		private	string	_Tag;		



		private int _colT_LEVEL			     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxT_LEVEL;
		private int _colCHK			         = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxCHK;
		private int _colFACTORY 		     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxFACTORY;
		private int _colSTYLE_CD		     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxSTYLE_CD;
		private int _colSTYLE_NM		     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxSTYLE_NM;
		private int _colINVOICE_DATE	     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxSTYLE_CD;
		private int _colINVOICE_NO		     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxSTYLE_NM;
		private int _colSHIP_DATE		     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxGEN_NM;
		private int _colSEASON			     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxSEASON;
		private int _colDOC_DATE		     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxDOC_DATE;

		private int _colGEN_CD			     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxGEN_CD;
		private int _colGEN_NM			     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxGEN_NM;
		private int _colORDER_SHOE_QTY       = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxORDER_SHOE_QTY;
		private int _colINVOICE_SHOE_QTY     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxINVOICE_SHOE_QTY;
		private int _colINVOICE_CT_QTY       = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxINVOICE_CT_QTY;
		private int _colPO_NO                = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxPO_NO;
		private int _colPO_ITEM              = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxPO_ITEM;
		private int _colPO_NO_K              = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxPO_NO_K;
		private int _colPO_ITEM_K            = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxPO_ITEM_K;

		private int _colORDER_CS_FOB         = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxORDER_CS_FOB;
		private int _colFOB_DIV              = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxFOB_DIV;
		private int _colTRADE_CS_FOB         = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxTRADE_CS_FOB;
		private int _colTRADE_FACTORY_FOB    = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxTRADE_FACTORY_FOB;

		private int _colAMOUNT               = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxAMOUNT;
		private int _colINVOICE_NO_K   	     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxINVOICE_NO_K;
		private int _colINVOICE_KEY    	     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxINVOICE_KEY_K;
		private int _colSIZE_DIV    	     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxSIZE_DIV;
		private int _colSIZE_FROM    	     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxSIZE_FROM;
		private int _colSIZE_TO     	     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxSIZE_TO;
		private int _colCURRENCY     	     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxCURRENCY;
		private int _colLOT_DIV     	     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxLOT_DIV;
		private int _colWERKS			   	 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxWERKS;
		private int _colFFS_SHP_TO_ACCT   	 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxFFS_SHP_TO_ACCT;
		private int _colCUST_XREF		   	 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxCUST_XREF;
		private int _colOUTPUT_PROFILE_ID	 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxOUTPUT_PROFILE_ID;
		private int _colFFS_STENCIL_DEST   	 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxFFS_STENCIL_DEST;
		private int _colFFS_STENCIL_SHIPTO	 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxFFS_STENCIL_SHIPTO;
		private int _colFFS_STENCIL_ORIGIN	 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxFFS_STENCIL_ORIGIN;
		private int _colAFS_CATEGORY	     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxAFS_CATEGORY;
		private int _colFSP					 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxFSP;
		private int _colLC_NO				 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxLC_NO;
		private int _colM_BL_NO				 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxM_BL_NO;
		private int _colPL_NO				 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxPL_NO;
		private int _colCUST_PO_NO			 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxCUST_PO_NO;
		private int _colAIR_CHARGES			 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxAIR_CHARGES;		
		private int _colPO_TYPE 		     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxPO_TYPE;

		private int _colSUB_CATEGORY_NAME    = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxSUB_CATEGORY_NAME;
		private int _colCONTRACT_NO    	     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxCONTRACT_NO;
		private int _colLINE_REMARK    	     = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxLINE_REMARK;

		private int _colBUYER_CD 	         = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxBUYER_CD;
		private int _colBUYER_NM	    	 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxBUYER_NM;

		private int _colBUKRS 		         = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxBUKRS;
		private int _colFFS_SOLDTO_CD    	 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxFFS_SOLDTO_CD;
		private int _colFFS_NAME2    		 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxFFS_NAME2;
		private int _colFFS_NAME2_1   		 = (int)ClassLib.TBSTM_INVOICE_IRREGULAR.IxFFS_NAME2_1;



		#endregion

		#region constructor / destructor

		public Form_TI_Invoice_Irregular()
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
			try
			{				

				string sLevel = fgrid_main[fgrid_main.Selection.r1, _colT_LEVEL].ToString();
				int    iRow   = fgrid_main.Selection.r1;
				int    iCol   = fgrid_main.Selection.c1;

				if (sLevel.Equals("1"))
				{
					if (iCol == _colCHK)
					{
						fgrid_main.Rows[iRow].AllowEditing   = true;

						GET_MERCURY_INVOICE_CHECK(true);
					}
					if ((iCol == _colSTYLE_CD)||(iCol == _colGEN_NM))
					{
						fgrid_main.Rows[iRow].AllowEditing   = true;
						fgrid_main.Cols[iCol].Style.DataType = typeof(DateTime);
						fgrid_main.Cols[iCol].Style.Format   = "yyyy-MM-dd";							
					}
					else if ((iCol == _colSTYLE_NM)||(iCol == _colFSP)||(iCol == _colLC_NO)||(iCol == _colFFS_NAME2)||(iCol == _colFFS_NAME2_1)||
							(iCol == _colAIR_CHARGES)||(iCol == _colCONTRACT_NO)||(iCol == _colLINE_REMARK))
					{
						fgrid_main.Rows[iRow].AllowEditing   = true;
					}
					else
					{
						fgrid_main.Rows[iRow].AllowEditing   = false;
					}

				}
				else
				{
					if (iCol == _colCHK)
					{
						fgrid_main.Rows[iRow].AllowEditing   = true;

						Calculate_Total();
						GET_MERCURY_INVOICE_CHECK(true);
					}
					else if ((iCol == _colCHK)||(iCol == _colSIZE_DIV)||(iCol == _colSIZE_FROM)||(iCol == _colSIZE_TO)||(iCol == _colINVOICE_CT_QTY)||(iCol == _colINVOICE_SHOE_QTY)||
							(iCol == _colTRADE_CS_FOB)||(iCol == _colTRADE_FACTORY_FOB)||(iCol == _colWERKS)||(iCol == _colFFS_SHP_TO_ACCT)||(iCol == _colFFS_STENCIL_DEST)||
							(iCol == _colFFS_STENCIL_SHIPTO)||(iCol == _colFFS_STENCIL_ORIGIN)||(iCol == _colAFS_CATEGORY)||(iCol == _colCUST_PO_NO)||(iCol == _colFFS_STENCIL_DEST)||(iCol == _colSUB_CATEGORY_NAME))
					{
						fgrid_main.Rows[iRow].AllowEditing   = true;
					}
					else if (((iCol == _colFFS_SOLDTO_CD)||(iCol == _colBUYER_CD))&&(fgrid_main.Cols[iCol].ComboList == "...")&&(_temp_row==iRow)&&(_temp_col==iCol))
					{
						Get_Consignee_Data();
						fgrid_main.Cols[iCol].ComboList = "";
					}
					else if ((iCol == _colFFS_SOLDTO_CD)||(iCol == _colBUYER_CD))
					{
						fgrid_main.Rows[iRow].AllowEditing   = true;
						fgrid_main.Cols[iCol].Style.DataType = typeof(string);
						fgrid_main.Cols[iCol].ComboList = "...";

						_temp_row = iRow;
						_temp_col = iCol;
					}
					else
					{
						fgrid_main.Rows[iRow].AllowEditing   = false;
					}							
				}

			}
			catch (Exception ex)
			{
				
			}			

		}

		private void Calculate_Total()
		{
			int iRow_H  =_Rowfixed;
			int iRow_Tag=_Rowfixed;

			int iCarton=0;
			int iShoe=0;
			double dAmount=0;

			for (iRow_H=iRow_Tag; iRow_H<fgrid_main.Rows.Count; iRow_H++)
			{
				if (fgrid_main[iRow_H, _colT_LEVEL].ToString() != "1")
					continue;

				for (int iRow=iRow_H+1; iRow<fgrid_main.Rows.Count; iRow++)
				{	
					if (fgrid_main[iRow, _colT_LEVEL].ToString() == "1")
					{
						iRow_Tag = iRow;
						break;
					}

					if (fgrid_main[iRow, _colINVOICE_NO_K].ToString().Length < 3)
					{
						if ((fgrid_main[iRow, _colCHK] == null)||
							(fgrid_main[iRow, _colCHK].ToString() != "True"))
							continue;
					}

					if (fgrid_main[iRow, _colINVOICE_CT_QTY] != null)
						iCarton += Convert.ToInt32(fgrid_main[iRow, _colINVOICE_CT_QTY].ToString());

					if (fgrid_main[iRow, _colINVOICE_SHOE_QTY] != null)
						iShoe   += Convert.ToInt32(fgrid_main[iRow, _colINVOICE_SHOE_QTY].ToString());

					if (fgrid_main[iRow, _colAMOUNT] != null)
						dAmount += Convert.ToDouble(fgrid_main[iRow, _colAMOUNT].ToString());
				}

				if (dAmount > 0)
				{
					fgrid_main[iRow_H, _colINVOICE_CT_QTY]   = iCarton.ToString();
					fgrid_main[iRow_H, _colINVOICE_SHOE_QTY] = iShoe.ToString();
					fgrid_main[iRow_H, _colAMOUNT]           = dAmount.ToString();

					iCarton = 0;
					iShoe   = 0;
					dAmount = 0;
				}				
				
			}


		}

		private void Get_Consignee_Data()
		{
			int iRow = fgrid_main.Selection.r1;
			int iCol = fgrid_main.Selection.c1;


			string[] keys = new string[]{ fgrid_main[iRow, _colFACTORY].ToString(),
										  fgrid_main[iRow, _colBUKRS].ToString()   };
						
			COM.ComVar.Parameter_PopUp		= new string[0];
			Pop_TI_Consignee_Master pop_consignee = new Pop_TI_Consignee_Master(keys);
			pop_consignee.ShowDialog();

			if (COM.ComVar.Parameter_PopUp.Length > 1)
			{
				if (iCol == _colFFS_SOLDTO_CD)
				{
					fgrid_main[iRow, _colBUKRS]         = COM.ComVar.Parameter_PopUp[0];
					fgrid_main[iRow, _colFFS_SOLDTO_CD] = COM.ComVar.Parameter_PopUp[1];
					fgrid_main[iRow, _colFFS_NAME2]     = COM.ComVar.Parameter_PopUp[2];

					fgrid_main.Update_Row(iRow);

					COM.ComVar.Parameter_PopUp		= new string[0];
				}
				else
				{
					fgrid_main[iRow, _colBUYER_CD]      = COM.ComVar.Parameter_PopUp[1];
					fgrid_main[iRow, _colBUYER_NM]      = COM.ComVar.Parameter_PopUp[2];
					fgrid_main.Update_Row(iRow);

					COM.ComVar.Parameter_PopUp		= new string[0];
				}
			}			

			pop_consignee.Dispose();
		}


		#endregion

		#region ToolBar Menu Event

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();

		}

		private bool GET_MERCURY_INVOICE_CHECK(bool doExecute)
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

				AdoConn.Close();
				AdoConn.Open();

				int iRow = fgrid_main.Selection.r1;
				string sQUERY;

				if (fgrid_main[iRow, _colT_LEVEL].ToString() == "2")
					sQUERY = ClassLib.ComFunction.MERCURY_QUERY_STRING("1", 
																		cmb_factory.SelectedValue.ToString(), 													 
																		fgrid_main[iRow, _colPO_NO_K].ToString(),
																		fgrid_main[iRow, _colPO_ITEM_K].ToString(),
																		"");
				else
					sQUERY = ClassLib.ComFunction.MERCURY_QUERY_STRING("2", 
																		cmb_factory.SelectedValue.ToString(),
																		fgrid_main[iRow, _colPO_NO_K].ToString(),
																		fgrid_main[iRow, _colPO_ITEM_K].ToString(),
																		fgrid_main[iRow, _colINVOICE_NO].ToString() );


				Cmd = new OleDbCommand(sQUERY, AdoConn);               
				myreader = Cmd.ExecuteReader();

				myreader.Read();

				if (myreader[0].ToString().Trim().Length > 0)
					fgrid_main[iRow, _colINVOICE_CT_QTY]     = myreader[0].ToString();

				if (myreader[2].ToString().Trim().Length > 0)
					fgrid_main[iRow, _colTRADE_CS_FOB]       = myreader[2].ToString();

				if (myreader[3].ToString().Trim().Length > 0)
					fgrid_main[iRow, _colFFS_STENCIL_SHIPTO] = myreader[3].ToString();

				if (myreader[4].ToString().Trim().Length > 0)
					fgrid_main[iRow, _colFFS_STENCIL_DEST]   = myreader[4].ToString();

				if (myreader[5].ToString().Trim().Length > 0)
					fgrid_main[iRow, _colFFS_STENCIL_ORIGIN] = myreader[5].ToString();

				if (myreader[6].ToString().Trim().Length > 0)
					fgrid_main[iRow, _colWERKS]              = myreader[6].ToString();

				if (myreader[7].ToString().Trim().Length > 0)
					fgrid_main[iRow, _colFFS_SHP_TO_ACCT]    = myreader[7].ToString();						

				if (myreader[8].ToString().Trim().Length > 0)
					fgrid_main[iRow, _colAFS_CATEGORY]       = myreader[8].ToString();						

				if (myreader[9].ToString().Trim().Length > 0)
					fgrid_main[iRow, _colSUB_CATEGORY_NAME]               = myreader[9].ToString();

				if (myreader[10].ToString().Trim().Length > 0)
					fgrid_main[iRow, _colGEN_CD]             = myreader[10].ToString();

				if (myreader[11].ToString().Trim().Length > 0)
					fgrid_main[iRow, _colGEN_NM]             = myreader[11].ToString();



				if (fgrid_main[iRow, _colINVOICE_NO_K].ToString() == "NOT YET")
				{

					double dTRADE_CS_FOB      = Convert.ToDouble(fgrid_main[iRow, _colTRADE_CS_FOB]);
					double dTRADE_FACTORY_FOB = 0;

				
					if (fgrid_main[iRow, _colFACTORY].ToString() == "VJ")
						dTRADE_FACTORY_FOB = ClassLib.ComFunction.Calcute_Factory_FOB(dTRADE_CS_FOB, _mediation_margin);								

					else if (fgrid_main[iRow, _colFACTORY].ToString() == "QD")
						dTRADE_FACTORY_FOB = System.Math.Round(dTRADE_CS_FOB * (_mediation_margin/100) - 0.0045, 2);

					fgrid_main[iRow, _colTRADE_FACTORY_FOB] = dTRADE_FACTORY_FOB.ToString();

					fgrid_main[iRow, _colAMOUNT] = Convert.ToDouble(fgrid_main[iRow, _colINVOICE_SHOE_QTY]) * 
						Convert.ToDouble(fgrid_main[iRow, _colTRADE_FACTORY_FOB]);
				}

				fgrid_main.Update_Row(iRow);				

				Cmd.Dispose();
				myreader = null;

				
				return true;

			}
			catch
			{
				return false;
			}
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
			else
			{				
				MessageBox.Show("Omitted Invoice date/Ship date/FSP/LC#");
			}
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int sel_row = fgrid_main.Selection.r1;

			if (sel_row < _Rowfixed) 
				return;

//			if (fgrid_main[sel_row, _colT_LEVEL].ToString() == "1")
//				return;

//			if (fgrid_main[sel_row+1, _colT_LEVEL].ToString() != "1")
//				return;
			

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

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			try
			{				
				Ceate_Invoice();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}


		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				this.Grid_AfterEditProcess();
			}
			catch (Exception ex)
			{
				
			}

		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
			if (fgrid_main[fgrid_main.Selection.r1, _colT_LEVEL].ToString() == "1")		
				menuItem1.Enabled = true;
			else
				menuItem1.Enabled = false;

			if (fgrid_main[fgrid_main.Selection.r1, _colT_LEVEL].ToString() == "1")		
				menuItem3.Enabled = true;

			else 
			if ((fgrid_main[fgrid_main.Selection.r1, _colINVOICE_NO] != null)              &&
			   (fgrid_main[fgrid_main.Selection.r1, _colINVOICE_NO].ToString().Length > 0) )
			    menuItem3.Enabled = true;
			else
			    menuItem3.Enabled = false;
			     
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


		#endregion

		#region DB Connect

		/// <summary>
		/// PKG_STM_INVOICE
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_STM_INVOICE(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_PO_NO";
			MyOraDB.Parameter_Name[ 2]  = "ARG_PO_ITEM";
			MyOraDB.Parameter_Name[ 3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[ 4]  = "ARG_INVOICE_NO";
			MyOraDB.Parameter_Name[ 5]  = "ARG_PO_TYPE";
			MyOraDB.Parameter_Name[ 6]  = "ARG_WERKS";
			MyOraDB.Parameter_Name[ 7]  = "ARG_DOC_DATE_FROM";
			MyOraDB.Parameter_Name[ 8]  = "ARG_DOC_DATE_TO";
			MyOraDB.Parameter_Name[ 9]  = "OUT_CURSOR";


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
			MyOraDB.Parameter_Values[1]   = ClassLib.ComFunction.Empty_TextBox(txt_po_no, "");
			MyOraDB.Parameter_Values[2]   = ClassLib.ComFunction.Empty_TextBox(txt_po_item, "");
			MyOraDB.Parameter_Values[3]   = ClassLib.ComFunction.Empty_TextBox(txtstyle_cd, "");
			MyOraDB.Parameter_Values[4]   = ClassLib.ComFunction.Empty_TextBox(txt_invoice_no, "");
			MyOraDB.Parameter_Values[5]   = ClassLib.ComFunction.Empty_Combo(cmb_po_type, "");
			MyOraDB.Parameter_Values[6]   = ClassLib.ComFunction.Empty_TextBox(txtPlant, "");

			if (chkdoc.Checked)
			{
				MyOraDB.Parameter_Values[7]   = this.dpick_doc_date_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[8]   = this.dpick_doc_date_to.Text.Replace("-", "");
			}
			else
			{
				MyOraDB.Parameter_Values[7]   = "________";
				MyOraDB.Parameter_Values[8]   = "________";
			}

			MyOraDB.Parameter_Values[9]   = "";

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
				int iCount  = 40;
				int iRow_Tag = _Rowfixed;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_STM_INVOICE.SAVE_STM_INV_IRREGULAR_01";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_PO_NO";
				MyOraDB.Parameter_Name[ 3] = "ARG_PO_ITEM";
				MyOraDB.Parameter_Name[ 4] = "ARG_INVOICE_KEY";
				MyOraDB.Parameter_Name[ 5] = "ARG_INVOICE_DATE";
				MyOraDB.Parameter_Name[ 6] = "ARG_INVOICE_NO";
				MyOraDB.Parameter_Name[ 7] = "ARG_SHIP_DATE";
				MyOraDB.Parameter_Name[ 8] = "ARG_SIZE_FROM";
				MyOraDB.Parameter_Name[ 9] = "ARG_SIZE_TO";
				MyOraDB.Parameter_Name[10] = "ARG_INVOICE_CT_QTY";
				MyOraDB.Parameter_Name[11] = "ARG_INVOICE_SHOE_QTY";			
				MyOraDB.Parameter_Name[12] = "ARG_DS_FOB";
				MyOraDB.Parameter_Name[13] = "ARG_FACTORY_FOB";
				MyOraDB.Parameter_Name[14] = "ARG_AMOUNT";
				MyOraDB.Parameter_Name[15] = "ARG_FSP";
				MyOraDB.Parameter_Name[16] = "ARG_LC_NO";
				MyOraDB.Parameter_Name[17] = "ARG_WERKS";
				MyOraDB.Parameter_Name[18] = "ARG_FFS_SHP_TO_ACCT";
				MyOraDB.Parameter_Name[19] = "ARG_CUST_XREF";
				MyOraDB.Parameter_Name[20] = "ARG_OUTPUT_PROFILE_ID";
				MyOraDB.Parameter_Name[21] = "ARG_FFS_STENCIL_DEST";
				MyOraDB.Parameter_Name[22] = "ARG_FFS_STENCIL_SHIPTO";
				MyOraDB.Parameter_Name[23] = "ARG_FFS_STENCIL_ORIGIN";
				MyOraDB.Parameter_Name[24] = "ARG_CUST_PO_NO";
				MyOraDB.Parameter_Name[25] = "ARG_M_BL_NO";
				MyOraDB.Parameter_Name[26] = "ARG_PL_NO";
				MyOraDB.Parameter_Name[27] = "ARG_AFS_CATEGORY";
				MyOraDB.Parameter_Name[28] = "ARG_SIZE_DIV";
				MyOraDB.Parameter_Name[29] = "ARG_AIR_CHARGES";
				MyOraDB.Parameter_Name[30] = "ARG_SUB_CATEGORY_NAME";
				MyOraDB.Parameter_Name[31] = "ARG_CONTRACT_NO";
				MyOraDB.Parameter_Name[32] = "ARG_LINE_REMARK";
				MyOraDB.Parameter_Name[33] = "ARG_FFS_SOLDTO_CD";
				MyOraDB.Parameter_Name[34] = "ARG_CONSIGNEE_NM3";
				MyOraDB.Parameter_Name[35] = "ARG_CONSIGNEE_NM4";
				MyOraDB.Parameter_Name[36] = "ARG_INVOICE_NO_K";
				MyOraDB.Parameter_Name[37] = "ARG_GEN_CD";
				MyOraDB.Parameter_Name[38] = "ARG_BUYER_CD";
				MyOraDB.Parameter_Name[39] = "ARG_UPD_USER";
				

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;

				for(int iRow = _Rowfixed; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
					{
						if (fgrid_main[iRow, 0].ToString() != "I") 
							save_ct += 1;
						else
						{
							for(int iRow_i = iRow+1; iRow_i < fgrid_main.Rows.Count; iRow_i++)
								if (fgrid_main[iRow_i, _colCHK].ToString() == "True") 
									save_ct += 1;	
				
							break;
						}
					}


				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct];


				iRow_Tag = _Rowfixed;
				for (int iRow = iRow_Tag; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if (fgrid_main[iRow, 0].ToString() == "I") 
					{
						iRow_Tag = iRow;
						break;
					}

					if ((fgrid_main[iRow, 0].ToString()!="U")&&(fgrid_main[iRow, 0].ToString()!="D"))
						continue;

					if (fgrid_main[iRow, _colT_LEVEL].ToString() == "1")
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString()+"H";
					else
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString()+"D";

					MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iRow, _colFACTORY].ToString();
					MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colPO_NO_K].ToString();
					MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow, _colPO_ITEM_K].ToString();
					MyOraDB.Parameter_Values[para_ct+ 4] = "";

					string sInvoice_No = fgrid_main[iRow, _colINVOICE_NO].ToString();

					if (fgrid_main[iRow, _colT_LEVEL].ToString() == "1")
					{
						MyOraDB.Parameter_Values[para_ct+ 5] = (fgrid_main[iRow, _colINVOICE_DATE] == null) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colINVOICE_DATE]).ToString("yyyyMMdd");	
						MyOraDB.Parameter_Values[para_ct+ 6] = (sInvoice_No.Length > 20) ? sInvoice_No.Substring(0,20) : sInvoice_No;
						MyOraDB.Parameter_Values[para_ct+ 7] = ((fgrid_main[iRow, _colSHIP_DATE] == null)||(fgrid_main[iRow, _colSHIP_DATE].ToString().Length == 0)) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colSHIP_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+ 8] = "";
						MyOraDB.Parameter_Values[para_ct+ 9] = "";
						MyOraDB.Parameter_Values[para_ct+10] = "";
						MyOraDB.Parameter_Values[para_ct+11] = "";
						MyOraDB.Parameter_Values[para_ct+12] = "";
						MyOraDB.Parameter_Values[para_ct+13] = "";
						MyOraDB.Parameter_Values[para_ct+14] = "";
						MyOraDB.Parameter_Values[para_ct+15] = (fgrid_main[iRow, _colFSP]    == null) ? "" : fgrid_main[iRow, _colFSP].ToString();
						MyOraDB.Parameter_Values[para_ct+16] = (fgrid_main[iRow, _colLC_NO]  == null) ? "" : fgrid_main[iRow, _colLC_NO].ToString();

						MyOraDB.Parameter_Values[para_ct+17] = "";
						MyOraDB.Parameter_Values[para_ct+18] = "";
						MyOraDB.Parameter_Values[para_ct+19] = "";
						MyOraDB.Parameter_Values[para_ct+20] = "";
						MyOraDB.Parameter_Values[para_ct+21] = "";
						MyOraDB.Parameter_Values[para_ct+22] = "";
						MyOraDB.Parameter_Values[para_ct+23] = "";
						MyOraDB.Parameter_Values[para_ct+24] = "";
						MyOraDB.Parameter_Values[para_ct+25] = "";
						MyOraDB.Parameter_Values[para_ct+26] = "";
						MyOraDB.Parameter_Values[para_ct+27] = "";
						MyOraDB.Parameter_Values[para_ct+28] = "";
						MyOraDB.Parameter_Values[para_ct+29] = (fgrid_main[iRow,   _colAIR_CHARGES]  == null) ? "" : fgrid_main[iRow, _colAIR_CHARGES].ToString();
						MyOraDB.Parameter_Values[para_ct+30] = "";
						MyOraDB.Parameter_Values[para_ct+31] = (fgrid_main[iRow, _colCONTRACT_NO]    == null) ? "" : fgrid_main[iRow, _colCONTRACT_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+32] = (fgrid_main[iRow, _colLINE_REMARK]    == null) ? "" : fgrid_main[iRow, _colLINE_REMARK].ToString();
						MyOraDB.Parameter_Values[para_ct+33] = "";
						MyOraDB.Parameter_Values[para_ct+34] = (fgrid_main[iRow, _colFFS_NAME2]      == null) ? "__" : fgrid_main[iRow, _colFFS_NAME2].ToString();
						MyOraDB.Parameter_Values[para_ct+35] = (fgrid_main[iRow, _colFFS_NAME2_1]    == null) ? "__" : fgrid_main[iRow, _colFFS_NAME2_1].ToString();
						MyOraDB.Parameter_Values[para_ct+36] = (fgrid_main[iRow, _colINVOICE_NO_K]   == null) ? "" : fgrid_main[iRow, _colINVOICE_NO_K].ToString();
						MyOraDB.Parameter_Values[para_ct+37] = "";
						MyOraDB.Parameter_Values[para_ct+38] = "";
					}
					else
					{
						MyOraDB.Parameter_Values[para_ct+ 5] = "";
						MyOraDB.Parameter_Values[para_ct+ 6] = "";
						MyOraDB.Parameter_Values[para_ct+ 7] = "";
						MyOraDB.Parameter_Values[para_ct+ 8] = (fgrid_main[iRow,   _colSIZE_FROM]         == null) ? "" : fgrid_main[iRow, _colSIZE_FROM].ToString();
						MyOraDB.Parameter_Values[para_ct+ 9] = (fgrid_main[iRow,   _colSIZE_TO]           == null) ? "" : fgrid_main[iRow, _colSIZE_TO].ToString();
						MyOraDB.Parameter_Values[para_ct+10] = (fgrid_main[iRow,   _colINVOICE_CT_QTY]    == null) ? "0" : fgrid_main[iRow, _colINVOICE_CT_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+11] = (fgrid_main[iRow,   _colINVOICE_SHOE_QTY]  == null) ? "0" : fgrid_main[iRow, _colINVOICE_SHOE_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+12] = (fgrid_main[iRow,   _colTRADE_CS_FOB]      == null) ? "0" : fgrid_main[iRow, _colTRADE_CS_FOB].ToString();
						MyOraDB.Parameter_Values[para_ct+13] = (fgrid_main[iRow,   _colTRADE_FACTORY_FOB] == null) ? "0" : fgrid_main[iRow, _colTRADE_FACTORY_FOB].ToString();

						if (fgrid_main[iRow, _colAMOUNT] == null)
							fgrid_main[iRow, _colAMOUNT] = Convert.ToDouble(fgrid_main[iRow, _colINVOICE_SHOE_QTY]) * 
								Convert.ToDouble(fgrid_main[iRow, _colTRADE_FACTORY_FOB]);
						MyOraDB.Parameter_Values[para_ct+14] = fgrid_main[iRow, _colAMOUNT].ToString();

						MyOraDB.Parameter_Values[para_ct+15] = "";
						MyOraDB.Parameter_Values[para_ct+16] = "";
						MyOraDB.Parameter_Values[para_ct+17] = (fgrid_main[iRow,   _colWERKS]               == null) ? "" : fgrid_main[iRow, _colWERKS].ToString();
						MyOraDB.Parameter_Values[para_ct+18] = (fgrid_main[iRow,   _colFFS_SHP_TO_ACCT]     == null) ? "" : fgrid_main[iRow, _colFFS_SHP_TO_ACCT].ToString();
						MyOraDB.Parameter_Values[para_ct+19] = (fgrid_main[iRow,   _colCUST_XREF]           == null) ? "" : fgrid_main[iRow, _colCUST_XREF].ToString();
						MyOraDB.Parameter_Values[para_ct+20] = (fgrid_main[iRow,   _colOUTPUT_PROFILE_ID]   == null) ? "" : fgrid_main[iRow, _colOUTPUT_PROFILE_ID].ToString();
						MyOraDB.Parameter_Values[para_ct+21] = (fgrid_main[iRow,   _colFFS_STENCIL_DEST]    == null) ? "" : fgrid_main[iRow, _colFFS_STENCIL_DEST].ToString();
						MyOraDB.Parameter_Values[para_ct+22] = (fgrid_main[iRow,   _colFFS_STENCIL_SHIPTO]  == null) ? "" : fgrid_main[iRow, _colFFS_STENCIL_SHIPTO].ToString();
						MyOraDB.Parameter_Values[para_ct+23] = (fgrid_main[iRow,   _colFFS_STENCIL_ORIGIN]  == null) ? "" : fgrid_main[iRow, _colFFS_STENCIL_ORIGIN].ToString();
						MyOraDB.Parameter_Values[para_ct+24] = (fgrid_main[iRow,   _colCUST_PO_NO]          == null) ? "" : fgrid_main[iRow, _colCUST_PO_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+25] = (fgrid_main[iRow,   _colM_BL_NO]             == null) ? "" : fgrid_main[iRow, _colM_BL_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+26] = (fgrid_main[iRow,   _colPL_NO]               == null) ? "" : fgrid_main[iRow, _colPL_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+27] = (fgrid_main[iRow,   _colAFS_CATEGORY]        == null) ? "" : fgrid_main[iRow, _colAFS_CATEGORY].ToString();
						MyOraDB.Parameter_Values[para_ct+28] = (fgrid_main[iRow,   _colSIZE_DIV].ToString() == "True") ? "Y" : "N";
						MyOraDB.Parameter_Values[para_ct+29] = "";
						MyOraDB.Parameter_Values[para_ct+30] = (fgrid_main[iRow,   _colSUB_CATEGORY_NAME]   == null) ? "" : fgrid_main[iRow, _colSUB_CATEGORY_NAME].ToString();
						MyOraDB.Parameter_Values[para_ct+31] = "";
						MyOraDB.Parameter_Values[para_ct+32] = "";
						MyOraDB.Parameter_Values[para_ct+33] = (fgrid_main[iRow,   _colFFS_SOLDTO_CD]       == null) ? "" : fgrid_main[iRow, _colFFS_SOLDTO_CD].ToString();

						MyOraDB.Parameter_Values[para_ct+34] = "";
						MyOraDB.Parameter_Values[para_ct+35] = "";
						MyOraDB.Parameter_Values[para_ct+36] = (fgrid_main[iRow, _colINVOICE_NO_K]          == null) ? "" : fgrid_main[iRow, _colINVOICE_NO_K].ToString();
						MyOraDB.Parameter_Values[para_ct+37] = (fgrid_main[iRow, _colGEN_CD]                == null) ? "" : fgrid_main[iRow, _colGEN_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+38] = (fgrid_main[iRow, _colBUYER_CD]              == null) ? "" : fgrid_main[iRow, _colBUYER_CD].ToString();
					}
				
					MyOraDB.Parameter_Values[para_ct+39] = COM.ComVar.This_User;

					para_ct += iCount;	
				
				}

				for (int iRow_H = iRow_Tag; iRow_H < fgrid_main.Rows.Count ; iRow_H++)
				{
					if (fgrid_main[iRow_H, 0].ToString() != "I") 
						continue;
					
					for (int iRow = iRow_H+1; iRow < fgrid_main.Rows.Count ; iRow++)
					{
					
						if (fgrid_main[iRow, _colCHK].ToString() != "True")
							continue;

						MyOraDB.Parameter_Values[para_ct+ 0] = "I";
						MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iRow,   _colFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow,   _colPO_NO_K].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow,   _colPO_ITEM_K].ToString();
						MyOraDB.Parameter_Values[para_ct+ 4] = "";

						MyOraDB.Parameter_Values[para_ct+ 5] = (fgrid_main[iRow_H, _colINVOICE_DATE] == null) ? "________" : Convert.ToDateTime(fgrid_main[iRow_H, _colINVOICE_DATE]).ToString("yyyyMMdd");						

						string sInvoice_No = fgrid_main[iRow_H, _colINVOICE_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+ 6] = (sInvoice_No.Length > 20) ? sInvoice_No.Substring(0,20) : sInvoice_No;

						MyOraDB.Parameter_Values[para_ct+ 7] = ((fgrid_main[iRow_H, _colSHIP_DATE] == null)||(fgrid_main[iRow_H, _colSHIP_DATE].ToString().Length == 0)) ? "________" : Convert.ToDateTime(fgrid_main[iRow_H, _colSHIP_DATE]).ToString("yyyyMMdd");					
						MyOraDB.Parameter_Values[para_ct+ 8] = (fgrid_main[iRow,   _colSIZE_FROM]         == null) ? "" : fgrid_main[iRow, _colSIZE_FROM].ToString();
						MyOraDB.Parameter_Values[para_ct+ 9] = (fgrid_main[iRow,   _colSIZE_TO]           == null) ? "" : fgrid_main[iRow, _colSIZE_TO].ToString();
						MyOraDB.Parameter_Values[para_ct+10] = (fgrid_main[iRow,   _colINVOICE_CT_QTY]    == null) ? "0" : fgrid_main[iRow, _colINVOICE_CT_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+11] = (fgrid_main[iRow,   _colINVOICE_SHOE_QTY]  == null) ? "0" : fgrid_main[iRow, _colINVOICE_SHOE_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+12] = (fgrid_main[iRow,   _colTRADE_CS_FOB]      == null) ? "0" : fgrid_main[iRow, _colTRADE_CS_FOB].ToString();
						MyOraDB.Parameter_Values[para_ct+13] = (fgrid_main[iRow,   _colTRADE_FACTORY_FOB] == null) ? "0" : fgrid_main[iRow, _colTRADE_FACTORY_FOB].ToString();

						if (fgrid_main[iRow, _colAMOUNT] == null)
							fgrid_main[iRow, _colAMOUNT] = Convert.ToDouble(fgrid_main[iRow, _colINVOICE_SHOE_QTY]) * 
								Convert.ToDouble(fgrid_main[iRow, _colTRADE_FACTORY_FOB]);
						MyOraDB.Parameter_Values[para_ct+14] = fgrid_main[iRow, _colAMOUNT].ToString();

						MyOraDB.Parameter_Values[para_ct+15] = (fgrid_main[iRow_H, _colFSP]                 == null) ? "" : fgrid_main[iRow_H, _colFSP].ToString();
						MyOraDB.Parameter_Values[para_ct+16] = (fgrid_main[iRow_H, _colLC_NO]               == null) ? "" : fgrid_main[iRow_H, _colLC_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+17] = (fgrid_main[iRow,   _colWERKS]               == null) ? "" : fgrid_main[iRow, _colWERKS].ToString();
						MyOraDB.Parameter_Values[para_ct+18] = (fgrid_main[iRow,   _colFFS_SHP_TO_ACCT]     == null) ? "" : fgrid_main[iRow, _colFFS_SHP_TO_ACCT].ToString();
						MyOraDB.Parameter_Values[para_ct+19] = (fgrid_main[iRow,   _colCUST_XREF]           == null) ? "" : fgrid_main[iRow, _colCUST_XREF].ToString();
						MyOraDB.Parameter_Values[para_ct+20] = (fgrid_main[iRow,   _colOUTPUT_PROFILE_ID]   == null) ? "" : fgrid_main[iRow, _colOUTPUT_PROFILE_ID].ToString();
						MyOraDB.Parameter_Values[para_ct+21] = (fgrid_main[iRow,   _colFFS_STENCIL_DEST]    == null) ? "" : fgrid_main[iRow, _colFFS_STENCIL_DEST].ToString();
						MyOraDB.Parameter_Values[para_ct+22] = (fgrid_main[iRow,   _colFFS_STENCIL_SHIPTO]  == null) ? "" : fgrid_main[iRow, _colFFS_STENCIL_SHIPTO].ToString();
						MyOraDB.Parameter_Values[para_ct+23] = (fgrid_main[iRow,   _colFFS_STENCIL_ORIGIN]  == null) ? "" : fgrid_main[iRow, _colFFS_STENCIL_ORIGIN].ToString();
						MyOraDB.Parameter_Values[para_ct+24] = (fgrid_main[iRow,   _colCUST_PO_NO]          == null) ? "" : fgrid_main[iRow, _colCUST_PO_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+25] = (fgrid_main[iRow,   _colM_BL_NO]             == null) ? "" : fgrid_main[iRow, _colM_BL_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+26] = (fgrid_main[iRow,   _colPL_NO]               == null) ? "" : fgrid_main[iRow, _colPL_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+27] = (fgrid_main[iRow,   _colAFS_CATEGORY]        == null) ? "" : fgrid_main[iRow, _colAFS_CATEGORY].ToString();
						MyOraDB.Parameter_Values[para_ct+28] = (fgrid_main[iRow,   _colSIZE_DIV].ToString() == "True") ? "Y" : "N";
						MyOraDB.Parameter_Values[para_ct+29] = (fgrid_main[iRow,   _colAIR_CHARGES]         == null) ? "" : fgrid_main[iRow, _colAIR_CHARGES].ToString();
						MyOraDB.Parameter_Values[para_ct+30] = (fgrid_main[iRow,   _colSUB_CATEGORY_NAME]   == null) ? "" : fgrid_main[iRow, _colSUB_CATEGORY_NAME].ToString();
						MyOraDB.Parameter_Values[para_ct+31] = (fgrid_main[iRow_H, _colCONTRACT_NO]         == null) ? "" : fgrid_main[iRow_H, _colCONTRACT_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+32] = (fgrid_main[iRow_H, _colLINE_REMARK]         == null) ? "" : fgrid_main[iRow_H, _colLINE_REMARK].ToString();
						MyOraDB.Parameter_Values[para_ct+33] = (fgrid_main[iRow,   _colFFS_SOLDTO_CD]       == null) ? "" : fgrid_main[iRow, _colFFS_SOLDTO_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+34] = (fgrid_main[iRow_H, _colFFS_NAME2]           == null) ? "__" : fgrid_main[iRow_H, _colFFS_NAME2].ToString();
						MyOraDB.Parameter_Values[para_ct+35] = (fgrid_main[iRow_H, _colFFS_NAME2_1]         == null) ? "__" : fgrid_main[iRow_H, _colFFS_NAME2_1].ToString();
						MyOraDB.Parameter_Values[para_ct+36] = (fgrid_main[iRow_H, _colINVOICE_NO_K]        == null) ? "" : fgrid_main[iRow_H, _colINVOICE_NO_K].ToString();
						MyOraDB.Parameter_Values[para_ct+37] = (fgrid_main[iRow,   _colGEN_CD]              == null) ? "" : fgrid_main[iRow, _colGEN_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+38] = (fgrid_main[iRow,   _colBUYER_CD]            == null) ? "" : fgrid_main[iRow, _colBUYER_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+39] = COM.ComVar.This_User;

						para_ct += iCount;	
					
					}
					break;					
				}

				MyOraDB.Add_Modify_Parameter(true);	// 파라미터 데이터를 DataSet에 추가
				
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




		#endregion

		#region Method

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Invoice Management [SS, OR, QQ]";
			this.Text		   = "Invoice";


			// grid set
			fgrid_main.Set_Grid("STM_INVOICE_IRREGULAR", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveDown;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.ListBox;

			//입력부 setup
			Init_Combo();		

			rad_lvl2.Checked = true;
			//rad_A.Checked    = true;
			chkdoc.Checked   = true;

			txt_po_no.Select();

			fgrid_main.Cols[_colINVOICE_CT_QTY].Format     = "#,###";
			fgrid_main.Cols[_colORDER_SHOE_QTY].Format     = "#,###";
			fgrid_main.Cols[_colINVOICE_SHOE_QTY].Format   = "#,###";
			fgrid_main.Cols[_colTRADE_CS_FOB].Format	   = "#,##0.00";
			fgrid_main.Cols[_colTRADE_FACTORY_FOB].Format  = "#,##0.00";
			fgrid_main.Cols[_colAMOUNT].Format			   = "#,##0.00";


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
				COM.ComCtl.Set_ComboList(vDt, cmb_po_type, 1, 2, true, 80, 140);
				cmb_po_type.SelectedValue = "SS";
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
				if ((cmb_po_type.ToString().Length == 0)&&(txtPlant.TextLength == 0)&&(txt_invoice_no.TextLength == 0))
					return;

				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_STM_INVOICE.SELECT_STM_INV_IRREGULAR_01";

				DataTable vDt = SELECT_STM_INVOICE(vProcedure);

				Clear_FlexGrid();

				if (vDt.Rows.Count > 0)
				{
					fgrid_main.Tree.Column = _colT_LEVEL; 
															
					Display_FlexGrid(vDt);
					GridSetColor();

					Get_Mediation_Margin();

					_Tag = "__";

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

		private void Tbtn_SearchProcess_1()
		{
			try
			{
				if (txt_po_no.TextLength == 0)
					return;

				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_STM_INVOICE.SELECT_STM_INVOICE";

				DataTable vDt = SELECT_STM_INVOICE(vProcedure);

				if (vDt.Rows.Count > 0)
				{
															
					Display_FlexGrid_1(vDt);

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

		private void Get_Mediation_Margin()
		{
			string sFactory = ClassLib.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory);

			DataTable vDt = ClassLib.ComVar.Select_ComCode(sFactory, "STM04");

			_mediation_margin = 100;

			for(int i = 0 ; i < vDt.Rows.Count; i++)
			{
				if (sFactory == vDt.Rows[i].ItemArray[1].ToString())
					_mediation_margin = Convert.ToDouble(vDt.Rows[i].ItemArray[2].ToString());
			}  
 			
			vDt.Dispose();				
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
				fgrid_main[newRow.Row.Index, 0] = "";
				fgrid_main[newRow.Row.Index, _colSTYLE_CD] = "";
				fgrid_main[newRow.Row.Index, _colGEN_NM] = "";

				// design setting
				if (iLevel == 1)
				{															
					fgrid_main.Cols[_colSTYLE_CD].Style.DataType = typeof(string);
					fgrid_main.Cols[  _colGEN_NM].Style.DataType = typeof(string);					
					//fgrid_main.Rows[newRow.Row.Index].AllowEditing = true;	
				}
				else
				{
					//fgrid_main.Rows[newRow.Row.Index].AllowEditing = true;				
				}

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					fgrid_main[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}

				fgrid_main.Tree.Column = _colSTYLE_CD;

			}

			rad_lvl2.Checked = true;
			fgrid_main.Tree.Show(2); 

		}

		private void Display_FlexGrid_1(DataTable arg_dt)
		{
			int iRow_fixed = fgrid_main.Rows.Fixed;
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{
				fgrid_main[iRow+_Rowfixed, _colORDER_CS_FOB]      = arg_dt.Rows[iRow].ItemArray[_colORDER_CS_FOB-1];
				fgrid_main[iRow+_Rowfixed, _colFOB_DIV]           = arg_dt.Rows[iRow].ItemArray[_colFOB_DIV-1];
				fgrid_main[iRow+_Rowfixed, _colTRADE_CS_FOB]      = arg_dt.Rows[iRow].ItemArray[_colTRADE_CS_FOB-1];
				fgrid_main[iRow+_Rowfixed, _colTRADE_FACTORY_FOB] = arg_dt.Rows[iRow].ItemArray[_colTRADE_FACTORY_FOB-1];

			}

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
				CellRange vRange_5;				


				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{				
					sLevel      = fgrid_main[iRow, _colT_LEVEL].ToString();
					vRange      = fgrid_main.GetCellRange(iRow, 1, iRow, _colDOC_DATE);
					vRange_1    = fgrid_main.GetCellRange(iRow, 1, iRow, _colGEN_NM);

					vRange_2    = fgrid_main.GetCellRange(iRow, _colSIZE_DIV,      iRow, _colINVOICE_SHOE_QTY);
					vRange_3    = fgrid_main.GetCellRange(iRow, _colLOT_DIV,       iRow, _colAMOUNT);
					vRange_4    = fgrid_main.GetCellRange(iRow, _colFSP,           iRow, fgrid_main.Cols.Count-1);
					vRange_5    = fgrid_main.GetCellRange(iRow, _colCUST_PO_NO+1,  iRow, fgrid_main.Cols.Count-1);

					

					if (sLevel.Equals("1"))
					{			
		
						vRange_2.StyleNew.ForeColor = Color.Red;
						vRange_3.StyleNew.ForeColor = Color.Red;

						if (fgrid_main[iRow, _colINVOICE_NO_K].ToString() == "NOT YET")
							vRange.StyleNew.BackColor = Color.SeaShell;	

					}
					else if (sLevel.Equals("2"))
					{
						vRange_1.StyleNew.BackColor = Color.White;
						vRange_1.StyleNew.ForeColor = Color.DarkGray;

						vRange_2.StyleNew.BackColor = Color.LightYellow;
						vRange_3.StyleNew.BackColor = Color.White;
						vRange_4.StyleNew.BackColor = Color.White;
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}

		private void Ceate_Invoice()
		{
			int sel_row = fgrid_main.Selection.r1;

			add_row(sel_row);
			GridSetColor();

		}


		/// <summary>
		/// add_row : 
		/// </summary>
		/// <param name="arg_rownum"></param>
		private void add_row(int arg_sel_row)
		{
			try
			{
				C1.Win.C1FlexGrid.Node node = fgrid_main.Rows[arg_sel_row].Node;
				int iShoe_Qty = 0;
				int iCT_Qty   = 0;
	
				if ((arg_sel_row < fgrid_main.Rows.Count-1) &&
					(fgrid_main[arg_sel_row+1, _colT_LEVEL].ToString() != "1"))
				{
					int previous_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index; 
				
					if (fgrid_main[previous_row, _colLOT_DIV].ToString() != "P")
					{					
						MessageBox.Show("This Order completed invoice creation already!","Create Invoice", MessageBoxButtons.OK ,MessageBoxIcon.Information);
						return;
					}
				}

				node.AddNode(NodeTypeEnum.LastChild, "");

				int current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index; 

				// Set Default Value //
				fgrid_main[current_row, 0]                       = "I";
				fgrid_main[current_row, _colT_LEVEL]	         = "2";
				fgrid_main[current_row, _colFACTORY]             = fgrid_main[current_row-1, _colFACTORY].ToString();
				fgrid_main[current_row, _colPO_NO_K]             = fgrid_main[current_row-1, _colPO_NO_K].ToString();
				fgrid_main[current_row, _colPO_ITEM_K]           = fgrid_main[current_row-1, _colPO_ITEM_K].ToString();
				fgrid_main[current_row, _colINVOICE_KEY]         = "";
				fgrid_main[current_row, _colCURRENCY]            = fgrid_main[current_row-1, _colCURRENCY].ToString();
				fgrid_main[current_row, _colTRADE_CS_FOB]        = fgrid_main[current_row-1, _colTRADE_CS_FOB].ToString();
				fgrid_main[current_row, _colTRADE_FACTORY_FOB]   = fgrid_main[current_row-1, _colTRADE_FACTORY_FOB].ToString();
				fgrid_main[current_row, _colSIZE_DIV]            = fgrid_main[arg_sel_row, _colSIZE_DIV].ToString();
				fgrid_main[current_row, _colSIZE_FROM]           = fgrid_main[arg_sel_row, _colSIZE_FROM].ToString();
				fgrid_main[current_row, _colSIZE_TO]             = fgrid_main[arg_sel_row, _colSIZE_TO].ToString();								

				if (current_row-1 == arg_sel_row)
				{
					if (fgrid_main[arg_sel_row, _colINVOICE_CT_QTY] != null)
						fgrid_main[current_row, _colINVOICE_CT_QTY]   = fgrid_main[arg_sel_row, _colINVOICE_CT_QTY].ToString();

					if (fgrid_main[arg_sel_row, _colINVOICE_SHOE_QTY] != null)
						fgrid_main[current_row, _colINVOICE_SHOE_QTY]   = fgrid_main[arg_sel_row, _colINVOICE_SHOE_QTY].ToString();

					if (fgrid_main[arg_sel_row, _colAMOUNT] != null)
						fgrid_main[current_row, _colAMOUNT]   = fgrid_main[arg_sel_row, _colAMOUNT].ToString();
				}
				else
				{
					for(int iRow=arg_sel_row+1; iRow<current_row; iRow++)
					{
						if (fgrid_main[iRow, _colINVOICE_CT_QTY] != null)
							iCT_Qty   += Convert.ToInt32(fgrid_main[iRow, _colINVOICE_CT_QTY].ToString());

						if (fgrid_main[iRow, _colINVOICE_SHOE_QTY] != null)
							iShoe_Qty += Convert.ToInt32(fgrid_main[iRow, _colINVOICE_SHOE_QTY].ToString());

					}

					if (fgrid_main[arg_sel_row, _colINVOICE_CT_QTY] != null)
						fgrid_main[current_row, _colINVOICE_CT_QTY]   = (Convert.ToInt32(fgrid_main[arg_sel_row, _colINVOICE_CT_QTY].ToString())-iCT_Qty).ToString();

					if (fgrid_main[arg_sel_row, _colINVOICE_SHOE_QTY] != null)
						fgrid_main[current_row, _colINVOICE_SHOE_QTY] = (Convert.ToInt32(fgrid_main[arg_sel_row, _colINVOICE_SHOE_QTY].ToString())-iShoe_Qty).ToString();


					fgrid_main[current_row, _colAMOUNT]           = Convert.ToDouble(fgrid_main[current_row, _colINVOICE_SHOE_QTY]) * 
																	Convert.ToDouble(fgrid_main[current_row, _colTRADE_FACTORY_FOB]);

				}

				fgrid_main[current_row, _colSTYLE_NM]            = "";
				fgrid_main[current_row, _colINVOICE_DATE]        = null;
				fgrid_main[current_row, _colSHIP_DATE]           = null;

				if (fgrid_main[current_row-1, _colWERKS] != null)
					fgrid_main[current_row, _colWERKS]               = fgrid_main[current_row-1, _colWERKS].ToString();

				if (fgrid_main[current_row-1, _colFFS_SHP_TO_ACCT] != null)
					fgrid_main[current_row, _colFFS_SHP_TO_ACCT]     = fgrid_main[current_row-1, _colFFS_SHP_TO_ACCT].ToString();

				if (fgrid_main[current_row-1, _colOUTPUT_PROFILE_ID] != null)
					fgrid_main[current_row, _colOUTPUT_PROFILE_ID]   = fgrid_main[current_row-1, _colOUTPUT_PROFILE_ID].ToString();

				if (fgrid_main[current_row-1, _colFFS_STENCIL_DEST] != null)
					fgrid_main[current_row, _colFFS_STENCIL_DEST]    = fgrid_main[current_row-1, _colFFS_STENCIL_DEST].ToString();

				if (fgrid_main[current_row-1, _colFFS_STENCIL_SHIPTO] != null)
					fgrid_main[current_row, _colFFS_STENCIL_SHIPTO]  = fgrid_main[current_row-1, _colFFS_STENCIL_SHIPTO].ToString();

				if (fgrid_main[current_row-1, _colCUST_PO_NO] != null)
					fgrid_main[current_row, _colCUST_PO_NO]          = fgrid_main[current_row-1, _colCUST_PO_NO].ToString();

				if (fgrid_main[current_row-1, _colAFS_CATEGORY] != null)
					fgrid_main[current_row, _colAFS_CATEGORY]               = fgrid_main[current_row-1, _colAFS_CATEGORY].ToString();


				if (fgrid_main[current_row-1, _colFFS_STENCIL_ORIGIN].ToString().Length == 0)
				{
					if (fgrid_main[current_row-1, _colFACTORY].ToString() == "QD")
						fgrid_main[current_row, _colFFS_STENCIL_ORIGIN]  = "CHINA";

					else if (fgrid_main[current_row-1, _colFACTORY].ToString() == "VJ")
						fgrid_main[current_row, _colFFS_STENCIL_ORIGIN]  = "VIETNAM";

					else if (fgrid_main[current_row-1, _colFACTORY].ToString() == "DS")
						fgrid_main[current_row, _colFFS_STENCIL_ORIGIN]  = "KOREA";					
				}
				else
					fgrid_main[current_row, _colFFS_STENCIL_ORIGIN]  = fgrid_main[current_row-1, _colFFS_STENCIL_ORIGIN].ToString();


				if (fgrid_main[current_row-1, _colFACTORY].ToString() == "QD")
					fgrid_main[current_row, _colFFS_STENCIL_ORIGIN]  = "CHINA";

				//fgrid_main[current_row, _colINVOICE_NO]          = cmb_factory.SelectedValue.ToString()+System.DateTime.Today.ToString("yy")+System.DateTime.Today.ToString("MM");

								
 
			}
			catch
			{}

		}



		private void Grid_AfterEditProcess()
		{
			int iCol = fgrid_main.Selection.c1;
			int iRow = fgrid_main.Selection.r1;

			double dTRADE_CS_FOB;
			double dTRADE_FACTORY_FOB=0;
			

			if ((iCol == _colINVOICE_SHOE_QTY)||(iCol == _colTRADE_CS_FOB)||(iCol == _colTRADE_FACTORY_FOB))
			{

				if (fgrid_main[iRow, _colINVOICE_NO_K].ToString() == "NOT YET")
				{
					fgrid_main[iRow, iCol] = "";
					fgrid_main[iRow, 0] = "";
					return;
				}

				if (iCol == _colTRADE_CS_FOB)
				{
					dTRADE_CS_FOB      = Convert.ToDouble(fgrid_main[iRow, _colTRADE_CS_FOB]);

					if (fgrid_main[iRow, _colFACTORY].ToString() == "VJ")
						dTRADE_FACTORY_FOB = ClassLib.ComFunction.Calcute_Factory_FOB(dTRADE_CS_FOB, _mediation_margin);

					else if (fgrid_main[iRow, _colFACTORY].ToString() == "QD")
						dTRADE_FACTORY_FOB = System.Math.Round(dTRADE_CS_FOB * (_mediation_margin/100) - 0.0045, 2);

					
					fgrid_main[iRow, _colTRADE_FACTORY_FOB] = dTRADE_FACTORY_FOB.ToString();
				}
 
				fgrid_main[iRow, _colAMOUNT] = Convert.ToDouble(fgrid_main[iRow, _colINVOICE_SHOE_QTY]) * 
					Convert.ToDouble(fgrid_main[iRow, _colTRADE_FACTORY_FOB]);

				Calculate_Total();
				fgrid_main.Update_Row(iRow);
											   			
			}
			else if (iCol == _colINVOICE_NO)
			{
				string sInvoice_No = fgrid_main[iRow, _colINVOICE_NO].ToString();

				if (sInvoice_No.Length > 20)
					fgrid_main[iRow, _colINVOICE_NO] = sInvoice_No.Substring(0,20);
				else
					fgrid_main[iRow, _colINVOICE_NO] = sInvoice_No;

				if (sInvoice_No.Length >= 4)
					this.btn_MercuryProcess();

				if (fgrid_main[iRow, _colINVOICE_NO_K].ToString() == "NOT YET")
					fgrid_main[iRow, 0] = "I";
				else
					fgrid_main[iRow, 0] = "U";

				return;

			}
			else if (iCol == _colINVOICE_DATE)
			{
				Make_Invoice_No(iRow);

				if (fgrid_main[iRow, _colINVOICE_NO_K].ToString() == "NOT YET")
					fgrid_main[iRow, 0] = "I";
				else
					fgrid_main[iRow, 0] = "U";

				return;

			}
//			else if  (iCol == _colFSP)
//			{
//				if (fgrid_main[iRow, _colFSP].ToString() == "T/T")
//					fgrid_main[iRow, _colLC_NO] = "514-82-000014";
//			}
			else if (iCol == _colINVOICE_CT_QTY)
			{
				if (fgrid_main[iRow, _colINVOICE_NO_K].ToString() == "NOT YET")
				{
					fgrid_main[iRow, iCol] = "";
					fgrid_main[iRow, 0] = "";
					return;
				}

				Calculate_Total();
			}
			else if (iCol == _colCHK)
				return;

			fgrid_main.Update_Row();
		}


		private void Make_Invoice_No(int arg_row)
		{
			string sInvoice_no;
			string sPo_Type;

			sPo_Type = cmb_po_type.SelectedValue.ToString();

			if (sPo_Type == "ID")
				sInvoice_no = fgrid_main[arg_row+1, _colFACTORY].ToString()+
							  sPo_Type+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(2,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(5,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(8,2);
			else if (sPo_Type == "QQ")
				sInvoice_no = fgrid_main[arg_row+1, _colFACTORY].ToString()+
							  "B"+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(2,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(5,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(8,2);
			else if (sPo_Type == "PS")
				sInvoice_no = fgrid_main[arg_row+1, _colFACTORY].ToString()+
							  "P"+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(2,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(5,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(8,2);
			else if (sPo_Type == "SS")
				sInvoice_no = fgrid_main[arg_row+1, _colFACTORY].ToString()+
							  "G"+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(2,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(5,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(8,2);
			else if (sPo_Type == "OR")
				sInvoice_no = fgrid_main[arg_row+1, _colFACTORY].ToString()+
							  "O"+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(2,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(5,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(8,2);
			else
				sInvoice_no = fgrid_main[arg_row+1, _colFACTORY].ToString()+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(2,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(5,2)+
							  fgrid_main[arg_row, _colINVOICE_DATE].ToString().Substring(8,2);

			fgrid_main[arg_row, _colINVOICE_NO] = sInvoice_no;
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
					this.Tbtn_SearchProcess();					
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

			bool b = true;

			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
			{
				if (fgrid_main[iRow, 0].ToString() != "I") continue;

				if ((fgrid_main[iRow, _colSTYLE_NM].ToString().Replace(" ", "").Trim().Length == 0)||
					(fgrid_main[iRow, _colSTYLE_CD] == null)||
					(fgrid_main[iRow, _colFSP] == null)||
					(fgrid_main[iRow, _colSHIP_DATE] == null)||
					(fgrid_main[iRow, _colSHIP_DATE].ToString().Trim() == "")||
					(fgrid_main[iRow, _colFSP].ToString().Length < 1))
				{
					b = false;
					break;
				}

				if (fgrid_main[iRow, _colFSP].ToString() == "L/C")
				{
					if ((fgrid_main[iRow, _colLC_NO] == null)||(fgrid_main[iRow, _colLC_NO].ToString().Length < 5))
						b = false;

					break;
				}
			}	

			return b;

		}



		#endregion

		private void btn_fob_Click(object sender, System.EventArgs e)
		{

		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			
		}

		private void Tbtn_PrintProcess()
		{
			try
			{
				string sReport_Job_Name    = "INVOICE";				

				DataTable vDt = FlexTrade.ClassLib.ComFunction.CREATE_REPORT_REQUEST_KEY(sReport_Job_Name);																
				
				string sReport_Request_Key = vDt.Rows[0].ItemArray[0].ToString();

				if (SAVE_REPORT_REQUEST(sReport_Request_Key))
					PRINT_INVOICE(sReport_Request_Key);
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

		private void Tbtn_PrintProcess_Tax()
		{
			try
			{
				string sReport_Job_Name    = "TAX";				

				DataTable vDt = FlexTrade.ClassLib.ComFunction.CREATE_REPORT_REQUEST_KEY(sReport_Job_Name);																
				
				string sReport_Request_Key = vDt.Rows[0].ItemArray[0].ToString();

				if (SAVE_REPORT_REQUEST(sReport_Request_Key))
					PRINT_INVOICE_TAX(sReport_Request_Key);

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
		


		private bool SAVE_REPORT_REQUEST(string arg_Report_Request_Key)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 7;

				string sInvoice_no = "__";


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_STM_REPORT.SAVE_STM_REPORT_REQUEST";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_REPORT_KEY_1";
				MyOraDB.Parameter_Name[ 1] = "ARG_REPORT_FIELD_1";
				MyOraDB.Parameter_Name[ 2] = "ARG_REPORT_FIELD_2";
				MyOraDB.Parameter_Name[ 3] = "ARG_REPORT_FIELD_3";
				MyOraDB.Parameter_Name[ 4] = "ARG_REPORT_FIELD_4";
				MyOraDB.Parameter_Name[ 5] = "ARG_REPORT_FIELD_5";
				MyOraDB.Parameter_Name[ 6] = "ARG_UPD_USER";


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				

				for(int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count; iRow++)
				{
					if (fgrid_main[iRow, _colINVOICE_NO_K].ToString() == "NOT YET")
						break;

					if (fgrid_main[iRow, _colT_LEVEL].ToString() != "1") continue;

					if (sInvoice_no == fgrid_main[iRow, _colINVOICE_NO_K].ToString()) 
						continue;

					sInvoice_no = fgrid_main[iRow, _colINVOICE_NO_K].ToString();

					if (fgrid_main[iRow, _colCHK].ToString() == "True")
						save_ct += 1;					
				}					

				sInvoice_no = "__";


				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if (fgrid_main[iRow, _colINVOICE_NO_K].ToString() == "NOT YET")
						break;

					if (fgrid_main[iRow, _colT_LEVEL].ToString() != "1") continue;

					if (sInvoice_no == fgrid_main[iRow, _colINVOICE_NO_K].ToString()) 
						continue;

					sInvoice_no = fgrid_main[iRow, _colINVOICE_NO_K].ToString();

					if (fgrid_main[iRow, _colCHK].ToString() == "True")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = arg_Report_Request_Key;
						MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iRow, _colFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colINVOICE_NO_K].ToString();

						MyOraDB.Parameter_Values[para_ct+ 3] = " ";
						MyOraDB.Parameter_Values[para_ct+ 4] = " ";
						MyOraDB.Parameter_Values[para_ct+ 5] = "INVOICE";						

						MyOraDB.Parameter_Values[para_ct+ 6] = COM.ComVar.This_User;

						para_ct += iCount;
	
					    _ReportTag = fgrid_main[iRow-1, _colPO_TYPE].ToString();
					}				
				}

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;
			}
			catch
			{
				return false;
			}		
		}


		private void PRINT_INVOICE(string arg_report_request_key)
		{
			string sDir;
			
			if (cmb_factory.SelectedValue.ToString() == "QD")
				sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Invoice");
			else if (cmb_factory.SelectedValue.ToString() == "VJ")
			{
//				if ((_ReportTag == "FT")||(_ReportTag == "PS"))
//				{
//
//					if (rad_A.Checked)
//						sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Invoice_VJ_Regular_Nego");
//					else if (rad_B.Checked)
//						sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Invoice_VJ_Regular_CO");
//					else
//						sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Invoice_VJ_Regular_CT");
//					
//				}
//				else
					sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Invoice_VJ_Irregular");
			}
			else
				sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Invoice");
			

			string sPara;
			
			sPara  = " /rp ";
			sPara += "'" + cmb_factory.SelectedValue.ToString()  +	"' ";
			sPara += "'" + arg_report_request_key                +	"' ";

			FlexTrade.Report.Form_RdViewer MyReport = new FlexTrade.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Invoice";
			MyReport.Show();
				
		}

		private void PRINT_INVOICE_TAX(string arg_report_request_key)
		{
			string sDir;
			
			sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Invoice_Tax_Irregular");

			string sPara;
			
			sPara  = " /rp ";
			sPara += "'" + cmb_factory.SelectedValue.ToString()  +	"' ";
			sPara += "'" + arg_report_request_key                +	"' ";

			FlexTrade.Report.Form_RdViewer MyReport = new FlexTrade.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Tax Invoice";
			MyReport.Show();
				
		}

		private void chk_ship_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void chk_invoice_CheckedChanged(object sender, System.EventArgs e)
		{

		}

		private void txt_po_no_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				txt_po_item.Select();

		}

		private void btn_mercury_Click(object sender, System.EventArgs e)
		{

		}

		private void btn_MercuryProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				//APPLY_MERCURY_INVOICE(true);
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


				for (int iRow=_Rowfixed; iRow<fgrid_main.Rows.Count; iRow++)
				{
					if (fgrid_main.Rows[iRow].Selected == false)
						continue;

					AdoConn.Close();
					AdoConn.Open();

					string sQUERY;

					if (fgrid_main[iRow, _colT_LEVEL].ToString() == "1")
						sQUERY = ClassLib.ComFunction.MERCURY_QUERY_STRING("1", 
																			cmb_factory.SelectedValue.ToString(), 													 
																			fgrid_main[iRow, _colPO_NO_K].ToString(),
																			fgrid_main[iRow, _colPO_ITEM_K].ToString(),
																			"");
					else
						sQUERY = ClassLib.ComFunction.MERCURY_QUERY_STRING("2", 
																			cmb_factory.SelectedValue.ToString(),
																			fgrid_main[iRow, _colPO_NO_K].ToString(),
																			fgrid_main[iRow, _colPO_ITEM_K].ToString(),
																			fgrid_main[iRow, _colINVOICE_NO].ToString() );


					Cmd = new OleDbCommand(sQUERY, AdoConn);               
					myreader = Cmd.ExecuteReader();

					myreader.Read();
	



					if (Convert.ToInt32(myreader[1]) > 0 )
					{
							if (myreader[0].ToString().Trim().Length > 0)
								fgrid_main[iRow, _colINVOICE_CT_QTY]     = myreader[0].ToString();

							if (myreader[2].ToString().Trim().Length > 0)
								fgrid_main[iRow, _colTRADE_CS_FOB]       = myreader[2].ToString();

							if (myreader[3].ToString().Trim().Length > 0)
								fgrid_main[iRow, _colFFS_STENCIL_SHIPTO] = myreader[3].ToString();

							if (myreader[4].ToString().Trim().Length > 0)
								fgrid_main[iRow, _colFFS_STENCIL_DEST]   = myreader[4].ToString();

							if (myreader[5].ToString().Trim().Length > 0)
								fgrid_main[iRow, _colFFS_STENCIL_ORIGIN] = myreader[5].ToString();

							if (myreader[6].ToString().Trim().Length > 0)
								fgrid_main[iRow, _colWERKS]              = myreader[6].ToString();

							if (myreader[7].ToString().Trim().Length > 0)
								fgrid_main[iRow, _colFFS_SHP_TO_ACCT]    = myreader[7].ToString();						

							if (myreader[8].ToString().Trim().Length > 0)
								fgrid_main[iRow, _colAFS_CATEGORY]       = myreader[8].ToString();						

							if (myreader[9].ToString().Trim().Length > 0)
								fgrid_main[iRow, _colSUB_CATEGORY_NAME]               = myreader[9].ToString();




							double dTRADE_CS_FOB      = Convert.ToDouble(fgrid_main[iRow, _colTRADE_CS_FOB]);
							double dTRADE_FACTORY_FOB = 0;

							if (fgrid_main[iRow, _colFACTORY].ToString() == "VJ")
								dTRADE_FACTORY_FOB = ClassLib.ComFunction.Calcute_Factory_FOB(dTRADE_CS_FOB, _mediation_margin);

							else if (fgrid_main[iRow, _colFACTORY].ToString() == "QD")
								dTRADE_FACTORY_FOB = System.Math.Round(dTRADE_CS_FOB * (_mediation_margin/100) - 0.0045, 2);							

							fgrid_main[iRow, _colTRADE_FACTORY_FOB] = dTRADE_FACTORY_FOB.ToString();
					}

					Cmd.Dispose();
					myreader = null;

					if (fgrid_main[iRow, _colT_LEVEL].ToString() == "2")
						fgrid_main.Update_Row(iRow);
				}

				
				return true;

			}
			catch
			{
				return false;
			}
		}


		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			if(ClassLib.ComFunction.User_Message("Do you want to apply mercury data?","Apply", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
			{
				_Tag = "__";
				this.btn_MercuryProcess();
			}				
		}

		private void fgrid_main_KeyPressEdit(object sender, C1.Win.C1FlexGrid.KeyPressEditEventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			int iCol = fgrid_main.Selection.c1;

			if (iCol == 0) 
				return;

			if (fgrid_main.Cols[iCol].DataType.Equals(typeof(DateTime)))				
			{
				if (e.KeyChar == 8)
				{
					fgrid_main.Col = iCol+1;
					fgrid_main[iRow, iCol] = null;
				}
			}

		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			for (int iRow=_Rowfixed; iRow<fgrid_main.Rows.Count; iRow++)
			{
				if (fgrid_main.Rows[iRow].Selected == false)
					continue;

				if (fgrid_main[iRow, _colT_LEVEL].ToString() == "1")
					continue;

				fgrid_main[iRow, 0] = "U";
			}
			
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			if(ClassLib.ComFunction.User_Message("Do you want to apply mercury data?","Apply", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
			{
				_Tag = "Carton";
				this.btn_MercuryProcess();
			}						
		}

		private void btn_Invoice_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_PrintProcess();
		}

		private void btn_Tax_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_PrintProcess_Tax();
		}

		private void btn_Invoice_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Invoice.ImageIndex = 1;
		}

		private void btn_Invoice_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Invoice.ImageIndex = 0;
		}

		private void btn_Tax_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Tax.ImageIndex = 1;
		}

		private void btn_Tax_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Tax.ImageIndex = 0;
		}

		private void txt_po_item_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void chkdoc_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkdoc.Checked)
			{
				dpick_doc_date_from.Enabled = true;
				dpick_doc_date_to.Enabled   = true;
			}
			else
			{
				dpick_doc_date_from.Enabled = false;
				dpick_doc_date_to.Enabled   = false;
			}				
		}




	}
}

