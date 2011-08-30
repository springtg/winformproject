using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.Threading;
using System.IO;
using System.Data;
using System.Reflection; 

namespace FlexMold.Management
{
	public class Form_PB_Mold_Slip : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker cmb_workday;
		private C1.Win.C1List.C1Combo cbo_wh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label3;
		private C1.Win.C1List.C1Combo CboStatus;
		private System.Windows.Forms.ComboBox Cbo_Part;
		private System.Windows.Forms.Label label4;

		private COM.OraDB OraDB = new COM.OraDB();

		public Form_PB_Mold_Slip()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Slip));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.CboStatus = new C1.Win.C1List.C1Combo();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbo_wh = new C1.Win.C1List.C1Combo();
			this.cmb_workday = new System.Windows.Forms.DateTimePicker();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.Cbo_Part = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CboStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.Cbo_Part);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.CboStatus);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbo_wh);
			this.panel1.Controls.Add(this.cmb_workday);
			this.panel1.Controls.Add(this.lbl_factory);
			this.panel1.Controls.Add(this.cbo_factory);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 40);
			this.panel1.TabIndex = 28;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(616, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 32;
			this.label3.Text = "Status";
			// 
			// CboStatus
			// 
			this.CboStatus.AddItemCols = 0;
			this.CboStatus.AddItemSeparator = ';';
			this.CboStatus.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.CboStatus.Caption = "";
			this.CboStatus.CaptionHeight = 17;
			this.CboStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.CboStatus.ColumnCaptionHeight = 17;
			this.CboStatus.ColumnFooterHeight = 17;
			this.CboStatus.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.CboStatus.ContentHeight = 17;
			this.CboStatus.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.CboStatus.EditorBackColor = System.Drawing.SystemColors.Window;
			this.CboStatus.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.CboStatus.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.CboStatus.EditorHeight = 17;
			this.CboStatus.GapHeight = 2;
			this.CboStatus.ItemHeight = 15;
			this.CboStatus.Location = new System.Drawing.Point(680, 8);
			this.CboStatus.MatchEntryTimeout = ((long)(2000));
			this.CboStatus.MaxDropDownItems = ((short)(5));
			this.CboStatus.MaxLength = 32767;
			this.CboStatus.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.CboStatus.Name = "CboStatus";
			this.CboStatus.PartialRightColumn = false;
			this.CboStatus.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.CboStatus.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.CboStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.CboStatus.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.CboStatus.Size = new System.Drawing.Size(144, 23);
			this.CboStatus.TabIndex = 31;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(352, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 21);
			this.label2.TabIndex = 23;
			this.label2.Text = "WareHouse";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(184, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 21);
			this.label1.TabIndex = 22;
			this.label1.Text = "Date";
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
			this.cbo_wh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbo_wh.ItemHeight = 15;
			this.cbo_wh.Location = new System.Drawing.Point(448, 8);
			this.cbo_wh.MatchEntryTimeout = ((long)(2000));
			this.cbo_wh.MaxDropDownItems = ((short)(5));
			this.cbo_wh.MaxLength = 32767;
			this.cbo_wh.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_wh.Name = "cbo_wh";
			this.cbo_wh.PartialRightColumn = false;
			this.cbo_wh.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"hnn\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFo" +
				"oterHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0," +
				" 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><" +
				"Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><Even" +
				"RowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\"" +
				" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"" +
				"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle " +
				"parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><Reco" +
				"rdSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Se" +
				"lected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListB" +
				"oxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Norma" +
				"l\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" " +
				"me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me" +
				"=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" " +
				"me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"" +
				"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits" +
				">1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSel" +
				"Width>17</DefaultRecSelWidth></Blob>";
			this.cbo_wh.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_wh.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_wh.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_wh.Size = new System.Drawing.Size(144, 23);
			this.cbo_wh.TabIndex = 21;
			this.cbo_wh.SelectedValueChanged += new System.EventHandler(this.cbo_wh_SelectedValueChanged);
			// 
			// cmb_workday
			// 
			this.cmb_workday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.cmb_workday.Location = new System.Drawing.Point(232, 8);
			this.cmb_workday.Name = "cmb_workday";
			this.cmb_workday.Size = new System.Drawing.Size(104, 22);
			this.cmb_workday.TabIndex = 20;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.Transparent;
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ForeColor = System.Drawing.Color.Blue;
			this.lbl_factory.Location = new System.Drawing.Point(12, 12);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(56, 16);
			this.lbl_factory.TabIndex = 29;
			this.lbl_factory.Text = "Factory";
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
			this.cbo_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_factory.EditorHeight = 17;
			this.cbo_factory.Enabled = false;
			this.cbo_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_factory.GapHeight = 2;
			this.cbo_factory.ItemHeight = 15;
			this.cbo_factory.Location = new System.Drawing.Point(79, 8);
			this.cbo_factory.MatchEntryTimeout = ((long)(2000));
			this.cbo_factory.MaxDropDownItems = ((short)(5));
			this.cbo_factory.MaxLength = 32767;
			this.cbo_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_factory.Name = "cbo_factory";
			this.cbo_factory.PartialRightColumn = false;
			this.cbo_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Caption{AlignHorz:Center;}Normal{BackColor:Window;}Selected{ForeColor:Highlig" +
				"htText;BackColor:Highlight;}Style10{}Style11{}OddRow{}HighlightRow{ForeColor:Hig" +
				"hlightText;BackColor:Highlight;}RecordSelector{AlignImage:Center;}Footer{}Group{" +
				"AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Inactive{ForeCol" +
				"or:InactiveCaptionText;BackColor:InactiveCaption;}EvenRow{BackColor:Aqua;}Headin" +
				"g{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Al" +
				"ignVert:Center;}Style9{AlignHorz:Near;}Style8{}Style5{}Style4{}Style7{}Style6{}S" +
				"tyle1{}Style3{}Style2{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"vvvvvvvv\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" Col" +
				"umnFooterHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRe" +
				"ct>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScroll" +
				"Bar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" />" +
				"<EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"St" +
				"yle3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\"" +
				" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveS" +
				"tyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" />" +
				"<RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle paren" +
				"t=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List." +
				"ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"" +
				"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Head" +
				"ing\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Norma" +
				"l\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Nor" +
				"mal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\"" +
				" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertS" +
				"plits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSe" +
				"lWidth>17</DefaultRecSelWidth></Blob>";
			this.cbo_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_factory.Size = new System.Drawing.Size(88, 23);
			this.cbo_factory.TabIndex = 30;
			// 
			// Cbo_Part
			// 
			this.Cbo_Part.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Cbo_Part.Items.AddRange(new object[] {
														  "1-PUP",
														  "9-OSP",
														  "R-PPP",
														  "S-IP",
														  " Null"});
			this.Cbo_Part.Location = new System.Drawing.Point(920, 8);
			this.Cbo_Part.Name = "Cbo_Part";
			this.Cbo_Part.Size = new System.Drawing.Size(88, 22);
			this.Cbo_Part.TabIndex = 33;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(840, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 21);
			this.label4.TabIndex = 34;
			this.label4.Text = "Part Area";
			// 
			// Form_PB_Mold_Slip
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.panel1);
			this.Name = "Form_PB_Mold_Slip";
			this.Text = "Form_PB_Mold_Request";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Slip_Load);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CboStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Slip_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			this.tbtn_New.Enabled = false;
			this.tbtn_Save.Enabled = false;
			this.tbtn_Append.Enabled = false;
			this.tbtn_Color.Enabled = false;
			this.tbtn_Delete.Enabled = false;
			this.tbtn_Insert.Enabled = false;
			this.tbtn_Search.Enabled = false;
		}
		private void Init_Form()
		{
			cbo_factory.Text = "VJ";
			this.lbl_MainTitle.Text = "PCC_Mold Request";
			ClassLib.ComFunction.SetLangDic(this);
		
			//			fgrid_main.Set_Grid("SDT_MOLD_LOCATE_MANAGER1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			//			fgrid_main.Set_Action_Image(img_Action);
			//			fgrid_main.ExtendLastCol = false;
			//			fgrid_main.AutoSizeCols();
 
			DataTable dt_ret = Select_com_filter_code_List("SDV15");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List("SDV38");
			ClassLib.ComCtl.Set_ComboList(dt_ret, CboStatus, 0, 1, false, false);

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

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename;
			if ((cbo_wh.Text.ToString() == "")||(cbo_wh.Columns[0].Text =="ALL"))
			{
				MessageBox.Show("Please choose WareHouse. ");
				return;
			}
			else if ((CboStatus.Columns[0].Text == "10")||(CboStatus.Columns[0].Text == "30"))
			{	
				mrd_Filename = FlexMold.ClassLib.ComFunction.Set_RD_Directory("Forn_Mold_Slip");
				               
			}
			else if (CboStatus.Columns[0].Text == "20")
			{	
				mrd_Filename = FlexMold.ClassLib.ComFunction.Set_RD_Directory("Forn_Mold_Coating_Slip");
				               
			}
			else
			{
				MessageBox.Show("Please choose Status. ");
				return;
			}

			string Para         = " ";

			#region 출력조건

			int  iCnt  = 4;
			string [] aHead =  new string[iCnt];	
			
			string[] vProviso = GetSearchProviso();
			

			if (cbo_factory.Text == "")
				aHead[0]    = "VJ";
			else
				aHead[0]    = cbo_factory.Text.Trim();
			aHead[1]    = cmb_workday.Text.Replace("-","").Replace("/","");
			
			//			if((CboGroup.Columns[0].Text =="ALL")||(CboGroup.Text ==""))
			if((cbo_wh.Text == "")||(cbo_wh.Columns[0].Text == "ALL"))
				aHead[2]	 = "";
			else
				aHead[2] = cbo_wh.Columns[0].Text;
			
			if(cbo_wh.SelectedValue.ToString() == "99")
				aHead[3]	 = Cbo_Part.Text.Substring(0,1).Trim();
			else
				aHead[3]	 = "";
	
			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			FlexMold.Report.Form_RdViewer report = new FlexMold.Report.Form_RdViewer(mrd_Filename, Para);
//			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();		
		}
		private string[] GetSearchProviso()
		{
			string[] vProviso = new string[30];
			return vProviso;
		}

		private void cbo_wh_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cbo_wh.SelectedValue.ToString() == "99")
			{
				Cbo_Part.Visible = true;
				label4.Visible = true;
			}
			else
			{
				Cbo_Part.Visible = false;
				label4.Visible = false;
			}
		}

	}
}