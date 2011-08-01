using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace COM.Com_Form
{
	public class Form_Proc_Error : COM.APSWinForm.Form_Top
	{
		public System.Windows.Forms.Panel pnl_Search;
		private C1.Win.C1List.C1Combo cmb_Factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_PopPgId;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.Label lbl_fac;
		private System.Windows.Forms.Label lbl_pdate;
		private System.Windows.Forms.Label lbl_pname;
		private System.Windows.Forms.Label lbl_ediv;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_date;
		private C1.Win.C1List.C1Combo cmb_div;
		private COM.FSP fgrid_Main;
		private System.Windows.Forms.Label lbl_err_mgs;
		private System.Windows.Forms.TextBox txt_err_mgs;
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txt_proc;
















		#region 변수

		private OraDB oraDB = null;
		private int _RowFixed;
		private string division = "BBB";




		private bool autoview = false;
		private string selectdate;
		private string selectspname;
		private string selectwdiv;


		private string cmb1 = "B";
		private string cmb2 = "B";
		private string cmb3 = "B";


		//private string date = "";

		private string rpm_check = null;

		#endregion

		public Form_Proc_Error()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


		public Form_Proc_Error(bool arg_select, string arg_selectdate, string arg_selectspname, string arg_selectwdiv)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			autoview = arg_select;
			selectdate = arg_selectdate;
			selectspname = arg_selectspname;
			selectwdiv = arg_selectwdiv;
		}


		public Form_Proc_Error(string arg_rpm_check, bool arg_select, string arg_selectdate, string arg_selectspname, string arg_selectwdiv)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			rpm_check = arg_rpm_check;
			autoview = arg_select;
			selectdate = arg_selectdate;
			selectspname = arg_selectspname;
			selectwdiv = arg_selectwdiv;
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Proc_Error));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.lbl_ediv = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.lbl_pname = new System.Windows.Forms.Label();
			this.lbl_pdate = new System.Windows.Forms.Label();
			this.lbl_fac = new System.Windows.Forms.Label();
			this.cmb_date = new C1.Win.C1List.C1Combo();
			this.txt_proc = new System.Windows.Forms.TextBox();
			this.cmb_div = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.btn_PopPgId = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.fgrid_Main = new COM.FSP();
			this.lbl_err_mgs = new System.Windows.Forms.Label();
			this.txt_err_mgs = new System.Windows.Forms.TextBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_date)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_div)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
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
			// tbtn_Delete
			// 
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
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
			this.pnl_Search.Controls.Add(this.lbl_ediv);
			this.pnl_Search.Controls.Add(this.lbl_pname);
			this.pnl_Search.Controls.Add(this.lbl_pdate);
			this.pnl_Search.Controls.Add(this.lbl_fac);
			this.pnl_Search.Controls.Add(this.cmb_date);
			this.pnl_Search.Controls.Add(this.txt_proc);
			this.pnl_Search.Controls.Add(this.cmb_div);
			this.pnl_Search.Controls.Add(this.cmb_Factory);
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.Bottom = 5;
			this.pnl_Search.DockPadding.Left = 10;
			this.pnl_Search.DockPadding.Right = 10;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 72);
			this.pnl_Search.TabIndex = 47;
			// 
			// lbl_ediv
			// 
			this.lbl_ediv.ImageIndex = 0;
			this.lbl_ediv.ImageList = this.img_SmallLabel;
			this.lbl_ediv.Location = new System.Drawing.Point(688, 36);
			this.lbl_ediv.Name = "lbl_ediv";
			this.lbl_ediv.Size = new System.Drawing.Size(50, 21);
			this.lbl_ediv.TabIndex = 58;
			this.lbl_ediv.Text = "DIV";
			this.lbl_ediv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_pname
			// 
			this.lbl_pname.ImageIndex = 0;
			this.lbl_pname.ImageList = this.img_SmallLabel;
			this.lbl_pname.Location = new System.Drawing.Point(464, 36);
			this.lbl_pname.Name = "lbl_pname";
			this.lbl_pname.Size = new System.Drawing.Size(50, 21);
			this.lbl_pname.TabIndex = 57;
			this.lbl_pname.Text = "PROC";
			this.lbl_pname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_pdate
			// 
			this.lbl_pdate.ImageIndex = 0;
			this.lbl_pdate.ImageList = this.img_SmallLabel;
			this.lbl_pdate.Location = new System.Drawing.Point(240, 36);
			this.lbl_pdate.Name = "lbl_pdate";
			this.lbl_pdate.Size = new System.Drawing.Size(50, 21);
			this.lbl_pdate.TabIndex = 56;
			this.lbl_pdate.Text = "Date";
			this.lbl_pdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_fac
			// 
			this.lbl_fac.ImageIndex = 0;
			this.lbl_fac.ImageList = this.img_SmallLabel;
			this.lbl_fac.Location = new System.Drawing.Point(18, 36);
			this.lbl_fac.Name = "lbl_fac";
			this.lbl_fac.Size = new System.Drawing.Size(50, 21);
			this.lbl_fac.TabIndex = 55;
			this.lbl_fac.Text = "FACT";
			this.lbl_fac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_date
			// 
			this.cmb_date.AddItemCols = 0;
			this.cmb_date.AddItemSeparator = ';';
			//this.cmb_date.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_date.Caption = "";
			this.cmb_date.CaptionHeight = 17;
			this.cmb_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_date.ColumnCaptionHeight = 18;
			this.cmb_date.ColumnFooterHeight = 18;
			this.cmb_date.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_date.ContentHeight = 17;
			this.cmb_date.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_date.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_date.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_date.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_date.EditorHeight = 17;
			this.cmb_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_date.GapHeight = 2;
			this.cmb_date.ItemHeight = 15;
			this.cmb_date.Location = new System.Drawing.Point(291, 36);
			this.cmb_date.MatchEntryTimeout = ((long)(2000));
			this.cmb_date.MaxDropDownItems = ((short)(5));
			this.cmb_date.MaxLength = 32767;
			this.cmb_date.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_date.Name = "cmb_date";
			//this.cmb_date.PartialRightColumn = false;
			this.cmb_date.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_date.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_date.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_date.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_date.Size = new System.Drawing.Size(150, 21);
			this.cmb_date.TabIndex = 51;
			// 
			// txt_proc
			// 
			this.txt_proc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_proc.Location = new System.Drawing.Point(515, 35);
			this.txt_proc.Name = "txt_proc";
			this.txt_proc.Size = new System.Drawing.Size(150, 22);
			this.txt_proc.TabIndex = 49;
			this.txt_proc.Text = "";
			// 
			// cmb_div
			// 
			this.cmb_div.AddItemCols = 0;
			this.cmb_div.AddItemSeparator = ';';
			//this.cmb_div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_div.Caption = "";
			this.cmb_div.CaptionHeight = 17;
			this.cmb_div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_div.ColumnCaptionHeight = 18;
			this.cmb_div.ColumnFooterHeight = 18;
			this.cmb_div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_div.ContentHeight = 17;
			this.cmb_div.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_div.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_div.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_div.EditorHeight = 17;
			this.cmb_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_div.GapHeight = 2;
			this.cmb_div.ItemHeight = 15;
			this.cmb_div.Location = new System.Drawing.Point(739, 36);
			this.cmb_div.MatchEntryTimeout = ((long)(2000));
			this.cmb_div.MaxDropDownItems = ((short)(5));
			this.cmb_div.MaxLength = 32767;
			this.cmb_div.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_div.Name = "cmb_div";
			//this.cmb_div.PartialRightColumn = false;
			this.cmb_div.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_div.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_div.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_div.Size = new System.Drawing.Size(150, 21);
			this.cmb_div.TabIndex = 40;
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			//this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.Enabled = false;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(69, 36);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			//this.cmb_Factory.PartialRightColumn = false;
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
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.btn_PopPgId);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(10, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(996, 67);
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
			this.picb_MR.Size = new System.Drawing.Size(15, 27);
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
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(772, 32);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      Search Procedure";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(980, 51);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(16, 16);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(144, 49);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(836, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 47);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 27);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
			this.picb_MM.Location = new System.Drawing.Point(160, 24);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.Size = new System.Drawing.Size(828, 27);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 136);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(1000, 384);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 48;
			this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
			// 
			// lbl_err_mgs
			// 
			this.lbl_err_mgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_err_mgs.BackColor = System.Drawing.Color.Transparent;
			this.lbl_err_mgs.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_err_mgs.ForeColor = System.Drawing.Color.DarkBlue;
			this.lbl_err_mgs.Location = new System.Drawing.Point(8, 528);
			this.lbl_err_mgs.Name = "lbl_err_mgs";
			this.lbl_err_mgs.Size = new System.Drawing.Size(200, 23);
			this.lbl_err_mgs.TabIndex = 50;
			this.lbl_err_mgs.Text = "<< Data Base Error Message >>";
			this.lbl_err_mgs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_err_mgs
			// 
			this.txt_err_mgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_err_mgs.BackColor = System.Drawing.Color.White;
			this.txt_err_mgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_err_mgs.ForeColor = System.Drawing.Color.Black;
			this.txt_err_mgs.Location = new System.Drawing.Point(8, 552);
			this.txt_err_mgs.Multiline = true;
			this.txt_err_mgs.Name = "txt_err_mgs";
			this.txt_err_mgs.ReadOnly = true;
			this.txt_err_mgs.Size = new System.Drawing.Size(496, 81);
			this.txt_err_mgs.TabIndex = 49;
			this.txt_err_mgs.Text = "";
			// 
			// lbl_title
			// 
			this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_title.ForeColor = System.Drawing.Color.DarkBlue;
			this.lbl_title.Location = new System.Drawing.Point(512, 528);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(200, 23);
			this.lbl_title.TabIndex = 51;
			this.lbl_title.Text = "<< User Error Message >>";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.ForeColor = System.Drawing.Color.Black;
			this.textBox1.Location = new System.Drawing.Point(512, 552);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(496, 81);
			this.textBox1.TabIndex = 52;
			this.textBox1.Text = "";
			// 
			// Form_Proc_Error
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lbl_title);
			this.Controls.Add(this.lbl_err_mgs);
			this.Controls.Add(this.txt_err_mgs);
			this.Controls.Add(this.fgrid_Main);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_Proc_Error";
			this.Load += new System.EventHandler(this.Form_Proc_Error_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			this.Controls.SetChildIndex(this.txt_err_mgs, 0);
			this.Controls.SetChildIndex(this.lbl_err_mgs, 0);
			this.Controls.SetChildIndex(this.lbl_title, 0);
			this.Controls.SetChildIndex(this.textBox1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_date)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_div)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_Proc_Error_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{
			this.Text = "Procedure Error Check";
			this.lbl_MainTitle.Text = "Procedure Error List";


			oraDB = new OraDB();



			tbtn_Insert.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled  = false;
			tbtn_Print.Enabled  = false;
			tbtn_Save.Enabled   = false;
			
			DataTable dt_ret = COM.ComFunction.Select_Factory_List();
			ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false);
			cmb_Factory.SelectedValue = ComVar.This_Factory;


			dt_ret = Select_PROC_Date();
			ComCtl.Set_ComboList(dt_ret, cmb_date, 0, 0, true);
			cmb_date.Splits[0].DisplayColumns[0].Visible = false;
			cmb_date.SelectedIndex = 0;

			string aa = cmb_date.SelectedValue.ToString();



			dt_ret = oraDB.Select_ComCode(ComVar.This_Factory, "SPM01");
			ComCtl.Set_ComboList(dt_ret, cmb_div, 1, 2, true);
			cmb_div.Splits[0].DisplayColumns[0].Visible = false;
			cmb_div.SelectedIndex = 0;
			


			fgrid_Main.Set_Grid_Comm("SPM_ERR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Main.Set_Action_Image(img_Action);
			fgrid_Main.AutoSizeCols();
			_RowFixed = fgrid_Main.Rows.Count;




			if(autoview)
			{

				tbtn_New.Enabled = false;
				tbtn_Search.Enabled = false;
				tbtn_Save.Enabled = false;
				tbtn_Delete.Enabled = false;
				cmb_date.SelectedValue = selectdate;
				txt_proc.Text = selectspname;
				cmb_div.SelectedValue = selectwdiv;



				tbtn_Search_Click(null, null);

			}




		}





		#region DB접속

		private DataTable Select_PROC_Date()
		{

			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_PROC_DATE";

			//// DB에서 언어 Dictionary 추출
			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_UPD_USER";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = COM.ComVar.This_User;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		private DataTable Select_PROC_ERR1(string arg_division, string arg_date, string arg_sp_name, string arg_div)
		{

			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_PROC_ERR1";

			//// DB에서 언어 Dictionary 추출
			oraDB.ReDim_Parameter(7);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_ERR_YMD";
			oraDB.Parameter_Name[3] = "ARG_UPD_USER";
			oraDB.Parameter_Name[4] = "ARG_SP_NAME";
			oraDB.Parameter_Name[5] = "ARG_ERR_DIV";
			oraDB.Parameter_Name[6] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_division;
			oraDB.Parameter_Values[1] = ComVar.This_Factory;
			oraDB.Parameter_Values[2] = arg_date;
			oraDB.Parameter_Values[3] = ComVar.This_User;
			oraDB.Parameter_Values[4] = arg_sp_name;
			oraDB.Parameter_Values[5] = arg_div;
			oraDB.Parameter_Values[6] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}




		private DataTable Select_RPM_ERR(string arg_division, string arg_date, string arg_sp_name, string arg_div)
		{

			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_RPM_ERR";

			//// DB에서 언어 Dictionary 추출
			oraDB.ReDim_Parameter(7);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_ERR_YMD";
			oraDB.Parameter_Name[3] = "ARG_UPD_USER";
			oraDB.Parameter_Name[4] = "ARG_SP_NAME";
			oraDB.Parameter_Name[5] = "ARG_ERR_DIV";
			oraDB.Parameter_Name[6] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_division;
			oraDB.Parameter_Values[1] = ComVar.This_Factory;
			oraDB.Parameter_Values[2] = arg_date;
			oraDB.Parameter_Values[3] = ComVar.This_User;
			oraDB.Parameter_Values[4] = arg_sp_name;
			oraDB.Parameter_Values[5] = arg_div;
			oraDB.Parameter_Values[6] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}




		private bool Delete_PROC_ERR(string arg_division, string arg_date, string arg_sp_name, string arg_div)
		{

			try
			{
				string Proc_Name = "PKG_SPS_LOG_HIST.DELETE_PROC_ERR";

				//// DB에서 언어 Dictionary 추출
				oraDB.ReDim_Parameter(6);
				oraDB.Process_Name = Proc_Name ;


				oraDB.Parameter_Name[0] = "ARG_DIVISION";
				oraDB.Parameter_Name[1] = "ARG_FACTORY";
				oraDB.Parameter_Name[2] = "ARG_ERR_YMD";
				oraDB.Parameter_Name[3] = "ARG_UPD_USER";
				oraDB.Parameter_Name[4] = "ARG_SP_NAME";
				oraDB.Parameter_Name[5] = "ARG_ERR_DIV";

				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[5] = (int)OracleType.VarChar;

				oraDB.Parameter_Values[0] = arg_division;
				oraDB.Parameter_Values[1] = ComVar.This_Factory;
				oraDB.Parameter_Values[2] = arg_date;
				oraDB.Parameter_Values[3] = ComVar.This_User;
				oraDB.Parameter_Values[4] = arg_sp_name;
				oraDB.Parameter_Values[5] = arg_div;

				oraDB.Add_Modify_Parameter(true);
				oraDB.Exe_Modify_Procedure();
				
				return true;
			}
			catch
			{
				return false;
			}
		}

		#endregion

		#region 이벤트

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{


			fgrid_Main.Rows.Count = _RowFixed;
			

			if(cmb_date.SelectedIndex != 0)
			{
				cmb1 = "A";
			}
			else
			{
				cmb1 = "B";
			}

			if(txt_proc.Text.Trim().Length > 0)
			{
				cmb2 = "A";
			}
			else
			{
				cmb2 = "B";
			}

			if(cmb_div.SelectedIndex != 0)
			{
				cmb3 = "A";
			}
			else
			{
				cmb3 = "B";
			}

			division = cmb1+cmb2+cmb3;


			string date = "20051028";
//			try
//			{
				date = cmb_date.SelectedValue.ToString();
//			}
//			catch
//			{
//				date = "20051003";
//			}
			string spname = txt_proc.Text.ToUpper();
			string div = cmb_div.SelectedValue.ToString();

			DataTable dt;

			if(rpm_check == null)
			{
				dt = Select_PROC_ERR1(division, date, spname, div);
			}
			else
			{
				dt = Select_RPM_ERR(division, date, spname, div);
			}

			int RowCount = dt.Rows.Count;
			int ColCount = dt.Columns.Count;

			for(int i=0; i<RowCount; i++)
			{

				string[] ArrayItem = new string[13];
				ArrayItem[0]  = dt.Rows[i].ItemArray[0].ToString();
				ArrayItem[1]  = dt.Rows[i].ItemArray[1].ToString();
				ArrayItem[2]  = dt.Rows[i].ItemArray[2].ToString();

				string Job_cd = dt.Rows[i].ItemArray[3].ToString();
				string Div    = ":";
				string[] Split= Job_cd.Split(Div.ToCharArray());

				try
				{
					ArrayItem[3]  = Split[1];
				}
				catch
				{
					ArrayItem[3]  = "";
				}

				ArrayItem[4]  = dt.Rows[i].ItemArray[4].ToString();
				ArrayItem[5]  = dt.Rows[i].ItemArray[5].ToString();
				ArrayItem[6]  = dt.Rows[i].ItemArray[6].ToString();

				string Err_mgs= dt.Rows[i].ItemArray[7].ToString();
				if(Err_mgs.Length > 20)
				{
					Err_mgs = Err_mgs.Substring(0,18) + "..";
				}
				ArrayItem[7]  = Err_mgs;

				string Usr_mgs= dt.Rows[i].ItemArray[8].ToString();
				if(Usr_mgs.Length > 20)
				{
					Usr_mgs = Usr_mgs.Substring(0,20) + "..";
				}
				ArrayItem[8]  = Usr_mgs;

				ArrayItem[9]  = dt.Rows[i].ItemArray[9].ToString();
				ArrayItem[10] = dt.Rows[i].ItemArray[10].ToString();
				ArrayItem[11] = dt.Rows[i].ItemArray[7].ToString();
				ArrayItem[12] = dt.Rows[i].ItemArray[8].ToString();

				fgrid_Main.AddItem(ArrayItem, fgrid_Main.Rows.Count, 1);
			}



			for(int i = _RowFixed; i<fgrid_Main.Rows.Count; i++)
			{
				if(fgrid_Main[i,(int)COM.TBSPM_ERR.IxERR_DIV].ToString() == "E : Error")
				{
					fgrid_Main.GetCellRange(i,(int)COM.TBSPM_ERR.IxERR_DIV).StyleNew.ForeColor = Color.Red;
					fgrid_Main.GetCellRange(i,(int)COM.TBSPM_ERR.IxERR_MSG).StyleNew.ForeColor = Color.Red;
					fgrid_Main.GetCellRange(i,(int)COM.TBSPM_ERR.IxUSR_MSG).StyleNew.ForeColor = Color.Red;
				}
			}


			fgrid_Main.AutoSizeCols();


			if(fgrid_Main.Rows.Count <= _RowFixed)
			{
				ComFunction.Status_Bar_Message(ComVar.MgsNotHaveData, this);
			}
			else	
			{
				ComFunction.Status_Bar_Message(ComVar.MgsEndSearch, this);
			}



			
		}


		private void fgrid_Main_Click(object sender, System.EventArgs e)
		{
			txt_err_mgs.Text = "";
			textBox1.Text = "";

			int sct_row = fgrid_Main.Selection.r1;

			if(sct_row < _RowFixed)
				return;

			txt_err_mgs.Text =  fgrid_Main[sct_row, (int)COM.TBSPM_ERR.IxTemp].ToString().Replace("\n", "\r\n");
			textBox1.Text = fgrid_Main[sct_row, (int)COM.TBSPM_ERR.IxTemp_User].ToString();
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			if(fgrid_Main.Rows.Count <= _RowFixed)
			{
				ComFunction.Status_Bar_Message(ComVar.MgsDoNotDelete, this);
				return;
			}

			string date = cmb_date.SelectedValue.ToString();
			string spname = txt_proc.Text.ToUpper();
			string div = cmb_div.SelectedValue.ToString();


			string contents = "";

			contents = "Factory : " + ComVar.This_Factory + "\r\n";
			
			if(cmb_date.SelectedIndex != 0)
			{
				contents += "Error Date : " + cmb_date.SelectedValue.ToString() + "\r\n";
			}

			if(txt_proc.Text.Trim().Length > 0)
			{
				contents += "Procedure Name : " + txt_proc.Text + "\r\n"; 
			}

			if(cmb_div.SelectedIndex != 0)
			{
				contents += "Error Div : " + cmb_div.SelectedValue.ToString() + "\r\n";
			}


			contents += "Do you want to Delete This Log File?";



			DialogResult rs = ComFunction.User_Message(contents, "Delete", MessageBoxButtons.YesNo);
			if(rs == DialogResult.Yes)
			{


				Delete_PROC_ERR(division, date, spname, div);

				tbtn_Search_Click(null, null);
			}
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Main.Rows.Count = _RowFixed;
		}

		#endregion

	}
}

