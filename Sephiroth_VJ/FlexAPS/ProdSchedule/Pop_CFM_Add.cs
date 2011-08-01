using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexAPS.ProdSchedule
{
	public class Pop_CFM_Add : COM.APSWinForm.Pop_Small
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ImageList imgs_new_btn;
		public System.Windows.Forms.TextBox txtStyleNo;
		private System.Windows.Forms.Label lblDPO;
		private System.Windows.Forms.Label lblFactory;
		public System.Windows.Forms.TextBox txtStyleName;
		private System.Windows.Forms.Label lblSeason;
		private System.Windows.Forms.Label lblShipDate;
		private System.Windows.Forms.Label lblStyleName;
		private System.Windows.Forms.Label lblStyleNo;
		private System.Windows.Forms.Label lblDeveloper;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Label lblSBookDate;
		private System.Windows.Forms.Label lblSpecDate;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.Label lblRemark;
		private System.Windows.Forms.Label lblAssyDate;
		private System.Windows.Forms.Label lblCFMDate;
		public C1.Win.C1List.C1Combo cmbSeason;
		public C1.Win.C1List.C1Combo cmbGender;
		public C1.Win.C1List.C1Combo cmbCategory;
		public C1.Win.C1List.C1Combo cmbDeveloper;
		public System.Windows.Forms.TextBox txtQty;
		public System.Windows.Forms.TextBox txtRemarks;
		public System.Windows.Forms.TextBox txtAssyDate1;
		public System.Windows.Forms.TextBox txtAssyDate2;
		public C1.Win.C1List.C1Combo cmbFactory;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		public System.Windows.Forms.DateTimePicker dateSpec;
		public System.Windows.Forms.DateTimePicker dateSBook;
		public System.Windows.Forms.DateTimePicker dateCFM;
		private System.Windows.Forms.Label lblDash;
		public System.Windows.Forms.TextBox txtShipDate;
		private System.Windows.Forms.Button btnSearch;
		public System.Windows.Forms.TextBox txtDPO;
		private System.Windows.Forms.CheckBox chkSpec;
		private System.Windows.Forms.CheckBox chkSBook;
		private System.Windows.Forms.CheckBox chkCFM;
		private COM.OraDB OraDB = new COM.OraDB();

		public Pop_CFM_Add(bool QueryOK)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			//this.frm_menu= frm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_CFM_Add));
			this.txtStyleNo = new System.Windows.Forms.TextBox();
			this.lblDPO = new System.Windows.Forms.Label();
			this.lblFactory = new System.Windows.Forms.Label();
			this.txtStyleName = new System.Windows.Forms.TextBox();
			this.lblSeason = new System.Windows.Forms.Label();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.lblShipDate = new System.Windows.Forms.Label();
			this.lblStyleName = new System.Windows.Forms.Label();
			this.lblStyleNo = new System.Windows.Forms.Label();
			this.lblDeveloper = new System.Windows.Forms.Label();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblSBookDate = new System.Windows.Forms.Label();
			this.lblSpecDate = new System.Windows.Forms.Label();
			this.lblQty = new System.Windows.Forms.Label();
			this.lblRemark = new System.Windows.Forms.Label();
			this.lblAssyDate = new System.Windows.Forms.Label();
			this.lblCFMDate = new System.Windows.Forms.Label();
			this.cmbSeason = new C1.Win.C1List.C1Combo();
			this.cmbGender = new C1.Win.C1List.C1Combo();
			this.cmbCategory = new C1.Win.C1List.C1Combo();
			this.cmbDeveloper = new C1.Win.C1List.C1Combo();
			this.dateSpec = new System.Windows.Forms.DateTimePicker();
			this.dateSBook = new System.Windows.Forms.DateTimePicker();
			this.dateCFM = new System.Windows.Forms.DateTimePicker();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.txtAssyDate1 = new System.Windows.Forms.TextBox();
			this.txtAssyDate2 = new System.Windows.Forms.TextBox();
			this.cmbFactory = new C1.Win.C1List.C1Combo();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblDash = new System.Windows.Forms.Label();
			this.txtShipDate = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtDPO = new System.Windows.Forms.TextBox();
			this.chkSpec = new System.Windows.Forms.CheckBox();
			this.chkSBook = new System.Windows.Forms.CheckBox();
			this.chkCFM = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.cmbSeason)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbGender)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbDeveloper)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbFactory)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ImageSize = new System.Drawing.Size(117, 21);
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// txtStyleNo
			// 
			this.txtStyleNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStyleNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtStyleNo.Location = new System.Drawing.Point(144, 120);
			this.txtStyleNo.MaxLength = 9;
			this.txtStyleNo.Name = "txtStyleNo";
			this.txtStyleNo.Size = new System.Drawing.Size(192, 22);
			this.txtStyleNo.TabIndex = 4;
			this.txtStyleNo.Text = "";
			this.txtStyleNo.Leave += new System.EventHandler(this.txtStyleNo_Leave);
			// 
			// lblDPO
			// 
			this.lblDPO.ImageIndex = 0;
			this.lblDPO.ImageList = this.img_Label;
			this.lblDPO.Location = new System.Drawing.Point(24, 96);
			this.lblDPO.Name = "lblDPO";
			this.lblDPO.Size = new System.Drawing.Size(117, 23);
			this.lblDPO.TabIndex = 69;
			this.lblDPO.Text = "DPO ID : ";
			this.lblDPO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblFactory
			// 
			this.lblFactory.ImageIndex = 0;
			this.lblFactory.ImageList = this.img_Label;
			this.lblFactory.Location = new System.Drawing.Point(24, 48);
			this.lblFactory.Name = "lblFactory";
			this.lblFactory.Size = new System.Drawing.Size(117, 23);
			this.lblFactory.TabIndex = 68;
			this.lblFactory.Text = "Factory : ";
			this.lblFactory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtStyleName
			// 
			this.txtStyleName.BackColor = System.Drawing.Color.White;
			this.txtStyleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStyleName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txtStyleName.Location = new System.Drawing.Point(144, 144);
			this.txtStyleName.MaxLength = 50;
			this.txtStyleName.Name = "txtStyleName";
			this.txtStyleName.Size = new System.Drawing.Size(216, 21);
			this.txtStyleName.TabIndex = 5;
			this.txtStyleName.Text = "";
			// 
			// lblSeason
			// 
			this.lblSeason.ImageIndex = 0;
			this.lblSeason.ImageList = this.img_Label;
			this.lblSeason.Location = new System.Drawing.Point(24, 72);
			this.lblSeason.Name = "lblSeason";
			this.lblSeason.Size = new System.Drawing.Size(117, 23);
			this.lblSeason.TabIndex = 158;
			this.lblSeason.Text = "Season :";
			this.lblSeason.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lblShipDate
			// 
			this.lblShipDate.ImageIndex = 0;
			this.lblShipDate.ImageList = this.img_Label;
			this.lblShipDate.Location = new System.Drawing.Point(24, 168);
			this.lblShipDate.Name = "lblShipDate";
			this.lblShipDate.Size = new System.Drawing.Size(117, 23);
			this.lblShipDate.TabIndex = 235;
			this.lblShipDate.Text = "Ship Date :";
			this.lblShipDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblStyleName
			// 
			this.lblStyleName.ImageIndex = 0;
			this.lblStyleName.ImageList = this.img_Label;
			this.lblStyleName.Location = new System.Drawing.Point(24, 144);
			this.lblStyleName.Name = "lblStyleName";
			this.lblStyleName.Size = new System.Drawing.Size(117, 23);
			this.lblStyleName.TabIndex = 234;
			this.lblStyleName.Text = "Style(Model) :";
			this.lblStyleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblStyleNo
			// 
			this.lblStyleNo.ImageIndex = 0;
			this.lblStyleNo.ImageList = this.img_Label;
			this.lblStyleNo.Location = new System.Drawing.Point(24, 120);
			this.lblStyleNo.Name = "lblStyleNo";
			this.lblStyleNo.Size = new System.Drawing.Size(117, 23);
			this.lblStyleNo.TabIndex = 233;
			this.lblStyleNo.Text = "Style No :";
			this.lblStyleNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDeveloper
			// 
			this.lblDeveloper.ImageIndex = 0;
			this.lblDeveloper.ImageList = this.img_Label;
			this.lblDeveloper.Location = new System.Drawing.Point(24, 240);
			this.lblDeveloper.Name = "lblDeveloper";
			this.lblDeveloper.Size = new System.Drawing.Size(117, 23);
			this.lblDeveloper.TabIndex = 238;
			this.lblDeveloper.Text = "Developer :";
			this.lblDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCategory
			// 
			this.lblCategory.ImageIndex = 0;
			this.lblCategory.ImageList = this.img_Label;
			this.lblCategory.Location = new System.Drawing.Point(24, 216);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(117, 23);
			this.lblCategory.TabIndex = 237;
			this.lblCategory.Text = "Category :";
			this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblGender
			// 
			this.lblGender.ImageIndex = 0;
			this.lblGender.ImageList = this.img_Label;
			this.lblGender.Location = new System.Drawing.Point(24, 192);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(117, 23);
			this.lblGender.TabIndex = 236;
			this.lblGender.Text = "Gender :";
			this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSBookDate
			// 
			this.lblSBookDate.ImageIndex = 0;
			this.lblSBookDate.ImageList = this.img_Label;
			this.lblSBookDate.Location = new System.Drawing.Point(24, 312);
			this.lblSBookDate.Name = "lblSBookDate";
			this.lblSBookDate.Size = new System.Drawing.Size(117, 23);
			this.lblSBookDate.TabIndex = 241;
			this.lblSBookDate.Text = "S/Book Plan Date :";
			this.lblSBookDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSpecDate
			// 
			this.lblSpecDate.ImageIndex = 0;
			this.lblSpecDate.ImageList = this.img_Label;
			this.lblSpecDate.Location = new System.Drawing.Point(24, 288);
			this.lblSpecDate.Name = "lblSpecDate";
			this.lblSpecDate.Size = new System.Drawing.Size(117, 23);
			this.lblSpecDate.TabIndex = 240;
			this.lblSpecDate.Text = "Spec Plan Date : ";
			this.lblSpecDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblQty
			// 
			this.lblQty.ImageIndex = 0;
			this.lblQty.ImageList = this.img_Label;
			this.lblQty.Location = new System.Drawing.Point(24, 264);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(117, 23);
			this.lblQty.TabIndex = 239;
			this.lblQty.Text = "Quantity :";
			this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblRemark
			// 
			this.lblRemark.ImageIndex = 0;
			this.lblRemark.ImageList = this.img_Label;
			this.lblRemark.Location = new System.Drawing.Point(24, 384);
			this.lblRemark.Name = "lblRemark";
			this.lblRemark.Size = new System.Drawing.Size(117, 23);
			this.lblRemark.TabIndex = 244;
			this.lblRemark.Text = "Remark :";
			this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblAssyDate
			// 
			this.lblAssyDate.ImageIndex = 0;
			this.lblAssyDate.ImageList = this.img_Label;
			this.lblAssyDate.Location = new System.Drawing.Point(24, 360);
			this.lblAssyDate.Name = "lblAssyDate";
			this.lblAssyDate.Size = new System.Drawing.Size(117, 23);
			this.lblAssyDate.TabIndex = 243;
			this.lblAssyDate.Text = "Assembly Date :";
			this.lblAssyDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCFMDate
			// 
			this.lblCFMDate.ImageIndex = 0;
			this.lblCFMDate.ImageList = this.img_Label;
			this.lblCFMDate.Location = new System.Drawing.Point(24, 336);
			this.lblCFMDate.Name = "lblCFMDate";
			this.lblCFMDate.Size = new System.Drawing.Size(117, 23);
			this.lblCFMDate.TabIndex = 242;
			this.lblCFMDate.Text = "CFM Shoe Date :";
			this.lblCFMDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.cmbSeason.Location = new System.Drawing.Point(144, 72);
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
			this.cmbSeason.Size = new System.Drawing.Size(216, 21);
			this.cmbSeason.TabIndex = 2;
			// 
			// cmbGender
			// 
			this.cmbGender.AddItemCols = 0;
			this.cmbGender.AddItemSeparator = ';';
			this.cmbGender.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbGender.Caption = "";
			this.cmbGender.CaptionHeight = 17;
			this.cmbGender.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbGender.ColumnCaptionHeight = 18;
			this.cmbGender.ColumnFooterHeight = 18;
			this.cmbGender.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbGender.ContentHeight = 17;
			this.cmbGender.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbGender.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbGender.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbGender.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbGender.EditorHeight = 17;
			this.cmbGender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbGender.GapHeight = 2;
			this.cmbGender.ItemHeight = 15;
			this.cmbGender.Location = new System.Drawing.Point(144, 192);
			this.cmbGender.MatchEntryTimeout = ((long)(2000));
			this.cmbGender.MaxDropDownItems = ((short)(5));
			this.cmbGender.MaxLength = 32767;
			this.cmbGender.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.PartialRightColumn = false;
			this.cmbGender.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbGender.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbGender.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbGender.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbGender.Size = new System.Drawing.Size(216, 21);
			this.cmbGender.TabIndex = 7;
			// 
			// cmbCategory
			// 
			this.cmbCategory.AddItemCols = 0;
			this.cmbCategory.AddItemSeparator = ';';
			this.cmbCategory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbCategory.Caption = "";
			this.cmbCategory.CaptionHeight = 17;
			this.cmbCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbCategory.ColumnCaptionHeight = 18;
			this.cmbCategory.ColumnFooterHeight = 18;
			this.cmbCategory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbCategory.ContentHeight = 17;
			this.cmbCategory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbCategory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbCategory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbCategory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbCategory.EditorHeight = 17;
			this.cmbCategory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbCategory.GapHeight = 2;
			this.cmbCategory.ItemHeight = 15;
			this.cmbCategory.Location = new System.Drawing.Point(144, 216);
			this.cmbCategory.MatchEntryTimeout = ((long)(2000));
			this.cmbCategory.MaxDropDownItems = ((short)(5));
			this.cmbCategory.MaxLength = 32767;
			this.cmbCategory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.PartialRightColumn = false;
			this.cmbCategory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbCategory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbCategory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbCategory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbCategory.Size = new System.Drawing.Size(216, 21);
			this.cmbCategory.TabIndex = 8;
			// 
			// cmbDeveloper
			// 
			this.cmbDeveloper.AddItemCols = 0;
			this.cmbDeveloper.AddItemSeparator = ';';
			this.cmbDeveloper.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbDeveloper.Caption = "";
			this.cmbDeveloper.CaptionHeight = 17;
			this.cmbDeveloper.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbDeveloper.ColumnCaptionHeight = 18;
			this.cmbDeveloper.ColumnFooterHeight = 18;
			this.cmbDeveloper.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbDeveloper.ContentHeight = 17;
			this.cmbDeveloper.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbDeveloper.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbDeveloper.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbDeveloper.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbDeveloper.EditorHeight = 17;
			this.cmbDeveloper.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbDeveloper.GapHeight = 2;
			this.cmbDeveloper.ItemHeight = 15;
			this.cmbDeveloper.Location = new System.Drawing.Point(144, 240);
			this.cmbDeveloper.MatchEntryTimeout = ((long)(2000));
			this.cmbDeveloper.MaxDropDownItems = ((short)(5));
			this.cmbDeveloper.MaxLength = 32767;
			this.cmbDeveloper.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbDeveloper.Name = "cmbDeveloper";
			this.cmbDeveloper.PartialRightColumn = false;
			this.cmbDeveloper.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbDeveloper.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbDeveloper.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbDeveloper.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbDeveloper.Size = new System.Drawing.Size(216, 21);
			this.cmbDeveloper.TabIndex = 9;
			// 
			// dateSpec
			// 
			this.dateSpec.CustomFormat = "yyyyMMdd";
			this.dateSpec.Font = new System.Drawing.Font("Verdana", 9F);
			this.dateSpec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateSpec.Location = new System.Drawing.Point(144, 288);
			this.dateSpec.Name = "dateSpec";
			this.dateSpec.Size = new System.Drawing.Size(100, 22);
			this.dateSpec.TabIndex = 11;
			this.dateSpec.ValueChanged += new System.EventHandler(this.dateSpec_ValueChanged);
			// 
			// dateSBook
			// 
			this.dateSBook.CustomFormat = "yyyyMMdd";
			this.dateSBook.Font = new System.Drawing.Font("Verdana", 9F);
			this.dateSBook.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateSBook.Location = new System.Drawing.Point(144, 312);
			this.dateSBook.Name = "dateSBook";
			this.dateSBook.Size = new System.Drawing.Size(100, 22);
			this.dateSBook.TabIndex = 12;
			this.dateSBook.ValueChanged += new System.EventHandler(this.dateSBook_ValueChanged);
			// 
			// dateCFM
			// 
			this.dateCFM.CustomFormat = "yyyyMMdd";
			this.dateCFM.Font = new System.Drawing.Font("Verdana", 9F);
			this.dateCFM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateCFM.Location = new System.Drawing.Point(144, 336);
			this.dateCFM.Name = "dateCFM";
			this.dateCFM.Size = new System.Drawing.Size(100, 22);
			this.dateCFM.TabIndex = 13;
			// 
			// txtQty
			// 
			this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtQty.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(144, 264);
			this.txtQty.MaxLength = 20;
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(216, 22);
			this.txtQty.TabIndex = 10;
			this.txtQty.Text = "";
			this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtRemarks
			// 
			this.txtRemarks.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRemarks.Font = new System.Drawing.Font("Verdana", 8F);
			this.txtRemarks.ForeColor = System.Drawing.Color.Black;
			this.txtRemarks.Location = new System.Drawing.Point(144, 384);
			this.txtRemarks.MaxLength = 100;
			this.txtRemarks.Multiline = true;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtRemarks.Size = new System.Drawing.Size(216, 104);
			this.txtRemarks.TabIndex = 17;
			this.txtRemarks.Text = "";
			// 
			// txtAssyDate1
			// 
			this.txtAssyDate1.BackColor = System.Drawing.Color.Gainsboro;
			this.txtAssyDate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAssyDate1.Enabled = false;
			this.txtAssyDate1.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txtAssyDate1.Location = new System.Drawing.Point(144, 360);
			this.txtAssyDate1.MaxLength = 20;
			this.txtAssyDate1.Name = "txtAssyDate1";
			this.txtAssyDate1.Size = new System.Drawing.Size(99, 21);
			this.txtAssyDate1.TabIndex = 15;
			this.txtAssyDate1.Text = "";
			this.txtAssyDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtAssyDate2
			// 
			this.txtAssyDate2.BackColor = System.Drawing.Color.Gainsboro;
			this.txtAssyDate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAssyDate2.Enabled = false;
			this.txtAssyDate2.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txtAssyDate2.Location = new System.Drawing.Point(264, 360);
			this.txtAssyDate2.MaxLength = 20;
			this.txtAssyDate2.Name = "txtAssyDate2";
			this.txtAssyDate2.Size = new System.Drawing.Size(99, 21);
			this.txtAssyDate2.TabIndex = 16;
			this.txtAssyDate2.Text = "";
			this.txtAssyDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.cmbFactory.Location = new System.Drawing.Point(144, 48);
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
			this.cmbFactory.Size = new System.Drawing.Size(216, 21);
			this.cmbFactory.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.ImageList = this.imgs_new_btn;
			this.btnSave.Location = new System.Drawing.Point(32, 496);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(80, 24);
			this.btnSave.TabIndex = 18;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ImageList = this.imgs_new_btn;
			this.btnClose.Location = new System.Drawing.Point(280, 496);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 24);
			this.btnClose.TabIndex = 19;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblDash
			// 
			this.lblDash.BackColor = System.Drawing.Color.Transparent;
			this.lblDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblDash.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lblDash.Location = new System.Drawing.Point(246, 362);
			this.lblDash.Name = "lblDash";
			this.lblDash.Size = new System.Drawing.Size(16, 20);
			this.lblDash.TabIndex = 309;
			this.lblDash.Text = "~";
			this.lblDash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtShipDate
			// 
			this.txtShipDate.BackColor = System.Drawing.Color.Gainsboro;
			this.txtShipDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtShipDate.Enabled = false;
			this.txtShipDate.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txtShipDate.Location = new System.Drawing.Point(144, 168);
			this.txtShipDate.MaxLength = 20;
			this.txtShipDate.Name = "txtShipDate";
			this.txtShipDate.Size = new System.Drawing.Size(216, 21);
			this.txtShipDate.TabIndex = 6;
			this.txtShipDate.Text = "";
			// 
			// btnSearch
			// 
			this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Location = new System.Drawing.Point(338, 120);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(22, 21);
			this.btnSearch.TabIndex = 310;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtDPO
			// 
			this.txtDPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDPO.Location = new System.Drawing.Point(144, 96);
			this.txtDPO.MaxLength = 6;
			this.txtDPO.Name = "txtDPO";
			this.txtDPO.Size = new System.Drawing.Size(216, 21);
			this.txtDPO.TabIndex = 3;
			this.txtDPO.Text = "";
			// 
			// chkSpec
			// 
			this.chkSpec.Location = new System.Drawing.Point(248, 288);
			this.chkSpec.Name = "chkSpec";
			this.chkSpec.TabIndex = 311;
			this.chkSpec.Text = "Spec Space";
			this.chkSpec.CheckedChanged += new System.EventHandler(this.chkSpec_CheckedChanged);
			// 
			// chkSBook
			// 
			this.chkSBook.Location = new System.Drawing.Point(248, 312);
			this.chkSBook.Name = "chkSBook";
			this.chkSBook.Size = new System.Drawing.Size(120, 24);
			this.chkSBook.TabIndex = 312;
			this.chkSBook.Text = "S/Book Space";
			this.chkSBook.CheckedChanged += new System.EventHandler(this.chkSBook_CheckedChanged);
			// 
			// chkCFM
			// 
			this.chkCFM.Location = new System.Drawing.Point(248, 336);
			this.chkCFM.Name = "chkCFM";
			this.chkCFM.TabIndex = 313;
			this.chkCFM.Text = "CFM Space";
			this.chkCFM.CheckedChanged += new System.EventHandler(this.chkCFM_CheckedChanged);
			// 
			// Pop_CFM_Add
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(386, 536);
			this.Controls.Add(this.chkCFM);
			this.Controls.Add(this.chkSBook);
			this.Controls.Add(this.chkSpec);
			this.Controls.Add(this.txtDPO);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtShipDate);
			this.Controls.Add(this.lblDash);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cmbFactory);
			this.Controls.Add(this.txtAssyDate2);
			this.Controls.Add(this.txtAssyDate1);
			this.Controls.Add(this.txtRemarks);
			this.Controls.Add(this.txtQty);
			this.Controls.Add(this.dateCFM);
			this.Controls.Add(this.dateSBook);
			this.Controls.Add(this.dateSpec);
			this.Controls.Add(this.cmbDeveloper);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.cmbGender);
			this.Controls.Add(this.cmbSeason);
			this.Controls.Add(this.lblRemark);
			this.Controls.Add(this.lblAssyDate);
			this.Controls.Add(this.lblCFMDate);
			this.Controls.Add(this.lblSBookDate);
			this.Controls.Add(this.lblSpecDate);
			this.Controls.Add(this.lblQty);
			this.Controls.Add(this.lblDeveloper);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.lblShipDate);
			this.Controls.Add(this.lblStyleName);
			this.Controls.Add(this.lblStyleNo);
			this.Controls.Add(this.txtStyleName);
			this.Controls.Add(this.lblSeason);
			this.Controls.Add(this.txtStyleNo);
			this.Controls.Add(this.lblDPO);
			this.Controls.Add(this.lblFactory);
			this.Name = "Pop_CFM_Add";
			this.Text = "Add CFM Shoe Style";
			this.Load += new System.EventHandler(this.Pop_CFM_Add_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.lblFactory, 0);
			this.Controls.SetChildIndex(this.lblDPO, 0);
			this.Controls.SetChildIndex(this.txtStyleNo, 0);
			this.Controls.SetChildIndex(this.lblSeason, 0);
			this.Controls.SetChildIndex(this.txtStyleName, 0);
			this.Controls.SetChildIndex(this.lblStyleNo, 0);
			this.Controls.SetChildIndex(this.lblStyleName, 0);
			this.Controls.SetChildIndex(this.lblShipDate, 0);
			this.Controls.SetChildIndex(this.lblGender, 0);
			this.Controls.SetChildIndex(this.lblCategory, 0);
			this.Controls.SetChildIndex(this.lblDeveloper, 0);
			this.Controls.SetChildIndex(this.lblQty, 0);
			this.Controls.SetChildIndex(this.lblSpecDate, 0);
			this.Controls.SetChildIndex(this.lblSBookDate, 0);
			this.Controls.SetChildIndex(this.lblCFMDate, 0);
			this.Controls.SetChildIndex(this.lblAssyDate, 0);
			this.Controls.SetChildIndex(this.lblRemark, 0);
			this.Controls.SetChildIndex(this.cmbSeason, 0);
			this.Controls.SetChildIndex(this.cmbGender, 0);
			this.Controls.SetChildIndex(this.cmbCategory, 0);
			this.Controls.SetChildIndex(this.cmbDeveloper, 0);
			this.Controls.SetChildIndex(this.dateSpec, 0);
			this.Controls.SetChildIndex(this.dateSBook, 0);
			this.Controls.SetChildIndex(this.dateCFM, 0);
			this.Controls.SetChildIndex(this.txtQty, 0);
			this.Controls.SetChildIndex(this.txtRemarks, 0);
			this.Controls.SetChildIndex(this.txtAssyDate1, 0);
			this.Controls.SetChildIndex(this.txtAssyDate2, 0);
			this.Controls.SetChildIndex(this.cmbFactory, 0);
			this.Controls.SetChildIndex(this.btnSave, 0);
			this.Controls.SetChildIndex(this.btnClose, 0);
			this.Controls.SetChildIndex(this.lblDash, 0);
			this.Controls.SetChildIndex(this.txtShipDate, 0);
			this.Controls.SetChildIndex(this.btnSearch, 0);
			this.Controls.SetChildIndex(this.txtDPO, 0);
			this.Controls.SetChildIndex(this.chkSpec, 0);
			this.Controls.SetChildIndex(this.chkSBook, 0);
			this.Controls.SetChildIndex(this.chkCFM, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmbSeason)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbGender)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbDeveloper)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbFactory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region DB컨넥트

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
		/// SDC_PJ_HEAD : GENDER ComboBox
		/// </summary>
		/// <paramref name=""/> Factory
		/// <paramref name=""/> Season
		/// <paramref name=""/> DPO ID
		/// <paramref name=""/> Style No
		/// <returns></returns>
		private DataTable Select_Sdc_CFM_Gender()
		{
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_GENDER";

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
		/// SDC_PJ_TAIL : CDC DPO ID ComboBox
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Sdc_CFM_Dpo()
		{
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_DPO";

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
		/// SDC_PJ_TAIL : CDC Developer ComboBox
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Sdc_CFM_Dev()
		{
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_DEV";

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
		/// Select Style data for CDC Sephiroth & CSC Sephiroth
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Style_Info()
		{
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_DEV";

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
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_STYLE_INFO";

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
			OraDB.Parameter_Values[1] = txtDPO.Text.Trim().ToString();
			OraDB.Parameter_Values[2] = cmbSeason.SelectedValue.ToString();
			OraDB.Parameter_Values[3] = txtStyleNo.Text.Trim().ToString();
			OraDB.Parameter_Values[4] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}
		
		
		/// <summary>
		/// Save new style
		/// </summary>
		/// <returns></returns>
		private void Save_CFM_Style()
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

			//04.DATA 정의
			OraDB.Parameter_Values[0]  = cmbFactory.SelectedValue.ToString();
			OraDB.Parameter_Values[1]  = txtStyleNo.Text.ToString().Trim();
			OraDB.Parameter_Values[2]  = txtStyleName.Text.ToString().Trim();
			OraDB.Parameter_Values[3]  = cmbSeason.SelectedValue.ToString();
			OraDB.Parameter_Values[4]  = txtDPO.Text.ToString().Trim();
			OraDB.Parameter_Values[5]  = txtShipDate.Text.ToString();
			OraDB.Parameter_Values[6]  = cmbGender.SelectedValue.ToString();
			OraDB.Parameter_Values[7]  = cmbCategory.SelectedValue.ToString();
			OraDB.Parameter_Values[8]  = cmbCategory.Text.ToString();
			OraDB.Parameter_Values[9]  = txtQty.Text.ToString().Trim();
			OraDB.Parameter_Values[10] = cmbDeveloper.SelectedValue.ToString();
			OraDB.Parameter_Values[11] = dateSpec.Text.ToString();
			OraDB.Parameter_Values[12] = dateSBook.Text.ToString();
			OraDB.Parameter_Values[13] = dateCFM.Text.ToString();
			OraDB.Parameter_Values[14] = txtAssyDate1.Text.ToString();
			OraDB.Parameter_Values[15] = txtAssyDate2.Text.ToString();
			OraDB.Parameter_Values[16] = txtRemarks.Text.ToString().Trim();
			OraDB.Parameter_Values[17] = (ClassLib.ComVar.This_Factory == "DS") ? ClassLib.ComVar.This_User : "";
			OraDB.Parameter_Values[18] = (ClassLib.ComVar.This_Factory == "DS") ? "" : ClassLib.ComVar.This_User; 
			OraDB.Parameter_Values[18] = ClassLib.ComVar.This_Factory;

			OraDB.Add_Modify_Parameter(true);
			OraDB.Exe_Modify_Procedure();
			// 저장성공여부 Check Rootin
		}

		#endregion 


		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			this.Text = "Add New CFM Shoe Style";
			this.lbl_MainTitle.Text = "Add New CFM Shoe Style";

			ClassLib.ComFunction.SetLangDic(this);

			//Factory Code ComboBox Link - Common Code Table
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmbFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmbFactory.SelectedValue = ClassLib.ComVar.This_Factory;

			//Season Code ComboBox List
			dt_ret = Select_Sdc_CFM_Season();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmbSeason, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
			cmbSeason.SelectedIndex = 0;

			//Gender Code ComboBox List
			dt_ret = Select_Sdc_CFM_Gender();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmbGender, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
			cmbGender.SelectedIndex = 0;

			//Category Code ComboBox Link - Common Code Table(COM_Code = 'MD02')
			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"MD02");
			COM.ComCtl.Set_ComboList(dt_ret, cmbCategory, 1, 2,  false, COM.ComVar.ComboList_Visible.Code_Name);
			cmbCategory.SelectedIndex = 0;
		
			//CDC Developer ComboBox List
			dt_ret = Select_Sdc_CFM_Dev();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmbDeveloper, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
			cmbDeveloper.SelectedIndex = 0;
		}

		private void Set_Clear()
		{
			cmbFactory.SelectedValue   = ClassLib.ComVar.This_Factory;
			txtStyleNo.Text            = "";
			txtStyleName.Text          = "";
			cmbSeason.SelectedIndex    = 0;
			txtDPO.Text                = "";
			txtShipDate.Text           = "";
			cmbGender.SelectedIndex    = 0;
			cmbCategory.SelectedIndex  = 0;
			txtQty.Text                = "";
			cmbDeveloper.SelectedIndex = 0;
			txtAssyDate1.Text          = "";
			txtAssyDate2.Text          = "";
			txtRemarks.Text            = "";
		}

		private void Pop_CFM_Add_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			///
			/// Validation -
			/// 

			/// DPO ID - ///
			//- DPO ID is blank or not. 
			if (txtDPO.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Empty DPO ID, Must be insert a DPO ID!");
				txtDPO.Focus();
				return;
			}
			//- DPO ID is 6-digit numbers or not.
			if (txtDPO.Text.Trim().Length < 6)
			{
				MessageBox.Show("Its Style No. are six-digit numbers.");
				txtDPO.Focus();
				return;
			}
			//- DPO ID is numeric or character - character is error
			for (int i = 0; i<= txtDPO.Text.Trim().Length-1; i++)
			{
				if (Char.IsNumber(txtDPO.Text.ToString(), i) == false)
				{
					MessageBox.Show("Must be numeric to DPO ID.");
					txtDPO.Focus();
					return;
				}
			}

			/// Style No - ///
			//- Style No is blank or not.
			if (txtStyleNo.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Empty Style No., Must be insert a Style No.!");
				txtStyleNo.Focus();
				return;
			}
			//- Style No is 9-digit numbers or not.
			if (txtStyleNo.Text.Trim().Length < 9)
			{
				MessageBox.Show("Its Style No. are nine-digit numbers.");
				txtStyleNo.Focus();
				return;
			}
			//- Style No is numeric or character - character is error
			for (int i = 0; i<= txtStyleNo.Text.Trim().Length-1; i++)
			{
				if (Char.IsNumber(txtStyleNo.Text.ToString(), i) == false)
				{
					MessageBox.Show("Must be numeric to Style Number.");
					txtStyleNo.Focus();
					return;
				}
			}

			/// Style(Model) Name - ///
			//- Style(Model) Name is blank or not.
			if (txtStyleName.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Empty Style(Model) Name, Must be insert a Style(Model) Name!");
				txtStyleName.Focus();
				return;
			}

			/// Quantity - ///
			//- Quantity is blank or not.
			if (txtQty.Text.ToString().Trim() == "")
			{
				MessageBox.Show("Empty Quantity, Must be insert a Quantity!");
				txtQty.Focus();
				return;
			}
			//- Style No is numeric or character - character is error
			for (int i = 0; i<= txtQty.Text.Trim().Length-1; i++)
			{
				if (Char.IsNumber(txtQty.Text.ToString(), i) == false)
				{
					MessageBox.Show("Must be numeric to Quantity.");
					txtQty.Focus();
					return;
				}
			}
 
			Save_CFM_Style();

			// 저장성공여부 Check Rootin

			// 저장 성공 후 Set Clear = default
			Set_Clear();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void txtStyleNo_Leave(object sender, System.EventArgs e)
		{
			if (txtDPO.Text.Trim().ToString() != "")
			{
				//Style Name, DPO ID, Ship Date, Gender, Category, Assambly Date... etc등 가져오기.
				//MessageBox.Show(Char.IsNumber(txtStyleNo.Text.ToString(),1).ToString());
				DataTable vDT = null;

				try
				{
					vDT = Select_CFM_Style_Info();

					if (vDT.Rows.Count == 0)
					{
						MessageBox.Show("Not found ["+ txtDPO.Text.Trim().ToString() +"] Style No., Click the browser button or changed Style No. at DPO text box!");
					}
					else if (vDT.Rows.Count == 1)
					{
						//ItemArray[i] Define
						//[1]SHIP_DATE,  [2]SEASON_CD, [3]DPO_ID,      [4]STYLE_CD, 
	   					//[5]STYLE_NAME, [6]GENDER,    [10]ASSY_DATE1, [11]ASSY_DATE2,[12]QTY
						txtDPO.Text             = vDT.Rows[0].ItemArray[3].ToString();
						txtStyleNo.Text         = vDT.Rows[0].ItemArray[4].ToString();
						txtStyleName.Text       = vDT.Rows[0].ItemArray[5].ToString();
						cmbGender.SelectedValue = vDT.Rows[0].ItemArray[6].ToString();
						txtQty.Text             = vDT.Rows[0].ItemArray[12].ToString();
						cmbSeason.SelectedValue = vDT.Rows[0].ItemArray[2].ToString();
						txtShipDate.Text        = vDT.Rows[0].ItemArray[1].ToString();
						txtAssyDate1.Text       = vDT.Rows[0].ItemArray[10].ToString();
						txtAssyDate2.Text       = vDT.Rows[0].ItemArray[11].ToString();
					}
					else
					{
						string vFactory = cmbFactory.SelectedValue.ToString();
						string vSeason  = cmbSeason.SelectedValue.ToString();
						string vDPO     = txtDPO.Text.Trim().ToString();
						string vStyleNo = txtStyleNo.Text.Trim().ToString();

						NewStyle_Show(vFactory, vSeason, vDPO, vStyleNo);
					}

					vDT.Dispose();
				}
				finally
				{
					if (vDT != null)
					{
						vDT.Dispose();
					}
				}
			}
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			//Enter to minimum 6-digit numeric in Style No.
			if (txtStyleNo.Text.Trim().Length < 6)
			{
				MessageBox.Show("Enter more 6-digit numeric to open the browser of Style.");
				txtStyleNo.Focus();
				return;
			}
			
			string vFactory = cmbFactory.SelectedValue.ToString();
			string vSeason  = cmbSeason.SelectedValue.ToString();
			string vDPO     = txtDPO.Text.Trim().ToString();
			string vStyleNo = txtStyleNo.Text.Trim().ToString();

			NewStyle_Show(vFactory, vSeason, vDPO, vStyleNo);
		}

		private void NewStyle_Show(string vFactory, string vSeason, string vDPO, string vStyleNo)
		{
			ProdSchedule.Pop_CFM_Select_Style NewStyle = new FlexAPS.ProdSchedule.Pop_CFM_Select_Style(this, vFactory, vSeason, vDPO, vStyleNo);
			NewStyle.ShowDialog();
		}

		private void chkSpec_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkSpec.Checked == true)
			{
				dateSpec.CustomFormat = " ";
			}
			else
			{
				dateSpec.CustomFormat = "yyyyMMdd";
			}
		}

		private void dateSpec_ValueChanged(object sender, System.EventArgs e)
		{
			chkSpec.Checked = false;
		}

		private void chkSBook_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkSBook.Checked == true)
			{
				dateSBook.CustomFormat = " ";
			}
			else
			{
				dateSBook.CustomFormat = "yyyyMMdd";
			}
		}

		private void dateSBook_ValueChanged(object sender, System.EventArgs e)
		{
			chkSBook.Checked = false;
		}

		private void chkCFM_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkCFM.Checked == true)
			{
				dateCFM.CustomFormat = " ";
			}
			else
			{
				dateCFM.CustomFormat = "yyyyMMdd";
			}
		}
	}
}

