using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using Lassalle.Flow;

namespace FlexAPS.ProdOrder
{
	/// <summary>
	/// Form1에 대한 요약 설명입니다.
	/// </summary>
	public class Form_PO_Lot_Display : System.Windows.Forms.Form
	{

		#region 컨트롤 정의 및 리소스 정리 

		public System.Windows.Forms.ImageList img_Label;
		public System.Windows.Forms.ImageList img_Button;
		public System.Windows.Forms.StatusBar stbar;
		public System.Windows.Forms.Label lbl_MainTitle;
		public System.Windows.Forms.Panel pnl_LeftSearch;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_ESearch;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.Label btn_PopPgId;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label btn_Search;
		private C1.Win.C1List.C1Combo cmb_FromDate;
		private C1.Win.C1List.C1Combo cmb_ToDate;
		private Lassalle.Flow.AddFlow addflow_Main;
		private System.ComponentModel.IContainer components;

		public Form_PO_Lot_Display()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_Lot_Display));
			this.img_Label = new System.Windows.Forms.ImageList(this.components);
			this.img_Button = new System.Windows.Forms.ImageList(this.components);
			this.lbl_MainTitle = new System.Windows.Forms.Label();
			this.stbar = new System.Windows.Forms.StatusBar();
			this.pnl_LeftSearch = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.btn_Search = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_ToDate = new C1.Win.C1List.C1Combo();
			this.btn_ESearch = new System.Windows.Forms.Label();
			this.cmb_FromDate = new C1.Win.C1List.C1Combo();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.btn_PopPgId = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.addflow_Main = new Lassalle.Flow.AddFlow();
			this.pnl_LeftSearch.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ToDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_FromDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Label.ImageSize = new System.Drawing.Size(100, 21);
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			this.img_Label.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_Button
			// 
			this.img_Button.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Button.ImageSize = new System.Drawing.Size(80, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbl_MainTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MainTitle.ForeColor = System.Drawing.Color.Navy;
			this.lbl_MainTitle.Location = new System.Drawing.Point(64, 26);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(312, 23);
			this.lbl_MainTitle.TabIndex = 24;
			this.lbl_MainTitle.Text = "title";
			this.lbl_MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 644);
			this.stbar.Name = "stbar";
			this.stbar.ShowPanels = true;
			this.stbar.Size = new System.Drawing.Size(1016, 22);
			this.stbar.TabIndex = 26;
			// 
			// pnl_LeftSearch
			// 
			this.pnl_LeftSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_LeftSearch.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_LeftSearch.Controls.Add(this.pnl_SearchImage);
			this.pnl_LeftSearch.DockPadding.Bottom = 8;
			this.pnl_LeftSearch.DockPadding.Left = 8;
			this.pnl_LeftSearch.DockPadding.Right = 8;
			this.pnl_LeftSearch.Location = new System.Drawing.Point(0, 64);
			this.pnl_LeftSearch.Name = "pnl_LeftSearch";
			this.pnl_LeftSearch.Size = new System.Drawing.Size(1016, 90);
			this.pnl_LeftSearch.TabIndex = 41;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.btn_Search);
			this.pnl_SearchImage.Controls.Add(this.label1);
			this.pnl_SearchImage.Controls.Add(this.cmb_ToDate);
			this.pnl_SearchImage.Controls.Add(this.btn_ESearch);
			this.pnl_SearchImage.Controls.Add(this.cmb_FromDate);
			this.pnl_SearchImage.Controls.Add(this.lbl_Date);
			this.pnl_SearchImage.Controls.Add(this.btn_PopPgId);
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
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
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 82);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// btn_Search
			// 
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_MiniButton;
			this.btn_Search.Location = new System.Drawing.Point(322, 58);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(21, 21);
			this.btn_Search.TabIndex = 43;
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Search_MouseUp);
			this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Search_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(208, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 21);
			this.label1.TabIndex = 42;
			this.label1.Text = "~";
			// 
			// cmb_ToDate
			// 
			this.cmb_ToDate.AddItemCols = 0;
			this.cmb_ToDate.AddItemSeparator = ';';
			this.cmb_ToDate.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_ToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_ToDate.Caption = "";
			this.cmb_ToDate.CaptionHeight = 17;
			this.cmb_ToDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_ToDate.ColumnCaptionHeight = 18;
			this.cmb_ToDate.ColumnFooterHeight = 18;
			this.cmb_ToDate.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_ToDate.ContentHeight = 17;
			this.cmb_ToDate.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_ToDate.EditorBackColor = System.Drawing.Color.White;
			this.cmb_ToDate.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ToDate.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_ToDate.EditorHeight = 17;
			this.cmb_ToDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ToDate.GapHeight = 2;
			this.cmb_ToDate.ItemHeight = 15;
			this.cmb_ToDate.Location = new System.Drawing.Point(224, 58);
			this.cmb_ToDate.MatchEntryTimeout = ((long)(2000));
			this.cmb_ToDate.MaxDropDownItems = ((short)(5));
			this.cmb_ToDate.MaxLength = 32767;
			this.cmb_ToDate.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_ToDate.Name = "cmb_ToDate";
			this.cmb_ToDate.PartialRightColumn = false;
			this.cmb_ToDate.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_ToDate.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_ToDate.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_ToDate.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_ToDate.Size = new System.Drawing.Size(97, 21);
			this.cmb_ToDate.TabIndex = 38;
			this.cmb_ToDate.SelectedValueChanged += new System.EventHandler(this.cmb_ToDate_SelectedValueChanged);
			// 
			// btn_ESearch
			// 
			this.btn_ESearch.Location = new System.Drawing.Point(331, 58);
			this.btn_ESearch.Name = "btn_ESearch";
			this.btn_ESearch.Size = new System.Drawing.Size(21, 21);
			this.btn_ESearch.TabIndex = 37;
			this.btn_ESearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmb_FromDate
			// 
			this.cmb_FromDate.AddItemCols = 0;
			this.cmb_FromDate.AddItemSeparator = ';';
			this.cmb_FromDate.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_FromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_FromDate.Caption = "";
			this.cmb_FromDate.CaptionHeight = 17;
			this.cmb_FromDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_FromDate.ColumnCaptionHeight = 18;
			this.cmb_FromDate.ColumnFooterHeight = 18;
			this.cmb_FromDate.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_FromDate.ContentHeight = 17;
			this.cmb_FromDate.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_FromDate.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_FromDate.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_FromDate.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_FromDate.EditorHeight = 17;
			this.cmb_FromDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_FromDate.GapHeight = 2;
			this.cmb_FromDate.ItemHeight = 15;
			this.cmb_FromDate.Location = new System.Drawing.Point(111, 58);
			this.cmb_FromDate.MatchEntryTimeout = ((long)(2000));
			this.cmb_FromDate.MaxDropDownItems = ((short)(5));
			this.cmb_FromDate.MaxLength = 32767;
			this.cmb_FromDate.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_FromDate.Name = "cmb_FromDate";
			this.cmb_FromDate.PartialRightColumn = false;
			this.cmb_FromDate.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_FromDate.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_FromDate.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_FromDate.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_FromDate.Size = new System.Drawing.Size(97, 21);
			this.cmb_FromDate.TabIndex = 36;
			this.cmb_FromDate.SelectedValueChanged += new System.EventHandler(this.cmb_FromDate_SelectedValueChanged);
			// 
			// lbl_Date
			// 
			this.lbl_Date.ImageIndex = 0;
			this.lbl_Date.ImageList = this.img_Label;
			this.lbl_Date.Location = new System.Drawing.Point(10, 58);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(100, 21);
			this.lbl_Date.TabIndex = 35;
			this.lbl_Date.Text = "DPO";
			this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_PopPgId
			// 
			this.btn_PopPgId.Location = new System.Drawing.Point(412, 36);
			this.btn_PopPgId.Name = "btn_PopPgId";
			this.btn_PopPgId.Size = new System.Drawing.Size(21, 21);
			this.btn_PopPgId.TabIndex = 34;
			this.btn_PopPgId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_Factory.TabIndex = 33;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 32;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(985, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 42);
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
			this.picb_TM.Size = new System.Drawing.Size(776, 32);
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
			this.lbl_SubTitle1.Text = "      Select DPO";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(984, 66);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 64);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 62);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 42);
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
			this.picb_MM.Size = new System.Drawing.Size(832, 42);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// addflow_Main
			// 
			this.addflow_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.addflow_Main.AutoScroll = true;
			this.addflow_Main.AutoScrollMinSize = new System.Drawing.Size(1173, 618);
			this.addflow_Main.BackColor = System.Drawing.Color.White;
			this.addflow_Main.CanChangeDst = false;
			this.addflow_Main.CanChangeOrg = false;
			this.addflow_Main.CanDrawLink = false;
			this.addflow_Main.CanDrawNode = false;
			this.addflow_Main.CanLabelEdit = false;
			this.addflow_Main.CanMoveNode = false;
			this.addflow_Main.CanSizeNode = false;
			this.addflow_Main.Location = new System.Drawing.Point(0, 153);
			this.addflow_Main.Name = "addflow_Main";
			this.addflow_Main.Size = new System.Drawing.Size(1016, 487);
			this.addflow_Main.TabIndex = 42;
			this.addflow_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addflow_Main_MouseDown);
			// 
			// Form_PO_Lot_Display
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.addflow_Main);
			this.Controls.Add(this.pnl_LeftSearch);
			this.Controls.Add(this.stbar);
			this.Controls.Add(this.lbl_MainTitle);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form_PO_Lot_Display";
			this.Text = "Display LOT of Factory";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form_PO_Lot_Display_Load);
			this.pnl_LeftSearch.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_ToDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_FromDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();

		DataTable _DT_Req;
		DataTable _DT_Lot;
		DataTable _DT_DaySeq;
 

		ClassLib.Class_PERT[] _ReqLot;
		ClassLib.Class_PERT[] _Lot; 
		ClassLib.Class_PERT_Detail[] _DaySeq;

		#endregion 

		#region 멤버 메서드



		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			DataTable dt_list; 

			// Title 
			this.Text = "Order LOT Monitoring";
			this.lbl_MainTitle.Text = "Order LOT Monitoring"; 

			ClassLib.ComFunction.SetLangDic(this);


//			cmb_Factory.Enabled = false;


			ClassLib.ComFunction.Clear_AddFlow(addflow_Main);
 
			dt_list = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory; 

 
		}
 
		
		/// <summary>
		/// Draw_Req : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Draw_Req(DataTable arg_dt)
		{
			int start_row = 0;
			int lot_count = 0;
			int tot_req_count = 0;
			int reqlot_count = 0;

			int top = 10;

			tot_req_count = Convert.ToInt32(_DT_Req.Rows[start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxTOT_REQ_COUNT].ToString());
 
			_ReqLot = new ClassLib.Class_PERT[tot_req_count]; 

			while(true)
			{
				lot_count = Convert.ToInt32(arg_dt.Rows[start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxLOT_COUNT].ToString());

				DataRow[] dr = new DataRow[lot_count];

				for(int i = start_row; i < lot_count + start_row; i++)
				{
					dr[i - start_row] = arg_dt.Rows[i];
				}


				_ReqLot[reqlot_count] = new ClassLib.Class_PERT();
 
				//(DataRow[], addflow, left, top, width, height)
				//return :top : 다음 그릴 셋트의 시작점

				top = _ReqLot[reqlot_count].DOrder(dr, addflow_Main, 20, top + 5, 121, 15, 0);

				//-----------------------------------------------------------------------------
				//text, tag, tooltip 속성 적용

				_ReqLot[reqlot_count].HeaderCd.Text = dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxREQ_NO].ToString();
				_ReqLot[reqlot_count].HeaderCd.Tag = dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxREQ_NO].ToString();
				_ReqLot[reqlot_count].HeaderCd.Tooltip = "OBS TYPE : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxOBS_TYPE].ToString() + "\r\n"
					+ "PO NO : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxPO_NO].ToString() + "\r\n"
					+ "STYLE CODE : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxSTYLE_CD].ToString(); 
  
				_ReqLot[reqlot_count].TotQty.Text = dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxTOT_QTY].ToString();
				_ReqLot[reqlot_count].SumQty.Text = dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxSUM_LOTQTY].ToString();
				_ReqLot[reqlot_count].RemainQty.Text = dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxREMAIN_LOTQTY].ToString();


				for(int i = start_row; i < lot_count + start_row; i++)
				{
					_ReqLot[reqlot_count].DetailCd[i - start_row].Text = dr[i - start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxLOT_NO_SEQ].ToString()
						+ "(" + dr[i - start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxLOT_QTY].ToString() + ")";
					_ReqLot[reqlot_count].DetailCd[i - start_row].Tooltip = _ReqLot[reqlot_count].DetailCd[i - start_row].Text;
					_ReqLot[reqlot_count].DetailCd[i - start_row].Tag = dr[i - start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxLOT_NO_SEQ].ToString(); 

				}

				//-----------------------------------------------------------------------------


				start_row = lot_count + start_row;
				reqlot_count++;


				if(reqlot_count > tot_req_count) 
				{
					reqlot_count = 0;
					top = 10;

				} 

				if(lot_count + start_row > arg_dt.Rows.Count) break;


			}




		}

		


		/// <summary>
		/// Draw_Lot : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Draw_Lot(DataTable arg_dt)
		{  
			int start_row = 0;
			int lot_count = 0;
			int tot_lot_count = 0; 
			int drawlot_count = 0;

			int top = 10;

			tot_lot_count = arg_dt.Rows.Count; //Convert.ToInt32(_DT_Req.Rows[start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_REQ.IxTOT_REQ_COUNT].ToString());
 
 
 			_Lot = new ClassLib.Class_PERT[tot_lot_count];

			 
			while(true)
			{
				lot_count = 1;

				DataRow[] dr = new DataRow[lot_count];

				for(int i = start_row; i < lot_count + start_row; i++)
				{
					dr[i - start_row] = arg_dt.Rows[i];
				}


   				_Lot[drawlot_count] = new ClassLib.Class_PERT();  
				
				//(DataRow[], addflow, left, top, width, height, addflow 노드속성번호)
				//return :top : 다음 그릴 셋트의 시작점

				top = _Lot[drawlot_count].DOrder(dr, addflow_Main, 180, top + 5, 121, 15, 1);
    

				//-----------------------------------------------------------------------------
				//text, tag, tooltip 속성 적용

				_Lot[drawlot_count].HeaderCd.Text = dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxLOT_NO_SEQ].ToString();
				_Lot[drawlot_count].HeaderCd.Tag = _Lot[drawlot_count].HeaderCd.Text;
				_Lot[drawlot_count].HeaderCd.Tooltip = "OBS TYPE : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxOBS_TYPE].ToString() + "\r\n"
					+ "PO NO : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxPO_NO].ToString() + "\r\n"
					+ "MODEL CODE : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxMODEL_CD].ToString() + "\r\n"
					+ "STYLE CODE : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxSTYLE_CD].ToString() + "\r\n"
					+ "GENDER : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxGEN].ToString();
  
				_Lot[drawlot_count].TotQty.Text = dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxLOT_QTY].ToString();
				_Lot[drawlot_count].SumQty.Text = "";
				_Lot[drawlot_count].RemainQty.Text = "";

				for(int i = start_row; i < lot_count + start_row; i++)
				{
//					_Lot[drawlot_count].DetailCd[i - start_row].Text = dr[i - start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxLINE_CD].ToString() 
//																	+ " : " + dr[i - start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxLINE_NAME].ToString() + " "
//																	+ "(" + dr[i - start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxSTD_CAPA].ToString() + ")";

					_Lot[drawlot_count].DetailCd[i - start_row].Text = dr[i - start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxLINE_CD].ToString() + " "
																	+ "(" + dr[i - start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxSTD_CAPA].ToString() + ")";

					_Lot[drawlot_count].DetailCd[i - start_row].Tooltip = _Lot[drawlot_count].DetailCd[i - start_row].Text;
					_Lot[drawlot_count].DetailCd[i - start_row].Tag = dr[i - start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LOT.IxLINE_CD].ToString(); 

				}

				//-----------------------------------------------------------------------------
				start_row = lot_count + start_row;
				drawlot_count++;


				if(drawlot_count > tot_lot_count) 
				{
					drawlot_count = 0;
					top = 10;

				} 

				if(lot_count + start_row > arg_dt.Rows.Count) break;


			}
		}




		/// <summary>
		/// Draw_Line : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Draw_DaySeq(DataTable arg_dt)
		{  
			int start_row = 0;
			int lot_count = 0;
			int tot_lot_count = 0; 
			int drawlot_count = 0;

			int top = 10;

			string before_key = "", now_key = "";

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				now_key = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LINE.IxLOT_NO_SEQ].ToString();

				if(before_key != now_key) 
				{
					tot_lot_count++;
	
					before_key = now_key;
				}
			
			}

			
			
 

			_DaySeq = new ClassLib.Class_PERT_Detail[tot_lot_count];

			while(true)
			{
				 
				lot_count = Convert.ToInt32(arg_dt.Rows[start_row].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LINE.IxDAY_COUNT].ToString());   //1;

				DataRow[] dr = new DataRow[lot_count];

				for(int i = start_row; i < lot_count + start_row; i++)
				{
					dr[i - start_row] = arg_dt.Rows[i];
				}


				_DaySeq[drawlot_count] = new ClassLib.Class_PERT_Detail(); 


				//(DataRow[], addflow, left, top, width, height)
				//return :top : 다음 그릴 셋트의 시작점

// 				ClassLib.ComVar.Set_DOrder_Parameter sdp = new ClassLib.ComVar.Set_DOrder_Parameter();
//
//				sdp.arg_row = dr;
//				sdp.arg_addflow = addflow_Main;
//				sdp.arg_left = 400;
//				sdp.arg_top = top + 10;
//				sdp.arg_width = 100;
//				sdp.arg_height = 15;
//				sdp.arg_type = 1;t
//				sdp.arg_colcount = 4;
//				sdp.arg_rowcount = 2;
//				sdp.arg_detailyn = false;
//
//				_DaySeq[drawlot_count].ParaList = sdp; 
 
				_DaySeq[drawlot_count].ParaList.arg_row = dr;
				_DaySeq[drawlot_count].ParaList.arg_addflow = addflow_Main;
				_DaySeq[drawlot_count].ParaList.arg_left = 350;
				_DaySeq[drawlot_count].ParaList.arg_top = top + 5;
				_DaySeq[drawlot_count].ParaList.arg_width = 120;
				_DaySeq[drawlot_count].ParaList.arg_height = 15;
				_DaySeq[drawlot_count].ParaList.arg_type = 1;
				_DaySeq[drawlot_count].ParaList.arg_colcount = Convert.ToInt32(dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LINE.IxDAY_COUNT].ToString()) + 1;
				_DaySeq[drawlot_count].ParaList.arg_rowcount = 2;
				_DaySeq[drawlot_count].ParaList.arg_detailyn = false; 

				top = _DaySeq[drawlot_count].DOrder();

				//-----------------------------------------------------------------------------
				//text, tag, tooltip 속성 적용

				_DaySeq[drawlot_count].HeaderCd.Text = dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LINE.IxLOT_NO_SEQ].ToString();
				_DaySeq[drawlot_count].HeaderCd.Tag = _DaySeq[drawlot_count].HeaderCd.Text;
				_DaySeq[drawlot_count].HeaderCd.Tooltip = "OBS TYPE : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LINE.IxOBS_TYPE].ToString() + "\r\n"
													    + "PO NO : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LINE.IxPO_NO].ToString() + "\r\n"
													    + "STYLE CODE : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LINE.IxSTYLE_CD].ToString() + "\r\n"
													    + "GENDER : " + dr[0].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LINE.IxGEN].ToString();
								  
				int qty_count = 0;

				_DaySeq[drawlot_count].DayQty[qty_count].Text = "Assy. Date";
				_DaySeq[drawlot_count].DayQty[qty_count + _DaySeq[drawlot_count].ParaList.arg_colcount].Text = "AloQty";

				qty_count++;

				for(int i = 0; i < dr.Length; i++)    //_Line[drawlot_count].ParaList.arg_colcount; i++)
				{
 
					_DaySeq[drawlot_count].DayQty[qty_count].Text = dr[i].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LINE.IxPLAN_YMD].ToString();
 					_DaySeq[drawlot_count].DayQty[qty_count + _DaySeq[drawlot_count].ParaList.arg_colcount].Text = dr[i].ItemArray[(int)ClassLib.TBSPO_ADDFLOW_LINE.IxALO_QTY].ToString();

					qty_count++;

				}
				
				//-----------------------------------------------------------------------------
 


//				start_row = lot_count + start_row;
//				drawlot_count++;


				if(drawlot_count > tot_lot_count) 
				{
					drawlot_count = 0;
					top = 10;

				} 

				if(lot_count + start_row > arg_dt.Rows.Count - 1) break;


				start_row = lot_count + start_row;
				drawlot_count++;


			} // end while

		}



		/// <summary>
		/// Draw_Link : 
		/// </summary>
		private void Draw_Link()
		{ 
			int org_index, dst_index;

			Lassalle.Flow.Link link;

			//-----------------------------------------------------------
			// Req_No : Lot No-Seq
			//-----------------------------------------------------------
			for(int i = 0; i < _ReqLot.Length; i++)
			{
				for(int j = 0; j < _ReqLot[i].DetailCd.Length; j++)
				{   

					for(int k = 0; k < _Lot.Length; k++)
					{
						if(_ReqLot[i].DetailCd[j].Tag.ToString() == _Lot[k].HeaderCd.Tag.ToString())
						{
							org_index = _ReqLot[i].DetailCd[j].Index;
							dst_index = _Lot[k].HeaderCd.Index;

							link = addflow_Main.Nodes[org_index].OutLinks.Add(addflow_Main.Nodes[dst_index]); 
							Set_Link_Prop(link);

							break;
						}
					} // end for(k, _Lot.Length)
				} // end for(j, _ReqLot[i].DetailCd.Length) 
			} // end for(i, _ReqLot.Length)



			//-----------------------------------------------------------
			// Lot(Lot No-Seq) : DaySeq(Lot No-Seq)
			//-----------------------------------------------------------

			if(_DaySeq == null) return;
			if(_DaySeq.Length == 0) return;

			for(int i = 0; i < _Lot.Length; i++)
			{
				for(int j = 0; j < _DaySeq.Length; j++)
				{
					if(_Lot[i].HeaderCd.Tag.ToString() == _DaySeq[j].HeaderCd.Tag.ToString())
					{
						org_index = _Lot[i].HeaderCd.Index;
						dst_index = _DaySeq[j].HeaderCd.Index;

						link = addflow_Main.Nodes[org_index].OutLinks.Add(addflow_Main.Nodes[dst_index]); 
						Set_Link_Prop(link);

						break;

					}

				} // end j(_DaySeq.Length)
			} // end i(_Lot.Length)




		}




		/// <summary>
		/// Set_Link_Prop : 
		/// </summary>
		/// <param name="arg_link"></param>
		private void Set_Link_Prop(Lassalle.Flow.Link arg_link)
		{
				
			arg_link.ArrowDst.Style = Lassalle.Flow.ArrowStyle.Arrow;  
			arg_link.ArrowDst.Size = Lassalle.Flow.ArrowSize.Small; 
//			arg_link.ArrowDst.Angle = Lassalle.Flow.ArrowAngle.deg45; 
			arg_link.ArrowDst.Filled = true;  
			arg_link.ArrowOrg.Style = Lassalle.Flow.ArrowStyle.None;  
			arg_link.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;  
			arg_link.DrawColor = Color.Black; 
			arg_link.DrawWidth = 1; 
			arg_link.Line.Style = LineStyle.HVH;  
			arg_link.Line.RoundedCorner = true;
  
		}

 


		/// <summary>
		/// Draw_Forward : 
		/// </summary>
		/// <param name="arg_node"></param>
		private void Draw_Forward(Lassalle.Flow.Node arg_node)
		{
			Lassalle.Flow.Link link; 
				 
			int node_index; 
			string node_tag;

			for(int i = 0; i < _ReqLot.Length; i++)
			{
				if(arg_node.Tag == null) continue;

				if((arg_node.Tag).ToString() == (_ReqLot[i].HeaderCd.Tag).ToString())
				{
					for(int j = 0; j < _ReqLot[i].DetailCd.Length; j++)
					{
						node_index = _ReqLot[i].DetailCd[j].Index;
						node_tag = _ReqLot[i].DetailCd[j].Tag.ToString();

						//-----------------------------------------------

						foreach(Item item_link in addflow_Main.Items)
						{
							if(item_link is Lassalle.Flow.Link)
							{
								link = (Lassalle.Flow.Link)item_link;

								if(link.Org.Index == node_index)  
								{
									link.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
									link.DrawWidth = 2;
									link.DrawColor = Color.Red; 

								}

							} // end if
						} // end foreadch

						//------------------------------------------------
						//DaySeq까지 연결

						for(int k = 0; k < _Lot.Length; k++)
						{
							if(node_tag == _Lot[k].HeaderCd.Tag.ToString())
							{
								node_index = _Lot[k].HeaderCd.Index;

								foreach(Item item_link in addflow_Main.Items)
								{
									if(item_link is Lassalle.Flow.Link)
									{
										link = (Lassalle.Flow.Link)item_link;

										if(link.Org.Index == node_index)  
										{
											link.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
											link.DrawWidth = 2;
											link.DrawColor = Color.Red; 

										}

									} // end if
								} // end foreadch

							}
						} // end for k(_Lot.Length)
						//------------------------------------------------

 

					}
				}
			} // end for(i, _ReqLot.Length) 

				 
  
		}

 

		/// <summary>
		/// Draw_Backward : 
		/// </summary>
		/// <param name="arg_node"></param>
		private void Draw_Backward(Lassalle.Flow.Node arg_node)
		{
			Lassalle.Flow.Link link; 
				 
			int node_index;
			int tempnode_index;
			string node_tag;

			for(int i = 0; i < _Lot.Length; i++)
			{
				if(arg_node.Tag == null) continue;
 
					 
				node_index = arg_node.Index; 
				node_tag = arg_node.Tag.ToString();
				

				//-----------------------------------------------

				foreach(Item item_link in addflow_Main.Items)
				{
					if(item_link is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item_link;

						if(link.Org.Index == node_index)  
						{
							link.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
							link.DrawWidth = 2;
							link.DrawColor = Color.Red; 
 
						}

					} // end if
				} // end foreadch

					  

				foreach(Item item_link in addflow_Main.Items) 
				{
					if(item_link is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item_link;

						if(link.Dst.Index == node_index) 
						{
							link.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
							link.DrawWidth = 2;
							link.DrawColor = Color.Red; 
						}

					} // end if
				} // end foreadch

				//-----------------------------------------------

				for(int j = 0; j < _ReqLot.Length; j++)
				{
					for(int k = 0; k < _ReqLot[j].DetailCd.Length; k++)
					{
						if(node_tag.ToString() == _ReqLot[j].DetailCd[k].Tag.ToString())
						{
							tempnode_index = _ReqLot[j].DetailCd[k].Index;

							foreach(Item item_link in addflow_Main.Items) 
							{
								if(item_link is Lassalle.Flow.Link)
								{
									link = (Lassalle.Flow.Link)item_link;

									if(link.Org.Index == tempnode_index) 
									{
										link.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
										link.DrawWidth = 2;
										link.DrawColor = Color.Red; 
									}

								} // end if
							} // end foreadch
						}

					} // end for k(_ReqLot[j].DetailCd.Length)
				} // end for j(_ReqLot.Length)

			
				 


			} // end for(i, _Lot.Length) 
 
				
  
		}








		#endregion  

		#region 이벤트 처리


		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_list; 

			if (cmb_Factory.SelectedIndex == -1) return;
 
			dt_list = ClassLib.ComFunction.Select_DPO(cmb_Factory.SelectedValue.ToString(), "L");  
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_FromDate, 0, 0, false, COM.ComVar.ComboList_Visible.Code); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_ToDate, 0, 0, true, COM.ComVar.ComboList_Visible.Code);  
			
			if(cmb_FromDate.ListCount != 0) cmb_FromDate.SelectedIndex = 0; 

		}


		private void cmb_FromDate_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_Factory.SelectedIndex == -1) return; 

			if(cmb_FromDate.Text == "") 
			{
				ClassLib.ComFunction.Clear_AddFlow(addflow_Main);
				return;
			}  

			//btn_Search_Click(null, null);


			cmb_ToDate.SelectedValue = cmb_FromDate.SelectedValue.ToString();

		}

		
		private void cmb_ToDate_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_FromDate.SelectedIndex == -1) return; 
				//btn_Search_Click(null, null);
			}
			catch
			{
			}
		}


		private void btn_Search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Search.ImageIndex = 1;
		}

		private void btn_Search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Search.ImageIndex = 0;
		}
 

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
  
			DataSet ds_ret; 

			try
			{
				this.Cursor = Cursors.WaitCursor;

				ClassLib.ComFunction.Clear_AddFlow(addflow_Main); 
		 			 
				ds_ret = Select_Recv_Lot();

				_DT_Req = ds_ret.Tables["PKG_SPO_LOT_BSC.SELECT_DISPLAY_RECV"];
				_DT_Lot = ds_ret.Tables["PKG_SPO_LOT_BSC.SELECT_DISPLAY_LOT"];  
				_DT_DaySeq = ds_ret.Tables["PKG_SPO_LOT_BSC.SELECT_DISPLAY_LOT_DAILY"];  
 
				if(_DT_Req.Rows.Count != 0) Draw_Req(_DT_Req);  
				if(_DT_Lot.Rows.Count != 0) Draw_Lot(_DT_Lot);  
				if(_DT_DaySeq.Rows.Count != 0) Draw_DaySeq(_DT_DaySeq); 
 

				//------------------------------------------------------
				// 관계 링크 표시
				//------------------------------------------------------
				if(_DT_Req.Rows.Count != 0 || _DT_Lot.Rows.Count != 0 || _DT_DaySeq.Rows.Count != 0)
				{
					Draw_Link();
				}

				this.Cursor = Cursors.Default;


			}
			catch
			{ 
				this.Cursor = Cursors.Default;
			}

			

		}


		
		private void addflow_Main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Item item = addflow_Main.PointedItem;
			
			Lassalle.Flow.Node node;  
			Lassalle.Flow.Link link; 

			//--------------------------------------------------
			foreach(Item item_link in addflow_Main.Items)
			{
				if(item_link is Lassalle.Flow.Link)
				{
					link = (Lassalle.Flow.Link)item_link;

					Set_Link_Prop(link);

				} // end if
			} // end foreadch
			//--------------------------------------------------

			if (item is Lassalle.Flow.Node)
			{
				node = (Lassalle.Flow.Node)item;  

				if(node.Tag == null) return;

				if((node.Tag).ToString().Length > 2)
				{
					if((node.Tag).ToString().Substring(0, 2) == "PR")
					{
						Draw_Forward(node);
					}
					else if((node.Tag).ToString().Substring(0, 2) == "LT")
					{
						Draw_Backward(node);
					}
				} // end if (.Length > 2)
				
 			}

 


		}



		
		#endregion


		#region DB Connect
 

		/// <summary>
		/// Select_Recv_Lot : addflow로 그려질 대상 검색
		/// </summary>
		/// <returns></returns>
		private DataSet Select_Recv_Lot()
		{
			DataSet ds_ret;
			string fromdate, todate;

			try
			{

				fromdate = ClassLib.ComFunction.Empty_Combo(cmb_FromDate, " ");
				todate = ClassLib.ComFunction.Empty_Combo(cmb_ToDate, " ");

                //------------------------------------------------------
				//SPO_RECV_LOT 리스트 찾기 - Order LOT Monitoring 
			    //------------------------------------------------------
				string process_name = "PKG_SPO_LOT_BSC.SELECT_DISPLAY_RECV";

				MyOraDB.ReDim_Parameter(4); 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
				MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";  
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(fromdate, " ");; 
				MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(todate, " ");
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true); 

				//------------------------------------------------------
				//SPO_LOT 리스트 찾기 - Order LOT Monitoring 
				//------------------------------------------------------
				process_name = "PKG_SPO_LOT_BSC.SELECT_DISPLAY_LOT";

				MyOraDB.ReDim_Parameter(4); 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
				MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";  
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(fromdate, " ");; 
				MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(todate, " ");
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(false); 

				//------------------------------------------------------
				//SPO_LOT_DAILY 리스트 찾기 - Order LOT Monitoring 
				//------------------------------------------------------
				process_name = "PKG_SPO_LOT_BSC.SELECT_DISPLAY_LOT_DAILY";

				MyOraDB.ReDim_Parameter(4); 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
				MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";  
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(fromdate, " ");; 
				MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(todate, " ");
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(false); 

				//------------------------------------------------------
				ds_ret = MyOraDB.Exe_Select_Procedure(); 
				if(ds_ret == null) return null ;
				return ds_ret; 
			}
			catch
			{
				return null;
			}
			 
		}




		#endregion


		private void Form_PO_Lot_Display_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		
		 
		



  
	}
}
