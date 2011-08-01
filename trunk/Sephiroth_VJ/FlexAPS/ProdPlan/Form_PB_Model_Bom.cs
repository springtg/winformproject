using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexAPS.ProdPlan
{
	public class Form_PB_Model_Bom : COM.APSWinForm.Form_Top
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
		private System.ComponentModel.IContainer components = null;
		public COM.FSP fgrid_MBom;


		#region 변수 선언

		private COM.OraDB oraDB = null;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_toobs;
		private C1.Win.C1List.C1Combo cmb_fromobs;
		private System.Windows.Forms.Label lbl_obsid;
		private int _RowFixd;
			
		#endregion

		public Form_PB_Model_Bom()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Model_Bom));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.cmb_toobs = new C1.Win.C1List.C1Combo();
			this.cmb_fromobs = new C1.Win.C1List.C1Combo();
			this.lbl_obsid = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
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
			this.fgrid_MBom = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_toobs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_fromobs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MBom)).BeginInit();
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
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.label2);
			this.pnl_Search.Controls.Add(this.cmb_toobs);
			this.pnl_Search.Controls.Add(this.cmb_fromobs);
			this.pnl_Search.Controls.Add(this.lbl_obsid);
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
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(477, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 21);
			this.label2.TabIndex = 255;
			this.label2.Text = "~";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmb_toobs
			// 
			this.cmb_toobs.AddItemCols = 0;
			this.cmb_toobs.AddItemSeparator = ';';
			this.cmb_toobs.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_toobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_toobs.Caption = "";
			this.cmb_toobs.CaptionHeight = 17;
			this.cmb_toobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_toobs.ColumnCaptionHeight = 18;
			this.cmb_toobs.ColumnFooterHeight = 18;
			this.cmb_toobs.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_toobs.ContentHeight = 17;
			this.cmb_toobs.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_toobs.EditorBackColor = System.Drawing.Color.White;
			this.cmb_toobs.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_toobs.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_toobs.EditorHeight = 17;
			this.cmb_toobs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_toobs.GapHeight = 2;
			this.cmb_toobs.ItemHeight = 15;
			this.cmb_toobs.Location = new System.Drawing.Point(493, 36);
			this.cmb_toobs.MatchEntryTimeout = ((long)(2000));
			this.cmb_toobs.MaxDropDownItems = ((short)(5));
			this.cmb_toobs.MaxLength = 32767;
			this.cmb_toobs.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_toobs.Name = "cmb_toobs";
			this.cmb_toobs.PartialRightColumn = false;
			this.cmb_toobs.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_toobs.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_toobs.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_toobs.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_toobs.Size = new System.Drawing.Size(80, 21);
			this.cmb_toobs.TabIndex = 254;
			// 
			// cmb_fromobs
			// 
			this.cmb_fromobs.AddItemCols = 0;
			this.cmb_fromobs.AddItemSeparator = ';';
			this.cmb_fromobs.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_fromobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_fromobs.Caption = "";
			this.cmb_fromobs.CaptionHeight = 17;
			this.cmb_fromobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_fromobs.ColumnCaptionHeight = 18;
			this.cmb_fromobs.ColumnFooterHeight = 18;
			this.cmb_fromobs.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_fromobs.ContentHeight = 17;
			this.cmb_fromobs.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_fromobs.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_fromobs.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_fromobs.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_fromobs.EditorHeight = 17;
			this.cmb_fromobs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_fromobs.GapHeight = 2;
			this.cmb_fromobs.ItemHeight = 15;
			this.cmb_fromobs.Location = new System.Drawing.Point(397, 36);
			this.cmb_fromobs.MatchEntryTimeout = ((long)(2000));
			this.cmb_fromobs.MaxDropDownItems = ((short)(5));
			this.cmb_fromobs.MaxLength = 32767;
			this.cmb_fromobs.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_fromobs.Name = "cmb_fromobs";
			this.cmb_fromobs.PartialRightColumn = false;
			this.cmb_fromobs.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_fromobs.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_fromobs.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_fromobs.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_fromobs.Size = new System.Drawing.Size(80, 21);
			this.cmb_fromobs.TabIndex = 253;
			// 
			// lbl_obsid
			// 
			this.lbl_obsid.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_obsid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_obsid.ImageIndex = 0;
			this.lbl_obsid.ImageList = this.img_Label;
			this.lbl_obsid.Location = new System.Drawing.Point(296, 36);
			this.lbl_obsid.Name = "lbl_obsid";
			this.lbl_obsid.Size = new System.Drawing.Size(100, 21);
			this.lbl_obsid.TabIndex = 252;
			this.lbl_obsid.Text = "OBS ID";
			this.lbl_obsid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Location = new System.Drawing.Point(117, 36);
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
			this.picb_MR.Size = new System.Drawing.Size(15, 19);
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
			this.lbl_SubTitle1.Text = "      Search Model By PO";
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
			// fgrid_MBom
			// 
			this.fgrid_MBom.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_MBom.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_MBom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_MBom.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_MBom.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_MBom.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_MBom.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_MBom.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_MBom.Location = new System.Drawing.Point(9, 136);
			this.fgrid_MBom.Name = "fgrid_MBom";
			this.fgrid_MBom.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_MBom.Size = new System.Drawing.Size(998, 505);
			this.fgrid_MBom.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_MBom.TabIndex = 49;
			// 
			// Form_PB_Model_Bom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_MBom);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_PB_Model_Bom";
			this.Load += new System.EventHandler(this.Form_PB_Model_Bom_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.fgrid_MBom, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_toobs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_fromobs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MBom)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Model_Bom_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{
			this.Text = "BOM Information";
			this.lbl_MainTitle.Text = "BOM Information";
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


			DataTable dt_list = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1,false,COM.ComVar.ComboList_Visible.Code);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory; 


//			dt_list = Select_Obs_ID();
//			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_fromobs, 0, 0, false, false);
//			cmb_fromobs.SelectedIndex = 0;
//			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_toobs, 0, 0, false, false);
//			cmb_toobs.SelectedIndex =  0;

			 
			DataTable dt_ret = ClassLib.ComFunction.Select_DPO(ClassLib.ComVar.This_Factory, "P"); 
 
			if(dt_ret != null && dt_ret.Rows.Count > 0)
			{
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_fromobs, 0, 0, false, COM.ComVar.ComboList_Visible.Code); 
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_toobs, 0, 0, false, COM.ComVar.ComboList_Visible.Code);  
				if(cmb_fromobs.ListCount != 0) cmb_fromobs.SelectedIndex = 0;
				if(cmb_toobs.ListCount != 0) cmb_toobs.SelectedIndex = 0;
			}

			dt_ret.Dispose();





			fgrid_MBom.Set_Grid("SPB_MODEL_BOM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
           // fgrid_MBom.Font = new Font("Verdana", 7);
            fgrid_MBom.Set_Action_Image(img_Action);
			_RowFixd = fgrid_MBom.Rows.Count;
			Search();


		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Search();
		}


		private void Search()
		{
			fgrid_MBom.Rows.Count = _RowFixd;

			ClassLib.ComFunction comfunc = new FlexAPS.ClassLib.ComFunction();

			DataTable dt = Select_Model_Bom();

			int dt_row = dt.Rows.Count;
			int dt_col = dt.Columns.Count;


			string old_model_bom = "";
			string new_model_bom = "";

			for(int i=0; i<dt_row; i++)
			{
				new_model_bom = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_BOM.IxDB_MODELCD].ToString() 
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_BOM.IxDB_STYLCD].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_BOM.IxDB_PO_NO].ToString();

				if(old_model_bom != new_model_bom)
				{
					fgrid_MBom.Rows.Add();
					
					for(int j=0; j<(int)ClassLib.TBSPB_MODEL_BOM.IxDB_BOMCD+1; j++)
					{
						if(j == (int)ClassLib.TBSPB_MODEL_BOM.IxDB_STRYMD || j == (int)ClassLib.TBSPB_MODEL_BOM.IxDB_ENDYMD || j == (int)ClassLib.TBSPB_MODEL_BOM.IxDB_PO_NO)
						{
							fgrid_MBom[fgrid_MBom.Rows.Count-1, j+1] = comfunc.ConvertDate2Type(dt.Rows[i].ItemArray[j].ToString());
						}
						else
						{
							fgrid_MBom[fgrid_MBom.Rows.Count-1, j+1] = dt.Rows[i].ItemArray[j].ToString();
						}
					}

					old_model_bom = new_model_bom;
				}



				for(int j=(int)ClassLib.TBSPB_MODEL_BOM.IxGR_CMPCD; j<fgrid_MBom.Cols.Count; j++)
				{
					if(fgrid_MBom[_RowFixd-1, j].ToString() == dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MODEL_BOM.IxDB_CMPCD].ToString())
					{
						fgrid_MBom[fgrid_MBom.Rows.Count-1, j] = "Y";
						break;
					}
				}


				
				
			}



			fgrid_MBom.AutoSizeCols((int)ClassLib.TBSPB_MODEL_BOM.IxGR_DIVISION, (int)ClassLib.TBSPB_MODEL_BOM.IxGR_BOMCD, 0);

			fgrid_MBom.AllowMerging = AllowMergingEnum.Free;

			for(int i=0; i<fgrid_MBom.Cols.Count; i++)
			{
				if(i==(int)ClassLib.TBSPB_MODEL_BOM.IxGR_BOMCD 
					|| i==(int)ClassLib.TBSPB_MODEL_BOM.IxGR_MODELCD 
					|| i==(int)ClassLib.TBSPB_MODEL_BOM.IxGR_MODELNAME
					|| i==(int)ClassLib.TBSPB_MODEL_BOM.IxGR_STYLCD
					|| i==(int)ClassLib.TBSPB_MODEL_BOM.IxGR_STYLENAME
					|| i==(int)ClassLib.TBSPB_MODEL_BOM.IxGR_DPO
					|| i==(int)ClassLib.TBSPB_MODEL_BOM.IxGR_PO_NO)
				{
					fgrid_MBom.Cols[i].AllowMerging = true;
				}
				else
				{
					fgrid_MBom.Cols[i].AllowMerging = false;
				}
			}

		}



		private DataTable Select_Model_Bom()
		{
			string Proc_Name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_BOM";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_FROM_DPO";
			oraDB.Parameter_Name[2] = "ARG_TO_DPO";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();

			ClassLib.ComFunction comfunc = new FlexAPS.ClassLib.ComFunction();

			oraDB.Parameter_Values[1] = cmb_fromobs.SelectedValue.ToString();
			oraDB.Parameter_Values[2] = cmb_toobs.SelectedValue.ToString();
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
				
			return  DS_Ret.Tables[Proc_Name];
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(fgrid_MBom.Rows.Count < _RowFixd) return;

			string filename = this.Name + ".txt";
			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;



			string message = "";

			for(int i=_RowFixd; i<fgrid_MBom.Rows.Count; i++)
			{
				for(int j=0; j<fgrid_MBom.Cols.Count; j++)
				{
					if(fgrid_MBom[i,j] != null)
					{
						message += fgrid_MBom[i,j].ToString() + " @";
					}
					else
					{
						message += "@";
					}
				}

				message += "\r\n";
			}





			FileStream Message = new FileStream(filename, FileMode.Create, FileAccess.Write);
			StreamWriter sw = new StreamWriter(Message);

			sw.Write(message);
			sw.Flush();

			sw.Close();
			Message.Close();



			string para = "/rfn [" + Application.StartupPath + @"\" + this.Name + ".txt] /rv V_FROMPO[" 
				+ cmb_fromobs.SelectedValue.ToString()
				+ "] V_TOPO[" + cmb_toobs.SelectedValue.ToString() + "]";
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report(this.Text, this.Name +".mrd", para);
			report.ShowDialog();




			//fgrid_MBom.SaveGrid(filename, FileFormatEnum.TextCustom, false);
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_MBom.Rows.Count = _RowFixd;
		}


//		/// <summary>
//		/// Select_Obs_ID
//		/// </summary>
//		private DataTable Select_Obs_ID()
//		{
//			string process_name = "PKG_SPO_LOT.SELECT_OBS_ID";
//
//			oraDB.ReDim_Parameter(2); 
//
//			oraDB.Process_Name = process_name;
// 
//			oraDB.Parameter_Name[0] = "ARG_FACTORY";
//			oraDB.Parameter_Name[1] = "OUT_CURSOR";
//
//			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
//			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;
//			 
//			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
//			oraDB.Parameter_Values[1] = ""; 
//
//			oraDB.Add_Select_Parameter(true);
// 
//			DataSet ds_ret = oraDB.Exe_Select_Procedure();
//
//			if(ds_ret == null) return null ;
//			
//			return ds_ret.Tables[process_name]; 
//		}



	}
}

