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


namespace FlexTraining.Management
{
	public class Form_Training_Attendance : COM.TrainingWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private COM.FSP fgrid_main;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.TextBox txt_Group;
		private System.Windows.Forms.TextBox txt_Wave;
		private System.Windows.Forms.TextBox txt_Seq;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Training;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.Label lbl_Training;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem mnu_Check;
		private System.Windows.Forms.MenuItem mnu_Cancel;
		private System.Windows.Forms.TextBox txt_T_Code;
		private System.ComponentModel.IContainer components = null;

		public Form_Training_Attendance(string [] arg_keys)
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			_vfactory	= arg_keys[0];
			_vt_code	= arg_keys[1];
			_vt_name	= arg_keys[2];
			_vseq	    = arg_keys[3];

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Training_Attendance));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_T_Code = new System.Windows.Forms.TextBox();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.txt_Group = new System.Windows.Forms.TextBox();
			this.txt_Wave = new System.Windows.Forms.TextBox();
			this.txt_Seq = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Training = new System.Windows.Forms.TextBox();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.lbl_Training = new System.Windows.Forms.Label();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pnl_Menu = new System.Windows.Forms.Panel();
			this.btn_Insert = new System.Windows.Forms.Label();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.mnu_Check = new System.Windows.Forms.MenuItem();
			this.mnu_Cancel = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			this.pnl_Menu.SuspendLayout();
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
			this.c1Sizer1.Controls.Add(this.pnl_Menu);
			this.c1Sizer1.Controls.Add(this.statusBar1);
			this.c1Sizer1.GridDefinition = "22.6666666666667:False:True;64.5:False:False;7.16666666666667:False:True;3.666666" +
				"66666667:False:True;\t99.609375:False:False;0:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1024, 600);
			this.c1Sizer1.TabIndex = 30;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel2.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.panel2.Location = new System.Drawing.Point(0, 140);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1020, 387);
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
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(1020, 387);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 32;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.Controls.Add(this.pictureBox6);
			this.pnl_Search.DockPadding.All = 7;
			this.pnl_Search.Location = new System.Drawing.Point(0, 0);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1024, 136);
			this.pnl_Search.TabIndex = 45;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_T_Code);
			this.pnl_SearchImage.Controls.Add(this.btn_Apply);
			this.pnl_SearchImage.Controls.Add(this.txt_Group);
			this.pnl_SearchImage.Controls.Add(this.txt_Wave);
			this.pnl_SearchImage.Controls.Add(this.txt_Seq);
			this.pnl_SearchImage.Controls.Add(this.label3);
			this.pnl_SearchImage.Controls.Add(this.label2);
			this.pnl_SearchImage.Controls.Add(this.label1);
			this.pnl_SearchImage.Controls.Add(this.txt_Training);
			this.pnl_SearchImage.Controls.Add(this.cmb_factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_factory);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.lbl_Training);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(7, 7);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1010, 122);
			this.pnl_SearchImage.TabIndex = 18;
			this.pnl_SearchImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_SearchImage_Paint);
			// 
			// txt_T_Code
			// 
			this.txt_T_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_T_Code.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_T_Code.Location = new System.Drawing.Point(110, 59);
			this.txt_T_Code.MaxLength = 20;
			this.txt_T_Code.Name = "txt_T_Code";
			this.txt_T_Code.Size = new System.Drawing.Size(104, 21);
			this.txt_T_Code.TabIndex = 567;
			this.txt_T_Code.Text = "";
			// 
			// btn_Apply
			// 
			this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(912, 88);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(80, 23);
			this.btn_Apply.TabIndex = 566;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			// 
			// txt_Group
			// 
			this.txt_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Group.Enabled = false;
			this.txt_Group.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Group.Location = new System.Drawing.Point(709, 35);
			this.txt_Group.MaxLength = 20;
			this.txt_Group.Name = "txt_Group";
			this.txt_Group.Size = new System.Drawing.Size(292, 21);
			this.txt_Group.TabIndex = 165;
			this.txt_Group.Text = "";
			// 
			// txt_Wave
			// 
			this.txt_Wave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Wave.Enabled = false;
			this.txt_Wave.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Wave.Location = new System.Drawing.Point(709, 57);
			this.txt_Wave.MaxLength = 20;
			this.txt_Wave.Name = "txt_Wave";
			this.txt_Wave.Size = new System.Drawing.Size(80, 21);
			this.txt_Wave.TabIndex = 164;
			this.txt_Wave.Text = "";
			// 
			// txt_Seq
			// 
			this.txt_Seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Seq.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Seq.Location = new System.Drawing.Point(110, 81);
			this.txt_Seq.MaxLength = 20;
			this.txt_Seq.Name = "txt_Seq";
			this.txt_Seq.Size = new System.Drawing.Size(104, 21);
			this.txt_Seq.TabIndex = 162;
			this.txt_Seq.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(608, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 159;
			this.label3.Text = "Wave";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(8, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 157;
			this.label2.Text = "Sequence";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(608, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 155;
			this.label1.Text = "Group";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Training
			// 
			this.txt_Training.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Training.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Training.Location = new System.Drawing.Point(215, 59);
			this.txt_Training.MaxLength = 20;
			this.txt_Training.Name = "txt_Training";
			this.txt_Training.Size = new System.Drawing.Size(312, 21);
			this.txt_Training.TabIndex = 154;
			this.txt_Training.Text = "";
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
			this.cmb_factory.Location = new System.Drawing.Point(110, 37);
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
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_factory.TabIndex = 151;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 36);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 152;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(909, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 84);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(996, 107);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(13, 15);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(775, 28);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      Search Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Training
			// 
			this.lbl_Training.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Training.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Training.ImageIndex = 0;
			this.lbl_Training.ImageList = this.img_Label;
			this.lbl_Training.Location = new System.Drawing.Point(8, 58);
			this.lbl_Training.Name = "lbl_Training";
			this.lbl_Training.Size = new System.Drawing.Size(100, 21);
			this.lbl_Training.TabIndex = 149;
			this.lbl_Training.Text = "Program";
			this.lbl_Training.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(994, 0);
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
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(123, 106);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(874, 17);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 107);
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
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 0);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(8, 246);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(136, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(908, 395);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
			// 
			// pnl_Menu
			// 
			this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Menu.Controls.Add(this.btn_Insert);
			this.pnl_Menu.Location = new System.Drawing.Point(0, 531);
			this.pnl_Menu.Name = "pnl_Menu";
			this.pnl_Menu.Size = new System.Drawing.Size(1024, 43);
			this.pnl_Menu.TabIndex = 44;
			// 
			// btn_Insert
			// 
			this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Insert.ImageIndex = 9;
			this.btn_Insert.ImageList = this.image_List;
			this.btn_Insert.Location = new System.Drawing.Point(896, 8);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(80, 23);
			this.btn_Insert.TabIndex = 350;
			this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// statusBar1
			// 
			this.statusBar1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar1.Location = new System.Drawing.Point(0, 578);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.Size = new System.Drawing.Size(1024, 22);
			this.statusBar1.TabIndex = 43;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.mnu_Check,
																						 this.mnu_Cancel});
			// 
			// mnu_Check
			// 
			this.mnu_Check.Index = 0;
			this.mnu_Check.Text = "Check All";
			this.mnu_Check.Click += new System.EventHandler(this.mnu_Check_Click);
			// 
			// mnu_Cancel
			// 
			this.mnu_Cancel.Index = 1;
			this.mnu_Cancel.Text = "Cancel All";
			this.mnu_Cancel.Click += new System.EventHandler(this.mnu_Cancel_Click);
			// 
			// Form_Training_Attendance
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_Training_Attendance";
			this.Load += new System.EventHandler(this.Form_Training_Attendance_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.pnl_Menu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed, _Save_col;
		private string[] arr_essential ;
		private string _vfactory, _vt_code, _vt_name, _vseq;
		private int _colEMP_NO = 4, _vFrozen_col = 8;
       
//		private int _colFACTORY			= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxFACTORY;
//		private int _colT_CODE			= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxT_CODE;
//		private int _colSEQ				= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxSEQ;
//		private int _colTRAINED_DATE	= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxTRAINED_DATE;
//		private int _colPGM_DESC		= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxPGM_DESC;
//		private int _colSCHEDULE_YN		= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxSCHEDULE_YN;
//		private int _colREASON			= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxREASON;
//		private int _colREMARK			= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxREMARK;

		#endregion

		private void Form_Training_Attendance_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Training Attendance";
			this.Text		   = "Training";
			cmb_factory.Enabled = false;
			txt_T_Code.Enabled = false;
			txt_Training.Enabled = false;
			txt_Seq.Enabled = false;
			txt_Group.Enabled = false;
			txt_Wave.Enabled = false;
			mnu_Check.Enabled = true;
			mnu_Cancel.Enabled = true;

			
			DataTable vDt;
				
			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;
			
			txt_T_Code.Text = _vt_code;
			txt_Training.Text            = _vt_name;
			txt_Seq.Text                 = _vseq;
			if (txt_Seq.Text != null)
			{
				DataTable dt_ret =GET_GROUPWAVE();	
				if (dt_ret.Rows.Count>0)
				{
					txt_Group.Text=dt_ret.Rows[0].ItemArray[0].ToString();
					txt_Wave.Text=dt_ret.Rows[0].ItemArray[1].ToString();
				}
			}

			// =========Grid set=======================
			Set_Grid_SIM_ATTENDANCE("SIM_ATTENDANCE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			//fgrid_main.Cols[_colTRAINED_DATE].Style.Format   = "yyyy-MM-dd";
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

		}

		private  void Set_Grid_SIM_ATTENDANCE( string arg_pgid, string arg_pgseq, int arg_hcount, string arg_lang, COM.ComVar.Grid_Type arg_type, bool arg_autosize)
		{
			
			DataTable dt_list, dt_cmblist; 
			CellStyle cellst; 

			int cellst_count = 0;


			try
			{
				////// DB에서 그리드 정보 추출 
				dt_list = Select_GridHead_SIM_ATTENDANCE(arg_pgid,arg_pgseq);
				if (dt_list== null) return ;
	
				if(dt_list.Rows.Count > 0)
				{
					fgrid_main.Clear(C1.Win.C1FlexGrid.ClearFlags.All); 
					fgrid_main.Cols.Count = dt_list.Rows.Count + 1; 
					fgrid_main.Rows.Count = arg_hcount + 1;
					fgrid_main.Rows.Fixed = arg_hcount + 1;
					fgrid_main.Rows[0].Visible = false;
					fgrid_main.Cols[0].AllowEditing = false;

					#region  그리드 색

					fgrid_main.Styles.EmptyArea.BackColor = COM.ComVar.GridEmptyColor;
					fgrid_main.Styles.Alternate.BackColor = COM.ComVar.GridAlternate_Color;
					fgrid_main.Styles.Highlight.BackColor = COM.ComVar.GridHigh_Color;
					fgrid_main.Styles.Highlight.ForeColor = COM.ComVar.GridHighFore_Color;
					//this.Styles.Focus.BackColor = COM.ComVar.GridHigh_Color;
					//this.Styles.Focus.ForeColor = COM.ComVar.GridHighFore_Color;
					fgrid_main.Styles.Fixed.ForeColor = COM.ComVar.GridForeColor;

					switch(arg_type)
					{
						case COM.ComVar.Grid_Type.ForModify:
							fgrid_main.Styles.Fixed.BackColor = COM.ComVar.GridDarkFixed_Color;
							break;

						case COM.ComVar.Grid_Type.ForSearch:
							fgrid_main.Styles.Fixed.BackColor = COM.ComVar.GridLightFixed_Color;
							break;
					}


					fgrid_main.Cols[0].StyleNew.BackColor = COM.ComVar.GridCol0_Color;

 
					#endregion 
					#region 헤더 정렬

					fgrid_main.Rows[1].TextAlign = TextAlignEnum.CenterCenter;

					if (arg_hcount==2)		// 2번째 Header
					{
						fgrid_main.Rows[2].TextAlign = TextAlignEnum.CenterCenter;
					}

					if (arg_hcount==3)		// 3번째 Header
					{
						fgrid_main.Rows[2].TextAlign = TextAlignEnum.CenterCenter;
						fgrid_main.Rows[3].TextAlign = TextAlignEnum.CenterCenter;
					}

					if (arg_hcount==4)		// 4번째 Header
					{
						fgrid_main.Rows[2].TextAlign = TextAlignEnum.CenterCenter;
						fgrid_main.Rows[3].TextAlign = TextAlignEnum.CenterCenter;
						fgrid_main.Rows[4].TextAlign = TextAlignEnum.CenterCenter;
					}

					#endregion 
					#region 속성 지정

					//--------------------------------------------------
					//전체 속성 지정
					fgrid_main.Cols.Fixed = COM.ComVar.GridCol_Fixed ; 
					fgrid_main.Cols[0].Width = COM.ComVar.GridCol0_Width ;  
					//this.Cols[0].StyleNew.BackColor = ComVar.GridCol0_Color ;  

					fgrid_main.Cols.Frozen = Convert.ToInt32(dt_list.Rows[0].ItemArray[(int)ClassLib.TBSCM_TABLE.IxFROZENCOL].ToString());	// 칼럼 Frozen
					fgrid_main.Rows.Frozen = Convert.ToInt32(dt_list.Rows[0].ItemArray[(int)ClassLib.TBSCM_TABLE.IxFROZENROW].ToString());	// 행 Frozen
				
					//-------------------------------------------------
					//Column 속성 설정 
					//alingment cellstyle
					//1. left
					cellst = fgrid_main.Styles.Add("LEFT");
					cellst.TextAlign = TextAlignEnum.LeftCenter; 
					cellst.ImageAlign = ImageAlignEnum.LeftCenter; 

					//2. center
					cellst = fgrid_main.Styles.Add("CENTER");
					cellst.TextAlign = TextAlignEnum.CenterCenter; 
					cellst.ImageAlign = ImageAlignEnum.CenterCenter; 

					//3. rigth
					cellst = fgrid_main.Styles.Add("RIGHT");
					cellst.TextAlign = TextAlignEnum.RightCenter; 
					cellst.ImageAlign = ImageAlignEnum.RightCenter; 


					#endregion


					arr_essential = new string[dt_list.Rows.Count+1] ;
					
					for(int i = 1; i < dt_list.Rows.Count + 1; i++)
					{
						 
						
						arr_essential[i] = (dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxESSENTIAL_YN] == null) ? "" : dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxESSENTIAL_YN].ToString() ;
				

						#region 정렬

						switch(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxHALIGN].ToString())									// 칼럼정렬
						{
							case "LEFT":  
								fgrid_main.Cols[i].Style = fgrid_main.Styles["LEFT"]; 
								break;

							case "CENTER": 
								fgrid_main.Cols[i].Style = fgrid_main.Styles["CENTER"]; 
								break;

							case "RIGHT": 
								fgrid_main.Cols[i].Style = fgrid_main.Styles["RIGHT"]; 
								break; 
						} 
					  
						#endregion 


						fgrid_main.Cols[i].Width = Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxWIDTH].ToString());
						
						//this.Cols[i].AllowEditing = Convert.ToBoolean(dt_list.Rows[i - 1].ItemArray[(int)IxLOCK_YN]);    // 칼럼 에디터 가능 여부

						if(Convert.ToBoolean(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxLOCK_YN]) )
						{
							// 컬럼 글자색 파란색으로 처리


							//기존 컬럼 스타일 상속받아서 새로운 스타일 생성, 임의로 일련번호 추가
							cellst = fgrid_main.Styles.Add("EDIT" + cellst_count.ToString(), fgrid_main.Cols[i].Style);

							//새로운 스타일의 속성
							cellst.DataType = typeof(string);
							cellst.ForeColor = COM.ComVar.ClrImportant;

							fgrid_main.Cols[i].Style = fgrid_main.Styles["EDIT" + cellst_count.ToString()]; 
								 
 
							fgrid_main.Cols[i].AllowEditing = true; 
						}
						else
						{
							fgrid_main.Cols[i].AllowEditing = false;
							//cellst.BackColor = COM.ComVar.Clr_Text_Pink;
						}

						fgrid_main.Cols[i].Visible = Convert.ToBoolean(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxVISIBLE_YN]);			// 칼럼 visible 
						fgrid_main.Cols[i].AllowSorting = Convert.ToBoolean(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxAUTOSORT_YN]);	// 칼럼 별자동 sort

						//헤더 데이터
						fgrid_main[0, i] = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxCOL_NAME].ToString();					// 테이블 칼럼명
 

						
						#region cell type
 
						//스타일로 지정되어 정렬되어진 컬럼에 대해서
						//사용자 정의 스타일 동시에 적용시키려 할때
						//이전 스타일 제거되고 신규 스타일만 적용되므로
						//신규 스타일 추가시 이전 스타일 상속받아서 생성

						//신규 스타일로 적용했을때 신규 스타일 이름이 같은 경우
						//기존 정렬이 신규 스타일에 따라서 일괄적으로 변경되기 때문에
						//신규 스타일 생성시 임의로 일련번호 추가해서 생성

						switch(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxCELLTYPE].ToString())				// Cell Type
						{
							case "TEXT":
  
								//기존 컬럼 스타일 상속받아서 새로운 스타일 생성, 임의로 일련번호 추가
								cellst = fgrid_main.Styles.Add("TEXT" + cellst_count.ToString(), fgrid_main.Cols[i].Style);

								//새로운 스타일의 속성
								cellst.DataType = typeof(string);

								fgrid_main.Cols[i].Style = fgrid_main.Styles["TEXT" + cellst_count.ToString()]; 
								 
								break;

							case "DATE": 

								cellst = fgrid_main.Styles.Add("DATE" + cellst_count.ToString(), fgrid_main.Cols[i].Style);
								cellst.DataType = typeof(DateTime);
								cellst.Format = "yyyyMMdd";

								fgrid_main.Cols[i].Style = fgrid_main.Styles["DATE" + cellst_count.ToString()]; 
 
								break;

							case "CHECKBOX":
								
								cellst = fgrid_main.Styles.Add("CHECKBOX" + cellst_count.ToString(), fgrid_main.Cols[i].Style);
								cellst.DataType = typeof(bool); 

								fgrid_main.Cols[i].Style = fgrid_main.Styles["CHECKBOX" + cellst_count.ToString()]; 

								break;

							case "COMBOBOX":
								
								cellst = fgrid_main.Styles.Add("COMBO_" + cellst_count.ToString(), fgrid_main.Cols[i].Style);
								cellst.DataType = typeof(string);

								fgrid_main.Cols[i].Style = fgrid_main.Styles["COMBO_" + cellst_count.ToString()]; 
 
								
							switch(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxDATA_LIST_TYPE].ToString()))	// data_list_type
							{
								case (int)COM.ComVar.ComboList_Type.ComCode :      //공통코드에서 ComboList 추출
											
									if(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxDATA_LIST_CD].ToString() != "")					// Data_LIst_Cd
									{
										//combo_list
										dt_cmblist = MyOraDB.Select_ComCode(COM.ComVar.This_Factory, dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxDATA_LIST_CD].ToString());
										if(dt_cmblist.Rows.Count != 0) fgrid_main.Make_CmbDataList(COM.ComVar.ComboList_Type.ComCode, dt_cmblist, i);
									}

									break;

								case (int)COM.ComVar.ComboList_Type.Query :      //쿼리에서 ComboList 추출	
											
									if(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxDATA_LIST_QUERY].ToString() != "")				//Data_List_Query
									{
												 
										//dt_cmblist = COM.FSP.Make_Query(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxDATA_LIST_QUERY].ToString().Trim());
										//if(dt_cmblist.Rows.Count != 0) fgrid_main.Make_CmbDataList(COM.ComVar.ComboList_Type.Query, dt_cmblist, i);
									}

									break;

								case (int)COM.ComVar.ComboList_Type.ComCode_Name :
											
									if(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxDATA_LIST_CD].ToString() != "")					// Data_LIst_Cd
									{
												 
										dt_cmblist = MyOraDB.Select_ComCode(COM.ComVar.This_Factory, dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxDATA_LIST_CD].ToString());
										if(dt_cmblist.Rows.Count != 0) fgrid_main.Make_CmbDataList(COM.ComVar.ComboList_Type.ComCode_Name, dt_cmblist, i);
									}

									break;

							} 
 
								break;


							case "NUMBER":
								
								cellst = fgrid_main.Styles.Add("NUMBER" + cellst_count.ToString(), fgrid_main.Cols[i].Style);
								cellst.DataType = typeof(double);
								cellst.Format = "#,##0.##########"; 

								fgrid_main.Cols[i].Style = fgrid_main.Styles["NUMBER" + cellst_count.ToString()]; 

								break;

 
						} //end switch


						cellst_count++;
					  
						#endregion 
						#region 언어
 
						fgrid_main[1, i] = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxHEAD_DESC1].ToString();					// 상단

						if(arg_hcount == 2)	
						{
							fgrid_main[2, i] = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxHEAD_DESC2].ToString();				// 하단
						}

						if(arg_hcount == 3)	
						{
							fgrid_main[2, i] = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxHEAD_DESC2].ToString();	
							fgrid_main[3, i] = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxHEAD_DESC3].ToString();				// 하단
						}

						if(arg_hcount == 4)	
						{
							fgrid_main[2, i] = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxHEAD_DESC2].ToString();	
							fgrid_main[3, i] = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxHEAD_DESC3].ToString();
							fgrid_main[4, i] = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxHEAD_DESC4].ToString();				// 하단
						}
 
					
						#endregion 
						#region 타이틀 색깔 설정

						//등록된 Title Header에 backcolor,forecolor 설정
						if(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxBACKCOLOR].ToString() != "")							// 배경색
						{
							fgrid_main.GetCellRange(1, i).StyleNew.BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxBACKCOLOR].ToString()));

							if(arg_hcount == 2)
							{
								fgrid_main.GetCellRange(2, i).StyleNew.BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxBACKCOLOR].ToString()));
							}

							if(arg_hcount == 3)
							{
								fgrid_main.GetCellRange(2, i, 3, i).StyleNew.BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxBACKCOLOR].ToString()));
							}

							if(arg_hcount == 4)
							{
								fgrid_main.GetCellRange(2, i, 4, i).StyleNew.BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxBACKCOLOR].ToString()));
							}

						}

						if(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxFORECOLOR].ToString() != "")							// 글자색
						{
							fgrid_main.GetCellRange(1, i).StyleNew.ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxFORECOLOR].ToString()));

							if(arg_hcount == 2)
							{
								fgrid_main.GetCellRange(2, i).StyleNew.ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxFORECOLOR].ToString()));
							}

							if(arg_hcount == 3)
							{
								fgrid_main.GetCellRange(2, i, 3, i).StyleNew.ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxFORECOLOR].ToString()));
							}

							if(arg_hcount == 4)
							{
								fgrid_main.GetCellRange(2, i, 4, i).StyleNew.ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSCM_TABLE.IxFORECOLOR].ToString()));
							}

						 

						}


						#endregion


					} //end for


					if(arg_autosize)
					{
						fgrid_main.AutoSizeCols();
					} 
				
					fgrid_main.ExtendLastCol = true;		// 그리드 끝에 빈공간없이 last column에 맞춤 
					//this.ExtendLastCol = arg_autosize;

					fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
					fgrid_main.SelectionMode = SelectionModeEnum.ListBox;
					fgrid_main.Font = new Font("Verdana", 9);
 
					//-------------------------------------------------------
					// merge
					fgrid_main.AllowMerging = AllowMergingEnum.FixedOnly;

					for(int i = 0; i < fgrid_main.Cols.Count; i++)
					{
						fgrid_main.Cols[i].AllowMerging = true;
					}

					
					for(int i = 0; i < fgrid_main.Rows.Fixed; i++)
					{
						fgrid_main.Rows[i].AllowMerging = true;
					}  

					//-------------------------------------------------------


				}
				else 
				{	// 그리드 정보 없음을 상태 바에 출력

				}//end if

			
			}	
			catch (Exception ex)
			{
				MessageBox.Show( ex.Message.ToString(),"Set_Grid",MessageBoxButtons.OK,MessageBoxIcon.Error);
				
			}
		}	


		private DataTable Select_GridHead_SIM_ATTENDANCE(string arg_pgid, string arg_pgseq)
		{

			DataSet ds_ret;
			string Proc_Name = "PKG_SIM_ATTENDANCE.SELECT_COL_LIST";

			MyOraDB.ReDim_Parameter(6); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = Proc_Name ;
			

			MyOraDB.Parameter_Name[0] = "ARG_PG_ID";
			MyOraDB.Parameter_Name[1] = "ARG_PG_SEQ"; 
			MyOraDB.Parameter_Name[2] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[3] = "ARG_T_CODE"; 
			MyOraDB.Parameter_Name[4] = "ARG_SEQ"; 
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 
			
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_pgid;
			MyOraDB.Parameter_Values[1] = arg_pgseq;
			MyOraDB.Parameter_Values[2] = _vfactory;
			MyOraDB.Parameter_Values[3] = _vt_code;
			MyOraDB.Parameter_Values[4] = _vseq;
			MyOraDB.Parameter_Values[5] = "";


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return  ds_ret.Tables[Proc_Name];

		}

				
		private DataTable GET_GROUPWAVE()
		{
			string vProcedure = "PKG_SIM_TRAINEE.SELECT_TRAINING_GROUPWAVE";
			DataTable dt_ret = SELECT_GROUPWAVE_LIST(vProcedure);	
			return dt_ret;
		}
		
		private DataTable SELECT_GROUPWAVE_LIST(string arg_procedure)
		{ 
			DataSet vDt;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_SEQ";
			MyOraDB.Parameter_Name[ 3]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = _vfactory;
			MyOraDB.Parameter_Values[ 1]   = _vt_code ;
			MyOraDB.Parameter_Values[ 2]   = _vseq;
			MyOraDB.Parameter_Values[ 3]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private void Get_Trainee_To_Attendance()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_ATTENDANCE.SELECT_SIM_ATTENDANCE_1";

				DataTable vDt = SELECT_SIM_ATTENDANCE(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					//Display_FlexGrid(vDt);
					for (int iRow = 0 ; iRow < vDt.Rows.Count ; iRow++)
					{				
						C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, 1);

						fgrid_main[newRow.Row.Index, 0] = "I";

						for (int iCol = 1 ; iCol < vDt.Columns.Count ; iCol++)
							fgrid_main[newRow.Row.Index, iCol] = vDt.Rows[iRow].ItemArray[iCol-1];
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

				for (int iCol = 0; iCol < arg_dt.Columns.Count ; iCol++)
					fgrid_main[newRow.Row.Index, iCol+1] = arg_dt.Rows[iRow].ItemArray[iCol];
			}
		}

		private void Tbtn_SearchProcess()
		{
			//string v1, v2;
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_ATTENDANCE.SELECT_SIM_ATTENDANCE_1";

				DataTable vDt = SELECT_SIM_ATTENDANCE(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);
					//=============== SELECT ATTENDANCE 2 ===================
					string vProcedure1     = "PKG_SIM_ATTENDANCE.SELECT_SIM_ATTENDANCE_2";
					DataTable vDt1 = SELECT_SIM_ATTENDANCE(vProcedure1);

					if (vDt1.Rows.Count > 0)
					{
						int iCol = _vFrozen_col, i = 0  ;
						for (int iRow = 0 ; iRow < vDt1.Rows.Count ; iRow++)
						{				
							if (iCol < fgrid_main.Cols.Count-1)
							{
								if (fgrid_main.Cols[iCol].AllowEditing == false)
								{
									fgrid_main.GetCellRange(_Rowfixed + i, iCol, _Rowfixed + i, iCol).StyleNew.BackColor = COM.ComVar.ClrSubTotal0  ;
									fgrid_main.Cols[iCol].Style.DataType = typeof(string);
									fgrid_main[_Rowfixed + i, iCol] = "";
								}
								else
									fgrid_main[_Rowfixed + i, iCol] = vDt1.Rows[iRow].ItemArray[2].ToString();

								iCol = iCol + 1;
								if (iCol == fgrid_main.Cols.Count-1)
								{
									i = i + 1;
									iCol = _vFrozen_col;
								}

							}
						}
					}

					//=============== SELECT ATTENDANCE 2 ===================
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


		public DataTable SELECT_SIM_ATTENDANCE(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_SEQ";
			MyOraDB.Parameter_Name[ 3]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = _vfactory;
			MyOraDB.Parameter_Values[ 1]   = _vt_code;
			MyOraDB.Parameter_Values[ 2]   = _vseq;
			MyOraDB.Parameter_Values[ 3]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			int sel_col = fgrid_main.Selection.c1;

			if (sel_col >= _vFrozen_col)
			{
				fgrid_main.ContextMenu = contextMenu1;
//				mnu_Check.Enabled = true;
//				mnu_Cancel.Enabled = false;
				_Save_col = sel_col;
			}
			else
			{
				fgrid_main.ContextMenu = null;
				_Save_col = 0;
			}

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			//Get_Trainee_To_Attendance();
			this.btn_Apply_Process();
		}

		private void btn_Apply_Process()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (GET_TRAINEE_TO_ATTENDANCE(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();
					MessageBox.Show("Apply Completed","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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

		public bool GET_TRAINEE_TO_ATTENDANCE(bool doExecute)
		{
			try
			{
				int iCount  = 4;

				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIM_ATTENDANCE.GET_TRAINEE_TO_ATTENDANCE";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 1] = "ARG_T_CODE";
				MyOraDB.Parameter_Name[ 2] = "ARG_SEQ";
				MyOraDB.Parameter_Name[ 3] = "ARG_UPDATE_USER";

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				MyOraDB.Parameter_Values[ 0]   = _vfactory;
				MyOraDB.Parameter_Values[ 1]   = _vt_code;
				MyOraDB.Parameter_Values[ 2]   = _vseq;
				MyOraDB.Parameter_Values[ 3]   = COM.ComVar.This_User;

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

		private void mnu_Check_Click(object sender, System.EventArgs e)
		{
			Check_All();
		}

		private void mnu_Cancel_Click(object sender, System.EventArgs e)
		{
			Cancel_All();
		}

		private void Check_All()
		{
			int sel_col = fgrid_main.Selection.c1;
			for (int iRow = _Rowfixed; iRow < fgrid_main.Rows.Count; iRow++)
			{
				if (fgrid_main.Cols[sel_col].AllowEditing)
				{
					fgrid_main[iRow, sel_col] = "TRUE";
					fgrid_main[iRow, 0] = "U";
				}
			}
		}

		private void Cancel_All()
		{
			int sel_col = fgrid_main.Selection.c1;
			for (int iRow = _Rowfixed; iRow < fgrid_main.Rows.Count; iRow++)
			{
				if (fgrid_main.Cols[sel_col].AllowEditing)
				{
					fgrid_main[iRow, sel_col] = "FALSE";
					fgrid_main[iRow, 0] = "U";
				}
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (_Save_col != 0)
			{
				if (Validate_Check())
				{
					if(ClassLib.ComFunction.User_Message("Do you want to save the changes you made?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
					{
						this.Tbtn_SaveProcess();					
					}
				}	
			}
		}
		private bool Validate_Check()
		{
//			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
//			{
//				if ((fgrid_main[iRow, _colEMP_NO].ToString().Replace(" ", "").Trim().Length == 0) )
//				{
//					fgrid_main[iRow, 0] = "";					
//				}
//			}			

			return true;
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SIM_ATTENDANCE(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();
					MessageBox.Show("Save Completed","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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

		public bool SAVE_SIM_ATTENDANCE(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 8;

				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIM_ATTENDANCE.SAVE_SIM_ATTENDANCE";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_T_CODE";
				MyOraDB.Parameter_Name[ 3] = "ARG_SEQ";
				MyOraDB.Parameter_Name[ 4] = "ARG_EMP_NO";
				MyOraDB.Parameter_Name[ 5] = "ARG_TRAINED_DATE";
				MyOraDB.Parameter_Name[ 6] = "ARG_ATTENDANCE_YN";
				MyOraDB.Parameter_Name[ 7] = "ARG_UPDATE_USER";


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;

//				int save_col = 1;
//
//			    save_col = fgrid_main.Cols.Count - _vFrozen_col - 1 ;
				
				MyOraDB.Parameter_Values  = new string[iCount * save_ct];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if(fgrid_main[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct + 0 ] = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct + 1 ] = _vfactory ;
						MyOraDB.Parameter_Values[para_ct + 2 ] = _vt_code ;
						MyOraDB.Parameter_Values[para_ct + 3 ] = _vseq ;
						MyOraDB.Parameter_Values[para_ct + 4 ] = fgrid_main[iRow, _colEMP_NO].ToString();
						MyOraDB.Parameter_Values[para_ct + 5 ] = String.Concat(fgrid_main[1, _Save_col].ToString(), fgrid_main[2, _Save_col].ToString());
						MyOraDB.Parameter_Values[para_ct + 6 ] = (fgrid_main[iRow, _Save_col].ToString()== "True") ? "Y" : "N";
						MyOraDB.Parameter_Values[para_ct + 7 ] = COM.ComVar.This_User;

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
			this.Grid_AfterEditProcess();
		}

		private void Grid_AfterEditProcess()
		{
			int iCol = fgrid_main.Selection.c1;
			int iRow = fgrid_main.Selection.r1;
			
			//if ((iCol == _colWAVE)||(iCol == _colGRP_CODE)||(iCol == _colLOCATION_DIV)||(iCol == _colLANG_DIV)||(iCol == _colTRAINER_ID)||(iCol == _colREMARK))
			if (iCol >= _vFrozen_col)
			{
				fgrid_main.Update_Row(iRow);
			}
			
			//fgrid_main.Update_Row();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}

		private void Tbtn_PrintProcess()
		{
			try
			{
					PRINT_ATTENDANCE();
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

		private void PRINT_ATTENDANCE()
		{
			string sDir;
			
			sDir = FlexTraining.ClassLib.ComFunction.Set_RD_Directory("Form_Training_Attendance");

			string sPara;
			
//			sPara  = " /rp ";
//			sPara += "'" + _vfactory  +	"' ";
//			sPara += "'" + _vt_code  +	"' ";
//			sPara += "'" + _vseq  +	"' ";
//			sPara += "'" + " "  +	"' ";
//			sPara += "'" + " "  +	"' ";

			sPara  = " /rp ";
			sPara += "'" + _vfactory +	"' ";			            //Parm1: Factory
			sPara += "'" + _vt_code +	"' ";						//Parm2: Training Group
			sPara += "'" + " " +	"' ";							//Parm3: Objectives
			sPara += "'" + _vseq  +	"' ";							//Parm4: Wave
			sPara += "'" +  " " +	"' ";                           //Parm5: Start date
			sPara += "'" +  " "   +	"' ";							//Parm5: Start date

			FlexTraining.Report.Form_RdViewer MyReport = new FlexTraining.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Training Attendance List";
			MyReport.Show();
				
		}

		private void pnl_SearchImage_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
	}
}

