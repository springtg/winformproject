using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Xml;
using System.Reflection;
using C1.Win.C1FlexGrid;  
using System.Data.OleDb;
using Microsoft.Office.Core;
using System.Runtime.InteropServices;


namespace FlexVJ_Common.DPUFE
{
	public class Form_Demand_Plan_Upload_Excel : COM.VJ_CommonWinForm.Form_Top
	{
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.Label btn_BrowesFile;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.DateTimePicker dpick_date_from;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private C1.Win.C1Input.C1Label Btn_Browes;
		private System.Windows.Forms.TextBox txt_FileName;
		private System.Windows.Forms.Label lbl_OSCode;
		private System.Windows.Forms.Label lbl_FileName;
		private System.Windows.Forms.TextBox txt_OSCode;
		private COM.FSP fgrid_Upload;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dpick_date_to;
		private System.ComponentModel.IContainer components = null;

		public Form_Demand_Plan_Upload_Excel()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			Init_Form();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Demand_Plan_Upload_Excel));
			this.btn_BrowesFile = new System.Windows.Forms.Label();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_date_to = new System.Windows.Forms.DateTimePicker();
			this.lbl_FileName = new System.Windows.Forms.Label();
			this.Btn_Browes = new C1.Win.C1Input.C1Label();
			this.txt_FileName = new System.Windows.Forms.TextBox();
			this.dpick_date_from = new System.Windows.Forms.DateTimePicker();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.lbl_OSCode = new System.Windows.Forms.Label();
			this.txt_OSCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.fgrid_Upload = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Btn_Browes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Upload)).BeginInit();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(754, 4);
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			this.stbar.Size = new System.Drawing.Size(1040, 22);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(1370, 23);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// btn_BrowesFile
			// 
			this.btn_BrowesFile.Location = new System.Drawing.Point(100, 100);
			this.btn_BrowesFile.Name = "btn_BrowesFile";
			this.btn_BrowesFile.TabIndex = 0;
			// 
			// pic_head5
			// 
			this.pic_head5.Location = new System.Drawing.Point(200, 200);
			this.pic_head5.Name = "pic_head5";
			this.pic_head5.TabIndex = 0;
			this.pic_head5.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Location = new System.Drawing.Point(0, 0);
			this.pic_head2.Name = "pic_head2";
			this.pic_head2.TabIndex = 0;
			this.pic_head2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pic_head6
			// 
			this.pic_head6.Location = new System.Drawing.Point(0, 0);
			this.pic_head6.Name = "pic_head6";
			this.pic_head6.TabIndex = 0;
			this.pic_head6.TabStop = false;
			// 
			// pic_head1
			// 
			this.pic_head1.Location = new System.Drawing.Point(0, 0);
			this.pic_head1.Name = "pic_head1";
			this.pic_head1.TabIndex = 0;
			this.pic_head1.TabStop = false;
			// 
			// pnl_head
			// 
			this.pnl_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.dpick_date_to);
			this.pnl_head.Controls.Add(this.lbl_FileName);
			this.pnl_head.Controls.Add(this.Btn_Browes);
			this.pnl_head.Controls.Add(this.txt_FileName);
			this.pnl_head.Controls.Add(this.dpick_date_from);
			this.pnl_head.Controls.Add(this.lbl_PlanYMD);
			this.pnl_head.Controls.Add(this.lbl_OSCode);
			this.pnl_head.Controls.Add(this.txt_OSCode);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.cmb_Factory);
			this.pnl_head.Controls.Add(this.lbl_Factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pictureBox2);
			this.pnl_head.Controls.Add(this.pictureBox3);
			this.pnl_head.Controls.Add(this.pictureBox5);
			this.pnl_head.Controls.Add(this.pictureBox4);
			this.pnl_head.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_head.Location = new System.Drawing.Point(8, 88);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1024, 96);
			this.pnl_head.TabIndex = 29;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(528, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 23);
			this.label1.TabIndex = 567;
			this.label1.Text = "~";
			// 
			// dpick_date_to
			// 
			this.dpick_date_to.CustomFormat = "yyyy-MM";
			this.dpick_date_to.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_to.Location = new System.Drawing.Point(552, 64);
			this.dpick_date_to.Name = "dpick_date_to";
			this.dpick_date_to.Size = new System.Drawing.Size(72, 21);
			this.dpick_date_to.TabIndex = 564;
			// 
			// lbl_FileName
			// 
			this.lbl_FileName.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_FileName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_FileName.ImageIndex = 1;
			this.lbl_FileName.ImageList = this.img_Label;
			this.lbl_FileName.Location = new System.Drawing.Point(8, 62);
			this.lbl_FileName.Name = "lbl_FileName";
			this.lbl_FileName.Size = new System.Drawing.Size(100, 21);
			this.lbl_FileName.TabIndex = 543;
			this.lbl_FileName.Text = "File Name";
			this.lbl_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Btn_Browes
			// 
			this.Btn_Browes.ImageIndex = 18;
			this.Btn_Browes.ImageList = this.img_SmallButton;
			this.Btn_Browes.Location = new System.Drawing.Point(297, 62);
			this.Btn_Browes.Name = "Btn_Browes";
			this.Btn_Browes.Size = new System.Drawing.Size(24, 23);
			this.Btn_Browes.TabIndex = 566;
			this.Btn_Browes.Tag = null;
			this.Btn_Browes.TextDetached = true;
			this.Btn_Browes.Click += new System.EventHandler(this.Btn_Browes_Click);
			// 
			// txt_FileName
			// 
			this.txt_FileName.BackColor = System.Drawing.SystemColors.Window;
			this.txt_FileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_FileName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_FileName.Location = new System.Drawing.Point(109, 62);
			this.txt_FileName.MaxLength = 10;
			this.txt_FileName.Name = "txt_FileName";
			this.txt_FileName.Size = new System.Drawing.Size(187, 21);
			this.txt_FileName.TabIndex = 565;
			this.txt_FileName.Text = "";
			this.txt_FileName.TextChanged += new System.EventHandler(this.txt_FileName_TextChanged);
			this.txt_FileName.DoubleClick += new System.EventHandler(this.txt_FileName_DoubleClick);
			// 
			// dpick_date_from
			// 
			this.dpick_date_from.CustomFormat = "yyyy-MM";
			this.dpick_date_from.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_from.Location = new System.Drawing.Point(448, 63);
			this.dpick_date_from.Name = "dpick_date_from";
			this.dpick_date_from.Size = new System.Drawing.Size(72, 21);
			this.dpick_date_from.TabIndex = 564;
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_PlanYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_PlanYMD.ImageIndex = 1;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(344, 63);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 543;
			this.lbl_PlanYMD.Text = "Plan Month";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OSCode
			// 
			this.lbl_OSCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OSCode.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_OSCode.ImageIndex = 1;
			this.lbl_OSCode.ImageList = this.img_Label;
			this.lbl_OSCode.Location = new System.Drawing.Point(344, 40);
			this.lbl_OSCode.Name = "lbl_OSCode";
			this.lbl_OSCode.Size = new System.Drawing.Size(100, 21);
			this.lbl_OSCode.TabIndex = 405;
			this.lbl_OSCode.Text = "OS Code";
			this.lbl_OSCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OSCode
			// 
			this.txt_OSCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OSCode.Location = new System.Drawing.Point(448, 39);
			this.txt_OSCode.Name = "txt_OSCode";
			this.txt_OSCode.Size = new System.Drawing.Size(176, 22);
			this.txt_OSCode.TabIndex = 0;
			this.txt_OSCode.Text = "";
			this.txt_OSCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_OSCode_KeyDown);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 393;
			this.label2.Text = "      Upload Information";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(1008, 80);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 79);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(984, 18);
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
			this.cmb_Factory.Location = new System.Drawing.Point(109, 40);
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
			this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_Factory.TabIndex = 10;
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
			this.pic_head7.Location = new System.Drawing.Point(923, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 55);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(1008, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 44;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 80);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(168, 20);
			this.pictureBox3.TabIndex = 43;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(160, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(944, 32);
			this.pictureBox5.TabIndex = 39;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(168, 78);
			this.pictureBox4.TabIndex = 41;
			this.pictureBox4.TabStop = false;
			// 
			// fgrid_Upload
			// 
			this.fgrid_Upload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Upload.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Upload.ColumnInfo = "10,1,0,0,0,80,Columns:1{AllowMerging:True;}\t";
			this.fgrid_Upload.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_Upload.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Upload.Location = new System.Drawing.Point(8, 192);
			this.fgrid_Upload.Name = "fgrid_Upload";
			this.fgrid_Upload.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_Upload.Size = new System.Drawing.Size(1032, 448);
			this.fgrid_Upload.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Upload.TabIndex = 178;
			this.fgrid_Upload.BeforeSort += new C1.Win.C1FlexGrid.SortColEventHandler(this.fgrid_Upload_BeforeSort);
			this.fgrid_Upload.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Upload_BeforeEdit);
			this.fgrid_Upload.DoubleClick += new System.EventHandler(this.fgrid_Upload_DoubleClick);
			this.fgrid_Upload.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Upload_AfterEdit);
			this.fgrid_Upload.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_Upload_KeyDown);
			// 
			// Form_Demand_Plan_Upload_Excel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1040, 666);
			this.Controls.Add(this.fgrid_Upload);
			this.Controls.Add(this.pnl_head);
			this.Name = "Form_Demand_Plan_Upload_Excel";
			this.Text = "Demand Plan Upload From Excel";
			this.Load += new System.EventHandler(this.Form_Demand_Plan_Upload_Excel_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_head, 0);
			this.Controls.SetChildIndex(this.fgrid_Upload, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Btn_Browes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Upload)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region "Declare Variable"

		private string _Excel_StyleCd = "";

		// MLU Upload display level
		private const int _LevelComponent = 1, _LevelMaterial = 2;
		private const int _LevelMaterial_Neomics = 3;

		private COM.OraDB oraDB = null;
		private int _MainRowfixed = 0;

		private const string ARG_FACTORY = "ARG_FACTORY";
		private const string ARG_OS_CODE = "ARG_OS_CODE";
		private const string ARG_MID_SOLE1 = "ARG_MID_SOLE1";
		private const string ARG_MID_SOLE2 = "ARG_MID_SOLE2";
		private const string ARG_MID_SOLE3 = "ARG_MID_SOLE3";
		private const string ARG_UPD_USER = "ARG_UPD_USER";
		private const string ARG_OUT_CURSOR = "OUT_CURSOR";

		private const string ARG_CATEGORY_NAME = "ARG_CATEGORY_NAME";
		private const string ARG_MODEL_CD = "ARG_MODEL_CD";
		private const string ARG_DEV_NAME = "ARG_DEV_NAME";
		private const string ARG_PLAN_MONTH = "ARG_PLAN_MONTH";
		private const string ARG_PLAN_QTY = "ARG_PLAN_QTY";
		private const string ARG_REMARK01 = "ARG_REMARK01";
		private const string ARG_REMARK02 = "ARG_REMARK02";
		private const string ARG_REMARK03 = "ARG_REMARK03";
		private const string ARG_OBS_ID = "ARG_OBS_ID";
		private const string ARG_DIVISION = "ARG_DIVISION";
		private const string ARG_LINE_CD = "ARG_LINE_CD";
		private const string ARG_MINI_LINE = "ARG_MINI_LINE";
		
		#endregion

		#region "Init Form"
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "Demand Plan Upload From Excel";
			lbl_MainTitle.Text = "Demand Plan Upload From Excel";
			Init_Control(); 
			oraDB = new COM.OraDB();
		}

		/// <summary>
		/// Init_Control : combobox setting
		/// </summary>
		private void Init_Control()
		{
			DataTable dt_ret;

			// factory
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			
			dt_ret.Dispose(); 

			// toolbar button disable setting
			tbtn_Confirm.Enabled = false; 
			tbtn_Confirm.Enabled=false;
			tbtn_Print.Enabled=false;
			tbtn_Create.Enabled=false;

			fgrid_Upload.Set_Grid("LST_SVM_DP_LOAD","1",2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Upload.AllowFreezing = AllowFreezingEnum.Columns;
			fgrid_Upload.Cols.Fixed = 0;// = AllowFreezingEnum.Columns;
			fgrid_Upload.Set_Action_Image(img_Action);
			_MainRowfixed = fgrid_Upload.Rows.Fixed;
			fgrid_Upload.Cols[G_COL_PLAN_MONTH].Style.Format = "yyyy-MM-dd";
			dpick_date_to.Value=dpick_date_from.Value.AddMonths(3);

		}

		#endregion

		#region "Event"
		
		private void Btn_Browes_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.CheckFileExists=true;
			openFileDialog.CheckPathExists=true;
			openFileDialog.Filter ="Excel Format(*.xls)|*.xls";
			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
                txt_FileName.Text = openFileDialog.FileName;
			}
			
			try
			{ 	
				this.Cursor = Cursors.WaitCursor;
				Excel_Upload();
				for (int i = fgrid_Upload.Rows.Fixed; i < fgrid_Upload.Rows.Count;i++)
				{
					fgrid_Upload[i,0] = "I";
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Excel_Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;

			}
		}

		

		
		private void c1Label1_Click(object sender, System.EventArgs e)
		{
			
		}
		
		
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;
				Clear_FlexGrid(fgrid_Upload);
				Display_FlexGrid(SearchData(cmb_Factory.SelectedValue.ToString(), 
					txt_OSCode.Text, dpick_date_from.Value.ToString("yyyyMM"),dpick_date_to.Value.ToString("yyyyMM")));
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SearchData", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;

			}
		}

		private bool InvalidOnRow(COM.FSP arg_grid, int arg_Row)
		{
			if(arg_grid.Rows[arg_Row].AllowEditing == false) return true;
			string objMid1 = Convert.ToString(arg_grid.Rows[arg_Row][G_COL_MID_SOLE1]);
			string objMid2 = Convert.ToString(arg_grid.Rows[arg_Row][G_COL_MID_SOLE2]);
			string objMid3 = Convert.ToString(arg_grid.Rows[arg_Row][G_COL_MID_SOLE3]);

//			if(objMid1 != "" || objMid2 != "" || objMid2 != "")
//			{
//				if(objMid1 == objMid2 && objMid1 != "" && objMid2 != "")
//				{
//					ClassLib.ComFunction.User_Message("'Mid Sole 1' conflict value with 'Mid Sole 2'!","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
//					return false;
//				}
//				if(objMid1 == objMid3 && objMid1 != "" && objMid3 != "")
//				{
//					ClassLib.ComFunction.User_Message("'Mid Sole 1' conflict value with 'Mid Sole 3'!","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
//					return false;
//				}
//				if(objMid2 == objMid3 && objMid2 != "" && objMid3 != "")
//				{
//					ClassLib.ComFunction.User_Message("'Mid Sole 2' conflict value with 'Mid Sole 3'!","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
//					return false;
//				}
//			}
			return true;
		}
		
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			//Not found data in gird
			if(fgrid_Upload.Rows.Count <= fgrid_Upload.Rows.Fixed)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsNotHaveData,this);
				return;
			}
			//CHECK MID SOLE CONDITION

			for(int i = _MainRowfixed; i < fgrid_Upload.Rows.Count; i++)
			{

				if(fgrid_Upload.Rows[i].AllowEditing == false) continue;
				if(InvalidOnRow(fgrid_Upload, i) == false)
				{
					return;
				}
				/*string objMid1 = Convert.ToString(fgrid_Upload.Rows[i][G_COL_MID_SOLE1]);
				string objMid2 = Convert.ToString(fgrid_Upload.Rows[i][G_COL_MID_SOLE2]);
				string objMid3 = Convert.ToString(fgrid_Upload.Rows[i][G_COL_MID_SOLE3]);
				if(objMid1 != "" || objMid2 != "" || objMid2 != "")
				{
					if(objMid1 == objMid2)
					{
						ClassLib.ComFunction.User_Message("'Mid Sole 1' conflict value with 'Mid Sole 2'!","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
						return ;
					}
					if(objMid1 == objMid3)
					{
						ClassLib.ComFunction.User_Message("'Mid Sole 1' conflict value with 'Mid Sole 3'!","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
						return;
					}
					if(objMid2 == objMid3)
					{
						ClassLib.ComFunction.User_Message("'Mid Sole 2' conflict value with 'Mid Sole 3'!","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
						return;
					}
				}*/
			}

			/*
			for(int i = _MainRowfixed; i < fgrid_Upload.Rows.Count; i++)
			{
				if(fgrid_Upload.Rows[i].AllowEditing == false) continue;
				object objMid1 = fgrid_Upload.Rows[i][G_COL_MID_SOLE1];
				if(objMid1 != null)
				{
					//MID SOLE 1 COMPARE WITH MID SOLE 2
					for(int j = _MainRowfixed ; j< fgrid_Upload.Rows.Count; j++)
					{
						object objTmp = fgrid_Upload[j,G_COL_MID_SOLE2];
						if(objTmp != null)
						{
							if(objMid1.ToString() == objTmp.ToString()) 
							{
								if(objMid1.ToString() != "" || objTmp.ToString() != "")
								{
									ClassLib.ComFunction.User_Message("'Mid Sole 1' conflict value with 'Mid Sole 2'!","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
									return ;
								}
							}
						}
					}
					//MID SOLE 1 COMPARE WITH MID SOLE 3
					for(int k = _MainRowfixed ; k< fgrid_Upload.Rows.Count; k++)
					{
						object objTmp = fgrid_Upload[k,G_COL_MID_SOLE3];
						if(objTmp != null)
						{
							if(objMid1.ToString() == objTmp.ToString())
							{
								if(objMid1.ToString() != "" || objTmp.ToString() != "")
								{
									ClassLib.ComFunction.User_Message("'Mid Sole 1' conflict value with 'Mid Sole 3'!","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
									return;
								}
							}
						}
					}
				}
				//MID SOLE 2 COMPARE WITH MID SOLE 3
				object objMid2 = fgrid_Upload.Rows[i][G_COL_MID_SOLE2];
				if(objMid2 != null)
				{
					for(int h = _MainRowfixed; h< fgrid_Upload.Rows.Count; h++)
					{
						object objTmp = fgrid_Upload[h,G_COL_MID_SOLE3];
						if(objTmp != null)
						{
							if(objMid2.ToString() == objTmp.ToString())
							{
								if(objMid2.ToString() != "" || objTmp.ToString() != "")
								{
									ClassLib.ComFunction.User_Message("'Mid Sole 2' conflict value with 'Mid Sole 3'!","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
									return;
								}
							}
						}
					}
				}
			}

			*/
			
			if (Grid_SetColor() > 0)
			{
				ClassLib.ComFunction.User_Message("You Must Fill 'Model Code'!","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
				return;
			}
			Before_Savedata();
			if(Savedata(true))
			{
				ClassLib.ComFunction.User_Message("Upload Data Sucess!","Infomation",MessageBoxButtons.OK ,MessageBoxIcon.Information);
				tbtn_Search_Click(tbtn_Search,null);
			}
		}

		
		private void txt_FileName_TextChanged(object sender, System.EventArgs e)
		{
		}

		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			txt_OSCode.Text=string.Empty;
			txt_FileName.Text=string.Empty;
			dpick_date_from.Value=DateTime.Now;
			Clear_FlexGrid(fgrid_Upload);
		}

		
		private void Clear_FlexGrid(COM.FSP p_fgControl)
		{
			if (p_fgControl.Rows.Fixed != p_fgControl.Rows.Count)
			{				
				p_fgControl.Clear(ClearFlags.UserData, p_fgControl.Rows.Fixed, 1, p_fgControl.Rows.Count - 1, p_fgControl.Cols.Count - 1);

				p_fgControl.Rows.Count = p_fgControl.Rows.Fixed;					
			}
		}
		

		private void txt_OSCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(!e.KeyData.Equals(Keys.Enter))
			{
				return;
			}
			tbtn_Search_Click(tbtn_Search,null);
		}
		
		
		#endregion

		#region "Method"

		/// <summary>
		/// Define Index Of DataSource
		/// </summary>
		private const string INDEX_FACTORY = "FACTORY";
		private const string INDEX_CATEGORY_NAME = "CATEGORY_NAME";
		private const string INDEX_OBS_ID = "OBS_ID";
		private const string INDEX_OS_CODE = "OS_CODE";
		private const string INDEX_LINE_CD = "LINE_CD";
		private const string INDEX_MINI_LINE = "MINI_LINE";
		private const string INDEX_MID_SOLE1 = "MID_SOLE1";
		private const string INDEX_MID_SOLE2 = "MID_SOLE2";
		private const string INDEX_MID_SOLE3 = "MID_SOLE3";
		private const string INDEX_DEV_NAME = "DEV_NAME";
		private const string INDEX_MODEL_CD = "MODEL_CD";
		private const string INDEX_PLAN_MONTH = "PLAN_MONTH";
		private const string INDEX_PLAN_QTY = "PLAN_QTY";
		private const string INDEX_REMARK01 = "REMARK01";
		private const string INDEX_REMARK02 = "REMARK02";
		private const string INDEX_REMARK03 = "REMARK03";

		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;		

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{								
				C1.Win.C1FlexGrid.Node newRow = fgrid_Upload.Rows.InsertNode(fgrid_Upload.Rows.Fixed + iRow, 1);
				fgrid_Upload[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					fgrid_Upload[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}
			}
		}


		private DataTable MakeEmptyDataSource()
		{
			DataTable l_DataTable=new DataTable();
			l_DataTable.Columns.Add(INDEX_FACTORY,typeof(string));
			l_DataTable.Columns.Add(INDEX_CATEGORY_NAME,typeof(string));
			l_DataTable.Columns.Add(INDEX_OBS_ID,typeof(string));
			l_DataTable.Columns.Add(INDEX_PLAN_MONTH,typeof(string));
			l_DataTable.Columns.Add(INDEX_OS_CODE,typeof(string));
			l_DataTable.Columns.Add(INDEX_LINE_CD,typeof(string));
			l_DataTable.Columns.Add(INDEX_MINI_LINE,typeof(string));
			l_DataTable.Columns.Add(INDEX_MID_SOLE1,typeof(string));
			l_DataTable.Columns.Add(INDEX_MID_SOLE2,typeof(string));
			l_DataTable.Columns.Add(INDEX_MID_SOLE3,typeof(string));
			l_DataTable.Columns.Add(INDEX_MODEL_CD,typeof(string));
			l_DataTable.Columns.Add(INDEX_DEV_NAME,typeof(string));			
			l_DataTable.Columns.Add(INDEX_PLAN_QTY,typeof(string));
			l_DataTable.Columns.Add(INDEX_REMARK01,typeof(string));
			l_DataTable.Columns.Add(INDEX_REMARK02,typeof(string));
			l_DataTable.Columns.Add(INDEX_REMARK03,typeof(string));
			return l_DataTable;
		}

		/// <summary>
		/// Excel_Upload : 
		/// </summary>
		private void Excel_Upload()
		{
			Clear_FlexGrid(fgrid_Upload);
			DataTable step_1_dt = ExcelUpload_Step_1();
			if(step_1_dt == null) return;
			Display_FlexGrid(step_1_dt);
			step_1_dt.Dispose();
		}

		
		#region Excel Upload Step

		/// <summary>
		/// ExcelUpload_Step_1 : 1. Excel Upload -> DataTable
		/// </summary>
		/// <returns></returns>
		private DataTable ExcelUpload_Step_1()
		{
			string path = txt_FileName.Text.Trim(); 
			DataSet ds_ret = ClassLib.ComFunction.Read_Excel(path);
			if(ds_ret == null) return null; 
			//---------------------------------------------------------------------------------------------------
			// 선택한 스타일과, 엑셀 업로드된 스타일 정합성 체크
			// ok : 틀려도 계속 진행
			// cancel : 다른 엑셀 시트 또는 콤보 스타일 선택 작업
			//---------------------------------------------------------------------------------------------------
			// excel sheet name = '000000-000$'  형식이므로 replace 처리
			string excel_style_cd = ds_ret.Namespace.Trim().ToString().Replace("$", "");
			excel_style_cd = excel_style_cd.Replace("'", "");
			excel_style_cd = excel_style_cd.Replace("-", "0"); 
			_Excel_StyleCd = excel_style_cd;
			DataTable dt_ret = ds_ret.Tables[0];
			DataTable dt_new = MakeEmptyDataSource();
			DataTable dt_Model = SELECT_SDC_MODEL();
			DataTable dt_Os_Master = new DataTable();
			dt_Os_Master = SELECT_SVM_OS_MASTER(COM.ComFunction.Empty_Combo(cmb_Factory,""));

			DataRow dr;
			for(int j=0;j<3;j++)
			{
				int column_qty = 5;
				if(j==0)
				{
					column_qty = 5;
				}
				if(j==1)
				{
					column_qty = 6;
				}
				if(j==2)
				{
					column_qty = 7;
				}
				

				for(int i = 2; i < dt_ret.Rows.Count; i++)
				{
					if( dt_ret.Rows[i][0] == DBNull.Value) continue;
					if (dt_ret.Rows[i].ItemArray[column_qty]==DBNull.Value) continue;
					if (Convert.ToString(dt_ret.Rows[i].ItemArray[column_qty])=="0") continue;
					dr = dt_new.NewRow();

					dr[INDEX_CATEGORY_NAME] = dt_ret.Rows[i].ItemArray[0];
					dr[INDEX_OS_CODE] = dt_ret.Rows[i].ItemArray[1];

					DataRow dr_Tmp = MappingMidSole(dt_ret.Rows[i].ItemArray[1],dt_Os_Master);
					if(dr_Tmp != null)
					{
						dr[INDEX_MID_SOLE1] = dr_Tmp["MID_SOLE1"];
						dr[INDEX_MID_SOLE2] = dr_Tmp["MID_SOLE2"];
						dr[INDEX_MID_SOLE3] = dr_Tmp["MID_SOLE3"];
					}
					dr[INDEX_MODEL_CD] = MappingModelCode(dt_ret.Rows[i].ItemArray[2],dt_Model);
					dr[INDEX_DEV_NAME] = dt_ret.Rows[i].ItemArray[2];
					dr[INDEX_PLAN_MONTH] = dt_ret.Rows[1][column_qty].ToString();
					//MessageBox.Show(dt_ret.Rows[i].ItemArray[3].ToString());
					string a ="";
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3])=="1")
					{
						a="001";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3])=="2")
					{
						a="002";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3])=="3")
					{
						a="003";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3])=="4")
					{
						a="004";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3])=="5")
					{
						a="005";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3])=="6")
					{
						a="006";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3]).ToUpper()=="A")
					{
						a="009";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3]).ToUpper()=="B")
					{
						a="007";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3]).ToUpper()=="C")
					{
						a="008";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3]).ToUpper()=="D")
					{
						a="010";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3]).ToUpper()=="E")
					{
						a="011";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3]).ToUpper()=="F")
					{
						a="012";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3]).ToUpper()=="G")
					{
						a="013";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3]).ToUpper()=="H")
					{
						a="014";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3]).ToUpper()=="I")
					{
						a="015";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3]).ToUpper()=="J")
					{
						a="016";
					}
					if(Convert.ToString(dt_ret.Rows[i].ItemArray[3]).ToUpper()=="N")
					{
						a="099";
					}

					dr[INDEX_LINE_CD]=a;
					//dr[INDEX_LINE_CD]=dt_ret.Rows[i].ItemArray[3];
					
					dr[INDEX_MINI_LINE]=dt_ret.Rows[i].ItemArray[4];

					dr[INDEX_PLAN_QTY] = dt_ret.Rows[i].ItemArray[column_qty];
					dr[INDEX_OBS_ID] = ConvertOBS_ID(Convert.ToInt32(dt_ret.Rows[1][column_qty].ToString().Substring(0,4))
														,Convert.ToInt32(dt_ret.Rows[1][column_qty].ToString().Substring(4,2)));
					dt_new.Rows.Add(dr);
				}

			}
			
			return dt_new;
		}
		
		#endregion 


		private void Before_Savedata()
		{
			try
			{
				int para_ct = 0; 
				int iCount  = 2;
				oraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				oraDB.Process_Name = "PKG_SVM_DP_LOAD.SP_BEFORE_INS_SVM_DP_LOAD";

				//02.ARGURMENT OF PROC
				oraDB.Parameter_Name[0] = ARG_FACTORY;
				oraDB.Parameter_Name[1] = ARG_PLAN_MONTH;
				
				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.VarChar ;
				oraDB.Parameter_Values  = new string[iCount * (fgrid_Upload.Rows.Count - _MainRowfixed) ];

				for (int iRow = _MainRowfixed; iRow < fgrid_Upload.Rows.Count ; iRow++)
				{				
					oraDB.Parameter_Values[para_ct+ 0] = COM.ComFunction.Empty_Combo(cmb_Factory,"");
					oraDB.Parameter_Values[para_ct+ 1] = Convert.ToString(fgrid_Upload[iRow, G_COL_PLAN_MONTH]);
					
					para_ct += iCount;	
				}

				oraDB.Add_Modify_Parameter(true);
				oraDB.Exe_Modify_Procedure() ;

			}
			catch(System.Exception ex)
			{
				return ;
			}
		}
		private bool Savedata(bool doExecute)
		{
			try
			{
				int para_ct = 0; 
				int iCount  = 18;
				oraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				oraDB.Process_Name = "PKG_SVM_DP_LOAD.SP_INS_SVM_DP_LOAD";

				//02.ARGURMENT OF PROC
				oraDB.Parameter_Name[0] = ARG_FACTORY;
				oraDB.Parameter_Name[1] = ARG_CATEGORY_NAME;
				oraDB.Parameter_Name[2] = ARG_OS_CODE;
				oraDB.Parameter_Name[3] = ARG_MODEL_CD;
				oraDB.Parameter_Name[4] = ARG_DEV_NAME;
				oraDB.Parameter_Name[5] = ARG_PLAN_MONTH;
				oraDB.Parameter_Name[6] = ARG_PLAN_QTY;
				oraDB.Parameter_Name[7] = ARG_REMARK01;
				oraDB.Parameter_Name[8] = ARG_REMARK02;
				oraDB.Parameter_Name[9] = ARG_REMARK03;
				oraDB.Parameter_Name[10] = ARG_UPD_USER;
				oraDB.Parameter_Name[11] = ARG_OBS_ID;
				oraDB.Parameter_Name[12] = ARG_DIVISION;
				oraDB.Parameter_Name[13] = ARG_MID_SOLE1;
				oraDB.Parameter_Name[14] = ARG_MID_SOLE2;
				oraDB.Parameter_Name[15] = ARG_MID_SOLE3;
				oraDB.Parameter_Name[16] = ARG_LINE_CD;
				oraDB.Parameter_Name[17] = ARG_MINI_LINE;


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					oraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[6] = (int)OracleType.Number;
				oraDB.Parameter_Values  = new string[iCount * (fgrid_Upload.Rows.Count - _MainRowfixed) ];

				for (int iRow = _MainRowfixed; iRow < fgrid_Upload.Rows.Count ; iRow++)
				{				
					oraDB.Parameter_Values[para_ct+ 0] = COM.ComFunction.Empty_Combo(cmb_Factory,"");
					oraDB.Parameter_Values[para_ct+ 1] = Convert.ToString(fgrid_Upload[iRow, G_COL_CATEGORY_NAME]);
					oraDB.Parameter_Values[para_ct+ 2] = Convert.ToString(fgrid_Upload[iRow, G_COL_OS_CODE]);
					oraDB.Parameter_Values[para_ct+ 3] = Convert.ToString(fgrid_Upload[iRow, G_COL_MODEL_CD]);
					oraDB.Parameter_Values[para_ct+ 4] = Convert.ToString(fgrid_Upload[iRow, G_COL_DEV_NAME]);
					if(Convert.ToString(fgrid_Upload[iRow, G_COL_PLAN_MONTH]).Equals(""))
					{
						oraDB.Parameter_Values[para_ct+ 5] = dpick_date_from.Value.ToString("yyyyMMdd");
					}
					else
					{
						oraDB.Parameter_Values[para_ct+ 5] = Convert.ToString(fgrid_Upload[iRow, G_COL_PLAN_MONTH]).Replace("-","");
					}
					try
					{
						oraDB.Parameter_Values[para_ct+ 6] = Convert.ToString(fgrid_Upload[iRow, G_COL_PLAN_QTY]).Replace(",","");
					}
					catch
					{
						oraDB.Parameter_Values[para_ct+ 6] = "0";
					}			
					oraDB.Parameter_Values[para_ct + 7] = Convert.ToString(fgrid_Upload[iRow, G_COL_REMARK01]);
					oraDB.Parameter_Values[para_ct + 8] = Convert.ToString(fgrid_Upload[iRow, G_COL_REMARK02]);
					oraDB.Parameter_Values[para_ct + 9] = Convert.ToString(fgrid_Upload[iRow, G_COL_REMARK03]);
					oraDB.Parameter_Values[para_ct + 10] = COM.ComVar.This_User;
					oraDB.Parameter_Values[para_ct + 11] = Convert.ToString(fgrid_Upload[iRow, G_COL_OBS_ID]);
					oraDB.Parameter_Values[para_ct + 12] = Convert.ToString(fgrid_Upload[iRow,0]);
					oraDB.Parameter_Values[para_ct + 13] = Convert.ToString(fgrid_Upload[iRow,G_COL_MID_SOLE1]);
					oraDB.Parameter_Values[para_ct + 14] = Convert.ToString(fgrid_Upload[iRow,G_COL_MID_SOLE2]);
					oraDB.Parameter_Values[para_ct + 15] = Convert.ToString(fgrid_Upload[iRow,G_COL_MID_SOLE3]);
					oraDB.Parameter_Values[para_ct + 16] = Convert.ToString(fgrid_Upload[iRow,G_COL_LINE_CD]);
					oraDB.Parameter_Values[para_ct + 17] = Convert.ToString(fgrid_Upload[iRow,G_COL_MINI_LINE]);
					
					para_ct += iCount;	
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
				return false;
			}
		}

		/*
		private bool SaveOsMaster()
		{
			try
			{
				int para_ct = 0; 
				int iCount  = 6;
				oraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				oraDB.Process_Name = "PKG_SVM_DP_LOAD.SP_UPD_SVM_OS_MASTER";

				//02.ARGURMENT OF PROC
				oraDB.Parameter_Name[0] = ARG_FACTORY;
				oraDB.Parameter_Name[1] = ARG_OS_CODE;
				oraDB.Parameter_Name[2] = ARG_MID_SOLE1;
				oraDB.Parameter_Name[3] = ARG_MID_SOLE2;
				oraDB.Parameter_Name[4] = ARG_MID_SOLE3;
				oraDB.Parameter_Name[5] = ARG_UPD_USER;

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					oraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;

				oraDB.Parameter_Values  = new string[iCount * (fgrid_Upload.Rows.Count - _MainRowfixed)];

				for (int iRow = _MainRowfixed; iRow < fgrid_Upload.Rows.Count ; iRow++)
				{				
					oraDB.Parameter_Values[para_ct+ 0] = COM.ComFunction.Empty_Combo(cmb_Factory,"");
					oraDB.Parameter_Values[para_ct+ 1] = Convert.ToString(fgrid_Upload[iRow, G_COL_OS_CODE]);
					oraDB.Parameter_Values[para_ct+ 2] = Convert.ToString(fgrid_Upload[iRow, G_COL_MID_SOLE1]);
					oraDB.Parameter_Values[para_ct+ 3] = Convert.ToString(fgrid_Upload[iRow, G_COL_MID_SOLE1]);
					oraDB.Parameter_Values[para_ct+ 4] = Convert.ToString(fgrid_Upload[iRow, G_COL_MID_SOLE1]);
					oraDB.Parameter_Values[para_ct + 5] = COM.ComVar.This_User;
					para_ct += iCount;	
				}

				oraDB.Add_Modify_Parameter(true);
				
				if (oraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;
			}
			catch(System.Exception ex)
			{
				return false;
			}
		}
*/
		
		private DataTable SearchData(string p_factory, string p_oscode, string p_plan_month_from,string p_plan_month_to)
		{
			try 
			{
				DataSet ds_ret;

				oraDB.ReDim_Parameter(5); 

				//01.PROCEDURE명
				oraDB.Process_Name = "PKG_SVM_DP_LOAD.SP_SEL_SVM_DP_LOAD"; 

				//02.ARGURMENT 명
				oraDB.Parameter_Name[0] = "ARG_FACTORY";
				oraDB.Parameter_Name[1] = "ARG_OS_CODE";
				oraDB.Parameter_Name[2] = "ARG_PLAN_MONTH_FROM";
				oraDB.Parameter_Name[3] = "ARG_PLAN_MONTH_TO";
				oraDB.Parameter_Name[4] = "OUT_CURSOR"; 
      
				//03.DATA TYPE 정의
				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

				//04.DATA 정의
				oraDB.Parameter_Values[0] = p_factory;
				oraDB.Parameter_Values[1] = p_oscode;
				oraDB.Parameter_Values[2] = p_plan_month_from;
				oraDB.Parameter_Values[3] = p_plan_month_to;
				oraDB.Parameter_Values[4] = ""; 

				oraDB.Add_Select_Parameter(true);
				ds_ret = oraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[oraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SearchData", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}

		}

		/// <summary>
		/// get info model
		/// </summary>
		/// <returns></returns>
		private DataTable SELECT_SDC_MODEL()
		{			
			try
			{
				DataSet ds_ret;
				int iCount  = 3;
				oraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				oraDB.Process_Name = "PKG_SVM_DP_LOAD.SP_SEL_MODEL_CD_DP_LOAD";

				//02.ARGURMENT OF PROC
				oraDB.Parameter_Name[0] = "ARG_MODEL_CD";
				oraDB.Parameter_Name[1] = "ARG_MODEL_NAME";
				oraDB.Parameter_Name[2] = "OUT_CURSOR";
				
				//03.Type
				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

				oraDB.Parameter_Values  = new string[iCount];
				oraDB.Parameter_Values[0] = "";
				oraDB.Parameter_Values[1] = "";
				oraDB.Parameter_Values[2] = "";

				oraDB.Add_Select_Parameter(true);				
				
				ds_ret = oraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[oraDB.Process_Name];
			}
			catch(System.Exception ex)
			{
				return null;
			}
		}

		/// <summary>
		/// get info model
		/// </summary>
		/// <returns></returns>
		private DataTable SELECT_SVM_OS_MASTER(string arg_factory)
		{			
			try
			{
				//oraDB = new COM.OraDB();
				DataSet ds_ret;
				int iCount  = 3;
				oraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				oraDB.Process_Name = "PKG_SVM_DP_LOAD.SP_GET_DATA";

				//02.ARGURMENT OF PROC
				oraDB.Parameter_Name[0] = ARG_FACTORY;
				oraDB.Parameter_Name[1] = ARG_OS_CODE;
				oraDB.Parameter_Name[2] = ARG_OUT_CURSOR;
				
				//03.Type
				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

				oraDB.Parameter_Values  = new string[iCount];
				oraDB.Parameter_Values[0] = arg_factory;
				oraDB.Parameter_Values[1] = "";
				oraDB.Parameter_Values[2] = "";

				oraDB.Add_Select_Parameter(true);	
				//string strSql = "SELECT FACTORY  , OS_CODE  , MID_SOLE1, MID_SOLE2, MID_SOLE3   FROM   SEPHIROTH.SVM_OS_MASTER";
				//string strSql = "SELECT MODEL_CD,DEV_NAME MODEL_NAME  FROM SVM_DP_LOAD ";
				//ds_ret = oraDB.Exe_Select_Query(strSql);
				ds_ret = oraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[oraDB.Process_Name];
			}
			catch(System.Exception ex)
			{
				return null;
			}
		}

		
		private object MappingModelCode(object p_dev_name, DataTable p_DataTable)
		{
			if(p_DataTable==null) return DBNull.Value;
			if(p_dev_name.Equals(string.Empty)) return DBNull.Value;
			for (int i=0; i<p_DataTable.Rows.Count;i++)
			{
				if(p_DataTable.Rows[i]["MODEL_NAME"].Equals(p_dev_name))
					return p_DataTable.Rows[i]["MODEL_CD"];
			}
			return DBNull.Value;
		}

		private DataRow MappingMidSole(object arg_oscode, DataTable arg_DataTable)
		{
			if(arg_DataTable == null) 
			{
				return null;
			}
			if(arg_oscode.Equals(string.Empty)) 
			{
				return null;
			}
			if(arg_DataTable.Rows.Count < 1 )
			{
				return null;
			}
			for (int i = 0; i < arg_DataTable.Rows.Count; i++)
			{
				if(Convert.ToString(arg_DataTable.Rows[i]["OS_CODE"]).Trim().Equals(arg_oscode.ToString().Trim()))
					return arg_DataTable.Rows[i];
			}
			return null;
		}


		private int Grid_SetColor()
		{
			int l_ErrorRow = 0;
//			for (int vRow = fgrid_Upload.Rows.Fixed ; vRow < fgrid_Upload.Rows.Count ; vRow++)
//			{
//				if ( fgrid_Upload[vRow, G_COL_MODEL_CD].ToString() == "")
//				{
//					l_ErrorRow++;
//					fgrid_Upload.GetCellRange(vRow, G_COL_MODEL_CD).StyleNew.BackColor = Color.Lavender;
//				}
//				else
//				{
//					fgrid_Upload.GetCellRange(vRow, G_COL_MODEL_CD).StyleNew.BackColor =
//						fgrid_Upload.GetCellRange(vRow, G_COL_DEV_NAME).StyleNew.BackColor;
//				}
//			}
			return l_ErrorRow;
		}
		
		
//		private string ConvertOBS_ID(int arg_year, int arg_month)
//		{
//			string rs = string.Empty;
//			string objMonth = string.Empty;
//			string[] arr_ObjMonth=new string[]{
//												  "0305",//1
//												  "0406",//2
//												  "0507",//3
//												  "0608",//4
//												  "0709",//5
//												  "0810",//6
//												  "0911",//7
//												  "1012",//8
//												  "1101",//9
//												  "1202",//10
//												  "0103",//11
//												  "0204",//12
//											  };
//			objMonth = arr_ObjMonth[arg_month - 1];
//			rs = arg_year.ToString().Substring(2,2)+objMonth;
//			return rs;
//		}
		
		private string ConvertOBS_ID(int arg_year, int arg_month)
		{
			string rs = string.Empty;
			int year = int.Parse(arg_year.ToString().Substring(2,2));
			if (arg_month==4)
			{
				rs=year.ToString("0#")+"0103";
			}
			if (arg_month==5)
			{
				rs=year.ToString("0#")+"0204";
			}
			if (arg_month==6)
			{
				rs=year.ToString("0#")+"0305";
			}
			if (arg_month==7)
			{
				rs=year.ToString("0#")+"0406";
			}
			if (arg_month==8)
			{
				rs=year.ToString("0#")+"0507";
			}
			if (arg_month==9)
			{
				rs=year.ToString("0#")+"0608";
			}
			if (arg_month==10)
			{
				rs=year.ToString("0#")+"0709";
			}
			if (arg_month==11)
			{
				rs=year.ToString("0#")+"0810";
			}
			if (arg_month==12)
			{
				year=year;
				rs=(year).ToString("0#")+"0911";
			}
			if (arg_month==1)
			{
				year=year-1;
				rs=year.ToString("0#")+"1012";
			}
			if (arg_month==2)
			{
				year=year-1;
				rs=year.ToString("0#")+"1101";
			}
			if (arg_month==3)
			{
				year=year-1;
				rs=year.ToString("0#")+"1202";
			}
			return rs;
		}
		
		#endregion	
		
		private const int G_COL_FACTORY=1;
		private const int G_COL_CATEGORY_NAME=2;
		private const int G_COL_OBS_ID = 3;
		private const int G_COL_PLAN_MONTH = 4;
		private const int G_COL_OS_CODE = 5;
		private const int G_COL_LINE_CD = 6;
		private const int G_COL_MINI_LINE = 7;
		private const int G_COL_MID_SOLE1 = 8;
		private const int G_COL_MID_SOLE2 = 9;
		private const int G_COL_MID_SOLE3 = 10;
		private const int G_COL_MODEL_CD = 11;
		private const int G_COL_DEV_NAME = 12;
		private const int G_COL_PLAN_QTY = 13;
		private const int G_COL_REMARK01 = 14;
		private const int G_COL_REMARK02 = 15;
		private const int G_COL_REMARK03 = 16;

		private void txt_FileName_DoubleClick(object sender, System.EventArgs e)
		{
			Btn_Browes_Click(Btn_Browes,null);
		}

		private void fgrid_Upload_DoubleClick(object sender, System.EventArgs e)
		{
			if (fgrid_Upload.ColSel != G_COL_MODEL_CD) return;
			if (fgrid_Upload.RowSel < fgrid_Upload.Rows.Fixed) return;
			string p_dev_name = fgrid_Upload[fgrid_Upload.RowSel,G_COL_DEV_NAME].ToString();
			Form_Select_Model f=new Form_Select_Model(p_dev_name);
			if(f.ShowDialog()== DialogResult.OK)
			{
				fgrid_Upload[fgrid_Upload.RowSel,fgrid_Upload.ColSel] = f.Tag;
			}
		}

		private void Form_Demand_Plan_Upload_Excel_Load(object sender, System.EventArgs e)
		{
			tbtn_Search_Click(tbtn_Search,null);
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				for (int i = 0 ; i< fgrid_Upload.Selections.Length; i++)
				{
					fgrid_Upload.Delete_Row(fgrid_Upload.Selections[i]);
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

		private void fgrid_Upload_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData.Equals(Keys.Space))
			{
				COM.FSP l_fgrid_Upload =(COM.FSP) sender;
				if(l_fgrid_Upload.ColSel == G_COL_MODEL_CD)
				{
					string p_dev_name = fgrid_Upload[fgrid_Upload.RowSel,G_COL_DEV_NAME].ToString();
					Form_Select_Model f=new Form_Select_Model(p_dev_name);
					if(f.ShowDialog()== DialogResult.OK)
					{
						fgrid_Upload[fgrid_Upload.RowSel,fgrid_Upload.ColSel] = f.Tag;
					}
				}
			}
		}

		private object _CurrBuff = null;
		

		private DataTable SearchMiniLine(string line_code)
		{
			try
			{
				DataSet ds_ret;
				int iCount  = 2;
				oraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				oraDB.Process_Name = "PKG_SVM_DP_LOAD.sp_get_mini_line";

				//02.ARGURMENT OF PROC
				oraDB.Parameter_Name[0] = "arg_line_code";
				oraDB.Parameter_Name[1] = "OUT_CURSOR";
				
				//03.Type
				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

				oraDB.Parameter_Values  = new string[iCount];
				oraDB.Parameter_Values[0] = line_code;
				oraDB.Parameter_Values[1] = "";

				oraDB.Add_Select_Parameter(true);				
				
				ds_ret = oraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[oraDB.Process_Name];
			}
			catch(System.Exception ex)
			{
				return null;
			}
		}


		private void fgrid_Upload_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			COM.FSP l_fgrid_main=(COM.FSP)sender;
			if(e.Col == G_COL_MID_SOLE1 || e.Col == G_COL_MID_SOLE2 || e.Col == G_COL_MID_SOLE3)
			{
				if(InvalidOnRow(l_fgrid_main,e.Row)==false)
				{
					l_fgrid_main[e.Row, e.Col] = string.Empty;
				}
			}
//			if(e.Col == G_COL_LINE_CD)
//			{
//				DataTable miniline = new DataTable();
//				miniline=SearchMiniLine(l_fgrid_main[e.Row,e.Col].ToString());
//				if(miniline.Rows.Count>0)
//				{
//					l_fgrid_main[e.Row,G_COL_MINI_LINE]=miniline.Rows[0][0].ToString();
//				}
//				else
//				{
//					l_fgrid_main[e.Row,G_COL_MINI_LINE]="";
//				}
//
//			}
			if (_CurrBuff != null)
			{
				if (_CurrBuff.ToString() != l_fgrid_main[e.Row,e.Col].ToString())
				{
					l_fgrid_main.Update_Row(e.Row);
				}
			}
			_CurrBuff = null;
		}

		private void fgrid_Upload_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			COM.FSP l_fgrid_main=(COM.FSP)sender;
			_CurrBuff = l_fgrid_main[e.Row,e.Col];
		}

		private void fgrid_Upload_BeforeSort(object sender, C1.Win.C1FlexGrid.SortColEventArgs e)
		{
			COM.FSP l_grid = (COM.FSP)sender;
			if(e.Col == G_COL_CATEGORY_NAME || e.Col == G_COL_OS_CODE)
			{
				// hadle the sort ourselves
				Cursor = Cursors.WaitCursor;
				CustomSort(l_grid, e.Col);
				Cursor = Cursors.Default;
				// tell control we handled it
				e.Handled = true;
			}
		}

		private void CustomSort(COM.FSP arg_Grid, int arg_Col)
		{
			if(arg_Grid.Cols[arg_Col].Sort == SortFlags.Ascending)
			{
				arg_Grid.Cols[arg_Col].Sort = SortFlags.Descending;
				arg_Grid.Sort(SortFlags.Descending,arg_Col);
				
			}
			else
			{
				arg_Grid.Sort(SortFlags.Ascending,arg_Col);
				arg_Grid.Cols[arg_Col].Sort = SortFlags.Ascending;
				
			}
		}



	}
}