using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;
using C1.Win.C1FlexGrid;
using System.IO;


namespace FlexMold.Management
{
	public class Form_PB_Mold_In : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private C1.Win.C1List.C1Combo cbo_PO_nu;
		private System.Windows.Forms.DateTimePicker dtp_In;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_mold;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cbo_wh;
		private System.Windows.Forms.Label label12;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtp_PO_date;
		private C1.Win.C1List.C1Combo cbo_In_type;
		private System.ComponentModel.IContainer components = null;
		public COM.FSP fgrid_main;
		public COM.FSP fgrid_size;
		private System.Windows.Forms.TextBox txt_Cust;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_moldnew;
		private System.Windows.Forms.Label label9;

		private COM.OraDB OraDB = new COM.OraDB();

		public Form_PB_Mold_In()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_In));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_moldnew = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_Cust = new System.Windows.Forms.TextBox();
			this.dtp_PO_date = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbo_PO_nu = new C1.Win.C1List.C1Combo();
			this.dtp_In = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbo_In_type = new C1.Win.C1List.C1Combo();
			this.txt_mold = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbo_wh = new C1.Win.C1List.C1Combo();
			this.label12 = new System.Windows.Forms.Label();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.fgrid_main = new COM.FSP();
			this.fgrid_size = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_PO_nu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_In_type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).BeginInit();
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
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 656);
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txt_moldnew);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txt_Cust);
			this.panel1.Controls.Add(this.dtp_PO_date);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.cbo_PO_nu);
			this.panel1.Controls.Add(this.dtp_In);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.cbo_In_type);
			this.panel1.Controls.Add(this.txt_mold);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbo_wh);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.cbo_factory);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 72);
			this.panel1.TabIndex = 29;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(889, 37);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 24);
			this.label9.TabIndex = 84;
			this.label9.Text = "New";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_moldnew
			// 
			this.txt_moldnew.Location = new System.Drawing.Point(928, 38);
			this.txt_moldnew.Name = "txt_moldnew";
			this.txt_moldnew.Size = new System.Drawing.Size(80, 22);
			this.txt_moldnew.TabIndex = 83;
			this.txt_moldnew.Text = "";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(696, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 16);
			this.label7.TabIndex = 82;
			this.label7.Text = "Customer";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Cust
			// 
			this.txt_Cust.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Cust.Location = new System.Drawing.Point(784, 8);
			this.txt_Cust.Name = "txt_Cust";
			this.txt_Cust.Size = new System.Drawing.Size(200, 23);
			this.txt_Cust.TabIndex = 81;
			this.txt_Cust.Text = "";
			// 
			// dtp_PO_date
			// 
			this.dtp_PO_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_PO_date.Location = new System.Drawing.Point(560, 8);
			this.dtp_PO_date.Name = "dtp_PO_date";
			this.dtp_PO_date.Size = new System.Drawing.Size(112, 22);
			this.dtp_PO_date.TabIndex = 79;
			this.dtp_PO_date.ValueChanged += new System.EventHandler(this.dtp_PO_date_ValueChanged);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(488, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 16);
			this.label8.TabIndex = 78;
			this.label8.Text = "PO Date";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(488, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 21);
			this.label6.TabIndex = 77;
			this.label6.Text = "PO NU";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbo_PO_nu
			// 
			this.cbo_PO_nu.AddItemCols = 0;
			this.cbo_PO_nu.AddItemSeparator = ';';
			this.cbo_PO_nu.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_PO_nu.Caption = "";
			this.cbo_PO_nu.CaptionHeight = 17;
			this.cbo_PO_nu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_PO_nu.ColumnCaptionHeight = 17;
			this.cbo_PO_nu.ColumnFooterHeight = 17;
			this.cbo_PO_nu.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_PO_nu.ContentHeight = 17;
			this.cbo_PO_nu.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_PO_nu.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_PO_nu.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_PO_nu.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_PO_nu.EditorHeight = 17;
			this.cbo_PO_nu.GapHeight = 2;
			this.cbo_PO_nu.ItemHeight = 15;
			this.cbo_PO_nu.Location = new System.Drawing.Point(560, 39);
			this.cbo_PO_nu.MatchEntryTimeout = ((long)(2000));
			this.cbo_PO_nu.MaxDropDownItems = ((short)(5));
			this.cbo_PO_nu.MaxLength = 32767;
			this.cbo_PO_nu.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_PO_nu.Name = "cbo_PO_nu";
			this.cbo_PO_nu.PartialRightColumn = false;
			this.cbo_PO_nu.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.cbo_PO_nu.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_PO_nu.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_PO_nu.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_PO_nu.Size = new System.Drawing.Size(128, 23);
			this.cbo_PO_nu.TabIndex = 75;
			this.cbo_PO_nu.SelectedValueChanged += new System.EventHandler(this.cbo_PO_nu_SelectedValueChanged);
			// 
			// dtp_In
			// 
			this.dtp_In.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_In.Location = new System.Drawing.Point(80, 35);
			this.dtp_In.Name = "dtp_In";
			this.dtp_In.Size = new System.Drawing.Size(112, 22);
			this.dtp_In.TabIndex = 73;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(8, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 21);
			this.label5.TabIndex = 72;
			this.label5.Text = "In Date";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(240, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 21);
			this.label4.TabIndex = 71;
			this.label4.Text = "In type";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbo_In_type
			// 
			this.cbo_In_type.AddItemCols = 0;
			this.cbo_In_type.AddItemSeparator = ';';
			this.cbo_In_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_In_type.Caption = "";
			this.cbo_In_type.CaptionHeight = 17;
			this.cbo_In_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_In_type.ColumnCaptionHeight = 17;
			this.cbo_In_type.ColumnFooterHeight = 17;
			this.cbo_In_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_In_type.ContentHeight = 17;
			this.cbo_In_type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_In_type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_In_type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_In_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_In_type.EditorHeight = 17;
			this.cbo_In_type.GapHeight = 2;
			this.cbo_In_type.ItemHeight = 15;
			this.cbo_In_type.Location = new System.Drawing.Point(320, 8);
			this.cbo_In_type.MatchEntryTimeout = ((long)(2000));
			this.cbo_In_type.MaxDropDownItems = ((short)(5));
			this.cbo_In_type.MaxLength = 32767;
			this.cbo_In_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_In_type.Name = "cbo_In_type";
			this.cbo_In_type.PartialRightColumn = false;
			this.cbo_In_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.cbo_In_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_In_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_In_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_In_type.Size = new System.Drawing.Size(142, 23);
			this.cbo_In_type.TabIndex = 70;
			this.cbo_In_type.SelectedValueChanged += new System.EventHandler(this.cbo_In_type_SelectedValueChanged);
			// 
			// txt_mold
			// 
			this.txt_mold.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_mold.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_mold.Location = new System.Drawing.Point(784, 38);
			this.txt_mold.Name = "txt_mold";
			this.txt_mold.Size = new System.Drawing.Size(104, 22);
			this.txt_mold.TabIndex = 65;
			this.txt_mold.Text = "";
			this.txt_mold.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_mold_KeyUp);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(696, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 24);
			this.label2.TabIndex = 64;
			this.label2.Text = "Mold Code";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbo_wh
			// 
			this.cbo_wh.AddItemCols = 0;
			this.cbo_wh.AddItemSeparator = ';';
			this.cbo_wh.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_wh.Caption = "";
			this.cbo_wh.CaptionHeight = 17;
			this.cbo_wh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_wh.ColumnCaptionHeight = 17;
			this.cbo_wh.ColumnFooterHeight = 17;
			this.cbo_wh.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_wh.ContentHeight = 17;
			this.cbo_wh.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_wh.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_wh.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_wh.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_wh.EditorHeight = 17;
			this.cbo_wh.GapHeight = 2;
			this.cbo_wh.ItemHeight = 15;
			this.cbo_wh.Location = new System.Drawing.Point(320, 39);
			this.cbo_wh.MatchEntryTimeout = ((long)(2000));
			this.cbo_wh.MaxDropDownItems = ((short)(5));
			this.cbo_wh.MaxLength = 32767;
			this.cbo_wh.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_wh.Name = "cbo_wh";
			this.cbo_wh.PartialRightColumn = false;
			this.cbo_wh.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.cbo_wh.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_wh.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_wh.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_wh.Size = new System.Drawing.Size(144, 23);
			this.cbo_wh.TabIndex = 63;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(235, 40);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 18);
			this.label12.TabIndex = 62;
			this.label12.Text = "Warehouse";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbo_factory
			// 
			this.cbo_factory.AddItemCols = 0;
			this.cbo_factory.AddItemSeparator = ';';
			this.cbo_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_factory.Caption = "";
			this.cbo_factory.CaptionHeight = 17;
			this.cbo_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_factory.ColumnCaptionHeight = 17;
			this.cbo_factory.ColumnFooterHeight = 17;
			this.cbo_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_factory.ContentHeight = 17;
			this.cbo_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_factory.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cbo_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_factory.EditorHeight = 17;
			this.cbo_factory.Enabled = false;
			this.cbo_factory.GapHeight = 2;
			this.cbo_factory.ItemHeight = 15;
			this.cbo_factory.Location = new System.Drawing.Point(80, 8);
			this.cbo_factory.MatchEntryTimeout = ((long)(2000));
			this.cbo_factory.MaxDropDownItems = ((short)(5));
			this.cbo_factory.MaxLength = 32767;
			this.cbo_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_factory.Name = "cbo_factory";
			this.cbo_factory.PartialRightColumn = false;
			this.cbo_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.cbo_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_factory.Size = new System.Drawing.Size(152, 23);
			this.cbo_factory.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Factory";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.TabIndex = 0;
			// 
			// fgrid_main
			// 
			this.fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_main.AllowEditing = false;
			this.fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_main.BackColor = System.Drawing.Color.Transparent;
			this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main.ColumnInfo = "20,1,0,0,0,95,Columns:0{Width:29;}\t1{TextAlign:CenterCenter;TextAlignFixed:Center" +
				"Center;ImageAlign:CenterCenter;}\t2{TextAlign:CenterCenter;TextAlignFixed:CenterC" +
				"enter;ImageAlign:CenterCenter;}\t3{TextAlign:CenterCenter;TextAlignFixed:CenterCe" +
				"nter;ImageAlign:CenterCenter;}\t4{TextAlign:CenterCenter;TextAlignFixed:CenterCen" +
				"ter;ImageAlign:CenterCenter;}\t5{TextAlign:CenterCenter;TextAlignFixed:CenterCent" +
				"er;ImageAlign:CenterCenter;}\t6{TextAlign:CenterCenter;TextAlignFixed:CenterCente" +
				"r;ImageAlign:CenterCenter;}\t7{TextAlign:CenterCenter;TextAlignFixed:CenterCenter" +
				";ImageAlign:CenterCenter;}\t8{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;" +
				"ImageAlign:CenterCenter;}\t9{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t10{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t11{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t12{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t13{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t14{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t15{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t16{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t17{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t18{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t19{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t";
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 128);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 28;
			this.fgrid_main.Rows.Fixed = 2;
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.fgrid_main.Size = new System.Drawing.Size(1016, 520);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:Transparent;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 49;
			this.fgrid_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseDown);
			this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
			// 
			// fgrid_size
			// 
			this.fgrid_size.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_size.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_size.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_size.BackColor = System.Drawing.Color.Transparent;
			this.fgrid_size.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_size.ColumnInfo = "20,1,0,0,0,95,Columns:0{Width:29;}\t1{TextAlign:CenterCenter;TextAlignFixed:Center" +
				"Center;ImageAlign:CenterCenter;}\t2{TextAlign:CenterCenter;TextAlignFixed:CenterC" +
				"enter;ImageAlign:CenterCenter;}\t3{TextAlign:CenterCenter;TextAlignFixed:CenterCe" +
				"nter;ImageAlign:CenterCenter;}\t4{TextAlign:CenterCenter;TextAlignFixed:CenterCen" +
				"ter;ImageAlign:CenterCenter;}\t5{TextAlign:CenterCenter;TextAlignFixed:CenterCent" +
				"er;ImageAlign:CenterCenter;}\t6{TextAlign:CenterCenter;TextAlignFixed:CenterCente" +
				"r;ImageAlign:CenterCenter;}\t7{TextAlign:CenterCenter;TextAlignFixed:CenterCenter" +
				";ImageAlign:CenterCenter;}\t8{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;" +
				"ImageAlign:CenterCenter;}\t9{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t10{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t11{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t12{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t13{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t14{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t15{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t16{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t17{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t18{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t19{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;I" +
				"mageAlign:CenterCenter;}\t";
			this.fgrid_size.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_size.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_size.Location = new System.Drawing.Point(0, 136);
			this.fgrid_size.Name = "fgrid_size";
			this.fgrid_size.Rows.Count = 100;
			this.fgrid_size.Rows.Fixed = 2;
			this.fgrid_size.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.fgrid_size.Size = new System.Drawing.Size(992, 512);
			this.fgrid_size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:Transparent;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_size.TabIndex = 51;
			this.fgrid_size.Click += new System.EventHandler(this.fgrid_size_Click);
			this.fgrid_size.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_size_MouseDown);
			this.fgrid_size.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_size_MouseUp);
			this.fgrid_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgrid_size_KeyPress);
			// 
			// Form_PB_Mold_In
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 678);
			this.Controls.Add(this.fgrid_size);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.panel1);
			this.Name = "Form_PB_Mold_In";
			this.Text = "Form_Mold_Incoming";
			this.Load += new System.EventHandler(this.Form_PB_Mold_In_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			this.Controls.SetChildIndex(this.fgrid_size, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_PO_nu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_In_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_In_Load(object sender, System.EventArgs e)
		{
//			fgrid_size.Visible = false;
			fgrid_main.Visible = false;
			Init_Form();
			FlexMold.ClassLib.ComVar.This_Win_ID = lbl_MainTitle.Text;
			FlexMold.ClassLib.ComVar.This_Computer = Environment.MachineName;
			Init_Form_Tail();
			txt_moldnew.Enabled = false;
			tbtn_Print.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_New.Enabled = false;
			tbtn_Delete.Enabled = false;
		}
		private void Init_Form()	
		{
			this.lbl_MainTitle.Text = "PCC Mold Incoming";
			ClassLib.ComFunction.SetLangDic(this);

			DataTable dt_ret = Select_com_filter_code_List("SBC21");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_factory, 0, 1, false, false);
			cbo_factory.SelectedValue = "VJ";
			dt_ret = Select_com_filter_code_List("SDV34");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_In_type, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List1("SDV15",ClassLib.ComVar.This_Dept);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

		}
		private void Init_Form_Tail()
		{
			for (int i=0; i< fgrid_main.Rows.Count-2;i++)
			{
				fgrid_main[i+2,0]=(char)(65+i);
			}
			for (int i=0; i <= fgrid_main.Cols.Count-1;i++)
			{
				fgrid_main.Cols[i].TextAlign = TextAlignEnum.CenterCenter;
			}

			fgrid_main[0,0] = "Size";
			fgrid_main[1,0] = "Seq";
			fgrid_main.AutoSizeCols();			
			fgrid_main.Rows[0].TextAlign = TextAlignEnum.CenterCenter ;
			fgrid_main.Cols[0].Width = 30 ;
		}
		private DataTable Select_com_filter_code_List(string com_cd)
		{
			string Proc_Name = "pkg_scm_code.select_com_filter_code_list";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_COM_CD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = com_cd;
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}
		
		private DataTable Select_com_filter_code_List1(string com_cd,string dept_cd)
		{
			string Proc_Name = "PKG_SDT_MOLD_WH.select_com_filter_code_list";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_COM_CD";
			OraDB.Parameter_Name[2] = "ARG_DEPT_CD";
			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = com_cd;
			OraDB.Parameter_Values[2] = dept_cd;
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		private void dtp_PO_date_ValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret = Select_Pur_No();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_PO_nu, 0, 1, false, false);
			
		}
		private DataTable Select_Pur_No()
		{
			string Proc_Name = "PKG_SDT_MOLD.SEARCH_PUR_NO";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_PUR_YMD_FR";
			OraDB.Parameter_Name[2] = "ARG_PUR_YMD_TO";
			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
//			OraDB.Parameter_Values[1] = dtp_PO_date.Text.Replace("/","").Replace("-","");
			OraDB.Parameter_Values[1] = dtp_PO_date.Value.ToString("yyyyMMdd").Replace("/","").Replace("-","");
//			OraDB.Parameter_Values[2] = dtp_PO_date.Text.Replace("/","").Replace("-","");
			OraDB.Parameter_Values[2] = dtp_PO_date.Value.ToString("yyyyMMdd").Replace("/","").Replace("-","");
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if ((cbo_In_type.Text == "" )||(cbo_wh.Text == ""))
				MessageBox.Show("Please choose In Type or W/h");
			else
			{
				DisplaceDetail();				
			}
		}
		private void DisplaceDetail()
		{
			Search_Seq_Stand();
			//Search_Size();
			Search_Size();
			FlexMold.ClassLib.ComVar.This_Action ="S" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
			Search_Seq();
		}
   
		private void Search_Size()
		{
			System.Data.DataTable vDt = null;
			try
			{
				vDt = SELECT_MOLD_SIZE();    
//				fgrid_size.Clear();    
				if(vDt.Rows.Count > 0)
				{
					for(int i = 0; i < vDt.Rows.Count ; i++)
					{
						fgrid_size.Cols.Count  = vDt.Rows.Count + 2 ; 
						fgrid_size[0,0] ="   ";
						fgrid_size[0,i+2] = vDt.Rows[i].ItemArray[1].ToString() ;						
						fgrid_size.AutoSizeCols();
						fgrid_size.Cols[i+1].TextAlign = TextAlignEnum.CenterCenter;
						fgrid_size[1,i+2] = vDt.Rows[i].ItemArray[0].ToString();
					}
				}
				else
				{
					
				}												
				//Init_Form_Tail();
				vDt.Dispose();
			}
			finally
			{
				if (vDt != null) 
					vDt.Dispose();
			}	
		}      

		private System.Data.DataTable SELECT_MOLD_SEQ_STAND()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_OUT_TAIL_SEQ";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_OUT_NU";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3] = "ARG_DIVISION";
			OraDB.Parameter_Name[4] = "ARG_WH_CD";

			OraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;		
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString();
			//if(cbo_PO_nu.Text != "") 
				//OraDB.Parameter_Values[1] = cbo_PO_nu.SelectedValue.ToString();
			//else 
			OraDB.Parameter_Values[1] = "";
//			OraDB.Parameter_Values[2] = txt_mold.Text.Trim();
			if (cbo_In_type.SelectedValue.ToString() == "6")
			{
				OraDB.Parameter_Values[2] = cbo_PO_nu.Text.ToString();
				OraDB.Parameter_Values[3] = "2";
			}			
			else if (cbo_In_type.SelectedValue.ToString() == "7")
			{	
				OraDB.Parameter_Values[2] = txt_mold.Text.Trim();
				OraDB.Parameter_Values[3] = "3 8";			
			}
			else if (cbo_In_type.SelectedValue.ToString() == "17")
			{	
				OraDB.Parameter_Values[2] = txt_mold.Text.Trim();
				OraDB.Parameter_Values[3] = "316";			
			}
			else if (cbo_In_type.SelectedValue.ToString() == "9")
			{
				OraDB.Parameter_Values[2] = txt_mold.Text.Trim();
				OraDB.Parameter_Values[3] = "310";	
			}
			else if (cbo_In_type.SelectedValue.ToString() == "19")
			{
				OraDB.Parameter_Values[2] = txt_mold.Text.Trim();
				OraDB.Parameter_Values[3] = "318";	
			}
			else if (cbo_In_type.SelectedValue.ToString() == "12")
			{
				OraDB.Parameter_Values[2] = txt_mold.Text.Trim();
				OraDB.Parameter_Values[3] = "313";	
			}
			else
			{
				OraDB.Parameter_Values[2] = txt_mold.Text.Trim();
				OraDB.Parameter_Values[3] = "1";			
			}
			OraDB.Parameter_Values[4] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[5] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;
			return retDS.Tables[OraDB.Process_Name];
		}
		private System.Data.DataTable SELECT_MOLD_SIZE()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_TAIL_SIZE";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_PUR_NU";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3] = "ARG_DIVISION";
			OraDB.Parameter_Name[4] = "ARG_WH_CD";

			OraDB.Parameter_Name[5] = "OUT_CURSOR";
			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
					
			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = cbo_PO_nu.Text.ToString();
			OraDB.Parameter_Values[2] = txt_mold.Text.Trim() ;
	
			if (cbo_In_type.SelectedValue.ToString() == "6" && cbo_PO_nu.Text != "") //ORDER IN
				OraDB.Parameter_Values[3] = "1";
			else if (cbo_In_type.SelectedValue.ToString() == "7")
				OraDB.Parameter_Values[3] = "3 8";
			else if (cbo_In_type.SelectedValue.ToString() == "17")
				OraDB.Parameter_Values[3] = "316";
			else if (cbo_In_type.SelectedValue.ToString() == "9")
				OraDB.Parameter_Values[3] = "310";
			else if (cbo_In_type.SelectedValue.ToString() == "19")
				OraDB.Parameter_Values[3] = "318";
			else if (cbo_In_type.SelectedValue.ToString() == "12")
				OraDB.Parameter_Values[3] = "313";	
			else
				OraDB.Parameter_Values[3] = "2";
					
			OraDB.Parameter_Values[4] = cbo_wh.SelectedValue.ToString();
		
			OraDB.Parameter_Values[5] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}
		private void Search_Seq()
		{
			System.Data.DataTable vDt = null;
			try
			{
				vDt = SELECT_MOLD_SEQ();    
				if(vDt.Rows.Count > 0)
				{
					for(int i = 0; i < vDt.Rows.Count; i++)
					{
						for (int k = 0 ; k < fgrid_size.Cols.Count-2 ; k++)
//						for (int k = 0 ; k < fgrid_size.Cols.Count-1 ; k++)
						{
//							if (vDt.Rows[i].ItemArray[1].ToString() == fgrid_size[1,k+2].ToString())							
							if (vDt.Rows[i].ItemArray[1].ToString() == fgrid_size[0,k+2].ToString())							
							{
								for (int j = 0 ; j <fgrid_size.Rows.Count -2 ; j++)
								{
									if (vDt.Rows[i].ItemArray[0].ToString()== fgrid_size[j+2,1].ToString())					
									{
										fgrid_size[j+2,k+2] = vDt.Rows[i].ItemArray[2].ToString();
										fgrid_size.GetCellStyleDisplay(j+2,1).ForeColor = Color.Red;
										fgrid_size.GetCellStyleDisplay(j+2,1).BackColor = Color.AliceBlue;								
									}
								}
							}
						}
					}
					fgrid_size[0,0] = "Size";
					fgrid_size[1,1] = "Seq";
					fgrid_size.AutoSizeCols();			
//					fgrid_size.Rows[0].TextAlign = TextAlignEnum.CenterCenter ;
//					fgrid_size.Cols[0].Width = 30 ;
				}
				else
				{					
				}
				vDt.Dispose();
			}
			finally
			{
				if (vDt != null) 
					vDt.Dispose();
			}	
		}
/*		private void Search_Seq()
		{
			System.Data.DataTable vDt = null;
			//char [] determine = char
			try
			{
				vDt = SELECT_MOLD_SEQ();    
				if(vDt.Rows.Count > 0)
				{
					for(int i = 0; i < vDt.Rows.Count ; i++)
					{
						for (int k = 0 ; k < fgrid_main.Cols.Count-1 ; k++)
						{
							if (vDt.Rows[i].ItemArray[1].ToString() == fgrid_main[0,k+1].ToString())							
							{
								for (int j = 0 ; j <fgrid_main.Rows.Count -2 ; j++)
								{
									if (vDt.Rows[i].ItemArray[0].ToString()== fgrid_main[j+2,0].ToString())								
										fgrid_main[j+2,k+1] = vDt.Rows[i].ItemArray[2].ToString();
								}
							}
						}
					}
				}
				else
				{
		
				}
									
				vDt.Dispose();
			}
			finally
			{
				if (vDt != null) 
					vDt.Dispose();
			}	
		}		*/
		private void Search_Seq_Stand()
		{
			System.Data.DataTable vDt = null;
			try
			{
				vDt = SELECT_MOLD_SEQ_STAND();    
				fgrid_size.Clear();
				//fgrid_size.Rows.Count = 4;

				if(vDt.Rows.Count > 0)
				{
					for(int i = 0; i < vDt.Rows.Count; i++)
					{
						//						fgrid_main.Cols.Count  = vDt.Rows.Count + 1 ; 						
						fgrid_size.Rows.Count  = vDt.Rows.Count + 2 ; 						
						fgrid_size[i+2,1] = vDt.Rows[i].ItemArray[0].ToString() ;						
						fgrid_size.AutoSizeCols();
						fgrid_size.Cols[0].TextAlign = TextAlignEnum.CenterCenter;
					}
				}
				else
				{
					
				}
				//				Init_Form_Tail();
				vDt.Dispose();
			}
			finally
			{
				if (vDt != null) 
					vDt.Dispose();
			}	
		}
		private System.Data.DataTable SELECT_MOLD_SEQ()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_TAIL_SEQ";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_PUR_NU";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3] = "ARG_DIVISION";
			OraDB.Parameter_Name[4] = "ARG_WH_CD";

			OraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
					
			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = cbo_PO_nu.Text.ToString();
			OraDB.Parameter_Values[2] = txt_mold.Text.Trim();
			
			//			if (rBtn_P.Checked == true)
			if (cbo_In_type.SelectedValue.ToString() == "6" && cbo_PO_nu.Text != "")
				OraDB.Parameter_Values[3] = "1";
//			else if ((cbo_In_type.SelectedValue.ToString() == "7")||(cbo_In_type.SelectedValue.ToString() == "17"))
//				OraDB.Parameter_Values[3] = "3";
			else if (cbo_In_type.SelectedValue.ToString() == "7")
				OraDB.Parameter_Values[3] = "3 8";
			else if (cbo_In_type.SelectedValue.ToString() == "17")
				OraDB.Parameter_Values[3] = "316";
			else if (cbo_In_type.SelectedValue.ToString() == "9")
				OraDB.Parameter_Values[3] = "310";
			else if (cbo_In_type.SelectedValue.ToString() == "19")
				OraDB.Parameter_Values[3] = "318";
			else if (cbo_In_type.SelectedValue.ToString() == "12")
				OraDB.Parameter_Values[3] = "313";
			else
				OraDB.Parameter_Values[3] = "2";
			
			OraDB.Parameter_Values[4] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[5] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (cbo_In_type.SelectedValue.ToString() == "6")
			{
				if (txt_moldnew.Text.Trim().ToString() == "")
					MessageBox.Show("Please input Mold Code New");
				else
				{
					save_order();
					FlexMold.ClassLib.ComVar.This_Action ="I" ;
					FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
					FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
				}
			}
			else
			{
				save_other();
				FlexMold.ClassLib.ComVar.This_Action ="I" ;
				FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
				FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
//				MessageBox.Show("Save Complete","Save", MessageBoxButtons.OK ,MessageBoxIcon.Information);
//				fgrid_size.Clear();
			}
		}
		private void save_order()
		{
			
			if ((cbo_In_type.Text == null)||(cbo_wh.Text == ""))
				MessageBox.Show("Please input Incoming Type Or Warehourse");
			else
			{
				DataTable In_seq = Select_In_seq();
				save_mold_In_order(In_seq.Rows[0].ItemArray[0].ToString());
				save_mold_In_order_tail(In_seq.Rows[0].ItemArray[0].ToString());
	//   update mold code vao purchase 
				UPDATE_MOLD_PO();
			}
		}
		private System.Data.DataTable UPDATE_MOLD_PO()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.UPDATE_MOLD_CODE";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_MOLD_CD_OLD";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD_NEW";


			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
					

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString();
			OraDB.Parameter_Values[1] = txt_mold.Text.Trim();
			OraDB.Parameter_Values[2] = txt_moldnew.Text.Trim();
			
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];

		}
		private void save_other()
		{
			if ((cbo_In_type.Text == null)||(cbo_wh.Text == ""))
				MessageBox.Show("Please input Incoming Type Or Warehourse");
			else
			{
				DataTable In_seq = Select_In_seq();
				save_mold_In_order1(In_seq.Rows[0].ItemArray[0].ToString());
				save_mold_In_order_tail1(In_seq.Rows[0].ItemArray[0].ToString());				
			}
		}
		private DataTable Select_In_seq()
		{
			string Proc_Name = "PKG_SDT_MOLD.SELECT_MOLD_IN_MAXSEQ";
			
			OraDB.ReDim_Parameter(3); 

			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_IN_YMD";
			OraDB.Parameter_Name[2]  = "OUT_CURSOR";
 
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString();
//			OraDB.Parameter_Values[1] = dtp_In.Text.Replace("-","").Replace("/","");
			OraDB.Parameter_Values[1] = dtp_In.Value.ToString("yyyyMMdd").Replace("-","").Replace("/","");
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);

			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}
//		private void mold_ord_sum()
//		{
//			int _msum =0;
//			for(int j =1; j< fgrid_main.Cols.Count; j++)
//			{
//				for (int k = 2 ; k < fgrid_main.Rows.Count-2 ; k++)
//				{
//					if(fgrid_main[k,j] != null && fgrid_main[k,j] !="") 
//					{
//						if (fgrid_main[k,j] == "I")
//							_msum = _msum + 1 ;
//					}
//				}
//			}
//			fgrid_head[fgrid_head.RowSel ,15] = _msum.ToString();
//		}
		private void save_mold_In_order(string _seq)
		{
			string process_name = "PKG_SDT_MOLD.SAVE_MOLD_INHEAD";
			OraDB.ReDim_Parameter(17); 

			OraDB.Process_Name = process_name;
			
			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_IN_NO"; //ARG_SPEC_CD
			OraDB.Parameter_Name[2]  = "ARG_IN_SEQ";
			OraDB.Parameter_Name[3]  = "ARG_MOLD_CD";
			OraDB.Parameter_Name[4]  = "ARG_TOTAL_QTY";
			OraDB.Parameter_Name[5]  = "ARG_IN_YMD";
			OraDB.Parameter_Name[6]  = "ARG_IN_TYPE";
			OraDB.Parameter_Name[7]  = "ARG_IN_STATUS";
			OraDB.Parameter_Name[8]  = "ARG_CONFIRM_YN";
			OraDB.Parameter_Name[9]  = "ARG_ACC_UPD_YN";
			OraDB.Parameter_Name[10] = "ARG_CUST_CD";
			OraDB.Parameter_Name[11] = "ARG_WH_CD";
			OraDB.Parameter_Name[12] = "ARG_REMARKS";
			OraDB.Parameter_Name[13] = "ARG_SEND_CHK";
			OraDB.Parameter_Name[14] = "ARG_SEND_YMD";
			OraDB.Parameter_Name[15] = "ARG_UPD_USER";
			OraDB.Parameter_Name[16] = "ARG_UPD_YMD";
			for(int i=0; i< 16 ; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			OraDB.Parameter_Values[0] = "VJ"; 
//			OraDB.Parameter_Values[1] = dtp_In.Text.Replace("-","").Replace("/",""); 
			OraDB.Parameter_Values[1] = dtp_In.Value.ToString("yyyyMMdd").Replace("-","").Replace("/",""); 
			OraDB.Parameter_Values[2] = _seq.ToString().PadLeft(3,'0').ToString(); 
			if (cbo_In_type.SelectedValue.ToString() == "6")
				OraDB.Parameter_Values[3] = txt_moldnew.Text.Trim().ToString (); //MOLD
			else
				OraDB.Parameter_Values[3] = txt_mold.Text.Trim().ToString (); //MOLD
			OraDB.Parameter_Values[4] = "";  //TOT
//			OraDB.Parameter_Values[5] = dtp_In.Text.Replace("-","").Replace("/",""); // Ngay Incoming
			OraDB.Parameter_Values[5] = dtp_In.Value.ToString("yyyyMMdd").Replace("-","").Replace("/",""); // Ngay Incoming
			OraDB.Parameter_Values[6] = cbo_In_type.SelectedValue.ToString(); 
			OraDB.Parameter_Values[7] = "";   //rta
			OraDB.Parameter_Values[8] = "";   //ets
			OraDB.Parameter_Values[9] = ""; 
			OraDB.Parameter_Values[10] = txt_Cust.Text.Trim();
			OraDB.Parameter_Values[11] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[12] = "";
			OraDB.Parameter_Values[13] = txt_moldnew.Text.Trim().ToString ();  // mold code new
			OraDB.Parameter_Values[14] = ""; 
			OraDB.Parameter_Values[15] = COM.ComVar.This_User;
			OraDB.Parameter_Values[16] = ""; 

			OraDB.Add_Modify_Parameter(true); 
			OraDB.Exe_Modify_Procedure();
		}

		private void cbo_PO_nu_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if ((cbo_PO_nu.Text != "")||(cbo_PO_nu.Text == null))
			{
				DataTable Mold = Select_mold();
				string temp = Mold.Rows[0].ItemArray[0].ToString();
				txt_mold.Text = temp;
			}
		}
		private void save_mold_In_order_tail(string _seq)
		{
			try
			{
				for (int i = 1; i < fgrid_size.Cols.Count-1 ; i++)
				{
					for (int j= 0 ; j < fgrid_size.Rows.Count -2 ;j++)
					{
						if (fgrid_size[j+2,i+1]!= null && fgrid_size[j+2,i+1]!= "") 
						{
							if ( fgrid_size[j+2,i+1].ToString() == "I")
							{
								save_mold_In_tail(_seq , txt_mold.Text.Trim(),
									fgrid_size[1,i+1].ToString(),fgrid_size[j+2,1].ToString(),
									fgrid_size[j+2,i+1].ToString());
							}
						}  
						else
						{
							//						break;
						}
					}
				}
				MessageBox.Show("Save Complete","Save", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				fgrid_size.Clear();
			}
			catch
			{
			}
			finally
			{

			}

		}

		private void save_mold_In_tail(string _Inseq,string _mold, string _size, string _moldseq, string _ord)
		{
			string process_name = "PKG_SDT_MOLD.SAVE_MOLD_INTAIL";
			string [] _usesize = null;
			char [] _determid ="/".ToCharArray();

			OraDB.ReDim_Parameter(16); 

			OraDB.Process_Name = process_name;

			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_IN_NO"; //ARG_SPEC_CD
			OraDB.Parameter_Name[2]  = "ARG_IN_SEQ";
			OraDB.Parameter_Name[3]  = "ARG_MOLD_CD";
			OraDB.Parameter_Name[4]  = "ARG_USE_SIZE";
			OraDB.Parameter_Name[5]  = "ARG_SEQ_NO";
			OraDB.Parameter_Name[6]  = "ARG_IN_QTY";
			OraDB.Parameter_Name[7]  = "ARG_PUR_CURRENCY";
			OraDB.Parameter_Name[8]  = "ARG_WH_CD";
			OraDB.Parameter_Name[9]  = "ARG_PUR_NO";
			OraDB.Parameter_Name[10] = "ARG_IN_STATUS";
			OraDB.Parameter_Name[11] = "ARG_REMARKS";
			OraDB.Parameter_Name[12] = "ARG_SEND_CHK";   /// mold code New
			OraDB.Parameter_Name[13] = "ARG_SEND_YMD";
			OraDB.Parameter_Name[14] = "ARG_UPD_USER";
			OraDB.Parameter_Name[15] = "ARG_UPD_YMD";

			for(int i=0; i< 15; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			OraDB.Parameter_Values[0] = "VJ"; 
//			OraDB.Parameter_Values[1] = "VJI" + dtp_In.Text.Replace("-","").Replace("/","") + _Inseq.ToString().PadLeft(3,'0').ToString(); 
			OraDB.Parameter_Values[1] = "VJI" + dtp_In.Value.ToString("yyyyMMdd").Replace("-","").Replace("/","") + _Inseq.ToString().PadLeft(3,'0').ToString(); 
			OraDB.Parameter_Values[2] = _Inseq.ToString().PadLeft(3,'0').ToString();  //pur_seq
			OraDB.Parameter_Values[3] = _mold; 
			_usesize = _size.ToString().Split(_determid);
			OraDB.Parameter_Values[4] = _usesize[0];  //get the use size
			OraDB.Parameter_Values[5] = _moldseq;   			
			OraDB.Parameter_Values[6] = "1";
			OraDB.Parameter_Values[7] = "1";
			OraDB.Parameter_Values[8] = cbo_wh.SelectedValue.ToString();			
			OraDB.Parameter_Values[9] = cbo_PO_nu.Text.ToString();  // Purchase No			
			OraDB.Parameter_Values[10] = _ord ; 
			OraDB.Parameter_Values[11] = cbo_In_type.SelectedValue.ToString();  // IO_type
			OraDB.Parameter_Values[12] = txt_moldnew.Text.Trim().ToString ();  // mold code new
			OraDB.Parameter_Values[13] = ""; 
			OraDB.Parameter_Values[14] = COM.ComVar.This_User;
			OraDB.Parameter_Values[15] = ""; 

			OraDB.Add_Modify_Parameter(true); 
			OraDB.Exe_Modify_Procedure();
		}

		private void txt_mold_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter )
			{
				if ((cbo_In_type.SelectedValue.ToString() == "4")||(cbo_In_type.SelectedValue.ToString() == "14"))
				{
					select();		
					Init_Form_Tail1();
				}
				else
				{
					MessageBox.Show("Please choose In Type","Choose", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				}
			}
		}
		private void select()
		{
			System.Data.DataTable vDt = null;
			try
			{
				vDt = SELECT_MOLD_SIZE_OTHER();    
				fgrid_size.Clear();    
				if(vDt.Rows.Count > 0)
				{
					for(int i = 0; i < vDt.Rows.Count ; i++)
					{
						fgrid_size.Cols.Count  = vDt.Rows.Count+2  ; 						
						fgrid_size[0,i+2] = vDt.Rows[i].ItemArray[1].ToString() ;						
						fgrid_size.Cols[i+2].TextAlign = TextAlignEnum.CenterCenter;
						fgrid_size[1,i+2] = vDt.Rows[i].ItemArray[0].ToString();
						fgrid_size.AutoSizeCols();
					}
				}
				else
				{
					
				}
//				Init_Form_Tail();
				vDt.Dispose();
			}
			finally
			{
				if (vDt != null) 
					vDt.Dispose();
			}	
		}
		private System.Data.DataTable SELECT_MOLD_SIZE_OTHER()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_SIZE_OTHER";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_MOLD_CD";

			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
					
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString();
			OraDB.Parameter_Values[1] = txt_mold.Text.Trim();
			
			OraDB.Parameter_Values[2] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];

		}

		private void cbo_In_type_SelectedValueChanged(object sender, System.EventArgs e)
		{
			fgrid_size.Clear();
			if (cbo_In_type.SelectedValue.ToString() == "6")
			{
//				fgrid_size.Visible = false;
//				fgrid_main.Visible = true;
				txt_mold.Enabled = false;
				txt_moldnew.Enabled = true;
				cbo_PO_nu.Visible =  true;
				tbtn_Search.Enabled = true ;	
				tbtn_Save.Enabled = true ;								
			}
			else if ((cbo_In_type.SelectedValue.ToString() == "7") || (cbo_In_type.SelectedValue.ToString() == "17")|| (cbo_In_type.SelectedValue.ToString() == "9")||(cbo_In_type.SelectedValue.ToString() == "19")||(cbo_In_type.SelectedValue.ToString() == "12"))
			{
//				fgrid_size.Visible = false;
//				fgrid_main.Visible = true;
				txt_mold.Enabled = true;
				txt_moldnew.Enabled = false;
				cbo_PO_nu.Visible =  false;
				tbtn_Search.Enabled = true ;	
				tbtn_Save.Enabled = true ;				
			}
			else
			{
//				fgrid_size.Visible = true;
//				fgrid_main.Visible = false;
				if((ClassLib.ComVar.This_Dept.ToString() =="110000")||(FlexMold.ClassLib.ComVar.This_Dept.ToString() =="0000"))
				{
					tbtn_Save.Enabled = true ;
//					txt_mold.Enabled = true;
				}
				else
				{
					tbtn_Save.Enabled = false ;
				}
				txt_mold.Enabled = true;
				txt_moldnew.Enabled = false;
				cbo_PO_nu.Visible =  false;
				tbtn_Search.Enabled = false ;									
			}
		}
		private void Init_Form_Tail1()
		{
			fgrid_size.Rows.Count = 100;
			for (int i=0; i <= fgrid_size.Cols.Count-1;i++)
			{
				fgrid_size.Cols[i].TextAlign = TextAlignEnum.CenterCenter;
			}
			fgrid_size[0,0] = "Size";
			fgrid_size[1,1] = "Seq";
			fgrid_size.AutoSizeCols();				
			fgrid_size.Rows[0].TextAlign = TextAlignEnum.CenterCenter ;
			fgrid_size.Cols[0].Width = 30 ;
			fgrid_size.Cols[1].AllowEditing = true;				
		}
		private void save_mold_In_order1(string _seq)
		{
			string process_name = "PKG_SDT_MOLD.SAVE_MOLD_INHEAD";
			OraDB.ReDim_Parameter(17); 

			OraDB.Process_Name = process_name;
			
			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_IN_NO"; //ARG_SPEC_CD
			OraDB.Parameter_Name[2]  = "ARG_IN_SEQ";
			OraDB.Parameter_Name[3]  = "ARG_MOLD_CD";
			OraDB.Parameter_Name[4]  = "ARG_TOTAL_QTY";
			OraDB.Parameter_Name[5]  = "ARG_IN_YMD";
			OraDB.Parameter_Name[6]  = "ARG_IN_TYPE";
			OraDB.Parameter_Name[7]  = "ARG_IN_STATUS";
			OraDB.Parameter_Name[8]  = "ARG_CONFIRM_YN";
			OraDB.Parameter_Name[9]  = "ARG_ACC_UPD_YN";
			OraDB.Parameter_Name[10] = "ARG_CUST_CD";
			OraDB.Parameter_Name[11] = "ARG_WH_CD";
			OraDB.Parameter_Name[12] = "ARG_REMARKS";
			OraDB.Parameter_Name[13] = "ARG_SEND_CHK";
			OraDB.Parameter_Name[14] = "ARG_SEND_YMD";
			OraDB.Parameter_Name[15] = "ARG_UPD_USER";
			OraDB.Parameter_Name[16] = "ARG_UPD_YMD";
			for(int i=0; i< 16 ; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			OraDB.Parameter_Values[0] = "VJ"; 
//			OraDB.Parameter_Values[1] = dtp_In.Text.Replace("-","").Replace("/",""); 
			OraDB.Parameter_Values[1] = dtp_In.Value.ToString("yyyyMMdd").Replace("-","").Replace("/",""); 
			OraDB.Parameter_Values[2] = _seq.ToString().PadLeft(3,'0').ToString(); 
			OraDB.Parameter_Values[3] = txt_mold.Text.Trim(); //MOLD
			OraDB.Parameter_Values[4] = "";  //TOT
//			OraDB.Parameter_Values[5] = dtp_In.Text.Replace("-","").Replace("/",""); // Ngay Incoming
			OraDB.Parameter_Values[5] = dtp_In.Value.ToString("yyyyMMdd").Replace("-","").Replace("/",""); // Ngay Incoming
			OraDB.Parameter_Values[6] = cbo_In_type.SelectedValue.ToString(); 
			OraDB.Parameter_Values[7] = "";   //rta
			OraDB.Parameter_Values[8] = "";   //ets
			OraDB.Parameter_Values[9] = ""; 
			OraDB.Parameter_Values[10] = txt_Cust.Text.Trim();
			OraDB.Parameter_Values[11] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[12] = "";
			OraDB.Parameter_Values[13] = ""; 
			OraDB.Parameter_Values[14] = ""; 
			OraDB.Parameter_Values[15] = COM.ComVar.This_User;
			OraDB.Parameter_Values[16] = ""; 

			OraDB.Add_Modify_Parameter(true); 
			OraDB.Exe_Modify_Procedure();
		}
		private void save_mold_In_order_tail1(string _seq)
		{
			try
			{
//			for (int i = 0; i < fgrid_size.Cols.Count-1 ; i++)
			for (int i = 1; i < fgrid_size.Cols.Count-1 ; i++)
			{
				for (int j= 0 ; j<fgrid_size.Rows.Count -2 ;j++)
				{
					if (fgrid_size[j+2,i+1]!= null && fgrid_size[j+2,i+1]!= "")
					{
						if ( fgrid_size[j+2,i+1].ToString() == "I")
						{
//							save_mold_In_tail1(_seq , txt_mold.Text.Trim(),
//								fgrid_size[1,i+1].ToString(),fgrid_size[j+2,0].ToString(),
//								fgrid_size[j+2,i+1].ToString());
							save_mold_In_tail1(_seq , txt_mold.Text.Trim(),
								fgrid_size[1,i+1].ToString(),fgrid_size[j+2,1].ToString(),
								fgrid_size[j+2,i+1].ToString());
						}
					}  
					else
					{
						//						break;
					}
				}
			}
			MessageBox.Show("Save Complete","Save", MessageBoxButtons.OK ,MessageBoxIcon.Information);
			}
			catch
			{
			}
			finally
			{

			}
		}

		private void save_mold_In_tail1(string _Inseq,string _mold, string _size, string _moldseq, string _ord)
		{
			string process_name = "PKG_SDT_MOLD.SAVE_MOLD_INTAIL_OTHER";
			string [] _usesize = null;
			char [] _determid ="/".ToCharArray();

			OraDB.ReDim_Parameter(16); 

			OraDB.Process_Name = process_name;

			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_IN_NO"; //ARG_SPEC_CD
			OraDB.Parameter_Name[2]  = "ARG_IN_SEQ";
			OraDB.Parameter_Name[3]  = "ARG_MOLD_CD";
			OraDB.Parameter_Name[4]  = "ARG_USE_SIZE";
			OraDB.Parameter_Name[5]  = "ARG_SEQ_NO";
			OraDB.Parameter_Name[6]  = "ARG_IN_QTY";
			OraDB.Parameter_Name[7]  = "ARG_PUR_CURRENCY";
			OraDB.Parameter_Name[8]  = "ARG_WH_CD";
			OraDB.Parameter_Name[9]  = "ARG_PUR_NO";
			OraDB.Parameter_Name[10] = "ARG_IN_STATUS";
			OraDB.Parameter_Name[11] = "ARG_REMARKS";
			OraDB.Parameter_Name[12] = "ARG_SEND_CHK";
			OraDB.Parameter_Name[13] = "ARG_SEND_YMD";
			OraDB.Parameter_Name[14] = "ARG_UPD_USER";
			OraDB.Parameter_Name[15] = "ARG_UPD_YMD";

			for(int i=0; i< 15; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			OraDB.Parameter_Values[0] = "VJ"; 
//			OraDB.Parameter_Values[1] = "VJI" + dtp_In.Text.Replace("-","").Replace("/","") + _Inseq.ToString().PadLeft(3,'0').ToString(); 
			OraDB.Parameter_Values[1] = "VJI" + dtp_In.Value.ToString("yyyyMMdd").Replace("-","").Replace("/","") + _Inseq.ToString().PadLeft(3,'0').ToString(); 
			OraDB.Parameter_Values[2] = _Inseq.ToString().PadLeft(3,'0').ToString();  //pur_seq
			OraDB.Parameter_Values[3] = _mold; 
			_usesize = _size.ToString().Split(_determid);
			OraDB.Parameter_Values[4] = _usesize[0];  //get the use size
			OraDB.Parameter_Values[5] = _moldseq;   			
			OraDB.Parameter_Values[6] = "1";
			OraDB.Parameter_Values[7] = "1";
			OraDB.Parameter_Values[8] = cbo_wh.SelectedValue.ToString();			
			OraDB.Parameter_Values[9] = "" ;			// PUR_NO
			OraDB.Parameter_Values[10] = _ord ; 
			OraDB.Parameter_Values[11] = cbo_In_type.SelectedValue.ToString(); // IO_TYPE 
			OraDB.Parameter_Values[12] = "";
			OraDB.Parameter_Values[13] = ""; 
			OraDB.Parameter_Values[14] = COM.ComVar.This_User; 
			OraDB.Parameter_Values[15] = ""; 

			OraDB.Add_Modify_Parameter(true); 
			OraDB.Exe_Modify_Procedure();
		}

		private void fgrid_main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_main.RowSel>0)
			{
				ClassLib.ComVar._startmouse = fgrid_main.RowSel;
			}
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_main.RowSel >0)
			{
				if (ClassLib.ComVar._startmouse > 0)
				{
					ClassLib.ComVar._endmouse = fgrid_main.RowSel;
					init_mold_order(ClassLib.ComVar._startmouse,ClassLib.ComVar._endmouse, fgrid_main.ColSel);
				}
			}
		}
		private void init_mold_order(int _start, int _end, int _col)
		{
			if (_end >= _start)
			{
				for (int i = _start; i <= _end; i++)
				{
					if(fgrid_main[i,_col] != null &&  fgrid_main[i,_col]!="")
					{
						if(fgrid_main[i,_col].ToString() == "O")
						{
							fgrid_main[i,_col] = "I";
						}
						else if(fgrid_main[i,_col].ToString() == "I" )
							fgrid_main[i,_col] = "O";
						else 
						{
							fgrid_main[i,_col] = "";
						} 
					}	//fgrid_main.fo
				}
			}
		}
		private DataTable Select_mold()
		{
			string Proc_Name = "PKG_SDT_MOLD.SELECT_MOLD_CD";
			
			OraDB.ReDim_Parameter(4); 

			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_PUR_YMD";
			OraDB.Parameter_Name[2]  = "ARG_PUR_NO";
			OraDB.Parameter_Name[3]  = "OUT_CURSOR";
 
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString();
//			OraDB.Parameter_Values[1] = dtp_PO_date.Text.Replace("-","").Replace("/","");
			OraDB.Parameter_Values[1] = dtp_PO_date.Value.ToString("yyyyMMdd").Replace("-","").Replace("/","");
			OraDB.Parameter_Values[2] = cbo_PO_nu.Text.ToString();
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);

			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		private void fgrid_size_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{	
			for (int i = 2 ; i < fgrid_size.Cols.Count -2 ; i++)
			{
				fgrid_size.Cols[i].AllowEditing = false;
//			if ((e.KeyChar == 'I'|| e.KeyChar == 'i')&& (fgrid_size.ColSel > 1))
//			{
//				fgrid_size[fgrid_size.RowSel,fgrid_size.ColSel] = (Keys.I);
//				fgrid_size.GetCellStyleDisplay(fgrid_size.RowSel,fgrid_size.ColSel).ForeColor  = Color.Blue;			
////					fgrid_size.GetCellStyleDisplay(fgrid_size.RowSel,fgrid_size.ColSel).BackColor  = Color.Blue;
			}
		}

		private void fgrid_size_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_main.RowSel>0)
			{
				ClassLib.ComVar._startmouse = fgrid_size.RowSel;
			}
		}

		private void fgrid_size_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ((fgrid_size.RowSel > 0 )&& (fgrid_size.ColSel >= 1 ))
			{
				if( fgrid_size.ColSel > 1)
				{
					if (ClassLib.ComVar._startmouse > 0)
					{
						ClassLib.ComVar._endmouse = fgrid_size.RowSel;
						init_mold_order_size(ClassLib.ComVar._startmouse,ClassLib.ComVar._endmouse, fgrid_size.ColSel);
					}
				}
				else
				{
					if (ClassLib.ComVar._startmouse > 0)
					{
						ClassLib.ComVar._endmouse = fgrid_size.RowSel;
						init_mold_order_seq(ClassLib.ComVar._startmouse,ClassLib.ComVar._endmouse, fgrid_size.ColSel);
					}
				}
			}
		}
		private void init_mold_order_size(int _start, int _end, int _col)
		{
			if (_end >= _start)
			{
				for (int i = _start; i <= _end; i++)
				{
						if(fgrid_size[i,_col]== "" || fgrid_size[i,_col] == null)
							fgrid_size[i,_col] = "I";
						else if (fgrid_size[i,_col].ToString()== "G" )
							fgrid_size[i,_col] = "I";
						else if (fgrid_size[i,_col].ToString()== "O" )
							fgrid_size[i,_col] = "I";
					    else
							fgrid_size[i,_col] = "";
				}
			}
		}

		private void init_mold_order_seq(int _start, int _end, int _col)
		{
			//_start = _start -2;
			int l =0;
			char f,s;
			if (_end >= _start)
			{
				for (int i = _start; i <= _end; i++)
				{
					if(i > 27)
					{
						f = (char)(65);
						s = (char)(65+l);
						fgrid_size[i,1] = f.ToString() + s.ToString(); //(char)(65) + (char)(65+l);
						fgrid_size[i,0] = i - 1;
						l++;
					}
					else
					{
						fgrid_size[i,1] = (char)(65+i-2);
						fgrid_size[i,0] = i - 1;
					}
				}
			}
		}

		private void fgrid_size_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}

