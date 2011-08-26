using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlexVJ_Common.ETC
{
	public class Form_General_Affair : COM.VJ_CommonWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Panel pnl_head;
		public System.Windows.Forms.CheckBox chk_manual;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.CheckBox chk_CheckInOut;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label btn_shipCheck;
		private System.Windows.Forms.Label btn_prodCheck;
		private System.Windows.Forms.TextBox txt_presto_yn;
		private System.Windows.Forms.Label lbl_presto;
		private System.Windows.Forms.TextBox txt_gender;
		private System.Windows.Forms.Label lbl_gender;
		private System.Windows.Forms.Label lbl_division;
		private C1.Win.C1List.C1Combo cmb_devision;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.TextBox txt_styleCd;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_styleCd;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.ComponentModel.IContainer components = null;

		public Form_General_Affair()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_General_Affair));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_main = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.fgrid_main = new COM.FSP();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.chk_manual = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chk_CheckInOut = new System.Windows.Forms.CheckBox();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_shipCheck = new System.Windows.Forms.Label();
			this.btn_prodCheck = new System.Windows.Forms.Label();
			this.txt_presto_yn = new System.Windows.Forms.TextBox();
			this.lbl_presto = new System.Windows.Forms.Label();
			this.txt_gender = new System.Windows.Forms.TextBox();
			this.lbl_gender = new System.Windows.Forms.Label();
			this.lbl_division = new System.Windows.Forms.Label();
			this.cmb_devision = new C1.Win.C1List.C1Combo();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.txt_styleCd = new System.Windows.Forms.TextBox();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.lbl_styleCd = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.cmb_style = new C1.Win.C1List.C1Combo();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_head.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_devision)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
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
			// stbar
			// 
			this.stbar.Name = "stbar";
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
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.Controls.Add(this.pnl_main);
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.GridDefinition = "19.7916666666667:False:True;78.125:False:False;\t0.393700787401575:False:True;97.6" +
				"377952755905:False:False;0.393700787401575:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 30;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_main
			// 
			this.pnl_main.Controls.Add(this.pictureBox2);
			this.pnl_main.Controls.Add(this.label1);
			this.pnl_main.Controls.Add(this.pictureBox1);
			this.pnl_main.Controls.Add(this.fgrid_main);
			this.pnl_main.Location = new System.Drawing.Point(12, 122);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(992, 450);
			this.pnl_main.TabIndex = 1;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(976, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 45;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 30);
			this.label1.TabIndex = 44;
			this.label1.Text = "      Material Info.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(208, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(952, 32);
			this.pictureBox1.TabIndex = 43;
			this.pictureBox1.TabStop = false;
			// 
			// fgrid_main
			// 
			this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 32);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(992, 415);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 1;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.chk_manual);
			this.pnl_head.Controls.Add(this.groupBox2);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.groupBox1);
			this.pnl_head.Controls.Add(this.txt_presto_yn);
			this.pnl_head.Controls.Add(this.lbl_presto);
			this.pnl_head.Controls.Add(this.txt_gender);
			this.pnl_head.Controls.Add(this.lbl_gender);
			this.pnl_head.Controls.Add(this.lbl_division);
			this.pnl_head.Controls.Add(this.cmb_devision);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.txt_styleCd);
			this.pnl_head.Controls.Add(this.lbl_factory);
			this.pnl_head.Controls.Add(this.lbl_styleCd);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Controls.Add(this.cmb_style);
			this.pnl_head.Location = new System.Drawing.Point(12, 4);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(992, 114);
			this.pnl_head.TabIndex = 0;
			// 
			// chk_manual
			// 
			this.chk_manual.BackColor = System.Drawing.Color.Transparent;
			this.chk_manual.Location = new System.Drawing.Point(832, 88);
			this.chk_manual.Name = "chk_manual";
			this.chk_manual.Size = new System.Drawing.Size(152, 24);
			this.chk_manual.TabIndex = 364;
			this.chk_manual.Text = "start manual mode";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chk_CheckInOut);
			this.groupBox2.Location = new System.Drawing.Point(908, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(75, 51);
			this.groupBox2.TabIndex = 363;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Check";
			// 
			// chk_CheckInOut
			// 
			this.chk_CheckInOut.BackColor = System.Drawing.Color.Transparent;
			this.chk_CheckInOut.Location = new System.Drawing.Point(6, 18);
			this.chk_CheckInOut.Name = "chk_CheckInOut";
			this.chk_CheckInOut.Size = new System.Drawing.Size(76, 24);
			this.chk_CheckInOut.TabIndex = 0;
			this.chk_CheckInOut.Text = "In/Out";
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(976, 98);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_shipCheck);
			this.groupBox1.Controls.Add(this.btn_prodCheck);
			this.groupBox1.Location = new System.Drawing.Point(728, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(180, 51);
			this.groupBox1.TabIndex = 362;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Auto Check ";
			// 
			// btn_shipCheck
			// 
			this.btn_shipCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_shipCheck.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_shipCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_shipCheck.ImageIndex = 0;
			this.btn_shipCheck.ImageList = this.img_Button;
			this.btn_shipCheck.Location = new System.Drawing.Point(9, 24);
			this.btn_shipCheck.Name = "btn_shipCheck";
			this.btn_shipCheck.Size = new System.Drawing.Size(80, 23);
			this.btn_shipCheck.TabIndex = 361;
			this.btn_shipCheck.Text = "Shipping";
			this.btn_shipCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_prodCheck
			// 
			this.btn_prodCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_prodCheck.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_prodCheck.Enabled = false;
			this.btn_prodCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_prodCheck.ImageIndex = 0;
			this.btn_prodCheck.ImageList = this.img_Button;
			this.btn_prodCheck.Location = new System.Drawing.Point(90, 24);
			this.btn_prodCheck.Name = "btn_prodCheck";
			this.btn_prodCheck.Size = new System.Drawing.Size(80, 23);
			this.btn_prodCheck.TabIndex = 361;
			this.btn_prodCheck.Text = "Production";
			this.btn_prodCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_presto_yn
			// 
			this.txt_presto_yn.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_presto_yn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_presto_yn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txt_presto_yn.Location = new System.Drawing.Point(623, 62);
			this.txt_presto_yn.Name = "txt_presto_yn";
			this.txt_presto_yn.ReadOnly = true;
			this.txt_presto_yn.TabIndex = 5;
			this.txt_presto_yn.Text = "";
			// 
			// lbl_presto
			// 
			this.lbl_presto.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_presto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_presto.ImageIndex = 0;
			this.lbl_presto.ImageList = this.img_Label;
			this.lbl_presto.Location = new System.Drawing.Point(522, 62);
			this.lbl_presto.Name = "lbl_presto";
			this.lbl_presto.Size = new System.Drawing.Size(100, 21);
			this.lbl_presto.TabIndex = 50;
			this.lbl_presto.Text = "Presto";
			this.lbl_presto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_gender
			// 
			this.txt_gender.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txt_gender.Location = new System.Drawing.Point(421, 62);
			this.txt_gender.Name = "txt_gender";
			this.txt_gender.ReadOnly = true;
			this.txt_gender.TabIndex = 5;
			this.txt_gender.Text = "";
			// 
			// lbl_gender
			// 
			this.lbl_gender.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_gender.ImageIndex = 0;
			this.lbl_gender.ImageList = this.img_Label;
			this.lbl_gender.Location = new System.Drawing.Point(320, 62);
			this.lbl_gender.Name = "lbl_gender";
			this.lbl_gender.Size = new System.Drawing.Size(100, 21);
			this.lbl_gender.TabIndex = 50;
			this.lbl_gender.Text = "Gender";
			this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_division
			// 
			this.lbl_division.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_division.ImageIndex = 0;
			this.lbl_division.ImageList = this.img_Label;
			this.lbl_division.Location = new System.Drawing.Point(8, 62);
			this.lbl_division.Name = "lbl_division";
			this.lbl_division.Size = new System.Drawing.Size(100, 21);
			this.lbl_division.TabIndex = 50;
			this.lbl_division.Text = "Division";
			this.lbl_division.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_devision
			// 
			this.cmb_devision.AddItemCols = 0;
			this.cmb_devision.AddItemSeparator = ';';
			this.cmb_devision.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_devision.AutoSize = false;
			this.cmb_devision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_devision.Caption = "";
			this.cmb_devision.CaptionHeight = 17;
			this.cmb_devision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_devision.ColumnCaptionHeight = 18;
			this.cmb_devision.ColumnFooterHeight = 18;
			this.cmb_devision.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_devision.ContentHeight = 17;
			this.cmb_devision.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_devision.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_devision.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_devision.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_devision.EditorHeight = 17;
			this.cmb_devision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_devision.GapHeight = 2;
			this.cmb_devision.ItemHeight = 15;
			this.cmb_devision.Location = new System.Drawing.Point(109, 62);
			this.cmb_devision.MatchEntryTimeout = ((long)(2000));
			this.cmb_devision.MaxDropDownItems = ((short)(5));
			this.cmb_devision.MaxLength = 32767;
			this.cmb_devision.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_devision.Name = "cmb_devision";
			this.cmb_devision.PartialRightColumn = false;
			this.cmb_devision.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"rollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Widt" +
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
			this.cmb_devision.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_devision.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_devision.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_devision.Size = new System.Drawing.Size(200, 21);
			this.cmb_devision.TabIndex = 4;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 97);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(952, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
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
			this.cmb_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
				"rollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Widt" +
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
			this.cmb_factory.TabIndex = 1;
			// 
			// txt_styleCd
			// 
			this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_styleCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txt_styleCd.Location = new System.Drawing.Point(421, 40);
			this.txt_styleCd.MaxLength = 10;
			this.txt_styleCd.Name = "txt_styleCd";
			this.txt_styleCd.TabIndex = 2;
			this.txt_styleCd.Text = "";
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 1;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 50;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_styleCd
			// 
			this.lbl_styleCd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_styleCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_styleCd.ImageIndex = 1;
			this.lbl_styleCd.ImageList = this.img_Label;
			this.lbl_styleCd.Location = new System.Drawing.Point(320, 40);
			this.lbl_styleCd.Name = "lbl_styleCd";
			this.lbl_styleCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_styleCd.TabIndex = 50;
			this.lbl_styleCd.Text = "Style";
			this.lbl_styleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(891, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 73);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
			this.pic_head2.Location = new System.Drawing.Point(976, 0);
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
			this.label2.Text = "      Shipping Material Info";
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
			this.pic_head1.Size = new System.Drawing.Size(952, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// pic_head5
			// 
			this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
			this.pic_head5.Location = new System.Drawing.Point(0, 98);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 87);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// cmb_style
			// 
			this.cmb_style.AddItemCols = 0;
			this.cmb_style.AddItemSeparator = ';';
			this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_style.AutoSize = false;
			this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_style.Caption = "";
			this.cmb_style.CaptionHeight = 17;
			this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_style.ColumnCaptionHeight = 18;
			this.cmb_style.ColumnFooterHeight = 18;
			this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_style.ContentHeight = 17;
			this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_style.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_style.EditorHeight = 17;
			this.cmb_style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_style.GapHeight = 2;
			this.cmb_style.ItemHeight = 15;
			this.cmb_style.Location = new System.Drawing.Point(522, 40);
			this.cmb_style.MatchEntryTimeout = ((long)(2000));
			this.cmb_style.MaxDropDownItems = ((short)(5));
			this.cmb_style.MaxLength = 32767;
			this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_style.Name = "cmb_style";
			this.cmb_style.PartialRightColumn = false;
			this.cmb_style.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"rollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Widt" +
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
			this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_style.Size = new System.Drawing.Size(201, 21);
			this.cmb_style.TabIndex = 3;
			// 
			// Form_General_Affair
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_General_Affair";
			this.Load += new System.EventHandler(this.Form_General_Affair_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_head.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_devision)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_General_Affair_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}

