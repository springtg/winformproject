using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;

namespace FlexVJ_Common.DPUFE
{
	public class Form_Plan_Simulation2 : COM.VJ_CommonWinForm.Form_Top
	{
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.DateTimePicker dpick_date_from;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private System.Windows.Forms.Label lbl_HeaderTitle;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label lbl_Line;
		private C1.Win.C1List.C1Combo cbm_Line;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.DateTimePicker dpick_date_To;
		
		private NETRONIC.XGantt.VcGantt vcGantt1;
		private System.ComponentModel.IContainer components = null;

		public Form_Plan_Simulation2()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Plan_Simulation2));
			this.pnl_head = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.cbm_Line = new C1.Win.C1List.C1Combo();
			this.dpick_date_from = new System.Windows.Forms.DateTimePicker();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.lbl_Line = new System.Windows.Forms.Label();
			this.lbl_HeaderTitle = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.dpick_date_To = new System.Windows.Forms.DateTimePicker();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.vcGantt1 = new NETRONIC.XGantt.VcGantt();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbm_Line)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			this.stbar.Text = "Month";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Text = "Plan Simulation";
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
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.label5);
			this.pnl_head.Controls.Add(this.cbm_Line);
			this.pnl_head.Controls.Add(this.dpick_date_from);
			this.pnl_head.Controls.Add(this.lbl_PlanYMD);
			this.pnl_head.Controls.Add(this.lbl_Line);
			this.pnl_head.Controls.Add(this.lbl_HeaderTitle);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.cmb_Factory);
			this.pnl_head.Controls.Add(this.lbl_Factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pictureBox2);
			this.pnl_head.Controls.Add(this.pictureBox3);
			this.pnl_head.Controls.Add(this.pictureBox4);
			this.pnl_head.Controls.Add(this.dpick_date_To);
			this.pnl_head.Controls.Add(this.pictureBox5);
			this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_head.Location = new System.Drawing.Point(0, 0);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1016, 100);
			this.pnl_head.TabIndex = 31;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(520, 50);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(16, 16);
			this.label5.TabIndex = 565;
			this.label5.Text = "~";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbm_Line
			// 
			this.cbm_Line.AddItemCols = 0;
			this.cbm_Line.AddItemSeparator = ';';
			this.cbm_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbm_Line.AutoSize = false;
			this.cbm_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cbm_Line.Caption = "";
			this.cbm_Line.CaptionHeight = 17;
			this.cbm_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbm_Line.ColumnCaptionHeight = 18;
			this.cbm_Line.ColumnFooterHeight = 18;
			this.cbm_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbm_Line.ContentHeight = 17;
			this.cbm_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbm_Line.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbm_Line.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cbm_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbm_Line.EditorHeight = 17;
			this.cbm_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cbm_Line.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbm_Line.GapHeight = 2;
			this.cbm_Line.ItemHeight = 15;
			this.cbm_Line.Location = new System.Drawing.Point(728, 48);
			this.cbm_Line.MatchEntryTimeout = ((long)(2000));
			this.cbm_Line.MaxDropDownItems = ((short)(5));
			this.cbm_Line.MaxLength = 32767;
			this.cbm_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbm_Line.Name = "cbm_Line";
			this.cbm_Line.PartialRightColumn = false;
			this.cbm_Line.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
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
				"DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cbm_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbm_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbm_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbm_Line.Size = new System.Drawing.Size(210, 21);
			this.cbm_Line.TabIndex = 10;
			// 
			// dpick_date_from
			// 
			this.dpick_date_from.CustomFormat = "yyyy-MM-dd";
			this.dpick_date_from.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_from.Location = new System.Drawing.Point(432, 48);
			this.dpick_date_from.Name = "dpick_date_from";
			this.dpick_date_from.Size = new System.Drawing.Size(88, 21);
			this.dpick_date_from.TabIndex = 564;
			this.dpick_date_from.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpick_date_from_KeyDown);
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_PlanYMD.ImageIndex = 1;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(328, 48);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 543;
			this.lbl_PlanYMD.Text = "Plan Month";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Line
			// 
			this.lbl_Line.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Line.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Line.ImageIndex = 1;
			this.lbl_Line.ImageList = this.img_Label;
			this.lbl_Line.Location = new System.Drawing.Point(624, 48);
			this.lbl_Line.Name = "lbl_Line";
			this.lbl_Line.Size = new System.Drawing.Size(100, 21);
			this.lbl_Line.TabIndex = 405;
			this.lbl_Line.Text = "Line";
			this.lbl_Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_HeaderTitle
			// 
			this.lbl_HeaderTitle.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_HeaderTitle.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_HeaderTitle.ForeColor = System.Drawing.Color.Navy;
			this.lbl_HeaderTitle.Image = ((System.Drawing.Image)(resources.GetObject("lbl_HeaderTitle.Image")));
			this.lbl_HeaderTitle.Location = new System.Drawing.Point(0, 0);
			this.lbl_HeaderTitle.Name = "lbl_HeaderTitle";
			this.lbl_HeaderTitle.Size = new System.Drawing.Size(231, 30);
			this.lbl_HeaderTitle.TabIndex = 393;
			this.lbl_HeaderTitle.Text = "      Search Information";
			this.lbl_HeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(1000, 84);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 83);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(976, 18);
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
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(109, 48);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
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
				"DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_Factory.TabIndex = 10;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 48);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 50;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(915, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 59);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(1000, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 44;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 84);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(168, 20);
			this.pictureBox3.TabIndex = 43;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(168, 82);
			this.pictureBox4.TabIndex = 41;
			this.pictureBox4.TabStop = false;
			// 
			// dpick_date_To
			// 
			this.dpick_date_To.CustomFormat = "yyyy-MM-dd";
			this.dpick_date_To.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_To.Location = new System.Drawing.Point(536, 48);
			this.dpick_date_To.Name = "dpick_date_To";
			this.dpick_date_To.Size = new System.Drawing.Size(88, 21);
			this.dpick_date_To.TabIndex = 564;
			this.dpick_date_To.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpick_date_To_KeyDown);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(160, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(936, 32);
			this.pictureBox5.TabIndex = 39;
			this.pictureBox5.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pnl_head);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 80);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1016, 100);
			this.panel3.TabIndex = 180;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.vcGantt1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 180);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1016, 464);
			this.panel5.TabIndex = 181;
			// 
			// vcGantt1
			// 
			this.vcGantt1.ConfigurationStorage = ((NETRONIC.XGantt.VcConfigurationStorage)(resources.GetObject("vcGantt1.ConfigurationStorage")));
			this.vcGantt1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vcGantt1.Location = new System.Drawing.Point(0, 0);
			this.vcGantt1.Name = "vcGantt1";
			this.vcGantt1.Size = new System.Drawing.Size(1016, 464);
			this.vcGantt1.TabIndex = 0;
			this.vcGantt1.Text = "vcGantt1";
			// 
			// Form_Plan_Simulation2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Name = "Form_Plan_Simulation2";
			this.Text = "Plan Simulation2";
			this.Load += new System.EventHandler(this.Form_Plan_Simulation_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.panel3, 0);
			this.Controls.SetChildIndex(this.panel5, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbm_Line)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
	
		#region "Declarce Variable"
		private bool _DemandPlan_ON_Flag = false;
		private int _Rowfixed = 1;
		private int _MainRowfixed = 1;
		private int _DynamicColWidth = 34;
		private COM.OraDB MyOraDB = new COM.OraDB();
		private bool _Flag_ItemMove =false;
		private int _MaxCol = 12;
		private object _CurrBuff=null;

		private  Color T1_Color = Color.FromArgb(255,255,0);
		private  Color T2_Color = Color.FromArgb(246,150,10);
		private  Color T3_Color = Color.FromArgb(181,255,4);
		private  Color T4_Color = Color.FromArgb(22,252,4);
		private  Color T5_Color = Color.FromArgb(4,222,252);
		private  Color T6_Color = Color.FromArgb(5,134,251);
		private  Color T7_Color = Color.FromArgb(209,7,249);
		private  Color T8_Color = Color.FromArgb(249,7,111);
		private  Color T9_Color = Color.FromArgb(99,157,139);
		private  Color T10_Color = Color.FromArgb(166,164,92);
		private  Color T11_Color = Color.FromArgb(236,87,20);
		private  Color T12_Color = Color.FromArgb(38,218,218);
		#endregion

		#region "Constant Argument"
		private const string ARG_FACTORY = "ARG_FACTORY";
		private const string ARG_MONTH = "ARG_MONTH";
		private const string ARG_LINE_CD = "ARG_LINE_CD";
		private const string ARG_OS_CODE = "ARG_OS_CODE";
		private const string ARG_DEV_NAME = "ARG_DEV_NAME";
	    private const string OUT_CURSOR = "OUT_CURSOR";
		private const string ARG_FROM_DATE = "ARG_FROM_DATE";
		private const string ARG_TO_DATE = "ARG_TO_DATE";

		private const string ARG_MINI_LINE = "ARG_MINI_LINE";
		private const string ARG_PLAN_YMD = "ARG_PLAN_YMD";
		//private const string ARG_MID_SOLE_1 = "ARG_MID_SOLE_1";
		//private const string ARG_MID_SOLE_2 = "ARG_MID_SOLE_2";
		//private const string ARG_MID_SOLE_3 = "ARG_MID_SOLE_3";
		private const string ARG_ITEM = "ARG_ITEM";
		private const string ARG_PLAN_QTY = "ARG_PLAN_QTY";
		private const string ARG_UPD_USER = "ARG_UPD_USER";
		private const string ARG_MPS_YN = "ARG_MPS_YN";
		private const string ARG_WORK_DAYS = "ARG_WORK_DAYS";
		private const string ARG_DAILY_CAPA = "ARG_DAILY_CAPA";


		#endregion

		#region "Constant Column Grid"
		private static int  G1_COL_FACTORY = 1;
		private static int  G1_COL_SEQ = 2;
		private static int 	G1_COL_LINE_CD = 3;
		//private static int 	G1_COL_MINI_LINE    = 4;
		private static int  G1_COL_PLAN_YMD = 4;
		private static int 	G1_COL_MID_SOLE_1 = 5;
		private static int 	G1_COL_MID_SOLE_2 = 6;
		private static int 	G1_COL_MID_SOLE_3 = 7;
		private static int  G1_COL_MODEL_CD =8;
		private static int  G1_COL_OS_CODE = 9;
		private static int  G1_COL_ITEM = 10;
		private static int  G1_COL_ODS_ID = 11;
		private static int	G1_COL_PLAN_QTY = 12;
		//private static int	G1_COL_CAPA_QTY = 14;

		
		private static int G2_COL_FACTORY= 1;
		private static int G2_COL_CATEGORY_NAME = 2;
		private static int G2_COL_OBS_ID = 3;
		private static int G2_COL_OS_CODE = 4;
		private static int G2_COL_MID_SOLE1 = 5;
		private static int G2_COL_MID_SOLE2 = 6;
		private static int G2_COL_MID_SOLE3 = 7;
		private static int G2_COL_MODEL_CD = 8;
		private static int G2_COL_DEV_NAME = 9;		
		private static int G2_COL_PLAN_MONTH = 10;
		private static int G2_COL_PLAN_QTY = 11;
		private static int G2_COL_REMARK01 = 12;
		private static int G2_COL_REMARK02 = 13;
		private static int G2_COL_REMARK03 = 14;



		#endregion 

		#region "Init"

		private void Init_Form()
		{
			Init_Control();
		}
		
		private void Init_Control()
		{
			tbtn_Insert.Enabled=false;
			tbtn_Print.Enabled=false;
			tbtn_Confirm.Enabled=false;
			tbtn_Create.Enabled=false;
			//tbtn_New.Enabled=false;
		
			//init header control
			DataTable dt_ret;

			// factory
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// Line
			dt_ret = SELECT_LINE_INFO();
			COM.ComCtl.Set_ComboList(dt_ret, cbm_Line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cbm_Line.SelectedIndex = 0;

			dt_ret.Dispose();

			//init datetime control
			Init_Time_Control();			
		}
		
		
		private void Init_Time_Control()
		{
			DateTime _CurTime = System.DateTime.Now;
			string sFrom_date = _CurTime.AddDays(42).ToString("yyyy-MM-dd");//current time + 6 week
			string sTo_date   = _CurTime.AddDays(42).AddMonths(2).ToString("yyyy-MM-dd");//from time add 2 months
						 
			dpick_date_from.Text = sFrom_date;
			dpick_date_To.Text   = sTo_date;
		}

		
		#endregion

		#region "Event"
		
		
		
		
		private void Form_Plan_Simulation_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			cmb_Factory.SelectedValueChanged+=new EventHandler(cmb_Factory_SelectedValueChanged);
			cbm_Line.SelectedValueChanged+=new EventHandler(cbm_Line_SelectedValueChanged);
			//dpick_date_from.ValueChanged+=new EventHandler(dpick_date_from_ValueChanged);
			//dpick_date_To.ValueChanged+=new EventHandler(dpick_date_To_ValueChanged);
		}

		
	
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DialogResult dr;

			if (false)//Validate_Check(null))
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.Tbtn_SaveProcess();					
				}
			}
			else
			{
				dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave);
			}
		}

		
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;				
				this.Tbtn_SearchProcess();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (cbm_Line.SelectedValue.ToString().Equals(" "))
				{
					ClassLib.ComFunction.User_Message("You must choose one line to create new!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					//this.Tbtn_NewProcess();
				}
			}
			catch (System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}		
		}
	
		
		private void cbm_Line_SelectedValueChanged(object sender, System.EventArgs e)
		{
			C1.Win.C1List.C1Combo l_Tmp = (C1.Win.C1List.C1Combo) sender;
			if (l_Tmp.SelectedValue.Equals(" "))
			{
				tbtn_Save.Enabled = false;
			}
			else
			{
				tbtn_Save.Enabled = true;
			}
			tbtn_Search_Click(tbtn_Search,null);
		}

	
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{			
			/*try
			{ 
				this.Cursor = Cursors.WaitCursor;								
				for (int i = _MainRowfixed; i< fgrid_main.Rows.Count; i++)
				{
//					if (fgrid_main.Rows[i].AllowEditing== false)
//					{
//						for (int j = i+1; j<fgrid_main.Rows.Count; j++)
//						{
//							if (fgrid_main.Rows[i][G1_COL_LINE_CD].ToString().Equals(fgrid_main.Rows[j].UserData.ToString()))
//							{
//								fgrid_main.Delete_Row(j);
//							}
//						}
//						break;
//					}
//					else
						if (fgrid_main.Rows[i].Selected)
						{
							if (fgrid_main.Rows[i].AllowEditing== false)
							{
								for (int j = i+1; j<fgrid_main.Rows.Count; j++)
								{
									if (fgrid_main.Rows[i][G1_COL_LINE_CD].ToString().Equals(fgrid_main.Rows[j].UserData.ToString()))
									{
										fgrid_main.Delete_Row(j);
									}
								}
							}
							else
							fgrid_main.Delete_Row(i);
						}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}*/
		}

		
		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
		
		}
		
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			tbtn_Search_Click(tbtn_Search,null);
		}

		
//		private void dpick_date_from_ValueChanged(object sender, System.EventArgs e)
//		{
//			tbtn_Search_Click(tbtn_Search,null);
//		}
//
//		
//		private void dpick_date_To_ValueChanged(object sender, System.EventArgs e)
//		{
//			tbtn_Search_Click(tbtn_Search,null);
//		}


		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			COM.FSP l_fgrid_main=(COM.FSP)sender;
			if (_CurrBuff != null)
			{
				if (_CurrBuff.ToString() != l_fgrid_main[e.Row,e.Col].ToString())
				{
					l_fgrid_main.Update_Row(e.Row);
					
				}
			}
			_CurrBuff = null;
		}


		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			COM.FSP l_fgrid_main=(COM.FSP)sender;
			_CurrBuff = l_fgrid_main[e.Row,e.Col];
		
		}

		
		
		#endregion

		#region "Methods"

		private int isNoEmptyFiled(int arg_rowIndex, COM.FSP arg_fgrid)
		{
			if(arg_fgrid.Rows.Count < _Rowfixed) return -1;
			for (int i = _MaxCol + 1; i < arg_fgrid.Cols.Count; i++)
			{
				if (ClassLib.ComFunction.NullToBlank(arg_fgrid[arg_rowIndex, i]).Equals(""))
				{
					return i;
				}
			}
			return -1;
		}

		
		private int FindPlanComplete(int arg_rowIndex, COM.FSP arg_fgrid)
		{
			int rs = -1;
			if(arg_fgrid.Rows.Count < _Rowfixed) return -1;
			for (int i = _MaxCol + 1; i < arg_fgrid.Cols.Count; i++)
			{
				if (arg_fgrid.GetCellStyle(arg_rowIndex,i)!=null)
				{
					if (arg_fgrid.GetCellStyle(arg_rowIndex,i).BackColor == Color.Gray)
					{
						rs = i;
					}					
				}
			}
			return rs;
		}

		
	
		
		private void Tbtn_SearchProcess()
		{
			try
			{
				DataTable vDt = SELECT_PLAN_SIMULATION();
//				Clear_FlexGrid(fgrid_main);
				if (vDt.Rows.Count > 0)
				{
//					Display_FlexGrid_3(vDt,ref fgrid_main,false);
//					SELECT_PLAN_SIMULATION_HEAD();
//					SELECT_PLAN_SIMULATION_VALUES();
//					CalSum();
//					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
//					FormatGird();
//					FormatGird2();
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
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}
		
		private void Display_XGanttChart(ref NETRONIC.XGantt.VcGantt arg_vcGantt, DataTable arg_DataTable)
		{
			if(arg_DataTable == null)
			{
				return;
			}
			if(arg_DataTable.Rows.Count < 1) 
			{
				return;
			}
			for(int i = 0; i < arg_DataTable.Rows.Count; i ++)
			{
				vcGantt1.InsertNodeRecord(string.Format("{0}",arg_DataTable.Rows[i].ItemArray));
			}

		}
		
		private void Tbtn_NewProcess(ref COM.FSP arg_fgrid)
		{
			try
			{
				DataTable vDt = NEW_PLAN_SIMULATION();
				Clear_FlexGrid(arg_fgrid);
				if (vDt.Rows.Count > 0)
				{
					if (vDt == null)
					{
						return;
					}
					Display_FlexGrid_3(vDt,ref arg_fgrid,true);
					NEW_PLAN_SIMULATION_HEAD(ref arg_fgrid);
					for (int i = _MainRowfixed; i < arg_fgrid.Rows.Count;i++)
					{		
						if (arg_fgrid.Rows[i].AllowEditing==false)
						{
							continue;
						}
						arg_fgrid[i, 0] = "I";
					}
					arg_fgrid.AllowMerging = AllowMergingEnum.Free;
					arg_fgrid.Cols[G1_COL_LINE_CD].AllowMerging = true;
					CalSum(ref arg_fgrid);
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
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}
		
		
		private DataTable NEW_PLAN_SIMULATION()
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SEL_NEW_PLAN_SIMULATION";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_FROM_DATE;
			MyOraDB.Parameter_Name[2]  = ARG_TO_DATE;
			MyOraDB.Parameter_Name[3]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}

		
		private void NEW_PLAN_SIMULATION_HEAD(ref COM.FSP arg_fgrid)
		{
			DataTable dt = SELECT_SPB_CAL_WORK();
			if (dt != null)
			{
				if (dt.Rows.Count > 0)
				{
					for (int i = 0; i < dt.Rows.Count; i ++ )
					{
						DateTime l_DateTime = ConvertToDateTime(dt.Rows[i][0].ToString());


						string l_value = ConvertOBS_ID(l_DateTime.Year,l_DateTime.Month);
						arg_fgrid.Cols.Add();
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].AllowSorting = false;
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].Caption = dt.Rows[i][0].ToString();
						string l_Str = GET_CAPA_QTY(cmb_Factory.SelectedValue.ToString(),
							dt.Rows[i][0].ToString(), l_value.Substring(0,2), cbm_Line.SelectedValue.ToString()).ToString();
						DateTime _dtime = ConvertToDateTime(dt.Rows[i][0].ToString());
						while(l_Str == "0")
						{
							_dtime = _dtime.AddMonths(-1);
							l_Str = GET_CAPA_QTY(cmb_Factory.SelectedValue.ToString(),
								_dtime.ToString("yyyyMMdd"), l_value.Substring(0,2), cbm_Line.SelectedValue.ToString()).ToString();
						}
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].UserData = l_Str;
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].DataType = typeof(Int32);
						arg_fgrid.Set_CellStyle_Number(arg_fgrid.Cols.Count -1);
						
						arg_fgrid[1,arg_fgrid.Cols.Count -1] = l_value;
						CellStyle c1 = arg_fgrid.Styles.Add("ColColor"+l_DateTime.Month.ToString());
						c1.ForeColor = Color.Black;
						c1.BackColor = GetColor(l_DateTime.Month);

						arg_fgrid.SetCellStyle(1,arg_fgrid.Cols.Count -1,c1);
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].Width= _DynamicColWidth;

						arg_fgrid[1,arg_fgrid.Cols.Count -1] = l_value;
						arg_fgrid[2,arg_fgrid.Cols.Count -1] = l_DateTime.ToString("MM/dd");
						arg_fgrid[3,arg_fgrid.Cols.Count -1] = dt.Rows[i][1].ToString();
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].AllowMerging=false;
						arg_fgrid.Rows[3].AllowMerging=false;
					}
				}
			}
		}

		
		private string getValueData(DataTable p_DataTable, 
			string p_line_cd,
			string p_seq,
			string p_mini_line, 
			string p_plan_ymd)
		{
			DataRow[]  rs = p_DataTable.Select("LINE_CD = '" +p_line_cd +"' AND SEQ = "+p_seq+ " AND MINI_LINE = '" + p_mini_line + "' AND PLAN_YMD='"+p_plan_ymd +"'");
			if (rs.Length == 0)
			{
				return "";
			}
			return rs[0]["PLAN_QTY"].ToString();
		}

		
	
		private object GET_CAPA_QTY(string p_factory, string p_plan_month,string p_year,string p_line_cd)
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_GET_CAPA_QTY";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = "ARG_PLAN_MONTH";
			MyOraDB.Parameter_Name[2]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[3]  = "ARG_YEAR";
			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = p_factory;
			MyOraDB.Parameter_Values[1]   = p_plan_month;
			MyOraDB.Parameter_Values[2]   = p_line_cd;
			MyOraDB.Parameter_Values[3]   = p_year;
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name].Rows[0][0];
		}

		
		private void SELECT_PLAN_SIMULATION_HEAD(ref COM.FSP arg_fgrid)
		{
			DataTable dt = SELECT_PLAN_SIMULA_SCHE_HEAD();
			/*for (int i =0 ; i < dt_header.Rows.Count; i++)
			{
				fgrid_main.Cols.Add();
				fgrid_main.Cols[fgrid_main.Cols.Count -1].DataType = typeof(Int32);
				fgrid_main.Cols[fgrid_main.Cols.Count -1].Caption = dt_header.Rows[i]["PLAN_YMD"].ToString();
				fgrid_main.Set_CellStyle_Number(fgrid_main.Cols.Count -1);
				fgrid_main[1,fgrid_main.Cols.Count -1] = ConvertToDateTime(dt_header.Rows[i]["PLAN_YMD"].ToString()).ToString("MM/dd");
				fgrid_main[2,fgrid_main.Cols.Count -1] = ConvertToDateTime(dt_header.Rows[i]["PLAN_YMD"].ToString()).ToString("MM/dd");
				fgrid_main.Cols[fgrid_main.Cols.Count -1].AllowMerging=true;
			}*/

			if (dt != null)
			{
				if (dt.Rows.Count > 0)
				{
					for (int i = 0; i < dt.Rows.Count; i ++ )
					{
						DateTime l_DateTime = ConvertToDateTime(dt.Rows[i][0].ToString());
						string l_value = ConvertOBS_ID(l_DateTime.Year,l_DateTime.Month);
						arg_fgrid.Cols.Add();
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].AllowSorting = false;
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].Caption = dt.Rows[i][0].ToString();
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].UserData = GET_CAPA_QTY(cmb_Factory.SelectedValue.ToString(),
							dt.Rows[i][0].ToString(),l_value.Substring(0,2), cbm_Line.SelectedValue.ToString());
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].DataType = typeof(Int32);
						arg_fgrid.Set_CellStyle_Number(arg_fgrid.Cols.Count -1);
						
						arg_fgrid[1,arg_fgrid.Cols.Count -1] = l_value;
						CellStyle c1 = arg_fgrid.Styles.Add("ColColor" +  l_DateTime.Month.ToString());
						c1.ForeColor = Color.Black;

						c1.BackColor = GetColor(l_DateTime.Month);
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].Width = _DynamicColWidth;
						arg_fgrid.SetCellStyle(1,arg_fgrid.Cols.Count -1,c1);
						arg_fgrid[2,arg_fgrid.Cols.Count -1] = l_DateTime.ToString("MM/dd");
						arg_fgrid[3,arg_fgrid.Cols.Count -1] = dt.Rows[i][1].ToString();
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].AllowMerging=false;
						arg_fgrid.Rows[3].AllowMerging=false;
					}
				}
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

		
		private Color GetColor(int month)
		{
			switch (month)
			{
				case 1:
					return T1_Color;
				case 2:
					return T2_Color;
				case 3:
					return T3_Color;
				case 4:
					return T4_Color;
				case 5:
					return T5_Color;
				case 6:
					return T6_Color;
				case 7:
					return T7_Color;
				case 8:
					return T8_Color;
				case 9:
					return T9_Color;
				case 10:
					return T10_Color;
				case 11:
					return T11_Color;
				case 12:
					return T12_Color;
			}
			return Color.Empty;
		}

		
		private void SELECT_PLAN_SIMULATION_VALUES(ref COM.FSP arg_fgrid)
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataTable dt1 = null;
			DataSet ds_ret;			
			try
			{
				string process_name = "PKG_SVM_PLAN_SIMULATION.SP_SEL_PLAN_SIMULA_SCHE_Values";

				MyOraDB.ReDim_Parameter(5);  
				MyOraDB.Process_Name = process_name;
   

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_FROM_DATE; 
				MyOraDB.Parameter_Name[2] = ARG_TO_DATE; 
				MyOraDB.Parameter_Name[3] = ARG_LINE_CD; 
				MyOraDB.Parameter_Name[4] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[3] = cbm_Line.SelectedValue.ToString();
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return ; 
				dt1 =  ds_ret.Tables[process_name]; 
			}
			catch
			{
				dt1 = null;
			}

			if (dt1 != null)
			{
				if (dt1.Rows.Count > 0)
				{
								
					for (int i =_MainRowfixed; i < arg_fgrid.Rows.Count; i ++ )
					{
						if (arg_fgrid.Rows[i].AllowEditing==false)
						{
							continue;
						}
						for (int j = _MaxCol + 1; j < arg_fgrid.Cols.Count; j++)
						{
							string tmp = getValueData(dt1,
								arg_fgrid.Rows[i].UserData.ToString(),
								arg_fgrid[i,G1_COL_SEQ].ToString(),
								arg_fgrid[i,G1_COL_LINE_CD].ToString(),
								arg_fgrid.Cols[j].Caption);
							if (tmp != "0")
							{
								arg_fgrid.Rows[i][j] = tmp	;
							}
						
						}
					}
				}
			}
		}

		private void FormatGird2(ref COM.FSP arg_fgrid)
		{
			CellStyle csRowLevel1 = arg_fgrid.Styles.Add("RowLevel1");
			csRowLevel1.BackColor = Color.FromArgb(241,236,248);

			CellStyle csRowLevel2 = arg_fgrid.Styles.Add("RowLevel2");
			csRowLevel2.BackColor = Color.FromArgb(217,247,197);

			CellStyle csRowLevel3 = arg_fgrid.Styles.Add("RowLevel3");
			csRowLevel3.BackColor = Color.FromArgb(255,255,255);

			if(arg_fgrid.Rows.Count<= arg_fgrid.Rows.Fixed) return;
			for(int i =  arg_fgrid.Rows.Fixed; i <  arg_fgrid.Rows.Count; i ++)
			{
				CellStyle csTmp =null;
				//row is level 1
				if(arg_fgrid.Rows[i].AllowEditing == false)
					arg_fgrid.Rows[i].Style = csRowLevel1;
				else//row is level 2
				{
					for(int j = 1; j < arg_fgrid.Cols.Count; j++)
					{
						try
						{
							if(csTmp==null) csTmp = arg_fgrid.GetCellStyle(1,FindPlanComplete(i,arg_fgrid)+1);
						}
						catch(Exception ex)
						{
							//MessageBox.Show("cho nay");
						}
						if(j >= 1 && j < _MaxCol + 1) 
							arg_fgrid.SetCellStyle(i,j,csRowLevel2);
						if(j > _MaxCol)
							if(Convert.ToString( arg_fgrid[i,j])=="" )
							{
								if ( arg_fgrid.GetCellStyle(i,j)== null)
									//if( fgrid_main.GetCellStyle(i,j).BackColor != Color.Gray)
									arg_fgrid.SetCellStyle(i,j,csRowLevel3);
							}
							else
							{
								arg_fgrid.SetCellStyle(i,j,csTmp);
							}


					}
				}
			}
		}
		private void FormatGird(ref COM.FSP arg_fgrid)
		{
			DataSet vDt;
			MyOraDB.ReDim_Parameter(5);
			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_GET_MPS_YN";
			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_FROM_DATE;
			MyOraDB.Parameter_Name[2]  = ARG_TO_DATE;
			MyOraDB.Parameter_Name[3]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return ;
			DataTable dt = vDt.Tables[MyOraDB.Process_Name];
			if (dt.Rows.Count < 1)
			{
				return;
			}
			
			for (int i = _MainRowfixed; i < arg_fgrid.Rows.Count; i ++)
			{
				if (arg_fgrid.Rows[i].AllowEditing==false)
				{
					continue;
				}
				for (int j = _MaxCol + 1; j < arg_fgrid.Cols.Count; j ++)
				{
					for (int k =0 ; k< dt.Rows.Count; k++)
					{
						
                        if (arg_fgrid[i,G1_COL_LINE_CD].ToString().Equals(dt.Rows[k][1].ToString())//mini lineTODO
							&& 
							arg_fgrid.Cols[j].Caption.Equals(dt.Rows[k][0].ToString())//plan ymd
							&& dt.Rows[k][2].ToString().Equals("Y")//mps yn
							&& arg_fgrid.Rows[i].UserData.ToString().Equals(dt.Rows[k][3].ToString())//LINE_CD
							&& arg_fgrid[i,G1_COL_SEQ].ToString().Equals(dt.Rows[k][4].ToString())//SEQ
							)
                        {
							if (arg_fgrid.GetCellStyle(i,j) == null)
							{
								CellStyle cs1=arg_fgrid.Styles.Add("PlanComplete");
								cs1.BackColor =  Color.Gray;
								arg_fgrid.SetCellStyle(i,j,cs1);
							}
                        }
					}
				}
			}
			//format color for grid
//			for(int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow ++)
//			{
//				for(int iCol=_MaxCol + 1; iCol<fgrid_main.Rows.Count; iCol++)
//				{
//					//if(fgrid_main[iRow,iCol].ToString()="")
//						//continuos
//					---
//
//				}
//			}
			
		}


		private void CalSum(ref COM.FSP arg_fgrid)
		{
			int rs = 0;
			for (int i =_MainRowfixed ; i <arg_fgrid.Rows.Count; i++)
			{
				if (arg_fgrid.Rows[i].AllowEditing==false)
				{
					continue;
				}
				for (int j =  _MaxCol + 1; j < arg_fgrid.Cols.Count; j++)
				{
					if(arg_fgrid[i,j] == null) continue;
					if(arg_fgrid[i,j].ToString() == "")
						continue;
					else
						rs += int.Parse(arg_fgrid[i,j].ToString().Replace(",",""));
				}
				arg_fgrid[i,G1_COL_PLAN_QTY] = rs;
				rs = 0;
			}			
		}

						
		private void Display_FlexGrid(DataTable arg_dt,ref COM.FSP  p_fgControl)
		{
			int iCount = arg_dt.Rows.Count;
			_Rowfixed = p_fgControl.Rows.Fixed;
			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = p_fgControl.Rows.InsertNode(_Rowfixed + iRow, 1);

				p_fgControl[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol < arg_dt.Columns.Count ; iCol++)
				{
					p_fgControl[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}
			}
		}
		// 메뉴 최상단 표시
		private string _RootDesc = "Root";
		private int _RootLevel = 0; 
		private string _TypeRoot = "R";
		private string _RootMenuKey = "-1";

		private int _MenuLevel = 1;

		private string _SeparatorDesc = "-";


		private void Display_FlexGrid_3(DataTable arg_dt,ref COM.FSP  p_fgControl, bool arg_is_new)
		{
			int level = 0;

			p_fgControl.Tree.Column = G1_COL_LINE_CD;
			p_fgControl.Tree.Style = TreeStyleFlags.Complete;
			p_fgControl.Tree.Show(-1);
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				level = Convert.ToInt32( arg_dt.Rows[i]["LV"].ToString() );

				p_fgControl.Rows.InsertNode(i + _MainRowfixed, level);

					if (level == 0)
					{
						p_fgControl[i + _MainRowfixed, G1_COL_LINE_CD ] = arg_dt.Rows[i]["LINE_CD"].ToString();
						p_fgControl.Rows[i + _MainRowfixed].AllowEditing = false;						
					}
					else
					{
						p_fgControl.Rows[i + _MainRowfixed].AllowEditing = true;
						p_fgControl[i + _MainRowfixed, G1_COL_FACTORY ] = arg_dt.Rows[i]["FACTORY"].ToString();
						p_fgControl[i + _MainRowfixed, G1_COL_SEQ ] = arg_dt.Rows[i]["SEQ"].ToString();
						p_fgControl.Rows[i + _MainRowfixed].UserData = arg_dt.Rows[i]["LINE_CD"].ToString();
						p_fgControl[i + _MainRowfixed, G1_COL_LINE_CD ] = arg_dt.Rows[i]["MINI_LINE"].ToString();
						if (!arg_is_new)
						{						
							p_fgControl[i + _MainRowfixed, G1_COL_PLAN_YMD ] = arg_dt.Rows[i]["PLAN_YMD"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_1 ] = arg_dt.Rows[i]["MID_SOLE_1"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_2 ] = arg_dt.Rows[i]["MID_SOLE_2"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_3 ] = arg_dt.Rows[i]["MID_SOLE_3"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_MODEL_CD ] = arg_dt.Rows[i]["MODEL_CD"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_OS_CODE ] = arg_dt.Rows[i]["OS_CODE"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_ITEM ] = arg_dt.Rows[i]["ITEM"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_ODS_ID ] = arg_dt.Rows[i]["OBS_ID"].ToString();
						}
						
					}

			} 
		}

		
		private void Clear_FlexGrid(COM.FSP p_fgControl)
		{
			if (p_fgControl.Rows.Fixed != p_fgControl.Rows.Count)
			{				
				p_fgControl.Clear(ClearFlags.UserData, p_fgControl.Rows.Fixed, 1, p_fgControl.Rows.Count - 1, p_fgControl.Cols.Count - 1);
				p_fgControl.Rows.Count = p_fgControl.Rows.Fixed;					
			}
			for (int i = p_fgControl.Cols.Count -1; i > _MaxCol  ; i --)
			{
				p_fgControl.Cols.Remove(i);
			}			
		}

		private void Clear_FlexGrid1(COM.FSP p_fgControl)
		{
			if (p_fgControl.Rows.Fixed != p_fgControl.Rows.Count)
			{				
				p_fgControl.Clear(ClearFlags.UserData, p_fgControl.Rows.Fixed, 1, p_fgControl.Rows.Count - 1, p_fgControl.Cols.Count - 1);
				p_fgControl.Rows.Count = p_fgControl.Rows.Fixed;					
			}	
		}
		
		
		private DataTable SELECT_LINE_INFO()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;			
			try
			{
				string process_name = "PKG_SBM_LLT_PLAN_TRACKING.SELECT_LINE_INFO";

				MyOraDB.ReDim_Parameter(2);  
				MyOraDB.Process_Name = process_name;
   

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = OUT_CURSOR; 

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


		private DataTable SELECT_PLAN_SIMULA_SCHE_HEAD()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;			
			try
			{
				string process_name = "PKG_SVM_PLAN_SIMULATION.SP_SEL_PLAN_SIMULA_SCHE_Head";

				MyOraDB.ReDim_Parameter(5);  
				MyOraDB.Process_Name = process_name;

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_FROM_DATE; 
				MyOraDB.Parameter_Name[2] = ARG_TO_DATE; 
				MyOraDB.Parameter_Name[3] = ARG_LINE_CD; 
				MyOraDB.Parameter_Name[4] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[3] = cbm_Line.SelectedValue.ToString();
				MyOraDB.Parameter_Values[4] = ""; 

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


		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
//				if (SAVE_PLAN_SIMULATION(fgrid_main))
//				{
//					fgrid_main.Refresh_Division();
//					this.Tbtn_SearchProcess_2();
//				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		
		
		private bool Validate_Check(ref COM.FSP arg_fgrid)
		{
			if (arg_fgrid.Rows.Count <= _MainRowfixed)
			{
				return false;
			}
			if (cbm_Line.SelectedValue.Equals(" "))
			{
				return false;
			}
			for(int i = _MainRowfixed; i < arg_fgrid.Rows.Count; i++)
			{
				if(arg_fgrid.Rows[i].AllowEditing == false) continue;
				object objMid1 = arg_fgrid.Rows[i][G1_COL_MID_SOLE_1];
				if(objMid1 != null)
				{
					for(int j = _MainRowfixed ; j< arg_fgrid.Rows.Count; j++)
					{
						object objTmp = arg_fgrid[j,G1_COL_MID_SOLE_2];
						if(objTmp != null)
						{
							if(objMid1.ToString() == objTmp.ToString()) 
							{
								if(objMid1.ToString() != "" || objTmp.ToString() != "")
									return false;
							}
						}
					}
					for(int k = _MainRowfixed ; k< arg_fgrid.Rows.Count; k++)
					{
						object objTmp = arg_fgrid[k,G1_COL_MID_SOLE_3];
						if(objTmp != null)
						{
							if(objMid1.ToString() == objTmp.ToString())
							{
								if(objMid1.ToString() != "" || objTmp.ToString() != "")
									return false;
							}
						}
					}
				}
				object objMid2 = arg_fgrid.Rows[i][G1_COL_MID_SOLE_2];
				if(objMid2 != null)
				{
					for(int h = _MainRowfixed; h< arg_fgrid.Rows.Count; h++)
					{
						object objTmp = arg_fgrid[h,G1_COL_MID_SOLE_3];
						if(objTmp != null)
						{
							if(objMid2.ToString() == objTmp.ToString())
							{
								if(objMid2.ToString() != "" || objTmp.ToString() != "")
									return false;
							}
						}
					}
				}
			}
			return true;
		}

		
		
		private DataTable SELECT_PLAN_SIMULATION()
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION2.SP_SEL_PLAN_SIMULATION";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_FROM_DATE;
			MyOraDB.Parameter_Name[2]  = ARG_TO_DATE;
			MyOraDB.Parameter_Name[3]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}


		private DataTable SELECT_GROWTH_PLAN()
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION2.SP_SEL_SVM_GROWTH_PLAN";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[2]  = ARG_FROM_DATE;
			MyOraDB.Parameter_Name[3]  = ARG_TO_DATE;
			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2]   = dpick_date_from.Value.ToString("yyyyMM");
			MyOraDB.Parameter_Values[3]   = dpick_date_To.Value.ToString("yyyyMM");
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}
		
		
		private bool SAVE_PLAN_SIMULATION(COM.FSP arg_fgrid)
		{
			try
			{
				int para_ct = 0; 
				int iCount  = 15;
				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_INS_SVM_PLAN_SIMULATION";

				//02.ARGURMENT OF PROC
				MyOraDB.Parameter_Name[0] = ARG_FACTORY;
				MyOraDB.Parameter_Name[1] = ARG_LINE_CD;
				MyOraDB.Parameter_Name[2] = ARG_MINI_LINE;
				MyOraDB.Parameter_Name[3] = ARG_PLAN_YMD;
				//MyOraDB.Parameter_Name[4] = ARG_MID_SOLE_1;
				//MyOraDB.Parameter_Name[5] = ARG_MID_SOLE_2;
				//MyOraDB.Parameter_Name[6] = ARG_MID_SOLE_3;
				MyOraDB.Parameter_Name[4] = ARG_OS_CODE;
				MyOraDB.Parameter_Name[5] = ARG_ITEM;
				MyOraDB.Parameter_Name[6] = ARG_PLAN_QTY;
				MyOraDB.Parameter_Name[7] = ARG_UPD_USER;
				MyOraDB.Parameter_Name[8] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[9] = ARG_MPS_YN;
				MyOraDB.Parameter_Name[10] = ARG_WORK_DAYS;
				MyOraDB.Parameter_Name[11] = ARG_DAILY_CAPA;
				MyOraDB.Parameter_Name[12] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[13] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[14] = "ARG_SEQ";
				
				//03. Type
				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.Number;
				MyOraDB.Parameter_Type[14] = (int)OracleType.Number;
				MyOraDB.Parameter_Values  = new string[iCount * (arg_fgrid.Rows.Count - 1 - _MainRowfixed) * ( arg_fgrid.Cols.Count -  1 - _MaxCol)];
				for (int iRow = _MainRowfixed; iRow < arg_fgrid.Rows.Count ; iRow++)
				{
					if (arg_fgrid.Rows[iRow].AllowEditing==false)
					{
						continue;
					}
					int _colPlanComplete = -1;
					_colPlanComplete = FindPlanComplete(iRow,arg_fgrid);
					for (int iCol = _MaxCol + 1;iCol < arg_fgrid.Cols.Count; iCol ++)
					{					
						MyOraDB.Parameter_Values[para_ct + 0] = Convert.ToString(cmb_Factory.SelectedValue);
						MyOraDB.Parameter_Values[para_ct + 1] = Convert.ToString(arg_fgrid.Rows[iRow].UserData);//line cd
						MyOraDB.Parameter_Values[para_ct + 2] = Convert.ToString(arg_fgrid[iRow, G1_COL_LINE_CD]);//mini line
						MyOraDB.Parameter_Values[para_ct + 3] =  arg_fgrid.Cols[iCol].Caption;
						//MyOraDB.Parameter_Values[para_ct + 4] = Convert.ToString(fgrid_main[iRow, G1_COL_MID_SOLE_1]);
						//MyOraDB.Parameter_Values[para_ct + 5] = Convert.ToString(fgrid_main[iRow, G1_COL_MID_SOLE_2]);
						//MyOraDB.Parameter_Values[para_ct + 6] = Convert.ToString(fgrid_main[iRow, G1_COL_MID_SOLE_3]);
						MyOraDB.Parameter_Values[para_ct + 4] = Convert.ToString(arg_fgrid[iRow, G1_COL_OS_CODE]);
						MyOraDB.Parameter_Values[para_ct + 5] = Convert.ToString(arg_fgrid[iRow, G1_COL_ITEM]);
						if (  arg_fgrid[iRow, iCol] == null)
						{
							MyOraDB.Parameter_Values[para_ct+ 6] = "0";
						} 
						else
						{
							MyOraDB.Parameter_Values[para_ct+ 6] = Convert.ToString(arg_fgrid[iRow, iCol]).Replace(",","");
						}
						MyOraDB.Parameter_Values[para_ct+ 7] = COM.ComVar.This_User;
						if (ClassLib.ComFunction.NullToBlank(arg_fgrid[iRow, 0]).Equals("D"))
							MyOraDB.Parameter_Values[para_ct+ 8] = arg_fgrid[iRow, 0].ToString();
						else
							MyOraDB.Parameter_Values[para_ct+ 8] = "O";
						
						
						if (_colPlanComplete != -1)
						{
							if (_MaxCol <iCol && iCol <= _colPlanComplete)
							{
								MyOraDB.Parameter_Values[para_ct+ 9] = "Y";
							}
							else
							{
								MyOraDB.Parameter_Values[para_ct+ 9] = "N";
							}
						}
						else
							MyOraDB.Parameter_Values[para_ct+ 9] = "N";

						MyOraDB.Parameter_Values[para_ct+ 10] = Convert.ToString(arg_fgrid[3, iCol]);
						MyOraDB.Parameter_Values[para_ct+ 11] = Convert.ToString(arg_fgrid.Cols[iCol].UserData);
						MyOraDB.Parameter_Values[para_ct+ 12] = Convert.ToString(arg_fgrid[iRow, G1_COL_MODEL_CD]);
						MyOraDB.Parameter_Values[para_ct+ 13] = Convert.ToString(arg_fgrid[iRow, G1_COL_ODS_ID]);
						MyOraDB.Parameter_Values[para_ct+ 14] = Convert.ToString(arg_fgrid[iRow, G1_COL_SEQ]);

						para_ct += iCount;	
					}
				}

				MyOraDB.Add_Modify_Parameter(true);
				
				
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;

			}
			catch(System.Exception ex)
			{
				return false;
			}
			
			//return true;
		}

		
		private DataTable SELECT_SPB_CAL_WORK()
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SEL_NEW_PLAN_SIMULATION_HEAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_FROM_DATE;
			MyOraDB.Parameter_Name[2]  = ARG_TO_DATE;
			MyOraDB.Parameter_Name[3]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}

		
		private DateTime ConvertToDateTime(string p_yyyyMMdd)
		{
			return DateTime.ParseExact(p_yyyyMMdd,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
		}
		

		private string CalSeq(string arg_line_cd,string arg_mini_line, COM.FSP arg_fgrid)
		{
			int l_tmp = 1;
			for (int i = 0;i < arg_fgrid.Rows.Count; i++)
			{
				if (arg_fgrid.Rows[i].AllowEditing==false)
				{
					continue;
				}
				if(arg_fgrid[i,G1_COL_LINE_CD].ToString().Equals(arg_mini_line)
					&& arg_line_cd == arg_fgrid.Rows[i].UserData.ToString())
				{
					int curSeq = 1;
					if (arg_fgrid[i,G1_COL_SEQ]!=null)
					{
						if (arg_fgrid[i,G1_COL_SEQ].ToString()!="")
						{
							curSeq = int.Parse(arg_fgrid[i,G1_COL_SEQ].ToString());
							if (curSeq > l_tmp)
							{
								l_tmp = curSeq;
							}							
						}
					}
				}	
				else
					continue;
			}
			return Convert.ToString(l_tmp + 1);
		}
		
		
		#endregion

		private void dpick_date_from_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			tbtn_Search_Click(tbtn_Search,null);
		}

		private void dpick_date_To_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			tbtn_Search_Click(tbtn_Search,null);
		}

		
		
	}
}
