using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexMold.Tooling
{
	public class Form_ST_Purchase_PO_Report : COM.MoldWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private C1.Win.C1List.C1Combo cmbVendor;
		private System.Windows.Forms.TextBox txtVendor;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label lbl_purYmd;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;		
		private System.Windows.Forms.DateTimePicker dpick_purYmd_Fr;
		private System.Windows.Forms.DateTimePicker dpick_purYmd;
		private System.Windows.Forms.DateTimePicker dtpETA;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.ComponentModel.IContainer components = null;

		private COM.OraDB MyOraDB = new COM.OraDB();		
		private Hashtable _cellCombo = null;
		private System.Windows.Forms.Panel pnl_main;
		private COM.FSP fgrid_main;
		private COM.FSP fgrid_main1;
		private System.Windows.Forms.CheckBox ckb_Report;
		private System.Windows.Forms.Label label5;
		private C1.Win.C1List.C1Combo cmbItem;
		private System.Windows.Forms.TextBox txtItem;
		private C1.Win.C1List.C1Combo cmbMain;
		private System.Windows.Forms.TextBox txtMain;
		private System.Windows.Forms.Label lbl_pur;
		private System.Windows.Forms.CheckBox ckb_Cuting;		
		private int _Rowfixed;			

		public Form_ST_Purchase_PO_Report()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_ST_Purchase_PO_Report));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_main = new System.Windows.Forms.Panel();
			this.fgrid_main1 = new COM.FSP();
			this.fgrid_main = new COM.FSP();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.ckb_Cuting = new System.Windows.Forms.CheckBox();
			this.lbl_pur = new System.Windows.Forms.Label();
			this.txtMain = new System.Windows.Forms.TextBox();
			this.cmbMain = new C1.Win.C1List.C1Combo();
			this.cmbItem = new C1.Win.C1List.C1Combo();
			this.txtItem = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ckb_Report = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpETA = new System.Windows.Forms.DateTimePicker();
			this.dpick_purYmd = new System.Windows.Forms.DateTimePicker();
			this.cmbVendor = new C1.Win.C1List.C1Combo();
			this.txtVendor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.lbl_purYmd = new System.Windows.Forms.Label();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dpick_purYmd_Fr = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbItem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbVendor)).BeginInit();
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
			this.c1Sizer1.Controls.Add(this.pnl_main);
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.GridDefinition = "16.1458333333333:False:True;83.1597222222222:False:False;\t0.393700787401575:False" +
				":True;98.4251968503937:False:False;0.393700787401575:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 30;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_main
			// 
			this.pnl_main.BackColor = System.Drawing.Color.White;
			this.pnl_main.Controls.Add(this.fgrid_main1);
			this.pnl_main.Controls.Add(this.fgrid_main);
			this.pnl_main.Location = new System.Drawing.Point(8, 97);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(1000, 479);
			this.pnl_main.TabIndex = 5;
			// 
			// fgrid_main1
			// 
			this.fgrid_main1.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main1.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main1.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main1.Name = "fgrid_main1";
			this.fgrid_main1.Size = new System.Drawing.Size(1000, 479);
			this.fgrid_main1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:192, 255, 255;ForeColor:Red;}	Subtotal0{BackColor:255, 224, 192;ForeColor:Blue;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main1.TabIndex = 2;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(1000, 479);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:192, 255, 255;ForeColor:Red;}	Subtotal0{BackColor:255, 224, 192;ForeColor:Blue;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 1;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.ckb_Cuting);
			this.pnl_head.Controls.Add(this.lbl_pur);
			this.pnl_head.Controls.Add(this.txtMain);
			this.pnl_head.Controls.Add(this.cmbMain);
			this.pnl_head.Controls.Add(this.cmbItem);
			this.pnl_head.Controls.Add(this.txtItem);
			this.pnl_head.Controls.Add(this.label5);
			this.pnl_head.Controls.Add(this.ckb_Report);
			this.pnl_head.Controls.Add(this.label4);
			this.pnl_head.Controls.Add(this.dtpETA);
			this.pnl_head.Controls.Add(this.dpick_purYmd);
			this.pnl_head.Controls.Add(this.cmbVendor);
			this.pnl_head.Controls.Add(this.txtVendor);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.lbl_purYmd);
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
			this.pnl_head.Size = new System.Drawing.Size(1000, 93);
			this.pnl_head.TabIndex = 4;
			// 
			// ckb_Cuting
			// 
			this.ckb_Cuting.Location = new System.Drawing.Point(744, 36);
			this.ckb_Cuting.Name = "ckb_Cuting";
			this.ckb_Cuting.Size = new System.Drawing.Size(104, 16);
			this.ckb_Cuting.TabIndex = 562;
			this.ckb_Cuting.Text = "Cutting die";
			this.ckb_Cuting.Click += new System.EventHandler(this.ckb_Cuting_Click);
			// 
			// lbl_pur
			// 
			this.lbl_pur.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_pur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_pur.ImageIndex = 0;
			this.lbl_pur.ImageList = this.img_Label;
			this.lbl_pur.Location = new System.Drawing.Point(328, 62);
			this.lbl_pur.Name = "lbl_pur";
			this.lbl_pur.Size = new System.Drawing.Size(70, 21);
			this.lbl_pur.TabIndex = 561;
			this.lbl_pur.Text = "Main";
			this.lbl_pur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtMain
			// 
			this.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txtMain.Location = new System.Drawing.Point(400, 62);
			this.txtMain.MaxLength = 500;
			this.txtMain.Name = "txtMain";
			this.txtMain.Size = new System.Drawing.Size(91, 21);
			this.txtMain.TabIndex = 560;
			this.txtMain.Text = "";
			this.txtMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMain_KeyUp);
			// 
			// cmbMain
			// 
			this.cmbMain.AddItemCols = 0;
			this.cmbMain.AddItemSeparator = ';';
			this.cmbMain.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbMain.AutoSize = false;
			this.cmbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbMain.Caption = "";
			this.cmbMain.CaptionHeight = 17;
			this.cmbMain.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbMain.ColumnCaptionHeight = 18;
			this.cmbMain.ColumnFooterHeight = 18;
			this.cmbMain.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbMain.ContentHeight = 17;
			this.cmbMain.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbMain.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbMain.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmbMain.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbMain.EditorHeight = 17;
			this.cmbMain.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbMain.GapHeight = 2;
			this.cmbMain.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmbMain.ItemHeight = 15;
			this.cmbMain.Location = new System.Drawing.Point(488, 62);
			this.cmbMain.MatchEntryTimeout = ((long)(2000));
			this.cmbMain.MaxDropDownItems = ((short)(5));
			this.cmbMain.MaxLength = 32767;
			this.cmbMain.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbMain.Name = "cmbMain";
			this.cmbMain.PartialRightColumn = false;
			this.cmbMain.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmbMain.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbMain.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbMain.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbMain.Size = new System.Drawing.Size(152, 21);
			this.cmbMain.TabIndex = 558;
			// 
			// cmbItem
			// 
			this.cmbItem.AddItemCols = 0;
			this.cmbItem.AddItemSeparator = ';';
			this.cmbItem.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbItem.AutoSize = false;
			this.cmbItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbItem.Caption = "";
			this.cmbItem.CaptionHeight = 17;
			this.cmbItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbItem.ColumnCaptionHeight = 18;
			this.cmbItem.ColumnFooterHeight = 18;
			this.cmbItem.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbItem.ContentHeight = 17;
			this.cmbItem.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbItem.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbItem.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmbItem.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbItem.EditorHeight = 17;
			this.cmbItem.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbItem.GapHeight = 2;
			this.cmbItem.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmbItem.ItemHeight = 15;
			this.cmbItem.Location = new System.Drawing.Point(832, 62);
			this.cmbItem.MatchEntryTimeout = ((long)(2000));
			this.cmbItem.MaxDropDownItems = ((short)(5));
			this.cmbItem.MaxLength = 32767;
			this.cmbItem.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbItem.Name = "cmbItem";
			this.cmbItem.PartialRightColumn = false;
			this.cmbItem.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Cen" +
				"ter;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmbItem.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbItem.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbItem.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbItem.Size = new System.Drawing.Size(152, 21);
			this.cmbItem.TabIndex = 556;
			// 
			// txtItem
			// 
			this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txtItem.Location = new System.Drawing.Point(744, 62);
			this.txtItem.MaxLength = 500;
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(91, 21);
			this.txtItem.TabIndex = 555;
			this.txtItem.Text = "";
			this.txtItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyUp);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ImageIndex = 0;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(672, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 21);
			this.label5.TabIndex = 554;
			this.label5.Text = "Item";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ckb_Report
			// 
			this.ckb_Report.Location = new System.Drawing.Point(864, 32);
			this.ckb_Report.Name = "ckb_Report";
			this.ckb_Report.Size = new System.Drawing.Size(96, 24);
			this.ckb_Report.TabIndex = 553;
			this.ckb_Report.Text = "Expenses";
			this.ckb_Report.Click += new System.EventHandler(this.ckb_Report_Click);
			this.ckb_Report.StyleChanged += new System.EventHandler(this.ckb_Report_StyleChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(512, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 16);
			this.label4.TabIndex = 552;
			this.label4.Text = "~";
			// 
			// dtpETA
			// 
			this.dtpETA.CustomFormat = "yyyy-MM-dd";
			this.dtpETA.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dtpETA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpETA.Location = new System.Drawing.Point(544, 40);
			this.dtpETA.Name = "dtpETA";
			this.dtpETA.Size = new System.Drawing.Size(96, 21);
			this.dtpETA.TabIndex = 551;
			// 
			// dpick_purYmd
			// 
			this.dpick_purYmd.CustomFormat = "yyyy-MM-dd";
			this.dpick_purYmd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_purYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_purYmd.Location = new System.Drawing.Point(400, 40);
			this.dpick_purYmd.Name = "dpick_purYmd";
			this.dpick_purYmd.Size = new System.Drawing.Size(99, 21);
			this.dpick_purYmd.TabIndex = 550;
			// 
			// cmbVendor
			// 
			this.cmbVendor.AddItemCols = 0;
			this.cmbVendor.AddItemSeparator = ';';
			this.cmbVendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbVendor.AutoSize = false;
			this.cmbVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbVendor.Caption = "";
			this.cmbVendor.CaptionHeight = 17;
			this.cmbVendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbVendor.ColumnCaptionHeight = 18;
			this.cmbVendor.ColumnFooterHeight = 18;
			this.cmbVendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbVendor.ContentHeight = 17;
			this.cmbVendor.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbVendor.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbVendor.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmbVendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbVendor.EditorHeight = 17;
			this.cmbVendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmbVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbVendor.GapHeight = 2;
			this.cmbVendor.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmbVendor.ItemHeight = 15;
			this.cmbVendor.Location = new System.Drawing.Point(154, 62);
			this.cmbVendor.MatchEntryTimeout = ((long)(2000));
			this.cmbVendor.MaxDropDownItems = ((short)(5));
			this.cmbVendor.MaxLength = 32767;
			this.cmbVendor.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbVendor.Name = "cmbVendor";
			this.cmbVendor.PartialRightColumn = false;
			this.cmbVendor.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmbVendor.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbVendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbVendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbVendor.Size = new System.Drawing.Size(152, 21);
			this.cmbVendor.TabIndex = 548;
			// 
			// txtVendor
			// 
			this.txtVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txtVendor.Location = new System.Drawing.Point(79, 62);
			this.txtVendor.MaxLength = 500;
			this.txtVendor.Name = "txtVendor";
			this.txtVendor.Size = new System.Drawing.Size(75, 21);
			this.txtVendor.TabIndex = 547;
			this.txtVendor.Text = "";
			this.txtVendor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVendor_KeyUp);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(328, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 21);
			this.label1.TabIndex = 543;
			this.label1.Text = "From";
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
			this.cmb_factory.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(79, 40);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(227, 21);
			this.cmb_factory.TabIndex = 1;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(984, 77);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// lbl_purYmd
			// 
			this.lbl_purYmd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_purYmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_purYmd.ImageIndex = 1;
			this.lbl_purYmd.ImageList = this.img_Label;
			this.lbl_purYmd.Location = new System.Drawing.Point(8, 62);
			this.lbl_purYmd.Name = "lbl_purYmd";
			this.lbl_purYmd.Size = new System.Drawing.Size(70, 21);
			this.lbl_purYmd.TabIndex = 50;
			this.lbl_purYmd.Text = "Vendor";
			this.lbl_purYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 76);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(960, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 1;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(70, 21);
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
			this.pic_head7.Location = new System.Drawing.Point(899, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 52);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
			this.pic_head2.Location = new System.Drawing.Point(984, 0);
			this.pic_head2.Name = "pic_head2";
			this.pic_head2.Size = new System.Drawing.Size(16, 32);
			this.pic_head2.TabIndex = 44;
			this.pic_head2.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 42;
			this.label2.Text = "       Report";
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
			this.pic_head1.Size = new System.Drawing.Size(960, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// pic_head5
			// 
			this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
			this.pic_head5.Location = new System.Drawing.Point(0, 77);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 66);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.TabIndex = 0;
			// 
			// dpick_purYmd_Fr
			// 
			this.dpick_purYmd_Fr.Location = new System.Drawing.Point(0, 0);
			this.dpick_purYmd_Fr.Name = "dpick_purYmd_Fr";
			this.dpick_purYmd_Fr.TabIndex = 0;
			// 
			// Form_ST_Purchase_PO_Report
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_ST_Purchase_PO_Report";
			this.Load += new System.EventHandler(this.Form_ST_Purchase_PO_Report_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmbMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbItem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbVendor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_ST_Purchase_PO_Report_Load(object sender, System.EventArgs e)
		{
			Init_Form();

			// set up Subtotal
			fgrid_main.Tree.Column = 1;
			CellStyle s = fgrid_main.Styles[CellStyleEnum.Subtotal0];
			s.BackColor  = Color.SkyBlue;
			s.ForeColor =  Color.Blue;

			CellStyle s1 = fgrid_main.Styles[CellStyleEnum.Subtotal1];
			s1.BackColor = Color.YellowGreen;
			s1.ForeColor = Color.Red;

			// set up Subtotal
			fgrid_main1.Tree.Column = 1;
			CellStyle s2 = fgrid_main1.Styles[CellStyleEnum.Subtotal0];
			s2.BackColor  = Color.SkyBlue;
			s2.ForeColor =  Color.Blue;

			CellStyle s3 = fgrid_main1.Styles[CellStyleEnum.Subtotal1];
			s3.BackColor = Color.YellowGreen;
			s3.ForeColor = Color.Red;
			
			fgrid_main.Visible = true;
			fgrid_main1.Visible = false;

			txtItem.Visible = false;
			cmbItem.Visible = false;
			label5.Visible = false;

			txtMain.Visible = false;
			cmbMain.Visible = false;
			lbl_pur.Visible = false;
			
		}

		private void Init_Form()
		{						
			// form initialize
			ClassLib.ComFunction.Init_Form_Control(this);
			ClassLib.ComFunction.SetLangDic(this);

			this.Text		   = "Small Tooling Report";
			lbl_MainTitle.Text = "PO List Report";		

			// grid set
			fgrid_main.Set_Grid("SVM_SM_PO_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
//			fgrid_main.Rows[1].AllowMerging = true;
//			fgrid_main.Rows[3].Visible = false;
//			fgrid_main.AllowDragging = AllowDraggingEnum.None;			
//			_Rowfixed = fgrid_main.Rows.Fixed;		

			//입력부 setup
			Init_Combo();						
			
			// grid set
//			_cellCombo = new Hashtable(fgrid_main.Cols.Count);
//
//			for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
//			{
//				if (fgrid_main.Cols[vCol].AllowEditing)
//				{
//					if (fgrid_main.Cols[vCol].DataMap != null)
//					{
//						_cellCombo.Add(vCol, fgrid_main.GetDataSourceWithCode(vCol));
//					}
//				}
//			}
//
//			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcrossOut; 
//			fgrid_main.SelectionMode = SelectionModeEnum.Cell;

//			_firstLoad = false;		
		
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
				
				vDt.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void txtVendor_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				txtVendorKeyUpProcess();		
		}

		private void txtVendorKeyUpProcess()
		{
			DataTable vDt = null;
			string temp ;
			try
			{
				if (txtVendor.Text.Trim().Length == 0)
					temp = "";
				else
					temp = txtVendor.Text ;
//				if (txtVendor.Text.Trim().Length > 0)
//				{
					vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, temp);
					
					cmbVendor.SelectedValue = txtVendor.Text;

					if (vDt.Rows.Count > 0)
					{
						ClassLib.ComCtl.Set_ComboList(vDt, cmbVendor, 0, 1, false, 80, 140);
					}
					else
					{
						ClassLib.ComFunction.User_Message("Data Not Found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtVendor.Text = "";
						cmbVendor.ClearItems();
					}

					txtVendor.Focus();
//				}
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (ckb_Report.Checked == true)			
				this.Tbtn_PrintProcess1();
			else if (ckb_Cuting.Checked  == true)
				this.Tbtn_PrintProcess2();
			else
				this.Tbtn_PrintProcess();
			
		}

		private void Tbtn_PrintProcess()
		{
			try
			{
				PRINT_ST_PURCHASE_PO();
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

		private void PRINT_ST_PURCHASE_PO()
		{
			string sDir;
			
			sDir = FlexMold.ClassLib.ComFunction.Set_RD_Directory("Purchase PO List By Date");

			string sPara;

			

			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");			
			MyOraDB.Parameter_Values[ 1]   = dpick_purYmd.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 2]   = dtpETA.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_Combo(cmbVendor, "");				
		
			sPara  = " /rp ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_factory, "") +	"' ";			            //Parm1: Factory
			sPara += "'" + dpick_purYmd.Value.ToString("yyyyMMdd") +	"' ";						                //Parm2: Out Date
			sPara += "'" + dtpETA.Value.ToString("yyyyMMdd") +	"' ";						      	//Parm3: Out Line
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmbVendor, " ") +	"' ";						                    	//Parm4: Item

			FlexMold.Report.Form_RdViewer MyReport = new FlexMold.Report.Form_RdViewer(sDir, sPara);

			//			FlexMold.Text = "VOC Material Tracking";
			MyReport.Show();
				
		}

		private void Tbtn_SearchProcess()
		{
			DataTable vDt1 = null;
			fgrid_main.Clear();
			

			fgrid_main.Set_Grid("SVM_SM_PO_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.ExtendLastCol = false;
			try
			{
				vDt1 = SELECT_PO_LIST();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_main.AddItem(vDt1.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);						
					}
					SubTotalGrid();

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
		private void Tbtn_SearchProcess1()
		{
			DataTable vDt1 = null;
			fgrid_main1.Clear();
			

			fgrid_main1.Set_Grid("SVM_SM_EXPENSES", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify,								false);
			fgrid_main1.Set_Action_Image(img_Action);
			fgrid_main1.ExtendLastCol = false;
			try
			{
				vDt1 = SELECT_EXPENSES();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_main1.AddItem(vDt1.Rows[i].ItemArray, fgrid_main1.Rows.Count, 1);						
					}
					SubTotalGrid1();
					fgrid_main1.Cols[1].AllowMerging = true ;
					fgrid_main1.Cols[2].AllowMerging = true ;
					fgrid_main1.Cols[3].AllowMerging = true ;

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

		private void Tbtn_SearchProcess2()
		{
			DataTable vDt1 = null;
			fgrid_main1.Clear();
			

			fgrid_main1.Set_Grid("SVM_SM_EXPENSES", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify,								false);
			fgrid_main1.Set_Action_Image(img_Action);
			fgrid_main1.ExtendLastCol = false;
			try
			{
				vDt1 = SELECT_CUTING();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_main1.AddItem(vDt1.Rows[i].ItemArray, fgrid_main1.Rows.Count, 1);						
					}
					SubTotalGrid2();
					fgrid_main1.Cols[1].AllowMerging = true ;
					fgrid_main1.Cols[2].AllowMerging = true ;
					fgrid_main1.Cols[3].AllowMerging = true ;

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

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (ckb_Report.Checked == true)
			{
				fgrid_main1.Clear(); 
				fgrid_main1.Set_Grid("SVM_SM_EXPENSES", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.											ForModify, false);
				fgrid_main1.Set_Action_Image(img_Action);
				fgrid_main1.ExtendLastCol = false;
				this.Tbtn_SearchProcess1();
			}
			else if (ckb_Cuting.Checked == true)
			{
				fgrid_main1.Clear(); 
				fgrid_main1.Set_Grid("SVM_SM_EXPENSES", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.										ForModify, false);
				fgrid_main1.Set_Action_Image(img_Action);
				fgrid_main1.ExtendLastCol = false;
				this.Tbtn_SearchProcess2();
			}
			else
			{
				fgrid_main.Clear();
				fgrid_main.Set_Grid("SVM_SM_PO_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify									, false);
				fgrid_main.Set_Action_Image(img_Action);
				fgrid_main.ExtendLastCol = false;
				this.Tbtn_SearchProcess();
			}
		}

		private System.Data.DataTable SELECT_PO_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_SM_PUR_REPORT.SELECT_SVM_SM_PUR_PO_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_YMD_FR";
			MyOraDB.Parameter_Name[2] = "ARG_PUR_YMD_TO";
			MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = dpick_purYmd.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2] = dtpETA.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmbVendor, "");				
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
			
		}
		private System.Data.DataTable SELECT_EXPENSES()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_SM_PUR_REPORT.SELECT_SVM_SM_PUR_EXPENSES";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_YMD_FR";
			MyOraDB.Parameter_Name[2] = "ARG_PUR_YMD_TO";
			MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[5] = "ARG_MAIN_CD";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = dpick_purYmd.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2] = dtpETA.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmbVendor, "");				
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmbItem, "");
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(cmbMain, "");
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
			
		}

		private System.Data.DataTable SELECT_CUTING()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_SM_PUR_REPORT.SELECT_SVM_SM_PUR_CUTING";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_YMD_FR";
			MyOraDB.Parameter_Name[2] = "ARG_PUR_YMD_TO";
			MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
//			MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
//			MyOraDB.Parameter_Name[5] = "ARG_MAIN_CD";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = dpick_purYmd.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2] = dtpETA.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmbVendor, "");				
//			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmbItem, "");
//			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(cmbMain, "");
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
			
		}

		private void SubTotalGrid()
		{
			fgrid_main.Subtotal(AggregateEnum.Clear);
			fgrid_main.SubtotalPosition = SubtotalPositionEnum.BelowData;			
			
			fgrid_main.Subtotal(AggregateEnum.Sum,-1, 0, 4, "GTotal");
			fgrid_main.Subtotal(AggregateEnum.Sum,-1, 0, 5, "GTotal");			
							
			fgrid_main.Subtotal(AggregateEnum.Sum, 0, 1, 4, "STotal");			 
			fgrid_main.Subtotal(AggregateEnum.Sum, 0, 1, 5, "STotal");			 			
			

		}
		private void SubTotalGrid1()
		{
			fgrid_main1.Subtotal(AggregateEnum.Clear);
			fgrid_main1.SubtotalPosition = SubtotalPositionEnum.BelowData;			
			
			fgrid_main1.Subtotal(AggregateEnum.Sum,-1, 1, 8, "GTotal");
			fgrid_main1.Subtotal(AggregateEnum.Sum,-1, 1, 9, "GTotal");			
							
			fgrid_main1.Subtotal(AggregateEnum.Sum, 0, 5, 8, "STotal");			 
			fgrid_main1.Subtotal(AggregateEnum.Sum, 0, 5, 9, "STotal");			 			
			

		}
		private void SubTotalGrid2()
		{
			fgrid_main1.Subtotal(AggregateEnum.Clear);
			fgrid_main1.SubtotalPosition = SubtotalPositionEnum.BelowData;			
			
//			fgrid_main1.Subtotal(AggregateEnum.Sum,-1, 1, 7, "GTotal");
			fgrid_main1.Subtotal(AggregateEnum.Sum,-1, 1, 8, "GTotal");			
			fgrid_main1.Subtotal(AggregateEnum.Sum,-1, 1, 9, "GTotal");			
							
//			fgrid_main1.Subtotal(AggregateEnum.Sum, 0, 5, 7, "STotal");			 
			fgrid_main1.Subtotal(AggregateEnum.Sum, 0, 5, 8, "STotal");			 			
			fgrid_main1.Subtotal(AggregateEnum.Sum, 0, 5, 9, "STotal");			 			
			

		}

		private void ckb_Report_StyleChanged(object sender, System.EventArgs e)
		{
//			if (ckb_Report.Checked == true)
//				fgrid_main.Visible = false;
//			else
//				fgrid_main1.Visible = true;
		}

		private void ckb_Report_Click(object sender, System.EventArgs e)
		{
			if (ckb_Report.Checked == true)
			{
				ckb_Cuting.Checked = false;
				fgrid_main1.Clear(); 
				fgrid_main1.Set_Grid("SVM_SM_EXPENSES", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.											ForModify, false);
				fgrid_main.Visible = false;
				fgrid_main1.Visible = true;
				txtItem.Visible = true;
				cmbItem.Visible = true;
				label5.Visible = true;

				txtMain.Visible = true;
				cmbMain.Visible = true;
				lbl_pur.Visible = true;
			}
			else
			{
				fgrid_main.Clear();
				fgrid_main.Set_Grid("SVM_SM_PO_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify									, false);
				fgrid_main.Visible = true;
				fgrid_main1.Visible = false;
				txtItem.Visible = false;
				cmbItem.Visible = false;
				label5.Visible = false;

				txtMain.Visible = false;
				cmbMain.Visible = false;
				lbl_pur.Visible = false;
			}
		
		}

		private void txtItem_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				txtItemKeyUpProcess();		
		}

		private void txtItemKeyUpProcess()
		{
			DataTable vDt = null;
			string temp ;
			try
			{
				if (txtItem.Text.Trim().Length == 0)
					temp = "";
				else
					temp = txtItem.Text ;
				//				if (txtVendor.Text.Trim().Length > 0)
				//				{
				vDt = ClassLib.ComFunction.SELECT_SCM_ITEM_LIST(temp);
					
				cmbItem.SelectedValue = txtItem.Text;

				if (vDt.Rows.Count > 0)
				{
					ClassLib.ComCtl.Set_ComboList(vDt, cmbItem, 0, 1, false, 80, 140);
				}
				else
				{
					ClassLib.ComFunction.User_Message("Data Not Found", "Search", MessageBoxButtons.OK,															MessageBoxIcon.Information);
					txtItem.Text = "";
					cmbItem.ClearItems();
				}

				txtItem.Focus();
				//				}
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}

		private void Tbtn_PrintProcess1()
		{
			try
			{
				PRINT_ST_PURCHASE_EXPENSES();
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

		private void Tbtn_PrintProcess2()
		{
			try
			{
				PRINT_ST_PURCHASE_CUTING();
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

		private void PRINT_ST_PURCHASE_EXPENSES()
		{
			string sDir;
			
			sDir = FlexMold.ClassLib.ComFunction.Set_RD_Directory("Purchase Expenses By Date");

			string sPara;

			

			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");			
			MyOraDB.Parameter_Values[ 1]   = dpick_purYmd.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 2]   = dtpETA.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_Combo(cmbVendor, "");				
			MyOraDB.Parameter_Values[ 4]   = ClassLib.ComFunction.Empty_Combo(cmbItem, "");				
			MyOraDB.Parameter_Values[ 5]   = ClassLib.ComFunction.Empty_Combo(cmbMain, "");				
		
			sPara  = " /rp ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_factory, "") +	"' ";	      //Parm1: Factory
			sPara += "'" + dpick_purYmd.Value.ToString("yyyyMMdd") +	"' ";			      //Parm2: Out Date
			sPara += "'" + dtpETA.Value.ToString("yyyyMMdd") +	"' ";					 	//Parm3: Out Line
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmbVendor, " ") +	"' ";		//Parm3: Vendor
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmbItem, " ")  +    "' ";		//Parm4: Item
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmbMain, " ")  +    "' ";	    //Parm5: Main

			FlexMold.Report.Form_RdViewer MyReport = new FlexMold.Report.Form_RdViewer(sDir, sPara);

			//			FlexMold.Text = "VOC Material Tracking";
			MyReport.Show();
				
		}

		private void PRINT_ST_PURCHASE_CUTING()
		{
			string sDir;
			
			sDir = FlexMold.ClassLib.ComFunction.Set_RD_Directory("Purchase Cuting Die By Date");

			string sPara;

			

			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");			
			MyOraDB.Parameter_Values[ 1]   = dpick_purYmd.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 2]   = dtpETA.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_Combo(cmbVendor, "");				
//			MyOraDB.Parameter_Values[ 4]   = ClassLib.ComFunction.Empty_Combo(cmbItem, "");				
//			MyOraDB.Parameter_Values[ 5]   = ClassLib.ComFunction.Empty_Combo(cmbMain, "");				
		
			sPara  = " /rp ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_factory, "") +	"' ";	      //Parm1: Factory
			sPara += "'" + dpick_purYmd.Value.ToString("yyyyMMdd") +	"' ";			      //Parm2: Out Date
			sPara += "'" + dtpETA.Value.ToString("yyyyMMdd") +	"' ";					 	//Parm3: Out Line
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmbVendor, " ") +	"' ";		//Parm3: Vendor
//			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmbItem, " ")  +    "' ";		//Parm4: Item
//			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmbMain, " ")  +    "' ";	    //Parm5: Main

			FlexMold.Report.Form_RdViewer MyReport = new FlexMold.Report.Form_RdViewer(sDir, sPara);

			//			FlexMold.Text = "VOC Material Tracking";
			MyReport.Show();
				
		}

		private void txtMain_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				txtMainKeyUpProcess();		
		}

		private void txtMainKeyUpProcess()
		{
			DataTable vDt1 = null;
			string temp1 ;
			string main_sub = "M";
			try
			{
				if (txtMain.Text.Trim().Length == 0)
					temp1 = "";
				else
					temp1 = txtMain.Text ;
				//				if (txtVendor.Text.Trim().Length > 0)
				//				{
				vDt1 = ClassLib.ComFunction.SELECT_SCM_MAIN_SUB_LIST(main_sub,temp1);
					
				cmbMain.SelectedValue = txtMain.Text;

				if (vDt1.Rows.Count > 0)
				{
					ClassLib.ComCtl.Set_ComboList(vDt1, cmbMain, 0, 1, false, 80, 140);
				}
				else
				{
					ClassLib.ComFunction.User_Message("Data Not Found", "Search", MessageBoxButtons.OK,																		MessageBoxIcon.Information);
					txtMain.Text = "";
					cmbMain.ClearItems();
				}

				txtMain.Focus();
				//				}
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
			finally
			{
				if (vDt1 != null) vDt1.Dispose();
			}
		}

		private void ckb_Cuting_Click(object sender, System.EventArgs e)
		{
			if (ckb_Cuting.Checked == true)
			{
				ckb_Report.Checked = false;
				fgrid_main1.Clear(); 
				fgrid_main1.Set_Grid("SVM_SM_EXPENSES", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.											ForModify, false);
				fgrid_main.Visible = false;
				fgrid_main1.Visible = true;
				txtItem.Visible = false;
				cmbItem.Visible = false;
				label5.Visible = false;

			}
			else
			{
				fgrid_main.Clear();
				fgrid_main.Set_Grid("SVM_SM_PO_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify									, false);
				fgrid_main.Visible = true;
				fgrid_main1.Visible = false;
				txtItem.Visible = false;
				cmbItem.Visible = false;
				label5.Visible = false;

				txtMain.Visible = false;
				cmbMain.Visible = false;
				lbl_pur.Visible = false;
			}
		}


	}
}

