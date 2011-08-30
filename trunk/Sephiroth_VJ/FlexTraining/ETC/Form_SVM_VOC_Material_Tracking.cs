using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data; 
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Threading;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;


namespace FlexTraining.ETC
{
	public class Form_SVM_VOC_Material_Tracking : COM.TrainingWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txt_Item_CD;
		private C1.Win.C1List.C1Combo cmb_Item;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dpick_Out_Date;
		public System.Windows.Forms.PictureBox picb_BR;
		private C1.Win.C1List.C1Combo cmb_Line;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.Label lbl_Dep;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.ComponentModel.IContainer components = null;

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Panel panel2;

		private int _Level_Total = 1;
		private string _OutStatus = "";
		private int _Rowfixed=0;

		public Form_SVM_VOC_Material_Tracking()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_SVM_VOC_Material_Tracking));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txt_Item_CD = new System.Windows.Forms.TextBox();
			this.cmb_Item = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dpick_Out_Date = new System.Windows.Forms.DateTimePicker();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.cmb_Line = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.lbl_Dep = new System.Windows.Forms.Label();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Item)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
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
			this.c1Sizer1.Controls.Add(this.pnl_Search);
			this.c1Sizer1.Controls.Add(this.statusBar1);
			this.c1Sizer1.GridDefinition = "16.4473684210526:False:True;79.1118421052632:False:False;0.822368421052632:False:" +
				"True;3.61842105263158:False:True;\t0.784313725490196:False:True;98.1372549019608:" +
				"False:False;1.07843137254902:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(-2, 56);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1020, 608);
			this.c1Sizer1.SplitterWidth = 0;
			this.c1Sizer1.TabIndex = 35;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel2.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.panel2.Location = new System.Drawing.Point(8, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1001, 481);
			this.panel2.TabIndex = 46;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(1001, 481);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 34;
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			this.fgrid_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyUp);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.panel3);
			this.pnl_Search.DockPadding.All = 7;
			this.pnl_Search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Search.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.pnl_Search.Location = new System.Drawing.Point(0, 0);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1020, 100);
			this.pnl_Search.TabIndex = 45;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.txt_Item_CD);
			this.panel3.Controls.Add(this.cmb_Item);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.dpick_Out_Date);
			this.panel3.Controls.Add(this.picb_BR);
			this.panel3.Controls.Add(this.cmb_Line);
			this.panel3.Controls.Add(this.cmb_Factory);
			this.panel3.Controls.Add(this.lbl_factory);
			this.panel3.Controls.Add(this.picb_TM);
			this.panel3.Controls.Add(this.lbl_SubTitle1);
			this.panel3.Controls.Add(this.lbl_Dep);
			this.panel3.Controls.Add(this.picb_TR);
			this.panel3.Controls.Add(this.picb_BM);
			this.panel3.Controls.Add(this.picb_BL);
			this.panel3.Controls.Add(this.picb_ML);
			this.panel3.Controls.Add(this.pictureBox6);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel3.Location = new System.Drawing.Point(7, 7);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1006, 86);
			this.panel3.TabIndex = 18;
			// 
			// txt_Item_CD
			// 
			this.txt_Item_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Item_CD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Item_CD.Location = new System.Drawing.Point(493, 56);
			this.txt_Item_CD.MaxLength = 5;
			this.txt_Item_CD.Name = "txt_Item_CD";
			this.txt_Item_CD.Size = new System.Drawing.Size(106, 21);
			this.txt_Item_CD.TabIndex = 608;
			this.txt_Item_CD.Text = "";
			this.txt_Item_CD.Visible = false;
			// 
			// cmb_Item
			// 
			this.cmb_Item.AddItemCols = 0;
			this.cmb_Item.AddItemSeparator = ';';
			this.cmb_Item.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Item.AutoSize = false;
			this.cmb_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Item.Caption = "";
			this.cmb_Item.CaptionHeight = 17;
			this.cmb_Item.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Item.ColumnCaptionHeight = 18;
			this.cmb_Item.ColumnFooterHeight = 18;
			this.cmb_Item.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Item.ContentHeight = 17;
			this.cmb_Item.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Item.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Item.EditorFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Item.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Item.EditorHeight = 17;
			this.cmb_Item.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Item.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Item.GapHeight = 2;
			this.cmb_Item.ItemHeight = 15;
			this.cmb_Item.Location = new System.Drawing.Point(600, 56);
			this.cmb_Item.MatchEntryTimeout = ((long)(2000));
			this.cmb_Item.MaxDropDownItems = ((short)(5));
			this.cmb_Item.MaxLength = 32767;
			this.cmb_Item.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Item.Name = "cmb_Item";
			this.cmb_Item.PartialRightColumn = false;
			this.cmb_Item.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
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
			this.cmb_Item.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Item.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Item.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Item.Size = new System.Drawing.Size(192, 21);
			this.cmb_Item.TabIndex = 607;
			this.cmb_Item.Visible = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(391, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 606;
			this.label1.Text = "Item";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Visible = false;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ImageIndex = 0;
			this.label6.ImageList = this.img_Label;
			this.label6.Location = new System.Drawing.Point(391, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 605;
			this.label6.Text = "Out Date";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_Out_Date
			// 
			this.dpick_Out_Date.CustomFormat = "";
			this.dpick_Out_Date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_Out_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Out_Date.Location = new System.Drawing.Point(493, 32);
			this.dpick_Out_Date.Name = "dpick_Out_Date";
			this.dpick_Out_Date.Size = new System.Drawing.Size(107, 22);
			this.dpick_Out_Date.TabIndex = 604;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.picb_BR.Location = new System.Drawing.Point(992, 71);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(13, 15);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// cmb_Line
			// 
			this.cmb_Line.AddItemCols = 0;
			this.cmb_Line.AddItemSeparator = ';';
			this.cmb_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Line.AutoSize = false;
			this.cmb_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Line.Caption = "";
			this.cmb_Line.CaptionHeight = 17;
			this.cmb_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Line.ColumnCaptionHeight = 18;
			this.cmb_Line.ColumnFooterHeight = 18;
			this.cmb_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Line.ContentHeight = 17;
			this.cmb_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Line.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Line.EditorFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Line.EditorHeight = 17;
			this.cmb_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Line.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line.GapHeight = 2;
			this.cmb_Line.ItemHeight = 15;
			this.cmb_Line.Location = new System.Drawing.Point(109, 56);
			this.cmb_Line.MatchEntryTimeout = ((long)(2000));
			this.cmb_Line.MaxDropDownItems = ((short)(5));
			this.cmb_Line.MaxLength = 32767;
			this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Line.Name = "cmb_Line";
			this.cmb_Line.PartialRightColumn = false;
			this.cmb_Line.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
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
			this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Line.Size = new System.Drawing.Size(235, 21);
			this.cmb_Line.TabIndex = 567;
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.AutoSize = false;
			this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory.Caption = "";
			this.cmb_Factory.CaptionHeight = 17;
			this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory.ColumnCaptionHeight = 18;
			this.cmb_Factory.ColumnFooterHeight = 18;
			this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(109, 34);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(235, 21);
			this.cmb_Factory.TabIndex = 151;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 34);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 152;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(771, 28);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      Search Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Dep
			// 
			this.lbl_Dep.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Dep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Dep.ImageIndex = 0;
			this.lbl_Dep.ImageList = this.img_Label;
			this.lbl_Dep.Location = new System.Drawing.Point(8, 56);
			this.lbl_Dep.Name = "lbl_Dep";
			this.lbl_Dep.Size = new System.Drawing.Size(100, 21);
			this.lbl_Dep.TabIndex = 149;
			this.lbl_Dep.Text = "Line";
			this.lbl_Dep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Location = new System.Drawing.Point(990, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(24, 67);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Location = new System.Drawing.Point(123, 70);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(870, 17);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Location = new System.Drawing.Point(0, 71);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(144, 19);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Location = new System.Drawing.Point(0, 22);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(144, 55);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Location = new System.Drawing.Point(137, 22);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(904, 48);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(137, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(86, 22);
			this.textBox1.TabIndex = 145;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(392, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 21);
			this.label2.TabIndex = 155;
			this.label2.Text = "Training";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// statusBar1
			// 
			this.statusBar1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar1.Location = new System.Drawing.Point(0, 100);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.Size = new System.Drawing.Size(1020, 508);
			this.statusBar1.TabIndex = 43;
			// 
			// Form_SVM_VOC_Material_Tracking
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_SVM_VOC_Material_Tracking";
			this.Load += new System.EventHandler(this.Form_SVM_VOC_Material_Tracking_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Item)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_SVM_VOC_Material_Tracking_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			this.tbtn_Confirm.Visible = false;
			this.tbtn_Delete.Visible = false;
			this.tbtn_Create.Visible  = false;
//			this.tbtn_New.Visible = false; 
		}
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "VOC Material Tracking";
			this.Text		   = "VOC Material Tracking";
			fgrid_main.Set_Grid("SVM_VOC_MATERIAL_TRACKING", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveDown;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.Cell;
			
			fgrid_main.Cols[14].Style.ForeColor = Color.Red; 

			DataTable vDt;
			
			//=========== Set Combobox: Begin =================================

			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_Factory.SelectedValue    = ClassLib.ComVar.This_Factory;	

			// Line
			vDt = SELECT_LINE_INFO();
			COM.ComCtl.Set_ComboList(vDt, cmb_Line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Line.SelectedIndex = 0;

			// Item
			txt_Item_CD.Text = "";
			vDt = SELECT_SVM_VOC_ITEM();
			COM.ComCtl.Set_ComboList(vDt, cmb_Item, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Item.SelectedIndex = 0;

			fgrid_main.Cols[12].Format = "###,###,##0.########";
			fgrid_main.Cols[13].Format = "###,###,##0.########";
			fgrid_main.Cols[14].Format = "###,###,##0.########";


		}

		public DataTable SELECT_LINE_INFO()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SBM_LLT_PLAN_TRACKING.SELECT_LINE_INFO";

				MyOraDB.ReDim_Parameter(2);  
				MyOraDB.Process_Name = process_name;
   

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
				MyOraDB.Parameter_Values[1] = ""; 

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
		
		public DataTable SELECT_SVM_VOC_ITEM()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SVM_VOC_TRACKING.SELECT_SVM_VOC_ITEM";

				MyOraDB.ReDim_Parameter(3);  
				MyOraDB.Process_Name = process_name;
   

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_ITEM_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
				MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_Item, "");
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

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
			
		}
		private void Tbtn_SearchProcess()
		{
			try
			{
				string vProcedure   = "PKG_SVM_VOC_TRACKING.SELECT_SVM_VOC_MAT_TRACK";

				DataTable vDt = SELECT_SVM_VOC_TRACKING(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);
					GridSetColor();
//					Display_Grid(vDt);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
					fgrid_main.Cols.Frozen = 7 ;
					
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

		public DataTable SELECT_SVM_VOC_TRACKING(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_OUT_YMD";
			MyOraDB.Parameter_Name[ 2]  = "ARG_OUT_LINE";
			MyOraDB.Parameter_Name[ 3]  = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[ 4]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			MyOraDB.Parameter_Values[ 1]   = dpick_Out_Date.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Line, "");
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_Combo(cmb_Item, "");
			MyOraDB.Parameter_Values[ 4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void Clear_FlexGrid()
		{
			if (_Rowfixed != fgrid_main.Rows.Count)
			{				
				fgrid_main.Clear(ClearFlags.UserData, _Rowfixed, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				fgrid_main.Rows.Count = _Rowfixed;
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

		private void fgrid_main_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
//			if (fgrid_main.ColSel == 13)
//			{
//				if ((e.KeyData ==Keys.Down)||(e.KeyData==Keys.Enter))
//				{
//					fgrid_main[fgrid_main.RowSel-1,0]="U";					
//				}
//			}
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;

			double Iconsum ;
			double Irealusing;

			if ((fgrid_main[iRow, 13] == null) ||
			    (fgrid_main[iRow, 13].ToString().Equals("")))
					fgrid_main[iRow, 13] = "0";

			this.Grid_AfterEditProcess();

			if (fgrid_main.Selection.c1 == 13)
			{
				Iconsum = Convert.ToDouble(fgrid_main[iRow,12].ToString());
				Irealusing = Convert.ToDouble(fgrid_main[iRow,13].ToString());

				fgrid_main[iRow, 14] = Convert.ToString(Irealusing - Iconsum);

				GridSetColor();
			}
						
		}

		private void GridSetColor()
		{
			try
			{				
				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if ((fgrid_main[iRow, 14] == null)||
					    (fgrid_main[iRow, 14].ToString() == "")||
						(fgrid_main[iRow, 14].ToString() == "0"))
						fgrid_main[iRow, 14] = "0";

					if (Convert.ToDouble(fgrid_main[iRow, 14].ToString())<0)
						fgrid_main.GetCellRange(iRow, 14).StyleNew.ForeColor = Color.Black;
					else
						fgrid_main.GetCellRange(iRow, 14).StyleNew.ForeColor = Color.Red;
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}

		private void Grid_AfterEditProcess()
		{
			fgrid_main.Update_Row();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
			{
				this.Tbtn_SaveProcess();					
			}
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SVM_VOC(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();
					//MessageBox.Show("Create Complete","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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

		public bool SAVE_SVM_VOC(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 17;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SVM_VOC_TRACKING.SAVE_SVM_VOC_MAT_TRACK";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_PROD_YMD";
				MyOraDB.Parameter_Name[ 3] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[ 4] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[ 5] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[ 6] = "ARG_GROUP1";
				MyOraDB.Parameter_Name[ 7] = "ARG_GROUP2";
				MyOraDB.Parameter_Name[ 8] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[ 9] = "ARG_ITEM_NAME";
				MyOraDB.Parameter_Name[10] = "ARG_PROD_QTY";
				MyOraDB.Parameter_Name[11] = "ARG_YIED";			
				MyOraDB.Parameter_Name[12] = "ARG_CONSUM";
				MyOraDB.Parameter_Name[13] = "ARG_REAL_USING";
				MyOraDB.Parameter_Name[14] = "ARG_OVER_USING";				
				MyOraDB.Parameter_Name[15] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if(fgrid_main[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = "VJ";
						MyOraDB.Parameter_Values[para_ct+ 2] = dpick_Out_Date.Value.ToString("yyyyMMdd"); 
						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow, 3].ToString();
						MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main[iRow, 1].ToString();

						MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main[iRow, 5].ToString().Replace("-","");
						
						MyOraDB.Parameter_Values[para_ct+ 6] = fgrid_main[iRow, 6].ToString();

						MyOraDB.Parameter_Values[para_ct+ 7] = fgrid_main[iRow, 7].ToString();
						MyOraDB.Parameter_Values[para_ct+ 8] = fgrid_main[iRow, 9].ToString();
						MyOraDB.Parameter_Values[para_ct+ 9] = fgrid_main[iRow, 8].ToString();
						MyOraDB.Parameter_Values[para_ct+10] = fgrid_main[iRow, 10].ToString();
						MyOraDB.Parameter_Values[para_ct+11] = fgrid_main[iRow, 11].ToString();
						MyOraDB.Parameter_Values[para_ct+12] = fgrid_main[iRow, 12].ToString();
						MyOraDB.Parameter_Values[para_ct+13] = fgrid_main[iRow, 13].ToString();
						MyOraDB.Parameter_Values[para_ct+14] = fgrid_main[iRow, 14].ToString();
						
						MyOraDB.Parameter_Values[para_ct+15] = "";

						MyOraDB.Parameter_Values[para_ct+16] = COM.ComVar.This_User;

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

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}
		private void Tbtn_PrintProcess()
		{
			try
			{
				PRINT_SVM_VOC_MAT_TRACK();
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
		private void PRINT_SVM_VOC_MAT_TRACK()
		{
			string sDir;
			
			sDir = FlexTraining.ClassLib.ComFunction.Set_RD_Directory("Form_SVM_VOC_MAT_TRACK");

			string sPara;

			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			MyOraDB.Parameter_Values[ 1]   = dpick_Out_Date.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Line, "");
		
			sPara  = " /rp ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_Factory, "") +	"' ";			            //Parm1: Factory
			sPara += "'" + dpick_Out_Date.Value.ToString("yyyyMMdd") +	"' ";						        //Parm2: Out Date
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_Line, "") +	"' ";							//Parm3: Out Line
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_Item, "") +	"' ";							//Parm4: Item
		
			FlexTraining.Report.Form_RdViewer MyReport = new FlexTraining.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "VOC Material Tracking";
			MyReport.Show();
				
		}

		private void Display_Grid(DataTable arg_dt)
		{

			int row_fixed = fgrid_main.Rows.Fixed;
			int level = 0; 

			for (int i = 0 ; i < arg_dt.Rows.Count ; i++)
			{

				level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxTREE_LEVEL - 1].ToString() );
//				level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxTREE_LEVEL + 5].ToString() );
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(row_fixed + i, level);

				// data setting
				fgrid_main[newRow.Row.Index, 0] = "";
				for (int j = 0 ; j < arg_dt.Columns.Count ; j++)
				{
					fgrid_main[newRow.Row.Index, j + 1] = arg_dt.Rows[i].ItemArray[j];
				}
 

				// design setting
				if (level == _Level_Total)  // SubTotal 
				{

					newRow.Row.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
					newRow.Row.AllowEditing = true; 

				}
				else
				{
					newRow.Row.AllowEditing = false;
					newRow.Row.StyleNew.BackColor = Color.White;
				}


				// 현재 출고 데이터 상태값
				//				if(_OutStatus.Trim().Equals("") )
				//				{
				//					_OutStatus = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_STATUS - 1].ToString();
				//				}


				_OutStatus = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_STATUS - 1].ToString();


			}


			fgrid_main.Tree.Column = (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxCOL_ITEM_NAME; 
//			rad_Header.Checked = true;
			fgrid_main.Tree.Show(_Level_Total);


//			EnableControlCheckProcess();

		}
		private void SubTotalGrid()
		{
			fgrid_main.Subtotal(AggregateEnum.Clear);
			fgrid_main.SubtotalPosition = SubtotalPositionEnum.BelowData;
			//fgrid_Search.Subtotal(AggregateEnum.Sum, -1,-1, 4, "GTotal");
			//			fgrid_Search.Subtotal(AggregateEnum.Sum, -1,-1, 9, "GTotal");
			//			fgrid_Search.Subtotal(AggregateEnum.Sum, -1,-1, 23, "GTotal");
			//			fgrid_Search.Subtotal(AggregateEnum.Sum, -1,-1, 24, "GTotal");
			
			//			fgrid_Search.Subtotal(AggregateEnum.Sum, 0,1, 4, "STotal");
			fgrid_main.Subtotal(AggregateEnum.Sum, 0, 1, 12, "STotal");			 
			//			fgrid_Search.Subtotal(AggregateEnum.Sum, 0,1, 9, "STotal");
			//			fgrid_Search.Subtotal(AggregateEnum.Sum, 0,1, 23, "STotal");
			//			fgrid_Search.Subtotal(AggregateEnum.Sum, 0,1, 24, "STotal");

		}
		
		
	}
}

