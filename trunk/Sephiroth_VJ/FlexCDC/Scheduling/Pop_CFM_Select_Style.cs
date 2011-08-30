using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;

namespace FlexCDC.Scheduling
{
	public class Pop_CFM_Select_Style : COM.APSWinForm.Pop_Large
	{
		#region 컨트롤정의 및 리소스 정의
		private System.ComponentModel.IContainer components = null;
		private int _RowFixed;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		public System.Windows.Forms.PictureBox pictureBox17;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ImageList img_MiniButton;
		public System.Windows.Forms.PictureBox pictureBox1;
		private C1.Win.C1List.C1Combo cmbSeason;
		private System.Windows.Forms.Label lblSeason;
		private System.Windows.Forms.Label lblFactory;
		public System.Windows.Forms.Label lbl_SubTitle;
		private C1.Win.C1List.C1Combo cmbFactory;
		private C1.Win.C1List.C1Combo cmbDPO;
		private System.Windows.Forms.Label lblDPO;
		private System.Windows.Forms.TextBox txtStyle;
		private System.Windows.Forms.Label lblStyle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnClose;
		private COM.OraDB OraDB = new COM.OraDB();
		private COM.FSP grdCFM;
		private Pop_CFM_Add frmCFMAdd = null;
		private System.Windows.Forms.CheckBox chkDPO;
		private Form_CFM_Schedule frmCFMSch = null;

		public Pop_CFM_Select_Style(Form_CFM_Schedule sForm, bool QueryOK, string vFactory, string vDPO_ID, string vSeason, string vStyleCD)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			Init_Form();

			frmCFMSch = sForm;
			cmbFactory.SelectedValue = vFactory;
			cmbDPO.SelectedValue     = vDPO_ID;
			cmbSeason.SelectedValue  = vSeason;
			txtStyle.Text            = vStyleCD;
			if (cmbFactory.SelectedIndex < 0 || vFactory == "")
			{
				cmbFactory.SelectedIndex = 0;
			}
			if (cmbDPO.SelectedIndex < 0)
			{
				cmbDPO.SelectedIndex = 0;
			}
			if (cmbSeason.SelectedIndex < 0)
			{
				cmbSeason.SelectedIndex = 0;
			}
		}

		public Pop_CFM_Select_Style(Pop_CFM_Add sForm, string sFactory, string sSeason, string sDPO, string sStyleNo)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			//
			// Call from Pop_CFM_Add Form
			//
			Init_Form();

			frmCFMAdd                = sForm;
			cmbFactory.SelectedValue = sFactory;
			cmbSeason.SelectedValue  = sSeason;
			cmbDPO.SelectedValue     = sDPO;
			txtStyle.Text            = sStyleNo;

			btnSave.Visible = false;

			Show_grdCFM_Data();
		}
	   
		#region 메인폼에 따른 변수정의 

//		public Pop_CFM_Select_Style(Purchase.Form_SD_Request arg_request, string arg_sr_no, string arg_pj_seq)
//		{
//			// 이 호출은 Windows Form 디자이너에 필요합니다.
//			InitializeComponent();
//
//			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
//
//			_form_type = "request";
//			request = arg_request;
//			sr_no = arg_sr_no;
//			pj_seq = arg_pj_seq;
//
//			txt_sr_no.Text = sr_no;
//		}
//
//		public Pop_DB_ModelList(SRF.Form_SD_SRFLoding arg_srfLoding, string arg_srf_no, int arg_sct_row)
//		{
//			// 이 호출은 Windows Form 디자이너에 필요합니다.
//			InitializeComponent();
//
//			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
//
//			_form_type = "yield";
//			srfLoding  = arg_srfLoding;
//			txt_srfno.Text = arg_srf_no;
//			loding_sct_row = arg_sct_row;
//		}
//
//		public Pop_DB_ModelList(SRF.Form_SRFUPLoding arg_srftest, string arg_srf_no, int arg_sct_row)
//		{
//			// 이 호출은 Windows Form 디자이너에 필요합니다.
//			InitializeComponent();
//
//			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
//
//			_form_type = "yield";
//			srftest  = arg_srftest;
//			txt_srfno.Text = arg_srf_no;
//			loding_sct_row = arg_sct_row;
//		}
//
//		public Pop_DB_ModelList(SRF.Form_SD_SRFLoding arg_srfLoding)
//		{
//			// 이 호출은 Windows Form 디자이너에 필요합니다.
//			InitializeComponent();
//
//			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
//
//			_form_type = "srfLoding";
//			srfLoding  = arg_srfLoding;
//		}
//
//		public Pop_DB_ModelList(SRF.Form_SRFUPLoding arg_srftest)
//		{
//			// 이 호출은 Windows Form 디자이너에 필요합니다.
//			InitializeComponent();
//
//			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
//
//			_form_type = "srftest";
//			srftest  = arg_srftest;
//		}
//
//
//		public Pop_DB_ModelList(Form_DB_Modelinfo arg_modelInfo)
//		{
//			// 이 호출은 Windows Form 디자이너에 필요합니다.
//			InitializeComponent();
//
//			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
//
//			_form_type = "modelinfo";
//			modelInfo  = arg_modelInfo;
//		}

		#endregion 

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_CFM_Select_Style));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtStyle = new System.Windows.Forms.TextBox();
			this.lblStyle = new System.Windows.Forms.Label();
			this.cmbDPO = new C1.Win.C1List.C1Combo();
			this.lblDPO = new System.Windows.Forms.Label();
			this.cmbFactory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle = new System.Windows.Forms.Label();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmbSeason = new C1.Win.C1List.C1Combo();
			this.lblSeason = new System.Windows.Forms.Label();
			this.lblFactory = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.grdCFM = new COM.FSP();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.chkDPO = new System.Windows.Forms.CheckBox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbDPO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbFactory)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbSeason)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdCFM)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageSize = new System.Drawing.Size(80, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Location = new System.Drawing.Point(40, 12);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(267, 22);
			this.lbl_MainTitle.Text = "Select CFM Shoe Style";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.btnSearch);
			this.panel2.Controls.Add(this.txtStyle);
			this.panel2.Controls.Add(this.lblStyle);
			this.panel2.Controls.Add(this.cmbDPO);
			this.panel2.Controls.Add(this.lblDPO);
			this.panel2.Controls.Add(this.cmbFactory);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.pictureBox10);
			this.panel2.Controls.Add(this.pictureBox11);
			this.panel2.Controls.Add(this.lbl_SubTitle);
			this.panel2.Controls.Add(this.pictureBox12);
			this.panel2.Controls.Add(this.pictureBox13);
			this.panel2.Controls.Add(this.pictureBox14);
			this.panel2.Controls.Add(this.pictureBox15);
			this.panel2.Controls.Add(this.pictureBox16);
			this.panel2.Controls.Add(this.pictureBox17);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("굴림", 9F);
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(8, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(990, 72);
			this.panel2.TabIndex = 18;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.Location = new System.Drawing.Point(898, 34);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(80, 24);
			this.btnSearch.TabIndex = 367;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtStyle
			// 
			this.txtStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStyle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtStyle.Location = new System.Drawing.Point(680, 36);
			this.txtStyle.Name = "txtStyle";
			this.txtStyle.Size = new System.Drawing.Size(184, 22);
			this.txtStyle.TabIndex = 4;
			this.txtStyle.Text = "";
			// 
			// lblStyle
			// 
			this.lblStyle.ImageIndex = 0;
			this.lblStyle.ImageList = this.img_Label;
			this.lblStyle.Location = new System.Drawing.Point(576, 36);
			this.lblStyle.Name = "lblStyle";
			this.lblStyle.Size = new System.Drawing.Size(100, 21);
			this.lblStyle.TabIndex = 365;
			this.lblStyle.Text = "Style Code";
			this.lblStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbDPO
			// 
			this.cmbDPO.AddItemCols = 0;
			this.cmbDPO.AddItemSeparator = ';';
			this.cmbDPO.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbDPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbDPO.Caption = "";
			this.cmbDPO.CaptionHeight = 17;
			this.cmbDPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbDPO.ColumnCaptionHeight = 18;
			this.cmbDPO.ColumnFooterHeight = 18;
			this.cmbDPO.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbDPO.ContentHeight = 17;
			this.cmbDPO.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbDPO.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbDPO.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbDPO.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbDPO.EditorHeight = 17;
			this.cmbDPO.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbDPO.GapHeight = 2;
			this.cmbDPO.ItemHeight = 15;
			this.cmbDPO.Location = new System.Drawing.Point(312, 36);
			this.cmbDPO.MatchEntryTimeout = ((long)(2000));
			this.cmbDPO.MaxDropDownItems = ((short)(5));
			this.cmbDPO.MaxLength = 32767;
			this.cmbDPO.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbDPO.Name = "cmbDPO";
			this.cmbDPO.PartialRightColumn = false;
			this.cmbDPO.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbDPO.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbDPO.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbDPO.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbDPO.Size = new System.Drawing.Size(80, 21);
			this.cmbDPO.TabIndex = 2;
			// 
			// lblDPO
			// 
			this.lblDPO.ImageIndex = 0;
			this.lblDPO.ImageList = this.img_Label;
			this.lblDPO.Location = new System.Drawing.Point(208, 36);
			this.lblDPO.Name = "lblDPO";
			this.lblDPO.Size = new System.Drawing.Size(100, 21);
			this.lblDPO.TabIndex = 364;
			this.lblDPO.Text = "DPO ID";
			this.lblDPO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbFactory
			// 
			this.cmbFactory.AddItemCols = 0;
			this.cmbFactory.AddItemSeparator = ';';
			this.cmbFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbFactory.Caption = "";
			this.cmbFactory.CaptionHeight = 17;
			this.cmbFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbFactory.ColumnCaptionHeight = 18;
			this.cmbFactory.ColumnFooterHeight = 18;
			this.cmbFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbFactory.ContentHeight = 17;
			this.cmbFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbFactory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbFactory.EditorHeight = 17;
			this.cmbFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbFactory.GapHeight = 2;
			this.cmbFactory.ItemHeight = 15;
			this.cmbFactory.Location = new System.Drawing.Point(120, 36);
			this.cmbFactory.MatchEntryTimeout = ((long)(2000));
			this.cmbFactory.MaxDropDownItems = ((short)(5));
			this.cmbFactory.MaxLength = 32767;
			this.cmbFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbFactory.Name = "cmbFactory";
			this.cmbFactory.PartialRightColumn = false;
			this.cmbFactory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbFactory.Size = new System.Drawing.Size(80, 21);
			this.cmbFactory.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Font = new System.Drawing.Font("굴림", 9F);
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(973, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 29);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(974, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(16, 32);
			this.pictureBox10.TabIndex = 21;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(224, 0);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(990, 40);
			this.pictureBox11.TabIndex = 0;
			this.pictureBox11.TabStop = false;
			// 
			// lbl_SubTitle
			// 
			this.lbl_SubTitle.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle.Image")));
			this.lbl_SubTitle.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle.Name = "lbl_SubTitle";
			this.lbl_SubTitle.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle.TabIndex = 28;
			this.lbl_SubTitle.Text = "      Style Search";
			this.lbl_SubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(974, 57);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(16, 16);
			this.pictureBox12.TabIndex = 23;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(144, 56);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(990, 18);
			this.pictureBox13.TabIndex = 24;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 57);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(168, 20);
			this.pictureBox14.TabIndex = 22;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(0, 24);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(168, 39);
			this.pictureBox15.TabIndex = 25;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(152, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(990, 32);
			this.pictureBox16.TabIndex = 27;
			this.pictureBox16.TabStop = false;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(472, 72);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(990, 32);
			this.pictureBox17.TabIndex = 27;
			this.pictureBox17.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.cmbSeason);
			this.panel1.Controls.Add(this.lblSeason);
			this.panel1.Controls.Add(this.lblFactory);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.DockPadding.Bottom = 8;
			this.panel1.DockPadding.Left = 8;
			this.panel1.DockPadding.Right = 8;
			this.panel1.Font = new System.Drawing.Font("굴림", 9F);
			this.panel1.Location = new System.Drawing.Point(0, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1006, 80);
			this.panel1.TabIndex = 129;
			// 
			// cmbSeason
			// 
			this.cmbSeason.AddItemCols = 0;
			this.cmbSeason.AddItemSeparator = ';';
			this.cmbSeason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbSeason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbSeason.Caption = "";
			this.cmbSeason.CaptionHeight = 17;
			this.cmbSeason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbSeason.ColumnCaptionHeight = 18;
			this.cmbSeason.ColumnFooterHeight = 18;
			this.cmbSeason.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbSeason.ContentHeight = 17;
			this.cmbSeason.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbSeason.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbSeason.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbSeason.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbSeason.EditorHeight = 17;
			this.cmbSeason.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbSeason.GapHeight = 2;
			this.cmbSeason.ItemHeight = 15;
			this.cmbSeason.Location = new System.Drawing.Point(512, 36);
			this.cmbSeason.MatchEntryTimeout = ((long)(2000));
			this.cmbSeason.MaxDropDownItems = ((short)(5));
			this.cmbSeason.MaxLength = 32767;
			this.cmbSeason.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbSeason.Name = "cmbSeason";
			this.cmbSeason.PartialRightColumn = false;
			this.cmbSeason.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbSeason.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbSeason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbSeason.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbSeason.Size = new System.Drawing.Size(64, 21);
			this.cmbSeason.TabIndex = 3;
			// 
			// lblSeason
			// 
			this.lblSeason.BackColor = System.Drawing.SystemColors.Window;
			this.lblSeason.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblSeason.ImageIndex = 0;
			this.lblSeason.ImageList = this.img_Label;
			this.lblSeason.Location = new System.Drawing.Point(408, 36);
			this.lblSeason.Name = "lblSeason";
			this.lblSeason.Size = new System.Drawing.Size(100, 21);
			this.lblSeason.TabIndex = 332;
			this.lblSeason.Tag = "1";
			this.lblSeason.Text = "Season";
			this.lblSeason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFactory
			// 
			this.lblFactory.BackColor = System.Drawing.SystemColors.Window;
			this.lblFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFactory.ImageIndex = 1;
			this.lblFactory.ImageList = this.img_Label;
			this.lblFactory.Location = new System.Drawing.Point(24, 36);
			this.lblFactory.Name = "lblFactory";
			this.lblFactory.Size = new System.Drawing.Size(100, 21);
			this.lblFactory.TabIndex = 330;
			this.lblFactory.Tag = "0";
			this.lblFactory.Text = "Factory";
			this.lblFactory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// grdCFM
			// 
			this.grdCFM.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.grdCFM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.grdCFM.AutoResize = false;
			this.grdCFM.BackColor = System.Drawing.SystemColors.Window;
			this.grdCFM.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.grdCFM.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.grdCFM.Font = new System.Drawing.Font("굴림", 9F);
			this.grdCFM.ForeColor = System.Drawing.SystemColors.WindowText;
			this.grdCFM.Location = new System.Drawing.Point(7, 128);
			this.grdCFM.Name = "grdCFM";
			this.grdCFM.Rows.Fixed = 0;
			this.grdCFM.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.grdCFM.Size = new System.Drawing.Size(991, 440);
			this.grdCFM.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.grdCFM.TabIndex = 124;
			this.grdCFM.Click += new System.EventHandler(this.grdCFM_Click);
			this.grdCFM.DoubleClick += new System.EventHandler(this.grdCFM_DoubleClick);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(898, 14);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 24);
			this.btnClose.TabIndex = 6;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.Location = new System.Drawing.Point(810, 14);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(80, 24);
			this.btnSave.TabIndex = 367;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// chkDPO
			// 
			this.chkDPO.BackColor = System.Drawing.Color.Transparent;
			this.chkDPO.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.chkDPO.Location = new System.Drawing.Point(808, 44);
			this.chkDPO.Name = "chkDPO";
			this.chkDPO.Size = new System.Drawing.Size(168, 20);
			this.chkDPO.TabIndex = 369;
			this.chkDPO.Text = "Check DPO Only";
			this.chkDPO.CheckedChanged += new System.EventHandler(this.chkDPO_CheckedChanged);
			// 
			// Pop_CFM_Select_Style
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1004, 576);
			this.Controls.Add(this.chkDPO);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.grdCFM);
			this.Name = "Pop_CFM_Select_Style";
			this.Text = "Select CFM Shoe";
			this.Load += new System.EventHandler(this.Pop_CFM_Select_Style_Load);
			this.Controls.SetChildIndex(this.grdCFM, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btnClose, 0);
			this.Controls.SetChildIndex(this.btnSave, 0);
			this.Controls.SetChildIndex(this.chkDPO, 0);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmbDPO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbFactory)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmbSeason)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdCFM)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
	

		#region  메쏘드 정의 

		private void Init_Form()
		{
			//Factory Code ComboBox Link - Common Code Table
			DataTable vDT = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_Factory_List(vDT, cmbFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			cmbFactory.SelectedValue = ClassLib.ComVar.This_Factory;

			//Season Code ComboBox List
			vDT = Select_Sdc_CFM_Season();
			ClassLib.ComCtl.Set_ComboList(vDT, cmbSeason, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
			cmbSeason.SelectedIndex = 0;

			//CDC DPO ComboBox List
			vDT = Select_Sdc_CFM_Dpo();
			COM.ComCtl.Set_ComboList(vDT, cmbDPO, 0, 0,  true, COM.ComVar.ComboList_Visible.Name);
			cmbDPO.SelectedIndex = 0;
			
			grdCFM.Set_Grid("SDC_CFM_SCH_STYLE", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);
			//grdCFM.Mark_Grid_Menu();
			_RowFixed = grdCFM.Rows.Fixed;
			grdCFM.AutoSizeCols();

			// [0] Col : Set checkbox cell type
			C1.Win.C1FlexGrid.CellStyle grdStyle = grdCFM.Styles.Add("CheckBoxCellStyle");
			grdStyle.DataType  = typeof(bool);
			grdStyle.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

			grdCFM.Cols[0].Style = grdCFM.Styles["CheckBoxCellStyle"];
		}

		private void Show_grdCFM_Data() 
		{
			grdCFM.Rows.Count = _RowFixed;

			DataTable vDt = Select_CFM_Style_Info();

			int dt_rows = vDt.Rows.Count;
			int dt_cols = vDt.Columns.Count;

			for(int i = 0; i < dt_rows; i++)
			{
				grdCFM.AddItem(vDt.Rows[i].ItemArray, grdCFM.Rows.Count, 1);
				grdCFM[i+grdCFM.Rows.Fixed,0] = false;

				//Setting New Color 
				if (grdCFM[i,1].ToString() == "NEW")
				{
					CellRange cr1 = grdCFM.GetCellRange(i, 1, i, 14);
					cr1.StyleNew.BackColor = Color.LightGreen;
				}
				else if (grdCFM[i,1].ToString() == "RPT")
				{
					CellRange cr1 = grdCFM.GetCellRange(i, 1, i, 14);
					cr1.StyleNew.BackColor = Color.GreenYellow;
				}
			}
			grdCFM.Cols[0].AllowEditing = true;
			grdCFM.AutoSizeCols();
			grdCFM.Cols[0].Width = 16;
		}

		private void Send_Mother_Form()
		{
			frmCFMAdd.cmbFactory.SelectedValue   = grdCFM[grdCFM.Row, 1].ToString();   //Factory
			frmCFMAdd.cmbSeason.SelectedValue    = grdCFM[grdCFM.Row, 3].ToString();   //Season Cd
			frmCFMAdd.txtDPO.Text                = grdCFM[grdCFM.Row, 4].ToString();   //DPO ID
			frmCFMAdd.txtStyleNo.Text            = grdCFM[grdCFM.Row, 5].ToString();   //Style Code
			frmCFMAdd.txtStyleName.Text          = grdCFM[grdCFM.Row, 6].ToString();   //Style name
			frmCFMAdd.txtShipDate.Text           = grdCFM[grdCFM.Row, 2].ToString();   //Ship Date
			frmCFMAdd.cmbGender.SelectedValue    = grdCFM[grdCFM.Row, 7].ToString();   //Gender
			frmCFMAdd.cmbCategory.SelectedValue  = grdCFM[grdCFM.Row, 8].ToString();   //Cat Cd
			//frmCFMAdd.cmbCategory.SelectedText  = grdCFM[grdCFM.Row, 9].ToString();  //Category
			frmCFMAdd.txtQty.Text                = grdCFM[grdCFM.Row, 13].ToString();  //Qty
			frmCFMAdd.cmbDeveloper.SelectedValue = grdCFM[grdCFM.Row, 10].ToString();  //Developer
			frmCFMAdd.txtAssyDate1.Text          = grdCFM[grdCFM.Row, 11].ToString();  //Assy Date1
			frmCFMAdd.txtAssyDate2.Text          = grdCFM[grdCFM.Row, 12].ToString();  //Assy Date2
		}

		#endregion  

		#region DB 컨넥트

		/// <summary>
		/// SDC_PJ_TAIL : FACTORY = 'DS' -> SEASON
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Sdc_CFM_Season()
		{
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_SEASON";

			OraDB.ReDim_Parameter(1);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		
		/// <summary>
		/// SDC_PJ_HEAD,TAIL/SEM_OBS, SDC_STYLE : Style Information 
		/// </summary>
		/// <returns></returns>
		private DataTable Select_CFM_Style_Info()
		{
			string Proc_Name;

			if (chkDPO.Checked == false)
			{
				Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_STYLE_INFO";
			}
			else
			{
				Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_STYLE_DPO";
			}


			OraDB.ReDim_Parameter(5);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_DPO_ID";
			OraDB.Parameter_Name[2] = "ARG_SEASON";
			OraDB.Parameter_Name[3] = "ARG_STYLE_NO";
			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cmbFactory.SelectedValue.ToString(); 
			OraDB.Parameter_Values[1] = cmbDPO.SelectedValue.ToString(); 
			OraDB.Parameter_Values[2] = cmbSeason.SelectedValue.ToString(); 
			OraDB.Parameter_Values[3] = txtStyle.Text.Trim().ToString(); 
			OraDB.Parameter_Values[4] = ""; 

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		/// <summary>
		/// SDC_PJ_TAIL : CDC DPO ID ComboBox
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Sdc_CFM_Dpo()
		{
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_SEM_DPO";

			OraDB.ReDim_Parameter(1);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		/// <summary>
		/// Save new style
		/// </summary>
		/// <returns></returns>
		private void Save_CFM_Style(int iRow)
		{
			OraDB.ReDim_Parameter(20); 

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDC_CFM.SAVE_NEW_CFM_SCH";
 
			//02.ARGURMENT명
			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_STYLE_CD";
			OraDB.Parameter_Name[2]  = "ARG_STYLE_NAME";
			OraDB.Parameter_Name[3]  = "ARG_SEASON_CD";
			OraDB.Parameter_Name[4]  = "ARG_DPO_ID";
			OraDB.Parameter_Name[5]  = "ARG_SHIP_DATE";
			OraDB.Parameter_Name[6]  = "ARG_GENDER";
			OraDB.Parameter_Name[7]  = "ARG_CAT_CD";
			OraDB.Parameter_Name[8]  = "ARG_CATEGORY";
			OraDB.Parameter_Name[9]  = "ARG_QTY";
			OraDB.Parameter_Name[10] = "ARG_CDC_DEV";
			OraDB.Parameter_Name[11] = "ARG_SPEC_DATE";
			OraDB.Parameter_Name[12] = "ARG_SBOOK_DATE";
			OraDB.Parameter_Name[13] = "ARG_CFMSHOE_DATE";
			OraDB.Parameter_Name[14] = "ARG_ASSY_DATE1";
			OraDB.Parameter_Name[15] = "ARG_ASSY_DATE2";
			OraDB.Parameter_Name[16] = "ARG_CFM_REMARK";
			OraDB.Parameter_Name[17] = "ARG_UPD_USER";
			OraDB.Parameter_Name[18] = "ARG_UPD_USER_F";
			OraDB.Parameter_Name[19] = "ARG_UPD_FACTORY";

			//03.DATA TYPE
			OraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[11] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[12] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[13] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[14] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[15] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[16] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[17] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[18] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[19] = (int)OracleType.VarChar;

			//04.grdCFM DATA 정의
			//   (1):Factory,(2):Ship Date,(3):Season,(4):DPO,(5):StyleNo,(6):StyleName,(7):Gender,
			//   (8):Category CD,(9):Category,(10):Developer,(11):Assembly Date1,(12):Assembly Date2,(13):Qty
			OraDB.Parameter_Values[0]  = grdCFM[iRow, 2].ToString();   //Factory
			OraDB.Parameter_Values[1]  = grdCFM[iRow, 6].ToString();   //Style Code
			OraDB.Parameter_Values[2]  = grdCFM[iRow, 7].ToString();   //Style name
			OraDB.Parameter_Values[3]  = grdCFM[iRow, 4].ToString();   //Season Cd
			OraDB.Parameter_Values[4]  = grdCFM[iRow, 5].ToString();   //DPO ID
			OraDB.Parameter_Values[5]  = grdCFM[iRow, 3].ToString();   //Ship Date
			OraDB.Parameter_Values[6]  = grdCFM[iRow, 8].ToString();   //Gender
			OraDB.Parameter_Values[7]  = grdCFM[iRow, 9].ToString();   //Cat Cd
			OraDB.Parameter_Values[8]  = grdCFM[iRow, 10].ToString();  //Category
			OraDB.Parameter_Values[9]  = grdCFM[iRow, 14].ToString();  //Qty
			OraDB.Parameter_Values[10] = grdCFM[iRow, 11].ToString();  //Developer
			OraDB.Parameter_Values[11] = "";                           //Spec Date
			OraDB.Parameter_Values[12] = "";                           //SBook Date
			OraDB.Parameter_Values[13] = "";                           //CFM Shoe Date
			OraDB.Parameter_Values[14] = grdCFM[iRow, 12].ToString();  //Assy Date1
			OraDB.Parameter_Values[15] = grdCFM[iRow, 13].ToString();  //Assy Date2
			OraDB.Parameter_Values[16] = "";                           //CFM Remark
			OraDB.Parameter_Values[17] = (ClassLib.ComVar.This_Factory == "DS") ? ClassLib.ComVar.This_User : "";
			OraDB.Parameter_Values[18] = (ClassLib.ComVar.This_Factory == "DS") ? "" : ClassLib.ComVar.This_User; 
			OraDB.Parameter_Values[18] = ClassLib.ComVar.This_Factory;

			OraDB.Add_Modify_Parameter(true);
			OraDB.Exe_Modify_Procedure();
			// 저장성공여부 Check Rootin 
		}

		#endregion 

		private void Pop_CFM_Select_Style_Load(object sender, System.EventArgs e)
		{
			//Init_Form();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			if (chkDPO.Checked == false)
			{
				if (cmbDPO.SelectedIndex == 0 && cmbSeason.SelectedIndex == 0 && txtStyle.Text.ToString().Trim() == "")
				{
					MessageBox.Show("Please, select DPO combobox, Season Combobox or Style Code.","Confirm!");
					return;
				}
			}
			else
			{
				if (cmbDPO.SelectedIndex == 0)
				{
					MessageBox.Show("Please, select DPO combobox.","Confirm!");
					return;
				}
			}

			this.Cursor = Cursors.WaitCursor;

			Show_grdCFM_Data();

			this.Cursor = Cursors.Default;
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (grdCFM.Rows.Count <= _RowFixed)
			{
				MessageBox.Show("No data. Please, selected Style list!");
				return;
			}

			DialogResult vOK = MessageBox.Show("Save OK?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (vOK == DialogResult.OK)
			{
				int t = 0;

				for (int i = _RowFixed; i < grdCFM.Rows.Count; i++)
				{
					if (grdCFM[i,0].Equals(true))
					{
						t = t + 1;
						try
						{
							Save_CFM_Style(i);   //Save SDC_CFM_SCH & HISTORY 
						}
						catch (Exception Error)
						{
							MessageBox.Show(Error.Message);
							return;
						}
					}
				}

				if (t == 0)
				{
					MessageBox.Show("No save a data!!");
				}
				else
				{
					MessageBox.Show("Save completed [" + t.ToString() + "] Record !!");
					//Save처리 후 해당 Column삭제 처리.
					for (int j = _RowFixed; j < grdCFM.Rows.Count; j++)
					{
						if (grdCFM[1,0] != null || grdCFM[j,0].Equals(true))
						{
							grdCFM.RemoveItem(j);
							j = j - 1;
						}
						
						frmCFMSch.Show_grdCFM_Data();
					}
				}
			}		
		}

		private void grdCFM_Click(object sender, System.EventArgs e)
		{
			if(frmCFMAdd != null)
			{
				if(grdCFM[grdCFM.Row, 0].Equals(true))
				{
					Send_Mother_Form();
					Close();
				}
			}
		}

		private void grdCFM_DoubleClick(object sender, System.EventArgs e)
		{
			if (frmCFMAdd != null)
			{
				Send_Mother_Form();
				Close();
			}
		}

		private void chkDPO_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkDPO.Checked == true)
			{
				cmbSeason.SelectedIndex = 0;
				cmbSeason.Enabled       = false;
				txtStyle.Text           = "";
				txtStyle.Enabled        = false;
			}
			else
			{
				cmbSeason.Enabled       = true;
				txtStyle.Enabled        = true;
			}
		}

	}



}

