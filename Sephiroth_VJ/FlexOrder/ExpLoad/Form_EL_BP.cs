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



namespace FlexOrder.ExpLoad
{
	public class Form_EL_BP : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.TextBox txt_Path;
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
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label btn_path;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		public System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.TextBox txt_sheet;
		private System.Windows.Forms.Label lbl_sheet;
		private System.Windows.Forms.ImageList image_Tag;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Label lbl_DOWN_YMD;
		private System.Windows.Forms.DateTimePicker dpick_down_ymd;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel pnl_progress;
		private System.Windows.Forms.Label lbl_m;
		private System.Windows.Forms.Label lbl_u;
		private System.Windows.Forms.Label lbl_s;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_3;
		private System.Windows.Forms.Label lbl_2;
		private System.Windows.Forms.Label lbl_1;
		private System.Windows.Forms.TextBox txt_MaxPo;
		private System.Windows.Forms.TextBox txt_MinPo;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem ctm_BP_Sel;
		private System.Windows.Forms.MenuItem cmt_BP_HistSel;
		private System.Windows.Forms.MenuItem cmt_CSOBS_CRT;
		private System.Windows.Forms.MenuItem ctm_CSOBS_Req;
		private System.Windows.Forms.MenuItem ctm_Bar_First;
		private C1.Win.C1List.C1Combo cmb_Del;
		private System.Windows.Forms.Label lbl_Del_Month;
		private System.ComponentModel.IContainer components = null;

		public Form_EL_BP()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
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

		#endregion

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EL_BP));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.cmb_Del = new C1.Win.C1List.C1Combo();
			this.lbl_Del_Month = new System.Windows.Forms.Label();
			this.dpick_down_ymd = new System.Windows.Forms.DateTimePicker();
			this.lbl_DOWN_YMD = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txt_sheet = new System.Windows.Forms.TextBox();
			this.lbl_sheet = new System.Windows.Forms.Label();
			this.btn_path = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.txt_Path = new System.Windows.Forms.TextBox();
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
			this.lbl_STYLE = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.pnl_progress = new System.Windows.Forms.Panel();
			this.lbl_m = new System.Windows.Forms.Label();
			this.lbl_u = new System.Windows.Forms.Label();
			this.lbl_s = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_3 = new System.Windows.Forms.Label();
			this.lbl_2 = new System.Windows.Forms.Label();
			this.lbl_1 = new System.Windows.Forms.Label();
			this.fgrid_Main = new COM.FSP();
			this.image_Tag = new System.Windows.Forms.ImageList(this.components);
			this.txt_MinPo = new System.Windows.Forms.TextBox();
			this.txt_MaxPo = new System.Windows.Forms.TextBox();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.cmt_CSOBS_CRT = new System.Windows.Forms.MenuItem();
			this.ctm_CSOBS_Req = new System.Windows.Forms.MenuItem();
			this.ctm_Bar_First = new System.Windows.Forms.MenuItem();
			this.ctm_BP_Sel = new System.Windows.Forms.MenuItem();
			this.cmt_BP_HistSel = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Body.SuspendLayout();
			this.pnl_progress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
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
			this.pnl_Search.TabIndex = 36;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.cmb_Del);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Del_Month);
			this.pnl_Search1_Image.Controls.Add(this.dpick_down_ymd);
			this.pnl_Search1_Image.Controls.Add(this.lbl_DOWN_YMD);
			this.pnl_Search1_Image.Controls.Add(this.textBox1);
			this.pnl_Search1_Image.Controls.Add(this.txt_sheet);
			this.pnl_Search1_Image.Controls.Add(this.lbl_sheet);
			this.pnl_Search1_Image.Controls.Add(this.btn_path);
			this.pnl_Search1_Image.Controls.Add(this.txt_Path);
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
			this.pnl_Search1_Image.Controls.Add(this.lbl_STYLE);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox4);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox6);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox9);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(1000, 112);
			this.pnl_Search1_Image.TabIndex = 0;
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
			this.dpick_down_ymd.Size = new System.Drawing.Size(210, 20);
			this.dpick_down_ymd.TabIndex = 118;
			this.dpick_down_ymd.ValueChanged += new System.EventHandler(this.dpick_down_ymd_ValueChanged);
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
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Verdana", 8F);
			this.textBox1.Location = new System.Drawing.Point(344, 80);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(646, 20);
			this.textBox1.TabIndex = 114;
			this.textBox1.Text = "textBox1";
			this.textBox1.Visible = false;
			// 
			// txt_sheet
			// 
			this.txt_sheet.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_sheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_sheet.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_sheet.ForeColor = System.Drawing.Color.Black;
			this.txt_sheet.Location = new System.Drawing.Point(780, 36);
			this.txt_sheet.MaxLength = 100;
			this.txt_sheet.Name = "txt_sheet";
			this.txt_sheet.ReadOnly = true;
			this.txt_sheet.Size = new System.Drawing.Size(210, 20);
			this.txt_sheet.TabIndex = 113;
			this.txt_sheet.Text = "";
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
			this.btn_path.ImageList = this.img_MiniButton;
			this.btn_path.Location = new System.Drawing.Point(299, 58);
			this.btn_path.Name = "btn_path";
			this.btn_path.Size = new System.Drawing.Size(21, 21);
			this.btn_path.TabIndex = 111;
			this.btn_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txt_Path
			// 
			this.txt_Path.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Path.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Path.ForeColor = System.Drawing.Color.Black;
			this.txt_Path.Location = new System.Drawing.Point(111, 58);
			this.txt_Path.MaxLength = 100;
			this.txt_Path.Name = "txt_Path";
			this.txt_Path.ReadOnly = true;
			this.txt_Path.Size = new System.Drawing.Size(187, 20);
			this.txt_Path.TabIndex = 110;
			this.txt_Path.Text = "";
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
			// lbl_STYLE
			// 
			this.lbl_STYLE.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_STYLE.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_STYLE.ImageIndex = 0;
			this.lbl_STYLE.ImageList = this.img_Label;
			this.lbl_STYLE.Location = new System.Drawing.Point(344, 36);
			this.lbl_STYLE.Name = "lbl_STYLE";
			this.lbl_STYLE.Size = new System.Drawing.Size(100, 21);
			this.lbl_STYLE.TabIndex = 20;
			this.lbl_STYLE.Text = "Style";
			this.lbl_STYLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.Color.Navy;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(32, 24);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(952, 80);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.Color.Blue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 98);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(80, 14);
			this.pictureBox6.TabIndex = 6;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.Color.Blue;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(72, 98);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(912, 14);
			this.pictureBox9.TabIndex = 9;
			this.pictureBox9.TabStop = false;
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
			this.pnl_Body.TabIndex = 43;
			// 
			// pnl_progress
			// 
			this.pnl_progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_progress.BackgroundImage")));
			this.pnl_progress.Controls.Add(this.lbl_m);
			this.pnl_progress.Controls.Add(this.lbl_u);
			this.pnl_progress.Controls.Add(this.lbl_s);
			this.pnl_progress.Controls.Add(this.progressBar1);
			this.pnl_progress.Controls.Add(this.label3);
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
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkGreen;
			this.label3.Location = new System.Drawing.Point(32, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 14);
			this.label3.TabIndex = 17;
			this.label3.Text = "Upload Status...";
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
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,85,Columns:1{AllowMerging:True;}\t";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(1000, 448);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;Border:Flat,1,Control,Vertical;}	Fixed{BackColor:226, 245, 153;ForeColor:Black;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;ForeColor:Black;}	Focus{BackColor:236, 247, 187;ForeColor:Black;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 38;
			// 
			// image_Tag
			// 
			this.image_Tag.ImageSize = new System.Drawing.Size(16, 16);
			this.image_Tag.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_Tag.ImageStream")));
			this.image_Tag.TransparentColor = System.Drawing.Color.Transparent;
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
			this.txt_MinPo.TabIndex = 108;
			this.txt_MinPo.Text = "";
			// 
			// txt_MaxPo
			// 
			this.txt_MaxPo.BackColor = System.Drawing.Color.White;
			this.txt_MaxPo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_MaxPo.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_MaxPo.Location = new System.Drawing.Point(896, 8);
			this.txt_MaxPo.MaxLength = 100;
			this.txt_MaxPo.Name = "txt_MaxPo";
			this.txt_MaxPo.Size = new System.Drawing.Size(112, 21);
			this.txt_MaxPo.TabIndex = 109;
			this.txt_MaxPo.Text = "";
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.cmt_CSOBS_CRT,
																						 this.ctm_CSOBS_Req,
																						 this.ctm_Bar_First,
																						 this.ctm_BP_Sel,
																						 this.cmt_BP_HistSel});
			// 
			// cmt_CSOBS_CRT
			// 
			this.cmt_CSOBS_CRT.Index = 0;
			this.cmt_CSOBS_CRT.Text = "CS OBS Create";
			this.cmt_CSOBS_CRT.Click += new System.EventHandler(this.cmt_CSOBS_CRT_Click);
			// 
			// ctm_CSOBS_Req
			// 
			this.ctm_CSOBS_Req.Index = 1;
			this.ctm_CSOBS_Req.Text = "CS OBS Request";
			this.ctm_CSOBS_Req.Click += new System.EventHandler(this.ctm_CSOBS_Req_Click);
			// 
			// ctm_Bar_First
			// 
			this.ctm_Bar_First.Index = 2;
			this.ctm_Bar_First.Text = "-";
			// 
			// ctm_BP_Sel
			// 
			this.ctm_BP_Sel.Index = 3;
			this.ctm_BP_Sel.Text = "BP By Option";
			this.ctm_BP_Sel.Click += new System.EventHandler(this.ctm_BP_Sel_Click);
			// 
			// cmt_BP_HistSel
			// 
			this.cmt_BP_HistSel.Index = 4;
			this.cmt_BP_HistSel.Text = "BP History";
			this.cmt_BP_HistSel.Click += new System.EventHandler(this.cmt_BP_HistSel_Click);
			// 
			// Form_EL_BP
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.txt_MaxPo);
			this.Controls.Add(this.txt_MinPo);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EL_BP";
			this.Text = "Build Plan Loading";
			this.Load += new System.EventHandler(this.Form_EL_BP_Load);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.txt_MinPo, 0);
			this.Controls.SetChildIndex(this.txt_MaxPo, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			this.pnl_progress.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의 
		private int _Rowfixed;  
		private string _sheet1, _sheet2;
		private ClassLib.OraDB  MyOraDB = new ClassLib.OraDB();
		private COM.ComFunction MyComFunction    = new COM.ComFunction();
		#endregion 

		#region 멤버 메서드 

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			
			//Title
			this.Text = "Build Plan Loading";
			this.lbl_MainTitle.Text = "Build Plan Loading"; 
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
			fgrid_Main.Set_Grid( "SEM_BP", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
			_Rowfixed = fgrid_Main.Rows.Fixed;		
			fgrid_Main.Set_Action_Image(img_Action); 
			fgrid_Main.Font  = new Font("Verdana",8);
				
			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib. ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib. ComVar.This_Factory;
	
			// Get target Excel File Path
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxBP_Path);
			txt_Path.Text = dt_list.Rows[0].ItemArray[1].ToString();

			// Get target Excel File Sheetname
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxBP_Sheet);
			_sheet1 = dt_list.Rows[0].ItemArray[1].ToString();  //Build Plan
			_sheet2 = dt_list.Rows[1].ItemArray[1].ToString();  //Sply Detail 
			txt_sheet.Text = _sheet1 + ", " + _sheet2; 		
			
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


		private void SB_Pop_Up()
		{
			FlexOrder.ExpLoad.POP_EL_BP  pop_form = new ExpLoad.POP_EL_BP();

			COM.ComVar.Parameter_PopUp = new string[] 
			{
				cmb_Factory.SelectedValue.ToString(),
				txt_MinPo.Text,
				txt_MaxPo.Text,
				txt_Style.Text
			};
			 
			pop_form.ShowDialog();

		}

		#endregion

		#region DB 컨트롤

		/// <summary>
		/// Select_BP_List
		/// </summary>
		private void Select_BP_List()
		{
			OleDbDataReader reader;

			string strSrc = txt_Path.Text;
			
			//_sheet2 = dt_list.Rows[1].ItemArray[1].ToString();  //Sply Detail  ,B
			string strSql = " SELECT   FCTY,  STY_DSP_NBR +  COLR_DSP_NBR as STYLE_CD,  STYLE_NAME,  DEL_MO,  DEST, '99999999' AS LASTING_WK," +
				" DMD_QTY, TARGET_IPW AS  BTO_DT ,  FCTY_GRP,  OS1,  MS1,  DEVCODE," +
				" PROD_ID, FCTY_CTRY_CD, PG_DEV_FCTY, TARGET_IPW," +
				" AIRBAG1,AIRBAG2,AIRBAG3,'00' AS PROD_LINE_CD, SAP_CAT_LONG_DESC AS PROD_LINE_DESC," +
				"'00' AS PROD_CAT_CD,SAP_SUB_CAT_LONG_DESC  AS  PROD_CAT_DESC, GENDERAGENAME,'NONE' AS  TYPEGROUPNAME," +
				"  LAST_CD,  TOOL_WK_CAP" +
				"   FROM [" + _sheet1 + "$] " +
				"  WHERE  FCTY= '" +cmb_Factory.SelectedValue+"' ";

//			SUM(CASE ACT_GUBUN
// WHEN '' THEN 0
// WHEN ISNULL(GRADE,0) THEN 0
//END) AS DAY_TOTAL


			if (txt_Style.Text.Trim().Length > 0)
				strSql +=	"   AND TRIM(  STY_DSP_NBR+  COLR_DSP_NBR) LIKE '" + txt_Style.Text + "%'" ;


			if (cmb_Del.Text.Trim().Length > 0)
				strSql +=	 " AND TRIM(  DEL_MO)<= '" + cmb_Del.Text  + "'" ;


			strSql +=	" ORDER BY   STY_DSP_NBR+  COLR_DSP_NBR ";

			strSql +=   " UNION ALL " ;

			//STYLE정보가 아닌 개발코드로 넘어온 데이타 SELECT
			strSql =  strSql +  " SELECT   FCTY,  STY_DSP_NBR +  COLR_DSP_NBR as STYLE_CD,  STYLE_NAME,  DEL_MO,  DEST, '99999999' AS LASTING_WK," +
				" DMD_QTY, TARGET_IPW AS  BTO_DT ,  FCTY_GRP,  OS1,  MS1,  DEVCODE," +
				" PROD_ID, FCTY_CTRY_CD, PG_DEV_FCTY, TARGET_IPW," +
				" AIRBAG1,AIRBAG2,AIRBAG3,'00' AS PROD_LINE_CD, SAP_CAT_LONG_DESC AS PROD_LINE_DESC," +
				"'00' AS PROD_CAT_CD,SAP_SUB_CAT_LONG_DESC  AS  PROD_CAT_DESC, GENDERAGENAME,'NONE' AS  TYPEGROUPNAME," +
				"  LAST_CD,  TOOL_WK_CAP " +
				"   FROM [" + _sheet1 + "$] " +
				"  WHERE   COLR_DSP_NBR IS NULL"+
				"    AND   FCTY= '" +cmb_Factory.SelectedValue+"' ";

			
			if (txt_Style.Text.Trim().Length > 0)
				strSql +=	"   AND TRIM(  STY_DSP_NBR+  COLR_DSP_NBR) LIKE '" + txt_Style.Text + "%'" ;


			if (cmb_Del.Text.Trim().Length > 0)
				strSql +=	 " AND TRIM(  DEL_MO)<= '" + cmb_Del.Text  + "'" ;
				



			#region 구버젼 쿼리
//			string strSql = " SELECT A.FCTY,A.STY_DSP_NBR+A.COLR_DSP_NBR as STYLE_CD,A.STYLE_NAME,A.DEL_MO,A.DEST, LASTING_WK," +
//				" PRDC_QTY, BTO_DT ,A.FCTY_GRP,A.OS1,A.MS1,A.DEVCODE," +
//				" GFP_PROD_ID, FCTY_CTRY_CD, PG_DEV_FCTY, TARGET_IPW," +
//				" AIRBAG1, AIRBAG2, AIRBAG3,'00' AS PROD_LINE_CD, SAP_CAT_LONG_DESC AS PROD_LINE_DESC," +
//				"'00' AS PROD_CAT_CD, SAP_SUB_CAT_LONG_DESC  AS  PROD_CAT_DESC, GENDERAGENAME,'NONE' AS  TYPEGROUPNAME," +
//				" LAST_CD, TOOL_WK_CAP" +
//				"   FROM [" + _sheet1 + "$] A, [" + _sheet2 + "$] B  " +
//				"  WHERE A.FCTY=  FCT" +
//				"    AND TRIM(A.STY_DSP_NBR+A.COLR_DSP_NBR)= TRIM( STYLE+ CLR)" +
//				"    AND A.DEL_MO =  DEL_MO" +
//				"    AND A.DEST=  DEST" +
//				"    AND A.FCTY= '" +cmb_Factory.SelectedValue+"' ";
//
//			if (txt_Style.Text.Trim().Length > 0)
//				strSql +=	"   AND TRIM(A.STY_DSP_NBR+A.COLR_DSP_NBR) LIKE '" + txt_Style.Text + "%'" ;
//
//
//			if (cmb_Del.Text.Trim().Length > 0)
//				strSql +=	 " AND TRIM(A.DEL_MO)<= '" + cmb_Del.Text  + "'" ;
//
//
//			strSql +=	" ORDER BY A.STY_DSP_NBR+A.COLR_DSP_NBR ";
//
//			strSql +=   " UNION ALL " ;
//
//			//STYLE정보가 아닌 개발코드로 넘어온 데이타 SELECT
//			strSql =  strSql +  " SELECT A.FCTY,A.STY_DSP_NBR+A.COLR_DSP_NBR as STYLE_CD,A.STYLE_NAME,A.DEL_MO,A.DEST, LASTING_WK," +
//				" PRDC_QTY, BTO_DT ,A.FCTY_GRP,A.OS1,A.MS1,A.DEVCODE," +
//				" GFP_PROD_ID, FCTY_CTRY_CD, PG_DEV_FCTY, TARGET_IPW," +
//				" AIRBAG1, AIRBAG2, AIRBAG3,'00' AS PROD_LINE_CD, SAP_CAT_LONG_DESC AS PROD_LINE_DESC," +
//				"'00' AS PROD_CAT_CD, SAP_SUB_CAT_LONG_DESC  AS  PROD_CAT_DESC, GENDERAGENAME,'NONE' AS  TYPEGROUPNAME," +
//				" LAST_CD, TOOL_WK_CAP" +
//				"   FROM [" + _sheet1 + "$] A, [" + _sheet2 + "$] B  " +
//				"  WHERE A.FCTY=  FCT" +
//				"    AND TRIM(A.STY_DSP_NBR+A.COLR_DSP_NBR)= TRIM( STYLE+ CLR)" +
//				"    AND A.DEL_MO =  DEL_MO" +
//				"    AND A.DEST=  DEST" +
//				"    AND A.COLR_DSP_NBR IS NULL"+
//				"    AND A.FCTY= '" +cmb_Factory.SelectedValue+"' ";
//
//			
//			if (txt_Style.Text.Trim().Length > 0)
//				strSql +=	"   AND TRIM(A.STY_DSP_NBR+A.COLR_DSP_NBR) LIKE '" + txt_Style.Text + "%'" ;
//
//
//			if (cmb_Del.Text.Trim().Length > 0)
//				strSql +=	 " AND TRIM(A.DEL_MO)<= '" + cmb_Del.Text  + "'" ;
				
			#endregion 



			#region 구버젼 쿼리

//			string strSql = " SELECT A.Fcty,A.Style+A.Clr as Style_cd,A.Name,A.Del_MO,A.Dest, LASTING_WK," +
//				" Prod_Qty, BTO_DT,A.Fcty_Grp,A.OS1,A.MS1,A.DevCode," +
//				"A.Prod_ID,A.FCTY_CTRY_CD,A.PG_DEV_FCTY,A.IPW," +
//				"A.AIRBAG1,A.AIRBAG2,A.AIRBAG3,A.PROD_LINE_CD,A.PROD_LINE_DESC," +
//				"A.PROD_CAT_CD,A.PROD_CAT_DESC,A.GENDERAGENAME,A.TYPEGROUPNAME," +
//				"A.LAST_CD,A.TOOL_WK_CAP" +
//				"   FROM [" + _sheet1 + "$] A, [" + _sheet2 + "$] B  " +
//				"  WHERE A.Fcty	  =  Fcty						     " +
//				"	 AND TRIM(A.Style+A.Clr)  = TRIM( Style+ Clr)  " +
//				"    AND A.Del_MO =  DEL_MO					     " +
//				"    AND A.Dest   =  Dest						     " +
//				"    AND A.Fcty   = '" +cmb_Factory.SelectedValue+"' ";
//			   
//
//			if (txt_Style.Text.Trim().Length > 0)
//				strSql +=	"   AND TRIM(A.Style+ Clr) LIKE '" + txt_Style.Text + "%'" ;
//
//
//			if (cmb_Del.Text.Trim().Length > 0)
//				strSql +=	 " AND TRIM(A.Del_MO)<= '" + cmb_Del.Text  + "'" ;
//
//
//			strSql +=	" ORDER BY A.Style+A.Clr ";
//
//			strSql +=   " UNION ALL " ;
//
//			//STYLE정보가 아닌 개발코드로 넘어온 데이타 SELECT
//			strSql +=   " SELECT A.Fcty,A.Style AS Style_cd,A.Name,A.Del_MO,A.Dest, LASTING_WK," +
//				" Prod_Qty, BTO_DT,A.Fcty_Grp,A.OS1,A.MS1,A.DevCode," +
//				"A.Prod_ID,A.FCTY_CTRY_CD,A.PG_DEV_FCTY,A.IPW," +
//				"A.AIRBAG1,A.AIRBAG2,A.AIRBAG3,A.PROD_LINE_CD,A.PROD_LINE_DESC," +
//				"A.PROD_CAT_CD, A.PROD_CAT_DESC,A.GENDERAGENAME,A.TYPEGROUPNAME," +
//				"A.LAST_CD,A.TOOL_WK_CAP" +
//				"   FROM [" + _sheet1 + "$] A, [" + _sheet2 + "$] B  " +
//				"  WHERE A.Fcty	  =  Fcty						     " +
//				"	 AND A.Style  =  Style						     " +
//				"    AND A.Del_MO =  DEL_MO					     " +
//				"    AND A.Dest   =  Dest						     " +
//				"    AND A.Clr is null " +
//				"    AND A.Fcty   = '" +cmb_Factory.SelectedValue+"' "; 
//
//			if (txt_Style.Text.Trim().Length > 0)
//				strSql +=	 "    AND TRIM(A.Style+ Clr) LIKE '" + txt_Style.Text + "%'" ;
//
//
//			if (cmb_Del.Text.Trim().Length > 0)
//				strSql +=	 " AND TRIM(A.Del_MO)<= '" + cmb_Del.Text  + "'" ;
//				

			#endregion 

	
			fgrid_Main.Rows.Count = _Rowfixed;
			
			//Excel File Read Function
			reader = ClassLib.ComFunction.Read_Excel(strSrc, strSql);
							
			bool b = true;                                                
			string[] str_d = new string[reader.FieldCount];			
			int[] ai = new int[2];
			ai[0] = (int)ClassLib.TBSEM_BP.IxFACTORY;
			ai[1] = (int)ClassLib.TBSEM_BP.IxSTYLE_CD;
			
			//Update용 레코드 강제생성//
			fgrid_Main.Rows.Count += 1;
			fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "U";

			for(int i=1; i<fgrid_Main.Cols.Count; i++)
				fgrid_Main[fgrid_Main.Rows.Count - 1, i] = "_";
			fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSEM_BP.IxDOWN_YMD] = Convert.ToDateTime(dpick_down_ymd.Text).ToString("yyyyMMdd");
			fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSEM_BP.IxFACTORY]  = cmb_Factory.SelectedValue;
			fgrid_Main.Rows[fgrid_Main.Rows.Count-1].Visible = false;
			

			while (reader.Read())
			{
				for(int i=0; i<reader.FieldCount; i++)
					str_d[i] = ClassLib.ComFunction.Convert_dtType(reader[i].GetType().Name.ToString(), reader[i].ToString());

//				textBox1.Text = str_d[0].ToString()+"/"+str_d[0].ToString().Trim().Length.ToString()+"/"+
//					str_d[1].ToString()+"/"+str_d[2].ToString() +"/"+
//					str_d[5].ToString()+"/"+str_d[6].ToString() +"////"+ fgrid_Main.Rows.Count.ToString();
					
				textBox1.Refresh();

			
				if ((str_d[ai[0]-7].ToString().Trim() != fgrid_Main[fgrid_Main.Rows.Count-1, ai[0]].ToString().Trim()) ||
					(str_d[ai[1]-7].ToString().Trim() != fgrid_Main[fgrid_Main.Rows.Count-1, ai[1]].ToString().Trim())  )
					b = false;
				else 
					b = true;

				fgrid_Main.AddItem(str_d, fgrid_Main.Rows.Count, 7);
				fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "I";
				fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSEM_BP.IxREMARKS]  = "None";
				fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSEM_BP.IxDOWN_YMD] = Convert.ToDateTime(dpick_down_ymd.Text).ToString("yyyyMMdd");
														

				if (b)  //헤더레코드의 fix column 데이타만 보이게 함
					fgrid_Main.GetCellRange(fgrid_Main.Rows.Count-1, ai[0], fgrid_Main.Rows.Count-1, ai[1]+1).StyleNew.ForeColor = ClassLib.ComVar.ClrTransparent;
				else				
				{
					fgrid_Main.GetCellRange(fgrid_Main.Rows.Count-1, ai[1]+2, fgrid_Main.Rows.Count-1, fgrid_Main.Cols.Count-1).StyleNew.BackColor = ClassLib.ComVar.ClrHead;
					fgrid_Main.GetCellRange(fgrid_Main.Rows.Count-1, ai[1]+2, fgrid_Main.Rows.Count-1, fgrid_Main.Cols.Count-1).Style.Border.Direction = BorderDirEnum.Both;
				}							
				str_d.Initialize();							
			}
			fgrid_Main.AutoSizeCols();
			fgrid_Main.Cols[0].Width = 0;
		}

		/// <summary>
		/// BP LOADING시 NEOMICS.STYLE 정보 체크, SEM_GSSC 체크
		/// </summary>
		/// <param name="arg_factory"factory></param>
		/// <param name="arg_fgrid">작업그리드</param>
		public  void Check_Style(C1FlexGrid arg_fgrid)
		{			
	
			progressBar1.Value = 0;
			lbl_1.ForeColor = Color.SaddleBrown;
			lbl_1.Text = "▶Check Style";
			lbl_1.Refresh();

			progressBar1.Value = 0;
			progressBar1.Maximum = arg_fgrid.Rows.Count-1;

			DateTime CurDate = DateTime.Now;	
			string Buf_fact  = "";
			string Buf_style = "";

			for (int i=arg_fgrid.Rows.Fixed+1; i<arg_fgrid.Rows.Count; i++)
			{		
				string arg_fact   = arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxFACTORY].ToString().Trim();
				string arg_style  = arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxSTYLE_CD].ToString().Trim();
			
				if ((Buf_fact  != arg_fact)  ||
					(Buf_style != arg_style) )
				{

					string strRlt; int iCnt;
					DataSet ret; DataTable dt_list;
		    
					iCnt =  3;
					MyOraDB. ReDim_Parameter(iCnt); 
		    
					strRlt  = "PKG_SEM_BP.SELECT_SEM_STYLE";
					MyOraDB. Process_Name =strRlt;
	
					MyOraDB. Parameter_Name[0] = "ARG_FACTORY";
					MyOraDB. Parameter_Name[1] = "ARG_STYLE"; 
					MyOraDB. Parameter_Name[2] = "OUT_CURSOR";
				
					MyOraDB. Parameter_Type[0] =  (int)OracleType.VarChar;
					MyOraDB. Parameter_Type[1] =  (int)OracleType.VarChar;
					MyOraDB. Parameter_Type[2] =  (int)OracleType.Cursor;						
	
					MyOraDB. Parameter_Values[0] = arg_fact;
					MyOraDB. Parameter_Values[1] = arg_style;
					MyOraDB. Parameter_Values[2] = "";
				
					MyOraDB. Add_Select_Parameter(true); 
					ret = MyOraDB. Exe_Select_Procedure();
										
					if (ret == null)  return  ;
					dt_list  =  ret.Tables[strRlt];

					for(int j=0; j<dt_list.Columns.Count; j++)
					{
						arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxERROR_YN] = "T";
						arg_fgrid[i, j+1] = dt_list.Rows[0].ItemArray[j].ToString();
						

						if (arg_fgrid[i, j+1].ToString().Trim() == "False")
						{					
							arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxERROR_YN] = "F";
							arg_fgrid.GetCellRange(i, 0, i, arg_fgrid.Cols.Count-1).StyleNew.ForeColor = ClassLib.ComVar.Clrwarn;
							arg_fgrid.GetCellRange(i, 0, i, arg_fgrid.Cols.Count-1).StyleNew.BackColor = ClassLib.ComVar.ClrHead;
						}						
					}								
					Buf_fact   = arg_fact;
					Buf_style  = arg_style;		
				}
				else
				{
					for(int j=(int)ClassLib.TBSEM_BP.lxStyle; j<=(int)ClassLib.TBSEM_BP.lxGSSC; j++)
					{
						arg_fgrid[i, j] = arg_fgrid[i-1, j].ToString();
						arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxERROR_YN] = "T";				
						
						if (arg_fgrid[i, j].ToString().Trim() == "False")
						{										
							arg_fgrid.GetCellRange(i, 0, i, arg_fgrid.Cols.Count-1).StyleNew.ForeColor = ClassLib.ComVar.Clrwarn;
							arg_fgrid.GetCellRange(i, 0, i, arg_fgrid.Cols.Count-1).StyleNew.BackColor = ClassLib.ComVar.ClrHead;
						}						
					}												
				}

				float rate = progressBar1.Value/progressBar1.Maximum;
				lbl_s.Text = ": " + rate.ToString() + "% (" + i.ToString() + "/" + (arg_fgrid.Rows.Count-1).ToString() + ")";			
				lbl_s.Text = ": " + (Math.Ceiling(rate*100)).ToString() + "% (" + i.ToString() + "/" + (arg_fgrid.Rows.Count-1).ToString() + ")";			
				lbl_s.Refresh();

			}			
		}

		/// <summary>
		/// BP LOADING시 SEM_REGION Check
		/// </summary>
		/// <param name="arg_factory"factory></param>
		/// <param name="arg_fgrid">작업그리드</param>
		public void Check_Region(C1FlexGrid arg_fgrid, int arg_rowfixed, TextBox arg_text)
		{			

			progressBar1.Value = 0;
			lbl_2.ForeColor = Color.SaddleBrown;
			lbl_2.Text = "▶Check Region";
			lbl_2.Refresh();

			progressBar1.Value = 0;
			progressBar1.Maximum = arg_fgrid.Rows.Count-1;

			string strRlt; int iCnt;
			DataSet ret; DataTable dt_list;
		    
			iCnt =  2;
			MyOraDB.ReDim_Parameter(iCnt); 
		    
			strRlt  =  "PKG_SEM_BP.SELECT_SEM_REGION";
			MyOraDB.Process_Name =strRlt;
	
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
				
			MyOraDB.Parameter_Type[0] =  (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] =  (int)OracleType.Cursor;						
	
			MyOraDB.Parameter_Values[0] =  arg_fgrid[arg_rowfixed, (int)ClassLib.TBSEM_BP.IxFACTORY].ToString();
			MyOraDB.Parameter_Values[1] = "";
				
			MyOraDB. Add_Select_Parameter(true); 
			ret = MyOraDB. Exe_Select_Procedure();

			if (ret == null)  return  ;
			dt_list  =  ret.Tables[strRlt];

//			int j=0;
			for (int i=arg_rowfixed+1; i<arg_fgrid.Rows.Count; i++)
			{

				#region Region 검증
				string strExpr = " REGION  = '" + arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxREGION].ToString()  + "'";

				DataRow[] foundRows = dt_list.Select(strExpr);

				if (foundRows.Length == 0)
				{
					arg_fgrid[i, (int)ClassLib.TBSEM_BP.lxRegion]   = "False";
					arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxERROR_YN] = "F";
					arg_fgrid.GetCellRange(i, 0, i, arg_fgrid.Cols.Count-1).StyleNew.ForeColor = ClassLib.ComVar.Clrwarn;
					arg_fgrid.GetCellRange(i, 0, i, arg_fgrid.Cols.Count-1).StyleNew.BackColor = ClassLib.ComVar.ClrHead;
				}
				else
				{
					arg_fgrid[i, (int)ClassLib.TBSEM_BP.lxRegion]   = "True";
					//arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxERROR_YN] = "T"; 
				}
				#endregion

				#region pono검증

				if (Convert.ToInt32(arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxBP_NO].ToString()) >
					Convert.ToInt32(txt_MaxPo.Text )) 
					txt_MaxPo.Text  = arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxBP_NO].ToString();

				if (Convert.ToInt32(arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxBP_NO].ToString()) < 
					Convert.ToInt32(txt_MinPo.Text )) 
					txt_MinPo.Text = arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxBP_NO].ToString();

				#endregion

				//if (arg_fgrid[i, (int)ClassLib.TBSEM_BP.IxERROR_YN].ToString() == "T") j = j+1;				

				float rate = progressBar1.Value/progressBar1.Maximum;
				lbl_u.Text = ": " + rate.ToString() + "% (" + i.ToString() + "/" + (arg_fgrid.Rows.Count-1).ToString() + ")";			
				lbl_u.Text = ": " + (Math.Ceiling(rate*100)).ToString() + "% (" + i.ToString() + "/" + (arg_fgrid.Rows.Count-1).ToString() + ")";			
				lbl_u.Refresh();

			}				
			//arg_text.Text = j.ToString();
		}



		/// <summary>
		/// SAVE SEM_BP
		/// </summary>
		private bool Save_SEM_BP(C1FlexGrid arg_fgrid)  
		{

			progressBar1.Value = 0;
			lbl_3.ForeColor = Color.SaddleBrown;
			lbl_3.Text = "▶ Data Upload";
			lbl_3.Refresh();

			progressBar1.Value = 0;
			progressBar1.Maximum = arg_fgrid.Rows.Count-1;
            
			int col_ct = fgrid_Main.Cols.Count;

			#region 히스토리 저장
			MyOraDB. ReDim_Parameter(col_ct); 

			MyOraDB. Process_Name = "PKG_SEM_BP.SAVE_SEM_BP";

			for(int i = 0; i < col_ct; i++)
				MyOraDB. Parameter_Type[i] = (int)OracleType.VarChar; 

			for(int i = 1; i < col_ct; i++)
			{
				MyOraDB. Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB. Parameter_Name[i] = "ARG_" + fgrid_Main[0,i].ToString();
			}

			for(int i=_Rowfixed; i<arg_fgrid.Rows.Count; i++)
			{
				for(int j=0; j<=(int)ClassLib.TBSEM_BP.IxERROR_YN; j++)
				{
					if (arg_fgrid[i, j] == null)  
						MyOraDB. Parameter_Values[j] =" ";
					else
						MyOraDB. Parameter_Values[j]  = arg_fgrid[i, j].ToString();
				}

				MyOraDB. Parameter_Values[(int)ClassLib.TBSEM_BP.IxUPD_USER]  = ClassLib.ComVar.This_User;
				MyOraDB. Parameter_Values[(int)ClassLib.TBSEM_BP.IxUPD_YMD]  = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

				MyOraDB.Add_Modify_Parameter(true);   //첫번째.... 	 
				MyOraDB. Exe_Modify_Procedure();


				progressBar1.Value =  i;

				float rate = progressBar1.Value/progressBar1.Maximum;
				lbl_m.Text = ": " + rate.ToString() + "% (" + i.ToString() + "/" + (arg_fgrid.Rows.Count-1).ToString() + ")";			
				lbl_m.Text = ": " + (Math.Ceiling(rate*100)).ToString() + "% (" + i.ToString() + "/" + (arg_fgrid.Rows.Count-1).ToString() + ")";			
				lbl_m.Refresh();
			}

			

			
			#endregion 
//
//
//			#region delievery month change
//
//			MyOraDB. ReDim_Parameter(1); 
//
//			MyOraDB. Process_Name = "PKG_SEM_BP.UPDATE_SEM_BP_DELMONH";
//
//			MyOraDB. Parameter_Type[0] = (int)OracleType.VarChar;	 
//
//			MyOraDB. Parameter_Name[0] = "ARG_FACTORY";
//						
//			MyOraDB. Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
//				
//			MyOraDB. Add_Modify_Parameter(true);
//			MyOraDB. Exe_Modify_Procedure();
//
//

//
//			#endregion 

			return true;
		
		}



		
		/// <summary>
		/// Send_SEM_BP
		/// </summary>
		private void Send_SEM_BP()  
		{

		

            int col_ct = 3;
			MyOraDB. ReDim_Parameter(col_ct); 

			MyOraDB. Process_Name = "PKG_SEM_BP.SEND_SEM_BP";

			for(int i = 0; i < col_ct; i++)
				MyOraDB. Parameter_Type[i] = (int)OracleType.VarChar; 

			MyOraDB. Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB. Parameter_Name[1] = "ARG_UPD_USER";
			MyOraDB. Parameter_Name[2] = "ARG_UPD_YMD";


			MyOraDB. Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB. Parameter_Values[1]  = ClassLib.ComVar.This_User.Replace("@dskorea.com","");
			MyOraDB. Parameter_Values[2]  = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

			MyOraDB. Add_Modify_Parameter(true);
			MyOraDB. Exe_Modify_Procedure();

		
		}

		#endregion

		#region 이벤트 처리

		private void btn_path_Click(object sender, System.EventArgs e)
		{
			openFileDialog1.InitialDirectory = txt_Path.Text;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txt_Path.Text = openFileDialog1.FileName;
			}
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{		
				//Build Plan정보(Sheet name : 해당파일.Xls - Sply Detail, Build Plan)를 읽어온다
				Select_BP_List();		
		
				if (fgrid_Main.Rows.Count == _Rowfixed) 
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
				}
		 
			}
			catch
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
			}							
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				//progress initial
				pnl_progress.Visible = true;

				lbl_1.Text = "   GPO Move";
				lbl_2.Text = "   Data Check";
				lbl_3.Text = "   GPO Upload";

				lbl_1.ForeColor = Color.Silver;
				lbl_2.ForeColor = Color.Silver;
				lbl_3.ForeColor = Color.Silver;

				lbl_s.Text = "";
				lbl_u.Text = "";
				lbl_m.Text = "";


				//스타일등 정보 체크
				Check_Style(fgrid_Main);

				//REGION 정보 체크
		  	    Check_Region(fgrid_Main, _Rowfixed, textBox1);		

				//UPLOAD..
				

				if (Save_SEM_BP(fgrid_Main) == false) 
				{
					pnl_progress.Visible = false;
					//ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave,this);
				}
				else
				{
					pnl_progress.Visible = false;
					Send_SEM_BP();
					SB_Pop_Up();
				}

			}
			catch 
			{   
				pnl_progress.Visible = false;
                 
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave,this);
				
			}			
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_list;

			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;	

			// Get target Excel File Path
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxBP_Path);
			txt_Path.Text = dt_list.Rows[0].ItemArray[1].ToString();

			dpick_down_ymd.Text = DateTime.Now.ToString();
			fgrid_Main.Rows.Count = _Rowfixed;  					
		}	


		private void dpick_down_ymd_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_down_ymd.Name, "");
		}

		#endregion

		#region 콘텍스트 메뉴
		private void cmt_CSOBS_CRT_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBSCS.Form_EC_CRT frm = new ExpOBSCS.Form_EC_CRT();
			frm.Show();	
		}

		
		private void ctm_CSOBS_Req_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBSCS.Form_EC_Req frm = new ExpOBSCS.Form_EC_Req();
			frm.Show();	
		}


		private void ctm_BP_Sel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpBP.Form_EB_SRCH frm = new ExpBP.Form_EB_SRCH();  
			frm.Show();	
		}

		private void cmt_BP_HistSel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpBP.Form_EB_HIST frm = new ExpBP.Form_EB_HIST();  
			frm.Show();	
		}


		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Send_SEM_BP()  ;
		}


		private void Form_EL_BP_Load(object sender, System.EventArgs e)
		{
			Init_Form();				
		}

		
	}
}

