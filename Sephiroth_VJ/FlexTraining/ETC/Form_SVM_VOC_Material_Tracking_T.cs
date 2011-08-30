using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data; 
using System.Data.OracleClient;
using System.Threading;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;


namespace FlexTraining.ETC
{
	public class Form_SVM_VOC_Material_Tracking_T : COM.TrainingWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.TextBox txt_Item_CD;
		private C1.Win.C1List.C1Combo cmb_Item;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private C1.Win.C1List.C1Combo cmb_Line;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_Process;		
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_Dep;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label btn_CreateDefective;

		private COM.ComFunction MyComFunction = new COM.ComFunction(); 
		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Level_Total = 1;
		private int _Rowfixed=0;

		private string _OutStatus = "";
		private string _OutStatus_Confirm = "C";
		private System.Windows.Forms.DateTimePicker dpick_Out_Date; 
		private string _OutStatus_Save = "S"; 

		public Form_SVM_VOC_Material_Tracking_T()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_SVM_VOC_Material_Tracking_T));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.dpick_Out_Date = new System.Windows.Forms.DateTimePicker();
			this.txt_Item_CD = new System.Windows.Forms.TextBox();
			this.cmb_Item = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmb_Line = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.lbl_Dep = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.fgrid_main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Item)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.Controls.Add(this.fgrid_main);
			this.c1Sizer1.GridDefinition = "17.9310344827586:False:True;81.3793103448276:False:False;\t0.393700787401575:False" +
				":True;98.4251968503937:False:False;0.393700787401575:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(-8, 56);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
			this.c1Sizer1.TabIndex = 29;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.dpick_Out_Date);
			this.pnl_head.Controls.Add(this.txt_Item_CD);
			this.pnl_head.Controls.Add(this.cmb_Item);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.label6);
			this.pnl_head.Controls.Add(this.cmb_Line);
			this.pnl_head.Controls.Add(this.cmb_Factory);
			this.pnl_head.Controls.Add(this.lbl_factory);
			this.pnl_head.Controls.Add(this.lbl_Dep);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Location = new System.Drawing.Point(8, 0);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1000, 104);
			this.pnl_head.TabIndex = 1;
			// 
			// dpick_Out_Date
			// 
			this.dpick_Out_Date.CustomFormat = "";
			this.dpick_Out_Date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_Out_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Out_Date.Location = new System.Drawing.Point(504, 39);
			this.dpick_Out_Date.Name = "dpick_Out_Date";
			this.dpick_Out_Date.Size = new System.Drawing.Size(107, 22);
			this.dpick_Out_Date.TabIndex = 618;
			// 
			// txt_Item_CD
			// 
			this.txt_Item_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Item_CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Item_CD.Location = new System.Drawing.Point(504, 64);
			this.txt_Item_CD.MaxLength = 5;
			this.txt_Item_CD.Name = "txt_Item_CD";
			this.txt_Item_CD.Size = new System.Drawing.Size(106, 21);
			this.txt_Item_CD.TabIndex = 617;
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
			this.cmb_Item.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Item.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Item.EditorHeight = 17;
			this.cmb_Item.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Item.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Item.GapHeight = 2;
			this.cmb_Item.ItemHeight = 15;
			this.cmb_Item.Location = new System.Drawing.Point(608, 64);
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
			this.cmb_Item.TabIndex = 616;
			this.cmb_Item.Visible = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(400, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 615;
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
			this.label6.Location = new System.Drawing.Point(400, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 614;
			this.label6.Text = "Out Date";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Line.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Line.EditorHeight = 17;
			this.cmb_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Line.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line.GapHeight = 2;
			this.cmb_Line.ItemHeight = 15;
			this.cmb_Line.Location = new System.Drawing.Point(120, 64);
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
			this.cmb_Line.TabIndex = 612;
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
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(120, 40);
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
			this.cmb_Factory.TabIndex = 610;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(16, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 611;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Dep
			// 
			this.lbl_Dep.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Dep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Dep.ImageIndex = 0;
			this.lbl_Dep.ImageList = this.img_Label;
			this.lbl_Dep.Location = new System.Drawing.Point(16, 64);
			this.lbl_Dep.Name = "lbl_Dep";
			this.lbl_Dep.Size = new System.Drawing.Size(100, 21);
			this.lbl_Dep.TabIndex = 609;
			this.lbl_Dep.Text = "Line";
			this.lbl_Dep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(984, 88);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 87);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(960, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(899, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 63);
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
			this.label2.Text = "            Search Info.";
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
			this.pic_head5.Location = new System.Drawing.Point(0, 88);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 77);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(8, 108);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(1000, 472);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 13;
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// Form_SVM_VOC_Material_Tracking_T
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_SVM_VOC_Material_Tracking_T";
			this.Load += new System.EventHandler(this.Form_SVM_VOC_Material_Tracking_T_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Item)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_SVM_VOC_Material_Tracking_T_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "VOC Material Tracking";
			this.Text		   = "VOC Material Tracking";
			fgrid_main.Set_Grid("SVM_VOC_MATERIAL_TRACKING_T", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			
//			fgrid_main.Rows[0].AllowMerging = true;			

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";
			
			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveDown;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.Cell;
			
//			fgrid_main.Cols[14].Style.ForeColor = Color.Red; 

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

			fgrid_main.Cols[14].Format = "###,###,##0.########";
			fgrid_main.Cols[15].Format = "###,###,##0.########";
			fgrid_main.Cols[16].Format = "###,###,##0.########";

			this.tbtn_New.Enabled = false ;
			this.tbtn_Insert.Enabled = false;
			this.tbtn_Append.Enabled = false;
			this.tbtn_Delete.Enabled = false;
			this.tbtn_Delete.Enabled = false;
			this.tbtn_Create.Enabled = false;
			this.tbtn_Color.Enabled = false;
			this.tbtn_Confirm.Enabled = false;


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
			fgrid_main.Clear();
			fgrid_main.Set_Grid("SVM_VOC_MATERIAL_TRACKING_T", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_main.Set_Action_Image(img_Action);
		
			if(cmb_Line.SelectedIndex == 0) 
				return;
			else
				Tbtn_SearchProcess();
		}

		private void Tbtn_SearchProcess()
		{
			try
			{

				this.Cursor = Cursors.WaitCursor;


//				if(cmb_Process.SelectedIndex == -1 || cmb_Line.SelectedIndex == -1) return;
				if(cmb_Line.SelectedIndex == -1) return;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_Line};   
				bool essential_check = FlexTraining.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;


				string factory = cmb_Factory.SelectedValue.ToString(); 
//				string out_division = cmb_OutDiv.SelectedValue.ToString(); 
//				string out_ymd_from = MyComFunction.ConvertDate2DbType(dpick_Out_Date.Value.ToString());
				string out_ymd_from = dpick_Out_Date.Value.ToString("yyyyMMdd");
//				string out_ymd_to = MyComFunction.ConvertDate2DbType(dpick_ToDate.Text); 
				string process =""; 
				string line = cmb_Line.SelectedValue.ToString(); 
				

				DataTable dt_ret = SELECT_VOC_TRACKING(factory,out_ymd_from, process, line);

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed; 
			

				if(dt_ret.Rows.Count == 0) 
				{  
					_OutStatus = _OutStatus_Save;
//					EnableControlCheckProcess(); 

					return;  
				}

				Display_Grid(dt_ret); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		private DataTable SELECT_VOC_TRACKING(string arg_factory, 			
			string arg_out_ymd_from, 		
			string arg_process, 
			string arg_line)
		{

			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_VOC_TRACKING.SELECT_SVM_VOC_MAT_TRACK_T";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_LINE";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";  

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_out_ymd_from;
			MyOraDB.Parameter_Values[2] = arg_line;
			MyOraDB.Parameter_Values[3] = arg_process;
			MyOraDB.Parameter_Values[4] = "";  

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null; 

			return ds_ret.Tables[MyOraDB.Process_Name];


		}

		private void Display_Grid(DataTable arg_dt)
		{

			int row_fixed = fgrid_main.Rows.Fixed;
			int level = 0; 

			for (int i = 0 ; i < arg_dt.Rows.Count ; i++)
			{

				level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxTREE_LEVEL - 1].ToString() );
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


				_OutStatus = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxCOL_SPEC_NAME - 1].ToString();
				

			}


			fgrid_main.Tree.Column = (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxCOL_ITEM_NAME; 
//			rad_Header.Checked = true;
			fgrid_main.Tree.Show(_Level_Total);



//			EnableControlCheckProcess();

			GridSetColor();

		}

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;

			double Iconsum ;
			double Irealusing;

			if ((fgrid_main[iRow, 15] == null) ||
				(fgrid_main[iRow, 15].ToString().Equals("")))
				fgrid_main[iRow, 15] = "0";

			this.Grid_AfterEditProcess();

			if (fgrid_main.Selection.c1 == 15)
			{
				Iconsum = Convert.ToDouble(fgrid_main[iRow,14].ToString());
				Irealusing = Convert.ToDouble(fgrid_main[iRow,15].ToString());

				fgrid_main[iRow, 16] = Convert.ToString(Irealusing - Iconsum);

				GridSetColor();
			}
		}
		private void Grid_AfterEditProcess()
		{
			fgrid_main.Update_Row();
		}
		private void GridSetColor()
		{
			try
			{				
				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if ((fgrid_main[iRow, 16] == null)||(fgrid_main[iRow, 16].ToString() == "")||
						(fgrid_main[iRow, 16].ToString() == "0"))
						 fgrid_main[iRow, 16] = "0";
					
//					{
//						if ((fgrid_main[iRow, 9].ToString()== "")||(fgrid_main[iRow, 9] == null))
//							fgrid_main[iRow, 16] = "";
//						else						
//							fgrid_main[iRow, 16] = "0";					
//					}
					
					if (!fgrid_main[iRow, 16].ToString().Equals(""))
					{
						if (Convert.ToDouble(fgrid_main[iRow, 16].ToString())== 0)
							fgrid_main.GetCellRange(iRow, 16).StyleNew.ForeColor = Color.Black;
						else
							fgrid_main.GetCellRange(iRow, 16).StyleNew.ForeColor = Color.Red;
					}					
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
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

				if (SAVE_SVM_VOC_T(true))
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

		public bool SAVE_SVM_VOC_T(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 15;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SVM_VOC_TRACKING.SAVE_SVM_VOC_MAT_TRACK_T";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_PROD_YMD";
				MyOraDB.Parameter_Name[ 3] = "ARG_LINE_CD";				
				MyOraDB.Parameter_Name[ 4] = "ARG_GROUP1";
				MyOraDB.Parameter_Name[ 5] = "ARG_GROUP2";
				MyOraDB.Parameter_Name[ 6] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[ 7] = "ARG_ITEM_NAME";
				MyOraDB.Parameter_Name[ 8] = "ARG_PROD_QTY";
				MyOraDB.Parameter_Name[ 9] = "ARG_YIED";			
				MyOraDB.Parameter_Name[10] = "ARG_CONSUM";
				MyOraDB.Parameter_Name[11] = "ARG_REAL_USING";
				MyOraDB.Parameter_Name[12] = "ARG_OVER_USING";				
				MyOraDB.Parameter_Name[13] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[14] = "ARG_UPD_USER";

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
						MyOraDB.Parameter_Values[para_ct+ 1] = cmb_Factory.SelectedValue.ToString(); 
						MyOraDB.Parameter_Values[para_ct+ 2] = dpick_Out_Date.Value.ToString("yyyyMMdd"); 
						MyOraDB.Parameter_Values[para_ct+ 3] = cmb_Line.SelectedValue.ToString(); 
						MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main[iRow, 9].ToString();												
						MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main[iRow, 10].ToString();
						MyOraDB.Parameter_Values[para_ct+ 6] = fgrid_main[iRow, 19].ToString();
						MyOraDB.Parameter_Values[para_ct+ 7] = fgrid_main[iRow, 11].ToString();
						MyOraDB.Parameter_Values[para_ct+ 8] = fgrid_main[iRow, 12].ToString();
						MyOraDB.Parameter_Values[para_ct+ 9] = fgrid_main[iRow, 13].ToString();
						MyOraDB.Parameter_Values[para_ct+10] = fgrid_main[iRow, 14].ToString();
						MyOraDB.Parameter_Values[para_ct+11] = fgrid_main[iRow, 15].ToString();
						MyOraDB.Parameter_Values[para_ct+12] = fgrid_main[iRow, 16].ToString();
						
						MyOraDB.Parameter_Values[para_ct+13] = "";

						MyOraDB.Parameter_Values[para_ct+14] = COM.ComVar.This_User;

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
				PRINT_SVM_VOC_MAT_TRACK_T();
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

		private void PRINT_SVM_VOC_MAT_TRACK_T()
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

//		private void EnableControlCheckProcess()
//		{
//
//			// 재고마감 여부 
//			
//
//			// 1. btn_CreateDefective 권한은 cmb_outdiv 에 의해 변경되어짐
//			// 2. 현장 부서의 조회만을 위한 Role 일 경우, tbtn_Save.Enabled 여부로 기타 버튼 권한 재 설정
//			//    -> tbtn_Delete, tbtn_Confirm 버튼은 tbtn_Save 와 동일 권한으로 이루어 지므로 대상에서 제외
//
//			if(_OutStatus == _OutStatus_Confirm)
//			{
// 
//				tbtn_Delete.Enabled = false;
//				tbtn_Confirm.Enabled = true;
//				 
//				btn_CreateDefective.Enabled = false;
//				btn_Usage.Enabled = false;
//
//				fgrid_main.AllowEditing = false; 
//
//			}
//			else if(_OutStatus == _OutStatus_Save)
//			{
// 
//				if(! tbtn_Save.Enabled) 
//				{
//					 
//					tbtn_Delete.Enabled = false;
//					tbtn_Confirm.Enabled = false;
//					btn_CreateDefective.Enabled = false;
//					btn_Usage.Enabled = false; 
//					fgrid_main.AllowEditing = false; 
//
//					return;
//				}
//
//
//				 
//				if(ClassLib.ComVar.This_InsaCd == "Y")
//				{
//					tbtn_Delete.Enabled = true;
//					tbtn_Confirm.Enabled = true; 
//				}
//				else
//				{
//					tbtn_Delete.Enabled = false;
//					tbtn_Confirm.Enabled = false; 
//				}
//
//				if(cmb_OutDiv.SelectedIndex == -1)
//				{
//					btn_CreateDefective.Enabled = false;
//				}
//				else
//				{
//					if(cmb_OutDiv.SelectedValue.ToString() == _OutDiv_Normal)
//					{
//						btn_CreateDefective.Enabled = false;
//					}
//					else
//					{
//						btn_CreateDefective.Enabled = true;
//					}
//				}
//
//
//				btn_Usage.Enabled = true;
//
//				fgrid_main.AllowEditing = true;  
//
//
//			} 
 
//		}


	}
}

