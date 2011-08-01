using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexAPS.ProdOrder
{
	public class Form_PO_Lot_Req : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		public COM.FSP fgrid_Main;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_FromDPO;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_StyleCd;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_ToDPO;
		private System.Windows.Forms.Label lbl_DPO;
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
		
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자
		 
		public Form_PO_Lot_Req()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_Lot_Req));
			this.fgrid_Main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.cmb_FromDPO = new C1.Win.C1List.C1Combo();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_StyleCd = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_ToDPO = new C1.Win.C1List.C1Combo();
			this.lbl_DPO = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_FromDPO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ToDPO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
			// fgrid_Main
			// 
			this.fgrid_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 139);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(1000, 500);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:White;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Focus{BackColor:Highlight;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 41;
			this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.Bottom = 5;
			this.pnl_Search.DockPadding.Left = 8;
			this.pnl_Search.DockPadding.Right = 8;
			this.pnl_Search.DockPadding.Top = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 75);
			this.pnl_Search.TabIndex = 40;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.cmb_FromDPO);
			this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.label1);
			this.pnl_SearchImage.Controls.Add(this.cmb_ToDPO);
			this.pnl_SearchImage.Controls.Add(this.lbl_DPO);
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
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 62);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// cmb_FromDPO
			// 
			this.cmb_FromDPO.AddItemCols = 0;
			this.cmb_FromDPO.AddItemSeparator = ';';
			this.cmb_FromDPO.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_FromDPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_FromDPO.Caption = "";
			this.cmb_FromDPO.CaptionHeight = 17;
			this.cmb_FromDPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_FromDPO.ColumnCaptionHeight = 18;
			this.cmb_FromDPO.ColumnFooterHeight = 18;
			this.cmb_FromDPO.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_FromDPO.ContentHeight = 17;
			this.cmb_FromDPO.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_FromDPO.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_FromDPO.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_FromDPO.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_FromDPO.EditorHeight = 17;
			this.cmb_FromDPO.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_FromDPO.GapHeight = 2;
			this.cmb_FromDPO.ItemHeight = 15;
			this.cmb_FromDPO.Location = new System.Drawing.Point(445, 36);
			this.cmb_FromDPO.MatchEntryTimeout = ((long)(2000));
			this.cmb_FromDPO.MaxDropDownItems = ((short)(5));
			this.cmb_FromDPO.MaxLength = 32767;
			this.cmb_FromDPO.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_FromDPO.Name = "cmb_FromDPO";
			this.cmb_FromDPO.PartialRightColumn = false;
			this.cmb_FromDPO.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_FromDPO.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_FromDPO.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_FromDPO.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_FromDPO.Size = new System.Drawing.Size(97, 21);
			this.cmb_FromDPO.TabIndex = 120;
			this.cmb_FromDPO.SelectedValueChanged += new System.EventHandler(this.cmb_FromDPO_SelectedValueChanged);
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.White;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(780, 36);
			this.txt_StyleCd.MaxLength = 20;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(210, 21);
			this.txt_StyleCd.TabIndex = 124;
			this.txt_StyleCd.Text = "";
			// 
			// lbl_StyleCd
			// 
			this.lbl_StyleCd.ImageIndex = 0;
			this.lbl_StyleCd.ImageList = this.img_Label;
			this.lbl_StyleCd.Location = new System.Drawing.Point(679, 36);
			this.lbl_StyleCd.Name = "lbl_StyleCd";
			this.lbl_StyleCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_StyleCd.TabIndex = 123;
			this.lbl_StyleCd.Text = "Style";
			this.lbl_StyleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(542, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 21);
			this.label1.TabIndex = 122;
			this.label1.Text = "~";
			// 
			// cmb_ToDPO
			// 
			this.cmb_ToDPO.AddItemCols = 0;
			this.cmb_ToDPO.AddItemSeparator = ';';
			this.cmb_ToDPO.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_ToDPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_ToDPO.Caption = "";
			this.cmb_ToDPO.CaptionHeight = 17;
			this.cmb_ToDPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_ToDPO.ColumnCaptionHeight = 18;
			this.cmb_ToDPO.ColumnFooterHeight = 18;
			this.cmb_ToDPO.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_ToDPO.ContentHeight = 17;
			this.cmb_ToDPO.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_ToDPO.EditorBackColor = System.Drawing.Color.White;
			this.cmb_ToDPO.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ToDPO.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_ToDPO.EditorHeight = 17;
			this.cmb_ToDPO.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ToDPO.GapHeight = 2;
			this.cmb_ToDPO.ItemHeight = 15;
			this.cmb_ToDPO.Location = new System.Drawing.Point(558, 36);
			this.cmb_ToDPO.MatchEntryTimeout = ((long)(2000));
			this.cmb_ToDPO.MaxDropDownItems = ((short)(5));
			this.cmb_ToDPO.MaxLength = 32767;
			this.cmb_ToDPO.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_ToDPO.Name = "cmb_ToDPO";
			this.cmb_ToDPO.PartialRightColumn = false;
			this.cmb_ToDPO.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_ToDPO.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_ToDPO.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_ToDPO.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_ToDPO.Size = new System.Drawing.Size(97, 21);
			this.cmb_ToDPO.TabIndex = 121;
			this.cmb_ToDPO.SelectedValueChanged += new System.EventHandler(this.cmb_ToDPO_SelectedValueChanged);
			// 
			// lbl_DPO
			// 
			this.lbl_DPO.ImageIndex = 1;
			this.lbl_DPO.ImageList = this.img_Label;
			this.lbl_DPO.Location = new System.Drawing.Point(344, 36);
			this.lbl_DPO.Name = "lbl_DPO";
			this.lbl_DPO.Size = new System.Drawing.Size(100, 21);
			this.lbl_DPO.TabIndex = 119;
			this.lbl_DPO.Text = "DPO";
			this.lbl_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_Factory.TabIndex = 118;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 117;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(983, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(17, 23);
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
			this.lbl_SubTitle1.Text = "      Select DPO and Style";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(984, 47);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 25);
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
			this.picb_MM.Size = new System.Drawing.Size(832, 22);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// Form_PO_Lot_Req
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_Main);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_PO_Lot_Req";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_FromDPO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ToDPO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();  

		#endregion 

		#region 멤버 메서드

		 
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 

			try
			{
 
				// Title 
				this.Text = "Release Week/DPO SizeRun Check List";
				this.lbl_MainTitle.Text = "Release Week/DPO SizeRun Check List"; 

				//ClassLib.ComFunction.SetLangDic(this); 

				fgrid_Main.Set_Grid("SPO_LOT_AND_REQ1", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, true); 
				fgrid_Main.Font = new Font("Verdana", 7);
				fgrid_Main.ExtendLastCol = false;
				fgrid_Main.Styles.Alternate.BackColor = Color.Empty;


				Init_Control(); 

				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
 
		}


		private void Init_Control()
		{

			tbtn_Save.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Insert.Enabled =false; 
			tbtn_Color.Enabled = false; 
			  

			 
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			dt_ret.Dispose();
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;     


		}




		private void Event_Tbtn_New()
		{
			 
			txt_StyleCd.Text = "";

			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 

			
		}

		private void Event_Tbtn_Search()
		{


			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_FromDPO};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

			if(! essential_check) return;

			string factory = cmb_Factory.SelectedValue.ToString();
			string dpo_from = cmb_FromDPO.SelectedValue.ToString();
			string dpo_to = ClassLib.ComFunction.Empty_Combo(cmb_ToDPO, dpo_from);  
			string style_cd = ClassLib.ComFunction.Empty_String(txt_StyleCd.Text.Replace("-", ""), " ");

			
			DataTable dt_ret = Select_SPO_RECV_AND_LOT_SIZE(factory, dpo_from, dpo_to, style_cd); 

			Display_Grid(dt_ret);
			Display_Grid_Property();
 

		}


		/// <summary>
		/// Display_Grid : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Grid(DataTable arg_dt)
		{
 
			string before_item = "", now_item = ""; 
			int gen_row = 0;   
			string sel_gen = "";
			int min_size_col = fgrid_Main.Cols.Count + 1;   //default : col max value 
  
 
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 

			if(arg_dt.Rows.Count == 0) return;
  
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
      	 

				
				//--------------------------------------------------------------
				// lot, req row 표시
				//--------------------------------------------------------------
				now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxFACTORY - 1].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxOBS_ID - 1].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxOBS_TYPE - 1].ToString() 
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxSTYLE_CD - 1].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxLOT - 1].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxREQ_NO - 1].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxDIVISION - 1].ToString();
  


				if(before_item != now_item)
				{
  
					fgrid_Main.Rows.Add(); 
								
					//default data setting
					fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "";

					for(int j = 1; j <= (int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN; j++)
					{ 
						fgrid_Main[fgrid_Main.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
					}
 					 
					//gen
					for(int j = 1; j <= fgrid_Main.Rows.Fixed; j++)
					{
						if(fgrid_Main[j, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN].ToString() 
							== arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_Main[gen_row, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN].ToString();

							break;
						} 
					}


					// difference row 색깔 표시
					if(fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxDIVISION].ToString() == "DIFF")
					{
						fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxDIVISION,
							fgrid_Main.Rows.Count - 1, fgrid_Main.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSubTotal1;

						fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxDIVISION,
							fgrid_Main.Rows.Count - 1, fgrid_Main.Cols.Count - 1).StyleNew.Font = new Font("Verdana", 7, FontStyle.Bold);

					}
					 

					before_item = now_item; 

				} 

				//--------------------------------------------------------------

				//--------------------------------------------------------------
				// size 별 수량 표시
				//--------------------------------------------------------------
				for(int j = (int)ClassLib.TBSPO_LOT_AND_REQ1.IxCS_SIZE_START; j < fgrid_Main.Cols.Count; j++)
				{
					if(fgrid_Main[gen_row, j].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxCS_SIZE - 1].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col; 

						fgrid_Main[fgrid_Main.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxSIZE_QTY - 1].ToString();
						fgrid_Main[fgrid_Main.Rows.Count - 1, j] = (fgrid_Main[fgrid_Main.Rows.Count - 1, j].ToString() == "0") ? "" : fgrid_Main[fgrid_Main.Rows.Count - 1, j].ToString();

						break; 
					} 
				}
				//--------------------------------------------------------------
  


			} // end for 







			//--------------------------------------------------------------
			//LOT에 대한 젠더만 표시
			string[] token = sel_gen.Split('/');

			for(int i = 1; i < fgrid_Main.Rows.Fixed; i++)
			{
				fgrid_Main.Rows[i].Visible = false;   
			}


			for(int i = 1; i < fgrid_Main.Rows.Fixed; i++) 
			{
				for(int j = 0; j < token.Length; j++)
				{
					if(fgrid_Main[i, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN].ToString() == token[j])
					{
						fgrid_Main.Rows[i].Visible = true; 
						break;
					} 
				} // end for j 
			} // end for i
  


			//기타 속성
			fgrid_Main.AutoSizeCols(1, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxCS_SIZE_START - 1, 2); 
			fgrid_Main.Cols.Frozen = (int)ClassLib.TBSPO_LOT_AND_REQ1.IxCS_SIZE_START;
			fgrid_Main.LeftCol = min_size_col; 



		}



		private void Display_Grid_Property()
		{
 
			  

			// subtotal 
			fgrid_Main.Subtotal(AggregateEnum.Clear);  
			fgrid_Main.SubtotalPosition = SubtotalPositionEnum.BelowData;  
			fgrid_Main.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
			fgrid_Main.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black; 
//			fgrid_Main.Styles[CellStyleEnum.Subtotal1].Font = new Font("Verdana", 7, FontStyle.Bold);
			fgrid_Main.Styles[CellStyleEnum.Subtotal2].BackColor = ClassLib.ComVar.ClrSubTotal2;
			fgrid_Main.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Black;
//			fgrid_Main.Styles[CellStyleEnum.Subtotal2].Font = new Font("Verdana", 7, FontStyle.Bold);
			fgrid_Main.Styles[CellStyleEnum.Subtotal3].BackColor = ClassLib.ComVar.ClrSubTotal3;
			fgrid_Main.Styles[CellStyleEnum.Subtotal3].ForeColor = Color.Black;
//			fgrid_Main.Styles[CellStyleEnum.Subtotal3].Font = new Font("Verdana", 7, FontStyle.Bold);
 
 
  

			fgrid_Main.Subtotal(AggregateEnum.Sum, 3, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxDIVISION, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxTOT_QTY, " {0}"); 

			for(int i = (int)ClassLib.TBSPO_LOT_AND_REQ1.IxCS_SIZE_START; i < fgrid_Main.Cols.Count; i++)
			{
				fgrid_Main.Subtotal(AggregateEnum.Sum, 3, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxDIVISION, i, " {0}"); 
			}



			// difference row subtotal 표시 안함
			for(int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
			{


				// subtotal row 에 데이터 표시
				if(fgrid_Main[i, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxDIVISION] == null
					|| fgrid_Main[i, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxDIVISION].ToString().Trim().Equals("") )
				{


					// subtotal row 표시
					fgrid_Main[i, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxFACTORY] = "X"; 

					for(int j = (int)ClassLib.TBSPO_LOT_AND_REQ1.IxFACTORY + 1; j <= (int)ClassLib.TBSPO_LOT_AND_REQ1.IxDIVISION; j++)
					{
						fgrid_Main[i, j] = (fgrid_Main[i - 1, j] == null) ? "" : fgrid_Main[i - 1, j].ToString();
					} // end for j


					fgrid_Main.Rows[i].IsNode = false;

				} // end if



				if(fgrid_Main[i, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxFACTORY].ToString() == "X"
					&& fgrid_Main[i, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxDIVISION].ToString() == "DIFF")
				{
					fgrid_Main.Rows[i].Visible = false;

				} // end if



			} // end for

  



			//merge 
			fgrid_Main.AllowMerging = AllowMergingEnum.Free; 
			for(int i = 0; i < fgrid_Main.Cols.Count; i++) fgrid_Main.Cols[i].AllowMerging = false; 
 

			for(int i = 0; i <= (int)ClassLib.TBSPO_LOT_AND_REQ1.IxTOT_QTY - 1; i++)
			{
				fgrid_Main.Cols[i].AllowMerging = true;
			} // end for i

 



		}



		private void Event_Tbtn_Print()
		{

			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_FromDPO};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

			if(! essential_check) return;
 
			

//			string factory = cmb_Factory.SelectedValue.ToString();
//			string dpo_from = cmb_FromDPO.SelectedValue.ToString();
//			string dpo_to = ClassLib.ComFunction.Empty_Combo(cmb_ToDPO, dpo_from);  
//			string style_cd = ClassLib.ComFunction.Empty_String(txt_StyleCd.Text.Replace("-", ""), " ");
//
//
//			string sDir = ClassLib.ComFunction.Set_RD_Directory("Form_PO_Lot_Req"); 
//			string sPara  = " /rp "; 
//			sPara += "'" + factory   + "' ";
//			sPara += "'" + dpo_from  + "' ";
//			sPara += "'" + dpo_to    + "' "; 
//			sPara += "'" + style_cd  + "' "; 
//
//
//			FlexAPS.Report.Form_RdViewer MyReport = new FlexAPS.Report.Form_RdViewer(sDir, sPara);
//			MyReport.Text = "Release Week/DPO SizeRun Check List";
//			MyReport.Show();


			string filename = Application.StartupPath + @"\Report\Production\" + this.Name + ".txt";
			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;

			 
			fgrid_Main.ClipSeparators = "@;";
			fgrid_Main.SaveGrid(filename, FileFormatEnum.TextCustom);


			string factory = cmb_Factory.SelectedValue.ToString();
			string dpo_from = cmb_FromDPO.SelectedValue.ToString();
			string dpo_to = ClassLib.ComFunction.Empty_Combo(cmb_ToDPO, dpo_from);  
			string style_cd = ClassLib.ComFunction.Empty_String(txt_StyleCd.Text.Replace("-", ""), " "); 
 

			string para = "/rfn [" + Application.StartupPath + @"\Report\Production\" + this.Name + ".txt] /rv V_FACTORY[" + factory 
				+ "] V_DPO_FROM[" + dpo_from + "] V_DPO_TO[" + dpo_to
				+ "] V_STYLE_CD[" + style_cd + "]";
 
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("Release Week/DPO Size Check", Application.StartupPath + @"\Report\Production\" + this.Name +".mrd", para);
			report.ShowDialog();

			 


		}
 

		#endregion
 
		#region 이벤트 처리

		#region 툴바 이벤트

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Tbtn_New();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Search(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Tbtn_Print(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		}

		#endregion

		#region 버튼 및 기타 이벤트

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
  
				if (cmb_Factory.SelectedIndex == -1) return;

				fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 

				DataTable dt_ret = ClassLib.ComFunction.Select_DPO(cmb_Factory.SelectedValue.ToString(), "P");  
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_FromDPO, 0, 0, false, COM.ComVar.ComboList_Visible.Code); 
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ToDPO, 0, 0, false, COM.ComVar.ComboList_Visible.Code);  
				dt_ret.Dispose();

				if(cmb_FromDPO.ListCount != 0) cmb_FromDPO.SelectedIndex = 0;



				// 사이즈 헤더 할당
				ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_Main, 
															cmb_Factory.SelectedValue.ToString(), 
															"", 
															fgrid_Main.Rows.Fixed,
															(int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN,
															(int)ClassLib.TBSPO_LOT_AND_REQ1.IxCS_SIZE_START);



				// set number type at total column 
				CellStyle cellst = fgrid_Main.Styles.Add("NUMBER", fgrid_Main.Cols[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxTOT_QTY].Style);
				cellst.DataType = typeof(double);
				cellst.Format = "#,##0"; 
				fgrid_Main.Cols[(int)ClassLib.TBSPO_LOT_AND_REQ1.IxTOT_QTY].Style = fgrid_Main.Styles["NUMBER"]; 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		private void cmb_FromDPO_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 

				fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 
 
				if(cmb_FromDPO.SelectedIndex == -1) return;
				cmb_ToDPO.SelectedValue = cmb_FromDPO.SelectedValue.ToString(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_FromDPO_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void cmb_ToDPO_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
			 
				fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_ToDPO_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		
		//선택되어졌던 젠더 행
		private int _BeforeGenRow = -1;

		private void fgrid_Main_Click(object sender, System.EventArgs e)
		{
			//선택한 젠더행 색깔 표시

			if(fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN] == null) return;


			string sel_gen = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN].ToString();

			int findrow = fgrid_Main.FindRow(sel_gen, 1, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN, false, true, false);

			if(findrow == -1) return;

			fgrid_Main.GetCellRange(findrow, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN, findrow, fgrid_Main.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow; 
			fgrid_Main.GetCellRange(findrow, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN, findrow, fgrid_Main.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
 
			if(_BeforeGenRow != -1 && _BeforeGenRow != findrow) 
				fgrid_Main.GetCellRange(_BeforeGenRow, (int)ClassLib.TBSPO_LOT_AND_REQ1.IxGEN, _BeforeGenRow, fgrid_Main.Cols.Count - 1).StyleNew.Clear(); 

			_BeforeGenRow = findrow;
		}


		  

		#endregion 

		#endregion

		#region 디비 연결

		/// <summary>
		/// Select_SPO_RECV_AND_LOT_SIZE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_dpo_from"></param>
		/// <param name="arg_dpo_to"></param> 
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		private DataTable Select_SPO_RECV_AND_LOT_SIZE(string arg_factory, string arg_dpo_from, string arg_dpo_to, string arg_style_cd)
		{

			try
			{
				 
				DataSet ds_ret;

				string process_name = "PKG_SPO_LOT_BSC.SELECT_SPO_RECV_AND_LOT_SIZE";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_FROM_DPO"; 
				MyOraDB.Parameter_Name[2] = "ARG_TO_DPO"; 
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";  

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_dpo_from;
				MyOraDB.Parameter_Values[2] = arg_dpo_to; 
				MyOraDB.Parameter_Values[3] = arg_style_cd;
				MyOraDB.Parameter_Values[4] = "";   

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[process_name]; 

			}
			catch
			{ 
				return null;
			}

		}


		#endregion




		
	}
}

