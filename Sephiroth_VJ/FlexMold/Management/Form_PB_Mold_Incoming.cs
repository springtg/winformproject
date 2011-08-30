using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexAPS.ProdPlan
{
	public class Form_PB_Mold_Incoming : COM.APSWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtp_income;
		private System.Windows.Forms.Label label8;
		public COM.FSP fgrid_main;
		private System.Windows.Forms.Label label12;
		private C1.Win.C1List.C1Combo cbo_warehouse;
		private System.ComponentModel.IContainer components = null;
		public COM.FSP fgrid_head;
		private C1.Win.C1List.C1Combo cbo_wh;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker dtp_order_to;
		private System.Windows.Forms.DateTimePicker dtp_order_from;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private C1.Win.C1List.C1Combo cbo_Incom_no;
		private C1.Win.C1List.C1Combo cbo_Incom_type;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private C1.Win.C1List.C1Combo cbo_Purchase;
		private System.Windows.Forms.Panel panelUPS;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton rBtn_P;
		private System.Windows.Forms.RadioButton rBtn_I;
		private System.Windows.Forms.TextBox txtBox_Cust;
		private System.Windows.Forms.TextBox txtMold_CD;
		public COM.FSP fgrid_size;
		private System.Windows.Forms.RadioButton rBtn_O;
		private System.Windows.Forms.Label label9;
		private C1.Win.C1List.C1Combo cbo_Out;
		
		private COM.OraDB OraDB = new COM.OraDB();
//		private COM.OraDB oraDB = null;

		public Form_PB_Mold_Incoming()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Incoming));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtMold_CD = new System.Windows.Forms.TextBox();
			this.panelUPS = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.rBtn_O = new System.Windows.Forms.RadioButton();
			this.label14 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.rBtn_P = new System.Windows.Forms.RadioButton();
			this.rBtn_I = new System.Windows.Forms.RadioButton();
			this.cbo_Purchase = new C1.Win.C1List.C1Combo();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbo_Incom_type = new C1.Win.C1List.C1Combo();
			this.cbo_Incom_no = new C1.Win.C1List.C1Combo();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtp_order_from = new System.Windows.Forms.DateTimePicker();
			this.dtp_order_to = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.cbo_wh = new C1.Win.C1List.C1Combo();
			this.label12 = new System.Windows.Forms.Label();
			this.txtBox_Cust = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dtp_income = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.cbo_warehouse = new C1.Win.C1List.C1Combo();
			this.fgrid_main = new COM.FSP();
			this.fgrid_head = new COM.FSP();
			this.fgrid_size = new COM.FSP();
			this.cbo_Out = new C1.Win.C1List.C1Combo();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panelUPS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Purchase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Incom_type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Incom_no)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_warehouse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_head)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Out)).BeginInit();
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
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
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
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.cbo_Out);
			this.panel1.Controls.Add(this.txtMold_CD);
			this.panel1.Controls.Add(this.panelUPS);
			this.panel1.Controls.Add(this.cbo_Purchase);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.cbo_Incom_type);
			this.panel1.Controls.Add(this.cbo_Incom_no);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dtp_order_from);
			this.panel1.Controls.Add(this.dtp_order_to);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.cbo_wh);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.txtBox_Cust);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.dtp_income);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.cbo_factory);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 64);
			this.panel1.TabIndex = 28;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// txtMold_CD
			// 
			this.txtMold_CD.Location = new System.Drawing.Point(552, 32);
			this.txtMold_CD.Name = "txtMold_CD";
			this.txtMold_CD.Size = new System.Drawing.Size(72, 22);
			this.txtMold_CD.TabIndex = 73;
			this.txtMold_CD.Text = "";
			this.txtMold_CD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMold_CD_KeyUp);
			// 
			// panelUPS
			// 
			this.panelUPS.BackColor = System.Drawing.Color.Transparent;
			this.panelUPS.Controls.Add(this.label9);
			this.panelUPS.Controls.Add(this.rBtn_O);
			this.panelUPS.Controls.Add(this.label14);
			this.panelUPS.Controls.Add(this.label7);
			this.panelUPS.Controls.Add(this.rBtn_P);
			this.panelUPS.Controls.Add(this.rBtn_I);
			this.panelUPS.Location = new System.Drawing.Point(696, 32);
			this.panelUPS.Name = "panelUPS";
			this.panelUPS.Size = new System.Drawing.Size(120, 27);
			this.panelUPS.TabIndex = 72;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Blue;
			this.label9.Location = new System.Drawing.Point(78, 5);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(16, 16);
			this.label9.TabIndex = 5;
			this.label9.Text = "O";
			// 
			// rBtn_O
			// 
			this.rBtn_O.Location = new System.Drawing.Point(99, 7);
			this.rBtn_O.Name = "rBtn_O";
			this.rBtn_O.Size = new System.Drawing.Size(17, 16);
			this.rBtn_O.TabIndex = 4;
			this.rBtn_O.Click += new System.EventHandler(this.rBtn_O_Click);
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Blue;
			this.label14.Location = new System.Drawing.Point(6, 5);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(16, 16);
			this.label14.TabIndex = 3;
			this.label14.Text = "I";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(40, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 16);
			this.label7.TabIndex = 2;
			this.label7.Text = "P";
			// 
			// rBtn_P
			// 
			this.rBtn_P.Location = new System.Drawing.Point(59, 7);
			this.rBtn_P.Name = "rBtn_P";
			this.rBtn_P.Size = new System.Drawing.Size(17, 16);
			this.rBtn_P.TabIndex = 1;
			this.rBtn_P.Click += new System.EventHandler(this.rBtn_P_Click);
			// 
			// rBtn_I
			// 
			this.rBtn_I.Location = new System.Drawing.Point(22, 7);
			this.rBtn_I.Name = "rBtn_I";
			this.rBtn_I.Size = new System.Drawing.Size(16, 15);
			this.rBtn_I.TabIndex = 0;
			this.rBtn_I.Click += new System.EventHandler(this.rBtn_I_Click);
			// 
			// cbo_Purchase
			// 
			this.cbo_Purchase.AddItemCols = 0;
			this.cbo_Purchase.AddItemSeparator = ';';
			this.cbo_Purchase.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_Purchase.Caption = "";
			this.cbo_Purchase.CaptionHeight = 17;
			this.cbo_Purchase.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_Purchase.ColumnCaptionHeight = 17;
			this.cbo_Purchase.ColumnFooterHeight = 17;
			this.cbo_Purchase.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_Purchase.ContentHeight = 17;
			this.cbo_Purchase.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_Purchase.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_Purchase.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Purchase.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_Purchase.EditorHeight = 17;
			this.cbo_Purchase.GapHeight = 2;
			this.cbo_Purchase.ItemHeight = 15;
			this.cbo_Purchase.Location = new System.Drawing.Point(552, 33);
			this.cbo_Purchase.MatchEntryTimeout = ((long)(2000));
			this.cbo_Purchase.MaxDropDownItems = ((short)(5));
			this.cbo_Purchase.MaxLength = 32767;
			this.cbo_Purchase.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_Purchase.Name = "cbo_Purchase";
			this.cbo_Purchase.PartialRightColumn = false;
			this.cbo_Purchase.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
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
			this.cbo_Purchase.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_Purchase.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_Purchase.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_Purchase.Size = new System.Drawing.Size(144, 23);
			this.cbo_Purchase.TabIndex = 71;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(464, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 21);
			this.label6.TabIndex = 70;
			this.label6.Text = "Purchase No";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(206, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 21);
			this.label4.TabIndex = 69;
			this.label4.Text = "Incoming type";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbo_Incom_type
			// 
			this.cbo_Incom_type.AddItemCols = 0;
			this.cbo_Incom_type.AddItemSeparator = ';';
			this.cbo_Incom_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_Incom_type.Caption = "";
			this.cbo_Incom_type.CaptionHeight = 17;
			this.cbo_Incom_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_Incom_type.ColumnCaptionHeight = 17;
			this.cbo_Incom_type.ColumnFooterHeight = 17;
			this.cbo_Incom_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_Incom_type.ContentHeight = 17;
			this.cbo_Incom_type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_Incom_type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_Incom_type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Incom_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_Incom_type.EditorHeight = 17;
			this.cbo_Incom_type.GapHeight = 2;
			this.cbo_Incom_type.ItemHeight = 15;
			this.cbo_Incom_type.Location = new System.Drawing.Point(314, 33);
			this.cbo_Incom_type.MatchEntryTimeout = ((long)(2000));
			this.cbo_Incom_type.MaxDropDownItems = ((short)(5));
			this.cbo_Incom_type.MaxLength = 32767;
			this.cbo_Incom_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_Incom_type.Name = "cbo_Incom_type";
			this.cbo_Incom_type.PartialRightColumn = false;
			this.cbo_Incom_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
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
			this.cbo_Incom_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_Incom_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_Incom_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_Incom_type.Size = new System.Drawing.Size(142, 23);
			this.cbo_Incom_type.TabIndex = 68;
			this.cbo_Incom_type.SelectedValueChanged += new System.EventHandler(this.cbo_Incom_type_SelectedValueChanged);
			// 
			// cbo_Incom_no
			// 
			this.cbo_Incom_no.AddItemCols = 0;
			this.cbo_Incom_no.AddItemSeparator = ';';
			this.cbo_Incom_no.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_Incom_no.Caption = "";
			this.cbo_Incom_no.CaptionHeight = 17;
			this.cbo_Incom_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_Incom_no.ColumnCaptionHeight = 17;
			this.cbo_Incom_no.ColumnFooterHeight = 17;
			this.cbo_Incom_no.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_Incom_no.ContentHeight = 17;
			this.cbo_Incom_no.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_Incom_no.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_Incom_no.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Incom_no.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_Incom_no.EditorHeight = 17;
			this.cbo_Incom_no.GapHeight = 2;
			this.cbo_Incom_no.ItemHeight = 15;
			this.cbo_Incom_no.Location = new System.Drawing.Point(314, 5);
			this.cbo_Incom_no.MatchEntryTimeout = ((long)(2000));
			this.cbo_Incom_no.MaxDropDownItems = ((short)(5));
			this.cbo_Incom_no.MaxLength = 32767;
			this.cbo_Incom_no.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_Incom_no.Name = "cbo_Incom_no";
			this.cbo_Incom_no.PartialRightColumn = false;
			this.cbo_Incom_no.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
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
			this.cbo_Incom_no.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_Incom_no.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_Incom_no.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_Incom_no.Size = new System.Drawing.Size(142, 23);
			this.cbo_Incom_no.TabIndex = 67;
			this.cbo_Incom_no.SelectedValueChanged += new System.EventHandler(this.cbo_Incom_no_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(206, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 21);
			this.label3.TabIndex = 66;
			this.label3.Text = "Incoming No";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(664, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 16);
			this.label2.TabIndex = 65;
			this.label2.Text = "~";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtp_order_from
			// 
			this.dtp_order_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_order_from.Location = new System.Drawing.Point(552, 7);
			this.dtp_order_from.Name = "dtp_order_from";
			this.dtp_order_from.Size = new System.Drawing.Size(104, 22);
			this.dtp_order_from.TabIndex = 64;
			// 
			// dtp_order_to
			// 
			this.dtp_order_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_order_to.Location = new System.Drawing.Point(696, 7);
			this.dtp_order_to.Name = "dtp_order_to";
			this.dtp_order_to.Size = new System.Drawing.Size(104, 22);
			this.dtp_order_to.TabIndex = 63;
			this.dtp_order_to.ValueChanged += new System.EventHandler(this.dtp_order_to_ValueChanged);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(464, 8);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(88, 21);
			this.label13.TabIndex = 62;
			this.label13.Text = "Order Date";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cbo_wh.Location = new System.Drawing.Point(896, 6);
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
			this.cbo_wh.Size = new System.Drawing.Size(112, 23);
			this.cbo_wh.TabIndex = 61;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(808, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 21);
			this.label12.TabIndex = 59;
			this.label12.Text = "Warehouse";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtBox_Cust
			// 
			this.txtBox_Cust.Location = new System.Drawing.Point(896, 33);
			this.txtBox_Cust.Name = "txtBox_Cust";
			this.txtBox_Cust.Size = new System.Drawing.Size(112, 22);
			this.txtBox_Cust.TabIndex = 1;
			this.txtBox_Cust.Text = "";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(817, 35);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 21);
			this.label8.TabIndex = 50;
			this.label8.Text = "Customer";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtp_income
			// 
			this.dtp_income.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_income.Location = new System.Drawing.Point(96, 34);
			this.dtp_income.Name = "dtp_income";
			this.dtp_income.Size = new System.Drawing.Size(104, 22);
			this.dtp_income.TabIndex = 44;
			this.dtp_income.ValueChanged += new System.EventHandler(this.dtp_income_ValueChanged);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(8, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 21);
			this.label5.TabIndex = 43;
			this.label5.Text = "In_Date";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cbo_factory.ContentHeight = 17;
			this.cbo_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_factory.EditorHeight = 17;
			this.cbo_factory.Enabled = false;
			this.cbo_factory.GapHeight = 2;
			this.cbo_factory.ItemHeight = 15;
			this.cbo_factory.Location = new System.Drawing.Point(96, 5);
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
			this.cbo_factory.Size = new System.Drawing.Size(72, 23);
			this.cbo_factory.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Factory";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbo_warehouse
			// 
			this.cbo_warehouse.AddItemCols = 0;
			this.cbo_warehouse.AddItemSeparator = ';';
			this.cbo_warehouse.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_warehouse.Caption = "";
			this.cbo_warehouse.CaptionHeight = 17;
			this.cbo_warehouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_warehouse.ColumnCaptionHeight = 17;
			this.cbo_warehouse.ColumnFooterHeight = 17;
			this.cbo_warehouse.ContentHeight = 15;
			this.cbo_warehouse.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_warehouse.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_warehouse.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_warehouse.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_warehouse.EditorHeight = 15;
			this.cbo_warehouse.GapHeight = 2;
			this.cbo_warehouse.ItemHeight = 15;
			this.cbo_warehouse.Location = new System.Drawing.Point(0, 0);
			this.cbo_warehouse.MatchEntryTimeout = ((long)(2000));
			this.cbo_warehouse.MaxDropDownItems = ((short)(5));
			this.cbo_warehouse.MaxLength = 32767;
			this.cbo_warehouse.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_warehouse.Name = "cbo_warehouse";
			this.cbo_warehouse.PartialRightColumn = false;
			this.cbo_warehouse.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
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
			this.cbo_warehouse.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_warehouse.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_warehouse.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_warehouse.TabIndex = 0;
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
			this.fgrid_main.Location = new System.Drawing.Point(0, 328);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 28;
			this.fgrid_main.Rows.Fixed = 2;
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.fgrid_main.Size = new System.Drawing.Size(1016, 336);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:Transparent;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 48;
			this.fgrid_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseDown);
			this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
			// 
			// fgrid_head
			// 
			this.fgrid_head.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_head.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_head.BackColor = System.Drawing.Color.Transparent;
			this.fgrid_head.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_head.ColumnInfo = "15,1,0,0,0,75,Columns:0{Width:29;}\t";
			this.fgrid_head.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_head.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_head.Location = new System.Drawing.Point(0, 128);
			this.fgrid_head.Name = "fgrid_head";
			this.fgrid_head.Rows.Count = 26;
			this.fgrid_head.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_head.Size = new System.Drawing.Size(1016, 192);
			this.fgrid_head.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;BackColor:Transparent;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_head.TabIndex = 49;
			this.fgrid_head.Click += new System.EventHandler(this.fgrid_head_Click);
			// 
			// fgrid_size
			// 
			this.fgrid_size.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_size.AllowEditing = false;
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
			this.fgrid_size.Location = new System.Drawing.Point(0, 128);
			this.fgrid_size.Name = "fgrid_size";
			this.fgrid_size.Rows.Count = 28;
			this.fgrid_size.Rows.Fixed = 2;
			this.fgrid_size.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.fgrid_size.Size = new System.Drawing.Size(992, 504);
			this.fgrid_size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:Transparent;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_size.TabIndex = 50;
			this.fgrid_size.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_size_MouseDown);
			this.fgrid_size.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_size_MouseUp);
			// 
			// cbo_Out
			// 
			this.cbo_Out.AddItemCols = 0;
			this.cbo_Out.AddItemSeparator = ';';
			this.cbo_Out.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_Out.Caption = "";
			this.cbo_Out.CaptionHeight = 17;
			this.cbo_Out.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_Out.ColumnCaptionHeight = 17;
			this.cbo_Out.ColumnFooterHeight = 17;
			this.cbo_Out.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_Out.ContentHeight = 17;
			this.cbo_Out.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_Out.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_Out.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Out.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_Out.EditorHeight = 17;
			this.cbo_Out.GapHeight = 2;
			this.cbo_Out.ItemHeight = 15;
			this.cbo_Out.Location = new System.Drawing.Point(552, 32);
			this.cbo_Out.MatchEntryTimeout = ((long)(2000));
			this.cbo_Out.MaxDropDownItems = ((short)(5));
			this.cbo_Out.MaxLength = 32767;
			this.cbo_Out.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_Out.Name = "cbo_Out";
			this.cbo_Out.PartialRightColumn = false;
			this.cbo_Out.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_Out.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_Out.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_Out.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_Out.Size = new System.Drawing.Size(120, 23);
			this.cbo_Out.TabIndex = 74;
			// 
			// Form_PB_Mold_Incoming
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_size);
			this.Controls.Add(this.fgrid_head);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.panel1);
			this.Name = "Form_PB_Mold_Incoming";
			this.Load += new System.EventHandler(this.Form_PB_Model_Incoming_Load);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			this.Controls.SetChildIndex(this.fgrid_head, 0);
			this.Controls.SetChildIndex(this.fgrid_size, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panelUPS.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_Purchase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Incom_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Incom_no)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_warehouse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_head)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Out)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Model_Incoming_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			Init_Form_Tail();
		}
		private void Init_Form()
		{
			//this.Text = "PCC_Mold Master";
			rBtn_P.Checked = false;
			rBtn_I.Checked = false;
			rBtn_O.Checked = false;
			txtMold_CD.Visible = false;
			cbo_Out.Visible = false ;
			fgrid_size.Visible = false;
			cbo_factory.Text = "VJ";
			this.lbl_MainTitle.Text = "PCC_Mold Income";
			ClassLib.ComFunction.SetLangDic(this);
		
			fgrid_head.Set_Grid("SDT_MOLD_INCOME_HEAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_head.Set_Action_Image(img_Action);
			//_RowFixed_desc = fgrip_main.Rows.Fixed;
			fgrid_head.ExtendLastCol = false;
			//fgrip_main.AutoSizeCols();
 
			DataTable dt_ret = Select_com_filter_code_List("SDV07");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_Incom_type, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List("SDV15");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

			//Model_List();
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

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void dtp_income_ValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret = Select_Incoming_No();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_Incom_no, 0, 1, false, false);
		}
		private DataTable Select_Incoming_No()
		{
			string Proc_Name = "PKG_SDT_MOLD.SEARCH_IN_NO";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_IN_YMD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = dtp_income.Text.Replace("/","").Replace("-","");
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];

		}

		private void dtp_order_to_ValueChanged(object sender, System.EventArgs e)
		{
			cbo_Incom_no.Enabled =false ;
			cbo_Incom_no.Text = "";
			DataTable dt_ret = Select_Pur_No();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_Purchase, 0, 1, false, false);
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
			OraDB.Parameter_Values[1] = dtp_order_from.Text.Replace("/","").Replace("-","");
			OraDB.Parameter_Values[2] = dtp_order_to.Text.Replace("/","").Replace("-","");
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Seach_Main();

		}
		private void Seach_Main()
		{
			DataTable vDt1 = null;
			fgrid_head.Clear();
			fgrid_main.Clear();
//			if (cbo_Incom_no.Text == "")
			if (rBtn_P.Checked == true && cbo_Incom_type.SelectedValue.ToString() == "10")
				fgrid_head.Set_Grid("SDT_MOLD_INCOME_HEAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			else if (rBtn_I.Checked == true && cbo_Incom_type.SelectedValue.ToString() != "20")
				fgrid_head.Set_Grid("SDT_MOLD_INCOME_HEAD1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			else if (cbo_Incom_type.SelectedValue.ToString() == "20")
				fgrid_head.Set_Grid("SDT_MOLD_INCOME_HEAD1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			else
			{
				MessageBox.Show("Please choose I or P.");
				return;
			}
			try
			{
				vDt1 = SELECT_MOLD_MAIN();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_head.AddItem(vDt1.Rows[i].ItemArray, fgrid_head.Rows.Count, 1);						
					}

				}
				else            
				{
					MessageBox.Show("No Data !!");
					return;
				}
			}
			catch
			{

			}
		}

		private System.Data.DataTable SELECT_MOLD_MAIN()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_PUR_HEAD";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_PUR_YMD_FR";
			OraDB.Parameter_Name[2] = "ARG_PUR_YMD_TO";
			OraDB.Parameter_Name[3] = "ARG_PUR_NU";
			OraDB.Parameter_Name[4] = "ARG_DIVISION";
			OraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString()  ;
			OraDB.Parameter_Values[1] = dtp_order_from.Text.ToString().Replace("/","").Replace("-","");
//			if (cbo_Incom_no.Text == "")
//			if (rBtn_P.Checked == true)
			if (rBtn_P.Checked == true && cbo_Incom_type.SelectedValue.ToString() == "10")
			{
				OraDB.Parameter_Values[2] = dtp_order_to.Text.ToString().Replace("/","").Replace("-","");
				OraDB.Parameter_Values[3] = cbo_Purchase.Text.ToString();
				OraDB.Parameter_Values[4] = "1";

			}
				//			else
			else if (rBtn_I.Checked == true && cbo_Incom_type.SelectedValue.ToString() != "20")
			{
				OraDB.Parameter_Values[2] = dtp_income.Text.ToString().Replace("/","").Replace("-","");
				OraDB.Parameter_Values[3] = cbo_Incom_no.Text.ToString();
				OraDB.Parameter_Values[4] = "2";
			}
			else
			{
				OraDB.Parameter_Values[2] = dtp_income.Text.ToString().Replace("/","").Replace("-","");
				OraDB.Parameter_Values[3] = cbo_Out.Text.ToString();
				OraDB.Parameter_Values[4] = "3";
			}
			OraDB.Parameter_Values[5] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

		private void fgrid_head_Click(object sender, System.EventArgs e)
		{
			if (fgrid_head.Rows.Count > 2) 
			{
//				if (rBtn_I.Checked == true && cbo_Purchase.Text == "")
				if (rBtn_I.Checked == true && cbo_Incom_type.SelectedValue.ToString() != "20")
				{
					for ( int k = 1; k < fgrid_head.Rows.Count ; k++)
						fgrid_head[k,0] = "" ; 
					fgrid_head[fgrid_head.RowSel,0] = "U" ; 
					cbo_Incom_type.SelectedValue = fgrid_head[fgrid_head.RowSel,10].ToString();
					cbo_wh.SelectedValue = fgrid_head[fgrid_head.RowSel,13].ToString();
				}
//				else if(rBtn_P.Checked == true && cbo_Incom_no.Text == "")
				else if (rBtn_P.Checked == true && cbo_Incom_type.SelectedValue.ToString() == "10")
				{
					for ( int t = 1; t < fgrid_head.Rows.Count ; t++)
						fgrid_head[t,0] = "" ; 
					fgrid_head[fgrid_head.RowSel,0] = "S" ;
				}
				else
				{
//					MessageBox.Show("Tho COn");
					for ( int t = 1; t < fgrid_head.Rows.Count ; t++)
						fgrid_head[t,0] = "" ; 
					fgrid_head[fgrid_head.RowSel,0] = "S" ;
				}
				fgrid_main.Clear();
				DisplaceDetail();				
			}
		}
		private void DisplaceDetail()
		{
			Search_Size();
			Search_Seq();
		}
		private void Search_Size()
		{
			System.Data.DataTable vDt = null;
			try
			{
				vDt = SELECT_MOLD_SIZE();    
				fgrid_main.Clear();    
				if(vDt.Rows.Count > 0)
				{
					for(int i = 0; i < vDt.Rows.Count ; i++)
					{
						fgrid_main.Cols.Count  = vDt.Rows.Count + 1 ; 						
						fgrid_main[0,i+1] = vDt.Rows[i].ItemArray[1].ToString() ;						
//						fgrid_main.Cols[i+1].Width = 60 ;
						fgrid_main.AutoSizeCols();
						fgrid_main.Cols[i+1].TextAlign = TextAlignEnum.CenterCenter;
						fgrid_main[1,i+1] = vDt.Rows[i].ItemArray[0].ToString();
					}
				}
				else
				{
					
				}
												
				Init_Form_Tail();
				vDt.Dispose();
			}
			finally
			{
				if (vDt != null) 
					vDt.Dispose();
			}	
		}
		private System.Data.DataTable SELECT_MOLD_SIZE()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_TAIL_SIZE";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_PUR_NU";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3] = "ARG_DIVISION";

			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
					
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString();
			OraDB.Parameter_Values[1] = fgrid_head[fgrid_head.RowSel,1].ToString();
			OraDB.Parameter_Values[2] = fgrid_head[fgrid_head.RowSel,2].ToString();
//			if (rBtn_P.Checked == true)
			if (rBtn_P.Checked == true && cbo_Incom_type.SelectedValue.ToString() == "10")
				OraDB.Parameter_Values[3] = "1";
			else if (rBtn_I.Checked == true && cbo_Incom_type.SelectedValue.ToString() != "20")
				OraDB.Parameter_Values[3] = "2";
			else
				OraDB.Parameter_Values[3] = "3";
			OraDB.Parameter_Values[4] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];

		}
		
		private void Search_Seq()
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
//									{
//										if (vDt.Rows[i].ItemArray[2].ToString()=="O")
											fgrid_main[j+2,k+1] = vDt.Rows[i].ItemArray[2].ToString();
										//										else
										//											fgrid_head.Rows[fgrid_head.RowSel].TextAlign =
//									}
//									else
//										fgrid_main[j+1,k+1] = "";
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
		}
		private System.Data.DataTable SELECT_MOLD_SEQ()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_TAIL_SEQ";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_PUR_NU";
			OraDB.Parameter_Name[2] = "ARG_DIVISION";

			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
					
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString();
			OraDB.Parameter_Values[1] = fgrid_head[fgrid_head.RowSel,1].ToString();
			
//			if (rBtn_P.Checked == true)
			if (rBtn_P.Checked == true && cbo_Incom_type.SelectedValue.ToString() == "10")
				OraDB.Parameter_Values[2] = "1";
			else if (rBtn_I.Checked == true && cbo_Incom_type.SelectedValue.ToString() != "20")
				OraDB.Parameter_Values[2] = "2";
			else
				OraDB.Parameter_Values[2] = "3";
			OraDB.Parameter_Values[3] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];

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
		private void fgrid_main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_main.RowSel>0)
			{
//				if (fgrid_main[fgrid_main.RowSel -1,fgrid_main.ColSel] == null || fgrid_main[fgrid_main.RowSel-1,fgrid_main.ColSel] =="")
//					ClassLib.ComVar._startmouse=0;
//				else
					ClassLib.ComVar._startmouse = fgrid_main.RowSel;
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
							//						mold_ord_count(_col);
//							mold_ord_sum();
						}
						else if(fgrid_main[i,_col].ToString() == "I" )
							fgrid_main[i,_col] = "O";
						else 
						{
							fgrid_main[i,_col] = "";
							//						mold_ord_count(_col);
//							mold_ord_sum();
						} 
					}	//fgrid_main.fo
				}
			}
		}
		private void mold_ord_sum()
		{
			int _msum =0;
			for(int j =1; j< fgrid_main.Cols.Count; j++)
			{
				for (int k = 2 ; k < fgrid_main.Rows.Count-2 ; k++)
				{
					if(fgrid_main[k,j] != null && fgrid_main[k,j] !="") 
					{
						if (fgrid_main[k,j] == "I")
//							_msum = _msum + System.Convert.ToInt32(fgrid_main[k,j].ToString());
							_msum = _msum + 1 ;
					}
				}
			}
			fgrid_head[fgrid_head.RowSel ,15] = _msum.ToString();
//			textBox3.Text = _msum.ToString();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			mold_ord_sum();
			if ((cbo_Incom_type.Text == null)||(cbo_wh.Text == ""))
				MessageBox.Show("Please input Incoming Type Or Warehourse");
			else
			{
				if (fgrid_head[fgrid_head.RowSel,0].ToString()=="S")
				{
					DataTable In_seq = Select_In_seq();
					save_mold_In_order(In_seq.Rows[0].ItemArray[0].ToString());
					save_mold_In_order_tail(In_seq.Rows[0].ItemArray[0].ToString());
				}
				else
				{
                   Update_mold_in_order_tail();
				}
			}
		    Seach_Main();	
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

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = dtp_income.Text.Replace("-","").Replace("/","");
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);

			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}
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
			OraDB.Parameter_Values[1] = dtp_income.Text.Replace("-","").Replace("/",""); 
			OraDB.Parameter_Values[2] = _seq.ToString().PadLeft(3,'0').ToString(); 
			OraDB.Parameter_Values[3] = fgrid_head[fgrid_head.RowSel,2].ToString (); //MOLD
			OraDB.Parameter_Values[4] = fgrid_head[fgrid_head.RowSel,15].ToString();  //TOT
			OraDB.Parameter_Values[5] = dtp_income.Text.Replace("-","").Replace("/",""); // Ngay Incoming
			OraDB.Parameter_Values[6] = cbo_Incom_type.SelectedValue.ToString(); 
			OraDB.Parameter_Values[7] = "";   //rta
			OraDB.Parameter_Values[8] = "";   //ets
			OraDB.Parameter_Values[9] = ""; 
			OraDB.Parameter_Values[10] = txtBox_Cust.Text.Trim();
			OraDB.Parameter_Values[11] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[12] = "";
			OraDB.Parameter_Values[13] = ""; 
			OraDB.Parameter_Values[14] = ""; 
			OraDB.Parameter_Values[15] = ClassLib.ComVar.This_User; 
			OraDB.Parameter_Values[16] = ""; 

			OraDB.Add_Modify_Parameter(true); 
			OraDB.Exe_Modify_Procedure();
		}
		
		private void save_mold_In_order_tail(string _seq)
		{
			//save pur_tail.
			for (int i = 0; i < fgrid_main.Cols.Count-1 ; i++)
			{
				for (int j= 0 ; j<fgrid_main.Rows.Count -2 ;j++)
				{
					if (fgrid_main[j+2,i+1]!= null && fgrid_main[j+2,i+1]!= "")
					{
						if ( fgrid_main[j+2,i+1]=="I")
						{
							save_mold_In_tail(_seq , fgrid_head[fgrid_head.RowSel,2].ToString(),
								fgrid_main[1,i+1].ToString(),fgrid_main[j+2,0].ToString(),
								fgrid_main[j+2,i+1].ToString());
						}
					}  
					else
					{
//						break;
					}
				}
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
			OraDB.Parameter_Name[12] = "ARG_SEND_CHK";
			OraDB.Parameter_Name[13] = "ARG_SEND_YMD";
			OraDB.Parameter_Name[14] = "ARG_UPD_USER";
			OraDB.Parameter_Name[15] = "ARG_UPD_YMD";

			for(int i=0; i< 15; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			OraDB.Parameter_Values[0] = "VJ"; 
			OraDB.Parameter_Values[1] = "VJI" + dtp_income.Text.Replace("-","").Replace("/","") + _Inseq.ToString().PadLeft(3,'0').ToString(); 
			OraDB.Parameter_Values[2] = _Inseq.ToString().PadLeft(3,'0').ToString();  //pur_seq
			OraDB.Parameter_Values[3] = _mold; 
			_usesize = _size.ToString().Split(_determid);
			OraDB.Parameter_Values[4] = _usesize[0];  //get the use size
			OraDB.Parameter_Values[5] = _moldseq;   			
			OraDB.Parameter_Values[6] = "1";
			OraDB.Parameter_Values[7] = "1";
			OraDB.Parameter_Values[8] = cbo_wh.SelectedValue.ToString();			
			OraDB.Parameter_Values[9] = fgrid_head[fgrid_head.RowSel,1].ToString();			
			OraDB.Parameter_Values[10] = _ord ; 
			OraDB.Parameter_Values[11] = ""; 
			OraDB.Parameter_Values[12] = "";
			OraDB.Parameter_Values[13] = ""; 
			OraDB.Parameter_Values[14] = ClassLib.ComVar.This_User; 
			OraDB.Parameter_Values[15] = ""; 

			OraDB.Add_Modify_Parameter(true); 
			OraDB.Exe_Modify_Procedure();
		}

		private void cbo_Incom_no_SelectedValueChanged(object sender, System.EventArgs e)
		{
//			if(cbo_Incom_no.Text != "" )
//			{
//				cbo_Purchase.Text = ""; cbo_Purchase.Enabled = false;
////				dtp_order_from.Text = "" ; dtp_order_from.Enabled = false;
//				dtp_order_to.Text = "" ; dtp_order_to.Enabled = false;
//			}
//			else
//			{
//				cbo_Purchase.Enabled = true ;
////				dtp_order_from.Enabled = true;	dtp_order_to.Enabled = true;
//			}
		}

		private void rBtn_I_Click(object sender, System.EventArgs e)
		{
			if (rBtn_I.Checked == true)
			{
				rBtn_P.Checked = false;
				cbo_Purchase.Enabled = false ;cbo_Purchase.Text = "";
				cbo_Incom_no.Enabled = true;
				fgrid_main.Clear();
				fgrid_head.Clear();
				fgrid_size.Visible = false;
				fgrid_main.Visible = true;
				fgrid_head.Visible = true;
				this.tbtn_Delete.Enabled = true ;
				txtMold_CD.Visible = false;
				txtMold_CD.Text = "";
				cbo_Incom_type.Text = "";
				cbo_Purchase.Visible = true;
				this.tbtn_Save.Enabled = false;
				this.tbtn_Search.Enabled = true ;	
				this.tbtn_Save.Enabled = false;
				this.tbtn_Append.Enabled = false ;
				
			}
			else
			{
				txtMold_CD.Visible = true;
				txtMold_CD.Text = "";
				cbo_Purchase.Visible = false;
				fgrid_size.Visible = true;
				fgrid_main.Visible = false;
				fgrid_head.Visible = false;
			}
			
		}

		private void rBtn_P_Click(object sender, System.EventArgs e)
		{	
			if (rBtn_P.Checked == true)
			{
				rBtn_I.Checked = false;
				cbo_Incom_no.Enabled = false ;cbo_Incom_no.Text = "";				
				cbo_Purchase.Enabled = true;
				label6.Text = "Purchase No" ;				
				fgrid_main.Clear();
				fgrid_head.Clear();
				cbo_Incom_type.SelectedValue = "10";
			   // FlexAPS.ClassLib.ComVar.
				fgrid_size.Visible = false;
				fgrid_main.Visible = true;
				fgrid_head.Visible = true;
				this.tbtn_Delete.Enabled = false ;
				txtMold_CD.Visible = false;
				txtMold_CD.Text = "";
				cbo_Purchase.Visible = true;
				this.tbtn_Save.Enabled = true;
				this.tbtn_Search.Enabled = true ;	
				this.tbtn_Append.Enabled = false ;
			}
			else
			{
				txtMold_CD.Visible = true;
				txtMold_CD.Text = "";
				cbo_Purchase.Visible = false;
				fgrid_size.Visible = true;
				fgrid_main.Visible = false;
				fgrid_head.Visible = false;
			}
		
		}
		private void Update_mold_in_order_tail()
		{
			for (int i = 0; i < fgrid_main.Cols.Count-1 ; i++)
			{
				for (int j= 0 ; j<fgrid_main.Rows.Count -2 ;j++)
				{
					if (fgrid_main[j+2,i+1]!= null && fgrid_main[j+2,i+1]!= "")
					{
						if ( fgrid_main[j+2,i+1].ToString().Trim()=="I")
						{
							Update_mold_In_tail(fgrid_head[fgrid_head.RowSel,1].ToString(),
								fgrid_head[fgrid_head.RowSel,2].ToString(),
								fgrid_main[1,i+1].ToString(),
								fgrid_main[j+2,0].ToString(),
								fgrid_main[j+2,i+1].ToString());
						}
						else if ( fgrid_main[j+2,i+1].ToString().Trim()=="O")
							update_mold_Pur(fgrid_head[fgrid_head.RowSel,11].ToString(),
								fgrid_head[fgrid_head.RowSel,2].ToString(),
								fgrid_main[1,i+1].ToString(),
								fgrid_main[j+2,0].ToString(),
								fgrid_main[j+2,i+1].ToString());
						else
						{
						}
					}  
					else
					{
						//						break;
					}
				}
			}
		}
	
		private void Update_mold_In_tail(string _Inseq,string _mold, string _size, string _moldseq, string _ord)
		{
			string process_name = "PKG_SDT_MOLD.UPDATE_MOLD_IN";
			string [] _usesize = null;
			char [] _determid ="/".ToCharArray();

			OraDB.ReDim_Parameter(17); 

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
			OraDB.Parameter_Name[16] = "ARG_TOTAL_QTY";

			for(int i=0; i< 16; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			OraDB.Parameter_Values[0] = "VJ"; 
			OraDB.Parameter_Values[1] = _Inseq ; 
			OraDB.Parameter_Values[2] = "";  //pur_seq
			OraDB.Parameter_Values[3] = _mold; 
			_usesize = _size.ToString().Split(_determid);
			OraDB.Parameter_Values[4] = _usesize[0];  //get the use size
			OraDB.Parameter_Values[5] = _moldseq;   			
			OraDB.Parameter_Values[6] = "1";
			OraDB.Parameter_Values[7] = "1";
			OraDB.Parameter_Values[8] = cbo_wh.SelectedValue.ToString();			
			OraDB.Parameter_Values[9] = fgrid_head[fgrid_head.RowSel,11].ToString();			
			OraDB.Parameter_Values[10] = _ord ; 
			OraDB.Parameter_Values[11] = ""; 
			OraDB.Parameter_Values[12] = "";
			OraDB.Parameter_Values[13] = ""; 
			OraDB.Parameter_Values[14] = "";
			OraDB.Parameter_Values[15] = ""; 
			OraDB.Parameter_Values[16] = fgrid_head[fgrid_head.RowSel,15].ToString();			

			OraDB.Add_Modify_Parameter(true); 
			OraDB.Exe_Modify_Procedure();
		}
		
		private void update_mold_Pur(string _Inseq,string _mold, string _size, string _moldseq, string _ord)
		{
			string process_name = "PKG_SDT_MOLD.UPDATE_MOLD_PUR";
			string [] _usesize = null;
			char [] _determid ="/".ToCharArray();

			OraDB.ReDim_Parameter(8); 

			OraDB.Process_Name = process_name;

			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_PUR_NO"; //ARG_SPEC_CD
			OraDB.Parameter_Name[2]  = "ARG_PUR_SEQ";
			OraDB.Parameter_Name[3]  = "ARG_MOLD_CD";
			OraDB.Parameter_Name[4]  = "ARG_USE_SIZE";
			OraDB.Parameter_Name[5]  = "ARG_SEQ_NO";
			OraDB.Parameter_Name[6]  = "ARG_PUR_STATUS";
			OraDB.Parameter_Name[7]  = "ARG_IN_NO";

			for(int i=0; i< 7; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			OraDB.Parameter_Values[0] = "VJ"; 
			OraDB.Parameter_Values[1] = _Inseq ; 
			OraDB.Parameter_Values[2] = "";  //pur_seq
			OraDB.Parameter_Values[3] = _mold; 
			_usesize = _size.ToString().Split(_determid);
			OraDB.Parameter_Values[4] = _usesize[0];  //get the use size
			OraDB.Parameter_Values[5] = _moldseq;
   			OraDB.Parameter_Values[6] = _ord ; 
			OraDB.Parameter_Values[7] = fgrid_head[fgrid_head.RowSel,1].ToString() ; 

			OraDB.Add_Modify_Parameter(true); 
			OraDB.Exe_Modify_Procedure();
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Delete_mold_in();
			Seach_Main();
		}
		private void Delete_mold_in()
		{
			for (int i = 0; i < fgrid_main.Cols.Count-1 ; i++)
			{
				for (int j= 0 ; j<fgrid_main.Rows.Count -2 ;j++)
				{
					if (fgrid_main[j+2,i+1]!= null && fgrid_main[j+2,i+1]!= "")
					{
						if ( fgrid_main[j+2,i+1].ToString().Trim()=="I")
						{
							Delete_Mold_In(fgrid_head[fgrid_head.RowSel,11].ToString(),
								fgrid_head[fgrid_head.RowSel,2].ToString(),
								fgrid_main[1,i+1].ToString(),
								fgrid_main[j+2,0].ToString(),
								fgrid_main[j+2,i+1].ToString());
						}
//						else if ( fgrid_main[j+2,i+1].ToString().Trim()=="O")
//							update_mold_Pur(fgrid_head[fgrid_head.RowSel,11].ToString(),
//								fgrid_head[fgrid_head.RowSel,2].ToString(),
//								fgrid_main[1,i+1].ToString(),
//								fgrid_main[j+2,0].ToString(),
//								fgrid_main[j+2,i+1].ToString());
//						else
//						{
//						}
					}  
					else
					{
						//						break;
					}
				}
			}
		}

		private void Delete_Mold_In(string _Inseq,string _mold, string _size, string _moldseq, string _ord)
		{
			string process_name = "PKG_SDT_MOLD.DELETE_MOLD_IN";
			string [] _usesize = null;
			char [] _determid ="/".ToCharArray();

			OraDB.ReDim_Parameter(8); 

			OraDB.Process_Name = process_name;

			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_PUR_NO"; //ARG_SPEC_CD
			OraDB.Parameter_Name[2]  = "ARG_IN_SEQ";
			OraDB.Parameter_Name[3]  = "ARG_MOLD_CD";
			OraDB.Parameter_Name[4]  = "ARG_USE_SIZE";
			OraDB.Parameter_Name[5]  = "ARG_SEQ_NO";
			OraDB.Parameter_Name[6]  = "ARG_PUR_STATUS";
			OraDB.Parameter_Name[7]  = "ARG_IN_NO";

			for(int i=0; i< 7; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			OraDB.Parameter_Values[0] = "VJ"; 
			OraDB.Parameter_Values[1] = _Inseq ; 
			OraDB.Parameter_Values[2] = "";  //pur_seq
			OraDB.Parameter_Values[3] = _mold; 
			_usesize = _size.ToString().Split(_determid);
			OraDB.Parameter_Values[4] = _usesize[0];  //get the use size
			OraDB.Parameter_Values[5] = _moldseq;
			OraDB.Parameter_Values[6] = _ord ; 
			OraDB.Parameter_Values[7] = fgrid_head[fgrid_head.RowSel,1].ToString() ; 

			OraDB.Add_Modify_Parameter(true); 
			OraDB.Exe_Modify_Procedure();
		}

		private void cbo_Incom_type_SelectedValueChanged(object sender, System.EventArgs e)
		{			
			if (cbo_Incom_type.SelectedValue.ToString() == "20")
			{
				label6.Text = "Outgoing No";
				cbo_Out.Visible = true;
				cbo_Purchase.Visible = false ;
				txtMold_CD.Visible = false ;
				txtMold_CD.Text = "";
				fgrid_size.Visible = false;
				fgrid_main.Visible = true;
				fgrid_head.Visible = true;
				DataTable dt_ret = Select_Outgoing();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_Out, 0, 1, false, false);
			}
			else if (cbo_Incom_type.SelectedValue.ToString() == "10")
			{
				label6.Text = "Purchase No";
				cbo_Out.Visible = false;
				cbo_Purchase.Visible = true ;
				txtMold_CD.Visible = false ;
				fgrid_size.Visible = false;
				fgrid_main.Visible = true;
				fgrid_head.Visible = true;
			}
			else
			{	
				label6.Text = "Mold Code";
				cbo_Out.Visible = false;
				cbo_Purchase.Visible = false ;
				txtMold_CD.Visible = true ;
				fgrid_size.Visible = true;
				fgrid_main.Visible = false;
				fgrid_head.Visible = false;

			}
		}

		private void txtMold_CD_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{	
			if (e.KeyData == Keys.Enter )
			{
//				Init_Form_Tail1();
				select();		
				Init_Form_Tail1();
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
						fgrid_size.Cols.Count  = vDt.Rows.Count + 1 ; 						
						fgrid_size[0,i+1] = vDt.Rows[i].ItemArray[1].ToString() ;						
						//						fgrid_main.Cols[i+1].Width = 60 ;
						fgrid_size.AutoSizeCols();
						fgrid_size.Cols[i+1].TextAlign = TextAlignEnum.CenterCenter;
						fgrid_size[1,i+1] = vDt.Rows[i].ItemArray[0].ToString();
					}
				}
				else
				{
					
				}
												
				Init_Form_Tail();
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
			OraDB.Parameter_Values[1] = txtMold_CD.Text.Trim();
			
			OraDB.Parameter_Values[2] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];

		}

		private void fgrid_size_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_size.RowSel>0)
			{
				//				if (fgrid_main[fgrid_main.RowSel -1,fgrid_main.ColSel] == null || fgrid_main[fgrid_main.RowSel-1,fgrid_main.ColSel] =="")
				//					ClassLib.ComVar._startmouse=0;
				//				else
				ClassLib.ComVar._startmouse = fgrid_size.RowSel;
			}
		
		}

		private void fgrid_size_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_size.RowSel >0)
			{
				if (ClassLib.ComVar._startmouse > 0)
				{
					ClassLib.ComVar._endmouse = fgrid_size.RowSel;
					init_mold_order1(ClassLib.ComVar._startmouse,ClassLib.ComVar._endmouse, fgrid_size.ColSel);
				}
			}		
		}
		private void init_mold_order1(int _start, int _end, int _col)
		{
			if (_end >= _start)
			{
				for (int i = _start; i <= _end; i++)
				{
					if(fgrid_size[i,_col] == null ||  fgrid_size[i,_col] == "")
//					{
//						if(fgrid_size[i,_col].ToString() == "O")
//						{
							fgrid_size[i,_col] = "I";
//						}
//						else if(fgrid_size[i,_col].ToString() == "I" )
//							fgrid_size[i,_col] = "O";
					 else 
						{
							fgrid_size[i,_col] = "";
								
						} 
						
				}
			}
		}

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable In_seq = Select_In_seq();
			save_mold_In_order1(In_seq.Rows[0].ItemArray[0].ToString());
			save_mold_In_order_tail1(In_seq.Rows[0].ItemArray[0].ToString());
		
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
			OraDB.Parameter_Values[1] = dtp_income.Text.Replace("-","").Replace("/",""); 
			OraDB.Parameter_Values[2] = _seq.ToString().PadLeft(3,'0').ToString(); 
			OraDB.Parameter_Values[3] = txtMold_CD.Text.Trim(); //MOLD
			OraDB.Parameter_Values[4] = "";  //TOT
			OraDB.Parameter_Values[5] = dtp_income.Text.Replace("-","").Replace("/",""); // Ngay Incoming
			OraDB.Parameter_Values[6] = cbo_Incom_type.SelectedValue.ToString(); 
			OraDB.Parameter_Values[7] = "";   //rta
			OraDB.Parameter_Values[8] = "";   //ets
			OraDB.Parameter_Values[9] = ""; 
			OraDB.Parameter_Values[10] = txtBox_Cust.Text.Trim();
			OraDB.Parameter_Values[11] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[12] = "";
			OraDB.Parameter_Values[13] = ""; 
			OraDB.Parameter_Values[14] = ""; 
			OraDB.Parameter_Values[15] = ClassLib.ComVar.This_User; 
			OraDB.Parameter_Values[16] = ""; 

			OraDB.Add_Modify_Parameter(true); 
			OraDB.Exe_Modify_Procedure();
		}
		private void save_mold_In_order_tail1(string _seq)
		{
			//save pur_tail.
			for (int i = 0; i < fgrid_size.Cols.Count-1 ; i++)
			{
				for (int j= 0 ; j<fgrid_size.Rows.Count -2 ;j++)
				{
					if (fgrid_size[j+2,i+1]!= null && fgrid_size[j+2,i+1]!= "")
					{
						if ( fgrid_size[j+2,i+1]=="I")
						{
							save_mold_In_tail1(_seq , txtMold_CD.Text.Trim(),
								fgrid_size[1,i+1].ToString(),fgrid_size[j+2,0].ToString(),
								fgrid_size[j+2,i+1].ToString());
						}
					}  
					else
					{
						//						break;
					}
				}
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
			OraDB.Parameter_Values[1] = "VJI" + dtp_income.Text.Replace("-","").Replace("/","") + _Inseq.ToString().PadLeft(3,'0').ToString(); 
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
			OraDB.Parameter_Values[11] = ""; 
			OraDB.Parameter_Values[12] = "";
			OraDB.Parameter_Values[13] = ""; 
			OraDB.Parameter_Values[14] = ClassLib.ComVar.This_User; 
			OraDB.Parameter_Values[15] = ""; 

			OraDB.Add_Modify_Parameter(true); 
			OraDB.Exe_Modify_Procedure();
		}
		
		private void Init_Form_Tail1()
		{
			for (int i=0; i< fgrid_size.Rows.Count-2;i++)
			{
				fgrid_size[i+2,0]=(char)(65+i);

			}
			for (int i=0; i <= fgrid_size.Cols.Count-1;i++)
			{
				fgrid_size.Cols[i].TextAlign = TextAlignEnum.CenterCenter;
				
			}
			fgrid_size[0,0] = "Size";
			fgrid_size[1,0] = "Seq";
			fgrid_size.AutoSizeCols();				
			fgrid_size.Rows[0].TextAlign = TextAlignEnum.CenterCenter ;
			fgrid_size.Cols[0].Width = 30 ;
						
		}

		private void rBtn_O_Click(object sender, System.EventArgs e)
		{
			if (rBtn_O.Checked == true)
			{
				txtMold_CD.Visible = true;
				txtMold_CD.Text = "";
				cbo_Purchase.Visible = false;
				cbo_Out.Visible = false;
				label6.Text = "Mold Code" ;
				cbo_Incom_type.Text = "" ;
				fgrid_size.Visible = true;
				fgrid_main.Visible = false;
				fgrid_head.Visible = false;
				this.tbtn_Save.Enabled = false;
				this.tbtn_Search.Enabled = false ;	
				this.tbtn_Append.Enabled = true ;
			}
			else
			{
				txtMold_CD.Visible = false;
				txtMold_CD.Text = "";
				cbo_Purchase.Visible = true;
				fgrid_size.Visible = false;
				fgrid_main.Visible = true;
				fgrid_head.Visible = true;
				
			}
		}
		
		private DataTable Select_Outgoing()
		{
			string Proc_Name = "PKG_SDT_MOLD.SEARCH_OUT_NO";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_OUT_YMD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = dtp_income.Text.Replace("/","").Replace("-","");
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}


	}
}

