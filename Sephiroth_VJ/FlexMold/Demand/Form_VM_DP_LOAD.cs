using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;
using Microsoft.Office.Core;
using System.Data.OracleClient;

namespace FlexMold.Demand
{
	public class Form_VM_DP_LOAD : COM.OrderWinForm.Form_Top
	{
		public System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.Panel pnl_progress;
		private System.Windows.Forms.Label lbl_m;
		private System.Windows.Forms.Label lbl_u;
		private System.Windows.Forms.Label lbl_s;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbl_3;
		private System.Windows.Forms.Label lbl_2;
		private System.Windows.Forms.Label lbl_1;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.ImageList img_MiniBtn;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private C1.Win.C1List.C1Combo cmb_Del;
		private System.Windows.Forms.Label lbl_Del_Month;
		private System.Windows.Forms.DateTimePicker dpick_down_ymd;
		private System.Windows.Forms.Label lbl_DOWN_YMD;
		private System.Windows.Forms.TextBox txtsheet;
		private System.Windows.Forms.Label lbl_sheet;
		private System.Windows.Forms.Label btn_path;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.TextBox txt_Style;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lbl_STYLE;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.TextBox text;
		private System.Windows.Forms.Label lblStyle;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.TextBox txt_MinPo;
		private System.Windows.Forms.TextBox txt_MaxPo;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;	
		private System.ComponentModel.IContainer components = null;

		public Form_VM_DP_LOAD()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_VM_DP_LOAD));
			this.img_MiniBtn = new System.Windows.Forms.ImageList(this.components);
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.pnl_progress = new System.Windows.Forms.Panel();
			this.lbl_m = new System.Windows.Forms.Label();
			this.lbl_u = new System.Windows.Forms.Label();
			this.lbl_s = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label9 = new System.Windows.Forms.Label();
			this.lbl_3 = new System.Windows.Forms.Label();
			this.lbl_2 = new System.Windows.Forms.Label();
			this.lbl_1 = new System.Windows.Forms.Label();
			this.fgrid_Main = new COM.FSP();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.lblStyle = new System.Windows.Forms.Label();
			this.cmb_Del = new C1.Win.C1List.C1Combo();
			this.lbl_Del_Month = new System.Windows.Forms.Label();
			this.dpick_down_ymd = new System.Windows.Forms.DateTimePicker();
			this.lbl_DOWN_YMD = new System.Windows.Forms.Label();
			this.txtsheet = new System.Windows.Forms.TextBox();
			this.lbl_sheet = new System.Windows.Forms.Label();
			this.btn_path = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.text = new System.Windows.Forms.TextBox();
			this.lbl_STYLE = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.txt_MinPo = new System.Windows.Forms.TextBox();
			this.txt_MaxPo = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Body.SuspendLayout();
			this.pnl_progress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
			// img_MiniBtn
			// 
			this.img_MiniBtn.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniBtn.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniBtn.ImageStream")));
			this.img_MiniBtn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.pnl_progress);
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 192);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 448);
			this.pnl_Body.TabIndex = 44;
			// 
			// pnl_progress
			// 
			this.pnl_progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_progress.BackgroundImage")));
			this.pnl_progress.Controls.Add(this.lbl_m);
			this.pnl_progress.Controls.Add(this.lbl_u);
			this.pnl_progress.Controls.Add(this.lbl_s);
			this.pnl_progress.Controls.Add(this.progressBar1);
			this.pnl_progress.Controls.Add(this.label9);
			this.pnl_progress.Controls.Add(this.lbl_3);
			this.pnl_progress.Controls.Add(this.lbl_2);
			this.pnl_progress.Controls.Add(this.lbl_1);
			this.pnl_progress.Location = new System.Drawing.Point(324, 137);
			this.pnl_progress.Name = "pnl_progress";
			this.pnl_progress.Size = new System.Drawing.Size(368, 175);
			this.pnl_progress.TabIndex = 45;
			// 
			// lbl_m
			// 
			this.lbl_m.BackColor = System.Drawing.Color.Transparent;
			this.lbl_m.Location = new System.Drawing.Point(144, 126);
			this.lbl_m.Name = "lbl_m";
			this.lbl_m.Size = new System.Drawing.Size(208, 14);
			this.lbl_m.TabIndex = 33;
			// 
			// lbl_u
			// 
			this.lbl_u.BackColor = System.Drawing.Color.Transparent;
			this.lbl_u.Location = new System.Drawing.Point(144, 108);
			this.lbl_u.Name = "lbl_u";
			this.lbl_u.Size = new System.Drawing.Size(208, 14);
			this.lbl_u.TabIndex = 32;
			// 
			// lbl_s
			// 
			this.lbl_s.BackColor = System.Drawing.Color.Transparent;
			this.lbl_s.Location = new System.Drawing.Point(144, 88);
			this.lbl_s.Name = "lbl_s";
			this.lbl_s.Size = new System.Drawing.Size(216, 14);
			this.lbl_s.TabIndex = 31;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(27, 144);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(317, 20);
			this.progressBar1.TabIndex = 30;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DarkGreen;
			this.label9.Location = new System.Drawing.Point(32, 64);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 14);
			this.label9.TabIndex = 17;
			this.label9.Text = "Upload Status...";
			// 
			// lbl_3
			// 
			this.lbl_3.BackColor = System.Drawing.Color.Transparent;
			this.lbl_3.ForeColor = System.Drawing.Color.Silver;
			this.lbl_3.Location = new System.Drawing.Point(27, 124);
			this.lbl_3.Name = "lbl_3";
			this.lbl_3.Size = new System.Drawing.Size(104, 16);
			this.lbl_3.TabIndex = 16;
			this.lbl_3.Text = "   Data Upload";
			// 
			// lbl_2
			// 
			this.lbl_2.BackColor = System.Drawing.Color.Transparent;
			this.lbl_2.ForeColor = System.Drawing.Color.Silver;
			this.lbl_2.Location = new System.Drawing.Point(27, 106);
			this.lbl_2.Name = "lbl_2";
			this.lbl_2.Size = new System.Drawing.Size(104, 16);
			this.lbl_2.TabIndex = 15;
			this.lbl_2.Text = "   Region Check";
			// 
			// lbl_1
			// 
			this.lbl_1.BackColor = System.Drawing.Color.Transparent;
			this.lbl_1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.lbl_1.Location = new System.Drawing.Point(27, 88);
			this.lbl_1.Name = "lbl_1";
			this.lbl_1.Size = new System.Drawing.Size(101, 14);
			this.lbl_1.TabIndex = 11;
			this.lbl_1.Text = "   Style Check ";
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AllowEditing = false;
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:1{AllowMerging:True;}\t";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(1000, 448);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;Border:Flat,1,Control,Vertical;}	Fixed{BackColor:226, 245, 153;ForeColor:Black;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;ForeColor:Black;}	Focus{BackColor:236, 247, 187;ForeColor:Black;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 38;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Location = new System.Drawing.Point(0, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.TabIndex = 0;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Location = new System.Drawing.Point(0, 0);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.TabIndex = 0;
			this.pictureBox9.TabStop = false;
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_Search1_Image);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 128);
			this.pnl_Search.TabIndex = 45;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.Transparent;
			this.pnl_Search1_Image.Controls.Add(this.pictureBox12);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox11);
			this.pnl_Search1_Image.Controls.Add(this.lblStyle);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Del);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Del_Month);
			this.pnl_Search1_Image.Controls.Add(this.dpick_down_ymd);
			this.pnl_Search1_Image.Controls.Add(this.lbl_DOWN_YMD);
			this.pnl_Search1_Image.Controls.Add(this.txtsheet);
			this.pnl_Search1_Image.Controls.Add(this.lbl_sheet);
			this.pnl_Search1_Image.Controls.Add(this.btn_path);
			this.pnl_Search1_Image.Controls.Add(this.txtPath);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.txt_Style);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Type);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox3);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(1000, 112);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox12.BackColor = System.Drawing.Color.Blue;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(0, 98);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(80, 14);
			this.pictureBox12.TabIndex = 194;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(72, 98);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(912, 14);
			this.pictureBox11.TabIndex = 193;
			this.pictureBox11.TabStop = false;
			// 
			// lblStyle
			// 
			this.lblStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lblStyle.Font = new System.Drawing.Font("Verdana", 8F);
			this.lblStyle.ImageIndex = 0;
			this.lblStyle.ImageList = this.img_Label;
			this.lblStyle.Location = new System.Drawing.Point(344, 36);
			this.lblStyle.Name = "lblStyle";
			this.lblStyle.Size = new System.Drawing.Size(100, 21);
			this.lblStyle.TabIndex = 192;
			this.lblStyle.Text = "Style";
			this.lblStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Del
			// 
			this.cmb_Del.AddItemCols = 0;
			this.cmb_Del.AddItemSeparator = ';';
			this.cmb_Del.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Del.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Del.Caption = "";
			this.cmb_Del.CaptionHeight = 17;
			this.cmb_Del.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Del.ColumnCaptionHeight = 18;
			this.cmb_Del.ColumnFooterHeight = 18;
			this.cmb_Del.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Del.ContentHeight = 15;
			this.cmb_Del.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Del.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Del.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Del.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Del.EditorHeight = 15;
			this.cmb_Del.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Del.GapHeight = 2;
			this.cmb_Del.ItemHeight = 15;
			this.cmb_Del.Location = new System.Drawing.Point(445, 58);
			this.cmb_Del.MatchEntryTimeout = ((long)(2000));
			this.cmb_Del.MaxDropDownItems = ((short)(5));
			this.cmb_Del.MaxLength = 32767;
			this.cmb_Del.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Del.Name = "cmb_Del";
			this.cmb_Del.PartialRightColumn = false;
			this.cmb_Del.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_Del.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Del.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Del.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Del.Size = new System.Drawing.Size(211, 19);
			this.cmb_Del.TabIndex = 191;
			// 
			// lbl_Del_Month
			// 
			this.lbl_Del_Month.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Del_Month.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Del_Month.ImageIndex = 0;
			this.lbl_Del_Month.ImageList = this.img_Label;
			this.lbl_Del_Month.Location = new System.Drawing.Point(344, 58);
			this.lbl_Del_Month.Name = "lbl_Del_Month";
			this.lbl_Del_Month.Size = new System.Drawing.Size(100, 21);
			this.lbl_Del_Month.TabIndex = 190;
			this.lbl_Del_Month.Text = "Delivery Month";
			this.lbl_Del_Month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_down_ymd
			// 
			this.dpick_down_ymd.CustomFormat = "yyyy-MM-dd";
			this.dpick_down_ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_down_ymd.Location = new System.Drawing.Point(111, 80);
			this.dpick_down_ymd.Name = "dpick_down_ymd";
			this.dpick_down_ymd.Size = new System.Drawing.Size(210, 22);
			this.dpick_down_ymd.TabIndex = 118;
			// 
			// lbl_DOWN_YMD
			// 
			this.lbl_DOWN_YMD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_DOWN_YMD.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_DOWN_YMD.ImageIndex = 1;
			this.lbl_DOWN_YMD.ImageList = this.img_Label;
			this.lbl_DOWN_YMD.Location = new System.Drawing.Point(10, 80);
			this.lbl_DOWN_YMD.Name = "lbl_DOWN_YMD";
			this.lbl_DOWN_YMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_DOWN_YMD.TabIndex = 115;
			this.lbl_DOWN_YMD.Text = "Download date";
			this.lbl_DOWN_YMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtsheet
			// 
			this.txtsheet.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtsheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtsheet.Font = new System.Drawing.Font("Verdana", 8F);
			this.txtsheet.ForeColor = System.Drawing.Color.Black;
			this.txtsheet.Location = new System.Drawing.Point(780, 36);
			this.txtsheet.MaxLength = 100;
			this.txtsheet.Name = "txtsheet";
			this.txtsheet.ReadOnly = true;
			this.txtsheet.Size = new System.Drawing.Size(210, 20);
			this.txtsheet.TabIndex = 113;
			this.txtsheet.Text = "";
			// 
			// lbl_sheet
			// 
			this.lbl_sheet.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_sheet.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_sheet.ImageIndex = 2;
			this.lbl_sheet.ImageList = this.img_Label;
			this.lbl_sheet.Location = new System.Drawing.Point(680, 36);
			this.lbl_sheet.Name = "lbl_sheet";
			this.lbl_sheet.Size = new System.Drawing.Size(100, 21);
			this.lbl_sheet.TabIndex = 112;
			this.lbl_sheet.Text = "Sheet";
			this.lbl_sheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_path
			// 
			this.btn_path.ImageIndex = 0;
			this.btn_path.ImageList = this.img_MiniBtn;
			this.btn_path.Location = new System.Drawing.Point(299, 58);
			this.btn_path.Name = "btn_path";
			this.btn_path.Size = new System.Drawing.Size(21, 21);
			this.btn_path.TabIndex = 111;
			this.btn_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
			// 
			// txtPath
			// 
			this.txtPath.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPath.Font = new System.Drawing.Font("Verdana", 8F);
			this.txtPath.ForeColor = System.Drawing.Color.Black;
			this.txtPath.Location = new System.Drawing.Point(111, 58);
			this.txtPath.MaxLength = 100;
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(187, 20);
			this.txtPath.TabIndex = 110;
			this.txtPath.Text = "";
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 18;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Style
			// 
			this.txt_Style.BackColor = System.Drawing.Color.White;
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style.Location = new System.Drawing.Point(445, 36);
			this.txt_Style.MaxLength = 100;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.Size = new System.Drawing.Size(210, 20);
			this.txt_Style.TabIndex = 107;
			this.txt_Style.Text = "";
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory.Caption = "";
			this.cmb_Factory.CaptionHeight = 17;
			this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory.ColumnCaptionHeight = 18;
			this.cmb_Factory.ColumnFooterHeight = 18;
			this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory.ContentHeight = 15;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 15;
			this.cmb_Factory.FetchRowStyles = true;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(111, 36);
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
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" FetchRowStyles=\"True\" VerticalScrollGroup=\"1\" Hor" +
				"izontalScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width" +
				">17</Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyl" +
				"e parent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><Fo" +
				"oterStyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" " +
				"/><HeadingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"Highli" +
				"ghtRow\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyl" +
				"e parent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=" +
				"\"Style10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal" +
				"\" me=\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=" +
				"\"\" me=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" m" +
				"e=\"Footer\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"" +
				"Inactive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Hi" +
				"ghlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"O" +
				"ddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" m" +
				"e=\"Group\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><L" +
				"ayout>Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 37;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(978, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 32);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(168, -1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(816, 32);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle1.TabIndex = 0;
			this.lbl_SubTitle1.Text = "      BP Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(981, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 66);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(910, 98);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 1;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(10, 58);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Type.TabIndex = 19;
			this.lbl_OBS_Type.Text = "File name";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 24);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 77);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// text
			// 
			this.text.Location = new System.Drawing.Point(0, 0);
			this.text.Name = "text";
			this.text.TabIndex = 0;
			this.text.Text = "";
			// 
			// lbl_STYLE
			// 
			this.lbl_STYLE.Location = new System.Drawing.Point(0, 0);
			this.lbl_STYLE.Name = "lbl_STYLE";
			this.lbl_STYLE.TabIndex = 0;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(0, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Location = new System.Drawing.Point(0, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.TabIndex = 0;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Location = new System.Drawing.Point(0, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.TabIndex = 0;
			this.pictureBox10.TabStop = false;
			// 
			// txt_MinPo
			// 
			this.txt_MinPo.BackColor = System.Drawing.Color.White;
			this.txt_MinPo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_MinPo.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_MinPo.Location = new System.Drawing.Point(896, 32);
			this.txt_MinPo.MaxLength = 100;
			this.txt_MinPo.Name = "txt_MinPo";
			this.txt_MinPo.Size = new System.Drawing.Size(112, 21);
			this.txt_MinPo.TabIndex = 109;
			this.txt_MinPo.Text = "";
			// 
			// txt_MaxPo
			// 
			this.txt_MaxPo.Location = new System.Drawing.Point(0, 0);
			this.txt_MaxPo.Name = "txt_MaxPo";
			this.txt_MaxPo.TabIndex = 28;
			this.txt_MaxPo.Text = "";
			// 
			// Form_VM_DP_LOAD
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.txt_MaxPo);
			this.Controls.Add(this.txt_MinPo);
			this.Controls.Add(this.pnl_Search);
			this.Controls.Add(this.pnl_Body);
			this.Name = "Form_VM_DP_LOAD";
			this.Load += new System.EventHandler(this.Form_VM_DP_LOAD_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.txt_MinPo, 0);
			this.Controls.SetChildIndex(this.txt_MaxPo, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			this.pnl_progress.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		private int _Rowfixed;  
		private string _sheet1, _sheet2;
		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction    = new COM.ComFunction();

		private void Form_VM_DP_LOAD_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{ 
			
			//Title
			this.Text = "Demand Plan Upload";
			this.lbl_MainTitle.Text = "Demand Plan Upload"; 
			ClassLib.ComFunction.SetLangDic(this);


			#region 버튼 권한
			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled =false;
			tbtn_Create.Enabled =false;
			tbtn_Delete.Enabled =false;
			tbtn_Insert.Enabled =false;
			tbtn_New.Enabled =true;
			tbtn_Print.Enabled =false;
			tbtn_Save.Enabled =true;
			tbtn_Search.Enabled =true;


			#endregion

			DataTable dt_list;
			
			// 그리드 설정
			// fgrid_main
			fgrid_Main.Set_Grid("SVM_DP", "1", 1,ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch,false);

			_Rowfixed = fgrid_Main.Rows.Fixed;		
			fgrid_Main.Set_Action_Image(img_Action); 
			fgrid_Main.Font  = new Font("Verdana",8);
				
			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
	
			// Get target Excel File Path
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxBP_Path);
			txtPath.Text = dt_list.Rows[0].ItemArray[1].ToString();

			// Get target Excel File Sheetname
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxBP_Sheet);
			_sheet1 = dt_list.Rows[0].ItemArray[1].ToString();
			_sheet2 = dt_list.Rows[1].ItemArray[1].ToString();
			txtsheet.Text = _sheet1 + ", " + _sheet2; 		
			
			txt_MinPo.Visible  = false; txt_MaxPo.Visible = false;
			txt_MinPo.Text = "99999999"; txt_MaxPo.Text = "00000000";
			

			//Date
			dpick_down_ymd.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			string now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_down_ymd.Text = MyComFunction.ConvertDate2Type(now);


			//Delievery Month
			#region Delievery
			DateTime CurDate = DateTime.Now;

			lbl_Del_Month.Text = "Delievery";
			cmb_Del.Enabled  = true;

			cmb_Del.ClearItems();
			

			///del_month_From
			cmb_Del.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			cmb_Del.ClearItems();
			cmb_Del.ExtendRightColumn = true;
			cmb_Del.ColumnHeaders = false;
			cmb_Del.AddItem(" ");
			for(int  i = -5; i <= 10; i++)
				cmb_Del.AddItem( CurDate.AddMonths(i).ToString("yyyyMM") + "01" );
			cmb_Del.MaxDropDownItems = Convert.ToInt16(cmb_Del.ListCount);



			#endregion 


			txt_Style.Enabled  = false;
			cmb_Del.Enabled    = false;

			// Setting Progress Bar..
			pnl_progress.Visible = false;
			pnl_progress.Location = new Point(344, 64);
			
		


			//ClassLib.ComFunction.Get_Values(this, dpick_down_ymd.Name);

		}

		private void btn_path_Click(object sender, System.EventArgs e)
		{
			openFileDialog1.InitialDirectory = txtPath.Text;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtPath.Text = openFileDialog1.FileName;
			}
		}
		
		
	}
}

