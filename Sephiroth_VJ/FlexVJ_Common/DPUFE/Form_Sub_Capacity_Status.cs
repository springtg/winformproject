using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;
using System.Drawing.Printing;

namespace FlexVJ_Common.DPUFE
{
	public class Form_Sub_Capacity_Status : COM.VJ_CommonWinForm.Form_Top
	{
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.DateTimePicker dtp_date_from;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_date;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.DateTimePicker dtp_date_to;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private MyGrid fgrid_main;
		private System.ComponentModel.IContainer components = null;

		public Form_Sub_Capacity_Status()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Sub_Capacity_Status));
			this.pnl_head = new System.Windows.Forms.Panel();
			this.dtp_date_from = new System.Windows.Forms.DateTimePicker();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_date = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.btn_groupSearch = new System.Windows.Forms.Label();
			this.dtp_date_to = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new FlexVJ_Common.DPUFE.MyGrid();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			this.panel2.SuspendLayout();
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
			this.lbl_MainTitle.Text = "Sub Capacity Status";
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
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.dtp_date_from);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.lbl_date);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.lbl_Factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.btn_groupSearch);
			this.pnl_head.Controls.Add(this.dtp_date_to);
			this.pnl_head.Controls.Add(this.label3);
			this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_head.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_head.Location = new System.Drawing.Point(0, 80);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1016, 88);
			this.pnl_head.TabIndex = 30;
			// 
			// dtp_date_from
			// 
			this.dtp_date_from.CustomFormat = "yyyy-MM-dd";
			this.dtp_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_date_from.Location = new System.Drawing.Point(445, 39);
			this.dtp_date_from.Name = "dtp_date_from";
			this.dtp_date_from.Size = new System.Drawing.Size(98, 22);
			this.dtp_date_from.TabIndex = 585;
			this.dtp_date_from.ValueChanged += new System.EventHandler(this.dtp_date_from_ValueChanged);
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
			this.cmb_factory.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(220, 21);
			this.cmb_factory.TabIndex = 563;
			this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
			// 
			// lbl_date
			// 
			this.lbl_date.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_date.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_date.ImageIndex = 0;
			this.lbl_date.ImageList = this.img_Label;
			this.lbl_date.Location = new System.Drawing.Point(344, 40);
			this.lbl_date.Name = "lbl_date";
			this.lbl_date.Size = new System.Drawing.Size(100, 21);
			this.lbl_date.TabIndex = 414;
			this.lbl_date.Text = "Plan Date";
			this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(224, 30);
			this.label2.TabIndex = 393;
			this.label2.Text = "      Search Information";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(1000, 72);
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
			this.pic_head4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 71);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(976, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 40);
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
			this.pic_head7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(915, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 47);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
			this.pic_head2.Location = new System.Drawing.Point(1000, 0);
			this.pic_head2.Name = "pic_head2";
			this.pic_head2.Size = new System.Drawing.Size(16, 32);
			this.pic_head2.TabIndex = 44;
			this.pic_head2.TabStop = false;
			// 
			// pic_head5
			// 
			this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
			this.pic_head5.Location = new System.Drawing.Point(0, 72);
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
			this.pic_head6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
			this.pic_head6.Location = new System.Drawing.Point(0, 0);
			this.pic_head6.Name = "pic_head6";
			this.pic_head6.Size = new System.Drawing.Size(168, 70);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// pic_head1
			// 
			this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
			this.pic_head1.Location = new System.Drawing.Point(152, 0);
			this.pic_head1.Name = "pic_head1";
			this.pic_head1.Size = new System.Drawing.Size(944, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// btn_groupSearch
			// 
			this.btn_groupSearch.Location = new System.Drawing.Point(0, 0);
			this.btn_groupSearch.Name = "btn_groupSearch";
			this.btn_groupSearch.TabIndex = 583;
			// 
			// dtp_date_to
			// 
			this.dtp_date_to.CustomFormat = "yyyy-MM-dd";
			this.dtp_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_date_to.Location = new System.Drawing.Point(567, 39);
			this.dtp_date_to.Name = "dtp_date_to";
			this.dtp_date_to.Size = new System.Drawing.Size(98, 22);
			this.dtp_date_to.TabIndex = 585;
			this.dtp_date_to.ValueChanged += new System.EventHandler(this.dtp_date_to_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(544, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(15, 18);
			this.label3.TabIndex = 584;
			this.label3.Text = "~";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 168);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1016, 476);
			this.panel2.TabIndex = 31;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,80,Columns:1{TextAlign:RightCenter;}\t";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_main.Size = new System.Drawing.Size(1016, 476);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 179;
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// Form_Sub_Capacity_Status
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnl_head);
			this.Name = "Form_Sub_Capacity_Status";
			this.Text = "Sub Capacity Status";
			this.Load += new System.EventHandler(this.Form_Sub_Capacity_Status_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_head, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		#region "variable Declare"
		private int _MainRowfixed = 0;
		private string _FontName = "Verdana";
		private float _FontSize = 7;
		private int _MaxCol = 4;
		private int _DynamicColWidth = 50;
		private string _FormatNumber = "#,##0.##########";  
		private COM.OraDB MyOraDB = new COM.OraDB();

		private CellStyle _CellCapacity = null;
		private CellStyle _CellPlan = null;
		private CellStyle _CellVar = null;
		private CellStyle _CellException = null;
		private CellStyle _CellPlanText = null;
		private CellStyle _CellOtherText = null;

		private const string RowCapacity = "Capacity";
		private const string RowPlan = "Plan";
		private const string RowVar = "Var.";

		#endregion

		#region "Constant Argument"
		private const string ARG_FACTORY = "ARG_FACTORY";
		private const string ARG_CAPA_QTY = "ARG_CAPA_QTY";
		private const string ARG_MID_SOLE = "ARG_MID_SOLE";
		private const string ARG_PLAN_YMD = "ARG_PLAN_YMD";
		private const string ARG_UPD_USER = "ARG_UPD_USER";
		private const string OUT_CURSOR = "OUT_CURSOR";
		private const string ARG_FROM_DATE = "ARG_FROM_DATE";
		private const string ARG_TO_DATE = "ARG_TO_DATE";

		#endregion
		
		
		
		private void Form_Sub_Capacity_Status_Load(object sender, System.EventArgs e)
		{			
			InitControl();
			InitCellStyle();
			tbtn_Search_Click(tbtn_Search, null);
		}


		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			tbtn_Search_Click(tbtn_Search,null);
		}

		private void dtp_date_from_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void dtp_date_to_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;				
				Tbtn_SearchProcess();
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

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DialogResult dr;

			if (Validate_Check())
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

		private void InitControl()
		{
			//tool bar button
			tbtn_Append.Enabled=false;
			tbtn_Color.Enabled=false;
			tbtn_Confirm.Enabled=false;
			tbtn_Create.Enabled=false;
			tbtn_Delete.Enabled=false;
			tbtn_Insert.Enabled=false;
			tbtn_New.Enabled=false;
			//tbtn_Print.Enabled=false;
			//tbtn_Save.Enabled=false;
			//tbtn_Search.Enabled=false;

			//init header control
			DataTable dt_ret;

			// cmb factory
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			//date control
			string sFrom_date = System.DateTime.Now.ToString("yyyy-MM-dd");
			string sTo_date   = System.DateTime.Now.AddMonths(2).ToString("yyyy-MM-dd");
						 
			dtp_date_from.Text = sFrom_date;
			dtp_date_to.Text   = sTo_date;

			//init gird main
			fgrid_main.Set_Grid("LST_SUB_CAPACITY_STATUS","1",2,COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);	
			_MainRowfixed = fgrid_main.Rows.Fixed;
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Font = new Font(_FontName, _FontSize);
			_MaxCol = fgrid_main.Cols.Count;
			Clear_FlexGrid(fgrid_main);
			Init_Dynamic_Grid_Header(ref fgrid_main);
			dt_ret.Dispose();
		}

		private DateTime ConvertToDateTime(string p_yyyyMMdd)
		{
			return DateTime.ParseExact(p_yyyyMMdd,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
		}

		
		private void Init_Dynamic_Grid_Header( ref MyGrid arg_grid)
		{
			DataTable dt = Select_Header_Value(Convert.ToString(cmb_factory.SelectedValue),
				dtp_date_from.Value.ToString("yyyyMMdd"), dtp_date_to.Value.ToString("yyyyMMdd"));
			if(dt != null)
			{
				if(dt.Rows.Count > 0)
				{
					for(int i = 0; i< dt.Rows.Count; i ++)
					{
						arg_grid.Cols.Add();
						int l_CurColIndex = arg_grid.Cols.Count - 1;
						string l_Plan_ymd = Convert.ToString(dt.Rows[i]["PLAN_YMD"]);
						int l_Work_Days = Convert.ToInt32(Convert.ToString( dt.Rows[i]["WORK_DAYS"]));
						arg_grid.Cols[l_CurColIndex].Caption = l_Plan_ymd;
						arg_grid[1,l_CurColIndex] = ConvertToDateTime(l_Plan_ymd).ToString("MM-dd");
						arg_grid[2,l_CurColIndex] = Convert.ToString(l_Work_Days);
					}
					arg_grid.Rows[2].AllowMerging = false;
				}
			}
			arg_grid.Cols[1].AllowMerging = true;
			arg_grid.Cols[2].AllowMerging = true;
		}
		
		
		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			MyGrid l_fgrid_main =(MyGrid)sender;
			CalVarCell(l_fgrid_main,e.Row,e.Col);
		}

		struct STMidSole
		{
			public const string L_CMP ="CMP";//CMP
			public const string L_P_L ="PHP";//'P/L';
			public const string L_IP_IPF ="IPR";// 'IP/IPF';
			public const string L_PU = "PUP";// 'PU';
			public const string L_PUCK = "PPP" ;//'PUCK';
		}
		struct STMidSoleColor
		{
			public static Color L_CMP =Color.LightCoral;
			public static  Color L_P_L =Color.LightCyan;
			public  static Color L_IP_IPF =Color.LightGoldenrodYellow;
			public static Color L_PU = Color.LightGray;
			public static Color L_PUCK = Color.LightSalmon;
		}
	
		private CellStyle InitCellStyle(int i, string arg_mid_sole, string row_type, bool arg_number)
		{

				CellStyle _CellVar1;
				_CellVar1 = fgrid_main.Styles.Add(arg_mid_sole + i.ToString() + row_type);
			if(row_type == RowPlan)
			{
				_CellVar1.ForeColor = Color.RoyalBlue;
			}
			else
			{
				_CellVar1.ForeColor = Color.Black;
			}

			if(arg_number)
			{
				_CellVar1.DataType = typeof(double);
				_CellVar1.Format = _FormatNumber;
			}
			else
			{
				_CellVar1.DataType = typeof(string);
			}
			if(row_type == RowVar)
			{
				_CellVar1.Font=new Font(_FontName,_FontSize,FontStyle.Bold,GraphicsUnit.Point);				
			}
			else
			{
				_CellVar1.Font=new Font(_FontName,_FontSize,FontStyle.Regular,GraphicsUnit.Point);				
			}
			return _CellVar1;
		}

		
		private void InitCellStyle()
		{
			if(_CellCapacity == null)
			{
				_CellCapacity = fgrid_main.Styles.Add("CAPACITY");
				_CellCapacity.ForeColor = Color.Black;
				_CellCapacity.Border.Style = BorderStyleEnum.Dotted;
				_CellCapacity.Border.Color = Color.LightBlue;
				_CellCapacity.Border.Direction = BorderDirEnum.Horizontal;
				_CellCapacity.DataType = typeof(double);
				_CellCapacity.Format = _FormatNumber;
				_CellCapacity.Font =new Font(_FontName,_FontSize,FontStyle.Regular,GraphicsUnit.Point);
			}
			if(_CellPlan == null)
			{
				_CellPlan = fgrid_main.Styles.Add("PLAN");
				_CellPlan.ForeColor = Color.FromArgb(97,187,255);
				_CellPlan.TextAlign = TextAlignEnum.RightCenter;
				_CellPlan.Border.Style = BorderStyleEnum.Dotted;	
				_CellPlan.Border.Direction = BorderDirEnum.Horizontal;
				_CellPlan.Border.Color = Color.LightBlue;
				_CellPlan.DataType = typeof(double);
				_CellPlan.Format = _FormatNumber;
				_CellPlan.Font=new Font(_FontName,_FontSize,FontStyle.Regular,GraphicsUnit.Point);				
			}
			if(_CellVar == null)
			{
				_CellVar = fgrid_main.Styles.Add("VAR");
				_CellVar.ForeColor = Color.Black;
				_CellVar.Border.Style = BorderStyleEnum.Dotted;	
				_CellVar.Border.Color = Color.LightBlue;
				_CellVar.Border.Direction = BorderDirEnum.Horizontal;
				_CellVar.DataType = typeof(double);
				_CellVar.Format = _FormatNumber;
				_CellVar.Font=new Font(_FontName,_FontSize,FontStyle.Bold,GraphicsUnit.Point);				
			}
			if(_CellException == null)
			{
				_CellException = fgrid_main.Styles.Add("EXCEPTION");
				_CellException.ForeColor = Color.White;
				_CellException.Border.Style = BorderStyleEnum.Dotted;	
				_CellException.Border.Color = Color.LightBlue;
				_CellException.BackColor = Color.Red;
				_CellException.DataType = typeof(double);
				_CellException.Format = _FormatNumber;
				_CellException.Font=new Font(_FontName,_FontSize,FontStyle.Bold,GraphicsUnit.Point);				
			}
			if(_CellPlanText == null)
			{
				_CellPlanText = fgrid_main.Styles.Add("PLANTEXT");
				_CellPlanText.ForeColor = Color.FromArgb(97,187,255);
				//_CellPlanText.Border.Style = BorderStyleEnum.Dotted;	
				//_CellPlanText.Border.Color = Color.LightBlue;
				//_CellPlanText.Border.Direction = BorderDirEnum.Horizontal;
				_CellPlanText.DataType = typeof(string);
				_CellPlanText.Font=new Font(_FontName,_FontSize,FontStyle.Regular,GraphicsUnit.Point);
				
			}
			if(_CellOtherText == null)
			{
				_CellOtherText = fgrid_main.Styles.Add("OTHERTEXT");
				_CellOtherText.ForeColor = Color.Black;
				//_CellOtherText.Border.Style = BorderStyleEnum.Dotted;	
				//_CellOtherText.Border.Color = Color.LightBlue;
				_CellOtherText.DataType = typeof(string);
				_CellOtherText.Font=new Font(_FontName,_FontSize,FontStyle.Regular,GraphicsUnit.Point);
				
			}
		}
	
		
		private void Tbtn_SearchProcess()
		{
			Clear_FlexGrid(fgrid_main);
			Init_Dynamic_Grid_Header(ref fgrid_main);
			DataTable dt = Select_Mid_Sole(Convert.ToString(cmb_factory.SelectedValue));
			Display_FlexGrid(dt,ref fgrid_main);
			FormatGrid();
			CalVarRow(fgrid_main);			
			dt.Dispose();
		}
		private void Clear_FlexGrid(MyGrid p_fgControl)
		{
			if (p_fgControl.Rows.Fixed != p_fgControl.Rows.Count)
			{				
				p_fgControl.Clear(ClearFlags.UserData, p_fgControl.Rows.Fixed, 1, p_fgControl.Rows.Count - 1, p_fgControl.Cols.Count - 1);
				p_fgControl.Rows.Count = p_fgControl.Rows.Fixed;					
			}
			for (int i = p_fgControl.Cols.Count -1; i >= _MaxCol  ; i --)
			{
				p_fgControl.Cols.Remove(i);
			}			
		}

	
		private void CalVarRow(MyGrid arg_Grid)
		{
			if(_MainRowfixed >= arg_Grid.Rows.Count) 
			{
				return;
			}
			for( int i = _MainRowfixed; i < arg_Grid.Rows.Count; i++)
			{
				if(arg_Grid.Rows[i].Caption != RowVar)
				{
					continue;
				}
				int iRowCapacity = i - 2;
				int iRowPlan = i - 1;
				int iRowVar = i;
				for(int j = _MaxCol; j < arg_Grid.Cols.Count; j ++)
				{
					string _TmpCapacity = Convert.ToString(arg_Grid[iRowCapacity,j]);
					if(_TmpCapacity != "")
					{
						double _ValueCapacity = double.Parse(_TmpCapacity);
						string _TmpPlan = Convert.ToString(arg_Grid[iRowPlan,j]);
						double _rs = 0;
						if(_TmpPlan != "")
						{
							double _ValuePlan = double.Parse(_TmpPlan);
							_rs =  _ValueCapacity - _ValuePlan;							
							arg_Grid[iRowVar,j] = _rs;							
						}
						else
						{
							_rs =  _ValueCapacity ;
							arg_Grid[iRowVar,j] = _rs;
						}
						if(_rs < 0)
						{
							arg_Grid.SetCellStyle(iRowVar,j,_CellException);
						}
						else
						{
							//_CellVar.BackColor = arg_Grid.GetCellStyle(iRowVar -1,j).BackColor;
							//arg_Grid.SetCellStyle(iRowVar,j,_CellVar);

							//arg_Grid.SetCellStyle(iRowVar,j,InitCellStyle(iRowVar,arg_Grid.GetCellStyle(iRowVar -1,j).BackColor));

							//arg_Grid.GetCellStyle(iRowVar,j).BackColor =  arg_Grid.GetCellStyle(iRowVar -1,j).BackColor;


						}
					}
				}
			}
		}
	
	
		private void CalVarCell(MyGrid arg_Grid, int arg_Row, int arg_Col)
		{
			if(_MainRowfixed >= arg_Grid.Rows.Count) 
			{
				return;
			}
			int iRowCapacity = arg_Row - 1;
			int iRowPlan = arg_Row;
			int iRowVar = arg_Row + 1;
			string _TmpCapacity = Convert.ToString(arg_Grid[iRowCapacity,arg_Col]);
			if(_TmpCapacity != "")
			{
				double _ValueCapacity = double.Parse(_TmpCapacity);
				string _TmpPlan = Convert.ToString(arg_Grid[iRowPlan,arg_Col]);
				double _rs = 0;
				if(_TmpPlan != "")
				{
					double _ValuePlan = double.Parse(_TmpPlan);
					_rs = _ValueCapacity - _ValuePlan;
					arg_Grid[iRowVar,arg_Col] = _rs ; 
				}
				else
				{
					_rs = _ValueCapacity ;
					arg_Grid[iRowVar,arg_Col] = _rs ; 
				}
				if(_rs < 0)
				{
					arg_Grid.SetCellStyle(iRowVar,arg_Col,_CellException);
				}
				else
				{
					//_CellVar.BackColor = arg_Grid.GetCellStyle(iRowVar -1,arg_Col).BackColor;
					arg_Grid.SetCellStyle(iRowVar,arg_Col,_CellVar);

					arg_Grid.GetCellStyle(iRowVar,arg_Col).BackColor =  arg_Grid.GetCellStyle(iRowVar -1,arg_Col).BackColor;
				}
			}
		}

		
		private DataTable Select_Header_Value(string arg_factory, string arg_date_from, string arg_date_to)
		{
			DataSet ds_ret;	
			DataTable dt = null;
			try
			{
				MyOraDB.ReDim_Parameter(4);  
				MyOraDB.Process_Name = "PKG_SVM_COMP_SUB_CAPA.SP_SEL_PLAN_SCHEDULE_Head";;

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_FROM_DATE; 
				MyOraDB.Parameter_Name[2] = ARG_TO_DATE; 
				MyOraDB.Parameter_Name[3] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_date_from;
				MyOraDB.Parameter_Values[2] = arg_date_to;
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) 
				{
					dt = null ;
				}
				else
				{
					dt = ds_ret.Tables[MyOraDB.Process_Name]; 
				}
			}
			catch
			{
				dt = null;
			}
			return dt;
		}

		
		private DataTable Select_Sub_Capacity(string arg_factory, string arg_date_from, string arg_date_to)
		{
			DataSet ds_ret;	
			DataTable dt = null;
			try
			{
				MyOraDB.ReDim_Parameter(4);  
				MyOraDB.Process_Name = "PKG_SVM_COMP_SUB_CAPA.SP_GET_SUB_CAP_ALL_COMP";

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_FROM_DATE; 
				MyOraDB.Parameter_Name[2] = ARG_TO_DATE; 
				MyOraDB.Parameter_Name[3] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_date_from;
				MyOraDB.Parameter_Values[2] = arg_date_to;
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) 
				{
					dt = null ;
				}
				else
				{
					dt = ds_ret.Tables[MyOraDB.Process_Name]; 
				}
			}
			catch
			{
				dt = null;
			}
			return dt;
		}

		private DataTable Select_Mid_Sole(string arg_factory)
		{
			DataSet ds_ret;	
			DataTable dt = null;
			try
			{
				MyOraDB.ReDim_Parameter(3);  
				MyOraDB.Process_Name = "PKG_SVM_COMP_SUB_CAPA.SP_SEL_COM_CODE";

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = "ARG_COM_CD"; 
				MyOraDB.Parameter_Name[2] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = "SVM16";
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) 
				{
					dt = null ;
				}
				else
				{
					dt = ds_ret.Tables[MyOraDB.Process_Name]; 
				}
			}
			catch
			{
				dt = null;
			}
			return dt;
		}


		private void Display_FlexGrid(DataTable arg_dt,ref MyGrid  p_fgControl)
		{
			if(arg_dt == null) 
			{
				return;
			}
			if(arg_dt.Rows.Count < 1)
			{
				return;
			}
			int iCount = arg_dt.Rows.Count;
			int RowCount = _MainRowfixed;
			DataTable dt = Select_Sub_Capacity(Convert.ToString(cmb_factory.SelectedValue), 
				dtp_date_from.Value.ToString("yyyyMMdd"), dtp_date_to.Value.ToString("yyyyMMdd"));
			//make cellstyle for backcolor is white
			//CellStyle cs1 = p_fgControl.Styles("BACKCOLORWHITE");
			//cs1.BackColor = Color.White;
			for (int iRow = 0 ; iRow < iCount ; iRow ++)
			{				
				string l_COM_VALUE = Convert.ToString(arg_dt.Rows[iRow]["COM_VALUE1"]);
				string l_COM_DESC =  Convert.ToString(arg_dt.Rows[iRow]["COM_DESC1"]);
				
				//add row capacity
				RowCount = p_fgControl.Rows.Count;
				C1.Win.C1FlexGrid.Node newRow = p_fgControl.Rows.InsertNode(RowCount, 1);
				p_fgControl[newRow.Row.Index, 0] = "";

				p_fgControl.Rows[newRow.Row.Index].UserData = l_COM_VALUE;
				p_fgControl.Rows[newRow.Row.Index].Caption = RowCapacity;
				p_fgControl[newRow.Row.Index,1] = l_COM_DESC;
				p_fgControl[newRow.Row.Index,2] = RowCapacity;
				p_fgControl.Rows[newRow.Row.Index].AllowEditing = false;
				for (int iCol = _MaxCol ; iCol < p_fgControl.Cols.Count ; iCol++)
				{
					object _tmp = Get_Sub_Capacity_Value(dt,l_COM_VALUE,Convert.ToString(p_fgControl.Cols[iCol].Caption));
					if (_tmp != DBNull.Value)
					{
						if(Convert.ToString( _tmp) != "" && Convert.ToInt32( _tmp) > 0)
						{
							p_fgControl[newRow.Row.Index, iCol] = _tmp;
						}
					}
				}
				
				//plan
				RowCount = p_fgControl.Rows.Count;
				newRow = p_fgControl.Rows.InsertNode(RowCount, 1);
				p_fgControl[newRow.Row.Index, 0] = "";
				
				p_fgControl.Rows[newRow.Row.Index].UserData = l_COM_VALUE;
				p_fgControl.Rows[newRow.Row.Index].Caption = RowPlan;
				p_fgControl[newRow.Row.Index,1] = l_COM_DESC;
				p_fgControl[newRow.Row.Index,2] = RowPlan;

				for (int iCol = _MaxCol ; iCol < p_fgControl.Cols.Count ; iCol++)
				{
					//p_fgControl[newRow.Row.Index, iCol] = Get_Sub_Plan_Value(dt,l_COM_VALUE,Convert.ToString(p_fgControl.Cols[iCol].Caption));
					object _tmp = Get_Sub_Plan_Value(dt,l_COM_VALUE,Convert.ToString(p_fgControl.Cols[iCol].Caption));
					if (_tmp != DBNull.Value)
					{
						if(Convert.ToString( _tmp) != "" && Convert.ToInt32( _tmp) > 0)
						{
							p_fgControl[newRow.Row.Index, iCol] = _tmp;
						}
					}
				}

				//var
				RowCount = p_fgControl.Rows.Count;
				newRow = p_fgControl.Rows.InsertNode(RowCount, 1);
				p_fgControl[newRow.Row.Index, 0] = "";
				p_fgControl.Rows[newRow.Row.Index].AllowEditing = false;
				p_fgControl.Rows[newRow.Row.Index].UserData = l_COM_VALUE;
				p_fgControl.Rows[newRow.Row.Index].Caption = RowVar;
				p_fgControl[newRow.Row.Index,1] = l_COM_DESC;
				p_fgControl[newRow.Row.Index,2] = RowVar;
				
			}
			//update backcolor = white; 
			for(int i = p_fgControl.Rows.Fixed; i < p_fgControl.Rows.Count; i++)
			{
				p_fgControl.Rows[i].StyleNew.BackColor = Color.White;
			}
		}

		
		private object Get_Sub_Capacity_Value(DataTable arg_dt, string arg_mid_sole, string arg_plan_ymd)
		{
			DataRow[] dr = null;
			dr = arg_dt.Select(" MID_SOLE = '" + arg_mid_sole + "' and PLAN_YMD = '" + arg_plan_ymd + "'");
			if(dr.Length > 0)
			{
				return dr[0]["SL"];
			}
			else
			{
				return null;
			}
		}

		private object Get_Sub_Plan_Value(DataTable arg_dt, string arg_mid_sole, string arg_plan_ymd)
		{
			DataRow[] dr = null;
			dr = arg_dt.Select(" MID_SOLE = '" + arg_mid_sole + "' and PLAN_YMD = '" + arg_plan_ymd + "'");
			if(dr.Length > 0)
			{
				return dr[0]["SL2"];
			}
			else
			{
				return null;
			}
		}
		
		
		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (Save_Sub_Capacity())
				{
					this.Tbtn_SearchProcess();
				}
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

		
		private bool Save_Sub_Capacity()
		{
			try
			{
				int para_ct = 0; 
				int iCount  = 5;
				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SVM_COMP_SUB_CAPA.SP_UPD_COMP_SUB_CAPA";

				//02.ARGURMENT OF PROC
				MyOraDB.Parameter_Name[0] = ARG_CAPA_QTY;
				MyOraDB.Parameter_Name[1] = ARG_FACTORY;
				MyOraDB.Parameter_Name[2] = ARG_MID_SOLE;
				MyOraDB.Parameter_Name[3] = ARG_PLAN_YMD;
				MyOraDB.Parameter_Name[4] = ARG_UPD_USER;
				
				//03. Type
				MyOraDB.Parameter_Type[0] = (int)OracleType.Number;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				//04. Value
				MyOraDB.Parameter_Values  = new string[iCount * (fgrid_main.Rows.Count - 1 - _MainRowfixed) * ( fgrid_main.Cols.Count -  1 - _MaxCol)];
				for (int iRow = _MainRowfixed; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if (fgrid_main.Rows[iRow].Caption != RowPlan )
					{
						continue;
					}
					for (int iCol = _MaxCol ;iCol < fgrid_main.Cols.Count; iCol ++)
					{					
						if(Convert.ToString(fgrid_main[iRow,iCol])=="")
						{
							continue;
						}
						MyOraDB.Parameter_Values[para_ct + 0] = Convert.ToString(fgrid_main[iRow,iCol]);//capa qty
						MyOraDB.Parameter_Values[para_ct + 1] = Convert.ToString(cmb_factory.SelectedValue);//factory
						MyOraDB.Parameter_Values[para_ct + 2] = Convert.ToString(fgrid_main.Rows[iRow].UserData);//mid sole
						MyOraDB.Parameter_Values[para_ct + 3] = fgrid_main.Cols[iCol].Caption;
						MyOraDB.Parameter_Values[para_ct + 4] = COM.ComVar.This_User;
						para_ct += iCount;	
					}
				}
				ArrayList arr = new ArrayList();
				for(int i = 0; i < MyOraDB.Parameter_Values.Length; i ++)
				{
					if(MyOraDB.Parameter_Values[i] ==null) continue;
					arr.Add(MyOraDB.Parameter_Values[i].ToString());
				}

				MyOraDB.Parameter_Values = (string[])arr.ToArray(typeof(string));

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
		}

		
		private bool Validate_Check()
		{
			if (fgrid_main.Rows.Count <= _MainRowfixed)
			{
				return false;
			}
			return true;
		}

		private void FormatGrid()
		{
			fgrid_main.AllowMerging = AllowMergingEnum.FixedOnly;
			if(_MainRowfixed >= fgrid_main.Rows.Count || _MainRowfixed == 0) 
			{
				 return;
			}

			for(int i = _MainRowfixed; i < fgrid_main.Rows.Count; i ++ )
			{	
				fgrid_main.SetCellStyle(i,2,InitCellStyle(i,fgrid_main.Rows[i].UserData.ToString(),
					fgrid_main.Rows[i].Caption,false));
				fgrid_main.SetCellStyle(i,1,InitCellStyle(i,fgrid_main.Rows[i].UserData.ToString(),
					fgrid_main.Rows[i].Caption,false));
				for(int j = _MaxCol; j < fgrid_main.Cols.Count; j ++)
				{
					fgrid_main.SetCellStyle(i,j,InitCellStyle(i,fgrid_main.Rows[i].UserData.ToString(),
						fgrid_main.Rows[i].Caption,true));
				}
				

			}
			fgrid_main.AllowMerging = AllowMergingEnum.Free;
			fgrid_main.Cols[1].AllowMerging = true;
			fgrid_main.Cols[2].AllowMerging = true;

		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_Print_Click();
		}
		public void Tbtn_Print_Click()
		{
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Sub_Capacity_Status") ;
			string Para         = " ";
		

			int  iCnt  = 3;
			string [] aHead =  new string[iCnt];    
            
			aHead[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");	
			aHead[ 1]   = this.dtp_date_from.Text.Replace("-", "");
			aHead[ 2]   = this.dtp_date_to.Text.Replace("-", "");            
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexVJ_Common.Report.Form_RdViewer report = new FlexVJ_Common.Report.Form_RdViewer(mrd_Filename, Para);
			
			//FlexTraining.Report.Form_RdViewer report = new FlexTraining.Report.Form_RdViewer(mrd_Filename, Para);

			report.Show();		


		}
		
	}
	public class MyGrid: COM.FSP
	{
		
		public MyGrid()
		{

		}
		
	
		override public CellRange GetMergedRange(int row, int col, bool clip)
		{
			// create basic cell range
			CellRange rg = GetCellRange(row, col);

			// expand left/right
			int i;
			int cnt = Cols.Count;
			int ifx = Cols.Fixed;
			for (i = rg.c1; i < cnt-1; i++)
			{
				if (GetDataDisplay(rg.r1, i) != GetDataDisplay(rg.r1, i+1)) break;
				rg.c2 = i+1;
			}
			for (i = rg.c1; i > ifx; i--)
			{
				if (GetDataDisplay(rg.r1, i) != GetDataDisplay(rg.r1, i-1)) break;
				rg.c1 = i-1;
			}

			// expand up/down
			cnt = Rows.Count;
			ifx = Rows.Fixed;
			for (i = rg.r1; i < cnt-1; i++)
			{
				if (GetDataDisplay(i, rg.c1) != GetDataDisplay(i+1, rg.c1)) break;
				rg.r2 = i+1;
			}
			for (i = rg.r1; i > ifx; i--)
			{
				if (GetDataDisplay(i, rg.c1) != GetDataDisplay(i-1, rg.c1)) break;
				rg.r1 = i-1;
			}

			// done
			return rg;
		}
	

	}
}

