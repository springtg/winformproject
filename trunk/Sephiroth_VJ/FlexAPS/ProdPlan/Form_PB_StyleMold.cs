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
	public class Form_PB_StyleMold : COM.APSWinForm.Form_Top
	{
		public System.Windows.Forms.Panel pnl_Search;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
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
		private System.Windows.Forms.Label lbl_planymd;
		private System.Windows.Forms.Label lbl_stylecd;
		public COM.FSP fgrid_Mold;
		private System.ComponentModel.IContainer components = null;



		private COM.OraDB oraDB = null;
		private int _IxGen_Value, _IxStart_Size, _IxTotal = 0;
		private int _IxGen_Start = 1;
		private int _IxGen_End   = 6;
		private int _IxSize_Start = 13;
		private int _IxSize_End = 0;
		private int col_width = 40;
		private int gen_width = 25;

		private int Font_Size = 7;


		private string factory = null;
		private string plan_ymd = null;
		private System.Windows.Forms.Label lbl_moldinfo;
		private System.Windows.Forms.CheckBox chk_moldinfo;
		private System.Windows.Forms.TextBox txt_style;
		private System.Windows.Forms.DateTimePicker dpick_select;
		private string style_cd = null;
		private string lot_no = null;
		private string lot_seq = null;
		private string day_seq = null;

		public Form_PB_StyleMold()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		public Form_PB_StyleMold(string arg_factory, string arg_plan_ymd, string arg_style_cd, string arg_lot_no, string arg_lot_seq, string arg_day_seq)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			factory  = arg_factory;
			plan_ymd = arg_plan_ymd;
			style_cd = arg_style_cd;
			lot_no   = arg_lot_no;
			lot_seq  = arg_lot_seq;
			day_seq  = arg_day_seq;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_StyleMold));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.txt_style = new System.Windows.Forms.TextBox();
			this.dpick_select = new System.Windows.Forms.DateTimePicker();
			this.lbl_moldinfo = new System.Windows.Forms.Label();
			this.lbl_stylecd = new System.Windows.Forms.Label();
			this.lbl_planymd = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.chk_moldinfo = new System.Windows.Forms.CheckBox();
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
			this.fgrid_Mold = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).BeginInit();
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// tbtn_Color
			// 
			this.tbtn_Color.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Color_Click);
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.txt_style);
			this.pnl_Search.Controls.Add(this.dpick_select);
			this.pnl_Search.Controls.Add(this.lbl_moldinfo);
			this.pnl_Search.Controls.Add(this.lbl_stylecd);
			this.pnl_Search.Controls.Add(this.lbl_planymd);
			this.pnl_Search.Controls.Add(this.cmb_Factory);
			this.pnl_Search.Controls.Add(this.lbl_Factory);
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.Bottom = 8;
			this.pnl_Search.DockPadding.Left = 8;
			this.pnl_Search.DockPadding.Right = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 72);
			this.pnl_Search.TabIndex = 46;
			// 
			// txt_style
			// 
			this.txt_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_style.Location = new System.Drawing.Point(661, 35);
			this.txt_style.Name = "txt_style";
			this.txt_style.Size = new System.Drawing.Size(150, 22);
			this.txt_style.TabIndex = 89;
			this.txt_style.Text = "";
			// 
			// dpick_select
			// 
			this.dpick_select.CustomFormat = "";
			this.dpick_select.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_select.Location = new System.Drawing.Point(389, 35);
			this.dpick_select.Name = "dpick_select";
			this.dpick_select.Size = new System.Drawing.Size(150, 22);
			this.dpick_select.TabIndex = 88;
			this.dpick_select.ValueChanged += new System.EventHandler(this.dpick_select_ValueChanged);
			// 
			// lbl_moldinfo
			// 
			this.lbl_moldinfo.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_moldinfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_moldinfo.ImageIndex = 0;
			this.lbl_moldinfo.ImageList = this.img_Label;
			this.lbl_moldinfo.Location = new System.Drawing.Point(832, 36);
			this.lbl_moldinfo.Name = "lbl_moldinfo";
			this.lbl_moldinfo.Size = new System.Drawing.Size(100, 21);
			this.lbl_moldinfo.TabIndex = 87;
			this.lbl_moldinfo.Text = "Mold Info";
			this.lbl_moldinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_stylecd
			// 
			this.lbl_stylecd.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_stylecd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_stylecd.ImageIndex = 0;
			this.lbl_stylecd.ImageList = this.img_Label;
			this.lbl_stylecd.Location = new System.Drawing.Point(560, 36);
			this.lbl_stylecd.Name = "lbl_stylecd";
			this.lbl_stylecd.Size = new System.Drawing.Size(100, 21);
			this.lbl_stylecd.TabIndex = 85;
			this.lbl_stylecd.Text = "Style Code";
			this.lbl_stylecd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_planymd
			// 
			this.lbl_planymd.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_planymd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_planymd.ImageIndex = 0;
			this.lbl_planymd.ImageList = this.img_Label;
			this.lbl_planymd.Location = new System.Drawing.Point(288, 36);
			this.lbl_planymd.Name = "lbl_planymd";
			this.lbl_planymd.Size = new System.Drawing.Size(100, 21);
			this.lbl_planymd.TabIndex = 83;
			this.lbl_planymd.Text = "Select Date";
			this.lbl_planymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Location = new System.Drawing.Point(117, 36);
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(150, 21);
			this.cmb_Factory.TabIndex = 38;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(16, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 37;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.chk_moldinfo);
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
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 64);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// chk_moldinfo
			// 
			this.chk_moldinfo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_moldinfo.Location = new System.Drawing.Point(932, 36);
			this.chk_moldinfo.Name = "chk_moldinfo";
			this.chk_moldinfo.Size = new System.Drawing.Size(21, 21);
			this.chk_moldinfo.TabIndex = 35;
			this.chk_moldinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_moldinfo.CheckedChanged += new System.EventHandler(this.chk_moldinfo_CheckedChanged);
			// 
			// btn_PopPgId
			// 
			this.btn_PopPgId.BackColor = System.Drawing.SystemColors.Window;
			this.btn_PopPgId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.picb_MR.Location = new System.Drawing.Point(985, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 24);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(984, 0);
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
			this.lbl_SubTitle1.Text = "      Search Style";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(984, 48);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 46);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(840, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 44);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
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
			this.picb_MM.Size = new System.Drawing.Size(832, 19);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
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
			this.fgrid_Mold.Location = new System.Drawing.Point(9, 136);
			this.fgrid_Mold.Name = "fgrid_Mold";
			this.fgrid_Mold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Mold.Size = new System.Drawing.Size(998, 504);
			this.fgrid_Mold.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Mold.TabIndex = 49;
			this.fgrid_Mold.Click += new System.EventHandler(this.fgrid_Mold_Click);
			this.fgrid_Mold.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Mold_AfterEdit);
			// 
			// Form_PB_StyleMold
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_Mold);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_PB_StyleMold";
			this.Load += new System.EventHandler(this.Form_PB_StyleMold_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.fgrid_Mold, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 이벤트

		private void Form_PB_StyleMold_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			search1();

			if(!chk_moldinfo.Checked)
			{
				for(int i=_IxGen_End; i<fgrid_Mold.Rows.Count; i++)
				{
					if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] != null)
					{
						if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION].ToString() == "H")
						{
							fgrid_Mold.Rows[i].Visible = false;
						}
					}
				}
			}
		}

		private void chk_moldinfo_CheckedChanged(object sender, System.EventArgs e)
		{
			for(int i=_IxGen_End; i<fgrid_Mold.Rows.Count; i++)
			{
				if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] != null)
				{
					if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION].ToString() == "H")
					{
						fgrid_Mold.Rows[i].Visible = chk_moldinfo.Checked;
					}
				}
			}
		}

		private void fgrid_Mold_Click(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_Mold.Selection.r1;
			int sct_col = fgrid_Mold.Selection.c1;

			if(sct_row < _IxGen_End) return;

			try
			{
				int row_num = 0;

				string sct_gen = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_GEN].ToString();

				for(int i=_IxGen_Start; i<_IxGen_End; i++)
				{
					fgrid_Mold.GetCellRange(i,_IxSize_Start,i,_IxSize_End).StyleNew.BackColor = COM.ComVar.GridLightFixed_Color;
					fgrid_Mold.GetCellRange(i,_IxSize_Start,i,_IxSize_End).StyleNew.ForeColor = Color.White;

					if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_GEN].ToString() == sct_gen)
					{
						row_num = i;
					}
				}

				fgrid_Mold.GetCellRange(row_num,_IxSize_Start,row_num,_IxSize_End).StyleNew.BackColor = Color.FromArgb(251, 248, 185);//COM.ComVar.GridDarkFixed_Color;
				fgrid_Mold.GetCellRange(row_num,_IxSize_Start,row_num,_IxSize_End).StyleNew.ForeColor = Color.Black;
			}
			catch
			{
			}
		}

		#endregion

		#region 메소드

		private void Init_Form()
		{

			this.Text = "Using Mold To Style";
			this.lbl_MainTitle.Text = "Using Mold To Style";
			ClassLib.ComFunction.SetLangDic(this);


			oraDB = new COM.OraDB();  

				
			#region 버튼 권한
				
//			try
//							
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
			tbtn_Create.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Save.Enabled = false;


			//Factroy ComboBox Setting
			DataTable dt_list = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1,false);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;


			//작업일 선택

//			Form_PO_LOT_MoldCapa moldCapa = new Form_PO_LOT_MoldCapa();
//			dt_list = moldCapa.Select_Plan_YMD(cmb_Factory.SelectedValue.ToString());
//			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_planymd, 0, 1,false);
//			cmb_planymd.SelectedIndex = 0;
//			cmb_planymd.Splits[0].DisplayColumns["Code"].Width = 0;



			//스타일 그리드
			fgrid_Mold.Set_Grid("SPB_STYLE_MOLD", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			ClassLib.ComFunction.Set_Grid_Font_Size(fgrid_Mold, 7);
			fgrid_Mold.Set_Action_Image(img_Action);
			Set_Gender_Grid(fgrid_Mold);
			fgrid_Mold.Cols.Frozen = (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_GEN+1;
			//fgrid_Mold.Cols[fgrid_Mold.Rows.Count-1].Visible = false;

			dpick_select.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			ClassLib.ComFunction.Get_Values(this, dpick_select.Name);


			_IxSize_Start = (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_GEN + 1;
			_IxSize_End   = fgrid_Mold.Cols.Count;	



			if(plan_ymd != null && style_cd != null)
			{
				ClassLib.ComFunction comfunc = new FlexAPS.ClassLib.ComFunction();
				
				dpick_select.Text = comfunc.ConvertDate2Type(plan_ymd);
				txt_style.Text = style_cd;


				tbtn_Search_Click(null, null);
			}
	





		}



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

			arg_fgrid.AutoSizeCols();

 			

			//------------------------------------------------
			//젠더 입력

			_IxGen_Value = (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_GEN;

			arg_fgrid.Cols.Insert(_IxGen_Value);

			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
				arg_fgrid[i + 1, _IxGen_Value] = dt_list.Rows[i].ItemArray[3].ToString();
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


			for(int i = 0; i < arg_fgrid.Rows.Count; i++)
			{
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



		private void search1()
		{
			try
			{
				fgrid_Mold.Rows.Count = _IxGen_End;


				string lot_sequence = lot_no + lot_seq + day_seq;

				DataTable dt = Select_Style_Info();

				int dt_row = dt.Rows.Count;
				int dt_col = dt.Columns.Count;

				string old_datamold = dt.Rows[0].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_MOLD_CD].ToString();

				string new_datamold = "";

				string new_mold = "";
				string old_mold = "";

				int same_row = 0;


				string new_date = "";
				string old_date = "";

				for(int i=0; i<dt_row; i++)
				{
					new_datamold = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_MOLD_CD].ToString();
					if(old_datamold != new_datamold)
					{
						Set_Result(same_row);	
						old_datamold = new_datamold;
					}

					new_mold = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_MOLD_CD].ToString();
				
					if(old_mold != new_mold)
					{
						same_row ++;
						fgrid_Mold.Rows.Add();
						fgrid_Mold.Rows.Add();
						fgrid_Mold.Rows.Add();
						fgrid_Mold.Rows.Add();

						Set_Grid_Moldinfo("M"+same_row.ToString(), fgrid_Mold.Rows.Count-4, new_mold,  dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_MODEL_CD].ToString());
						fgrid_Mold[fgrid_Mold.Rows.Count-3, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_STYLE_CD] = "Mold Stock";
						fgrid_Mold[fgrid_Mold.Rows.Count-3, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] = "H";

						fgrid_Mold[fgrid_Mold.Rows.Count-2, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_STYLE_CD] = "PRS/SET";
						fgrid_Mold[fgrid_Mold.Rows.Count-2, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] = "H";

						fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_STYLE_CD] = "Cycle";
						fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] = "H";
					
					
						fgrid_Mold.Rows[fgrid_Mold.Rows.Count-4].StyleNew.BackColor = Color.FromArgb(230, 230,250);
						fgrid_Mold.Rows[fgrid_Mold.Rows.Count-3].StyleNew.BackColor = Color.FromArgb(210, 210,247);
						fgrid_Mold.Rows[fgrid_Mold.Rows.Count-2].StyleNew.BackColor = Color.FromArgb(230, 230,250);
						fgrid_Mold.Rows[fgrid_Mold.Rows.Count-1].StyleNew.BackColor = Color.FromArgb(210, 210,247);

					
					
					
						old_mold = new_mold;
					}

					new_date = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_MOLD_CD].ToString()
						+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_LINE_CD].ToString()
						+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_LOT_NO].ToString()
						+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_LOT_SEQ].ToString()
						+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_DAY_SEQ].ToString();
				  

					if(old_date != new_date)
					{
						fgrid_Mold.Rows.Add();

						int into_row = fgrid_Mold.Rows.Count-1;

						fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] = same_row.ToString();

						fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_FACTORY] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_FACTORY].ToString();

						fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_PLAN_YMD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_PLAN_YMD].ToString();

						fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_MOLD_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_MOLD_CD].ToString();

						fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_LINE_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_LINE_CD].ToString();

						fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_MODEL_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_MODEL_CD].ToString();

						fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_MODEL_NAME] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_MODEL_NAME].ToString();

						fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_STYLE_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_STYLE_CD].ToString();

						fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_LOT_NO] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_LOT_NO].ToString();

						fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_LOT_SEQ] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_LOT_SEQ].ToString();

						fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DAY_SEQ] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_DAY_SEQ].ToString();

						fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_GEN] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_GEN].ToString();

						if(dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_LOT_NO].ToString()
							+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_LOT_SEQ].ToString()
							+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_DAY_SEQ].ToString() == lot_sequence)
						{
							fgrid_Mold.Rows[into_row].StyleNew.BackColor = Color.FromArgb(251,248,185);
							fgrid_Mold[into_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_SEQ] = "C";
						}



						old_date = new_date;
					}


					string gen = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_GEN].ToString();
					string cs_size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_CS_SIZE].ToString();
					string qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDB_SUMQTY].ToString();
					Set_Grid_Size(fgrid_Mold.Rows.Count-1, gen, cs_size, qty);
				}

				Set_Result(same_row);
				fgrid_Mold.AutoSizeCols((int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_FACTORY, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_STYLE_CD, 10);

				//fgrid_Mold.AllowEditing = false;

				for(int i=0; i<fgrid_Mold.Rows.Count; i++)
				{
					if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_SEQ] != null)
					{
						if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_SEQ].ToString() == "C")
						{
							fgrid_Mold.Rows[i].AllowEditing = true;
						}
						else
						{
							fgrid_Mold.Rows[i].AllowEditing = false;
						}
					}
					else
					{
						fgrid_Mold.Rows[i].AllowEditing = false;
					}
				}



				fgrid_Mold.Rows.Add();
				Max_Value();

				fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_STYLE_CD] = "Max Shortage Capa";



			}
			catch
			{
			}
		}



		private void Max_Value()
		{
			int Max_Value;
			for(int i=_IxSize_Start; i<_IxSize_End; i++)
			{
				Max_Value = 10000;
				for(int j=_IxGen_End; j<fgrid_Mold.Rows.Count; j++)
				{
					if(fgrid_Mold[j,(int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] != null)
					{
						if(fgrid_Mold[j,(int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION].ToString() == "SM")
						{
							if(Max_Value > int.Parse(fgrid_Mold[j, i].ToString()))
							{
								Max_Value = int.Parse(fgrid_Mold[j, i].ToString());
							}
						}
					}
				}


				fgrid_Mold[fgrid_Mold.Rows.Count-1, i] = Max_Value.ToString();


				System.Drawing.Color font_color = Color.Blue; 
				if(Max_Value >= 0)
					font_color = Color.Blue;
				else
					font_color = Color.Red;

				fgrid_Mold.GetCellRange(fgrid_Mold.Rows.Count-1, i).StyleNew.ForeColor = font_color;
				fgrid_Mold.Rows[fgrid_Mold.Rows.Count-1].StyleNew.BackColor = Color.FromArgb(217, 250, 216);
			}
		}


		private void Set_Grid_Size(int arg_rownum, string arg_gen, string arg_cs_size, string arg_qty)
		{
			int i;
			
			for(i=_IxGen_Start; i<_IxGen_End; i++)
			{
				if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_GEN].ToString() == arg_gen)
				{
					break;
				}
			}


			for(int j=_IxSize_Start; j<_IxSize_End; j++)
			{
				if(fgrid_Mold[i, j].ToString() == arg_cs_size)
				{
					fgrid_Mold[arg_rownum, j] = arg_qty;
					return;
				}
			}
		}


		private void Set_Grid_Moldinfo(string arg_same_row, int arg_rownum, string arg_mold_cd, string arg_model_cd)
		{
			DataTable dt = Select_Mold_Info(arg_mold_cd,  arg_model_cd);

			int dt_row = dt.Rows.Count;
			int dt_col = dt.Columns.Count;

			try
			{


				string factory = dt.Rows[0].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDBMOLD_FACTORY].ToString();
				string moldname = dt.Rows[0].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDBMOLD_MOLD_TYPE].ToString()+"["+ arg_mold_cd + "]";
				string moldcd   = dt.Rows[0].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDBMOLD_SPEC_CD].ToString();
				string moldgen  = dt.Rows[0].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDBMOLD_GEN].ToString();

				fgrid_Mold[arg_rownum, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] = arg_same_row;
				fgrid_Mold[arg_rownum, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_FACTORY] = factory;
				fgrid_Mold[arg_rownum, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_MODEL_NAME] = moldname;
				fgrid_Mold[arg_rownum, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_STYLE_CD] = moldcd;
				fgrid_Mold[arg_rownum, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_GEN] = moldgen;


				for(int i=0; i<dt_row; i++)
				{
					string gen     = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDBMOLD_GEN].ToString();
					string cs_size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDBMOLD_CS_SIZE].ToString();
					string sum_qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDBMOLD_SUM_QTY].ToString();
					string pairs   = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDBMOLD_PAIRS].ToString();
					string cycle   = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDBMOLD_CYCLE].ToString();
					//string daycapa = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_STYLE_MOLD1.IxDBMOLD_DAYCAPA].ToString();

					int j;

					for(j=_IxGen_Start; j<_IxGen_End; j++)
					{
						if(fgrid_Mold[j, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_GEN].ToString() == gen)
						{
							break;
						}
					}


					for(int k=_IxSize_Start; k<_IxSize_End; k++)
					{
						if(fgrid_Mold[j, k].ToString() == cs_size)
						{
							fgrid_Mold[arg_rownum, k] = (int.Parse(sum_qty) * int.Parse(pairs) * int.Parse(cycle)).ToString();
							fgrid_Mold[arg_rownum+1, k] = sum_qty;
							fgrid_Mold[arg_rownum+2, k] = pairs;
							fgrid_Mold[arg_rownum+3, k] = cycle;
							break;
						}
					}
				}
			}
			catch
			{
				fgrid_Mold[arg_rownum, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_MODEL_NAME] = "Check Mold Status";
				fgrid_Mold[arg_rownum, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_STYLE_CD] = arg_mold_cd;
			}


		}


		private void Set_Result(int arg_same_row)
		{
			fgrid_Mold.Rows.Add();
			fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] = "TO";// + arg_same_row.ToString();
			fgrid_Mold.Rows.Add();
			fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] = "SM";// + arg_same_row.ToString();

			for(int j=_IxSize_Start; j<_IxSize_End; j++)
			{
				int style_sum = 0;
				int mold_capa = 0;

				int k;
				for(k=_IxGen_End; k<fgrid_Mold.Rows.Count-1; k++)
				{
					if(fgrid_Mold[k, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] != null)
					{
						if(fgrid_Mold[k, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION].ToString() == "M" + arg_same_row.ToString())
						{
							if(fgrid_Mold[k,j] != null)
							{
								mold_capa = int.Parse(fgrid_Mold[k,j].ToString());
							}
						}

						if(fgrid_Mold[k, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION].ToString() == arg_same_row.ToString())
						{
							if(fgrid_Mold[k,j] != null)
							{
								style_sum += int.Parse(fgrid_Mold[k,j].ToString());
							}
						}
					}
				}

				fgrid_Mold[fgrid_Mold.Rows.Count-2, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_STYLE_CD] = "Total Order Qty";
				fgrid_Mold[fgrid_Mold.Rows.Count-2, j] = style_sum.ToString();

				fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_STYLE_CD] = "Shortage Moldcapa";
				fgrid_Mold[fgrid_Mold.Rows.Count-1, j] = (mold_capa - style_sum).ToString();

				System.Drawing.Color font_color = Color.Blue; 
				if(mold_capa - style_sum >= 0)
					font_color = Color.Blue;
				else
					font_color = Color.Red;

				fgrid_Mold.GetCellRange(fgrid_Mold.Rows.Count-1, j).StyleNew.ForeColor = font_color;
				fgrid_Mold.Rows[fgrid_Mold.Rows.Count-1].StyleNew.BackColor = Color.FromArgb(217, 250, 216);


				
			}
			fgrid_Mold.Rows.Add();
			fgrid_Mold.Rows[fgrid_Mold.Rows.Count-1].StyleNew.BackColor = Color.FromArgb(194, 194, 194);
			fgrid_Mold.Rows[fgrid_Mold.Rows.Count-1].Height = 2;
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

			for(int mgen = _IxGen_Start; mgen<_IxGen_End; mgen++)
			{
				if(gen == arg_fgrid[mgen, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_GEN].ToString())
				{
					arg_fgrid.GetCellRange(mgen, _IxSize_Start, mgen, _IxSize_End-2).StyleNew.BackColor = Color.FromArgb(arg_red, arg_green, arg_blue);
				}
				else
				{
					arg_fgrid.GetCellRange(mgen, _IxSize_Start, mgen, _IxSize_End-2).StyleNew.BackColor = Color.FromArgb(135,179,234);
				}
			}
		}




		#endregion

		#region DB접속
		/// <summary>
		/// 스타일 코드를 가져온다.
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Style_CD(string arg_plan_ymd)
		{

			string Proc_Name = "PKG_SPB_MOLD.SELECT_STYLE_CD";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_PLAN_YMD";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = arg_plan_ymd;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


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


		private DataTable Select_Style_Info()
		{

			string Proc_Name = "PKG_SPB_MOLD.SELECT_STYLE_MOLD";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_PLAN_YMD";
			oraDB.Parameter_Name[2] = "ARG_STYLE_CD";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			ClassLib.ComFunction comfunc = new FlexAPS.ClassLib.ComFunction();
			oraDB.Parameter_Values[1] = comfunc.ConvertDate2DbType(dpick_select.Text);;
			oraDB.Parameter_Values[2] = txt_style.Text.Replace("-","").Trim();
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		private DataTable Select_Mold_Info(string arg_mold_cd, string arg_model_cd)
		{

			string Proc_Name = "PKG_SPB_MOLD.SELECT_STYLE_MOLD_CAPACITY";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_MODEL_CD";
			oraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = arg_model_cd;
			oraDB.Parameter_Values[2] = arg_mold_cd;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		#endregion

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Font_Size++;
			ClassLib.ComFunction.Set_Grid_Font_Size(fgrid_Mold,Font_Size);
			fgrid_Mold.AutoSizeCols();
		}

		private void tbtn_Color_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Font_Size--;
			ClassLib.ComFunction.Set_Grid_Font_Size(fgrid_Mold,Font_Size);
			fgrid_Mold.AutoSizeCols();
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Mold.Rows.Count = _IxGen_End;
		}

		private void dpick_select_ValueChanged(object sender, System.EventArgs e)
		{
			ClassLib.ComFunction.Set_Values(this, dpick_select.Name);
		}

		private void fgrid_Mold_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			int edit_row = fgrid_Mold.Selection.r1;
			int edit_col = fgrid_Mold.Selection.c1;

			//if(fgrid_Mold[edit_row, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] != "M" )return;

			string edit_value;

			try
			{
				edit_value = fgrid_Mold[edit_row, edit_col].ToString();
			}
			catch
			{
				edit_value = "0";
			}

			if(!ClassLib.ComFunction.Check_Digit(edit_value))
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsWrongInput);
				fgrid_Mold[edit_row, edit_col] = 0;
				return;
			}

			for(int i=_IxGen_End; i<fgrid_Mold.Rows.Count; i++)
			{
				if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_SEQ] != null)
				{
					if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_SEQ].ToString() == "C")
					{
						fgrid_Mold[i, edit_col] = edit_value;
					}
				}
			}



			string mold_cd = "";
			int sum = 0;
			int mold_day = 0;
			for(int i=_IxGen_End; i<fgrid_Mold.Rows.Count; i++)
			{
				if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION] != null)
				{
					if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_MOLD_CD] != null)
					{
						if(mold_cd == fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_MOLD_CD].ToString())
						{
							try
							{
								sum += int.Parse(fgrid_Mold[i, edit_col].ToString());
							}
							catch
							{
							}
						}
						else
						{
							try
							{
								mold_day = int.Parse(fgrid_Mold[i-4, edit_col].ToString());
							}
							catch
							{
								mold_day = 0;
							}


							mold_cd = fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_MOLD_CD].ToString();
							sum = 0;

							try
							{
								sum = int.Parse(fgrid_Mold[i, edit_col].ToString());
							}
							catch
							{
							}
						}
					}
					else if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION].ToString() == "TO")
					{
						fgrid_Mold[i, edit_col] = sum.ToString();
					}
					else if(fgrid_Mold[i, (int)ClassLib.TBSPB_STYLE_MOLD1.IxGR_DIVISION].ToString() == "SM")
					{
						fgrid_Mold[i, edit_col] = (mold_day - int.Parse(fgrid_Mold[i-1, edit_col].ToString())).ToString();
					}
				
				}

			}


			Max_Value();



		}
	}
}

