using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;
using System.IO;

namespace FlexMold.Management
{
	public class Form_PB_Mold_History : COM.MoldWinForm.Form_Top
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
		public COM.FSP fgrid_Mold;
		private System.ComponentModel.IContainer components = null;



		#region 변수

		private COM.OraDB oraDB = null;
		private int _IxGen_Value, _IxStart_Size;
		//private int _IxTotal;
		private int _IxGen_Start = 1;
		private int _IxGen_End   = 6;
		private int _IxSize_Start = 12;
		private int _IxSize_End = 0;
		private int col_width = 40;
		private C1.Win.C1List.C1Combo cmb_Model;
		private System.Windows.Forms.Label lbl_Model;
		private C1.Win.C1List.C1Combo cmb_moldtype;
		private System.Windows.Forms.Label label3;
		private int gen_width = 25;

		#endregion

		public Form_PB_Mold_History()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_History));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.cmb_moldtype = new C1.Win.C1List.C1Combo();
			this.label3 = new System.Windows.Forms.Label();
			this.cmb_Model = new C1.Win.C1List.C1Combo();
			this.lbl_Model = new System.Windows.Forms.Label();
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
			this.fgrid_Mold = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_moldtype)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Model)).BeginInit();
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
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.cmb_moldtype);
			this.pnl_Search.Controls.Add(this.label3);
			this.pnl_Search.Controls.Add(this.cmb_Model);
			this.pnl_Search.Controls.Add(this.lbl_Model);
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
			// cmb_moldtype
			// 
			this.cmb_moldtype.AddItemCols = 0;
			this.cmb_moldtype.AddItemSeparator = ';';
			this.cmb_moldtype.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_moldtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_moldtype.Caption = "";
			this.cmb_moldtype.CaptionHeight = 17;
			this.cmb_moldtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_moldtype.ColumnCaptionHeight = 18;
			this.cmb_moldtype.ColumnFooterHeight = 18;
			this.cmb_moldtype.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_moldtype.ContentHeight = 17;
			this.cmb_moldtype.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_moldtype.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_moldtype.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_moldtype.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_moldtype.EditorHeight = 17;
			this.cmb_moldtype.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_moldtype.GapHeight = 2;
			this.cmb_moldtype.ItemHeight = 15;
			this.cmb_moldtype.Location = new System.Drawing.Point(701, 36);
			this.cmb_moldtype.MatchEntryTimeout = ((long)(2000));
			this.cmb_moldtype.MaxDropDownItems = ((short)(5));
			this.cmb_moldtype.MaxLength = 32767;
			this.cmb_moldtype.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_moldtype.Name = "cmb_moldtype";
			this.cmb_moldtype.PartialRightColumn = false;
			this.cmb_moldtype.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_moldtype.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_moldtype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_moldtype.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_moldtype.Size = new System.Drawing.Size(140, 21);
			this.cmb_moldtype.TabIndex = 50;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Window;
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(600, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 49;
			this.label3.Text = "CMP";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Model
			// 
			this.cmb_Model.AddItemCols = 0;
			this.cmb_Model.AddItemSeparator = ';';
			this.cmb_Model.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Model.Caption = "";
			this.cmb_Model.CaptionHeight = 17;
			this.cmb_Model.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Model.ColumnCaptionHeight = 18;
			this.cmb_Model.ColumnFooterHeight = 18;
			this.cmb_Model.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Model.ContentHeight = 17;
			this.cmb_Model.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Model.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Model.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Model.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Model.EditorHeight = 17;
			this.cmb_Model.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Model.GapHeight = 2;
			this.cmb_Model.ItemHeight = 15;
			this.cmb_Model.Location = new System.Drawing.Point(397, 36);
			this.cmb_Model.MatchEntryTimeout = ((long)(2000));
			this.cmb_Model.MaxDropDownItems = ((short)(5));
			this.cmb_Model.MaxLength = 32767;
			this.cmb_Model.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Model.Name = "cmb_Model";
			this.cmb_Model.PartialRightColumn = false;
			this.cmb_Model.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Model.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Model.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Model.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Model.Size = new System.Drawing.Size(170, 21);
			this.cmb_Model.TabIndex = 48;
			this.cmb_Model.SelectedValueChanged += new System.EventHandler(this.cmb_Model_SelectedValueChanged);
			// 
			// lbl_Model
			// 
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_Label;
			this.lbl_Model.Location = new System.Drawing.Point(296, 36);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(100, 21);
			this.lbl_Model.TabIndex = 47;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
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
			this.lbl_SubTitle1.Text = "      Search Mold For Model";
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
			this.fgrid_Mold.Size = new System.Drawing.Size(998, 505);
			this.fgrid_Mold.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Mold.TabIndex = 49;
			this.fgrid_Mold.Click += new System.EventHandler(this.fgrid_Mold_Click);
			// 
			// Form_PB_Mold_History
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_Mold);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_PB_Mold_History";
			this.Load += new System.EventHandler(this.Form_Mold_History_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.fgrid_Mold, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_moldtype)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Model)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mold)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		

		#region 메소드

		private void Init_Form()
		{
			this.Text = "Mold History";
			this.lbl_MainTitle.Text = "Mold History";
			ClassLib.ComFunction.SetLangDic(this);


			oraDB = new COM.OraDB();


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


			DataTable dt_list = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
 


			fgrid_Mold.Set_Grid("SPB_MOLD_HISTORY", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			COM.ComFunction.Set_Grid_Font_Size(fgrid_Mold, 7);
			fgrid_Mold.Set_Action_Image(img_Action);
			Set_Gender_Grid(fgrid_Mold);
			fgrid_Mold.Cols.Frozen = (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_SIZE_START;

			_IxSize_End   = fgrid_Mold.Cols.Count;	
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

			_IxGen_Value = (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MOLD_GEN;

			arg_fgrid.Cols.Insert(_IxGen_Value);

			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
				
				arg_fgrid[i + 1, _IxGen_Value] = dt_list.Rows[i].ItemArray[3].ToString();

				if(dt_list.Rows[i].ItemArray[3].ToString() == "ME")
				{
					arg_fgrid.Rows[i + 1].Visible = true;
				}
				else
				{
					arg_fgrid.Rows[i + 1].Visible = false;
				}
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
			//_IxTotal = arg_fgrid.Cols.Count;

			//arg_fgrid.Cols.Add();

			for(int i = 0; i < arg_fgrid.Rows.Count; i++)
			{
				//arg_fgrid[i, _IxTotal] = "Total"; 
				arg_fgrid.Rows[i].TextAlign = TextAlignEnum.CenterCenter; 
			}

			//arg_fgrid.Cols[_IxTotal].Visible = true;

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

			//arg_fgrid.Cols[_IxTotal].AllowMerging = true;
		}

		private void Set_Grid_Size(int arg_rownum, string arg_gen, string arg_mold_size, string arg_dcode, string arg_mold_qty)
		{
			int i;
			for(i=_IxGen_Start; i<_IxGen_End; i++)
			{
				if(fgrid_Mold[i, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MOLD_GEN].ToString() == arg_gen)
				{
					break;
				}
			}


			//			for(int j=_IxSize_Start; j<_IxSize_End; j++)
			//			{
			//				if(fgrid_Mold[i, j].ToString() == arg_mold_size)
			//				{
			//					fgrid_Mold[arg_rownum, j] = arg_mold_qty;
			//				}
			//			}


			for(int j=_IxSize_Start; j<_IxSize_End; j++)
			{
				if(fgrid_Mold[i, j].ToString() == arg_mold_size)
				{
					if(arg_dcode == "2" || arg_dcode == "3" || arg_dcode == "5" 
						|| arg_dcode == "8" || arg_dcode == "A" || arg_dcode == "D")
					{
						fgrid_Mold[arg_rownum, j] = "-" + arg_mold_qty;
					}
					else
					{
						fgrid_Mold[arg_rownum, j] = arg_mold_qty;
					}
				}
			}
		}


		private void Show_Gen(string arg_gen)
		{


			for(int i=_IxGen_Start; i<_IxGen_End; i++)
			{
				if(fgrid_Mold[i, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MOLD_GEN].ToString() == arg_gen)
				{
					fgrid_Mold.Rows[i].Visible = true;
				}
			}
		}


		private void Sum_Type_Qty()
		{
			for(int i=_IxGen_End; i<fgrid_Mold.Rows.Count; i++)
			{
				int sum_qty = 0;

				for(int j=_IxSize_Start; j<fgrid_Mold.Cols.Count; j++)
				{
					if(fgrid_Mold[i,j] != null)
					{
						sum_qty += int.Parse(fgrid_Mold[i,j].ToString());
					}
				}

				fgrid_Mold[i,(int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_TOTAL] = sum_qty.ToString();
			}
		}


		private void Sum_Size_Qty(int arg_count)
		{
			fgrid_Mold.Rows.Add();
			fgrid_Mold[fgrid_Mold.Rows.Count-1, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MOLD_TYPE] = "Mold Stock";

			fgrid_Mold.Rows[fgrid_Mold.Rows.Count-1].StyleNew.BackColor =  Color.FromArgb(230, 230, 250);

			for(int j=_IxSize_Start; j<fgrid_Mold.Cols.Count; j++)
			{
				int sum_size_qty = 0;
				
				for(int k=_IxGen_End; k<fgrid_Mold.Rows.Count; k++)
				{
					if(fgrid_Mold[k,(int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_DIVISION] != null)
					{
						if(fgrid_Mold[k,(int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_DIVISION].ToString() == (arg_count-1).ToString())
						{
							if(fgrid_Mold[k,j] != null)
							{
								
								sum_size_qty += int.Parse(fgrid_Mold[k,j].ToString());
							}
						}
					}
				}
				
				fgrid_Mold[fgrid_Mold.Rows.Count-1, j] = sum_size_qty.ToString();

			}
		}

		#endregion

		#region DB접속

		/// <summary>
		/// Select_Gen_Size : 
		/// </summary>
		/// <param name="arg_gen"></param>
		/// <returns></returns>
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




		/// <summary>
		/// Select_Mold_History : 몰드 히스토리
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Mold_History()
		{
			string Proc_Name = "PKG_SPB_MOLD.SELECT_MOLD_HISTORY_NEW";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_MODEL_CD";
			oraDB.Parameter_Name[2] = "ARG_MOLD_TYPE";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = cmb_Model.SelectedValue.ToString();

			string mold_type = cmb_moldtype.SelectedValue.ToString();
 
			if(cmb_moldtype.SelectedIndex == 0)
			{
				mold_type = cmb_moldtype.Columns[1].Text;
			}

			oraDB.Parameter_Values[2] = mold_type;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Select_ReqNo_CmbList : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <returns></returns>
		public DataTable Select_ReqNo_CmbList(string arg_factory)
		{ 
			
			string Proc_Name = "PKG_SPO_ORDER_BSC.SELECT_DPO_CMBLIST";

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




		public DataTable Select_All_Model(string arg_factory)
		{ 
			string Proc_Name = "PKG_SPB_MOLD.SELECT_ALL_MODEL_CD";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Select_SPB_Mold_CMP : 몰드 타입(반제 별로 가져오기)
		/// </summary>
		private DataTable Select_SPB_Mold_CMP()
		{
			string Proc_Name = "PKG_SPB_MOLD.SELECT_SPB_MOLD_CMP";

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


		/// <summary>
		/// Select_Model_Mold_List : 모델이 쓰는 몰드 가져오기
		/// </summary>
		private DataTable Select_Model_Mold_List()
		{
			string Proc_Name = "PKG_SPB_MOLD.SELECT_MODEL_MOLD_LIST";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_MODEL_CD";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = cmb_Model.SelectedValue.ToString();
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		#endregion

		#region 이벤트

		private void Form_Mold_History_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(cmb_Model.SelectedIndex == -1)return;

			fgrid_Mold.Focus();


			for(int i=_IxGen_Start; i<_IxGen_End; i++)
			{
				fgrid_Mold.Rows[i].Visible = false;
			}


			fgrid_Mold.Rows.Count = _IxGen_End;

			DataTable dt = Select_Mold_History();
			int dt_row = dt.Rows.Count;
			int dt_col = dt.Columns.Count;



			string old_data = "";
			string new_data = "";

			int count = 0;

			string old_mold_info = "";
			try
			{

				old_mold_info = dt.Rows[0].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MODEL_CD].ToString()
					+ dt.Rows[0].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MOLD_CD].ToString();
			}
			catch
			{
			}

			string new_mold_info = "";

			int insert_row = 0;

			for(int i=0; i<dt_row; i++)
			{

				new_mold_info =  dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MODEL_CD].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MOLD_CD].ToString();

				if(old_mold_info != new_mold_info)
				{
					count++;

					Sum_Size_Qty(count);
	


					old_mold_info = new_mold_info;
				}

				new_data = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MODEL_CD].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MOLD_CD].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_YMD].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_DCODE].ToString();

				if(old_data != new_data)
				{
					fgrid_Mold.Rows.Add();
					
					insert_row = fgrid_Mold.Rows.Count-1;

					fgrid_Mold[insert_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_DIVISION] 
						= count.ToString();

					fgrid_Mold[insert_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_FACTORY] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_FACTORY].ToString();

					fgrid_Mold[insert_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MODEL_CD] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MODEL_CD].ToString();

					fgrid_Mold[insert_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MODEL_NAME] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MODEL_NAME].ToString();

					COM.ComFunction comfunction = new COM.ComFunction();

					fgrid_Mold[insert_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_DATE] 
						= comfunction.ConvertDate2Type(dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_YMD].ToString());

					fgrid_Mold[insert_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_HISTORY] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_CD_NAME].ToString();

					fgrid_Mold[insert_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MOLD_CD] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MOLD_CD].ToString();

					fgrid_Mold[insert_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_SPEC_CD] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_SPEC_CD].ToString();

					fgrid_Mold[insert_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_CMP_CD] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_CMP_CD].ToString();

					fgrid_Mold[insert_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MOLD_TYPE] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MOLD_TYPE].ToString();

					fgrid_Mold[insert_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MOLD_GEN] 
						= dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MOLD_GEN].ToString();


					Show_Gen(dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MOLD_GEN].ToString());


					old_data = new_data;

				}

				string mold_gen  = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_MOLD_GEN].ToString();
				string mold_size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_CS_SIZE].ToString();
				string dcode     = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_DCODE].ToString();
				string mold_qty  = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_HISTORY.IxDB_QTY].ToString();

				Set_Grid_Size(insert_row, mold_gen, mold_size, dcode, mold_qty);
			}
			//Sum_Size_Qty(count+1);

			Sum_Type_Qty();
			fgrid_Mold.AutoSizeCols(0, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MOLD_TYPE,5);

			fgrid_Mold.AllowMerging = AllowMergingEnum.Free;
		}

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_Factory.SelectedIndex == -1) return;

			DataTable dt_list = Select_All_Model(cmb_Factory.SelectedValue.ToString());

			if(dt_list.Rows.Count > 0)
			{
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Model, 0, 1, false); 
				cmb_Model.SelectedIndex = 0;
			}
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Mold.Rows.Count = _IxGen_End;
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(fgrid_Mold.Rows.Count == _IxGen_End) return;


			string filename = this.Name + ".txt";
			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;

            //fgrid_Mold.SaveGrid( filename, FileFormatEnum.TextComma, false);
            fgrid_Mold.SaveGrid(filename, FileFormatEnum.TextComma);

			string para = "/rfn [" + Application.StartupPath + @"\" + this.Name + ".txt] /rv V_MODEL[" + cmb_Model.Columns[1].Text + "] V_CMP["
				+ cmb_moldtype.Columns[1].Text + "]";
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("Tooling History", this.Name +".mrd", para);
			report.ShowDialog();
		}

		#endregion

		private void fgrid_Mold_Click(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_Mold.Selection.r1;
			int sct_col = fgrid_Mold.Selection.r1;



			int row_num = 0;

			try
			{

				string sct_gen = fgrid_Mold[sct_row, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MOLD_GEN].ToString();

				int i;
				for(i=_IxGen_Start; i<_IxGen_End; i++)
				{
					fgrid_Mold.GetCellRange(i,_IxSize_Start,i,_IxSize_End-1).StyleNew.BackColor = COM.ComVar.GridLightFixed_Color;
					fgrid_Mold.GetCellRange(i,_IxSize_Start,i,_IxSize_End-1).StyleNew.ForeColor = Color.White;
					if(fgrid_Mold[i, (int)ClassLib.TBSPB_MOLD_HISTORY.IxGR_MOLD_GEN].ToString() == sct_gen)
					{
						row_num = i;
					}
				}

				fgrid_Mold.GetCellRange(row_num,_IxSize_Start,row_num,_IxSize_End-1).StyleNew.BackColor = Color.FromArgb(251, 248, 185);//COM.ComVar.GridDarkFixed_Color;
				fgrid_Mold.GetCellRange(row_num,_IxSize_Start,row_num,_IxSize_End-1).StyleNew.ForeColor = Color.Black;
			}
			catch
			{
			}
		}

		private void cmb_Model_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_Model.SelectedIndex == -1) return;

			DataTable dt_list = Select_Model_Mold_List();
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_moldtype, 1, 2, true); 
			cmb_moldtype.SelectedIndex = 0;
		}











		
	}
}

