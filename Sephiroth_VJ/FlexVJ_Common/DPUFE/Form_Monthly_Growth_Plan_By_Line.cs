using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 

namespace FlexVJ_Common.DPUFE
{
	public class Form_Monthly_Growth_Plan_By_Line : COM.VJ_CommonWinForm.Pop_Large
	{
		private System.ComponentModel.IContainer components = null;

		public Form_Monthly_Growth_Plan_By_Line()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
			Init_Form();
			Init_Control();
			Init_Object();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Monthly_Growth_Plan_By_Line));
			this.pnl_head = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_date_to = new System.Windows.Forms.DateTimePicker();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.lbl_HeaderTitle = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.txt_Year = new System.Windows.Forms.TextBox();
			this.dpick_date_from = new System.Windows.Forms.DateTimePicker();
			this.lbl_Season = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.cbm_Season = new C1.Win.C1List.C1Combo();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.fgrid_Growth_Plan = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbm_Season)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Growth_Plan)).BeginInit();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(465, 4);
			this.c1ToolBar1.Name = "c1ToolBar1";
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(506, 22);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// pnl_head
			// 
			this.pnl_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.dpick_date_to);
			this.pnl_head.Controls.Add(this.lbl_PlanYMD);
			this.pnl_head.Controls.Add(this.lbl_HeaderTitle);
			this.pnl_head.Controls.Add(this.pictureBox4);
			this.pnl_head.Controls.Add(this.txt_Year);
			this.pnl_head.Controls.Add(this.dpick_date_from);
			this.pnl_head.Controls.Add(this.lbl_Season);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.cmb_Factory);
			this.pnl_head.Controls.Add(this.lbl_Factory);
			this.pnl_head.Controls.Add(this.pictureBox2);
			this.pnl_head.Controls.Add(this.pictureBox3);
			this.pnl_head.Controls.Add(this.cbm_Season);
			this.pnl_head.Controls.Add(this.pictureBox5);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Location = new System.Drawing.Point(8, 80);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(736, 94);
			this.pnl_head.TabIndex = 30;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.label1.Location = new System.Drawing.Point(208, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 8);
			this.label1.TabIndex = 567;
			this.label1.Text = "~";
			// 
			// dpick_date_to
			// 
			this.dpick_date_to.CustomFormat = "yyyy-MM-dd";
			this.dpick_date_to.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_to.Location = new System.Drawing.Point(232, 64);
			this.dpick_date_to.Name = "dpick_date_to";
			this.dpick_date_to.Size = new System.Drawing.Size(88, 21);
			this.dpick_date_to.TabIndex = 566;
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_PlanYMD.ImageIndex = 1;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(8, 64);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(104, 24);
			this.lbl_PlanYMD.TabIndex = 543;
			this.lbl_PlanYMD.Text = "Plan Month";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_HeaderTitle
			// 
			this.lbl_HeaderTitle.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_HeaderTitle.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_HeaderTitle.ForeColor = System.Drawing.Color.Navy;
			this.lbl_HeaderTitle.Image = ((System.Drawing.Image)(resources.GetObject("lbl_HeaderTitle.Image")));
			this.lbl_HeaderTitle.Location = new System.Drawing.Point(1, 0);
			this.lbl_HeaderTitle.Name = "lbl_HeaderTitle";
			this.lbl_HeaderTitle.Size = new System.Drawing.Size(198, 28);
			this.lbl_HeaderTitle.TabIndex = 393;
			this.lbl_HeaderTitle.Text = "      Search Information";
			this.lbl_HeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(8, 77);
			this.pictureBox4.TabIndex = 41;
			this.pictureBox4.TabStop = false;
			// 
			// txt_Year
			// 
			this.txt_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Year.Location = new System.Drawing.Point(624, 40);
			this.txt_Year.MaxLength = 2;
			this.txt_Year.Name = "txt_Year";
			this.txt_Year.Size = new System.Drawing.Size(24, 21);
			this.txt_Year.TabIndex = 565;
			this.txt_Year.Text = "";
			this.txt_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_Year.WordWrap = false;
			this.txt_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Year_KeyPress);
			this.txt_Year.Leave += new System.EventHandler(this.txt_Year_Leave);
			// 
			// dpick_date_from
			// 
			this.dpick_date_from.CustomFormat = "yyyy-MM-dd";
			this.dpick_date_from.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_from.Location = new System.Drawing.Point(112, 64);
			this.dpick_date_from.Name = "dpick_date_from";
			this.dpick_date_from.Size = new System.Drawing.Size(88, 21);
			this.dpick_date_from.TabIndex = 564;
			this.dpick_date_from.ValueChanged += new System.EventHandler(this.dpick_date_from_ValueChanged);
			// 
			// lbl_Season
			// 
			this.lbl_Season.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Season.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Season.ImageIndex = 1;
			this.lbl_Season.ImageList = this.img_Label;
			this.lbl_Season.Location = new System.Drawing.Point(368, 39);
			this.lbl_Season.Name = "lbl_Season";
			this.lbl_Season.Size = new System.Drawing.Size(104, 24);
			this.lbl_Season.TabIndex = 405;
			this.lbl_Season.Text = "Season";
			this.lbl_Season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(722, 79);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(14, 15);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(117, 78);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(701, 17);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
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
			this.cmb_Factory.ContentHeight = 16;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 16;
			this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(112, 41);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Cont" +
				"rol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}St" +
				"yle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(208, 20);
			this.cmb_Factory.TabIndex = 10;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 39);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(104, 24);
			this.lbl_Factory.TabIndex = 50;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(722, -4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(14, 30);
			this.pictureBox2.TabIndex = 44;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 79);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(144, 18);
			this.pictureBox3.TabIndex = 43;
			this.pictureBox3.TabStop = false;
			// 
			// cbm_Season
			// 
			this.cbm_Season.AddItemCols = 0;
			this.cbm_Season.AddItemSeparator = ';';
			this.cbm_Season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbm_Season.AutoSize = false;
			this.cbm_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cbm_Season.Caption = "";
			this.cbm_Season.CaptionHeight = 17;
			this.cbm_Season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbm_Season.ColumnCaptionHeight = 18;
			this.cbm_Season.ColumnFooterHeight = 18;
			this.cbm_Season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbm_Season.ContentHeight = 16;
			this.cbm_Season.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbm_Season.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbm_Season.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cbm_Season.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbm_Season.EditorHeight = 16;
			this.cbm_Season.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cbm_Season.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbm_Season.GapHeight = 2;
			this.cbm_Season.ItemHeight = 15;
			this.cbm_Season.Location = new System.Drawing.Point(472, 41);
			this.cbm_Season.MatchEntryTimeout = ((long)(2000));
			this.cbm_Season.MaxDropDownItems = ((short)(5));
			this.cbm_Season.MaxLength = 32767;
			this.cbm_Season.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbm_Season.Name = "cbm_Season";
			this.cbm_Season.PartialRightColumn = false;
			this.cbm_Season.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Cont" +
				"rol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cbm_Season.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbm_Season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbm_Season.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbm_Season.Size = new System.Drawing.Size(152, 20);
			this.cbm_Season.TabIndex = 10;
			this.cbm_Season.SelectedValueChanged += new System.EventHandler(this.cbm_Season_SelectedValueChanged);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(137, -4);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(668, 30);
			this.pictureBox5.TabIndex = 39;
			this.pictureBox5.TabStop = false;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(640, 8);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(86, 84);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// fgrid_Growth_Plan
			// 
			this.fgrid_Growth_Plan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Growth_Plan.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Growth_Plan.ColumnInfo = "7,1,0,0,0,90,Columns:";
			this.fgrid_Growth_Plan.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Growth_Plan.Location = new System.Drawing.Point(1, 184);
			this.fgrid_Growth_Plan.Name = "fgrid_Growth_Plan";
			this.fgrid_Growth_Plan.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_Growth_Plan.Size = new System.Drawing.Size(751, 384);
			this.fgrid_Growth_Plan.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Growth_Plan.TabIndex = 179;
			this.fgrid_Growth_Plan.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Growth_Plan_BeforeEdit);
			this.fgrid_Growth_Plan.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Growth_Plan_AfterEdit);
			// 
			// Form_Monthly_Growth_Plan_By_Line
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(752, 566);
			this.Controls.Add(this.fgrid_Growth_Plan);
			this.Controls.Add(this.pnl_head);
			this.Name = "Form_Monthly_Growth_Plan_By_Line";
			this.Text = "Monthly Growth Plan By Line";
			this.Load += new System.EventHandler(this.Form_Monthly_Growth_Plan_By_Line_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_head, 0);
			this.Controls.SetChildIndex(this.fgrid_Growth_Plan, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbm_Season)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Growth_Plan)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
	
	
		#region "Constant Object"
		private const string ARG_FACTORY = "ARG_FACTORY";
		private const string ARG_LINE_CD = "ARG_LINE_CD";
		private const string ARG_MINI = "ARG_MINI";
		private const string ARG_SEASON = "ARG_SEASON";
		private const string ARG_YEAR = "ARG_YEAR";
		private const string ARG_PLAN_MONTH = "ARG_PLAN_MONTH";
		private const string ARG_CAPA_QTY = "ARG_CAPA_QTY";
		private const string ARG_REMARK01 = "ARG_REMARK01";
		private const string ARG_REMARK02 = "ARG_REMARK02";
		private const string ARG_REMARK03 = "ARG_REMARK03";
		private const string ARG_UPD_USER = "ARG_UPD_USER";
		
		private const string ARG_OUT_CURSOR="OUT_CURSOR";
		private const string  arg_upd_user="arg_upd_user";
		private const string  arg_plant_from="arg_plant_from";
		private const string  arg_plant_to="arg_plant_to";
		private const string  arg_from_obsid="arg_from_obsid";
		private const string  arg_to_obsid="arg_to_obsid";

		
		#endregion
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.DateTimePicker dpick_date_from;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private COM.FSP fgrid_Growth_Plan;
		private System.Windows.Forms.Label lbl_HeaderTitle;
		private System.Windows.Forms.Label lbl_Season;
		private C1.Win.C1List.C1Combo cbm_Season;

		#region "Declare Variable"
		private COM.OraDB oraDB = null;
		#endregion

		#region "Alias Grid Control"
		private const int G1_COL_FACTORY = 1;
		private const int G1_COL_LINE_CD = 2;
		private const int G1_COL_MINI = 3;
		private const int G1_COL_SEASON = 4;
		private const int G1_COL_YEAR = 5;
		private const int G1_COL_PLAN_MONTH = 6;
		private const int G1_COL_CAPA_QTY = 7;
		private const int G1_COL_CAPA_QTY2 = 8;
		private const int G1_COL_CAPA_QTY3 = 9;
		private const int G1_COL_REMARK01 = 10;
		private const int G1_COL_REMARK02 = 11;
		private const int G1_COL_REMARK03 = 12;
		private const int G1_COL_UPD_USER = 13;
		private System.Windows.Forms.TextBox txt_Year;
		private System.Windows.Forms.DateTimePicker dpick_date_to;
		private System.Windows.Forms.Label label1;
		private const int G1_COL_UPD_YMD = 14;
		#endregion

		#region "Init Object"

		private void Init_Form()
		{
			lbl_MainTitle.Text = this.Text;
		}

		private void Init_Control()
		{			
			tbtn_Print.Enabled=false;
			tbtn_Create.Enabled=false;
			tbtn_Conform.Enabled=false;
			tbtn_New.Enabled=false;			
			fgrid_Growth_Plan.DataSource=null;
			fgrid_Growth_Plan.Set_Grid("LST_GROWTH_PLAN","1",2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Growth_Plan.AllowMerging = AllowMergingEnum.FixedOnly;
			fgrid_Growth_Plan.Cols[0].AllowMerging=true	;
			fgrid_Growth_Plan.Set_Action_Image(img_Action);
			Init_Header();
			ChangeColumeCapa(cbm_Season.SelectedValue.ToString());
		}

		private void Init_Header()
		{
			//Load Factory
			DataTable dt_ret;
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			//Load Season
			cbm_Season.SelectedValueChanged-=new EventHandler(cbm_Season_SelectedValueChanged);
			dt_ret = Select_Data(ClassLib.ComVar.This_Factory,"SEM15");
			COM.ComCtl.Set_ComboList(dt_ret, cbm_Season, 5, 6, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cbm_Season.SelectedIndex = 0;
			dt_ret.Dispose(); 
			dpick_date_from.Value= DateTime.Now;
			txt_Year.Text = DateTime.Now.ToString("yy");
			cbm_Season.SelectedValueChanged+=new EventHandler(cbm_Season_SelectedValueChanged);
		}


		private void Init_Object()
		{
			oraDB=new COM.OraDB();
		}

		#endregion

		#region "Methods"

		private DataTable SearchData(string p_factory, string p_season, string p_year,string p_plan_month)
		{
			DataSet ds_ret;
			//para count
			oraDB.ReDim_Parameter(5); 
			//para store name
			oraDB.Process_Name = "PKG_SVM_GROWTH_PLAN.SP_SEL_SVM_GROWTH_PLAN";
			//para name
			oraDB.Parameter_Name[0] = ARG_FACTORY;
			oraDB.Parameter_Name[1] = ARG_SEASON;
			oraDB.Parameter_Name[2] = ARG_YEAR;
			oraDB.Parameter_Name[3] = ARG_PLAN_MONTH;
			oraDB.Parameter_Name[4] = ARG_OUT_CURSOR;
			//para type
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			//para values
			oraDB.Parameter_Values[0] = p_factory;
			oraDB.Parameter_Values[1] = p_season; 
			oraDB.Parameter_Values[2] = p_year; 
			oraDB.Parameter_Values[3] = p_plan_month; 
			oraDB.Parameter_Values[4] = ""; 
			//use para select
			oraDB.Add_Select_Parameter(true); 
			//exec prod
			ds_ret = oraDB.Exe_Select_Procedure();
			//return object data
			if(ds_ret == null) return null; 
			return ds_ret.Tables[oraDB.Process_Name]; 
		}
		private DataTable SearchData1(string p_factory, string p_season, string p_year)
		{
			DataSet ds_ret;
			//para count
			oraDB.ReDim_Parameter(4); 
			//para store name
			oraDB.Process_Name = "PKG_SVM_GROWTH_PLAN.SP_SEL_SVM_SEASON_MASTER";
			//para name
			oraDB.Parameter_Name[0] = ARG_FACTORY;
			oraDB.Parameter_Name[1] = ARG_SEASON;
			oraDB.Parameter_Name[2] = ARG_YEAR;
			oraDB.Parameter_Name[3] = ARG_OUT_CURSOR;
			//para type
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			//para values
			oraDB.Parameter_Values[0] = p_factory;
			oraDB.Parameter_Values[1] = p_season; 
			oraDB.Parameter_Values[2] = p_year; 
			oraDB.Parameter_Values[3] = ""; 
			//use para select
			oraDB.Add_Select_Parameter(true); 
			//exec prod
			ds_ret = oraDB.Exe_Select_Procedure();
			//return object data
			if(ds_ret == null) return null; 
			return ds_ret.Tables[oraDB.Process_Name]; 
		}
		
		private bool Save_Data(bool doExecute)
		{
			try
			{				
				int para_ct = 0; 
				int iCount  = 12;
				oraDB.ReDim_Parameter(iCount);
				//01.PROCEDURE NAME
				oraDB.Process_Name = "PKG_SVM_GROWTH_PLAN.SP_INS_SVM_GROWTH_PLAN_1";
				//02.ARGURMENT OF PROC
				oraDB.Parameter_Name[0] = "ARG_DIVISION";
				oraDB.Parameter_Name[1] = ARG_FACTORY;
				oraDB.Parameter_Name[2] = ARG_LINE_CD;
				oraDB.Parameter_Name[3] = ARG_MINI;
				oraDB.Parameter_Name[4] = ARG_SEASON;
				oraDB.Parameter_Name[5] = ARG_YEAR;
				oraDB.Parameter_Name[6] = ARG_PLAN_MONTH;
				oraDB.Parameter_Name[7] = ARG_CAPA_QTY;
				oraDB.Parameter_Name[8] = ARG_REMARK01;
				oraDB.Parameter_Name[9] = ARG_REMARK02;
				oraDB.Parameter_Name[10] = ARG_REMARK03;
				oraDB.Parameter_Name[11] = ARG_UPD_USER;
				//03. Type of Argurment
				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[3] = (int)OracleType.Number;
				oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[7] = (int)OracleType.Number;
				oraDB.Parameter_Type[8] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[9] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[10]= (int)OracleType.VarChar;
				oraDB.Parameter_Type[11] = (int)OracleType.VarChar;

				oraDB.Parameter_Values  = new string[iCount * (fgrid_Growth_Plan.Rows.Count - fgrid_Growth_Plan.Rows.Fixed) * 3 ];
				ArrayList vModifyList	= new ArrayList();

				for (int iRow = fgrid_Growth_Plan.Rows.Fixed; iRow < fgrid_Growth_Plan.Rows.Count ; iRow++)
				{		
					string l_Tmp = ClassLib.ComFunction.NullCheck(fgrid_Growth_Plan[iRow, 0], "").ToString();
					
					if (l_Tmp.Equals("U") || l_Tmp.Equals(""))
					{
						if (ClassLib.ComFunction.NullCheck(fgrid_Growth_Plan[iRow, 1],"")=="")
						{						
							for (int i=0; i< 3; i++)
							{							
								vModifyList.Add("I");
								vModifyList.Add(cmb_Factory.SelectedValue);
								vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_LINE_CD]);
								vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_MINI]);
								vModifyList.Add(cbm_Season.SelectedValue);
								vModifyList.Add(int.Parse(txt_Year.Text).ToString("0#"));
								vModifyList.Add(dpick_date_from.Value.ToString("yyyy").Substring(0,2) + int.Parse(txt_Year.Text).ToString("0#")+
									ChangeMonthFromIndex(cbm_Season.SelectedValue.ToString(),i));
								if (i == 0 )
								{
									if (fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY] == null)
										vModifyList.Add("0");
									else
										vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY]);
								}
								if (i == 1 )
								{
									if (fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY2] == null)
										vModifyList.Add("0");
									else
										vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY2]);
								}
								if (i == 2 )
								{
									if (fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY3] == null)
										vModifyList.Add("0");
									else
										vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY3]);
								}

								vModifyList.Add( fgrid_Growth_Plan[iRow, G1_COL_REMARK01]);
								vModifyList.Add( fgrid_Growth_Plan[iRow, G1_COL_REMARK02]);
								vModifyList.Add( fgrid_Growth_Plan[iRow, G1_COL_REMARK03]);
								vModifyList.Add( COM.ComVar.This_User);
							}
						}
						if (ClassLib.ComFunction.NullCheck(fgrid_Growth_Plan[iRow, 1],"")!="")
						{
							for (int i=0; i< 3; i++)
							{
								vModifyList.Add("U");
								vModifyList.Add(cmb_Factory.SelectedValue);
								vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_LINE_CD]);
								vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_MINI]);
								vModifyList.Add(cbm_Season.SelectedValue);
								vModifyList.Add(int.Parse(txt_Year.Text).ToString("0#"));
								vModifyList.Add(dpick_date_from.Value.ToString("yyyy").Substring(0,2) + int.Parse(txt_Year.Text).ToString("0#")+
									ChangeMonthFromIndex(cbm_Season.SelectedValue.ToString(),i));
								if (i == 0 )
								{
									if (fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY] == null)
										vModifyList.Add("0");
									else
										vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY]);
								}
								if (i == 1 )
								{
									if (fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY2] == null)
										vModifyList.Add("0");
									else
										vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY2]);
								}
								if (i == 2 )
								{
									if (fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY3] == null)
										vModifyList.Add("0");
									else
										vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY3]);
								}

								vModifyList.Add( fgrid_Growth_Plan[iRow, G1_COL_REMARK01]);
								vModifyList.Add( fgrid_Growth_Plan[iRow, G1_COL_REMARK02]);
								vModifyList.Add( fgrid_Growth_Plan[iRow, G1_COL_REMARK03]);
								vModifyList.Add( COM.ComVar.This_User);
							}
						}
					}				

					if (l_Tmp.Equals("D"))
					{
						for (int i=0; i< 3; i++)
						{
							vModifyList.Add(l_Tmp);
							vModifyList.Add(cmb_Factory.SelectedValue);
							vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_LINE_CD]);
							vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_MINI]);
							vModifyList.Add(cbm_Season.SelectedValue);
							vModifyList.Add(int.Parse(txt_Year.Text).ToString("0#"));
							vModifyList.Add(dpick_date_from.Value.ToString("yyyy").Substring(0,2) + int.Parse(txt_Year.Text).ToString("0#")+
								ChangeMonthFromIndex(cbm_Season.SelectedValue.ToString(),i));
							if (i == 0 )
							{
								if (fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY] == null)
									vModifyList.Add("0");
								else
									vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY]);
							}
							if (i == 1 )
							{
								if (fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY2] == null)
									vModifyList.Add("0");
								else
									vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY2]);
							}
							if (i == 2 )
							{
								if (fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY3] == null)
									vModifyList.Add("0");
								else
									vModifyList.Add(fgrid_Growth_Plan[iRow, G1_COL_CAPA_QTY3]);
							}

							vModifyList.Add( fgrid_Growth_Plan[iRow, G1_COL_REMARK01]);
							vModifyList.Add( fgrid_Growth_Plan[iRow, G1_COL_REMARK02]);
							vModifyList.Add( fgrid_Growth_Plan[iRow, G1_COL_REMARK03]);
							vModifyList.Add( COM.ComVar.This_User);
						}
					}
					para_ct += iCount;	
				}

				oraDB.Parameter_Values = new string[vModifyList.Count];
				for (int j=0; j<vModifyList.Count;j++)
				{
					oraDB.Parameter_Values[j] = vModifyList[j].ToString();
				}
				oraDB.Add_Modify_Parameter(true);
				
				if (doExecute)
				{
					if (oraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}
				return true;

			}
			catch(System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		private string ConvertOBS_ID(int arg_year, int arg_month)
		{
			string rs = string.Empty;
			string objMonth = string.Empty;
			string[] arr_ObjMonth=new string[]{
												  "0305",//1
												  "0406",//2
												  "0507",//3
												  "0608",//4
												  "0709",//5
												  "0810",//6
												  "0911",//7
												  "1012",//8
												  "1101",//9
												  "1202",//10
												  "0103",//11
												  "0204",//12
			};
			objMonth = arr_ObjMonth[arg_month - 1];
			rs = arg_year.ToString().Substring(2,2)+objMonth;
			return rs;
		}
		private bool Save_Data1(bool doExecute)
		{
			try
			{				
				oraDB.ReDim_Parameter(6);
				//01.PROCEDURE NAME
				oraDB.Process_Name = "PKG_SVM_GROWTH_PLAN.sp_ins_svm_season_master";
				//02.ARGURMENT OF PROC
				oraDB.Parameter_Name[0] = ARG_FACTORY;
				oraDB.Parameter_Name[1] = ARG_SEASON;
				oraDB.Parameter_Name[2] = ARG_YEAR;
				oraDB.Parameter_Name[3] = arg_plant_from;
				oraDB.Parameter_Name[4] = arg_plant_to;
				oraDB.Parameter_Name[5] = arg_upd_user;
				//oraDB.Parameter_Name[6] = arg_from_obsid;
				//oraDB.Parameter_Name[7] = arg_to_obsid;
				//03. Type of Argurment
				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				//oraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				//oraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				//04. Data od Argurment
				oraDB.Parameter_Values[0]= cmb_Factory.SelectedValue.ToString();
				oraDB.Parameter_Values[1]= cbm_Season.SelectedValue.ToString();
				oraDB.Parameter_Values[2]= txt_Year.Text;
				oraDB.Parameter_Values[3]= dpick_date_from.Value.ToString("yyyyMMdd");
				oraDB.Parameter_Values[4]= dpick_date_to.Value.ToString("yyyyMMdd");
				oraDB.Parameter_Values[5]= COM.ComVar.This_User;
				//oraDB.Parameter_Values[6]= ConvertOBS_ID(dpick_date_from.Value.Year,dpick_date_from.Value.Month);
				//oraDB.Parameter_Values[7]= ConvertOBS_ID(dpick_date_to.Value.Year,dpick_date_to.Value.Month);
				
				oraDB.Add_Modify_Parameter(true);
				oraDB.Exe_Modify_Procedure();
				if(oraDB.Exe_Modify_Procedure()==null)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			catch(System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		

		private bool Delete_Data1(bool doExecute)
		{
			try
			{				
				oraDB.ReDim_Parameter(8);
				//01.PROCEDURE NAME
				oraDB.Process_Name = "PKG_SVM_GROWTH_PLAN.sp_del_svm_season_master";
				//02.ARGURMENT OF PROC
				oraDB.Parameter_Name[0] = ARG_FACTORY;
				oraDB.Parameter_Name[1] = ARG_SEASON;
				oraDB.Parameter_Name[2] = ARG_YEAR;
				oraDB.Parameter_Name[3] = arg_plant_from;
				oraDB.Parameter_Name[4] = arg_plant_to;
				oraDB.Parameter_Name[5] = arg_upd_user;
				oraDB.Parameter_Name[6] = arg_from_obsid;
				oraDB.Parameter_Name[7] = arg_to_obsid;
				//03. Type of Argurment
				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				//04. Data od Argurment
				oraDB.Parameter_Values[0]= cmb_Factory.SelectedValue.ToString();
				oraDB.Parameter_Values[1]= cbm_Season.SelectedValue.ToString();
				oraDB.Parameter_Values[2]= txt_Year.Text;
				oraDB.Parameter_Values[3]= dpick_date_from.Value.ToString();
				oraDB.Parameter_Values[4]= dpick_date_to.Value.ToString();
				oraDB.Parameter_Values[5]= COM.ComVar.This_User;
				oraDB.Parameter_Values[6]= ConvertOBS_ID(dpick_date_from.Value.Year,dpick_date_from.Value.Month);
				oraDB.Parameter_Values[7]= ConvertOBS_ID(dpick_date_to.Value.Year,dpick_date_to.Value.Month);
				
				oraDB.Add_Modify_Parameter(true);
				oraDB.Exe_Modify_Procedure();
				if(oraDB.Exe_Modify_Procedure()==null)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			catch(System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Delete_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;
			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{								
				C1.Win.C1FlexGrid.Node newRow = fgrid_Growth_Plan.Rows.InsertNode(fgrid_Growth_Plan.Rows.Fixed + iRow, 1);

				fgrid_Growth_Plan[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					if(G1_COL_CAPA_QTY == iCol || G1_COL_CAPA_QTY2 == iCol || G1_COL_CAPA_QTY3 == iCol)
					{
						if(arg_dt.Rows[iRow].ItemArray[iCol-1]!= DBNull.Value)
						{
							if(Convert.ToInt32(arg_dt.Rows[iRow].ItemArray[iCol-1])>0)
							{
								fgrid_Growth_Plan[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
							}
						}
					}
					else
					{
						fgrid_Growth_Plan[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
					}
				}
			}
		}


		private DataTable Select_Data(string factory,string code)
		{
			COM.OraDB oraDB = new COM.OraDB();

			DataSet ds_ret;
			string process_name = "PKG_SCM_CODE.SELECT_CODE_LIST2";

			oraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			oraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			oraDB.Parameter_Name[0] = ARG_FACTORY;;
			oraDB.Parameter_Name[1] = "ARG_COM_CD";
			oraDB.Parameter_Name[2] = ARG_OUT_CURSOR;

			//03.DATA TYPE
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = code;
			oraDB.Parameter_Values[2] = ""; 

			oraDB.Add_Select_Parameter(true);
 
			ds_ret = oraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}


		private void Clear_FlexGrid()
		{
			if (fgrid_Growth_Plan.Rows.Fixed != fgrid_Growth_Plan.Rows.Count)
			{				
				fgrid_Growth_Plan.Clear(ClearFlags.UserData, fgrid_Growth_Plan.Rows.Fixed, 1, fgrid_Growth_Plan.Rows.Count - 1, fgrid_Growth_Plan.Cols.Count - 1);

				fgrid_Growth_Plan.Rows.Count = fgrid_Growth_Plan.Rows.Fixed;
					
			}
		}

		
		private bool ValidateData()
		{
			if(cbm_Season.SelectedValue.ToString()== " ")
				return false;
			return true;
		}
		
		
		private string ChangeMonthFromIndex(string p_Season, int p_CurrIndex)
		{
			if (p_Season.ToUpper().Equals("SP"))
			{
				if (p_CurrIndex == 0)
				{
					return "10";
				}
				if (p_CurrIndex == 1)
				{
					return "11";
				}

				if (p_CurrIndex == 2)
				{
					return "12";
				}
			}
			if (p_Season.ToUpper().Equals("FA"))
			{
				if (p_CurrIndex == 0)
				{
					return "04";
				}
				if (p_CurrIndex == 1)
				{
					return "05";
				}

				if (p_CurrIndex == 2)
				{
					return "06";
				}
			}
			if (p_Season.ToUpper().Equals("SU"))
			{
				if (p_CurrIndex == 0)
				{
					return "01";
				}
				if (p_CurrIndex == 1)
				{
					return "02";
				}

				if (p_CurrIndex == 2)
				{
					return "03";
				}
			}
			if (p_Season.ToUpper().Equals("HO"))
			{
				if (p_CurrIndex == 0)
				{
					return "07";
				}
				if (p_CurrIndex == 1)
				{
					return "08";
				}

				if (p_CurrIndex == 2)
				{
					return "09";
				}
			}
			return string.Empty;
		}

		
		private void ChangeColumeCapa(string p_Season )
		{
			DateTime dt = new DateTime(2008, 3, 9, 0, 0, 0, 0);
			if (p_Season.ToUpper().Equals("SP"))
			{
				dt = new DateTime(2008, 10, 10, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY]  = string.Format("{0:MMMM}", dt);
				dt = new DateTime(2008, 11, 11, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY2]  = string.Format("{0:MMMM}", dt);
				dt = new DateTime(2008, 12, 12, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY3]  = string.Format("{0:MMMM}", dt);
			}
			if (p_Season.ToUpper().Equals("FA"))
			{
				dt = new DateTime(2008, 4, 10, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY]  = string.Format("{0:MMMM}", dt);
				dt = new DateTime(2008, 5, 11, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY2]  = string.Format("{0:MMMM}", dt);
				dt = new DateTime(2008, 6, 12, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY3]  = string.Format("{0:MMMM}", dt);
			}
			if (p_Season.ToUpper().Equals("SU"))
			{
				dt = new DateTime(2008, 1, 10, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY]  = string.Format("{0:MMMM}", dt);
				dt = new DateTime(2008, 2, 11, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY2]  = string.Format("{0:MMMM}", dt);
				dt = new DateTime(2008, 3, 12, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY3]  = string.Format("{0:MMMM}", dt);
			}
			if (p_Season.ToUpper().Equals("HO"))
			{
				dt = new DateTime(2008, 7, 10, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY]  = string.Format("{0:MMMM}", dt);
				dt = new DateTime(2008, 8, 11, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY2]  = string.Format("{0:MMMM}", dt);
				dt = new DateTime(2008, 9, 12, 0, 0, 0, 0);
				fgrid_Growth_Plan[2,G1_COL_CAPA_QTY3]  = string.Format("{0:MMMM}", dt);
			}
		}

		
		private bool ValidateHeader(object p_CtrlYear)
		{
			TextBox l_TextBox =(TextBox)p_CtrlYear;
			if (l_TextBox.Text.Trim().Equals(string.Empty))
			{
				ClassLib.ComFunction.User_Message("'Year' is required![YY]!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_Year.Focus();
				return false;
			}
			return true;
		}

		
		#endregion
		
		#region "Event"

		private void fgrid_Growth_Plan_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			COM.FSP l_Tmp=(COM.FSP)sender;
			if ((l_Tmp.Rows.Fixed > 0) && (l_Tmp.Row >= l_Tmp.Rows.Fixed))
				l_Tmp.Buffer_CellData = (l_Tmp[l_Tmp.Row, l_Tmp.Col] == null) ? "" : l_Tmp[l_Tmp.Row, l_Tmp.Col].ToString();
		}

		
		private void fgrid_Growth_Plan_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			COM.FSP l_Tmp=(COM.FSP)sender;
			if(l_Tmp.Buffer_CellData != Convert.ToString( l_Tmp[e.Row,e.Col]))
			{
				l_Tmp.Update_Row();
			}
		}

		
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				for (int i=0 ; i< fgrid_Growth_Plan.Selections.Length; i++)
				{
					fgrid_Growth_Plan.Delete_Row(fgrid_Growth_Plan.Selections[i]);
				}
			}
			catch (System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"tbtn_Delete_Click", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		
		private void Form_Monthly_Growth_Plan_By_Line_Load(object sender, System.EventArgs e)
		{
			
			Init_cbm_Season();
			txt_Year.TextChanged+=new EventHandler(txt_Year_TextChanged);
			tbtn_Search_Click(tbtn_Search,null);
			

		}


				
		private void txt_Year_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+")&& e.KeyChar != (char)Keys.Back)
				e.Handled = true;
		}

		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}
		
		private DateTime ConvertToDateTime(string p_yyyyMMdd)
		{
			return DateTime.ParseExact(p_yyyyMMdd,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
		}
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if(ValidateHeader(txt_Year))
				{				
					Clear_FlexGrid();
					DataTable l_DataTable = SearchData(cmb_Factory.SelectedValue.ToString(),cbm_Season.SelectedValue.ToString(),
						int.Parse(txt_Year.Text).ToString("0#"), dpick_date_from.Value.ToString("yyyy").Substring(0,2) + int.Parse(txt_Year.Text).ToString("0#"));					
					Display_FlexGrid(l_DataTable);
					ChangeColumeCapa(cbm_Season.SelectedValue.ToString());
					//Search data for datebox
					DataTable l_DataTable1= SearchData1(cmb_Factory.SelectedValue.ToString(),cbm_Season.SelectedValue.ToString(),
						int.Parse(txt_Year.Text).ToString("0#"));
					if(l_DataTable1.Rows.Count>0)
					{
						dpick_date_from.Value=ConvertToDateTime(l_DataTable1.Rows[0][0].ToString());
						dpick_date_to.Value=ConvertToDateTime(l_DataTable1.Rows[0][1].ToString());
					}
				}
			}
			catch (System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
			
				if(!ValidateData())
				{
					ClassLib.ComFunction.User_Message("Pls Choose Season!!","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
				if(Save_Data1(true)&& Save_Data(true))
				{
					tbtn_Search_Click(tbtn_Search, null);
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				}
			}
			catch (System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"tbtn_Save_Click", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		
		private void txt_Year_Leave(object sender, System.EventArgs e)
		{
			ValidateHeader(sender);
		}
		private void Init_cbm_Season ()
		{
			int year = int.Parse(txt_Year.Text);
			if (cbm_Season.SelectedValue.ToString()=="SP")
			{
				int l_year=year-1;
				string _temp="20"+String.Format("{0:0#}",l_year)+"0801";
				string _temp2="20"+String.Format("{0:0#}",l_year)+"1030";
				dpick_date_from.Value= DateTime.ParseExact(_temp,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
				dpick_date_to.Value= DateTime.ParseExact(_temp2,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
			}
			if (cbm_Season.SelectedValue.ToString()=="FA")
			{
				string _temp="20"+String.Format("{0:0#}",year)+"0201";
				string _temp2="20"+String.Format("{0:0#}",year)+"0430";
				dpick_date_from.Value= DateTime.ParseExact(_temp,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
				dpick_date_to.Value= DateTime.ParseExact(_temp2,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
			}
			if (cbm_Season.SelectedValue.ToString()=="SU")
			{
				int l_year=year-1;
				string _temp="20"+String.Format("{0:0#}",l_year)+"1101";
				string _temp2="20"+String.Format("{0:0#}",year)+"0130";
				dpick_date_from.Value= DateTime.ParseExact(_temp,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
				dpick_date_to.Value= DateTime.ParseExact(_temp2,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
			}
			if (cbm_Season.SelectedValue.ToString()=="HO")
			{
				string _temp="20"+String.Format("{0:0#}",year)+"0501";
				string _temp2="20"+String.Format("{0:0#}",year)+"0730";
				dpick_date_from.Value= DateTime.ParseExact(_temp,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
				dpick_date_to.Value= DateTime.ParseExact(_temp2,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
			}
		}
		
		private void cbm_Season_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Init_cbm_Season();
			tbtn_Search_Click(tbtn_Search,null);
		}

		
		#endregion

		private void dpick_date_from_ValueChanged(object sender, System.EventArgs e)
		{
//			txt_Year.Text = dpick_date_from.Value.ToString("yy");
//			tbtn_Search_Click(tbtn_Search,null);
		}

		private void txt_Year_TextChanged(object sender, System.EventArgs e)
		{
			TextBox l_txt_Year=(TextBox)sender;
			if (l_txt_Year.Text.Length!=2)
			{
				return;
			}
			Init_cbm_Season();
			tbtn_Search_Click(tbtn_Search,null);
		}


			
	}

	

}

