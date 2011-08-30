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

namespace FlexTrade.Outgoing
{
	public class Form_TO_Outgoing : COM.TradeWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.DateTimePicker dpick_ship_from;
		private System.Windows.Forms.DateTimePicker dpick_ship_to;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
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
		private System.Windows.Forms.CheckBox chkORD;
		private System.Windows.Forms.DateTimePicker dpick_ord_date_from;
		private System.Windows.Forms.DateTimePicker dpick_ord_date_to;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox chkShip;
		private System.Windows.Forms.Panel panel3;
		public COM.FSP fgrid_main;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblAmount_Factory;
		private System.Windows.Forms.TextBox txtAmount_Factory;
		private System.Windows.Forms.TextBox txtAmount_CS;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.TextBox txtCount;
		private System.Windows.Forms.Label lblpo_type;
		private C1.Win.C1List.C1Combo cmbpo_type;
		private System.ComponentModel.IContainer components = null;

		public Form_TO_Outgoing()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_TO_Outgoing));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtAmount_Factory = new System.Windows.Forms.TextBox();
			this.txtAmount_CS = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.lblAmount_Factory = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.cmbpo_type = new C1.Win.C1List.C1Combo();
			this.lblpo_type = new System.Windows.Forms.Label();
			this.chkShip = new System.Windows.Forms.CheckBox();
			this.chkORD = new System.Windows.Forms.CheckBox();
			this.dpick_ord_date_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_ord_date_to = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dpick_ship_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_ship_to = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
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
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbpo_type)).BeginInit();
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
			this.c1Sizer1.Controls.Add(this.groupBox2);
			this.c1Sizer1.Controls.Add(this.panel3);
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.GridDefinition = "16.4359861591695:False:True;75.2595155709343:False:False;6.9204152249135:False:Fa" +
				"lse;\t0.392156862745098:False:True;98.4313725490196:False:False;0.392156862745098" +
				":False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1020, 578);
			this.c1Sizer1.TabIndex = 30;
			this.c1Sizer1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtAmount_Factory);
			this.groupBox2.Controls.Add(this.txtAmount_CS);
			this.groupBox2.Controls.Add(this.txtQuantity);
			this.groupBox2.Controls.Add(this.txtCount);
			this.groupBox2.Controls.Add(this.lblAmount_Factory);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.ForeColor = System.Drawing.Color.Orange;
			this.groupBox2.Location = new System.Drawing.Point(8, 538);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1004, 40);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "※ Total Info.";
			// 
			// txtAmount_Factory
			// 
			this.txtAmount_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtAmount_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAmount_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAmount_Factory.Font = new System.Drawing.Font("굴림", 9F);
			this.txtAmount_Factory.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtAmount_Factory.Location = new System.Drawing.Point(813, 12);
			this.txtAmount_Factory.MaxLength = 10;
			this.txtAmount_Factory.Name = "txtAmount_Factory";
			this.txtAmount_Factory.ReadOnly = true;
			this.txtAmount_Factory.Size = new System.Drawing.Size(88, 21);
			this.txtAmount_Factory.TabIndex = 67;
			this.txtAmount_Factory.Text = "";
			this.txtAmount_Factory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtAmount_CS
			// 
			this.txtAmount_CS.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtAmount_CS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAmount_CS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAmount_CS.Font = new System.Drawing.Font("굴림", 9F);
			this.txtAmount_CS.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtAmount_CS.Location = new System.Drawing.Point(613, 12);
			this.txtAmount_CS.MaxLength = 10;
			this.txtAmount_CS.Name = "txtAmount_CS";
			this.txtAmount_CS.ReadOnly = true;
			this.txtAmount_CS.Size = new System.Drawing.Size(88, 21);
			this.txtAmount_CS.TabIndex = 66;
			this.txtAmount_CS.Text = "";
			this.txtAmount_CS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtQuantity
			// 
			this.txtQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtQuantity.Font = new System.Drawing.Font("굴림", 9F);
			this.txtQuantity.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtQuantity.Location = new System.Drawing.Point(405, 12);
			this.txtQuantity.MaxLength = 10;
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.ReadOnly = true;
			this.txtQuantity.Size = new System.Drawing.Size(88, 21);
			this.txtQuantity.TabIndex = 65;
			this.txtQuantity.Text = "";
			this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtCount
			// 
			this.txtCount.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCount.Font = new System.Drawing.Font("굴림", 9F);
			this.txtCount.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtCount.Location = new System.Drawing.Point(200, 12);
			this.txtCount.MaxLength = 10;
			this.txtCount.Name = "txtCount";
			this.txtCount.ReadOnly = true;
			this.txtCount.Size = new System.Drawing.Size(88, 21);
			this.txtCount.TabIndex = 64;
			this.txtCount.Text = "";
			this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblAmount_Factory
			// 
			this.lblAmount_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lblAmount_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblAmount_Factory.ForeColor = System.Drawing.Color.Black;
			this.lblAmount_Factory.ImageIndex = 1;
			this.lblAmount_Factory.ImageList = this.img_Label;
			this.lblAmount_Factory.Location = new System.Drawing.Point(712, 12);
			this.lblAmount_Factory.Name = "lblAmount_Factory";
			this.lblAmount_Factory.Size = new System.Drawing.Size(100, 21);
			this.lblAmount_Factory.TabIndex = 63;
			this.lblAmount_Factory.Text = "QD Amount";
			this.lblAmount_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.ImageIndex = 1;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(512, 12);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 62;
			this.label9.Text = "CS Amount";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.ImageIndex = 1;
			this.label6.ImageList = this.img_Label;
			this.label6.Location = new System.Drawing.Point(304, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 61;
			this.label6.Text = "Quantity";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.ImageIndex = 1;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(99, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 60;
			this.label1.Text = "Count";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.fgrid_main);
			this.panel3.Location = new System.Drawing.Point(8, 99);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1004, 435);
			this.panel3.TabIndex = 6;
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
			this.fgrid_main.Size = new System.Drawing.Size(1004, 435);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 37;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.cmbpo_type);
			this.pnl_head.Controls.Add(this.lblpo_type);
			this.pnl_head.Controls.Add(this.chkShip);
			this.pnl_head.Controls.Add(this.chkORD);
			this.pnl_head.Controls.Add(this.dpick_ord_date_from);
			this.pnl_head.Controls.Add(this.dpick_ord_date_to);
			this.pnl_head.Controls.Add(this.label7);
			this.pnl_head.Controls.Add(this.label8);
			this.pnl_head.Controls.Add(this.dpick_ship_from);
			this.pnl_head.Controls.Add(this.dpick_ship_to);
			this.pnl_head.Controls.Add(this.label5);
			this.pnl_head.Controls.Add(this.label3);
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
			this.pnl_head.Size = new System.Drawing.Size(1004, 95);
			this.pnl_head.TabIndex = 4;
			// 
			// cmbpo_type
			// 
			this.cmbpo_type.AddItemCols = 0;
			this.cmbpo_type.AddItemSeparator = ';';
			this.cmbpo_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbpo_type.AutoSize = false;
			this.cmbpo_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbpo_type.Caption = "";
			this.cmbpo_type.CaptionHeight = 17;
			this.cmbpo_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbpo_type.ColumnCaptionHeight = 18;
			this.cmbpo_type.ColumnFooterHeight = 18;
			this.cmbpo_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbpo_type.ContentHeight = 17;
			this.cmbpo_type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbpo_type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbpo_type.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmbpo_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbpo_type.EditorHeight = 17;
			this.cmbpo_type.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmbpo_type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbpo_type.GapHeight = 2;
			this.cmbpo_type.ItemHeight = 15;
			this.cmbpo_type.Location = new System.Drawing.Point(477, 62);
			this.cmbpo_type.MatchEntryTimeout = ((long)(2000));
			this.cmbpo_type.MaxDropDownItems = ((short)(5));
			this.cmbpo_type.MaxLength = 32767;
			this.cmbpo_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbpo_type.Name = "cmbpo_type";
			this.cmbpo_type.PartialRightColumn = false;
			this.cmbpo_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbpo_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbpo_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbpo_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbpo_type.Size = new System.Drawing.Size(200, 21);
			this.cmbpo_type.TabIndex = 581;
			// 
			// lblpo_type
			// 
			this.lblpo_type.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lblpo_type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblpo_type.ImageIndex = 0;
			this.lblpo_type.ImageList = this.img_Label;
			this.lblpo_type.Location = new System.Drawing.Point(376, 62);
			this.lblpo_type.Name = "lblpo_type";
			this.lblpo_type.Size = new System.Drawing.Size(100, 21);
			this.lblpo_type.TabIndex = 580;
			this.lblpo_type.Text = "Buy Group";
			this.lblpo_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkShip
			// 
			this.chkShip.Location = new System.Drawing.Point(460, 44);
			this.chkShip.Name = "chkShip";
			this.chkShip.Size = new System.Drawing.Size(13, 13);
			this.chkShip.TabIndex = 578;
			this.chkShip.CheckedChanged += new System.EventHandler(this.chkShip_CheckedChanged);
			// 
			// chkORD
			// 
			this.chkORD.Checked = true;
			this.chkORD.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkORD.Location = new System.Drawing.Point(93, 66);
			this.chkORD.Name = "chkORD";
			this.chkORD.Size = new System.Drawing.Size(13, 13);
			this.chkORD.TabIndex = 577;
			this.chkORD.CheckedChanged += new System.EventHandler(this.chkORD_CheckedChanged);
			// 
			// dpick_ord_date_from
			// 
			this.dpick_ord_date_from.CustomFormat = "";
			this.dpick_ord_date_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ord_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ord_date_from.Location = new System.Drawing.Point(109, 62);
			this.dpick_ord_date_from.Name = "dpick_ord_date_from";
			this.dpick_ord_date_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_ord_date_from.TabIndex = 573;
			// 
			// dpick_ord_date_to
			// 
			this.dpick_ord_date_to.CustomFormat = "";
			this.dpick_ord_date_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ord_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ord_date_to.Location = new System.Drawing.Point(218, 62);
			this.dpick_ord_date_to.Name = "dpick_ord_date_to";
			this.dpick_ord_date_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_ord_date_to.TabIndex = 574;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(197, 64);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label7.Size = new System.Drawing.Size(16, 16);
			this.label7.TabIndex = 576;
			this.label7.Text = "~";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ImageIndex = 0;
			this.label8.ImageList = this.img_Label;
			this.label8.Location = new System.Drawing.Point(8, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 21);
			this.label8.TabIndex = 575;
			this.label8.Text = "ORD Date";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_ship_from
			// 
			this.dpick_ship_from.CustomFormat = "";
			this.dpick_ship_from.Enabled = false;
			this.dpick_ship_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ship_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ship_from.Location = new System.Drawing.Point(477, 40);
			this.dpick_ship_from.Name = "dpick_ship_from";
			this.dpick_ship_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_ship_from.TabIndex = 2;
			// 
			// dpick_ship_to
			// 
			this.dpick_ship_to.CustomFormat = "";
			this.dpick_ship_to.Enabled = false;
			this.dpick_ship_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ship_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ship_to.Location = new System.Drawing.Point(586, 40);
			this.dpick_ship_to.Name = "dpick_ship_to";
			this.dpick_ship_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_ship_to.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(568, 40);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(16, 16);
			this.label5.TabIndex = 554;
			this.label5.Text = "~";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(376, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 547;
			this.label3.Text = "Ship Date";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_factory.TextChanged += new System.EventHandler(this.cmb_factory_TextChanged);
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(988, 79);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 78);
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
			this.pic_head7.Size = new System.Drawing.Size(101, 54);
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
			this.label2.Text = "      Outgoing Info.";
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
			this.pic_head5.Location = new System.Drawing.Point(0, 79);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 68);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(0, 0);
			this.label10.Name = "label10";
			this.label10.TabIndex = 0;
			// 
			// Form_TO_Outgoing
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_TO_Outgoing";
			this.Load += new System.EventHandler(this.Form_TO_Outgoing_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmbpo_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion



		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed;

		private int _colSHIP_DATE	     = (int)ClassLib.TBSTM_OUTGOING.IxSHIP_DATE;
		private int _colLC_NO            = (int)ClassLib.TBSTM_OUTGOING.IxLC_NO;
		private int _colINVOICE_NO	     = (int)ClassLib.TBSTM_OUTGOING.IxINVOICE_NO;
		private int _colSHOE_QTY	     = (int)ClassLib.TBSTM_OUTGOING.IxSHOE_QTY;
		private int _colCS_AMOUNT	     = (int)ClassLib.TBSTM_OUTGOING.IxCS_AMOUNT;
		private int _colFACTORY_AMOUNT   = (int)ClassLib.TBSTM_OUTGOING.IxFACTORY_AMOUNT;
		private int _colPO_ID	         = (int)ClassLib.TBSTM_OUTGOING.IxPO_ID;
		private int _colFFS_SHP_TO_ACCT	 = (int)ClassLib.TBSTM_OUTGOING.IxFFS_SHP_TO_ACCT;
		private int _colWERKS	         = (int)ClassLib.TBSTM_OUTGOING.IxWERKS;
		private int _colSTYLE_CD         = (int)ClassLib.TBSTM_OUTGOING.IxSTYLE_CD;
		private int _colBOOKING_NO	     = (int)ClassLib.TBSTM_OUTGOING.IxBOOKING_NO;
		private int _colMARGIN_RATE      = (int)ClassLib.TBSTM_OUTGOING.IxMARGIN_RATE;

		#endregion




		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Monthly Outgoing List";
			this.Text		   = "Outgoing";

			// grid set
			fgrid_main.Set_Grid("STM_OUTGOING", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";
			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 

			fgrid_main.Rows[1].AllowMerging = true;

			//입력부 setup
			Init_Combo();		

			fgrid_main.Cols[_colSHOE_QTY].Format	        = "#,###";
			fgrid_main.Cols[_colCS_AMOUNT].Format			= "#,##0.00";
			fgrid_main.Cols[_colFACTORY_AMOUNT].Format		= "#,##0.00";
			fgrid_main.Cols[_colMARGIN_RATE].Format			= "#,##0.00";

			txtCount.Text          = "0";
			txtQuantity.Text       = "0";
			txtAmount_CS.Text      = "0";
			txtAmount_Factory.Text = "0";
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

				lblAmount_Factory.Text = cmb_factory.SelectedValue.ToString();

				//	cmbpo_type
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "STM01");
				COM.ComCtl.Set_ComboList(vDt, cmbpo_type, 1, 2, true, 80, 140);
				cmbpo_type.SelectedIndex = 0;
				vDt.Dispose();
			
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}


		private void Form_TO_Outgoing_Load(object sender, System.EventArgs e)
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
                
				string vProcedure     = "PKG_STM_INVOICE_CS.SELECT_STM_OUTGOING";

				DataTable vDt = SELECT_STM_OUTGOING(vProcedure);

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

		private void Clear_FlexGrid()
		{
			if (fgrid_main.Rows.Fixed != fgrid_main.Rows.Count)
			{				
				fgrid_main.Clear(ClearFlags.UserData, fgrid_main.Rows.Fixed, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
			}
		}

		public DataTable SELECT_STM_OUTGOING(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_SHIP_DATE_FROM";
			MyOraDB.Parameter_Name[2]  = "ARG_SHIP_DATE_TO";			
			MyOraDB.Parameter_Name[3]  = "ARG_ORD_DATE_FROM";
			MyOraDB.Parameter_Name[4]  = "ARG_ORD_DATE_TO";		
			MyOraDB.Parameter_Name[5]  = "ARG_PO_TYPE";		
			MyOraDB.Parameter_Name[6]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");

			if (chkShip.Checked)
			{
				MyOraDB.Parameter_Values[ 1]   = this.dpick_ship_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[ 2]   = this.dpick_ship_to.Text.Replace("-", "");
			}
			else
			{
				MyOraDB.Parameter_Values[ 1]   = "________";
				MyOraDB.Parameter_Values[ 2]   = "________";
			}

			if (chkORD.Checked)
			{
				MyOraDB.Parameter_Values[ 3]   = this.dpick_ord_date_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[ 4]   = this.dpick_ord_date_to.Text.Replace("-", "");
			}
			else
			{
				MyOraDB.Parameter_Values[ 3]   = "________";
				MyOraDB.Parameter_Values[ 4]   = "________";
			}

			MyOraDB.Parameter_Values[5]   = ClassLib.ComFunction.Empty_Combo(cmbpo_type, "");

			MyOraDB.Parameter_Values[6]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private void Display_FlexGrid(DataTable arg_dt)
		{
			double dQuantity       = 0;
			double dAmount_CS      = 0;
			double dAmount_Factory = 0;

			txtCount.Text          = "0";
			txtQuantity.Text       = "0";
			txtAmount_CS.Text      = "0";
			txtAmount_Factory.Text = "0";
			
			fgrid_main.Rows.Count = _Rowfixed;
			fgrid_main.Cols.Count = arg_dt.Columns.Count + 1; 
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_main.AddItem(arg_dt.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);
				fgrid_main[i + _Rowfixed, 0] = ""; 

				dQuantity       = dQuantity       + Convert.ToDouble(arg_dt.Rows[i].ItemArray[_colSHOE_QTY       -1].ToString());
				dAmount_CS      = dAmount_CS      + Convert.ToDouble(arg_dt.Rows[i].ItemArray[_colCS_AMOUNT      -1].ToString());
				dAmount_Factory = dAmount_Factory + Convert.ToDouble(arg_dt.Rows[i].ItemArray[_colFACTORY_AMOUNT -1].ToString());
			} 

			txtCount.Text          = arg_dt.Rows.Count.ToString();
			txtQuantity.Text       = dQuantity.ToString("##,###,##0");
			txtAmount_CS.Text      = dAmount_CS.ToString("##,###,##0.00");
			txtAmount_Factory.Text = dAmount_Factory.ToString("##,###,##0.00");
		}

		// set grid color
		private void GridSetColor()
		{
			try
			{				
				fgrid_main.Cols[_colSHOE_QTY].StyleNew.ForeColor  = Color.DarkGreen;
				fgrid_main.Cols[_colCS_AMOUNT].StyleNew.ForeColor = Color.RoyalBlue;
				fgrid_main.Cols[_colFACTORY_AMOUNT].StyleNew.ForeColor = Color.Red;

				fgrid_main.Cols[_colSHIP_DATE].StyleNew.ForeColor       = Color.RoyalBlue;
				fgrid_main.Cols[_colINVOICE_NO].StyleNew.ForeColor       = Color.DarkViolet;

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
			string sDir = FlexTrade.ClassLib.ComFunction.Set_RD_Directory("Form_TO_Outgoing");

			string sPara;
			
			sPara  = " /rp ";
			sPara += "'" + cmb_factory.SelectedValue.ToString()      +	"' ";

			if (chkShip.Checked)
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

			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmbpo_type, "") + "' ";

			FlexTrade.Report.Form_RdViewer MyReport = new FlexTrade.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Monthly Outgoing List";
			MyReport.Show();
				
		}

		private void chkShip_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkShip.Checked)
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

		private void cmb_factory_TextChanged(object sender, System.EventArgs e)
		{
			lblAmount_Factory.Text = cmb_factory.SelectedValue.ToString() + " Amount";
		}


	}
}

