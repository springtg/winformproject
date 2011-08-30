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
using FlexTraining.Master; 

namespace FlexTraining.Master
{
	public class Form_Training_Target : COM.TrainingWinForm.Pop_Large
	{
		private System.Windows.Forms.Panel panel2;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.TextBox txt_Training;
		private C1.Win.C1List.C1Combo cmb_Training;
		private System.Windows.Forms.Label lbl_Training;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cmb_Group;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dpick_date_from;
		private System.Windows.Forms.DateTimePicker dpick_date_to;
		private System.ComponentModel.IContainer components = null;

		public Form_Training_Target()
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

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed;
		private int _temp_row = 0, _temp_col = 0;
		private int _colMonth	    = (int) ClassLib.TBSIM_TRAINEE_TARGET.IxMonth;
		private int _colTarget	    = (int) ClassLib.TBSIM_TRAINEE_TARGET.IxTarget;
		private int _colRemark	    = (int) ClassLib.TBSIM_TRAINEE_TARGET.IxRemark;
			
		#endregion


		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Training_Target));
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.txt_Training = new System.Windows.Forms.TextBox();
			this.cmb_Training = new C1.Win.C1List.C1Combo();
			this.lbl_Training = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.cmb_Group = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_date_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_date_to = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Training)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Group)).BeginInit();
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
			// tbtn_New
			// 
			this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
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
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel2.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.panel2.Location = new System.Drawing.Point(5, 160);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(787, 408);
			this.panel2.TabIndex = 47;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(787, 408);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 32;
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// txt_Training
			// 
			this.txt_Training.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Training.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Training.Location = new System.Drawing.Point(112, 110);
			this.txt_Training.MaxLength = 20;
			this.txt_Training.Name = "txt_Training";
			this.txt_Training.Size = new System.Drawing.Size(200, 21);
			this.txt_Training.TabIndex = 157;
			this.txt_Training.Text = "";
			// 
			// cmb_Training
			// 
			this.cmb_Training.AddItemCols = 0;
			this.cmb_Training.AddItemSeparator = ';';
			this.cmb_Training.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Training.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Training.Caption = "";
			this.cmb_Training.CaptionHeight = 17;
			this.cmb_Training.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Training.ColumnCaptionHeight = 18;
			this.cmb_Training.ColumnFooterHeight = 18;
			this.cmb_Training.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Training.ContentHeight = 17;
			this.cmb_Training.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Training.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Training.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Training.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Training.EditorHeight = 17;
			this.cmb_Training.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Training.GapHeight = 2;
			this.cmb_Training.ItemHeight = 15;
			this.cmb_Training.Location = new System.Drawing.Point(314, 110);
			this.cmb_Training.MatchEntryTimeout = ((long)(2000));
			this.cmb_Training.MaxDropDownItems = ((short)(5));
			this.cmb_Training.MaxLength = 32767;
			this.cmb_Training.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Training.Name = "cmb_Training";
			this.cmb_Training.PartialRightColumn = false;
			this.cmb_Training.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Training.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Training.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Training.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Training.Size = new System.Drawing.Size(354, 21);
			this.cmb_Training.TabIndex = 156;
			this.cmb_Training.TextChanged += new System.EventHandler(this.cmb_Training_TextChanged);
			// 
			// lbl_Training
			// 
			this.lbl_Training.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Training.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Training.ImageIndex = 0;
			this.lbl_Training.ImageList = this.img_Label;
			this.lbl_Training.Location = new System.Drawing.Point(8, 110);
			this.lbl_Training.Name = "lbl_Training";
			this.lbl_Training.Size = new System.Drawing.Size(100, 21);
			this.lbl_Training.TabIndex = 155;
			this.lbl_Training.Text = "Training";
			this.lbl_Training.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_factory.Location = new System.Drawing.Point(112, 86);
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
			this.cmb_factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_factory.TabIndex = 158;
			this.cmb_factory.Change += new C1.Win.C1List.ChangeEventHandler(this.cmb_factory_Change);
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 86);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 159;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Group
			// 
			this.cmb_Group.AddItemCols = 0;
			this.cmb_Group.AddItemSeparator = ';';
			this.cmb_Group.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Group.Caption = "";
			this.cmb_Group.CaptionHeight = 17;
			this.cmb_Group.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Group.ColumnCaptionHeight = 18;
			this.cmb_Group.ColumnFooterHeight = 18;
			this.cmb_Group.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Group.ContentHeight = 17;
			this.cmb_Group.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Group.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Group.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Group.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Group.EditorHeight = 17;
			this.cmb_Group.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Group.GapHeight = 2;
			this.cmb_Group.ItemHeight = 15;
			this.cmb_Group.Location = new System.Drawing.Point(112, 134);
			this.cmb_Group.MatchEntryTimeout = ((long)(2000));
			this.cmb_Group.MaxDropDownItems = ((short)(5));
			this.cmb_Group.MaxLength = 32767;
			this.cmb_Group.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Group.Name = "cmb_Group";
			this.cmb_Group.PartialRightColumn = false;
			this.cmb_Group.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Group.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Group.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Group.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Group.Size = new System.Drawing.Size(283, 21);
			this.cmb_Group.TabIndex = 161;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 160;
			this.label1.Text = "Group";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_date_from
			// 
			this.dpick_date_from.CustomFormat = "";
			this.dpick_date_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_from.Location = new System.Drawing.Point(504, 134);
			this.dpick_date_from.Name = "dpick_date_from";
			this.dpick_date_from.Size = new System.Drawing.Size(128, 21);
			this.dpick_date_from.TabIndex = 559;
			// 
			// dpick_date_to
			// 
			this.dpick_date_to.CustomFormat = "";
			this.dpick_date_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_to.Location = new System.Drawing.Point(664, 134);
			this.dpick_date_to.Name = "dpick_date_to";
			this.dpick_date_to.Size = new System.Drawing.Size(120, 21);
			this.dpick_date_to.TabIndex = 560;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(640, 134);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(8, 16);
			this.label2.TabIndex = 562;
			this.label2.Text = "~";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(400, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 561;
			this.label3.Text = "Training Date";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form_Training_Target
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.dpick_date_from);
			this.Controls.Add(this.dpick_date_to);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmb_Group);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmb_factory);
			this.Controls.Add(this.lbl_factory);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.cmb_Training);
			this.Controls.Add(this.txt_Training);
			this.Controls.Add(this.lbl_Training);
			this.Name = "Form_Training_Target";
			this.Load += new System.EventHandler(this.Form_Training_Target_Load);
			this.Controls.SetChildIndex(this.lbl_Training, 0);
			this.Controls.SetChildIndex(this.txt_Training, 0);
			this.Controls.SetChildIndex(this.cmb_Training, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.lbl_factory, 0);
			this.Controls.SetChildIndex(this.cmb_factory, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.cmb_Group, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.dpick_date_to, 0);
			this.Controls.SetChildIndex(this.dpick_date_from, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Training)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Group)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void cmb_Training_TextChanged(object sender, System.EventArgs e)
		{
			if(cmb_Training.SelectedIndex == -1) return;
			 
			txt_Training.Text = cmb_Training.Columns[1].Text;
		}

		private void Form_Training_Target_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Training Target";
			this.Text		   = "Training";


			// grid set
			fgrid_main.Set_Grid("SIM_TRAINING_TARGET", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.Cell;

			DataTable vDt;
				
			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;
			
			// cmb Group set
			vDt = Select_Group("SIM02");
			COM.ComCtl.Set_ComboList(vDt, cmb_Group , 0, 1, false);
			cmb_Group.SelectedValue    = ClassLib.ComVar.This_Factory;

			// cmb_Training set
			DataTable dt_ret = Select_TrainingList("");
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Training, 0, 1, false);


			txt_Training.Select();
		}
		private DataTable Select_Group(string com_cd)
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SCM_CODE.SELECT_COM_FILTER_CODE_LIST";

				MyOraDB.ReDim_Parameter(3); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = process_name;
 
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_COM_CD";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


				//03.DATA TYPE 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
				//04.DATA 정의   
				MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = com_cd;
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true);
 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}


		}

		private DataTable Select_TrainingList(string arg_t_name)
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SIM_MASTER.SELECT_SIM_TRAINING_LIST";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_T_NAME";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


			//03.DATA TYPE 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의   
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = arg_t_name;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		private void cmb_factory_Change(object sender, System.EventArgs e)
		{
			DataTable dt_ret = Select_TrainingList("");
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Training, 0, 1, false);
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
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, 1);

				fgrid_main[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
					fgrid_main[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
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
                
				string vProcedure     = "PKG_SIM_MASTER.SELECT_SIM_TRAINING_TARGET";

				DataTable vDt = SELECT_SIM_TRAINING_TARGET(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);

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
		public DataTable SELECT_SIM_TRAINING_TARGET(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_GRP_CODE";
			MyOraDB.Parameter_Name[ 3]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_Training, "");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Group, "");
			MyOraDB.Parameter_Values[ 3]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_CreateProcess();
		}

		private void Tbtn_CreateProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_MASTER.SELECT_SIM_CREATE_TARGET";

				DataTable vDt = SELECT_SIM_TRAINING_CREATE_TARGET(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);	
					for (int iRow = 0 ; iRow < vDt.Rows.Count ; iRow++)
					{				
						fgrid_main[iRow+3, 0] = "I";
					}

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
		
		public DataTable SELECT_SIM_TRAINING_CREATE_TARGET(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_GRP_CODE";
			MyOraDB.Parameter_Name[ 3]  = "ARG_DATE_FROM";
			MyOraDB.Parameter_Name[ 4]  = "ARG_DATE_TO";
			MyOraDB.Parameter_Name[ 5]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 5]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_Training, "________");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Group, "________");
			MyOraDB.Parameter_Values[ 3]   = dpick_date_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 4]   = dpick_date_to.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 5]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(ClassLib.ComFunction.User_Message("Do you want to save the changes you made?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				this.Tbtn_SaveProcess();			
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SIM_TRAINEE_TARGET(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();
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

		public bool SAVE_SIM_TRAINEE_TARGET(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 8;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIM_MASTER.SAVE_SIM_TRAINEE_TARGET";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";      
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";   
				MyOraDB.Parameter_Name[ 2] = "ARG_T_CODE";  
				MyOraDB.Parameter_Name[ 3] = "ARG_GRP_CODE";
				MyOraDB.Parameter_Name[ 4] = "ARG_MONTH"; 
				MyOraDB.Parameter_Name[ 5] = "ARG_TARGET";
				MyOraDB.Parameter_Name[ 6] = "ARG_REMARK";
				MyOraDB.Parameter_Name[ 7] = "ARG_UPDATE_USER";

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;
				
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if(fgrid_main[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
						MyOraDB.Parameter_Values[para_ct+ 2] = ClassLib.ComFunction.Empty_Combo(cmb_Training, "");
						MyOraDB.Parameter_Values[para_ct+ 3] = ClassLib.ComFunction.Empty_Combo(cmb_Group, "");
						MyOraDB.Parameter_Values[para_ct+ 4] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colMonth].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 5] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colTarget].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 6] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colRemark].ToString(),"");;
						MyOraDB.Parameter_Values[para_ct+ 7] = COM.ComVar.This_User;

						para_ct += iCount;	
					}				
				}

				MyOraDB.Add_Modify_Parameter(true);		
				
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

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;			
			fgrid_main.Update_Row(iRow);
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int sel_row = fgrid_main.Selection.r1;
			fgrid_main.Delete_Row(sel_row);
		}		

	}
}

