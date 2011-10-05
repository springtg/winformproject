using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexTrade.Invoice
{
	public class Form_TI_Stuffing : COM.TradeWinForm.Form_Top
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
		private System.Windows.Forms.Label lbl_po_no;
		private System.Windows.Forms.TextBox txt_po_no;
		private System.Windows.Forms.TextBox txt_po_item;
		private System.Windows.Forms.Panel panel2;
		public COM.FSP fgrid_main;
		private System.Windows.Forms.ContextMenu contextMenu1;
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
		private System.Windows.Forms.TextBox txt_invoice_no;
		private C1.Win.C1List.C1Combo cmb_trans;
		private System.Windows.Forms.Label btn_booking;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label btn_Origin;
		private System.Windows.Forms.Label lbl_booking;
		private System.Windows.Forms.TextBox txtBooking;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_lvl2;
		private System.Windows.Forms.RadioButton rad_lvl1;
		private System.Windows.Forms.CheckBox chkbook;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbl_booking_date;
		private System.Windows.Forms.DateTimePicker dpick_booking_date_from;
		private System.Windows.Forms.DateTimePicker dpick_booking_date_to;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rad_B;
		private System.Windows.Forms.RadioButton rad_A;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region Design Source
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_TI_Stuffing));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rad_B = new System.Windows.Forms.RadioButton();
			this.rad_A = new System.Windows.Forms.RadioButton();
			this.chkbook = new System.Windows.Forms.CheckBox();
			this.dpick_booking_date_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_booking_date_to = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_booking_date = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rad_lvl2 = new System.Windows.Forms.RadioButton();
			this.rad_lvl1 = new System.Windows.Forms.RadioButton();
			this.txtBooking = new System.Windows.Forms.TextBox();
			this.btn_Origin = new System.Windows.Forms.Label();
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_booking = new System.Windows.Forms.Label();
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
			this.lbl_booking = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_head.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
			this.lbl_MainTitle.Click += new System.EventHandler(this.lbl_MainTitle_Click);
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
				":True;98.8235294117647:False:False;0:False:True;";
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
			this.panel2.Size = new System.Drawing.Size(1008, 434);
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
			this.fgrid_main.Size = new System.Drawing.Size(1008, 434);
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
			this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
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
			this.pnl_head.Controls.Add(this.chkbook);
			this.pnl_head.Controls.Add(this.dpick_booking_date_from);
			this.pnl_head.Controls.Add(this.dpick_booking_date_to);
			this.pnl_head.Controls.Add(this.label6);
			this.pnl_head.Controls.Add(this.lbl_booking_date);
			this.pnl_head.Controls.Add(this.groupBox1);
			this.pnl_head.Controls.Add(this.txtBooking);
			this.pnl_head.Controls.Add(this.btn_Origin);
			this.pnl_head.Controls.Add(this.btn_booking);
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
			this.pnl_head.Controls.Add(this.lbl_booking);
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
			this.pnl_head.Size = new System.Drawing.Size(1008, 140);
			this.pnl_head.TabIndex = 4;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.rad_B);
			this.groupBox2.Controls.Add(this.rad_A);
			this.groupBox2.Location = new System.Drawing.Point(832, 70);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(168, 35);
			this.groupBox2.TabIndex = 571;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Booking Form Div.";
			// 
			// rad_B
			// 
			this.rad_B.Location = new System.Drawing.Point(104, 16);
			this.rad_B.Name = "rad_B";
			this.rad_B.Size = new System.Drawing.Size(56, 16);
			this.rad_B.TabIndex = 35;
			this.rad_B.Tag = "2";
			this.rad_B.Text = "Early";
			// 
			// rad_A
			// 
			this.rad_A.Location = new System.Drawing.Point(16, 16);
			this.rad_A.Name = "rad_A";
			this.rad_A.Size = new System.Drawing.Size(80, 16);
			this.rad_A.TabIndex = 34;
			this.rad_A.Tag = "1";
			this.rad_A.Text = "On Time";
			// 
			// chkbook
			// 
			this.chkbook.Location = new System.Drawing.Point(91, 111);
			this.chkbook.Name = "chkbook";
			this.chkbook.Size = new System.Drawing.Size(13, 13);
			this.chkbook.TabIndex = 570;
			this.chkbook.CheckedChanged += new System.EventHandler(this.chkbook_CheckedChanged);
			// 
			// dpick_booking_date_from
			// 
			this.dpick_booking_date_from.CustomFormat = "";
			this.dpick_booking_date_from.Enabled = false;
			this.dpick_booking_date_from.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_booking_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_booking_date_from.Location = new System.Drawing.Point(109, 106);
			this.dpick_booking_date_from.Name = "dpick_booking_date_from";
			this.dpick_booking_date_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_booking_date_from.TabIndex = 566;
			this.dpick_booking_date_from.ValueChanged += new System.EventHandler(this.dpick_booking_date_from_ValueChanged);
			// 
			// dpick_booking_date_to
			// 
			this.dpick_booking_date_to.CustomFormat = "";
			this.dpick_booking_date_to.Enabled = false;
			this.dpick_booking_date_to.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_booking_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_booking_date_to.Location = new System.Drawing.Point(220, 106);
			this.dpick_booking_date_to.Name = "dpick_booking_date_to";
			this.dpick_booking_date_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_booking_date_to.TabIndex = 567;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(200, 107);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(16, 16);
			this.label6.TabIndex = 569;
			this.label6.Text = "~";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_booking_date
			// 
			this.lbl_booking_date.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_booking_date.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_booking_date.ImageIndex = 0;
			this.lbl_booking_date.ImageList = this.img_Label;
			this.lbl_booking_date.Location = new System.Drawing.Point(8, 106);
			this.lbl_booking_date.Name = "lbl_booking_date";
			this.lbl_booking_date.Size = new System.Drawing.Size(100, 21);
			this.lbl_booking_date.TabIndex = 568;
			this.lbl_booking_date.Text = "Booking Date";
			this.lbl_booking_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rad_lvl2);
			this.groupBox1.Controls.Add(this.rad_lvl1);
			this.groupBox1.Location = new System.Drawing.Point(831, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(168, 35);
			this.groupBox1.TabIndex = 565;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tree View Option";
			// 
			// rad_lvl2
			// 
			this.rad_lvl2.Location = new System.Drawing.Point(88, 16);
			this.rad_lvl2.Name = "rad_lvl2";
			this.rad_lvl2.Size = new System.Drawing.Size(72, 16);
			this.rad_lvl2.TabIndex = 35;
			this.rad_lvl2.Tag = "2";
			this.rad_lvl2.Text = "Invoice";
			this.rad_lvl2.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_lvl1
			// 
			this.rad_lvl1.Location = new System.Drawing.Point(16, 16);
			this.rad_lvl1.Name = "rad_lvl1";
			this.rad_lvl1.Size = new System.Drawing.Size(60, 16);
			this.rad_lvl1.TabIndex = 34;
			this.rad_lvl1.Tag = "1";
			this.rad_lvl1.Text = "Order";
			this.rad_lvl1.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// txtBooking
			// 
			this.txtBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBooking.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBooking.Font = new System.Drawing.Font("����", 9F);
			this.txtBooking.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtBooking.Location = new System.Drawing.Point(485, 106);
			this.txtBooking.MaxLength = 20;
			this.txtBooking.Name = "txtBooking";
			this.txtBooking.Size = new System.Drawing.Size(200, 21);
			this.txtBooking.TabIndex = 10;
			this.txtBooking.Text = "";
			// 
			// btn_Origin
			// 
			this.btn_Origin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Origin.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Origin.Font = new System.Drawing.Font("����", 9F);
			this.btn_Origin.ImageIndex = 0;
			this.btn_Origin.ImageList = this.img_LongButton;
			this.btn_Origin.Location = new System.Drawing.Point(899, 110);
			this.btn_Origin.Name = "btn_Origin";
			this.btn_Origin.TabIndex = 564;
			this.btn_Origin.Text = "Origin";
			this.btn_Origin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Origin.Click += new System.EventHandler(this.btn_Origin_Click);
			this.btn_Origin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Origin_MouseUp);
			this.btn_Origin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Origin_MouseDown);
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_booking
			// 
			this.btn_booking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_booking.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_booking.Font = new System.Drawing.Font("����", 9F);
			this.btn_booking.ImageIndex = 0;
			this.btn_booking.ImageList = this.img_LongButton;
			this.btn_booking.Location = new System.Drawing.Point(798, 110);
			this.btn_booking.Name = "btn_booking";
			this.btn_booking.TabIndex = 563;
			this.btn_booking.Text = "Booking Form";
			this.btn_booking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
			this.btn_booking.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_booking_MouseUp);
			this.btn_booking.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_booking_MouseDown);
			// 
			// chk_ship
			// 
			this.chk_ship.Location = new System.Drawing.Point(91, 88);
			this.chk_ship.Name = "chk_ship";
			this.chk_ship.Size = new System.Drawing.Size(13, 13);
			this.chk_ship.TabIndex = 561;
			this.chk_ship.CheckedChanged += new System.EventHandler(this.chk_ship_CheckedChanged);
			// 
			// chk_invoice
			// 
			this.chk_invoice.Location = new System.Drawing.Point(468, 44);
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
			this.cmb_trans.EditorFont = new System.Drawing.Font("����", 9F);
			this.cmb_trans.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_trans.EditorHeight = 17;
			this.cmb_trans.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_trans.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_trans.GapHeight = 2;
			this.cmb_trans.ItemHeight = 15;
			this.cmb_trans.Location = new System.Drawing.Point(109, 62);
			this.cmb_trans.MatchEntryTimeout = ((long)(2000));
			this.cmb_trans.MaxDropDownItems = ((short)(5));
			this.cmb_trans.MaxLength = 32767;
			this.cmb_trans.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_trans.Name = "cmb_trans";
			this.cmb_trans.PartialRightColumn = false;
			this.cmb_trans.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:����, 9pt;B" +
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
			this.cmb_trans.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_trans.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_trans.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_trans.Size = new System.Drawing.Size(200, 21);
			this.cmb_trans.TabIndex = 2;
			// 
			// dpick_invoice_from
			// 
			this.dpick_invoice_from.CustomFormat = "";
			this.dpick_invoice_from.Enabled = false;
			this.dpick_invoice_from.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_invoice_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_invoice_from.Location = new System.Drawing.Point(485, 40);
			this.dpick_invoice_from.Name = "dpick_invoice_from";
			this.dpick_invoice_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_invoice_from.TabIndex = 5;
			this.dpick_invoice_from.ValueChanged += new System.EventHandler(this.dpick_invoice_from_ValueChanged);
			// 
			// dpick_invoice_to
			// 
			this.dpick_invoice_to.CustomFormat = "";
			this.dpick_invoice_to.Enabled = false;
			this.dpick_invoice_to.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_invoice_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_invoice_to.Location = new System.Drawing.Point(594, 40);
			this.dpick_invoice_to.Name = "dpick_invoice_to";
			this.dpick_invoice_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_invoice_to.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(576, 42);
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
			this.dpick_ship_from.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ship_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ship_from.Location = new System.Drawing.Point(109, 84);
			this.dpick_ship_from.Name = "dpick_ship_from";
			this.dpick_ship_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_ship_from.TabIndex = 3;
			this.dpick_ship_from.ValueChanged += new System.EventHandler(this.dpick_ship_from_ValueChanged);
			// 
			// dpick_ship_to
			// 
			this.dpick_ship_to.CustomFormat = "";
			this.dpick_ship_to.Enabled = false;
			this.dpick_ship_to.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ship_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ship_to.Location = new System.Drawing.Point(220, 84);
			this.dpick_ship_to.Name = "dpick_ship_to";
			this.dpick_ship_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_ship_to.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(199, 86);
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
			this.txt_invoice_no.Font = new System.Drawing.Font("����", 9F);
			this.txt_invoice_no.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_invoice_no.Location = new System.Drawing.Point(485, 62);
			this.txt_invoice_no.MaxLength = 20;
			this.txt_invoice_no.Name = "txt_invoice_no";
			this.txt_invoice_no.Size = new System.Drawing.Size(200, 21);
			this.txt_invoice_no.TabIndex = 7;
			this.txt_invoice_no.Text = "";
			// 
			// lbl_trans_cd
			// 
			this.lbl_trans_cd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_trans_cd.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_trans_cd.ImageIndex = 0;
			this.lbl_trans_cd.ImageList = this.img_Label;
			this.lbl_trans_cd.Location = new System.Drawing.Point(8, 62);
			this.lbl_trans_cd.Name = "lbl_trans_cd";
			this.lbl_trans_cd.Size = new System.Drawing.Size(100, 21);
			this.lbl_trans_cd.TabIndex = 548;
			this.lbl_trans_cd.Text = "Transport Div.";
			this.lbl_trans_cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(8, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 547;
			this.label3.Text = "Ship Date";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(384, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 546;
			this.label1.Text = "Invoice #";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_invoice_date
			// 
			this.lbl_invoice_date.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_invoice_date.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_invoice_date.ImageIndex = 0;
			this.lbl_invoice_date.ImageList = this.img_Label;
			this.lbl_invoice_date.Location = new System.Drawing.Point(384, 40);
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
			this.txt_po_no.Font = new System.Drawing.Font("����", 9F);
			this.txt_po_no.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_po_no.Location = new System.Drawing.Point(485, 84);
			this.txt_po_no.MaxLength = 10;
			this.txt_po_no.Name = "txt_po_no";
			this.txt_po_no.Size = new System.Drawing.Size(140, 21);
			this.txt_po_no.TabIndex = 8;
			this.txt_po_no.Text = "";
			// 
			// lbl_booking
			// 
			this.lbl_booking.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_booking.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_booking.ImageIndex = 0;
			this.lbl_booking.ImageList = this.img_Label;
			this.lbl_booking.Location = new System.Drawing.Point(384, 106);
			this.lbl_booking.Name = "lbl_booking";
			this.lbl_booking.Size = new System.Drawing.Size(100, 21);
			this.lbl_booking.TabIndex = 381;
			this.lbl_booking.Text = "Booking #";
			this.lbl_booking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_factory.EditorFont = new System.Drawing.Font("����", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_factory.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:����, 9pt;B" +
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
			this.txt_po_item.Font = new System.Drawing.Font("����", 9F);
			this.txt_po_item.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_po_item.Location = new System.Drawing.Point(626, 84);
			this.txt_po_item.MaxLength = 10;
			this.txt_po_item.Name = "txt_po_item";
			this.txt_po_item.Size = new System.Drawing.Size(59, 21);
			this.txt_po_item.TabIndex = 9;
			this.txt_po_item.Text = "";
			// 
			// lbl_po_no
			// 
			this.lbl_po_no.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_po_no.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_po_no.ImageIndex = 0;
			this.lbl_po_no.ImageList = this.img_Label;
			this.lbl_po_no.Location = new System.Drawing.Point(384, 84);
			this.lbl_po_no.Name = "lbl_po_no";
			this.lbl_po_no.Size = new System.Drawing.Size(100, 21);
			this.lbl_po_no.TabIndex = 365;
			this.lbl_po_no.Text = "Po / Item #";
			this.lbl_po_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(992, 124);
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
			this.pic_head4.Size = new System.Drawing.Size(968, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.pic_head7.Size = new System.Drawing.Size(101, 99);
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
			this.label2.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Bold);
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
			this.pic_head1.Size = new System.Drawing.Size(968, 32);
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
			// Form_TI_Stuffing
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_TI_Stuffing";
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
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_trans)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed;
		private int _temp_row = 0, _temp_col = 0;
		private	double	_mediation_margin;
		private	string	_Trans_cd;

		private int _colT_LEVEL			     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxT_LEVEL;
		private int _colCHK			         = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxCHK;
		private int _colFACTORY 		     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFACTORY;
		private int _colSTYLE_CD		     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxSTYLE_CD;
		private int _colSTYLE_NM		     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxSTYLE_NM;
		private int _colINVOICE_DATE	     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxSTYLE_CD;
		private int _colINVOICE_NO		     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxSTYLE_NM;
		private int _colSHIP_DATE		     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxGEN_NM;
		private int _colGEN_NM			     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxGEN_NM;
		private int _colORDER_SHOE_QTY       = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxORDER_SHOE_QTY;
		private int _colINVOICE_SHOE_QTY     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxINVOICE_SHOE_QTY;
		private int _colINVOICE_CT_QTY       = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxINVOICE_CT_QTY;
		private int _colPO_NO                = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxPO_NO;
		private int _colPO_ITEM              = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxPO_ITEM;
		private int _colPO_NO_K              = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxPO_NO_K;
		private int _colPO_ITEM_K            = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxPO_ITEM_K;		
		private int _colTRADE_CS_FOB         = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxTRADE_CS_FOB;
		private int _colTRADE_FACTORY_FOB    = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxTRADE_FACTORY_FOB;
		private int _colAMOUNT               = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxAMOUNT;
		private int _colINVOICE_KEY    	     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxINVOICE_KEY;												     
		private int _colCI_WEIGHT     	     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxCI_WEIGHT;
		private int _colCI_NO      	         = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxCI_NO;
		private int _colCCIB      	         = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxCCIB;										     
		private int _colCBM     	         = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxCBM;
		private int _colNET_WEIGHT     	     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxNET_WEIGHT;
		private int _colGROSS_WEIGHT         = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxGROSS_WEIGHT;
		private int _colORD_DATE             = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxORD_DATE;
		private int _colPO_TYPE_NM           = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxPO_TYPE_NM;										     
		private int _colBOOKING_NO           = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxBOOKING_NO;
		private int _colBOOKING_DATE         = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxBOOKING_DATE;
		private int _colBOOKING_REVISE_DATE  = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxBOOKING_REVISE_DATE;
		private int _colDELIVERY_DATE        = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxDELIVERY_DATE;		
		private int _colFFS_STENCIL_DEST     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFFS_STENCIL_DEST;										     
		private int _colBUKRS			     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxBUKRS;
		private int _colFFS_SOLDTO_CD	     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFFS_SOLDTO_CD;
		private int _colFFS_NAME2		     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFFS_NAME2;
		private int _colNOTIFY_KEY		     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxNOTIFY_KEY;
		private int _colNOTIFY_NAME1	     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxNOTIFY_NAME1;										     
		private int _colCUST_XREF		     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxCUST_XREF;
		private int _colWERKS			     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxWERKS;
		private int _colFFS_SHP_TO_ACCT	     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFFS_SHP_TO_ACCT;
		private int _colFFS_STENCIL_SHIPTO	 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFFS_STENCIL_SHIPTO;
		private int _colFFS_STENCIL_ORIGIN	 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFFS_STENCIL_ORIGIN;		
		private int _colTRANS_CD			 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxTRANS_CD;
		private int _colTRANS_NM			 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxTRANS_NM;
		private int _colLC_NO				 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxLC_NO;
		private int _colM_BL_NO				 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxM_BL_NO;
		private int _colPL_NO				 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxPL_NO;
		private int _colAFS_CATEGORY		 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxAFS_CATEGORY;
		private int _colCUST_PO_NO			 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxCUST_PO_NO;
		private int _colRGAC_DATE			 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxRGAC_DATE;
		private int _colBGAC_DATE			 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxBGAC_DATE;
		private int _colAIR_CHARGES			 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxAIR_CHARGES;
		private int _colSIZE_DIV			 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxSIZE_DIV;
		private int _colSIZE_FROM			 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxSIZE_FROM;
		private int _colSIZE_TO			     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxSIZE_TO;
		private int _colREMARKS			     = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxREMARKS;

		private int _colAIR_DISCHARGE		 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxAIR_DISCHARGE;
		private int _colFORWARDER_TO		 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFORWARDER_TO;
		private int _colFORWARDER_FR		 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFORWARDER_FR;
		private int _colFORWARDER_AF_NO 	 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFORWARDER_AF_NO;
		private int _colFORWARDER_REMARK_1	 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFORWARDER_REMARK_1;
		private int _colFORWARDER_REMARK_2	 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFORWARDER_REMARK_2;
		private int _colFORWARDER_REMARK_3	 = (int)ClassLib.TBSTM_INVOICE_BOOKING_1.IxFORWARDER_REMARK_3;


		#endregion

		#region constructor / destructor

		public Form_TI_Stuffing()
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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
			int    iRow   = fgrid_main.Selection.r1;
			int    iCol   = fgrid_main.Selection.c1;
			string sLevel = fgrid_main[iRow, _colT_LEVEL].ToString();

			if ((iCol == _colFFS_SOLDTO_CD)&&(fgrid_main.Cols[iCol].ComboList == "...")&&(_temp_row==iRow)&&(_temp_col==iCol))
			{					
					Get_Consignee_Data();	
					fgrid_main.Cols[iCol].ComboList = "";
					
			}
			else if ((iCol == _colNOTIFY_KEY)&&(fgrid_main.Cols[iCol].ComboList == "...")&&(_temp_row==iRow)&&(_temp_col==iCol))
			{					
				Get_Notify_Data();	
				fgrid_main.Cols[iCol].ComboList = "";
					
			}
			else if (sLevel.Equals("2"))
			{
				if ((iCol == _colSTYLE_CD)||(iCol == _colGEN_NM)||(iCol == _colORD_DATE))
				{
					fgrid_main.Cols[iCol].Style.DataType = typeof(DateTime);
					fgrid_main.Cols[iCol].Style.Format   = "yyyy-MM-dd";							
				}
				else if ((iCol == _colFFS_SOLDTO_CD)||(iCol == _colNOTIFY_KEY))
				{
					fgrid_main.Cols[iCol].Style.DataType = typeof(string);
					fgrid_main.Cols[iCol].ComboList = "...";

					_temp_row = iRow;
					_temp_col = iCol;
				}
			}


			

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
			else
			{				
				MessageBox.Show("Omitted Invoice Date/Invoice #/Ship date");
			}
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int sel_row = fgrid_main.Selection.r1;

			if (sel_row < _Rowfixed) 
				return;

			if (fgrid_main[sel_row, _colT_LEVEL].ToString() == "1")
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

		private void menuItem1_Click(object sender, System.EventArgs e)
		{

		}

		private void Get_Consignee_Data()
		{
			int iRow = fgrid_main.Selection.r1;
			string sBukrs = "";

			if (fgrid_main[iRow, _colBUKRS] != null)
				sBukrs = fgrid_main[iRow, _colBUKRS].ToString();

			string[] keys = new string[]{ fgrid_main[iRow, _colFACTORY].ToString(),
										  sBukrs  };

						
			COM.ComVar.Parameter_PopUp		= new string[0];
			Pop_TI_Consignee_Master pop_consignee = new Pop_TI_Consignee_Master(keys);
			pop_consignee.ShowDialog();

			if (COM.ComVar.Parameter_PopUp.Length > 1)
			{
				fgrid_main[iRow, _colBUKRS]         = COM.ComVar.Parameter_PopUp[0];
				fgrid_main[iRow, _colFFS_SOLDTO_CD] = COM.ComVar.Parameter_PopUp[1];
				fgrid_main[iRow, _colFFS_NAME2]     = COM.ComVar.Parameter_PopUp[2];

				fgrid_main.Update_Row(iRow);

				COM.ComVar.Parameter_PopUp		= new string[0];
			}			

			pop_consignee.Dispose();
		}

		private void Get_Notify_Data()
		{
			int iRow = fgrid_main.Selection.r1;

			string[] keys = new string[]{ fgrid_main[iRow, _colFACTORY].ToString() };

			COM.ComVar.Parameter_PopUp		= new string[0];
			Pop_TI_Notify_Master pop_notify = new Pop_TI_Notify_Master(keys);
			pop_notify.ShowDialog();

			if (COM.ComVar.Parameter_PopUp.Length > 1)
			{
				fgrid_main[iRow, _colNOTIFY_KEY]   = COM.ComVar.Parameter_PopUp[0];
				fgrid_main[iRow, _colNOTIFY_NAME1] = COM.ComVar.Parameter_PopUp[1];

				fgrid_main.Update_Row(iRow);

				COM.ComVar.Parameter_PopUp		= new string[0];
			}
			
			pop_notify.Dispose();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{

		}



		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
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

		private void btn_booking_Click(object sender, System.EventArgs e)
		{
			this.btn_BookingProcess();
		}


		private void btn_booking_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_booking.ImageIndex = 1;
		}

		private void btn_booking_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_booking.ImageIndex = 0;
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

			MyOraDB.ReDim_Parameter(13);

			//01.PROCEDURE��
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT ��
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_SHIP_DATE_FROM";
			MyOraDB.Parameter_Name[ 2]  = "ARG_SHIP_DATE_TO";			
			MyOraDB.Parameter_Name[ 3]  = "ARG_INVOICE_DATE_FROM";
			MyOraDB.Parameter_Name[ 4]  = "ARG_INVOICE_DATE_TO";
			MyOraDB.Parameter_Name[ 5]  = "ARG_INVOICE_NO";
			MyOraDB.Parameter_Name[ 6]  = "ARG_PO_NO";
			MyOraDB.Parameter_Name[ 7]  = "ARG_PO_ITEM";			
			MyOraDB.Parameter_Name[ 8]  = "ARG_TRANS_CD";
			MyOraDB.Parameter_Name[ 9]  = "ARG_BOOKING_NO";
			MyOraDB.Parameter_Name[10]  = "ARG_BOOKING_DATE_FROM";
			MyOraDB.Parameter_Name[11]  = "ARG_BOOKING_DATE_TO";
			MyOraDB.Parameter_Name[12]  = "OUT_CURSOR";

			//03.DATA TYPE ����
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
			MyOraDB.Parameter_Type[12]  = (int)OracleType.Cursor;

			//04.DATA ����
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
			MyOraDB.Parameter_Values[ 9]   = ClassLib.ComFunction.Empty_TextBox(txtBooking, "");

			if (chkbook.Checked)
			{
				MyOraDB.Parameter_Values[10]   = this.dpick_booking_date_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[11]   = this.dpick_booking_date_to.Text.Replace("-", "");
			}
			else
			{
				MyOraDB.Parameter_Values[10]   = "________";
				MyOraDB.Parameter_Values[11]   = "________";
			}

			MyOraDB.Parameter_Values[12]   = "";

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
				int iCount  = 50;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE��
				MyOraDB.Process_Name = "PKG_STM_INVOICE_BOOKING.SAVE_STM_INVOICE_BOOKING_1";

				//02.ARGURMENT ��
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_PO_NO";
				MyOraDB.Parameter_Name[ 3] = "ARG_PO_ITEM";
				MyOraDB.Parameter_Name[ 4] = "ARG_INVOICE_KEY";
				MyOraDB.Parameter_Name[ 5] = "ARG_INVOICE_DATE";
				MyOraDB.Parameter_Name[ 6] = "ARG_INVOICE_NO";
				MyOraDB.Parameter_Name[ 7] = "ARG_SHIP_DATE";
				MyOraDB.Parameter_Name[ 8] = "ARG_CI_WEIGHT";
				MyOraDB.Parameter_Name[ 9] = "ARG_CI_NO";
				MyOraDB.Parameter_Name[10] = "ARG_CCIB";
				MyOraDB.Parameter_Name[11] = "ARG_CBM";
				MyOraDB.Parameter_Name[12] = "ARG_NET_WEIGHT";
				MyOraDB.Parameter_Name[13] = "ARG_GROSS_WEIGHT";
				MyOraDB.Parameter_Name[14] = "ARG_ORD_DATE";
				MyOraDB.Parameter_Name[15] = "ARG_BOOKING_NO";
				MyOraDB.Parameter_Name[16] = "ARG_BOOKING_DATE";
				MyOraDB.Parameter_Name[17] = "ARG_DELIVERY_DATE";
				MyOraDB.Parameter_Name[18] = "ARG_FFS_SOLDTO_CD";
				MyOraDB.Parameter_Name[19] = "ARG_NOTIFY_KEY";
				MyOraDB.Parameter_Name[20] = "ARG_WERKS";		
				MyOraDB.Parameter_Name[21] = "ARG_FFS_SHP_TO_ACCT";
				MyOraDB.Parameter_Name[22] = "ARG_CUST_XREF";	
				MyOraDB.Parameter_Name[23] = "ARG_FFS_STENCIL_DEST";
				MyOraDB.Parameter_Name[24] = "ARG_FFS_STENCIL_SHIPTO";
				MyOraDB.Parameter_Name[25] = "ARG_FFS_STENCIL_ORIGIN";
				MyOraDB.Parameter_Name[26] = "ARG_DS_FOB";
				MyOraDB.Parameter_Name[27] = "ARG_FACTORY_FOB";
				MyOraDB.Parameter_Name[28] = "ARG_AMOUNT";
				MyOraDB.Parameter_Name[29] = "ARG_CUST_PO_NO";
				MyOraDB.Parameter_Name[30] = "ARG_LC_NO";
				MyOraDB.Parameter_Name[31] = "ARG_M_BL_NO";
				MyOraDB.Parameter_Name[32] = "ARG_PL_NO";
				MyOraDB.Parameter_Name[33] = "ARG_AFS_CATEGORY";
				MyOraDB.Parameter_Name[34] = "ARG_AIR_CHARGES";
				MyOraDB.Parameter_Name[35] = "ARG_SIZE_DIV";
				MyOraDB.Parameter_Name[36] = "ARG_SIZE_FROM";
				MyOraDB.Parameter_Name[37] = "ARG_SIZE_TO";
				MyOraDB.Parameter_Name[38] = "ARG_INVOICE_CT_QTY";
				MyOraDB.Parameter_Name[39] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[40] = "ARG_BGAC_DATE";
				MyOraDB.Parameter_Name[41] = "ARG_BOOKING_REVISE_DATE";
				MyOraDB.Parameter_Name[42] = "ARG_AIR_DISCHARGE";
				MyOraDB.Parameter_Name[43] = "ARG_FORWARDER_TO";
				MyOraDB.Parameter_Name[44] = "ARG_FORWARDER_FR";
				MyOraDB.Parameter_Name[45] = "ARG_FORWARDER_AF_NO";
				MyOraDB.Parameter_Name[46] = "ARG_FORWARDER_REMARK_1";
				MyOraDB.Parameter_Name[47] = "ARG_FORWARDER_REMARK_2";
				MyOraDB.Parameter_Name[48] = "ARG_FORWARDER_REMARK_3";
				MyOraDB.Parameter_Name[49] = "ARG_UPD_USER";


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;

				// �Ķ���� ���� ������ �迭
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if(fgrid_main[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iRow, _colFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colPO_NO_K].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow, _colPO_ITEM_K].ToString();
						MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main[iRow, _colINVOICE_KEY].ToString();

						MyOraDB.Parameter_Values[para_ct+ 5] = ((fgrid_main[iRow, _colINVOICE_DATE] == null)||(fgrid_main[iRow, _colINVOICE_DATE].ToString().Length == 0)) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colINVOICE_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+ 6] = fgrid_main[iRow, _colINVOICE_NO].ToString();

						MyOraDB.Parameter_Values[para_ct+ 7] = ((fgrid_main[iRow, _colSHIP_DATE] == null)||(fgrid_main[iRow, _colSHIP_DATE].ToString().Length == 0)) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colSHIP_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+ 8] = (fgrid_main[iRow, _colCI_WEIGHT]           == null) ? "" : fgrid_main[iRow, _colCI_WEIGHT].ToString();
						MyOraDB.Parameter_Values[para_ct+ 9] = (fgrid_main[iRow, _colCI_NO]               == null) ? "" : fgrid_main[iRow, _colCI_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+10] = (fgrid_main[iRow, _colCCIB]                == null) ? "" : fgrid_main[iRow, _colCCIB].ToString();
						MyOraDB.Parameter_Values[para_ct+11] = (fgrid_main[iRow, _colCBM]                 == null) ? "0" : fgrid_main[iRow, _colCBM].ToString();
						MyOraDB.Parameter_Values[para_ct+12] = (fgrid_main[iRow, _colNET_WEIGHT]          == null) ? "0" : fgrid_main[iRow, _colNET_WEIGHT].ToString();
						MyOraDB.Parameter_Values[para_ct+13] = (fgrid_main[iRow, _colGROSS_WEIGHT]        == null) ? "0" : fgrid_main[iRow, _colGROSS_WEIGHT].ToString();
						MyOraDB.Parameter_Values[para_ct+14] = ((fgrid_main[iRow, _colORD_DATE]      == null)||(fgrid_main[iRow, _colORD_DATE].ToString().Length == 0)) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colORD_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+15] = (fgrid_main[iRow, _colBOOKING_NO]          == null) ? "" : fgrid_main[iRow, _colBOOKING_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+16] = ((fgrid_main[iRow, _colBOOKING_DATE]  == null)||(fgrid_main[iRow, _colBOOKING_DATE].ToString().Length == 0)) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colBOOKING_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+17] = ((fgrid_main[iRow, _colDELIVERY_DATE] == null)||(fgrid_main[iRow, _colDELIVERY_DATE].ToString().Length == 0)) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colDELIVERY_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+18] = (fgrid_main[iRow, _colFFS_SOLDTO_CD]       == null) ? "" : fgrid_main[iRow, _colFFS_SOLDTO_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+19] = (fgrid_main[iRow, _colNOTIFY_KEY]          == null) ? "0" : fgrid_main[iRow, _colNOTIFY_KEY].ToString();
						MyOraDB.Parameter_Values[para_ct+20] = (fgrid_main[iRow, _colWERKS]               == null) ? "" : fgrid_main[iRow, _colWERKS].ToString();
						MyOraDB.Parameter_Values[para_ct+21] = (fgrid_main[iRow, _colFFS_SHP_TO_ACCT]     == null) ? "" : fgrid_main[iRow, _colFFS_SHP_TO_ACCT].ToString();
						MyOraDB.Parameter_Values[para_ct+22] = (fgrid_main[iRow, _colCUST_XREF]           == null) ? "" : fgrid_main[iRow, _colCUST_XREF].ToString();
						MyOraDB.Parameter_Values[para_ct+23] = (fgrid_main[iRow, _colFFS_STENCIL_DEST]    == null) ? "" : fgrid_main[iRow, _colFFS_STENCIL_DEST].ToString();
						MyOraDB.Parameter_Values[para_ct+24] = (fgrid_main[iRow, _colFFS_STENCIL_SHIPTO]  == null) ? "" : fgrid_main[iRow, _colFFS_STENCIL_SHIPTO].ToString();
						MyOraDB.Parameter_Values[para_ct+25] = (fgrid_main[iRow, _colFFS_STENCIL_ORIGIN]  == null) ? "" : fgrid_main[iRow, _colFFS_STENCIL_ORIGIN].ToString();
						MyOraDB.Parameter_Values[para_ct+26] = fgrid_main[iRow, _colTRADE_CS_FOB].ToString();
						MyOraDB.Parameter_Values[para_ct+27] = fgrid_main[iRow, _colTRADE_FACTORY_FOB].ToString();						

						if (fgrid_main[iRow, _colAMOUNT] == null)
							fgrid_main[iRow, _colAMOUNT] = Convert.ToDouble(fgrid_main[iRow, _colINVOICE_SHOE_QTY]) * 
														   Convert.ToDouble(fgrid_main[iRow, _colTRADE_FACTORY_FOB]);
						MyOraDB.Parameter_Values[para_ct+28] = fgrid_main[iRow, _colAMOUNT].ToString();

						MyOraDB.Parameter_Values[para_ct+29] = (fgrid_main[iRow, _colCUST_PO_NO]      == null) ? "" : fgrid_main[iRow, _colCUST_PO_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+30] = (fgrid_main[iRow, _colLC_NO]           == null) ? "" : fgrid_main[iRow, _colLC_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+31] = (fgrid_main[iRow, _colM_BL_NO]         == null) ? "" : fgrid_main[iRow, _colM_BL_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+32] = (fgrid_main[iRow, _colPL_NO]           == null) ? "" : fgrid_main[iRow, _colPL_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+33] = (fgrid_main[iRow, _colAFS_CATEGORY]    == null) ? "" : fgrid_main[iRow, _colAFS_CATEGORY].ToString();
						MyOraDB.Parameter_Values[para_ct+34] = (fgrid_main[iRow, _colAIR_CHARGES]     == null) ? "" : fgrid_main[iRow, _colAIR_CHARGES].ToString();
						MyOraDB.Parameter_Values[para_ct+35] = (fgrid_main[iRow, _colSIZE_DIV].ToString() == "True") ? "Y" : "N";
						MyOraDB.Parameter_Values[para_ct+36] = (fgrid_main[iRow, _colSIZE_FROM]       == null) ? "" : fgrid_main[iRow, _colSIZE_FROM].ToString();
						MyOraDB.Parameter_Values[para_ct+37] = (fgrid_main[iRow, _colSIZE_TO]         == null) ? "" : fgrid_main[iRow, _colSIZE_TO].ToString();
						MyOraDB.Parameter_Values[para_ct+38] = (fgrid_main[iRow, _colINVOICE_CT_QTY]  == null) ? "0" : fgrid_main[iRow, _colINVOICE_CT_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+39] = (fgrid_main[iRow, _colREMARKS]         == null) ? "" : fgrid_main[iRow, _colREMARKS].ToString();

						MyOraDB.Parameter_Values[para_ct+40] = ((fgrid_main[iRow, _colBGAC_DATE]  == null)||(fgrid_main[iRow, _colBGAC_DATE].ToString().Length == 0)) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colBGAC_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+41] = ((fgrid_main[iRow, _colBOOKING_REVISE_DATE]  == null)||(fgrid_main[iRow, _colBOOKING_REVISE_DATE].ToString().Length == 0)) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colBOOKING_REVISE_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+42] = (fgrid_main[iRow,  _colAIR_DISCHARGE]      == null) ? "" : fgrid_main[iRow, _colAIR_DISCHARGE].ToString();
						MyOraDB.Parameter_Values[para_ct+43] = (fgrid_main[iRow,  _colFORWARDER_TO]       == null) ? "" : fgrid_main[iRow, _colFORWARDER_TO].ToString();
						MyOraDB.Parameter_Values[para_ct+44] = (fgrid_main[iRow,  _colFORWARDER_FR]       == null) ? "" : fgrid_main[iRow, _colFORWARDER_FR].ToString();
						MyOraDB.Parameter_Values[para_ct+45] = (fgrid_main[iRow,  _colFORWARDER_AF_NO]    == null) ? "" : fgrid_main[iRow, _colFORWARDER_AF_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+46] = (fgrid_main[iRow,  _colFORWARDER_REMARK_1] == null) ? "" : fgrid_main[iRow, _colFORWARDER_REMARK_1].ToString();
						MyOraDB.Parameter_Values[para_ct+47] = (fgrid_main[iRow,  _colFORWARDER_REMARK_2] == null) ? "" : fgrid_main[iRow, _colFORWARDER_REMARK_2].ToString();
						MyOraDB.Parameter_Values[para_ct+48] = (fgrid_main[iRow,  _colFORWARDER_REMARK_3] == null) ? "" : fgrid_main[iRow, _colFORWARDER_REMARK_3].ToString();

						MyOraDB.Parameter_Values[para_ct+49] = COM.ComVar.This_User;

						para_ct += iCount;	
					}
				
				}

				MyOraDB.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
				
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

		private bool SAVE_REPORT_REQUEST(string arg_Report_Request_Key, string arg_job_name)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 7;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE��
				MyOraDB.Process_Name = "PKG_STM_REPORT.SAVE_STM_REPORT_REQUEST";

				//02.ARGURMENT ��
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
					if (fgrid_main[iRow, _colT_LEVEL].ToString() == "1") continue;

					if (fgrid_main[iRow, _colCHK].ToString() == "True")
						save_ct += 1;					
				}					


				// �Ķ���� ���� ������ �迭
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if (fgrid_main[iRow, _colT_LEVEL].ToString() == "1") continue;

					if (fgrid_main[iRow, _colCHK].ToString() == "True")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = arg_Report_Request_Key;
						MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iRow, _colFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colINVOICE_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow, _colTRANS_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 4] = " ";
						MyOraDB.Parameter_Values[para_ct+ 5] = arg_job_name;
						MyOraDB.Parameter_Values[para_ct+ 6] = COM.ComVar.This_User;

						para_ct += iCount;	

						_Trans_cd = fgrid_main[iRow, _colTRANS_CD].ToString();
					}				
				}

				MyOraDB.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
				
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


		#endregion

		#region Method

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Booking Management [FT, PS]";
			this.Text		   = "Booking";


			// grid set
			fgrid_main.Set_Grid("STM_INVOICE_BOOKING", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.ListBox;

					

			//�Էº� setup
			Init_Combo();		

			rad_lvl2.Checked = true;
			rad_A.Checked    = true;

			txt_invoice_no.Select();

			fgrid_main.Cols[_colINVOICE_CT_QTY].Format     = "#,###";
			fgrid_main.Cols[_colORDER_SHOE_QTY].Format     = "#,###";
			fgrid_main.Cols[_colINVOICE_SHOE_QTY].Format   = "#,###";
			fgrid_main.Cols[_colTRADE_CS_FOB].Format	   = "#,##0.00";
			fgrid_main.Cols[_colTRADE_FACTORY_FOB].Format  = "#,##0.00";
			fgrid_main.Cols[_colAMOUNT].Format			   = "#,##0.00";

			fgrid_main.Cols[_colCI_WEIGHT].Format          = "#,###";
			fgrid_main.Cols[_colCBM].Format                = "#,##0.00";
			fgrid_main.Cols[_colNET_WEIGHT].Format         = "#,##0.00";
			fgrid_main.Cols[_colGROSS_WEIGHT].Format       = "#,##0.00";

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
                
				string vProcedure     = "PKG_STM_INVOICE_BOOKING.SELECT_STM_INVOICE_BOOKING_1";

				DataTable vDt = SELECT_STM_INVOICE(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					fgrid_main.Tree.Column = _colT_LEVEL; 
										
					Display_FlexGrid(vDt);
					GridSetColor();

					Get_Mediation_Margin();

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

					fgrid_main.Rows[newRow.Row.Index].AllowEditing = false;
					
				}
				else if(iLevel == 2)
				{				
					fgrid_main.Cols[_colBOOKING_DATE].Style.Format        = "yyyy-MM-dd";
					fgrid_main.Cols[_colBOOKING_REVISE_DATE].Style.Format = "yyyy-MM-dd";
					fgrid_main.Cols[_colDELIVERY_DATE].Style.Format       = "yyyy-MM-dd";					
					fgrid_main.Cols[_colORD_DATE].Style.Format            = "yyyy-MM-dd";
					fgrid_main.Cols[_colBGAC_DATE].Style.Format           = "yyyy-MM-dd";
				}


				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
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
				CellRange vRange_5;
				CellRange vRange_6;
				CellRange vRange_7;
				CellRange vRange_8;


				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{


					sLevel      = fgrid_main[iRow, _colT_LEVEL].ToString();
					vRange      = fgrid_main.GetCellRange(iRow, 1, iRow, fgrid_main.Cols.Count-1);
					vRange_1    = fgrid_main.GetCellRange(iRow, 1, iRow, _colGEN_NM);

					vRange_2    = fgrid_main.GetCellRange(iRow, _colTRANS_CD,			iRow,   _colTRANS_NM);
					vRange_3    = fgrid_main.GetCellRange(iRow, _colTRANS_NM+1,         iRow,   _colORD_DATE);

					vRange_4    = fgrid_main.GetCellRange(iRow, _colORD_DATE+1,         iRow,   _colFFS_STENCIL_DEST);					
					vRange_5    = fgrid_main.GetCellRange(iRow, _colFFS_STENCIL_DEST+1, iRow,   _colAIR_CHARGES);

					vRange_6    = fgrid_main.GetCellRange(iRow, _colRGAC_DATE,			iRow,   _colPO_TYPE_NM);
					vRange_7    = fgrid_main.GetCellRange(iRow, _colLC_NO,				iRow,   _colCUST_PO_NO);
					vRange_8    = fgrid_main.GetCellRange(iRow, _colCUST_PO_NO+1,		iRow,   fgrid_main.Cols.Count-1);


					if (sLevel.Equals("1"))
					{						
						fgrid_main.GetCellRange(iRow, _colINVOICE_SHOE_QTY).StyleNew.ForeColor = Color.Red;

						fgrid_main.GetCellRange(iRow, _colAMOUNT).StyleNew.ForeColor = Color.Red;						

						fgrid_main.GetCellRange(iRow, _colTRADE_CS_FOB, iRow, _colTRADE_FACTORY_FOB).StyleNew.ForeColor = Color.DarkGray;						
	
						vRange_2.StyleNew.ForeColor = Color.DarkGray;
						vRange_4.StyleNew.ForeColor = Color.DarkGray;
						vRange_5.StyleNew.ForeColor = Color.DarkGray;

						fgrid_main.GetCellRange(iRow, _colPO_NO).StyleNew.ForeColor   = Color.RoyalBlue;
						fgrid_main.GetCellRange(iRow, _colPO_ITEM).StyleNew.ForeColor = Color.RoyalBlue;

						fgrid_main.GetCellRange(iRow, _colSTYLE_CD).StyleNew.ForeColor = Color.DarkGray;
						fgrid_main.GetCellRange(iRow, _colSTYLE_NM).StyleNew.ForeColor = Color.DarkGray;
						
						fgrid_main.GetCellRange(iRow, _colGEN_NM).StyleNew.ForeColor   = Color.Black;
						fgrid_main.GetCellRange(iRow, _colCUST_PO_NO).StyleNew.ForeColor = Color.DarkGray;

					}
					else if (sLevel.Equals("2"))
					{
						fgrid_main.GetCellRange(iRow,      _colAMOUNT).StyleNew.ForeColor = Color.RoyalBlue;
						fgrid_main.GetCellRange(iRow, _colTRADE_CS_FOB).StyleNew.ForeColor = Color.DarkGreen;

						vRange_1.StyleNew.BackColor = Color.WhiteSmoke;
						vRange_2.StyleNew.BackColor = Color.White;
						vRange_3.StyleNew.BackColor = Color.LightYellow;
						vRange_4.StyleNew.BackColor = Color.LightYellow;
						vRange_5.StyleNew.BackColor = Color.LightYellow;
						vRange_6.StyleNew.BackColor = Color.White;
						vRange_7.StyleNew.BackColor = Color.LightYellow;
						vRange_8.StyleNew.BackColor = Color.White;

						fgrid_main.GetCellRange(iRow, _colFFS_SOLDTO_CD).StyleNew.ForeColor = Color.DarkGreen;					
						fgrid_main.GetCellRange(iRow, _colNOTIFY_KEY).StyleNew.ForeColor = Color.DarkGreen;
						fgrid_main.GetCellRange(iRow, _colFFS_SOLDTO_CD, iRow, _colNOTIFY_NAME1).StyleNew.BackColor = Color.LightYellow;
						
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

			double dTRADE_CS_FOB;
			double dTRADE_FACTORY_FOB=0;
			double dGROSS_WEIGHT;
			double dNET_WEIGHT;
			double dCT_QTY;
			
			if ((iCol == _colINVOICE_SHOE_QTY)||(iCol == _colTRADE_CS_FOB)||(iCol == _colTRADE_FACTORY_FOB))
			{
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

				fgrid_main.Update_Row(iRow);
											   			
			}
			else if (iCol == _colGROSS_WEIGHT)
			{
				dGROSS_WEIGHT = Convert.ToDouble(fgrid_main[iRow, iCol]);
				dCT_QTY       = Convert.ToDouble(fgrid_main[iRow, _colINVOICE_CT_QTY]);

				dNET_WEIGHT = dGROSS_WEIGHT - (dCT_QTY*0.6);
		
				fgrid_main[iRow, _colNET_WEIGHT] = dNET_WEIGHT.ToString();
			}
 

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



		private bool Validate_Check()
		{

			bool b = true;


			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
			{

				if ((fgrid_main[iRow, _colSTYLE_NM].ToString().Replace(" ", "").Trim().Length == 0)||
					(fgrid_main[iRow, _colSTYLE_CD] == null)||					
					(fgrid_main[iRow, _colGEN_NM]   == null))
				{
					b = false;
					break;
				}

			}			

			txt_invoice_no.Select();

			return b;			
		}


		private void btn_BookingProcess()
		{
			try
			{
				string sReport_Job_Name    = "BOOKING";

				DataTable vDt = FlexTrade.ClassLib.ComFunction.CREATE_REPORT_REQUEST_KEY(sReport_Job_Name);
				
				string sReport_Request_Key = vDt.Rows[0].ItemArray[0].ToString();

				if (SAVE_REPORT_REQUEST(sReport_Request_Key, sReport_Job_Name))
					PRINT_INVOICE(sReport_Request_Key, sReport_Job_Name);
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



		private void PRINT_INVOICE(string arg_report_request_key, string arg_job_name)
		{
			string sDir="";

			if (arg_job_name == "BOOKING")
			{
				if (cmb_factory.SelectedValue.ToString() == "QD")
				{
					if (_Trans_cd == "AF")
						sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Booking_AF_QD");
					else
						sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Booking_VL_QD");
				}
				else if (cmb_factory.SelectedValue.ToString() == "VJ")
				{
					if (_Trans_cd == "AF")
						sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Booking_AF_VJ");
					else
					{
						if (rad_A.Checked)
							sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Booking_VL_VJ_Regular_A");
						else
							sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Booking_VL_VJ_Regular_B");
					}
						
				}

			}
			else
			{
				if (cmb_factory.SelectedValue.ToString() == "QD")
					sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Certificate_Origin");
				else if (cmb_factory.SelectedValue.ToString() == "VJ")
					sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Certificate_Origin_VJ");
			}

			string sPara;
			
			sPara  = " /rp ";
			sPara += "'" + cmb_factory.SelectedValue.ToString()  +	"' ";
			sPara += "'" + arg_report_request_key                +	"' ";
			sPara += "'" + _Trans_cd                             +	"' ";


			FlexTrade.Report.Form_RdViewer MyReport = new FlexTrade.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Booking Form";
			MyReport.Show();
				
		}

		#endregion


		private void btn_Origin_Click(object sender, System.EventArgs e)
		{
			this.btn_OriginProcess();
		}

		private void btn_OriginProcess()
		{
			try
			{
				string sReport_Job_Name    = "ORIGIN";

				DataTable vDt = FlexTrade.ClassLib.ComFunction.CREATE_REPORT_REQUEST_KEY(sReport_Job_Name);
				
				string sReport_Request_Key = vDt.Rows[0].ItemArray[0].ToString();

				if (SAVE_REPORT_REQUEST(sReport_Request_Key, sReport_Job_Name))
					PRINT_INVOICE(sReport_Request_Key, sReport_Job_Name);
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

		private void btn_Origin_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Origin.ImageIndex = 1;
		}

		private void btn_Origin_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Origin.ImageIndex = 0;
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if ((chk_ship.Checked)||(chkbook.Checked)||(chk_invoice.Checked))
				this.btn_PrintProcess();
		}

		private void btn_PrintProcess()
		{
			string sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TI_Stuffing_Plan");

			string sPara;
			
			sPara  = " /rp ";
			sPara += "'" + cmb_factory.SelectedValue.ToString()          +	"' ";

			if (chk_ship.Checked)
			{
				sPara += "'" + dpick_ship_from.Text.Replace("-", "")         +	"' ";
				sPara += "'" + dpick_ship_to.Text.Replace("-", "")           +	"' ";
			}
			else
			{
				sPara += "'" + "________" +	"' ";
				sPara += "'" + "________" +	"' ";
			}

			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_trans, "")           +	"' ";

			if (chkbook.Checked)
			{
				sPara += "'" + dpick_booking_date_from.Text.Replace("-", "")         +	"' ";
				sPara += "'" + dpick_booking_date_to.Text.Replace("-", "")           +	"' ";
			}
			else
			{
				sPara += "'" + "________" +	"' ";
				sPara += "'" + "________" +	"' ";
			}

			if (chk_invoice.Checked)
			{
				sPara += "'" + dpick_invoice_from.Text.Replace("-", "")         +	"' ";
				sPara += "'" + dpick_invoice_to.Text.Replace("-", "")           +	"' ";
			}
			else
			{
				sPara += "'" + "________" +	"' ";
				sPara += "'" + "________" +	"' ";
			}

			FlexTrade.Report.Form_RdViewer MyReport = new FlexTrade.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Stuffing Plan";
			MyReport.Show();
				
		}

		private void lbl_MainTitle_Click(object sender, System.EventArgs e)
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

		private void chkbook_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkbook.Checked)
			{
				dpick_booking_date_from.Enabled = true;
				dpick_booking_date_to.Enabled   = true;
			}
			else
			{
				dpick_booking_date_from.Enabled = false;
				dpick_booking_date_to.Enabled   = false;
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

		private void dpick_booking_date_from_ValueChanged(object sender, System.EventArgs e)
		{
			dpick_booking_date_to.Value = dpick_booking_date_from.Value;
		}





	}
}
