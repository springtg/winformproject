using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdPlan
{
	public class Form_PO_LOT_MoldCapa : COM.APSWinForm.Form_Top
	{
		public System.Windows.Forms.Panel pnl_Search;
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
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_plan_ymd;
		private System.Windows.Forms.DateTimePicker dpick_Start;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_Stop;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_selectday;
		private System.Windows.Forms.Panel panel1;
		public COM.FSP fgrid_Style;
		public COM.FSP fgrid_Mold;
		public COM.FSP fgrid_Style_info;



		#region 사용자 변수
				
		private COM.OraDB oraDB = null;
		private int _IxGen_Value, _IxStart_Size, _IxTotal;
		private int _Ix_gen_s = 1;
		private int _Ix_gen_e = 6;
		private int _Ix_size_s = 5;
		private int _Ix_size_e = 0;
		private int fst_qty =0;
		private C1.Win.C1List.C1Combo cmb_selectday;
		//private int ignore = 0;
		private int col_width = 40;
		private int gen_width = 25;
		private int _BeforeSelCol = -1;
		private string model_info = "";
		private System.Windows.Forms.Label btn_Run;
		private System.Windows.Forms.ImageList img_MiniButton;
		private string mold_info = "";

		#endregion

		public Form_PO_LOT_MoldCapa()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_LOT_MoldCapa));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.btn_Run = new System.Windows.Forms.Label();
			this.cmb_selectday = new C1.Win.C1List.C1Combo();
			this.lbl_selectday = new System.Windows.Forms.Label();
			this.dpick_Stop = new System.Windows.Forms.DateTimePicker();
			this.lblexcep_mark = new System.Windows.Forms.Label();
			this.dpick_Start = new System.Windows.Forms.DateTimePicker();
			this.lbl_plan_ymd = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
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
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.fgrid_Mold = new COM.FSP();
			this.fgrid_Style = new COM.FSP();
			this.fgrid_Style_info = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_selectday)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Style_info)).BeginInit();
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
			this.pnl_Search.Controls.Add(this.btn_Run);
			this.pnl_Search.Controls.Add(this.cmb_selectday);
			this.pnl_Search.Controls.Add(this.lbl_selectday);
			this.pnl_Search.Controls.Add(this.dpick_Stop);
			this.pnl_Search.Controls.Add(this.lblexcep_mark);
			this.pnl_Search.Controls.Add(this.dpick_Start);
			this.pnl_Search.Controls.Add(this.lbl_plan_ymd);
			this.pnl_Search.Controls.Add(this.lbl_Factory);
			this.pnl_Search.Controls.Add(this.cmb_Factory);
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.Bottom = 5;
			this.pnl_Search.DockPadding.Left = 10;
			this.pnl_Search.DockPadding.Right = 10;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 72);
			this.pnl_Search.TabIndex = 43;
			// 
			// btn_Run
			// 
			this.btn_Run.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Run.ImageIndex = 0;
			this.btn_Run.ImageList = this.img_Button;
			this.btn_Run.Location = new System.Drawing.Point(585, 34);
			this.btn_Run.Name = "btn_Run";
			this.btn_Run.Size = new System.Drawing.Size(80, 23);
			this.btn_Run.TabIndex = 101;
			this.btn_Run.Text = "Run Proc";
			this.btn_Run.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
			this.btn_Run.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Run_MouseUp);
			this.btn_Run.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Run_MouseDown);
			// 
			// cmb_selectday
			// 
			this.cmb_selectday.AddItemCols = 0;
			this.cmb_selectday.AddItemSeparator = ';';
			this.cmb_selectday.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_selectday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_selectday.Caption = "";
			this.cmb_selectday.CaptionHeight = 17;
			this.cmb_selectday.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_selectday.ColumnCaptionHeight = 18;
			this.cmb_selectday.ColumnFooterHeight = 18;
			this.cmb_selectday.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_selectday.ContentHeight = 17;
			this.cmb_selectday.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_selectday.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_selectday.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_selectday.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_selectday.EditorHeight = 17;
			this.cmb_selectday.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_selectday.GapHeight = 2;
			this.cmb_selectday.ItemHeight = 15;
			this.cmb_selectday.Location = new System.Drawing.Point(788, 36);
			this.cmb_selectday.MatchEntryTimeout = ((long)(2000));
			this.cmb_selectday.MaxDropDownItems = ((short)(5));
			this.cmb_selectday.MaxLength = 32767;
			this.cmb_selectday.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_selectday.Name = "cmb_selectday";
			this.cmb_selectday.PartialRightColumn = false;
			this.cmb_selectday.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_selectday.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_selectday.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_selectday.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_selectday.Size = new System.Drawing.Size(150, 21);
			this.cmb_selectday.TabIndex = 82;
			// 
			// lbl_selectday
			// 
			this.lbl_selectday.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_selectday.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_selectday.ImageIndex = 0;
			this.lbl_selectday.ImageList = this.img_Label;
			this.lbl_selectday.Location = new System.Drawing.Point(688, 36);
			this.lbl_selectday.Name = "lbl_selectday";
			this.lbl_selectday.Size = new System.Drawing.Size(100, 21);
			this.lbl_selectday.TabIndex = 81;
			this.lbl_selectday.Text = "Select Date";
			this.lbl_selectday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_Stop
			// 
			this.dpick_Stop.CustomFormat = "";
			this.dpick_Stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Stop.Location = new System.Drawing.Point(486, 35);
			this.dpick_Stop.Name = "dpick_Stop";
			this.dpick_Stop.Size = new System.Drawing.Size(99, 22);
			this.dpick_Stop.TabIndex = 80;
			// 
			// lblexcep_mark
			// 
			this.lblexcep_mark.Location = new System.Drawing.Point(464, 35);
			this.lblexcep_mark.Name = "lblexcep_mark";
			this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblexcep_mark.Size = new System.Drawing.Size(22, 22);
			this.lblexcep_mark.TabIndex = 79;
			this.lblexcep_mark.Text = "~";
			this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dpick_Start
			// 
			this.dpick_Start.CustomFormat = "";
			this.dpick_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Start.Location = new System.Drawing.Point(365, 35);
			this.dpick_Start.Name = "dpick_Start";
			this.dpick_Start.Size = new System.Drawing.Size(99, 22);
			this.dpick_Start.TabIndex = 78;
			// 
			// lbl_plan_ymd
			// 
			this.lbl_plan_ymd.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_plan_ymd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_plan_ymd.ImageIndex = 0;
			this.lbl_plan_ymd.ImageList = this.img_Label;
			this.lbl_plan_ymd.Location = new System.Drawing.Point(264, 36);
			this.lbl_plan_ymd.Name = "lbl_plan_ymd";
			this.lbl_plan_ymd.Size = new System.Drawing.Size(100, 21);
			this.lbl_plan_ymd.TabIndex = 36;
			this.lbl_plan_ymd.Text = "Plan Date";
			this.lbl_plan_ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
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
			this.cmb_Factory.Size = new System.Drawing.Size(120, 21);
			this.cmb_Factory.TabIndex = 34;
			this.cmb_Factory.TextChanged += new System.EventHandler(this.cmb_Factory_TextChanged);
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
			this.lbl_SubTitle1.Text = "      Style Request Mold Info.";
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
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.fgrid_Mold);
			this.panel1.Controls.Add(this.fgrid_Style);
			this.panel1.Location = new System.Drawing.Point(8, 135);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1000, 377);
			this.panel1.TabIndex = 47;
			// 
			// fgrid_Mold
			// 
			this.fgrid_Mold.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Mold.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Mold.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_Mold.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Mold.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Mold.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Mold.Location = new System.Drawing.Point(0, 104);
			this.fgrid_Mold.Name = "fgrid_Mold";
			this.fgrid_Mold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Mold.Size = new System.Drawing.Size(1000, 273);
			this.fgrid_Mold.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Mold.TabIndex = 47;
			this.fgrid_Mold.Click += new System.EventHandler(this.fgrid_Click);
			this.fgrid_Mold.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Mold_AfterScroll);
			// 
			// fgrid_Style
			// 
			this.fgrid_Style.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_Style.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_Style.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Style.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Style.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_Style.Dock = System.Windows.Forms.DockStyle.Top;
			this.fgrid_Style.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Style.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Style.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Style.Name = "fgrid_Style";
			this.fgrid_Style.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.fgrid_Style.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Style.Size = new System.Drawing.Size(1000, 104);
			this.fgrid_Style.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Style.TabIndex = 46;
			this.fgrid_Style.Visible = false;
			this.fgrid_Style.Click += new System.EventHandler(this.fgrid_Click);
			this.fgrid_Style.AfterResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Style_AfterResizeColumn);
			this.fgrid_Style.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Mold_AfterScroll);
			// 
			// fgrid_Style_info
			// 
			this.fgrid_Style_info.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_Style_info.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_Style_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Style_info.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Style_info.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Style_info.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_Style_info.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Style_info.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Style_info.Location = new System.Drawing.Point(8, 520);
			this.fgrid_Style_info.Name = "fgrid_Style_info";
			this.fgrid_Style_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.fgrid_Style_info.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Style_info.Size = new System.Drawing.Size(1000, 120);
			this.fgrid_Style_info.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Style_info.TabIndex = 48;
			this.fgrid_Style_info.Click += new System.EventHandler(this.fgrid_Style_info_Click);
			this.fgrid_Style_info.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Mold_AfterScroll);
			// 
			// Form_PO_LOT_MoldCapa
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_Style_info);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_PO_LOT_MoldCapa";
			this.Text = "Mold Capa";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.From_PO_LOT_MoldCapa_Load);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.fgrid_Style_info, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_selectday)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Style_info)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 컬럼 자동 소트 클래스

		/// <summary>
		/// MyComparer
		/// compares two grid rows using all columns
		/// </summary>
		public class MyComparer : IComparer
		{
			C1FlexGrid _flex;
			public MyComparer(C1FlexGrid flex)
			{
				_flex = flex;
			}
			int IComparer.Compare(object x, object y)
			{
				// get row indices
				int r1 = ((Row)x).Index;
				int r2 = ((Row)y).Index;

				// scan all columns looking for differences
				for (int c = 0; c < _flex.Cols.Count; c++)
				{
					// get display values
					string s1 = _flex.GetDataDisplay(r1, c);
					string s2 = _flex.GetDataDisplay(r2, c);

					// compare, done when a difference is found
					int cmp = string.Compare(s1, s2);
					if (cmp != 0) return cmp;
				}

				// all values are the same, use row indices
				// to keep sort stable
				return r1 - r2;
			}
		}


		#endregion 

		#region 사용자 메소드

		private void Init_Form()
		{
			this.Text = "Request Mold Check";
			this.lbl_MainTitle.Text = "Request Mold Check";

			ClassLib.ComFunction.SetLangDic(this);

			#region 버튼 권한

//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//			}
//			catch
//			{
//			}

			#endregion


			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Save.Enabled = false;

			
			oraDB = new COM.OraDB();

			//Fastroy ComboBox Setting
			DataTable dt_list = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1,false,COM.ComVar.ComboList_Visible.Code);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;


			//작업일 선택 기간
			COM.ComFunction cfun = new COM.ComFunction();
			//dpick_Start.Text = cfun.ConvertDate2Type(ClassLib.ComVar.This_FormDate);//cfun.ConvertDate2Type(Select_NextWorkDay().Rows[0].ItemArray[2].ToString());
			//dpick_Stop.Text  = cfun.ConvertDate2Type(ClassLib.ComVar.This_ToDate);//DateTime.Now.Add(System.TimeSpan.FromDays(+7));


			dpick_Start.Text = cfun.ConvertDate2Type(Select_NextWorkDay().Rows[0].ItemArray[2].ToString());
			dpick_Stop.Value = DateTime.Now.AddDays(7);

			dpick_Start.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_Stop.CustomFormat  = ClassLib.ComVar.This_SetedDateType;



			//작업일 선택
			dt_list = Select_Plan_YMD(cmb_Factory.SelectedValue.ToString());
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_selectday, 0, 1,true);
			cmb_selectday.Splits[0].DisplayColumns["Code"].Width = 0;


			int selectIndex = 0;
			if(dt_list.Rows.Count > 0)
				selectIndex = 1;
			
			cmb_selectday.SelectedIndex = selectIndex; 
			cmb_selectday.Splits[0].DisplayColumns[1].Width = 0;




			//스타일 그리드
			fgrid_Style.Set_Grid("SPO_MOLD_CAPA", "3", 1, ClassLib.ComVar.This_Lang, false); 
			Set_Gender_Grid(fgrid_Style);

			fgrid_Style.Cols.Frozen = 5; 

			fgrid_Style.ScrollBars = ScrollBars.None;

			for(int i = (int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGR_GEN+1; i < fgrid_Style.Cols.Count; i++)
			{
				fgrid_Style.Cols[i].AllowEditing = false;
			}


			fgrid_Mold.Set_Grid("SPO_MOLD_CAPA", "4", 1, ClassLib.ComVar.This_Lang, false);
			fgrid_Mold.Set_Action_Image(img_Action);
			Set_Gender_Grid(fgrid_Mold);

			fgrid_Mold.Styles.Alternate.BackColor = Color.White;

			fgrid_Mold.Cols.Frozen = 5; 


			for(int i = (int)ClassLib.TBSPO_TMP_LOT_MOLD.IxFACTORY; i <= fgrid_Mold.Cols.Count-1; i++)
			{
				fgrid_Mold.Cols[i].AllowEditing = false;
			}


			//스타일 그리드
			fgrid_Style_info.Set_Grid("SPO_MOLD_CAPA", "3", 1, ClassLib.ComVar.This_Lang, false); 
			Set_Gender_Grid(fgrid_Style_info);

			fgrid_Style_info.Cols.Frozen = 5;


			_Ix_size_e = fgrid_Style.Cols.Count-1;




			if(COM.ComVar.PlanMoldCapacity_Plan_Date.Trim().Length > 0)
			{
				try
				{
					cmb_selectday.SelectedValue = COM.ComVar.PlanMoldCapacity_Plan_Date.Trim();
					tbtn_Search_Click(null, null);

				}
				catch
				{
				}
			}
		}



		/// <summary>
		/// Set_Gender_Grid : 
		/// </summary>
		/// <param name="arg_fgrid"></param>
		private void Set_Gender_Grid(C1FlexGrid arg_fgrid)
		{
			
			DataTable dt_list;
			DataTable dt_size_list;

			string[] new_data = new string[arg_fgrid.Cols.Count]; 
			
			int size_count = 0;

			

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

 			

			//------------------------------------------------
			//젠더 입력

			_IxGen_Value = 4;//(int)ClassLib.TBSPO_STYLE_SIZE.IxSTYLE_CD;

			arg_fgrid.Cols.Insert(_IxGen_Value);

			for(int i = 0; i < dt_list.Rows.Count; i++)
			{				
				
				arg_fgrid[i + 1, _IxGen_Value] = dt_list.Rows[i].ItemArray[3].ToString();

				//------------------------------------------------------------------
				if(arg_fgrid[i + 1, _IxGen_Value].ToString() == "ME" )continue;
					//|| arg_fgrid[i + 1, _IxGen_Value].ToString() == "WO") continue;

				arg_fgrid.Rows[i + 1].Visible = false;
 
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
		}



		private void Style_Grid_Setting(C1FlexGrid arg_fgrid, string arg_factory, string arg_select_ymd)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;

			DataTable dt;
			dt = Select_Mold_Style_Info( arg_factory, arg_select_ymd );
			
			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;
			int colsTotal = 0;


			string new_ymd = "";

			string new_data = "";
			string old_data = "";


			for(int mgen=_Ix_gen_s; mgen<_Ix_gen_e; mgen++)
			{
				fgrid_Style_info.Rows[mgen].Visible = false;
			}

			for(int i=0; i<rowcount; i++)
			{
				new_data = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxPLAN_YMD].ToString() + dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxMOLDE_CD].ToString() + dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxSTYLE_CD].ToString();
				new_ymd  = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxPLAN_YMD].ToString();
				
				if(old_data != new_data)
				{
					colsTotal = 0;
					arg_fgrid.Rows.Add();
					
					arg_fgrid[arg_fgrid.Rows.Count-1, (int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGR_PLAN_YMD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxPLAN_YMD].ToString();
					arg_fgrid[arg_fgrid.Rows.Count-1, (int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGR_MODEL_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxMOLDE_CD].ToString();

					
					arg_fgrid[arg_fgrid.Rows.Count-1, (int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGR_STYLE_CD ] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxSTYLE_CD].ToString();
					arg_fgrid[arg_fgrid.Rows.Count-1, (int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGR_GEN ] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGEN].ToString();   

					Style_Size_Sitting(arg_fgrid, dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGEN].ToString(), dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxCS_SIZE].ToString(), arg_fgrid.Rows.Count-1, dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxSIZE_QTY].ToString());
					colsTotal += int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxSIZE_QTY].ToString());



					Show_Mold_Gender(fgrid_Style_info,  dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGEN].ToString());
					old_data = new_data;
				}
				else
				{
					Style_Size_Sitting(arg_fgrid, dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGEN].ToString(), dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxCS_SIZE].ToString(), arg_fgrid.Rows.Count-1, dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxSIZE_QTY].ToString());
					colsTotal += int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxSIZE_QTY].ToString());
					arg_fgrid[arg_fgrid.Rows.Count-1,arg_fgrid.Cols.Count-1] = colsTotal.ToString();

				}
			}


			
			arg_fgrid.Rows.Add();
			arg_fgrid[arg_fgrid.Rows.Count-1, (int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGR_STYLE_CD] = "Total Qty";


			for(int i=_Ix_size_s; i<_Ix_size_e+1; i++)
			{
				int tot_qty = 0;

				for(int j=_Ix_gen_e; j<arg_fgrid.Rows.Count-1; j++)
				{	
					try
					{
						if(arg_fgrid[j,i].ToString() != "")
						{
							tot_qty += int.Parse(arg_fgrid[j,i].ToString());
							arg_fgrid[arg_fgrid.Rows.Count-1, i] = tot_qty.ToString();
						}
					}
					catch
					{
						if(arg_fgrid[j,i] != null)
						{
							tot_qty += int.Parse(arg_fgrid[j,i].ToString());
							arg_fgrid[arg_fgrid.Rows.Count-1, i] = tot_qty.ToString();
						}
					}
				}					
			}

			int total_row = fgrid_Style_info.Rows.Count-1;
			int style_order_qty = 0;
			
			for(int j=_Ix_size_s; j<_Ix_size_e; j++)
			{
				int style_size_order_qty = 0;

				try
				{
					style_size_order_qty = int.Parse(fgrid_Style_info[total_row, j].ToString());
				}
				catch
				{
					style_size_order_qty = 0;
				}

				style_order_qty += style_size_order_qty;
			}

			fgrid_Style_info[total_row, _IxTotal] = style_order_qty.ToString();
		}


		private void Style_Size_Sitting(C1FlexGrid arg_fgrid, string arg_gen, string arg_cs_size, int arg_rows, string arg_size_qty)
		{
			int i, j;
			for(i=_Ix_gen_s; i<_Ix_gen_e; i++)
			{
				if(arg_fgrid[i,(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGR_GEN].ToString() == arg_gen)
				{
					for(j=_Ix_size_s; j<_Ix_size_e; j++)
					{
						if(arg_fgrid[i,j].ToString() == arg_cs_size)
						{
							arg_fgrid[arg_rows, j] = arg_size_qty;
						}
						else
						{
							if(arg_fgrid[arg_rows, j] == null)
							{
								//fgrid_Style[arg_rows, j] = "0";
								arg_fgrid[arg_rows, j] = "";
							}
						}
					}
				}
			}
		}


		private void Mold_Grid_Setting(string arg_factory, string arg_select_ymd)
		{
			_BeforeSelCol = -1;


			int rownum = 0;

			fgrid_Mold.Rows.Count = _Ix_gen_e;

			DataTable dt = Select_Mold_Info( arg_factory, arg_select_ymd );
			
			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;


			string msize_yn = "";



			string new_data = "";
			string old_data = "";


			for(int i=0; i<rowcount; i++)
			{
				new_data = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxPLAN_YMD].ToString() + 
					dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxMOLD_CD].ToString();

				if(old_data != new_data)
				{
					fgrid_Mold.Rows.Add();

					rownum = fgrid_Mold.Rows.Count-1;

					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();
					fgrid_Mold.Rows.Add();

					int mold_cd       = fgrid_Mold.Rows.Count-11;
					int mold_qty_rate = fgrid_Mold.Rows.Count-10;
					int mold_pairs    = fgrid_Mold.Rows.Count-9;
					int mold_avail    = fgrid_Mold.Rows.Count-8;
					int mold_cycle    = fgrid_Mold.Rows.Count-7;
					int mold_day_capa = fgrid_Mold.Rows.Count-6;
					int mold_rate     = fgrid_Mold.Rows.Count-5;
					int req_mold_qty  = fgrid_Mold.Rows.Count-4;
					int shortage_mold = fgrid_Mold.Rows.Count-3;
					int real_capa     = fgrid_Mold.Rows.Count-2;
					int div_line      = fgrid_Mold.Rows.Count-1;


					fgrid_Mold[mold_qty_rate,0] = "H";
					fgrid_Mold[mold_pairs,0]    = "H";
					fgrid_Mold[mold_avail,0]    = "H";

					fgrid_Mold[mold_cd,       (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_PLAN_YMD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxPLAN_YMD].ToString();


					for(int j=2; j<12; j++)
					{
						fgrid_Mold[fgrid_Mold.Rows.Count - j, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_DIVISION] = rownum.ToString();
						fgrid_Mold[fgrid_Mold.Rows.Count - j, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_MODEL_CD] =dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxMOLD_NAME].ToString();
					}

					fgrid_Mold[div_line, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_MODEL_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxMOLD_NAME].ToString();



					if(dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxMUSE_YN].ToString() == "Y")
					{
						msize_yn = "(M)";
					}
					else
					{
						msize_yn = "";
					}

					fgrid_Mold[mold_cd, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_STYLE_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxMOLD_CD].ToString() + msize_yn;
					fgrid_Mold[mold_cd, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_GEN] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxMOLD_GEN].ToString();

					fgrid_Mold[mold_qty_rate, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_STYLE_CD] = "MOLD QTY RATE";
					fgrid_Mold[mold_pairs, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_STYLE_CD]    = "PRS/SET";
					fgrid_Mold[mold_avail, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_STYLE_CD]    = "PAIRS/PRESS";
					fgrid_Mold[mold_cycle, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_STYLE_CD]    = "Cycle";
					fgrid_Mold[mold_day_capa, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_STYLE_CD] = "Mold Capacity";
					fgrid_Mold[mold_rate, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_STYLE_CD]     = "Order QTY";
					fgrid_Mold[req_mold_qty, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_STYLE_CD]  = "Request QTY";
					fgrid_Mold[shortage_mold, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_STYLE_CD] = "REQUEST MOLD";
					fgrid_Mold[real_capa, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_STYLE_CD]     = "MAX CAPA";


					fgrid_Mold.Rows[mold_qty_rate].Height = 0;
					fgrid_Mold.Rows[mold_avail].Height = 0;
					fgrid_Mold.Rows[shortage_mold].Height = 0;
					fgrid_Mold.Rows[real_capa].Height = 0;



					



					CellStyle cellst2 = fgrid_Mold.Styles.Add("ROW_MOLD_CD");
					cellst2.TextAlign = TextAlignEnum.RightCenter;
					cellst2.BackColor = Color.Lavender;
								
				
					fgrid_Mold.Rows[mold_cd].Style = fgrid_Mold.Styles["ROW_MOLD_CD"];

								
					CellStyle cellst1 = fgrid_Mold.Styles.Add("ALIGN");
					cellst1.TextAlign = TextAlignEnum.RightCenter;

					fgrid_Mold.Rows[mold_qty_rate].Style = fgrid_Mold.Styles["ALIGN"];
					fgrid_Mold.Rows[mold_pairs].Style    = fgrid_Mold.Styles["ALIGN"];
					fgrid_Mold.Rows[mold_avail].Style    = fgrid_Mold.Styles["ALIGN"];
					fgrid_Mold.Rows[mold_cycle].Style    = fgrid_Mold.Styles["ALIGN"];
					fgrid_Mold.Rows[mold_day_capa].Style = fgrid_Mold.Styles["ALIGN"];
					fgrid_Mold.Rows[mold_rate].Style     = fgrid_Mold.Styles["ALIGN"];
					fgrid_Mold.Rows[req_mold_qty].Style  = fgrid_Mold.Styles["ALIGN"];
					fgrid_Mold.Rows[real_capa].Style     = fgrid_Mold.Styles["ALIGN"];

					fgrid_Mold.Rows[div_line].StyleNew.BackColor = Color.FromArgb(194, 194, 194);
					fgrid_Mold.Rows[div_line].Height = 3;

					Show_Mold_Gender(fgrid_Mold,  dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxMOLD_GEN].ToString());

					old_data = new_data;
				}


				

				string[] ArrayItem = new string[14];
				ArrayItem[0] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxMOLD_GEN].ToString();
				ArrayItem[1] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxCS_SIZE].ToString();
				ArrayItem[2] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxSUM_QTY].ToString();
				ArrayItem[3] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxPAIRS].ToString();
				ArrayItem[4] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxAVAIL_PAIRS].ToString();
				ArrayItem[5] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxCYCLE].ToString();
				ArrayItem[6] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxDAY_CAPA].ToString();
				ArrayItem[7] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxFST_SIZE].ToString();
				ArrayItem[8] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxMUSE_YN].ToString();
				ArrayItem[9] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxMOLD_CD].ToString();
				ArrayItem[10] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxSTYLE_QTY].ToString();

				ArrayItem[11] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxREQUEST].ToString();
				ArrayItem[12] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxNECK_CAPA].ToString();
				ArrayItem[13] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxREQ_MOLD].ToString();


				Mold_Size_Sitting(ArrayItem);
			}
		}


		private void Mold_Size_Sitting(string[] arg_arrayitem)
		{
			int i, j;

			int mold_cd       = fgrid_Mold.Rows.Count-11;
			int mold_qty_rate = fgrid_Mold.Rows.Count-10;
			int mold_pairs    = fgrid_Mold.Rows.Count-9;
			int mold_avail    = fgrid_Mold.Rows.Count-8;
			int mold_cycle    = fgrid_Mold.Rows.Count-7;
			int mold_day_capa = fgrid_Mold.Rows.Count-6;
			int mold_rate     = fgrid_Mold.Rows.Count-5;
			int req_mold_qty  = fgrid_Mold.Rows.Count-4;
			int shortage_mold = fgrid_Mold.Rows.Count-3;
			int real_capa     = fgrid_Mold.Rows.Count-2;
			int div_line      = fgrid_Mold.Rows.Count-1;




			System.Drawing.Color font_color = Color.Black; 

			for(i=_Ix_gen_s; i<_Ix_gen_e; i++)
			{
				if(fgrid_Mold[i,(int)ClassLib.TBSPO_TMP_LOT_MOLD.IxGR_GEN].ToString() == arg_arrayitem[0])
				{
					for(j=_Ix_size_s; j<_Ix_size_e; j++)
					{
						if(fgrid_Mold[i,j].ToString() == arg_arrayitem[1])
						{	
							fgrid_Mold[mold_cd, j] = arg_arrayitem[2];
							fst_qty = int.Parse(arg_arrayitem[2]);
							fgrid_Mold[shortage_mold,j]  = arg_arrayitem[13];


							fgrid_Mold[mold_pairs, j]    = arg_arrayitem[3];
							fgrid_Mold[mold_avail, j]    = arg_arrayitem[4];
							fgrid_Mold[mold_cycle, j]    = arg_arrayitem[5];
							fgrid_Mold[mold_day_capa, j] = arg_arrayitem[6];
							fgrid_Mold[mold_rate,j]      = arg_arrayitem[10];
							fgrid_Mold[req_mold_qty,j]   = arg_arrayitem[11];
							fgrid_Mold[real_capa,j]      = arg_arrayitem[12];	
							
							if(int.Parse(arg_arrayitem[11]) >= 0)
								font_color = Color.Blue;
							else
								font_color = Color.Red;


							fgrid_Mold.GetCellRange(req_mold_qty,j).StyleNew.ForeColor =  font_color;
							fgrid_Mold.GetCellRange(shortage_mold,j).StyleNew.ForeColor =  font_color;

							CellStyle cellst = fgrid_Mold.Styles.Add("BOLD");
							cellst.TextAlign = TextAlignEnum.RightCenter;
							cellst.BackColor = Color.FromArgb(251, 248, 185);
							


							CellStyle cellst1 = fgrid_Mold.Styles.Add("REAL");
							cellst1.BackColor = Color.FromArgb(251, 248, 185);
							fgrid_Mold.Rows[req_mold_qty].Style = fgrid_Mold.Styles["REAL"];


							fgrid_Mold.GetCellRange(mold_cd,(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_MODEL_CD).StyleNew.BackColor =  Color.FromArgb(245, 245, 220);
							fgrid_Mold.GetCellRange(req_mold_qty,(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_MODEL_CD).StyleNew.BackColor =  Color.FromArgb(245, 245, 220);
							fgrid_Mold.GetCellRange(div_line,(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_MODEL_CD).StyleNew.BackColor =  Color.FromArgb(245, 245, 220);
//							fgrid_Mold.GetCellRange(mold_rate,(int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_MODEL_CD).StyleNew.BackColor =   Color.FromArgb(245, 245, 220);
						}
					}
					return;
				}
			}	
		}


		/// <summary>
		/// Show_Mold_Gender : 특정 몰드 젠더만 보여줌
		/// </summary>
		/// <param name="arg_fgrid">그리드 이름</param>
		/// <param name="gen">특정 젠더</param>
		private void Show_Mold_Gender(C1FlexGrid arg_fgrid,  string gen)
		{
			int mgen;

			//헤드 부분 동일 gen만 보여줌
			for(mgen = _Ix_gen_s; mgen<_Ix_gen_e; mgen++)
			{
				if(gen == arg_fgrid[mgen, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_GEN].ToString())
				{
					arg_fgrid.Rows[mgen].Visible = true;
				}
			}
		}



		/// <summary>
		/// Select_Row_Color : 선택한 젠더에 따른 헤드 사이즈 선택하기
		/// </summary>
		/// <param name="arg_fgrid">그리드 이름</param>
		/// <param name="gen">젠더</param>
		/// <param name="arg_red">red</param>
		/// <param name="arg_green">green</param>
		/// <param name="arg_blue">blue</param>
		private void Select_Row_Color(C1FlexGrid arg_fgrid,  string gen, int arg_red, int arg_green, int arg_blue)
		{
			_Ix_size_e = fgrid_Mold.Cols.Count-2;
			for(int mgen = _Ix_gen_s; mgen<_Ix_gen_e; mgen++)
			{
				if(gen == arg_fgrid[mgen, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_GEN].ToString())
				{
					arg_fgrid.GetCellRange(mgen, _Ix_size_s, mgen, _Ix_size_e).StyleNew.BackColor = Color.FromArgb(arg_red, arg_green, arg_blue);
				}
				else
				{
					arg_fgrid.GetCellRange(mgen, _Ix_size_s, mgen, _Ix_size_e).StyleNew.BackColor = Color.FromArgb(135,179,234);
				}
			}
		}



		private string Fst_Size_Qty(string arg_mold_cd, string arg_fst_size, string arg_cs_size)
		{
			string arg_factory = cmb_Factory.SelectedValue.ToString();
			string arg_select_ymd = cmb_selectday.SelectedValue.ToString();
			
			
			DataTable dt = Select_Fst_Size(arg_factory, arg_select_ymd, arg_mold_cd, arg_fst_size, arg_cs_size);

			return dt.Rows[0].ItemArray[0].ToString();
		}



		private void Show_Hide_Row(bool arg_bool)
		{

			for(int i=_Ix_gen_e; i<fgrid_Mold.Rows.Count; i++)
			{
				if(fgrid_Mold[i,0] != null)
				{
					fgrid_Mold.Rows[i].Visible = arg_bool;
				}
			}
		}


		/// <summary>
		/// Clear_Form : 초기화
		/// </summary>
		private void Clear_Form()
		{
			fgrid_Mold.Rows.Count = _Ix_gen_e;
			fgrid_Style.Rows.Count = _Ix_gen_e;
			fgrid_Style_info.Rows.Count = _Ix_gen_e;

			cmb_selectday.SelectedIndex = -1;
		}


	

		#endregion

		#region 이벤트

		/// <summary>
		/// 폼이 로드 될때 발생
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void From_PO_LOT_MoldCapa_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		
		/// <summary>
		/// Search버튼 클릭시
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(cmb_selectday.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Work Plan Date!!");
				cmb_selectday.Focus();
				return;
			}
			this.Cursor = Cursors.WaitCursor;

			//fgrid_Mold 헤드 부분 초기화
			for(int mgen=_Ix_gen_s; mgen<_Ix_gen_e; mgen++)
			{
				fgrid_Mold.Rows[mgen].Visible = false;
			}

			Mold_Grid_Setting(cmb_Factory.SelectedValue.ToString(), cmb_selectday.SelectedValue.ToString());





			
			

			for(int sum_row = 12; sum_row<fgrid_Mold.Rows.Count; sum_row += 11)
			{
				int mold_order_qty = 0;
				for(int col=_Ix_size_s; col<_Ix_size_e; col++)
				{
					int mold_size_order_qty = 0;
					
					try
					{ 
						mold_size_order_qty = int.Parse(fgrid_Mold[sum_row, col].ToString()); 
					}
					catch
					{ 
						mold_size_order_qty = 0; 
					}

					mold_order_qty += mold_size_order_qty;
				}
				fgrid_Mold[sum_row, _IxTotal] = mold_order_qty.ToString();
			}



			fgrid_Mold.AllowMerging = AllowMergingEnum.Free;
			fgrid_Mold.Cols[2].AllowMerging = true;


			///Show_Hide_Row(false);
			///

//			fgrid_Mold.AllowMerging = AllowMergingEnum.FixedOnly;
//
//			for(int i = 1; i <= _IxGen_Value; i++)
//			{
//				fgrid_Mold.Cols[i].AllowMerging = true;
//			}
//
//			fgrid_Mold.Cols[_IxTotal].AllowMerging = true;
			
			this.Cursor = Cursors.Default;
		}

		private void btn_Run_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			COM.ComFunction cfun = new COM.ComFunction();
			Run_Proc(cmb_Factory.SelectedValue.ToString(), cfun.ConvertDate2DbType(dpick_Start.Text), cfun.ConvertDate2DbType(dpick_Stop.Text));


			//작업일 선택
			DataTable dt_list = Select_Plan_YMD(cmb_Factory.SelectedValue.ToString());
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_selectday, 0, 1,true);

			int selectIndex = 0;

			if(dt_list.Rows.Count > 0)
				selectIndex = 1;

			cmb_selectday.SelectedIndex = selectIndex;
			cmb_selectday.Splits[0].DisplayColumns[0].Width = 0;

			this.Cursor = Cursors.Default;
		}


		/// <summary>
		/// 공장 콤보 박스 선택시
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmb_Factory_TextChanged(object sender, System.EventArgs e)
		{

			Clear_Form();


			DataTable dt_list = Select_Plan_YMD(cmb_Factory.SelectedValue.ToString());
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_selectday, 0, 0,true);

			int selectIndex = 0;
			if(dt_list.Rows.Count > 0)
				selectIndex = 1;
			
			cmb_selectday.SelectedIndex = selectIndex; 
			cmb_selectday.Splits[0].DisplayColumns[1].Width = 0;
		}

		private void fgrid_Style_AfterResizeColumn(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Mold.Cols[e.Col].Width = fgrid_Style.Cols[e.Col].Width;
		}


		private void fgrid_Click(object sender, System.EventArgs e)
		{
			try
			{
				int sct_row = fgrid_Mold.Selection.r1;
				int sct_col = fgrid_Mold.Selection.c1;

				if(sct_row < _Ix_gen_e) return;


				int rownum = int.Parse(fgrid_Mold[sct_row, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_DIVISION].ToString());

				try
				{
					int row_num = 0;

					string sct_gen = fgrid_Mold[rownum, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_GEN].ToString();

					for(int i=_Ix_gen_s; i<_Ix_gen_e; i++)
					{
						fgrid_Mold.GetCellRange(i,_Ix_size_s,i,_Ix_size_e).StyleNew.BackColor = COM.ComVar.GridLightFixed_Color;
						fgrid_Mold.GetCellRange(i,_Ix_size_s,i,_Ix_size_e).StyleNew.ForeColor = Color.White;

						if(fgrid_Mold[i, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_GEN].ToString() == sct_gen)
						{
							row_num = i;
						}
					}

					fgrid_Mold.GetCellRange(row_num,_Ix_size_s,row_num,_Ix_size_e).StyleNew.BackColor = Color.FromArgb(251, 248, 185);//COM.ComVar.GridDarkFixed_Color;
					fgrid_Mold.GetCellRange(row_num,_Ix_size_s,row_num,_Ix_size_e).StyleNew.ForeColor = Color.Black;
				}
				catch
				{
				}

				try
				{
					//int rownum = int.Parse(fgrid_Mold[sct_row, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_DIVISION].ToString());


					//FACTORY
					string factory = cmb_Factory.SelectedValue.ToString();

					//PLAN_YMD
					string plan_ymd = fgrid_Mold[rownum, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_PLAN_YMD].ToString();

					//MODEL_CD
					model_info =  fgrid_Mold[rownum, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_MODEL_CD].ToString();

					//Mold CD
					string v_mold_cd = fgrid_Mold[rownum, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_STYLE_CD].ToString();
					mold_info = v_mold_cd.Trim().Substring(0,5);

					Style_Grid_Setting(fgrid_Style_info,cmb_Factory.SelectedValue.ToString(), cmb_selectday.SelectedValue.ToString());


					for(int i=0; i<fgrid_Style_info.Rows.Count; i++)
					{
						fgrid_Style_info.Rows[i].AllowEditing = false;
					}

					int style_order = fgrid_Style_info.Rows.Count-1;

					fgrid_Style_info.Rows[style_order].StyleNew.BackColor = Color.FromArgb(251, 248, 185);
					fgrid_Style_info.GetCellRange(style_order, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_GEN, style_order, fgrid_Style_info.Cols.Count-1).StyleNew.ForeColor = Color.Blue;
				}
				catch
				{
				}
			}
			catch
			{
			}

		}



		/// <summary>
		/// Clear버튼 클릭시 발생
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Form_Clear();
		}

		public void Form_Clear()
		{
			fgrid_Mold.Rows.Count = _Ix_gen_e;
			fgrid_Style.Rows.Count = _Ix_gen_e;
			fgrid_Style_info.Rows.Count = _Ix_gen_e;
		}
		


		private void fgrid_Style_info_Click(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_Style_info.Selection.r1;
			int cst_col = fgrid_Style_info.Selection.c1;

			try
			{
				string mgen = fgrid_Style_info[sct_row, (int)ClassLib.TBSPO_TMP_LOT_MOLD_INFO.IxGR_GEN].ToString();
				Select_Row_Color(fgrid_Style_info, mgen, 122, 160, 200);
			}
			catch
			{
			}
		}

		private void btn_Run_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Run.ImageIndex =1;
		}

		private void btn_Run_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Run.ImageIndex =0;
		}

		private void btn_moldstatus_Click(object sender, System.EventArgs e)
		{
//			Pop_Check_MoldStatus show_MoldStatus = new Pop_Check_MoldStatus(this);
//			show_MoldStatus.ShowDialog();
		}
		
		#endregion

        #region 스크롤 동기화 작업

		// synchronize grid scrolling
		bool _synchronizing = false;

		private void fgrid_Mold_AfterScroll(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			 
			if (!_synchronizing)
			{
				// avoid reentrant calls
				_synchronizing = true;

				// get new scrollposition for sender control
				C1FlexGrid src = sender as C1FlexGrid;
				src.Update();
				Point pt = src.ScrollPosition;

				// apply to others
				if (src.Equals(this.fgrid_Style))
				{ 
					fgrid_Mold.ScrollPosition = new Point(pt.X, fgrid_Mold.ScrollPosition.Y);
				}
				 
				else if (src.Equals(this.fgrid_Mold))
				{
					fgrid_Style.ScrollPosition = new Point(pt.X, fgrid_Style.ScrollPosition.Y); 
					fgrid_Style_info.ScrollPosition = new Point(pt.X, fgrid_Style.ScrollPosition.Y); 
				}
				 

				// done
				_synchronizing = false;

			} // end if
			 
		}
		#endregion

		#region DB 접속

		/// <summary>
		/// Select_Gen_Size : 
		/// </summary>
		/// <param name="arg_gen"></param>
		/// <returns></returns>
		private DataTable Select_Gen_Size(string arg_gen)
		{
			string Proc_Name = "PKG_SPO_ORDER_MOLD.SELECT_MOLD_SIZE1";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_GEN";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = arg_gen;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// 작업 날짜를 가져온다.
		/// </summary>
		/// <returns></returns>
		public DataTable Select_Plan_YMD(string arg_factory)
		{

			COM.OraDB MyoraDB = new COM.OraDB();

			string Proc_Name = "PKG_SPO_LOT_MOLD_CHECK.SELECT_PLAN_YMD";

			MyoraDB.ReDim_Parameter(2);
			MyoraDB.Process_Name = Proc_Name ;


			MyoraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyoraDB.Parameter_Name[0] = "OUT_CURSOR";

			MyoraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyoraDB.Parameter_Type[0] = (int)OracleType.Cursor;

			MyoraDB.Parameter_Values[1] = arg_factory;
			MyoraDB.Parameter_Values[0] = "";

			MyoraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyoraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// 몰드 계산 프로시져 실행
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_s_plan_ymd"></param>
		/// <param name="arg_e_plan_ymd"></param>
		private void Run_Proc(string arg_factory, string arg_s_plan_ymd, string arg_e_plan_ymd)
		{

			string Proc_Name = "SP_SPO_MOLD_CHECK";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_S_PLAN_YMD";
			oraDB.Parameter_Name[2] = "ARG_E_PLAN_YMD";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_s_plan_ymd;
			oraDB.Parameter_Values[2] = arg_e_plan_ymd;

			oraDB.Add_Run_Parameter(true);
			oraDB.Exe_Run_Procedure();
		}



		private DataTable Select_Style_Info(string arg_factory, string arg_select_ymd)
		{
			string Proc_Name = "PKG_SPO_LOT_MOLD_CHECK.SELECT_STYLE_INFO";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_SELECT_YMD";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_select_ymd;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}



		private DataTable Select_Mold_Info(string arg_factory, string arg_select_ymd)
		{
			string Proc_Name = "PKG_SPO_LOT_MOLD_CHECK.SELECT_MOLD_INFO";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_SELECT_YMD";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_select_ymd;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}



		private DataTable Select_Fst_Size(string arg_factory, string arg_select_ymd, string arg_mold_cd, string arg_fst_size, string arg_cs_size)
		{
			string Proc_Name = "PKG_SPO_LOT_MOLD_CHECK.SELECT_FST_SIZE";

			oraDB.ReDim_Parameter(6);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_SELECT_YMD";
			oraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[3] = "ARG_FST_SIZE";
			oraDB.Parameter_Name[4] = "ARG_CS_SIZE";
			oraDB.Parameter_Name[5] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_select_ymd;
			oraDB.Parameter_Values[2] = arg_mold_cd;
			oraDB.Parameter_Values[3] = arg_fst_size;
			oraDB.Parameter_Values[4] = arg_cs_size;
			oraDB.Parameter_Values[5] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		private DataTable Select_Mold_Style_Info( string arg_factory, string arg_select_ymd )
		{
			string Proc_Name = "PKG_SPO_LOT_MOLD_CHECK.SELECT_MOLD_STYLE_INFO";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_SELECT_YMD";
			oraDB.Parameter_Name[2] = "ARG_MODEL_CD";
			oraDB.Parameter_Name[3] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[4] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_select_ymd;
			oraDB.Parameter_Values[2] = model_info;
			oraDB.Parameter_Values[3] = mold_info;
			oraDB.Parameter_Values[4] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}



		private DataTable Select_Neck_Capa(string arg_mold_cd, string arg_mold_size)
		{


			string Proc_Name = "PKG_SPO_LOT_MOLD_CHECK.SELECT_NECK_CAPA";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_SELECT_YMD";
			oraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[3] = "ARG_MOLD_SIZE";
			oraDB.Parameter_Name[4] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = cmb_selectday.SelectedValue.ToString();
			oraDB.Parameter_Values[2] = arg_mold_cd;
			oraDB.Parameter_Values[3] = arg_mold_size;
			oraDB.Parameter_Values[4] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}




		private DataTable Select_NextWorkDay()
		{
			string Proc_Name = "PKG_SPD_WORKSHEET_BSC.SELECT_NEXTWORKDAY";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		#endregion


	}
}

