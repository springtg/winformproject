using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexMold.Management
{
	public class Form_PB_Mold_Status : COM.APSWinForm.Form_Top
	{
		public COM.FSP fgrid_Mold;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.Panel pnl_Search;
		private C1.Win.C1List.C1Combo cbo_Wh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_subject;
		private System.Windows.Forms.Label lbl_condition;
		private C1.Win.C1List.C1Combo cmb_Status;
		private System.Windows.Forms.Label btn_sct;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.Label lbl_status;
		private C1.Win.C1List.C1Combo cmb_mold_type;
		private System.Windows.Forms.Label lbl_mold_type;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_PopPgId;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.ComponentModel.IContainer components = null;

		private COM.OraDB oraDB = null;
		private int _IxGen_Value, _IxStart_Size, _IxTotal;
		private int _Ix_gen_s = 1;
		private int _Ix_gen_e = 6;
		private int _Ix_size_s = 11;
		private int _Ix_size_e = 0;
		private int col_width = 40;
		private int gen_width = 25;
		private MenuItem mitem = null;

		private int sct_start = 0;
		private int sct_stop  = 0;
		private string arg_sct_yn = "Y";
		private string sct_type = "";
		private System.Windows.Forms.TextBox txt_Mold;
		private string tem_YN = "";

		public Form_PB_Mold_Status()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Status));
			this.fgrid_Mold = new COM.FSP();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.cbo_Wh = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Mold = new System.Windows.Forms.TextBox();
			this.lbl_subject = new System.Windows.Forms.Label();
			this.lbl_condition = new System.Windows.Forms.Label();
			this.cmb_Status = new C1.Win.C1List.C1Combo();
			this.btn_sct = new System.Windows.Forms.Label();
			this.txt_status = new System.Windows.Forms.TextBox();
			this.lbl_status = new System.Windows.Forms.Label();
			this.cmb_mold_type = new C1.Win.C1List.C1Combo();
			this.lbl_mold_type = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.btn_PopPgId = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).BeginInit();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Status)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_mold_type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
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
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
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
			// fgrid_Mold
			// 
			this.fgrid_Mold.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_Mold.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_Mold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Mold.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Mold.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Mold.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_Mold.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Mold.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Mold.Location = new System.Drawing.Point(8, 152);
			this.fgrid_Mold.Name = "fgrid_Mold";
			this.fgrid_Mold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Mold.Size = new System.Drawing.Size(998, 488);
			this.fgrid_Mold.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Mold.TabIndex = 49;
			this.fgrid_Mold.Click += new System.EventHandler(this.fgrid_Mold_Click);
			// 
			// picb_TM
			// 
			this.picb_TM.Location = new System.Drawing.Point(0, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.TabIndex = 0;
			// 
			// picb_BR
			// 
			this.picb_BR.Location = new System.Drawing.Point(0, 0);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.TabIndex = 0;
			this.picb_BR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Location = new System.Drawing.Point(0, 0);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.TabIndex = 0;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Location = new System.Drawing.Point(0, 0);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.TabIndex = 0;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Location = new System.Drawing.Point(0, 0);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.TabIndex = 0;
			this.picb_ML.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.Location = new System.Drawing.Point(0, 0);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.TabIndex = 0;
			this.picb_MM.TabStop = false;
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.cbo_Wh);
			this.pnl_Search.Controls.Add(this.label1);
			this.pnl_Search.Controls.Add(this.txt_Mold);
			this.pnl_Search.Controls.Add(this.lbl_subject);
			this.pnl_Search.Controls.Add(this.lbl_condition);
			this.pnl_Search.Controls.Add(this.cmb_Status);
			this.pnl_Search.Controls.Add(this.btn_sct);
			this.pnl_Search.Controls.Add(this.txt_status);
			this.pnl_Search.Controls.Add(this.lbl_status);
			this.pnl_Search.Controls.Add(this.cmb_mold_type);
			this.pnl_Search.Controls.Add(this.lbl_mold_type);
			this.pnl_Search.Controls.Add(this.cmb_Factory);
			this.pnl_Search.Controls.Add(this.lbl_Factory);
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.Bottom = 5;
			this.pnl_Search.DockPadding.Left = 10;
			this.pnl_Search.DockPadding.Right = 10;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 88);
			this.pnl_Search.TabIndex = 50;
			// 
			// cbo_Wh
			// 
			this.cbo_Wh.AddItemCols = 0;
			this.cbo_Wh.AddItemSeparator = ';';
			this.cbo_Wh.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_Wh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cbo_Wh.Caption = "";
			this.cbo_Wh.CaptionHeight = 17;
			this.cbo_Wh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_Wh.ColumnCaptionHeight = 18;
			this.cbo_Wh.ColumnFooterHeight = 18;
			this.cbo_Wh.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_Wh.ContentHeight = 17;
			this.cbo_Wh.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_Wh.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_Wh.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Wh.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_Wh.EditorHeight = 17;
			this.cbo_Wh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Wh.GapHeight = 2;
			this.cbo_Wh.ItemHeight = 15;
			this.cbo_Wh.Location = new System.Drawing.Point(119, 58);
			this.cbo_Wh.MatchEntryTimeout = ((long)(2000));
			this.cbo_Wh.MaxDropDownItems = ((short)(5));
			this.cbo_Wh.MaxLength = 32767;
			this.cbo_Wh.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_Wh.Name = "cbo_Wh";
			this.cbo_Wh.PartialRightColumn = false;
			this.cbo_Wh.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_Wh.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_Wh.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_Wh.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_Wh.Size = new System.Drawing.Size(150, 21);
			this.cbo_Wh.TabIndex = 108;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(568, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 107;
			this.label1.Text = "Mold Code";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Mold
			// 
			this.txt_Mold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mold.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Mold.Location = new System.Drawing.Point(669, 58);
			this.txt_Mold.Name = "txt_Mold";
			this.txt_Mold.Size = new System.Drawing.Size(150, 22);
			this.txt_Mold.TabIndex = 106;
			this.txt_Mold.Text = "";
			// 
			// lbl_subject
			// 
			this.lbl_subject.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_subject.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_subject.ImageIndex = 0;
			this.lbl_subject.ImageList = this.img_Label;
			this.lbl_subject.Location = new System.Drawing.Point(17, 58);
			this.lbl_subject.Name = "lbl_subject";
			this.lbl_subject.Size = new System.Drawing.Size(100, 21);
			this.lbl_subject.TabIndex = 105;
			this.lbl_subject.Text = "WareHouse";
			this.lbl_subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_condition
			// 
			this.lbl_condition.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_condition.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_condition.ImageIndex = 0;
			this.lbl_condition.ImageList = this.img_Label;
			this.lbl_condition.Location = new System.Drawing.Point(296, 58);
			this.lbl_condition.Name = "lbl_condition";
			this.lbl_condition.Size = new System.Drawing.Size(100, 21);
			this.lbl_condition.TabIndex = 104;
			this.lbl_condition.Text = "Mold Status";
			this.lbl_condition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Status
			// 
			this.cmb_Status.AddItemCols = 0;
			this.cmb_Status.AddItemSeparator = ';';
			this.cmb_Status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Status.Caption = "";
			this.cmb_Status.CaptionHeight = 17;
			this.cmb_Status.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Status.ColumnCaptionHeight = 18;
			this.cmb_Status.ColumnFooterHeight = 18;
			this.cmb_Status.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Status.ContentHeight = 17;
			this.cmb_Status.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Status.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Status.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Status.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Status.EditorHeight = 17;
			this.cmb_Status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Status.GapHeight = 2;
			this.cmb_Status.ItemHeight = 15;
			this.cmb_Status.Location = new System.Drawing.Point(397, 58);
			this.cmb_Status.MatchEntryTimeout = ((long)(2000));
			this.cmb_Status.MaxDropDownItems = ((short)(5));
			this.cmb_Status.MaxLength = 32767;
			this.cmb_Status.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Status.Name = "cmb_Status";
			this.cmb_Status.PartialRightColumn = false;
			this.cmb_Status.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Status.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Status.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Status.Size = new System.Drawing.Size(150, 21);
			this.cmb_Status.TabIndex = 103;
			// 
			// btn_sct
			// 
			this.btn_sct.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_sct.Location = new System.Drawing.Point(860, 36);
			this.btn_sct.Name = "btn_sct";
			this.btn_sct.Size = new System.Drawing.Size(21, 21);
			this.btn_sct.TabIndex = 102;
			this.btn_sct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_sct.Visible = false;
			// 
			// txt_status
			// 
			this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_status.Location = new System.Drawing.Point(669, 35);
			this.txt_status.Name = "txt_status";
			this.txt_status.Size = new System.Drawing.Size(190, 22);
			this.txt_status.TabIndex = 40;
			this.txt_status.Text = "GOOD";
			// 
			// lbl_status
			// 
			this.lbl_status.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_status.ImageIndex = 0;
			this.lbl_status.ImageList = this.img_Label;
			this.lbl_status.Location = new System.Drawing.Point(568, 36);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(100, 21);
			this.lbl_status.TabIndex = 39;
			this.lbl_status.Text = "Tooling Status";
			this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_mold_type
			// 
			this.cmb_mold_type.AddItemCols = 0;
			this.cmb_mold_type.AddItemSeparator = ';';
			this.cmb_mold_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_mold_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_mold_type.Caption = "";
			this.cmb_mold_type.CaptionHeight = 17;
			this.cmb_mold_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_mold_type.ColumnCaptionHeight = 18;
			this.cmb_mold_type.ColumnFooterHeight = 18;
			this.cmb_mold_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_mold_type.ContentHeight = 17;
			this.cmb_mold_type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_mold_type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_mold_type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_mold_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_mold_type.EditorHeight = 17;
			this.cmb_mold_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_mold_type.GapHeight = 2;
			this.cmb_mold_type.ItemHeight = 15;
			this.cmb_mold_type.Location = new System.Drawing.Point(397, 36);
			this.cmb_mold_type.MatchEntryTimeout = ((long)(2000));
			this.cmb_mold_type.MaxDropDownItems = ((short)(5));
			this.cmb_mold_type.MaxLength = 32767;
			this.cmb_mold_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_mold_type.Name = "cmb_mold_type";
			this.cmb_mold_type.PartialRightColumn = false;
			this.cmb_mold_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_mold_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_mold_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_mold_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_mold_type.Size = new System.Drawing.Size(150, 21);
			this.cmb_mold_type.TabIndex = 38;
			// 
			// lbl_mold_type
			// 
			this.lbl_mold_type.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_mold_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_mold_type.ImageIndex = 0;
			this.lbl_mold_type.ImageList = this.img_Label;
			this.lbl_mold_type.Location = new System.Drawing.Point(296, 36);
			this.lbl_mold_type.Name = "lbl_mold_type";
			this.lbl_mold_type.Size = new System.Drawing.Size(100, 21);
			this.lbl_mold_type.TabIndex = 37;
			this.lbl_mold_type.Text = "Mold Type";
			this.lbl_mold_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.Enabled = false;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(119, 36);
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(150, 21);
			this.cmb_Factory.TabIndex = 36;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(18, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 35;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.btn_PopPgId);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.pictureBox1);
			this.pnl_SearchImage.Controls.Add(this.label2);
			this.pnl_SearchImage.Controls.Add(this.pictureBox2);
			this.pnl_SearchImage.Controls.Add(this.pictureBox3);
			this.pnl_SearchImage.Controls.Add(this.pictureBox4);
			this.pnl_SearchImage.Controls.Add(this.pictureBox5);
			this.pnl_SearchImage.Controls.Add(this.pictureBox6);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(10, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(996, 83);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// btn_PopPgId
			// 
			this.btn_PopPgId.Location = new System.Drawing.Point(412, 36);
			this.btn_PopPgId.Name = "btn_PopPgId";
			this.btn_PopPgId.Size = new System.Drawing.Size(21, 21);
			this.btn_PopPgId.TabIndex = 34;
			this.btn_PopPgId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(981, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 40);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(980, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(16, 32);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(224, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(772, 32);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 28;
			this.label2.Text = "      Search Mold Conditions";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(980, 67);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 16);
			this.pictureBox2.TabIndex = 23;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(144, 65);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(836, 24);
			this.pictureBox3.TabIndex = 24;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 63);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(168, 20);
			this.pictureBox4.TabIndex = 22;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(0, 24);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(168, 40);
			this.pictureBox5.TabIndex = 25;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(160, 24);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(828, 48);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
			// 
			// Form_PB_Mold_Status
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Search);
			this.Controls.Add(this.fgrid_Mold);
			this.Name = "Form_PB_Mold_Status";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Status_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.fgrid_Mold, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_Wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Status)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_mold_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Status_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		private void Init_Form()
		{
			this.Text = "Mold Information";
			this.lbl_MainTitle.Text = "Mold Information";
			ClassLib.ComFunction.SetLangDic(this);

			#region 버튼 권한
			
			#endregion

			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Save.Enabled = false;
			
			oraDB = new COM.OraDB();

			//Factroy ComboBox Setting
			DataTable dt_list = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1,false,COM.ComVar.ComboList_Visible.Code);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory; 

			//Mold Type ComboBox Setting 
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),ClassLib.ComVar.CxMoldType);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_mold_type, 1,2 ,true);
			cmb_mold_type.SelectedIndex = 0;

//			dt_list = Select_com_filter_code_List1("SDV15",ClassLib.ComVar.This_Dept);
			dt_list = Select_com_filter_code_List("SDV15");
			ClassLib.ComCtl.Set_ComboList(dt_list, cbo_Wh, 0, 1, false, false);

			dt_list = Select_com_filter_code_List("SDV35");
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Status, 0, 1, false, false);

//			Show_Mold_Status();	 // LAY RA DUOC CHU GOOD

			//스타일 그리드
			fgrid_Mold.Set_Grid("SPB_MOLD1", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Mold.Set_Action_Image(img_Action);
			Set_Gender_Grid(fgrid_Mold);
			fgrid_Mold.Cols.Frozen = (int)ClassLib.TBSPB_MOLD.IxGR_GEN+1;
			fgrid_Mold.Font = new Font("Verdana", 7);

//			fgrid_Multi.Set_Grid("SPB_MOLD", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
//			fgrid_Multi.Set_Action_Image(img_Action);
//			Set_Gender_Grid(fgrid_Multi);
//			fgrid_Multi.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
//			fgrid_Multi.Cols.Frozen = (int)ClassLib.TBSPB_MOLD.IxGR_GEN;
//			fgrid_Multi.Font = new Font("Verdana", 7);

			//Mold Type ComboBox Setting 
//			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),ClassLib.ComVar.CxMoldCondition);
//			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_condition, 1,2 ,false);
//			cmb_condition.SelectedIndex = 0;

			//mold inventory 가져오기
			btn_Run_Click(null, null);		
			
		}
		private void btn_Run_Click(object sender, System.EventArgs e)
		{

			this.Cursor = Cursors.WaitCursor;
			if(Run_Proc(ClassLib.ComVar.This_Factory))
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
			}
			else
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
			}
			this.Cursor = Cursors.Default;


			fgrid_Mold.Rows.Count = _Ix_gen_e;
//			fgrid_Multi.Rows.Count = _Ix_gen_e;

		}
		private DataTable Select_com_filter_code_List(string com_cd)
		{
			string Proc_Name = "pkg_scm_code.select_com_filter_code_list";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_COM_CD";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = "VJ";
			oraDB.Parameter_Values[1] = com_cd;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}
		private void Set_Gender_Grid(C1FlexGrid arg_fgrid)
		{
			
			DataTable dt_list;
			DataTable dt_size_list;

			string[] new_data = new string[arg_fgrid.Cols.Count]; 
			
			int size_count = 0;

			
			// LAY DUOC GENDER (MEN , WOMEN..)
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxGen);  

			
			//------------------------------------------------
			new_data[0] = ""; 

			for(int i = 1; i < arg_fgrid.Cols.Count; i++)
			{
				new_data[i] = arg_fgrid[1, i].ToString();
			}

			//------------------------------------------------
			for(int i = 0; i < dt_list.Rows.Count - 1; i++)
			{ 
				arg_fgrid.AddItem(new_data, arg_fgrid.Rows.Count, 0);  
			}


			arg_fgrid.Rows.Fixed = dt_list.Rows.Count + 1;

			arg_fgrid.AutoSizeCols();

 			

			//------------------------------------------------
			//젠더 입력

			_IxGen_Value = (int)ClassLib.TBSPB_MOLD.IxGR_GEN;

			arg_fgrid.Cols.Insert(_IxGen_Value);

			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
				arg_fgrid[i + 1, _IxGen_Value] = dt_list.Rows[i].ItemArray[3].ToString();

				//------------------------------------------------------------------

				if(arg_fgrid.Name == "fgrid_Multi")
				{
					if(arg_fgrid[i + 1, _IxGen_Value].ToString() == "ME" )continue;
					//|| arg_fgrid[i + 1, _IxGen_Value].ToString() == "WO") continue;

					arg_fgrid.Rows[i + 1].Visible = false;
				}
 
				//------------------------------------------------------------------
			}


			//------------------------------------------------
			//사이즈 문대 표시
			
			_IxStart_Size = _IxGen_Value + 1;

			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
				dt_size_list = Select_Gen_Size(dt_list.Rows[i].ItemArray[3].ToString());

				size_count = dt_size_list.Rows.Count + _IxStart_Size;

				if(size_count > arg_fgrid.Cols.Count)
				{
					arg_fgrid.Cols.Count = size_count;
				}
 
				for(int j = 0; j < dt_size_list.Rows.Count; j++)
				{
					arg_fgrid[i + 1, _IxStart_Size + j] = dt_size_list.Rows[j].ItemArray[0];
				}
			}

			//------------------------------------------------
			//total 표시
			_IxTotal = arg_fgrid.Cols.Count;

			arg_fgrid.Cols.Add();

			for(int i = 0; i < arg_fgrid.Rows.Count; i++)
			{
				arg_fgrid[i, _IxTotal] = "Total"; 
				arg_fgrid.Rows[i].TextAlign = TextAlignEnum.CenterCenter; 
			}

			arg_fgrid.Cols[_IxTotal].Visible = false;

			//------------------------------------------------
		 
			for(int i = _IxGen_Value; i < arg_fgrid.Cols.Count; i++)
			{
				arg_fgrid.Cols[i].Width = col_width; 
				
				if(i == _IxGen_Value)
				{
					arg_fgrid.Cols[i].Width = gen_width; 
				} 

				for(int j = 1; j < arg_fgrid.Rows.Fixed; j++)
				{
					if(arg_fgrid[j, i] == null) arg_fgrid[j, i] = "x";
				}
			}
 
			 
 
			arg_fgrid.AllowMerging = AllowMergingEnum.FixedOnly;

			for(int i = 1; i <= _IxGen_Value; i++)
			{
				arg_fgrid.Cols[i].AllowMerging = true;
			}

			arg_fgrid.Cols[_IxTotal].AllowMerging = true;


			if(arg_fgrid.Name == "fgrid_Multi")
			{
				for(int l=0; l<=(int)ClassLib.TBSPB_MOLD.IxGR_GEN; l++)
				{
					arg_fgrid.Cols[l].Visible = false;
				}


				#region 그리드 헤드 변경

				for(int i=_Ix_gen_s; i<_Ix_gen_e; i++)
				{
					arg_fgrid[i, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD] = "MOLD SIZE";
				}

				#endregion

				
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].Visible = true;
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].Width = 80;
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN].Visible =true;
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN].Visible =true;
			}
			else
			{
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_TYPE].Width = 95;
				arg_fgrid.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_HALF].Width = 30;
			}
		}
		private bool Run_Proc(string arg_factory)
		{

			string Proc_Name = "SP_SPB_MOLD";

			oraDB.ReDim_Parameter(1);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "AEG_FACTORY";
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Values[0] = arg_factory;

			oraDB.Add_Run_Parameter(true);

			if(oraDB.Exe_Run_Procedure() == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		private DataTable Select_Gen_Size(string arg_gen)
		{
			string Proc_Name = "PKG_SPO_ORDER_BSC.SELECT_GEN_SIZE";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_GEN";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_gen;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Mold.Select(fgrid_Mold.Selection.r1, 0, fgrid_Mold.Selection.r1, fgrid_Mold.Cols.Count-1, false);
			
			Set_Grid_Data();

			//임시 로우
			fgrid_Mold.Rows.Add();
			fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION] = "Y";
			fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_MOLD.IxGR_FACTORY] = cmb_Factory.SelectedValue.ToString();
			fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD] = "";
			fgrid_Mold.Rows[fgrid_Mold.Rows.Count-1].Height = 0;

			Sum_Qty();

			if(fgrid_Mold.Rows.Count > _Ix_gen_e)
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			else
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
			}
		}

		private void Set_Grid_Data()
		{
			this.Cursor = Cursors.WaitCursor;
			fgrid_Mold.Rows.Count = _Ix_gen_e;
			
			string arg_division = "ALL";

			if( cmb_mold_type.SelectedIndex > 0 )
				arg_division = "SCT";			  

			string arg_factory = cmb_Factory.SelectedValue.ToString();
			string arg_mold_type = cmb_mold_type.SelectedValue.ToString();

			DataTable dt = Select_SPB_Mold(arg_division);

			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;

			string rowcheck = "";
			string newrow = "";						

			for(int i=0; i<rowcount; i++)
			{
				newrow = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_FACTORY].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_CD].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_STATUS].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_TYPE].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_HALF].ToString();

				if(rowcheck != newrow)
				{
					int fgrid_row = fgrid_Mold.Rows.Count;
					
					fgrid_Mold.Rows.Add();
					
					//Factory
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_FACTORY] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_FACTORY].ToString();
					
					//MOLD_CD
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_CD].ToString();

					//SPEC_CD
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_SPEC_CD] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SPEC_CD].ToString();

					//HALF
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_HALF] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_HALF].ToString();

					//MOLD_STATUS

					string mold_type = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_STATUS].ToString();
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS] 
						= mold_type;

					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SYSTEM_YN].ToString();

					//MOLD_TYPE
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_STATUS_CD] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MTYPE].ToString();

					//MOLD_TYPE
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_MOLD_TYPE] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MOLD_TYPE].ToString();

					//MSIZE_YN
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MSIZE_YN].ToString();

					//MUSE_YN
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_MUSE_YN].ToString();

					//SUM_QTY
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_SUM_QTY] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SUM_QTY].ToString();

					//GEN
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_GEN] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_GEN].ToString();

					//HALF_DIV code
					fgrid_Mold[fgrid_row, fgrid_Mold.Cols.Count-1] 
						=  dt.Rows[i].ItemArray[10].ToString();

					string arg_gen = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_GEN].ToString();
					string arg_cs_size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_CS_SIZE].ToString();
					string arg_qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SUM_QTY].ToString();

					Set_Mold_Size(arg_gen, arg_cs_size, fgrid_row, arg_qty);

					rowcheck = newrow;
				}
				else
				{
					int fgrid_row = fgrid_Mold.Rows.Count-1;

					int sum_qty = 0;
					
					try
					{
						sum_qty = int.Parse(fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_SUM_QTY].ToString());
					}
					catch
					{
						sum_qty = 0;
					}
					
					string aa = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SUM_QTY].ToString();

					try
					{
						sum_qty = sum_qty + int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SUM_QTY].ToString());	
					}
					catch{}
					
					fgrid_Mold[fgrid_row, (int)ClassLib.TBSPB_MOLD.IxGR_SUM_QTY] = sum_qty.ToString();

					string arg_gen = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_GEN].ToString();
					string arg_cs_size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_CS_SIZE].ToString();
					string arg_qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD.IxDB_SUM_QTY].ToString();


					Set_Mold_Size(arg_gen, arg_cs_size, fgrid_row, arg_qty);
				}

				for(int j=_Ix_gen_e; j<fgrid_Mold.Rows.Count;j++)
				{
					if(fgrid_Mold[j,(int)ClassLib.TBSPB_MOLD.IxGR_MSIZE_YN].ToString() == "Y" || fgrid_Mold[j,(int)ClassLib.TBSPB_MOLD.IxGR_MUSE_YN].ToString() == "Y")
					{
						fgrid_Mold.Rows[j].AllowEditing = false;
					}
				}
			}

			this.Cursor = Cursors.Default;

		}
		private DataTable Select_SPB_Mold(string arg_division)
		{			
			string Proc_Name = "PKG_SDT_MOLD.SELECT_SPB_MOLD_STATUS";

			oraDB.ReDim_Parameter(7);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_DIVISION";
			oraDB.Parameter_Name[2] = "ARG_MOLD_TYPE";
			oraDB.Parameter_Name[3] = "ARG_STATUS";
			oraDB.Parameter_Name[4] = "ARG_SUBJECT";
			oraDB.Parameter_Name[5] = "ARG_WH";
			oraDB.Parameter_Name[6] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = arg_division;
			oraDB.Parameter_Values[2] = cmb_mold_type.SelectedValue.ToString();
			if (cmb_Status.Text == "")
				oraDB.Parameter_Values[3] = "";		
			else
				oraDB.Parameter_Values[3] = cmb_Status.SelectedValue.ToString();		

			string subject = txt_Mold.Text.Trim();

			if(subject.Length == 0)
			{
				subject = "ALL";
			}

			oraDB.Parameter_Values[4] = subject;
			oraDB.Parameter_Values[5] = cbo_Wh.SelectedValue.ToString();
			oraDB.Parameter_Values[6] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}
		private void Sum_Qty()
		{
			Cursor = Cursors.WaitCursor;

			string new_check = "";
			string old_check = "";


			int check=0;

			string insert_row = "";

			for(int i=_Ix_gen_e; i<fgrid_Mold.Rows.Count; i++)
			{
				new_check = fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_FACTORY].ToString() + fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].ToString(); 
				
				if(old_check != new_check)
				{
					check++;

					if(check > 1)
					{
						insert_row = insert_row + i.ToString() + "/";
					}

					old_check = new_check;
					check = 0;

				}
				else
				{
					check++;
				}
			}

			string div = "/";
			string[] insert_rows = insert_row.Split(div.ToCharArray());
			int row = 0;

			for(int i = 0; i<insert_rows.Length; i++)
			{
				if(insert_rows[i] != "")
				{
					int new_row = int.Parse(insert_rows[i].Trim()) + row;
					string[] ArrayItem = new string[11];
					ArrayItem[0] = "S";
					ArrayItem[1] = fgrid_Mold[new_row-1,(int)ClassLib.TBSPB_MOLD.IxGR_FACTORY].ToString();
					ArrayItem[2] = fgrid_Mold[new_row-1,(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].ToString();
					ArrayItem[3] = "Status Sum";
					ArrayItem[4] = "";
					ArrayItem[5] = "";
					ArrayItem[6] = "";
					ArrayItem[7] = "";
					ArrayItem[8] = "";
					ArrayItem[9] = Mold_Type_Sum_Qty(ArrayItem[1]+ArrayItem[2], new_row, 9);
//					ArrayItem[9] = Mold_Type_Sum_Qty(ArrayItem[1]+ArrayItem[2], new_row, 10);
					ArrayItem[10] = fgrid_Mold[new_row-1,(int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString();

					fgrid_Mold.AddItem(ArrayItem, new_row, 0);
					fgrid_Mold.Rows[new_row].StyleNew.BackColor = Color.FromArgb(251, 248, 185);
					
					fgrid_Mold[new_row, 10]= ArrayItem[9];
					fgrid_Mold[new_row, 11]= ArrayItem[10];
					
//					for(int k=_Ix_size_s; k<_Ix_size_e; k++)
//					{
//						if(Mold_Type_Sum_Qty(ArrayItem[1]+ArrayItem[2], new_row, k) != "0")
//						{
//							fgrid_Mold[new_row, k] = Mold_Type_Sum_Qty(ArrayItem[1]+ArrayItem[2], new_row, k);
//						}
//					}
					row++;
				}
			}

			Cursor = Cursors.Default;

			for(int i=_Ix_gen_e; i<fgrid_Mold.Rows.Count; i++)
			{
				if(fgrid_Mold[i,0].ToString() != "N")
				{
					fgrid_Mold.Rows[i].AllowEditing = false;
				}
			}
		}
		private string Mold_Type_Sum_Qty(string arg_code, int arg_row, int arg_col)
		{
			int i = 1;
			string old_code = "";

			int sum_qty = 0;
			while(true)
			{
				old_code = fgrid_Mold[arg_row - i,(int)ClassLib.TBSPB_MOLD.IxGR_FACTORY].ToString() + fgrid_Mold[arg_row - i,(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_CD].ToString();
				
				if(old_code == arg_code)
				{
					fgrid_Mold.Rows[arg_row - i].StyleNew.BackColor = Color.FromArgb(217, 250, 216);
					try
					{
						sum_qty = sum_qty + int.Parse(fgrid_Mold[arg_row - i,arg_col+1].ToString());
					}
					catch
					{
					}

					i++;
				}
				else
				{
					break;
				}
			}

			return sum_qty.ToString();
		}
		private void Set_Mold_Size(string arg_gen, string arg_cs_size, int arg_row, string arg_qty)
		{
			_Ix_size_e = fgrid_Mold.Cols.Count-1;

			int i;

			for(i=_Ix_gen_s; i<_Ix_gen_e; i++)
			{
				if(fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString() == arg_gen)
				{
					break;
				}
			}

			for(int j=_Ix_size_s; j<_Ix_size_e; j++)
			{
				if( fgrid_Mold[i,j].ToString() == arg_cs_size )
				{
					fgrid_Mold[arg_row, j] = arg_qty;
				}
				else
				{
					if(fgrid_Mold[arg_row, j] == null || fgrid_Mold[arg_row, j].ToString() == "")
					{
						fgrid_Mold[arg_row, j] = "";
					}
				}
			}
		}

		private void fgrid_Mold_Click(object sender, System.EventArgs e)
		{
			if(fgrid_Mold.Rows.Count < _Ix_gen_e) return;

			int sct_row = fgrid_Mold.Selection.r1;
			int sct_col = fgrid_Mold.Selection.r1;


			if(fgrid_Mold[sct_row, 0].ToString() == "N")
				fgrid_Mold.Rows[sct_row].AllowEditing = true;

			int row_num = 0;

			try
			{

				string sct_gen = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString();

				int i;
				for(i=_Ix_gen_s; i<_Ix_gen_e; i++)
				{
					fgrid_Mold.GetCellRange(i,_Ix_size_s,i,_Ix_size_e).StyleNew.BackColor = COM.ComVar.GridLightFixed_Color;
					fgrid_Mold.GetCellRange(i,_Ix_size_s,i,_Ix_size_e).StyleNew.ForeColor = Color.White;

					if(fgrid_Mold[i, (int)ClassLib.TBSPB_MOLD.IxGR_GEN].ToString() == sct_gen)
					{
						row_num = i;
					}
				}

				fgrid_Mold.GetCellRange(row_num,_Ix_size_s,row_num,_Ix_size_e).StyleNew.BackColor = Color.FromArgb(251, 248, 185);//COM.ComVar.GridDarkFixed_Color;
				fgrid_Mold.GetCellRange(row_num,_Ix_size_s,row_num,_Ix_size_e).StyleNew.ForeColor = Color.Black;

				if(fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD.IxGR_DIVISION].ToString() == "I")
					fgrid_Mold.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS].AllowEditing = true; 
				else
					fgrid_Mold.Cols[(int)ClassLib.TBSPB_MOLD.IxGR_MOLD_STATUS].AllowEditing = false; 

//				fgrid_Mold_DoubleClick(null, null);
			}
			catch
			{
			}
		}
		private DataTable Select_com_filter_code_List1(string com_cd,string dept_cd)
		{
			string Proc_Name = "PKG_SDT_MOLD_WH.select_com_filter_code_list";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_COM_CD";
			oraDB.Parameter_Name[2] = "ARG_DEPT_CD";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = "VJ";
			oraDB.Parameter_Values[1] = com_cd;
			oraDB.Parameter_Values[2] = dept_cd;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(fgrid_Mold.Rows.Count < _Ix_gen_e+1) return;


			fgrid_Mold.Rows.Remove(fgrid_Mold.Rows.Count-1);

			string filename = this.Name + ".txt";
			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;

            //fgrid_Mold.SaveGrid(filename, FileFormatEnum.TextComma, false);
            fgrid_Mold.SaveGrid(filename, FileFormatEnum.TextComma);

//			string mold_type = cmb_mold_type.Columns[1].Text;
			string mold_type = cmb_Status.Text ;
			string mold_status = txt_status.Text;
			string WH_CD  = cbo_Wh.Text;
			//Form_Report_Mold report = new Form_Report_Mold(filename, mold_type, mold_status);
			//report.ShowDialog();

			string para = "/rfn [" + Application.StartupPath + @"\" + this.Name + ".txt] /rv V_MTYPE[" +mold_type + "] V_MSTATUS[" + mold_status + "] V_WH[" + WH_CD + "]";
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("MOLD INVENTORY", this.Name +".mrd", para);
			report.ShowDialog();
		}


	}
}

